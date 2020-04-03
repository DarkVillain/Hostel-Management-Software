<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addroom
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClr = New System.Windows.Forms.Button()
        Me.btnBK = New System.Windows.Forms.Button()
        Me.lblRN = New System.Windows.Forms.Label()
        Me.lblRT = New System.Windows.Forms.Label()
        Me.lblPC = New System.Windows.Forms.Label()
        Me.txtRN = New System.Windows.Forms.TextBox()
        Me.txtRT = New System.Windows.Forms.TextBox()
        Me.txtPC = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(41, 250)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClr
        '
        Me.btnClr.Location = New System.Drawing.Point(240, 250)
        Me.btnClr.Name = "btnClr"
        Me.btnClr.Size = New System.Drawing.Size(75, 23)
        Me.btnClr.TabIndex = 1
        Me.btnClr.Text = "Clear"
        Me.btnClr.UseVisualStyleBackColor = True
        '
        'btnBK
        '
        Me.btnBK.Location = New System.Drawing.Point(144, 250)
        Me.btnBK.Name = "btnBK"
        Me.btnBK.Size = New System.Drawing.Size(75, 23)
        Me.btnBK.TabIndex = 2
        Me.btnBK.Text = "Back"
        Me.btnBK.UseVisualStyleBackColor = True
        '
        'lblRN
        '
        Me.lblRN.AutoSize = True
        Me.lblRN.Location = New System.Drawing.Point(38, 49)
        Me.lblRN.Name = "lblRN"
        Me.lblRN.Size = New System.Drawing.Size(55, 13)
        Me.lblRN.TabIndex = 3
        Me.lblRN.Text = "Room No."
        '
        'lblRT
        '
        Me.lblRT.AutoSize = True
        Me.lblRT.Location = New System.Drawing.Point(38, 113)
        Me.lblRT.Name = "lblRT"
        Me.lblRT.Size = New System.Drawing.Size(62, 13)
        Me.lblRT.TabIndex = 4
        Me.lblRT.Text = "Room Type"
        '
        'lblPC
        '
        Me.lblPC.AutoSize = True
        Me.lblPC.Location = New System.Drawing.Point(38, 172)
        Me.lblPC.Name = "lblPC"
        Me.lblPC.Size = New System.Drawing.Size(31, 13)
        Me.lblPC.TabIndex = 5
        Me.lblPC.Text = "Price"
        '
        'txtRN
        '
        Me.txtRN.Location = New System.Drawing.Point(121, 49)
        Me.txtRN.Name = "txtRN"
        Me.txtRN.Size = New System.Drawing.Size(179, 20)
        Me.txtRN.TabIndex = 6
        '
        'txtRT
        '
        Me.txtRT.Location = New System.Drawing.Point(121, 113)
        Me.txtRT.Name = "txtRT"
        Me.txtRT.Size = New System.Drawing.Size(179, 20)
        Me.txtRT.TabIndex = 7
        '
        'txtPC
        '
        Me.txtPC.Location = New System.Drawing.Point(121, 172)
        Me.txtPC.Name = "txtPC"
        Me.txtPC.Size = New System.Drawing.Size(179, 20)
        Me.txtPC.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(387, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(376, 235)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'addroom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtPC)
        Me.Controls.Add(Me.txtRT)
        Me.Controls.Add(Me.txtRN)
        Me.Controls.Add(Me.lblPC)
        Me.Controls.Add(Me.lblRT)
        Me.Controls.Add(Me.lblRN)
        Me.Controls.Add(Me.btnBK)
        Me.Controls.Add(Me.btnClr)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "addroom"
        Me.Text = "addroom"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClr As Button
    Friend WithEvents btnBK As Button
    Friend WithEvents lblRN As Label
    Friend WithEvents lblRT As Label
    Friend WithEvents lblPC As Label
    Friend WithEvents txtRN As TextBox
    Friend WithEvents txtRT As TextBox
    Friend WithEvents txtPC As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
