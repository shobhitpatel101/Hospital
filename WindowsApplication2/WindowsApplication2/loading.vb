Public Class loading

    Private Sub progressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles progressBar1.Click

    End Sub

    Private Sub timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer1.Tick
        If progressBar1.Value = 100 Then
            timer1.Enabled = False

            Me.Hide()
            hospital.Show()
        Else
            progressBar1.Value = progressBar1.Value + 10
        End If
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        progressBar1.Value = 0
    End Sub
End Class