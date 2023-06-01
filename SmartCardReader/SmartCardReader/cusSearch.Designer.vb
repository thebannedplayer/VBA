<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cusSearch
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
        Me.components = New System.ComponentModel.Container()
        Dim AddinfoLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim Name_thaiLabel As System.Windows.Forms.Label
        Dim TelLabel As System.Windows.Forms.Label
        Dim LineLabel As System.Windows.Forms.Label
        Dim BirthLabel As System.Windows.Forms.Label
        Dim Drug_allergyLabel As System.Windows.Forms.Label
        Dim Congenital_diseaseLabel As System.Windows.Forms.Label
        Dim WeightLabel As System.Windows.Forms.Label
        Dim HeightLabel As System.Windows.Forms.Label
        Dim AddressNoLabel As System.Windows.Forms.Label
        Dim AddressMuLabel As System.Windows.Forms.Label
        Dim AddressRoadLabel As System.Windows.Forms.Label
        Dim AddressTambolLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim AddressDistrictLabel As System.Windows.Forms.Label
        Dim AddressProvinceLabel As System.Windows.Forms.Label
        Dim NoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cusSearch))
        Me.BtnSearchTel = New System.Windows.Forms.Button()
        Me.txtSearchBox = New System.Windows.Forms.TextBox()
        Me.BtnSearchId = New System.Windows.Forms.Button()
        Me.BtnSearchNo = New System.Windows.Forms.Button()
        Me.BtnSearchName = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtAddinfo = New System.Windows.Forms.TextBox()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicNisaDataSet = New SmartCardReader.ClinicNisaDataSet()
        Me.CustomerDataGridView = New System.Windows.Forms.DataGridView()
        Me.NoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamethaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameengDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugallergyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CongenitaldiseaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeriodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddinfoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressMuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressRoadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressTambolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDistrictDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressProvinceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtBirthday = New System.Windows.Forms.DateTimePicker()
        Me.txtProvince = New System.Windows.Forms.TextBox()
        Me.txtDistrict = New System.Windows.Forms.TextBox()
        Me.txtTambol = New System.Windows.Forms.TextBox()
        Me.txtRoad = New System.Windows.Forms.TextBox()
        Me.txtMu = New System.Windows.Forms.TextBox()
        Me.txtHouseNo = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtCongenital_disease = New System.Windows.Forms.TextBox()
        Me.txtDrug_allergy = New System.Windows.Forms.TextBox()
        Me.txtPeriod = New System.Windows.Forms.TextBox()
        Me.txtLinechecked = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtNameThai = New System.Windows.Forms.TextBox()
        Me.txtIDCard = New System.Windows.Forms.TextBox()
        Me.txtno = New System.Windows.Forms.TextBox()
        Me.btnUpdateCus = New System.Windows.Forms.Button()
        Me.btnPrintCus = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnOutputExcel = New System.Windows.Forms.Button()
        Me.CustomerTableAdapter = New SmartCardReader.ClinicNisaDataSetTableAdapters.customerTableAdapter()
        Me.TableAdapterManager = New SmartCardReader.ClinicNisaDataSetTableAdapters.TableAdapterManager()
        AddinfoLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        Name_thaiLabel = New System.Windows.Forms.Label()
        TelLabel = New System.Windows.Forms.Label()
        LineLabel = New System.Windows.Forms.Label()
        BirthLabel = New System.Windows.Forms.Label()
        Drug_allergyLabel = New System.Windows.Forms.Label()
        Congenital_diseaseLabel = New System.Windows.Forms.Label()
        WeightLabel = New System.Windows.Forms.Label()
        HeightLabel = New System.Windows.Forms.Label()
        AddressNoLabel = New System.Windows.Forms.Label()
        AddressMuLabel = New System.Windows.Forms.Label()
        AddressRoadLabel = New System.Windows.Forms.Label()
        AddressTambolLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        AddressDistrictLabel = New System.Windows.Forms.Label()
        AddressProvinceLabel = New System.Windows.Forms.Label()
        NoLabel = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicNisaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'AddinfoLabel
        '
        AddinfoLabel.AutoSize = True
        AddinfoLabel.Location = New System.Drawing.Point(10, 684)
        AddinfoLabel.Name = "AddinfoLabel"
        AddinfoLabel.Size = New System.Drawing.Size(65, 25)
        AddinfoLabel.TabIndex = 86
        AddinfoLabel.Text = "เหตุผล"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(9, 96)
        IdLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(151, 25)
        IdLabel.TabIndex = 7
        IdLabel.Text = "เลขบัตรประชาชน"
        '
        'Name_thaiLabel
        '
        Name_thaiLabel.AutoSize = True
        Name_thaiLabel.Location = New System.Drawing.Point(9, 146)
        Name_thaiLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Name_thaiLabel.Name = "Name_thaiLabel"
        Name_thaiLabel.Size = New System.Drawing.Size(82, 25)
        Name_thaiLabel.TabIndex = 9
        Name_thaiLabel.Text = "ชื่อ(ไทย)"
        '
        'TelLabel
        '
        TelLabel.AutoSize = True
        TelLabel.Location = New System.Drawing.Point(9, 254)
        TelLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        TelLabel.Name = "TelLabel"
        TelLabel.Size = New System.Drawing.Size(82, 25)
        TelLabel.TabIndex = 17
        TelLabel.Text = "เบอร์โทร"
        '
        'LineLabel
        '
        LineLabel.AutoSize = True
        LineLabel.Location = New System.Drawing.Point(9, 306)
        LineLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        LineLabel.Name = "LineLabel"
        LineLabel.Size = New System.Drawing.Size(45, 25)
        LineLabel.TabIndex = 19
        LineLabel.Text = "ไลน์"
        '
        'BirthLabel
        '
        BirthLabel.AutoSize = True
        BirthLabel.Location = New System.Drawing.Point(9, 354)
        BirthLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        BirthLabel.Name = "BirthLabel"
        BirthLabel.Size = New System.Drawing.Size(64, 25)
        BirthLabel.TabIndex = 21
        BirthLabel.Text = "วันเกิด"
        '
        'Drug_allergyLabel
        '
        Drug_allergyLabel.AutoSize = True
        Drug_allergyLabel.Location = New System.Drawing.Point(9, 404)
        Drug_allergyLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Drug_allergyLabel.Name = "Drug_allergyLabel"
        Drug_allergyLabel.Size = New System.Drawing.Size(58, 25)
        Drug_allergyLabel.TabIndex = 23
        Drug_allergyLabel.Text = "แพ้ยา"
        '
        'Congenital_diseaseLabel
        '
        Congenital_diseaseLabel.AutoSize = True
        Congenital_diseaseLabel.Location = New System.Drawing.Point(9, 454)
        Congenital_diseaseLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Congenital_diseaseLabel.Name = "Congenital_diseaseLabel"
        Congenital_diseaseLabel.Size = New System.Drawing.Size(115, 25)
        Congenital_diseaseLabel.TabIndex = 25
        Congenital_diseaseLabel.Text = "โรคประจำตัว"
        '
        'WeightLabel
        '
        WeightLabel.AutoSize = True
        WeightLabel.Location = New System.Drawing.Point(9, 549)
        WeightLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        WeightLabel.Name = "WeightLabel"
        WeightLabel.Size = New System.Drawing.Size(71, 25)
        WeightLabel.TabIndex = 27
        WeightLabel.Text = "น้ำหนัก"
        '
        'HeightLabel
        '
        HeightLabel.AutoSize = True
        HeightLabel.Location = New System.Drawing.Point(9, 596)
        HeightLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        HeightLabel.Name = "HeightLabel"
        HeightLabel.Size = New System.Drawing.Size(66, 25)
        HeightLabel.TabIndex = 29
        HeightLabel.Text = "ส่วนสูง"
        '
        'AddressNoLabel
        '
        AddressNoLabel.AutoSize = True
        AddressNoLabel.Location = New System.Drawing.Point(9, 644)
        AddressNoLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        AddressNoLabel.Name = "AddressNoLabel"
        AddressNoLabel.Size = New System.Drawing.Size(86, 25)
        AddressNoLabel.TabIndex = 31
        AddressNoLabel.Text = "เลขที่บ้าน"
        '
        'AddressMuLabel
        '
        AddressMuLabel.AutoSize = True
        AddressMuLabel.Location = New System.Drawing.Point(9, 692)
        AddressMuLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        AddressMuLabel.Name = "AddressMuLabel"
        AddressMuLabel.Size = New System.Drawing.Size(37, 25)
        AddressMuLabel.TabIndex = 33
        AddressMuLabel.Text = "หมู่"
        '
        'AddressRoadLabel
        '
        AddressRoadLabel.AutoSize = True
        AddressRoadLabel.Location = New System.Drawing.Point(9, 746)
        AddressRoadLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        AddressRoadLabel.Name = "AddressRoadLabel"
        AddressRoadLabel.Size = New System.Drawing.Size(49, 25)
        AddressRoadLabel.TabIndex = 35
        AddressRoadLabel.Text = "ถนน"
        '
        'AddressTambolLabel
        '
        AddressTambolLabel.AutoSize = True
        AddressTambolLabel.Location = New System.Drawing.Point(9, 795)
        AddressTambolLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        AddressTambolLabel.Name = "AddressTambolLabel"
        AddressTambolLabel.Size = New System.Drawing.Size(55, 25)
        AddressTambolLabel.TabIndex = 37
        AddressTambolLabel.Text = "ตำบล"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(9, 502)
        Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(104, 25)
        Label1.TabIndex = 79
        Label1.Text = "ประจำเดือน"
        '
        'AddressDistrictLabel
        '
        AddressDistrictLabel.AutoSize = True
        AddressDistrictLabel.Location = New System.Drawing.Point(9, 839)
        AddressDistrictLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        AddressDistrictLabel.Name = "AddressDistrictLabel"
        AddressDistrictLabel.Size = New System.Drawing.Size(61, 25)
        AddressDistrictLabel.TabIndex = 39
        AddressDistrictLabel.Text = "อำเภอ"
        '
        'AddressProvinceLabel
        '
        AddressProvinceLabel.AutoSize = True
        AddressProvinceLabel.Location = New System.Drawing.Point(9, 886)
        AddressProvinceLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        AddressProvinceLabel.Name = "AddressProvinceLabel"
        AddressProvinceLabel.Size = New System.Drawing.Size(66, 25)
        AddressProvinceLabel.TabIndex = 41
        AddressProvinceLabel.Text = "จังหวัด"
        '
        'NoLabel
        '
        NoLabel.AutoSize = True
        NoLabel.Location = New System.Drawing.Point(9, 46)
        NoLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        NoLabel.Name = "NoLabel"
        NoLabel.Size = New System.Drawing.Size(99, 25)
        NoLabel.TabIndex = 5
        NoLabel.Text = "รันนัมเบอร์"
        '
        'BtnSearchTel
        '
        Me.BtnSearchTel.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchTel.Location = New System.Drawing.Point(816, 136)
        Me.BtnSearchTel.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BtnSearchTel.Name = "BtnSearchTel"
        Me.BtnSearchTel.Size = New System.Drawing.Size(292, 44)
        Me.BtnSearchTel.TabIndex = 3
        Me.BtnSearchTel.Text = "ค้นหาด้วยเบอร์โทร"
        Me.BtnSearchTel.UseVisualStyleBackColor = True
        '
        'txtSearchBox
        '
        Me.txtSearchBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBox.Location = New System.Drawing.Point(0, 88)
        Me.txtSearchBox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtSearchBox.Multiline = True
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.Size = New System.Drawing.Size(767, 92)
        Me.txtSearchBox.TabIndex = 4
        '
        'BtnSearchId
        '
        Me.BtnSearchId.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchId.Location = New System.Drawing.Point(816, 79)
        Me.BtnSearchId.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BtnSearchId.Name = "BtnSearchId"
        Me.BtnSearchId.Size = New System.Drawing.Size(292, 44)
        Me.BtnSearchId.TabIndex = 2
        Me.BtnSearchId.Text = "ค้นหาด้วยบัตรประชาชน"
        Me.BtnSearchId.UseVisualStyleBackColor = True
        '
        'BtnSearchNo
        '
        Me.BtnSearchNo.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchNo.Location = New System.Drawing.Point(816, 25)
        Me.BtnSearchNo.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BtnSearchNo.Name = "BtnSearchNo"
        Me.BtnSearchNo.Size = New System.Drawing.Size(292, 44)
        Me.BtnSearchNo.TabIndex = 1
        Me.BtnSearchNo.Text = "ค้นหาด้วยรันนัมเบอร์"
        Me.BtnSearchNo.UseVisualStyleBackColor = True
        '
        'BtnSearchName
        '
        Me.BtnSearchName.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchName.Location = New System.Drawing.Point(816, 192)
        Me.BtnSearchName.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BtnSearchName.Name = "BtnSearchName"
        Me.BtnSearchName.Size = New System.Drawing.Size(292, 44)
        Me.BtnSearchName.TabIndex = 112
        Me.BtnSearchName.Text = "ค้นหาด้วยชื่อ"
        Me.BtnSearchName.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtAddinfo)
        Me.GroupBox2.Controls.Add(Me.CustomerDataGridView)
        Me.GroupBox2.Controls.Add(Me.BtnSearchName)
        Me.GroupBox2.Controls.Add(AddinfoLabel)
        Me.GroupBox2.Controls.Add(Me.BtnSearchNo)
        Me.GroupBox2.Controls.Add(Me.BtnSearchId)
        Me.GroupBox2.Controls.Add(Me.txtSearchBox)
        Me.GroupBox2.Controls.Add(Me.BtnSearchTel)
        Me.GroupBox2.Location = New System.Drawing.Point(781, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1128, 835)
        Me.GroupBox2.TabIndex = 85
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ค้นหาผู้ป่วย"
        '
        'txtAddinfo
        '
        Me.txtAddinfo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "addinfo", True))
        Me.txtAddinfo.Location = New System.Drawing.Point(81, 689)
        Me.txtAddinfo.Multiline = True
        Me.txtAddinfo.Name = "txtAddinfo"
        Me.txtAddinfo.Size = New System.Drawing.Size(901, 126)
        Me.txtAddinfo.TabIndex = 111
        Me.txtAddinfo.Text = "txtAddinfo"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "customer"
        Me.CustomerBindingSource.DataSource = Me.ClinicNisaDataSet
        '
        'ClinicNisaDataSet
        '
        Me.ClinicNisaDataSet.DataSetName = "ClinicNisaDataSet"
        Me.ClinicNisaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerDataGridView
        '
        Me.CustomerDataGridView.AllowUserToAddRows = False
        Me.CustomerDataGridView.AllowUserToDeleteRows = False
        Me.CustomerDataGridView.AutoGenerateColumns = False
        Me.CustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoDataGridViewTextBoxColumn, Me.IdDataGridViewTextBoxColumn, Me.NamethaiDataGridViewTextBoxColumn, Me.NameengDataGridViewTextBoxColumn, Me.TelDataGridViewTextBoxColumn, Me.LineDataGridViewTextBoxColumn, Me.BirthDataGridViewTextBoxColumn, Me.DrugallergyDataGridViewTextBoxColumn, Me.CongenitaldiseaseDataGridViewTextBoxColumn, Me.WeightDataGridViewTextBoxColumn, Me.HeightDataGridViewTextBoxColumn, Me.PeriodDataGridViewTextBoxColumn, Me.AddinfoDataGridViewTextBoxColumn, Me.AddressNoDataGridViewTextBoxColumn, Me.AddressMuDataGridViewTextBoxColumn, Me.AddressRoadDataGridViewTextBoxColumn, Me.AddressTambolDataGridViewTextBoxColumn, Me.AddressDistrictDataGridViewTextBoxColumn, Me.AddressProvinceDataGridViewTextBoxColumn})
        Me.CustomerDataGridView.DataSource = Me.CustomerBindingSource
        Me.CustomerDataGridView.Location = New System.Drawing.Point(12, 262)
        Me.CustomerDataGridView.Name = "CustomerDataGridView"
        Me.CustomerDataGridView.ReadOnly = True
        Me.CustomerDataGridView.RowTemplate.Height = 30
        Me.CustomerDataGridView.Size = New System.Drawing.Size(1096, 359)
        Me.CustomerDataGridView.TabIndex = 124
        '
        'NoDataGridViewTextBoxColumn
        '
        Me.NoDataGridViewTextBoxColumn.DataPropertyName = "no"
        Me.NoDataGridViewTextBoxColumn.HeaderText = "no"
        Me.NoDataGridViewTextBoxColumn.Name = "NoDataGridViewTextBoxColumn"
        Me.NoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 250
        '
        'NamethaiDataGridViewTextBoxColumn
        '
        Me.NamethaiDataGridViewTextBoxColumn.DataPropertyName = "name_thai"
        Me.NamethaiDataGridViewTextBoxColumn.HeaderText = "name_thai"
        Me.NamethaiDataGridViewTextBoxColumn.Name = "NamethaiDataGridViewTextBoxColumn"
        Me.NamethaiDataGridViewTextBoxColumn.ReadOnly = True
        Me.NamethaiDataGridViewTextBoxColumn.Width = 500
        '
        'NameengDataGridViewTextBoxColumn
        '
        Me.NameengDataGridViewTextBoxColumn.DataPropertyName = "name_eng"
        Me.NameengDataGridViewTextBoxColumn.HeaderText = "name_eng"
        Me.NameengDataGridViewTextBoxColumn.Name = "NameengDataGridViewTextBoxColumn"
        Me.NameengDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameengDataGridViewTextBoxColumn.Width = 5
        '
        'TelDataGridViewTextBoxColumn
        '
        Me.TelDataGridViewTextBoxColumn.DataPropertyName = "tel"
        Me.TelDataGridViewTextBoxColumn.HeaderText = "tel"
        Me.TelDataGridViewTextBoxColumn.Name = "TelDataGridViewTextBoxColumn"
        Me.TelDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelDataGridViewTextBoxColumn.Width = 250
        '
        'LineDataGridViewTextBoxColumn
        '
        Me.LineDataGridViewTextBoxColumn.DataPropertyName = "line"
        Me.LineDataGridViewTextBoxColumn.HeaderText = "line"
        Me.LineDataGridViewTextBoxColumn.Name = "LineDataGridViewTextBoxColumn"
        Me.LineDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BirthDataGridViewTextBoxColumn
        '
        Me.BirthDataGridViewTextBoxColumn.DataPropertyName = "birth"
        Me.BirthDataGridViewTextBoxColumn.HeaderText = "birth"
        Me.BirthDataGridViewTextBoxColumn.Name = "BirthDataGridViewTextBoxColumn"
        Me.BirthDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DrugallergyDataGridViewTextBoxColumn
        '
        Me.DrugallergyDataGridViewTextBoxColumn.DataPropertyName = "drug_allergy"
        Me.DrugallergyDataGridViewTextBoxColumn.HeaderText = "drug_allergy"
        Me.DrugallergyDataGridViewTextBoxColumn.Name = "DrugallergyDataGridViewTextBoxColumn"
        Me.DrugallergyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CongenitaldiseaseDataGridViewTextBoxColumn
        '
        Me.CongenitaldiseaseDataGridViewTextBoxColumn.DataPropertyName = "congenital_disease"
        Me.CongenitaldiseaseDataGridViewTextBoxColumn.HeaderText = "congenital_disease"
        Me.CongenitaldiseaseDataGridViewTextBoxColumn.Name = "CongenitaldiseaseDataGridViewTextBoxColumn"
        Me.CongenitaldiseaseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WeightDataGridViewTextBoxColumn
        '
        Me.WeightDataGridViewTextBoxColumn.DataPropertyName = "weight"
        Me.WeightDataGridViewTextBoxColumn.HeaderText = "weight"
        Me.WeightDataGridViewTextBoxColumn.Name = "WeightDataGridViewTextBoxColumn"
        Me.WeightDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HeightDataGridViewTextBoxColumn
        '
        Me.HeightDataGridViewTextBoxColumn.DataPropertyName = "height"
        Me.HeightDataGridViewTextBoxColumn.HeaderText = "height"
        Me.HeightDataGridViewTextBoxColumn.Name = "HeightDataGridViewTextBoxColumn"
        Me.HeightDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PeriodDataGridViewTextBoxColumn
        '
        Me.PeriodDataGridViewTextBoxColumn.DataPropertyName = "period"
        Me.PeriodDataGridViewTextBoxColumn.HeaderText = "period"
        Me.PeriodDataGridViewTextBoxColumn.Name = "PeriodDataGridViewTextBoxColumn"
        Me.PeriodDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddinfoDataGridViewTextBoxColumn
        '
        Me.AddinfoDataGridViewTextBoxColumn.DataPropertyName = "addinfo"
        Me.AddinfoDataGridViewTextBoxColumn.HeaderText = "addinfo"
        Me.AddinfoDataGridViewTextBoxColumn.Name = "AddinfoDataGridViewTextBoxColumn"
        Me.AddinfoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressNoDataGridViewTextBoxColumn
        '
        Me.AddressNoDataGridViewTextBoxColumn.DataPropertyName = "addressNo"
        Me.AddressNoDataGridViewTextBoxColumn.HeaderText = "addressNo"
        Me.AddressNoDataGridViewTextBoxColumn.Name = "AddressNoDataGridViewTextBoxColumn"
        Me.AddressNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressMuDataGridViewTextBoxColumn
        '
        Me.AddressMuDataGridViewTextBoxColumn.DataPropertyName = "addressMu"
        Me.AddressMuDataGridViewTextBoxColumn.HeaderText = "addressMu"
        Me.AddressMuDataGridViewTextBoxColumn.Name = "AddressMuDataGridViewTextBoxColumn"
        Me.AddressMuDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressRoadDataGridViewTextBoxColumn
        '
        Me.AddressRoadDataGridViewTextBoxColumn.DataPropertyName = "addressRoad"
        Me.AddressRoadDataGridViewTextBoxColumn.HeaderText = "addressRoad"
        Me.AddressRoadDataGridViewTextBoxColumn.Name = "AddressRoadDataGridViewTextBoxColumn"
        Me.AddressRoadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressTambolDataGridViewTextBoxColumn
        '
        Me.AddressTambolDataGridViewTextBoxColumn.DataPropertyName = "addressTambol"
        Me.AddressTambolDataGridViewTextBoxColumn.HeaderText = "addressTambol"
        Me.AddressTambolDataGridViewTextBoxColumn.Name = "AddressTambolDataGridViewTextBoxColumn"
        Me.AddressTambolDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressDistrictDataGridViewTextBoxColumn
        '
        Me.AddressDistrictDataGridViewTextBoxColumn.DataPropertyName = "addressDistrict"
        Me.AddressDistrictDataGridViewTextBoxColumn.HeaderText = "addressDistrict"
        Me.AddressDistrictDataGridViewTextBoxColumn.Name = "AddressDistrictDataGridViewTextBoxColumn"
        Me.AddressDistrictDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressProvinceDataGridViewTextBoxColumn
        '
        Me.AddressProvinceDataGridViewTextBoxColumn.DataPropertyName = "addressProvince"
        Me.AddressProvinceDataGridViewTextBoxColumn.HeaderText = "addressProvince"
        Me.AddressProvinceDataGridViewTextBoxColumn.Name = "AddressProvinceDataGridViewTextBoxColumn"
        Me.AddressProvinceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtBirthday)
        Me.GroupBox1.Controls.Add(Me.txtProvince)
        Me.GroupBox1.Controls.Add(Me.txtDistrict)
        Me.GroupBox1.Controls.Add(Me.txtTambol)
        Me.GroupBox1.Controls.Add(Me.txtRoad)
        Me.GroupBox1.Controls.Add(Me.txtMu)
        Me.GroupBox1.Controls.Add(Me.txtHouseNo)
        Me.GroupBox1.Controls.Add(Me.txtHeight)
        Me.GroupBox1.Controls.Add(Me.txtWeight)
        Me.GroupBox1.Controls.Add(Me.txtCongenital_disease)
        Me.GroupBox1.Controls.Add(Me.txtDrug_allergy)
        Me.GroupBox1.Controls.Add(Me.txtPeriod)
        Me.GroupBox1.Controls.Add(Me.txtLinechecked)
        Me.GroupBox1.Controls.Add(Me.txtTel)
        Me.GroupBox1.Controls.Add(Me.txtNameThai)
        Me.GroupBox1.Controls.Add(Me.txtIDCard)
        Me.GroupBox1.Controls.Add(Me.txtno)
        Me.GroupBox1.Controls.Add(NoLabel)
        Me.GroupBox1.Controls.Add(AddressProvinceLabel)
        Me.GroupBox1.Controls.Add(AddressDistrictLabel)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(AddressTambolLabel)
        Me.GroupBox1.Controls.Add(AddressRoadLabel)
        Me.GroupBox1.Controls.Add(AddressMuLabel)
        Me.GroupBox1.Controls.Add(AddressNoLabel)
        Me.GroupBox1.Controls.Add(HeightLabel)
        Me.GroupBox1.Controls.Add(WeightLabel)
        Me.GroupBox1.Controls.Add(Congenital_diseaseLabel)
        Me.GroupBox1.Controls.Add(Drug_allergyLabel)
        Me.GroupBox1.Controls.Add(BirthLabel)
        Me.GroupBox1.Controls.Add(LineLabel)
        Me.GroupBox1.Controls.Add(TelLabel)
        Me.GroupBox1.Controls.Add(Name_thaiLabel)
        Me.GroupBox1.Controls.Add(IdLabel)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(657, 1061)
        Me.GroupBox1.TabIndex = 84
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลผู้ป่วย"
        '
        'txtBirthday
        '
        Me.txtBirthday.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerBindingSource, "birth", True))
        Me.txtBirthday.Location = New System.Drawing.Point(233, 349)
        Me.txtBirthday.Name = "txtBirthday"
        Me.txtBirthday.Size = New System.Drawing.Size(396, 31)
        Me.txtBirthday.TabIndex = 124
        '
        'txtProvince
        '
        Me.txtProvince.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "addressProvince", True))
        Me.txtProvince.Location = New System.Drawing.Point(233, 883)
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.Size = New System.Drawing.Size(396, 31)
        Me.txtProvince.TabIndex = 123
        Me.txtProvince.Text = "txtProvince"
        '
        'txtDistrict
        '
        Me.txtDistrict.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "addressDistrict", True))
        Me.txtDistrict.Location = New System.Drawing.Point(233, 836)
        Me.txtDistrict.Name = "txtDistrict"
        Me.txtDistrict.Size = New System.Drawing.Size(396, 31)
        Me.txtDistrict.TabIndex = 121
        Me.txtDistrict.Text = "txtDistrict"
        '
        'txtTambol
        '
        Me.txtTambol.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "addressTambol", True))
        Me.txtTambol.Location = New System.Drawing.Point(233, 792)
        Me.txtTambol.Name = "txtTambol"
        Me.txtTambol.Size = New System.Drawing.Size(396, 31)
        Me.txtTambol.TabIndex = 119
        Me.txtTambol.Text = "txtTambol"
        '
        'txtRoad
        '
        Me.txtRoad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "addressRoad", True))
        Me.txtRoad.Location = New System.Drawing.Point(233, 743)
        Me.txtRoad.Name = "txtRoad"
        Me.txtRoad.Size = New System.Drawing.Size(396, 31)
        Me.txtRoad.TabIndex = 117
        Me.txtRoad.Text = "txtRoad"
        '
        'txtMu
        '
        Me.txtMu.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "addressMu", True))
        Me.txtMu.Location = New System.Drawing.Point(233, 689)
        Me.txtMu.Name = "txtMu"
        Me.txtMu.Size = New System.Drawing.Size(396, 31)
        Me.txtMu.TabIndex = 115
        Me.txtMu.Text = "txtMu"
        '
        'txtHouseNo
        '
        Me.txtHouseNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "addressNo", True))
        Me.txtHouseNo.Location = New System.Drawing.Point(233, 641)
        Me.txtHouseNo.Name = "txtHouseNo"
        Me.txtHouseNo.Size = New System.Drawing.Size(396, 31)
        Me.txtHouseNo.TabIndex = 113
        Me.txtHouseNo.Text = "txtHouseNo"
        '
        'txtHeight
        '
        Me.txtHeight.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "height", True))
        Me.txtHeight.Location = New System.Drawing.Point(233, 593)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(396, 31)
        Me.txtHeight.TabIndex = 107
        Me.txtHeight.Text = "txtHeight"
        '
        'txtWeight
        '
        Me.txtWeight.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "weight", True))
        Me.txtWeight.Location = New System.Drawing.Point(233, 546)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(396, 31)
        Me.txtWeight.TabIndex = 105
        Me.txtWeight.Text = "txtWeight"
        '
        'txtCongenital_disease
        '
        Me.txtCongenital_disease.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "congenital_disease", True))
        Me.txtCongenital_disease.Location = New System.Drawing.Point(233, 451)
        Me.txtCongenital_disease.Name = "txtCongenital_disease"
        Me.txtCongenital_disease.Size = New System.Drawing.Size(396, 31)
        Me.txtCongenital_disease.TabIndex = 103
        Me.txtCongenital_disease.Text = "txtCongenital_disease"
        '
        'txtDrug_allergy
        '
        Me.txtDrug_allergy.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "drug_allergy", True))
        Me.txtDrug_allergy.Location = New System.Drawing.Point(233, 401)
        Me.txtDrug_allergy.Name = "txtDrug_allergy"
        Me.txtDrug_allergy.Size = New System.Drawing.Size(396, 31)
        Me.txtDrug_allergy.TabIndex = 101
        Me.txtDrug_allergy.Text = "txtDrug_allergy"
        '
        'txtPeriod
        '
        Me.txtPeriod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "period", True))
        Me.txtPeriod.Location = New System.Drawing.Point(233, 499)
        Me.txtPeriod.Name = "txtPeriod"
        Me.txtPeriod.Size = New System.Drawing.Size(396, 31)
        Me.txtPeriod.TabIndex = 109
        Me.txtPeriod.Text = "txtPeriod"
        '
        'txtLinechecked
        '
        Me.txtLinechecked.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "line", True))
        Me.txtLinechecked.Location = New System.Drawing.Point(233, 303)
        Me.txtLinechecked.Name = "txtLinechecked"
        Me.txtLinechecked.Size = New System.Drawing.Size(396, 31)
        Me.txtLinechecked.TabIndex = 97
        Me.txtLinechecked.Text = "txtLinechecked"
        '
        'txtTel
        '
        Me.txtTel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "tel", True))
        Me.txtTel.Location = New System.Drawing.Point(233, 251)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(396, 31)
        Me.txtTel.TabIndex = 95
        Me.txtTel.Text = "txtTel"
        '
        'txtNameThai
        '
        Me.txtNameThai.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "name_thai", True))
        Me.txtNameThai.Location = New System.Drawing.Point(233, 143)
        Me.txtNameThai.Name = "txtNameThai"
        Me.txtNameThai.Size = New System.Drawing.Size(396, 31)
        Me.txtNameThai.TabIndex = 91
        Me.txtNameThai.Text = "txtNameThai"
        '
        'txtIDCard
        '
        Me.txtIDCard.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "id", True))
        Me.txtIDCard.Location = New System.Drawing.Point(233, 93)
        Me.txtIDCard.Name = "txtIDCard"
        Me.txtIDCard.Size = New System.Drawing.Size(396, 31)
        Me.txtIDCard.TabIndex = 89
        Me.txtIDCard.Text = "txtIDCard"
        '
        'txtno
        '
        Me.txtno.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "no", True))
        Me.txtno.Location = New System.Drawing.Point(233, 43)
        Me.txtno.Name = "txtno"
        Me.txtno.ReadOnly = True
        Me.txtno.Size = New System.Drawing.Size(396, 31)
        Me.txtno.TabIndex = 87
        Me.txtno.Text = "txtno"
        '
        'btnUpdateCus
        '
        Me.btnUpdateCus.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnUpdateCus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateCus.ForeColor = System.Drawing.Color.White
        Me.btnUpdateCus.Location = New System.Drawing.Point(5, 34)
        Me.btnUpdateCus.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnUpdateCus.Name = "btnUpdateCus"
        Me.btnUpdateCus.Size = New System.Drawing.Size(237, 82)
        Me.btnUpdateCus.TabIndex = 77
        Me.btnUpdateCus.Text = "อัปเดทข้อมูล"
        Me.btnUpdateCus.UseVisualStyleBackColor = False
        '
        'btnPrintCus
        '
        Me.btnPrintCus.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnPrintCus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrintCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintCus.ForeColor = System.Drawing.Color.White
        Me.btnPrintCus.Location = New System.Drawing.Point(268, 34)
        Me.btnPrintCus.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnPrintCus.Name = "btnPrintCus"
        Me.btnPrintCus.Size = New System.Drawing.Size(237, 82)
        Me.btnPrintCus.TabIndex = 78
        Me.btnPrintCus.Text = "พิมพ์ข้อมูล"
        Me.btnPrintCus.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.Location = New System.Drawing.Point(528, 34)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(237, 82)
        Me.BtnDelete.TabIndex = 79
        Me.BtnDelete.Text = "ลบข้อมูล"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnOutputExcel)
        Me.GroupBox3.Controls.Add(Me.BtnDelete)
        Me.GroupBox3.Controls.Add(Me.btnPrintCus)
        Me.GroupBox3.Controls.Add(Me.btnUpdateCus)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox3.Location = New System.Drawing.Point(657, 930)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(1267, 131)
        Me.GroupBox3.TabIndex = 86
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ปุ่ม"
        '
        'BtnOutputExcel
        '
        Me.BtnOutputExcel.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnOutputExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOutputExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOutputExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOutputExcel.ForeColor = System.Drawing.Color.White
        Me.BtnOutputExcel.Location = New System.Drawing.Point(788, 34)
        Me.BtnOutputExcel.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BtnOutputExcel.Name = "BtnOutputExcel"
        Me.BtnOutputExcel.Size = New System.Drawing.Size(237, 82)
        Me.BtnOutputExcel.TabIndex = 80
        Me.BtnOutputExcel.Text = "พิมพ์ข้อมูลคนไข้ทั้งหมดเป็นไฟล์ CSV"
        Me.BtnOutputExcel.UseVisualStyleBackColor = False
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.UpdateOrder = SmartCardReader.ClinicNisaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'cusSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(1924, 1061)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "cusSearch"
        Me.Text = "ค้นหาข้อมูล"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicNisaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnSearchTel As Button
    Friend WithEvents txtSearchBox As TextBox
    Friend WithEvents BtnSearchId As Button
    Friend WithEvents BtnSearchNo As Button
    Friend WithEvents BtnSearchName As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnUpdateCus As Button
    Friend WithEvents btnPrintCus As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ClinicNisaDataSet As ClinicNisaDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As ClinicNisaDataSetTableAdapters.customerTableAdapter
    Friend WithEvents TableAdapterManager As ClinicNisaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtno As TextBox
    Friend WithEvents txtIDCard As TextBox
    Friend WithEvents txtNameThai As TextBox
    Friend WithEvents txtLinechecked As TextBox
    Friend WithEvents txtDrug_allergy As TextBox
    Friend WithEvents txtCongenital_disease As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtPeriod As TextBox
    Friend WithEvents txtAddinfo As TextBox
    Friend WithEvents txtHouseNo As TextBox
    Friend WithEvents txtMu As TextBox
    Friend WithEvents txtRoad As TextBox
    Friend WithEvents txtTambol As TextBox
    Friend WithEvents txtDistrict As TextBox
    Friend WithEvents txtProvince As TextBox
    Friend WithEvents BtnOutputExcel As Button
    Friend WithEvents CustomerDataGridView As DataGridView
    Friend WithEvents NoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamethaiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameengDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LineDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BirthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DrugallergyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CongenitaldiseaseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HeightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PeriodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddinfoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressMuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressRoadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressTambolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDistrictDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressProvinceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtBirthday As DateTimePicker
    Friend WithEvents txtTel As TextBox
End Class
