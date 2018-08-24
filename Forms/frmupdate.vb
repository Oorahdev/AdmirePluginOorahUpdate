Imports adm
Imports adm.AdmUtilities
Imports AdmireUpdate.Utilities
Imports System
Imports System.Text

Public Class frmupdate
    Dim util As New Utilities
    Public host As admAdmireCustomModuleInterface.AdmireHostParameters
    Public Plugin As AdmireUpdate
    ' Public Shared result As String
    Public Shared rows As DataRow()
    Public Shared stringArr
    Public Shared labels

    Public Sub New(admireHost As admAdmireCustomModuleInterface.AdmireHostParameters)
        host = admireHost
    End Sub

    Public Sub New(ByVal AdmirePlugin As AdmireUpdate)
        Try
            InitializeComponent()
            Plugin = AdmirePlugin
            host = AdmirePlugin.Host
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub


    Private Sub update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkForUpdate()
    End Sub


    Public Sub checkForUpdate()
        Dim arrargs As Object() = {host.SqlMaster.UserId}
        host.SqlMaster.PullDataTable("UpdatedDlls", "AdmireUpdatedDLLs", arrargs, True)
        Dim labels As New StringBuilder
        rows = host.SqlMaster.DataTables("UpdatedDlls").Select("CUDLL_name is not null", "CUDLL_name")
        For Each row As DataRow In rows
            labels.Append(" " + row.Item("CUDLL_name"))
        Next
        If host.SqlMaster.DataTables("UpdatedDlls").Rows.Count > 0 Then
            Button1.Text = labels.ToString() '"Update Required"
            Button1.ForeColor = Color.White
            Button1.BackColor = Color.Red
        Else
            Button1.Text = "Up To Date"
            Button1.ForeColor = Color.White
            Button1.BackColor = Color.MediumSeaGreen
        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim exe = "C:\Users\lfireman\Documents\GitHub\updateAdmire\AwsConsoleApp1\bin\Debug\AwsConsoleApp1.exe"
            Dim args = labels
            Process.Start(exe, args)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim arrargs As Object() = {host.SqlMaster.UserId}
        host.SqlMaster.RunSql("AdmireUpdateDlls_lastUpdate", arrargs)
        Button1.Text = "Update Successful"
        Button1.ForeColor = Color.White
        Button1.BackColor = Color.MediumSeaGreen
    End Sub


End Class