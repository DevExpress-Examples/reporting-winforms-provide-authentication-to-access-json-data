<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/178005424/23.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830444)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Reporting for WinForms - How to Provide Authentication to Access JSON Data

This example demonstrates how to provide a report's JSON data source with authentication parameters at runtime. You can see two approaches to provide authentication to the specified Web Service Endpoint:

- **Approach 1**  
You can use a connection string to create a [JsonDataSource](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.Json.JsonDataSource) object. The connection string can include authentication parameters.  
In this approach, only the JsonDataSource's connection name is serialized to the report's definition. The JsonDataSource's [JsonSource](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.Json.JsonDataSource.JsonSource) property is not specified.

- **Approach 2**  
You can use the [UriJsonSource](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.Json.UriJsonSource) object to specify authentication parameters. Assign this object to the JsonDataSource's [JsonSource](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.Json.JsonDataSource.JsonSource) property.   
In this approach, authentication parameters are serialized to the report's definition together with the JsonDataSource's UriJsonSource object.

## Files to Review

* [MyUriJsonSource.cs](./CS/ReportCustomization/MyUriJsonSource.cs) (VB: [MyUriJsonSource.vb](./VB/ReportCustomization/MyUriJsonSource.vb))
* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))

## Documentation

* [Provide Authentication to Access JSON Data (Runtime Sample)](https://docs.devexpress.com/XtraReports/400660)
* [JSON Data Source](https://docs.devexpress.com/XtraReports/400377)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-winforms-provide-authentication-to-access-json-data&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-winforms-provide-authentication-to-access-json-data&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
