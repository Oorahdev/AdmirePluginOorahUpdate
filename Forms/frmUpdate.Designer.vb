<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnRunUpdate = New System.Windows.Forms.Button()
        Me.LblRequired = New System.Windows.Forms.Label()
        Me.LblUpToDate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnRunUpdate
        '
        Me.BtnRunUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnRunUpdate.Location = New System.Drawing.Point(109, 101)
        Me.BtnRunUpdate.Name = "BtnRunUpdate"
        Me.BtnRunUpdate.Size = New System.Drawing.Size(145, 60)
        Me.BtnRunUpdate.TabIndex = 0
        Me.BtnRunUpdate.Text = "Run Update"
        Me.BtnRunUpdate.UseVisualStyleBackColor = False
        '
        'LblRequired
        '
        Me.LblRequired.AutoSize = True
        Me.LblRequired.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRequired.ForeColor = System.Drawing.Color.Red
        Me.LblRequired.Location = New System.Drawing.Point(79, 66)
        Me.LblRequired.Name = "LblRequired"
        Me.LblRequired.Size = New System.Drawing.Size(199, 17)
        Me.LblRequired.TabIndex = 1
        Me.LblRequired.Text = "Your Admire requires an update "
        '
        'LblUpToDate
        '
        Me.LblUpToDate.AutoSize = True
        Me.LblUpToDate.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUpToDate.ForeColor = System.Drawing.Color.ForestGreen
        Me.LblUpToDate.Location = New System.Drawing.Point(92, 66)
        Me.LblUpToDate.Name = "LblUpToDate"
        Me.LblUpToDate.Size = New System.Drawing.Size(162, 17)
        Me.LblUpToDate.TabIndex = 2
        Me.LblUpToDate.Text = "Your Admire is up to date!"
        '
        'frmUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(366, 231)
        Me.Controls.Add(Me.LblUpToDate)
        Me.Controls.Add(Me.LblRequired)
        Me.Controls.Add(Me.BtnRunUpdate)
        Me.Name = "frmUpdate"
        Me.Text = "Update Admire"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRunUpdate As Button
    Friend WithEvents LblRequired As Label
    Friend WithEvents LblUpToDate As Label
End Class
