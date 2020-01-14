Public Class Erabiltzaile
    Private _id As Integer
    Private _erabiltzaile As String
    Private _pasahitza As String
    Private _emaila As String
    Private _telefonoa As String
    Private _ErabiltzaileMota As String
    Private _IzenAbizenak As String

    'id
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    'erabiltzaile
    Public Property erabiltzaile() As String
        Get
            Return _erabiltzaile
        End Get
        Set(ByVal value As String)
            _erabiltzaile = value
        End Set
    End Property

    'pasahitza
    Public Property pasahitza() As String
        Get
            Return _pasahitza
        End Get
        Set(ByVal value As String)
            _pasahitza = value
        End Set
    End Property
    'emaila
    Public Property emaila() As String
        Get
            Return _emaila
        End Get
        Set(ByVal value As String)
            _emaila = value
        End Set
    End Property
    'telefonoa
    Public Property telefonoa() As String
        Get
            Return _telefonoa
        End Get
        Set(ByVal value As String)
            _telefonoa = value
        End Set
    End Property
    'ErabiltzaileMota
    Public Property ErabiltzaileMota() As String
        Get
            Return _ErabiltzaileMota
        End Get
        Set(ByVal value As String)
            _ErabiltzaileMota = value
        End Set
    End Property
    'IzenAbizenak
    Public Property IzenAbizenak() As String
        Get
            Return _IzenAbizenak
        End Get
        Set(ByVal value As String)
            _IzenAbizenak = value
        End Set
    End Property

End Class
