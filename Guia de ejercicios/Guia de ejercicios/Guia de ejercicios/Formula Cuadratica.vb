Imports System.ComponentModel

Public Class Formula_Cuadratica
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim valorx2, valorx, valor, discriminante, resultado1, resultado2 As Double
        valorx2 = Val(txtValorx2.Text)
        valorx = Val(txtValorx.Text)
        valor = Val(txtValor.Text)

        discriminante = ((valorx) ^ 2) - (4 * ((valorx2) * (valor)))

        If discriminante < 0 Then
            MsgBox("La ecuacion no tiene solución en los numeros reales", vbOKOnly + vbExclamation, "Atención")
            txtResultado1.Clear()
            txtResultado2.Clear()
            txtValorx2.Clear()
            txtValorx.Clear()
            txtValor.Clear()
        Else
            resultado1 = ((-1 * (valorx)) + ((discriminante) ^ (1 / 2))) / (2 * valorx2)
            resultado2 = ((-1 * (valorx)) - ((discriminante) ^ (1 / 2))) / (2 * valorx2)
            txtResultado1.Text = resultado1
            txtResultado2.Text = resultado2
        End If


    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtValorx2.Clear()
        txtValorx.Clear()
        txtValor.Clear()
        txtResultado2.Clear()
        txtResultado1.Clear()
    End Sub

    Private Sub btnSalirTodo_Click(sender As Object, e As EventArgs) Handles btnSalirTodo.Click
        End
    End Sub

    Private Sub RegresarAlMenuPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarAlMenuPrincipalToolStripMenuItem.Click
        MenuPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub txtValorx2_TextChanged(sender As Object, e As EventArgs) Handles txtValorx2.TextChanged

    End Sub

    Private Sub txtValorx_TextChanged(sender As Object, e As EventArgs) Handles txtValorx.TextChanged

    End Sub

    Private Sub txtValor_TextChanged(sender As Object, e As EventArgs) Handles txtValor.TextChanged

    End Sub

    Private Sub txtValorx2_Validating(sender As Object, e As CancelEventArgs) Handles txtValorx2.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtValorx_Validating(sender As Object, e As CancelEventArgs) Handles txtValorx.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtValor_Validating(sender As Object, e As CancelEventArgs) Handles txtValor.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtValorx2_MouseHover(sender As Object, e As EventArgs) Handles txtValorx2.MouseHover
        ToolTip.SetToolTip(txtValorx2, "Ingrese el valor que acompaña a x^2")
        ToolTip.ToolTipTitle = "Valor x^2"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtValorx_MouseHover(sender As Object, e As EventArgs) Handles txtValorx.MouseHover
        ToolTip.SetToolTip(txtValorx, "Ingrese el valor que acompaña a x")
        ToolTip.ToolTipTitle = "Valor x"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtValor_MouseHover(sender As Object, e As EventArgs) Handles txtValor.MouseHover
        ToolTip.SetToolTip(txtValor, "Ingrese el valor constante")
        ToolTip.ToolTipTitle = "Valor constante"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class