namespace TasKagitMakas
{
    partial class Form1
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
            this.btnBotTas = new System.Windows.Forms.Button();
            this.btnBotKagit = new System.Windows.Forms.Button();
            this.btnBotMakas = new System.Windows.Forms.Button();
            this.btnUserTas = new System.Windows.Forms.Button();
            this.btnUserKagit = new System.Windows.Forms.Button();
            this.btnUserMakas = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lblSkorBot = new System.Windows.Forms.Label();
            this.lblSkorUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBotTas
            // 
            this.btnBotTas.BackColor = System.Drawing.Color.White;
            this.btnBotTas.Enabled = false;
            this.btnBotTas.Location = new System.Drawing.Point(90, 12);
            this.btnBotTas.Name = "btnBotTas";
            this.btnBotTas.Size = new System.Drawing.Size(129, 47);
            this.btnBotTas.TabIndex = 0;
            this.btnBotTas.Text = "TAŞ";
            this.btnBotTas.UseVisualStyleBackColor = false;
            // 
            // btnBotKagit
            // 
            this.btnBotKagit.BackColor = System.Drawing.Color.White;
            this.btnBotKagit.Enabled = false;
            this.btnBotKagit.Location = new System.Drawing.Point(90, 65);
            this.btnBotKagit.Name = "btnBotKagit";
            this.btnBotKagit.Size = new System.Drawing.Size(129, 47);
            this.btnBotKagit.TabIndex = 1;
            this.btnBotKagit.Text = "KAĞIT";
            this.btnBotKagit.UseVisualStyleBackColor = false;
            // 
            // btnBotMakas
            // 
            this.btnBotMakas.BackColor = System.Drawing.Color.White;
            this.btnBotMakas.Enabled = false;
            this.btnBotMakas.Location = new System.Drawing.Point(90, 118);
            this.btnBotMakas.Name = "btnBotMakas";
            this.btnBotMakas.Size = new System.Drawing.Size(129, 47);
            this.btnBotMakas.TabIndex = 2;
            this.btnBotMakas.Text = "MAKAS";
            this.btnBotMakas.UseVisualStyleBackColor = false;
            // 
            // btnUserTas
            // 
            this.btnUserTas.BackColor = System.Drawing.Color.White;
            this.btnUserTas.Location = new System.Drawing.Point(90, 217);
            this.btnUserTas.Name = "btnUserTas";
            this.btnUserTas.Size = new System.Drawing.Size(129, 47);
            this.btnUserTas.TabIndex = 3;
            this.btnUserTas.Text = "TAŞ";
            this.btnUserTas.UseVisualStyleBackColor = false;
            this.btnUserTas.Click += new System.EventHandler(this.btnUserTas_Click);
            // 
            // btnUserKagit
            // 
            this.btnUserKagit.BackColor = System.Drawing.Color.White;
            this.btnUserKagit.Location = new System.Drawing.Point(90, 270);
            this.btnUserKagit.Name = "btnUserKagit";
            this.btnUserKagit.Size = new System.Drawing.Size(129, 47);
            this.btnUserKagit.TabIndex = 4;
            this.btnUserKagit.Text = "KAĞIT";
            this.btnUserKagit.UseVisualStyleBackColor = false;
            this.btnUserKagit.Click += new System.EventHandler(this.btnUserKagit_Click);
            // 
            // btnUserMakas
            // 
            this.btnUserMakas.BackColor = System.Drawing.Color.White;
            this.btnUserMakas.Location = new System.Drawing.Point(90, 323);
            this.btnUserMakas.Name = "btnUserMakas";
            this.btnUserMakas.Size = new System.Drawing.Size(129, 47);
            this.btnUserMakas.TabIndex = 5;
            this.btnUserMakas.Text = "MAKAS";
            this.btnUserMakas.UseVisualStyleBackColor = false;
            this.btnUserMakas.Click += new System.EventHandler(this.btnUserMakas_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(87, 173);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(155, 32);
            this.lblSonuc.TabIndex = 6;
            this.lblSonuc.Text = "Oyuna başlamak için \r\nbir seçim yapın";
            // 
            // lblSkorBot
            // 
            this.lblSkorBot.AutoSize = true;
            this.lblSkorBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSkorBot.Location = new System.Drawing.Point(221, 12);
            this.lblSkorBot.Name = "lblSkorBot";
            this.lblSkorBot.Size = new System.Drawing.Size(14, 13);
            this.lblSkorBot.TabIndex = 7;
            this.lblSkorBot.Text = "0";
            // 
            // lblSkorUser
            // 
            this.lblSkorUser.AutoSize = true;
            this.lblSkorUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSkorUser.Location = new System.Drawing.Point(225, 217);
            this.lblSkorUser.Name = "lblSkorUser";
            this.lblSkorUser.Size = new System.Drawing.Size(14, 13);
            this.lblSkorUser.TabIndex = 8;
            this.lblSkorUser.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 382);
            this.Controls.Add(this.lblSkorUser);
            this.Controls.Add(this.lblSkorBot);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnUserMakas);
            this.Controls.Add(this.btnUserKagit);
            this.Controls.Add(this.btnUserTas);
            this.Controls.Add(this.btnBotMakas);
            this.Controls.Add(this.btnBotKagit);
            this.Controls.Add(this.btnBotTas);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Taş Kağıt Makas Oyunu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBotTas;
        private System.Windows.Forms.Button btnBotKagit;
        private System.Windows.Forms.Button btnBotMakas;
        private System.Windows.Forms.Button btnUserTas;
        private System.Windows.Forms.Button btnUserKagit;
        private System.Windows.Forms.Button btnUserMakas;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblSkorBot;
        private System.Windows.Forms.Label lblSkorUser;
    }
}

