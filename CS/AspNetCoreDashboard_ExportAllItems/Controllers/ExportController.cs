using AspNetCoreDashboard_ExportAllItems.Classes;
using AspNetCoreDashboard_ExportAllItems.Models;
using DevExpress.DashboardAspNetCore;
using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using DevExpress.Pdf;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDashboard_ExportAllItems.Controllers {
    public class ExportController : Controller {

        [HttpGet]
        public FileContentResult ExportAllItems([FromServices] DashboardConfigurator dashboardConfigurator, string dashboardId, string state) {
            CustomDashboardStorage storage = dashboardConfigurator.DashboardStorage as CustomDashboardStorage;
            Dashboard dashboard = new Dashboard();
            dashboard.LoadFromXDocument(storage.GetDashboardXmlById(dashboardId));

            MemoryStream resultStream = new MemoryStream();
            using (PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor()) {
                documentProcessor.CreateEmptyDocument(resultStream);
                for (int i = 0; i < dashboard.Items.Count; i++) {
                    string dashboardItemName = dashboard.Items[i].ComponentName;
                    DashboardState dashboardState = new DashboardState();
                    dashboardState.LoadFromJson(state);

                    WebDashboardExporter exporter = new WebDashboardExporter(dashboardConfigurator);
                    using (MemoryStream stream = new MemoryStream()) {
                        exporter.ExportDashboardItemToPdf(dashboardId, dashboardItemName, stream, new System.Drawing.Size(1024, 768), dashboardState);
                        documentProcessor.AppendDocument(stream);
                    }
                }
            }
            return File(resultStream.ToArray(), "application/pdf", $"{dashboardId}.pdf");
        }
    }
}
