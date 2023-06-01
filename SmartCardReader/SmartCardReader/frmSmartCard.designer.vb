<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSmartCard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSmartCard))
        Me.txtName_Thai = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtIDCard = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtBirthDate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAddinfo = New System.Windows.Forms.TextBox()
        Me.btnInsertCus = New System.Windows.Forms.Button()
        Me.txtno = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PeriodNotNormal = New System.Windows.Forms.RadioButton()
        Me.PeriodNormal = New System.Windows.Forms.RadioButton()
        Me.txtLinechecked = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.checkLinetrue = New System.Windows.Forms.CheckBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtCongenital_disease = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtDrug_allergy = New System.Windows.Forms.TextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.txtProvince = New System.Windows.Forms.TextBox()
        Me.txtDistrict = New System.Windows.Forms.TextBox()
        Me.txtTambol = New System.Windows.Forms.TextBox()
        Me.txtRoad = New System.Windows.Forms.TextBox()
        Me.txtVillageNo = New System.Windows.Forms.TextBox()
        Me.txtHouseNo = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtExpireDate = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtIssueDate = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.picData = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtName_Thai
        '
        Me.txtName_Thai.Location = New System.Drawing.Point(178, 142)
        Me.txtName_Thai.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtName_Thai.MaxLength = 120
        Me.txtName_Thai.Name = "txtName_Thai"
        Me.txtName_Thai.Size = New System.Drawing.Size(273, 30)
        Me.txtName_Thai.TabIndex = 2
        Me.txtName_Thai.Text = "txtName_Thai"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(28, 146)
        Me.label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(88, 23)
        Me.label2.TabIndex = 23
        Me.label2.Text = "ชื่อ (ไทย)"
        '
        'txtIDCard
        '
        Me.txtIDCard.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtIDCard.ForeColor = System.Drawing.Color.Navy
        Me.txtIDCard.Location = New System.Drawing.Point(178, 102)
        Me.txtIDCard.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtIDCard.MaxLength = 25
        Me.txtIDCard.Name = "txtIDCard"
        Me.txtIDCard.Size = New System.Drawing.Size(273, 26)
        Me.txtIDCard.TabIndex = 1
        Me.txtIDCard.Text = "txtIDCard"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(28, 106)
        Me.label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(146, 23)
        Me.label1.TabIndex = 21
        Me.label1.Text = "เลขบัตรประชาชน"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtBirthDate)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtAddinfo)
        Me.GroupBox1.Controls.Add(Me.btnInsertCus)
        Me.GroupBox1.Controls.Add(Me.txtno)
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnRead)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtLinechecked)
        Me.GroupBox1.Controls.Add(Me.txtTel)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.txtHeight)
        Me.GroupBox1.Controls.Add(Me.txtWeight)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.checkLinetrue)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtCongenital_disease)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtDrug_allergy)
        Me.GroupBox1.Controls.Add(Me.lblAge)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.txtProvince)
        Me.GroupBox1.Controls.Add(Me.txtDistrict)
        Me.GroupBox1.Controls.Add(Me.txtTambol)
        Me.GroupBox1.Controls.Add(Me.txtRoad)
        Me.GroupBox1.Controls.Add(Me.txtVillageNo)
        Me.GroupBox1.Controls.Add(Me.txtHouseNo)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtExpireDate)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtIssueDate)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.picData)
        Me.GroupBox1.Controls.Add(Me.label1)
        Me.GroupBox1.Controls.Add(Me.txtIDCard)
        Me.GroupBox1.Controls.Add(Me.label2)
        Me.GroupBox1.Controls.Add(Me.txtName_Thai)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1450, 856)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " ข้อมูลจากบัตรประชาชน "
        '
        'txtBirthDate
        '
        Me.txtBirthDate.Location = New System.Drawing.Point(178, 189)
        Me.txtBirthDate.Name = "txtBirthDate"
        Me.txtBirthDate.Size = New System.Drawing.Size(273, 30)
        Me.txtBirthDate.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(614, 540)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 23)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "เหตุผล"
        '
        'txtAddinfo
        '
        Me.txtAddinfo.Location = New System.Drawing.Point(708, 545)
        Me.txtAddinfo.Multiline = True
        Me.txtAddinfo.Name = "txtAddinfo"
        Me.txtAddinfo.Size = New System.Drawing.Size(357, 108)
        Me.txtAddinfo.TabIndex = 16
        Me.txtAddinfo.Text = "txtAddinfo"
        '
        'btnInsertCus
        '
        Me.btnInsertCus.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnInsertCus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInsertCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsertCus.ForeColor = System.Drawing.Color.White
        Me.btnInsertCus.Location = New System.Drawing.Point(434, 769)
        Me.btnInsertCus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInsertCus.Name = "btnInsertCus"
        Me.btnInsertCus.Size = New System.Drawing.Size(149, 55)
        Me.btnInsertCus.TabIndex = 17
        Me.btnInsertCus.Text = "เพิ่มผู้ป่วย F6"
        Me.btnInsertCus.UseVisualStyleBackColor = False
        '
        'txtno
        '
        Me.txtno.AcceptsReturn = True
        Me.txtno.AcceptsTab = True
        Me.txtno.Location = New System.Drawing.Point(178, 59)
        Me.txtno.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtno.MaxLength = 120
        Me.txtno.Name = "txtno"
        Me.txtno.ReadOnly = True
        Me.txtno.Size = New System.Drawing.Size(273, 30)
        Me.txtno.TabIndex = 80
        Me.txtno.Text = "txtno"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(798, 769)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(149, 55)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "จบโปรแกรม F10"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnRead
        '
        Me.btnRead.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnRead.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRead.ForeColor = System.Drawing.Color.White
        Me.btnRead.Location = New System.Drawing.Point(618, 769)
        Me.btnRead.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(149, 55)
        Me.btnRead.TabIndex = 99
        Me.btnRead.Text = "อ่านบัตร F7"
        Me.btnRead.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 63)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 23)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "เลขผู้ป่วย"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PeriodNotNormal)
        Me.GroupBox2.Controls.Add(Me.PeriodNormal)
        Me.GroupBox2.Location = New System.Drawing.Point(418, 540)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(162, 113)
        Me.GroupBox2.TabIndex = 79
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ประจำเดือน"
        '
        'PeriodNotNormal
        '
        Me.PeriodNotNormal.AutoSize = True
        Me.PeriodNotNormal.Location = New System.Drawing.Point(40, 68)
        Me.PeriodNotNormal.Margin = New System.Windows.Forms.Padding(4)
        Me.PeriodNotNormal.Name = "PeriodNotNormal"
        Me.PeriodNotNormal.Size = New System.Drawing.Size(84, 27)
        Me.PeriodNotNormal.TabIndex = 1
        Me.PeriodNotNormal.TabStop = True
        Me.PeriodNotNormal.Text = "ไม่ปกติ"
        Me.PeriodNotNormal.UseVisualStyleBackColor = True
        '
        'PeriodNormal
        '
        Me.PeriodNormal.AutoSize = True
        Me.PeriodNormal.Location = New System.Drawing.Point(40, 32)
        Me.PeriodNormal.Margin = New System.Windows.Forms.Padding(4)
        Me.PeriodNormal.Name = "PeriodNormal"
        Me.PeriodNormal.Size = New System.Drawing.Size(63, 27)
        Me.PeriodNormal.TabIndex = 0
        Me.PeriodNormal.TabStop = True
        Me.PeriodNormal.Text = "ปกติ"
        Me.PeriodNormal.UseVisualStyleBackColor = True
        '
        'txtLinechecked
        '
        Me.txtLinechecked.Enabled = False
        Me.txtLinechecked.Location = New System.Drawing.Point(235, 636)
        Me.txtLinechecked.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtLinechecked.MaxLength = 120
        Me.txtLinechecked.Name = "txtLinechecked"
        Me.txtLinechecked.Size = New System.Drawing.Size(153, 30)
        Me.txtLinechecked.TabIndex = 14
        Me.txtLinechecked.Text = "txtLinechecked"
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(178, 461)
        Me.txtTel.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtTel.MaxLength = 120
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(324, 30)
        Me.txtTel.TabIndex = 10
        Me.txtTel.Text = "txtTel"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(26, 465)
        Me.Label22.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(78, 23)
        Me.Label22.TabIndex = 77
        Me.Label22.Text = "เบอร์โทร"
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(178, 582)
        Me.txtHeight.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtHeight.MaxLength = 120
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(153, 30)
        Me.txtHeight.TabIndex = 13
        Me.txtHeight.Text = "txtHeight"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(178, 542)
        Me.txtWeight.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtWeight.MaxLength = 120
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(153, 30)
        Me.txtWeight.TabIndex = 12
        Me.txtWeight.Text = "txtWeight"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 585)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 23)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "ส่วนสูง"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 545)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 23)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "น้ำหนัก"
        '
        'checkLinetrue
        '
        Me.checkLinetrue.AutoSize = True
        Me.checkLinetrue.Location = New System.Drawing.Point(181, 639)
        Me.checkLinetrue.Margin = New System.Windows.Forms.Padding(4)
        Me.checkLinetrue.Name = "checkLinetrue"
        Me.checkLinetrue.Size = New System.Drawing.Size(40, 27)
        Me.checkLinetrue.TabIndex = 71
        Me.checkLinetrue.Text = "มี"
        Me.checkLinetrue.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(31, 639)
        Me.Label21.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(44, 23)
        Me.Label21.TabIndex = 70
        Me.Label21.Text = "ไลน์"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(32, 723)
        Me.Label19.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(109, 23)
        Me.Label19.TabIndex = 68
        Me.Label19.Text = "โรคประจำตัว"
        '
        'txtCongenital_disease
        '
        Me.txtCongenital_disease.Location = New System.Drawing.Point(182, 719)
        Me.txtCongenital_disease.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtCongenital_disease.MaxLength = 120
        Me.txtCongenital_disease.Name = "txtCongenital_disease"
        Me.txtCongenital_disease.Size = New System.Drawing.Size(273, 30)
        Me.txtCongenital_disease.TabIndex = 15
        Me.txtCongenital_disease.Text = "txtCongenital_disease"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(32, 679)
        Me.Label20.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(54, 23)
        Me.Label20.TabIndex = 67
        Me.Label20.Text = "แพ้ยา"
        '
        'txtDrug_allergy
        '
        Me.txtDrug_allergy.Location = New System.Drawing.Point(182, 676)
        Me.txtDrug_allergy.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtDrug_allergy.MaxLength = 120
        Me.txtDrug_allergy.Name = "txtDrug_allergy"
        Me.txtDrug_allergy.Size = New System.Drawing.Size(273, 30)
        Me.txtDrug_allergy.TabIndex = 14
        Me.txtDrug_allergy.Text = "txtDrug_allergy"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblAge.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblAge.Location = New System.Drawing.Point(178, 281)
        Me.lblAge.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(47, 19)
        Me.lblAge.TabIndex = 64
        Me.lblAge.Text = "อายุ: "
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(907, 30)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(381, 29)
        Me.ProgressBar1.TabIndex = 18
        '
        'txtProvince
        '
        Me.txtProvince.Location = New System.Drawing.Point(178, 501)
        Me.txtProvince.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtProvince.MaxLength = 120
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.Size = New System.Drawing.Size(324, 30)
        Me.txtProvince.TabIndex = 11
        Me.txtProvince.Text = "txtProvince"
        '
        'txtDistrict
        '
        Me.txtDistrict.Location = New System.Drawing.Point(179, 418)
        Me.txtDistrict.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtDistrict.MaxLength = 120
        Me.txtDistrict.Name = "txtDistrict"
        Me.txtDistrict.Size = New System.Drawing.Size(324, 30)
        Me.txtDistrict.TabIndex = 9
        Me.txtDistrict.Text = "txtDistrict"
        '
        'txtTambol
        '
        Me.txtTambol.Location = New System.Drawing.Point(179, 374)
        Me.txtTambol.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtTambol.MaxLength = 120
        Me.txtTambol.Name = "txtTambol"
        Me.txtTambol.Size = New System.Drawing.Size(324, 30)
        Me.txtTambol.TabIndex = 8
        Me.txtTambol.Text = "txtTambol"
        '
        'txtRoad
        '
        Me.txtRoad.Location = New System.Drawing.Point(592, 331)
        Me.txtRoad.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtRoad.MaxLength = 120
        Me.txtRoad.Name = "txtRoad"
        Me.txtRoad.Size = New System.Drawing.Size(213, 30)
        Me.txtRoad.TabIndex = 7
        Me.txtRoad.Text = "txtRoad"
        '
        'txtVillageNo
        '
        Me.txtVillageNo.Location = New System.Drawing.Point(418, 331)
        Me.txtVillageNo.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtVillageNo.MaxLength = 120
        Me.txtVillageNo.Name = "txtVillageNo"
        Me.txtVillageNo.Size = New System.Drawing.Size(85, 30)
        Me.txtVillageNo.TabIndex = 6
        Me.txtVillageNo.Text = "txtVillageNo"
        '
        'txtHouseNo
        '
        Me.txtHouseNo.Location = New System.Drawing.Point(179, 331)
        Me.txtHouseNo.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtHouseNo.MaxLength = 120
        Me.txtHouseNo.Name = "txtHouseNo"
        Me.txtHouseNo.Size = New System.Drawing.Size(153, 30)
        Me.txtHouseNo.TabIndex = 5
        Me.txtHouseNo.Text = "txtHouseNo"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(29, 504)
        Me.Label18.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 23)
        Me.Label18.TabIndex = 51
        Me.Label18.Text = "จังหวัด"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(28, 421)
        Me.Label17.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 23)
        Me.Label17.TabIndex = 50
        Me.Label17.Text = "อำเภอ/เขต"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(28, 378)
        Me.Label16.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 23)
        Me.Label16.TabIndex = 49
        Me.Label16.Text = "ตำบล"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(535, 333)
        Me.Label15.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 23)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "ถนน"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(358, 334)
        Me.Label13.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 23)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "หมู่ที่"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(28, 334)
        Me.Label12.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 23)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "บ้านเลขที่"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(476, 105)
        Me.Label11.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 23)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "บัตรหมดอายุ"
        '
        'txtExpireDate
        '
        Me.txtExpireDate.Location = New System.Drawing.Point(592, 102)
        Me.txtExpireDate.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtExpireDate.MaxLength = 120
        Me.txtExpireDate.Name = "txtExpireDate"
        Me.txtExpireDate.Size = New System.Drawing.Size(273, 30)
        Me.txtExpireDate.TabIndex = 99
        Me.txtExpireDate.Text = "txtExpireDate"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(476, 62)
        Me.Label10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 23)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "วันออกบัตร"
        '
        'txtIssueDate
        '
        Me.txtIssueDate.Location = New System.Drawing.Point(592, 59)
        Me.txtIssueDate.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtIssueDate.MaxLength = 120
        Me.txtIssueDate.Name = "txtIssueDate"
        Me.txtIssueDate.Size = New System.Drawing.Size(273, 30)
        Me.txtIssueDate.TabIndex = 99
        Me.txtIssueDate.Text = "txtIssueDate"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 195)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 23)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "วันเดือนปีเกิด"
        '
        'picData
        '
        Me.picData.Location = New System.Drawing.Point(907, 59)
        Me.picData.Margin = New System.Windows.Forms.Padding(4)
        Me.picData.Name = "picData"
        Me.picData.Size = New System.Drawing.Size(381, 272)
        Me.picData.TabIndex = 32
        Me.picData.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(476, 146)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(358, 23)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "เช่น: นางสาวหนึ่ง สองสาม, น.ส.สี่ห้า หกเจ็ด"
        '
        'frmSmartCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1450, 856)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frmSmartCard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เพิ่มข้อมูลใหม่"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.picData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents txtName_Thai As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents txtIDCard As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents picData As System.Windows.Forms.PictureBox
    Private WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents txtProvince As System.Windows.Forms.TextBox
    Private WithEvents txtDistrict As System.Windows.Forms.TextBox
    Private WithEvents txtTambol As System.Windows.Forms.TextBox
    Private WithEvents txtRoad As System.Windows.Forms.TextBox
    Private WithEvents txtVillageNo As System.Windows.Forms.TextBox
    Private WithEvents txtHouseNo As System.Windows.Forms.TextBox
    Private WithEvents Label18 As System.Windows.Forms.Label
    Private WithEvents Label17 As System.Windows.Forms.Label
    Private WithEvents Label16 As System.Windows.Forms.Label
    Private WithEvents Label15 As System.Windows.Forms.Label
    Private WithEvents Label13 As System.Windows.Forms.Label
    Private WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnRead As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents btnInsertCus As Button
    Friend WithEvents checkLinetrue As CheckBox
    Private WithEvents Label21 As Label
    Private WithEvents Label19 As Label
    Private WithEvents txtCongenital_disease As TextBox
    Private WithEvents Label20 As Label
    Private WithEvents txtDrug_allergy As TextBox
    Private WithEvents txtHeight As TextBox
    Private WithEvents txtWeight As TextBox
    Private WithEvents Label4 As Label
    Private WithEvents Label5 As Label
    Private WithEvents txtTel As TextBox
    Private WithEvents Label22 As Label
    Friend WithEvents txtLinechecked As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PeriodNotNormal As RadioButton
    Friend WithEvents PeriodNormal As RadioButton
    Private WithEvents Label6 As Label
    Friend WithEvents txtno As TextBox
    Private WithEvents Label11 As Label
    Private WithEvents txtExpireDate As TextBox
    Private WithEvents Label10 As Label
    Private WithEvents txtIssueDate As TextBox
    Private WithEvents Label8 As Label
    Friend WithEvents txtAddinfo As TextBox
    Friend WithEvents txtBirthDate As DateTimePicker
    Private WithEvents Label3 As Label
End Class
