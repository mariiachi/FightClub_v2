namespace FightClub
{
    partial class Player1Form
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
            this.userHpProgress = new System.Windows.Forms.ProgressBar();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userHpLabel = new System.Windows.Forms.Label();
            this.defendPanel = new System.Windows.Forms.Panel();
            this.LegsDefendButton = new System.Windows.Forms.Button();
            this.BodyDefendButton = new System.Windows.Forms.Button();
            this.headDefendButton = new System.Windows.Forms.Button();
            this.defLab = new System.Windows.Forms.Label();
            this.AttackPanel = new System.Windows.Forms.Panel();
            this.attackLegsbutton = new System.Windows.Forms.Button();
            this.attackBodybutton = new System.Windows.Forms.Button();
            this.attackHeadButton = new System.Windows.Forms.Button();
            this.AttackLabel = new System.Windows.Forms.Label();
            this.defendPanel.SuspendLayout();
            this.AttackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // userHpProgress
            // 
            this.userHpProgress.Location = new System.Drawing.Point(82, 28);
            this.userHpProgress.Name = "userHpProgress";
            this.userHpProgress.Size = new System.Drawing.Size(179, 23);
            this.userHpProgress.TabIndex = 2;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameLabel.Location = new System.Drawing.Point(171, 9);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(37, 16);
            this.userNameLabel.TabIndex = 4;
            this.userNameLabel.Text = "Имя";
            // 
            // userHpLabel
            // 
            this.userHpLabel.AutoSize = true;
            this.userHpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userHpLabel.Location = new System.Drawing.Point(289, 35);
            this.userHpLabel.Name = "userHpLabel";
            this.userHpLabel.Size = new System.Drawing.Size(16, 16);
            this.userHpLabel.TabIndex = 6;
            this.userHpLabel.Text = "0";
            // 
            // defendPanel
            // 
            this.defendPanel.Controls.Add(this.LegsDefendButton);
            this.defendPanel.Controls.Add(this.BodyDefendButton);
            this.defendPanel.Controls.Add(this.headDefendButton);
            this.defendPanel.Controls.Add(this.defLab);
            this.defendPanel.Location = new System.Drawing.Point(16, 80);
            this.defendPanel.Name = "defendPanel";
            this.defendPanel.Size = new System.Drawing.Size(363, 100);
            this.defendPanel.TabIndex = 8;
            // 
            // LegsDefendButton
            // 
            this.LegsDefendButton.Location = new System.Drawing.Point(276, 56);
            this.LegsDefendButton.Name = "LegsDefendButton";
            this.LegsDefendButton.Size = new System.Drawing.Size(75, 23);
            this.LegsDefendButton.TabIndex = 3;
            this.LegsDefendButton.Text = "Ноги";
            this.LegsDefendButton.UseVisualStyleBackColor = true;
            this.LegsDefendButton.Click += new System.EventHandler(this.LegsDefendButton_Click);
            // 
            // BodyDefendButton
            // 
            this.BodyDefendButton.Location = new System.Drawing.Point(146, 56);
            this.BodyDefendButton.Name = "BodyDefendButton";
            this.BodyDefendButton.Size = new System.Drawing.Size(75, 23);
            this.BodyDefendButton.TabIndex = 2;
            this.BodyDefendButton.Text = "Корпус";
            this.BodyDefendButton.UseVisualStyleBackColor = true;
            this.BodyDefendButton.Click += new System.EventHandler(this.BodyDefendButton_Click);
            // 
            // headDefendButton
            // 
            this.headDefendButton.Location = new System.Drawing.Point(12, 56);
            this.headDefendButton.Name = "headDefendButton";
            this.headDefendButton.Size = new System.Drawing.Size(75, 23);
            this.headDefendButton.TabIndex = 1;
            this.headDefendButton.Text = "Голова";
            this.headDefendButton.UseVisualStyleBackColor = true;
            this.headDefendButton.Click += new System.EventHandler(this.headDefendButton_Click);
            // 
            // defLab
            // 
            this.defLab.AutoSize = true;
            this.defLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.defLab.Location = new System.Drawing.Point(138, 9);
            this.defLab.Name = "defLab";
            this.defLab.Size = new System.Drawing.Size(83, 15);
            this.defLab.TabIndex = 0;
            this.defLab.Text = "Защищайся";
            // 
            // AttackPanel
            // 
            this.AttackPanel.Controls.Add(this.attackLegsbutton);
            this.AttackPanel.Controls.Add(this.attackBodybutton);
            this.AttackPanel.Controls.Add(this.attackHeadButton);
            this.AttackPanel.Controls.Add(this.AttackLabel);
            this.AttackPanel.Location = new System.Drawing.Point(16, 83);
            this.AttackPanel.Name = "AttackPanel";
            this.AttackPanel.Size = new System.Drawing.Size(363, 100);
            this.AttackPanel.TabIndex = 9;
            // 
            // attackLegsbutton
            // 
            this.attackLegsbutton.Location = new System.Drawing.Point(276, 56);
            this.attackLegsbutton.Name = "attackLegsbutton";
            this.attackLegsbutton.Size = new System.Drawing.Size(75, 23);
            this.attackLegsbutton.TabIndex = 3;
            this.attackLegsbutton.Text = "Ноги";
            this.attackLegsbutton.UseVisualStyleBackColor = true;
            this.attackLegsbutton.Click += new System.EventHandler(this.attackLegsbutton_Click);
            // 
            // attackBodybutton
            // 
            this.attackBodybutton.Location = new System.Drawing.Point(146, 56);
            this.attackBodybutton.Name = "attackBodybutton";
            this.attackBodybutton.Size = new System.Drawing.Size(75, 23);
            this.attackBodybutton.TabIndex = 2;
            this.attackBodybutton.Text = "Корпус";
            this.attackBodybutton.UseVisualStyleBackColor = true;
            this.attackBodybutton.Click += new System.EventHandler(this.attackBodybutton_Click);
            // 
            // attackHeadButton
            // 
            this.attackHeadButton.Location = new System.Drawing.Point(12, 56);
            this.attackHeadButton.Name = "attackHeadButton";
            this.attackHeadButton.Size = new System.Drawing.Size(75, 23);
            this.attackHeadButton.TabIndex = 1;
            this.attackHeadButton.Text = "Голова";
            this.attackHeadButton.UseVisualStyleBackColor = true;
            this.attackHeadButton.Click += new System.EventHandler(this.attackHeadButton_Click);
            // 
            // AttackLabel
            // 
            this.AttackLabel.AutoSize = true;
            this.AttackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AttackLabel.Location = new System.Drawing.Point(155, 9);
            this.AttackLabel.Name = "AttackLabel";
            this.AttackLabel.Size = new System.Drawing.Size(52, 15);
            this.AttackLabel.TabIndex = 0;
            this.AttackLabel.Text = "Атакуй";
            // 
            // Player1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 203);
            this.Controls.Add(this.userHpLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.userHpProgress);
            this.Controls.Add(this.defendPanel);
            this.Controls.Add(this.AttackPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Player1Form";
            this.Text = "Player 1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Player1Form_FormClosed);
            this.Load += new System.EventHandler(this.Player1Form_Load);
            this.defendPanel.ResumeLayout(false);
            this.defendPanel.PerformLayout();
            this.AttackPanel.ResumeLayout(false);
            this.AttackPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar userHpProgress;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label userHpLabel;
        private System.Windows.Forms.Panel defendPanel;
        private System.Windows.Forms.Panel AttackPanel;
        private System.Windows.Forms.Button attackLegsbutton;
        private System.Windows.Forms.Button attackBodybutton;
        private System.Windows.Forms.Button attackHeadButton;
        private System.Windows.Forms.Label AttackLabel;
        private System.Windows.Forms.Button LegsDefendButton;
        private System.Windows.Forms.Button BodyDefendButton;
        private System.Windows.Forms.Button headDefendButton;
        private System.Windows.Forms.Label defLab;
    }
}