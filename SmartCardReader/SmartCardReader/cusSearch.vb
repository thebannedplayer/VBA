Imports System.ComponentModel
Imports System.Data.SqlClient

Imports System.Data.SqlTypes
Imports Microsoft.SqlServer
Imports PdfSharp
Imports PdfSharp.Charting
Imports PdfSharp.Drawing
Imports PdfSharp.Fonts
Imports PdfSharp.Pdf
Imports PdfSharp.Pdf.Advanced
Imports PdfSharp.Pdf.Content.Objects
Imports System.IO
Imports System.Text
Imports System.Net.WebRequestMethods
Imports System.Text.RegularExpressions

Public Class cusSearch
    Private Sub cusSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBirthday.Value = DateTime.Now.AddYears(543)
        Try
            Me.CustomerTableAdapter.Fill(Me.ClinicNisaDataSet.customer)
            CustomerDataGridView.Sort(CustomerDataGridView.Columns(0), ListSortDirection.Descending)
            txtBirthday.Format = DateTimePickerFormat.Custom

            txtBirthday.CustomFormat = "dd/MM/yyyy"
            txtBirthday.ShowUpDown = True

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSearchNo_Click(sender As Object, e As EventArgs) Handles BtnSearchNo.Click
        Using conn As New SqlConnection("Server=localhost\sqlexpress;Database=ClinicNisa;Trusted_Connection=True;")
            Try
                Me.CustomerBindingSource.Filter = " no = '" & txtSearchBox.Text & "'"
            Catch ex As Exception
                MsgBox("กรุณากรอกข้อมูลที่ต้องการค้นหา หรือติดต่อเจ้าหน้าที่")
            End Try

        End Using
    End Sub

    Private Sub btnSearchId_Click(sender As Object, e As EventArgs) Handles BtnSearchId.Click
        Using conn As New SqlConnection("Server=localhost\sqlexpress;Database=ClinicNisa;Trusted_Connection=True;")
            Try
                Me.CustomerBindingSource.Filter = "id = '" & txtSearchBox.Text & "'"
            Catch ex As Exception
                MsgBox("กรุณากรอกข้อมูลที่ต้องการค้นหา หรือติดต่อเจ้าหน้าที่")
            End Try
        End Using
    End Sub

    Private Sub btnSearchTel_Click(sender As Object, e As EventArgs) Handles BtnSearchTel.Click
        Using conn As New SqlConnection("Server=localhost\sqlexpress;Database=ClinicNisa;Trusted_Connection=True;")
            Try
                Me.CustomerBindingSource.Filter = "tel LIKE  '%" & txtSearchBox.Text & "%'"
                Me.CustomerBindingSource.Filter = CustomerBindingSource.Filter.Replace("Or tel LIKE '%-%'", "")

            Catch ex As Exception
                MsgBox("กรุณากรอกข้อมูลที่ต้องการค้นหา หรือติดต่อเจ้าหน้าที่")
            End Try
        End Using
    End Sub

    Private Sub BtnSearchName_Click(sender As Object, e As EventArgs) Handles BtnSearchName.Click
        Using conn As New SqlConnection("Server=localhost\sqlexpress;Database=ClinicNisa;Trusted_Connection=True;")
            Try
                Me.CustomerBindingSource.Filter = "name_thai LIKE '%" & txtSearchBox.Text & "%'"
            Catch ex As Exception
                MsgBox("กรุณากรอกข้อมูลที่ต้องการค้นหา หรือติดต่อเจ้าหน้าที่")
            End Try
        End Using
    End Sub

    Private Sub btnUpdateCus_Click(sender As Object, e As EventArgs) Handles btnUpdateCus.Click

        Dim DiagRes As DialogResult = MessageBox.Show("ต้องการแก้ไขข้อมูลหรือไม่", "ยืนยันการแก้ไขข้อมูล", MessageBoxButtons.YesNo)
        If DiagRes = DialogResult.Yes Then
            Dim query As String = String.Empty
            query &= "UPDATE [dbo].[customer] SET
           [id] = @colId
           ,[name_thai] = @colname_thai
           ,[tel] = @coltel
           ,[line] = @colline
           ,[birth] = @colbirth
           ,[drug_allergy] = @coldrug_allergy
           ,[congenital_disease] = @colcongenital_disease
           ,[weight] = @colweight
           ,[height] = @colheight
           ,[period] = @colperiod
           ,[addinfo] = @coladdinfo
           ,[addressNo] = @coladdressNo
           ,[addressMu] = @coladdressMu
           ,[addressRoad] = @coladdressRoad
           ,[addressTambol] = @coladdressTambol
           ,[addressDistrict] =  @coladdressDistrict
           ,[addressProvince] = @coladdressProvince
           
            WHERE [no] = @colno
           "
            Using conn As New SqlConnection("Server=localhost\sqlexpress;Database=ClinicNisa;Trusted_Connection=True;")
                    Using comm As New SqlCommand()
                        With comm
                            .Connection = conn
                            .CommandType = System.Data.CommandType.Text
                            .CommandText = query
                            .Parameters.AddWithValue("@colno", txtno.Text)
                            .Parameters.AddWithValue("@colId", txtIDCard.Text)
                            .Parameters.AddWithValue("@colname_thai", txtNameThai.Text)

                            .Parameters.AddWithValue("@coltel", txtTel.Text)
                            .Parameters.AddWithValue("@colline", txtLinechecked.Text)
                            .Parameters.AddWithValue("@colbirth", txtBirthday.Value)
                            .Parameters.AddWithValue("@coldrug_allergy", txtDrug_allergy.Text)
                            .Parameters.AddWithValue("@colcongenital_disease", txtCongenital_disease.Text)
                            .Parameters.AddWithValue("@colweight", txtWeight.Text)
                            .Parameters.AddWithValue("@colheight", txtHeight.Text)
                            .Parameters.AddWithValue("@colperiod", txtPeriod.Text)
                            .Parameters.AddWithValue("@coladdinfo", txtAddinfo.Text)
                            .Parameters.AddWithValue("@coladdressNo", txtHouseNo.Text)
                            .Parameters.AddWithValue("@coladdressMu", txtMu.Text)
                            .Parameters.AddWithValue("@coladdressRoad", txtRoad.Text)
                            .Parameters.AddWithValue("@coladdressTambol", txtTambol.Text)
                            .Parameters.AddWithValue("@coladdressDistrict", txtDistrict.Text)
                            .Parameters.AddWithValue("@coladdressProvince", txtProvince.Text)

                        End With

                        Try
                            conn.Open()
                            comm.ExecuteNonQuery()
                        MessageBox.Show("แก้ไขผู้ป่วยชื่อ " + txtNameThai.Text + " หมายเลขบัตร " + txtIDCard.Text + " สำเร็จ")
                        Try
                                Me.CustomerTableAdapter.Fill(Me.ClinicNisaDataSet.customer)
                                CustomerDataGridView.Sort(CustomerDataGridView.Columns(0), ListSortDirection.Descending)
                            Catch ex As Exception

                            End Try
                        Catch ex As SqlException
                            MessageBox.Show(ex.Message.ToString(), "Error Message")
                        End Try
                    End Using
                End Using
            End If
    End Sub

    Private Sub btnPrintCus_Click(sender As Object, e As EventArgs) Handles btnPrintCus.Click
        Main(Me.txtno)
    End Sub

    Private Sub CustomerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ClinicNisaDataSet)

    End Sub

    Private Sub BtnOutputExcel_Click(sender As Object, e As EventArgs) Handles BtnOutputExcel.Click
        Dim connectionString As String = "Server=localhost\sqlexpress;Database=ClinicNisa;Trusted_Connection=True;"
        Dim connection As New SqlConnection(connectionString)
        connection.Open()

        ' Retrieve the data from the database
        Dim command As New SqlCommand("SELECT [no]
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
      ,[addinfo]
      ,[addressNo]
      ,[addressMu]
      ,[addressRoad]
      ,[addressTambol]
      ,[addressDistrict]
      ,[addressProvince]
  FROM [ClinicNisa].[dbo].[customer]", connection)
        Dim reader As SqlDataReader = command.ExecuteReader()

        Dim file As New StreamWriter("D:\" + Today.ToString("dd-MM-yyyy") + ".csv", False, Encoding.UTF8)

        ' Write the column names to the CSV file
        Dim columnCount As Integer = reader.FieldCount
        For i As Integer = 0 To columnCount - 1
            file.Write(reader.GetName(i))
            If i < columnCount - 1 Then
                file.Write(",")
            End If
        Next
        file.WriteLine()

        ' Iterate over the rows returned by the SELECT statement and write them to the CSV file
        While reader.Read()
            For i As Integer = 0 To columnCount - 1
                file.Write(reader(i).ToString())
                If i < columnCount - 1 Then
                    file.Write(",")
                End If
            Next
            file.WriteLine()
        End While
        MsgBox("แปลงเป็นไฟล์ CSV สำเร็จ. ไฟล์จะเก็บไว้ในไดร์ D:")

        ' Close the file and the reader
        file.Close()
        reader.Close()

        ' Disconnect from the database
        connection.Close()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim DiagRes As DialogResult = MessageBox.Show("ต้องการลบข้อมูล", "ยืนยันการลบข้อมูล", MessageBoxButtons.YesNo)
        If DiagRes = DialogResult.Yes Then
            Using conn As New SqlConnection("Server=localhost\sqlexpress;Database=ClinicNisa;Trusted_Connection=True;")
                Try
                    Dim cmd As New SqlCommand("", conn)
                    cmd.CommandText &= "DELETE FROM dbo.customer WHERE no ='" & txtno.Text & "'"
                    Try
                        conn.Open()
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("ลบข้อมูล สำเร็จ")
                        cmd.CommandText &= "DBCC CHECKIDENT('dbo.customer', RESEED)"
                        cmd.ExecuteNonQuery()
                        cusSearch_Load(sender, e)
                    Catch ex As SqlException
                        MessageBox.Show(ex.Message.ToString(), "Error Message")
                    End Try
                Catch ex As Exception
                    MsgBox("กรุณากรอกข้อมูลที่ต้องการค้นหา หรือติดต่อเจ้าหน้าที่")
                End Try
            End Using
        End If
    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.CustomerTableAdapter.Fill(Me.ClinicNisaDataSet.customer)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.CustomerTableAdapter.FillBy(Me.ClinicNisaDataSet.customer)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTel.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTel_TextChanged(sender As Object, e As EventArgs) Handles txtTel.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d\,]")
        txtTel.Text = digitsOnly.Replace(txtTel.Text, "")
    End Sub
End Class
Module Program
    Dim no As String
    Dim id As String
    Dim name_thai As String
    Dim tel As String
    Dim line As String
    Dim birth As Date
    Dim drug_allergy As String
    Dim congenital_disease As String
    Dim weight As String
    Dim height As String
    Dim period As String
    Dim addressno As String
    Dim addressmu As String
    Dim addressroad As String
    Dim addresstambol As String
    Dim addressdistrict As String
    Dim addressprovince As String
    Dim addinfo As String

    Dim str As String
    Dim na_thai As String = ""
    Dim me_thai As String = ""
    Dim lineok As String = ""
    Dim sex As String = ""
    Dim age As String = ""
    Sub Main(tb As TextBox)

        ' Create a new PDF document
        Dim document As New PdfDocument
        document.Info.Title = "Created with PDFsharp"
        str = tb.Text
        Using conn As New SqlConnection("Server=localhost\sqlexpress;Database=ClinicNisa;Trusted_Connection=True")
            Dim cmd As New SqlCommand("", conn)
            conn.Open()
            cmd.CommandText &= "SELECT
            [no]
           ,[id]
           ,[name_thai]
           ,[name_eng]
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
           ,[addinfo]FROM [dbo].[customer] WHERE no = '" & str & "'"
            Dim myReader As SqlDataReader = cmd.ExecuteReader()
            If (myReader.Read()) Then
                no = myReader.GetValue(0).ToString()
                id = myReader.GetString(1)
                name_thai = myReader.GetString(2)
                If name_thai.Contains("นาง") OrElse name_thai.Contains("นางสาว") OrElse name_thai.Contains("น.ส.") OrElse
                    name_thai.Contains("นส.") OrElse name_thai.Contains("น.ส") OrElse name_thai.Contains("เด็กหญิง") OrElse
                    name_thai.Contains("ด.ญ.") OrElse name_thai.Contains("ด.ญ") OrElse name_thai.Contains("ดญ.") Then
                    sex = "หญิง"
                ElseIf name_thai.Contains("เด็กชาย") OrElse name_thai.Contains("นาย") OrElse name_thai.Contains("ดช.") OrElse
                    name_thai.Contains("ด.ช.") OrElse name_thai.Contains("ด.ช") OrElse name_thai.Contains("พระ") Then
                    sex = "ชาย"
                Else sex = ""
                End If

                If name_thai.Count Then
                    Dim index As Int32 = name_thai.IndexOf(" ", 1)
                    If Not index < 0 Then
                        na_thai = name_thai.Substring(0, name_thai.IndexOf(" "))
                        Dim index2 As Int32 = name_thai.LastIndexOf(" ", +1)
                        me_thai = name_thai.Substring(name_thai.IndexOf(" ") + 1)
                    Else na_thai = name_thai
                    End If
                End If


                tel = myReader.GetString(4)
                line = myReader.GetString(5)
                If Not String.IsNullOrEmpty(line) Then
                    lineok = "YES"
                Else lineok = "NO"
                End If

                If myReader.IsDBNull(6) Then
                    birth = DateTime.MinValue
                Else birth = myReader.GetDateTime(6)
                End If


                age = (Today.Year + 543) - birth.Year
                If birth.Date > Today.AddYears(-age + 543) Then
                    age += -1
                End If
                drug_allergy = myReader.GetString(7)
                congenital_disease = myReader.GetString(8)
                weight = myReader.GetValue(9).ToString()
                If weight = "" Or weight = "0" Then
                    weight = "ไม่ระบุ"
                End If
                height = myReader.GetValue(10).ToString()
                If height = "" Or height = "0" Then
                    height = "ไม่ระบุ"
                End If
                period = myReader.GetString(11)
                addressno = myReader.GetString(12)
                addressmu = myReader.GetString(13)
                addressroad = myReader.GetString(14)
                addresstambol = myReader.GetString(15)
                addressdistrict = myReader.GetString(16)
                addressprovince = myReader.GetString(17)
                addinfo = myReader.GetString(18)
                period = myReader.GetString(11)
            addressno = myReader.GetString(12)
            addressmu = myReader.GetString(13)
            addressroad = myReader.GetString(14)
            addresstambol = myReader.GetString(15)
            addressdistrict = myReader.GetString(16)
            addressprovince = myReader.GetString(17)
            addinfo = myReader.GetString(18)
            End If
        End Using
        ' Create an empty(Landscape) A4 page
        Dim page As PdfPage = document.AddPage
        page.Orientation = PageOrientation.Landscape
        page.Height = 595
        page.Width = 842

        ' Get an XGraphics object for drawing
        Dim gfx As XGraphics = XGraphics.FromPdfPage(page)
        ' Draw image
        gfx.DrawImage(XImage.FromFile("images/img.png"), 500, 30, 180, 70)

        ' Create a font
        Dim font As New XFont("TH Sarabun New", 16, XFontStyle.Regular)
        GlobalFontSettings.DefaultFontEncoding = PdfFontEncoding.Unicode
        ' Draw the text
        gfx.DrawString("ชื่อ " + na_thai, font, XBrushes.Black,
        New XRect(450, -170, page.Width.Point, page.Height.Point), XStringFormats.CenterLeft)

        gfx.DrawString("นามสกุล " + me_thai, font, XBrushes.Black,
        New XRect(450, -140, page.Width.Point, page.Height.Point), XStringFormats.CenterLeft)

        gfx.DrawString("HN     " + no, font, XBrushes.Black,
        New XRect(450, -110, page.Width.Point, page.Height.Point), XStringFormats.CenterLeft)

        gfx.DrawString("@ไลน์  " + lineok, font, XBrushes.Black,
        New XRect(550, -110, page.Width.Point, page.Height.Point), XStringFormats.CenterLeft)

        gfx.DrawString("หมายเหตุ  " + addinfo, font, XBrushes.Black,
        New XRect(450, -80, page.Width.Point, page.Height.Point), XStringFormats.CenterLeft)

        gfx.DrawString("เลขที่บัตรประชาชน  " + id, font, XBrushes.Black,
        New XRect(450, -50, page.Width.Point, page.Height.Point), XStringFormats.CenterLeft)

        gfx.DrawString("เบอร์โทรศัพท์  " + tel, font, XBrushes.Black,
        New XRect(450, -20, page.Width.Point, page.Height.Point), XStringFormats.CenterLeft)

        If age > 0 And Not birth = DateTime.MinValue Then
            gfx.DrawString("อายุ  " + age + "  ปี", font, XBrushes.Black,
            New XRect(450, 10, page.Width.Point, page.Height.Point), XStringFormats.CenterLeft)
        Else
            gfx.DrawString("อายุ  " + "ไม่ระบุ" + "  ปี", font, XBrushes.Black,
            New XRect(450, 10, page.Width.Point, page.Height.Point), XStringFormats.CenterLeft)
        End If
        gfx.DrawString("เพศ  " + sex, font, XBrushes.Black,
        New XRect(540, 10, page.Width.Point, page.Height.Point), XStringFormats.CenterLeft)

        gfx.DrawString("แพ้ยา  " + drug_allergy, font, XBrushes.Black,
        New XRect(450, 40, page.Width.Point, page.Height.Point), XStringFormats.CenterLeft)

        gfx.DrawString("โรคประจำตัว  " + congenital_disease, font, XBrushes.Black,
        New XRect(450, 70, page.Width.Point, page.Height.Point), XStringFormats.CenterLeft)

        gfx.DrawString("ประจำเดือน  " + period, font, XBrushes.Black,
        New XRect(450, 100, page.Width.Point, page.Height.Point), XStringFormats.CenterLeft)

        If birth = Today Or birth = DateTime.MinValue Then
            gfx.DrawString("ว/ด/ป เกิด  " + "ไม่ระบุ", font, XBrushes.Black,
            New XRect(450, 130, page.Width.Point, page.Height.Point), XStringFormats.CenterLeft)
        Else
            gfx.DrawString("ว/ด/ป เกิด  " + birth.ToString("dd'/'MM'/'yyyy"), font, XBrushes.Black,
            New XRect(450, 130, page.Width.Point, page.Height.Point), XStringFormats.CenterLeft)
        End If

        gfx.DrawString("น้ำหนัก  " + weight + "  KG.", font, XBrushes.Black,
        New XRect(450, 160, page.Width.Point, page.Height.Point), XStringFormats.CenterLeft)

        gfx.DrawString("ส่วนสูง  " + height + "  ซม.", font, XBrushes.Black,
        New XRect(570, 160, page.Width.Point, page.Height.Point), XStringFormats.CenterLeft)

        gfx.DrawString("ที่อยู่  " + addressno, font, XBrushes.Black,
        New XRect(450, 190, page.Width.Point, page.Height.Point), XStringFormats.CenterLeft)

        gfx.DrawString("  หมู่ที่  " + addressmu + " ", font, XBrushes.Black,
        New XRect(550, 190, page.Width.Point, page.Height.Point), XStringFormats.CenterLeft)

        gfx.DrawString("  ถนน  " + addressroad, font, XBrushes.Black,
        New XRect(650, 190, page.Width.Point, page.Height.Point), XStringFormats.CenterLeft)

        gfx.DrawString("ตำบล  " + addresstambol, font, XBrushes.Black,
        New XRect(450, 220, page.Width.Point, page.Height.Point), XStringFormats.CenterLeft)

        gfx.DrawString("  อำเภอ  " + addressdistrict, font, XBrushes.Black,
        New XRect(550, 220, page.Width.Point, page.Height.Point), XStringFormats.CenterLeft)

        gfx.DrawString("จังหวัด  " + addressprovince, font, XBrushes.Black,
        New XRect(450, 250, page.Width.Point, page.Height.Point), XStringFormats.CenterLeft)


        ' Save the document...
        Dim filename As String = "D:\customer.pdf"
        document.Save(filename)
        ' ...and start a viewer.
        Process.Start(filename)

    End Sub
End Module

