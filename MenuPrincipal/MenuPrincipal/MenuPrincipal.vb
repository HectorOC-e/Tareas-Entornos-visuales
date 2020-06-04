Public Class MenuPrincipal
    Private Sub CalcularMontoInicialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularMontoInicialToolStripMenuItem.Click
        MontoInicialCompuesto.Show()
        Me.Hide()
    End Sub

    Private Sub CalcularTasaDeInteresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularTasaDeInteresToolStripMenuItem.Click
        TasaDeInteres.Show()
        Me.Hide()
    End Sub

    Private Sub CalcularElNumeroDeAñosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularElNumeroDeAñosToolStripMenuItem.Click
        CalcularTiempo.Show()
        Me.Hide()
    End Sub

    Private Sub CalcularElMontoFinalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularElMontoFinalToolStripMenuItem.Click

    End Sub
End Class

