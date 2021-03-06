﻿using System.Windows.Forms;

namespace FormApp.Controls
{
    public partial class BaseEdit : UserControl
    {
        public Label Label => m_label;
        public virtual Control Control { get; }
        public virtual object Value { get; set; }
        public virtual object DefaultValue { get; }

        public BaseEdit()
        {
            InitializeComponent();
        }
    }
}
