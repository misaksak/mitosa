Public Class Form6

    Private Sub LstBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstBox.SelectedIndexChanged

    End Sub

    Sub New(lst As List(Of String))
        InitializeComponent()
        LstBox.DataSource = lst
    End Sub





End Class