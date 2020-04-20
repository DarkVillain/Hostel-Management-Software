<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addExpenses
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblEi = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblRn = New System.Windows.Forms.Label()
        Me.lblAm = New System.Windows.Forms.Label()
        Me.lblDt = New System.Windows.Forms.Label()
        Me.txtEi = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnBck = New System.Windows.Forms.Button()
        Me.txtAm = New System.Windows.Forms.TextBox()
        Me.txtRn = New System.Windows.Forms.TextBox()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(107, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Expenses"
        '
        'lblEi
        '
        Me.lblEi.AutoSize = True
        Me.lblEi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEi.ForeColor = System.Drawing.Color.White
        Me.lblEi.Location = New System.Drawing.Point(25, 80)
        Me.lblEi.Name = "lblEi"
        Me.lblEi.Size = New System.Drawing.Size(75, 16)
        Me.lblEi.TabIndex = 3434
        Me.lblEi.Text = "Expense id"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTo.ForeColor = System.Drawing.Color.White
        Me.lblTo.Location = New System.Drawing.Point(25, 128)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(25, 16)
        Me.lblTo.TabIndex = 2
        Me.lblTo.Text = "To"
        '
        'lblRn
        '
        Me.lblRn.AutoSize = True
        Me.lblRn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRn.ForeColor = System.Drawing.Color.White
        Me.lblRn.Location = New System.Drawing.Point(25, 178)
        Me.lblRn.Name = "lblRn"
        Me.lblRn.Size = New System.Drawing.Size(56, 16)
        Me.lblRn.TabIndex = 3
        Me.lblRn.Text = "Reason"
        '
        'lblAm
        '
        Me.lblAm.AutoSize = True
        Me.lblAm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAm.ForeColor = System.Drawing.Color.White
        Me.lblAm.Location = New System.Drawing.Point(25, 228)
        Me.lblAm.Name = "lblAm"
        Me.lblAm.Size = New System.Drawing.Size(53, 16)
        Me.lblAm.TabIndex = 4
        Me.lblAm.Text = "Amount"
        '
        'lblDt
        '
        Me.lblDt.AutoSize = True
        Me.lblDt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDt.ForeColor = System.Drawing.Color.White
        Me.lblDt.Location = New System.Drawing.Point(25, 281)
        Me.lblDt.Name = "lblDt"
        Me.lblDt.Size = New System.Drawing.Size(37, 16)
        Me.lblDt.TabIndex = 5
        Me.lblDt.Text = "Date"
        '
        'txtEi
        '
        Me.txtEi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEi.Location = New System.Drawing.Point(142, 77)
        Me.txtEi.Name = "txtEi"
        Me.txtEi.Size = New System.Drawing.Size(147, 22)
        Me.txtEi.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(43, 345)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnBck
        '
        Me.btnBck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBck.Location = New System.Drawing.Point(176, 345)
        Me.btnBck.Name = "btnBck"
        Me.btnBck.Size = New System.Drawing.Size(75, 23)
        Me.btnBck.TabIndex = 7
        Me.btnBck.Text = "BACK"
        Me.btnBck.UseVisualStyleBackColor = True
        '
        'txtAm
        '
        Me.txtAm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAm.Location = New System.Drawing.Point(142, 225)
        Me.txtAm.Name = "txtAm"
        Me.txtAm.Size = New System.Drawing.Size(147, 22)
        Me.txtAm.TabIndex = 4
        '
        'txtRn
        '
        Me.txtRn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRn.Location = New System.Drawing.Point(142, 178)
        Me.txtRn.Name = "txtRn"
        Me.txtRn.Size = New System.Drawing.Size(147, 22)
        Me.txtRn.TabIndex = 3
        '
        'txtTo
        '
        Me.txtTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTo.Location = New System.Drawing.Point(142, 128)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(147, 22)
        Me.txtTo.TabIndex = 2
        '
        'dtp
        '
        Me.dtp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp.Location = New System.Drawing.Point(142, 281)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(147, 22)
        Me.dtp.TabIndex = 5
        '
        'addExpenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(329, 396)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.txtRn)
        Me.Controls.Add(Me.txtAm)
        Me.Controls.Add(Me.btnBck)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtEi)
        Me.Controls.Add(Me.lblDt)
        Me.Controls.Add(Me.lblAm)
        Me.Controls.Add(Me.lblRn)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.lblEi)
        Me.Controls.Add(Me.Label1)
        Me.Name = "addExpenses"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblEi As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents lblRn As Label
    Friend WithEvents lblAm As Label
    Friend WithEvents lblDt As Label
    Friend WithEvents txtEi As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnBck As Button
    Friend WithEvents txtAm As TextBox
    Friend WithEvents txtRn As TextBox
    Friend WithEvents txtTo As TextBox
    Friend WithEvents dtp As DateTimePicker
End Class
