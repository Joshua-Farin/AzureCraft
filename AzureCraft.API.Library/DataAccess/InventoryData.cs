﻿using AzureCraft.API.Library.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureCraft.API.Library.DataAccess
{
	public class InventoryData : IInventoryData
	{
		private readonly IConfiguration _config;
		private readonly ISqlDataAccess _sql;
		public InventoryData(IConfiguration config, ISqlDataAccess sql)
		{
			_config = config;
			_sql = sql;
		}
		public List<InventoryModel> GetInventory()
		{
			var output = _sql.LoadData<InventoryModel, dynamic>("dbo.spInventory_GetAll", new { }, "AzureCraftData");

			return output;
		}

		public void SaveInventoryRecord(InventoryModel item)
		{
			_sql.SaveData("dbo.spInventory_Insert", item, "AzureCraftData");
		}
	}
}
