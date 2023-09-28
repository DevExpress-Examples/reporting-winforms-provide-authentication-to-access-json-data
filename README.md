<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/178005424/2023.1)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830444)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to Provide Authentication to Access Json Data in Reports

This example demonstrates how to provide a report's JSON data source with authentication parameters at runtime.

You can see two approaches to provide authentication to the specified Web Service Endpoint:

- **Approach 1**  
You can use a connection string to create a [JsonDataSource](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.Json.JsonDataSource) object. The connection string can include authentication parameters.  
In this approach, only the JsonDataSource's connection name is serialized to the report's definition. The JsonDataSource's [JsonSource](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.Json.JsonDataSource.JsonSource) property is not specified.

- **Approach 2**  
You can use the [UriJsonSource](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.Json.UriJsonSource) object to specify authentication parameters. Assign this object to the JsonDataSource's [JsonSource](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.Json.JsonDataSource.JsonSource) property.   
In this approach, authentication parameters are serialized to the report's definition together with the JsonDataSource's UriJsonSource object.

Refer to the [Provide Authentication to Access JSON Data (Runtime Sample)](https://docs.devexpress.com/XtraReports/400660) topic for more instructions.

Refer to the [JSON Data Source](https://docs.devexpress.com/XtraReports/400377) documentation section for more information on how to bind reports to JSON data.
