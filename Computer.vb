Imports System.Security.Cryptography

Public Class Computer
    Private _Cooling As Cooling
    Private _CPU As CPU
    Private _Disk As Disk
    Private _Frame As Frame
    Private _GPU As GPU
    Private _Motherboard As Motherboard
    Private _Powerplant As Powerplant
    Private _Ram As RAM
    Public Sub New()

    End Sub
    Public Sub New(Cooling As Cooling, CPU As CPU, Disk As Disk, Frame As Frame, GPU As GPU, Motherboard As Motherboard, Powerplant As Powerplant, Ram As RAM)
        _Cooling = Cooling
        _CPU = CPU
        _Disk = Disk
        _Frame = Frame
        _GPU = GPU
        _Motherboard = Motherboard
        _Powerplant = Powerplant
        _Ram = Ram
    End Sub
    Public Property GPU() As GPU
        Get
            Return _GPU
        End Get
        Set(value As GPU)
            _GPU = value
        End Set
    End Property
    Public Property Motherboard() As Motherboard
        Get
            Return _Motherboard
        End Get
        Set(value As Motherboard)
            _Motherboard = value
        End Set
    End Property
    Public Property Powerplant() As Powerplant
        Get
            Return _Powerplant
        End Get
        Set(value As Powerplant)
            _Powerplant = value
        End Set
    End Property
    Public Property Ram() As RAM
        Get
            Return _Ram
        End Get
        Set(value As RAM)
            _Ram = value
        End Set
    End Property
    Public Property Disk() As Disk
        Get
            Return _Disk
        End Get
        Set(value As Disk)
            _Disk = value
        End Set
    End Property
    Public Property Frame() As Frame
        Get
            Return _Frame
        End Get
        Set(value As Frame)
            _Frame = value
        End Set
    End Property
    Public Property Cooling() As Cooling
        Get
            Return _Cooling
        End Get
        Set(value As Cooling)
            _Cooling = value
        End Set
    End Property
    Public Property CPU() As CPU
        Get
            Return _CPU
        End Get
        Set(value As CPU)
            _CPU = value
        End Set
    End Property
End Class
