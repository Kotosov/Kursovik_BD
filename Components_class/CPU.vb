Public Class CPU

    ' Объявление переменных класса
    Private _Id As Integer
    Private _Manufacturer As String
    Private _Model As String
    Private _Soket As String
    Private _Sistem_cooling_in As Boolean
    Private _Cores As Integer
    Private _Process_cores As Integer
    Private _Max_kol_potok As Integer
    Private _KESH As Double
    Private _Baze_speed As Double
    Private _Max_speed As Double
    Private _Type_RAM As String
    Private _Max_speed_RAM As Integer
    Private _Max_RAM As Integer
    Private _TDP As Integer
    Private _In_GPU As String
    Private _Control_PCI As String
    Private _Kol_lines As Integer
    Private _Cost As Decimal

    ' Конструктор класса, принимающий все переменные
    Public Sub New(Id As Integer, Manufacturer As String, Model As String, Soket As String, Sistem_cooling_in As Boolean, Cores As Integer, Process_cores As Integer, Max_kol_potok As Integer, KESH As Double, Baze_speed As Double, Max_speed As Double, Type_RAM As String, Max_speed_RAM As Integer, Max_RAM As Integer, TDP As Integer, In_GPU As String, Control_PCI As String, Kol_lines As Integer, Cost As Decimal)

        _Id = Id
        _Manufacturer = Manufacturer
        _Model = Model
        _Soket = Soket
        _Sistem_cooling_in = Sistem_cooling_in
        _Cores = Cores
        _Process_cores = Process_cores
        _Max_kol_potok = Max_kol_potok
        _KESH = KESH
        _Baze_speed = Baze_speed
        _Max_speed = Max_speed
        _Type_RAM = Type_RAM
        _Max_speed_RAM = Max_speed_RAM
        _Max_RAM = Max_RAM
        _TDP = TDP
        _In_GPU = In_GPU
        _Control_PCI = Control_PCI
        _Kol_lines = Kol_lines
        _Cost = Cost

    End Sub
    Public Sub New()

    End Sub
    ' Property для каждой переменной класса
    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property

    Public Property Manufacturer As String
        Get
            Return _Manufacturer
        End Get
        Set(value As String)
            _Manufacturer = value
        End Set
    End Property

    Public Property Model As String
        Get
            Return _Model
        End Get
        Set(value As String)
            _Model = value
        End Set
    End Property

    Public Property Soket As String
        Get
            Return _Soket
        End Get
        Set(value As String)
            _Soket = value
        End Set
    End Property

    Public Property Sistem_cooling_in As Boolean
        Get
            Return _Sistem_cooling_in
        End Get
        Set(value As Boolean)
            _Sistem_cooling_in = value
        End Set
    End Property

    Public Property Cores As Integer
        Get
            Return _Cores
        End Get
        Set(value As Integer)
            _Cores = value
        End Set
    End Property

    Public Property Process_cores As Integer
        Get
            Return _Process_cores
        End Get
        Set(value As Integer)
            _Process_cores = value
        End Set
    End Property

    Public Property Max_kol_potok As Integer
        Get
            Return _Max_kol_potok
        End Get
        Set(value As Integer)
            _Max_kol_potok = value
        End Set
    End Property

    Public Property KESH As Double
        Get
            Return _KESH
        End Get
        Set(value As Double)
            _KESH = value
        End Set
    End Property

    Public Property Baze_speed As Double
        Get
            Return _Baze_speed
        End Get
        Set(value As Double)
            _Baze_speed = value
        End Set
    End Property

    Public Property Max_speed As Double
        Get
            Return _Max_speed
        End Get
        Set(value As Double)
            _Max_speed = value
        End Set
    End Property

    Public Property Type_RAM As String
        Get
            Return _Type_RAM
        End Get
        Set(value As String)
            _Type_RAM = value
        End Set
    End Property

    Public Property Max_speed_RAM As Integer
        Get
            Return _Max_speed_RAM
        End Get
        Set(value As Integer)
            _Max_speed_RAM = value
        End Set
    End Property

    Public Property Max_RAM As Integer
        Get
            Return _Max_RAM
        End Get
        Set(value As Integer)
            _Max_RAM = value
        End Set
    End Property

    Public Property TDP As Integer
        Get
            Return _TDP
        End Get
        Set(value As Integer)
            _TDP = value
        End Set
    End Property

    Public Property In_GPU As String
        Get
            Return _In_GPU
        End Get
        Set(value As String)
            _In_GPU = value
        End Set
    End Property

    Public Property Control_PCI As String
        Get
            Return _Control_PCI
        End Get
        Set(value As String)
            _Control_PCI = value
        End Set
    End Property

    Public Property Kol_lines As Integer
        Get
            Return _Kol_lines
        End Get
        Set(value As Integer)
            _Kol_lines = value
        End Set
    End Property

    Public Property Cost As Decimal
        Get
            Return _Cost
        End Get
        Set(value As Decimal)
            _Cost = value
        End Set
    End Property

End Class
