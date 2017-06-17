using Domain.Abstract;
using Domain.Concrete;
using Domain.Model;
using Domain.Model.Abstract;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApplication.Infrastructure;
using WebApplication.Models;
using WebApplication.Resources;

namespace WebApplication.Controllers
{
    public class SectionController : Controller
    {
        public SectionController(ITypeResolver typeResolver)
        {
            m_typeResolver = typeResolver;
        }

        public ActionResult Contact(int page = 1)
        {
            return SectionView<Contact>(page);
        }
        public ActionResult Tour(int page = 1)
        {
            return SectionView<Tour>(page);
        }
        public ActionResult BookedTour(int page = 1)
        {
            return SectionView<BookedTour>(page);
        }

        private ITypeResolver m_typeResolver;
        private int m_itemsPerPage = 15;

        private const string BASE_SECTION_NAME = "BaseSection";

        private ViewResult SectionView<TModel>(int page) where TModel : BaseEntity
        {
            string modelName = typeof(TModel).Name;
            IView view = ViewEngineCollection.FindView(ControllerContext, modelName, null).View ??
                ViewEngineCollection.FindView(ControllerContext, BASE_SECTION_NAME, null).View;

            return View(view, GetSectionViewModel<TModel>(page));
        }
        private SectionViewModel GetSectionViewModel<TModel>(int page) where TModel : BaseEntity
        {
            IRepository<TModel> repository = (IRepository<TModel>)m_typeResolver.Get(typeof(IRepository<TModel>));
            Schema schema = DomainSchemas.GetSchema(typeof(TModel).Name);
            IEnumerable<EntityColumn> gridEntityColumns = schema.Columns.Where(col => !col.IsHidden);
            double gridColumnsWidth = 100.0 / gridEntityColumns.Count();

            return new SectionViewModel
            {
                Entities = repository.Entities
                    .OrderBy(m => m.Id)
                    .Skip((page - 1) * m_itemsPerPage)
                    .Take(m_itemsPerPage),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = m_itemsPerPage,
                    TotalItems = repository.Entities.Count()
                },
                Caption = SectionMenuItemCaptions.ResourceManager.GetString(typeof(TModel).Name),
                GridColumns = gridEntityColumns.Select(col => new GridColumn
                {
                    EntityColumn = col,
                    GridWidth = gridColumnsWidth
                })
            };
        }
    }
}