namespace FormApp.Controls
{
    partial class EditableDataGridView<T>
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_dataGridView = new System.Windows.Forms.DataGridView();
            this.m_addButton = new System.Windows.Forms.Button();
            this.m_editButton = new System.Windows.Forms.Button();
            this.m_deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // m_dataGridView
            // 
            this.m_dataGridView.AllowUserToAddRows = false;
            this.m_dataGridView.AllowUserToDeleteRows = false;
            this.m_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.m_dataGridView.MultiSelect = false;
            this.m_dataGridView.Name = "m_dataGridView";
            this.m_dataGridView.ReadOnly = true;
            this.m_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_dataGridView.Size = new System.Drawing.Size(366, 172);
            this.m_dataGridView.TabIndex = 0;
            // 
            // m_addButton
            // 
            this.m_addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_addButton.Image = global::FormApp.Properties.Resources._1;
            this.m_addButton.Location = new System.Drawing.Point(12, 178);
            this.m_addButton.Name = "m_addButton";
            this.m_addButton.Size = new System.Drawing.Size(28, 28);
            this.m_addButton.TabIndex = 1;
            this.m_addButton.UseVisualStyleBackColor = true;
            this.m_addButton.Click += new System.EventHandler(this.OnAddButtonClick);
            // 
            // m_editButton
            // 
            this.m_editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_editButton.Image = global::FormApp.Properties.Resources._2;
            this.m_editButton.Location = new System.Drawing.Point(46, 178);
            this.m_editButton.Name = "m_editButton";
            this.m_editButton.Size = new System.Drawing.Size(28, 28);
            this.m_editButton.TabIndex = 2;
            this.m_editButton.UseVisualStyleBackColor = true;
            this.m_editButton.Click += new System.EventHandler(this.OnEditButtonClick);
            // 
            // m_deleteButton
            // 
            this.m_deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_deleteButton.Image = global::FormApp.Properties.Resources._3;
            this.m_deleteButton.Location = new System.Drawing.Point(80, 179);
            this.m_deleteButton.Name = "m_deleteButton";
            this.m_deleteButton.Size = new System.Drawing.Size(28, 28);
            this.m_deleteButton.TabIndex = 3;
            this.m_deleteButton.UseVisualStyleBackColor = true;
            this.m_deleteButton.Click += new System.EventHandler(this.OnDeleteButtonClick);
            // 
            // EditableDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_deleteButton);
            this.Controls.Add(this.m_editButton);
            this.Controls.Add(this.m_addButton);
            this.Controls.Add(this.m_dataGridView);
            this.Name = "EditableDataGridView";
            this.Size = new System.Drawing.Size(366, 210);
            ((System.ComponentModel.ISupportInitialize)(this.m_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView m_dataGridView;
        private System.Windows.Forms.Button m_addButton;
        private System.Windows.Forms.Button m_editButton;
        private System.Windows.Forms.Button m_deleteButton;
    }
}
