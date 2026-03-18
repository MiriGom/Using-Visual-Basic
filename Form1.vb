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

        If IsNumeric(txtHoursWorked.Text) = True Then
            iHoursWorked = CInt(txtHoursWorked.Text)   'Cint converts the text to an integer
        Else
            MsgBox("You must enter a number")
            Exit Sub
        End If


        MsgBox("Hello " & stFirstName & " " & stLastName & " you are a " & stGender & " " & stOccupation _
               & " making $" & decPayRate & " an hour")

        MsgBox("Because you worked " & " " & iHoursWorked & " hours you have made $" & decResult)

        If iHoursWorked < 40 Then
            MsgBox("You have not worked enough hours to get overtime")
        ElseIf iHoursWorked = 40 Then
            MsgBox("You have worked 40 hours, you will not get overtime")
        ElseIf iHoursWorked > 40 Then
            MsgBox("You have worked more than 40 hours, you will get overtime")
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstOccupation.Items.Add("Writer")
        lstOccupation.Items.Add("Actor")
        lstOccupation.Items.Add("Painter")
    End Sub
End Class
