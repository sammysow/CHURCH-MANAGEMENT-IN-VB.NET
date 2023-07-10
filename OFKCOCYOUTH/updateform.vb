Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text
Imports Emgu.CV
Public Class updateform
    Dim conn As MySqlConnection 'for connection to the database
    Dim cmd As MySqlCommand ' to query the database for data
    Dim read As MySqlDataReader ' to read the information return from the database for display or any action to be taken
    Dim dtable As New DataTable
    Dim dadapter As MySqlDataAdapter
    Dim myconnection As New DTConnect
    Dim capture As New Capture

    Private Sub getMember()
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost;userid=root;password=;database=youth"
        Dim read As MySqlDataReader

        Dim search As String = txtSearch.Text
        Dim q As String
        q = "select * from youth.members where Full_name like '%" + search + "%' or mem_id like '%" + search + "%' "


        Try
            conn.Open()


            cmd = New MySqlCommand(q, conn)


            read = cmd.ExecuteReader

            Dim arrImage() As Byte
            'fetch data from database

            If read.Read = False Then
                reset()
                MessageBox.Show("User not Found!", "Error Message")

            Else
                lblMemID.Text = read.GetString("mem_id")
                txtName.Text = read.GetString("Full_name")
                cGender.Text = read.GetString("Gender")
                txtphone.Text = read.GetString("Phone_Number")
                txtEmail.Text = read.GetString("Email")
                dob.Text = read.GetString("Date_of_Birth")
                dBapt.Text = read.GetString("Date_Baptized")
                txtPbap.Text = read.GetString("Place_Baptized")
                Cmbzone.Text = read.GetString("Zone")
                cNation.Text = read.GetString("Nationality")
                txtHome.Text = read.GetString("Hometown")
                cmbr.Text = read.GetString("Region")
                txtHouse.Text = read.GetString("House_address")
                txtOccu.Text = read.GetString("Occupation")
                cMstatus.Text = read.GetString("Marital_status")
                txtNumChild.Text = read.GetString("Number_child")
                txtSpname.Text = read.GetString("Spouse_name")
                txtSpcon.Text = read.GetString("Spouse_contact")
                txtRelaname.Text = read.GetString("Relationship")
                txtTransf.Text = read.GetString("Transferred_from")
                transDate.Text = read.GetString("Transferred_from_Date")
                txtTranst.Text = read.GetString("Transferred_to")
                transDateto.Text = read.GetString("Transferred_to_Date")
                txtPostal.Text = read.GetString("Postal_Address")
                dod.Text = read.GetString("death")
                txtFname.Text = read.GetString("Father_Name")
                txtfht.Text = read.GetString("Father_hometown")
                Cmbfr.Text = read.GetString("Father_region")
                txtMname.Text = read.GetString("Mother_Name")
                txtmht.Text = read.GetString("Mother_hometown")
                Cmbmr.Text = read.GetString("Mother_region")
                cmbtitle.Text = read.GetString("Title")
                Txtage.Text = read.GetString("Age")
                Txtplace.Text = read.GetString("Place_birth")
                Cmbcountry.Text = read.GetString("Country_birth")
                Txtsuburb.Text = read.GetString("Suburb")
                Txtcity.Text = read.GetString("City_residence")
                TxtHno.Text = read.GetString("House_number")
                Txtstreet.Text = read.GetString("Street_name")
                Cmbtype.Text = read.GetString("Type_employment")
                TxtPwork.Text = read.GetString("Place_work")
                Txtedu.Text = read.GetString("Education_level")
                Txtinsti.Text = read.GetString("Institution_name")
                Txtloc.Text = read.GetString("Location_work")
                Cmbmin.Text = read.GetString("Ministry")
                Txtfatherp.Text = read.GetString("Father_phone")
                Txtfatherh.Text = read.GetString("Father_house")
                Txtfatherpa.Text = read.GetString("Father_postal")
                Txtmotherh.Text = read.GetString("Mother_house")
                Txtmotherp.Text = read.GetString("Mother_phone")
                Txtmotherpa.Text = read.GetString("Mother_postal")

                arrImage = CType(read("img"), Byte())
                If arrImage Is Nothing Then
                    Picbox.Image = Nothing
                Else
                    Dim ms As New System.IO.MemoryStream(arrImage)
                    Picbox.Image = Image.FromStream(ms)
                End If


            End If


            If txtSearch.Text = "" Then
                Autocomplete()

                reset()
            End If

            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error Message")
            conn.Close()
        End Try
    End Sub

    Private Sub reset()
        lblMemID.Text = ""
        txtName.Text = ""
        cGender.Text = ""
        txtphone.Text = ""
        txtEmail.Text = ""
        dob.Text = Date.Now()
        dBapt.Text = Date.Now()
        txtPbap.Text = ""
        cmbzone.Text = ""
        cNation.Text = ""
        txtHome.Text = ""
        cmbr.Text = ""
        txtHouse.Text = ""
        txtOccu.Text = ""
        cMstatus.Text = ""
        txtNumChild.Text = ""
        txtSpname.Text = ""
        txtSpcon.Text = ""
        txtRelaname.Text = ""
        txtTransf.Text = ""
        transDate.Text = Date.Now()
        txtTranst.Text = ""
        transDateto.Text = Date.Now()
        txtPostal.Text = ""
        dod.Text = Date.Now()
        txtFname.Text = ""
        txtfht.Text = ""
        Cmbfr.Text = ""
        txtMname.Text = ""
        txtmht.Text = ""
        Cmbmr.Text = ""
        Picbox.Image = Nothing
        txtSearch.Text = ""
        cmbtitle.Text = ""
        Txtage.Text = ""
        Txtplace.Text = ""
        Cmbcountry.Text = ""
        Txtsuburb.Text = ""
        Txtcity.Text = ""
        TxtHno.Text = ""
        Txtstreet.Text = ""
        Cmbtype.Text = ""
        TxtPwork.Text = ""
        Txtedu.Text = ""
        Txtinsti.Text = ""
        Txtloc.Text = ""
        Cmbmin.Text = ""
        Txtfatherp.Text = ""
        Txtfatherh.Text = ""
        Txtfatherpa.Text = ""
        Txtmotherh.Text = ""
        Txtmotherp.Text = ""
        Txtmotherpa.Text = ""
    End Sub

    Private Sub updateMem()
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost;userid=root;password=;database=youth"

        Dim Full_name As String = txtName.Text.ToUpper
        Dim mem_id As String = lblMemID.Text.ToUpper
        Dim Gender As String = cGender.Text.ToUpper
        Dim Phone_Number As String = txtphone.Text.ToUpper
        Dim Email As String = txtEmail.Text.ToUpper
        Dim Date_of_Birth As String = dob.Value.Date.ToString()
        Dim Date_Baptized As String = dBapt.Value.Date.ToString()
        Dim Place_Baptized As String = txtPbap.Text.ToUpper
        Dim Zone As String = cmbzone.Text.ToUpper
        Dim Nationality As String = cNation.Text.ToUpper
        Dim Hometown As String = txtHome.Text.ToUpper
        Dim Region As String = cmbr.Text.ToUpper
        Dim House_address As String = txtHouse.Text.ToUpper
        Dim Occupation As String = txtOccu.Text.ToUpper
        Dim Marital_status As String = cMstatus.Text.ToUpper
        Dim Number_child As String = txtNumChild.Text.ToUpper
        Dim Spouse_name As String = txtSpname.Text.ToUpper
        Dim Spouse_contact As String = txtSpcon.Text.ToUpper
        Dim Relationship As String = txtRelaname.Text.ToUpper
        Dim Transferred_from As String = txtTransf.Text.ToUpper
        Dim Transferred_from_Date As String = transDate.Value.Date.ToString()
        Dim Transferred_to As String = txtTranst.Text.ToUpper
        Dim Transferred_to_Date As String = transDateto.Value.Date.ToString()
        Dim Postal_Address As String = txtPostal.Text.ToUpper
        Dim death As String = dod.Value.Date.ToString()
        Dim Father_Name As String = txtFname.Text.ToUpper
        Dim Father_hometown As String = txtfht.Text.ToUpper
        Dim Father_region As String = Cmbfr.Text.ToUpper
        Dim Mother_Name As String = txtMname.Text.ToUpper
        Dim Mother_hometown As String = txtmht.Text.ToUpper
        Dim Mother_region As String = Cmbmr.Text.ToUpper
        Dim Title As String = cmbtitle.Text.ToUpper
        Dim Age As String = Txtage.Text.ToUpper
        Dim Place_birth As String = Txtplace.Text.ToUpper
        Dim Country_birth As String = Cmbcountry.Text.ToUpper
        Dim Suburb As String = Txtsuburb.Text.ToUpper
        Dim City_residence As String = Txtcity.Text.ToUpper
        Dim House_number As String = TxtHno.Text.ToUpper
        Dim street_name As String = Txtstreet.Text.ToUpper
        Dim Type_employment As String = Cmbtype.Text.ToUpper
        Dim Place_work As String = TxtPwork.Text.ToUpper
        Dim Education_level As String = Txtedu.Text.ToUpper
        Dim institution_name As String = Txtinsti.Text.ToUpper
        Dim location_work As String = Txtloc.Text.ToUpper
        Dim Ministry As String = Cmbmin.Text.ToUpper
        Dim Father_phone As String = Txtfatherp.Text.ToUpper
        Dim Father_house As String = Txtfatherh.Text.ToUpper
        Dim Father_postal As String = Txtfatherpa.Text.ToUpper
        Dim Mother_phone As String = Txtmotherp.Text.ToUpper
        Dim Mother_house As String = Txtmotherh.Text.ToUpper
        Dim Mother_postal As String = Txtmotherpa.Text.ToUpper




        Dim upd As String = "update youth.members set 
                                
                               Age='" + Age + "',
                               Place_birth='" + Place_birth + "',
                               Country_birth='" + Country_birth + "',
                               Suburb='" + Suburb + "',
                               City_residence='" + City_residence + "',
                               House_number='" + House_number + "',
                               Street_name='" + street_name + "',
                               Type_employment='" + Type_employment + "',
                               Place_work='" + Place_work + "',
                               Education_level='" + Education_level + "',
                               Institution_name='" + institution_name + "',
                               Location_work='" + location_work + "',
                               Ministry='" + Ministry + "',
                               Father_phone='" + Father_phone + "',
                               Father_house='" + Father_house + "',
                               Father_postal='" + Father_postal + "',
                               Mother_phone='" + Mother_phone + "',
                               Mother_house='" + Mother_house + "',
                               Mother_postal='" + Mother_postal + "',
                               mem_id='" + mem_id + "',
                               Gender='" + Gender + "',
                               Phone_Number='" + Phone_Number + "',
                               Email='" + Email + "',
                               Date_of_Birth='" + Date_of_Birth + "', 
                               Date_Baptized='" + Date_Baptized + "', 
                               Place_Baptized='" + Place_Baptized + "', 
                               Zone='" + Zone + "', 
                               Nationality='" + Nationality + "', 
                               Hometown='" + Hometown + "', 
                               Region='" + Region + "', 
                               House_address='" + House_address + "', 
                               Occupation='" + Occupation + "', 
                               Marital_status='" + Marital_status + "', 
                               Number_child='" + Number_child + "', 
                               Spouse_name='" + Spouse_name + "', 
                               Spouse_contact='" + Spouse_contact + "', 
                               Relationship='" + Relationship + "', 
                               Transferred_from='" + Transferred_from + "', 
                               Transferred_from_Date='" + Transferred_from_Date + "', 
                               Transferred_to='" + Transferred_to + "',
                               Transferred_to_Date='" + Transferred_to_Date + "',
                               Postal_Address='" + Postal_Address + "',
                               death='" + death + "',
                               Father_Name='" + Father_Name + "',
                               Father_hometown='" + Father_hometown + "',
                               Father_region='" + Father_region + "',
                               Mother_Name='" + Mother_Name + "',
                               Mother_hometown='" + Mother_hometown + "',
                               Mother_region='" + Mother_region + "',
                               img=@img      where mem_id='" + mem_id + "'"

        Dim ms As New System.IO.MemoryStream()
        Picbox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage = ms.GetBuffer()
        Dim FileSize As UInt32
        FileSize = ms.Length
        ms.Close()
        Try
            conn.Open()
            cmd = New MySqlCommand(upd, conn)
            Dim p As New MySqlParameter("@img", MySqlDbType.LongBlob)
            p.Value = arrImage
            cmd.Parameters.Add(p)
            read = cmd.ExecuteReader()

            MessageBox.Show("Member " + Full_name + " Updated Successfully")
        Catch ex As MySqlException
            MessageBox.Show("Error>> " + ex.Message)
            conn.Close()
        End Try

    End Sub

    Private Sub delete()
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost;userid=root;password=;database=youth"
        Dim read As MySqlDataReader ' to read the information return from the database for display or any action to be taken

        Try
            conn.Open() 'open the connection created

            Dim Full_name As String = txtName.Text.ToUpper
            Dim mem_id As String = lblMemID.Text.ToUpper
            Dim Gender As String = cGender.Text.ToUpper
            Dim Phone_Number As String = txtphone.Text.ToUpper
            Dim Email As String = txtEmail.Text.ToUpper
            Dim Date_of_Birth As String = dob.Value.Date.ToString()
            Dim Date_Baptized As String = dBapt.Value.Date.ToString()
            Dim Place_Baptized As String = txtPbap.Text.ToUpper
            Dim Zone As String = cmbzone.Text.ToUpper
            Dim Nationality As String = cNation.Text.ToUpper
            Dim Hometown As String = txtHome.Text.ToUpper
            Dim Region As String = cmbr.Text.ToUpper
            Dim House_address As String = txtHouse.Text.ToUpper
            Dim Occupation As String = txtOccu.Text.ToUpper
            Dim Marital_status As String = cMstatus.Text.ToUpper
            Dim Number_child As String = txtNumChild.Text.ToUpper
            Dim Spouse_name As String = txtSpname.Text.ToUpper
            Dim Spouse_contact As String = txtSpcon.Text.ToUpper
            Dim Relationship As String = txtRelaname.Text.ToUpper
            Dim Transferred_from As String = txtTransf.Text.ToUpper
            Dim Transferred_from_Date As String = transDate.Value.Date.ToString()
            Dim Transferred_to As String = txtTranst.Text.ToUpper
            Dim Transferred_to_Date As String = transDateto.Value.Date.ToString()
            Dim Postal_Address As String = txtPostal.Text.ToUpper
            Dim death As String = dod.Value.Date.ToString()
            Dim Father_Name As String = txtFname.Text.ToUpper
            Dim Father_hometown As String = txtfht.Text.ToUpper
            Dim Father_region As String = Cmbfr.Text.ToUpper
            Dim Mother_Name As String = txtMname.Text.ToUpper
            Dim Mother_hometown As String = txtmht.Text.ToUpper
            Dim Mother_region As String = Cmbmr.Text.ToUpper
            Dim Title As String = cmbtitle.Text.ToUpper
            Dim Age As String = Txtage.Text.ToUpper
            Dim Place_birth As String = Txtplace.Text.ToUpper
            Dim Country_birth As String = Cmbcountry.Text.ToUpper
            Dim Suburb As String = Txtsuburb.Text.ToUpper
            Dim City_residence As String = Txtcity.Text.ToUpper
            Dim House_number As String = TxtHno.Text.ToUpper
            Dim street_name As String = Txtstreet.Text.ToUpper
            Dim Type_employment As String = Cmbtype.Text.ToUpper
            Dim Place_work As String = TxtPwork.Text.ToUpper
            Dim Education_level As String = Txtedu.Text.ToUpper
            Dim institution_name As String = Txtinsti.Text.ToUpper
            Dim location_work As String = Txtloc.Text.ToUpper
            Dim Ministry As String = Cmbmin.Text.ToUpper
            Dim Father_phone As String = Txtfatherp.Text.ToUpper
            Dim Father_house As String = Txtfatherh.Text.ToUpper
            Dim Father_postal As String = Txtfatherpa.Text.ToUpper
            Dim Mother_phone As String = Txtmotherp.Text.ToUpper
            Dim Mother_house As String = Txtmotherh.Text.ToUpper
            Dim Mother_postal As String = Txtmotherpa.Text.ToUpper


            Dim Query As String

            Query = "Delete from youth.members where mem_id='" + mem_id + "'"
            cmd = New MySqlCommand(Query, conn)

            read = cmd.ExecuteReader
            Dim dialog As DialogResult
            dialog = MessageBox.Show("Are you Sure, you want to Delete?", "DELETE MEMBER", MessageBoxButtons.YesNo)
            If dialog = DialogResult.No Then
                dialog = True
            Else
                MessageBox.Show("Member Deleted Successfully")
                reset()
            End If


            conn.Close()
        Catch ex As MySqlException

            MessageBox.Show(ex.Message, "Error Message")

        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub updateform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'AutoComplete()
    End Sub
    Sub Autocomplete()
        Dim search As String = txtSearch.Text
        cmd.Connection = myconnection.Open
        cmd.CommandText = "select * from youth.members where Full_name like '%" + search + "%' or mem_id like '%" + search + "%' "
        Dim ds As New DataSet
        dadapter = New MySqlDataAdapter(cmd)
        dadapter.Fill(ds, "Full_name")
        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("Full_name").ToString)
        Next
        myconnection.Close()
        txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtSearch.AutoCompleteCustomSource = col
        txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest

    End Sub
    Private Sub Pic()
        Try
            With OpenFileDialog1
                .Filter = ("Images|*.png; *.bmp; *.jpg; *.jpeg; *.gif; *.ico;")
                .FilterIndex = 4

            End With
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Picbox.Image = Image.FromFile(OpenFileDialog1.FileName)
                Dim file As String = IO.Path.ChangeExtension(IO.Path.GetTempFileName, "jpg")
                Picbox.Image.Save(file, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim ss As New IO.FileInfo(file)
                'This to make sure that the image file is small so not to generate an error
                Dim dd As Double = (Val(ss.Length) / 1024)
                If dd > 800 Then
                    MessageBox.Show(Me, "Image should be less than 800 Kilobytes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)
        Picbox.ImageLocation = OpenFileDialog1.FileName
    End Sub

    Private Sub Btnclear_Click_1(sender As Object, e As EventArgs) Handles Btnclear.Click
        reset()
    End Sub

    Private Sub txtSearch_TextChanged_1(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        getMember()
        Autocomplete()
    End Sub

    Private Sub btnUpdate_Click_1(sender As Object, e As EventArgs) Handles btnUpdate.Click
        updateMem()
        reset()
    End Sub

    Private Sub BtnBrowse_Click_1(sender As Object, e As EventArgs)
        Try
            conn.Open()

            With OpenFileDialog1
                .Filter = ("Images|*.png; *.bmp; *.jpg; *.jpeg; *.gif; *.ico;")
                .FilterIndex = 4

            End With
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Picbox.Image = Image.FromFile(OpenFileDialog1.FileName)
                Dim file As String = IO.Path.ChangeExtension(IO.Path.GetTempFileName, "jpg")
                Picbox.Image.Save(file, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim ss As New IO.FileInfo(file)
                'This to make sure that the image file is small so not to generate an error
                Dim dd As Double = (Val(ss.Length) / 1024)
                If dd > 800 Then
                    MessageBox.Show(Me, "Image should be less than 800 Kilobytes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            conn.Close()
        End Try
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        delete()
    End Sub

    Private Sub dob_ValueChanged(sender As Object, e As EventArgs) Handles dob.ValueChanged
        Dim datecheck As String
        Dim today As System.DateTime = System.DateTime.Now
        datecheck = dob.Text

        Dim yearnow As Integer = today.Year
        Dim yeardtp As Integer = dob.Value.Year
        Dim rightyear As Integer = dob.Value.Year
        Dim minimage As Integer = yeardtp - rightyear
        Dim currentage As Integer = yearnow - yeardtp
        Txtage.Text = currentage.ToString
        Txtage.Show()
    End Sub

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        Pic()

    End Sub

    Private Sub Picbox_Click(sender As Object, e As EventArgs) Handles Picbox.Click
        Timer1.Start()
    End Sub

    Private Sub Btncapture_Click(sender As Object, e As EventArgs) Handles Btncapture.Click
        Timer1.Stop()
        Capture.Dispose
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Picbox.Image = Capture.QueryFrame.Bitmap

        Catch ex As Exception
            Capture = New Capture
        End Try
    End Sub
End Class


