using Domain.Model;
using FormApp.Controls;

namespace FormApp.Forms
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_buttonsPanel = new System.Windows.Forms.Panel();
            this.m_deleteDuplicatesButton = new System.Windows.Forms.Button();
            this.m_openTourGridButton = new System.Windows.Forms.Button();
            this.m_openContactGridButton = new System.Windows.Forms.Button();
            this.m_buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_buttonsPanel
            // 
            this.m_buttonsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_buttonsPanel.Controls.Add(this.m_deleteDuplicatesButton);
            this.m_buttonsPanel.Controls.Add(this.m_openTourGridButton);
            this.m_buttonsPanel.Controls.Add(this.m_openContactGridButton);
            this.m_buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_buttonsPanel.Location = new System.Drawing.Point(0, 253);
            this.m_buttonsPanel.Name = "m_buttonsPanel";
            this.m_buttonsPanel.Size = new System.Drawing.Size(586, 47);
            this.m_buttonsPanel.TabIndex = 0;
            // 
            // m_deleteDuplicatesButton
            // 
            this.m_deleteDuplicatesButton.Location = new System.Drawing.Point(174, 12);
            this.m_deleteDuplicatesButton.Name = "m_deleteDuplicatesButton";
            this.m_deleteDuplicatesButton.Size = new System.Drawing.Size(120, 23);
            this.m_deleteDuplicatesButton.TabIndex = 2;
            this.m_deleteDuplicatesButton.Text = "Удалить дубликаты";
            this.m_deleteDuplicatesButton.UseVisualStyleBackColor = true;
            this.m_deleteDuplicatesButton.Click += new System.EventHandler(this.OnDeleteDuplicatesButtonClick);
            // 
            // m_openTourGridButton
            // 
            this.m_openTourGridButton.Location = new System.Drawing.Point(93, 12);
            this.m_openTourGridButton.Name = "m_openTourGridButton";
            this.m_openTourGridButton.Size = new System.Drawing.Size(75, 23);
            this.m_openTourGridButton.TabIndex = 1;
            this.m_openTourGridButton.Text = "Туры";
            this.m_openTourGridButton.UseVisualStyleBackColor = true;
            this.m_openTourGridButton.Click += new System.EventHandler(this.OnOpenTourGridButtonClick);
            // 
            // m_openContactGridButton
            // 
            this.m_openContactGridButton.Location = new System.Drawing.Point(12, 12);
            this.m_openContactGridButton.Name = "m_openContactGridButton";
            this.m_openContactGridButton.Size = new System.Drawing.Size(75, 23);
            this.m_openContactGridButton.TabIndex = 0;
            this.m_openContactGridButton.Text = "Контакты";
            this.m_openContactGridButton.UseVisualStyleBackColor = true;
            this.m_openContactGridButton.Click += new System.EventHandler(this.OnOpenContactGridButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 300);
            this.Controls.Add(this.m_buttonsPanel);
            this.Name = "MainForm";
            this.Text = "Забронированные туры";
            this.m_buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel m_buttonsPanel;
        private System.Windows.Forms.Button m_openContactGridButton;
        private System.Windows.Forms.Button m_openTourGridButton;
        private System.Windows.Forms.Button m_deleteDuplicatesButton;
    }
}

