Public Class preg
    Dim cn As New OleDb.OleDbConnection
    Dim r As New OleDb.OleDbCommand

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\Database1.mdb")
        cn.Open()
        r.Connection = cn
        r.CommandText = "insert into plist (ID ,name ,age ,sex ,mob ,dname ,reason ,bg) values ('" & TextBox2.Text & "','" & TextBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "')"
        r.ExecuteNonQuery()
        MsgBox("New record added")
        cn.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\Database1.mdb")
        cn.Open()
        r.Connection = cn
        r.CommandText = "Update plist set name= '" & TextBox1.Text & "' where ID ='" & TextBox2.Text & "'"
        r.ExecuteNonQuery()
        MsgBox("Record Updated")
        cn.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\Database1.mdb")
        cn.Open()
        r.Connection = cn
        r.CommandText = "Delete from plist where ID='" & TextBox2.Text & "'"
        r.ExecuteNonQuery()
        MsgBox("Record deleted")
        cn.Close()

    End Sub

    Private Sub preg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class