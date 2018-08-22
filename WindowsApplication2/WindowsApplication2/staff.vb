Imports System.Web
Public Class staff
    Dim cn As New OleDb.OleDbConnection
    Dim r As New OleDb.OleDbCommand
    Dim rdd As OleDb.OleDbDataReader

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\Database1.mdb")
        cn.Open()
        r.Connection = cn
        r.CommandText = "select * from lstaff where sid ='" & TextBox9.Text & "'"
        r.ExecuteNonQuery()


        rdd = r.ExecuteReader

        If Not rdd.Read Then
            MsgBox("Not Found !!")
        Else
            TextBox1.Text = rdd.Item(0)

            TextBox3.Text = rdd.Item(2)
            TextBox4.Text = rdd.Item(3)
            TextBox5.Text = rdd.Item(4)
            TextBox6.Text = rdd.Item(5)
            TextBox7.Text = rdd.Item(6)
            TextBox8.Text = rdd.Item(7)

        End If



        cn.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\Database1.mdb")
        cn.Open()
        r.Connection = cn
        r.CommandText = "delete from lstaff where sid='" & TextBox9.Text & "'"
        r.ExecuteNonQuery()
        MsgBox("Record deleted")
        cn.Close()

    End Sub

    Private Sub staff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\Database1.mdb")
        cn.Open()
        r.Connection = cn
        r.CommandText = "insert into lstaff values ('" & TextBox2.Text & "','" & TextBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "')"
        r.ExecuteNonQuery()
        MsgBox("New record added")
        cn.Close()
    End Sub

    
End Class