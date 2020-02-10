namespace RssFeeder
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ButtonDescription = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.MainBox = new System.Windows.Forms.ListBox();
            this.ButtonSettings = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.ButtonSettings);
            this.MainPanel.Controls.Add(this.ButtonDescription);
            this.MainPanel.Controls.Add(this.StartButton);
            this.MainPanel.Controls.Add(this.MainBox);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1241, 586);
            this.MainPanel.TabIndex = 0;
            // 
            // ButtonDescription
            // 
            this.ButtonDescription.Location = new System.Drawing.Point(1123, 65);
            this.ButtonDescription.Name = "ButtonDescription";
            this.ButtonDescription.Size = new System.Drawing.Size(115, 44);
            this.ButtonDescription.TabIndex = 2;
            this.ButtonDescription.Text = "Description";
            this.ButtonDescription.UseVisualStyleBackColor = true;
            this.ButtonDescription.Click += new System.EventHandler(this.ButtonDescription_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(1123, 12);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(115, 47);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MainBox
            // 
            this.MainBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MainBox.FormattingEnabled = true;
            this.MainBox.ItemHeight = 16;
            this.MainBox.Location = new System.Drawing.Point(12, 12);
            this.MainBox.Name = "MainBox";
            this.MainBox.Size = new System.Drawing.Size(1105, 548);
            this.MainBox.TabIndex = 0;
            this.MainBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MainBox_MouseDoubleClick);
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.Location = new System.Drawing.Point(1123, 115);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(114, 44);
            this.ButtonSettings.TabIndex = 3;
            this.ButtonSettings.Text = "Settings";
            this.ButtonSettings.UseVisualStyleBackColor = true;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 586);
            this.Controls.Add(this.MainPanel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ListBox MainBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ButtonDescription;
        private System.Windows.Forms.Button ButtonSettings;
    }
}

