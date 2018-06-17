Public Class DVD
    Inherits EntertainmentDevice

    Private isPaused As Boolean = False

    Sub New(name As String, maxSate As Integer, maxVolume As Integer)
        MyBase.New(name, maxSate, maxVolume)
    End Sub


    Public Overrides Sub stateDown()
        If Me.isOnValue Then
            Me.stateValue -= 1
            Console.WriteLine(Me.name & " displaying chapter:" & Me.state)
        Else
            Console.WriteLine("cannot stateDown when " & Me.name & " is turned off!")
        End If
    End Sub

    Public Overrides Sub stateUp()
        If Me.isOnValue Then

            If Me.state + 1 > maxState Then
                Me.stateValue = 0
            Else
                Me.stateValue += 1
            End If
            Console.WriteLine(Me.name & " displaying chapter:" & Me.state)
        Else
            Console.WriteLine("cannot stateUp when " & Me.name & " is turned off!")
        End If
    End Sub

    Public Sub pause()
        If Me.isOnValue Then
            If isPaused Then
                Console.WriteLine(Me.name & " play")
                Me.isPaused = False
            Else
                Console.WriteLine(Me.name & " paused")
                Me.isPaused = True
            End If

        Else
            Console.WriteLine("cannot pause when " & Me.name & " is turned off!")
        End If
    End Sub

    Public Sub play()
        If Me.isOnValue Then
            If Not isPaused Then
                Console.WriteLine(Me.name & " play")
                Me.isPaused = False
            Else
                Console.WriteLine(Me.name & " already playing!")
            End If
        Else
            Console.WriteLine("cannot play when " & Me.name & " is turned off!")
        End If
    End Sub
End Class
