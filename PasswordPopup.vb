Public Class PasswordPopup
    Dim loginHandler As LoginHandler = LoginHandler.GetSingleton()
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If loginHandler.CheckPwd(txtPassword.Text) Then
            DialogResult = DialogResult.OK
            LoginHandler.userPwd = txtPassword.Text
        Else
            DialogResult = DialogResult.Cancel
        End If

        Close()
    End Sub
End Class