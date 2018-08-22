Public Class frmUpdate
    Private Sub frmUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub BtnRunUpdate_Click(sender As Object, e As EventArgs) Handles BtnRunUpdate.Click
        Process.Start("C:\Users\lfireman\Documents\GitHub\updateAdmire\AwsConsoleApp1\bin\Debug\AwsConsoleApp1.exe")
    End Sub


End Class