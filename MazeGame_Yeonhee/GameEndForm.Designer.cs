
namespace MazeGame_Yeonhee
{
    partial class GameEndForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameEndForm));
            this.pbRetry = new System.Windows.Forms.PictureBox();
            this.pbQuit = new System.Windows.Forms.PictureBox();
            this.pbPenguin = new System.Windows.Forms.PictureBox();
            this.lbMainText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPenguin)).BeginInit();
            this.SuspendLayout();
            // 
            // pbRetry
            // 
            this.pbRetry.Image = ((System.Drawing.Image)(resources.GetObject("pbRetry.Image")));
            this.pbRetry.Location = new System.Drawing.Point(194, 318);
            this.pbRetry.Name = "pbRetry";
            this.pbRetry.Size = new System.Drawing.Size(122, 47);
            this.pbRetry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbRetry.TabIndex = 0;
            this.pbRetry.TabStop = false;
            this.pbRetry.Click += new System.EventHandler(this.pbRetry_Click);
            // 
            // pbQuit
            // 
            this.pbQuit.Image = ((System.Drawing.Image)(resources.GetObject("pbQuit.Image")));
            this.pbQuit.Location = new System.Drawing.Point(475, 318);
            this.pbQuit.Name = "pbQuit";
            this.pbQuit.Size = new System.Drawing.Size(122, 47);
            this.pbQuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbQuit.TabIndex = 1;
            this.pbQuit.TabStop = false;
            this.pbQuit.Click += new System.EventHandler(this.pbQuit_Click);
            // 
            // pbPenguin
            // 
            this.pbPenguin.BackColor = System.Drawing.Color.Transparent;
            this.pbPenguin.Image = ((System.Drawing.Image)(resources.GetObject("pbPenguin.Image")));
            this.pbPenguin.Location = new System.Drawing.Point(328, 148);
            this.pbPenguin.Name = "pbPenguin";
            this.pbPenguin.Size = new System.Drawing.Size(128, 128);
            this.pbPenguin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPenguin.TabIndex = 2;
            this.pbPenguin.TabStop = false;
            // 
            // lbMainText
            // 
            this.lbMainText.AutoSize = true;
            this.lbMainText.BackColor = System.Drawing.Color.Transparent;
            this.lbMainText.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMainText.Location = new System.Drawing.Point(274, 91);
            this.lbMainText.Name = "lbMainText";
            this.lbMainText.Size = new System.Drawing.Size(222, 35);
            this.lbMainText.TabIndex = 3;
            this.lbMainText.Text = "Penguin Maze";
            // 
            // GameEndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbMainText);
            this.Controls.Add(this.pbPenguin);
            this.Controls.Add(this.pbQuit);
            this.Controls.Add(this.pbRetry);
            this.Name = "GameEndForm";
            this.Text = "GameEndForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbRetry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPenguin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRetry;
        private System.Windows.Forms.PictureBox pbQuit;
        private System.Windows.Forms.PictureBox pbPenguin;
        private System.Windows.Forms.Label lbMainText;
    }
}