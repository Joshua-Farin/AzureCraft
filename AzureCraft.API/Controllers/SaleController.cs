using AzureCraft.API.Library.DataAccess;
using AzureCraft.API.Library.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AzureCraft.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	[Authorize]
	public class SaleController : ControllerBase
	{
		private readonly ISaleData _saleData;

		public SaleController(ISaleData saleData)
		{
			_saleData = saleData;
		}
		[Authorize(Roles = "Cashier")]
		[HttpPost]
		public void Post(SaleModel sale)
		{
			string userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // old way - RequestContext.Principal.Identity.GetUserId();

			_saleData.SaveSale(sale, userId);
		}

		[Authorize(Roles = "Admin,Manager")]
		[Route("GetSalesReport")]
		[HttpGet]
		public List<SaleReportModel> GetSaleReport()
		{
			return _saleData.GetSaleReport();
		}

		[AllowAnonymous]
		[Route("GetTaxRate")]
		[HttpGet]
		public decimal GetTaxRate()
		{
			return _saleData.GetTaxRate();
		}
	}
}
