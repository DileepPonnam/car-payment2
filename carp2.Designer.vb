<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDateToday = New System.Windows.Forms.TextBox()
        Me.lblTimeToday = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtloan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblPayment = New System.Windows.Forms.TextBox()
        Me.Calculate = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radCloth = New System.Windows.Forms.RadioButton()
        Me.radHeat = New System.Windows.Forms.RadioButton()
        Me.radLeath = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkEnter = New System.Windows.Forms.CheckBox()
        Me.chkPower = New System.Windows.Forms.CheckBox()
        Me.chkNavi = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.TextBox()
        Me.lblStatus.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Today's Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(340, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Today's Time"
        '
        'lblDateToday
        '
        Me.lblDateToday.Location = New System.Drawing.Point(184, 19)
        Me.lblDateToday.Name = "lblDateToday"
        Me.lblDateToday.Size = New System.Drawing.Size(119, 20)
        Me.lblDateToday.TabIndex = 2
        '
        'lblTimeToday
        '
        Me.lblTimeToday.Location = New System.Drawing.Point(476, 19)
        Me.lblTimeToday.Name = "lblTimeToday"
        Me.lblTimeToday.Size = New System.Drawing.Size(131, 20)
        Me.lblTimeToday.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Name of the Car"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(184, 62)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(121, 20)
        Me.txtName.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(340, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Purchase price"
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(476, 62)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(131, 20)
        Me.txtprice.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Number of years for the loan"
        '
        'txtloan
        '
        Me.txtloan.Location = New System.Drawing.Point(184, 109)
        Me.txtloan.Name = "txtloan"
        Me.txtloan.Size = New System.Drawing.Size(121, 20)
        Me.txtloan.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(340, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Sales Tax"
        '
        'lblTax
        '
        Me.lblTax.Location = New System.Drawing.Point(476, 105)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(131, 20)
        Me.lblTax.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 358)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Montly Payment"
        '
        'lblPayment
        '
        Me.lblPayment.Location = New System.Drawing.Point(144, 355)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(213, 20)
        Me.lblPayment.TabIndex = 13
        '
        'Calculate
        '
        Me.Calculate.Location = New System.Drawing.Point(59, 446)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(110, 30)
        Me.Calculate.TabIndex = 14
        Me.Calculate.Text = "Calculate"
        Me.Calculate.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(211, 447)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 28)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(375, 446)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 28)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.lblStatus.Location = New System.Drawing.Point(0, 449)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(867, 22)
        Me.lblStatus.TabIndex = 17
        Me.lblStatus.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(31, 17)
        Me.ToolStripStatusLabel1.Text = "Date"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radCloth)
        Me.GroupBox1.Controls.Add(Me.radHeat)
        Me.GroupBox1.Controls.Add(Me.radLeath)
        Me.GroupBox1.Location = New System.Drawing.Point(43, 164)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(278, 178)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Packages"
        '
        'radCloth
        '
        Me.radCloth.AutoSize = True
        Me.radCloth.Location = New System.Drawing.Point(25, 130)
        Me.radCloth.Name = "radCloth"
        Me.radCloth.Size = New System.Drawing.Size(79, 17)
        Me.radCloth.TabIndex = 2
        Me.radCloth.TabStop = True
        Me.radCloth.Text = "Cloth Seats"
        Me.radCloth.UseVisualStyleBackColor = True
        '
        'radHeat
        '
        Me.radHeat.AutoSize = True
        Me.radHeat.Location = New System.Drawing.Point(25, 85)
        Me.radHeat.Name = "radHeat"
        Me.radHeat.Size = New System.Drawing.Size(170, 17)
        Me.radHeat.TabIndex = 1
        Me.radHeat.TabStop = True
        Me.radHeat.Text = "Heated Leather Seat Package"
        Me.radHeat.UseVisualStyleBackColor = True
        '
        'radLeath
        '
        Me.radLeath.AutoSize = True
        Me.radLeath.Location = New System.Drawing.Point(25, 40)
        Me.radLeath.Name = "radLeath"
        Me.radLeath.Size = New System.Drawing.Size(132, 17)
        Me.radLeath.TabIndex = 0
        Me.radLeath.TabStop = True
        Me.radLeath.Text = "Leather Seat Package"
        Me.radLeath.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkEnter)
        Me.GroupBox2.Controls.Add(Me.chkPower)
        Me.GroupBox2.Controls.Add(Me.chkNavi)
        Me.GroupBox2.Location = New System.Drawing.Point(374, 164)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(312, 178)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Options"
        '
        'chkEnter
        '
        Me.chkEnter.AutoSize = True
        Me.chkEnter.Location = New System.Drawing.Point(28, 129)
        Me.chkEnter.Name = "chkEnter"
        Me.chkEnter.Size = New System.Drawing.Size(137, 17)
        Me.chkEnter.TabIndex = 2
        Me.chkEnter.Text = "Entertainment Package"
        Me.chkEnter.UseVisualStyleBackColor = True
        '
        'chkPower
        '
        Me.chkPower.AutoSize = True
        Me.chkPower.Location = New System.Drawing.Point(31, 81)
        Me.chkPower.Name = "chkPower"
        Me.chkPower.Size = New System.Drawing.Size(102, 17)
        Me.chkPower.TabIndex = 1
        Me.chkPower.Text = "Power Package"
        Me.chkPower.UseVisualStyleBackColor = True
        '
        'chkNavi
        '
        Me.chkNavi.AutoSize = True
        Me.chkNavi.Location = New System.Drawing.Point(33, 33)
        Me.chkNavi.Name = "chkNavi"
        Me.chkNavi.Size = New System.Drawing.Size(123, 17)
        Me.chkNavi.TabIndex = 0
        Me.chkNavi.Text = "Navigation Package"
        Me.chkNavi.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 401)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Result"
        '
        'lblResult
        '
        Me.lblResult.Location = New System.Drawing.Point(147, 396)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(460, 20)
        Me.lblResult.TabIndex = 21
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 471)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Calculate)
        Me.Controls.Add(Me.lblPayment)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtloan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTimeToday)
        Me.Controls.Add(Me.lblDateToday)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Car monthly payment"
        Me.lblStatus.ResumeLayout(False)
        Me.lblStatus.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDateToday As System.Windows.Forms.TextBox
    Friend WithEvents lblTimeToday As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtloan As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblPayment As System.Windows.Forms.TextBox
    Friend WithEvents Calculate As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radCloth As System.Windows.Forms.RadioButton
    Friend WithEvents radHeat As System.Windows.Forms.RadioButton
    Friend WithEvents radLeath As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkEnter As System.Windows.Forms.CheckBox
    Friend WithEvents chkPower As System.Windows.Forms.CheckBox
    Friend WithEvents chkNavi As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.TextBox

End Class
