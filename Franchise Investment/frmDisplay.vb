' The frmDisplayInventory class is opened by frmDepreciation
' and displays the inventory file in sorted order

Option Strict On


Public Class frmDisplay

    Private Sub frmDisplayInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' The frmDisplayInventory load event is a second forms that
        ' displays the sorted inventory items

    End Sub

    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        ' This Sub procedure opens the first form
        Dim frmFirst As New frmInvestment

        Hide()
        frmFirst.ShowDialog()
    End Sub


End Class