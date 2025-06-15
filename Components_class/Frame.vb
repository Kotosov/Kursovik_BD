Public Class Frame

    ' Объявление переменных класса
    Private _Id As Integer
    Private _Manufacturer As String
    Private _Hight As Double ' в мм
    Private _Width As Double ' в мм
    Private _Length As Double ' в мм
    Private _Weight As Double ' в кг
    Private _Color As String
    Private _Material As String
    Private _Form_factor As String ' ATX, Micro-ATX, Mini-ITX и т.д.
    Private _Max_lenght_of_GPU As Integer ' в мм
    Private _Water_cooling As Boolean
    Private _Cost As Decimal

    ' Конструктор класса
    Public Sub New(Id As Integer, Manufacturer As String, Hight As Double, Width As Double, Length As Double, Weight As Double, Color As String, Material As String, Form_factor As String, Max_lenght_of_GPU As Integer, Water_cooling As Boolean, Cost As Decimal)

        _Id = Id
        _Manufacturer = Manufacturer
        _Hight = Hight
        _Width = Width
        _Length = Length
        _Weight = Weight
        _Color = Color
        _Material = Material
        _Form_factor = Form_factor
        _Max_lenght_of_GPU = Max_lenght_of_GPU
        _Water_cooling = Water_cooling
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

    Public Property Hight As Double
        Get
            Return _Hight
        End Get
        Set(value As Double)
            _Hight = value
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

    Public Property Length As Double
        Get
            Return _Length
        End Get
        Set(value As Double)
            _Length = value
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

    Public Property Material As String
        Get
            Return _Material
        End Get
        Set(value As String)
            _Material = value
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

    Public Property Max_lenght_of_GPU As Integer
        Get
            Return _Max_lenght_of_GPU
        End Get
        Set(value As Integer)
            _Max_lenght_of_GPU = value
        End Set
    End Property

    Public Property Water_cooling As Boolean
        Get
            Return _Water_cooling
        End Get
        Set(value As Boolean)
            _Water_cooling = value
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