using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using WMPLib;
using Microsoft.Win32;
using System.IO;
namespace bankers_game_proto
{
    public partial class Form1 : Form
    {
        #region variable
        RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        int sounds;
        WindowsMediaPlayer playersm = new WindowsMediaPlayer();

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

        public static int ext = 0;
        #endregion

        public Form1()
        {
         
            InitializeComponent();

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


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reg.SetValue("My app", Application.ExecutablePath.ToString());
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
           howto1.Paint += new PaintEventHandler(howto1_Paint);
           notif1.Paint += new PaintEventHandler(notif1_Paint);
           grpabt1.Paint += new PaintEventHandler(grpabt1_Paint);
           sounds = 0;
           sound();
           des();
           
        }

        #region paint
        void grpabt1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, grpabt1.ClientRectangle,
              SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
              SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
              SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
              SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }   
        void howto1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, howto1.ClientRectangle,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }
        void notif1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, notif1.ClientRectangle,
                    SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                    SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                    SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                    SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }
        #endregion

        void sound() { 
     if(sounds==0){
         playersm.URL = "PSM.mp3";
         playersm.settings.setMode("Loop", true);
     }
     else if(sounds==1){
         playersm.controls.pause();
         btnsound.BackgroundImage = bankers_game_proto.Properties.Resources.kisspng_computer_icons_sound_icon_volume_5ae7f3c98521e8_4195341015251506655453;


     } if(sounds>1){
         sounds = 0;
         playersm.controls.play();
         playersm.settings.setMode("Loop", true);
         btnsound.BackgroundImage = bankers_game_proto.Properties.Resources._109_1095591_no_audio_icon_free_download_png_and_vector;
     }

        
        }

        void des() {
            pictureBox1.Parent = groupBox1;
            pictureBox1.Image = bankers_game_proto.Properties.Resources.ezgif_com_gif_maker;

            pictureBox2.Image = bankers_game_proto.Properties.Resources.u9jgR5x0;

            pictureBox2.Parent = pictureBox1;
            pictureBox2.BackColor = Color.Transparent;
            btnstart.Parent = pictureBox1;
            btnstart.BackColor = Color.Transparent;

            howto1.Parent = pictureBox1;
            howto1.BackColor = Color.Transparent;

            btnexit.Parent = pictureBox1;
            //btnexit.BackColor = Color.Transparent;
            btnexit.BackgroundImage = bankers_game_proto.Properties.Resources.exit;
            btnexit.BackgroundImageLayout = ImageLayout.Stretch;

            btnsetting.Parent = pictureBox1;
            //btnsetting.BackColor = Color.Transparent;


            btnabout.Parent = pictureBox1;
            //btnabout.BackColor = Color.Transparent;
            btnabout.BackgroundImage = bankers_game_proto.Properties.Resources.faq;
            btnabout.BackgroundImageLayout = ImageLayout.Stretch;

            notif1.BackgroundImage = bankers_game_proto.Properties.Resources.panel;
            notif1.BackgroundImageLayout = ImageLayout.Stretch;

            grpabt1.BackgroundImage = bankers_game_proto.Properties.Resources.panel;
            grpabt1.BackgroundImageLayout = ImageLayout.Stretch;

            btnacc1.BackgroundImage = bankers_game_proto.Properties.Resources.check;
            btnacc1.BackgroundImageLayout = ImageLayout.Stretch;

            btnok.BackgroundImage = bankers_game_proto.Properties.Resources.check;
            btnok.BackgroundImageLayout = ImageLayout.Stretch;

            btndec1.BackgroundImage = bankers_game_proto.Properties.Resources.cancel;
            btndec1.BackgroundImageLayout = ImageLayout.Stretch;
            btnsound.Parent = pictureBox1;
            //btnsound.BackColor = Color.Transparent;
            btnsound.BackgroundImage = bankers_game_proto.Properties.Resources._109_1095591_no_audio_icon_free_download_png_and_vector;
            btnsound.BackgroundImageLayout = ImageLayout.Stretch;

       
        }

        private void btnsound_Click(object sender, EventArgs e)
        {

            sounds = sounds + 1;
            sound();
            
        }

        private void btnabout_Click(object sender, EventArgs e)
        {
            click.Play();
            grpabt1.Visible = true;
      
        }

        private void btnsetting_Click(object sender, EventArgs e)
        {
            Settings b = new Settings();
            b.Show();
            b.Focus();
            click.Play();
            playersm.controls.play();
            playersm.settings.setMode("Loop", true);

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            click.PlaySync();
            notif1.Visible = true;
            p1notif.Text = "Do you want to quit the game?";
            pb1notif.Image = bankers_game_proto.Properties.Resources.quits;
            btndec1.Visible = true;
            btnacc1.Visible = true;
        }

        #region design
        private void btnstart_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnstart.ClientRectangle,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void btnsetting_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnsetting.ClientRectangle,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            click.PlaySync();
            Player_Select b = new Player_Select();
            b.Show();
            b.Focus();
        }

        private void howto1_Click(object sender, EventArgs e)
        {
            click.PlaySync();
            howtoplay b = new howtoplay();
            b.Focus();
            b.Show();
        }

        private void btnacc1_Click(object sender, EventArgs e)
        {
            click.Play();
            if(p1notif.Text.StartsWith("Do you want to quit the game?"))
            {
                this.Close();
            }
        }

        private void btndec1_Click(object sender, EventArgs e)
        {
            decline.Play();
            if (p1notif.Text.StartsWith("Do you want to quit the game?"))
            {
                notif1.Visible = false;
            }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            grpabt1.Visible = false;
            click.Play();
        }

    } 
        
    }
