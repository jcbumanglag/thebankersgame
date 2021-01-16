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
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
        }

        private void Map_Load(object sender, EventArgs e)
        {
            icon();
            des();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            groupBox1.Paint += new PaintEventHandler(groupBox1_Paint);
            btnexit.Paint += new PaintEventHandler(btnexit_Paint);
            brd.Paint += new PaintEventHandler(brd_Paint);
        }

        #region design
        void brd_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, brd.ClientRectangle,
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

        void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, groupBox1.ClientRectangle,
              SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
              SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
              SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
              SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        void icon() {
            btn1x1.Visible = false;
            btn2x1.Visible = false;
            btn3x1.Visible = false;
            btn4x1.Visible = false;
            btn5x1.Visible = false;
            btn6x1.Visible = false;
            btn7x1.Visible = false;
            btn8x1.Visible = false;
            btn9x1.Visible = false;
            btn10x1.Visible = false;
            btn11x1.Visible = false;
            btn12x1.Visible = false;
            btn13x1.Visible = false;
            btn14x1.Visible = false;
            btn15x1.Visible = false;
            btn16x1.Visible = false;
            btn17x1.Visible = false;
            btn18x1.Visible = false;
            btn19x1.Visible = false;
            btn20x1.Visible = false;
            btn21x1.Visible = false;
            btn22x1.Visible = false;
            btn23x1.Visible = false;
            btn24x1.Visible = false;
            btn25x1.Visible = false;
            btn26x1.Visible = false;
            btn27x1.Visible = false;
            btn28x1.Visible = false;
            btn29x1.Visible = false;
            btn30x1.Visible = false;
            btn31x1.Visible = false;
            btn32x1.Visible = false;
            btn33x1.Visible = false;
            btn34x1.Visible = false;
            btn35x1.Visible = false;
            btn36x1.Visible = false;
            btn37x1.Visible = false;
            btn38x1.Visible = false;
            btn39x1.Visible = false;
            btn40x1.Visible = false;
               
        }

        void des() 
        {
            comboBox1.Text = "------------------";
            label1.Text = "";

            btnexit.Image = bankers_game_proto.Properties.Resources.fa2d98d6414563c58d66663dd6b2e1c5;
            btnexit.Parent = groupBox1;
            btnexit.BackColor = Color.Transparent;

            groupBox2.BackgroundImage = bankers_game_proto.Properties.Resources.kisspng_gear_data_icon_ppt_design_gear_icon_5a80761cd85096_6031217115183682848861;
            groupBox2.BackgroundImageLayout = ImageLayout.Tile;
            brd.BackgroundImage = bankers_game_proto.Properties.Resources._21;
            brd.BackgroundImageLayout = ImageLayout.Stretch;
        }
        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "------------------")
            {
                icon();
                label1.Text = "";
            }

            else if (comboBox1.Text == "Free Space")
            {
                btn1x1.Visible = false;
                btn2x1.Visible = false;
                btn3x1.Visible = false;
                btn4x1.Visible = false;
                btn5x1.Visible = false;
                btn6x1.Visible = false;
                btn7x1.Visible = false;
                btn8x1.Visible = false;
                btn9x1.Visible = false;
                btn10x1.Visible = false;
                btn11x1.Visible = false;
                btn12x1.Visible = false;
                btn13x1.Visible = false;
                btn14x1.Visible = false;
                btn15x1.Visible = false;
                btn16x1.Visible = false;
                btn17x1.Visible = false;
                btn18x1.Visible = false;
                btn19x1.Visible = false;
                btn20x1.Visible = false;
                btn21x1.Visible = true;
                btn22x1.Visible = false;
                btn23x1.Visible = false;
                btn24x1.Visible = false;
                btn25x1.Visible = false;
                btn26x1.Visible = false;
                btn27x1.Visible = false;
                btn28x1.Visible = false;
                btn29x1.Visible = false;
                btn30x1.Visible = false;
                btn31x1.Visible = false;
                btn32x1.Visible = false;
                btn33x1.Visible = false;
                btn34x1.Visible = false;
                btn35x1.Visible = false;
                btn36x1.Visible = false;
                btn37x1.Visible = false;
                btn38x1.Visible = false;
                btn39x1.Visible = false;
                btn40x1.Visible = false;
                label1.TabIndex = 10;
                label1.Text = "If a player lands on this tile,\r\ngains 50php and free from rents.";
            }


            else if(comboBox1.Text=="Go/Start Tile"){
                btn1x1.Visible = true;
                btn2x1.Visible = false;
                btn3x1.Visible = false;
                btn4x1.Visible = false;
                btn5x1.Visible = false;
                btn6x1.Visible = false;
                btn7x1.Visible = false;
                btn8x1.Visible = false;
                btn9x1.Visible = false;
                btn10x1.Visible = false;
                btn11x1.Visible = false;
                btn12x1.Visible = false;
                btn13x1.Visible = false;
                btn14x1.Visible = false;
                btn15x1.Visible = false;
                btn16x1.Visible = false;
                btn17x1.Visible = false;
                btn18x1.Visible = false;
                btn19x1.Visible = false;
                btn20x1.Visible = false;
                btn21x1.Visible = false;
                btn22x1.Visible = false;
                btn23x1.Visible = false;
                btn24x1.Visible = false;
                btn25x1.Visible = false;
                btn26x1.Visible = false;
                btn27x1.Visible = false;
                btn28x1.Visible = false;
                btn29x1.Visible = false;
                btn30x1.Visible = false;
                btn31x1.Visible = false;
                btn32x1.Visible = false;
                btn33x1.Visible = false;
                btn34x1.Visible = false;
                btn35x1.Visible = false;
                btn36x1.Visible = false;
                btn37x1.Visible = false;
                btn38x1.Visible = false;
                btn39x1.Visible = false;
                btn40x1.Visible = false;
                label1.TabIndex = 1;
                label1.Text = "This Tile is the Start tile or Go tile.\r\nWhen a player lands on this tile, \r\n This player will receive 200php ";
            }
            else if (comboBox1.Text == "Go to Jail Tile")
            {
                btn1x1.Visible = false;
                btn2x1.Visible = false;
                btn3x1.Visible = false;
                btn4x1.Visible = false;
                btn5x1.Visible = false;
                btn6x1.Visible = false;
                btn7x1.Visible = false;
                btn8x1.Visible = false;
                btn9x1.Visible = false;
                btn10x1.Visible = false;
                btn11x1.Visible = false;
                btn12x1.Visible = false;
                btn13x1.Visible = false;
                btn14x1.Visible = false;
                btn15x1.Visible = false;
                btn16x1.Visible = false;
                btn17x1.Visible = false;
                btn18x1.Visible = false;
                btn19x1.Visible = false;
                btn20x1.Visible = false;
                btn21x1.Visible = false;
                btn22x1.Visible = false;
                btn23x1.Visible = false;
                btn24x1.Visible = false;
                btn25x1.Visible = false;
                btn26x1.Visible = false;
                btn27x1.Visible = false;
                btn28x1.Visible = false;
                btn29x1.Visible = false;
                btn30x1.Visible = false;
                btn31x1.Visible = true;
                btn32x1.Visible = false;
                btn33x1.Visible = false;
                btn34x1.Visible = false;
                btn35x1.Visible = false;
                btn36x1.Visible = false;
                btn37x1.Visible = false;
                btn38x1.Visible = false;
                btn39x1.Visible = false;
                btn40x1.Visible = false;
                label1.TabIndex = 1;
                label1.Text = "When a player lands on this tile, \r\n This player will be sent to Jail ";
            } 
            
            else if(comboBox1.Text=="Jail Tile"){
                btn1x1.Visible = false;
                btn2x1.Visible = false;
                btn3x1.Visible = false;
                btn4x1.Visible = false;
                btn5x1.Visible = false;
                btn6x1.Visible = false;
                btn7x1.Visible = false;
                btn8x1.Visible = false;
                btn9x1.Visible = false;
                btn10x1.Visible = false;
                btn11x1.Visible = true;
                btn12x1.Visible = false;
                btn13x1.Visible = false;
                btn14x1.Visible = false;
                btn15x1.Visible = false;
                btn16x1.Visible = false;
                btn17x1.Visible = false;
                btn18x1.Visible = false;
                btn19x1.Visible = false;
                btn20x1.Visible = false;
                btn21x1.Visible = false;
                btn22x1.Visible = false;
                btn23x1.Visible = false;
                btn24x1.Visible = false;
                btn25x1.Visible = false;
                btn26x1.Visible = false;
                btn27x1.Visible = false;
                btn28x1.Visible = false;
                btn29x1.Visible = false;
                btn30x1.Visible = false;
                btn31x1.Visible = false;
                btn32x1.Visible = false;
                btn33x1.Visible = false;
                btn34x1.Visible = false;
                btn35x1.Visible = false;
                btn36x1.Visible = false;
                btn37x1.Visible = false;
                btn38x1.Visible = false;
                btn39x1.Visible = false;
                btn40x1.Visible = false;
                label1.TabIndex = 10;
                label1.Text = "Holds players who met the condition to go jail or visit,\r\nplayers will be held in this tile until the conditions are met. \r\n \r\nBail: 50php \r\nCondition: Get 2 doubles on 2 turns to get out \r\nor for every even number of turns to bail";
            }

            else if (comboBox1.Text == "Eastern School")
            {
                btn1x1.Visible = false;
                btn2x1.Visible = true;
                btn3x1.Visible = false;
                btn4x1.Visible = false;
                btn5x1.Visible = false;
                btn6x1.Visible = false;
                btn7x1.Visible = false;
                btn8x1.Visible = false;
                btn9x1.Visible = false;
                btn10x1.Visible = false;
                btn11x1.Visible = false;
                btn12x1.Visible = false;
                btn13x1.Visible = false;
                btn14x1.Visible = false;
                btn15x1.Visible = false;
                btn16x1.Visible = false;
                btn17x1.Visible = false;
                btn18x1.Visible = false;
                btn19x1.Visible = false;
                btn20x1.Visible = false;
                btn21x1.Visible = false;
                btn22x1.Visible = false;
                btn23x1.Visible = false;
                btn24x1.Visible = false;
                btn25x1.Visible = false;
                btn26x1.Visible = false;
                btn27x1.Visible = false;
                btn28x1.Visible = false;
                btn29x1.Visible = false;
                btn30x1.Visible = false;
                btn31x1.Visible = false;
                btn32x1.Visible = false;
                btn33x1.Visible = false;
                btn34x1.Visible = false;
                btn35x1.Visible = false;
                btn36x1.Visible = false;
                btn37x1.Visible = false;
                btn38x1.Visible = false;
                btn39x1.Visible = false;
                btn40x1.Visible = false;
                label1.TabIndex = 10;
                label1.Text = "Price: 60php \r\nRent: 2php \r\nBanker's Rent: 4php\r\nUpgrade: 50php\r\n1 School: 10php \r\n2 Schools: 30php\r\nSingle Building: 250php";
            }


            else if (comboBox1.Text == "Western School")
            {
                btn1x1.Visible = false;
                btn2x1.Visible = false;
                btn3x1.Visible = false;
                btn4x1.Visible = true;
                btn5x1.Visible = false;
                btn6x1.Visible = false;
                btn7x1.Visible = false;
                btn8x1.Visible = false;
                btn9x1.Visible = false;
                btn10x1.Visible = false;
                btn11x1.Visible = false;
                btn12x1.Visible = false;
                btn13x1.Visible = false;
                btn14x1.Visible = false;
                btn15x1.Visible = false;
                btn16x1.Visible = false;
                btn17x1.Visible = false;
                btn18x1.Visible = false;
                btn19x1.Visible = false;
                btn20x1.Visible = false;
                btn21x1.Visible = false;
                btn22x1.Visible = false;
                btn23x1.Visible = false;
                btn24x1.Visible = false;
                btn25x1.Visible = false;
                btn26x1.Visible = false;
                btn27x1.Visible = false;
                btn28x1.Visible = false;
                btn29x1.Visible = false;
                btn30x1.Visible = false;
                btn31x1.Visible = false;
                btn32x1.Visible = false;
                btn33x1.Visible = false;
                btn34x1.Visible = false;
                btn35x1.Visible = false;
                btn36x1.Visible = false;
                btn37x1.Visible = false;
                btn38x1.Visible = false;
                btn39x1.Visible = false;
                btn40x1.Visible = false;
                label1.TabIndex = 10;
                label1.Text = "Price: 60php \r\nRent: 2php \r\nBanker's Rent: 4php\r\nUpgrade: 50php\r\n1 School: 10php \r\n2 Schools: 30php\r\nSingle Building: 250php";
            }

            else if (comboBox1.Text == "Formation Fee ")
            {
                btn1x1.Visible = false;
                btn2x1.Visible = false;
                btn3x1.Visible = false;
                btn4x1.Visible = false;
                btn5x1.Visible = true;
                btn6x1.Visible = false;
                btn7x1.Visible = false;
                btn8x1.Visible = false;
                btn9x1.Visible = false;
                btn10x1.Visible = false;
                btn11x1.Visible = false;
                btn12x1.Visible = false;
                btn13x1.Visible = false;
                btn14x1.Visible = false;
                btn15x1.Visible = false;
                btn16x1.Visible = false;
                btn17x1.Visible = false;
                btn18x1.Visible = false;
                btn19x1.Visible = false;
                btn20x1.Visible = false;
                btn21x1.Visible = false;
                btn22x1.Visible = false;
                btn23x1.Visible = false;
                btn24x1.Visible = false;
                btn25x1.Visible = false;
                btn26x1.Visible = false;
                btn27x1.Visible = false;
                btn28x1.Visible = false;
                btn29x1.Visible = false;
                btn30x1.Visible = false;
                btn31x1.Visible = false;
                btn32x1.Visible = false;
                btn33x1.Visible = false;
                btn34x1.Visible = false;
                btn35x1.Visible = false;
                btn36x1.Visible = false;
                btn37x1.Visible = false;
                btn38x1.Visible = false;
                btn39x1.Visible = true;
                btn40x1.Visible = false;
                label1.TabIndex = 10;
                label1.Text = "When a player lands on this tile,\r\nThe player is obliged to pay 200php\r\nfor the formation fee";
            }
            else if (comboBox1.Text == "Transportation Stations ")
            {
                btn1x1.Visible = false;
                btn2x1.Visible = false;
                btn3x1.Visible = false;
                btn4x1.Visible = false;
                btn5x1.Visible = false;
                btn6x1.Visible = true;
                btn7x1.Visible = false;
                btn8x1.Visible = false;
                btn9x1.Visible = false;
                btn10x1.Visible = false;
                btn11x1.Visible = false;
                btn12x1.Visible = false;
                btn13x1.Visible = false;
                btn14x1.Visible = false;
                btn15x1.Visible = false;
                btn16x1.Visible = true;
                btn17x1.Visible = false;
                btn18x1.Visible = false;
                btn19x1.Visible = false;
                btn20x1.Visible = false;
                btn21x1.Visible = false;
                btn22x1.Visible = false;
                btn23x1.Visible = false;
                btn24x1.Visible = false;
                btn25x1.Visible = false;
                btn26x1.Visible = true;
                btn27x1.Visible = false;
                btn28x1.Visible = false;
                btn29x1.Visible = false;
                btn30x1.Visible = false;
                btn31x1.Visible = false;
                btn32x1.Visible = false;
                btn33x1.Visible = false;
                btn34x1.Visible = false;
                btn35x1.Visible = false;
                btn36x1.Visible = true;
                btn37x1.Visible = false;
                btn38x1.Visible = false;
                btn39x1.Visible = false;
                btn40x1.Visible = false;
                label1.TabIndex = 10;
                label1.Text = "Price: 150php \r\nRent: 1x the number of Dice times the price of Station\r\nIf 2 owned 2x the number of Dice times the price of Station\r\nIf 3 owned 3x the number of Dice times the price of Station\r\nIf 4 owned 4x the number of Dice times the price of Station";
            }


            else if (comboBox1.Text == "Visayas High-School ")
            {
                btn1x1.Visible = false;
                btn2x1.Visible = false;
                btn3x1.Visible = false;
                btn4x1.Visible = false;
                btn5x1.Visible = false;
                btn6x1.Visible = false;
                btn7x1.Visible = true;
                btn8x1.Visible = false;
                btn9x1.Visible = false;
                btn10x1.Visible = false;
                btn11x1.Visible = false;
                btn12x1.Visible = false;
                btn13x1.Visible = false;
                btn14x1.Visible = false;
                btn15x1.Visible = false;
                btn16x1.Visible = false;
                btn17x1.Visible = false;
                btn18x1.Visible = false;
                btn19x1.Visible = false;
                btn20x1.Visible = false;
                btn21x1.Visible = false;
                btn22x1.Visible = false;
                btn23x1.Visible = false;
                btn24x1.Visible = false;
                btn25x1.Visible = false;
                btn26x1.Visible = false;
                btn27x1.Visible = false;
                btn28x1.Visible = false;
                btn29x1.Visible = false;
                btn30x1.Visible = false;
                btn31x1.Visible = false;
                btn32x1.Visible = false;
                btn33x1.Visible = false;
                btn34x1.Visible = false;
                btn35x1.Visible = false;
                btn36x1.Visible = false;
                btn37x1.Visible = false;
                btn38x1.Visible = false;
                btn39x1.Visible = false;
                btn40x1.Visible = false;
                label1.TabIndex = 10;
                label1.Text = "Price: 100php \r\nRent: 6php \r\nBanker's Rent: 12php\r\nUpgrade: 50php\r\n1 School: 30php \r\n2 Schools: 90php\r\n3 Schools: 270php\r\nIndustrial Building: 550php";
            }

            else if (comboBox1.Text == "Southern School ")
            {
                btn1x1.Visible = false;
                btn2x1.Visible = false;
                btn3x1.Visible = false;
                btn4x1.Visible = false;
                btn5x1.Visible = false;
                btn6x1.Visible = false;
                btn7x1.Visible = false;
                btn8x1.Visible = false;
                btn9x1.Visible = true;
                btn10x1.Visible = false;
                btn11x1.Visible = false;
                btn12x1.Visible = false;
                btn13x1.Visible = false;
                btn14x1.Visible = false;
                btn15x1.Visible = false;
                btn16x1.Visible = false;
                btn17x1.Visible = false;
                btn18x1.Visible = false;
                btn19x1.Visible = false;
                btn20x1.Visible = false;
                btn21x1.Visible = false;
                btn22x1.Visible = false;
                btn23x1.Visible = false;
                btn24x1.Visible = false;
                btn25x1.Visible = false;
                btn26x1.Visible = false;
                btn27x1.Visible = false;
                btn28x1.Visible = false;
                btn29x1.Visible = false;
                btn30x1.Visible = false;
                btn31x1.Visible = false;
                btn32x1.Visible = false;
                btn33x1.Visible = false;
                btn34x1.Visible = false;
                btn35x1.Visible = false;
                btn36x1.Visible = false;
                btn37x1.Visible = false;
                btn38x1.Visible = false;
                btn39x1.Visible = false;
                btn40x1.Visible = false;
                label1.TabIndex = 10;
                label1.Text = "Price: 100php \r\nRent: 6php \r\nBanker's Rent: 12php\r\nUpgrade: 50php\r\n1 School: 30php \r\n2 Schools: 90php\r\n3 Schools: 270php\r\nIndustrial Building: 550php";
            }

            else if (comboBox1.Text == "National University")
            {
                btn1x1.Visible = false;
                btn2x1.Visible = false;
                btn3x1.Visible = false;
                btn4x1.Visible = false;
                btn5x1.Visible = false;
                btn6x1.Visible = false;
                btn7x1.Visible = false;
                btn8x1.Visible = false;
                btn9x1.Visible = false;
                btn10x1.Visible = true;
                btn11x1.Visible = false;
                btn12x1.Visible = false;
                btn13x1.Visible = false;
                btn14x1.Visible = false;
                btn15x1.Visible = false;
                btn16x1.Visible = false;
                btn17x1.Visible = false;
                btn18x1.Visible = false;
                btn19x1.Visible = false;
                btn20x1.Visible = false;
                btn21x1.Visible = false;
                btn22x1.Visible = false;
                btn23x1.Visible = false;
                btn24x1.Visible = false;
                btn25x1.Visible = false;
                btn26x1.Visible = false;
                btn27x1.Visible = false;
                btn28x1.Visible = false;
                btn29x1.Visible = false;
                btn30x1.Visible = false;
                btn31x1.Visible = false;
                btn32x1.Visible = false;
                btn33x1.Visible = false;
                btn34x1.Visible = false;
                btn35x1.Visible = false;
                btn36x1.Visible = false;
                btn37x1.Visible = false;
                btn38x1.Visible = false;
                btn39x1.Visible = false;
                btn40x1.Visible = false;
                label1.TabIndex = 10;
                label1.Text = "Price: 120php \r\nRent: 6php \r\nBanker's Rent: 12php\r\nUpgrade: 50php\r\n1 School: 30php \r\n2 Schools: 90php\r\n3 Schools: 270php\r\nIndustrial Building: 550php";

            }
            else if (comboBox1.Text == "West Market")
            {
                btn1x1.Visible = false;
                btn2x1.Visible = false;
                btn3x1.Visible = false;
                btn4x1.Visible = false;
                btn5x1.Visible = false;
                btn6x1.Visible = false;
                btn7x1.Visible = false;
                btn8x1.Visible = false;
                btn9x1.Visible = false;
                btn10x1.Visible = false;
                btn11x1.Visible = false;
                btn12x1.Visible = true;
                btn13x1.Visible = false;
                btn14x1.Visible = false;
                btn15x1.Visible = false;
                btn16x1.Visible = false;
                btn17x1.Visible = false;
                btn18x1.Visible = false;
                btn19x1.Visible = false;
                btn20x1.Visible = false;
                btn21x1.Visible = false;
                btn22x1.Visible = false;
                btn23x1.Visible = false;
                btn24x1.Visible = false;
                btn25x1.Visible = false;
                btn26x1.Visible = false;
                btn27x1.Visible = false;
                btn28x1.Visible = false;
                btn29x1.Visible = false;
                btn30x1.Visible = false;
                btn31x1.Visible = false;
                btn32x1.Visible = false;
                btn33x1.Visible = false;
                btn34x1.Visible = false;
                btn35x1.Visible = false;
                btn36x1.Visible = false;
                btn37x1.Visible = false;
                btn38x1.Visible = false;
                btn39x1.Visible = false;
                btn40x1.Visible = false;
                label1.TabIndex = 10;
                label1.Text = "Price: 140php \r\nRent: 12php \r\nBanker's Rent: 24php\r\nUpgrade: 100php\r\n1 Market: 60php \r\n2 Markets: 180php\r\n3 Markets: 500php\r\nCommercial Property: 900php";
            }


            else if (comboBox1.Text == "Night Market")
            {
                btn1x1.Visible = false;
                btn2x1.Visible = false;
                btn3x1.Visible = false;
                btn4x1.Visible = false;
                btn5x1.Visible = false;
                btn6x1.Visible = false;
                btn7x1.Visible = false;
                btn8x1.Visible = false;
                btn9x1.Visible = false;
                btn10x1.Visible = false;
                btn11x1.Visible = false;
                btn12x1.Visible = false;
                btn13x1.Visible = false;
                btn14x1.Visible = true;
                btn15x1.Visible = false;
                btn16x1.Visible = false;
                btn17x1.Visible = false;
                btn18x1.Visible = false;
                btn19x1.Visible = false;
                btn20x1.Visible = false;
                btn21x1.Visible = false;
                btn22x1.Visible = false;
                btn23x1.Visible = false;
                btn24x1.Visible = false;
                btn25x1.Visible = false;
                btn26x1.Visible = false;
                btn27x1.Visible = false;
                btn28x1.Visible = false;
                btn29x1.Visible = false;
                btn30x1.Visible = false;
                btn31x1.Visible = false;
                btn32x1.Visible = false;
                btn33x1.Visible = false;
                btn34x1.Visible = false;
                btn35x1.Visible = false;
                btn36x1.Visible = false;
                btn37x1.Visible = false;
                btn38x1.Visible = false;
                btn39x1.Visible = false;
                btn40x1.Visible = false;
                label1.TabIndex = 10;
                label1.Text = "Price: 140php \r\nRent: 12php \r\nBanker's Rent: 24php\r\nUpgrade: 100php\r\n1 Market: 60php \r\n2 Markets: 180php\r\n3 Markets: 500php\r\nCommercial Property: 900php";
            }

            else if (comboBox1.Text == "Day Market")
            {
                btn1x1.Visible = false;
                btn2x1.Visible = false;
                btn3x1.Visible = false;
                btn4x1.Visible = false;
                btn5x1.Visible = false;
                btn6x1.Visible = false;
                btn7x1.Visible = false;
                btn8x1.Visible = false;
                btn9x1.Visible = false;
                btn10x1.Visible = false;
                btn11x1.Visible = false;
                btn12x1.Visible = false;
                btn13x1.Visible = false;
                btn14x1.Visible = false;
                btn15x1.Visible = true;
                btn16x1.Visible = false;
                btn17x1.Visible = false;
                btn18x1.Visible = false;
                btn19x1.Visible = false;
                btn20x1.Visible = false;
                btn21x1.Visible = false;
                btn22x1.Visible = false;
                btn23x1.Visible = false;
                btn24x1.Visible = false;
                btn25x1.Visible = false;
                btn26x1.Visible = false;
                btn27x1.Visible = false;
                btn28x1.Visible = false;
                btn29x1.Visible = false;
                btn30x1.Visible = false;
                btn31x1.Visible = false;
                btn32x1.Visible = false;
                btn33x1.Visible = false;
                btn34x1.Visible = false;
                btn35x1.Visible = false;
                btn36x1.Visible = false;
                btn37x1.Visible = false;
                btn38x1.Visible = false;
                btn39x1.Visible = false;
                btn40x1.Visible = false;
                label1.TabIndex = 10;
                label1.Text = "Price: 140php \r\nRent: 12php \r\nBanker's Rent: 24php\r\nUpgrade: 100php\r\n1 Market: 60php \r\n2 Markets: 180php\r\n3 Markets: 500php\r\nCommercial Property: 900php";
            }

            else if (comboBox1.Text == "Star Market")
            {
                btn1x1.Visible = false;
                btn2x1.Visible = false;
                btn3x1.Visible = false;
                btn4x1.Visible = false;
                btn5x1.Visible = false;
                btn6x1.Visible = false;
                btn7x1.Visible = false;
                btn8x1.Visible = false;
                btn9x1.Visible = false;
                btn10x1.Visible = false;
                btn11x1.Visible = false;
                btn12x1.Visible = false;
                btn13x1.Visible = false;
                btn14x1.Visible = false;
                btn15x1.Visible = false;
                btn16x1.Visible = false;
                btn17x1.Visible = true;
                btn18x1.Visible = false;
                btn19x1.Visible = false;
                btn20x1.Visible = false;
                btn21x1.Visible = false;
                btn22x1.Visible = false;
                btn23x1.Visible = false;
                btn24x1.Visible = false;
                btn25x1.Visible = false;
                btn26x1.Visible = false;
                btn27x1.Visible = false;
                btn28x1.Visible = false;
                btn29x1.Visible = false;
                btn30x1.Visible = false;
                btn31x1.Visible = false;
                btn32x1.Visible = false;
                btn33x1.Visible = false;
                btn34x1.Visible = false;
                btn35x1.Visible = false;
                btn36x1.Visible = false;
                btn37x1.Visible = false;
                btn38x1.Visible = false;
                btn39x1.Visible = false;
                btn40x1.Visible = false;
                label1.TabIndex = 10;
                label1.Text = "Price: 180php \r\nRent: 14php \r\nBanker's Rent: 28php\r\nUpgrade: 100php\r\n1 Market: 70php \r\n2 Markets: 200php\r\n3 Markets: 550php\r\nCommercial Property: 950php";
            }

            else if (comboBox1.Text == "Moon Market")
            {
                btn1x1.Visible = false;
                btn2x1.Visible = false;
                btn3x1.Visible = false;
                btn4x1.Visible = false;
                btn5x1.Visible = false;
                btn6x1.Visible = false;
                btn7x1.Visible = false;
                btn8x1.Visible = false;
                btn9x1.Visible = false;
                btn10x1.Visible = false;
                btn11x1.Visible = false;
                btn12x1.Visible = false;
                btn13x1.Visible = false;
                btn14x1.Visible = false;
                btn15x1.Visible = false;
                btn16x1.Visible = false;
                btn17x1.Visible = false;
                btn18x1.Visible = false;
                btn19x1.Visible = true;
                btn20x1.Visible = false;
                btn21x1.Visible = false;
                btn22x1.Visible = false;
                btn23x1.Visible = false;
                btn24x1.Visible = false;
                btn25x1.Visible = false;
                btn26x1.Visible = false;
                btn27x1.Visible = false;
                btn28x1.Visible = false;
                btn29x1.Visible = false;
                btn30x1.Visible = false;
                btn31x1.Visible = false;
                btn32x1.Visible = false;
                btn33x1.Visible = false;
                btn34x1.Visible = false;
                btn35x1.Visible = false;
                btn36x1.Visible = false;
                btn37x1.Visible = false;
                btn38x1.Visible = false;
                btn39x1.Visible = false;
                btn40x1.Visible = false;
                label1.TabIndex = 10;
                label1.Text = "Price: 180php \r\nRent: 14php \r\nBanker's Rent: 28php\r\nUpgrade: 100php\r\n1 Market: 70php \r\n2 Markets: 200php\r\n3 Markets: 550php\r\nCommercial Property: 950php";
            }

            else if (comboBox1.Text == "Mega Market ")
            {
                btn1x1.Visible = false;
                btn2x1.Visible = false;
                btn3x1.Visible = false;
                btn4x1.Visible = false;
                btn5x1.Visible = false;
                btn6x1.Visible = false;
                btn7x1.Visible = false;
                btn8x1.Visible = false;
                btn9x1.Visible = false;
                btn10x1.Visible = false;
                btn11x1.Visible = false;
                btn12x1.Visible = false;
                btn13x1.Visible = false;
                btn14x1.Visible = false;
                btn15x1.Visible = false;
                btn16x1.Visible = false;
                btn17x1.Visible = false;
                btn18x1.Visible = false;
                btn19x1.Visible = false;
                btn20x1.Visible = true;
                btn21x1.Visible = false;
                btn22x1.Visible = false;
                btn23x1.Visible = false;
                btn24x1.Visible = false;
                btn25x1.Visible = false;
                btn26x1.Visible = false;
                btn27x1.Visible = false;
                btn28x1.Visible = false;
                btn29x1.Visible = false;
                btn30x1.Visible = false;
                btn31x1.Visible = false;
                btn32x1.Visible = false;
                btn33x1.Visible = false;
                btn34x1.Visible = false;
                btn35x1.Visible = false;
                btn36x1.Visible = false;
                btn37x1.Visible = false;
                btn38x1.Visible = false;
                btn39x1.Visible = false;
                btn40x1.Visible = false;
                label1.TabIndex = 10;
                label1.Text = "Price: 180php \r\nRent: 16php \r\nBanker's Rent: 32php\r\nUpgrade: 100php\r\n1 Market: 70php \r\n2 Markets: 200php\r\n3 Markets: 550php\r\nCommercial Property: 950php";
            }


            else if (comboBox1.Text == "Visaya Hospital ")
            {
                btn1x1.Visible = false;
                btn2x1.Visible = false;
                btn3x1.Visible = false;
                btn4x1.Visible = false;
                btn5x1.Visible = false;
                btn6x1.Visible = false;
                btn7x1.Visible = false;
                btn8x1.Visible = false;
                btn9x1.Visible = false;
                btn10x1.Visible = false;
                btn11x1.Visible = false;
                btn12x1.Visible = false;
                btn13x1.Visible = false;
                btn14x1.Visible = false;
                btn15x1.Visible = false;
                btn16x1.Visible = false;
                btn17x1.Visible = false;
                btn18x1.Visible = false;
                btn19x1.Visible = false;
                btn20x1.Visible = false;
                btn21x1.Visible = false;
                btn22x1.Visible = true;
                btn23x1.Visible = false;
                btn24x1.Visible = false;
                btn25x1.Visible = false;
                btn26x1.Visible = false;
                btn27x1.Visible = false;
                btn28x1.Visible = false;
                btn29x1.Visible = false;
                btn30x1.Visible = false;
                btn31x1.Visible = false;
                btn32x1.Visible = false;
                btn33x1.Visible = false;
                btn34x1.Visible = false;
                btn35x1.Visible = false;
                btn36x1.Visible = false;
                btn37x1.Visible = false;
                btn38x1.Visible = false;
                btn39x1.Visible = false;
                btn40x1.Visible = false;
                label1.TabIndex = 10;
                label1.Text = "Price: 220php \r\nRent: 18php \r\nBanker's Rent: 36php\r\nUpgrade: 100php\r\n1 Hospital: 70php \r\n2 Hopitals: 200php\r\n3 Hospitals: 550php\r\nTower: 1050php";
            }


            else if (comboBox1.Text == "Hoberts Hospital")
            {
                btn1x1.Visible = false;
                btn2x1.Visible = false;
                btn3x1.Visible = false;
                btn4x1.Visible = false;
                btn5x1.Visible = false;
                btn6x1.Visible = false;
                btn7x1.Visible = false;
                btn8x1.Visible = false;
                btn9x1.Visible = false;
                btn10x1.Visible = false;
                btn11x1.Visible = false;
                btn12x1.Visible = false;
                btn13x1.Visible = false;
                btn14x1.Visible = false;
                btn15x1.Visible = false;
                btn16x1.Visible = false;
                btn17x1.Visible = false;
                btn18x1.Visible = false;
                btn19x1.Visible = false;
                btn20x1.Visible = false;
                btn21x1.Visible = false;
                btn22x1.Visible = false;
                btn23x1.Visible = false;
                btn24x1.Visible = true;
                btn25x1.Visible = false;
                btn26x1.Visible = false;
                btn27x1.Visible = false;
                btn28x1.Visible = false;
                btn29x1.Visible = false;
                btn30x1.Visible = false;
                btn31x1.Visible = false;
                btn32x1.Visible = false;
                btn33x1.Visible = false;
                btn34x1.Visible = false;
                btn35x1.Visible = false;
                btn36x1.Visible = false;
                btn37x1.Visible = false;
                btn38x1.Visible = false;
                btn39x1.Visible = false;
                btn40x1.Visible = false;
                label1.TabIndex = 10;
                label1.Text = "Price: 220php \r\nRent: 18php \r\nBanker's Rent: 36php\r\nUpgrade: 100php\r\n1 Hospital: 70php \r\n2 Hopitals: 200php\r\n3 Hospitals: 550php\r\nTower: 1050php";
            }


            else if (comboBox1.Text == "Hearts Hospital")
            {
                btn1x1.Visible = false;
                btn2x1.Visible = false;
                btn3x1.Visible = false;
                btn4x1.Visible = false;
                btn5x1.Visible = false;
                btn6x1.Visible = false;
                btn7x1.Visible = false;
                btn8x1.Visible = false;
                btn9x1.Visible = false;
                btn10x1.Visible = false;
                btn11x1.Visible = false;
                btn12x1.Visible = false;
                btn13x1.Visible = false;
                btn14x1.Visible = false;
                btn15x1.Visible = false;
                btn16x1.Visible = false;
                btn17x1.Visible = false;
                btn18x1.Visible = false;
                btn19x1.Visible = false;
                btn20x1.Visible = false;
                btn21x1.Visible = false;
                btn22x1.Visible = false;
                btn23x1.Visible = false;
                btn24x1.Visible = false;
                btn25x1.Visible = true;
                btn26x1.Visible = false;
                btn27x1.Visible = false;
                btn28x1.Visible = false;
                btn29x1.Visible = false;
                btn30x1.Visible = false;
                btn31x1.Visible = false;
                btn32x1.Visible = false;
                btn33x1.Visible = false;
                btn34x1.Visible = false;
                btn35x1.Visible = false;
                btn36x1.Visible = false;
                btn37x1.Visible = false;
                btn38x1.Visible = false;
                btn39x1.Visible = false;
                btn40x1.Visible = false;
                label1.TabIndex = 10;
                label1.Text = "Price: 240php \r\nRent: 20php \r\nBanker's Rent: 36php\r\nUpgrade: 100php\r\n1 Hospital: 70php \r\n2 Hopitals: 200php\r\n3 Hospitals: 550php\r\nTower: 1050php";
            }

            else if (comboBox1.Text == "Interns Hospital ")
            {
                btn1x1.Visible = false;
                btn2x1.Visible = false;
                btn3x1.Visible = false;
                btn4x1.Visible = false;
                btn5x1.Visible = false;
                btn6x1.Visible = false;
                btn7x1.Visible = false;
                btn8x1.Visible = false;
                btn9x1.Visible = false;
                btn10x1.Visible = false;
                btn11x1.Visible = false;
                btn12x1.Visible = false;
                btn13x1.Visible = false;
                btn14x1.Visible = false;
                btn15x1.Visible = false;
                btn16x1.Visible = false;
                btn17x1.Visible = false;
                btn18x1.Visible = false;
                btn19x1.Visible = false;
                btn20x1.Visible = false;
                btn21x1.Visible = false;
                btn22x1.Visible = false;
                btn23x1.Visible = false;
                btn24x1.Visible = false;
                btn25x1.Visible = false;
                btn26x1.Visible = false;
                btn27x1.Visible = true;
                btn28x1.Visible = false;
                btn29x1.Visible = false;
                btn30x1.Visible = false;
                btn31x1.Visible = false;
                btn32x1.Visible = false;
                btn33x1.Visible = false;
                btn34x1.Visible = false;
                btn35x1.Visible = false;
                btn36x1.Visible = false;
                btn37x1.Visible = false;
                btn38x1.Visible = false;
                btn39x1.Visible = false;
                btn40x1.Visible = false;
                label1.TabIndex = 10;
                label1.Text = "Price: 260php \r\nRent: 22php \r\nBanker's Rent: 44php\r\nUpgrade: 150php\r\n1 Hospital: 110php \r\n2 Hopitals: 330php\r\n3 Hospitals: 800php\r\nTower: 1150php";
            }

            else if (comboBox1.Text == "National Health Hospital")
            {
                btn1x1.Visible = false;
                btn2x1.Visible = false;
                btn3x1.Visible = false;
                btn4x1.Visible = false;
                btn5x1.Visible = false;
                btn6x1.Visible = false;
                btn7x1.Visible = false;
                btn8x1.Visible = false;
                btn9x1.Visible = false;
                btn10x1.Visible = false;
                btn11x1.Visible = false;
                btn12x1.Visible = false;
                btn13x1.Visible = false;
                btn14x1.Visible = false;
                btn15x1.Visible = false;
                btn16x1.Visible = false;
                btn17x1.Visible = false;
                btn18x1.Visible = false;
                btn19x1.Visible = false;
                btn20x1.Visible = false;
                btn21x1.Visible = false;
                btn22x1.Visible = false;
                btn23x1.Visible = false;
                btn24x1.Visible = false;
                btn25x1.Visible = false;
                btn26x1.Visible = false;
                btn27x1.Visible = false;
                btn28x1.Visible = true;
                btn29x1.Visible = false;
                btn30x1.Visible = false;
                btn31x1.Visible = false;
                btn32x1.Visible = false;
                btn33x1.Visible = false;
                btn34x1.Visible = false;
                btn35x1.Visible = false;
                btn36x1.Visible = false;
                btn37x1.Visible = false;
                btn38x1.Visible = false;
                btn39x1.Visible = false;
                btn40x1.Visible = false;
                label1.TabIndex = 10;
                label1.Text = "Price: 260php \r\nRent: 22php \r\nBanker's Rent: 44php\r\nUpgrade: 150php\r\n1 Hospital: 110php \r\n2 Hopitals: 330php\r\n3 Hospitals: 800php\r\nTower: 1150php";
            }

            else if (comboBox1.Text == "Vetarans Hospital")
            {
                btn1x1.Visible = false;
                btn2x1.Visible = false;
                btn3x1.Visible = false;
                btn4x1.Visible = false;
                btn5x1.Visible = false;
                btn6x1.Visible = false;
                btn7x1.Visible = false;
                btn8x1.Visible = false;
                btn9x1.Visible = false;
                btn10x1.Visible = false;
                btn11x1.Visible = false;
                btn12x1.Visible = false;
                btn13x1.Visible = false;
                btn14x1.Visible = false;
                btn15x1.Visible = false;
                btn16x1.Visible = false;
                btn17x1.Visible = false;
                btn18x1.Visible = false;
                btn19x1.Visible = false;
                btn20x1.Visible = false;
                btn21x1.Visible = false;
                btn22x1.Visible = false;
                btn23x1.Visible = false;
                btn24x1.Visible = false;
                btn25x1.Visible = false;
                btn26x1.Visible = false;
                btn27x1.Visible = false;
                btn28x1.Visible = false;
                btn29x1.Visible = false;
                btn30x1.Visible = true;
                btn31x1.Visible = false;
                btn32x1.Visible = false;
                btn33x1.Visible = false;
                btn34x1.Visible = false;
                btn35x1.Visible = false;
                btn36x1.Visible = false;
                btn37x1.Visible = false;
                btn38x1.Visible = false;
                btn39x1.Visible = false;
                btn40x1.Visible = false;
                label1.TabIndex = 10;
                label1.Text = "Price: 280php \r\nRent: 24php \r\nBanker's Rent: 48php\r\nUpgrade: 150php\r\n1 Hospital: 110php \r\n2 Hopitals: 330php\r\n3 Hospitals: 800php\r\nTower: 1150php";
            }

            else if (comboBox1.Text == "Pearl Mall")
            {
                btn1x1.Visible = false;
                btn2x1.Visible = false;
                btn3x1.Visible = false;
                btn4x1.Visible = false;
                btn5x1.Visible = false;
                btn6x1.Visible = false;
                btn7x1.Visible = false;
                btn8x1.Visible = false;
                btn9x1.Visible = false;
                btn10x1.Visible = false;
                btn11x1.Visible = false;
                btn12x1.Visible = false;
                btn13x1.Visible = false;
                btn14x1.Visible = false;
                btn15x1.Visible = false;
                btn16x1.Visible = false;
                btn17x1.Visible = false;
                btn18x1.Visible = false;
                btn19x1.Visible = false;
                btn20x1.Visible = false;
                btn21x1.Visible = false;
                btn22x1.Visible = false;
                btn23x1.Visible = false;
                btn24x1.Visible = false;
                btn25x1.Visible = false;
                btn26x1.Visible = false;
                btn27x1.Visible = false;
                btn28x1.Visible = false;
                btn29x1.Visible = false;
                btn30x1.Visible = false;
                btn31x1.Visible = false;
                btn32x1.Visible = true;
                btn33x1.Visible = false;
                btn34x1.Visible = false;
                btn35x1.Visible = false;
                btn36x1.Visible = false;
                btn37x1.Visible = false;
                btn38x1.Visible = false;
                btn39x1.Visible = false;
                btn40x1.Visible = false;
                label1.TabIndex = 10;
                label1.Text = "Price: 300php \r\nRent: 26php \r\nBanker's Rent: 52php\r\nUpgrade: 200php\r\n1 Mall: 130php \r\n2 Malls: 390php\r\n3 Malls: 900php\r\nCommercial Tower: 1275php";
            }

            else if (comboBox1.Text == "Mega Mall")
            {
                btn1x1.Visible = false;
                btn2x1.Visible = false;
                btn3x1.Visible = false;
                btn4x1.Visible = false;
                btn5x1.Visible = false;
                btn6x1.Visible = false;
                btn7x1.Visible = false;
                btn8x1.Visible = false;
                btn9x1.Visible = false;
                btn10x1.Visible = false;
                btn11x1.Visible = false;
                btn12x1.Visible = false;
                btn13x1.Visible = false;
                btn14x1.Visible = false;
                btn15x1.Visible = false;
                btn16x1.Visible = false;
                btn17x1.Visible = false;
                btn18x1.Visible = false;
                btn19x1.Visible = false;
                btn20x1.Visible = false;
                btn21x1.Visible = false;
                btn22x1.Visible = false;
                btn23x1.Visible = false;
                btn24x1.Visible = false;
                btn25x1.Visible = false;
                btn26x1.Visible = false;
                btn27x1.Visible = false;
                btn28x1.Visible = false;
                btn29x1.Visible = false;
                btn30x1.Visible = false;
                btn31x1.Visible = false;
                btn32x1.Visible = false;
                btn33x1.Visible = true;
                btn34x1.Visible = false;
                btn35x1.Visible = false;
                btn36x1.Visible = false;
                btn37x1.Visible = false;
                btn38x1.Visible = false;
                btn39x1.Visible = false;
                btn40x1.Visible = false;
                label1.TabIndex = 10;
                label1.Text = "Price: 300php \r\nRent: 26php \r\nBanker's Rent: 52php\r\nUpgrade: 200php\r\n1 Mall: 130php \r\n2 Malls: 390php\r\n3 Malls: 900php\r\nCommercial Tower: 1275php";
            }

            else if (comboBox1.Text == "Artic Mall")
            {
                btn1x1.Visible = false;
                btn2x1.Visible = false;
                btn3x1.Visible = false;
                btn4x1.Visible = false;
                btn5x1.Visible = false;
                btn6x1.Visible = false;
                btn7x1.Visible = false;
                btn8x1.Visible = false;
                btn9x1.Visible = false;
                btn10x1.Visible = false;
                btn11x1.Visible = false;
                btn12x1.Visible = false;
                btn13x1.Visible = false;
                btn14x1.Visible = false;
                btn15x1.Visible = false;
                btn16x1.Visible = false;
                btn17x1.Visible = false;
                btn18x1.Visible = false;
                btn19x1.Visible = false;
                btn20x1.Visible = false;
                btn21x1.Visible = false;
                btn22x1.Visible = false;
                btn23x1.Visible = false;
                btn24x1.Visible = false;
                btn25x1.Visible = false;
                btn26x1.Visible = false;
                btn27x1.Visible = false;
                btn28x1.Visible = false;
                btn29x1.Visible = false;
                btn30x1.Visible = false;
                btn31x1.Visible = false;
                btn32x1.Visible = false;
                btn33x1.Visible = false;
                btn34x1.Visible = false;
                btn35x1.Visible = true;
                btn36x1.Visible = false;
                btn37x1.Visible = false;
                btn38x1.Visible = false;
                btn39x1.Visible = false;
                btn40x1.Visible = false;
                label1.TabIndex = 10;
                label1.Text = "Price: 320php \r\nRent: 28php \r\nBanker's Rent: 56php\r\nUpgrade: 200php\r\n1 Mall: 130php \r\n2 Malls: 390php\r\n3 Malls: 900php\r\nCommercial Tower: 1400php";
            }

            else if (comboBox1.Text == "Heavenly Mall")
            {
                btn1x1.Visible = false;
                btn2x1.Visible = false;
                btn3x1.Visible = false;
                btn4x1.Visible = false;
                btn5x1.Visible = false;
                btn6x1.Visible = false;
                btn7x1.Visible = false;
                btn8x1.Visible = false;
                btn9x1.Visible = false;
                btn10x1.Visible = false;
                btn11x1.Visible = false;
                btn12x1.Visible = false;
                btn13x1.Visible = false;
                btn14x1.Visible = false;
                btn15x1.Visible = false;
                btn16x1.Visible = false;
                btn17x1.Visible = false;
                btn18x1.Visible = false;
                btn19x1.Visible = false;
                btn20x1.Visible = false;
                btn21x1.Visible = false;
                btn22x1.Visible = false;
                btn23x1.Visible = false;
                btn24x1.Visible = false;
                btn25x1.Visible = false;
                btn26x1.Visible = false;
                btn27x1.Visible = false;
                btn28x1.Visible = false;
                btn29x1.Visible = false;
                btn30x1.Visible = false;
                btn31x1.Visible = false;
                btn32x1.Visible = false;
                btn33x1.Visible = false;
                btn34x1.Visible = false;
                btn35x1.Visible = false;
                btn36x1.Visible = false;
                btn37x1.Visible = false;
                btn38x1.Visible = true;
                btn39x1.Visible = false;
                btn40x1.Visible = false;
                label1.TabIndex = 10;
                label1.Text = "Price: 400php \r\nRent: 50php \r\nBanker's Rent: 56php\r\nUpgrade: 200php\r\n1 Mall: 170php \r\n2 Malls: 500php\r\nCommercial Tower: 2000php";
            }

            else if (comboBox1.Text == "Shangrila Mall")
            {
                btn1x1.Visible = false;
                btn2x1.Visible = false;
                btn3x1.Visible = false;
                btn4x1.Visible = false;
                btn5x1.Visible = false;
                btn6x1.Visible = false;
                btn7x1.Visible = false;
                btn8x1.Visible = false;
                btn9x1.Visible = false;
                btn10x1.Visible = false;
                btn11x1.Visible = false;
                btn12x1.Visible = false;
                btn13x1.Visible = false;
                btn14x1.Visible = false;
                btn15x1.Visible = false;
                btn16x1.Visible = false;
                btn17x1.Visible = false;
                btn18x1.Visible = false;
                btn19x1.Visible = false;
                btn20x1.Visible = false;
                btn21x1.Visible = false;
                btn22x1.Visible = false;
                btn23x1.Visible = false;
                btn24x1.Visible = false;
                btn25x1.Visible = false;
                btn26x1.Visible = false;
                btn27x1.Visible = false;
                btn28x1.Visible = false;
                btn29x1.Visible = false;
                btn30x1.Visible = false;
                btn31x1.Visible = false;
                btn32x1.Visible = false;
                btn33x1.Visible = false;
                btn34x1.Visible = false;
                btn35x1.Visible = false;
                btn36x1.Visible = false;
                btn37x1.Visible = false;
                btn38x1.Visible = false;
                btn39x1.Visible = false;
                btn40x1.Visible = true;
                label1.TabIndex = 10;
                label1.Text = "Price: 350php \r\nRent: 35php \r\nBanker's Rent: 56php\r\nUpgrade: 200php\r\n1 Mall: 170php \r\n2 Malls: 500php\r\nCommercial Tower: 1500php";
            }

            else if (comboBox1.Text == "Utility")
            {
                btn1x1.Visible = false;
                btn2x1.Visible = false;
                btn3x1.Visible = false;
                btn4x1.Visible = false;
                btn5x1.Visible = false;
                btn6x1.Visible = false;
                btn7x1.Visible = false;
                btn8x1.Visible = false;
                btn9x1.Visible = false;
                btn10x1.Visible = false;
                btn11x1.Visible = false;
                btn12x1.Visible = false;
                btn13x1.Visible = true;
                btn14x1.Visible = false;
                btn15x1.Visible = false;
                btn16x1.Visible = false;
                btn17x1.Visible = false;
                btn18x1.Visible = false;
                btn19x1.Visible = false;
                btn20x1.Visible = false;
                btn21x1.Visible = false;
                btn22x1.Visible = false;
                btn23x1.Visible = false;
                btn24x1.Visible = false;
                btn25x1.Visible = false;
                btn26x1.Visible = false;
                btn27x1.Visible = false;
                btn28x1.Visible = false;
                btn29x1.Visible = true;
                btn30x1.Visible = false;
                btn31x1.Visible = false;
                btn32x1.Visible = false;
                btn33x1.Visible = false;
                btn34x1.Visible = false;
                btn35x1.Visible = false;
                btn36x1.Visible = false;
                btn37x1.Visible = false;
                btn38x1.Visible = false;
                btn39x1.Visible = false;
                btn40x1.Visible = false;
                label1.TabIndex = 10;
                label1.Text = "Price: 150php \r\nRent: 2x the number of Dice times the price of Utility\r\nIf 2 owned 4x the number of Dice times the price of Utility";
            }

            else if (comboBox1.Text == "Wheel Of Power")
            {
                btn1x1.Visible = false;
                btn2x1.Visible = false;
                btn3x1.Visible = false;
                btn4x1.Visible = false;
                btn5x1.Visible = false;
                btn6x1.Visible = false;
                btn7x1.Visible = false;
                btn8x1.Visible = true;
                btn9x1.Visible = false;
                btn10x1.Visible = false;
                btn11x1.Visible = false;
                btn12x1.Visible = false;
                btn13x1.Visible = false;
                btn14x1.Visible = false;
                btn15x1.Visible = false;
                btn16x1.Visible = false;
                btn17x1.Visible = false;
                btn18x1.Visible = false;
                btn19x1.Visible = false;
                btn20x1.Visible = false;
                btn21x1.Visible = false;
                btn22x1.Visible = false;
                btn23x1.Visible = true;
                btn24x1.Visible = false;
                btn25x1.Visible = false;
                btn26x1.Visible = false;
                btn27x1.Visible = false;
                btn28x1.Visible = false;
                btn29x1.Visible = false;
                btn30x1.Visible = false;
                btn31x1.Visible = false;
                btn32x1.Visible = false;
                btn33x1.Visible = false;
                btn34x1.Visible = false;
                btn35x1.Visible = false;
                btn36x1.Visible = false;
                btn37x1.Visible = true;
                btn38x1.Visible = false;
                btn39x1.Visible = false;
                btn40x1.Visible = false;
                label1.TabIndex = 10;
                label1.Text = "If a player lands on this tile,\r\nThe player has the chance to get a power-up card.\r\n\r\nCard Infos:\r\n\r\nDemolish: This Card Demolishes Structure,\r\nIf conditions are met\r\n\r\nSurrender Property: This Card allows the user\r\nto return property to the banker,\r\nand gains money or refund.\r\n\r\nImmunity: This card prevents rents,demolish and tax\r\nfor only even number of turns. ";
            }
            
            else if (comboBox1.Text == "Community Cards")
            {
                btn1x1.Visible = false;
                btn2x1.Visible = false;
                btn3x1.Visible = true;
                btn4x1.Visible = false;
                btn5x1.Visible = false;
                btn6x1.Visible = false;
                btn7x1.Visible = false;
                btn8x1.Visible = false;
                btn9x1.Visible = false;
                btn10x1.Visible = false;
                btn11x1.Visible = false;
                btn12x1.Visible = false;
                btn13x1.Visible = false;
                btn14x1.Visible = false;
                btn15x1.Visible = false;
                btn16x1.Visible = false;
                btn17x1.Visible = false;
                btn18x1.Visible = true;
                btn19x1.Visible = false;
                btn20x1.Visible = false;
                btn21x1.Visible = false;
                btn22x1.Visible = false;
                btn23x1.Visible = false;
                btn24x1.Visible = false;
                btn25x1.Visible = false;
                btn26x1.Visible = false;
                btn27x1.Visible = false;
                btn28x1.Visible = false;
                btn29x1.Visible = false;
                btn30x1.Visible = false;
                btn31x1.Visible = false;
                btn32x1.Visible = false;
                btn33x1.Visible = true;
                btn34x1.Visible = false;
                btn35x1.Visible = false;
                btn36x1.Visible = false;
                btn37x1.Visible = false;
                btn38x1.Visible = false;
                btn39x1.Visible = false;
                btn40x1.Visible = false;
                label1.TabIndex = 10;
                label1.Text = "If a player lands on this tile,\r\nThe player has the chance to get Insurances or \r\nbe involve in activities(Mayor,School and Hospital).";
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Settings b = new Settings();
            b.Show();
            b.Focus();
            this.Close();
        }
    }
}
