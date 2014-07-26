<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportSales1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportSales1))
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.ToolStrip5 = New System.Windows.Forms.ToolStrip
        Me.cmdView = New System.Windows.Forms.ToolStripButton
        Me.cmbPrinters = New System.Windows.Forms.ToolStripComboBox
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.t1 = New System.Windows.Forms.DateTimePicker
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.t2 = New System.Windows.Forms.DateTimePicker
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.t3 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.ToolStrip5.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerColorTint = System.Drawing.Color.White
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Silver
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
        '
        'ToolStrip5
        '
        Me.ToolStrip5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdView, Me.cmbPrinters, Me.cmdPrint})
        Me.ToolStrip5.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip5.Name = "ToolStrip5"
        Me.ToolStrip5.Size = New System.Drawing.Size(443, 25)
        Me.ToolStrip5.TabIndex = 110
        Me.ToolStrip5.Text = "ToolStrip5"
        '
        'cmdView
        '
        Me.cmdView.Image = CType(resources.GetObject("cmdView.Image"), System.Drawing.Image)
        Me.cmdView.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(68, 22)
        Me.cmdView.Text = "Preview"
        '
        'cmbPrinters
        '
        Me.cmbPrinters.Name = "cmbPrinters"
        Me.cmbPrinters.Size = New System.Drawing.Size(200, 25)
        Me.cmbPrinters.Text = "Printer LX-300 (Section 1)"
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(52, 22)
        Me.cmdPrint.Text = "Print"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX7)
        Me.FlowLayoutPanel1.Controls.Add(Me.t1)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX1)
        Me.FlowLayoutPanel1.Controls.Add(Me.t2)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX2)
        Me.FlowLayoutPanel1.Controls.Add(Me.t3)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 25)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(443, 88)
        Me.FlowLayoutPanel1.TabIndex = 111
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(3, 3)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(86, 21)
        Me.LabelX7.TabIndex = 119
        Me.LabelX7.Text = "Start Date"
        '
        't1
        '
        Me.t1.CalendarFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t1.CustomFormat = "dd/MM/yyyy"
        Me.t1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.t1.Location = New System.Drawing.Point(95, 3)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(340, 22)
        Me.t1.TabIndex = 6
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(3, 31)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(86, 21)
        Me.LabelX1.TabIndex = 121
        Me.LabelX1.Text = "Last Date"
        '
        't2
        '
        Me.t2.CalendarFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t2.CustomFormat = "dd/MM/yyyy"
        Me.t2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.t2.Location = New System.Drawing.Point(95, 31)
        Me.t2.Name = "t2"
        Me.t2.Size = New System.Drawing.Size(340, 22)
        Me.t2.TabIndex = 120
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(3, 59)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(86, 21)
        Me.LabelX2.TabIndex = 123
        Me.LabelX2.Text = "Item Code"
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
        Me.t3.TabIndex = 122
        '
        'frmReportSales1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 113)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip5)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.Name = "frmReportSales1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Report"
        Me.ToolStrip5.ResumeLayout(False)
        Me.ToolStrip5.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents ToolStrip5 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdView As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbPrinters As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents t1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents t2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents t3 As DevComponents.DotNetBar.Controls.TextBoxX
End Class
