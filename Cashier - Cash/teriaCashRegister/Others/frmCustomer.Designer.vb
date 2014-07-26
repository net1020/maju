<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomer))
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.Bar1 = New DevComponents.DotNetBar.Bar
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem
        Me.TextBoxX13 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.TextBoxX14 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.TextBoxX10 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.TextBoxX9 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.TextBoxX8 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.TextBoxX7 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.TextBoxX6 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.TextBoxX5 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.TextBoxX4 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.TextBoxX3 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.TextBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.TextBoxX12 = New DevComponents.DotNetBar.Controls.TextBoxX
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(232, Byte), Integer)))
        '
        'Bar1
        '
        Me.Bar1.AntiAlias = True
        Me.Bar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem1, Me.ButtonItem2, Me.ButtonItem3})
        Me.Bar1.Location = New System.Drawing.Point(5, 1)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(335, 25)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabIndex = 101
        Me.Bar1.TabStop = False
        Me.Bar1.Text = "Bar1"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem1.Image = CType(resources.GetObject("ButtonItem1.Image"), System.Drawing.Image)
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Text = "Save"
        '
        'ButtonItem2
        '
        Me.ButtonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem2.Image = CType(resources.GetObject("ButtonItem2.Image"), System.Drawing.Image)
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.Text = "Save && New"
        '
        'ButtonItem3
        '
        Me.ButtonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem3.Image = CType(resources.GetObject("ButtonItem3.Image"), System.Drawing.Image)
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.Text = "Exit"
        '
        'TextBoxX13
        '
        Me.TextBoxX13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.TextBoxX13.Border.BackColor = System.Drawing.Color.Transparent
        Me.TextBoxX13.Border.BackColor2 = System.Drawing.Color.Transparent
        Me.TextBoxX13.Border.BackColorGradientAngle = 5
        Me.TextBoxX13.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX13.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX13.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX13.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX13.Border.Class = "TextBoxBorder"
        Me.TextBoxX13.Border.CornerDiameter = 3
        Me.TextBoxX13.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TextBoxX13.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxX13.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX13.Location = New System.Drawing.Point(3, 366)
        Me.TextBoxX13.Name = "TextBoxX13"
        Me.TextBoxX13.Size = New System.Drawing.Size(303, 27)
        Me.TextBoxX13.TabIndex = 129
        Me.TextBoxX13.WatermarkImage = CType(resources.GetObject("TextBoxX13.WatermarkImage"), System.Drawing.Image)
        Me.TextBoxX13.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TextBoxX13.WatermarkText = "Account"
        '
        'TextBoxX14
        '
        Me.TextBoxX14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.TextBoxX14.Border.BackColor = System.Drawing.Color.Transparent
        Me.TextBoxX14.Border.BackColor2 = System.Drawing.Color.Transparent
        Me.TextBoxX14.Border.BackColorGradientAngle = 5
        Me.TextBoxX14.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX14.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX14.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX14.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX14.Border.Class = "TextBoxBorder"
        Me.TextBoxX14.Border.CornerDiameter = 3
        Me.TextBoxX14.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TextBoxX14.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxX14.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX14.Location = New System.Drawing.Point(3, 333)
        Me.TextBoxX14.Name = "TextBoxX14"
        Me.TextBoxX14.Size = New System.Drawing.Size(303, 27)
        Me.TextBoxX14.TabIndex = 128
        Me.TextBoxX14.WatermarkImage = CType(resources.GetObject("TextBoxX14.WatermarkImage"), System.Drawing.Image)
        Me.TextBoxX14.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TextBoxX14.WatermarkText = "Comments"
        '
        'TextBoxX10
        '
        Me.TextBoxX10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.TextBoxX10.Border.BackColor = System.Drawing.Color.Transparent
        Me.TextBoxX10.Border.BackColor2 = System.Drawing.Color.Transparent
        Me.TextBoxX10.Border.BackColorGradientAngle = 5
        Me.TextBoxX10.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX10.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX10.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX10.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX10.Border.Class = "TextBoxBorder"
        Me.TextBoxX10.Border.CornerDiameter = 3
        Me.TextBoxX10.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TextBoxX10.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxX10.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX10.Location = New System.Drawing.Point(3, 300)
        Me.TextBoxX10.Name = "TextBoxX10"
        Me.TextBoxX10.Size = New System.Drawing.Size(303, 27)
        Me.TextBoxX10.TabIndex = 127
        Me.TextBoxX10.WatermarkImage = CType(resources.GetObject("TextBoxX10.WatermarkImage"), System.Drawing.Image)
        Me.TextBoxX10.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TextBoxX10.WatermarkText = "Country"
        '
        'TextBoxX9
        '
        Me.TextBoxX9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.TextBoxX9.Border.BackColor = System.Drawing.Color.Transparent
        Me.TextBoxX9.Border.BackColor2 = System.Drawing.Color.Transparent
        Me.TextBoxX9.Border.BackColorGradientAngle = 5
        Me.TextBoxX9.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX9.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX9.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX9.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX9.Border.Class = "TextBoxBorder"
        Me.TextBoxX9.Border.CornerDiameter = 3
        Me.TextBoxX9.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TextBoxX9.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxX9.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX9.Location = New System.Drawing.Point(3, 267)
        Me.TextBoxX9.Name = "TextBoxX9"
        Me.TextBoxX9.Size = New System.Drawing.Size(303, 27)
        Me.TextBoxX9.TabIndex = 126
        Me.TextBoxX9.WatermarkImage = CType(resources.GetObject("TextBoxX9.WatermarkImage"), System.Drawing.Image)
        Me.TextBoxX9.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TextBoxX9.WatermarkText = "Zip"
        '
        'TextBoxX8
        '
        Me.TextBoxX8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.TextBoxX8.Border.BackColor = System.Drawing.Color.Transparent
        Me.TextBoxX8.Border.BackColor2 = System.Drawing.Color.Transparent
        Me.TextBoxX8.Border.BackColorGradientAngle = 5
        Me.TextBoxX8.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX8.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX8.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX8.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX8.Border.Class = "TextBoxBorder"
        Me.TextBoxX8.Border.CornerDiameter = 3
        Me.TextBoxX8.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TextBoxX8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxX8.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX8.Location = New System.Drawing.Point(3, 234)
        Me.TextBoxX8.Name = "TextBoxX8"
        Me.TextBoxX8.Size = New System.Drawing.Size(303, 27)
        Me.TextBoxX8.TabIndex = 125
        Me.TextBoxX8.WatermarkImage = CType(resources.GetObject("TextBoxX8.WatermarkImage"), System.Drawing.Image)
        Me.TextBoxX8.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TextBoxX8.WatermarkText = "State"
        '
        'TextBoxX7
        '
        Me.TextBoxX7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.TextBoxX7.Border.BackColor = System.Drawing.Color.Transparent
        Me.TextBoxX7.Border.BackColor2 = System.Drawing.Color.Transparent
        Me.TextBoxX7.Border.BackColorGradientAngle = 5
        Me.TextBoxX7.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX7.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX7.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX7.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX7.Border.Class = "TextBoxBorder"
        Me.TextBoxX7.Border.CornerDiameter = 3
        Me.TextBoxX7.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TextBoxX7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxX7.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX7.Location = New System.Drawing.Point(3, 201)
        Me.TextBoxX7.Name = "TextBoxX7"
        Me.TextBoxX7.Size = New System.Drawing.Size(303, 27)
        Me.TextBoxX7.TabIndex = 118
        Me.TextBoxX7.WatermarkImage = CType(resources.GetObject("TextBoxX7.WatermarkImage"), System.Drawing.Image)
        Me.TextBoxX7.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TextBoxX7.WatermarkText = "City"
        '
        'TextBoxX6
        '
        Me.TextBoxX6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.TextBoxX6.Border.BackColor = System.Drawing.Color.Transparent
        Me.TextBoxX6.Border.BackColor2 = System.Drawing.Color.Transparent
        Me.TextBoxX6.Border.BackColorGradientAngle = 5
        Me.TextBoxX6.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX6.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX6.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX6.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX6.Border.Class = "TextBoxBorder"
        Me.TextBoxX6.Border.CornerDiameter = 3
        Me.TextBoxX6.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TextBoxX6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxX6.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX6.Location = New System.Drawing.Point(3, 168)
        Me.TextBoxX6.Name = "TextBoxX6"
        Me.TextBoxX6.Size = New System.Drawing.Size(303, 27)
        Me.TextBoxX6.TabIndex = 117
        Me.TextBoxX6.WatermarkImage = CType(resources.GetObject("TextBoxX6.WatermarkImage"), System.Drawing.Image)
        Me.TextBoxX6.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TextBoxX6.WatermarkText = "Address 2"
        '
        'TextBoxX5
        '
        Me.TextBoxX5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.TextBoxX5.Border.BackColor = System.Drawing.Color.Transparent
        Me.TextBoxX5.Border.BackColor2 = System.Drawing.Color.Transparent
        Me.TextBoxX5.Border.BackColorGradientAngle = 5
        Me.TextBoxX5.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX5.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX5.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX5.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX5.Border.Class = "TextBoxBorder"
        Me.TextBoxX5.Border.CornerDiameter = 3
        Me.TextBoxX5.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TextBoxX5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxX5.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX5.Location = New System.Drawing.Point(3, 135)
        Me.TextBoxX5.Name = "TextBoxX5"
        Me.TextBoxX5.Size = New System.Drawing.Size(303, 27)
        Me.TextBoxX5.TabIndex = 116
        Me.TextBoxX5.WatermarkImage = CType(resources.GetObject("TextBoxX5.WatermarkImage"), System.Drawing.Image)
        Me.TextBoxX5.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TextBoxX5.WatermarkText = "Address 1"
        '
        'TextBoxX4
        '
        Me.TextBoxX4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.TextBoxX4.Border.BackColor = System.Drawing.Color.Transparent
        Me.TextBoxX4.Border.BackColor2 = System.Drawing.Color.Transparent
        Me.TextBoxX4.Border.BackColorGradientAngle = 5
        Me.TextBoxX4.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX4.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX4.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX4.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX4.Border.Class = "TextBoxBorder"
        Me.TextBoxX4.Border.CornerDiameter = 3
        Me.TextBoxX4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TextBoxX4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxX4.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX4.Location = New System.Drawing.Point(3, 102)
        Me.TextBoxX4.Name = "TextBoxX4"
        Me.TextBoxX4.Size = New System.Drawing.Size(303, 27)
        Me.TextBoxX4.TabIndex = 115
        Me.TextBoxX4.WatermarkImage = CType(resources.GetObject("TextBoxX4.WatermarkImage"), System.Drawing.Image)
        Me.TextBoxX4.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TextBoxX4.WatermarkText = "Phone"
        '
        'TextBoxX3
        '
        Me.TextBoxX3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.TextBoxX3.Border.BackColor = System.Drawing.Color.Transparent
        Me.TextBoxX3.Border.BackColor2 = System.Drawing.Color.Transparent
        Me.TextBoxX3.Border.BackColorGradientAngle = 5
        Me.TextBoxX3.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX3.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX3.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX3.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX3.Border.Class = "TextBoxBorder"
        Me.TextBoxX3.Border.CornerDiameter = 3
        Me.TextBoxX3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TextBoxX3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxX3.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX3.Location = New System.Drawing.Point(3, 69)
        Me.TextBoxX3.Name = "TextBoxX3"
        Me.TextBoxX3.Size = New System.Drawing.Size(303, 27)
        Me.TextBoxX3.TabIndex = 114
        Me.TextBoxX3.WatermarkImage = CType(resources.GetObject("TextBoxX3.WatermarkImage"), System.Drawing.Image)
        Me.TextBoxX3.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TextBoxX3.WatermarkText = "Email"
        '
        'TextBoxX2
        '
        Me.TextBoxX2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.TextBoxX2.Border.BackColor = System.Drawing.Color.Transparent
        Me.TextBoxX2.Border.BackColor2 = System.Drawing.Color.Transparent
        Me.TextBoxX2.Border.BackColorGradientAngle = 5
        Me.TextBoxX2.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX2.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX2.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX2.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX2.Border.Class = "TextBoxBorder"
        Me.TextBoxX2.Border.CornerDiameter = 3
        Me.TextBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TextBoxX2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxX2.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX2.Location = New System.Drawing.Point(3, 36)
        Me.TextBoxX2.Name = "TextBoxX2"
        Me.TextBoxX2.Size = New System.Drawing.Size(303, 27)
        Me.TextBoxX2.TabIndex = 113
        Me.TextBoxX2.WatermarkImage = CType(resources.GetObject("TextBoxX2.WatermarkImage"), System.Drawing.Image)
        Me.TextBoxX2.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TextBoxX2.WatermarkText = "Last Name"
        '
        'TextBoxX1
        '
        Me.TextBoxX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX1.Border.BackColor = System.Drawing.Color.Transparent
        Me.TextBoxX1.Border.BackColor2 = System.Drawing.Color.Transparent
        Me.TextBoxX1.Border.BackColorGradientAngle = 5
        Me.TextBoxX1.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX1.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX1.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX1.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX1.Border.Class = "TextBoxBorder"
        Me.TextBoxX1.Border.CornerDiameter = 3
        Me.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TextBoxX1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxX1.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX1.Location = New System.Drawing.Point(3, 3)
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.Size = New System.Drawing.Size(303, 27)
        Me.TextBoxX1.TabIndex = 112
        Me.TextBoxX1.WatermarkImage = CType(resources.GetObject("TextBoxX1.WatermarkImage"), System.Drawing.Image)
        Me.TextBoxX1.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TextBoxX1.WatermarkText = "First Name"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBoxX1)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBoxX2)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBoxX3)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBoxX4)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBoxX5)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBoxX6)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBoxX7)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBoxX8)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBoxX9)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBoxX10)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBoxX14)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBoxX13)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBoxX12)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(5, 32)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(311, 432)
        Me.FlowLayoutPanel1.TabIndex = 125
        '
        'TextBoxX12
        '
        Me.TextBoxX12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.TextBoxX12.Border.BackColor = System.Drawing.Color.Transparent
        Me.TextBoxX12.Border.BackColor2 = System.Drawing.Color.Transparent
        Me.TextBoxX12.Border.BackColorGradientAngle = 5
        Me.TextBoxX12.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX12.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX12.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX12.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX12.Border.Class = "TextBoxBorder"
        Me.TextBoxX12.Border.CornerDiameter = 3
        Me.TextBoxX12.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TextBoxX12.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxX12.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX12.Location = New System.Drawing.Point(3, 399)
        Me.TextBoxX12.Name = "TextBoxX12"
        Me.TextBoxX12.Size = New System.Drawing.Size(303, 27)
        Me.TextBoxX12.TabIndex = 131
        Me.TextBoxX12.WatermarkImage = CType(resources.GetObject("TextBoxX12.WatermarkImage"), System.Drawing.Image)
        Me.TextBoxX12.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TextBoxX12.WatermarkText = "Taxable"
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(345, 553)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Bar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Name = "frmCustomer"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer"
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents TextBoxX13 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextBoxX14 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextBoxX10 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextBoxX9 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextBoxX8 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextBoxX7 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextBoxX6 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextBoxX5 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextBoxX4 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextBoxX3 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents TextBoxX12 As DevComponents.DotNetBar.Controls.TextBoxX
End Class
