using EFBasics.IoC;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using EFBasics.Data;

namespace test.Controllers
{
    public class HomeController : Controller
    {
        public ApplicationDbContext Context { get; set; }

        public HomeController(ApplicationDbContext applicationDbContext)
        {
            Context = applicationDbContext;
        }
        
        public IActionResult Index()
        {
            if (!Context.Settings.Any())
            {
                Context.Settings.Add(new SettingsDataModel
                {
                    Name = "this is a name",
                    Value = "this is a value"
                });
                Context.SaveChanges();
            }

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
