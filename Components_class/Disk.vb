Public Class Disk

    ' Объявление переменных класса
    Private _Id As Integer
    Private _Manufacturer As String
    Private _Weight As Double
    Private _Type As String
    Private _V_of_disk As Integer ' Объем диска в ГБ или ТБ
    Private _Interface As String
    Private _Max_speed_read As Integer ' в МБ/с
    Private _Max_speed_write As Integer ' в МБ/с
    Private _Max_V_write As Integer ' ресурс записи в TBW (Терабайт записи)
    Private _Length As Double ' в мм
    Private _Cost As Decimal

    ' Конструктор класса
    Public Sub New(Id As Integer, Manufacturer As String, Weight As Double, Type As String, V_of_disk As Integer, Interface_q As String, Max_speed_read As Integer, Max_speed_write As Integer, Max_V_write As Integer, Length As Double, Cost As Decimal)

        _Id = Id
        _Manufacturer = Manufacturer
        _Weight = Weight
        _Type = Type
        _V_of_disk = V_of_disk
        _Interface = Interface_q
        _Max_speed_read = Max_speed_read
        _Max_speed_write = Max_speed_write
        _Max_V_write = Max_V_write
        _Length = Length
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

    Public Property Type As String
        Get
            Return _Type
        End Get
        Set(value As String)
            _Type = value
        End Set
    End Property

    Public Property V_of_disk As Integer
        Get
            Return _V_of_disk
        End Get
        Set(value As Integer)
            _V_of_disk = value
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

    Public Property Max_speed_read As Integer
        Get
            Return _Max_speed_read
        End Get
        Set(value As Integer)
            _Max_speed_read = value
        End Set
    End Property

    Public Property Max_speed_write As Integer
        Get
            Return _Max_speed_write
        End Get
        Set(value As Integer)
            _Max_speed_write = value
        End Set
    End Property

    Public Property Max_V_write As Integer
        Get
            Return _Max_V_write
        End Get
        Set(value As Integer)
            _Max_V_write = value
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

    Public Property Cost As Decimal
        Get
            Return _Cost
        End Get
        Set(value As Decimal)
            _Cost = value
        End Set
    End Property

End Class
