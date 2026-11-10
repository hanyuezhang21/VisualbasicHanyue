Public Class Verzending
    Protected VerzendType As String
    Public Sub New(verzendtype As String)
        Me.VerzendType = verzendtype
    End Sub
    Public Overridable Function BerekenVerzendKosten() As Double
        Return 3
    End Function

End Class
Public Class PakketVerzending
    Inherits Verzending
    Private Pakketgrootte As String
    Public Sub New(verzendtype As String, pakketgrootte As String)
        MyBase.New(verzendtype)
        Me.Pakketgrootte = pakketgrootte
    End Sub
    'Verzendkosten afhankelijk van `Pakketgrootte`'
    Public Overrides Function BerekenVerzendKosten() As Double
        Select Case Pakketgrootte
            Case "klein"
                Return 3
            Case "middelgroot"
                Return 5
            Case "groot"
                Return 8
        End Select

    End Function

End Class
Public Class Luchtpost
    Inherits Verzending
    Private Luchttarief As Double
    Public Sub New(verzendType As String)
        MyBase.New(verzendType)
        Luchttarief = 15
    End Sub
    'Verzendkosten te breken'
    Public Overrides Function BerekenVerzendKosten() As Double
        Return MyBase.BerekenVerzendKosten() + Luchttarief
    End Function
End Class
