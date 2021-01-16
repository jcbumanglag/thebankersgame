using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bankers_game_proto
{
    public partial class Ranking : Form
    {
        #region variables
        int p1scor = 0;
        int p2scor = 0;
        int p3scor = 0;
        int p4scor = 0;
        int prop1 = 0;
        int prop2 = 0;
        int prop3 = 0;
        int prop4 = 0;

        int wincon1 = 0;
        int wincon2 = 0;
        int wincon3 = 0;
        int wincon4 = 0;
        #endregion

        public Ranking()
        {
            p1scor = p4_gameplay.p1score;
            p2scor = p4_gameplay.p2score;
            p3scor = p4_gameplay.p3score;
            p4scor = p4_gameplay.p4score;

            prop1 = p4_gameplay.props1;
            prop2 = p4_gameplay.props2;
            prop3 = p4_gameplay.props3;
            prop4 = p4_gameplay.props4;

            wincon1 = p4_gameplay.wincon1;
            wincon2 = p4_gameplay.wincon2;
            wincon3 = p4_gameplay.wincon3;
            wincon4 = p4_gameplay.wincon4;

           
            InitializeComponent();
        }

        void scorings() 
        {

          if(wincon1==1)
          {
              champs1.Image = bankers_game_proto.Properties.Resources.p1win;
              propc.Text = p4_gameplay.props1.ToString();
              scorc.Text = p4_gameplay.p1score.ToString();
          }
          if (wincon2 == 1)
          {
              champs1.Image = bankers_game_proto.Properties.Resources.p2win;
              propc.Text = prop2.ToString();
              scorc.Text = p2scor.ToString();
          }
          if (wincon3 == 1)
          {
              champs1.Image = bankers_game_proto.Properties.Resources.p3win;
              propc.Text = prop3.ToString();
              scorc.Text = p3scor.ToString();
          }
          if (wincon4 == 1)
          {
              champs1.Image = bankers_game_proto.Properties.Resources.p4win;
              propc.Text = prop4.ToString();
              scorc.Text = p4scor.ToString();
          }
        }

        void design() 
        {
       
            rankgrp.BackgroundImage = bankers_game_proto.Properties.Resources.panel;
            rankgrp.BackgroundImageLayout = ImageLayout.Stretch;
            Champ.BackgroundImage = bankers_game_proto.Properties.Resources.panel;
            Champ.BackgroundImageLayout = ImageLayout.Stretch;

            rank1.Image = bankers_game_proto.Properties.Resources.p1win;
            rank2.Image = bankers_game_proto.Properties.Resources.p2win;
            rank3.Image = bankers_game_proto.Properties.Resources.p3win;
            rank4.Image = bankers_game_proto.Properties.Resources.p4win;

            Stats1.Image = bankers_game_proto.Properties.Resources.stats;
            property1.Image = bankers_game_proto.Properties.Resources.property;
            score1.Image = bankers_game_proto.Properties.Resources.score;
            pbwin.Image = bankers_game_proto.Properties.Resources.podium;

            scor1.Text = p1scor.ToString();
            scor2.Text = p2scor.ToString();
            scor3.Text = p3scor.ToString();
            scor4.Text = p4scor.ToString();

            props1.Text = prop1.ToString();
            props2.Text = prop2.ToString();
            props3.Text = prop3.ToString();
            props4.Text = prop4.ToString();
        }

        #region paint

        void rankgrp_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, rankgrp.ClientRectangle,
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

        void Champ_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, Champ.ClientRectangle,
                  SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                  SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                  SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                  SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }
        #endregion

        private void btnexit_Click(object sender, EventArgs e)
        {

            wincon1 = 0;
            wincon2 = 0;
            wincon3 = 0;
            wincon4 = 0;
          
            p4_gameplay.wincon1 = 0;
            p4_gameplay.wincon2 = 0;
            p4_gameplay.wincon3 = 0;
            p4_gameplay.wincon4 = 0;
            p4_gameplay.props1 = 0;
            p4_gameplay.props2 = 0;
            p4_gameplay.props3 = 0;
            p4_gameplay.props4 = 0;
            p4_gameplay.p1score = 0;
            p4_gameplay.p2score = 0;
            p4_gameplay.p3score = 0;
            p4_gameplay.p4score = 0;
            this.Close();
        }

        private void Ranking_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            #region paint
            Champ.Paint += new PaintEventHandler(Champ_Paint);
            btnexit.Paint += new PaintEventHandler(btnexit_Paint);
            rankgrp.Paint += new PaintEventHandler(rankgrp_Paint);
            #endregion

            
            design();
            scorings();
      
        }

        private void win_Tick(object sender, EventArgs e)
        {            
        }
    }
}
