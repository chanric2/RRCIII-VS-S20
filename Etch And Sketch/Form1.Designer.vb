<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GraphicForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ColorButton = New System.Windows.Forms.Button()
        Me.EraseButton = New System.Windows.Forms.Button()
        Me.ColorChooser = New System.Windows.Forms.ColorDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ArtPictureBox = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.WaveButton = New System.Windows.Forms.Button()
        CType(Me.ArtPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColorButton
        '
        Me.ColorButton.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorButton.Location = New System.Drawing.Point(12, 12)
        Me.ColorButton.Name = "ColorButton"
        Me.ColorButton.Size = New System.Drawing.Size(235, 73)
        Me.ColorButton.TabIndex = 0
        Me.ColorButton.Text = "Color"
        Me.ColorButton.UseVisualStyleBackColor = True
        '
        'EraseButton
        '
        Me.EraseButton.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EraseButton.Location = New System.Drawing.Point(253, 12)
        Me.EraseButton.Name = "EraseButton"
        Me.EraseButton.Size = New System.Drawing.Size(235, 73)
        Me.EraseButton.TabIndex = 1
        Me.EraseButton.Text = "Erase"
        Me.EraseButton.UseVisualStyleBackColor = True
        '
        'ColorChooser
        '
        Me.ColorChooser.AnyColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(735, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'ArtPictureBox
        '
        Me.ArtPictureBox.Location = New System.Drawing.Point(6, 19)
        Me.ArtPictureBox.Name = "ArtPictureBox"
        Me.ArtPictureBox.Size = New System.Drawing.Size(600, 400)
        Me.ArtPictureBox.TabIndex = 3
        Me.ArtPictureBox.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ArtPictureBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(615, 426)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'WaveButton
        '
        Me.WaveButton.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WaveButton.Location = New System.Drawing.Point(494, 12)
        Me.WaveButton.Name = "WaveButton"
        Me.WaveButton.Size = New System.Drawing.Size(235, 73)
        Me.WaveButton.TabIndex = 5
        Me.WaveButton.Text = "Trig Waves"
        Me.WaveButton.UseVisualStyleBackColor = True
        '
        'GraphicForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1283, 603)
        Me.Controls.Add(Me.WaveButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.EraseButton)
        Me.Controls.Add(Me.ColorButton)
        Me.Name = "GraphicForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Richard's Sketchy Etch-and-Sketch"
        CType(Me.ArtPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ColorButton As Button
    Friend WithEvents EraseButton As Button
    Friend WithEvents ColorChooser As ColorDialog
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ArtPictureBox As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents WaveButton As Button
End Class
