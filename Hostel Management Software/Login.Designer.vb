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
        Me.llCP = New System.Windows.Forms.LinkLabel()
        Me.llFP = New System.Windows.Forms.LinkLabel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClr = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtBoxPass = New System.Windows.Forms.TextBox()
        Me.txtBoxName = New System.Windows.Forms.TextBox()
        Me.Up.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Up
        '
        Me.Up.BackColor = System.Drawing.Color.DodgerBlue
        Me.Up.Controls.Add(Me.lblTitle)
        Me.Up.Dock = System.Windows.Forms.DockStyle.Top
        Me.Up.Location = New System.Drawing.Point(0, 0)
        Me.Up.Name = "Up"
        Me.Up.Size = New System.Drawing.Size(1366, 260)
        Me.Up.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(213, 59)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(321, 32)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Ashroy Boys Hostel"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.llCP)
        Me.Panel1.Controls.Add(Me.llFP)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnClr)
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.lblPass)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.txtBoxPass)
        Me.Panel1.Controls.Add(Me.txtBoxName)
        Me.Panel1.Location = New System.Drawing.Point(481, 181)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(332, 335)
        Me.Panel1.TabIndex = 3
        '
        'llCP
        '
        Me.llCP.AutoSize = True
        Me.llCP.Location = New System.Drawing.Point(193, 284)
        Me.llCP.Name = "llCP"
        Me.llCP.Size = New System.Drawing.Size(93, 13)
        Me.llCP.TabIndex = 8
        Me.llCP.TabStop = True
        Me.llCP.Text = "Change Password"
        '
        'llFP
        '
        Me.llFP.AutoSize = True
        Me.llFP.Location = New System.Drawing.Point(48, 284)
        Me.llFP.Name = "llFP"
        Me.llFP.Size = New System.Drawing.Size(92, 13)
        Me.llFP.TabIndex = 7
        Me.llFP.TabStop = True
        Me.llFP.Text = "Forgot Password?"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(211, 231)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnClr
        '
        Me.btnClr.BackColor = System.Drawing.Color.Gold
        Me.btnClr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClr.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClr.Location = New System.Drawing.Point(130, 231)
        Me.btnClr.Name = "btnClr"
        Me.btnClr.Size = New System.Drawing.Size(75, 23)
        Me.btnClr.TabIndex = 5
        Me.btnClr.Text = "Clear"
        Me.btnClr.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Green
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLogin.Location = New System.Drawing.Point(49, 231)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblPass.Location = New System.Drawing.Point(46, 155)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(68, 16)
        Me.lblPass.TabIndex = 3
        Me.lblPass.Text = "Password"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblName.Location = New System.Drawing.Point(47, 93)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(77, 16)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "User Name"
        '
        'txtBoxPass
        '
        Me.txtBoxPass.BackColor = System.Drawing.Color.White
        Me.txtBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoxPass.Location = New System.Drawing.Point(49, 183)
        Me.txtBoxPass.Name = "txtBoxPass"
        Me.txtBoxPass.Size = New System.Drawing.Size(236, 20)
        Me.txtBoxPass.TabIndex = 1
        Me.txtBoxPass.UseSystemPasswordChar = True
        '
        'txtBoxName
        '
        Me.txtBoxName.BackColor = System.Drawing.Color.White
        Me.txtBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoxName.Location = New System.Drawing.Point(49, 122)
        Me.txtBoxName.Name = "txtBoxName"
        Me.txtBoxName.Size = New System.Drawing.Size(236, 20)
        Me.txtBoxName.TabIndex = 0
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Up)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.Text = "Form1"
        Me.Up.ResumeLayout(False)
        Me.Up.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Up As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtBoxPass As TextBox
    Friend WithEvents txtBoxName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents llCP As LinkLabel
    Friend WithEvents llFP As LinkLabel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClr As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblPass As Label
End Class