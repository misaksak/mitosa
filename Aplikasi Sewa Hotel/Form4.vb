Public Class FormPemesanan

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles lblpesan.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnpesan.Click
        If (txtnama.Text = "") Then
            MsgBox("Nama Pemesanan Masih Kosong", vbCritical, "Salah")
            txtnama.Focus()
        ElseIf (cbKartu.Text = "") Then
            MsgBox("Kartu Identitas Masih Kosong", vbCritical, "Salah")
            cbKartu.Focus()
        ElseIf (txtNoidentitas.Text = "") Then
            MsgBox("No Identitas Masih Kosong", vbCritical, "Salah")
            txtNoidentitas.Focus()
        ElseIf (txtnotelpon.Text = "") Then
            MsgBox("Tahun Motor Masih Kosong", vbCritical, "Salah")
            txtnotelpon.Focus()
        End If
        Text = "Berhasil Memesan Kamar"
        FormPembayaran.Show()

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles lblHotel.Click

    End Sub

    Private Sub lnkkembali_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkkembali.LinkClicked
        FormNoKamar.Show()
    End Sub

    Private Sub txtnama_TextChanged(sender As Object, e As EventArgs) Handles txtnama.TextChanged
        Text = "Isi Nama Pemesanan "

    End Sub

    Private Sub cbKartu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbKartu.SelectedIndexChanged
        Text = "Isi Kartu Identitas"
    End Sub

    Private Sub txtNoidentitas_TextChanged(sender As Object, e As EventArgs) Handles txtNoidentitas.TextChanged
        Text = "Isi No Identitas"
    End Sub

    Private Sub rblaki_CheckedChanged(sender As Object, e As EventArgs) Handles rblaki.CheckedChanged
        Text = "Laki - laki"
    End Sub

    Private Sub rbperempuan_CheckedChanged(sender As Object, e As EventArgs) Handles rbperempuan.CheckedChanged
        Text = "Perempuan"
    End Sub

    Private Sub txtnotelpon_TextChanged(sender As Object, e As EventArgs) Handles txtnotelpon.TextChanged
        Text = "Isi No Telepon"
    End Sub

    Private Sub cbjumlahkamar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbjumlahkamar.SelectedIndexChanged
        Text = "Jenis Kamar"
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Text = "9"
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        Text = "10"
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Text = "11"
    End Sub

    Private Sub cbtipekamar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbtipekamar.SelectedIndexChanged
        Text = "Pilih Tipe Kamar"
    End Sub

    Private Sub cbtanggal_ValueChanged(sender As Object, e As EventArgs) Handles cbtanggal.ValueChanged
        Text = "Tanggal Cek In"
    End Sub

    Private Sub cbbulan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbulan.SelectedIndexChanged
        Text = "Bulan Cek In"
    End Sub

    Private Sub cbtahun_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbtahun.SelectedIndexChanged
        Text = "Tahun Cek In"
    End Sub

    Private Sub numtanggal_ValueChanged(sender As Object, e As EventArgs) Handles numtanggal.ValueChanged
        Text = "Tanggal Cek Out"
    End Sub

    Private Sub cbbln_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbln.SelectedIndexChanged
        Text = "Bulan Cek Out"
    End Sub

    Private Sub cbthn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbthn.SelectedIndexChanged
        Text = "Tahun Cek Out"
    End Sub

    Private Sub rbtunai_CheckedChanged(sender As Object, e As EventArgs) Handles rbtunai.CheckedChanged
        Text = "Tunai"
    End Sub

    Private Sub rbkeredit_CheckedChanged(sender As Object, e As EventArgs) Handles rbkeredit.CheckedChanged
        Text = "Kredit"
    End Sub
End Class