<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addMaterials
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
        Me.lblAm = New System.Windows.Forms.Label()
        Me.lblMt = New System.Windows.Forms.Label()
        Me.lblPu = New System.Windows.Forms.Label()
        Me.lblUn = New System.Windows.Forms.Label()
        Me.txtMt = New System.Windows.Forms.TextBox()
        Me.txtPu = New System.Windows.Forms.TextBox()
        Me.cmbUn = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnBck = New System.Windows.Forms.Button()
        Me.txtMi = New System.Windows.Forms.TextBox()
        Me.lblMi = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAm
        '
        Me.lblAm.AutoSize = True
        Me.lblAm.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAm.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAm.Location = New System.Drawing.Point(253, 37)
        Me.lblAm.Name = "lblAm"
        Me.lblAm.Size = New System.Drawing.Size(136, 24)
        Me.lblAm.TabIndex = 0
        Me.lblAm.Text = "Add Materials"
        '
        'lblMt
        '
        Me.lblMt.AutoSize = True
        Me.lblMt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMt.ForeColor = System.Drawing.SystemColors.Control
        Me.lblMt.Location = New System.Drawing.Point(29, 179)
        Me.lblMt.Name = "lblMt"
        Me.lblMt.Size = New System.Drawing.Size(96, 16)
        Me.lblMt.TabIndex = 1
        Me.lblMt.Text = "Material Name"
        '
        'lblPu
        '
        Me.lblPu.AutoSize = True
        Me.lblPu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPu.ForeColor = System.Drawing.SystemColors.Control
        Me.lblPu.Location = New System.Drawing.Point(29, 228)
        Me.lblPu.Name = "lblPu"
        Me.lblPu.Size = New System.Drawing.Size(88, 16)
        Me.lblPu.TabIndex = 2
        Me.lblPu.Text = "Price per Unit"
        '
        'lblUn
        '
        Me.lblUn.AutoSize = True
        Me.lblUn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUn.ForeColor = System.Drawing.SystemColors.Control
        Me.lblUn.Location = New System.Drawing.Point(29, 278)
        Me.lblUn.Name = "lblUn"
        Me.lblUn.Size = New System.Drawing.Size(31, 16)
        Me.lblUn.TabIndex = 3
        Me.lblUn.Text = "Unit"
        '
        'txtMt
        '
        Me.txtMt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMt.Location = New System.Drawing.Point(170, 176)
        Me.txtMt.Name = "txtMt"
        Me.txtMt.Size = New System.Drawing.Size(100, 22)
        Me.txtMt.TabIndex = 4
        '
        'txtPu
        '
        Me.txtPu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPu.Location = New System.Drawing.Point(170, 228)
        Me.txtPu.Name = "txtPu"
        Me.txtPu.Size = New System.Drawing.Size(100, 22)
        Me.txtPu.TabIndex = 5
        '
        'cmbUn
        '
        Me.cmbUn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUn.FormattingEnabled = True
        Me.cmbUn.Items.AddRange(New Object() {"KiloGrams", "Liters", "Grams"})
        Me.cmbUn.Location = New System.Drawing.Point(170, 273)
        Me.cmbUn.Name = "cmbUn"
        Me.cmbUn.Size = New System.Drawing.Size(100, 24)
        Me.cmbUn.TabIndex = 6
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(50, 348)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnBck
        '
        Me.btnBck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBck.Location = New System.Drawing.Point(170, 348)
        Me.btnBck.Name = "btnBck"
        Me.btnBck.Size = New System.Drawing.Size(75, 23)
        Me.btnBck.TabIndex = 8
        Me.btnBck.Text = "BACK"
        Me.btnBck.UseVisualStyleBackColor = True
        '
        'txtMi
        '
        Me.txtMi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMi.Location = New System.Drawing.Point(170, 128)
        Me.txtMi.Name = "txtMi"
        Me.txtMi.Size = New System.Drawing.Size(100, 22)
        Me.txtMi.TabIndex = 10
        '
        'lblMi
        '
        Me.lblMi.AutoSize = True
        Me.lblMi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMi.ForeColor = System.Drawing.SystemColors.Control
        Me.lblMi.Location = New System.Drawing.Point(29, 131)
        Me.lblMi.Name = "lblMi"
        Me.lblMi.Size = New System.Drawing.Size(70, 16)
        Me.lblMi.TabIndex = 9
        Me.lblMi.Text = "Material id"
        '
        'addMaterials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(725, 450)
        Me.Controls.Add(Me.txtMi)
        Me.Controls.Add(Me.lblMi)
        Me.Controls.Add(Me.btnBck)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cmbUn)
        Me.Controls.Add(Me.txtPu)
        Me.Controls.Add(Me.txtMt)
        Me.Controls.Add(Me.lblUn)
        Me.Controls.Add(Me.lblPu)
        Me.Controls.Add(Me.lblMt)
        Me.Controls.Add(Me.lblAm)
        Me.Name = "addMaterials"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAm As Label
    Friend WithEvents lblMt As Label
    Friend WithEvents lblPu As Label
    Friend WithEvents lblUn As Label
    Friend WithEvents txtMt As TextBox
    Friend WithEvents txtPu As TextBox
    Friend WithEvents cmbUn As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnBck As Button
    Friend WithEvents txtMi As TextBox
    Friend WithEvents lblMi As Label
End Class
