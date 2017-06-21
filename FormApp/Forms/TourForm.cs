using Domain.Model;
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
    public partial class TourForm : Form
    {
        public TourForm()
        {
            InitializeComponent();
            Init();
        }

        private EditableDataGridView<Tour> m_gridView;

        private void Init()
        {
            m_gridView = new EditableDataGridView<Tour>(
                Factory.GetInstance<IDataHelper<Tour>>())
            {
                Parent = this,
                Dock = DockStyle.Fill
            };
        }
    }
}
