<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblGender = New Button()
        lblFirstName = New Button()
        btnLastName = New Button()
        txtFirstName = New TextBox()
        txtLastName = New TextBox()
        txtGender = New TextBox()
        btnGo = New Button()
        lblOccupation = New Label()
        lstOccupation = New ListBox()
        SuspendLayout()
        ' 
        ' lblGender
        ' 
        lblGender.BackColor = Color.Cyan
        lblGender.Location = New Point(222, 235)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(94, 29)
        lblGender.TabIndex = 0
        lblGender.Text = "Gender"
        lblGender.UseVisualStyleBackColor = False
        ' 
        ' lblFirstName
        ' 
        lblFirstName.Location = New Point(222, 127)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(94, 29)
        lblFirstName.TabIndex = 1
        lblFirstName.Text = "First Name"
        lblFirstName.UseVisualStyleBackColor = True
        ' 
        ' btnLastName
        ' 
        btnLastName.Location = New Point(222, 177)
        btnLastName.Name = "btnLastName"
        btnLastName.Size = New Size(94, 29)
        btnLastName.TabIndex = 2
        btnLastName.Text = "Last Name"
        btnLastName.UseVisualStyleBackColor = True
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(322, 129)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(227, 27)
        txtFirstName.TabIndex = 3
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(322, 179)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(227, 27)
        txtLastName.TabIndex = 4
        ' 
        ' txtGender
        ' 
        txtGender.Location = New Point(322, 235)
        txtGender.Name = "txtGender"
        txtGender.Size = New Size(227, 27)
        txtGender.TabIndex = 5
        ' 
        ' btnGo
        ' 
        btnGo.Location = New Point(222, 75)
        btnGo.Name = "btnGo"
        btnGo.Size = New Size(94, 29)
        btnGo.TabIndex = 6
        btnGo.Text = "Go"
        btnGo.UseVisualStyleBackColor = True
        ' 
        ' lblOccupation
        ' 
        lblOccupation.AutoSize = True
        lblOccupation.Location = New Point(600, 9)
        lblOccupation.Name = "lblOccupation"
        lblOccupation.Size = New Size(85, 20)
        lblOccupation.TabIndex = 8
        lblOccupation.Text = "Occupation"
        ' 
        ' lstOccupation
        ' 
        lstOccupation.FormattingEnabled = True
        lstOccupation.Items.AddRange(New Object() {"Doctor", "Programmer", "Teacher", "Student", "Tailor", "Sailor", "Soldier", "Tinker"})
        lstOccupation.Location = New Point(600, 42)
        lstOccupation.Name = "lstOccupation"
        lstOccupation.Size = New Size(134, 224)
        lstOccupation.TabIndex = 9
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lstOccupation)
        Controls.Add(lblOccupation)
        Controls.Add(btnGo)
        Controls.Add(txtGender)
        Controls.Add(txtLastName)
        Controls.Add(txtFirstName)
        Controls.Add(btnLastName)
        Controls.Add(lblFirstName)
        Controls.Add(lblGender)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblGender As Button
    Friend WithEvents lblFirstName As Button
    Friend WithEvents btnLastName As Button
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents btnGo As Button
    Friend WithEvents lblOccupation As Label
    Friend WithEvents lstOccupation As ListBox

End Class
