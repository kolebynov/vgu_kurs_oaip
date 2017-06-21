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
    public partial class DateTimeEdit : BaseEdit
    {
        public override Control Control => m_control;
        public override object Value
        {
            get => m_control.Value;
            set => m_control.Value = (DateTime)value;
        }
        public override object DefaultValue => DateTime.Now.Date;

        public DateTimeEdit()
        {
            InitializeComponent();
        }
    }
}
