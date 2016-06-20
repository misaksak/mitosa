Public Class FormUtama

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnPemesanan.Click
        FormJenisKamar.Show()

    End Sub


    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Text = "Keluar Dari Form"
        Me.Close()
    End Sub
End Class
