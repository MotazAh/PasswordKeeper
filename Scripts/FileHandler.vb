Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class FileHandler
    Sub New()
    End Sub

    Public Function ReadFileAllLines(ByVal fileName As String) As String()
        Try
            Dim lines = IO.File.ReadAllLines(fileName)
            Return lines
        Catch ex As Exception
            MessageBox.Show("Unable to read file: " & ex.Message)
        End Try
        Return {} ' Failed to read file
    End Function

    Public Function AppendNewLineToFile(ByVal fileName As String, ByVal text As String)
        Try
            IO.File.AppendAllText(fileName, text & Environment.NewLine)
            Return True
        Catch ex As Exception
            MessageBox.Show("Unable to write to file: " & ex.Message)
        End Try
        Return False ' Failed to append new line
    End Function

    Public Function RemoveLineFromFileById(ByVal fileName As String, ByVal id As String)
        Try
            Dim lines As List(Of String) = IO.File.ReadAllLines(fileName).ToList
            For i As Integer = 0 To lines.Count - 1
                Dim words As String() = lines(i).Split("_")
                If words(0) = id Then
                    lines.RemoveAt(i)
                    Exit For
                End If
            Next
            IO.File.WriteAllLines(fileName, lines)
            Return True
        Catch ex As Exception
            MessageBox.Show("Unable to remove from file: " & ex.Message)
        End Try
        Return False ' Failed to remove line
    End Function

    Public Sub ClearFile(ByVal fileName As String)
        Try
            IO.File.WriteAllText(fileName, "")
        Catch ex As Exception
            MessageBox.Show("Unable to clear file: " & ex.Message)
        End Try
    End Sub

End Class
