Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGauges.Win.Gauges.Linear
Imports DevExpress.XtraGauges.Core.Drawing
Imports DevExpress.XtraGauges.Core.Model

Namespace WindowsApplication1
	Partial Public Class XtraForm1
		Inherits DevExpress.XtraEditors.XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private time As Integer
		Private Const maxtime As Integer = 50
		Private Const highlightedIndicatorsCount As Integer = 4
		Private opacityValues() As Single = {0.5F, 0.7F, 0.9F, 1F }

		Public Sub ShowProgress()
			ShowDialog()
		End Sub

		Private Shared Sub HighlightIndicator(ByVal indicator As LinearScaleStateIndicatorComponent, ByVal opacity As Single)
			Dim shader As New OpacityShader()
			shader.Opacity = opacity
			indicator.Shader = shader
			indicator.States(0).ShapeType = StateIndicatorShapeType.ProgressItem9
		End Sub


		Public Sub SetProgress(ByVal progress As Integer)
			progress = progress Mod linearGauge1.Indicators.Count
			Dim highlightedIndicators(highlightedIndicatorsCount - 1) As LinearScaleStateIndicatorComponent
			For i As Integer = 0 To highlightedIndicatorsCount - 1
				highlightedIndicators(i) = linearGauge1.Indicators((progress + i) Mod linearGauge1.Indicators.Count)
			Next i

			For Each indicator As LinearScaleStateIndicatorComponent In linearGauge1.Indicators
				indicator.Shader = BaseColorShader.Empty
				indicator.States(0).ShapeType = StateIndicatorShapeType.ProgressItem5
			Next indicator
			For i As Integer = 0 To highlightedIndicatorsCount - 1
				HighlightIndicator(highlightedIndicators(i), opacityValues(i))
			Next i
		End Sub

		Private Sub timer1_Elapsed(ByVal sender As Object, ByVal e As System.Timers.ElapsedEventArgs) Handles timer1.Elapsed
			SetProgress(time)
			time += 1
			If time > maxtime Then
				timer1.Stop()
				Dispose()
			End If
		End Sub
	End Class
End Namespace