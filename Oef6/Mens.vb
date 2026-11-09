Public Class Mens
    Inherits Salamander
    Private intAantalBenen As Integer
    Private intAantalArmen As Integer
    Private strHaarkleur As String
    Public Sub New(strhaarkleur As String)
        MyBase.New()

        intAantalPoten = 0
        intStaartLengteInCm = 0
        dblLongCapaciteitInLiter = 7
        intAantalBenen = 2
        intAantalArmen = 2
        Me.strHaarkleur = strhaarkleur
    End Sub
    Public Function GeefHaarkleur() As String
        Return strHaarkleur
    End Function
    Public Function GeefAantalArmenEnBenen() As String
        Return intAantalArmen & "armen en" & intAantalBenen & "benen"
    End Function
End Class
