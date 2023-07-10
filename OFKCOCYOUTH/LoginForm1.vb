Imports MySql.Data.MySqlClient
Public Class LoginForm1
    Dim conn As MySqlConnection 'for connection to the database
    Dim COMMAND As MySqlCommand ' to query the database for data

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'Declear new connection to connect to database
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost;userid=root;password=;database=youth"
        Dim READER As MySqlDataReader ' to read the information return from the database for display or any action to be taken

        'catch exceptions to handle errors
        Try
            conn.Open() 'open the connection created

            'MessageBox.Show("Connection Successful", "Connected Message") 'option, this is to check if the connection is successful

            Dim User As String = UsernameTextBox.Text
            Dim Password As String = PasswordTextBox.Text
            Dim Query As String
            Query = "select * from youth.admin where user = '" + User + "' and password = '" + Password + "' "
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader


            Dim count As Integer
            count = 0

            While READER.Read
                count = count + 1
            End While

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
                UsernameTextBox.Text = ""
                PasswordTextBox.Text = ""
            ElseIf count > 1 Then
                MessageBox.Show("Username and Password are duplicated")
            Else
                MessageBox.Show("Username or Password is not correct")
            End If


            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error Message")
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Mainform.MembershipToolStripMenuItem.Enabled = False
        Mainform.FinanceToolStripMenuItem.Enabled = False
        Mainform.MembershipToolStripMenuItem.Enabled = False
        Mainform.EventsSchdulesToolStripMenuItem.Enabled = False
        Mainform.ReportingToolStripMenuItem.Enabled = False
        Mainform.SettingToolStripMenuItem.Enabled = False
        Mainform.ReportingToolStripMenuItem.Enabled = False
        Mainform.BackupToolStripMenuItem.Enabled = False
        Mainform.MessageToolStripMenuItem.Enabled = False
        Mainform.AboutUsToolStripMenuItem.Enabled = False


    End Sub

    Private Sub lblforgot_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblforgot.LinkClicked
        My.Forms.LoginForm1.Hide()
        My.Forms.Forgot_password.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        My.Forms.Admin_Accounts.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            PasswordTextBox.UseSystemPasswordChar = True

        Else
            PasswordTextBox.UseSystemPasswordChar = False

        End If
    End Sub
End Class
