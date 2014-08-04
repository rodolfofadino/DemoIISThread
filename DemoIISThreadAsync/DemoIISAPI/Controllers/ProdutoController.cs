using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using DemoIISAPI.Models;
using DemoIISAPI.Utility;

namespace DemoIISAPI.Controllers
{
    public class ProdutoController : ApiController
    {
        public async Task<IEnumerable<Produto>> GetAllProducts(CancellationToken cancelToken)
        {
            await Task.Delay(Util.GetDelay(), cancelToken);
            return Produto.GetProducts();
        }
    }
}
