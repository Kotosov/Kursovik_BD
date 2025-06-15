Public Class RAM

    ' Объявление переменных класса
    Private _Id As Integer
    Private _Manufacturer As String
    Private _Color As String
    Private _Type_RAM As String ' Например, DDR4, DDR5
    Private _Sum_RAM As Integer ' Общий объем оперативной памяти в ГБ
    Private _One_RAM As Integer ' Объем одного модуля памяти в ГБ
    Private _Kol_RAM As Integer ' Количество модулей памяти
    Private _Speed_RAM As Integer ' Частота памяти в МГц
    Private _Cooler_RAM As Boolean ' Наличие радиатора/охлаждения
    Private _Cost As Decimal

    ' Конструктор класса
    Public Sub New(Id As Integer, Manufacturer As String, Color As String, Type_RAM As String, Sum_RAM As Integer, One_RAM As Integer, Kol_RAM As Integer, Speed_RAM As Integer, Cooler_RAM As Boolean, Cost As Decimal)

        _Id = Id
        _Manufacturer = Manufacturer
        _Color = Color
        _Type_RAM = Type_RAM
        _Sum_RAM = Sum_RAM
        _One_RAM = One_RAM
        _Kol_RAM = Kol_RAM
        _Speed_RAM = Speed_RAM
        _Cooler_RAM = Cooler_RAM
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

    Public Property Color As String
        Get
            Return _Color
        End Get
        Set(value As String)
            _Color = value
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

    Public Property Sum_RAM As Integer
        Get
            Return _Sum_RAM
        End Get
        Set(value As Integer)
            _Sum_RAM = value
        End Set
    End Property

    Public Property One_RAM As Integer
        Get
            Return _One_RAM
        End Get
        Set(value As Integer)
            _One_RAM = value
        End Set
    End Property

    Public Property Kol_RAM As Integer
        Get
            Return _Kol_RAM
        End Get
        Set(value As Integer)
            _Kol_RAM = value
        End Set
    End Property

    Public Property Speed_RAM As Integer
        Get
            Return _Speed_RAM
        End Get
        Set(value As Integer)
            _Speed_RAM = value
        End Set
    End Property

    Public Property Cooler_RAM As Boolean
        Get
            Return _Cooler_RAM
        End Get
        Set(value As Boolean)
            _Cooler_RAM = value
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
