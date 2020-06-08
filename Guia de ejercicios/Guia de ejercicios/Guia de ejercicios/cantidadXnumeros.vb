Public Class cantidadXnumeros
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()

    End Sub
    Private Sub Limpiar()
        txtDato.Clear()
        txtImpares.Clear()
        txtNegativos.Clear()
        txtPares.Clear()
        txtPositivos.Clear()
        txtTotalNum.Clear()
        cmbNumAcumulados.Items.Clear()
        txtSumatotal.Clear()
    End Sub


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click


        Try
            Dim TotalNumeros, residuo, pares, dato, sumaTotal, impares, positivos, negativos As Integer


            If (Val(txtDato.Text)) - Int(Val(txtDato.Text)) = 0 And (Val(txtDato.Text)) >= 0 Then
                TotalNumeros = Val(txtDato.Text)
                sumaTotal = 0

                For i = 1 To TotalNumeros Step 1
                    dato = InputBox("Ingrese un numero " & i, "Ingresar numeros")
                    residuo = dato Mod 2
                    cmbNumAcumulados.Items.Add(dato)
                    If residuo = 0 Then
                        pares += 1
                    Else
                        impares += 1
                    End If

                    If dato > 0 Then
                        positivos += 1
                    Else
                        negativos += 1
                    End If

                    sumaTotal += dato

                Next

                txtImpares.Text = impares
                txtPares.Text = pares
                txtPositivos.Text = positivos
                txtNegativos.Text = negativos
                txtSumatotal.Text = sumaTotal
                txtTotalNum.Text = TotalNumeros

            Else
                MsgBox("Debe ingresar una cantidad entera positiva", vbOKOnly + vbExclamation, "Advertencia")
                Limpiar()

            End If



        Catch ex As Exception
            MsgBox(ex.Message)

        End Try





    End Sub

    Private Sub RegresarAlMenuPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarAlMenuPrincipalToolStripMenuItem.Click
        MenuPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub btnSalirtodo_Click(sender As Object, e As EventArgs) Handles btnSalirtodo.Click
        End
    End Sub
End Class