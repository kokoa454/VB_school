Imports System.Runtime.InteropServices.JavaScript.JSType
Imports NAudio.Wave

Public Class Form_win
    Private waveOut As WaveOutEvent
    Private mp3Reader As Mp3FileReader
    Private stopMusic As Boolean = False 'the flag to stop the music

    Private Sub Button_OK_Click(sender As Object, e As EventArgs) Handles Button_OK.Click
        stopMusic = True    'Set the flag to stop music
        waveOut.Stop()

        Application.Exit()
    End Sub

    Private Sub Form_win_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Controls.Add(Label1)
        PictureBox1.Controls.Add(Label2)
        PictureBox1.Controls.Add(Label3)
        PictureBox1.Controls.Add(Label4)
        PictureBox1.Controls.Add(Label5)
        PictureBox1.Controls.Add(Label6)
        PictureBox1.Controls.Add(Label7)
        PictureBox1.Controls.Add(Label8)
        PictureBox1.Controls.Add(Label9)
        PictureBox1.Controls.Add(Label10)

        'NAudio setting to play Ура.mp3
        playMusic("..\..\..\music\Ура.mp3")
    End Sub

    Private Sub playMusic(filePath As String)
        mp3Reader = New Mp3FileReader(filePath)
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

    Private Sub PlayNextMusic()
        'play Интернационал.mp3
        playMusic("..\..\..\music\Интернационал.mp3")
    End Sub

    Private Sub OnPlaybackStopped(sender As Object, e As StoppedEventArgs)
        'check if waveOut and mp3Reader are still valid
        If mp3Reader IsNot Nothing AndAlso waveOut IsNot Nothing AndAlso Not stopMusic Then
            mp3Reader.Position = 0  'reset the position to the beginning of the file
            PlayNextMusic()  'start playing next music
        End If
    End Sub
End Class