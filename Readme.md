<!-- default file list -->
*Files to look at*:
* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- default file list end -->

# How to Invoke the Data Inspector Asynchronously When the Dashboard is Loaded

This example demonstrates how to call asynchronous methods that retrieves data when the dashboard is loaded.

The Dashboard Viewer loads a dashboard and asynchronously invokes the [Data Inspector](https://docs.devexpress.com/Dashboard/401194) window.

![screenshot](/images/screenshot.png)



## API

* [DashboardViewer.AsyncMode](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.AsyncMode). Switches to the asynchronous mode. The property is set in the **InitializeComponent** method.
* [DashboardViewer.ShowDataInspectorAsync](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.ShowDataInspectorAsync(System.String)) method. Invokes the Data Inspector window for the specified dashboard item, asynchronously.
* [DashboardViewer.Initialized](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.Initialized) event. Handle this event to perform asynchronous tasks on the first load.


## Documentation

* [Asynchronous Mode](https://docs.devexpress.com/Dashboard/401305)
* [Data Inspector](https://docs.devexpress.com/Dashboard/401194)

## More Examples 

- [Dashboard Viewer: How to Get Dashboard Item Data Asynchronously](https://github.com/DevExpress-Examples/winforms-dashboard-async-mode-get-item-data)
- [Dashboard Viewer: How to Get FIlter Values and Set Master Filter Asynchronously](https://github.com/DevExpress-Examples/winforms-dashboard-async-mode-random-filter)
- [Dashboard Viewer: How to Create a Slide Show with Asynchronous Maximize and Restore Methods](https://github.com/DevExpress-Examples/winforms-dashboard-async-mode-maximize-slide-show)
