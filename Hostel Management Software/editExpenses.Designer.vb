<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editExpenses
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
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.txtRn = New System.Windows.Forms.TextBox()
        Me.txtAm = New System.Windows.Forms.TextBox()
        Me.btnBck = New System.Windows.Forms.Button()
        Me.btnUpdt = New System.Windows.Forms.Button()
        Me.lblDt = New System.Windows.Forms.Label()
        Me.lblAm = New System.Windows.Forms.Label()
        Me.lblRn = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblEi = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDlt = New System.Windows.Forms.Button()
        Me.cmbEi = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'dtp
        '
        Me.dtp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp.Location = New System.Drawing.Point(141, 285)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(147, 22)
        Me.dtp.TabIndex = 5
        '
        'txtTo
        '
        Me.txtTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTo.Location = New System.Drawing.Point(141, 132)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(147, 22)
        Me.txtTo.TabIndex = 2
        '
        'txtRn
        '
        Me.txtRn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRn.Location = New System.Drawing.Point(141, 182)
        Me.txtRn.Name = "txtRn"
        Me.txtRn.Size = New System.Drawing.Size(147, 22)
        Me.txtRn.TabIndex = 3
        '
        'txtAm
        '
        Me.txtAm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAm.Location = New System.Drawing.Point(141, 229)
        Me.txtAm.Name = "txtAm"
        Me.txtAm.Size = New System.Drawing.Size(147, 22)
        Me.txtAm.TabIndex = 4
        '
        'btnBck
        '
        Me.btnBck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBck.Location = New System.Drawing.Point(213, 358)
        Me.btnBck.Name = "btnBck"
        Me.btnBck.Size = New System.Drawing.Size(75, 23)
        Me.btnBck.TabIndex = 8
        Me.btnBck.Text = "BACK"
        Me.btnBck.UseVisualStyleBackColor = True
        '
        'btnUpdt
        '
        Me.btnUpdt.Location = New System.Drawing.Point(27, 358)
        Me.btnUpdt.Name = "btnUpdt"
        Me.btnUpdt.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdt.TabIndex = 6
        Me.btnUpdt.Text = "UPDATE"
        Me.btnUpdt.UseVisualStyleBackColor = True
        '
        'lblDt
        '
        Me.lblDt.AutoSize = True
        Me.lblDt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDt.ForeColor = System.Drawing.Color.White
        Me.lblDt.Location = New System.Drawing.Point(24, 285)
        Me.lblDt.Name = "lblDt"
        Me.lblDt.Size = New System.Drawing.Size(37, 16)
        Me.lblDt.TabIndex = 3444
        Me.lblDt.Text = "Date"
        '
        'lblAm
        '
        Me.lblAm.AutoSize = True
        Me.lblAm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAm.ForeColor = System.Drawing.Color.White
        Me.lblAm.Location = New System.Drawing.Point(24, 232)
        Me.lblAm.Name = "lblAm"
        Me.lblAm.Size = New System.Drawing.Size(53, 16)
        Me.lblAm.TabIndex = 3443
        Me.lblAm.Text = "Amount"
        '
        'lblRn
        '
        Me.lblRn.AutoSize = True
        Me.lblRn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRn.ForeColor = System.Drawing.Color.White
        Me.lblRn.Location = New System.Drawing.Point(24, 182)
        Me.lblRn.Name = "lblRn"
        Me.lblRn.Size = New System.Drawing.Size(56, 16)
        Me.lblRn.TabIndex = 3442
        Me.lblRn.Text = "Reason"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTo.ForeColor = System.Drawing.Color.White
        Me.lblTo.Location = New System.Drawing.Point(24, 132)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(25, 16)
        Me.lblTo.TabIndex = 3441
        Me.lblTo.Text = "To"
        '
        'lblEi
        '
        Me.lblEi.AutoSize = True
        Me.lblEi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEi.ForeColor = System.Drawing.Color.White
        Me.lblEi.Location = New System.Drawing.Point(24, 84)
        Me.lblEi.Name = "lblEi"
        Me.lblEi.Size = New System.Drawing.Size(75, 16)
        Me.lblEi.TabIndex = 3448
        Me.lblEi.Text = "Expense id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(106, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 20)
        Me.Label1.TabIndex = 3440
        Me.Label1.Text = "Edit Expenses"
        '
        'btnDlt
        '
        Me.btnDlt.Location = New System.Drawing.Point(120, 358)
        Me.btnDlt.Name = "btnDlt"
        Me.btnDlt.Size = New System.Drawing.Size(75, 23)
        Me.btnDlt.TabIndex = 7
        Me.btnDlt.Text = "DELETE"
        Me.btnDlt.UseVisualStyleBackColor = True
        '
        'cmbEi
        '
        Me.cmbEi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEi.FormattingEnabled = True
        Me.cmbEi.Location = New System.Drawing.Point(141, 81)
        Me.cmbEi.Name = "cmbEi"
        Me.cmbEi.Size = New System.Drawing.Size(145, 24)
        Me.cmbEi.TabIndex = 1
        '
        'editExpenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(319, 407)
        Me.Controls.Add(Me.cmbEi)
        Me.Controls.Add(Me.btnDlt)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.txtRn)
        Me.Controls.Add(Me.txtAm)
        Me.Controls.Add(Me.btnBck)
        Me.Controls.Add(Me.btnUpdt)
        Me.Controls.Add(Me.lblDt)
        Me.Controls.Add(Me.lblAm)
        Me.Controls.Add(Me.lblRn)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.lblEi)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "editExpenses"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents txtTo As TextBox
    Friend WithEvents txtRn As TextBox
    Friend WithEvents txtAm As TextBox
    Friend WithEvents btnBck As Button
    Friend WithEvents btnUpdt As Button
    Friend WithEvents lblDt As Label
    Friend WithEvents lblAm As Label
    Friend WithEvents lblRn As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents lblEi As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDlt As Button
    Friend WithEvents cmbEi As ComboBox
End Class
