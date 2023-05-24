<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/306050958/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T942028)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Dashboard for ASP.NET Core - Backend

This is an ASP.NET Core 6.0 backend application (server) for the [DevExpress Web Dashboard](https://docs.devexpress.com/Dashboard/115955/web-dashboard). The server handles client data requests and includes backend capabilities such as data access, dashboard storage, and so on.

This server contains a dashboard connected to a JSON data source and a SQL Server Connection String, but I have removed the appsettings.json and appsettings,development.json from GIT for security reasons. The data source obtains data from the following connection: `https://raw.githubusercontent.com/DevExpress-Examples/DataSources/master/JSON/customers.json`.

> **Warning** This application does not have any views. Configure and launch a client application to display data from this server, be it react or angular, I am personally using react as Client App.

## Quick Start
Install DevExpress BI Dashboard for ASP.NET Core 6.0 from: [DevExpress](https://www.devexpress.com/products/net/dashboard/) and get a valid license.
Run the following command to start server:

```
dotnet run
```

See the following section for information on how to install NuGet packages from the DevExpress NuGet feed: [Install DevExpress Controls Using NuGet Packages](https://docs.devexpress.com/GeneralInformation/115912/installation/install-devexpress-controls-using-nuget-packages).

> This server allows CORS requests from _all_ origins with _any_ scheme (http or https). This default configuration is insecure: any website can make cross-origin requests to the app. We recommend that you specify the client application's URL to prohibit other clients from accessing sensitive information stored on the server. Learn more: [Cross-Origin Resource Sharing (CORS)](https://docs.devexpress.com/Dashboard/400709)

In the client application, set the following URL as an [endpoint](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DashboardControlOptions?p=netframework#js_devexpress_dashboard_dashboardcontroloptions_endpoint):

```
http://localhost:5000/api/dashboard
```

To debug the server, run the **AspNetCoreDashboardBackend** application in Visual Studio and change the client's `endpoint` property according to the listening port: `https://localhost:44395/api/dashboard`.

## Files to Review

* [Program.cs](./CS/AspNetCoreDashboardBackend/Program.cs)
* [DashboardUtils.cs](./CS/AspNetCoreDashboardBackend/Code/DashboardUtils.cs)
* [DefaultDashboardController.cs](./CS/AspNetCoreDashboardBackend/DefaultDashboardController.cs)
<!-- default file list end -->


## Documentation

- [Dashboard Backend](https://docs.devexpress.com/Dashboard/402096)    
- [Cross-Origin Resource Sharing (CORS)](https://docs.devexpress.com/Dashboard/400709)    
- [Install DevExpress Controls Using NuGet Packages](https://docs.devexpress.com/GeneralInformation/115912/installation/install-devexpress-controls-using-nuget-packages)
        
## More Examples from DevExpress

- [Get Started - Client-Side Dashboard Application (Angular)](https://github.com/DevExpress-Examples/dashboard-angular-app)
- [Get Started - Client-Side Dashboard Application (React)](https://github.com/DevExpress-Examples/dashboard-react-app)
- [Get Started - Client-Side Dashboard Application (Vue)](https://github.com/DevExpress-Examples/dashboard-vue-app)
