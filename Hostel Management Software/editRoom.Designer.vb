﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class editRoom
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
        Me.lblRN = New System.Windows.Forms.Label()
        Me.lblRT = New System.Windows.Forms.Label()
        Me.lblPC = New System.Windows.Forms.Label()
        Me.txtPC = New System.Windows.Forms.TextBox()
        Me.cmbRN = New System.Windows.Forms.ComboBox()
        Me.cmbRT = New System.Windows.Forms.ComboBox()
        Me.btnUPDT = New System.Windows.Forms.Button()
        Me.btnDLT = New System.Windows.Forms.Button()
        Me.btnBCK = New System.Windows.Forms.Button()
        Me.btnCLR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblRN
        '
        Me.lblRN.AutoSize = True
        Me.lblRN.Location = New System.Drawing.Point(6, 64)
        Me.lblRN.Name = "lblRN"
        Me.lblRN.Size = New System.Drawing.Size(55, 13)
        Me.lblRN.TabIndex = 0
        Me.lblRN.Text = "Room No."
        '
        'lblRT
        '
        Me.lblRT.AutoSize = True
        Me.lblRT.Location = New System.Drawing.Point(6, 112)
        Me.lblRT.Name = "lblRT"
        Me.lblRT.Size = New System.Drawing.Size(62, 13)
        Me.lblRT.TabIndex = 1
        Me.lblRT.Text = "Room Type"
        '
        'lblPC
        '
        Me.lblPC.AutoSize = True
        Me.lblPC.Location = New System.Drawing.Point(6, 165)
        Me.lblPC.Name = "lblPC"
        Me.lblPC.Size = New System.Drawing.Size(31, 13)
        Me.lblPC.TabIndex = 2
        Me.lblPC.Text = "Price"
        '
        'txtPC
        '
        Me.txtPC.Location = New System.Drawing.Point(107, 158)
        Me.txtPC.Name = "txtPC"
        Me.txtPC.Size = New System.Drawing.Size(121, 20)
        Me.txtPC.TabIndex = 3
        '
        'cmbRN
        '
        Me.cmbRN.FormattingEnabled = True
        Me.cmbRN.Location = New System.Drawing.Point(107, 64)
        Me.cmbRN.Name = "cmbRN"
        Me.cmbRN.Size = New System.Drawing.Size(121, 21)
        Me.cmbRN.TabIndex = 4
        '
        'cmbRT
        '
        Me.cmbRT.FormattingEnabled = True
        Me.cmbRT.Location = New System.Drawing.Point(107, 109)
        Me.cmbRT.Name = "cmbRT"
        Me.cmbRT.Size = New System.Drawing.Size(121, 21)
        Me.cmbRT.TabIndex = 5
        '
        'btnUPDT
        '
        Me.btnUPDT.Location = New System.Drawing.Point(3, 206)
        Me.btnUPDT.Name = "btnUPDT"
        Me.btnUPDT.Size = New System.Drawing.Size(75, 23)
        Me.btnUPDT.TabIndex = 6
        Me.btnUPDT.Text = "Update"
        Me.btnUPDT.UseVisualStyleBackColor = True
        '
        'btnDLT
        '
        Me.btnDLT.Location = New System.Drawing.Point(84, 206)
        Me.btnDLT.Name = "btnDLT"
        Me.btnDLT.Size = New System.Drawing.Size(75, 23)
        Me.btnDLT.TabIndex = 7
        Me.btnDLT.Text = "Delete"
        Me.btnDLT.UseVisualStyleBackColor = True
        '
        'btnBCK
        '
        Me.btnBCK.Location = New System.Drawing.Point(165, 206)
        Me.btnBCK.Name = "btnBCK"
        Me.btnBCK.Size = New System.Drawing.Size(75, 23)
        Me.btnBCK.TabIndex = 8
        Me.btnBCK.Text = "Back"
        Me.btnBCK.UseVisualStyleBackColor = True
        '
        'btnCLR
        '
        Me.btnCLR.Location = New System.Drawing.Point(246, 206)
        Me.btnCLR.Name = "btnCLR"
        Me.btnCLR.Size = New System.Drawing.Size(75, 23)
        Me.btnCLR.TabIndex = 9
        Me.btnCLR.Text = "Clear"
        Me.btnCLR.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCLR)
        Me.Controls.Add(Me.btnBCK)
        Me.Controls.Add(Me.btnDLT)
        Me.Controls.Add(Me.btnUPDT)
        Me.Controls.Add(Me.cmbRT)
        Me.Controls.Add(Me.cmbRN)
        Me.Controls.Add(Me.txtPC)
        Me.Controls.Add(Me.lblPC)
        Me.Controls.Add(Me.lblRT)
        Me.Controls.Add(Me.lblRN)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRN As Label
    Friend WithEvents lblRT As Label
    Friend WithEvents lblPC As Label
    Friend WithEvents txtPC As TextBox
    Friend WithEvents cmbRN As ComboBox
    Friend WithEvents cmbRT As ComboBox
    Friend WithEvents btnUPDT As Button
    Friend WithEvents btnDLT As Button
    Friend WithEvents btnBCK As Button
    Friend WithEvents btnCLR As Button
End Class
