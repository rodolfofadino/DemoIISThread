using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using DemoIISThreadAsync.Models;
using DemoIISThreadAsync.Utility;
using Newtonsoft.Json;

namespace DemoIISThreadAsync.Services
{
    public class ProdutoService
    {
        public List<Produto> GetProdutos()
        {
            var uri = Util.getServiceUri("produto"); ;
            using (WebClient webClient = new WebClient())
            {
                return JsonConvert.DeserializeObject<List<Produto>>(webClient.DownloadString(uri));
            }
        }
        public async Task<List<Produto>> GetProdutosAsync()
        {
            var uri = Util.getServiceUri("produto");
            using (HttpClient httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(uri);
                return (await response.Content.ReadAsAsync<List<Produto>>());
            }
        }

    }
}