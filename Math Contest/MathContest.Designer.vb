<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathContest
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GradeNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.AgeNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.GradeLabel = New System.Windows.Forms.Label()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.StudentAnswerLabel = New System.Windows.Forms.Label()
        Me.SecondNumberLabel = New System.Windows.Forms.Label()
        Me.FirstNumberLabel = New System.Windows.Forms.Label()
        Me.StudentTextBox = New System.Windows.Forms.TextBox()
        Me.SecondNumberTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNumberTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DivRadioButton = New System.Windows.Forms.RadioButton()
        Me.MultiRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubRadioButton = New System.Windows.Forms.RadioButton()
        Me.AddRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.HelpToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.GradeNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgeNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GradeNumericUpDown)
        Me.GroupBox1.Controls.Add(Me.AgeNumericUpDown)
        Me.GroupBox1.Controls.Add(Me.GradeLabel)
        Me.GroupBox1.Controls.Add(Me.AgeLabel)
        Me.GroupBox1.Controls.Add(Me.NameLabel)
        Me.GroupBox1.Controls.Add(Me.NameTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 88)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Information"
        '
        'GradeNumericUpDown
        '
        Me.GradeNumericUpDown.Location = New System.Drawing.Point(245, 49)
        Me.GradeNumericUpDown.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.GradeNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.GradeNumericUpDown.Name = "GradeNumericUpDown"
        Me.GradeNumericUpDown.Size = New System.Drawing.Size(35, 20)
        Me.GradeNumericUpDown.TabIndex = 7
        Me.HelpToolTip.SetToolTip(Me.GradeNumericUpDown, "Select the grade")
        Me.GradeNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'AgeNumericUpDown
        '
        Me.AgeNumericUpDown.Location = New System.Drawing.Point(193, 48)
        Me.AgeNumericUpDown.Maximum = New Decimal(New Integer() {11, 0, 0, 0})
        Me.AgeNumericUpDown.Minimum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.AgeNumericUpDown.Name = "AgeNumericUpDown"
        Me.AgeNumericUpDown.Size = New System.Drawing.Size(35, 20)
        Me.AgeNumericUpDown.TabIndex = 6
        Me.HelpToolTip.SetToolTip(Me.AgeNumericUpDown, "Select The Age")
        Me.AgeNumericUpDown.Value = New Decimal(New Integer() {7, 0, 0, 0})
        '
        'GradeLabel
        '
        Me.GradeLabel.AutoSize = True
        Me.GradeLabel.Location = New System.Drawing.Point(242, 29)
        Me.GradeLabel.Name = "GradeLabel"
        Me.GradeLabel.Size = New System.Drawing.Size(36, 13)
        Me.GradeLabel.TabIndex = 5
        Me.GradeLabel.Text = "Grade"
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(190, 29)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(26, 13)
        Me.AgeLabel.TabIndex = 4
        Me.AgeLabel.Text = "Age"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(6, 29)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(35, 13)
        Me.NameLabel.TabIndex = 3
        Me.NameLabel.Text = "Name"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(6, 48)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(163, 20)
        Me.NameTextBox.TabIndex = 0
        Me.HelpToolTip.SetToolTip(Me.NameTextBox, "Please Enter Students Name")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.StudentAnswerLabel)
        Me.GroupBox2.Controls.Add(Me.SecondNumberLabel)
        Me.GroupBox2.Controls.Add(Me.FirstNumberLabel)
        Me.GroupBox2.Controls.Add(Me.StudentTextBox)
        Me.GroupBox2.Controls.Add(Me.SecondNumberTextBox)
        Me.GroupBox2.Controls.Add(Me.FirstNumberTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(175, 165)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Current Math Problem"
        '
        'StudentAnswerLabel
        '
        Me.StudentAnswerLabel.AutoSize = True
        Me.StudentAnswerLabel.Location = New System.Drawing.Point(3, 113)
        Me.StudentAnswerLabel.Name = "StudentAnswerLabel"
        Me.StudentAnswerLabel.Size = New System.Drawing.Size(82, 13)
        Me.StudentAnswerLabel.TabIndex = 5
        Me.StudentAnswerLabel.Text = "Student Answer"
        '
        'SecondNumberLabel
        '
        Me.SecondNumberLabel.AutoSize = True
        Me.SecondNumberLabel.Location = New System.Drawing.Point(3, 71)
        Me.SecondNumberLabel.Name = "SecondNumberLabel"
        Me.SecondNumberLabel.Size = New System.Drawing.Size(65, 13)
        Me.SecondNumberLabel.TabIndex = 4
        Me.SecondNumberLabel.Text = "2nd Number"
        '
        'FirstNumberLabel
        '
        Me.FirstNumberLabel.AutoSize = True
        Me.FirstNumberLabel.Location = New System.Drawing.Point(3, 27)
        Me.FirstNumberLabel.Name = "FirstNumberLabel"
        Me.FirstNumberLabel.Size = New System.Drawing.Size(61, 13)
        Me.FirstNumberLabel.TabIndex = 3
        Me.FirstNumberLabel.Text = "1st Number"
        '
        'StudentTextBox
        '
        Me.StudentTextBox.Enabled = False
        Me.StudentTextBox.Location = New System.Drawing.Point(6, 129)
        Me.StudentTextBox.Name = "StudentTextBox"
        Me.StudentTextBox.Size = New System.Drawing.Size(163, 20)
        Me.StudentTextBox.TabIndex = 5
        Me.HelpToolTip.SetToolTip(Me.StudentTextBox, "Student Filled Response")
        '
        'SecondNumberTextBox
        '
        Me.SecondNumberTextBox.Enabled = False
        Me.SecondNumberTextBox.Location = New System.Drawing.Point(6, 87)
        Me.SecondNumberTextBox.Name = "SecondNumberTextBox"
        Me.SecondNumberTextBox.Size = New System.Drawing.Size(163, 20)
        Me.SecondNumberTextBox.TabIndex = 4
        Me.HelpToolTip.SetToolTip(Me.SecondNumberTextBox, "Randomized Number")
        '
        'FirstNumberTextBox
        '
        Me.FirstNumberTextBox.Enabled = False
        Me.FirstNumberTextBox.Location = New System.Drawing.Point(6, 43)
        Me.FirstNumberTextBox.Name = "FirstNumberTextBox"
        Me.FirstNumberTextBox.Size = New System.Drawing.Size(163, 20)
        Me.FirstNumberTextBox.TabIndex = 3
        Me.HelpToolTip.SetToolTip(Me.FirstNumberTextBox, "Randomized Number")
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DivRadioButton)
        Me.GroupBox3.Controls.Add(Me.MultiRadioButton)
        Me.GroupBox3.Controls.Add(Me.SubRadioButton)
        Me.GroupBox3.Controls.Add(Me.AddRadioButton)
        Me.GroupBox3.Location = New System.Drawing.Point(193, 106)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(115, 165)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Math Problem Type"
        '
        'DivRadioButton
        '
        Me.DivRadioButton.AutoSize = True
        Me.DivRadioButton.Enabled = False
        Me.DivRadioButton.Location = New System.Drawing.Point(6, 98)
        Me.DivRadioButton.Name = "DivRadioButton"
        Me.DivRadioButton.Size = New System.Drawing.Size(55, 17)
        Me.DivRadioButton.TabIndex = 9
        Me.DivRadioButton.TabStop = True
        Me.DivRadioButton.Text = "Divide"
        Me.DivRadioButton.UseVisualStyleBackColor = True
        '
        'MultiRadioButton
        '
        Me.MultiRadioButton.AutoSize = True
        Me.MultiRadioButton.Enabled = False
        Me.MultiRadioButton.Location = New System.Drawing.Point(6, 75)
        Me.MultiRadioButton.Name = "MultiRadioButton"
        Me.MultiRadioButton.Size = New System.Drawing.Size(60, 17)
        Me.MultiRadioButton.TabIndex = 8
        Me.MultiRadioButton.TabStop = True
        Me.MultiRadioButton.Text = "Multiply"
        Me.MultiRadioButton.UseVisualStyleBackColor = True
        '
        'SubRadioButton
        '
        Me.SubRadioButton.AutoSize = True
        Me.SubRadioButton.Enabled = False
        Me.SubRadioButton.Location = New System.Drawing.Point(6, 52)
        Me.SubRadioButton.Name = "SubRadioButton"
        Me.SubRadioButton.Size = New System.Drawing.Size(65, 17)
        Me.SubRadioButton.TabIndex = 7
        Me.SubRadioButton.TabStop = True
        Me.SubRadioButton.Text = "Subtract"
        Me.SubRadioButton.UseVisualStyleBackColor = True
        '
        'AddRadioButton
        '
        Me.AddRadioButton.AutoSize = True
        Me.AddRadioButton.Enabled = False
        Me.AddRadioButton.Location = New System.Drawing.Point(6, 29)
        Me.AddRadioButton.Name = "AddRadioButton"
        Me.AddRadioButton.Size = New System.Drawing.Size(44, 17)
        Me.AddRadioButton.TabIndex = 6
        Me.AddRadioButton.TabStop = True
        Me.AddRadioButton.Text = "Add"
        Me.AddRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ExitButton)
        Me.GroupBox4.Controls.Add(Me.SummaryButton)
        Me.GroupBox4.Controls.Add(Me.ClearButton)
        Me.GroupBox4.Controls.Add(Me.SubmitButton)
        Me.GroupBox4.Location = New System.Drawing.Point(314, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(204, 259)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(6, 182)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(191, 48)
        Me.ExitButton.TabIndex = 13
        Me.ExitButton.Text = "E&xit"
        Me.HelpToolTip.SetToolTip(Me.ExitButton, "Stops Math Contest with ESC, X, or CLICK")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Enabled = False
        Me.SummaryButton.Location = New System.Drawing.Point(7, 128)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(191, 48)
        Me.SummaryButton.TabIndex = 12
        Me.SummaryButton.Text = "Summ&ary"
        Me.HelpToolTip.SetToolTip(Me.SummaryButton, "Gives Final Score with A or CLICK")
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(7, 74)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(191, 48)
        Me.ClearButton.TabIndex = 11
        Me.ClearButton.Text = "&Clear"
        Me.HelpToolTip.SetToolTip(Me.ClearButton, "Clears Student Info with C, or CLICK")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Enabled = False
        Me.SubmitButton.Location = New System.Drawing.Point(7, 20)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(191, 48)
        Me.SubmitButton.TabIndex = 10
        Me.SubmitButton.Text = "&Submit"
        Me.HelpToolTip.SetToolTip(Me.SubmitButton, "Checks Answer with ENTER, S, or CLICK")
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'MathContest
        '
        Me.AcceptButton = Me.SubmitButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(530, 279)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MathContest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Math Contest"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GradeNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgeNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents StudentTextBox As TextBox
    Friend WithEvents SecondNumberTextBox As TextBox
    Friend WithEvents FirstNumberTextBox As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DivRadioButton As RadioButton
    Friend WithEvents MultiRadioButton As RadioButton
    Friend WithEvents SubRadioButton As RadioButton
    Friend WithEvents AddRadioButton As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents HelpToolTip As ToolTip
    Friend WithEvents GradeLabel As Label
    Friend WithEvents AgeLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents StudentAnswerLabel As Label
    Friend WithEvents SecondNumberLabel As Label
    Friend WithEvents FirstNumberLabel As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SubmitButton As Button
    Friend WithEvents GradeNumericUpDown As NumericUpDown
    Friend WithEvents AgeNumericUpDown As NumericUpDown
End Class
