
namespace WindowsFormsApp4
{
    partial class colourChoicePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(colourChoicePage));
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.continueBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label1.Location = new System.Drawing.Point(296, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 61);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Colour";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(377, 71);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 20);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Blue";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.BackColor = System.Drawing.Color.LimeGreen;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(545, 71);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(62, 20);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Green";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            this.checkBox3.BackColor = System.Drawing.Color.Yellow;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.ForeColor = System.Drawing.Color.Black;
            this.checkBox3.Location = new System.Drawing.Point(460, 71);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(62, 20);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Yellow";
            this.checkBox3.UseVisualStyleBackColor = false;
            // 
            // checkBox4
            // 
            this.checkBox4.BackColor = System.Drawing.Color.Red;
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox4.ForeColor = System.Drawing.Color.White;
            this.checkBox4.Location = new System.Drawing.Point(629, 71);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(62, 20);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "Red";
            this.checkBox4.UseVisualStyleBackColor = false;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // continueBtn
            // 
            this.continueBtn.Location = new System.Drawing.Point(497, 275);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(75, 33);
            this.continueBtn.TabIndex = 10;
            this.continueBtn.Text = "Continue";
            this.continueBtn.UseVisualStyleBackColor = true;
            this.continueBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label2.Location = new System.Drawing.Point(227, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Player 1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label3.Location = new System.Drawing.Point(227, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Player 2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBox5
            // 
            this.checkBox5.BackColor = System.Drawing.Color.Red;
            this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox5.ForeColor = System.Drawing.Color.White;
            this.checkBox5.Location = new System.Drawing.Point(629, 126);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(62, 20);
            this.checkBox5.TabIndex = 15;
            this.checkBox5.Text = "Red";
            this.checkBox5.UseVisualStyleBackColor = false;
            // 
            // checkBox6
            // 
            this.checkBox6.BackColor = System.Drawing.Color.Yellow;
            this.checkBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox6.ForeColor = System.Drawing.Color.Black;
            this.checkBox6.Location = new System.Drawing.Point(460, 126);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(62, 20);
            this.checkBox6.TabIndex = 14;
            this.checkBox6.Text = "Yellow";
            this.checkBox6.UseVisualStyleBackColor = false;
            // 
            // checkBox7
            // 
            this.checkBox7.BackColor = System.Drawing.Color.LimeGreen;
            this.checkBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox7.ForeColor = System.Drawing.Color.White;
            this.checkBox7.Location = new System.Drawing.Point(545, 126);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(62, 20);
            this.checkBox7.TabIndex = 13;
            this.checkBox7.Text = "Green";
            this.checkBox7.UseVisualStyleBackColor = false;
            // 
            // checkBox8
            // 
            this.checkBox8.BackColor = System.Drawing.Color.RoyalBlue;
            this.checkBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox8.ForeColor = System.Drawing.Color.White;
            this.checkBox8.Location = new System.Drawing.Point(377, 126);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(62, 20);
            this.checkBox8.TabIndex = 12;
            this.checkBox8.Text = "Blue";
            this.checkBox8.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label4.Location = new System.Drawing.Point(227, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Player 3";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBox9
            // 
            this.checkBox9.BackColor = System.Drawing.Color.Red;
            this.checkBox9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox9.ForeColor = System.Drawing.Color.White;
            this.checkBox9.Location = new System.Drawing.Point(629, 177);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(62, 20);
            this.checkBox9.TabIndex = 20;
            this.checkBox9.Text = "Red";
            this.checkBox9.UseVisualStyleBackColor = false;
            // 
            // checkBox10
            // 
            this.checkBox10.BackColor = System.Drawing.Color.Yellow;
            this.checkBox10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox10.ForeColor = System.Drawing.Color.Black;
            this.checkBox10.Location = new System.Drawing.Point(460, 177);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(62, 20);
            this.checkBox10.TabIndex = 19;
            this.checkBox10.Text = "Yellow";
            this.checkBox10.UseVisualStyleBackColor = false;
            // 
            // checkBox11
            // 
            this.checkBox11.BackColor = System.Drawing.Color.LimeGreen;
            this.checkBox11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox11.ForeColor = System.Drawing.Color.White;
            this.checkBox11.Location = new System.Drawing.Point(545, 177);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(62, 20);
            this.checkBox11.TabIndex = 18;
            this.checkBox11.Text = "Green";
            this.checkBox11.UseVisualStyleBackColor = false;
            // 
            // checkBox12
            // 
            this.checkBox12.BackColor = System.Drawing.Color.RoyalBlue;
            this.checkBox12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox12.ForeColor = System.Drawing.Color.White;
            this.checkBox12.Location = new System.Drawing.Point(377, 177);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(62, 20);
            this.checkBox12.TabIndex = 17;
            this.checkBox12.Text = "Blue";
            this.checkBox12.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label5.Location = new System.Drawing.Point(227, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Player 4";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBox13
            // 
            this.checkBox13.BackColor = System.Drawing.Color.Red;
            this.checkBox13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox13.ForeColor = System.Drawing.Color.White;
            this.checkBox13.Location = new System.Drawing.Point(629, 222);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(62, 20);
            this.checkBox13.TabIndex = 25;
            this.checkBox13.Text = "Red";
            this.checkBox13.UseVisualStyleBackColor = false;
            // 
            // checkBox14
            // 
            this.checkBox14.BackColor = System.Drawing.Color.Yellow;
            this.checkBox14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox14.ForeColor = System.Drawing.Color.Black;
            this.checkBox14.Location = new System.Drawing.Point(460, 222);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(62, 20);
            this.checkBox14.TabIndex = 24;
            this.checkBox14.Text = "Yellow";
            this.checkBox14.UseVisualStyleBackColor = false;
            // 
            // checkBox15
            // 
            this.checkBox15.BackColor = System.Drawing.Color.LimeGreen;
            this.checkBox15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox15.ForeColor = System.Drawing.Color.White;
            this.checkBox15.Location = new System.Drawing.Point(545, 222);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(62, 20);
            this.checkBox15.TabIndex = 23;
            this.checkBox15.Text = "Green";
            this.checkBox15.UseVisualStyleBackColor = false;
            // 
            // checkBox16
            // 
            this.checkBox16.BackColor = System.Drawing.Color.RoyalBlue;
            this.checkBox16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox16.ForeColor = System.Drawing.Color.White;
            this.checkBox16.Location = new System.Drawing.Point(377, 222);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(62, 20);
            this.checkBox16.TabIndex = 22;
            this.checkBox16.Text = "Blue";
            this.checkBox16.UseVisualStyleBackColor = false;
            // 
            // colourChoicePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox13);
            this.Controls.Add(this.checkBox14);
            this.Controls.Add(this.checkBox15);
            this.Controls.Add(this.checkBox16);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox9);
            this.Controls.Add(this.checkBox10);
            this.Controls.Add(this.checkBox11);
            this.Controls.Add(this.checkBox12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.continueBtn);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "colourChoicePage";
            this.Text = "Form6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button continueBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox16;
    }
}