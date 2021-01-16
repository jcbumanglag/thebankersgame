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
    public partial class Wheels : Form
    {
        #region variables
        public static int p4wheelch = 0;
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
        gamewheel wheel;
        Random rand;
        public static string result = "";
        SoundPlayer spin;

        public static int p2wheel = 0;
        public static int p2wheel2 = 0;

        public static int p4wheel1 = 0;
        public static int p4wheel2 = 0;
        public static int p4wheel3 = 0;
        public static int p4wheel4 = 0;

        public static int freeze1 = 0;
        public static int freepr1 = 0;
        public static int rev1 = 0;
        public static int demo1 = 0;
        public static int jmp1 = 0;

        public static int freeze2 = 0;
        public static int freepr2 = 0;
        public static int rev2 = 0;
        public static int demo2 = 0;
        public static int jmp2 = 0;

        public static int freeze3 = 0;
        public static int freepr3 = 0;
        public static int rev3 = 0;
        public static int demo3 = 0;
        public static int jmp3 = 0;

        public static int freeze4 = 0;
        public static int freepr4 = 0;
        public static int rev4 = 0;
        public static int demo4 = 0;
        public static int jmp4 = 0;
        #endregion

        public Wheels()
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
            spin = new SoundPlayer(bankers_game_proto.Properties.Resources._12);
            p4wheel1 = p4_gameplay.p4wheel1;
            p4wheel2 = p4_gameplay.p4wheel2;
            p4wheel3 = p4_gameplay.p4wheel3;
            p4wheel4 = p4_gameplay.p4wheel4;

            freepr1 = p4_gameplay.freepr1;
            freeze1 = p4_gameplay.freeze1;
            demo1 = p4_gameplay.demo1;
            rev1 = p4_gameplay.rev1;
            jmp1 = p4_gameplay.jmp1;

            freepr2 = p4_gameplay.freepr2;
            freeze2 = p4_gameplay.freeze2;
            demo2 = p4_gameplay.demo2;
            rev2 = p4_gameplay.rev2;
            jmp2 = p4_gameplay.jmp2;

            freepr3 = p4_gameplay.freepr3;
            freeze3 = p4_gameplay.freeze3;
            demo3 = p4_gameplay.demo3;
            rev3 = p4_gameplay.rev3;
            jmp3 = p4_gameplay.jmp3;

            freepr4 = p4_gameplay.freepr4;
            freeze4 = p4_gameplay.freeze4;
            demo4 = p4_gameplay.demo4;
            rev4 = p4_gameplay.rev4;
            jmp4 = p4_gameplay.jmp4;

            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            this.Shown += new EventHandler(form1_shown);
            panel1.Click += new EventHandler(panel1_Click);
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 53;     // this is the highest resolution possible for form timers

            
         
            rand = new Random();

        }

        #region rules
        void results1() 
        {
        if(result.StartsWith("A") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel1==1 && freeze1 == 0)
        {
            notif1.Visible = true;
            btnacc1.Visible = true;
            pb1notif.Image = bankers_game_proto.Properties.Resources.freeze;
            p1notif.Text = "You have Received Freeze Card.";
        }

        if (result.StartsWith("B") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel1 == 1 && demo1 == 0)
        {

            notif1.Visible = true;
            btnacc1.Visible = true;
            pb1notif.Image = bankers_game_proto.Properties.Resources.demolish;
            p1notif.Text = "You have Received Demolish Card.";
         
        
        }

        if (result.StartsWith("C") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel1 == 1 && jmp1 == 0)
        {

            notif1.Visible = true;
            btnacc1.Visible = true;
            pb1notif.Image = bankers_game_proto.Properties.Resources.happy;
            p1notif.Text = "You have Received Jump card.";
          
        }

        if ( result.StartsWith("D") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel1 == 1 )
        {

            notif1.Visible = true;
            btnacc1.Visible = true;
            pb1notif.Image = bankers_game_proto.Properties.Resources.gotojail;
            p1notif.Text = "Oh no!, Your luck has run out, \r\nYou sent to jail.";

        }
        if (result.StartsWith("E") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel1 == 1 && freepr1 == 0)
        {
            notif1.Visible = true;
            btnacc1.Visible = true;
            pb1notif.Image = bankers_game_proto.Properties.Resources.bail;
            p1notif.Text = "You have received Get out of jail Card.";
        }
        if (result.StartsWith("F") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel1 == 1 && rev1 == 0)
        {
            notif1.Visible = true;
            btnacc1.Visible = true;
            pb1notif.Image = bankers_game_proto.Properties.Resources.back;
            p1notif.Text = "You have received Reverse Card.";
        }
        if (result.StartsWith("G") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel1 == 1)
        {
            notif1.Visible = true;
            btnacc1.Visible = true;
            pb1notif.Image = bankers_game_proto.Properties.Resources.gotojail;
            p1notif.Text = "Oh no!, Your luck has run out, \r\nYou sent to jail.";
        }


        //already taken move to comm cards
        if (result.StartsWith("A") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel1 == 1 && freeze1 == 1)
        {
            notif1.Visible = true;
            btnacc1.Visible = true;
            pb1notif.Image = bankers_game_proto.Properties.Resources.back_card;
            p1notif.Text = "You have already acquired Freeze Card, \r\nTest your luck and gain bonuses.";

        }

        if (result.StartsWith("B") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel1 == 1 && demo1 == 1)
        {

            notif1.Visible = true;
            btnacc1.Visible = true;
            pb1notif.Image = bankers_game_proto.Properties.Resources.back_card;
            p1notif.Text = "You have already acquired Demolish Card, \r\nTest your luck and gain bonuses.";


        }

        if (result.StartsWith("C") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel1 == 1 && jmp1 == 1)
        {

            notif1.Visible = true;
            btnacc1.Visible = true;
            pb1notif.Image = bankers_game_proto.Properties.Resources.back_card;
            p1notif.Text = "You have already acquired Jump Card, \r\nTest your luck and gain bonuses.";

        }


        if (result.StartsWith("E") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel1 == 1 && freepr1 == 1)
        {
            notif1.Visible = true;
            btnacc1.Visible = true;
            pb1notif.Image = bankers_game_proto.Properties.Resources.back_card;
            p1notif.Text = "You have already acquired Get out of jail Card, \r\nTest your luck and gain bonuses.";
        }
        if (result.StartsWith("F") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel1 == 1 && rev1 == 1)
        {
            notif1.Visible = true;
            btnacc1.Visible = true;
            pb1notif.Image = bankers_game_proto.Properties.Resources.back_card;
            p1notif.Text = "You have already acquired Reverse Card, \r\nTest your luck and gain bonuses.";
        }
        }
        void results2()
        {
            if (result.StartsWith("A") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel2 == 1 && freeze2 == 0)
            {
                notif2.Visible = true;
                btnacc2.Visible = true;
                pb2notif.Image = bankers_game_proto.Properties.Resources.freeze;
                p2notif.Text = "You have Received Freeze Card.";
            }

            if (result.StartsWith("B") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel2 == 1 && demo2 == 0)
            {

                notif2.Visible = true;
                btnacc2.Visible = true;
                pb2notif.Image = bankers_game_proto.Properties.Resources.demolish_l;
                p2notif.Text = "You have Received Demolish Card.";


            }

            if (result.StartsWith("C") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel2 == 1 && jmp2 == 0)
            {

                notif2.Visible = true;
                btnacc2.Visible = true;
                pb2notif.Image = bankers_game_proto.Properties.Resources.happy_l;
                p2notif.Text = "You have Received Jump card.";

            }

            if (result.StartsWith("D") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel2 == 1)
            {

                notif2.Visible = true;
                btnacc2.Visible = true;
                pb2notif.Image = bankers_game_proto.Properties.Resources.gotojail_l;
                p2notif.Text = "Oh no!, Your luck has run out, \r\nYou sent to jail.";

            }
            if (result.StartsWith("E") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel2 == 1 && freepr2 == 0)
            {
                notif2.Visible = true;
                btnacc2.Visible = true;
                pb2notif.Image = bankers_game_proto.Properties.Resources.bail__1__l;
                p2notif.Text = "You have received Get out of jail Card.";
            }
            if (result.StartsWith("F") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel2 == 1 && rev2 == 0)
            {
                notif2.Visible = true;
                btnacc2.Visible = true;
                pb2notif.Image = bankers_game_proto.Properties.Resources.back_l;
                p2notif.Text = "You have received Reverse Card.";
            }
            if (result.StartsWith("G") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel2 == 1)
            {
                notif2.Visible = true;
                btnacc2.Visible = true;
                pb2notif.Image = bankers_game_proto.Properties.Resources.gotojail_l;
                p2notif.Text = "Oh no!, Your luck has run out, \r\nYou sent to jail.";
            }
            //already taken move to comm cards
            if (result.StartsWith("A") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel2 == 1 && freeze2 == 1)
            {
                notif2.Visible = true;
                btnacc2.Visible = true;
                pb2notif.Image = bankers_game_proto.Properties.Resources.back_card_l;
                p2notif.Text = "You have already acquired Freeze Card, \r\nTest your luck and gain bonuses.";

            }

            if (result.StartsWith("B") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel2 == 1 && demo2 == 1)
            {

                notif2.Visible = true;
                btnacc2.Visible = true;
                pb2notif.Image = bankers_game_proto.Properties.Resources.back_card_l;
                p2notif.Text = "You have already acquired Demolish Card, \r\nTest your luck and gain bonuses.";


            }

            if (result.StartsWith("C") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel2 == 1 && jmp2 == 1)
            {

                notif2.Visible = true;
                btnacc2.Visible = true;
                pb2notif.Image = bankers_game_proto.Properties.Resources.back_card_l;
                p2notif.Text = "You have already acquired Jump Card, \r\nTest your luck and gain bonuses.";

            }


            if (result.StartsWith("E") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel2 == 1 && freepr2 == 1)
            {
                notif2.Visible = true;
                btnacc2.Visible = true;
                pb2notif.Image = bankers_game_proto.Properties.Resources.back_card_l;
                p2notif.Text = "You have already acquired Get out of jail Card, \r\nTest your luck and gain bonuses.";
            }
            if (result.StartsWith("F") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel2 == 1 && rev2 == 1)
            {
                notif2.Visible = true;
                btnacc2.Visible = true;
                pb2notif.Image = bankers_game_proto.Properties.Resources.back_card;
                p2notif.Text = "You have already acquired Reverse Card, \r\nTest your luck and gain bonuses.";
            }

        }
        void results3()
        {
            if (result.StartsWith("A") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel3 == 1 && freeze3 == 0)
            {
                notif3.Visible = true;
                btnacc3.Visible = true;
                pb3notif.Image = bankers_game_proto.Properties.Resources.freeze;
                p3notif.Text = "You have Received Freeze Card.";
            }

            if ( result.StartsWith("B") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel3 == 1 && demo3==0)
            {

                notif3.Visible = true;
                btnacc3.Visible = true;
                pb3notif.Image = bankers_game_proto.Properties.Resources.demolish_t;
                p3notif.Text = "You have Received Demolish Card.";


            }

            if ( result.StartsWith("C") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel3 == 1 && jmp3 == 0)
            {

                notif3.Visible = true;
                btnacc3.Visible = true;
                pb3notif.Image = bankers_game_proto.Properties.Resources.happy_t;
                p3notif.Text = "You have Received Jump card.";

            }

            if (result.StartsWith("D") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel3 == 1)
            {

                notif3.Visible = true;
                btnacc3.Visible = true;
                pb3notif.Image = bankers_game_proto.Properties.Resources.gotojail_t;
                p3notif.Text = "Oh no!, Your luck has run out, \r\nYou sent to jail.";

            }
            if (result.StartsWith("E") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel3 == 1 && freepr3 == 0)
            {
                notif3.Visible = true;
                btnacc3.Visible = true;
                pb3notif.Image = bankers_game_proto.Properties.Resources.bail_1__t;
                p3notif.Text = "You have received Get out of jail Card.";
            }
            if (result.StartsWith("F") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel3 == 1 && rev3 == 0)
            {
                notif3.Visible = true;
                btnacc3.Visible = true;
                pb3notif.Image = bankers_game_proto.Properties.Resources.back_t;
                p3notif.Text = "You have received Reverse Card.";
            }
            if (result.StartsWith("G") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel3 == 1)
            {
                notif3.Visible = true;
                btnacc3.Visible = true;
                pb3notif.Image = bankers_game_proto.Properties.Resources.gotojail_t;
                p3notif.Text = "Oh no!, Your luck has run out, \r\nYou sent to jail.";
            }
            //already taken move to comm cards
            if (result.StartsWith("A") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel3 == 1 && freeze3 == 1)
            {
                notif3.Visible = true;
                btnacc3.Visible = true;
                pb3notif.Image = bankers_game_proto.Properties.Resources.back_card_t;
                p3notif.Text = "You have already acquired Freeze Card, \r\nTest your luck and gain bonuses.";

            }

            if (result.StartsWith("B") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel3 == 1 && demo3 == 1)
            {

                notif3.Visible = true;
                btnacc3.Visible = true;
                pb3notif.Image = bankers_game_proto.Properties.Resources.back_card_t;
                p3notif.Text = "You have already acquired Demolish Card, \r\nTest your luck and gain bonuses.";


            }

            if ( result.StartsWith("C") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel3 == 1 && p4_gameplay.jmp3 == 1)
            {

                notif3.Visible = true;
                btnacc3.Visible = true;
                pb3notif.Image = bankers_game_proto.Properties.Resources.back_card_t;
                p3notif.Text = "You have already acquired Jump Card, \r\nTest your luck and gain bonuses.";

            }


            if (result.StartsWith("E") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel3 == 1 && p4_gameplay.freepr3 == 1)
            {
                notif3.Visible = true;
                btnacc3.Visible = true;
                pb3notif.Image = bankers_game_proto.Properties.Resources.back_card_t;
                p3notif.Text = "You have already acquired Get out of jail Card, \r\nTest your luck and gain bonuses.";
            }
            if (result.StartsWith("F") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel3 == 1 && p4_gameplay.rev3 == 1)
            {
                notif3.Visible = true;
                btnacc3.Visible = true;
                pb3notif.Image = bankers_game_proto.Properties.Resources.back_card_t;
                p3notif.Text = "You have already acquired Reverse Card, \r\nTest your luck and gain bonuses.";
            }
        }
        void results4() 
        {
            if (result.StartsWith("A") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel4 == 1 && freeze4 == 0)
            {
                notif4.Visible = true;
                btnacc4.Visible = true;
                pb4notif.Image = bankers_game_proto.Properties.Resources.freeze;
                p4notif.Text = "You have Received Freeze Card.";
            }

            if (result.StartsWith("B") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel4 == 1 && demo4 == 0)
            {

                notif4.Visible = true;
                btnacc4.Visible = true;
                pb4notif.Image = bankers_game_proto.Properties.Resources.demolish_r;
                p4notif.Text = "You have Received Demolish Card.";


            }

            if (result.StartsWith("C") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel4 == 1 && jmp4 == 0)
            {

                notif4.Visible = true;
                btnacc4.Visible = true;
                pb4notif.Image = bankers_game_proto.Properties.Resources.happy_r;
                p4notif.Text = "You have Received Jump card.";

            }

            if (result.StartsWith("D") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel4 == 1)
            {

                notif4.Visible = true;
                btnacc4.Visible = true;
                pb4notif.Image = bankers_game_proto.Properties.Resources.gotojail__r;
                p4notif.Text = "Oh no!, Your luck has run out, \r\nYou sent to jail.";

            }
            if (result.StartsWith("E") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel4 == 1 && freepr4 == 0)
            {
                notif4.Visible = true;
                btnacc4.Visible = true;
                pb4notif.Image = bankers_game_proto.Properties.Resources.bail__1__r;
                p4notif.Text = "You have received Get out of jail Card.";
            }
            if (result.StartsWith("F") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel4 == 1 && rev4 == 0)
            {
                notif4.Visible = true;
                btnacc4.Visible = true;
                pb4notif.Image = bankers_game_proto.Properties.Resources.back_r;
                p4notif.Text = "You have received Reverse Card.";
            }
            if (result.StartsWith("G") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel4 == 1)
            {
                notif4.Visible = true;
                btnacc4.Visible = true;
                pb4notif.Image = bankers_game_proto.Properties.Resources.gotojail__r;
                p4notif.Text = "Oh no!, Your luck has run out, \r\nYou sent to jail.";
            }
            //already taken move to comm cards
            if (result.StartsWith("A") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel4 == 1 && freeze4 == 1)
            {
                notif4.Visible = true;
                btnacc4.Visible = true;
                pb4notif.Image = bankers_game_proto.Properties.Resources.back_card_r;
                p4notif.Text = "You have already acquired Freeze Card, \r\nTest your luck and gain bonuses.";

            }

            if (result.StartsWith("B") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel4 == 1 && demo4 == 1)
            {

                notif4.Visible = true;
                btnacc4.Visible = true;
                pb4notif.Image = bankers_game_proto.Properties.Resources.back_card_r;
                p4notif.Text = "You have already acquired Demolish Card, \r\nTest your luck and gain bonuses.";


            }

            if (result.StartsWith("C") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel4 == 1 && jmp4 == 1)
            {

                notif4.Visible = true;
                btnacc4.Visible = true;
                pb4notif.Image = bankers_game_proto.Properties.Resources.back_card_r;
                p4notif.Text = "You have already acquired Jump Card, \r\nTest your luck and gain bonuses.";

            }


            if (result.StartsWith("E") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel4 == 1 && freepr4 == 1)
            {
                notif4.Visible = true;
                btnacc4.Visible = true;
                pb4notif.Image = bankers_game_proto.Properties.Resources.back_card_r;
                p4notif.Text = "You have already acquired Get out of jail Card, \r\nTest your luck and gain bonuses.";
            }
            if (result.StartsWith("F") && wheel.state == gamewheel.STATE_HIGHLIGHTING && p4wheel4 == 1 && rev4 == 1)
            {
                notif4.Visible = true;
                btnacc4.Visible = true;
                pb4notif.Image = bankers_game_proto.Properties.Resources.back_card;
                p4notif.Text = "You have already acquired Reverse Card, \r\nTest your luck and gain bonuses.";
            }
        }

        #endregion

        #region design
        void iconss() 
        {
            notif1.BackgroundImage = bankers_game_proto.Properties.Resources.panel;
            notif1.BackgroundImageLayout = ImageLayout.Stretch;
            notif2.BackgroundImage = bankers_game_proto.Properties.Resources.panel_r;
            notif2.BackgroundImageLayout = ImageLayout.Stretch;
            notif3.BackgroundImage = bankers_game_proto.Properties.Resources.panel;
            notif3.BackgroundImageLayout = ImageLayout.Stretch;
            notif4.BackgroundImage = bankers_game_proto.Properties.Resources.panel_r;
            notif4.BackgroundImageLayout = ImageLayout.Stretch;
        }
        void icondes() 
        {
            btnacc1.BackgroundImage = bankers_game_proto.Properties.Resources.check;
            btnacc1.BackgroundImageLayout = ImageLayout.Stretch;
            btnacc2.BackgroundImage = bankers_game_proto.Properties.Resources.check_r;
            btnacc2.BackgroundImageLayout = ImageLayout.Stretch;
            btnacc3.BackgroundImage = bankers_game_proto.Properties.Resources.check_t;
            btnacc3.BackgroundImageLayout = ImageLayout.Stretch;
            btnacc4.BackgroundImage = bankers_game_proto.Properties.Resources.check_l;
            btnacc4.BackgroundImageLayout = ImageLayout.Stretch;
        }
        #endregion

        void form1_shown(object sender, EventArgs e)
        {
            panel1.Height = this.ClientSize.Height;
            panel1.Width = panel1.Height + 100;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            Point panelCenter = new Point(panel1.Width / 2, panel1.Height / 2);

            int radius = (this.ClientSize.Height - 20) / 2;
            string[] values = new String[] { "A", "B", "C", "D", "E", "F", "G"};
            wheel = new gamewheel(panelCenter, radius, values);


            wheel.SetGraphics(panel1.CreateGraphics());
            wheel.Draw();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            wheel.Refresh(true);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (wheel.state == gamewheel.STATE_NOT_STARTED)
            {
                // the game can only be played once
                timer1.Start();
                spin.Play();
                result = wheel.Spin(ref rand);

  
           }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            panel1.BackgroundImage = bankers_game_proto.Properties.Resources.green;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = bankers_game_proto.Properties.Resources.green;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            #region Paint
            notif1.Paint += new PaintEventHandler(notif1_Paint);
            notif2.Paint += new PaintEventHandler(notif2_Paint);
            notif3.Paint += new PaintEventHandler(notif3_Paint);
            notif4.Paint += new PaintEventHandler(notif4_Paint);
            #endregion
            iconss();
            icondes();
        }

        #region

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

        #endregion

        private void res_Tick(object sender, EventArgs e)
        {

            if (wheel.state == gamewheel.STATE_HIGHLIGHTING)
            {

                sss.Enabled = false;
                results1();
                results2();
                results3();
                results4();
            }
           
        }

        private void btnacc1_Click(object sender, EventArgs e)
        {
            p4wheelch = 1;
            if (p1notif.Text.StartsWith("You have Received Freeze Card."))
            {

                result = "";
                p4wheel1 = 0;
                this.Close();
                click.Play();
            }
            if (p1notif.Text.StartsWith("You have Received Demolish Card."))
            {
                result = "";
                p4wheel1 = 0;
                this.Close();
                click.Play();
            }
            if (p1notif.Text.StartsWith("You have Received Jump card."))
            {
                result = "";
                p4wheel1 = 0;
                this.Close();
                click.Play();
            }
            if (p1notif.Text.StartsWith("Oh no!, Your luck has run out, \r\nYou sent to jail."))
            {
                result = "";
                p4wheel1 = 0;
                this.Close();
                click.Play();
            }
            if (p1notif.Text.StartsWith("You have received Get out of jail Card."))
            {
                result = "";
                p4wheel1 = 0;
                this.Close();
                click.Play();
            }
            if (p1notif.Text.StartsWith("You have received Reverse Card."))
            {
                result = "";
                p4wheel1 = 0;
                this.Close();
                click.Play();
            }

            //edit for 2 players
            if (p1notif.Text.StartsWith("You have already acquired Freeze Card, \r\nTest your luck and gain bonuses."))
            {

                result = "";
                p2wheel = 0;
                p4wheel1 = 0;
                p4_gameplay.p4wheel1 = 0;
                Drawcardp4.p1comm = 1;
                p4_gameplay.p1comm = 1;
                Drawcardp4 b = new Drawcardp4();
                b.Focus();
                b.Show();
                this.Close();
                click.Play();
            }
            if (p1notif.Text.StartsWith("You have already acquired Demolish Card, \r\nTest your luck and gain bonuses."))
            {
                result = "";
                p2wheel = 0;
                p4wheel1 = 0;
                p4_gameplay.p4wheel1 = 0;
                Drawcardp4.p1comm = 1;
                p4_gameplay.p1comm = 1;
                Drawcardp4 b = new Drawcardp4();
                b.Focus();
                b.Show();
                this.Close();
                click.Play();
            }
            if (p1notif.Text.StartsWith("You have already acquired Jump Card, \r\nTest your luck and gain bonuses."))
            {
                result = "";
                p2wheel = 0;
                p4wheel1 = 0;
                p4_gameplay.p4wheel1 = 0;
                Drawcardp4.p1comm = 1;
                p4_gameplay.p1comm = 1;
                Drawcardp4 b = new Drawcardp4();
                b.Focus();
                b.Show();
                this.Close();
                click.Play();
            }

            if (p1notif.Text.StartsWith("You have already acquired Get out of jail Card, \r\nTest your luck and gain bonuses."))
            {
                result = "";
                p2wheel = 0;
                p4wheel1 = 0;
                p4_gameplay.p4wheel1 = 0;
                Drawcardp4.p1comm = 1;
                p4_gameplay.p1comm = 1;
                Drawcardp4 b = new Drawcardp4();
                b.Focus();
                b.Show();
                this.Close();
                click.Play();
            }
            if (p1notif.Text.StartsWith("You have already acquired Reverse Card, \r\nTest your luck and gain bonuses."))
            {
                result = "";
                p2wheel = 0;
                p4wheel1 = 0;
                p4_gameplay.p4wheel1 = 0;
                Drawcardp4.p1comm = 1;
                p4_gameplay.p1comm = 1;
                Drawcardp4 b = new Drawcardp4();
                b.Focus();
                b.Show();
                this.Close();
                click.Play();
            }
        }

        private void btnacc3_Click(object sender, EventArgs e)
        {
            p4wheelch = 1;
            if (p3notif.Text.StartsWith("You have Received Freeze Card."))
            {
                result = "";
                p4wheel3 = 0;
                this.Close();
                click.Play();
            }
            if (p3notif.Text.StartsWith("You have Received Demolish Card."))
            {
                result = "";
                p4wheel3 = 0;
                this.Close();
                click.Play();
            }
            if (p3notif.Text.StartsWith("You have Received Jump card."))
            {
                result = "";
                p4wheel3 = 0;
                this.Close();
                click.Play();
            }
            if (p3notif.Text.StartsWith("Oh no!, Your luck has run out, \r\nYou sent to jail."))
            {
                result = "";
                p4wheel3 = 0;
                this.Close();
                click.Play();
            }
            if (p3notif.Text.StartsWith("You have received Get out of jail Card."))
            {
                result = "";
                p4wheel3 = 0;
                this.Close();
                click.Play();
            }
            if (p3notif.Text.StartsWith("You have received Reverse Card."))
            {
                result = "";
                p4wheel3 = 0;
                this.Close();
                click.Play();
            }
            //edit for 2 players
            if (p3notif.Text.StartsWith("You have already acquired Freeze Card, \r\nTest your luck and gain bonuses."))
            {

                result = "";
                p2wheel = 0;
                p4wheel3 = 0;
                p4_gameplay.p4wheel3 = 0;
                p4_gameplay.p3comm = 1;
                Drawcardp4.p3comm = 1;
                Drawcardp4 b = new Drawcardp4();
                b.Focus();
                b.Show();
                this.Close();
                click.Play();
            }
            if (p3notif.Text.StartsWith("You have already acquired Demolish Card, \r\nTest your luck and gain bonuses."))
            {
                result = "";
                p2wheel = 0;
                p4wheel3 = 0;
                p4_gameplay.p4wheel3 = 0;
                p4_gameplay.p3comm = 1;
                Drawcardp4.p3comm = 1;
                Drawcardp4 b = new Drawcardp4();
                b.Focus();
                b.Show();
                this.Close();
                click.Play();
            }
            if (p3notif.Text.StartsWith("You have already acquired Jump Card, \r\nTest your luck and gain bonuses."))
            {
                result = "";
                p2wheel = 0;
                p4wheel3 = 0;
                p4_gameplay.p4wheel3 = 0;
                Drawcardp4.p3comm = 1;
                p4_gameplay.p3comm = 1;
                Drawcardp4 b = new Drawcardp4();
                b.Focus();
                b.Show();
                this.Close();
                click.Play();
            }

            if (p3notif.Text.StartsWith("You have already acquired Get out of jail Card, \r\nTest your luck and gain bonuses."))
            {
                result = "";
                p2wheel = 0;
                p4wheel3 = 0;
                p4_gameplay.p4wheel3 = 0;
                Drawcardp4.p3comm = 1;
                p4_gameplay.p3comm = 1;
                Drawcardp4 b = new Drawcardp4();
                b.Focus();
                b.Show();
                this.Close();
                click.Play();
            }
            if (p3notif.Text.StartsWith("You have already acquired Reverse Card, \r\nTest your luck and gain bonuses."))
            {
                result = "";
                p2wheel = 0;
                p4wheel3 = 0;
                p4_gameplay.p4wheel3 = 0;
                Drawcardp4.p3comm = 1;
                p4_gameplay.p3comm = 1;
                Drawcardp4 b = new Drawcardp4();
                b.Focus();
                b.Show();
                this.Close();
                click.Play();
            }
        }

        private void btnacc2_Click(object sender, EventArgs e)
        {
            p4wheelch = 1;
            if (p2notif.Text.StartsWith("You have Received Freeze Card."))
            {
                p2wheel2 = 0;
                p4wheel2 = 0;
                result = "";
                this.Close();
                click.Play();
            }
            if (p2notif.Text.StartsWith("You have Received Demolish Card."))
            {
                p2wheel2 = 0;
                p4wheel2 = 0;
                result = "";
                this.Close();
                click.Play();
            }
            if (p2notif.Text.StartsWith("You have Received Jump card."))
            {
                p2wheel2 = 0;
                p4wheel2 = 0;
                result = "";
                this.Close();
                click.Play();
            }
            if (p2notif.Text.StartsWith("Oh no!, Your luck has run out, \r\nYou sent to jail."))
            {
                p2wheel2 = 0;
                p4wheel2 = 0;
                result = "";
                this.Close();
                click.Play();
            }
            if (p2notif.Text.StartsWith("You have received Get out of jail Card."))
            {
                p2wheel2 = 0;
                p4wheel2 = 0;
                result = "";
                this.Close();
                click.Play();
            }
            if (p2notif.Text.StartsWith("You have received Reverse Card."))
            {
                p2wheel2 = 0;
                p4wheel2 = 0;
                result = "";
                this.Close();
                click.Play();
            }
            //edit for 2 players
            if (p2notif.Text.StartsWith("You have already acquired Freeze Card, \r\nTest your luck and gain bonuses."))
            {

                result = "";
                p2wheel2 = 0;
                p4wheel2 = 0;
                p4_gameplay.p4wheel2 = 0;
                Drawcardp4.p2comm = 1;
                p4_gameplay.p2comm = 1;
                Drawcardp4 b = new Drawcardp4();
                b.Focus();
                b.Show();
                this.Close();
                click.Play();
            }
            if (p2notif.Text.StartsWith("You have already acquired Demolish Card, \r\nTest your luck and gain bonuses."))
            {
                result = "";
                p2wheel2 = 0;
                p4wheel2 = 0;
                p4_gameplay.p4wheel2 = 0;
                Drawcardp4.p2comm = 1;
                p4_gameplay.p2comm = 1;
                Drawcardp4 b = new Drawcardp4();
                b.Focus();
                b.Show();
                this.Close();
                click.Play();
            }
            if (p2notif.Text.StartsWith("You have already acquired Jump Card, \r\nTest your luck and gain bonuses."))
            {
                result = "";
                p2wheel2 = 0;
                p4wheel2 = 0;
                p4_gameplay.p4wheel2 = 0;
                Drawcardp4.p2comm = 1;
                p4_gameplay.p2comm = 1;
                Drawcardp4 b = new Drawcardp4();
                b.Focus();
                b.Show();
                this.Close();
                click.Play();
            }

            if (p2notif.Text.StartsWith("You have already acquired Get out of jail Card, \r\nTest your luck and gain bonuses."))
            {
                result = "";
                p2wheel2 = 0;
                p4wheel2 = 0;
                p4_gameplay.p4wheel2 = 0;
                Drawcardp4.p2comm = 1;
                p4_gameplay.p2comm = 1;
                Drawcardp4 b = new Drawcardp4();
                b.Focus();
                b.Show();
                this.Close();
                click.Play();
            }
            if (p2notif.Text.StartsWith("You have already acquired Reverse Card, \r\nTest your luck and gain bonuses."))
            {
                result = "";
                p2wheel2 = 0;
                p4wheel2 = 0;
                p4_gameplay.p4wheel2 = 0;
                Drawcardp4.p2comm = 1;
                p4_gameplay.p2comm = 1;
                Drawcardp4 b = new Drawcardp4();
                b.Focus();
                b.Show();
                this.Close();
                click.Play();
            }
        }

        private void btnacc4_Click(object sender, EventArgs e)
        {
            p4wheelch = 1;
            if (p4notif.Text.StartsWith("You have Received Freeze Card."))
            {
                result = "";
                p4wheel4 = 0;
                this.Close();
                click.Play();
            }
            if (p4notif.Text.StartsWith("You have Received Demolish Card."))
            {
                result = "";
                p4wheel4 = 0;
                this.Close();
                click.Play();
            }
            if (p4notif.Text.StartsWith("You have Received Jump card."))
            {
                result = "";
                p4wheel4 = 0;
                this.Close();
                click.Play();
            }
            if (p4notif.Text.StartsWith("Oh no!, Your luck has run out, \r\nYou sent to jail."))
            {
                result = "";
                p4wheel4 = 0;
                this.Close();
                click.Play();
            }
            if (p4notif.Text.StartsWith("You have received Get out of jail Card."))
            {
                result = "";
                p4wheel4 = 0;
                this.Close();
                click.Play();
            }
            if (p4notif.Text.StartsWith("You have received Reverse Card."))
            {
                result = "";
                p4wheel4 = 0;
                this.Close();
                click.Play();
            }
            //edit for 2 players
            if (p4notif.Text.StartsWith("You have already acquired Freeze Card, \r\nTest your luck and gain bonuses."))
            {

                result = "";
                p2wheel = 0;
                p4wheel4 = 0;
                p4_gameplay.p4wheel4 = 0;
                Drawcardp4.p4comm = 1;
                p4_gameplay.p4comm = 1;
                Drawcardp4 b = new Drawcardp4();
                b.Focus();
                b.Show();
                this.Close();
                click.Play();
            }
            if (p4notif.Text.StartsWith("You have already acquired Demolish Card, \r\nTest your luck and gain bonuses."))
            {
                result = "";
                p2wheel = 0;
                p4wheel4 = 0;
                p4_gameplay.p4wheel4 = 0;
                Drawcardp4.p4comm = 1;
                p4_gameplay.p4comm = 1;
                Drawcardp4 b = new Drawcardp4();
                b.Focus();
                b.Show();
                this.Close();
                click.Play();
            }
            if (p4notif.Text.StartsWith("You have already acquired Jump Card, \r\nTest your luck and gain bonuses."))
            {
                result = "";
                p2wheel = 0;
                p4wheel4 = 0;
                p4_gameplay.p4wheel4 = 0;
                Drawcardp4.p4comm = 1;
                p4_gameplay.p4comm = 1;
                Drawcardp4 b = new Drawcardp4();
                b.Focus();
                b.Show();
                this.Close();
                click.Play();
            }

            if (p4notif.Text.StartsWith("You have already acquired Get out of jail Card, \r\nTest your luck and gain bonuses."))
            {
                result = "";
                p2wheel = 0;
                p4wheel4 = 0;
                p4_gameplay.p4wheel4 = 0;
                Drawcardp4.p4comm = 1;
                p4_gameplay.p4comm = 1;
                Drawcardp4 b = new Drawcardp4();
                b.Focus();
                b.Show();
                this.Close();
                click.Play();
            }
            if (p4notif.Text.StartsWith("You have already acquired Reverse Card, \r\nTest your luck and gain bonuses."))
            {
                result = "";
                p2wheel = 0;
                p4wheel4 = 0;
                p4_gameplay.p4wheel4 = 0;
                Drawcardp4.p4comm = 1;
                p4_gameplay.p4comm = 1;
                Drawcardp4 b = new Drawcardp4();
                b.Focus();
                b.Show();
                this.Close();
                click.Play();
            }
        }


      
    }
}
