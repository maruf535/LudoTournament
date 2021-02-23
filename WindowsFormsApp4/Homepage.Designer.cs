
namespace WindowsFormsApp4
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.newTourBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newTourBtn
            // 
            this.newTourBtn.BackColor = System.Drawing.Color.Transparent;
            this.newTourBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newTourBtn.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTourBtn.ForeColor = System.Drawing.Color.DarkKhaki;
            this.newTourBtn.Location = new System.Drawing.Point(216, 224);
            this.newTourBtn.Margin = new System.Windows.Forms.Padding(4);
            this.newTourBtn.Name = "newTourBtn";
            this.newTourBtn.Size = new System.Drawing.Size(260, 66);
            this.newTourBtn.TabIndex = 0;
            this.newTourBtn.Text = "New Tournament";
            this.newTourBtn.UseVisualStyleBackColor = false;
            this.newTourBtn.Click += new System.EventHandler(this.newTourBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkKhaki;
            this.button2.Location = new System.Drawing.Point(589, 224);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(257, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ongoing Tournaments";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ongTourBtn_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.newTourBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Homepage";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newTourBtn;
        private System.Windows.Forms.Button button2;
    }
}