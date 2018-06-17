Public Class Television
    Inherits EntertainmentDevice

    Private aspectRatio As String = "4:3"

    Sub New(name As String, maxSate As Integer, maxVolume As Integer)
        MyBase.New(name, maxSate, maxVolume)
    End Sub

    Public Overrides Sub stateDown()
        If Me.isOnValue Then

            If Me.state - 1 < 0 Then
                Me.stateValue = Me.maxState
            Else
                Me.stateValue -= 1
            End If
            Console.WriteLine(Me.name & " displaying channel:" & Me.state)
        Else
            Console.WriteLine("canot channelDown when " & Me.name & " is turned off!")
        End If
    End Sub

    Public Overrides Sub stateUp()
        If Me.isOnValue Then

            If Me.state + 1 > maxState Then
                Me.stateValue = 0
            Else
                Me.stateValue += 1
            End If
            Console.WriteLine(Me.name & " displaying channel:" & Me.state)
        Else
            Console.WriteLine("canot channelUp when " & Me.name & " is turned off!")
        End If
    End Sub

    Public Sub changeAspectRatio()
        If Me.isOnValue Then

            If Me.aspectRatio = "4:3" Then
                Me.aspectRatio = "16:9"
            Else
                Me.aspectRatio = "4:3"
            End If
            Console.WriteLine(Me.name & " displaying in " & Me.aspectRatio)
        Else
            Console.WriteLine("canot change aspect ratio when " & Me.name & " is turned off!")
        End If
    End Sub
End Class
