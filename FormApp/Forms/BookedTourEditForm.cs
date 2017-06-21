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
    public partial class BookedTourEditForm : BaseEditForm<BookedTour>
    {
        public BookedTourEditForm(IDataHelper<BookedTour> dataHelper, Guid primaryKeyValue) : 
            base(dataHelper, primaryKeyValue)
        {
            InitializeComponent();
            BindingsControls.Add(m_dateEdit);
            BindingsControls.Add(m_contactLookupEdit);
            BindingsControls.Add(m_tourLookupEdit);
            DataHelper.LoadLookupEdit<Contact, object>(m_contactLookupEdit);
            DataHelper.LoadLookupEdit<Tour, object>(m_tourLookupEdit);
        }
        public BookedTourEditForm(IDataHelper<BookedTour> dataHelper) : this(dataHelper, Guid.Empty)
        { }
        public BookedTourEditForm() : this(null)
        { }
    }
}
