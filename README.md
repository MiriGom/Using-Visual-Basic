# Using-Visual-Basic
Here I am applying the knowledge I have obtained on Visual Basic

#1 How a simple program syntax looks like

"Public Class Form1

End Class"

#2 Button syntax to the form so we can click it and make something happen

   "Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
    End Sub"

#3 Creating a variable

   "Dim stFirstName As String"     

#4 Display variable in a message box
   "MsgBox(stFirstName)" or more currently used in Visual Basic..
   "MessageBox.Show(stFirstName)"

#5 Captureing input by setting the variable to the text box input
   "stFirstName = txtFirstName.Text"

#6 running code while the form is loading
   "Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub"