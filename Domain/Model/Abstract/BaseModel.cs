using Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Model.Abstract
{
    public abstract class BaseModel
    {
        public Schema Schema => m_schema;

        public event EventHandler Inserting;
        public event EventHandler Inserted;
        public event EventHandler Updating;
        public event EventHandler Updated;
        public event EventHandler Deleting;
        public event EventHandler Deleted;

        public BaseModel()
        {
            m_schema = DomainSchemas.GetSchema(GetType());
            m_columnValues = new Dictionary<EntityColumn, object>();
            Inserting += BaseModelInserting;
            Updating += BaseModelUpdating;
        }

        public void OnInserting()
        {
            Inserting?.Invoke(this, new EventArgs());
        }
        public void OnInserted()
        {
            Inserted?.Invoke(this, new EventArgs());
        }
        public void OnUpdating()
        {
            Updating?.Invoke(this, new EventArgs());
        }
        public void OnUpdated()
        {
            Updated?.Invoke(this, new EventArgs());
        }
        public void OnDeleting()
        {
            Deleting?.Invoke(this, new EventArgs());
        }
        public void OnDeleted()
        {
            Deleted?.Invoke(this, new EventArgs());
        }
        public void SetColumnValue(string columnName, object value)
        {
            EntityColumn column = Schema.Columns.Find(entityColumn =>
                entityColumn.Name == columnName);
            SetColumnValue(column, value);
        }
        public void SetColumnValue(EntityColumn column, object value)
        {
            CheckColumn(column);
            m_columnValues[column] = value;
        }
        public object GetColumnValue(string columnName)
        {
            EntityColumn column = Schema.Columns.Find(entityColumn =>
                entityColumn.Name == columnName);
            return GetColumnValue(column);
        }
        public object GetColumnValue(EntityColumn column)
        {
            CheckColumn(column);
            m_columnValues.TryGetValue(column, out object result);
            return result;
        }
        public T GetTypedColumnValue<T>(string columnName)
        {
            EntityColumn column = Schema.Columns.Find(entityColumn =>
                entityColumn.Name == columnName);
            return GetTypedColumnValue<T>(column);
        }
        public T GetTypedColumnValue<T>(EntityColumn column)
        {
            object result = GetColumnValue(column);
            return result != null ? (T)result : Default<T>();
        }
        public object GetPrimaryColumnValue()
        {
            return GetColumnValue(Schema.PrimaryColumn);
        }
        public string GetDisplayColumnValue()
        {
            return GetTypedColumnValue<string>(Schema.DisplayColumn);
        }

        protected void BaseModelUpdating(object sender, EventArgs e) =>
            CheckRequiredColumnValues();
        protected void BaseModelInserting(object sender, EventArgs e) =>
            CheckRequiredColumnValues();

        private Schema m_schema;
        private Dictionary<EntityColumn, object> m_columnValues;

        private static readonly Type _dateTimeType = typeof(DateTime);
        private static readonly Type _nullableDateTimeType = typeof(DateTime?);
        private static readonly DateTime _minDateTimeValue = new DateTime(1900, 1, 1);

        private void CheckColumn(EntityColumn column)
        {
            if (column == null)
                throw new ArgumentNullException(nameof(column));
            if (column.Schema != Schema)
                throw new Exception();
        }
        private T Default<T>()
        {
            Type type = typeof(T);
            if (type == _dateTimeType)
                return (T)(object)_minDateTimeValue;
            else
                return default(T);
        }
        private void CheckRequiredColumnValues()
        {
            IEnumerable<EntityColumn> requiredColumns = Schema.Columns.Where(
                column => column.IsRequired);
            foreach (EntityColumn requiredColumn in requiredColumns)
            {
                if (!m_columnValues.ContainsKey(requiredColumn))
                    throw new RequiredColumnException(this, requiredColumn);
            }
        }
    }
}
