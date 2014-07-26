<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatpricing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCatpricing))
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.t1 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.t2 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX
        Me.t3 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX
        Me.t4 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX
        Me.t5 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.t0 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.t8 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Bar1 = New DevComponents.DotNetBar.Bar
        Me.cmdSave = New DevComponents.DotNetBar.ButtonItem
        Me.cmdExit = New DevComponents.DotNetBar.ButtonItem
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerColorTint = System.Drawing.Color.White
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Silver
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX1)
        Me.FlowLayoutPanel1.Controls.Add(Me.t1)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX2)
        Me.FlowLayoutPanel1.Controls.Add(Me.t2)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX9)
        Me.FlowLayoutPanel1.Controls.Add(Me.t3)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX8)
        Me.FlowLayoutPanel1.Controls.Add(Me.t4)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX10)
        Me.FlowLayoutPanel1.Controls.Add(Me.t5)
        Me.FlowLayoutPanel1.Controls.Add(Me.t0)
        Me.FlowLayoutPanel1.Controls.Add(Me.t8)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 25)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(443, 144)
        Me.FlowLayoutPanel1.TabIndex = 108
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
        Me.LabelX1.Text = "Cat. ID"
        '
        't1
        '
        Me.t1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.t1.Border.Class = "TextBoxBorder"
        Me.t1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t1.Enabled = False
        Me.t1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t1.ForeColor = System.Drawing.Color.Black
        Me.t1.Location = New System.Drawing.Point(95, 3)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(340, 22)
        Me.t1.TabIndex = 0
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
        Me.LabelX2.Text = "Cat. Name"
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
        Me.t2.TabIndex = 1
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX9.Location = New System.Drawing.Point(3, 59)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(86, 21)
        Me.LabelX9.TabIndex = 123
        Me.LabelX9.Text = "Normal Disc"
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
        Me.t3.TabIndex = 2
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.Location = New System.Drawing.Point(3, 87)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(86, 21)
        Me.LabelX8.TabIndex = 129
        Me.LabelX8.Text = "Member Disc"
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
        Me.t4.TabIndex = 3
        '
        'LabelX10
        '
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX10.Location = New System.Drawing.Point(3, 115)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(86, 21)
        Me.LabelX10.TabIndex = 131
        Me.LabelX10.Text = "Cust. Disc"
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
        Me.t5.TabIndex = 4
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
        Me.t0.Location = New System.Drawing.Point(3, 143)
        Me.t0.Name = "t0"
        Me.t0.Size = New System.Drawing.Size(35, 22)
        Me.t0.TabIndex = 108
        Me.t0.Visible = False
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
        Me.t8.Location = New System.Drawing.Point(44, 143)
        Me.t8.Name = "t8"
        Me.t8.Size = New System.Drawing.Size(35, 22)
        Me.t8.TabIndex = 132
        Me.t8.Visible = False
        '
        'Bar1
        '
        Me.Bar1.AntiAlias = True
        Me.Bar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.cmdSave, Me.cmdExit})
        Me.Bar1.Location = New System.Drawing.Point(0, 0)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(443, 25)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabIndex = 107
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
        'cmdExit
        '
        Me.cmdExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Text = "Exit"
        '
        'frmCatpricing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 169)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Bar1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.Name = "frmCatpricing"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input Data"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents t2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents t0 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents cmdSave As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdExit As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents t1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents t3 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents t4 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents t5 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents t8 As DevComponents.DotNetBar.Controls.TextBoxX
End Class
