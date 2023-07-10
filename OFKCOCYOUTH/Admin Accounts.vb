Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class Admin_Accounts
    Dim conn As MySqlConnection 'for connection to the database
    Dim cmd As MySqlCommand ' to query the database for data
    Dim read As MySqlDataReader ' to read the information return from the database for display or any action to be taken
    Private Sub reset()
        TxtAfn.Text = ""
        Txtaemail.Text = ""
        Txtapass.Text = ""
        Txtapho.Text = ""
        Txtaverpass.Text = ""
    End Sub
    Private Sub AddMem()
        'Dim READER As MySqlDataReader
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost;userid=root;password=;database=youth"
        Dim user As String = TxtAfn.Text.ToUpper
        Dim Phone As String = Txtapho.Text.ToUpper
        Dim Email As String = Txtaemail.Text.ToUpper
        Dim Password As String = Txtapass.Text.ToUpper

        Dim q As String
        q = "insert into youth.admin(user,Phone,Email,password)values
        ('" + user + "','" + Phone + "','" + Email + "',
        '" + Password + "')"

        If user = "" Or Email = "" Or Password = "" Then
            MessageBox.Show("Fill in all Fields")
            Return
        Else
            Try
                conn.Open()
                cmd = New MySqlCommand(q, conn)
                'cmd.Parameters.Add(New MySqlParameter("@img", arrImage))
                read = cmd.ExecuteReader()
                Dim count As Integer
                count = 0

                'While READER.Read
                '    count = count + 1
                'End While

                If count = 1 Then
                    'MessageBox.Show("Username and Password are correct")
                    My.Forms.Mainform.Show()
                    Mainform.MembershipToolStripMenuItem.Enabled = True
                    Mainform.FinanceToolStripMenuItem.Enabled = True
                    Mainform.MembershipToolStripMenuItem.Enabled = True
                    Mainform.EventsSchdulesToolStripMenuItem.Enabled = True
                    Mainform.ReportingToolStripMenuItem.Enabled = True
                    Mainform.SettingToolStripMenuItem.Enabled = True
                    Mainform.ReportingToolStripMenuItem.Enabled = True
                    Mainform.BackupToolStripMenuItem.Enabled = True
                    Mainform.MessageToolStripMenuItem.Enabled = True
                    Mainform.AboutUsToolStripMenuItem.Enabled = True
                    Me.Hide()

                ElseIf count > 1 Then
                    MessageBox.Show("Username and Password are duplicated")
                End If
                'Return
                MessageBox.Show("Member " + user + " Added Successfully")
            Catch ex As MySqlException
                MessageBox.Show("Error>> " + ex.Message)
                conn.Close()
            End Try
        End If
        conn.Close()

    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        If (Txtapass.Text.Equals(Txtaverpass.Text)) Then
            AddMem()
            reset()
        Else
            MessageBox.Show("Password Mismatched check and enter Again")
        End If

    End Sub

    Private Sub Btnacancel_Click(sender As Object, e As EventArgs) Handles Btnacancel.Click
        Me.Hide()
        My.Forms.LoginForm1.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Txtapass.UseSystemPasswordChar = True
            Txtaverpass.UseSystemPasswordChar = True
        Else
            Txtapass.UseSystemPasswordChar = False
            Txtaverpass.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub Txtaemail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtaemail.KeyPress
        Dim email, a As String
        Dim count As Integer
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            If Txtaemail.Text = "" Then
                MsgBox("Email address is not entered", MsgBoxStyle.Information, "Error")
            Else
                email = Txtaemail.Text
                If (email.Contains("@") = False Or email.Contains(".") = False Or email.Contains("com") = False Or email.Contains("co.uk") = False) Then
                    MsgBox("@ or .Missing", MsgBoxStyle.Information, "Error")
                    Return
                Else
                    For y = 0 To email.Length - 1
                        a = email.Substring(y, 1)
                        If a.Equals("@") Then
                            count = count + 1
                        End If
                    Next
                    If (count > 1) Then
                        MsgBox("Email Address don't have @ symbol more than once", MsgBoxStyle.Information, "Error")
                        Return
                    Else
                        MsgBox("Success", MsgBoxStyle.Information, "Information")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Txtapho_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtapho.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            If (Txtapho.Text = "") Then
                MsgBox("Telephone number is not entered", MsgBoxStyle.Information, "Error")
            ElseIf IsNumeric(Txtapho.Text) = False Then
                MsgBox("Only numbers is Accepted", MsgBoxStyle.Information, "Error")
                Return
            ElseIf Len(Trim(Txtapho.Text)) <> 10 Then
                MsgBox("Only 10 digits is allowed", MsgBoxStyle.Information, "Error")
                Return
            ElseIf Not Txtapho.Text.StartsWith(0) Then
                MsgBox("Telephone number Should start with 0 digit", MsgBoxStyle.Information, "Error")
                Return

            End If
        End If
    End Sub
End Class