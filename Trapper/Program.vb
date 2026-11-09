Imports System

Module Program

    Public Sub Main()

        Randomize()
        Dim objMbappe As New Trapper("De Ketelaere", 0.8)
        Dim objMartinez As New Keeper("Kevin De Bruyne", 0.6)
        Dim dblTrapper As Double = objMbappe.DoeStrafschop()
        Dim dblKeeper As Double = objMartinez.DoeStrafschop()
        Console.WriteLine("Trapper: " & objMbappe.strNaam)
        Console.WriteLine("Keeper: " & objMartinez.strNaam)

        If dblKeeper > dblTrapper Then
            Console.WriteLine("Gepakt door keeper.")
        Else
            Console.WriteLine("Binnen getrapt.")
        End If
    End Sub

End Module