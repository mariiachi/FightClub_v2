namespace FightClub
{
    partial class LogInForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.header = new System.Windows.Forms.Label();
            this.header2 = new System.Windows.Forms.Label();
            this.userNameInputInvite = new System.Windows.Forms.Label();
            this.userNameInput = new System.Windows.Forms.TextBox();
            this.LogInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.header.Location = new System.Drawing.Point(92, 27);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(261, 16);
            this.header.TabIndex = 0;
            this.header.Text = "Добро пожаловать в Бойцовский клуб.";
            // 
            // header2
            // 
            this.header2.AutoSize = true;
            this.header2.Location = new System.Drawing.Point(125, 59);
            this.header2.Name = "header2";
            this.header2.Size = new System.Drawing.Size(194, 26);
            this.header2.TabIndex = 1;
            this.header2.Text = "Первое правило Бойцовского клуба:\r\nне упоминать о Бойцовском клубе.";
            // 
            // userNameInputInvite
            // 
            this.userNameInputInvite.AutoSize = true;
            this.userNameInputInvite.Location = new System.Drawing.Point(193, 108);
            this.userNameInputInvite.Name = "userNameInputInvite";
            this.userNameInputInvite.Size = new System.Drawing.Size(58, 13);
            this.userNameInputInvite.TabIndex = 2;
            this.userNameInputInvite.Text = "Твоё имя:";
            // 
            // userNameInput
            // 
            this.userNameInput.Location = new System.Drawing.Point(173, 135);
            this.userNameInput.Name = "userNameInput";
            this.userNameInput.Size = new System.Drawing.Size(100, 20);
            this.userNameInput.TabIndex = 3;
            // 
            // LogInButton
            // 
            this.LogInButton.Location = new System.Drawing.Point(173, 162);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(100, 23);
            this.LogInButton.TabIndex = 4;
            this.LogInButton.Text = "Войти";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 296);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.userNameInput);
            this.Controls.Add(this.userNameInputInvite);
            this.Controls.Add(this.header2);
            this.Controls.Add(this.header);
            this.Name = "LogInForm";
            this.Text = "Fight Club";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label header2;
        private System.Windows.Forms.Label userNameInputInvite;
        private System.Windows.Forms.TextBox userNameInput;
        private System.Windows.Forms.Button LogInButton;
    }
}

