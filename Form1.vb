Public Class Form1

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim stFirstName As String
        Dim stLastName As String
        Dim stGender As String
        Dim stOccupation As String
        Dim iHoursWorked As Integer
        Dim decPayRate As Decimal
        Dim decResult As Decimal


        stFirstName = txtFirstName.Text
        stLastName = txtLastName.Text
        stGender = txtGender.Text
        iHoursWorked = txtHoursWorked.Text
        decPayRate = txtPayRate.Text
        decResult = iHoursWorked * decPayRate

        stOccupation = lstOccupation.SelectedItem


        MsgBox("Hello " & stFirstName & " " & stLastName & " you are a " & stGender & " " & stOccupation _
               & " making $" & decPayRate & " an hour")

        MsgBox("Because you worked " & " " & iHoursWorked & " hours you have made $" & decResult)


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstOccupation.Items.Add("Writer")
        lstOccupation.Items.Add("Actor")
        lstOccupation.Items.Add("Painter")
    End Sub
End Class
