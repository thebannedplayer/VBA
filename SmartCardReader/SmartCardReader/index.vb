Imports System.Windows

Public Class index
    Private Sub btnOpenFormSmartcard_Click(sender As Object, e As EventArgs) Handles btnOpenFormSmartcard.Click
        Dim oForm As New frmSmartCard
        oForm.ShowDialog()
    End Sub

    Private Sub btnOpenFormcusSearch_Click(sender As Object, e As EventArgs) Handles btnOpenFormcusSearch.Click
        Dim oForm As New cusSearch
        oForm.ShowDialog()
    End Sub
End Class