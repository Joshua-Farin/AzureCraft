using AzureCraft.API.Library.DataAccess;
using AzureCraft.API.Library.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AzureCraft.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	[Authorize(Roles = "Cashier")]
	public class ProductController : ControllerBase
	{
		private readonly IProductData _productData;
		public ProductController(IProductData productData)
		{
			_productData = productData;
		}
		[HttpGet]
		public List<ProductModel> Get()
		{
			var products = _productData.GetProducts();
			return products;
		}
	}
}
