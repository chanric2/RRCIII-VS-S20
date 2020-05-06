Public Class GraphicForm
    Dim graph As Graphics
    Dim penColor As Color = Color.DarkViolet
    Dim mousePen As New Pen(penColor, 4)
    Private Sub GraphicForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        graph = ArtPictureBox.CreateGraphics
    End Sub

    Private Sub GraphicForm_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        'lineMessage()
        'DrawString()
    End Sub

    'Sub lineMessage()
    '    Dim graph As Graphics
    '    graph = Me.CreateGraphics

    '    Dim linePen As New Pen(Color.DarkViolet, 4)
    '    ''Dim x2 As Integer = Me.Width - 50
    '    ''Dim y2 As Integer = Me.Height - 50
    '    ''graph.DrawLine(linePen, 10, 10, x2, 10) 'horizontal line
    '    ''graph.DrawLine(linePen, 10, 10, 10, y2) 'vertical line

    '    ''graph.DrawLine(linePen, 10, y2, x2, y2) 'horizontal line
    '    ''graph.DrawLine(linePen, x2, 10, x2, y2) 'vertical line

    '    'I
    '    graph.DrawLine(linePen, 0, 100, 100, 100) 'horiz
    '    graph.DrawLine(linePen, 50, 100, 50, 400) 'vert
    '    graph.DrawLine(linePen, 0, 400, 100, 400) 'horiz
    '    'L
    '    graph.DrawLine(linePen, 150, 100, 150, 400) 'vert
    '    graph.DrawLine(linePen, 150, 400, 250, 400) 'horiz
    '    'O
    '    graph.DrawEllipse(linePen, New Rectangle(300, 100, 200, 300))
    '    'v
    '    graph.DrawLine(linePen, 550, 100, 600, 400) 'diag
    '    graph.DrawLine(linePen, 600, 400, 650, 100) 'diag
    '    'E
    '    graph.DrawLine(linePen, 700, 100, 700, 400) 'vert
    '    graph.DrawLine(linePen, 700, 100, 800, 100) 'horiz
    '    graph.DrawLine(linePen, 700, 250, 800, 250) 'horiz
    '    graph.DrawLine(linePen, 700, 400, 800, 400) 'horiz
    '    'P
    '    graph.DrawLine(linePen, 850, 130, 850, 400) 'vert
    '    graph.DrawEllipse(linePen, New Rectangle(850, 100, 150, 150))
    '    'A
    '    graph.DrawLine(linePen, 1000, 400, 1050, 100) 'diag
    '    graph.DrawLine(linePen, 1050, 100, 1100, 400) 'diag
    '    graph.DrawLine(linePen, 1025, 250, 1075, 250) 'horiz
    '    'N
    '    graph.DrawLine(linePen, 1150, 100, 1150, 400) 'horiz
    '    graph.DrawLine(linePen, 1150, 100, 1250, 400) 'diag
    '    graph.DrawLine(linePen, 1250, 100, 1250, 400) 'horiz

    '    linePen.Dispose()
    '    graph.Dispose()

    'End Sub
    'Public Sub DrawString()
    '    Dim formGraphics As System.Drawing.Graphics = Me.CreateGraphics()
    '    Dim drawString As String = TextBox1.Text
    '    TextBox1.Text = "I LOVE PAN"
    '    Dim drawFont As New System.Drawing.Font("Times New Roman", 175)
    '    Dim drawBrush As New _
    '       System.Drawing.SolidBrush(System.Drawing.Color.Purple)
    '    Dim x As Single = -55.0
    '    Dim y As Single = 450.0
    '    Dim drawFormat As New System.Drawing.StringFormat
    '    formGraphics.DrawString(drawString, drawFont, drawBrush,
    '        x, y, drawFormat)

    '    drawFont.Dispose()
    '    drawBrush.Dispose()
    '    formGraphics.Dispose()
    'End Sub

    Private Sub GraphicForm_MouseMove(sender As Object, e As MouseEventArgs) Handles ArtPictureBox.MouseMove

        Static startX As Integer
        Static startY As Integer

        If e.Button.ToString <> "None" Then
            graph.DrawLine(mousePen, startX, startY, e.X, e.Y)
        End If

        startX = e.X
        startY = e.Y

        Me.Text = "X: " & e.X & " Y: " & e.Y
    End Sub

    Private Sub ColorButton_Click(sender As Object, e As EventArgs) Handles ColorButton.Click
        ColorChooser.ShowDialog()
        penColor = ColorChooser.Color
        mousePen.Color = penColor

    End Sub

    Private Sub EraseButton_Click(sender As Object, e As EventArgs) Handles EraseButton.Click

        Dim position1 As Integer = Me.Top
        For i = 1 To 3
            For shake = 1 To 10000000
                'move to bottom
                If shake <= 5000000 Then
                    'move to up
                    Me.Top = position1 - 300
                Else
                    Me.Top = position1
                End If
            Next
        Next

        graph.Clear(BackColor)


    End Sub

    Private Sub WaveButton_Click(sender As Object, e As EventArgs) Handles WaveButton.Click
        Dim gratPen As New Pen(Color.Black, 2)

        graph.Clear(BackColor)
        'border
        Dim xWidth As Integer = ArtPictureBox.Width
        Dim yHeight As Integer = ArtPictureBox.Height
        graph.DrawLine(gratPen, 0, 0, xWidth, 0) 'horizontal line
        graph.DrawLine(gratPen, 0, 0, 0, yHeight) 'vertical line

        graph.DrawLine(gratPen, 0, yHeight, xWidth, yHeight) 'horizontal line
        graph.DrawLine(gratPen, xWidth, 0, xWidth, yHeight) 'vertical line

        'graticules vertical
        For x1 = 60 To 540 Step 60
            For y1 = 5 To 400 Step 10
                graph.DrawLine(gratPen, x1, y1, x1, y1 + 5)
            Next
        Next
        'graticules horizontal
        For y2 = 40 To 360 Step 40
            For x2 = 5 To 600 Step 10
                graph.DrawLine(gratPen, x2, y2, x2 + 5, y2)
            Next
        Next

        Dim sinePen As New Pen(Color.DarkCyan, 4)
        Dim cosPen As New Pen(Color.Crimson, 4)
        Dim tanPen As New Pen(Color.LemonChiffon, 4)
        Dim beginX1 As Integer
        Dim beginY1 As Integer = 200
        Dim beginX2 As Integer
        Dim beginY2 As Integer = 160
        Dim beginX3 As Integer
        Dim beginY3 As Integer = 200
        Dim sineX As Integer
        Dim sineY As Integer
        Dim cosX As Integer
        Dim cosY As Integer
        Dim tanX As Integer
        Dim tanY As Integer

        'sin Wave
        For x = 1 To 600 Step 2
            sineX = x
            sineY = 200 - 40 * (Math.Sin((x / 300) * 2 * Math.PI))
            graph.DrawLine(sinePen, beginX1, beginY1, sineX, sineY)
            beginX1 = sineX
            beginY1 = sineY
        Next
        'cos wave
        For y = 1 To 600 Step 2
            cosX = y
            cosY = 200 - 40 * (Math.Cos((y / 300) * 2 * Math.PI))
            graph.DrawLine(cosPen, beginX2, beginY2, cosX, cosY)
            beginX2 = cosX
            beginY2 = cosY
        Next
        'tan wave

        'If tanY <= -1 Then
        '    tanY = -1
        'ElseIf tanY >= 401 Then
        '    tanY = 401
        'End If
        'If tanX = "set x" Then
        '    graph.DrawLine(tanPen, beginX, beginY, tanX, tanY)
        'Else
        '    graph.DrawLine(tanPen, beginX, beginY, tanX, tanY)
        'End If

    End Sub

End Class
