namespace FormApp.Controls
{
    partial class BaseEdit
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
            this.m_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_label
            // 
            this.m_label.AutoEllipsis = true;
            this.m_label.AutoSize = true;
            this.m_label.Location = new System.Drawing.Point(3, 3);
            this.m_label.MaximumSize = new System.Drawing.Size(100, 0);
            this.m_label.Name = "m_label";
            this.m_label.Size = new System.Drawing.Size(35, 13);
            this.m_label.TabIndex = 2;
            this.m_label.Text = "label1";
            // 
            // BaseEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_label);
            this.Name = "BaseEdit";
            this.Size = new System.Drawing.Size(200, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_label;
    }
}
