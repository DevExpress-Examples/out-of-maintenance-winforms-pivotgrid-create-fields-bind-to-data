<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/172492655/21.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830458)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to Create the Fields and Bind the PivotGridControl to Data in Code

This example demonstrates how to create the [pivot grid fields](https://docs.devexpress.com/WindowsForms/1918) in code and specify their location and format. The PivotGridControl's data source is the [ExcelDataSource](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.Excel.ExcelDataSource) instance, created in code.

![screenshot](./images/screenshot.png)

API in this example:

* [PivotGridField](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridField) class
* [PivotArea](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotArea) enum
* [PivotGroupInterval](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotGroupInterval) enum
* [FormatInfo](https://docs.devexpress.com/CoreLibraries/DevExpress.Utils.FormatInfo) class
* [PivotGridFieldFilterValues](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotGridFieldFilterValues) class
* [PivotGridControl.BestFit](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.BestFit) method

**See also:**

* [Pivot Grid Fields](https://docs.devexpress.com/WindowsForms/1918)
