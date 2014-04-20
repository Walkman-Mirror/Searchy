<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.version_label = New System.Windows.Forms.Label()
        Me.productname_label = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.version_label)
        Me.Panel1.Controls.Add(Me.productname_label)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(534, 68)
        Me.Panel1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(460, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "&X"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'version_label
        '
        Me.version_label.AutoSize = True
        Me.version_label.Location = New System.Drawing.Point(116, 14)
        Me.version_label.Name = "version_label"
        Me.version_label.Size = New System.Drawing.Size(41, 13)
        Me.version_label.TabIndex = 1
        Me.version_label.Text = "version"
        '
        'productname_label
        '
        Me.productname_label.AutoSize = True
        Me.productname_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productname_label.Location = New System.Drawing.Point(12, 20)
        Me.productname_label.Name = "productname_label"
        Me.productname_label.Size = New System.Drawing.Size(122, 33)
        Me.productname_label.TabIndex = 0
        Me.productname_label.Text = "Searchy"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 101)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(326, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search the web:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Google", "Yahoo", "Bing"})
        Me.ComboBox1.Location = New System.Drawing.Point(347, 100)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(79, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(432, 99)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "&Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Results:"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(15, 164)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(507, 218)
        Me.WebBrowser1.TabIndex = 6
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "Searchy"
        Me.NotifyIcon1.Visible = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(469, 135)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(53, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "&Expand"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(347, 135)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(116, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "&Open in browser"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(150, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(215, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Finding that for you..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 394)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Searchy"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents productname_label As System.Windows.Forms.Label
    Friend WithEvents version_label As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
