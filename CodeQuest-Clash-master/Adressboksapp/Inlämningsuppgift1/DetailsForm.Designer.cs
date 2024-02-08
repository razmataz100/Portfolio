namespace Inlämningsuppgift1
{
    partial class DetailsForm
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
            groupBoxKontaktinfo = new GroupBox();
            btnUpdate = new Button();
            EmailTextBox = new TextBox();
            PhoneTextBox = new TextBox();
            lblEpost = new Label();
            lblTelefon = new Label();
            lblPostort = new Label();
            CityTextBox = new TextBox();
            PostalCodeTextBox = new TextBox();
            lblPostnummer = new Label();
            StreetAddressTextBox = new TextBox();
            lblAdress = new Label();
            lblNamn = new Label();
            NameTextBox = new TextBox();
            groupBoxKontaktinfo.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxKontaktinfo
            // 
            groupBoxKontaktinfo.Controls.Add(btnUpdate);
            groupBoxKontaktinfo.Controls.Add(EmailTextBox);
            groupBoxKontaktinfo.Controls.Add(PhoneTextBox);
            groupBoxKontaktinfo.Controls.Add(lblEpost);
            groupBoxKontaktinfo.Controls.Add(lblTelefon);
            groupBoxKontaktinfo.Controls.Add(lblPostort);
            groupBoxKontaktinfo.Controls.Add(CityTextBox);
            groupBoxKontaktinfo.Controls.Add(PostalCodeTextBox);
            groupBoxKontaktinfo.Controls.Add(lblPostnummer);
            groupBoxKontaktinfo.Controls.Add(StreetAddressTextBox);
            groupBoxKontaktinfo.Controls.Add(lblAdress);
            groupBoxKontaktinfo.Controls.Add(lblNamn);
            groupBoxKontaktinfo.Controls.Add(NameTextBox);
            groupBoxKontaktinfo.Location = new Point(193, 31);
            groupBoxKontaktinfo.Name = "groupBoxKontaktinfo";
            groupBoxKontaktinfo.Size = new Size(414, 389);
            groupBoxKontaktinfo.TabIndex = 1;
            groupBoxKontaktinfo.TabStop = false;
            groupBoxKontaktinfo.Text = "Kontaktinformation";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(123, 282);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(167, 29);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Uppdatera kontakt";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(129, 214);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(161, 27);
            EmailTextBox.TabIndex = 11;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(129, 181);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(161, 27);
            PhoneTextBox.TabIndex = 10;
            // 
            // lblEpost
            // 
            lblEpost.AutoSize = true;
            lblEpost.Location = new Point(14, 214);
            lblEpost.Name = "lblEpost";
            lblEpost.Size = new Size(46, 20);
            lblEpost.TabIndex = 9;
            lblEpost.Text = "Epost";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(14, 181);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(58, 20);
            lblTelefon.TabIndex = 8;
            lblTelefon.Text = "Telefon";
            // 
            // lblPostort
            // 
            lblPostort.AutoSize = true;
            lblPostort.Location = new Point(14, 148);
            lblPostort.Name = "lblPostort";
            lblPostort.Size = new Size(55, 20);
            lblPostort.TabIndex = 7;
            lblPostort.Text = "Postort";
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(129, 148);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(161, 27);
            CityTextBox.TabIndex = 6;
            // 
            // PostalCodeTextBox
            // 
            PostalCodeTextBox.Location = new Point(129, 115);
            PostalCodeTextBox.Name = "PostalCodeTextBox";
            PostalCodeTextBox.Size = new Size(161, 27);
            PostalCodeTextBox.TabIndex = 5;
            // 
            // lblPostnummer
            // 
            lblPostnummer.AutoSize = true;
            lblPostnummer.Location = new Point(14, 115);
            lblPostnummer.Name = "lblPostnummer";
            lblPostnummer.Size = new Size(91, 20);
            lblPostnummer.TabIndex = 4;
            lblPostnummer.Text = "Postnummer";
            // 
            // StreetAddressTextBox
            // 
            StreetAddressTextBox.Location = new Point(129, 82);
            StreetAddressTextBox.Name = "StreetAddressTextBox";
            StreetAddressTextBox.Size = new Size(161, 27);
            StreetAddressTextBox.TabIndex = 3;
            // 
            // lblAdress
            // 
            lblAdress.AutoSize = true;
            lblAdress.Location = new Point(14, 82);
            lblAdress.Name = "lblAdress";
            lblAdress.Size = new Size(82, 20);
            lblAdress.TabIndex = 2;
            lblAdress.Text = "Gatuadress";
            // 
            // lblNamn
            // 
            lblNamn.AutoSize = true;
            lblNamn.Location = new Point(14, 49);
            lblNamn.Name = "lblNamn";
            lblNamn.Size = new Size(49, 20);
            lblNamn.TabIndex = 1;
            lblNamn.Text = "Namn";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(129, 49);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(161, 27);
            NameTextBox.TabIndex = 0;
            // 
            // DetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxKontaktinfo);
            Name = "DetailsForm";
            Text = "DetailsForm";
            groupBoxKontaktinfo.ResumeLayout(false);
            groupBoxKontaktinfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxKontaktinfo;
        private Button btnUpdate;
        private TextBox EmailTextBox;
        private TextBox PhoneTextBox;
        private Label lblEpost;
        private Label lblTelefon;
        private Label lblPostort;
        private TextBox CityTextBox;
        private TextBox PostalCodeTextBox;
        private Label lblPostnummer;
        private TextBox StreetAddressTextBox;
        private Label lblAdress;
        private Label lblNamn;
        private TextBox NameTextBox;
    }
}