Imports System.Collections.Specialized
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json.Linq
Imports MySql.Data.MySqlClient

Public Class frmSms
    Dim conn As MySqlConnection 'for connection to the database
    Dim cmd As MySqlCommand ' to query the database for data
    Dim read As MySqlDataReader
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dispose()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost;userid=root;password=;database=youth"
        Dim query As String = "select Full_name,Phone_Number from youth.members"
        Try
            conn.Open()

            If radioIndividual.Checked Then
                If txtContact.Text.Equals(String.Empty) Then
                    MsgBox("Please provide contact Number")
                    Return

                Else
                End If
                smsgridview.Rows.Add("N/A", txtContact.Text)
                    txtContact.Text = String.Empty
                    ElseIf radioAll.Checked Then
                query = "select Full_name,Phone_Number from youth.members"

            ElseIf radioMen.Checked Then
                query = "select Full_name,Phone_Number from youth.members where Gender ='MALE'"

            ElseIf radioWomen.Checked Then
                query = "select Full_name,Phone_Number from youth.members where Gender ='FEMALE'"

            End If
            cmd = New MySqlCommand(query, conn)
            read = cmd.ExecuteReader()

            If read.HasRows Then
                smsgridview.Rows.Clear()

                While read.Read
                    smsgridview.Rows.Add(read("Full_name"), read("Phone_Number"))
                End While
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error>> " + ex.Message)
            conn.Close()
        End Try

    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If smsgridview.Rows.Count <= 0 Then
            Return
        End If
        If txtMsg.Text.Equals(String.Empty) Then
            Return
        End If
        btnSend.Enabled = False
        btnSend.Text = "Sending SMS..."

        For i As Integer = 0 To smsgridview.Rows.Count - 1
            Dim status = SendSms(smsgridview.Rows(i).Cells(1).Value, txtMsg.Text)

            smsgridview.Rows(i).Cells(2).Value = status
            'MsgBox(smsgridview.Rows(i).Cells(1).Value)
        Next

        btnSend.Text = "Send SMS"
        btnSend.Enabled = True
    End Sub

    Public Function SendSms(contact As String, msg As String) As String
        Using client = New WebClient()
            Dim data As New NameValueCollection()
            data("recipient[]") = contact
            data("sender") = "OFKCOC"
            data("message") = msg
            data("is_schedule") = "False"
            data("schedule_date") = ""

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

            Dim response = client.UploadValues("https://api.mnotify.com/api/sms/quick?key=4guX64hIgvfX3JPQEKDE3d9EpeI0zUsDaXBg1TZioefsX", "POST", data)
            Dim resString = Encoding.Default.GetString(response)

            Dim jsonRes = JObject.Parse(resString)

            Return jsonRes("status").ToObject(Of String)
        End Using
    End Function

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim selectedRows = smsgridview.Rows.GetRowCount(DataGridViewElementStates.Selected)

        If selectedRows <= 0 Then
            Return
        Else
            If (MessageBox.Show("Are you sure you want to remove these items?",
                               Application.ProductName, MessageBoxButtons.YesNo).Equals(DialogResult.Yes)) Then

                btnRemove.Enabled = False
                btnRemove.Text = "Removing Selections..."

                For i As Integer = 0 To selectedRows - 1
                    smsgridview.Rows.RemoveAt(smsgridview.SelectedRows(0).Index)
                Next

                btnRemove.Text = "Remove"
                btnRemove.Enabled = True
            End If
        End If
    End Sub

    Private Sub frmSms_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

End Class