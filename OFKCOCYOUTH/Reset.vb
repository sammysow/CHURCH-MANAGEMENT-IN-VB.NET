Imports System.Data
Imports MySql.Data.MySqlClient
Public Class Reset
    Dim conn As MySqlConnection 'for connection to the database
    Dim cmd As MySqlCommand
    Dim username As String = Forgot_password.touser
    Dim read As MySqlDataReader
    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        If (TxtNewPass.Text.Equals(TxtVerpass.Text)) Then
            conn = New MySqlConnection
            conn.ConnectionString = "server = localhost;userid=root;password=;database=youth"

            Dim upd As String = "update youth.admin set 
                                User='" + username + "',password='" + TxtNewPass.Text + "' where user='" + username + "'"
            conn.Open()
            cmd = New MySqlCommand(upd, conn)
            read = cmd.ExecuteReader()

            MessageBox.Show("Password Resetted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            My.Forms.LoginForm1.Show()
            conn.Close()
        Else
            MessageBox.Show("Password Mismatched check and enter Again")
        End If

    End Sub

    Private Sub Reset_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class