
namespace MazeGame_Yeonhee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbMap = new System.Windows.Forms.PictureBox();
            this.lbLives = new System.Windows.Forms.Label();
            this.lbEnergies = new System.Windows.Forms.Label();
            this.lbWallBreakers = new System.Windows.Forms.Label();
            this.pbHint = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHint)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMap
            // 
            this.pbMap.BackColor = System.Drawing.Color.Transparent;
            this.pbMap.Location = new System.Drawing.Point(0, 31);
            this.pbMap.Name = "pbMap";
            this.pbMap.Size = new System.Drawing.Size(449, 354);
            this.pbMap.TabIndex = 0;
            this.pbMap.TabStop = false;
            this.pbMap.Paint += new System.Windows.Forms.PaintEventHandler(this.pbMap_Paint);
            // 
            // lbLives
            // 
            this.lbLives.AutoSize = true;
            this.lbLives.BackColor = System.Drawing.Color.Transparent;
            this.lbLives.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLives.Location = new System.Drawing.Point(0, 0);
            this.lbLives.Name = "lbLives";
            this.lbLives.Size = new System.Drawing.Size(109, 31);
            this.lbLives.TabIndex = 1;
            this.lbLives.Text = "Lives: 3";
            // 
            // lbEnergies
            // 
            this.lbEnergies.AutoSize = true;
            this.lbEnergies.BackColor = System.Drawing.Color.Transparent;
            this.lbEnergies.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnergies.Location = new System.Drawing.Point(381, 0);
            this.lbEnergies.Name = "lbEnergies";
            this.lbEnergies.Size = new System.Drawing.Size(184, 31);
            this.lbEnergies.TabIndex = 2;
            this.lbEnergies.Text = "Energies: 100";
            // 
            // lbWallBreakers
            // 
            this.lbWallBreakers.AutoSize = true;
            this.lbWallBreakers.BackColor = System.Drawing.Color.Transparent;
            this.lbWallBreakers.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWallBreakers.Location = new System.Drawing.Point(132, 0);
            this.lbWallBreakers.Name = "lbWallBreakers";
            this.lbWallBreakers.Size = new System.Drawing.Size(220, 31);
            this.lbWallBreakers.TabIndex = 3;
            this.lbWallBreakers.Text = "Wall Breakers: 3";
            // 
            // pbHint
            // 
            this.pbHint.Image = ((System.Drawing.Image)(resources.GetObject("pbHint.Image")));
            this.pbHint.Location = new System.Drawing.Point(600, 0);
            this.pbHint.Name = "pbHint";
            this.pbHint.Size = new System.Drawing.Size(100, 31);
            this.pbHint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHint.TabIndex = 5;
            this.pbHint.TabStop = false;
            this.pbHint.Click += new System.EventHandler(this.pbHint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbHint);
            this.Controls.Add(this.lbWallBreakers);
            this.Controls.Add(this.lbEnergies);
            this.Controls.Add(this.lbLives);
            this.Controls.Add(this.pbMap);
            this.Name = "Form1";
            this.Text = "Maze Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMap;
        private System.Windows.Forms.Label lbLives;
        private System.Windows.Forms.Label lbEnergies;
        private System.Windows.Forms.Label lbWallBreakers;
        private System.Windows.Forms.PictureBox pbHint;
    }
}

