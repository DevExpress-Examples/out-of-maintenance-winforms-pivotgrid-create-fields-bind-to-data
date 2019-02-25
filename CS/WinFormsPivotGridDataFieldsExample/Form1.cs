using DevExpress.DataAccess.Excel;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;
using System;

namespace WinFormsPivotGridDataFieldsExample
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            // Create the Excel Data Source.
            ExcelDataSource ds = new ExcelDataSource();
            ds.FileName = "SalesPerson.xlsx";
            ExcelWorksheetSettings settings = new ExcelWorksheetSettings("Data");
            ds.SourceOptions = new ExcelSourceOptions(settings);
            ds.Fill();
            // Set the pivot's data source.
            pivotGridControl1.DataSource = ds;
            // Create pivot grid fields.
            PivotGridField fieldCategoryName = new PivotGridField()
            {
                Area = PivotArea.RowArea,
                AreaIndex = 0,
                Caption = "Category Name",
                FieldName = "CategoryName"
            };
            PivotGridField fieldProductName = new PivotGridField()
            {
                Area = PivotArea.RowArea,
                AreaIndex = 1,
                Caption = "Product Name",
                FieldName = "ProductName"
            };
            PivotGridField fieldExtendedPrice = new PivotGridField()
            {
                Area = PivotArea.DataArea,
                AreaIndex = 0,
                Caption = "Extended Price",
                FieldName = "Extended Price",
            };
            // Specify the field format.
            fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            fieldExtendedPrice.CellFormat.FormatString = "c2";

            PivotGridField fieldOrderDate1 = new PivotGridField()
            {
                Area = PivotArea.ColumnArea,
                AreaIndex = 0,
                Caption = "Year",
                GroupInterval = PivotGroupInterval.DateYear,
                FieldName = "OrderDate",
            };
            PivotGridField fieldOrderDate2 = new PivotGridField()
            {
                Area = PivotArea.ColumnArea,
                AreaIndex = 1,
                Caption = "Quarter",
                GroupInterval = PivotGroupInterval.DateQuarter,
                FieldName = "OrderDate"
            };
            PivotGridField fieldCountry = new PivotGridField()
            {
                AreaIndex = 0,
                Caption = "Country",
                FieldName = "Country"
            };
            // Create a field's filter.
            fieldCountry.FilterValues.Clear();
            fieldCountry.FilterValues.FilterType = PivotFilterType.Included;
            fieldCountry.FilterValues.Add("USA");
            // Add fields to the pivot grid.
            pivotGridControl1.Fields.AddRange(new PivotGridField[] {
            fieldCategoryName,
            fieldProductName,
            fieldOrderDate1,
            fieldOrderDate2,
            fieldExtendedPrice,
            fieldCountry});
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pivotGridControl1.BestFit();
        }
    }
}
