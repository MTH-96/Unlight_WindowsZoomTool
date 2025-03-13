Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Management
Imports System.Reflection
Imports Newtonsoft.Json.Linq
Imports System.Xml
Imports HtmlAgilityPack


Public Class Form1
    Dim MainFormLocation As String = ""
    Dim appName As String = "unlight_revive"
    Dim appFullName As String = "UNLIGHT_Revive.exe"
    Dim Fixed_WindowsHeight As Integer = 32
    Dim Origin_Width As Integer = 760   '1x倍率的程式寬
    Dim Origin_Height As Integer = 680  '1x倍率的程式高
    Dim dic_ZoomFileName As New Dictionary(Of Integer, String) From {{0, ""}, {1, "index.html"}, {2, "package.json"}} ''縮放用，更改Unlight原始檔案
    Dim JsonFile As String = ""
    Dim htmlFile As String = ""
    Dim OriginScale As Double = 1.0
    Dim AppWindow As New List(Of Integer)   '(left,top,Width ,Height)
    Private Const DWMWA_EXTENDED_FRAME_BOUNDS As Integer = 9
    '這個常數用於DwmGetWindowAttribute函數，表示要檢索窗口的擴展框架邊界矩形。這個矩形是在螢幕空間中的，包含了窗口的所有邊框和陰影。
    Public Const PROCESS_QUERY_INFORMATION As UInteger = &H400
    '這個常數用於OpenProcess函數，表示打開進程以查詢其資訊。它允許您獲取進程的基本資訊，例如進程ID、優先級等。
    Public Const PROCESS_VM_READ As UInteger = &H10
    '這個常數也是用於OpenProcess函數，表示打開進程以讀取其記憶體。它允許您讀取進程的記憶體空間，這在需要檢查或調試其他進程時非常有用。
    Dim FindappStatus As Boolean = False
    Dim dic_AppLocation As New Dictionary(Of Integer, Label)        'App位置相關
    Dim isCheckGameStatusRunning As Boolean = False
    Dim GameStatus As String = ""
    Dim CheckGameCounter As Integer = 0
    Dim CheckGameCounterMax As Integer = 3



#Region "表單開啟"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init_Component()
        JsonFileLoader(False)
        HtmlFileLoader(False)
        AddHandler NumericUpDown1.ValueChanged, AddressOf NumericUpDown1_ValueChanged
        NumericUpDown1.Value = CDbl(OriginScale.ToString("F2"))
        ExeLocationTimer.Interval = 1000
        ExeLocationTimer.Start()
    End Sub
#End Region

#Region "初始化"
    Private Sub Init_Component()
        MainFormLocation = AppDomain.CurrentDomain.BaseDirectory
        dic_ZoomFileName(0) = MainFormLocation '"F:\SteamLibrary\steamapps\common\UNLIGHTRevive"
        TB_AppLocation.Text = dic_ZoomFileName(0) + "\" + appFullName
        JsonFile = dic_ZoomFileName(0) + "\" + dic_ZoomFileName(2)
        htmlFile = dic_ZoomFileName(0) + "\" + dic_ZoomFileName(1)
        For Each a In GpBox_App_Position_info.Controls
            If TypeOf (a) Is Label Then
                Dim lb = CType(a, Label)
                If lb.Name.Contains("valuelb") Then
                    Dim tempTxt = lb.Name.Split("_")
                    Dim index = tempTxt(2)
                    dic_AppLocation.Add(index, lb)
                End If
            End If
        Next
    End Sub
#End Region

#Region "Timer相關"
    Private Sub ExeLocatoinTimer_Tick(sender As Object, e As EventArgs) Handles ExeLocationTimer.Tick
        Dim hWnd As IntPtr = FindWindow(Nothing, appName)
        Dim dpi As UInteger = GetDpiForWindow(hWnd)
        Dim scaleFactor As Double = dpi / 96.0          '換算獲得Windows螢幕倍率，如果沒開程式則為0%
        AppWindow.Clear()
        If hWnd <> IntPtr.Zero Then     '如果有找到視窗
            FindappStatus = True
            ' 獲取進程ID
            Dim processId As UInteger
            GetWindowThreadProcessId(hWnd, processId)
            ' 打開進程

            ' 獲取客戶區域大小
            Dim rect As RECT
            If DwmGetWindowAttribute(hWnd, DWMWA_EXTENDED_FRAME_BOUNDS, rect, Marshal.SizeOf(GetType(RECT))) = 0 Then
                Dim leftTop As New Point With {.X = rect.Left, .Y = rect.Top}
                Dim rightBottom As New Point With {.X = rect.Right, .Y = rect.Bottom}

                Dim Width As Integer = rightBottom.X - leftTop.X
                Dim Height As Integer = rightBottom.Y - leftTop.Y
                Dim AppInfo As New Dictionary(Of Integer, String) From {
                        {0, "( " + leftTop.X.ToString + " , " + leftTop.Y.ToString + " ) "},
                        {1, " ( " + rightBottom.X.ToString + " , " + rightBottom.Y.ToString + " ) "},
                        {2, Width},
                        {3, Height},
                        {4, ""},
                        {5, ""},
                        {6, ""}
                        }
                'App縮放倍率=(縮放總倍率/Windows倍率)
                Dim TotalScaleW As Double = CDbl(((Width) / CDbl(Origin_Width)) / scaleFactor).ToString("F2")
                Dim TotalScaleH As Double = CDbl(((Height - Fixed_WindowsHeight) / CDbl(Origin_Height)) / scaleFactor).ToString("F2")
                Dim TotalScale As Double = CDbl((TotalScaleW + TotalScaleH) / 2).ToString("F2")
                OriginScale = TotalScale
                AppInfo(4) = TotalScale
                AppInfo(5) = TotalScaleW
                AppInfo(6) = TotalScaleH
                For Each i In dic_AppLocation
                    Dim index As Integer = i.Key
                    If AppInfo.ContainsKey(index) Then
                        dic_AppLocation(index).Text = AppInfo(index)
                    End If
                Next
                lb_LockOnStatus_ChangeStatus(FindappStatus)
                ' 顯示或處理窗口資訊
                'Console.WriteLine($"左上角: {AppInfo(0)}, 右下角: {AppInfo(1)}, 寬度: {Width}, 高度: {Height}")
                ' Console.WriteLine($"當前螢幕縮放倍率: {scaleFactor * 100}%  ")
                AppWindow.Add(leftTop.X)
                AppWindow.Add(leftTop.Y)
                AppWindow.Add(Width)
                AppWindow.Add(Height)

                ' 在這裡檢查並運行 CheckGameStatus
                If Not isCheckGameStatusRunning And hWnd = GetForegroundWindow() Then
                    CheckGameCounter += 1
                    If CheckGameCounter >= CheckGameCounterMax Then
                        isCheckGameStatusRunning = True

                        '  Await CheckGameStatus(ZoomScale, leftTop, AppWindow(2), AppWindow(3))
                        CheckGameCounter = 0
                    End If
                End If
            End If

        Else    '如果沒找到視窗
            If FindappStatus = True Then
                Dim processName() As Process = Process.GetProcessesByName(appName)
                Try
                    If processName.Length > 0 Then
                        For Each proc As Process In processName
                            proc.Kill()
                        Next
                    End If
                Catch ex As Exception
                End Try
            End If

            FindappStatus = False
            For Each i In dic_AppLocation
                Dim index As Integer = i.Key
                If index <= 1 Then
                    dic_AppLocation(index).Text = "(N/A , N/A)"
                Else
                    dic_AppLocation(index).Text = "(N/A)"
                End If
            Next
            lb_LockOnStatus_ChangeStatus(FindappStatus)
            'Console.WriteLine("未找到窗口")
        End If
        bt_Confirm.BackColor = SystemColors.Control
    End Sub
#End Region

#Region "變化鎖定狀態標籤"
    Private Sub lb_LockOnStatus_ChangeStatus(ByVal LockOn As Boolean)
        If LockOn = True Then
            lb_LockOnStatus.BackColor = Color.LightYellow
            lb_LockOnStatus.ForeColor = Color.Green
            lb_LockOnStatus.Text = "已鎖定"
            bt_OnOffApp.BackColor = Color.LightSalmon
            bt_OnOffApp.Text = "關閉"
        Else
            lb_LockOnStatus.BackColor = SystemColors.Control
            lb_LockOnStatus.ForeColor = Color.OrangeRed
            lb_LockOnStatus.Text = "尚未鎖定"
            bt_OnOffApp.BackColor = Color.LightGreen
            bt_OnOffApp.Text = "開啟"
        End If
    End Sub
#End Region

#Region "確認變更"
    Private Sub bt_Confirm_Click(sender As Object, e As EventArgs) Handles bt_Confirm.Click
        JsonFileLoader(True)
        HtmlFileLoader(True)
        bt_Confirm.BackColor = Color.LightGreen
    End Sub
#End Region 

#Region "開啟程式路徑"
    Private Sub btn_OpenFolder_Click(sender As Object, e As EventArgs) Handles btn_OpenFolder.Click
        Process.Start("explorer.exe", MainFormLocation)
    End Sub
#End Region

#Region "JSON檔案修改/讀取"
    Private Sub JsonFileLoader(ByVal EditMode As Boolean)
        If File.Exists(JsonFile) Then
            Dim jsonContent As String = File.ReadAllText(JsonFile)
            ' 解析JSON內容為JObject
            Dim jsonObject As JObject = JObject.Parse(jsonContent)
            Dim windowObject As JObject = jsonObject("window")
            If EditMode = True Then     ''變更後保存
                windowObject("width") = CInt(tb_NewWidth.Text)
                windowObject("height") = CInt(tb_NewHeight.Text)
                windowObject("resizable") = CStr(ckb_ZoomOrNot.Checked)
                Dim modifiedJsonString As String = jsonObject.ToString()
                System.IO.File.WriteAllText(JsonFile, modifiedJsonString)
            Else        ''打開來讀取
                Dim icon As String = windowObject("icon").ToString()
                Dim width As Integer = windowObject("width").ToObject(Of Integer)()
                Dim height As Integer = windowObject("height").ToObject(Of Integer)()
                Dim resizable As Boolean = windowObject("resizable").ToObject(Of Boolean)
                ' 顯示結果
                tb_OriginHeight.Text = height
                tb_OriginWidth.Text = width
                ckb_ZoomOrNot.Checked = resizable
            End If
        Else
            MessageBox.Show("JSON檔案不存在")
        End If
    End Sub
#End Region

#Region "HTML檔案修改/讀取"
    Private Sub HtmlFileLoader(ByVal EditMode As Boolean)
        Dim scalevalue As Double = NumericUpDown1.Value
        Dim MarginLeft As Integer = Math.Ceiling(-66 + (scalevalue - 1) * 347.5)        '內部影像offset
        Dim MarginTop As Integer = Math.Ceiling(-66 + (scalevalue - 1) * 307.5)        '內部影像offset
        Dim MarginBottom As Integer = -15
        Dim innerText1 As String = "
        body { 
                background-color: #000000;
          }
         "

        Dim innerText2 As String = $"
        #frame_game {{
                transform: scale({scalevalue.ToString("F2")});
		        transform-origin: center;
		        margin-left: {MarginLeft}px;
		        margin-top: {MarginTop}px;
		        margin-bottom: {MarginBottom}px;
         }}
        "

        Dim TopMostButtonStyle As String = $"
		#alwaysOnTopButton {{
			    position: absolute;
			    top: 10px;
			    left: 100px;
			    width: 80px; /* 設置按鈕寬度 */
			    height: 20px; /* 設置按鈕高度 */
			    padding: 0; /* 移除內邊距 */
			    background-color: #f44336; /* 初始為紅色 */
			    color: white;
			    border: none;
			    cursor: pointer;
			    font-size: 12px;
			    z-index: 1000; /* 確保按鈕顯示在最上層 */
			}}
		#alwaysOnTopButton.topmost {{
			    background-color: #4CAF50; /* 綠色 */
			}}

		#alwaysOnTopButton.not-topmost {{
			    background-color: #f44336; /* 紅色 */
			}}
        "
        If File.Exists(htmlFile) Then
            ' 讀取和解析HTML檔案
            Dim htmlDoc As New HtmlDocument()
            htmlDoc.Load(htmlFile)
            Dim headNode1 As HtmlNode = htmlDoc.DocumentNode.SelectSingleNode("//head")
            Dim headNode2 As HtmlNode = headNode1.SelectSingleNode("//style")       '讀到style
            Dim bodyNode1 As HtmlNode = htmlDoc.DocumentNode.SelectSingleNode("//body")
            Dim buttonNode As HtmlNode = htmlDoc.DocumentNode.SelectSingleNode("//button[@id='alwaysOnTopButton']")
            Dim scriptNodes As HtmlNodeCollection = htmlDoc.DocumentNode.SelectNodes("//script")
            Dim ButtonHtml As String = "<button id=""alwaysOnTopButton"" class=""Not-topmost"" onclick=""toggleAlwaysOnTop()"">置頂切換</button>"
            Dim scriptHtml As String = "  <script>
                let isTopmost = false;
                function toggleAlwaysOnTop() {
                    console.log(""toggleAlwaysOnTop function called""); // 添加日誌輸出
                    if (typeof nw !== 'undefined' && typeof nw.require === 'function') {
                        isTopmost = !isTopmost;
                        nw.Window.get().setAlwaysOnTop(isTopmost);
                        console.log(""Window topmost state:"", isTopmost); // 添加日誌輸出

                        // 更新按鈕背景顏色
                        const button = document.getElementById(""alwaysOnTopButton"");
                        if (isTopmost) {
                            button.classList.remove(""not-topmost"");
                            button.classList.add(""topmost"");
                        } else {
                            button.classList.remove(""topmost"");
                            button.classList.add(""not-topmost"");
                        }
                    } else {
                        alert(""此功能僅在 NW.js 環境中可用"");
                    }
                }
            </script> 
             "

            If EditMode = True Then
                If headNode2 IsNot Nothing Then
                    If buttonNode IsNot Nothing AndAlso ckb_TopMost.Checked = True Then   ''如果原本存在按鈕，並且保持使用
                        headNode2.InnerHtml = innerText1 + innerText2 + TopMostButtonStyle
                    ElseIf buttonNode IsNot Nothing AndAlso ckb_TopMost.Checked = False Then    '如果原本存在按鈕 但 不用了
                        headNode2.InnerHtml = innerText1 + innerText2
                        buttonNode.ParentNode.RemoveChild(buttonNode)
                        For Each scriptNode As HtmlNode In scriptNodes
                            If scriptNode.InnerHtml.Contains("toggleAlwaysOnTop") Then
                                scriptNode.ParentNode.RemoveChild(scriptNode)
                            End If
                        Next
                    ElseIf buttonNode Is Nothing AndAlso ckb_TopMost.Checked = True Then    '如果原本沒按鈕 並且 接下來要使用
                        headNode2.InnerHtml = innerText1 + innerText2 + TopMostButtonStyle
                        bodyNode1.InnerHtml = ButtonHtml & bodyNode1.InnerHtml
                        bodyNode1.InnerHtml &= scriptHtml
                    ElseIf buttonNode Is Nothing AndAlso ckb_TopMost.Checked = False Then        '如果原本沒按鈕 並且 也不使用
                        headNode2.InnerHtml = innerText1 + innerText2
                    End If
                    ' Console.WriteLine(headNode2.InnerHtml)
                    'Console.WriteLine(bodyNode1.InnerHtml)
                    ' 修改<head>節點的內容
                Else
                    MessageBox.Show("<head>節點不存在")
                End If
                htmlDoc.Save(htmlFile)
            Else
                If headNode2 IsNot Nothing AndAlso headNode2.InnerHtml.Contains("scale") Then
                    Dim tempx1 = headNode2.InnerHtml.Split("(")
                    Dim tempx2 = tempx1(1).Split(")")(0)
                    OriginScale = CDbl(tempx2)
                Else
                    OriginScale = CDbl((Origin_Height / CDbl(tb_OriginHeight.Text)).ToString("F2"))
                End If
                tb_OriginScale.Text = OriginScale.ToString("F2") + " 倍"

                If buttonNode IsNot Nothing Then
                    ckb_TopMost.Checked = True
                End If
            End If
            ' 查找<head>節點

        Else
            MessageBox.Show("HTML檔案不存在")
        End If
    End Sub
#End Region

#Region "調整倍率"
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs)
        Dim BaseScale As Double = 1.0
        Dim OffsetH As Integer = 0
        Dim OffsetW As Integer = 0
        tb_NewHeight.Text = (Math.Ceiling(CInt((Origin_Height) * NumericUpDown1.Value)) + OffsetH).ToString '無條件進位
        tb_NewWidth.Text = (Math.Ceiling(CInt((Origin_Width) * NumericUpDown1.Value)) + OffsetW).ToString     '無條件進位
    End Sub
#End Region

#Region "APP開啟/關閉功能"
    Private Sub bt_OnOffApp_Click(sender As Object, e As EventArgs) Handles bt_OnOffApp.Click
        Dim exePath As String = TB_AppLocation.Text
        Dim exeName As String = IO.Path.GetFileNameWithoutExtension(exePath)
        If IsValidPath(exePath) AndAlso FindappStatus = False Then
            Process.Start(exePath)
        ElseIf FindappStatus = True Then
            Dim searcher As New ManagementObjectSearcher("Select * FROM Win32_Process WHERE Name = '" & exeName & ".exe'")
            Try
                For Each process As ManagementObject In searcher.Get()
                    If process("ExecutablePath").ToString().Equals(exePath, StringComparison.OrdinalIgnoreCase) Then
                        process.InvokeMethod("Terminate", Nothing)
                        Console.WriteLine($"已終止進程: {exeName}")
                    End If
                Next
            Catch ex As Exception

            End Try
        Else
            MessageBox.Show("找不到遊戲執行檔")
        End If
    End Sub
    Private Function IsValidPath(pathA As String) As Boolean
        Try
            ' 檢查路徑是否為絕對路徑
            If Not Path.IsPathRooted(pathA) Then
                Return False
            End If

            ' 檢查檔案或目錄是否存在
            If File.Exists(pathA) Or Directory.Exists(pathA) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            ' 處理例外狀況
            Return False
        End Try
    End Function
#End Region

End Class
