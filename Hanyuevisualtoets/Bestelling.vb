Imports System

Public Class Bestelling
    'hier bevat klantnaam en totaalbedrag'
    Protected KlantNaam As String
    Protected TotaalBedrag As Double
    Public Sub New(klantNaam As String, totaalBedrag As Double)
        Me.KlantNaam = klantNaam
        Me.TotaalBedrag = totaalBedrag
    End Sub
    'Tis een functie om alle info te tonnen'
    Public Overridable Sub ToonBestelDetails()
        Console.WriteLine("Klantnaam: " & KlantNaam)
        Console.WriteLine("Totaalbedrag: " & TotaalBedrag & "euro")
    End Sub
    Public Overridable Function BerekenVerzendkosten() As Double
        Return 5
    End Function
End Class
Public Class SnelleLevering
    Inherits Bestelling
    Private SpoedToeslag As Double

    Public Sub New(klantNaam As String, totaalBedrag As Double)
        MyBase.New(klantNaam, totaalBedrag)
        SpoedToeslag = 10
    End Sub
    'verzendkosten te berekenen'
    Public Overrides Function BerekenVerzendkosten() As Double
        Return MyBase.BerekenVerzendkosten() + SpoedToeslag
    End Function
End Class
Public Class InternationaleBestelling
    Inherits Bestelling
    Private Land As String
    Public Sub New(klantNaam As String, totaalBedrag As Double, land As String)
        MyBase.New(klantNaam, totaalBedrag)
        Me.Land = land
    End Sub
    'douanekosten te breken'
    Public Function BerekenDouaneKosten() As Double
        Return TotaalBedrag * 0.1
    End Function
    Public Overrides Function BerekenVerzendkosten() As Double
        'eenmalig bedrag'
        Return MyBase.BerekenVerzendkosten() + BerekenDouaneKosten()
    End Function

End Class

