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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.version_label_small = New System.Windows.Forms.Label()
        Me.logo_small = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.productname_label_small = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.type_of_serach_label = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SubmitFeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProjectSiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SourceCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.HideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.version_label_big = New System.Windows.Forms.Label()
        Me.productname_label_big = New System.Windows.Forms.Label()
        Me.logo_big = New System.Windows.Forms.PictureBox()
        Me.trademark_label = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.KeyChecker = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.logo_small, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.logo_big, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.version_label_small)
        Me.Panel1.Controls.Add(Me.logo_small)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.productname_label_small)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(534, 68)
        Me.Panel1.TabIndex = 0
        '
        'version_label_small
        '
        Me.version_label_small.AutoSize = True
        Me.version_label_small.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.version_label_small.Location = New System.Drawing.Point(171, 14)
        Me.version_label_small.Name = "version_label_small"
        Me.version_label_small.Size = New System.Drawing.Size(41, 13)
        Me.version_label_small.TabIndex = 1
        Me.version_label_small.Text = "version"
        '
        'logo_small
        '
        Me.logo_small.Image = CType(resources.GetObject("logo_small.Image"), System.Drawing.Image)
        Me.logo_small.Location = New System.Drawing.Point(3, 3)
        Me.logo_small.Name = "logo_small"
        Me.logo_small.Size = New System.Drawing.Size(62, 62)
        Me.logo_small.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo_small.TabIndex = 3
        Me.logo_small.TabStop = False
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
        'productname_label_small
        '
        Me.productname_label_small.AutoSize = True
        Me.productname_label_small.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productname_label_small.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.productname_label_small.Location = New System.Drawing.Point(67, 20)
        Me.productname_label_small.Name = "productname_label_small"
        Me.productname_label_small.Size = New System.Drawing.Size(122, 33)
        Me.productname_label_small.TabIndex = 0
        Me.productname_label_small.Text = "Searchy"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 101)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(326, 20)
        Me.TextBox1.TabIndex = 1
        '
        'type_of_serach_label
        '
        Me.type_of_serach_label.AutoSize = True
        Me.type_of_serach_label.Location = New System.Drawing.Point(12, 85)
        Me.type_of_serach_label.Name = "type_of_serach_label"
        Me.type_of_serach_label.Size = New System.Drawing.Size(85, 13)
        Me.type_of_serach_label.TabIndex = 2
        Me.type_of_serach_label.Text = "Search the web:"
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
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Searchy"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubmitFeedbackToolStripMenuItem, Me.ToolStripSeparator3, Me.ProjectSiteToolStripMenuItem, Me.SourceCodeToolStripMenuItem, Me.ToolStripSeparator1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem1, Me.ToolStripSeparator2, Me.HideToolStripMenuItem, Me.ToolStripMenuItem4})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(209, 176)
        '
        'SubmitFeedbackToolStripMenuItem
        '
        Me.SubmitFeedbackToolStripMenuItem.Name = "SubmitFeedbackToolStripMenuItem"
        Me.SubmitFeedbackToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.SubmitFeedbackToolStripMenuItem.Text = "S&ubmit feedback"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(205, 6)
        '
        'ProjectSiteToolStripMenuItem
        '
        Me.ProjectSiteToolStripMenuItem.Name = "ProjectSiteToolStripMenuItem"
        Me.ProjectSiteToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.ProjectSiteToolStripMenuItem.Text = "&Project site"
        '
        'SourceCodeToolStripMenuItem
        '
        Me.SourceCodeToolStripMenuItem.Name = "SourceCodeToolStripMenuItem"
        Me.SourceCodeToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.SourceCodeToolStripMenuItem.Text = "&Source code"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(205, 6)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(208, 22)
        Me.ToolStripMenuItem2.Text = "&Check for updates"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(208, 22)
        Me.ToolStripMenuItem1.Text = "&About Searchy"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(205, 6)
        '
        'HideToolStripMenuItem
        '
        Me.HideToolStripMenuItem.Name = "HideToolStripMenuItem"
        Me.HideToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.HideToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.HideToolStripMenuItem.Text = "&Hide"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(208, 22)
        Me.ToolStripMenuItem4.Text = "&Exit"
        '
        'version_label_big
        '
        Me.version_label_big.AutoSize = True
        Me.version_label_big.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.version_label_big.Location = New System.Drawing.Point(299, 295)
        Me.version_label_big.Name = "version_label_big"
        Me.version_label_big.Size = New System.Drawing.Size(41, 13)
        Me.version_label_big.TabIndex = 6
        Me.version_label_big.Text = "version"
        Me.version_label_big.Visible = False
        '
        'productname_label_big
        '
        Me.productname_label_big.AutoSize = True
        Me.productname_label_big.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productname_label_big.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.productname_label_big.Location = New System.Drawing.Point(195, 301)
        Me.productname_label_big.Name = "productname_label_big"
        Me.productname_label_big.Size = New System.Drawing.Size(122, 33)
        Me.productname_label_big.TabIndex = 5
        Me.productname_label_big.Text = "Searchy"
        Me.productname_label_big.Visible = False
        '
        'logo_big
        '
        Me.logo_big.Image = CType(resources.GetObject("logo_big.Image"), System.Drawing.Image)
        Me.logo_big.Location = New System.Drawing.Point(182, 147)
        Me.logo_big.Name = "logo_big"
        Me.logo_big.Size = New System.Drawing.Size(139, 131)
        Me.logo_big.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo_big.TabIndex = 7
        Me.logo_big.TabStop = False
        Me.logo_big.Visible = False
        '
        'trademark_label
        '
        Me.trademark_label.AutoSize = True
        Me.trademark_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trademark_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.trademark_label.Location = New System.Drawing.Point(89, 334)
        Me.trademark_label.Name = "trademark_label"
        Me.trademark_label.Size = New System.Drawing.Size(351, 24)
        Me.trademark_label.TabIndex = 8
        Me.trademark_label.Text = "Search for almost everything on the web."
        Me.trademark_label.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(150, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(215, 25)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Finding that for you..."
        Me.Label3.Visible = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(15, 164)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(507, 218)
        Me.WebBrowser1.TabIndex = 21
        Me.WebBrowser1.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(406, 135)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(116, 23)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "&Open in browser"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Results:"
        Me.Label2.Visible = False
        '
        'KeyChecker
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 394)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.type_of_serach_label)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.trademark_label)
        Me.Controls.Add(Me.logo_big)
        Me.Controls.Add(Me.version_label_big)
        Me.Controls.Add(Me.productname_label_big)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Searchy"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.logo_small, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.logo_big, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents productname_label_small As System.Windows.Forms.Label
    Friend WithEvents version_label_small As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents type_of_serach_label As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents logo_small As System.Windows.Forms.PictureBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProjectSiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SourceCodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents version_label_big As System.Windows.Forms.Label
    Friend WithEvents productname_label_big As System.Windows.Forms.Label
    Friend WithEvents logo_big As System.Windows.Forms.PictureBox
    Friend WithEvents trademark_label As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SubmitFeedbackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KeyChecker As System.Windows.Forms.Timer

End Class
