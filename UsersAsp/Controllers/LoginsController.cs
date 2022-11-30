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
    [RoutePrefix("logins")]
    public class LoginsController : Controller
    {
        //[Route("index")]
        /*public ActionResult Index()
        {
            return RedirectToAction("Index?page=1");
        }*/

        //[Route("index/{page}")]
        public async Task<ActionResult> Index(int page=1)
        {
            int pageSize = 15;

            if (page < 1) page = 1;

            using (var context = new UsersContext())
            {
                var retVal = await context.Logins
                    .Include("User")
                    .OrderByDescending(ob=>ob.Date)
                    .Skip( (page-1)*pageSize )
                    .Take(pageSize)
                    .ToListAsync();

                int totalPages = await context.Logins.CountAsync();
                int pages = (int) Math.Ceiling( (double)totalPages / pageSize); 


                return View(new PaginatedDataViewModel<Login>
                {
                    Page = page,
                    Pages = pages,
                    Data = retVal
                });
            }
        }

        [Route("details/{id}")]
        public async Task<ActionResult> Details(int id)
        {
            using (var context = new UsersContext())
            {
                var retVal = await context.Logins
                    .Include("User")
                    .FirstOrDefaultAsync(q => q.Id == id);
                return View(retVal);
            }
        }

        [Route("create")]
        public async Task<ActionResult> Create()
        {
            using (var context = new UsersContext())
            {
                var users = await context.Users
                    .Select(s => new SelectListItem
                    {
                        Value = s.Id.ToString(),
                        Text = s.LastName + " " + s.FirstName
                    })
                    .ToListAsync();

                ViewBag.Users = users;

                return View();
            }
        }

        [HttpPost]
        [Route("create")]
        public async Task<ActionResult> Create(Login l)
        {
            using (var context = new UsersContext())
            {
                context.Logins.Add(l);
                await context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }

        [Route("edit/{id}")]
        public async Task<ActionResult> Edit(int id)
        {
            using (var context = new UsersContext())
            {
                var retVal = await context.Logins
                    //.Include("User")
                    .FirstOrDefaultAsync(q=>q.Id==id);

                var users = await context.Users
                    .Select(s => new SelectListItem
                    {
                        Value = s.Id.ToString(),
                        Text = s.LastName + " " + s.FirstName
                    })
                    .ToListAsync();

                ViewBag.Users = users;
                return View(retVal);
            }
        }

        [HttpPost]
        [Route("edit/{id}")]
        public async Task<ActionResult> Edit(int id, Login l)
        {
            using (var context = new UsersContext())
            {
                var candidate = await context.Logins
                    .FirstOrDefaultAsync(q => q.Id == id);

                candidate.UserId = l.UserId;
                candidate.Date = l.Date;
                candidate.Note = l.Note;
                candidate.LoginSuccessful = l.LoginSuccessful;

                await context.SaveChangesAsync();

                return RedirectToAction("Index");
            }

        }

        [Route("delete/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            using (var context = new UsersContext())
            {
                var retVal = await context.Logins
                    .Include("User")
                    .FirstOrDefaultAsync(q => q.Id == id);
                return View(retVal);
            }
        }

        [HttpPost]
        [Route("delete/{id}")]
        public async Task<ActionResult> DeleteExec(int id)
        {
            using (var context = new UsersContext())
            {
                var candidate = await context.Logins
                    .FirstOrDefaultAsync(q => q.Id == id);

                context.Logins.Remove(candidate);

                await context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }
    }
}