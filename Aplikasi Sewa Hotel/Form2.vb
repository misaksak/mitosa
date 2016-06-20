Public Class FormJenisKamar

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FormUtama.Show()
        Me.Close()
    End Sub



    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblpilih1.LinkClicked
        FormNoKamar.Show()
        FormNoKamar.gbkamarekonomi.Enabled = True
        FormNoKamar.gbkamarpremium.Enabled = False
        FormNoKamar.gbkamarkhusus.Enabled = False
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblpilih2.LinkClicked
        FormNoKamar.Show()
        FormNoKamar.gbkamarekonomi.Enabled = False
        FormNoKamar.gbkamarpremium.Enabled = True
        FormNoKamar.gbkamarkhusus.Enabled = False
        Me.Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblpilih3.LinkClicked
        FormNoKamar.Show()
        FormNoKamar.gbkamarekonomi.Enabled = False
        FormNoKamar.gbkamarpremium.Enabled = False
        FormNoKamar.gbkamarkhusus.Enabled = True
        Me.Close()
    End Sub

    Private Sub linkkembali_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        FormUtama.Show()
        Me.Close()
    End Sub
End Class