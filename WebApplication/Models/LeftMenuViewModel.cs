using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class LeftMenuViewModel
    {
        public IEnumerable<SectionMenuElement> MenuElements { get; set; }
    }
}