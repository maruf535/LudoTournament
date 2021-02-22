
namespace WindowsFormsApp4
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.playerLgnBtn = new System.Windows.Forms.Button();
            this.passwordInp = new System.Windows.Forms.TextBox();
            this.usernameInp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(310, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player ONE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerLgnBtn
            // 
            this.playerLgnBtn.BackColor = System.Drawing.Color.Transparent;
            this.playerLgnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playerLgnBtn.ForeColor = System.Drawing.Color.DarkKhaki;
            this.playerLgnBtn.Location = new System.Drawing.Point(429, 249);
            this.playerLgnBtn.Name = "playerLgnBtn";
            this.playerLgnBtn.Size = new System.Drawing.Size(75, 23);
            this.playerLgnBtn.TabIndex = 9;
            this.playerLgnBtn.Text = "LOGIN";
            this.playerLgnBtn.UseVisualStyleBackColor = false;
            this.playerLgnBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // passwordInp
            // 
            this.passwordInp.Location = new System.Drawing.Point(357, 197);
            this.passwordInp.Name = "passwordInp";
            this.passwordInp.PasswordChar = '*';
            this.passwordInp.Size = new System.Drawing.Size(148, 20);
            this.passwordInp.TabIndex = 8;
            // 
            // usernameInp
            // 
            this.usernameInp.Location = new System.Drawing.Point(357, 148);
            this.usernameInp.Name = "usernameInp";
            this.usernameInp.Size = new System.Drawing.Size(148, 20);
            this.usernameInp.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Username";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playerLgnBtn);
            this.Controls.Add(this.passwordInp);
            this.Controls.Add(this.usernameInp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button playerLgnBtn;
        private System.Windows.Forms.TextBox passwordInp;
        private System.Windows.Forms.TextBox usernameInp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}