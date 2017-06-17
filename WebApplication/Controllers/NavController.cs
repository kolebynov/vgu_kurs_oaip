using Domain.Concrete;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;
using WebApplication.Resources;

namespace WebApplication.Controllers
{
    public class NavController : Controller
    {
        public ActionResult LeftMenu()
        {
            return PartialView(new LeftMenuViewModel
            {
                MenuElements = _sectionSchemaNames.Select(name => new SectionMenuElement
                {
                    Caption = SectionMenuItemCaptions.ResourceManager.GetString(name),
                    IsSelected = false,
                    Name = name
                })
            });
        }
        public ActionResult RightMenu()
        {
            return PartialView();
        }

        private static string[] _sectionSchemaNames = { nameof(Contact),
            nameof(Tour), nameof(BookedTour) };
    }
}