Public Class frmClocks

    Private isMouseDown As Boolean = False
    Private mouseOffset As Point
    Private isCall As Boolean = False
    Private isLunch As Boolean = False
    Private isBreak As Boolean = False

    ' This integer variable keeps track of the 
    ' remaining time.
    Private timeLeft As Integer
    Dim dtFuture As New DateTime
    Dim tsCount As New TimeSpan

    Private Sub frmClocks_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, Screen.PrimaryScreen.WorkingArea.Height - Me.Height)
    End Sub

    Private Sub BtnBreak_Click(sender As Object, e As EventArgs) Handles btnBreak.Click
        dtFuture = DateTime.Now.AddMinutes(15)
        ' tmrBreak.Start()
        isBreak = True
        btnBreak.Hide()
        btnLunch.Hide()
        btnStop.Show()
    End Sub

    Private Sub btnLunch_Click(sender As Object, e As EventArgs) Handles btnLunch.Click
        dtFuture = DateTime.Now.AddMinutes(30)
        ' tmrLunch.Start()
        isLunch = True
        btnBreak.Hide()
        btnLunch.Hide()
        btnStop.Show()
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        ' tmrLunch.Stop()
        ' tmrBreak.Stop()
        isBreak = False
        isCall = False
        isLunch = False
        ' dtFuture = DateTime.Now
        lblLunch.Text = "30:00"
        lblBreak.Text = "15:00"
        btnBreak.Show()
        btnLunch.Show()
        btnStop.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub tmrClocks_Tick(sender As Object, e As EventArgs) Handles tmrClocks.Tick
        Select Case True

            Case isBreak
                If dtFuture > DateTime.Now Then
                    ' Display the new time left
                    ' by updating the Time Left label.
                    tsCount = dtFuture - DateTime.Now
                    lblBreak.Text = String.Format("{0:D2}:{1:D2}", tsCount.Minutes, tsCount.Seconds)
                Else
                    ' If the user ran out of time, stop the timer, show a MessageBox
                    ' and reset buttons and labels
                    ' tmrBreak.Stop()
                    lblBreak.Text = "00:00"
                    isBreak = False
                    MessageBox.Show("Your Break is OVER.", "Sorry!")
                    btnBreak.Show()
                    btnLunch.Show()
                    btnStop.Hide()
                    lblBreak.Text = "15:00"
                End If

            Case isLunch
                If dtFuture > DateTime.Now Then
                    ' Display the new time left
                    ' by updating the Time Left label.
                    tsCount = dtFuture - DateTime.Now
                    lblLunch.Text = String.Format("{0:D2}:{1:D2}", tsCount.Minutes, tsCount.Seconds)
                Else
                    ' If the user ran out of time, stop the timer, show a MessageBox
                    ' and reset buttons and labels
                    ' tmrLunch.Stop()
                    lblLunch.Text = "00:00"
                    isLunch = False
                    MessageBox.Show("Your Break is OVER.", "Sorry!")
                    btnBreak.Show()
                    btnLunch.Show()
                    btnStop.Hide()
                    lblLunch.Text = "30:00"
                End If
        End Select
        lblClock.Text = DateTime.Now.ToString("hh:mm:ss tt")
        lblClocks24.Text = TimeString

    End Sub

    Private Sub tmrBreak_Tick(sender As Object, e As EventArgs) Handles tmrBreak.Tick

        If dtFuture > DateTime.Now Then
            ' Display the new time left
            ' by updating the Time Left label.
            tsCount = dtFuture - DateTime.Now
            lblBreak.Text = String.Format("{0:D2}:{1:D2}", tsCount.Minutes, tsCount.Seconds)
        Else
            ' If the user ran out of time, stop the timer, show a MessageBox
            ' and reset buttons and labels
            tmrBreak.Stop()
            lblBreak.Text = "00:00"
            MessageBox.Show("Your Break is OVER.", "Sorry!")
            btnBreak.Show()
            btnLunch.Show()
            btnStop.Hide()
            lblBreak.Text = "15:00"
        End If

    End Sub

    Private Sub tmrLunch_Tick(sender As Object, e As EventArgs) Handles tmrLunch.Tick

        If dtFuture > DateTime.Now Then
            ' Display the new time left
            ' by updating the Time Left label.
            tsCount = dtFuture - DateTime.Now
            lblLunch.Text = String.Format("{0:D2}:{1:D2}", tsCount.Minutes, tsCount.Seconds)
        Else
            ' If the user ran out of time, stop the timer, show a MessageBox
            ' and reset buttons and labels
            tmrLunch.Stop()
            lblLunch.Text = "00:00"
            MessageBox.Show("Your Break is OVER.", "Sorry!")
            btnBreak.Show()
            btnLunch.Show()
            btnStop.Hide()
            lblLunch.Text = "30:00"
        End If

    End Sub

    ' Left mouse button pressed
    Private Sub frmClocks_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' Get the new position
            mouseOffset = New Point(-e.X, -e.Y)
            ' Set that left button is pressed
            isMouseDown = True
        End If
    End Sub

    ' MouseMove used to check if mouse cursor is moving
    Private Sub frmClocks_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            ' Get the new form position
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    ' Left mouse button released, form should stop moving
    Private Sub frmClocks_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub
End Class