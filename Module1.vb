Module Module1

    Sub Main()

        Dim TV As New Television("Samsung TV", 20, 100)
        Dim DVD As New DVD("Sony DVD", 10, 100)

        Dim simpleTVRemote As New SimpleTVRemote(TV)
        Dim complecatedTVRemote As New ComplecatedTVRemote(TV)
        Dim simpleDVDRemote As New SimpleDVDRemote(DVD)

        simpleTVRemote.onPressed()
        simpleTVRemote.stateUpPressed()
        simpleTVRemote.stateUpPressed()
        simpleTVRemote.stateDownPressed()
        simpleTVRemote.stateUpPressed()
        simpleTVRemote.stateUpPressed()
        simpleTVRemote.stateUpPressed()
        simpleTVRemote.stateDownPressed()
        simpleTVRemote.stateDownPressed()
        simpleTVRemote.stateDownPressed()
        simpleTVRemote.stateDownPressed()
        simpleTVRemote.stateDownPressed()
        simpleTVRemote.stateDownPressed()
        simpleTVRemote.stateUpPressed()
        simpleTVRemote.VolumeDownPressed()
        simpleTVRemote.VolumeUpPressed()

        complecatedTVRemote.setChannel(17)
        complecatedTVRemote.setChannel(2)
        complecatedTVRemote.changeAspectRatio()
        complecatedTVRemote.changeAspectRatio()
        complecatedTVRemote.OffPressed()

        Console.WriteLine("-------------")

        simpleDVDRemote.onPressed()
        simpleDVDRemote.onPressed()
        simpleDVDRemote.play()
        simpleDVDRemote.stateUpPressed()
        simpleDVDRemote.stateDownPressed()
        simpleDVDRemote.stateUpPressed()
        simpleDVDRemote.OffPressed()
        simpleDVDRemote.stateDownPressed()
        simpleDVDRemote.onPressed()
        simpleDVDRemote.stateUpPressed()
        simpleDVDRemote.VolumeDownPressed()
        simpleDVDRemote.VolumeUpPressed()
        simpleDVDRemote.pause()
        simpleDVDRemote.OffPressed()

        Do Until (Console.ReadKey.Key = ConsoleKey.Escape)
            System.Threading.Thread.Sleep(1000)
        Loop
    End Sub

End Module
