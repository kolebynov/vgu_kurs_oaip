using Domain.Concrete;

namespace WebApplication.Models
{
    public class GridColumn
    {
        public EntityColumn EntityColumn { get; set; }
        public double GridWidth { get; set; }
    }
}