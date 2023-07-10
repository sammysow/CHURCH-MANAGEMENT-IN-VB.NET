Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Backup_Restore
    Dim path As String
    Dim Backupath As String
    Dim DatabaseName As String = "Backup" + Date.Now.ToString("dd-MM-yyyy-HH:mm:ss")
    Sub backup()
        Try
            If Not Directory.Exists(Backupath) Then
                Directory.CreateDirectory(Backupath)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Process.Start("C:\xampp\mysql\bin\mysqldump.exe", "-u root  mydatabase  -r""" & Backupath & "" & DatabaseName & ".sql""")
        MsgBox("Backup Successful")
    End Sub

    Private Sub CMBserver_SelectedIndexChanged(sender As Object, e As EventArgs)
        'connection()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            ProgressBar1.Visible = False
            MsgBox("Successfully Done")
        Else
            ProgressBar1.Value = ProgressBar1.Value + 5
        End If
    End Sub


    Private Sub BtnBackup_Click(sender As Object, ByVal e As EventArgs) Handles BtnBackup.Click
        'Backup the database and save it into our local server
        FolderBrowserDialog1.ShowDialog()
        Backupath = FolderBrowserDialog1.SelectedPath.ToString() + "\"
        backup()

    End Sub

    Private Sub BtnRestore_Click(sender As Object, e As EventArgs) Handles BtnRestore.Click


    End Sub

    Private Sub Backup_Restore_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class