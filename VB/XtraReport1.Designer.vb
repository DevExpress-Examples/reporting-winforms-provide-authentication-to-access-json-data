Namespace Xtrareport_json_datasource_with_authorization

    Partial Class XtraReport1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            CType((Me.xrTable2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.Name = "TopMargin"
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Name = "BottomMargin"
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable2})
            Me.Detail.HeightF = 25F
            Me.Detail.Name = "Detail"
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Country]")})
            Me.xrLabel1.Font = New System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold)
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 10.00001F)
            Me.xrLabel1.Multiline = True
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(150F, 30F)
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.Text = "xrLabel1"
            ' 
            ' GroupHeader2
            ' 
            Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1})
            Me.GroupHeader2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Country", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
            Me.GroupHeader2.HeightF = 40.00001F
            Me.GroupHeader2.Level = 1
            Me.GroupHeader2.Name = "GroupHeader2"
            ' 
            ' xrTable2
            ' 
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(50F, 0F)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow2})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(600F, 25F)
            ' 
            ' xrTableRow2
            ' 
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell5, Me.xrTableCell6, Me.xrTableCell7, Me.xrTableCell8})
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.Weight = 11.5R
            ' 
            ' xrTableCell5
            ' 
            Me.xrTableCell5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CompanyName]")})
            Me.xrTableCell5.Multiline = True
            Me.xrTableCell5.Name = "xrTableCell5"
            Me.xrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F)
            Me.xrTableCell5.StylePriority.UsePadding = False
            Me.xrTableCell5.Text = "xrTableCell5"
            Me.xrTableCell5.Weight = 0.4R
            ' 
            ' xrTableCell6
            ' 
            Me.xrTableCell6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Address]")})
            Me.xrTableCell6.Multiline = True
            Me.xrTableCell6.Name = "xrTableCell6"
            Me.xrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F)
            Me.xrTableCell6.StylePriority.UsePadding = False
            Me.xrTableCell6.Text = "xrTableCell6"
            Me.xrTableCell6.Weight = 0.4R
            ' 
            ' xrTableCell7
            ' 
            Me.xrTableCell7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Phone]")})
            Me.xrTableCell7.Multiline = True
            Me.xrTableCell7.Name = "xrTableCell7"
            Me.xrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F)
            Me.xrTableCell7.StylePriority.UsePadding = False
            Me.xrTableCell7.Text = "xrTableCell7"
            Me.xrTableCell7.Weight = 0.4R
            ' 
            ' xrTableCell8
            ' 
            Me.xrTableCell8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "FormatString('{0}, {1}', [ContactName], [ContactTitle])")})
            Me.xrTableCell8.Multiline = True
            Me.xrTableCell8.Name = "xrTableCell8"
            Me.xrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F)
            Me.xrTableCell8.StylePriority.UsePadding = False
            Me.xrTableCell8.Text = "xrTableCell8"
            Me.xrTableCell8.Weight = 0.4R
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[City]")})
            Me.xrLabel2.Font = New System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold)
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(50F, 10.00001F)
            Me.xrLabel2.Multiline = True
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(150F, 25F)
            Me.xrLabel2.StylePriority.UseFont = False
            Me.xrLabel2.Text = "xrLabel1"
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel2})
            Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("City", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WholePage
            Me.GroupHeader1.HeightF = 35.00001F
            Me.GroupHeader1.KeepTogether = True
            Me.GroupHeader1.Name = "GroupHeader1"
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail, Me.GroupHeader1, Me.GroupHeader2})
            Me.Font = New System.Drawing.Font("Arial", 9.75F)
            Me.Version = "18.2"
            CType((Me.xrTable2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private xrTable2 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell

        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel

        Private GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand

        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel

        Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    End Class
End Namespace
