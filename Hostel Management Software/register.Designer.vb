<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblFn = New System.Windows.Forms.Label()
        Me.lblUn = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblCnPass = New System.Windows.Forms.Label()
        Me.lblGnd = New System.Windows.Forms.Label()
        Me.lblDob = New System.Windows.Forms.Label()
        Me.lblPn = New System.Windows.Forms.Label()
        Me.lblRf = New System.Windows.Forms.Label()
        Me.txtFn = New System.Windows.Forms.TextBox()
        Me.txtUn = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtCnPass = New System.Windows.Forms.TextBox()
        Me.dtpDob = New System.Windows.Forms.DateTimePicker()
        Me.txtPn = New System.Windows.Forms.TextBox()
        Me.btnReg = New System.Windows.Forms.Button()
        Me.lblMl = New System.Windows.Forms.Label()
        Me.txtMl = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtOr = New System.Windows.Forms.Label()
        Me.cmbGnd = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblFn
        '
        Me.lblFn.AutoSize = True
        Me.lblFn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFn.ForeColor = System.Drawing.Color.White
        Me.lblFn.Location = New System.Drawing.Point(30, 214)
        Me.lblFn.Name = "lblFn"
        Me.lblFn.Size = New System.Drawing.Size(78, 16)
        Me.lblFn.TabIndex = 0
        Me.lblFn.Text = "Full Name"
        '
        'lblUn
        '
        Me.lblUn.AutoSize = True
        Me.lblUn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUn.ForeColor = System.Drawing.Color.White
        Me.lblUn.Location = New System.Drawing.Point(27, 81)
        Me.lblUn.Name = "lblUn"
        Me.lblUn.Size = New System.Drawing.Size(86, 16)
        Me.lblUn.TabIndex = 2
        Me.lblUn.Text = "User Name"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.ForeColor = System.Drawing.Color.White
        Me.lblPass.Location = New System.Drawing.Point(27, 151)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(110, 16)
        Me.lblPass.TabIndex = 3
        Me.lblPass.Text = "New Password"
        '
        'lblCnPass
        '
        Me.lblCnPass.AutoSize = True
        Me.lblCnPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCnPass.ForeColor = System.Drawing.Color.White
        Me.lblCnPass.Location = New System.Drawing.Point(241, 151)
        Me.lblCnPass.Name = "lblCnPass"
        Me.lblCnPass.Size = New System.Drawing.Size(132, 16)
        Me.lblCnPass.TabIndex = 4
        Me.lblCnPass.Text = "Confirm Password"
        '
        'lblGnd
        '
        Me.lblGnd.AutoSize = True
        Me.lblGnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGnd.ForeColor = System.Drawing.Color.White
        Me.lblGnd.Location = New System.Drawing.Point(28, 279)
        Me.lblGnd.Name = "lblGnd"
        Me.lblGnd.Size = New System.Drawing.Size(59, 16)
        Me.lblGnd.TabIndex = 5
        Me.lblGnd.Text = "Gender"
        '
        'lblDob
        '
        Me.lblDob.AutoSize = True
        Me.lblDob.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDob.ForeColor = System.Drawing.Color.White
        Me.lblDob.Location = New System.Drawing.Point(241, 283)
        Me.lblDob.Name = "lblDob"
        Me.lblDob.Size = New System.Drawing.Size(93, 16)
        Me.lblDob.TabIndex = 6
        Me.lblDob.Text = "Date of Birth"
        '
        'lblPn
        '
        Me.lblPn.AutoSize = True
        Me.lblPn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPn.ForeColor = System.Drawing.Color.White
        Me.lblPn.Location = New System.Drawing.Point(27, 342)
        Me.lblPn.Name = "lblPn"
        Me.lblPn.Size = New System.Drawing.Size(80, 16)
        Me.lblPn.TabIndex = 7
        Me.lblPn.Text = "Phone No."
        '
        'lblRf
        '
        Me.lblRf.AutoSize = True
        Me.lblRf.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRf.ForeColor = System.Drawing.Color.White
        Me.lblRf.Location = New System.Drawing.Point(111, 11)
        Me.lblRf.Name = "lblRf"
        Me.lblRf.Size = New System.Drawing.Size(202, 26)
        Me.lblRf.TabIndex = 8
        Me.lblRf.Text = "Registration Form"
        '
        'txtFn
        '
        Me.txtFn.Location = New System.Drawing.Point(32, 245)
        Me.txtFn.Name = "txtFn"
        Me.txtFn.Size = New System.Drawing.Size(363, 20)
        Me.txtFn.TabIndex = 10
        '
        'txtUn
        '
        Me.txtUn.Location = New System.Drawing.Point(30, 110)
        Me.txtUn.Name = "txtUn"
        Me.txtUn.Size = New System.Drawing.Size(363, 20)
        Me.txtUn.TabIndex = 12
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(30, 179)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(149, 20)
        Me.txtPass.TabIndex = 13
        '
        'txtCnPass
        '
        Me.txtCnPass.Location = New System.Drawing.Point(244, 179)
        Me.txtCnPass.Name = "txtCnPass"
        Me.txtCnPass.Size = New System.Drawing.Size(149, 20)
        Me.txtCnPass.TabIndex = 14
        '
        'dtpDob
        '
        Me.dtpDob.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDob.Location = New System.Drawing.Point(244, 309)
        Me.dtpDob.Name = "dtpDob"
        Me.dtpDob.Size = New System.Drawing.Size(149, 20)
        Me.dtpDob.TabIndex = 17
        '
        'txtPn
        '
        Me.txtPn.Location = New System.Drawing.Point(30, 371)
        Me.txtPn.Name = "txtPn"
        Me.txtPn.Size = New System.Drawing.Size(363, 20)
        Me.txtPn.TabIndex = 18
        '
        'btnReg
        '
        Me.btnReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReg.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnReg.Location = New System.Drawing.Point(32, 483)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(116, 30)
        Me.btnReg.TabIndex = 19
        Me.btnReg.Text = "Register"
        Me.btnReg.UseVisualStyleBackColor = True
        '
        'lblMl
        '
        Me.lblMl.AutoSize = True
        Me.lblMl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMl.ForeColor = System.Drawing.Color.White
        Me.lblMl.Location = New System.Drawing.Point(30, 403)
        Me.lblMl.Name = "lblMl"
        Me.lblMl.Size = New System.Drawing.Size(52, 16)
        Me.lblMl.TabIndex = 21
        Me.lblMl.Text = "E-mail"
        '
        'txtMl
        '
        Me.txtMl.Location = New System.Drawing.Point(32, 433)
        Me.txtMl.Name = "txtMl"
        Me.txtMl.Size = New System.Drawing.Size(363, 20)
        Me.txtMl.TabIndex = 22
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnLogin.Location = New System.Drawing.Point(279, 483)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(116, 30)
        Me.btnLogin.TabIndex = 23
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtOr
        '
        Me.txtOr.AutoSize = True
        Me.txtOr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOr.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtOr.Location = New System.Drawing.Point(199, 490)
        Me.txtOr.Name = "txtOr"
        Me.txtOr.Size = New System.Drawing.Size(20, 16)
        Me.txtOr.TabIndex = 24
        Me.txtOr.Text = "or"
        '
        'cmbGnd
        '
        Me.cmbGnd.FormattingEnabled = True
        Me.cmbGnd.Items.AddRange(New Object() {"Male", "Female", "Others"})
        Me.cmbGnd.Location = New System.Drawing.Point(32, 308)
        Me.cmbGnd.Name = "cmbGnd"
        Me.cmbGnd.Size = New System.Drawing.Size(148, 21)
        Me.cmbGnd.TabIndex = 25
        '
        'register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(419, 525)
        Me.Controls.Add(Me.cmbGnd)
        Me.Controls.Add(Me.txtOr)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtMl)
        Me.Controls.Add(Me.lblMl)
        Me.Controls.Add(Me.btnReg)
        Me.Controls.Add(Me.txtPn)
        Me.Controls.Add(Me.dtpDob)
        Me.Controls.Add(Me.txtCnPass)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUn)
        Me.Controls.Add(Me.txtFn)
        Me.Controls.Add(Me.lblRf)
        Me.Controls.Add(Me.lblPn)
        Me.Controls.Add(Me.lblDob)
        Me.Controls.Add(Me.lblGnd)
        Me.Controls.Add(Me.lblCnPass)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUn)
        Me.Controls.Add(Me.lblFn)
        Me.Name = "register"
        Me.Text = "Register Now!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFn As Label
    Friend WithEvents lblUn As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents lblCnPass As Label
    Friend WithEvents lblGnd As Label
    Friend WithEvents lblDob As Label
    Friend WithEvents lblPn As Label
    Friend WithEvents lblRf As Label
    Friend WithEvents txtFn As TextBox
    Friend WithEvents txtUn As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtCnPass As TextBox
    Friend WithEvents dtpDob As DateTimePicker
    Friend WithEvents txtPn As TextBox
    Friend WithEvents btnReg As Button
    Friend WithEvents lblMl As Label
    Friend WithEvents txtMl As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtOr As Label
    Friend WithEvents cmbGnd As ComboBox
End Class
