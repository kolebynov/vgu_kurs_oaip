namespace FormApp.Forms
{
    partial class BaseEditForm<T>
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
            this.m_buttonsPanel = new System.Windows.Forms.Panel();
            this.m_cancelButton = new System.Windows.Forms.Button();
            this.m_saveButton = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.m_buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_buttonsPanel
            // 
            this.m_buttonsPanel.Controls.Add(this.m_cancelButton);
            this.m_buttonsPanel.Controls.Add(this.m_saveButton);
            this.m_buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_buttonsPanel.Location = new System.Drawing.Point(0, 273);
            this.m_buttonsPanel.Name = "m_buttonsPanel";
            this.m_buttonsPanel.Size = new System.Drawing.Size(418, 51);
            this.m_buttonsPanel.TabIndex = 0;
            // 
            // m_cancelButton
            // 
            this.m_cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_cancelButton.Location = new System.Drawing.Point(330, 16);
            this.m_cancelButton.Name = "m_cancelButton";
            this.m_cancelButton.Size = new System.Drawing.Size(76, 23);
            this.m_cancelButton.TabIndex = 1;
            this.m_cancelButton.Text = "button1";
            this.m_cancelButton.UseVisualStyleBackColor = true;
            this.m_cancelButton.Click += new System.EventHandler(this.OnCancelButtonClick);
            // 
            // m_saveButton
            // 
            this.m_saveButton.Location = new System.Drawing.Point(12, 16);
            this.m_saveButton.Name = "m_saveButton";
            this.m_saveButton.Size = new System.Drawing.Size(75, 23);
            this.m_saveButton.TabIndex = 0;
            this.m_saveButton.Text = "button1";
            this.m_saveButton.UseVisualStyleBackColor = true;
            this.m_saveButton.Click += new System.EventHandler(this.OnSaveButtonClick);
            // 
            // contentPanel
            // 
            this.contentPanel.AutoScroll = true;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(418, 273);
            this.contentPanel.TabIndex = 1;
            // 
            // BaseEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 324);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.m_buttonsPanel);
            this.Name = "BaseEditForm";
            this.Text = "BaseEditForm";
            this.Load += new System.EventHandler(this.OnLoad);
            this.m_buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel m_buttonsPanel;
        private System.Windows.Forms.Button m_cancelButton;
        private System.Windows.Forms.Button m_saveButton;
        protected System.Windows.Forms.Panel contentPanel;
    }
}