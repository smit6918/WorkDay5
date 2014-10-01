Option Strict On

Public Class Form1

    Private Sub btnDetermine_Click(sender As System.Object, e As System.EventArgs) Handles btnDetermine.Click
        Dim name As String
        name = txtFullName.Text
        'name = txtFullName.Text.Trim() this will allow you to put spaces in front of first name 
        txtFirstName.Text = FirstName(name)
    End Sub

    Function FirstName(ByVal name As String) As String
        Dim idxSpace As Integer
        idxSpace = name.IndexOf(" ")

        Dim fstName As String
        fstName = name.Substring(0, idxSpace)

        Return fstName
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
