' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page
    Private timer As DispatcherTimer
    Private CountDown As Integer

    Private Sub btnCountDown_Click(sender As Object, e As RoutedEventArgs) Handles btnCountDown.Click
        CountDown = txtCountDown.Text
        timer = New DispatcherTimer
        timer.Interval = TimeSpan.FromSeconds(1)
        AddHandler timer.Tick, AddressOf timer_Tick
        timer.Start()

    End Sub

    Private Sub timer_Tick(sender As Object, e As Object)
        CountDown -= 1
        lblCountDown.Text = CountDown
        If CountDown <= 0 Then
            MediaTool.Play()
            timer.Stop()
        End If
    End Sub

    Private Sub btnCountDown_Copy_Click(sender As Object, e As RoutedEventArgs) Handles btnCountDown_Copy.Click
        CountDown = 0
        lblCountDown.Text = 0
        timer.Stop()
    End Sub
End Class
