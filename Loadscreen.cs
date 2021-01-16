using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Text;

namespace bankers_game_proto
{
    public partial class Loadscreen : Form
    {
        public Loadscreen()
        {
            p4aucd = p4_gameplay.p4aucd;
            p4tradedlod = p4_gameplay.p4tradedlod;
            InitializeComponent();
        }

        #region variable
        private int ProgressMinimum = 0;
        private int ProgressMaximum = 100;
        private int ProgressValue = 0;
        int p4aucd = 0;
        int p4tradedlod = 0;

        #endregion

        void background()
        {
   
        if(Player_Select.rush==1)
        {
            this.BackgroundImage = bankers_game_proto.Properties.Resources.bankrushscrn;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        if (Player_Select.rush == 0)
        {
            this.BackgroundImage = bankers_game_proto.Properties.Resources.freetoplayscrn;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        if(p4aucd == 1)
        {
            this.BackgroundImage = bankers_game_proto.Properties.Resources.aucscrn;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        if (p4tradedlod == 1)
        {
            this.BackgroundImage = bankers_game_proto.Properties.Resources.tradeload;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        }

        private void tmrWork_Tick(object sender, EventArgs e)
        {
            ProgressValue += 4;

            if (ProgressValue == ProgressMaximum && Player_Select.gameload==1)
            {
                ProgressValue = 0;
                Player_Select.gameload = 0;
                tmrWork.Enabled = false;
                p4_gameplay b = new p4_gameplay();
                b.Focus();
                this.Close();

            }
            if(ProgressValue >= 80)
            {
                pictureBox1.Image = bankers_game_proto.Properties.Resources.Fav_CLOSED__;
            }
  
            if (ProgressValue == ProgressMaximum && p4_gameplay.p4aucd == 1)
            {
                ProgressValue = 0;
                p4_gameplay.p4aucd = 0;
                tmrWork.Enabled = false;
                p4_gameplay b = new p4_gameplay();
                b.Focus();
                this.Close();

            }
            if (ProgressValue == ProgressMaximum && p4_gameplay.p4tradedlod == 1)
            {
                ProgressValue = 0;
                p4_gameplay.p4tradedlod = 0;
                tmrWork.Enabled = false;
                p4_gameplay b = new p4_gameplay();
                b.Focus();
                this.Close();

            }
           
            picProgress.Refresh();
        }

        // Show the progress.
        private void picProgress_Paint(object sender, PaintEventArgs e)
        {
            // Clear the background.
            e.Graphics.Clear(picProgress.BackColor);

            // Draw the progress bar.
            float fraction =
                (float)(ProgressValue - ProgressMinimum) /
                (ProgressMaximum - ProgressMinimum);
            int wid = (int)(fraction * picProgress.ClientSize.Width);
            e.Graphics.FillRectangle(
                Brushes.LightGreen, 0, 0, wid,
                picProgress.ClientSize.Height);

            // Draw the text.
            e.Graphics.TextRenderingHint =
                TextRenderingHint.AntiAliasGridFit;
            using (StringFormat sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                int percent = (int)(fraction * 100);
                e.Graphics.DrawString(
                    percent.ToString() + "%",
                    this.Font, Brushes.Black,
                    picProgress.ClientRectangle, sf);
            }
        }

        private void Loadscreen_Load(object sender, EventArgs e)
        {
            background();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            pictureBox1.Image = bankers_game_proto.Properties.Resources.Monopoly_Fav_banker_deal_;
            ProgressValue = 0;
            tmrWork.Start();
        }
    }
}
