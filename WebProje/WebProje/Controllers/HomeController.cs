using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using WebProje.Models;

namespace WebProje.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly ILogger<HomeController> _logger;
        private readonly IStringLocalizer _localizer;
        private readonly IStringLocalizer<SharedResources> _sharedLocalizer;
        public HomeController(ILogger<HomeController> logger, IStringLocalizer<HomeController> localizer, IStringLocalizer<SharedResources> sharedLocalizer)
        {
            _localizer = localizer;
            _sharedLocalizer = sharedLocalizer;
            _logger = logger;
        }

        Context context = new Context();
        [Authorize]
        public IActionResult Index(string searchString)
        {

            ViewData["Message"] = _sharedLocalizer["Merhaba"];
            if (searchString == null)
            {
                var pokemons = context.POKEMON.ToList();

                return View(pokemons);
            }
            else
            {
                var pokemons = context.POKEMON.Where(p => p.POKEMON_NAME.Contains(searchString)).ToList();
                return View(pokemons);
            }

        }
        [HttpPost]
        public IActionResult Cookie(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.Now.AddDays(10) }
                );
            return LocalRedirect(returnUrl);
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
