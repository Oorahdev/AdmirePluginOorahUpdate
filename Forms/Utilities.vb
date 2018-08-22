Imports AdmireUpdate
Imports adm
Imports adm.AdmUtilities
Imports AdmireUpdate.frmupdate
'Imports Telerik.WinControls.UI

Public Class Utilities

    Public host As admAdmireCustomModuleInterface.AdmireHostParameters
    Public Plugin As AdmireUpdate


    Public Delegate Function CaseDelegate(ByVal str As String)

    'Public Sub SetCaseTextBoxes(ByVal delegateFunction As CaseDelegate, ByVal panel As Telerik.WinControls.UI.RadPanel)
    '    Dim allTextBoxes = GetChildControlsRecursive(Of TextBox)(panel)
    '    For Each ctrl As TextBox In allTextBoxes
    '        ctrl.Text = delegateFunction(ctrl.Text)
    '    Next
    'End Sub

    'Public Sub SetCaseTextBoxes(ByVal delegateFunction As CaseDelegate, ByVal textBox As Telerik.WinControls.UI.RadTextBox)
    '    textBox.Text = delegateFunction(textBox.Text)
    'End Sub

    'Public Function GetCheckedItems(ByVal ctrl As Telerik.WinControls.UI.RadCheckedDropDownList)
    '    Dim results = ""
    '    For Each result As RadCheckedListDataItem In ctrl.CheckedItems
    '        results += result.Text + ", "
    '    Next

    '    If results.Length > 0 Then
    '        results = results.Remove(results.Length - 2)
    '    End If

    '    Return results
    'End Function

    'Public Function GetCheckedItems(ByVal ctrl As Telerik.WinControls.UI.RadCheckedListBox)
    '    Dim results = ""
    '    For Each result As ListViewDataItem In ctrl.CheckedItems
    '        results += result.Text + ", "
    '    Next

    '    If results.Length > 0 Then
    '        results = results.Remove(results.Length - 2)
    '    End If

    '    Return results
    'End Function

    'Public Function GetCheckedItems(ByVal panel As Telerik.WinControls.UI.RadPanel, Optional str As Boolean = False) As String
    '    Dim radioButtons = GetChildControlsRecursive(Of Telerik.WinControls.UI.RadRadioButton)(panel)
    '    For Each ctrl As Telerik.WinControls.UI.RadRadioButton In radioButtons
    '        If ctrl.CheckState = 1 Then
    '            If ctrl.Text = "Yes" Then
    '                If str = True Then
    '                    Return ctrl.Text
    '                Else
    '                    Return 1
    '                End If
    '            ElseIf ctrl.Text = "No" Then
    '                If str = True Then
    '                    Return ctrl.Text
    '                Else
    '                    Return 0
    '                End If
    '            Else
    '                Return ctrl.Text
    '            End If
    '        End If
    '    Next
    '    Return Nothing
    'End Function

    'Public Function NullDateTime(ByVal dt As DateTime)
    '    Return IIf(dt > "1/1/0001", dt, Nothing)
    'End Function

    'Public Function GetToggleState(ByVal cbl As Telerik.WinControls.Enumerations.ToggleState)
    '    If cbl.Equals(Telerik.WinControls.Enumerations.ToggleState.On) Then
    '        Return 1
    '    Else
    '        Return Nothing
    '    End If
    'End Function

    'Public Sub SetCheckedItems(ByVal panel As Telerik.WinControls.UI.RadPanel, text As String)
    '    Dim radioButtons = GetChildControlsRecursive(Of Telerik.WinControls.UI.RadRadioButton)(panel)
    '    For Each ctrl As Telerik.WinControls.UI.RadRadioButton In radioButtons
    '        If ctrl.Text = text Then
    '            ctrl.CheckState = CheckState.Checked
    '        End If
    '    Next
    'End Sub

    'Public Sub EnableAllPages(ByVal pageview As Telerik.WinControls.UI.RadPageView, Enable As Boolean)
    '    Dim pages = GetChildControlsRecursive(Of Telerik.WinControls.UI.RadPageViewPage)(pageview)
    '    If Enable = True Then
    '        For Each ctrl As Telerik.WinControls.UI.RadPageViewPage In pages
    '            ctrl.Enabled = True
    '        Next
    '    Else
    '        For Each ctrl As Telerik.WinControls.UI.RadPageViewPage In pages
    '            If ctrl.Name IsNot "pgGeneral" Then
    '                ctrl.Enabled = False
    '            End If
    '        Next
    '    End If

    'End Sub

    'Public Sub SetCheckedItemsYesNo(ByVal panel As Telerik.WinControls.UI.RadPanel, value As String)
    '    Dim radioButtons = GetChildControlsRecursive(Of Telerik.WinControls.UI.RadRadioButton)(panel)
    '    For Each ctrl As Telerik.WinControls.UI.RadRadioButton In radioButtons
    '        If (ctrl.Text = "Yes" And value = "True") Or (ctrl.Text = "No" And value = "False") Then
    '            ctrl.CheckState = CheckState.Checked
    '        End If

    '    Next
    'End Sub

    'Public Sub SetPropertiesDropDowns(ByVal frm As Form)
    '    Dim allDropDowns = GetChildControlsRecursive(Of Telerik.WinControls.UI.RadDropDownList)(frm)
    '    For Each ctrl As Telerik.WinControls.UI.RadDropDownList In allDropDowns
    '        With ctrl
    '            .ReadOnly = False
    '            .DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
    '            .AutoCompleteMode = AutoCompleteMode.Append
    '        End With
    '    Next
    'End Sub

    'Public Sub SetPropertiesRadioButtons(ByVal frm As Form, ByVal shape As Telerik.WinControls.ElementShape)
    '    Dim allRadioButtons = GetChildControlsRecursive(Of Telerik.WinControls.UI.RadRadioButton)(frm)
    '    For Each ctrl As Telerik.WinControls.UI.RadRadioButton In allRadioButtons
    '        With ctrl
    '            .ButtonElement.CheckMarkPrimitive.Shape = shape
    '        End With
    '    Next
    'End Sub

    'Public Function SetTitleCaseTextBoxes(text As String) As String
    '    Return StrConv(text, VbStrConv.ProperCase)
    'End Function

    'Public Function SetUpperCaseTextBoxes(text As String) As String
    '    Return StrConv(text, VbStrConv.Uppercase)
    'End Function

    'Function RemoveCharacter(ByVal stringToCleanUp, ByVal characterToRemove)
    '    ' replace the target with nothing
    '    ' Replace() returns a new String and does not modify the current one
    '    Return stringToCleanUp.Replace(characterToRemove, "")
    'End Function

    'Public Sub refreshControls(ctrl As Control)
    '    If TypeOf ctrl Is RadCheckBox Then
    '        CType(ctrl, RadCheckBox).Checked = False
    '    ElseIf TypeOf ctrl Is RadTextBox Then
    '        CType(ctrl, RadTextBox).Text = String.Empty
    '    ElseIf TypeOf ctrl Is RadRadioButton Then
    '        CType(ctrl, RadRadioButton).CheckState = CheckState.Unchecked
    '    ElseIf TypeOf ctrl Is RadCheckedDropDownList Then
    '        CType(ctrl, RadCheckedDropDownList).CheckedItems.Clear()
    '    ElseIf TypeOf ctrl Is RadDropDownList Then
    '        CType(ctrl, RadDropDownList).SelectedIndex = -1
    '    ElseIf TypeOf ctrl Is RadCheckedListBox Then
    '        CType(ctrl, RadCheckedListBox).UncheckAllItems()
    '    ElseIf TypeOf ctrl Is RadMaskedEditBox Then
    '        CType(ctrl, RadMaskedEditBox).Value = Nothing
    '    ElseIf TypeOf ctrl Is Raddatetimepicker Then
    '        CType(ctrl, RadDateTimePicker).Value = Nothing
    '        'CType(ctrl, RadDateTimePicker).Format = DateTimePickerFormat.Custom
    '    ElseIf TypeOf ctrl Is RadTrackBar Then
    '        CType(ctrl, RadTrackBar).Value = 0
    '    End If
    'End Sub

    'Public Function refreshPageView(ByVal pv As Telerik.WinControls.UI.RadPageView)
    '    For Each pg As RadPageViewPage In pv.Pages
    '        For Each ctrl1 As Control In pg.Controls
    '            If TypeOf ctrl1 IsNot RadGroupBox Then
    '                refreshControls(ctrl1)
    '            Else
    '                For Each ctrl2 As Control In ctrl1.Controls
    '                    If TypeOf ctrl2 IsNot RadPanel Then
    '                        refreshControls(ctrl2)
    '                    Else
    '                        For Each ctrl3 As Control In ctrl2.Controls
    '                            If TypeOf ctrl3 IsNot RadPanel Then
    '                                refreshControls(ctrl3)
    '                            Else
    '                                For Each ctrl As Control In ctrl3.Controls
    '                                    refreshControls(ctrl)
    '                                Next
    '                            End If
    '                        Next
    '                    End If
    '                Next

    '            End If


    '        Next
    '    Next

    '    Return Nothing
    'End Function

    'Sub maskPhoneNumber_MouseUp(sender As Object, e As MouseEventArgs)
    '    Dim editBox As RadMaskedEditBox = CType(CType(sender, Telerik.WinControls.RadHostItem).ElementTree.Control, RadMaskedEditBox)
    '    Dim stringLength = sender.text.replace(" ", "").length
    '    If stringLength <= 2 Then
    '        editBox.SelectionStart = 0
    '    Else
    '        editBox.SelectionStart = stringLength
    '    End If
    'End Sub

End Class
