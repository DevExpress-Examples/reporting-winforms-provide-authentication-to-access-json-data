Imports DevExpress.DataAccess.Json
Imports DevExpress.XtraReports.UI
Imports System
Imports System.Collections.Generic
Imports System.Data.Common
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports Xtrareport_json_datasource_with_authorization.ReportCustomization

Namespace Xtrareport_json_datasource_with_authorization
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		#Region "CreateReportDataSourceFromConnectionStringButton_Click"
		Private Sub CreateReportDataSourceFromConnectionStringButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			' XtraReport1 does not have assigned data sources
			Dim report = New XtraReport1()

			' Create JsonDataSource from the specified connection string
			Dim jsonDataSource = CreateReportDataSourceFromConnectionString()
			' Retrieve data to populate the Report Designer's Field List
			jsonDataSource.Fill()

			report.DataSource = jsonDataSource
			report.DataMember = "Customers"

			Call (New DevExpress.XtraReports.UI.ReportDesignTool(report)).ShowDesigner()
		End Sub
		#End Region
		#Region "CreateReportDataSourceFromConnectionString"
		Public Shared Function CreateReportDataSourceFromConnectionString() As JsonDataSource
			Dim jsonDataSource As JsonDataSource = New DevExpress.DataAccess.Json.JsonDataSource() With {.ConnectionName = "JsonConnection"}
			Return jsonDataSource
		End Function
		#End Region

		#Region "CreateReportDataSourceWithAuthenticationInCodeButton_Click"
		Private Sub CreateReportDataSourceWithAuthenticationInCodeButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click, button1.Click
			' XtraReport1 does not have assigned data sources
			Dim report = New XtraReport1()

			' Create JsonDataSource in code
			Dim jsonDataSource As JsonDataSource = CreateReportDataSourceWithAuthenticationInCode()
			' Retrieve data to populate the Report Designer's Field List
			jsonDataSource.Fill()

			report.DataSource = jsonDataSource
			report.DataMember = "Customers"

			Call (New DevExpress.XtraReports.UI.ReportDesignTool(report)).ShowDesigner()
		End Sub
		#End Region
		#Region "CreateReportDataSourceWithAuthenticationInCode"
		Public Shared Function CreateReportDataSourceWithAuthenticationInCode() As JsonDataSource
		#End Region
			#Region "CreateReportDataSourceWithAuthenticationInCode_JsonSource"
			' Create a new UriJsonSource object and configure authentication data in it
			Dim jsonSource = New DevExpress.DataAccess.Json.UriJsonSource()
			jsonSource.Uri = New Uri("http://northwind.servicestack.net/customers.json")


			jsonSource.AuthenticationInfo.Username = "user"
			jsonSource.AuthenticationInfo.Password = "pwd"

			jsonSource.HeaderParameters.Add(New HeaderParameter("MyAuthHeader1", "secretToken1"))
			jsonSource.HeaderParameters.Add(New HeaderParameter("MyAuthHeader2", "secretToken2"))

			jsonSource.QueryParameters.Add(New QueryParameter("id", "123456"))
			jsonSource.QueryParameters.Add(New QueryParameter("name", "MyName"))
			#End Region
			#Region "CreateReportDataSourceWithAuthenticationInCode_JsonDataSource"
			' Create a JsonDataSource object and assign the UriJsonSource object to it
			Dim jsonDataSource = New DevExpress.DataAccess.Json.JsonDataSource() With {.JsonSource = jsonSource}

			Return jsonDataSource
			#End Region
			#Region "CreateReportDataSourceWithAuthenticationInCode_EndClass"
		End Function
		#End Region

	End Class
	#Region "ConvertReportWithMyUriJsonSourceTo191"
	Public NotInheritable Class JsonDatasourceAuthorization_Example

		Private Sub New()
		End Sub

		Public Shared Function ConvertReportWithMyUriJsonSourceTo191(ByVal repxContent As String, <System.Runtime.InteropServices.Out()> ByRef connectionString As List(Of String)) As String
			Dim report = New XtraReport()
			Using ms = New MemoryStream(Encoding.UTF8.GetBytes(repxContent))
				report.LoadLayoutFromXml(ms)
			End Using

			connectionString = New List(Of String)()

			Dim i As Integer = 0
			For Each component In report.ComponentStorage
				Dim jsonDS = (TryCast(component, DevExpress.DataAccess.Json.JsonDataSource))
				Dim jsonSource = (TryCast(jsonDS?.JsonSource, MyUriJsonSource))
				If jsonSource IsNot Nothing Then
					i += 1
					jsonDS.ConnectionName = String.Format("newJsonConnection_{0}{1}", report.Name, i.ToString())

					Dim builder = New DbConnectionStringBuilder()
					builder.Add("Uri", jsonSource.Uri.OriginalString)
					builder.Add("UserName", jsonSource.UserName)
					builder.Add("Password", jsonSource.Password)

					connectionString.Add(String.Format("<add name=""{0}"" connectionString=""{1}"" providerName=""JsonSourceProvider"" />", jsonDS.ConnectionName, builder.ConnectionString))

					jsonDS.JsonSource = Nothing
				End If
			Next component
			Using ms = New MemoryStream()
				report.SaveLayoutToXml(ms)
				ms.Position = 0
				Dim reader As New StreamReader(ms)
				Return reader.ReadToEnd()
			End Using
		End Function
	End Class
	#End Region
End Namespace
