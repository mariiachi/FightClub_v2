namespace FightClub
{
    partial class Player2Form
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
            this.compHpLabel = new System.Windows.Forms.Label();
            this.compNameLabel = new System.Windows.Forms.Label();
            this.compHpProgress = new System.Windows.Forms.ProgressBar();
            this.CompActLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // compHpLabel
            // 
            this.compHpLabel.AutoSize = true;
            this.compHpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.compHpLabel.Location = new System.Drawing.Point(234, 35);
            this.compHpLabel.Name = "compHpLabel";
            this.compHpLabel.Size = new System.Drawing.Size(16, 16);
            this.compHpLabel.TabIndex = 10;
            this.compHpLabel.Text = "0";
            // 
            // compNameLabel
            // 
            this.compNameLabel.AutoSize = true;
            this.compNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.compNameLabel.Location = new System.Drawing.Point(90, 9);
            this.compNameLabel.Name = "compNameLabel";
            this.compNameLabel.Size = new System.Drawing.Size(90, 16);
            this.compNameLabel.TabIndex = 9;
            this.compNameLabel.Text = "Компьютер";
            // 
            // compHpProgress
            // 
            this.compHpProgress.Location = new System.Drawing.Point(29, 28);
            this.compHpProgress.Name = "compHpProgress";
            this.compHpProgress.Size = new System.Drawing.Size(179, 23);
            this.compHpProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.compHpProgress.TabIndex = 8;
            // 
            // CompActLabel
            // 
            this.CompActLabel.AutoSize = true;
            this.CompActLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompActLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompActLabel.Location = new System.Drawing.Point(93, 126);
            this.CompActLabel.Name = "CompActLabel";
            this.CompActLabel.Size = new System.Drawing.Size(50, 20);
            this.CompActLabel.TabIndex = 11;
            this.CompActLabel.Text = "action";
            // 
            // Player2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 203);
            this.Controls.Add(this.CompActLabel);
            this.Controls.Add(this.compHpLabel);
            this.Controls.Add(this.compNameLabel);
            this.Controls.Add(this.compHpProgress);
            this.Name = "Player2Form";
            this.Text = "Player 2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Player2Form_FormClosed);
            this.Load += new System.EventHandler(this.Player2Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label compHpLabel;
        private System.Windows.Forms.Label compNameLabel;
        private System.Windows.Forms.ProgressBar compHpProgress;
        private System.Windows.Forms.Label CompActLabel;
    }
}