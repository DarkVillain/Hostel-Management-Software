<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changePass
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
        Me.txtMl = New System.Windows.Forms.TextBox()
        Me.lblMl = New System.Windows.Forms.Label()
        Me.txtCnPass = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUn = New System.Windows.Forms.TextBox()
        Me.lblCnPass = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblUn = New System.Windows.Forms.Label()
        Me.lblRf = New System.Windows.Forms.Label()
        Me.btnCng = New System.Windows.Forms.Button()
        Me.btnCnl = New System.Windows.Forms.Button()
        Me.txtFn = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPn = New System.Windows.Forms.TextBox()
        Me.lblPn = New System.Windows.Forms.Label()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.lblDob = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtMl
        '
        Me.txtMl.Location = New System.Drawing.Point(25, 155)
        Me.txtMl.Name = "txtMl"
        Me.txtMl.Size = New System.Drawing.Size(301, 20)
        Me.txtMl.TabIndex = 30
        '
        'lblMl
        '
        Me.lblMl.AutoSize = True
        Me.lblMl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMl.ForeColor = System.Drawing.Color.White
        Me.lblMl.Location = New System.Drawing.Point(23, 125)
        Me.lblMl.Name = "lblMl"
        Me.lblMl.Size = New System.Drawing.Size(52, 16)
        Me.lblMl.TabIndex = 29
        Me.lblMl.Text = "E-mail"
        '
        'txtCnPass
        '
        Me.txtCnPass.Location = New System.Drawing.Point(188, 341)
        Me.txtCnPass.Name = "txtCnPass"
        Me.txtCnPass.Size = New System.Drawing.Size(138, 20)
        Me.txtCnPass.TabIndex = 28
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(25, 341)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(117, 20)
        Me.txtPass.TabIndex = 27
        '
        'txtUn
        '
        Me.txtUn.Location = New System.Drawing.Point(25, 97)
        Me.txtUn.Name = "txtUn"
        Me.txtUn.Size = New System.Drawing.Size(301, 20)
        Me.txtUn.TabIndex = 26
        '
        'lblCnPass
        '
        Me.lblCnPass.AutoSize = True
        Me.lblCnPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCnPass.ForeColor = System.Drawing.Color.White
        Me.lblCnPass.Location = New System.Drawing.Point(185, 313)
        Me.lblCnPass.Name = "lblCnPass"
        Me.lblCnPass.Size = New System.Drawing.Size(132, 16)
        Me.lblCnPass.TabIndex = 25
        Me.lblCnPass.Text = "Confirm Password"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.ForeColor = System.Drawing.Color.White
        Me.lblPass.Location = New System.Drawing.Point(22, 313)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(110, 16)
        Me.lblPass.TabIndex = 24
        Me.lblPass.Text = "New Password"
        '
        'lblUn
        '
        Me.lblUn.AutoSize = True
        Me.lblUn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUn.ForeColor = System.Drawing.Color.White
        Me.lblUn.Location = New System.Drawing.Point(22, 68)
        Me.lblUn.Name = "lblUn"
        Me.lblUn.Size = New System.Drawing.Size(86, 16)
        Me.lblUn.TabIndex = 23
        Me.lblUn.Text = "User Name"
        '
        'lblRf
        '
        Me.lblRf.AutoSize = True
        Me.lblRf.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRf.ForeColor = System.Drawing.Color.White
        Me.lblRf.Location = New System.Drawing.Point(48, 9)
        Me.lblRf.Name = "lblRf"
        Me.lblRf.Size = New System.Drawing.Size(257, 26)
        Me.lblRf.TabIndex = 31
        Me.lblRf.Text = "Change Password Form"
        '
        'btnCng
        '
        Me.btnCng.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCng.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnCng.Location = New System.Drawing.Point(26, 413)
        Me.btnCng.Name = "btnCng"
        Me.btnCng.Size = New System.Drawing.Size(116, 30)
        Me.btnCng.TabIndex = 32
        Me.btnCng.Text = "Change"
        Me.btnCng.UseVisualStyleBackColor = True
        '
        'btnCnl
        '
        Me.btnCnl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCnl.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnCnl.Location = New System.Drawing.Point(210, 413)
        Me.btnCnl.Name = "btnCnl"
        Me.btnCnl.Size = New System.Drawing.Size(116, 30)
        Me.btnCnl.TabIndex = 33
        Me.btnCnl.Text = "Cancel"
        Me.btnCnl.UseVisualStyleBackColor = True
        '
        'txtFn
        '
        Me.txtFn.Location = New System.Drawing.Point(25, 276)
        Me.txtFn.Name = "txtFn"
        Me.txtFn.Size = New System.Drawing.Size(301, 20)
        Me.txtFn.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(28, 246)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "E-mail"
        '
        'txtPn
        '
        Me.txtPn.Location = New System.Drawing.Point(26, 217)
        Me.txtPn.Name = "txtPn"
        Me.txtPn.Size = New System.Drawing.Size(116, 20)
        Me.txtPn.TabIndex = 37
        '
        'lblPn
        '
        Me.lblPn.AutoSize = True
        Me.lblPn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPn.ForeColor = System.Drawing.Color.White
        Me.lblPn.Location = New System.Drawing.Point(24, 187)
        Me.lblPn.Name = "lblPn"
        Me.lblPn.Size = New System.Drawing.Size(80, 16)
        Me.lblPn.TabIndex = 36
        Me.lblPn.Text = "Phone No."
        '
        'dtp
        '
        Me.dtp.Location = New System.Drawing.Point(188, 217)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(138, 20)
        Me.dtp.TabIndex = 38
        '
        'lblDob
        '
        Me.lblDob.AutoSize = True
        Me.lblDob.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDob.ForeColor = System.Drawing.Color.White
        Me.lblDob.Location = New System.Drawing.Point(185, 187)
        Me.lblDob.Name = "lblDob"
        Me.lblDob.Size = New System.Drawing.Size(93, 16)
        Me.lblDob.TabIndex = 39
        Me.lblDob.Text = "Date of Birth"
        '
        'changePass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(348, 477)
        Me.Controls.Add(Me.lblDob)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.txtPn)
        Me.Controls.Add(Me.lblPn)
        Me.Controls.Add(Me.txtFn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCnl)
        Me.Controls.Add(Me.btnCng)
        Me.Controls.Add(Me.lblRf)
        Me.Controls.Add(Me.txtMl)
        Me.Controls.Add(Me.lblMl)
        Me.Controls.Add(Me.txtCnPass)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUn)
        Me.Controls.Add(Me.lblCnPass)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUn)
        Me.Name = "changePass"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMl As TextBox
    Friend WithEvents lblMl As Label
    Friend WithEvents txtCnPass As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUn As TextBox
    Friend WithEvents lblCnPass As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents lblUn As Label
    Friend WithEvents lblRf As Label
    Friend WithEvents btnCng As Button
    Friend WithEvents btnCnl As Button
    Friend WithEvents txtFn As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPn As TextBox
    Friend WithEvents lblPn As Label
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents lblDob As Label
End Class
