#Region "ABOUT"
' / --------------------------------------------------------------------------------
' / Developer : Mr.Surapon Yodsanga (Thongkorn Tubtimkrob)
' / eMail : thongkorn@hotmail.com
' / URL: http://www.g2gnet.com (Khon Kaen - Thailand)
' / Facebook: https://www.facebook.com/g2gnet (For Thailand)
' / Facebook: https://www.facebook.com/Cmdonindy (Worldwide)
' / More Info: http://www.g2    gnet.com/webboard
' /
' / Purpose: Read the information from Smart Card.
' / Microsoft Visual Basic .NET (2010)
' /
' / This is open source code under @CopyLeft by Thongkorn Tubtimkrob.
' / You can modify and/or distribute without to inform the developer.
' / Special Thanks.
' / https://github.com/chakphanu/ThaiNationalIDCard
' / --------------------------------------------------------------------------------
#End Region


Imports ThaiNationalIDCard
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.ApplicationServices


Public Class frmSmartCard
    Dim datethai As Integer = Date.Now.Year + 543
    Dim bgWorker As New BackgroundWorker

    Private Sub frmSmartCard_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F7
                Call btnRead_Click(sender, e)
            Case Keys.F10
                Me.Close()
        End Select
    End Sub

    Private Sub frmSmartCard_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtBirthDate.Value = DateTime.Now.AddYears(543)
        txtBirthDate.Format = DateTimePickerFormat.Custom
        txtBirthDate.CustomFormat = "dd/MM/yyyy"
        txtBirthDate.ShowUpDown = True
        Call SetupScreen()
        Using conn As New SqlConnection("Server=localhost\sqlexpress;Database=ClinicNisa;Trusted_Connection=True;")
            Using cmd As New SqlCommand("", conn)
                conn.Open()
                Dim txtName As String
                '// Select the first cell(no,0,0)with only then 4 char from the right FROM dbo.customer WHERE we get the 2 char from no = the current thai year the 2 char from right order by desc :P
                cmd.CommandText &= "SELECT TOP 1 RIGHT(no,5) FROM dbo.customer ORDER BY no Desc"
                txtName = IIf(IsDBNull(cmd.ExecuteScalar), "", cmd.ExecuteScalar)
                If txtName = "" Then
                    txtName = "00000"
                End If
                Dim dateno As String = Convert.ToString(Microsoft.VisualBasic.Right(datethai, 2)) 'Get the last 2 digits of current year

                txtno.Text = (CInt(dateno + txtName) + 1).ToString
            End Using
        End Using
        '// Detect Smart card reader.
        If Not GetReader() Then Return
        ProgressBar1.Visible = False
        '// Initialized BackGroundWorker
        With bgWorker
            .WorkerReportsProgress = True
            .WorkerSupportsCancellation = True
        End With
        '// *********** IMPORTANT ***********
        Control.CheckForIllegalCrossThreadCalls = False
        '// Add Event Handler.
        AddHandler bgWorker.DoWork, AddressOf bgWorker_DoWork
        AddHandler bgWorker.RunWorkerCompleted, AddressOf bgWorker_RunWorkerCompleted


    End Sub

    '// ตรวจสอบเครื่องอ่านบัตรว่ามีอยู่หรือไม่
    Function GetReader() As Boolean
        Try
            Dim ID As New ThaiIDCard
            Dim readers = ID.GetReaders
            If readers Is Nothing Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show("Smart Card Reader not found.", "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End Try
    End Function

    Private Sub btnRead_Click(sender As System.Object, e As System.EventArgs) Handles btnRead.Click
        Call SetupScreen()
        If Not GetReader() Then Return
        btnRead.Enabled = False
        '/
        ProgressBar1.Style = ProgressBarStyle.Marquee
        ProgressBar1.Visible = True
        '// BackGroundWorker
        bgWorker.RunWorkerAsync()
    End Sub

    Private Sub bgWorker_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs)
        Try
            '// -------------------------------------------
            '// โค้ดส่วนของการอ่านข้อมูลบัตรประชาชน
            Dim ID As New ThaiIDCard
            Refresh()
            Using conn As New SqlConnection("Server=localhost\sqlexpress;Database=ClinicNisa;Trusted_Connection=True;")
                Using cmd As New SqlCommand("", conn)
                    conn.Open()
                    Dim txtName As String
                    '// Select the first cell(no,0,0)with only then 4 char from the right FROM dbo.customer WHERE we get the 2 char from no = the current thai year the 2 char from right order by desc :P
                    cmd.CommandText &= "SELECT TOP 1 RIGHT(no,5) FROM dbo.customer ORDER BY no Desc"
                    txtName = IIf(IsDBNull(cmd.ExecuteScalar), "", cmd.ExecuteScalar)
                    If txtName = "" Then
                        txtName = "00000"
                    End If
                    Dim dateno As String = Convert.ToString(Microsoft.VisualBasic.Right(datethai, 2)) 'Get the last 2 digits of current year

                    txtno.Text = (CInt(dateno + txtName) + 1).ToString
                End Using
            End Using
            Dim Personal As Personal = ID.readAllPhoto
            If Not IsNothing(Personal) Then
                With Personal

                    txtIDCard.Text = .Citizenid
                    txtName_thai.Text = .Th_Prefix + .Th_Firstname + " " + .Th_Lastname
                    txtBirthDate.Value = .Birthday.AddYears(543)
                    '// คำนวณอายุ
                    If Not IsNothing(txtBirthDate.Value) Then lblAge.Text = CalcDate(txtBirthDate.Value, Now())
                    '// 1 = ชาย, 2 = หญิง (นำไปแปลงค่าเพศในฟังค์ชั่นก่อน)
                    txtIssueDate.Text = Format(CDate(.Issue.ToString), "dd/MM/yyyy")
                    txtExpireDate.Text = Format(CDate(.Expire.ToString), "dd/MM/yyyy")
                    '// ที่อยู่
                    txtHouseNo.Text = .addrHouseNo
                    txtVillageNo.Text = .addrVillageNo.Replace("หมู่ที่", "")
                    txtRoad.Text = .addrRoad.Replace("ถนน", "")
                    txtTambol.Text = .addrTambol.Replace("ตำบล", "")
                    txtDistrict.Text = .addrAmphur.Replace("อำเภอ", "")
                    txtProvince.Text = .addrProvince.Replace("จังหวัด", "")
                    '// รูปภาพ
                    picData.Image = .PhotoBitmap
                End With
                '// -------------------------------------------



            ElseIf (ID.ErrorCode() > 0) Then
                MessageBox.Show(ID.Error)
            Else
                MessageBox.Show("Catch All", "รายงานความผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        btnRead.Enabled = True
    End Sub

    '// Reading complete.
    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs)
        ProgressBar1.Visible = False
        'MessageBox.Show("Done Complete.", "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Function CheckSex(ByVal sex As Byte, ByRef txt As TextBox) As String
        '// เก็บค่าตัวเลขไว้ใน Tag เผื่อไว้ตอนไปเก็บลงในฐานข้อมูล [กำหนดให้ ชาย=1 หญิง=2]
        txt.Tag = sex
        If sex = 1 Then
            CheckSex = "ชาย"
        Else
            CheckSex = "หญิง"
        End If
    End Function

    '// เคลียร์หน้าจอทั้งหมด
    Sub SetupScreen()
        '// หรือสั่งลูปเคลียร์ TextBox Control ทั้งหมดที่มีอยู่บนฟอร์ม
        For Each tb As TextBox In Me.GroupBox1.Controls.OfType(Of TextBox)()
            tb.Clear()
        Next
        picData.Image = Nothing
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmSmartCard_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        GC.SuppressFinalize(Me)
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / ฟังค์ชั่นในการคำนวณหาความแตกต่างระหว่างวันเดือนปี (คำนวณหาอายุ)
    ' / คัดลอกโค้ดทั้งหมดมาจาก VB6 
    Public Function CalcDate(sDate As Date, eDate As Date) As String
        Dim vDays As Integer
        Dim vMonths As Integer
        Dim vYears As Integer
        '/ Parameters:
        '/    sDate - ค่าวันเดือนปีเกิด (หรือวันเดือนปีที่ต้องการคำนวณหา)
        '/    eDate - คำนวณเทียบกับวันเดือนปีปัจจุบัน (Now())
        '/ Results:
        '/    vYears - เก็บค่าความแตกต่างของจำนวนปี
        '/    vMonths - เก็บค่าความแตกต่างของจำนวนเดือน
        '/    vDays - เก็บค่าความแตกต่างของจำนวนวัน

        '/ หาความแตกต่างของจำนวนเดือน
        vMonths = DateDiff("m", sDate, eDate.AddYears(543))
        vDays = DateDiff("d", DateAdd("m", vMonths, sDate), eDate.AddYears(543))
        If vDays < 0 Then
            vMonths = vMonths - 1
            vDays = DateDiff("d", DateAdd("m", vMonths, sDate), eDate.AddYears(543))
        End If
        vYears = vMonths \ 12 ' หารตัดเศษก็จะได้จำนวนปี
        vMonths = vMonths Mod 12 ' การหารเอาเศษ โดยจะมีค่าระหว่าง 0, 1, 2, ... 11 ไม่มีทางเท่ากับ หรือ มากกว่า 12
        CalcDate = "อายุ: " & vYears & " ปี " & vMonths & " เดือน " & vDays & " วัน."
    End Function

    Private Sub btnInsertCus_Click(sender As Object, e As EventArgs) Handles btnInsertCus.Click
        '// อันนี้จะเพิ่มแล้วค้นหาใน SQL ว่ามีชื่อซ้ำไหม ยังไม่ได้

        'Dim connection As New SqlConnection("server=localhost\sqlexpress;database=clinicnisa;trusted_connection=true;")
        'Dim command As New SqlCommand("select name_thai from dbo.customer where @name_thai = '@name_thai'", connection)
        'command.Parameters.AddWithValue("@name_thai", txtName_Thai.Text)
        'connection.Open()
        'Dim reader As SqlDataReader = command.ExecuteReader()
        'If reader.GetOrdinal("name_thai") < 0 Then
        '    Dim diagres As DialogResult = MessageBox.Show("พบว่ามีรายชื่ออยู่แล้ว ยังต้องการเพิ่มหรือไม่", "มีรายชื่ออยู่แล้ว ต้องการเพิ่ม?", MessageBoxButtons.YesNo)
        '    If diagres = DialogResult.Yes Then
        '        MessageBox.Show("ยกเลิกการเพิ่มรายชื่อ")
        '        reader.Close()
        '        connection.Close()
        '        Exit Sub
        '    End If
        'End If

        If txtIDCard.Text = Nothing And txtName_Thai.Text = Nothing Then
            MessageBox.Show("กรุณากรอกข้อมูลเพิ่มเติม")
        Else
            Dim query As String = String.Empty
            query &= "SET IDENTITY_INSERT dbo.customer ON; INSERT INTO [dbo].[customer]
           (
            [no]
           ,[id]
           ,[name_thai]
           ,[tel]
           ,[line]
           ,[birth]
           ,[drug_allergy]
           ,[congenital_disease]
           ,[weight]
           ,[height]
           ,[period]
           ,[addressNo]
           ,[addressMu]
           ,[addressRoad]
           ,[addressTambol]
           ,[addressDistrict]
           ,[addressProvince]
           ,[addinfo]
            )
                VALUES
            (@colno, @colId, @colname_thai, @coltel, @colline, @colbirth, @coldrug_allergy, @colcongenital_disease,
            @colweight, @colheight,@colperiod ,@coladdressNo, @coladdressMu, @coladdressRoad, @coladdressTambol, @coladdressDistrict, @coladdressProvince, @coladdinfo)
            "
            Using conn As New SqlConnection("Server=localhost\sqlexpress;Database=ClinicNisa;Trusted_Connection=True;")
                Dim period As String
                Using comm As New SqlCommand()
                    With comm

                        .Connection = conn
                        .CommandType = System.Data.CommandType.Text
                        .CommandText = query

                        .Parameters.AddWithValue("@colno", txtno.Text)
                        .Parameters.AddWithValue("@colId", txtIDCard.Text)
                        .Parameters.AddWithValue("@colname_thai", txtName_Thai.Text)
                        .Parameters.AddWithValue("@coltel", txtTel.Text)
                        If checkLinetrue.Checked = True And txtLinechecked.Text = "" Then
                            txtLinechecked.Text = "มี"
                        ElseIf checkLinetrue.Checked = False Then
                            txtLinechecked.Text = "ไม่มี"
                        End If
                        .Parameters.AddWithValue("@colline", txtLinechecked.Text)
                        .Parameters.AddWithValue("@colbirth", txtBirthDate.Value)
                        .Parameters.AddWithValue("@coldrug_allergy", txtDrug_allergy.Text)
                        .Parameters.AddWithValue("@colcongenital_disease", txtCongenital_disease.Text)
                        .Parameters.AddWithValue("@colweight", txtWeight.Text)
                        .Parameters.AddWithValue("@colheight", txtHeight.Text)
                        If (PeriodNormal.Checked) Then
                            period = "ปกติ"
                        ElseIf (PeriodNotNormal.Checked) Then
                            period = "ไม่ปกติ"
                        Else period = ""
                        End If
                        .Parameters.AddWithValue("@colperiod", period)
                        .Parameters.AddWithValue("@coladdressNo", txtHouseNo.Text)
                        .Parameters.AddWithValue("@coladdressMu", txtVillageNo.Text)
                        .Parameters.AddWithValue("@coladdressRoad", txtRoad.Text)
                        .Parameters.AddWithValue("@coladdressTambol", txtTambol.Text)
                        .Parameters.AddWithValue("@coladdressDistrict", txtDistrict.Text)
                        .Parameters.AddWithValue("@coladdressProvince", txtProvince.Text)
                        .Parameters.AddWithValue("@coladdinfo", txtAddinfo.Text)
                    End With

                    Try
                        conn.Open()
                        comm.ExecuteNonQuery()
                        MessageBox.Show("เพิ่มผู้ป่วยชื่อ" + txtName_Thai.Text + "สำเร็จ")

                    Catch ex As SqlException
                        MessageBox.Show(ex.Message.ToString(), "Error Message")
                    End Try
                End Using
            End Using
        End If
    End Sub

    Private Sub checkLine_CheckedChanged(sender As Object, e As EventArgs) Handles checkLinetrue.CheckedChanged
        If checkLinetrue.Checked = True Then
            txtLinechecked.Enabled = True


        Else
            txtLinechecked.Enabled = False
        End If
    End Sub
End Class