Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Get today’s date from the system and display it.
        lblDateToday.Text = Now.ToString("D")

        ' Get the current time from the system and display it.
        lblTimeToday.Text = Now.ToString("T")
    End Sub

    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        Dim decTax As Decimal
        Dim decPayment As Decimal
        Dim decResult As Decimal
        Dim decTotal As Decimal
        Const decTAX_RATE As Decimal = 0.08  ' Tax rate
        Dim blnInputOk As Boolean = True

        'Constants for packages fee
        Const decLEATH_FEE As Decimal = 2000D
        Const decHEAT_FEE As Decimal = 3000D
        Const decCLOTH_FEE As Decimal = 0D

        'Constants for OPTIONS fee
        Const decNAVIGATION_FEE As Decimal = 4000D
        Const decPOWER_FEE As Decimal = 1000D
        Const decENTERTAINMENT_FEE As Decimal = 4500D

        If blnInputOk = True Then
            ' Determine the base monthly fee.
            If radLeath.Checked = True Then
                decTotal = decLEATH_FEE
            ElseIf radHeat.Checked = True Then
                decTotal = decHEAT_FEE
            ElseIf radCloth.Checked = True Then
                decTotal = decCLOTH_FEE
            End If


            ' Check for additonal services.
            If chkNavi.Checked = True Then
                decTotal += decNAVIGATION_FEE
            End If

            If chkPower.Checked = True Then
                decTotal += decPOWER_FEE
            End If

            If chkEnter.Checked = True Then
                decTotal += decENTERTAINMENT_FEE
            End If

            'Calculate the Sales Tax
            decTax = CDec(txtprice.Text) * decTAX_RATE
            lblTax.Text = decTax.ToString("c")

            'calculate the monthly payment
            decPayment = (CDec(txtprice.Text) + decTax) / ((txtloan.Text) * 12)
            lblPayment.Text = decPayment.ToString("c")

            'Calculate the result
            decResult = (CDec(txtprice.Text) + decTotal + decTax) / ((txtloan.Text) * 12)

            'display the result
            lblResult.Text = txtName.Text & decResult.ToString("c")
        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'clear the fields
        txtName.Clear()
        txtprice.Clear()
        txtloan.Clear()

        'clearing the monthly and tax fields
        lblTax.Text = String.Empty
        lblPayment.Text = String.Empty
        lblResult.Text = String.Empty


        txtName.Focus()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        lblStatus.Text = Now.ToString("D")

    End Sub

   
    End Sub
End Class

