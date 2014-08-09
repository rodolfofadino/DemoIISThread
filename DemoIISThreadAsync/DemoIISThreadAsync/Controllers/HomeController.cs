using System.Threading;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.UI;

namespace DemoIISThreadAsync.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var produtoService = new Services.ProdutoService();

            return View(produtoService.GetProdutos());
        }

        public async  Task<ActionResult> IndexAsync()
        {
            var produtoService = new Services.ProdutoService();

            return View(await produtoService.GetProdutosAsync());
        }
        
    }
}