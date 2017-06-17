using Domain.Model.Abstract;
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
        event EventHandler OnEntityDeleted;
        event EventHandler OnEntitySaved;

        void LoadGridView(DataGridView gridView);
        void OpenEditForm(Guid primaryKeyValue);
        void DeleteEntity(Guid primaryKeyValue);
        void SaveEntity(T entity);
        T LoadEntity(Guid primaryKeyValue);
    }
}
