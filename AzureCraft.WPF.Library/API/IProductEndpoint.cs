using AzureCraft.WPF.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureCraft.WPF.Library.API
{
	public interface IProductEndpoint
	{
		Task<List<ProductModel>> GetAll();
	}
}
