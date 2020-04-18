<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editMaterials
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
        Me.btnBck = New System.Windows.Forms.Button()
        Me.btnUpdt = New System.Windows.Forms.Button()
        Me.cmbUn = New System.Windows.Forms.ComboBox()
        Me.txtPu = New System.Windows.Forms.TextBox()
        Me.lblUn = New System.Windows.Forms.Label()
        Me.lblPu = New System.Windows.Forms.Label()
        Me.lblMn = New System.Windows.Forms.Label()
        Me.lblEm = New System.Windows.Forms.Label()
        Me.cmbMi = New System.Windows.Forms.ComboBox()
        Me.txtMn = New System.Windows.Forms.TextBox()
        Me.lblMi = New System.Windows.Forms.Label()
        Me.btnDlt = New System.Windows.Forms.Button()
        Me.txtAm = New System.Windows.Forms.TextBox()
        Me.lblMu = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBck
        '
        Me.btnBck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBck.Location = New System.Drawing.Point(213, 336)
        Me.btnBck.Name = "btnBck"
        Me.btnBck.Size = New System.Drawing.Size(75, 23)
        Me.btnBck.TabIndex = 17
        Me.btnBck.Text = "BACK"
        Me.btnBck.UseVisualStyleBackColor = True
        '
        'btnUpdt
        '
        Me.btnUpdt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdt.Location = New System.Drawing.Point(25, 336)
        Me.btnUpdt.Name = "btnUpdt"
        Me.btnUpdt.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdt.TabIndex = 16
        Me.btnUpdt.Text = "UPDATE"
        Me.btnUpdt.UseVisualStyleBackColor = True
        '
        'cmbUn
        '
        Me.cmbUn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUn.FormattingEnabled = True
        Me.cmbUn.Items.AddRange(New Object() {"KiloGrams", "Liters", "Grams"})
        Me.cmbUn.Location = New System.Drawing.Point(166, 259)
        Me.cmbUn.Name = "cmbUn"
        Me.cmbUn.Size = New System.Drawing.Size(122, 24)
        Me.cmbUn.TabIndex = 15
        '
        'txtPu
        '
        Me.txtPu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPu.Location = New System.Drawing.Point(166, 176)
        Me.txtPu.Name = "txtPu"
        Me.txtPu.Size = New System.Drawing.Size(122, 22)
        Me.txtPu.TabIndex = 14
        '
        'lblUn
        '
        Me.lblUn.AutoSize = True
        Me.lblUn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUn.ForeColor = System.Drawing.SystemColors.Control
        Me.lblUn.Location = New System.Drawing.Point(22, 264)
        Me.lblUn.Name = "lblUn"
        Me.lblUn.Size = New System.Drawing.Size(31, 16)
        Me.lblUn.TabIndex = 12
        Me.lblUn.Text = "Unit"
        '
        'lblPu
        '
        Me.lblPu.AutoSize = True
        Me.lblPu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPu.ForeColor = System.Drawing.SystemColors.Control
        Me.lblPu.Location = New System.Drawing.Point(22, 182)
        Me.lblPu.Name = "lblPu"
        Me.lblPu.Size = New System.Drawing.Size(88, 16)
        Me.lblPu.TabIndex = 11
        Me.lblPu.Text = "Price per Unit"
        '
        'lblMn
        '
        Me.lblMn.AutoSize = True
        Me.lblMn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMn.ForeColor = System.Drawing.SystemColors.Control
        Me.lblMn.Location = New System.Drawing.Point(22, 135)
        Me.lblMn.Name = "lblMn"
        Me.lblMn.Size = New System.Drawing.Size(96, 16)
        Me.lblMn.TabIndex = 10
        Me.lblMn.Text = "Material Name"
        '
        'lblEm
        '
        Me.lblEm.AutoSize = True
        Me.lblEm.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEm.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblEm.Location = New System.Drawing.Point(106, 9)
        Me.lblEm.Name = "lblEm"
        Me.lblEm.Size = New System.Drawing.Size(136, 24)
        Me.lblEm.TabIndex = 9
        Me.lblEm.Text = "Edit Materials"
        '
        'cmbMi
        '
        Me.cmbMi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMi.FormattingEnabled = True
        Me.cmbMi.Location = New System.Drawing.Point(166, 84)
        Me.cmbMi.Name = "cmbMi"
        Me.cmbMi.Size = New System.Drawing.Size(122, 24)
        Me.cmbMi.TabIndex = 18
        '
        'txtMn
        '
        Me.txtMn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMn.Location = New System.Drawing.Point(166, 129)
        Me.txtMn.Name = "txtMn"
        Me.txtMn.Size = New System.Drawing.Size(122, 22)
        Me.txtMn.TabIndex = 20
        '
        'lblMi
        '
        Me.lblMi.AutoSize = True
        Me.lblMi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMi.ForeColor = System.Drawing.SystemColors.Control
        Me.lblMi.Location = New System.Drawing.Point(22, 92)
        Me.lblMi.Name = "lblMi"
        Me.lblMi.Size = New System.Drawing.Size(70, 16)
        Me.lblMi.TabIndex = 19
        Me.lblMi.Text = "Material id"
        '
        'btnDlt
        '
        Me.btnDlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDlt.Location = New System.Drawing.Point(116, 336)
        Me.btnDlt.Name = "btnDlt"
        Me.btnDlt.Size = New System.Drawing.Size(75, 23)
        Me.btnDlt.TabIndex = 21
        Me.btnDlt.Text = "DELETE"
        Me.btnDlt.UseVisualStyleBackColor = True
        '
        'txtAm
        '
        Me.txtAm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAm.Location = New System.Drawing.Point(166, 219)
        Me.txtAm.Name = "txtAm"
        Me.txtAm.Size = New System.Drawing.Size(122, 22)
        Me.txtAm.TabIndex = 23
        '
        'lblMu
        '
        Me.lblMu.AutoSize = True
        Me.lblMu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMu.ForeColor = System.Drawing.SystemColors.Control
        Me.lblMu.Location = New System.Drawing.Point(22, 219)
        Me.lblMu.Name = "lblMu"
        Me.lblMu.Size = New System.Drawing.Size(56, 16)
        Me.lblMu.TabIndex = 22
        Me.lblMu.Text = "Quantity"
        '
        'editMaterials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(319, 404)
        Me.Controls.Add(Me.txtAm)
        Me.Controls.Add(Me.lblMu)
        Me.Controls.Add(Me.btnDlt)
        Me.Controls.Add(Me.txtMn)
        Me.Controls.Add(Me.lblMi)
        Me.Controls.Add(Me.cmbMi)
        Me.Controls.Add(Me.btnBck)
        Me.Controls.Add(Me.btnUpdt)
        Me.Controls.Add(Me.cmbUn)
        Me.Controls.Add(Me.txtPu)
        Me.Controls.Add(Me.lblUn)
        Me.Controls.Add(Me.lblPu)
        Me.Controls.Add(Me.lblMn)
        Me.Controls.Add(Me.lblEm)
        Me.Name = "editMaterials"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBck As Button
    Friend WithEvents btnUpdt As Button
    Friend WithEvents cmbUn As ComboBox
    Friend WithEvents txtPu As TextBox
    Friend WithEvents lblUn As Label
    Friend WithEvents lblPu As Label
    Friend WithEvents lblMn As Label
    Friend WithEvents lblEm As Label
    Friend WithEvents cmbMi As ComboBox
    Friend WithEvents txtMn As TextBox
    Friend WithEvents lblMi As Label
    Friend WithEvents btnDlt As Button
    Friend WithEvents txtAm As TextBox
    Friend WithEvents lblMu As Label
End Class
