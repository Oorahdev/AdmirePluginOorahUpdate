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
        Me.HeadwayWebPage = New System.Windows.Forms.WebBrowser()
        Me.GroupBoxRecentUpdates = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBoxRecentUpdates.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HeadwayWebPage
        '
        Me.HeadwayWebPage.Location = New System.Drawing.Point(23, 49)
        Me.HeadwayWebPage.MinimumSize = New System.Drawing.Size(20, 20)
        Me.HeadwayWebPage.Name = "HeadwayWebPage"
        Me.HeadwayWebPage.ScriptErrorsSuppressed = True
        Me.HeadwayWebPage.Size = New System.Drawing.Size(780, 457)
        Me.HeadwayWebPage.TabIndex = 2
        Me.HeadwayWebPage.Url = New System.Uri("https://headwayapp.co/oorah-updates", System.UriKind.Absolute)
        '
        'GroupBoxRecentUpdates
        '
        Me.GroupBoxRecentUpdates.Controls.Add(Me.HeadwayWebPage)
        Me.GroupBoxRecentUpdates.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxRecentUpdates.ForeColor = System.Drawing.Color.DarkGray
        Me.GroupBoxRecentUpdates.Location = New System.Drawing.Point(12, 92)
        Me.GroupBoxRecentUpdates.Name = "GroupBoxRecentUpdates"
        Me.GroupBoxRecentUpdates.Size = New System.Drawing.Size(828, 519)
        Me.GroupBoxRecentUpdates.TabIndex = 4
        Me.GroupBoxRecentUpdates.TabStop = False
        Me.GroupBoxRecentUpdates.Text = "Recent Updates:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(828, 72)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Status:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.DarkGray
        Me.Button1.Location = New System.Drawing.Point(652, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Run Update"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmupdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(852, 623)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBoxRecentUpdates)
        Me.Name = "frmupdate"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "update"
        Me.GroupBoxRecentUpdates.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HeadwayWebPage As WebBrowser
    Friend WithEvents GroupBoxRecentUpdates As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    'Friend WithEvents CustomShape1 As Telerik.WinControls.OldShapeEditor.CustomShape
    'Private WithEvents PathElementShape1 As Telerik.WinControls.Shapes.PathElementShape
    'Friend WithEvents object_75830c7e_529b_4ec7_9261_7e286a67f4a2 As Telerik.WinControls.RootRadElement
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
