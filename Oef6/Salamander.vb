Imports System

Public Class Salamander
    Protected intAantalPoten As Integer
    Protected intStaartLengteInCm As Integer
    Protected dblLongCapaciteitInLiter As Double

    Public Sub New()
        intAantalPoten = 4
        intStaartLengteInCm = 6
        dblLongCapaciteitInLiter = 0.5
    End Sub
    Public Function GeefAantalPoten() As Integer
        Return intAantalPoten
    End Function

    Public Function GeefLongCapaciteit() As Double
        Return dblLongCapaciteitInLiter
    End Function
End Class