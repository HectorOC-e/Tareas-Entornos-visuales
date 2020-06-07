Public Class Calculadora
    Dim num1, num2 As Double
    Dim op As String
    Private Sub RegresarAlMenuPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarAlMenuPrincipalToolStripMenuItem.Click
        MenuPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub SalirTodo_Click(sender As Object, e As EventArgs) Handles SalirTodo.Click
        MenuPrincipal.Close()
        Me.Close()
    End Sub

    Private Sub btnUno_Click(sender As Object, e As EventArgs) Handles btnUno.Click
        txtResultado.Text = txtResultado.Text & 1
    End Sub

    Private Sub btnDos_Click(sender As Object, e As EventArgs) Handles btnDos.Click
        txtResultado.Text = txtResultado.Text & 2
    End Sub

    Private Sub btnTres_Click(sender As Object, e As EventArgs) Handles btnTres.Click
        txtResultado.Text = txtResultado.Text & 3
    End Sub

    Private Sub btnCuatro_Click(sender As Object, e As EventArgs) Handles btnCuatro.Click
        txtResultado.Text = txtResultado.Text & 4
    End Sub

    Private Sub btnCinco_Click(sender As Object, e As EventArgs) Handles btnCinco.Click
        txtResultado.Text = txtResultado.Text & 5
    End Sub

    Private Sub btnSeis_Click(sender As Object, e As EventArgs) Handles btnSeis.Click
        txtResultado.Text = txtResultado.Text & 6
    End Sub

    Private Sub btnSiete_Click(sender As Object, e As EventArgs) Handles btnSiete.Click
        txtResultado.Text = txtResultado.Text & 7
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        txtResultado.Text = txtResultado.Text & 8
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        txtResultado.Text = txtResultado.Text & 9
    End Sub

    Private Sub btnCero_Click(sender As Object, e As EventArgs) Handles btnCero.Click
        txtResultado.Text = txtResultado.Text & 0
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtResultado.Clear()
        btnPunto.Enabled = True

    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        num1 = Val(txtResultado.Text)
        txtResultado.Text = ""
        op = "+"
        txtResultado.Clear()
        btnPunto.Enabled = True
    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        num1 = Val(txtResultado.Text)
        txtResultado.Text = ""
        op = "-"
        txtResultado.Clear()
        btnPunto.Enabled = True
    End Sub

    Private Sub btnMultiplicacion_Click(sender As Object, e As EventArgs) Handles btnMultiplicacion.Click
        num1 = Val(txtResultado.Text)
        txtResultado.Text = ""
        op = "*"
        txtResultado.Clear()
        btnPunto.Enabled = True
    End Sub

    Private Sub btnRaiz_Click(sender As Object, e As EventArgs) Handles btnRaiz.Click
        num1 = Val(txtResultado.Text)
        txtResultado.Text = num1 ^ (1 / 2)
        lstbHistorial.Items.Add(txtResultado.Text & " = " & num1 & "√")
        btnPunto.Enabled = True
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        num1 = Val(txtResultado.Text)
        txtResultado.Text = ""
        op = "/"
        txtResultado.Clear()
        btnPunto.Enabled = True
    End Sub

    Private Sub btnLimpiarHistorial_Click(sender As Object, e As EventArgs) Handles btnLimpiarHistorial.Click
        lstbHistorial.Items.Clear()
    End Sub

    Private Sub btnPunto_Click(sender As Object, e As EventArgs) Handles btnPunto.Click
        txtResultado.Text = txtResultado.Text & "."
        btnPunto.Enabled = False
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        num2 = Val(txtResultado.Text)

        If op = "+" Then
            txtResultado.Text = num1 + num2
            lstbHistorial.Items.Add(txtResultado.Text & " = " & num2 & " + " & num1)

        End If

        If op = "-" Then
            txtResultado.Text = num1 - num2
            lstbHistorial.Items.Add(txtResultado.Text & " = " & num2 & " - " & num1)
        End If


        If op = "*" Then
            txtResultado.Text = num1 * num2
            lstbHistorial.Items.Add(txtResultado.Text & " = " & num2 & " * " & num1)
        End If


        If op = "/" Then
            If num1 = 0 Then
                txtResultado.Text = "No se puede dividir entre 0"
            Else
                txtResultado.Text = num1 / num2
                lstbHistorial.Items.Add(txtResultado.Text & " = " & num2 & " / " & num1)
            End If
        End If

        btnPunto.Enabled = True

    End Sub
End Class