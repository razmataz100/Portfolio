namespace Inlämningsuppgift1
{
    partial class Adressbok
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
            lblSearchName = new Label();
            SearchNameTextBox = new TextBox();
            lblCitySearch = new Label();
            SearchCityTextBox = new TextBox();
            SearchGroupBox = new GroupBox();
            btnSearch = new Button();
            btnAdd = new Button();
            listBox = new ListBox();
            btnDetails = new Button();
            btnRemove = new Button();
            SearchGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // lblSearchName
            // 
            lblSearchName.AutoSize = true;
            lblSearchName.Location = new Point(19, 43);
            lblSearchName.Name = "lblSearchName";
            lblSearchName.Size = new Size(49, 20);
            lblSearchName.TabIndex = 2;
            lblSearchName.Text = "Namn";
            // 
            // SearchNameTextBox
            // 
            SearchNameTextBox.Location = new Point(74, 43);
            SearchNameTextBox.Name = "SearchNameTextBox";
            SearchNameTextBox.Size = new Size(189, 27);
            SearchNameTextBox.TabIndex = 3;
            // 
            // lblCitySearch
            // 
            lblCitySearch.AutoSize = true;
            lblCitySearch.Location = new Point(282, 43);
            lblCitySearch.Name = "lblCitySearch";
            lblCitySearch.Size = new Size(55, 20);
            lblCitySearch.TabIndex = 4;
            lblCitySearch.Text = "Postort";
            // 
            // SearchCityTextBox
            // 
            SearchCityTextBox.Location = new Point(343, 43);
            SearchCityTextBox.Name = "SearchCityTextBox";
            SearchCityTextBox.Size = new Size(189, 27);
            SearchCityTextBox.TabIndex = 5;
            // 
            // SearchGroupBox
            // 
            SearchGroupBox.Controls.Add(btnRemove);
            SearchGroupBox.Controls.Add(btnSearch);
            SearchGroupBox.Controls.Add(btnDetails);
            SearchGroupBox.Controls.Add(SearchNameTextBox);
            SearchGroupBox.Controls.Add(lblCitySearch);
            SearchGroupBox.Controls.Add(SearchCityTextBox);
            SearchGroupBox.Controls.Add(lblSearchName);
            SearchGroupBox.Location = new Point(35, 30);
            SearchGroupBox.Name = "SearchGroupBox";
            SearchGroupBox.Size = new Size(727, 323);
            SearchGroupBox.TabIndex = 6;
            SearchGroupBox.TabStop = false;
            SearchGroupBox.Text = "Sök kontakt";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(602, 43);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Sök";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(603, 386);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(146, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Lägg till kontakt";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 20;
            listBox.Location = new Point(35, 162);
            listBox.Name = "listBox";
            listBox.Size = new Size(578, 164);
            listBox.TabIndex = 8;
            // 
            // btnDetails
            // 
            btnDetails.Location = new Point(602, 132);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(112, 29);
            btnDetails.TabIndex = 9;
            btnDetails.Text = "Detaljer";
            btnDetails.UseVisualStyleBackColor = true;
            btnDetails.Click += btnDetails_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(602, 179);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(112, 29);
            btnRemove.TabIndex = 10;
            btnRemove.Text = "Ta bort";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // Adressbok
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(listBox);
            Controls.Add(SearchGroupBox);
            Name = "Adressbok";
            Text = "Adressbok";
            SearchGroupBox.ResumeLayout(false);
            SearchGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblSearchName;
        private TextBox SearchNameTextBox;
        private Label lblCitySearch;
        private TextBox SearchCityTextBox;
        private GroupBox SearchGroupBox;
        private Button btnSearch;
        private Button btnAdd;
        private ListBox listBox;
        private Button btnDetails;
        private Button btnRemove;
    }
}