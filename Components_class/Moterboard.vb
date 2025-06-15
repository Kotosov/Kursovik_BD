Public Class Motherboard

    ' Объявление переменных класса
    Private _Id As Integer
    Private _Manufacturer As String
    Private _Weight As Double ' в кг
    Private _Color As String
    Private _Length As Double ' в см 
    Private _Width As Double
    Private _Soket As String ' Например, LGA 1700, AM5
    Private _Type_RAM As String ' Например, DDR4, DDR5
    Private _Max_V_RAM As Integer ' Максимальный объем ОЗУ в ГБ
    Private _Max_speed_RAM As Integer ' Максимальная частота ОЗУ в МГц
    Private _Kol_slots_RAM As Integer ' Количество слотов ОЗУ
    Private _PCI_version As String ' Версия PCI Express (например, PCIe 4.0, PCIe 5.0)
    Private _Kol_M2 As Integer ' Количество слотов M.2
    Private _USB As Integer 'количество портов USB
    Private _Video_port As String ' Тип и количество видеопортов (например, HDMI x 1, DisplayPort x 1)
    Private _Form_factor As String ' Форм-фактор (например, ATX, Micro-ATX, Mini-ITX)
    Private _Esernet_adapter As String ' Модель Ethernet-адаптера (например, Intel I225-V)
    Private _Esernet_speed As String ' Скорость Ethernet-адаптера в Мбит/с (например, 2500)
    Private _Cost As Decimal

    ' Конструктор класса
    Public Sub New(Id As Integer, Manufacturer As String, Weight As Double, Color As String, Length As Double, Width As Double, Soket As String, Type_RAM As String, Max_V_RAM As Integer, Max_speed_RAM As Integer, Kol_slots_RAM As Integer, PCI_version As String, Kol_M2 As Integer, USB As Integer, Video_port As String, Form_factor As String, Esernet_adapter As String, Esernet_speed As String, Cost As Decimal)

        _Id = Id
        _Manufacturer = Manufacturer
        _Weight = Weight
        _Color = Color
        _Length = Length
        _Width = Width
        _Soket = Soket
        _Type_RAM = Type_RAM
        _Max_V_RAM = Max_V_RAM
        _Max_speed_RAM = Max_speed_RAM
        _Kol_slots_RAM = Kol_slots_RAM
        _PCI_version = PCI_version
        _Kol_M2 = Kol_M2
        _USB = USB
        _Video_port = Video_port
        _Form_factor = Form_factor
        _Esernet_adapter = Esernet_adapter
        _Esernet_speed = Esernet_speed
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

    Public Property Length As Double
        Get
            Return _Length
        End Get
        Set(value As Double)
            _Length = value
        End Set
    End Property

    Public Property Width As Double
        Get
            Return _Width
        End Get
        Set(value As Double)
            _Width = value
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

    Public Property Type_RAM As String
        Get
            Return _Type_RAM
        End Get
        Set(value As String)
            _Type_RAM = value
        End Set
    End Property

    Public Property Max_V_RAM As Integer
        Get
            Return _Max_V_RAM
        End Get
        Set(value As Integer)
            _Max_V_RAM = value
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

    Public Property Kol_slots_RAM As Integer
        Get
            Return _Kol_slots_RAM
        End Get
        Set(value As Integer)
            _Kol_slots_RAM = value
        End Set
    End Property

    Public Property PCI_version As String
        Get
            Return _PCI_version
        End Get
        Set(value As String)
            _PCI_version = value
        End Set
    End Property

    Public Property Kol_M2 As Integer
        Get
            Return _Kol_M2
        End Get
        Set(value As Integer)
            _Kol_M2 = value
        End Set
    End Property

    Public Property USB As Integer
        Get
            Return _USB
        End Get
        Set(value As Integer)
            _USB = value
        End Set
    End Property

    Public Property Video_port As String
        Get
            Return _Video_port
        End Get
        Set(value As String)
            _Video_port = value
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

    Public Property Esernet_adapter As String
        Get
            Return _Esernet_adapter
        End Get
        Set(value As String)
            _Esernet_adapter = value
        End Set
    End Property

    Public Property Esernet_speed As String
        Get
            Return _Esernet_speed
        End Get
        Set(value As String)
            _Esernet_speed = value
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
