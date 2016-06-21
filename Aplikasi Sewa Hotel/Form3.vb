Public Class FormNoKamar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1201.Click, btn1301.Click, btn1501.Click, btn1601.Click, btn1801.Click, btn2001.Click, btn2401.Click,
        btn2501.Click, btn2601.Click
        Text = "Kamar No 2601"
        MessageBox.Show("Maaf,kamar sudah terisi/pesan!", "Hotel Elang", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn1401.Click, btn1701.Click, btn1901.Click, btn2701.Click,
         Bbtn2301.Click, btn2201.Click, btn2101.Click
        Text = "Kamar No 1401"
        FormPemesanan.Show()
        Me.Close()
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles btn3102.Click, btn3302.Click, btn3402.Click, btn3702.Click, btn3802.Click, btn3902.Click, btn4102.Click
        Text = "Kamar No 4102"
        MessageBox.Show("Maaf,kamar  sudah terisi/pesan!", "Hotel Elang", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles btn3202.Click, btn3502.Click, btn3602.Click, btn4002.Click, btn4202.Click, btn4302.Click,
        btn4602.Click, btn4402.Click
        Text = "Kamar No 4402"
        FormPemesanan.Show()
        Me.Close()
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles btn5503.Click
        Text = "Kamar No 5503"
        FormPemesanan.Show()
        Me.Close()
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles btn6203.Click
        Text = "Kamar No 6203"
        FormPemesanan.Show()
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles gbkamarekonomi.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles gbkamarpremium.Enter

    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles btn5103.Click
        Text = "Kamar No 5103"
        MessageBox.Show("Maaf,kamar  sudah terisi/pesan!", "Hotel Elang", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub btn5203_Click(sender As Object, e As EventArgs) Handles btn5203.Click
        Text = "Kamar No 5203"
        FormPemesanan.Show()
        Me.Close()
    End Sub

    Private Sub btn5303_Click(sender As Object, e As EventArgs) Handles btn5303.Click
        Text = "Kamar No 5303"
        FormPemesanan.Show()
        Me.Close()
    End Sub

    Private Sub btn5603_Click(sender As Object, e As EventArgs) Handles btn5603.Click
        Text = "Kamar No 5603"
        FormPemesanan.Show()
        Me.Close()

    End Sub

    Private Sub btn5703_Click(sender As Object, e As EventArgs) Handles btn5703.Click
        Text = "Kamar No 5703"
        FormPemesanan.Show()
        Me.Close()

    End Sub

    Private Sub btn5903_Click(sender As Object, e As EventArgs) Handles btn5903.Click
        Text = "Kamar No 5903"
        FormPemesanan.Show()
        Me.Close()

    End Sub

    Private Sub btn6103_Click(sender As Object, e As EventArgs) Handles btn6103.Click
        Text = "Kamar No 6103"
        FormPemesanan.Show()
        Me.Close()

    End Sub

    Private Sub btn6303_Click(sender As Object, e As EventArgs) Handles btn6303.Click
        MessageBox.Show("Maaf,kamar  sudah terisi/pesan!", "Hotel Elang", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Text = "Kamar No 6303"
    End Sub

    Private Sub btn6403_Click(sender As Object, e As EventArgs) Handles btn6403.Click
        Text = "Kamar No 6403"
        FormPemesanan.Show()
        Me.Close()

    End Sub

    Private Sub btn6503_Click(sender As Object, e As EventArgs) Handles btn6503.Click
        Text = "Kamar No 6503"
        FormPemesanan.Show()
        Me.Close()

    End Sub

    Private Sub btn6603_Click(sender As Object, e As EventArgs) Handles btn6603.Click
        Text = "Kamar No 6603"
        MessageBox.Show("Maaf,kamar  sudah terisi/pesan!", "Hotel Elang", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub btn5803_Click(sender As Object, e As EventArgs) Handles btn5803.Click
        Text = "Kamar No 5803"
        MessageBox.Show("Maaf,kamar  sudah terisi/pesan!", "Hotel Elang", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btn5403_Click(sender As Object, e As EventArgs) Handles btn5403.Click
        Text = "Kamar No 5403"
        MessageBox.Show("Maaf,kamar  sudah terisi/pesan!", "Hotel Elang", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub linkkembali_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkkembali.LinkClicked
        Text = "Kembali Ke Form Sebelumnya"
        FormJenisKamar.Show()
        Me.Close()

    End Sub

    Private Sub btn6003_Click(sender As Object, e As EventArgs) Handles btn6003.Click
        Text = "Kamar No 6003"
        MessageBox.Show("Maaf,kamar  sudah terisi/pesan!", "Hotel Elang", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class