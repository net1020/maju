<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits DevComponents.DotNetBar.Office2007RibbonForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ribbon1 = New DevComponents.DotNetBar.RibbonControl
        Me.ribbonPanel1 = New DevComponents.DotNetBar.RibbonPanel
        Me.RibbonBar1 = New DevComponents.DotNetBar.RibbonBar
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem64 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem9 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem4 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem7 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem10 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem11 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem12 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem13 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem15 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem16 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem17 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem18 = New DevComponents.DotNetBar.ButtonItem
        Me.RibbonPanel4 = New DevComponents.DotNetBar.RibbonPanel
        Me.RibbonBar8 = New DevComponents.DotNetBar.RibbonBar
        Me.ButtonItem19 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem20 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem21 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem22 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem23 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem24 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem25 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem26 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem27 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem28 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem29 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem30 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem31 = New DevComponents.DotNetBar.ButtonItem
        Me.RibbonPanel5 = New DevComponents.DotNetBar.RibbonPanel
        Me.RibbonBar9 = New DevComponents.DotNetBar.RibbonBar
        Me.ButtonItem14 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem42 = New DevComponents.DotNetBar.ButtonItem
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.ButtonFile = New DevComponents.DotNetBar.Office2007StartButton
        Me.menuFileContainer = New DevComponents.DotNetBar.ItemContainer
        Me.menuFileTwoColumnContainer = New DevComponents.DotNetBar.ItemContainer
        Me.menuFileItems = New DevComponents.DotNetBar.ItemContainer
        Me.menuFileBottomContainer = New DevComponents.DotNetBar.ItemContainer
        Me.buttonExit = New DevComponents.DotNetBar.ButtonItem
        Me.ribbonTabItem1 = New DevComponents.DotNetBar.RibbonTabItem
        Me.RibbonTabItem2 = New DevComponents.DotNetBar.RibbonTabItem
        Me.RibbonTabItem5 = New DevComponents.DotNetBar.RibbonTabItem
        Me.RibbonTabItem4 = New DevComponents.DotNetBar.RibbonTabItem
        Me.RibbonTabItemGroup1 = New DevComponents.DotNetBar.RibbonTabItemGroup
        Me.RibbonTabItemGroup2 = New DevComponents.DotNetBar.RibbonTabItemGroup
        Me.RibbonTabItemGroup3 = New DevComponents.DotNetBar.RibbonTabItemGroup
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.barStatus = New DevComponents.DotNetBar.Bar
        Me.labelStatus = New DevComponents.DotNetBar.LabelItem
        Me.ItemContainer12 = New DevComponents.DotNetBar.ItemContainer
        Me.labelPosition = New DevComponents.DotNetBar.LabelItem
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tabStrip1 = New DevComponents.DotNetBar.TabStrip
        Me.ButtonItem8 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem5 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem6 = New DevComponents.DotNetBar.ButtonItem
        Me.ribbon1.SuspendLayout()
        Me.ribbonPanel1.SuspendLayout()
        Me.RibbonPanel4.SuspendLayout()
        Me.RibbonPanel5.SuspendLayout()
        CType(Me.barStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbon1
        '
        Me.ribbon1.AntiAlias = False
        Me.ribbon1.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.ribbon1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ribbon1.CanCustomize = False
        Me.ribbon1.CaptionVisible = True
        Me.ribbon1.Controls.Add(Me.RibbonPanel4)
        Me.ribbon1.Controls.Add(Me.ribbonPanel1)
        Me.ribbon1.Controls.Add(Me.RibbonPanel5)
        Me.ribbon1.Controls.Add(Me.RadioButton1)
        Me.ribbon1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ribbon1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonFile, Me.ribbonTabItem1, Me.RibbonTabItem2, Me.RibbonTabItem5, Me.RibbonTabItem4})
        Me.ribbon1.Location = New System.Drawing.Point(5, 1)
        Me.ribbon1.MdiSystemItemVisible = False
        Me.ribbon1.Name = "ribbon1"
        Me.ribbon1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.ribbon1.Size = New System.Drawing.Size(717, 138)
        Me.ribbon1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ribbon1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon"
        Me.ribbon1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon"
        Me.ribbon1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar"
        Me.ribbon1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>"
        Me.ribbon1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar..."
        Me.ribbon1.SystemText.QatDialogAddButton = "&Add >>"
        Me.ribbon1.SystemText.QatDialogCancelButton = "Cancel"
        Me.ribbon1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar"
        Me.ribbon1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:"
        Me.ribbon1.SystemText.QatDialogOkButton = "OK"
        Me.ribbon1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon"
        Me.ribbon1.SystemText.QatDialogRemoveButton = "&Remove"
        Me.ribbon1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon"
        Me.ribbon1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon"
        Me.ribbon1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar"
        Me.ribbon1.TabGroupHeight = 14
        Me.ribbon1.TabGroups.AddRange(New DevComponents.DotNetBar.RibbonTabItemGroup() {Me.RibbonTabItemGroup1, Me.RibbonTabItemGroup2, Me.RibbonTabItemGroup3})
        Me.ribbon1.TabGroupsVisible = True
        Me.ribbon1.TabIndex = 13
        '
        'ribbonPanel1
        '
        Me.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ribbonPanel1.Controls.Add(Me.RibbonBar1)
        Me.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ribbonPanel1.Location = New System.Drawing.Point(0, 54)
        Me.ribbonPanel1.Name = "ribbonPanel1"
        Me.ribbonPanel1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.ribbonPanel1.Size = New System.Drawing.Size(717, 82)
        '
        '
        '
        Me.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ribbonPanel1.TabIndex = 1
        Me.ribbonPanel1.Visible = False
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
        Me.RibbonBar1.DialogLauncherVisible = True
        Me.RibbonBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem1, Me.ButtonItem64, Me.ButtonItem9, Me.ButtonItem3, Me.ButtonItem4, Me.ButtonItem7, Me.ButtonItem10, Me.ButtonItem11, Me.ButtonItem12, Me.ButtonItem13, Me.ButtonItem15, Me.ButtonItem16, Me.ButtonItem17, Me.ButtonItem18})
        Me.RibbonBar1.Location = New System.Drawing.Point(3, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Size = New System.Drawing.Size(702, 79)
        Me.RibbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar1.TabIndex = 5
        Me.RibbonBar1.Text = "Page Setup"
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
        'ButtonItem1
        '
        Me.ButtonItem1.Image = CType(resources.GetObject("ButtonItem1.Image"), System.Drawing.Image)
        Me.ButtonItem1.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.ButtonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Text = "Employee"
        '
        'ButtonItem64
        '
        Me.ButtonItem64.Image = CType(resources.GetObject("ButtonItem64.Image"), System.Drawing.Image)
        Me.ButtonItem64.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.ButtonItem64.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem64.Name = "ButtonItem64"
        Me.ButtonItem64.Text = "Position"
        '
        'ButtonItem9
        '
        Me.ButtonItem9.Image = CType(resources.GetObject("ButtonItem9.Image"), System.Drawing.Image)
        Me.ButtonItem9.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem9.Name = "ButtonItem9"
        Me.ButtonItem9.Text = "Membership"
        '
        'ButtonItem3
        '
        Me.ButtonItem3.Image = CType(resources.GetObject("ButtonItem3.Image"), System.Drawing.Image)
        Me.ButtonItem3.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.ButtonItem3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.Text = "Customer"
        '
        'ButtonItem4
        '
        Me.ButtonItem4.Image = CType(resources.GetObject("ButtonItem4.Image"), System.Drawing.Image)
        Me.ButtonItem4.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.ButtonItem4.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem4.Name = "ButtonItem4"
        Me.ButtonItem4.Text = "Supplier"
        '
        'ButtonItem7
        '
        Me.ButtonItem7.Image = CType(resources.GetObject("ButtonItem7.Image"), System.Drawing.Image)
        Me.ButtonItem7.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.ButtonItem7.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem7.Name = "ButtonItem7"
        Me.ButtonItem7.Text = "Bank"
        '
        'ButtonItem10
        '
        Me.ButtonItem10.Image = CType(resources.GetObject("ButtonItem10.Image"), System.Drawing.Image)
        Me.ButtonItem10.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.ButtonItem10.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem10.Name = "ButtonItem10"
        Me.ButtonItem10.Text = "Product"
        '
        'ButtonItem11
        '
        Me.ButtonItem11.Image = CType(resources.GetObject("ButtonItem11.Image"), System.Drawing.Image)
        Me.ButtonItem11.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.ButtonItem11.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem11.Name = "ButtonItem11"
        Me.ButtonItem11.Text = "Category"
        '
        'ButtonItem12
        '
        Me.ButtonItem12.Image = CType(resources.GetObject("ButtonItem12.Image"), System.Drawing.Image)
        Me.ButtonItem12.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.ButtonItem12.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem12.Name = "ButtonItem12"
        Me.ButtonItem12.Text = "Courier"
        '
        'ButtonItem13
        '
        Me.ButtonItem13.Image = CType(resources.GetObject("ButtonItem13.Image"), System.Drawing.Image)
        Me.ButtonItem13.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.ButtonItem13.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem13.Name = "ButtonItem13"
        Me.ButtonItem13.Text = "User"
        '
        'ButtonItem15
        '
        Me.ButtonItem15.Image = CType(resources.GetObject("ButtonItem15.Image"), System.Drawing.Image)
        Me.ButtonItem15.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.ButtonItem15.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem15.Name = "ButtonItem15"
        Me.ButtonItem15.Text = "Group"
        '
        'ButtonItem16
        '
        Me.ButtonItem16.Image = CType(resources.GetObject("ButtonItem16.Image"), System.Drawing.Image)
        Me.ButtonItem16.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.ButtonItem16.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem16.Name = "ButtonItem16"
        Me.ButtonItem16.Text = "Unit"
        '
        'ButtonItem17
        '
        Me.ButtonItem17.Image = CType(resources.GetObject("ButtonItem17.Image"), System.Drawing.Image)
        Me.ButtonItem17.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.ButtonItem17.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem17.Name = "ButtonItem17"
        Me.ButtonItem17.Text = "Pricing"
        '
        'ButtonItem18
        '
        Me.ButtonItem18.Image = CType(resources.GetObject("ButtonItem18.Image"), System.Drawing.Image)
        Me.ButtonItem18.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.ButtonItem18.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem18.Name = "ButtonItem18"
        Me.ButtonItem18.Text = "Category Discount"
        '
        'RibbonPanel4
        '
        Me.RibbonPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel4.Controls.Add(Me.RibbonBar8)
        Me.RibbonPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel4.Location = New System.Drawing.Point(0, 54)
        Me.RibbonPanel4.Name = "RibbonPanel4"
        Me.RibbonPanel4.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel4.Size = New System.Drawing.Size(717, 82)
        '
        '
        '
        Me.RibbonPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel4.TabIndex = 6
        '
        'RibbonBar8
        '
        Me.RibbonBar8.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar8.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar8.ContainerControlProcessDialogKey = True
        Me.RibbonBar8.DialogLauncherVisible = True
        Me.RibbonBar8.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar8.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem19, Me.ButtonItem29})
        Me.RibbonBar8.Location = New System.Drawing.Point(3, 0)
        Me.RibbonBar8.Name = "RibbonBar8"
        Me.RibbonBar8.Size = New System.Drawing.Size(320, 79)
        Me.RibbonBar8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar8.TabIndex = 7
        Me.RibbonBar8.Text = "Page Setup"
        '
        '
        '
        Me.RibbonBar8.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar8.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar8.TitleVisible = False
        '
        'ButtonItem19
        '
        Me.ButtonItem19.AutoExpandOnClick = True
        Me.ButtonItem19.Image = CType(resources.GetObject("ButtonItem19.Image"), System.Drawing.Image)
        Me.ButtonItem19.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.ButtonItem19.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem19.Name = "ButtonItem19"
        Me.ButtonItem19.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem20, Me.ButtonItem2, Me.ButtonItem21, Me.ButtonItem25, Me.ButtonItem26})
        Me.ButtonItem19.Text = "Sales"
        '
        'ButtonItem20
        '
        Me.ButtonItem20.Name = "ButtonItem20"
        Me.ButtonItem20.Text = "Sales Detail"
        '
        'ButtonItem2
        '
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.Text = "Sales Daily"
        '
        'ButtonItem21
        '
        Me.ButtonItem21.Name = "ButtonItem21"
        Me.ButtonItem21.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem22, Me.ButtonItem23, Me.ButtonItem24})
        Me.ButtonItem21.Text = "Sales Monthly"
        '
        'ButtonItem22
        '
        Me.ButtonItem22.Name = "ButtonItem22"
        Me.ButtonItem22.Text = "Salesman"
        '
        'ButtonItem23
        '
        Me.ButtonItem23.Name = "ButtonItem23"
        Me.ButtonItem23.Text = "Membership"
        '
        'ButtonItem24
        '
        Me.ButtonItem24.Name = "ButtonItem24"
        Me.ButtonItem24.Text = "Cashier"
        '
        'ButtonItem25
        '
        Me.ButtonItem25.Name = "ButtonItem25"
        Me.ButtonItem25.Text = "Cashier Report"
        '
        'ButtonItem26
        '
        Me.ButtonItem26.Name = "ButtonItem26"
        Me.ButtonItem26.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem27, Me.ButtonItem28})
        Me.ButtonItem26.Text = "Sales Top 50"
        '
        'ButtonItem27
        '
        Me.ButtonItem27.Name = "ButtonItem27"
        Me.ButtonItem27.Text = "By Amount"
        '
        'ButtonItem28
        '
        Me.ButtonItem28.Name = "ButtonItem28"
        Me.ButtonItem28.Text = "By Qty"
        '
        'ButtonItem29
        '
        Me.ButtonItem29.AutoExpandOnClick = True
        Me.ButtonItem29.Image = CType(resources.GetObject("ButtonItem29.Image"), System.Drawing.Image)
        Me.ButtonItem29.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.ButtonItem29.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem29.Name = "ButtonItem29"
        Me.ButtonItem29.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem30, Me.ButtonItem31})
        Me.ButtonItem29.Text = "Stock"
        '
        'ButtonItem30
        '
        Me.ButtonItem30.Name = "ButtonItem30"
        Me.ButtonItem30.Text = "Item Stock"
        '
        'ButtonItem31
        '
        Me.ButtonItem31.Name = "ButtonItem31"
        Me.ButtonItem31.Text = "Stock Card"
        '
        'RibbonPanel5
        '
        Me.RibbonPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel5.Controls.Add(Me.RibbonBar9)
        Me.RibbonPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel5.Location = New System.Drawing.Point(0, 54)
        Me.RibbonPanel5.Name = "RibbonPanel5"
        Me.RibbonPanel5.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel5.Size = New System.Drawing.Size(717, 82)
        '
        '
        '
        Me.RibbonPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel5.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel5.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel5.TabIndex = 7
        Me.RibbonPanel5.Visible = False
        '
        'RibbonBar9
        '
        Me.RibbonBar9.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar9.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar9.ContainerControlProcessDialogKey = True
        Me.RibbonBar9.DialogLauncherVisible = True
        Me.RibbonBar9.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar9.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem14, Me.ButtonItem42})
        Me.RibbonBar9.Location = New System.Drawing.Point(3, 0)
        Me.RibbonBar9.Name = "RibbonBar9"
        Me.RibbonBar9.Size = New System.Drawing.Size(101, 79)
        Me.RibbonBar9.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar9.TabIndex = 8
        Me.RibbonBar9.Text = "Page Setup"
        '
        '
        '
        Me.RibbonBar9.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar9.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar9.TitleVisible = False
        '
        'ButtonItem14
        '
        Me.ButtonItem14.Image = CType(resources.GetObject("ButtonItem14.Image"), System.Drawing.Image)
        Me.ButtonItem14.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem14.Name = "ButtonItem14"
        Me.ButtonItem14.Text = "About Us"
        '
        'ButtonItem42
        '
        Me.ButtonItem42.Image = CType(resources.GetObject("ButtonItem42.Image"), System.Drawing.Image)
        Me.ButtonItem42.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem42.Name = "ButtonItem42"
        Me.ButtonItem42.Text = "License"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(99, 0)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 8
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'ButtonFile
        '
        Me.ButtonFile.AutoExpandOnClick = True
        Me.ButtonFile.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image
        Me.ButtonFile.Image = CType(resources.GetObject("ButtonFile.Image"), System.Drawing.Image)
        Me.ButtonFile.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.ButtonFile.ImagePaddingHorizontal = 0
        Me.ButtonFile.ImagePaddingVertical = 0
        Me.ButtonFile.Name = "ButtonFile"
        Me.ButtonFile.ShowSubItems = False
        Me.ButtonFile.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.menuFileContainer})
        '
        'menuFileContainer
        '
        '
        '
        '
        Me.menuFileContainer.BackgroundStyle.Class = "RibbonFileMenuContainer"
        Me.menuFileContainer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.menuFileContainer.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.menuFileContainer.Name = "menuFileContainer"
        Me.menuFileContainer.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.menuFileTwoColumnContainer, Me.menuFileBottomContainer})
        '
        '
        '
        Me.menuFileContainer.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'menuFileTwoColumnContainer
        '
        '
        '
        '
        Me.menuFileTwoColumnContainer.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer"
        Me.menuFileTwoColumnContainer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.menuFileTwoColumnContainer.ItemSpacing = 0
        Me.menuFileTwoColumnContainer.Name = "menuFileTwoColumnContainer"
        Me.menuFileTwoColumnContainer.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.menuFileItems})
        '
        '
        '
        Me.menuFileTwoColumnContainer.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'menuFileItems
        '
        '
        '
        '
        Me.menuFileItems.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.menuFileItems.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer"
        Me.menuFileItems.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.menuFileItems.ItemSpacing = 4
        Me.menuFileItems.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.menuFileItems.MinimumSize = New System.Drawing.Size(120, 0)
        Me.menuFileItems.Name = "menuFileItems"
        '
        '
        '
        Me.menuFileItems.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'menuFileBottomContainer
        '
        '
        '
        '
        Me.menuFileBottomContainer.BackgroundStyle.Class = "RibbonFileMenuBottomContainer"
        Me.menuFileBottomContainer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.menuFileBottomContainer.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right
        Me.menuFileBottomContainer.Name = "menuFileBottomContainer"
        Me.menuFileBottomContainer.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonExit})
        '
        '
        '
        Me.menuFileBottomContainer.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'buttonExit
        '
        Me.buttonExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.buttonExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.buttonExit.Image = CType(resources.GetObject("buttonExit.Image"), System.Drawing.Image)
        Me.buttonExit.Name = "buttonExit"
        Me.buttonExit.SubItemsExpandWidth = 24
        Me.buttonExit.Text = "E&xit <i>RibbonPad</i>"
        Me.buttonExit.Visible = False
        '
        'ribbonTabItem1
        '
        Me.ribbonTabItem1.Name = "ribbonTabItem1"
        Me.ribbonTabItem1.Panel = Me.ribbonPanel1
        Me.ribbonTabItem1.Text = "Data Master"
        '
        'RibbonTabItem2
        '
        Me.RibbonTabItem2.Checked = True
        Me.RibbonTabItem2.Name = "RibbonTabItem2"
        Me.RibbonTabItem2.Panel = Me.RibbonPanel4
        Me.RibbonTabItem2.Text = "Report"
        '
        'RibbonTabItem5
        '
        Me.RibbonTabItem5.Name = "RibbonTabItem5"
        Me.RibbonTabItem5.Panel = Me.RibbonPanel4
        Me.RibbonTabItem5.Text = "Settings"
        Me.RibbonTabItem5.Visible = False
        '
        'RibbonTabItem4
        '
        Me.RibbonTabItem4.Name = "RibbonTabItem4"
        Me.RibbonTabItem4.Panel = Me.RibbonPanel5
        Me.RibbonTabItem4.Text = "Help"
        Me.RibbonTabItem4.Visible = False
        '
        'RibbonTabItemGroup1
        '
        Me.RibbonTabItemGroup1.Color = DevComponents.DotNetBar.eRibbonTabGroupColor.Orange
        Me.RibbonTabItemGroup1.GroupTitle = "Tab Group"
        Me.RibbonTabItemGroup1.Name = "RibbonTabItemGroup1"
        '
        '
        '
        Me.RibbonTabItemGroup1.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.RibbonTabItemGroup1.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.RibbonTabItemGroup1.Style.BackColorGradientAngle = 90
        Me.RibbonTabItemGroup1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.RibbonTabItemGroup1.Style.BorderBottomWidth = 1
        Me.RibbonTabItemGroup1.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.RibbonTabItemGroup1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.RibbonTabItemGroup1.Style.BorderLeftWidth = 1
        Me.RibbonTabItemGroup1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.RibbonTabItemGroup1.Style.BorderRightWidth = 1
        Me.RibbonTabItemGroup1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.RibbonTabItemGroup1.Style.BorderTopWidth = 1
        Me.RibbonTabItemGroup1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonTabItemGroup1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.RibbonTabItemGroup1.Style.TextColor = System.Drawing.Color.Black
        Me.RibbonTabItemGroup1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        'RibbonTabItemGroup2
        '
        Me.RibbonTabItemGroup2.GroupTitle = "New Group"
        Me.RibbonTabItemGroup2.Name = "RibbonTabItemGroup2"
        '
        '
        '
        Me.RibbonTabItemGroup2.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.RibbonTabItemGroup2.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.RibbonTabItemGroup2.Style.BackColorGradientAngle = 90
        Me.RibbonTabItemGroup2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.RibbonTabItemGroup2.Style.BorderBottomWidth = 1
        Me.RibbonTabItemGroup2.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.RibbonTabItemGroup2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.RibbonTabItemGroup2.Style.BorderLeftWidth = 1
        Me.RibbonTabItemGroup2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.RibbonTabItemGroup2.Style.BorderRightWidth = 1
        Me.RibbonTabItemGroup2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.RibbonTabItemGroup2.Style.BorderTopWidth = 1
        Me.RibbonTabItemGroup2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonTabItemGroup2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.RibbonTabItemGroup2.Style.TextColor = System.Drawing.Color.White
        Me.RibbonTabItemGroup2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.RibbonTabItemGroup2.Style.TextShadowColor = System.Drawing.Color.Black
        Me.RibbonTabItemGroup2.Style.TextShadowOffset = New System.Drawing.Point(1, 1)
        '
        'RibbonTabItemGroup3
        '
        Me.RibbonTabItemGroup3.GroupTitle = "New Group"
        Me.RibbonTabItemGroup3.Name = "RibbonTabItemGroup3"
        '
        '
        '
        Me.RibbonTabItemGroup3.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.RibbonTabItemGroup3.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.RibbonTabItemGroup3.Style.BackColorGradientAngle = 90
        Me.RibbonTabItemGroup3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.RibbonTabItemGroup3.Style.BorderBottomWidth = 1
        Me.RibbonTabItemGroup3.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.RibbonTabItemGroup3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.RibbonTabItemGroup3.Style.BorderLeftWidth = 1
        Me.RibbonTabItemGroup3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.RibbonTabItemGroup3.Style.BorderRightWidth = 1
        Me.RibbonTabItemGroup3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.RibbonTabItemGroup3.Style.BorderTopWidth = 1
        Me.RibbonTabItemGroup3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonTabItemGroup3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.RibbonTabItemGroup3.Style.TextColor = System.Drawing.Color.White
        Me.RibbonTabItemGroup3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.RibbonTabItemGroup3.Style.TextShadowColor = System.Drawing.Color.Black
        Me.RibbonTabItemGroup3.Style.TextShadowOffset = New System.Drawing.Point(1, 1)
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerColorTint = System.Drawing.Color.White
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Silver
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
        '
        'barStatus
        '
        Me.barStatus.AccessibleDescription = "DotNetBar Bar (barStatus)"
        Me.barStatus.AccessibleName = "DotNetBar Bar"
        Me.barStatus.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar
        Me.barStatus.AntiAlias = True
        Me.barStatus.BarType = DevComponents.DotNetBar.eBarType.StatusBar
        Me.barStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.barStatus.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.ResizeHandle
        Me.barStatus.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.labelStatus, Me.labelPosition})
        Me.barStatus.ItemSpacing = 2
        Me.barStatus.Location = New System.Drawing.Point(5, 457)
        Me.barStatus.Name = "barStatus"
        Me.barStatus.Size = New System.Drawing.Size(717, 20)
        Me.barStatus.Stretch = True
        Me.barStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.barStatus.TabIndex = 16
        Me.barStatus.TabStop = False
        '
        'labelStatus
        '
        Me.labelStatus.Name = "labelStatus"
        Me.labelStatus.PaddingLeft = 2
        Me.labelStatus.PaddingRight = 2
        Me.labelStatus.SingleLineColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.labelStatus.Stretch = True
        Me.labelStatus.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer12})
        '
        'ItemContainer12
        '
        '
        '
        '
        Me.ItemContainer12.BackgroundStyle.Class = "Office2007StatusBarBackground2"
        Me.ItemContainer12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer12.Name = "ItemContainer12"
        '
        '
        '
        Me.ItemContainer12.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'labelPosition
        '
        Me.labelPosition.Name = "labelPosition"
        Me.labelPosition.PaddingLeft = 2
        Me.labelPosition.PaddingRight = 2
        Me.labelPosition.SingleLineColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.labelPosition.TextAlignment = System.Drawing.StringAlignment.Far
        Me.labelPosition.Width = 100
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'tabStrip1
        '
        Me.tabStrip1.AutoSelectAttachedControl = True
        Me.tabStrip1.CanReorderTabs = True
        Me.tabStrip1.CloseButtonOnTabsVisible = True
        Me.tabStrip1.CloseButtonPosition = DevComponents.DotNetBar.eTabCloseButtonPosition.Right
        Me.tabStrip1.CloseButtonVisible = True
        Me.tabStrip1.Dock = System.Windows.Forms.DockStyle.Top
        Me.tabStrip1.Location = New System.Drawing.Point(5, 139)
        Me.tabStrip1.MdiTabbedDocuments = True
        Me.tabStrip1.Name = "tabStrip1"
        Me.tabStrip1.SelectedTab = Nothing
        Me.tabStrip1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabStrip1.Size = New System.Drawing.Size(717, 26)
        Me.tabStrip1.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Dock
        Me.tabStrip1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top
        Me.tabStrip1.TabIndex = 18
        Me.tabStrip1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.tabStrip1.Text = "tabStrip1"
        '
        'ButtonItem8
        '
        Me.ButtonItem8.Image = CType(resources.GetObject("ButtonItem8.Image"), System.Drawing.Image)
        Me.ButtonItem8.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem8.Name = "ButtonItem8"
        Me.ButtonItem8.Text = "Calculate Production Planning"
        '
        'ButtonItem5
        '
        Me.ButtonItem5.Image = CType(resources.GetObject("ButtonItem5.Image"), System.Drawing.Image)
        Me.ButtonItem5.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.ButtonItem5.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem5.Name = "ButtonItem5"
        Me.ButtonItem5.Text = "Product"
        '
        'ButtonItem6
        '
        Me.ButtonItem6.Image = CType(resources.GetObject("ButtonItem6.Image"), System.Drawing.Image)
        Me.ButtonItem6.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.ButtonItem6.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem6.Name = "ButtonItem6"
        Me.ButtonItem6.Text = "Product"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 479)
        Me.Controls.Add(Me.tabStrip1)
        Me.Controls.Add(Me.barStatus)
        Me.Controls.Add(Me.ribbon1)
        Me.EnableGlass = False
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.Text = "Toko Madju - POS Management System v1.0 - Powered by adnetindo.com"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ribbon1.ResumeLayout(False)
        Me.ribbon1.PerformLayout()
        Me.ribbonPanel1.ResumeLayout(False)
        Me.RibbonPanel4.ResumeLayout(False)
        Me.RibbonPanel5.ResumeLayout(False)
        CType(Me.barStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ribbon1 As DevComponents.DotNetBar.RibbonControl
    Friend WithEvents ribbonPanel1 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents RibbonBar1 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem64 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem9 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonPanel4 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents RibbonBar8 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents RibbonPanel5 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents RibbonBar9 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem14 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem42 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonFile As DevComponents.DotNetBar.Office2007StartButton
    Friend WithEvents menuFileContainer As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents menuFileTwoColumnContainer As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents menuFileItems As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents menuFileBottomContainer As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents buttonExit As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ribbonTabItem1 As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents RibbonTabItem2 As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents RibbonTabItem4 As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents RibbonTabItemGroup1 As DevComponents.DotNetBar.RibbonTabItemGroup
    Friend WithEvents RibbonTabItemGroup2 As DevComponents.DotNetBar.RibbonTabItemGroup
    Friend WithEvents RibbonTabItemGroup3 As DevComponents.DotNetBar.RibbonTabItemGroup
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents RibbonTabItem5 As DevComponents.DotNetBar.RibbonTabItem
    Private WithEvents barStatus As DevComponents.DotNetBar.Bar
    Friend WithEvents labelStatus As DevComponents.DotNetBar.LabelItem
    Friend WithEvents ItemContainer12 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents labelPosition As DevComponents.DotNetBar.LabelItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents tabStrip1 As DevComponents.DotNetBar.TabStrip
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem8 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem7 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem10 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem11 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem12 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem13 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem15 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem16 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem5 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem6 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem17 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem18 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem19 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem20 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem21 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem22 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem23 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem24 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem25 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem26 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem27 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem28 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem29 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem30 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem31 As DevComponents.DotNetBar.ButtonItem
End Class
