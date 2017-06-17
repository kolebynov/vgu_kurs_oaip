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
    {
        public Guid PrimaryKeyValue { get; set; }
        public Contact Entity { get; private set; }

        public event EventHandler OnEntitySaved;

        public BaseEditForm(IDataHelper<Contact> dataHelper, Guid primaryKeyValue)
        {
            InitializeComponent();

            PrimaryKeyValue = primaryKeyValue;
            m_dataHelper = dataHelper;
        }
        public BaseEditForm(IDataHelper<Contact> dataHelper) : this(dataHelper, Guid.Empty)
        { }
        public BaseEditForm() : this(null)
        { }

        protected List<BaseEdit> BindingsControls { get; } = new List<BaseEdit>();

        private IDataHelper<Contact> m_dataHelper;

        private void OnCancelButtonClick(object sender, EventArgs e) =>
            Close();
        private void OnSaveButtonClick(object sender, EventArgs e)
        {
            m_dataHelper.SaveEntity(Entity);
            OnEntitySaved?.Invoke(this, EventArgs.Empty);
            OnCancelButtonClick(sender, e);
        }
        private void OnLoad(object sender, EventArgs e)
        {
            Entity = PrimaryKeyValue == Guid.Empty ? new Contact() :
                m_dataHelper.LoadEntity(PrimaryKeyValue);
            InitBindings();
        }
        private void InitBindings()
        {
            foreach (BaseEdit edit in BindingsControls)
            {
                if (edit.Tag != null)
                {
                    string columnName = (string)edit.Tag;
                    edit.DataBindings.Add("Value", Entity, columnName);
                }
            }
        }
    }
}
