Public Class GPU

    ' Объявление переменных класса
    Private _Id As Integer
    Private _Manufacturer As String
    Private _Weight As Double ' в кг
    Private _Color As String
    Private _Model As String
    Private _Graphic_unit As String ' Чипсет (например, NVIDIA GeForce RTX 3080)
    Private _Frequency As Integer ' Базовая частота в МГц
    Private _Turbofrequency As Integer ' Турбо частота в МГц
    Private _DLSS As Boolean ' Поддержка DLSS
    Private _V_GPU As Integer ' Объем видеопамяти в ГБ
    Private _Type_of_memory As String ' Тип памяти (например, GDDR6X)
    Private _Type_of_ports As String ' Тип портов (например, HDMI, DisplayPort)
    Private _Kol_ports As Integer ' Количество портов
    Private _Interface As String ' Интерфейс (например, PCIe 4.0)
    Private _Dop_power As String ' Дополнительное питание (например, 8+8 pin)
    Private _Type_of_cooling As String ' Тип охлаждения (воздушное, водяное)
    Private _LED As Boolean ' Наличие LED-подсветки
    Private _Cost As Decimal

    ' Конструктор класса
    Public Sub New(Id As Integer, Manufacturer As String, Weight As Double, Color As String, Model As String, Graphic_unit As String, Frequency As Integer, Turbofrequency As Integer, DLSS As Boolean, V_GPU As Integer, Type_of_memory As String, Type_of_ports As String, Kol_ports As Integer, Interface_q As String, Dop_power As String, Type_of_cooling As String, LED As Boolean, Cost As Decimal)

        _Id = Id
        _Manufacturer = Manufacturer
        _Weight = Weight
        _Color = Color
        _Model = Model
        _Graphic_unit = Graphic_unit
        _Frequency = Frequency
        _Turbofrequency = Turbofrequency
        _DLSS = DLSS
        _V_GPU = V_GPU
        _Type_of_memory = Type_of_memory
        _Type_of_ports = Type_of_ports
        _Kol_ports = Kol_ports
        _Interface = Interface_q
        _Dop_power = Dop_power
        _Type_of_cooling = Type_of_cooling
        _LED = LED
        _Cost = Cost

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

    Public Property Weight As Double
        Get
            Return _Weight
        End Get
        Set(value As Double)
            _Weight = value
        End Set
    End Property

    Public Property Color As String
        Get
            Return _Color
        End Get
        Set(value As String)
            _Color = value
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

    Public Property Graphic_unit As String
        Get
            Return _Graphic_unit
        End Get
        Set(value As String)
            _Graphic_unit = value
        End Set
    End Property

    Public Property Frequency As Integer
        Get
            Return _Frequency
        End Get
        Set(value As Integer)
            _Frequency = value
        End Set
    End Property

    Public Property Turbofrequency As Integer
        Get
            Return _Turbofrequency
        End Get
        Set(value As Integer)
            _Turbofrequency = value
        End Set
    End Property

    Public Property DLSS As Boolean
        Get
            Return _DLSS
        End Get
        Set(value As Boolean)
            _DLSS = value
        End Set
    End Property

    Public Property V_GPU As Integer
        Get
            Return _V_GPU
        End Get
        Set(value As Integer)
            _V_GPU = value
        End Set
    End Property

    Public Property Type_of_memory As String
        Get
            Return _Type_of_memory
        End Get
        Set(value As String)
            _Type_of_memory = value
        End Set
    End Property

    Public Property Type_of_ports As String
        Get
            Return _Type_of_ports
        End Get
        Set(value As String)
            _Type_of_ports = value
        End Set
    End Property

    Public Property Kol_ports As Integer
        Get
            Return _Kol_ports
        End Get
        Set(value As Integer)
            _Kol_ports = value
        End Set
    End Property

    Public Property Interface_q As String
        Get
            Return _Interface
        End Get
        Set(value As String)
            _Interface = value
        End Set
    End Property

    Public Property Dop_power As String
        Get
            Return _Dop_power
        End Get
        Set(value As String)
            _Dop_power = value
        End Set
    End Property

    Public Property Type_of_cooling As String
        Get
            Return _Type_of_cooling
        End Get
        Set(value As String)
            _Type_of_cooling = value
        End Set
    End Property

    Public Property LED As Boolean
        Get
            Return _LED
        End Get
        Set(value As Boolean)
            _LED = value
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

