Public Class Erreserba
    Private _id As Integer
    Private _id_ostatu As Integer
    Private _id_erabiltzaile As Integer
    Private _Erreserba_Data As Date
    Private _Prezio_Guztira As Double
    Private _Hasiera_Data As Date
    Private _Amaiera_Data As Date



    'id
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property
    'id ostatu
    Public Property id_ostatu() As Integer
        Get
            Return _id_ostatu
        End Get
        Set(ByVal value As Integer)
            _id_ostatu = value
        End Set
    End Property
    'id erabiltzaile
    Public Property id_erabiltzaile() As Integer
        Get
            Return _id_erabiltzaile
        End Get
        Set(ByVal value As Integer)
            _id_erabiltzaile = value
        End Set
    End Property
    'Erreserba Data
    Public Property Erreserba_Data() As Date
        Get
            Return _Erreserba_Data
        End Get
        Set(ByVal value As Date)
            _Erreserba_Data = value
        End Set
    End Property
    'Prezio Guztira
    Public Property Prezio_Guztira() As Double
        Get
            Return _Prezio_Guztira
        End Get
        Set(ByVal value As Double)
            _Prezio_Guztira = value
        End Set
    End Property
    'Hasiera Data
    Public Property Hasiera_Data() As Date
        Get
            Return _Hasiera_Data
        End Get
        Set(ByVal value As Date)
            _Hasiera_Data = value
        End Set
    End Property
    'Amaiera Data
    Public Property Amaiera_Data() As Date
        Get
            Return _Amaiera_Data
        End Get
        Set(ByVal value As Date)
            _Amaiera_Data = value
        End Set
    End Property

End Class
