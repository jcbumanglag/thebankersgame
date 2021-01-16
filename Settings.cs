using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Media;
namespace bankers_game_proto
{
    public partial class Settings : Form
    {
        #region variable for settings
        public static int money1 = 2600;
        public static int money2 = 2600;
        public static int money3 = 2600;
        public static int money4 = 2600;
        public static int mode = 0;
        public static string tmr1 = "1:00";
        public static string tmr2 = "1:00";
        public static string tmr3 = "1:00";
        public static string tmr4 = "1:00";
        public static string gtmr3 = "15:00";

        public static int timer1 = 60;
        public static int timer2 = 60;
        public static int timer3 = 60;
        public static int timer4 = 60;
        public static int timer5 = 900;
        public static int ext = 0;
        public static Boolean cardes = true;

        //soundtrack
        SoundPlayer click;
        SoundPlayer decline;
        SoundPlayer p1sound;
        SoundPlayer p2sound;
        SoundPlayer p3sound;
        SoundPlayer p4sound;
        SoundPlayer jailed;
        SoundPlayer freezing;
        SoundPlayer reversing;
        SoundPlayer jumped;
        SoundPlayer demolished;
        SoundPlayer bankrupted;
        SoundPlayer timesup;
        SoundPlayer trainstat;
        SoundPlayer utilelec;
        SoundPlayer passed;
        SoundPlayer drawcarded;
        SoundPlayer bought;
        SoundPlayer gavel;
        SoundPlayer upgraded;

        #endregion

        public Settings()
        {

            click = new SoundPlayer(bankers_game_proto.Properties.Resources.Tiny_Button_Push_SoundBible_com_513260752);
            bought = new SoundPlayer(bankers_game_proto.Properties.Resources.buy);
            upgraded = new SoundPlayer(bankers_game_proto.Properties.Resources.upgraded);
            gavel = new SoundPlayer(bankers_game_proto.Properties.Resources.auction1);
            decline = new SoundPlayer(bankers_game_proto.Properties.Resources.backed);
            p1sound = new SoundPlayer(bankers_game_proto.Properties.Resources.p1);
            p2sound = new SoundPlayer(bankers_game_proto.Properties.Resources.p2);
            p3sound = new SoundPlayer(bankers_game_proto.Properties.Resources.p3);
            p4sound = new SoundPlayer(bankers_game_proto.Properties.Resources.p4);
            trainstat = new SoundPlayer(bankers_game_proto.Properties.Resources.trainstat);
            utilelec = new SoundPlayer(bankers_game_proto.Properties.Resources.utilsound);
            freezing = new SoundPlayer(bankers_game_proto.Properties.Resources.freeze1);
            demolished = new SoundPlayer(bankers_game_proto.Properties.Resources.demolish1);
            reversing = new SoundPlayer(bankers_game_proto.Properties.Resources.reverse);
            jumped = new SoundPlayer(bankers_game_proto.Properties.Resources.jump);
            passed = new SoundPlayer(bankers_game_proto.Properties.Resources.pass);
            jailed = new SoundPlayer(bankers_game_proto.Properties.Resources.jail);
            drawcarded = new SoundPlayer(bankers_game_proto.Properties.Resources.card);
            bankrupted = new SoundPlayer(bankers_game_proto.Properties.Resources.bankrupt1);
            timesup = new SoundPlayer(bankers_game_proto.Properties.Resources.Timesup);


            InitializeComponent();
            ext = Form1.ext;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            setstart();

            des1();
            notif1.Paint += new PaintEventHandler(notif1_Paint);
            btnsave.Paint += new PaintEventHandler(btnsave_Paint);
            btnexit.Paint += new PaintEventHandler(btnexit_Paint);
            btnmap.Paint += new PaintEventHandler(btnmap_Paint);
         
        }

        #region initial des

        void notif1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, notif1.ClientRectangle,
                 SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                 SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                 SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                 SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        void btnmap_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnmap.ClientRectangle,
              SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
              SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
              SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
              SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        void btnexit_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnexit.ClientRectangle,
              SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
              SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
              SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
              SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        void btnsave_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnsave.ClientRectangle,
           SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
           SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
           SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
           SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        void setstart()
        {
            comboBox1.Text = "------------------";
            comboBox2.Text = "------------------";
            comboBox3.Text = "------------------";
            comboBox5.Text = "------------------";


            label1.Parent = groupBox1;
            pictureBox1.Parent = groupBox1;
            label2.Parent = groupBox1;
            label8.Parent = groupBox1;
            label3.Parent = groupBox1;
            label4.Parent = groupBox1;
            label5.Parent = groupBox1;
            label6.Parent = groupBox1;
            label7.Parent = groupBox1;
            label12.Parent = groupBox1;
            label13.Parent = groupBox1;
            label14.Parent = groupBox1;


            label1.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label12.BackColor = Color.Transparent;
            label13.BackColor = Color.Transparent;
            label14.BackColor = Color.Transparent;

            btnexit.Parent = groupBox1;
            btnexit.BackColor = Color.Transparent;
            btnexit.Image = bankers_game_proto.Properties.Resources.fa2d98d6414563c58d66663dd6b2e1c5;

            btnsave.Parent = groupBox1;
            btnsave.BackColor = Color.Transparent;
            btnsave.Image = bankers_game_proto.Properties.Resources.fa2d98d6414563c58d66663dd6b2e1c5;

            btnmap.Parent = groupBox1;
            btnmap.BackColor = Color.Transparent;
            btnmap.Image = bankers_game_proto.Properties.Resources.fa2d98d6414563c58d66663dd6b2e1c5;

            groupBox1.BackgroundImage = bankers_game_proto.Properties.Resources.kisspng_gear_data_icon_ppt_design_gear_icon_5a80761cd85096_6031217115183682848861;
            groupBox1.BackgroundImageLayout = ImageLayout.Tile;

            btnsave.Enabled = false;

            pictureBox1.Parent = groupBox1;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = bankers_game_proto.Properties.Resources._3QAxNZGm;
        }
        #endregion

        #region
        void des1()
        {
            btnacc1.BackgroundImage = bankers_game_proto.Properties.Resources.check;
            btnacc1.BackgroundImageLayout = ImageLayout.Stretch;
            btndec1.BackgroundImage = bankers_game_proto.Properties.Resources.cancel;
            btndec1.BackgroundImageLayout = ImageLayout.Stretch;

            notif1.BackgroundImage = bankers_game_proto.Properties.Resources.panel;
            notif1.BackgroundImageLayout = ImageLayout.Stretch;
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            click.Play();
            if (comboBox1.Text == "1500" || comboBox2.Text == "------------------" && comboBox1.Text == "1500")
            {

                notif1.Visible = true;
                pb1notif.Image = bankers_game_proto.Properties.Resources.save;
                p1notif.Text = "Do you want to save the settings?";
                btndec1.Visible = true;
                btnacc1.Visible = true;


            }

            else if (comboBox1.Text == "2600" || comboBox2.Text == "------------------" && comboBox1.Text == "2600")
            {

                notif1.Visible = true;
                pb1notif.Image = bankers_game_proto.Properties.Resources.save;
                p1notif.Text = "Do you want to save the settings?";
                btndec1.Visible = true;
                btnacc1.Visible = true;


            }
            else if (comboBox1.Text == "3600" || comboBox2.Text == "------------------" && comboBox1.Text == "3600")
            {

                notif1.Visible = true;
                pb1notif.Image = bankers_game_proto.Properties.Resources.save;
                p1notif.Text = "Do you want to save the settings?";
                btndec1.Visible = true;
                btnacc1.Visible = true;


            }
            else if (comboBox1.Text == "------------------" && comboBox2.Text == "------------------" && comboBox5.Text == "------------------")
            {
                notif1.Visible = true;
                pb1notif.Image = bankers_game_proto.Properties.Resources.cancel;
                p1notif.Text = "Invalid Settings";
                btnacc1.Visible = true;
                btndec1.Visible = false;

            }

            if (comboBox2.Text.StartsWith("2:00min") || comboBox1.Text == "------------------" && comboBox2.Text.StartsWith("2:00"))
            {
                notif1.Visible = true;
                pb1notif.Image = bankers_game_proto.Properties.Resources.save;
                p1notif.Text = "Do you want to save the settings?";
                btndec1.Visible = true;
                btnacc1.Visible = true;

            }

            else if (comboBox2.Text.StartsWith("3:00min") || comboBox1.Text == "------------------" && comboBox2.Text.StartsWith("3:00"))
            {

                notif1.Visible = true;
                pb1notif.Image = bankers_game_proto.Properties.Resources.save;
                p1notif.Text = "Do you want to save the settings?";
                btndec1.Visible = true;
                btnacc1.Visible = true;

            }

            else if (comboBox2.Text.StartsWith("5:00min") || comboBox1.Text == "------------------" && comboBox2.Text.StartsWith("5:00"))
            {

                notif1.Visible = true;
                pb1notif.Image = bankers_game_proto.Properties.Resources.save;
                p1notif.Text = "Do you want to save the settings?";
                btndec1.Visible = true;
                btnacc1.Visible = true;


            }
            if (comboBox5.Text.StartsWith("30:00min"))
            {

                notif1.Visible = true;
                pb1notif.Image = bankers_game_proto.Properties.Resources.save;
                p1notif.Text = "Do you want to save the settings?";
                btndec1.Visible = true;
                btnacc1.Visible = true;

            }
            if (comboBox5.Text.StartsWith("10:00min"))
            {

                notif1.Visible = true;
                pb1notif.Image = bankers_game_proto.Properties.Resources.save;
                p1notif.Text = "Do you want to save the settings?";
                btndec1.Visible = true;
                btnacc1.Visible = true;


            }

            if (comboBox5.Text.StartsWith("15:00min"))
            {

                notif1.Visible = true;
                pb1notif.Image = bankers_game_proto.Properties.Resources.save;
                p1notif.Text = "Do you want to save the settings?";
                btndec1.Visible = true;
                btnacc1.Visible = true;


            }
            else if (comboBox5.Text.StartsWith("45:00min"))
            {

                notif1.Visible = true;
                pb1notif.Image = bankers_game_proto.Properties.Resources.save;
                p1notif.Text = "Do you want to save the settings?";
                btndec1.Visible = true;
                btnacc1.Visible = true;

            }
            else if (comboBox5.Text.StartsWith("60:00min"))
            {
                notif1.Visible = true;
                pb1notif.Image = bankers_game_proto.Properties.Resources.save;
                p1notif.Text = "Do you want to save the settings?";
                btndec1.Visible = true;
                btnacc1.Visible = true;

            }
            else if (comboBox3.Text.StartsWith("True"))
            {
                notif1.Visible = true;
                pb1notif.Image = bankers_game_proto.Properties.Resources.save;
                p1notif.Text = "Do you want to save the settings?";
                btndec1.Visible = true;
                btnacc1.Visible = true;

            }
            else if (comboBox3.Text.StartsWith("False"))
            {
                notif1.Visible = true;
                pb1notif.Image = bankers_game_proto.Properties.Resources.save;
                p1notif.Text = "Do you want to save the settings?";
                btndec1.Visible = true;
                btnacc1.Visible = true;

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            decline.Play();
            if (btnsave.Enabled == false)
            {
                this.Close();
                ext = 0;

            }

            if (btnsave.Enabled == true)
            {

                notif1.Visible = true;
                pb1notif.Image = bankers_game_proto.Properties.Resources.exit;
                p1notif.Text = "Do you want to exit without saving the settings?";
                btndec1.Visible = true;
                btnacc1.Visible = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            click.Play();
            Map b = new Map();
            b.Focus();
            b.Show();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnsave.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnsave.Enabled = true;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnsave.Enabled = true;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnsave.Enabled = true;
        }

        private void btnacc1_Click(object sender, EventArgs e)
        {
            click.Play();
            if (comboBox3.Text.StartsWith("False"))
            {

                btnsave.Enabled = false;
                notif1.Visible = false;
                label2.Text = "Currently: False";
                cardes = false;

            }
            if (comboBox3.Text.StartsWith("True"))
            {

                btnsave.Enabled = false;
                notif1.Visible = false;
                label2.Text = "Currently: True";
                cardes = true;

            }
            if (comboBox1.Text == "1500" || comboBox2.Text == "------------------" && comboBox1.Text == "1500")
            {
                money1 = 1500;
                money2 = 1500;
                money3 = 1500;
                money4 = 1500;
                label4.Text = money1.ToString();
                btnsave.Enabled = false;
                notif1.Visible = false;

            }

            else if (comboBox1.Text == "2600" || comboBox2.Text == "------------------" && comboBox1.Text == "2600")
            {
                money1 = 2600;
                money2 = 2600;
                money3 = 2600;
                money4 = 2600;
                label4.Text = money1.ToString();
                btnsave.Enabled = false;
                notif1.Visible = false;


            }
            else if (comboBox1.Text == "3600" || comboBox2.Text == "------------------" && comboBox1.Text == "3600")
            {
                money1 = 3600;
                money2 = 3600;
                money3 = 3600;
                money4 = 3600;
                label4.Text = money1.ToString();
                btnsave.Enabled = false;
                notif1.Visible = false;


            }
            else if (p1notif.Text.StartsWith("Invalid Settings"))
            {
                notif1.Visible = false;
                btnsave.Enabled = false;


            }

            if (comboBox2.Text.StartsWith("1:00min") || comboBox1.Text == "------------------" && comboBox2.Text.StartsWith("2:00"))
            {
                tmr1 = "1:00";
                tmr2 = "1:00";
                timer1 = 60;
                timer2 = 60;
                tmr3 = "1:00";
                tmr4 = "1:00";
                timer3 = 60;
                timer4 = 60;
                label6.Text = "1:00";
                notif1.Visible = false;
                btnsave.Enabled = false;
            }

            else if (comboBox2.Text.StartsWith("3:00min") || comboBox1.Text == "------------------" && comboBox2.Text.StartsWith("3:00"))
            {
                tmr1 = "3:00";
                tmr2 = "3:00";
                timer1 = 180;
                timer2 = 180;
                tmr3 = "3:00";
                tmr4 = "3:00";
                timer3 = 180;
                timer4 = 180;
                btnsave.Enabled = false;
                label6.Text = "3:00";
                notif1.Visible = false;

            }

            else if (comboBox2.Text.StartsWith("5:00min") || comboBox1.Text == "------------------" && comboBox2.Text.StartsWith("5:00"))
            {
                tmr1 = "5:00";
                tmr2 = "5:00";
                timer1 = 300;
                timer2 = 300;
                tmr3 = "5:00";
                tmr4 = "5:00";
                timer3 = 300;
                timer4 = 300;
                btnsave.Enabled = false;
                label6.Text = "5:00";
                notif1.Visible = false;

            }
            if (comboBox5.Text.StartsWith("30:00min"))
            {
                timer5 = 1800;
                gtmr3 = "30:00";
                label13.Text = gtmr3;
                btnsave.Enabled = false;
                notif1.Visible = false;
                mode = 1;

            }
            if (comboBox5.Text.StartsWith("10:00min"))
            {
                timer5 = 600;
                gtmr3 = "10:00";
                label13.Text = gtmr3;
                btnsave.Enabled = false;
                notif1.Visible = false;
                mode = 1;
            }
            if (comboBox5.Text.StartsWith("15:00min"))
            {
                timer5 = 900;
                gtmr3 = "15:00";
                label13.Text = gtmr3;
                btnsave.Enabled = false;
                notif1.Visible = false;
                mode = 1;
            }
            else if (comboBox5.Text.StartsWith("45:00min"))
            {
                timer5 = 2700;
                gtmr3 = "45:00";
                label13.Text = gtmr3;
                btnsave.Enabled = false;
                notif1.Visible = false;
                mode = 1;
            }
            else if (comboBox5.Text.StartsWith("60:00min"))
            {
                timer5 = 3600;
                gtmr3 = "60:00";
                label13.Text = gtmr3;
                btnsave.Enabled = false;
                notif1.Visible = false;
                mode = 1;
            }


            if (p1notif.Text.StartsWith("Do you want to exit without saving the settings?"))
            {
                ext = 0;
                mode = 0;
                this.Close();

            }
            if (p1notif.Text.StartsWith("This Option lets the players decide \r\non how much do they want to start with.") || p1notif.Text.StartsWith("This Option lets the players decide \r\non how long should the time on each turns.") || p1notif.Text.StartsWith("This Option lets the players decide \r\non how long should the time on the game.\r\n(this option if saved will disable free-to-play mode)") || p1notif.Text.StartsWith("This Option lets the players decide \r\nif they want the power up cards available or not"))
            {
                notif1.Visible = false;

            }

        }

        private void btndec1_Click(object sender, EventArgs e)
        {
            decline.Play();
            if (comboBox1.Text == "1500" || comboBox2.Text == "------------------" && comboBox1.Text == "1500")
            {

                btnsave.Enabled = false;
                notif1.Visible = false;

            }

            else if (comboBox1.Text == "2600" || comboBox2.Text == "------------------" && comboBox1.Text == "2600")
            {

                btnsave.Enabled = false;
                notif1.Visible = false;


            }
            else if (comboBox1.Text == "3600" || comboBox2.Text == "------------------" && comboBox1.Text == "3600")
            {

                label4.Text = money1.ToString();
                btnsave.Enabled = false;
                notif1.Visible = false;


            }


            if (comboBox2.Text.StartsWith("2:00min") || comboBox1.Text == "------------------" && comboBox2.Text.StartsWith("2:00"))
            {

                notif1.Visible = false;
                btnsave.Enabled = false;

            }

            else if (comboBox2.Text.StartsWith("3:00min") || comboBox1.Text == "------------------" && comboBox2.Text.StartsWith("3:00"))
            {

                btnsave.Enabled = false;
                notif1.Visible = false;

            }

            else if (comboBox2.Text.StartsWith("5:00min") || comboBox1.Text == "------------------" && comboBox2.Text.StartsWith("5:00"))
            {

                btnsave.Enabled = false;

                notif1.Visible = false;

            }
            if (comboBox5.Text.StartsWith("30:00min"))
            {

                btnsave.Enabled = false;
                notif1.Visible = false;
                mode = 0;

            }
            if (comboBox5.Text.StartsWith("10:00min"))
            {

                btnsave.Enabled = false;
                notif1.Visible = false;
                mode = 0;
            }
            if (comboBox5.Text.StartsWith("15:00min"))
            {

                btnsave.Enabled = false;
                notif1.Visible = false;
                mode = 0;
            }
            else if (comboBox5.Text.StartsWith("45:00min"))
            {

                btnsave.Enabled = false;
                notif1.Visible = false;
                mode = 0;
            }
            else if (comboBox5.Text.StartsWith("60:00min"))
            {

                btnsave.Enabled = false;
                notif1.Visible = false;
                mode = 0;
            }
            else if (comboBox3.Text.StartsWith("True"))
            {

                btnsave.Enabled = false;
                notif1.Visible = false;
            }
            else if (comboBox3.Text.StartsWith("False"))
            {

                btnsave.Enabled = false;
                notif1.Visible = false;
            }
            if (p1notif.Text.StartsWith("Do you want to exit without saving the settings?"))
            {
                btnsave.Enabled = true;
                notif1.Visible = false;

            }
        }

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            btnsave.Enabled = true;
        }

        private void tip1_Click(object sender, EventArgs e)
        {
            notif1.Visible = true;
            p1notif.Text = "This Option lets the players decide \r\non how much do they want to start with.";
            pb1notif.Image = bankers_game_proto.Properties.Resources.philippine_peso;
            btndec1.Visible = false;
            btnacc1.Visible = true;
        }

        private void tip2_Click(object sender, EventArgs e)
        {
            notif1.Visible = true;
            p1notif.Text = "This Option lets the players decide \r\non how long should the time on each turns.";
            pb1notif.Image = bankers_game_proto.Properties.Resources.clock;
            btndec1.Visible = false;
            btnacc1.Visible = true;
        }

        private void tip3_Click(object sender, EventArgs e)
        {
            notif1.Visible = true;
            p1notif.Text = "This Option lets the players decide \r\non how long should the time on the game.\r\n(this option if saved will disable free-to-play mode)";
            pb1notif.Image = bankers_game_proto.Properties.Resources.deadline;
            btndec1.Visible = false;
            btnacc1.Visible = true;
        }

        private void tip4_Click(object sender, EventArgs e)
        {
            notif1.Visible = true;
            p1notif.Text = "This Option lets the players decide \r\nif they want the power up cards available or not";
            pb1notif.Image = bankers_game_proto.Properties.Resources.playing_cards;
            btndec1.Visible = false;
            btnacc1.Visible = true;
        }

    }
}
