Public MustInherit Class RemoteController

    Protected device As EntertainmentDevice

    Sub New(device As EntertainmentDevice)
        Me.device = device
    End Sub

    Public Sub VolumeDownPressed()
        device.volumeDown()
    End Sub

    Public Sub stateUpPressed()
        device.stateUp()
    End Sub

    Public Sub VolumeUpPressed()
        device.volumeUp()
    End Sub

    Public Sub stateDownPressed()
        device.stateDown()
    End Sub

    Public Sub onPressed()
        device.turnOn()
    End Sub

    Public Sub OffPressed()
        device.turnOff()
    End Sub

End Class
