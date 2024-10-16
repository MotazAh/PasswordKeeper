Imports System.Security.Cryptography
Imports System.Text
Imports PasswordKeeper.FileHandler
Public NotInheritable Class PassHandler
    Public Shared passDict As Dictionary(Of String, String()) = New Dictionary(Of String, String())
    Shared passFileName As String = "pass.txt"
    Private Shared passHandler As PassHandler = New PassHandler()
    Private Sub New()

    End Sub

    Public Shared Function GetSingleton() As PassHandler
        If passHandler Is Nothing Then
            passHandler = New PassHandler()
        End If
        Return passHandler
    End Function

    Public Shared Sub LoadPasswords()
        Dim fileHandler As New FileHandler()
        Dim lines = fileHandler.ReadFileAllLines(passFileName)

        For Each line As String In lines
            Dim words = line.Split("_")
            passDict.Add(words(0), {words(1), words(2), words(3)})
        Next
    End Sub

    ' Saves new password to file with encryption
    Public Function SavePassword(ByVal description As String, ByVal pass As String, ByVal key As String)
        If description.Contains("_") Then
            MessageBox.Show("Using underscores '_' is not allowed in description")
            Return False
        End If
        Dim salt As String
        Dim fileHandler As New FileHandler()

        Using hasher As SHA1 = SHA1.Create()
            Dim sBuilder As New StringBuilder
            Dim saltBytes As Byte() = hasher.ComputeHash(Encoding.UTF8.GetBytes(TimeString))

            ' Conert to hex string
            For n As Integer = 0 To saltBytes.Length - 1
                sBuilder.Append(saltBytes(n).ToString("X2"))
            Next n

            salt = sBuilder.ToString()
        End Using
        Try
            Dim encryptedPass = EncryptString(pass, key, salt)
            key = ""

            Dim id As String = Guid.NewGuid().ToString("N")
            fileHandler.AppendNewLineToFile(passFileName, id + "_" + description + "_" + encryptedPass + "_" + salt)
            passDict.Add(id, {description, encryptedPass, salt})
            Return id
        Catch ex As Exception
            MessageBox.Show("Unable to write to file")
        End Try
        Return ""
    End Function

    Public Function GetPassword(ByVal id As String, ByVal key As String)
        Dim hash As String = passDict(id)(1)

        Return DecryptString(hash, key)
    End Function

    Public Sub RemovePassword(ByVal id As String)
        Try
            Dim fileHandler As FileHandler = New FileHandler()
            fileHandler.RemoveLineFromFileById(passFileName, id)
            passDict.Remove(id)
        Catch ex As Exception
            MessageBox.Show("Unable to remove password: " & ex.Message)
        End Try
    End Sub

    ' Encrypts and salts string with AES using given key
    Private Function EncryptString(ByVal text As String, ByVal key As String, ByVal salt As String) As String
        Dim encrypted As String = ""
        Dim AES As New RijndaelManaged
        Dim keyHash As Byte()

        Using hasher As MD5 = MD5.Create()
            keyHash = hasher.ComputeHash(Encoding.UTF8.GetBytes(key))
        End Using
        key = ""
        Try
            AES.Mode = CipherMode.ECB
            AES.Key = keyHash

            Dim DESEncrypter As ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(text + salt)

            For i As Integer = 0 To 10
                Buffer = DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length)
            Next

            encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
        Catch ex As Exception
            MessageBox.Show("Unable to encrypt: " & ex.Message)
        End Try
        Return encrypted
    End Function

    ' Decrypts given encrypted string
    Private Function DecryptString(ByVal encryptedStr As String, ByVal key As String) As String
        Dim decrypted As String = ""
        Dim AES As New RijndaelManaged
        Dim keyHash As Byte()

        Using hasher As MD5 = MD5.Create()
            keyHash = hasher.ComputeHash(Encoding.UTF8.GetBytes(key))
        End Using

        Try
            AES.Mode = CipherMode.ECB
            AES.Key = keyHash

            Dim DESDecrypter As ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = Convert.FromBase64String(encryptedStr)

            For i As Integer = 0 To 10
                Buffer = DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length)
            Next

            decrypted = ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
        Catch ex As Exception
            MessageBox.Show("Unable to decrypt: " & ex.Message)
        End Try
        Return decrypted
    End Function
End Class
