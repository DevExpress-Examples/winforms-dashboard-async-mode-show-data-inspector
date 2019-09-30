Imports System
Imports System.Windows.Forms

Namespace DataInspectorOnInitializeExample
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
			AddHandler dashboardViewer1.Initialized, AddressOf dashboardViewer1_Initialized
		End Sub
		Private Async Sub dashboardViewer1_Initialized(ByVal sender As Object, ByVal e As EventArgs)
			Await dashboardViewer1.ShowDataInspectorAsync("gridDashboardItem1")
		End Sub
	End Class
End Namespace
