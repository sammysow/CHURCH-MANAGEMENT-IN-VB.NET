Imports MySql.Data.MySqlClient
Imports Emgu.CV
Public Class Add_Member
    Dim conn As MySqlConnection 'for connection to the database
    Dim cmd As MySqlCommand ' to query the database for data
    Dim read As MySqlDataReader ' to read the information return from the database for display or any action to be taken
    Dim bmp As Bitmap
    Dim capture As New Capture

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
    Private Sub MemID()
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost;userid=root;password=;database=youth"
        Dim query As String = "select count(id) from youth.members"
        Dim id As Integer = Nothing
        Try
            conn.Open()
            cmd = New MySqlCommand(query, conn)
            read = cmd.ExecuteReader()

            If read.Read = True Then
                id = read.GetInt32("count(id)")

                If id = 0 Then
                    id.ToString()
                    lblMemID.Text = "OFKCOC001"

                ElseIf id > 0 Then

                    Dim newId As Integer = id + 1
                    newId.ToString()
                    lblMemID.Text = "OFKCOC00" & newId

                End If
            End If
            conn.Close()
        Catch ex As MySqlException
            conn.Close()
        End Try
    End Sub

    Private Sub AddMem()
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost;userid=root;password=;database=youth"

        Dim ms As New System.IO.MemoryStream()
        Picbox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage = ms.GetBuffer()
        Dim FileSize As UInt32
        FileSize = ms.Length

        ms.Close()

        Dim Full_name As String = txtName.Text.ToUpper
        Dim mem_id As String = lblMemID.Text.ToUpper
        Dim Gender As String = cGender.Text.ToUpper
        Dim Phone_Number As String = txtphone.Text.ToUpper
        Dim Email As String = txtEmail.Text.ToUpper
        Dim Date_of_Birth As String = dob.Value.Date.ToString()
        Dim Date_Baptized As String = dBapt.Value.Date.ToString()
        Dim Place_Baptized As String = txtPbap.Text.ToUpper
        Dim Zone As String = Cmbzone.Text.ToUpper
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

        Dim q As String
        q = "insert into youth.members(Full_name,mem_id,Gender,Phone_Number,Email,Date_of_Birth,
        Date_Baptized,Place_Baptized,Zone,Nationality,Hometown,Region,House_address,Occupation,
        Marital_status,Number_child,Spouse_name,Spouse_contact,Relationship,Transferred_from,
        Transferred_from_Date,Transferred_to,Transferred_to_Date,Postal_Address,death,Title,Age,
        Place_birth,Country_birth,Suburb,City_residence,House_number,Street_name,Type_employment,
        Place_work,Education_level,Institution_name,Location_work,Ministry,Father_phone,Father_house,
        Father_postal,Mother_house,Mother_phone,Mother_postal, Father_Name,Father_hometown,Father_region,
        Mother_Name,Mother_hometown,Mother_region,img)values
        ('" + Full_name + "','" + mem_id + "','" + Gender + "','" + Phone_Number + "','" + Email + "',
        '" + Date_of_Birth + "','" + Date_Baptized + "','" + Place_Baptized + "','" + Zone + "','" + Nationality + "',
        '" + Hometown + "', '" + Region + "','" + House_address + "', '" + Occupation + "', '" + Marital_status + "',
        '" + Number_child + "', '" + Spouse_name + "', '" + Spouse_contact + "', '" + Relationship + "',
        '" + Transferred_from + "', '" + Transferred_from_Date + "', '" + Transferred_to + "',
        '" + Transferred_to_Date + "','" + Postal_Address + "','" + death + "','" + Title + "','" + Age + "',
        '" + Place_birth + "','" + Country_birth + "','" + Suburb + "','" + City_residence + "', '" + House_number + "',
        '" + street_name + "', '" + Type_employment + "', '" + Place_work + "', '" + Education_level + "',
        '" + institution_name + "','" + location_work + "','" + Ministry + "','" + Father_phone + "', 
        '" + Father_house + "', '" + Father_postal + "', '" + Mother_phone + "','" + Mother_house + "','" + Mother_postal + "',
        '" + Father_Name + "','" + Father_hometown + "','" + Father_region + "','" + Mother_Name + "','" + Mother_hometown + "','" + Mother_region + "',@img)"

        If Full_name = "" Or Gender = "" Or Zone = "" Then
            MessageBox.Show("Fill in all Fields")
            Return
        Else
            Try
                conn.Open()
                cmd = New MySqlCommand(q, conn)
                cmd.Parameters.Add(New MySqlParameter("@img", arrImage))
                read = cmd.ExecuteReader()
                'Return
                MessageBox.Show("Member " + Full_name + " Added Successfully")
            Catch ex As MySqlException
                MessageBox.Show("Error>> " + ex.Message)
                conn.Close()
            End Try
        End If
        conn.Close()

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
        Cmbzone.Text = ""
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
    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        Pic()

    End Sub

    Private Sub Add_Member_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '............................................Disable button for Add member forms
        MemID()

    End Sub

    Private Sub TxtFullname_TextChanged(sender As Object, e As EventArgs)
        '...................................Enable Add,clear buttons when clicked
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        AddMem()
        MemID()
        reset()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        reset()

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Picbox.ImageLocation = OpenFileDialog1.FileName
    End Sub
    Private Sub Picbox_Click(sender As Object, e As EventArgs) Handles Picbox.Click
        Timer1.Start()

    End Sub

    Private Sub Btncapture_Click(sender As Object, e As EventArgs) Handles Btncapture.Click
        Timer1.Stop()
        capture.Dispose


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

    Private Sub dBapt_ValueChanged(sender As Object, e As EventArgs) Handles dBapt.ValueChanged
        dBapt.Value = Date.Now.ToString()
    End Sub

    Private Sub transDate_ValueChanged(sender As Object, e As EventArgs) Handles transDate.ValueChanged
        transDate.Value = Date.Now.ToString()
    End Sub

    Private Sub transDateto_ValueChanged(sender As Object, e As EventArgs) Handles transDateto.ValueChanged
        transDateto.Value = Date.Now.ToString()
    End Sub

    Private Sub dod_ValueChanged(sender As Object, e As EventArgs) Handles dod.ValueChanged
        dod.Value = Date.Now.ToString()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Picbox.Image = capture.QueryFrame.Bitmap

        Catch ex As Exception
            capture = New Capture
        End Try
    End Sub
End Class