using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebProje.Models;

namespace WebProje.Controllers.AdminPage
{
 public class AdminController : Controller
    {
        Context context = new Context();

        [Authorize(Roles="Admin")]
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult EditAbility(Models.Abilities ability)
        {
            context.ABILITY.Update(ability);
            context.SaveChanges();
            return Json("başarılı");
        }

        [HttpPost]
        public JsonResult DeleteAbility(Models.Abilities ability)
        {
            string errorMessage = "";
            try
            {
                context.ABILITY.Remove(ability);
            }
            catch (Exception e)
            {

                errorMessage = e.Message;
            }

            context.SaveChanges();

            if (errorMessage == "")
            {
                return Json("başarılı");
            }
            else
            {
                return Json("errorMessage");
            }

        }

        [HttpPost]
        public JsonResult EditStat(Models.Stat stat)
        {
            string errorMessage = "";
            try
            {
                context.Update(stat);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
            }

            if (errorMessage == "")
            {
                return Json("başarılı");
            }
            else
            {
                return Json(errorMessage);
            }

        }
        [HttpPost]
        public JsonResult DeleteStat(Models.Stat stat)
        {
            string errorMessage = "";

            try
            {
                context.Remove(stat);
                context.SaveChanges();
            }
            catch (Exception e)
            {

                errorMessage = e.Message;
                
            }

            if (errorMessage == "")
            {
                return Json("başarılı");
            }
            else
            {
                return Json(errorMessage);
            }

        }

        [HttpPost]
        public JsonResult DeleteType(Models.Type type)
        {
            string errorMessage = "";

            try
            {
                context.TYPE.Remove(type);
                context.SaveChanges();
            }
            catch (Exception e)
            {

                errorMessage = e.Message;
            }

            if (errorMessage == "")
            {
                return Json("başarılı");
            }
            else
            {
                return Json(errorMessage);
            }
        }

        [HttpPost]
        public JsonResult UpdateType(Models.Type type)
        {
            string errorMessage = "";

            try
            {
                context.TYPE.Update(type);
                context.SaveChanges();
            }
            catch (Exception e)
            {

                errorMessage = e.Message;
            }

            if (errorMessage == "")
            {
                return Json("başarılı");
            }
            else
            {
                return Json(errorMessage);
            }
        }

        [HttpPost]
        public JsonResult DeleteWeakness(Models.Weakness weakness)
        {
            string errorMessage = "";
            try
            {
                context.WEAKNESS.Remove(weakness);
                context.SaveChanges();
            }
            catch (Exception e)
            {

                errorMessage = e.Message;
            }

            if (errorMessage == "")
            {
                return Json("başarılı");
            }
            else
            {
                return Json(errorMessage);
            }

        }
        [HttpPost]
        public JsonResult EditWeakness(Models.Weakness weakness)
        {
            string errorMessage = "";

            try
            {
                context.Update(weakness);
                context.SaveChanges();
            }
            catch (Exception e)
            {

                errorMessage = e.Message;
            }

            if (errorMessage == "")
            {
                return Json("başarılı");
            }
            else
            {
                return Json(errorMessage);
            }
        }
        [HttpPost]
        public JsonResult EditPokemon(Models.Pokemon pokemon)
        {
            string errorMessage = "";

            try
            {
                context.POKEMON.Update(pokemon);
                context.SaveChanges();
            }
            catch (Exception e)
            {

                errorMessage = e.Message;
            }

            if (errorMessage == "")
            {
                return Json("başarılı");
            }
            else
            {
                return Json(errorMessage);
            }
        }
        [HttpPost]
        public JsonResult DeletePokemon(Models.Pokemon pokemon)
        {
            string errorMessage = "";
            try
            {
                context.POKEMON.Remove(pokemon);
                context.SaveChanges();
            }
            catch (Exception e)
            {

                errorMessage = e.Message;
            }

            if (errorMessage == "")
            {
                return Json("başarılı");
            }
            else
            {
                return Json(errorMessage);
            }
        }
    }
  }

