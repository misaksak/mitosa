Public Class FormPemesanan

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles lblpesan.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnpesan.Click
        If (txtnama.TextLength <= 0) Then
            Text = "Nama Pemesan Belum Diisi"
        End If
        If (cbKartu.Text.Length <= 0) Then
            Text = "No Kartu Belum Diisi"
        End If
        If (txtNoidentitas.TextLength <= 0) Then
            Text = "No Identitas Belum Diisi"
        End If
        If (txtnotelpon.TextLength <= 0) Then
            Text = "No Telepon Belum Diisi"
        End If

        Form5.Show()

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub lnkkembali_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkkembali.LinkClicked
        FormNoKamar.Show()
    End Sub

    Private Sub txtnama_TextChanged(sender As Object, e As EventArgs) Handles txtnama.TextChanged
       

    End Sub
End Class