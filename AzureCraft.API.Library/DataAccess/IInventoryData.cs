using AzureCraft.API.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureCraft.API.Library.DataAccess
{
	public interface IInventoryData
	{
		List<InventoryModel> GetInventory();
		void SaveInventoryRecord(InventoryModel item);
	}
}
