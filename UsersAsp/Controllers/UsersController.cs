using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using UsersAsp.Models;
using UsersAsp.ViewModels;

namespace UsersAsp.Controllers
{
    [RoutePrefix("users")]
    public class UsersController : Controller
    {
        [Route("Random")]
        public async Task<ActionResult> Random()
        {
            using(var context = new UsersContext())
            {
                ViewData["Titolo"] = "Get One Random";
                ViewBag.Titolo = "Get One Random";
                int count = await context.Users.CountAsync();
                Random rnd = new Random();
                int toSkip = rnd.Next(0,count-1);

                User u = await context.Users
                    .OrderBy(o=>o.Id)
                    .Skip(toSkip).FirstOrDefaultAsync();

                return View( new RandomViewModel
                {
                    Titolo = "Get One Random",
                    User = u
                });
            }
        }

        [Route("")]
        public async Task<ActionResult> Index()
        {
            //return View();
            //return Content("Questo è un ContentResult");
            //return Redirect("https://www.google.com");
            //return RedirectToAction("Index","Home");
            //return HttpNotFound();
            //return Json("Questo è un JsonResult");
            //return File()
            //return new EmptyResult();
            using (var context = new UsersContext())
            {
                return View(await context.Users.ToListAsync());
            }
        }

        [Route("{id}")]
        public async Task<ActionResult> GetOne(int id)
        {
            using (var context = new UsersContext())
            {
                ViewData["Titolo"] = "Get One By Id";
                ViewBag.Titolo = "Get One By Id";
                User u = await context.Users.FirstOrDefaultAsync(q => q.Id == id);
                return View("Random",new RandomViewModel
                {
                    Titolo = "Get One By Id",
                    User = u
                });
            }
        }

        [Route("byusername/{username}")]
        public async Task<ActionResult> GetOneByUsername(string username)
        {
            using (var context = new UsersContext())
            {
                ViewData["Titolo"] = "Get One By Username";
                ViewBag.Titolo = "Get One By Username";
                User u = await context.Users.FirstOrDefaultAsync(q => q.Username.ToLower() == username.ToLower());
                return View("Random", new RandomViewModel
                {
                    Titolo = "Get One By Username",
                    User = u
                });
            }
        }
    }
}