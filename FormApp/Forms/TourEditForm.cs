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
    public partial class TourEditForm : BaseEditForm<Tour>
    {
        public TourEditForm(IDataHelper<Tour> dataHelper, Guid primaryKeyValue) :
            base(dataHelper, primaryKeyValue)
        {
            InitializeComponent();
            BindingsControls.Add(m_cityEdit);
            BindingsControls.Add(m_countryEdit);
            BindingsControls.Add(m_nameEdit);
            BindingsControls.Add(m_priceEdit);
            DataHelper.LoadLookupEdit<Country, object>(m_countryEdit);
            DataHelper.LoadLookupEdit<City, object>(m_cityEdit);

            ((ComboBox)m_countryEdit.Control).SelectedValueChanged += (sender, e) => 
                DataHelper.LoadLookupEdit(m_cityEdit, FilterHelper.GetCitiesByCountry, (Guid)m_countryEdit.Value);
        }
        public TourEditForm(IDataHelper<Tour> dataHelper) : this(dataHelper, Guid.Empty)
        { }
        public TourEditForm() : this(null)
        { }
    }
}
