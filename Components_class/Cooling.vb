Imports System.Runtime.Intrinsics.Arm
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar

Public Class Cooling
    Private _Id As String
    Private _Manufacturer As String
    Private _Weight As String
    Private _Type As String
    Private _Soket As String
    Private _For_what As String
    Private _TDP As Integer
    Private _Length As Single
    Private _Width As Single
    Private _Cost As Single
    Public Sub New(Id As String, Manufacturer As String, Weight As String, Type As String,
                   Soket As String, For_what As String, TDP As Integer,
                   Length As Single, Width As Single, Cost As Single)
        _Id = Id
        _Manufacturer = Manufacturer
        _Weight = Weight
        _Type = Type
        _Soket = Soket
        _For_what = For_what
        _TDP = TDP
        _Length = Length
        _Width = Width
        _Cost = Cost
    End Sub
    Public Property Id As String
        Get
            Return _Id
        End Get
        Set(value As String)
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
    Public Property Weight As String
        Get
            Return _Weight
        End Get
        Set(value As String)
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
    Public Property Soket As String
        Get
            Return _Soket
        End Get
        Set(value As String)
            _Soket = value
        End Set
    End Property
    Public Property For_what As String
        Get
            Return _For_what
        End Get
        Set(value As String)
            _For_what = value
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
    Public Property Length As Single
        Get
            Return _Length
        End Get
        Set(value As Single)
            _Length = value
        End Set
    End Property
    Public Property Width As Single
        Get
            Return _Width
        End Get
        Set(value As Single)
            _Width = value
        End Set
    End Property
    Public Property Cost As Single
        Get
            Return _Cost
        End Get
        Set(value As Single)
            _Cost = value
        End Set
    End Property
End Class
