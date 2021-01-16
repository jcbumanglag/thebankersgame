namespace bankers_game_proto
{
    partial class Loadscreen
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
            this.components = new System.ComponentModel.Container();
            this.tmrWork = new System.Windows.Forms.Timer(this.components);
            this.picProgress = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tit1 = new System.Windows.Forms.PictureBox();
            this.txt1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt1)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrWork
            // 
            this.tmrWork.Interval = 500;
            this.tmrWork.Tick += new System.EventHandler(this.tmrWork_Tick);
            // 
            // picProgress
            // 
            this.picProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picProgress.BackColor = System.Drawing.Color.White;
            this.picProgress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picProgress.Location = new System.Drawing.Point(12, 997);
            this.picProgress.Name = "picProgress";
            this.picProgress.Size = new System.Drawing.Size(1888, 24);
            this.picProgress.TabIndex = 3;
            this.picProgress.TabStop = false;
            this.picProgress.Paint += new System.Windows.Forms.PaintEventHandler(this.picProgress_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1750, 825);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tit1
            // 
            this.tit1.BackColor = System.Drawing.Color.Transparent;
            this.tit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tit1.Location = new System.Drawing.Point(833, 573);
            this.tit1.Name = "tit1";
            this.tit1.Size = new System.Drawing.Size(557, 104);
            this.tit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tit1.TabIndex = 5;
            this.tit1.TabStop = false;
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.Color.Transparent;
            this.txt1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt1.Location = new System.Drawing.Point(137, 697);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(1621, 104);
            this.txt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txt1.TabIndex = 6;
            this.txt1.TabStop = false;
            // 
            // Loadscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1912, 1053);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.tit1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picProgress);
            this.Name = "Loadscreen";
            this.Text = "howto_info_on_progressbar";
            this.Load += new System.EventHandler(this.Loadscreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrWork;
        private System.Windows.Forms.PictureBox picProgress;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox tit1;
        private System.Windows.Forms.PictureBox txt1;
    }
}

