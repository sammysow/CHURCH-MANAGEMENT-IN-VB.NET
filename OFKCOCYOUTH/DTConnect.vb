Imports MySql.Data.MySqlClient
Public Class DTConnect
    Dim connect As New MySqlConnection("server='localhost';user='root';password='';database='youth'")
    Public Function Open() As MySqlConnection
        Try
            connect.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return connect
    End Function
    Public Function Close() As MySqlConnection
        Try
            connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return connect
    End Function
End Class

