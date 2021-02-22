
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
            this.onGoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newTourBtn
            // 
            this.newTourBtn.BackColor = System.Drawing.Color.Transparent;
            this.newTourBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newTourBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTourBtn.ForeColor = System.Drawing.Color.DarkKhaki;
            this.newTourBtn.Location = new System.Drawing.Point(162, 182);
            this.newTourBtn.Name = "newTourBtn";
            this.newTourBtn.Size = new System.Drawing.Size(195, 54);
            this.newTourBtn.TabIndex = 0;
            this.newTourBtn.Text = "New Tournament";
            this.newTourBtn.UseVisualStyleBackColor = false;
            this.newTourBtn.Click += new System.EventHandler(this.newTourBtn_Click);
            // 
            // onGoBtn
            // 
            this.onGoBtn.BackColor = System.Drawing.Color.Transparent;
            this.onGoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onGoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onGoBtn.ForeColor = System.Drawing.Color.DarkKhaki;
            this.onGoBtn.Location = new System.Drawing.Point(442, 182);
            this.onGoBtn.Name = "onGoBtn";
            this.onGoBtn.Size = new System.Drawing.Size(193, 54);
            this.onGoBtn.TabIndex = 1;
            this.onGoBtn.Text = "Ongoing Tournaments";
            this.onGoBtn.UseVisualStyleBackColor = false;
            this.onGoBtn.Click += new System.EventHandler(this.ongTourBtn_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.onGoBtn);
            this.Controls.Add(this.newTourBtn);
            this.Name = "Homepage";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newTourBtn;
        private System.Windows.Forms.Button onGoBtn;
    }
}