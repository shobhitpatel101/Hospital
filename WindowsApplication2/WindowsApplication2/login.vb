Public Class login
    Dim cn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand


    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        cn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\Database1.mdb")
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "Select * from login where user = '" & textBox1.Text & "'"
        Dim r As OleDb.OleDbDataReader = cmd.ExecuteReader

        If Not r.Read Then
            MsgBox("Error in LOGIN !!")

        ElseIf textBox2.Text = r.Item(1) Then
            Me.Hide()
            loading.Show()
        Else
            MsgBox("Error in LOGIN !!")
        End If


        cn.Close()

    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        Me.Close()

    End Sub

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
