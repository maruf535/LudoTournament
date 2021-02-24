
namespace WindowsFormsApp4
{
    partial class game
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
            this.ludoBoard = new System.Windows.Forms.Panel();
            this.greenToken1 = new System.Windows.Forms.PictureBox();
            this.ludoBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.greenToken1)).BeginInit();
            this.SuspendLayout();
            // 
            // ludoBoard
            // 
            this.ludoBoard.BackColor = System.Drawing.Color.Transparent;
            this.ludoBoard.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.ludoBoard;
            this.ludoBoard.Controls.Add(this.greenToken1);
            this.ludoBoard.Location = new System.Drawing.Point(226, 73);
            this.ludoBoard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ludoBoard.Name = "ludoBoard";
            this.ludoBoard.Size = new System.Drawing.Size(481, 497);
            this.ludoBoard.TabIndex = 0;
            // 
            // greenToken1
            // 
            this.greenToken1.Location = new System.Drawing.Point(32, 199);
            this.greenToken1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.greenToken1.Name = "greenToken1";
            this.greenToken1.Size = new System.Drawing.Size(28, 32);
            this.greenToken1.TabIndex = 0;
            this.greenToken1.TabStop = false;
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(886, 609);
            this.Controls.Add(this.ludoBoard);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "game";
            this.Text = "game";
            this.ludoBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.greenToken1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ludoBoard;
        private System.Windows.Forms.PictureBox greenToken1;
    }
}