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
        Me.SuspendLayout()
        '
        'ColorButton
        '
        Me.ColorButton.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorButton.Location = New System.Drawing.Point(12, 365)
        Me.ColorButton.Name = "ColorButton"
        Me.ColorButton.Size = New System.Drawing.Size(235, 73)
        Me.ColorButton.TabIndex = 0
        Me.ColorButton.Text = "Color"
        Me.ColorButton.UseVisualStyleBackColor = True
        '
        'EraseButton
        '
        Me.EraseButton.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EraseButton.Location = New System.Drawing.Point(553, 365)
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
        'GraphicForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.EraseButton)
        Me.Controls.Add(Me.ColorButton)
        Me.Name = "GraphicForm"
        Me.Text = "Richard's Sketchy Etch-and-Sketch"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ColorButton As Button
    Friend WithEvents EraseButton As Button
    Friend WithEvents ColorChooser As ColorDialog
End Class
