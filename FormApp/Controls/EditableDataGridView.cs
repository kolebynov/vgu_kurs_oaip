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
using FormApp.Resources;

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
            LoadData();
        }
        private void OnAddButtonClick(object sender, EventArgs e) =>
            m_dataHelper.OpenEditForm(Guid.Empty, LoadData);
        private void OnEditButtonClick(object sender, EventArgs e)
        {
            Guid? key = GetSelectedRecordKey();
            if (key.HasValue)
                m_dataHelper.OpenEditForm(key.Value, LoadData);
        }
        private void OnDeleteButtonClick(object sender, EventArgs e)
        {
            Guid? key = GetSelectedRecordKey();
            if (key.HasValue)
            {
                DialogResult result = MessageBox.Show(Captions.ConfirmationDelete,
                    Captions.Confirmation, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    m_dataHelper.DeleteEntity(key.Value);
                    LoadData();
                }
            }
        }
        private Guid? GetSelectedRecordKey()
        {
            if (m_dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = m_dataGridView.SelectedRows[0];
                BaseModel entity = (BaseModel)selectedRow.DataBoundItem;
                return (Guid)entity.GetPrimaryColumnValue();
            }
            else
                return null;
        }
    }
}
