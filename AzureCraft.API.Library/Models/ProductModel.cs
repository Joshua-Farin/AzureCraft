﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureCraft.API.Library.Models
{
	public class ProductModel
	{
		//The unique identifier for a given product

		public int Id { get; set; }
		public string ProductName { get; set; }
		public string Description { get; set; }
		public decimal RetailPrice { get; set; }
		public int QuantityInStock { get; set; }
		public bool IsTaxable { get; set; }
		public string ProductImage { get; set; }
	}
}
