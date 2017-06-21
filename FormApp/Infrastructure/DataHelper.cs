using Domain.Abstract;
using Domain.Concrete;
using Domain.Model.Abstract;
using FormApp.Forms;
using System;
using System.Linq;
using System.Windows.Forms;
using FormApp.Controls;
using System.Collections.Generic;
using Domain.Model;

namespace FormApp.Infrastructure
{
    public class DataHelper<T> : IDataHelper<T> where T : BaseEntity, new()
    {
        public void LoadGridView(DataGridView gridView)
        {
            gridView.AutoGenerateColumns = false;
            IRepository<T> repository = Factory.GetInstance<IRepository<T>>();
            Schema entitySchema = DomainSchemas.GetSchema<T>();
            gridView.Columns.Clear();
            gridView.DataSource = null;
            gridView.Columns.AddRange(entitySchema.Columns
                .Where(column => !column.IsHidden && !column.IsLookup && !column.IsForeignKey)
                .Select(column => new DataGridViewTextBoxColumn
                {
                    DataPropertyName = column.Name,
                    HeaderText = column.Caption
                }).ToArray());
            gridView.DataSource = repository.Entities.ToList();
        }
        public void OpenEditForm(Guid primaryKeyValue, Action onEntitySavedCallback)
        {
            BaseEditForm<T> editForm = Factory.GetInstance<BaseEditForm<T>>();
            editForm.PrimaryKeyValue = primaryKeyValue;
            editForm.OnEntitySaved += (sender, e) => onEntitySavedCallback?.Invoke();
            editForm.Show();
        }
        public void DeleteEntity(Guid primaryKeyValue)
        {
            IRepository<T> repository = Factory.GetInstance<IRepository<T>>(true);
            repository.Delete(primaryKeyValue);
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
        public void LoadLookupEdit<V, TFilter>(LookupEdit lookupEdit, 
            Func<TFilter, IEnumerable<V>> filter = null, 
            TFilter filterValue = default(TFilter)) where V : BaseEntity
        {
            Schema entitySchema = DomainSchemas.GetSchema<V>();
            ComboBox comboBox = (ComboBox)lookupEdit.Control;
            comboBox.ValueMember = entitySchema.PrimaryColumn.Name;
            comboBox.DisplayMember = entitySchema.DisplayColumn.Name;
            if (filter != null)
                comboBox.DataSource = filter(filterValue);
            else
            {
                IRepository<V> repository = Factory.GetInstance<IRepository<V>>(true);
                comboBox.DataSource = repository.Entities.ToList();
            }
        }
        public void DeleteDuplicatedBookedTour()
        {
            IRepository<BookedTour> repository = Factory.GetInstance<IRepository<BookedTour>>(true);
            repository.Entities
                .OrderByDescending(tour => tour.Date)
                .GroupBy(tour => new { tour.TourId, tour.ContactId })
                .Where(group => group.Count() > 1).ToList()
                .ForEach(group => group.Skip(1).ToList()
                    .ForEach(tour => repository.Delete(tour.Id)));
        }
    }
}
