<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainFrm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainFrm))
        Me.LBL_Time = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LBL_VAL_TIME = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BillingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateSaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.Status_Message = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LBL_Time
        '
        Me.LBL_Time.AutoSize = True
        Me.LBL_Time.BackColor = System.Drawing.Color.White
        Me.LBL_Time.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Time.ForeColor = System.Drawing.Color.DodgerBlue
        Me.LBL_Time.Location = New System.Drawing.Point(1060, 36)
        Me.LBL_Time.Name = "LBL_Time"
        Me.LBL_Time.Size = New System.Drawing.Size(53, 19)
        Me.LBL_Time.TabIndex = 1
        Me.LBL_Time.Text = "Time:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'LBL_VAL_TIME
        '
        Me.LBL_VAL_TIME.AutoSize = True
        Me.LBL_VAL_TIME.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_VAL_TIME.ForeColor = System.Drawing.Color.Crimson
        Me.LBL_VAL_TIME.Location = New System.Drawing.Point(1182, 39)
        Me.LBL_VAL_TIME.Name = "LBL_VAL_TIME"
        Me.LBL_VAL_TIME.Size = New System.Drawing.Size(60, 19)
        Me.LBL_VAL_TIME.TabIndex = 2
        Me.LBL_VAL_TIME.Text = "Label1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.BillingToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1383, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'BillingToolStripMenuItem
        '
        Me.BillingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaleToolStripMenuItem, Me.UpdateSaleToolStripMenuItem})
        Me.BillingToolStripMenuItem.Name = "BillingToolStripMenuItem"
        Me.BillingToolStripMenuItem.Size = New System.Drawing.Size(65, 24)
        Me.BillingToolStripMenuItem.Text = "Billing"
        '
        'SaleToolStripMenuItem
        '
        Me.SaleToolStripMenuItem.Name = "SaleToolStripMenuItem"
        Me.SaleToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SaleToolStripMenuItem.Text = "Sale"
        '
        'UpdateSaleToolStripMenuItem
        '
        Me.UpdateSaleToolStripMenuItem.Name = "UpdateSaleToolStripMenuItem"
        Me.UpdateSaleToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.UpdateSaleToolStripMenuItem.Text = "UpdateSale"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton1, Me.Status_Message})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 774)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1383, 26)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(39, 24)
        Me.ToolStripSplitButton1.Text = "ToolStripSplitButton1"
        '
        'Status_Message
        '
        Me.Status_Message.Name = "Status_Message"
        Me.Status_Message.Size = New System.Drawing.Size(50, 20)
        Me.Status_Message.Text = "Ready"
        '
        'MainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1383, 800)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.LBL_VAL_TIME)
        Me.Controls.Add(Me.LBL_Time)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainFrm"
        Me.ShowIcon = False
        Me.Text = "BillingSystem"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBL_Time As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LBL_VAL_TIME As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BillingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents Status_Message As ToolStripStatusLabel
    Friend WithEvents SaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UpdateSaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
