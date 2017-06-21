using Domain.Model.Abstract;
using FormApp.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp.Infrastructure
{
    public interface IDataHelper<T> where T : BaseEntity
    {
        void LoadGridView(DataGridView gridView);
        void OpenEditForm(Guid primaryKeyValue, Action onEntitySavedCallback);
        void DeleteEntity(Guid primaryKeyValue);
        void SaveEntity(T entity);
        T LoadEntity(Guid primaryKeyValue);
        void LoadLookupEdit<V, TFilter>(LookupEdit lookupEdit, 
            Func<TFilter, IEnumerable<V>> filter = null, 
            TFilter filterValue = default(TFilter)) where V : BaseEntity;
        void DeleteDuplicatedBookedTour();
    }
}
