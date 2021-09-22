using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project.Domain.Models.IdentityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Project.Web.App.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, ActionName("Index")]
        public async Task<IActionResult> Index([FromForm] LoginIdentityModel model)
        {
            var host = "http://localhost:6000/api/auth/login";
            using (var client = new HttpClient())
            {
                var body = JsonConvert.SerializeObject(model);
                var content = new StringContent(body, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(host, content);
                return RedirectToAction("Index", "Home");
            }

        }
    }
}
