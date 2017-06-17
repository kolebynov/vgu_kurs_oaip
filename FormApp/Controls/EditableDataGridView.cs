using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Model.Abstract;
using Domain.Abstract;
using FormApp.Infrastructure;

namespace FormApp.Controls
{
    public partial class EditableDataGridView<T> : UserControl
        where T : BaseEntity
    {
        public EditableDataGridView(IDataHelper<T> dataHelper)
        {
            m_dataHelper = dataHelper;
            InitializeComponent();
            Init();
        }

        public void LoadData()
        {
            m_dataHelper.LoadGridView(m_dataGridView);
        }

        private IDataHelper<T> m_dataHelper;

        private void Init()
        {
            m_dataHelper.OnEntityDeleted += (sender, e) => LoadData();
            m_dataHelper.OnEntitySaved += (sender, e) => LoadData();
            LoadData();
        }
        private void OnAddButtonClick(object sender, EventArgs e) =>
            m_dataHelper.OpenEditForm(Guid.Empty);
        private void OnEditButtonClick(object sender, EventArgs e) =>
            m_dataHelper.OpenEditForm(GetSelectedRecordKey());
        private void OnDeleteButtonClick(object sender, EventArgs e) =>
            m_dataHelper.DeleteEntity(GetSelectedRecordKey());
        private Guid GetSelectedRecordKey()
        {
            DataGridViewRow selectedRow = m_dataGridView.SelectedRows[0];
            BaseModel entity = (BaseModel)selectedRow.DataBoundItem;
            return (Guid)entity.GetPrimaryColumnValue();
        }
    }
}
