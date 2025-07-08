<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.bt_Confirm = New System.Windows.Forms.Button()
        Me.ckb_TopMost = New System.Windows.Forms.CheckBox()
        Me.ckb_ZoomOrNot = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.tb_NewHeight = New System.Windows.Forms.TextBox()
        Me.tb_NewWidth = New System.Windows.Forms.TextBox()
        Me.tb_OriginHeight = New System.Windows.Forms.TextBox()
        Me.tb_OriginWidth = New System.Windows.Forms.TextBox()
        Me.tb_OriginScale = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt_OnOffApp = New System.Windows.Forms.Button()
        Me.TB_AppLocation = New System.Windows.Forms.TextBox()
        Me.lb_LockOnStatus = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_OpenFolder = New System.Windows.Forms.Button()
        Me.ExeLocationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GpBox_App_Position_info = New System.Windows.Forms.GroupBox()
        Me.valuelb_YZoom_06 = New System.Windows.Forms.Label()
        Me.App_YZoom_lb = New System.Windows.Forms.Label()
        Me.valuelb_XZoom_05 = New System.Windows.Forms.Label()
        Me.App_XZoom_lb = New System.Windows.Forms.Label()
        Me.valuelb_TZoom_04 = New System.Windows.Forms.Label()
        Me.App_TZoom_lb = New System.Windows.Forms.Label()
        Me.valuelb_Height_03 = New System.Windows.Forms.Label()
        Me.App_Height_lb = New System.Windows.Forms.Label()
        Me.valuelb_Width_02 = New System.Windows.Forms.Label()
        Me.App_Width_lb = New System.Windows.Forms.Label()
        Me.valuelb_RB_01 = New System.Windows.Forms.Label()
        Me.App_RB_lb = New System.Windows.Forms.Label()
        Me.valuelb_LT_00 = New System.Windows.Forms.Label()
        Me.App_LT_lb = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GpBox_App_Position_info.SuspendLayout()
        Me.SuspendLayout()
        '
        'bt_Confirm
        '
        Me.bt_Confirm.Enabled = False
        Me.bt_Confirm.Location = New System.Drawing.Point(229, 305)
        Me.bt_Confirm.Name = "bt_Confirm"
        Me.bt_Confirm.Size = New System.Drawing.Size(122, 40)
        Me.bt_Confirm.TabIndex = 14
        Me.bt_Confirm.Text = "保存修改"
        Me.bt_Confirm.UseVisualStyleBackColor = True
        '
        'ckb_TopMost
        '
        Me.ckb_TopMost.AutoSize = True
        Me.ckb_TopMost.Enabled = False
        Me.ckb_TopMost.Location = New System.Drawing.Point(17, 295)
        Me.ckb_TopMost.Name = "ckb_TopMost"
        Me.ckb_TopMost.Size = New System.Drawing.Size(188, 24)
        Me.ckb_TopMost.TabIndex = 27
        Me.ckb_TopMost.Text = "視窗是否增加置頂按鈕"
        Me.ckb_TopMost.UseVisualStyleBackColor = True
        '
        'ckb_ZoomOrNot
        '
        Me.ckb_ZoomOrNot.AutoSize = True
        Me.ckb_ZoomOrNot.Enabled = False
        Me.ckb_ZoomOrNot.Location = New System.Drawing.Point(17, 321)
        Me.ckb_ZoomOrNot.Name = "ckb_ZoomOrNot"
        Me.ckb_ZoomOrNot.Size = New System.Drawing.Size(140, 24)
        Me.ckb_ZoomOrNot.TabIndex = 26
        Me.ckb_ZoomOrNot.Text = "視窗是否可伸縮"
        Me.ckb_ZoomOrNot.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.DecimalPlaces = 2
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown1.Location = New System.Drawing.Point(111, 260)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {25, 0, 0, 65536})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(76, 29)
        Me.NumericUpDown1.TabIndex = 25
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        '
        'tb_NewHeight
        '
        Me.tb_NewHeight.Location = New System.Drawing.Point(275, 259)
        Me.tb_NewHeight.MaxLength = 5
        Me.tb_NewHeight.Name = "tb_NewHeight"
        Me.tb_NewHeight.ReadOnly = True
        Me.tb_NewHeight.Size = New System.Drawing.Size(76, 29)
        Me.tb_NewHeight.TabIndex = 24
        Me.tb_NewHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_NewWidth
        '
        Me.tb_NewWidth.Location = New System.Drawing.Point(193, 259)
        Me.tb_NewWidth.MaxLength = 5
        Me.tb_NewWidth.Name = "tb_NewWidth"
        Me.tb_NewWidth.ReadOnly = True
        Me.tb_NewWidth.Size = New System.Drawing.Size(76, 29)
        Me.tb_NewWidth.TabIndex = 23
        Me.tb_NewWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_OriginHeight
        '
        Me.tb_OriginHeight.Location = New System.Drawing.Point(275, 224)
        Me.tb_OriginHeight.MaxLength = 5
        Me.tb_OriginHeight.Name = "tb_OriginHeight"
        Me.tb_OriginHeight.ReadOnly = True
        Me.tb_OriginHeight.Size = New System.Drawing.Size(76, 29)
        Me.tb_OriginHeight.TabIndex = 22
        Me.tb_OriginHeight.Text = "680"
        Me.tb_OriginHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_OriginWidth
        '
        Me.tb_OriginWidth.Location = New System.Drawing.Point(193, 224)
        Me.tb_OriginWidth.MaxLength = 5
        Me.tb_OriginWidth.Name = "tb_OriginWidth"
        Me.tb_OriginWidth.ReadOnly = True
        Me.tb_OriginWidth.Size = New System.Drawing.Size(76, 29)
        Me.tb_OriginWidth.TabIndex = 21
        Me.tb_OriginWidth.Text = "760"
        Me.tb_OriginWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_OriginScale
        '
        Me.tb_OriginScale.Location = New System.Drawing.Point(111, 224)
        Me.tb_OriginScale.MaxLength = 5
        Me.tb_OriginScale.Name = "tb_OriginScale"
        Me.tb_OriginScale.ReadOnly = True
        Me.tb_OriginScale.Size = New System.Drawing.Size(76, 29)
        Me.tb_OriginScale.TabIndex = 20
        Me.tb_OriginScale.Text = "1.0"
        Me.tb_OriginScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(296, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 21)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "高度"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(215, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 21)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "寬度"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(129, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 21)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "倍率"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 21)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "調整倍率:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 227)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 21)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "原始倍率:"
        '
        'bt_OnOffApp
        '
        Me.bt_OnOffApp.Location = New System.Drawing.Point(281, 39)
        Me.bt_OnOffApp.Margin = New System.Windows.Forms.Padding(5)
        Me.bt_OnOffApp.Name = "bt_OnOffApp"
        Me.bt_OnOffApp.Size = New System.Drawing.Size(70, 29)
        Me.bt_OnOffApp.TabIndex = 31
        Me.bt_OnOffApp.Text = "開啟"
        Me.bt_OnOffApp.UseVisualStyleBackColor = True
        '
        'TB_AppLocation
        '
        Me.TB_AppLocation.Location = New System.Drawing.Point(111, 39)
        Me.TB_AppLocation.Name = "TB_AppLocation"
        Me.TB_AppLocation.ReadOnly = True
        Me.TB_AppLocation.Size = New System.Drawing.Size(162, 29)
        Me.TB_AppLocation.TabIndex = 29
        '
        'lb_LockOnStatus
        '
        Me.lb_LockOnStatus.AutoSize = True
        Me.lb_LockOnStatus.ForeColor = System.Drawing.Color.OrangeRed
        Me.lb_LockOnStatus.Location = New System.Drawing.Point(12, 9)
        Me.lb_LockOnStatus.Name = "lb_LockOnStatus"
        Me.lb_LockOnStatus.Size = New System.Drawing.Size(73, 20)
        Me.lb_LockOnStatus.TabIndex = 30
        Me.lb_LockOnStatus.Text = "尚未鎖定"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 21)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "遊戲路徑:"
        '
        'btn_OpenFolder
        '
        Me.btn_OpenFolder.Location = New System.Drawing.Point(219, 5)
        Me.btn_OpenFolder.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_OpenFolder.Name = "btn_OpenFolder"
        Me.btn_OpenFolder.Size = New System.Drawing.Size(132, 29)
        Me.btn_OpenFolder.TabIndex = 33
        Me.btn_OpenFolder.Text = "開啟當前資料夾"
        Me.btn_OpenFolder.UseVisualStyleBackColor = True
        '
        'ExeLocationTimer
        '
        '
        'GpBox_App_Position_info
        '
        Me.GpBox_App_Position_info.Controls.Add(Me.valuelb_YZoom_06)
        Me.GpBox_App_Position_info.Controls.Add(Me.App_YZoom_lb)
        Me.GpBox_App_Position_info.Controls.Add(Me.valuelb_XZoom_05)
        Me.GpBox_App_Position_info.Controls.Add(Me.App_XZoom_lb)
        Me.GpBox_App_Position_info.Controls.Add(Me.valuelb_TZoom_04)
        Me.GpBox_App_Position_info.Controls.Add(Me.App_TZoom_lb)
        Me.GpBox_App_Position_info.Controls.Add(Me.valuelb_Height_03)
        Me.GpBox_App_Position_info.Controls.Add(Me.App_Height_lb)
        Me.GpBox_App_Position_info.Controls.Add(Me.valuelb_Width_02)
        Me.GpBox_App_Position_info.Controls.Add(Me.App_Width_lb)
        Me.GpBox_App_Position_info.Controls.Add(Me.valuelb_RB_01)
        Me.GpBox_App_Position_info.Controls.Add(Me.App_RB_lb)
        Me.GpBox_App_Position_info.Controls.Add(Me.valuelb_LT_00)
        Me.GpBox_App_Position_info.Controls.Add(Me.App_LT_lb)
        Me.GpBox_App_Position_info.Font = New System.Drawing.Font("微軟正黑體", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GpBox_App_Position_info.Location = New System.Drawing.Point(3, 76)
        Me.GpBox_App_Position_info.Name = "GpBox_App_Position_info"
        Me.GpBox_App_Position_info.Size = New System.Drawing.Size(348, 107)
        Me.GpBox_App_Position_info.TabIndex = 34
        Me.GpBox_App_Position_info.TabStop = False
        Me.GpBox_App_Position_info.Text = "應用程式資訊"
        '
        'valuelb_YZoom_06
        '
        Me.valuelb_YZoom_06.AutoSize = True
        Me.valuelb_YZoom_06.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.valuelb_YZoom_06.Location = New System.Drawing.Point(286, 84)
        Me.valuelb_YZoom_06.Name = "valuelb_YZoom_06"
        Me.valuelb_YZoom_06.Size = New System.Drawing.Size(50, 17)
        Me.valuelb_YZoom_06.TabIndex = 14
        Me.valuelb_YZoom_06.Text = "( N/A )"
        '
        'App_YZoom_lb
        '
        Me.App_YZoom_lb.AutoSize = True
        Me.App_YZoom_lb.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.App_YZoom_lb.Location = New System.Drawing.Point(203, 84)
        Me.App_YZoom_lb.Name = "App_YZoom_lb"
        Me.App_YZoom_lb.Size = New System.Drawing.Size(58, 17)
        Me.App_YZoom_lb.TabIndex = 13
        Me.App_YZoom_lb.Text = "Y軸縮放:"
        '
        'valuelb_XZoom_05
        '
        Me.valuelb_XZoom_05.AutoSize = True
        Me.valuelb_XZoom_05.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.valuelb_XZoom_05.Location = New System.Drawing.Point(286, 62)
        Me.valuelb_XZoom_05.Name = "valuelb_XZoom_05"
        Me.valuelb_XZoom_05.Size = New System.Drawing.Size(50, 17)
        Me.valuelb_XZoom_05.TabIndex = 12
        Me.valuelb_XZoom_05.Text = "( N/A )"
        '
        'App_XZoom_lb
        '
        Me.App_XZoom_lb.AutoSize = True
        Me.App_XZoom_lb.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.App_XZoom_lb.Location = New System.Drawing.Point(203, 62)
        Me.App_XZoom_lb.Name = "App_XZoom_lb"
        Me.App_XZoom_lb.Size = New System.Drawing.Size(59, 17)
        Me.App_XZoom_lb.TabIndex = 11
        Me.App_XZoom_lb.Text = "X軸縮放:"
        '
        'valuelb_TZoom_04
        '
        Me.valuelb_TZoom_04.AutoSize = True
        Me.valuelb_TZoom_04.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.valuelb_TZoom_04.Location = New System.Drawing.Point(99, 77)
        Me.valuelb_TZoom_04.Name = "valuelb_TZoom_04"
        Me.valuelb_TZoom_04.Size = New System.Drawing.Size(50, 17)
        Me.valuelb_TZoom_04.TabIndex = 10
        Me.valuelb_TZoom_04.Text = "( N/A )"
        '
        'App_TZoom_lb
        '
        Me.App_TZoom_lb.AutoSize = True
        Me.App_TZoom_lb.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.App_TZoom_lb.Location = New System.Drawing.Point(12, 77)
        Me.App_TZoom_lb.Name = "App_TZoom_lb"
        Me.App_TZoom_lb.Size = New System.Drawing.Size(63, 17)
        Me.App_TZoom_lb.TabIndex = 9
        Me.App_TZoom_lb.Text = "縮放倍率:"
        '
        'valuelb_Height_03
        '
        Me.valuelb_Height_03.AutoSize = True
        Me.valuelb_Height_03.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.valuelb_Height_03.Location = New System.Drawing.Point(286, 40)
        Me.valuelb_Height_03.Name = "valuelb_Height_03"
        Me.valuelb_Height_03.Size = New System.Drawing.Size(50, 17)
        Me.valuelb_Height_03.TabIndex = 8
        Me.valuelb_Height_03.Text = "( N/A )"
        '
        'App_Height_lb
        '
        Me.App_Height_lb.AutoSize = True
        Me.App_Height_lb.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.App_Height_lb.Location = New System.Drawing.Point(203, 40)
        Me.App_Height_lb.Name = "App_Height_lb"
        Me.App_Height_lb.Size = New System.Drawing.Size(63, 17)
        Me.App_Height_lb.TabIndex = 7
        Me.App_Height_lb.Text = "程式高度:"
        '
        'valuelb_Width_02
        '
        Me.valuelb_Width_02.AutoSize = True
        Me.valuelb_Width_02.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.valuelb_Width_02.Location = New System.Drawing.Point(286, 18)
        Me.valuelb_Width_02.Name = "valuelb_Width_02"
        Me.valuelb_Width_02.Size = New System.Drawing.Size(50, 17)
        Me.valuelb_Width_02.TabIndex = 6
        Me.valuelb_Width_02.Text = "( N/A )"
        '
        'App_Width_lb
        '
        Me.App_Width_lb.AutoSize = True
        Me.App_Width_lb.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.App_Width_lb.Location = New System.Drawing.Point(203, 18)
        Me.App_Width_lb.Name = "App_Width_lb"
        Me.App_Width_lb.Size = New System.Drawing.Size(63, 17)
        Me.App_Width_lb.TabIndex = 5
        Me.App_Width_lb.Text = "程式寬度:"
        '
        'valuelb_RB_01
        '
        Me.valuelb_RB_01.AutoSize = True
        Me.valuelb_RB_01.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.valuelb_RB_01.Location = New System.Drawing.Point(99, 50)
        Me.valuelb_RB_01.Name = "valuelb_RB_01"
        Me.valuelb_RB_01.Size = New System.Drawing.Size(85, 17)
        Me.valuelb_RB_01.TabIndex = 4
        Me.valuelb_RB_01.Text = "( N/A , N/A )"
        '
        'App_RB_lb
        '
        Me.App_RB_lb.AutoSize = True
        Me.App_RB_lb.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.App_RB_lb.Location = New System.Drawing.Point(11, 50)
        Me.App_RB_lb.Name = "App_RB_lb"
        Me.App_RB_lb.Size = New System.Drawing.Size(63, 17)
        Me.App_RB_lb.TabIndex = 3
        Me.App_RB_lb.Text = "右下座標:"
        '
        'valuelb_LT_00
        '
        Me.valuelb_LT_00.AutoSize = True
        Me.valuelb_LT_00.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.valuelb_LT_00.Location = New System.Drawing.Point(99, 22)
        Me.valuelb_LT_00.Name = "valuelb_LT_00"
        Me.valuelb_LT_00.Size = New System.Drawing.Size(85, 17)
        Me.valuelb_LT_00.TabIndex = 2
        Me.valuelb_LT_00.Text = "( N/A , N/A )"
        '
        'App_LT_lb
        '
        Me.App_LT_lb.AutoSize = True
        Me.App_LT_lb.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.App_LT_lb.Location = New System.Drawing.Point(11, 22)
        Me.App_LT_lb.Name = "App_LT_lb"
        Me.App_LT_lb.Size = New System.Drawing.Size(63, 17)
        Me.App_LT_lb.TabIndex = 1
        Me.App_LT_lb.Text = "左上座標:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 357)
        Me.Controls.Add(Me.GpBox_App_Position_info)
        Me.Controls.Add(Me.btn_OpenFolder)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.bt_OnOffApp)
        Me.Controls.Add(Me.lb_LockOnStatus)
        Me.Controls.Add(Me.TB_AppLocation)
        Me.Controls.Add(Me.bt_Confirm)
        Me.Controls.Add(Me.ckb_TopMost)
        Me.Controls.Add(Me.ckb_ZoomOrNot)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.tb_NewHeight)
        Me.Controls.Add(Me.tb_NewWidth)
        Me.Controls.Add(Me.tb_OriginHeight)
        Me.Controls.Add(Me.tb_OriginWidth)
        Me.Controls.Add(Me.tb_OriginScale)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form1"
        Me.Text = "Unlight視窗縮放工具"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GpBox_App_Position_info.ResumeLayout(False)
        Me.GpBox_App_Position_info.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bt_Confirm As Button
    Friend WithEvents ckb_TopMost As CheckBox
    Friend WithEvents ckb_ZoomOrNot As CheckBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents tb_NewHeight As TextBox
    Friend WithEvents tb_NewWidth As TextBox
    Friend WithEvents tb_OriginHeight As TextBox
    Friend WithEvents tb_OriginWidth As TextBox
    Friend WithEvents tb_OriginScale As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bt_OnOffApp As Button
    Friend WithEvents TB_AppLocation As TextBox
    Friend WithEvents lb_LockOnStatus As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_OpenFolder As Button
    Friend WithEvents ExeLocationTimer As Timer
    Friend WithEvents GpBox_App_Position_info As GroupBox
    Friend WithEvents valuelb_YZoom_06 As Label
    Friend WithEvents App_YZoom_lb As Label
    Friend WithEvents valuelb_XZoom_05 As Label
    Friend WithEvents App_XZoom_lb As Label
    Friend WithEvents valuelb_TZoom_04 As Label
    Friend WithEvents App_TZoom_lb As Label
    Friend WithEvents valuelb_Height_03 As Label
    Friend WithEvents App_Height_lb As Label
    Friend WithEvents valuelb_Width_02 As Label
    Friend WithEvents App_Width_lb As Label
    Friend WithEvents valuelb_RB_01 As Label
    Friend WithEvents App_RB_lb As Label
    Friend WithEvents valuelb_LT_00 As Label
    Friend WithEvents App_LT_lb As Label
End Class
