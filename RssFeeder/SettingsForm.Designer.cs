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
            this.LabelFeed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxRssFeed = new System.Windows.Forms.TextBox();
            this.TextBoxUpdateFreq = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ButtonUpdateRssFeed = new System.Windows.Forms.Button();
            this.ButtonUpdateFreq = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.button3);
            this.MainPanel.Controls.Add(this.ButtonUpdateFreq);
            this.MainPanel.Controls.Add(this.ButtonUpdateRssFeed);
            this.MainPanel.Controls.Add(this.textBox3);
            this.MainPanel.Controls.Add(this.TextBoxUpdateFreq);
            this.MainPanel.Controls.Add(this.TextBoxRssFeed);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.LabelFeed);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(729, 208);
            this.MainPanel.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Update frequency";
            // 
            // TextBoxRssFeed
            // 
            this.TextBoxRssFeed.Location = new System.Drawing.Point(182, 70);
            this.TextBoxRssFeed.Name = "TextBoxRssFeed";
            this.TextBoxRssFeed.Size = new System.Drawing.Size(347, 20);
            this.TextBoxRssFeed.TabIndex = 4;
            // 
            // TextBoxUpdateFreq
            // 
            this.TextBoxUpdateFreq.Location = new System.Drawing.Point(182, 110);
            this.TextBoxUpdateFreq.Name = "TextBoxUpdateFreq";
            this.TextBoxUpdateFreq.Size = new System.Drawing.Size(347, 20);
            this.TextBoxUpdateFreq.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(182, 152);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(347, 20);
            this.textBox3.TabIndex = 6;
            // 
            // ButtonUpdateRssFeed
            // 
            this.ButtonUpdateRssFeed.Location = new System.Drawing.Point(550, 68);
            this.ButtonUpdateRssFeed.Name = "ButtonUpdateRssFeed";
            this.ButtonUpdateRssFeed.Size = new System.Drawing.Size(101, 21);
            this.ButtonUpdateRssFeed.TabIndex = 7;
            this.ButtonUpdateRssFeed.Text = "Update";
            this.ButtonUpdateRssFeed.UseVisualStyleBackColor = true;
            this.ButtonUpdateRssFeed.Click += new System.EventHandler(this.ButtonUpdateRssFeed_Click);
            // 
            // ButtonUpdateFreq
            // 
            this.ButtonUpdateFreq.Location = new System.Drawing.Point(550, 109);
            this.ButtonUpdateFreq.Name = "ButtonUpdateFreq";
            this.ButtonUpdateFreq.Size = new System.Drawing.Size(101, 21);
            this.ButtonUpdateFreq.TabIndex = 8;
            this.ButtonUpdateFreq.Text = "Update";
            this.ButtonUpdateFreq.UseVisualStyleBackColor = true;
            this.ButtonUpdateFreq.Click += new System.EventHandler(this.ButtonUpdateFreq_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(550, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 21);
            this.button3.TabIndex = 9;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Settings";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 208);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ButtonUpdateFreq;
        private System.Windows.Forms.Button ButtonUpdateRssFeed;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox TextBoxUpdateFreq;
        private System.Windows.Forms.TextBox TextBoxRssFeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}