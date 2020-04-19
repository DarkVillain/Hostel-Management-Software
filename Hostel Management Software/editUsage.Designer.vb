<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class editUsage
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
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.txtPc = New System.Windows.Forms.TextBox()
        Me.txtAm = New System.Windows.Forms.TextBox()
        Me.txtPu = New System.Windows.Forms.TextBox()
        Me.txtMn = New System.Windows.Forms.TextBox()
        Me.cmbUn = New System.Windows.Forms.ComboBox()
        Me.cmbUi = New System.Windows.Forms.ComboBox()
        Me.btnBck = New System.Windows.Forms.Button()
        Me.btnUpdt = New System.Windows.Forms.Button()
        Me.lblTd = New System.Windows.Forms.Label()
        Me.lblPc = New System.Windows.Forms.Label()
        Me.lblUs = New System.Windows.Forms.Label()
        Me.lblUn = New System.Windows.Forms.Label()
        Me.lblPu = New System.Windows.Forms.Label()
        Me.lblMn = New System.Windows.Forms.Label()
        Me.lblUi = New System.Windows.Forms.Label()
        Me.lblMu = New System.Windows.Forms.Label()
        Me.btnDlt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dtp
        '
        Me.dtp.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp.Location = New System.Drawing.Point(162, 332)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(131, 22)
        Me.dtp.TabIndex = 33
        '
        'txtPc
        '
        Me.txtPc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPc.Location = New System.Drawing.Point(162, 293)
        Me.txtPc.Name = "txtPc"
        Me.txtPc.Size = New System.Drawing.Size(131, 22)
        Me.txtPc.TabIndex = 32
        '
        'txtAm
        '
        Me.txtAm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAm.Location = New System.Drawing.Point(162, 245)
        Me.txtAm.Name = "txtAm"
        Me.txtAm.Size = New System.Drawing.Size(131, 22)
        Me.txtAm.TabIndex = 31
        '
        'txtPu
        '
        Me.txtPu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPu.Location = New System.Drawing.Point(162, 163)
        Me.txtPu.Name = "txtPu"
        Me.txtPu.Size = New System.Drawing.Size(131, 22)
        Me.txtPu.TabIndex = 30
        '
        'txtMn
        '
        Me.txtMn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMn.Location = New System.Drawing.Point(162, 119)
        Me.txtMn.Name = "txtMn"
        Me.txtMn.Size = New System.Drawing.Size(131, 22)
        Me.txtMn.TabIndex = 29
        '
        'cmbUn
        '
        Me.cmbUn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUn.FormattingEnabled = True
        Me.cmbUn.Items.AddRange(New Object() {"KiloGrams", "Liter", "Grams"})
        Me.cmbUn.Location = New System.Drawing.Point(162, 204)
        Me.cmbUn.Name = "cmbUn"
        Me.cmbUn.Size = New System.Drawing.Size(131, 24)
        Me.cmbUn.TabIndex = 28
        '
        'cmbUi
        '
        Me.cmbUi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUi.FormattingEnabled = True
        Me.cmbUi.Location = New System.Drawing.Point(162, 72)
        Me.cmbUi.Name = "cmbUi"
        Me.cmbUi.Size = New System.Drawing.Size(131, 24)
        Me.cmbUi.TabIndex = 27
        '
        'btnBck
        '
        Me.btnBck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBck.Location = New System.Drawing.Point(237, 394)
        Me.btnBck.Name = "btnBck"
        Me.btnBck.Size = New System.Drawing.Size(56, 23)
        Me.btnBck.TabIndex = 26
        Me.btnBck.Text = "BACK"
        Me.btnBck.UseVisualStyleBackColor = True
        '
        'btnUpdt
        '
        Me.btnUpdt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdt.Location = New System.Drawing.Point(25, 394)
        Me.btnUpdt.Name = "btnUpdt"
        Me.btnUpdt.Size = New System.Drawing.Size(87, 23)
        Me.btnUpdt.TabIndex = 25
        Me.btnUpdt.Text = "UPDATE"
        Me.btnUpdt.UseVisualStyleBackColor = True
        '
        'lblTd
        '
        Me.lblTd.AutoSize = True
        Me.lblTd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTd.ForeColor = System.Drawing.Color.White
        Me.lblTd.Location = New System.Drawing.Point(22, 332)
        Me.lblTd.Name = "lblTd"
        Me.lblTd.Size = New System.Drawing.Size(48, 16)
        Me.lblTd.TabIndex = 24
        Me.lblTd.Text = "Today"
        '
        'lblPc
        '
        Me.lblPc.AutoSize = True
        Me.lblPc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPc.ForeColor = System.Drawing.Color.White
        Me.lblPc.Location = New System.Drawing.Point(22, 294)
        Me.lblPc.Name = "lblPc"
        Me.lblPc.Size = New System.Drawing.Size(39, 16)
        Me.lblPc.TabIndex = 23
        Me.lblPc.Text = "Price"
        '
        'lblUs
        '
        Me.lblUs.AutoSize = True
        Me.lblUs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUs.ForeColor = System.Drawing.Color.White
        Me.lblUs.Location = New System.Drawing.Point(22, 251)
        Me.lblUs.Name = "lblUs"
        Me.lblUs.Size = New System.Drawing.Size(49, 16)
        Me.lblUs.TabIndex = 22
        Me.lblUs.Text = "Usage"
        '
        'lblUn
        '
        Me.lblUn.AutoSize = True
        Me.lblUn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUn.ForeColor = System.Drawing.Color.White
        Me.lblUn.Location = New System.Drawing.Point(22, 212)
        Me.lblUn.Name = "lblUn"
        Me.lblUn.Size = New System.Drawing.Size(31, 16)
        Me.lblUn.TabIndex = 21
        Me.lblUn.Text = "Unit"
        '
        'lblPu
        '
        Me.lblPu.AutoSize = True
        Me.lblPu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPu.ForeColor = System.Drawing.Color.White
        Me.lblPu.Location = New System.Drawing.Point(22, 167)
        Me.lblPu.Name = "lblPu"
        Me.lblPu.Size = New System.Drawing.Size(88, 16)
        Me.lblPu.TabIndex = 20
        Me.lblPu.Text = "Price per Unit"
        '
        'lblMn
        '
        Me.lblMn.AutoSize = True
        Me.lblMn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMn.ForeColor = System.Drawing.Color.White
        Me.lblMn.Location = New System.Drawing.Point(22, 124)
        Me.lblMn.Name = "lblMn"
        Me.lblMn.Size = New System.Drawing.Size(96, 16)
        Me.lblMn.TabIndex = 19
        Me.lblMn.Text = "Material Name"
        '
        'lblUi
        '
        Me.lblUi.AutoSize = True
        Me.lblUi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUi.ForeColor = System.Drawing.Color.White
        Me.lblUi.Location = New System.Drawing.Point(22, 77)
        Me.lblUi.Name = "lblUi"
        Me.lblUi.Size = New System.Drawing.Size(63, 16)
        Me.lblUi.TabIndex = 18
        Me.lblUi.Text = "Usage id"
        '
        'lblMu
        '
        Me.lblMu.AutoSize = True
        Me.lblMu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMu.ForeColor = System.Drawing.Color.White
        Me.lblMu.Location = New System.Drawing.Point(103, 9)
        Me.lblMu.Name = "lblMu"
        Me.lblMu.Size = New System.Drawing.Size(111, 24)
        Me.lblMu.TabIndex = 17
        Me.lblMu.Text = "Edit Usage"
        '
        'btnDlt
        '
        Me.btnDlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDlt.Location = New System.Drawing.Point(138, 394)
        Me.btnDlt.Name = "btnDlt"
        Me.btnDlt.Size = New System.Drawing.Size(76, 23)
        Me.btnDlt.TabIndex = 34
        Me.btnDlt.Text = "DELETE"
        Me.btnDlt.UseVisualStyleBackColor = True
        '
        'editUsage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(320, 440)
        Me.Controls.Add(Me.btnDlt)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.txtPc)
        Me.Controls.Add(Me.txtAm)
        Me.Controls.Add(Me.txtPu)
        Me.Controls.Add(Me.txtMn)
        Me.Controls.Add(Me.cmbUn)
        Me.Controls.Add(Me.cmbUi)
        Me.Controls.Add(Me.btnBck)
        Me.Controls.Add(Me.btnUpdt)
        Me.Controls.Add(Me.lblTd)
        Me.Controls.Add(Me.lblPc)
        Me.Controls.Add(Me.lblUs)
        Me.Controls.Add(Me.lblUn)
        Me.Controls.Add(Me.lblPu)
        Me.Controls.Add(Me.lblMn)
        Me.Controls.Add(Me.lblUi)
        Me.Controls.Add(Me.lblMu)
        Me.Name = "editUsage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents txtPc As TextBox
    Friend WithEvents txtAm As TextBox
    Friend WithEvents txtPu As TextBox
    Friend WithEvents txtMn As TextBox
    Friend WithEvents cmbUn As ComboBox
    Friend WithEvents cmbUi As ComboBox
    Friend WithEvents btnBck As Button
    Friend WithEvents btnUpdt As Button
    Friend WithEvents lblTd As Label
    Friend WithEvents lblPc As Label
    Friend WithEvents lblUs As Label
    Friend WithEvents lblUn As Label
    Friend WithEvents lblPu As Label
    Friend WithEvents lblMn As Label
    Friend WithEvents lblUi As Label
    Friend WithEvents lblMu As Label
    Friend WithEvents btnDlt As Button
End Class
