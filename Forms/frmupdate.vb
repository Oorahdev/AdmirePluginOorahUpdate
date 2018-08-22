Imports adm
Imports adm.AdmUtilities
Imports AdmireUpdate.Utilities

Public Class frmupdate
    Dim util As New Utilities
    Public host As admAdmireCustomModuleInterface.AdmireHostParameters
    Public Plugin As AdmireUpdate

    Public Sub New(admireHost As admAdmireCustomModuleInterface.AdmireHostParameters)
        'InitializeComponent()
        host = admireHost
    End Sub

    Public Sub New(ByVal AdmirePlugin As AdmireUpdate)
        Try
            InitializeComponent()
            Plugin = AdmirePlugin
            host = AdmirePlugin.Host
            ' InitForm()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub


    Private Sub update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkForUpdate()
    End Sub


    'Public Sub New()
    'End Sub

    Private Sub checkForUpdate()

        Dim arrargs As Object() = {host.SqlMaster.UserId}
        ' host.SqlMaster.RunSql("AdmireUpdatedDLLs", arrargs)
        host.SqlMaster.PullDataTable("UpdatedDlls", "AdmireUpdatedDLLs", arrargs, True)
        If host.SqlMaster.DataTables("UpdatedDlls").Rows.Count > 0 Then
            'Dim dv As DataView = host.SqlMaster.CreateDataView("UpdatedDlls")

            'If host.SqlMaster.PullDataTable("UpdatedDlls", "AdmireUpdatedDLLs", 0, True) > 0 Then
            '    Dim dvDLLs As DataView = host.SqlMaster.CreateDataView("UpdatedDlls")
            ' If "UpdatedDlls" > 0 Then
            ' Dim result As String = host.SqlMaster.DataTables("UpdatedDlls").Rows(0).Item("CUDLL_name")
            Button1.Text = "Update Required"
            Button1.ForeColor = Color.White
            Button1.BackColor = Color.Red
        Else
            Button1.Text = "Up To Date"
            Button1.ForeColor = Color.White
            Button1.BackColor = Color.MediumSeaGreen
        End If

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("C:\Users\lfireman\Documents\GitHub\updateAdmire\AwsConsoleApp1\bin\Debug\AwsConsoleApp1.exe")
        Button1.Text = "Update Successful"
        Button1.ForeColor = Color.White
        Button1.BackColor = Color.MediumSeaGreen
    End Sub


End Class