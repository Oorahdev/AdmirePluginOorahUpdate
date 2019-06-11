<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmupdate

    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New Telerik.WinControls.UI.RadButton()
        Me.HeadwayWebPage = New System.Windows.Forms.WebBrowser()
        Me.Label1 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.Button1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Snow
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(31, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 53)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Run Update"
        '
        'HeadwayWebPage
        '
        Me.HeadwayWebPage.Location = New System.Drawing.Point(12, 164)
        Me.HeadwayWebPage.MinimumSize = New System.Drawing.Size(20, 20)
        Me.HeadwayWebPage.Name = "HeadwayWebPage"
        Me.HeadwayWebPage.Size = New System.Drawing.Size(828, 430)
        Me.HeadwayWebPage.TabIndex = 2
        Me.HeadwayWebPage.Url = New System.Uri("https://headwayapp.co/oorah-updates", System.UriKind.Absolute)
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(372, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 30)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Recent Updates:"
        '
        'frmupdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(852, 623)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HeadwayWebPage)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmupdate"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "update"
        CType(Me.Button1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents HeadwayWebPage As WebBrowser
    Friend WithEvents Label1 As Telerik.WinControls.UI.RadLabel
End Class
