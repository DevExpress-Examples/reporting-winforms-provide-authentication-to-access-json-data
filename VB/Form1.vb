Imports DevExpress.DataAccess.Json
Imports DevExpress.XtraReports.UI
Imports System
Imports System.Collections.Generic
Imports System.Data.Common
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports Xtrareport_json_datasource_with_authorization.ReportCustomization
Imports System.Runtime.InteropServices

Namespace Xtrareport_json_datasource_with_authorization

    Public Partial Class Form1
        Inherits System.Windows.Forms.Form

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub CreateReportDataSourceFromConnectionStringButton_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            ' XtraReport1 does not have assigned data sources
            Dim report = New Xtrareport_json_datasource_with_authorization.XtraReport1()
            ' Create JsonDataSource from the specified connection string
            Dim jsonDataSource = Xtrareport_json_datasource_with_authorization.Form1.CreateReportDataSourceFromConnectionString()
            ' Retrieve data to populate the Report Designer's Field List
            jsonDataSource.Fill()
            report.DataSource = jsonDataSource
            report.DataMember = "Customers"
            Call New DevExpress.XtraReports.UI.ReportDesignTool(CType((report), DevExpress.XtraReports.UI.XtraReport)).ShowDesigner()
        End Sub

        Public Shared Function CreateReportDataSourceFromConnectionString() As JsonDataSource
            ' The application's configuration file should include the "JsonConnection" connection string
            Dim jsonDataSource As DevExpress.DataAccess.Json.JsonDataSource = New DevExpress.DataAccess.Json.JsonDataSource() With {.ConnectionName = "JsonConnection"}
            Return jsonDataSource
        End Function

        Private Sub CreateReportDataSourceWithAuthenticationInCodeButton_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            ' XtraReport1 does not have assigned data sources
            Dim report = New Xtrareport_json_datasource_with_authorization.XtraReport1()
            ' Create JsonDataSource in code
            Dim jsonDataSource As DevExpress.DataAccess.Json.JsonDataSource = Xtrareport_json_datasource_with_authorization.Form1.CreateReportDataSourceWithAuthenticationInCode()
            ' Retrieve data to populate the Report Designer's Field List
            jsonDataSource.Fill()
            report.DataSource = jsonDataSource
            report.DataMember = "Customers"
            Call New DevExpress.XtraReports.UI.ReportDesignTool(CType((report), DevExpress.XtraReports.UI.XtraReport)).ShowDesigner()
        End Sub

        Public Shared Function CreateReportDataSourceWithAuthenticationInCode() As JsonDataSource
            ' Create a new UriJsonSource object and configure authentication data in it
            Dim jsonSource = New DevExpress.DataAccess.Json.UriJsonSource()
            jsonSource.Uri = New System.Uri("http://northwind.servicestack.net/customers.json")
            jsonSource.AuthenticationInfo.Username = "user"
            jsonSource.AuthenticationInfo.Password = "pwd"
            jsonSource.HeaderParameters.Add(New DevExpress.DataAccess.Json.HeaderParameter("MyAuthHeader1", "secretToken1"))
            jsonSource.HeaderParameters.Add(New DevExpress.DataAccess.Json.HeaderParameter("MyAuthHeader2", "secretToken2"))
            jsonSource.QueryParameters.Add(New DevExpress.DataAccess.Json.QueryParameter("id", "123456"))
            jsonSource.QueryParameters.Add(New DevExpress.DataAccess.Json.QueryParameter("name", "MyName"))
            ' Create a JsonDataSource object and assign the UriJsonSource object to it
            Dim jsonDataSource = New DevExpress.DataAccess.Json.JsonDataSource() With {.JsonSource = jsonSource}
            Return jsonDataSource
        End Function
    End Class

    Public Module JsonDatasourceAuthorization_Example

        Public Function ConvertReportWithMyUriJsonSourceTo191(ByVal repxContent As String, <Out> ByRef connectionString As System.Collections.Generic.List(Of String)) As String
            Dim report = New DevExpress.XtraReports.UI.XtraReport()
            Using ms = New System.IO.MemoryStream(System.Text.Encoding.UTF8.GetBytes(repxContent))
                report.LoadLayoutFromXml(ms)
            End Using

            connectionString = New System.Collections.Generic.List(Of String)()
            Dim i As Integer = 0
            For Each component In report.ComponentStorage
                Dim jsonDS = TryCast(component, DevExpress.DataAccess.Json.JsonDataSource)
                Dim jsonSource = TryCast(jsonDS?.JsonSource, Xtrareport_json_datasource_with_authorization.ReportCustomization.MyUriJsonSource)
                If jsonSource IsNot Nothing Then
                    i += 1
                    jsonDS.ConnectionName = String.Format("newJsonConnection_{0}{1}", report.Name, i.ToString())
                    Dim builder = New System.Data.Common.DbConnectionStringBuilder()
                    builder.Add("Uri", jsonSource.Uri.OriginalString)
                    builder.Add("UserName", jsonSource.UserName)
                    builder.Add("Password", jsonSource.Password)
                    connectionString.Add(String.Format("<add name=""{0}"" connectionString=""{1}"" providerName=""JsonSourceProvider"" />", jsonDS.ConnectionName, builder.ConnectionString))
                    jsonDS.JsonSource = Nothing
                End If
            Next

            Using ms = New System.IO.MemoryStream()
                report.SaveLayoutToXml(ms)
                ms.Position = 0
                Dim reader As System.IO.StreamReader = New System.IO.StreamReader(ms)
                Return reader.ReadToEnd()
            End Using
        End Function
    End Module
End Namespace
