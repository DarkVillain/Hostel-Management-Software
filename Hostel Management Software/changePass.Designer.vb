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
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.txtCnPass = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUn = New System.Windows.Forms.TextBox()
        Me.lblCnPass = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblUn = New System.Windows.Forms.Label()
        Me.lblRf = New System.Windows.Forms.Label()
        Me.btnCng = New System.Windows.Forms.Button()
        Me.btnCnl = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(187, 146)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(363, 20)
        Me.txtMail.TabIndex = 30
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.ForeColor = System.Drawing.Color.White
        Me.lblMail.Location = New System.Drawing.Point(185, 116)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(52, 16)
        Me.lblMail.TabIndex = 29
        Me.lblMail.Text = "E-mail"
        '
        'txtCnPass
        '
        Me.txtCnPass.Location = New System.Drawing.Point(401, 279)
        Me.txtCnPass.Name = "txtCnPass"
        Me.txtCnPass.Size = New System.Drawing.Size(149, 20)
        Me.txtCnPass.TabIndex = 28
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(187, 279)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(149, 20)
        Me.txtPass.TabIndex = 27
        '
        'txtUn
        '
        Me.txtUn.Location = New System.Drawing.Point(187, 208)
        Me.txtUn.Name = "txtUn"
        Me.txtUn.Size = New System.Drawing.Size(363, 20)
        Me.txtUn.TabIndex = 26
        '
        'lblCnPass
        '
        Me.lblCnPass.AutoSize = True
        Me.lblCnPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCnPass.ForeColor = System.Drawing.Color.White
        Me.lblCnPass.Location = New System.Drawing.Point(398, 251)
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
        Me.lblPass.Location = New System.Drawing.Point(184, 251)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(76, 16)
        Me.lblPass.TabIndex = 24
        Me.lblPass.Text = "Password"
        '
        'lblUn
        '
        Me.lblUn.AutoSize = True
        Me.lblUn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUn.ForeColor = System.Drawing.Color.White
        Me.lblUn.Location = New System.Drawing.Point(184, 179)
        Me.lblUn.Name = "lblUn"
        Me.lblUn.Size = New System.Drawing.Size(82, 16)
        Me.lblUn.TabIndex = 23
        Me.lblUn.Text = "UserName"
        '
        'lblRf
        '
        Me.lblRf.AutoSize = True
        Me.lblRf.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRf.ForeColor = System.Drawing.Color.White
        Me.lblRf.Location = New System.Drawing.Point(241, 9)
        Me.lblRf.Name = "lblRf"
        Me.lblRf.Size = New System.Drawing.Size(257, 26)
        Me.lblRf.TabIndex = 31
        Me.lblRf.Text = "Change Password Form"
        '
        'btnCng
        '
        Me.btnCng.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCng.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnCng.Location = New System.Drawing.Point(187, 382)
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
        Me.btnCnl.Location = New System.Drawing.Point(433, 382)
        Me.btnCnl.Name = "btnCnl"
        Me.btnCnl.Size = New System.Drawing.Size(116, 30)
        Me.btnCnl.TabIndex = 33
        Me.btnCnl.Text = "Cancel"
        Me.btnCnl.UseVisualStyleBackColor = True
        '
        'changePass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(800, 521)
        Me.Controls.Add(Me.btnCnl)
        Me.Controls.Add(Me.btnCng)
        Me.Controls.Add(Me.lblRf)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.txtCnPass)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUn)
        Me.Controls.Add(Me.lblCnPass)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUn)
        Me.Name = "changePass"
        Me.Text = "changePass"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMail As TextBox
    Friend WithEvents lblMail As Label
    Friend WithEvents txtCnPass As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUn As TextBox
    Friend WithEvents lblCnPass As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents lblUn As Label
    Friend WithEvents lblRf As Label
    Friend WithEvents btnCng As Button
    Friend WithEvents btnCnl As Button
End Class
