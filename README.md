# Easy way to Customize the Appearance of WinUI DataGrid

This demo shows the easy way to customize the appearance of WinUI SfDataGrid.

## Overview

The Syncfusion WinUI DataGrid is used to display and manipulate tabular data. Its rich feature set includes functionalities like data binding, editing, sorting, filtering, and grouping. It has also been optimized to work with millions of records, as well as to handle high-frequency, real-time updates.This sample demonstrates how to use built-in resources and styling capabilities to modify various visual aspects of the SfDataGrid.

## Key Features Demonstrated

### 1. **Resource-Based Customization**

The sample uses Syncfusion's resource dictionary keys to customize the appearance of the DataGrid. By defining `SolidColorBrush` resources with specific keys in the `SfDataGrid.Resources` section, you can easily change colors for different parts of the grid:

**XAML**
```
<dataGrid:SfDataGrid.Resources>
    <SolidColorBrush x:Key="SyncfusionDataGridRowControlForeground" Color="DarkBlue"/>
    <SolidColorBrush x:Key="SyncfusionGridStackedHeaderCellControlBackground" Color="Red"/>
    <SolidColorBrush x:Key="SyncfusionGridStackedHeaderCellControlForeground" Color="White"/>
    <SolidColorBrush x:Key="SyncfusionGridHeaderCellControlBackground" Color="Red"/>
    <SolidColorBrush x:Key="SyncfusionGridHeaderCellControlForeground" Color="White"/>
    <SolidColorBrush x:Key="SyncfusionDataGridRowSelectedBackground" Color="DarkGray"/>
    <SolidColorBrush x:Key="SyncfusionDataGridRowSelectedForeground" Color="White"/>
    <SolidColorBrush x:Key="SyncfusionDataGridCurrentCellBorderBrush" Color="DarkBlue"/>
    <Thickness x:Key="SyncfusionDataGridCurrentCellBorderThickness">2</Thickness>
    <SolidColorBrush x:Key="SyncfusionUnboundRowControlBackground" Color="SkyBlue"/>
    <SolidColorBrush x:Key="SyncfusionUnboundRowControlForeground" Color="DeepPink"/>
    <SolidColorBrush x:Key="SyncfusionGridRowHeaderCellBackground" Color="Gray"/>
    <SolidColorBrush x:Key="SyncfusionGridRowHeaderIndentCellBackground" Color="Gray"/>
    <SolidColorBrush x:Key="SyncfusionDataGridRowHeaderCellCurrentRowIconFill" Color="White"/>
</dataGrid:SfDataGrid.Resources>
```

### 2. **Customizable Elements**

This sample customizes the following visual aspects:

- **Row Foreground**: Changes the text color of data rows
- **Header Background and Foreground**: Customizes the appearance of column headers
- **Stacked Header Styling**: Applies custom colors to stacked header rows
- **Selected Row Background and Foreground**: Modifies the appearance of selected rows
- **Current Cell Border**: Customizes the border color and thickness of the active cell
- **Unbound Row Styling**: Changes the appearance of unbound rows (summary rows)
- **Row Header Styling**: Customizes the appearance of row headers

### 3. **DataGrid Configuration**

The DataGrid is configured with:

- `AutoGenerateColumns="False"` - Columns are explicitly defined
- `ShowRowHeader="True"` - Row headers are displayed
- `ColumnWidthMode="Auto"` - Columns automatically adjust width based on content
- **Stacked Headers**: Multiple columns are grouped under category headers (Order Details, Customer Details, Shipping Details)
- **Unbound Rows**: Summary rows are added at the bottom to display aggregate information

### 4. **Unbound Rows**

The sample demonstrates how to handle unbound rows (rows not bound to data) using the `QueryUnboundRow` event:

**C#**
```
private void SfDataGrid_QueryUnboundRow(object sender, GridUnboundRowEventsArgs e)
{
    if (e.UnboundAction == UnboundActions.QueryData)
    {
        if (e.RowColumnIndex.ColumnIndex == 4)
        {
            e.Value = "Total Orders:";
            e.Handled = true;
        }
        else if (e.RowColumnIndex.ColumnIndex == 5)
        {
            e.Value = (this.sfDataGrid.View.Records.Count).ToString();
            e.Handled = true;
        }
    }
}
```

## Usage

To apply custom appearance to the SfDataGrid in your application:

1. Define the resource keys with custom colors and styles within the `SfDataGrid.Resources` section
2. Use the appropriate resource key names to override the default appearance
3. Bind your data to the `ItemsSource` property
4. Define columns explicitly using `GridTextColumn` or other column types
5. Handle events like `QueryUnboundRow` for dynamic data in unbound rows

## Reference

For more information about the WinUI DataGrid control and its features, refer to the [Syncfusion WinUI DataGrid documentation](https://help.syncfusion.com/winui/datagrid/overview).
