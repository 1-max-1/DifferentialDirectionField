Imports org.mariuszgromada.math.mxparser
Imports OxyPlot
Imports OxyPlot.Series

Public Class MainForm
	Private ReadOnly dotSeries As ScatterSeries
	Private ReadOnly lineSeries As LineSeries
	Private model As PlotModel

	Private Sub New()
		InitializeComponent()

		dotSeries = New ScatterSeries() With {.MarkerType = MarkerType.Circle}
		lineSeries = New LineSeries()
	End Sub

	'Actually puts the data series on the graph
	Private Sub RefreshSeries()
		'Need to clear it because series can only be added to 1 model.
		'If there is no model yet, then this is the first graph and we dont need to clear.
		If model IsNot Nothing Then model.Series.Clear()

		'Create a new model every time. This allows the axis range to be re-calculated
		model = New PlotModel()
		model.Series.Add(dotSeries)
		model.Series.Add(lineSeries)

		'And we need to do a refresh so it redraws itself and makes the new data appear
		plotView.Model = model
		plotView.Refresh()
	End Sub

	Private Sub goButton_Click(sender As Object, e As EventArgs) Handles goButton.Click
		'Get values from input fields
		Dim currentIndependent As Double = initialTInput.Value
		Dim currentDependent As Double = initialXInput.Value
		Dim stepSize As Double = stepSizeInput.Value

		Dim der As New [Function]("DF(t,x) = " & derivativeFunctionInput.Text)

		'Plot intial value.
		dotSeries.Points.Clear()
		lineSeries.Points.Clear()
		dotSeries.Points.Add(New ScatterPoint(currentIndependent, currentDependent))
		lineSeries.Points.Add(New DataPoint(currentIndependent, currentDependent))

		'Now use eulers method to get the next points and plot them
		'maximumIterations - 2 instead of -1 because we have already plotted the initial condition point
		For i = 0 To (pointCountInput.Value - 2) * stepSize Step stepSize
			Dim expression As New Expression(String.Format("DF({0},{1})", currentIndependent, currentDependent), der)
			currentDependent += stepSize * expression.calculate()
			currentIndependent += stepSize

			'Add points to both dot and line
			dotSeries.Points.Add(New ScatterPoint(currentIndependent, currentDependent))
			lineSeries.Points.Add(New DataPoint(currentIndependent, currentDependent))
		Next

		'Checkboxes allow user to control visibility
		dotSeries.IsVisible = showDotsCheckbox.Checked
		lineSeries.IsVisible = connectPointsCheckbox.Checked
		RefreshSeries()
	End Sub

	'When a chekcbox is clicked all we need to do is update the visibility and refresh
	''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
	Private Sub showDotsCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles showDotsCheckbox.CheckedChanged
		If dotSeries IsNot Nothing And plotView.Model IsNot Nothing Then
			dotSeries.IsVisible = showDotsCheckbox.Checked
			RefreshSeries()
		End If
	End Sub

	Private Sub connectPointsCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles connectPointsCheckbox.CheckedChanged
		If lineSeries IsNot Nothing And plotView.Model IsNot Nothing Then
			lineSeries.IsVisible = connectPointsCheckbox.Checked
			RefreshSeries()
		End If
	End Sub
	''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
End Class