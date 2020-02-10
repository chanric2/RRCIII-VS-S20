<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormsControlsform
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
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.GoButton = New System.Windows.Forms.Button()
        Me.UserInputGroupBox = New System.Windows.Forms.GroupBox()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.StateTextBox3 = New System.Windows.Forms.TextBox()
        Me.AddressTextBox2 = New System.Windows.Forms.TextBox()
        Me.NameTextBox1 = New System.Windows.Forms.TextBox()
        Me.UserSelectionGroupBox = New System.Windows.Forms.GroupBox()
        Me.UserPicture = New System.Windows.Forms.PictureBox()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.UserInputGroupBox.SuspendLayout()
        CType(Me.UserPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(280, 338)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(120, 85)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "E&XIT"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(154, 338)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(120, 85)
        Me.UpdateButton.TabIndex = 1
        Me.UpdateButton.Text = "UPDATE"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'GoButton
        '
        Me.GoButton.Location = New System.Drawing.Point(28, 338)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(120, 85)
        Me.GoButton.TabIndex = 2
        Me.GoButton.Text = "GO"
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'UserInputGroupBox
        '
        Me.UserInputGroupBox.Controls.Add(Me.StateLabel)
        Me.UserInputGroupBox.Controls.Add(Me.AddressLabel)
        Me.UserInputGroupBox.Controls.Add(Me.NameLabel)
        Me.UserInputGroupBox.Controls.Add(Me.StateTextBox3)
        Me.UserInputGroupBox.Controls.Add(Me.AddressTextBox2)
        Me.UserInputGroupBox.Controls.Add(Me.NameTextBox1)
        Me.UserInputGroupBox.Location = New System.Drawing.Point(28, 36)
        Me.UserInputGroupBox.Name = "UserInputGroupBox"
        Me.UserInputGroupBox.Size = New System.Drawing.Size(200, 222)
        Me.UserInputGroupBox.TabIndex = 3
        Me.UserInputGroupBox.TabStop = False
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Location = New System.Drawing.Point(29, 83)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(32, 13)
        Me.StateLabel.TabIndex = 5
        Me.StateLabel.Text = "State"
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Location = New System.Drawing.Point(16, 51)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(45, 13)
        Me.AddressLabel.TabIndex = 4
        Me.AddressLabel.Text = "Address"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(4, 27)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(57, 13)
        Me.NameLabel.TabIndex = 3
        Me.NameLabel.Text = "First Name"
        '
        'StateTextBox3
        '
        Me.StateTextBox3.Location = New System.Drawing.Point(73, 76)
        Me.StateTextBox3.Name = "StateTextBox3"
        Me.StateTextBox3.Size = New System.Drawing.Size(100, 20)
        Me.StateTextBox3.TabIndex = 2
        '
        'AddressTextBox2
        '
        Me.AddressTextBox2.Location = New System.Drawing.Point(73, 48)
        Me.AddressTextBox2.Name = "AddressTextBox2"
        Me.AddressTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.AddressTextBox2.TabIndex = 1
        '
        'NameTextBox1
        '
        Me.NameTextBox1.Location = New System.Drawing.Point(73, 20)
        Me.NameTextBox1.Name = "NameTextBox1"
        Me.NameTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.NameTextBox1.TabIndex = 0
        '
        'UserSelectionGroupBox
        '
        Me.UserSelectionGroupBox.Location = New System.Drawing.Point(257, 36)
        Me.UserSelectionGroupBox.Name = "UserSelectionGroupBox"
        Me.UserSelectionGroupBox.Size = New System.Drawing.Size(200, 222)
        Me.UserSelectionGroupBox.TabIndex = 4
        Me.UserSelectionGroupBox.TabStop = False
        '
        'UserPicture
        '
        Me.UserPicture.Location = New System.Drawing.Point(478, 36)
        Me.UserPicture.Name = "UserPicture"
        Me.UserPicture.Size = New System.Drawing.Size(163, 222)
        Me.UserPicture.TabIndex = 5
        Me.UserPicture.TabStop = False
        '
        'DisplayLabel
        '
        Me.DisplayLabel.Location = New System.Drawing.Point(478, 270)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(163, 171)
        Me.DisplayLabel.TabIndex = 6
        '
        'FormsControlsform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DisplayLabel)
        Me.Controls.Add(Me.UserPicture)
        Me.Controls.Add(Me.UserSelectionGroupBox)
        Me.Controls.Add(Me.UserInputGroupBox)
        Me.Controls.Add(Me.GoButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Name = "FormsControlsform"
        Me.Text = "User Control Interface"
        Me.UserInputGroupBox.ResumeLayout(False)
        Me.UserInputGroupBox.PerformLayout()
        CType(Me.UserPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents GoButton As Button
    Friend WithEvents UserInputGroupBox As GroupBox
    Friend WithEvents StateTextBox3 As TextBox
    Friend WithEvents AddressTextBox2 As TextBox
    Friend WithEvents NameTextBox1 As TextBox
    Friend WithEvents UserSelectionGroupBox As GroupBox
    Friend WithEvents UserPicture As PictureBox
    Friend WithEvents StateLabel As Label
    Friend WithEvents AddressLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents DisplayLabel As Label
End Class
