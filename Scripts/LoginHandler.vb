Imports System.Security.Cryptography
Imports System.Text

Public NotInheritable Class LoginHandler
    Public Shared userPwd As String = ""
    Shared loginFileName As String = "login.txt"
    Private Shared loginHandler As LoginHandler = New LoginHandler()
    Private Sub New()

    End Sub

    Public Shared Function GetSingleton() As LoginHandler
        If loginHandler Is Nothing Then
            loginHandler = New LoginHandler()
        End If
        Return loginHandler
    End Function

    Public Function CheckUserExists() As Boolean
        Dim fileHandler As FileHandler = New FileHandler()
        Dim lines = fileHandler.ReadFileAllLines(loginFileName)
        If lines.Length = 0 Then
            ' Register new user password
            Return False
        Else
            ' Request user to login with their password
            Return True
        End If
    End Function

    Public Sub SaveLoginPwd(ByVal pwd As String)
        Dim fileHandler As FileHandler = New FileHandler()
        Dim hash As String

        Using hasher As SHA1 = SHA1.Create()
            Dim sBuilder As New StringBuilder
            Dim saltBytes As Byte() = hasher.ComputeHash(Encoding.UTF8.GetBytes(pwd))

            ' Conert to hex string
            For n As Integer = 0 To saltBytes.Length - 1
                sBuilder.Append(saltBytes(n).ToString("X2"))
            Next n

            hash = sBuilder.ToString()
        End Using
        pwd = ""

        fileHandler.ClearFile(loginFileName)
        fileHandler.AppendNewLineToFile(loginFileName, hash)
    End Sub

    Public Function CheckPwd(ByVal pwd As String) As Boolean
        Dim fileHandler As FileHandler = New FileHandler()
        Dim hash As String

        Using hasher As SHA1 = SHA1.Create()
            Dim sBuilder As New StringBuilder
            Dim saltBytes As Byte() = hasher.ComputeHash(Encoding.UTF8.GetBytes(pwd))

            ' Conert to hex string
            For n As Integer = 0 To saltBytes.Length - 1
                sBuilder.Append(saltBytes(n).ToString("X2"))
            Next n

            hash = sBuilder.ToString()
        End Using
        pwd = ""
        Dim lines = fileHandler.ReadFileAllLines(loginFileName)
        If lines(0) = hash Then
            Return True
        End If
        Return False
    End Function
End Class
