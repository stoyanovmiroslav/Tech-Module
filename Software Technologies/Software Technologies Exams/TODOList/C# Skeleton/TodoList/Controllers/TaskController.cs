﻿using System;
using System.Linq;
using System.Web.Mvc;
using TodoList.Models;

namespace TodoList.Controllers
{
        [ValidateInput(false)]
	public class TaskController : Controller
	{
        private TodoListDbContext db = new TodoListDbContext();

        [HttpGet]
        [Route("")]
	    public ActionResult Index()
	    {
	         var tasks = db.Tasks.ToList();
            return View(tasks);
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
		{
            return View(new Task());
        }

		[HttpPost]
		[Route("create")]
        [ValidateAntiForgeryToken]
		public ActionResult Create(Task task)
		{
            if (this.ModelState.IsValid)
            {
                db.Tasks.Add(task);
                db.SaveChanges();
                return Redirect("/");
            }

            return View(task);
        }

		[HttpGet]
		[Route("delete/{id}")]
        public ActionResult Delete(int id)
		{
            var task = db.Tasks.Find(id);
            if (task == null)
                return HttpNotFound();

            return View(task);
        }

		[HttpPost]
		[Route("delete/{id}")]
        [ValidateAntiForgeryToken]
		public ActionResult DeleteConfirm(int id)
		{
            var taskFromDb = db.Tasks.Find(id);
            if (taskFromDb == null)
                return HttpNotFound();

            db.Tasks.Remove(taskFromDb);
            db.SaveChanges();
            return Redirect("/");
        }
	}
}