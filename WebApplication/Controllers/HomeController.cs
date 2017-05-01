using Domain.Abstract;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IRepository<Contact> repository)
        {
            m_repository = repository;
        }

        public ActionResult Index()
        {
            return View();
        }

        private IRepository<Contact> m_repository;
    }
}