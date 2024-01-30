Imports DevExpress.DataAccess.Json
Imports System
Imports System.ComponentModel
Imports System.Xml.Linq

Namespace Xtrareport_json_datasource_with_authorization.ReportCustomization

    Public Class MyUriJsonSource
        Inherits UriJsonSource

        Public Property UserName As String

        <PasswordPropertyText(True)>
        Public Property Password As String

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
