Imports System.Runtime.Intrinsics.Arm

Public Class Trapper
        Public strNaam As String
        Private dblBetrouwbaarheid As Double

        Public Sub New(strnaam As String, dblbetrouwbaarheid As Double)
            Me.strNaam = strnaam
            Me.dblBetrouwbaarheid = dblbetrouwbaarheid
        End Sub

        Public Function DoeStrafschop() As Double
            Dim dblOndergrens As Double = dblBetrouwbaarheid - 0.3
            Dim dblBovengrens As Double = dblBetrouwbaarheid + 0.1
            Dim dblKans As Double = (dblBovengrens - dblOndergrens) * Rnd() + dblOndergrens

            Return dblKans
        End Function

    End Class


