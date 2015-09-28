

Public Class Panel
    Private Sub Panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cerrarfmf()

    End Sub

    Function cerrarfmf()
        fmfEgresos.Close()
        fmfIngresos.Close()
        fmfProductos.Close()
        fmfProvedores.Close()
        PanelConfiguraciones.Close()
        Inicio.Close()

        Return 0

    End Function


    Private Sub PictureBox1_Click_1_Proveedores(sender As Object, e As EventArgs) Handles PictureBoxProveedores.Click
        cerrarfmf()
        fmfProvedores.Show()

    End Sub

    Private Sub PictureBox4_Click_Productos(sender As Object, e As EventArgs) Handles PictureBoxProductos.Click
        cerrarfmf()
        fmfProductos.Show()

    End Sub

    Private Sub PictureBox2_Click_Ingresos(sender As Object, e As EventArgs) Handles PictureBoxIngresos.Click
        cerrarfmf()
        fmfIngresos.Show()
    End Sub

    Private Sub PictureBox3_Click_Egresos(sender As Object, e As EventArgs) Handles PictureBoxEgresos.Click
        cerrarfmf()
        fmfEgresos.Show()

    End Sub

    Private Sub PictureBoxParam_Click(sender As Object, e As EventArgs) Handles PictureBoxParam.Click
        cerrarfmf()
        PanelConfiguraciones.Show()

    End Sub


End Class