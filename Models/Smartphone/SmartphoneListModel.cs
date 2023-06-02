﻿namespace GadgetBlitzPZ.Models.Smartphone
{
	public class SmartphoneListModel
	{
		public string? id { get; set; }
		public string? name { get; set; }
		public double? size { get; set; }
		public int? battery { get; set; }
		public string? system { get; set; }
		public int? storage { get; set; }
		public List<string>? urls { get; set; }
		public double? price { get; set; }

		public int rating = 5;
	}
}
