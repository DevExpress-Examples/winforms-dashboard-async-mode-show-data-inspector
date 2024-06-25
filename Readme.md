# Dashboard for WinForms - How to Invoke the Data Inspector Asynchronously When the Dashboard is Loaded

This example demonstrates how to call asynchronous methods that retrieves data when the dashboard is loaded.

The Dashboard Viewer loads a dashboard and asynchronously invokes the [Data Inspector](https://docs.devexpress.com/Dashboard/401194) window.

![Dashboard for WinForms - Data Inspector Window](/images/screenshot.png)

## Files to look at:
* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))


## API

* The [DashboardViewer.AsyncMode](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.AsyncMode) property.
* The [DashboardViewer.ShowDataInspectorAsync](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.ShowDataInspectorAsync(System.String)) method.
* The [DashboardViewer.Initialized](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.Initialized) event.


## Documentation

* [Manage Data Inspector in the WinForms Viewer](https://docs.devexpress.com/Dashboard/403975/winforms-dashboard/winforms-viewer/manage-data-inspector-in-win-forms-viewer)
* [Asynchronous Mode](https://docs.devexpress.com/Dashboard/401305)

## More Examples 

- [Dashboard for WinForms - How to Get Dashboard Item Data Asynchronously](https://github.com/DevExpress-Examples/winforms-dashboard-async-mode-get-item-data)
- [Dashboard for WinForms - How to Get FIlter Values and Set Master Filter Asynchronously](https://github.com/DevExpress-Examples/winforms-dashboard-async-mode-random-filter)
- [Dashboard for WinForms - How to Create a Slide Show with Asynchronous Maximize and Restore Methods](https://github.com/DevExpress-Examples/winforms-dashboard-async-mode-maximize-slide-show)
