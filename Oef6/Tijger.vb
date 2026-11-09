Public Class Tijger
    Inherits Salamander
    Private strHaarkleur As String
    Public Sub New()
        MyBase.New()
        strHaarkleur = "Zwart."
        dblLongCapaciteitInLiter = 2
    End Sub
    Public Function GeefHaarkleur() As String
        Return strHaarkleur
    End Function
End Class
