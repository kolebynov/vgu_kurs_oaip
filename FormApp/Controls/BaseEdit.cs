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
    public partial class BaseEdit : UserControl
    {
        public Label Label => m_label;
        public virtual Control Control { get; }
        public virtual object Value { get; set; }

        public BaseEdit()
        {
            InitializeComponent();
        }
    }
}
