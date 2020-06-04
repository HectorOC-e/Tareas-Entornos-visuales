Public Class MenuPrincipal
    Private Sub CalcularMontoInicialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularMontoInicialToolStripMenuItem.Click
        MontoInicialCompuesto.Show()
        Me.Hide()
    End Sub

    Private Sub CalcularTasaDeInteresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularTasaDeInteresToolStripMenuItem.Click
        TasaDeInteresCompuesto.Show()
        Me.Hide()
    End Sub

    Private Sub CalcularElNumeroDeAñosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularElNumeroDeAñosToolStripMenuItem.Click
        CalcularTiempo_ICompuesto.Show()
        Me.Hide()
    End Sub

    Private Sub CalcularElMontoFinalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularElMontoFinalToolStripMenuItem.Click
        MontoFinal_ICompuesto.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub CapitalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CapitalToolStripMenuItem.Click
        Capital_ISimple.Show()
        Me.Hide()
    End Sub

    Private Sub TasaDeInteresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TasaDeInteresToolStripMenuItem.Click
        TasaInteres_Isimple.Show()
        Me.Hide()
    End Sub

    Private Sub PeriodoDeTiempoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeriodoDeTiempoToolStripMenuItem.Click
        Tiempo_ISimple.Show()
        Me.Hide()

    End Sub
End Class

