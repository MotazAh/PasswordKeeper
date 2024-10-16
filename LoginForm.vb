Public Class LoginForm
    Dim loginHandler As LoginHandler = LoginHandler.GetSingleton()

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If loginHandler.CheckUserExists() Then
            lblTitle.Text = "Login"
            lblTitle.Location = New Point((ClientSize.Width - lblTitle.Width) / 2, lblTitle.Location.Y)
            lblConfirmPwd.Visible = False
            txtConfirmPwd.Visible = False
            btnLogin.Text = "Login"
            btnLogin.Location = New Point((ClientSize.Width - btnLogin.Width) / 2, btnLogin.Location.Y)
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Threading.Thread.Sleep(500)
        If btnLogin.Text = "Login" Then
            ' Check user password
            If loginHandler.CheckPwd(txtPwd.Text) Then
                txtPwd.Text = ""

                ' Open main program and hide the login form
                Dim form1 As MainProgram = New MainProgram()
                Me.Hide()
                form1.Show()

                AddHandler form1.FormClosed, AddressOf CloseForm
            Else
                MessageBox.Show("Incorrect password")
            End If
        Else
            ' Save new user password
            If txtPwd.Text = "" Then
                MessageBox.Show("Please enter a password")
                Return
            End If
            If Not txtPwd.Text.Equals(txtConfirmPwd.Text) Then
                MessageBox.Show("Passwords don't match")
                Return
            End If
            ' Open main program and hide the login form
            Dim form1 As MainProgram = New MainProgram()
            Me.Hide()
            form1.Show()

            AddHandler form1.FormClosed, AddressOf CloseForm
            loginHandler.SaveLoginPwd(txtPwd.Text)
            txtPwd.Text = ""
            txtConfirmPwd.Text = ""
        End If

    End Sub

    Private Sub CloseForm()
        Me.Close()
    End Sub
End Class