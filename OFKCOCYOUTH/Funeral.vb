Imports Emgu.CV.Stitching
Imports Emgu.CV.XFeatures2D
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Math.EC.Custom
Imports System.Web.UI.WebControls.WebParts
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window

Public Class Funeral
    Dim maxrow As Integer
    Dim balance As Double = 0
    Dim id As Integer = 0
    Dim conn As MySqlConnection 'for connection to the database
    Dim cmd As MySqlCommand ' to query the database for data
    Dim dtable As New DataTable
    Dim dadapter As MySqlDataAdapter
    Dim myconnection As New DTConnect
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim money As Double

        If cboType.Text = "Select" Then
            MsgBox("Pls choose the transaction type", MsgBoxStyle.Exclamation)
            Return
        End If
        If txtMoney.Text = "" Then
            MsgBox("Money cannot be null", MsgBoxStyle.Exclamation)
            Return
        End If
        If txtRemarks.Text = "" Then
            MsgBox("Remarks cannot be null", MsgBoxStyle.Exclamation)
            Return
        End If

        sql = "SELECT *  FROM youth.tblbudget 
                WHERE BugetID = " & id
        maxrow = loadSingleResult(sql)
        If maxrow > 0 Then

            If MessageBox.Show("Do you want to update this record?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then

                If cboType.Text = "Received" Then
                    money = Double.Parse(txtMoney.Text) - Double.Parse(dt.Rows(0).Item(1))
                    balance = Double.Parse(dt.Rows(0).Item(3)) + money
                Else
                    money = Double.Parse(dt.Rows(0).Item(2)) - Double.Parse(txtMoney.Text)
                    balance = Double.Parse(dt.Rows(0).Item(3)) + money
                End If
                'MsgBox(money)
                'MsgBox(balance)
                Try
                    sql = "SELECT BugetID,BudgetBalance FROM `tblbudget` 
                        WHERE BugetID > " & id & "  ORDER BY `BugetID` asc"
                    loadSingleResult(sql)
                    For Each r As DataRow In dt.Rows
                        sql = "UPDATE youth.tblbudget SET BudgetBalance = BudgetBalance + '" & money & "' WHERE BugetID = " & r.Item(0)
                        executeQuery(sql)
                    Next
                Catch ex As Exception
                End Try

                Select Case cboType.Text
                    Case "Received"
                        sql = "UPDATE youth.tblbudget SET `BudgetIn`='" & txtMoney.Text & "',`BudgetBalance`= '" & balance & "',
                                `Remarks`='" & txtRemarks.Text & "',`TrasactionDate`='" & dtpTransDate.Text & "',`Type`='" & cboType.Text & "' 
                                WHERE `BugetID`=" & id
                        executeQuery(sql)

                    Case "Withdraw"
                        sql = "UPDATE youth.tblbudget SET `BudgetOut`='" & txtMoney.Text & "',`BudgetBalance`= '" & balance & "',
                                `Remarks`='" & txtRemarks.Text & "',`TrasactionDate`='" & dtpTransDate.Text & "',`Type`='" & cboType.Text & "' 
                                WHERE `BugetID`=" & id
                        executeQuery(sql)
                End Select
            End If




        Else
            If MessageBox.Show("Do you want to Save this record?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then

                Select Case cboType.Text
                    Case "Received"

                        sql = "SELECT BudgetBalance FROM `tblbudget` ORDER BY `BugetID` DESC"
                        maxrow = loadSingleResult(sql)
                        If maxrow > 0 Then
                            balance = Double.Parse(dt.Rows(0).Item(0)) + Double.Parse(txtMoney.Text)
                        Else
                            balance = txtMoney.Text
                        End If


                        sql = "INSERT INTO youth.tblbudget(`BudgetIn`, `BudgetOut`, `BudgetBalance`, `Remarks`, `TrasactionDate`,Type) 
                        VALUES ('" & txtMoney.Text & "',0,'" & balance & "','" & txtRemarks.Text & "','" & dtpTransDate.Text & "',
                            '" & cboType.Text & "')"
                        executeQuery(sql)

                    Case "Withdraw"

                        sql = "SELECT BudgetBalance FROM youth.tblbudget ORDER BY `BugetID` DESC"
                        maxrow = loadSingleResult(sql)
                        If maxrow > 0 Then

                            balance = Double.Parse(dt.Rows(0).Item(0)) - Double.Parse(txtMoney.Text)

                        Else
                            MsgBox("transaction cannot be proccess", MsgBoxStyle.Exclamation)
                            Return
                        End If

                        sql = "INSERT INTO youth.tblbudget(`BudgetIn`, `BudgetOut`, `BudgetBalance`, `Remarks`, `TrasactionDate`,Type) 
                        VALUES (0,'" & txtMoney.Text & "','" & balance & "','" & txtRemarks.Text & "','" & dtpTransDate.Text & "',
                            '" & cboType.Text & "')"
                        executeQuery(sql)
                End Select
            End If

        End If

        clear()
    End Sub
    Private Sub clear()
        id = 0
        txtMoney.Text = 0
        txtRemarks.Clear()
        cboType.Text = "Select"
        dtpTransDate.Text = Now()

        sql = "SELECT `BugetID`,`TrasactionDate` as 'Date', `BudgetIn` as 'Recieved', `BudgetOut` as 'Withdraw', `BudgetBalance` as 'Balance', `Remarks`,  `Type` FROM youth.tblbudget ORDER BY BugetID ASC"
        loadResultList(sql, dtglist)

        Dim maxrow As Integer
        Dim recieve, withdraw, bal As Double
        maxrow = dtglist.RowCount()


        For i As Integer = 0 To maxrow - 1
            recieve += dtglist.Rows(i).Cells(2).Value
            withdraw += dtglist.Rows(i).Cells(3).Value
        Next

        bal = recieve - withdraw
        txtRecieved.Text = recieve.ToString("N2")
        txtWidthraw.Text = withdraw.ToString("N2")
        txtBalance.Text = bal.ToString("N2")


        'sql = "SELECT BudgetBalance FROM `tblbudget` ORDER BY `BugetID` DESC"
        'maxrow = loadSingleResult(sql)
        'If maxrow > 0 Then
        '    bal = Double.Parse(dt.Rows(0).Item(0)) + Double.Parse(txtMoney.Text)
        '    txtBalance.Text = bal.ToString("N2")
        'Else
        '    txtBalance.Text = 0
        'End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clear()
    End Sub

    Private Sub txtMoney_Click(sender As Object, e As EventArgs) Handles txtMoney.Click
        txtMoney.SelectAll()
    End Sub
    Private Sub txtRemarks_Click(sender As Object, e As EventArgs) Handles txtRemarks.Click
        txtRemarks.SelectAll()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        sql = "SELECT `BugetID`,`TrasactionDate` as 'Date', `BudgetIn` as 'Received', `BudgetOut` as 'Withdraw', `BudgetBalance` as 'Balance', `Remarks`,  `Type` 
                FROM youth.tblbudget WHERE DATE(TrasactionDate) BETWEEN '" & dtpfrom.Text & "' AND '" & dtpto.Text & "' ORDER BY BugetID ASC"
        loadResultList(sql, dtglist)

        Dim maxrow As Integer
        Dim recieve, withdraw, bal As Double
        maxrow = dtglist.RowCount()


        For i As Integer = 0 To maxrow - 1
            recieve += dtglist.Rows(i).Cells(2).Value
            withdraw += dtglist.Rows(i).Cells(3).Value
        Next

        bal = recieve - withdraw
        txtRecieved.Text = recieve.ToString("N2")
        txtWidthraw.Text = withdraw.ToString("N2")
        txtBalance.Text = bal.ToString("N2")




        'sql = "SELECT BudgetBalance FROM `tblbudget` ORDER BY `BugetID` DESC"
        'maxrow = loadSingleResult(sql)
        'If maxrow > 0 Then
        '    bal = Double.Parse(dt.Rows(0).Item(0))
        '    txtBalance.Text = bal.ToString("N2")
        'Else
        '    txtBalance.Text = 0
        'End If

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        clear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim money As Double

        If dtglist.CurrentRow.Cells(6).Value = "Received" Then
            money = dtglist.CurrentRow.Cells(2).Value
        Else
            money = dtglist.CurrentRow.Cells(3).Value
        End If

        If MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then



            sql = "SELECT BugetID,BudgetBalance FROM youth.tblbudget
                WHERE BugetID > " & dtglist.CurrentRow.Cells(0).Value & "  ORDER BY `BugetID` asc"
            maxrow = loadSingleResult(sql)
            If maxrow > 0 Then
                Try
                    For Each r As DataRow In dt.Rows

                        'bal = r.Item(1) - money 


                        sql = "UPDATE youth.tblbudget SET BudgetBalance = BudgetBalance + '" & money & "' WHERE BugetID = " & r.Item(0)
                        executeQuery(sql)
                    Next
                    'For i As Integer = 0 To maxrow
                    '    sql = "UPDATE tblbudget SET BudgetBalance = BudgetBalance - '" & dt.Rows(i).Item(1) & "' WHERE BugetID = " & dt.Rows(i).Item(0)
                    '    executeQuery(sql)
                    'Next

                Catch ex As Exception

                End Try

            End If

            sql = "DELETE FROM youth.tblbudget WHERE `BugetID` = " & dtglist.CurrentRow.Cells(0).Value
            executeQuery(sql)

            clear()
        End If
    End Sub

    Private Sub dtglist_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtglist.CellClick
        Try
            With dtglist.CurrentRow
                If .Cells(6).Value = "Received" Then
                    txtMoney.Text = .Cells(2).Value
                Else
                    txtMoney.Text = .Cells(3).Value
                End If
                id = .Cells(0).Value

                txtRemarks.Text = .Cells(5).Value
                cboType.Text = .Cells(6).Value
                dtpTransDate.Text = .Cells(1).Value
            End With
        Catch ex As Exception

        End Try
    End Sub
    Private Sub reset()
        txtfuname.Text = ""
        txtfuphone.Text = ""
        txtfuzone.Text = ""

    End Sub
    Sub Autocomplete()
        Dim search As String = TextBox1.Text
        cmd.Connection = myconnection.Open
        cmd.CommandText = "select * from youth.members order by Full_name asc, mem_id"
        Dim ds As New DataSet
        dadapter = New MySqlDataAdapter(cmd)
        dadapter.Fill(ds, "Full_name")
        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("Full_name").ToString & "" & ds.Tables(0).Rows(i)("mem_id").ToString)
        Next

        myconnection.Close()
        TextBox1.AutoCompleteSource = AutoCompleteSource.CustomSource
        TextBox1.AutoCompleteCustomSource = col
        TextBox1.AutoCompleteMode = AutoCompleteMode.Suggest

    End Sub
    Private Sub Btnnamesearch_Click(sender As Object, e As EventArgs) Handles Btnnamesearch.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost;userid=root;password=;database=youth"
        Dim read As MySqlDataReader

        Dim search As String = TextBox1.Text
        Dim q As String
        q = "select * from youth.members where Full_name like '%" + search + "%' or mem_id like '%" + search + "%' "

        Try
            conn.Open()

            cmd = New MySqlCommand(q, conn)

            read = cmd.ExecuteReader
            If read.Read = False Then
                Reset()
                MessageBox.Show("User not Found!", "Error Message")

            Else
                txtfuname.Text = read.GetString("Full_name")
                txtfuphone.Text = read.GetString("Phone_Number")
                txtfuzone.Text = read.GetString("Zone")
            End If

            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error Message")
            conn.Close()
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            'Autocomplete()

            reset()
        End If
    End Sub

    Private Sub TextBox1_MouseEnter(sender As Object, e As EventArgs) Handles TextBox1.MouseEnter

    End Sub
End Class
