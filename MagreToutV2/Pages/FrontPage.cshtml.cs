using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using FusionCharts.DataEngine;
using FusionCharts.Visualization;

namespace MalgreToutV2.Pages {
    public class FrontPageModel : PageModel {
        //private readonly ILogger<IndexModel> _logger;

        //public FrontPageModel(ILogger<IndexModel> logger) {
        //    _logger = logger;
        //}


        public string ChartJson { get; internal set; }
        public void OnGet() {

            // create data table to store data
            DataTable ChartData = new DataTable();
            // Add columns to data table
            ChartData.Columns.Add("Company for advertisement", typeof(System.String));
            ChartData.Columns.Add("Advertisement Price", typeof(System.Double));
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
            column.Caption.Text = "Advertisements for the different companies";
            // Set chart sub title
            column.SubCaption.Text = "2020 - 2021";
            // hide chart Legend
            column.Legend.Show = false;
            // set XAxis Text
            column.XAxis.Text = "Company";
            // Set YAxis title
            column.YAxis.Text = "Money";
            // set chart theme
            column.ThemeName = FusionChartsTheme.ThemeName.FUSION;
            // set chart rendering json
            ChartJson = column.Render();
        }
    }
}
