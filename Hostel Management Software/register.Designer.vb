<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
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
        Me.lblFn = New System.Windows.Forms.Label()
        Me.lblLn = New System.Windows.Forms.Label()
        Me.lblUn = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblCnPass = New System.Windows.Forms.Label()
        Me.lblGnd = New System.Windows.Forms.Label()
        Me.lblDob = New System.Windows.Forms.Label()
        Me.lblPn = New System.Windows.Forms.Label()
        Me.lblRf = New System.Windows.Forms.Label()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.txtFn = New System.Windows.Forms.TextBox()
        Me.txtLn = New System.Windows.Forms.TextBox()
        Me.txtUn = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtCnPass = New System.Windows.Forms.TextBox()
        Me.rbMl = New System.Windows.Forms.RadioButton()
        Me.dtpDob = New System.Windows.Forms.DateTimePicker()
        Me.txtPn = New System.Windows.Forms.TextBox()
        Me.btnReg = New System.Windows.Forms.Button()
        Me.rbFl = New System.Windows.Forms.RadioButton()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtOr = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFn
        '
        Me.lblFn.AutoSize = True
        Me.lblFn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFn.ForeColor = System.Drawing.Color.White
        Me.lblFn.Location = New System.Drawing.Point(78, 84)
        Me.lblFn.Name = "lblFn"
        Me.lblFn.Size = New System.Drawing.Size(83, 16)
        Me.lblFn.TabIndex = 0
        Me.lblFn.Text = "First Name"
        '
        'lblLn
        '
        Me.lblLn.AutoSize = True
        Me.lblLn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLn.ForeColor = System.Drawing.Color.White
        Me.lblLn.Location = New System.Drawing.Point(292, 84)
        Me.lblLn.Name = "lblLn"
        Me.lblLn.Size = New System.Drawing.Size(82, 16)
        Me.lblLn.TabIndex = 1
        Me.lblLn.Text = "Last Name"
        '
        'lblUn
        '
        Me.lblUn.AutoSize = True
        Me.lblUn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUn.ForeColor = System.Drawing.Color.White
        Me.lblUn.Location = New System.Drawing.Point(77, 213)
        Me.lblUn.Name = "lblUn"
        Me.lblUn.Size = New System.Drawing.Size(82, 16)
        Me.lblUn.TabIndex = 2
        Me.lblUn.Text = "UserName"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.ForeColor = System.Drawing.Color.White
        Me.lblPass.Location = New System.Drawing.Point(77, 285)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(76, 16)
        Me.lblPass.TabIndex = 3
        Me.lblPass.Text = "Password"
        '
        'lblCnPass
        '
        Me.lblCnPass.AutoSize = True
        Me.lblCnPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCnPass.ForeColor = System.Drawing.Color.White
        Me.lblCnPass.Location = New System.Drawing.Point(291, 285)
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
        Me.lblGnd.Location = New System.Drawing.Point(77, 349)
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
        Me.lblDob.Location = New System.Drawing.Point(291, 349)
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
        Me.lblPn.Location = New System.Drawing.Point(77, 415)
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
        Me.lblRf.Location = New System.Drawing.Point(163, 19)
        Me.lblRf.Name = "lblRf"
        Me.lblRf.Size = New System.Drawing.Size(202, 26)
        Me.lblRf.TabIndex = 8
        Me.lblRf.Text = "Registration Form"
        '
        'lblExit
        '
        Me.lblExit.AutoSize = True
        Me.lblExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.ForeColor = System.Drawing.Color.White
        Me.lblExit.Location = New System.Drawing.Point(501, 19)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(17, 16)
        Me.lblExit.TabIndex = 9
        Me.lblExit.Text = "X"
        '
        'txtFn
        '
        Me.txtFn.Location = New System.Drawing.Point(80, 115)
        Me.txtFn.Name = "txtFn"
        Me.txtFn.Size = New System.Drawing.Size(149, 20)
        Me.txtFn.TabIndex = 10
        '
        'txtLn
        '
        Me.txtLn.Location = New System.Drawing.Point(295, 115)
        Me.txtLn.Name = "txtLn"
        Me.txtLn.Size = New System.Drawing.Size(149, 20)
        Me.txtLn.TabIndex = 11
        '
        'txtUn
        '
        Me.txtUn.Location = New System.Drawing.Point(80, 242)
        Me.txtUn.Name = "txtUn"
        Me.txtUn.Size = New System.Drawing.Size(363, 20)
        Me.txtUn.TabIndex = 12
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(80, 313)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(149, 20)
        Me.txtPass.TabIndex = 13
        '
        'txtCnPass
        '
        Me.txtCnPass.Location = New System.Drawing.Point(294, 313)
        Me.txtCnPass.Name = "txtCnPass"
        Me.txtCnPass.Size = New System.Drawing.Size(149, 20)
        Me.txtCnPass.TabIndex = 14
        '
        'rbMl
        '
        Me.rbMl.AutoSize = True
        Me.rbMl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rbMl.Location = New System.Drawing.Point(80, 378)
        Me.rbMl.Name = "rbMl"
        Me.rbMl.Size = New System.Drawing.Size(60, 20)
        Me.rbMl.TabIndex = 15
        Me.rbMl.TabStop = True
        Me.rbMl.Text = "Male"
        Me.rbMl.UseVisualStyleBackColor = True
        '
        'dtpDob
        '
        Me.dtpDob.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDob.Location = New System.Drawing.Point(294, 375)
        Me.dtpDob.Name = "dtpDob"
        Me.dtpDob.Size = New System.Drawing.Size(149, 20)
        Me.dtpDob.TabIndex = 17
        '
        'txtPn
        '
        Me.txtPn.Location = New System.Drawing.Point(80, 444)
        Me.txtPn.Name = "txtPn"
        Me.txtPn.Size = New System.Drawing.Size(363, 20)
        Me.txtPn.TabIndex = 18
        '
        'btnReg
        '
        Me.btnReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReg.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnReg.Location = New System.Drawing.Point(81, 483)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(116, 30)
        Me.btnReg.TabIndex = 19
        Me.btnReg.Text = "Register"
        Me.btnReg.UseVisualStyleBackColor = True
        '
        'rbFl
        '
        Me.rbFl.AutoSize = True
        Me.rbFl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rbFl.Location = New System.Drawing.Point(156, 378)
        Me.rbFl.Name = "rbFl"
        Me.rbFl.Size = New System.Drawing.Size(78, 20)
        Me.rbFl.TabIndex = 20
        Me.rbFl.TabStop = True
        Me.rbFl.Text = "Female"
        Me.rbFl.UseVisualStyleBackColor = True
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.ForeColor = System.Drawing.Color.White
        Me.lblMail.Location = New System.Drawing.Point(78, 150)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(52, 16)
        Me.lblMail.TabIndex = 21
        Me.lblMail.Text = "E-mail"
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(80, 180)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(363, 20)
        Me.txtMail.TabIndex = 22
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnLogin.Location = New System.Drawing.Point(328, 483)
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
        Me.txtOr.Location = New System.Drawing.Point(243, 492)
        Me.txtOr.Name = "txtOr"
        Me.txtOr.Size = New System.Drawing.Size(20, 16)
        Me.txtOr.TabIndex = 24
        Me.txtOr.Text = "or"
        '
        'register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(530, 525)
        Me.Controls.Add(Me.txtOr)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.rbFl)
        Me.Controls.Add(Me.btnReg)
        Me.Controls.Add(Me.txtPn)
        Me.Controls.Add(Me.dtpDob)
        Me.Controls.Add(Me.rbMl)
        Me.Controls.Add(Me.txtCnPass)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUn)
        Me.Controls.Add(Me.txtLn)
        Me.Controls.Add(Me.txtFn)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.lblRf)
        Me.Controls.Add(Me.lblPn)
        Me.Controls.Add(Me.lblDob)
        Me.Controls.Add(Me.lblGnd)
        Me.Controls.Add(Me.lblCnPass)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUn)
        Me.Controls.Add(Me.lblLn)
        Me.Controls.Add(Me.lblFn)
        Me.Name = "register"
        Me.Text = "Register Now!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFn As Label
    Friend WithEvents lblLn As Label
    Friend WithEvents lblUn As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents lblCnPass As Label
    Friend WithEvents lblGnd As Label
    Friend WithEvents lblDob As Label
    Friend WithEvents lblPn As Label
    Friend WithEvents lblRf As Label
    Friend WithEvents lblExit As Label
    Friend WithEvents txtFn As TextBox
    Friend WithEvents txtLn As TextBox
    Friend WithEvents txtUn As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtCnPass As TextBox
    Friend WithEvents rbMl As RadioButton
    Friend WithEvents dtpDob As DateTimePicker
    Friend WithEvents txtPn As TextBox
    Friend WithEvents btnReg As Button
    Friend WithEvents rbFl As RadioButton
    Friend WithEvents lblMail As Label
    Friend WithEvents txtMail As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtOr As Label
End Class
