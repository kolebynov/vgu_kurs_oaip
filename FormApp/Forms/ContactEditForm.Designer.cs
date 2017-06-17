namespace FormApp.Forms
{
    partial class ContactEditForm
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
            this.m_firstNameTextEdit = new FormApp.Controls.TextEdit();
            this.m_secondNameTextEdit = new FormApp.Controls.TextEdit();
            this.m_middleNameTextEdit = new FormApp.Controls.TextEdit();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.m_middleNameTextEdit);
            this.contentPanel.Controls.Add(this.m_secondNameTextEdit);
            this.contentPanel.Controls.Add(this.m_firstNameTextEdit);
            this.contentPanel.Size = new System.Drawing.Size(377, 230);
            // 
            // m_firstNameTextEdit
            // 
            this.m_firstNameTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_firstNameTextEdit.Location = new System.Drawing.Point(12, 40);
            this.m_firstNameTextEdit.Name = "m_firstNameTextEdit";
            this.m_firstNameTextEdit.Size = new System.Drawing.Size(353, 22);
            this.m_firstNameTextEdit.TabIndex = 0;
            this.m_firstNameTextEdit.Tag = "FirstName";
            this.m_firstNameTextEdit.Value = "";
            // 
            // m_secondNameTextEdit
            // 
            this.m_secondNameTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_secondNameTextEdit.Location = new System.Drawing.Point(12, 12);
            this.m_secondNameTextEdit.Name = "m_secondNameTextEdit";
            this.m_secondNameTextEdit.Size = new System.Drawing.Size(353, 22);
            this.m_secondNameTextEdit.TabIndex = 1;
            this.m_secondNameTextEdit.Tag = "SecondName";
            this.m_secondNameTextEdit.Value = "";
            // 
            // m_middleNameTextEdit
            // 
            this.m_middleNameTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_middleNameTextEdit.Location = new System.Drawing.Point(12, 68);
            this.m_middleNameTextEdit.Name = "m_middleNameTextEdit";
            this.m_middleNameTextEdit.Size = new System.Drawing.Size(353, 22);
            this.m_middleNameTextEdit.TabIndex = 2;
            this.m_middleNameTextEdit.Tag = "MiddleName";
            this.m_middleNameTextEdit.Value = "";
            // 
            // ContactEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 281);
            this.Name = "ContactEditForm";
            this.Text = "ContactEditForm";
            this.contentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.TextEdit m_firstNameTextEdit;
        private Controls.TextEdit m_middleNameTextEdit;
        private Controls.TextEdit m_secondNameTextEdit;
    }
}