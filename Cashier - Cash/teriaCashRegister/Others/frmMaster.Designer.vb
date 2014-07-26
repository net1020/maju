<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaster
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.ItemPanel1 = New DevComponents.DotNetBar.ItemPanel
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.SlidePanel1 = New DevComponents.DotNetBar.Controls.SlidePanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TextBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.TextBoxX3 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.ToolStrip6 = New System.Windows.Forms.ToolStrip
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.Bar1 = New DevComponents.DotNetBar.Bar
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem
        Me.ItemPanel1.SuspendLayout()
        Me.SlidePanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip6.SuspendLayout()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(2, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contact Information"
        '
        'ItemPanel1
        '
        Me.ItemPanel1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ItemPanel1.BackgroundStyle.Class = "ItemPanel"
        Me.ItemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemPanel1.ContainerControlProcessDialogKey = True
        Me.ItemPanel1.Controls.Add(Me.Button3)
        Me.ItemPanel1.Controls.Add(Me.Button2)
        Me.ItemPanel1.Controls.Add(Me.Button1)
        Me.ItemPanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemPanel1.Location = New System.Drawing.Point(5, 63)
        Me.ItemPanel1.Name = "ItemPanel1"
        Me.ItemPanel1.Size = New System.Drawing.Size(329, 165)
        Me.ItemPanel1.TabIndex = 2
        Me.ItemPanel1.Text = "ItemPanel1"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(99, 68)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(174, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(99, 120)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(174, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(99, 97)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(174, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SlidePanel1
        '
        Me.SlidePanel1.Controls.Add(Me.Panel1)
        Me.SlidePanel1.Location = New System.Drawing.Point(5, 234)
        Me.SlidePanel1.Name = "SlidePanel1"
        Me.SlidePanel1.Size = New System.Drawing.Size(329, 148)
        Me.SlidePanel1.SlideOutActiveButtonSize = New System.Drawing.Size(1, 1)
        Me.SlidePanel1.SlideOutButtonSize = New System.Drawing.Size(1, 1)
        Me.SlidePanel1.SlideSide = DevComponents.DotNetBar.Controls.eSlideSide.Top
        Me.SlidePanel1.TabIndex = 6
        Me.SlidePanel1.Text = "SlidePanel1"
        Me.SlidePanel1.UsesBlockingAnimation = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBoxX2)
        Me.Panel1.Controls.Add(Me.TextBoxX1)
        Me.Panel1.Controls.Add(Me.TextBoxX3)
        Me.Panel1.Controls.Add(Me.LabelX2)
        Me.Panel1.Controls.Add(Me.LabelX1)
        Me.Panel1.Location = New System.Drawing.Point(0, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(326, 138)
        Me.Panel1.TabIndex = 7
        '
        'TextBoxX2
        '
        Me.TextBoxX2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX2.Border.BackColor = System.Drawing.Color.Transparent
        Me.TextBoxX2.Border.BackColor2 = System.Drawing.Color.Transparent
        Me.TextBoxX2.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX2.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX2.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX2.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX2.Border.Class = "TextBoxBorder"
        Me.TextBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TextBoxX2.Border.CornerTypeBottomLeft = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX2.Border.CornerTypeBottomRight = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX2.Border.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX2.Border.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxX2.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX2.Location = New System.Drawing.Point(0, 50)
        Me.TextBoxX2.Name = "TextBoxX2"
        Me.TextBoxX2.Size = New System.Drawing.Size(326, 30)
        Me.TextBoxX2.TabIndex = 14
        Me.TextBoxX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBoxX2.WatermarkText = "Enter Company Name"
        '
        'TextBoxX1
        '
        Me.TextBoxX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX1.Border.BackColor = System.Drawing.Color.Transparent
        Me.TextBoxX1.Border.BackColor2 = System.Drawing.Color.Transparent
        Me.TextBoxX1.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX1.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX1.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX1.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX1.Border.Class = "TextBoxBorder"
        Me.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TextBoxX1.Border.CornerTypeBottomLeft = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX1.Border.CornerTypeBottomRight = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX1.Border.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX1.Border.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxX1.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX1.Location = New System.Drawing.Point(0, 26)
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.Size = New System.Drawing.Size(326, 30)
        Me.TextBoxX1.TabIndex = 13
        Me.TextBoxX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBoxX1.WatermarkText = "Enter Company Name"
        '
        'TextBoxX3
        '
        Me.TextBoxX3.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX3.Border.BackColor = System.Drawing.Color.Transparent
        Me.TextBoxX3.Border.BackColor2 = System.Drawing.Color.Transparent
        Me.TextBoxX3.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX3.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX3.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX3.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TextBoxX3.Border.Class = "TextBoxBorder"
        Me.TextBoxX3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TextBoxX3.Border.CornerTypeBottomLeft = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX3.Border.CornerTypeBottomRight = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX3.Border.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX3.Border.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxX3.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX3.Location = New System.Drawing.Point(0, 0)
        Me.TextBoxX3.Name = "TextBoxX3"
        Me.TextBoxX3.Size = New System.Drawing.Size(326, 30)
        Me.TextBoxX3.TabIndex = 12
        Me.TextBoxX3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBoxX3.WatermarkText = "Enter Company Name"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(8, 6)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(132, 20)
        Me.LabelX2.TabIndex = 7
        Me.LabelX2.Text = "Company Name"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(9, 35)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 21)
        Me.LabelX1.TabIndex = 6
        Me.LabelX1.Text = "LabelX1"
        '
        'ToolStrip6
        '
        Me.ToolStrip6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip6.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1})
        Me.ToolStrip6.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip6.Name = "ToolStrip6"
        Me.ToolStrip6.Size = New System.Drawing.Size(335, 25)
        Me.ToolStrip6.TabIndex = 85
        Me.ToolStrip6.Text = "ToolStrip6"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(300, 25)
        '
        'Bar1
        '
        Me.Bar1.AntiAlias = True
        Me.Bar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem1})
        Me.Bar1.Location = New System.Drawing.Point(156, 34)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(153, 25)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabIndex = 86
        Me.Bar1.TabStop = False
        Me.Bar1.Text = "Bar1"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Text = "ButtonItem1"
        '
        'frmMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(335, 435)
        Me.Controls.Add(Me.Bar1)
        Me.Controls.Add(Me.ToolStrip6)
        Me.Controls.Add(Me.SlidePanel1)
        Me.Controls.Add(Me.ItemPanel1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMaster"
        Me.Text = "Customer"
        Me.ItemPanel1.ResumeLayout(False)
        Me.SlidePanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ToolStrip6.ResumeLayout(False)
        Me.ToolStrip6.PerformLayout()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ItemPanel1 As DevComponents.DotNetBar.ItemPanel
    Friend WithEvents SlidePanel1 As DevComponents.DotNetBar.Controls.SlidePanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ToolStrip6 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents TextBoxX3 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
End Class
