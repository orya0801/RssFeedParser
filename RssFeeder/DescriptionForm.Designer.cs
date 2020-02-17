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
            this.PanelDescription = new System.Windows.Forms.Panel();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelPubDate = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PanelDescription.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelDescription
            // 
            this.PanelDescription.BackColor = System.Drawing.Color.LightSteelBlue;
            this.PanelDescription.Controls.Add(this.LabelPubDate);
            this.PanelDescription.Controls.Add(this.LabelTitle);
            this.PanelDescription.Controls.Add(this.LabelDescription);
            this.PanelDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDescription.Location = new System.Drawing.Point(0, 0);
            this.PanelDescription.Name = "PanelDescription";
            this.PanelDescription.Size = new System.Drawing.Size(754, 483);
            this.PanelDescription.TabIndex = 1;
            // 
            // LabelDescription
            // 
            this.LabelDescription.AllowDrop = true;
            this.LabelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelDescription.BackColor = System.Drawing.Color.AliceBlue;
            this.LabelDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDescription.Location = new System.Drawing.Point(12, 73);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(730, 351);
            this.LabelDescription.TabIndex = 0;
            this.LabelDescription.Text = "label1";
            // 
            // LabelTitle
            // 
            this.LabelTitle.AllowDrop = true;
            this.LabelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTitle.Location = new System.Drawing.Point(11, 9);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(731, 54);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "label1";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelPubDate
            // 
            this.LabelPubDate.AllowDrop = true;
            this.LabelPubDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelPubDate.BackColor = System.Drawing.Color.AliceBlue;
            this.LabelPubDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPubDate.Location = new System.Drawing.Point(12, 435);
            this.LabelPubDate.Name = "LabelPubDate";
            this.LabelPubDate.Size = new System.Drawing.Size(730, 39);
            this.LabelPubDate.TabIndex = 2;
            this.LabelPubDate.Text = "label1";
            this.LabelPubDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.PanelDescription);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(754, 483);
            this.MainPanel.TabIndex = 0;
            // 
            // DescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 483);
            this.Controls.Add(this.MainPanel);
            this.Name = "DescriptionForm";
            this.Text = "DescriptionForm";
            this.PanelDescription.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel PanelDescription;
        public System.Windows.Forms.Label LabelPubDate;
        public System.Windows.Forms.Label LabelTitle;
        public System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.Panel MainPanel;
    }
}