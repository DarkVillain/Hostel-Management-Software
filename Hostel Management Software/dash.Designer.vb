<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dash
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
        Me.mnsDm = New System.Windows.Forms.MenuStrip()
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KitchenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddMaterialsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMaterialsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnterUsageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditUsageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentLeaveEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeaveEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HostelExpensesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnterExpensesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditExpensesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HostelBillingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BillsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DailyUsageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeaveEntryToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpensesEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsslMsg = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslNm = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslBlnk = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslTd = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.mnsDm.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnsDm
        '
        Me.mnsDm.BackColor = System.Drawing.Color.White
        Me.mnsDm.GripMargin = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.mnsDm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.mnsDm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentToolStripMenuItem, Me.KitchenToolStripMenuItem, Me.UsageToolStripMenuItem, Me.StudentLeaveEntryToolStripMenuItem, Me.HostelExpensesToolStripMenuItem, Me.HostelBillingToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.mnsDm.Location = New System.Drawing.Point(0, 0)
        Me.mnsDm.Name = "mnsDm"
        Me.mnsDm.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.mnsDm.ShowItemToolTips = True
        Me.mnsDm.Size = New System.Drawing.Size(1018, 25)
        Me.mnsDm.TabIndex = 0
        Me.mnsDm.Text = "MenuStrip1"
        '
        'StudentToolStripMenuItem
        '
        Me.StudentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.StudentToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem"
        Me.StudentToolStripMenuItem.Size = New System.Drawing.Size(112, 21)
        Me.StudentToolStripMenuItem.Text = "Student Details"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.AddToolStripMenuItem.Text = "Add Student"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.EditToolStripMenuItem.Text = "Edit Student"
        '
        'KitchenToolStripMenuItem
        '
        Me.KitchenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddMaterialsToolStripMenuItem, Me.EditMaterialsToolStripMenuItem})
        Me.KitchenToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KitchenToolStripMenuItem.Name = "KitchenToolStripMenuItem"
        Me.KitchenToolStripMenuItem.Size = New System.Drawing.Size(124, 21)
        Me.KitchenToolStripMenuItem.Text = "Kitchen Materials"
        '
        'AddMaterialsToolStripMenuItem
        '
        Me.AddMaterialsToolStripMenuItem.Name = "AddMaterialsToolStripMenuItem"
        Me.AddMaterialsToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.AddMaterialsToolStripMenuItem.Text = "Add Materials"
        '
        'EditMaterialsToolStripMenuItem
        '
        Me.EditMaterialsToolStripMenuItem.Name = "EditMaterialsToolStripMenuItem"
        Me.EditMaterialsToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.EditMaterialsToolStripMenuItem.Text = "Edit Materials"
        '
        'UsageToolStripMenuItem
        '
        Me.UsageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterUsageToolStripMenuItem, Me.EditUsageToolStripMenuItem})
        Me.UsageToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsageToolStripMenuItem.Name = "UsageToolStripMenuItem"
        Me.UsageToolStripMenuItem.Size = New System.Drawing.Size(120, 21)
        Me.UsageToolStripMenuItem.Text = " Materials Usage"
        '
        'EnterUsageToolStripMenuItem
        '
        Me.EnterUsageToolStripMenuItem.Name = "EnterUsageToolStripMenuItem"
        Me.EnterUsageToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.EnterUsageToolStripMenuItem.Text = "Enter Usage"
        '
        'EditUsageToolStripMenuItem
        '
        Me.EditUsageToolStripMenuItem.Name = "EditUsageToolStripMenuItem"
        Me.EditUsageToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.EditUsageToolStripMenuItem.Text = "Edit Usage"
        '
        'StudentLeaveEntryToolStripMenuItem
        '
        Me.StudentLeaveEntryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LeaveEntryToolStripMenuItem, Me.EditEntryToolStripMenuItem})
        Me.StudentLeaveEntryToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentLeaveEntryToolStripMenuItem.Name = "StudentLeaveEntryToolStripMenuItem"
        Me.StudentLeaveEntryToolStripMenuItem.Size = New System.Drawing.Size(143, 21)
        Me.StudentLeaveEntryToolStripMenuItem.Text = "Student Leave Entry"
        '
        'LeaveEntryToolStripMenuItem
        '
        Me.LeaveEntryToolStripMenuItem.Name = "LeaveEntryToolStripMenuItem"
        Me.LeaveEntryToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.LeaveEntryToolStripMenuItem.Text = "Leave Entry"
        '
        'EditEntryToolStripMenuItem
        '
        Me.EditEntryToolStripMenuItem.Name = "EditEntryToolStripMenuItem"
        Me.EditEntryToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.EditEntryToolStripMenuItem.Text = "Edit Entry"
        '
        'HostelExpensesToolStripMenuItem
        '
        Me.HostelExpensesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterExpensesToolStripMenuItem, Me.EditExpensesToolStripMenuItem})
        Me.HostelExpensesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HostelExpensesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HostelExpensesToolStripMenuItem.Name = "HostelExpensesToolStripMenuItem"
        Me.HostelExpensesToolStripMenuItem.Size = New System.Drawing.Size(119, 21)
        Me.HostelExpensesToolStripMenuItem.Text = "Hostel Expenses"
        '
        'EnterExpensesToolStripMenuItem
        '
        Me.EnterExpensesToolStripMenuItem.Name = "EnterExpensesToolStripMenuItem"
        Me.EnterExpensesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EnterExpensesToolStripMenuItem.Text = "Enter Expenses"
        '
        'EditExpensesToolStripMenuItem
        '
        Me.EditExpensesToolStripMenuItem.Name = "EditExpensesToolStripMenuItem"
        Me.EditExpensesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EditExpensesToolStripMenuItem.Text = "Edit Expenses"
        '
        'HostelBillingToolStripMenuItem
        '
        Me.HostelBillingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BillsToolStripMenuItem})
        Me.HostelBillingToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HostelBillingToolStripMenuItem.Name = "HostelBillingToolStripMenuItem"
        Me.HostelBillingToolStripMenuItem.Size = New System.Drawing.Size(99, 21)
        Me.HostelBillingToolStripMenuItem.Text = "Hostel Billing"
        '
        'BillsToolStripMenuItem
        '
        Me.BillsToolStripMenuItem.Name = "BillsToolStripMenuItem"
        Me.BillsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BillsToolStripMenuItem.Text = "Bills"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentReportsToolStripMenuItem, Me.MaterialReportToolStripMenuItem, Me.DailyUsageToolStripMenuItem, Me.LeaveEntryToolStripMenuItem1, Me.ExpensesEntryToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(67, 21)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'StudentReportsToolStripMenuItem
        '
        Me.StudentReportsToolStripMenuItem.Name = "StudentReportsToolStripMenuItem"
        Me.StudentReportsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.StudentReportsToolStripMenuItem.Text = "Student Report"
        '
        'MaterialReportToolStripMenuItem
        '
        Me.MaterialReportToolStripMenuItem.Name = "MaterialReportToolStripMenuItem"
        Me.MaterialReportToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MaterialReportToolStripMenuItem.Text = "Material Report"
        '
        'DailyUsageToolStripMenuItem
        '
        Me.DailyUsageToolStripMenuItem.Name = "DailyUsageToolStripMenuItem"
        Me.DailyUsageToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DailyUsageToolStripMenuItem.Text = "Daily Usage"
        '
        'LeaveEntryToolStripMenuItem1
        '
        Me.LeaveEntryToolStripMenuItem1.Name = "LeaveEntryToolStripMenuItem1"
        Me.LeaveEntryToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.LeaveEntryToolStripMenuItem1.Text = "Leave Entry"
        '
        'ExpensesEntryToolStripMenuItem
        '
        Me.ExpensesEntryToolStripMenuItem.Name = "ExpensesEntryToolStripMenuItem"
        Me.ExpensesEntryToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExpensesEntryToolStripMenuItem.Text = "Expenses Entry"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.White
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslMsg, Me.tsslNm, Me.tsslBlnk, Me.tsslTd})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 460)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1018, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsslMsg
        '
        Me.tsslMsg.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsslMsg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tsslMsg.Name = "tsslMsg"
        Me.tsslMsg.Size = New System.Drawing.Size(87, 17)
        Me.tsslMsg.Text = "Logged in as:"
        '
        'tsslNm
        '
        Me.tsslNm.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsslNm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tsslNm.Image = Global.Hostel_Management_Software.My.Resources.Resources.admin
        Me.tsslNm.Name = "tsslNm"
        Me.tsslNm.Size = New System.Drawing.Size(86, 17)
        Me.tsslNm.Text = "&login.txtUn"
        '
        'tsslBlnk
        '
        Me.tsslBlnk.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tsslBlnk.Name = "tsslBlnk"
        Me.tsslBlnk.Size = New System.Drawing.Size(739, 17)
        Me.tsslBlnk.Spring = True
        '
        'tsslTd
        '
        Me.tsslTd.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsslTd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tsslTd.Name = "tsslTd"
        Me.tsslTd.Size = New System.Drawing.Size(0, 17)
        Me.tsslTd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkMagenta
        Me.BackgroundImage = Global.Hostel_Management_Software.My.Resources.Resources.hostelbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1018, 482)
        Me.Controls.Add(Me.mnsDm)
        Me.Controls.Add(Me.StatusStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MainMenuStrip = Me.mnsDm
        Me.Name = "dash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.mnsDm.ResumeLayout(False)
        Me.mnsDm.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnsDm As MenuStrip
    Friend WithEvents StudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KitchenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddMaterialsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditMaterialsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnterUsageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditUsageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentLeaveEntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeaveEntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditEntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HostelExpensesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnterExpensesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditExpensesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HostelBillingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BillsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaterialReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DailyUsageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeaveEntryToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExpensesEntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tsslMsg As ToolStripStatusLabel
    Friend WithEvents tsslNm As ToolStripStatusLabel
    Friend WithEvents tsslBlnk As ToolStripStatusLabel
    Friend WithEvents tsslTd As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
