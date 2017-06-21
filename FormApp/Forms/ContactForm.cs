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
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
            Init();
        }

        private EditableDataGridView<Contact> m_gridView;

        private void Init()
        {
            m_gridView = new EditableDataGridView<Contact>(
                Factory.GetInstance<IDataHelper<Contact>>())
            {
                Parent = this,
                Dock = DockStyle.Fill
            };
        }
    }
}
