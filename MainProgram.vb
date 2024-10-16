Imports PasswordKeeper.FileHandler
Public Class MainProgram
    Dim defaultButton As Button
    Dim pHandler As PassHandler = PassHandler.GetSingleton()
    Dim loginHandler As LoginHandler = LoginHandler.GetSingleton()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tableLayoutPass.RowStyles.Add(New RowStyle(SizeType.Absolute, 25))
        PassHandler.LoadPasswords()
        For Each kvp As KeyValuePair(Of String, String()) In PassHandler.passDict
            AddPassRow(kvp.Key, kvp.Value(0))
        Next
    End Sub

    Private Sub AddPassRow(ByVal id As String, ByVal description As String)
        tableLayoutPass.SuspendLayout()

        Dim btnShow As New Button
        Dim btnRemove As New Button
        Dim txtType As New TextBox
        Dim txtPassword As New TextBox

        btnShow.Text = "Show"
        btnShow.Name = id
        btnShow.Anchor = AnchorStyles.None
        btnShow.AutoSize = True
        btnShow.Dock = DockStyle.None
        btnShow.BackColor = Color.Transparent
        btnShow.Size = New Size(50, 23)
        btnShow.MinimumSize = New Size(50, 23)
        btnShow.Margin = New Padding(0, 1, 0, 1)
        AddHandler btnShow.Click, AddressOf ShowPassword

        btnRemove.Text = "Remove"
        btnRemove.Name = id
        btnRemove.Anchor = AnchorStyles.None
        btnRemove.AutoSize = True
        btnRemove.Dock = DockStyle.None
        btnRemove.BackColor = Color.Transparent
        btnRemove.Size = New Size(50, 23)
        btnRemove.MinimumSize = New Size(50, 23)
        btnRemove.Margin = New Padding(0, 1, 0, 1)
        AddHandler btnRemove.Click, AddressOf RemovePassword

        txtType.Text = description
        txtType.BorderStyle = BorderStyle.None
        txtType.ReadOnly = True
        txtType.Size = New Size(320, 19)
        txtType.Anchor = AnchorStyles.None
        txtType.Dock = DockStyle.None
        txtType.TextAlign = HorizontalAlignment.Center
        txtType.BackColor = Color.White
        txtType.Font = New Font("Microsoft Sans Serif", 12)

        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.ReadOnly = True
        txtPassword.Size = New Size(320, 19)
        txtPassword.Anchor = AnchorStyles.None
        txtPassword.Dock = DockStyle.None
        txtPassword.TextAlign = HorizontalAlignment.Center
        txtPassword.BackColor = Color.White
        txtPassword.Font = New Font("Microsoft Sans Serif", 12)
        txtPassword.Enabled = False

        With tableLayoutPass
            .Controls.Add(txtType)
            .Controls.Add(txtPassword)
            .Controls.Add(btnShow)
            .Controls.Add(btnRemove)
        End With

        tableLayoutPass.RowStyles.Add(New RowStyle(SizeType.Absolute, 30))

        tableLayoutPass.ResumeLayout()
    End Sub

    Private Sub RemoveRow(ByVal row As Integer)
        tableLayoutPass.SuspendLayout()
        For i As Integer = 0 To tableLayoutPass.ColumnCount - 1
            Dim control As Control = tableLayoutPass.GetControlFromPosition(0, row)
            tableLayoutPass.Controls.Remove(control)
            control.Dispose()
        Next

        tableLayoutPass.RowStyles.RemoveAt(row)
        Dim rowStyleCount As Integer = tableLayoutPass.RowStyles.Count
        tableLayoutPass.RowStyles.Clear()

        tableLayoutPass.ResumeLayout()

        For i As Integer = 0 To rowStyleCount - 1
            tableLayoutPass.RowStyles.Add(New RowStyle(SizeType.Absolute, 30))
        Next
    End Sub

    ' Shows password temporarily after clicking the show button
    Private Sub ShowPassword(ByVal sender As Control, ByVal e As System.EventArgs)
        Try
            Dim row As Integer = tableLayoutPass.GetPositionFromControl(sender).Row
            Dim id As String = sender.Name
            Dim pwdCell As TextBox = tableLayoutPass.GetControlFromPosition(1, row)

            If sender.Text = "Hide" Then
                pwdCell.Enabled = False ' Disable password cell
                pwdCell.Text = ""
                sender.Text = "Show"
                Return
            End If

            Dim pwdPopup As PasswordPopup = New PasswordPopup()

            Dim result As DialogResult = pwdPopup.ShowDialog(Me)

            If result = DialogResult.Cancel Then
                MessageBox.Show("Incorrect Password")
                Return
            End If

            Dim password As String = pHandler.GetPassword(id, LoginHandler.userPwd)
            LoginHandler.userPwd = ""
            password = password.Substring(0, password.Length - 40)
            pwdCell.Enabled = True ' Enable password cell
            pwdCell.Text = password
            sender.Text = "Hide"
            password = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ' Removes password
    Private Sub RemovePassword(ByVal sender As Control, ByVal e As System.EventArgs)
        Try
            Dim pwdPopup As PasswordPopup = New PasswordPopup()
            ' Avoid deletion if the password is incorrect (Avoid bad actor from deleting passwords)
            If pwdPopup.ShowDialog() = DialogResult.Cancel Then
                MessageBox.Show("Incorrect Password")
                Return
            End If
            LoginHandler.userPwd = ""

            Dim id As String = sender.Name
            Dim row As Integer = tableLayoutPass.GetPositionFromControl(sender).Row
            pHandler.RemovePassword(id)
            RemoveRow(row)
            MessageBox.Show("Successfully removed password")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnAddPassword_Click(sender As Object, e As EventArgs) Handles btnAddPassword.Click
        Dim pwdPopup As PasswordPopup = New PasswordPopup()
        If pwdPopup.ShowDialog() = DialogResult.Cancel Then
            MessageBox.Show("Incorrect Password")
            Return
        End If
        Dim id = pHandler.SavePassword(txtDescription.Text, txtPassword.Text, LoginHandler.userPwd)
        If Not id.Equals("") Then
            MessageBox.Show("Successfully added password")
            AddPassRow(id, txtDescription.Text)
        End If
        LoginHandler.userPwd = ""
        txtDescription.Text = ""
        txtPassword.Text = ""
    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property
End Class
