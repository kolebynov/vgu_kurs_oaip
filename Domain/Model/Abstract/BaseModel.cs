using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            EntityColumn column = m_schema.Columns.Find(entityColumn =>
                entityColumn.Name == columnName);
            SetColumnValue(column, value);
        }
        public void SetColumnValue(EntityColumn column, object value)
        {
            CheckColumn(column);
            if ((column.Type == _dateTimeType || column.Type == _nullableDateTimeType) && value != null)
                value = ((DateTime?)value).Value.ToUniversalTime();
            m_columnValues[column] = value;
        }
        public object GetColumnValue(string columnName)
        {
            EntityColumn column = m_schema.Columns.Find(entityColumn =>
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
            EntityColumn column = m_schema.Columns.Find(entityColumn =>
                entityColumn.Name == columnName);
            return GetTypedColumnValue<T>(column);
        }
        public T GetTypedColumnValue<T>(EntityColumn column)
        {
            object result = GetColumnValue(column);
            return result != null ? (T)result : default(T);
        }
        public object GetPrimaryColumnValue()
        {
            return GetColumnValue(Schema.PrimaryColumn);
        }

        private Schema m_schema;
        private Dictionary<EntityColumn, object> m_columnValues;

        private static readonly Type _dateTimeType = typeof(DateTime);
        private static readonly Type _nullableDateTimeType = typeof(DateTime?);

        private void CheckColumn(EntityColumn column)
        {
            if (column == null)
                throw new ArgumentNullException(nameof(column));
            if (column.Schema != m_schema)
                throw new Exception();
        }
    }
}
