using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WEB.UI.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonAppService _personAppService;

        public PersonController(IPersonAppService personAppService)
        {
            _personAppService = personAppService;
        }

        public ActionResult Index()
        {
            return View(_personAppService.GetAll());
        }

        public ActionResult Details(int id)
        {
            return View(_personAppService.GetById(id));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Person model)
        {
            try
            {
                _personAppService.Add(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }

        public ActionResult Edit(int id)
        {
            return View(_personAppService.GetById(id));
        }

        [HttpPost]
        public ActionResult Edit(int id, Person model)
        {
            try
            {
                _personAppService.Update(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }

        public ActionResult Delete(int id)
        {
            return View(_personAppService.GetById(id));
        }

        [HttpPost]
        public ActionResult Delete(int id, Person model)
        {
            try
            {
                _personAppService.Remove(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }
    }
}
