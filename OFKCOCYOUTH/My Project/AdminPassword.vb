Imports MySql.Data.MySqlClient
Imports System.IO
Public Class AdminPassword
    Dim conn As MySqlConnection 'for connection to the database
    Dim cmd As MySqlCommand ' to query the database for data
    Dim read As MySqlDataReader ' to read the information return from the database for display or any action to be taken
    Private Sub addMem()
        conn = New MySqlConnection
        conn.ConnectionString = "server = 192.168.8.122;userid=sowah;password='';database=youth"
        Dim User As String = UsernameTextBox.Text
        Dim Password As String = PasswordTextBox.Text
        Dim q As String
        q = "insert into youth.admin(User,Password)values
        ('" + User + "','" + Password + "')"

        If User = "" Or Password = "" Then
            MessageBox.Show("Fill in all Fields")
        Else
            Try
                conn.Open()
                cmd = New MySqlCommand(q, conn)
                read = cmd.ExecuteReader()
                MessageBox.Show("Member " + User + " Added Successfully")
            Catch ex As MySqlException
                MessageBox.Show("Error>> " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub Btnregister_Click(sender As Object, e As EventArgs) Handles Btnregister.Click
        addMem()
    End Sub
End Class