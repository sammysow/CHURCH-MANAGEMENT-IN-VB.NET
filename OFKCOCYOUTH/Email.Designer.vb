Imports System.Net.Mail
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Email
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Email))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txtemailmess = New System.Windows.Forms.TextBox()
        Me.BtnSendm = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtfrom = New System.Windows.Forms.TextBox()
        Me.txtsub = New System.Windows.Forms.TextBox()
        Me.Txtto = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(166, 14)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(410, 33)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "E-MAIL MESSAGE SENDER"
        '
        'Txtemailmess
        '
        Me.Txtemailmess.Location = New System.Drawing.Point(22, 311)
        Me.Txtemailmess.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txtemailmess.Multiline = True
        Me.Txtemailmess.Name = "Txtemailmess"
        Me.Txtemailmess.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txtemailmess.Size = New System.Drawing.Size(666, 204)
        Me.Txtemailmess.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.Txtemailmess, "Type your Email message here")
        '
        'BtnSendm
        '
        Me.BtnSendm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSendm.Location = New System.Drawing.Point(24, 557)
        Me.BtnSendm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnSendm.Name = "BtnSendm"
        Me.BtnSendm.Size = New System.Drawing.Size(160, 40)
        Me.BtnSendm.TabIndex = 6
        Me.BtnSendm.Text = "Send Mail"
        Me.BtnSendm.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Image = Global.OFKCOCYOUTH.My.Resources.Resources.Edit_Property_25px
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(18, 266)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(256, 31)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "       Type Message Here"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Image = Global.OFKCOCYOUTH.My.Resources.Resources.Subtitles_25px
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(18, 198)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 43)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "        Subject"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Image = Global.OFKCOCYOUTH.My.Resources.Resources.Read_Message_25px
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(18, 148)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(252, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "       Recipient Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Image = Global.OFKCOCYOUTH.My.Resources.Resources.Message_25px
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(18, 94)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "       Sender's Email"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Txtfrom
        '
        Me.Txtfrom.Location = New System.Drawing.Point(279, 89)
        Me.Txtfrom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txtfrom.Name = "Txtfrom"
        Me.Txtfrom.Size = New System.Drawing.Size(409, 26)
        Me.Txtfrom.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.Txtfrom, "The Person sending the Email Address")
        '
        'txtsub
        '
        Me.txtsub.Location = New System.Drawing.Point(279, 211)
        Me.txtsub.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtsub.Name = "txtsub"
        Me.txtsub.Size = New System.Drawing.Size(409, 26)
        Me.txtsub.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.txtsub, "The heading for the Message you are sending")
        '
        'Txtto
        '
        Me.Txtto.Location = New System.Drawing.Point(279, 148)
        Me.Txtto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txtto.Name = "Txtto"
        Me.Txtto.Size = New System.Drawing.Size(409, 26)
        Me.Txtto.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.Txtto, "The person receiving the Email Address")
        '
        'Email
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 631)
        Me.Controls.Add(Me.Txtto)
        Me.Controls.Add(Me.txtsub)
        Me.Controls.Add(Me.Txtfrom)
        Me.Controls.Add(Me.BtnSendm)
        Me.Controls.Add(Me.Txtemailmess)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "Email"
        Me.Text = "Email"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Txtemailmess As TextBox
    Friend WithEvents BtnSendm As Button
    Friend WithEvents Txtfrom As TextBox
    Friend WithEvents txtsub As TextBox
    Friend WithEvents Txtto As TextBox
    Friend WithEvents ToolTip1 As ToolTip

    Private Sub BtnSendm_Click(sender As Object, e As EventArgs) Handles BtnSendm.Click
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("rebeccaoffei1992@gmail.com", "0546490340")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"
            e_mail = New MailMessage
            e_mail.From = New MailAddress(Txtfrom.Text)
            e_mail.To.Add(Txtto.Text)
            e_mail.Subject = txtsub.Text
            e_mail.IsBodyHtml=False
            e_mail.Body = Txtemailmess.Text
            Smtp_Server.Send(e_mail)
            MsgBox("Mail Send Successfully, Thank you :)")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
