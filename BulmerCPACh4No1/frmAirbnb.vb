' Program:  AirBnB Reservations
' Author:   Mark Bulmer
' Date:     February 13, 2022
' Purpose:  This application calculates and displays the total
'           cost of renting an Air BnB for a specified number of nights.

Option Strict On

Public Class frmAirbnb

    ' Cost per bike rental - used in multiple procedures
    Const _cdecPricePerDay As Decimal = 79D


    Private Sub btnCost_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCost.Click
        ' This event handler is executed when the user clicks the
        ' Find Cost button. It calculates and displays the cost
        ' of the bike rented (number of days times the cost per bike).

        Dim strNumberOfDays As String
        Dim intNumberOfDays As Integer
        Dim decTotalCost As Decimal

        strNumberOfDays = txtNumberOfDays.Text
        intNumberOfDays = Convert.ToInt32(strNumberOfDays)
        decTotalCost = intNumberOfDays * _cdecPricePerDay
        lblTotalCost.Text = decTotalCost.ToString("C")
    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
        ' This event handler is executed when the user clicks the
        ' Clear button. It clears the number of days text box
        ' and the Text property of the Total Cost label.
        ' Then it sets the focus on the txtNumberOfDays Textbox object.

        txtNumberOfDays.Clear()
        lblTotalCost.Text = ""
        txtNumberOfDays.Focus()

    End Sub

    Private Sub frmDigitalDownloads_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' This event handler is executed when the form is loaded.
        ' It displays the cost heading, clears the Text property of the
        ' Total Cost label, and sets the focus on
        '  the txtNumberOfDays Textbox object.
        lblCostHeading.Text = "Only " & _cdecPricePerDay.ToString("C") & " per night"
        lblTotalCost.Text = ""
        txtNumberOfDays.Focus()

    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        ' Close the window and terminate the application.

        Close()
    End Sub

End Class
