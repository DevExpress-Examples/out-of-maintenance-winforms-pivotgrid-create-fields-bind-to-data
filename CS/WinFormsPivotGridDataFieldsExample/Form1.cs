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
                DataBinding = new DataSourceColumnBinding("CategoryName")
            };
            PivotGridField fieldProductName = new PivotGridField() {
                Area = PivotArea.RowArea,
                AreaIndex = 1,
                Caption = "Product Name",
                DataBinding = new DataSourceColumnBinding("ProductName")
            };
            PivotGridField fieldExtendedPrice = new PivotGridField()
            {
                Area = PivotArea.DataArea,
                AreaIndex = 0,
                Caption = "Extended Price",
                DataBinding = new DataSourceColumnBinding("Extended Price")
    };
            // Specify the field format.
            fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            fieldExtendedPrice.CellFormat.FormatString = "c2";

            PivotGridField fieldOrderDate1 = new PivotGridField()
            {
                Area = PivotArea.ColumnArea,
                AreaIndex = 0,
                Caption = "Year",
                DataBinding = new DataSourceColumnBinding("OrderDate", PivotGroupInterval.DateYear)
            };
            PivotGridField fieldOrderDate2 = new PivotGridField()
            {
                Area = PivotArea.ColumnArea,
                AreaIndex = 1,
                Caption = "Quarter",
                DataBinding = new DataSourceColumnBinding("OrderDate", PivotGroupInterval.DateQuarter)
            };
            PivotGridField fieldCountry = new PivotGridField()
            {
                AreaIndex = 0,
                Caption = "Country",
                DataBinding = new DataSourceColumnBinding("Country")
            };
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
