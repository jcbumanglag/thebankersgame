namespace bankers_game_proto
{
    partial class howtoplay
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
            this.pbback1 = new System.Windows.Forms.PictureBox();
            this.pbnext1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnexit = new bankers_game_proto.Curvebutton();
            ((System.ComponentModel.ISupportInitialize)(this.pbback1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbnext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbback1
            // 
            this.pbback1.BackColor = System.Drawing.Color.Transparent;
            this.pbback1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbback1.Location = new System.Drawing.Point(12, 776);
            this.pbback1.Name = "pbback1";
            this.pbback1.Size = new System.Drawing.Size(153, 136);
            this.pbback1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbback1.TabIndex = 2;
            this.pbback1.TabStop = false;
            this.pbback1.Visible = false;
            this.pbback1.Click += new System.EventHandler(this.pbback1_Click);
            // 
            // pbnext1
            // 
            this.pbnext1.BackColor = System.Drawing.Color.Transparent;
            this.pbnext1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbnext1.Location = new System.Drawing.Point(1747, 776);
            this.pbnext1.Name = "pbnext1";
            this.pbnext1.Size = new System.Drawing.Size(153, 136);
            this.pbnext1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbnext1.TabIndex = 1;
            this.pbnext1.TabStop = false;
            this.pbnext1.Click += new System.EventHandler(this.pbnext1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1920, 1080);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(1804, 951);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(96, 90);
            this.btnexit.TabIndex = 3;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // howtoplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1912, 1053);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.pbback1);
            this.Controls.Add(this.pbnext1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "howtoplay";
            this.Text = "howtoplay";
            this.Load += new System.EventHandler(this.howtoplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbback1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbnext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbnext1;
        private System.Windows.Forms.PictureBox pbback1;
        private Curvebutton btnexit;
    }
}