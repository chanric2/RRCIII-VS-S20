Public Class GraphicForm
    Private Sub GraphicForm_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        'lineBox()
    End Sub

    Sub lineBox()
        Dim graph As Graphics
        graph = Me.CreateGraphics

        Dim linePen As New Pen(Color.Purple)
        Dim x2 As Integer = Me.Width - 50
        Dim y2 As Integer = Me.Height - 50
        graph.DrawLine(linePen, 10, 10, x2, 10) 'horizontal line
        graph.DrawLine(linePen, 10, 10, 10, y2) 'vertical line

        graph.DrawLine(linePen, 10, y2, x2, y2) 'horizontal line
        graph.DrawLine(linePen, x2, 10, x2, y2) 'vertical line

        linePen.Dispose()
        graph.Dispose()

    End Sub

    Private Sub GraphicForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Dim graph As Graphics
        graph = Me.CreateGraphics

        Static penColor As Color = Color.DarkViolet

        Dim mousePen As New Pen(penColor)
        Static startX As Integer
        Static startY As Integer

        If e.Button.ToString = "Left" Then
            graph.DrawLine(mousePen, startX, startY, e.X, e.Y)
        ElseIf e.Button.ToString = "Right" Then
            graph.Clear(Color.White)
        ElseIf e.Button.ToString = "Middle" Then
            ColorChooser.ShowDialog()
            penColor = ColorChooser.Color
            mousePen.Color = penColor
        End If

        startX = e.X
        startY = e.Y

        mousePen.Dispose()
        graph.Dispose()
    End Sub

End Class
