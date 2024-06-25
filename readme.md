<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/434628383/23.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1091839)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# BI Dashboard for ASP.NET Core - How to export all dashboard items into the same PDF document

This example shows how to add a custom **Export to PDF** button that exports all dashboard items into the same PDF document.

## Client

On the client, the [ViewerApiExtensionOptions.onDashboardTitleToolbarUpdated](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.ViewerApiExtensionOptions#js_devexpress_dashboard_viewerapiextensionoptions_ondashboardtitletoolbarupdated) event is handled to modify the [dashboard title](https://docs.devexpress.com/Dashboard/117383/web-dashboard/ui-elements-and-customization/ui-elements/dashboard-title) and add the custom export button to it. This functionality is encapsulated into a custom [dashboard extension](https://docs.devexpress.com/Dashboard/117543/web-dashboard/ui-elements-and-customization/extensions-overview) (the [ExportAllItemsExtension.js](/CS/AspNetCoreDashboard_ExportAllItems/wwwroot/js/ExportAllItemsExtension.js) file).

To perform the export operation, the client sends a GET request to a custom Export Controller.

## Server

The custom Export Controller processes requests from the client side. This controller uses the following classes:

- The [WebDashboardExporter](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.WebDashboardExporter) class exports dashboard items to PDF.
- The [PdfDocumentProcessor](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Pdf.PdfDocumentProcessor) class joins exported documents together.

## Files to Review

* [ExportAllItemsExtension.js](CS/AspNetCoreDashboard_ExportAllItems/wwwroot/js/ExportAllItemsExtension.js)
* [Startup.cs](./CS/AspNetCoreDashboard_ExportAllItems/Startup.cs)
* [CustomDashboardStorage.cs](./CS/AspNetCoreDashboard_ExportAllItems/Classes/CustomDashboardStorage.cs)
* [ExportController.cs](./CS/AspNetCoreDashboard_ExportAllItems/Controllers/ExportController.cs)
* [DashboardExportModel.cs](./CS/AspNetCoreDashboard_ExportAllItems/Models/DashboardExportModel.cs)
* [_Layout.cshtml](./CS/AspNetCoreDashboard_ExportAllItems/Pages/_Layout.cshtml)
* [Index.cshtml](./CS/AspNetCoreDashboard_ExportAllItems/Pages/Index.cshtml)

## Documentation

- [Manage Exporting Capabilities](https://docs.devexpress.com/Dashboard/400355/web-dashboard/aspnet-core-dashboard-control/manage-exporting-capabilities)

## More Examples

- [Dashboard for ASP.NET Core - How to load and save dashboards from/to a database](https://github.com/DevExpress-Examples/asp-net-core-dashboard-save-dashboards-to-database)
- [Dashboard for MVC - How to implement server-side export](https://github.com/DevExpress-Examples/aspnet-mvc-dashboard-how-to-implement-server-side-export-t590027)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-core-dashboard-export-all-items&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-core-dashboard-export-all-items&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
