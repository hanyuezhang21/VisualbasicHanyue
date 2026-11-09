
Module Program
    Public Class Dier
        Protected strKleur As String
        Public Sub New(kleur As String)
            Me.strKleur = kleur
        End Sub
        Public Sub Eet()
            Console.WriteLine("Het dier eet.")
        End Sub
        Public Sub Slaap()
            Console.WriteLine("Het dier slaapt.")
        End Sub
    End Class
    Public Class Hond
        Inherits Dier

        Private strNaam As String
        Private strEigenaar As String
        Public Sub New(strKleur As String, strnaam As String, streigenaar As String)
            MyBase.New(strKleur)
            Me.strNaam = strnaam
            Me.strEigenaar = streigenaar
        End Sub
        Public Sub Blaf()
            Console.WriteLine("De hond blaft.")
        End Sub
        Public Sub GeefEigenaar()
            Console.WriteLine("Eigenaar:" & strEigenaar)
        End Sub
        Public Sub ZetEigenaar(streigenaar As String)
            Me.strEigenaar = streigenaar
        End Sub
        Public Sub PrintInformatie()
            Console.WriteLine("Hond")
            Console.WriteLine("Naam:" & strNaam)
            Console.WriteLine("Kleur:" & strKleur)
            Console.WriteLine("Eigenaar:" & strEigenaar)
        End Sub
    End Class
    Public Class Leeuw
        Inherits Dier

        Private strNaam As String
        Private strJungle As String
        Public Sub New(strkleur As String, strnaam As String, strjungle As String)
            MyBase.New(strkleur)
            Me.strNaam = strnaam
            Me.strJungle = strjungle

        End Sub
        Public Sub Brult()
            Console.WriteLine("De leeuw brult.")
        End Sub
        Public Sub GeefJungle()
            Console.WriteLine("Jungle:" & strJungle)
        End Sub
        Public Sub PrintInformatie()
            Console.WriteLine("Leeuw")
            Console.WriteLine("Naam:" & strNaam)
            Console.WriteLine("Kleur:" & strKleur)
            Console.WriteLine("Jungle:" & strJungle)
        End Sub
    End Class

End Module
