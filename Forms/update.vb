Public Class update

    Public host As admAdmireCustomModuleInterface.AdmireHostParameters
    Private Sub update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkForUpdate()
    End Sub

    Private Sub checkForUpdate()
        Dim result As String
        If host.SqlMaster.PullDataTable("UpdatedDlls", "AdmireUpdatedDLLs", 0, True) > 0 Then
            LblRed.Show()
            result = host.SqlMaster.DataTables("UpdatedDlls").Rows(0).Item("CUDLL_name")
            Print(result)
        Else
            LblGreen.Show()
        End If

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("C:\Users\lfireman\Documents\GitHub\updateAdmire\AwsConsoleApp1\bin\Debug\AwsConsoleApp1.exe")
    End Sub


End Class