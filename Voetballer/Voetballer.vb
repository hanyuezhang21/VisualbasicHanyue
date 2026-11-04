Module Voetballer
    Public Class Voetballer
        Private naam As String
        Private leeftijd As Integer
        Private aantalGeleKaarten As Integer
        Public Sub New(naam As String, leeftijd As Integer)
            Me.naam = naam
            Me.leeftijd = leeftijd
            aantalGeleKaarten = 0
        End Sub
        Public Function NaarKleedkamer() As String
            If aantalGeleKaarten > 1 Then
                Return "KLEEDKAMER"
            Else
                Return "SPELEN"
            End If
        End Function
        Public Sub GeefKaart()
            If aantalGeleKaarten < 2 Then
                aantalGeleKaarten = aantalGeleKaarten + 1
            End If
        End Sub

    End Class
    Sub Main(args As String())
        Dim speler As New Voetballer("Kevin", 27)
        Console.WriteLine("Moet ik naar de kleedkamer: " & speler.NaarKleedkamer())
        Console.WriteLine("Ik geef een kaart")
        speler.GeefKaart()
        Console.WriteLine("Ik geef nog een kaart")
        speler.GeefKaart()
        Console.WriteLine("Moet ik naar de kleedkamer: " & speler.NaarKleedkamer())
    End Sub
End Module
