Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmnhanvien
    Dim tb As New DataTable
    Dim connectstr As String = "workstation id=Ps02298.mssql.somee.com;packet size=4096;user id=ps02298;pwd=Hienhqps1803;data source=Ps02298.mssql.somee.com;persist security info=False;initial catalog=Ps02298"
    Private Sub loaddata()
        Dim connect As New SqlConnection(connectstr)
        Dim sqladapter As New SqlDataAdapter("select * from nhanvien", connect)
        Try
            sqladapter.Fill(tb)
        Catch ex As Exception
        End Try
        DataGridView.DataSource = tb
        connect.Close()

    End Sub
    Private Sub btnthem_cellClick(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim index As Integer = btnthem.curentcell.rowindex
        txtdc.Text =
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim connect As New SqlConnection(connectstr)
        connect.Open()
        Dim stradd As String = "delete from nhanvien where manhanvien = @manhanvien"
        Dim con As New SqlCommand(stradd, connect)
        Try
            con.Parameters.AddWithValue("@manhanvien", txtmanv.Text)
            con.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception
            MessageBox.Show(" xoa thanh cong ")
        End Try
        tb.Clear()
        DataGridView.DataSource = tb
        DataGridView.DataSource = Nothing
        loaddata()
    End Sub
End Class