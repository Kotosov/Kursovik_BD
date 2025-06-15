Public Class Powerplant

    ' Объявление переменных класса
    Private _Id As Integer
    Private _Manufacturer As String
    Private _Weight As Double ' Вес в кг
    Private _Color As String
    Private _Сapacity As Integer ' Мощность в Ваттах
    Private _Form_factor As String ' Форм-фактор (ATX, SFX и т.д.)
    Private _Power_CPU As String ' Тип и количество разъемов питания CPU (например, 4+4 pin)
    Private _Power_GPU As String ' Тип и количество разъемов питания GPU (например, 6+2 pin x 2)
    Private _15_pin_SATA As String ' Количество 15-pin SATA разъемов
    Private _4_pin_Molex As String ' Количество 4-pin Molex разъемов
    Private _Cooling_system As String ' Тип системы охлаждения (активная, пассивная, гибридная)
    Private _Sertif As String ' Сертификация 80 PLUS (например, 80 PLUS Bronze, 80 PLUS Gold)
    Private _Cost As Decimal

    ' Конструктор класса
    Public Sub New(Id As Integer, Manufacturer As String, Weight As Double, Color As String, Сapacity As Integer, Form_factor As String, Power_CPU As String, Power_GPU As String, l_15_pin_SATA As String, l_4_pin_Molex As String, Cooling_system As String, Sertif As String, Cost As Decimal)

        _Id = Id
        _Manufacturer = Manufacturer
        _Weight = Weight
        _Color = Color
        _Сapacity = Сapacity
        _Form_factor = Form_factor
        _Power_CPU = Power_CPU
        _Power_GPU = Power_GPU
        _15_pin_SATA = l_15_pin_SATA
        _4_pin_Molex = l_4_pin_Molex
        _Cooling_system = Cooling_system
        _Sertif = Sertif
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

    Public Property Сapacity As Integer
        Get
            Return _Сapacity
        End Get
        Set(value As Integer)
            _Сapacity = value
        End Set
    End Property

    Public Property Form_factor As String
        Get
            Return _Form_factor
        End Get
        Set(value As String)
            _Form_factor = value
        End Set
    End Property

    Public Property Power_CPU As String
        Get
            Return _Power_CPU
        End Get
        Set(value As String)
            _Power_CPU = value
        End Set
    End Property

    Public Property Power_GPU As String
        Get
            Return _Power_GPU
        End Get
        Set(value As String)
            _Power_GPU = value
        End Set
    End Property

    Public Property l_15_pin_SATA As String
        Get
            Return _15_pin_SATA
        End Get
        Set(value As String)
            _15_pin_SATA = value
        End Set
    End Property

    Public Property l_4_pin_Molex As String
        Get
            Return _4_pin_Molex
        End Get
        Set(value As String)
            _4_pin_Molex = value
        End Set
    End Property

    Public Property Cooling_system As String
        Get
            Return _Cooling_system
        End Get
        Set(value As String)
            _Cooling_system = value
        End Set
    End Property

    Public Property Sertif As String
        Get
            Return _Sertif
        End Get
        Set(value As String)
            _Sertif = value
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