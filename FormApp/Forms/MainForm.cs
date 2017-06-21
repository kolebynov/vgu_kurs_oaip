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
using FormApp.Controls;
using Domain.Abstract;
using FormApp.Resources;

namespace FormApp.Forms
{
    public partial class MainForm : Form
    {
        public IDataHelper<BookedTour> DataHelper { get; }

        public MainForm(IDataHelper<BookedTour> dataHelper)
        {
            DataHelper = dataHelper;
            InitializeComponent();
            Init();
        }

        private EditableDataGridView<BookedTour> m_gridView;

        private void Init()
        {
            m_gridView = new EditableDataGridView<BookedTour>(
                Factory.GetInstance<IDataHelper<BookedTour>>())
            {
                Width = ClientSize.Width,
                Height = ClientSize.Height - m_buttonsPanel.Height,
                Anchor = Anchor | AnchorStyles.Right | AnchorStyles.Bottom,
                Parent = this
            };
        }
        private void OnOpenContactGridButtonClick(object sender, EventArgs e) =>
            new ContactForm().Show();
        private void OnOpenTourGridButtonClick(object sender, EventArgs e) =>
            new TourForm().Show();
        private void OnDeleteDuplicatesButtonClick(object sender, EventArgs e) =>
            DeleteDuplicates();
        private void DeleteDuplicates()
        {
            DataHelper.DeleteDuplicatedBookedTour();
            MessageBox.Show(Captions.DuplicatesDeleted, Captions.MessageCaption);
            m_gridView.LoadData();
        }
    }
}
