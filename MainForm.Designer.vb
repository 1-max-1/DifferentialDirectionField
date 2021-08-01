<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
		Me.inputPanel = New System.Windows.Forms.Panel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.connectPointsCheckbox = New System.Windows.Forms.CheckBox()
		Me.pointCountLabel = New System.Windows.Forms.Label()
		Me.pointCountInput = New System.Windows.Forms.NumericUpDown()
		Me.goButton = New System.Windows.Forms.Button()
		Me.stepSizeLabel = New System.Windows.Forms.Label()
		Me.stepSizeInput = New System.Windows.Forms.NumericUpDown()
		Me.initialXInput = New System.Windows.Forms.NumericUpDown()
		Me.initialXLabel = New System.Windows.Forms.Label()
		Me.initialTLabel = New System.Windows.Forms.Label()
		Me.initialTInput = New System.Windows.Forms.NumericUpDown()
		Me.initialValuesLabel = New System.Windows.Forms.Label()
		Me.derivativeFunctionInput = New System.Windows.Forms.TextBox()
		Me.derivativeFunctionLabel = New System.Windows.Forms.Label()
		Me.plotView = New OxyPlot.WindowsForms.PlotView()
		Me.showDotsCheckbox = New System.Windows.Forms.CheckBox()
		Me.inputPanel.SuspendLayout()
		CType(Me.pointCountInput, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.stepSizeInput, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.initialXInput, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.initialTInput, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'inputPanel
		'
		Me.inputPanel.BackColor = System.Drawing.SystemColors.Control
		Me.inputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.inputPanel.Controls.Add(Me.showDotsCheckbox)
		Me.inputPanel.Controls.Add(Me.Label1)
		Me.inputPanel.Controls.Add(Me.connectPointsCheckbox)
		Me.inputPanel.Controls.Add(Me.pointCountLabel)
		Me.inputPanel.Controls.Add(Me.pointCountInput)
		Me.inputPanel.Controls.Add(Me.goButton)
		Me.inputPanel.Controls.Add(Me.stepSizeLabel)
		Me.inputPanel.Controls.Add(Me.stepSizeInput)
		Me.inputPanel.Controls.Add(Me.initialXInput)
		Me.inputPanel.Controls.Add(Me.initialXLabel)
		Me.inputPanel.Controls.Add(Me.initialTLabel)
		Me.inputPanel.Controls.Add(Me.initialTInput)
		Me.inputPanel.Controls.Add(Me.initialValuesLabel)
		Me.inputPanel.Controls.Add(Me.derivativeFunctionInput)
		Me.inputPanel.Controls.Add(Me.derivativeFunctionLabel)
		Me.inputPanel.Dock = System.Windows.Forms.DockStyle.Top
		Me.inputPanel.Location = New System.Drawing.Point(0, 0)
		Me.inputPanel.Name = "inputPanel"
		Me.inputPanel.Size = New System.Drawing.Size(1378, 193)
		Me.inputPanel.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(43, 114)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(106, 50)
		Me.Label1.TabIndex = 13
		Me.Label1.Text = "Of the form" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "dx/dt=f(x,t)"
		'
		'connectPointsCheckbox
		'
		Me.connectPointsCheckbox.AutoSize = True
		Me.connectPointsCheckbox.Location = New System.Drawing.Point(533, 124)
		Me.connectPointsCheckbox.Name = "connectPointsCheckbox"
		Me.connectPointsCheckbox.Size = New System.Drawing.Size(158, 29)
		Me.connectPointsCheckbox.TabIndex = 12
		Me.connectPointsCheckbox.Text = "Connect points"
		Me.connectPointsCheckbox.UseVisualStyleBackColor = True
		'
		'pointCountLabel
		'
		Me.pointCountLabel.AutoSize = True
		Me.pointCountLabel.Location = New System.Drawing.Point(730, 34)
		Me.pointCountLabel.Name = "pointCountLabel"
		Me.pointCountLabel.Size = New System.Drawing.Size(158, 25)
		Me.pointCountLabel.TabIndex = 11
		Me.pointCountLabel.Text = "Number of points:"
		'
		'pointCountInput
		'
		Me.pointCountInput.Location = New System.Drawing.Point(730, 71)
		Me.pointCountInput.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
		Me.pointCountInput.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.pointCountInput.Name = "pointCountInput"
		Me.pointCountInput.Size = New System.Drawing.Size(128, 31)
		Me.pointCountInput.TabIndex = 10
		Me.pointCountInput.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'goButton
		'
		Me.goButton.Location = New System.Drawing.Point(927, 65)
		Me.goButton.Name = "goButton"
		Me.goButton.Size = New System.Drawing.Size(179, 83)
		Me.goButton.TabIndex = 9
		Me.goButton.Text = "Go!"
		Me.goButton.UseVisualStyleBackColor = True
		'
		'stepSizeLabel
		'
		Me.stepSizeLabel.AutoSize = True
		Me.stepSizeLabel.Location = New System.Drawing.Point(550, 34)
		Me.stepSizeLabel.Name = "stepSizeLabel"
		Me.stepSizeLabel.Size = New System.Drawing.Size(85, 25)
		Me.stepSizeLabel.TabIndex = 8
		Me.stepSizeLabel.Text = "Step size:"
		'
		'stepSizeInput
		'
		Me.stepSizeInput.DecimalPlaces = 4
		Me.stepSizeInput.Location = New System.Drawing.Point(550, 71)
		Me.stepSizeInput.Name = "stepSizeInput"
		Me.stepSizeInput.Size = New System.Drawing.Size(128, 31)
		Me.stepSizeInput.TabIndex = 7
		'
		'initialXInput
		'
		Me.initialXInput.DecimalPlaces = 4
		Me.initialXInput.Location = New System.Drawing.Point(362, 123)
		Me.initialXInput.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
		Me.initialXInput.Minimum = New Decimal(New Integer() {1000000, 0, 0, -2147483648})
		Me.initialXInput.Name = "initialXInput"
		Me.initialXInput.Size = New System.Drawing.Size(131, 31)
		Me.initialXInput.TabIndex = 6
		'
		'initialXLabel
		'
		Me.initialXLabel.AutoSize = True
		Me.initialXLabel.Location = New System.Drawing.Point(332, 123)
		Me.initialXLabel.Name = "initialXLabel"
		Me.initialXLabel.Size = New System.Drawing.Size(24, 25)
		Me.initialXLabel.TabIndex = 5
		Me.initialXLabel.Text = "x:"
		'
		'initialTLabel
		'
		Me.initialTLabel.AutoSize = True
		Me.initialTLabel.Location = New System.Drawing.Point(332, 71)
		Me.initialTLabel.Name = "initialTLabel"
		Me.initialTLabel.Size = New System.Drawing.Size(22, 25)
		Me.initialTLabel.TabIndex = 4
		Me.initialTLabel.Text = "t:"
		'
		'initialTInput
		'
		Me.initialTInput.DecimalPlaces = 4
		Me.initialTInput.Location = New System.Drawing.Point(362, 71)
		Me.initialTInput.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
		Me.initialTInput.Minimum = New Decimal(New Integer() {1000000, 0, 0, -2147483648})
		Me.initialTInput.Name = "initialTInput"
		Me.initialTInput.Size = New System.Drawing.Size(131, 31)
		Me.initialTInput.TabIndex = 3
		'
		'initialValuesLabel
		'
		Me.initialValuesLabel.AutoSize = True
		Me.initialValuesLabel.Location = New System.Drawing.Point(332, 34)
		Me.initialValuesLabel.Name = "initialValuesLabel"
		Me.initialValuesLabel.Size = New System.Drawing.Size(112, 25)
		Me.initialValuesLabel.TabIndex = 2
		Me.initialValuesLabel.Text = "Initial values:"
		'
		'derivativeFunctionInput
		'
		Me.derivativeFunctionInput.Location = New System.Drawing.Point(43, 68)
		Me.derivativeFunctionInput.Name = "derivativeFunctionInput"
		Me.derivativeFunctionInput.Size = New System.Drawing.Size(240, 31)
		Me.derivativeFunctionInput.TabIndex = 1
		'
		'derivativeFunctionLabel
		'
		Me.derivativeFunctionLabel.AutoSize = True
		Me.derivativeFunctionLabel.Location = New System.Drawing.Point(43, 34)
		Me.derivativeFunctionLabel.Name = "derivativeFunctionLabel"
		Me.derivativeFunctionLabel.Size = New System.Drawing.Size(164, 25)
		Me.derivativeFunctionLabel.TabIndex = 0
		Me.derivativeFunctionLabel.Text = "Derivative function:"
		'
		'plotView
		'
		Me.plotView.Dock = System.Windows.Forms.DockStyle.Fill
		Me.plotView.Location = New System.Drawing.Point(0, 193)
		Me.plotView.Name = "plotView"
		Me.plotView.PanCursor = System.Windows.Forms.Cursors.Hand
		Me.plotView.Size = New System.Drawing.Size(1378, 651)
		Me.plotView.TabIndex = 1
		Me.plotView.Text = "PlotView1"
		Me.plotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE
		Me.plotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE
		Me.plotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS
		'
		'showDotsCheckbox
		'
		Me.showDotsCheckbox.AutoSize = True
		Me.showDotsCheckbox.Checked = True
		Me.showDotsCheckbox.CheckState = System.Windows.Forms.CheckState.Checked
		Me.showDotsCheckbox.Location = New System.Drawing.Point(730, 125)
		Me.showDotsCheckbox.Name = "showDotsCheckbox"
		Me.showDotsCheckbox.Size = New System.Drawing.Size(123, 29)
		Me.showDotsCheckbox.TabIndex = 14
		Me.showDotsCheckbox.Text = "Show dots"
		Me.showDotsCheckbox.UseVisualStyleBackColor = True
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1378, 844)
		Me.Controls.Add(Me.plotView)
		Me.Controls.Add(Me.inputPanel)
		Me.Name = "MainForm"
		Me.Text = "Eulers Method"
		Me.inputPanel.ResumeLayout(False)
		Me.inputPanel.PerformLayout()
		CType(Me.pointCountInput, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.stepSizeInput, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.initialXInput, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.initialTInput, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents inputPanel As Panel
	Friend WithEvents derivativeFunctionLabel As Label
	Friend WithEvents derivativeFunctionInput As TextBox
	Friend WithEvents initialValuesLabel As Label
	Friend WithEvents initialXInput As NumericUpDown
	Friend WithEvents initialXLabel As Label
	Friend WithEvents initialTLabel As Label
	Friend WithEvents initialTInput As NumericUpDown
	Friend WithEvents stepSizeLabel As Label
	Friend WithEvents stepSizeInput As NumericUpDown
	Friend WithEvents goButton As Button
	Friend WithEvents pointCountLabel As Label
	Friend WithEvents pointCountInput As NumericUpDown
	Friend WithEvents connectPointsCheckbox As CheckBox
	Friend WithEvents Label1 As Label
	Friend WithEvents plotView As OxyPlot.WindowsForms.PlotView
	Friend WithEvents showDotsCheckbox As CheckBox
End Class
