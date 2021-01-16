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
    public partial class Drawcardp4 : Form
    {
        #region Variable for cards
        public static int p4drawch = 0;
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
        public static int card;
        Random cardsh = new Random();
        public static int p1comm = 0;
        public static int p2comm = 0;
        public static int p3comm = 0;
        public static int p4comm = 0;
        public static int p1quit = 0;
        public static int p2quit = 0;
        public static int p3quit = 0;
        public static int p4quit = 0;
        #endregion

        public Drawcardp4()
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
            p1comm = p4_gameplay.p1comm;
            p2comm = p4_gameplay.p2comm;
            p3comm = p4_gameplay.p3comm;
            p4comm = p4_gameplay.p4comm;
            InitializeComponent();
        }

        private void Drawcardp4_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            iconss();
            cardpos();
            carddes();
            this.WindowState = FormWindowState.Maximized;
            pbcard1.Paint += new PaintEventHandler(pbcard1_Paint);
            pbcard2.Paint += new PaintEventHandler(pbcard2_Paint);
            pbcard3.Paint += new PaintEventHandler(pbcard3_Paint);
            notif1.Paint += new PaintEventHandler(notif1_Paint);
            notif2.Paint += new PaintEventHandler(notif2_Paint);
            notif3.Paint += new PaintEventHandler(notif3_Paint);
            notif4.Paint += new PaintEventHandler(notif4_Paint);
            pbcard4.Paint += new PaintEventHandler(pbcard4_Paint);
            pbcard5.Paint += new PaintEventHandler(pbcard5_Paint);
            pbcard6.Paint += new PaintEventHandler(pbcard6_Paint);
            card = 0;
        }

        #region card des
        void cardpos()
        {
            if (p1comm == 1 || p3comm == 1)
            {
                pbcard1.Visible = true;
                pbcard2.Visible = true;
                pbcard3.Visible = true;

                pbcard4.Visible = false;
                pbcard5.Visible = false;
                pbcard6.Visible = false;
            }
            if (p2comm == 1 || p4comm == 1)
            {
                pbcard4.Visible = true;
                pbcard5.Visible = true;
                pbcard6.Visible = true;

                pbcard1.Visible = false;
                pbcard2.Visible = false;
                pbcard3.Visible = false;

            }
        }
        #endregion

        #region Rules for picking card
        void cardcond1()
        {
            if (card == 1 && p1comm == 1)
            {

                pb1notif.Image = bankers_game_proto.Properties.Resources.gotojail;
                p1notif.Text = "Oh no!, Your luck has ran out, You've Sent to Jail";
                bankrupted.Play();
            }
            if (card == 2 && p1comm == 1)
            {
                pb1notif.Image = bankers_game_proto.Properties.Resources.go;
                p1notif.Text = "Advance To Go Tile!";
                good.Play();
            }
            if (card == 3 && p1comm == 1)
            {
                pb1notif.Image = bankers_game_proto.Properties.Resources.student;
                p1notif.Text = "Sharing is Caring!, Donate 200php to schools";
                good.Play();
            }
            if (card == 4 && p1comm == 1)
            {
                pb1notif.Image = bankers_game_proto.Properties.Resources.bank;
                p1notif.Text = "Because we Care, Claim 200php Ensurance";
                good.Play();
            }
            if (card == 5 && p1comm == 1)
            {
                pb1notif.Image = bankers_game_proto.Properties.Resources.bus;
                p1notif.Text = "Jump To the Nearest Station, \r\nIf Unowned Purchase, If not Pay rent";
                good.Play();
            }

            if (card == 6 && p1comm == 1)
            {
                pb1notif.Image = bankers_game_proto.Properties.Resources.bank;
                p1notif.Text = "You are given a dividend of 50php by the banker";
                good.Play();
            }
            if (card == 7 && p1comm == 1)
            {
                pb1notif.Image = bankers_game_proto.Properties.Resources.vote;
                p1notif.Text = "Congratulation!, You have been Elected as a Mayor. \r\nPay 50php to each player";
                good.Play();
            }
            if (card == 8 && p1comm == 1)
            {
                pb1notif.Image = bankers_game_proto.Properties.Resources.bank;
                p1notif.Text = "Congratulation!, Your Loan Matures \r\nCollect 150php";
                good.Play();
            }
            if (card == 9 && p1comm == 1)
            {
                pb1notif.Image = bankers_game_proto.Properties.Resources.back;
                p1notif.Text = "Go back 3 spaces";
                bankrupted.Play();
            }
        }
        void cardcond2()
        {
            if (card == 1 && p2comm == 1)
            {
                btnacc2.Visible = true;
                pb2notif.Image = bankers_game_proto.Properties.Resources.gotojail_l;
                p2notif.Text = "Oh no!, Your luck has ran out, You've Sent to Jail";
                bankrupted.Play();
            }
            else if (card == 2 && p2comm == 1)
            {
                pb2notif.Image = bankers_game_proto.Properties.Resources.go_l;
                p2notif.Text = "Advance To Go Tile!";
                good.Play();
            }
            else if (card == 3 && p2comm == 1)
            {
                pb2notif.Image = bankers_game_proto.Properties.Resources.student_l;
                p2notif.Text = "Sharing is Caring!, Donate 200php to schools";
                good.Play();
            }
            else if (card == 4 && p2comm == 1)
            {
                pb2notif.Image = bankers_game_proto.Properties.Resources.bank_l;
                p2notif.Text = "Because we Care, Claim 200php Ensurance";
                good.Play();
            }
            else if (card == 5 && p2comm == 1)
            {
                pb2notif.Image = bankers_game_proto.Properties.Resources.bus_l;
                p2notif.Text = "Jump To the Nearest Station, \r\nIf Unowned Purchase, If not Pay rent";
                good.Play();
            }

            else if (card == 6 && p2comm == 1)
            {
                pb2notif.Image = bankers_game_proto.Properties.Resources.bank_l;
                p2notif.Text = "You are given a dividend of 50php by the banker";
                good.Play();
            }
            else if (card == 7 && p2comm == 1)
            {
                pb2notif.Image = bankers_game_proto.Properties.Resources.vote_l;
                p2notif.Text= "Congratulation!, You have been Elected as a Mayor. \r\nPay 50php to each player";
                good.Play();
            }
            else if (card == 8 && p2comm == 1)
            {
                pb2notif.Image = bankers_game_proto.Properties.Resources.bank_l;
                p2notif.Text = "Congratulation!, Your Loan Matures \r\nCollect 150php";
                good.Play();
            }
            else if (card == 9 && p2comm == 1)
            {
                pb2notif.Image = bankers_game_proto.Properties.Resources.back_l;
                p2notif.Text = "Go back 3 spaces";
                bankrupted.Play();
            }
        }
        void cardcond3()
        {
            if (card == 1 && p3comm == 1)
            {
                btnacc3.Visible = true;
                pb3notif.Image = bankers_game_proto.Properties.Resources.gotojail_t;
                p3notif.Text = "Oh no!, Your luck has ran out, You've Sent to Jail";
                bankrupted.Play();
            }
            else if (card == 2 && p3comm == 1)
            {
                pb3notif.Image = bankers_game_proto.Properties.Resources.go_t;
                p3notif.Text = "Advance To Go Tile!";
                good.Play();
            }
            else if (card == 3 && p3comm == 1)
            {
                pb3notif.Image = bankers_game_proto.Properties.Resources.student_t;
                p3notif.Text = "Sharing is Caring!, Donate 200php to schools";
                good.Play();
            }
            else if (card == 4 && p3comm == 1)
            {
                pb3notif.Image = bankers_game_proto.Properties.Resources.bank_t;
                p3notif.Text = "Because we Care, Claim 200php Ensurance";
                good.Play();
            }
            else if (card == 5 && p3comm == 1)
            {
                pb3notif.Image = bankers_game_proto.Properties.Resources.bus_t;
                p3notif.Text = "Jump To the Nearest Station, \r\nIf Unowned Purchase, If not Pay rent";
                good.Play();
            }

            else if (card == 6 && p3comm == 1)
            {
                pb3notif.Image = bankers_game_proto.Properties.Resources.bank_t;
                p3notif.Text = "You are given a dividend of 50php by the banker";
                good.Play();
            }
            else if (card == 7 && p3comm == 1)
            {
                pb3notif.Image = bankers_game_proto.Properties.Resources.vote_t;
                p3notif.Text = "Congratulation!, You have been Elected as a Mayor. \r\nPay 50php to each player";
                good.Play();
            }
            else if (card == 8 && p3comm == 1)
            {
                pb3notif.Image = bankers_game_proto.Properties.Resources.bank_t;
                p3notif.Text = "Congratulation!, Your Loan Matures \r\nCollect 150php";
                good.Play();
            }
            else if (card == 9 && p3comm == 1)
            {
                pb3notif.Image = bankers_game_proto.Properties.Resources.back_t;
                p3notif.Text = "Go back 3 spaces";
                good.Play();
            }
        }
        void cardcond4()
        {
            if (card == 1 && p4comm == 1)
            {
                btnacc4.Visible = true;
                pb4notif.Image = bankers_game_proto.Properties.Resources.gotojail__r;
                p4notif.Text = "Oh no!, Your luck has ran out, You've Sent to Jail";
                bankrupted.Play();
            }
            else if (card == 2 && p4comm == 1)
            {
                pb4notif.Image = bankers_game_proto.Properties.Resources.go_r;
                p4notif.Text = "Advance To Go Tile!";
                good.Play();
            }
            else if (card == 3 && p4comm == 1)
            {
                pb4notif.Image = bankers_game_proto.Properties.Resources.student_r;
                p4notif.Text = "Sharing is Caring!, Donate 200php to schools";
                good.Play();
            }
            else if (card == 4 && p4comm == 1)
            {
                pb4notif.Image = bankers_game_proto.Properties.Resources.bank_r;
                p4notif.Text = "Because we Care, Claim 200php Ensurance";
                good.Play();
            }
            else if (card == 5 && p4comm == 1)
            {
                pb4notif.Image = bankers_game_proto.Properties.Resources.bus_r;
                p4notif.Text = "Jump To the Nearest Station, \r\nIf Unowned Purchase, If not Pay rent";
                good.Play();
            }

            else if (card == 6 && p4comm == 1)
            {
                pb4notif.Image = bankers_game_proto.Properties.Resources.bank_r;
                p4notif.Text = "You are given a dividend of 50php by the banker";
                good.Play();
            }
            else if (card == 7 && p4comm == 1)
            {
                pb4notif.Image = bankers_game_proto.Properties.Resources.vote_r;
                p4notif.Text = "Congratulation!, You have been Elected as a Mayor. \r\nPay 50php to each player";
                good.Play();
            }
            else if (card == 8 && p4comm == 1)
            {
                pb4notif.Image = bankers_game_proto.Properties.Resources.bank_r;
                p4notif.Text = "Congratulation!, Your Loan Matures \r\nCollect 150php";
                good.Play();
            }
            else if (card == 9 && p4comm == 1)
            {
                pb4notif.Image = bankers_game_proto.Properties.Resources.back_r;
                p4notif.Text = "Go back 3 spaces";
                bankrupted.Play();
            }
        }
        #endregion

        #region Design
        void pbcard6_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pbcard6.ClientRectangle,
      SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
      SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
      SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
      SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        void pbcard5_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pbcard5.ClientRectangle,
   SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
   SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
   SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
   SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        void pbcard4_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pbcard4.ClientRectangle,
    SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
    SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
    SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
    SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        void notif4_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, notif4.ClientRectangle,
   SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
   SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
   SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
   SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        void notif3_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, notif3.ClientRectangle,
   SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
   SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
   SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
   SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        void notif2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, notif2.ClientRectangle,
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

        void pbcard3_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pbcard3.ClientRectangle,
  SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
  SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
  SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
  SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        void pbcard2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pbcard2.ClientRectangle,
SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        void pbcard1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pbcard1.ClientRectangle,
SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        void iconss()
        {
            groupBox1.BackgroundImage = bankers_game_proto.Properties.Resources.green;
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            btnacc1.BackgroundImage = bankers_game_proto.Properties.Resources.check;
            btnacc1.BackgroundImageLayout = ImageLayout.Stretch;
            btnacc2.BackgroundImage = bankers_game_proto.Properties.Resources.check_r;
            btnacc2.BackgroundImageLayout = ImageLayout.Stretch;
            btnacc3.BackgroundImage = bankers_game_proto.Properties.Resources.check_t;
            btnacc3.BackgroundImageLayout = ImageLayout.Stretch;
            btnacc4.BackgroundImage = bankers_game_proto.Properties.Resources.check_l;
            btnacc4.BackgroundImageLayout = ImageLayout.Stretch;

            notif1.BackgroundImage = bankers_game_proto.Properties.Resources.panel;
            notif1.BackgroundImageLayout = ImageLayout.Stretch;
            notif3.BackgroundImage = bankers_game_proto.Properties.Resources.panel;
            notif3.BackgroundImageLayout = ImageLayout.Stretch;
            notif2.BackgroundImage = bankers_game_proto.Properties.Resources.panel_r;
            notif2.BackgroundImageLayout = ImageLayout.Stretch;
            notif4.BackgroundImage = bankers_game_proto.Properties.Resources.panel_r;
            notif4.BackgroundImageLayout = ImageLayout.Stretch;
        }

        void carddes()
        {
            if (p1comm == 1)
            {
                pbcard1.Image = bankers_game_proto.Properties.Resources.back_card;
                pbcard2.Image = bankers_game_proto.Properties.Resources.back_card;
                pbcard3.Image = bankers_game_proto.Properties.Resources.back_card;
            }

            if (p3comm == 1)
            {
                pbcard1.Image = bankers_game_proto.Properties.Resources.back_card_t;
                pbcard2.Image = bankers_game_proto.Properties.Resources.back_card_t;
                pbcard3.Image = bankers_game_proto.Properties.Resources.back_card_t;
            }

            if (p4comm == 1)
            {
                pbcard4.Image = bankers_game_proto.Properties.Resources.back_card_r;
                pbcard5.Image = bankers_game_proto.Properties.Resources.back_card_r;
                pbcard6.Image = bankers_game_proto.Properties.Resources.back_card_r;
            }

            if (p2comm == 1)
            {
                pbcard4.Image = bankers_game_proto.Properties.Resources.back_card_l;
                pbcard5.Image = bankers_game_proto.Properties.Resources.back_card_l;
                pbcard6.Image = bankers_game_proto.Properties.Resources.back_card_l;

            }


        }

        #endregion

        #region Cards 1

        private void pbcard1_Click(object sender, EventArgs e)
        {

            if (p1comm == 1)
            {
                card = cardsh.Next(1, 10);
                cardcond1();
                notif1.Visible = true;
                btnacc1.Visible = true;
                pbcard1.Enabled = false;
                pbcard2.Enabled = false;
                pbcard3.Enabled = false;
                pbcard1.Visible = false;
                pbcard2.Visible = false;
                pbcard3.Visible = false;
                p1quit = 1;

                drawcarded.Play();
            }

            if (p3comm == 1)
            {

                card = cardsh.Next(1, 10);
                cardcond3();
                notif3.Visible = true;
                btnacc3.Visible = true;
                pbcard1.Enabled = false;
                pbcard2.Enabled = false;
                pbcard3.Enabled = false;
                pbcard1.Visible = false;
                pbcard2.Visible = false;
                pbcard3.Visible = false;
                p3quit = 1;

                drawcarded.Play();
            }
        }

        private void pbcard3_Click(object sender, EventArgs e)
        {
            if (p1comm == 1)
            {

                card = cardsh.Next(1, 10);
                cardcond1();
                notif1.Visible = true;
                btnacc1.Visible = true;
                pbcard1.Enabled = false;
                pbcard2.Enabled = false;
                pbcard3.Enabled = false;
                pbcard1.Visible = false;
                pbcard2.Visible = false;
                pbcard3.Visible = false;
                p1quit = 1;

                drawcarded.Play();
            }

            if (p3comm == 1)
            {

                card = cardsh.Next(1, 10);
                cardcond3();
                notif3.Visible = true;
                btnacc3.Visible = true;
                pbcard1.Enabled = false;
                pbcard2.Enabled = false;
                pbcard3.Enabled = false;
                pbcard1.Visible = false;
                pbcard2.Visible = false;
                pbcard3.Visible = false;

                p3quit = 1;

                drawcarded.Play();
            }
        }

        private void pbcard2_Click(object sender, EventArgs e)
        {
            if (p1comm == 1)
            {

                card = cardsh.Next(1, 10);
                cardcond1();
                notif1.Visible = true;
                btnacc1.Visible = true;
                pbcard1.Enabled = false;
                pbcard2.Enabled = false;
                pbcard3.Enabled = false;
                pbcard1.Visible = false;
                pbcard2.Visible = false;
                pbcard3.Visible = false;
                p1quit = 1;

                drawcarded.Play();
            }

            if (p3comm == 1)
            {

                card = cardsh.Next(1, 10);
                cardcond3();
                notif3.Visible = true;
                btnacc3.Visible = true;
                pbcard1.Enabled = false;
                pbcard2.Enabled = false;
                pbcard3.Enabled = false;
                pbcard1.Visible = false;
                pbcard2.Visible = false;
                pbcard3.Visible = false;

                p3quit = 1;

                drawcarded.Play();
            }

        }

        #endregion

        #region cards 2
        private void pbcard4_Click(object sender, EventArgs e)
        {

            if (p2comm == 1)
            {
                card = cardsh.Next(1, 10);
                cardcond2();
                notif2.Visible = true;
                btnacc2.Visible = true;
                pbcard4.Enabled = false;
                pbcard5.Enabled = false;
                pbcard6.Enabled = false;
                pbcard4.Visible = false;
                pbcard5.Visible = false;
                pbcard6.Visible = false;

                p2quit = 1;

                drawcarded.Play();
            }

            if (p4comm == 1)
            {

                card = cardsh.Next(1, 10);
                cardcond4();
                notif4.Visible = true;
                btnacc4.Visible = true;
                pbcard4.Enabled = false;
                pbcard5.Enabled = false;
                pbcard6.Enabled = false;
                pbcard4.Visible = false;
                pbcard5.Visible = false;
                pbcard6.Visible = false;
                p4quit = 1;
                cardcond4();
                drawcarded.Play();
            }
        }

        private void pbcard5_Click(object sender, EventArgs e)
        {
            if (p2comm == 1)
            {

                card = cardsh.Next(1, 10);
                cardcond2();
                notif2.Visible = true;
                btnacc2.Visible = true;
                pbcard4.Enabled = false;
                pbcard5.Enabled = false;
                pbcard6.Enabled = false;
                pbcard4.Visible = false;
                pbcard5.Visible = false;
                pbcard6.Visible = false;

                p2quit = 1;

                drawcarded.Play();
            }

            if (p4comm == 1)
            {

                card = cardsh.Next(1, 10);
                cardcond4();
                notif4.Visible = true;
                btnacc4.Visible = true;
                pbcard4.Enabled = false;
                pbcard5.Enabled = false;
                pbcard6.Enabled = false;
                pbcard4.Visible = false;
                pbcard5.Visible = false;
                pbcard6.Visible = false;

                p4quit = 1;

                drawcarded.Play();
            }
        }

        private void pbcard6_Click(object sender, EventArgs e)
        {
            if (p2comm == 1)
            {

                card = cardsh.Next(1, 10);
                cardcond2();
                notif2.Visible = true;
                btnacc2.Visible = true;
                pbcard4.Enabled = false;
                pbcard5.Enabled = false;
                pbcard6.Enabled = false;
                pbcard4.Visible = false;
                pbcard5.Visible = false;
                pbcard6.Visible = false;

                p2quit = 1;

                drawcarded.Play();
            }

            if (p4comm == 1)
            {

                card = cardsh.Next(1, 10);
                cardcond4();
                notif4.Visible = true;
                btnacc4.Visible = true;
                pbcard4.Enabled = false;
                pbcard5.Enabled = false;
                pbcard6.Enabled = false;
                pbcard4.Visible = false;
                pbcard5.Visible = false;
                pbcard6.Visible = false;

                p4quit = 1;

                drawcarded.Play();
            }

        }


        #endregion

        private void btnacc2_Click(object sender, EventArgs e)
        {
            p4drawch = 1;
            if (p2notif.Text.StartsWith("Oh no!, Your luck has ran out, You've Sent to Jail"))
            {
                p1quit = 0;
                p2quit = 0;
                p3quit = 0;
                p4quit = 0;
                this.Close();
            }
            if (p2notif.Text.StartsWith("Advance To Go Tile!"))
            {
                p1quit = 0;
                p2quit = 0;
                p3quit = 0;
                p4quit = 0;
                this.Close();
            }
            if (p2notif.Text.StartsWith("Sharing is Caring!, Donate 200php to schools"))
            {
                p1quit = 0;
                p2quit = 0;
                p3quit = 0;
                p4quit = 0;
                this.Close();
            }
            if (p2notif.Text.StartsWith("Because we Care, Claim 200php Ensurance"))
            {
                p1quit = 0;
                p2quit = 0;
                p3quit = 0;
                p4quit = 0;
                this.Close();
            }

            if (p2notif.Text.StartsWith("Jump To the Nearest Station, \r\nIf Unowned Purchase, If not Pay rent"))
            {
                p1quit = 0;
                p2quit = 0;
                p3quit = 0;
                p4quit = 0;
                this.Close();

            }

            if (p2notif.Text.StartsWith("You are given a dividend of 50php by the banker"))
            {
                p1quit = 0;
                p2quit = 0;
                p3quit = 0;
                p4quit = 0;
                this.Close();

            }

            if (p2notif.Text.StartsWith("Congratulation!, You have been Elected as a Mayor. \r\nPay 50php to each player"))
            {
                p1quit = 0;
                p2quit = 0;
                p3quit = 0;
                p4quit = 0;
                this.Close();

            }

            if (p2notif.Text.StartsWith("Congratulation!, Your Loan Matures \r\nCollect 150php"))
            {
                p1quit = 0;
                p2quit = 0;
                p3quit = 0;
                p4quit = 0;
                this.Close();

            }

            if (p2notif.Text.StartsWith("Go back 3 spaces"))
            {
                p1quit = 0;
                p2quit = 0;
                p3quit = 0;
                p4quit = 0;
                this.Close();

            }
        }

        private void btnacc3_Click(object sender, EventArgs e)
        {
            p4drawch = 1;
            if (p3notif.Text.StartsWith("Oh no!, Your luck has ran out, You've Sent to Jail"))
            {
                p1quit = 0;
                p2quit = 0;
                p3quit = 0;
                p4quit = 0;
                this.Close();
            }
            if (p3notif.Text.StartsWith("Advance To Go Tile!"))
            {
                p1quit = 0;
                p2quit = 0;
                p3quit = 0;
                p4quit = 0;
                this.Close();
            }
            if (p3notif.Text.StartsWith("Sharing is Caring!, Donate 200php to schools"))
            {
                p1quit = 0;
                p2quit = 0;
                p3quit = 0;
                p4quit = 0;
                this.Close();
            }
            if (p3notif.Text.StartsWith("Because we Care, Claim 200php Ensurance"))
            {
                p1quit = 0;
                p2quit = 0;
                p3quit = 0;
                p4quit = 0;
                this.Close();
            }

            if (p3notif.Text.StartsWith("Jump To the Nearest Station, \r\nIf Unowned Purchase, If not Pay rent"))
            {
                p1quit = 0;
                p2quit = 0;
                p3quit = 0;
                p4quit = 0;
                this.Close();

            }

            if (p3notif.Text.StartsWith("You are given a dividend of 50php by the banker"))
            {
                p1quit = 0;
                p2quit = 0;
                p3quit = 0;
                p4quit = 0;
                this.Close();

            }

            if (p3notif.Text.StartsWith("Congratulation!, You have been Elected as a Mayor. \r\nPay 50php to each player"))
            {
                p1quit = 0;
                p2quit = 0;
                p3quit = 0;
                p4quit = 0;
                this.Close();

            }

            if (p3notif.Text.StartsWith("Congratulation!, Your Loan Matures \r\nCollect 150php"))
            {
                p1quit = 0;
                p2quit = 0;
                p3quit = 0;
                p4quit = 0;
                this.Close();

            }

            if (p3notif.Text.StartsWith("Go back 3 spaces"))
            {
                p1quit = 0;
                p2quit = 0;
                p3quit = 0;
                p4quit = 0;
                this.Close();

            }
        }

        private void btnacc1_Click(object sender, EventArgs e)
        {
            p4drawch = 1;
            if (p1notif.Text.StartsWith("Oh no!, Your luck has ran out, You've Sent to Jail"))
            {
                p1quit = 0;
                p2quit = 0;
                p3quit = 0;
                p4quit = 0;
                this.Close();
            }
            if (p1notif.Text.StartsWith("Advance To Go Tile!"))
            {
                p1quit = 0;
                p2quit = 0;
                p3quit = 0;
                p4quit = 0;
                this.Close();
            }
            if (p1notif.Text.StartsWith("Sharing is Caring!, Donate 200php to schools"))
            {
                p1quit = 0;
                p2quit = 0;
                p3quit = 0;
                p4quit = 0;
                this.Close();
            }
            if (p1notif.Text.StartsWith("Because we Care, Claim 200php Ensurance"))
            {
                p1quit = 0;
                p2quit = 0;
                p3quit = 0;
                p4quit = 0;
                this.Close();
            }

            if (p1notif.Text.StartsWith("Jump To the Nearest Station, \r\nIf Unowned Purchase, If not Pay rent"))
            {
                p1quit = 0;
                p2quit = 0;
                p3quit = 0;
                p4quit = 0;
                this.Close();

            }

            if (p1notif.Text.StartsWith("You are given a dividend of 50php by the banker"))
            {
                p1quit = 0;
                p2quit = 0;
                p3quit = 0;
                p4quit = 0;
                this.Close();

            }

            if (p1notif.Text.StartsWith("Congratulation!, You have been Elected as a Mayor. \r\nPay 50php to each player"))
            {
                p1quit = 0;
                p2quit = 0;
                p3quit = 0;
                p4quit = 0;
                this.Close();

            }

            if (p1notif.Text.StartsWith("Congratulation!, Your Loan Matures \r\nCollect 150php"))
            {
                p1quit = 0;
                p2quit = 0;
                p3quit = 0;
                p4quit = 0;
                this.Close();

            }

            if (p1notif.Text.StartsWith("Go back 3 spaces"))
            {
                p1quit = 0;
                p2quit = 0;
                p3quit = 0;
                p4quit = 0;
                this.Close();

            }
        }

        private void btnacc4_Click(object sender, EventArgs e)
        {
            p4drawch = 1;
            if (p4notif.Text.StartsWith("Oh no!, Your luck has ran out, You've Sent to Jail"))
            {
                p1quit = 0;
                p2quit = 0;
                p3quit = 0;
                p4quit = 0;
                this.Close();
            }
            if (p4notif.Text.StartsWith("Advance To Go Tile!"))
            {
                p1quit = 0;
                p2quit = 0;
                p3quit = 0;
                p4quit = 0;
                this.Close();
            }
            if (p4notif.Text.StartsWith("Sharing is Caring!, Donate 200php to schools"))
            {
                p1quit = 0;
                p2quit = 0;
                p3quit = 0;
                p4quit = 0;
                this.Close();
            }
            if (p4notif.Text.StartsWith("Because we Care, Claim 200php Ensurance"))
            {
                p1quit = 0;
                p2quit = 0;
                p3quit = 0;
                p4quit = 0;
                this.Close();
            }

            if (p4notif.Text.StartsWith("Jump To the Nearest Station, \r\nIf Unowned Purchase, If not Pay rent"))
            {
                p1quit = 0;
                p2quit = 0;
                p3quit = 0;
                p4quit = 0;
                this.Close();

            }

            if (p4notif.Text.StartsWith("You are given a dividend of 50php by the banker"))
            {
                p1quit = 0;
                p2quit = 0;
                p3quit = 0;
                p4quit = 0;
                this.Close();

            }

            if (p4notif.Text.StartsWith("Congratulation!, You have been Elected as a Mayor. \r\nPay 50php to each player"))
            {
                p1quit = 0;
                p2quit = 0;
                p3quit = 0;
                p4quit = 0;
                this.Close();

            }

            if (p4notif.Text.StartsWith("Congratulation!, Your Loan Matures \r\nCollect 150php"))
            {
                p1quit = 0;
                p2quit = 0;
                p3quit = 0;
                p4quit = 0;
                this.Close();

            }

            if (p4notif.Text.StartsWith("Go back 3 spaces"))
            {
                p1quit = 0;
                p2quit = 0;
                p3quit = 0;
                p4quit = 0;
                this.Close();

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



    }
}
