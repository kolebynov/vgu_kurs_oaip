namespace FormApp.Controls
{
    partial class LookupEdit
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
            this.m_control = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // m_control
            // 
            this.m_control.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_control.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_control.FormattingEnabled = true;
            this.m_control.Location = new System.Drawing.Point(110, 0);
            this.m_control.Name = "m_control";
            this.m_control.Size = new System.Drawing.Size(136, 21);
            this.m_control.TabIndex = 3;
            // 
            // LookupEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_control);
            this.Name = "LookupEdit";
            this.Size = new System.Drawing.Size(246, 21);
            this.Controls.SetChildIndex(this.m_control, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox m_control;
    }
}
