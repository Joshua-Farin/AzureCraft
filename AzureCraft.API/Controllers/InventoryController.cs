using AzureCraft.API.Library.DataAccess;
using AzureCraft.API.Library.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AzureCraft.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	[Authorize]
	public class InventoryController : ControllerBase
	{
		private readonly IInventoryData _inventoryData;
		public InventoryController(IInventoryData inventoryData)
		{
			_inventoryData = inventoryData;
		}
		[Authorize(Roles = "Manager,Admin")]
		[HttpGet]
		public List<InventoryModel> Get()
		{
			return _inventoryData.GetInventory();
		}

		[Authorize(Roles = "Admin")]
		[HttpPost]
		public void Post(InventoryModel item)
		{
			_inventoryData.SaveInventoryRecord(item);
		}
	}
}
