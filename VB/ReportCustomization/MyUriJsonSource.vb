Imports DevExpress.DataAccess.Json
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Net
Imports System.Text
Imports System.Threading.Tasks
Imports System.Xml.Linq
Imports DevExpress.DataAccess.Native
Imports System.Security.Cryptography
Imports System.IO
Imports System.Web.Security

Namespace Xtrareport_json_datasource_with_authorization.ReportCustomization
	Public Class MyUriJsonSource
		Inherits UriJsonSource

		Public Property UserName() As String

		<PasswordPropertyText(True)>
		Public Property Password() As String

		Protected Overrides Sub LoadFromXml(ByVal connection As XElement)
			MyBase.LoadFromXml(connection)
			Dim cred = MySecretStorage.SecretStorage.Instance.GetCredentials(Uri.Authority)
			If cred IsNot Nothing Then
				UserName = cred.Item1
				Password = cred.Item2
			End If
		End Sub
	End Class
End Namespace
