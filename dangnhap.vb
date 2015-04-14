Imports System.Data.SqlClient
Public Class frmdangnhap

    Private Sub btndangnhap_Click(sender As Object, e As EventArgs) Handles btndangnhap.Click
        Dim ketnoi As String = "workstation id=Ps02298.mssql.somee.com;packet size=4096;user id=ps02298;pwd=Hienhqps1803;data source=Ps02298.mssql.somee.com;persist security info=False;initial catalog=Ps02298"
        Dim connect As SqlConnection = New SqlConnection(ketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from nhanvien where manhanvien='" & txtuser.Text & "' and pass= '" & txtpass.Text & "' ", ketnoi)
        Dim tb As New DataTable
        Try
            connect.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Đăng Nhập Thành Công")
                frmmenu.Show()
                Me.Hide()
            Else
                MessageBox.Show("Tài Khoản Không Đúng Xin Vui Lòng Kiểm Tra Lại")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        txtuser.Clear()
        txtpass.Clear()
    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Me.Close()
    End Sub
End Class
