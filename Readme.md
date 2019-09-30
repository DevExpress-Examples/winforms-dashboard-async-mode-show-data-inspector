<!-- default file list -->
*Files to look at*:
* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- default file list end -->

# How to Invoke the Data Inspector Asynchronously When the Dashoard is Loaded

This example demonstrates how to call asynchronous methods that retrieves data when the dashboard is loaded.

The Dashboard Viewer loads a dashboard and asynchronously invokes the [Data Inspector](https://docs.devexpress.com/Dashboard/401194) window.

![screenshot](/images/screenshot.png)



API in this example:

* [DashboardViewer.AsyncMode](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.AsyncMode). Switches to the asynchronous mode. The property is set in the **InitializeComponent** method.
* [DashboardViewer.ShowDataInspectorAsync](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.ShowDataInspectorAsync(System.String)) method. Invokes the Data Inspector window for the specified dashboard item, asynchronously.
* [DashboardViewer.Initialized](https:/docs.devexpress.devx/Dashboard/DevExpress.DashboardWin.DashboardViewer.Initialized) event. Handle this event to perform asynchronous tasks on the first load.


See also:

* [Asynchronous Mode](https://docs.devexpress.com/Dashboard/401305)
