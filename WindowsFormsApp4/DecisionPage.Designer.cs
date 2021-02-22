
namespace WindowsFormsApp4
{
    partial class DecisionPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.restartBtn = new System.Windows.Forms.Button();
            this.resumeBtn = new System.Windows.Forms.Button();
            this.showRankBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label1.Location = new System.Drawing.Point(285, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tournament_Name_1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // restartBtn
            // 
            this.restartBtn.BackColor = System.Drawing.Color.Transparent;
            this.restartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartBtn.ForeColor = System.Drawing.Color.DarkKhaki;
            this.restartBtn.Location = new System.Drawing.Point(408, 178);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(150, 50);
            this.restartBtn.TabIndex = 4;
            this.restartBtn.Text = "Restart";
            this.restartBtn.UseVisualStyleBackColor = false;
            // 
            // resumeBtn
            // 
            this.resumeBtn.BackColor = System.Drawing.Color.Transparent;
            this.resumeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resumeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resumeBtn.ForeColor = System.Drawing.Color.DarkKhaki;
            this.resumeBtn.Location = new System.Drawing.Point(238, 178);
            this.resumeBtn.Name = "resumeBtn";
            this.resumeBtn.Size = new System.Drawing.Size(150, 50);
            this.resumeBtn.TabIndex = 3;
            this.resumeBtn.Text = "Resume";
            this.resumeBtn.UseVisualStyleBackColor = false;
            // 
            // showRankBtn
            // 
            this.showRankBtn.BackColor = System.Drawing.Color.Transparent;
            this.showRankBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showRankBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showRankBtn.ForeColor = System.Drawing.Color.DarkKhaki;
            this.showRankBtn.Location = new System.Drawing.Point(238, 263);
            this.showRankBtn.Name = "showRankBtn";
            this.showRankBtn.Size = new System.Drawing.Size(320, 50);
            this.showRankBtn.TabIndex = 5;
            this.showRankBtn.Text = "Show Ranks";
            this.showRankBtn.UseVisualStyleBackColor = false;
            this.showRankBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // TournamentName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showRankBtn);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.resumeBtn);
            this.Controls.Add(this.label1);
            this.Name = "TournamentName";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TournamentName_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.Button resumeBtn;
        private System.Windows.Forms.Button showRankBtn;
    }
}