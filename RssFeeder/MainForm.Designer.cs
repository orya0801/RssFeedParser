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
            this.ButtonSettings = new System.Windows.Forms.Button();
            this.ButtonDescription = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.MainBox = new System.Windows.Forms.ListBox();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.MainPanel.Controls.Add(this.ButtonSettings);
            this.MainPanel.Controls.Add(this.ButtonDescription);
            this.MainPanel.Controls.Add(this.StartButton);
            this.MainPanel.Controls.Add(this.MainBox);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1037, 379);
            this.MainPanel.TabIndex = 0;
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSettings.Location = new System.Drawing.Point(875, 345);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(150, 24);
            this.ButtonSettings.TabIndex = 3;
            this.ButtonSettings.Text = "Settings";
            this.ButtonSettings.UseVisualStyleBackColor = true;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // ButtonDescription
            // 
            this.ButtonDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonDescription.Location = new System.Drawing.Point(168, 345);
            this.ButtonDescription.Name = "ButtonDescription";
            this.ButtonDescription.Size = new System.Drawing.Size(150, 24);
            this.ButtonDescription.TabIndex = 2;
            this.ButtonDescription.Text = "Show description";
            this.ButtonDescription.UseVisualStyleBackColor = true;
            this.ButtonDescription.Click += new System.EventHandler(this.ButtonDescription_Click);
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StartButton.Location = new System.Drawing.Point(12, 345);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(150, 25);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MainBox
            // 
            this.MainBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainBox.BackColor = System.Drawing.Color.AliceBlue;
            this.MainBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainBox.FormattingEnabled = true;
            this.MainBox.ItemHeight = 19;
            this.MainBox.Location = new System.Drawing.Point(12, 12);
            this.MainBox.Name = "MainBox";
            this.MainBox.Size = new System.Drawing.Size(1013, 327);
            this.MainBox.TabIndex = 0;
            this.MainBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MainBox_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 379);
            this.Controls.Add(this.MainPanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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

