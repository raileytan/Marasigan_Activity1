Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim a As Integer
        Dim b As Integer

        a = txtFirstnum.Text
        b = txtSecondnum.Text

        lblresult.Text = a + b


    End Sub
End Class

