Imports System.Management
Imports System.Management.Instrumentation

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show(getHDDID("E"))
        MessageBox.Show(getHDDID("F"))
        MessageBox.Show(getHDDID("G"))
    End Sub

    Public Shared Function getHDDID(ByVal drive As String) As String
        Dim disk As ManagementObject = New ManagementObject("Win32_LogicalDisk.DeviceID=""" & drive & ":""")
        disk.[Get]()
        drive = disk("VolumeSerialNumber").ToString()
        Return drive
    End Function

End Class
