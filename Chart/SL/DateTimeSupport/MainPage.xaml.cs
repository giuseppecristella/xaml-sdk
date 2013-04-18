﻿using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace DateTimeSupport
{
	public partial class MainPage : UserControl
	{
		public MainPage()
		{
			System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
			InitializeComponent();
			var itemsSource = new List<TradeData>()
			{
				new TradeData { FromDate = new DateTime(2012, 8, 10), Close = 23.42 },
				new TradeData { FromDate = new DateTime(2012, 8, 11), Close = 23.13 },
				new TradeData { FromDate = new DateTime(2012, 8, 12), Close = 23.53 },
				new TradeData { FromDate = new DateTime(2012, 8, 13), Close = 23.62 },
				new TradeData { FromDate = new DateTime(2012, 8, 14), Close = 23.69 },
				new TradeData { FromDate = new DateTime(2012, 8, 17), Close = 23.25 },
				new TradeData { FromDate = new DateTime(2012, 8, 18), Close = 23.58 },
				new TradeData { FromDate = new DateTime(2012, 8, 19), Close = 23.65 },
				new TradeData { FromDate = new DateTime(2012, 8, 20), Close = 23.67 },
				new TradeData { FromDate = new DateTime(2012, 8, 21), Close = 24.41 },
			};

			this.radChart.ItemsSource = itemsSource;
			this.radChart.DefaultView.ChartArea.AxisX.DefaultLabelFormat = "dd-MMM";
			this.radChart.DefaultView.ChartArea.AxisX.LabelRotationAngle = 45;
		}
	}
}
