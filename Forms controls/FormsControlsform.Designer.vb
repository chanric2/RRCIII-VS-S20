﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.UserSelectionGroupBox = New System.Windows.Forms.GroupBox()
        Me.UserPicture = New System.Windows.Forms.PictureBox()
        Me.UserInputGroupBox.SuspendLayout()
        CType(Me.UserPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(280, 338)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(120, 85)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "EXIT"
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
        Me.UserInputGroupBox.Controls.Add(Me.TextBox3)
        Me.UserInputGroupBox.Controls.Add(Me.TextBox2)
        Me.UserInputGroupBox.Controls.Add(Me.TextBox1)
        Me.UserInputGroupBox.Location = New System.Drawing.Point(28, 36)
        Me.UserInputGroupBox.Name = "UserInputGroupBox"
        Me.UserInputGroupBox.Size = New System.Drawing.Size(200, 222)
        Me.UserInputGroupBox.TabIndex = 3
        Me.UserInputGroupBox.TabStop = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(27, 76)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(27, 48)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(27, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
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
        'FormsControlsform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents UserSelectionGroupBox As GroupBox
    Friend WithEvents UserPicture As PictureBox
End Class