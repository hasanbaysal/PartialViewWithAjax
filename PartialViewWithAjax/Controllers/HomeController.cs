using Microsoft.AspNetCore.Mvc;
using PartialViewWithAjax.Models;
using System.Diagnostics;

namespace PartialViewWithAjax.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public static List<Product> data = new List<Product>();



        public HomeController(ILogger<HomeController> logger)
        {
            if (!data.Any())
            {
                #region data fill

                data.Add(new() { Name = "product 1", Price = 10, Description = "product 1 is expensive" });
                data.Add(new() { Name = "product 2", Price = 20, Description = "product 2 is expensive" });
                data.Add(new() { Name = "product 3", Price = 30, Description = "product 3 is expensive" });
                data.Add(new() { Name = "product 4", Price = 40, Description = "product 4 is expensive" });
                data.Add(new() { Name = "product 5", Price = 50, Description = "product 5 is expensive" });
                data.Add(new() { Name = "product 6", Price = 60, Description = "product 6 is expensive" });
                data.Add(new() { Name = "product 7", Price = 70, Description = "product 7 is expensive" });
                data.Add(new() { Name = "product 8", Price = 70, Description = "product  8 is expensive" });
                data.Add(new() { Name = "product 9", Price = 70, Description = "product  9 is expensive" });
                data.Add(new() { Name = "product 10", Price = 70, Description = "product 10 is expensive" });
                data.Add(new() { Name = "product 4", Price = 40, Description = "product 4 is expensive" });
                data.Add(new() { Name = "product 5", Price = 50, Description = "product 5 is expensive" });
                data.Add(new() { Name = "product 6", Price = 60, Description = "product 6 is expensive" });
                data.Add(new() { Name = "product 7", Price = 70, Description = "product 7 is expensive" });
                data.Add(new() { Name = "product 8", Price = 70, Description = "product  8 is expensive" });
                data.Add(new() { Name = "product 9", Price = 70, Description = "product  9 is expensive" });
                data.Add(new() { Name = "product 10", Price = 70, Description = "product 10 is expensive" });
                data.Add(new() { Name = "product 11", Price = 70, Description = "product 11 is expensive" });
                data.Add(new() { Name = "product 12", Price = 70, Description = "product 12 is expensive" });
                data.Add(new() { Name = "product 13", Price = 70, Description = "product 13 is expensive" });
                data.Add(new() { Name = "product 14", Price = 70, Description = "product 14 is expensive" });
                data.Add(new() { Name = "product 8", Price = 70, Description = "product  8 is expensive" });
                data.Add(new() { Name = "product 9", Price = 70, Description = "product  9 is expensive" });
                data.Add(new() { Name = "product 10", Price = 70, Description = "product 10 is expensive" });
                data.Add(new() { Name = "product 4", Price = 40, Description = "product 4 is expensive" });
                data.Add(new() { Name = "product 5", Price = 50, Description = "product 5 is expensive" });
                data.Add(new() { Name = "product 6", Price = 60, Description = "product 6 is expensive" });
                data.Add(new() { Name = "product 7", Price = 70, Description = "product 7 is expensive" });
                data.Add(new() { Name = "product 8", Price = 70, Description = "product  8 is expensive" });
                data.Add(new() { Name = "product 9", Price = 70, Description = "product  9 is expensive" });
                data.Add(new() { Name = "product 10", Price = 70, Description = "product 10 is expensive" });
                data.Add(new() { Name = "product 11", Price = 70, Description = "product 11 is expensive" });
                data.Add(new() { Name = "product 12", Price = 70, Description = "product 12 is expensive" });
                data.Add(new() { Name = "product 13", Price = 70, Description = "product 13 is expensive" });
                data.Add(new() { Name = "product 14", Price = 70, Description = "product 14 is expensive" });


                #endregion

            }


            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(data);
        }

      
        public IActionResult GetData(string id)
        {
            var mydata = data.Find(x => x.Id == id);

           
            return PartialView("_ProductPartialView",mydata);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}