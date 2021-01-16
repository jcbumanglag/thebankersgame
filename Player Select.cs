using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
namespace bankers_game_proto
{
    public partial class Player_Select : Form
    {
        #region variables

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
        SoundPlayer good;
        //int on = 0;
        public static int playersel1;
        public static int playersel2;
        public static int p2sel = 0;
        public static int p3sel = 0;
        public static int p4sel = 0;
        public static int playersel3;
        public static int gameload = 0;
        public static int rush = 0;
        public static int extre1 = 0;
        public static int classic1 = 0;
        Random col = new Random();
        int counter = 1;
        int red = 0;
        #endregion

        public Player_Select()
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
            good = new SoundPlayer(bankers_game_proto.Properties.Resources.good);
            InitializeComponent();
        }

        private void Player_Select_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;


            groupBox1.BackgroundImage = bankers_game_proto.Properties.Resources.auc;
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;

            btnmulti2.BackgroundImage = bankers_game_proto.Properties.Resources.multiplayer;
            btnmulti2.BackgroundImageLayout = ImageLayout.Zoom;
            btnmulti1.BackgroundImage = bankers_game_proto.Properties.Resources.online_game;
            btnmulti1.BackgroundImageLayout = ImageLayout.Zoom;
            btnvs.BackgroundImage = bankers_game_proto.Properties.Resources.pvp;
            btnvs.BackgroundImageLayout = ImageLayout.Zoom;
            btnexit.BackgroundImage = bankers_game_proto.Properties.Resources.exit;
            btnexit.BackgroundImageLayout = ImageLayout.Zoom;


            btnvs.Paint += new PaintEventHandler(btnvs_Paint);
            btnmulti2.Paint += new PaintEventHandler(btnmulti_Paint);
            btnstart.Paint += new PaintEventHandler(btnstart_Paint);

            btnvs.BackColor = Color.Gray;
            btnmulti2.BackColor = Color.Gray;
            btnmulti1.BackColor = Color.Gray;

            pictureBox1.Parent = groupBox1;
            pictureBox1.Image = bankers_game_proto.Properties.Resources.Monopoly_Fav_banker_deal_;
            pictureBox1.BackColor = Color.Transparent;

            p2grp.BackgroundImage = bankers_game_proto.Properties.Resources.panel;
            p2grp.BackgroundImageLayout = ImageLayout.Stretch;


            gamemode.BackgroundImage = bankers_game_proto.Properties.Resources.panel;
            gamemode.BackgroundImageLayout = ImageLayout.Stretch;

            btnmulti1.Paint += new PaintEventHandler(btnmulti1_Paint);
            p2grp.Paint += new PaintEventHandler(p2grp_Paint);
            gamemode.Paint += new PaintEventHandler(gamemode_Paint);
            gamemode.Visible = true;
            settingchange();
        }

        #region paint
        void btnmulti1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnmulti1.ClientRectangle,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        void gamemode_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, gamemode.ClientRectangle,
           SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
           SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
           SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
           SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        void p2grp_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, p2grp.ClientRectangle,
               SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
               SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
               SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
               SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        void btnstart_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnstart.ClientRectangle,
             SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
             SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
             SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
             SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        void btnmulti_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnmulti2.ClientRectangle,
             SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
             SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
             SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
             SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        void btnvs_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnvs.ClientRectangle,
              SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
              SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
              SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
              SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }
        #endregion

        #region design
        void playerselcol()
        {
            if (playersel1 == 1)
            {

                if (counter == 1)
                {
                    if (red < 255)
                    {
                        red += 10;

                    }
                    else
                    {
                        counter = 0;
                    }


                }
                if (counter == 0)
                {
                    if (red > 0)
                    {
                        red -= 10;
                    }

                    else
                    {
                        counter = 1;

                    }

                }
                if (red > 255)
                {
                    red = 255;

                }
                if (red < 0)
                {
                    red = 0;
                }

                btnvs.BackColor = Color.FromArgb(0, red, red);


            }
            if (playersel3 == 1)
            {
                if (counter == 1)
                {
                    if (red < 255)
                    {
                        red += 10;
                    }
                    else
                    {
                        counter = 0;
                    }


                }
                if (counter == 0)
                {
                    if (red > 0)
                    {
                        red -= 10;
                    }
                    else
                    {
                        counter = 1;
                    }

                }
                if (red > 255)
                {
                    red = 255;

                }
                if (red < 0)
                {
                    red = 0;
                }
                btnmulti1.BackColor = Color.FromArgb(0, red, red);

            }
            if (playersel2 == 1)
            {
                if (counter == 1)
                {
                    if (red < 255)
                    {
                        red += 10;

                    }
                    else
                    {
                        counter = 0;
                    }


                }
                if (counter == 0)
                {
                    if (red > 0)
                    {
                        red -= 10;
                    }
                    else
                    {
                        counter = 1;
                    }

                }
                if (red > 255)
                {
                    red = 255;

                }
                if (red < 0)
                {
                    red = 0;
                }
                btnmulti2.BackColor = Color.FromArgb(0, red, red);

            }
            if (playersel1 == 0)
            {

                btnvs.BackColor = Color.Gray;
            }
            if (playersel2 == 0)
            {
                btnmulti2.BackColor = Color.Gray;
            }
            if (playersel3 == 0)
            {
                btnmulti1.BackColor = Color.Gray;
            }

        }


        void possel()
        {
            if (p2rad.Checked == true)
            {
                p2sel = 1;
                p3sel = 0;
                p4sel = 0;
                p4_gameplay b = new p4_gameplay();
                //b.Focus();
                b.Show();
                this.Close();

                Loadscreen c = new Loadscreen();
                c.Show();
                c.Focus();

            }
            if (p4rad.Checked == true)
            {
                p2sel = 0;
                p3sel = 0;
                p4sel = 1;
                p4_gameplay b = new p4_gameplay();
                //b.Focus();
                b.Show();
                this.Close();

                Loadscreen c = new Loadscreen();
                c.Show();
                c.Focus();

            }
            if (p3rad.Checked == true)
            {
                p2sel = 0;
                p3sel = 1;
                p4sel = 0;
                p4_gameplay b = new p4_gameplay();
                //b.Focus();
                b.Show();
                this.Close();

                Loadscreen c = new Loadscreen();
                c.Show();
                c.Focus();

            }
            if (p2rad.Checked == false && p4rad.Checked == false && p3rad.Checked == false)
            {
                MessageBox.Show("Select the position of the opposing player", "Select Position", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        void gamemodesel()
        {
            if (freepl1.Checked == true)
            {
                rush = 0;
                class1.Visible = false;
                extr1.Visible = false;

            }
            if (rushpl1.Checked == true)
            {
                rush = 1;
                extr1.Visible = true;
                class1.Visible = true;


            }
            if (extr1.Checked == true)
            {
                extre1 = 1;
                classic1 = 0;


            }
            if (class1.Checked == true)
            {
                classic1 = 1;
                extre1 = 0;
            }

        }

        void settingchange()
        {
            if (Settings.mode == 0)
            {
                playersel1 = 1;
                playersel2 = 0;
                playersel3 = 0;
                p2grp.Visible = true;
                p2rad.Checked = true;
                freepl1.Checked = true;
                gamemodesel();
                playerselcol();
            }
            if (Settings.mode == 1)
            {


                playersel1 = 1;
                playersel2 = 0;
                playersel3 = 0;
                p2grp.Visible = true;
                p2rad.Checked = true;
                freepl1.Enabled = false;
                rushpl1.Checked = true;
                gamemodesel();
                playerselcol();

            }
        }
        #endregion

        private void btnexit_Click(object sender, EventArgs e)
        {
            click.Play();
            this.Close();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            click.Play();
            if (playersel1 == 1)
            {
                possel();
                gameload = 1;
                rusheedd.Stop();
                Settings.mode = 0;
            }
            if (playersel2 == 1)
            {

                Settings.mode = 0;
                p4_gameplay b = new p4_gameplay();
                // b.Focus();
                b.Show();
                gameload = 1;


                Loadscreen c = new Loadscreen();
                c.Show();
                c.Focus();
                rusheedd.Stop();
                this.Close();
            }
            if (playersel3 == 1)
            {
                Settings.mode = 0;
                p4_gameplay b = new p4_gameplay();
                //b.Focus();
                b.Show();
                gameload = 1;

                Loadscreen c = new Loadscreen();
                c.Show();
                c.Focus();
                rusheedd.Stop();
                this.Close();
            }

        }

        private void btnvs_Click(object sender, EventArgs e)
        {
            playersel1 = 1;
            playersel2 = 0;
            playersel3 = 0;
            p2grp.Visible = true;
            p2rad.Checked = true;
            playerselcol();
            click.Play();


        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            playersel2 = 1;
            playersel1 = 0;
            playersel3 = 0;
            p2grp.Visible = false;
            playerselcol();
            click.Play();

        }

        private void btnmulti1_Click(object sender, EventArgs e)
        {
            playersel1 = 0;
            playersel2 = 0;
            playersel3 = 1;
            p2grp.Visible = false;
            playerselcol();
            click.Play();
        }

        private void rusheedd_Tick(object sender, EventArgs e)
        {

            gamemodesel();
        }

        private void class1_CheckedChanged(object sender, EventArgs e)
        {
            extr1.Checked = false;
        }

        private void extr1_CheckedChanged(object sender, EventArgs e)
        {
            class1.Checked = false;
        }

        private void rushpl1_CheckedChanged(object sender, EventArgs e)
        {
            class1.Checked = true;
        }

        private void colorss_Tick(object sender, EventArgs e)
        {
            playerselcol();




        }

    }
}
