<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Searchy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Searchy))
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblVersionSmall = New System.Windows.Forms.Label()
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.txtQuery = New System.Windows.Forms.TextBox()
        Me.lblTypeOfSerach = New System.Windows.Forms.Label()
        Me.cbEngine = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.NotificationIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotificationContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NotificationContextMenuSubmitFeedback = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificationContextMenuSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.NotificationContextMenuProjectSite = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificationContextMenuSourceCode = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificationContextMenuSeperator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.NotificationContextMenuUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificationContextMenuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificationContextMenuSeperator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.NotificationContextMenuPreferences = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificationContextMenuHide = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificationContextMenuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.timerKeyChecker = New System.Windows.Forms.Timer(Me.components)
        Me.pnlTop.SuspendLayout()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NotificationContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.lblVersionSmall)
        Me.pnlTop.Controls.Add(Me.imgLogo)
        Me.pnlTop.Controls.Add(Me.btnClose)
        Me.pnlTop.Controls.Add(Me.lblProductName)
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(534, 68)
        Me.pnlTop.TabIndex = 0
        '
        'lblVersionSmall
        '
        Me.lblVersionSmall.AutoSize = True
        Me.lblVersionSmall.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblVersionSmall.Location = New System.Drawing.Point(171, 14)
        Me.lblVersionSmall.Name = "lblVersionSmall"
        Me.lblVersionSmall.Size = New System.Drawing.Size(41, 13)
        Me.lblVersionSmall.TabIndex = 1
        Me.lblVersionSmall.Text = "version"
        '
        'imgLogo
        '
        Me.imgLogo.Image = Global.Searchy.My.Resources.Resources._1398027694_Search
        Me.imgLogo.Location = New System.Drawing.Point(3, 3)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(62, 62)
        Me.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgLogo.TabIndex = 3
        Me.imgLogo.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(460, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(62, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "&X"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblProductName.Location = New System.Drawing.Point(67, 20)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(122, 33)
        Me.lblProductName.TabIndex = 0
        Me.lblProductName.Text = "Searchy"
        '
        'txtQuery
        '
        Me.txtQuery.Location = New System.Drawing.Point(15, 115)
        Me.txtQuery.Name = "txtQuery"
        Me.txtQuery.Size = New System.Drawing.Size(326, 20)
        Me.txtQuery.TabIndex = 1
        '
        'lblTypeOfSerach
        '
        Me.lblTypeOfSerach.AutoSize = True
        Me.lblTypeOfSerach.Location = New System.Drawing.Point(12, 99)
        Me.lblTypeOfSerach.Name = "lblTypeOfSerach"
        Me.lblTypeOfSerach.Size = New System.Drawing.Size(85, 13)
        Me.lblTypeOfSerach.TabIndex = 2
        Me.lblTypeOfSerach.Text = "Search the web:"
        '
        'cbEngine
        '
        Me.cbEngine.FormattingEnabled = True
        Me.cbEngine.Items.AddRange(New Object() {"-Web-", "Google", "Yahoo", "Bing", "DuckDuckGo", "", "-Video-", "YouTube", "Dailymotion", "", "-Music-", "", "SoundCloud", "", "-Code-", "GitHub"})
        Me.cbEngine.Location = New System.Drawing.Point(347, 114)
        Me.cbEngine.Name = "cbEngine"
        Me.cbEngine.Size = New System.Drawing.Size(79, 21)
        Me.cbEngine.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(432, 113)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(90, 23)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'NotificationIcon
        '
        Me.NotificationIcon.ContextMenuStrip = Me.NotificationContextMenu
        Me.NotificationIcon.Icon = CType(resources.GetObject("NotificationIcon.Icon"), System.Drawing.Icon)
        Me.NotificationIcon.Text = "Searchy"
        Me.NotificationIcon.Visible = True
        '
        'NotificationContextMenu
        '
        Me.NotificationContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NotificationContextMenuSubmitFeedback, Me.NotificationContextMenuSeparator3, Me.NotificationContextMenuProjectSite, Me.NotificationContextMenuSourceCode, Me.NotificationContextMenuSeperator1, Me.NotificationContextMenuUpdate, Me.NotificationContextMenuAbout, Me.NotificationContextMenuSeperator2, Me.NotificationContextMenuPreferences, Me.NotificationContextMenuHide, Me.NotificationContextMenuExit})
        Me.NotificationContextMenu.Name = "ContextMenuStrip1"
        Me.NotificationContextMenu.Size = New System.Drawing.Size(209, 198)
        '
        'NotificationContextMenuSubmitFeedback
        '
        Me.NotificationContextMenuSubmitFeedback.Name = "NotificationContextMenuSubmitFeedback"
        Me.NotificationContextMenuSubmitFeedback.Size = New System.Drawing.Size(208, 22)
        Me.NotificationContextMenuSubmitFeedback.Text = "S&ubmit feedback"
        '
        'NotificationContextMenuSeparator3
        '
        Me.NotificationContextMenuSeparator3.Name = "NotificationContextMenuSeparator3"
        Me.NotificationContextMenuSeparator3.Size = New System.Drawing.Size(205, 6)
        '
        'NotificationContextMenuProjectSite
        '
        Me.NotificationContextMenuProjectSite.Image = CType(resources.GetObject("NotificationContextMenuProjectSite.Image"), System.Drawing.Image)
        Me.NotificationContextMenuProjectSite.Name = "NotificationContextMenuProjectSite"
        Me.NotificationContextMenuProjectSite.Size = New System.Drawing.Size(208, 22)
        Me.NotificationContextMenuProjectSite.Text = "&Project site"
        '
        'NotificationContextMenuSourceCode
        '
        Me.NotificationContextMenuSourceCode.Image = CType(resources.GetObject("NotificationContextMenuSourceCode.Image"), System.Drawing.Image)
        Me.NotificationContextMenuSourceCode.Name = "NotificationContextMenuSourceCode"
        Me.NotificationContextMenuSourceCode.Size = New System.Drawing.Size(208, 22)
        Me.NotificationContextMenuSourceCode.Text = "&Source code"
        '
        'NotificationContextMenuSeperator1
        '
        Me.NotificationContextMenuSeperator1.Name = "NotificationContextMenuSeperator1"
        Me.NotificationContextMenuSeperator1.Size = New System.Drawing.Size(205, 6)
        '
        'NotificationContextMenuUpdate
        '
        Me.NotificationContextMenuUpdate.Name = "NotificationContextMenuUpdate"
        Me.NotificationContextMenuUpdate.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.NotificationContextMenuUpdate.Size = New System.Drawing.Size(208, 22)
        Me.NotificationContextMenuUpdate.Text = "&Check for updates"
        '
        'NotificationContextMenuAbout
        '
        Me.NotificationContextMenuAbout.Image = Global.Searchy.My.Resources.Resources._1402255166_susehelpcenter
        Me.NotificationContextMenuAbout.Name = "NotificationContextMenuAbout"
        Me.NotificationContextMenuAbout.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.NotificationContextMenuAbout.Size = New System.Drawing.Size(208, 22)
        Me.NotificationContextMenuAbout.Text = "&About Searchy"
        '
        'NotificationContextMenuSeperator2
        '
        Me.NotificationContextMenuSeperator2.Name = "NotificationContextMenuSeperator2"
        Me.NotificationContextMenuSeperator2.Size = New System.Drawing.Size(205, 6)
        '
        'NotificationContextMenuPreferences
        '
        Me.NotificationContextMenuPreferences.Image = Global.Searchy.My.Resources.Resources._1402255170_package_settings
        Me.NotificationContextMenuPreferences.Name = "NotificationContextMenuPreferences"
        Me.NotificationContextMenuPreferences.Size = New System.Drawing.Size(208, 22)
        Me.NotificationContextMenuPreferences.Text = "&Preferences"
        '
        'NotificationContextMenuHide
        '
        Me.NotificationContextMenuHide.Name = "NotificationContextMenuHide"
        Me.NotificationContextMenuHide.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.NotificationContextMenuHide.Size = New System.Drawing.Size(208, 22)
        Me.NotificationContextMenuHide.Text = "&Hide"
        '
        'NotificationContextMenuExit
        '
        Me.NotificationContextMenuExit.Name = "NotificationContextMenuExit"
        Me.NotificationContextMenuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.NotificationContextMenuExit.Size = New System.Drawing.Size(208, 22)
        Me.NotificationContextMenuExit.Text = "&Exit"
        '
        'timerKeyChecker
        '
        '
        'Searchy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 172)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.cbEngine)
        Me.Controls.Add(Me.lblTypeOfSerach)
        Me.Controls.Add(Me.txtQuery)
        Me.Controls.Add(Me.pnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Searchy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Searchy"
        Me.TopMost = True
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NotificationContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents lblVersionSmall As System.Windows.Forms.Label
    Friend WithEvents txtQuery As System.Windows.Forms.TextBox
    Friend WithEvents lblTypeOfSerach As System.Windows.Forms.Label
    Friend WithEvents cbEngine As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents NotificationIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents imgLogo As System.Windows.Forms.PictureBox
    Friend WithEvents NotificationContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NotificationContextMenuUpdate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotificationContextMenuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotificationContextMenuHide As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotificationContextMenuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotificationContextMenuProjectSite As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotificationContextMenuSourceCode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotificationContextMenuSubmitFeedback As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotificationContextMenuSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents timerKeyChecker As System.Windows.Forms.Timer
    Friend WithEvents NotificationContextMenuPreferences As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotificationContextMenuSeperator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NotificationContextMenuSeperator2 As System.Windows.Forms.ToolStripSeparator

End Class
