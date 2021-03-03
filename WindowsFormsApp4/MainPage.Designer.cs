
namespace WindowsFormsApp4
{
    partial class MainPage
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
            this.backBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.welcPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.enterBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HomePanel = new System.Windows.Forms.Panel();
            this.ongTourBtn = new System.Windows.Forms.Button();
            this.newTourBtn = new System.Windows.Forms.Button();
            this.tourNamePanel = new System.Windows.Forms.Panel();
            this.nextBtn = new System.Windows.Forms.Button();
            this.tourNameInp = new System.Windows.Forms.TextBox();
            this.enterTourName = new System.Windows.Forms.Label();
            this.PlayerChoicePanel = new System.Windows.Forms.Panel();
            this.PlayerTitle = new System.Windows.Forms.Label();
            this.regChcBtn = new System.Windows.Forms.Button();
            this.lgnChcBtn = new System.Windows.Forms.Button();
            this.welcPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.HomePanel.SuspendLayout();
            this.tourNamePanel.SuspendLayout();
            this.PlayerChoicePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.DarkKhaki;
            this.backBtn.Location = new System.Drawing.Point(13, 14);
            this.backBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(133, 59);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "< BACK";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.homeBtn.BackColor = System.Drawing.Color.Transparent;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.DarkKhaki;
            this.homeBtn.Location = new System.Drawing.Point(1035, 12);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(133, 59);
            this.homeBtn.TabIndex = 1;
            this.homeBtn.Text = "HOME";
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // welcPanel
            // 
            this.welcPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.welcPanel.BackColor = System.Drawing.Color.Transparent;
            this.welcPanel.Controls.Add(this.pictureBox1);
            this.welcPanel.Controls.Add(this.pictureBox2);
            this.welcPanel.Controls.Add(this.label2);
            this.welcPanel.Controls.Add(this.enterBtn);
            this.welcPanel.Controls.Add(this.label1);
            this.welcPanel.Location = new System.Drawing.Point(189, 143);
            this.welcPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.welcPanel.Name = "welcPanel";
            this.welcPanel.Size = new System.Drawing.Size(812, 534);
            this.welcPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.pictureBox1.Image = global::WindowsFormsApp4.Properties.Resources.dice_169063;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Image = global::WindowsFormsApp4.Properties.Resources.dice_169063;
            this.pictureBox2.Location = new System.Drawing.Point(717, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(93, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label2.Location = new System.Drawing.Point(533, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "By cypherTrio";
            // 
            // enterBtn
            // 
            this.enterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.enterBtn.BackColor = System.Drawing.Color.Transparent;
            this.enterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterBtn.ForeColor = System.Drawing.Color.DarkKhaki;
            this.enterBtn.Location = new System.Drawing.Point(325, 470);
            this.enterBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(199, 60);
            this.enterBtn.TabIndex = 5;
            this.enterBtn.Text = "Let\'s  Roll";
            this.enterBtn.UseVisualStyleBackColor = false;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label1.Location = new System.Drawing.Point(88, 196);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(681, 134);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ludo Tournament";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            this.label1.UseWaitCursor = true;
            // 
            // HomePanel
            // 
            this.HomePanel.BackColor = System.Drawing.Color.Transparent;
            this.HomePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HomePanel.Controls.Add(this.ongTourBtn);
            this.HomePanel.Controls.Add(this.newTourBtn);
            this.HomePanel.Location = new System.Drawing.Point(189, 143);
            this.HomePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(812, 534);
            this.HomePanel.TabIndex = 9;
            this.HomePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HomePanel_Paint);
            // 
            // ongTourBtn
            // 
            this.ongTourBtn.BackColor = System.Drawing.Color.Transparent;
            this.ongTourBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ongTourBtn.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ongTourBtn.ForeColor = System.Drawing.Color.DarkKhaki;
            this.ongTourBtn.Location = new System.Drawing.Point(471, 231);
            this.ongTourBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ongTourBtn.Name = "ongTourBtn";
            this.ongTourBtn.Size = new System.Drawing.Size(257, 66);
            this.ongTourBtn.TabIndex = 3;
            this.ongTourBtn.Text = "Ongoing Tournaments";
            this.ongTourBtn.UseVisualStyleBackColor = false;
            this.ongTourBtn.Click += new System.EventHandler(this.ongTourBtn_Click);
            // 
            // newTourBtn
            // 
            this.newTourBtn.BackColor = System.Drawing.Color.Transparent;
            this.newTourBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newTourBtn.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTourBtn.ForeColor = System.Drawing.Color.DarkKhaki;
            this.newTourBtn.Location = new System.Drawing.Point(99, 231);
            this.newTourBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newTourBtn.Name = "newTourBtn";
            this.newTourBtn.Size = new System.Drawing.Size(260, 66);
            this.newTourBtn.TabIndex = 2;
            this.newTourBtn.Text = "New Tournament";
            this.newTourBtn.UseVisualStyleBackColor = false;
            this.newTourBtn.Click += new System.EventHandler(this.newTourBtn_Click);
            // 
            // tourNamePanel
            // 
            this.tourNamePanel.BackColor = System.Drawing.Color.Transparent;
            this.tourNamePanel.Controls.Add(this.nextBtn);
            this.tourNamePanel.Controls.Add(this.tourNameInp);
            this.tourNamePanel.Controls.Add(this.enterTourName);
            this.tourNamePanel.Location = new System.Drawing.Point(189, 143);
            this.tourNamePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tourNamePanel.Name = "tourNamePanel";
            this.tourNamePanel.Size = new System.Drawing.Size(812, 534);
            this.tourNamePanel.TabIndex = 10;
            // 
            // nextBtn
            // 
            this.nextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nextBtn.BackColor = System.Drawing.Color.Transparent;
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.ForeColor = System.Drawing.Color.DarkKhaki;
            this.nextBtn.Location = new System.Drawing.Point(323, 391);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(167, 60);
            this.nextBtn.TabIndex = 13;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // tourNameInp
            // 
            this.tourNameInp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tourNameInp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tourNameInp.Location = new System.Drawing.Point(189, 262);
            this.tourNameInp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tourNameInp.Multiline = true;
            this.tourNameInp.Name = "tourNameInp";
            this.tourNameInp.Size = new System.Drawing.Size(435, 50);
            this.tourNameInp.TabIndex = 12;
            // 
            // enterTourName
            // 
            this.enterTourName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.enterTourName.BackColor = System.Drawing.Color.Transparent;
            this.enterTourName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterTourName.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterTourName.ForeColor = System.Drawing.Color.DarkKhaki;
            this.enterTourName.Location = new System.Drawing.Point(204, 82);
            this.enterTourName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enterTourName.Name = "enterTourName";
            this.enterTourName.Size = new System.Drawing.Size(405, 164);
            this.enterTourName.TabIndex = 11;
            this.enterTourName.Text = "Enter the Tournament Name";
            this.enterTourName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerChoicePanel
            // 
            this.PlayerChoicePanel.BackColor = System.Drawing.Color.Transparent;
            this.PlayerChoicePanel.Controls.Add(this.PlayerTitle);
            this.PlayerChoicePanel.Controls.Add(this.regChcBtn);
            this.PlayerChoicePanel.Controls.Add(this.lgnChcBtn);
            this.PlayerChoicePanel.Location = new System.Drawing.Point(187, 140);
            this.PlayerChoicePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayerChoicePanel.Name = "PlayerChoicePanel";
            this.PlayerChoicePanel.Size = new System.Drawing.Size(812, 534);
            this.PlayerChoicePanel.TabIndex = 14;
            // 
            // PlayerTitle
            // 
            this.PlayerTitle.BackColor = System.Drawing.Color.Transparent;
            this.PlayerTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayerTitle.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerTitle.ForeColor = System.Drawing.Color.DarkKhaki;
            this.PlayerTitle.Location = new System.Drawing.Point(253, 81);
            this.PlayerTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerTitle.Name = "PlayerTitle";
            this.PlayerTitle.Size = new System.Drawing.Size(328, 75);
            this.PlayerTitle.TabIndex = 7;
            this.PlayerTitle.Text = "Player 1";
            this.PlayerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // regChcBtn
            // 
            this.regChcBtn.BackColor = System.Drawing.Color.Transparent;
            this.regChcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regChcBtn.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regChcBtn.ForeColor = System.Drawing.Color.DarkKhaki;
            this.regChcBtn.Location = new System.Drawing.Point(484, 278);
            this.regChcBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.regChcBtn.Name = "regChcBtn";
            this.regChcBtn.Size = new System.Drawing.Size(257, 66);
            this.regChcBtn.TabIndex = 6;
            this.regChcBtn.Text = "REGISTER";
            this.regChcBtn.UseVisualStyleBackColor = false;
            this.regChcBtn.Click += new System.EventHandler(this.regChcBtn_Click);
            // 
            // lgnChcBtn
            // 
            this.lgnChcBtn.BackColor = System.Drawing.Color.Transparent;
            this.lgnChcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lgnChcBtn.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgnChcBtn.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lgnChcBtn.Location = new System.Drawing.Point(103, 278);
            this.lgnChcBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lgnChcBtn.Name = "lgnChcBtn";
            this.lgnChcBtn.Size = new System.Drawing.Size(260, 66);
            this.lgnChcBtn.TabIndex = 5;
            this.lgnChcBtn.Text = "LOGIN";
            this.lgnChcBtn.UseVisualStyleBackColor = false;
            this.lgnChcBtn.Click += new System.EventHandler(this.lgnChcBtn_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1181, 766);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.welcPanel);
            this.Controls.Add(this.PlayerChoicePanel);
            this.Controls.Add(this.tourNamePanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.welcPanel.ResumeLayout(false);
            this.welcPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.HomePanel.ResumeLayout(false);
            this.tourNamePanel.ResumeLayout(false);
            this.tourNamePanel.PerformLayout();
            this.PlayerChoicePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Panel welcPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Button ongTourBtn;
        private System.Windows.Forms.Button newTourBtn;
        private System.Windows.Forms.Panel tourNamePanel;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.TextBox tourNameInp;
        private System.Windows.Forms.Label enterTourName;
        private System.Windows.Forms.Panel PlayerChoicePanel;
        private System.Windows.Forms.Label PlayerTitle;
        private System.Windows.Forms.Button regChcBtn;
        private System.Windows.Forms.Button lgnChcBtn;
    }
}