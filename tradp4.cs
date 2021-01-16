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
    public partial class tradp4 : Form
    {
        #region variable for trading
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

        public static int p1 = 0;
        public static int p2 = 0;
        public static int p3 = 0;
        public static int p4 = 0;
        int quick = 0;
        int quick2 = 0;
        int quick3 = 0;
        int quick4 = 0;
        int p1trad = 0;
        int p2trad = 0;
        int p3trad = 0;
        int p4trad = 0;
        int turnsint = 0;

        public static int p1tradein1 = 0;
        public static int p2tradein2 = 0;
        public static int p3tradein3 = 0;
        public static int p4tradein4 = 0;

        int det = 0;

        public static int p1trade = 0;
        public static int p2trade = 0;
        public static int p3trade = 0;
        public static int p4trade = 0;
        public static int p1trd = 0;
        public static int p2trd = 0;
        public static int p3trd = 0;
        public static int p4trd = 0;

        public static int easternschooltr1 = 0;
        public static int westernschooltr1 = 0;
        public static int visayashighschooltr1 = 0;
        public static int southernschooltr1 = 0;
        public static int nationsschooltr1 = 0;
        public static int westmarkettr1 = 0;
        public static int nightmarkettr1 = 0;
        public static int daymarkettr1 = 0;
        public static int starmarkettr1 = 0;
        public static int moonmarkettr1 = 0;
        public static int megamarkettr1 = 0;
        public static int visayashospitaltr1 = 0;
        public static int hobertshospitaltr1 = 0;
        public static int heartshospitaltr1 = 0;
        public static int internshospitaltr1 = 0;
        public static int nationalhealthhospitaltr1 = 0;
        public static int veteranshospitaltr1 = 0;
        public static int pearlmalltr1 = 0;
        public static int megamalltr1 = 0;
        public static int articmalltr1 = 0;
        public static int heavenlymalltr1 = 0;
        public static int shangrillamalltr1 = 0;
        public static int utility1x1tr1 = 0;
        public static int utility1x2tr1 = 0;
        public static int transportation1x1tr1 = 0;
        public static int transportation1x2tr1 = 0;
        public static int transportation1x3tr1 = 0;
        public static int transportation1x4tr1 = 0;

        public static int easternschooltr2 = 0;
        public static int westernschooltr2 = 0;
        public static int visayashighschooltr2 = 0;
        public static int southernschooltr2 = 0;
        public static int nationsschooltr2 = 0;
        public static int westmarkettr2 = 0;
        public static int nightmarkettr2 = 0;
        public static int daymarkettr2 = 0;
        public static int starmarkettr2 = 0;
        public static int moonmarkettr2 = 0;
        public static int megamarkettr2 = 0;
        public static int visayashospitaltr2 = 0;
        public static int hobertshospitaltr2 = 0;
        public static int heartshospitaltr2 = 0;
        public static int internshospitaltr2 = 0;
        public static int nationalhealthhospitaltr2 = 0;
        public static int veteranshospitaltr2 = 0;
        public static int pearlmalltr2 = 0;
        public static int megamalltr2 = 0;
        public static int articmalltr2 = 0;
        public static int heavenlymalltr2 = 0;
        public static int shangrillamalltr2 = 0;
        public static int utility2x1tr2 = 0;
        public static int utility2x2tr2 = 0;
        public static int transportation2x1tr2 = 0;
        public static int transportation2x2tr2 = 0;
        public static int transportation2x3tr2 = 0;
        public static int transportation2x4tr2 = 0;

        public static int easternschooltr3 = 0;
        public static int westernschooltr3 = 0;
        public static int visayashighschooltr3 = 0;
        public static int southernschooltr3 = 0;
        public static int nationsschooltr3 = 0;
        public static int westmarkettr3 = 0;
        public static int nightmarkettr3 = 0;
        public static int daymarkettr3 = 0;
        public static int starmarkettr3 = 0;
        public static int moonmarkettr3 = 0;
        public static int megamarkettr3 = 0;
        public static int visayashospitaltr3 = 0;
        public static int hobertshospitaltr3 = 0;
        public static int heartshospitaltr3 = 0;
        public static int internshospitaltr3 = 0;
        public static int nationalhealthhospitaltr3 = 0;
        public static int veteranshospitaltr3 = 0;
        public static int pearlmalltr3 = 0;
        public static int megamalltr3 = 0;
        public static int articmalltr3 = 0;
        public static int heavenlymalltr3 = 0;
        public static int shangrillamalltr3 = 0;
        public static int utility3x1tr3 = 0;
        public static int utility3x2tr3 = 0;
        public static int transportation3x1tr3 = 0;
        public static int transportation3x2tr3 = 0;
        public static int transportation3x3tr3 = 0;
        public static int transportation3x4tr3 = 0;

        public static int easternschooltr4 = 0;
        public static int westernschooltr4 = 0;
        public static int visayashighschooltr4 = 0;
        public static int southernschooltr4 = 0;
        public static int nationsschooltr4 = 0;
        public static int westmarkettr4 = 0;
        public static int nightmarkettr4 = 0;
        public static int daymarkettr4 = 0;
        public static int starmarkettr4 = 0;
        public static int moonmarkettr4 = 0;
        public static int megamarkettr4 = 0;
        public static int visayashospitaltr4 = 0;
        public static int hobertshospitaltr4 = 0;
        public static int heartshospitaltr4 = 0;
        public static int internshospitaltr4 = 0;
        public static int nationalhealthhospitaltr4 = 0;
        public static int veteranshospitaltr4 = 0;
        public static int pearlmalltr4 = 0;
        public static int megamalltr4 = 0;
        public static int articmalltr4 = 0;
        public static int heavenlymalltr4 = 0;
        public static int shangrillamalltr4 = 0;
        public static int utility4x1tr4 = 0;
        public static int utility4x2tr4 = 0;
        public static int transportation4x1tr4 = 0;
        public static int transportation4x2tr4 = 0;
        public static int transportation4x3tr4 = 0;
        public static int transportation4x4tr4 = 0;

        public static int easternschooltrd1 = 0;
        public static int westernschooltrd1 = 0;
        public static int visayashighschooltrd1 = 0;
        public static int southernschooltrd1 = 0;
        public static int nationsschooltrd1 = 0;
        public static int westmarkettrd1 = 0;
        public static int nightmarkettrd1 = 0;
        public static int daymarkettrd1 = 0;
        public static int starmarkettrd1 = 0;
        public static int moonmarkettrd1 = 0;
        public static int megamarkettrd1 = 0;
        public static int visayashospitaltrd1 = 0;
        public static int hobertshospitaltrd1 = 0;
        public static int heartshospitaltrd1 = 0;
        public static int internshospitaltrd1 = 0;
        public static int nationalhealthhospitaltrd1 = 0;
        public static int veteranshospitaltrd1 = 0;
        public static int pearlmalltrd1 = 0;
        public static int megamalltrd1 = 0;
        public static int articmalltrd1 = 0;
        public static int heavenlymalltrd1 = 0;
        public static int shangrillamalltrd1 = 0;
        public static int utility1x1trd1 = 0;
        public static int utility1x2trd1 = 0;
        public static int transportation1x1trd1 = 0;
        public static int transportation1x2trd1 = 0;
        public static int transportation1x3trd1 = 0;
        public static int transportation1x4trd1 = 0;

        public static int easternschooltrd2 = 0;
        public static int westernschooltrd2 = 0;
        public static int visayashighschooltrd2 = 0;
        public static int southernschooltrd2 = 0;
        public static int nationsschooltrd2 = 0;
        public static int westmarkettrd2 = 0;
        public static int nightmarkettrd2 = 0;
        public static int daymarkettrd2 = 0;
        public static int starmarkettrd2 = 0;
        public static int moonmarkettrd2 = 0;
        public static int megamarkettrd2 = 0;
        public static int visayashospitaltrd2 = 0;
        public static int hobertshospitaltrd2 = 0;
        public static int heartshospitaltrd2 = 0;
        public static int internshospitaltrd2 = 0;
        public static int nationalhealthhospitaltrd2 = 0;
        public static int veteranshospitaltrd2 = 0;
        public static int pearlmalltrd2 = 0;
        public static int megamalltrd2 = 0;
        public static int articmalltrd2 = 0;
        public static int heavenlymalltrd2 = 0;
        public static int shangrillamalltrd2 = 0;
        public static int utility2x1trd2 = 0;
        public static int utility2x2trd2 = 0;
        public static int transportation2x1trd2 = 0;
        public static int transportation2x2trd2 = 0;
        public static int transportation2x3trd2 = 0;
        public static int transportation2x4trd2 = 0;

        //details
        int easternschooldet1 = 0;
        int westernschooldet1 = 0;
        int visayashighschooldet1 = 0;
        int southernschooldet1 = 0;
        int nationsschooldet1 = 0;
        int westmarketdet1 = 0;
        int nightmarketdet1 = 0;
        int daymarketdet1 = 0;
        int starmarketdet1 = 0;
        int moonmarketdet1 = 0;
        int megamarketdet1 = 0;
        int visayashospitaldet1 = 0;
        int hobertshospitaldet1 = 0;
        int heartshospitaldet1 = 0;
        int internshospitaldet1 = 0;
        int nationalhealthhospitaldet1 = 0;
        int veteranshospitaldet1 = 0;
        int pearlmalldet1 = 0;
        int megamalldet1 = 0;
        int articmalldet1 = 0;
        int heavenlymalldet1 = 0;
        int shangrillamalldet1 = 0;
        int utility1x1det1 = 0;
        int utility1x2det1 = 0;
        int transportation1x1det1 = 0;
        int transportation1x2det1 = 0;
        int transportation1x3det1 = 0;
        int transportation1x4det1 = 0;

        int easternschooldet2 = 0;
        int westernschooldet2 = 0;
        int visayashighschooldet2 = 0;
        int southernschooldet2 = 0;
        int nationsschooldet2 = 0;
        int westmarketdet2 = 0;
        int nightmarketdet2 = 0;
        int daymarketdet2 = 0;
        int starmarketdet2 = 0;
        int moonmarketdet2 = 0;
        int megamarketdet2 = 0;
        int visayashospitaldet2 = 0;
        int hobertshospitaldet2 = 0;
        int heartshospitaldet2 = 0;
        int internshospitaldet2 = 0;
        int nationalhealthhospitaldet2 = 0;
        int veteranshospitaldet2 = 0;
        int pearlmalldet2 = 0;
        int megamalldet2 = 0;
        int articmalldet2 = 0;
        int heavenlymalldet2 = 0;
        int shangrillamalldet2 = 0;
        int utility2x1det2 = 0;
        int utility2x2det2 = 0;
        int transportation2x1det2 = 0;
        int transportation2x2det2 = 0;
        int transportation2x3det2 = 0;
        int transportation2x4det2 = 0;

        //spec traded flags
        public static int easternschooltr1d = 0;
        public static int westernschooltr1d = 0;
        public static int visayashighschooltr1d = 0;
        public static int southernschooltr1d = 0;
        public static int nationsschooltr1d = 0;
        public static int westmarkettr1d = 0;
        public static int nightmarkettr1d = 0;
        public static int daymarkettr1d = 0;
        public static int starmarkettr1d = 0;
        public static int moonmarkettr1d = 0;
        public static int megamarkettr1d = 0;
        public static int visayashospitaltr1d = 0;
        public static int hobertshospitaltr1d = 0;
        public static int heartshospitaltr1d = 0;
        public static int internshospitaltr1d = 0;
        public static int nationalhealthhospitaltr1d = 0;
        public static int veteranshospitaltr1d = 0;
        public static int pearlmalltr1d = 0;
        public static int megamalltr1d = 0;
        public static int articmalltr1d = 0;
        public static int heavenlymalltr1d = 0;
        public static int shangrillamalltr1d = 0;
        public static int utility1x1tr1d = 0;
        public static int utility1x2tr1d = 0;
        public static int transportation1x1tr1d = 0;
        public static int transportation1x2tr1d = 0;
        public static int transportation1x3tr1d = 0;
        public static int transportation1x4tr1d = 0;

        public static int easternschooltr2d = 0;
        public static int westernschooltr2d = 0;
        public static int visayashighschooltr2d = 0;
        public static int southernschooltr2d = 0;
        public static int nationsschooltr2d = 0;
        public static int westmarkettr2d = 0;
        public static int nightmarkettr2d = 0;
        public static int daymarkettr2d = 0;
        public static int starmarkettr2d = 0;
        public static int moonmarkettr2d = 0;
        public static int megamarkettr2d = 0;
        public static int visayashospitaltr2d = 0;
        public static int hobertshospitaltr2d = 0;
        public static int heartshospitaltr2d = 0;
        public static int internshospitaltr2d = 0;
        public static int nationalhealthhospitaltr2d = 0;
        public static int veteranshospitaltr2d = 0;
        public static int pearlmalltr2d = 0;
        public static int megamalltr2d = 0;
        public static int articmalltr2d = 0;
        public static int heavenlymalltr2d = 0;
        public static int shangrillamalltr2d = 0;
        public static int utility2x1tr2d = 0;
        public static int utility2x2tr2d = 0;
        public static int transportation2x1tr2d = 0;
        public static int transportation2x2tr2d = 0;
        public static int transportation2x3tr2d = 0;
        public static int transportation2x4tr2d = 0;

        public static int easternschooltr3d = 0;
        public static int westernschooltr3d = 0;
        public static int visayashighschooltr3d = 0;
        public static int southernschooltr3d = 0;
        public static int nationsschooltr3d = 0;
        public static int westmarkettr3d = 0;
        public static int nightmarkettr3d = 0;
        public static int daymarkettr3d = 0;
        public static int starmarkettr3d = 0;
        public static int moonmarkettr3d = 0;
        public static int megamarkettr3d = 0;
        public static int visayashospitaltr3d = 0;
        public static int hobertshospitaltr3d = 0;
        public static int heartshospitaltr3d = 0;
        public static int internshospitaltr3d = 0;
        public static int nationalhealthhospitaltr3d = 0;
        public static int veteranshospitaltr3d = 0;
        public static int pearlmalltr3d = 0;
        public static int megamalltr3d = 0;
        public static int articmalltr3d = 0;
        public static int heavenlymalltr3d = 0;
        public static int shangrillamalltr3d = 0;
        public static int utility3x1tr3d = 0;
        public static int utility3x2tr3d = 0;
        public static int transportation3x1tr3d = 0;
        public static int transportation3x2tr3d = 0;
        public static int transportation3x3tr3d = 0;
        public static int transportation3x4tr3d = 0;
        public static int easternschooltr4d = 0;
        public static int westernschooltr4d = 0;
        public static int visayashighschooltr4d = 0;
        public static int southernschooltr4d = 0;
        public static int nationsschooltr4d = 0;
        public static int westmarkettr4d = 0;
        public static int nightmarkettr4d = 0;
        public static int daymarkettr4d = 0;
        public static int starmarkettr4d = 0;
        public static int moonmarkettr4d = 0;
        public static int megamarkettr4d = 0;
        public static int visayashospitaltr4d = 0;
        public static int hobertshospitaltr4d = 0;
        public static int heartshospitaltr4d = 0;
        public static int internshospitaltr4d = 0;
        public static int nationalhealthhospitaltr4d = 0;
        public static int veteranshospitaltr4d = 0;
        public static int pearlmalltr4d = 0;
        public static int megamalltr4d = 0;
        public static int articmalltr4d = 0;
        public static int heavenlymalltr4d = 0;
        public static int shangrillamalltr4d = 0;
        public static int utility4x1tr4d = 0;
        public static int utility4x2tr4d = 0;
        public static int transportation4x1tr4d = 0;
        public static int transportation4x2tr4d = 0;
        public static int transportation4x3tr4d = 0;
        public static int transportation4x4tr4d = 0;


        #endregion

        public tradp4()
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

            p1 = p4_gameplay.p1;
            p2 = p4_gameplay.p2;
            p3 = p4_gameplay.p3;
            p4 = p4_gameplay.p4;

            p1trad = p4_gameplay.p1trad;
            p2trad = p4_gameplay.p2trad;
            p3trad = p4_gameplay.p3trad;
            p4trad = p4_gameplay.p4trad;

            quick = Settings.timer1;
            quick2 = Settings.timer2;
            quick3 = Settings.timer3;
            quick4 = Settings.timer4;

            easternschooltr1 = p4_gameplay.easternschooltr1;
            westernschooltr1 = p4_gameplay.westernschooltr1;
            visayashighschooltr1 = p4_gameplay.visayashighschooltr1;
            southernschooltr1 = p4_gameplay.southernschooltr1;
            nationsschooltr1 = p4_gameplay.nationsschooltr1;
            westmarkettr1 = p4_gameplay.westmarkettr1;
            nightmarkettr1 = p4_gameplay.nightmarkettr1;
            daymarkettr1 = p4_gameplay.daymarkettr1;
            starmarkettr1 = p4_gameplay.starmarkettr1;
            moonmarkettr1 = p4_gameplay.moonmarkettr1;
            megamarkettr1 = p4_gameplay.megamarkettr1;
            visayashospitaltr1 = p4_gameplay.visayashospitaltr1;
            hobertshospitaltr1 = p4_gameplay.hobertshospitaltr1;
            heartshospitaltr1 = p4_gameplay.heartshospitaltr1;
            internshospitaltr1 = p4_gameplay.internshospitaltr1;
            nationalhealthhospitaltr1 = p4_gameplay.nationalhealthhospitaltr1;
            veteranshospitaltr1 = p4_gameplay.veteranshospitaltr1;
            pearlmalltr1 = p4_gameplay.pearlmalltr1;
            megamalltr1 = p4_gameplay.megamalltr1;
            articmalltr1 = p4_gameplay.articmalltr1;
            heavenlymalltr1 = p4_gameplay.heavenlymalltr1;
            shangrillamalltr1 = p4_gameplay.shangrillamalltr1;
            utility1x1tr1 = p4_gameplay.utility1x1tr1;
            utility1x2tr1 = p4_gameplay.utility1x2tr1;
            transportation1x1tr1 = p4_gameplay.transportation1x1tr1;
            transportation1x2tr1 = p4_gameplay.transportation1x2tr1;
            transportation1x3tr1 = p4_gameplay.transportation1x3tr1;
            transportation1x4tr1 = p4_gameplay.transportation1x4tr1;


            easternschooltr2 = p4_gameplay.easternschooltr2;
            westernschooltr2 = p4_gameplay.westernschooltr2;
            visayashighschooltr2 = p4_gameplay.visayashighschooltr2;
            southernschooltr2 = p4_gameplay.southernschooltr2;
            nationsschooltr2 = p4_gameplay.nationsschooltr2;
            westmarkettr2 = p4_gameplay.westmarkettr2;
            nightmarkettr2 = p4_gameplay.nightmarkettr2;
            daymarkettr2 = p4_gameplay.daymarkettr2;
            starmarkettr2 = p4_gameplay.starmarkettr2;
            moonmarkettr2 = p4_gameplay.moonmarkettr2;
            megamarkettr2 = p4_gameplay.megamarkettr2;
            visayashospitaltr2 = p4_gameplay.visayashospitaltr2;
            hobertshospitaltr2 = p4_gameplay.hobertshospitaltr2;
            heartshospitaltr2 = p4_gameplay.heartshospitaltr2;
            internshospitaltr2 = p4_gameplay.internshospitaltr2;
            nationalhealthhospitaltr2 = p4_gameplay.nationalhealthhospitaltr2;
            veteranshospitaltr2 = p4_gameplay.veteranshospitaltr2;
            pearlmalltr2 = p4_gameplay.pearlmalltr2;
            megamalltr2 = p4_gameplay.megamalltr2;
            articmalltr2 = p4_gameplay.articmalltr2;
            heavenlymalltr2 = p4_gameplay.heavenlymalltr2;
            shangrillamalltr2 = p4_gameplay.shangrillamalltr2;
            utility2x1tr2 = p4_gameplay.utility2x1tr2;
            utility2x2tr2 = p4_gameplay.utility2x2tr2;
            transportation2x1tr2 = p4_gameplay.transportation2x1tr2;
            transportation2x2tr2 = p4_gameplay.transportation2x2tr2;
            transportation2x3tr2 = p4_gameplay.transportation2x3tr2;
            transportation2x4tr2 = p4_gameplay.transportation2x4tr2;

            easternschooltr3 = p4_gameplay.easternschooltr3;
            westernschooltr3 = p4_gameplay.westernschooltr3;
            visayashighschooltr3 = p4_gameplay.visayashighschooltr3;
            southernschooltr3 = p4_gameplay.southernschooltr3;
            nationsschooltr3 = p4_gameplay.nationsschooltr3;
            westmarkettr3 = p4_gameplay.westmarkettr3;
            nightmarkettr3 = p4_gameplay.nightmarkettr3;
            daymarkettr3 = p4_gameplay.daymarkettr3;
            starmarkettr3 = p4_gameplay.starmarkettr3;
            moonmarkettr3 = p4_gameplay.moonmarkettr3;
            megamarkettr3 = p4_gameplay.megamarkettr3;
            visayashospitaltr3 = p4_gameplay.visayashospitaltr3;
            hobertshospitaltr3 = p4_gameplay.hobertshospitaltr3;
            heartshospitaltr3 = p4_gameplay.heartshospitaltr3;
            internshospitaltr3 = p4_gameplay.internshospitaltr3;
            nationalhealthhospitaltr3 = p4_gameplay.nationalhealthhospitaltr3;
            veteranshospitaltr3 = p4_gameplay.veteranshospitaltr3;
            pearlmalltr3 = p4_gameplay.pearlmalltr3;
            megamalltr3 = p4_gameplay.megamalltr3;
            articmalltr3 = p4_gameplay.articmalltr3;
            heavenlymalltr3 = p4_gameplay.heavenlymalltr3;
            shangrillamalltr3 = p4_gameplay.shangrillamalltr3;
            utility3x1tr3 = p4_gameplay.utility3x1tr3;
            utility3x2tr3 = p4_gameplay.utility3x2tr3;
            transportation3x1tr3 = p4_gameplay.transportation3x1tr3;
            transportation3x2tr3 = p4_gameplay.transportation3x2tr3;
            transportation3x3tr3 = p4_gameplay.transportation3x3tr3;
            transportation3x4tr3 = p4_gameplay.transportation3x4tr3;

            easternschooltr4 = p4_gameplay.easternschooltr4;
            westernschooltr4 = p4_gameplay.westernschooltr4;
            visayashighschooltr4 = p4_gameplay.visayashighschooltr4;
            southernschooltr4 = p4_gameplay.southernschooltr4;
            nationsschooltr4 = p4_gameplay.nationsschooltr4;
            westmarkettr4 = p4_gameplay.westmarkettr4;
            nightmarkettr4 = p4_gameplay.nightmarkettr4;
            daymarkettr4 = p4_gameplay.daymarkettr4;
            starmarkettr4 = p4_gameplay.starmarkettr4;
            moonmarkettr4 = p4_gameplay.moonmarkettr4;
            megamarkettr4 = p4_gameplay.megamarkettr4;
            visayashospitaltr4 = p4_gameplay.visayashospitaltr4;
            hobertshospitaltr4 = p4_gameplay.hobertshospitaltr4;
            heartshospitaltr4 = p4_gameplay.heartshospitaltr4;
            internshospitaltr4 = p4_gameplay.internshospitaltr4;
            nationalhealthhospitaltr4 = p4_gameplay.nationalhealthhospitaltr4;
            veteranshospitaltr4 = p4_gameplay.veteranshospitaltr4;
            pearlmalltr4 = p4_gameplay.pearlmalltr4;
            megamalltr4 = p4_gameplay.megamalltr4;
            articmalltr4 = p4_gameplay.articmalltr4;
            heavenlymalltr4 = p4_gameplay.heavenlymalltr4;
            shangrillamalltr4 = p4_gameplay.shangrillamalltr4;
            utility4x1tr4 = p4_gameplay.utility4x1tr4;
            utility4x2tr4 = p4_gameplay.utility4x2tr4;
            transportation4x1tr4 = p4_gameplay.transportation4x1tr4;
            transportation4x2tr4 = p4_gameplay.transportation4x2tr4;
            transportation4x3tr4 = p4_gameplay.transportation4x3tr4;
            transportation4x4tr4 = p4_gameplay.transportation4x4tr4;
            InitializeComponent();
        }

        #region rules for trad
        void trp1trad()
        {
            if (p4_gameplay.easternschooltr1 == 1 && p4_gameplay.p1trad == 1)
            {
                pb1x1.Visible = true;
                pb1x1.Image = bankers_game_proto.Properties.Resources.Eastern_School_Purple;

            }
            if (p4_gameplay.westernschooltr1 == 1 && p4_gameplay.p1trad == 1)
            {
                pb1x2.Visible = true;
                pb1x2.Image = bankers_game_proto.Properties.Resources.Western_school;
            }

            if (p4_gameplay.visayashighschooltr1 == 1 && p4_gameplay.p1trad == 1)
            {
                pb1x3.Visible = true;
                pb1x3.Image = bankers_game_proto.Properties.Resources.Visayas_highschool;
            }
            if (p4_gameplay.southernschooltr1 == 1 && p4_gameplay.p1trad == 1)
            {
                pb1x4.Visible = true;
                pb1x4.Image = bankers_game_proto.Properties.Resources.Southern_highschool;
            }
            if (p4_gameplay.nationsschooltr1 == 1 && p4_gameplay.p1trad == 1)
            {
                pb1x5.Visible = true;
                pb1x5.Image = bankers_game_proto.Properties.Resources.Nation_s_highschool;
            }

            if (p4_gameplay.westmarkettr1 == 1 && p4_gameplay.p1trad == 1)
            {
                pb1x6.Visible = true;
                pb1x6.Image = bankers_game_proto.Properties.Resources.West_Market;
            }
            if (p4_gameplay.nightmarkettr1 == 1 && p4_gameplay.p1trad == 1)
            {
                pb1x7.Visible = true;
                pb1x7.Image = bankers_game_proto.Properties.Resources.Night_market;
            }
            if (p4_gameplay.daymarkettr1 == 1 && p4_gameplay.p1trad == 1)
            {
                pb1x8.Visible = true;
                pb1x8.Image = bankers_game_proto.Properties.Resources.Day_market;
            }

            if (p4_gameplay.starmarkettr1 == 1 && p4_gameplay.p1trad == 1)
            {
                pb1x9.Visible = true;
                pb1x9.Image = bankers_game_proto.Properties.Resources.Star_market;
            }
            if (p4_gameplay.moonmarkettr1 == 1 && p4_gameplay.p1trad == 1)
            {
                pb1x10.Visible = true;
                pb1x10.Image = bankers_game_proto.Properties.Resources.Moon_market;
            }
            if (p4_gameplay.megamarkettr1 == 1 && p4_gameplay.p1trad == 1)
            {
                pb1x11.Visible = true;
                pb1x11.Image = bankers_game_proto.Properties.Resources.Mega_market;
            }

            if (p4_gameplay.visayashospitaltr1 == 1 && p4_gameplay.p1trad == 1)
            {
                pb1x12.Visible = true;
                pb1x12.Image = bankers_game_proto.Properties.Resources.Visayas_hospital;
            }
            if (p4_gameplay.hobertshospitaltr1 == 1 && p4_gameplay.p1trad == 1)
            {
                pb1x13.Visible = true;
                pb1x13.Image = bankers_game_proto.Properties.Resources.Hobert_s_hospital;
            }
            if (p4_gameplay.heartshospitaltr1 == 1 && p4_gameplay.p1trad == 1)
            {
                pb1x14.Visible = true;
                pb1x14.Image = bankers_game_proto.Properties.Resources.Hearts_hospital;
            }

            if (p4_gameplay.internshospitaltr1 == 1 && p4_gameplay.p1trad == 1)
            {
                pb1x15.Visible = true;
                pb1x15.Image = bankers_game_proto.Properties.Resources.Intern_s_hospital;
            }
            if (p4_gameplay.nationalhealthhospitaltr1 == 1 && p4_gameplay.p1trad == 1)
            {
                pb1x16.Visible = true;
                pb1x16.Image = bankers_game_proto.Properties.Resources.National_healths_hospital;
            }
            if (p4_gameplay.veteranshospitaltr1 == 1 && p4_gameplay.p1trad == 1)
            {
                pb1x17.Visible = true;
                pb1x17.Image = bankers_game_proto.Properties.Resources.VETERANS_Hospital;
            }

            if (p4_gameplay.pearlmalltr1 == 1 && p4_gameplay.p1trad == 1)
            {
                pb1x18.Visible = true;
                pb1x18.Image = bankers_game_proto.Properties.Resources.Pearl_Mall;
            }
            if (p4_gameplay.megamalltr1 == 1 && p4_gameplay.p1trad == 1)
            {
                pb1x19.Visible = true;
                pb1x19.Image = bankers_game_proto.Properties.Resources.Mega_mall;
            }
            if (p4_gameplay.articmalltr1 == 1 && p4_gameplay.p1trad == 1)
            {
                pb1x20.Visible = true;
                pb1x20.Image = bankers_game_proto.Properties.Resources.Artic_mall;

            }

            if (p4_gameplay.heavenlymalltr1 == 1 && p4_gameplay.p1trad == 1)
            {
                pb1x21.Visible = true;
                pb1x21.Image = bankers_game_proto.Properties.Resources.Heavenly_mall;

            }
            if (p4_gameplay.shangrillamalltr1 == 1 && p4_gameplay.p1trad == 1)
            {
                pb1x22.Visible = true;
                pb1x22.Image = bankers_game_proto.Properties.Resources.Shangrilla_Mall;

            }

            if (p4_gameplay.utility1x1tr1 == 1 && p4_gameplay.p1trad == 1)
            {
                pb1x23.Visible = true;
                pb1x23.Image = bankers_game_proto.Properties.Resources.Meralco;

            }
            if (p4_gameplay.utility1x2tr1 == 1 && p4_gameplay.p1trad == 1)
            {
                pb1x24.Visible = true;
                pb1x24.Image = bankers_game_proto.Properties.Resources.Niagra_Fall;

            }

            if (p4_gameplay.transportation1x1tr1 == 1 && p4_gameplay.p1trad == 1)
            {
                pb1x25.Visible = true;
                pb1x25.Image = bankers_game_proto.Properties.Resources.Rosevelt_Station;

            }
            if (p4_gameplay.transportation1x2tr1 == 1 && p4_gameplay.p1trad == 1)
            {
                pb1x26.Visible = true;
                pb1x26.Image = bankers_game_proto.Properties.Resources.Santolan_Station;
            }
            if (p4_gameplay.transportation1x3tr1 == 1 && p4_gameplay.p1trad == 1)
            {
                pb1x27.Visible = true;
                pb1x27.Image = bankers_game_proto.Properties.Resources.Quezon_Station;
            }
            if (p4_gameplay.transportation1x4tr1 == 1 && p4_gameplay.p1trad == 1)
            {
                pb1x28.Visible = true;
                pb1x28.Image = bankers_game_proto.Properties.Resources.Trinoma_Station;
            }
        }
        void trp2trad()
        {
            if (p4_gameplay.easternschooltr2 == 1 && p4_gameplay.p2trad == 1)
            {
                pb1x1.Visible = true;
                pb1x1.Image = bankers_game_proto.Properties.Resources.Eastern_School_Purple;

            }
            if (p4_gameplay.westernschooltr2 == 1 && p4_gameplay.p2trad == 1)
            {
                pb1x2.Visible = true;
                pb1x2.Image = bankers_game_proto.Properties.Resources.Western_school;
            }

            if (p4_gameplay.visayashighschooltr2 == 1 && p4_gameplay.p2trad == 1)
            {
                pb1x3.Visible = true;
                pb1x3.Image = bankers_game_proto.Properties.Resources.Visayas_highschool;
            }
            if (p4_gameplay.southernschooltr2 == 1 && p4_gameplay.p2trad == 1)
            {
                pb1x4.Visible = true;
                pb1x4.Image = bankers_game_proto.Properties.Resources.Southern_highschool;
            }
            if (p4_gameplay.nationsschooltr2 == 1 && p4_gameplay.p2trad == 1)
            {
                pb1x5.Visible = true;
                pb1x5.Image = bankers_game_proto.Properties.Resources.Nation_s_highschool;
            }

            if (p4_gameplay.westmarkettr2 == 1 && p4_gameplay.p2trad == 1)
            {
                pb1x6.Visible = true;
                pb1x6.Image = bankers_game_proto.Properties.Resources.West_Market;
            }
            if (p4_gameplay.nightmarkettr2 == 1 && p4_gameplay.p2trad == 1)
            {
                pb1x7.Visible = true;
                pb1x7.Image = bankers_game_proto.Properties.Resources.Night_market;
            }
            if (p4_gameplay.daymarkettr2 == 1 && p4_gameplay.p2trad == 1)
            {
                pb1x8.Visible = true;
                pb1x8.Image = bankers_game_proto.Properties.Resources.Day_market;
            }

            if (p4_gameplay.starmarkettr2 == 1 && p4_gameplay.p2trad == 1)
            {
                pb1x9.Visible = true;
                pb1x9.Image = bankers_game_proto.Properties.Resources.Star_market;
            }
            if (p4_gameplay.moonmarkettr2 == 1 && p4_gameplay.p2trad == 1)
            {
                pb1x10.Visible = true;
                pb1x10.Image = bankers_game_proto.Properties.Resources.Moon_market;
            }
            if (p4_gameplay.megamarkettr2 == 1 && p4_gameplay.p2trad == 1)
            {
                pb1x11.Visible = true;
                pb1x11.Image = bankers_game_proto.Properties.Resources.Mega_market;
            }

            if (p4_gameplay.visayashospitaltr2 == 1 && p4_gameplay.p2trad == 1)
            {
                pb1x12.Visible = true;
                pb1x12.Image = bankers_game_proto.Properties.Resources.Visayas_hospital;
            }
            if (p4_gameplay.hobertshospitaltr2 == 1 && p4_gameplay.p2trad == 1)
            {
                pb1x13.Visible = true;
                pb1x13.Image = bankers_game_proto.Properties.Resources.Hobert_s_hospital;
            }
            if (p4_gameplay.heartshospitaltr2 == 1 && p4_gameplay.p2trad == 1)
            {
                pb1x14.Visible = true;
                pb1x14.Image = bankers_game_proto.Properties.Resources.Hearts_hospital;
            }

            if (p4_gameplay.internshospitaltr2 == 1 && p4_gameplay.p2trad == 1)
            {
                pb1x15.Visible = true;
                pb1x15.Image = bankers_game_proto.Properties.Resources.Intern_s_hospital;
            }
            if (p4_gameplay.nationalhealthhospitaltr2 == 1 && p4_gameplay.p2trad == 1)
            {
                pb1x16.Visible = true;
                pb1x16.Image = bankers_game_proto.Properties.Resources.National_healths_hospital;
            }
            if (p4_gameplay.veteranshospitaltr2 == 1 && p4_gameplay.p2trad == 1)
            {
                pb1x17.Visible = true;
                pb1x17.Image = bankers_game_proto.Properties.Resources.VETERANS_Hospital;
            }

            if (p4_gameplay.pearlmalltr2 == 1 && p4_gameplay.p2trad == 1)
            {
                pb1x18.Visible = true;
                pb1x18.Image = bankers_game_proto.Properties.Resources.Pearl_Mall;
            }
            if (p4_gameplay.megamalltr2 == 1 && p4_gameplay.p2trad == 1)
            {
                pb1x19.Visible = true;
                pb1x19.Image = bankers_game_proto.Properties.Resources.Mega_mall;
            }
            if (p4_gameplay.articmalltr2 == 1 && p4_gameplay.p2trad == 1)
            {
                pb1x20.Visible = true;
                pb1x20.Image = bankers_game_proto.Properties.Resources.Artic_mall;

            }

            if (p4_gameplay.heavenlymalltr2 == 1 && p4_gameplay.p2trad == 1)
            {
                pb1x21.Visible = true;
                pb1x21.Image = bankers_game_proto.Properties.Resources.Heavenly_mall;

            }
            if (p4_gameplay.shangrillamalltr2 == 1 && p4_gameplay.p2trad == 1)
            {
                pb1x22.Visible = true;
                pb1x22.Image = bankers_game_proto.Properties.Resources.Shangrilla_Mall;

            }

            if (p4_gameplay.utility2x1tr2 == 1 && p4_gameplay.p2trad == 1)
            {
                pb1x23.Visible = true;
                pb1x23.Image = bankers_game_proto.Properties.Resources.Meralco;

            }
            if (p4_gameplay.utility2x2tr2 == 1 && p4_gameplay.p2trad == 1)
            {
                pb1x24.Visible = true;
                pb1x24.Image = bankers_game_proto.Properties.Resources.Niagra_Fall;

            }

            if (p4_gameplay.transportation2x1tr2 == 1 && p4_gameplay.p2trad == 1)
            {
                pb1x25.Visible = true;
                pb1x25.Image = bankers_game_proto.Properties.Resources.Rosevelt_Station;

            }
            if (p4_gameplay.transportation2x2tr2 == 1 && p4_gameplay.p2trad == 1)
            {
                pb1x26.Visible = true;
                pb1x26.Image = bankers_game_proto.Properties.Resources.Santolan_Station;
            }
            if (p4_gameplay.transportation2x3tr2 == 1 && p4_gameplay.p2trad == 1)
            {
                pb1x27.Visible = true;
                pb1x27.Image = bankers_game_proto.Properties.Resources.Quezon_Station;
            }
            if (p4_gameplay.transportation2x4tr2 == 1 && p4_gameplay.p2trad == 1)
            {
                pb1x28.Visible = true;
                pb1x28.Image = bankers_game_proto.Properties.Resources.Trinoma_Station;
            }
        }
        void trp3trad()
        {
            if (p4_gameplay.easternschooltr3 == 1 && p4_gameplay.p3trad == 1)
            {
                pb1x1.Visible = true;
                pb1x1.Image = bankers_game_proto.Properties.Resources.Eastern_School_Purple;

            }
            if (p4_gameplay.westernschooltr3 == 1 && p4_gameplay.p3trad == 1)
            {
                pb1x2.Visible = true;
                pb1x2.Image = bankers_game_proto.Properties.Resources.Western_school;
            }

            if (p4_gameplay.visayashighschooltr3 == 1 && p4_gameplay.p3trad == 1)
            {
                pb1x3.Visible = true;
                pb1x3.Image = bankers_game_proto.Properties.Resources.Visayas_highschool;
            }
            if (p4_gameplay.southernschooltr3 == 1 && p4_gameplay.p3trad == 1)
            {
                pb1x4.Visible = true;
                pb1x4.Image = bankers_game_proto.Properties.Resources.Southern_highschool;
            }
            if (p4_gameplay.nationsschooltr3 == 1 && p4_gameplay.p3trad == 1)
            {
                pb1x5.Visible = true;
                pb1x5.Image = bankers_game_proto.Properties.Resources.Nation_s_highschool;
            }

            if (p4_gameplay.westmarkettr3 == 1 && p4_gameplay.p3trad == 1)
            {
                pb1x6.Visible = true;
                pb1x6.Image = bankers_game_proto.Properties.Resources.West_Market;
            }
            if (p4_gameplay.nightmarkettr3 == 1 && p4_gameplay.p3trad == 1)
            {
                pb1x7.Visible = true;
                pb1x7.Image = bankers_game_proto.Properties.Resources.Night_market;
            }
            if (p4_gameplay.daymarkettr3 == 1 && p4_gameplay.p3trad == 1)
            {
                pb1x8.Visible = true;
                pb1x8.Image = bankers_game_proto.Properties.Resources.Day_market;
            }

            if (p4_gameplay.starmarkettr3 == 1 && p4_gameplay.p3trad == 1)
            {
                pb1x9.Visible = true;
                pb1x9.Image = bankers_game_proto.Properties.Resources.Star_market;
            }
            if (p4_gameplay.moonmarkettr3 == 1 && p4_gameplay.p3trad == 1)
            {
                pb1x10.Visible = true;
                pb1x10.Image = bankers_game_proto.Properties.Resources.Moon_market;
            }
            if (p4_gameplay.megamarkettr3 == 1 && p4_gameplay.p3trad == 1)
            {
                pb1x11.Visible = true;
                pb1x11.Image = bankers_game_proto.Properties.Resources.Mega_market;
            }

            if (p4_gameplay.visayashospitaltr3 == 1 && p4_gameplay.p3trad == 1)
            {
                pb1x12.Visible = true;
                pb1x12.Image = bankers_game_proto.Properties.Resources.Visayas_hospital;
            }
            if (p4_gameplay.hobertshospitaltr3 == 1 && p4_gameplay.p3trad == 1)
            {
                pb1x13.Visible = true;
                pb1x13.Image = bankers_game_proto.Properties.Resources.Hobert_s_hospital;
            }
            if (p4_gameplay.heartshospitaltr3 == 1 && p4_gameplay.p3trad == 1)
            {
                pb1x14.Visible = true;
                pb1x14.Image = bankers_game_proto.Properties.Resources.Hearts_hospital;
            }

            if (p4_gameplay.internshospitaltr3 == 1 && p4_gameplay.p3trad == 1)
            {
                pb1x15.Visible = true;
                pb1x15.Image = bankers_game_proto.Properties.Resources.Intern_s_hospital;
            }
            if (p4_gameplay.nationalhealthhospitaltr3 == 1 && p4_gameplay.p3trad == 1)
            {
                pb1x16.Visible = true;
                pb1x16.Image = bankers_game_proto.Properties.Resources.National_healths_hospital;
            }
            if (p4_gameplay.veteranshospitaltr3 == 1 && p4_gameplay.p3trad == 1)
            {
                pb1x17.Visible = true;
                pb1x17.Image = bankers_game_proto.Properties.Resources.VETERANS_Hospital;
            }

            if (p4_gameplay.pearlmalltr3 == 1 && p4_gameplay.p3trad == 1)
            {
                pb1x18.Visible = true;
                pb1x18.Image = bankers_game_proto.Properties.Resources.Pearl_Mall;
            }
            if (p4_gameplay.megamalltr3 == 1 && p4_gameplay.p3trad == 1)
            {
                pb1x19.Visible = true;
                pb1x19.Image = bankers_game_proto.Properties.Resources.Mega_mall;
            }
            if (p4_gameplay.articmalltr3 == 1 && p4_gameplay.p3trad == 1)
            {
                pb1x20.Visible = true;
                pb1x20.Image = bankers_game_proto.Properties.Resources.Artic_mall;

            }

            if (p4_gameplay.heavenlymalltr3 == 1 && p4_gameplay.p3trad == 1)
            {
                pb1x21.Visible = true;
                pb1x21.Image = bankers_game_proto.Properties.Resources.Heavenly_mall;

            }
            if (p4_gameplay.shangrillamalltr3 == 1 && p4_gameplay.p3trad == 1)
            {
                pb1x22.Visible = true;
                pb1x22.Image = bankers_game_proto.Properties.Resources.Shangrilla_Mall;

            }

            if (p4_gameplay.utility3x1tr3 == 1 && p4_gameplay.p3trad == 1)
            {
                pb1x23.Visible = true;
                pb1x23.Image = bankers_game_proto.Properties.Resources.Meralco;

            }
            if (p4_gameplay.utility3x2tr3 == 1 && p4_gameplay.p3trad == 1)
            {
                pb1x24.Visible = true;
                pb1x24.Image = bankers_game_proto.Properties.Resources.Niagra_Fall;

            }

            if (p4_gameplay.transportation3x1tr3 == 1 && p4_gameplay.p3trad == 1)
            {
                pb1x25.Visible = true;
                pb1x25.Image = bankers_game_proto.Properties.Resources.Rosevelt_Station;

            }
            if (p4_gameplay.transportation3x2tr3 == 1 && p4_gameplay.p3trad == 1)
            {
                pb1x26.Visible = true;
                pb1x26.Image = bankers_game_proto.Properties.Resources.Santolan_Station;
            }
            if (p4_gameplay.transportation3x3tr3 == 1 && p4_gameplay.p3trad == 1)
            {
                pb1x27.Visible = true;
                pb1x27.Image = bankers_game_proto.Properties.Resources.Quezon_Station;
            }
            if (p4_gameplay.transportation3x4tr3 == 1 && p4_gameplay.p3trad == 1)
            {
                pb1x28.Visible = true;
                pb1x28.Image = bankers_game_proto.Properties.Resources.Trinoma_Station;
            }
        }
        void trp4trad()
        {
            if (p4_gameplay.easternschooltr4 == 1 && p4_gameplay.p4trad == 1)
            {
                pb1x1.Visible = true;
                pb1x1.Image = bankers_game_proto.Properties.Resources.Eastern_School_Purple;

            }
            if (p4_gameplay.westernschooltr4 == 1 && p4_gameplay.p4trad == 1)
            {
                pb1x2.Visible = true;
                pb1x2.Image = bankers_game_proto.Properties.Resources.Western_school;
            }

            if (p4_gameplay.visayashighschooltr4 == 1 && p4_gameplay.p4trad == 1)
            {
                pb1x3.Visible = true;
                pb1x3.Image = bankers_game_proto.Properties.Resources.Visayas_highschool;
            }
            if (p4_gameplay.southernschooltr4 == 1 && p4_gameplay.p4trad == 1)
            {
                pb1x4.Visible = true;
                pb1x4.Image = bankers_game_proto.Properties.Resources.Southern_highschool;
            }
            if (p4_gameplay.nationsschooltr4 == 1 && p4_gameplay.p4trad == 1)
            {
                pb1x5.Visible = true;
                pb1x5.Image = bankers_game_proto.Properties.Resources.Nation_s_highschool;
            }

            if (p4_gameplay.westmarkettr4 == 1 && p4_gameplay.p4trad == 1)
            {
                pb1x6.Visible = true;
                pb1x6.Image = bankers_game_proto.Properties.Resources.West_Market;
            }
            if (p4_gameplay.nightmarkettr4 == 1 && p4_gameplay.p4trad == 1)
            {
                pb1x7.Visible = true;
                pb1x7.Image = bankers_game_proto.Properties.Resources.Night_market;
            }
            if (p4_gameplay.daymarkettr4 == 1 && p4_gameplay.p4trad == 1)
            {
                pb1x8.Visible = true;
                pb1x8.Image = bankers_game_proto.Properties.Resources.Day_market;
            }

            if (p4_gameplay.starmarkettr4 == 1 && p4_gameplay.p4trad == 1)
            {
                pb1x9.Visible = true;
                pb1x9.Image = bankers_game_proto.Properties.Resources.Star_market;
            }
            if (p4_gameplay.moonmarkettr4 == 1 && p4_gameplay.p4trad == 1)
            {
                pb1x10.Visible = true;
                pb1x10.Image = bankers_game_proto.Properties.Resources.Moon_market;
            }
            if (p4_gameplay.megamarkettr4 == 1 && p4_gameplay.p4trad == 1)
            {
                pb1x11.Visible = true;
                pb1x11.Image = bankers_game_proto.Properties.Resources.Mega_market;
            }

            if (p4_gameplay.visayashospitaltr4 == 1 && p4_gameplay.p4trad == 1)
            {
                pb1x12.Visible = true;
                pb1x12.Image = bankers_game_proto.Properties.Resources.Visayas_hospital;
            }
            if (p4_gameplay.hobertshospitaltr4 == 1 && p4_gameplay.p4trad == 1)
            {
                pb1x13.Visible = true;
                pb1x13.Image = bankers_game_proto.Properties.Resources.Hobert_s_hospital;
            }
            if (p4_gameplay.heartshospitaltr4 == 1 && p4_gameplay.p4trad == 1)
            {
                pb1x14.Visible = true;
                pb1x14.Image = bankers_game_proto.Properties.Resources.Hearts_hospital;
            }

            if (p4_gameplay.internshospitaltr4 == 1 && p4_gameplay.p4trad == 1)
            {
                pb1x15.Visible = true;
                pb1x15.Image = bankers_game_proto.Properties.Resources.Intern_s_hospital;
            }
            if (p4_gameplay.nationalhealthhospitaltr4 == 1 && p4_gameplay.p4trad == 1)
            {
                pb1x16.Visible = true;
                pb1x16.Image = bankers_game_proto.Properties.Resources.National_healths_hospital;
            }
            if (p4_gameplay.veteranshospitaltr4 == 1 && p4_gameplay.p4trad == 1)
            {
                pb1x17.Visible = true;
                pb1x17.Image = bankers_game_proto.Properties.Resources.VETERANS_Hospital;
            }

            if (p4_gameplay.pearlmalltr4 == 1 && p4_gameplay.p4trad == 1)
            {
                pb1x18.Visible = true;
                pb1x18.Image = bankers_game_proto.Properties.Resources.Pearl_Mall;
            }
            if (p4_gameplay.megamalltr4 == 1 && p4_gameplay.p4trad == 1)
            {
                pb1x19.Visible = true;
                pb1x19.Image = bankers_game_proto.Properties.Resources.Mega_mall;
            }
            if (p4_gameplay.articmalltr4 == 1 && p4_gameplay.p4trad == 1)
            {
                pb1x20.Visible = true;
                pb1x20.Image = bankers_game_proto.Properties.Resources.Artic_mall;

            }

            if (p4_gameplay.heavenlymalltr4 == 1 && p4_gameplay.p4trad == 1)
            {
                pb1x21.Visible = true;
                pb1x21.Image = bankers_game_proto.Properties.Resources.Heavenly_mall;

            }
            if (p4_gameplay.shangrillamalltr4 == 1 && p4_gameplay.p4trad == 1)
            {
                pb1x22.Visible = true;
                pb1x22.Image = bankers_game_proto.Properties.Resources.Shangrilla_Mall;

            }

            if (p4_gameplay.utility4x1tr4 == 1 && p4_gameplay.p4trad == 1)
            {
                pb1x23.Visible = true;
                pb1x23.Image = bankers_game_proto.Properties.Resources.Meralco;

            }
            if (p4_gameplay.utility4x2tr4 == 1 && p4_gameplay.p4trad == 1)
            {
                pb1x24.Visible = true;
                pb1x24.Image = bankers_game_proto.Properties.Resources.Niagra_Fall;

            }

            if (p4_gameplay.transportation4x1tr4 == 1 && p4_gameplay.p4trad == 1)
            {
                pb1x25.Visible = true;
                pb1x25.Image = bankers_game_proto.Properties.Resources.Rosevelt_Station;

            }
            if (p4_gameplay.transportation4x2tr4 == 1 && p4_gameplay.p4trad == 1)
            {
                pb1x26.Visible = true;
                pb1x26.Image = bankers_game_proto.Properties.Resources.Santolan_Station;
            }
            if (p4_gameplay.transportation4x3tr4 == 1 && p4_gameplay.p4trad == 1)
            {
                pb1x27.Visible = true;
                pb1x27.Image = bankers_game_proto.Properties.Resources.Quezon_Station;
            }
            if (p4_gameplay.transportation4x4tr4 == 1 && p4_gameplay.p4trad == 1)
            {
                pb1x28.Visible = true;
                pb1x28.Image = bankers_game_proto.Properties.Resources.Trinoma_Station;
            }
        }
        void trp1()
        {
            if (p4_gameplay.easternschooltr1 == 1 && p4_gameplay.p1 == 1)
            {
                pb2x1.Visible = true;
                pb2x1.Image = bankers_game_proto.Properties.Resources.Eastern_School_Purple_t;

            }
            if (p4_gameplay.westernschooltr1 == 1 && p4_gameplay.p1 == 1)
            {
                pb2x2.Visible = true;
                pb2x2.Image = bankers_game_proto.Properties.Resources.Western_school_t;
            }

            if (p4_gameplay.visayashighschooltr1 == 1 && p4_gameplay.p1 == 1)
            {
                pb2x3.Visible = true;
                pb2x3.Image = bankers_game_proto.Properties.Resources.Visayas_highschool_t;
            }
            if (p4_gameplay.southernschooltr1 == 1 && p4_gameplay.p1 == 1)
            {
                pb2x4.Visible = true;
                pb2x4.Image = bankers_game_proto.Properties.Resources.Southern_highschool_t;
            }
            if (p4_gameplay.nationsschooltr1 == 1 && p4_gameplay.p1 == 1)
            {
                pb2x5.Visible = true;
                pb2x5.Image = bankers_game_proto.Properties.Resources.Nation_s_highschool_t;
            }

            if (p4_gameplay.westmarkettr1 == 1 && p4_gameplay.p1 == 1)
            {
                pb2x6.Visible = true;
                pb2x6.Image = bankers_game_proto.Properties.Resources.West_Market_t;
            }
            if (p4_gameplay.nightmarkettr1 == 1 && p4_gameplay.p1 == 1)
            {
                pb2x7.Visible = true;
                pb2x7.Image = bankers_game_proto.Properties.Resources.Night_market_t;
            }
            if (p4_gameplay.daymarkettr1 == 1 && p4_gameplay.p1 == 1)
            {
                pb2x8.Visible = true;
                pb2x8.Image = bankers_game_proto.Properties.Resources.Day_market_t;
            }

            if (p4_gameplay.starmarkettr1 == 1 && p4_gameplay.p1 == 1)
            {
                pb2x9.Visible = true;
                pb2x9.Image = bankers_game_proto.Properties.Resources.Star_market_t;
            }
            if (p4_gameplay.moonmarkettr1 == 1 && p4_gameplay.p1 == 1)
            {
                pb2x10.Visible = true;
                pb2x10.Image = bankers_game_proto.Properties.Resources.Moon_market_t;
            }
            if (p4_gameplay.megamarkettr1 == 1 && p4_gameplay.p1 == 1)
            {
                pb2x11.Visible = true;
                pb2x11.Image = bankers_game_proto.Properties.Resources.Mega_market_t;
            }

            if (p4_gameplay.visayashospitaltr1 == 1 && p4_gameplay.p1 == 1)
            {
                pb2x12.Visible = true;
                pb2x12.Image = bankers_game_proto.Properties.Resources.Visayas_hospital_t;
            }
            if (p4_gameplay.hobertshospitaltr1 == 1 && p4_gameplay.p1 == 1)
            {
                pb2x13.Visible = true;
                pb2x13.Image = bankers_game_proto.Properties.Resources.Hobert_s_hospital_t;
            }
            if (p4_gameplay.heartshospitaltr1 == 1 && p4_gameplay.p1 == 1)
            {
                pb2x14.Visible = true;
                pb2x14.Image = bankers_game_proto.Properties.Resources.Hearts_hospital_t;
            }

            if (p4_gameplay.internshospitaltr1 == 1 && p4_gameplay.p1 == 1)
            {
                pb2x15.Visible = true;
                pb2x15.Image = bankers_game_proto.Properties.Resources.Intern_s_hospital_t;
            }
            if (p4_gameplay.nationalhealthhospitaltr1 == 1 && p4_gameplay.p1 == 1)
            {
                pb2x16.Visible = true;
                pb2x16.Image = bankers_game_proto.Properties.Resources.National_healths_hospital_t;
            }
            if (p4_gameplay.veteranshospitaltr1 == 1 && p4_gameplay.p1 == 1)
            {
                pb2x17.Visible = true;
                pb2x17.Image = bankers_game_proto.Properties.Resources.VETERANS_Hospital_t;
            }

            if (p4_gameplay.pearlmalltr1 == 1 && p4_gameplay.p1 == 1)
            {
                pb2x18.Visible = true;
                pb2x18.Image = bankers_game_proto.Properties.Resources.Pearl_Mall_t;
            }
            if (p4_gameplay.megamalltr1 == 1 && p4_gameplay.p1 == 1)
            {
                pb2x19.Visible = true;
                pb2x19.Image = bankers_game_proto.Properties.Resources.Mega_mall_t;
            }
            if (p4_gameplay.articmalltr1 == 1 && p4_gameplay.p1 == 1)
            {
                pb2x20.Visible = true;
                pb2x20.Image = bankers_game_proto.Properties.Resources.Artic_mall_t;

            }

            if (p4_gameplay.heavenlymalltr1 == 1 && p4_gameplay.p1 == 1)
            {
                pb2x21.Visible = true;
                pb2x21.Image = bankers_game_proto.Properties.Resources.Heavenly_mall_t;

            }
            if (p4_gameplay.shangrillamalltr1 == 1 && p4_gameplay.p1 == 1)
            {
                pb2x22.Visible = true;
                pb2x22.Image = bankers_game_proto.Properties.Resources.Shangrilla_Mall_t;

            }

            if (p4_gameplay.utility1x1tr1 == 1 && p4_gameplay.p1 == 1)
            {
                pb2x23.Visible = true;
                pb2x23.Image = bankers_game_proto.Properties.Resources.Meralco_t;

            }
            if (p4_gameplay.utility1x2tr1 == 1 && p4_gameplay.p1 == 1)
            {
                pb2x24.Visible = true;
                pb2x24.Image = bankers_game_proto.Properties.Resources.Niagra_Fall_t;

            }

            if (p4_gameplay.transportation1x1tr1 == 1 && p4_gameplay.p1 == 1)
            {
                pb2x25.Visible = true;
                pb2x25.Image = bankers_game_proto.Properties.Resources.Rosevelt_Station_t;

            }
            if (p4_gameplay.transportation1x2tr1 == 1 && p4_gameplay.p1 == 1)
            {
                pb2x26.Visible = true;
                pb2x26.Image = bankers_game_proto.Properties.Resources.Santolan_Station_t;
            }
            if (p4_gameplay.transportation1x3tr1 == 1 && p4_gameplay.p1 == 1)
            {
                pb2x27.Visible = true;
                pb2x27.Image = bankers_game_proto.Properties.Resources.Quezon_Station_t;
            }
            if (p4_gameplay.transportation1x4tr1 == 1 && p4_gameplay.p1 == 1)
            {
                pb2x28.Visible = true;
                pb2x28.Image = bankers_game_proto.Properties.Resources.Trinoma_Station_t;
            }
        }
        void trp2()
        {
            if (p4_gameplay.easternschooltr2 == 1 && p4_gameplay.p2 == 1)
            {
                pb2x1.Visible = true;
                pb2x1.Image = bankers_game_proto.Properties.Resources.Eastern_School_Purple_t;

            }
            if (p4_gameplay.westernschooltr2 == 1 && p4_gameplay.p2 == 1)
            {
                pb2x2.Visible = true;
                pb2x2.Image = bankers_game_proto.Properties.Resources.Western_school_t;
            }

            if (p4_gameplay.visayashighschooltr2 == 1 && p4_gameplay.p2 == 1)
            {
                pb2x3.Visible = true;
                pb2x3.Image = bankers_game_proto.Properties.Resources.Visayas_highschool_t;
            }
            if (p4_gameplay.southernschooltr2 == 1 && p4_gameplay.p2 == 1)
            {
                pb2x4.Visible = true;
                pb2x4.Image = bankers_game_proto.Properties.Resources.Southern_highschool_t;
            }
            if (p4_gameplay.nationsschooltr2 == 1 && p4_gameplay.p2 == 1)
            {
                pb2x5.Visible = true;
                pb2x5.Image = bankers_game_proto.Properties.Resources.Nation_s_highschool_t;
            }

            if (p4_gameplay.westmarkettr2 == 1 && p4_gameplay.p2 == 1)
            {
                pb2x6.Visible = true;
                pb2x6.Image = bankers_game_proto.Properties.Resources.West_Market_t;
            }
            if (p4_gameplay.nightmarkettr2 == 1 && p4_gameplay.p2 == 1)
            {
                pb2x7.Visible = true;
                pb2x7.Image = bankers_game_proto.Properties.Resources.Night_market_t;
            }
            if (p4_gameplay.daymarkettr2 == 1 && p4_gameplay.p2 == 1)
            {
                pb2x8.Visible = true;
                pb2x8.Image = bankers_game_proto.Properties.Resources.Day_market_t;
            }

            if (p4_gameplay.starmarkettr2 == 1 && p4_gameplay.p2 == 1)
            {
                pb2x9.Visible = true;
                pb2x9.Image = bankers_game_proto.Properties.Resources.Star_market_t;
            }
            if (p4_gameplay.moonmarkettr2 == 1 && p4_gameplay.p2 == 1)
            {
                pb2x10.Visible = true;
                pb2x10.Image = bankers_game_proto.Properties.Resources.Moon_market_t;
            }
            if (p4_gameplay.megamarkettr2 == 1 && p4_gameplay.p2 == 1)
            {
                pb2x11.Visible = true;
                pb2x11.Image = bankers_game_proto.Properties.Resources.Mega_market_t;
            }

            if (p4_gameplay.visayashospitaltr2 == 1 && p4_gameplay.p2 == 1)
            {
                pb2x12.Visible = true;
                pb2x12.Image = bankers_game_proto.Properties.Resources.Visayas_hospital_t;
            }
            if (p4_gameplay.hobertshospitaltr2 == 1 && p4_gameplay.p2 == 1)
            {
                pb2x13.Visible = true;
                pb2x13.Image = bankers_game_proto.Properties.Resources.Hobert_s_hospital_t;
            }
            if (p4_gameplay.heartshospitaltr2 == 1 && p4_gameplay.p2 == 1)
            {
                pb2x14.Visible = true;
                pb2x14.Image = bankers_game_proto.Properties.Resources.Hearts_hospital_t;
            }

            if (p4_gameplay.internshospitaltr2 == 1 && p4_gameplay.p2 == 1)
            {
                pb2x15.Visible = true;
                pb2x15.Image = bankers_game_proto.Properties.Resources.Intern_s_hospital_t;
            }
            if (p4_gameplay.nationalhealthhospitaltr2 == 1 && p4_gameplay.p2 == 1)
            {
                pb2x16.Visible = true;
                pb2x16.Image = bankers_game_proto.Properties.Resources.National_healths_hospital_t;
            }
            if (p4_gameplay.veteranshospitaltr2 == 1 && p4_gameplay.p2 == 1)
            {
                pb2x17.Visible = true;
                pb2x17.Image = bankers_game_proto.Properties.Resources.VETERANS_Hospital_t;
            }

            if (p4_gameplay.pearlmalltr2 == 1 && p4_gameplay.p2 == 1)
            {
                pb2x18.Visible = true;
                pb2x18.Image = bankers_game_proto.Properties.Resources.Pearl_Mall_t;
            }
            if (p4_gameplay.megamalltr2 == 1 && p4_gameplay.p2 == 1)
            {
                pb2x19.Visible = true;
                pb2x19.Image = bankers_game_proto.Properties.Resources.Mega_mall_t;
            }
            if (p4_gameplay.articmalltr2 == 1 && p4_gameplay.p2 == 1)
            {
                pb2x20.Visible = true;
                pb2x20.Image = bankers_game_proto.Properties.Resources.Artic_mall_t;

            }

            if (p4_gameplay.heavenlymalltr2 == 1 && p4_gameplay.p2 == 1)
            {
                pb2x21.Visible = true;
                pb2x21.Image = bankers_game_proto.Properties.Resources.Heavenly_mall_t;

            }
            if (p4_gameplay.shangrillamalltr2 == 1 && p4_gameplay.p2 == 1)
            {
                pb2x22.Visible = true;
                pb2x22.Image = bankers_game_proto.Properties.Resources.Shangrilla_Mall_t;

            }

            if (p4_gameplay.utility2x1tr2 == 1 && p4_gameplay.p2 == 1)
            {
                pb2x23.Visible = true;
                pb2x23.Image = bankers_game_proto.Properties.Resources.Meralco_t;

            }
            if (p4_gameplay.utility2x2tr2 == 1 && p4_gameplay.p2 == 1)
            {
                pb2x24.Visible = true;
                pb2x24.Image = bankers_game_proto.Properties.Resources.Niagra_Fall_t;

            }

            if (p4_gameplay.transportation2x1tr2 == 1 && p4_gameplay.p2 == 1)
            {
                pb2x25.Visible = true;
                pb2x25.Image = bankers_game_proto.Properties.Resources.Rosevelt_Station_t;

            }
            if (p4_gameplay.transportation2x2tr2 == 1 && p4_gameplay.p2 == 1)
            {
                pb2x26.Visible = true;
                pb2x26.Image = bankers_game_proto.Properties.Resources.Santolan_Station_t;
            }
            if (p4_gameplay.transportation2x3tr2 == 1 && p4_gameplay.p2 == 1)
            {
                pb2x27.Visible = true;
                pb2x27.Image = bankers_game_proto.Properties.Resources.Quezon_Station_t;
            }
            if (p4_gameplay.transportation2x4tr2 == 1 && p4_gameplay.p2 == 1)
            {
                pb2x28.Visible = true;
                pb2x28.Image = bankers_game_proto.Properties.Resources.Trinoma_Station_t;
            }
        }
        void trp3()
        {
            if (p4_gameplay.easternschooltr3 == 1 && p4_gameplay.p3 == 1)
            {
                pb2x1.Visible = true;
                pb2x1.Image = bankers_game_proto.Properties.Resources.Eastern_School_Purple_t;

            }
            if (p4_gameplay.westernschooltr3 == 1 && p4_gameplay.p3 == 1)
            {
                pb2x2.Visible = true;
                pb2x2.Image = bankers_game_proto.Properties.Resources.Western_school_t;
            }

            if (p4_gameplay.visayashighschooltr3 == 1 && p4_gameplay.p3 == 1)
            {
                pb2x3.Visible = true;
                pb2x3.Image = bankers_game_proto.Properties.Resources.Visayas_highschool_t;
            }
            if (p4_gameplay.southernschooltr3 == 1 && p4_gameplay.p3 == 1)
            {
                pb2x4.Visible = true;
                pb2x4.Image = bankers_game_proto.Properties.Resources.Southern_highschool_t;
            }
            if (p4_gameplay.nationsschooltr3 == 1 && p4_gameplay.p3 == 1)
            {
                pb2x5.Visible = true;
                pb2x5.Image = bankers_game_proto.Properties.Resources.Nation_s_highschool_t;
            }

            if (p4_gameplay.westmarkettr3 == 1 && p4_gameplay.p3 == 1)
            {
                pb2x6.Visible = true;
                pb2x6.Image = bankers_game_proto.Properties.Resources.West_Market_t;
            }
            if (p4_gameplay.nightmarkettr3 == 1 && p4_gameplay.p3 == 1)
            {
                pb2x7.Visible = true;
                pb2x7.Image = bankers_game_proto.Properties.Resources.Night_market_t;
            }
            if (p4_gameplay.daymarkettr3 == 1 && p4_gameplay.p3 == 1)
            {
                pb2x8.Visible = true;
                pb2x8.Image = bankers_game_proto.Properties.Resources.Day_market_t;
            }

            if (p4_gameplay.starmarkettr3 == 1 && p4_gameplay.p3 == 1)
            {
                pb2x9.Visible = true;
                pb2x9.Image = bankers_game_proto.Properties.Resources.Star_market_t;
            }
            if (p4_gameplay.moonmarkettr3 == 1 && p4_gameplay.p3 == 1)
            {
                pb2x10.Visible = true;
                pb2x10.Image = bankers_game_proto.Properties.Resources.Moon_market_t;
            }
            if (p4_gameplay.megamarkettr3 == 1 && p4_gameplay.p3 == 1)
            {
                pb2x11.Visible = true;
                pb2x11.Image = bankers_game_proto.Properties.Resources.Mega_market_t;
            }

            if (p4_gameplay.visayashospitaltr3 == 1 && p4_gameplay.p3 == 1)
            {
                pb2x12.Visible = true;
                pb2x12.Image = bankers_game_proto.Properties.Resources.Visayas_hospital_t;
            }
            if (p4_gameplay.hobertshospitaltr3 == 1 && p4_gameplay.p3 == 1)
            {
                pb2x13.Visible = true;
                pb2x13.Image = bankers_game_proto.Properties.Resources.Hobert_s_hospital_t;
            }
            if (p4_gameplay.heartshospitaltr3 == 1 && p4_gameplay.p3 == 1)
            {
                pb2x14.Visible = true;
                pb2x14.Image = bankers_game_proto.Properties.Resources.Hearts_hospital_t;
            }

            if (p4_gameplay.internshospitaltr3 == 1 && p4_gameplay.p3 == 1)
            {
                pb2x15.Visible = true;
                pb2x15.Image = bankers_game_proto.Properties.Resources.Intern_s_hospital_t;
            }
            if (p4_gameplay.nationalhealthhospitaltr3 == 1 && p4_gameplay.p3 == 1)
            {
                pb2x16.Visible = true;
                pb2x16.Image = bankers_game_proto.Properties.Resources.National_healths_hospital_t;
            }
            if (p4_gameplay.veteranshospitaltr3 == 1 && p4_gameplay.p3 == 1)
            {
                pb2x17.Visible = true;
                pb2x17.Image = bankers_game_proto.Properties.Resources.VETERANS_Hospital_t;
            }

            if (p4_gameplay.pearlmalltr3 == 1 && p4_gameplay.p3 == 1)
            {
                pb2x18.Visible = true;
                pb2x18.Image = bankers_game_proto.Properties.Resources.Pearl_Mall_t;
            }
            if (p4_gameplay.megamalltr3 == 1 && p4_gameplay.p3 == 1)
            {
                pb2x19.Visible = true;
                pb2x19.Image = bankers_game_proto.Properties.Resources.Mega_mall_t;
            }
            if (p4_gameplay.articmalltr3 == 1 && p4_gameplay.p3 == 1)
            {
                pb2x20.Visible = true;
                pb2x20.Image = bankers_game_proto.Properties.Resources.Artic_mall_t;

            }

            if (p4_gameplay.heavenlymalltr3 == 1 && p4_gameplay.p3 == 1)
            {
                pb2x21.Visible = true;
                pb2x21.Image = bankers_game_proto.Properties.Resources.Heavenly_mall_t;

            }
            if (p4_gameplay.shangrillamalltr3 == 1 && p4_gameplay.p3 == 1)
            {
                pb2x22.Visible = true;
                pb2x22.Image = bankers_game_proto.Properties.Resources.Shangrilla_Mall_t;

            }

            if (p4_gameplay.utility3x1tr3 == 1 && p4_gameplay.p3 == 1)
            {
                pb2x23.Visible = true;
                pb2x23.Image = bankers_game_proto.Properties.Resources.Meralco_t;

            }
            if (p4_gameplay.utility3x2tr3 == 1 && p4_gameplay.p3 == 1)
            {
                pb2x24.Visible = true;
                pb2x24.Image = bankers_game_proto.Properties.Resources.Niagra_Fall_t;

            }

            if (p4_gameplay.transportation3x1tr3 == 1 && p4_gameplay.p3 == 1)
            {
                pb2x25.Visible = true;
                pb2x25.Image = bankers_game_proto.Properties.Resources.Rosevelt_Station_t;

            }
            if (p4_gameplay.transportation3x2tr3 == 1 && p4_gameplay.p3 == 1)
            {
                pb2x26.Visible = true;
                pb2x26.Image = bankers_game_proto.Properties.Resources.Santolan_Station_t;
            }
            if (p4_gameplay.transportation3x3tr3 == 1 && p4_gameplay.p3 == 1)
            {
                pb2x27.Visible = true;
                pb2x27.Image = bankers_game_proto.Properties.Resources.Quezon_Station_t;
            }
            if (p4_gameplay.transportation3x4tr3 == 1 && p4_gameplay.p3 == 1)
            {
                pb2x28.Visible = true;
                pb2x28.Image = bankers_game_proto.Properties.Resources.Trinoma_Station_t;
            }
        }
        void trp4()
        {
            if (p4_gameplay.easternschooltr4 == 1 && p4_gameplay.p4 == 1)
            {
                pb2x1.Visible = true;
                pb2x1.Image = bankers_game_proto.Properties.Resources.Eastern_School_Purple_t;

            }
            if (p4_gameplay.westernschooltr4 == 1 && p4_gameplay.p4 == 1)
            {
                pb2x2.Visible = true;
                pb2x2.Image = bankers_game_proto.Properties.Resources.Western_school_t;
            }

            if (p4_gameplay.visayashighschooltr4 == 1 && p4_gameplay.p4 == 1)
            {
                pb2x3.Visible = true;
                pb2x3.Image = bankers_game_proto.Properties.Resources.Visayas_highschool_t;
            }
            if (p4_gameplay.southernschooltr4 == 1 && p4_gameplay.p4 == 1)
            {
                pb2x4.Visible = true;
                pb2x4.Image = bankers_game_proto.Properties.Resources.Southern_highschool_t;
            }
            if (p4_gameplay.nationsschooltr4 == 1 && p4_gameplay.p4 == 1)
            {
                pb2x5.Visible = true;
                pb2x5.Image = bankers_game_proto.Properties.Resources.Nation_s_highschool_t;
            }

            if (p4_gameplay.westmarkettr4 == 1 && p4_gameplay.p4 == 1)
            {
                pb2x6.Visible = true;
                pb2x6.Image = bankers_game_proto.Properties.Resources.West_Market_t;
            }
            if (p4_gameplay.nightmarkettr4 == 1 && p4_gameplay.p4 == 1)
            {
                pb2x7.Visible = true;
                pb2x7.Image = bankers_game_proto.Properties.Resources.Night_market_t;
            }
            if (p4_gameplay.daymarkettr4 == 1 && p4_gameplay.p4 == 1)
            {
                pb2x8.Visible = true;
                pb2x8.Image = bankers_game_proto.Properties.Resources.Day_market_t;
            }

            if (p4_gameplay.starmarkettr4 == 1 && p4_gameplay.p4 == 1)
            {
                pb2x9.Visible = true;
                pb2x9.Image = bankers_game_proto.Properties.Resources.Star_market_t;
            }
            if (p4_gameplay.moonmarkettr4 == 1 && p4_gameplay.p4 == 1)
            {
                pb2x10.Visible = true;
                pb2x10.Image = bankers_game_proto.Properties.Resources.Moon_market_t;
            }
            if (p4_gameplay.megamarkettr4 == 1 && p4_gameplay.p4 == 1)
            {
                pb2x11.Visible = true;
                pb2x11.Image = bankers_game_proto.Properties.Resources.Mega_market_t;
            }

            if (p4_gameplay.visayashospitaltr4 == 1 && p4_gameplay.p4 == 1)
            {
                pb2x12.Visible = true;
                pb2x12.Image = bankers_game_proto.Properties.Resources.Visayas_hospital_t;
            }
            if (p4_gameplay.hobertshospitaltr4 == 1 && p4_gameplay.p4 == 1)
            {
                pb2x13.Visible = true;
                pb2x13.Image = bankers_game_proto.Properties.Resources.Hobert_s_hospital_t;
            }
            if (p4_gameplay.heartshospitaltr4 == 1 && p4_gameplay.p4 == 1)
            {
                pb2x14.Visible = true;
                pb2x14.Image = bankers_game_proto.Properties.Resources.Hearts_hospital_t;
            }

            if (p4_gameplay.internshospitaltr4 == 1 && p4_gameplay.p4 == 1)
            {
                pb2x15.Visible = true;
                pb2x15.Image = bankers_game_proto.Properties.Resources.Intern_s_hospital_t;
            }
            if (p4_gameplay.nationalhealthhospitaltr4 == 1 && p4_gameplay.p4 == 1)
            {
                pb2x16.Visible = true;
                pb2x16.Image = bankers_game_proto.Properties.Resources.National_healths_hospital_t;
            }
            if (p4_gameplay.veteranshospitaltr4 == 1 && p4_gameplay.p4 == 1)
            {
                pb2x17.Visible = true;
                pb2x17.Image = bankers_game_proto.Properties.Resources.VETERANS_Hospital_t;
            }

            if (p4_gameplay.pearlmalltr4 == 1 && p4_gameplay.p4 == 1)
            {
                pb2x18.Visible = true;
                pb2x18.Image = bankers_game_proto.Properties.Resources.Pearl_Mall_t;
            }
            if (p4_gameplay.megamalltr4 == 1 && p4_gameplay.p4 == 1)
            {
                pb2x19.Visible = true;
                pb2x19.Image = bankers_game_proto.Properties.Resources.Mega_mall_t;
            }
            if (p4_gameplay.articmalltr4 == 1 && p4_gameplay.p4 == 1)
            {
                pb2x20.Visible = true;
                pb2x20.Image = bankers_game_proto.Properties.Resources.Artic_mall_t;

            }

            if (p4_gameplay.heavenlymalltr4 == 1 && p4_gameplay.p4 == 1)
            {
                pb2x21.Visible = true;
                pb2x21.Image = bankers_game_proto.Properties.Resources.Heavenly_mall_t;

            }
            if (p4_gameplay.shangrillamalltr4 == 1 && p4_gameplay.p4 == 1)
            {
                pb2x22.Visible = true;
                pb2x22.Image = bankers_game_proto.Properties.Resources.Shangrilla_Mall_t;

            }

            if (p4_gameplay.utility4x1tr4 == 1 && p4_gameplay.p4 == 1)
            {
                pb2x23.Visible = true;
                pb2x23.Image = bankers_game_proto.Properties.Resources.Meralco_t;

            }
            if (p4_gameplay.utility4x2tr4 == 1 && p4_gameplay.p4 == 1)
            {
                pb2x24.Visible = true;
                pb2x24.Image = bankers_game_proto.Properties.Resources.Niagra_Fall_t;

            }

            if (p4_gameplay.transportation4x1tr4 == 1 && p4_gameplay.p4 == 1)
            {
                pb2x25.Visible = true;
                pb2x25.Image = bankers_game_proto.Properties.Resources.Rosevelt_Station_t;

            }
            if (p4_gameplay.transportation4x2tr4 == 1 && p4_gameplay.p4 == 1)
            {
                pb2x26.Visible = true;
                pb2x26.Image = bankers_game_proto.Properties.Resources.Santolan_Station_t;
            }
            if (p4_gameplay.transportation4x3tr4 == 1 && p4_gameplay.p4 == 1)
            {
                pb2x27.Visible = true;
                pb2x27.Image = bankers_game_proto.Properties.Resources.Quezon_Station_t;
            }
            if (p4_gameplay.transportation4x4tr4 == 1 && p4_gameplay.p4 == 1)
            {
                pb2x28.Visible = true;
                pb2x28.Image = bankers_game_proto.Properties.Resources.Trinoma_Station_t;
            }
        }
        void turn1()
        {

            if (p1trad == 1 && p2 == 0)
            {
                det = 0;
                btnp2.Enabled = false;
                btnp1.Enabled = true;
                btnp2.Enabled = false;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                pb2x1.Enabled = true;
                pb2x2.Enabled = true;
                pb2x3.Enabled = true;
                pb2x4.Enabled = true;
                pb2x5.Enabled = true;
                pb2x6.Enabled = true;
                pb2x7.Enabled = true;
                pb2x8.Enabled = true;
                pb2x9.Enabled = true;
                pb2x10.Enabled = true;
                pb2x11.Enabled = true;
                pb2x12.Enabled = true;
                pb2x13.Enabled = true;
                pb2x14.Enabled = true;
                pb2x15.Enabled = true;
                pb2x16.Enabled = true;
                pb2x17.Enabled = true;
                pb2x18.Enabled = true;
                pb2x19.Enabled = true;
                pb2x20.Enabled = true;
                pb2x21.Enabled = true;
                pb2x22.Enabled = true;
                pb2x23.Enabled = true;
                pb2x24.Enabled = true;
                pb2x25.Enabled = true;
                pb2x26.Enabled = true;
                pb2x27.Enabled = true;
                pb2x28.Enabled = true;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
            }

            if (p1trad == 1 && p3 == 0)
            {
                det = 0;
                btnp2.Enabled = false;
                btnp1.Enabled = true;
                btnp2.Enabled = false;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                pb2x1.Enabled = true;
                pb2x2.Enabled = true;
                pb2x3.Enabled = true;
                pb2x4.Enabled = true;
                pb2x5.Enabled = true;
                pb2x6.Enabled = true;
                pb2x7.Enabled = true;
                pb2x8.Enabled = true;
                pb2x9.Enabled = true;
                pb2x10.Enabled = true;
                pb2x11.Enabled = true;
                pb2x12.Enabled = true;
                pb2x13.Enabled = true;
                pb2x14.Enabled = true;
                pb2x15.Enabled = true;
                pb2x16.Enabled = true;
                pb2x17.Enabled = true;
                pb2x18.Enabled = true;
                pb2x19.Enabled = true;
                pb2x20.Enabled = true;
                pb2x21.Enabled = true;
                pb2x22.Enabled = true;
                pb2x23.Enabled = true;
                pb2x24.Enabled = true;
                pb2x25.Enabled = true;
                pb2x26.Enabled = true;
                pb2x27.Enabled = true;
                pb2x28.Enabled = true;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
            }


            if (p1trad == 1 && p4 == 0)
            {
                det = 0;
                btnp2.Enabled = false;
                btnp1.Enabled = true;
                btnp2.Enabled = false;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                pb2x1.Enabled = true;
                pb2x2.Enabled = true;
                pb2x3.Enabled = true;
                pb2x4.Enabled = true;
                pb2x5.Enabled = true;
                pb2x6.Enabled = true;
                pb2x7.Enabled = true;
                pb2x8.Enabled = true;
                pb2x9.Enabled = true;
                pb2x10.Enabled = true;
                pb2x11.Enabled = true;
                pb2x12.Enabled = true;
                pb2x13.Enabled = true;
                pb2x14.Enabled = true;
                pb2x15.Enabled = true;
                pb2x16.Enabled = true;
                pb2x17.Enabled = true;
                pb2x18.Enabled = true;
                pb2x19.Enabled = true;
                pb2x20.Enabled = true;
                pb2x21.Enabled = true;
                pb2x22.Enabled = true;
                pb2x23.Enabled = true;
                pb2x24.Enabled = true;
                pb2x25.Enabled = true;
                pb2x26.Enabled = true;
                pb2x27.Enabled = true;
                pb2x28.Enabled = true;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
            }


            if (p2trad == 1 && p1 == 0)
            {
                det = 0;
                btnp2.Enabled = false;
                btnp1.Enabled = true;
                btnp2.Enabled = false;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                pb2x1.Enabled = true;
                pb2x2.Enabled = true;
                pb2x3.Enabled = true;
                pb2x4.Enabled = true;
                pb2x5.Enabled = true;
                pb2x6.Enabled = true;
                pb2x7.Enabled = true;
                pb2x8.Enabled = true;
                pb2x9.Enabled = true;
                pb2x10.Enabled = true;
                pb2x11.Enabled = true;
                pb2x12.Enabled = true;
                pb2x13.Enabled = true;
                pb2x14.Enabled = true;
                pb2x15.Enabled = true;
                pb2x16.Enabled = true;
                pb2x17.Enabled = true;
                pb2x18.Enabled = true;
                pb2x19.Enabled = true;
                pb2x20.Enabled = true;
                pb2x21.Enabled = true;
                pb2x22.Enabled = true;
                pb2x23.Enabled = true;
                pb2x24.Enabled = true;
                pb2x25.Enabled = true;
                pb2x26.Enabled = true;
                pb2x27.Enabled = true;
                pb2x28.Enabled = true;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
            }



            if (p2trad == 1 && p3 == 0)
            {
                det = 0;
                btnp2.Enabled = false;
                btnp1.Enabled = true;
                btnp2.Enabled = false;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                pb2x1.Enabled = true;
                pb2x2.Enabled = true;
                pb2x3.Enabled = true;
                pb2x4.Enabled = true;
                pb2x5.Enabled = true;
                pb2x6.Enabled = true;
                pb2x7.Enabled = true;
                pb2x8.Enabled = true;
                pb2x9.Enabled = true;
                pb2x10.Enabled = true;
                pb2x11.Enabled = true;
                pb2x12.Enabled = true;
                pb2x13.Enabled = true;
                pb2x14.Enabled = true;
                pb2x15.Enabled = true;
                pb2x16.Enabled = true;
                pb2x17.Enabled = true;
                pb2x18.Enabled = true;
                pb2x19.Enabled = true;
                pb2x20.Enabled = true;
                pb2x21.Enabled = true;
                pb2x22.Enabled = true;
                pb2x23.Enabled = true;
                pb2x24.Enabled = true;
                pb2x25.Enabled = true;
                pb2x26.Enabled = true;
                pb2x27.Enabled = true;
                pb2x28.Enabled = true;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
            }


            if (p2trad == 1 && p4 == 0)
            {
                det = 0;
                btnp2.Enabled = false;
                btnp1.Enabled = true;
                btnp2.Enabled = false;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                pb2x1.Enabled = true;
                pb2x2.Enabled = true;
                pb2x3.Enabled = true;
                pb2x4.Enabled = true;
                pb2x5.Enabled = true;
                pb2x6.Enabled = true;
                pb2x7.Enabled = true;
                pb2x8.Enabled = true;
                pb2x9.Enabled = true;
                pb2x10.Enabled = true;
                pb2x11.Enabled = true;
                pb2x12.Enabled = true;
                pb2x13.Enabled = true;
                pb2x14.Enabled = true;
                pb2x15.Enabled = true;
                pb2x16.Enabled = true;
                pb2x17.Enabled = true;
                pb2x18.Enabled = true;
                pb2x19.Enabled = true;
                pb2x20.Enabled = true;
                pb2x21.Enabled = true;
                pb2x22.Enabled = true;
                pb2x23.Enabled = true;
                pb2x24.Enabled = true;
                pb2x25.Enabled = true;
                pb2x26.Enabled = true;
                pb2x27.Enabled = true;
                pb2x28.Enabled = true;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
            }


            if (p3trad == 1 && p1 == 0)
            {
                det = 0;
                btnp2.Enabled = false;
                btnp1.Enabled = true;
                btnp2.Enabled = false;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                pb2x1.Enabled = true;
                pb2x2.Enabled = true;
                pb2x3.Enabled = true;
                pb2x4.Enabled = true;
                pb2x5.Enabled = true;
                pb2x6.Enabled = true;
                pb2x7.Enabled = true;
                pb2x8.Enabled = true;
                pb2x9.Enabled = true;
                pb2x10.Enabled = true;
                pb2x11.Enabled = true;
                pb2x12.Enabled = true;
                pb2x13.Enabled = true;
                pb2x14.Enabled = true;
                pb2x15.Enabled = true;
                pb2x16.Enabled = true;
                pb2x17.Enabled = true;
                pb2x18.Enabled = true;
                pb2x19.Enabled = true;
                pb2x20.Enabled = true;
                pb2x21.Enabled = true;
                pb2x22.Enabled = true;
                pb2x23.Enabled = true;
                pb2x24.Enabled = true;
                pb2x25.Enabled = true;
                pb2x26.Enabled = true;
                pb2x27.Enabled = true;
                pb2x28.Enabled = true;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
            }



            if (p3trad == 1 && p2 == 0)
            {
                det = 0;
                btnp2.Enabled = false;
                btnp1.Enabled = true;
                btnp2.Enabled = false;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                pb2x1.Enabled = true;
                pb2x2.Enabled = true;
                pb2x3.Enabled = true;
                pb2x4.Enabled = true;
                pb2x5.Enabled = true;
                pb2x6.Enabled = true;
                pb2x7.Enabled = true;
                pb2x8.Enabled = true;
                pb2x9.Enabled = true;
                pb2x10.Enabled = true;
                pb2x11.Enabled = true;
                pb2x12.Enabled = true;
                pb2x13.Enabled = true;
                pb2x14.Enabled = true;
                pb2x15.Enabled = true;
                pb2x16.Enabled = true;
                pb2x17.Enabled = true;
                pb2x18.Enabled = true;
                pb2x19.Enabled = true;
                pb2x20.Enabled = true;
                pb2x21.Enabled = true;
                pb2x22.Enabled = true;
                pb2x23.Enabled = true;
                pb2x24.Enabled = true;
                pb2x25.Enabled = true;
                pb2x26.Enabled = true;
                pb2x27.Enabled = true;
                pb2x28.Enabled = true;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
            }

            if (p3trad == 1 && p4 == 0)
            {
                det = 0;
                btnp2.Enabled = false;
                btnp1.Enabled = true;
                btnp2.Enabled = false;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                pb2x1.Enabled = true;
                pb2x2.Enabled = true;
                pb2x3.Enabled = true;
                pb2x4.Enabled = true;
                pb2x5.Enabled = true;
                pb2x6.Enabled = true;
                pb2x7.Enabled = true;
                pb2x8.Enabled = true;
                pb2x9.Enabled = true;
                pb2x10.Enabled = true;
                pb2x11.Enabled = true;
                pb2x12.Enabled = true;
                pb2x13.Enabled = true;
                pb2x14.Enabled = true;
                pb2x15.Enabled = true;
                pb2x16.Enabled = true;
                pb2x17.Enabled = true;
                pb2x18.Enabled = true;
                pb2x19.Enabled = true;
                pb2x20.Enabled = true;
                pb2x21.Enabled = true;
                pb2x22.Enabled = true;
                pb2x23.Enabled = true;
                pb2x24.Enabled = true;
                pb2x25.Enabled = true;
                pb2x26.Enabled = true;
                pb2x27.Enabled = true;
                pb2x28.Enabled = true;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
            }


            if (p4trad == 1 && p1 == 0)
            {
                det = 0;
                btnp2.Enabled = false;
                btnp1.Enabled = true;
                btnp2.Enabled = false;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                pb2x1.Enabled = true;
                pb2x2.Enabled = true;
                pb2x3.Enabled = true;
                pb2x4.Enabled = true;
                pb2x5.Enabled = true;
                pb2x6.Enabled = true;
                pb2x7.Enabled = true;
                pb2x8.Enabled = true;
                pb2x9.Enabled = true;
                pb2x10.Enabled = true;
                pb2x11.Enabled = true;
                pb2x12.Enabled = true;
                pb2x13.Enabled = true;
                pb2x14.Enabled = true;
                pb2x15.Enabled = true;
                pb2x16.Enabled = true;
                pb2x17.Enabled = true;
                pb2x18.Enabled = true;
                pb2x19.Enabled = true;
                pb2x20.Enabled = true;
                pb2x21.Enabled = true;
                pb2x22.Enabled = true;
                pb2x23.Enabled = true;
                pb2x24.Enabled = true;
                pb2x25.Enabled = true;
                pb2x26.Enabled = true;
                pb2x27.Enabled = true;
                pb2x28.Enabled = true;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
            }



            if (p4trad == 1 && p2 == 0)
            {
                det = 0;
                btnp2.Enabled = false;
                btnp1.Enabled = true;
                btnp2.Enabled = false;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                pb2x1.Enabled = true;
                pb2x2.Enabled = true;
                pb2x3.Enabled = true;
                pb2x4.Enabled = true;
                pb2x5.Enabled = true;
                pb2x6.Enabled = true;
                pb2x7.Enabled = true;
                pb2x8.Enabled = true;
                pb2x9.Enabled = true;
                pb2x10.Enabled = true;
                pb2x11.Enabled = true;
                pb2x12.Enabled = true;
                pb2x13.Enabled = true;
                pb2x14.Enabled = true;
                pb2x15.Enabled = true;
                pb2x16.Enabled = true;
                pb2x17.Enabled = true;
                pb2x18.Enabled = true;
                pb2x19.Enabled = true;
                pb2x20.Enabled = true;
                pb2x21.Enabled = true;
                pb2x22.Enabled = true;
                pb2x23.Enabled = true;
                pb2x24.Enabled = true;
                pb2x25.Enabled = true;
                pb2x26.Enabled = true;
                pb2x27.Enabled = true;
                pb2x28.Enabled = true;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
            }


            if (p4trad == 1 && p3 == 0)
            {
                det = 0;
                btnp2.Enabled = false;
                btnp1.Enabled = true;
                btnp2.Enabled = false;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                pb2x1.Enabled = true;
                pb2x2.Enabled = true;
                pb2x3.Enabled = true;
                pb2x4.Enabled = true;
                pb2x5.Enabled = true;
                pb2x6.Enabled = true;
                pb2x7.Enabled = true;
                pb2x8.Enabled = true;
                pb2x9.Enabled = true;
                pb2x10.Enabled = true;
                pb2x11.Enabled = true;
                pb2x12.Enabled = true;
                pb2x13.Enabled = true;
                pb2x14.Enabled = true;
                pb2x15.Enabled = true;
                pb2x16.Enabled = true;
                pb2x17.Enabled = true;
                pb2x18.Enabled = true;
                pb2x19.Enabled = true;
                pb2x20.Enabled = true;
                pb2x21.Enabled = true;
                pb2x22.Enabled = true;
                pb2x23.Enabled = true;
                pb2x24.Enabled = true;
                pb2x25.Enabled = true;
                pb2x26.Enabled = true;
                pb2x27.Enabled = true;
                pb2x28.Enabled = true;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
            }
        }
        void turn2()
        {

            if (p1trad == 0 && p2 == 1)
            {
                det = 0;
                btnp2.Enabled = true;
                btnp1.Enabled = false;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                pb1x1.Enabled = true;
                pb1x2.Enabled = true;
                pb1x3.Enabled = true;
                pb1x4.Enabled = true;
                pb1x5.Enabled = true;
                pb1x6.Enabled = true;
                pb1x7.Enabled = true;
                pb1x8.Enabled = true;
                pb1x9.Enabled = true;
                pb1x10.Enabled = true;
                pb1x11.Enabled = true;
                pb1x12.Enabled = true;
                pb1x13.Enabled = true;
                pb1x14.Enabled = true;
                pb1x15.Enabled = true;
                pb1x16.Enabled = true;
                pb1x17.Enabled = true;
                pb1x18.Enabled = true;
                pb1x19.Enabled = true;
                pb1x20.Enabled = true;
                pb1x21.Enabled = true;
                pb1x22.Enabled = true;
                pb1x23.Enabled = true;
                pb1x24.Enabled = true;
                pb1x25.Enabled = true;
                pb1x26.Enabled = true;
                pb1x27.Enabled = true;
                pb1x28.Enabled = true;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();

            }
            if (p1trad == 0 && p3 == 1)
            {
                det = 0;
                btnp2.Enabled = true;
                btnp1.Enabled = false;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                pb1x1.Enabled = true;
                pb1x2.Enabled = true;
                pb1x3.Enabled = true;
                pb1x4.Enabled = true;
                pb1x5.Enabled = true;
                pb1x6.Enabled = true;
                pb1x7.Enabled = true;
                pb1x8.Enabled = true;
                pb1x9.Enabled = true;
                pb1x10.Enabled = true;
                pb1x11.Enabled = true;
                pb1x12.Enabled = true;
                pb1x13.Enabled = true;
                pb1x14.Enabled = true;
                pb1x15.Enabled = true;
                pb1x16.Enabled = true;
                pb1x17.Enabled = true;
                pb1x18.Enabled = true;
                pb1x19.Enabled = true;
                pb1x20.Enabled = true;
                pb1x21.Enabled = true;
                pb1x22.Enabled = true;
                pb1x23.Enabled = true;
                pb1x24.Enabled = true;
                pb1x25.Enabled = true;
                pb1x26.Enabled = true;
                pb1x27.Enabled = true;
                pb1x28.Enabled = true;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();

            }
            if (p1trad == 0 && p4 == 1)
            {
                det = 0;
                btnp2.Enabled = true;
                btnp1.Enabled = false;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                pb1x1.Enabled = true;
                pb1x2.Enabled = true;
                pb1x3.Enabled = true;
                pb1x4.Enabled = true;
                pb1x5.Enabled = true;
                pb1x6.Enabled = true;
                pb1x7.Enabled = true;
                pb1x8.Enabled = true;
                pb1x9.Enabled = true;
                pb1x10.Enabled = true;
                pb1x11.Enabled = true;
                pb1x12.Enabled = true;
                pb1x13.Enabled = true;
                pb1x14.Enabled = true;
                pb1x15.Enabled = true;
                pb1x16.Enabled = true;
                pb1x17.Enabled = true;
                pb1x18.Enabled = true;
                pb1x19.Enabled = true;
                pb1x20.Enabled = true;
                pb1x21.Enabled = true;
                pb1x22.Enabled = true;
                pb1x23.Enabled = true;
                pb1x24.Enabled = true;
                pb1x25.Enabled = true;
                pb1x26.Enabled = true;
                pb1x27.Enabled = true;
                pb1x28.Enabled = true;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();

            }

            if (p2trad == 0 && p1 == 1)
            {
                det = 0;
                btnp2.Enabled = true;
                btnp1.Enabled = false;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                pb1x1.Enabled = true;
                pb1x2.Enabled = true;
                pb1x3.Enabled = true;
                pb1x4.Enabled = true;
                pb1x5.Enabled = true;
                pb1x6.Enabled = true;
                pb1x7.Enabled = true;
                pb1x8.Enabled = true;
                pb1x9.Enabled = true;
                pb1x10.Enabled = true;
                pb1x11.Enabled = true;
                pb1x12.Enabled = true;
                pb1x13.Enabled = true;
                pb1x14.Enabled = true;
                pb1x15.Enabled = true;
                pb1x16.Enabled = true;
                pb1x17.Enabled = true;
                pb1x18.Enabled = true;
                pb1x19.Enabled = true;
                pb1x20.Enabled = true;
                pb1x21.Enabled = true;
                pb1x22.Enabled = true;
                pb1x23.Enabled = true;
                pb1x24.Enabled = true;
                pb1x25.Enabled = true;
                pb1x26.Enabled = true;
                pb1x27.Enabled = true;
                pb1x28.Enabled = true;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();

            }
            if (p2trad == 0 && p3 == 1)
            {
                det = 0;
                btnp2.Enabled = true;
                btnp1.Enabled = false;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                pb1x1.Enabled = true;
                pb1x2.Enabled = true;
                pb1x3.Enabled = true;
                pb1x4.Enabled = true;
                pb1x5.Enabled = true;
                pb1x6.Enabled = true;
                pb1x7.Enabled = true;
                pb1x8.Enabled = true;
                pb1x9.Enabled = true;
                pb1x10.Enabled = true;
                pb1x11.Enabled = true;
                pb1x12.Enabled = true;
                pb1x13.Enabled = true;
                pb1x14.Enabled = true;
                pb1x15.Enabled = true;
                pb1x16.Enabled = true;
                pb1x17.Enabled = true;
                pb1x18.Enabled = true;
                pb1x19.Enabled = true;
                pb1x20.Enabled = true;
                pb1x21.Enabled = true;
                pb1x22.Enabled = true;
                pb1x23.Enabled = true;
                pb1x24.Enabled = true;
                pb1x25.Enabled = true;
                pb1x26.Enabled = true;
                pb1x27.Enabled = true;
                pb1x28.Enabled = true;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();

            }
            if (p2trad == 0 && p4 == 1)
            {
                det = 0;
                btnp2.Enabled = true;
                btnp1.Enabled = false;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                pb1x1.Enabled = true;
                pb1x2.Enabled = true;
                pb1x3.Enabled = true;
                pb1x4.Enabled = true;
                pb1x5.Enabled = true;
                pb1x6.Enabled = true;
                pb1x7.Enabled = true;
                pb1x8.Enabled = true;
                pb1x9.Enabled = true;
                pb1x10.Enabled = true;
                pb1x11.Enabled = true;
                pb1x12.Enabled = true;
                pb1x13.Enabled = true;
                pb1x14.Enabled = true;
                pb1x15.Enabled = true;
                pb1x16.Enabled = true;
                pb1x17.Enabled = true;
                pb1x18.Enabled = true;
                pb1x19.Enabled = true;
                pb1x20.Enabled = true;
                pb1x21.Enabled = true;
                pb1x22.Enabled = true;
                pb1x23.Enabled = true;
                pb1x24.Enabled = true;
                pb1x25.Enabled = true;
                pb1x26.Enabled = true;
                pb1x27.Enabled = true;
                pb1x28.Enabled = true;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();

            }

            if (p3trad == 0 && p1 == 1)
            {
                det = 0;
                btnp2.Enabled = true;
                btnp1.Enabled = false;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                pb1x1.Enabled = true;
                pb1x2.Enabled = true;
                pb1x3.Enabled = true;
                pb1x4.Enabled = true;
                pb1x5.Enabled = true;
                pb1x6.Enabled = true;
                pb1x7.Enabled = true;
                pb1x8.Enabled = true;
                pb1x9.Enabled = true;
                pb1x10.Enabled = true;
                pb1x11.Enabled = true;
                pb1x12.Enabled = true;
                pb1x13.Enabled = true;
                pb1x14.Enabled = true;
                pb1x15.Enabled = true;
                pb1x16.Enabled = true;
                pb1x17.Enabled = true;
                pb1x18.Enabled = true;
                pb1x19.Enabled = true;
                pb1x20.Enabled = true;
                pb1x21.Enabled = true;
                pb1x22.Enabled = true;
                pb1x23.Enabled = true;
                pb1x24.Enabled = true;
                pb1x25.Enabled = true;
                pb1x26.Enabled = true;
                pb1x27.Enabled = true;
                pb1x28.Enabled = true;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();

            }
            if (p3trad == 0 && p2 == 1)
            {
                det = 0;
                btnp2.Enabled = true;
                btnp1.Enabled = false;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                pb1x1.Enabled = true;
                pb1x2.Enabled = true;
                pb1x3.Enabled = true;
                pb1x4.Enabled = true;
                pb1x5.Enabled = true;
                pb1x6.Enabled = true;
                pb1x7.Enabled = true;
                pb1x8.Enabled = true;
                pb1x9.Enabled = true;
                pb1x10.Enabled = true;
                pb1x11.Enabled = true;
                pb1x12.Enabled = true;
                pb1x13.Enabled = true;
                pb1x14.Enabled = true;
                pb1x15.Enabled = true;
                pb1x16.Enabled = true;
                pb1x17.Enabled = true;
                pb1x18.Enabled = true;
                pb1x19.Enabled = true;
                pb1x20.Enabled = true;
                pb1x21.Enabled = true;
                pb1x22.Enabled = true;
                pb1x23.Enabled = true;
                pb1x24.Enabled = true;
                pb1x25.Enabled = true;
                pb1x26.Enabled = true;
                pb1x27.Enabled = true;
                pb1x28.Enabled = true;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();

            }
            if (p3trad == 0 && p4 == 1)
            {
                det = 0;
                btnp2.Enabled = true;
                btnp1.Enabled = false;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                pb1x1.Enabled = true;
                pb1x2.Enabled = true;
                pb1x3.Enabled = true;
                pb1x4.Enabled = true;
                pb1x5.Enabled = true;
                pb1x6.Enabled = true;
                pb1x7.Enabled = true;
                pb1x8.Enabled = true;
                pb1x9.Enabled = true;
                pb1x10.Enabled = true;
                pb1x11.Enabled = true;
                pb1x12.Enabled = true;
                pb1x13.Enabled = true;
                pb1x14.Enabled = true;
                pb1x15.Enabled = true;
                pb1x16.Enabled = true;
                pb1x17.Enabled = true;
                pb1x18.Enabled = true;
                pb1x19.Enabled = true;
                pb1x20.Enabled = true;
                pb1x21.Enabled = true;
                pb1x22.Enabled = true;
                pb1x23.Enabled = true;
                pb1x24.Enabled = true;
                pb1x25.Enabled = true;
                pb1x26.Enabled = true;
                pb1x27.Enabled = true;
                pb1x28.Enabled = true;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();

            }

            if (p4trad == 0 && p1 == 1)
            {
                det = 0;
                btnp2.Enabled = true;
                btnp1.Enabled = false;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                pb1x1.Enabled = true;
                pb1x2.Enabled = true;
                pb1x3.Enabled = true;
                pb1x4.Enabled = true;
                pb1x5.Enabled = true;
                pb1x6.Enabled = true;
                pb1x7.Enabled = true;
                pb1x8.Enabled = true;
                pb1x9.Enabled = true;
                pb1x10.Enabled = true;
                pb1x11.Enabled = true;
                pb1x12.Enabled = true;
                pb1x13.Enabled = true;
                pb1x14.Enabled = true;
                pb1x15.Enabled = true;
                pb1x16.Enabled = true;
                pb1x17.Enabled = true;
                pb1x18.Enabled = true;
                pb1x19.Enabled = true;
                pb1x20.Enabled = true;
                pb1x21.Enabled = true;
                pb1x22.Enabled = true;
                pb1x23.Enabled = true;
                pb1x24.Enabled = true;
                pb1x25.Enabled = true;
                pb1x26.Enabled = true;
                pb1x27.Enabled = true;
                pb1x28.Enabled = true;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();

            }
            if (p4trad == 0 && p2 == 1)
            {
                det = 0;
                btnp2.Enabled = true;
                btnp1.Enabled = false;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                pb1x1.Enabled = true;
                pb1x2.Enabled = true;
                pb1x3.Enabled = true;
                pb1x4.Enabled = true;
                pb1x5.Enabled = true;
                pb1x6.Enabled = true;
                pb1x7.Enabled = true;
                pb1x8.Enabled = true;
                pb1x9.Enabled = true;
                pb1x10.Enabled = true;
                pb1x11.Enabled = true;
                pb1x12.Enabled = true;
                pb1x13.Enabled = true;
                pb1x14.Enabled = true;
                pb1x15.Enabled = true;
                pb1x16.Enabled = true;
                pb1x17.Enabled = true;
                pb1x18.Enabled = true;
                pb1x19.Enabled = true;
                pb1x20.Enabled = true;
                pb1x21.Enabled = true;
                pb1x22.Enabled = true;
                pb1x23.Enabled = true;
                pb1x24.Enabled = true;
                pb1x25.Enabled = true;
                pb1x26.Enabled = true;
                pb1x27.Enabled = true;
                pb1x28.Enabled = true;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();

            }
            if (p4trad == 0 && p3 == 1)
            {
                det = 0;
                btnp2.Enabled = true;
                btnp1.Enabled = false;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                pb1x1.Enabled = true;
                pb1x2.Enabled = true;
                pb1x3.Enabled = true;
                pb1x4.Enabled = true;
                pb1x5.Enabled = true;
                pb1x6.Enabled = true;
                pb1x7.Enabled = true;
                pb1x8.Enabled = true;
                pb1x9.Enabled = true;
                pb1x10.Enabled = true;
                pb1x11.Enabled = true;
                pb1x12.Enabled = true;
                pb1x13.Enabled = true;
                pb1x14.Enabled = true;
                pb1x15.Enabled = true;
                pb1x16.Enabled = true;
                pb1x17.Enabled = true;
                pb1x18.Enabled = true;
                pb1x19.Enabled = true;
                pb1x20.Enabled = true;
                pb1x21.Enabled = true;
                pb1x22.Enabled = true;
                pb1x23.Enabled = true;
                pb1x24.Enabled = true;
                pb1x25.Enabled = true;
                pb1x26.Enabled = true;
                pb1x27.Enabled = true;
                pb1x28.Enabled = true;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();

            }

        }
        void turnedd1()
        {
            if (p1trad == 1 && p2 == 0 && p4_gameplay.p2tr == 1)
            {
                p2traded2();
                p1trtraded1();
                
                p2 = 1;
                p1trad = 0;
                p4_gameplay.p2tr = 0;

                
                

                turn2();

                btnacc1.Visible = false;
                btndec1.Visible = false;
                btnacc2.Visible = false;
                btndec2.Visible = false;
                p1tr.Visible = false;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                notif1.Visible = false;
                notif2.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p2tr.Visible = false;
                pbdet2.Visible = false;

                p1lvw.Items.Clear();
                p2lvw.Items.Clear();

                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;


            }

            if (p1trad == 1 && p3 == 0 && p4_gameplay.p3tr == 1)
            {
            
                p3 = 1;
                p1trad = 0;    
                p3traded3();
                p1trtraded1_3();
                p4_gameplay.p3tr = 0;
                turn2();



                btnacc1.Visible = false;
                btndec1.Visible = false;
                btnacc2.Visible = false;
                btndec2.Visible = false;
                p1tr.Visible = false;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;


            }

            if (p1trad == 1 && p4 == 0 && p4_gameplay.p4tr == 1)
            {
                p4traded4();
                p1trtraded1_4();
                p4 = 1;
                p1trad = 0;
                p4_gameplay.p4tr = 0;
                turn2();



                btnacc1.Visible = false;
                btndec1.Visible = false;
                btnacc2.Visible = false;
                btndec2.Visible = false;
                p1tr.Visible = false;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;
            }


        }
        void turnedd1_2()
        {
            if (p2trad == 1 && p1 == 0 && p4_gameplay.p1tr == 1)
            {
                p1traded1();
                p2trtraded2();
                
                p1 = 1;
                p2trad = 0;
                p4_gameplay.p1tr = 0;
                turn2();


                btnacc1.Visible = false;
                btndec1.Visible = false;
                btnacc2.Visible = false;
                btndec2.Visible = false;
                p1tr.Visible = false;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;


            }

            if (p2trad == 1 && p3 == 0 && p4_gameplay.p3tr == 1)
            {
                p3traded3_2();
                p2trtraded2_3();
                p3 = 1;
                p2trad = 0;
                p4_gameplay.p3tr = 0;
                turn2();



                btnacc1.Visible = false;
                btndec1.Visible = false;
                btnacc2.Visible = false;
                btndec2.Visible = false;
                p1tr.Visible = false;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;


            }

            if (p2trad == 1 && p4 == 0 && p4_gameplay.p4tr == 1)
            {
                p4traded4_2();
                p2trtraded2_4();
                p4 = 1;
                p2trad = 0;
                p4_gameplay.p4tr = 0;
                turn2();



                btnacc1.Visible = false;
                btndec1.Visible = false;
                btnacc2.Visible = false;
                btndec2.Visible = false;
                p1tr.Visible = false;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;


            }
        }
        void turnedd1_3()
        {
            if (p3trad == 1 && p1 == 0 && p4_gameplay.p1tr == 1)
            {
                p3trtraded3();
                p1traded1_3();  
                p1 = 1;
                p3trad = 0;
                p4_gameplay.p1tr = 0;

                turn2();


                btnacc1.Visible = false;
                btndec1.Visible = false;
                btnacc2.Visible = false;
                btndec2.Visible = false;
                p1tr.Visible = false;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();

                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;

            }

            if (p3trad == 1 && p2 == 0 && p4_gameplay.p2tr == 1)
            {               
                p2traded2_3();
                p3trtraded3_2();

                p2 = 1;
                p3trad = 0;
                p4_gameplay.p2tr = 0;
                turn2();

                btnacc1.Visible = false;
                btndec1.Visible = false;
                btnacc2.Visible = false;
                btndec2.Visible = false;
                p1tr.Visible = false;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;


            }

            if (p3trad == 1 && p4 == 0 && p4_gameplay.p4tr == 1)
            {
                p3trtraded3_4();
                p4traded4_3();
                p4 = 1;
                p3trad = 0;
                p4_gameplay.p4tr = 0;
                turn2();


                btnacc1.Visible = false;
                btndec1.Visible = false;
                btnacc2.Visible = false;
                btndec2.Visible = false;
                p1tr.Visible = false;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;


            }
        }
        void turnedd1_4()
        {
            if (p4trad == 1 && p1 == 0 && p4_gameplay.p1tr == 1)
            {
                p4trtraded4();
                p1traded1_4();
                p1 = 1;
                p4trad = 0;
                p4_gameplay.p1tr = 0;
                turn2();




                btnacc1.Visible = false;
                btndec1.Visible = false;
                btnacc2.Visible = false;
                btndec2.Visible = false;
                p1tr.Visible = false;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;


            }

            if (p4trad == 1 && p2 == 0 && p4_gameplay.p2tr == 1)
            {
                p4trtraded4_2();
                p2traded2_4();
                p2 = 1;
                p4trad = 0;
                p4_gameplay.p2tr = 0;
                turn2();


                btnacc1.Visible = false;
                btndec1.Visible = false;
                btnacc2.Visible = false;
                btndec2.Visible = false;
                p1tr.Visible = false;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;


            }

            if (p4trad == 1 && p3 == 0 && p4_gameplay.p3tr == 1)
            {
                p4trtraded4_3();
                p3traded3_4();
                p3 = 1;
                p4trad = 0;
                p4_gameplay.p3tr = 0;
                turn2();



                btnacc1.Visible = false;
                btndec1.Visible = false;
                btnacc2.Visible = false;
                btndec2.Visible = false;
                p1tr.Visible = false;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;


            }
        }
        void turnedd2()
        {
            if (p1trad == 0 && p2 == 1 && p4_gameplay.p2tr == 0)
            {
                p2traded2();
                p1trtraded1();

                p2 = 0;
                p1trad = 1;
                p4_gameplay.p2tr = 1;
               
             
                
                turn1();

                btnacc2.Visible = false;
                btndec2.Visible = false;
                btnacc1.Visible = false;
                btndec1.Visible = false;
                p2tr.Visible = false;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;


            }

            if (p1trad == 0 && p3 == 1 && p4_gameplay.p3tr == 0)
            {
                p3 = 0;
                p1trad = 1;
                p4_gameplay.p3tr = 1;
                turn1();
                p1trtraded1_3();
                p3traded3();

                btnacc2.Visible = false;
                btndec2.Visible = false;
                btnacc1.Visible = false;
                btndec1.Visible = false;
                p2tr.Visible = false;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;


            }


            if (p1trad == 0 && p4 == 1 && p4_gameplay.p4tr == 0)
            {
                p4 = 0;
                p1trad = 1;
                p4_gameplay.p4tr = 1;
                turn1();
                p4traded4();
                p1trtraded1_4();

                btnacc2.Visible = false;
                btndec2.Visible = false;
                btnacc1.Visible = false;
                btndec1.Visible = false;
                p2tr.Visible = false;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;


            }


        }
        void turnedd2_2()
        {
            if (p2trad == 0 && p1 == 1 && p4_gameplay.p1tr == 0)
            {
                p2trtraded2();
                p1traded1();
                p1 = 0;
                p2trad = 1;
                p4_gameplay.p1tr = 1;
                turn1();


                btnacc2.Visible = false;
                btndec2.Visible = false;
                btnacc1.Visible = false;
                btndec1.Visible = false;
                p2tr.Visible = false;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;


            }

            if (p2trad == 0 && p3 == 1 && p4_gameplay.p3tr == 0)
            {
                p2trtraded2_3();
                p3traded3_2();
                p3 = 0;
                p2trad = 1;
                p4_gameplay.p3tr = 1;
                turn1();

                btnacc2.Visible = false;
                btndec2.Visible = false;
                btnacc1.Visible = false;
                btndec1.Visible = false;
                p2tr.Visible = false;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;


            }


            if (p2trad == 0 && p4 == 1 && p4_gameplay.p4tr == 0)
            {
                p4traded4_2();
                p2trtraded2_4();
                p4 = 0;
                p2trad = 1;
                p4_gameplay.p4tr = 1;
                turn1();



                btnacc2.Visible = false;
                btndec2.Visible = false;
                btnacc1.Visible = false;
                btndec1.Visible = false;
                p2tr.Visible = false;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;

            }
        }
        void turnedd2_3()
        {
            if (p3trad == 0 && p1 == 1 && p4_gameplay.p1tr == 0)
            {
                p3trtraded3();
                p1traded1_3();
                p1 = 0;
                p3trad = 1;
                p4_gameplay.p1tr = 1;
                turn1();

                btnacc2.Visible = false;
                btndec2.Visible = false;
                btnacc1.Visible = false;
                btndec1.Visible = false;
                p2tr.Visible = false;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;


            }

            if (p3trad == 0 && p2 == 1 && p4_gameplay.p2tr == 0)
            {
                p3trtraded3_2();
                p2traded2_3();
                p2 = 0;
                p3trad = 1;
                p4_gameplay.p2tr = 1;
                turn1();

                btnacc2.Visible = false;
                btndec2.Visible = false;
                btnacc1.Visible = false;
                btndec1.Visible = false;
                p2tr.Visible = false;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;


            }


            if (p3trad == 0 && p4 == 1 && p4_gameplay.p4tr == 0)
            {
                p4traded4_3();
                p3trtraded3_4();
                p4 = 0;
                p3trad = 1;
                p4_gameplay.p4tr = 1;
                turn1();

                btnacc2.Visible = false;
                btndec2.Visible = false;
                btnacc1.Visible = false;
                btndec1.Visible = false;
                p2tr.Visible = false;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;


            }
        }
        void turnedd2_4()
        {
            if (p4trad == 0 && p1 == 1 && p4_gameplay.p1tr == 0)
            {
                p4trtraded4();
                p1traded1_4();
                p1 = 0;
                p4trad = 1;
                p4_gameplay.p1tr = 1;
                turn1();




                btnacc2.Visible = false;
                btndec2.Visible = false;
                btnacc1.Visible = false;
                btndec1.Visible = false;
                p2tr.Visible = false;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;


            }

            if (p4trad == 0 && p2 == 1 && p4_gameplay.p2tr == 0)
            {
                p4trtraded4_2();
                p2traded2_4();
                p2 = 0;
                p4trad = 1;
                p4_gameplay.p2tr = 1;
                turn1();

                btnacc2.Visible = false;
                btndec2.Visible = false;
                btnacc1.Visible = false;
                btndec1.Visible = false;
                p2tr.Visible = false;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;


            }


            if (p4trad == 0 && p3 == 1 && p4_gameplay.p3tr == 0)
            {

                p3 = 0;
                p4trad = 1;
                p4trtraded4_3();
                p3traded3_4();
                p4_gameplay.p3tr = 1;
                turn1();

                btnacc2.Visible = false;
                btndec2.Visible = false;
                btnacc1.Visible = false;
                btndec1.Visible = false;
                p2tr.Visible = false;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;


            }
        }
        void turneddec1()
        {
            if (p1trad == 1 && p2 == 0 && p4_gameplay.p2tr == 1)
            {
                p2 = 1;
                p1trad = 0;
                p4_gameplay.p2tr = 0;
                turn2();

                btnacc1.Visible = false;
                btndec1.Visible = false;
                btnacc2.Visible = false;
                btndec2.Visible = false;
                p1tr.Visible = false;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                notif1.Visible = false;
                notif2.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;

            }

            if (p1trad == 1 && p3 == 0 && p4_gameplay.p3tr == 1)
            {
                p3 = 1;
                p1trad = 0;
                p4_gameplay.p3tr = 0;
                turn2();
                p1trtraded1_3();
                p3traded3();

                btnacc1.Visible = false;
                btndec1.Visible = false;
                btnacc2.Visible = false;
                btndec2.Visible = false;
                p1tr.Visible = false;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;

            }

            if (p1trad == 1 && p4 == 0 && p4_gameplay.p4tr == 1)
            {
                p4 = 1;
                p1trad = 0;
                p4_gameplay.p4tr = 0;
                turn2();
                p1trtraded1_4();
                p4traded4();

                btnacc1.Visible = false;
                btndec1.Visible = false;
                btnacc2.Visible = false;
                btndec2.Visible = false;
                p1tr.Visible = false;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;

            }


        }
        void turneddec1_2()
        {
            if (p2trad == 1 && p1 == 0 && p4_gameplay.p1tr == 1)
            {
                p1 = 1;
                p2trad = 0;
                p4_gameplay.p1tr = 0;
                turn2();

                btnacc1.Visible = false;
                btndec1.Visible = false;
                btnacc2.Visible = false;
                btndec2.Visible = false;
                p1tr.Visible = false;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;

            }

            if (p2trad == 1 && p3 == 0 && p4_gameplay.p3tr == 1)
            {
                p3 = 1;
                p2trad = 0;
                p4_gameplay.p3tr = 0;
                turn2();
                p2trtraded2_3();
                p3traded3_2();

                btnacc1.Visible = false;
                btndec1.Visible = false;
                btnacc2.Visible = false;
                btndec2.Visible = false;
                p1tr.Visible = false;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;

            }

            if (p2trad == 1 && p4 == 0 && p4_gameplay.p4tr == 1)
            {
                p4 = 1;
                p2trad = 0;
                p4_gameplay.p4tr = 0;
                turn2();
                p2trtraded2_4();
                p4traded4_2();

                btnacc1.Visible = false;
                btndec1.Visible = false;
                btnacc2.Visible = false;
                btndec2.Visible = false;
                p1tr.Visible = false;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;

            }
        }
        void turneddec1_3()
        {
            if (p3trad == 1 && p1 == 0 && p4_gameplay.p1tr == 1)
            {
                p1 = 1;
                p3trad = 0;
                p4_gameplay.p1tr = 0;
                turn2();

                btnacc1.Visible = false;
                btndec1.Visible = false;
                btnacc2.Visible = false;
                btndec2.Visible = false;
                p1tr.Visible = false;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;

            }

            if (p3trad == 1 && p2 == 0 && p4_gameplay.p2tr == 1)
            {
                p2 = 1;
                p3trad = 0;
                p4_gameplay.p2tr = 0;
                turn2();
                p3trtraded3_2();
                p2traded2_3();

                btnacc1.Visible = false;
                btndec1.Visible = false;
                btnacc2.Visible = false;
                btndec2.Visible = false;
                p1tr.Visible = false;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;

            }

            if (p3trad == 1 && p4 == 0 && p4_gameplay.p4tr == 1)
            {
                p4 = 1;
                p3trad = 0;
                p4_gameplay.p4tr = 0;
                turn2();
                p3trtraded3_4();
                p4traded4_3();

                btnacc1.Visible = false;
                btndec1.Visible = false;
                btnacc2.Visible = false;
                btndec2.Visible = false;
                p1tr.Visible = false;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;

            }
        }
        void turneddec1_4()
        {
            if (p4trad == 1 && p1 == 0 && p4_gameplay.p1tr == 1)
            {
                p1 = 1;
                p4trad = 0;
                p4_gameplay.p1tr = 0;
                turn2();


                btnacc1.Visible = false;
                btndec1.Visible = false;
                btnacc2.Visible = false;
                btndec2.Visible = false;
                p1tr.Visible = false;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;

            }

            if (p4trad == 1 && p2 == 0 && p4_gameplay.p2tr == 1)
            {
                p2 = 1;
                p4trad = 0;
                p4_gameplay.p2tr = 0;
                turn2();
                p2trtraded2_4();
                p4traded4_2();


                btnacc1.Visible = false;
                btndec1.Visible = false;
                btnacc2.Visible = false;
                btndec2.Visible = false;
                p1tr.Visible = false;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;

            }

            if (p4trad == 1 && p3 == 0 && p4_gameplay.p3tr == 1)
            {
                p3 = 1;
                p4trad = 0;
                p4_gameplay.p3tr = 0;
                turn2();
                p4trtraded4_3();
                p3traded3_4();

                btnacc1.Visible = false;
                btndec1.Visible = false;
                btnacc2.Visible = false;
                btndec2.Visible = false;
                p1tr.Visible = false;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p2tr.Visible = false;
                pbdet2.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;

            }
        }
        void turneddec2()
        {
            if (p1trad == 0 && p2 == 1 && p4_gameplay.p2tr == 0)
            {
                p2 = 0;
                p1trad = 1;
                p4_gameplay.p2tr = 1;
                turn1();

                btnacc2.Visible = false;
                btndec2.Visible = false;
                btnacc1.Visible = false;
                btndec1.Visible = false;
                p2tr.Visible = false;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;

            }

            if (p1trad == 0 && p3 == 1 && p4_gameplay.p3tr == 0)
            {
                p3 = 0;
                p1trad = 1;
                p4_gameplay.p3tr = 1;
                turn1();
                p1trtraded1_3();
                p3traded3();

                btnacc2.Visible = false;
                btndec2.Visible = false;
                btnacc1.Visible = false;
                btndec1.Visible = false;
                p2tr.Visible = false;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;

            }


            if (p1trad == 0 && p4 == 1 && p4_gameplay.p4tr == 0)
            {
                p4 = 0;
                p1trad = 1;
                p4_gameplay.p4tr = 1;
                turn1();
                p1trtraded1_4();
                p4traded4();

                btnacc2.Visible = false;
                btndec2.Visible = false;
                btnacc1.Visible = false;
                btndec1.Visible = false;
                p2tr.Visible = false;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;

            }


        }
        void turneddec2_2()
        {
            if (p2trad == 0 && p1 == 1 && p4_gameplay.p1tr == 0)
            {
                p1 = 0;
                p2trad = 1;
                p4_gameplay.p1tr = 1;
                turn1();
                p2trtraded2();
                p1traded1();

                btnacc2.Visible = false;
                btndec2.Visible = false;
                btnacc1.Visible = false;
                btndec1.Visible = false;
                p2tr.Visible = false;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;

            }

            if (p2trad == 0 && p3 == 1 && p4_gameplay.p3tr == 0)
            {
                p3 = 0;
                p2trad = 1;
                p4_gameplay.p3tr = 1;
                turn1();
                p2trtraded2_3();
                p3traded3_2();

                btnacc2.Visible = false;
                btndec2.Visible = false;
                btnacc1.Visible = false;
                btndec1.Visible = false;
                p2tr.Visible = false;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;

            }


            if (p2trad == 0 && p4 == 1 && p4_gameplay.p4tr == 0)
            {
                p4 = 0;
                p2trad = 1;
                p4_gameplay.p4tr = 1;
                turn1();
                p2trtraded2_4();
                p4traded4_2();

                btnacc2.Visible = false;
                btndec2.Visible = false;
                btnacc1.Visible = false;
                btndec1.Visible = false;
                p2tr.Visible = false;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;

            }
        }
        void turneddec2_3()
        {
            if (p3trad == 0 && p1 == 1 && p4_gameplay.p1tr == 0)
            {
                p1 = 0;
                p3trad = 1;
                p4_gameplay.p1tr = 1;
                turn1();

                btnacc2.Visible = false;
                btndec2.Visible = false;
                btnacc1.Visible = false;
                btndec1.Visible = false;
                p2tr.Visible = false;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;

            }

            if (p3trad == 0 && p2 == 1 && p4_gameplay.p2tr == 0)
            {
                p2 = 0;
                p3trad = 1;
                p4_gameplay.p2tr = 1;
                turn1();
                p3trtraded3_2();
                p2traded2_3();

                btnacc2.Visible = false;
                btndec2.Visible = false;
                btnacc1.Visible = false;
                btndec1.Visible = false;
                p2tr.Visible = false;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;

            }


            if (p3trad == 0 && p4 == 1 && p4_gameplay.p4tr == 0)
            {
                p4 = 0;
                p3trad = 1;
                p4_gameplay.p4tr = 1;
                turn1();
                p3trtraded3_4();
                p4traded4_3();

                btnacc2.Visible = false;
                btndec2.Visible = false;
                btnacc1.Visible = false;
                btndec1.Visible = false;
                p2tr.Visible = false;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;

            }
        }
        void turneddec2_4()
        {
            if (p4trad == 0 && p1 == 1 && p4_gameplay.p1tr == 0)
            {
                p1 = 0;
                p4trad = 1;
                p4_gameplay.p1tr = 1;
                turn1();

                btnacc2.Visible = false;
                btndec2.Visible = false;
                btnacc1.Visible = false;
                btndec1.Visible = false;
                p2tr.Visible = false;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;

            }

            if (p4trad == 0 && p2 == 1 && p4_gameplay.p2tr == 0)
            {
                p2 = 0;
                p4trad = 1;
                p4_gameplay.p2tr = 1;
                turn1();
                p2trtraded2_4();
                p4traded4_2();

                btnacc2.Visible = false;
                btndec2.Visible = false;
                btnacc1.Visible = false;
                btndec1.Visible = false;
                p2tr.Visible = false;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;

            }


            if (p4trad == 0 && p3 == 1 && p4_gameplay.p3tr == 0)
            {
                p3 = 0;
                p4trad = 1;
                p4_gameplay.p3tr = 1;
                turn1();
                p4trtraded4_3();
                p3traded3_4();


                btnacc2.Visible = false;
                btndec2.Visible = false;
                btnacc1.Visible = false;
                btndec1.Visible = false;
                p2tr.Visible = false;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                notif2.Visible = false;
                notif1.Visible = false;
                btnp2.Visible = true;
                btnp1.Visible = true;
                p1tr.Visible = false;
                pbdet1.Visible = false;
                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;


                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;

            }
        }
        void colorturn()
        {

            if (p4_gameplay.p1trad == 1)
            {
                p1tr.BackColor = Color.Firebrick;
                p1tradein1 = 1;
                btnp1.BackColor = Color.LightSalmon;
                btnp1.BackgroundImage = bankers_game_proto.Properties.Resources.p1_d;
                btnp1.BackgroundImageLayout = ImageLayout.Stretch;
                timer1.Start();
            }

            if (p4_gameplay.p2trad == 1)
            {
                p1tr.BackColor = Color.RoyalBlue;
                p2tradein2 = 1;
                btnp1.BackColor = Color.LightSkyBlue;
                btnp1.BackgroundImage = bankers_game_proto.Properties.Resources.p2_d;
                btnp1.BackgroundImageLayout = ImageLayout.Stretch;
                timer1.Start();
            }
            if (p4_gameplay.p3trad == 1)
            {
                p1tr.BackColor = Color.LimeGreen;
                p3tradein3 = 1;
                btnp1.BackColor = Color.LimeGreen;
                btnp1.BackgroundImage = bankers_game_proto.Properties.Resources.p3_d;
                btnp1.BackgroundImageLayout = ImageLayout.Stretch;
                timer1.Start();
            }
            if (p4_gameplay.p4trad == 1)
            {
                p1tr.BackColor = Color.Coral;
                p4tradein4 = 1;
                btnp1.BackColor = Color.Orange;
                btnp1.BackgroundImage = bankers_game_proto.Properties.Resources.p4_d;
                btnp1.BackgroundImageLayout = ImageLayout.Stretch;
                timer1.Start();
            }

            if (p4_gameplay.p1 == 1)
            {
                p2tr.BackColor = Color.Firebrick;
                btnp2.BackColor = Color.LightSalmon;
                btnp2.BackgroundImage = bankers_game_proto.Properties.Resources.p1_t;
                btnp2.BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (p4_gameplay.p2 == 1)
            {
                p2tr.BackColor = Color.RoyalBlue;
                btnp2.BackColor = Color.LightSkyBlue;
                btnp2.BackgroundImage = bankers_game_proto.Properties.Resources.p2_t;
                btnp2.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (p4_gameplay.p3 == 1)
            {
                p2tr.BackColor = Color.LimeGreen;
                btnp2.BackColor = Color.LimeGreen;
                btnp2.BackgroundImage = bankers_game_proto.Properties.Resources.p3_t;
                btnp2.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (p4_gameplay.p4 == 1)
            {
                p2tr.BackColor = Color.Coral;
                btnp2.BackColor = Color.Orange;
                btnp2.BackgroundImage = bankers_game_proto.Properties.Resources.p4_t;
                btnp2.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (btnp1.Enabled == false && p1trad == 0)
            {
                btnp1.BackColor = Color.Gray;
            }


            if (btnp1.Enabled == false && p2trad == 0)
            {
                btnp1.BackColor = Color.Gray;
            }

            if (btnp1.Enabled == false && p3trad == 0)
            {
                btnp1.BackColor = Color.Gray;
            }

            if (btnp1.Enabled == false && p4trad == 0)
            {
                btnp1.BackColor = Color.Gray;
            }

            if (btnp2.Enabled == false && p1 == 0)
            {
                btnp2.BackColor = Color.Gray;
            }

            if (btnp2.Enabled == false && p2 == 0)
            {
                btnp2.BackColor = Color.Gray;
            }

            if (btnp2.Enabled == false && p3 == 0)
            {
                btnp2.BackColor = Color.Gray;

            }
            if (btnp2.Enabled == false && p4 == 0)
            {
                btnp2.BackColor = Color.Gray;
            }
        }
        void initializerstrad()
        {
            if (p1trad == 1)
            {
                p1trad = 1;
                p2trad = 0;
                p3trad = 0;
                p4trad = 0;
            }

            if (p2trad == 1)
            {
                p1trad = 0;
                p2trad = 1;
                p3trad = 0;
                p4trad = 0;
            }

            if (p3trad == 1)
            {
                p1trad = 0;
                p2trad = 0;
                p3trad = 1;
                p4trad = 0;
            }

            if (p4trad == 1)
            {
                p1trad = 0;
                p2trad = 0;
                p3trad = 0;
                p4trad = 1;
            }
            if (p1 == 1)
            {
                p1 = 1;
                p2 = 0;
                p3 = 0;
                p4 = 0;
            }

            if (p2 == 1)
            {
                p1 = 0;
                p2 = 1;
                p3 = 0;
                p4 = 0;
            }

            if (p3 == 1)
            {
                p1 = 0;
                p2 = 0;
                p3 = 1;
                p4 = 0;
            }

            if (p4 == 1)
            {
                p1 = 0;
                p2 = 0;
                p3 = 0;
                p4 = 1;
            }

        }
        void tradep1()
        {

            ListViewItem li2 = new ListViewItem();

            if (easternschooltr1 == 1 && easternschooldet2 == 1 && easternschooltrd2 == 0)
            {
                easternschooltrd2 = 1;
                btntrad1.Visible = false;
                li2.ForeColor = Color.Purple;
                li2.Text = "Eastern School";
                p2lvw.Items.Add(li2);



            }
            if (westernschooltr1 == 1 && westernschooldet2 == 1 && westernschooltrd2 == 0)
            {
                westernschooltrd2 = 1;
                btntrad1.Visible = false;
                li2.ForeColor = Color.Purple;
                li2.Text = "Western School";
                p2lvw.Items.Add(li2);
            }

            if (visayashighschooltr1 == 1 && visayashighschooldet2 == 1 && visayashighschooltrd2 == 0)
            {
                visayashighschooltrd2 = 1;
                btntrad1.Visible = false;
                li2.ForeColor = Color.LightBlue;
                li2.Text = "Visayas High-School";
                p2lvw.Items.Add(li2);

            }
            if (southernschooltr1 == 1 && southernschooldet2 == 1 && southernschooltrd2 == 0)
            {
                southernschooltrd2 = 1;
                btntrad1.Visible = false;
                li2.ForeColor = Color.LightBlue;
                li2.Text = "Southern School";
                p2lvw.Items.Add(li2);
            }
            if (nationsschooltr1 == 1 && nationsschooldet2 == 1 && nationsschooltrd2 == 0)
            {
                nationsschooltrd2 = 1;
                btntrad1.Visible = false;
                li2.ForeColor = Color.LightBlue;
                li2.Text = "Nation's School";
                p2lvw.Items.Add(li2);
            }

            if (westmarkettr1 == 1 && westmarketdet2 == 1 && westmarkettrd2 == 0)
            {
                westmarkettrd2 = 1;
                btntrad1.Visible = false;
                li2.ForeColor = Color.Pink;
                li2.Text = "West Market";
                p2lvw.Items.Add(li2);
            }
            if (nightmarkettr1 == 1 && nightmarketdet2 == 1 && nightmarkettrd2 == 0)
            {
                nightmarkettrd2 = 1;
                btntrad1.Visible = false;
                li2.ForeColor = Color.Pink;
                li2.Text = "Night Market";
                p2lvw.Items.Add(li2);
            }
            if (daymarkettr1 == 1 && daymarketdet2 == 1 && daymarkettrd2 == 0)
            {
                daymarkettrd2 = 1;
                btntrad1.Visible = false;
                li2.ForeColor = Color.Pink;
                li2.Text = "Day Market";
                p2lvw.Items.Add(li2);
            }

            if (starmarkettr1 == 1 && starmarketdet2 == 1 && starmarkettrd2 == 0)
            {
                starmarkettrd2 = 1;
                btntrad1.Visible = false;
                li2.ForeColor = Color.DarkOrange;
                li2.Text = "Star Market";
                p2lvw.Items.Add(li2);
            }
            if (moonmarkettr1 == 1 && moonmarketdet2 == 1 && moonmarkettrd2 == 0)
            {
                moonmarkettrd2 = 1;
                btntrad1.Visible = false;
                li2.ForeColor = Color.DarkOrange;
                li2.Text = "Moon Market";
                p2lvw.Items.Add(li2);
            }
            if (megamarkettr1 == 1 && megamarketdet2 == 1 && megamarkettrd2 == 0)
            {
                megamarkettrd2 = 1;
                btntrad1.Visible = false;
                li2.ForeColor = Color.DarkOrange;
                li2.Text = "Mega Market";
                p2lvw.Items.Add(li2);
            }

            if (visayashospitaltr1 == 1 && visayashospitaldet2 == 1 && visayashospitaltrd2 == 0)
            {
                visayashospitaltrd2 = 1;
                btntrad1.Visible = false;
                li2.ForeColor = Color.Red;
                li2.Text = "Visayas Hospital";
                p2lvw.Items.Add(li2);
            }
            else if (hobertshospitaltr1 == 1 && hobertshospitaldet2 == 1 && hobertshospitaltrd2 == 0)
            {
                hobertshospitaltrd2 = 1;
                btntrad1.Visible = false;
                li2.ForeColor = Color.Red;
                li2.Text = "Hobert's Hospital";
                p2lvw.Items.Add(li2);
            }
            else if (heartshospitaltr1 == 1 && heartshospitaldet2 == 1 && heartshospitaltrd2 == 0)
            {
                heartshospitaltrd2 = 1;
                btntrad1.Visible = false;
                li2.ForeColor = Color.Red;
                li2.Text = "Hearts Hospital";
                p2lvw.Items.Add(li2);
            }

            if (internshospitaltr1 == 1 && internshospitaldet2 == 1 && internshospitaltrd2 == 0)
            {
                internshospitaltrd2 = 1;
                btntrad1.Visible = false;
                li2.ForeColor = Color.LightGoldenrodYellow;
                li2.Text = "Intern's Hospital";
                p2lvw.Items.Add(li2);
            }
            else if (nationalhealthhospitaltr1 == 1 && nationalhealthhospitaldet2 == 1 && nationalhealthhospitaltrd2 == 0)
            {
                nationalhealthhospitaltrd2 = 1;
                btntrad1.Visible = false;
                li2.ForeColor = Color.LightGoldenrodYellow;
                li2.Text = "National Health Hospital";
                p2lvw.Items.Add(li2);
            }
            else if (veteranshospitaltr1 == 1 && veteranshospitaldet2 == 1 && veteranshospitaltrd2 == 0)
            {
                veteranshospitaltrd2 = 1;
                btntrad1.Visible = false;
                li2.ForeColor = Color.LightGoldenrodYellow;
                li2.Text = "Veteran's Hospital";
                p2lvw.Items.Add(li2);
            }

            if (pearlmalltr1 == 1 && pearlmalldet2 == 1 && pearlmalltrd2 == 0)
            {
                pearlmalltrd2 = 1;
                btntrad1.Visible = false;
                li2.ForeColor = Color.Green;
                li2.Text = "Pearl Mall";
                p2lvw.Items.Add(li2);
            }
            else if (megamalltr1 == 1 && megamalldet2 == 1 && megamalltrd2 == 0)
            {
                megamalltrd2 = 1;
                btntrad1.Visible = false;
                li2.ForeColor = Color.Green;
                li2.Text = "Mega Mall";
                p2lvw.Items.Add(li2);
            }
            else if (articmalltr1 == 1 && articmalldet2 == 1 && articmalltrd2 == 0)
            {
                articmalltr1 = 1;
                btntrad1.Visible = false;
                li2.ForeColor = Color.Green;
                li2.Text = "Artic Mall";
                p2lvw.Items.Add(li2);
            }

            if (heavenlymalltr1 == 1 && heavenlymalldet2 == 1 && heavenlymalltrd2 == 0)
            {
                heavenlymalltrd2 = 1;
                btntrad1.Visible = false;
                li2.ForeColor = Color.DarkBlue;
                li2.Text = "Heavenly Mall";
                p2lvw.Items.Add(li2);
            }
            else if (shangrillamalltr1 == 1 && shangrillamalldet2 == 1 && shangrillamalltrd2 == 0)
            {
                shangrillamalltrd2 = 1;
                btntrad1.Visible = false;
                li2.ForeColor = Color.DarkBlue;
                li2.Text = "Shangrilla Mall";
                p2lvw.Items.Add(li2);
            }

            if (utility1x1tr1 == 1 && utility2x1det2 == 1 && utility2x1trd2 == 0)
            {
                utility2x1trd2 = 1;
                btntrad1.Visible = false;
                li2.ForeColor = Color.Yellow;
                li2.Text = "Meralco Electricity";
                p2lvw.Items.Add(li2);
            }
            else if (utility1x2tr1 == 1 && utility2x2det2 == 1 && utility2x2trd2 == 0)
            {
                utility2x2trd2 = 1;
                btntrad1.Visible = false;
                li2.ForeColor = Color.Yellow;
                li2.Text = "Niagra Falls Electricity";
                p2lvw.Items.Add(li2);
            }

            if (transportation1x1tr1 == 1 && transportation2x1det2 == 1 && transportation2x1trd2 == 0)
            {
                transportation2x1trd2 = 1;
                btntrad1.Visible = false;
                li2.ForeColor = Color.SteelBlue;
                li2.Text = "Rosevelt Station";
                p2lvw.Items.Add(li2);
            }
            else if (transportation1x2tr1 == 1 && transportation2x2det2 == 1 && transportation2x2trd2 == 0)
            {
                transportation2x2trd2 = 1;
                btntrad1.Visible = false;
                li2.ForeColor = Color.SteelBlue;
                li2.Text = "Santolan Station";
                p2lvw.Items.Add(li2);
            }
            else if (transportation1x3tr1 == 1 && transportation2x3det2 == 1 && transportation2x3trd2 == 0)
            {
                transportation2x3trd2 = 1;
                btntrad1.Visible = false;
                li2.ForeColor = Color.SteelBlue;
                li2.Text = "Fairview Station";
                p2lvw.Items.Add(li2);
            }
            else if (transportation1x4tr1 == 1 && transportation2x4det2 == 1 && transportation2x4trd2 == 0)
            {
                transportation2x4trd2 = 1;
                btntrad1.Visible = false;
                li2.ForeColor = Color.SteelBlue;
                li2.Text = "Sta. Mesa Station";
                p2lvw.Items.Add(li2);
            }


        }
        void tradep2()
        {
            ListViewItem li2 = new ListViewItem();

            if (easternschooltr2 == 1 && easternschooldet2 == 1 && easternschooltrd2 == 0)
            {
                easternschooltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Purple;
                li2.Text = "Eastern School";
                p2lvw.Items.Add(li2);



            }
            if (westernschooltr2 == 1 && westernschooldet2 == 1 && westernschooltrd2 == 0)
            {
                westernschooltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Purple;
                li2.Text = "Western School";
                p2lvw.Items.Add(li2);
            }

            if (visayashighschooltr2 == 1 && visayashighschooldet2 == 1 && visayashighschooltrd2 == 0)
            {
                visayashighschooltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.LightBlue;
                li2.Text = "Visayas High-School";
                p2lvw.Items.Add(li2);

            }
            if (southernschooltr2 == 1 && southernschooldet2 == 1 && southernschooltrd2 == 0)
            {
                southernschooltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.LightBlue;
                li2.Text = "Southern School";
                p2lvw.Items.Add(li2);
            }
            if (nationsschooltr2 == 1 && nationsschooldet2 == 1 && nationsschooltrd2 == 0)
            {
                nationsschooltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.LightBlue;
                li2.Text = "Nation's School";
                p2lvw.Items.Add(li2);
            }

            if (westmarkettr2 == 1 && westmarketdet2 == 1 && westmarkettrd2 == 0)
            {
                westmarkettrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Pink;
                li2.Text = "West Market";
                p2lvw.Items.Add(li2);
            }
            if (nightmarkettr2 == 1 && nightmarketdet2 == 1 && nightmarkettrd2 == 0)
            {
                nightmarkettrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Pink;
                li2.Text = "Night Market";
                p2lvw.Items.Add(li2);
            }
            if (daymarkettr2 == 1 && daymarketdet2 == 1 && daymarkettrd2 == 0)
            {
                daymarkettrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Pink;
                li2.Text = "Day Market";
                p2lvw.Items.Add(li2);
            }

            if (starmarkettr2 == 1 && starmarketdet2 == 1 && starmarkettrd2 == 0)
            {
                starmarkettrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.DarkOrange;
                li2.Text = "Star Market";
                p2lvw.Items.Add(li2);
            }
            if (moonmarkettr2 == 1 && moonmarketdet2 == 1 && moonmarkettrd2 == 0)
            {
                moonmarkettrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.DarkOrange;
                li2.Text = "Moon Market";
                p2lvw.Items.Add(li2);
            }
            if (megamarkettr2 == 1 && megamarketdet2 == 1 && megamarkettrd2 == 0)
            {
                megamarkettrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.DarkOrange;
                li2.Text = "Mega Market";
                p2lvw.Items.Add(li2);
            }

            if (visayashospitaltr2 == 1 && visayashospitaldet2 == 1 && visayashospitaltrd2 == 0)
            {
                visayashospitaltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Red;
                li2.Text = "Visayas Hospital";
                p2lvw.Items.Add(li2);
            }
            else if (hobertshospitaltr2 == 1 && hobertshospitaldet2 == 1 && hobertshospitaltrd2 == 0)
            {
                hobertshospitaltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Red;
                li2.Text = "Hobert's Hospital";
                p2lvw.Items.Add(li2);
            }
            else if (heartshospitaltr2 == 1 && heartshospitaldet2 == 1 && heartshospitaltrd2 == 0)
            {
                heartshospitaltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Red;
                li2.Text = "Hearts Hospital";
                p2lvw.Items.Add(li2);
            }

            if (internshospitaltr2 == 1 && internshospitaldet2 == 1 && internshospitaltrd2 == 0)
            {
                internshospitaltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.LightGoldenrodYellow;
                li2.Text = "Intern's Hospital";
                p2lvw.Items.Add(li2);
            }
            else if (nationalhealthhospitaltr2 == 1 && nationalhealthhospitaldet2 == 1 && nationalhealthhospitaltrd2 == 0)
            {
                nationalhealthhospitaltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.LightGoldenrodYellow;
                li2.Text = "National Health Hospital";
                p2lvw.Items.Add(li2);
            }
            else if (veteranshospitaltr2 == 1 && veteranshospitaldet2 == 1 && veteranshospitaltrd2 == 0)
            {
                veteranshospitaltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.LightGoldenrodYellow;
                li2.Text = "Veteran's Hospital";
                p2lvw.Items.Add(li2);
            }

            if (pearlmalltr2 == 1 && pearlmalldet2 == 1 && pearlmalltrd2 == 0)
            {
                pearlmalltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Green;
                li2.Text = "Pearl Mall";
                p2lvw.Items.Add(li2);
            }
            else if (megamalltr2 == 1 && megamalldet2 == 1 && megamalltrd2 == 0)
            {
                megamalltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Green;
                li2.Text = "Mega Mall";
                p2lvw.Items.Add(li2);
            }
            else if (articmalltr2 == 1 && articmalldet2 == 1 && articmalltrd2 == 0)
            {
                articmalltr2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Green;
                li2.Text = "Artic Mall";
                p2lvw.Items.Add(li2);
            }

            if (heavenlymalltr2 == 1 && heavenlymalldet2 == 1 && heavenlymalltrd2 == 0)
            {
                heavenlymalltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.DarkBlue;
                li2.Text = "Heavenly Mall";
                p2lvw.Items.Add(li2);
            }
            else if (shangrillamalltr2 == 1 && shangrillamalldet2 == 1 && shangrillamalltrd2 == 0)
            {
                shangrillamalltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.DarkBlue;
                li2.Text = "Shangrilla Mall";
                p2lvw.Items.Add(li2);
            }

            if (utility2x1tr2 == 1 && utility2x1det2 == 1 && utility2x1trd2 == 0)
            {
                utility2x1trd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Yellow;
                li2.Text = "Meralco Electricity";
                p2lvw.Items.Add(li2);
            }
            else if (utility2x2tr2 == 1 && utility2x2det2 == 1 && utility2x2trd2 == 0)
            {
                utility2x2trd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Yellow;
                li2.Text = "Niagra Falls Electricity";
                p2lvw.Items.Add(li2);
            }

            if (transportation2x1tr2 == 1 && transportation2x1det2 == 1 && transportation2x1trd2 == 0)
            {
                transportation2x1trd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.SteelBlue;
                li2.Text = "Rosevelt Station";
                p2lvw.Items.Add(li2);
            }
            else if (transportation2x2tr2 == 1 && transportation2x2det2 == 1 && transportation2x2trd2 == 0)
            {
                transportation2x2trd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.SteelBlue;
                li2.Text = "Santolan Station";
                p2lvw.Items.Add(li2);
            }
            else if (transportation2x3tr2 == 1 && transportation2x3det2 == 1 && transportation2x3trd2 == 0)
            {
                transportation2x3trd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.SteelBlue;
                li2.Text = "Fairview Station";
                p2lvw.Items.Add(li2);
            }
            else if (transportation2x4tr2 == 1 && transportation2x4det2 == 1 && transportation2x4trd2 == 0)
            {
                transportation2x4trd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.SteelBlue;
                li2.Text = "Sta. Mesa Station";
                p2lvw.Items.Add(li2);
            }




        }
        void tradep3()
        {
            ListViewItem li2 = new ListViewItem();

            if (easternschooltr3 == 1 && easternschooldet2 == 1 && easternschooltrd2 == 0)
            {
                easternschooltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Purple;
                li2.Text = "Eastern School";
                p2lvw.Items.Add(li2);



            }
            if (westernschooltr3 == 1 && westernschooldet2 == 1 && westernschooltrd2 == 0)
            {
                westernschooltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Purple;
                li2.Text = "Western School";
                p2lvw.Items.Add(li2);
            }

            if (visayashighschooltr3 == 1 && visayashighschooldet2 == 1 && visayashighschooltrd2 == 0)
            {
                visayashighschooltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.LightBlue;
                li2.Text = "Visayas High-School";
                p2lvw.Items.Add(li2);

            }
            if (southernschooltr3 == 1 && southernschooldet2 == 1 && southernschooltrd2 == 0)
            {
                southernschooltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.LightBlue;
                li2.Text = "Southern School";
                p2lvw.Items.Add(li2);
            }
            if (nationsschooltr3 == 1 && nationsschooldet2 == 1 && nationsschooltrd2 == 0)
            {
                nationsschooltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.LightBlue;
                li2.Text = "Nation's School";
                p2lvw.Items.Add(li2);
            }

            if (westmarkettr3 == 1 && westmarketdet2 == 1 && westmarkettrd2 == 0)
            {
                westmarkettrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Pink;
                li2.Text = "West Market";
                p2lvw.Items.Add(li2);
            }
            if (nightmarkettr3 == 1 && nightmarketdet2 == 1 && nightmarkettrd2 == 0)
            {
                nightmarkettrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Pink;
                li2.Text = "Night Market";
                p2lvw.Items.Add(li2);
            }
            if (daymarkettr3 == 1 && daymarketdet2 == 1 && daymarkettrd2 == 0)
            {
                daymarkettrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Pink;
                li2.Text = "Day Market";
                p2lvw.Items.Add(li2);
            }

            if (starmarkettr3 == 1 && starmarketdet2 == 1 && starmarkettrd2 == 0)
            {
                starmarkettrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.DarkOrange;
                li2.Text = "Star Market";
                p2lvw.Items.Add(li2);
            }
            if (moonmarkettr3 == 1 && moonmarketdet2 == 1 && moonmarkettrd2 == 0)
            {
                moonmarkettrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.DarkOrange;
                li2.Text = "Moon Market";
                p2lvw.Items.Add(li2);
            }
            if (megamarkettr3 == 1 && megamarketdet2 == 1 && megamarkettrd2 == 0)
            {
                megamarkettrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.DarkOrange;
                li2.Text = "Mega Market";
                p2lvw.Items.Add(li2);
            }

            if (visayashospitaltr3 == 1 && visayashospitaldet2 == 1 && visayashospitaltrd2 == 0)
            {
                visayashospitaltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Red;
                li2.Text = "Visayas Hospital";
                p2lvw.Items.Add(li2);
            }
            else if (hobertshospitaltr3 == 1 && hobertshospitaldet2 == 1 && hobertshospitaltrd2 == 0)
            {
                hobertshospitaltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Red;
                li2.Text = "Hobert's Hospital";
                p2lvw.Items.Add(li2);
            }
            else if (heartshospitaltr3 == 1 && heartshospitaldet2 == 1 && heartshospitaltrd2 == 0)
            {
                heartshospitaltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Red;
                li2.Text = "Hearts Hospital";
                p2lvw.Items.Add(li2);
            }

            if (internshospitaltr3 == 1 && internshospitaldet2 == 1 && internshospitaltrd2 == 0)
            {
                internshospitaltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.LightGoldenrodYellow;
                li2.Text = "Intern's Hospital";
                p2lvw.Items.Add(li2);
            }
            else if (nationalhealthhospitaltr3 == 1 && nationalhealthhospitaldet2 == 1 && nationalhealthhospitaltrd2 == 0)
            {
                nationalhealthhospitaltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.LightGoldenrodYellow;
                li2.Text = "National Health Hospital";
                p2lvw.Items.Add(li2);
            }
            else if (veteranshospitaltr3 == 1 && veteranshospitaldet2 == 1 && veteranshospitaltrd2 == 0)
            {
                veteranshospitaltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.LightGoldenrodYellow;
                li2.Text = "Veteran's Hospital";
                p2lvw.Items.Add(li2);
            }

            if (pearlmalltr3 == 1 && pearlmalldet2 == 1 && pearlmalltrd2 == 0)
            {
                pearlmalltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Green;
                li2.Text = "Pearl Mall";
                p2lvw.Items.Add(li2);
            }
            else if (megamalltr3 == 1 && megamalldet2 == 1 && megamalltrd2 == 0)
            {
                megamalltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Green;
                li2.Text = "Mega Mall";
                p2lvw.Items.Add(li2);
            }
            else if (articmalltr3 == 1 && articmalldet2 == 1 && articmalltrd2 == 0)
            {
                articmalltr3 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Green;
                li2.Text = "Artic Mall";
                p2lvw.Items.Add(li2);
            }

            if (heavenlymalltr3 == 1 && heavenlymalldet2 == 1 && heavenlymalltrd2 == 0)
            {
                heavenlymalltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.DarkBlue;
                li2.Text = "Heavenly Mall";
                p2lvw.Items.Add(li2);
            }
            else if (shangrillamalltr3 == 1 && shangrillamalldet2 == 1 && shangrillamalltrd2 == 0)
            {
                shangrillamalltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.DarkBlue;
                li2.Text = "Shangrilla Mall";
                p2lvw.Items.Add(li2);
            }

            if (utility3x1tr3 == 1 && utility2x1det2 == 1 && utility2x1trd2 == 0)
            {
                utility2x1trd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Yellow;
                li2.Text = "Meralco Electricity";
                p2lvw.Items.Add(li2);
            }
            else if (utility3x2tr3 == 1 && utility2x2det2 == 1 && utility2x2trd2 == 0)
            {
                utility2x2trd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Yellow;
                li2.Text = "Niagra Falls Electricity";
                p2lvw.Items.Add(li2);
            }

            if (transportation3x1tr3 == 1 && transportation2x1det2 == 1 && transportation2x1trd2 == 0)
            {
                transportation2x1trd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.SteelBlue;
                li2.Text = "Rosevelt Station";
                p2lvw.Items.Add(li2);
            }
            else if (transportation3x2tr3 == 1 && transportation2x2det2 == 1 && transportation2x2trd2 == 0)
            {
                transportation2x2trd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.SteelBlue;
                li2.Text = "Santolan Station";
                p2lvw.Items.Add(li2);
            }
            else if (transportation3x3tr3 == 1 && transportation2x3det2 == 1 && transportation2x3trd2 == 0)
            {
                transportation2x3trd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.SteelBlue;
                li2.Text = "Fairview Station";
                p2lvw.Items.Add(li2);
            }
            else if (transportation3x4tr3 == 1 && transportation2x4det2 == 1 && transportation2x4trd2 == 0)
            {
                transportation2x4trd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.SteelBlue;
                li2.Text = "Sta. Mesa Station";
                p2lvw.Items.Add(li2);
            }




        }
        void tradep4()
        {
            ListViewItem li2 = new ListViewItem();

            if (easternschooltr4 == 1 && easternschooldet2 == 1 && easternschooltrd2 == 0)
            {
                easternschooltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Purple;
                li2.Text = "Eastern School";
                p2lvw.Items.Add(li2);



            }
            if (westernschooltr4 == 1 && westernschooldet2 == 1 && westernschooltrd2 == 0)
            {
                westernschooltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Purple;
                li2.Text = "Western School";
                p2lvw.Items.Add(li2);
            }

            if (visayashighschooltr4 == 1 && visayashighschooldet2 == 1 && visayashighschooltrd2 == 0)
            {
                visayashighschooltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.LightBlue;
                li2.Text = "Visayas High-School";
                p2lvw.Items.Add(li2);

            }
            if (southernschooltr4 == 1 && southernschooldet2 == 1 && southernschooltrd2 == 0)
            {
                southernschooltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.LightBlue;
                li2.Text = "Southern School";
                p2lvw.Items.Add(li2);
            }
            if (nationsschooltr4 == 1 && nationsschooldet2 == 1 && nationsschooltrd2 == 0)
            {
                nationsschooltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.LightBlue;
                li2.Text = "Nation's School";
                p2lvw.Items.Add(li2);
            }

            if (westmarkettr4 == 1 && westmarketdet2 == 1 && westmarkettrd2 == 0)
            {
                westmarkettrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Pink;
                li2.Text = "West Market";
                p2lvw.Items.Add(li2);
            }
            if (nightmarkettr4 == 1 && nightmarketdet2 == 1 && nightmarkettrd2 == 0)
            {
                nightmarkettrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Pink;
                li2.Text = "Night Market";
                p2lvw.Items.Add(li2);
            }
            if (daymarkettr4 == 1 && daymarketdet2 == 1 && daymarkettrd2 == 0)
            {
                daymarkettrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Pink;
                li2.Text = "Day Market";
                p2lvw.Items.Add(li2);
            }

            if (starmarkettr4 == 1 && starmarketdet2 == 1 && starmarkettrd2 == 0)
            {
                starmarkettrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.DarkOrange;
                li2.Text = "Star Market";
                p2lvw.Items.Add(li2);
            }
            if (moonmarkettr4 == 1 && moonmarketdet2 == 1 && moonmarkettrd2 == 0)
            {
                moonmarkettrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.DarkOrange;
                li2.Text = "Moon Market";
                p2lvw.Items.Add(li2);
            }
            if (megamarkettr4 == 1 && megamarketdet2 == 1 && megamarkettrd2 == 0)
            {
                megamarkettrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.DarkOrange;
                li2.Text = "Mega Market";
                p2lvw.Items.Add(li2);
            }

            if (visayashospitaltr4 == 1 && visayashospitaldet2 == 1 && visayashospitaltrd2 == 0)
            {
                visayashospitaltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Red;
                li2.Text = "Visayas Hospital";
                p2lvw.Items.Add(li2);
            }
            else if (hobertshospitaltr4 == 1 && hobertshospitaldet2 == 1 && hobertshospitaltrd2 == 0)
            {
                hobertshospitaltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Red;
                li2.Text = "Hobert's Hospital";
                p2lvw.Items.Add(li2);
            }
            else if (heartshospitaltr4 == 1 && heartshospitaldet2 == 1 && heartshospitaltrd2 == 0)
            {
                heartshospitaltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Red;
                li2.Text = "Hearts Hospital";
                p2lvw.Items.Add(li2);
            }

            if (internshospitaltr4 == 1 && internshospitaldet2 == 1 && internshospitaltrd2 == 0)
            {
                internshospitaltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.LightGoldenrodYellow;
                li2.Text = "Intern's Hospital";
                p2lvw.Items.Add(li2);
            }
            else if (nationalhealthhospitaltr4 == 1 && nationalhealthhospitaldet2 == 1 && nationalhealthhospitaltrd2 == 0)
            {
                nationalhealthhospitaltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.LightGoldenrodYellow;
                li2.Text = "National Health Hospital";
                p2lvw.Items.Add(li2);
            }
            else if (veteranshospitaltr4 == 1 && veteranshospitaldet2 == 1 && veteranshospitaltrd2 == 0)
            {
                veteranshospitaltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.LightGoldenrodYellow;
                li2.Text = "Veteran's Hospital";
                p2lvw.Items.Add(li2);
            }

            if (pearlmalltr4 == 1 && pearlmalldet2 == 1 && pearlmalltrd2 == 0)
            {
                pearlmalltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Green;
                li2.Text = "Pearl Mall";
                p2lvw.Items.Add(li2);
            }
            else if (megamalltr4 == 1 && megamalldet2 == 1 && megamalltrd2 == 0)
            {
                megamalltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Green;
                li2.Text = "Mega Mall";
                p2lvw.Items.Add(li2);
            }
            else if (articmalltr4 == 1 && articmalldet2 == 1 && articmalltrd2 == 0)
            {
                articmalltr4 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Green;
                li2.Text = "Artic Mall";
                p2lvw.Items.Add(li2);
            }

            if (heavenlymalltr4 == 1 && heavenlymalldet2 == 1 && heavenlymalltrd2 == 0)
            {
                heavenlymalltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.DarkBlue;
                li2.Text = "Heavenly Mall";
                p2lvw.Items.Add(li2);
            }
            else if (shangrillamalltr4 == 1 && shangrillamalldet2 == 1 && shangrillamalltrd2 == 0)
            {
                shangrillamalltrd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.DarkBlue;
                li2.Text = "Shangrilla Mall";
                p2lvw.Items.Add(li2);
            }

            if (utility4x1tr4 == 1 && utility2x1det2 == 1 && utility2x1trd2 == 0)
            {
                utility2x1trd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Yellow;
                li2.Text = "Meralco Electricity";
                p2lvw.Items.Add(li2);
            }
            else if (utility4x2tr4 == 1 && utility2x2det2 == 1 && utility2x2trd2 == 0)
            {
                utility2x2trd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.Yellow;
                li2.Text = "Niagra Falls Electricity";
                p2lvw.Items.Add(li2);
            }

            if (transportation4x1tr4 == 1 && transportation2x1det2 == 1 && transportation2x1trd2 == 0)
            {
                transportation2x1trd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.SteelBlue;
                li2.Text = "Rosevelt Station";
                p2lvw.Items.Add(li2);
            }
            else if (transportation4x2tr4 == 1 && transportation2x2det2 == 1 && transportation2x2trd2 == 0)
            {
                transportation2x2trd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.SteelBlue;
                li2.Text = "Santolan Station";
                p2lvw.Items.Add(li2);
            }
            else if (transportation4x3tr4 == 1 && transportation2x3det2 == 1 && transportation2x3trd2 == 0)
            {
                transportation2x3trd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.SteelBlue;
                li2.Text = "Fairview Station";
                p2lvw.Items.Add(li2);
            }
            else if (transportation4x4tr4 == 1 && transportation2x4det2 == 1 && transportation2x4trd2 == 0)
            {
                transportation2x4trd2 = 1;
                btntrad2.Visible = false;
                li2.ForeColor = Color.SteelBlue;
                li2.Text = "Sta. Mesa Station";
                p2lvw.Items.Add(li2);
            }




        }
        void tradep1trad()
        {

            ListViewItem li = new ListViewItem();

            if (easternschooltr1 == 1 && easternschooldet1 == 1 && easternschooltrd1 == 0)
            {
                easternschooltrd1 = 1;
                btntrad1.Visible = false;
                li.ForeColor = Color.Purple;
                li.Text = "Eastern School";
                p1lvw.Items.Add(li);



            }
            if (westernschooltr1 == 1 && westernschooldet1 == 1 && westernschooltrd1 == 0)
            {
                westernschooltrd1 = 1;
                btntrad1.Visible = false;
                li.ForeColor = Color.Purple;
                li.Text = "Western School";
                p1lvw.Items.Add(li);
            }

            if (visayashighschooltr1 == 1 && visayashighschooldet1 == 1 && visayashighschooltrd1 == 0)
            {
                visayashighschooltrd1 = 1;
                btntrad1.Visible = false;
                li.ForeColor = Color.LightBlue;
                li.Text = "Visayas High-School";
                p1lvw.Items.Add(li);

            }
            if (southernschooltr1 == 1 && southernschooldet1 == 1 && southernschooltrd1 == 0)
            {
                southernschooltrd1 = 1;
                btntrad1.Visible = false;
                li.ForeColor = Color.LightBlue;
                li.Text = "Southern School";
                p1lvw.Items.Add(li);
            }
            if (nationsschooltr1 == 1 && nationsschooldet1 == 1 && nationsschooltrd1 == 0)
            {
                nationsschooltrd1 = 1;
                btntrad1.Visible = false;
                li.ForeColor = Color.LightBlue;
                li.Text = "Nation's School";
                p1lvw.Items.Add(li);
            }

            if (westmarkettr1 == 1 && westmarketdet1 == 1 && westmarkettrd1 == 0)
            {
                westmarkettrd1 = 1;
                btntrad1.Visible = false;
                li.ForeColor = Color.Pink;
                li.Text = "West Market";
                p1lvw.Items.Add(li);
            }
            if (nightmarkettr1 == 1 && nightmarketdet1 == 1 && nightmarkettrd1 == 0)
            {
                nightmarkettrd1 = 1;
                btntrad1.Visible = false;
                li.ForeColor = Color.Pink;
                li.Text = "Night Market";
                p1lvw.Items.Add(li);
            }
            if (daymarkettr1 == 1 && daymarketdet1 == 1 && daymarkettrd1 == 0)
            {
                daymarkettrd1 = 1;
                btntrad1.Visible = false;
                li.ForeColor = Color.Pink;
                li.Text = "Day Market";
                p1lvw.Items.Add(li);
            }

            if (starmarkettr1 == 1 && starmarketdet1 == 1 && starmarkettrd1 == 0)
            {
                starmarkettrd1 = 1;
                btntrad1.Visible = false;
                li.ForeColor = Color.DarkOrange;
                li.Text = "Star Market";
                p1lvw.Items.Add(li);
            }
            if (moonmarkettr1 == 1 && moonmarketdet1 == 1 && moonmarkettrd1 == 0)
            {
                moonmarkettrd1 = 1;
                btntrad1.Visible = false;
                li.ForeColor = Color.DarkOrange;
                li.Text = "Moon Market";
                p1lvw.Items.Add(li);
            }
            if (megamarkettr1 == 1 && megamarketdet1 == 1 && megamarkettrd1 == 0)
            {
                megamarkettrd1 = 1;
                btntrad1.Visible = false;
                li.ForeColor = Color.DarkOrange;
                li.Text = "Mega Market";
                p1lvw.Items.Add(li);
            }

            if (visayashospitaltr1 == 1 && visayashospitaldet1 == 1 && visayashospitaltrd1 == 0)
            {
                visayashospitaltrd1 = 1;
                btntrad1.Visible = false;
                li.ForeColor = Color.Red;
                li.Text = "Visayas Hospital";
                p1lvw.Items.Add(li);
            }
            else if (hobertshospitaltr1 == 1 && hobertshospitaldet1 == 1 && hobertshospitaltrd1 == 0)
            {
                hobertshospitaltrd1 = 1;
                btntrad1.Visible = false;
                li.ForeColor = Color.Red;
                li.Text = "Hobert's Hospital";
                p1lvw.Items.Add(li);
            }
            else if (heartshospitaltr1 == 1 && heartshospitaldet1 == 1 && heartshospitaltrd1 == 0)
            {
                heartshospitaltrd1 = 1;
                btntrad1.Visible = false;
                li.ForeColor = Color.Red;
                li.Text = "Hearts Hospital";
                p1lvw.Items.Add(li);
            }

            if (internshospitaltr1 == 1 && internshospitaldet1 == 1 && internshospitaltrd1 == 0)
            {
                internshospitaltrd1 = 1;
                btntrad1.Visible = false;
                li.ForeColor = Color.LightGoldenrodYellow;
                li.Text = "Intern's Hospital";
                p1lvw.Items.Add(li);
            }
            else if (nationalhealthhospitaltr1 == 1 && nationalhealthhospitaldet1 == 1 && nationalhealthhospitaltrd1 == 0)
            {
                nationalhealthhospitaltrd1 = 1;
                btntrad1.Visible = false;
                li.ForeColor = Color.LightGoldenrodYellow;
                li.Text = "National Health Hospital";
                p1lvw.Items.Add(li);
            }
            else if (veteranshospitaltr1 == 1 && veteranshospitaldet1 == 1 && veteranshospitaltrd1 == 0)
            {
                veteranshospitaltrd1 = 1;
                btntrad1.Visible = false;
                li.ForeColor = Color.LightGoldenrodYellow;
                li.Text = "Veteran's Hospital";
                p1lvw.Items.Add(li);
            }

            if (pearlmalltr1 == 1 && pearlmalldet1 == 1 && pearlmalltrd1 == 0)
            {
                pearlmalltrd1 = 1;
                btntrad1.Visible = false;
                li.ForeColor = Color.Green;
                li.Text = "Pearl Mall";
                p1lvw.Items.Add(li);
            }
            else if (megamalltr1 == 1 && megamalldet1 == 1 && megamalltrd1 == 0)
            {
                megamalltrd1 = 1;
                btntrad1.Visible = false;
                li.ForeColor = Color.Green;
                li.Text = "Mega Mall";
                p1lvw.Items.Add(li);
            }
            else if (articmalltr1 == 1 && articmalldet1 == 1 && articmalltrd1 == 0)
            {
                articmalltr1 = 1;
                btntrad1.Visible = false;
                li.ForeColor = Color.Green;
                li.Text = "Artic Mall";
                p1lvw.Items.Add(li);
            }

            if (heavenlymalltr1 == 1 && heavenlymalldet1 == 1 && heavenlymalltrd1 == 0)
            {
                heavenlymalltrd1 = 1;
                btntrad1.Visible = false;
                li.ForeColor = Color.DarkBlue;
                li.Text = "Heavenly Mall";
                p1lvw.Items.Add(li);
            }
            else if (shangrillamalltr1 == 1 && shangrillamalldet1 == 1 && shangrillamalltrd1 == 0)
            {
                shangrillamalltrd1 = 1;
                btntrad1.Visible = false;
                li.ForeColor = Color.DarkBlue;
                li.Text = "Shangrilla Mall";
                p1lvw.Items.Add(li);
            }

            if (utility1x1tr1 == 1 && utility1x1det1 == 1 && utility1x1trd1 == 0)
            {
                utility1x1trd1 = 1;
                btntrad1.Visible = false;
                li.ForeColor = Color.Yellow;
                li.Text = "Meralco Electricity";
                p1lvw.Items.Add(li);
            }
            else if (utility1x2tr1 == 1 && utility1x2det1 == 1 && utility1x2trd1 == 0)
            {
                utility1x2trd1 = 1;
                btntrad1.Visible = false;
                li.ForeColor = Color.Yellow;
                li.Text = "Niagra Falls Electricity";
                p1lvw.Items.Add(li);
            }

            if (transportation1x1tr1 == 1 && transportation1x1det1 == 1 && transportation1x1trd1 == 0)
            {
                transportation1x1trd1 = 1;
                btntrad1.Visible = false;
                li.ForeColor = Color.SteelBlue;
                li.Text = "Rosevelt Station";
                p1lvw.Items.Add(li);
            }
            else if (transportation1x2tr1 == 1 && transportation1x2det1 == 1 && transportation1x2trd1 == 0)
            {
                transportation1x2trd1 = 1;
                btntrad1.Visible = false;
                li.ForeColor = Color.SteelBlue;
                li.Text = "Santolan Station";
                p1lvw.Items.Add(li);
            }
            else if (transportation1x3tr1 == 1 && transportation1x3det1 == 1 && transportation1x3trd1 == 0)
            {
                transportation1x3trd1 = 1;
                btntrad1.Visible = false;
                li.ForeColor = Color.SteelBlue;
                li.Text = "Fairview Station";
                p1lvw.Items.Add(li);
            }
            else if (transportation1x4tr1 == 1 && transportation1x4det1 == 1 && transportation1x4trd1 == 0)
            {
                transportation1x4trd1 = 1;
                btntrad1.Visible = false;
                li.ForeColor = Color.SteelBlue;
                li.Text = "Sta. Mesa Station";
                p1lvw.Items.Add(li);
            }


        }
        void tradep2trad()
        {
            ListViewItem li = new ListViewItem();

            if (easternschooltr2 == 1 && easternschooldet1 == 1 && easternschooltrd1 == 0)
            {
                easternschooltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Purple;
                li.Text = "Eastern School";
                p1lvw.Items.Add(li);



            }
            if (westernschooltr2 == 1 && westernschooldet1 == 1 && westernschooltrd1 == 0)
            {
                westernschooltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Purple;
                li.Text = "Western School";
                p1lvw.Items.Add(li);
            }

            if (visayashighschooltr2 == 1 && visayashighschooldet1 == 1 && visayashighschooltrd1 == 0)
            {
                visayashighschooltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.LightBlue;
                li.Text = "Visayas High-School";
                p1lvw.Items.Add(li);

            }
            if (southernschooltr2 == 1 && southernschooldet1 == 1 && southernschooltrd1 == 0)
            {
                southernschooltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.LightBlue;
                li.Text = "Southern School";
                p1lvw.Items.Add(li);
            }
            if (nationsschooltr2 == 1 && nationsschooldet1 == 1 && nationsschooltrd1 == 0)
            {
                nationsschooltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.LightBlue;
                li.Text = "Nation's School";
                p1lvw.Items.Add(li);
            }

            if (westmarkettr2 == 1 && westmarketdet1 == 1 && westmarkettrd1 == 0)
            {
                westmarkettrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Pink;
                li.Text = "West Market";
                p1lvw.Items.Add(li);
            }
            if (nightmarkettr2 == 1 && nightmarketdet1 == 1 && nightmarkettrd1 == 0)
            {
                nightmarkettrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Pink;
                li.Text = "Night Market";
                p1lvw.Items.Add(li);
            }
            if (daymarkettr2 == 1 && daymarketdet1 == 1 && daymarkettrd1 == 0)
            {
                daymarkettrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Pink;
                li.Text = "Day Market";
                p1lvw.Items.Add(li);
            }

            if (starmarkettr2 == 1 && starmarketdet1 == 1 && starmarkettrd1 == 0)
            {
                starmarkettrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.DarkOrange;
                li.Text = "Star Market";
                p1lvw.Items.Add(li);
            }
            if (moonmarkettr2 == 1 && moonmarketdet1 == 1 && moonmarkettrd1 == 0)
            {
                moonmarkettrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.DarkOrange;
                li.Text = "Moon Market";
                p1lvw.Items.Add(li);
            }
            if (megamarkettr2 == 1 && megamarketdet1 == 1 && megamarkettrd1 == 0)
            {
                megamarkettrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.DarkOrange;
                li.Text = "Mega Market";
                p1lvw.Items.Add(li);
            }

            if (visayashospitaltr2 == 1 && visayashospitaldet1 == 1 && visayashospitaltrd1 == 0)
            {
                visayashospitaltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Red;
                li.Text = "Visayas Hospital";
                p1lvw.Items.Add(li);
            }
            else if (hobertshospitaltr2 == 1 && hobertshospitaldet1 == 1 && hobertshospitaltrd1 == 0)
            {
                hobertshospitaltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Red;
                li.Text = "Hobert's Hospital";
                p1lvw.Items.Add(li);
            }
            else if (heartshospitaltr2 == 1 && heartshospitaldet1 == 1 && heartshospitaltrd1 == 0)
            {
                heartshospitaltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Red;
                li.Text = "Hearts Hospital";
                p1lvw.Items.Add(li);
            }

            if (internshospitaltr2 == 1 && internshospitaldet1 == 1 && internshospitaltrd1 == 0)
            {
                internshospitaltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.LightGoldenrodYellow;
                li.Text = "Intern's Hospital";
                p1lvw.Items.Add(li);
            }
            else if (nationalhealthhospitaltr2 == 1 && nationalhealthhospitaldet1 == 1 && nationalhealthhospitaltrd1 == 0)
            {
                nationalhealthhospitaltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.LightGoldenrodYellow;
                li.Text = "National Health Hospital";
                p1lvw.Items.Add(li);
            }
            else if (veteranshospitaltr2 == 1 && veteranshospitaldet1 == 1 && veteranshospitaltrd1 == 0)
            {
                veteranshospitaltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.LightGoldenrodYellow;
                li.Text = "Veteran's Hospital";
                p1lvw.Items.Add(li);
            }

            if (pearlmalltr2 == 1 && pearlmalldet1 == 1 && pearlmalltrd1 == 0)
            {
                pearlmalltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Green;
                li.Text = "Pearl Mall";
                p1lvw.Items.Add(li);
            }
            else if (megamalltr2 == 1 && megamalldet1 == 1 && megamalltrd1 == 0)
            {
                megamalltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Green;
                li.Text = "Mega Mall";
                p1lvw.Items.Add(li);
            }
            else if (articmalltr2 == 1 && articmalldet1 == 1 && articmalltrd1 == 0)
            {
                articmalltr2 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Green;
                li.Text = "Artic Mall";
                p1lvw.Items.Add(li);
            }

            if (heavenlymalltr2 == 1 && heavenlymalldet1 == 1 && heavenlymalltrd1 == 0)
            {
                heavenlymalltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.DarkBlue;
                li.Text = "Heavenly Mall";
                p1lvw.Items.Add(li);
            }
            else if (shangrillamalltr2 == 1 && shangrillamalldet1 == 1 && shangrillamalltrd1 == 0)
            {
                shangrillamalltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.DarkBlue;
                li.Text = "Shangrilla Mall";
                p1lvw.Items.Add(li);
            }

            if (utility2x1tr2 == 1 && utility1x1det1 == 1 && utility1x1trd1 == 0)
            {
                utility1x1trd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Yellow;
                li.Text = "Meralco Electricity";
                p1lvw.Items.Add(li);
            }
            else if (utility2x2tr2 == 1 && utility1x2det1 == 1 && utility1x2trd1 == 0)
            {
                utility1x2trd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Yellow;
                li.Text = "Niagra Falls Electricity";
                p1lvw.Items.Add(li);
            }

            if (transportation2x1tr2 == 1 && transportation1x1det1 == 1 && transportation1x1trd1 == 0)
            {
                transportation1x1trd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.SteelBlue;
                li.Text = "Rosevelt Station";
                p1lvw.Items.Add(li);
            }
            else if (transportation2x2tr2 == 1 && transportation1x2det1 == 1 && transportation1x2trd1 == 0)
            {
                transportation1x2trd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.SteelBlue;
                li.Text = "Santolan Station";
                p1lvw.Items.Add(li);
            }
            else if (transportation2x3tr2 == 1 && transportation1x3det1 == 1 && transportation1x3trd1 == 0)
            {
                transportation1x3trd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.SteelBlue;
                li.Text = "Fairview Station";
                p1lvw.Items.Add(li);
            }
            else if (transportation2x4tr2 == 1 && transportation1x4det1 == 1 && transportation1x4trd1 == 0)
            {
                transportation1x4trd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.SteelBlue;
                li.Text = "Sta. Mesa Station";
                p1lvw.Items.Add(li);
            }




        }
        void tradep3trad()
        {
            ListViewItem li = new ListViewItem();

            if (easternschooltr3 == 1 && easternschooldet1 == 1 && easternschooltrd1 == 0)
            {
                easternschooltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Purple;
                li.Text = "Eastern School";
                p1lvw.Items.Add(li);



            }
            if (westernschooltr3 == 1 && westernschooldet1 == 1 && westernschooltrd1 == 0)
            {
                westernschooltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Purple;
                li.Text = "Western School";
                p1lvw.Items.Add(li);
            }

            if (visayashighschooltr3 == 1 && visayashighschooldet1 == 1 && visayashighschooltrd1 == 0)
            {
                visayashighschooltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.LightBlue;
                li.Text = "Visayas High-School";
                p1lvw.Items.Add(li);

            }
            if (southernschooltr3 == 1 && southernschooldet1 == 1 && southernschooltrd1 == 0)
            {
                southernschooltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.LightBlue;
                li.Text = "Southern School";
                p1lvw.Items.Add(li);
            }
            if (nationsschooltr3 == 1 && nationsschooldet1 == 1 && nationsschooltrd1 == 0)
            {
                nationsschooltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.LightBlue;
                li.Text = "Nation's School";
                p1lvw.Items.Add(li);
            }

            if (westmarkettr3 == 1 && westmarketdet1 == 1 && westmarkettrd1 == 0)
            {
                westmarkettrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Pink;
                li.Text = "West Market";
                p1lvw.Items.Add(li);
            }
            if (nightmarkettr3 == 1 && nightmarketdet1 == 1 && nightmarkettrd1 == 0)
            {
                nightmarkettrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Pink;
                li.Text = "Night Market";
                p1lvw.Items.Add(li);
            }
            if (daymarkettr3 == 1 && daymarketdet1 == 1 && daymarkettrd1 == 0)
            {
                daymarkettrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Pink;
                li.Text = "Day Market";
                p1lvw.Items.Add(li);
            }

            if (starmarkettr3 == 1 && starmarketdet1 == 1 && starmarkettrd1 == 0)
            {
                starmarkettrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.DarkOrange;
                li.Text = "Star Market";
                p1lvw.Items.Add(li);
            }
            if (moonmarkettr3 == 1 && moonmarketdet1 == 1 && moonmarkettrd1 == 0)
            {
                moonmarkettrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.DarkOrange;
                li.Text = "Moon Market";
                p1lvw.Items.Add(li);
            }
            if (megamarkettr3 == 1 && megamarketdet1 == 1 && megamarkettrd1 == 0)
            {
                megamarkettrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.DarkOrange;
                li.Text = "Mega Market";
                p1lvw.Items.Add(li);
            }

            if (visayashospitaltr3 == 1 && visayashospitaldet1 == 1 && visayashospitaltrd1 == 0)
            {
                visayashospitaltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Red;
                li.Text = "Visayas Hospital";
                p1lvw.Items.Add(li);
            }
            else if (hobertshospitaltr3 == 1 && hobertshospitaldet1 == 1 && hobertshospitaltrd1 == 0)
            {
                hobertshospitaltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Red;
                li.Text = "Hobert's Hospital";
                p1lvw.Items.Add(li);
            }
            else if (heartshospitaltr3 == 1 && heartshospitaldet1 == 1 && heartshospitaltrd1 == 0)
            {
                heartshospitaltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Red;
                li.Text = "Hearts Hospital";
                p1lvw.Items.Add(li);
            }

            if (internshospitaltr3 == 1 && internshospitaldet1 == 1 && internshospitaltrd1 == 0)
            {
                internshospitaltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.LightGoldenrodYellow;
                li.Text = "Intern's Hospital";
                p1lvw.Items.Add(li);
            }
            else if (nationalhealthhospitaltr3 == 1 && nationalhealthhospitaldet1 == 1 && nationalhealthhospitaltrd1 == 0)
            {
                nationalhealthhospitaltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.LightGoldenrodYellow;
                li.Text = "National Health Hospital";
                p1lvw.Items.Add(li);
            }
            else if (veteranshospitaltr3 == 1 && veteranshospitaldet1 == 1 && veteranshospitaltrd1 == 0)
            {
                veteranshospitaltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.LightGoldenrodYellow;
                li.Text = "Veteran's Hospital";
                p1lvw.Items.Add(li);
            }

            if (pearlmalltr3 == 1 && pearlmalldet1 == 1 && pearlmalltrd1 == 0)
            {
                pearlmalltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Green;
                li.Text = "Pearl Mall";
                p1lvw.Items.Add(li);
            }
            else if (megamalltr3 == 1 && megamalldet1 == 1 && megamalltrd1 == 0)
            {
                megamalltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Green;
                li.Text = "Mega Mall";
                p1lvw.Items.Add(li);
            }
            else if (articmalltr3 == 1 && articmalldet1 == 1 && articmalltrd1 == 0)
            {
                articmalltr3 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Green;
                li.Text = "Artic Mall";
                p1lvw.Items.Add(li);
            }

            if (heavenlymalltr3 == 1 && heavenlymalldet1 == 1 && heavenlymalltrd1 == 0)
            {
                heavenlymalltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.DarkBlue;
                li.Text = "Heavenly Mall";
                p1lvw.Items.Add(li);
            }
            else if (shangrillamalltr3 == 1 && shangrillamalldet1 == 1 && shangrillamalltrd1 == 0)
            {
                shangrillamalltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.DarkBlue;
                li.Text = "Shangrilla Mall";
                p1lvw.Items.Add(li);
            }

            if (utility3x1tr3 == 1 && utility1x1det1 == 1 && utility1x1trd1 == 0)
            {
                utility1x1trd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Yellow;
                li.Text = "Meralco Electricity";
                p1lvw.Items.Add(li);
            }
            else if (utility3x2tr3 == 1 && utility1x2det1 == 1 && utility1x2trd1 == 0)
            {
                utility1x2trd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Yellow;
                li.Text = "Niagra Falls Electricity";
                p1lvw.Items.Add(li);
            }

            if (transportation3x1tr3 == 1 && transportation1x1det1 == 1 && transportation1x1trd1 == 0)
            {
                transportation1x1trd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.SteelBlue;
                li.Text = "Rosevelt Station";
                p1lvw.Items.Add(li);
            }
            else if (transportation3x2tr3 == 1 && transportation1x2det1 == 1 && transportation1x2trd1 == 0)
            {
                transportation1x2trd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.SteelBlue;
                li.Text = "Santolan Station";
                p1lvw.Items.Add(li);
            }
            else if (transportation3x3tr3 == 1 && transportation1x3det1 == 1 && transportation1x3trd1 == 0)
            {
                transportation1x3trd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.SteelBlue;
                li.Text = "Fairview Station";
                p1lvw.Items.Add(li);
            }
            else if (transportation3x4tr3 == 1 && transportation1x4det1 == 1 && transportation1x4trd1 == 0)
            {
                transportation1x4trd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.SteelBlue;
                li.Text = "Sta. Mesa Station";
                p1lvw.Items.Add(li);
            }




        }
        void tradep4trad()
        {
            ListViewItem li = new ListViewItem();

            if (easternschooltr4 == 1 && easternschooldet1 == 1 && easternschooltrd1 == 0)
            {
                easternschooltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Purple;
                li.Text = "Eastern School";
                p1lvw.Items.Add(li);



            }
            if (westernschooltr4 == 1 && westernschooldet1 == 1 && westernschooltrd1 == 0)
            {
                westernschooltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Purple;
                li.Text = "Western School";
                p1lvw.Items.Add(li);
            }

            if (visayashighschooltr4 == 1 && visayashighschooldet1 == 1 && visayashighschooltrd1 == 0)
            {
                visayashighschooltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.LightBlue;
                li.Text = "Visayas High-School";
                p1lvw.Items.Add(li);

            }
            if (southernschooltr4 == 1 && southernschooldet1 == 1 && southernschooltrd1 == 0)
            {
                southernschooltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.LightBlue;
                li.Text = "Southern School";
                p1lvw.Items.Add(li);
            }
            if (nationsschooltr4 == 1 && nationsschooldet1 == 1 && nationsschooltrd1 == 0)
            {
                nationsschooltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.LightBlue;
                li.Text = "Nation's School";
                p1lvw.Items.Add(li);
            }

            if (westmarkettr4 == 1 && westmarketdet1 == 1 && westmarkettrd1 == 0)
            {
                westmarkettrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Pink;
                li.Text = "West Market";
                p1lvw.Items.Add(li);
            }
            if (nightmarkettr4 == 1 && nightmarketdet1 == 1 && nightmarkettrd1 == 0)
            {
                nightmarkettrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Pink;
                li.Text = "Night Market";
                p1lvw.Items.Add(li);
            }
            if (daymarkettr4 == 1 && daymarketdet1 == 1 && daymarkettrd1 == 0)
            {
                daymarkettrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Pink;
                li.Text = "Day Market";
                p1lvw.Items.Add(li);
            }

            if (starmarkettr4 == 1 && starmarketdet1 == 1 && starmarkettrd1 == 0)
            {
                starmarkettrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.DarkOrange;
                li.Text = "Star Market";
                p1lvw.Items.Add(li);
            }
            if (moonmarkettr4 == 1 && moonmarketdet1 == 1 && moonmarkettrd1 == 0)
            {
                moonmarkettrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.DarkOrange;
                li.Text = "Moon Market";
                p1lvw.Items.Add(li);
            }
            if (megamarkettr4 == 1 && megamarketdet1 == 1 && megamarkettrd1 == 0)
            {
                megamarkettrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.DarkOrange;
                li.Text = "Mega Market";
                p1lvw.Items.Add(li);
            }

            if (visayashospitaltr4 == 1 && visayashospitaldet1 == 1 && visayashospitaltrd1 == 0)
            {
                visayashospitaltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Red;
                li.Text = "Visayas Hospital";
                p1lvw.Items.Add(li);
            }
            else if (hobertshospitaltr4 == 1 && hobertshospitaldet1 == 1 && hobertshospitaltrd1 == 0)
            {
                hobertshospitaltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Red;
                li.Text = "Hobert's Hospital";
                p1lvw.Items.Add(li);
            }
            else if (heartshospitaltr4 == 1 && heartshospitaldet1 == 1 && heartshospitaltrd1 == 0)
            {
                heartshospitaltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Red;
                li.Text = "Hearts Hospital";
                p1lvw.Items.Add(li);
            }

            if (internshospitaltr4 == 1 && internshospitaldet1 == 1 && internshospitaltrd1 == 0)
            {
                internshospitaltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.LightGoldenrodYellow;
                li.Text = "Intern's Hospital";
                p1lvw.Items.Add(li);
            }
            else if (nationalhealthhospitaltr4 == 1 && nationalhealthhospitaldet1 == 1 && nationalhealthhospitaltrd1 == 0)
            {
                nationalhealthhospitaltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.LightGoldenrodYellow;
                li.Text = "National Health Hospital";
                p1lvw.Items.Add(li);
            }
            else if (veteranshospitaltr4 == 1 && veteranshospitaldet1 == 1 && veteranshospitaltrd1 == 0)
            {
                veteranshospitaltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.LightGoldenrodYellow;
                li.Text = "Veteran's Hospital";
                p1lvw.Items.Add(li);
            }

            if (pearlmalltr4 == 1 && pearlmalldet1 == 1 && pearlmalltrd1 == 0)
            {
                pearlmalltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Green;
                li.Text = "Pearl Mall";
                p1lvw.Items.Add(li);
            }
            else if (megamalltr4 == 1 && megamalldet1 == 1 && megamalltrd1 == 0)
            {
                megamalltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Green;
                li.Text = "Mega Mall";
                p1lvw.Items.Add(li);
            }
            else if (articmalltr4 == 1 && articmalldet1 == 1 && articmalltrd1 == 0)
            {
                articmalltr4 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Green;
                li.Text = "Artic Mall";
                p1lvw.Items.Add(li);
            }

            if (heavenlymalltr4 == 1 && heavenlymalldet1 == 1 && heavenlymalltrd1 == 0)
            {
                heavenlymalltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.DarkBlue;
                li.Text = "Heavenly Mall";
                p1lvw.Items.Add(li);
            }
            else if (shangrillamalltr4 == 1 && shangrillamalldet1 == 1 && shangrillamalltrd1 == 0)
            {
                shangrillamalltrd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.DarkBlue;
                li.Text = "Shangrilla Mall";
                p1lvw.Items.Add(li);
            }

            if (utility4x1tr4 == 1 && utility1x1det1 == 1 && utility1x1trd1 == 0)
            {
                utility1x1trd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Yellow;
                li.Text = "Meralco Electricity";
                p1lvw.Items.Add(li);
            }
            else if (utility4x2tr4 == 1 && utility1x2det1 == 1 && utility1x2trd1 == 0)
            {
                utility1x2trd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.Yellow;
                li.Text = "Niagra Falls Electricity";
                p1lvw.Items.Add(li);
            }

            if (transportation4x1tr4 == 1 && transportation1x1det1 == 1 && transportation1x1trd1 == 0)
            {
                transportation1x1trd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.SteelBlue;
                li.Text = "Rosevelt Station";
                p1lvw.Items.Add(li);
            }
            else if (transportation4x2tr4 == 1 && transportation1x2det1 == 1 && transportation1x2trd1 == 0)
            {
                transportation1x2trd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.SteelBlue;
                li.Text = "Santolan Station";
                p1lvw.Items.Add(li);
            }
            else if (transportation4x3tr4 == 1 && transportation1x3det1 == 1 && transportation1x3trd1 == 0)
            {
                transportation1x3trd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.SteelBlue;
                li.Text = "Fairview Station";
                p1lvw.Items.Add(li);
            }
            else if (transportation4x4tr4 == 1 && transportation1x4det1 == 1 && transportation1x4trd1 == 0)
            {
                transportation1x4trd1 = 1;
                btntrad2.Visible = false;
                li.ForeColor = Color.SteelBlue;
                li.Text = "Sta. Mesa Station";
                p1lvw.Items.Add(li);
            }




        }
        void p1trtraded1()
        {
            //p1trad to p2
            if (easternschooltr1 == 1 && easternschooltrd1 == 1)
            {
                easternschooltrd1 = 0;
                easternschooltr1d = 0;
                easternschooltr2d = 1;
                easternschooltr3d = 0;
                easternschooltr4d = 0;
                easternschooltr1 = 0;
                easternschooltr2 = 1;
                easternschooltr3 = 0;
                easternschooltr4 = 0;
                pb2x1.Visible = true;
                pb1x1.Visible = false;


            }
            if (westernschooltr1 == 1 && westernschooltrd1 == 1)
            {
                westernschooltrd1 = 0;
                westernschooltr1d = 0;
                westernschooltr2d = 1;
                westernschooltr3d = 0;
                westernschooltr4d = 0;
                westernschooltr1 = 0;
                westernschooltr2 = 1;
                westernschooltr3 = 0;
                westernschooltr4 = 0;
                pb1x2.Visible = false;
                pb2x2.Visible = true;

            }

            if (visayashighschooltr1 == 1 && visayashighschooltrd1 == 1)
            {
                visayashighschooltrd1 = 0;
                visayashighschooltr1d = 0;
                visayashighschooltr2d = 1;
                visayashighschooltr3d = 0;
                visayashighschooltr4d = 0;
                visayashighschooltr1 = 0;
                visayashighschooltr2 = 1;
                visayashighschooltr3 = 0;
                visayashighschooltr4 = 0;
                pb1x3.Visible = false;
                pb2x3.Visible = true;
            }
            if (southernschooltr1 == 1 && southernschooltrd1 == 1)
            {
                southernschooltrd1 = 0;
                southernschooltr1d = 0;
                southernschooltr2d = 1;
                southernschooltr3d = 0;
                southernschooltr4d = 0;
                southernschooltr1 = 0;
                southernschooltr2 = 1;
                southernschooltr3 = 0;
                southernschooltr4 = 0;
                pb1x4.Visible = false;
                pb2x4.Visible = true;
            }
            if (nationsschooltr1 == 1 && nationsschooltrd1 == 1)
            {
                nationsschooltrd1 = 0;
                nationsschooltr1d = 0;
                nationsschooltr2d = 1;
                nationsschooltr3d = 0;
                nationsschooltr4d = 0;
                nationsschooltr1 = 0;
                nationsschooltr2 = 1;
                nationsschooltr3 = 0;
                nationsschooltr4 = 0;
                pb1x5.Visible = false;
                pb2x5.Visible = true;
            }

            if (westmarkettr1 == 1 && westernschooltrd1 == 1)
            {
                westmarkettrd1 = 0;
                westmarkettr1d = 0;
                westmarkettr2d = 1;
                westmarkettr3d = 0;
                westmarkettr4d = 0;
                westmarkettr1 = 0;
                westmarkettr2 = 1;
                westmarkettr3 = 0;
                westmarkettr4 = 0;
                pb1x6.Visible = false;
                pb2x6.Visible = true;

            }
            if (nightmarkettr1 == 1 && nightmarkettrd1 == 1)
            {
                nightmarkettrd1 = 0;
                nightmarkettr1d = 0;
                nightmarkettr2d = 1;
                nightmarkettr3d = 0;
                nightmarkettr4d = 0;
                nightmarkettr1 = 0;
                nightmarkettr2 = 1;
                nightmarkettr3 = 0;
                nightmarkettr4 = 0;
                pb1x7.Visible = false;
                pb2x7.Visible = true;
            }
            if (daymarkettr1 == 1 && daymarkettrd1 == 1)
            {
                daymarkettrd1 = 0;
                daymarkettr1d = 0;
                daymarkettr2d = 1;
                daymarkettr3d = 0;
                daymarkettr4d = 0;
                daymarkettr1 = 0;
                daymarkettr2 = 1;
                daymarkettr3 = 0;
                daymarkettr4 = 0;
                pb1x8.Visible = false;
                pb2x8.Visible = true;
            }

            if (starmarkettr1 == 1 && starmarkettrd1 == 1)
            {
                starmarkettrd1 = 0;
                starmarkettr1d = 0;
                starmarkettr2d = 1;
                starmarkettr3d = 0;
                starmarkettr4d = 0;
                starmarkettr1 = 0;
                starmarkettr2 = 1;
                starmarkettr3 = 0;
                starmarkettr4 = 0;
                pb1x9.Visible = false;
                pb2x9.Visible = true;
            }
            if (moonmarkettr1 == 1 && moonmarkettrd1 == 1)
            {
                moonmarkettrd1 = 0;
                moonmarkettr1d = 0;
                moonmarkettr2d = 1;
                moonmarkettr3d = 0;
                moonmarkettr4d = 0;
                moonmarkettr1 = 0;
                moonmarkettr2 = 1;
                moonmarkettr3 = 0;
                moonmarkettr4 = 0;
                pb1x10.Visible = false;
                pb2x10.Visible = true;
            }
            if (megamarkettr1 == 1 && megamarkettrd1 == 1)
            {
                megamarkettrd1 = 0;
                megamarkettr1d = 0;
                megamarkettr2d = 1;
                megamarkettr3d = 0;
                megamarkettr4d = 0;
                megamarkettr1 = 0;
                megamarkettr2 = 1;
                megamarkettr3 = 0;
                megamarkettr4 = 0;
                pb1x11.Visible = false;
                pb2x11.Visible = true;
            }

            if (visayashospitaltr1 == 1 && visayashospitaltrd1 == 1)
            {
                visayashospitaltrd1 = 0;
                visayashospitaltr1d = 0;
                visayashospitaltr2d = 1;
                visayashospitaltr3d = 0;
                visayashospitaltr4d = 0;
                visayashospitaltr1 = 0;
                visayashospitaltr2 = 1;
                visayashospitaltr3 = 0;
                visayashospitaltr4 = 0;
                pb1x12.Visible = false;
                pb2x12.Visible = true;
            }
            if (hobertshospitaltr1 == 1 && hobertshospitaltrd1 == 1)
            {
                hobertshospitaltrd1 = 0;
                hobertshospitaltr1d = 0;
                hobertshospitaltr2d = 1;
                hobertshospitaltr3d = 0;
                hobertshospitaltr4d = 0;
                hobertshospitaltr1 = 0;
                hobertshospitaltr2 = 1;
                hobertshospitaltr1 = 0;
                hobertshospitaltr2 = 0;
                pb1x13.Visible = false;
                pb2x13.Visible = true;
            }
            if (heartshospitaltr1 == 1 && heartshospitaltrd1 == 1)
            {
                heartshospitaltrd1 = 0;
                heartshospitaltr1d = 0;
                heartshospitaltr2d = 1;
                heartshospitaltr3d = 0;
                heartshospitaltr4d = 0;
                heartshospitaltr1 = 0;
                heartshospitaltr2 = 1;
                heartshospitaltr3 = 0;
                heartshospitaltr4 = 0;
                pb1x14.Visible = false;
                pb2x14.Visible = true;

            }

            if (internshospitaltr1 == 1 && internshospitaltrd1 == 1)
            {
                internshospitaltrd1 = 0;
                internshospitaltr1d = 0;
                internshospitaltr2d = 1;
                internshospitaltr3d = 0;
                internshospitaltr4d = 0;
                internshospitaltr1 = 0;
                internshospitaltr2 = 1;
                internshospitaltr3 = 0;
                internshospitaltr4 = 0;
                pb1x15.Visible = false;
                pb2x15.Visible = true;



            }
            if (nationalhealthhospitaltr1 == 1 && nationalhealthhospitaltrd1 == 1)
            {
                nationalhealthhospitaltrd1 = 0;
                nationalhealthhospitaltr1d = 0;
                nationalhealthhospitaltr2d = 1;
                nationalhealthhospitaltr3d = 0;
                nationalhealthhospitaltr4d = 0;
                nationalhealthhospitaltr1 = 0;
                nationalhealthhospitaltr2 = 1;
                nationalhealthhospitaltr3 = 0;
                nationalhealthhospitaltr4 = 0;
                pb1x16.Visible = false;
                pb2x16.Visible = true;
            }
            if (veteranshospitaltr1 == 1 && veteranshospitaltrd1 == 1)
            {
                veteranshospitaltrd1 = 0;
                veteranshospitaltr1d = 0;
                veteranshospitaltr2d = 1;
                veteranshospitaltr3d = 0;
                veteranshospitaltr4d = 0;
                veteranshospitaltr1 = 0;
                veteranshospitaltr2 = 1;
                veteranshospitaltr3 = 0;
                veteranshospitaltr4 = 0;
                pb1x17.Visible = false;
                pb2x17.Visible = true;
            }

            if (pearlmalltr1 == 1 && pearlmalltrd1 == 1)
            {
                pearlmalltrd1 = 0;
                pearlmalltr1d = 0;
                pearlmalltr2d = 1;
                pearlmalltr3d = 0;
                pearlmalltr4d = 0;
                pearlmalltr1 = 0;
                pearlmalltr2 = 1;
                pearlmalltr3 = 0;
                pearlmalltr4 = 0;
                pb1x18.Visible = false;
                pb2x18.Visible = true;
            }
            if (megamalltr1 == 1 && megamalltrd1 == 1)
            {
                megamalltrd1 = 0;
                megamalltr1d = 0;
                megamalltr2d = 1;
                megamalltr3d = 0;
                megamalltr4d = 0;
                megamalltr1 = 0;
                megamalltr2 = 1;
                megamalltr3 = 0;
                megamalltr4 = 0;
                pb1x19.Visible = false;
                pb2x19.Visible = true;
            }
            if (articmalltr1 == 1 && articmalltrd1 == 1)
            {
                articmalltrd1 = 0;
                articmalltr1d = 0;
                articmalltr2d = 1;
                articmalltr3d = 0;
                articmalltr4d = 0;
                articmalltr1 = 0;
                articmalltr2 = 1;
                articmalltr3 = 0;
                articmalltr4 = 0;
                pb1x20.Visible = false;
                pb2x20.Visible = true;
            }

            if (heavenlymalltr1 == 1 && heavenlymalltrd1 == 1)
            {
                heavenlymalltrd1 = 0;
                heavenlymalltr1d = 0;
                heavenlymalltr2d = 1;
                heavenlymalltr3d = 0;
                heavenlymalltr4d = 0;
                heavenlymalltr1 = 0;
                heavenlymalltr2 = 1;
                heavenlymalltr3 = 0;
                heavenlymalltr4 = 0;
                pb1x21.Visible = false;
                pb2x21.Visible = true;
            }
            if (shangrillamalltr1 == 1 && shangrillamalltrd1 == 1)
            {
                shangrillamalltrd1 = 0;
                shangrillamalltr1d = 0;
                shangrillamalltr2d = 1;
                shangrillamalltr3d = 0;
                shangrillamalltr4d = 0;
                shangrillamalltr1 = 0;
                shangrillamalltr2 = 1;
                shangrillamalltr3 = 0;
                shangrillamalltr4 = 0;
                pb1x22.Visible = false;
                pb2x22.Visible = true;
            }

            if (utility1x1tr1 == 1 && utility1x1trd1 == 1)
            {
                utility1x1trd1 = 0;
                utility1x1tr1d = 0;
                utility2x1tr2d = 1;
                utility3x1tr3d = 0;
                utility4x1tr4d = 0;
                utility1x1tr1 = 0;
                utility2x1tr2 = 1;
                utility3x1tr3 = 0;
                utility4x1tr4 = 0;
                pb1x23.Visible = false;
                pb2x23.Visible = true;
            }
            if (utility1x2tr1 == 1 && utility1x2trd1 == 1)
            {
                utility1x2trd1 = 0;
                utility1x2tr1d = 0;
                utility2x2tr2d = 1;
                utility3x2tr3d = 0;
                utility4x2tr4d = 0;
                utility1x2tr1 = 0;
                utility2x2tr2 = 1;
                utility3x2tr3 = 0;
                utility4x2tr4 = 0;

                pb1x24.Visible = false;
                pb2x24.Visible = true;
            }

            if (transportation1x1tr1 == 1 && transportation1x1trd1 == 1)
            {
                transportation1x1trd1 = 0;
                transportation1x1tr1d = 0;
                transportation2x1tr2d = 1;
                transportation3x1tr3d = 0;
                transportation4x1tr4d = 0;
                transportation1x1tr1 = 0;
                transportation2x1tr2 = 1;
                transportation3x1tr3 = 0;
                transportation4x1tr4 = 0;
                pb1x25.Visible = false;
                pb2x25.Visible = true;
            }
            if (transportation1x2tr1 == 1 && transportation1x2trd1 == 1)
            {
                transportation1x2trd1 = 0;
                transportation1x2tr1d = 0;
                transportation2x2tr2d = 1;
                transportation3x2tr3d = 0;
                transportation4x2tr4d = 0;
                transportation1x2tr1 = 0;
                transportation2x2tr2 = 1;
                transportation3x2tr3 = 0;
                transportation4x2tr4 = 0;
                pb1x26.Visible = false;
                pb2x26.Visible = true;
            }
            if (transportation1x3tr1 == 1 && transportation1x3trd1 == 1)
            {
                transportation1x3trd1 = 0;
                transportation1x3tr1d = 0;
                transportation2x3tr2d = 1;
                transportation3x3tr3d = 0;
                transportation4x3tr4d = 0;
                transportation1x3tr1 = 0;
                transportation2x3tr2 = 1;
                transportation3x3tr3 = 0;
                transportation4x3tr4 = 0;
                pb1x27.Visible = false;
                pb2x27.Visible = true;
            }
            if (transportation1x4tr1 == 1 && transportation1x4trd1 == 1)
            {
                transportation1x4trd1 = 0;
                transportation1x4tr1d = 0;
                transportation2x4tr2d = 1;
                transportation3x4tr3d = 0;
                transportation4x4tr4d = 0;
                transportation1x4tr1 = 0;
                transportation2x4tr2 = 1;
                transportation3x4tr3 = 0;
                transportation4x4tr4 = 0;
                pb1x28.Visible = false;
                pb2x28.Visible = true;
            }



        }
        void p1trtraded1_3()
        {
            //p1 to p3 
            if (easternschooltr1 == 1 && easternschooltrd1 == 1)
            {
                easternschooltrd1 = 0;
                easternschooltr1d = 0;
                easternschooltr2d = 0;
                easternschooltr3d = 1;
                easternschooltr4d = 0;
                easternschooltr1 = 0;
                easternschooltr2 = 0;
                easternschooltr3 = 1;
                easternschooltr4 = 0;
                pb1x1.Visible = false;
                pb2x1.Visible = true;


            }
            if (westernschooltr1 == 1 && westernschooltrd1 == 1 && p4_gameplay.p3tr == 1)
            {
                westernschooltrd1 = 0;
                westernschooltr1d = 0;
                westernschooltr2d = 0;
                westernschooltr3d = 1;
                westernschooltr4d = 0;
                westernschooltr1 = 0;
                westernschooltr2 = 0;
                westernschooltr3 = 1;
                westernschooltr4 = 0;
                pb1x2.Visible = false;
                pb2x2.Visible = true;

            }

            if (visayashighschooltr1 == 1 && visayashighschooltrd1 == 1)
            {
                visayashighschooltrd1 = 0;
                visayashighschooltr1d = 0;
                visayashighschooltr2d = 0;
                visayashighschooltr3d = 1;
                visayashighschooltr4d = 0;
                visayashighschooltr1 = 0;
                visayashighschooltr2 = 0;
                visayashighschooltr3 = 1;
                visayashighschooltr4 = 0;
                pb1x3.Visible = false;
                pb2x3.Visible = true;
            }
            if (southernschooltr1 == 1 && southernschooltrd1 == 1)
            {
                southernschooltrd1 = 0;
                southernschooltr1d = 0;
                southernschooltr2d = 0;
                southernschooltr3d = 1;
                southernschooltr4d = 0;
                southernschooltr1 = 0;
                southernschooltr2 = 0;
                southernschooltr3 = 1;
                southernschooltr4 = 0;
                pb1x4.Visible = false;
                pb2x4.Visible = true;
            }
            if (nationsschooltr1 == 1 && nationsschooltrd1 == 1)
            {
                nationsschooltrd1 = 0;
                nationsschooltr1d = 0;
                nationsschooltr2d = 0;
                nationsschooltr3d = 1;
                nationsschooltr4d = 0;
                nationsschooltr1 = 0;
                nationsschooltr2 = 0;
                nationsschooltr3 = 1;
                nationsschooltr4 = 0;
                pb1x5.Visible = false;
                pb2x5.Visible = true;
            }

            if (westmarkettr1 == 1 && westernschooltrd1 == 1)
            {
                westmarkettrd1 = 0;
                westmarkettr1d = 0;
                westmarkettr2d = 0;
                westmarkettr3d = 1;
                westmarkettr4d = 0;
                westmarkettr1 = 0;
                westmarkettr2 = 0;
                westmarkettr3 = 1;
                westmarkettr4 = 0;
                pb1x6.Visible = false;
                pb2x6.Visible = true;

            }
            if (nightmarkettr1 == 1 && nightmarkettrd1 == 1)
            {
                nightmarkettrd1 = 0;
                nightmarkettr1d = 0;
                nightmarkettr2d = 0;
                nightmarkettr3d = 1;
                nightmarkettr4d = 0;
                nightmarkettr1 = 0;
                nightmarkettr2 = 0;
                nightmarkettr3 = 1;
                nightmarkettr4 = 0;
                pb1x7.Visible = false;
                pb2x7.Visible = true;
            }
            if (daymarkettr1 == 1 && daymarkettrd1 == 1)
            {
                daymarkettrd1 = 0;
                daymarkettr1d = 0;
                daymarkettr2d = 0;
                daymarkettr3d = 1;
                daymarkettr4d = 0;
                daymarkettr1 = 0;
                daymarkettr2 = 0;
                daymarkettr3 = 1;
                daymarkettr4 = 0;
                pb1x8.Visible = false;
                pb2x8.Visible = true;
            }

            if (starmarkettr1 == 1 && starmarkettrd1 == 1)
            {
                starmarkettrd1 = 0;
                starmarkettr1d = 0;
                starmarkettr2d = 0;
                starmarkettr3d = 1;
                starmarkettr4d = 0;
                starmarkettr1 = 0;
                starmarkettr2 = 0;
                starmarkettr3 = 1;
                starmarkettr4 = 0;
                pb1x9.Visible = false;
                pb2x9.Visible = true;
            }
            if (moonmarkettr1 == 1 && moonmarkettrd1 == 1)
            {
                moonmarkettrd1 = 0;
                moonmarkettr1d = 0;
                moonmarkettr2d = 0;
                moonmarkettr3d = 1;
                moonmarkettr4d = 0;
                moonmarkettr1 = 0;
                moonmarkettr2 = 0;
                moonmarkettr3 = 1;
                moonmarkettr4 = 0;
                pb1x10.Visible = false;
                pb2x10.Visible = true;
            }
            if (megamarkettr1 == 1 && megamarkettrd1 == 1)
            {
                megamarkettrd1 = 0;
                megamarkettr1d = 0;
                megamarkettr2d = 0;
                megamarkettr3d = 1;
                megamarkettr4d = 0;
                megamarkettr1 = 0;
                megamarkettr2 = 0;
                megamarkettr3 = 1;
                megamarkettr4 = 0;
                pb1x11.Visible = false;
                pb2x11.Visible = true;
            }

            if (visayashospitaltr1 == 1 && visayashospitaltrd1 == 1)
            {
                visayashospitaltrd1 = 0;
                visayashospitaltr1d = 0;
                visayashospitaltr2d = 0;
                visayashospitaltr3d = 1;
                visayashospitaltr4d = 0;
                visayashospitaltr1 = 0;
                visayashospitaltr2 = 0;
                visayashospitaltr3 = 1;
                visayashospitaltr4 = 0;
                pb1x12.Visible = false;
                pb2x12.Visible = true;
            }
            if (hobertshospitaltr1 == 1 && hobertshospitaltrd1 == 1)
            {
                hobertshospitaltrd1 = 0;
                hobertshospitaltr1d = 0;
                hobertshospitaltr2d = 0;
                hobertshospitaltr3d = 1;
                hobertshospitaltr4d = 0;
                hobertshospitaltr1 = 0;
                hobertshospitaltr2 = 0;
                hobertshospitaltr3 = 1;
                hobertshospitaltr4 = 0;
                pb1x13.Visible = false;
                pb2x13.Visible = true;
            }
            if (heartshospitaltr1 == 1 && heartshospitaltrd1 == 1)
            {
                heartshospitaltrd1 = 0;
                heartshospitaltr1d = 0;
                heartshospitaltr2d = 0;
                heartshospitaltr3d = 1;
                heartshospitaltr4d = 0;
                heartshospitaltr1 = 0;
                heartshospitaltr2 = 0;
                heartshospitaltr3 = 1;
                heartshospitaltr4 = 0;
                pb1x14.Visible = false;
                pb2x14.Visible = true;

            }

            if (internshospitaltr1 == 1 && internshospitaltrd1 == 1)
            {
                internshospitaltrd1 = 0;
                internshospitaltr1d = 0;
                internshospitaltr2d = 0;
                internshospitaltr3d = 1;
                internshospitaltr4d = 0;
                internshospitaltr1 = 0;
                internshospitaltr2 = 0;
                internshospitaltr3 = 1;
                internshospitaltr4 = 0;
                pb1x15.Visible = false;
                pb2x15.Visible = true;



            }
            if (nationalhealthhospitaltr1 == 1 && nationalhealthhospitaltrd1 == 1)
            {
                nationalhealthhospitaltrd1 = 0;
                nationalhealthhospitaltr1d = 0;
                nationalhealthhospitaltr2d = 0;
                nationalhealthhospitaltr3d = 1;
                nationalhealthhospitaltr4d = 0;
                nationalhealthhospitaltr1 = 0;
                nationalhealthhospitaltr2 = 0;
                nationalhealthhospitaltr3 = 1;
                nationalhealthhospitaltr4 = 0;
                pb1x16.Visible = false;
                pb2x16.Visible = true;
            }
            if (veteranshospitaltr1 == 1 && veteranshospitaltrd1 == 1)
            {
                veteranshospitaltrd1 = 0;
                veteranshospitaltr1d = 0;
                veteranshospitaltr2d = 0;
                veteranshospitaltr3d = 1;
                veteranshospitaltr4d = 0;
                veteranshospitaltr1 = 0;
                veteranshospitaltr2 = 0;
                veteranshospitaltr3 = 1;
                veteranshospitaltr4 = 0;
                pb1x17.Visible = false;
                pb2x17.Visible = true;
            }

            if (pearlmalltr1 == 1 && pearlmalltrd1 == 1)
            {
                pearlmalltrd1 = 0;
                pearlmalltr1d = 0;
                pearlmalltr2d = 0;
                pearlmalltr3d = 1;
                pearlmalltr4d = 0;
                pearlmalltr1 = 0;
                pearlmalltr2 = 0;
                pearlmalltr3 = 1;
                pearlmalltr4 = 0;
                pb1x18.Visible = false;
                pb2x18.Visible = true;
            }
            if (megamalltr1 == 1 && megamalltrd1 == 1)
            {
                megamalltrd1 = 0;
                megamalltr1d = 0;
                megamalltr2d = 0;
                megamalltr3d = 1;
                megamalltr4d = 0;
                megamalltr1 = 0;
                megamalltr2 = 0;
                megamalltr3 = 1;
                megamalltr4 = 0;
                pb1x19.Visible = false;
                pb2x19.Visible = true;
            }
            if (articmalltr1 == 1 && articmalltrd1 == 1)
            {
                articmalltrd1 = 0;
                articmalltr1d = 0;
                articmalltr2d = 0;
                articmalltr3d = 1;
                articmalltr4d = 0;
                articmalltr1 = 0;
                articmalltr2 = 0;
                articmalltr3 = 1;
                articmalltr4 = 0;
                pb1x20.Visible = false;
                pb2x20.Visible = true;
            }

            if (heavenlymalltr1 == 1 && heavenlymalltrd1 == 1)
            {
                heavenlymalltrd1 = 0;
                heavenlymalltr1d = 0;
                heavenlymalltr2d = 0;
                heavenlymalltr3d = 1;
                heavenlymalltr4d = 0;
                heavenlymalltr1 = 0;
                heavenlymalltr2 = 0;
                heavenlymalltr3 = 1;
                heavenlymalltr4 = 0;
                pb1x21.Visible = false;
                pb2x21.Visible = true;
            }
            if (shangrillamalltr1 == 1 && shangrillamalltrd1 == 1)
            {
                shangrillamalltrd1 = 0;
                shangrillamalltr1d = 0;
                shangrillamalltr2d = 0;
                shangrillamalltr3d = 1;
                shangrillamalltr4d = 0;
                shangrillamalltr1 = 0;
                shangrillamalltr2 = 0;
                shangrillamalltr3 = 1;
                shangrillamalltr4 = 0;
                pb1x22.Visible = false;
                pb2x22.Visible = true;
            }

            if (utility1x1tr1 == 1 && utility1x1trd1 == 1)
            {
                utility1x1trd1 = 0;
                utility1x1tr1d = 0;
                utility2x1tr2d = 0;
                utility3x1tr3d = 1;
                utility4x1tr4d = 0;
                utility1x1tr1 = 0;
                utility2x1tr2 = 0;
                utility3x1tr3 = 1;
                utility4x1tr4 = 0;
                pb1x23.Visible = false;
                pb2x23.Visible = true;
            }
            if (utility1x2tr1 == 1 && utility1x2trd1 == 1)
            {
                utility1x2trd1 = 0;
                utility1x2tr1d = 0;
                utility2x2tr2d = 0;
                utility3x2tr3d = 1;
                utility4x2tr4d = 0;
                utility1x2tr1 = 0;
                utility2x2tr2 = 0;
                utility3x2tr3 = 1;
                utility4x2tr4 = 0;
                pb1x24.Visible = false;
                pb2x24.Visible = true;
            }

            if (transportation1x1tr1 == 1 && transportation1x1trd1 == 1)
            {
                transportation1x1trd1 = 0;
                transportation1x1tr1d = 0;
                transportation2x1tr2d = 0;
                transportation3x1tr3d = 1;
                transportation4x1tr4d = 0;
                transportation1x1tr1 = 0;
                transportation2x1tr2 = 0;
                transportation3x1tr3 = 1;
                transportation4x1tr4 = 0;
                pb1x25.Visible = false;
                pb2x25.Visible = true;
            }
            if (transportation1x2tr1 == 1 && transportation1x2trd1 == 1)
            {
                transportation1x2trd1 = 0;
                transportation1x2tr1d = 0;
                transportation2x2tr2d = 0;
                transportation3x2tr3d = 1;
                transportation4x2tr4d = 0;
                transportation1x2tr1 = 0;
                transportation2x2tr2 = 0;
                transportation3x2tr3 = 1;
                transportation4x2tr4 = 0;
                pb1x26.Visible = false;
                pb2x26.Visible = true;
            }
            if (transportation1x3tr1 == 1 && transportation1x3trd1 == 1)
            {
                transportation1x3trd1 = 0;
                transportation1x3tr1d = 0;
                transportation2x3tr2d = 0;
                transportation3x3tr3d = 1;
                transportation4x3tr4d = 0;
                transportation1x3tr1 = 0;
                transportation2x3tr2 = 0;
                transportation3x3tr3 = 1;
                transportation4x3tr4 = 0;
                pb1x27.Visible = false;
                pb2x27.Visible = true;
            }
            if (transportation1x4tr1 == 1 && transportation1x4trd1 == 1)
            {
                transportation1x4trd1 = 0;
                transportation1x4tr1d = 0;
                transportation2x4tr2d = 0;
                transportation3x4tr3d = 1;
                transportation4x4tr4d = 0;
                transportation1x4tr1 = 0;
                transportation2x4tr2 = 0;
                transportation3x4tr3 = 1;
                transportation4x4tr4 = 0;
                pb1x28.Visible = false;
                pb2x28.Visible = true;
            }

        }
        void p1trtraded1_4()
        {
            //p1 to p4
            if (easternschooltr1 == 1 && easternschooltrd1 == 1)
            {
                easternschooltrd1 = 0;
                easternschooltr1d = 0;
                easternschooltr2d = 0;
                easternschooltr3d = 0;
                easternschooltr4d = 1;
                easternschooltr1 = 0;
                easternschooltr2 = 0;
                easternschooltr3 = 0;
                easternschooltr4 = 1;
                pb1x1.Visible = false;
                pb2x1.Visible = true;


            }
            if (westernschooltr1 == 1 && westernschooltrd1 == 1)
            {
                westernschooltrd1 = 0;
                westernschooltr1d = 0;
                westernschooltr2d = 0;
                westernschooltr3d = 0;
                westernschooltr4d = 1;
                westernschooltr1 = 0;
                westernschooltr2 = 0;
                westernschooltr3 = 0;
                westernschooltr4 = 1;
                pb1x2.Visible = false;
                pb2x2.Visible = true;

            }

            if (visayashighschooltr1 == 1 && visayashighschooltrd1 == 1)
            {
                visayashighschooltrd1 = 0;
                visayashighschooltr1d = 0;
                visayashighschooltr2d = 0;
                visayashighschooltr3d = 0;
                visayashighschooltr4d = 1;
                visayashighschooltr1 = 0;
                visayashighschooltr2 = 0;
                visayashighschooltr3 = 0;
                visayashighschooltr4 = 1;
                pb1x3.Visible = false;
                pb2x3.Visible = true;
            }
            if (southernschooltr1 == 1 && southernschooltrd1 == 1)
            {
                southernschooltrd1 = 0;
                southernschooltr1d = 0;
                southernschooltr2d = 0;
                southernschooltr3d = 0;
                southernschooltr4d = 1;
                southernschooltr1 = 0;
                southernschooltr2 = 0;
                southernschooltr3 = 0;
                southernschooltr4 = 1;
                pb1x4.Visible = false;
                pb2x4.Visible = true;
            }
            if (nationsschooltr1 == 1 && nationsschooltrd1 == 1)
            {
                nationsschooltrd1 = 0;
                nationsschooltr1d = 0;
                nationsschooltr2d = 0;
                nationsschooltr3d = 0;
                nationsschooltr4d = 1;
                nationsschooltr1 = 0;
                nationsschooltr2 = 0;
                nationsschooltr3 = 0;
                nationsschooltr4 = 1;
                pb1x5.Visible = false;
                pb2x5.Visible = true;
            }

            if (westmarkettr1 == 1 && westernschooltrd1 == 1)
            {
                westmarkettrd1 = 0;
                westmarkettr1d = 0;
                westmarkettr2d = 0;
                westmarkettr3d = 0;
                westmarkettr4d = 1;
                westmarkettr1 = 0;
                westmarkettr2 = 0;
                westmarkettr3 = 0;
                westmarkettr4 = 1;
                pb1x6.Visible = false;
                pb2x6.Visible = true;

            }
            if (nightmarkettr1 == 1 && nightmarkettrd1 == 1)
            {
                nightmarkettrd1 = 0;
                nightmarkettr1d = 0;
                nightmarkettr2d = 0;
                nightmarkettr3d = 0;
                nightmarkettr4d = 1;
                nightmarkettr1 = 0;
                nightmarkettr2 = 0;
                nightmarkettr3 = 0;
                nightmarkettr4 = 1;
                pb1x7.Visible = false;
                pb2x7.Visible = true;
            }
            if (daymarkettr1 == 1 && daymarkettrd1 == 1)
            {
                daymarkettrd1 = 0;
                daymarkettr1d = 0;
                daymarkettr2d = 0;
                daymarkettr3d = 0;
                daymarkettr4d = 1;
                daymarkettr1 = 0;
                daymarkettr2 = 0;
                daymarkettr3 = 0;
                daymarkettr4 = 1;
                pb1x8.Visible = false;
                pb2x8.Visible = true;
            }

            if (starmarkettr1 == 1 && starmarkettrd1 == 1)
            {
                starmarkettrd1 = 0;
                starmarkettr1d = 0;
                starmarkettr2d = 0;
                starmarkettr3d = 0;
                starmarkettr4d = 1;
                starmarkettr1 = 0;
                starmarkettr2 = 0;
                starmarkettr3 = 0;
                starmarkettr4 = 1;
                pb1x9.Visible = false;
                pb2x9.Visible = true;
            }
            if (moonmarkettr1 == 1 && moonmarkettrd1 == 1)
            {
                moonmarkettrd1 = 0;
                moonmarkettr1d = 0;
                moonmarkettr2d = 0;
                moonmarkettr3d = 0;
                moonmarkettr4d = 1;
                moonmarkettr1 = 0;
                moonmarkettr2 = 0;
                moonmarkettr3 = 0;
                moonmarkettr4 = 1;
                pb1x10.Visible = false;
                pb2x10.Visible = true;
            }
            if (megamarkettr1 == 1 && megamarkettrd1 == 1)
            {
                megamarkettrd1 = 0;
                megamarkettr1d = 0;
                megamarkettr2d = 0;
                megamarkettr3d = 0;
                megamarkettr4d = 1;
                megamarkettr1 = 0;
                megamarkettr2 = 0;
                megamarkettr3 = 0;
                megamarkettr4 = 1;
                pb1x11.Visible = false;
                pb2x11.Visible = true;
            }

            if (visayashospitaltr1 == 1 && visayashospitaltrd1 == 1)
            {
                visayashospitaltrd1 = 0;
                visayashospitaltr1d = 0;
                visayashospitaltr2d = 0;
                visayashospitaltr3d = 0;
                visayashospitaltr4d = 1;
                visayashospitaltr1 = 0;
                visayashospitaltr2 = 0;
                visayashospitaltr3 = 0;
                visayashospitaltr4 = 1;
                pb1x12.Visible = false;
                pb2x12.Visible = true;
            }
            if (hobertshospitaltr1 == 1 && hobertshospitaltrd1 == 1)
            {
                hobertshospitaltrd1 = 0;
                hobertshospitaltr1d = 0;
                hobertshospitaltr2d = 0;
                hobertshospitaltr3d = 0;
                hobertshospitaltr4d = 1;
                hobertshospitaltr1 = 0;
                hobertshospitaltr2 = 0;
                hobertshospitaltr3 = 0;
                hobertshospitaltr4 = 1;
                pb1x13.Visible = false;
                pb2x13.Visible = true;
            }
            if (heartshospitaltr1 == 1 && heartshospitaltrd1 == 1)
            {
                heartshospitaltrd1 = 0;
                heartshospitaltr1d = 0;
                heartshospitaltr2d = 0;
                heartshospitaltr3d = 0;
                heartshospitaltr4d = 1;
                heartshospitaltr1 = 0;
                heartshospitaltr2 = 0;
                heartshospitaltr3 = 0;
                heartshospitaltr4 = 1;
                pb1x14.Visible = false;
                pb2x14.Visible = true;

            }

            if (internshospitaltr1 == 1 && internshospitaltrd1 == 1)
            {
                internshospitaltrd1 = 0;
                internshospitaltr1d = 0;
                internshospitaltr2d = 0;
                internshospitaltr3d = 0;
                internshospitaltr4d = 1;
                internshospitaltr1 = 0;
                internshospitaltr2 = 0;
                internshospitaltr3 = 0;
                internshospitaltr4 = 1;
                pb1x15.Visible = false;
                pb2x15.Visible = true;



            }
            if (nationalhealthhospitaltr1 == 1 && nationalhealthhospitaltrd1 == 1)
            {
                nationalhealthhospitaltrd1 = 0;
                nationalhealthhospitaltr1d = 0;
                nationalhealthhospitaltr2d = 0;
                nationalhealthhospitaltr3d = 0;
                nationalhealthhospitaltr4d = 1;
                nationalhealthhospitaltr1 = 0;
                nationalhealthhospitaltr2 = 0;
                nationalhealthhospitaltr3 = 0;
                nationalhealthhospitaltr4 = 1;
                pb1x16.Visible = false;
                pb2x16.Visible = true;
            }
            if (veteranshospitaltr1 == 1 && veteranshospitaltrd1 == 1)
            {
                veteranshospitaltrd1 = 0;
                veteranshospitaltr1d = 0;
                veteranshospitaltr2d = 0;
                veteranshospitaltr3d = 0;
                veteranshospitaltr4d = 1;
                veteranshospitaltr1 = 0;
                veteranshospitaltr2 = 0;
                veteranshospitaltr3 = 0;
                veteranshospitaltr4 = 1;
                pb1x17.Visible = false;
                pb2x17.Visible = true;
            }

            if (pearlmalltr1 == 1 && pearlmalltrd1 == 1)
            {
                pearlmalltrd1 = 0;
                pearlmalltr1d = 0;
                pearlmalltr2d = 0;
                pearlmalltr3d = 0;
                pearlmalltr4d = 1;
                pearlmalltr1 = 0;
                pearlmalltr2 = 0;
                pearlmalltr3 = 0;
                pearlmalltr4 = 1;
                pb1x18.Visible = false;
                pb2x18.Visible = true;
            }
            if (megamalltr1 == 1 && megamalltrd1 == 1)
            {
                megamalltrd1 = 0;
                megamalltr1d = 0;
                megamalltr2d = 0;
                megamalltr3d = 0;
                megamalltr4d = 1;
                megamalltr1 = 0;
                megamalltr2 = 0;
                megamalltr3 = 0;
                megamalltr4 = 1;
                pb1x19.Visible = false;
                pb2x19.Visible = true;
            }
            if (articmalltr1 == 1 && articmalltrd1 == 1)
            {
                articmalltrd1 = 0;
                articmalltr1d = 0;
                articmalltr2d = 0;
                articmalltr3d = 0;
                articmalltr4d = 1;
                articmalltr1 = 0;
                articmalltr2 = 0;
                articmalltr3 = 0;
                articmalltr4 = 1;
                pb1x20.Visible = false;
                pb2x20.Visible = true;
            }

            if (heavenlymalltr1 == 1 && heavenlymalltrd1 == 1)
            {
                heavenlymalltrd1 = 0;
                heavenlymalltr1d = 0;
                heavenlymalltr2d = 0;
                heavenlymalltr3d = 0;
                heavenlymalltr4d = 1;
                heavenlymalltr1 = 0;
                heavenlymalltr2 = 0;
                heavenlymalltr3 = 0;
                heavenlymalltr4 = 1;
                pb1x21.Visible = false;
                pb2x21.Visible = true;
            }
            if (shangrillamalltr1 == 1 && shangrillamalltrd1 == 1)
            {
                shangrillamalltrd1 = 0;
                shangrillamalltr1d = 0;
                shangrillamalltr2d = 0;
                shangrillamalltr3d = 0;
                shangrillamalltr4d = 1;
                shangrillamalltr1 = 0;
                shangrillamalltr2 = 0;
                shangrillamalltr3 = 0;
                shangrillamalltr4 = 1;
                pb1x22.Visible = false;
                pb2x22.Visible = true;
            }

            if (utility1x1tr1 == 1 && utility1x1trd1 == 1)
            {
                utility1x1trd1 = 0;
                utility1x1tr1d = 0;
                utility2x1tr2d = 0;
                utility3x1tr3d = 0;
                utility4x1tr4d = 1;
                utility1x1tr1 = 0;
                utility2x1tr2 = 0;
                utility3x1tr3 = 0;
                utility4x1tr4 = 1;
                pb1x23.Visible = false;
                pb2x23.Visible = true;
            }
            if (utility1x2tr1 == 1 && utility1x2trd1 == 1)
            {
                utility1x2trd1 = 0;
                utility1x2tr1d = 0;
                utility2x2tr2d = 0;
                utility3x2tr3d = 0;
                utility4x2tr4d = 1;
                utility1x2tr1 = 0;
                utility2x2tr2 = 0;
                utility3x2tr3 = 0;
                utility4x2tr4 = 1;
                pb1x24.Visible = false;
                pb2x24.Visible = true;
            }

            if (transportation1x1tr1 == 1 && transportation1x1trd1 == 1)
            {
                transportation1x1trd1 = 0;
                transportation1x1tr1d = 0;
                transportation2x1tr2d = 0;
                transportation3x1tr3d = 0;
                transportation4x1tr4d = 1;
                transportation1x1tr1 = 0;
                transportation2x1tr2 = 0;
                transportation3x1tr3 = 0;
                transportation4x1tr4 = 1;
                pb1x25.Visible = false;
                pb2x25.Visible = true;
            }
            if (transportation1x2tr1 == 1 && transportation1x2trd1 == 1)
            {
                transportation1x2trd1 = 0;
                transportation1x2tr1d = 0;
                transportation2x2tr2d = 0;
                transportation3x2tr3d = 0;
                transportation4x2tr4d = 1;
                transportation1x2tr1 = 0;
                transportation2x2tr2 = 0;
                transportation3x2tr3 = 0;
                transportation4x2tr4 = 1;
                pb1x26.Visible = false;
                pb2x26.Visible = true;
            }
            if (transportation1x3tr1 == 1 && transportation1x3trd1 == 1)
            {
                transportation1x3trd1 = 0;
                transportation1x3tr1d = 0;
                transportation2x3tr2d = 0;
                transportation3x3tr3d = 0;
                transportation4x3tr4d = 1;
                transportation1x3tr1 = 0;
                transportation2x3tr2 = 0;
                transportation3x3tr3 = 0;
                transportation4x3tr4 = 1;
                pb1x27.Visible = false;
                pb2x27.Visible = true;
            }
            if (transportation1x4tr1 == 1 && transportation1x4trd1 == 1)
            {
                transportation1x4trd1 = 0;
                transportation1x4tr1d = 0;
                transportation2x4tr2d = 0;
                transportation3x4tr3d = 0;
                transportation4x4tr4d = 1;
                transportation1x4tr1 = 0;
                transportation2x4tr2 = 0;
                transportation3x4tr3 = 0;
                transportation4x4tr4 = 1;
                pb1x28.Visible = false;
                pb2x28.Visible = true;
            }
        }
        void p2trtraded2()
        {
            //p2 to p1
            if (easternschooltr2 == 1 && easternschooltrd1 == 1)
            {
                easternschooltrd1 = 0;
                easternschooltr1d = 1;
                easternschooltr2d = 0;
                easternschooltr3d = 0;
                easternschooltr4d = 0;
                easternschooltr1 = 1;
                easternschooltr2 = 0;
                easternschooltr3 = 0;
                easternschooltr4 = 0;
                pb2x1.Visible = true;
                pb1x1.Visible = false;


            }

            if (westernschooltr2 == 1 && westernschooltrd1 == 1)
            {
                westernschooltrd1 = 0;
                westernschooltr1d = 1;
                westernschooltr2d = 0;
                westernschooltr3d = 0;
                westernschooltr4d = 0;
                westernschooltr1d = 1;
                westernschooltr2d = 0;
                westernschooltr3d = 0;
                westernschooltr4d = 0;
                westernschooltr1 = 1;
                westernschooltr2 = 0;
                westernschooltr3 = 0;
                westernschooltr4 = 0;
                pb1x2.Visible = false;
                pb2x2.Visible = true;

            }

            if (visayashighschooltr2 == 1 && visayashighschooltrd1 == 1)
            {
                visayashighschooltrd1 = 0;
                visayashighschooltr1d = 1;
                visayashighschooltr2d = 0;
                visayashighschooltr3d = 0;
                visayashighschooltr4d = 0;
                visayashighschooltr1 = 1;
                visayashighschooltr2 = 0;
                visayashighschooltr3 = 0;
                visayashighschooltr4 = 0;
                pb1x3.Visible = false;
                pb2x3.Visible = true;
            }
            if (southernschooltr2 == 1 && southernschooltrd1 == 1)
            {
                southernschooltrd1 = 0;
                southernschooltr1d = 1;
                southernschooltr2d = 0;
                southernschooltr3d = 0;
                southernschooltr4d = 0;
                southernschooltr1 = 1;
                southernschooltr2 = 0;
                southernschooltr3 = 0;
                southernschooltr4 = 0;
                pb1x4.Visible = false;
                pb2x4.Visible = true;
            }
            if (nationsschooltr2 == 1 && nationsschooltrd1 == 1)
            {
                nationsschooltrd1 = 0;
                nationsschooltr1d = 1;
                nationsschooltr2d = 0;
                nationsschooltr3d = 0;
                nationsschooltr4d = 0;
                nationsschooltr1 = 1;
                nationsschooltr2 = 0;
                nationsschooltr3 = 0;
                nationsschooltr4 = 0;
                pb1x5.Visible = false;
                pb2x5.Visible = true;
            }

            if (westmarkettr2 == 1 && westernschooltrd1 == 1)
            {
                westmarkettrd1 = 0;
                westmarkettr1d = 1;
                westmarkettr2d = 0;
                westmarkettr3d = 0;
                westmarkettr4d = 0;
                westmarkettr1 = 1;
                westmarkettr2 = 0;
                westmarkettr3 = 0;
                westmarkettr4 = 0;
                pb1x6.Visible = false;
                pb2x6.Visible = true;

            }
            if (nightmarkettr2 == 1 && nightmarkettrd1 == 1)
            {
                nightmarkettrd1 = 0;
                nightmarkettr1d = 1;
                nightmarkettr2d = 0;
                nightmarkettr3d = 0;
                nightmarkettr4d = 0;
                nightmarkettr1 = 1;
                nightmarkettr2 = 0;
                nightmarkettr3 = 0;
                nightmarkettr4 = 0;
                pb1x7.Visible = false;
                pb2x7.Visible = true;
            }
            if (daymarkettr2 == 1 && daymarkettrd1 == 1)
            {
                daymarkettrd1 = 0;
                daymarkettr1d = 1;
                daymarkettr2d = 0;
                daymarkettr3d = 0;
                daymarkettr4d = 0;
                daymarkettr1 = 1;
                daymarkettr2 = 0;
                daymarkettr3 = 0;
                daymarkettr4 = 0;
                pb1x8.Visible = false;
                pb2x8.Visible = true;
            }

            if (starmarkettr2 == 1 && starmarkettrd1 == 1)
            {
                starmarkettrd1 = 0;
                starmarkettr1d = 1;
                starmarkettr2d = 0;
                starmarkettr3d = 0;
                starmarkettr4d = 0;
                starmarkettr1 = 1;
                starmarkettr2 = 0;
                starmarkettr3 = 0;
                starmarkettr4 = 0;
                pb1x9.Visible = false;
                pb2x9.Visible = true;
            }
            if (moonmarkettr2 == 1 && moonmarkettrd1 == 1)
            {
                moonmarkettrd1 = 0;
                moonmarkettr1d = 1;
                moonmarkettr2d = 0;
                moonmarkettr3d = 0;
                moonmarkettr4d = 0;
                moonmarkettr1 = 1;
                moonmarkettr2 = 0;
                moonmarkettr3 = 0;
                moonmarkettr4 = 0;
                pb1x10.Visible = false;
                pb2x10.Visible = true;
            }
            if (megamarkettr2 == 1 && megamarkettrd1 == 1)
            {
                megamarkettrd1 = 0;
                megamarkettr1d = 1;
                megamarkettr2d = 0;
                megamarkettr3d = 0;
                megamarkettr4d = 0;
                megamarkettr1 = 1;
                megamarkettr2 = 0;
                megamarkettr3 = 0;
                megamarkettr4 = 0;
                pb1x11.Visible = false;
                pb2x11.Visible = true;
            }

            if (visayashospitaltr2 == 1 && visayashospitaltrd1 == 1)
            {
                visayashospitaltrd1 = 0;
                visayashospitaltr1d = 1;
                visayashospitaltr2d = 0;
                visayashospitaltr3d = 0;
                visayashospitaltr4d = 0;
                visayashospitaltr1 = 1;
                visayashospitaltr2 = 0;
                visayashospitaltr3 = 0;
                visayashospitaltr4 = 0;
                pb1x12.Visible = false;
                pb2x12.Visible = true;
            }
            if (hobertshospitaltr2 == 1 && hobertshospitaltrd1 == 1)
            {
                hobertshospitaltrd1 = 0;
                hobertshospitaltr1d = 1;
                hobertshospitaltr2d = 0;
                hobertshospitaltr3d = 0;
                hobertshospitaltr4d = 0;
                hobertshospitaltr1 = 1;
                hobertshospitaltr2 = 0;
                hobertshospitaltr3 = 0;
                hobertshospitaltr4 = 0;
                pb1x13.Visible = false;
                pb2x13.Visible = true;
            }
            if (heartshospitaltr2 == 1 && heartshospitaltrd1 == 1)
            {
                heartshospitaltrd1 = 0;
                heartshospitaltr1d = 1;
                heartshospitaltr2d = 0;
                heartshospitaltr3d = 0;
                heartshospitaltr4d = 0;
                heartshospitaltr1 = 1;
                heartshospitaltr2 = 0;
                heartshospitaltr3 = 0;
                heartshospitaltr4 = 0;
                pb1x14.Visible = false;
                pb2x14.Visible = true;

            }

            if (internshospitaltr2 == 1 && internshospitaltrd1 == 1)
            {
                internshospitaltrd1 = 0;
                internshospitaltr1d = 1;
                internshospitaltr2d = 0;
                internshospitaltr3d = 0;
                internshospitaltr4d = 0;
                internshospitaltr1 = 1;
                internshospitaltr2 = 0;
                internshospitaltr3 = 0;
                internshospitaltr4 = 0;
                pb1x15.Visible = false;
                pb2x15.Visible = true;



            }
            if (nationalhealthhospitaltr2 == 1 && nationalhealthhospitaltrd1 == 1)
            {
                nationalhealthhospitaltrd1 = 0;
                nationalhealthhospitaltr1d = 1;
                nationalhealthhospitaltr2d = 0;
                nationalhealthhospitaltr3d = 0;
                nationalhealthhospitaltr4d = 0;
                nationalhealthhospitaltr1 = 1;
                nationalhealthhospitaltr2 = 0;
                nationalhealthhospitaltr3 = 0;
                nationalhealthhospitaltr4 = 0;
                pb1x16.Visible = false;
                pb2x16.Visible = true;
            }
            if (veteranshospitaltr2 == 1 && veteranshospitaltrd1 == 1)
            {
                veteranshospitaltrd1 = 0;
                veteranshospitaltr1d = 1;
                veteranshospitaltr2d = 0;
                veteranshospitaltr3d = 0;
                veteranshospitaltr4d = 0;
                veteranshospitaltr1 = 1;
                veteranshospitaltr2 = 0;
                veteranshospitaltr3 = 0;
                veteranshospitaltr4 = 0;
                pb1x17.Visible = false;
                pb2x17.Visible = true;
            }

            if (pearlmalltr2 == 1 && pearlmalltrd1 == 1)
            {
                pearlmalltrd1 = 0;
                pearlmalltr1d = 1;
                pearlmalltr2d = 0;
                pearlmalltr3d = 0;
                pearlmalltr4d = 0;
                pearlmalltr1 = 1;
                pearlmalltr2 = 0;
                pearlmalltr3 = 0;
                pearlmalltr4 = 0;
                pb1x18.Visible = false;
                pb2x18.Visible = true;
            }
            if (megamalltr2 == 1 && megamalltrd1 == 1)
            {
                megamalltrd1 = 0;
                megamalltr1d = 1;
                megamalltr2d = 0;
                megamalltr3d = 0;
                megamalltr4d = 0;
                megamalltr1 = 1;
                megamalltr2 = 0;
                megamalltr3 = 0;
                megamalltr4 = 0;
                pb1x19.Visible = false;
                pb2x19.Visible = true;
            }
            if (articmalltr2 == 1 && articmalltrd1 == 1)
            {
                articmalltrd1 = 0;
                articmalltr1d = 1;
                articmalltr2d = 0;
                articmalltr3d = 0;
                articmalltr4d = 0;
                articmalltr1 = 1;
                articmalltr2 = 0;
                articmalltr3 = 0;
                articmalltr4 = 0;
                pb1x20.Visible = false;
                pb2x20.Visible = true;
            }

            if (heavenlymalltr2 == 1 && heavenlymalltrd1 == 1)
            {
                heavenlymalltrd1 = 0;
                heavenlymalltr1d = 1;
                heavenlymalltr2d = 0;
                heavenlymalltr3d = 0;
                heavenlymalltr4d = 0;
                heavenlymalltr1 = 1;
                heavenlymalltr2 = 0;
                heavenlymalltr3 = 0;
                heavenlymalltr4 = 0;
                pb1x21.Visible = false;
                pb2x21.Visible = true;
            }
            if (shangrillamalltr2 == 1 && shangrillamalltrd1 == 1)
            {
                shangrillamalltrd1 = 0;
                shangrillamalltr1d = 1;
                shangrillamalltr2d = 0;
                shangrillamalltr3d = 0;
                shangrillamalltr4d = 0;
                shangrillamalltr1 = 1;
                shangrillamalltr2 = 0;
                shangrillamalltr3 = 0;
                shangrillamalltr4 = 0;
                pb1x22.Visible = false;
                pb2x22.Visible = true;
            }

            if (utility2x1tr2 == 1 && utility1x1trd1 == 1)
            {
                utility1x1trd1 = 0;
                utility1x1tr1d = 1;
                utility2x1tr2d = 0;
                utility3x1tr3d = 0;
                utility4x1tr4d = 0;
                utility1x1tr1 = 1;
                utility2x1tr2 = 0;
                utility3x1tr3 = 0;
                utility4x1tr4 = 0;
                pb1x23.Visible = false;
                pb2x23.Visible = true;
            }
            if (utility2x2tr2 == 1 && utility1x2trd1 == 1)
            {
                utility1x2trd1 = 0;
                utility1x2tr1d = 1;
                utility2x2tr2d = 0;
                utility3x2tr3d = 0;
                utility4x2tr4d = 0;
                utility1x2tr1 = 1;
                utility2x2tr2 = 0;
                utility3x2tr3 = 0;
                utility4x2tr4 = 0;
                pb1x24.Visible = false;
                pb2x24.Visible = true;
            }

            if (transportation2x1tr2 == 1 && transportation1x1trd1 == 1)
            {
                transportation1x1trd1 = 0;
                transportation1x1tr1d = 1;
                transportation2x1tr2d = 0;
                transportation3x1tr3d = 0;
                transportation4x1tr4d = 0;
                transportation1x1tr1 = 1;
                transportation2x1tr2 = 0;
                transportation3x1tr3 = 0;
                transportation4x1tr4 = 0;
                pb1x25.Visible = false;
                pb2x25.Visible = true;
            }
            if (transportation2x2tr2 == 1 && transportation1x2trd1 == 1)
            {
                transportation1x2trd1 = 0;
                transportation1x2tr1d = 1;
                transportation2x2tr2d = 0;
                transportation3x2tr3d = 0;
                transportation4x2tr4d = 0;
                transportation1x2tr1 = 1;
                transportation2x2tr2 = 0;
                transportation3x2tr3 = 0;
                transportation4x2tr4 = 0;
                pb1x26.Visible = false;
                pb2x26.Visible = true;
            }
            if (transportation2x3tr2 == 1 && transportation1x3trd1 == 1)
            {
                transportation1x3trd1 = 0;
                transportation1x3tr1d = 1;
                transportation2x3tr2d = 0;
                transportation3x3tr3d = 0;
                transportation4x3tr4d = 0;
                transportation1x3tr1 = 1;
                transportation2x3tr2 = 0;
                transportation3x3tr3 = 0;
                transportation4x3tr4 = 0;
                pb1x27.Visible = false;
                pb2x27.Visible = true;
            }
            if (transportation2x4tr2 == 1 && transportation1x4trd1 == 1)
            {
                transportation1x4trd1 = 0;
                transportation1x4tr1d = 1;
                transportation2x4tr2d = 0;
                transportation3x4tr3d = 0;
                transportation4x4tr4d = 0;
                transportation1x4tr1 = 1;
                transportation2x4tr2 = 0;
                transportation3x4tr3 = 0;
                transportation4x4tr4 = 0;
                pb1x28.Visible = false;
                pb2x28.Visible = true;
            }

        }
        void p2trtraded2_3()
        {
            //p2 to p3
            if (easternschooltr2 == 1 && easternschooltrd1 == 1)
            {
                easternschooltrd1 = 0;
                easternschooltr1d = 0;
                easternschooltr2d = 0;
                easternschooltr3d = 1;
                easternschooltr4d = 0;
                easternschooltr1 = 0;
                easternschooltr2 = 0;
                easternschooltr3 = 1;
                easternschooltr4 = 0;
                pb1x1.Visible = false;
                pb2x1.Visible = true;


            }
            if (westernschooltr2 == 1 && westernschooltrd1 == 1)
            {
                westernschooltrd1 = 0;
                westernschooltr1d = 0;
                westernschooltr2d = 0;
                westernschooltr3d = 1;
                westernschooltr4d = 0;
                westernschooltr1 = 0;
                westernschooltr2 = 0;
                westernschooltr3 = 1;
                westernschooltr4 = 0;
                pb1x2.Visible = false;
                pb2x2.Visible = true;

            }

            if (visayashighschooltr2 == 1 && visayashighschooltrd1 == 1)
            {
                visayashighschooltrd1 = 0;
                visayashighschooltr1d = 0;
                visayashighschooltr2d = 0;
                visayashighschooltr3d = 1;
                visayashighschooltr4d = 0;
                visayashighschooltr1 = 0;
                visayashighschooltr2 = 0;
                visayashighschooltr3 = 1;
                visayashighschooltr4 = 0;
                pb1x3.Visible = false;
                pb2x3.Visible = true;
            }
            if (southernschooltr2 == 1 && southernschooltrd1 == 1)
            {
                southernschooltrd1 = 0;
                southernschooltr1d = 0;
                southernschooltr2d = 0;
                southernschooltr3d = 1;
                southernschooltr4d = 0;
                southernschooltr1 = 0;
                southernschooltr2 = 0;
                southernschooltr3 = 1;
                southernschooltr4 = 0;
                pb1x4.Visible = false;
                pb2x4.Visible = true;
            }
            if (nationsschooltr2 == 1 && nationsschooltrd1 == 1)
            {
                nationsschooltrd1 = 0;
                nationsschooltr1d = 0;
                nationsschooltr2d = 0;
                nationsschooltr3d = 1;
                nationsschooltr4d = 0;
                nationsschooltr1 = 0;
                nationsschooltr2 = 0;
                nationsschooltr3 = 1;
                nationsschooltr4 = 0;
                pb1x5.Visible = false;
                pb2x5.Visible = true;
            }

            if (westmarkettr2 == 1 && westernschooltrd1 == 1)
            {
                westmarkettrd1 = 0;
                westmarkettr1d = 0;
                westmarkettr2d = 0;
                westmarkettr3d = 1;
                westmarkettr4d = 0;
                westmarkettr1 = 0;
                westmarkettr2 = 0;
                westmarkettr3 = 1;
                westmarkettr4 = 0;
                pb1x6.Visible = false;
                pb2x6.Visible = true;

            }
            if (nightmarkettr2 == 1 && nightmarkettrd1 == 1)
            {
                nightmarkettrd1 = 0;
                nightmarkettr1d = 0;
                nightmarkettr2d = 0;
                nightmarkettr3d = 1;
                nightmarkettr4d = 0;
                nightmarkettr1 = 0;
                nightmarkettr2 = 0;
                nightmarkettr3 = 1;
                nightmarkettr4 = 0;
                pb1x7.Visible = false;
                pb2x7.Visible = true;
            }
            if (daymarkettr2 == 1 && daymarkettrd1 == 1)
            {
                daymarkettrd1 = 0;
                daymarkettr1d = 0;
                daymarkettr2d = 0;
                daymarkettr3d = 1;
                daymarkettr4d = 0;
                daymarkettr1 = 0;
                daymarkettr2 = 0;
                daymarkettr3 = 1;
                daymarkettr4 = 0;
                pb1x8.Visible = false;
                pb2x8.Visible = true;
            }

            if (starmarkettr2 == 1 && starmarkettrd1 == 1)
            {
                starmarkettrd1 = 0;
                starmarkettr1d = 0;
                starmarkettr2d = 0;
                starmarkettr3d = 1;
                starmarkettr4d = 0;
                starmarkettr1 = 0;
                starmarkettr2 = 0;
                starmarkettr3 = 1;
                starmarkettr4 = 0;
                pb1x9.Visible = false;
                pb2x9.Visible = true;
            }
            if (moonmarkettr2 == 1 && moonmarkettrd1 == 1)
            {
                moonmarkettrd1 = 0;
                moonmarkettr1d = 0;
                moonmarkettr2d = 0;
                moonmarkettr3d = 1;
                moonmarkettr4d = 0;
                moonmarkettr1 = 0;
                moonmarkettr2 = 0;
                moonmarkettr3 = 1;
                moonmarkettr4 = 0;
                pb1x10.Visible = false;
                pb2x10.Visible = true;
            }
            if (megamarkettr2 == 1 && megamarkettrd1 == 1)
            {
                megamarkettrd1 = 0;
                megamarkettr1d = 0;
                megamarkettr2d = 0;
                megamarkettr3d = 1;
                megamarkettr4d = 0;
                megamarkettr1 = 0;
                megamarkettr2 = 0;
                megamarkettr3 = 1;
                megamarkettr4 = 0;
                pb1x11.Visible = false;
                pb2x11.Visible = true;
            }

            if (visayashospitaltr2 == 1 && visayashospitaltrd1 == 1)
            {
                visayashospitaltrd1 = 0;
                visayashospitaltr1d = 0;
                visayashospitaltr2d = 0;
                visayashospitaltr3d = 1;
                visayashospitaltr4d = 0;
                visayashospitaltr1 = 0;
                visayashospitaltr2 = 0;
                visayashospitaltr3 = 1;
                visayashospitaltr4 = 0;
                pb1x12.Visible = false;
                pb2x12.Visible = true;
            }
            if (hobertshospitaltr2 == 1 && hobertshospitaltrd1 == 1)
            {
                hobertshospitaltrd1 = 0;
                hobertshospitaltr1d = 0;
                hobertshospitaltr2d = 0;
                hobertshospitaltr3d = 1;
                hobertshospitaltr4d = 0;
                hobertshospitaltr1 = 0;
                hobertshospitaltr2 = 0;
                hobertshospitaltr3 = 1;
                hobertshospitaltr4 = 0;
                pb1x13.Visible = false;
                pb2x13.Visible = true;
            }
            if (heartshospitaltr2 == 1 && heartshospitaltrd1 == 1)
            {
                heartshospitaltrd1 = 0;
                heartshospitaltr1d = 0;
                heartshospitaltr2d = 0;
                heartshospitaltr3d = 1;
                heartshospitaltr4d = 0;
                heartshospitaltr1 = 0;
                heartshospitaltr2 = 0;
                heartshospitaltr3 = 1;
                heartshospitaltr4 = 0;
                pb1x14.Visible = false;
                pb2x14.Visible = true;

            }

            if (internshospitaltr2 == 1 && internshospitaltrd1 == 1)
            {
                internshospitaltrd1 = 0;
                internshospitaltr1d = 0;
                internshospitaltr2d = 0;
                internshospitaltr3d = 1;
                internshospitaltr4d = 0;
                internshospitaltr1 = 0;
                internshospitaltr2 = 0;
                internshospitaltr3 = 1;
                internshospitaltr4 = 0;
                pb1x15.Visible = false;
                pb2x15.Visible = true;
            }
            if (nationalhealthhospitaltr2 == 1 && nationalhealthhospitaltrd1 == 1)
            {
                nationalhealthhospitaltrd1 = 0;
                nationalhealthhospitaltr1d = 0;
                nationalhealthhospitaltr2d = 0;
                nationalhealthhospitaltr3d = 1;
                nationalhealthhospitaltr4d = 0;
                nationalhealthhospitaltr1 = 0;
                nationalhealthhospitaltr2 = 0;
                nationalhealthhospitaltr3 = 1;
                nationalhealthhospitaltr4 = 0;
                pb1x16.Visible = false;
                pb2x16.Visible = true;
            }
            if (veteranshospitaltr2 == 1 && veteranshospitaltrd1 == 1)
            {
                veteranshospitaltrd1 = 0;
                veteranshospitaltr1d = 0;
                veteranshospitaltr2d = 0;
                veteranshospitaltr3d = 1;
                veteranshospitaltr4d = 0;
                veteranshospitaltr1 = 0;
                veteranshospitaltr2 = 0;
                veteranshospitaltr3 = 1;
                veteranshospitaltr4 = 0;
                pb1x17.Visible = false;
                pb2x17.Visible = true;
            }

            if (pearlmalltr2 == 1 && pearlmalltrd1 == 1)
            {
                pearlmalltrd1 = 0;
                pearlmalltr1d = 0;
                pearlmalltr2d = 0;
                pearlmalltr3d = 1;
                pearlmalltr4d = 0;
                pearlmalltr1 = 0;
                pearlmalltr2 = 0;
                pearlmalltr3 = 1;
                pearlmalltr4 = 0;
                pb1x18.Visible = false;
                pb2x18.Visible = true;
            }
            if (megamalltr2 == 1 && megamalltrd1 == 1)
            {
                megamalltrd1 = 0;
                megamalltr1d = 0;
                megamalltr2d = 0;
                megamalltr3d = 1;
                megamalltr4d = 0;
                megamalltr1 = 0;
                megamalltr2 = 0;
                megamalltr3 = 1;
                megamalltr4 = 0;
                pb1x19.Visible = false;
                pb2x19.Visible = true;
            }
            if (articmalltr2 == 1 && articmalltrd1 == 1)
            {
                articmalltrd1 = 0;
                articmalltr1d = 0;
                articmalltr2d = 0;
                articmalltr3d = 1;
                articmalltr4d = 0;
                articmalltr1 = 0;
                articmalltr2 = 0;
                articmalltr3 = 1;
                articmalltr4 = 0;
                pb1x20.Visible = false;
                pb2x20.Visible = true;
            }

            if (heavenlymalltr2 == 1 && heavenlymalltrd1 == 1)
            {
                heavenlymalltrd1 = 0;
                heavenlymalltr1d = 0;
                heavenlymalltr2d = 0;
                heavenlymalltr3d = 1;
                heavenlymalltr4d = 0;
                heavenlymalltr1 = 0;
                heavenlymalltr2 = 0;
                heavenlymalltr3 = 1;
                heavenlymalltr4 = 0;
                pb1x21.Visible = false;
                pb2x21.Visible = true;
            }
            if (shangrillamalltr2 == 1 && shangrillamalltrd1 == 1)
            {
                shangrillamalltrd1 = 0;
                shangrillamalltr1d = 0;
                shangrillamalltr2d = 0;
                shangrillamalltr3d = 1;
                shangrillamalltr4d = 0;
                shangrillamalltr1 = 0;
                shangrillamalltr2 = 0;
                shangrillamalltr3 = 1;
                shangrillamalltr4 = 0;
                pb1x22.Visible = false;
                pb2x22.Visible = true;
            }

            if (utility2x1tr2 == 1 && utility1x1trd1 == 1)
            {
                utility1x1trd1 = 0;
                utility1x1tr1d = 0;
                utility2x1tr2d = 0;
                utility3x1tr3d = 1;
                utility4x1tr4d = 0;
                utility1x1tr1 = 0;
                utility2x1tr2 = 0;
                utility3x1tr3 = 1;
                utility4x1tr4 = 0;
                pb1x23.Visible = false;
                pb2x23.Visible = true;
            }
            if (utility2x2tr2 == 1 && utility1x2trd1 == 1)
            {
                utility1x2trd1 = 0;
                utility1x2tr1d = 0;
                utility2x2tr2d = 0;
                utility3x2tr3d = 1;
                utility4x2tr4d = 0;
                utility1x2tr1 = 0;
                utility2x2tr2 = 0;
                utility3x2tr3 = 1;
                utility4x2tr4 = 0;
                pb1x24.Visible = false;
                pb2x24.Visible = true;
            }

            if (transportation2x1tr2 == 1 && transportation1x1trd1 == 1)
            {
                transportation1x1trd1 = 0;
                transportation1x1tr1d = 0;
                transportation2x1tr2d = 0;
                transportation3x1tr3d = 1;
                transportation4x1tr4d = 0;
                transportation1x1tr1 = 0;
                transportation2x1tr2 = 0;
                transportation3x1tr3 = 1;
                transportation4x1tr4 = 0;
                pb1x25.Visible = false;
                pb2x25.Visible = true;
            }
            if (transportation2x2tr2 == 1 && transportation1x2trd1 == 1)
            {
                transportation1x2trd1 = 0;
                transportation1x2tr1d = 0;
                transportation2x2tr2d = 0;
                transportation3x2tr3d = 1;
                transportation4x2tr4d = 0;
                transportation1x2tr1 = 0;
                transportation2x2tr2 = 0;
                transportation3x2tr3 = 1;
                transportation4x2tr4 = 0;
                pb1x26.Visible = false;
                pb2x26.Visible = true;
            }
            if (transportation2x3tr2 == 1 && transportation1x3trd1 == 1)
            {
                transportation1x3trd1 = 0;
                transportation1x3tr1d = 0;
                transportation2x3tr2d = 0;
                transportation3x3tr3d = 1;
                transportation4x3tr4d = 0;
                transportation1x3tr1 = 0;
                transportation2x3tr2 = 0;
                transportation3x3tr3 = 1;
                transportation4x3tr4 = 0;
                pb1x27.Visible = false;
                pb2x27.Visible = true;
            }
            if (transportation2x4tr2 == 1 && transportation1x4trd1 == 1)
            {
                transportation1x4trd1 = 0;
                transportation1x4tr1d = 0;
                transportation2x4tr2d = 0;
                transportation3x4tr3d = 1;
                transportation4x4tr4d = 0;
                transportation1x4tr1 = 0;
                transportation2x4tr2 = 0;
                transportation3x4tr3 = 1;
                transportation4x4tr4 = 0;
                pb1x28.Visible = false;
                pb2x28.Visible = true;
            }

        }
        void p2trtraded2_4()
        {
            //p2 to p4
            if (easternschooltr2 == 1 && easternschooltrd1 == 1)
            {
                easternschooltrd1 = 0;
                easternschooltr1d = 0;
                easternschooltr2d = 0;
                easternschooltr3d = 0;
                easternschooltr4d = 1;
                easternschooltr1 = 0;
                easternschooltr2 = 0;
                easternschooltr3 = 0;
                easternschooltr4 = 1;
                pb1x1.Visible = false;
                pb2x1.Visible = true;


            }
            if (westernschooltr2 == 1 && westernschooltrd1 == 1)
            {
                westernschooltrd1 = 0;
                westernschooltr1d = 0;
                westernschooltr2d = 0;
                westernschooltr3d = 0;
                westernschooltr4d = 1;
                westernschooltr1 = 0;
                westernschooltr2 = 0;
                westernschooltr3 = 0;
                westernschooltr4 = 1;
                pb1x2.Visible = false;
                pb2x2.Visible = true;

            }

            if (visayashighschooltr2 == 1 && visayashighschooltrd1 == 1)
            {
                visayashighschooltrd1 = 0;
                visayashighschooltr1d = 0;
                visayashighschooltr2d = 0;
                visayashighschooltr3d = 0;
                visayashighschooltr4d = 1;
                visayashighschooltr1 = 0;
                visayashighschooltr2 = 0;
                visayashighschooltr3 = 0;
                visayashighschooltr4 = 1;
                pb1x3.Visible = false;
                pb2x3.Visible = true;
            }
            if (southernschooltr2 == 1 && southernschooltrd1 == 1)
            {
                southernschooltrd1 = 0;
                southernschooltr1d = 0;
                southernschooltr2d = 0;
                southernschooltr3d = 0;
                southernschooltr4d = 1;
                southernschooltr1 = 0;
                southernschooltr2 = 0;
                southernschooltr3 = 0;
                southernschooltr4 = 1;
                pb1x4.Visible = false;
                pb2x4.Visible = true;
            }
            if (nationsschooltr2 == 1 && nationsschooltrd1 == 1)
            {
                nationsschooltrd1 = 0;
                nationsschooltr1d = 0;
                nationsschooltr2d = 0;
                nationsschooltr3d = 0;
                nationsschooltr4d = 1;
                nationsschooltr1 = 0;
                nationsschooltr2 = 0;
                nationsschooltr3 = 0;
                nationsschooltr4 = 1;
                pb1x5.Visible = false;
                pb2x5.Visible = true;
            }

            if (westmarkettr2 == 1 && westernschooltrd1 == 1)
            {
                westmarkettrd1 = 0;
                westmarkettr1d = 0;
                westmarkettr2d = 0;
                westmarkettr3d = 0;
                westmarkettr4d = 1;
                westmarkettr1 = 0;
                westmarkettr2 = 0;
                westmarkettr3 = 0;
                westmarkettr4 = 1;
                pb1x6.Visible = false;
                pb2x6.Visible = true;

            }
            if (nightmarkettr2 == 1 && nightmarkettrd1 == 1)
            {
                nightmarkettrd1 = 0;
                nightmarkettr1d = 0;
                nightmarkettr2d = 0;
                nightmarkettr3d = 0;
                nightmarkettr4d = 1;
                nightmarkettr1 = 0;
                nightmarkettr2 = 0;
                nightmarkettr3 = 0;
                nightmarkettr4 = 1;
                pb1x7.Visible = false;
                pb2x7.Visible = true;
            }
            if (daymarkettr2 == 1 && daymarkettrd1 == 1)
            {
                daymarkettrd1 = 0;
                daymarkettr1d = 0;
                daymarkettr2d = 0;
                daymarkettr3d = 0;
                daymarkettr4d = 1;
                daymarkettr1 = 0;
                daymarkettr2 = 0;
                daymarkettr3 = 0;
                daymarkettr4 = 1;
                pb1x8.Visible = false;
                pb2x8.Visible = true;
            }

            if (starmarkettr2 == 1 && starmarkettrd1 == 1)
            {
                starmarkettrd1 = 0;
                starmarkettr1d = 0;
                starmarkettr2d = 0;
                starmarkettr3d = 0;
                starmarkettr4d = 1;
                starmarkettr1 = 0;
                starmarkettr2 = 0;
                starmarkettr3 = 0;
                starmarkettr4 = 1;
                pb1x9.Visible = false;
                pb2x9.Visible = true;
            }
            if (moonmarkettr2 == 1 && moonmarkettrd1 == 1)
            {
                moonmarkettrd1 = 0;
                moonmarkettr1d = 0;
                moonmarkettr2d = 0;
                moonmarkettr3d = 0;
                moonmarkettr4d = 1;
                moonmarkettr1 = 0;
                moonmarkettr2 = 0;
                moonmarkettr3 = 0;
                moonmarkettr4 = 1;
                pb1x10.Visible = false;
                pb2x10.Visible = true;
            }
            if (megamarkettr2 == 1 && megamarkettrd1 == 1)
            {
                megamarkettrd1 = 0;
                megamarkettr1d = 0;
                megamarkettr2d = 0;
                megamarkettr3d = 0;
                megamarkettr4d = 1;
                megamarkettr1 = 0;
                megamarkettr2 = 0;
                megamarkettr3 = 0;
                megamarkettr4 = 1;
                pb1x11.Visible = false;
                pb2x11.Visible = true;
            }

            if (visayashospitaltr2 == 1 && visayashospitaltrd1 == 1)
            {
                visayashospitaltrd1 = 0;
                visayashospitaltr1d = 0;
                visayashospitaltr2d = 0;
                visayashospitaltr3d = 0;
                visayashospitaltr4d = 1;
                visayashospitaltr1 = 0;
                visayashospitaltr2 = 0;
                visayashospitaltr3 = 0;
                visayashospitaltr4 = 1;
                pb1x12.Visible = false;
                pb2x12.Visible = true;
            }
            if (hobertshospitaltr2 == 1 && hobertshospitaltrd1 == 1)
            {
                hobertshospitaltrd1 = 0;
                hobertshospitaltr1d = 0;
                hobertshospitaltr2d = 0;
                hobertshospitaltr3d = 0;
                hobertshospitaltr4d = 1;
                hobertshospitaltr1 = 0;
                hobertshospitaltr2 = 0;
                hobertshospitaltr3 = 0;
                hobertshospitaltr4 = 1;
                pb1x13.Visible = false;
                pb2x13.Visible = true;
            }
            if (heartshospitaltr2 == 1 && heartshospitaltrd1 == 1)
            {
                heartshospitaltrd1 = 0;
                heartshospitaltr1d = 0;
                heartshospitaltr2d = 0;
                heartshospitaltr3d = 0;
                heartshospitaltr4d = 1;
                heartshospitaltr1 = 0;
                heartshospitaltr2 = 0;
                heartshospitaltr3 = 0;
                heartshospitaltr4 = 1;
                pb1x14.Visible = false;
                pb2x14.Visible = true;

            }

            if (internshospitaltr2 == 1 && internshospitaltrd1 == 1)
            {
                internshospitaltrd1 = 0;
                internshospitaltr1d = 0;
                internshospitaltr2d = 0;
                internshospitaltr3d = 0;
                internshospitaltr4d = 1;
                internshospitaltr1 = 0;
                internshospitaltr2 = 0;
                internshospitaltr3 = 0;
                internshospitaltr4 = 1;
                pb1x15.Visible = false;
                pb2x15.Visible = true;

            }
            if (nationalhealthhospitaltr2 == 1 && nationalhealthhospitaltrd1 == 1)
            {
                nationalhealthhospitaltrd1 = 0;
                nationalhealthhospitaltr1d = 0;
                nationalhealthhospitaltr2d = 0;
                nationalhealthhospitaltr3d = 0;
                nationalhealthhospitaltr4d = 1;
                nationalhealthhospitaltr1 = 0;
                nationalhealthhospitaltr2 = 0;
                nationalhealthhospitaltr3 = 0;
                nationalhealthhospitaltr4 = 1;
                pb1x16.Visible = false;
                pb2x16.Visible = true;
            }
            if (veteranshospitaltr2 == 1 && veteranshospitaltrd1 == 1)
            {
                veteranshospitaltrd1 = 0;
                veteranshospitaltr1d = 0;
                veteranshospitaltr2d = 0;
                veteranshospitaltr3d = 0;
                veteranshospitaltr4d = 1;
                veteranshospitaltr1 = 0;
                veteranshospitaltr2 = 0;
                veteranshospitaltr3 = 0;
                veteranshospitaltr4 = 1;
                pb1x17.Visible = false;
                pb2x17.Visible = true;
            }

            if (pearlmalltr2 == 1 && pearlmalltr1d == 1)
            {
                pearlmalltrd1 = 0;
                pearlmalltr1d = 0;
                pearlmalltr2d = 0;
                pearlmalltr3d = 0;
                pearlmalltr4d = 1;
                pearlmalltr1 = 0;
                pearlmalltr2 = 0;
                pearlmalltr3 = 0;
                pearlmalltr4 = 1;
                pb1x18.Visible = false;
                pb2x18.Visible = true;
            }
            if (megamalltr2 == 1 && megamalltrd1 == 1)
            {
                megamalltrd1 = 0;
                megamalltr1d = 0;
                megamalltr2d = 0;
                megamalltr3d = 0;
                megamalltr4d = 1;
                megamalltr1 = 0;
                megamalltr2 = 0;
                megamalltr3 = 0;
                megamalltr4 = 1;
                pb1x19.Visible = false;
                pb2x19.Visible = true;
            }
            if (articmalltr2 == 1 && articmalltrd1 == 1)
            {
                articmalltrd1 = 0;
                articmalltr1d = 0;
                articmalltr2d = 0;
                articmalltr3d = 0;
                articmalltr4d = 1;
                articmalltr1 = 0;
                articmalltr2 = 0;
                articmalltr3 = 0;
                articmalltr4 = 1;
                pb1x20.Visible = false;
                pb2x20.Visible = true;
            }

            if (heavenlymalltr2 == 1 && heavenlymalltrd1 == 1)
            {
                heavenlymalltrd1 = 0;
                heavenlymalltr1d = 0;
                heavenlymalltr2d = 0;
                heavenlymalltr3d = 0;
                heavenlymalltr4d = 1;
                heavenlymalltr1 = 0;
                heavenlymalltr2 = 0;
                heavenlymalltr3 = 0;
                heavenlymalltr4 = 1;
                pb1x21.Visible = false;
                pb2x21.Visible = true;
            }
            if (shangrillamalltr2 == 1 && shangrillamalltrd1 == 1)
            {
                shangrillamalltrd1 = 0;
                shangrillamalltr1d = 0;
                shangrillamalltr2d = 0;
                shangrillamalltr3d = 0;
                shangrillamalltr4d = 1;
                shangrillamalltr1 = 0;
                shangrillamalltr2 = 0;
                shangrillamalltr3 = 0;
                shangrillamalltr4 = 1;
                pb1x22.Visible = false;
                pb2x22.Visible = true;
            }

            if (utility2x1tr2 == 1 && utility1x1trd1 == 1)
            {
                utility1x1trd1 = 0;
                utility1x1tr1d = 0;
                utility2x1tr2d = 0;
                utility3x1tr3d = 0;
                utility4x1tr4d = 1;
                utility1x1tr1 = 0;
                utility2x1tr2 = 0;
                utility3x1tr3 = 0;
                utility4x1tr4 = 1;
                pb1x23.Visible = false;
                pb2x23.Visible = true;
            }
            if (utility2x2tr2 == 1 && utility1x2trd1 == 1)
            {
                utility1x2trd1 = 0;
                utility1x2tr1d = 0;
                utility2x2tr2d = 0;
                utility3x2tr3d = 0;
                utility4x2tr4d = 1;
                utility1x2tr1 = 0;
                utility2x2tr2 = 0;
                utility3x2tr3 = 0;
                utility4x2tr4 = 1;
                pb1x24.Visible = false;
                pb2x24.Visible = true;
            }

            if (transportation2x1tr2 == 1 && transportation1x1trd1 == 1)
            {
                transportation1x1trd1 = 0;
                transportation1x1tr1d = 0;
                transportation2x1tr2d = 0;
                transportation3x1tr3d = 0;
                transportation4x1tr4d = 1;
                transportation1x1tr1 = 0;
                transportation2x1tr2 = 0;
                transportation3x1tr3 = 0;
                transportation4x1tr4 = 1;
                pb1x25.Visible = false;
                pb2x25.Visible = true;
            }
            if (transportation2x2tr2 == 1 && transportation1x2trd1 == 1)
            {
                transportation1x2trd1 = 0;
                transportation1x2tr1d = 0;
                transportation2x2tr2d = 0;
                transportation3x2tr3d = 0;
                transportation4x2tr4d = 1;
                transportation1x2tr1 = 0;
                transportation2x2tr2 = 0;
                transportation3x2tr3 = 0;
                transportation4x2tr4 = 1;
                pb1x26.Visible = false;
                pb2x26.Visible = true;
            }
            if (transportation2x3tr2 == 1 && transportation1x3trd1 == 1)
            {
                transportation1x3trd1 = 0;
                transportation1x3tr1d = 0;
                transportation2x3tr2d = 0;
                transportation3x3tr3d = 0;
                transportation4x3tr4d = 1;
                transportation1x3tr1 = 0;
                transportation2x3tr2 = 0;
                transportation3x3tr3 = 0;
                transportation4x3tr4 = 1;
                pb1x27.Visible = false;
                pb2x27.Visible = true;
            }
            if (transportation2x4tr2 == 1 && transportation1x4trd1 == 1)
            {
                transportation1x4trd1 = 0;
                transportation1x4tr1d = 0;
                transportation2x4tr2d = 0;
                transportation3x4tr3d = 0;
                transportation4x4tr4d = 1;
                transportation1x4tr1 = 0;
                transportation2x4tr2 = 0;
                transportation3x4tr3 = 0;
                transportation4x4tr4 = 1;
                pb1x28.Visible = false;
                pb2x28.Visible = true;
            }

        }
        void p3trtraded3()
        {
            if (easternschooltr3 == 1 && easternschooltrd1 == 1)
            {
                easternschooltrd1 = 0;
                easternschooltr1d = 1;
                easternschooltr2d = 0;
                easternschooltr3d = 0;
                easternschooltr4d = 0;
                easternschooltr1 = 1;
                easternschooltr2 = 0;
                easternschooltr3 = 0;
                easternschooltr4 = 0;
                pb1x1.Visible = false;
                pb2x1.Visible = true;


            }
            if (westernschooltr3 == 1 && westernschooltrd1 == 1)
            {
                westernschooltrd1 = 0;
                westernschooltr1d = 1;
                westernschooltr2d = 0;
                westernschooltr3d = 0;
                westernschooltr4d = 0;
                westernschooltr1 = 1;
                westernschooltr2 = 0;
                westernschooltr3 = 0;
                westernschooltr4 = 0;
                pb1x2.Visible = false;
                pb2x2.Visible = true;

            }

            if (visayashighschooltr3 == 1 && visayashighschooltrd1 == 1)
            {
                visayashighschooltrd1 = 0;
                visayashighschooltr1d = 1;
                visayashighschooltr2d = 0;
                visayashighschooltr3d = 0;
                visayashighschooltr4d = 0;
                visayashighschooltr1 = 1;
                visayashighschooltr2 = 0;
                visayashighschooltr3 = 0;
                visayashighschooltr4 = 0;
                pb1x3.Visible = false;
                pb2x3.Visible = true;
            }
            if (southernschooltr3 == 1 && southernschooltrd1 == 1)
            {
                southernschooltrd1 = 0;
                southernschooltr1d = 1;
                southernschooltr2d = 0;
                southernschooltr3d = 0;
                southernschooltr4d = 0;
                southernschooltr1 = 1;
                southernschooltr2 = 0;
                southernschooltr3 = 0;
                southernschooltr4 = 0;
                pb1x4.Visible = false;
                pb2x4.Visible = true;
            }
            if (nationsschooltr3 == 1 && nationsschooltrd1 == 1)
            {
                nationsschooltrd1 = 0;
                nationsschooltr1d = 1;
                nationsschooltr2d = 0;
                nationsschooltr3d = 0;
                nationsschooltr4d = 0;
                nationsschooltr1 = 1;
                nationsschooltr2 = 0;
                nationsschooltr3 = 0;
                nationsschooltr4 = 0;
                pb1x5.Visible = false;
                pb2x5.Visible = true;
            }

            if (westmarkettr3 == 1 && westernschooltrd1 == 1)
            {
                westmarkettrd1 = 0;
                westmarkettr1d = 1;
                westmarkettr2d = 0;
                westmarkettr3d = 0;
                westmarkettr4d = 0;
                westmarkettr1d = 1;
                westmarkettr2d = 0;
                westmarkettr3d = 0;
                westmarkettr4d = 0;
                westmarkettr1 = 1;
                westmarkettr2 = 0;
                westmarkettr3 = 0;
                westmarkettr4 = 0;
                pb1x6.Visible = false;
                pb2x6.Visible = true;

            }
            if (nightmarkettr3 == 1 && nightmarkettrd1 == 1)
            {
                nightmarkettrd1 = 0;
                nightmarkettr1d = 1;
                nightmarkettr2d = 0;
                nightmarkettr3d = 0;
                nightmarkettr4d = 0;
                nightmarkettr1 = 1;
                nightmarkettr2 = 0;
                nightmarkettr3 = 0;
                nightmarkettr4 = 0;
                pb1x7.Visible = false;
                pb2x7.Visible = true;
            }
            if (daymarkettr3 == 1 && daymarkettrd1 == 1)
            {
                daymarkettrd1 = 0;
                daymarkettr1d = 1;
                daymarkettr2d = 0;
                daymarkettr3d = 0;
                daymarkettr4d = 0;
                daymarkettr1 = 1;
                daymarkettr2 = 0;
                daymarkettr3 = 0;
                daymarkettr4 = 0;
                pb1x8.Visible = false;
                pb2x8.Visible = true;
            }

            if (starmarkettr3 == 1 && starmarkettrd1 == 1)
            {
                starmarkettrd1 = 0;
                starmarkettr1d = 1;
                starmarkettr2d = 0;
                starmarkettr3d = 0;
                starmarkettr4d = 0;
                starmarkettr1 = 1;
                starmarkettr2 = 0;
                starmarkettr3 = 0;
                starmarkettr4 = 0;
                pb1x9.Visible = false;
                pb2x9.Visible = true;
            }
            if (moonmarkettr3 == 1 && moonmarkettrd1 == 1)
            {
                moonmarkettrd1 = 0;
                moonmarkettr1d = 1;
                moonmarkettr2d = 0;
                moonmarkettr3d = 0;
                moonmarkettr4d = 0;
                moonmarkettr1 = 1;
                moonmarkettr2 = 0;
                moonmarkettr3 = 0;
                moonmarkettr4 = 0;
                pb1x10.Visible = false;
                pb2x10.Visible = true;
            }
            if (megamarkettr3 == 1 && megamarkettrd1 == 1)
            {
                megamarkettrd1 = 0;
                megamarkettr1d = 1;
                megamarkettr2d = 0;
                megamarkettr3d = 0;
                megamarkettr4d = 0;
                megamarkettr1 = 1;
                megamarkettr2 = 0;
                megamarkettr3 = 0;
                megamarkettr4 = 0;
                pb1x11.Visible = false;
                pb2x11.Visible = true;
            }

            if (visayashospitaltr3 == 1 && visayashospitaltrd1 == 1)
            {
                visayashospitaltrd1 = 0;
                visayashospitaltr1d = 1;
                visayashospitaltr2d = 0;
                visayashospitaltr3d = 0;
                visayashospitaltr4d = 0;
                visayashospitaltr1 = 1;
                visayashospitaltr2 = 0;
                visayashospitaltr3 = 0;
                visayashospitaltr4 = 0;
                pb1x12.Visible = false;
                pb2x12.Visible = true;
            }
            if (hobertshospitaltr3 == 1 && hobertshospitaltrd1 == 1)
            {
                hobertshospitaltrd1 = 0;
                hobertshospitaltr1d = 1;
                hobertshospitaltr2d = 0;
                hobertshospitaltr3d = 0;
                hobertshospitaltr4d = 0;
                hobertshospitaltr1 = 1;
                hobertshospitaltr2 = 0;
                hobertshospitaltr3 = 0;
                hobertshospitaltr4 = 0;
                pb1x13.Visible = false;
                pb2x13.Visible = true;
            }
            if (heartshospitaltr3 == 1 && heartshospitaltrd1 == 1)
            {
                heartshospitaltrd1 = 0;
                heartshospitaltr1d = 1;
                heartshospitaltr2d = 0;
                heartshospitaltr3d = 0;
                heartshospitaltr4d = 0;
                heartshospitaltr1 = 1;
                heartshospitaltr2 = 0;
                heartshospitaltr3 = 0;
                heartshospitaltr4 = 0;
                pb1x14.Visible = false;
                pb2x14.Visible = true;

            }

            if (internshospitaltr3 == 1 && internshospitaltrd1 == 1)
            {
                internshospitaltrd1 = 0;
                internshospitaltr1d = 1;
                internshospitaltr2d = 0;
                internshospitaltr3d = 0;
                internshospitaltr4d = 0;
                internshospitaltr1 = 1;
                internshospitaltr2 = 0;
                internshospitaltr3 = 0;
                internshospitaltr4 = 0;
                pb1x15.Visible = false;
                pb2x15.Visible = true;



            }
            if (nationalhealthhospitaltr3 == 1 && nationalhealthhospitaltrd1 == 1)
            {
                nationalhealthhospitaltrd1 = 0;
                nationalhealthhospitaltr1d = 1;
                nationalhealthhospitaltr2d = 0;
                nationalhealthhospitaltr3d = 0;
                nationalhealthhospitaltr4d = 0;
                nationalhealthhospitaltr1 = 1;
                nationalhealthhospitaltr2 = 0;
                nationalhealthhospitaltr3 = 0;
                nationalhealthhospitaltr4 = 0;
                pb1x16.Visible = false;
                pb2x16.Visible = true;
            }
            if (veteranshospitaltr3 == 1 && veteranshospitaltrd1 == 1)
            {
                veteranshospitaltrd1 = 0;
                veteranshospitaltr1d = 1;
                veteranshospitaltr2d = 0;
                veteranshospitaltr3d = 0;
                veteranshospitaltr4d = 0;
                veteranshospitaltr1 = 1;
                veteranshospitaltr2 = 0;
                veteranshospitaltr3 = 0;
                veteranshospitaltr4 = 0;
                pb1x17.Visible = false;
                pb2x17.Visible = true;
            }

            if (pearlmalltr3 == 1 && pearlmalltr1d == 1)
            {
                pearlmalltrd1 = 0;
                pearlmalltr1d = 1;
                pearlmalltr2d = 0;
                pearlmalltr3d = 0;
                pearlmalltr4d = 0;
                pearlmalltr1 = 1;
                pearlmalltr2 = 0;
                pearlmalltr3 = 0;
                pearlmalltr4 = 0;
                pb1x18.Visible = false;
                pb2x18.Visible = true;
            }
            if (megamalltr3 == 1 && megamalltrd1 == 1)
            {
                megamalltrd1 = 0;
                megamalltr1d = 1;
                megamalltr2d = 0;
                megamalltr3d = 0;
                megamalltr4d = 0;
                megamalltr1 = 1;
                megamalltr2 = 0;
                megamalltr3 = 0;
                megamalltr4 = 0;
                pb1x19.Visible = false;
                pb2x19.Visible = true;
            }
            if (articmalltr3 == 1 && articmalltrd1 == 1)
            {
                articmalltrd1 = 0;
                articmalltr1d = 1;
                articmalltr2d = 0;
                articmalltr3d = 0;
                articmalltr4d = 0;
                articmalltr1 = 1;
                articmalltr2 = 0;
                articmalltr3 = 0;
                articmalltr4 = 0;
                pb1x20.Visible = false;
                pb2x20.Visible = true;
            }

            if (heavenlymalltr3 == 1 && heavenlymalltrd1 == 1)
            {
                heavenlymalltrd1 = 0;
                heavenlymalltr1d = 1;
                heavenlymalltr2d = 0;
                heavenlymalltr3d = 0;
                heavenlymalltr4d = 0;
                heavenlymalltr1 = 1;
                heavenlymalltr2 = 0;
                heavenlymalltr3 = 0;
                heavenlymalltr4 = 0;
                pb1x21.Visible = false;
                pb2x21.Visible = true;
            }
            if (shangrillamalltr3 == 1 && shangrillamalltrd1 == 1)
            {
                shangrillamalltrd1 = 0;
                shangrillamalltr1d = 1;
                shangrillamalltr2d = 0;
                shangrillamalltr3d = 0;
                shangrillamalltr4d = 0;
                shangrillamalltr1 = 1;
                shangrillamalltr2 = 0;
                shangrillamalltr3 = 0;
                shangrillamalltr4 = 0;
                pb1x22.Visible = false;
                pb2x22.Visible = true;
            }

            if (utility3x1tr3 == 1 && utility1x1trd1 == 1)
            {
                utility1x1trd1 = 0;
                utility1x1tr1d = 1;
                utility2x1tr2d = 0;
                utility3x1tr3d = 0;
                utility4x1tr4d = 0;
                utility1x1tr1 = 1;
                utility2x1tr2 = 0;
                utility3x1tr3 = 0;
                utility4x1tr4 = 0;
                pb1x23.Visible = false;
                pb2x23.Visible = true;
            }
            if (utility3x2tr3 == 1 && utility1x2trd1 == 1)
            {
                utility1x2trd1 = 0;
                utility1x2tr1d = 1;
                utility2x2tr2d = 0;
                utility3x2tr3d = 0;
                utility4x2tr4d = 0;
                utility1x2tr1 = 1;
                utility2x2tr2 = 0;
                utility3x2tr3 = 0;
                utility4x2tr4 = 0;
                pb1x24.Visible = false;
                pb2x24.Visible = true;
            }

            if (transportation3x1tr3 == 1 && transportation1x1trd1 == 1)
            {
                transportation1x1trd1 = 0;
                transportation1x1tr1d = 1;
                transportation2x1tr2d = 0;
                transportation3x1tr3d = 0;
                transportation4x1tr4d = 0;
                transportation1x1tr1 = 1;
                transportation2x1tr2 = 0;
                transportation3x1tr3 = 0;
                transportation4x1tr4 = 0;
                pb1x25.Visible = false;
                pb2x25.Visible = true;
            }
            if (transportation3x2tr3 == 1 && transportation1x2trd1 == 1)
            {
                transportation1x2trd1 = 0;
                transportation1x2tr1d = 1;
                transportation2x2tr2d = 0;
                transportation3x2tr3d = 0;
                transportation4x2tr4d = 0;
                transportation1x2tr1 = 1;
                transportation2x2tr2 = 0;
                transportation3x2tr3 = 0;
                transportation4x2tr4 = 0;
                pb1x26.Visible = false;
                pb2x26.Visible = true;
            }
            if (transportation3x3tr3 == 1 && transportation1x3trd1 == 1)
            {
                transportation1x3trd1 = 0;
                transportation1x3tr1d = 1;
                transportation2x3tr2d = 0;
                transportation3x3tr3d = 0;
                transportation4x3tr4d = 0;
                transportation1x3tr1 = 1;
                transportation2x3tr2 = 0;
                transportation3x3tr3 = 0;
                transportation4x3tr4 = 0;
                pb1x27.Visible = false;
                pb2x27.Visible = true;
            }
            if (transportation3x4tr3 == 1 && transportation1x4trd1 == 1)
            {
                transportation1x4trd1 = 0;
                transportation1x4tr1d = 1;
                transportation2x4tr2d = 0;
                transportation3x4tr3d = 0;
                transportation4x4tr4d = 0;
                transportation1x4tr1 = 1;
                transportation2x4tr2 = 0;
                transportation3x4tr3 = 0;
                transportation4x4tr4 = 0;
                pb1x28.Visible = false;
                pb2x28.Visible = true;
            }
        }
        void p3trtraded3_2()
        {
            //p3 to p2
            if (easternschooltr3 == 1 && easternschooltrd1 == 1)
            {
                easternschooltrd1 = 0;
                easternschooltr1d = 0;
                easternschooltr2d = 1;
                easternschooltr3d = 0;
                easternschooltr4d = 0;
                easternschooltr1 = 0;
                easternschooltr2 = 1;
                easternschooltr3 = 0;
                easternschooltr4 = 0;
                pb1x1.Visible = false;
                pb2x1.Visible = true;


            }
            if (westernschooltr3 == 1 && westernschooltrd1 == 1)
            {
                westernschooltrd1 = 0;
                westernschooltr1d = 0;
                westernschooltr2d = 1;
                westernschooltr3d = 0;
                westernschooltr4d = 0;
                westernschooltr1 = 0;
                westernschooltr2 = 1;
                westernschooltr3 = 0;
                westernschooltr4 = 0;
                pb1x2.Visible = false;
                pb2x2.Visible = true;

            }

            if (visayashighschooltr3 == 1 && visayashighschooltrd1 == 1)
            {
                visayashighschooltrd1 = 0;
                visayashighschooltr1d = 0;
                visayashighschooltr2d = 1;
                visayashighschooltr3d = 0;
                visayashighschooltr4d = 0;
                visayashighschooltr1 = 0;
                visayashighschooltr2 = 1;
                visayashighschooltr3 = 0;
                visayashighschooltr4 = 0;
                pb1x3.Visible = false;
                pb2x3.Visible = true;
            }
            if (southernschooltr3 == 1 && southernschooltrd1 == 1)
            {
                southernschooltrd1 = 0;
                southernschooltr1d = 0;
                southernschooltr2d = 1;
                southernschooltr3d = 0;
                southernschooltr4d = 0;
                southernschooltr1 = 0;
                southernschooltr2 = 1;
                southernschooltr3 = 0;
                southernschooltr4 = 0;
                pb1x4.Visible = false;
                pb2x4.Visible = true;
            }
            if (nationsschooltr3 == 1 && nationsschooltrd1 == 1)
            {
                nationsschooltrd1 = 0;
                nationsschooltr1d = 0;
                nationsschooltr2d = 1;
                nationsschooltr3d = 0;
                nationsschooltr4d = 0;
                nationsschooltr1 = 0;
                nationsschooltr2 = 1;
                nationsschooltr3 = 0;
                nationsschooltr4 = 0;
                pb1x5.Visible = false;
                pb2x5.Visible = true;
            }

            if (westmarkettr3 == 1 && westernschooltrd1 == 1)
            {
                westmarkettrd1 = 0;
                westmarkettr1d = 0;
                westmarkettr2d = 1;
                westmarkettr3d = 0;
                westmarkettr4d = 0;
                westmarkettr1 = 0;
                westmarkettr2 = 1;
                westmarkettr3 = 0;
                westmarkettr4 = 0;
                pb1x6.Visible = false;
                pb2x6.Visible = true;

            }
            if (nightmarkettr3 == 1 && nightmarkettrd1 == 1)
            {
                nightmarkettrd1 = 0;
                nightmarkettr1d = 0;
                nightmarkettr2d = 1;
                nightmarkettr3d = 0;
                nightmarkettr4d = 0;
                nightmarkettr1 = 0;
                nightmarkettr2 = 1;
                nightmarkettr3 = 0;
                nightmarkettr4 = 0;
                pb1x7.Visible = false;
                pb2x7.Visible = true;
            }
            if (daymarkettr3 == 1 && daymarkettrd1 == 1)
            {
                daymarkettrd1 = 0;
                daymarkettr1d = 0;
                daymarkettr2d = 1;
                daymarkettr3d = 0;
                daymarkettr4d = 0;
                daymarkettr1 = 0;
                daymarkettr2 = 1;
                daymarkettr3 = 0;
                daymarkettr4 = 0;
                pb1x8.Visible = false;
                pb2x8.Visible = true;
            }

            if (starmarkettr3 == 1 && starmarkettrd1 == 1)
            {
                starmarkettrd1 = 0;
                starmarkettr1d = 0;
                starmarkettr2d = 1;
                starmarkettr3d = 0;
                starmarkettr4d = 0;
                starmarkettr1 = 0;
                starmarkettr2 = 1;
                starmarkettr3 = 0;
                starmarkettr4 = 0;
                pb1x9.Visible = false;
                pb2x9.Visible = true;
            }
            if (moonmarkettr3 == 1 && moonmarkettrd1 == 1)
            {
                moonmarkettrd1 = 0;
                moonmarkettr1d = 0;
                moonmarkettr2d = 1;
                moonmarkettr3d = 0;
                moonmarkettr4d = 0;
                moonmarkettr1 = 0;
                moonmarkettr2 = 1;
                moonmarkettr3 = 0;
                moonmarkettr4 = 0;
                pb1x10.Visible = false;
                pb2x10.Visible = true;
            }
            if (megamarkettr3 == 1 && megamarkettrd1 == 1)
            {
                megamarkettrd1 = 0;
                megamarkettr1d = 0;
                megamarkettr2d = 1;
                megamarkettr3d = 0;
                megamarkettr4d = 0;
                megamarkettr1 = 0;
                megamarkettr2 = 1;
                megamarkettr3 = 0;
                megamarkettr4 = 0;
                pb1x11.Visible = false;
                pb2x11.Visible = true;
            }

            if (visayashospitaltr3 == 1 && visayashospitaltrd1 == 1)
            {
                visayashospitaltrd1 = 0;
                visayashospitaltr1d = 0;
                visayashospitaltr2d = 1;
                visayashospitaltr3d = 0;
                visayashospitaltr4d = 0;
                visayashospitaltr1 = 0;
                visayashospitaltr2 = 1;
                visayashospitaltr3 = 0;
                visayashospitaltr4 = 0;
                pb1x12.Visible = false;
                pb2x12.Visible = true;
            }
            if (hobertshospitaltr3 == 1 && hobertshospitaltrd1 == 1)
            {
                hobertshospitaltrd1 = 0;
                hobertshospitaltr1d = 0;
                hobertshospitaltr2d = 1;
                hobertshospitaltr3d = 0;
                hobertshospitaltr4d = 0;
                hobertshospitaltr1 = 0;
                hobertshospitaltr2 = 1;
                hobertshospitaltr3 = 0;
                hobertshospitaltr4 = 0;
                pb1x13.Visible = false;
                pb2x13.Visible = true;
            }
            if (heartshospitaltr3 == 1 && heartshospitaltrd1 == 1)
            {
                heartshospitaltrd1 = 0;
                heartshospitaltr1d = 0;
                heartshospitaltr2d = 1;
                heartshospitaltr3d = 0;
                heartshospitaltr4d = 0;
                heartshospitaltr1 = 0;
                heartshospitaltr2 = 1;
                heartshospitaltr3 = 0;
                heartshospitaltr4 = 0;
                pb1x14.Visible = false;
                pb2x14.Visible = true;

            }

            if (internshospitaltr3 == 1 && internshospitaltrd1 == 1)
            {
                internshospitaltrd1 = 0;
                internshospitaltr1d = 0;
                internshospitaltr2d = 1;
                internshospitaltr3d = 0;
                internshospitaltr4d = 0;
                internshospitaltr1 = 0;
                internshospitaltr2 = 1;
                internshospitaltr3 = 0;
                internshospitaltr4 = 0;
                pb1x15.Visible = false;
                pb2x15.Visible = true;



            }
            if (nationalhealthhospitaltr3 == 1 && nationalhealthhospitaltrd1 == 1)
            {
                nationalhealthhospitaltrd1 = 0;
                nationalhealthhospitaltr1d = 0;
                nationalhealthhospitaltr2d = 1;
                nationalhealthhospitaltr3d = 0;
                nationalhealthhospitaltr4d = 0;
                nationalhealthhospitaltr1 = 0;
                nationalhealthhospitaltr2 = 1;
                nationalhealthhospitaltr3 = 0;
                nationalhealthhospitaltr4 = 0;
                pb1x16.Visible = false;
                pb2x16.Visible = true;
            }
            if (veteranshospitaltr3 == 1 && veteranshospitaltrd1 == 1)
            {
                veteranshospitaltrd1 = 0;
                veteranshospitaltr1d = 0;
                veteranshospitaltr2d = 1;
                veteranshospitaltr3d = 0;
                veteranshospitaltr4d = 0;
                veteranshospitaltr1 = 0;
                veteranshospitaltr2 = 1;
                veteranshospitaltr3 = 0;
                veteranshospitaltr4 = 0;
                pb1x17.Visible = false;
                pb2x17.Visible = true;
            }

            if (pearlmalltr3 == 1 && pearlmalltr1d == 1)
            {
                pearlmalltrd1 = 0;
                pearlmalltr1d = 0;
                pearlmalltr2d = 1;
                pearlmalltr3d = 0;
                pearlmalltr4d = 0;
                pearlmalltr1 = 0;
                pearlmalltr2 = 1;
                pearlmalltr3 = 0;
                pearlmalltr4 = 0;
                pb1x18.Visible = false;
                pb2x18.Visible = true;
            }
            if (megamalltr3 == 1 && megamalltrd1 == 1)
            {
                megamalltrd1 = 0;
                megamalltr1d = 0;
                megamalltr2d = 1;
                megamalltr3d = 0;
                megamalltr4d = 0;
                megamalltr1 = 0;
                megamalltr2 = 1;
                megamalltr3 = 0;
                megamalltr4 = 0;
                pb1x19.Visible = false;
                pb2x19.Visible = true;
            }
            if (articmalltr3 == 1 && articmalltrd1 == 1)
            {
                articmalltrd1 = 0;
                articmalltr1d = 0;
                articmalltr2d = 1;
                articmalltr3d = 0;
                articmalltr4d = 0;
                articmalltr1 = 0;
                articmalltr2 = 1;
                articmalltr3 = 0;
                articmalltr4 = 0;
                pb1x20.Visible = false;
                pb2x20.Visible = true;
            }

            if (heavenlymalltr3 == 1 && heavenlymalltrd1 == 1)
            {
                heavenlymalltrd1 = 0;
                heavenlymalltr1d = 0;
                heavenlymalltr2d = 1;
                heavenlymalltr3d = 0;
                heavenlymalltr4d = 0;
                heavenlymalltr1 = 0;
                heavenlymalltr2 = 1;
                heavenlymalltr3 = 0;
                heavenlymalltr4 = 0;
                pb1x21.Visible = false;
                pb2x21.Visible = true;
            }
            if (shangrillamalltr3 == 1 && shangrillamalltrd1 == 1)
            {
                shangrillamalltrd1 = 0;
                shangrillamalltr1d = 0;
                shangrillamalltr2d = 1;
                shangrillamalltr3d = 0;
                shangrillamalltr4d = 0;
                shangrillamalltr1 = 0;
                shangrillamalltr2 = 1;
                shangrillamalltr3 = 0;
                shangrillamalltr4 = 0;
                pb1x22.Visible = false;
                pb2x22.Visible = true;
            }

            if (utility3x1tr3 == 1 && utility1x1trd1 == 1)
            {
                utility1x1trd1 = 0;
                utility1x1tr1d = 0;
                utility2x1tr2d = 1;
                utility3x1tr3d = 0;
                utility4x1tr4d = 0;
                utility1x1tr1 = 0;
                utility2x1tr2 = 1;
                utility3x1tr3 = 0;
                utility4x1tr4 = 0;
                pb1x23.Visible = false;
                pb2x23.Visible = true;
            }
            if (utility3x2tr3 == 1 && utility1x2trd1 == 1)
            {
                utility1x2trd1 = 0;
                utility1x2tr1d = 0;
                utility2x2tr2d = 1;
                utility3x2tr3d = 0;
                utility4x2tr4d = 0;
                utility1x2tr1 = 0;
                utility2x2tr2 = 1;
                utility3x2tr3 = 0;
                utility4x2tr4 = 0;
                pb1x24.Visible = false;
                pb2x24.Visible = true;
            }

            if (transportation3x1tr3 == 1 && transportation1x1trd1 == 1)
            {
                transportation1x1trd1 = 0;
                transportation1x1tr1d = 0;
                transportation2x1tr2d = 1;
                transportation3x1tr3d = 0;
                transportation4x1tr4d = 0;
                transportation1x1tr1 = 0;
                transportation2x1tr2 = 1;
                transportation3x1tr3 = 0;
                transportation4x1tr4 = 0;
                pb1x25.Visible = false;
                pb2x25.Visible = true;
            }
            if (transportation3x2tr3 == 1 && transportation1x2trd1 == 1)
            {
                transportation1x2trd1 = 0;
                transportation1x2tr1d = 0;
                transportation2x2tr2d = 1;
                transportation3x2tr3d = 0;
                transportation4x2tr4d = 0;
                transportation1x2tr1 = 0;
                transportation2x2tr2 = 1;
                transportation3x2tr3 = 0;
                transportation4x2tr4 = 0;
                pb1x26.Visible = false;
                pb2x26.Visible = true;
            }
            if (transportation3x3tr3 == 1 && transportation1x3trd1 == 1)
            {
                transportation1x3trd1 = 0;
                transportation1x3tr1d = 0;
                transportation2x3tr2d = 1;
                transportation3x3tr3d = 0;
                transportation4x3tr4d = 0;
                transportation1x3tr1 = 0;
                transportation2x3tr2 = 1;
                transportation3x3tr3 = 0;
                transportation4x3tr4 = 0;
                pb1x27.Visible = false;
                pb2x27.Visible = true;
            }
            if (transportation3x4tr3 == 1 && transportation1x4trd1 == 1)
            {
                transportation1x4trd1 = 0;
                transportation1x4tr1d = 0;
                transportation2x4tr2d = 1;
                transportation3x4tr3d = 0;
                transportation4x4tr4d = 0;
                transportation1x4tr1 = 0;
                transportation2x4tr2 = 1;
                transportation3x4tr3 = 0;
                transportation4x4tr4 = 0;
                pb1x28.Visible = false;
                pb2x28.Visible = true;
            }
        }
        void p3trtraded3_4()
        {
            //p3 to p4
            if (easternschooltr3 == 1 && easternschooltrd1 == 1)
            {
                easternschooltrd1 = 0;
                easternschooltr1d = 0;
                easternschooltr2d = 0;
                easternschooltr3d = 0;
                easternschooltr4d = 1;
                easternschooltr1 = 0;
                easternschooltr2 = 0;
                easternschooltr3 = 0;
                easternschooltr4 = 1;
                pb1x1.Visible = false;
                pb2x1.Visible = true;


            }
            if (westernschooltr3 == 1 && westernschooltrd1 == 1)
            {
                westernschooltrd1 = 0;
                westernschooltr1d = 0;
                westernschooltr2d = 0;
                westernschooltr3d = 0;
                westernschooltr4d = 1;
                westernschooltr1 = 0;
                westernschooltr2 = 0;
                westernschooltr3 = 0;
                westernschooltr4 = 1;
                pb1x2.Visible = false;
                pb2x2.Visible = true;

            }

            if (visayashighschooltr3 == 1 && visayashighschooltrd1 == 1)
            {
                visayashighschooltrd1 = 0;
                visayashighschooltr1d = 0;
                visayashighschooltr2d = 0;
                visayashighschooltr3d = 0;
                visayashighschooltr4d = 1;
                visayashighschooltr1 = 0;
                visayashighschooltr2 = 0;
                visayashighschooltr3 = 0;
                visayashighschooltr4 = 1;
                pb1x3.Visible = false;
                pb2x3.Visible = true;
            }
            if (southernschooltr3 == 1 && southernschooltrd1 == 1)
            {
                southernschooltrd1 = 0;
                southernschooltr1d = 0;
                southernschooltr2d = 0;
                southernschooltr3d = 0;
                southernschooltr4d = 1;
                southernschooltr1 = 0;
                southernschooltr2 = 0;
                southernschooltr3 = 0;
                southernschooltr4 = 1;
                pb1x4.Visible = false;
                pb2x4.Visible = true;
            }
            if (nationsschooltr3 == 1 && nationsschooltrd1 == 1)
            {
                nationsschooltrd1 = 0;
                nationsschooltr1d = 0;
                nationsschooltr2d = 0;
                nationsschooltr3d = 0;
                nationsschooltr4d = 1;
                nationsschooltr1 = 0;
                nationsschooltr2 = 0;
                nationsschooltr3 = 0;
                nationsschooltr4 = 1;
                pb1x5.Visible = false;
                pb2x5.Visible = true;
            }

            if (westmarkettr3 == 1 && westernschooltrd1 == 1)
            {
                westmarkettrd1 = 0;
                westmarkettr1d = 0;
                westmarkettr2d = 0;
                westmarkettr3d = 0;
                westmarkettr4d = 1;
                westmarkettr1 = 0;
                westmarkettr2 = 0;
                westmarkettr3 = 0;
                westmarkettr4 = 1;
                pb1x6.Visible = false;
                pb2x6.Visible = true;

            }
            if (nightmarkettr3 == 1 && nightmarkettrd1 == 1)
            {
                nightmarkettrd1 = 0;
                nightmarkettr1d = 0;
                nightmarkettr2d = 0;
                nightmarkettr3d = 0;
                nightmarkettr4d = 1;
                nightmarkettr1 = 0;
                nightmarkettr2 = 0;
                nightmarkettr3 = 0;
                nightmarkettr4 = 1;
                pb1x7.Visible = false;
                pb2x7.Visible = true;
            }
            if (daymarkettr3 == 1 && daymarkettrd1 == 1)
            {
                daymarkettrd1 = 0;
                daymarkettr1d = 0;
                daymarkettr2d = 0;
                daymarkettr3d = 0;
                daymarkettr4d = 1;
                daymarkettr1 = 0;
                daymarkettr2 = 0;
                daymarkettr3 = 0;
                daymarkettr4 = 1;
                pb1x8.Visible = false;
                pb2x8.Visible = true;
            }

            if (starmarkettr3 == 1 && starmarkettrd1 == 1)
            {
                starmarkettrd1 = 0;
                starmarkettr1d = 0;
                starmarkettr2d = 0;
                starmarkettr3d = 0;
                starmarkettr4d = 1;
                starmarkettr1 = 0;
                starmarkettr2 = 0;
                starmarkettr3 = 0;
                starmarkettr4 = 1;
                pb1x9.Visible = false;
                pb2x9.Visible = true;
            }
            if (moonmarkettr3 == 1 && moonmarkettrd1 == 1)
            {
                moonmarkettrd1 = 0;
                moonmarkettr1d = 0;
                moonmarkettr2d = 0;
                moonmarkettr3d = 0;
                moonmarkettr4d = 1;
                moonmarkettr1 = 0;
                moonmarkettr2 = 0;
                moonmarkettr3 = 0;
                moonmarkettr4 = 1;
                pb1x10.Visible = false;
                pb2x10.Visible = true;
            }
            if (megamarkettr3 == 1 && megamarkettrd1 == 1)
            {
                megamarkettrd1 = 0;
                megamarkettr1d = 0;
                megamarkettr2d = 0;
                megamarkettr3d = 0;
                megamarkettr4d = 1;
                megamarkettr1 = 0;
                megamarkettr2 = 0;
                megamarkettr3 = 0;
                megamarkettr4 = 1;
                pb1x11.Visible = false;
                pb2x11.Visible = true;
            }

            if (visayashospitaltr3 == 1 && visayashospitaltrd1 == 1)
            {
                visayashospitaltrd1 = 0;
                visayashospitaltr1d = 0;
                visayashospitaltr2d = 0;
                visayashospitaltr3d = 0;
                visayashospitaltr4d = 1;
                visayashospitaltr1 = 0;
                visayashospitaltr2 = 0;
                visayashospitaltr3 = 0;
                visayashospitaltr4 = 1;
                pb1x12.Visible = false;
                pb2x12.Visible = true;
            }
            if (hobertshospitaltr3 == 1 && hobertshospitaltrd1 == 1)
            {
                hobertshospitaltrd1 = 0;
                hobertshospitaltr1d = 0;
                hobertshospitaltr2d = 0;
                hobertshospitaltr3d = 0;
                hobertshospitaltr4d = 1;
                hobertshospitaltr1 = 0;
                hobertshospitaltr2 = 0;
                hobertshospitaltr3 = 0;
                hobertshospitaltr4 = 1;
                pb1x13.Visible = false;
                pb2x13.Visible = true;
            }
            if (heartshospitaltr3 == 1 && heartshospitaltrd1 == 1)
            {
                heartshospitaltrd1 = 0;
                heartshospitaltr1d = 0;
                heartshospitaltr2d = 0;
                heartshospitaltr3d = 0;
                heartshospitaltr4d = 1;
                heartshospitaltr1 = 0;
                heartshospitaltr2 = 0;
                heartshospitaltr3 = 0;
                heartshospitaltr4 = 1;
                pb1x14.Visible = false;
                pb2x14.Visible = true;

            }

            if (internshospitaltr3 == 1 && internshospitaltrd1 == 1)
            {
                internshospitaltrd1 = 0;
                internshospitaltr1d = 0;
                internshospitaltr2d = 0;
                internshospitaltr3d = 0;
                internshospitaltr4d = 1;
                internshospitaltr1 = 0;
                internshospitaltr2 = 0;
                internshospitaltr3 = 0;
                internshospitaltr4 = 1;
                pb1x15.Visible = false;
                pb2x15.Visible = true;



            }
            if (nationalhealthhospitaltr3 == 1 && nationalhealthhospitaltrd1 == 1)
            {
                nationalhealthhospitaltrd1 = 0;
                nationalhealthhospitaltr1d = 0;
                nationalhealthhospitaltr2d = 0;
                nationalhealthhospitaltr3d = 0;
                nationalhealthhospitaltr4d = 1;
                nationalhealthhospitaltr1 = 0;
                nationalhealthhospitaltr2 = 0;
                nationalhealthhospitaltr3 = 0;
                nationalhealthhospitaltr4 = 1;
                pb1x16.Visible = false;
                pb2x16.Visible = true;
            }
            if (veteranshospitaltr3 == 1 && veteranshospitaltrd1 == 1)
            {
                veteranshospitaltrd1 = 0;
                veteranshospitaltr1d = 0;
                veteranshospitaltr2d = 0;
                veteranshospitaltr3d = 0;
                veteranshospitaltr4d = 1;
                veteranshospitaltr1 = 0;
                veteranshospitaltr2 = 0;
                veteranshospitaltr3 = 0;
                veteranshospitaltr4 = 1;
                pb1x17.Visible = false;
                pb2x17.Visible = true;
            }

            if (pearlmalltr3 == 1 && pearlmalltr1d == 1)
            {
                pearlmalltrd1 = 0;
                pearlmalltr1d = 0;
                pearlmalltr2d = 0;
                pearlmalltr3d = 0;
                pearlmalltr4d = 1;
                pearlmalltr1 = 0;
                pearlmalltr2 = 0;
                pearlmalltr3 = 0;
                pearlmalltr4 = 1;
                pb1x18.Visible = false;
                pb2x18.Visible = true;
            }
            if (megamalltr3 == 1 && megamalltrd1 == 1)
            {
                megamalltrd1 = 0;
                megamalltr1d = 0;
                megamalltr2d = 0;
                megamalltr3d = 0;
                megamalltr4d = 1;
                megamalltr1 = 0;
                megamalltr2 = 0;
                megamalltr3 = 0;
                megamalltr4 = 1;
                pb1x19.Visible = false;
                pb2x19.Visible = true;
            }
            if (articmalltr3 == 1 && articmalltrd1 == 1)
            {
                articmalltrd1 = 0;
                articmalltr1d = 0;
                articmalltr2d = 0;
                articmalltr3d = 0;
                articmalltr4d = 1;
                articmalltr1 = 0;
                articmalltr2 = 0;
                articmalltr3 = 0;
                articmalltr4 = 1;
                pb1x20.Visible = false;
                pb2x20.Visible = true;
            }

            if (heavenlymalltr3 == 1 && heavenlymalltrd1 == 1)
            {
                heavenlymalltrd1 = 0;
                heavenlymalltr1d = 0;
                heavenlymalltr2d = 0;
                heavenlymalltr3d = 0;
                heavenlymalltr4d = 1;
                heavenlymalltr1 = 0;
                heavenlymalltr2 = 0;
                heavenlymalltr3 = 0;
                heavenlymalltr4 = 1;
                pb1x21.Visible = false;
                pb2x21.Visible = true;
            }
            if (shangrillamalltr3 == 1 && shangrillamalltrd1 == 1)
            {
                shangrillamalltrd1 = 0;
                shangrillamalltr1d = 0;
                shangrillamalltr2d = 0;
                shangrillamalltr3d = 0;
                shangrillamalltr4d = 1;
                shangrillamalltr1 = 0;
                shangrillamalltr2 = 0;
                shangrillamalltr3 = 0;
                shangrillamalltr4 = 1;
                pb1x22.Visible = false;
                pb2x22.Visible = true;
            }

            if (utility3x1tr3 == 1 && utility1x1trd1 == 1)
            {
                utility1x1trd1 = 0;
                utility1x1tr1d = 0;
                utility2x1tr2d = 0;
                utility3x1tr3d = 0;
                utility4x1tr4d = 1;
                utility1x1tr1 = 0;
                utility2x1tr2 = 0;
                utility3x1tr3 = 0;
                utility4x1tr4 = 1;
                pb1x23.Visible = false;
                pb2x23.Visible = true;
            }
            if (utility3x2tr3 == 1 && utility1x2trd1 == 1)
            {
                utility1x2trd1 = 0;
                utility1x2tr1d = 0;
                utility2x2tr2d = 0;
                utility3x2tr3d = 0;
                utility4x2tr4d = 1;
                utility1x2tr1 = 0;
                utility2x2tr2 = 0;
                utility3x2tr3 = 0;
                utility4x2tr4 = 1;
                pb1x24.Visible = false;
                pb2x24.Visible = true;
            }

            if (transportation3x1tr3 == 1 && transportation1x1trd1 == 1)
            {
                transportation1x1trd1 = 0;
                transportation1x1tr1d = 0;
                transportation2x1tr2d = 0;
                transportation3x1tr3d = 0;
                transportation4x1tr4d = 1;
                transportation1x1tr1 = 0;
                transportation2x1tr2 = 0;
                transportation3x1tr3 = 0;
                transportation4x1tr4 = 1;
                pb1x25.Visible = false;
                pb2x25.Visible = true;
            }
            if (transportation3x2tr3 == 1 && transportation1x2trd1 == 1)
            {
                transportation1x2trd1 = 0;
                transportation1x2tr1d = 0;
                transportation2x2tr2d = 0;
                transportation3x2tr3d = 0;
                transportation4x2tr4d = 1;
                transportation1x2tr1 = 0;
                transportation2x2tr2 = 0;
                transportation3x2tr3 = 0;
                transportation4x2tr4 = 1;
                pb1x26.Visible = false;
                pb2x26.Visible = true;
            }
            if (transportation3x3tr3 == 1 && transportation1x3trd1 == 1)
            {
                transportation1x3trd1 = 0;
                transportation1x3tr1d = 0;
                transportation2x3tr2d = 0;
                transportation3x3tr3d = 0;
                transportation4x3tr4d = 1;
                transportation1x3tr1 = 0;
                transportation2x3tr2 = 0;
                transportation3x3tr3 = 0;
                transportation4x3tr4 = 1;
                pb1x27.Visible = false;
                pb2x27.Visible = true;
            }
            if (transportation3x4tr3 == 1 && transportation1x4trd1 == 1)
            {
                transportation1x4trd1 = 0;
                transportation1x4tr1d = 0;
                transportation2x4tr2d = 0;
                transportation3x4tr3d = 0;
                transportation4x4tr4d = 1;
                transportation1x4tr1 = 0;
                transportation2x4tr2 = 0;
                transportation3x4tr3 = 0;
                transportation4x4tr4 = 1;
                pb1x28.Visible = false;
                pb2x28.Visible = true;
            }

        }
        void p4trtraded4()
        {
            if (easternschooltr4 == 1 && easternschooltrd1 == 1)
            {
                easternschooltrd1 = 0;
                easternschooltr1d = 1;
                easternschooltr2d = 0;
                easternschooltr3d = 0;
                easternschooltr4d = 0;
                easternschooltr1 = 1;
                easternschooltr2 = 0;
                easternschooltr3 = 0;
                easternschooltr4 = 0;
                pb1x1.Visible = false;
                pb2x1.Visible = true;


            }
            if (westernschooltr4 == 1 && westernschooltrd1 == 1)
            {
                westernschooltrd1 = 0;
                westernschooltr1d = 1;
                westernschooltr2d = 0;
                westernschooltr3d = 0;
                westernschooltr4d = 0;
                westernschooltr1 = 1;
                westernschooltr2 = 0;
                westernschooltr3 = 0;
                westernschooltr4 = 0;
                pb1x2.Visible = false;
                pb2x2.Visible = true;

            }

            if (visayashighschooltr4 == 1 && visayashighschooltrd1 == 1)
            {
                visayashighschooltrd1 = 0;
                visayashighschooltr1d = 1;
                visayashighschooltr2d = 0;
                visayashighschooltr3d = 0;
                visayashighschooltr4d = 0;
                visayashighschooltr1 = 1;
                visayashighschooltr2 = 0;
                visayashighschooltr3 = 0;
                visayashighschooltr4 = 0;
                pb1x3.Visible = false;
                pb2x3.Visible = true;
            }
            if (southernschooltr4 == 1 && southernschooltrd1 == 1)
            {
                southernschooltrd1 = 0;
                southernschooltr1d = 1;
                southernschooltr2d = 0;
                southernschooltr3d = 0;
                southernschooltr4d = 0;
                southernschooltr1 = 1;
                southernschooltr2 = 0;
                southernschooltr3 = 0;
                southernschooltr4 = 0;
                pb1x4.Visible = false;
                pb2x4.Visible = true;
            }
            if (nationsschooltr4 == 1 && nationsschooltrd1 == 1)
            {
                nationsschooltrd1 = 0;
                nationsschooltr1d = 1;
                nationsschooltr2d = 0;
                nationsschooltr3d = 0;
                nationsschooltr4d = 0;
                nationsschooltr1 = 1;
                nationsschooltr2 = 0;
                nationsschooltr3 = 0;
                nationsschooltr4 = 0;
                pb1x5.Visible = false;
                pb2x5.Visible = true;
            }

            if (westmarkettr4 == 1 && westernschooltrd1 == 1)
            {
                westmarkettrd1 = 0;
                westmarkettr1d = 1;
                westmarkettr2d = 0;
                westmarkettr3d = 0;
                westmarkettr4d = 0;
                westmarkettr1 = 1;
                westmarkettr2 = 0;
                westmarkettr3 = 0;
                westmarkettr4 = 0;
                pb1x6.Visible = false;
                pb2x6.Visible = true;

            }
            if (nightmarkettr4 == 1 && nightmarkettrd1 == 1)
            {
                nightmarkettrd1 = 0;
                nightmarkettr1d = 1;
                nightmarkettr2d = 0;
                nightmarkettr3d = 0;
                nightmarkettr4d = 0;
                nightmarkettr1 = 1;
                nightmarkettr2 = 0;
                nightmarkettr3 = 0;
                nightmarkettr4 = 0;
                pb1x7.Visible = false;
                pb2x7.Visible = true;
            }
            if (daymarkettr4 == 1 && daymarkettrd1 == 1)
            {
                daymarkettrd1 = 0;
                daymarkettr1d = 1;
                daymarkettr2d = 0;
                daymarkettr3d = 0;
                daymarkettr4d = 0;
                daymarkettr1 = 1;
                daymarkettr2 = 0;
                daymarkettr3 = 0;
                daymarkettr4 = 0;
                pb1x8.Visible = false;
                pb2x8.Visible = true;
            }

            if (starmarkettr4 == 1 && starmarkettrd1 == 1)
            {
                starmarkettrd1 = 0;
                starmarkettr1d = 1;
                starmarkettr2d = 0;
                starmarkettr3d = 0;
                starmarkettr4d = 0;
                starmarkettr1 = 1;
                starmarkettr2 = 0;
                starmarkettr3 = 0;
                starmarkettr4 = 0;
                pb1x9.Visible = false;
                pb2x9.Visible = true;
            }
            if (moonmarkettr4 == 1 && moonmarkettrd1 == 1)
            {
                moonmarkettrd1 = 0;
                moonmarkettr1d = 1;
                moonmarkettr2d = 0;
                moonmarkettr3d = 0;
                moonmarkettr4d = 0;
                moonmarkettr1 = 1;
                moonmarkettr2 = 0;
                moonmarkettr3 = 0;
                moonmarkettr4 = 0;
                pb1x10.Visible = false;
                pb2x10.Visible = true;
            }
            if (megamarkettr4 == 1 && megamarkettrd1 == 1)
            {
                megamarkettrd1 = 0;
                megamalltr1d = 1;
                megamalltr2d = 0;
                megamalltr3d = 0;
                megamalltr4d = 0;
                megamalltr1 = 1;
                megamalltr2 = 0;
                megamalltr3 = 0;
                megamalltr4 = 0;
                pb1x11.Visible = false;
                pb2x11.Visible = true;
            }

            if (visayashospitaltr4 == 1 && visayashospitaltrd1 == 1)
            {
                visayashospitaltrd1 = 0;
                visayashospitaltr1d = 1;
                visayashospitaltr2d = 0;
                visayashospitaltr3d = 0;
                visayashospitaltr4d = 0;
                visayashospitaltr1 = 1;
                visayashospitaltr2 = 0;
                visayashospitaltr3 = 0;
                visayashospitaltr4 = 0;
                pb1x12.Visible = false;
                pb2x12.Visible = true;
            }
            if (hobertshospitaltr4 == 1 && hobertshospitaltrd1 == 1)
            {
                hobertshospitaltrd1 = 0;
                hobertshospitaltr1d = 1;
                hobertshospitaltr2d = 0;
                hobertshospitaltr3d = 0;
                hobertshospitaltr4d = 0;
                hobertshospitaltr1 = 1;
                hobertshospitaltr2 = 0;
                hobertshospitaltr3 = 0;
                hobertshospitaltr4 = 0;
                pb1x13.Visible = false;
                pb2x13.Visible = true;
            }
            if (heartshospitaltr4 == 1 && heartshospitaltrd1 == 1)
            {
                heartshospitaltrd1 = 0;
                heartshospitaltr1d = 1;
                heartshospitaltr2d = 0;
                heartshospitaltr3d = 0;
                heartshospitaltr4d = 0;
                heartshospitaltr1 = 1;
                heartshospitaltr2 = 0;
                heartshospitaltr3 = 0;
                heartshospitaltr4 = 0;
                pb1x14.Visible = false;
                pb2x14.Visible = true;

            }

            if (internshospitaltr4 == 1 && internshospitaltrd1 == 1)
            {
                internshospitaltrd1 = 0;
                internshospitaltr1d = 1;
                internshospitaltr2d = 0;
                internshospitaltr3d = 0;
                internshospitaltr4d = 0;
                internshospitaltr1 = 1;
                internshospitaltr2 = 0;
                internshospitaltr3 = 0;
                internshospitaltr4 = 0;
                pb1x15.Visible = false;
                pb2x15.Visible = true;


            }
            if (nationalhealthhospitaltr4 == 1 && nationalhealthhospitaltrd1 == 1)
            {
                nationalhealthhospitaltrd1 = 0;
                nationalhealthhospitaltr1d = 1;
                nationalhealthhospitaltr2d = 0;
                nationalhealthhospitaltr3d = 0;
                nationalhealthhospitaltr4d = 0;
                nationalhealthhospitaltr1 = 1;
                nationalhealthhospitaltr2 = 0;
                nationalhealthhospitaltr3 = 0;
                nationalhealthhospitaltr4 = 0;
                pb1x16.Visible = false;
                pb2x16.Visible = true;
            }
            if (veteranshospitaltr4 == 1 && veteranshospitaltrd1 == 1)
            {
                veteranshospitaltrd1 = 0;
                veteranshospitaltr1d = 1;
                veteranshospitaltr2d = 0;
                veteranshospitaltr3d = 0;
                veteranshospitaltr4d = 0;
                veteranshospitaltr1 = 1;
                veteranshospitaltr2 = 0;
                veteranshospitaltr3 = 0;
                veteranshospitaltr4 = 0;
                pb1x17.Visible = false;
                pb2x17.Visible = true;
            }

            if (pearlmalltr4 == 1 && pearlmalltr1d == 1)
            {
                pearlmalltrd1 = 0;
                pearlmalltr1d = 1;
                pearlmalltr2d = 0;
                pearlmalltr3d = 0;
                pearlmalltr4d = 0;
                pearlmalltr1 = 1;
                pearlmalltr2 = 0;
                pearlmalltr3 = 0;
                pearlmalltr4 = 0;
                pb1x18.Visible = false;
                pb2x18.Visible = true;
            }
            if (megamalltr4 == 1 && megamalltrd1 == 1)
            {
                megamalltrd1 = 0;
                megamalltr1d = 1;
                megamalltr2d = 0;
                megamalltr3d = 0;
                megamalltr4d = 0;
                megamalltr1 = 1;
                megamalltr2 = 0;
                megamalltr3 = 0;
                megamalltr4 = 0;
                pb1x19.Visible = false;
                pb2x19.Visible = true;
            }
            if (articmalltr4 == 1 && articmalltrd1 == 1)
            {
                articmalltrd1 = 0;
                articmalltr1d = 1;
                articmalltr2d = 0;
                articmalltr3d = 0;
                articmalltr4d = 0;
                articmalltr1 = 1;
                articmalltr2 = 0;
                articmalltr3 = 0;
                articmalltr4 = 0;
                pb1x20.Visible = false;
                pb2x20.Visible = true;
            }

            if (heavenlymalltr4 == 1 && heavenlymalltrd1 == 1)
            {
                heavenlymalltrd1 = 0;
                heavenlymalltr1d = 1;
                heavenlymalltr2d = 0;
                heavenlymalltr3d = 0;
                heavenlymalltr4d = 0;
                heavenlymalltr1 = 1;
                heavenlymalltr2 = 0;
                heavenlymalltr3 = 0;
                heavenlymalltr4 = 0;
                pb1x21.Visible = false;
                pb2x21.Visible = true;
            }
            if (shangrillamalltr4 == 1 && shangrillamalltrd1 == 1)
            {
                shangrillamalltrd1 = 0;
                shangrillamalltr1d = 1;
                shangrillamalltr2d = 0;
                shangrillamalltr3d = 0;
                shangrillamalltr4d = 0;
                shangrillamalltr1 = 1;
                shangrillamalltr2 = 0;
                shangrillamalltr3 = 0;
                shangrillamalltr4 = 0;
                pb1x22.Visible = false;
                pb2x22.Visible = true;
            }

            if (utility4x1tr4 == 1 && utility1x1trd1 == 1)
            {
                utility1x1trd1 = 0;
                utility1x1tr1d = 1;
                utility2x1tr2d = 0;
                utility3x1tr3d = 0;
                utility4x1tr4d = 0;
                utility1x1tr1 = 1;
                utility2x1tr2 = 0;
                utility3x1tr3 = 0;
                utility4x1tr4 = 0;
                pb1x23.Visible = false;
                pb2x23.Visible = true;
            }
            if (utility4x2tr4 == 1 && utility1x2trd1 == 1)
            {
                utility1x2trd1 = 0;
                utility1x2tr1d = 1;
                utility2x2tr2d = 0;
                utility3x2tr3d = 0;
                utility4x2tr4d = 0;
                utility1x2tr1 = 1;
                utility2x2tr2 = 0;
                utility3x2tr3 = 0;
                utility4x2tr4 = 0;
                pb1x24.Visible = false;
                pb2x24.Visible = true;
            }

            if (transportation4x1tr4 == 1 && transportation1x1trd1 == 1)
            {
                transportation1x1trd1 = 0;
                transportation1x1tr1d = 1;
                transportation2x1tr2d = 0;
                transportation3x1tr3d = 0;
                transportation4x1tr4d = 0;
                transportation1x1tr1 = 1;
                transportation2x1tr2 = 0;
                transportation3x1tr3 = 0;
                transportation4x1tr4 = 0;
                pb1x25.Visible = false;
                pb2x25.Visible = true;
            }
            if (transportation4x2tr4 == 1 && transportation1x2trd1 == 1)
            {
                transportation1x2trd1 = 0;
                transportation1x2tr1d = 1;
                transportation2x2tr2d = 0;
                transportation3x2tr3d = 0;
                transportation4x2tr4d = 0;
                transportation1x2tr1 = 1;
                transportation2x2tr2 = 0;
                transportation3x2tr3 = 0;
                transportation4x2tr4 = 0;
                pb1x26.Visible = false;
                pb2x26.Visible = true;
            }
            if (transportation4x3tr4 == 1 && transportation1x3trd1 == 1)
            {
                transportation1x3trd1 = 0;
                transportation1x3tr1d = 1;
                transportation2x3tr2d = 0;
                transportation3x3tr3d = 0;
                transportation4x3tr4d = 0;
                transportation1x3tr1 = 1;
                transportation2x3tr2 = 0;
                transportation3x3tr3 = 0;
                transportation4x3tr4 = 0;
                pb1x27.Visible = false;
                pb2x27.Visible = true;
            }
            if (transportation4x4tr4 == 1 && transportation1x4trd1 == 1)
            {
                transportation1x4trd1 = 0;
                transportation1x4tr1d = 1;
                transportation2x4tr2d = 0;
                transportation3x4tr3d = 0;
                transportation4x4tr4d = 0;
                transportation1x4tr1 = 1;
                transportation2x4tr2 = 0;
                transportation3x4tr3 = 0;
                transportation4x4tr4 = 0;
                pb1x28.Visible = false;
                pb2x28.Visible = true;
            }


        }
        void p4trtraded4_2()
        {
            //p4 to p2
            if (easternschooltr4 == 1 && easternschooltrd1 == 1)
            {
                easternschooltrd1 = 0;
                easternschooltr1d = 0;
                easternschooltr2d = 1;
                easternschooltr3d = 0;
                easternschooltr4d = 0;
                easternschooltr1 = 0;
                easternschooltr2 = 1;
                easternschooltr3 = 0;
                easternschooltr4 = 0;
                pb1x1.Visible = false;
                pb2x1.Visible = true;


            }
            if (westernschooltr4 == 1 && westernschooltrd1 == 1)
            {
                westernschooltrd1 = 0;
                westernschooltr1d = 0;
                westernschooltr2d = 1;
                westernschooltr3d = 0;
                westernschooltr4d = 0;
                westernschooltr1 = 0;
                westernschooltr2 = 1;
                westernschooltr3 = 0;
                westernschooltr4 = 0;
                pb1x2.Visible = false;
                pb2x2.Visible = true;

            }

            if (visayashighschooltr4 == 1 && visayashighschooltrd1 == 1)
            {
                visayashighschooltrd1 = 0;
                visayashighschooltr1d = 0;
                visayashighschooltr2d = 1;
                visayashighschooltr3d = 0;
                visayashighschooltr4d = 0;
                visayashighschooltr1 = 0;
                visayashighschooltr2 = 1;
                visayashighschooltr3 = 0;
                visayashighschooltr4 = 0;
                pb1x3.Visible = false;
                pb2x3.Visible = true;
            }
            if (southernschooltr4 == 1 && southernschooltrd1 == 1)
            {
                southernschooltrd1 = 0;
                southernschooltr1d = 0;
                southernschooltr2d = 1;
                southernschooltr3d = 0;
                southernschooltr4d = 0;
                southernschooltr1 = 0;
                southernschooltr2 = 1;
                southernschooltr3 = 0;
                southernschooltr4 = 0;
                pb1x4.Visible = false;
                pb2x4.Visible = true;
            }
            if (nationsschooltr4 == 1 && nationsschooltrd1 == 1)
            {
                nationsschooltrd1 = 0;
                nationsschooltr1d = 0;
                nationsschooltr2d = 1;
                nationsschooltr3d = 0;
                nationsschooltr4d = 0;
                nationsschooltr1 = 0;
                nationsschooltr2 = 1;
                nationsschooltr3 = 0;
                nationsschooltr4 = 0;
                pb1x5.Visible = false;
                pb2x5.Visible = true;
            }

            if (westmarkettr4 == 1 && westernschooltrd1 == 1)
            {
                westmarkettrd1 = 0;
                westmarkettr1d = 0;
                westmarkettr2d = 1;
                westmarkettr3d = 0;
                westmarkettr4d = 0;
                westmarkettr1 = 0;
                westmarkettr2 = 1;
                westmarkettr3 = 0;
                westmarkettr4 = 0;
                pb1x6.Visible = false;
                pb2x6.Visible = true;

            }
            if (nightmarkettr4 == 1 && nightmarkettrd1 == 1)
            {
                nightmarkettrd1 = 0;
                nightmarkettr1d = 0;
                nightmarkettr2d = 1;
                nightmarkettr3d = 0;
                nightmarkettr4d = 0;
                nightmarkettr1 = 0;
                nightmarkettr2 = 1;
                nightmarkettr3 = 0;
                nightmarkettr4 = 0;
                pb1x7.Visible = false;
                pb2x7.Visible = true;
            }
            if (daymarkettr4 == 1 && daymarkettrd1 == 1)
            {
                daymarkettrd1 = 0;
                daymarkettr1d = 0;
                daymarkettr2d = 1;
                daymarkettr3d = 0;
                daymarkettr4d = 0;
                daymarkettr1 = 0;
                daymarkettr2 = 1;
                daymarkettr3 = 0;
                daymarkettr4 = 0;
                pb1x8.Visible = false;
                pb2x8.Visible = true;
            }

            if (starmarkettr4 == 1 && starmarkettrd1 == 1)
            {
                starmarkettrd1 = 0;
                starmarkettr1d = 0;
                starmarkettr2d = 1;
                starmarkettr3d = 0;
                starmarkettr4d = 0;
                starmarkettr1 = 0;
                starmarkettr2 = 1;
                starmarkettr3 = 0;
                starmarkettr4 = 0;
                pb1x9.Visible = false;
                pb2x9.Visible = true;
            }
            if (moonmarkettr4 == 1 && moonmarkettrd1 == 1)
            {
                moonmarkettrd1 = 0;
                moonmarkettr1d = 0;
                moonmarkettr2d = 1;
                moonmarkettr3d = 0;
                moonmarkettr4d = 0;
                moonmarkettr1 = 0;
                moonmarkettr2 = 1;
                moonmarkettr3 = 0;
                moonmarkettr4 = 0;
                pb1x10.Visible = false;
                pb2x10.Visible = true;
            }
            if (megamarkettr4 == 1 && megamarkettrd1 == 1)
            {
                megamarkettrd1 = 0;
                megamarkettr1d = 0;
                megamarkettr2d = 1;
                megamarkettr3d = 0;
                megamarkettr4d = 0;
                megamarkettr1 = 0;
                megamarkettr2 = 1;
                megamarkettr3 = 0;
                megamarkettr4 = 0;
                pb1x11.Visible = false;
                pb2x11.Visible = true;
            }

            if (visayashospitaltr4 == 1 && visayashospitaltrd1 == 1)
            {
                visayashospitaltrd1 = 0;
                visayashospitaltr1d = 0;
                visayashospitaltr2d = 1;
                visayashospitaltr3d = 0;
                visayashospitaltr4d = 0;
                visayashospitaltr1 = 0;
                visayashospitaltr2 = 1;
                visayashospitaltr3 = 0;
                visayashospitaltr4 = 0;
                pb1x12.Visible = false;
                pb2x12.Visible = true;
            }
            if (hobertshospitaltr4 == 1 && hobertshospitaltrd1 == 1)
            {
                hobertshospitaltrd1 = 0;
                hobertshospitaltr1d = 0;
                hobertshospitaltr2d = 1;
                hobertshospitaltr3d = 0;
                hobertshospitaltr4d = 0;
                hobertshospitaltr1 = 0;
                hobertshospitaltr2 = 1;
                hobertshospitaltr3 = 0;
                hobertshospitaltr4 = 0;
                pb1x13.Visible = false;
                pb2x13.Visible = true;
            }
            if (heartshospitaltr4 == 1 && heartshospitaltrd1 == 1)
            {
                heartshospitaltrd1 = 0;
                heartshospitaltr1d = 0;
                heartshospitaltr2d = 1;
                heartshospitaltr3d = 0;
                heartshospitaltr4d = 0;
                heartshospitaltr1 = 0;
                heartshospitaltr2 = 1;
                heartshospitaltr3 = 0;
                heartshospitaltr4 = 0;
                pb1x14.Visible = false;
                pb2x14.Visible = true;

            }

            if (internshospitaltr4 == 1 && internshospitaltrd1 == 1)
            {
                internshospitaltrd1 = 0;
                internshospitaltr1d = 0;
                internshospitaltr2d = 1;
                internshospitaltr3d = 0;
                internshospitaltr4d = 0;
                internshospitaltr1 = 0;
                internshospitaltr2 = 1;
                internshospitaltr3 = 0;
                internshospitaltr4 = 0;
                pb1x15.Visible = false;
                pb2x15.Visible = true;



            }
            if (nationalhealthhospitaltr4 == 1 && nationalhealthhospitaltrd1 == 1)
            {
                nationalhealthhospitaltrd1 = 0;
                nationalhealthhospitaltr1d = 0;
                nationalhealthhospitaltr2d = 1;
                nationalhealthhospitaltr3d = 0;
                nationalhealthhospitaltr4d = 0;
                nationalhealthhospitaltr1 = 0;
                nationalhealthhospitaltr2 = 1;
                nationalhealthhospitaltr3 = 0;
                nationalhealthhospitaltr4 = 0;
                pb1x16.Visible = false;
                pb2x16.Visible = true;
            }
            if (veteranshospitaltr4 == 1 && veteranshospitaltrd1 == 1)
            {
                veteranshospitaltrd1 = 0;
                veteranshospitaltr1d = 0;
                veteranshospitaltr2d = 1;
                veteranshospitaltr3d = 0;
                veteranshospitaltr4d = 0;
                veteranshospitaltr1 = 0;
                veteranshospitaltr2 = 1;
                veteranshospitaltr3 = 0;
                veteranshospitaltr4 = 0;
                pb1x17.Visible = false;
                pb2x17.Visible = true;
            }

            if (pearlmalltr4 == 1 && pearlmalltr1d == 1)
            {
                pearlmalltrd1 = 0;
                pearlmalltr1d = 0;
                pearlmalltr2d = 1;
                pearlmalltr3d = 0;
                pearlmalltr4d = 0;
                pearlmalltr1 = 0;
                pearlmalltr2 = 1;
                pearlmalltr3 = 0;
                pearlmalltr4 = 0;
                pb1x18.Visible = false;
                pb2x18.Visible = true;
            }
            if (megamalltr4 == 1 && megamalltrd1 == 1)
            {
                megamalltrd1 = 0;
                megamalltr1d = 0;
                megamalltr2d = 1;
                megamalltr3d = 0;
                megamalltr4d = 0;
                megamalltr1 = 0;
                megamalltr2 = 1;
                megamalltr3 = 0;
                megamalltr4 = 0;
                pb1x19.Visible = false;
                pb2x19.Visible = true;
            }
            if (articmalltr4 == 1 && articmalltrd1 == 1)
            {
                articmalltrd1 = 0;
                articmalltr1d = 0;
                articmalltr2d = 1;
                articmalltr3d = 0;
                articmalltr4d = 0;
                articmalltr1 = 0;
                articmalltr2 = 1;
                articmalltr3 = 0;
                articmalltr4 = 0;
                pb1x20.Visible = false;
                pb2x20.Visible = true;
            }

            if (heavenlymalltr4 == 1 && heavenlymalltrd1 == 1)
            {
                heavenlymalltrd1 = 0;
                heavenlymalltr1d = 0;
                heavenlymalltr2d = 1;
                heavenlymalltr3d = 0;
                heavenlymalltr4d = 0;
                heavenlymalltr1 = 0;
                heavenlymalltr2 = 1;
                heavenlymalltr3 = 0;
                heavenlymalltr4 = 0;
                pb1x21.Visible = false;
                pb2x21.Visible = true;
            }
            if (shangrillamalltr4 == 1 && shangrillamalltrd1 == 1)
            {
                shangrillamalltrd1 = 0;
                shangrillamalltr1d = 0;
                shangrillamalltr2d = 1;
                shangrillamalltr3d = 0;
                shangrillamalltr4d = 0;
                shangrillamalltr1 = 0;
                shangrillamalltr2 = 1;
                shangrillamalltr3 = 0;
                shangrillamalltr4 = 0;
                pb1x22.Visible = false;
                pb2x22.Visible = true;
            }

            if (utility4x1tr4 == 1 && utility1x1trd1 == 1)
            {
                utility1x1trd1 = 0;
                utility1x1tr1d = 0;
                utility2x1tr2d = 1;
                utility3x1tr3d = 0;
                utility4x1tr4d = 0;
                utility1x1tr1 = 0;
                utility2x1tr2 = 1;
                utility3x1tr3 = 0;
                utility4x1tr4 = 0;
                pb1x23.Visible = false;
                pb2x23.Visible = true;
            }
            if (utility4x2tr4 == 1 && utility1x2trd1 == 1)
            {
                utility1x2trd1 = 0;
                utility1x2tr1d = 0;
                utility2x2tr2d = 1;
                utility3x2tr3d = 0;
                utility4x2tr4d = 0;
                utility1x2tr1 = 0;
                utility2x2tr2 = 1;
                utility3x2tr3 = 0;
                utility4x2tr4 = 0;
                pb1x24.Visible = false;
                pb2x24.Visible = true;
            }

            if (transportation4x1tr4 == 1 && transportation1x1trd1 == 1)
            {
                transportation1x1trd1 = 0;
                transportation1x1tr1d = 0;
                transportation2x1tr2d = 1;
                transportation3x1tr3d = 0;
                transportation4x1tr4d = 0;
                transportation1x1tr1 = 0;
                transportation2x1tr2 = 1;
                transportation3x1tr3 = 0;
                transportation4x1tr4 = 0;
                pb1x25.Visible = false;
                pb2x25.Visible = true;
            }
            if (transportation4x2tr4 == 1 && transportation1x2trd1 == 1)
            {
                transportation1x2trd1 = 0;
                transportation1x2tr1d = 0;
                transportation2x2tr2d = 1;
                transportation3x2tr3d = 0;
                transportation4x2tr4d = 0;
                transportation1x2tr1 = 0;
                transportation2x2tr2 = 1;
                transportation3x2tr3 = 0;
                transportation4x2tr4 = 0;
                pb1x26.Visible = false;
                pb2x26.Visible = true;
            }
            if (transportation4x3tr4 == 1 && transportation1x3trd1 == 1)
            {
                transportation1x3trd1 = 0;
                transportation1x3tr1d = 0;
                transportation2x3tr2d = 1;
                transportation3x3tr3d = 0;
                transportation4x3tr4d = 0;
                transportation1x3tr1 = 0;
                transportation2x3tr2 = 1;
                transportation3x3tr3 = 0;
                transportation4x3tr4 = 0;
                pb1x27.Visible = false;
                pb2x27.Visible = true;
            }
            if (transportation4x4tr4 == 1 && transportation1x4trd1 == 1)
            {
                transportation1x4trd1 = 0;
                transportation1x4tr1d = 0;
                transportation2x4tr2d = 1;
                transportation3x4tr3d = 0;
                transportation4x4tr4d = 0;
                transportation1x4tr1 = 0;
                transportation2x4tr2 = 1;
                transportation3x4tr3 = 0;
                transportation4x4tr4 = 0;
                pb1x28.Visible = false;
                pb2x28.Visible = true;
            }

        }
        void p4trtraded4_3()
        {

            //p4 to p3
            if (easternschooltr4 == 1 && easternschooltrd1 == 1)
            {
                easternschooltrd1 = 0;
                easternschooltr1d = 0;
                easternschooltr2d = 0;
                easternschooltr3d = 1;
                easternschooltr4d = 0;
                easternschooltr1 = 0;
                easternschooltr2 = 0;
                easternschooltr3 = 1;
                easternschooltr4 = 0;
                pb1x1.Visible = false;
                pb2x1.Visible = true;


            }
            if (westernschooltr4 == 1 && westernschooltrd1 == 1)
            {
                westernschooltrd1 = 0;
                westernschooltr1d = 0;
                westernschooltr2d = 0;
                westernschooltr3d = 1;
                westernschooltr4d = 0;
                westernschooltr1 = 0;
                westernschooltr2 = 0;
                westernschooltr3 = 1;
                westernschooltr4 = 0;
                pb1x2.Visible = false;
                pb2x2.Visible = true;

            }

            if (visayashighschooltr4 == 1 && visayashighschooltrd1 == 1)
            {
                visayashighschooltrd1 = 0;
                visayashighschooltr1d = 0;
                visayashighschooltr2d = 0;
                visayashighschooltr3d = 1;
                visayashighschooltr4d = 0;
                visayashighschooltr1 = 0;
                visayashighschooltr2 = 0;
                visayashighschooltr3 = 1;
                visayashighschooltr4 = 0;
                pb1x3.Visible = false;
                pb2x3.Visible = true;
            }
            if (southernschooltr4 == 1 && southernschooltrd1 == 1)
            {
                southernschooltrd1 = 0;
                southernschooltr1d = 0;
                southernschooltr2d = 0;
                southernschooltr3d = 1;
                southernschooltr4d = 0;
                southernschooltr1 = 0;
                southernschooltr2 = 0;
                southernschooltr3 = 1;
                southernschooltr4 = 0;
                pb1x4.Visible = false;
                pb2x4.Visible = true;
            }
            if (nationsschooltr4 == 1 && nationsschooltrd1 == 1)
            {
                nationsschooltrd1 = 0;
                nationsschooltr1d = 0;
                nationsschooltr2d = 0;
                nationsschooltr3d = 1;
                nationsschooltr4d = 0;
                nationsschooltr1 = 0;
                nationsschooltr2 = 0;
                nationsschooltr3 = 1;
                nationsschooltr4 = 0;
                pb1x5.Visible = false;
                pb2x5.Visible = true;
            }

            if (westmarkettr4 == 1 && westernschooltrd1 == 1)
            {
                westmarkettrd1 = 0;
                westmarkettr1d = 0;
                westmarkettr2d = 0;
                westmarkettr3d = 1;
                westmarkettr4d = 0;
                westmarkettr1 = 0;
                westmarkettr2 = 0;
                westmarkettr3 = 1;
                westmarkettr4 = 0;
                pb1x6.Visible = false;
                pb2x6.Visible = true;

            }
            if (nightmarkettr4 == 1 && nightmarkettrd1 == 1)
            {
                nightmarkettrd1 = 0;
                nightmarkettr1d = 0;
                nightmarkettr2d = 0;
                nightmarkettr3d = 1;
                nightmarkettr4d = 0;
                nightmarkettr1 = 0;
                nightmarkettr2 = 0;
                nightmarkettr3 = 1;
                nightmarkettr4 = 0;
                pb1x7.Visible = false;
                pb2x7.Visible = true;
            }
            if (daymarkettr4 == 1 && daymarkettrd1 == 1)
            {
                daymarkettrd1 = 0;
                daymarkettr1d = 0;
                daymarkettr2d = 0;
                daymarkettr3d = 1;
                daymarkettr4d = 0;
                daymarkettr1 = 0;
                daymarkettr2 = 0;
                daymarkettr3 = 1;
                daymarkettr4 = 0;
                pb1x8.Visible = false;
                pb2x8.Visible = true;
            }

            if (starmarkettr4 == 1 && starmarkettrd1 == 1)
            {
                starmarkettrd1 = 0;
                starmarkettr1d = 0;
                starmarkettr2d = 0;
                starmarkettr3d = 1;
                starmarkettr4d = 0;
                starmarkettr1 = 0;
                starmarkettr2 = 0;
                starmarkettr3 = 1;
                starmarkettr4 = 0;
                pb1x9.Visible = false;
                pb2x9.Visible = true;
            }
            if (moonmarkettr4 == 1 && moonmarkettrd1 == 1)
            {
                moonmarkettrd1 = 0;
                moonmarkettr1d = 0;
                moonmarkettr2d = 0;
                moonmarkettr3d = 1;
                moonmarkettr4d = 0;
                moonmarkettr1 = 0;
                moonmarkettr2 = 0;
                moonmarkettr3 = 1;
                moonmarkettr4 = 0;
                pb1x10.Visible = false;
                pb2x10.Visible = true;
            }
            if (megamarkettr4 == 1 && megamarkettrd1 == 1)
            {
                megamarkettrd1 = 0;
                megamarkettr1d = 0;
                megamarkettr2d = 0;
                megamarkettr3d = 1;
                megamarkettr4d = 0;
                megamarkettr1 = 0;
                megamarkettr2 = 0;
                megamarkettr3 = 1;
                megamarkettr4 = 0;
                pb1x11.Visible = false;
                pb2x11.Visible = true;
            }

            if (visayashospitaltr4 == 1 && visayashospitaltrd1 == 1)
            {
                visayashospitaltrd1 = 0;
                visayashospitaltr1d = 0;
                visayashospitaltr2d = 0;
                visayashospitaltr3d = 1;
                visayashospitaltr4d = 0;
                visayashospitaltr1 = 0;
                visayashospitaltr2 = 0;
                visayashospitaltr3 = 1;
                visayashospitaltr4 = 0;
                pb1x12.Visible = false;
                pb2x12.Visible = true;
            }
            if (hobertshospitaltr4 == 1 && hobertshospitaltrd1 == 1)
            {
                hobertshospitaltrd1 = 0;
                hobertshospitaltr1d = 0;
                hobertshospitaltr2d = 0;
                hobertshospitaltr3d = 1;
                hobertshospitaltr4d = 0;
                hobertshospitaltr1 = 0;
                hobertshospitaltr2 = 0;
                hobertshospitaltr3 = 1;
                hobertshospitaltr4 = 0;
                pb1x13.Visible = false;
                pb2x13.Visible = true;
            }
            if (heartshospitaltr4 == 1 && heartshospitaltrd1 == 1)
            {
                heartshospitaltrd1 = 0;
                heartshospitaltr1d = 0;
                heartshospitaltr2d = 0;
                heartshospitaltr3d = 1;
                heartshospitaltr4d = 0;
                heartshospitaltr1 = 0;
                heartshospitaltr2 = 0;
                heartshospitaltr3 = 1;
                heartshospitaltr4 = 0;
                pb1x14.Visible = false;
                pb2x14.Visible = true;

            }

            if (internshospitaltr4 == 1 && internshospitaltrd1 == 1)
            {
                internshospitaltrd1 = 0;
                internshospitaltr1d = 0;
                internshospitaltr2d = 0;
                internshospitaltr3d = 1;
                internshospitaltr4d = 0;
                internshospitaltr1 = 0;
                internshospitaltr2 = 0;
                internshospitaltr3 = 1;
                internshospitaltr4 = 0;
                pb1x15.Visible = false;
                pb2x15.Visible = true;



            }
            if (nationalhealthhospitaltr4 == 1 && nationalhealthhospitaltrd1 == 1)
            {
                nationalhealthhospitaltrd1 = 0;
                nationalhealthhospitaltr1d = 0;
                nationalhealthhospitaltr2d = 0;
                nationalhealthhospitaltr3d = 1;
                nationalhealthhospitaltr4d = 0;
                nationalhealthhospitaltr1 = 0;
                nationalhealthhospitaltr2 = 0;
                nationalhealthhospitaltr3 = 1;
                nationalhealthhospitaltr4 = 0;
                pb1x16.Visible = false;
                pb2x16.Visible = true;
            }
            if (veteranshospitaltr4 == 1 && veteranshospitaltrd1 == 1)
            {
                veteranshospitaltrd1 = 0;
                veteranshospitaltr1d = 0;
                veteranshospitaltr2d = 0;
                veteranshospitaltr3d = 1;
                veteranshospitaltr4d = 0;
                veteranshospitaltr1 = 0;
                veteranshospitaltr2 = 0;
                veteranshospitaltr3 = 1;
                veteranshospitaltr4 = 0;
                pb1x17.Visible = false;
                pb2x17.Visible = true;
            }

            if (pearlmalltr4 == 1 && pearlmalltr1d == 1)
            {
                pearlmalltrd1 = 0;
                pearlmalltr1d = 0;
                pearlmalltr2d = 0;
                pearlmalltr3d = 1;
                pearlmalltr4d = 0;
                pearlmalltr1 = 0;
                pearlmalltr2 = 0;
                pearlmalltr3 = 1;
                pearlmalltr4 = 0;
                pb1x18.Visible = false;
                pb2x18.Visible = true;
            }
            if (megamalltr4 == 1 && megamalltrd1 == 1)
            {
                megamalltrd1 = 0;
                megamalltr1d = 0;
                megamalltr2d = 0;
                megamalltr3d = 1;
                megamalltr4d = 0;
                megamalltr1 = 0;
                megamalltr2 = 0;
                megamalltr3 = 1;
                megamalltr4 = 0;
                pb1x19.Visible = false;
                pb2x19.Visible = true;
            }
            if (articmalltr4 == 1 && articmalltrd1 == 1)
            {
                articmalltrd1 = 0;
                articmalltr1d = 0;
                articmalltr2d = 0;
                articmalltr3d = 1;
                articmalltr4d = 0;
                articmalltr1 = 0;
                articmalltr2 = 0;
                articmalltr3 = 1;
                articmalltr4 = 0;
                pb1x20.Visible = false;
                pb2x20.Visible = true;
            }

            if (heavenlymalltr4 == 1 && heavenlymalltrd1 == 1)
            {
                heavenlymalltrd1 = 0;
                heavenlymalltr1d = 0;
                heavenlymalltr2d = 0;
                heavenlymalltr3d = 1;
                heavenlymalltr4d = 0;
                heavenlymalltr1 = 0;
                heavenlymalltr2 = 0;
                heavenlymalltr3 = 1;
                heavenlymalltr4 = 0;
                pb1x21.Visible = false;
                pb2x21.Visible = true;
            }
            if (shangrillamalltr4 == 1 && shangrillamalltrd1 == 1)
            {
                shangrillamalltrd1 = 0;
                shangrillamalltr1d = 0;
                shangrillamalltr2d = 0;
                shangrillamalltr3d = 1;
                shangrillamalltr4d = 0;
                shangrillamalltr1 = 0;
                shangrillamalltr2 = 0;
                shangrillamalltr3 = 1;
                shangrillamalltr4 = 0;
                pb1x22.Visible = false;
                pb2x22.Visible = true;
            }

            if (utility4x1tr4 == 1 && utility1x1trd1 == 1)
            {
                utility1x1trd1 = 0;
                utility1x1tr1d = 0;
                utility2x1tr2d = 0;
                utility3x1tr3d = 1;
                utility4x1tr4d = 0;
                utility1x1tr1 = 0;
                utility2x1tr2 = 0;
                utility3x1tr3 = 1;
                utility4x1tr4 = 0;
                pb1x23.Visible = false;
                pb2x23.Visible = true;
            }
            if (utility4x2tr4 == 1 && utility1x2trd1 == 1)
            {
                utility1x2trd1 = 0;
                utility1x2tr1d = 0;
                utility2x2tr2d = 0;
                utility3x2tr3d = 1;
                utility4x2tr4d = 0;
                utility1x2tr1 = 0;
                utility2x2tr2 = 0;
                utility3x2tr3 = 1;
                utility4x2tr4 = 0;

                pb1x24.Visible = false;
                pb2x24.Visible = true;
            }

            if (transportation4x1tr4 == 1 && transportation1x1trd1 == 1)
            {
                transportation1x1trd1 = 0;
                transportation1x1tr1d = 0;
                transportation2x1tr2d = 0;
                transportation3x1tr3d = 1;
                transportation4x1tr4d = 0;
                transportation1x1tr1 = 0;
                transportation2x1tr2 = 0;
                transportation3x1tr3 = 1;
                transportation4x1tr4 = 0;
                pb1x25.Visible = false;
                pb2x25.Visible = true;
            }
            if (transportation4x2tr4 == 1 && transportation1x2trd1 == 1)
            {
                transportation1x2trd1 = 0;
                transportation1x2tr1d = 0;
                transportation2x2tr2d = 0;
                transportation3x2tr3d = 1;
                transportation4x2tr4d = 0;
                transportation1x2tr1 = 0;
                transportation2x2tr2 = 0;
                transportation3x2tr3 = 1;
                transportation4x2tr4 = 0;
                pb1x26.Visible = false;
                pb2x26.Visible = true;
            }
            if (transportation4x3tr4 == 1 && transportation1x3trd1 == 1)
            {
                transportation1x3trd1 = 0;
                transportation1x3tr1d = 0;
                transportation2x3tr2d = 0;
                transportation3x3tr3d = 1;
                transportation4x3tr4d = 0;
                transportation1x3tr1 = 0;
                transportation2x3tr2 = 0;
                transportation3x3tr3 = 1;
                transportation4x3tr4 = 0;
                pb1x27.Visible = false;
                pb2x27.Visible = true;
            }
            if (transportation4x4tr4 == 1 && transportation1x4trd1 == 1)
            {
                transportation1x4trd1 = 0;
                transportation1x4tr1d = 0;
                transportation2x4tr2d = 0;
                transportation3x4tr3d = 1;
                transportation4x4tr4d = 0;
                transportation1x4tr1 = 0;
                transportation2x4tr2 = 0;
                transportation3x4tr3 = 1;
                transportation4x4tr4 = 0;
                pb1x28.Visible = false;
                pb2x28.Visible = true;
            }
        }
        void p1traded1()
        {
            //p1trad to p2
            if (easternschooltr1 == 1 && easternschooltrd2 == 1)
            {
                easternschooltrd2 = 0;
                easternschooltr1d = 0;
                easternschooltr2d = 1;
                easternschooltr3d = 0;
                easternschooltr4d = 0;
                easternschooltr1 = 0;
                easternschooltr2 = 1;
                easternschooltr3 = 0;
                easternschooltr4 = 0;
                pb1x1.Visible = true;
                pb2x1.Visible = false;


            }
            if (westernschooltr1 == 1 && westernschooltrd2 == 1)
            {
                westernschooltrd2 = 0;
                westernschooltr1d = 0;
                westernschooltr2d = 1;
                westernschooltr3d = 0;
                westernschooltr4d = 0;
                westernschooltr1 = 0;
                westernschooltr2 = 1;
                westernschooltr3 = 0;
                westernschooltr4 = 0;
                pb1x2.Visible = true;
                pb2x2.Visible = false;

            }

            if (visayashighschooltr1 == 1 && visayashighschooltrd2 == 1)
            {
                visayashighschooltrd2 = 0;
                visayashighschooltr1d = 0;
                visayashighschooltr2d = 1;
                visayashighschooltr3d = 0;
                visayashighschooltr4d = 0;
                visayashighschooltr1 = 0;
                visayashighschooltr2 = 1;
                visayashighschooltr3 = 0;
                visayashighschooltr4 = 0;
                pb1x3.Visible = true;
                pb2x3.Visible = false;
            }
            if (southernschooltr1 == 1 && southernschooltrd2 == 1)
            {
                southernschooltrd2 = 0;
                southernschooltr1d = 0;
                southernschooltr2d = 1;
                southernschooltr3d = 0;
                southernschooltr4d = 0;
                southernschooltr1 = 0;
                southernschooltr2 = 1;
                southernschooltr3 = 0;
                southernschooltr4 = 0;
                pb1x4.Visible = true;
                pb2x4.Visible = false;
            }
            if (nationsschooltr1 == 1 && nationsschooltrd2 == 1)
            {
                nationsschooltrd2 = 0;
                nationsschooltr1d = 0;
                nationsschooltr2d = 1;
                nationsschooltr3d = 0;
                nationsschooltr4d = 0;
                nationsschooltr1 = 0;
                nationsschooltr2 = 1;
                nationsschooltr3 = 0;
                nationsschooltr4 = 0;
                pb1x5.Visible = true;
                pb2x5.Visible = false;
            }

            if (westmarkettr1 == 1 && westernschooltrd2 == 1)
            {
                westmarkettrd2 = 0;
                westmarkettr1d = 0;
                westmarkettr2d = 1;
                westmarkettr3d = 0;
                westmarkettr4d = 0;
                westmarkettr1 = 0;
                westmarkettr2 = 1;
                westmarkettr3 = 0;
                westmarkettr4 = 0;
                pb1x6.Visible = true;
                pb2x6.Visible = false;

            }
            if (nightmarkettr1 == 1 && nightmarkettrd2 == 1)
            {
                nightmarkettrd2 = 0;
                nightmarkettr1d = 0;
                nightmarkettr2d = 1;
                nightmarkettr3d = 0;
                nightmarkettr4d = 0;
                nightmarkettr1 = 0;
                nightmarkettr2 = 1;
                nightmarkettr3 = 0;
                nightmarkettr4 = 0;
                pb1x7.Visible = true;
                pb2x7.Visible = false;
            }
            if (daymarkettr1 == 1 && daymarkettrd2 == 1)
            {
                daymarkettrd2 = 0;
                daymarkettr1d = 0;
                daymarkettr2d = 1;
                daymarkettr3d = 0;
                daymarkettr4d = 0;
                daymarkettr1 = 0;
                daymarkettr2 = 1;
                daymarkettr3 = 0;
                daymarkettr4 = 0;
                pb1x8.Visible = true;
                pb2x8.Visible = false;
            }

            if (starmarkettr1 == 1 && starmarkettrd2 == 1)
            {
                starmarkettrd2 = 0;
                starmarkettr1d = 0;
                starmarkettr2d = 1;
                starmarkettr3d = 0;
                starmarkettr4d = 0;
                starmarkettr1 = 0;
                starmarkettr2 = 1;
                starmarkettr3 = 0;
                starmarkettr4 = 0;
                pb1x9.Visible = true;
                pb2x9.Visible = false;
            }
            if (moonmarkettr1 == 1 && moonmarkettrd2 == 1)
            {
                moonmarkettrd2 = 0;
                moonmarkettr1d = 0;
                moonmarkettr2d = 1;
                moonmarkettr3d = 0;
                moonmarkettr4d = 0;
                moonmarkettr1 = 0;
                moonmarkettr2 = 1;
                moonmarkettr3 = 0;
                moonmarkettr4 = 0;
                pb1x10.Visible = true;
                pb2x10.Visible = false;
            }
            if (megamarkettr1 == 1 && megamarkettrd2 == 1)
            {
                megamarkettrd2 = 0;
                megamarkettr1d = 0;
                megamarkettr2d = 1;
                megamarkettr3d = 0;
                megamarkettr4d = 0;
                megamarkettr1 = 0;
                megamarkettr2 = 1;
                megamarkettr3 = 0;
                megamarkettr4 = 0;
                pb1x11.Visible = true;
                pb2x11.Visible = false;
            }

            if (visayashospitaltr1 == 1 && visayashospitaltrd2 == 1)
            {
                visayashospitaltrd2 = 0;
                visayashospitaltr1d = 0;
                visayashospitaltr2d = 1;
                visayashospitaltr3d = 0;
                visayashospitaltr4d = 0;
                visayashospitaltr1 = 0;
                visayashospitaltr2 = 1;
                visayashospitaltr3 = 0;
                visayashospitaltr4 = 0;
                pb1x12.Visible = true;
                pb2x12.Visible = false;
            }
            if (hobertshospitaltr1 == 1 && hobertshospitaltrd2 == 1)
            {
                hobertshospitaltrd2 = 0;
                hobertshospitaltr1d = 0;
                hobertshospitaltr2d = 1;
                hobertshospitaltr3d = 0;
                hobertshospitaltr4d = 0;
                hobertshospitaltr1 = 0;
                hobertshospitaltr2 = 1;
                hobertshospitaltr1 = 0;
                hobertshospitaltr2 = 0;
                pb1x13.Visible = true;
                pb2x13.Visible = false;
            }
            if (heartshospitaltr1 == 1 && heartshospitaltrd2 == 1)
            {
                heartshospitaltrd2 = 0;
                heartshospitaltr1d = 0;
                heartshospitaltr2d = 1;
                heartshospitaltr3d = 0;
                heartshospitaltr4d = 0;
                heartshospitaltr1 = 0;
                heartshospitaltr2 = 1;
                heartshospitaltr3 = 0;
                heartshospitaltr4 = 0;
                pb1x14.Visible = true;
                pb2x14.Visible = false;

            }

            if (internshospitaltr1 == 1 && internshospitaltrd2 == 1)
            {
                internshospitaltrd2 = 0;
                internshospitaltr1d = 0;
                internshospitaltr2d = 1;
                internshospitaltr3d = 0;
                internshospitaltr4d = 0;
                internshospitaltr1 = 0;
                internshospitaltr2 = 1;
                internshospitaltr3 = 0;
                internshospitaltr4 = 0;
                pb1x15.Visible = true;
                pb2x15.Visible = false;



            }
            if (nationalhealthhospitaltr1 == 1 && nationalhealthhospitaltrd2 == 1)
            {
                nationalhealthhospitaltrd2 = 0;
                nationalhealthhospitaltr1d = 0;
                nationalhealthhospitaltr2d = 1;
                nationalhealthhospitaltr3d = 0;
                nationalhealthhospitaltr4d = 0;
                nationalhealthhospitaltr1 = 0;
                nationalhealthhospitaltr2 = 1;
                nationalhealthhospitaltr3 = 0;
                nationalhealthhospitaltr4 = 0;
                pb1x16.Visible = true;
                pb2x16.Visible = false;
            }
            if (veteranshospitaltr1 == 1 && veteranshospitaltrd2 == 1)
            {
                veteranshospitaltrd2 = 0;
                veteranshospitaltr1d = 0;
                veteranshospitaltr2d = 1;
                veteranshospitaltr3d = 0;
                veteranshospitaltr4d = 0;
                veteranshospitaltr1 = 0;
                veteranshospitaltr2 = 1;
                veteranshospitaltr3 = 0;
                veteranshospitaltr4 = 0;
                pb1x17.Visible = true;
                pb2x17.Visible = false;
            }

            if (pearlmalltr1 == 1 && pearlmalltr2d == 1)
            {
                pearlmalltrd2 = 0;
                pearlmalltr1d = 0;
                pearlmalltr2d = 1;
                pearlmalltr3d = 0;
                pearlmalltr4d = 0;
                pearlmalltr1 = 0;
                pearlmalltr2 = 1;
                pearlmalltr3 = 0;
                pearlmalltr4 = 0;
                pb1x18.Visible = true;
                pb2x18.Visible = false;
            }
            if (megamalltr1 == 1 && megamalltrd2 == 1)
            {
                megamalltrd2 = 0;
                megamalltr1d = 0;
                megamalltr2d = 1;
                megamalltr3d = 0;
                megamalltr4d = 0;
                megamalltr1 = 0;
                megamalltr2 = 1;
                megamalltr3 = 0;
                megamalltr4 = 0;
                pb1x19.Visible = true;
                pb2x19.Visible = false;
            }
            if (articmalltr1 == 1 && articmalltrd2 == 1)
            {
                articmalltrd2 = 0;
                articmalltr1d = 0;
                articmalltr2d = 1;
                articmalltr3d = 0;
                articmalltr4d = 0;
                articmalltr1 = 0;
                articmalltr2 = 1;
                articmalltr3 = 0;
                articmalltr4 = 0;
                pb1x20.Visible = true;
                pb2x20.Visible = false;
            }

            if (heavenlymalltr1 == 1 && heavenlymalltrd2 == 1)
            {
                heavenlymalltrd2 = 0;
                heavenlymalltr1d = 0;
                heavenlymalltr2d = 1;
                heavenlymalltr3d = 0;
                heavenlymalltr4d = 0;
                heavenlymalltr1 = 0;
                heavenlymalltr2 = 1;
                heavenlymalltr3 = 0;
                heavenlymalltr4 = 0;
                pb1x21.Visible = true;
                pb2x21.Visible = false;
            }
            if (shangrillamalltr1 == 1 && shangrillamalltrd2 == 1)
            {
                shangrillamalltrd2 = 0;
                shangrillamalltr1d = 0;
                shangrillamalltr2d = 1;
                shangrillamalltr3d = 0;
                shangrillamalltr4d = 0;
                shangrillamalltr1 = 0;
                shangrillamalltr2 = 1;
                shangrillamalltr3 = 0;
                shangrillamalltr4 = 0;
                pb1x22.Visible = true;
                pb2x22.Visible = false;
            }

            if (utility1x1tr1 == 1 && utility2x1trd2 == 1)
            {
                utility2x1trd2 = 0;
                utility1x1tr1d = 0;
                utility2x1tr2d = 1;
                utility3x1tr3d = 0;
                utility4x1tr4d = 0;
                utility1x1tr1 = 0;
                utility2x1tr2 = 1;
                utility3x1tr3 = 0;
                utility4x1tr4 = 0;
                pb1x23.Visible = true;
                pb2x23.Visible = false;
            }
            if (utility1x2tr1 == 1 && utility2x2trd2 == 1)
            {
                utility2x2trd2 = 0;
                utility1x2tr1d = 0;
                utility2x2tr2d = 1;
                utility3x2tr3d = 0;
                utility4x2tr4d = 0;
                utility1x2tr1 = 0;
                utility2x2tr2 = 1;
                utility3x2tr3 = 0;
                utility4x2tr4 = 0;
                pb1x24.Visible = true;
                pb2x24.Visible = false;
            }

            if (transportation1x1tr1 == 1 && transportation2x1trd2 == 1)
            {
                transportation2x1trd2 = 0;
                transportation1x1tr1d = 0;
                transportation2x1tr2d = 1;
                transportation3x1tr3d = 0;
                transportation4x1tr4d = 0;
                transportation1x1tr1 = 0;
                transportation2x1tr2 = 1;
                transportation3x1tr3 = 0;
                transportation4x1tr4 = 0;
                pb1x25.Visible = true;
                pb2x25.Visible = false;
            }
            if (transportation1x2tr1 == 1 && transportation2x2trd2 == 1)
            {
                transportation2x2trd2 = 0;
                transportation1x2tr1d = 0;
                transportation2x2tr2d = 1;
                transportation3x2tr3d = 0;
                transportation4x2tr4d = 0;
                transportation1x2tr1 = 0;
                transportation2x2tr2 = 1;
                transportation3x2tr3 = 0;
                transportation4x2tr4 = 0;
                pb1x26.Visible = true;
                pb2x26.Visible = false;
            }
            if (transportation1x3tr1 == 1 && transportation2x3trd2 == 1)
            {
                transportation2x3trd2 = 0;
                transportation1x3tr1d = 0;
                transportation2x3tr2d = 1;
                transportation3x3tr3d = 0;
                transportation4x3tr4d = 0;
                transportation1x3tr1 = 0;
                transportation2x3tr2 = 1;
                transportation3x3tr3 = 0;
                transportation4x3tr4 = 0;
                pb1x27.Visible = true;
                pb2x27.Visible = false;
            }
            if (transportation1x4tr1 == 1 && transportation2x4trd2 == 1)
            {
                transportation2x4trd2 = 0;
                transportation1x4tr1d = 0;
                transportation2x4tr2d = 1;
                transportation3x4tr3d = 0;
                transportation4x4tr4d = 0;
                transportation1x4tr1 = 0;
                transportation2x4tr2 = 1;
                transportation3x4tr3 = 0;
                transportation4x4tr4 = 0;
                pb1x28.Visible = true;
                pb2x28.Visible = false;
            }



        }
        void p1traded1_3()
        {
            //p1 to p3 
            if (easternschooltr1 == 1 && easternschooltrd2 == 1)
            {
                easternschooltrd2 = 0;
                easternschooltr1d = 0;
                easternschooltr2d = 0;
                easternschooltr3d = 1;
                easternschooltr4d = 0;
                easternschooltr1 = 0;
                easternschooltr2 = 0;
                easternschooltr3 = 1;
                easternschooltr4 = 0;
                pb1x1.Visible = true;
                pb2x1.Visible = false;


            }
            if (westernschooltr1 == 1 && westernschooltrd2 == 1)
            {
                westernschooltrd2 = 0;
                westernschooltr1d = 0;
                westernschooltr2d = 0;
                westernschooltr3d = 1;
                westernschooltr4d = 0;
                westernschooltr1 = 0;
                westernschooltr2 = 0;
                westernschooltr3 = 1;
                westernschooltr4 = 0;
                pb1x2.Visible = true;
                pb2x2.Visible = false;

            }

            if (visayashighschooltr1 == 1 && visayashighschooltrd2 == 1)
            {
                visayashighschooltrd2 = 0;
                visayashighschooltr1d = 0;
                visayashighschooltr2d = 0;
                visayashighschooltr3d = 1;
                visayashighschooltr4d = 0;
                visayashighschooltr1 = 0;
                visayashighschooltr2 = 0;
                visayashighschooltr3 = 1;
                visayashighschooltr4 = 0;
                pb1x3.Visible = true;
                pb2x3.Visible = false;
            }
            if (southernschooltr1 == 1 && southernschooltrd2 == 1)
            {
                southernschooltrd2 = 0;
                southernschooltr1d = 0;
                southernschooltr2d = 0;
                southernschooltr3d = 1;
                southernschooltr4d = 0;
                southernschooltr1 = 0;
                southernschooltr2 = 0;
                southernschooltr3 = 1;
                southernschooltr4 = 0;
                pb1x4.Visible = true;
                pb2x4.Visible = false;
            }
            if (nationsschooltr1 == 1 && nationsschooltrd2 == 1)
            {
                nationsschooltrd2 = 0;
                nationsschooltr1d = 0;
                nationsschooltr2d = 0;
                nationsschooltr3d = 1;
                nationsschooltr4d = 0;
                nationsschooltr1 = 0;
                nationsschooltr2 = 0;
                nationsschooltr3 = 1;
                nationsschooltr4 = 0;
                pb1x5.Visible = true;
                pb2x5.Visible = false;
            }

            if (westmarkettr1 == 1 && westernschooltrd2 == 1)
            {
                westmarkettrd2 = 0;
                westmarkettr1d = 0;
                westmarkettr2d = 0;
                westmarkettr3d = 1;
                westmarkettr4d = 0;
                westmarkettr1 = 0;
                westmarkettr2 = 0;
                westmarkettr3 = 1;
                westmarkettr4 = 0;
                pb1x6.Visible = true;
                pb2x6.Visible = false;

            }
            if (nightmarkettr1 == 1 && nightmarkettrd2 == 1)
            {
                nightmarkettrd2 = 0;
                nightmarkettr1d = 0;
                nightmarkettr2d = 0;
                nightmarkettr3d = 1;
                nightmarkettr4d = 0;
                nightmarkettr1 = 0;
                nightmarkettr2 = 0;
                nightmarkettr3 = 1;
                nightmarkettr4 = 0;
                pb1x7.Visible = true;
                pb2x7.Visible = false;
            }
            if (daymarkettr1 == 1 && daymarkettrd2 == 1)
            {
                daymarkettrd2 = 0;
                daymarkettr1d = 0;
                daymarkettr2d = 0;
                daymarkettr3d = 1;
                daymarkettr4d = 0;
                daymarkettr1 = 0;
                daymarkettr2 = 0;
                daymarkettr3 = 1;
                daymarkettr4 = 0;
                pb1x8.Visible = true;
                pb2x8.Visible = false;
            }

            if (starmarkettr1 == 1 && starmarkettrd2 == 1)
            {
                starmarkettrd2 = 0;
                starmarkettr1d = 0;
                starmarkettr2d = 0;
                starmarkettr3d = 1;
                starmarkettr4d = 0;
                starmarkettr1 = 0;
                starmarkettr2 = 0;
                starmarkettr3 = 1;
                starmarkettr4 = 0;
                pb1x9.Visible = true;
                pb2x9.Visible = false;
            }
            if (moonmarkettr1 == 1 && moonmarkettrd2 == 1)
            {
                moonmarkettrd2 = 0;
                moonmarkettr1d = 0;
                moonmarkettr2d = 0;
                moonmarkettr3d = 1;
                moonmarkettr4d = 0;
                moonmarkettr1 = 0;
                moonmarkettr2 = 0;
                moonmarkettr3 = 1;
                moonmarkettr4 = 0;
                pb1x10.Visible = true;
                pb2x10.Visible = false;
            }
            if (megamarkettr1 == 1 && megamarkettrd2 == 1)
            {
                megamarkettrd2 = 0;
                megamarkettrd1 = 0;
                megamarkettrd2 = 0;
                megamarkettr3d = 1;
                megamarkettr4d = 0;
                megamarkettr1 = 0;
                megamarkettr2 = 0;
                megamarkettr3 = 1;
                megamarkettr4 = 0;
                pb1x11.Visible = true;
                pb2x11.Visible = false;
            }

            if (visayashospitaltr1 == 1 && visayashospitaltrd2 == 1)
            {
                visayashospitaltrd2 = 0;
                visayashospitaltr1d = 0;
                visayashospitaltr2d = 0;
                visayashospitaltr3d = 1;
                visayashospitaltr4d = 0;
                visayashospitaltr1 = 0;
                visayashospitaltr2 = 0;
                visayashospitaltr3 = 1;
                visayashospitaltr4 = 0;
                pb1x12.Visible = true;
                pb2x12.Visible = false;
            }
            if (hobertshospitaltr1 == 1 && hobertshospitaltrd2 == 1)
            {
                hobertshospitaltrd2 = 0;
                hobertshospitaltr1d = 0;
                hobertshospitaltr2d = 0;
                hobertshospitaltr3d = 1;
                hobertshospitaltr4d = 0;
                hobertshospitaltr1 = 0;
                hobertshospitaltr2 = 0;
                hobertshospitaltr3 = 1;
                hobertshospitaltr4 = 0;
                pb1x13.Visible = true;
                pb2x13.Visible = false;
            }
            if (heartshospitaltr1 == 1 && heartshospitaltrd2 == 1)
            {
                heartshospitaltrd2 = 0;
                heartshospitaltr1d = 0;
                heartshospitaltr2d = 0;
                heartshospitaltr3d = 1;
                heartshospitaltr4d = 0;
                heartshospitaltr1 = 0;
                heartshospitaltr2 = 0;
                heartshospitaltr3 = 1;
                heartshospitaltr4 = 0;
                pb1x14.Visible = true;
                pb2x14.Visible = false;

            }

            if (internshospitaltr1 == 1 && internshospitaltrd2 == 1)
            {
                internshospitaltrd2 = 0;
                internshospitaltr1d = 0;
                internshospitaltr2d = 0;
                internshospitaltr3d = 1;
                internshospitaltr4d = 0;
                internshospitaltr1 = 0;
                internshospitaltr2 = 0;
                internshospitaltr3 = 1;
                internshospitaltr4 = 0;
                pb1x15.Visible = true;
                pb2x15.Visible = false;



            }
            if (nationalhealthhospitaltr1 == 1 && nationalhealthhospitaltrd2 == 1)
            {
                nationalhealthhospitaltrd2 = 0;
                nationalhealthhospitaltr1d = 0;
                nationalhealthhospitaltr2d = 0;
                nationalhealthhospitaltr3d = 1;
                nationalhealthhospitaltr4d = 0;
                nationalhealthhospitaltr1 = 0;
                nationalhealthhospitaltr2 = 0;
                nationalhealthhospitaltr3 = 1;
                nationalhealthhospitaltr4 = 0;
                pb1x16.Visible = true;
                pb2x16.Visible = false;
            }
            if (veteranshospitaltr1 == 1 && veteranshospitaltrd2 == 1)
            {
                veteranshospitaltrd2 = 0;
                veteranshospitaltr1d = 0;
                veteranshospitaltr2d = 0;
                veteranshospitaltr3d = 1;
                veteranshospitaltr4d = 0;
                veteranshospitaltr1 = 0;
                veteranshospitaltr2 = 0;
                veteranshospitaltr3 = 1;
                veteranshospitaltr4 = 0;
                pb1x17.Visible = true;
                pb2x17.Visible = false;
            }

            if (pearlmalltr1 == 1 && pearlmalltr2d == 1)
            {
                pearlmalltrd2 = 0;
                pearlmalltr1d = 0;
                pearlmalltr2d = 0;
                pearlmalltr3d = 1;
                pearlmalltr4d = 0;
                pearlmalltr1 = 0;
                pearlmalltr2 = 0;
                pearlmalltr3 = 1;
                pearlmalltr4 = 0;
                pb1x18.Visible = true;
                pb2x18.Visible = false;
            }
            if (megamalltr1 == 1 && megamalltrd2 == 1)
            {
                megamalltrd2 = 0;
                megamalltr1d = 0;
                megamalltr2d = 0;
                megamalltr3d = 1;
                megamalltr4d = 0;
                megamalltr1 = 0;
                megamalltr2 = 0;
                megamalltr3 = 1;
                megamalltr4 = 0;
                pb1x19.Visible = true;
                pb2x19.Visible = false;
            }
            if (articmalltr1 == 1 && articmalltrd2 == 1)
            {
                articmalltrd2 = 0;
                articmalltr1d = 0;
                articmalltr2d = 0;
                articmalltr3d = 1;
                articmalltr4d = 0;
                articmalltr1 = 0;
                articmalltr2 = 0;
                articmalltr3 = 1;
                articmalltr4 = 0;
                pb1x20.Visible = true;
                pb2x20.Visible = false;
            }

            if (heavenlymalltr1 == 1 && heavenlymalltrd2 == 1)
            {
                heavenlymalltrd2 = 0;
                heavenlymalltr1d = 0;
                heavenlymalltr2d = 0;
                heavenlymalltr3d = 1;
                heavenlymalltr4d = 0;
                heavenlymalltr1 = 0;
                heavenlymalltr2 = 0;
                heavenlymalltr3 = 1;
                heavenlymalltr4 = 0;
                pb1x21.Visible = true;
                pb2x21.Visible = false;
            }
            if (shangrillamalltr1 == 1 && shangrillamalltrd2 == 1)
            {
                shangrillamalltrd2 = 0;
                shangrillamalltr1d = 0;
                shangrillamalltr2d = 0;
                shangrillamalltr3d = 1;
                shangrillamalltr4d = 0;
                shangrillamalltr1 = 0;
                shangrillamalltr2 = 0;
                shangrillamalltr3 = 1;
                shangrillamalltr4 = 0;
                pb1x22.Visible = true;
                pb2x22.Visible = false;
            }

            if (utility1x1tr1 == 1 && utility2x1trd2 == 1)
            {
                utility2x1trd2 = 0;
                utility1x1tr1d = 0;
                utility2x1tr2d = 0;
                utility3x1tr3d = 1;
                utility4x1tr4d = 0;
                utility1x1tr1 = 0;
                utility2x1tr2 = 0;
                utility3x1tr3 = 1;
                utility4x1tr4 = 0;
                pb1x23.Visible = true;
                pb2x23.Visible = false;
            }
            if (utility1x2tr1 == 1 && utility2x2trd2 == 1)
            {
                utility2x2trd2 = 0;
                utility1x2tr1d = 0;
                utility2x2tr2d = 0;
                utility3x2tr3d = 1;
                utility4x2tr4d = 0;
                utility1x2tr1 = 0;
                utility2x2tr2 = 0;
                utility3x2tr3 = 1;
                utility4x2tr4 = 0;

                pb1x24.Visible = true;
                pb2x24.Visible = false;
            }

            if (transportation1x1tr1 == 1 && transportation2x1trd2 == 1)
            {
                transportation2x1trd2 = 0;
                transportation1x1tr1d = 0;
                transportation2x1tr2d = 0;
                transportation3x1tr3d = 1;
                transportation4x1tr4d = 0;
                transportation1x1tr1 = 0;
                transportation2x1tr2 = 0;
                transportation3x1tr3 = 1;
                transportation4x1tr4 = 0;
                pb1x25.Visible = true;
                pb2x25.Visible = false;
            }
            if (transportation1x2tr1 == 1 && transportation2x2trd2 == 1)
            {
                transportation2x2trd2 = 0;
                transportation1x2tr1d = 0;
                transportation2x2tr2d = 0;
                transportation3x2tr3d = 1;
                transportation4x2tr4d = 0;
                transportation1x2tr1 = 0;
                transportation2x2tr2 = 0;
                transportation3x2tr3 = 1;
                transportation4x2tr4 = 0;
                pb1x26.Visible = true;
                pb2x26.Visible = false;
            }
            if (transportation1x3tr1 == 1 && transportation2x3trd2 == 1)
            {
                transportation2x3trd2 = 0;
                transportation1x3tr1d = 0;
                transportation2x3tr2d = 0;
                transportation3x3tr3d = 1;
                transportation4x3tr4d = 0;
                transportation1x3tr1 = 0;
                transportation2x3tr2 = 0;
                transportation3x3tr3 = 1;
                transportation4x3tr4 = 0;
                pb1x27.Visible = true;
                pb2x27.Visible = false;
            }
            if (transportation1x4tr1 == 1 && transportation2x4trd2 == 1)
            {
                transportation2x4trd2 = 0;
                transportation1x4tr1d = 0;
                transportation2x4tr2d = 0;
                transportation3x4tr3d = 1;
                transportation4x4tr4d = 0;
                transportation1x4tr1 = 0;
                transportation2x4tr2 = 0;
                transportation3x4tr3 = 1;
                transportation4x4tr4 = 0;
                pb1x28.Visible = true;
                pb2x28.Visible = false;
            }
        }
        void p1traded1_4()
        {
            //p1 to p4
            if (easternschooltr1 == 1 && easternschooltrd2 == 1)
            {
                easternschooltrd2 = 0;
                easternschooltr1d = 0;
                easternschooltr2d = 0;
                easternschooltr3d = 0;
                easternschooltr4d = 1;
                easternschooltr1 = 0;
                easternschooltr2 = 0;
                easternschooltr3 = 0;
                easternschooltr4 = 1;
                pb1x1.Visible = true;
                pb2x1.Visible = false;


            }
            if (westernschooltr1 == 1 && westernschooltrd2 == 1)
            {
                westernschooltrd2 = 0;
                westernschooltr1d = 0;
                westernschooltr2d = 0;
                westernschooltr3d = 0;
                westernschooltr4d = 1;
                westernschooltr1 = 0;
                westernschooltr2 = 0;
                westernschooltr3 = 0;
                westernschooltr4 = 1;
                pb1x2.Visible = true;
                pb2x2.Visible = false;

            }

            if (visayashighschooltr1 == 1 && visayashighschooltrd2 == 1)
            {
                visayashighschooltrd2 = 0;
                visayashighschooltr1d = 0;
                visayashighschooltr2d = 0;
                visayashighschooltr3d = 0;
                visayashighschooltr4d = 1;
                visayashighschooltr1 = 0;
                visayashighschooltr2 = 0;
                visayashighschooltr3 = 0;
                visayashighschooltr4 = 1;
                pb1x3.Visible = true;
                pb2x3.Visible = false;
            }
            if (southernschooltr1 == 1 && southernschooltrd2 == 1)
            {
                southernschooltrd2 = 0;
                southernschooltr1d = 0;
                southernschooltr2d = 0;
                southernschooltr3d = 0;
                southernschooltr4d = 1;
                southernschooltr1 = 0;
                southernschooltr2 = 0;
                southernschooltr3 = 0;
                southernschooltr4 = 1;
                pb1x4.Visible = true;
                pb2x4.Visible = false;
            }
            if (nationsschooltr1 == 1 && nationsschooltrd2 == 1)
            {
                nationsschooltrd2 = 0;
                nationsschooltr1d = 0;
                nationsschooltr2d = 0;
                nationsschooltr3d = 0;
                nationsschooltr4d = 1;
                nationsschooltr1 = 0;
                nationsschooltr2 = 0;
                nationsschooltr3 = 0;
                nationsschooltr4 = 1;
                pb1x5.Visible = true;
                pb2x5.Visible = false;
            }

            if (westmarkettr1 == 1 && westernschooltrd2 == 1)
            {
                westmarkettrd2 = 0;
                westmarkettr1d = 0;
                westmarkettr2d = 0;
                westmarkettr3d = 0;
                westmarkettr4d = 1;
                westmarkettr1 = 0;
                westmarkettr2 = 0;
                westmarkettr3 = 0;
                westmarkettr4 = 1;
                pb1x6.Visible = true;
                pb2x6.Visible = false;

            }
            if (nightmarkettr1 == 1 && nightmarkettrd2 == 1)
            {
                nightmarkettrd2 = 0;
                nightmarkettr1d = 0;
                nightmarkettr2d = 0;
                nightmarkettr3d = 0;
                nightmarkettr4d = 1;
                nightmarkettr1 = 0;
                nightmarkettr2 = 0;
                nightmarkettr3 = 0;
                nightmarkettr4 = 1;
                pb1x7.Visible = true;
                pb2x7.Visible = false;
            }
            if (daymarkettr1 == 1 && daymarkettrd2 == 1)
            {
                daymarkettrd2 = 0;
                daymarkettr1d = 0;
                daymarkettr2d = 0;
                daymarkettr3d = 0;
                daymarkettr4d = 1;
                daymarkettr1 = 0;
                daymarkettr2 = 0;
                daymarkettr3 = 0;
                daymarkettr4 = 1;
                pb1x8.Visible = true;
                pb2x8.Visible = false;
            }

            if (starmarkettr1 == 1 && starmarkettrd2 == 1)
            {
                starmarkettrd2 = 0;
                starmarkettr1d = 0;
                starmarkettr2d = 0;
                starmarkettr3d = 0;
                starmarkettr4d = 1;
                starmarkettr1 = 0;
                starmarkettr2 = 0;
                starmarkettr3 = 0;
                starmarkettr4 = 1;
                pb1x9.Visible = true;
                pb2x9.Visible = false;
            }
            if (moonmarkettr1 == 1 && moonmarkettrd2 == 1)
            {
                moonmarkettrd2 = 0;
                moonmarkettr1d = 0;
                moonmarkettr2d = 0;
                moonmarkettr3d = 0;
                moonmarkettr4d = 1;
                moonmarkettr1 = 0;
                moonmarkettr2 = 0;
                moonmarkettr3 = 0;
                moonmarkettr4 = 1;
                pb1x10.Visible = true;
                pb2x10.Visible = false;
            }
            if (megamarkettr1 == 1 && megamarkettrd2 == 1)
            {
                megamarkettrd2 = 0;
                megamarkettr1d = 0;
                megamarkettr2d = 0;
                megamarkettr3d = 0;
                megamarkettr4d = 1;
                megamarkettr1 = 0;
                megamarkettr2 = 0;
                megamarkettr3 = 0;
                megamarkettr4 = 1;
                pb1x11.Visible = true;
                pb2x11.Visible = false;
            }

            if (visayashospitaltr1 == 1 && visayashospitaltrd2 == 1)
            {
                visayashospitaltrd2 = 0;
                visayashospitaltr1d = 0;
                visayashospitaltr2d = 0;
                visayashospitaltr3d = 0;
                visayashospitaltr4d = 1;
                visayashospitaltr1 = 0;
                visayashospitaltr2 = 0;
                visayashospitaltr3 = 0;
                visayashospitaltr4 = 1;
                pb1x12.Visible = true;
                pb2x12.Visible = false;
            }
            if (hobertshospitaltr1 == 1 && hobertshospitaltrd2 == 1)
            {
                hobertshospitaltrd2 = 0;
                hobertshospitaltr1d = 0;
                hobertshospitaltr2d = 0;
                hobertshospitaltr3d = 0;
                hobertshospitaltr4d = 1;
                hobertshospitaltr1 = 0;
                hobertshospitaltr2 = 0;
                hobertshospitaltr3 = 0;
                hobertshospitaltr4 = 1;
                pb1x13.Visible = true;
                pb2x13.Visible = false;
            }
            if (heartshospitaltr1 == 1 && heartshospitaltrd2 == 1)
            {
                heartshospitaltrd2 = 0;
                heartshospitaltr1d = 0;
                heartshospitaltr2d = 0;
                heartshospitaltr3d = 0;
                heartshospitaltr4d = 1;
                heartshospitaltr1 = 0;
                heartshospitaltr2 = 0;
                heartshospitaltr3 = 0;
                heartshospitaltr4 = 1;
                pb1x14.Visible = true;
                pb2x14.Visible = false;

            }

            if (internshospitaltr1 == 1 && internshospitaltrd2 == 1)
            {
                internshospitaltrd2 = 0;
                internshospitaltr1d = 0;
                internshospitaltr2d = 0;
                internshospitaltr3d = 0;
                internshospitaltr4d = 1;
                internshospitaltr1 = 0;
                internshospitaltr2 = 0;
                internshospitaltr3 = 0;
                internshospitaltr4 = 1;
                pb1x15.Visible = true;
                pb2x15.Visible = false;



            }
            if (nationalhealthhospitaltr1 == 1 && nationalhealthhospitaltrd2 == 1)
            {
                nationalhealthhospitaltrd2 = 0;
                nationalhealthhospitaltr1d = 0;
                nationalhealthhospitaltr2d = 0;
                nationalhealthhospitaltr3d = 0;
                nationalhealthhospitaltr4d = 1;
                nationalhealthhospitaltr1 = 0;
                nationalhealthhospitaltr2 = 0;
                nationalhealthhospitaltr3 = 0;
                nationalhealthhospitaltr4 = 1;
                pb1x16.Visible = true;
                pb2x16.Visible = false;
            }
            if (veteranshospitaltr1 == 1 && veteranshospitaltrd2 == 1)
            {
                veteranshospitaltrd2 = 0;
                veteranshospitaltr1d = 0;
                veteranshospitaltr2d = 0;
                veteranshospitaltr3d = 0;
                veteranshospitaltr4d = 1;
                veteranshospitaltr1 = 0;
                veteranshospitaltr2 = 0;
                veteranshospitaltr3 = 0;
                veteranshospitaltr4 = 1;
                pb1x17.Visible = true;
                pb2x17.Visible = false;
            }

            if (pearlmalltr1 == 1 && pearlmalltr2d == 1)
            {
                pearlmalltrd2 = 0;
                pearlmalltr1d = 0;
                pearlmalltr2d = 0;
                pearlmalltr3d = 0;
                pearlmalltr4d = 1;
                pearlmalltr1 = 0;
                pearlmalltr2 = 0;
                pearlmalltr3 = 0;
                pearlmalltr4 = 1;
                pb1x18.Visible = true;
                pb2x18.Visible = false;
            }
            if (megamalltr1 == 1 && megamalltrd2 == 1)
            {
                megamalltrd2 = 0;
                megamalltr1d = 0;
                megamalltr2d = 0;
                megamalltr3d = 0;
                megamalltr4d = 1;
                megamalltr1 = 0;
                megamalltr2 = 0;
                megamalltr3 = 0;
                megamalltr4 = 1;
                pb1x19.Visible = true;
                pb2x19.Visible = false;
            }
            if (articmalltr1 == 1 && articmalltrd2 == 1)
            {
                articmalltrd2 = 0;
                articmalltr1d = 0;
                articmalltr2d = 0;
                articmalltr3d = 0;
                articmalltr4d = 1;
                articmalltr1 = 0;
                articmalltr2 = 0;
                articmalltr3 = 0;
                articmalltr4 = 1;
                pb1x20.Visible = true;
                pb2x20.Visible = false;
            }

            if (heavenlymalltr1 == 1 && heavenlymalltrd2 == 1)
            {
                heavenlymalltrd2 = 0;
                heavenlymalltr1d = 0;
                heavenlymalltr2d = 0;
                heavenlymalltr3d = 0;
                heavenlymalltr4d = 1;
                heavenlymalltr1 = 0;
                heavenlymalltr2 = 0;
                heavenlymalltr3 = 0;
                heavenlymalltr4 = 1;
                pb1x21.Visible = true;
                pb2x21.Visible = false;
            }
            if (shangrillamalltr1 == 1 && shangrillamalltrd2 == 1)
            {
                shangrillamalltrd2 = 0;
                shangrillamalltr1d = 0;
                shangrillamalltr2d = 0;
                shangrillamalltr3d = 0;
                shangrillamalltr4d = 1;
                shangrillamalltr1 = 0;
                shangrillamalltr2 = 0;
                shangrillamalltr3 = 0;
                shangrillamalltr4 = 1;
                pb1x22.Visible = true;
                pb2x22.Visible = false;
            }

            if (utility1x1tr1 == 1 && utility2x1trd2 == 1)
            {
                utility2x1trd2 = 0;
                utility1x1tr1d = 0;
                utility2x1tr2d = 0;
                utility3x1tr3d = 0;
                utility4x1tr4d = 1;
                utility1x1tr1 = 0;
                utility2x1tr2 = 0;
                utility3x1tr3 = 0;
                utility4x1tr4 = 1;
                pb1x23.Visible = true;
                pb2x23.Visible = false;
            }
            if (utility1x2tr1 == 1 && utility2x2trd2 == 1)
            {
                utility2x2trd2 = 0;
                utility1x2tr1d = 0;
                utility2x2tr2d = 0;
                utility3x2tr3d = 0;
                utility4x2tr4d = 1;
                utility1x2tr1 = 0;
                utility2x2tr2 = 0;
                utility3x2tr3 = 0;
                utility4x2tr4 = 1;
                pb1x24.Visible = true;
                pb2x24.Visible = false;
            }

            if (transportation1x1tr1 == 1 && transportation2x1trd2 == 1)
            {
                transportation2x1trd2 = 0;
                transportation1x1tr1d = 0;
                transportation2x1tr2d = 0;
                transportation3x1tr3d = 0;
                transportation4x1tr4d = 1;
                transportation1x1tr1 = 0;
                transportation2x1tr2 = 0;
                transportation3x1tr3 = 0;
                transportation4x1tr4 = 1;
                pb1x25.Visible = true;
                pb2x25.Visible = false;
            }
            if (transportation1x2tr1 == 1 && transportation2x2trd2 == 1)
            {
                transportation2x2trd2 = 0;
                transportation1x2tr1d = 0;
                transportation2x2tr2d = 0;
                transportation3x2tr3d = 0;
                transportation4x2tr4d = 1;
                transportation1x2tr1 = 0;
                transportation2x2tr2 = 0;
                transportation3x2tr3 = 0;
                transportation4x2tr4 = 1;
                pb1x26.Visible = true;
                pb2x26.Visible = false;
            }
            if (transportation1x3tr1 == 1 && transportation2x3trd2 == 1)
            {
                transportation2x3trd2 = 0;
                transportation1x3tr1d = 0;
                transportation2x3tr2d = 0;
                transportation3x3tr3d = 0;
                transportation4x3tr4d = 1;
                transportation1x3tr1 = 0;
                transportation2x3tr2 = 0;
                transportation3x3tr3 = 0;
                transportation4x3tr4 = 1;
                pb1x27.Visible = true;
                pb2x27.Visible = false;
            }
            if (transportation1x4tr1 == 1 && transportation2x4trd2 == 1)
            {
                transportation2x4trd2 = 0;
                transportation1x4tr1d = 0;
                transportation2x4tr2d = 0;
                transportation3x4tr3d = 0;
                transportation4x4tr4d = 1;
                transportation1x4tr1 = 0;
                transportation2x4tr2 = 0;
                transportation3x4tr3 = 0;
                transportation4x4tr4 = 1;
                pb1x28.Visible = true;
                pb2x28.Visible = false;
            }

        }
        void p2traded2()
        {
            //p2 to p1
            if (easternschooltr2 == 1 && easternschooltrd2 == 1)
            {
                easternschooltrd2 = 0;
                easternschooltr1d = 1;
                easternschooltr2d = 0;
                easternschooltr3d = 0;
                easternschooltr4d = 0;
                easternschooltr1 = 1;
                easternschooltr2 = 0;
                easternschooltr3 = 0;
                easternschooltr4 = 0;
                pb1x1.Visible = true;
                pb2x1.Visible = false;


            }
            if (westernschooltr2 == 1 && westernschooltrd2 == 1)
            {
                westernschooltrd2 = 0;
                westernschooltr1d = 1;
                westernschooltr2d = 0;
                westernschooltr3d = 0;
                westernschooltr4d = 0;
                westernschooltr1 = 1;
                westernschooltr2 = 0;
                westernschooltr3 = 0;
                westernschooltr4 = 0;
                pb1x2.Visible = true;
                pb2x2.Visible = false;

            }

            if (visayashighschooltr2 == 1 && visayashighschooltrd2 == 1)
            {
                visayashighschooltrd2 = 0;
                visayashighschooltr1d = 1;
                visayashighschooltr2d = 0;
                visayashighschooltr3d = 0;
                visayashighschooltr4d = 0;
                visayashighschooltr1 = 1;
                visayashighschooltr2 = 0;
                visayashighschooltr3 = 0;
                visayashighschooltr4 = 0;
                pb1x3.Visible = true;
                pb2x3.Visible = false;
            }
            if (southernschooltr2 == 1 && southernschooltrd2 == 1)
            {
                southernschooltrd2 = 0;
                southernschooltr1d = 1;
                southernschooltr2d = 0;
                southernschooltr3d = 0;
                southernschooltr4d = 0;
                southernschooltr1 = 1;
                southernschooltr2 = 0;
                southernschooltr3 = 0;
                southernschooltr4 = 0;
                pb1x4.Visible = true;
                pb2x4.Visible = false;
            }
            if (nationsschooltr2 == 1 && nationsschooltrd2 == 1)
            {
                nationsschooltrd2 = 0;
                nationsschooltr1d = 1;
                nationsschooltr2d = 0;
                nationsschooltr3d = 0;
                nationsschooltr4d = 0;
                nationsschooltr1 = 1;
                nationsschooltr2 = 0;
                nationsschooltr3 = 0;
                nationsschooltr4 = 0;
                pb1x5.Visible = true;
                pb2x5.Visible = false;
            }

            if (westmarkettr2 == 1 && westernschooltrd2 == 1)
            {
                westmarkettrd2 = 0;
                westmarkettr1d = 1;
                westmarkettr2d = 0;
                westmarkettr3d = 0;
                westmarkettr4d = 0;
                westmarkettr1 = 1;
                westmarkettr2 = 0;
                westmarkettr3 = 0;
                westmarkettr4 = 0;
                pb1x6.Visible = true;
                pb2x6.Visible = false;

            }
            if (nightmarkettr2 == 1 && nightmarkettrd2 == 1)
            {
                nightmarkettrd2 = 0;
                nightmarkettr1d = 1;
                nightmarkettr2d = 0;
                nightmarkettr3d = 0;
                nightmarkettr4d = 0;
                nightmarkettr1 = 1;
                nightmarkettr2 = 0;
                nightmarkettr3 = 0;
                nightmarkettr4 = 0;
                pb1x7.Visible = true;
                pb2x7.Visible = false;
            }
            if (daymarkettr2 == 1 && daymarkettrd2 == 1)
            {
                daymarkettrd2 = 0;
                daymarkettr1d = 1;
                daymarkettr2d = 0;
                daymarkettr3d = 0;
                daymarkettr4d = 0;
                daymarkettr1 = 1;
                daymarkettr2 = 0;
                daymarkettr3 = 0;
                daymarkettr4 = 0;
                pb1x8.Visible = true;
                pb2x8.Visible = false;
            }

            if (starmarkettr2 == 1 && starmarkettrd2 == 1)
            {
                starmarkettrd2 = 0;
                starmarkettr1d = 1;
                starmarkettr2d = 0;
                starmarkettr3d = 0;
                starmarkettr4d = 0;
                starmarkettr1 = 1;
                starmarkettr2 = 0;
                starmarkettr3 = 0;
                starmarkettr4 = 0;
                pb1x9.Visible = true;
                pb2x9.Visible = false;
            }
            if (moonmarkettr2 == 1 && moonmarkettrd2 == 1)
            {
                moonmarkettrd2 = 0;
                moonmarkettr1d = 1;
                moonmarkettr2d = 0;
                moonmarkettr3d = 0;
                moonmarkettr4d = 0;
                moonmarkettr1 = 1;
                moonmarkettr2 = 0;
                moonmarkettr3 = 0;
                moonmarkettr4 = 0;
                pb1x10.Visible = true;
                pb2x10.Visible = false;
            }
            if (megamarkettr2 == 1 && megamarkettrd2 == 1)
            {
                megamarkettrd2 = 0;
                megamarkettr1d = 1;
                megamarkettr2d = 0;
                megamarkettr3d = 0;
                megamarkettr4d = 0;
                megamarkettr1 = 1;
                megamarkettr2 = 0;
                megamarkettr3 = 0;
                megamarkettr4 = 0;
                pb1x11.Visible = true;
                pb2x11.Visible = false;
            }

            if (visayashospitaltr2 == 1 && visayashospitaltrd2 == 1)
            {
                visayashospitaltrd2 = 0;
                visayashospitaltr1d = 1;
                visayashospitaltr2d = 0;
                visayashospitaltr3d = 0;
                visayashospitaltr4d = 0;
                visayashospitaltr1 = 1;
                visayashospitaltr2 = 0;
                visayashospitaltr3 = 0;
                visayashospitaltr4 = 0;
                pb1x12.Visible = true;
                pb2x12.Visible = false;
            }
            if (hobertshospitaltr2 == 1 && hobertshospitaltrd2 == 1)
            {
                hobertshospitaltrd2 = 0;
                hobertshospitaltr1d = 1;
                hobertshospitaltr2d = 0;
                hobertshospitaltr3d = 0;
                hobertshospitaltr4d = 0;
                hobertshospitaltr1 = 1;
                hobertshospitaltr2 = 0;
                hobertshospitaltr3 = 0;
                hobertshospitaltr4 = 0;
                pb1x13.Visible = true;
                pb2x13.Visible = false;
            }
            if (heartshospitaltr2 == 1 && heartshospitaltrd2 == 1)
            {
                heartshospitaltrd2 = 0;
                heartshospitaltr1d = 1;
                heartshospitaltr2d = 0;
                heartshospitaltr3d = 0;
                heartshospitaltr4d = 0;
                heartshospitaltr1 = 1;
                heartshospitaltr2 = 0;
                heartshospitaltr3 = 0;
                heartshospitaltr4 = 0;
                pb1x14.Visible = true;
                pb2x14.Visible = false;

            }

            if (internshospitaltr2 == 1 && internshospitaltrd2 == 1)
            {
                internshospitaltrd2 = 0;
                internshospitaltr1d = 1;
                internshospitaltr2d = 0;
                internshospitaltr3d = 0;
                internshospitaltr4d = 0;
                internshospitaltr1 = 1;
                internshospitaltr2 = 0;
                internshospitaltr3 = 0;
                internshospitaltr4 = 0;
                pb1x15.Visible = true;
                pb2x15.Visible = false;

            }
            if (nationalhealthhospitaltr2 == 1 && nationalhealthhospitaltrd2 == 1)
            {
                nationalhealthhospitaltrd2 = 0;
                nationalhealthhospitaltr1d = 1;
                nationalhealthhospitaltr2d = 0;
                nationalhealthhospitaltr3d = 0;
                nationalhealthhospitaltr4d = 0;
                nationalhealthhospitaltr1 = 1;
                nationalhealthhospitaltr2 = 0;
                nationalhealthhospitaltr3 = 0;
                nationalhealthhospitaltr4 = 0;
                pb1x16.Visible = true;
                pb2x16.Visible = false;
            }
            if (veteranshospitaltr2 == 1 && veteranshospitaltrd2 == 1)
            {
                veteranshospitaltrd2 = 0;
                veteranshospitaltr1d = 1;
                veteranshospitaltr2d = 0;
                veteranshospitaltr3d = 0;
                veteranshospitaltr4d = 0;
                veteranshospitaltr1 = 1;
                veteranshospitaltr2 = 0;
                veteranshospitaltr3 = 0;
                veteranshospitaltr4 = 0;
                pb1x17.Visible = true;
                pb2x17.Visible = false;
            }

            if (pearlmalltr2 == 1 && pearlmalltrd2 == 1)
            {
                pearlmalltrd2 = 0;
                pearlmalltr1d = 1;
                pearlmalltr2d = 0;
                pearlmalltr3d = 0;
                pearlmalltr4d = 0;
                pearlmalltr1 = 1;
                pearlmalltr2 = 0;
                pearlmalltr3 = 0;
                pearlmalltr4 = 0;
                pb1x18.Visible = true;
                pb2x18.Visible = false;
            }
            if (megamalltr2 == 1 && megamalltrd2 == 1)
            {
                megamalltrd2 = 0;
                megamalltr1d = 1;
                megamalltr2d = 0;
                megamalltr3d = 0;
                megamalltr4d = 0;
                megamalltr1 = 1;
                megamalltr2 = 0;
                megamalltr3 = 0;
                megamalltr4 = 0;
                pb1x19.Visible = true;
                pb2x19.Visible = false;
            }
            if (articmalltr2 == 1 && articmalltrd2 == 1)
            {
                articmalltrd2 = 0;
                articmalltr1d = 1;
                articmalltr2d = 0;
                articmalltr3d = 0;
                articmalltr4d = 0;
                articmalltr1 = 1;
                articmalltr2 = 0;
                articmalltr3 = 0;
                articmalltr4 = 0;
                pb1x20.Visible = true;
                pb2x20.Visible = false;
            }

            if (heavenlymalltr2 == 1 && heavenlymalltrd2 == 1)
            {
                heavenlymalltrd2 = 0;
                heavenlymalltr1d = 1;
                heavenlymalltr2d = 0;
                heavenlymalltr3d = 0;
                heavenlymalltr4d = 0;
                heavenlymalltr1 = 1;
                heavenlymalltr2 = 0;
                heavenlymalltr3 = 0;
                heavenlymalltr4 = 0;
                pb1x21.Visible = true;
                pb2x21.Visible = false;
            }
            if (shangrillamalltr2 == 1 && shangrillamalltrd2 == 1)
            {
                shangrillamalltrd2 = 0;
                shangrillamalltr1d = 1;
                shangrillamalltr2d = 0;
                shangrillamalltr3d = 0;
                shangrillamalltr4d = 0;
                shangrillamalltr1 = 1;
                shangrillamalltr2 = 0;
                shangrillamalltr3 = 0;
                shangrillamalltr4 = 0;
                pb1x22.Visible = true;
                pb2x22.Visible = false;
            }

            if (utility2x1tr2 == 1 && utility2x1trd2 == 1)
            {
                utility2x1trd2 = 0;
                utility1x1tr1d = 1;
                utility2x1tr2d = 0;
                utility3x1tr3d = 0;
                utility4x1tr4d = 0;
                utility1x1tr1 = 1;
                utility2x1tr2 = 0;
                utility3x1tr3 = 0;
                utility4x1tr4 = 0;
                pb1x23.Visible = true;
                pb2x23.Visible = false;
            }
            if (utility2x2tr2 == 1 && utility2x2trd2 == 1)
            {
                utility2x2trd2 = 0;
                utility1x2tr1d = 1;
                utility2x2tr2d = 0;
                utility3x2tr3d = 0;
                utility4x2tr4d = 0;
                utility1x2tr1 = 1;
                utility2x2tr2 = 0;
                utility3x2tr3 = 0;
                utility4x2tr4 = 0;
                pb1x24.Visible = true;
                pb2x24.Visible = false;
            }

            if (transportation2x1tr2 == 1 && transportation2x1trd2 == 1)
            {
                transportation2x1trd2 = 0;
                transportation1x1tr1d = 1;
                transportation2x1tr2d = 0;
                transportation3x1tr3d = 0;
                transportation4x1tr4d = 0;
                transportation1x1tr1 = 1;
                transportation2x1tr2 = 0;
                transportation3x1tr3 = 0;
                transportation4x1tr4 = 0;
                pb1x25.Visible = true;
                pb2x25.Visible = false;
            }
            if (transportation2x2tr2 == 1 && transportation2x2trd2 == 1)
            {
                transportation2x2trd2 = 0;
                transportation1x2tr1d = 1;
                transportation2x2tr2d = 0;
                transportation3x2tr3d = 0;
                transportation4x2tr4d = 0;
                transportation1x2tr1 = 1;
                transportation2x2tr2 = 0;
                transportation3x2tr3 = 0;
                transportation4x2tr4 = 0;
                pb1x26.Visible = true;
                pb2x26.Visible = false;
            }
            if (transportation2x3tr2 == 1 && transportation2x3trd2 == 1)
            {
                transportation2x3trd2 = 0;
                transportation1x3tr1d = 1;
                transportation2x3tr2d = 0;
                transportation3x3tr3d = 0;
                transportation4x3tr4d = 0;
                transportation1x3tr1 = 1;
                transportation2x3tr2 = 0;
                transportation3x3tr3 = 0;
                transportation4x3tr4 = 0;
                pb1x27.Visible = true;
                pb2x27.Visible = false;
            }
            if (transportation2x4tr2 == 1 && transportation2x4trd2 == 1)
            {
                transportation2x4trd2 = 0;
                transportation1x4tr1d = 1;
                transportation2x4tr2d = 0;
                transportation3x4tr3d = 0;
                transportation4x4tr4d = 0;
                transportation1x4tr1 = 1;
                transportation2x4tr2 = 0;
                transportation3x4tr3 = 0;
                transportation4x4tr4 = 0;
                pb1x28.Visible = true;
                pb2x28.Visible = false;
            }


        }
        void p2traded2_3()
        {
            //p2 to p3
            if (easternschooltr2 == 1 && easternschooltrd2 == 1)
            {
                easternschooltrd2 = 0;
                easternschooltr1d = 0;
                easternschooltr2d = 0;
                easternschooltr3d = 1;
                easternschooltr4d = 0;
                easternschooltr1 = 0;
                easternschooltr2 = 0;
                easternschooltr3 = 1;
                easternschooltr4 = 0;
                pb1x1.Visible = true;
                pb2x1.Visible = false;


            }
            if (westernschooltr2 == 1 && westernschooltrd2 == 1)
            {
                westernschooltrd2 = 0;
                westernschooltr1d = 0;
                westernschooltr2d = 0;
                westernschooltr3d = 1;
                westernschooltr4d = 0;
                westernschooltr1 = 0;
                westernschooltr2 = 0;
                westernschooltr3 = 1;
                westernschooltr4 = 0;
                pb1x2.Visible = true;
                pb2x2.Visible = false;

            }

            if (visayashighschooltr2 == 1 && visayashighschooltrd2 == 1)
            {
                visayashighschooltrd2 = 0;
                visayashighschooltr1d = 0;
                visayashighschooltr2d = 0;
                visayashighschooltr3d = 1;
                visayashighschooltr4d = 0;
                visayashighschooltr1 = 0;
                visayashighschooltr2 = 0;
                visayashighschooltr3 = 1;
                visayashighschooltr4 = 0;
                pb1x3.Visible = true;
                pb2x3.Visible = false;
            }
            if (southernschooltr2 == 1 && southernschooltrd2 == 1)
            {
                southernschooltrd2 = 0;
                southernschooltr1d = 0;
                southernschooltr2d = 0;
                southernschooltr3d = 1;
                southernschooltr4d = 0;
                southernschooltr1 = 0;
                southernschooltr2 = 0;
                southernschooltr3 = 1;
                southernschooltr4 = 0;
                pb1x4.Visible = true;
                pb2x4.Visible = false;
            }
            if (nationsschooltr2 == 1 && nationsschooltrd2 == 1)
            {
                nationsschooltrd2 = 0;
                nationsschooltr1d = 0;
                nationsschooltr2d = 0;
                nationsschooltr3d = 1;
                nationsschooltr4d = 0;
                nationsschooltr1 = 0;
                nationsschooltr2 = 0;
                nationsschooltr3 = 1;
                nationsschooltr4 = 0;
                pb1x5.Visible = true;
                pb2x5.Visible = false;
            }

            if (westmarkettr2 == 1 && westernschooltrd2 == 1)
            {
                westmarkettrd2 = 0;
                westmarkettr1d = 0;
                westmarkettr2d = 0;
                westmarkettr3d = 1;
                westmarkettr4d = 0;
                westmarkettr1 = 0;
                westmarkettr2 = 0;
                westmarkettr3 = 1;
                westmarkettr4 = 0;
                pb1x6.Visible = true;
                pb2x6.Visible = false;

            }
            if (nightmarkettr2 == 1 && nightmarkettrd2 == 1)
            {
                nightmarkettrd2 = 0;
                nightmarkettr1d = 0;
                nightmarkettr2d = 0;
                nightmarkettr3d = 1;
                nightmarkettr4d = 0;
                nightmarkettr1 = 0;
                nightmarkettr2 = 0;
                nightmarkettr3 = 1;
                nightmarkettr4 = 0;
                pb1x7.Visible = true;
                pb2x7.Visible = false;
            }
            if (daymarkettr2 == 1 && daymarkettrd2 == 1)
            {
                daymarkettrd2 = 0;
                daymarkettr1d = 0;
                daymarkettr2d = 0;
                daymarkettr3d = 1;
                daymarkettr4d = 0;
                daymarkettr1 = 0;
                daymarkettr2 = 0;
                daymarkettr3 = 1;
                daymarkettr4 = 0;
                pb1x8.Visible = true;
                pb2x8.Visible = false;
            }

            if (starmarkettr2 == 1 && starmarkettrd2 == 1)
            {
                starmarkettrd2 = 0;
                starmarkettr1d = 0;
                starmarkettr2d = 0;
                starmarkettr3d = 2;
                starmarkettr4d = 0;
                starmarkettr1 = 0;
                starmarkettr2 = 0;
                starmarkettr3 = 1;
                starmarkettr4 = 0;
                pb1x9.Visible = true;
                pb2x9.Visible = false;
            }
            if (moonmarkettr2 == 1 && moonmarkettrd2 == 1)
            {
                moonmarkettrd2 = 0;
                moonmarkettr1d = 0;
                moonmarkettr2d = 0;
                moonmarkettr3d = 1;
                moonmarkettr4d = 0;
                moonmarkettr1 = 0;
                moonmarkettr2 = 0;
                moonmarkettr3 = 1;
                moonmarkettr4 = 0;
                pb1x10.Visible = true;
                pb2x10.Visible = false;
            }
            if (megamarkettr2 == 1 && megamarkettrd2 == 1)
            {
                megamarkettrd2 = 0;
                megamarkettr1d = 0;
                megamarkettr2d = 0;
                megamarkettr3d = 1;
                megamarkettr4d = 0;
                megamarkettr1 = 0;
                megamarkettr2 = 0;
                megamarkettr3 = 1;
                megamarkettr4 = 0;
                pb1x11.Visible = true;
                pb2x11.Visible = false;
            }

            if (visayashospitaltr2 == 1 && visayashospitaltrd2 == 1)
            {
                visayashospitaltrd2 = 0;
                visayashospitaltr1d = 0;
                visayashospitaltr2d = 0;
                visayashospitaltr3d = 1;
                visayashospitaltr4d = 0;
                visayashospitaltr1 = 0;
                visayashospitaltr2 = 0;
                visayashospitaltr3 = 1;
                visayashospitaltr4 = 0;
                pb1x12.Visible = true;
                pb2x12.Visible = false;
            }
            if (hobertshospitaltr2 == 1 && hobertshospitaltrd2 == 1)
            {
                hobertshospitaltrd2 = 0;
                hobertshospitaltr1d = 0;
                hobertshospitaltr2d = 0;
                hobertshospitaltr3d = 1;
                hobertshospitaltr4d = 0;
                hobertshospitaltr1 = 0;
                hobertshospitaltr2 = 0;
                hobertshospitaltr3 = 1;
                hobertshospitaltr4 = 0;
                pb1x13.Visible = true;
                pb2x13.Visible = false;
            }
            if (heartshospitaltr2 == 1 && heartshospitaltrd2 == 1)
            {
                heartshospitaltrd2 = 0;
                heartshospitaltr1d = 0;
                heartshospitaltr2d = 0;
                heartshospitaltr3d = 1;
                heartshospitaltr4d = 0;
                heartshospitaltr1 = 0;
                heartshospitaltr2 = 0;
                heartshospitaltr3 = 1;
                heartshospitaltr4 = 0;
                pb1x14.Visible = true;
                pb2x14.Visible = false;

            }

            if (internshospitaltr2 == 1 && internshospitaltrd2 == 1)
            {
                internshospitaltrd2 = 0;
                internshospitaltr1d = 0;
                internshospitaltr2d = 0;
                internshospitaltr3d = 1;
                internshospitaltr4d = 0;
                internshospitaltr1 = 0;
                internshospitaltr2 = 0;
                internshospitaltr3 = 1;
                internshospitaltr4 = 0;
                pb1x15.Visible = true;
                pb2x15.Visible = false;



            }
            if (nationalhealthhospitaltr2 == 1 && nationalhealthhospitaltrd2 == 1)
            {
                nationalhealthhospitaltrd2 = 0;
                nationalhealthhospitaltr1d = 0;
                nationalhealthhospitaltr2d = 0;
                nationalhealthhospitaltr3d = 1;
                nationalhealthhospitaltr4d = 0;
                nationalhealthhospitaltr1 = 0;
                nationalhealthhospitaltr2 = 0;
                nationalhealthhospitaltr3 = 1;
                nationalhealthhospitaltr4 = 0;
                pb1x16.Visible = true;
                pb2x16.Visible = false;
            }
            if (veteranshospitaltr2 == 1 && veteranshospitaltrd2 == 1)
            {
                veteranshospitaltrd2 = 0;
                veteranshospitaltr1d = 0;
                veteranshospitaltr2d = 0;
                veteranshospitaltr3d = 1;
                veteranshospitaltr4d = 0;
                veteranshospitaltr1 = 0;
                veteranshospitaltr2 = 0;
                veteranshospitaltr3 = 1;
                veteranshospitaltr4 = 0;
                pb1x17.Visible = true;
                pb2x17.Visible = false;
            }

            if (pearlmalltr2 == 1 && pearlmalltrd2 == 1)
            {
                pearlmalltrd2 = 0;
                pearlmalltr1d = 0;
                pearlmalltr2d = 0;
                pearlmalltr3d = 1;
                pearlmalltr4d = 0;
                pearlmalltr1 = 0;
                pearlmalltr2 = 0;
                pearlmalltr3 = 1;
                pearlmalltr4 = 0;
                pb1x18.Visible = true;
                pb2x18.Visible = false;
            }
            if (megamalltr2 == 1 && megamalltrd2 == 1)
            {
                megamalltrd2 = 0;
                megamalltr1d = 0;
                megamalltr2d = 0;
                megamalltr3d = 1;
                megamalltr4d = 0;
                megamalltr1 = 0;
                megamalltr2 = 0;
                megamalltr3 = 1;
                megamalltr4 = 0;
                pb1x19.Visible = true;
                pb2x19.Visible = false;
            }
            if (articmalltr2 == 1 && articmalltrd2 == 1)
            {
                articmalltrd2 = 0;
                articmalltr1d = 0;
                articmalltr2d = 0;
                articmalltr3d = 1;
                articmalltr4d = 0;
                articmalltr1 = 0;
                articmalltr2 = 0;
                articmalltr3 = 1;
                articmalltr4 = 0;
                pb1x20.Visible = true;
                pb2x20.Visible = false;
            }

            if (heavenlymalltr2 == 1 && heavenlymalltrd2 == 1)
            {
                heavenlymalltrd2 = 0;
                heavenlymalltr1d = 0;
                heavenlymalltr2d = 0;
                heavenlymalltr3d = 1;
                heavenlymalltr4d = 0;
                heavenlymalltr1 = 0;
                heavenlymalltr2 = 0;
                heavenlymalltr3 = 1;
                heavenlymalltr4 = 0;
                pb1x21.Visible = true;
                pb2x21.Visible = false;
            }
            if (shangrillamalltr2 == 1 && shangrillamalltrd2 == 1)
            {
                shangrillamalltrd2 = 0;
                shangrillamalltr1d = 0;
                shangrillamalltr2d = 0;
                shangrillamalltr3d = 1;
                shangrillamalltr4d = 0;
                shangrillamalltr1 = 0;
                shangrillamalltr2 = 0;
                shangrillamalltr3 = 1;
                shangrillamalltr4 = 0;
                pb1x22.Visible = true;
                pb2x22.Visible = false;
            }

            if (utility2x1tr2 == 1 && utility2x1trd2 == 1)
            {
                utility2x1trd2 = 0;
                utility1x1tr1d = 0;
                utility2x1tr2d = 0;
                utility3x1tr3d = 1;
                utility4x1tr4d = 0;
                utility1x1tr1 = 0;
                utility2x1tr2 = 0;
                utility3x1tr3 = 1;
                utility4x1tr4 = 0;
                pb1x23.Visible = true;
                pb2x23.Visible = false;
            }
            if (utility2x2tr2 == 1 && utility2x2trd2 == 1)
            {
                utility2x2trd2 = 0;
                utility1x2tr1d = 0;
                utility2x2tr2d = 0;
                utility3x2tr3d = 1;
                utility4x2tr4d = 0;
                utility1x2tr1 = 0;
                utility2x2tr2 = 0;
                utility3x2tr3 = 1;
                utility4x2tr4 = 0;
                pb1x24.Visible = true;
                pb2x24.Visible = false;
            }

            if (transportation2x1tr2 == 1 && transportation2x1trd2 == 1)
            {
                transportation2x1trd2 = 0;
                transportation1x1tr1d = 0;
                transportation2x1tr2d = 0;
                transportation3x1tr3d = 1;
                transportation4x1tr4d = 0;
                transportation1x1tr1 = 0;
                transportation2x1tr2 = 0;
                transportation3x1tr3 = 1;
                transportation4x1tr4 = 0;
                pb1x25.Visible = true;
                pb2x25.Visible = false;
            }
            if (transportation2x2tr2 == 1 && transportation2x2trd2 == 1)
            {
                transportation2x2trd2 = 0;
                transportation1x2tr1d = 0;
                transportation2x2tr2d = 0;
                transportation3x2tr3d = 1;
                transportation4x2tr4d = 0;
                transportation1x2tr1 = 0;
                transportation2x2tr2 = 0;
                transportation3x2tr3 = 1;
                transportation4x2tr4 = 0;
                pb1x26.Visible = true;
                pb2x26.Visible = false;
            }
            if (transportation2x3tr2 == 1 && transportation2x3trd2 == 1)
            {
                transportation2x3trd2 = 0;
                transportation1x3tr1d = 0;
                transportation2x3tr2d = 0;
                transportation3x3tr3d = 1;
                transportation4x3tr4d = 0;
                transportation1x3tr1 = 0;
                transportation2x3tr2 = 0;
                transportation3x3tr3 = 1;
                transportation4x3tr4 = 0;
                pb1x27.Visible = true;
                pb2x27.Visible = false;
            }
            if (transportation2x4tr2 == 1 && transportation2x4trd2 == 1)
            {
                transportation2x4trd2 = 0;
                transportation1x4tr1d = 0;
                transportation2x4tr2d = 0;
                transportation3x4tr3d = 1;
                transportation4x4tr4d = 0;
                transportation1x4tr1 = 0;
                transportation2x4tr2 = 0;
                transportation3x4tr3 = 1;
                transportation4x4tr4 = 0;
                pb1x28.Visible = true;
                pb2x28.Visible = false;
            }

        }
        void p2traded2_4()
        {
            //p2 to p4
            if (easternschooltr2 == 1 && easternschooltrd2 == 1)
            {
                easternschooltrd2 = 0;
                easternschooltr1d = 0;
                easternschooltr2d = 0;
                easternschooltr3d = 0;
                easternschooltr4d = 1;
                easternschooltr1 = 0;
                easternschooltr2 = 0;
                easternschooltr3 = 0;
                easternschooltr4 = 1;
                pb1x1.Visible = true;
                pb2x1.Visible = false;


            }
            if (westernschooltr2 == 1 && westernschooltrd2 == 1)
            {
                westernschooltrd2 = 0;
                westernschooltr1d = 0;
                westernschooltr2d = 0;
                westernschooltr3d = 0;
                westernschooltr4d = 1;
                westernschooltr1 = 0;
                westernschooltr2 = 0;
                westernschooltr3 = 0;
                westernschooltr4 = 1;
                pb1x2.Visible = true;
                pb2x2.Visible = false;

            }

            if (visayashighschooltr2 == 1 && visayashighschooltrd2 == 1)
            {
                visayashighschooltrd2 = 0;
                visayashighschooltr1d = 0;
                visayashighschooltr2d = 0;
                visayashighschooltr3d = 0;
                visayashighschooltr4d = 1;
                visayashighschooltr1 = 0;
                visayashighschooltr2 = 0;
                visayashighschooltr3 = 0;
                visayashighschooltr4 = 1;
                pb1x3.Visible = true;
                pb2x3.Visible = false;
            }
            if (southernschooltr2 == 1 && southernschooltrd2 == 1)
            {
                southernschooltrd2 = 0;
                southernschooltr1d = 0;
                southernschooltr2d = 0;
                southernschooltr3d = 0;
                southernschooltr4d = 1;
                southernschooltr1 = 0;
                southernschooltr2 = 0;
                southernschooltr3 = 0;
                southernschooltr4 = 1;
                pb1x4.Visible = true;
                pb2x4.Visible = false;
            }
            if (nationsschooltr2 == 1 && nationsschooltrd2 == 1)
            {
                nationsschooltrd2 = 0;
                nationsschooltr1d = 0;
                nationsschooltr2d = 0;
                nationsschooltr3d = 0;
                nationsschooltr4d = 1;
                nationsschooltr1 = 0;
                nationsschooltr2 = 0;
                nationsschooltr3 = 0;
                nationsschooltr4 = 1;
                pb1x5.Visible = true;
                pb2x5.Visible = false;
            }

            if (westmarkettr2 == 1 && westernschooltrd2 == 1)
            {
                westmarkettrd2 = 0;
                westmarkettr1d = 0;
                westmarkettr2d = 0;
                westmarkettr3d = 0;
                westmarkettr4d = 1;
                westmarkettr1 = 0;
                westmarkettr2 = 0;
                westmarkettr3 = 0;
                westmarkettr4 = 1;
                pb1x6.Visible = true;
                pb2x6.Visible = false;

            }
            if (nightmarkettr2 == 1 && nightmarkettrd2 == 1)
            {
                nightmarkettrd2 = 0;
                nightmarkettr1d = 0;
                nightmarkettr2d = 0;
                nightmarkettr3d = 0;
                nightmarkettr4d = 1;
                nightmarkettr1 = 0;
                nightmarkettr2 = 0;
                nightmarkettr3 = 0;
                nightmarkettr4 = 1;
                pb1x7.Visible = true;
                pb2x7.Visible = false;
            }
            if (daymarkettr2 == 1 && daymarkettrd2 == 1)
            {
                daymarkettrd2 = 0;
                daymarkettr1d = 0;
                daymarkettr2d = 0;
                daymarkettr3d = 0;
                daymarkettr4d = 1;
                daymarkettr1 = 0;
                daymarkettr2 = 0;
                daymarkettr3 = 0;
                daymarkettr4 = 1;
                pb1x8.Visible = true;
                pb2x8.Visible = false;
            }

            if (starmarkettr2 == 1 && starmarkettrd2 == 1)
            {
                starmarkettrd2 = 0;
                starmarkettr1d = 0;
                starmarkettr2d = 0;
                starmarkettr3d = 0;
                starmarkettr4d = 1;
                starmarkettr1 = 0;
                starmarkettr2 = 0;
                starmarkettr3 = 0;
                starmarkettr4 = 1;
                pb1x9.Visible = true;
                pb2x9.Visible = false;
            }
            if (moonmarkettr2 == 1 && moonmarkettrd2 == 1)
            {
                moonmarkettrd2 = 0;
                moonmarkettr1d = 0;
                moonmarkettr2d = 0;
                moonmarkettr3d = 0;
                moonmarkettr4d = 1;
                moonmarkettr1 = 0;
                moonmarkettr2 = 0;
                moonmarkettr3 = 0;
                moonmarkettr4 = 1;
                pb1x10.Visible = true;
                pb2x10.Visible = false;
            }
            if (megamarkettr2 == 1 && megamarkettrd2 == 1)
            {
                megamarkettrd2 = 0;
                megamarkettr1d = 0;
                megamarkettr2d = 0;
                megamarkettr3d = 0;
                megamarkettr4d = 1;
                megamarkettr1 = 0;
                megamarkettr2 = 0;
                megamarkettr3 = 0;
                megamarkettr4 = 1;
                pb1x11.Visible = true;
                pb2x11.Visible = false;
            }

            if (visayashospitaltr2 == 1 && visayashospitaltrd2 == 1)
            {
                visayashospitaltrd2 = 0;
                visayashospitaltr1d = 0;
                visayashospitaltr2d = 0;
                visayashospitaltr3d = 0;
                visayashospitaltr4d = 1;
                visayashospitaltr1 = 0;
                visayashospitaltr2 = 0;
                visayashospitaltr3 = 0;
                visayashospitaltr4 = 1;
                pb1x12.Visible = true;
                pb2x12.Visible = false;
            }
            if (hobertshospitaltr2 == 1 && hobertshospitaltrd2 == 1)
            {
                hobertshospitaltrd2 = 0;
                hobertshospitaltr1d = 0;
                hobertshospitaltr2d = 0;
                hobertshospitaltr3d = 0;
                hobertshospitaltr4d = 1;
                hobertshospitaltr1 = 0;
                hobertshospitaltr2 = 0;
                hobertshospitaltr3 = 0;
                hobertshospitaltr4 = 1;
                pb1x13.Visible = true;
                pb2x13.Visible = false;
            }
            if (heartshospitaltr2 == 1 && heartshospitaltrd2 == 1)
            {
                heartshospitaltrd2 = 0;
                heartshospitaltr1d = 0;
                heartshospitaltr2d = 0;
                heartshospitaltr3d = 0;
                heartshospitaltr4d = 1;
                heartshospitaltr1 = 0;
                heartshospitaltr2 = 0;
                heartshospitaltr3 = 0;
                heartshospitaltr4 = 1;
                pb1x14.Visible = true;
                pb2x14.Visible = false;

            }

            if (internshospitaltr2 == 1 && internshospitaltrd2 == 1)
            {
                internshospitaltrd2 = 0;
                internshospitaltr1d = 0;
                internshospitaltr2d = 0;
                internshospitaltr3d = 0;
                internshospitaltr4d = 1;
                internshospitaltr1 = 0;
                internshospitaltr2 = 0;
                internshospitaltr3 = 0;
                internshospitaltr4 = 1;
                pb1x15.Visible = true;
                pb2x15.Visible = false;



            }
            if (nationalhealthhospitaltr2 == 1 && nationalhealthhospitaltrd2 == 1)
            {
                nationalhealthhospitaltrd2 = 0;
                nationalhealthhospitaltr1d = 0;
                nationalhealthhospitaltr2d = 0;
                nationalhealthhospitaltr3d = 0;
                nationalhealthhospitaltr4d = 1;
                nationalhealthhospitaltr1 = 0;
                nationalhealthhospitaltr2 = 0;
                nationalhealthhospitaltr3 = 0;
                nationalhealthhospitaltr4 = 1;
                pb1x16.Visible = true;
                pb2x16.Visible = false;
            }
            if (veteranshospitaltr2 == 1 && veteranshospitaltrd2 == 1)
            {
                veteranshospitaltrd2 = 0;
                veteranshospitaltr1d = 0;
                veteranshospitaltr2d = 0;
                veteranshospitaltr3d = 0;
                veteranshospitaltr4d = 1;
                veteranshospitaltr1 = 0;
                veteranshospitaltr2 = 0;
                veteranshospitaltr3 = 0;
                veteranshospitaltr4 = 1;
                pb1x17.Visible = true;
                pb2x17.Visible = false;
            }

            if (pearlmalltr2 == 1 && pearlmalltrd2 == 1)
            {
                pearlmalltrd2 = 0;
                pearlmalltr1d = 0;
                pearlmalltr2d = 0;
                pearlmalltr3d = 0;
                pearlmalltr4d = 1;
                pearlmalltr1 = 0;
                pearlmalltr2 = 0;
                pearlmalltr3 = 0;
                pearlmalltr4 = 1;
                pb1x18.Visible = true;
                pb2x18.Visible = false;
            }
            if (megamalltr2 == 1 && megamalltrd2 == 1)
            {
                megamalltrd2 = 0;
                megamalltr1d = 0;
                megamalltr2d = 0;
                megamalltr3d = 0;
                megamalltr4d = 1;
                megamalltr1 = 0;
                megamalltr2 = 0;
                megamalltr3 = 0;
                megamalltr4 = 1;
                pb1x19.Visible = true;
                pb2x19.Visible = false;
            }
            if (articmalltr2 == 1 && articmalltrd2 == 1)
            {
                articmalltrd2 = 0;
                articmalltr1d = 0;
                articmalltr2d = 0;
                articmalltr3d = 0;
                articmalltr4d = 1;
                articmalltr1 = 0;
                articmalltr2 = 0;
                articmalltr3 = 0;
                articmalltr4 = 1;
                pb1x20.Visible = true;
                pb2x20.Visible = false;
            }

            if (heavenlymalltr2 == 1 && heavenlymalltrd2 == 1)
            {
                heavenlymalltrd2 = 0;
                heavenlymalltr1d = 0;
                heavenlymalltr2d = 0;
                heavenlymalltr3d = 0;
                heavenlymalltr4d = 1;
                heavenlymalltr1 = 0;
                heavenlymalltr2 = 0;
                heavenlymalltr3 = 0;
                heavenlymalltr4 = 1;
                pb1x21.Visible = true;
                pb2x21.Visible = false;
            }
            if (shangrillamalltr2 == 1 && shangrillamalltrd2 == 1)
            {
                shangrillamalltrd2 = 0;
                shangrillamalltr1d = 0;
                shangrillamalltr2d = 0;
                shangrillamalltr3d = 0;
                shangrillamalltr4d = 1;
                shangrillamalltr1 = 0;
                shangrillamalltr2 = 0;
                shangrillamalltr3 = 0;
                shangrillamalltr4 = 1;
                pb1x22.Visible = true;
                pb2x22.Visible = false;
            }

            if (utility2x1tr2 == 1 && utility2x1trd2 == 1)
            {
                utility2x1trd2 = 0;
                utility1x1tr1d = 0;
                utility2x1tr2d = 0;
                utility3x1tr3d = 0;
                utility4x1tr4d = 1;
                utility1x1tr1 = 0;
                utility2x1tr2 = 0;
                utility3x1tr3 = 0;
                utility4x1tr4 = 1;
                pb1x23.Visible = true;
                pb2x23.Visible = false;
            }
            if (utility2x2tr2 == 1 && utility2x2trd2 == 1)
            {
                utility2x2trd2 = 0;
                utility1x2tr1d = 0;
                utility2x2tr2d = 0;
                utility3x2tr3d = 0;
                utility4x2tr4d = 1;
                utility1x2tr1 = 0;
                utility2x2tr2 = 0;
                utility3x2tr3 = 0;
                utility4x2tr4 = 1;
                pb1x24.Visible = true;
                pb2x24.Visible = false;
            }

            if (transportation2x1tr2 == 1 && transportation2x1trd2 == 1)
            {
                transportation2x1trd2 = 0;
                transportation1x1tr1d = 0;
                transportation2x1tr2d = 0;
                transportation3x1tr3d = 0;
                transportation4x1tr4d = 1;
                transportation1x1tr1 = 0;
                transportation2x1tr2 = 0;
                transportation3x1tr3 = 0;
                transportation4x1tr4 = 1;
                pb1x25.Visible = true;
                pb2x25.Visible = false;
            }
            if (transportation2x2tr2 == 1 && transportation2x2trd2 == 1)
            {
                transportation2x2trd2 = 0;
                transportation1x2tr1d = 0;
                transportation2x2tr2d = 0;
                transportation3x2tr3d = 0;
                transportation4x2tr4d = 1;
                transportation1x2tr1 = 0;
                transportation2x2tr2 = 0;
                transportation3x2tr3 = 0;
                transportation4x2tr4 = 1;
                pb1x26.Visible = true;
                pb2x26.Visible = false;
            }
            if (transportation2x3tr2 == 1 && transportation2x3trd2 == 1)
            {
                transportation2x3trd2 = 0;
                transportation1x3tr1d = 0;
                transportation2x3tr2d = 0;
                transportation3x3tr3d = 0;
                transportation4x3tr4d = 1;
                transportation1x3tr1 = 0;
                transportation2x3tr2 = 0;
                transportation3x3tr3 = 0;
                transportation4x3tr4 = 1;
                pb1x27.Visible = true;
                pb2x27.Visible = false;
            }
            if (transportation2x4tr2 == 1 && transportation2x4trd2 == 1)
            {
                transportation2x4trd2 = 0;
                transportation1x4tr1d = 0;
                transportation2x4tr2d = 0;
                transportation3x4tr3d = 0;
                transportation4x4tr4d = 1;
                transportation1x4tr1 = 0;
                transportation2x4tr2 = 0;
                transportation3x4tr3 = 0;
                transportation4x4tr4 = 1;
                pb1x28.Visible = true;
                pb2x28.Visible = false;
            }
        }
        void p3traded3()
        {
            if (easternschooltr3 == 1 && easternschooltrd2 == 1)
            {
                easternschooltrd2 = 0;
                easternschooltr1d = 1;
                easternschooltr2d = 0;
                easternschooltr3d = 0;
                easternschooltr4d = 0;
                easternschooltr1 = 1;
                easternschooltr2 = 0;
                easternschooltr3 = 0;
                easternschooltr4 = 0;
                pb1x1.Visible = true;
                pb2x1.Visible = false;

            }
            if (westernschooltr3 == 1 && westernschooltrd2 == 1)
            {
                westernschooltrd2 = 0;
                westernschooltr1d = 1;
                westernschooltr2d = 0;
                westernschooltr3d = 0;
                westernschooltr4d = 0;
                westernschooltr1 = 1;
                westernschooltr2 = 0;
                westernschooltr3 = 0;
                westernschooltr4 = 0;
                pb1x2.Visible = true;
                pb2x2.Visible = false;


            }

            if (visayashighschooltr3 == 1 && visayashighschooltrd2 == 1)
            {
                visayashighschooltrd2 = 0;
                visayashighschooltr1d = 1;
                visayashighschooltr2d = 0;
                visayashighschooltr3d = 0;
                visayashighschooltr4d = 0;
                visayashighschooltr1 = 1;
                visayashighschooltr2 = 0;
                visayashighschooltr3 = 0;
                visayashighschooltr4 = 0;
                pb1x3.Visible = true;
                pb2x3.Visible = false;
            }
            if (southernschooltr3 == 1 && southernschooltrd2 == 1)
            {
                southernschooltrd2 = 0;
                southernschooltr1d = 1;
                southernschooltr2d = 0;
                southernschooltr3d = 0;
                southernschooltr4d = 0;
                southernschooltr1 = 1;
                southernschooltr2 = 0;
                southernschooltr3 = 0;
                southernschooltr4 = 0;
                pb1x4.Visible = true;
                pb2x4.Visible = false;
            }
            if (nationsschooltr3 == 1 && nationsschooltrd2 == 1)
            {
                nationsschooltrd2 = 0;
                nationsschooltr1d = 1;
                nationsschooltr2d = 0;
                nationsschooltr3d = 0;
                nationsschooltr4d = 0;
                nationsschooltr1 = 1;
                nationsschooltr2 = 0;
                nationsschooltr3 = 0;
                nationsschooltr4 = 0;
                pb1x5.Visible = true;
                pb2x5.Visible = false;
            }

            if (westmarkettr3 == 1 && westernschooltrd2 == 1)
            {
                westmarkettrd2 = 0;
                westmarkettr1d = 1;
                westmarkettr2d = 0;
                westmarkettr3d = 0;
                westmarkettr4d = 0;
                westmarkettr1 = 1;
                westmarkettr2 = 0;
                westmarkettr3 = 0;
                westmarkettr4 = 0;
                pb1x6.Visible = true;
                pb2x6.Visible = false;

            }
            if (nightmarkettr3 == 1 && nightmarkettrd2 == 1)
            {
                nightmarkettrd2 = 0;
                nightmarkettr1d = 1;
                nightmarkettr2d = 0;
                nightmarkettr3d = 0;
                nightmarkettr4d = 0;
                nightmarkettr1 = 1;
                nightmarkettr2 = 0;
                nightmarkettr3 = 0;
                nightmarkettr4 = 0;
                pb1x7.Visible = true;
                pb2x7.Visible = false;
            }
            if (daymarkettr3 == 1 && daymarkettrd2 == 1)
            {
                daymarkettrd2 = 0;
                daymarkettr1d = 1;
                daymarkettr2d = 0;
                daymarkettr3d = 0;
                daymarkettr4d = 0;
                daymarkettr1 = 1;
                daymarkettr2 = 0;
                daymarkettr3 = 0;
                daymarkettr4 = 0;
                pb1x8.Visible = true;
                pb2x8.Visible = false;
            }

            if (starmarkettr3 == 1 && starmarkettrd2 == 1)
            {
                starmarkettrd2 = 0;
                starmarkettr1d = 1;
                starmarkettr2d = 0;
                starmarkettr3d = 0;
                starmarkettr4d = 0;
                starmarkettr1 = 1;
                starmarkettr2 = 0;
                starmarkettr3 = 0;
                starmarkettr4 = 0;
                pb1x9.Visible = true;
                pb2x9.Visible = false;
            }
            if (moonmarkettr3 == 1 && moonmarkettrd2 == 1)
            {
                moonmarkettrd2 = 0;
                moonmarkettr1d = 1;
                moonmarkettr2d = 0;
                moonmarkettr3d = 0;
                moonmarkettr4d = 0;
                moonmarkettr1 = 1;
                moonmarkettr2 = 0;
                moonmarkettr3 = 0;
                moonmarkettr4 = 0;
                pb1x10.Visible = true;
                pb2x10.Visible = false;
            }
            if (megamarkettr3 == 1 && megamarkettrd2 == 1)
            {
                megamarkettrd2 = 0;
                megamarkettr1d = 1;
                megamarkettr2d = 0;
                megamarkettr3d = 0;
                megamarkettr4d = 0;
                megamarkettr1 = 1;
                megamarkettr2 = 0;
                megamarkettr3 = 0;
                megamarkettr4 = 0;
                pb1x11.Visible = true;
                pb2x11.Visible = false;
            }

            if (visayashospitaltr3 == 1 && visayashospitaltrd2 == 1)
            {
                visayashospitaltrd2 = 0;
                visayashospitaltr1d = 1;
                visayashospitaltr2d = 0;
                visayashospitaltr3d = 0;
                visayashospitaltr4d = 0;
                visayashospitaltr1 = 1;
                visayashospitaltr2 = 0;
                visayashospitaltr3 = 0;
                visayashospitaltr4 = 0;
                pb1x12.Visible = true;
                pb2x12.Visible = false;
            }
            if (hobertshospitaltr3 == 1 && hobertshospitaltrd2 == 1)
            {
                hobertshospitaltrd2 = 0;
                hobertshospitaltr1d = 1;
                hobertshospitaltr2d = 0;
                hobertshospitaltr3d = 0;
                hobertshospitaltr4d = 0;
                hobertshospitaltr1 = 1;
                hobertshospitaltr2 = 0;
                hobertshospitaltr3 = 0;
                hobertshospitaltr4 = 0;
                pb1x13.Visible = true;
                pb2x13.Visible = false;
            }
            if (heartshospitaltr3 == 1 && heartshospitaltrd2 == 1)
            {
                heartshospitaltrd2 = 0;
                heartshospitaltr1d = 1;
                heartshospitaltr2d = 0;
                heartshospitaltr3d = 0;
                heartshospitaltr4d = 0;
                heartshospitaltr1 = 1;
                heartshospitaltr2 = 0;
                heartshospitaltr3 = 0;
                heartshospitaltr4 = 0;
                pb1x14.Visible = true;
                pb2x14.Visible = false;

            }

            if (internshospitaltr3 == 1 && internshospitaltrd2 == 1)
            {
                internshospitaltrd2 = 0;
                internshospitaltr1d = 1;
                internshospitaltr2d = 0;
                internshospitaltr3d = 0;
                internshospitaltr4d = 0;
                internshospitaltr1 = 1;
                internshospitaltr2 = 0;
                internshospitaltr3 = 0;
                internshospitaltr4 = 0;
                pb1x15.Visible = true;
                pb2x15.Visible = false;



            }
            if (nationalhealthhospitaltr3 == 1 && nationalhealthhospitaltrd2 == 1)
            {
                nationalhealthhospitaltrd2 = 0;
                nationalhealthhospitaltr1d = 1;
                nationalhealthhospitaltr2d = 0;
                nationalhealthhospitaltr3d = 0;
                nationalhealthhospitaltr4d = 0;
                nationalhealthhospitaltr1 = 1;
                nationalhealthhospitaltr2 = 0;
                nationalhealthhospitaltr3 = 0;
                nationalhealthhospitaltr4 = 0;
                pb1x16.Visible = true;
                pb2x16.Visible = false;
            }
            if (veteranshospitaltr3 == 1 && veteranshospitaltrd2 == 1)
            {
                veteranshospitaltrd2 = 0;
                veteranshospitaltr1d = 1;
                veteranshospitaltr2d = 0;
                veteranshospitaltr3d = 0;
                veteranshospitaltr4d = 0;
                veteranshospitaltr1 = 1;
                veteranshospitaltr2 = 0;
                veteranshospitaltr3 = 0;
                veteranshospitaltr4 = 0;
                pb1x17.Visible = true;
                pb2x17.Visible = false;
            }

            if (pearlmalltr3 == 1 && pearlmalltrd2 == 1)
            {
                pearlmalltrd2 = 0;
                pearlmalltr1d = 1;
                pearlmalltr2d = 0;
                pearlmalltr3d = 0;
                pearlmalltr4d = 0;
                pearlmalltr1 = 1;
                pearlmalltr2 = 0;
                pearlmalltr3 = 0;
                pearlmalltr4 = 0;
                pb1x18.Visible = true;
                pb2x18.Visible = false;
            }
            if (megamalltr3 == 1 && megamalltrd2 == 1)
            {
                megamalltrd2 = 0;
                megamalltr1d = 1;
                megamalltr2d = 0;
                megamalltr3d = 0;
                megamalltr4d = 0;
                megamalltr1 = 1;
                megamalltr2 = 0;
                megamalltr3 = 0;
                megamalltr4 = 0;
                pb1x19.Visible = true;
                pb2x19.Visible = false;
            }
            if (articmalltr3 == 1 && articmalltrd2 == 1)
            {
                articmalltrd2 = 0;
                articmalltr1d = 1;
                articmalltr2d = 0;
                articmalltr3d = 0;
                articmalltr4d = 0;
                articmalltr1 = 1;
                articmalltr2 = 0;
                articmalltr3 = 0;
                articmalltr4 = 0;
                pb1x20.Visible = true;
                pb2x20.Visible = false;
            }

            if (heavenlymalltr3 == 1 && heavenlymalltrd2 == 1)
            {
                heavenlymalltrd2 = 0;
                heavenlymalltr1d = 1;
                heavenlymalltr2d = 0;
                heavenlymalltr3d = 0;
                heavenlymalltr4d = 0;
                heavenlymalltr1 = 1;
                heavenlymalltr2 = 0;
                heavenlymalltr3 = 0;
                heavenlymalltr4 = 0;
                pb1x21.Visible = true;
                pb2x21.Visible = false;
            }
            if (shangrillamalltr3 == 1 && shangrillamalltrd2 == 1)
            {
                shangrillamalltrd2 = 0;
                shangrillamalltr1d = 1;
                shangrillamalltr2d = 0;
                shangrillamalltr3d = 0;
                shangrillamalltr4d = 0;
                shangrillamalltr1 = 1;
                shangrillamalltr2 = 0;
                shangrillamalltr3 = 0;
                shangrillamalltr4 = 0;
                pb1x22.Visible = true;
                pb2x22.Visible = false;
            }

            if (utility3x1tr3 == 1 && utility2x1trd2 == 1)
            {
                utility2x1trd2 = 0;
                utility1x1tr1d = 1;
                utility2x1tr2d = 0;
                utility3x1tr3d = 0;
                utility4x1tr4d = 0;
                utility1x1tr1 = 1;
                utility2x1tr2 = 0;
                utility3x1tr3 = 0;
                utility4x1tr4 = 0;
                pb1x23.Visible = true;
                pb2x23.Visible = false;
            }
            if (utility3x2tr3 == 1 && utility2x2trd2 == 1)
            {
                utility2x2trd2 = 0;
                utility1x2tr1d = 1;
                utility2x2tr2d = 0;
                utility3x2tr3d = 0;
                utility4x2tr4d = 0;
                utility1x2tr1 = 1;
                utility2x2tr2 = 0;
                utility3x2tr3 = 0;
                utility4x2tr4 = 0;

                pb1x24.Visible = true;
                pb2x24.Visible = false;
            }

            if (transportation3x1tr3 == 1 && transportation2x1trd2 == 1)
            {
                transportation2x1trd2 = 0;
                transportation1x1tr1d = 1;
                transportation2x1tr2d = 0;
                transportation3x1tr3d = 0;
                transportation4x1tr4d = 0;
                transportation1x1tr1 = 1;
                transportation2x1tr2 = 0;
                transportation3x1tr3 = 0;
                transportation4x1tr4 = 0;
                pb1x25.Visible = true;
                pb2x25.Visible = false;
            }
            if (transportation3x2tr3 == 1 && transportation2x2trd2 == 1)
            {
                transportation2x2trd2 = 0;
                transportation1x2tr1d = 1;
                transportation2x2tr2d = 0;
                transportation3x2tr3d = 0;
                transportation4x2tr4d = 0;
                transportation1x2tr1 = 1;
                transportation2x2tr2 = 0;
                transportation3x2tr3 = 0;
                transportation4x2tr4 = 0;
                pb1x26.Visible = true;
                pb2x26.Visible = false;
            }
            if (transportation3x3tr3 == 1 && transportation2x3trd2 == 1)
            {
                transportation2x3trd2 = 0;
                transportation1x3tr1d = 1;
                transportation2x3tr2d = 0;
                transportation3x3tr3d = 0;
                transportation4x3tr4d = 0;
                transportation1x3tr1 = 1;
                transportation2x3tr2 = 0;
                transportation3x3tr3 = 0;
                transportation4x3tr4 = 0;
                pb1x27.Visible = true;
                pb2x27.Visible = false;
            }
            if (transportation3x4tr3 == 1 && transportation2x4trd2 == 1)
            {
                transportation2x4trd2 = 0;
                transportation1x4tr1d = 1;
                transportation2x4tr2d = 0;
                transportation3x4tr3d = 0;
                transportation4x4tr4d = 0;
                transportation1x4tr1 = 1;
                transportation2x4tr2 = 0;
                transportation3x4tr3 = 0;
                transportation4x4tr4 = 0;
                pb1x28.Visible = true;
                pb2x28.Visible = false;
            }


        }
        void p3traded3_2()
        {
            //p3 to p2
            if (easternschooltr3 == 1 && easternschooltrd2 == 1)
            {
                easternschooltrd2 = 0;
                easternschooltr1d = 0;
                easternschooltr2d = 1;
                easternschooltr3d = 0;
                easternschooltr4d = 0;
                easternschooltr1 = 0;
                easternschooltr2 = 1;
                easternschooltr3 = 0;
                easternschooltr4 = 0;
                pb1x1.Visible = true;
                pb2x1.Visible = false;


            }
            if (westernschooltr3 == 1 && westernschooltrd2 == 1)
            {
                westernschooltrd2 = 0;
                westernschooltr1d = 0;
                westernschooltr2d = 1;
                westernschooltr3d = 0;
                westernschooltr4d = 0;
                westernschooltr1 = 0;
                westernschooltr2 = 1;
                westernschooltr3 = 0;
                westernschooltr4 = 0;
                pb1x2.Visible = true;
                pb2x2.Visible = false;

            }

            if (visayashighschooltr3 == 1 && visayashighschooltrd2 == 1)
            {
                visayashighschooltrd2 = 0;
                visayashighschooltr1d = 0;
                visayashighschooltr2d = 1;
                visayashighschooltr3d = 0;
                visayashighschooltr4d = 0;
                visayashighschooltr1 = 0;
                visayashighschooltr2 = 1;
                visayashighschooltr3 = 0;
                visayashighschooltr4 = 0;
                pb1x3.Visible = true;
                pb2x3.Visible = false;
            }
            if (southernschooltr3 == 1 && southernschooltrd2 == 1)
            {
                southernschooltrd2 = 0;
                southernschooltr1d = 0;
                southernschooltr2d = 1;
                southernschooltr3d = 0;
                southernschooltr4d = 0;
                southernschooltr1 = 0;
                southernschooltr2 = 1;
                southernschooltr3 = 0;
                southernschooltr4 = 0;
                pb1x4.Visible = true;
                pb2x4.Visible = false;
            }
            if (nationsschooltr3 == 1 && nationsschooltrd2 == 1)
            {
                nationsschooltrd2 = 0;
                nationsschooltr1d = 0;
                nationsschooltr2d = 1;
                nationsschooltr3d = 0;
                nationsschooltr4d = 0;
                nationsschooltr1 = 0;
                nationsschooltr2 = 1;
                nationsschooltr3 = 0;
                nationsschooltr4 = 0;
                pb1x5.Visible = true;
                pb2x5.Visible = false;
            }

            if (westmarkettr3 == 1 && westernschooltrd2 == 1)
            {
                westmarkettrd2 = 0;
                westmarkettr1d = 0;
                westmarkettr2d = 1;
                westmarkettr3d = 0;
                westmarkettr4d = 0;
                westmarkettr1 = 0;
                westmarkettr2 = 1;
                westmarkettr3 = 0;
                westmarkettr4 = 0;
                pb1x6.Visible = true;
                pb2x6.Visible = false;

            }
            if (nightmarkettr3 == 1 && nightmarkettrd2 == 1)
            {
                nightmarkettrd2 = 0;
                nightmarkettr1d = 0;
                nightmarkettr2d = 1;
                nightmarkettr3d = 0;
                nightmarkettr4d = 0;
                nightmarkettr1 = 0;
                nightmarkettr2 = 1;
                nightmarkettr3 = 0;
                nightmarkettr4 = 0;
                pb1x7.Visible = true;
                pb2x7.Visible = false;
            }
            if (daymarkettr3 == 1 && daymarkettrd2 == 1)
            {
                daymarkettrd2 = 0;
                daymarkettr1d = 0;
                daymarkettr2d = 1;
                daymarkettr3d = 0;
                daymarkettr4d = 0;
                daymarkettr1 = 0;
                daymarkettr2 = 1;
                daymarkettr3 = 0;
                daymarkettr4 = 0;
                pb1x8.Visible = true;
                pb2x8.Visible = false;
            }

            if (starmarkettr3 == 1 && starmarkettrd2 == 1)
            {
                starmarkettrd2 = 0;
                starmarkettr1d = 0;
                starmarkettr2d = 1;
                starmarkettr3d = 0;
                starmarkettr4d = 0;
                starmarkettr1 = 0;
                starmarkettr2 = 1;
                starmarkettr3 = 0;
                starmarkettr4 = 0;
                pb1x9.Visible = true;
                pb2x9.Visible = false;
            }
            if (moonmarkettr3 == 1 && moonmarkettrd2 == 1)
            {
                moonmarkettrd2 = 0;
                moonmarkettr1d = 0;
                moonmarkettr2d = 1;
                moonmarkettr3d = 0;
                moonmarkettr4d = 0;
                moonmarkettr1 = 0;
                moonmarkettr2 = 1;
                moonmarkettr3 = 0;
                moonmarkettr4 = 0;
                pb1x10.Visible = true;
                pb2x10.Visible = false;
            }
            if (megamarkettr3 == 1 && megamarkettrd2 == 1)
            {
                megamarkettrd2 = 0;
                megamarkettr1d = 0;
                megamarkettr2d = 1;
                megamarkettr3d = 0;
                megamarkettr4d = 0;
                megamarkettr1 = 0;
                megamarkettr2 = 1;
                megamarkettr3 = 0;
                megamarkettr4 = 0;
                pb1x11.Visible = true;
                pb2x11.Visible = false;
            }

            if (visayashospitaltr3 == 1 && visayashospitaltrd2 == 1)
            {
                visayashospitaltrd2 = 0;
                visayashospitaltr1d = 0;
                visayashospitaltr2d = 1;
                visayashospitaltr3d = 0;
                visayashospitaltr4d = 0;
                visayashospitaltr1 = 0;
                visayashospitaltr2 = 1;
                visayashospitaltr3 = 0;
                visayashospitaltr4 = 0;
                pb1x12.Visible = true;
                pb2x12.Visible = false;
            }
            if (hobertshospitaltr3 == 1 && hobertshospitaltrd2 == 1)
            {
                hobertshospitaltrd2 = 0;
                hobertshospitaltr1d = 0;
                hobertshospitaltr2d = 1;
                hobertshospitaltr3d = 0;
                hobertshospitaltr4d = 0;
                hobertshospitaltr1 = 0;
                hobertshospitaltr2 = 1;
                hobertshospitaltr3 = 0;
                hobertshospitaltr4 = 0;
                pb1x13.Visible = true;
                pb2x13.Visible = false;
            }
            if (heartshospitaltr3 == 1 && heartshospitaltrd2 == 1)
            {
                heartshospitaltrd2 = 0;
                heartshospitaltr1d = 0;
                heartshospitaltr2d = 1;
                heartshospitaltr3d = 0;
                heartshospitaltr4d = 0;
                heartshospitaltr1 = 0;
                heartshospitaltr2 = 1;
                heartshospitaltr3 = 0;
                heartshospitaltr4 = 0;
                pb1x14.Visible = true;
                pb2x14.Visible = false;

            }

            if (internshospitaltr3 == 1 && internshospitaltrd2 == 1)
            {
                internshospitaltrd2 = 0;
                internshospitaltr1d = 0;
                internshospitaltr2d = 1;
                internshospitaltr3d = 0;
                internshospitaltr4d = 0;
                internshospitaltr1 = 0;
                internshospitaltr2 = 1;
                internshospitaltr3 = 0;
                internshospitaltr4 = 0;
                pb1x15.Visible = true;
                pb2x15.Visible = false;



            }
            if (nationalhealthhospitaltr3 == 1 && nationalhealthhospitaltrd2 == 1)
            {
                nationalhealthhospitaltrd2 = 0;
                nationalhealthhospitaltr1d = 0;
                nationalhealthhospitaltr2d = 1;
                nationalhealthhospitaltr3d = 0;
                nationalhealthhospitaltr4d = 0;
                nationalhealthhospitaltr1 = 0;
                nationalhealthhospitaltr2 = 1;
                nationalhealthhospitaltr3 = 0;
                nationalhealthhospitaltr4 = 0;
                pb1x16.Visible = true;
                pb2x16.Visible = false;
            }
            if (veteranshospitaltr3 == 1 && veteranshospitaltrd2 == 1)
            {
                veteranshospitaltrd2 = 0;
                veteranshospitaltr1d = 0;
                veteranshospitaltr2d = 1;
                veteranshospitaltr3d = 0;
                veteranshospitaltr4d = 0;
                veteranshospitaltr1 = 0;
                veteranshospitaltr2 = 1;
                veteranshospitaltr3 = 0;
                veteranshospitaltr4 = 0;
                pb1x17.Visible = true;
                pb2x17.Visible = false;
            }

            if (pearlmalltr3 == 1 && pearlmalltrd2 == 1)
            {
                pearlmalltrd2 = 0;
                pearlmalltr1d = 0;
                pearlmalltr2d = 1;
                pearlmalltr3d = 0;
                pearlmalltr4d = 0;
                pearlmalltr1 = 0;
                pearlmalltr2 = 1;
                pearlmalltr3 = 0;
                pearlmalltr4 = 0;
                pb1x18.Visible = true;
                pb2x18.Visible = false;
            }
            if (megamalltr3 == 1 && megamalltrd2 == 1)
            {
                megamalltrd2 = 0;
                megamalltr1d = 0;
                megamalltr2d = 1;
                megamalltr3d = 0;
                megamalltr4d = 0;
                megamalltr1 = 0;
                megamalltr2 = 1;
                megamalltr3 = 0;
                megamalltr4 = 0;
                pb1x19.Visible = true;
                pb2x19.Visible = false;
            }
            if (articmalltr3 == 1 && articmalltrd2 == 1)
            {
                articmalltrd2 = 0;
                articmalltr1d = 0;
                articmalltr2d = 1;
                articmalltr3d = 0;
                articmalltr4d = 0;
                articmalltr1 = 0;
                articmalltr2 = 1;
                articmalltr3 = 0;
                articmalltr4 = 0;
                pb1x20.Visible = true;
                pb2x20.Visible = false;
            }

            if (heavenlymalltr3 == 1 && heavenlymalltrd2 == 1)
            {
                heavenlymalltrd2 = 0;
                heavenlymalltr1d = 0;
                heavenlymalltr2d = 1;
                heavenlymalltr3d = 0;
                heavenlymalltr4d = 0;
                heavenlymalltr1 = 0;
                heavenlymalltr2 = 1;
                heavenlymalltr3 = 0;
                heavenlymalltr4 = 0;
                pb1x21.Visible = true;
                pb2x21.Visible = false;
            }
            if (shangrillamalltr3 == 1 && shangrillamalltrd2 == 1)
            {
                shangrillamalltrd2 = 0;
                shangrillamalltr1d = 0;
                shangrillamalltr2d = 1;
                shangrillamalltr3d = 0;
                shangrillamalltr4d = 0;
                shangrillamalltr1 = 0;
                shangrillamalltr2 = 1;
                shangrillamalltr3 = 0;
                shangrillamalltr4 = 0;
                pb1x22.Visible = true;
                pb2x22.Visible = false;
            }

            if (utility3x1tr3 == 1 && utility2x1trd2 == 1)
            {
                utility2x1trd2 = 0;
                utility1x1tr1d = 0;
                utility2x1tr2d = 1;
                utility3x1tr3d = 0;
                utility4x1tr4d = 0;
                utility1x1tr1 = 0;
                utility2x1tr2 = 1;
                utility3x1tr3 = 0;
                utility4x1tr4 = 0;
                pb1x23.Visible = true;
                pb2x23.Visible = false;
            }
            if (utility3x2tr3 == 1 && utility2x2trd2 == 1)
            {
                utility2x2trd2 = 0;
                utility1x2tr1d = 0;
                utility2x2tr2d = 1;
                utility3x2tr3d = 0;
                utility4x2tr4d = 0;
                utility1x2tr1 = 0;
                utility2x2tr2 = 1;
                utility3x2tr3 = 0;
                utility4x2tr4 = 0;

                pb1x24.Visible = true;
                pb2x24.Visible = false;
            }

            if (transportation3x1tr3 == 1 && transportation2x1trd2 == 1)
            {
                transportation2x1trd2 = 0;
                transportation1x1tr1d = 0;
                transportation2x1tr2d = 1;
                transportation3x1tr3d = 0;
                transportation4x1tr4d = 0;
                transportation1x1tr1 = 0;
                transportation2x1tr2 = 1;
                transportation3x1tr3 = 0;
                transportation4x1tr4 = 0;
                pb1x25.Visible = true;
                pb2x25.Visible = false;
            }
            if (transportation3x2tr3 == 1 && transportation2x2trd2 == 1)
            {
                transportation2x2trd2 = 0;
                transportation1x2tr1d = 0;
                transportation2x2tr2d = 1;
                transportation3x2tr3d = 0;
                transportation4x2tr4d = 0;
                transportation1x2tr1 = 0;
                transportation2x2tr2 = 1;
                transportation3x2tr3 = 0;
                transportation4x2tr4 = 0;
                pb1x26.Visible = true;
                pb2x26.Visible = false;
            }
            if (transportation3x3tr3 == 1 && transportation2x3trd2 == 1)
            {
                transportation2x3trd2 = 0;
                transportation1x3tr1d = 0;
                transportation2x3tr2d = 1;
                transportation3x3tr3d = 0;
                transportation4x3tr4d = 0;
                transportation1x3tr1 = 0;
                transportation2x3tr2 = 1;
                transportation3x3tr3 = 0;
                transportation4x3tr4 = 0;
                pb1x27.Visible = true;
                pb2x27.Visible = false;
            }
            if (transportation3x4tr3 == 1 && transportation2x4trd2 == 1)
            {
                transportation2x4trd2 = 0;
                transportation1x4tr1d = 0;
                transportation2x4tr2d = 1;
                transportation3x4tr3d = 0;
                transportation4x4tr4d = 0;
                transportation1x4tr1 = 0;
                transportation2x4tr2 = 1;
                transportation3x4tr3 = 0;
                transportation4x4tr4 = 0;
                pb1x28.Visible = true;
                pb2x28.Visible = false;
            }

        }
        void p3traded3_4()
        {

            //p3 to p4
            if (easternschooltr3 == 1 && easternschooltrd2 == 1)
            {
                easternschooltrd2 = 0;
                easternschooltr1d = 0;
                easternschooltr2d = 0;
                easternschooltr3d = 0;
                easternschooltr4d = 1;
                easternschooltr1 = 0;
                easternschooltr2 = 0;
                easternschooltr3 = 0;
                easternschooltr4 = 1;
                pb1x1.Visible = true;
                pb2x1.Visible = false;


            }
            if (westernschooltr3 == 1 && westernschooltrd2 == 1)
            {
                westernschooltrd2 = 0;
                westernschooltr1d = 0;
                westernschooltr2d = 0;
                westernschooltr3d = 0;
                westernschooltr4d = 1;
                westernschooltr1 = 0;
                westernschooltr2 = 0;
                westernschooltr3 = 0;
                westernschooltr4 = 1;
                pb1x2.Visible = true;
                pb2x2.Visible = false;

            }

            if (visayashighschooltr3 == 1 && visayashighschooltrd2 == 1)
            {
                visayashighschooltrd2 = 0;
                visayashighschooltr1d = 0;
                visayashighschooltr2d = 0;
                visayashighschooltr3d = 0;
                visayashighschooltr4d = 1;
                visayashighschooltr1 = 0;
                visayashighschooltr2 = 0;
                visayashighschooltr3 = 0;
                visayashighschooltr4 = 1;
                pb1x3.Visible = true;
                pb2x3.Visible = false;
            }
            if (southernschooltr3 == 1 && southernschooltrd2 == 1)
            {
                southernschooltrd2 = 0;
                southernschooltr1d = 0;
                southernschooltr2d = 0;
                southernschooltr3d = 0;
                southernschooltr4d = 1;
                southernschooltr1 = 0;
                southernschooltr2 = 0;
                southernschooltr3 = 0;
                southernschooltr4 = 1;
                pb1x4.Visible = true;
                pb2x4.Visible = false;
            }
            if (nationsschooltr3 == 1 && nationsschooltrd2 == 1)
            {
                nationsschooltrd2 = 0;
                nationsschooltr1d = 0;
                nationsschooltr2d = 0;
                nationsschooltr3d = 0;
                nationsschooltr4d = 1;
                nationsschooltr1 = 0;
                nationsschooltr2 = 0;
                nationsschooltr3 = 0;
                nationsschooltr4 = 1;
                pb1x5.Visible = true;
                pb2x5.Visible = false;
            }

            if (westmarkettr3 == 1 && westernschooltrd2 == 1)
            {
                westmarkettrd2 = 0;
                westmarkettr1d = 0;
                westmarkettr2d = 0;
                westmarkettr3d = 0;
                westmarkettr4d = 1;
                westmarkettr1 = 0;
                westmarkettr2 = 0;
                westmarkettr3 = 0;
                westmarkettr4 = 1;
                pb1x6.Visible = true;
                pb2x6.Visible = false;

            }
            if (nightmarkettr3 == 1 && nightmarkettrd2 == 1)
            {
                nightmarkettrd2 = 0;
                nightmarkettr1d = 0;
                nightmarkettr2d = 0;
                nightmarkettr3d = 0;
                nightmarkettr4d = 1;
                nightmarkettr1 = 0;
                nightmarkettr2 = 0;
                nightmarkettr3 = 0;
                nightmarkettr4 = 1;
                pb1x7.Visible = true;
                pb2x7.Visible = false;
            }
            if (daymarkettr3 == 1 && daymarkettrd2 == 1)
            {
                daymarkettrd2 = 0;
                daymarkettr1d = 0;
                daymarkettr2d = 0;
                daymarkettr3d = 0;
                daymarkettr4d = 1;
                daymarkettr1 = 0;
                daymarkettr2 = 0;
                daymarkettr3 = 0;
                daymarkettr4 = 1;
                pb1x8.Visible = true;
                pb2x8.Visible = false;
            }

            if (starmarkettr3 == 1 && starmarkettrd2 == 1)
            {
                starmarkettrd2 = 0;
                starmarkettr1d = 0;
                starmarkettr2d = 0;
                starmarkettr3d = 0;
                starmarkettr4d = 1;
                starmarkettr1 = 0;
                starmarkettr2 = 0;
                starmarkettr3 = 0;
                starmarkettr4 = 1;
                pb1x9.Visible = true;
                pb2x9.Visible = false;
            }
            if (moonmarkettr3 == 1 && moonmarkettrd2 == 1)
            {
                moonmarkettrd2 = 0;
                moonmarkettr1d = 0;
                moonmarkettr2d = 0;
                moonmarkettr3d = 0;
                moonmarkettr4d = 1;
                moonmarkettr1 = 0;
                moonmarkettr2 = 0;
                moonmarkettr3 = 0;
                moonmarkettr4 = 1;
                pb1x10.Visible = true;
                pb2x10.Visible = false;
            }
            if (megamarkettr3 == 1 && megamarkettrd2 == 1)
            {
                megamarkettrd2 = 0;
                megamarkettr1d = 0;
                megamarkettr2d = 0;
                megamarkettr3d = 0;
                megamarkettr4d = 1;
                megamarkettr1 = 0;
                megamarkettr2 = 0;
                megamarkettr3 = 0;
                megamarkettr4 = 1;
                pb1x11.Visible = true;
                pb2x11.Visible = false;
            }

            if (visayashospitaltr3 == 1 && visayashospitaltrd2 == 1)
            {
                visayashospitaltrd2 = 0;
                visayashospitaltr1d = 0;
                visayashospitaltr2d = 0;
                visayashospitaltr3d = 0;
                visayashospitaltr4d = 1;
                visayashospitaltr1 = 0;
                visayashospitaltr2 = 0;
                visayashospitaltr3 = 0;
                visayashospitaltr4 = 1;
                pb1x12.Visible = true;
                pb2x12.Visible = false;
            }
            if (hobertshospitaltr3 == 1 && hobertshospitaltrd2 == 1)
            {
                hobertshospitaltrd2 = 0;
                hobertshospitaltr1d = 0;
                hobertshospitaltr2d = 0;
                hobertshospitaltr3d = 0;
                hobertshospitaltr4d = 1;
                hobertshospitaltr1 = 0;
                hobertshospitaltr2 = 0;
                hobertshospitaltr3 = 0;
                hobertshospitaltr4 = 1;
                pb1x13.Visible = true;
                pb2x13.Visible = false;
            }
            if (heartshospitaltr3 == 1 && heartshospitaltrd2 == 1)
            {
                heartshospitaltrd2 = 0;
                heartshospitaltr1d = 0;
                heartshospitaltr2d = 0;
                heartshospitaltr3d = 0;
                heartshospitaltr4d = 1;
                heartshospitaltr1 = 0;
                heartshospitaltr2 = 0;
                heartshospitaltr3 = 0;
                heartshospitaltr4 = 1;
                pb1x14.Visible = true;
                pb2x14.Visible = false;

            }

            if (internshospitaltr3 == 1 && internshospitaltrd2 == 1)
            {
                internshospitaltrd2 = 0;
                internshospitaltr1d = 0;
                internshospitaltr2d = 0;
                internshospitaltr3d = 0;
                internshospitaltr4d = 1;
                internshospitaltr1 = 0;
                internshospitaltr2 = 0;
                internshospitaltr3 = 0;
                internshospitaltr4 = 1;
                pb1x15.Visible = true;
                pb2x15.Visible = false;



            }
            if (nationalhealthhospitaltr3 == 1 && nationalhealthhospitaltrd2 == 1)
            {
                nationalhealthhospitaltrd2 = 0;
                nationalhealthhospitaltr1d = 0;
                nationalhealthhospitaltr2d = 0;
                nationalhealthhospitaltr3d = 0;
                nationalhealthhospitaltr4d = 1;
                nationalhealthhospitaltr1 = 0;
                nationalhealthhospitaltr2 = 0;
                nationalhealthhospitaltr3 = 0;
                nationalhealthhospitaltr4 = 1;
                pb1x16.Visible = true;
                pb2x16.Visible = false;
            }
            if (veteranshospitaltr3 == 1 && veteranshospitaltrd2 == 1)
            {
                veteranshospitaltrd2 = 0;
                veteranshospitaltr1d = 0;
                veteranshospitaltr2d = 0;
                veteranshospitaltr3d = 0;
                veteranshospitaltr4d = 1;
                veteranshospitaltr1 = 0;
                veteranshospitaltr2 = 0;
                veteranshospitaltr3 = 0;
                veteranshospitaltr4 = 1;
                pb1x17.Visible = true;
                pb2x17.Visible = false;
            }

            if (pearlmalltr3 == 1 && pearlmalltrd2 == 1)
            {
                pearlmalltrd2 = 0;
                pearlmalltr1d = 0;
                pearlmalltr2d = 0;
                pearlmalltr3d = 0;
                pearlmalltr4d = 1;
                pearlmalltr1 = 0;
                pearlmalltr2 = 0;
                pearlmalltr3 = 0;
                pearlmalltr4 = 1;
                pb1x18.Visible = true;
                pb2x18.Visible = false;
            }
            if (megamalltr3 == 1 && megamalltrd2 == 1)
            {
                megamalltrd2 = 0;
                megamalltr1d = 0;
                megamalltr2d = 0;
                megamalltr3d = 0;
                megamalltr4d = 1;
                megamalltr1 = 0;
                megamalltr2 = 0;
                megamalltr3 = 0;
                megamalltr4 = 1;
                pb1x19.Visible = true;
                pb2x19.Visible = false;
            }
            if (articmalltr3 == 1 && articmalltrd2 == 1)
            {
                articmalltrd2 = 0;
                articmalltr1d = 0;
                articmalltr2d = 0;
                articmalltr3d = 0;
                articmalltr4d = 1;
                articmalltr1 = 0;
                articmalltr2 = 0;
                articmalltr3 = 0;
                articmalltr4 = 1;
                pb1x20.Visible = true;
                pb2x20.Visible = false;
            }

            if (heavenlymalltr3 == 1 && heavenlymalltrd2 == 1)
            {
                heavenlymalltrd2 = 0;
                heavenlymalltr1d = 0;
                heavenlymalltr2d = 0;
                heavenlymalltr3d = 0;
                heavenlymalltr4d = 1;
                heavenlymalltr1 = 0;
                heavenlymalltr2 = 0;
                heavenlymalltr3 = 0;
                heavenlymalltr4 = 1;
                pb1x21.Visible = true;
                pb2x21.Visible = false;
            }
            if (shangrillamalltr3 == 1 && shangrillamalltrd2 == 1)
            {
                shangrillamalltrd2 = 0;
                shangrillamalltr1d = 0;
                shangrillamalltr2d = 0;
                shangrillamalltr3d = 0;
                shangrillamalltr4d = 1;
                shangrillamalltr1 = 0;
                shangrillamalltr2 = 0;
                shangrillamalltr3 = 0;
                shangrillamalltr4 = 1;
                pb1x22.Visible = true;
                pb2x22.Visible = false;
            }

            if (utility3x1tr3 == 1 && utility2x1trd2 == 1)
            {
                utility2x1trd2 = 0;
                utility1x1tr1d = 0;
                utility2x1tr2d = 0;
                utility3x1tr3d = 0;
                utility4x1tr4d = 1;
                utility1x1tr1 = 0;
                utility2x1tr2 = 0;
                utility3x1tr3 = 0;
                utility4x1tr4 = 1;
                pb1x23.Visible = true;
                pb2x23.Visible = false;
            }
            if (utility3x2tr3 == 1 && utility2x2trd2 == 1)
            {
                utility2x2trd2 = 0;
                utility1x2tr1d = 0;
                utility2x2tr2d = 0;
                utility3x2tr3d = 0;
                utility4x2tr4d = 1;
                utility1x2tr1 = 0;
                utility2x2tr2 = 0;
                utility3x2tr3 = 0;
                utility4x2tr4 = 1;
                pb1x24.Visible = true;
                pb2x24.Visible = false;
            }

            if (transportation3x1tr3 == 1 && transportation2x1trd2 == 1)
            {
                transportation2x1trd2 = 0;
                transportation1x1tr1d = 0;
                transportation2x1tr2d = 0;
                transportation3x1tr3d = 0;
                transportation4x1tr4d = 1;
                transportation1x1tr1 = 0;
                transportation2x1tr2 = 0;
                transportation3x1tr3 = 0;
                transportation4x1tr4 = 1;
                pb1x25.Visible = true;
                pb2x25.Visible = false;
            }
            if (transportation3x2tr3 == 1 && transportation2x2trd2 == 1)
            {
                transportation2x2trd2 = 0;
                transportation1x2tr1d = 0;
                transportation2x2tr2d = 0;
                transportation3x2tr3d = 0;
                transportation4x2tr4d = 1;
                transportation1x2tr1 = 0;
                transportation2x2tr2 = 0;
                transportation3x2tr3 = 0;
                transportation4x2tr4 = 1;
                pb1x26.Visible = true;
                pb2x26.Visible = false;
            }
            if (transportation3x3tr3 == 1 && transportation2x3trd2 == 1)
            {
                transportation2x3trd2 = 0;
                transportation1x3tr1d = 0;
                transportation2x3tr2d = 0;
                transportation3x3tr3d = 0;
                transportation4x3tr4d = 1;
                transportation1x3tr1 = 0;
                transportation2x3tr2 = 0;
                transportation3x3tr3 = 0;
                transportation4x3tr4 = 1;
                pb1x27.Visible = true;
                pb2x27.Visible = false;
            }
            if (transportation3x4tr3 == 1 && transportation2x4trd2 == 1)
            {
                transportation2x4trd2 = 0;
                transportation1x4tr1d = 0;
                transportation2x4tr2d = 0;
                transportation3x4tr3d = 0;
                transportation4x4tr4d = 1;
                transportation1x4tr1 = 0;
                transportation2x4tr2 = 0;
                transportation3x4tr3 = 0;
                transportation4x4tr4 = 1;
                pb1x28.Visible = true;
                pb2x28.Visible = false;
            }


        }
        void p4traded4()
        {
            if (easternschooltr4 == 1 && easternschooltrd2 == 1)
            {
                easternschooltrd2 = 0;
                easternschooltr1d = 1;
                easternschooltr2d = 0;
                easternschooltr3d = 0;
                easternschooltr4d = 0;
                easternschooltr1 = 1;
                easternschooltr2 = 0;
                easternschooltr3 = 0;
                easternschooltr4 = 0;
                pb1x1.Visible = true;
                pb2x1.Visible = false;


            }
            if (westernschooltr4 == 1 && westernschooltrd2 == 1)
            {
                westernschooltrd2 = 0;
                westernschooltr1d = 1;
                westernschooltr2d = 0;
                westernschooltr3d = 0;
                westernschooltr4d = 0;
                westernschooltr1 = 1;
                westernschooltr2 = 0;
                westernschooltr3 = 0;
                westernschooltr4 = 0;
                pb1x2.Visible = true;
                pb2x2.Visible = false;

            }

            if (visayashighschooltr4 == 1 && visayashighschooltrd2 == 1)
            {
                visayashighschooltrd2 = 0;
                visayashighschooltr1d = 1;
                visayashighschooltr2d = 0;
                visayashighschooltr3d = 0;
                visayashighschooltr4d = 0;
                visayashighschooltr1 = 1;
                visayashighschooltr2 = 0;
                visayashighschooltr3 = 0;
                visayashighschooltr4 = 0;
                pb1x3.Visible = true;
                pb2x3.Visible = false;
            }
            if (southernschooltr4 == 1 && southernschooltrd2 == 1)
            {
                southernschooltrd2 = 0;
                southernschooltr1d = 1;
                southernschooltr2d = 0;
                southernschooltr3d = 0;
                southernschooltr4d = 0;
                southernschooltr1 = 1;
                southernschooltr2 = 0;
                southernschooltr3 = 0;
                southernschooltr4 = 0;
                pb1x4.Visible = true;
                pb2x4.Visible = false;
            }
            if (nationsschooltr4 == 1 && nationsschooltrd2 == 1)
            {
                nationsschooltrd2 = 0;
                nationsschooltr1d = 1;
                nationsschooltr2d = 0;
                nationsschooltr3d = 0;
                nationsschooltr4d = 0;
                nationsschooltr1 = 1;
                nationsschooltr2 = 0;
                nationsschooltr3 = 0;
                nationsschooltr4 = 0;
                pb1x5.Visible = true;
                pb2x5.Visible = false;
            }

            if (westmarkettr4 == 1 && westernschooltrd2 == 1)
            {
                westmarkettrd2 = 0;
                westmarkettr1d = 0;
                westmarkettr2d = 0;
                westmarkettr3d = 0;
                westmarkettr4d = 1;
                westmarkettr1 = 1;
                westmarkettr2 = 0;
                westmarkettr3 = 0;
                westmarkettr4 = 0;
                pb1x6.Visible = true;
                pb2x6.Visible = false;

            }
            if (nightmarkettr4 == 1 && nightmarkettrd2 == 1)
            {
                nightmarkettrd2 = 0;
                nightmarkettr1d = 1;
                nightmarkettr2d = 0;
                nightmarkettr3d = 0;
                nightmarkettr4d = 0;
                nightmarkettr1 = 1;
                nightmarkettr2 = 0;
                nightmarkettr3 = 0;
                nightmarkettr4 = 0;
                pb1x7.Visible = true;
                pb2x7.Visible = false;
            }
            if (daymarkettr4 == 1 && daymarkettrd2 == 1)
            {
                daymarkettrd2 = 0;
                daymarkettr1d = 1;
                daymarkettr2d = 0;
                daymarkettr3d = 0;
                daymarkettr4d = 0;
                daymarkettr1 = 1;
                daymarkettr2 = 0;
                daymarkettr3 = 0;
                daymarkettr4 = 0;
                pb1x8.Visible = true;
                pb2x8.Visible = false;
            }

            if (starmarkettr4 == 1 && starmarkettrd2 == 1)
            {
                starmarkettrd2 = 0;
                starmarkettr1d = 1;
                starmarkettr2d = 0;
                starmarkettr3d = 0;
                starmarkettr4d = 0;
                starmarkettr1 = 1;
                starmarkettr2 = 0;
                starmarkettr3 = 0;
                starmarkettr4 = 0;
                pb1x9.Visible = true;
                pb2x9.Visible = false;
            }
            if (moonmarkettr4 == 1 && moonmarkettrd2 == 1)
            {
                moonmarkettrd2 = 0;
                moonmarkettr1d = 1;
                moonmarkettr2d = 0;
                moonmarkettr3d = 0;
                moonmarkettr4d = 0;
                moonmarkettr1 = 1;
                moonmarkettr2 = 0;
                moonmarkettr3 = 0;
                moonmarkettr4 = 0;
                pb1x10.Visible = true;
                pb2x10.Visible = false;
            }
            if (megamarkettr4 == 1 && megamarkettrd2 == 1)
            {
                megamarkettrd2 = 0;
                megamarkettr1d = 1;
                megamarkettr2d = 0;
                megamarkettr3d = 0;
                megamarkettr4d = 0;
                megamarkettr1 = 1;
                megamarkettr2 = 0;
                megamarkettr3 = 0;
                megamarkettr4 = 0;
                pb1x11.Visible = true;
                pb2x11.Visible = false;
            }

            if (visayashospitaltr4 == 1 && visayashospitaltrd2 == 1)
            {
                visayashospitaltrd2 = 0;
                visayashospitaltr1d = 1;
                visayashospitaltr2d = 0;
                visayashospitaltr3d = 0;
                visayashospitaltr4d = 0;
                visayashospitaltr1 = 1;
                visayashospitaltr2 = 0;
                visayashospitaltr3 = 0;
                visayashospitaltr4 = 0;
                pb1x12.Visible = true;
                pb2x12.Visible = false;
            }
            if (hobertshospitaltr4 == 1 && hobertshospitaltrd2 == 1)
            {
                hobertshospitaltrd2 = 0;
                hobertshospitaltr1d = 1;
                hobertshospitaltr2d = 0;
                hobertshospitaltr3d = 0;
                hobertshospitaltr4d = 0;
                hobertshospitaltr1 = 1;
                hobertshospitaltr2 = 0;
                hobertshospitaltr3 = 0;
                hobertshospitaltr4 = 0;
                pb1x13.Visible = true;
                pb2x13.Visible = false;
            }
            if (heartshospitaltr4 == 1 && heartshospitaltrd2 == 1)
            {
                heartshospitaltrd2 = 0;
                heartshospitaltr1d = 1;
                heartshospitaltr2d = 0;
                heartshospitaltr3d = 0;
                heartshospitaltr4d = 0;
                heartshospitaltr1 = 1;
                heartshospitaltr2 = 0;
                heartshospitaltr3 = 0;
                heartshospitaltr4 = 0;
                pb1x14.Visible = true;
                pb2x14.Visible = false;

            }

            if (internshospitaltr4 == 1 && internshospitaltrd2 == 1)
            {
                internshospitaltrd2 = 0;
                internshospitaltr1d = 1;
                internshospitaltr2d = 0;
                internshospitaltr3d = 0;
                internshospitaltr4d = 0;
                internshospitaltr1 = 1;
                internshospitaltr2 = 0;
                internshospitaltr3 = 0;
                internshospitaltr4 = 0;
                pb1x15.Visible = true;
                pb2x15.Visible = false;



            }
            if (nationalhealthhospitaltr4 == 1 && nationalhealthhospitaltrd2 == 1)
            {
                nationalhealthhospitaltrd2 = 0;
                nationalhealthhospitaltr1d = 1;
                nationalhealthhospitaltr2d = 0;
                nationalhealthhospitaltr3d = 0;
                nationalhealthhospitaltr4d = 0;
                nationalhealthhospitaltr1 = 1;
                nationalhealthhospitaltr2 = 0;
                nationalhealthhospitaltr3 = 0;
                nationalhealthhospitaltr4 = 0;
                pb1x16.Visible = true;
                pb2x16.Visible = false;
            }
            if (veteranshospitaltr4 == 1 && veteranshospitaltrd2 == 1)
            {
                veteranshospitaltrd2 = 0;
                veteranshospitaltr1d = 1;
                veteranshospitaltr2d = 0;
                veteranshospitaltr3d = 0;
                veteranshospitaltr4d = 0;
                veteranshospitaltr1 = 1;
                veteranshospitaltr2 = 0;
                veteranshospitaltr3 = 0;
                veteranshospitaltr4 = 0;
                pb1x17.Visible = true;
                pb2x17.Visible = false;
            }

            if (pearlmalltr4 == 1 && pearlmalltrd2 == 1)
            {
                pearlmalltrd2 = 0;
                pearlmalltr1d = 1;
                pearlmalltr2d = 0;
                pearlmalltr3d = 0;
                pearlmalltr4d = 0;
                pearlmalltr1 = 1;
                pearlmalltr2 = 0;
                pearlmalltr3 = 0;
                pearlmalltr4 = 0;
                pb1x18.Visible = true;
                pb2x18.Visible = false;
            }
            if (megamalltr4 == 1 && megamalltrd2 == 1)
            {
                megamalltrd2 = 0;
                megamalltr1d = 1;
                megamalltr2d = 0;
                megamalltr3d = 0;
                megamalltr4d = 0;
                megamalltr1 = 1;
                megamalltr2 = 0;
                megamalltr3 = 0;
                megamalltr4 = 0;
                pb1x19.Visible = true;
                pb2x19.Visible = false;
            }
            if (articmalltr4 == 1 && articmalltrd2 == 1)
            {
                articmalltrd2 = 0;
                articmalltr1d = 1;
                articmalltr2d = 0;
                articmalltr3d = 0;
                articmalltr4d = 0;
                articmalltr1 = 1;
                articmalltr2 = 0;
                articmalltr3 = 0;
                articmalltr4 = 0;
                pb1x20.Visible = true;
                pb2x20.Visible = false;
            }

            if (heavenlymalltr4 == 1 && heavenlymalltrd2 == 1)
            {
                heavenlymalltrd2 = 0;
                heavenlymalltr1d = 1;
                heavenlymalltr2d = 0;
                heavenlymalltr3d = 0;
                heavenlymalltr4d = 0;
                heavenlymalltr1 = 1;
                heavenlymalltr2 = 0;
                heavenlymalltr3 = 0;
                heavenlymalltr4 = 0;
                pb1x21.Visible = true;
                pb2x21.Visible = false;
            }
            if (shangrillamalltr4 == 1 && shangrillamalltrd2 == 1)
            {
                shangrillamalltrd2 = 0;
                shangrillamalltr1d = 1;
                shangrillamalltr2d = 0;
                shangrillamalltr3d = 0;
                shangrillamalltr4d = 0;
                shangrillamalltr1 = 1;
                shangrillamalltr2 = 0;
                shangrillamalltr3 = 0;
                shangrillamalltr4 = 0;
                pb1x22.Visible = true;
                pb2x22.Visible = false;
            }

            if (utility4x1tr4 == 1 && utility2x1trd2 == 1)
            {
                utility2x1trd2 = 0;
                utility1x1tr1d = 1;
                utility2x1tr2d = 0;
                utility3x1tr3d = 0;
                utility4x1tr4d = 0;
                utility1x1tr1 = 1;
                utility2x1tr2 = 0;
                utility3x1tr3 = 0;
                utility4x1tr4 = 0;
                pb1x23.Visible = true;
                pb2x23.Visible = false;
            }
            if (utility4x2tr4 == 1 && utility2x2trd2 == 1)
            {
                utility2x2trd2 = 0;
                utility1x2tr1d = 1;
                utility2x2tr2d = 0;
                utility3x2tr3d = 0;
                utility4x2tr4d = 0;
                utility1x2tr1 = 1;
                utility2x2tr2 = 0;
                utility3x2tr3 = 0;
                utility4x2tr4 = 0;

                pb1x24.Visible = true;
                pb2x24.Visible = false;
            }

            if (transportation4x1tr4 == 1 && transportation2x1trd2 == 1)
            {
                transportation2x1trd2 = 0;
                transportation1x1tr1d = 1;
                transportation2x1tr2d = 0;
                transportation3x1tr3d = 0;
                transportation4x1tr4d = 0;
                transportation1x1tr1 = 1;
                transportation2x1tr2 = 0;
                transportation3x1tr3 = 0;
                transportation4x1tr4 = 0;
                pb1x25.Visible = true;
                pb2x25.Visible = false;
            }
            if (transportation4x2tr4 == 1 && transportation2x2trd2 == 1)
            {
                transportation2x2trd2 = 0;
                transportation1x2tr1d = 1;
                transportation2x2tr2d = 0;
                transportation3x2tr3d = 0;
                transportation4x2tr4d = 0;
                transportation1x2tr1 = 1;
                transportation2x2tr2 = 0;
                transportation3x2tr3 = 0;
                transportation4x2tr4 = 0;
                pb1x26.Visible = true;
                pb2x26.Visible = false;
            }
            if (transportation4x3tr4 == 1 && transportation2x3trd2 == 1)
            {
                transportation2x3trd2 = 0;
                transportation1x3tr1d = 1;
                transportation2x3tr2d = 0;
                transportation3x3tr3d = 0;
                transportation4x3tr4d = 0;
                transportation1x3tr1 = 1;
                transportation2x3tr2 = 0;
                transportation3x3tr3 = 0;
                transportation4x3tr4 = 0;
                pb1x27.Visible = true;
                pb2x27.Visible = false;
            }
            if (transportation4x4tr4 == 1 && transportation2x4trd2 == 1)
            {
                transportation2x4trd2 = 0;
                transportation1x4tr1d = 1;
                transportation2x4tr2d = 0;
                transportation3x4tr3d = 0;
                transportation4x4tr4d = 0;
                transportation1x4tr1 = 1;
                transportation2x4tr2 = 0;
                transportation3x4tr3 = 0;
                transportation4x4tr4 = 0;
                pb1x28.Visible = true;
                pb2x28.Visible = false;
            }


        }
        void p4traded4_2()
        {
            //p4 to p2
            if (easternschooltr4 == 1 && easternschooltrd2 == 1)
            {
                easternschooltrd2 = 0;
                easternschooltr1d = 0;
                easternschooltr2d = 1;
                easternschooltr3d = 0;
                easternschooltr4d = 0;
                easternschooltr1 = 0;
                easternschooltr2 = 1;
                easternschooltr3 = 0;
                easternschooltr4 = 0;
                pb1x1.Visible = true;
                pb2x1.Visible = false;


            }
            if (westernschooltr4 == 1 && westernschooltrd2 == 1)
            {
                westernschooltrd2 = 0;
                westernschooltr1d = 0;
                westernschooltr2d = 1;
                westernschooltr3d = 0;
                westernschooltr4d = 0;
                westernschooltr1 = 0;
                westernschooltr2 = 1;
                westernschooltr3 = 0;
                westernschooltr4 = 0;
                pb1x2.Visible = true;
                pb2x2.Visible = false;

            }

            if (visayashighschooltr4 == 1 && visayashighschooltrd2 == 1)
            {
                visayashighschooltrd2 = 0;
                visayashighschooltr1d = 0;
                visayashighschooltr2d = 1;
                visayashighschooltr3d = 0;
                visayashighschooltr4d = 0;
                visayashighschooltr1 = 0;
                visayashighschooltr2 = 1;
                visayashighschooltr3 = 0;
                visayashighschooltr4 = 0;
                pb1x3.Visible = true;
                pb2x3.Visible = false;
            }
            if (southernschooltr4 == 1 && southernschooltrd2 == 1)
            {
                southernschooltrd2 = 0;
                southernschooltr1d = 0;
                southernschooltr2d = 1;
                southernschooltr3d = 0;
                southernschooltr4d = 0;
                southernschooltr1 = 0;
                southernschooltr2 = 1;
                southernschooltr3 = 0;
                southernschooltr4 = 0;
                pb1x4.Visible = true;
                pb2x4.Visible = false;
            }
            if (nationsschooltr4 == 1 && nationsschooltrd2 == 1)
            {
                nationsschooltrd2 = 0;
                nationsschooltr1d = 0;
                nationsschooltr2d = 1;
                nationsschooltr3d = 0;
                nationsschooltr4d = 0;
                nationsschooltr1 = 0;
                nationsschooltr2 = 1;
                nationsschooltr3 = 0;
                nationsschooltr4 = 0;
                pb1x5.Visible = true;
                pb2x5.Visible = false;
            }

            if (westmarkettr4 == 1 && westernschooltrd2 == 1)
            {
                westmarkettrd2 = 0;
                westmarkettr1d = 0;
                westmarkettr2d = 1;
                westmarkettr3d = 0;
                westmarkettr4d = 0;
                westmarkettr1 = 0;
                westmarkettr2 = 1;
                westmarkettr3 = 0;
                westmarkettr4 = 0;
                pb1x6.Visible = true;
                pb2x6.Visible = false;

            }
            if (nightmarkettr4 == 1 && nightmarkettrd2 == 1)
            {
                nightmarkettrd2 = 0;
                nightmarkettr1d = 0;
                nightmarkettr2d = 1;
                nightmarkettr3d = 0;
                nightmarkettr4d = 0;
                nightmarkettr1 = 0;
                nightmarkettr2 = 1;
                nightmarkettr3 = 0;
                nightmarkettr4 = 0;
                pb1x7.Visible = true;
                pb2x7.Visible = false;
            }
            if (daymarkettr4 == 1 && daymarkettrd2 == 1)
            {
                daymarkettrd2 = 0;
                daymarkettr1d = 0;
                daymarkettr2d = 1;
                daymarkettr3d = 0;
                daymarkettr4d = 0;
                daymarkettr1 = 0;
                daymarkettr2 = 1;
                daymarkettr3 = 0;
                daymarkettr4 = 0;
                pb1x8.Visible = true;
                pb2x8.Visible = false;
            }

            if (starmarkettr4 == 1 && starmarkettrd2 == 1)
            {
                starmarkettrd2 = 0;
                starmarkettr1d = 0;
                starmarkettr2d = 1;
                starmarkettr3d = 0;
                starmarkettr4d = 0;
                starmarkettr1 = 0;
                starmarkettr2 = 1;
                starmarkettr3 = 0;
                starmarkettr4 = 0;
                pb1x9.Visible = true;
                pb2x9.Visible = false;
            }
            if (moonmarkettr4 == 1 && moonmarkettrd2 == 1)
            {
                moonmarkettrd2 = 0;
                moonmarkettr1d = 0;
                moonmarkettr2d = 1;
                moonmarkettr3d = 0;
                moonmarkettr4d = 0;
                moonmarkettr1 = 0;
                moonmarkettr2 = 1;
                moonmarkettr3 = 0;
                moonmarkettr4 = 0;
                pb1x10.Visible = true;
                pb2x10.Visible = false;
            }
            if (megamarkettr4 == 1 && megamarkettrd2 == 1)
            {
                megamarkettrd2 = 0;
                megamarkettr1d = 0;
                megamarkettr2d = 1;
                megamarkettr3d = 0;
                megamarkettr4d = 0;
                megamarkettr1 = 0;
                megamarkettr2 = 1;
                megamarkettr3 = 0;
                megamarkettr4 = 0;
                pb1x11.Visible = true;
                pb2x11.Visible = false;
            }

            if (visayashospitaltr4 == 1 && visayashospitaltrd2 == 1)
            {
                visayashospitaltrd2 = 0;
                visayashospitaltr1d = 0;
                visayashospitaltr2d = 1;
                visayashospitaltr3d = 0;
                visayashospitaltr4d = 0;
                visayashospitaltr1 = 0;
                visayashospitaltr2 = 1;
                visayashospitaltr3 = 0;
                visayashospitaltr4 = 0;
                pb1x12.Visible = true;
                pb2x12.Visible = false;
            }
            if (hobertshospitaltr4 == 1 && hobertshospitaltrd2 == 1)
            {
                hobertshospitaltrd2 = 0;
                hobertshospitaltr1d = 0;
                hobertshospitaltr2d = 1;
                hobertshospitaltr3d = 0;
                hobertshospitaltr4d = 0;
                hobertshospitaltr1 = 0;
                hobertshospitaltr2 = 1;
                hobertshospitaltr3 = 0;
                hobertshospitaltr4 = 0;
                pb1x13.Visible = true;
                pb2x13.Visible = false;
            }
            if (heartshospitaltr4 == 1 && heartshospitaltrd2 == 1)
            {
                heartshospitaltrd2 = 0;
                heartshospitaltr1d = 0;
                heartshospitaltr2d = 1;
                heartshospitaltr3d = 0;
                heartshospitaltr4d = 0;
                heartshospitaltr1 = 0;
                heartshospitaltr2 = 1;
                heartshospitaltr3 = 0;
                heartshospitaltr4 = 0;
                pb1x14.Visible = true;
                pb2x14.Visible = false;

            }

            if (internshospitaltr4 == 1 && internshospitaltrd2 == 1)
            {
                internshospitaltrd2 = 0;
                internshospitaltr1d = 0;
                internshospitaltr2d = 1;
                internshospitaltr3d = 0;
                internshospitaltr4d = 0;
                internshospitaltr1 = 0;
                internshospitaltr2 = 1;
                internshospitaltr3 = 0;
                internshospitaltr4 = 0;
                pb1x15.Visible = true;
                pb2x15.Visible = false;



            }
            if (nationalhealthhospitaltr4 == 1 && nationalhealthhospitaltrd2 == 1)
            {
                nationalhealthhospitaltrd2 = 0;
                nationalhealthhospitaltr1d = 0;
                nationalhealthhospitaltr2d = 1;
                nationalhealthhospitaltr3d = 0;
                nationalhealthhospitaltr4d = 0;
                nationalhealthhospitaltr1 = 0;
                nationalhealthhospitaltr2 = 1;
                nationalhealthhospitaltr3 = 0;
                nationalhealthhospitaltr4 = 0;
                pb1x16.Visible = true;
                pb2x16.Visible = false;
            }
            if (veteranshospitaltr4 == 1 && veteranshospitaltrd2 == 1)
            {
                veteranshospitaltrd2 = 0;
                veteranshospitaltr1d = 0;
                veteranshospitaltr2d = 1;
                veteranshospitaltr3d = 0;
                veteranshospitaltr4d = 0;
                veteranshospitaltr1 = 0;
                veteranshospitaltr2 = 1;
                veteranshospitaltr3 = 0;
                veteranshospitaltr4 = 0;
                pb1x17.Visible = true;
                pb2x17.Visible = false;
            }

            if (pearlmalltr4 == 1 && pearlmalltrd2 == 1)
            {
                pearlmalltrd2 = 0;
                pearlmalltr1d = 0;
                pearlmalltr2d = 1;
                pearlmalltr3d = 0;
                pearlmalltr4d = 0;
                pearlmalltr1 = 0;
                pearlmalltr2 = 1;
                pearlmalltr3 = 0;
                pearlmalltr4 = 0;
                pb1x18.Visible = true;
                pb2x18.Visible = false;
            }
            if (megamalltr4 == 1 && megamalltrd2 == 1)
            {
                megamalltrd2 = 0;
                megamalltr1d = 0;
                megamalltr2d = 1;
                megamalltr3d = 0;
                megamalltr4d = 0;
                megamalltr1 = 0;
                megamalltr2 = 1;
                megamalltr3 = 0;
                megamalltr4 = 0;
                pb1x19.Visible = true;
                pb2x19.Visible = false;
            }
            if (articmalltr4 == 1 && articmalltrd2 == 1)
            {
                articmalltrd2 = 0;
                articmalltr1d = 0;
                articmalltr2d = 1;
                articmalltr3d = 0;
                articmalltr4d = 0;
                articmalltr1 = 0;
                articmalltr2 = 1;
                articmalltr3 = 0;
                articmalltr4 = 0;
                pb1x20.Visible = true;
                pb2x20.Visible = false;
            }

            if (heavenlymalltr4 == 1 && heavenlymalltrd2 == 1)
            {
                heavenlymalltrd2 = 0;
                heavenlymalltr1d = 0;
                heavenlymalltr2d = 1;
                heavenlymalltr3d = 0;
                heavenlymalltr4d = 0;
                heavenlymalltr1 = 0;
                heavenlymalltr2 = 1;
                heavenlymalltr3 = 0;
                heavenlymalltr4 = 0;
                pb1x21.Visible = true;
                pb2x21.Visible = false;
            }
            if (shangrillamalltr4 == 1 && shangrillamalltrd2 == 1)
            {
                shangrillamalltrd2 = 0;
                shangrillamalltr1d = 0;
                shangrillamalltr2d = 1;
                shangrillamalltr3d = 0;
                shangrillamalltr4d = 0;
                shangrillamalltr1 = 0;
                shangrillamalltr2 = 1;
                shangrillamalltr3 = 0;
                shangrillamalltr4 = 0;
                pb1x22.Visible = true;
                pb2x22.Visible = false;
            }

            if (utility4x1tr4 == 1 && utility2x1trd2 == 1)
            {
                utility2x1trd2 = 0;
                utility1x1tr1d = 0;
                utility2x1tr2d = 1;
                utility3x1tr3d = 0;
                utility4x1tr4d = 0;
                utility1x1tr1 = 0;
                utility2x1tr2 = 1;
                utility3x1tr3 = 0;
                utility4x1tr4 = 0;
                pb1x23.Visible = true;
                pb2x23.Visible = false;
            }
            if (utility4x2tr4 == 1 && utility2x2trd2 == 1)
            {
                utility2x2trd2 = 0;
                utility1x2tr1d = 0;
                utility2x2tr2d = 1;
                utility3x2tr3d = 0;
                utility4x2tr4d = 0;
                utility1x2tr1 = 0;
                utility2x2tr2 = 1;
                utility3x2tr3 = 0;
                utility4x2tr4 = 0;

                pb1x24.Visible = true;
                pb2x24.Visible = false;
            }

            if (transportation4x1tr4 == 1 && transportation2x1trd2 == 1)
            {
                transportation2x1trd2 = 0;
                transportation1x1tr1d = 0;
                transportation2x1tr2d = 1;
                transportation3x1tr3d = 0;
                transportation4x1tr4d = 0;
                transportation1x1tr1 = 0;
                transportation2x1tr2 = 1;
                transportation3x1tr3 = 0;
                transportation4x1tr4 = 0;
                pb1x25.Visible = true;
                pb2x25.Visible = false;
            }
            if (transportation4x2tr4 == 1 && transportation2x2trd2 == 1)
            {
                transportation2x2trd2 = 0;
                transportation1x2tr1d = 0;
                transportation2x2tr2d = 1;
                transportation3x2tr3d = 0;
                transportation4x2tr4d = 0;
                transportation1x2tr1 = 0;
                transportation2x2tr2 = 1;
                transportation3x2tr3 = 0;
                transportation4x2tr4 = 0;
                pb1x26.Visible = true;
                pb2x26.Visible = false;
            }
            if (transportation4x3tr4 == 1 && transportation2x3trd2 == 1)
            {
                transportation2x3trd2 = 0;
                transportation1x3tr1d = 0;
                transportation2x3tr2d = 1;
                transportation3x3tr3d = 0;
                transportation4x3tr4d = 0;
                transportation1x3tr1 = 0;
                transportation2x3tr2 = 1;
                transportation3x3tr3 = 0;
                transportation4x3tr4 = 0;
                pb1x27.Visible = true;
                pb2x27.Visible = false;
            }
            if (transportation4x4tr4 == 1 && transportation2x4trd2 == 1)
            {
                transportation2x4trd2 = 0;
                transportation1x4tr1d = 0;
                transportation2x4tr2d = 1;
                transportation3x4tr3d = 0;
                transportation4x4tr4d = 0;
                transportation1x4tr1 = 0;
                transportation2x4tr2 = 1;
                transportation3x4tr3 = 0;
                transportation4x4tr4 = 0;
                pb1x28.Visible = true;
                pb2x28.Visible = false;
            }

        }
        void p4traded4_3()
        {

            //p4 to p3
            if (easternschooltr4 == 1 && easternschooltrd2 == 1)
            {
                easternschooltrd2 = 0;
                easternschooltr1d = 0;
                easternschooltr2d = 0;
                easternschooltr3d = 1;
                easternschooltr4d = 0;
                easternschooltr1 = 0;
                easternschooltr2 = 0;
                easternschooltr3 = 1;
                easternschooltr4 = 0;
                pb1x1.Visible = true;
                pb2x1.Visible = false;


            }
            if (westernschooltr4 == 1 && westernschooltrd2 == 1)
            {
                westernschooltrd2 = 0;
                westernschooltr1d = 0;
                westernschooltr2d = 0;
                westernschooltr3d = 1;
                westernschooltr4d = 0;
                westernschooltr1 = 0;
                westernschooltr2 = 0;
                westernschooltr3 = 1;
                westernschooltr4 = 0;
                pb1x2.Visible = true;
                pb2x2.Visible = false;

            }

            if (visayashighschooltr4 == 1 && visayashighschooltrd2 == 1)
            {
                visayashighschooltrd2 = 0;
                visayashighschooltr1d = 0;
                visayashighschooltr2d = 0;
                visayashighschooltr3d = 1;
                visayashighschooltr4d = 0;
                visayashighschooltr1 = 0;
                visayashighschooltr2 = 0;
                visayashighschooltr3 = 1;
                visayashighschooltr4 = 0;
                pb1x3.Visible = true;
                pb2x3.Visible = false;
            }
            if (southernschooltr4 == 1 && southernschooltrd2 == 1)
            {
                southernschooltrd2 = 0;
                southernschooltr1d = 0;
                southernschooltr2d = 0;
                southernschooltr3d = 1;
                southernschooltr4d = 0;
                southernschooltr1 = 0;
                southernschooltr2 = 0;
                southernschooltr3 = 1;
                southernschooltr4 = 0;
                pb1x4.Visible = true;
                pb2x4.Visible = false;
            }
            if (nationsschooltr4 == 1 && nationsschooltrd2 == 1)
            {
                nationsschooltrd2 = 0;
                nationsschooltr1d = 0;
                nationsschooltr2d = 0;
                nationsschooltr3d = 1;
                nationsschooltr4d = 0;
                nationsschooltr1 = 0;
                nationsschooltr2 = 0;
                nationsschooltr3 = 1;
                nationsschooltr4 = 0;
                pb1x5.Visible = true;
                pb2x5.Visible = false;
            }

            if (westmarkettr4 == 1 && westernschooltrd2 == 1)
            {
                westmarkettrd2 = 0;
                westmarkettr1d = 0;
                westmarkettr2d = 0;
                westmarkettr3d = 1;
                westmarkettr4d = 0;
                westmarkettr1 = 0;
                westmarkettr2 = 0;
                westmarkettr3 = 1;
                westmarkettr4 = 0;
                pb1x6.Visible = true;
                pb2x6.Visible = false;

            }
            if (nightmarkettr4 == 1 && nightmarkettrd2 == 1)
            {
                nightmarkettrd2 = 0;
                nightmarkettr1d = 0;
                nightmarkettr2d = 0;
                nightmarkettr3d = 1;
                nightmarkettr4d = 0;
                nightmarkettr1 = 0;
                nightmarkettr2 = 0;
                nightmarkettr3 = 1;
                nightmarkettr4 = 0;
                pb1x7.Visible = true;
                pb2x7.Visible = false;
            }
            if (daymarkettr4 == 1 && daymarkettrd2 == 1)
            {
                daymarkettrd2 = 0;
                daymarkettr1d = 0;
                daymarkettr2d = 0;
                daymarkettr3d = 1;
                daymarkettr4d = 0;
                daymarkettr1 = 0;
                daymarkettr2 = 0;
                daymarkettr3 = 1;
                daymarkettr4 = 0;
                pb1x8.Visible = true;
                pb2x8.Visible = false;
            }

            if (starmarkettr4 == 1 && starmarkettrd2 == 1)
            {
                starmarkettrd2 = 0;
                starmarkettr1d = 0;
                starmarkettr2d = 0;
                starmarkettr3d = 1;
                starmarkettr4d = 0;
                starmarkettr1 = 0;
                starmarkettr2 = 0;
                starmarkettr3 = 1;
                starmarkettr4 = 0;
                pb1x9.Visible = true;
                pb2x9.Visible = false;
            }
            if (moonmarkettr4 == 1 && moonmarkettrd2 == 1)
            {
                moonmarkettrd2 = 0;
                moonmarkettr1d = 0;
                moonmarkettr2d = 0;
                moonmarkettr3d = 1;
                moonmarkettr4d = 0;
                moonmarkettr1 = 0;
                moonmarkettr2 = 0;
                moonmarkettr3 = 1;
                moonmarkettr4 = 0;
                pb1x10.Visible = true;
                pb2x10.Visible = false;
            }
            if (megamarkettr4 == 1 && megamarkettrd2 == 1)
            {
                megamarkettrd2 = 0;
                megamarkettr1d = 0;
                megamarkettr2d = 0;
                megamarkettr3d = 1;
                megamarkettr4d = 0;
                megamarkettr1 = 0;
                megamarkettr2 = 0;
                megamarkettr3 = 1;
                megamarkettr4 = 0;
                pb1x11.Visible = true;
                pb2x11.Visible = false;
            }

            if (visayashospitaltr4 == 1 && visayashospitaltrd2 == 1)
            {
                visayashospitaltrd2 = 0;
                visayashospitaltr1d = 0;
                visayashospitaltr2d = 0;
                visayashospitaltr3d = 1;
                visayashospitaltr4d = 0;
                visayashospitaltr1 = 0;
                visayashospitaltr2 = 0;
                visayashospitaltr3 = 1;
                visayashospitaltr4 = 0;
                pb1x12.Visible = true;
                pb2x12.Visible = false;
            }
            if (hobertshospitaltr4 == 1 && hobertshospitaltrd2 == 1)
            {
                hobertshospitaltrd2 = 0;
                hobertshospitaltr1d = 0;
                hobertshospitaltr2d = 0;
                hobertshospitaltr3d = 1;
                hobertshospitaltr4d = 0;
                hobertshospitaltr1 = 0;
                hobertshospitaltr2 = 0;
                hobertshospitaltr3 = 1;
                hobertshospitaltr4 = 0;
                pb1x13.Visible = true;
                pb2x13.Visible = false;
            }
            if (heartshospitaltr4 == 1 && heartshospitaltrd2 == 1)
            {
                heartshospitaltrd2 = 0;
                heartshospitaltr1d = 0;
                heartshospitaltr2d = 0;
                heartshospitaltr3d = 1;
                heartshospitaltr4d = 0;
                heartshospitaltr1 = 0;
                heartshospitaltr2 = 0;
                heartshospitaltr3 = 1;
                heartshospitaltr4 = 0;
                pb1x14.Visible = true;
                pb2x14.Visible = false;

            }

            if (internshospitaltr4 == 1 && internshospitaltrd2 == 1)
            {
                internshospitaltrd2 = 0;
                internshospitaltr1d = 0;
                internshospitaltr2d = 0;
                internshospitaltr3d = 1;
                internshospitaltr4d = 0;
                internshospitaltr1 = 0;
                internshospitaltr2 = 0;
                internshospitaltr3 = 1;
                internshospitaltr4 = 0;
                pb1x15.Visible = true;
                pb2x15.Visible = false;



            }
            if (nationalhealthhospitaltr4 == 1 && nationalhealthhospitaltrd2 == 1)
            {
                nationalhealthhospitaltrd2 = 0;
                nationalhealthhospitaltr1d = 0;
                nationalhealthhospitaltr2d = 0;
                nationalhealthhospitaltr3d = 1;
                nationalhealthhospitaltr4d = 0;
                nationalhealthhospitaltr1 = 0;
                nationalhealthhospitaltr2 = 0;
                nationalhealthhospitaltr3 = 1;
                nationalhealthhospitaltr4 = 0;
                pb1x16.Visible = true;
                pb2x16.Visible = false;
            }
            if (veteranshospitaltr4 == 1 && veteranshospitaltrd2 == 1)
            {
                veteranshospitaltrd2 = 0;
                veteranshospitaltr1d = 0;
                veteranshospitaltr2d = 0;
                veteranshospitaltr3d = 1;
                veteranshospitaltr4d = 0;
                veteranshospitaltr1 = 0;
                veteranshospitaltr2 = 0;
                veteranshospitaltr3 = 1;
                veteranshospitaltr4 = 0;
                pb1x17.Visible = true;
                pb2x17.Visible = false;
            }

            if (pearlmalltr4 == 1 && pearlmalltrd2 == 1)
            {
                pearlmalltrd2 = 0;
                pearlmalltr1d = 0;
                pearlmalltr2d = 0;
                pearlmalltr3d = 1;
                pearlmalltr4d = 0;
                pearlmalltr1 = 0;
                pearlmalltr2 = 0;
                pearlmalltr3 = 1;
                pearlmalltr4 = 0;
                pb1x18.Visible = true;
                pb2x18.Visible = false;
            }
            if (megamalltr4 == 1 && megamalltrd2 == 1)
            {
                megamalltrd2 = 0;
                megamalltr1d = 0;
                megamalltr2d = 0;
                megamalltr3d = 1;
                megamalltr4d = 0;
                megamalltr1 = 0;
                megamalltr2 = 0;
                megamalltr3 = 1;
                megamalltr4 = 0;
                pb1x19.Visible = true;
                pb2x19.Visible = false;
            }
            if (articmalltr4 == 1 && articmalltrd2 == 1)
            {
                articmalltrd2 = 0;
                articmalltr1d = 0;
                articmalltr2d = 0;
                articmalltr3d = 1;
                articmalltr4d = 0;
                articmalltr1 = 0;
                articmalltr2 = 0;
                articmalltr3 = 1;
                articmalltr4 = 0;
                pb1x20.Visible = true;
                pb2x20.Visible = false;
            }

            if (heavenlymalltr4 == 1 && heavenlymalltrd2 == 1)
            {
                heavenlymalltrd2 = 0;
                heavenlymalltr1d = 0;
                heavenlymalltr2d = 0;
                heavenlymalltr3d = 1;
                heavenlymalltr4d = 0;
                heavenlymalltr1 = 0;
                heavenlymalltr2 = 0;
                heavenlymalltr3 = 1;
                heavenlymalltr4 = 0;
                pb1x21.Visible = true;
                pb2x21.Visible = false;
            }
            if (shangrillamalltr4 == 1 && shangrillamalltrd2 == 1)
            {
                shangrillamalltrd2 = 0;
                shangrillamalltr1d = 0;
                shangrillamalltr2d = 0;
                shangrillamalltr3d = 1;
                shangrillamalltr4d = 0;
                shangrillamalltr1 = 0;
                shangrillamalltr2 = 0;
                shangrillamalltr3 = 1;
                shangrillamalltr4 = 0;
                pb1x22.Visible = true;
                pb2x22.Visible = false;
            }

            if (utility4x1tr4 == 1 && utility2x1trd2 == 1)
            {
                utility2x1trd2 = 0;
                utility1x1tr1d = 0;
                utility2x1tr2d = 0;
                utility3x1tr3d = 1;
                utility4x1tr4d = 0;
                utility1x1tr1 = 0;
                utility2x1tr2 = 0;
                utility3x1tr3 = 1;
                utility4x1tr4 = 0;
                pb1x23.Visible = true;
                pb2x23.Visible = false;
            }
            if (utility4x2tr4 == 1 && utility2x2trd2 == 1)
            {
                utility2x2trd2 = 0;
                utility1x2tr1d = 0;
                utility2x2tr2d = 0;
                utility3x2tr3d = 1;
                utility4x2tr4d = 0;
                utility1x2tr1 = 0;
                utility2x2tr2 = 0;
                utility3x2tr3 = 1;
                utility4x2tr4 = 0;

                pb1x24.Visible = true;
                pb2x24.Visible = false;
            }

            if (transportation4x1tr4 == 1 && transportation2x1trd2 == 1)
            {
                transportation2x1trd2 = 0;
                transportation1x1tr1d = 0;
                transportation2x1tr2d = 0;
                transportation3x1tr3d = 1;
                transportation4x1tr4d = 0;
                transportation1x1tr1 = 0;
                transportation2x1tr2 = 0;
                transportation3x1tr3 = 1;
                transportation4x1tr4 = 0;
                pb1x25.Visible = true;
                pb2x25.Visible = false;
            }
            if (transportation4x2tr4 == 1 && transportation2x2trd2 == 1)
            {
                transportation2x2trd2 = 0;
                transportation1x2tr1d = 0;
                transportation2x2tr2d = 0;
                transportation3x2tr3d = 1;
                transportation4x2tr4d = 0;
                transportation1x2tr1 = 0;
                transportation2x2tr2 = 0;
                transportation3x2tr3 = 1;
                transportation4x2tr4 = 0;
                pb1x26.Visible = true;
                pb2x26.Visible = false;
            }
            if (transportation4x3tr4 == 1 && transportation2x3trd2 == 1)
            {
                transportation2x3trd2 = 0;
                transportation1x3tr1d = 0;
                transportation2x3tr2d = 0;
                transportation3x3tr3d = 1;
                transportation4x3tr4d = 0;
                transportation1x3tr1 = 0;
                transportation2x3tr2 = 0;
                transportation3x3tr3 = 1;
                transportation4x3tr4 = 0;
                pb1x27.Visible = true;
                pb2x27.Visible = false;
            }
            if (transportation4x4tr4 == 1 && transportation2x4trd2 == 1)
            {
                transportation2x4trd2 = 0;
                transportation1x4tr1d = 0;
                transportation2x4tr2d = 0;
                transportation3x4tr3d = 1;
                transportation4x4tr4d = 0;
                transportation1x4tr1 = 0;
                transportation2x4tr2 = 0;
                transportation3x4tr3 = 1;
                transportation4x4tr4 = 0;
                pb1x28.Visible = true;
                pb2x28.Visible = false;
            }
        }
        void guide()
        {

            if (btnp1.Enabled == true)
            {
                tip1.Visible = true;
            }
            if (btnp2.Enabled == true)
            {
                tip2.Visible = true;
            }


            if (btnp1.Enabled == false)
            {
                tip1.Visible = false;
            }
            if (btnp2.Enabled == false)
            {
                tip2.Visible = false;
            }

        }
        void rushedquit() 
        {
        if(p4_gameplay.timer5 == 0)
        {
            p4tradein4 = 0;
            p3tradein3 = 0;
            p2tradein2 = 0;
            p1tradein1 = 0;
            p4_gameplay.p1 = 0;
            p4_gameplay.p2 = 0;
            p4_gameplay.p3 = 0;
            p4_gameplay.p4 = 0;
            p4_gameplay.p1tr = 0;
            p4_gameplay.p2tr = 0;
            p4_gameplay.p3tr = 0;
            p4_gameplay.p4tr = 0;
            p4_gameplay.p1trad = 0;
            p4_gameplay.p2trad = 0;
            p4_gameplay.p3trad = 0;
            p4_gameplay.p4trad = 0;

            this.Close();
        }
        }
        void turned() 
        {
            if (btnp1.Enabled == true && p1trad == 1 && turnsint == 1)
            {
                btnp1.Enabled = false;
                notif1.Visible = true;
                pb1notif.Image = bankers_game_proto.Properties.Resources.p1_d;
                p1notif.Text = "Player 1's turn";
                btnacc1.Visible = true;
                btndec1.Visible = false;
            }
            if (btnp1.Enabled == true && p2trad == 1 && turnsint == 1)
            {
                btnp1.Enabled = false;
                notif1.Visible = true;
                pb1notif.Image = bankers_game_proto.Properties.Resources.p2_d;
                p1notif.Text = "Player 2's turn";
                btnacc1.Visible = true;
                btndec1.Visible = false;
            }
            if (btnp1.Enabled == true && p3trad == 1 && turnsint == 1)
            {
                btnp1.Enabled = false;
                notif1.Visible = true;
                pb1notif.Image = bankers_game_proto.Properties.Resources.p3_d;
                p1notif.Text = "Player 3's turn";
                btnacc1.Visible = true;
                btndec1.Visible = false;
            }
            if (btnp1.Enabled == true && p4trad == 1 && turnsint == 1)
            {
                btnp1.Enabled = false;
                notif1.Visible = true;
                pb1notif.Image = bankers_game_proto.Properties.Resources.p4_d;
                p1notif.Text = "Player 4's turn";
                btnacc1.Visible = true;
                btndec1.Visible = false;
            }
            if (btnp2.Enabled == true && p1 == 1 && turnsint == 1)
            {
                btnp2.Enabled = false;
                notif2.Visible = true;
                pb2notif.Image = bankers_game_proto.Properties.Resources.p1_t;
                p2notif.Text = "Player 1's turn";
                btnacc2.Visible = true;
                btndec2.Visible = false;
            }
            if (btnp2.Enabled == true && p2  == 1 && turnsint == 1)
            {
                btnp2.Enabled = false;
                notif2.Visible = true;
                pb2notif.Image = bankers_game_proto.Properties.Resources.p2_t;
                p2notif.Text = "Player 2's turn";
                btnacc2.Visible = true;
                btndec2.Visible = false;
            }
            if (btnp2.Enabled == true && p3 == 1 && turnsint == 1)
            {
                btnp2.Enabled = false;
                notif2.Visible = true;
                pb2notif.Image = bankers_game_proto.Properties.Resources.p3_t;
                p2notif.Text = "Player 3's turn";
                btnacc2.Visible = true;
                btndec2.Visible = false;
            }
            if (btnp2.Enabled == true && p4 == 1 && turnsint == 1)
            {
                btnp2.Enabled = false;
                notif2.Visible = true;
                pb2notif.Image = bankers_game_proto.Properties.Resources.p4_t;
                p2notif.Text = "Player 4's turn";
                btnacc2.Visible = true;
                btndec2.Visible = false;
            }
        }
        #endregion

        #region props1
        private void pb1x1_Click(object sender, EventArgs e)
        {
            if (det == 1 || det == 1 && p1trad == 1 || det == 1 && p2trad == 1 || det == 1 && p3trad == 1 || det == 1 && p4trad == 1)
            {
                p1tr.Visible = true;
                pbdet1.Visible = true;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                easternschooldet1 = 1;
                pb1x1.Enabled = false;
                pb1x2.Enabled = false;
                pb1x3.Enabled = false;
                pb1x4.Enabled = false;
                pb1x5.Enabled = false;
                pb1x6.Enabled = false;
                pb1x7.Enabled = false;
                pb1x8.Enabled = false;
                pb1x9.Enabled = false;
                pb1x10.Enabled = false;
                pb1x11.Enabled = false;
                pb1x12.Enabled = false;
                pb1x13.Enabled = false;
                pb1x14.Enabled = false;
                pb1x15.Enabled = false;
                pb1x16.Enabled = false;
                pb1x17.Enabled = false;
                pb1x18.Enabled = false;
                pb1x19.Enabled = false;
                pb1x20.Enabled = false;
                pb1x21.Enabled = false;
                pb1x22.Enabled = false;
                pb1x23.Enabled = false;
                pb1x24.Enabled = false;
                pb1x25.Enabled = false;
                pb1x26.Enabled = false;
                pb1x27.Enabled = false;
                pb1x28.Enabled = false;
                pbdet1.Image = bankers_game_proto.Properties.Resources.Eastern_School_Purple;
                drawcarded.Play();
            }
            if (p1 == 1)
            {
                ListViewItem eastern = new ListViewItem();
                easternschooltrd1 = 1;
                btntrad1.Visible = false;
                eastern.ForeColor = Color.Purple;
                eastern.Text = "Eastern School";
                p1lvw.Items.Add(eastern);

                drawcarded.Play();
            }
            if (p2 == 1)
            {
                ListViewItem eastern = new ListViewItem();
                easternschooltrd1 = 1;
                btntrad1.Visible = false;
                eastern.ForeColor = Color.Purple;
                eastern.Text = "Eastern School";
                p1lvw.Items.Add(eastern);

                drawcarded.Play();
            }
            if (p3 == 1)
            {
                ListViewItem eastern = new ListViewItem();
                easternschooltrd1 = 1;
                btntrad1.Visible = false;
                eastern.ForeColor = Color.Purple;
                eastern.Text = "Eastern School";
                p1lvw.Items.Add(eastern);

                drawcarded.Play();
            }
            if (p4 == 1)
            {
                ListViewItem eastern = new ListViewItem();
                easternschooltrd1 = 1;
                btntrad1.Visible = false;
                eastern.ForeColor = Color.Purple;
                eastern.Text = "Eastern School";
                p1lvw.Items.Add(eastern);

                drawcarded.Play();
            }


            drawcarded.Play();
        }

        private void pb1x2_Click(object sender, EventArgs e)
        {
            if (det == 1 || det == 1 && p1trad == 1 || det == 1 && p2trad == 1 || det == 1 && p3trad == 1 || det == 1 && p4trad == 1)
            {
                p1tr.Visible = true;
                pbdet1.Visible = true;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                pb1x2.Enabled = false;
                westernschooldet1 = 1;
                pb1x1.Enabled = false;
                pb1x2.Enabled = false;
                pb1x3.Enabled = false;
                pb1x4.Enabled = false;
                pb1x5.Enabled = false;
                pb1x6.Enabled = false;
                pb1x7.Enabled = false;
                pb1x8.Enabled = false;
                pb1x9.Enabled = false;
                pb1x10.Enabled = false;
                pb1x11.Enabled = false;
                pb1x12.Enabled = false;
                pb1x13.Enabled = false;
                pb1x14.Enabled = false;
                pb1x15.Enabled = false;
                pb1x16.Enabled = false;
                pb1x17.Enabled = false;
                pb1x18.Enabled = false;
                pb1x19.Enabled = false;
                pb1x20.Enabled = false;
                pb1x21.Enabled = false;
                pb1x22.Enabled = false;
                pb1x23.Enabled = false;
                pb1x24.Enabled = false;
                pb1x25.Enabled = false;
                pb1x26.Enabled = false;
                pb1x27.Enabled = false;
                pb1x28.Enabled = false;
                pbdet1.Image = bankers_game_proto.Properties.Resources.Western_school;
                drawcarded.Play();
            }
            if (p1 == 1)
            {
                ListViewItem westernss = new ListViewItem();
                westernschooltrd1 = 1;
                btntrad1.Visible = false;
                westernss.ForeColor = Color.Purple;
                westernss.Text = "Western School";
                p1lvw.Items.Add(westernss);

                drawcarded.Play();
            }
            if (p2 == 1)
            {
                ListViewItem westernss = new ListViewItem();
                westernschooltrd1 = 1;
                btntrad1.Visible = false;
                westernss.ForeColor = Color.Purple;
                westernss.Text = "Western School";
                p1lvw.Items.Add(westernss);

                drawcarded.Play();
            }
            if (p3 == 1)
            {
                ListViewItem westernss = new ListViewItem();
                westernschooltrd1 = 1;
                btntrad1.Visible = false;
                westernss.ForeColor = Color.Purple;
                westernss.Text = "Western School";
                p1lvw.Items.Add(westernss);

                drawcarded.Play();
            }
            if (p4 == 1)
            {
                ListViewItem westernss = new ListViewItem();
                westernschooltrd1 = 1;
                btntrad1.Visible = false;
                westernss.ForeColor = Color.Purple;
                westernss.Text = "Western School";
                p1lvw.Items.Add(westernss);

                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb1x3_Click(object sender, EventArgs e)
        {
            if (p1 == 1)
            {
                ListViewItem visayashigh = new ListViewItem();
                visayashighschooltrd1 = 1;
                btntrad1.Visible = false;
                visayashigh.ForeColor = Color.LightBlue;
                visayashigh.Text = "Visayas High-School";
                p1lvw.Items.Add(visayashigh);

                drawcarded.Play();
            }
            if (p2 == 1)
            {
                ListViewItem visayashigh = new ListViewItem();
                visayashighschooltrd1 = 1;
                btntrad1.Visible = false;
                visayashigh.ForeColor = Color.LightBlue;
                visayashigh.Text = "Visayas High-School";
                p1lvw.Items.Add(visayashigh);

                drawcarded.Play();
            }
            if (p3 == 1)
            {
                ListViewItem visayashigh = new ListViewItem();
                visayashighschooltrd1 = 1;
                btntrad1.Visible = false;
                visayashigh.ForeColor = Color.LightBlue;
                visayashigh.Text = "Visayas High-School";
                p1lvw.Items.Add(visayashigh);

                drawcarded.Play();
            }
            if (p4 == 1)
            {
                ListViewItem visayashigh = new ListViewItem();
                visayashighschooltrd1 = 1;
                btntrad1.Visible = false;
                visayashigh.ForeColor = Color.LightBlue;
                visayashigh.Text = "Visayas High-School";
                p1lvw.Items.Add(visayashigh);

                drawcarded.Play();
            }
            if (det == 1 || det == 1 && p1trad == 1 || det == 1 && p2trad == 1 || det == 1 && p3trad == 1 || det == 1 && p4trad == 1)
            {
                p1tr.Visible = true;
                pbdet1.Visible = true;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                visayashighschooldet1 = 1;
                pb1x1.Enabled = false;
                pb1x2.Enabled = false;
                pb1x3.Enabled = false;
                pb1x4.Enabled = false;
                pb1x5.Enabled = false;
                pb1x6.Enabled = false;
                pb1x7.Enabled = false;
                pb1x8.Enabled = false;
                pb1x9.Enabled = false;
                pb1x10.Enabled = false;
                pb1x11.Enabled = false;
                pb1x12.Enabled = false;
                pb1x13.Enabled = false;
                pb1x14.Enabled = false;
                pb1x15.Enabled = false;
                pb1x16.Enabled = false;
                pb1x17.Enabled = false;
                pb1x18.Enabled = false;
                pb1x19.Enabled = false;
                pb1x20.Enabled = false;
                pb1x21.Enabled = false;
                pb1x22.Enabled = false;
                pb1x23.Enabled = false;
                pb1x24.Enabled = false;
                pb1x25.Enabled = false;
                pb1x26.Enabled = false;
                pb1x27.Enabled = false;
                pb1x28.Enabled = false;
                pbdet1.Image = bankers_game_proto.Properties.Resources.Visayas_highschool;
                drawcarded.Play();
            }

            drawcarded.Play();
        }

        private void pb1x4_Click(object sender, EventArgs e)
        {
            if (p1 == 1)
            {
                ListViewItem southern = new ListViewItem();
                southernschooltrd1 = 1;
                btntrad1.Visible = false;
                southern.ForeColor = Color.LightBlue;
                southern.Text = "Southern School";
                p1lvw.Items.Add(southern);

                drawcarded.Play();
            }
            if (p2 == 1)
            {
                ListViewItem southern = new ListViewItem();
                southernschooltrd1 = 1;
                btntrad1.Visible = false;
                southern.ForeColor = Color.LightBlue;
                southern.Text = "Southern School";
                p1lvw.Items.Add(southern);

                drawcarded.Play();
            }
            if (p3 == 1)
            {
                ListViewItem southern = new ListViewItem();
                southernschooltrd1 = 1;
                btntrad1.Visible = false;
                southern.ForeColor = Color.LightBlue;
                southern.Text = "Southern School";
                p1lvw.Items.Add(southern);

                drawcarded.Play();
            }
            if (p4 == 1)
            {
                ListViewItem southern = new ListViewItem();
                southernschooltrd1 = 1;
                btntrad1.Visible = false;
                southern.ForeColor = Color.LightBlue;
                southern.Text = "Southern School";
                p1lvw.Items.Add(southern);

                drawcarded.Play();
            }
            if (det == 1 || det == 1 && p1trad == 1 || det == 1 && p2trad == 1 || det == 1 && p3trad == 1 || det == 1 && p4trad == 1)
            {
                p1tr.Visible = true;
                pbdet1.Visible = true;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                southernschooldet1 = 1;
                pb1x1.Enabled = false;
                pb1x2.Enabled = false;
                pb1x3.Enabled = false;
                pb1x4.Enabled = false;
                pb1x5.Enabled = false;
                pb1x6.Enabled = false;
                pb1x7.Enabled = false;
                pb1x8.Enabled = false;
                pb1x9.Enabled = false;
                pb1x10.Enabled = false;
                pb1x11.Enabled = false;
                pb1x12.Enabled = false;
                pb1x13.Enabled = false;
                pb1x14.Enabled = false;
                pb1x15.Enabled = false;
                pb1x16.Enabled = false;
                pb1x17.Enabled = false;
                pb1x18.Enabled = false;
                pb1x19.Enabled = false;
                pb1x20.Enabled = false;
                pb1x21.Enabled = false;
                pb1x22.Enabled = false;
                pb1x23.Enabled = false;
                pb1x24.Enabled = false;
                pb1x25.Enabled = false;
                pb1x26.Enabled = false;
                pb1x27.Enabled = false;
                pb1x28.Enabled = false;
                pbdet1.Image = bankers_game_proto.Properties.Resources.Southern_highschool;
                drawcarded.Play();
            }

            drawcarded.Play();
        }

        private void pb1x5_Click(object sender, EventArgs e)
        {
            if (p1 == 1)
            {
                ListViewItem nationss = new ListViewItem();
                nationsschooltrd1 = 1;
                btntrad1.Visible = false;
                nationss.ForeColor = Color.LightBlue;
                nationss.Text = "Nation's School";
                p1lvw.Items.Add(nationss);

                drawcarded.Play();
            }
            if (p2 == 1)
            {
                ListViewItem nationss = new ListViewItem();
                nationsschooltrd1 = 1;
                btntrad1.Visible = false;
                nationss.ForeColor = Color.LightBlue;
                nationss.Text = "Nation's School";
                p1lvw.Items.Add(nationss);

                drawcarded.Play();
            }
            if (p3 == 1)
            {
                ListViewItem nationss = new ListViewItem();
                nationsschooltrd1 = 1;
                btntrad1.Visible = false;
                nationss.ForeColor = Color.LightBlue;
                nationss.Text = "Nation's School";
                p1lvw.Items.Add(nationss);

                drawcarded.Play();
            }
            if (p4 == 1)
            {
                ListViewItem nationss = new ListViewItem();
                nationsschooltrd1 = 1;
                btntrad1.Visible = false;
                nationss.ForeColor = Color.LightBlue;
                nationss.Text = "Nation's School";
                p1lvw.Items.Add(nationss);

                drawcarded.Play();
            }
            if (det == 1 || det == 1 && p1trad == 1 || det == 1 && p2trad == 1 || det == 1 && p3trad == 1 || det == 1 && p4trad == 1)
            {
                p1tr.Visible = true;
                pbdet1.Visible = true;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                nationsschooldet1 = 1;
                pb1x1.Enabled = false;
                pb1x2.Enabled = false;
                pb1x3.Enabled = false;
                pb1x4.Enabled = false;
                pb1x5.Enabled = false;
                pb1x6.Enabled = false;
                pb1x7.Enabled = false;
                pb1x8.Enabled = false;
                pb1x9.Enabled = false;
                pb1x10.Enabled = false;
                pb1x11.Enabled = false;
                pb1x12.Enabled = false;
                pb1x13.Enabled = false;
                pb1x14.Enabled = false;
                pb1x15.Enabled = false;
                pb1x16.Enabled = false;
                pb1x17.Enabled = false;
                pb1x18.Enabled = false;
                pb1x19.Enabled = false;
                pb1x20.Enabled = false;
                pb1x21.Enabled = false;
                pb1x22.Enabled = false;
                pb1x23.Enabled = false;
                pb1x24.Enabled = false;
                pb1x25.Enabled = false;
                pb1x26.Enabled = false;
                pb1x27.Enabled = false;
                pb1x28.Enabled = false;
                pbdet1.Image = bankers_game_proto.Properties.Resources.Nation_s_highschool;
                drawcarded.Play();
            }

            drawcarded.Play();
        }

        private void pb1x6_Click(object sender, EventArgs e)
        {
            if (p1 == 1)
            {
                ListViewItem westma = new ListViewItem();
                westmarkettrd1 = 1;
                btntrad1.Visible = false;
                westma.ForeColor = Color.Pink;
                westma.Text = "West Market";
                p1lvw.Items.Add(westma);

                drawcarded.Play();
            }
            if (p2 == 1)
            {
                ListViewItem westma = new ListViewItem();
                westmarkettrd1 = 1;
                btntrad1.Visible = false;
                westma.ForeColor = Color.Pink;
                westma.Text = "West Market";
                p1lvw.Items.Add(westma);

                drawcarded.Play();
            }
            if (p3 == 1)
            {
                ListViewItem westma = new ListViewItem();
                westmarkettrd1 = 1;
                btntrad1.Visible = false;
                westma.ForeColor = Color.Pink;
                westma.Text = "West Market";
                p1lvw.Items.Add(westma);

                drawcarded.Play();
            }
            if (p4 == 1)
            {
                ListViewItem westma = new ListViewItem();
                westmarkettrd1 = 1;
                btntrad1.Visible = false;
                westma.ForeColor = Color.Pink;
                westma.Text = "West Market";
                p1lvw.Items.Add(westma);

                drawcarded.Play();
            }
            if (det == 1 || det == 1 && p1trad == 1 || det == 1 && p2trad == 1 || det == 1 && p3trad == 1 || det == 1 && p4trad == 1)
            {
                p1tr.Visible = true;
                pbdet1.Visible = true;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                westmarketdet1 = 1;
                pb1x1.Enabled = false;
                pb1x2.Enabled = false;
                pb1x3.Enabled = false;
                pb1x4.Enabled = false;
                pb1x5.Enabled = false;
                pb1x6.Enabled = false;
                pb1x7.Enabled = false;
                pb1x8.Enabled = false;
                pb1x9.Enabled = false;
                pb1x10.Enabled = false;
                pb1x11.Enabled = false;
                pb1x12.Enabled = false;
                pb1x13.Enabled = false;
                pb1x14.Enabled = false;
                pb1x15.Enabled = false;
                pb1x16.Enabled = false;
                pb1x17.Enabled = false;
                pb1x18.Enabled = false;
                pb1x19.Enabled = false;
                pb1x20.Enabled = false;
                pb1x21.Enabled = false;
                pb1x22.Enabled = false;
                pb1x23.Enabled = false;
                pb1x24.Enabled = false;
                pb1x25.Enabled = false;
                pb1x26.Enabled = false;
                pb1x27.Enabled = false;
                pb1x28.Enabled = false;
                pbdet1.Image = bankers_game_proto.Properties.Resources.West_Market;
                drawcarded.Play();
            }

            drawcarded.Play();
        }

        private void pb1x7_Click(object sender, EventArgs e)
        {
            if (p1 == 1)
            {
                ListViewItem nightma = new ListViewItem();
                nightmarkettrd1 = 1;
                btntrad1.Visible = false;
                nightma.ForeColor = Color.Pink;
                nightma.Text = "Night Market";
                p1lvw.Items.Add(nightma);

                drawcarded.Play();
            }
            if (p2 == 1)
            {
                ListViewItem nightma = new ListViewItem();
                nightmarkettrd1 = 1;
                btntrad1.Visible = false;
                nightma.ForeColor = Color.Pink;
                nightma.Text = "Night Market";
                p1lvw.Items.Add(nightma);

                drawcarded.Play();
            }
            if (p3 == 1)
            {
                ListViewItem nightma = new ListViewItem();
                nightmarkettrd1 = 1;
                btntrad1.Visible = false;
                nightma.ForeColor = Color.Pink;
                nightma.Text = "Night Market";
                p1lvw.Items.Add(nightma);

                drawcarded.Play();
            }
            if (p4 == 1)
            {
                ListViewItem nightma = new ListViewItem();
                nightmarkettrd1 = 1;
                btntrad1.Visible = false;
                nightma.ForeColor = Color.Pink;
                nightma.Text = "Night Market";
                p1lvw.Items.Add(nightma);

                drawcarded.Play();
            }
            if (det == 1 || det == 1 && p1trad == 1 || det == 1 && p2trad == 1 || det == 1 && p3trad == 1 || det == 1 && p4trad == 1)
            {
                p1tr.Visible = true;
                pbdet1.Visible = true;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                nightmarketdet1 = 1;
                pb1x1.Enabled = false;
                pb1x2.Enabled = false;
                pb1x3.Enabled = false;
                pb1x4.Enabled = false;
                pb1x5.Enabled = false;
                pb1x6.Enabled = false;
                pb1x7.Enabled = false;
                pb1x8.Enabled = false;
                pb1x9.Enabled = false;
                pb1x10.Enabled = false;
                pb1x11.Enabled = false;
                pb1x12.Enabled = false;
                pb1x13.Enabled = false;
                pb1x14.Enabled = false;
                pb1x15.Enabled = false;
                pb1x16.Enabled = false;
                pb1x17.Enabled = false;
                pb1x18.Enabled = false;
                pb1x19.Enabled = false;
                pb1x20.Enabled = false;
                pb1x21.Enabled = false;
                pb1x22.Enabled = false;
                pb1x23.Enabled = false;
                pb1x24.Enabled = false;
                pb1x25.Enabled = false;
                pb1x26.Enabled = false;
                pb1x27.Enabled = false;
                pb1x28.Enabled = false;
                pbdet1.Image = bankers_game_proto.Properties.Resources.Night_market;
                drawcarded.Play();
            }

            drawcarded.Play();
        }

        private void pb1x8_Click(object sender, EventArgs e)
        {
            if (p1 == 1)
            {
                ListViewItem dayma = new ListViewItem();
                daymarkettrd1 = 1;
                btntrad1.Visible = false;
                dayma.ForeColor = Color.Pink;
                dayma.Text = "Day Market";
                p1lvw.Items.Add(dayma);

                drawcarded.Play();
            }
            if (p2 == 1)
            {
                ListViewItem dayma = new ListViewItem();
                daymarkettrd1 = 1;
                btntrad1.Visible = false;
                dayma.ForeColor = Color.Pink;
                dayma.Text = "Day Market";
                p1lvw.Items.Add(dayma);

                drawcarded.Play();
            }
            if (p3 == 1)
            {
                ListViewItem dayma = new ListViewItem();
                daymarkettrd1 = 1;
                btntrad1.Visible = false;
                dayma.ForeColor = Color.Pink;
                dayma.Text = "Day Market";
                p1lvw.Items.Add(dayma);

                drawcarded.Play();
            }
            if (p4 == 1)
            {
                ListViewItem dayma = new ListViewItem();
                daymarkettrd1 = 1;
                btntrad1.Visible = false;
                dayma.ForeColor = Color.Pink;
                dayma.Text = "Day Market";
                p1lvw.Items.Add(dayma);

                drawcarded.Play();
            }
            if (det == 1 || det == 1 && p1trad == 1 || det == 1 && p2trad == 1 || det == 1 && p3trad == 1 || det == 1 && p4trad == 1)
            {
                p1tr.Visible = true;
                pbdet1.Visible = true;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                daymarketdet1 = 1;
                pb1x1.Enabled = false;
                pb1x2.Enabled = false;
                pb1x3.Enabled = false;
                pb1x4.Enabled = false;
                pb1x5.Enabled = false;
                pb1x6.Enabled = false;
                pb1x7.Enabled = false;
                pb1x8.Enabled = false;
                pb1x9.Enabled = false;
                pb1x10.Enabled = false;
                pb1x11.Enabled = false;
                pb1x12.Enabled = false;
                pb1x13.Enabled = false;
                pb1x14.Enabled = false;
                pb1x15.Enabled = false;
                pb1x16.Enabled = false;
                pb1x17.Enabled = false;
                pb1x18.Enabled = false;
                pb1x19.Enabled = false;
                pb1x20.Enabled = false;
                pb1x21.Enabled = false;
                pb1x22.Enabled = false;
                pb1x23.Enabled = false;
                pb1x24.Enabled = false;
                pb1x25.Enabled = false;
                pb1x26.Enabled = false;
                pb1x27.Enabled = false;
                pb1x28.Enabled = false;
                pbdet1.Image = bankers_game_proto.Properties.Resources.Day_market;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb1x9_Click(object sender, EventArgs e)
        {
            if (p1 == 1)
            {
                ListViewItem starma = new ListViewItem();
                starmarkettrd1 = 1;
                btntrad1.Visible = false;
                starma.ForeColor = Color.DarkOrange;
                starma.Text = "Star Market";
                p1lvw.Items.Add(starma);

                drawcarded.Play();
            }
            if (p2 == 1)
            {
                ListViewItem starma = new ListViewItem();
                starmarkettrd1 = 1;
                btntrad1.Visible = false;
                starma.ForeColor = Color.DarkOrange;
                starma.Text = "Star Market";
                p1lvw.Items.Add(starma);

                drawcarded.Play();
            }
            if (p3 == 1)
            {
                ListViewItem starma = new ListViewItem();
                starmarkettrd1 = 1;
                btntrad1.Visible = false;
                starma.ForeColor = Color.DarkOrange;
                starma.Text = "Star Market";
                p1lvw.Items.Add(starma);

                drawcarded.Play();
            }
            if (p4 == 1)
            {
                ListViewItem starma = new ListViewItem();
                starmarkettrd1 = 1;
                btntrad1.Visible = false;
                starma.ForeColor = Color.DarkOrange;
                starma.Text = "Star Market";
                p1lvw.Items.Add(starma);

                drawcarded.Play();
            }
            if (det == 1 || det == 1 && p1trad == 1 || det == 1 && p2trad == 1 || det == 1 && p3trad == 1 || det == 1 && p4trad == 1)
            {
                p1tr.Visible = true;
                pbdet1.Visible = true;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                starmarketdet1 = 1;
                pb1x1.Enabled = false;
                pb1x2.Enabled = false;
                pb1x3.Enabled = false;
                pb1x4.Enabled = false;
                pb1x5.Enabled = false;
                pb1x6.Enabled = false;
                pb1x7.Enabled = false;
                pb1x8.Enabled = false;
                pb1x9.Enabled = false;
                pb1x10.Enabled = false;
                pb1x11.Enabled = false;
                pb1x12.Enabled = false;
                pb1x13.Enabled = false;
                pb1x14.Enabled = false;
                pb1x15.Enabled = false;
                pb1x16.Enabled = false;
                pb1x17.Enabled = false;
                pb1x18.Enabled = false;
                pb1x19.Enabled = false;
                pb1x20.Enabled = false;
                pb1x21.Enabled = false;
                pb1x22.Enabled = false;
                pb1x23.Enabled = false;
                pb1x24.Enabled = false;
                pb1x25.Enabled = false;
                pb1x26.Enabled = false;
                pb1x27.Enabled = false;
                pb1x28.Enabled = false;
                pbdet1.Image = bankers_game_proto.Properties.Resources.Star_market;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb1x10_Click(object sender, EventArgs e)
        {
            if (p1 == 1)
            {
                ListViewItem moonma = new ListViewItem();
                moonmarkettrd1 = 1;
                btntrad1.Visible = false;
                moonma.ForeColor = Color.DarkOrange;
                moonma.Text = "Moon Market";
                p1lvw.Items.Add(moonma);

                drawcarded.Play();
            }
            if (p2 == 1)
            {
                ListViewItem moonma = new ListViewItem();
                moonmarkettrd1 = 1;
                btntrad1.Visible = false;
                moonma.ForeColor = Color.DarkOrange;
                moonma.Text = "Moon Market";
                p1lvw.Items.Add(moonma);

                drawcarded.Play();
            }
            if (p3 == 1)
            {
                ListViewItem moonma = new ListViewItem();
                moonmarkettrd1 = 1;
                btntrad1.Visible = false;
                moonma.ForeColor = Color.DarkOrange;
                moonma.Text = "Moon Market";
                p1lvw.Items.Add(moonma);

                drawcarded.Play();
            }
            if (p4 == 1)
            {
                ListViewItem moonma = new ListViewItem();
                moonmarkettrd1 = 1;
                btntrad1.Visible = false;
                moonma.ForeColor = Color.DarkOrange;
                moonma.Text = "Moon Market";
                p1lvw.Items.Add(moonma);

                drawcarded.Play();
            }
            if (det == 1 || det == 1 && p1trad == 1 || det == 1 && p2trad == 1 || det == 1 && p3trad == 1 || det == 1 && p4trad == 1)
            {
                p1tr.Visible = true;
                pbdet1.Visible = true;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                moonmarketdet1 = 1;
                pb1x1.Enabled = false;
                pb1x2.Enabled = false;
                pb1x3.Enabled = false;
                pb1x4.Enabled = false;
                pb1x5.Enabled = false;
                pb1x6.Enabled = false;
                pb1x7.Enabled = false;
                pb1x8.Enabled = false;
                pb1x9.Enabled = false;
                pb1x10.Enabled = false;
                pb1x11.Enabled = false;
                pb1x12.Enabled = false;
                pb1x13.Enabled = false;
                pb1x14.Enabled = false;
                pb1x15.Enabled = false;
                pb1x16.Enabled = false;
                pb1x17.Enabled = false;
                pb1x18.Enabled = false;
                pb1x19.Enabled = false;
                pb1x20.Enabled = false;
                pb1x21.Enabled = false;
                pb1x22.Enabled = false;
                pb1x23.Enabled = false;
                pb1x24.Enabled = false;
                pb1x25.Enabled = false;
                pb1x26.Enabled = false;
                pb1x27.Enabled = false;
                pb1x28.Enabled = false;
                pbdet1.Image = bankers_game_proto.Properties.Resources.Moon_market;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb1x11_Click(object sender, EventArgs e)
        {
            if (p1 == 1)
            {
                ListViewItem megama = new ListViewItem();
                megamarkettrd1 = 1;
                btntrad1.Visible = false;
                megama.ForeColor = Color.DarkOrange;
                megama.Text = "Mega Market";
                p1lvw.Items.Add(megama);

                drawcarded.Play();
            }
            if (p2 == 1)
            {
                ListViewItem megama = new ListViewItem();
                megamarkettrd1 = 1;
                btntrad1.Visible = false;
                megama.ForeColor = Color.DarkOrange;
                megama.Text = "Mega Market";
                p1lvw.Items.Add(megama);

                drawcarded.Play();
            }
            if (p3 == 1)
            {
                ListViewItem megama = new ListViewItem();
                megamarkettrd1 = 1;
                btntrad1.Visible = false;
                megama.ForeColor = Color.DarkOrange;
                megama.Text = "Mega Market";
                p1lvw.Items.Add(megama);

                drawcarded.Play();
            }
            if (p4 == 1)
            {
                ListViewItem megama = new ListViewItem();
                megamarkettrd1 = 1;
                btntrad1.Visible = false;
                megama.ForeColor = Color.DarkOrange;
                megama.Text = "Mega Market";
                p1lvw.Items.Add(megama);

                drawcarded.Play();
            }
            if (det == 1 || det == 1 && p1trad == 1 || det == 1 && p2trad == 1 || det == 1 && p3trad == 1 || det == 1 && p4trad == 1)
            {
                p1tr.Visible = true;
                pbdet1.Visible = true;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                megamarketdet1 = 1;
                pb1x1.Enabled = false;
                pb1x2.Enabled = false;
                pb1x3.Enabled = false;
                pb1x4.Enabled = false;
                pb1x5.Enabled = false;
                pb1x6.Enabled = false;
                pb1x7.Enabled = false;
                pb1x8.Enabled = false;
                pb1x9.Enabled = false;
                pb1x10.Enabled = false;
                pb1x11.Enabled = false;
                pb1x12.Enabled = false;
                pb1x13.Enabled = false;
                pb1x14.Enabled = false;
                pb1x15.Enabled = false;
                pb1x16.Enabled = false;
                pb1x17.Enabled = false;
                pb1x18.Enabled = false;
                pb1x19.Enabled = false;
                pb1x20.Enabled = false;
                pb1x21.Enabled = false;
                pb1x22.Enabled = false;
                pb1x23.Enabled = false;
                pb1x24.Enabled = false;
                pb1x25.Enabled = false;
                pb1x26.Enabled = false;
                pb1x27.Enabled = false;
                pb1x28.Enabled = false;
                pbdet1.Image = bankers_game_proto.Properties.Resources.Mega_market;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb1x12_Click(object sender, EventArgs e)
        {
            if (p1 == 1)
            {
                ListViewItem visayashos = new ListViewItem();
                visayashospitaltrd1 = 1;
                btntrad1.Visible = false;
                visayashos.ForeColor = Color.Red;
                visayashos.Text = "Visayas Hospital";
                p1lvw.Items.Add(visayashos);

                drawcarded.Play();
            }
            if (p2 == 1)
            {
                ListViewItem visayashos = new ListViewItem();
                visayashospitaltrd1 = 1;
                btntrad1.Visible = false;
                visayashos.ForeColor = Color.Red;
                visayashos.Text = "Visayas Hospital";
                p1lvw.Items.Add(visayashos);

                drawcarded.Play();
            }
            if (p3 == 1)
            {
                ListViewItem visayashos = new ListViewItem();
                visayashospitaltrd1 = 1;
                btntrad1.Visible = false;
                visayashos.ForeColor = Color.Red;
                visayashos.Text = "Visayas Hospital";
                p1lvw.Items.Add(visayashos);

                drawcarded.Play();
            }
            if (p4 == 1)
            {
                ListViewItem visayashos = new ListViewItem();
                visayashospitaltrd1 = 1;
                btntrad1.Visible = false;
                visayashos.ForeColor = Color.Red;
                visayashos.Text = "Visayas Hospital";
                p1lvw.Items.Add(visayashos);

                drawcarded.Play();
            }
            if (det == 1 || det == 1 && p1trad == 1 || det == 1 && p2trad == 1 || det == 1 && p3trad == 1 || det == 1 && p4trad == 1)
            {
                p1tr.Visible = true;
                pbdet1.Visible = true;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                visayashospitaldet1 = 1;
                pb1x1.Enabled = false;
                pb1x2.Enabled = false;
                pb1x3.Enabled = false;
                pb1x4.Enabled = false;
                pb1x5.Enabled = false;
                pb1x6.Enabled = false;
                pb1x7.Enabled = false;
                pb1x8.Enabled = false;
                pb1x9.Enabled = false;
                pb1x10.Enabled = false;
                pb1x11.Enabled = false;
                pb1x12.Enabled = false;
                pb1x13.Enabled = false;
                pb1x14.Enabled = false;
                pb1x15.Enabled = false;
                pb1x16.Enabled = false;
                pb1x17.Enabled = false;
                pb1x18.Enabled = false;
                pb1x19.Enabled = false;
                pb1x20.Enabled = false;
                pb1x21.Enabled = false;
                pb1x22.Enabled = false;
                pb1x23.Enabled = false;
                pb1x24.Enabled = false;
                pb1x25.Enabled = false;
                pb1x26.Enabled = false;
                pb1x27.Enabled = false;
                pb1x28.Enabled = false;
                pbdet1.Image = bankers_game_proto.Properties.Resources.Visayas_hospital;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb1x13_Click(object sender, EventArgs e)
        {
            if (p1 == 1)
            {
                ListViewItem hobertshos = new ListViewItem();
                hobertshospitaltrd1 = 1;
                btntrad1.Visible = false;
                hobertshos.ForeColor = Color.Red;
                hobertshos.Text = "Hobert's Hospital";
                p1lvw.Items.Add(hobertshos);

                drawcarded.Play();
            }
            if (p2 == 1)
            {
                ListViewItem hobertshos = new ListViewItem();
                hobertshospitaltrd1 = 1;
                btntrad1.Visible = false;
                hobertshos.ForeColor = Color.Red;
                hobertshos.Text = "Hobert's Hospital";
                p1lvw.Items.Add(hobertshos);

                drawcarded.Play();
            }
            if (p3 == 1)
            {
                ListViewItem hobertshos = new ListViewItem();
                hobertshospitaltrd1 = 1;
                btntrad1.Visible = false;
                hobertshos.ForeColor = Color.Red;
                hobertshos.Text = "Hobert's Hospital";
                p1lvw.Items.Add(hobertshos);

                drawcarded.Play();
            }
            if (p4 == 1)
            {
                ListViewItem hobertshos = new ListViewItem();
                hobertshospitaltrd1 = 1;
                btntrad1.Visible = false;
                hobertshos.ForeColor = Color.Red;
                hobertshos.Text = "Hobert's Hospital";
                p1lvw.Items.Add(hobertshos);

                drawcarded.Play();
            }
            if (det == 1 || det == 1 && p1trad == 1 || det == 1 && p2trad == 1 || det == 1 && p3trad == 1 || det == 1 && p4trad == 1)
            {
                p1tr.Visible = true;
                pbdet1.Visible = true;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                hobertshospitaldet1 = 1;
                pb1x1.Enabled = false;
                pb1x2.Enabled = false;
                pb1x3.Enabled = false;
                pb1x4.Enabled = false;
                pb1x5.Enabled = false;
                pb1x6.Enabled = false;
                pb1x7.Enabled = false;
                pb1x8.Enabled = false;
                pb1x9.Enabled = false;
                pb1x10.Enabled = false;
                pb1x11.Enabled = false;
                pb1x12.Enabled = false;
                pb1x13.Enabled = false;
                pb1x14.Enabled = false;
                pb1x15.Enabled = false;
                pb1x16.Enabled = false;
                pb1x17.Enabled = false;
                pb1x18.Enabled = false;
                pb1x19.Enabled = false;
                pb1x20.Enabled = false;
                pb1x21.Enabled = false;
                pb1x22.Enabled = false;
                pb1x23.Enabled = false;
                pb1x24.Enabled = false;
                pb1x25.Enabled = false;
                pb1x26.Enabled = false;
                pb1x27.Enabled = false;
                pb1x28.Enabled = false;
                pbdet1.Image = bankers_game_proto.Properties.Resources.Hobert_s_hospital;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb1x14_Click(object sender, EventArgs e)
        {
            if (p1 == 1)
            {
                ListViewItem heartshos = new ListViewItem();
                heartshospitaltrd1 = 1;
                btntrad1.Visible = false;
                heartshos.ForeColor = Color.Red;
                heartshos.Text = "Hearts Hospital";
                p1lvw.Items.Add(heartshos);

                drawcarded.Play();
            }
            if (p2 == 1)
            {
                ListViewItem heartshos = new ListViewItem();
                heartshospitaltrd1 = 1;
                btntrad1.Visible = false;
                heartshos.ForeColor = Color.Red;
                heartshos.Text = "Hearts Hospital";
                p1lvw.Items.Add(heartshos);

                drawcarded.Play();
            }
            if (p3 == 1)
            {
                ListViewItem heartshos = new ListViewItem();
                heartshospitaltrd1 = 1;
                btntrad1.Visible = false;
                heartshos.ForeColor = Color.Red;
                heartshos.Text = "Hearts Hospital";
                p1lvw.Items.Add(heartshos);

                drawcarded.Play();
            }
            if (p4 == 1)
            {
                ListViewItem heartshos = new ListViewItem();
                heartshospitaltrd1 = 1;
                btntrad1.Visible = false;
                heartshos.ForeColor = Color.Red;
                heartshos.Text = "Hearts Hospital";
                p1lvw.Items.Add(heartshos);

                drawcarded.Play();
            }
            if (det == 1 || det == 1 && p1trad == 1 || det == 1 && p2trad == 1 || det == 1 && p3trad == 1 || det == 1 && p4trad == 1)
            {
                p1tr.Visible = true;
                pbdet1.Visible = true;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                heartshospitaldet1 = 1;
                pb1x1.Enabled = false;
                pb1x2.Enabled = false;
                pb1x3.Enabled = false;
                pb1x4.Enabled = false;
                pb1x5.Enabled = false;
                pb1x6.Enabled = false;
                pb1x7.Enabled = false;
                pb1x8.Enabled = false;
                pb1x9.Enabled = false;
                pb1x10.Enabled = false;
                pb1x11.Enabled = false;
                pb1x12.Enabled = false;
                pb1x13.Enabled = false;
                pb1x14.Enabled = false;
                pb1x15.Enabled = false;
                pb1x16.Enabled = false;
                pb1x17.Enabled = false;
                pb1x18.Enabled = false;
                pb1x19.Enabled = false;
                pb1x20.Enabled = false;
                pb1x21.Enabled = false;
                pb1x22.Enabled = false;
                pb1x23.Enabled = false;
                pb1x24.Enabled = false;
                pb1x25.Enabled = false;
                pb1x26.Enabled = false;
                pb1x27.Enabled = false;
                pb1x28.Enabled = false;
                pbdet1.Image = bankers_game_proto.Properties.Resources.Hearts_hospital;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb1x15_Click(object sender, EventArgs e)
        {
            if (p1 == 1)
            {
                ListViewItem internshos = new ListViewItem();
                internshospitaltrd1 = 1;
                btntrad1.Visible = false;
                internshos.ForeColor = Color.LightGoldenrodYellow;
                internshos.Text = "Intern's Hospital";
                p1lvw.Items.Add(internshos);

                drawcarded.Play();
            }
            if (p2 == 1)
            {
                ListViewItem internshos = new ListViewItem();
                internshospitaltrd1 = 1;
                btntrad1.Visible = false;
                internshos.ForeColor = Color.LightGoldenrodYellow;
                internshos.Text = "Intern's Hospital";
                p1lvw.Items.Add(internshos);

                drawcarded.Play();
            }
            if (p3 == 1)
            {
                ListViewItem internshos = new ListViewItem();
                internshospitaltrd1 = 1;
                btntrad1.Visible = false;
                internshos.ForeColor = Color.LightGoldenrodYellow;
                internshos.Text = "Intern's Hospital";
                p1lvw.Items.Add(internshos);

                drawcarded.Play();
            }
            if (p4 == 1)
            {
                ListViewItem internshos = new ListViewItem();
                internshospitaltrd1 = 1;
                btntrad1.Visible = false;
                internshos.ForeColor = Color.LightGoldenrodYellow;
                internshos.Text = "Intern's Hospital";
                p1lvw.Items.Add(internshos);

                drawcarded.Play();
            }
            if (det == 1 || det == 1 && p1trad == 1 || det == 1 && p2trad == 1 || det == 1 && p3trad == 1 || det == 1 && p4trad == 1)
            {
                p1tr.Visible = true;
                pbdet1.Visible = true;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                internshospitaldet1 = 1;
                pb1x1.Enabled = false;
                pb1x2.Enabled = false;
                pb1x3.Enabled = false;
                pb1x4.Enabled = false;
                pb1x5.Enabled = false;
                pb1x6.Enabled = false;
                pb1x7.Enabled = false;
                pb1x8.Enabled = false;
                pb1x9.Enabled = false;
                pb1x10.Enabled = false;
                pb1x11.Enabled = false;
                pb1x12.Enabled = false;
                pb1x13.Enabled = false;
                pb1x14.Enabled = false;
                pb1x15.Enabled = false;
                pb1x16.Enabled = false;
                pb1x17.Enabled = false;
                pb1x18.Enabled = false;
                pb1x19.Enabled = false;
                pb1x20.Enabled = false;
                pb1x21.Enabled = false;
                pb1x22.Enabled = false;
                pb1x23.Enabled = false;
                pb1x24.Enabled = false;
                pb1x25.Enabled = false;
                pb1x26.Enabled = false;
                pb1x27.Enabled = false;
                pb1x28.Enabled = false;
                pbdet1.Image = bankers_game_proto.Properties.Resources.Intern_s_hospital;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb1x16_Click(object sender, EventArgs e)
        {
            if (p1 == 1)
            {
                ListViewItem nationalhos = new ListViewItem();
                nationalhealthhospitaltrd1 = 1;
                btntrad1.Visible = false;
                nationalhos.ForeColor = Color.LightGoldenrodYellow;
                nationalhos.Text = "National Health Hospital";
                p1lvw.Items.Add(nationalhos);

                drawcarded.Play();
            }
            if (p2 == 1)
            {
                ListViewItem nationalhos = new ListViewItem();
                nationalhealthhospitaltrd1 = 1;
                btntrad1.Visible = false;
                nationalhos.ForeColor = Color.LightGoldenrodYellow;
                nationalhos.Text = "National Health Hospital";
                p1lvw.Items.Add(nationalhos);

                drawcarded.Play();
            }
            if (p3 == 1)
            {
                ListViewItem nationalhos = new ListViewItem();
                nationalhealthhospitaltrd1 = 1;
                btntrad1.Visible = false;
                nationalhos.ForeColor = Color.LightGoldenrodYellow;
                nationalhos.Text = "National Health Hospital";
                p1lvw.Items.Add(nationalhos);

                drawcarded.Play();
            }
            if (p4 == 1)
            {
                ListViewItem nationalhos = new ListViewItem();
                nationalhealthhospitaltrd1 = 1;
                btntrad1.Visible = false;
                nationalhos.ForeColor = Color.LightGoldenrodYellow;
                nationalhos.Text = "National Health Hospital";
                p1lvw.Items.Add(nationalhos);

                drawcarded.Play();
            }
            if (det == 1 || det == 1 && p1trad == 1 || det == 1 && p2trad == 1 || det == 1 && p3trad == 1 || det == 1 && p4trad == 1)
            {
                p1tr.Visible = true;
                pbdet1.Visible = true;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                nationalhealthhospitaldet1 = 1;
                pb1x1.Enabled = false;
                pb1x2.Enabled = false;
                pb1x3.Enabled = false;
                pb1x4.Enabled = false;
                pb1x5.Enabled = false;
                pb1x6.Enabled = false;
                pb1x7.Enabled = false;
                pb1x8.Enabled = false;
                pb1x9.Enabled = false;
                pb1x10.Enabled = false;
                pb1x11.Enabled = false;
                pb1x12.Enabled = false;
                pb1x13.Enabled = false;
                pb1x14.Enabled = false;
                pb1x15.Enabled = false;
                pb1x16.Enabled = false;
                pb1x17.Enabled = false;
                pb1x18.Enabled = false;
                pb1x19.Enabled = false;
                pb1x20.Enabled = false;
                pb1x21.Enabled = false;
                pb1x22.Enabled = false;
                pb1x23.Enabled = false;
                pb1x24.Enabled = false;
                pb1x25.Enabled = false;
                pb1x26.Enabled = false;
                pb1x27.Enabled = false;
                pb1x28.Enabled = false;
                pbdet1.Image = bankers_game_proto.Properties.Resources.National_healths_hospital;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb1x17_Click(object sender, EventArgs e)
        {
            if (p1 == 1)
            {
                ListViewItem veteranshos = new ListViewItem();
                veteranshospitaltrd1 = 1;
                btntrad1.Visible = false;
                veteranshos.ForeColor = Color.LightGoldenrodYellow;
                veteranshos.Text = "Veteran's Hospital";
                p1lvw.Items.Add(veteranshos);

                drawcarded.Play();
            }
            if (p2 == 1)
            {
                ListViewItem veteranshos = new ListViewItem();
                veteranshospitaltrd1 = 1;
                btntrad1.Visible = false;
                veteranshos.ForeColor = Color.LightGoldenrodYellow;
                veteranshos.Text = "Veteran's Hospital";
                p1lvw.Items.Add(veteranshos);

                drawcarded.Play();
            }
            if (p3 == 1)
            {
                ListViewItem veteranshos = new ListViewItem();
                veteranshospitaltrd1 = 1;
                btntrad1.Visible = false;
                veteranshos.ForeColor = Color.LightGoldenrodYellow;
                veteranshos.Text = "Veteran's Hospital";
                p1lvw.Items.Add(veteranshos);

                drawcarded.Play();
            }
            if (p4 == 1)
            {
                ListViewItem veteranshos = new ListViewItem();
                veteranshospitaltrd1 = 1;
                btntrad1.Visible = false;
                veteranshos.ForeColor = Color.LightGoldenrodYellow;
                veteranshos.Text = "Veteran's Hospital";
                p1lvw.Items.Add(veteranshos);

                drawcarded.Play();
            }
            if (det == 1 || det == 1 && p1trad == 1 || det == 1 && p2trad == 1 || det == 1 && p3trad == 1 || det == 1 && p4trad == 1)
            {
                p1tr.Visible = true;
                pbdet1.Visible = true;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                veteranshospitaldet1 = 1;
                pb1x1.Enabled = false;
                pb1x2.Enabled = false;
                pb1x3.Enabled = false;
                pb1x4.Enabled = false;
                pb1x5.Enabled = false;
                pb1x6.Enabled = false;
                pb1x7.Enabled = false;
                pb1x8.Enabled = false;
                pb1x9.Enabled = false;
                pb1x10.Enabled = false;
                pb1x11.Enabled = false;
                pb1x12.Enabled = false;
                pb1x13.Enabled = false;
                pb1x14.Enabled = false;
                pb1x15.Enabled = false;
                pb1x16.Enabled = false;
                pb1x17.Enabled = false;
                pb1x18.Enabled = false;
                pb1x19.Enabled = false;
                pb1x20.Enabled = false;
                pb1x21.Enabled = false;
                pb1x22.Enabled = false;
                pb1x23.Enabled = false;
                pb1x24.Enabled = false;
                pb1x25.Enabled = false;
                pb1x26.Enabled = false;
                pb1x27.Enabled = false;
                pb1x28.Enabled = false;
                pbdet1.Image = bankers_game_proto.Properties.Resources.VETERANS_Hospital;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb1x18_Click(object sender, EventArgs e)
        {
            if (p1 == 1)
            {
                ListViewItem pearlmal = new ListViewItem();
                pearlmalltrd1 = 1;
                btntrad1.Visible = false;
                pearlmal.ForeColor = Color.Green;
                pearlmal.Text = "Pearl Mall";
                p1lvw.Items.Add(pearlmal);

                drawcarded.Play();
            }
            if (p2 == 1)
            {
                ListViewItem pearlmal = new ListViewItem();
                pearlmalltrd1 = 1;
                btntrad1.Visible = false;
                pearlmal.ForeColor = Color.Green;
                pearlmal.Text = "Pearl Mall";
                p1lvw.Items.Add(pearlmal);

                drawcarded.Play();
            }
            if (p3 == 1)
            {
                ListViewItem pearlmal = new ListViewItem();
                pearlmalltrd1 = 1;
                btntrad1.Visible = false;
                pearlmal.ForeColor = Color.Green;
                pearlmal.Text = "Pearl Mall";
                p1lvw.Items.Add(pearlmal);

                drawcarded.Play();
            }
            if (p4 == 1)
            {
                ListViewItem pearlmal = new ListViewItem();
                pearlmalltrd1 = 1;
                btntrad1.Visible = false;
                pearlmal.ForeColor = Color.Green;
                pearlmal.Text = "Pearl Mall";
                p1lvw.Items.Add(pearlmal);

                drawcarded.Play();
            }
            if (det == 1 || det == 1 && p1trad == 1 || det == 1 && p2trad == 1 || det == 1 && p3trad == 1 || det == 1 && p4trad == 1)
            {
                p1tr.Visible = true;
                pbdet1.Visible = true;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                pearlmalldet1 = 1;
                pb1x1.Enabled = false;
                pb1x2.Enabled = false;
                pb1x3.Enabled = false;
                pb1x4.Enabled = false;
                pb1x5.Enabled = false;
                pb1x6.Enabled = false;
                pb1x7.Enabled = false;
                pb1x8.Enabled = false;
                pb1x9.Enabled = false;
                pb1x10.Enabled = false;
                pb1x11.Enabled = false;
                pb1x12.Enabled = false;
                pb1x13.Enabled = false;
                pb1x14.Enabled = false;
                pb1x15.Enabled = false;
                pb1x16.Enabled = false;
                pb1x17.Enabled = false;
                pb1x18.Enabled = false;
                pb1x19.Enabled = false;
                pb1x20.Enabled = false;
                pb1x21.Enabled = false;
                pb1x22.Enabled = false;
                pb1x23.Enabled = false;
                pb1x24.Enabled = false;
                pb1x25.Enabled = false;
                pb1x26.Enabled = false;
                pb1x27.Enabled = false;
                pb1x28.Enabled = false;
                pbdet1.Image = bankers_game_proto.Properties.Resources.Pearl_Mall;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb1x19_Click(object sender, EventArgs e)
        {
            if (p1 == 1)
            {
                ListViewItem megamal = new ListViewItem();
                megamalltrd1 = 1;
                btntrad1.Visible = false;
                megamal.ForeColor = Color.Green;
                megamal.Text = "Mega Mall";
                p1lvw.Items.Add(megamal);

                drawcarded.Play();
            }
            if (p2 == 1)
            {
                ListViewItem megamal = new ListViewItem();
                megamalltrd1 = 1;
                btntrad1.Visible = false;
                megamal.ForeColor = Color.Green;
                megamal.Text = "Mega Mall";
                p1lvw.Items.Add(megamal);

                drawcarded.Play();
            }
            if (p3 == 1)
            {
                ListViewItem megamal = new ListViewItem();
                megamalltrd1 = 1;
                btntrad1.Visible = false;
                megamal.ForeColor = Color.Green;
                megamal.Text = "Mega Mall";
                p1lvw.Items.Add(megamal);

                drawcarded.Play();
            }
            if (p4 == 1)
            {
                ListViewItem megamal = new ListViewItem();
                megamalltrd1 = 1;
                btntrad1.Visible = false;
                megamal.ForeColor = Color.Green;
                megamal.Text = "Mega Mall";
                p1lvw.Items.Add(megamal);

                drawcarded.Play();
            }
            if (det == 1 || det == 1 && p1trad == 1 || det == 1 && p2trad == 1 || det == 1 && p3trad == 1 || det == 1 && p4trad == 1)
            {
                p1tr.Visible = true;
                pbdet1.Visible = true;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                megamalldet1 = 1;
                pb1x1.Enabled = false;
                pb1x2.Enabled = false;
                pb1x3.Enabled = false;
                pb1x4.Enabled = false;
                pb1x5.Enabled = false;
                pb1x6.Enabled = false;
                pb1x7.Enabled = false;
                pb1x8.Enabled = false;
                pb1x9.Enabled = false;
                pb1x10.Enabled = false;
                pb1x11.Enabled = false;
                pb1x12.Enabled = false;
                pb1x13.Enabled = false;
                pb1x14.Enabled = false;
                pb1x15.Enabled = false;
                pb1x16.Enabled = false;
                pb1x17.Enabled = false;
                pb1x18.Enabled = false;
                pb1x19.Enabled = false;
                pb1x20.Enabled = false;
                pb1x21.Enabled = false;
                pb1x22.Enabled = false;
                pb1x23.Enabled = false;
                pb1x24.Enabled = false;
                pb1x25.Enabled = false;
                pb1x26.Enabled = false;
                pb1x27.Enabled = false;
                pb1x28.Enabled = false;
                pbdet1.Image = bankers_game_proto.Properties.Resources.Mega_mall;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb1x20_Click(object sender, EventArgs e)
        {
            if (p1 == 1)
            {
                ListViewItem articmal = new ListViewItem();
                articmalltr1 = 1;
                btntrad1.Visible = false;
                articmal.ForeColor = Color.Green;
                articmal.Text = "Artic Mall";
                p1lvw.Items.Add(articmal);

                drawcarded.Play();
            }
            if (p2 == 1)
            {
                ListViewItem articmal = new ListViewItem();
                articmalltr1 = 1;
                btntrad1.Visible = false;
                articmal.ForeColor = Color.Green;
                articmal.Text = "Artic Mall";
                p1lvw.Items.Add(articmal);

                drawcarded.Play();
            }
            if (p3 == 1)
            {
                ListViewItem articmal = new ListViewItem();
                articmalltr1 = 1;
                btntrad1.Visible = false;
                articmal.ForeColor = Color.Green;
                articmal.Text = "Artic Mall";
                p1lvw.Items.Add(articmal);

                drawcarded.Play();
            }
            if (p4 == 1)
            {
                ListViewItem articmal = new ListViewItem();
                articmalltr1 = 1;
                btntrad1.Visible = false;
                articmal.ForeColor = Color.Green;
                articmal.Text = "Artic Mall";
                p1lvw.Items.Add(articmal);

                drawcarded.Play();
            }
            if (det == 1 || det == 1 && p1trad == 1 || det == 1 && p2trad == 1 || det == 1 && p3trad == 1 || det == 1 && p4trad == 1)
            {
                p1tr.Visible = true;
                pbdet1.Visible = true;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                articmalldet1 = 1;
                pb1x1.Enabled = false;
                pb1x2.Enabled = false;
                pb1x3.Enabled = false;
                pb1x4.Enabled = false;
                pb1x5.Enabled = false;
                pb1x6.Enabled = false;
                pb1x7.Enabled = false;
                pb1x8.Enabled = false;
                pb1x9.Enabled = false;
                pb1x10.Enabled = false;
                pb1x11.Enabled = false;
                pb1x12.Enabled = false;
                pb1x13.Enabled = false;
                pb1x14.Enabled = false;
                pb1x15.Enabled = false;
                pb1x16.Enabled = false;
                pb1x17.Enabled = false;
                pb1x18.Enabled = false;
                pb1x19.Enabled = false;
                pb1x20.Enabled = false;
                pb1x21.Enabled = false;
                pb1x22.Enabled = false;
                pb1x23.Enabled = false;
                pb1x24.Enabled = false;
                pb1x25.Enabled = false;
                pb1x26.Enabled = false;
                pb1x27.Enabled = false;
                pb1x28.Enabled = false;
                pbdet1.Image = bankers_game_proto.Properties.Resources.Artic_mall;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb1x21_Click(object sender, EventArgs e)
        {
            if (p1 == 1)
            {
                ListViewItem heavenlymal = new ListViewItem();
                heavenlymalltrd1 = 1;
                btntrad1.Visible = false;
                heavenlymal.ForeColor = Color.DarkBlue;
                heavenlymal.Text = "Heavenly Mall";
                p1lvw.Items.Add(heavenlymal);

                drawcarded.Play();
            }

            if (p2 == 1)
            {
                ListViewItem heavenlymal = new ListViewItem();
                heavenlymalltrd1 = 1;
                btntrad1.Visible = false;
                heavenlymal.ForeColor = Color.DarkBlue;
                heavenlymal.Text = "Heavenly Mall";
                p1lvw.Items.Add(heavenlymal);

                drawcarded.Play();
            }

            if (p3 == 1)
            {
                ListViewItem heavenlymal = new ListViewItem();
                heavenlymalltrd1 = 1;
                btntrad1.Visible = false;
                heavenlymal.ForeColor = Color.DarkBlue;
                heavenlymal.Text = "Heavenly Mall";
                p1lvw.Items.Add(heavenlymal);

                drawcarded.Play();
            }

            if (p4 == 1)
            {
                ListViewItem heavenlymal = new ListViewItem();
                heavenlymalltrd1 = 1;
                btntrad1.Visible = false;
                heavenlymal.ForeColor = Color.DarkBlue;
                heavenlymal.Text = "Heavenly Mall";
                p1lvw.Items.Add(heavenlymal);

                drawcarded.Play();
            }
            if (det == 1 || det == 1 && p1trad == 1 || det == 1 && p2trad == 1 || det == 1 && p3trad == 1 || det == 1 && p4trad == 1)
            {
                p1tr.Visible = true;
                pbdet1.Visible = true;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                heavenlymalldet1 = 1;
                pb1x1.Enabled = false;
                pb1x2.Enabled = false;
                pb1x3.Enabled = false;
                pb1x4.Enabled = false;
                pb1x5.Enabled = false;
                pb1x6.Enabled = false;
                pb1x7.Enabled = false;
                pb1x8.Enabled = false;
                pb1x9.Enabled = false;
                pb1x10.Enabled = false;
                pb1x11.Enabled = false;
                pb1x12.Enabled = false;
                pb1x13.Enabled = false;
                pb1x14.Enabled = false;
                pb1x15.Enabled = false;
                pb1x16.Enabled = false;
                pb1x17.Enabled = false;
                pb1x18.Enabled = false;
                pb1x19.Enabled = false;
                pb1x20.Enabled = false;
                pb1x21.Enabled = false;
                pb1x22.Enabled = false;
                pb1x23.Enabled = false;
                pb1x24.Enabled = false;
                pb1x25.Enabled = false;
                pb1x26.Enabled = false;
                pb1x27.Enabled = false;
                pb1x28.Enabled = false;
                pbdet1.Image = bankers_game_proto.Properties.Resources.Heavenly_mall;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb1x22_Click(object sender, EventArgs e)
        {
            if (p1 == 1)
            {
                ListViewItem shangrillamal = new ListViewItem();
                shangrillamalltrd1 = 1;
                btntrad1.Visible = false;
                shangrillamal.ForeColor = Color.DarkBlue;
                shangrillamal.Text = "Shangrilla Mall";
                p1lvw.Items.Add(shangrillamal);

                drawcarded.Play();
            }
            if (p2 == 1)
            {
                ListViewItem shangrillamal = new ListViewItem();
                shangrillamalltrd1 = 1;
                btntrad1.Visible = false;
                shangrillamal.ForeColor = Color.DarkBlue;
                shangrillamal.Text = "Shangrilla Mall";
                p1lvw.Items.Add(shangrillamal);

                drawcarded.Play();
            }
            if (p3 == 1)
            {
                ListViewItem shangrillamal = new ListViewItem();
                shangrillamalltrd1 = 1;
                btntrad1.Visible = false;
                shangrillamal.ForeColor = Color.DarkBlue;
                shangrillamal.Text = "Shangrilla Mall";
                p1lvw.Items.Add(shangrillamal);

                drawcarded.Play();
            }
            if (p4 == 1)
            {
                ListViewItem shangrillamal = new ListViewItem();
                shangrillamalltrd1 = 1;
                btntrad1.Visible = false;
                shangrillamal.ForeColor = Color.DarkBlue;
                shangrillamal.Text = "Shangrilla Mall";
                p1lvw.Items.Add(shangrillamal);

                drawcarded.Play();
            }
            if (det == 1 || det == 1 && p1trad == 1 || det == 1 && p2trad == 1 || det == 1 && p3trad == 1 || det == 1 && p4trad == 1)
            {
                p1tr.Visible = true;
                pbdet1.Visible = true;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                shangrillamalldet1 = 1;
                pb1x1.Enabled = false;
                pb1x2.Enabled = false;
                pb1x3.Enabled = false;
                pb1x4.Enabled = false;
                pb1x5.Enabled = false;
                pb1x6.Enabled = false;
                pb1x7.Enabled = false;
                pb1x8.Enabled = false;
                pb1x9.Enabled = false;
                pb1x10.Enabled = false;
                pb1x11.Enabled = false;
                pb1x12.Enabled = false;
                pb1x13.Enabled = false;
                pb1x14.Enabled = false;
                pb1x15.Enabled = false;
                pb1x16.Enabled = false;
                pb1x17.Enabled = false;
                pb1x18.Enabled = false;
                pb1x19.Enabled = false;
                pb1x20.Enabled = false;
                pb1x21.Enabled = false;
                pb1x22.Enabled = false;
                pb1x23.Enabled = false;
                pb1x24.Enabled = false;
                pb1x25.Enabled = false;
                pb1x26.Enabled = false;
                pb1x27.Enabled = false;
                pb1x28.Enabled = false;
                pbdet1.Image = bankers_game_proto.Properties.Resources.Shangrilla_Mall;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb1x23_Click(object sender, EventArgs e)
        {
            if (p1 == 1)
            {
                ListViewItem meralco = new ListViewItem();
                utility1x1trd1 = 1;
                btntrad1.Visible = false;
                meralco.ForeColor = Color.Yellow;
                meralco.Text = "Meralco Electricity";
                p1lvw.Items.Add(meralco);

                drawcarded.Play();
            }
            if (p2 == 1)
            {
                ListViewItem meralco = new ListViewItem();
                utility1x1trd1 = 1;
                btntrad1.Visible = false;
                meralco.ForeColor = Color.Yellow;
                meralco.Text = "Meralco Electricity";
                p1lvw.Items.Add(meralco);

                drawcarded.Play();
            }
            if (p3 == 1)
            {
                ListViewItem meralco = new ListViewItem();
                utility1x1trd1 = 1;
                btntrad1.Visible = false;
                meralco.ForeColor = Color.Yellow;
                meralco.Text = "Meralco Electricity";
                p1lvw.Items.Add(meralco);

                drawcarded.Play();
            }
            if (p4 == 1)
            {
                ListViewItem meralco = new ListViewItem();
                utility1x1trd1 = 1;
                btntrad1.Visible = false;
                meralco.ForeColor = Color.Yellow;
                meralco.Text = "Meralco Electricity";
                p1lvw.Items.Add(meralco);

                drawcarded.Play();
            }
            if (det == 1 || det == 1 && p1trad == 1 || det == 1 && p2trad == 1 || det == 1 && p3trad == 1 || det == 1 && p4trad == 1)
            {
                p1tr.Visible = true;
                pbdet1.Visible = true;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                utility1x1det1 = 1;
                pb1x1.Enabled = false;
                pb1x2.Enabled = false;
                pb1x3.Enabled = false;
                pb1x4.Enabled = false;
                pb1x5.Enabled = false;
                pb1x6.Enabled = false;
                pb1x7.Enabled = false;
                pb1x8.Enabled = false;
                pb1x9.Enabled = false;
                pb1x10.Enabled = false;
                pb1x11.Enabled = false;
                pb1x12.Enabled = false;
                pb1x13.Enabled = false;
                pb1x14.Enabled = false;
                pb1x15.Enabled = false;
                pb1x16.Enabled = false;
                pb1x17.Enabled = false;
                pb1x18.Enabled = false;
                pb1x19.Enabled = false;
                pb1x20.Enabled = false;
                pb1x21.Enabled = false;
                pb1x22.Enabled = false;
                pb1x23.Enabled = false;
                pb1x24.Enabled = false;
                pb1x25.Enabled = false;
                pb1x26.Enabled = false;
                pb1x27.Enabled = false;
                pb1x28.Enabled = false;
                pbdet1.Image = bankers_game_proto.Properties.Resources.Meralco;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb1x24_Click(object sender, EventArgs e)
        {
            if (p1 == 1)
            {
                ListViewItem niagra = new ListViewItem();
                utility1x2trd1 = 1;
                btntrad1.Visible = false;
                niagra.ForeColor = Color.Yellow;
                niagra.Text = "Niagra Falls Electricity";
                p1lvw.Items.Add(niagra);

                drawcarded.Play();
            }
            if (p2 == 1)
            {
                ListViewItem niagra = new ListViewItem();
                utility1x2trd1 = 1;
                btntrad1.Visible = false;
                niagra.ForeColor = Color.Yellow;
                niagra.Text = "Niagra Falls Electricity";
                p1lvw.Items.Add(niagra);

                drawcarded.Play();
            }
            if (p3 == 1)
            {
                ListViewItem niagra = new ListViewItem();
                utility1x2trd1 = 1;
                btntrad1.Visible = false;
                niagra.ForeColor = Color.Yellow;
                niagra.Text = "Niagra Falls Electricity";
                p1lvw.Items.Add(niagra);

                drawcarded.Play();
            }
            if (p4 == 1)
            {
                ListViewItem niagra = new ListViewItem();
                utility1x2trd1 = 1;
                btntrad1.Visible = false;
                niagra.ForeColor = Color.Yellow;
                niagra.Text = "Niagra Falls Electricity";
                p1lvw.Items.Add(niagra);

                drawcarded.Play();
            }
            if (det == 1 || det == 1 && p1trad == 1 || det == 1 && p2trad == 1 || det == 1 && p3trad == 1 || det == 1 && p4trad == 1)
            {
                p1tr.Visible = true;
                pbdet1.Visible = true;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                utility1x2det1 = 1;
                pb1x1.Enabled = false;
                pb1x2.Enabled = false;
                pb1x3.Enabled = false;
                pb1x4.Enabled = false;
                pb1x5.Enabled = false;
                pb1x6.Enabled = false;
                pb1x7.Enabled = false;
                pb1x8.Enabled = false;
                pb1x9.Enabled = false;
                pb1x10.Enabled = false;
                pb1x11.Enabled = false;
                pb1x12.Enabled = false;
                pb1x13.Enabled = false;
                pb1x14.Enabled = false;
                pb1x15.Enabled = false;
                pb1x16.Enabled = false;
                pb1x17.Enabled = false;
                pb1x18.Enabled = false;
                pb1x19.Enabled = false;
                pb1x20.Enabled = false;
                pb1x21.Enabled = false;
                pb1x22.Enabled = false;
                pb1x23.Enabled = false;
                pb1x24.Enabled = false;
                pb1x25.Enabled = false;
                pb1x26.Enabled = false;
                pb1x27.Enabled = false;
                pb1x28.Enabled = false;
                pbdet1.Image = bankers_game_proto.Properties.Resources.Niagra_Fall;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb1x25_Click(object sender, EventArgs e)
        {
            if (p1 == 1)
            {
                ListViewItem rose = new ListViewItem();
                transportation1x1trd1 = 1;
                btntrad1.Visible = false;
                rose.ForeColor = Color.SteelBlue;
                rose.Text = "Rosevelt Station";
                p1lvw.Items.Add(rose);

                drawcarded.Play();
            }
            if (p2 == 1)
            {
                ListViewItem rose = new ListViewItem();
                transportation1x1trd1 = 1;
                btntrad1.Visible = false;
                rose.ForeColor = Color.SteelBlue;
                rose.Text = "Rosevelt Station";
                p1lvw.Items.Add(rose);

                drawcarded.Play();
            }
            if (p3 == 1)
            {
                ListViewItem rose = new ListViewItem();
                transportation1x1trd1 = 1;
                btntrad1.Visible = false;
                rose.ForeColor = Color.SteelBlue;
                rose.Text = "Rosevelt Station";
                p1lvw.Items.Add(rose);

                drawcarded.Play();
            }
            if (p4 == 1)
            {
                ListViewItem rose = new ListViewItem();
                transportation1x1trd1 = 1;
                btntrad1.Visible = false;
                rose.ForeColor = Color.SteelBlue;
                rose.Text = "Rosevelt Station";
                p1lvw.Items.Add(rose);

                drawcarded.Play();
            }
            if (det == 1 || det == 1 && p1trad == 1 || det == 1 && p2trad == 1 || det == 1 && p3trad == 1 || det == 1 && p4trad == 1)
            {
                p1tr.Visible = true;
                pbdet1.Visible = true;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                transportation1x1det1 = 1;
                pb1x1.Enabled = false;
                pb1x2.Enabled = false;
                pb1x3.Enabled = false;
                pb1x4.Enabled = false;
                pb1x5.Enabled = false;
                pb1x6.Enabled = false;
                pb1x7.Enabled = false;
                pb1x8.Enabled = false;
                pb1x9.Enabled = false;
                pb1x10.Enabled = false;
                pb1x11.Enabled = false;
                pb1x12.Enabled = false;
                pb1x13.Enabled = false;
                pb1x14.Enabled = false;
                pb1x15.Enabled = false;
                pb1x16.Enabled = false;
                pb1x17.Enabled = false;
                pb1x18.Enabled = false;
                pb1x19.Enabled = false;
                pb1x20.Enabled = false;
                pb1x21.Enabled = false;
                pb1x22.Enabled = false;
                pb1x23.Enabled = false;
                pb1x24.Enabled = false;
                pb1x25.Enabled = false;
                pb1x26.Enabled = false;
                pb1x27.Enabled = false;
                pb1x28.Enabled = false;
                pbdet1.Image = bankers_game_proto.Properties.Resources.Rosevelt_Station;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb1x26_Click(object sender, EventArgs e)
        {
            if (p1 == 1)
            {
                ListViewItem santol = new ListViewItem();
                transportation1x2trd1 = 1;
                btntrad1.Visible = false;
                santol.ForeColor = Color.SteelBlue;
                santol.Text = "Santolan Station";
                p1lvw.Items.Add(santol);

                drawcarded.Play();
            }
            if (p2 == 1)
            {
                ListViewItem santol = new ListViewItem();
                transportation1x2trd1 = 1;
                btntrad1.Visible = false;
                santol.ForeColor = Color.SteelBlue;
                santol.Text = "Santolan Station";
                p1lvw.Items.Add(santol);

                drawcarded.Play();
            }
            if (p3 == 1)
            {
                ListViewItem santol = new ListViewItem();
                transportation1x2trd1 = 1;
                btntrad1.Visible = false;
                santol.ForeColor = Color.SteelBlue;
                santol.Text = "Santolan Station";
                p1lvw.Items.Add(santol);

                drawcarded.Play();
            }
            if (p4 == 1)
            {
                ListViewItem santol = new ListViewItem();
                transportation1x2trd1 = 1;
                btntrad1.Visible = false;
                santol.ForeColor = Color.SteelBlue;
                santol.Text = "Santolan Station";
                p1lvw.Items.Add(santol);

                drawcarded.Play();
            }
            if (det == 1 || det == 1 && p1trad == 1 || det == 1 && p2trad == 1 || det == 1 && p3trad == 1 || det == 1 && p4trad == 1)
            {
                p1tr.Visible = true;
                pbdet1.Visible = true;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                transportation1x2det1 = 1;
                pb1x1.Enabled = false;
                pb1x2.Enabled = false;
                pb1x3.Enabled = false;
                pb1x4.Enabled = false;
                pb1x5.Enabled = false;
                pb1x6.Enabled = false;
                pb1x7.Enabled = false;
                pb1x8.Enabled = false;
                pb1x9.Enabled = false;
                pb1x10.Enabled = false;
                pb1x11.Enabled = false;
                pb1x12.Enabled = false;
                pb1x13.Enabled = false;
                pb1x14.Enabled = false;
                pb1x15.Enabled = false;
                pb1x16.Enabled = false;
                pb1x17.Enabled = false;
                pb1x18.Enabled = false;
                pb1x19.Enabled = false;
                pb1x20.Enabled = false;
                pb1x21.Enabled = false;
                pb1x22.Enabled = false;
                pb1x23.Enabled = false;
                pb1x24.Enabled = false;
                pb1x25.Enabled = false;
                pb1x26.Enabled = false;
                pb1x27.Enabled = false;
                pb1x28.Enabled = false;
                pbdet1.Image = bankers_game_proto.Properties.Resources.Santolan_Station;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb1x27_Click(object sender, EventArgs e)
        {
            if (p1 == 1)
            {
                ListViewItem fairview = new ListViewItem();
                transportation1x3trd1 = 1;
                btntrad1.Visible = false;
                fairview.ForeColor = Color.SteelBlue;
                fairview.Text = "Quezon Station";
                p1lvw.Items.Add(fairview);

                drawcarded.Play();
            }
            if (p2 == 1)
            {
                ListViewItem fairview = new ListViewItem();
                transportation1x3trd1 = 1;
                btntrad1.Visible = false;
                fairview.ForeColor = Color.SteelBlue;
                fairview.Text = "Quezon Station";
                p1lvw.Items.Add(fairview);

                drawcarded.Play();
            }
            if (p3 == 1)
            {
                ListViewItem fairview = new ListViewItem();
                transportation1x3trd1 = 1;
                btntrad1.Visible = false;
                fairview.ForeColor = Color.SteelBlue;
                fairview.Text = "Quezon Station";
                p1lvw.Items.Add(fairview);

                drawcarded.Play();
            }
            if (p4 == 1)
            {
                ListViewItem fairview = new ListViewItem();
                transportation1x3trd1 = 1;
                btntrad1.Visible = false;
                fairview.ForeColor = Color.SteelBlue;
                fairview.Text = "Quezon Station";
                p1lvw.Items.Add(fairview);

                drawcarded.Play();
            }
            if (det == 1 || det == 1 && p1trad == 1 || det == 1 && p2trad == 1 || det == 1 && p3trad == 1 || det == 1 && p4trad == 1)
            {
                p1tr.Visible = true;
                pbdet1.Visible = true;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                transportation1x3det1 = 1;
                pb1x1.Enabled = false;
                pb1x2.Enabled = false;
                pb1x3.Enabled = false;
                pb1x4.Enabled = false;
                pb1x5.Enabled = false;
                pb1x6.Enabled = false;
                pb1x7.Enabled = false;
                pb1x8.Enabled = false;
                pb1x9.Enabled = false;
                pb1x10.Enabled = false;
                pb1x11.Enabled = false;
                pb1x12.Enabled = false;
                pb1x13.Enabled = false;
                pb1x14.Enabled = false;
                pb1x15.Enabled = false;
                pb1x16.Enabled = false;
                pb1x17.Enabled = false;
                pb1x18.Enabled = false;
                pb1x19.Enabled = false;
                pb1x20.Enabled = false;
                pb1x21.Enabled = false;
                pb1x22.Enabled = false;
                pb1x23.Enabled = false;
                pb1x24.Enabled = false;
                pb1x25.Enabled = false;
                pb1x26.Enabled = false;
                pb1x27.Enabled = false;
                pb1x28.Enabled = false;
                pbdet1.Image = bankers_game_proto.Properties.Resources.Quezon_Station;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb1x28_Click(object sender, EventArgs e)
        {
            if (p1 == 1)
            {
                ListViewItem stame = new ListViewItem();
                transportation1x4trd1 = 1;
                btntrad1.Visible = false;
                stame.ForeColor = Color.SteelBlue;
                stame.Text = "Trinoma Station";
                p1lvw.Items.Add(stame);

                drawcarded.Play();
            }

            if (p2 == 1)
            {
                ListViewItem stame = new ListViewItem();
                transportation1x4trd1 = 1;
                btntrad1.Visible = false;
                stame.ForeColor = Color.SteelBlue;
                stame.Text = "Trinoma Station";
                p1lvw.Items.Add(stame);

                drawcarded.Play();
            }

            if (p3 == 1)
            {
                ListViewItem stame = new ListViewItem();
                transportation1x4trd1 = 1;
                btntrad1.Visible = false;
                stame.ForeColor = Color.SteelBlue;
                stame.Text = "Trinoma Station";
                p1lvw.Items.Add(stame);

                drawcarded.Play();
            }

            if (p4 == 1)
            {
                ListViewItem stame = new ListViewItem();
                transportation1x4trd1 = 1;
                btntrad1.Visible = false;
                stame.ForeColor = Color.SteelBlue;
                stame.Text = "Trinoma Station";
                p1lvw.Items.Add(stame);

                drawcarded.Play();
            }
            if (det == 1 || det == 1 && p1trad == 1 || det == 1 && p2trad == 1 || det == 1 && p3trad == 1 || det == 1 && p4trad == 1)
            {
                p1tr.Visible = true;
                pbdet1.Visible = true;
                btntrad1.Visible = true;
                btnback1.Visible = true;
                transportation1x4det1 = 1;
                pb1x1.Enabled = false;
                pb1x2.Enabled = false;
                pb1x3.Enabled = false;
                pb1x4.Enabled = false;
                pb1x5.Enabled = false;
                pb1x6.Enabled = false;
                pb1x7.Enabled = false;
                pb1x8.Enabled = false;
                pb1x9.Enabled = false;
                pb1x10.Enabled = false;
                pb1x11.Enabled = false;
                pb1x12.Enabled = false;
                pb1x13.Enabled = false;
                pb1x14.Enabled = false;
                pb1x15.Enabled = false;
                pb1x16.Enabled = false;
                pb1x17.Enabled = false;
                pb1x18.Enabled = false;
                pb1x19.Enabled = false;
                pb1x20.Enabled = false;
                pb1x21.Enabled = false;
                pb1x22.Enabled = false;
                pb1x23.Enabled = false;
                pb1x24.Enabled = false;
                pb1x25.Enabled = false;
                pb1x26.Enabled = false;
                pb1x27.Enabled = false;
                pb1x28.Enabled = false;
                pbdet1.Image = bankers_game_proto.Properties.Resources.Trinoma_Station;
                drawcarded.Play();
            }
            drawcarded.Play();
        }



        #endregion

        #region props2
        private void pb2x1_Click(object sender, EventArgs e)
        {
            if (det == 2 || det == 2 && p1 == 1 || det == 2 && p2 == 1 || det == 2 && p3 == 1 || det == 2 && p4 == 1)
            {
                p2tr.Visible = true;
                pbdet2.Visible = true;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                easternschooldet2 = 1;
                pb2x1.Enabled = false;
                pb2x2.Enabled = false;
                pb2x3.Enabled = false;
                pb2x4.Enabled = false;
                pb2x5.Enabled = false;
                pb2x6.Enabled = false;
                pb2x7.Enabled = false;
                pb2x8.Enabled = false;
                pb2x9.Enabled = false;
                pb2x10.Enabled = false;
                pb2x11.Enabled = false;
                pb2x12.Enabled = false;
                pb2x13.Enabled = false;
                pb2x14.Enabled = false;
                pb2x15.Enabled = false;
                pb2x16.Enabled = false;
                pb2x17.Enabled = false;
                pb2x18.Enabled = false;
                pb2x19.Enabled = false;
                pb2x20.Enabled = false;
                pb2x21.Enabled = false;
                pb2x22.Enabled = false;
                pb2x23.Enabled = false;
                pb2x24.Enabled = false;
                pb2x25.Enabled = false;
                pb2x26.Enabled = false;
                pb2x27.Enabled = false;
                pb2x28.Enabled = false;
                pbdet2.Image = bankers_game_proto.Properties.Resources.Eastern_School_Purple_t;
                drawcarded.Play();
            }
            if (p1trad == 1)
            {
                ListViewItem eastern = new ListViewItem();
                easternschooltrd2 = 1;
                btntrad2.Visible = false;
                eastern.ForeColor = Color.Purple;
                eastern.Text = "Eastern School";
                p2lvw.Items.Add(eastern);

                drawcarded.Play();
            }
            if (p2trad == 1)
            {
                ListViewItem eastern = new ListViewItem();
                easternschooltrd2 = 1;
                btntrad2.Visible = false;
                eastern.ForeColor = Color.Purple;
                eastern.Text = "Eastern School";
                p2lvw.Items.Add(eastern);

                drawcarded.Play();
            }
            if (p3trad == 1)
            {
                ListViewItem eastern = new ListViewItem();
                easternschooltrd2 = 1;
                btntrad2.Visible = false;
                eastern.ForeColor = Color.Purple;
                eastern.Text = "Eastern School";
                p2lvw.Items.Add(eastern);

                drawcarded.Play();
            }
            if (p4trad == 1)
            {
                ListViewItem eastern = new ListViewItem();
                easternschooltrd2 = 1;
                btntrad2.Visible = false;
                eastern.ForeColor = Color.Purple;
                eastern.Text = "Eastern School";
                p2lvw.Items.Add(eastern);

                drawcarded.Play();
            }

            drawcarded.Play();
        }

        private void pb2x2_Click(object sender, EventArgs e)
        {
            if (p1trad == 1)
            {
                ListViewItem west = new ListViewItem();
                westernschooltrd2 = 1;
                btntrad2.Visible = false;
                west.ForeColor = Color.Purple;
                west.Text = "Western School";
                p2lvw.Items.Add(west);


                drawcarded.Play();
            }
            if (p2trad == 1)
            {
                ListViewItem west = new ListViewItem();
                westernschooltrd2 = 1;
                btntrad2.Visible = false;
                west.ForeColor = Color.Purple;
                west.Text = "Western School";
                p2lvw.Items.Add(west);


                drawcarded.Play();
            }
            if (p3trad == 1)
            {
                ListViewItem west = new ListViewItem();
                westernschooltrd2 = 1;
                btntrad2.Visible = false;
                west.ForeColor = Color.Purple;
                west.Text = "Western School";
                p2lvw.Items.Add(west);


                drawcarded.Play();
            }
            if (p4trad == 1)
            {
                ListViewItem west = new ListViewItem();
                westernschooltrd2 = 1;
                btntrad2.Visible = false;
                west.ForeColor = Color.Purple;
                west.Text = "Western School";
                p2lvw.Items.Add(west);


                drawcarded.Play();
            }
            if (det == 2 || det == 2 && p1 == 1 || det == 2 && p2 == 1 || det == 2 && p3 == 1 || det == 2 && p4 == 1)
            {
                p2tr.Visible = true;
                pbdet2.Visible = true;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                westernschooldet2 = 1;
                pb2x1.Enabled = false;
                pb2x2.Enabled = false;
                pb2x3.Enabled = false;
                pb2x4.Enabled = false;
                pb2x5.Enabled = false;
                pb2x6.Enabled = false;
                pb2x7.Enabled = false;
                pb2x8.Enabled = false;
                pb2x9.Enabled = false;
                pb2x10.Enabled = false;
                pb2x11.Enabled = false;
                pb2x12.Enabled = false;
                pb2x13.Enabled = false;
                pb2x14.Enabled = false;
                pb2x15.Enabled = false;
                pb2x16.Enabled = false;
                pb2x17.Enabled = false;
                pb2x18.Enabled = false;
                pb2x19.Enabled = false;
                pb2x20.Enabled = false;
                pb2x21.Enabled = false;
                pb2x22.Enabled = false;
                pb2x23.Enabled = false;
                pb2x24.Enabled = false;
                pb2x25.Enabled = false;
                pb2x26.Enabled = false;
                pb2x27.Enabled = false;
                pb2x28.Enabled = false;
                pbdet2.Image = bankers_game_proto.Properties.Resources.Western_school_t;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb2x3_Click(object sender, EventArgs e)
        {
            if (p1trad == 1)
            {
                ListViewItem visayashigh = new ListViewItem();
                visayashighschooltrd2 = 1;
                btntrad2.Visible = false;
                visayashigh.ForeColor = Color.LightBlue;
                visayashigh.Text = "Visayas High-School";
                p2lvw.Items.Add(visayashigh);



                drawcarded.Play();
            }
            if (p2trad == 1)
            {
                ListViewItem visayashigh = new ListViewItem();
                visayashighschooltrd2 = 1;
                btntrad2.Visible = false;
                visayashigh.ForeColor = Color.LightBlue;
                visayashigh.Text = "Visayas High-School";
                p2lvw.Items.Add(visayashigh);



                drawcarded.Play();
            }
            if (p3trad == 1)
            {
                ListViewItem visayashigh = new ListViewItem();
                visayashighschooltrd2 = 1;
                btntrad2.Visible = false;
                visayashigh.ForeColor = Color.LightBlue;
                visayashigh.Text = "Visayas High-School";
                p2lvw.Items.Add(visayashigh);



                drawcarded.Play();
            }
            if (p4trad == 1)
            {
                ListViewItem visayashigh = new ListViewItem();
                visayashighschooltrd2 = 1;
                btntrad2.Visible = false;
                visayashigh.ForeColor = Color.LightBlue;
                visayashigh.Text = "Visayas High-School";
                p2lvw.Items.Add(visayashigh);



                drawcarded.Play();
            }
            if (det == 2 || det == 2 && p1 == 1 || det == 2 && p2 == 1 || det == 2 && p3 == 1 || det == 2 && p4 == 1)
            {
                p2tr.Visible = true;
                pbdet2.Visible = true;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                visayashighschooldet2 = 1;
                pb2x1.Enabled = false;
                pb2x2.Enabled = false;
                pb2x3.Enabled = false;
                pb2x4.Enabled = false;
                pb2x5.Enabled = false;
                pb2x6.Enabled = false;
                pb2x7.Enabled = false;
                pb2x8.Enabled = false;
                pb2x9.Enabled = false;
                pb2x10.Enabled = false;
                pb2x11.Enabled = false;
                pb2x12.Enabled = false;
                pb2x13.Enabled = false;
                pb2x14.Enabled = false;
                pb2x15.Enabled = false;
                pb2x16.Enabled = false;
                pb2x17.Enabled = false;
                pb2x18.Enabled = false;
                pb2x19.Enabled = false;
                pb2x20.Enabled = false;
                pb2x21.Enabled = false;
                pb2x22.Enabled = false;
                pb2x23.Enabled = false;
                pb2x24.Enabled = false;
                pb2x25.Enabled = false;
                pb2x26.Enabled = false;
                pb2x27.Enabled = false;
                pb2x28.Enabled = false;
                pbdet2.Image = bankers_game_proto.Properties.Resources.Visayas_highschool_t;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb2x4_Click(object sender, EventArgs e)
        {
            if (p1trad == 1)
            {
                ListViewItem southern = new ListViewItem();
                southernschooltrd2 = 1;
                btntrad2.Visible = false;
                southern.ForeColor = Color.LightBlue;
                southern.Text = "Southern School";
                p2lvw.Items.Add(southern);

                drawcarded.Play();
            }
            if (p2trad == 1)
            {
                ListViewItem southern = new ListViewItem();
                southernschooltrd2 = 1;
                btntrad2.Visible = false;
                southern.ForeColor = Color.LightBlue;
                southern.Text = "Southern School";
                p2lvw.Items.Add(southern);

                drawcarded.Play();
            }
            if (p3trad == 1)
            {
                ListViewItem southern = new ListViewItem();
                southernschooltrd2 = 1;
                btntrad2.Visible = false;
                southern.ForeColor = Color.LightBlue;
                southern.Text = "Southern School";
                p2lvw.Items.Add(southern);

                drawcarded.Play();
            }
            if (p4trad == 1)
            {
                ListViewItem southern = new ListViewItem();
                southernschooltrd2 = 1;
                btntrad2.Visible = false;
                southern.ForeColor = Color.LightBlue;
                southern.Text = "Southern School";
                p2lvw.Items.Add(southern);

                drawcarded.Play();
            }

            if (det == 2 || det == 2 && p1 == 1 || det == 2 && p2 == 1 || det == 2 && p3 == 1 || det == 2 && p4 == 1 || det == 2 || det == 2 && p1 == 1 || det == 2 && p2 == 1 || det == 2 && p3 == 1 || det == 2 && p4 == 1 && p1 == 1 || det == 2 && p2 == 1 || det == 2 && p3 == 1 || det == 2 && p4 == 1)
            {
                p2tr.Visible = true;
                pbdet2.Visible = true;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                southernschooldet2 = 1;
                pb2x1.Enabled = false;
                pb2x2.Enabled = false;
                pb2x3.Enabled = false;
                pb2x4.Enabled = false;
                pb2x5.Enabled = false;
                pb2x6.Enabled = false;
                pb2x7.Enabled = false;
                pb2x8.Enabled = false;
                pb2x9.Enabled = false;
                pb2x10.Enabled = false;
                pb2x11.Enabled = false;
                pb2x12.Enabled = false;
                pb2x13.Enabled = false;
                pb2x14.Enabled = false;
                pb2x15.Enabled = false;
                pb2x16.Enabled = false;
                pb2x17.Enabled = false;
                pb2x18.Enabled = false;
                pb2x19.Enabled = false;
                pb2x20.Enabled = false;
                pb2x21.Enabled = false;
                pb2x22.Enabled = false;
                pb2x23.Enabled = false;
                pb2x24.Enabled = false;
                pb2x25.Enabled = false;
                pb2x26.Enabled = false;
                pb2x27.Enabled = false;
                pb2x28.Enabled = false;
                pbdet2.Image = bankers_game_proto.Properties.Resources.Southern_highschool_t;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb2x5_Click(object sender, EventArgs e)
        {
            if (p1trad == 1)
            {
                ListViewItem nations = new ListViewItem();
                nationsschooltrd2 = 1;
                btntrad2.Visible = false;
                nations.ForeColor = Color.LightBlue;
                nations.Text = "Nation's School";
                p2lvw.Items.Add(nations);

                drawcarded.Play();
            }
            if (p2trad == 1)
            {
                ListViewItem nations = new ListViewItem();
                nationsschooltrd2 = 1;
                btntrad2.Visible = false;
                nations.ForeColor = Color.LightBlue;
                nations.Text = "Nation's School";
                p2lvw.Items.Add(nations);

                drawcarded.Play();
            }
            if (p3trad == 1)
            {
                ListViewItem nations = new ListViewItem();
                nationsschooltrd2 = 1;
                btntrad2.Visible = false;
                nations.ForeColor = Color.LightBlue;
                nations.Text = "Nation's School";
                p2lvw.Items.Add(nations);

                drawcarded.Play();
            }
            if (p4trad == 1)
            {
                ListViewItem nations = new ListViewItem();
                nationsschooltrd2 = 1;
                btntrad2.Visible = false;
                nations.ForeColor = Color.LightBlue;
                nations.Text = "Nation's School";
                p2lvw.Items.Add(nations);

                drawcarded.Play();
            }
            if (det == 2 || det == 2 && p1 == 1 || det == 2 && p2 == 1 || det == 2 && p3 == 1 || det == 2 && p4 == 1)
            {
                p2tr.Visible = true;
                pbdet2.Visible = true;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                nationsschooldet2 = 1;
                pb2x1.Enabled = false;
                pb2x2.Enabled = false;
                pb2x3.Enabled = false;
                pb2x4.Enabled = false;
                pb2x5.Enabled = false;
                pb2x6.Enabled = false;
                pb2x7.Enabled = false;
                pb2x8.Enabled = false;
                pb2x9.Enabled = false;
                pb2x10.Enabled = false;
                pb2x11.Enabled = false;
                pb2x12.Enabled = false;
                pb2x13.Enabled = false;
                pb2x14.Enabled = false;
                pb2x15.Enabled = false;
                pb2x16.Enabled = false;
                pb2x17.Enabled = false;
                pb2x18.Enabled = false;
                pb2x19.Enabled = false;
                pb2x20.Enabled = false;
                pb2x21.Enabled = false;
                pb2x22.Enabled = false;
                pb2x23.Enabled = false;
                pb2x24.Enabled = false;
                pb2x25.Enabled = false;
                pb2x26.Enabled = false;
                pb2x27.Enabled = false;
                pb2x28.Enabled = false;
                pbdet2.Image = bankers_game_proto.Properties.Resources.Nation_s_highschool_t;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb2x6_Click(object sender, EventArgs e)
        {
            if (p1trad == 1)
            {
                ListViewItem westma = new ListViewItem();
                westmarkettrd2 = 1;
                btntrad2.Visible = false;
                westma.ForeColor = Color.Pink;
                westma.Text = "West Market";
                p2lvw.Items.Add(westma);

                drawcarded.Play();
            }
            if (p2trad == 1)
            {
                ListViewItem westma = new ListViewItem();
                westmarkettrd2 = 1;
                btntrad2.Visible = false;
                westma.ForeColor = Color.Pink;
                westma.Text = "West Market";
                p2lvw.Items.Add(westma);

                drawcarded.Play();
            }
            if (p3trad == 1)
            {
                ListViewItem westma = new ListViewItem();
                westmarkettrd2 = 1;
                btntrad2.Visible = false;
                westma.ForeColor = Color.Pink;
                westma.Text = "West Market";
                p2lvw.Items.Add(westma);

                drawcarded.Play();
            }
            if (p4trad == 1)
            {
                ListViewItem westma = new ListViewItem();
                westmarkettrd2 = 1;
                btntrad2.Visible = false;
                westma.ForeColor = Color.Pink;
                westma.Text = "West Market";
                p2lvw.Items.Add(westma);

                drawcarded.Play();
            }
            if (det == 2 || det == 2 && p1 == 1 || det == 2 && p2 == 1 || det == 2 && p3 == 1 || det == 2 && p4 == 1)
            {
                p2tr.Visible = true;
                pbdet2.Visible = true;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                westmarketdet2 = 1;
                pb2x1.Enabled = false;
                pb2x2.Enabled = false;
                pb2x3.Enabled = false;
                pb2x4.Enabled = false;
                pb2x5.Enabled = false;
                pb2x6.Enabled = false;
                pb2x7.Enabled = false;
                pb2x8.Enabled = false;
                pb2x9.Enabled = false;
                pb2x10.Enabled = false;
                pb2x11.Enabled = false;
                pb2x12.Enabled = false;
                pb2x13.Enabled = false;
                pb2x14.Enabled = false;
                pb2x15.Enabled = false;
                pb2x16.Enabled = false;
                pb2x17.Enabled = false;
                pb2x18.Enabled = false;
                pb2x19.Enabled = false;
                pb2x20.Enabled = false;
                pb2x21.Enabled = false;
                pb2x22.Enabled = false;
                pb2x23.Enabled = false;
                pb2x24.Enabled = false;
                pb2x25.Enabled = false;
                pb2x26.Enabled = false;
                pb2x27.Enabled = false;
                pb2x28.Enabled = false;
                pbdet2.Image = bankers_game_proto.Properties.Resources.West_Market_t;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb2x7_Click(object sender, EventArgs e)
        {
            if (p1trad == 1)
            {
                ListViewItem nightma = new ListViewItem();
                nightmarkettrd2 = 1;
                btntrad2.Visible = false;
                nightma.ForeColor = Color.Pink;
                nightma.Text = "Night Market";
                p2lvw.Items.Add(nightma);

                drawcarded.Play();
            }
            if (p2trad == 1)
            {
                ListViewItem nightma = new ListViewItem();
                nightmarkettrd2 = 1;
                btntrad2.Visible = false;
                nightma.ForeColor = Color.Pink;
                nightma.Text = "Night Market";
                p2lvw.Items.Add(nightma);

                drawcarded.Play();
            }
            if (p3trad == 1)
            {
                ListViewItem nightma = new ListViewItem();
                nightmarkettrd2 = 1;
                btntrad2.Visible = false;
                nightma.ForeColor = Color.Pink;
                nightma.Text = "Night Market";
                p2lvw.Items.Add(nightma);

                drawcarded.Play();
            }
            if (p4trad == 1)
            {
                ListViewItem nightma = new ListViewItem();
                nightmarkettrd2 = 1;
                btntrad2.Visible = false;
                nightma.ForeColor = Color.Pink;
                nightma.Text = "Night Market";
                p2lvw.Items.Add(nightma);

                drawcarded.Play();
            }
            if (det == 2 || det == 2 && p1 == 1 || det == 2 && p2 == 1 || det == 2 && p3 == 1 || det == 2 && p4 == 1)
            {
                p2tr.Visible = true;
                pbdet2.Visible = true;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                nightmarketdet2 = 1;
                pb2x1.Enabled = false;
                pb2x2.Enabled = false;
                pb2x3.Enabled = false;
                pb2x4.Enabled = false;
                pb2x5.Enabled = false;
                pb2x6.Enabled = false;
                pb2x7.Enabled = false;
                pb2x8.Enabled = false;
                pb2x9.Enabled = false;
                pb2x10.Enabled = false;
                pb2x11.Enabled = false;
                pb2x12.Enabled = false;
                pb2x13.Enabled = false;
                pb2x14.Enabled = false;
                pb2x15.Enabled = false;
                pb2x16.Enabled = false;
                pb2x17.Enabled = false;
                pb2x18.Enabled = false;
                pb2x19.Enabled = false;
                pb2x20.Enabled = false;
                pb2x21.Enabled = false;
                pb2x22.Enabled = false;
                pb2x23.Enabled = false;
                pb2x24.Enabled = false;
                pb2x25.Enabled = false;
                pb2x26.Enabled = false;
                pb2x27.Enabled = false;
                pb2x28.Enabled = false;
                pbdet2.Image = bankers_game_proto.Properties.Resources.Night_market_t;

                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb2x8_Click(object sender, EventArgs e)
        {
            if (p1trad == 1)
            {
                ListViewItem dayma = new ListViewItem();
                daymarkettrd2 = 1;
                btntrad2.Visible = false;
                dayma.ForeColor = Color.Pink;
                dayma.Text = "Day Market";
                p2lvw.Items.Add(dayma);

                drawcarded.Play();
            }
            if (p2trad == 1)
            {
                ListViewItem dayma = new ListViewItem();
                daymarkettrd2 = 1;
                btntrad2.Visible = false;
                dayma.ForeColor = Color.Pink;
                dayma.Text = "Day Market";
                p2lvw.Items.Add(dayma);

                drawcarded.Play();
            }
            if (p3trad == 1)
            {
                ListViewItem dayma = new ListViewItem();
                daymarkettrd2 = 1;
                btntrad2.Visible = false;
                dayma.ForeColor = Color.Pink;
                dayma.Text = "Day Market";
                p2lvw.Items.Add(dayma);

                drawcarded.Play();
            }
            if (p4trad == 1)
            {
                ListViewItem dayma = new ListViewItem();
                daymarkettrd2 = 1;
                btntrad2.Visible = false;
                dayma.ForeColor = Color.Pink;
                dayma.Text = "Day Market";
                p2lvw.Items.Add(dayma);

                drawcarded.Play();
            }
            if (det == 2 || det == 2 && p1 == 1 || det == 2 && p2 == 1 || det == 2 && p3 == 1 || det == 2 && p4 == 1)
            {
                p2tr.Visible = true;
                pbdet2.Visible = true;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                daymarketdet2 = 1;
                pb2x1.Enabled = false;
                pb2x2.Enabled = false;
                pb2x3.Enabled = false;
                pb2x4.Enabled = false;
                pb2x5.Enabled = false;
                pb2x6.Enabled = false;
                pb2x7.Enabled = false;
                pb2x8.Enabled = false;
                pb2x9.Enabled = false;
                pb2x10.Enabled = false;
                pb2x11.Enabled = false;
                pb2x12.Enabled = false;
                pb2x13.Enabled = false;
                pb2x14.Enabled = false;
                pb2x15.Enabled = false;
                pb2x16.Enabled = false;
                pb2x17.Enabled = false;
                pb2x18.Enabled = false;
                pb2x19.Enabled = false;
                pb2x20.Enabled = false;
                pb2x21.Enabled = false;
                pb2x22.Enabled = false;
                pb2x23.Enabled = false;
                pb2x24.Enabled = false;
                pb2x25.Enabled = false;
                pb2x26.Enabled = false;
                pb2x27.Enabled = false;
                pb2x28.Enabled = false;
                pbdet2.Image = bankers_game_proto.Properties.Resources.Day_market_t;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb2x9_Click(object sender, EventArgs e)
        {
            if (p1trad == 1)
            {
                ListViewItem starma = new ListViewItem();
                starmarkettrd2 = 1;
                btntrad2.Visible = false;
                starma.ForeColor = Color.DarkOrange;
                starma.Text = "Star Market";
                p2lvw.Items.Add(starma);

                drawcarded.Play();
            }
            if (p2trad == 1)
            {
                ListViewItem starma = new ListViewItem();
                starmarkettrd2 = 1;
                btntrad2.Visible = false;
                starma.ForeColor = Color.DarkOrange;
                starma.Text = "Star Market";
                p2lvw.Items.Add(starma);

                drawcarded.Play();
            }
            if (p3trad == 1)
            {
                ListViewItem starma = new ListViewItem();
                starmarkettrd2 = 1;
                btntrad2.Visible = false;
                starma.ForeColor = Color.DarkOrange;
                starma.Text = "Star Market";
                p2lvw.Items.Add(starma);

                drawcarded.Play();
            }
            if (p4trad == 1)
            {
                ListViewItem starma = new ListViewItem();
                starmarkettrd2 = 1;
                btntrad2.Visible = false;
                starma.ForeColor = Color.DarkOrange;
                starma.Text = "Star Market";
                p2lvw.Items.Add(starma);

                drawcarded.Play();
            }
            if (det == 2 || det == 2 && p1 == 1 || det == 2 && p2 == 1 || det == 2 && p3 == 1 || det == 2 && p4 == 1)
            {
                p2tr.Visible = true;
                pbdet2.Visible = true;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                starmarketdet2 = 1;
                pb2x1.Enabled = false;
                pb2x2.Enabled = false;
                pb2x3.Enabled = false;
                pb2x4.Enabled = false;
                pb2x5.Enabled = false;
                pb2x6.Enabled = false;
                pb2x7.Enabled = false;
                pb2x8.Enabled = false;
                pb2x9.Enabled = false;
                pb2x10.Enabled = false;
                pb2x11.Enabled = false;
                pb2x12.Enabled = false;
                pb2x13.Enabled = false;
                pb2x14.Enabled = false;
                pb2x15.Enabled = false;
                pb2x16.Enabled = false;
                pb2x17.Enabled = false;
                pb2x18.Enabled = false;
                pb2x19.Enabled = false;
                pb2x20.Enabled = false;
                pb2x21.Enabled = false;
                pb2x22.Enabled = false;
                pb2x23.Enabled = false;
                pb2x24.Enabled = false;
                pb2x25.Enabled = false;
                pb2x26.Enabled = false;
                pb2x27.Enabled = false;
                pb2x28.Enabled = false;
                pbdet2.Image = bankers_game_proto.Properties.Resources.Star_market_t;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb2x10_Click(object sender, EventArgs e)
        {
            if (p1trad == 1)
            {
                ListViewItem moonma = new ListViewItem();
                moonmarkettrd2 = 1;
                btntrad2.Visible = false;
                moonma.ForeColor = Color.DarkOrange;
                moonma.Text = "Moon Market";
                p2lvw.Items.Add(moonma);

                drawcarded.Play();
            }
            if (p2trad == 1)
            {
                ListViewItem moonma = new ListViewItem();
                moonmarkettrd2 = 1;
                btntrad2.Visible = false;
                moonma.ForeColor = Color.DarkOrange;
                moonma.Text = "Moon Market";
                p2lvw.Items.Add(moonma);

                drawcarded.Play();
            }
            if (p3trad == 1)
            {
                ListViewItem moonma = new ListViewItem();
                moonmarkettrd2 = 1;
                btntrad2.Visible = false;
                moonma.ForeColor = Color.DarkOrange;
                moonma.Text = "Moon Market";
                p2lvw.Items.Add(moonma);

                drawcarded.Play();
            }
            if (p4trad == 1)
            {
                ListViewItem moonma = new ListViewItem();
                moonmarkettrd2 = 1;
                btntrad2.Visible = false;
                moonma.ForeColor = Color.DarkOrange;
                moonma.Text = "Moon Market";
                p2lvw.Items.Add(moonma);

                drawcarded.Play();
            }
            if (det == 2 || det == 2 && p1 == 1 || det == 2 && p2 == 1 || det == 2 && p3 == 1 || det == 2 && p4 == 1)
            {
                p2tr.Visible = true;
                pbdet2.Visible = true;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                moonmarketdet2 = 1;
                pb2x1.Enabled = false;
                pb2x2.Enabled = false;
                pb2x3.Enabled = false;
                pb2x4.Enabled = false;
                pb2x5.Enabled = false;
                pb2x6.Enabled = false;
                pb2x7.Enabled = false;
                pb2x8.Enabled = false;
                pb2x9.Enabled = false;
                pb2x10.Enabled = false;
                pb2x11.Enabled = false;
                pb2x12.Enabled = false;
                pb2x13.Enabled = false;
                pb2x14.Enabled = false;
                pb2x15.Enabled = false;
                pb2x16.Enabled = false;
                pb2x17.Enabled = false;
                pb2x18.Enabled = false;
                pb2x19.Enabled = false;
                pb2x20.Enabled = false;
                pb2x21.Enabled = false;
                pb2x22.Enabled = false;
                pb2x23.Enabled = false;
                pb2x24.Enabled = false;
                pb2x25.Enabled = false;
                pb2x26.Enabled = false;
                pb2x27.Enabled = false;
                pb2x28.Enabled = false;
                pbdet2.Image = bankers_game_proto.Properties.Resources.Moon_market_t;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb2x11_Click(object sender, EventArgs e)
        {
            if (p1trad == 1)
            {
                ListViewItem megama = new ListViewItem();
                megamarkettrd2 = 1;
                btntrad2.Visible = false;
                megama.ForeColor = Color.DarkOrange;
                megama.Text = "Mega Market";
                p2lvw.Items.Add(megama);

                drawcarded.Play();
            }
            if (p2trad == 1)
            {
                ListViewItem megama = new ListViewItem();
                megamarkettrd2 = 1;
                btntrad2.Visible = false;
                megama.ForeColor = Color.DarkOrange;
                megama.Text = "Mega Market";
                p2lvw.Items.Add(megama);

                drawcarded.Play();
            }
            if (p3trad == 1)
            {
                ListViewItem megama = new ListViewItem();
                megamarkettrd2 = 1;
                btntrad2.Visible = false;
                megama.ForeColor = Color.DarkOrange;
                megama.Text = "Mega Market";
                p2lvw.Items.Add(megama);

                drawcarded.Play();
            }
            if (p4trad == 1)
            {
                ListViewItem megama = new ListViewItem();
                megamarkettrd2 = 1;
                btntrad2.Visible = false;
                megama.ForeColor = Color.DarkOrange;
                megama.Text = "Mega Market";
                p2lvw.Items.Add(megama);

                drawcarded.Play();
            }
            if (det == 2 || det == 2 && p1 == 1 || det == 2 && p2 == 1 || det == 2 && p3 == 1 || det == 2 && p4 == 1)
            {
                p2tr.Visible = true;
                pbdet2.Visible = true;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                megamarketdet2 = 1;
                pb2x1.Enabled = false;
                pb2x2.Enabled = false;
                pb2x3.Enabled = false;
                pb2x4.Enabled = false;
                pb2x5.Enabled = false;
                pb2x6.Enabled = false;
                pb2x7.Enabled = false;
                pb2x8.Enabled = false;
                pb2x9.Enabled = false;
                pb2x10.Enabled = false;
                pb2x11.Enabled = false;
                pb2x12.Enabled = false;
                pb2x13.Enabled = false;
                pb2x14.Enabled = false;
                pb2x15.Enabled = false;
                pb2x16.Enabled = false;
                pb2x17.Enabled = false;
                pb2x18.Enabled = false;
                pb2x19.Enabled = false;
                pb2x20.Enabled = false;
                pb2x21.Enabled = false;
                pb2x22.Enabled = false;
                pb2x23.Enabled = false;
                pb2x24.Enabled = false;
                pb2x25.Enabled = false;
                pb2x26.Enabled = false;
                pb2x27.Enabled = false;
                pb2x28.Enabled = false;
                pbdet2.Image = bankers_game_proto.Properties.Resources.Mega_market_t;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb2x12_Click(object sender, EventArgs e)
        {
            if (p1trad == 1)
            {
                ListViewItem visayashos = new ListViewItem();
                visayashospitaltrd2 = 1;
                btntrad2.Visible = false;
                visayashos.ForeColor = Color.Red;
                visayashos.Text = "Visayas Hospital";
                p2lvw.Items.Add(visayashos);

                drawcarded.Play();
            }
            if (p2trad == 1)
            {
                ListViewItem visayashos = new ListViewItem();
                visayashospitaltrd2 = 1;
                btntrad2.Visible = false;
                visayashos.ForeColor = Color.Red;
                visayashos.Text = "Visayas Hospital";
                p2lvw.Items.Add(visayashos);

                drawcarded.Play();
            }
            if (p3trad == 1)
            {
                ListViewItem visayashos = new ListViewItem();
                visayashospitaltrd2 = 1;
                btntrad2.Visible = false;
                visayashos.ForeColor = Color.Red;
                visayashos.Text = "Visayas Hospital";
                p2lvw.Items.Add(visayashos);

                drawcarded.Play();
            }
            if (p4trad == 1)
            {
                ListViewItem visayashos = new ListViewItem();
                visayashospitaltrd2 = 1;
                btntrad2.Visible = false;
                visayashos.ForeColor = Color.Red;
                visayashos.Text = "Visayas Hospital";
                p2lvw.Items.Add(visayashos);

                drawcarded.Play();
            }
            if (det == 2 || det == 2 && p1 == 1 || det == 2 && p2 == 1 || det == 2 && p3 == 1 || det == 2 && p4 == 1)
            {
                p2tr.Visible = true;
                pbdet2.Visible = true;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                visayashospitaldet2 = 1;
                pb2x1.Enabled = false;
                pb2x2.Enabled = false;
                pb2x3.Enabled = false;
                pb2x4.Enabled = false;
                pb2x5.Enabled = false;
                pb2x6.Enabled = false;
                pb2x7.Enabled = false;
                pb2x8.Enabled = false;
                pb2x9.Enabled = false;
                pb2x10.Enabled = false;
                pb2x11.Enabled = false;
                pb2x12.Enabled = false;
                pb2x13.Enabled = false;
                pb2x14.Enabled = false;
                pb2x15.Enabled = false;
                pb2x16.Enabled = false;
                pb2x17.Enabled = false;
                pb2x18.Enabled = false;
                pb2x19.Enabled = false;
                pb2x20.Enabled = false;
                pb2x21.Enabled = false;
                pb2x22.Enabled = false;
                pb2x23.Enabled = false;
                pb2x24.Enabled = false;
                pb2x25.Enabled = false;
                pb2x26.Enabled = false;
                pb2x27.Enabled = false;
                pb2x28.Enabled = false;
                pbdet2.Image = bankers_game_proto.Properties.Resources.Visayas_hospital_t;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb2x13_Click(object sender, EventArgs e)
        {
            if (p1trad == 1)
            {
                ListViewItem hobertshos = new ListViewItem();
                hobertshospitaltrd2 = 1;
                btntrad2.Visible = false;
                hobertshos.ForeColor = Color.Red;
                hobertshos.Text = "Hobert's Hospital";
                p2lvw.Items.Add(hobertshos);

                drawcarded.Play();
            }
            if (p2trad == 1)
            {
                ListViewItem hobertshos = new ListViewItem();
                hobertshospitaltrd2 = 1;
                btntrad2.Visible = false;
                hobertshos.ForeColor = Color.Red;
                hobertshos.Text = "Hobert's Hospital";
                p2lvw.Items.Add(hobertshos);

                drawcarded.Play();
            }
            if (p3trad == 1)
            {
                ListViewItem hobertshos = new ListViewItem();
                hobertshospitaltrd2 = 1;
                btntrad2.Visible = false;
                hobertshos.ForeColor = Color.Red;
                hobertshos.Text = "Hobert's Hospital";
                p2lvw.Items.Add(hobertshos);

                drawcarded.Play();
            }
            if (p4trad == 1)
            {
                ListViewItem hobertshos = new ListViewItem();
                hobertshospitaltrd2 = 1;
                btntrad2.Visible = false;
                hobertshos.ForeColor = Color.Red;
                hobertshos.Text = "Hobert's Hospital";
                p2lvw.Items.Add(hobertshos);

                drawcarded.Play();
            }
            if (det == 2 || det == 2 && p1 == 1 || det == 2 && p2 == 1 || det == 2 && p3 == 1 || det == 2 && p4 == 1)
            {
                p2tr.Visible = true;
                pbdet2.Visible = true;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                hobertshospitaldet2 = 1;
                pb2x1.Enabled = false;
                pb2x2.Enabled = false;
                pb2x3.Enabled = false;
                pb2x4.Enabled = false;
                pb2x5.Enabled = false;
                pb2x6.Enabled = false;
                pb2x7.Enabled = false;
                pb2x8.Enabled = false;
                pb2x9.Enabled = false;
                pb2x10.Enabled = false;
                pb2x11.Enabled = false;
                pb2x12.Enabled = false;
                pb2x13.Enabled = false;
                pb2x14.Enabled = false;
                pb2x15.Enabled = false;
                pb2x16.Enabled = false;
                pb2x17.Enabled = false;
                pb2x18.Enabled = false;
                pb2x19.Enabled = false;
                pb2x20.Enabled = false;
                pb2x21.Enabled = false;
                pb2x22.Enabled = false;
                pb2x23.Enabled = false;
                pb2x24.Enabled = false;
                pb2x25.Enabled = false;
                pb2x26.Enabled = false;
                pb2x27.Enabled = false;
                pb2x28.Enabled = false;
                pbdet2.Image = bankers_game_proto.Properties.Resources.Hobert_s_hospital_t;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb2x14_Click(object sender, EventArgs e)
        {
            if (p1trad == 1)
            {
                ListViewItem heartshos = new ListViewItem();
                heartshospitaltrd2 = 1;
                btntrad2.Visible = false;
                heartshos.ForeColor = Color.Red;
                heartshos.Text = "Hearts Hospital";
                p2lvw.Items.Add(heartshos);

                drawcarded.Play();
            }
            if (p2trad == 1)
            {
                ListViewItem heartshos = new ListViewItem();
                heartshospitaltrd2 = 1;
                btntrad2.Visible = false;
                heartshos.ForeColor = Color.Red;
                heartshos.Text = "Hearts Hospital";
                p2lvw.Items.Add(heartshos);

                drawcarded.Play();
            }
            if (p3trad == 1)
            {
                ListViewItem heartshos = new ListViewItem();
                heartshospitaltrd2 = 1;
                btntrad2.Visible = false;
                heartshos.ForeColor = Color.Red;
                heartshos.Text = "Hearts Hospital";
                p2lvw.Items.Add(heartshos);

                drawcarded.Play();
            }
            if (p4trad == 1)
            {
                ListViewItem heartshos = new ListViewItem();
                heartshospitaltrd2 = 1;
                btntrad2.Visible = false;
                heartshos.ForeColor = Color.Red;
                heartshos.Text = "Hearts Hospital";
                p2lvw.Items.Add(heartshos);

                drawcarded.Play();
            }
            if (det == 2 || det == 2 && p1 == 1 || det == 2 && p2 == 1 || det == 2 && p3 == 1 || det == 2 && p4 == 1)
            {
                p2tr.Visible = true;
                pbdet2.Visible = true;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                heartshospitaldet2 = 1;
                pb2x1.Enabled = false;
                pb2x2.Enabled = false;
                pb2x3.Enabled = false;
                pb2x4.Enabled = false;
                pb2x5.Enabled = false;
                pb2x6.Enabled = false;
                pb2x7.Enabled = false;
                pb2x8.Enabled = false;
                pb2x9.Enabled = false;
                pb2x10.Enabled = false;
                pb2x11.Enabled = false;
                pb2x12.Enabled = false;
                pb2x13.Enabled = false;
                pb2x14.Enabled = false;
                pb2x15.Enabled = false;
                pb2x16.Enabled = false;
                pb2x17.Enabled = false;
                pb2x18.Enabled = false;
                pb2x19.Enabled = false;
                pb2x20.Enabled = false;
                pb2x21.Enabled = false;
                pb2x22.Enabled = false;
                pb2x23.Enabled = false;
                pb2x24.Enabled = false;
                pb2x25.Enabled = false;
                pb2x26.Enabled = false;
                pb2x27.Enabled = false;
                pb2x28.Enabled = false;
                pbdet2.Image = bankers_game_proto.Properties.Resources.Hearts_hospital_t;


                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb2x15_Click(object sender, EventArgs e)
        {
            if (p1trad == 1)
            {
                ListViewItem internshos = new ListViewItem();
                internshospitaltrd2 = 1;
                btntrad2.Visible = false;
                internshos.ForeColor = Color.LightGoldenrodYellow;
                internshos.Text = "Intern's Hospital";
                p2lvw.Items.Add(internshos);

                drawcarded.Play();
            }
            if (p2trad == 1)
            {
                ListViewItem internshos = new ListViewItem();
                internshospitaltrd2 = 1;
                btntrad2.Visible = false;
                internshos.ForeColor = Color.LightGoldenrodYellow;
                internshos.Text = "Intern's Hospital";
                p2lvw.Items.Add(internshos);

                drawcarded.Play();
            }
            if (p3trad == 1)
            {
                ListViewItem internshos = new ListViewItem();
                internshospitaltrd2 = 1;
                btntrad2.Visible = false;
                internshos.ForeColor = Color.LightGoldenrodYellow;
                internshos.Text = "Intern's Hospital";
                p2lvw.Items.Add(internshos);

                drawcarded.Play();
            }
            if (p4trad == 1)
            {
                ListViewItem internshos = new ListViewItem();
                internshospitaltrd2 = 1;
                btntrad2.Visible = false;
                internshos.ForeColor = Color.LightGoldenrodYellow;
                internshos.Text = "Intern's Hospital";
                p2lvw.Items.Add(internshos);

                drawcarded.Play();
            }
            if (det == 2 || det == 2 && p1 == 1 || det == 2 && p2 == 1 || det == 2 && p3 == 1 || det == 2 && p4 == 1)
            {
                p2tr.Visible = true;
                pbdet2.Visible = true;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                internshospitaldet2 = 1;
                pb2x1.Enabled = false;
                pb2x2.Enabled = false;
                pb2x3.Enabled = false;
                pb2x4.Enabled = false;
                pb2x5.Enabled = false;
                pb2x6.Enabled = false;
                pb2x7.Enabled = false;
                pb2x8.Enabled = false;
                pb2x9.Enabled = false;
                pb2x10.Enabled = false;
                pb2x11.Enabled = false;
                pb2x12.Enabled = false;
                pb2x13.Enabled = false;
                pb2x14.Enabled = false;
                pb2x15.Enabled = false;
                pb2x16.Enabled = false;
                pb2x17.Enabled = false;
                pb2x18.Enabled = false;
                pb2x19.Enabled = false;
                pb2x20.Enabled = false;
                pb2x21.Enabled = false;
                pb2x22.Enabled = false;
                pb2x23.Enabled = false;
                pb2x24.Enabled = false;
                pb2x25.Enabled = false;
                pb2x26.Enabled = false;
                pb2x27.Enabled = false;
                pb2x28.Enabled = false;
                pbdet2.Image = bankers_game_proto.Properties.Resources.Intern_s_hospital_t;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb2x16_Click(object sender, EventArgs e)
        {
            if (p1trad == 1)
            {
                ListViewItem nationalhe = new ListViewItem();
                nationalhealthhospitaltrd2 = 1;
                btntrad2.Visible = false;
                nationalhe.ForeColor = Color.LightGoldenrodYellow;
                nationalhe.Text = "National Health Hospital";
                p2lvw.Items.Add(nationalhe);

                drawcarded.Play();
            }
            if (p2trad == 1)
            {
                ListViewItem nationalhe = new ListViewItem();
                nationalhealthhospitaltrd2 = 1;
                btntrad2.Visible = false;
                nationalhe.ForeColor = Color.LightGoldenrodYellow;
                nationalhe.Text = "National Health Hospital";
                p2lvw.Items.Add(nationalhe);

                drawcarded.Play();
            }
            if (p3trad == 1)
            {
                ListViewItem nationalhe = new ListViewItem();
                nationalhealthhospitaltrd2 = 1;
                btntrad2.Visible = false;
                nationalhe.ForeColor = Color.LightGoldenrodYellow;
                nationalhe.Text = "National Health Hospital";
                p2lvw.Items.Add(nationalhe);

                drawcarded.Play();
            }
            if (p4trad == 1)
            {
                ListViewItem nationalhe = new ListViewItem();
                nationalhealthhospitaltrd2 = 1;
                btntrad2.Visible = false;
                nationalhe.ForeColor = Color.LightGoldenrodYellow;
                nationalhe.Text = "National Health Hospital";
                p2lvw.Items.Add(nationalhe);

                drawcarded.Play();
            }
            if (det == 2 || det == 2 && p1 == 1 || det == 2 && p2 == 1 || det == 2 && p3 == 1 || det == 2 && p4 == 1)
            {
                p2tr.Visible = true;
                pbdet2.Visible = true;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                nationalhealthhospitaldet2 = 1;
                pb2x1.Enabled = false;
                pb2x2.Enabled = false;
                pb2x3.Enabled = false;
                pb2x4.Enabled = false;
                pb2x5.Enabled = false;
                pb2x6.Enabled = false;
                pb2x7.Enabled = false;
                pb2x8.Enabled = false;
                pb2x9.Enabled = false;
                pb2x10.Enabled = false;
                pb2x11.Enabled = false;
                pb2x12.Enabled = false;
                pb2x13.Enabled = false;
                pb2x14.Enabled = false;
                pb2x15.Enabled = false;
                pb2x16.Enabled = false;
                pb2x17.Enabled = false;
                pb2x18.Enabled = false;
                pb2x19.Enabled = false;
                pb2x20.Enabled = false;
                pb2x21.Enabled = false;
                pb2x22.Enabled = false;
                pb2x23.Enabled = false;
                pb2x24.Enabled = false;
                pb2x25.Enabled = false;
                pb2x26.Enabled = false;
                pb2x27.Enabled = false;
                pb2x28.Enabled = false;
                pbdet2.Image = bankers_game_proto.Properties.Resources.National_healths_hospital_t;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb2x17_Click(object sender, EventArgs e)
        {
            if (p1trad == 1)
            {
                ListViewItem veteranshos = new ListViewItem();
                veteranshospitaltrd2 = 1;
                btntrad2.Visible = false;
                veteranshos.ForeColor = Color.LightGoldenrodYellow;
                veteranshos.Text = "Veteran's Hospital";
                p2lvw.Items.Add(veteranshos);

                drawcarded.Play();
            }
            if (p2trad == 1)
            {
                ListViewItem veteranshos = new ListViewItem();
                veteranshospitaltrd2 = 1;
                btntrad2.Visible = false;
                veteranshos.ForeColor = Color.LightGoldenrodYellow;
                veteranshos.Text = "Veteran's Hospital";
                p2lvw.Items.Add(veteranshos);

                drawcarded.Play();
            }
            if (p3trad == 1)
            {
                ListViewItem veteranshos = new ListViewItem();
                veteranshospitaltrd2 = 1;
                btntrad2.Visible = false;
                veteranshos.ForeColor = Color.LightGoldenrodYellow;
                veteranshos.Text = "Veteran's Hospital";
                p2lvw.Items.Add(veteranshos);

                drawcarded.Play();
            }
            if (p4trad == 1)
            {
                ListViewItem veteranshos = new ListViewItem();
                veteranshospitaltrd2 = 1;
                btntrad2.Visible = false;
                veteranshos.ForeColor = Color.LightGoldenrodYellow;
                veteranshos.Text = "Veteran's Hospital";
                p2lvw.Items.Add(veteranshos);

                drawcarded.Play();
            }
            if (det == 2 || det == 2 && p1 == 1 || det == 2 && p2 == 1 || det == 2 && p3 == 1 || det == 2 && p4 == 1)
            {
                p2tr.Visible = true;
                pbdet2.Visible = true;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                veteranshospitaldet2 = 1;
                pb2x1.Enabled = false;
                pb2x2.Enabled = false;
                pb2x3.Enabled = false;
                pb2x4.Enabled = false;
                pb2x5.Enabled = false;
                pb2x6.Enabled = false;
                pb2x7.Enabled = false;
                pb2x8.Enabled = false;
                pb2x9.Enabled = false;
                pb2x10.Enabled = false;
                pb2x11.Enabled = false;
                pb2x12.Enabled = false;
                pb2x13.Enabled = false;
                pb2x14.Enabled = false;
                pb2x15.Enabled = false;
                pb2x16.Enabled = false;
                pb2x17.Enabled = false;
                pb2x18.Enabled = false;
                pb2x19.Enabled = false;
                pb2x20.Enabled = false;
                pb2x21.Enabled = false;
                pb2x22.Enabled = false;
                pb2x23.Enabled = false;
                pb2x24.Enabled = false;
                pb2x25.Enabled = false;
                pb2x26.Enabled = false;
                pb2x27.Enabled = false;
                pb2x28.Enabled = false;
                pbdet2.Image = bankers_game_proto.Properties.Resources.VETERANS_Hospital_t;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb2x18_Click(object sender, EventArgs e)
        {
            if (p1trad == 1)
            {
                ListViewItem pearlma = new ListViewItem();
                pearlmalltrd2 = 1;
                btntrad2.Visible = false;
                pearlma.ForeColor = Color.Green;
                pearlma.Text = "Pearl Mall";
                p2lvw.Items.Add(pearlma);

                drawcarded.Play();
            }
            if (p2trad == 1)
            {
                ListViewItem pearlma = new ListViewItem();
                pearlmalltrd2 = 1;
                btntrad2.Visible = false;
                pearlma.ForeColor = Color.Green;
                pearlma.Text = "Pearl Mall";
                p2lvw.Items.Add(pearlma);

                drawcarded.Play();
            }
            if (p3trad == 1)
            {
                ListViewItem pearlma = new ListViewItem();
                pearlmalltrd2 = 1;
                btntrad2.Visible = false;
                pearlma.ForeColor = Color.Green;
                pearlma.Text = "Pearl Mall";
                p2lvw.Items.Add(pearlma);

                drawcarded.Play();
            }
            if (p4trad == 1)
            {
                ListViewItem pearlma = new ListViewItem();
                pearlmalltrd2 = 1;
                btntrad2.Visible = false;
                pearlma.ForeColor = Color.Green;
                pearlma.Text = "Pearl Mall";
                p2lvw.Items.Add(pearlma);

                drawcarded.Play();
            }
            if (det == 2 || det == 2 && p1 == 1 || det == 2 && p2 == 1 || det == 2 && p3 == 1 || det == 2 && p4 == 1)
            {
                p2tr.Visible = true;
                pbdet2.Visible = true;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                pearlmalldet2 = 1;
                pb2x1.Enabled = false;
                pb2x2.Enabled = false;
                pb2x3.Enabled = false;
                pb2x4.Enabled = false;
                pb2x5.Enabled = false;
                pb2x6.Enabled = false;
                pb2x7.Enabled = false;
                pb2x8.Enabled = false;
                pb2x9.Enabled = false;
                pb2x10.Enabled = false;
                pb2x11.Enabled = false;
                pb2x12.Enabled = false;
                pb2x13.Enabled = false;
                pb2x14.Enabled = false;
                pb2x15.Enabled = false;
                pb2x16.Enabled = false;
                pb2x17.Enabled = false;
                pb2x18.Enabled = false;
                pb2x19.Enabled = false;
                pb2x20.Enabled = false;
                pb2x21.Enabled = false;
                pb2x22.Enabled = false;
                pb2x23.Enabled = false;
                pb2x24.Enabled = false;
                pb2x25.Enabled = false;
                pb2x26.Enabled = false;
                pb2x27.Enabled = false;
                pb2x28.Enabled = false;
                pbdet2.Image = bankers_game_proto.Properties.Resources.Pearl_Mall_t;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb2x19_Click(object sender, EventArgs e)
        {
            if (p1trad == 1)
            {
                ListViewItem megamal = new ListViewItem();
                megamalltrd2 = 1;
                btntrad2.Visible = false;
                megamal.ForeColor = Color.Green;
                megamal.Text = "Mega Mall";
                p2lvw.Items.Add(megamal);

                drawcarded.Play();
            }
            if (p2trad == 1)
            {
                ListViewItem megamal = new ListViewItem();
                megamalltrd2 = 1;
                btntrad2.Visible = false;
                megamal.ForeColor = Color.Green;
                megamal.Text = "Mega Mall";
                p2lvw.Items.Add(megamal);

                drawcarded.Play();
            }
            if (p3trad == 1)
            {
                ListViewItem megamal = new ListViewItem();
                megamalltrd2 = 1;
                btntrad2.Visible = false;
                megamal.ForeColor = Color.Green;
                megamal.Text = "Mega Mall";
                p2lvw.Items.Add(megamal);

                drawcarded.Play();
            }
            if (p4trad == 1)
            {
                ListViewItem megamal = new ListViewItem();
                megamalltrd2 = 1;
                btntrad2.Visible = false;
                megamal.ForeColor = Color.Green;
                megamal.Text = "Mega Mall";
                p2lvw.Items.Add(megamal);

                drawcarded.Play();
            }
            if (det == 2 || det == 2 && p1 == 1 || det == 2 && p2 == 1 || det == 2 && p3 == 1 || det == 2 && p4 == 1)
            {
                p2tr.Visible = true;
                pbdet2.Visible = true;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                megamalldet2 = 1;
                pb2x1.Enabled = false;
                pb2x2.Enabled = false;
                pb2x3.Enabled = false;
                pb2x4.Enabled = false;
                pb2x5.Enabled = false;
                pb2x6.Enabled = false;
                pb2x7.Enabled = false;
                pb2x8.Enabled = false;
                pb2x9.Enabled = false;
                pb2x10.Enabled = false;
                pb2x11.Enabled = false;
                pb2x12.Enabled = false;
                pb2x13.Enabled = false;
                pb2x14.Enabled = false;
                pb2x15.Enabled = false;
                pb2x16.Enabled = false;
                pb2x17.Enabled = false;
                pb2x18.Enabled = false;
                pb2x19.Enabled = false;
                pb2x20.Enabled = false;
                pb2x21.Enabled = false;
                pb2x22.Enabled = false;
                pb2x23.Enabled = false;
                pb2x24.Enabled = false;
                pb2x25.Enabled = false;
                pb2x26.Enabled = false;
                pb2x27.Enabled = false;
                pb2x28.Enabled = false;
                pbdet2.Image = bankers_game_proto.Properties.Resources.Mega_mall_t;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb2x20_Click(object sender, EventArgs e)
        {
            if (p1trad == 1)
            {
                ListViewItem articmal = new ListViewItem();
                articmalltr2 = 1;
                btntrad2.Visible = false;
                articmal.ForeColor = Color.Green;
                articmal.Text = "Artic Mall";
                p2lvw.Items.Add(articmal);

                drawcarded.Play();
            }
            if (p2trad == 1)
            {
                ListViewItem articmal = new ListViewItem();
                articmalltr2 = 1;
                btntrad2.Visible = false;
                articmal.ForeColor = Color.Green;
                articmal.Text = "Artic Mall";
                p2lvw.Items.Add(articmal);

                drawcarded.Play();
            }
            if (p3trad == 1)
            {
                ListViewItem articmal = new ListViewItem();
                articmalltr2 = 1;
                btntrad2.Visible = false;
                articmal.ForeColor = Color.Green;
                articmal.Text = "Artic Mall";
                p2lvw.Items.Add(articmal);

                drawcarded.Play();
            }
            if (p4trad == 1)
            {
                ListViewItem articmal = new ListViewItem();
                articmalltr2 = 1;
                btntrad2.Visible = false;
                articmal.ForeColor = Color.Green;
                articmal.Text = "Artic Mall";
                p2lvw.Items.Add(articmal);

                drawcarded.Play();
            }
            if (det == 2 || det == 2 && p1 == 1 || det == 2 && p2 == 1 || det == 2 && p3 == 1 || det == 2 && p4 == 1)
            {
                p2tr.Visible = true;
                pbdet2.Visible = true;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                articmalldet2 = 1;
                pb2x1.Enabled = false;
                pb2x2.Enabled = false;
                pb2x3.Enabled = false;
                pb2x4.Enabled = false;
                pb2x5.Enabled = false;
                pb2x6.Enabled = false;
                pb2x7.Enabled = false;
                pb2x8.Enabled = false;
                pb2x9.Enabled = false;
                pb2x10.Enabled = false;
                pb2x11.Enabled = false;
                pb2x12.Enabled = false;
                pb2x13.Enabled = false;
                pb2x14.Enabled = false;
                pb2x15.Enabled = false;
                pb2x16.Enabled = false;
                pb2x17.Enabled = false;
                pb2x18.Enabled = false;
                pb2x19.Enabled = false;
                pb2x20.Enabled = false;
                pb2x21.Enabled = false;
                pb2x22.Enabled = false;
                pb2x23.Enabled = false;
                pb2x24.Enabled = false;
                pb2x25.Enabled = false;
                pb2x26.Enabled = false;
                pb2x27.Enabled = false;
                pb2x28.Enabled = false;
                pbdet2.Image = bankers_game_proto.Properties.Resources.Artic_mall_t;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb2x21_Click(object sender, EventArgs e)
        {
            if (p1trad == 1)
            {
                ListViewItem heavenlymal = new ListViewItem();
                heavenlymalltrd2 = 1;
                btntrad2.Visible = false;
                heavenlymal.ForeColor = Color.DarkBlue;
                heavenlymal.Text = "Heavenly Mall";
                p2lvw.Items.Add(heavenlymal);

                drawcarded.Play();
            }
            if (p2trad == 1)
            {
                ListViewItem heavenlymal = new ListViewItem();
                heavenlymalltrd2 = 1;
                btntrad2.Visible = false;
                heavenlymal.ForeColor = Color.DarkBlue;
                heavenlymal.Text = "Heavenly Mall";
                p2lvw.Items.Add(heavenlymal);

                drawcarded.Play();
            }
            if (p3trad == 1)
            {
                ListViewItem heavenlymal = new ListViewItem();
                heavenlymalltrd2 = 1;
                btntrad2.Visible = false;
                heavenlymal.ForeColor = Color.DarkBlue;
                heavenlymal.Text = "Heavenly Mall";
                p2lvw.Items.Add(heavenlymal);

                drawcarded.Play();
            }
            if (p4trad == 1)
            {
                ListViewItem heavenlymal = new ListViewItem();
                heavenlymalltrd2 = 1;
                btntrad2.Visible = false;
                heavenlymal.ForeColor = Color.DarkBlue;
                heavenlymal.Text = "Heavenly Mall";
                p2lvw.Items.Add(heavenlymal);

                drawcarded.Play();
            }
            if (det == 2 || det == 2 && p1 == 1 || det == 2 && p2 == 1 || det == 2 && p3 == 1 || det == 2 && p4 == 1)
            {
                p2tr.Visible = true;
                pbdet2.Visible = true;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                heavenlymalldet2 = 1;
                pb2x1.Enabled = false;
                pb2x2.Enabled = false;
                pb2x3.Enabled = false;
                pb2x4.Enabled = false;
                pb2x5.Enabled = false;
                pb2x6.Enabled = false;
                pb2x7.Enabled = false;
                pb2x8.Enabled = false;
                pb2x9.Enabled = false;
                pb2x10.Enabled = false;
                pb2x11.Enabled = false;
                pb2x12.Enabled = false;
                pb2x13.Enabled = false;
                pb2x14.Enabled = false;
                pb2x15.Enabled = false;
                pb2x16.Enabled = false;
                pb2x17.Enabled = false;
                pb2x18.Enabled = false;
                pb2x19.Enabled = false;
                pb2x20.Enabled = false;
                pb2x21.Enabled = false;
                pb2x22.Enabled = false;
                pb2x23.Enabled = false;
                pb2x24.Enabled = false;
                pb2x25.Enabled = false;
                pb2x26.Enabled = false;
                pb2x27.Enabled = false;
                pb2x28.Enabled = false;
                pbdet2.Image = bankers_game_proto.Properties.Resources.Heavenly_mall_t;
                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb2x22_Click(object sender, EventArgs e)
        {
            if (p1trad == 1)
            {
                ListViewItem shangrillamal = new ListViewItem();
                shangrillamalltrd2 = 1;
                btntrad2.Visible = false;
                shangrillamal.ForeColor = Color.DarkBlue;
                shangrillamal.Text = "Shangrilla Mall";
                p2lvw.Items.Add(shangrillamal);
                drawcarded.Play();
            }
            if (p2trad == 1)
            {
                ListViewItem shangrillamal = new ListViewItem();
                shangrillamalltrd2 = 1;
                btntrad2.Visible = false;
                shangrillamal.ForeColor = Color.DarkBlue;
                shangrillamal.Text = "Shangrilla Mall";
                p2lvw.Items.Add(shangrillamal);

                drawcarded.Play();
            }
            if (p3trad == 1)
            {
                ListViewItem shangrillamal = new ListViewItem();
                shangrillamalltrd2 = 1;
                btntrad2.Visible = false;
                shangrillamal.ForeColor = Color.DarkBlue;
                shangrillamal.Text = "Shangrilla Mall";
                p2lvw.Items.Add(shangrillamal);

                drawcarded.Play();
            }
            if (p4trad == 1)
            {
                ListViewItem shangrillamal = new ListViewItem();
                shangrillamalltrd2 = 1;
                btntrad2.Visible = false;
                shangrillamal.ForeColor = Color.DarkBlue;
                shangrillamal.Text = "Shangrilla Mall";
                p2lvw.Items.Add(shangrillamal);

                drawcarded.Play();
            }
            if (det == 2 || det == 2 && p1 == 1 || det == 2 && p2 == 1 || det == 2 && p3 == 1 || det == 2 && p4 == 1)
            {
                p2tr.Visible = true;
                pbdet2.Visible = true;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                shangrillamalldet2 = 1;
                pb2x1.Enabled = false;
                pb2x2.Enabled = false;
                pb2x3.Enabled = false;
                pb2x4.Enabled = false;
                pb2x5.Enabled = false;
                pb2x6.Enabled = false;
                pb2x7.Enabled = false;
                pb2x8.Enabled = false;
                pb2x9.Enabled = false;
                pb2x10.Enabled = false;
                pb2x11.Enabled = false;
                pb2x12.Enabled = false;
                pb2x13.Enabled = false;
                pb2x14.Enabled = false;
                pb2x15.Enabled = false;
                pb2x16.Enabled = false;
                pb2x17.Enabled = false;
                pb2x18.Enabled = false;
                pb2x19.Enabled = false;
                pb2x20.Enabled = false;
                pb2x21.Enabled = false;
                pb2x22.Enabled = false;
                pb2x23.Enabled = false;
                pb2x24.Enabled = false;
                pb2x25.Enabled = false;
                pb2x26.Enabled = false;
                pb2x27.Enabled = false;
                pb2x28.Enabled = false;
                pbdet2.Image = bankers_game_proto.Properties.Resources.Shangrilla_Mall_t;

                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb2x23_Click(object sender, EventArgs e)
        {
            if (p1trad == 1)
            {
                ListViewItem util2x1 = new ListViewItem();
                utility2x1trd2 = 1;
                btntrad2.Visible = false;
                util2x1.ForeColor = Color.Yellow;
                util2x1.Text = "Meralco Electricity";
                p2lvw.Items.Add(util2x1);

                drawcarded.Play();
            }
            if (p2trad == 1)
            {
                ListViewItem util2x1 = new ListViewItem();
                utility2x1trd2 = 1;
                btntrad2.Visible = false;
                util2x1.ForeColor = Color.Yellow;
                util2x1.Text = "Meralco Electricity";
                p2lvw.Items.Add(util2x1);

                drawcarded.Play();
            }
            if (p3trad == 1)
            {
                ListViewItem util2x1 = new ListViewItem();
                utility2x1trd2 = 1;
                btntrad2.Visible = false;
                util2x1.ForeColor = Color.Yellow;
                util2x1.Text = "Meralco Electricity";
                p2lvw.Items.Add(util2x1);

                drawcarded.Play();
            }
            if (p4trad == 1)
            {
                ListViewItem util2x1 = new ListViewItem();
                utility2x1trd2 = 1;
                btntrad2.Visible = false;
                util2x1.ForeColor = Color.Yellow;
                util2x1.Text = "Meralco Electricity";
                p2lvw.Items.Add(util2x1);

                drawcarded.Play();
            }
            if (det == 2 || det == 2 && p1 == 1 || det == 2 && p2 == 1 || det == 2 && p3 == 1 || det == 2 && p4 == 1)
            {
                p2tr.Visible = true;
                pbdet2.Visible = true;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                utility2x1det2 = 1;
                pb2x1.Enabled = false;
                pb2x2.Enabled = false;
                pb2x3.Enabled = false;
                pb2x4.Enabled = false;
                pb2x5.Enabled = false;
                pb2x6.Enabled = false;
                pb2x7.Enabled = false;
                pb2x8.Enabled = false;
                pb2x9.Enabled = false;
                pb2x10.Enabled = false;
                pb2x11.Enabled = false;
                pb2x12.Enabled = false;
                pb2x13.Enabled = false;
                pb2x14.Enabled = false;
                pb2x15.Enabled = false;
                pb2x16.Enabled = false;
                pb2x17.Enabled = false;
                pb2x18.Enabled = false;
                pb2x19.Enabled = false;
                pb2x20.Enabled = false;
                pb2x21.Enabled = false;
                pb2x22.Enabled = false;
                pb2x23.Enabled = false;
                pb2x24.Enabled = false;
                pb2x25.Enabled = false;
                pb2x26.Enabled = false;
                pb2x27.Enabled = false;
                pb2x28.Enabled = false;
                pbdet2.Image = bankers_game_proto.Properties.Resources.Meralco_t;


                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb2x24_Click(object sender, EventArgs e)
        {
            if (p1trad == 1)
            {
                ListViewItem util2x2 = new ListViewItem();
                utility2x2trd2 = 1;
                btntrad2.Visible = false;
                util2x2.ForeColor = Color.Yellow;
                util2x2.Text = "Niagra Falls Electricity";
                p2lvw.Items.Add(util2x2);

                drawcarded.Play();
            }
            if (p2trad == 1)
            {
                ListViewItem util2x2 = new ListViewItem();
                utility2x2trd2 = 1;
                btntrad2.Visible = false;
                util2x2.ForeColor = Color.Yellow;
                util2x2.Text = "Niagra Falls Electricity";
                p2lvw.Items.Add(util2x2);

                drawcarded.Play();
            }
            if (p3trad == 1)
            {
                ListViewItem util2x2 = new ListViewItem();
                utility2x2trd2 = 1;
                btntrad2.Visible = false;
                util2x2.ForeColor = Color.Yellow;
                util2x2.Text = "Niagra Falls Electricity";
                p2lvw.Items.Add(util2x2);

                drawcarded.Play();
            }
            if (p4trad == 1)
            {
                ListViewItem util2x2 = new ListViewItem();
                utility2x2trd2 = 1;
                btntrad2.Visible = false;
                util2x2.ForeColor = Color.Yellow;
                util2x2.Text = "Niagra Falls Electricity";
                p2lvw.Items.Add(util2x2);

                drawcarded.Play();
            }
            if (det == 2 || det == 2 && p1 == 1 || det == 2 && p2 == 1 || det == 2 && p3 == 1 || det == 2 && p4 == 1)
            {
                p2tr.Visible = true;
                pbdet2.Visible = true;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                utility2x2det2 = 1;
                pb2x1.Enabled = false;
                pb2x2.Enabled = false;
                pb2x3.Enabled = false;
                pb2x4.Enabled = false;
                pb2x5.Enabled = false;
                pb2x6.Enabled = false;
                pb2x7.Enabled = false;
                pb2x8.Enabled = false;
                pb2x9.Enabled = false;
                pb2x10.Enabled = false;
                pb2x11.Enabled = false;
                pb2x12.Enabled = false;
                pb2x13.Enabled = false;
                pb2x14.Enabled = false;
                pb2x15.Enabled = false;
                pb2x16.Enabled = false;
                pb2x17.Enabled = false;
                pb2x18.Enabled = false;
                pb2x19.Enabled = false;
                pb2x20.Enabled = false;
                pb2x21.Enabled = false;
                pb2x22.Enabled = false;
                pb2x23.Enabled = false;
                pb2x24.Enabled = false;
                pb2x25.Enabled = false;
                pb2x26.Enabled = false;
                pb2x27.Enabled = false;
                pb2x28.Enabled = false;
                pbdet2.Image = bankers_game_proto.Properties.Resources.Niagra_Fall_t;

                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb2x25_Click(object sender, EventArgs e)
        {
            if (p1trad == 1)
            {
                ListViewItem rose = new ListViewItem();
                transportation2x1trd2 = 1;
                btntrad2.Visible = false;
                rose.ForeColor = Color.SteelBlue;
                rose.Text = "Rosevelt Station";
                p2lvw.Items.Add(rose);

                drawcarded.Play();
            }
            if (p2trad == 1)
            {
                ListViewItem rose = new ListViewItem();
                transportation2x1trd2 = 1;
                btntrad2.Visible = false;
                rose.ForeColor = Color.SteelBlue;
                rose.Text = "Rosevelt Station";
                p2lvw.Items.Add(rose);

                drawcarded.Play();
            }
            if (p3trad == 1)
            {
                ListViewItem rose = new ListViewItem();
                transportation2x1trd2 = 1;
                btntrad2.Visible = false;
                rose.ForeColor = Color.SteelBlue;
                rose.Text = "Rosevelt Station";
                p2lvw.Items.Add(rose);

                drawcarded.Play();
            }
            if (p4trad == 1)
            {
                ListViewItem rose = new ListViewItem();
                transportation2x1trd2 = 1;
                btntrad2.Visible = false;
                rose.ForeColor = Color.SteelBlue;
                rose.Text = "Rosevelt Station";
                p2lvw.Items.Add(rose);

                drawcarded.Play();
            }
            if (det == 2 || det == 2 && p1 == 1 || det == 2 && p2 == 1 || det == 2 && p3 == 1 || det == 2 && p4 == 1)
            {
                p2tr.Visible = true;
                pbdet2.Visible = true;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                transportation2x1det2 = 1;
                pb2x1.Enabled = false;
                pb2x2.Enabled = false;
                pb2x3.Enabled = false;
                pb2x4.Enabled = false;
                pb2x5.Enabled = false;
                pb2x6.Enabled = false;
                pb2x7.Enabled = false;
                pb2x8.Enabled = false;
                pb2x9.Enabled = false;
                pb2x10.Enabled = false;
                pb2x11.Enabled = false;
                pb2x12.Enabled = false;
                pb2x13.Enabled = false;
                pb2x14.Enabled = false;
                pb2x15.Enabled = false;
                pb2x16.Enabled = false;
                pb2x17.Enabled = false;
                pb2x18.Enabled = false;
                pb2x19.Enabled = false;
                pb2x20.Enabled = false;
                pb2x21.Enabled = false;
                pb2x22.Enabled = false;
                pb2x23.Enabled = false;
                pb2x24.Enabled = false;
                pb2x25.Enabled = false;
                pb2x26.Enabled = false;
                pb2x27.Enabled = false;
                pb2x28.Enabled = false;
                pbdet2.Image = bankers_game_proto.Properties.Resources.Rosevelt_Station_t;


                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb2x26_Click(object sender, EventArgs e)
        {
            if (p1trad == 1)
            {
                ListViewItem santol = new ListViewItem();
                transportation2x2trd2 = 1;
                btntrad2.Visible = false;
                santol.ForeColor = Color.SteelBlue;
                santol.Text = "Santolan Station";
                p2lvw.Items.Add(santol);

                drawcarded.Play();
            }
            if (p2trad == 1)
            {
                ListViewItem santol = new ListViewItem();
                transportation2x2trd2 = 1;
                btntrad2.Visible = false;
                santol.ForeColor = Color.SteelBlue;
                santol.Text = "Santolan Station";
                p2lvw.Items.Add(santol);

                drawcarded.Play();
            }
            if (p3trad == 1)
            {
                ListViewItem santol = new ListViewItem();
                transportation2x2trd2 = 1;
                btntrad2.Visible = false;
                santol.ForeColor = Color.SteelBlue;
                santol.Text = "Santolan Station";
                p2lvw.Items.Add(santol);

                drawcarded.Play();
            }
            if (p4trad == 1)
            {
                ListViewItem santol = new ListViewItem();
                transportation2x2trd2 = 1;
                btntrad2.Visible = false;
                santol.ForeColor = Color.SteelBlue;
                santol.Text = "Santolan Station";
                p2lvw.Items.Add(santol);

                drawcarded.Play();
            }
            if (det == 2 || det == 2 && p1 == 1 || det == 2 && p2 == 1 || det == 2 && p3 == 1 || det == 2 && p4 == 1)
            {
                p2tr.Visible = true;
                pbdet2.Visible = true;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                transportation2x2det2 = 1;
                pb2x1.Enabled = false;
                pb2x2.Enabled = false;
                pb2x3.Enabled = false;
                pb2x4.Enabled = false;
                pb2x5.Enabled = false;
                pb2x6.Enabled = false;
                pb2x7.Enabled = false;
                pb2x8.Enabled = false;
                pb2x9.Enabled = false;
                pb2x10.Enabled = false;
                pb2x11.Enabled = false;
                pb2x12.Enabled = false;
                pb2x13.Enabled = false;
                pb2x14.Enabled = false;
                pb2x15.Enabled = false;
                pb2x16.Enabled = false;
                pb2x17.Enabled = false;
                pb2x18.Enabled = false;
                pb2x19.Enabled = false;
                pb2x20.Enabled = false;
                pb2x21.Enabled = false;
                pb2x22.Enabled = false;
                pb2x23.Enabled = false;
                pb2x24.Enabled = false;
                pb2x25.Enabled = false;
                pb2x26.Enabled = false;
                pb2x27.Enabled = false;
                pb2x28.Enabled = false;
                pbdet2.Image = bankers_game_proto.Properties.Resources.Santolan_Station_t;


                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb2x27_Click(object sender, EventArgs e)
        {
            if (p1trad == 1)
            {
                ListViewItem fairview = new ListViewItem();
                transportation2x3trd2 = 1;
                btntrad2.Visible = false;
                fairview.ForeColor = Color.SteelBlue;
                fairview.Text = "Quezon Station";
                p2lvw.Items.Add(fairview);

                drawcarded.Play();
            }
            if (p2trad == 1)
            {
                ListViewItem fairview = new ListViewItem();
                transportation2x3trd2 = 1;
                btntrad2.Visible = false;
                fairview.ForeColor = Color.SteelBlue;
                fairview.Text = "Quezon Station";
                p2lvw.Items.Add(fairview);

                drawcarded.Play();
            }
            if (p3trad == 1)
            {
                ListViewItem fairview = new ListViewItem();
                transportation2x3trd2 = 1;
                btntrad2.Visible = false;
                fairview.ForeColor = Color.SteelBlue;
                fairview.Text = "Quezon Station";
                p2lvw.Items.Add(fairview);

                drawcarded.Play();
            }
            if (p4trad == 1)
            {
                ListViewItem fairview = new ListViewItem();
                transportation2x3trd2 = 1;
                btntrad2.Visible = false;
                fairview.ForeColor = Color.SteelBlue;
                fairview.Text = "Quezon Station";
                p2lvw.Items.Add(fairview);

                drawcarded.Play();
            }
            if (det == 2 || det == 2 && p1 == 1 || det == 2 && p2 == 1 || det == 2 && p3 == 1 || det == 2 && p4 == 1)
            {
                p2tr.Visible = true;
                pbdet2.Visible = true;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                transportation2x3det2 = 1;
                pb2x1.Enabled = false;
                pb2x2.Enabled = false;
                pb2x3.Enabled = false;
                pb2x4.Enabled = false;
                pb2x5.Enabled = false;
                pb2x6.Enabled = false;
                pb2x7.Enabled = false;
                pb2x8.Enabled = false;
                pb2x9.Enabled = false;
                pb2x10.Enabled = false;
                pb2x11.Enabled = false;
                pb2x12.Enabled = false;
                pb2x13.Enabled = false;
                pb2x14.Enabled = false;
                pb2x15.Enabled = false;
                pb2x16.Enabled = false;
                pb2x17.Enabled = false;
                pb2x18.Enabled = false;
                pb2x19.Enabled = false;
                pb2x20.Enabled = false;
                pb2x21.Enabled = false;
                pb2x22.Enabled = false;
                pb2x23.Enabled = false;
                pb2x24.Enabled = false;
                pb2x25.Enabled = false;
                pb2x26.Enabled = false;
                pb2x27.Enabled = false;
                pb2x28.Enabled = false;
                pbdet2.Image = bankers_game_proto.Properties.Resources.Quezon_Station_t;


                drawcarded.Play();
            }
            drawcarded.Play();
        }

        private void pb2x28_Click(object sender, EventArgs e)
        {
            if (p1trad == 1)
            {
                ListViewItem stame = new ListViewItem();
                transportation2x4trd2 = 1;
                btntrad2.Visible = false;
                stame.ForeColor = Color.SteelBlue;
                stame.Text = "Trinoma Station";
                p2lvw.Items.Add(stame);

                drawcarded.Play();
            }
            if (p2trad == 1)
            {
                ListViewItem stame = new ListViewItem();
                transportation2x4trd2 = 1;
                btntrad2.Visible = false;
                stame.ForeColor = Color.SteelBlue;
                stame.Text = "Trinoma Station";
                p2lvw.Items.Add(stame);

                drawcarded.Play();
            }
            if (p3trad == 1)
            {
                ListViewItem stame = new ListViewItem();
                transportation2x4trd2 = 1;
                btntrad2.Visible = false;
                stame.ForeColor = Color.SteelBlue;
                stame.Text = "Trinoma Station";
                p2lvw.Items.Add(stame);

                drawcarded.Play();
            }
            if (p4trad == 1)
            {
                ListViewItem stame = new ListViewItem();
                transportation2x4trd2 = 1;
                btntrad2.Visible = false;
                stame.ForeColor = Color.SteelBlue;
                stame.Text = "Trinoma Station";
                p2lvw.Items.Add(stame);

                drawcarded.Play();
            }
            if (det == 2 || det == 2 && p1 == 1 || det == 2 && p2 == 1 || det == 2 && p3 == 1 || det == 2 && p4 == 1)
            {
                p2tr.Visible = true;
                pbdet2.Visible = true;
                btntrad2.Visible = true;
                btnback2.Visible = true;
                transportation2x4det2 = 1;
                pb2x1.Enabled = false;
                pb2x2.Enabled = false;
                pb2x3.Enabled = false;
                pb2x4.Enabled = false;
                pb2x5.Enabled = false;
                pb2x6.Enabled = false;
                pb2x7.Enabled = false;
                pb2x8.Enabled = false;
                pb2x9.Enabled = false;
                pb2x10.Enabled = false;
                pb2x11.Enabled = false;
                pb2x12.Enabled = false;
                pb2x13.Enabled = false;
                pb2x14.Enabled = false;
                pb2x15.Enabled = false;
                pb2x16.Enabled = false;
                pb2x17.Enabled = false;
                pb2x18.Enabled = false;
                pb2x19.Enabled = false;
                pb2x20.Enabled = false;
                pb2x21.Enabled = false;
                pb2x22.Enabled = false;
                pb2x23.Enabled = false;
                pb2x24.Enabled = false;
                pb2x25.Enabled = false;
                pb2x26.Enabled = false;
                pb2x27.Enabled = false;
                pb2x28.Enabled = false;

                pbdet2.Image = bankers_game_proto.Properties.Resources.Trinoma_Station_t;

                drawcarded.Play();
            }
            drawcarded.Play();
        }


        #endregion

        #region design

        void icons()
        {
            groupBox1.BackgroundImage = bankers_game_proto.Properties.Resources.meet;
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;

            btntrad1.BackgroundImage = bankers_game_proto.Properties.Resources.check;
            btntrad1.BackgroundImageLayout = ImageLayout.Zoom;

            btnacc1.BackgroundImage = bankers_game_proto.Properties.Resources.check;
            btnacc1.BackgroundImageLayout = ImageLayout.Stretch;

            btndec1.BackgroundImage = bankers_game_proto.Properties.Resources.cancel;
            btndec1.BackgroundImageLayout = ImageLayout.Stretch;

            btnback1.BackgroundImage = bankers_game_proto.Properties.Resources.cancel;
            btnback1.BackgroundImageLayout = ImageLayout.Zoom;

            btnquit1.BackgroundImage = bankers_game_proto.Properties.Resources.exit1;
            btnquit1.BackgroundImageLayout = ImageLayout.Zoom;

            btnacc2.BackgroundImage = bankers_game_proto.Properties.Resources.check_t;
            btnacc2.BackgroundImageLayout = ImageLayout.Stretch;

            btndec2.BackgroundImage = bankers_game_proto.Properties.Resources.cancel;
            btndec2.BackgroundImageLayout = ImageLayout.Stretch;

            btntrad2.BackgroundImage = bankers_game_proto.Properties.Resources.check_t;
            btntrad2.BackgroundImageLayout = ImageLayout.Zoom;

            btnback2.BackgroundImage = bankers_game_proto.Properties.Resources.cancel;
            btnback2.BackgroundImageLayout = ImageLayout.Zoom;

            btnquit2.BackgroundImage = bankers_game_proto.Properties.Resources.exit_t;
            btnquit2.BackgroundImageLayout = ImageLayout.Zoom;

            btnp1.BackgroundImage = bankers_game_proto.Properties.Resources.p1_d;
            btnp1.BackgroundImageLayout = ImageLayout.Stretch;

            btnp2.BackgroundImage = bankers_game_proto.Properties.Resources.p2_t;
            btnp2.BackgroundImageLayout = ImageLayout.Stretch;

            p1props.BackgroundImage = bankers_game_proto.Properties.Resources.panel;
            p1props.BackgroundImageLayout = ImageLayout.Stretch;
            p2props.BackgroundImage = bankers_game_proto.Properties.Resources.panel;
            p2props.BackgroundImageLayout = ImageLayout.Stretch;

            p1tr.BackgroundImage = bankers_game_proto.Properties.Resources.panel;
            p1tr.BackgroundImageLayout = ImageLayout.Stretch;
            p2tr.BackgroundImage = bankers_game_proto.Properties.Resources.panel;
            p2tr.BackgroundImageLayout = ImageLayout.Stretch;

            notif1.BackgroundImage = bankers_game_proto.Properties.Resources.panel;
            notif1.BackgroundImageLayout = ImageLayout.Stretch;
            notif2.BackgroundImage = bankers_game_proto.Properties.Resources.panel;
            notif2.BackgroundImageLayout = ImageLayout.Stretch;
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

        void p2tr_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, p2tr.ClientRectangle,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        void p1tr_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, p1tr.ClientRectangle,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        void btnp2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnp2.ClientRectangle,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        void btnp1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnp1.ClientRectangle,
             SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
             SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
             SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
             SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        void pbdet2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pbdet2.ClientRectangle,
              SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
              SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
              SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
              SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        void pbdet1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pbdet1.ClientRectangle,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        void p2props_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, p2props.ClientRectangle,
              SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
              SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
              SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
              SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        void p1props_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, p1props.ClientRectangle,
             SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
             SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
             SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
             SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        #endregion


        private void tradp4_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            turn1();


            p1 = 0;
            p2 = 0;
            p3 = 0;
            p4 = 0;

            #region paint
            btnp1.Paint += new PaintEventHandler(btnp1_Paint);
            btnp2.Paint += new PaintEventHandler(btnp2_Paint);
            p1tr.Paint += new PaintEventHandler(p1tr_Paint);
            p2tr.Paint += new PaintEventHandler(p2tr_Paint);
            notif1.Paint += new PaintEventHandler(notif1_Paint);
            notif2.Paint += new PaintEventHandler(notif2_Paint);
            p1props.Paint += new PaintEventHandler(p1props_Paint);
            p2props.Paint += new PaintEventHandler(p2props_Paint);
            pbdet1.Paint += new PaintEventHandler(pbdet1_Paint);
            pbdet2.Paint += new PaintEventHandler(pbdet2_Paint);
            #endregion

            colorturn();
            trp1();
            trp2();
            trp3();
            trp4();
            trp1trad();
            trp2trad();
            trp3trad();
            trp4trad();


            icons();

            guide();

        }

        private void btnp2_Click(object sender, EventArgs e)
        {
            det = 2;
            p2tr.Visible = true;
            btnp2.Visible = false;
            tip2.Visible = true;
            quick2 = Settings.timer2;
            tmr2.Text = quick2 / 60 + ":" + ((quick2 % 60) >= 10 ? (quick2 % 60).ToString() : "0" + (quick2 % 60));
            p2timer.Start();
            click.Play();
        }

        private void btnp1_Click(object sender, EventArgs e)
        {
            det = 1;
            p1tr.Visible = true;
            btnp1.Visible = false;
            tip1.Visible = true;
            quick = Settings.timer1;
            tmr1.Text = quick / 60 + ":" + ((quick % 60) >= 10 ? (quick % 60).ToString() : "0" + (quick % 60));
            timer1.Start();
            click.Play();
        }

        private void btntrad2_Click(object sender, EventArgs e)
        {
            click.Play();
          
            if (p1 == 1)
            {
                tradep1();
                btnerase2.Visible = true;
                btntrad2.Visible = false;
            }
            if (p2 == 1)
            {
                tradep2();
                btntrad2.Visible = false;
                btnerase2.Visible = true;
            }

             if (p3 == 1)
            {
                tradep3();
                btnerase2.Visible = true;
                btntrad2.Visible = false;
            }
            if (p4 == 1)
            {
                tradep4();
                btnerase2.Visible = true;
                btntrad2.Visible = false;
            }

        }

        private void btntrad1_Click(object sender, EventArgs e)
        {
            click.Play();
           
            if (p1trad == 1)
            {
                tradep1trad();
                btnerase1.Visible = true;
                btntrad1.Visible = false;

            }
            if (p2trad == 1)
            {
                tradep2trad();
                btnerase1.Visible = true;
                btntrad1.Visible = false;
            }
            if (p3trad == 1)
            {
                tradep3trad();
                btnerase1.Visible = true;
                btntrad1.Visible = false;
            }
            if (p4trad == 1)
            {
                tradep4trad();
                btnerase1.Visible = true;
                btntrad1.Visible = false;
            }
        }

        private void btntraded1_Click(object sender, EventArgs e)
        {
            click.Play();
            if (p1trad == 1 && p1lvw.Items.Count >= 1 && p2lvw.Items.Count >= 1)
            {
                notif2.Visible = true;
                p2notif.Text = "P1 is requesting a trade " + "\r\n(Warning: this property/ies may have greater value/s)";
                pb2notif.Image = bankers_game_proto.Properties.Resources.trade_t;
                btnacc2.Visible = true;
                btndec2.Visible = true;
                btnp2.Enabled = false;
                p2tr.Visible = false;
                btntrad2.Visible = false;
                btnback2.Visible = false;

                btntrad2.Visible = false;
                btnback2.Visible = false;

            }
            if (p2trad == 1 && p1lvw.Items.Count >= 1 && p2lvw.Items.Count >= 1)
            {
                notif2.Visible = true;
                p2notif.Text = "P2 is requesting a trade " + "\r\n(Warning: this property/ies may have greater value/s)";
                pb2notif.Image = bankers_game_proto.Properties.Resources.trade_t;
                btnacc2.Visible = true;
                btndec2.Visible = true;
                btnp2.Enabled = false;
                p2tr.Visible = false;
                btntrad2.Visible = false;
                btnback2.Visible = false;

                btntrad2.Visible = false;
                btnback2.Visible = false;

            }
            if (p3trad == 1 && p1lvw.Items.Count >= 1 && p2lvw.Items.Count >= 1)
            {
                notif2.Visible = true;
                p2notif.Text = "P3 is requesting a trade " + "\r\n(Warning: this property/ies may have greater value/s)";
                pb2notif.Image = bankers_game_proto.Properties.Resources.trade_t;
                btnacc2.Visible = true;
                btndec2.Visible = true;
                btnp2.Enabled = false;
                p2tr.Visible = false;
                btntrad2.Visible = false;
                btnback2.Visible = false;

                btntrad2.Visible = false;
                btnback2.Visible = false;

            }
            if (p4trad == 1 && p1lvw.Items.Count >= 1 && p2lvw.Items.Count >= 1)
            {
                notif2.Visible = true;
                p2notif.Text = "P4 is requesting a trade " + "\r\n(Warning: this property/ies may have greater value/s)";
                pb2notif.Image = bankers_game_proto.Properties.Resources.trade_t;
                btnacc2.Visible = true;
                btndec2.Visible = true;
                btnp2.Enabled = false;
                p2tr.Visible = false;
                btntrad2.Visible = false;
                btnback2.Visible = false;

                btntrad2.Visible = false;
                btnback2.Visible = false;

            }


            if (p1 == 1 && p1lvw.Items.Count >= 1 && p2lvw.Items.Count >= 1)
            {
                notif1.Visible = true;
                p1notif.Text = "P1 is requesting a trade " + "\r\n(Warning: this property/ies may have greater value/s)";
                pb1notif.Image = bankers_game_proto.Properties.Resources.trade;
                btnacc1.Visible = true;
                btndec1.Visible = true;
                btnp2.Enabled = false;
                p1tr.Visible = false;
                btntrad1.Visible = false;
                btnback1.Visible = false;

                btntrad1.Visible = false;
                btnback1.Visible = false;

            }

            if (p2 == 1 && p1lvw.Items.Count >= 1 && p2lvw.Items.Count >= 1)
            {
                notif1.Visible = true;
                p1notif.Text = "P2 is requesting a trade " + "\r\n(Warning: this property/ies may have greater value/s)";
                pb1notif.Image = bankers_game_proto.Properties.Resources.trade;
                btnacc1.Visible = true;
                btndec1.Visible = true;
                btnp2.Enabled = false;
                p1tr.Visible = false;
                btntrad1.Visible = false;
                btnback1.Visible = false;

                btntrad1.Visible = false;
                btnback1.Visible = false;

            }

            if (p3 == 1 && p1lvw.Items.Count >= 1 && p2lvw.Items.Count >= 1)
            {
                notif1.Visible = true;
                pb1notif.Image = bankers_game_proto.Properties.Resources.trade;
                p1notif.Text = "P3 is requesting a trade " + "\r\n(Warning: this property/ies may have greater value/s)";
                btnacc1.Visible = true;
                btndec1.Visible = true;
                btnp2.Enabled = false;
                p1tr.Visible = false;
                btntrad1.Visible = false;
                btnback1.Visible = false;

                btntrad1.Visible = false;
                btnback1.Visible = false;

            }

            if (p4 == 1 && p1lvw.Items.Count >= 1 && p2lvw.Items.Count >= 1)
            {
                notif1.Visible = true;
                pb1notif.Image = bankers_game_proto.Properties.Resources.trade;
                p1notif.Text = "P4 is requesting a trade " + "\r\n(Warning: this property/ies may have greater value/s)";
                btnacc1.Visible = true;
                btndec1.Visible = true;
                btnp2.Enabled = false;
                p1tr.Visible = false;
                btntrad1.Visible = false;
                btnback1.Visible = false;

                btntrad1.Visible = false;
                btnback1.Visible = false;

            }


            if (p1lvw.Items.Count == 0 && p2lvw.Items.Count == 0 || p1lvw.Items.Count == 0 || p2lvw.Items.Count == 0)
            {
                MessageBox.Show("Fields Empty");

                p1lvw.Items.Clear();
                p2lvw.Items.Clear();
                easternschooltrd1 = 0;
                westernschooltrd1 = 0;
                visayashighschooltrd1 = 0;
                southernschooltrd1 = 0;
                nationsschooltrd1 = 0;
                westmarkettrd1 = 0;
                nightmarkettrd1 = 0;
                daymarkettrd1 = 0;
                starmarkettrd1 = 0;
                moonmarkettrd1 = 0;
                megamarkettrd1 = 0;
                visayashospitaltrd1 = 0;
                hobertshospitaltrd1 = 0;
                heartshospitaltrd1 = 0;
                internshospitaltrd1 = 0;
                nationalhealthhospitaltrd1 = 0;
                veteranshospitaltrd1 = 0;
                pearlmalltrd1 = 0;
                megamalltrd1 = 0;
                articmalltrd1 = 0;
                heavenlymalltrd1 = 0;
                shangrillamalltrd1 = 0;
                utility1x1trd1 = 0;
                utility1x2trd1 = 0;
                transportation1x1trd1 = 0;
                transportation1x2trd1 = 0;
                transportation1x3trd1 = 0;
                transportation1x4trd1 = 0;

                easternschooltrd2 = 0;
                westernschooltrd2 = 0;
                visayashighschooltrd2 = 0;
                southernschooltrd2 = 0;
                nationsschooltrd2 = 0;
                westmarkettrd2 = 0;
                nightmarkettrd2 = 0;
                daymarkettrd2 = 0;
                starmarkettrd2 = 0;
                moonmarkettrd2 = 0;
                megamarkettrd2 = 0;
                visayashospitaltrd2 = 0;
                hobertshospitaltrd2 = 0;
                heartshospitaltrd2 = 0;
                internshospitaltrd2 = 0;
                nationalhealthhospitaltrd2 = 0;
                veteranshospitaltrd2 = 0;
                pearlmalltrd2 = 0;
                megamalltrd2 = 0;
                articmalltrd2 = 0;
                heavenlymalltrd2 = 0;
                shangrillamalltrd2 = 0;
                utility2x1trd2 = 0;
                utility2x2trd2 = 0;
                transportation2x1trd2 = 0;
                transportation2x2trd2 = 0;
                transportation2x3trd2 = 0;
                transportation2x4trd2 = 0;

                notif1.Visible = false;
                notif2.Visible = false;
                p2tr.Enabled = true;
                p1tr.Enabled = true;

            }



        }

        private void btnacc2_Click(object sender, EventArgs e)
        {
            if (p1tradein1 == 1 )
            {
              
                turnedd1();
                guide();
                good.Play();
                p2timer.Stop();
                turnsint = 1;
                timer3.Start(); 
                btnerase1.Visible = false;
            }

            if (p2tradein2 == 1)
            {
                
                turnedd1_2();
                guide();
                good.Play();
                p2timer.Stop();
                turnsint = 1;
                timer3.Start();
                btnerase1.Visible = false;
            }
            if (p3tradein3 == 1)
            {
                
                turnedd1_3();
                good.Play();
                guide();
                p2timer.Stop();
                turnsint = 1;
                timer3.Start();
                btnerase1.Visible = false;
            }

            if (p4tradein4 == 1)
            {
               
                turnedd1_4();

                good.Play();

                guide();
                p2timer.Stop();
                turnsint = 1;
                timer3.Start(); 
                btnerase1.Visible = false;
            }
            if (p2notif.Text.StartsWith("Click the player icon \r\nto the corner right side to show control-panel"))
            {
                btnp2.Enabled = true;
                notif2.Visible = false;
                tip2.Visible = true;
                click.Play();
            }

            if (p2notif.Text.StartsWith(" To trade properties, select the following properties that you want to trade.\r\n  located at the 2 panels, above the player icons"))
            {
                p2tr.Enabled = true;
                notif2.Visible = false;
                tip2.Visible = true;
                click.Play();
            }
            if (p2notif.Text.StartsWith("Do you want to leave trading?"))
            {
               
                p4tradein4 = 0;
                p3tradein3 = 0;
                p2tradein2 = 0;
                p1tradein1 = 0;
                p1 = 0;
                p2 = 0;
                p3 = 0;
                p4 = 0;
                p4_gameplay.p1 = 0;
                p4_gameplay.p2 = 0;
                p4_gameplay.p3 = 0;
                p4_gameplay.p4 = 0;
                p4_gameplay.p1tr = 0;
                p4_gameplay.p2tr = 0;
                p4_gameplay.p3tr = 0;
                p4_gameplay.p4tr = 0;
                p4_gameplay.p1trad = 0;
                p4_gameplay.p2trad = 0;
                p4_gameplay.p3trad = 0;
                p4_gameplay.p4trad = 0;


                click.Play();
                timer1.Stop();
                p2timer.Stop();
                ruletrad.Stop();
                timer3.Stop();
                timer1.Dispose();
                p2timer.Dispose();
                ruletrad.Dispose();
                timer3.Dispose();

                this.Close();
            }
            if (p2notif.Text.StartsWith("Player 1's turn"))
            {
                click.Play();
                btnerase1.Visible = false;
                notif2.Visible = false;
                p2tr.Enabled = true;
                btnp2.Enabled = true;
                turnsint = 0;
                tip2.Visible = true;
                timer3.Stop();
            }
            if (p2notif.Text.StartsWith("Player 2's turn"))
            {
                click.Play();
                btnerase1.Visible = false;
                notif2.Visible = false;
                p2tr.Enabled = true;
                btnp2.Enabled = true;
                turnsint = 0;
                tip2.Visible = true;
                timer3.Stop();
            }
            if (p2notif.Text.StartsWith("Player 3's turn"))
            {
                click.Play();
                btnerase1.Visible = false;
                notif2.Visible = false;
                p2tr.Enabled = true;
                btnp2.Enabled = true;
                turnsint = 0;
                tip2.Visible = true;
                timer3.Stop();
            }
            if (p2notif.Text.StartsWith("Player 4's turn"))
            {
                click.Play();
                btnerase1.Visible = false;
                notif2.Visible = false;
                p2tr.Enabled = true;
                btnp2.Enabled = true;
                turnsint = 0;
                tip2.Visible = true;
                timer3.Stop();
            }

            if (p2notif.Text.StartsWith("The trade has been cancelled."))
            {
                p4tradein4 = 0;
                p3tradein3 = 0;
                p2tradein2 = 0;
                p1tradein1 = 0;
                p1 = 0;
                p2 = 0;
                p3 = 0;
                p4 = 0;
                p4_gameplay.p1 = 0;
                p4_gameplay.p2 = 0;
                p4_gameplay.p3 = 0;
                p4_gameplay.p4 = 0;
                p4_gameplay.p1tr = 0;
                p4_gameplay.p2tr = 0;
                p4_gameplay.p3tr = 0;
                p4_gameplay.p4tr = 0;
                p4_gameplay.p1trad = 0;
                p4_gameplay.p2trad = 0;
                p4_gameplay.p3trad = 0;
                p4_gameplay.p4trad = 0;

                timer1.Stop();
                p2timer.Stop();
                ruletrad.Stop();
                timer3.Stop();
                timer1.Dispose();
                p2timer.Dispose();
                ruletrad.Dispose();
                timer3.Dispose();
                this.Close();
            }
        }

        private void btnacc1_Click(object sender, EventArgs e)
        {
            if (p1tradein1 == 1 )
            {
               
                turnedd2();
                guide();
                good.Play();
                timer1.Stop();
                turnsint = 1;
                timer3.Start();
                btnerase2.Visible = false;
            }
            if (p2tradein2 == 1)
            {
               
                turnedd2_2();
                guide();
                good.Play();
                timer1.Stop();
                turnsint = 1;
                timer3.Start(); 
                btnerase2.Visible = false;
            }

            if (p3tradein3 == 1)
            {
               
                turnedd2_3();
                guide();
                good.Play();
                timer1.Stop();
                turnsint = 1;
                timer3.Start(); 
                btnerase2.Visible = false;
            }
            if (p4tradein4 == 1)
            {
                
                turnedd2_4();
                guide();
                
                good.Play();
                timer1.Stop();
                turnsint = 1;
                timer3.Start();
                btnerase2.Visible = false;
            }

            if (p1notif.Text.StartsWith("Click the player icon \r\nto the corner right side to show control-panel"))
            {
                btnp1.Enabled = true;
                notif1.Visible = false;
                tip1.Visible = true;
            }

            if (p1notif.Text.StartsWith(" To trade properties, select the following properties that you want to trade.\r\n  located at the 2 panels, above the player icons"))
            {
                p1tr.Enabled = true;
                notif1.Visible = false;
                tip1.Visible = true;
            }

            if (p1notif.Text.StartsWith("Do you want to leave trading?"))
            {
                ruletrad.Stop();
                timer1.Stop();
                p2timer.Stop();
      
                p4tradein4 = 0;
                p3tradein3 = 0;
                p2tradein2 = 0;
                p1tradein1 = 0;
                p1 = 0;
                p2 = 0;
                p3 = 0;
                p4 = 0;
                p4_gameplay.p1 = 0;
                p4_gameplay.p2 = 0;
                p4_gameplay.p3 = 0;
                p4_gameplay.p4 = 0;
                p4_gameplay.p1tr = 0;
                p4_gameplay.p2tr = 0;
                p4_gameplay.p3tr = 0;
                p4_gameplay.p4tr = 0;
                p4_gameplay.p1trad = 0;
                p4_gameplay.p2trad = 0;
                p4_gameplay.p3trad = 0;
                p4_gameplay.p4trad = 0;
               
                click.Play();
                timer1.Stop();
                p2timer.Stop();
                ruletrad.Stop();
                timer3.Stop();
                timer1.Dispose();
                p2timer.Dispose();
                ruletrad.Dispose();
                timer3.Dispose();

               
                this.Close();
            }
            if (p1notif.Text.StartsWith("Player 1's turn"))
            {
                btnerase2.Visible = false;
                click.Play();
                notif1.Visible = false;
                p1tr.Enabled = true;
                btnp1.Enabled = true;
                turnsint = 0;
                tip1.Visible = true;
                timer3.Stop();
            }
            if (p1notif.Text.StartsWith("Player 2's turn"))
            {
                btnerase2.Visible = false;
                click.Play();
                notif1.Visible = false;
                p1tr.Enabled = true;
                btnp1.Enabled = true;
                turnsint = 0;
                tip1.Visible = true;
                timer3.Stop();
            }
            if (p1notif.Text.StartsWith("Player 3's turn"))
            {
                btnerase2.Visible = false;
                click.Play();
                notif1.Visible = false;
                p1tr.Enabled = true;
                btnp1.Enabled = true;
                turnsint = 0;
                tip1.Visible = true;
                timer3.Stop();
            }
            if (p1notif.Text.StartsWith("Player 4's turn"))
            {
                btnerase2.Visible = false;
                click.Play();
                notif1.Visible = false;
                p1tr.Enabled = true;
                btnp1.Enabled = true;
                turnsint = 0;
                timer3.Stop();
            }

            if (p1notif.Text.StartsWith("The trade has been cancelled."))
            {
                p4tradein4 = 0;
                p3tradein3 = 0;
                p2tradein2 = 0;
                p1tradein1 = 0;
                p1 = 0;
                p2 = 0;
                p3 = 0;
                p4 = 0;
                p4_gameplay.p1 = 0;
                p4_gameplay.p2 = 0;
                p4_gameplay.p3 = 0;
                p4_gameplay.p4 = 0;
                p4_gameplay.p1tr = 0;
                p4_gameplay.p2tr = 0;
                p4_gameplay.p3tr = 0;
                p4_gameplay.p4tr = 0;
                p4_gameplay.p1trad = 0;
                p4_gameplay.p2trad = 0;
                p4_gameplay.p3trad = 0;
                p4_gameplay.p4trad = 0;

                timer1.Stop();
                p2timer.Stop();
                ruletrad.Stop();
                timer3.Stop();
                timer1.Dispose();
                p2timer.Dispose();
                ruletrad.Dispose();
                timer3.Dispose();

                this.Close();
            }

        }

        private void ruletrad_Tick(object sender, EventArgs e)
        {
            trp1();
            trp2();
            trp3();
            trp4();
            trp1trad();
            trp2trad();
            trp3trad();
            trp4trad();
            colorturn();
            rushedquit();

        }

        private void btnback1_Click(object sender, EventArgs e)
        {
            decline.Play();
            det = 0;
            p1tr.Visible = false;
            pbdet1.Visible = false;
            btnp1.Visible = true;
            btnp1.Enabled = true;

            //det flags
            easternschooldet1 = 0;
            westernschooldet1 = 0;
            visayashighschooldet1 = 0;
            southernschooldet1 = 0;
            nationsschooldet1 = 0;
            westmarketdet1 = 0;
            nightmarketdet1 = 0;
            daymarketdet1 = 0;
            starmarketdet1 = 0;
            moonmarketdet1 = 0;
            megamarketdet1 = 0;
            visayashospitaldet1 = 0;
            hobertshospitaldet1 = 0;
            heartshospitaldet1 = 0;
            internshospitaldet1 = 0;
            nationalhealthhospitaldet1 = 0;
            veteranshospitaldet1 = 0;
            pearlmalldet1 = 0;
            megamalldet1 = 0;
            articmalldet1 = 0;
            heavenlymalldet1 = 0;
            shangrillamalldet1 = 0;
            utility1x1det1 = 0;
            utility1x2det1 = 0;
            transportation1x1det1 = 0;
            transportation1x2det1 = 0;
            transportation1x3det1 = 0;
            transportation1x4det1 = 0;

            pb1x1.Enabled = true;
            pb1x2.Enabled = true;
            pb1x3.Enabled = true;
            pb1x4.Enabled = true;
            pb1x5.Enabled = true;
            pb1x6.Enabled = true;
            pb1x7.Enabled = true;
            pb1x8.Enabled = true;
            pb1x9.Enabled = true;
            pb1x10.Enabled = true;
            pb1x11.Enabled = true;
            pb1x12.Enabled = true;
            pb1x13.Enabled = true;
            pb1x14.Enabled = true;
            pb1x15.Enabled = true;
            pb1x16.Enabled = true;
            pb1x17.Enabled = true;
            pb1x18.Enabled = true;
            pb1x19.Enabled = true;
            pb1x20.Enabled = true;
            pb1x21.Enabled = true;
            pb1x22.Enabled = true;
            pb1x23.Enabled = true;
            pb1x24.Enabled = true;
            pb1x25.Enabled = true;
            pb1x26.Enabled = true;
            pb1x27.Enabled = true;
            pb1x28.Enabled = true;

        }

        private void btnback2_Click(object sender, EventArgs e)
        {
            decline.Play();
            det = 0;
            p2tr.Visible = false;
            pbdet2.Visible = false;
            btnp2.Visible = true;
            btnp2.Enabled = true;
            btntrad2.Visible = false;

            //det flags
            easternschooldet2 = 0;
            westernschooldet2 = 0;
            visayashighschooldet2 = 0;
            southernschooldet2 = 0;
            nationsschooldet2 = 0;
            westmarketdet2 = 0;
            nightmarketdet2 = 0;
            daymarketdet2 = 0;
            starmarketdet2 = 0;
            moonmarketdet2 = 0;
            megamarketdet2 = 0;
            visayashospitaldet2 = 0;
            hobertshospitaldet2 = 0;
            heartshospitaldet2 = 0;
            internshospitaldet2 = 0;
            nationalhealthhospitaldet2 = 0;
            veteranshospitaldet2 = 0;
            pearlmalldet2 = 0;
            megamalldet2 = 0;
            articmalldet2 = 0;
            heavenlymalldet2 = 0;
            shangrillamalldet2 = 0;
            utility2x1det2 = 0;
            utility2x2det2 = 0;
            transportation2x1det2 = 0;
            transportation2x2det2 = 0;
            transportation2x3det2 = 0;
            transportation2x4det2 = 0;

            pb2x1.Enabled = true;
            pb2x2.Enabled = true;
            pb2x3.Enabled = true;
            pb2x4.Enabled = true;
            pb2x5.Enabled = true;
            pb2x6.Enabled = true;
            pb2x7.Enabled = true;
            pb2x8.Enabled = true;
            pb2x9.Enabled = true;
            pb2x10.Enabled = true;
            pb2x11.Enabled = true;
            pb2x12.Enabled = true;
            pb2x13.Enabled = true;
            pb2x14.Enabled = true;
            pb2x15.Enabled = true;
            pb2x16.Enabled = true;
            pb2x17.Enabled = true;
            pb2x18.Enabled = true;
            pb2x19.Enabled = true;
            pb2x20.Enabled = true;
            pb2x21.Enabled = true;
            pb2x22.Enabled = true;
            pb2x23.Enabled = true;
            pb2x24.Enabled = true;
            pb2x25.Enabled = true;
            pb2x26.Enabled = true;
            pb2x27.Enabled = true;
            pb2x28.Enabled = true;

        }

        private void btnquit2_Click(object sender, EventArgs e)
        {
            notif2.Visible = true;
            pb2notif.Image = bankers_game_proto.Properties.Resources.exit_t;
            p2notif.Text = "Do you want to leave trading?";
            p2tr.Enabled = false;
            btnacc2.Visible = true;
            btndec2.Visible = true;
        }

        private void btnquit1_Click(object sender, EventArgs e)
        {
            notif1.Visible = true;
            pb1notif.Image = bankers_game_proto.Properties.Resources.exit1;
            p1notif.Text = "Do you want to leave trading?";
            p1tr.Enabled = false;
            btnacc1.Visible = true;
            btndec1.Visible = true;
        }

        private void btndec2_Click(object sender, EventArgs e)
        {
            decline.Play();
            if (p1tradein1 == 1)
            {
                guide();
                turneddec1();
                p2timer.Stop();
                turnsint = 1;
                timer3.Start();
            }

            if (p2tradein2 == 1)
            {
                guide();
                turneddec1_2();
                p2timer.Stop();
                turnsint = 1;
                timer3.Start();
            }
            if (p3tradein3 == 1)
            {
                guide();
                turneddec1_3();
                p2timer.Stop();
                turnsint = 1;
                timer3.Start();
            }

            if (p4tradein4 == 1)
            {
                guide();
                turneddec1_4();
                p2timer.Stop();
                turnsint = 1;
                timer3.Start();
            }
            if (p2notif.Text.StartsWith("Do you want to leave trading?"))
            {
                p2tr.Enabled = true;
                notif2.Visible = false;
                tip2.Visible = true;
                timer3.Stop();
            }
        }

        private void btndec1_Click(object sender, EventArgs e)
        {
            decline.Play();
            if (p1tradein1 == 1)
            {
                guide();
                turneddec2();
                timer1.Stop();
                turnsint = 1;
                timer3.Start();
            }
            if (p2tradein2 == 1)
            {
                guide();
                turneddec2_2();
                timer1.Stop();
                turnsint = 1;
                timer3.Start();
            }

            if (p3tradein3 == 1)
            {
                guide();
                turneddec2_3();
                timer1.Stop();
                turnsint = 1;
                timer3.Start();
            }
            if (p4tradein4 == 1)
            {
                guide();
                turneddec2_4();
                timer1.Stop();
                turnsint = 1;
                timer3.Start();
            }
            if (p1notif.Text.StartsWith("Do you want to leave trading?"))
            {
                p1tr.Enabled = true;
                notif1.Visible = false;
                tip1.Visible = true;
                timer3.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (p1tradein1 == 1)
            {
                quick--;
                tmr1.Text = quick / 60 + ":" + ((quick % 60) >= 10 ? (quick % 60).ToString() : "0" + (quick % 60));
                if (quick == 0)
                {
                    timer1.Stop();
                    p2timer.Stop();
                    ruletrad.Stop();
                    timer3.Stop();
                    timesup.Play();
                    notif1.Visible = true;
                    p1notif.Text = "The trade has been cancelled.";
                    btnacc1.Visible = true;
                    pb1notif.Image = bankers_game_proto.Properties.Resources.Fav_CLOSED__;
                }

            }

            if (p2tradein2 == 1)
            {
                quick--;
                tmr1.Text = quick / 60 + ":" + ((quick % 60) >= 10 ? (quick % 60).ToString() : "0" + (quick % 60));
                if (quick == 0)
                {


                    timer1.Stop();
                    p2timer.Stop();
                    ruletrad.Stop();
                    timer3.Stop();
                    timer1.Stop();
                    timesup.Play();
                    notif1.Visible = true;
                    p1notif.Text = "The trade has been cancelled.";
                    btnacc1.Visible = true;
                    pb1notif.Image = bankers_game_proto.Properties.Resources.Fav_CLOSED__;
                }

            }
            if (p3tradein3 == 1)
            {
                quick--;
                tmr1.Text = quick / 60 + ":" + ((quick % 60) >= 10 ? (quick % 60).ToString() : "0" + (quick % 60));
                if (quick == 0)
                {
                    timer1.Stop();
                    p2timer.Stop();
                    ruletrad.Stop();
                    timer3.Stop();
                    timesup.Play();
                    notif1.Visible = true;
                    p1notif.Text = "The trade has been cancelled.";
                    btnacc1.Visible = true;
                    pb1notif.Image = bankers_game_proto.Properties.Resources.Fav_CLOSED__;
                }

            }

            if (p4tradein4 == 1)
            {
                quick--;
                tmr1.Text = quick / 60 + ":" + ((quick % 60) >= 10 ? (quick % 60).ToString() : "0" + (quick % 60));
                if (quick == 0)
                {

                    timer1.Stop();
                    p2timer.Stop();
                    ruletrad.Stop();
                    timer3.Stop();
                    timesup.Play();
                    notif1.Visible = true;
                    p1notif.Text = "The trade has been cancelled.";
                    btnacc1.Visible = true;
                    pb1notif.Image = bankers_game_proto.Properties.Resources.Fav_CLOSED__;
                }

            }
        }

        private void tip1_Click(object sender, EventArgs e)
        {
            click.Play();

            if (p1trad == 1)
            {
                tip1.Visible = false;
                notif1.Visible = true;
                p1notif.Text = "Click the player icon \r\nto the corner right side to show control-panel";
                pb1notif.Image = bankers_game_proto.Properties.Resources.p1_d;
                btnp1.Enabled = false;
                btnacc1.Visible = true;
            }
            if (p2trad == 1)
            {
                tip1.Visible = false;
                notif1.Visible = true;
                p1notif.Text = "Click the player icon \r\nto the corner right side to show control-panel";
                pb1notif.Image = bankers_game_proto.Properties.Resources.p2_d;
                btnp1.Enabled = false;
                btnacc1.Visible = true;
            }
            if (p3trad == 1)
            {
                tip1.Visible = false;
                notif1.Visible = true;
                p1notif.Text = "Click the player icon \r\nto the corner right side to show control-panel";
                pb1notif.Image = bankers_game_proto.Properties.Resources.p3_d;
                btnp1.Enabled = false;
                btnacc1.Visible = true;
            }
            if (p4trad == 1)
            {
                tip1.Visible = false;
                notif1.Visible = true;
                p1notif.Text = "Click the player icon \r\nto the corner right side to show control-panel";
                pb1notif.Image = bankers_game_proto.Properties.Resources.p4_d;
                btnp1.Enabled = false;
                btnacc1.Visible = true;
           }

            if (det == 1)
            {
                tip1.Visible = false;
                notif1.Visible = true;
                p1notif.Text = " To trade properties, select the following properties that you want to trade.\r\n  located at the 2 panels, above the player icons";
                pb1notif.Image = bankers_game_proto.Properties.Resources.trade;
                p1tr.Enabled = false;
                btnacc1.Visible = true;
            }
        }

        private void tip2_Click(object sender, EventArgs e)
        {
            click.Play();

    
            if (p1 == 1)
            {
                tip2.Visible = false;
                notif2.Visible = true;
                p2notif.Text = "Click the player icon \r\nto the corner right side to show control-panel";
                pb2notif.Image = bankers_game_proto.Properties.Resources.p1_t;
                btnp2.Enabled = false;
                btnacc2.Visible = true;
            }

            if (p2 == 1)
            {
                tip2.Visible = false;
                notif2.Visible = true;
                p2notif.Text = "Click the player icon \r\nto the corner right side to show control-panel";
                pb2notif.Image = bankers_game_proto.Properties.Resources.p2_t;
                btnp2.Enabled = false;
                btnacc2.Visible = true;
            }
            if (p3 == 1)
            {
                tip2.Visible = false;
                notif2.Visible = true;
                p2notif.Text = "Click the player icon \r\nto the corner right side to show control-panel";
                pb2notif.Image = bankers_game_proto.Properties.Resources.p3_t;
                btnp2.Enabled = false;
                btnacc2.Visible = true;
            }
            if (p4 == 1)
            {
                tip2.Visible = false;
                notif2.Visible = true;
                p2notif.Text = "Click the player icon \r\nto the corner right side to show control-panel";
                pb2notif.Image = bankers_game_proto.Properties.Resources.p4_t;
                btnp2.Enabled = false;
                btnacc2.Visible = true;
            }
            if (det == 2)
            {
                tip2.Visible = false;
                notif2.Visible = true;
                p2notif.Text = " To trade properties, select the following properties that you want to trade.\r\n  located at the 2 panels, above the player icons";
                pb2notif.Image = bankers_game_proto.Properties.Resources.trade_t;
                p2tr.Enabled = false;
                btnacc2.Visible = true;
            }

        }

        private void p2timer_Tick(object sender, EventArgs e)
        {
            if (p1 == 1)
            {
                quick2--;
                tmr2.Text = quick2 / 60 + ":" + ((quick2 % 60) >= 10 ? (quick2 % 60).ToString() : "0" + (quick2 % 60));
                if (quick == 0)
                {
                    timer1.Stop();
                    p2timer.Stop();
                    ruletrad.Stop();
                    timer3.Stop();
                    timesup.Play();
                    notif2.Visible = true;
                    p2notif.Text = "The trade has been cancelled.";
                    btnacc2.Visible = true;
                    pb2notif.Image = bankers_game_proto.Properties.Resources.Fav_CLOSED___t;
        
                }

            }

            if (p2 == 1)
            {
                quick2--;
                tmr2.Text = quick2 / 60 + ":" + ((quick2 % 60) >= 10 ? (quick2 % 60).ToString() : "0" + (quick2 % 60));
                if (quick2 == 0)
                {
                    timer1.Stop();
                    p2timer.Stop();
                    ruletrad.Stop();
                    timer3.Stop();
                    timesup.Play();
                    notif2.Visible = true;
                    p2notif.Text = "The trade has been cancelled.";
                    btnacc2.Visible = true;
                    pb2notif.Image = bankers_game_proto.Properties.Resources.Fav_CLOSED___t;
                }

            }
            if (p3 == 1)
            {
                quick2--;
                tmr2.Text = quick2 / 60 + ":" + ((quick2 % 60) >= 10 ? (quick2 % 60).ToString() : "0" + (quick2 % 60));
                if (quick2 == 0)
                {
                    timer1.Stop();
                    p2timer.Stop();
                    ruletrad.Stop();
                    timer3.Stop();
                    timesup.Play();
                    notif2.Visible = true;
                    p2notif.Text = "The trade has been cancelled.";
                    btnacc2.Visible = true;
                    pb2notif.Image = bankers_game_proto.Properties.Resources.Fav_CLOSED___t;
                }

            }

            if (p4 == 1)
            {
                quick2--;
                tmr2.Text = quick2 / 60 + ":" + ((quick2 % 60) >= 10 ? (quick2 % 60).ToString() : "0" + (quick2 % 60));
                if (quick == 0)
                {
                    timer1.Stop();
                    p2timer.Stop();
                    ruletrad.Stop();
                    timer3.Stop();
                    timesup.Play();
                    notif2.Visible = true;
                    p2notif.Text = "The trade has been cancelled.";
                    btnacc2.Visible = true;
                    pb2notif.Image = bankers_game_proto.Properties.Resources.Fav_CLOSED___t;
                }

            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            turned();
        }

        private void btnerase1_Click(object sender, EventArgs e)
        {
            decline.Play();
            det = 0;
            btnerase1.Visible = false;
            p1tr.Visible = false;
            pbdet1.Visible = false;
            btnp1.Visible = true;
            btnp1.Enabled = true;

            //det flags
            easternschooldet1 = 0;
            westernschooldet1 = 0;
            visayashighschooldet1 = 0;
            southernschooldet1 = 0;
            nationsschooldet1 = 0;
            westmarketdet1 = 0;
            nightmarketdet1 = 0;
            daymarketdet1 = 0;
            starmarketdet1 = 0;
            moonmarketdet1 = 0;
            megamarketdet1 = 0;
            visayashospitaldet1 = 0;
            hobertshospitaldet1 = 0;
            heartshospitaldet1 = 0;
            internshospitaldet1 = 0;
            nationalhealthhospitaldet1 = 0;
            veteranshospitaldet1 = 0;
            pearlmalldet1 = 0;
            megamalldet1 = 0;
            articmalldet1 = 0;
            heavenlymalldet1 = 0;
            shangrillamalldet1 = 0;
            utility1x1det1 = 0;
            utility1x2det1 = 0;
            transportation1x1det1 = 0;
            transportation1x2det1 = 0;
            transportation1x3det1 = 0;
            transportation1x4det1 = 0;

            pb1x1.Enabled = true;
            pb1x2.Enabled = true;
            pb1x3.Enabled = true;
            pb1x4.Enabled = true;
            pb1x5.Enabled = true;
            pb1x6.Enabled = true;
            pb1x7.Enabled = true;
            pb1x8.Enabled = true;
            pb1x9.Enabled = true;
            pb1x10.Enabled = true;
            pb1x11.Enabled = true;
            pb1x12.Enabled = true;
            pb1x13.Enabled = true;
            pb1x14.Enabled = true;
            pb1x15.Enabled = true;
            pb1x16.Enabled = true;
            pb1x17.Enabled = true;
            pb1x18.Enabled = true;
            pb1x19.Enabled = true;
            pb1x20.Enabled = true;
            pb1x21.Enabled = true;
            pb1x22.Enabled = true;
            pb1x23.Enabled = true;
            pb1x24.Enabled = true;
            pb1x25.Enabled = true;
            pb1x26.Enabled = true;
            pb1x27.Enabled = true;
            pb1x28.Enabled = true;

            p1lvw.Items.Clear();
            p2lvw.Items.Clear();

            easternschooltrd1 = 0;
            westernschooltrd1 = 0;
            visayashighschooltrd1 = 0;
            southernschooltrd1 = 0;
            nationsschooltrd1 = 0;
            westmarkettrd1 = 0;
            nightmarkettrd1 = 0;
            daymarkettrd1 = 0;
            starmarkettrd1 = 0;
            moonmarkettrd1 = 0;
            megamarkettrd1 = 0;
            visayashospitaltrd1 = 0;
            hobertshospitaltrd1 = 0;
            heartshospitaltrd1 = 0;
            internshospitaltrd1 = 0;
            nationalhealthhospitaltrd1 = 0;
            veteranshospitaltrd1 = 0;
            pearlmalltrd1 = 0;
            megamalltrd1 = 0;
            articmalltrd1 = 0;
            heavenlymalltrd1 = 0;
            shangrillamalltrd1 = 0;
            utility1x1trd1 = 0;
            utility1x2trd1 = 0;
            transportation1x1trd1 = 0;
            transportation1x2trd1 = 0;
            transportation1x3trd1 = 0;
            transportation1x4trd1 = 0;


            easternschooltrd2 = 0;
            westernschooltrd2 = 0;
            visayashighschooltrd2 = 0;
            southernschooltrd2 = 0;
            nationsschooltrd2 = 0;
            westmarkettrd2 = 0;
            nightmarkettrd2 = 0;
            daymarkettrd2 = 0;
            starmarkettrd2 = 0;
            moonmarkettrd2 = 0;
            megamarkettrd2 = 0;
            visayashospitaltrd2 = 0;
            hobertshospitaltrd2 = 0;
            heartshospitaltrd2 = 0;
            internshospitaltrd2 = 0;
            nationalhealthhospitaltrd2 = 0;
            veteranshospitaltrd2 = 0;
            pearlmalltrd2 = 0;
            megamalltrd2 = 0;
            articmalltrd2 = 0;
            heavenlymalltrd2 = 0;
            shangrillamalltrd2 = 0;
            utility2x1trd2 = 0;
            utility2x2trd2 = 0;
            transportation2x1trd2 = 0;
            transportation2x2trd2 = 0;
            transportation2x3trd2 = 0;
            transportation2x4trd2 = 0;
        }

        private void btnerase2_Click(object sender, EventArgs e)
        {
            decline.Play();
            det = 0;
            btnerase2.Visible = false;
            p2tr.Visible = false;
            pbdet2.Visible = false;
            btnp2.Visible = true;
            btnp2.Enabled = true;
            btntrad2.Visible = false;

            //det flags
            easternschooldet2 = 0;
            westernschooldet2 = 0;
            visayashighschooldet2 = 0;
            southernschooldet2 = 0;
            nationsschooldet2 = 0;
            westmarketdet2 = 0;
            nightmarketdet2 = 0;
            daymarketdet2 = 0;
            starmarketdet2 = 0;
            moonmarketdet2 = 0;
            megamarketdet2 = 0;
            visayashospitaldet2 = 0;
            hobertshospitaldet2 = 0;
            heartshospitaldet2 = 0;
            internshospitaldet2 = 0;
            nationalhealthhospitaldet2 = 0;
            veteranshospitaldet2 = 0;
            pearlmalldet2 = 0;
            megamalldet2 = 0;
            articmalldet2 = 0;
            heavenlymalldet2 = 0;
            shangrillamalldet2 = 0;
            utility2x1det2 = 0;
            utility2x2det2 = 0;
            transportation2x1det2 = 0;
            transportation2x2det2 = 0;
            transportation2x3det2 = 0;
            transportation2x4det2 = 0;

            pb2x1.Enabled = true;
            pb2x2.Enabled = true;
            pb2x3.Enabled = true;
            pb2x4.Enabled = true;
            pb2x5.Enabled = true;
            pb2x6.Enabled = true;
            pb2x7.Enabled = true;
            pb2x8.Enabled = true;
            pb2x9.Enabled = true;
            pb2x10.Enabled = true;
            pb2x11.Enabled = true;
            pb2x12.Enabled = true;
            pb2x13.Enabled = true;
            pb2x14.Enabled = true;
            pb2x15.Enabled = true;
            pb2x16.Enabled = true;
            pb2x17.Enabled = true;
            pb2x18.Enabled = true;
            pb2x19.Enabled = true;
            pb2x20.Enabled = true;
            pb2x21.Enabled = true;
            pb2x22.Enabled = true;
            pb2x23.Enabled = true;
            pb2x24.Enabled = true;
            pb2x25.Enabled = true;
            pb2x26.Enabled = true;
            pb2x27.Enabled = true;
            pb2x28.Enabled = true;

            p1lvw.Items.Clear();
            p2lvw.Items.Clear();

            easternschooltrd1 = 0;
            westernschooltrd1 = 0;
            visayashighschooltrd1 = 0;
            southernschooltrd1 = 0;
            nationsschooltrd1 = 0;
            westmarkettrd1 = 0;
            nightmarkettrd1 = 0;
            daymarkettrd1 = 0;
            starmarkettrd1 = 0;
            moonmarkettrd1 = 0;
            megamarkettrd1 = 0;
            visayashospitaltrd1 = 0;
            hobertshospitaltrd1 = 0;
            heartshospitaltrd1 = 0;
            internshospitaltrd1 = 0;
            nationalhealthhospitaltrd1 = 0;
            veteranshospitaltrd1 = 0;
            pearlmalltrd1 = 0;
            megamalltrd1 = 0;
            articmalltrd1 = 0;
            heavenlymalltrd1 = 0;
            shangrillamalltrd1 = 0;
            utility1x1trd1 = 0;
            utility1x2trd1 = 0;
            transportation1x1trd1 = 0;
            transportation1x2trd1 = 0;
            transportation1x3trd1 = 0;
            transportation1x4trd1 = 0;


            easternschooltrd2 = 0;
            westernschooltrd2 = 0;
            visayashighschooltrd2 = 0;
            southernschooltrd2 = 0;
            nationsschooltrd2 = 0;
            westmarkettrd2 = 0;
            nightmarkettrd2 = 0;
            daymarkettrd2 = 0;
            starmarkettrd2 = 0;
            moonmarkettrd2 = 0;
            megamarkettrd2 = 0;
            visayashospitaltrd2 = 0;
            hobertshospitaltrd2 = 0;
            heartshospitaltrd2 = 0;
            internshospitaltrd2 = 0;
            nationalhealthhospitaltrd2 = 0;
            veteranshospitaltrd2 = 0;
            pearlmalltrd2 = 0;
            megamalltrd2 = 0;
            articmalltrd2 = 0;
            heavenlymalltrd2 = 0;
            shangrillamalltrd2 = 0;
            utility2x1trd2 = 0;
            utility2x2trd2 = 0;
            transportation2x1trd2 = 0;
            transportation2x2trd2 = 0;
            transportation2x3trd2 = 0;
            transportation2x4trd2 = 0;
        }


    }
}
