var ExportAllItemsExtension = (function () {
    var _dashboardControl;
    var _exportRoute;

    // Viewer
    function customizeTitleToolbar(e) {
        e.options.actionItems.push({
            icon: 'dx-dashboard-export-to-pdf',
            tooltip: 'Export All Items',
            type: 'button',
            click: performExport
        });
    }

    function performExport(e) {
        var queryParameters = new URLSearchParams({
            dashboardId: _dashboardControl.getDashboardId(),
            state: _dashboardControl.getDashboardState()
        });
        window.open(`${_exportRoute}?${queryParameters}`);
    }

    // Event Subscription
    function ExportAllItemsExtension(dashboardControl, exportRoute) {
        this.name = "exportAllItems";

        _dashboardControl = dashboardControl;
        _exportRoute = exportRoute;

        this.start = function () {
            var viewerApiExtension = _dashboardControl.findExtension('viewerApi');
            if (viewerApiExtension) {
                viewerApiExtension.on('dashboardTitleToolbarUpdated', customizeTitleToolbar);
            }
        };
        this.stop = function () {
            var viewerApiExtension = _dashboardControl.findExtension('viewerApi');
            if (viewerApiExtension) {
                viewerApiExtension.off('itemCaptionToolbarUpdated', customizeTitleToolbar);
            }
        };
    }
    return ExportAllItemsExtension;
}());
