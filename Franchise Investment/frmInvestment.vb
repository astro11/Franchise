' Program Name:     Franchise Investment
' Author:           Aquila Strother
' Date:             5/23/2016
' Purpose:          This Windows application determines the average cost for investing in a
'                   franchise restuarant.

Option Strict On

Public Class frmInvestment
    ' Class Level Private variables
    Private _intLifeOfItems As Integer = 6
    Public Shared _intSizeOfArray As Integer = 7
    Public Shared _strInventoryItem(_intSizeOfArray) As String
    Private _strItemId(_intSizeOfArray) As String
    Private _decInitialPrice(_intSizeOfArray) As String
    Private _intQuantity(_intSizeOfArray) As Integer

    Private Sub frmInvestment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' The frmInvestment load event reads the franchise text files and
        ' fills the Listbox object with the inventory items

        ' Initialize an instance of the StreamReader object and declare variables
        Dim objReader As IO.StreamReader
        Dim strLocationAndNameOfFile As String = "C:\Users\JetStream\Documents\Book Files\Chapter 08\Franchise.txt"
        Dim intCount As Integer = 0
        Dim strFileError As String = "The file is not available. Restart when the file is available."

        'Verify the file exists
        If IO.File.Exists("C: \Users\JetStream\Documents\Book Files\Chapter 08\Franchise.txt") Then
            objReader = IO.File.OpenText("C:\Users\JetStream\Documents\Book Files\Chapter 08\Franchise.txt")

            ' Read the file line by line until the file is completed
            Do While objReader.Peek <> -1
                _strInventoryItem(intCount) = objReader.ReadLine()
                _strItemId(intCount) = objReader.ReadLine()
                _decInitialPrice(intCount) = Convert.ToString(objReader.ReadLine())
                _intQuantity(intCount) = Convert.ToInt32(objReader.ReadLine())

            Loop
            objReader.Close()

            ' The Listbox object is filled with the franchise items
            For intFill = 0 To (_strItemId.Length - 1)
                lstFranchise.Items.Add(_strItemId)
            Next

        Else
            MsgBox(strFileError, , "Error")
            Close()
        End If


    End Sub

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click

        'The btnCalculateDepreciation click event calls the depreciation Sub procedures
        ' Declare variables
        Dim intSelectedItemId As Integer
        Dim strMissingSelection As String = "Missing Selection"
        Dim strSelectInventoryItemIdError As String = "Select a Franchise"

        ' If the ListBox and a Depreciation RadioButton object are selected,
        ' call the depreciation procedures
        If lstFranchise.SelectedIndex >= 0 Then
            intSelectedItemId = lstFranchise.SelectedIndex



        Else
            MsgBox(strSelectInventoryItemIdError, , strMissingSelection)

        End If
    End Sub




    Private Sub MakeObjectsVisible()
        ' This procedure displays the objects showing the results
        lblSelectedInvestment.Visible = True
        lblCost.Visible = True

        ' The previous data is removed
        lstFranchise.Items.Clear()


    End Sub


    Private Sub mnuDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDisplay.Click
        ' The mnuDisplay click event creates an instance of frmDisplayInventory
        Dim frmSecond As New frmDisplay

        ' Hide this form and show the Display Inventory form
        Hide()
        frmSecond.ShowDialog()
    End Sub


    Private Sub mnuClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClear.Click
        ' The mnuClear click event clears and resets the form
        lstFranchise.Items.Clear()
        lblCost.Visible = False
        lblSelectedInvestment.Visible = False


    End Sub


    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        ' The mnuExit click event closes the application
        Application.Exit()
    End Sub

End Class
