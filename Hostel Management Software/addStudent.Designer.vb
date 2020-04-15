<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addStudent
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
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblAr = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.cmbYr = New System.Windows.Forms.ComboBox()
        Me.cmbAr = New System.Windows.Forms.ComboBox()
        Me.txtFn = New System.Windows.Forms.TextBox()
        Me.txtNm = New System.Windows.Forms.TextBox()
        Me.txtRn = New System.Windows.Forms.TextBox()
        Me.btnBck = New System.Windows.Forms.Button()
        Me.txtAdrs = New System.Windows.Forms.TextBox()
        Me.txtPn = New System.Windows.Forms.TextBox()
        Me.txtMl = New System.Windows.Forms.TextBox()
        Me.lblPn = New System.Windows.Forms.Label()
        Me.lblMl = New System.Windows.Forms.Label()
        Me.lblAdrs = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblInfo.Location = New System.Drawing.Point(84, 9)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(234, 24)
        Me.lblInfo.TabIndex = 0
        Me.lblInfo.Text = "Add Student Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(25, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Registration No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(25, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(27, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Class"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(27, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Date"
        '
        'lblAr
        '
        Me.lblAr.AutoSize = True
        Me.lblAr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAr.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAr.Location = New System.Drawing.Point(27, 263)
        Me.lblAr.Name = "lblAr"
        Me.lblAr.Size = New System.Drawing.Size(113, 16)
        Me.lblAr.TabIndex = 5
        Me.lblAr.Text = "Aallocated Room"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(25, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Fathers Name"
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(243, 477)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dtp
        '
        Me.dtp.Location = New System.Drawing.Point(147, 220)
        Me.dtp.Name = "dtp"
        Me.dtp.ShowCheckBox = True
        Me.dtp.Size = New System.Drawing.Size(233, 20)
        Me.dtp.TabIndex = 8
        '
        'cmbYr
        '
        Me.cmbYr.FormattingEnabled = True
        Me.cmbYr.Items.AddRange(New Object() {"8", "9", "10", "11", "12"})
        Me.cmbYr.Location = New System.Drawing.Point(147, 178)
        Me.cmbYr.Name = "cmbYr"
        Me.cmbYr.Size = New System.Drawing.Size(233, 21)
        Me.cmbYr.TabIndex = 9
        '
        'cmbAr
        '
        Me.cmbAr.FormattingEnabled = True
        Me.cmbAr.Items.AddRange(New Object() {"A0", "A1", "A2", "A3", "A5", "A6", "A7", "A8", "A9", "B0", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9"})
        Me.cmbAr.Location = New System.Drawing.Point(147, 260)
        Me.cmbAr.Name = "cmbAr"
        Me.cmbAr.Size = New System.Drawing.Size(233, 21)
        Me.cmbAr.TabIndex = 10
        '
        'txtFn
        '
        Me.txtFn.Location = New System.Drawing.Point(147, 136)
        Me.txtFn.Name = "txtFn"
        Me.txtFn.Size = New System.Drawing.Size(233, 20)
        Me.txtFn.TabIndex = 11
        '
        'txtNm
        '
        Me.txtNm.Location = New System.Drawing.Point(147, 97)
        Me.txtNm.Name = "txtNm"
        Me.txtNm.Size = New System.Drawing.Size(233, 20)
        Me.txtNm.TabIndex = 12
        '
        'txtRn
        '
        Me.txtRn.Location = New System.Drawing.Point(147, 58)
        Me.txtRn.Name = "txtRn"
        Me.txtRn.Size = New System.Drawing.Size(233, 20)
        Me.txtRn.TabIndex = 13
        '
        'btnBck
        '
        Me.btnBck.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBck.Location = New System.Drawing.Point(74, 477)
        Me.btnBck.Name = "btnBck"
        Me.btnBck.Size = New System.Drawing.Size(75, 23)
        Me.btnBck.TabIndex = 14
        Me.btnBck.Text = "Back"
        Me.btnBck.UseVisualStyleBackColor = True
        '
        'txtAdrs
        '
        Me.txtAdrs.Location = New System.Drawing.Point(145, 302)
        Me.txtAdrs.Multiline = True
        Me.txtAdrs.Name = "txtAdrs"
        Me.txtAdrs.Size = New System.Drawing.Size(235, 49)
        Me.txtAdrs.TabIndex = 18
        '
        'txtPn
        '
        Me.txtPn.Location = New System.Drawing.Point(145, 370)
        Me.txtPn.Name = "txtPn"
        Me.txtPn.Size = New System.Drawing.Size(235, 20)
        Me.txtPn.TabIndex = 19
        '
        'txtMl
        '
        Me.txtMl.Location = New System.Drawing.Point(145, 405)
        Me.txtMl.Name = "txtMl"
        Me.txtMl.Size = New System.Drawing.Size(235, 20)
        Me.txtMl.TabIndex = 20
        '
        'lblPn
        '
        Me.lblPn.AutoSize = True
        Me.lblPn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPn.Location = New System.Drawing.Point(25, 370)
        Me.lblPn.Name = "lblPn"
        Me.lblPn.Size = New System.Drawing.Size(71, 16)
        Me.lblPn.TabIndex = 21
        Me.lblPn.Text = "Phone No."
        '
        'lblMl
        '
        Me.lblMl.AutoSize = True
        Me.lblMl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMl.Location = New System.Drawing.Point(27, 405)
        Me.lblMl.Name = "lblMl"
        Me.lblMl.Size = New System.Drawing.Size(50, 16)
        Me.lblMl.TabIndex = 22
        Me.lblMl.Text = "Mail id."
        '
        'lblAdrs
        '
        Me.lblAdrs.AutoSize = True
        Me.lblAdrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdrs.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAdrs.Location = New System.Drawing.Point(27, 302)
        Me.lblAdrs.Name = "lblAdrs"
        Me.lblAdrs.Size = New System.Drawing.Size(59, 16)
        Me.lblAdrs.TabIndex = 23
        Me.lblAdrs.Text = "Address"
        '
        'addStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(401, 512)
        Me.Controls.Add(Me.lblAdrs)
        Me.Controls.Add(Me.lblMl)
        Me.Controls.Add(Me.lblPn)
        Me.Controls.Add(Me.txtMl)
        Me.Controls.Add(Me.txtPn)
        Me.Controls.Add(Me.txtAdrs)
        Me.Controls.Add(Me.btnBck)
        Me.Controls.Add(Me.txtRn)
        Me.Controls.Add(Me.txtNm)
        Me.Controls.Add(Me.txtFn)
        Me.Controls.Add(Me.cmbAr)
        Me.Controls.Add(Me.cmbYr)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAr)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblInfo)
        Me.Name = "addStudent"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInfo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblAr As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents cmbYr As ComboBox
    Friend WithEvents cmbAr As ComboBox
    Friend WithEvents txtFn As TextBox
    Friend WithEvents txtNm As TextBox
    Friend WithEvents txtRn As TextBox
    Friend WithEvents btnBck As Button
    Friend WithEvents ofgUp As OpenFileDialog
    Friend WithEvents txtAdrs As TextBox
    Friend WithEvents txtPn As TextBox
    Friend WithEvents txtMl As TextBox
    Friend WithEvents lblPn As Label
    Friend WithEvents lblMl As Label
    Friend WithEvents lblAdrs As Label
End Class
