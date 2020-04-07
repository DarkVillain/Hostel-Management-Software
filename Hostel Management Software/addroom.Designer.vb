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
        Me.txtPC = New System.Windows.Forms.TextBox()
        Me.cmbRT = New System.Windows.Forms.ComboBox()
        Me.dgvRoom = New System.Windows.Forms.DataGridView()
        Me.lblRD = New System.Windows.Forms.Label()
        CType(Me.dgvRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(21, 223)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClr
        '
        Me.btnClr.Location = New System.Drawing.Point(205, 223)
        Me.btnClr.Name = "btnClr"
        Me.btnClr.Size = New System.Drawing.Size(75, 23)
        Me.btnClr.TabIndex = 1
        Me.btnClr.Text = "Clear"
        Me.btnClr.UseVisualStyleBackColor = True
        '
        'btnBK
        '
        Me.btnBK.Location = New System.Drawing.Point(111, 223)
        Me.btnBK.Name = "btnBK"
        Me.btnBK.Size = New System.Drawing.Size(75, 23)
        Me.btnBK.TabIndex = 2
        Me.btnBK.Text = "Back"
        Me.btnBK.UseVisualStyleBackColor = True
        '
        'lblRN
        '
        Me.lblRN.AutoSize = True
        Me.lblRN.Location = New System.Drawing.Point(18, 101)
        Me.lblRN.Name = "lblRN"
        Me.lblRN.Size = New System.Drawing.Size(55, 13)
        Me.lblRN.TabIndex = 3
        Me.lblRN.Text = "Room No."
        '
        'lblRT
        '
        Me.lblRT.AutoSize = True
        Me.lblRT.Location = New System.Drawing.Point(18, 142)
        Me.lblRT.Name = "lblRT"
        Me.lblRT.Size = New System.Drawing.Size(62, 13)
        Me.lblRT.TabIndex = 4
        Me.lblRT.Text = "Room Type"
        '
        'lblPC
        '
        Me.lblPC.AutoSize = True
        Me.lblPC.Location = New System.Drawing.Point(18, 183)
        Me.lblPC.Name = "lblPC"
        Me.lblPC.Size = New System.Drawing.Size(31, 13)
        Me.lblPC.TabIndex = 5
        Me.lblPC.Text = "Price"
        '
        'txtRN
        '
        Me.txtRN.Location = New System.Drawing.Point(101, 101)
        Me.txtRN.Name = "txtRN"
        Me.txtRN.Size = New System.Drawing.Size(179, 20)
        Me.txtRN.TabIndex = 6
        '
        'txtPC
        '
        Me.txtPC.Location = New System.Drawing.Point(101, 183)
        Me.txtPC.Name = "txtPC"
        Me.txtPC.Size = New System.Drawing.Size(179, 20)
        Me.txtPC.TabIndex = 8
        '
        'cmbRT
        '
        Me.cmbRT.FormattingEnabled = True
        Me.cmbRT.Items.AddRange(New Object() {"AC", "NON-AC"})
        Me.cmbRT.Location = New System.Drawing.Point(101, 142)
        Me.cmbRT.Name = "cmbRT"
        Me.cmbRT.Size = New System.Drawing.Size(179, 21)
        Me.cmbRT.TabIndex = 10
        '
        'dgvRoom
        '
        Me.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRoom.Location = New System.Drawing.Point(325, 56)
        Me.dgvRoom.Name = "dgvRoom"
        Me.dgvRoom.Size = New System.Drawing.Size(962, 609)
        Me.dgvRoom.TabIndex = 11
        '
        'lblRD
        '
        Me.lblRD.AutoSize = True
        Me.lblRD.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRD.Location = New System.Drawing.Point(321, 9)
        Me.lblRD.Name = "lblRD"
        Me.lblRD.Size = New System.Drawing.Size(121, 24)
        Me.lblRD.TabIndex = 12
        Me.lblRD.Text = "Room Details"
        '
        'addroom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Hostel_Management_Software.My.Resources.Resources.hostelbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1350, 747)
        Me.Controls.Add(Me.lblRD)
        Me.Controls.Add(Me.dgvRoom)
        Me.Controls.Add(Me.cmbRT)
        Me.Controls.Add(Me.txtPC)
        Me.Controls.Add(Me.txtRN)
        Me.Controls.Add(Me.lblPC)
        Me.Controls.Add(Me.lblRT)
        Me.Controls.Add(Me.lblRN)
        Me.Controls.Add(Me.btnBK)
        Me.Controls.Add(Me.btnClr)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "addroom"
        Me.Text = "Please insert details"
        CType(Me.dgvRoom, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtPC As TextBox
    Friend WithEvents cmbRT As ComboBox
    Friend WithEvents dgvRoom As DataGridView
    Friend WithEvents lblRD As Label
End Class
