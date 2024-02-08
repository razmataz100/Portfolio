namespace Inlämningsuppgift2
{
    partial class ShotgunGame
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
            btnShoot = new Button();
            btnReload = new Button();
            btnBlock = new Button();
            lblPlayer = new Label();
            lblComputer = new Label();
            btnRestart = new Button();
            btnShotgun = new Button();
            lblAmmo = new Label();
            lblWins = new Label();
            txtHumanAmmo = new TextBox();
            txtComputerAmmo = new TextBox();
            txtComputerWins = new TextBox();
            txtHumanWins = new TextBox();
            lblLastActionLabel = new Label();
            btnQuit = new Button();
            lblLastOutcomeLabel = new Label();
            lblHumanLastAction = new Label();
            lblLastOutcome = new Label();
            lblComputerLastAction = new Label();
            SuspendLayout();
            // 
            // btnShoot
            // 
            btnShoot.Location = new Point(159, 360);
            btnShoot.Margin = new Padding(3, 4, 3, 4);
            btnShoot.Name = "btnShoot";
            btnShoot.Size = new Size(86, 31);
            btnShoot.TabIndex = 0;
            btnShoot.Text = "Shoot";
            btnShoot.UseVisualStyleBackColor = true;
            btnShoot.Click += btnShoot_Click;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(251, 360);
            btnReload.Margin = new Padding(3, 4, 3, 4);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(86, 31);
            btnReload.TabIndex = 1;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // btnBlock
            // 
            btnBlock.Location = new Point(344, 360);
            btnBlock.Margin = new Padding(3, 4, 3, 4);
            btnBlock.Name = "btnBlock";
            btnBlock.Size = new Size(86, 31);
            btnBlock.TabIndex = 2;
            btnBlock.Text = "Block";
            btnBlock.UseVisualStyleBackColor = true;
            btnBlock.Click += btnBlock_Click;
            // 
            // lblPlayer
            // 
            lblPlayer.AutoSize = true;
            lblPlayer.Location = new Point(191, 28);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(57, 20);
            lblPlayer.TabIndex = 3;
            lblPlayer.Text = "Human";
            // 
            // lblComputer
            // 
            lblComputer.AutoSize = true;
            lblComputer.Location = new Point(362, 28);
            lblComputer.Name = "lblComputer";
            lblComputer.Size = new Size(75, 20);
            lblComputer.TabIndex = 5;
            lblComputer.Text = "Computer";
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(570, 360);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(94, 29);
            btnRestart.TabIndex = 9;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // btnShotgun
            // 
            btnShotgun.Location = new Point(251, 423);
            btnShotgun.Name = "btnShotgun";
            btnShotgun.Size = new Size(86, 43);
            btnShotgun.TabIndex = 10;
            btnShotgun.Text = "Shotgun";
            btnShotgun.UseVisualStyleBackColor = true;
            btnShotgun.Click += btnShotgun_Click;
            // 
            // lblAmmo
            // 
            lblAmmo.AutoSize = true;
            lblAmmo.Location = new Point(99, 107);
            lblAmmo.Name = "lblAmmo";
            lblAmmo.Size = new Size(54, 20);
            lblAmmo.TabIndex = 11;
            lblAmmo.Text = "Ammo";
            // 
            // lblWins
            // 
            lblWins.AutoSize = true;
            lblWins.Location = new Point(112, 180);
            lblWins.Name = "lblWins";
            lblWins.Size = new Size(41, 20);
            lblWins.TabIndex = 12;
            lblWins.Text = "Wins";
            // 
            // txtHumanAmmo
            // 
            txtHumanAmmo.Location = new Point(191, 100);
            txtHumanAmmo.Margin = new Padding(3, 4, 3, 4);
            txtHumanAmmo.Name = "txtHumanAmmo";
            txtHumanAmmo.Size = new Size(55, 27);
            txtHumanAmmo.TabIndex = 13;
            // 
            // txtComputerAmmo
            // 
            txtComputerAmmo.Location = new Point(362, 100);
            txtComputerAmmo.Margin = new Padding(3, 4, 3, 4);
            txtComputerAmmo.Name = "txtComputerAmmo";
            txtComputerAmmo.Size = new Size(55, 27);
            txtComputerAmmo.TabIndex = 14;
            // 
            // txtComputerWins
            // 
            txtComputerWins.Location = new Point(362, 177);
            txtComputerWins.Margin = new Padding(3, 4, 3, 4);
            txtComputerWins.Name = "txtComputerWins";
            txtComputerWins.Size = new Size(55, 27);
            txtComputerWins.TabIndex = 15;
            // 
            // txtHumanWins
            // 
            txtHumanWins.Location = new Point(191, 177);
            txtHumanWins.Margin = new Padding(3, 4, 3, 4);
            txtHumanWins.Name = "txtHumanWins";
            txtHumanWins.Size = new Size(55, 27);
            txtHumanWins.TabIndex = 16;
            // 
            // lblLastActionLabel
            // 
            lblLastActionLabel.AutoSize = true;
            lblLastActionLabel.Location = new Point(73, 240);
            lblLastActionLabel.Name = "lblLastActionLabel";
            lblLastActionLabel.Size = new Size(80, 20);
            lblLastActionLabel.TabIndex = 17;
            lblLastActionLabel.Text = "Last action";
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(570, 452);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(94, 29);
            btnQuit.TabIndex = 20;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // lblLastOutcomeLabel
            // 
            lblLastOutcomeLabel.AutoSize = true;
            lblLastOutcomeLabel.Location = new Point(55, 299);
            lblLastOutcomeLabel.Name = "lblLastOutcomeLabel";
            lblLastOutcomeLabel.Size = new Size(98, 20);
            lblLastOutcomeLabel.TabIndex = 22;
            lblLastOutcomeLabel.Text = "Last outcome";
            // 
            // lblHumanLastAction
            // 
            lblHumanLastAction.AutoSize = true;
            lblHumanLastAction.Location = new Point(191, 245);
            lblHumanLastAction.Name = "lblHumanLastAction";
            lblHumanLastAction.Size = new Size(50, 20);
            lblHumanLastAction.TabIndex = 23;
            lblHumanLastAction.Text = "label1";
            // 
            // lblLastOutcome
            // 
            lblLastOutcome.AutoSize = true;
            lblLastOutcome.Location = new Point(191, 299);
            lblLastOutcome.Name = "lblLastOutcome";
            lblLastOutcome.Size = new Size(50, 20);
            lblLastOutcome.TabIndex = 24;
            lblLastOutcome.Text = "label2";
            // 
            // lblComputerLastAction
            // 
            lblComputerLastAction.AutoSize = true;
            lblComputerLastAction.Location = new Point(362, 245);
            lblComputerLastAction.Name = "lblComputerLastAction";
            lblComputerLastAction.Size = new Size(50, 20);
            lblComputerLastAction.TabIndex = 25;
            lblComputerLastAction.Text = "label3";
            // 
            // ShotgunGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 533);
            Controls.Add(lblComputerLastAction);
            Controls.Add(lblLastOutcome);
            Controls.Add(lblHumanLastAction);
            Controls.Add(lblLastOutcomeLabel);
            Controls.Add(btnQuit);
            Controls.Add(lblLastActionLabel);
            Controls.Add(txtHumanWins);
            Controls.Add(txtComputerWins);
            Controls.Add(txtComputerAmmo);
            Controls.Add(txtHumanAmmo);
            Controls.Add(lblWins);
            Controls.Add(lblAmmo);
            Controls.Add(btnShotgun);
            Controls.Add(btnRestart);
            Controls.Add(lblComputer);
            Controls.Add(lblPlayer);
            Controls.Add(btnBlock);
            Controls.Add(btnReload);
            Controls.Add(btnShoot);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ShotgunGame";
            Text = "ShotgunGame";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnShoot;
        private Button btnReload;
        private Button btnBlock;
        private Label lblPlayer;
        private Label lblComputer;
        private Button btnRestart;
        private Button btnShotgun;
        private Label lblAmmo;
        private Label lblWins;
        private TextBox txtHumanAmmo;
        private TextBox txtComputerAmmo;
        private TextBox txtComputerWins;
        private TextBox txtHumanWins;
        private Label lblLastActionLabel;
        private Button btnQuit;
        public Label lblLastOutcomeLabel;
        private Label lblHumanLastAction;
        private Label lblLastOutcome;
        private Label lblComputerLastAction;
    }
}