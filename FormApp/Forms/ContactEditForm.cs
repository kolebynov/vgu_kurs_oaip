using Domain.Model;
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
    public partial class ContactEditForm : BaseEditForm<Contact>
    {
        public ContactEditForm(IDataHelper<Contact> dataHelper, Guid primaryKeyValue) :
            base(dataHelper, primaryKeyValue)
        {
            InitializeComponent();
            BindingsControls.Add(m_firstNameTextEdit);
            BindingsControls.Add(m_secondNameTextEdit);
            BindingsControls.Add(m_middleNameTextEdit);
            BindingsControls.Add(m_genderEdit);
            DataHelper.LoadLookupEdit<Gender, object>(m_genderEdit);
        }
        public ContactEditForm(IDataHelper<Contact> dataHelper) : this(dataHelper, Guid.Empty)
        { }
        public ContactEditForm() : this(null)
        { }
    }
}
