﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.Up = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.llRn = New System.Windows.Forms.LinkLabel()
        Me.llFp = New System.Windows.Forms.LinkLabel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblUn = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUm = New System.Windows.Forms.TextBox()
        Me.Up.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Up
        '
        Me.Up.BackColor = System.Drawing.Color.DodgerBlue
        Me.Up.Controls.Add(Me.lblTitle)
        Me.Up.Dock = System.Windows.Forms.DockStyle.Top
        Me.Up.Location = New System.Drawing.Point(0, 0)
        Me.Up.Name = "Up"
        Me.Up.Size = New System.Drawing.Size(568, 214)
        Me.Up.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(35, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(496, 79)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Ashroy Boys Hostel"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.llRn)
        Me.Panel1.Controls.Add(Me.llFp)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.lblPass)
        Me.Panel1.Controls.Add(Me.lblUn)
        Me.Panel1.Controls.Add(Me.txtPass)
        Me.Panel1.Controls.Add(Me.txtUm)
        Me.Panel1.Location = New System.Drawing.Point(126, 121)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(332, 399)
        Me.Panel1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Hostel_Management_Software.My.Resources.Resources.User
        Me.PictureBox1.Location = New System.Drawing.Point(118, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'llRn
        '
        Me.llRn.AutoSize = True
        Me.llRn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llRn.LinkColor = System.Drawing.Color.Purple
        Me.llRn.Location = New System.Drawing.Point(192, 345)
        Me.llRn.Name = "llRn"
        Me.llRn.Size = New System.Drawing.Size(105, 16)
        Me.llRn.TabIndex = 6
        Me.llRn.TabStop = True
        Me.llRn.Text = "Register Now!"
        '
        'llFp
        '
        Me.llFp.AutoSize = True
        Me.llFp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llFp.LinkColor = System.Drawing.Color.Red
        Me.llFp.Location = New System.Drawing.Point(47, 345)
        Me.llFp.Name = "llFp"
        Me.llFp.Size = New System.Drawing.Size(117, 16)
        Me.llFp.TabIndex = 5
        Me.llFp.TabStop = True
        Me.llFp.Text = "Forgot Password?"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Gold
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClear.Location = New System.Drawing.Point(206, 292)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(78, 32)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Green
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLogin.Location = New System.Drawing.Point(48, 292)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(84, 32)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblPass.Location = New System.Drawing.Point(45, 216)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(76, 16)
        Me.lblPass.TabIndex = 3
        Me.lblPass.Text = "Password"
        '
        'lblUn
        '
        Me.lblUn.AutoSize = True
        Me.lblUn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUn.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblUn.Location = New System.Drawing.Point(46, 154)
        Me.lblUn.Name = "lblUn"
        Me.lblUn.Size = New System.Drawing.Size(86, 16)
        Me.lblUn.TabIndex = 2
        Me.lblUn.Text = "User Name"
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.White
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(48, 244)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(236, 22)
        Me.txtPass.TabIndex = 2
        Me.txtPass.UseSystemPasswordChar = True
        '
        'txtUm
        '
        Me.txtUm.BackColor = System.Drawing.Color.White
        Me.txtUm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUm.Location = New System.Drawing.Point(48, 183)
        Me.txtUm.Name = "txtUm"
        Me.txtUm.Size = New System.Drawing.Size(236, 22)
        Me.txtUm.TabIndex = 1
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(568, 561)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Up)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Login"
        Me.Up.ResumeLayout(False)
        Me.Up.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Up As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUm As TextBox
    Friend WithEvents lblUn As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents llRn As LinkLabel
    Friend WithEvents llFp As LinkLabel
    Friend WithEvents btnClear As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblPass As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
