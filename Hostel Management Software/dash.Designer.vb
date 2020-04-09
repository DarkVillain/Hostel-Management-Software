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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
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
        Me.pnlDash = New System.Windows.Forms.Panel()
        Me.lblUSR = New System.Windows.Forms.Label()
        Me.lblBanner = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlDash.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentToolStripMenuItem, Me.KitchenToolStripMenuItem, Me.UsageToolStripMenuItem, Me.StudentLeaveEntryToolStripMenuItem, Me.HostelExpensesToolStripMenuItem, Me.HostelBillingToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(-1, 69)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(792, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
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
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddToolStripMenuItem.Text = "Add Student"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
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
        Me.AddMaterialsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddMaterialsToolStripMenuItem.Text = "Add Materials"
        '
        'EditMaterialsToolStripMenuItem
        '
        Me.EditMaterialsToolStripMenuItem.Name = "EditMaterialsToolStripMenuItem"
        Me.EditMaterialsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
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
        Me.EnterUsageToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EnterUsageToolStripMenuItem.Text = "Enter Usage"
        '
        'EditUsageToolStripMenuItem
        '
        Me.EditUsageToolStripMenuItem.Name = "EditUsageToolStripMenuItem"
        Me.EditUsageToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
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
        Me.LeaveEntryToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LeaveEntryToolStripMenuItem.Text = "Leave Entry"
        '
        'EditEntryToolStripMenuItem
        '
        Me.EditEntryToolStripMenuItem.Name = "EditEntryToolStripMenuItem"
        Me.EditEntryToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EditEntryToolStripMenuItem.Text = "Edit Entry"
        '
        'HostelExpensesToolStripMenuItem
        '
        Me.HostelExpensesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterExpensesToolStripMenuItem, Me.EditExpensesToolStripMenuItem})
        Me.HostelExpensesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'pnlDash
        '
        Me.pnlDash.BackColor = System.Drawing.Color.DodgerBlue
        Me.pnlDash.Controls.Add(Me.lblUSR)
        Me.pnlDash.Controls.Add(Me.lblBanner)
        Me.pnlDash.Location = New System.Drawing.Point(-1, 0)
        Me.pnlDash.Name = "pnlDash"
        Me.pnlDash.Size = New System.Drawing.Size(872, 66)
        Me.pnlDash.TabIndex = 1
        '
        'lblUSR
        '
        Me.lblUSR.AutoSize = True
        Me.lblUSR.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lblUSR.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUSR.Location = New System.Drawing.Point(774, 13)
        Me.lblUSR.Name = "lblUSR"
        Me.lblUSR.Size = New System.Drawing.Size(0, 21)
        Me.lblUSR.TabIndex = 1
        '
        'lblBanner
        '
        Me.lblBanner.AutoSize = True
        Me.lblBanner.Font = New System.Drawing.Font("Microsoft Uighur", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBanner.ForeColor = System.Drawing.SystemColors.Control
        Me.lblBanner.Location = New System.Drawing.Point(13, 13)
        Me.lblBanner.Name = "lblBanner"
        Me.lblBanner.Size = New System.Drawing.Size(436, 38)
        Me.lblBanner.TabIndex = 0
        Me.lblBanner.Text = "WELCOME TO ASHROY BOYS HOSTEL "
        '
        'dash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(869, 482)
        Me.Controls.Add(Me.pnlDash)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "dash"
        Me.Text = "WELCOME"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlDash.ResumeLayout(False)
        Me.pnlDash.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
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
    Friend WithEvents pnlDash As Panel
    Friend WithEvents lblUSR As Label
    Friend WithEvents lblBanner As Label
End Class
