Imports System.Data.SqlClient

Module Module1
    Public conn As SqlConnection
    Public comm As SqlCommand
    Public ds As DataSet
    Public data As DataTable
    Public da As SqlDataAdapter

    Sub Openserver()
        Try
            conn = New SqlConnection
            conn.ConnectionString = "Data Source=JA\JAHILBERO;Initial Catalog=tuitionfee;Integrated Security=True"
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub NewDataSet(ByVal sqlStr As String)
        Try
            data = New DataTable
            da = New SqlDataAdapter(sqlStr, conn)
            da.Fill(data)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub Save(ByVal sqlStr As String)
        Try
            comm = New SqlCommand
            comm.Connection = conn
            comm.CommandText = sqlStr
            comm.ExecuteNonQuery()
            comm.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
