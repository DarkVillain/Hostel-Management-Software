<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editEntry
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
        Me.btnBck = New System.Windows.Forms.Button()
        Me.btnUpdt = New System.Windows.Forms.Button()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.cmbTo = New System.Windows.Forms.Label()
        Me.dtpFrm = New System.Windows.Forms.DateTimePicker()
        Me.lblFrm = New System.Windows.Forms.Label()
        Me.lblCz = New System.Windows.Forms.Label()
        Me.cmbCz = New System.Windows.Forms.ComboBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblRn = New System.Windows.Forms.Label()
        Me.cmbEi = New System.Windows.Forms.ComboBox()
        Me.lblEi = New System.Windows.Forms.Label()
        Me.btnDlt = New System.Windows.Forms.Button()
        Me.txtRn = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnBck
        '
        Me.btnBck.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBck.Location = New System.Drawing.Point(240, 287)
        Me.btnBck.Name = "btnBck"
        Me.btnBck.Size = New System.Drawing.Size(75, 23)
        Me.btnBck.TabIndex = 36
        Me.btnBck.Text = "BACK"
        Me.btnBck.UseVisualStyleBackColor = True
        '
        'btnUpdt
        '
        Me.btnUpdt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdt.Location = New System.Drawing.Point(49, 287)
        Me.btnUpdt.Name = "btnUpdt"
        Me.btnUpdt.Size = New System.Drawing.Size(82, 23)
        Me.btnUpdt.TabIndex = 35
        Me.btnUpdt.Text = "UPDATE"
        Me.btnUpdt.UseVisualStyleBackColor = True
        '
        'dtpTo
        '
        Me.dtpTo.Location = New System.Drawing.Point(206, 233)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.ShowCheckBox = True
        Me.dtpTo.Size = New System.Drawing.Size(109, 20)
        Me.dtpTo.TabIndex = 34
        '
        'cmbTo
        '
        Me.cmbTo.AutoSize = True
        Me.cmbTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmbTo.Location = New System.Drawing.Point(53, 233)
        Me.cmbTo.Name = "cmbTo"
        Me.cmbTo.Size = New System.Drawing.Size(25, 16)
        Me.cmbTo.TabIndex = 33
        Me.cmbTo.Text = "To"
        '
        'dtpFrm
        '
        Me.dtpFrm.Location = New System.Drawing.Point(206, 188)
        Me.dtpFrm.Name = "dtpFrm"
        Me.dtpFrm.ShowCheckBox = True
        Me.dtpFrm.Size = New System.Drawing.Size(109, 20)
        Me.dtpFrm.TabIndex = 32
        '
        'lblFrm
        '
        Me.lblFrm.AutoSize = True
        Me.lblFrm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrm.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFrm.Location = New System.Drawing.Point(53, 188)
        Me.lblFrm.Name = "lblFrm"
        Me.lblFrm.Size = New System.Drawing.Size(39, 16)
        Me.lblFrm.TabIndex = 31
        Me.lblFrm.Text = "From"
        '
        'lblCz
        '
        Me.lblCz.AutoSize = True
        Me.lblCz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCz.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCz.Location = New System.Drawing.Point(51, 143)
        Me.lblCz.Name = "lblCz"
        Me.lblCz.Size = New System.Drawing.Size(56, 16)
        Me.lblCz.TabIndex = 30
        Me.lblCz.Text = "Reason"
        '
        'cmbCz
        '
        Me.cmbCz.FormattingEnabled = True
        Me.cmbCz.Items.AddRange(New Object() {"School leave", "Sick leave"})
        Me.cmbCz.Location = New System.Drawing.Point(206, 138)
        Me.cmbCz.Name = "cmbCz"
        Me.cmbCz.Size = New System.Drawing.Size(109, 21)
        Me.cmbCz.TabIndex = 29
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblInfo.Location = New System.Drawing.Point(130, 9)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(100, 24)
        Me.lblInfo.TabIndex = 27
        Me.lblInfo.Text = "Edit Entry"
        '
        'lblRn
        '
        Me.lblRn.AutoSize = True
        Me.lblRn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRn.Location = New System.Drawing.Point(51, 104)
        Me.lblRn.Name = "lblRn"
        Me.lblRn.Size = New System.Drawing.Size(104, 16)
        Me.lblRn.TabIndex = 26
        Me.lblRn.Text = "Registration No."
        '
        'cmbEi
        '
        Me.cmbEi.FormattingEnabled = True
        Me.cmbEi.Location = New System.Drawing.Point(206, 63)
        Me.cmbEi.Name = "cmbEi"
        Me.cmbEi.Size = New System.Drawing.Size(109, 21)
        Me.cmbEi.TabIndex = 37
        '
        'lblEi
        '
        Me.lblEi.AutoSize = True
        Me.lblEi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEi.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblEi.Location = New System.Drawing.Point(55, 63)
        Me.lblEi.Name = "lblEi"
        Me.lblEi.Size = New System.Drawing.Size(52, 16)
        Me.lblEi.TabIndex = 38
        Me.lblEi.Text = "Entry id"
        '
        'btnDlt
        '
        Me.btnDlt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDlt.Location = New System.Drawing.Point(146, 287)
        Me.btnDlt.Name = "btnDlt"
        Me.btnDlt.Size = New System.Drawing.Size(75, 23)
        Me.btnDlt.TabIndex = 39
        Me.btnDlt.Text = "DELETE"
        Me.btnDlt.UseVisualStyleBackColor = True
        '
        'txtRn
        '
        Me.txtRn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRn.Location = New System.Drawing.Point(206, 101)
        Me.txtRn.Name = "txtRn"
        Me.txtRn.Size = New System.Drawing.Size(108, 22)
        Me.txtRn.TabIndex = 40
        '
        'editEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(422, 450)
        Me.Controls.Add(Me.txtRn)
        Me.Controls.Add(Me.btnDlt)
        Me.Controls.Add(Me.lblEi)
        Me.Controls.Add(Me.cmbEi)
        Me.Controls.Add(Me.btnBck)
        Me.Controls.Add(Me.btnUpdt)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.cmbTo)
        Me.Controls.Add(Me.dtpFrm)
        Me.Controls.Add(Me.lblFrm)
        Me.Controls.Add(Me.lblCz)
        Me.Controls.Add(Me.cmbCz)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblRn)
        Me.Name = "editEntry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBck As Button
    Friend WithEvents btnUpdt As Button
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents cmbTo As Label
    Friend WithEvents dtpFrm As DateTimePicker
    Friend WithEvents lblFrm As Label
    Friend WithEvents lblCz As Label
    Friend WithEvents cmbCz As ComboBox
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblRn As Label
    Friend WithEvents cmbEi As ComboBox
    Friend WithEvents lblEi As Label
    Friend WithEvents btnDlt As Button
    Friend WithEvents txtRn As TextBox
End Class
