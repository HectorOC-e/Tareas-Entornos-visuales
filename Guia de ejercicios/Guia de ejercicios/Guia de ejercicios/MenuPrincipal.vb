Public Class MenuPrincipal
    Private Sub CalculadoraCientificaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraCientificaToolStripMenuItem.Click
        Calculadora.Show()
        Me.Hide()
    End Sub

    Private Sub FormulaCuadraticaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormulaCuadraticaToolStripMenuItem.Click
        Formula_Cuadratica.Show()
        Me.Hide()

    End Sub

    Private Sub NumerosImparesYParesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NumerosImparesYParesToolStripMenuItem1.Click
        cantidadXnumeros.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        DeduccionOexento.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        Ventas_de_una_empresa.Show()
        Me.Hide()
    End Sub
End Class
