Public Class Form1

    Dim objConversor = New Conversor()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub cambiarConversor(ByVal tipo As SByte)
        cboDeTipoConversor.Items.Clear()
        cboATipoConversor.Items.Clear()

        cboDeTipoConversor.Items.AddRange(objConversor.etiquetas(tipo))
        cboATipoConversor.Items.AddRange(objConversor.etiquetas(tipo))
    End Sub

    Private Sub cboTipoConversor_TextChanged(sender As Object, e As EventArgs) Handles cboTipoConversor.TextChanged
        cambiarConversor(cboTipoConversor.SelectedIndex())
    End Sub

    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click
        lblRespuesta.Text = Math.Round(objConversor.convertir(cboTipoConversor.SelectedIndex, cboDeTipoConversor.SelectedIndex, cboATipoConversor.SelectedIndex, txtConvertir.Text), 2).ToString() + " " + objConversor.etiquetas(cboTipoConversor.SelectedIndex)(cboATipoConversor.SelectedIndex)
    End Sub
End Class
