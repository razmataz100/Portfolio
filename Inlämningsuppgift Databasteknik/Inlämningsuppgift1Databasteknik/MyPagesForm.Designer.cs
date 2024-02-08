namespace Inlämningsuppgift1Databasteknik
{
    partial class MyPagesForm
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
            this.lblMyAds = new System.Windows.Forms.Label();
            this.listBoxMyAds = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMyAds
            // 
            this.lblMyAds.AutoSize = true;
            this.lblMyAds.Location = new System.Drawing.Point(42, 39);
            this.lblMyAds.Name = "lblMyAds";
            this.lblMyAds.Size = new System.Drawing.Size(95, 16);
            this.lblMyAds.TabIndex = 0;
            this.lblMyAds.Text = "Mina annonser";
            // 
            // listBoxMyAds
            // 
            this.listBoxMyAds.FormattingEnabled = true;
            this.listBoxMyAds.ItemHeight = 16;
            this.listBoxMyAds.Location = new System.Drawing.Point(45, 58);
            this.listBoxMyAds.Name = "listBoxMyAds";
            this.listBoxMyAds.Size = new System.Drawing.Size(204, 340);
            this.listBoxMyAds.TabIndex = 1;
            this.listBoxMyAds.DoubleClick += new System.EventHandler(this.listBoxMyAds_DoubleClick);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(328, 58);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(139, 41);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Ta bort annons";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(328, 123);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(139, 41);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Uppdatera annons";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // MyPagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 495);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.listBoxMyAds);
            this.Controls.Add(this.lblMyAds);
            this.Name = "MyPagesForm";
            this.Text = "Mina sidor";
            this.Load += new System.EventHandler(this.MyPagesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMyAds;
        private System.Windows.Forms.ListBox listBoxMyAds;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
    }
}