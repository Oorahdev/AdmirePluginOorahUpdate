Imports adm
Imports adm.AdmUtilities
Imports AdmireUpdate.Utilities
Imports System
Imports System.Text

Public Class frmupdate
    Dim util As New Utilities
    Public host As admAdmireCustomModuleInterface.AdmireHostParameters
    Public Plugin As AdmireUpdate
    Public Shared rows As DataRow()
    Public Shared stringArr
    Public labels


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
        Me.labels = labels
        If host.SqlMaster.DataTables("UpdatedDlls").Rows.Count > 0 Then
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
        Try
            downloadDlls()
            ' markUpdated()
            ' reopenAdmire()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub downloadDlls()
        Try
            Dim exe = "C:\Users\lfireman\Documents\GitHub\updateAdmire\AwsConsoleApp1\bin\Debug\AwsConsoleApp1.exe"
            Dim dlls = labels.ToString()

            Dim arrargs As Object() = {host.SqlMaster.UserId}
            host.SqlMaster.PullDataTable("UsrId", "Usr_UsrId", arrargs, True)
            Dim usr As String = Convert.ToString(Nz(host.SqlMaster.DataTables("UsrId").Rows(0).Item("USR_ID"), 0))

            Process.Start(exe, usr & dlls)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub closeAdmire()
    '    Try
    '        Process.Start("taskkill /IM admire.exe")
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Private Sub reopenAdmire()
    '    Try
    '        Process.Start("start /d C:\Admire admire.exe")
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub



    'Private Sub markUpdated()
    '    Dim arrargs As Object() = {host.SqlMaster.UserId}
    '    host.SqlMaster.RunSql("AdmireUpdateDlls_lastUpdate", arrargs)
    '    Button1.Text = "Update Successful"
    '    Button1.ForeColor = Color.White
    '    Button1.BackColor = Color.MediumSeaGreen
    'End Sub

End Class