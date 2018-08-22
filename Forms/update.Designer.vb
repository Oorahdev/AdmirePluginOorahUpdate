<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class update
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LblGreen = New System.Windows.Forms.Label()
        Me.LblRed = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(184, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "BtnUpdate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LblGreen
        '
        Me.LblGreen.AutoSize = True
        Me.LblGreen.ForeColor = System.Drawing.Color.ForestGreen
        Me.LblGreen.Location = New System.Drawing.Point(147, 69)
        Me.LblGreen.Name = "LblGreen"
        Me.LblGreen.Size = New System.Drawing.Size(41, 13)
        Me.LblGreen.TabIndex = 1
        Me.LblGreen.Text = "Current"
        Me.LblGreen.Visible = False
        '
        'LblRed
        '
        Me.LblRed.AutoSize = True
        Me.LblRed.ForeColor = System.Drawing.Color.Red
        Me.LblRed.Location = New System.Drawing.Point(223, 69)
        Me.LblRed.Name = "LblRed"
        Me.LblRed.Size = New System.Drawing.Size(88, 13)
        Me.LblRed.TabIndex = 2
        Me.LblRed.Text = "Update Required"
        Me.LblRed.Visible = False
        '
        'update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 293)
        Me.Controls.Add(Me.LblRed)
        Me.Controls.Add(Me.LblGreen)
        Me.Controls.Add(Me.Button1)
        Me.Name = "update"
        Me.Text = "update"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents LblGreen As Label
    Friend WithEvents LblRed As Label
End Class
