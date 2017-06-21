namespace FormApp.Forms
{
    partial class TourEditForm
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
            this.m_nameEdit = new FormApp.Controls.TextEdit();
            this.m_countryEdit = new FormApp.Controls.LookupEdit();
            this.m_cityEdit = new FormApp.Controls.LookupEdit();
            this.m_priceEdit = new FormApp.Controls.FloatEdit();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.m_priceEdit);
            this.contentPanel.Controls.Add(this.m_cityEdit);
            this.contentPanel.Controls.Add(this.m_countryEdit);
            this.contentPanel.Controls.Add(this.m_nameEdit);
            this.contentPanel.Size = new System.Drawing.Size(415, 273);
            // 
            // m_nameEdit
            // 
            this.m_nameEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_nameEdit.Location = new System.Drawing.Point(12, 12);
            this.m_nameEdit.Name = "m_nameEdit";
            this.m_nameEdit.Size = new System.Drawing.Size(391, 20);
            this.m_nameEdit.TabIndex = 0;
            this.m_nameEdit.Tag = "Name";
            this.m_nameEdit.Value = "";
            // 
            // m_countryEdit
            // 
            this.m_countryEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_countryEdit.Location = new System.Drawing.Point(12, 38);
            this.m_countryEdit.Name = "m_countryEdit";
            this.m_countryEdit.Size = new System.Drawing.Size(391, 21);
            this.m_countryEdit.TabIndex = 1;
            this.m_countryEdit.Tag = "CountryId";
            this.m_countryEdit.Value = new System.Guid("00000000-0000-0000-0000-000000000000");
            // 
            // m_cityEdit
            // 
            this.m_cityEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_cityEdit.Location = new System.Drawing.Point(12, 65);
            this.m_cityEdit.Name = "m_cityEdit";
            this.m_cityEdit.Size = new System.Drawing.Size(391, 21);
            this.m_cityEdit.TabIndex = 2;
            this.m_cityEdit.Tag = "CityId";
            this.m_cityEdit.Value = new System.Guid("00000000-0000-0000-0000-000000000000");
            // 
            // m_priceEdit
            // 
            this.m_priceEdit.Location = new System.Drawing.Point(12, 92);
            this.m_priceEdit.Name = "m_priceEdit";
            this.m_priceEdit.Size = new System.Drawing.Size(229, 20);
            this.m_priceEdit.TabIndex = 3;
            this.m_priceEdit.Tag = "Price";
            this.m_priceEdit.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // TourEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 324);
            this.Name = "TourEditForm";
            this.Text = "TourEditForm";
            this.contentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.TextEdit m_nameEdit;
        private Controls.FloatEdit m_priceEdit;
        private Controls.LookupEdit m_cityEdit;
        private Controls.LookupEdit m_countryEdit;
    }
}