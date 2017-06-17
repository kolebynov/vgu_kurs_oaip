using Domain.Abstract;
using Domain.Concrete;
using Domain.Model.Abstract;
using FormApp.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FormApp.Infrastructure
{
    public class DataHelper<T> : IDataHelper<T> where T : BaseEntity, new()
    {
        public event EventHandler OnEntityDeleted;
        public event EventHandler OnEntitySaved;

        public void LoadGridView(DataGridView gridView)
        {
            gridView.AutoGenerateColumns = false;
            IRepository<T> repository = Factory.GetInstance<IRepository<T>>(true);
            Schema entitySchema = DomainSchemas.GetSchema<T>();
            gridView.Columns.Clear();
            gridView.DataSource = null;
            gridView.Columns.AddRange(entitySchema.Columns
                .Where(column => !column.IsHidden)
                .Select(column => new DataGridViewTextBoxColumn
                {
                    DataPropertyName = column.Name,
                    HeaderText = column.Caption
                }).ToArray());
            gridView.DataSource = repository.Entities.ToList();
        }
        public void OpenEditForm(Guid primaryKeyValue)
        {
            BaseEditForm<T> editForm = Factory.GetInstance<BaseEditForm<T>>();
            editForm.PrimaryKeyValue = primaryKeyValue;
            editForm.OnEntitySaved += (sender, e) => OnEntitySaved?.Invoke(this, EventArgs.Empty);
            editForm.Show();
        }
        public void DeleteEntity(Guid primaryKeyValue)
        {
            IRepository<T> repository = Factory.GetInstance<IRepository<T>>(true);
            repository.Delete(primaryKeyValue);
            OnEntityDeleted?.Invoke(this, EventArgs.Empty);
        }
        public void SaveEntity(T entity)
        {
            IRepository<T> repository = Factory.GetInstance<IRepository<T>>(true);
            if (entity.Id == Guid.Empty)
                repository.Insert(entity);
            else
                repository.Update(entity);
        }
        public T LoadEntity(Guid primaryKeyValue)
        {
            IRepository<T> repository = Factory.GetInstance<IRepository<T>>(true);
            return repository.Entities.First(entity => entity.Id == primaryKeyValue);
        }
    }
}
