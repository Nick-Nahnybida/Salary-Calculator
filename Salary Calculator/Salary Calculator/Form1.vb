Public Class Form1

    Private Sub lblPayPeriods_Click(sender As Object, e As EventArgs) Handles lblPayPeriods.Click

    End Sub

    Private Sub lblSal_Click(sender As Object, e As EventArgs) Handles lblSPPP.Click

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decAnnualSalary As Decimal ' Annual Salary
        Dim intPayPeriods As Integer   ' Number of Pay Periods
        Dim decSalary As Decimal       ' Salary per pay period
        lblStatus.Text = String.Empty

        Try
            ' Get the annual salary and number of pay periods.
            decAnnualSalary = CDec(txtAnnualSalary.Text)
            intPayPeriods = CInt(txtPayPeriods.Text)

            ' Calculate the salary per pay period.
            decSalary = decAnnualSalary / intPayPeriods

            ' Display the salary per pay period.
            lblSalary.Text = decSalary.ToString("c")
        Catch
            ' Display an error message.
            lblStatus.Text = "Error: be sure to enter nonzero " & "numeric values."
        End Try
    End Sub
End Class
