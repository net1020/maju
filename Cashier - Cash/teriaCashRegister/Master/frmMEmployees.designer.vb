<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMEmployees
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMEmployees))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem
        Me.TextBoxItem1 = New DevComponents.DotNetBar.TextBoxItem
        Me.LabelItem2 = New DevComponents.DotNetBar.LabelItem
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem8 = New DevComponents.DotNetBar.ButtonItem
        Me.AdnetNavigation1 = New ctlNavigation.AdnetNavigation
        Me.Bar1 = New DevComponents.DotNetBar.Bar
        Me.ButtonItem9 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem10 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem11 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem12 = New DevComponents.DotNetBar.ButtonItem
        Me.LabelItem3 = New DevComponents.DotNetBar.LabelItem
        Me.ComboBoxItem2 = New DevComponents.DotNetBar.ComboBoxItem
        Me.grid1 = New DevComponents.DotNetBar.Controls.DataGridViewX
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonItem1
        '
        Me.ButtonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Text = "<<"
        '
        'ButtonItem2
        '
        Me.ButtonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.Text = "<"
        '
        'TextBoxItem1
        '
        Me.TextBoxItem1.Name = "TextBoxItem1"
        Me.TextBoxItem1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextBoxItem1.WatermarkColor = System.Drawing.SystemColors.GrayText
        '
        'LabelItem2
        '
        Me.LabelItem2.ForeColor = System.Drawing.Color.Black
        Me.LabelItem2.Name = "LabelItem2"
        Me.LabelItem2.Text = "of 2"
        '
        'ButtonItem3
        '
        Me.ButtonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem3.Image = CType(resources.GetObject("ButtonItem3.Image"), System.Drawing.Image)
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.Text = ">"
        '
        'ButtonItem8
        '
        Me.ButtonItem8.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem8.Image = CType(resources.GetObject("ButtonItem8.Image"), System.Drawing.Image)
        Me.ButtonItem8.Name = "ButtonItem8"
        Me.ButtonItem8.Text = ">>"
        '
        'AdnetNavigation1
        '
        Me.AdnetNavigation1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AdnetNavigation1.Location = New System.Drawing.Point(0, 374)
        Me.AdnetNavigation1.Name = "AdnetNavigation1"
        Me.AdnetNavigation1.Size = New System.Drawing.Size(629, 25)
        Me.AdnetNavigation1.TabIndex = 107
        '
        'Bar1
        '
        Me.Bar1.AntiAlias = True
        Me.Bar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem9, Me.ButtonItem10, Me.ButtonItem11, Me.ButtonItem12, Me.LabelItem3, Me.ComboBoxItem2})
        Me.Bar1.Location = New System.Drawing.Point(0, 0)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(629, 28)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabIndex = 109
        Me.Bar1.TabStop = False
        Me.Bar1.Text = "Bar1"
        '
        'ButtonItem9
        '
        Me.ButtonItem9.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem9.Image = CType(resources.GetObject("ButtonItem9.Image"), System.Drawing.Image)
        Me.ButtonItem9.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.ButtonItem9.Name = "ButtonItem9"
        Me.ButtonItem9.Text = "Add New"
        '
        'ButtonItem10
        '
        Me.ButtonItem10.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem10.Image = CType(resources.GetObject("ButtonItem10.Image"), System.Drawing.Image)
        Me.ButtonItem10.Name = "ButtonItem10"
        Me.ButtonItem10.Text = "Edit"
        '
        'ButtonItem11
        '
        Me.ButtonItem11.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem11.Image = CType(resources.GetObject("ButtonItem11.Image"), System.Drawing.Image)
        Me.ButtonItem11.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.ButtonItem11.Name = "ButtonItem11"
        Me.ButtonItem11.Text = "remove"
        '
        'ButtonItem12
        '
        Me.ButtonItem12.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem12.Image = CType(resources.GetObject("ButtonItem12.Image"), System.Drawing.Image)
        Me.ButtonItem12.Name = "ButtonItem12"
        Me.ButtonItem12.Text = "Refresh"
        '
        'LabelItem3
        '
        Me.LabelItem3.ForeColor = System.Drawing.Color.Black
        Me.LabelItem3.Name = "LabelItem3"
        Me.LabelItem3.Text = "Search "
        '
        'ComboBoxItem2
        '
        Me.ComboBoxItem2.ComboWidth = 150
        Me.ComboBoxItem2.DropDownHeight = 106
        Me.ComboBoxItem2.ItemHeight = 17
        Me.ComboBoxItem2.Name = "ComboBoxItem2"
        '
        'grid1
        '
        Me.grid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid1.DefaultCellStyle = DataGridViewCellStyle2
        Me.grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid1.EnableHeadersVisualStyles = False
        Me.grid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.grid1.Location = New System.Drawing.Point(0, 28)
        Me.grid1.Name = "grid1"
        Me.grid1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grid1.RowHeadersVisible = False
        Me.grid1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid1.Size = New System.Drawing.Size(629, 346)
        Me.grid1.TabIndex = 110
        '
        'frmMEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 399)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.Bar1)
        Me.Controls.Add(Me.AdnetNavigation1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMEmployees"
        Me.Text = "Employee"
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents TextBoxItem1 As DevComponents.DotNetBar.TextBoxItem
    Friend WithEvents LabelItem2 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem8 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents AdnetNavigation1 As ctlNavigation.AdnetNavigation
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents ButtonItem9 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem10 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem11 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem12 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LabelItem3 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents ComboBoxItem2 As DevComponents.DotNetBar.ComboBoxItem
    Friend WithEvents grid1 As DevComponents.DotNetBar.Controls.DataGridViewX
End Class
