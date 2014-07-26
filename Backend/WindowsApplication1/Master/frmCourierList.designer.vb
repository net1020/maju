<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCourierList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCourierList))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.cmdAdd = New System.Windows.Forms.ToolStripButton
        Me.cmdEdit = New System.Windows.Forms.ToolStripButton
        Me.cmdRemove = New System.Windows.Forms.ToolStripButton
        Me.cmdRefresh = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.txtSearch = New System.Windows.Forms.ToolStripComboBox
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.btnPrev = New System.Windows.Forms.ToolStripButton
        Me.lblPage = New System.Windows.Forms.ToolStripLabel
        Me.btnNext = New System.Windows.Forms.ToolStripButton
        Me.gridRaw1 = New System.Windows.Forms.DataGridView
        Me.bind1 = New DevComponents.DotNetBar.Controls.BindingNavigatorEx(Me.components)
        Me.BindingNavigatorAddNewItem = New DevComponents.DotNetBar.ButtonItem
        Me.BindingNavigatorCountItem = New DevComponents.DotNetBar.LabelItem
        Me.BindingNavigatorDeleteItem = New DevComponents.DotNetBar.ButtonItem
        Me.BindingNavigatorMoveFirstItem = New DevComponents.DotNetBar.ButtonItem
        Me.BindingNavigatorMovePreviousItem = New DevComponents.DotNetBar.ButtonItem
        Me.BindingNavigatorPositionItem = New DevComponents.DotNetBar.TextBoxItem
        Me.BindingNavigatorMoveNextItem = New DevComponents.DotNetBar.ButtonItem
        Me.BindingNavigatorMoveLastItem = New DevComponents.DotNetBar.ButtonItem
        Me.ToolStrip1.SuspendLayout()
        CType(Me.gridRaw1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bind1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAdd, Me.cmdEdit, Me.cmdRemove, Me.cmdRefresh, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.txtSearch, Me.ToolStripSeparator2, Me.ToolStripButton1, Me.btnPrev, Me.lblPage, Me.btnNext})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(779, 25)
        Me.ToolStrip1.TabIndex = 19
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdAdd
        '
        Me.cmdAdd.Image = CType(resources.GetObject("cmdAdd.Image"), System.Drawing.Image)
        Me.cmdAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(76, 22)
        Me.cmdAdd.Text = "Add New"
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(52, 22)
        Me.cmdEdit.Text = "View"
        '
        'cmdRemove
        '
        Me.cmdRemove.Image = CType(resources.GetObject("cmdRemove.Image"), System.Drawing.Image)
        Me.cmdRemove.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(70, 22)
        Me.cmdRemove.Text = "Remove"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(66, 22)
        Me.cmdRefresh.Text = "Refresh"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(45, 22)
        Me.ToolStripLabel1.Text = "Search:"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(125, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Search"
        '
        'btnPrev
        '
        Me.btnPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnPrev.Image = CType(resources.GetObject("btnPrev.Image"), System.Drawing.Image)
        Me.btnPrev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(23, 22)
        Me.btnPrev.Text = "<"
        '
        'lblPage
        '
        Me.lblPage.Name = "lblPage"
        Me.lblPage.Size = New System.Drawing.Size(50, 22)
        Me.lblPage.Text = "Page (1)"
        '
        'btnNext
        '
        Me.btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnNext.Image = CType(resources.GetObject("btnNext.Image"), System.Drawing.Image)
        Me.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(23, 22)
        Me.btnNext.Text = ">"
        '
        'gridRaw1
        '
        Me.gridRaw1.AllowUserToAddRows = False
        Me.gridRaw1.AllowUserToDeleteRows = False
        Me.gridRaw1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gridRaw1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gridRaw1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridRaw1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridRaw1.Location = New System.Drawing.Point(0, 25)
        Me.gridRaw1.Name = "gridRaw1"
        Me.gridRaw1.ReadOnly = True
        Me.gridRaw1.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridRaw1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.gridRaw1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridRaw1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.gridRaw1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridRaw1.Size = New System.Drawing.Size(779, 347)
        Me.gridRaw1.TabIndex = 23
        '
        'bind1
        '
        Me.bind1.AddNewRecordButton = Me.BindingNavigatorAddNewItem
        Me.bind1.AntiAlias = True
        Me.bind1.CountLabel = Me.BindingNavigatorCountItem
        Me.bind1.CountLabelFormat = "of {0}"
        Me.bind1.DeleteButton = Me.BindingNavigatorDeleteItem
        Me.bind1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bind1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bind1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.bind1.Location = New System.Drawing.Point(0, 347)
        Me.bind1.MoveFirstButton = Me.BindingNavigatorMoveFirstItem
        Me.bind1.MoveLastButton = Me.BindingNavigatorMoveLastItem
        Me.bind1.MoveNextButton = Me.BindingNavigatorMoveNextItem
        Me.bind1.MovePreviousButton = Me.BindingNavigatorMovePreviousItem
        Me.bind1.Name = "bind1"
        Me.bind1.PositionTextBox = Me.BindingNavigatorPositionItem
        Me.bind1.Size = New System.Drawing.Size(779, 25)
        Me.bind1.Stretch = True
        Me.bind1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.bind1.TabIndex = 28
        Me.bind1.TabStop = False
        Me.bind1.Text = "BindingNavigatorEx1"
        Me.bind1.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Text = "of {0}"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.BeginGroup = True
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BindingNavigatorPositionItem.TextBoxWidth = 54
        Me.BindingNavigatorPositionItem.WatermarkColor = System.Drawing.SystemColors.GrayText
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.BeginGroup = True
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'frmProductList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 372)
        Me.Controls.Add(Me.bind1)
        Me.Controls.Add(Me.gridRaw1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProductList"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Product"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.gridRaw1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bind1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdRemove As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtSearch As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents gridRaw1 As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents bind1 As DevComponents.DotNetBar.Controls.BindingNavigatorEx
    Friend WithEvents BindingNavigatorAddNewItem As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BindingNavigatorCountItem As DevComponents.DotNetBar.LabelItem
    Friend WithEvents BindingNavigatorDeleteItem As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BindingNavigatorMoveFirstItem As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BindingNavigatorMovePreviousItem As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BindingNavigatorPositionItem As DevComponents.DotNetBar.TextBoxItem
    Friend WithEvents BindingNavigatorMoveNextItem As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BindingNavigatorMoveLastItem As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnPrev As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblPage As System.Windows.Forms.ToolStripLabel
End Class
