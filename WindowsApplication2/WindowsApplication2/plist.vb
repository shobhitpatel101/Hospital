Public Class plist

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Dim cn As New OleDb.OleDbConnection
    Dim r As New OleDb.OleDbCommand
    Dim d As OleDb.OleDbDataReader
    Private Sub plist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.plist' table. You can move, or remove it, as needed.
        Me.PlistTableAdapter.Fill(Me.Database1DataSet.plist)

       
         
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class