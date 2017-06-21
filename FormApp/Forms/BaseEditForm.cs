using Domain.Concrete;
using Domain.Model;
using Domain.Model.Abstract;
using FormApp.Controls;
using FormApp.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp.Forms
{
    public partial class BaseEditForm<T> : Form
        where T : BaseEntity, new()
    {
        public Guid PrimaryKeyValue { get; set; }
        public T Entity { get; private set; }
        public IDataHelper<T> DataHelper { get; }

        public event EventHandler OnEntitySaved;

        public BaseEditForm(IDataHelper<T> dataHelper, Guid primaryKeyValue)
        {
            InitializeComponent();

            PrimaryKeyValue = primaryKeyValue;
            DataHelper = dataHelper;
        }
        public BaseEditForm(IDataHelper<T> dataHelper) : this(dataHelper, Guid.Empty)
        { }
        public BaseEditForm() : this(null)
        { }

        protected List<BaseEdit> BindingsControls { get; } = new List<BaseEdit>();

        private void OnCancelButtonClick(object sender, EventArgs e) =>
            Close();
        private void OnSaveButtonClick(object sender, EventArgs e)
        {
            DataHelper.SaveEntity(Entity);
            OnEntitySaved?.Invoke(this, EventArgs.Empty);
            OnCancelButtonClick(sender, e);
        }
        private void OnLoad(object sender, EventArgs e)
        {
            Entity = PrimaryKeyValue == Guid.Empty ? new T() :
                DataHelper.LoadEntity(PrimaryKeyValue);
            InitBindingControls();
            Text = DomainSchemas.GetSchema<T>().Caption;
        }
        private void InitBindingControls()
        {
            Schema schema = DomainSchemas.GetSchema<T>();
            foreach (BaseEdit edit in BindingsControls)
            {
                if (edit.Tag != null)
                {
                    string columnName = (string)edit.Tag;
                    edit.Label.Text = schema.Columns.Find(col => col.Name == columnName).Caption;
                    Binding binding = edit.DataBindings.Add("Value", Entity, columnName);
                    if (PrimaryKeyValue == Guid.Empty)
                    {
                        edit.Value = edit.DefaultValue;
                        binding.WriteValue();
                    }
                }
            }
        }
    }
}
