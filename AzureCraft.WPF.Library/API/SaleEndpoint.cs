﻿using AzureCraft.WPF.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureCraft.WPF.Library.API
{
	public class SaleEndpoint : ISaleEndpoint
	{
		private IAPIHelper _apiHelper;
		public SaleEndpoint(IAPIHelper apiHelper)
		{
			_apiHelper = apiHelper;
		}

		public async Task PostSale(SaleModel sale)
		{
			using (HttpResponseMessage response = await _apiHelper.ApiClient.PostAsJsonAsync("/api/Sale", sale))
			{
				if (response.IsSuccessStatusCode)
				{
					// Log successful call?
				}
				else
				{
					throw new Exception(response.ReasonPhrase);
				}
			}
		}
	}
}
