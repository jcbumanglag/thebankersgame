namespace bankers_game_proto
{
    partial class Player_Select
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gamemode = new System.Windows.Forms.GroupBox();
            this.extr1 = new System.Windows.Forms.CheckBox();
            this.class1 = new System.Windows.Forms.CheckBox();
            this.rushpl1 = new System.Windows.Forms.RadioButton();
            this.freepl1 = new System.Windows.Forms.RadioButton();
            this.p2grp = new System.Windows.Forms.GroupBox();
            this.p4rad = new System.Windows.Forms.RadioButton();
            this.p3rad = new System.Windows.Forms.RadioButton();
            this.p2rad = new System.Windows.Forms.RadioButton();
            this.btnmulti1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnstart = new System.Windows.Forms.Button();
            this.btnexit = new bankers_game_proto.Curvebutton();
            this.btnmulti2 = new System.Windows.Forms.Button();
            this.btnvs = new System.Windows.Forms.Button();
            this.rusheedd = new System.Windows.Forms.Timer(this.components);
            this.colorss = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.gamemode.SuspendLayout();
            this.p2grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.gamemode);
            this.groupBox1.Controls.Add(this.p2grp);
            this.groupBox1.Controls.Add(this.btnmulti1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnstart);
            this.groupBox1.Controls.Add(this.btnexit);
            this.groupBox1.Controls.Add(this.btnmulti2);
            this.groupBox1.Controls.Add(this.btnvs);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1920, 1080);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // gamemode
            // 
            this.gamemode.BackColor = System.Drawing.SystemColors.Control;
            this.gamemode.Controls.Add(this.extr1);
            this.gamemode.Controls.Add(this.class1);
            this.gamemode.Controls.Add(this.rushpl1);
            this.gamemode.Controls.Add(this.freepl1);
            this.gamemode.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamemode.ForeColor = System.Drawing.Color.White;
            this.gamemode.Location = new System.Drawing.Point(699, 826);
            this.gamemode.Name = "gamemode";
            this.gamemode.Size = new System.Drawing.Size(618, 107);
            this.gamemode.TabIndex = 15;
            this.gamemode.TabStop = false;
            this.gamemode.Text = "Game Mode";
            this.gamemode.Visible = false;
            // 
            // extr1
            // 
            this.extr1.AutoSize = true;
            this.extr1.BackColor = System.Drawing.Color.Transparent;
            this.extr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extr1.Location = new System.Drawing.Point(293, 70);
            this.extr1.Name = "extr1";
            this.extr1.Size = new System.Drawing.Size(94, 24);
            this.extr1.TabIndex = 3;
            this.extr1.Text = "Extreme";
            this.extr1.UseVisualStyleBackColor = false;
            this.extr1.Visible = false;
            this.extr1.CheckedChanged += new System.EventHandler(this.extr1_CheckedChanged);
            // 
            // class1
            // 
            this.class1.AutoSize = true;
            this.class1.BackColor = System.Drawing.Color.Transparent;
            this.class1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class1.Location = new System.Drawing.Point(172, 70);
            this.class1.Name = "class1";
            this.class1.Size = new System.Drawing.Size(85, 24);
            this.class1.TabIndex = 2;
            this.class1.Text = "Classic";
            this.class1.UseVisualStyleBackColor = false;
            this.class1.Visible = false;
            this.class1.CheckedChanged += new System.EventHandler(this.class1_CheckedChanged);
            // 
            // rushpl1
            // 
            this.rushpl1.BackColor = System.Drawing.Color.Transparent;
            this.rushpl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushpl1.ForeColor = System.Drawing.Color.White;
            this.rushpl1.Location = new System.Drawing.Point(172, 39);
            this.rushpl1.Name = "rushpl1";
            this.rushpl1.Size = new System.Drawing.Size(158, 29);
            this.rushpl1.TabIndex = 1;
            this.rushpl1.TabStop = true;
            this.rushpl1.Text = "Bank rush";
            this.rushpl1.UseVisualStyleBackColor = false;
            this.rushpl1.CheckedChanged += new System.EventHandler(this.rushpl1_CheckedChanged);
            // 
            // freepl1
            // 
            this.freepl1.BackColor = System.Drawing.Color.Transparent;
            this.freepl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freepl1.ForeColor = System.Drawing.Color.White;
            this.freepl1.Location = new System.Drawing.Point(8, 35);
            this.freepl1.Name = "freepl1";
            this.freepl1.Size = new System.Drawing.Size(158, 36);
            this.freepl1.TabIndex = 0;
            this.freepl1.TabStop = true;
            this.freepl1.Text = "Free-to-play";
            this.freepl1.UseVisualStyleBackColor = false;
            // 
            // p2grp
            // 
            this.p2grp.BackColor = System.Drawing.SystemColors.Control;
            this.p2grp.Controls.Add(this.p4rad);
            this.p2grp.Controls.Add(this.p3rad);
            this.p2grp.Controls.Add(this.p2rad);
            this.p2grp.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2grp.ForeColor = System.Drawing.Color.White;
            this.p2grp.Location = new System.Drawing.Point(699, 636);
            this.p2grp.Name = "p2grp";
            this.p2grp.Size = new System.Drawing.Size(618, 184);
            this.p2grp.TabIndex = 14;
            this.p2grp.TabStop = false;
            this.p2grp.Text = "Player Position";
            this.p2grp.Visible = false;
            // 
            // p4rad
            // 
            this.p4rad.BackColor = System.Drawing.Color.Transparent;
            this.p4rad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p4rad.ForeColor = System.Drawing.Color.White;
            this.p4rad.Location = new System.Drawing.Point(224, 110);
            this.p4rad.Name = "p4rad";
            this.p4rad.Size = new System.Drawing.Size(158, 29);
            this.p4rad.TabIndex = 2;
            this.p4rad.TabStop = true;
            this.p4rad.Text = "P4 (Right Side)";
            this.p4rad.UseVisualStyleBackColor = false;
            // 
            // p3rad
            // 
            this.p3rad.BackColor = System.Drawing.Color.Transparent;
            this.p3rad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p3rad.ForeColor = System.Drawing.Color.White;
            this.p3rad.Location = new System.Drawing.Point(224, 75);
            this.p3rad.Name = "p3rad";
            this.p3rad.Size = new System.Drawing.Size(158, 29);
            this.p3rad.TabIndex = 1;
            this.p3rad.TabStop = true;
            this.p3rad.Text = "P3 (Top Side)";
            this.p3rad.UseVisualStyleBackColor = false;
            // 
            // p2rad
            // 
            this.p2rad.BackColor = System.Drawing.Color.Transparent;
            this.p2rad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2rad.ForeColor = System.Drawing.Color.White;
            this.p2rad.Location = new System.Drawing.Point(224, 40);
            this.p2rad.Name = "p2rad";
            this.p2rad.Size = new System.Drawing.Size(158, 36);
            this.p2rad.TabIndex = 0;
            this.p2rad.TabStop = true;
            this.p2rad.Text = "P2 (Left Side)";
            this.p2rad.UseVisualStyleBackColor = false;
            // 
            // btnmulti1
            // 
            this.btnmulti1.Location = new System.Drawing.Point(830, 332);
            this.btnmulti1.Name = "btnmulti1";
            this.btnmulti1.Size = new System.Drawing.Size(354, 284);
            this.btnmulti1.TabIndex = 13;
            this.btnmulti1.UseVisualStyleBackColor = true;
            this.btnmulti1.Click += new System.EventHandler(this.btnmulti1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1755, 741);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnstart
            // 
            this.btnstart.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.ForeColor = System.Drawing.Color.White;
            this.btnstart.Image = global::bankers_game_proto.Properties.Resources.fa2d98d6414563c58d66663dd6b2e1c5;
            this.btnstart.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnstart.Location = new System.Drawing.Point(888, 952);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(193, 57);
            this.btnstart.TabIndex = 11;
            this.btnstart.Text = "Game Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.White;
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnexit.Location = new System.Drawing.Point(1820, 961);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(80, 80);
            this.btnexit.TabIndex = 10;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnmulti2
            // 
            this.btnmulti2.Location = new System.Drawing.Point(1254, 332);
            this.btnmulti2.Name = "btnmulti2";
            this.btnmulti2.Size = new System.Drawing.Size(354, 284);
            this.btnmulti2.TabIndex = 1;
            this.btnmulti2.UseVisualStyleBackColor = true;
            this.btnmulti2.Click += new System.EventHandler(this.btnmulti_Click);
            // 
            // btnvs
            // 
            this.btnvs.Location = new System.Drawing.Point(405, 332);
            this.btnvs.Name = "btnvs";
            this.btnvs.Size = new System.Drawing.Size(354, 284);
            this.btnvs.TabIndex = 0;
            this.btnvs.UseVisualStyleBackColor = true;
            this.btnvs.Click += new System.EventHandler(this.btnvs_Click);
            // 
            // rusheedd
            // 
            this.rusheedd.Enabled = true;
            this.rusheedd.Tick += new System.EventHandler(this.rusheedd_Tick);
            // 
            // colorss
            // 
            this.colorss.Enabled = true;
            this.colorss.Interval = 1;
            this.colorss.Tick += new System.EventHandler(this.colorss_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // Player_Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1912, 1053);
            this.Controls.Add(this.groupBox1);
            this.Name = "Player_Select";
            this.Text = "Player_Select";
            this.Load += new System.EventHandler(this.Player_Select_Load);
            this.groupBox1.ResumeLayout(false);
            this.gamemode.ResumeLayout(false);
            this.gamemode.PerformLayout();
            this.p2grp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnmulti2;
        private System.Windows.Forms.Button btnvs;
        private Curvebutton btnexit;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnmulti1;
        private System.Windows.Forms.GroupBox p2grp;
        private System.Windows.Forms.RadioButton p4rad;
        private System.Windows.Forms.RadioButton p3rad;
        private System.Windows.Forms.RadioButton p2rad;
        private System.Windows.Forms.GroupBox gamemode;
        private System.Windows.Forms.RadioButton rushpl1;
        private System.Windows.Forms.RadioButton freepl1;
        private System.Windows.Forms.Timer rusheedd;
        private System.Windows.Forms.CheckBox extr1;
        private System.Windows.Forms.CheckBox class1;
        private System.Windows.Forms.Timer colorss;
        private System.Windows.Forms.Timer timer1;
    }
}