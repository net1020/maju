<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSales))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblTime = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblQty = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.lblPrice = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.grid1 = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.Button1 = New System.Windows.Forms.Button
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.port1 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblSubTotal = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.ribbonMenu = New DevComponents.DotNetBar.RibbonPanel
        Me.RibbonBar3 = New DevComponents.DotNetBar.RibbonBar
        Me.cmdf1 = New DevComponents.DotNetBar.ButtonItem
        Me.cmdf2 = New DevComponents.DotNetBar.ButtonItem
        Me.cmdf3 = New DevComponents.DotNetBar.ButtonItem
        Me.cmdf4 = New DevComponents.DotNetBar.ButtonItem
        Me.cmdf5 = New DevComponents.DotNetBar.ButtonItem
        Me.cmdf6 = New DevComponents.DotNetBar.ButtonItem
        Me.cmdf7 = New DevComponents.DotNetBar.ButtonItem
        Me.cmdf8 = New DevComponents.DotNetBar.ButtonItem
        Me.cmdf9 = New DevComponents.DotNetBar.ButtonItem
        Me.cmdf10 = New DevComponents.DotNetBar.ButtonItem
        Me.cmdf11 = New DevComponents.DotNetBar.ButtonItem
        Me.cmdf12 = New DevComponents.DotNetBar.ButtonItem
        Me.cmdUser = New DevComponents.DotNetBar.ButtonItem
        Me.cmdPrint = New DevComponents.DotNetBar.ButtonItem
        Me.cmbMember = New DevComponents.DotNetBar.ButtonItem
        Me.cmbSales = New DevComponents.DotNetBar.ButtonItem
        Me.cmdOnline = New DevComponents.DotNetBar.ButtonItem
        Me.cmdOffline = New DevComponents.DotNetBar.ButtonItem
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.timerItem = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.ButtonItem15 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem14 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem13 = New DevComponents.DotNetBar.ButtonItem
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.ribbonMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1024, 39)
        Me.Panel1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(601, 39)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "TOKO MADJU - SUPERMARKET BAHAN BANGUNAN"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblTime.Location = New System.Drawing.Point(588, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(436, 39)
        Me.lblTime.TabIndex = 0
        Me.lblTime.Text = "Selasa, 23-Feb-2013 12:20:12"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.lblQty)
        Me.Panel2.Controls.Add(Me.lblName)
        Me.Panel2.Controls.Add(Me.lblPrice)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel2.Location = New System.Drawing.Point(0, 39)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1024, 99)
        Me.Panel2.TabIndex = 1
        '
        'lblQty
        '
        Me.lblQty.BackColor = System.Drawing.Color.Transparent
        Me.lblQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQty.ForeColor = System.Drawing.Color.Gray
        Me.lblQty.Location = New System.Drawing.Point(0, 52)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(654, 47)
        Me.lblQty.TabIndex = 3
        Me.lblQty.Text = "1pc"
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Gray
        Me.lblName.Location = New System.Drawing.Point(0, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(654, 52)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Cat Nippon Dulux - 12D - Warna Kuning"
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 42.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblPrice.Location = New System.Drawing.Point(654, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(370, 99)
        Me.lblPrice.TabIndex = 1
        Me.lblPrice.Text = "100,000"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.grid1)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 138)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1024, 365)
        Me.Panel3.TabIndex = 2
        '
        'grid1
        '
        Me.grid1.AllowUserToResizeColumns = False
        Me.grid1.AllowUserToResizeRows = False
        Me.grid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column3, Me.Column1, Me.Column7, Me.Column8, Me.Column5, Me.Column9, Me.Column6, Me.Column2})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid1.DefaultCellStyle = DataGridViewCellStyle7
        Me.grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid1.EnableHeadersVisualStyles = False
        Me.grid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grid1.HighlightSelectedColumnHeaders = False
        Me.grid1.Location = New System.Drawing.Point(0, 0)
        Me.grid1.Margin = New System.Windows.Forms.Padding(6)
        Me.grid1.Name = "grid1"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.grid1.RowHeadersVisible = False
        Me.grid1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid1.Size = New System.Drawing.Size(1024, 240)
        Me.grid1.TabIndex = 81
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(706, 110)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 41)
        Me.Button1.TabIndex = 82
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.port1)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.lblSubTotal)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 240)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1024, 50)
        Me.Panel5.TabIndex = 80
        '
        'port1
        '
        Me.port1.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.port1.Border.Class = "TextBoxBorder"
        Me.port1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.port1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.port1.Location = New System.Drawing.Point(459, 13)
        Me.port1.Name = "port1"
        Me.port1.Size = New System.Drawing.Size(78, 20)
        Me.port1.TabIndex = 6
        Me.port1.Visible = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(541, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(212, 50)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "SUB TOTAL :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTotal.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSubTotal.Location = New System.Drawing.Point(753, 0)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(271, 50)
        Me.lblSubTotal.TabIndex = 4
        Me.lblSubTotal.Text = "100,000,-"
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.ribbonMenu)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 290)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1024, 75)
        Me.Panel4.TabIndex = 79
        '
        'ribbonMenu
        '
        Me.ribbonMenu.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ribbonMenu.Controls.Add(Me.RibbonBar3)
        Me.ribbonMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ribbonMenu.Location = New System.Drawing.Point(0, 0)
        Me.ribbonMenu.Name = "ribbonMenu"
        Me.ribbonMenu.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.ribbonMenu.Size = New System.Drawing.Size(1024, 75)
        '
        '
        '
        Me.ribbonMenu.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribbonMenu.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribbonMenu.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ribbonMenu.TabIndex = 5
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
        Me.RibbonBar3.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar3.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right
        Me.RibbonBar3.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.cmdf1, Me.cmdf2, Me.cmdf3, Me.cmdf4, Me.cmdf5, Me.cmdf6, Me.cmdf7, Me.cmdf8, Me.cmdf9, Me.cmdf10, Me.cmdf11, Me.cmdf12, Me.cmdUser, Me.cmbMember, Me.cmbSales, Me.cmdOnline, Me.cmdOffline})
        Me.RibbonBar3.Location = New System.Drawing.Point(3, 0)
        Me.RibbonBar3.Name = "RibbonBar3"
        Me.RibbonBar3.Size = New System.Drawing.Size(1009, 72)
        Me.RibbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar3.TabIndex = 5
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
        'cmdf1
        '
        Me.cmdf1.FixedSize = New System.Drawing.Size(60, 67)
        Me.cmdf1.Image = CType(resources.GetObject("cmdf1.Image"), System.Drawing.Image)
        Me.cmdf1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdf1.Name = "cmdf1"
        Me.cmdf1.Text = "(F1)               New Sales    "
        '
        'cmdf2
        '
        Me.cmdf2.FixedSize = New System.Drawing.Size(50, 67)
        Me.cmdf2.Image = CType(resources.GetObject("cmdf2.Image"), System.Drawing.Image)
        Me.cmdf2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdf2.Name = "cmdf2"
        Me.cmdf2.Text = "(F2)           PLU"
        '
        'cmdf3
        '
        Me.cmdf3.FixedSize = New System.Drawing.Size(50, 67)
        Me.cmdf3.Image = CType(resources.GetObject("cmdf3.Image"), System.Drawing.Image)
        Me.cmdf3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdf3.Name = "cmdf3"
        Me.cmdf3.Text = "(F3)            Qty"
        '
        'cmdf4
        '
        Me.cmdf4.FixedSize = New System.Drawing.Size(71, 67)
        Me.cmdf4.Image = CType(resources.GetObject("cmdf4.Image"), System.Drawing.Image)
        Me.cmdf4.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdf4.Name = "cmdf4"
        Me.cmdf4.Text = "(F4) Pembayaran"
        '
        'cmdf5
        '
        Me.cmdf5.FixedSize = New System.Drawing.Size(55, 67)
        Me.cmdf5.Image = CType(resources.GetObject("cmdf5.Image"), System.Drawing.Image)
        Me.cmdf5.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdf5.Name = "cmdf5"
        Me.cmdf5.Text = "(F5)           Search"
        '
        'cmdf6
        '
        Me.cmdf6.FixedSize = New System.Drawing.Size(55, 67)
        Me.cmdf6.Image = CType(resources.GetObject("cmdf6.Image"), System.Drawing.Image)
        Me.cmdf6.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdf6.Name = "cmdf6"
        Me.cmdf6.Text = "(F6)          Pending"
        '
        'cmdf7
        '
        Me.cmdf7.FixedSize = New System.Drawing.Size(55, 67)
        Me.cmdf7.Image = CType(resources.GetObject("cmdf7.Image"), System.Drawing.Image)
        Me.cmdf7.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdf7.Name = "cmdf7"
        Me.cmdf7.Text = "(F7)            Recall"
        '
        'cmdf8
        '
        Me.cmdf8.FixedSize = New System.Drawing.Size(55, 67)
        Me.cmdf8.Image = CType(resources.GetObject("cmdf8.Image"), System.Drawing.Image)
        Me.cmdf8.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdf8.Name = "cmdf8"
        Me.cmdf8.Text = "(F8)         Salesman"
        '
        'cmdf9
        '
        Me.cmdf9.FixedSize = New System.Drawing.Size(71, 67)
        Me.cmdf9.Image = CType(resources.GetObject("cmdf9.Image"), System.Drawing.Image)
        Me.cmdf9.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdf9.Name = "cmdf9"
        Me.cmdf9.Text = "(F9) Membership"
        '
        'cmdf10
        '
        Me.cmdf10.FixedSize = New System.Drawing.Size(55, 67)
        Me.cmdf10.Image = CType(resources.GetObject("cmdf10.Image"), System.Drawing.Image)
        Me.cmdf10.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdf10.Name = "cmdf10"
        Me.cmdf10.Text = "(F10)           Sign Off"
        '
        'cmdf11
        '
        Me.cmdf11.FixedSize = New System.Drawing.Size(50, 67)
        Me.cmdf11.Image = CType(resources.GetObject("cmdf11.Image"), System.Drawing.Image)
        Me.cmdf11.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdf11.Name = "cmdf11"
        Me.cmdf11.Text = "(F11)           Void"
        '
        'cmdf12
        '
        Me.cmdf12.FixedSize = New System.Drawing.Size(70, 67)
        Me.cmdf12.Image = CType(resources.GetObject("cmdf12.Image"), System.Drawing.Image)
        Me.cmdf12.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdf12.Name = "cmdf12"
        Me.cmdf12.Text = "(F12)           Open Drawer"
        '
        'cmdUser
        '
        Me.cmdUser.AutoExpandOnClick = True
        Me.cmdUser.FixedSize = New System.Drawing.Size(75, 70)
        Me.cmdUser.Image = CType(resources.GetObject("cmdUser.Image"), System.Drawing.Image)
        Me.cmdUser.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdUser.Name = "cmdUser"
        Me.cmdUser.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.cmdPrint})
        Me.cmdUser.SubItemsExpandWidth = 14
        '
        'cmdPrint
        '
        Me.cmdPrint.FixedSize = New System.Drawing.Size(85, 67)
        Me.cmdPrint.Image = Global.TokoMadju.My.Resources.Resources.print
        Me.cmdPrint.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Text = "Reprint Receipt"
        '
        'cmbMember
        '
        Me.cmbMember.FixedSize = New System.Drawing.Size(75, 70)
        Me.cmbMember.Image = CType(resources.GetObject("cmbMember.Image"), System.Drawing.Image)
        Me.cmbMember.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmbMember.Name = "cmbMember"
        Me.cmbMember.SubItemsExpandWidth = 14
        '
        'cmbSales
        '
        Me.cmbSales.FixedSize = New System.Drawing.Size(75, 70)
        Me.cmbSales.Image = CType(resources.GetObject("cmbSales.Image"), System.Drawing.Image)
        Me.cmbSales.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmbSales.Name = "cmbSales"
        Me.cmbSales.SubItemsExpandWidth = 14
        '
        'cmdOnline
        '
        Me.cmdOnline.FixedSize = New System.Drawing.Size(60, 70)
        Me.cmdOnline.Image = Global.TokoMadju.My.Resources.Resources.online
        Me.cmdOnline.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdOnline.Name = "cmdOnline"
        Me.cmdOnline.SubItemsExpandWidth = 14
        Me.cmdOnline.Text = "Server Online"
        '
        'cmdOffline
        '
        Me.cmdOffline.FixedSize = New System.Drawing.Size(60, 70)
        Me.cmdOffline.Image = Global.TokoMadju.My.Resources.Resources.offlineb
        Me.cmdOffline.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.cmdOffline.Name = "cmdOffline"
        Me.cmdOffline.SubItemsExpandWidth = 14
        Me.cmdOffline.Text = "Server Offine"
        Me.cmdOffline.Visible = False
        '
        'timerItem
        '
        Me.timerItem.Interval = 200
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "f1.png")
        Me.ImageList1.Images.SetKeyName(1, "f2.png")
        Me.ImageList1.Images.SetKeyName(2, "f3.png")
        Me.ImageList1.Images.SetKeyName(3, "f4.png")
        Me.ImageList1.Images.SetKeyName(4, "f5.png")
        Me.ImageList1.Images.SetKeyName(5, "f6.png")
        Me.ImageList1.Images.SetKeyName(6, "f7.png")
        Me.ImageList1.Images.SetKeyName(7, "f8.png")
        Me.ImageList1.Images.SetKeyName(8, "f9.png")
        Me.ImageList1.Images.SetKeyName(9, "f10.png")
        Me.ImageList1.Images.SetKeyName(10, "f11.png")
        Me.ImageList1.Images.SetKeyName(11, "f12.png")
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Silver
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(232, Byte), Integer)))
        '
        'ButtonItem15
        '
        Me.ButtonItem15.Image = CType(resources.GetObject("ButtonItem15.Image"), System.Drawing.Image)
        Me.ButtonItem15.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem15.Name = "ButtonItem15"
        Me.ButtonItem15.Text = "ButtonItem13 23423423423"
        '
        'ButtonItem14
        '
        Me.ButtonItem14.FixedSize = New System.Drawing.Size(125, 70)
        Me.ButtonItem14.Image = CType(resources.GetObject("ButtonItem14.Image"), System.Drawing.Image)
        Me.ButtonItem14.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem14.Name = "ButtonItem14"
        Me.ButtonItem14.SubItemsExpandWidth = 14
        Me.ButtonItem14.Text = "Sales : Joseph"
        '
        'ButtonItem13
        '
        Me.ButtonItem13.FixedSize = New System.Drawing.Size(125, 70)
        Me.ButtonItem13.Image = CType(resources.GetObject("ButtonItem13.Image"), System.Drawing.Image)
        Me.ButtonItem13.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem13.Name = "ButtonItem13"
        Me.ButtonItem13.SubItemsExpandWidth = 14
        Me.ButtonItem13.Text = "Member : Adi Cipta"
        '
        'Column4
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column4.HeaderText = "No"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 35
        '
        'Column3
        '
        Me.Column3.HeaderText = "Kode Barang"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Nama Barang"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column7
        '
        '
        '
        '
        Me.Column7.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.Column7.BackgroundStyle.Class = "DataGridViewNumericBorder"
        Me.Column7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Column7.BackgroundStyle.TextColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column7.HeaderText = "Qty"
        Me.Column7.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center
        Me.Column7.MaxValue = 10000
        Me.Column7.MinValue = 1
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 65
        '
        'Column8
        '
        Me.Column8.HeaderText = "Unit"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 65
        '
        'Column5
        '
        '
        '
        '
        Me.Column5.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.Column5.BackgroundStyle.Class = "DataGridViewNumericBorder"
        Me.Column5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Column5.BackgroundStyle.TextColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column5.DisplayFormat = "#,###"
        Me.Column5.HeaderText = "Harga"
        Me.Column5.Increment = 1
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 90
        '
        'Column9
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column9.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column9.HeaderText = "Disc %"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column9.Width = 75
        '
        'Column6
        '
        '
        '
        '
        Me.Column6.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.Column6.BackgroundStyle.Class = "DataGridViewNumericBorder"
        Me.Column6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Column6.BackgroundStyle.TextColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column6.DisplayFormat = "#,###"
        Me.Column6.HeaderText = "Total"
        Me.Column6.Increment = 1
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Keterangan"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        '
        'frmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1024, 503)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSales"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Penjualan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ribbonMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ButtonItem15 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents grid1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ribbonMenu As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents RibbonBar3 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents cmdf1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdf2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdf3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdf4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdf5 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdf6 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdf7 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdf8 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdf9 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdf10 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdf11 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdf12 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem14 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem13 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents timerItem As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents cmdUser As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmbMember As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmbSales As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents cmdOnline As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdOffline As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents cmdPrint As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents port1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
