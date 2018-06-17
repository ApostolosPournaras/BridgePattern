Public Class ComplecatedTVRemote
    Inherits RemoteController

    Sub New(tv As Television)
        MyBase.New(tv)
    End Sub

    Public Sub setChannel(channel As Integer)
        Dim currentChannel = Me.device.state

        If currentChannel < channel Then
            For i = currentChannel + 1 To channel
                Me.device.stateUp()
            Next
        End If

        If currentChannel > channel Then
            For i = channel + 1 To currentChannel
                Me.device.stateDown()
            Next
        End If

    End Sub

    Public Sub changeAspectRatio()
        CType(Me.device, Television).changeAspectRatio()
    End Sub

End Class
