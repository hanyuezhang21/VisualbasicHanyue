Public Class Keeper
    Public strNaam As String
    Private dblBetrouwbaarheid As Double
    Public Sub New(strNaam As String, dblBetrouwbaarheid As Double)
        Me.strNaam = strNaam
        Me.dblBetrouwbaarheid = dblBetrouwbaarheid
    End Sub
    Public Function DoeStrafschop() As Double
        Dim dblOndergrens As Double = dblBetrouwbaarheid - 0.1
        Dim dblBovengrens As Double = dblBetrouwbaarheid + 0.2
        Dim dblKans As Double = (dblBovengrens - dblOndergrens) * Rnd() + dblOndergrens

        Return dblKans
    End Function

End Class