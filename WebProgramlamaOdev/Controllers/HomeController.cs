using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebProgramlamaOdev.Models;

namespace WebProgramlamaOdev.Controllers
{
    public class HomeController : Controller
    {
        

        Context context = new Context();
       
        [Authorize]
        public IActionResult Index(string searchString)
        {
            User currentUser;
            if (HttpContext.User.Identity.IsAuthenticated)
            {

                var email = HttpContext.User.Claims.FirstOrDefault().Value;
                currentUser = context.USER.FirstOrDefault(u => u.USER_MAIL == email);

            }

            else
            {
                 currentUser = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("SessionUser"));
            }

            
         
        

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
      
    }
}
