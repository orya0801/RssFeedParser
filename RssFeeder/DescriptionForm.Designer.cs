namespace RssFeeder
{
    partial class DescriptionForm
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
            this.PanelPubDate = new System.Windows.Forms.Panel();
            this.LabelPubDate = new System.Windows.Forms.Label();
            this.PanelDescription = new System.Windows.Forms.Panel();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.PanelPubDate.SuspendLayout();
            this.PanelDescription.SuspendLayout();
            this.PanelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.PanelPubDate);
            this.MainPanel.Controls.Add(this.PanelDescription);
            this.MainPanel.Controls.Add(this.PanelTitle);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(824, 561);
            this.MainPanel.TabIndex = 0;
            // 
            // PanelPubDate
            // 
            this.PanelPubDate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PanelPubDate.Controls.Add(this.LabelPubDate);
            this.PanelPubDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelPubDate.Location = new System.Drawing.Point(0, 526);
            this.PanelPubDate.Name = "PanelPubDate";
            this.PanelPubDate.Size = new System.Drawing.Size(824, 35);
            this.PanelPubDate.TabIndex = 2;
            this.PanelPubDate.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelPubDate_Paint);
            // 
            // LabelPubDate
            // 
            this.LabelPubDate.AllowDrop = true;
            this.LabelPubDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPubDate.Location = new System.Drawing.Point(3, 0);
            this.LabelPubDate.Name = "LabelPubDate";
            this.LabelPubDate.Size = new System.Drawing.Size(821, 35);
            this.LabelPubDate.TabIndex = 2;
            this.LabelPubDate.Text = "label1";
            this.LabelPubDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PanelDescription
            // 
            this.PanelDescription.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PanelDescription.Controls.Add(this.LabelDescription);
            this.PanelDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelDescription.Location = new System.Drawing.Point(0, 57);
            this.PanelDescription.Name = "PanelDescription";
            this.PanelDescription.Size = new System.Drawing.Size(824, 466);
            this.PanelDescription.TabIndex = 1;
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelTitle.Controls.Add(this.LabelTitle);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(824, 57);
            this.PanelTitle.TabIndex = 0;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AllowDrop = true;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTitle.Location = new System.Drawing.Point(0, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(800, 54);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "label1";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelDescription
            // 
            this.LabelDescription.AllowDrop = true;
            this.LabelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDescription.Location = new System.Drawing.Point(0, 0);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(824, 466);
            this.LabelDescription.TabIndex = 0;
            this.LabelDescription.Text = "label1";
            // 
            // DescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 561);
            this.Controls.Add(this.MainPanel);
            this.Name = "DescriptionForm";
            this.Text = "DescriptionForm";
            this.MainPanel.ResumeLayout(false);
            this.PanelPubDate.ResumeLayout(false);
            this.PanelDescription.ResumeLayout(false);
            this.PanelTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        public System.Windows.Forms.Panel PanelTitle;
        public System.Windows.Forms.Panel PanelDescription;
        public System.Windows.Forms.Panel PanelPubDate;
        public System.Windows.Forms.Label LabelTitle;
        public System.Windows.Forms.Label LabelPubDate;
        public System.Windows.Forms.Label LabelDescription;
    }
}