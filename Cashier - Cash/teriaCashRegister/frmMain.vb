Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Rendering

Public Class frmMain
    Inherits DevComponents.DotNetBar.Office2007RibbonForm
    'Public doc1 As frmAddMaterials = New frmAddMaterials()


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents imageList1 As System.Windows.Forms.ImageList
    Friend WithEvents openFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents saveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents labelStatus As DevComponents.DotNetBar.LabelItem
    Private WithEvents barStatus As DevComponents.DotNetBar.Bar
    Friend WithEvents ribbonControl1 As DevComponents.DotNetBar.RibbonControl
    Friend WithEvents ribbonPanel1 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents ribbonPanel3 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents ribbonTabItem1 As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents ribbonTabItem3 As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents RibbonTabItemGroup1 As DevComponents.DotNetBar.RibbonTabItemGroup
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents buttonChangeStyle As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonStyleOffice2007Blue As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonStyleOffice2007Black As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonFile As DevComponents.DotNetBar.Office2007StartButton
    Friend WithEvents buttonItem47 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem48 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem49 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem18 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem19 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem21 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonStyleOffice2007Silver As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonStyleCustom As DevComponents.DotNetBar.ColorPickerDropDown
    Friend WithEvents AppCommandSaveAs As DevComponents.DotNetBar.Command
    Friend WithEvents AppCommandTheme As DevComponents.DotNetBar.Command
    Friend WithEvents AppCommandSave As DevComponents.DotNetBar.Command
    Friend WithEvents AppCommandNew As DevComponents.DotNetBar.Command
    Friend WithEvents AppCommandOpen As DevComponents.DotNetBar.Command
    Friend WithEvents AppCommandClose As DevComponents.DotNetBar.Command
    Friend WithEvents buttonVistaGlass As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem54 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem55 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonStyleOffice2010Blue As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonStyleOffice2010Black As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonPanel5 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents RibbonPanel4 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents RibbonTabItem2 As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents RibbonTabItem4 As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents RibbonTabItemGroup2 As DevComponents.DotNetBar.RibbonTabItemGroup
    Friend WithEvents RibbonTabItemGroup3 As DevComponents.DotNetBar.RibbonTabItemGroup
    Friend WithEvents LabelItem2 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents itemContainer1 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents buttonCut As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonCopy As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar1 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem64 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem5 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem9 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar2 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem6 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem11 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar8 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem138 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem40 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar9 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem14 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem42 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RibbonPanel2 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents RibbonBar3 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem12 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonTabItem5 As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem15 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem16 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem30 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents tabStrip1 As DevComponents.DotNetBar.TabStrip
    Friend WithEvents ButtonItem24 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem7 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem63 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem65 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem17 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem27 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem59 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem61 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem8 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem20 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem23 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem26 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem28 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem13 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem29 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem31 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem32 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem33 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem34 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem22 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem35 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem36 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem37 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem39 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem38 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.barStatus = New DevComponents.DotNetBar.Bar
        Me.labelStatus = New DevComponents.DotNetBar.LabelItem
        Me.ribbonControl1 = New DevComponents.DotNetBar.RibbonControl
        Me.ribbonPanel1 = New DevComponents.DotNetBar.RibbonPanel
        Me.RibbonBar1 = New DevComponents.DotNetBar.RibbonBar
        Me.ButtonItem5 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem65 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem9 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem64 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem30 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem63 = New DevComponents.DotNetBar.ButtonItem
        Me.RibbonPanel2 = New DevComponents.DotNetBar.RibbonPanel
        Me.RibbonBar3 = New DevComponents.DotNetBar.RibbonBar
        Me.ButtonItem24 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem7 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem8 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem20 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem23 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem26 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem28 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem13 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem29 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem31 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem32 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem33 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem34 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem37 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem39 = New DevComponents.DotNetBar.ButtonItem
        Me.RibbonPanel4 = New DevComponents.DotNetBar.RibbonPanel
        Me.RibbonBar8 = New DevComponents.DotNetBar.RibbonBar
        Me.ButtonItem40 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem138 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem12 = New DevComponents.DotNetBar.ButtonItem
        Me.ribbonPanel3 = New DevComponents.DotNetBar.RibbonPanel
        Me.RibbonBar2 = New DevComponents.DotNetBar.RibbonBar
        Me.ButtonItem4 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem6 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem11 = New DevComponents.DotNetBar.ButtonItem
        Me.RibbonPanel5 = New DevComponents.DotNetBar.RibbonPanel
        Me.RibbonBar9 = New DevComponents.DotNetBar.RibbonBar
        Me.ButtonItem14 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem42 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonFile = New DevComponents.DotNetBar.Office2007StartButton
        Me.ribbonTabItem3 = New DevComponents.DotNetBar.RibbonTabItem
        Me.RibbonTabItem5 = New DevComponents.DotNetBar.RibbonTabItem
        Me.ribbonTabItem1 = New DevComponents.DotNetBar.RibbonTabItem
        Me.RibbonTabItem2 = New DevComponents.DotNetBar.RibbonTabItem
        Me.RibbonTabItem4 = New DevComponents.DotNetBar.RibbonTabItem
        Me.buttonChangeStyle = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonStyleOffice2010Blue = New DevComponents.DotNetBar.ButtonItem
        Me.AppCommandTheme = New DevComponents.DotNetBar.Command(Me.components)
        Me.ButtonItem54 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonStyleOffice2010Black = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem55 = New DevComponents.DotNetBar.ButtonItem
        Me.buttonStyleOffice2007Blue = New DevComponents.DotNetBar.ButtonItem
        Me.buttonStyleOffice2007Black = New DevComponents.DotNetBar.ButtonItem
        Me.buttonStyleOffice2007Silver = New DevComponents.DotNetBar.ButtonItem
        Me.buttonVistaGlass = New DevComponents.DotNetBar.ButtonItem
        Me.buttonStyleCustom = New DevComponents.DotNetBar.ColorPickerDropDown
        Me.RibbonTabItemGroup1 = New DevComponents.DotNetBar.RibbonTabItemGroup
        Me.RibbonTabItemGroup2 = New DevComponents.DotNetBar.RibbonTabItemGroup
        Me.RibbonTabItemGroup3 = New DevComponents.DotNetBar.RibbonTabItemGroup
        Me.AppCommandClose = New DevComponents.DotNetBar.Command(Me.components)
        Me.AppCommandSave = New DevComponents.DotNetBar.Command(Me.components)
        Me.AppCommandNew = New DevComponents.DotNetBar.Command(Me.components)
        Me.AppCommandOpen = New DevComponents.DotNetBar.Command(Me.components)
        Me.AppCommandSaveAs = New DevComponents.DotNetBar.Command(Me.components)
        Me.ComboItem1 = New DevComponents.Editors.ComboItem
        Me.ComboItem2 = New DevComponents.Editors.ComboItem
        Me.ComboItem3 = New DevComponents.Editors.ComboItem
        Me.ComboItem4 = New DevComponents.Editors.ComboItem
        Me.ComboItem5 = New DevComponents.Editors.ComboItem
        Me.ComboItem6 = New DevComponents.Editors.ComboItem
        Me.ComboItem7 = New DevComponents.Editors.ComboItem
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.LabelItem2 = New DevComponents.DotNetBar.LabelItem
        Me.itemContainer1 = New DevComponents.DotNetBar.ItemContainer
        Me.buttonCut = New DevComponents.DotNetBar.ButtonItem
        Me.buttonCopy = New DevComponents.DotNetBar.ButtonItem
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tabStrip1 = New DevComponents.DotNetBar.TabStrip
        Me.ButtonItem18 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem19 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem21 = New DevComponents.DotNetBar.ButtonItem
        Me.buttonItem47 = New DevComponents.DotNetBar.ButtonItem
        Me.buttonItem48 = New DevComponents.DotNetBar.ButtonItem
        Me.buttonItem49 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem15 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem16 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem17 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem27 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem59 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem61 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem22 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem35 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem36 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem38 = New DevComponents.DotNetBar.ButtonItem
        CType(Me.barStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ribbonControl1.SuspendLayout()
        Me.ribbonPanel1.SuspendLayout()
        Me.RibbonPanel2.SuspendLayout()
        Me.RibbonPanel4.SuspendLayout()
        Me.ribbonPanel3.SuspendLayout()
        Me.RibbonPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
        Me.imageList1.Images.SetKeyName(0, "")
        Me.imageList1.Images.SetKeyName(1, "")
        Me.imageList1.Images.SetKeyName(2, "")
        Me.imageList1.Images.SetKeyName(3, "")
        Me.imageList1.Images.SetKeyName(4, "")
        Me.imageList1.Images.SetKeyName(5, "")
        Me.imageList1.Images.SetKeyName(6, "")
        Me.imageList1.Images.SetKeyName(7, "")
        Me.imageList1.Images.SetKeyName(8, "")
        Me.imageList1.Images.SetKeyName(9, "")
        Me.imageList1.Images.SetKeyName(10, "")
        Me.imageList1.Images.SetKeyName(11, "")
        Me.imageList1.Images.SetKeyName(12, "")
        Me.imageList1.Images.SetKeyName(13, "")
        Me.imageList1.Images.SetKeyName(14, "")
        Me.imageList1.Images.SetKeyName(15, "")
        Me.imageList1.Images.SetKeyName(16, "")
        Me.imageList1.Images.SetKeyName(17, "")
        Me.imageList1.Images.SetKeyName(18, "")
        Me.imageList1.Images.SetKeyName(19, "")
        Me.imageList1.Images.SetKeyName(20, "")
        Me.imageList1.Images.SetKeyName(21, "")
        Me.imageList1.Images.SetKeyName(22, "")
        Me.imageList1.Images.SetKeyName(23, "")
        '
        'saveFileDialog1
        '
        Me.saveFileDialog1.FileName = "doc1"
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
        Me.barStatus.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.labelStatus})
        Me.barStatus.ItemSpacing = 2
        Me.barStatus.Location = New System.Drawing.Point(5, 383)
        Me.barStatus.Name = "barStatus"
        Me.barStatus.Size = New System.Drawing.Size(804, 20)
        Me.barStatus.Stretch = True
        Me.barStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.barStatus.TabIndex = 9
        Me.barStatus.TabStop = False
        '
        'labelStatus
        '
        Me.labelStatus.Name = "labelStatus"
        Me.labelStatus.PaddingLeft = 2
        Me.labelStatus.PaddingRight = 2
        Me.labelStatus.SingleLineColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.labelStatus.Stretch = True
        '
        'ribbonControl1
        '
        Me.ribbonControl1.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ribbonControl1.CanCustomize = False
        Me.ribbonControl1.CaptionVisible = True
        Me.ribbonControl1.Controls.Add(Me.ribbonPanel3)
        Me.ribbonControl1.Controls.Add(Me.RibbonPanel2)
        Me.ribbonControl1.Controls.Add(Me.ribbonPanel1)
        Me.ribbonControl1.Controls.Add(Me.RibbonPanel4)
        Me.ribbonControl1.Controls.Add(Me.RibbonPanel5)
        Me.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ribbonControl1.ForeColor = System.Drawing.Color.Black
        Me.ribbonControl1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonFile, Me.ribbonTabItem3, Me.RibbonTabItem5, Me.ribbonTabItem1, Me.RibbonTabItem2, Me.RibbonTabItem4, Me.buttonChangeStyle})
        Me.ribbonControl1.Location = New System.Drawing.Point(5, 1)
        Me.ribbonControl1.MdiSystemItemVisible = False
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.ribbonControl1.Size = New System.Drawing.Size(804, 138)
        Me.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon"
        Me.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon"
        Me.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar"
        Me.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>"
        Me.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar..."
        Me.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>"
        Me.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel"
        Me.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar"
        Me.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:"
        Me.ribbonControl1.SystemText.QatDialogOkButton = "OK"
        Me.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon"
        Me.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove"
        Me.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon"
        Me.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon"
        Me.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar"
        Me.ribbonControl1.TabGroupHeight = 14
        Me.ribbonControl1.TabGroups.AddRange(New DevComponents.DotNetBar.RibbonTabItemGroup() {Me.RibbonTabItemGroup1, Me.RibbonTabItemGroup2, Me.RibbonTabItemGroup3})
        Me.ribbonControl1.TabGroupsVisible = True
        Me.ribbonControl1.TabIndex = 11
        '
        'ribbonPanel1
        '
        Me.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ribbonPanel1.Controls.Add(Me.RibbonBar1)
        Me.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ribbonPanel1.Location = New System.Drawing.Point(0, 54)
        Me.ribbonPanel1.Name = "ribbonPanel1"
        Me.ribbonPanel1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.ribbonPanel1.Size = New System.Drawing.Size(804, 82)
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
        Me.RibbonBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem5, Me.ButtonItem65, Me.ButtonItem9, Me.ButtonItem64, Me.ButtonItem30, Me.ButtonItem63})
        Me.RibbonBar1.Location = New System.Drawing.Point(3, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Size = New System.Drawing.Size(410, 79)
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
        'ButtonItem5
        '
        Me.ButtonItem5.Image = CType(resources.GetObject("ButtonItem5.Image"), System.Drawing.Image)
        Me.ButtonItem5.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem5.Name = "ButtonItem5"
        Me.ButtonItem5.Text = "Customer"
        '
        'ButtonItem65
        '
        Me.ButtonItem65.Image = CType(resources.GetObject("ButtonItem65.Image"), System.Drawing.Image)
        Me.ButtonItem65.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem65.Name = "ButtonItem65"
        Me.ButtonItem65.Text = "Employee"
        '
        'ButtonItem9
        '
        Me.ButtonItem9.Image = CType(resources.GetObject("ButtonItem9.Image"), System.Drawing.Image)
        Me.ButtonItem9.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem9.Name = "ButtonItem9"
        Me.ButtonItem9.Text = "Vendor"
        '
        'ButtonItem64
        '
        Me.ButtonItem64.Image = CType(resources.GetObject("ButtonItem64.Image"), System.Drawing.Image)
        Me.ButtonItem64.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.ButtonItem64.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem64.Name = "ButtonItem64"
        Me.ButtonItem64.Text = "Items"
        '
        'ButtonItem30
        '
        Me.ButtonItem30.Image = CType(resources.GetObject("ButtonItem30.Image"), System.Drawing.Image)
        Me.ButtonItem30.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem30.Name = "ButtonItem30"
        Me.ButtonItem30.Text = "Category"
        '
        'ButtonItem63
        '
        Me.ButtonItem63.Image = CType(resources.GetObject("ButtonItem63.Image"), System.Drawing.Image)
        Me.ButtonItem63.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem63.Name = "ButtonItem63"
        Me.ButtonItem63.Text = "Voucher"
        '
        'RibbonPanel2
        '
        Me.RibbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel2.Controls.Add(Me.RibbonBar3)
        Me.RibbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel2.Location = New System.Drawing.Point(0, 54)
        Me.RibbonPanel2.Name = "RibbonPanel2"
        Me.RibbonPanel2.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel2.Size = New System.Drawing.Size(804, 82)
        '
        '
        '
        Me.RibbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel2.TabIndex = 8
        Me.RibbonPanel2.Visible = False
        '
        'RibbonBar3
        '
        Me.RibbonBar3.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar3.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar3.ContainerControlProcessDialogKey = True
        Me.RibbonBar3.DialogLauncherVisible = True
        Me.RibbonBar3.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar3.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem24, Me.ButtonItem7, Me.ButtonItem8, Me.ButtonItem20, Me.ButtonItem23, Me.ButtonItem26, Me.ButtonItem28, Me.ButtonItem13, Me.ButtonItem29, Me.ButtonItem31, Me.ButtonItem32, Me.ButtonItem33, Me.ButtonItem34, Me.ButtonItem37, Me.ButtonItem39})
        Me.RibbonBar3.Location = New System.Drawing.Point(3, 0)
        Me.RibbonBar3.Name = "RibbonBar3"
        Me.RibbonBar3.Size = New System.Drawing.Size(829, 79)
        Me.RibbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar3.TabIndex = 3
        '
        '
        '
        Me.RibbonBar3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar3.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar3.TitleVisible = False
        '
        'ButtonItem24
        '
        Me.ButtonItem24.Image = CType(resources.GetObject("ButtonItem24.Image"), System.Drawing.Image)
        Me.ButtonItem24.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem24.Name = "ButtonItem24"
        Me.ButtonItem24.Text = "Sales"
        '
        'ButtonItem7
        '
        Me.ButtonItem7.Image = CType(resources.GetObject("ButtonItem7.Image"), System.Drawing.Image)
        Me.ButtonItem7.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem7.Name = "ButtonItem7"
        Me.ButtonItem7.Text = "Customers"
        '
        'ButtonItem8
        '
        Me.ButtonItem8.Image = CType(resources.GetObject("ButtonItem8.Image"), System.Drawing.Image)
        Me.ButtonItem8.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem8.Name = "ButtonItem8"
        Me.ButtonItem8.Text = "Employees"
        '
        'ButtonItem20
        '
        Me.ButtonItem20.Image = CType(resources.GetObject("ButtonItem20.Image"), System.Drawing.Image)
        Me.ButtonItem20.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem20.Name = "ButtonItem20"
        Me.ButtonItem20.Text = "Discount"
        '
        'ButtonItem23
        '
        Me.ButtonItem23.Image = CType(resources.GetObject("ButtonItem23.Image"), System.Drawing.Image)
        Me.ButtonItem23.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem23.Name = "ButtonItem23"
        Me.ButtonItem23.Text = "Receiving"
        '
        'ButtonItem26
        '
        Me.ButtonItem26.Image = CType(resources.GetObject("ButtonItem26.Image"), System.Drawing.Image)
        Me.ButtonItem26.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem26.Name = "ButtonItem26"
        Me.ButtonItem26.Text = "Inventory"
        '
        'ButtonItem28
        '
        Me.ButtonItem28.Image = CType(resources.GetObject("ButtonItem28.Image"), System.Drawing.Image)
        Me.ButtonItem28.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem28.Name = "ButtonItem28"
        Me.ButtonItem28.Text = "Items"
        '
        'ButtonItem13
        '
        Me.ButtonItem13.Image = CType(resources.GetObject("ButtonItem13.Image"), System.Drawing.Image)
        Me.ButtonItem13.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem13.Name = "ButtonItem13"
        Me.ButtonItem13.Text = "Categories"
        '
        'ButtonItem29
        '
        Me.ButtonItem29.Image = CType(resources.GetObject("ButtonItem29.Image"), System.Drawing.Image)
        Me.ButtonItem29.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem29.Name = "ButtonItem29"
        Me.ButtonItem29.Text = "Customers"
        '
        'ButtonItem31
        '
        Me.ButtonItem31.Image = CType(resources.GetObject("ButtonItem31.Image"), System.Drawing.Image)
        Me.ButtonItem31.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem31.Name = "ButtonItem31"
        Me.ButtonItem31.Text = "Package"
        '
        'ButtonItem32
        '
        Me.ButtonItem32.Image = CType(resources.GetObject("ButtonItem32.Image"), System.Drawing.Image)
        Me.ButtonItem32.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem32.Name = "ButtonItem32"
        Me.ButtonItem32.Text = "Payment"
        '
        'ButtonItem33
        '
        Me.ButtonItem33.Image = CType(resources.GetObject("ButtonItem33.Image"), System.Drawing.Image)
        Me.ButtonItem33.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem33.Name = "ButtonItem33"
        Me.ButtonItem33.Text = "Suppliers"
        '
        'ButtonItem34
        '
        Me.ButtonItem34.Image = CType(resources.GetObject("ButtonItem34.Image"), System.Drawing.Image)
        Me.ButtonItem34.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem34.Name = "ButtonItem34"
        Me.ButtonItem34.Text = "Taxes"
        '
        'ButtonItem37
        '
        Me.ButtonItem37.Image = CType(resources.GetObject("ButtonItem37.Image"), System.Drawing.Image)
        Me.ButtonItem37.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem37.Name = "ButtonItem37"
        Me.ButtonItem37.Text = "Deleted Sales"
        '
        'ButtonItem39
        '
        Me.ButtonItem39.Image = CType(resources.GetObject("ButtonItem39.Image"), System.Drawing.Image)
        Me.ButtonItem39.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem39.Name = "ButtonItem39"
        Me.ButtonItem39.Text = "Voucher"
        '
        'RibbonPanel4
        '
        Me.RibbonPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel4.Controls.Add(Me.RibbonBar8)
        Me.RibbonPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel4.Location = New System.Drawing.Point(0, 54)
        Me.RibbonPanel4.Name = "RibbonPanel4"
        Me.RibbonPanel4.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel4.Size = New System.Drawing.Size(804, 82)
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
        Me.RibbonPanel4.Visible = False
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
        Me.RibbonBar8.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem40, Me.ButtonItem138, Me.ButtonItem12})
        Me.RibbonBar8.Location = New System.Drawing.Point(3, 0)
        Me.RibbonBar8.Name = "RibbonBar8"
        Me.RibbonBar8.Size = New System.Drawing.Size(217, 79)
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
        'ButtonItem40
        '
        Me.ButtonItem40.Image = CType(resources.GetObject("ButtonItem40.Image"), System.Drawing.Image)
        Me.ButtonItem40.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.ButtonItem40.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem40.Name = "ButtonItem40"
        Me.ButtonItem40.Text = "Preferences"
        '
        'ButtonItem138
        '
        Me.ButtonItem138.Image = CType(resources.GetObject("ButtonItem138.Image"), System.Drawing.Image)
        Me.ButtonItem138.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.ButtonItem138.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem138.Name = "ButtonItem138"
        Me.ButtonItem138.Text = "User Management"
        '
        'ButtonItem12
        '
        Me.ButtonItem12.Image = CType(resources.GetObject("ButtonItem12.Image"), System.Drawing.Image)
        Me.ButtonItem12.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem12.Name = "ButtonItem12"
        Me.ButtonItem12.Text = "Company Profile"
        '
        'ribbonPanel3
        '
        Me.ribbonPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ribbonPanel3.Controls.Add(Me.RibbonBar2)
        Me.ribbonPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ribbonPanel3.Location = New System.Drawing.Point(0, 54)
        Me.ribbonPanel3.Name = "ribbonPanel3"
        Me.ribbonPanel3.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.ribbonPanel3.Size = New System.Drawing.Size(804, 82)
        '
        '
        '
        Me.ribbonPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribbonPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribbonPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ribbonPanel3.TabIndex = 3
        '
        'RibbonBar2
        '
        Me.RibbonBar2.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar2.ContainerControlProcessDialogKey = True
        Me.RibbonBar2.DialogLauncherVisible = True
        Me.RibbonBar2.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem4, Me.ButtonItem1, Me.ButtonItem6, Me.ButtonItem11})
        Me.RibbonBar2.Location = New System.Drawing.Point(3, 0)
        Me.RibbonBar2.Name = "RibbonBar2"
        Me.RibbonBar2.Size = New System.Drawing.Size(206, 79)
        Me.RibbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar2.TabIndex = 2
        '
        '
        '
        Me.RibbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar2.TitleVisible = False
        '
        'ButtonItem4
        '
        Me.ButtonItem4.Image = CType(resources.GetObject("ButtonItem4.Image"), System.Drawing.Image)
        Me.ButtonItem4.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem4.Name = "ButtonItem4"
        Me.ButtonItem4.Text = "Sales"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.Image = CType(resources.GetObject("ButtonItem1.Image"), System.Drawing.Image)
        Me.ButtonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Text = "Sales Return"
        '
        'ButtonItem6
        '
        Me.ButtonItem6.Image = CType(resources.GetObject("ButtonItem6.Image"), System.Drawing.Image)
        Me.ButtonItem6.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem6.Name = "ButtonItem6"
        Me.ButtonItem6.Text = "Receiving"
        '
        'ButtonItem11
        '
        Me.ButtonItem11.Image = CType(resources.GetObject("ButtonItem11.Image"), System.Drawing.Image)
        Me.ButtonItem11.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem11.Name = "ButtonItem11"
        Me.ButtonItem11.Text = "Receiving Return"
        '
        'RibbonPanel5
        '
        Me.RibbonPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel5.Controls.Add(Me.RibbonBar9)
        Me.RibbonPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel5.Location = New System.Drawing.Point(0, 54)
        Me.RibbonPanel5.Name = "RibbonPanel5"
        Me.RibbonPanel5.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel5.Size = New System.Drawing.Size(804, 82)
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
        Me.RibbonBar9.Size = New System.Drawing.Size(111, 79)
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
        Me.ButtonItem42.Text = "Technical Support"
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
        Me.ButtonFile.Text = "F&ile"
        '
        'ribbonTabItem3
        '
        Me.ribbonTabItem3.Checked = True
        Me.ribbonTabItem3.Name = "ribbonTabItem3"
        Me.ribbonTabItem3.Panel = Me.ribbonPanel3
        Me.ribbonTabItem3.Text = "Transactions"
        '
        'RibbonTabItem5
        '
        Me.RibbonTabItem5.Name = "RibbonTabItem5"
        Me.RibbonTabItem5.Panel = Me.RibbonPanel2
        Me.RibbonTabItem5.Text = "Reports"
        '
        'ribbonTabItem1
        '
        Me.ribbonTabItem1.Name = "ribbonTabItem1"
        Me.ribbonTabItem1.Panel = Me.ribbonPanel1
        Me.ribbonTabItem1.Text = "Master"
        '
        'RibbonTabItem2
        '
        Me.RibbonTabItem2.Name = "RibbonTabItem2"
        Me.RibbonTabItem2.Panel = Me.RibbonPanel4
        Me.RibbonTabItem2.Text = "Settings"
        '
        'RibbonTabItem4
        '
        Me.RibbonTabItem4.Name = "RibbonTabItem4"
        Me.RibbonTabItem4.Panel = Me.RibbonPanel5
        Me.RibbonTabItem4.Text = "Help"
        '
        'buttonChangeStyle
        '
        Me.buttonChangeStyle.AutoExpandOnClick = True
        Me.buttonChangeStyle.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far
        Me.buttonChangeStyle.Name = "buttonChangeStyle"
        Me.buttonChangeStyle.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonStyleOffice2010Blue, Me.ButtonItem54, Me.ButtonStyleOffice2010Black, Me.ButtonItem55, Me.buttonStyleOffice2007Blue, Me.buttonStyleOffice2007Black, Me.buttonStyleOffice2007Silver, Me.buttonVistaGlass, Me.buttonStyleCustom})
        Me.buttonChangeStyle.Text = "Style"
        '
        'ButtonStyleOffice2010Blue
        '
        Me.ButtonStyleOffice2010Blue.Command = Me.AppCommandTheme
        Me.ButtonStyleOffice2010Blue.CommandParameter = "Office2010Blue"
        Me.ButtonStyleOffice2010Blue.Name = "ButtonStyleOffice2010Blue"
        Me.ButtonStyleOffice2010Blue.Text = "Office 2010 Blue"
        '
        'AppCommandTheme
        '
        Me.AppCommandTheme.Name = "AppCommandTheme"
        '
        'ButtonItem54
        '
        Me.ButtonItem54.Command = Me.AppCommandTheme
        Me.ButtonItem54.CommandParameter = "Office2010Silver"
        Me.ButtonItem54.Name = "ButtonItem54"
        Me.ButtonItem54.OptionGroup = "style"
        Me.ButtonItem54.Text = "Office 2010 <font color=""Silver""><b>Silver</b></font>"
        '
        'ButtonStyleOffice2010Black
        '
        Me.ButtonStyleOffice2010Black.Command = Me.AppCommandTheme
        Me.ButtonStyleOffice2010Black.CommandParameter = "Office2010Black"
        Me.ButtonStyleOffice2010Black.Name = "ButtonStyleOffice2010Black"
        Me.ButtonStyleOffice2010Black.OptionGroup = "style"
        Me.ButtonStyleOffice2010Black.Text = "Office 2010 Black"
        '
        'ButtonItem55
        '
        Me.ButtonItem55.Checked = True
        Me.ButtonItem55.Command = Me.AppCommandTheme
        Me.ButtonItem55.CommandParameter = "Windows7Blue"
        Me.ButtonItem55.Name = "ButtonItem55"
        Me.ButtonItem55.OptionGroup = "style"
        Me.ButtonItem55.Text = "Windows 7"
        '
        'buttonStyleOffice2007Blue
        '
        Me.buttonStyleOffice2007Blue.Command = Me.AppCommandTheme
        Me.buttonStyleOffice2007Blue.CommandParameter = "Office2007Blue"
        Me.buttonStyleOffice2007Blue.Name = "buttonStyleOffice2007Blue"
        Me.buttonStyleOffice2007Blue.OptionGroup = "style"
        Me.buttonStyleOffice2007Blue.Text = "Office 2007 <font color=""Blue""><b>Blue</b></font>"
        '
        'buttonStyleOffice2007Black
        '
        Me.buttonStyleOffice2007Black.Command = Me.AppCommandTheme
        Me.buttonStyleOffice2007Black.CommandParameter = "Office2007Black"
        Me.buttonStyleOffice2007Black.Name = "buttonStyleOffice2007Black"
        Me.buttonStyleOffice2007Black.OptionGroup = "style"
        Me.buttonStyleOffice2007Black.Text = "Office 2007 <font color=""Black""><b>Black</b></font>"
        '
        'buttonStyleOffice2007Silver
        '
        Me.buttonStyleOffice2007Silver.Command = Me.AppCommandTheme
        Me.buttonStyleOffice2007Silver.CommandParameter = "Office2007Silver"
        Me.buttonStyleOffice2007Silver.Name = "buttonStyleOffice2007Silver"
        Me.buttonStyleOffice2007Silver.Text = "Office 2007 <font color=""Silver""><b>Silver</b></font>"
        '
        'buttonVistaGlass
        '
        Me.buttonVistaGlass.Command = Me.AppCommandTheme
        Me.buttonVistaGlass.CommandParameter = "Office2007VistaGlass"
        Me.buttonVistaGlass.Name = "buttonVistaGlass"
        Me.buttonVistaGlass.OptionGroup = "style"
        Me.buttonVistaGlass.Text = "Vista Glass"
        '
        'buttonStyleCustom
        '
        Me.buttonStyleCustom.BeginGroup = True
        Me.buttonStyleCustom.Command = Me.AppCommandTheme
        Me.buttonStyleCustom.Name = "buttonStyleCustom"
        Me.buttonStyleCustom.Text = "Custom scheme"
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
        'AppCommandClose
        '
        Me.AppCommandClose.Name = "AppCommandClose"
        '
        'AppCommandSave
        '
        Me.AppCommandSave.Name = "AppCommandSave"
        '
        'AppCommandNew
        '
        Me.AppCommandNew.Name = "AppCommandNew"
        '
        'AppCommandOpen
        '
        Me.AppCommandOpen.Name = "AppCommandOpen"
        '
        'AppCommandSaveAs
        '
        Me.AppCommandSaveAs.Name = "AppCommandSaveAs"
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "6"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "7"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "8"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "9"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "10"
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "11"
        '
        'ComboItem7
        '
        Me.ComboItem7.Text = "12"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Silver
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(232, Byte), Integer)))
        '
        'LabelItem2
        '
        Me.LabelItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.LabelItem2.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.LabelItem2.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.LabelItem2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.LabelItem2.Name = "LabelItem2"
        Me.LabelItem2.PaddingBottom = 1
        Me.LabelItem2.PaddingLeft = 10
        Me.LabelItem2.PaddingTop = 1
        Me.LabelItem2.SingleLineColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.LabelItem2.Text = "LabelItem2"
        '
        'itemContainer1
        '
        '
        '
        '
        Me.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.itemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.itemContainer1.Name = "itemContainer1"
        Me.itemContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonCut, Me.buttonCopy})
        '
        '
        '
        Me.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'buttonCut
        '
        Me.buttonCut.Enabled = False
        Me.buttonCut.Image = CType(resources.GetObject("buttonCut.Image"), System.Drawing.Image)
        Me.buttonCut.Name = "buttonCut"
        Me.buttonCut.Text = "Cut"
        '
        'buttonCopy
        '
        Me.buttonCopy.Enabled = False
        Me.buttonCopy.Image = CType(resources.GetObject("buttonCopy.Image"), System.Drawing.Image)
        Me.buttonCopy.Name = "buttonCopy"
        Me.buttonCopy.Text = "Copy"
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
        Me.tabStrip1.ForeColor = System.Drawing.Color.Black
        Me.tabStrip1.Location = New System.Drawing.Point(5, 139)
        Me.tabStrip1.MdiForm = Me
        Me.tabStrip1.MdiTabbedDocuments = True
        Me.tabStrip1.Name = "tabStrip1"
        Me.tabStrip1.SelectedTab = Nothing
        Me.tabStrip1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabStrip1.Size = New System.Drawing.Size(804, 26)
        Me.tabStrip1.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Dock
        Me.tabStrip1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top
        Me.tabStrip1.TabIndex = 13
        Me.tabStrip1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.tabStrip1.Text = "tabStrip1"
        '
        'ButtonItem18
        '
        Me.ButtonItem18.BeginGroup = True
        Me.ButtonItem18.Image = CType(resources.GetObject("ButtonItem18.Image"), System.Drawing.Image)
        Me.ButtonItem18.Name = "ButtonItem18"
        Me.ButtonItem18.Text = "Search for Templates Online..."
        '
        'ButtonItem19
        '
        Me.ButtonItem19.Image = CType(resources.GetObject("ButtonItem19.Image"), System.Drawing.Image)
        Me.ButtonItem19.Name = "ButtonItem19"
        Me.ButtonItem19.Text = "Browse for Templates..."
        '
        'ButtonItem21
        '
        Me.ButtonItem21.Image = CType(resources.GetObject("ButtonItem21.Image"), System.Drawing.Image)
        Me.ButtonItem21.Name = "ButtonItem21"
        Me.ButtonItem21.Text = "Save Current Template..."
        '
        'buttonItem47
        '
        Me.buttonItem47.BeginGroup = True
        Me.buttonItem47.Image = CType(resources.GetObject("buttonItem47.Image"), System.Drawing.Image)
        Me.buttonItem47.Name = "buttonItem47"
        Me.buttonItem47.Text = "Search for Templates Online..."
        '
        'buttonItem48
        '
        Me.buttonItem48.Image = CType(resources.GetObject("buttonItem48.Image"), System.Drawing.Image)
        Me.buttonItem48.Name = "buttonItem48"
        Me.buttonItem48.Text = "Browse for Templates..."
        '
        'buttonItem49
        '
        Me.buttonItem49.Image = CType(resources.GetObject("buttonItem49.Image"), System.Drawing.Image)
        Me.buttonItem49.Name = "buttonItem49"
        Me.buttonItem49.Text = "Save Current Template..."
        '
        'ButtonItem3
        '
        Me.ButtonItem3.Image = CType(resources.GetObject("ButtonItem3.Image"), System.Drawing.Image)
        Me.ButtonItem3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.Text = "Penjualan"
        '
        'ButtonItem15
        '
        Me.ButtonItem15.Image = CType(resources.GetObject("ButtonItem15.Image"), System.Drawing.Image)
        Me.ButtonItem15.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem15.Name = "ButtonItem15"
        Me.ButtonItem15.Text = "Pembelian"
        '
        'ButtonItem16
        '
        Me.ButtonItem16.Image = CType(resources.GetObject("ButtonItem16.Image"), System.Drawing.Image)
        Me.ButtonItem16.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem16.Name = "ButtonItem16"
        Me.ButtonItem16.Text = "Penjualan"
        '
        'ButtonItem17
        '
        Me.ButtonItem17.AutoExpandOnClick = True
        Me.ButtonItem17.Image = CType(resources.GetObject("ButtonItem17.Image"), System.Drawing.Image)
        Me.ButtonItem17.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem17.Name = "ButtonItem17"
        Me.ButtonItem17.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem27, Me.ButtonItem59, Me.ButtonItem61})
        Me.ButtonItem17.Text = "Penjualan"
        '
        'ButtonItem27
        '
        Me.ButtonItem27.Name = "ButtonItem27"
        Me.ButtonItem27.Text = "Payment Type"
        '
        'ButtonItem59
        '
        Me.ButtonItem59.Name = "ButtonItem59"
        Me.ButtonItem59.Text = "Aged Receivables"
        '
        'ButtonItem61
        '
        Me.ButtonItem61.Name = "ButtonItem61"
        Me.ButtonItem61.Text = "Top 10 Items"
        '
        'ButtonItem22
        '
        Me.ButtonItem22.Image = CType(resources.GetObject("ButtonItem22.Image"), System.Drawing.Image)
        Me.ButtonItem22.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem22.Name = "ButtonItem22"
        Me.ButtonItem22.Text = "Customers"
        '
        'ButtonItem35
        '
        Me.ButtonItem35.Image = CType(resources.GetObject("ButtonItem35.Image"), System.Drawing.Image)
        Me.ButtonItem35.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem35.Name = "ButtonItem35"
        Me.ButtonItem35.Text = "Payment"
        '
        'ButtonItem36
        '
        Me.ButtonItem36.Image = CType(resources.GetObject("ButtonItem36.Image"), System.Drawing.Image)
        Me.ButtonItem36.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem36.Name = "ButtonItem36"
        Me.ButtonItem36.Text = "Payment"
        '
        'ButtonItem38
        '
        Me.ButtonItem38.Image = CType(resources.GetObject("ButtonItem38.Image"), System.Drawing.Image)
        Me.ButtonItem38.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem38.Name = "ButtonItem38"
        Me.ButtonItem38.Text = "Taxes"
        '
        'frmMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(814, 405)
        Me.Controls.Add(Me.tabStrip1)
        Me.Controls.Add(Me.ribbonControl1)
        Me.Controls.Add(Me.barStatus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "teria Cash Register v1.0 - Powered by adnetindo.com"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.barStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ribbonControl1.ResumeLayout(False)
        Me.ribbonControl1.PerformLayout()
        Me.ribbonPanel1.ResumeLayout(False)
        Me.RibbonPanel2.ResumeLayout(False)
        Me.RibbonPanel4.ResumeLayout(False)
        Me.ribbonPanel3.ResumeLayout(False)
        Me.RibbonPanel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        labelStatus.Text = FormatDateTime(Now, DateFormat.ShortDate) & " " & FormatDateTime(Now, DateFormat.LongTime)
    End Sub

    Private Sub ButtonItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem4.Click
        frmSales.ShowDialog()
    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        Dim doc1 As frm1SalesReturnList = New frm1SalesReturnList()
        doc1.Text = "Sales Order"
        doc1.MdiParent = Me
        doc1.WindowState = FormWindowState.Maximized
        doc1.Show()
        doc1.Update()
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tabStrip1.MdiForm = Me
    End Sub

    Private Sub ButtonItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem6.Click
        Dim doc1 As frm1PurchaseList = New frm1PurchaseList()
        doc1.Text = "Purchase Order"
        doc1.MdiParent = Me
        doc1.WindowState = FormWindowState.Maximized
        doc1.Show()
        doc1.Update()
    End Sub

    Private Sub ButtonItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem11.Click
        Dim doc1 As frm1PurchaseReturnList = New frm1PurchaseReturnList()
        doc1.Text = "Purchase Return"
        doc1.MdiParent = Me
        doc1.WindowState = FormWindowState.Maximized
        doc1.Show()
        doc1.Update()
    End Sub

    Private Sub ButtonItem64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem64.Click
        Dim doc1 As frmMItems = New frmMItems()
        doc1.Text = "Item"
        doc1.MdiParent = Me
        doc1.WindowState = FormWindowState.Maximized
        doc1.Show()
        doc1.Update()
    End Sub

    Private Sub ButtonItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem30.Click
        Dim doc1 As frmMCategorys = New frmMCategorys()
        doc1.Text = "Category"
        doc1.MdiParent = Me
        doc1.WindowState = FormWindowState.Maximized
        doc1.Show()
        doc1.Update()
    End Sub

    Private Sub ButtonItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem5.Click
        Dim doc1 As frmMCustomers = New frmMCustomers()
        doc1.Text = "Customer"
        doc1.MdiParent = Me
        doc1.WindowState = FormWindowState.Maximized
        doc1.Show()
        doc1.Update()
    End Sub

    Private Sub ButtonItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem9.Click
        Dim doc1 As frmMVendors = New frmMVendors()
        doc1.Text = "Vendor"
        doc1.MdiParent = Me
        doc1.WindowState = FormWindowState.Maximized
        doc1.Show()
        doc1.Update()
    End Sub

    Private Sub ButtonItem65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem65.Click
        Dim doc1 As frmMEmployees = New frmMEmployees()
        doc1.Text = "Employee"
        doc1.MdiParent = Me
        doc1.WindowState = FormWindowState.Maximized
        doc1.Show()
        doc1.Update()
    End Sub

    Private Sub ButtonItem63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem63.Click
        Dim doc1 As frmMVouchers = New frmMVouchers()
        doc1.Text = "Voucher"
        doc1.MdiParent = Me
        doc1.WindowState = FormWindowState.Maximized
        doc1.Show()
        doc1.Update()
    End Sub
End Class
