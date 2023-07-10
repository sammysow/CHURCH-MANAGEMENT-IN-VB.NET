Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text

Public Class Attendance
    Dim conn As MySqlConnection 'for connection to the database
    Dim cmd As MySqlCommand ' to query the database for data
    Dim read As MySqlDataReader ' to read the information return from the database for display or any action to be taken

    Private Sub reset()
        txtName.Text = ""
        lblMemID.Text = ""
        txtphone.Text = ""
        cGender.Text = ""
        TxtSeat.Text = ""
        dob.Text = Date.Now()
        TxtSearch.Text = ""
    End Sub
    Private Sub count()
        If cGender.Text = "Female" Then
            Txtfemale.Text = Val(Txtfemale.Text) + 1

        ElseIf cGender.Text = "Male" Then
            Txtmale.Text = Val(Txtmale.Text) + 1
        End If

        Dim sum As String = Val(Txtfemale.Text) + Val(Txtmale.Text)
        Txttotal.Text = sum

    End Sub
    Private Sub memID()
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost;userid=root;password=;database=youth"
        Dim query As String = "select count(id) from attendance"
        Dim id As Integer = Nothing
        Try
            conn.Open()
            cmd = New MySqlCommand(query, conn)
            read = cmd.ExecuteReader()

            If read.Read = True Then
                id = read.GetInt32("count(id)")

                If id = 0 Then
                    id.ToString()
                    lblMemID.Text = "OFK001"

                ElseIf id > 0 Then

                    Dim newId As Integer = id + 1
                    newId.ToString()
                    lblMemID.Text = "OFK00" & newId

                End If
            End If
        Catch ex As MySqlException
            conn.Close()

        End Try
    End Sub
    Private Sub addMem()
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost;userid=root;password=;database=youth"

        Dim id As String = lblMemID.Text
        Dim Full_name As String = txtName.Text.ToUpper
        Dim mem_id As String = lblMemID.Text.ToUpper
        Dim Phone_Number As String = txtphone.Text.ToUpper
        Dim Gender As String = cGender.Text.ToUpper
        Dim Seat_Number As String = TxtSeat.Text.ToUpper
        Dim Date_of_Reporting As String = dob.Value.Date.ToString()

        Dim q As String
        q = "insert into attendance (Full_name,mem_id,Phone_Number,Gender,Seat_Number,Date_of_Reporting)values('" + Full_name + "','" + mem_id + "','" + Phone_Number + "','" + Gender + "','" + Seat_Number + "','" + Date_of_Reporting + "')"

        If Full_name = "" Or Gender = "" Or Seat_Number = "" Then
            MessageBox.Show("Fill in all Fields")
            Return

        Else
            Try
                conn.Open()
                cmd = New MySqlCommand(q, conn)
                read = cmd.ExecuteReader()
                MessageBox.Show("Member " + Full_name + " Added Successfully")
            Catch ex As MySqlException
                MessageBox.Show("Error>> " + ex.Message)
                conn.Close()

            End Try
        End If


    End Sub
    Private Sub updateMem()
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost;userid=root;password=;database=youth"

        'Dim id As String = lblMemID.Text
        Dim Full_name As String = txtName.Text.ToUpper
        Dim mem_id As String = lblMemID.Text.ToUpper
        Dim Phone_Number As String = txtphone.Text.ToUpper
        Dim Gender As String = cGender.Text.ToUpper
        Dim Seat_Number As String = TxtSeat.Text
        Dim Date_of_Reporting As String = dob.Value.Date.ToString()

        Dim upd As String = "update attendance set Full_name='" + Full_name + "', 
                               mem_id='" + mem_id + "',
                               Gender='" + Gender + "',
                               Phone_Number='" + Phone_Number + "',Seat_Number='" + Seat_Number + "',
                               Date_of_Reporting='" + Date_of_Reporting + "'," ' where mem_id='" + mem_id + "'"

        Try
            conn.Open()
            cmd = New MySqlCommand(upd, conn)
            read = cmd.ExecuteReader()
            MessageBox.Show("Member " + name + " Updated Successfully")
        Catch ex As MySqlException
            MessageBox.Show("Error>> " + ex.Message)
            conn.Close()

        End Try

    End Sub

    Private Sub getMember()
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost;userid=root;password=;database=youth"
        Dim read As MySqlDataReader

        Dim search As String = TxtSearch.Text
        Dim q As String
        q = "select * from youth.attendance where Full_name like '%" + search + "%' or mem_id like '%" + search + "%' "

        Try
            conn.Open()

            cmd = New MySqlCommand(q, conn)
            read = cmd.ExecuteReader
            'fetch data from database
            If read.Read = False Then
                Reset()
                MessageBox.Show("User not Found!", "Error Message")
            Else
                lblMemID.Text = read.GetString("mem_id")
                txtName.Text = read.GetString("Full_name")
                txtphone.Text = read.GetString("Phone_Number")
                cGender.Text = read.GetString("Gender")
                TxtSeat.Text = read.GetString("Seat_Number")
                dob.Text = read.GetString("Date_of_Reporting")
            End If

            If TxtSearch.Text = "" Then
                Reset()
            End If
            conn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error Message")
            conn.Close()

        End Try
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        updateMem()
        memID()
        count()

    End Sub


    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        getMember()
    End Sub


    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        addMem()
        memID()
        count()
        reset()
    End Sub

    Private Sub Picbox_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dob_ValueChanged(sender As Object, e As EventArgs) Handles dob.ValueChanged
        dob.Value = Date.Now.ToString()
    End Sub
End Class
