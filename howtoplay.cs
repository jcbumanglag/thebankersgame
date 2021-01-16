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
    public partial class howtoplay : Form
    {
        #region variables
        int pages = 1;
        SoundPlayer click;
        #endregion

        #region img
        void pagelimit() 
        {
        if(pages >=19)
        {
            pages = 19;
            pbnext1.Visible = false;
            pbback1.Visible = true;
        }
        if (pages == 1)
        {
            pbnext1.Visible = true;
            pbback1.Visible = false;
        }
        if (pages < 18 && pages > 0)
        {
            pbnext1.Visible = true;
            pbback1.Visible = true;
        }
        if(pages <=0)
        {
            pages = 1;
            pbnext1.Visible = true;
            pbback1.Visible = false;
        }
        }
        void rulepics() 
        {
            if(pages==1)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = bankers_game_proto.Properties.Resources.gameman1;

            }
            if (pages == 2)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = bankers_game_proto.Properties.Resources.gameman2;
            }
            if (pages == 3)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = bankers_game_proto.Properties.Resources.gameman3;
            }
            if (pages == 4)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = bankers_game_proto.Properties.Resources.gameman4;
            }
            if (pages == 5)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = bankers_game_proto.Properties.Resources.gameman5;
            }
            if (pages == 6)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = bankers_game_proto.Properties.Resources.gameman6;
            }
            if (pages == 7)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = bankers_game_proto.Properties.Resources.gameman7;
            }
            if (pages == 8)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = bankers_game_proto.Properties.Resources.gameman8;
            }
            if (pages == 9)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = bankers_game_proto.Properties.Resources.gameman9;
            }
            if (pages == 10)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = bankers_game_proto.Properties.Resources.gameman10;
            }
            if (pages == 11)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = bankers_game_proto.Properties.Resources.gameman11;
            }
            if (pages == 12)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = bankers_game_proto.Properties.Resources.gamerul1;
            }
            if (pages == 13)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = bankers_game_proto.Properties.Resources.gamerul2;
            }
            if (pages == 14)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = bankers_game_proto.Properties.Resources.gamerul3;
            }
            if (pages == 15)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = bankers_game_proto.Properties.Resources.gamerul4;
            }
            if (pages == 16)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = bankers_game_proto.Properties.Resources.gamerul5;
            }
            if (pages == 17)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = bankers_game_proto.Properties.Resources.gamerul6;
            }
            if (pages == 18)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = bankers_game_proto.Properties.Resources.gamerul7;

            }

            if (pages == 19)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = bankers_game_proto.Properties.Resources.gamerul8;

            }
        }
        #endregion

        public howtoplay()
        {
            click = new SoundPlayer(bankers_game_proto.Properties.Resources.Tiny_Button_Push_SoundBible_com_513260752);
            InitializeComponent();
        }

        private void howtoplay_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            pbnext1.Image = bankers_game_proto.Properties.Resources.next;
            pbback1.Image = bankers_game_proto.Properties.Resources.prev;
            btnexit.BackgroundImage = bankers_game_proto.Properties.Resources.exit;
            btnexit.BackgroundImageLayout = ImageLayout.Stretch;
            pbback1.Parent = pictureBox1;
            pbnext1.Parent = pictureBox1;
            rulepics();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            click.PlaySync();
            pages = 0;
            this.Close();

        }

        private void pbnext1_Click(object sender, EventArgs e)
        {
            click.PlaySync();
            pages++;
            pagelimit();
            rulepics();
        }

        private void pbback1_Click(object sender, EventArgs e)
        {
            click.PlaySync();
            pages--;
            pagelimit();
            rulepics();
        }

    }
}
