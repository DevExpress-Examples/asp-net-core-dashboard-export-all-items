using DevExpress.DashboardWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AspNetCoreDashboard_ExportAllItems.Classes {
    public class CustomDashboardStorage : DashboardFileStorage {
        public CustomDashboardStorage(string path) : base(path) { }
        public XDocument GetDashboardXmlById(string dashboardID) {
            return this.LoadDashboard(dashboardID);
        }
    }
}
