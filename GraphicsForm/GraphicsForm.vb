
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

    Sub drawSinWave()
        'vi = Vp * sin((360 * f * t) + theta) + DC
        'vi = Vp * sin(n * theta)
        'where Vp is peak, n is the current x multiple
        ' theta cycle width divided by 360 degrees

        Dim vmax% = 100 ' PictureBox.Height \ 2
        Dim yOffset% = vmax
        Dim theta% = PictureBox.Width \ 360
        Dim lastX%, lastY%, currentY%, currentX%
        Dim angle#

        For n = 0 To 360
            'n = 90
            angle = (Math.PI / 180) * n * theta

            ' currentY = vmax * CInt(Math.Sin((Math.PI\180) * n)) + yOffset
            currentY = CInt(100 * Math.Sin(angle)) + 100
            currentX = n
            DrawLineSegment(lastX, lastY, currentX, currentY)
            lastX = currentX
            lastY = currentY
        Next


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
        currentColor = Color.Black
    End Sub

    Private Sub GraphicsForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        'testDraw()
        'DrawGraph()
        drawSinWave()
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
End Class
