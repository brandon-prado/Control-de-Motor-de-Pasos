Public Class FrmInicio
    Private Sub BtnIniciar_Click(sender As Object, e As EventArgs) Handles BtnIniciar.Click
        FrmMenuPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class