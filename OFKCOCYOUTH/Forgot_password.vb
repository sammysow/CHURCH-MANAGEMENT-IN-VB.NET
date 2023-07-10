Imports System.Net
Imports System.Net.Mail
Public Class Forgot_password
    Dim randomCode As String
    Public Shared touser As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSend.Click
        Dim from, pass, messagebody As String
        Dim rand As Random = New Random
        randomCode = (rand.Next(999999)).ToString
        Dim message As MailMessage = New MailMessage
        touser = TxtEmail.Text
        from = "ofkcoc1@gmail.com"
        pass = "*ChurchOfChrist#"
        messagebody = "Your reset code is " + randomCode
        message.To.Add(touser)
        message.From = New MailAddress(from)
        message.Body = messagebody
        message.Subject = "Password resetting Code"
        Dim smtp As SmtpClient = New SmtpClient("smtp.gmail.com")
        smtp.EnableSsl = True
        smtp.Port = 587
        smtp.DeliveryMethod = smtp.DeliveryMethod.Network
        smtp.Credentials = New NetworkCredential(from, pass)
        Try
            smtp.Send(message)
            MessageBox.Show("Message sent Successfuly", "Please Check your email and enter the code in the Enter Code Box")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub BtnVerify_Click(sender As Object, e As EventArgs) Handles BtnVerify.Click
        If (Txtcode.Text.Equals(randomCode)) Then
            touser = TxtEmail.Text
            My.Forms.Forgot_password.Hide()
            My.Forms.Reset.Show()
        Else
            MessageBox.Show("Wrong Code")
        End If
    End Sub

    Private Sub Forgot_password_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class