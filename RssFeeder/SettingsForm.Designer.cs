namespace RssFeeder
{
    partial class SettingsForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonUpdateFreq = new System.Windows.Forms.Button();
            this.ButtonUpdateRssFeed = new System.Windows.Forms.Button();
            this.TextBoxUpdateFreq = new System.Windows.Forms.TextBox();
            this.TextBoxRssFeed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelFeed = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.ButtonUpdateFreq);
            this.MainPanel.Controls.Add(this.ButtonUpdateRssFeed);
            this.MainPanel.Controls.Add(this.TextBoxUpdateFreq);
            this.MainPanel.Controls.Add(this.TextBoxRssFeed);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.LabelFeed);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(725, 189);
            this.MainPanel.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(327, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Settings";
            // 
            // ButtonUpdateFreq
            // 
            this.ButtonUpdateFreq.Location = new System.Drawing.Point(550, 110);
            this.ButtonUpdateFreq.Name = "ButtonUpdateFreq";
            this.ButtonUpdateFreq.Size = new System.Drawing.Size(101, 21);
            this.ButtonUpdateFreq.TabIndex = 8;
            this.ButtonUpdateFreq.Text = "Update";
            this.ButtonUpdateFreq.UseVisualStyleBackColor = true;
            this.ButtonUpdateFreq.Click += new System.EventHandler(this.ButtonUpdateFreq_Click);
            // 
            // ButtonUpdateRssFeed
            // 
            this.ButtonUpdateRssFeed.Location = new System.Drawing.Point(550, 70);
            this.ButtonUpdateRssFeed.Name = "ButtonUpdateRssFeed";
            this.ButtonUpdateRssFeed.Size = new System.Drawing.Size(101, 21);
            this.ButtonUpdateRssFeed.TabIndex = 7;
            this.ButtonUpdateRssFeed.Text = "Update";
            this.ButtonUpdateRssFeed.UseVisualStyleBackColor = true;
            this.ButtonUpdateRssFeed.Click += new System.EventHandler(this.ButtonUpdateRssFeed_Click);
            // 
            // TextBoxUpdateFreq
            // 
            this.TextBoxUpdateFreq.Location = new System.Drawing.Point(158, 110);
            this.TextBoxUpdateFreq.Name = "TextBoxUpdateFreq";
            this.TextBoxUpdateFreq.Size = new System.Drawing.Size(371, 20);
            this.TextBoxUpdateFreq.TabIndex = 5;
            // 
            // TextBoxRssFeed
            // 
            this.TextBoxRssFeed.Location = new System.Drawing.Point(158, 70);
            this.TextBoxRssFeed.Name = "TextBoxRssFeed";
            this.TextBoxRssFeed.Size = new System.Drawing.Size(371, 20);
            this.TextBoxRssFeed.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Update frequency";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // LabelFeed
            // 
            this.LabelFeed.AutoSize = true;
            this.LabelFeed.Location = new System.Drawing.Point(58, 73);
            this.LabelFeed.Name = "LabelFeed";
            this.LabelFeed.Size = new System.Drawing.Size(83, 13);
            this.LabelFeed.TabIndex = 0;
            this.LabelFeed.Text = "Rss Feed ( link )";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 189);
            this.Controls.Add(this.MainPanel);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelFeed;
        private System.Windows.Forms.Button ButtonUpdateFreq;
        private System.Windows.Forms.Button ButtonUpdateRssFeed;
        private System.Windows.Forms.TextBox TextBoxUpdateFreq;
        private System.Windows.Forms.TextBox TextBoxRssFeed;
        private System.Windows.Forms.Label label4;
    }
}