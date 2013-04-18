﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace DataBindingToManyChartAreas
{
	public partial class MainPage : UserControl
	{
		public MainPage()
		{
			InitializeComponent();
			this.DataContext = new List<List<ChartData>>()
			{
				new List<ChartData>()
				{
					new ChartData { Description = "Internet Explorer", Value = 6792000 },
					new ChartData { Description = "Firefox", Value = 2549000 },
					new ChartData { Description = "Safari", Value = 270000 },
					new ChartData { Description = "Opera", Value = 270000 },
					new ChartData { Description = "Chrome", Value = 91000 },
					new ChartData { Description = "Other", Value = 27000 },
				},
				new List<ChartData>()
				{
					new ChartData { Description = "Internet Explorer", Value = 5971000 },
					new ChartData { Description = "Firefox", Value = 3048000 },
					new ChartData { Description = "Safari", Value = 310000 },
					new ChartData { Description = "Opera", Value = 262000 },
					new ChartData { Description = "Chrome", Value = 327000 },
					new ChartData { Description = "Other", Value = 83000 },
				}
			};
		}
	}
}
