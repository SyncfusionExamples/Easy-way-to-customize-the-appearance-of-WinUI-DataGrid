// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Syncfusion.UI.Xaml.DataGrid;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Notifications;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SyncFusionExample
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow() 
        {
            this.InitializeComponent();
            this.sfDataGrid.QueryUnboundRow += SfDataGrid_QueryUnboundRow;
        }

        private void SfDataGrid_QueryUnboundRow(object sender, GridUnboundRowEventsArgs e)
        {
            if (e.UnboundAction == UnboundActions.QueryData)
            {
                if (e.RowColumnIndex.ColumnIndex == 4)
                {
                    e.Value = "Total Orders:";
                    e.Handled= true;
                }
                else if (e.RowColumnIndex.ColumnIndex == 5)
                {
                    e.Value = (this.sfDataGrid.View.Records.Count).ToString();
                    e.Handled= true;
                }
            }
        }
    }
}
