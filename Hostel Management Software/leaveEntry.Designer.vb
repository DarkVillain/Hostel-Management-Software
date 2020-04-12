<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class leaveEntry
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
        Me.lblRn = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.cmbCz = New System.Windows.Forms.ComboBox()
        Me.lblCz = New System.Windows.Forms.Label()
        Me.lblFrm = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.cmbTo = New System.Windows.Forms.Label()
        Me.btnBck = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dtpFrm = New System.Windows.Forms.DateTimePicker()
        Me.txtEi = New System.Windows.Forms.TextBox()
        Me.cmbRn = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSpn = New System.Windows.Forms.TextBox()
        Me.btnCd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblRn
        '
        Me.lblRn.AutoSize = True
        Me.lblRn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRn.Location = New System.Drawing.Point(56, 99)
        Me.lblRn.Name = "lblRn"
        Me.lblRn.Size = New System.Drawing.Size(104, 16)
        Me.lblRn.TabIndex = 14
        Me.lblRn.Text = "Registration No."
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblInfo.Location = New System.Drawing.Point(135, 9)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(120, 24)
        Me.lblInfo.TabIndex = 16
        Me.lblInfo.Text = "Leave Entry"
        '
        'cmbCz
        '
        Me.cmbCz.FormattingEnabled = True
        Me.cmbCz.Items.AddRange(New Object() {"School leave", "Sick leave"})
        Me.cmbCz.Location = New System.Drawing.Point(211, 138)
        Me.cmbCz.Name = "cmbCz"
        Me.cmbCz.Size = New System.Drawing.Size(109, 21)
        Me.cmbCz.TabIndex = 18
        '
        'lblCz
        '
        Me.lblCz.AutoSize = True
        Me.lblCz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCz.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCz.Location = New System.Drawing.Point(56, 143)
        Me.lblCz.Name = "lblCz"
        Me.lblCz.Size = New System.Drawing.Size(56, 16)
        Me.lblCz.TabIndex = 19
        Me.lblCz.Text = "Reason"
        '
        'lblFrm
        '
        Me.lblFrm.AutoSize = True
        Me.lblFrm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrm.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFrm.Location = New System.Drawing.Point(58, 188)
        Me.lblFrm.Name = "lblFrm"
        Me.lblFrm.Size = New System.Drawing.Size(39, 16)
        Me.lblFrm.TabIndex = 20
        Me.lblFrm.Text = "From"
        '
        'dtpTo
        '
        Me.dtpTo.CustomFormat = "dd MMM yyyy"
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(211, 233)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(109, 20)
        Me.dtpTo.TabIndex = 23
        '
        'cmbTo
        '
        Me.cmbTo.AutoSize = True
        Me.cmbTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmbTo.Location = New System.Drawing.Point(58, 233)
        Me.cmbTo.Name = "cmbTo"
        Me.cmbTo.Size = New System.Drawing.Size(25, 16)
        Me.cmbTo.TabIndex = 22
        Me.cmbTo.Text = "To"
        '
        'btnBck
        '
        Me.btnBck.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBck.Location = New System.Drawing.Point(222, 318)
        Me.btnBck.Name = "btnBck"
        Me.btnBck.Size = New System.Drawing.Size(75, 23)
        Me.btnBck.TabIndex = 25
        Me.btnBck.Text = "Back"
        Me.btnBck.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(70, 318)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 24
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dtpFrm
        '
        Me.dtpFrm.CustomFormat = "dd MMM yyyy"
        Me.dtpFrm.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrm.Location = New System.Drawing.Point(211, 188)
        Me.dtpFrm.Name = "dtpFrm"
        Me.dtpFrm.Size = New System.Drawing.Size(109, 20)
        Me.dtpFrm.TabIndex = 26
        '
        'txtEi
        '
        Me.txtEi.Location = New System.Drawing.Point(211, 57)
        Me.txtEi.Name = "txtEi"
        Me.txtEi.Size = New System.Drawing.Size(109, 20)
        Me.txtEi.TabIndex = 27
        '
        'cmbRn
        '
        Me.cmbRn.FormattingEnabled = True
        Me.cmbRn.Items.AddRange(New Object() {"School leave", "Sick leave"})
        Me.cmbRn.Location = New System.Drawing.Point(211, 99)
        Me.cmbRn.Name = "cmbRn"
        Me.cmbRn.Size = New System.Drawing.Size(109, 21)
        Me.cmbRn.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(58, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Entry id"
        '
        'txtSpn
        '
        Me.txtSpn.Location = New System.Drawing.Point(211, 273)
        Me.txtSpn.Name = "txtSpn"
        Me.txtSpn.Size = New System.Drawing.Size(109, 20)
        Me.txtSpn.TabIndex = 30
        '
        'btnCd
        '
        Me.btnCd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCd.Location = New System.Drawing.Point(59, 271)
        Me.btnCd.Name = "btnCd"
        Me.btnCd.Size = New System.Drawing.Size(101, 23)
        Me.btnCd.TabIndex = 31
        Me.btnCd.Text = "Count Days"
        Me.btnCd.UseVisualStyleBackColor = True
        '
        'leaveEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(379, 394)
        Me.Controls.Add(Me.btnCd)
        Me.Controls.Add(Me.txtSpn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbRn)
        Me.Controls.Add(Me.txtEi)
        Me.Controls.Add(Me.dtpFrm)
        Me.Controls.Add(Me.btnBck)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.cmbTo)
        Me.Controls.Add(Me.lblFrm)
        Me.Controls.Add(Me.lblCz)
        Me.Controls.Add(Me.cmbCz)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblRn)
        Me.Name = "leaveEntry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRn As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents cmbCz As ComboBox
    Friend WithEvents lblCz As Label
    Friend WithEvents lblFrm As Label
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents cmbTo As Label
    Friend WithEvents btnBck As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents dtpFrm As DateTimePicker
    Friend WithEvents txtEi As TextBox
    Friend WithEvents cmbRn As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSpn As TextBox
    Friend WithEvents btnCd As Button
End Class
