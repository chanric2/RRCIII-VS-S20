<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RollingForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ResListBox = New System.Windows.Forms.ListBox()
        Me.RollButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ResListBox
        '
        Me.ResListBox.FormattingEnabled = True
        Me.ResListBox.Location = New System.Drawing.Point(12, 12)
        Me.ResListBox.Name = "ResListBox"
        Me.ResListBox.Size = New System.Drawing.Size(776, 342)
        Me.ResListBox.TabIndex = 0
        '
        'RollButton
        '
        Me.RollButton.Location = New System.Drawing.Point(12, 360)
        Me.RollButton.Name = "RollButton"
        Me.RollButton.Size = New System.Drawing.Size(190, 78)
        Me.RollButton.TabIndex = 1
        Me.RollButton.Text = "&ROLL"
        Me.RollButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(404, 360)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(190, 78)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "&CLEAR"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(598, 360)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(190, 78)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&XIT"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'RollingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.RollButton)
        Me.Controls.Add(Me.ResListBox)
        Me.Name = "RollingForm"
        Me.Text = "Dice Rolling"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ResListBox As ListBox
    Friend WithEvents RollButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
End Class
