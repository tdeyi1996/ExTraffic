<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMMain))
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.GTMain = New ExTraffic.GhostTheme()
        Me.wb = New System.Windows.Forms.WebBrowser()
        Me.lbDelayStatus = New System.Windows.Forms.Label()
        Me.GBbtnStartSurf = New ExTraffic.GhostButton()
        Me.GBbtnStopSurf = New ExTraffic.GhostButton()
        Me.GBbtnRemoveLinks = New ExTraffic.GhostButton()
        Me.GBbtnAddLinks = New ExTraffic.GhostButton()
        Me.GhostControlBox1 = New ExTraffic.GhostControlBox()
        Me.lbStatus = New System.Windows.Forms.Label()
        Me.GGBLinks = New ExTraffic.GhostGroupBox()
        Me.LBLinks = New System.Windows.Forms.ListBox()
        Me.GTMain.SuspendLayout()
        Me.GGBLinks.SuspendLayout()
        Me.SuspendLayout()
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        '
        'GTMain
        '
        Me.GTMain.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.GTMain.Colors = New ExTraffic.Bloom(-1) {}
        Me.GTMain.Controls.Add(Me.wb)
        Me.GTMain.Controls.Add(Me.lbDelayStatus)
        Me.GTMain.Controls.Add(Me.GBbtnStartSurf)
        Me.GTMain.Controls.Add(Me.GBbtnStopSurf)
        Me.GTMain.Controls.Add(Me.GBbtnRemoveLinks)
        Me.GTMain.Controls.Add(Me.GBbtnAddLinks)
        Me.GTMain.Controls.Add(Me.GhostControlBox1)
        Me.GTMain.Controls.Add(Me.lbStatus)
        Me.GTMain.Controls.Add(Me.GGBLinks)
        Me.GTMain.Customization = ""
        Me.GTMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GTMain.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.GTMain.Image = Nothing
        Me.GTMain.Location = New System.Drawing.Point(0, 0)
        Me.GTMain.MaximumSize = New System.Drawing.Size(421, 284)
        Me.GTMain.MinimumSize = New System.Drawing.Size(421, 284)
        Me.GTMain.Movable = True
        Me.GTMain.Name = "GTMain"
        Me.GTMain.NoRounding = False
        Me.GTMain.ShowIcon = False
        Me.GTMain.Sizable = True
        Me.GTMain.Size = New System.Drawing.Size(421, 284)
        Me.GTMain.SmartBounds = True
        Me.GTMain.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GTMain.TabIndex = 0
        Me.GTMain.Text = "ExTraffic :: Adfocus Bot"
        Me.GTMain.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.GTMain.Transparent = False
        '
        'wb
        '
        Me.wb.Location = New System.Drawing.Point(234, 240)
        Me.wb.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wb.Name = "wb"
        Me.wb.Size = New System.Drawing.Size(162, 30)
        Me.wb.TabIndex = 7
        Me.wb.Visible = False
        '
        'lbDelayStatus
        '
        Me.lbDelayStatus.AutoSize = True
        Me.lbDelayStatus.BackColor = System.Drawing.Color.Transparent
        Me.lbDelayStatus.ForeColor = System.Drawing.Color.Lime
        Me.lbDelayStatus.Location = New System.Drawing.Point(18, 258)
        Me.lbDelayStatus.Name = "lbDelayStatus"
        Me.lbDelayStatus.Size = New System.Drawing.Size(104, 13)
        Me.lbDelayStatus.TabIndex = 7
        Me.lbDelayStatus.Text = "Delay status : nil"
        '
        'GBbtnStartSurf
        '
        Me.GBbtnStartSurf.Color = System.Drawing.Color.Empty
        Me.GBbtnStartSurf.Colors = New ExTraffic.Bloom(-1) {}
        Me.GBbtnStartSurf.Customization = ""
        Me.GBbtnStartSurf.EnableGlass = True
        Me.GBbtnStartSurf.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.GBbtnStartSurf.Image = Nothing
        Me.GBbtnStartSurf.Location = New System.Drawing.Point(15, 210)
        Me.GBbtnStartSurf.Name = "GBbtnStartSurf"
        Me.GBbtnStartSurf.NoRounding = False
        Me.GBbtnStartSurf.Size = New System.Drawing.Size(89, 23)
        Me.GBbtnStartSurf.TabIndex = 1
        Me.GBbtnStartSurf.Text = "Start Surfing"
        Me.GBbtnStartSurf.Transparent = False
        '
        'GBbtnStopSurf
        '
        Me.GBbtnStopSurf.Color = System.Drawing.Color.Empty
        Me.GBbtnStopSurf.Colors = New ExTraffic.Bloom(-1) {}
        Me.GBbtnStopSurf.Customization = ""
        Me.GBbtnStopSurf.EnableGlass = True
        Me.GBbtnStopSurf.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.GBbtnStopSurf.Image = Nothing
        Me.GBbtnStopSurf.Location = New System.Drawing.Point(110, 210)
        Me.GBbtnStopSurf.Name = "GBbtnStopSurf"
        Me.GBbtnStopSurf.NoRounding = False
        Me.GBbtnStopSurf.Size = New System.Drawing.Size(84, 23)
        Me.GBbtnStopSurf.TabIndex = 2
        Me.GBbtnStopSurf.Text = "Stop Surfing"
        Me.GBbtnStopSurf.Transparent = False
        '
        'GBbtnRemoveLinks
        '
        Me.GBbtnRemoveLinks.Color = System.Drawing.Color.Empty
        Me.GBbtnRemoveLinks.Colors = New ExTraffic.Bloom(-1) {}
        Me.GBbtnRemoveLinks.Customization = ""
        Me.GBbtnRemoveLinks.EnableGlass = True
        Me.GBbtnRemoveLinks.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.GBbtnRemoveLinks.Image = Nothing
        Me.GBbtnRemoveLinks.Location = New System.Drawing.Point(200, 40)
        Me.GBbtnRemoveLinks.Name = "GBbtnRemoveLinks"
        Me.GBbtnRemoveLinks.NoRounding = False
        Me.GBbtnRemoveLinks.Size = New System.Drawing.Size(105, 23)
        Me.GBbtnRemoveLinks.TabIndex = 6
        Me.GBbtnRemoveLinks.Text = "Remove Links"
        Me.GBbtnRemoveLinks.Transparent = False
        '
        'GBbtnAddLinks
        '
        Me.GBbtnAddLinks.Color = System.Drawing.Color.Empty
        Me.GBbtnAddLinks.Colors = New ExTraffic.Bloom(-1) {}
        Me.GBbtnAddLinks.Customization = ""
        Me.GBbtnAddLinks.EnableGlass = True
        Me.GBbtnAddLinks.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.GBbtnAddLinks.Image = Nothing
        Me.GBbtnAddLinks.Location = New System.Drawing.Point(123, 40)
        Me.GBbtnAddLinks.Name = "GBbtnAddLinks"
        Me.GBbtnAddLinks.NoRounding = False
        Me.GBbtnAddLinks.Size = New System.Drawing.Size(71, 23)
        Me.GBbtnAddLinks.TabIndex = 5
        Me.GBbtnAddLinks.Text = "Add Links"
        Me.GBbtnAddLinks.Transparent = False
        '
        'GhostControlBox1
        '
        Me.GhostControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GhostControlBox1.Customization = "QEBA/wAAAP9aWlr/"
        Me.GhostControlBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.GhostControlBox1.Image = Nothing
        Me.GhostControlBox1.Location = New System.Drawing.Point(346, 3)
        Me.GhostControlBox1.Name = "GhostControlBox1"
        Me.GhostControlBox1.NoRounding = False
        Me.GhostControlBox1.Size = New System.Drawing.Size(71, 19)
        Me.GhostControlBox1.TabIndex = 4
        Me.GhostControlBox1.Text = "GhostControlBox1"
        Me.GhostControlBox1.Transparent = False
        '
        'lbStatus
        '
        Me.lbStatus.AutoSize = True
        Me.lbStatus.BackColor = System.Drawing.Color.Transparent
        Me.lbStatus.ForeColor = System.Drawing.Color.Lime
        Me.lbStatus.Location = New System.Drawing.Point(18, 240)
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(69, 13)
        Me.lbStatus.TabIndex = 3
        Me.lbStatus.Text = "Status : nil"
        '
        'GGBLinks
        '
        Me.GGBLinks.Colors = New ExTraffic.Bloom(-1) {}
        Me.GGBLinks.Controls.Add(Me.LBLinks)
        Me.GGBLinks.Customization = ""
        Me.GGBLinks.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.GGBLinks.Image = Nothing
        Me.GGBLinks.Location = New System.Drawing.Point(12, 69)
        Me.GGBLinks.Name = "GGBLinks"
        Me.GGBLinks.NoRounding = False
        Me.GGBLinks.Size = New System.Drawing.Size(397, 135)
        Me.GGBLinks.TabIndex = 0
        Me.GGBLinks.Text = "Your Links :"
        Me.GGBLinks.Transparent = False
        '
        'LBLinks
        '
        Me.LBLinks.FormattingEnabled = True
        Me.LBLinks.Location = New System.Drawing.Point(3, 24)
        Me.LBLinks.Name = "LBLinks"
        Me.LBLinks.Size = New System.Drawing.Size(391, 108)
        Me.LBLinks.TabIndex = 0
        '
        'FRMMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 284)
        Me.Controls.Add(Me.GTMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(421, 284)
        Me.MinimumSize = New System.Drawing.Size(421, 284)
        Me.Name = "FRMMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.GTMain.ResumeLayout(False)
        Me.GTMain.PerformLayout()
        Me.GGBLinks.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GTMain As ExTraffic.GhostTheme
    Friend WithEvents lbStatus As System.Windows.Forms.Label
    Friend WithEvents GBbtnStopSurf As ExTraffic.GhostButton
    Friend WithEvents GBbtnStartSurf As ExTraffic.GhostButton
    Friend WithEvents GGBLinks As ExTraffic.GhostGroupBox
    Friend WithEvents LBLinks As System.Windows.Forms.ListBox
    Friend WithEvents GhostControlBox1 As ExTraffic.GhostControlBox
    Friend WithEvents GBbtnRemoveLinks As ExTraffic.GhostButton
    Friend WithEvents GBbtnAddLinks As ExTraffic.GhostButton
    Friend WithEvents wb As System.Windows.Forms.WebBrowser
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lbDelayStatus As System.Windows.Forms.Label

End Class
