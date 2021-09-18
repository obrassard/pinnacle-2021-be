﻿using System;

namespace Pinnacle_2021.Contracts.Requests
{
	public record AddItemRequest
	{
		public string Upc { get; set; }
		public int Quantity { get; set; }
		public DateTime? Expiration { get; set; }
	}
}
