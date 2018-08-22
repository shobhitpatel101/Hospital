Public Class pdet
    Dim cn As New OleDb.OleDbConnection
    Dim r As New OleDb.OleDbCommand
    Dim d As OleDb.OleDbDataReader
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\Database1.mdb")
        cn.Open()
        r.Connection = cn
        r.CommandText = "select * from plist where ID='" & TextBox2.Text & "'"
        r.ExecuteNonQuery()
        d = r.ExecuteReader
        If Not d.Read Then
            MsgBox("No record found")

        Else
            TextBox1.Text = d.Item(1)
            TextBox3.Text = d.Item(2)
            TextBox4.Text = d.Item(3)
            TextBox5.Text = d.Item(4)
            TextBox6.Text = d.Item(5)
            TextBox7.Text = d.Item(6)
            TextBox8.Text = d.Item(7)

        End If
        cn.Close()

    End Sub
    
    Private Sub pdet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class