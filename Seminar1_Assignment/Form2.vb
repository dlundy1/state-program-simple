Public Class Form2
    ''Public Property statestring As String
    ''Public Property abbrevstring As String
    Private Sub quit_button_Click(sender As Object, e As EventArgs) Handles quit_button.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub search_more_button_Click(sender As Object, e As EventArgs) Handles search_more_button.Click
        Me.Close()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class