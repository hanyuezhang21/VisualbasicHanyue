Module Program
    Public Sub Main()
        Dim objTijger As New Tijger()
        Dim objSalamander
        Dim objMens As New Mens("Rood")
        ' De poten
        Console.WriteLine("De Salamander heeft zoveel poten: " & objSalamander.GeefAantalPoten())
        Console.WriteLine("De Tijger heeft zoveel poten: " & objTijger.GeefAantalPoten())
        Console.WriteLine("De Mens heeft zoveel poten: " & objMens.GeefAantalPoten())
        ' Kleur van haar
        Console.WriteLine("De tijger heeft deze kleur van haar: " & objTijger.GeefHaarkleur())
        Console.WriteLine("De mens heeft deze kleur van haar: " & objMens.GeefHaarkleur())
        ' Longcapaciteit
        Console.WriteLine("De Salamander longcapaciteit (in liter): " & objSalamander.GeefLongCapaciteit())
        Console.WriteLine("De Tijger longcapaciteit (in liter): " & objTijger.GeefLongCapaciteit())
        Console.WriteLine("De Mens longcapaciteit (in liter): " & objMens.GeefLongCapaciteit())
        ' Armen en benen
        Console.WriteLine("De mens heeft: " & objMens.GeefAantalArmenEnBenen())
    End Sub

End Module