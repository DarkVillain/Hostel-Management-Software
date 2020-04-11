<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addStudent
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
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblAr = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.cmbYr = New System.Windows.Forms.ComboBox()
        Me.cmbAr = New System.Windows.Forms.ComboBox()
        Me.txtFn = New System.Windows.Forms.TextBox()
        Me.txtNm = New System.Windows.Forms.TextBox()
        Me.txtRn = New System.Windows.Forms.TextBox()
        Me.btnBck = New System.Windows.Forms.Button()
        Me.pbPic = New System.Windows.Forms.PictureBox()
        Me.ofgUp = New System.Windows.Forms.OpenFileDialog()
        Me.btnBrws = New System.Windows.Forms.Button()
        Me.txtPic = New System.Windows.Forms.TextBox()
        CType(Me.pbPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblInfo.Location = New System.Drawing.Point(152, 19)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(234, 24)
        Me.lblInfo.TabIndex = 0
        Me.lblInfo.Text = "Add Student Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(27, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Registration No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(27, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(29, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Class"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(29, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Date"
        '
        'lblAr
        '
        Me.lblAr.AutoSize = True
        Me.lblAr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAr.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAr.Location = New System.Drawing.Point(29, 306)
        Me.lblAr.Name = "lblAr"
        Me.lblAr.Size = New System.Drawing.Size(113, 16)
        Me.lblAr.TabIndex = 5
        Me.lblAr.Text = "Aallocated Room"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(27, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Fathers Name"
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(148, 350)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dtp
        '
        Me.dtp.Location = New System.Drawing.Point(149, 263)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(121, 20)
        Me.dtp.TabIndex = 8
        '
        'cmbYr
        '
        Me.cmbYr.FormattingEnabled = True
        Me.cmbYr.Items.AddRange(New Object() {"8", "9", "10", "11", "12"})
        Me.cmbYr.Location = New System.Drawing.Point(149, 221)
        Me.cmbYr.Name = "cmbYr"
        Me.cmbYr.Size = New System.Drawing.Size(121, 21)
        Me.cmbYr.TabIndex = 9
        '
        'cmbAr
        '
        Me.cmbAr.FormattingEnabled = True
        Me.cmbAr.Items.AddRange(New Object() {"A0", "A1", "A2", "A3", "A5", "A6", "A7", "A8", "A9", "B0", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9"})
        Me.cmbAr.Location = New System.Drawing.Point(149, 303)
        Me.cmbAr.Name = "cmbAr"
        Me.cmbAr.Size = New System.Drawing.Size(121, 21)
        Me.cmbAr.TabIndex = 10
        '
        'txtFn
        '
        Me.txtFn.Location = New System.Drawing.Point(149, 179)
        Me.txtFn.Name = "txtFn"
        Me.txtFn.Size = New System.Drawing.Size(119, 20)
        Me.txtFn.TabIndex = 11
        '
        'txtNm
        '
        Me.txtNm.Location = New System.Drawing.Point(149, 140)
        Me.txtNm.Name = "txtNm"
        Me.txtNm.Size = New System.Drawing.Size(119, 20)
        Me.txtNm.TabIndex = 12
        '
        'txtRn
        '
        Me.txtRn.Location = New System.Drawing.Point(149, 101)
        Me.txtRn.Name = "txtRn"
        Me.txtRn.Size = New System.Drawing.Size(119, 20)
        Me.txtRn.TabIndex = 13
        '
        'btnBck
        '
        Me.btnBck.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBck.Location = New System.Drawing.Point(311, 350)
        Me.btnBck.Name = "btnBck"
        Me.btnBck.Size = New System.Drawing.Size(75, 23)
        Me.btnBck.TabIndex = 14
        Me.btnBck.Text = "Back"
        Me.btnBck.UseVisualStyleBackColor = True
        '
        'pbPic
        '
        Me.pbPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbPic.Location = New System.Drawing.Point(286, 101)
        Me.pbPic.Name = "pbPic"
        Me.pbPic.Size = New System.Drawing.Size(100, 98)
        Me.pbPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPic.TabIndex = 15
        Me.pbPic.TabStop = False
        '
        'ofgUp
        '
        Me.ofgUp.FileName = "Upload Picture"
        '
        'btnBrws
        '
        Me.btnBrws.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrws.Location = New System.Drawing.Point(401, 176)
        Me.btnBrws.Name = "btnBrws"
        Me.btnBrws.Size = New System.Drawing.Size(68, 23)
        Me.btnBrws.TabIndex = 16
        Me.btnBrws.Text = "Browse..."
        Me.btnBrws.UseVisualStyleBackColor = True
        '
        'txtPic
        '
        Me.txtPic.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPic.Location = New System.Drawing.Point(286, 221)
        Me.txtPic.Name = "txtPic"
        Me.txtPic.Size = New System.Drawing.Size(188, 14)
        Me.txtPic.TabIndex = 17
        '
        'addStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtPic)
        Me.Controls.Add(Me.btnBrws)
        Me.Controls.Add(Me.pbPic)
        Me.Controls.Add(Me.btnBck)
        Me.Controls.Add(Me.txtRn)
        Me.Controls.Add(Me.txtNm)
        Me.Controls.Add(Me.txtFn)
        Me.Controls.Add(Me.cmbAr)
        Me.Controls.Add(Me.cmbYr)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAr)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblInfo)
        Me.Name = "addStudent"
        CType(Me.pbPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInfo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblAr As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents cmbYr As ComboBox
    Friend WithEvents cmbAr As ComboBox
    Friend WithEvents txtFn As TextBox
    Friend WithEvents txtNm As TextBox
    Friend WithEvents txtRn As TextBox
    Friend WithEvents btnBck As Button
    Friend WithEvents pbPic As PictureBox
    Friend WithEvents ofgUp As OpenFileDialog
    Friend WithEvents btnBrws As Button
    Friend WithEvents txtPic As TextBox
End Class
