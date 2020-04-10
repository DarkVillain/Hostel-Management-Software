<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editStudent
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
        Me.txtNm = New System.Windows.Forms.TextBox()
        Me.txtFn = New System.Windows.Forms.TextBox()
        Me.cmbAr = New System.Windows.Forms.ComboBox()
        Me.cmbYr = New System.Windows.Forms.ComboBox()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.btnUpdt = New System.Windows.Forms.Button()
        Me.lblFn = New System.Windows.Forms.Label()
        Me.lblAr = New System.Windows.Forms.Label()
        Me.lblDtp = New System.Windows.Forms.Label()
        Me.lblYr = New System.Windows.Forms.Label()
        Me.lblNm = New System.Windows.Forms.Label()
        Me.lblRn = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.cmbRn = New System.Windows.Forms.ComboBox()
        Me.btnDlt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBck
        '
        Me.btnBck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBck.Location = New System.Drawing.Point(492, 392)
        Me.btnBck.Name = "btnBck"
        Me.btnBck.Size = New System.Drawing.Size(75, 23)
        Me.btnBck.TabIndex = 29
        Me.btnBck.Text = "BACK"
        Me.btnBck.UseVisualStyleBackColor = True
        '
        'txtNm
        '
        Me.txtNm.Location = New System.Drawing.Point(448, 138)
        Me.txtNm.Name = "txtNm"
        Me.txtNm.Size = New System.Drawing.Size(119, 20)
        Me.txtNm.TabIndex = 27
        '
        'txtFn
        '
        Me.txtFn.Location = New System.Drawing.Point(448, 177)
        Me.txtFn.Name = "txtFn"
        Me.txtFn.Size = New System.Drawing.Size(119, 20)
        Me.txtFn.TabIndex = 26
        '
        'cmbAr
        '
        Me.cmbAr.FormattingEnabled = True
        Me.cmbAr.Items.AddRange(New Object() {"A0", "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "B0", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9"})
        Me.cmbAr.Location = New System.Drawing.Point(446, 308)
        Me.cmbAr.Name = "cmbAr"
        Me.cmbAr.Size = New System.Drawing.Size(121, 21)
        Me.cmbAr.TabIndex = 25
        '
        'cmbYr
        '
        Me.cmbYr.FormattingEnabled = True
        Me.cmbYr.Items.AddRange(New Object() {"2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cmbYr.Location = New System.Drawing.Point(446, 226)
        Me.cmbYr.Name = "cmbYr"
        Me.cmbYr.Size = New System.Drawing.Size(121, 21)
        Me.cmbYr.TabIndex = 24
        '
        'dtp
        '
        Me.dtp.Location = New System.Drawing.Point(446, 268)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(121, 20)
        Me.dtp.TabIndex = 23
        '
        'btnUpdt
        '
        Me.btnUpdt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdt.Location = New System.Drawing.Point(274, 391)
        Me.btnUpdt.Name = "btnUpdt"
        Me.btnUpdt.Size = New System.Drawing.Size(86, 23)
        Me.btnUpdt.TabIndex = 22
        Me.btnUpdt.Text = "UPDATE"
        Me.btnUpdt.UseVisualStyleBackColor = True
        '
        'lblFn
        '
        Me.lblFn.AutoSize = True
        Me.lblFn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFn.Location = New System.Drawing.Point(280, 179)
        Me.lblFn.Name = "lblFn"
        Me.lblFn.Size = New System.Drawing.Size(93, 16)
        Me.lblFn.TabIndex = 21
        Me.lblFn.Text = "Fathers Name"
        '
        'lblAr
        '
        Me.lblAr.AutoSize = True
        Me.lblAr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAr.Location = New System.Drawing.Point(280, 313)
        Me.lblAr.Name = "lblAr"
        Me.lblAr.Size = New System.Drawing.Size(113, 16)
        Me.lblAr.TabIndex = 20
        Me.lblAr.Text = "Aallocated Room"
        '
        'lblDtp
        '
        Me.lblDtp.AutoSize = True
        Me.lblDtp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDtp.Location = New System.Drawing.Point(280, 270)
        Me.lblDtp.Name = "lblDtp"
        Me.lblDtp.Size = New System.Drawing.Size(37, 16)
        Me.lblDtp.TabIndex = 19
        Me.lblDtp.Text = "Date"
        '
        'lblYr
        '
        Me.lblYr.AutoSize = True
        Me.lblYr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYr.Location = New System.Drawing.Point(280, 228)
        Me.lblYr.Name = "lblYr"
        Me.lblYr.Size = New System.Drawing.Size(37, 16)
        Me.lblYr.TabIndex = 18
        Me.lblYr.Text = "Year"
        '
        'lblNm
        '
        Me.lblNm.AutoSize = True
        Me.lblNm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNm.Location = New System.Drawing.Point(280, 140)
        Me.lblNm.Name = "lblNm"
        Me.lblNm.Size = New System.Drawing.Size(45, 16)
        Me.lblNm.TabIndex = 17
        Me.lblNm.Text = "Name"
        '
        'lblRn
        '
        Me.lblRn.AutoSize = True
        Me.lblRn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRn.Location = New System.Drawing.Point(280, 101)
        Me.lblRn.Name = "lblRn"
        Me.lblRn.Size = New System.Drawing.Size(104, 16)
        Me.lblRn.TabIndex = 16
        Me.lblRn.Text = "Registration No."
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(316, 37)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(171, 16)
        Me.lblInfo.TabIndex = 15
        Me.lblInfo.Text = "Edit Student Information"
        '
        'cmbRn
        '
        Me.cmbRn.FormattingEnabled = True
        Me.cmbRn.Location = New System.Drawing.Point(448, 98)
        Me.cmbRn.Name = "cmbRn"
        Me.cmbRn.Size = New System.Drawing.Size(121, 21)
        Me.cmbRn.TabIndex = 30
        '
        'btnDlt
        '
        Me.btnDlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDlt.Location = New System.Drawing.Point(388, 391)
        Me.btnDlt.Name = "btnDlt"
        Me.btnDlt.Size = New System.Drawing.Size(77, 23)
        Me.btnDlt.TabIndex = 31
        Me.btnDlt.Text = "DELETE"
        Me.btnDlt.UseVisualStyleBackColor = True
        '
        'editStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Hostel_Management_Software.My.Resources.Resources.hostelbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnDlt)
        Me.Controls.Add(Me.cmbRn)
        Me.Controls.Add(Me.btnBck)
        Me.Controls.Add(Me.txtNm)
        Me.Controls.Add(Me.txtFn)
        Me.Controls.Add(Me.cmbAr)
        Me.Controls.Add(Me.cmbYr)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.btnUpdt)
        Me.Controls.Add(Me.lblFn)
        Me.Controls.Add(Me.lblAr)
        Me.Controls.Add(Me.lblDtp)
        Me.Controls.Add(Me.lblYr)
        Me.Controls.Add(Me.lblNm)
        Me.Controls.Add(Me.lblRn)
        Me.Controls.Add(Me.lblInfo)
        Me.Name = "editStudent"
        Me.Text = "Edit Student Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBck As Button
    Friend WithEvents txtNm As TextBox
    Friend WithEvents txtFn As TextBox
    Friend WithEvents cmbAr As ComboBox
    Friend WithEvents cmbYr As ComboBox
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents btnUpdt As Button
    Friend WithEvents lblFn As Label
    Friend WithEvents lblAr As Label
    Friend WithEvents lblDtp As Label
    Friend WithEvents lblYr As Label
    Friend WithEvents lblNm As Label
    Friend WithEvents lblRn As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents cmbRn As ComboBox
    Friend WithEvents btnDlt As Button
End Class
