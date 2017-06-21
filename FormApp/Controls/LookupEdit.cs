using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp.Controls
{
    public partial class LookupEdit : BaseEdit
    {
        public override Control Control => m_control;
        public override object Value
        {
            get => m_control.SelectedValue ?? Guid.Empty;
            set => m_control.SelectedValue = value;
        }
        public override object DefaultValue => Guid.Empty;

        public LookupEdit()
        {
            InitializeComponent();
        }
    }
}
