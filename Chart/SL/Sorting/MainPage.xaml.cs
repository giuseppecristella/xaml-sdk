﻿using System.Collections.Generic;
using System.Windows.Controls;

namespace Sorting
{
	public partial class MainPage : UserControl
	{
		public MainPage()
		{
			InitializeComponent();
			this.DataContext = new List<ProductSales>()
			{
				new ProductSales { ID = 1, Quantity = 154 },
				new ProductSales { ID = 2, Quantity = 138 },
				new ProductSales { ID = 3, Quantity = 143 },
				new ProductSales { ID = 4, Quantity = 120 },
				new ProductSales { ID = 5, Quantity = 135 },
				new ProductSales { ID = 6, Quantity = 125 },
				new ProductSales { ID = 7, Quantity = 179 },
				new ProductSales { ID = 8, Quantity = 170 },
				new ProductSales { ID = 9, Quantity = 198 },
				new ProductSales { ID = 10, Quantity = 187 },
				new ProductSales { ID = 11, Quantity = 193 },
				new ProductSales { ID = 12, Quantity = 212 },
			};
		}
	}
}
