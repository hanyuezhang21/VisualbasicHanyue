Imports System

Module Program
    Public Class Veelhoek
        Public aantalZijden As Integer
        Public Sub New(aantalzijden As Integer)
            Me.aantalZijden = aantalzijden
        End Sub
    End Class
    Public Class Vierkant
        Inherits Veelhoek

        Public Sub New()
            MyBase.New(4)
        End Sub
    End Class

End Module
