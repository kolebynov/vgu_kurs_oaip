using Domain.Abstract;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IRepository<Country> repository)
        {
            m_repository = repository;
        }

        public ActionResult Index()
        {
            var contacts = m_repository.Entities.ToList();
            return View();
        }

        private IRepository<Country> m_repository;
    }
}