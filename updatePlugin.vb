Imports Microsoft.VisualBasic


'move to plugins folder

Public Class AdmireUpdate
    Inherits admAdmireCustomModuleInterface.admICustomModule

    Public Overrides ReadOnly Property ModuleName() As String
        Get
            Return "AdmireUpdate"
        End Get
    End Property

    Public Overrides Function GetMenuItems() As admAdmireCustomModuleInterface.admICustomModule.CustomModuleMenuItem()
        Dim arrRet(0) As CustomModuleMenuItem
        arrRet(0) = New CustomModuleMenuItem
        arrRet(0).DelegateToRun = New admAdmireCustomModuleInterface.admICustomModule.CustomModuleMenuItemClick(AddressOf MenuItemOpenCollectorsClick)
        arrRet(0).Locations = New MenuLocation() {MenuLocation.MainMenu}
        arrRet(0).Text = "Admire|Update"
        Return arrRet
    End Function


    Public Sub MenuItemOpenCollectorsClick(ByVal sender As Object, ByVal e As CustomModuleMenuItemClickEventArgs)
        downloadDlls()
    End Sub


    Public Sub downloadDlls()
        Dim x As update = New update
        x.Show()
    End Sub
End Class
