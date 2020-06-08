Public Class Ventas_de_una_empresa
    Private Sub RegresarAlMenuPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarAlMenuPrincipalToolStripMenuItem.Click
        MenuPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtMediaVenta.Clear()
        lstVentasSuperiores.Items.Clear()

    End Sub

    Private Sub ventaFN()

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim venta1, venta2, venta3, venta4, venta5, venta6, venta7, venta8, venta9, venta10, MediaVentas As Double
        Try


            venta1 = InputBox("Ingrese las ventas obtenidas por parte de la empresa 1", "Ingresar")
            cmbVentaEmpresa.Items.Add("Primer Empresa L." & venta1)


            venta2 = InputBox("Ingrese las ventas obtenidas por parte de la empresa 2", "Ingresar")
            cmbVentaEmpresa.Items.Add("Segunda Empresa L." & venta2)


            venta3 = InputBox("Ingrese las ventas obtenidas por parte de la empresa 3", "Ingresar")
            cmbVentaEmpresa.Items.Add("Tercer Empresa L." & venta1)


            venta4 = InputBox("Ingrese las ventas obtenidas por parte de la empresa 4", "Ingresar")
            cmbVentaEmpresa.Items.Add("Cuarta Empresa L." & venta1)


            venta5 = InputBox("Ingrese las ventas obtenidas por parte de la empresa 5", "Ingresar")
            cmbVentaEmpresa.Items.Add("Quinta Empresa L." & venta1)


            venta6 = InputBox("Ingrese las ventas obtenidas por parte de la empresa 6", "Ingresar")
            cmbVentaEmpresa.Items.Add("Sexta Empresa L." & venta1)


            venta7 = InputBox("Ingrese las ventas obtenidas por parte de la empresa 7", "Ingresar")

            cmbVentaEmpresa.Items.Add("Septima Empresa L." & venta1)


            venta8 = InputBox("Ingrese las ventas obtenidas por parte de la empresa 8", "Ingresar")
            cmbVentaEmpresa.Items.Add("Octava Empresa L." & venta1)


            venta9 = InputBox("Ingrese las ventas obtenidas por parte de la empresa 9", "Ingresar")
            cmbVentaEmpresa.Items.Add("Novena Empresa L." & venta1)


            venta10 = InputBox("Ingrese las ventas obtenidas por parte de la empresa 10", "Ingresar")
            cmbVentaEmpresa.Items.Add("Decima Empresa L." & venta1)

            MediaVentas = (venta1 + venta2 + venta3 + venta4 + venta5 + venta6 + venta7 + venta8 + venta9 + venta10) / 10

            txtMediaVenta.Text = MediaVentas

            If venta1 > MediaVentas Then
                lstVentasSuperiores.Items.Add("Primer empresa L." & venta1)
            End If
            If venta2 > MediaVentas Then
                lstVentasSuperiores.Items.Add("Segunda empresa L." & venta2)
            End If
            If venta3 > MediaVentas Then
                lstVentasSuperiores.Items.Add("Tercer empresa L." & venta3)
            End If
            If venta4 > MediaVentas Then
                lstVentasSuperiores.Items.Add("Cuarta empresa L." & venta4)
            End If
            If venta5 > MediaVentas Then
                lstVentasSuperiores.Items.Add("Quinta empresa L." & venta5)
            End If
            If venta6 > MediaVentas Then
                lstVentasSuperiores.Items.Add("Sexto empresa L." & venta6)
            End If
            If venta7 > MediaVentas Then
                lstVentasSuperiores.Items.Add("Septimo empresa L." & venta7)
            End If
            If venta8 > MediaVentas Then
                lstVentasSuperiores.Items.Add("Octavo empresa L." & venta8)
            End If
            If venta9 > MediaVentas Then
                lstVentasSuperiores.Items.Add("Nueve empresa L." & venta9)
            End If
            If venta10 > MediaVentas Then
                lstVentasSuperiores.Items.Add("Decimo empresa L." & venta10)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnSalirTodo_Click(sender As Object, e As EventArgs) Handles btnSalirTodo.Click
        End
    End Sub
End Class