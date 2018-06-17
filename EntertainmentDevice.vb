Public MustInherit Class EntertainmentDevice

    Protected name As String = ""
    Protected maxState As Integer
    Protected maxVolume As Integer

    Protected isOnValue As Boolean = False
    Public ReadOnly Property isOn() As Boolean
        Get
            Return isOnValue
        End Get
    End Property

    Protected volumeLevelValue As Integer = 0
    Public ReadOnly Property volumeLevel() As Integer
        Get
            Return volumeLevelValue
        End Get
    End Property

    Protected stateValue As Integer = 0
    Public ReadOnly Property state() As Integer
        Get
            Return stateValue
        End Get
    End Property

    Sub New(name As String, maxState As Integer, maxVolume As Integer)
        Me.name = name
        Me.maxState = maxState
        Me.maxVolume = maxVolume
    End Sub

    Public Sub turnOff()
        If Not Me.isOnValue Then
            Console.WriteLine(Me.name & " already turned off!")
        Else
            Me.isOnValue = True
            Console.WriteLine(Me.name & " turned off")
        End If
        Me.isOnValue = False
    End Sub

    Public Sub turnOn()
        If Me.isOnValue Then
            Console.WriteLine(Me.name & " already turned on!")
        Else
            Me.isOnValue = True
            Console.WriteLine(Me.name & " turned on")
        End If
    End Sub

    Public Sub volumeDown()
        If Me.isOnValue Then
            If Me.volumeLevel - 1 < 0 Then
                Me.volumeLevelValue = 0
            Else
                Me.volumeLevelValue -= 1
            End If
            Console.WriteLine(Me.name & " volume at level:" & Me.volumeLevel)
        Else
            Console.WriteLine("canot volumeDown when " & Me.name & " is turned off!")
        End If
    End Sub

    Public Sub volumeUp()
        If Me.isOnValue Then

            If Me.volumeLevel + 1 > maxVolume Then
                Me.volumeLevelValue = maxVolume
            Else
                Me.volumeLevelValue += 1
            End If
            Console.WriteLine(Me.name & " volume at level:" & Me.volumeLevel)
        Else
            Console.WriteLine("canot volumeUp when " & Me.name & " is turned off!")
        End If
    End Sub

    MustOverride Sub stateUp()
    MustOverride Sub stateDown()

End Class
