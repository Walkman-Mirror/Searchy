<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(533, 152)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(116, 23)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "&Open in browser"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(139, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Results:"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(277, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(215, 25)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Finding that for you..."
        Me.Label3.Visible = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(142, 181)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(507, 218)
        Me.WebBrowser1.TabIndex = 11
        Me.WebBrowser1.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 550)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
End Class
