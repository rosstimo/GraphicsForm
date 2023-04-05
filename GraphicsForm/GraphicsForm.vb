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

    ' event handlers

    Private Sub GraphicsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        currentColor = Color.Black
    End Sub

    Private Sub GraphicsForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        testDraw()
    End Sub

    Private Sub GraphicsForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, Me.MouseDown
        Select Case e.Button.ToString

            Case "Left"

            Case "Right"

            Case "Middle"
                ColorDialog.ShowDialog()
                Me.currentColor = ColorDialog.Color
        End Select
        Me.Text = $"({e.X},{e.Y}) button: {e.Button.ToString} Color: {Me.currentColor}"


    End Sub
End Class
