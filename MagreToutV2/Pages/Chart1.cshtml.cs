using System.Data;
using FusionCharts.DataEngine;
using FusionCharts.Visualization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FusionChartsRazorSamples.Pages
{
    public class IndexModel : PageModel
    {
        // create a public property. OnGet method() set the chart configuration json in this property.
        // When the page is being loaded, OnGet method will be  invoked
        public string ChartJson { get; internal set; }
        public void OnGet()
        {

            // create data table to store data
            DataTable ChartData = new DataTable();
            // Add columns to data table
            ChartData.Columns.Add("Firmaet det drejer sig om", typeof(System.String));
            ChartData.Columns.Add("Announce Pris", typeof(System.Double));
            // Add rows to data table

            ChartData.Rows.Add("Horse Medicine", 62000);
            ChartData.Rows.Add("Horse R' Us", 46000);
            ChartData.Rows.Add("Me myself and horse", 38000);
            ChartData.Rows.Add("Horse feeder 2000", 31000);
            ChartData.Rows.Add("Horse saddles", 27000);
            ChartData.Rows.Add("Sports Gear", 14000);
            ChartData.Rows.Add("Sport Master", 14000);

            // Create static source with this data table
            StaticSource source = new StaticSource(ChartData);
            // Create instance of DataModel class
            DataModel model = new DataModel();
            // Add DataSource to the DataModel
            model.DataSources.Add(source);
            // Instantiate Column Chart
            Charts.ColumnChart column = new Charts.ColumnChart("first_chart");
            // Set Chart's width and height
            column.Width.Pixel(700);
            column.Height.Pixel(400);
            // Set DataModel instance as the data source of the chart
            column.Data.Source = model;
            // Set Chart Title
            column.Caption.Text = "Reklame for de forskellige firmaer";
            // Set chart sub title
            column.SubCaption.Text = "2020 - 2021";
            // hide chart Legend
            column.Legend.Show = false;
            // set XAxis Text
            column.XAxis.Text = "Firma";
            // Set YAxis title
            column.YAxis.Text = "Penge";
            // set chart theme
            column.ThemeName = FusionChartsTheme.ThemeName.FUSION;
            // set chart rendering json
            ChartJson = column.Render();
        }
    }
}
