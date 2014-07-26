<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalesItem))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.t1 = New System.Windows.Forms.ComboBox
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.t2 = New System.Windows.Forms.TextBox
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.t3 = New System.Windows.Forms.TextBox
        Me.t0 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.cmdSave = New DevComponents.DotNetBar.ButtonItem
        Me.cmdExit = New DevComponents.DotNetBar.ButtonItem
        Me.ControlContainerItem1 = New DevComponents.DotNetBar.ControlContainerItem
        Me.btnprint = New DevComponents.DotNetBar.ButtonItem
        Me.btnexit = New DevComponents.DotNetBar.ButtonItem
        Me.Bar1 = New DevComponents.DotNetBar.Bar
        Me.btnsave = New DevComponents.DotNetBar.ButtonItem
        Me.ControlContainerItem2 = New DevComponents.DotNetBar.ControlContainerItem
        Me.btncancel = New DevComponents.DotNetBar.ButtonItem
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX3)
        Me.FlowLayoutPanel1.Controls.Add(Me.t1)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX1)
        Me.FlowLayoutPanel1.Controls.Add(Me.t2)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelX2)
        Me.FlowLayoutPanel1.Controls.Add(Me.t3)
        Me.FlowLayoutPanel1.Controls.Add(Me.t0)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 28)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(346, 97)
        Me.FlowLayoutPanel1.TabIndex = 112
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(3, 3)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(101, 21)
        Me.LabelX3.TabIndex = 111
        Me.LabelX3.Text = "Item"
        '
        't1
        '
        Me.t1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t1.FormattingEnabled = True
        Me.t1.Location = New System.Drawing.Point(110, 3)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(203, 24)
        Me.t1.TabIndex = 1
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(3, 33)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(101, 21)
        Me.LabelX1.TabIndex = 2
        Me.LabelX1.Text = "Qty"
        '
        't2
        '
        Me.t2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t2.Location = New System.Drawing.Point(110, 33)
        Me.t2.Name = "t2"
        Me.t2.Size = New System.Drawing.Size(203, 22)
        Me.t2.TabIndex = 2
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(3, 61)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(101, 21)
        Me.LabelX2.TabIndex = 112
        Me.LabelX2.Text = "Price"
        '
        't3
        '
        Me.t3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t3.Location = New System.Drawing.Point(110, 61)
        Me.t3.Name = "t3"
        Me.t3.Size = New System.Drawing.Size(203, 22)
        Me.t3.TabIndex = 3
        '
        't0
        '
        Me.t0.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.t0.Border.Class = "TextBoxBorder"
        Me.t0.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t0.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.t0.Location = New System.Drawing.Point(319, 61)
        Me.t0.Name = "t0"
        Me.t0.Size = New System.Drawing.Size(20, 22)
        Me.t0.TabIndex = 108
        Me.t0.Visible = False
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
        Me.cmdExit.Text = "Cancel"
        '
        'ControlContainerItem1
        '
        Me.ControlContainerItem1.AllowItemResize = False
        Me.ControlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ControlContainerItem1.Name = "ControlContainerItem1"
        '
        'btnprint
        '
        Me.btnprint.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnprint.Image = CType(resources.GetObject("btnprint.Image"), System.Drawing.Image)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnexit})
        Me.btnprint.Text = "Print"
        '
        'btnexit
        '
        Me.btnexit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnexit.Image = CType(resources.GetObject("btnexit.Image"), System.Drawing.Image)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Text = "Exit"
        '
        'Bar1
        '
        Me.Bar1.AccessibleDescription = "DotNetBar Bar (Bar1)"
        Me.Bar1.AccessibleName = "DotNetBar Bar"
        Me.Bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.Bar1.AntiAlias = True
        Me.Bar1.BackColor = System.Drawing.Color.Silver
        Me.Bar1.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.TopLeft
        Me.Bar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Bar1.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnsave, Me.btncancel})
        Me.Bar1.ItemSpacing = 7
        Me.Bar1.Location = New System.Drawing.Point(0, 0)
        Me.Bar1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.SingleLineColor = System.Drawing.Color.White
        Me.Bar1.Size = New System.Drawing.Size(371, 25)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Bar1.TabIndex = 113
        Me.Bar1.TabStop = False
        Me.Bar1.Text = "Bar1"
        '
        'btnsave
        '
        Me.btnsave.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Text = "Save"
        '
        'ControlContainerItem2
        '
        Me.ControlContainerItem2.AllowItemResize = False
        Me.ControlContainerItem2.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ControlContainerItem2.Name = "ControlContainerItem2"
        '
        'btncancel
        '
        Me.btncancel.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btncancel.Image = CType(resources.GetObject("btncancel.Image"), System.Drawing.Image)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Text = "Exit"
        '
        'frmSalesItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 129)
        Me.Controls.Add(Me.Bar1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.DoubleBuffered = True
        Me.Name = "frmSalesItem"
        Me.Text = "Add Item"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents t1 As System.Windows.Forms.ComboBox
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents t2 As System.Windows.Forms.TextBox
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents t3 As System.Windows.Forms.TextBox
    Friend WithEvents t0 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmdSave As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdExit As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ControlContainerItem1 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents btnprint As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnexit As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents btnsave As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btncancel As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ControlContainerItem2 As DevComponents.DotNetBar.ControlContainerItem
End Class
