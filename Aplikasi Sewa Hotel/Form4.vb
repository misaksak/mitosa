Public Class FormPemesanan
    Dim lst As List(Of String) = New List(Of String)


    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles lblpesan.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub lnkkembali_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkkembali.LinkClicked
        FormNoKamar.Show()
    End Sub

    Private Sub FormPemesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnTampil.Click
        Dim btnTampil As Form6 = New Form6(lst)

        btnTampil.Show()




    End Sub
End Class