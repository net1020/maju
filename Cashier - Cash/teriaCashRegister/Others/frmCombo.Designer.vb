<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCombo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCombo))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.TextBoxX9 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.grid1 = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TextBoxX9.Location = New System.Drawing.Point(2, 3)
        Me.TextBoxX9.Name = "TextBoxX9"
        Me.TextBoxX9.Size = New System.Drawing.Size(294, 27)
        Me.TextBoxX9.TabIndex = 121
        Me.TextBoxX9.WatermarkImage = CType(resources.GetObject("TextBoxX9.WatermarkImage"), System.Drawing.Image)
        Me.TextBoxX9.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TextBoxX9.WatermarkText = "Search"
        '
        'grid1
        '
        Me.grid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid1.ColumnHeadersVisible = False
        Me.grid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid1.DefaultCellStyle = DataGridViewCellStyle2
        Me.grid1.EnableHeadersVisualStyles = False
        Me.grid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.grid1.Location = New System.Drawing.Point(2, 31)
        Me.grid1.Name = "grid1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grid1.RowHeadersVisible = False
        Me.grid1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid1.Size = New System.Drawing.Size(294, 210)
        Me.grid1.TabIndex = 122
        '
        'Column1
        '
        Me.Column1.HeaderText = "Items"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 293
        '
        'frmCombo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 283)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.TextBoxX9)
        Me.Name = "frmCombo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCombo"
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextBoxX9 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents grid1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
