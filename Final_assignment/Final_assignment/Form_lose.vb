Imports NAudio.Wave

Public Class Form_lose
    Private waveOut As WaveOutEvent
    Private mp3Reader As Mp3FileReader
    Private stopMusic As Boolean = False 'the flag to stop the music

    Private Sub Button_OK_Click(sender As Object, e As EventArgs) Handles Button_OK.Click
        stopMusic = True
        waveOut.Stop()

        Application.Exit()
    End Sub

    Private Sub Form_lose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Controls.Add(Label1)
        PictureBox1.Controls.Add(Label2)
        PictureBox1.Controls.Add(Label3)
        PictureBox1.Controls.Add(Label4)

        'NAudio setting to play Перемен.mp3
        mp3Reader = New Mp3FileReader("..\..\..\music\Перемен.mp3")
        waveOut = New WaveOutEvent()
        AddHandler waveOut.PlaybackStopped, AddressOf OnPlaybackStopped
        waveOut.Init(mp3Reader)
        waveOut.Volume = 0.1
        waveOut.Play()
    End Sub
    Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
        'remove event handler before stopping and disposing
        RemoveHandler waveOut.PlaybackStopped, AddressOf OnPlaybackStopped
        waveOut.Stop()
        mp3Reader.Dispose()
        waveOut.Dispose()
        MyBase.OnFormClosing(e)
    End Sub

    Private Sub OnPlaybackStopped(sender As Object, e As StoppedEventArgs)
        'check if waveOut and mp3Reader are still valid
        If mp3Reader IsNot Nothing AndAlso waveOut IsNot Nothing AndAlso Not stopMusic Then
            mp3Reader.Position = 0  'Reset the position to the beginning of the file
            waveOut.Play()  'Start playing again
        End If
    End Sub
End Class