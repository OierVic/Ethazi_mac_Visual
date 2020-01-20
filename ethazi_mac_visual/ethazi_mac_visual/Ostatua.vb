Public Class Ostatua
    Private _id As Integer
    Private _izena As String
    Private _deskribapena As String
    Private _OstatuMota As String
    Private _LogelaKop As Integer
    Private _Kokapena As String
    Private _Telefonoa As String
    Private _Email As String
    Private _Latitudea As String
    Private _Longitudea As String
    Private _Prezioa As String


    'id
    Public Property id() As Integer
            Get
                Return _id
            End Get
            Set(ByVal value As Integer)
                _id = value
            End Set
        End Property

    'izena
    Public Property izena() As String
        Get
            Return _izena
        End Get
        Set(ByVal value As String)
            _izena = value
        End Set
    End Property

    'deskribapena
    Public Property deskribapena() As String
        Get
            Return _deskribapena
        End Get
        Set(ByVal value As String)
            _deskribapena = value
        End Set
    End Property
    'OstatuMota
    Public Property OstatuMota() As String
        Get
            Return _OstatuMota
        End Get
        Set(ByVal value As String)
            _OstatuMota = value
        End Set
    End Property
    'LogelaKop
    Public Property LogelaKop() As Integer
        Get
            Return _LogelaKop
        End Get
        Set(ByVal value As Integer)
            _LogelaKop = value
        End Set
    End Property
    'Kokapena
    Public Property Kokapena() As String
        Get
            Return _Kokapena
        End Get
        Set(ByVal value As String)
            _Kokapena = value
        End Set
    End Property
    'Telefonoa
    Public Property Telefonoa() As String
        Get
            Return _Telefonoa
        End Get
        Set(ByVal value As String)
            _Telefonoa = value
        End Set
    End Property

    'Email
    Public Property Email() As String
        Get
            Return _Email
        End Get
        Set(ByVal value As String)
            _Email = value
        End Set
    End Property
    'Latitudea
    Public Property Latitudea() As String
        Get
            Return _Latitudea
        End Get
        Set(ByVal value As String)
            _Latitudea = value
        End Set
    End Property
    'Longitudea
    Public Property Longitudea() As String
        Get
            Return _Longitudea
        End Get
        Set(ByVal value As String)
            _Longitudea = value
        End Set
    End Property
    'Prezioa
    Public Property Prezioa() As String
        Get
            Return _Prezioa
        End Get
        Set(ByVal value As String)
            _Prezioa = value
        End Set
    End Property

End Class
