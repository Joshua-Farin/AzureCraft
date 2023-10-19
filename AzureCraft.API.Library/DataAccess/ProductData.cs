using AzureCraft.API.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureCraft.API.Library.DataAccess
{
	public class ProductData : IProductData
	{
		private readonly ISqlDataAccess _sql;
		public ProductData(ISqlDataAccess sql)
		{
			_sql = sql;
		}
		public List<ProductModel> GetProducts()
		{
			var output = _sql.LoadData<ProductModel, dynamic>("dbo.spProduct_GetAll", new { }, "AzureCraftData");

			return output;
		}

		public ProductModel GetProductById(int productId)
		{
			var output = _sql.LoadData<ProductModel, dynamic>("dbo.spProduct_GetById", new { Id = productId }, "AzureCraftData").FirstOrDefault();

			return output;
		}
	}
}
