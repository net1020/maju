<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMEmployee))
        Me.Bar1 = New DevComponents.DotNetBar.Bar
        Me.cmdSave = New DevComponents.DotNetBar.ButtonItem
        Me.cmdSaveNew = New DevComponents.DotNetBar.ButtonItem
        Me.cmdExit = New DevComponents.DotNetBar.ButtonItem
        Me.t0 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.t1 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.t2 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.t3 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.t4 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.t5 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.t6 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.t7 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX
        Me.t8 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX
        Me.t9 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX
        Me.t10 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX
        Me.t11 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.SuperTabItem2 = New DevComponents.DotNetBar.SuperTabItem
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX
        Me.t12 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX
        Me.t13 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.SuperTabItem1 = New DevComponents.DotNetBar.SuperTabItem
        Me.SuperTabControlPanel3 = New DevComponents.DotNetBar.SuperTabControlPanel
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel
        Me.c1 = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.c2 = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.c3 = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.c4 = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.c5 = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.c6 = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.c7 = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.c8 = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.c9 = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.c10 = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.SuperTabItem3 = New DevComponents.DotNetBar.SuperTabItem
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuperTabControlPanel1.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.SuperTabControlPanel3.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Bar1
        '
        Me.Bar1.AntiAlias = True
        Me.Bar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.cmdSave, Me.cmdSaveNew, Me.cmdExit})
        Me.Bar1.Location = New System.Drawing.Point(0, 0)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(443, 25)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabIndex = 102
        Me.Bar1.TabStop = False
        Me.Bar1.Text = "Bar1"
        '
        'cmdSave
        '
        Me.cmdSave.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Text = "Save"
        '
        'cmdSaveNew
        '
        Me.cmdSaveNew.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdSaveNew.Image = CType(resources.GetObject("cmdSaveNew.Image"), System.Drawing.Image)
        Me.cmdSaveNew.Name = "cmdSaveNew"
        Me.cmdSaveNew.Text = "Save && New"
        '
        'cmdExit
        '
        Me.cmdExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Text = "Exit"
        '
        't0
        '
        Me.t0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.t0.Border.Class = "TextBoxBorder"
        Me.t0.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t0.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t0.ForeColor = System.Drawing.Color.Black
        Me.t0.Location = New System.Drawing.Point(187, 2)
        Me.t0.Name = "t0"
        Me.t0.Size = New System.Drawing.Size(20, 22)
        Me.t0.TabIndex = 104
        Me.t0.Visible = False
        '
        'SuperTabControl1
        '
        Me.SuperTabControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        '
        '
        '
        Me.SuperTabControl1.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabControl1.ControlBox.MenuBox.Name = ""
        Me.SuperTabControl1.ControlBox.Name = ""
        Me.SuperTabControl1.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabControl1.ControlBox.MenuBox, Me.SuperTabControl1.ControlBox.CloseBox})
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel2)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel1)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel3)
        Me.SuperTabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SuperTabControl1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl1.ForeColor = System.Drawing.Color.Black
        Me.SuperTabControl1.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControl1.Name = "SuperTabControl1"
        Me.SuperTabControl1.ReorderTabsEnabled = True
        Me.SuperTabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SuperTabControl1.SelectedTabIndex = 0
        Me.SuperTabControl1.Size = New System.Drawing.Size(443, 337)
        Me.SuperTabControl1.TabFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl1.TabIndex = 105
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem2, Me.SuperTabItem1, Me.SuperTabItem3})
        Me.SuperTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue
        Me.SuperTabControl1.Text = "SuperTabControl1"
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.SuperTabControlPanel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(443, 312)
        Me.SuperTabControlPanel2.TabIndex = 0
        Me.SuperTabControlPanel2.TabItem = Me.SuperTabItem2
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX1)
        Me.FlowLayoutPanel1.Controls.Add(Me.t1)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX2)
        Me.FlowLayoutPanel1.Controls.Add(Me.t2)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX3)
        Me.FlowLayoutPanel1.Controls.Add(Me.t3)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX4)
        Me.FlowLayoutPanel1.Controls.Add(Me.t4)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX5)
        Me.FlowLayoutPanel1.Controls.Add(Me.t5)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX6)
        Me.FlowLayoutPanel1.Controls.Add(Me.t6)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX7)
        Me.FlowLayoutPanel1.Controls.Add(Me.t7)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX8)
        Me.FlowLayoutPanel1.Controls.Add(Me.t8)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX9)
        Me.FlowLayoutPanel1.Controls.Add(Me.t9)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX10)
        Me.FlowLayoutPanel1.Controls.Add(Me.t10)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX11)
        Me.FlowLayoutPanel1.Controls.Add(Me.t11)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(443, 312)
        Me.FlowLayoutPanel1.TabIndex = 104
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(3, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(86, 21)
        Me.LabelX1.TabIndex = 2
        Me.LabelX1.Text = "First Name"
        '
        't1
        '
        Me.t1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.t1.Border.Class = "TextBoxBorder"
        Me.t1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t1.ForeColor = System.Drawing.Color.Black
        Me.t1.Location = New System.Drawing.Point(95, 3)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(340, 22)
        Me.t1.TabIndex = 3
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(3, 31)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(86, 21)
        Me.LabelX2.TabIndex = 4
        Me.LabelX2.Text = "Last Name"
        '
        't2
        '
        Me.t2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.t2.Border.Class = "TextBoxBorder"
        Me.t2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t2.ForeColor = System.Drawing.Color.Black
        Me.t2.Location = New System.Drawing.Point(95, 31)
        Me.t2.Name = "t2"
        Me.t2.Size = New System.Drawing.Size(340, 22)
        Me.t2.TabIndex = 5
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(3, 59)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(86, 21)
        Me.LabelX3.TabIndex = 6
        Me.LabelX3.Text = "Email"
        '
        't3
        '
        Me.t3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.t3.Border.Class = "TextBoxBorder"
        Me.t3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t3.ForeColor = System.Drawing.Color.Black
        Me.t3.Location = New System.Drawing.Point(95, 59)
        Me.t3.Name = "t3"
        Me.t3.Size = New System.Drawing.Size(340, 22)
        Me.t3.TabIndex = 7
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(3, 87)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(86, 21)
        Me.LabelX4.TabIndex = 8
        Me.LabelX4.Text = "Phone"
        '
        't4
        '
        Me.t4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.t4.Border.Class = "TextBoxBorder"
        Me.t4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t4.ForeColor = System.Drawing.Color.Black
        Me.t4.Location = New System.Drawing.Point(95, 87)
        Me.t4.Name = "t4"
        Me.t4.Size = New System.Drawing.Size(340, 22)
        Me.t4.TabIndex = 9
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(3, 115)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(86, 21)
        Me.LabelX5.TabIndex = 10
        Me.LabelX5.Text = "Address 1"
        '
        't5
        '
        Me.t5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.t5.Border.Class = "TextBoxBorder"
        Me.t5.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t5.ForeColor = System.Drawing.Color.Black
        Me.t5.Location = New System.Drawing.Point(95, 115)
        Me.t5.Name = "t5"
        Me.t5.Size = New System.Drawing.Size(340, 22)
        Me.t5.TabIndex = 11
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(3, 143)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(86, 21)
        Me.LabelX6.TabIndex = 12
        Me.LabelX6.Text = "Address 2"
        '
        't6
        '
        Me.t6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.t6.Border.Class = "TextBoxBorder"
        Me.t6.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t6.ForeColor = System.Drawing.Color.Black
        Me.t6.Location = New System.Drawing.Point(95, 143)
        Me.t6.Name = "t6"
        Me.t6.Size = New System.Drawing.Size(340, 22)
        Me.t6.TabIndex = 13
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(3, 171)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(86, 21)
        Me.LabelX7.TabIndex = 14
        Me.LabelX7.Text = "City"
        '
        't7
        '
        Me.t7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.t7.Border.Class = "TextBoxBorder"
        Me.t7.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t7.ForeColor = System.Drawing.Color.Black
        Me.t7.Location = New System.Drawing.Point(95, 171)
        Me.t7.Name = "t7"
        Me.t7.Size = New System.Drawing.Size(340, 22)
        Me.t7.TabIndex = 15
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.Location = New System.Drawing.Point(3, 199)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(86, 21)
        Me.LabelX8.TabIndex = 16
        Me.LabelX8.Text = "State"
        '
        't8
        '
        Me.t8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.t8.Border.Class = "TextBoxBorder"
        Me.t8.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t8.ForeColor = System.Drawing.Color.Black
        Me.t8.Location = New System.Drawing.Point(95, 199)
        Me.t8.Name = "t8"
        Me.t8.Size = New System.Drawing.Size(340, 22)
        Me.t8.TabIndex = 17
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX9.Location = New System.Drawing.Point(3, 227)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(86, 21)
        Me.LabelX9.TabIndex = 18
        Me.LabelX9.Text = "Zip"
        '
        't9
        '
        Me.t9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.t9.Border.Class = "TextBoxBorder"
        Me.t9.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t9.ForeColor = System.Drawing.Color.Black
        Me.t9.Location = New System.Drawing.Point(95, 227)
        Me.t9.Name = "t9"
        Me.t9.Size = New System.Drawing.Size(340, 22)
        Me.t9.TabIndex = 19
        '
        'LabelX10
        '
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX10.Location = New System.Drawing.Point(3, 255)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(86, 21)
        Me.LabelX10.TabIndex = 20
        Me.LabelX10.Text = "Country"
        '
        't10
        '
        Me.t10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.t10.Border.Class = "TextBoxBorder"
        Me.t10.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t10.ForeColor = System.Drawing.Color.Black
        Me.t10.Location = New System.Drawing.Point(95, 255)
        Me.t10.Name = "t10"
        Me.t10.Size = New System.Drawing.Size(340, 22)
        Me.t10.TabIndex = 21
        '
        'LabelX11
        '
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX11.Location = New System.Drawing.Point(3, 283)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(86, 21)
        Me.LabelX11.TabIndex = 22
        Me.LabelX11.Text = "Comments"
        '
        't11
        '
        Me.t11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.t11.Border.Class = "TextBoxBorder"
        Me.t11.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t11.ForeColor = System.Drawing.Color.Black
        Me.t11.Location = New System.Drawing.Point(95, 283)
        Me.t11.Name = "t11"
        Me.t11.Size = New System.Drawing.Size(340, 22)
        Me.t11.TabIndex = 23
        '
        'SuperTabItem2
        '
        Me.SuperTabItem2.AttachedControl = Me.SuperTabControlPanel2
        Me.SuperTabItem2.GlobalItem = False
        Me.SuperTabItem2.Name = "SuperTabItem2"
        Me.SuperTabItem2.Text = "Personal"
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Controls.Add(Me.FlowLayoutPanel3)
        Me.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(443, 312)
        Me.SuperTabControlPanel1.TabIndex = 1
        Me.SuperTabControlPanel1.TabItem = Me.SuperTabItem1
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel3.Controls.Add(Me.LabelX12)
        Me.FlowLayoutPanel3.Controls.Add(Me.t12)
        Me.FlowLayoutPanel3.Controls.Add(Me.LabelX13)
        Me.FlowLayoutPanel3.Controls.Add(Me.t13)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(443, 312)
        Me.FlowLayoutPanel3.TabIndex = 105
        '
        'LabelX12
        '
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX12.Location = New System.Drawing.Point(3, 3)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(86, 21)
        Me.LabelX12.TabIndex = 2
        Me.LabelX12.Text = "User Name"
        '
        't12
        '
        Me.t12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.t12.Border.Class = "TextBoxBorder"
        Me.t12.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t12.ForeColor = System.Drawing.Color.Black
        Me.t12.Location = New System.Drawing.Point(95, 3)
        Me.t12.Name = "t12"
        Me.t12.Size = New System.Drawing.Size(340, 22)
        Me.t12.TabIndex = 3
        '
        'LabelX13
        '
        '
        '
        '
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX13.Location = New System.Drawing.Point(3, 31)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(86, 21)
        Me.LabelX13.TabIndex = 4
        Me.LabelX13.Text = "Password"
        '
        't13
        '
        Me.t13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.t13.Border.Class = "TextBoxBorder"
        Me.t13.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t13.ForeColor = System.Drawing.Color.Black
        Me.t13.Location = New System.Drawing.Point(95, 31)
        Me.t13.Name = "t13"
        Me.t13.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.t13.Size = New System.Drawing.Size(340, 22)
        Me.t13.TabIndex = 5
        Me.t13.UseSystemPasswordChar = True
        '
        'SuperTabItem1
        '
        Me.SuperTabItem1.AttachedControl = Me.SuperTabControlPanel1
        Me.SuperTabItem1.GlobalItem = False
        Me.SuperTabItem1.Name = "SuperTabItem1"
        Me.SuperTabItem1.Text = "User Login"
        '
        'SuperTabControlPanel3
        '
        Me.SuperTabControlPanel3.Controls.Add(Me.FlowLayoutPanel2)
        Me.SuperTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel3.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel3.Name = "SuperTabControlPanel3"
        Me.SuperTabControlPanel3.Size = New System.Drawing.Size(443, 312)
        Me.SuperTabControlPanel3.TabIndex = 0
        Me.SuperTabControlPanel3.TabItem = Me.SuperTabItem3
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel2.Controls.Add(Me.c1)
        Me.FlowLayoutPanel2.Controls.Add(Me.c2)
        Me.FlowLayoutPanel2.Controls.Add(Me.c3)
        Me.FlowLayoutPanel2.Controls.Add(Me.c4)
        Me.FlowLayoutPanel2.Controls.Add(Me.c5)
        Me.FlowLayoutPanel2.Controls.Add(Me.c6)
        Me.FlowLayoutPanel2.Controls.Add(Me.c7)
        Me.FlowLayoutPanel2.Controls.Add(Me.c8)
        Me.FlowLayoutPanel2.Controls.Add(Me.c9)
        Me.FlowLayoutPanel2.Controls.Add(Me.c10)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(443, 312)
        Me.FlowLayoutPanel2.TabIndex = 105
        '
        'c1
        '
        '
        '
        '
        Me.c1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.c1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1.Location = New System.Drawing.Point(3, 3)
        Me.c1.Name = "c1"
        Me.c1.Size = New System.Drawing.Size(443, 21)
        Me.c1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.c1.TabIndex = 28
        Me.c1.Text = "Customer"
        '
        'c2
        '
        '
        '
        '
        Me.c2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.c2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c2.Location = New System.Drawing.Point(3, 30)
        Me.c2.Name = "c2"
        Me.c2.Size = New System.Drawing.Size(443, 21)
        Me.c2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.c2.TabIndex = 29
        Me.c2.Text = "Employee"
        '
        'c3
        '
        '
        '
        '
        Me.c3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.c3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c3.Location = New System.Drawing.Point(3, 57)
        Me.c3.Name = "c3"
        Me.c3.Size = New System.Drawing.Size(443, 21)
        Me.c3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.c3.TabIndex = 30
        Me.c3.Text = "Vendor"
        '
        'c4
        '
        '
        '
        '
        Me.c4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.c4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c4.Location = New System.Drawing.Point(3, 84)
        Me.c4.Name = "c4"
        Me.c4.Size = New System.Drawing.Size(443, 21)
        Me.c4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.c4.TabIndex = 31
        Me.c4.Text = "Items"
        '
        'c5
        '
        '
        '
        '
        Me.c5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.c5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c5.Location = New System.Drawing.Point(3, 111)
        Me.c5.Name = "c5"
        Me.c5.Size = New System.Drawing.Size(443, 21)
        Me.c5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.c5.TabIndex = 32
        Me.c5.Text = "Category"
        '
        'c6
        '
        '
        '
        '
        Me.c6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.c6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c6.Location = New System.Drawing.Point(3, 138)
        Me.c6.Name = "c6"
        Me.c6.Size = New System.Drawing.Size(443, 21)
        Me.c6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.c6.TabIndex = 33
        Me.c6.Text = "Sales"
        '
        'c7
        '
        '
        '
        '
        Me.c7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.c7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c7.Location = New System.Drawing.Point(3, 165)
        Me.c7.Name = "c7"
        Me.c7.Size = New System.Drawing.Size(443, 21)
        Me.c7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.c7.TabIndex = 34
        Me.c7.Text = "Receive"
        '
        'c8
        '
        '
        '
        '
        Me.c8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.c8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c8.Location = New System.Drawing.Point(3, 192)
        Me.c8.Name = "c8"
        Me.c8.Size = New System.Drawing.Size(443, 21)
        Me.c8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.c8.TabIndex = 35
        Me.c8.Text = "Report"
        '
        'c9
        '
        '
        '
        '
        Me.c9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.c9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c9.Location = New System.Drawing.Point(3, 219)
        Me.c9.Name = "c9"
        Me.c9.Size = New System.Drawing.Size(443, 21)
        Me.c9.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.c9.TabIndex = 36
        Me.c9.Text = "Voucher"
        '
        'c10
        '
        '
        '
        '
        Me.c10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.c10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c10.Location = New System.Drawing.Point(3, 246)
        Me.c10.Name = "c10"
        Me.c10.Size = New System.Drawing.Size(443, 21)
        Me.c10.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.c10.TabIndex = 37
        Me.c10.Text = "Profile"
        '
        'SuperTabItem3
        '
        Me.SuperTabItem3.AttachedControl = Me.SuperTabControlPanel3
        Me.SuperTabItem3.GlobalItem = False
        Me.SuperTabItem3.Name = "SuperTabItem3"
        Me.SuperTabItem3.Text = "User Access"
        '
        'frmMEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 364)
        Me.Controls.Add(Me.SuperTabControl1)
        Me.Controls.Add(Me.Bar1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMEmployee"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee"
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.SuperTabControlPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.SuperTabControlPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.SuperTabControlPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents cmdSave As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdSaveNew As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdExit As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents t0 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents SuperTabControl1 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents t1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents t2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents t3 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents t4 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents t5 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents t6 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents t7 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents t8 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents t9 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents t10 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents t11 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents SuperTabItem2 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel3 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents c1 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents c2 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents c3 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents c4 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents c5 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents c6 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents c7 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents c8 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents c9 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents c10 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents SuperTabItem3 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem1 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents t12 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents t13 As DevComponents.DotNetBar.Controls.TextBoxX
End Class
