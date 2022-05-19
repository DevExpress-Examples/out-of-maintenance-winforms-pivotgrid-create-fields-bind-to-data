Imports DevExpress.DataAccess.Excel
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid
Imports System

Namespace WinFormsPivotGridDataFieldsExample
	Partial Public Class Form1
		Inherits XtraForm

		Public Sub New()
			InitializeComponent()
			AddHandler Me.Load, AddressOf Form1_Load
			' Create the Excel Data Source.
			Dim ds As New ExcelDataSource()
			ds.FileName = "SalesPerson.xlsx"
			Dim settings As New ExcelWorksheetSettings("Data")
			ds.SourceOptions = New ExcelSourceOptions(settings)
			ds.Fill()
			' Set the pivot's data source.
			pivotGridControl1.DataSource = ds
			' Create pivot grid fields.
			Dim fieldCategoryName As New PivotGridField() With {
				.Area = PivotArea.RowArea,
				.AreaIndex = 0,
				.Caption = "Category Name",
				.DataBinding = New DataSourceColumnBinding("CategoryName")
			}
			Dim fieldProductName As New PivotGridField() With {
				.Area = PivotArea.RowArea,
				.AreaIndex = 1,
				.Caption = "Product Name",
				.DataBinding = New DataSourceColumnBinding("ProductName")
			}
			Dim fieldExtendedPrice As New PivotGridField() With {
				.Area = PivotArea.DataArea,
				.AreaIndex = 0,
				.Caption = "Extended Price",
				.DataBinding = New DataSourceColumnBinding("Extended Price")
			}
			' Specify the field format.
			fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			fieldExtendedPrice.CellFormat.FormatString = "c2"

			Dim fieldOrderDate1 As New PivotGridField() With {
				.Area = PivotArea.ColumnArea,
				.AreaIndex = 0,
				.Caption = "Year",
				.DataBinding = New DataSourceColumnBinding("OrderDate", PivotGroupInterval.DateYear)
			}
			Dim fieldOrderDate2 As New PivotGridField() With {
				.Area = PivotArea.ColumnArea,
				.AreaIndex = 1,
				.Caption = "Quarter",
				.DataBinding = New DataSourceColumnBinding("OrderDate", PivotGroupInterval.DateQuarter)
			}
			Dim fieldCountry As New PivotGridField() With {
				.AreaIndex = 0,
				.Caption = "Country",
				.DataBinding = New DataSourceColumnBinding("Country")
			}
			' Add fields to the pivot grid.
			pivotGridControl1.Fields.AddRange(New PivotGridField() { fieldCategoryName, fieldProductName, fieldOrderDate1, fieldOrderDate2, fieldExtendedPrice, fieldCountry})
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
			pivotGridControl1.BestFit()
		End Sub
	End Class
End Namespace
