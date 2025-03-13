Imports System.Runtime.InteropServices
Imports System.Text

Module ApiDefinitions
    ' 定義Windows API函數
    <DllImport("user32.dll", SetLastError:=True)>
    Public Function FindWindow(lpClassName As String, lpWindowName As String) As IntPtr
    End Function

    ' 定義Windows API函數
    <DllImport("user32.dll")>
    Public Function GetDpiForWindow(hWnd As IntPtr) As UInteger
    End Function

    <DllImport("user32.dll")>
    Public Function GetForegroundWindow() As IntPtr
    End Function


    <DllImport("dwmapi.dll", SetLastError:=True)>
    Public Function DwmGetWindowAttribute(hWnd As IntPtr, dwAttribute As Integer, ByRef pvAttribute As RECT, cbAttribute As Integer) As Integer
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Public Function GetWindowThreadProcessId(hWnd As IntPtr, ByRef lpdwProcessId As UInteger) As UInteger
    End Function

    <DllImport("kernel32.dll", SetLastError:=True)>
    Public Function OpenProcess(dwDesiredAccess As UInteger, bInheritHandle As Boolean, dwProcessId As UInteger) As IntPtr
    End Function

    <DllImport("psapi.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Public Function GetModuleFileNameEx(hProcess As IntPtr, hModule As IntPtr, lpFilename As StringBuilder, nSize As Integer) As UInteger
    End Function

    <DllImport("kernel32.dll", SetLastError:=True)>
    Public Function CloseHandle(hObject As IntPtr) As Boolean
    End Function

    ' 定義RECT結構
    <StructLayout(LayoutKind.Sequential)>
    Public Structure RECT
        Public Left As Integer
        Public Top As Integer
        Public Right As Integer
        Public Bottom As Integer
    End Structure

    ' 引入 mouse_event 函數
    <DllImport("user32.dll", SetLastError:=True)>
    Public Sub mouse_event(dwFlags As UInteger, dx As UInteger, dy As UInteger, dwData As UInteger, dwExtraInfo As IntPtr)
    End Sub

    <DllImport("user32.dll", SetLastError:=True)>
    Public Function UnhookWindowsHookEx(hhk As IntPtr) As Boolean
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Public Function CallNextHookEx(hhk As IntPtr, nCode As Integer, wParam As IntPtr, lParam As IntPtr) As IntPtr
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Public Function GetAsyncKeyState(vKey As Integer) As Short
    End Function


End Module