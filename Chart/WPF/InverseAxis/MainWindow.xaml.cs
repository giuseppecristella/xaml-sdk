﻿using System.Windows;
using Telerik.Windows.Controls.Charting;

namespace InverseAxis
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			telerikChart.DefaultView.ChartArea.AxisY.IsInverse = true;
			telerikChart.DefaultView.ChartArea.AxisX.IsInverse = true;

			//Line Chart
			DataSeries lineSeries = new DataSeries();
			lineSeries.LegendLabel = "Turnover";
			lineSeries.Definition = new LineSeriesDefinition();
			lineSeries.Add(new DataPoint() { YValue = 154, XCategory = "Jan" });
			lineSeries.Add(new DataPoint() { YValue = 138, XCategory = "Feb" });
			lineSeries.Add(new DataPoint() { YValue = 143, XCategory = "Mar" });
			lineSeries.Add(new DataPoint() { YValue = 120, XCategory = "Apr" });
			lineSeries.Add(new DataPoint() { YValue = 135, XCategory = "May" });
			lineSeries.Add(new DataPoint() { YValue = 125, XCategory = "Jun" });
			lineSeries.Add(new DataPoint() { YValue = 179, XCategory = "Jul" });
			lineSeries.Add(new DataPoint() { YValue = 170, XCategory = "Aug" });
			lineSeries.Add(new DataPoint() { YValue = 198, XCategory = "Sep" });
			lineSeries.Add(new DataPoint() { YValue = 187, XCategory = "Oct" });
			lineSeries.Add(new DataPoint() { YValue = 193, XCategory = "Nov" });
			lineSeries.Add(new DataPoint() { YValue = 176, XCategory = "Dec" });
			telerikChart.DefaultView.ChartArea.DataSeries.Add(lineSeries);

			//Bar Chart
			DataSeries barSeries = new DataSeries();
			barSeries.LegendLabel = "Expenses";
			barSeries.Definition = new BarSeriesDefinition();
			barSeries.Add(new DataPoint() { YValue = 45, XCategory = "Jan" });
			barSeries.Add(new DataPoint() { YValue = 48, XCategory = "Feb" });
			barSeries.Add(new DataPoint() { YValue = 53, XCategory = "Mar" });
			barSeries.Add(new DataPoint() { YValue = 41, XCategory = "Apr" });
			barSeries.Add(new DataPoint() { YValue = 32, XCategory = "May" });
			barSeries.Add(new DataPoint() { YValue = 28, XCategory = "Jun" });
			barSeries.Add(new DataPoint() { YValue = 63, XCategory = "Jul" });
			barSeries.Add(new DataPoint() { YValue = 74, XCategory = "Aug" });
			barSeries.Add(new DataPoint() { YValue = 77, XCategory = "Sep" });
			barSeries.Add(new DataPoint() { YValue = 85, XCategory = "Oct" });
			barSeries.Add(new DataPoint() { YValue = 89, XCategory = "Nov" });
			barSeries.Add(new DataPoint() { YValue = 80, XCategory = "Dec" });
			telerikChart.DefaultView.ChartArea.DataSeries.Add(barSeries);
		}
	}
}
