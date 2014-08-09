using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DemoIISAPI.Models;

namespace DemoIISAPI.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            using (var context =new BloggingContext())
            {
                context.Blogs.Add(new Blog() { Name = "Blog demo" });
                context.Blogs.Add(new Blog() { Name = "Blog demo 1" });

                await context.SaveChangesAsync();

                var blogs = await context.Blogs.ToListAsync();
                return View(blogs);
            }
        }
    }
}
