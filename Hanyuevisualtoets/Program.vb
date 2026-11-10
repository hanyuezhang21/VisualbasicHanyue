Module Program
    Sub main()
        'object maken'
        Dim bestelling1 As Bestelling = New SnelleLevering("Jansen", 100)

        bestelling1.ToonBestelDetails()
        'print'
        Console.WriteLine("Totale verzendkosten zijn: " & bestelling1.BerekenVerzendkosten())

        'object maken'
        Dim bestelling2 As InternationaleBestelling = New InternationaleBestelling("Martinez", 200, "Frankrijk")
        bestelling2.ToonBestelDetails()

        'print'
        Console.WriteLine("Totale verzendkosten zijn: " & bestelling2.BerekenVerzendkosten())

        'object maken'
        Dim verzending1 As Verzending = New PakketVerzending("Pakket", "middelgroot")
        'print'
        Console.WriteLine("Verzendkosten voor pakket met grootte: middelgroot is: " &
                      verzending1.BerekenVerzendKosten() & " euro")
        'object maken'
        Dim verzending2 As Verzending = New Luchtpost("Luchtpost")
        'print'
        Console.WriteLine("Verzendkosten voor luchtpakket zijn: " &
                      verzending2.BerekenVerzendKosten() & " euro")
        'Ik weet niet hoe mag ik goed commentaar shrijven'
    End Sub
End Module
