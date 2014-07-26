<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaymentDone
    Inherits DevComponents.DotNetBar.Office2007Form

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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPaymentDone))
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.RibbonBar1 = New DevComponents.DotNetBar.RibbonBar
        Me.cmdf1 = New DevComponents.DotNetBar.ButtonItem
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.lblChange = New DevComponents.DotNetBar.LabelX
        Me.t1 = New DevComponents.Editors.DoubleInput
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.t1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Silver
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(232, Byte), Integer)))
        '
        'RibbonBar1
        '
        Me.RibbonBar1.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar1.ContainerControlProcessDialogKey = True
        Me.RibbonBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RibbonBar1.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right
        Me.RibbonBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.cmdf1})
        Me.RibbonBar1.Location = New System.Drawing.Point(0, 103)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Size = New System.Drawing.Size(469, 70)
        Me.RibbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar1.TabIndex = 143
        Me.RibbonBar1.Text = "RibbonBar1"
        '
        '
        '
        Me.RibbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar1.TitleVisible = False
        '
        'cmdf1
        '
        Me.cmdf1.FixedSize = New System.Drawing.Size(60, 67)
        Me.cmdf1.Image = CType(resources.GetObject("cmdf1.Image"), System.Drawing.Image)
        Me.cmdf1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdf1.Name = "cmdf1"
        Me.cmdf1.Text = "(F1)               New Sales    "
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX7)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblChange)
        Me.FlowLayoutPanel1.Controls.Add(Me.t1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(469, 103)
        Me.FlowLayoutPanel1.TabIndex = 147
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(3, 3)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(154, 100)
        Me.LabelX7.TabIndex = 140
        Me.LabelX7.Text = "Kembali"
        '
        'lblChange
        '
        '
        '
        '
        Me.lblChange.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblChange.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(163, 3)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(302, 100)
        Me.lblChange.TabIndex = 2
        Me.lblChange.Text = "Rp 1.000.000"
        Me.lblChange.TextAlignment = System.Drawing.StringAlignment.Far
        '
        't1
        '
        '
        '
        '
        Me.t1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.t1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.t1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t1.Increment = 1
        Me.t1.Location = New System.Drawing.Point(3, 109)
        Me.t1.MaxValue = 1000000000
        Me.t1.MinValue = 0
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(282, 29)
        Me.t1.TabIndex = 141
        '
        'frmPaymentDone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 173)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.RibbonBar1)
        Me.EnableGlass = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPaymentDone"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pembayaran Selesai"
        Me.TopMost = True
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.t1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents RibbonBar1 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lblChange As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmdf1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents t1 As DevComponents.Editors.DoubleInput
End Class
