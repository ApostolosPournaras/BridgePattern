Public Class SimpleDVDRemote
    Inherits RemoteController

    Sub New(dvd As DVD)
        MyBase.New(dvd)
    End Sub

    Public Sub pause()
        CType(Me.device, DVD).pause()
    End Sub

    Public Sub play()
        CType(Me.device, DVD).play()
    End Sub

End Class
