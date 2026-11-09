Imports System

Module Program
    Public Class Speler
        Protected strNaam As String
        Public Sub New(strnaam As String)
            Me.strNaam = strnaam
        End Sub
        Public Overridable Sub TrapBal()
            Console.WriteLine("De speler trapt de bal.")
        End Sub

        Protected Shared randomGenerator As New Random()
    End Class
    Public Class Verdediger
        Inherits Speler
        Public Sub New(strnaam As String)
            MyBase.New(strnaam)
        End Sub
        Public Overridable Sub TrapBal()
            If randomGenerator.Next(0, 100) < 50 Then
                Console.WriteLine(strNaam & "verliest de bal.")
            Else
                Console.WriteLine(strNaam & "geeft de bal goed af.")
            End If
        End Sub

    End Class

    Public Class Aanvaller
        Inherits Speler

        Public Sub New(strnaam As String)
            MyBase.New(strnaam)
        End Sub
        Public Overridable Sub TrapBal()
            If randomGenerator.Next(0, 100) < 30 Then
                Console.WriteLine(strNaam & "scoort een goal.")
            Else
                Console.WriteLine(strNaam & "maakt geen goal.")
            End If
        End Sub

    End Class

End Module
