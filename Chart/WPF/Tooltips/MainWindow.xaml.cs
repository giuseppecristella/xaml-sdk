﻿using System.Windows;

namespace Tooltips
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			this.DataContext = TradeData.GetWeeklyData();
		}
	}
}
