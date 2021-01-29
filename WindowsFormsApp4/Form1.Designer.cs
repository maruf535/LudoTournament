
namespace WindowsFormsApp4
{
    partial class frmRegister
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lgNameInp = new System.Windows.Forms.TextBox();
            this.lgIdInp = new System.Windows.Forms.TextBox();
            this.lgIntakeInp = new System.Windows.Forms.TextBox();
            this.lgSectionInp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lgPasswordInp = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgStdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgIntake = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Intake";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Section";
            // 
            // lgNameInp
            // 
            this.lgNameInp.Location = new System.Drawing.Point(165, 87);
            this.lgNameInp.Name = "lgNameInp";
            this.lgNameInp.Size = new System.Drawing.Size(141, 20);
            this.lgNameInp.TabIndex = 4;
            // 
            // lgIdInp
            // 
            this.lgIdInp.Location = new System.Drawing.Point(426, 84);
            this.lgIdInp.Name = "lgIdInp";
            this.lgIdInp.Size = new System.Drawing.Size(141, 20);
            this.lgIdInp.TabIndex = 5;
            // 
            // lgIntakeInp
            // 
            this.lgIntakeInp.Location = new System.Drawing.Point(165, 137);
            this.lgIntakeInp.Name = "lgIntakeInp";
            this.lgIntakeInp.Size = new System.Drawing.Size(141, 20);
            this.lgIntakeInp.TabIndex = 6;
            // 
            // lgSectionInp
            // 
            this.lgSectionInp.Location = new System.Drawing.Point(426, 133);
            this.lgSectionInp.Name = "lgSectionInp";
            this.lgSectionInp.Size = new System.Drawing.Size(141, 20);
            this.lgSectionInp.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(177, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(296, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(426, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button4.Location = new System.Drawing.Point(553, 192);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Login";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(593, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Password";
            // 
            // lgPasswordInp
            // 
            this.lgPasswordInp.Location = new System.Drawing.Point(662, 83);
            this.lgPasswordInp.Name = "lgPasswordInp";
            this.lgPasswordInp.PasswordChar = '*';
            this.lgPasswordInp.Size = new System.Drawing.Size(100, 20);
            this.lgPasswordInp.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgSL,
            this.dgStdId,
            this.dgName,
            this.dgIntake,
            this.dgSection,
            this.dgPassword});
            this.dataGridView1.Location = new System.Drawing.Point(165, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(531, 183);
            this.dataGridView1.TabIndex = 14;
            // 
            // dgSL
            // 
            this.dgSL.HeaderText = "Serial";
            this.dgSL.Name = "dgSL";
            // 
            // dgStdId
            // 
            this.dgStdId.HeaderText = "ID";
            this.dgStdId.Name = "dgStdId";
            // 
            // dgName
            // 
            this.dgName.HeaderText = "Name";
            this.dgName.Name = "dgName";
            // 
            // dgIntake
            // 
            this.dgIntake.HeaderText = "Intake";
            this.dgIntake.Name = "dgIntake";
            // 
            // dgSection
            // 
            this.dgSection.HeaderText = "Section";
            this.dgSection.Name = "dgSection";
            // 
            // dgPassword
            // 
            this.dgPassword.HeaderText = "Password";
            this.dgPassword.Name = "dgPassword";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.california_1751455_1920;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lgPasswordInp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lgSectionInp);
            this.Controls.Add(this.lgIntakeInp);
            this.Controls.Add(this.lgIdInp);
            this.Controls.Add(this.lgNameInp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRegister";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lgNameInp;
        private System.Windows.Forms.TextBox lgIdInp;
        private System.Windows.Forms.TextBox lgIntakeInp;
        private System.Windows.Forms.TextBox lgSectionInp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lgPasswordInp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgStdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIntake;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPassword;
    }
}

