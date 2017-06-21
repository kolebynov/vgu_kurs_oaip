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
    public partial class FloatEdit : NumericEdit
    {
        public override object DefaultValue => 0m;

        public FloatEdit()
        {
            InitializeComponent();
            NumericUpDown control = (NumericUpDown)Control;
            control.Maximum = decimal.MaxValue;
            control.DecimalPlaces = 2;
        }
    }
}
