
Option Strict On
Option Explicit On


Public Class GraphicsForm
    Dim currentColor As Color
    Sub testDraw()
        Dim g As Graphics = Me.CreateGraphics
        Dim myPen As Pen = New Pen(Me.currentColor)

        g.DrawLine(myPen, 0, 0, 500, 100)
        myPen.Color = Color.Green
        myPen.Width = 10
        g.DrawEllipse(myPen, 200, 200, 400, 400)
        'g.FillEllipse(mybrush, 300, 300, 350, 350)



        g.Dispose()
        myPen.Dispose()
    End Sub
    Sub DrawLineSegment(x1%, y1%, x2%, y2%)
        Dim g As Graphics = PictureBox.CreateGraphics
        Dim myPen = New Pen(Me.currentColor)

        g.DrawLine(myPen, x1, y1, x2, y2)

        myPen.Dispose()
        g.Dispose()
    End Sub



    Sub UpdateColor()
        ColorDialog.ShowDialog()
        Me.currentColor = ColorDialog.Color
    End Sub
    Sub Clear()
        PictureBox.Refresh()
        shake()
        'PictureBox.BackColor = Color.White
    End Sub

    Sub DrawGraph()
        Dim oldColor As Color = Me.currentColor
        Me.currentColor = Color.DarkSlateGray
        Dim bottomEdge As Integer = PictureBox.Height
        Dim rightEdge As Integer = PictureBox.Width
        Dim hSpace As Integer = PictureBox.Width \ 10
        Dim vspace As Integer = PictureBox.Height \ 8

        For i = hSpace To PictureBox.Width Step hSpace

            DrawLineSegment(i, 0, i, bottomEdge)
        Next
        For i = vspace To PictureBox.Height Step vspace

            DrawLineSegment(0, i, rightEdge, i)
        Next
        Me.currentColor = oldColor
    End Sub

    Sub drawSinWave()
        Dim oldColor As Color = Me.currentColor
        Me.currentColor = Color.Red
        'vi = Vp * sin((360 * f * t) + theta) + DC
        'vi = Vp * sin(n * theta)
        'where Vp is peak, n is the current x multiple
        'theta cycle width divided by 360 degrees

        Dim vmax# = ((PictureBox.Height - 5) \ 2) 'absolute distance from zero
        Dim yOffset# = vmax  'push the wave down to center
        Dim lastX% = -1, lastY% = CInt(yOffset), currentY%, currentX%
        Dim angle#

        'plot one cycle that spans the entire picture box
        For x = 0 To CInt(PictureBox.Width) Step PictureBox.Width / 360
            angle = (Math.PI / 180) * x 'degrees to radians
            'surround the entire expression with the integer conversion
            'losing too much precision converting the small value terms
            currentY = CInt(-1 * vmax * Math.Sin(angle) + yOffset)
            currentX = CInt(x * PictureBox.Width / 360)
            DrawLineSegment(lastX, lastY, currentX, currentY)
            'current end point becomes next start point
            lastX = currentX
            lastY = currentY
        Next
        Me.currentColor = oldColor
    End Sub
    Sub drawCosWave()
        Dim oldColor As Color = Me.currentColor
        Me.currentColor = Color.Blue
        'vi = Vp * sin((360 * f * t) + theta) + DC
        'vi = Vp * sin(n * theta)
        'where Vp is peak, n is the current x multiple
        'theta cycle width divided by 360 degrees

        Dim vmax# = ((PictureBox.Height - 5) \ 2) 'absolute distance from zero
        Dim yOffset# = vmax  'push the wave down to center
        Dim lastX% = -1, lastY% = CInt(yOffset), currentY%, currentX%
        Dim angle#

        'plot one cycle that spans the entire picture box
        For x = 0 To CInt(PictureBox.Width) Step PictureBox.Width / 360
            angle = (Math.PI / 180) * x 'degrees to radians
            'surround the entire expression with the integer conversion
            'losing too much precision converting the small value terms
            currentY = CInt(-1 * vmax * Math.Cos(angle) + yOffset)
            currentX = CInt(x * PictureBox.Width / 360)
            DrawLineSegment(lastX, lastY, currentX, currentY)
            'current end point becomes next start point
            lastX = currentX
            lastY = currentY
        Next
        Me.currentColor = oldColor
    End Sub
    Sub drawTanWave()
        Dim oldColor As Color = Me.currentColor
        Me.currentColor = Color.Green
        'vi = Vp * sin((360 * f * t) + theta) + DC
        'vi = Vp * sin(n * theta)
        'where Vp is peak, n is the current x multiple
        'theta cycle width divided by 360 degrees

        Dim vmax# = ((PictureBox.Height - 5) \ 2) 'absolute distance from zero
        Dim yOffset# = vmax  'push the wave down to center
        Dim lastX% = -1, lastY% = CInt(yOffset), currentY%, currentX%
        Dim angle#

        'plot one cycle that spans the entire picture box
        For x = 0 To CInt(PictureBox.Width) Step PictureBox.Width / 360
            angle = (Math.PI / 180) * x 'degrees to radians
            'surround the entire expression with the integer conversion
            'losing too much precision converting the small value terms
            currentY = CInt(-1 * vmax * Math.Tan(angle) + yOffset)
            currentX = CInt(x * PictureBox.Width / 360)
            DrawLineSegment(lastX, lastY, currentX, currentY)
            'current end point becomes next start point
            lastX = currentX
            lastY = currentY
        Next
        Me.currentColor = oldColor
    End Sub
    Sub shake()
        'Me.Top
        'Me.Left
        Dim offset As Integer = 50

        'https://freesound.org/
        Try
            My.Computer.Audio.Play(My.Resources.shaker, AudioPlayMode.Background)
        Catch ex As Exception
        End Try

        For i = 1 To 20
            'offset *= -1
            offset = offset * -1
            Me.Top += offset
            Me.Left += offset
            System.Threading.Thread.Sleep(100)
        Next

    End Sub
    ' event handlers

    Private Sub GraphicsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        currentColor = Color.White
    End Sub

    Private Sub GraphicsForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        'testDraw()
        DrawGraph()
        drawSinWave()
        drawCosWave()
        drawTanWave()

    End Sub

    Private Sub PictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox.MouseMove, PictureBox.MouseDown
        Static lastX%, lastY%
        Select Case e.Button.ToString
            Case "Left"
                DrawLineSegment(lastX, lastY, e.X, e.Y)
            Case "Middle"
                UpdateColor()
        End Select
        Me.Text = $"({e.X},{e.Y}) button: {e.Button.ToString} Color: {Me.currentColor.ToString}"
        lastX = e.X
        lastY = e.Y
    End Sub

    Private Sub ChooseColorContextMenuItem_Click(sender As Object, e As EventArgs) Handles ChooseColorContextMenuItem.Click
        UpdateColor()
    End Sub

    Private Sub ClearConextMenuItem_Click(sender As Object, e As EventArgs) Handles ClearConextMenuItem.Click
        Clear()
    End Sub

    Private Sub PictureBox_SizeChanged(sender As Object, e As EventArgs) Handles PictureBox.SizeChanged
        PictureBox.Refresh()
    End Sub
End Class
