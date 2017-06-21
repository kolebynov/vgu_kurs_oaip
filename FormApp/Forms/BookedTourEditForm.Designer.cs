namespace FormApp.Forms
{
    partial class BookedTourEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_dateEdit = new FormApp.Controls.DateTimeEdit();
            this.m_contactLookupEdit = new FormApp.Controls.LookupEdit();
            this.m_tourLookupEdit = new FormApp.Controls.LookupEdit();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.m_tourLookupEdit);
            this.contentPanel.Controls.Add(this.m_contactLookupEdit);
            this.contentPanel.Controls.Add(this.m_dateEdit);
            // 
            // m_dateEdit
            // 
            this.m_dateEdit.Location = new System.Drawing.Point(12, 38);
            this.m_dateEdit.Name = "m_dateEdit";
            this.m_dateEdit.Size = new System.Drawing.Size(394, 20);
            this.m_dateEdit.TabIndex = 0;
            this.m_dateEdit.Tag = "Date";
            this.m_dateEdit.Value = new System.DateTime(2017, 6, 18, 12, 20, 7, 432);
            // 
            // m_contactLookupEdit
            // 
            this.m_contactLookupEdit.Location = new System.Drawing.Point(12, 12);
            this.m_contactLookupEdit.Name = "m_contactLookupEdit";
            this.m_contactLookupEdit.Size = new System.Drawing.Size(394, 21);
            this.m_contactLookupEdit.TabIndex = 1;
            this.m_contactLookupEdit.Tag = "ContactId";
            this.m_contactLookupEdit.Value = null;
            // 
            // m_tourLookupEdit
            // 
            this.m_tourLookupEdit.Location = new System.Drawing.Point(12, 64);
            this.m_tourLookupEdit.Name = "m_tourLookupEdit";
            this.m_tourLookupEdit.Size = new System.Drawing.Size(394, 21);
            this.m_tourLookupEdit.TabIndex = 2;
            this.m_tourLookupEdit.Tag = "TourId";
            this.m_tourLookupEdit.Value = null;
            // 
            // BookedTourEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 324);
            this.Name = "BookedTourEditForm";
            this.Text = "BookedTourEditForm";
            this.contentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.DateTimeEdit m_dateEdit;
        private Controls.LookupEdit m_contactLookupEdit;
        private Controls.LookupEdit m_tourLookupEdit;
    }
}