Public Class Mainform
    Private Sub AddNewMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewMemberToolStripMenuItem.Click
        My.Forms.Add_Member.Show()
    End Sub

    Private Sub UpdateMembershipDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateMembershipDetailsToolStripMenuItem.Click
        My.Forms.updateform.Show()
    End Sub

    Private Sub Mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Show()
        LoginForm1.ShowDialog()
        'MembershipToolStripMenuItem.Enabled = True
        'FinanceToolStripMenuItem.Enabled = False
        'MembershipToolStripMenuItem.Enabled = False
        'EventsSchdulesToolStripMenuItem.Enabled = False
        'ReportingToolStripMenuItem.Enabled = False
        'SettingToolStripMenuItem.Enabled = False
        'ReportingToolStripMenuItem.Enabled = False
        'BackupToolStripMenuItem.Enabled = False
        'MessageToolStripMenuItem.Enabled = False
        'AboutUsToolStripMenuItem.Enabled = False

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        LoginForm1.Show()
        MembershipToolStripMenuItem.Enabled = True
        FinanceToolStripMenuItem.Enabled = False
        MembershipToolStripMenuItem.Enabled = False
        EventsSchdulesToolStripMenuItem.Enabled = False
        ReportingToolStripMenuItem.Enabled = False
        SettingToolStripMenuItem.Enabled = False
        ReportingToolStripMenuItem.Enabled = False
        BackupToolStripMenuItem.Enabled = False
        MessageToolStripMenuItem.Enabled = False
        AboutUsToolStripMenuItem.Enabled = False

        'Me.Hide()
    End Sub

    Private Sub AddUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUserToolStripMenuItem.Click
        My.Forms.Admin_Accounts.Show()
    End Sub

    Private Sub AttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttendanceToolStripMenuItem.Click
        My.Forms.Attendance.Show()
    End Sub

    Private Sub SMSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SMSToolStripMenuItem.Click
        frmSms.ShowDialog()
    End Sub

    Private Sub EmailToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmailToolStripMenuItem1.Click
        My.Forms.Email.Show()

    End Sub

    Private Sub BackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupToolStripMenuItem.Click
        My.Forms.Backup_Restore.Show()
    End Sub

    Private Sub LogInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogInToolStripMenuItem.Click
        My.Forms.LoginForm1.Show()
    End Sub

    Private Sub AddMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddMemberToolStripMenuItem.Click
        My.Forms.Add_Member.Show()

    End Sub

    Private Sub UpdateMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateMemberToolStripMenuItem.Click
        My.Forms.updateform.Show()
    End Sub

    Private Sub PayDuesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PayDuesToolStripMenuItem1.Click
        My.Forms.Funeral.Show()
    End Sub

    Private Sub TestReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestReportToolStripMenuItem.Click
        My.Forms.report.Show()
    End Sub
End Class
