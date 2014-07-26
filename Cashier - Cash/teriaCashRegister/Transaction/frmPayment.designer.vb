<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayment))
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.RibbonBar1 = New DevComponents.DotNetBar.RibbonBar
        Me.cmdf4 = New DevComponents.DotNetBar.ButtonItem
        Me.cmdf10 = New DevComponents.DotNetBar.ButtonItem
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.t1 = New DevComponents.Editors.DoubleInput
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.t2a = New DevComponents.Editors.IntegerInput
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX
        Me.t2 = New DevComponents.Editors.DoubleInput
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.t3 = New DevComponents.Editors.DoubleInput
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.t4 = New DevComponents.Editors.DoubleInput
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.t4a = New DevComponents.Editors.DoubleInput
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.t5 = New DevComponents.Editors.DoubleInput
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX
        Me.c1 = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.t6 = New DevComponents.Editors.DoubleInput
        Me.LabelX17 = New DevComponents.DotNetBar.LabelX
        Me.c2 = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.t7 = New DevComponents.Editors.DoubleInput
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX
        Me.c3 = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.t8 = New DevComponents.Editors.DoubleInput
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX
        Me.c4 = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.t9 = New DevComponents.Editors.DoubleInput
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.t10 = New DevComponents.Editors.DoubleInput
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.cmbPrinters = New System.Windows.Forms.ComboBox
        Me.RibbonBar1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.t1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t2a, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t4a, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
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
        Me.RibbonBar1.Controls.Add(Me.cmbPrinters)
        Me.RibbonBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RibbonBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.cmdf4, Me.cmdf10})
        Me.RibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Size = New System.Drawing.Size(469, 76)
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
        'cmdf4
        '
        Me.cmdf4.FixedSize = New System.Drawing.Size(65, 67)
        Me.cmdf4.Image = CType(resources.GetObject("cmdf4.Image"), System.Drawing.Image)
        Me.cmdf4.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdf4.Name = "cmdf4"
        Me.cmdf4.Text = "(F1) Bayar"
        '
        'cmdf10
        '
        Me.cmdf10.FixedSize = New System.Drawing.Size(65, 67)
        Me.cmdf10.Image = CType(resources.GetObject("cmdf10.Image"), System.Drawing.Image)
        Me.cmdf10.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdf10.Name = "cmdf10"
        Me.cmdf10.Text = "(Esc) Keluar"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX1)
        Me.FlowLayoutPanel1.Controls.Add(Me.t1)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX2)
        Me.FlowLayoutPanel1.Controls.Add(Me.t2a)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX11)
        Me.FlowLayoutPanel1.Controls.Add(Me.t2)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX3)
        Me.FlowLayoutPanel1.Controls.Add(Me.t3)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX4)
        Me.FlowLayoutPanel1.Controls.Add(Me.t4)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX5)
        Me.FlowLayoutPanel1.Controls.Add(Me.t4a)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX6)
        Me.FlowLayoutPanel1.Controls.Add(Me.t5)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX8)
        Me.FlowLayoutPanel1.Controls.Add(Me.c1)
        Me.FlowLayoutPanel1.Controls.Add(Me.t6)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX17)
        Me.FlowLayoutPanel1.Controls.Add(Me.c2)
        Me.FlowLayoutPanel1.Controls.Add(Me.t7)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX9)
        Me.FlowLayoutPanel1.Controls.Add(Me.c3)
        Me.FlowLayoutPanel1.Controls.Add(Me.t8)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX10)
        Me.FlowLayoutPanel1.Controls.Add(Me.c4)
        Me.FlowLayoutPanel1.Controls.Add(Me.t9)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX7)
        Me.FlowLayoutPanel1.Controls.Add(Me.t10)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 76)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(469, 416)
        Me.FlowLayoutPanel1.TabIndex = 147
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(3, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(171, 21)
        Me.LabelX1.TabIndex = 2
        Me.LabelX1.Text = "Sub Total"
        '
        't1
        '
        '
        '
        '
        Me.t1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.t1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.t1.DisplayFormat = "#,0"
        Me.t1.Enabled = False
        Me.t1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t1.Increment = 1
        Me.t1.Location = New System.Drawing.Point(180, 3)
        Me.t1.MaxValue = 1000000000
        Me.t1.MinValue = 0
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(282, 29)
        Me.t1.TabIndex = 0
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(3, 38)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(114, 21)
        Me.LabelX2.TabIndex = 111
        Me.LabelX2.Text = "Diskon"
        '
        't2a
        '
        '
        '
        '
        Me.t2a.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.t2a.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t2a.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.t2a.Enabled = False
        Me.t2a.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t2a.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center
        Me.t2a.Location = New System.Drawing.Point(123, 38)
        Me.t2a.MaxValue = 100
        Me.t2a.MinValue = 0
        Me.t2a.Name = "t2a"
        Me.t2a.ShowUpDown = True
        Me.t2a.Size = New System.Drawing.Size(78, 29)
        Me.t2a.TabIndex = 144
        '
        'LabelX11
        '
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX11.Location = New System.Drawing.Point(207, 38)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(20, 29)
        Me.LabelX11.TabIndex = 145
        Me.LabelX11.Text = "%"
        '
        't2
        '
        '
        '
        '
        Me.t2.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.t2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t2.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.t2.DisplayFormat = "#,0"
        Me.t2.Enabled = False
        Me.t2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t2.Increment = 1
        Me.t2.Location = New System.Drawing.Point(233, 38)
        Me.t2.MaxValue = 1000000000
        Me.t2.MinValue = 0
        Me.t2.Name = "t2"
        Me.t2.Size = New System.Drawing.Size(229, 29)
        Me.t2.TabIndex = 1
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(3, 73)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(171, 21)
        Me.LabelX3.TabIndex = 113
        Me.LabelX3.Text = "Pembulatan"
        '
        't3
        '
        '
        '
        '
        Me.t3.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.t3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t3.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.t3.DisplayFormat = "#,0"
        Me.t3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t3.Increment = 1
        Me.t3.Location = New System.Drawing.Point(180, 73)
        Me.t3.MaxValue = 999
        Me.t3.MinValue = 0
        Me.t3.Name = "t3"
        Me.t3.Size = New System.Drawing.Size(282, 29)
        Me.t3.TabIndex = 2
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(3, 108)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(171, 21)
        Me.LabelX4.TabIndex = 115
        Me.LabelX4.Text = "Biaya Kartu Kredit"
        '
        't4
        '
        '
        '
        '
        Me.t4.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.t4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t4.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.t4.DisplayFormat = "#,0"
        Me.t4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t4.Increment = 1
        Me.t4.Location = New System.Drawing.Point(180, 108)
        Me.t4.MaxValue = 10000000
        Me.t4.MinValue = 0
        Me.t4.Name = "t4"
        Me.t4.Size = New System.Drawing.Size(282, 29)
        Me.t4.TabIndex = 3
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(3, 143)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(171, 21)
        Me.LabelX5.TabIndex = 122
        Me.LabelX5.Text = "Total"
        '
        't4a
        '
        '
        '
        '
        Me.t4a.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.t4a.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t4a.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.t4a.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.t4a.DisplayFormat = "#,0"
        Me.t4a.Enabled = False
        Me.t4a.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t4a.Increment = 1
        Me.t4a.Location = New System.Drawing.Point(180, 143)
        Me.t4a.MaxValue = 1000000000
        Me.t4a.MinValue = 0
        Me.t4a.Name = "t4a"
        Me.t4a.Size = New System.Drawing.Size(282, 29)
        Me.t4a.TabIndex = 142
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(3, 178)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(224, 21)
        Me.LabelX6.TabIndex = 124
        Me.LabelX6.Text = "Tunai"
        '
        't5
        '
        '
        '
        '
        Me.t5.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.t5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t5.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.t5.DisplayFormat = "#,0"
        Me.t5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t5.Increment = 1
        Me.t5.Location = New System.Drawing.Point(233, 178)
        Me.t5.MaxValue = 1000000000
        Me.t5.MinValue = 0
        Me.t5.Name = "t5"
        Me.t5.Size = New System.Drawing.Size(229, 29)
        Me.t5.TabIndex = 4
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.Location = New System.Drawing.Point(3, 213)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(114, 21)
        Me.LabelX8.TabIndex = 126
        Me.LabelX8.Text = "Debit"
        '
        'c1
        '
        Me.c1.DisplayMember = "Text"
        Me.c1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.c1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1.FormattingEnabled = True
        Me.c1.ItemHeight = 23
        Me.c1.Location = New System.Drawing.Point(123, 213)
        Me.c1.Name = "c1"
        Me.c1.Size = New System.Drawing.Size(104, 29)
        Me.c1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.c1.TabIndex = 5
        '
        't6
        '
        '
        '
        '
        Me.t6.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.t6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t6.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.t6.DisplayFormat = "#,0"
        Me.t6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t6.Increment = 1
        Me.t6.Location = New System.Drawing.Point(233, 213)
        Me.t6.MaxValue = 1000000000
        Me.t6.MinValue = 0
        Me.t6.Name = "t6"
        Me.t6.Size = New System.Drawing.Size(230, 29)
        Me.t6.TabIndex = 6
        '
        'LabelX17
        '
        '
        '
        '
        Me.LabelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX17.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX17.Location = New System.Drawing.Point(3, 248)
        Me.LabelX17.Name = "LabelX17"
        Me.LabelX17.Size = New System.Drawing.Size(114, 21)
        Me.LabelX17.TabIndex = 133
        Me.LabelX17.Text = "Kartu Kredit"
        '
        'c2
        '
        Me.c2.DisplayMember = "Text"
        Me.c2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.c2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c2.FormattingEnabled = True
        Me.c2.ItemHeight = 23
        Me.c2.Location = New System.Drawing.Point(123, 248)
        Me.c2.Name = "c2"
        Me.c2.Size = New System.Drawing.Size(104, 29)
        Me.c2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.c2.TabIndex = 7
        '
        't7
        '
        Me.t7.AccessibleDescription = ""
        '
        '
        '
        Me.t7.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.t7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t7.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.t7.DisplayFormat = "#,0"
        Me.t7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t7.Increment = 1
        Me.t7.Location = New System.Drawing.Point(233, 248)
        Me.t7.MaxValue = 1000000000
        Me.t7.MinValue = 0
        Me.t7.Name = "t7"
        Me.t7.Size = New System.Drawing.Size(229, 29)
        Me.t7.TabIndex = 8
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX9.Location = New System.Drawing.Point(3, 283)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(114, 21)
        Me.LabelX9.TabIndex = 136
        Me.LabelX9.Text = "Voucher"
        '
        'c3
        '
        Me.c3.DisplayMember = "Text"
        Me.c3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.c3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c3.FormattingEnabled = True
        Me.c3.ItemHeight = 23
        Me.c3.Location = New System.Drawing.Point(123, 283)
        Me.c3.Name = "c3"
        Me.c3.Size = New System.Drawing.Size(104, 29)
        Me.c3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.c3.TabIndex = 9
        '
        't8
        '
        '
        '
        '
        Me.t8.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.t8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t8.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.t8.DisplayFormat = "#,0"
        Me.t8.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t8.Increment = 1
        Me.t8.Location = New System.Drawing.Point(233, 283)
        Me.t8.MaxValue = 1000000000
        Me.t8.MinValue = 0
        Me.t8.Name = "t8"
        Me.t8.Size = New System.Drawing.Size(229, 29)
        Me.t8.TabIndex = 10
        '
        'LabelX10
        '
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX10.Location = New System.Drawing.Point(3, 318)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(114, 21)
        Me.LabelX10.TabIndex = 139
        Me.LabelX10.Text = "Transfer"
        '
        'c4
        '
        Me.c4.DisplayMember = "Text"
        Me.c4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.c4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c4.FormattingEnabled = True
        Me.c4.ItemHeight = 23
        Me.c4.Location = New System.Drawing.Point(123, 318)
        Me.c4.Name = "c4"
        Me.c4.Size = New System.Drawing.Size(104, 29)
        Me.c4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.c4.TabIndex = 11
        '
        't9
        '
        '
        '
        '
        Me.t9.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.t9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t9.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.t9.DisplayFormat = "#,0"
        Me.t9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t9.Increment = 1
        Me.t9.Location = New System.Drawing.Point(233, 318)
        Me.t9.MaxValue = 1000000000
        Me.t9.MinValue = 0
        Me.t9.Name = "t9"
        Me.t9.Size = New System.Drawing.Size(229, 29)
        Me.t9.TabIndex = 12
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(3, 353)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(224, 21)
        Me.LabelX7.TabIndex = 140
        Me.LabelX7.Text = "Kembali"
        '
        't10
        '
        '
        '
        '
        Me.t10.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.t10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t10.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.t10.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.t10.DisplayFormat = "#,0"
        Me.t10.Enabled = False
        Me.t10.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t10.Increment = 1
        Me.t10.Location = New System.Drawing.Point(233, 353)
        Me.t10.MaxValue = 1000000000
        Me.t10.MinValue = -1000000000
        Me.t10.Name = "t10"
        Me.t10.Size = New System.Drawing.Size(229, 29)
        Me.t10.TabIndex = 141
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 470)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(469, 22)
        Me.StatusStrip1.TabIndex = 149
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'cmbPrinters
        '
        Me.cmbPrinters.FormattingEnabled = True
        Me.cmbPrinters.Location = New System.Drawing.Point(272, 20)
        Me.cmbPrinters.Name = "cmbPrinters"
        Me.cmbPrinters.Size = New System.Drawing.Size(121, 21)
        Me.cmbPrinters.TabIndex = 0
        Me.cmbPrinters.Visible = False
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 492)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.RibbonBar1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPayment"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pembayaran"
        Me.RibbonBar1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.t1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t2a, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t4a, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents RibbonBar1 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents c1 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
    Friend WithEvents c2 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents c3 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents c4 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cmdf4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdf10 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents t1 As DevComponents.Editors.DoubleInput
    Friend WithEvents t2 As DevComponents.Editors.DoubleInput
    Friend WithEvents t3 As DevComponents.Editors.DoubleInput
    Friend WithEvents t4 As DevComponents.Editors.DoubleInput
    Friend WithEvents t5 As DevComponents.Editors.DoubleInput
    Friend WithEvents t6 As DevComponents.Editors.DoubleInput
    Friend WithEvents t7 As DevComponents.Editors.DoubleInput
    Friend WithEvents t8 As DevComponents.Editors.DoubleInput
    Friend WithEvents t9 As DevComponents.Editors.DoubleInput
    Friend WithEvents t10 As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents t4a As DevComponents.Editors.DoubleInput
    Friend WithEvents t2a As DevComponents.Editors.IntegerInput
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cmbPrinters As System.Windows.Forms.ComboBox
End Class
