<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchaseOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPurchaseOrder))
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim SuperTabItemColorTable1 As DevComponents.DotNetBar.Rendering.SuperTabItemColorTable = New DevComponents.DotNetBar.Rendering.SuperTabItemColorTable
        Dim SuperTabColorStates1 As DevComponents.DotNetBar.Rendering.SuperTabColorStates = New DevComponents.DotNetBar.Rendering.SuperTabColorStates
        Dim SuperTabItemStateColorTable1 As DevComponents.DotNetBar.Rendering.SuperTabItemStateColorTable = New DevComponents.DotNetBar.Rendering.SuperTabItemStateColorTable
        Me.t0 = New System.Windows.Forms.TextBox
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.t2 = New System.Windows.Forms.TextBox
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.t3 = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.t4 = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.Bar1 = New DevComponents.DotNetBar.Bar
        Me.cmbReport = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.cmdSave = New DevComponents.DotNetBar.ButtonItem
        Me.cmdEdit = New DevComponents.DotNetBar.ButtonItem
        Me.cmdAdd = New DevComponents.DotNetBar.ButtonItem
        Me.cmdPreview = New DevComponents.DotNetBar.ButtonItem
        Me.ControlContainerItem1 = New DevComponents.DotNetBar.ControlContainerItem
        Me.cmdPrint = New DevComponents.DotNetBar.ButtonItem
        Me.cmdExit = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel
        Me.LabelX17 = New DevComponents.DotNetBar.LabelX
        Me.cmbWarehouse = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.cmdWarehouse = New DevComponents.DotNetBar.ButtonX
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX
        Me.cmbPayment = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.cmdPayment = New DevComponents.DotNetBar.ButtonX
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX
        Me.dtDelivery = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.txtTransno = New System.Windows.Forms.TextBox
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.dtTrans = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.cmbCustomer = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.cmdCustomer = New DevComponents.DotNetBar.ButtonX
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.tTotal = New DevComponents.DotNetBar.LabelX
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX
        Me.txtNote = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel
        Me.TB2 = New DevComponents.DotNetBar.SuperTabControl
        Me.SuperTabControlPanel3 = New DevComponents.DotNetBar.SuperTabControlPanel
        Me.grid1 = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.btnremove = New DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.qtyrcv = New DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewDoubleInputColumn2 = New DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
        Me.Column1 = New DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
        Me.total = New DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
        Me.SuperTabItem4 = New DevComponents.DotNetBar.SuperTabItem
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX
        Me.tAmount = New DevComponents.Editors.DoubleInput
        Me.LabelX18 = New DevComponents.DotNetBar.LabelX
        Me.tDisccent = New DevComponents.Editors.DoubleInput
        Me.LabelX19 = New DevComponents.DotNetBar.LabelX
        Me.tDiscamount = New DevComponents.Editors.DoubleInput
        Me.LabelX25 = New DevComponents.DotNetBar.LabelX
        Me.tpreTotal = New DevComponents.Editors.DoubleInput
        Me.LabelX20 = New DevComponents.DotNetBar.LabelX
        Me.tPPNcent = New DevComponents.Editors.DoubleInput
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX
        Me.tPPNamount = New DevComponents.Editors.DoubleInput
        Me.LabelX21 = New DevComponents.DotNetBar.LabelX
        Me.tOtherfee = New DevComponents.Editors.DoubleInput
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX
        Me.tSubtotal = New DevComponents.Editors.DoubleInput
        Me.LabelX22 = New DevComponents.DotNetBar.LabelX
        Me.tDP = New DevComponents.Editors.DoubleInput
        Me.LabelX23 = New DevComponents.DotNetBar.LabelX
        Me.tLeftamount = New DevComponents.Editors.DoubleInput
        Me.SuperTabItem3 = New DevComponents.DotNetBar.SuperTabItem
        Me.SuperTabItem2 = New DevComponents.DotNetBar.SuperTabItem
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.t3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bar1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        CType(Me.dtDelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.dtTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel1.SuspendLayout()
        CType(Me.TB2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TB2.SuspendLayout()
        Me.SuperTabControlPanel3.SuspendLayout()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControlPanel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.FlowLayoutPanel5.SuspendLayout()
        CType(Me.tAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tDisccent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tDiscamount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tpreTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tPPNcent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tPPNamount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tOtherfee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tSubtotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tDP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tLeftamount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        't0
        '
        Me.t0.Location = New System.Drawing.Point(392, -102)
        Me.t0.Name = "t0"
        Me.t0.Size = New System.Drawing.Size(27, 20)
        Me.t0.TabIndex = 126
        Me.t0.Visible = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX1)
        Me.FlowLayoutPanel1.Controls.Add(Me.t2)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX4)
        Me.FlowLayoutPanel1.Controls.Add(Me.t3)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX3)
        Me.FlowLayoutPanel1.Controls.Add(Me.t4)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX2)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, -102)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(377, 98)
        Me.FlowLayoutPanel1.TabIndex = 121
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(3, 4)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(118, 22)
        Me.LabelX1.TabIndex = 2
        Me.LabelX1.Text = "Quotation No:"
        '
        't2
        '
        Me.t2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.t2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t2.Location = New System.Drawing.Point(127, 4)
        Me.t2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.t2.Name = "t2"
        Me.t2.Size = New System.Drawing.Size(236, 22)
        Me.t2.TabIndex = 2
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(3, 34)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(118, 22)
        Me.LabelX4.TabIndex = 115
        Me.LabelX4.Text = "Quotation Date:"
        '
        't3
        '
        '
        '
        '
        Me.t3.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.t3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t3.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.t3.ButtonDropDown.Visible = True
        Me.t3.IsPopupCalendarOpen = False
        Me.t3.Location = New System.Drawing.Point(127, 33)
        '
        '
        '
        Me.t3.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.t3.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t3.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.t3.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.t3.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.t3.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.t3.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.t3.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.t3.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.t3.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.t3.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t3.MonthCalendar.DisplayMonth = New Date(2014, 5, 1, 0, 0, 0, 0)
        Me.t3.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.t3.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.t3.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.t3.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.t3.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.t3.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.t3.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t3.MonthCalendar.TodayButtonVisible = True
        Me.t3.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.t3.Name = "t3"
        Me.t3.Size = New System.Drawing.Size(236, 20)
        Me.t3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.t3.TabIndex = 119
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(3, 64)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(118, 22)
        Me.LabelX3.TabIndex = 111
        Me.LabelX3.Text = "Customer Name:"
        '
        't4
        '
        Me.t4.DisplayMember = "Text"
        Me.t4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.t4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.t4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t4.FormattingEnabled = True
        Me.t4.ItemHeight = 16
        Me.t4.Location = New System.Drawing.Point(127, 64)
        Me.t4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.t4.Name = "t4"
        Me.t4.Size = New System.Drawing.Size(236, 22)
        Me.t4.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.t4.TabIndex = 114
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(3, 94)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(118, 26)
        Me.LabelX2.TabIndex = 112
        '
        'Bar1
        '
        Me.Bar1.AccessibleDescription = "DotNetBar Bar (Bar1)"
        Me.Bar1.AccessibleName = "DotNetBar Bar"
        Me.Bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.Bar1.AntiAlias = True
        Me.Bar1.BackColor = System.Drawing.Color.Silver
        Me.Bar1.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.TopLeft
        Me.Bar1.Controls.Add(Me.cmbReport)
        Me.Bar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Bar1.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.cmdSave, Me.cmdEdit, Me.cmdAdd, Me.cmdPreview, Me.ControlContainerItem1, Me.cmdPrint, Me.cmdExit})
        Me.Bar1.ItemSpacing = 11
        Me.Bar1.Location = New System.Drawing.Point(0, 0)
        Me.Bar1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.SingleLineColor = System.Drawing.Color.White
        Me.Bar1.Size = New System.Drawing.Size(779, 27)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Bar1.TabIndex = 120
        Me.Bar1.TabStop = False
        Me.Bar1.Text = "Bar1"
        '
        'cmbReport
        '
        Me.cmbReport.DisplayMember = "Text"
        Me.cmbReport.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReport.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReport.FormattingEnabled = True
        Me.cmbReport.ItemHeight = 16
        Me.cmbReport.Location = New System.Drawing.Point(263, 2)
        Me.cmbReport.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbReport.Name = "cmbReport"
        Me.cmbReport.Size = New System.Drawing.Size(195, 22)
        Me.cmbReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbReport.TabIndex = 116
        '
        'cmdSave
        '
        Me.cmdSave.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Text = "Save"
        '
        'cmdEdit
        '
        Me.cmdEdit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Text = "Edit"
        '
        'cmdAdd
        '
        Me.cmdAdd.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdAdd.Image = CType(resources.GetObject("cmdAdd.Image"), System.Drawing.Image)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Text = "Add"
        '
        'cmdPreview
        '
        Me.cmdPreview.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdPreview.Image = CType(resources.GetObject("cmdPreview.Image"), System.Drawing.Image)
        Me.cmdPreview.Name = "cmdPreview"
        Me.cmdPreview.Text = "Preview"
        '
        'ControlContainerItem1
        '
        Me.ControlContainerItem1.AllowItemResize = False
        Me.ControlContainerItem1.Control = Me.cmbReport
        Me.ControlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ControlContainerItem1.Name = "ControlContainerItem1"
        '
        'cmdPrint
        '
        Me.cmdPrint.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Text = "Print"
        '
        'cmdExit
        '
        Me.cmdExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Text = "Exit"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem1.Image = CType(resources.GetObject("ButtonItem1.Image"), System.Drawing.Image)
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Text = "Print"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.FlowLayoutPanel3)
        Me.Panel2.Controls.Add(Me.FlowLayoutPanel2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 27)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(779, 91)
        Me.Panel2.TabIndex = 136
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.LabelX17)
        Me.FlowLayoutPanel3.Controls.Add(Me.cmbWarehouse)
        Me.FlowLayoutPanel3.Controls.Add(Me.cmdWarehouse)
        Me.FlowLayoutPanel3.Controls.Add(Me.LabelX8)
        Me.FlowLayoutPanel3.Controls.Add(Me.cmbPayment)
        Me.FlowLayoutPanel3.Controls.Add(Me.cmdPayment)
        Me.FlowLayoutPanel3.Controls.Add(Me.LabelX10)
        Me.FlowLayoutPanel3.Controls.Add(Me.dtDelivery)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(402, 0)
        Me.FlowLayoutPanel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(377, 91)
        Me.FlowLayoutPanel3.TabIndex = 130
        '
        'LabelX17
        '
        '
        '
        '
        Me.LabelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX17.Location = New System.Drawing.Point(3, 4)
        Me.LabelX17.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX17.Name = "LabelX17"
        Me.LabelX17.Size = New System.Drawing.Size(118, 22)
        Me.LabelX17.TabIndex = 146
        Me.LabelX17.Text = "Warehouse :"
        '
        'cmbWarehouse
        '
        Me.cmbWarehouse.DisplayMember = "Text"
        Me.cmbWarehouse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbWarehouse.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbWarehouse.FormattingEnabled = True
        Me.cmbWarehouse.ItemHeight = 16
        Me.cmbWarehouse.Location = New System.Drawing.Point(127, 4)
        Me.cmbWarehouse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbWarehouse.Name = "cmbWarehouse"
        Me.cmbWarehouse.Size = New System.Drawing.Size(218, 22)
        Me.cmbWarehouse.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.cmbWarehouse.TabIndex = 4
        '
        'cmdWarehouse
        '
        Me.cmdWarehouse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdWarehouse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdWarehouse.Image = CType(resources.GetObject("cmdWarehouse.Image"), System.Drawing.Image)
        Me.cmdWarehouse.ImageFixedSize = New System.Drawing.Size(12, 12)
        Me.cmdWarehouse.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom
        Me.cmdWarehouse.Location = New System.Drawing.Point(351, 3)
        Me.cmdWarehouse.Name = "cmdWarehouse"
        Me.cmdWarehouse.Size = New System.Drawing.Size(21, 22)
        Me.cmdWarehouse.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.cmdWarehouse.TabIndex = 147
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.Location = New System.Drawing.Point(3, 34)
        Me.LabelX8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(118, 22)
        Me.LabelX8.TabIndex = 2
        Me.LabelX8.Text = "Payment Terms :"
        '
        'cmbPayment
        '
        Me.cmbPayment.DisplayMember = "Text"
        Me.cmbPayment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayment.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPayment.FormattingEnabled = True
        Me.cmbPayment.ItemHeight = 16
        Me.cmbPayment.Location = New System.Drawing.Point(127, 34)
        Me.cmbPayment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbPayment.Name = "cmbPayment"
        Me.cmbPayment.Size = New System.Drawing.Size(218, 22)
        Me.cmbPayment.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.cmbPayment.TabIndex = 5
        '
        'cmdPayment
        '
        Me.cmdPayment.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdPayment.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdPayment.Image = CType(resources.GetObject("cmdPayment.Image"), System.Drawing.Image)
        Me.cmdPayment.ImageFixedSize = New System.Drawing.Size(12, 12)
        Me.cmdPayment.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom
        Me.cmdPayment.Location = New System.Drawing.Point(351, 33)
        Me.cmdPayment.Name = "cmdPayment"
        Me.cmdPayment.Size = New System.Drawing.Size(21, 22)
        Me.cmdPayment.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.cmdPayment.TabIndex = 149
        '
        'LabelX10
        '
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX10.Location = New System.Drawing.Point(3, 64)
        Me.LabelX10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(118, 22)
        Me.LabelX10.TabIndex = 111
        Me.LabelX10.Text = "Delivery Date :"
        '
        'dtDelivery
        '
        '
        '
        '
        Me.dtDelivery.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtDelivery.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtDelivery.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtDelivery.ButtonDropDown.Visible = True
        Me.dtDelivery.CustomFormat = "dd/MM/yyyy"
        Me.dtDelivery.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDelivery.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.dtDelivery.IsPopupCalendarOpen = False
        Me.dtDelivery.Location = New System.Drawing.Point(127, 63)
        '
        '
        '
        Me.dtDelivery.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtDelivery.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtDelivery.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtDelivery.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtDelivery.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtDelivery.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtDelivery.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtDelivery.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtDelivery.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtDelivery.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtDelivery.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtDelivery.MonthCalendar.DisplayMonth = New Date(2014, 5, 1, 0, 0, 0, 0)
        Me.dtDelivery.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.dtDelivery.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtDelivery.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtDelivery.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtDelivery.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtDelivery.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtDelivery.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtDelivery.MonthCalendar.TodayButtonVisible = True
        Me.dtDelivery.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtDelivery.Name = "dtDelivery"
        Me.dtDelivery.Size = New System.Drawing.Size(245, 22)
        Me.dtDelivery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtDelivery.TabIndex = 6
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.LabelX5)
        Me.FlowLayoutPanel2.Controls.Add(Me.txtTransno)
        Me.FlowLayoutPanel2.Controls.Add(Me.LabelX6)
        Me.FlowLayoutPanel2.Controls.Add(Me.dtTrans)
        Me.FlowLayoutPanel2.Controls.Add(Me.LabelX7)
        Me.FlowLayoutPanel2.Controls.Add(Me.cmbCustomer)
        Me.FlowLayoutPanel2.Controls.Add(Me.cmdCustomer)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(377, 91)
        Me.FlowLayoutPanel2.TabIndex = 128
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(3, 4)
        Me.LabelX5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(118, 22)
        Me.LabelX5.TabIndex = 2
        Me.LabelX5.Text = "PO No :"
        '
        'txtTransno
        '
        Me.txtTransno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTransno.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransno.Location = New System.Drawing.Point(127, 4)
        Me.txtTransno.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTransno.Name = "txtTransno"
        Me.txtTransno.Size = New System.Drawing.Size(236, 22)
        Me.txtTransno.TabIndex = 0
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(3, 34)
        Me.LabelX6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(118, 22)
        Me.LabelX6.TabIndex = 115
        Me.LabelX6.Text = "PO Date :"
        '
        'dtTrans
        '
        '
        '
        '
        Me.dtTrans.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtTrans.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtTrans.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtTrans.ButtonDropDown.Visible = True
        Me.dtTrans.CustomFormat = "dd/MM/yyyy"
        Me.dtTrans.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTrans.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.dtTrans.IsPopupCalendarOpen = False
        Me.dtTrans.Location = New System.Drawing.Point(127, 33)
        '
        '
        '
        Me.dtTrans.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtTrans.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtTrans.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtTrans.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtTrans.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtTrans.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtTrans.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtTrans.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtTrans.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtTrans.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtTrans.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtTrans.MonthCalendar.DisplayMonth = New Date(2014, 5, 1, 0, 0, 0, 0)
        Me.dtTrans.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.dtTrans.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtTrans.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtTrans.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtTrans.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtTrans.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtTrans.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtTrans.MonthCalendar.TodayButtonVisible = True
        Me.dtTrans.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtTrans.Name = "dtTrans"
        Me.dtTrans.Size = New System.Drawing.Size(236, 22)
        Me.dtTrans.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtTrans.TabIndex = 1
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(3, 64)
        Me.LabelX7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(118, 22)
        Me.LabelX7.TabIndex = 111
        Me.LabelX7.Text = "Vendor :"
        '
        'cmbCustomer
        '
        Me.cmbCustomer.DisplayMember = "Text"
        Me.cmbCustomer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCustomer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCustomer.FormattingEnabled = True
        Me.cmbCustomer.ItemHeight = 16
        Me.cmbCustomer.Location = New System.Drawing.Point(127, 64)
        Me.cmbCustomer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbCustomer.Name = "cmbCustomer"
        Me.cmbCustomer.Size = New System.Drawing.Size(209, 22)
        Me.cmbCustomer.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.cmbCustomer.TabIndex = 2
        '
        'cmdCustomer
        '
        Me.cmdCustomer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCustomer.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCustomer.Image = CType(resources.GetObject("cmdCustomer.Image"), System.Drawing.Image)
        Me.cmdCustomer.ImageFixedSize = New System.Drawing.Size(12, 12)
        Me.cmdCustomer.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom
        Me.cmdCustomer.Location = New System.Drawing.Point(342, 63)
        Me.cmdCustomer.Name = "cmdCustomer"
        Me.cmdCustomer.Size = New System.Drawing.Size(21, 22)
        Me.cmdCustomer.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.cmdCustomer.TabIndex = 137
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.SuperTabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(779, 450)
        Me.Panel1.TabIndex = 137
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 370)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(779, 80)
        Me.Panel5.TabIndex = 142
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.tTotal)
        Me.Panel7.Controls.Add(Me.LabelX11)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(354, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(425, 80)
        Me.Panel7.TabIndex = 143
        '
        'tTotal
        '
        '
        '
        '
        Me.tTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tTotal.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tTotal.Location = New System.Drawing.Point(198, 21)
        Me.tTotal.Name = "tTotal"
        Me.tTotal.Size = New System.Drawing.Size(215, 35)
        Me.tTotal.TabIndex = 143
        Me.tTotal.Text = "0"
        Me.tTotal.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX11
        '
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX11.Location = New System.Drawing.Point(5, 20)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(194, 35)
        Me.LabelX11.TabIndex = 142
        Me.LabelX11.Text = "TOTAL:      Rp."
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.LabelX12)
        Me.Panel6.Controls.Add(Me.txtNote)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(350, 80)
        Me.Panel6.TabIndex = 142
        '
        'LabelX12
        '
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX12.Location = New System.Drawing.Point(5, 3)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(44, 23)
        Me.LabelX12.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.LabelX12.TabIndex = 141
        Me.LabelX12.Text = "Notes:"
        '
        'txtNote
        '
        Me.txtNote.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNote.Border.BackColor = System.Drawing.Color.Black
        Me.txtNote.Border.BackColor2 = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtNote.Border.BackColorGradientAngle = 180
        Me.txtNote.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtNote.Border.BorderBottomWidth = 1
        Me.txtNote.Border.BorderColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarStripeColor
        Me.txtNote.Border.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveText
        Me.txtNote.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtNote.Border.BorderLeftWidth = 1
        Me.txtNote.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtNote.Border.BorderRightWidth = 1
        Me.txtNote.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtNote.Border.BorderTopWidth = 1
        Me.txtNote.Border.CornerDiameter = 7
        Me.txtNote.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNote.Border.CornerTypeBottomLeft = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNote.Border.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNote.Border.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNote.Border.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.txtNote.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNote.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNote.Location = New System.Drawing.Point(56, 11)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(289, 59)
        Me.txtNote.TabIndex = 15
        '
        'SuperTabControl1
        '
        Me.SuperTabControl1.BackColor = System.Drawing.Color.White
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
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel1)
        Me.SuperTabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SuperTabControl1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl1.ForeColor = System.Drawing.Color.Black
        Me.SuperTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SuperTabControl1.Name = "SuperTabControl1"
        Me.SuperTabControl1.ReorderTabsEnabled = True
        Me.SuperTabControl1.SelectedTabFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl1.SelectedTabIndex = 0
        Me.SuperTabControl1.Size = New System.Drawing.Size(779, 362)
        Me.SuperTabControl1.TabFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl1.TabIndex = 129
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem2})
        Me.SuperTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.VisualStudio2008Dock
        Me.SuperTabControl1.Text = "SuperTabControl1"
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Controls.Add(Me.TB2)
        Me.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(0, 30)
        Me.SuperTabControlPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(779, 332)
        Me.SuperTabControlPanel1.TabIndex = 1
        Me.SuperTabControlPanel1.TabItem = Me.SuperTabItem2
        '
        'TB2
        '
        Me.TB2.BackColor = System.Drawing.Color.White
        '
        '
        '
        '
        '
        '
        Me.TB2.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.TB2.ControlBox.MenuBox.Name = ""
        Me.TB2.ControlBox.Name = ""
        Me.TB2.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.TB2.ControlBox.MenuBox, Me.TB2.ControlBox.CloseBox})
        Me.TB2.Controls.Add(Me.SuperTabControlPanel3)
        Me.TB2.Controls.Add(Me.SuperTabControlPanel2)
        Me.TB2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TB2.ForeColor = System.Drawing.Color.Black
        Me.TB2.Location = New System.Drawing.Point(0, 0)
        Me.TB2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TB2.Name = "TB2"
        Me.TB2.ReorderTabsEnabled = True
        Me.TB2.SelectedTabFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TB2.SelectedTabIndex = 0
        Me.TB2.Size = New System.Drawing.Size(779, 332)
        Me.TB2.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Bottom
        Me.TB2.TabFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB2.TabIndex = 1
        Me.TB2.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem4, Me.SuperTabItem3})
        Me.TB2.Text = "SuperTabControl1"
        '
        'SuperTabControlPanel3
        '
        Me.SuperTabControlPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.SuperTabControlPanel3.Controls.Add(Me.grid1)
        Me.SuperTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel3.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControlPanel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SuperTabControlPanel3.Name = "SuperTabControlPanel3"
        Me.SuperTabControlPanel3.Size = New System.Drawing.Size(779, 302)
        Me.SuperTabControlPanel3.TabIndex = 1
        Me.SuperTabControlPanel3.TabItem = Me.SuperTabItem4
        '
        'grid1
        '
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.btnremove, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.qtyrcv, Me.Type, Me.DataGridViewDoubleInputColumn2, Me.Column1, Me.total})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid1.DefaultCellStyle = DataGridViewCellStyle7
        Me.grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid1.EnableHeadersVisualStyles = False
        Me.grid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.grid1.Location = New System.Drawing.Point(0, 0)
        Me.grid1.Name = "grid1"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.grid1.RowHeadersVisible = False
        Me.grid1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid1.Size = New System.Drawing.Size(779, 302)
        Me.grid1.TabIndex = 8
        '
        'btnremove
        '
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.btnremove.DefaultCellStyle = DataGridViewCellStyle18
        Me.btnremove.HeaderText = ""
        Me.btnremove.Image = CType(resources.GetObject("btnremove.Image"), System.Drawing.Image)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Text = Nothing
        Me.btnremove.Width = 20
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Item Code"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridViewTextBoxColumn7.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'qtyrcv
        '
        '
        '
        '
        Me.qtyrcv.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.qtyrcv.BackgroundStyle.Class = "DataGridViewNumericBorder"
        Me.qtyrcv.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.qtyrcv.BackgroundStyle.TextColor = System.Drawing.Color.Black
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.qtyrcv.DefaultCellStyle = DataGridViewCellStyle20
        Me.qtyrcv.HeaderText = "Qty"
        Me.qtyrcv.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center
        Me.qtyrcv.MinimumWidth = 35
        Me.qtyrcv.Name = "qtyrcv"
        Me.qtyrcv.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.qtyrcv.Width = 35
        '
        'Type
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Type.DefaultCellStyle = DataGridViewCellStyle14
        Me.Type.HeaderText = "Unit"
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        Me.Type.Width = 65
        '
        'DataGridViewDoubleInputColumn2
        '
        '
        '
        '
        Me.DataGridViewDoubleInputColumn2.BackgroundStyle.BackColor = System.Drawing.Color.White
        Me.DataGridViewDoubleInputColumn2.BackgroundStyle.Class = "DataGridViewNumericBorder"
        Me.DataGridViewDoubleInputColumn2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DataGridViewDoubleInputColumn2.BackgroundStyle.TextColor = System.Drawing.Color.Black
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.White
        Me.DataGridViewDoubleInputColumn2.DefaultCellStyle = DataGridViewCellStyle21
        Me.DataGridViewDoubleInputColumn2.DisplayFormat = "#,0"
        Me.DataGridViewDoubleInputColumn2.HeaderText = "Price"
        Me.DataGridViewDoubleInputColumn2.Increment = 1
        Me.DataGridViewDoubleInputColumn2.Name = "DataGridViewDoubleInputColumn2"
        Me.DataGridViewDoubleInputColumn2.Width = 115
        '
        'Column1
        '
        '
        '
        '
        Me.Column1.BackgroundStyle.BackColor = System.Drawing.Color.White
        Me.Column1.BackgroundStyle.Class = "DataGridViewNumericBorder"
        Me.Column1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Column1.BackgroundStyle.TextColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle15
        Me.Column1.HeaderText = "Disc(%)"
        Me.Column1.Increment = 1
        Me.Column1.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.Width = 60
        '
        'total
        '
        '
        '
        '
        Me.total.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.total.BackgroundStyle.Class = "DataGridViewNumericBorder"
        Me.total.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.total.BackgroundStyle.TextColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.total.DefaultCellStyle = DataGridViewCellStyle6
        Me.total.DisplayFormat = "#,0"
        Me.total.HeaderText = "Total"
        Me.total.Increment = 1
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.Width = 125
        '
        'SuperTabItem4
        '
        Me.SuperTabItem4.AttachedControl = Me.SuperTabControlPanel3
        Me.SuperTabItem4.GlobalItem = False
        Me.SuperTabItem4.Image = CType(resources.GetObject("SuperTabItem4.Image"), System.Drawing.Image)
        Me.SuperTabItem4.Name = "SuperTabItem4"
        SuperTabItemStateColorTable1.CloseMarker = System.Drawing.Color.White
        SuperTabColorStates1.Normal = SuperTabItemStateColorTable1
        SuperTabItemColorTable1.Bottom = SuperTabColorStates1
        Me.SuperTabItem4.TabColor = SuperTabItemColorTable1
        Me.SuperTabItem4.Text = "Item Details"
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me.Panel4)
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControlPanel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(779, 302)
        Me.SuperTabControlPanel2.TabIndex = 0
        Me.SuperTabControlPanel2.TabItem = Me.SuperTabItem3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.FlowLayoutPanel5)
        Me.Panel4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Panel4.Location = New System.Drawing.Point(5, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(771, 283)
        Me.Panel4.TabIndex = 117
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.Controls.Add(Me.LabelX15)
        Me.FlowLayoutPanel5.Controls.Add(Me.tAmount)
        Me.FlowLayoutPanel5.Controls.Add(Me.LabelX18)
        Me.FlowLayoutPanel5.Controls.Add(Me.tDisccent)
        Me.FlowLayoutPanel5.Controls.Add(Me.LabelX19)
        Me.FlowLayoutPanel5.Controls.Add(Me.tDiscamount)
        Me.FlowLayoutPanel5.Controls.Add(Me.LabelX25)
        Me.FlowLayoutPanel5.Controls.Add(Me.tpreTotal)
        Me.FlowLayoutPanel5.Controls.Add(Me.LabelX20)
        Me.FlowLayoutPanel5.Controls.Add(Me.tPPNcent)
        Me.FlowLayoutPanel5.Controls.Add(Me.LabelX16)
        Me.FlowLayoutPanel5.Controls.Add(Me.tPPNamount)
        Me.FlowLayoutPanel5.Controls.Add(Me.LabelX21)
        Me.FlowLayoutPanel5.Controls.Add(Me.tOtherfee)
        Me.FlowLayoutPanel5.Controls.Add(Me.LabelX13)
        Me.FlowLayoutPanel5.Controls.Add(Me.tSubtotal)
        Me.FlowLayoutPanel5.Controls.Add(Me.LabelX22)
        Me.FlowLayoutPanel5.Controls.Add(Me.tDP)
        Me.FlowLayoutPanel5.Controls.Add(Me.LabelX23)
        Me.FlowLayoutPanel5.Controls.Add(Me.tLeftamount)
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(394, 27)
        Me.FlowLayoutPanel5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(373, 250)
        Me.FlowLayoutPanel5.TabIndex = 116
        '
        'LabelX15
        '
        '
        '
        '
        Me.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX15.Location = New System.Drawing.Point(3, 4)
        Me.LabelX15.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(170, 22)
        Me.LabelX15.TabIndex = 115
        Me.LabelX15.Text = "Total Amount :"
        '
        'tAmount
        '
        '
        '
        '
        Me.tAmount.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tAmount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tAmount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tAmount.Increment = 1
        Me.tAmount.Location = New System.Drawing.Point(179, 3)
        Me.tAmount.Name = "tAmount"
        Me.tAmount.Size = New System.Drawing.Size(191, 22)
        Me.tAmount.TabIndex = 9
        '
        'LabelX18
        '
        '
        '
        '
        Me.LabelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX18.Location = New System.Drawing.Point(3, 34)
        Me.LabelX18.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX18.Name = "LabelX18"
        Me.LabelX18.Size = New System.Drawing.Size(70, 22)
        Me.LabelX18.TabIndex = 116
        Me.LabelX18.Text = "Disc :"
        '
        'tDisccent
        '
        '
        '
        '
        Me.tDisccent.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tDisccent.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tDisccent.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tDisccent.Increment = 1
        Me.tDisccent.Location = New System.Drawing.Point(79, 33)
        Me.tDisccent.MaxValue = 100
        Me.tDisccent.MinValue = 0
        Me.tDisccent.Name = "tDisccent"
        Me.tDisccent.ShowUpDown = True
        Me.tDisccent.Size = New System.Drawing.Size(64, 22)
        Me.tDisccent.TabIndex = 10
        '
        'LabelX19
        '
        '
        '
        '
        Me.LabelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX19.Location = New System.Drawing.Point(149, 34)
        Me.LabelX19.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX19.Name = "LabelX19"
        Me.LabelX19.Size = New System.Drawing.Size(24, 22)
        Me.LabelX19.TabIndex = 117
        Me.LabelX19.Text = "% ="
        '
        'tDiscamount
        '
        '
        '
        '
        Me.tDiscamount.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tDiscamount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tDiscamount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tDiscamount.DisplayFormat = "#,0"
        Me.tDiscamount.Enabled = False
        Me.tDiscamount.Increment = 1
        Me.tDiscamount.Location = New System.Drawing.Point(179, 33)
        Me.tDiscamount.Name = "tDiscamount"
        Me.tDiscamount.Size = New System.Drawing.Size(191, 22)
        Me.tDiscamount.TabIndex = 9
        '
        'LabelX25
        '
        '
        '
        '
        Me.LabelX25.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX25.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX25.Location = New System.Drawing.Point(3, 64)
        Me.LabelX25.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX25.Name = "LabelX25"
        Me.LabelX25.Size = New System.Drawing.Size(170, 22)
        Me.LabelX25.TabIndex = 139
        Me.LabelX25.Text = "Total :"
        '
        'tpreTotal
        '
        '
        '
        '
        Me.tpreTotal.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tpreTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tpreTotal.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tpreTotal.Enabled = False
        Me.tpreTotal.Increment = 1
        Me.tpreTotal.Location = New System.Drawing.Point(179, 63)
        Me.tpreTotal.Name = "tpreTotal"
        Me.tpreTotal.Size = New System.Drawing.Size(191, 22)
        Me.tpreTotal.TabIndex = 140
        '
        'LabelX20
        '
        '
        '
        '
        Me.LabelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX20.Location = New System.Drawing.Point(3, 94)
        Me.LabelX20.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX20.Name = "LabelX20"
        Me.LabelX20.Size = New System.Drawing.Size(70, 22)
        Me.LabelX20.TabIndex = 120
        Me.LabelX20.Text = "PPN 10 % :"
        '
        'tPPNcent
        '
        '
        '
        '
        Me.tPPNcent.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tPPNcent.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tPPNcent.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tPPNcent.Enabled = False
        Me.tPPNcent.Increment = 1
        Me.tPPNcent.Location = New System.Drawing.Point(79, 93)
        Me.tPPNcent.Name = "tPPNcent"
        Me.tPPNcent.ShowUpDown = True
        Me.tPPNcent.Size = New System.Drawing.Size(64, 22)
        Me.tPPNcent.TabIndex = 10
        '
        'LabelX16
        '
        '
        '
        '
        Me.LabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX16.Location = New System.Drawing.Point(149, 94)
        Me.LabelX16.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX16.Name = "LabelX16"
        Me.LabelX16.Size = New System.Drawing.Size(24, 22)
        Me.LabelX16.TabIndex = 128
        Me.LabelX16.Text = "% ="
        '
        'tPPNamount
        '
        '
        '
        '
        Me.tPPNamount.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tPPNamount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tPPNamount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tPPNamount.Enabled = False
        Me.tPPNamount.Increment = 1
        Me.tPPNamount.Location = New System.Drawing.Point(179, 93)
        Me.tPPNamount.Name = "tPPNamount"
        Me.tPPNamount.Size = New System.Drawing.Size(191, 22)
        Me.tPPNamount.TabIndex = 10
        '
        'LabelX21
        '
        '
        '
        '
        Me.LabelX21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX21.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX21.Location = New System.Drawing.Point(3, 124)
        Me.LabelX21.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX21.Name = "LabelX21"
        Me.LabelX21.Size = New System.Drawing.Size(170, 22)
        Me.LabelX21.TabIndex = 130
        Me.LabelX21.Text = "Other Fee :"
        '
        'tOtherfee
        '
        '
        '
        '
        Me.tOtherfee.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tOtherfee.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tOtherfee.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tOtherfee.Increment = 1
        Me.tOtherfee.Location = New System.Drawing.Point(179, 123)
        Me.tOtherfee.Name = "tOtherfee"
        Me.tOtherfee.Size = New System.Drawing.Size(191, 22)
        Me.tOtherfee.TabIndex = 11
        '
        'LabelX13
        '
        '
        '
        '
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX13.Location = New System.Drawing.Point(3, 154)
        Me.LabelX13.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(170, 22)
        Me.LabelX13.TabIndex = 126
        Me.LabelX13.Text = "Sub Total:"
        '
        'tSubtotal
        '
        '
        '
        '
        Me.tSubtotal.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tSubtotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tSubtotal.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tSubtotal.Enabled = False
        Me.tSubtotal.Increment = 1
        Me.tSubtotal.Location = New System.Drawing.Point(179, 153)
        Me.tSubtotal.Name = "tSubtotal"
        Me.tSubtotal.Size = New System.Drawing.Size(191, 22)
        Me.tSubtotal.TabIndex = 12
        '
        'LabelX22
        '
        '
        '
        '
        Me.LabelX22.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX22.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX22.Location = New System.Drawing.Point(3, 184)
        Me.LabelX22.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX22.Name = "LabelX22"
        Me.LabelX22.Size = New System.Drawing.Size(170, 22)
        Me.LabelX22.TabIndex = 132
        Me.LabelX22.Text = "Down Payment :"
        '
        'tDP
        '
        '
        '
        '
        Me.tDP.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tDP.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tDP.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tDP.Increment = 1
        Me.tDP.Location = New System.Drawing.Point(179, 183)
        Me.tDP.Name = "tDP"
        Me.tDP.Size = New System.Drawing.Size(191, 22)
        Me.tDP.TabIndex = 13
        '
        'LabelX23
        '
        '
        '
        '
        Me.LabelX23.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX23.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX23.Location = New System.Drawing.Point(3, 214)
        Me.LabelX23.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX23.Name = "LabelX23"
        Me.LabelX23.Size = New System.Drawing.Size(170, 22)
        Me.LabelX23.TabIndex = 134
        Me.LabelX23.Text = "Left Amount :"
        '
        'tLeftamount
        '
        '
        '
        '
        Me.tLeftamount.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tLeftamount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tLeftamount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tLeftamount.Enabled = False
        Me.tLeftamount.Increment = 1
        Me.tLeftamount.Location = New System.Drawing.Point(179, 213)
        Me.tLeftamount.Name = "tLeftamount"
        Me.tLeftamount.Size = New System.Drawing.Size(191, 22)
        Me.tLeftamount.TabIndex = 14
        '
        'SuperTabItem3
        '
        Me.SuperTabItem3.AttachedControl = Me.SuperTabControlPanel2
        Me.SuperTabItem3.GlobalItem = False
        Me.SuperTabItem3.Image = CType(resources.GetObject("SuperTabItem3.Image"), System.Drawing.Image)
        Me.SuperTabItem3.Name = "SuperTabItem3"
        Me.SuperTabItem3.Text = "Total Details"
        '
        'SuperTabItem2
        '
        Me.SuperTabItem2.AttachedControl = Me.SuperTabControlPanel1
        Me.SuperTabItem2.GlobalItem = False
        Me.SuperTabItem2.Image = CType(resources.GetObject("SuperTabItem2.Image"), System.Drawing.Image)
        Me.SuperTabItem2.Name = "SuperTabItem2"
        Me.SuperTabItem2.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Silver
        Me.SuperTabItem2.SelectedTabFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabItem2.TabFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabItem2.Text = "Purchase Order"
        '
        'frmPurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 562)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.t0)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Bar1)
        Me.EnableGlass = False
        Me.MinimumSize = New System.Drawing.Size(789, 600)
        Me.Name = "frmPurchaseOrder"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Order"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.t3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bar1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.FlowLayoutPanel3.ResumeLayout(False)
        CType(Me.dtDelivery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        CType(Me.dtTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.SuperTabControlPanel1.ResumeLayout(False)
        CType(Me.TB2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TB2.ResumeLayout(False)
        Me.SuperTabControlPanel3.ResumeLayout(False)
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControlPanel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.FlowLayoutPanel5.ResumeLayout(False)
        CType(Me.tAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tDisccent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tDiscamount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tpreTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tPPNcent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tPPNamount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tOtherfee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tSubtotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tDP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tLeftamount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents t0 As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents t2 As System.Windows.Forms.TextBox
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents t3 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents t4 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents cmbReport As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cmdSave As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdEdit As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdAdd As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdPreview As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ControlContainerItem1 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents cmdPrint As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdExit As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbWarehouse As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtDelivery As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTransno As System.Windows.Forms.TextBox
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtTrans As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbCustomer As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cmdCustomer As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SuperTabControl1 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents TB2 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel3 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem4 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel5 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tAmount As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tDisccent As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX19 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tDiscamount As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX20 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tPPNcent As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tPPNamount As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tOtherfee As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX21 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tSubtotal As DevComponents.Editors.DoubleInput
    Friend WithEvents SuperTabItem3 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabItem2 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents grid1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents tTotal As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNote As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX22 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tDP As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX23 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tLeftamount As DevComponents.Editors.DoubleInput
    Friend WithEvents cmdWarehouse As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmbPayment As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cmdPayment As DevComponents.DotNetBar.ButtonX
    Friend WithEvents tpreTotal As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX25 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnremove As DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qtyrcv As DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn
    Friend WithEvents Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewDoubleInputColumn2 As DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
    Friend WithEvents Column1 As DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
    Friend WithEvents total As DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
End Class
