Imports System.Configuration
Imports System.Net.Mail
Imports MySql.Data.MySqlClient
Public Class autobirthday
    Private Sub Autobirthday_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt As New DataTable()
        Dim query As String = "SELECT Name, Email FROM youth.members WHERE DATEPART(DAY, BirthDate) = @Day AND DATEPART(MONTH, BirthDate) = @Month"
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using conn As New MySqlConnection(constr)
            Using cmd As New MySqlCommand(query)
                cmd.Connection = conn
                cmd.Parameters.AddWithValue("@Day", DateTime.Today.Day)
                cmd.Parameters.AddWithValue("@Month", DateTime.Today.Month)
                Using sda As New MySqlDataAdapter(cmd)
                    sda.Fill(dt)
                End Using
            End Using
        End Using
        For Each row As DataRow In dt.Rows
            Dim name As String = row("Name").ToString()
            Dim email As String = row("Email").ToString()
            WriteToFile("Trying to send email to: " & name & " " & email)

            Using mm As New MailMessage("sender@gmail.com", email)
                mm.Subject = "Birthday Greetings"
                mm.Body = String.Format("<b>Happy Birthday </b>{0}<br /><br />Many happy returns of the day.", name)

                mm.IsBodyHtml = True
                Dim smtp As New SmtpClient()
                smtp.Host = "smtp.gmail.com"
                smtp.EnableSsl = True
                Dim credentials As New System.Net.NetworkCredential()
                credentials.UserName = "sender@gmail.com"
                credentials.Password = "<Password>"
                smtp.UseDefaultCredentials = True
                smtp.Credentials = credentials
                smtp.Port = 587
                smtp.Send(mm)
                WriteToFile("Email sent successfully to: " & name & " " & email)
            End Using
        Next
        Me.ScheduleService()

        'WriteToFile("Simple Service Error on: {0} " + ex.Message + ex.StackTrace)

        'Stop the Windows Service.
        Using serviceController As New System.ServiceProcess.ServiceController("SimpleService")
            serviceController.[Stop]()
        End Using

    End Sub

    Private Sub ScheduleService()
        Throw New NotImplementedException()
    End Sub

    Private Sub WriteToFile(v As String)
        Throw New NotImplementedException()
    End Sub
End Class