﻿using DevExpress.DashboardAspNetCore;
using DevExpress.DashboardWeb;
using Microsoft.AspNetCore.DataProtection;

namespace AspNetCoreDashboard_ExportAllItems.Controllers {
    public class DefaultDashboardController : DashboardController {
        public DefaultDashboardController(DashboardConfigurator configurator, IDataProtectionProvider dataProtectionProvider = null)
            : base(configurator, dataProtectionProvider) {
        }
    }
}