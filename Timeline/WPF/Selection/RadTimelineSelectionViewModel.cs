﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Selection
{
    public class RadTimelineSelectionViewModel
    {
		public RadTimelineSelectionViewModel()
		{
			this.PeriodStart = new DateTime(2011, 1, 1);
			this.PeriodEnd = new DateTime(2012, 1, 1);

			this.GenerateTimelineData();
		}

		public DateTime PeriodStart { get; set; }

		public DateTime PeriodEnd { get; set; }

		public List<RadTimelineDataItem> TimelineItems { get; set; }

		private void GenerateTimelineData()
		{
			Random r = new Random();
			List<RadTimelineDataItem> items = new List<RadTimelineDataItem>();

			for (DateTime date = this.PeriodStart; date < this.PeriodEnd; date = date.AddDays(1))
			{
				items.Add(new RadTimelineDataItem() { StartDate = date, Duration = TimeSpan.FromDays(r.Next(0, 10)) });
			}

			this.TimelineItems = items;
		}
    }
}
