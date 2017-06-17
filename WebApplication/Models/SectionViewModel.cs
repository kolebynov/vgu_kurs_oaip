using Domain.Model.Abstract;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public class SectionViewModel
    {
        public IEnumerable<BaseModel> Entities { get; set; }
        public IEnumerable<GridColumn> GridColumns { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string Caption { get; set; }
    }
}