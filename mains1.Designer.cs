namespace bankers_game_proto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpabt1 = new System.Windows.Forms.GroupBox();
            this.btnok = new bankers_game_proto.Curvebutton();
            this.abt = new CustomControl.OrientAbleTextControls.OrientedTextLabel();
            this.notif1 = new System.Windows.Forms.GroupBox();
            this.btndec1 = new bankers_game_proto.Curvebutton();
            this.btnacc1 = new bankers_game_proto.Curvebutton();
            this.p1notif = new CustomControl.OrientAbleTextControls.OrientedTextLabel();
            this.pb1notif = new System.Windows.Forms.PictureBox();
            this.howto1 = new System.Windows.Forms.Button();
            this.btnexit = new bankers_game_proto.Curvebutton();
            this.btnsound = new bankers_game_proto.Curvebutton();
            this.btnstart = new System.Windows.Forms.Button();
            this.btnsetting = new System.Windows.Forms.Button();
            this.btnabout = new bankers_game_proto.Curvebutton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.grpabt1.SuspendLayout();
            this.notif1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1notif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grpabt1);
            this.groupBox1.Controls.Add(this.notif1);
            this.groupBox1.Controls.Add(this.howto1);
            this.groupBox1.Controls.Add(this.btnexit);
            this.groupBox1.Controls.Add(this.btnsound);
            this.groupBox1.Controls.Add(this.btnstart);
            this.groupBox1.Controls.Add(this.btnsetting);
            this.groupBox1.Controls.Add(this.btnabout);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1920, 1080);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // grpabt1
            // 
            this.grpabt1.Controls.Add(this.btnok);
            this.grpabt1.Controls.Add(this.abt);
            this.grpabt1.Location = new System.Drawing.Point(381, 302);
            this.grpabt1.Name = "grpabt1";
            this.grpabt1.Size = new System.Drawing.Size(1207, 646);
            this.grpabt1.TabIndex = 688;
            this.grpabt1.TabStop = false;
            this.grpabt1.Visible = false;
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.Color.White;
            this.btnok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnok.FlatAppearance.BorderSize = 0;
            this.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnok.Location = new System.Drawing.Point(558, 550);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(90, 90);
            this.btnok.TabIndex = 9;
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // abt
            // 
            this.abt.BackColor = System.Drawing.Color.Black;
            this.abt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abt.ForeColor = System.Drawing.Color.White;
            this.abt.Location = new System.Drawing.Point(15, 43);
            this.abt.Name = "abt";
            this.abt.RotationAngle = 0D;
            this.abt.Size = new System.Drawing.Size(1174, 502);
            this.abt.TabIndex = 0;
            this.abt.Text = resources.GetString("abt.Text");
            this.abt.TextDirection = CustomControl.OrientAbleTextControls.Direction.Clockwise;
            this.abt.TextOrientation = CustomControl.OrientAbleTextControls.Orientation.Rotate;
            // 
            // notif1
            // 
            this.notif1.Controls.Add(this.btndec1);
            this.notif1.Controls.Add(this.btnacc1);
            this.notif1.Controls.Add(this.p1notif);
            this.notif1.Controls.Add(this.pb1notif);
            this.notif1.Location = new System.Drawing.Point(629, 513);
            this.notif1.Name = "notif1";
            this.notif1.Size = new System.Drawing.Size(734, 251);
            this.notif1.TabIndex = 687;
            this.notif1.TabStop = false;
            this.notif1.Visible = false;
            // 
            // btndec1
            // 
            this.btndec1.BackColor = System.Drawing.SystemColors.Control;
            this.btndec1.FlatAppearance.BorderSize = 0;
            this.btndec1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndec1.Location = new System.Drawing.Point(349, 165);
            this.btndec1.Name = "btndec1";
            this.btndec1.Size = new System.Drawing.Size(82, 74);
            this.btndec1.TabIndex = 520;
            this.btndec1.UseVisualStyleBackColor = false;
            this.btndec1.Visible = false;
            this.btndec1.Click += new System.EventHandler(this.btndec1_Click);
            // 
            // btnacc1
            // 
            this.btnacc1.BackColor = System.Drawing.SystemColors.Control;
            this.btnacc1.FlatAppearance.BorderSize = 0;
            this.btnacc1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnacc1.Location = new System.Drawing.Point(219, 165);
            this.btnacc1.Name = "btnacc1";
            this.btnacc1.Size = new System.Drawing.Size(82, 74);
            this.btnacc1.TabIndex = 519;
            this.btnacc1.UseVisualStyleBackColor = false;
            this.btnacc1.Visible = false;
            this.btnacc1.Click += new System.EventHandler(this.btnacc1_Click);
            // 
            // p1notif
            // 
            this.p1notif.BackColor = System.Drawing.Color.Black;
            this.p1notif.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1notif.ForeColor = System.Drawing.Color.White;
            this.p1notif.Location = new System.Drawing.Point(190, 23);
            this.p1notif.Name = "p1notif";
            this.p1notif.RotationAngle = 0D;
            this.p1notif.Size = new System.Drawing.Size(522, 136);
            this.p1notif.TabIndex = 518;
            this.p1notif.Text = "orientedTextLabel1";
            this.p1notif.TextDirection = CustomControl.OrientAbleTextControls.Direction.Clockwise;
            this.p1notif.TextOrientation = CustomControl.OrientAbleTextControls.Orientation.Rotate;
            // 
            // pb1notif
            // 
            this.pb1notif.Location = new System.Drawing.Point(11, 24);
            this.pb1notif.Name = "pb1notif";
            this.pb1notif.Size = new System.Drawing.Size(173, 136);
            this.pb1notif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1notif.TabIndex = 0;
            this.pb1notif.TabStop = false;
            // 
            // howto1
            // 
            this.howto1.BackColor = System.Drawing.SystemColors.Control;
            this.howto1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howto1.ForeColor = System.Drawing.Color.White;
            this.howto1.Image = global::bankers_game_proto.Properties.Resources.fa2d98d6414563c58d66663dd6b2e1c5;
            this.howto1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.howto1.Location = new System.Drawing.Point(891, 707);
            this.howto1.Name = "howto1";
            this.howto1.Size = new System.Drawing.Size(193, 57);
            this.howto1.TabIndex = 10;
            this.howto1.Text = "How-To-Play";
            this.howto1.UseVisualStyleBackColor = false;
            this.howto1.Click += new System.EventHandler(this.howto1_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.White;
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Location = new System.Drawing.Point(1826, 963);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(80, 80);
            this.btnexit.TabIndex = 9;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnsound
            // 
            this.btnsound.BackColor = System.Drawing.Color.White;
            this.btnsound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnsound.FlatAppearance.BorderSize = 0;
            this.btnsound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsound.Location = new System.Drawing.Point(1826, 772);
            this.btnsound.Name = "btnsound";
            this.btnsound.Size = new System.Drawing.Size(80, 80);
            this.btnsound.TabIndex = 8;
            this.btnsound.UseVisualStyleBackColor = false;
            this.btnsound.Click += new System.EventHandler(this.btnsound_Click);
            // 
            // btnstart
            // 
            this.btnstart.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.ForeColor = System.Drawing.Color.White;
            this.btnstart.Image = global::bankers_game_proto.Properties.Resources.fa2d98d6414563c58d66663dd6b2e1c5;
            this.btnstart.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnstart.Location = new System.Drawing.Point(891, 485);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(193, 57);
            this.btnstart.TabIndex = 3;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            this.btnstart.Paint += new System.Windows.Forms.PaintEventHandler(this.btnstart_Paint);
            // 
            // btnsetting
            // 
            this.btnsetting.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsetting.ForeColor = System.Drawing.Color.White;
            this.btnsetting.Image = global::bankers_game_proto.Properties.Resources.fa2d98d6414563c58d66663dd6b2e1c5;
            this.btnsetting.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsetting.Location = new System.Drawing.Point(891, 592);
            this.btnsetting.Name = "btnsetting";
            this.btnsetting.Size = new System.Drawing.Size(193, 57);
            this.btnsetting.TabIndex = 4;
            this.btnsetting.Text = "Settings";
            this.btnsetting.UseVisualStyleBackColor = true;
            this.btnsetting.Click += new System.EventHandler(this.btnsetting_Click);
            this.btnsetting.Paint += new System.Windows.Forms.PaintEventHandler(this.btnsetting_Paint);
            // 
            // btnabout
            // 
            this.btnabout.BackColor = System.Drawing.Color.White;
            this.btnabout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnabout.FlatAppearance.BorderSize = 0;
            this.btnabout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnabout.Location = new System.Drawing.Point(1826, 868);
            this.btnabout.Name = "btnabout";
            this.btnabout.Size = new System.Drawing.Size(80, 80);
            this.btnabout.TabIndex = 7;
            this.btnabout.UseVisualStyleBackColor = false;
            this.btnabout.Click += new System.EventHandler(this.btnabout_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(598, 348);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(756, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1920, 1080);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 1055);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.grpabt1.ResumeLayout(false);
            this.notif1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb1notif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnsetting;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.GroupBox groupBox1;
        private Curvebutton btnsound;
        private Curvebutton btnabout;
        private System.Windows.Forms.Timer timer1;
        private Curvebutton btnexit;
        private System.Windows.Forms.Button howto1;
        private System.Windows.Forms.GroupBox notif1;
        private Curvebutton btndec1;
        private Curvebutton btnacc1;
        private CustomControl.OrientAbleTextControls.OrientedTextLabel p1notif;
        private System.Windows.Forms.PictureBox pb1notif;
        private System.Windows.Forms.GroupBox grpabt1;
        private Curvebutton btnok;
        private CustomControl.OrientAbleTextControls.OrientedTextLabel abt;
    }
}

