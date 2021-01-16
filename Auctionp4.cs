using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;
namespace bankers_game_proto
{
    public partial class Auctionp4 : Form
    {
        #region Variable for Auction
        public static int p4aucch = 0;
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

        string input = string.Empty;
        string input2 = string.Empty;
        string input3 = string.Empty;
        string input4 = string.Empty;
        int minprice = 60;
        int turn = 0;
        int turn2 = 0;
        int turn3 = 0;
        int turn4 = 0;
        int p1auced = 0;
        int p2auced = 0;
        int p3auced = 0;
        int p4auced = 0;
        int p1quit1 = 0;
        int p1quit2 = 0;
        int p1quit3 = 0;
        int p1quit4 = 0;
        int quick = 0;
        int quick2 = 0;
        int quick3 = 0;
        int quick4 = 0;
        int mon = 0;
        int mon2 = 0;
        int mon3 = 0;
        int mon4 = 0;
        public static int hibid = 0;
        int bid = 0;
        int bid1 = 0;
        int bid2 = 0;
        int bid3 = 0;

        //auction flags
        public static int easternschoolaucd1 = 0;
        public static int westernschoolaucd1 = 0;
        public static int visayashighschoolaucd1 = 0;
        public static int southernschoolaucd1 = 0;
        public static int nationsschoolaucd1 = 0;
        public static int westmarketaucd1 = 0;
        public static int nightmarketaucd1 = 0;
        public static int daymarketaucd1 = 0;
        public static int starmarketaucd1 = 0;
        public static int moonmarketaucd1 = 0;
        public static int megamarketaucd1 = 0;
        public static int visayashospitalaucd1 = 0;
        public static int hobertshospitalaucd1 = 0;
        public static int heartshospitalaucd1 = 0;
        public static int internshospitalaucd1 = 0;
        public static int nationalhealthhospitalaucd1 = 0;
        public static int veteranshospitalaucd1 = 0;
        public static int pearlmallaucd1 = 0;
        public static int megamallaucd1 = 0;
        public static int articmallaucd1 = 0;
        public static int heavenlymallaucd1 = 0;
        public static int shangrillamallaucd1 = 0;
        public static int utility1x1aucd1 = 0;
        public static int utility1x2aucd1 = 0;
        public static int transportation1x1aucd1 = 0;
        public static int transportation1x2aucd1 = 0;
        public static int transportation1x3aucd1 = 0;
        public static int transportation1x4aucd1 = 0;


        public static int easternschoolaucd2 = 0;
        public static int westernschoolaucd2 = 0;
        public static int visayashighschoolaucd2 = 0;
        public static int southernschoolaucd2 = 0;
        public static int nationsschoolaucd2 = 0;
        public static int westmarketaucd2 = 0;
        public static int nightmarketaucd2 = 0;
        public static int daymarketaucd2 = 0;
        public static int starmarketaucd2 = 0;
        public static int moonmarketaucd2 = 0;
        public static int megamarketaucd2 = 0;
        public static int visayashospitalaucd2 = 0;
        public static int hobertshospitalaucd2 = 0;
        public static int heartshospitalaucd2 = 0;
        public static int internshospitalaucd2 = 0;
        public static int nationalhealthhospitalaucd2 = 0;
        public static int veteranshospitalaucd2 = 0;
        public static int pearlmallaucd2 = 0;
        public static int megamallaucd2 = 0;
        public static int articmallaucd2 = 0;
        public static int heavenlymallaucd2 = 0;
        public static int shangrillamallaucd2 = 0;
        public static int utility2x1aucd2 = 0;
        public static int utility2x2aucd2 = 0;
        public static int transportation2x1aucd2 = 0;
        public static int transportation2x2aucd2 = 0;
        public static int transportation2x3aucd2 = 0;
        public static int transportation2x4aucd2 = 0;

        public static int easternschoolaucd3 = 0;
        public static int westernschoolaucd3 = 0;
        public static int visayashighschoolaucd3 = 0;
        public static int southernschoolaucd3 = 0;
        public static int nationsschoolaucd3 = 0;
        public static int westmarketaucd3 = 0;
        public static int nightmarketaucd3 = 0;
        public static int daymarketaucd3 = 0;
        public static int starmarketaucd3 = 0;
        public static int moonmarketaucd3 = 0;
        public static int megamarketaucd3 = 0;
        public static int visayashospitalaucd3 = 0;
        public static int hobertshospitalaucd3 = 0;
        public static int heartshospitalaucd3 = 0;
        public static int internshospitalaucd3 = 0;
        public static int nationalhealthhospitalaucd3 = 0;
        public static int veteranshospitalaucd3 = 0;
        public static int pearlmallaucd3 = 0;
        public static int megamallaucd3 = 0;
        public static int articmallaucd3 = 0;
        public static int heavenlymallaucd3 = 0;
        public static int shangrillamallaucd3 = 0;
        public static int utility3x1aucd3 = 0;
        public static int utility3x2aucd3 = 0;
        public static int transportation3x1aucd3 = 0;
        public static int transportation3x2aucd3 = 0;
        public static int transportation3x3aucd3 = 0;
        public static int transportation3x4aucd3 = 0;

        public static int easternschoolaucd4 = 0;
        public static int westernschoolaucd4 = 0;
        public static int visayashighschoolaucd4 = 0;
        public static int southernschoolaucd4 = 0;
        public static int nationsschoolaucd4 = 0;
        public static int westmarketaucd4 = 0;
        public static int nightmarketaucd4 = 0;
        public static int daymarketaucd4 = 0;
        public static int starmarketaucd4 = 0;
        public static int moonmarketaucd4 = 0;
        public static int megamarketaucd4 = 0;
        public static int visayashospitalaucd4 = 0;
        public static int hobertshospitalaucd4 = 0;
        public static int heartshospitalaucd4 = 0;
        public static int internshospitalaucd4 = 0;
        public static int nationalhealthhospitalaucd4 = 0;
        public static int veteranshospitalaucd4 = 0;
        public static int pearlmallaucd4 = 0;
        public static int megamallaucd4 = 0;
        public static int articmallaucd4 = 0;
        public static int heavenlymallaucd4 = 0;
        public static int shangrillamallaucd4 = 0;
        public static int utility4x1aucd4 = 0;
        public static int utility4x2aucd4 = 0;
        public static int transportation4x1aucd4 = 0;
        public static int transportation4x2aucd4 = 0;
        public static int transportation4x3aucd4 = 0;
        public static int transportation4x4aucd4 = 0;

        //auction
        public static int easternschoolauc1 = 0;
        public static int westernschoolauc1 = 0;
        public static int visayashighschoolauc1 = 0;
        public static int southernschoolauc1 = 0;
        public static int nationsschoolauc1 = 0;
        public static int westmarketauc1 = 0;
        public static int nightmarketauc1 = 0;
        public static int daymarketauc1 = 0;
        public static int starmarketauc1 = 0;
        public static int moonmarketauc1 = 0;
        public static int megamarketauc1 = 0;
        public static int visayashospitalauc1 = 0;
        public static int hobertshospitalauc1 = 0;
        public static int heartshospitalauc1 = 0;
        public static int internshospitalauc1 = 0;
        public static int nationalhealthhospitalauc1 = 0;
        public static int veteranshospitalauc1 = 0;
        public static int pearlmallauc1 = 0;
        public static int megamallauc1 = 0;
        public static int articmallauc1 = 0;
        public static int heavenlymallauc1 = 0;
        public static int shangrillamallauc1 = 0;
        public static int utility1x1auc1 = 0;
        public static int utility1x2auc1 = 0;
        public static int transportation1x1auc1 = 0;
        public static int transportation1x2auc1 = 0;
        public static int transportation1x3auc1 = 0;
        public static int transportation1x4auc1 = 0;


        public static int easternschoolauc2 = 0;
        public static int westernschoolauc2 = 0;
        public static int visayashighschoolauc2 = 0;
        public static int southernschoolauc2 = 0;
        public static int nationsschoolauc2 = 0;
        public static int westmarketauc2 = 0;
        public static int nightmarketauc2 = 0;
        public static int daymarketauc2 = 0;
        public static int starmarketauc2 = 0;
        public static int moonmarketauc2 = 0;
        public static int megamarketauc2 = 0;
        public static int visayashospitalauc2 = 0;
        public static int hobertshospitalauc2 = 0;
        public static int heartshospitalauc2 = 0;
        public static int internshospitalauc2 = 0;
        public static int nationalhealthhospitalauc2 = 0;
        public static int veteranshospitalauc2 = 0;
        public static int pearlmallauc2 = 0;
        public static int megamallauc2 = 0;
        public static int articmallauc2 = 0;
        public static int heavenlymallauc2 = 0;
        public static int shangrillamallauc2 = 0;
        public static int utility2x1auc2 = 0;
        public static int utility2x2auc2 = 0;
        public static int transportation2x1auc2 = 0;
        public static int transportation2x2auc2 = 0;
        public static int transportation2x3auc2 = 0;
        public static int transportation2x4auc2 = 0;

        public static int easternschoolauc3 = 0;
        public static int westernschoolauc3 = 0;
        public static int visayashighschoolauc3 = 0;
        public static int southernschoolauc3 = 0;
        public static int nationsschoolauc3 = 0;
        public static int westmarketauc3 = 0;
        public static int nightmarketauc3 = 0;
        public static int daymarketauc3 = 0;
        public static int starmarketauc3 = 0;
        public static int moonmarketauc3 = 0;
        public static int megamarketauc3 = 0;
        public static int visayashospitalauc3 = 0;
        public static int hobertshospitalauc3 = 0;
        public static int heartshospitalauc3 = 0;
        public static int internshospitalauc3 = 0;
        public static int nationalhealthhospitalauc3 = 0;
        public static int veteranshospitalauc3 = 0;
        public static int pearlmallauc3 = 0;
        public static int megamallauc3 = 0;
        public static int articmallauc3 = 0;
        public static int heavenlymallauc3 = 0;
        public static int shangrillamallauc3 = 0;
        public static int utility3x1auc3 = 0;
        public static int utility3x2auc3 = 0;
        public static int transportation3x1auc3 = 0;
        public static int transportation3x2auc3 = 0;
        public static int transportation3x3auc3 = 0;
        public static int transportation3x4auc3 = 0;

        public static int easternschoolauc4 = 0;
        public static int westernschoolauc4 = 0;
        public static int visayashighschoolauc4 = 0;
        public static int southernschoolauc4 = 0;
        public static int nationsschoolauc4 = 0;
        public static int westmarketauc4 = 0;
        public static int nightmarketauc4 = 0;
        public static int daymarketauc4 = 0;
        public static int starmarketauc4 = 0;
        public static int moonmarketauc4 = 0;
        public static int megamarketauc4 = 0;
        public static int visayashospitalauc4 = 0;
        public static int hobertshospitalauc4 = 0;
        public static int heartshospitalauc4 = 0;
        public static int internshospitalauc4 = 0;
        public static int nationalhealthhospitalauc4 = 0;
        public static int veteranshospitalauc4 = 0;
        public static int pearlmallauc4 = 0;
        public static int megamallauc4 = 0;
        public static int articmallauc4 = 0;
        public static int heavenlymallauc4 = 0;
        public static int shangrillamallauc4 = 0;
        public static int utility4x1auc4 = 0;
        public static int utility4x2auc4 = 0;
        public static int transportation4x1auc4 = 0;
        public static int transportation4x2auc4 = 0;
        public static int transportation4x3auc4 = 0;
        public static int transportation4x4auc4 = 0;

        #endregion

        public Auctionp4()
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
            mon = p4_gameplay.mon;
            mon2 = p4_gameplay.mon2;
            mon3 = p4_gameplay.mon3;
            mon4 = p4_gameplay.mon4;
            p1quit1 = p4_gameplay.p1quit1;
            p1quit2 = p4_gameplay.p1quit2;
            p1quit3 = p4_gameplay.p1quit3;
            p1quit4 = p4_gameplay.p1quit4;
            quick = p4_gameplay.quick;
            quick2 = p4_gameplay.quick2;
            quick3 = p4_gameplay.quick3;
            quick4 = p4_gameplay.quick4;

            easternschoolauc1 = p4_gameplay.easternschoolauc1;
            westernschoolauc1 = p4_gameplay.westernschoolauc1;
            visayashighschoolauc1 = p4_gameplay.visayashighschoolauc1;
            southernschoolauc1 = p4_gameplay.southernschoolauc1;
            nationsschoolauc1 = p4_gameplay.nationsschoolauc1;
            westmarketauc1 = p4_gameplay.westmarketauc1;
            nightmarketauc1 = p4_gameplay.nightmarketauc1;
            daymarketauc1 = p4_gameplay.daymarketauc1;
            starmarketauc1 = p4_gameplay.starmarketauc1;
            moonmarketauc1 = p4_gameplay.moonmarketauc1;
            megamarketauc1 = p4_gameplay.megamarketauc1;
            visayashospitalauc1 = p4_gameplay.visayashospitalauc1;
            hobertshospitalauc1 = p4_gameplay.hobertshospitalauc1;
            heartshospitalauc1 = p4_gameplay.heartshospitalauc1;
            internshospitalauc1 = p4_gameplay.internshospitalauc1;
            nationalhealthhospitalauc1 = p4_gameplay.nationalhealthhospitalauc1;
            veteranshospitalauc1 = p4_gameplay.veteranshospitalauc1;
            pearlmallauc1 = p4_gameplay.pearlmallauc1;
            megamallauc1 = p4_gameplay.megamallauc1;
            articmallauc1 = p4_gameplay.articmallauc1;
            heavenlymallauc1 = p4_gameplay.heavenlymallauc1;
            shangrillamallauc1 = p4_gameplay.shangrillamallauc1;
            utility1x1auc1 = p4_gameplay.utility1x1auc1;
            utility1x2auc1 = p4_gameplay.utility1x2auc1;
            transportation1x1auc1 = p4_gameplay.transportation1x1auc1;
            transportation1x2auc1 = p4_gameplay.transportation1x2auc1;
            transportation1x3auc1 = p4_gameplay.transportation1x3auc1;
            transportation1x4auc1 = p4_gameplay.transportation1x4auc1;

            //p2
            easternschoolauc2 = p4_gameplay.easternschoolauc2;
            westernschoolauc2 = p4_gameplay.westernschoolauc2;
            visayashighschoolauc2 = p4_gameplay.visayashighschoolauc2;
            southernschoolauc2 = p4_gameplay.southernschoolauc2;
            nationsschoolauc2 = p4_gameplay.nationsschoolauc2;
            westmarketauc2 = p4_gameplay.westmarketauc2;
            nightmarketauc2 = p4_gameplay.nightmarketauc2;
            daymarketauc2 = p4_gameplay.daymarketauc2;
            starmarketauc2 = p4_gameplay.starmarketauc2;
            moonmarketauc2 = p4_gameplay.moonmarketauc2;
            megamarketauc2 = p4_gameplay.megamarketauc2;
            visayashospitalauc2 = p4_gameplay.visayashospitalauc2;
            hobertshospitalauc2 = p4_gameplay.hobertshospitalauc2;
            heartshospitalauc2 = p4_gameplay.heartshospitalauc2;
            internshospitalauc2 = p4_gameplay.internshospitalauc2;
            nationalhealthhospitalauc2 = p4_gameplay.nationalhealthhospitalauc2;
            veteranshospitalauc2 = p4_gameplay.veteranshospitalauc2;
            pearlmallauc2 = p4_gameplay.pearlmallauc2;
            megamallauc2 = p4_gameplay.megamallauc2;
            articmallauc2 = p4_gameplay.articmallauc2;
            heavenlymallauc2 = p4_gameplay.heavenlymallauc2;
            shangrillamallauc2 = p4_gameplay.shangrillamallauc2;
            utility2x1auc2 = p4_gameplay.utility2x1auc2;
            utility2x2auc2 = p4_gameplay.utility2x2auc2;
            transportation2x1auc2 = p4_gameplay.transportation2x1auc2;
            transportation2x2auc2 = p4_gameplay.transportation2x2auc2;
            transportation2x3auc2 = p4_gameplay.transportation2x3auc2;
            transportation2x4auc2 = p4_gameplay.transportation2x4auc2;

            easternschoolauc3 = p4_gameplay.easternschoolauc3;
            westernschoolauc3 = p4_gameplay.westernschoolauc3;
            visayashighschoolauc3 = p4_gameplay.visayashighschoolauc3;
            southernschoolauc3 = p4_gameplay.southernschoolauc3;
            nationsschoolauc3 = p4_gameplay.nationsschoolauc3;
            westmarketauc3 = p4_gameplay.westmarketauc3;
            nightmarketauc3 = p4_gameplay.nightmarketauc3;
            daymarketauc3 = p4_gameplay.daymarketauc3;
            starmarketauc3 = p4_gameplay.starmarketauc3;
            moonmarketauc3 = p4_gameplay.moonmarketauc3;
            megamarketauc3 = p4_gameplay.megamarketauc3;
            visayashospitalauc3 = p4_gameplay.visayashospitalauc3;
            hobertshospitalauc3 = p4_gameplay.hobertshospitalauc3;
            heartshospitalauc3 = p4_gameplay.heartshospitalauc3;
            internshospitalauc3 = p4_gameplay.internshospitalauc3;
            nationalhealthhospitalauc3 = p4_gameplay.nationalhealthhospitalauc3;
            veteranshospitalauc3 = p4_gameplay.veteranshospitalauc3;
            pearlmallauc3 = p4_gameplay.pearlmallauc3;
            megamallauc3 = p4_gameplay.megamallauc3;
            articmallauc3 = p4_gameplay.articmallauc3;
            heavenlymallauc3 = p4_gameplay.heavenlymallauc3;
            shangrillamallauc3 = p4_gameplay.shangrillamallauc3;
            utility3x1auc3 = p4_gameplay.utility3x1auc3;
            utility3x2auc3 = p4_gameplay.utility3x2auc3;
            transportation3x1auc3 = p4_gameplay.transportation3x1auc3;
            transportation3x2auc3 = p4_gameplay.transportation3x2auc3;
            transportation3x3auc3 = p4_gameplay.transportation3x3auc3;
            transportation3x4auc3 = p4_gameplay.transportation3x4auc3;

            easternschoolauc4 = p4_gameplay.easternschoolauc4;
            westernschoolauc4 = p4_gameplay.westernschoolauc4;
            visayashighschoolauc4 = p4_gameplay.visayashighschoolauc4;
            southernschoolauc4 = p4_gameplay.southernschoolauc4;
            nationsschoolauc4 = p4_gameplay.nationsschoolauc4;
            westmarketauc4 = p4_gameplay.westmarketauc4;
            nightmarketauc4 = p4_gameplay.nightmarketauc4;
            daymarketauc4 = p4_gameplay.daymarketauc4;
            starmarketauc4 = p4_gameplay.starmarketauc4;
            moonmarketauc4 = p4_gameplay.moonmarketauc4;
            megamarketauc4 = p4_gameplay.megamarketauc4;
            visayashospitalauc4 = p4_gameplay.visayashospitalauc4;
            hobertshospitalauc4 = p4_gameplay.hobertshospitalauc4;
            heartshospitalauc4 = p4_gameplay.heartshospitalauc4;
            internshospitalauc4 = p4_gameplay.internshospitalauc4;
            nationalhealthhospitalauc4 = p4_gameplay.nationalhealthhospitalauc4;
            veteranshospitalauc4 = p4_gameplay.veteranshospitalauc4;
            pearlmallauc4 = p4_gameplay.pearlmallauc4;
            megamallauc4 = p4_gameplay.megamallauc4;
            articmallauc4 = p4_gameplay.articmallauc4;
            heavenlymallauc4 = p4_gameplay.heavenlymallauc4;
            shangrillamallauc4 = p4_gameplay.shangrillamallauc4;
            utility4x1auc4 = p4_gameplay.utility4x1auc4;
            utility4x2auc4 = p4_gameplay.utility4x2auc4;
            transportation4x1auc4 = p4_gameplay.transportation4x1auc4;
            transportation4x2auc4 = p4_gameplay.transportation4x2auc4;
            transportation4x3auc4 = p4_gameplay.transportation4x3auc4;
            transportation4x4auc4 = p4_gameplay.transportation4x4auc4;

            easternschoolaucd1 = p4_gameplay.easternschoolaucd1;
            westernschoolaucd1 = p4_gameplay.westernschoolaucd1;
            visayashighschoolaucd1 = p4_gameplay.visayashighschoolaucd1;
            southernschoolaucd1 = p4_gameplay.southernschoolaucd1;
            nationsschoolaucd1 = p4_gameplay.nationsschoolaucd1;
            westmarketaucd1 = p4_gameplay.westmarketaucd1;
            nightmarketaucd1 = p4_gameplay.nightmarketaucd1;
            daymarketaucd1 = p4_gameplay.daymarketaucd1;
            starmarketaucd1 = p4_gameplay.starmarketaucd1;
            moonmarketaucd1 = p4_gameplay.moonmarketaucd1;
            megamarketaucd1 = p4_gameplay.megamarketaucd1;
            visayashospitalaucd1 = p4_gameplay.visayashospitalaucd1;
            hobertshospitalaucd1 = p4_gameplay.hobertshospitalaucd1;
            heartshospitalaucd1 = p4_gameplay.heartshospitalaucd1;
            internshospitalaucd1 = p4_gameplay.internshospitalaucd1;
            nationalhealthhospitalaucd1 = p4_gameplay.nationalhealthhospitalaucd1;
            veteranshospitalaucd1 = p4_gameplay.veteranshospitalaucd1;
            pearlmallaucd1 = p4_gameplay.pearlmallaucd1;
            megamallaucd1 = p4_gameplay.megamallaucd1;
            articmallaucd1 = p4_gameplay.articmallaucd1;
            heavenlymallaucd1 = p4_gameplay.heavenlymallaucd1;
            shangrillamallaucd1 = p4_gameplay.shangrillamallaucd1;
            utility1x1aucd1 = p4_gameplay.utility1x1aucd1;
            utility1x2aucd1 = p4_gameplay.utility1x2aucd1;
            transportation1x1aucd1 = p4_gameplay.transportation1x1aucd1;
            transportation1x2aucd1 = p4_gameplay.transportation1x2aucd1;
            transportation1x3aucd1 = p4_gameplay.transportation1x3aucd1;
            transportation1x4aucd1 = p4_gameplay.transportation1x4aucd1;

            //p2
            easternschoolaucd2 = p4_gameplay.easternschoolaucd2;
            westernschoolaucd2 = p4_gameplay.westernschoolaucd2;
            visayashighschoolaucd2 = p4_gameplay.visayashighschoolaucd2;
            southernschoolaucd2 = p4_gameplay.southernschoolaucd2;
            nationsschoolaucd2 = p4_gameplay.nationsschoolaucd2;
            westmarketaucd2 = p4_gameplay.westmarketaucd2;
            nightmarketaucd2 = p4_gameplay.nightmarketaucd2;
            daymarketaucd2 = p4_gameplay.daymarketaucd2;
            starmarketaucd2 = p4_gameplay.starmarketaucd2;
            moonmarketaucd2 = p4_gameplay.moonmarketaucd2;
            megamarketaucd2 = p4_gameplay.megamarketaucd2;
            visayashospitalaucd2 = p4_gameplay.visayashospitalaucd2;
            hobertshospitalaucd2 = p4_gameplay.hobertshospitalaucd2;
            heartshospitalaucd2 = p4_gameplay.heartshospitalaucd2;
            internshospitalaucd2 = p4_gameplay.internshospitalaucd2;
            nationalhealthhospitalaucd2 = p4_gameplay.nationalhealthhospitalaucd2;
            veteranshospitalaucd2 = p4_gameplay.veteranshospitalaucd2;
            pearlmallaucd2 = p4_gameplay.pearlmallaucd2;
            megamallaucd2 = p4_gameplay.megamallaucd2;
            articmallaucd2 = p4_gameplay.articmallaucd2;
            heavenlymallaucd2 = p4_gameplay.heavenlymallaucd2;
            shangrillamallaucd2 = p4_gameplay.shangrillamallaucd2;
            utility2x1aucd2 = p4_gameplay.utility2x1aucd2;
            utility2x2aucd2 = p4_gameplay.utility2x2aucd2;
            transportation2x1aucd2 = p4_gameplay.transportation2x1aucd2;
            transportation2x2aucd2 = p4_gameplay.transportation2x2aucd2;
            transportation2x3aucd2 = p4_gameplay.transportation2x3aucd2;
            transportation2x4aucd2 = p4_gameplay.transportation2x4aucd2;

            easternschoolaucd3 = p4_gameplay.easternschoolaucd3;
            westernschoolaucd3 = p4_gameplay.westernschoolaucd3;
            visayashighschoolaucd3 = p4_gameplay.visayashighschoolaucd3;
            southernschoolaucd3 = p4_gameplay.southernschoolaucd3;
            nationsschoolaucd3 = p4_gameplay.nationsschoolaucd3;
            westmarketaucd3 = p4_gameplay.westmarketaucd3;
            nightmarketaucd3 = p4_gameplay.nightmarketaucd3;
            daymarketaucd3 = p4_gameplay.daymarketaucd3;
            starmarketaucd3 = p4_gameplay.starmarketaucd3;
            moonmarketaucd3 = p4_gameplay.moonmarketaucd3;
            megamarketaucd3 = p4_gameplay.megamarketaucd3;
            visayashospitalaucd3 = p4_gameplay.visayashospitalaucd3;
            hobertshospitalaucd3 = p4_gameplay.hobertshospitalaucd3;
            heartshospitalaucd3 = p4_gameplay.heartshospitalaucd3;
            internshospitalaucd3 = p4_gameplay.internshospitalaucd3;
            nationalhealthhospitalaucd3 = p4_gameplay.nationalhealthhospitalaucd3;
            veteranshospitalaucd3 = p4_gameplay.veteranshospitalaucd3;
            pearlmallaucd3 = p4_gameplay.pearlmallaucd3;
            megamallaucd3 = p4_gameplay.megamallaucd3;
            articmallaucd3 = p4_gameplay.articmallaucd3;
            heavenlymallaucd3 = p4_gameplay.heavenlymallaucd3;
            shangrillamallaucd3 = p4_gameplay.shangrillamallaucd3;
            utility3x1aucd3 = p4_gameplay.utility3x1aucd3;
            utility3x2aucd3 = p4_gameplay.utility3x2aucd3;
            transportation3x1aucd3 = p4_gameplay.transportation3x1aucd3;
            transportation3x2aucd3 = p4_gameplay.transportation3x2aucd3;
            transportation3x3aucd3 = p4_gameplay.transportation3x3aucd3;
            transportation3x4aucd3 = p4_gameplay.transportation3x4aucd3;

            easternschoolaucd4 = p4_gameplay.easternschoolaucd4;
            westernschoolaucd4 = p4_gameplay.westernschoolaucd4;
            visayashighschoolaucd4 = p4_gameplay.visayashighschoolaucd4;
            southernschoolaucd4 = p4_gameplay.southernschoolaucd4;
            nationsschoolaucd4 = p4_gameplay.nationsschoolaucd4;
            westmarketaucd4 = p4_gameplay.westmarketaucd4;
            nightmarketaucd4 = p4_gameplay.nightmarketaucd4;
            daymarketaucd4 = p4_gameplay.daymarketaucd4;
            starmarketaucd4 = p4_gameplay.starmarketaucd4;
            moonmarketaucd4 = p4_gameplay.moonmarketaucd4;
            megamarketaucd4 = p4_gameplay.megamarketaucd4;
            visayashospitalaucd4 = p4_gameplay.visayashospitalaucd4;
            hobertshospitalaucd4 = p4_gameplay.hobertshospitalaucd4;
            heartshospitalaucd4 = p4_gameplay.heartshospitalaucd4;
            internshospitalaucd4 = p4_gameplay.internshospitalaucd4;
            nationalhealthhospitalaucd4 = p4_gameplay.nationalhealthhospitalaucd4;
            veteranshospitalaucd4 = p4_gameplay.veteranshospitalaucd4;
            pearlmallaucd4 = p4_gameplay.pearlmallaucd4;
            megamallaucd4 = p4_gameplay.megamallaucd4;
            articmallaucd4 = p4_gameplay.articmallaucd4;
            heavenlymallaucd4 = p4_gameplay.heavenlymallaucd4;
            shangrillamallaucd4 = p4_gameplay.shangrillamallaucd4;
            utility4x1aucd4 = p4_gameplay.utility4x1aucd4;
            utility4x2aucd4 = p4_gameplay.utility4x2aucd4;
            transportation4x1aucd4 = p4_gameplay.transportation4x1aucd4;
            transportation4x2aucd4 = p4_gameplay.transportation4x2aucd4;
            transportation4x3aucd4 = p4_gameplay.transportation4x3aucd4;
            transportation4x4aucd4 = p4_gameplay.transportation4x4aucd4;



        }

        private void Auctionp4_Load(object sender, EventArgs e)
        {
            icons();
            icons2();
            guide();
            p1auc.Visible = false;
            p2auc.Visible = false;
            p3auc.Visible = false;
            p4auc.Visible = false;
            colorturn();
            startingenable();
            disableplayer();
            #region paint
            btnp1.Paint += new PaintEventHandler(btnp1_Paint);
            btnp2.Paint += new PaintEventHandler(btnp2_Paint);
            btnp3.Paint += new PaintEventHandler(btnp3_Paint);
            btnp4.Paint += new PaintEventHandler(btnp4_Paint);
            p1auc.Paint += new PaintEventHandler(p1auc_Paint);
            p2auc.Paint += new PaintEventHandler(p2auc_Paint);
            p3auc.Paint += new PaintEventHandler(p3auc_Paint);
            p4auc.Paint += new PaintEventHandler(p4auc_Paint);
            notif1.Paint += new PaintEventHandler(notif1_Paint);
            notif2.Paint += new PaintEventHandler(notif2_Paint);
            notif3.Paint += new PaintEventHandler(notif3_Paint);
            notif4.Paint += new PaintEventHandler(notif4_Paint);
            #endregion
            hibid = 0;
            tmr1.Text = Settings.tmr1;
            tmr2.Text = Settings.tmr2;
            tmr3.Text = Settings.tmr3;
            tmr4.Text = Settings.tmr4;
            gavel.Play();
        }

        #region design
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

        void p4auc_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, p4auc.ClientRectangle,
SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        void p3auc_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, p3auc.ClientRectangle,
SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        void p2auc_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, p2auc.ClientRectangle,
 SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
 SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
 SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
 SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        void p1auc_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, p1auc.ClientRectangle,
           SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
           SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
           SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
           SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        void btnp4_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnp4.ClientRectangle,
  SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
  SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
  SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
  SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        void btnp3_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnp3.ClientRectangle,
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

        #endregion

        #region rules auct
        void disableplayer()
        {
            if (p1quit1 == 1)
            {
                btnp1.Enabled = false;
                btnp1.Visible = false;
                p1auc.Visible = false;
                p1bid.Visible = false;
            }
            if (p1quit2 == 1)
            {
                btnp2.Enabled = false;
                btnp2.Visible = false;
                p2auc.Visible = false;
                p2bid.Visible = false;
            }
            if (p1quit3 == 1)
            {
                btnp3.Enabled = false;
                btnp3.Visible = false;
                p3auc.Visible = false;
                p3bid.Visible = false;
            }
            if (p1quit4 == 1)
            {
                btnp4.Enabled = false;
                btnp4.Visible = false;
                p4auc.Visible = false;
                p4bid.Visible = false;
            }
        }
        void turns1()
        {

            if (p1quit1 == 0 && p1quit2 == 0 && p1quit3 == 0 && p1quit4 == 0)
            {
                btnp1.Enabled = false;
                btnp1.Visible = true;
                p1auc.Visible = false;

                btnp2.Enabled = true;
                turnss();

                guide();
            }

            if (p1quit1 == 0 && p1quit2 == 0 && p1quit3 == 1 && p1quit4 == 0)
            {
                btnp1.Enabled = false;
                btnp1.Visible = true;
                p1auc.Visible = false;

                btnp2.Enabled = true;
                turnss();

                guide();
            }
            if (p1quit1 == 0 && p1quit2 == 0 && p1quit3 == 0 && p1quit4 == 1)
            {
                btnp1.Enabled = false;
                btnp1.Visible = true;
                p1auc.Visible = false;

                btnp2.Enabled = true;
                turnss();

                guide();
            }

            if (p1quit1 == 0 && p1quit2 == 1 && p1quit3 == 0 && p1quit4 == 0)
            {
                btnp1.Enabled = false;
                btnp1.Visible = true;
                btnp2.Visible = false;
                btnp2.Enabled = false;
                p1auc.Visible = false;


                btnp3.Enabled = true;
                turnss();
                guide();
            }

            if (p1quit1 == 0 && p1quit2 == 1 && p1quit3 == 1 && p1quit4 == 0)
            {
                btnp1.Enabled = false;
                btnp1.Visible = true;
                btnp2.Visible = false;
                btnp2.Enabled = false;
                btnp3.Visible = false;
                btnp3.Enabled = false;
                p1auc.Visible = false;
                disableplayer();

                btnp4.Enabled = true;
                turnss();
                guide();
            }

            if (p1quit1 == 0 && p1quit2 == 1 && p1quit3 == 0 && p1quit4 == 1)
            {
                btnp1.Enabled = false;
                btnp1.Visible = true;
                btnp2.Visible = false;
                btnp2.Enabled = false;
                btnp4.Visible = false;
                btnp4.Enabled = false;
                p1auc.Visible = false;
                disableplayer();

                btnp3.Enabled = true;
                turnss();
                guide();
            }
            if (p1quit1 == 0 && p1quit2 == 0 && p1quit3 == 1 && p1quit4 == 1)
            {
                btnp1.Enabled = false;
                btnp1.Visible = true;
                btnp3.Visible = false;
                btnp3.Enabled = false;
                btnp4.Visible = false;
                btnp4.Enabled = false;
                p1auc.Visible = false;
                disableplayer();

                btnp2.Enabled = true;
                turnss();
                guide();
            }
            if (p1quit1 == 1 && p1quit2 == 0 && p1quit3 == 0 && p1quit4 == 0)
            {
                btnp1.Enabled = false;
                btnp1.Visible = false;
                p1auc.Visible = false;

                btnp2.Enabled = true;
                turnss();

                guide();
            }

            //quit p1

            if (p1quit1 == 1 && p1quit2 == 0 && p1quit3 == 0 && p1quit4 == 0)
            {
                btnp1.Enabled = false;
                btnp1.Visible = true;
                p1auc.Visible = false;

                btnp2.Enabled = true;
                turnss();

                guide();
            }

            if (p1quit1 == 1 && p1quit2 == 0 && p1quit3 == 1 && p1quit4 == 0)
            {
                btnp1.Enabled = false;
                btnp1.Visible = true;
                p1auc.Visible = false;

                btnp2.Enabled = true;
                turnss();

                guide();
            }
            if (p1quit1 == 1 && p1quit2 == 0 && p1quit3 == 0 && p1quit4 == 1)
            {
                btnp1.Enabled = false;
                btnp1.Visible = true;
                p1auc.Visible = false;

                btnp2.Enabled = true;
                turnss();

                guide();
            }

            if (p1quit1 == 1 && p1quit2 == 1 && p1quit3 == 0 && p1quit4 == 0)
            {
                btnp1.Enabled = false;
                btnp1.Visible = true;
                btnp2.Visible = false;
                btnp2.Enabled = false;
                p1auc.Visible = false;


                btnp3.Enabled = true;
                turnss();
                guide();
            }

            if (p1quit1 == 0 && p1quit2 == 1 && p1quit3 == 1 && p1quit4 == 0)
            {
                btnp1.Enabled = false;
                btnp1.Visible = true;
                btnp2.Visible = false;
                btnp2.Enabled = false;
                btnp3.Visible = false;
                btnp3.Enabled = false;
                p1auc.Visible = false;
                disableplayer();

                btnp4.Enabled = true;
                turnss();
                guide();
            }

            if (p1quit1 == 0 && p1quit2 == 1 && p1quit3 == 0 && p1quit4 == 1)
            {
                btnp1.Enabled = false;
                btnp1.Visible = true;
                btnp2.Visible = false;
                btnp2.Enabled = false;
                btnp4.Visible = false;
                btnp4.Enabled = false;
                p1auc.Visible = false;
                disableplayer();

                btnp3.Enabled = true;
                turnss();
                guide();
            }
            if (p1quit1 == 0 && p1quit2 == 0 && p1quit3 == 1 && p1quit4 == 1)
            {
                btnp1.Enabled = false;
                btnp1.Visible = true;
                btnp3.Visible = false;
                btnp3.Enabled = false;
                btnp4.Visible = false;
                btnp4.Enabled = false;
                p1auc.Visible = false;
                disableplayer();

                btnp2.Enabled = true;
                turnss();
                guide();
            }
            if (p1quit1 == 1 && p1quit2 == 0 && p1quit3 == 0 && p1quit4 == 0)
            {
                btnp1.Enabled = false;
                btnp1.Visible = false;
                p1auc.Visible = false;

                btnp2.Enabled = true;
                turnss();

                guide();
            }
        }
        void turns2()
        {

            if (p1quit1 == 0 && p1quit2 == 0 && p1quit3 == 0 && p1quit4 == 0)
            {
                btnp2.Enabled = false;
                btnp2.Visible = true;
                p2auc.Visible = false;

                btnp3.Enabled = true;
                turnss();

                guide();
            }
            if (p1quit1 == 1 && p1quit2 == 0 && p1quit3 == 0 && p1quit4 == 0)
            {
                btnp2.Enabled = false;
                btnp2.Visible = true;
                p2auc.Visible = false;

                btnp3.Enabled = true;
                turnss();

                guide();
            }
            if (p1quit1 == 0 && p1quit2 == 0 && p1quit3 == 0 && p1quit4 == 1)
            {
                btnp2.Enabled = false;
                btnp2.Visible = true;
                p2auc.Visible = false;

                btnp3.Enabled = true;
                turnss();

                guide();
            }



            if (p1quit1 == 0 && p1quit2 == 0 && p1quit3 == 1 && p1quit4 == 0)
            {
                btnp2.Visible = true;
                btnp2.Enabled = false;
                btnp3.Visible = false;
                btnp3.Enabled = false;
                p2auc.Visible = false;
                disableplayer();

                btnp4.Enabled = true;
                turnss();

                guide();
            }
            if (p1quit1 == 0 && p1quit2 == 0 && p1quit3 == 1 && p1quit4 == 1)
            {
                btnp2.Visible = true;
                btnp2.Enabled = false;
                btnp3.Visible = false;
                btnp3.Enabled = false;
                btnp4.Visible = false;
                btnp4.Enabled = false;
                p2auc.Visible = false;
                disableplayer();

                btnp1.Enabled = true;
                turnss();

                guide();
            }
            if (p1quit1 == 1 && p1quit2 == 0 && p1quit3 == 0 && p1quit4 == 1)
            {
                btnp2.Visible = true;
                btnp2.Enabled = false;
                btnp1.Visible = false;
                btnp1.Enabled = false;
                btnp4.Visible = false;
                btnp4.Enabled = false;
                p2auc.Visible = false;
                disableplayer();

                btnp3.Enabled = true;
                turnss();

                guide();
            }
            if (p1quit1 == 1 && p1quit2 == 0 && p1quit3 == 1 && p1quit4 == 0)
            {
                btnp2.Visible = true;
                btnp2.Enabled = false;
                btnp1.Visible = false;
                btnp1.Enabled = false;
                btnp3.Visible = false;
                btnp3.Enabled = false;
                p2auc.Visible = false;
                disableplayer();

                btnp4.Enabled = true;
                turnss();

                guide();
            }

            //quit p2
            if (p1quit1 == 0 && p1quit2 == 1 && p1quit3 == 0 && p1quit4 == 0)
            {
                btnp2.Enabled = false;
                btnp2.Visible = true;
                p2auc.Visible = false;

                btnp3.Enabled = true;
                turnss();

                guide();
            }
            if (p1quit1 == 1 && p1quit2 == 1 && p1quit3 == 0 && p1quit4 == 0)
            {
                btnp2.Enabled = false;
                btnp2.Visible = true;
                p2auc.Visible = false;

                btnp3.Enabled = true;
                turnss();

                guide();
            }
            if (p1quit1 == 0 && p1quit2 == 1 && p1quit3 == 0 && p1quit4 == 1)
            {
                btnp2.Enabled = false;
                btnp2.Visible = true;
                p2auc.Visible = false;

                btnp3.Enabled = true;
                turnss();

                guide();
            }



            if (p1quit1 == 0 && p1quit2 == 1 && p1quit3 == 1 && p1quit4 == 0)
            {
                btnp2.Visible = true;
                btnp2.Enabled = false;
                btnp3.Visible = false;
                btnp3.Enabled = false;
                p2auc.Visible = false;
                disableplayer();

                btnp4.Enabled = true;
                turnss();

                guide();
            }
            if (p1quit1 == 0 && p1quit2 == 0 && p1quit3 == 1 && p1quit4 == 1)
            {
                btnp2.Visible = true;
                btnp2.Enabled = false;
                btnp3.Visible = false;
                btnp3.Enabled = false;
                btnp4.Visible = false;
                btnp4.Enabled = false;
                p2auc.Visible = false;
                disableplayer();

                btnp1.Enabled = true;
                turnss();

                guide();
            }
            if (p1quit1 == 1 && p1quit2 == 0 && p1quit3 == 0 && p1quit4 == 1)
            {
                btnp2.Visible = true;
                btnp2.Enabled = false;
                btnp1.Visible = false;
                btnp1.Enabled = false;
                btnp4.Visible = false;
                btnp4.Enabled = false;
                p2auc.Visible = false;
                disableplayer();

                btnp3.Enabled = true;
                turnss();

                guide();
            }
            if (p1quit1 == 1 && p1quit2 == 0 && p1quit3 == 1 && p1quit4 == 0)
            {
                btnp2.Visible = true;
                btnp2.Enabled = false;
                btnp1.Visible = false;
                btnp1.Enabled = false;
                btnp3.Visible = false;
                btnp3.Enabled = false;
                p2auc.Visible = false;
                disableplayer();

                btnp4.Enabled = true;
                turnss();

                guide();
            }
        }
        void turns3()
        {


            if (p1quit1 == 0 && p1quit2 == 0 && p1quit3 == 0 && p1quit4 == 0)
            {
                btnp3.Enabled = false;
                btnp3.Visible = true;
                p3auc.Visible = false;

                btnp4.Enabled = true;
                turnss();

                guide();
            }

            if (p1quit1 == 0 && p1quit2 == 0 && p1quit3 == 1 && p1quit4 == 0)
            {
                btnp3.Enabled = false;
                btnp3.Visible = true;
                p3auc.Visible = false;

                btnp4.Enabled = true;
                turnss();

                guide();
            }

            if (p1quit1 == 1 && p1quit2 == 0 && p1quit3 == 0 && p1quit4 == 0)
            {
                btnp3.Enabled = false;
                btnp3.Visible = true;
                p3auc.Visible = false;

                btnp4.Enabled = true;
                turnss();

                guide();
            }
            if (p1quit1 == 0 && p1quit2 == 1 && p1quit3 == 0 && p1quit4 == 0)
            {
                btnp3.Enabled = false;
                btnp3.Visible = true;
                p3auc.Visible = false;

                btnp4.Enabled = true;
                turnss();

                guide();
            }


            if (p1quit1 == 0 && p1quit2 == 0 && p1quit3 == 0 && p1quit4 == 1)
            {
                btnp3.Enabled = false;
                btnp3.Visible = true;
                btnp4.Enabled = false;
                btnp4.Visible = false;
                p3auc.Visible = false;
                disableplayer();

                btnp1.Enabled = true;
                turnss();

                guide();
            }
            if (p1quit1 == 1 && p1quit2 == 0 && p1quit3 == 0 && p1quit4 == 1)
            {
                btnp3.Enabled = false;
                btnp3.Visible = true;
                btnp4.Enabled = false;
                btnp4.Visible = false;
                btnp1.Enabled = false;
                btnp1.Visible = false;
                p3auc.Visible = false;
                disableplayer();

                btnp2.Enabled = true;
                turnss();

                guide();
            }
            if (p1quit1 == 0 && p1quit2 == 1 && p1quit3 == 0 && p1quit4 == 1)
            {
                btnp3.Enabled = false;
                btnp3.Visible = true;
                btnp4.Enabled = false;
                btnp4.Visible = false;
                btnp2.Enabled = false;
                btnp2.Visible = false;
                p3auc.Visible = false;
                disableplayer();

                btnp1.Enabled = true;
                turnss();

                guide();
            }
            if (p1quit1 == 1 && p1quit2 == 1 && p1quit3 == 0 && p1quit4 == 0)
            {
                btnp3.Enabled = false;
                btnp3.Visible = true;
                btnp1.Enabled = false;
                btnp1.Visible = false;
                btnp2.Enabled = false;
                btnp2.Visible = false;
                p3auc.Visible = false;
                disableplayer();

                btnp4.Enabled = true;
                turnss();

                guide();
            }
            
            //quit p3

            if (p1quit1 == 0 && p1quit2 == 0 && p1quit3 == 1 && p1quit4 == 0)
            {
                btnp3.Enabled = false;
                btnp3.Visible = true;
                p3auc.Visible = false;

                btnp4.Enabled = true;
                turnss();

                guide();
            }

            if (p1quit1 == 0 && p1quit2 == 0 && p1quit3 == 1 && p1quit4 == 0)
            {
                btnp3.Enabled = false;
                btnp3.Visible = true;
                p3auc.Visible = false;

                btnp4.Enabled = true;
                turnss();

                guide();
            }

            if (p1quit1 == 1 && p1quit2 == 0 && p1quit3 == 1 && p1quit4 == 0)
            {
                btnp3.Enabled = false;
                btnp3.Visible = true;
                p3auc.Visible = false;

                btnp4.Enabled = true;
                turnss();

                guide();
            }
            if (p1quit1 == 0 && p1quit2 == 1 && p1quit3 == 1 && p1quit4 == 0)
            {
                btnp3.Enabled = false;
                btnp3.Visible = true;
                p3auc.Visible = false;

                btnp4.Enabled = true;
                turnss();

                guide();
            }


            if (p1quit1 == 0 && p1quit2 == 0 && p1quit3 == 1 && p1quit4 == 1)
            {
                btnp3.Enabled = false;
                btnp3.Visible = true;
                btnp4.Enabled = false;
                btnp4.Visible = false;
                p3auc.Visible = false;
                disableplayer();

                btnp1.Enabled = true;
                turnss();

                guide();
            }
            if (p1quit1 == 1 && p1quit2 == 0 && p1quit3 == 0 && p1quit4 == 1)
            {
                btnp3.Enabled = false;
                btnp3.Visible = true;
                btnp4.Enabled = false;
                btnp4.Visible = false;
                btnp1.Enabled = false;
                btnp1.Visible = false;
                p3auc.Visible = false;
                disableplayer();

                btnp2.Enabled = true;
                turnss();

                guide();
            }
            if (p1quit1 == 0 && p1quit2 == 1 && p1quit3 == 0 && p1quit4 == 1)
            {
                btnp3.Enabled = false;
                btnp3.Visible = true;
                btnp4.Enabled = false;
                btnp4.Visible = false;
                btnp2.Enabled = false;
                btnp2.Visible = false;
                p3auc.Visible = false;
                disableplayer();

                btnp1.Enabled = true;
                turnss();

                guide();
            }
            if (p1quit1 == 1 && p1quit2 == 1 && p1quit3 == 0 && p1quit4 == 0)
            {
                btnp3.Enabled = false;
                btnp3.Visible = true;
                btnp1.Enabled = false;
                btnp1.Visible = false;
                btnp2.Enabled = false;
                btnp2.Visible = false;
                p3auc.Visible = false;
                disableplayer();

                btnp4.Enabled = true;
                turnss();

                guide();
            }
        }
        void turns4()
        {

            if (p1quit1 == 0 && p1quit2 == 0 && p1quit3 == 0 && p1quit4 == 0)
            {
                btnp4.Enabled = false;
                btnp4.Visible = true;
                p4auc.Visible = false;

                btnp1.Enabled = true;
                turnss();

                guide();
            }

            if (p1quit1 == 0 && p1quit2 == 1 && p1quit3 == 0 && p1quit4 == 0)
            {
                btnp4.Enabled = false;
                btnp4.Visible = false;
                p4auc.Visible = false;

                btnp1.Enabled = true;
                turnss();

                guide();
            }
            if (p1quit1 == 0 && p1quit2 == 0 && p1quit3 == 1 && p1quit4 == 0)
            {
                btnp4.Enabled = false;
                btnp4.Visible = false;
                p4auc.Visible = false;

                btnp1.Enabled = true;
                turnss();

                guide();
            }
            if (p1quit1 == 0 && p1quit2 == 0 && p1quit3 == 1 && p1quit4 == 1)
            {
                btnp4.Enabled = false;
                btnp4.Visible = false;
                p4auc.Visible = false;

                btnp1.Enabled = true;
                turnss();

                guide();
            }


            if (p1quit1 == 1 && p1quit2 == 0 && p1quit3 == 0 && p1quit4 == 0)
            {
                btnp4.Visible = true;
                btnp4.Enabled = false;
                btnp1.Visible = false;
                btnp1.Enabled = false;
                p4auc.Visible = false;
                disableplayer();

                btnp2.Enabled = true;
                turnss();

                guide();
            }
            if (p1quit1 == 1 && p1quit2 == 0 && p1quit3 == 0 && p1quit4 == 1)
            {
                btnp4.Visible = true;
                btnp4.Enabled = false;
                btnp1.Visible = false;
                btnp1.Enabled = false;
                p4auc.Visible = false;
                disableplayer();

                btnp2.Enabled = true;
                turnss();

                guide();
            }
            if (p1quit1 == 1 && p1quit2 == 1 && p1quit3 == 0 && p1quit4 == 0)
            {
                btnp4.Visible = true;
                btnp4.Enabled = false;
                btnp1.Visible = false;
                btnp1.Enabled = false;
                btnp2.Visible = false;
                btnp2.Enabled = false;
                p4auc.Visible = false;
                disableplayer();

                btnp3.Enabled = true;
                turnss();

                guide();
            }
            if (p1quit1 == 0 && p1quit2 == 1 && p1quit3 == 1 && p1quit4 == 0)
            {
                btnp4.Visible = true;
                btnp4.Enabled = false;
                btnp3.Visible = false;
                btnp3.Enabled = false;
                btnp2.Visible = false;
                btnp2.Enabled = false;
                p4auc.Visible = false;
                disableplayer();

                btnp1.Enabled = true;
                turnss();

                guide();
            }
            if (p1quit1 == 1 && p1quit2 == 0 && p1quit3 == 1 && p1quit4 == 0)
            {
                btnp4.Visible = true;
                btnp4.Enabled = false;
                btnp3.Visible = false;
                btnp3.Enabled = false;
                btnp1.Visible = false;
                btnp1.Enabled = false;
                p4auc.Visible = false;
                disableplayer();

                btnp2.Enabled = true;
                turnss();

                guide();
            }
            if (p1quit1 == 1 && p1quit2 == 1 && p1quit3 == 0 && p1quit4 == 0)
            {
                btnp4.Visible = true;
                btnp4.Enabled = false;
                btnp1.Visible = false;
                btnp1.Enabled = false;
                btnp2.Visible = false;
                btnp2.Enabled = false;
                p4auc.Visible = false;
                disableplayer();

                btnp3.Enabled = true;
                turnss();

                guide();
            }

            //quit p4
            if (p1quit1 == 0 && p1quit2 == 0 && p1quit3 == 0 && p1quit4 == 1)
            {
                btnp4.Enabled = false;
                btnp4.Visible = true;
                p4auc.Visible = false;

                btnp1.Enabled = true;
                turnss();

                guide();
            }

            if (p1quit1 == 0 && p1quit2 == 1 && p1quit3 == 0 && p1quit4 == 1)
            {
                btnp4.Enabled = false;
                btnp4.Visible = false;
                p4auc.Visible = false;

                btnp1.Enabled = true;
                turnss();

                guide();
            }
            if (p1quit1 == 0 && p1quit2 == 0 && p1quit3 == 1 && p1quit4 == 1)
            {
                btnp4.Enabled = false;
                btnp4.Visible = false;
                p4auc.Visible = false;

                btnp1.Enabled = true;
                turnss();

                guide();
            }
            if (p1quit1 == 0 && p1quit2 == 0 && p1quit3 == 1 && p1quit4 == 1)
            {
                btnp4.Enabled = false;
                btnp4.Visible = false;
                p4auc.Visible = false;

                btnp1.Enabled = true;
                turnss();

                guide();
            }


            if (p1quit1 == 1 && p1quit2 == 0 && p1quit3 == 0 && p1quit4 == 1)
            {
                btnp4.Visible = true;
                btnp4.Enabled = false;
                btnp1.Visible = false;
                btnp1.Enabled = false;
                p4auc.Visible = false;
                disableplayer();

                btnp2.Enabled = true;
                turnss();

                guide();
            }
            if (p1quit1 == 1 && p1quit2 == 0 && p1quit3 == 0 && p1quit4 == 1)
            {
                btnp4.Visible = true;
                btnp4.Enabled = false;
                btnp1.Visible = false;
                btnp1.Enabled = false;
                p4auc.Visible = false;
                disableplayer();

                btnp2.Enabled = true;
                turnss();

                guide();
            }
            if (p1quit1 == 1 && p1quit2 == 1 && p1quit3 == 0 && p1quit4 == 0)
            {
                btnp4.Visible = true;
                btnp4.Enabled = false;
                btnp1.Visible = false;
                btnp1.Enabled = false;
                btnp2.Visible = false;
                btnp2.Enabled = false;
                p4auc.Visible = false;
                disableplayer();

                btnp3.Enabled = true;
                turnss();

                guide();
            }
            if (p1quit1 == 0 && p1quit2 == 1 && p1quit3 == 1 && p1quit4 == 0)
            {
                btnp4.Visible = true;
                btnp4.Enabled = false;
                btnp3.Visible = false;
                btnp3.Enabled = false;
                btnp2.Visible = false;
                btnp2.Enabled = false;
                p4auc.Visible = false;
                disableplayer();

                btnp1.Enabled = true;
                turnss();

                guide();
            }
            if (p1quit1 == 1 && p1quit2 == 0 && p1quit3 == 1 && p1quit4 == 0)
            {
                btnp4.Visible = true;
                btnp4.Enabled = false;
                btnp3.Visible = false;
                btnp3.Enabled = false;
                btnp1.Visible = false;
                btnp1.Enabled = false;
                p4auc.Visible = false;
                disableplayer();

                btnp2.Enabled = true;
                turnss();

                guide();
            }
            if (p1quit1 == 1 && p1quit2 == 1 && p1quit3 == 0 && p1quit4 == 0)
            {
                btnp4.Visible = true;
                btnp4.Enabled = false;
                btnp1.Visible = false;
                btnp1.Enabled = false;
                btnp2.Visible = false;
                btnp2.Enabled = false;
                p4auc.Visible = false;
                disableplayer();

                btnp3.Enabled = true;
                turnss();

                guide();
            }
        }
        void bidding1()
        {
            bool a = false;
            int bidder = 0;
            a = int.TryParse(p1txt.Text, out bidder);

            if (!a || bidder > mon || bidder < bid || bidder < hibid || bidder < minprice)
            {
                p1notif.Visible = true;

            }
            else
            {
                turns1();
                bid = bidder;
                auc1.Visible = false;
                turnss();
                tip1.Visible = false;
                p1timer.Stop();
                quick = p4_gameplay.quick;
                tmr1.Text = quick / 60 + ":" + ((quick % 60) >= 10 ? (quick % 60).ToString() : "0" + (quick % 60));
            }

            //compare
            if (bid > bid1)
            {
                p1bid.Text = "Highest Bid:" + bid.ToString();
                p2bid.Text = "Highest Bid:" + bid.ToString();
                p3bid.Text = "Highest Bid:" + bid.ToString();
                p4bid.Text = "Highest Bid:" + bid.ToString();
                hibid = bid;

            }

            if (bid > bid2)
            {
                p1bid.Text = "Highest Bid:" + bid.ToString();
                p2bid.Text = "Highest Bid:" + bid.ToString();
                p3bid.Text = "Highest Bid:" + bid.ToString();
                p4bid.Text = "Highest Bid:" + bid.ToString();
                hibid = bid;
            }
            if (bid > bid3)
            {
                p1bid.Text = "Highest Bid:" + bid.ToString();
                p2bid.Text = "Highest Bid:" + bid.ToString();
                p3bid.Text = "Highest Bid:" + bid.ToString();
                p4bid.Text = "Highest Bid:" + bid.ToString();
                hibid = bid;
            }


        }
        void bidding2()
        {
            bool a = false;
            int bidder1 = 0;
            a = int.TryParse(p2txt.Text, out bidder1);

            if (!a || bidder1 > mon2 || bidder1 < bid1 || bidder1 < hibid || bidder1 < minprice)
            {
                p2notif.Visible = true;

            }
            else
            {

                turns2();
                bid1 = bidder1;
                auc2.Visible = false;
                turnss();
                tip2.Visible = false;
                p2timer.Stop();
                quick2 = p4_gameplay.quick2;
                tmr2.Text = quick2 / 60 + ":" + ((quick2 % 60) >= 10 ? (quick2 % 60).ToString() : "0" + (quick2 % 60));
            }

            //compare
            if (bid1 > bid)
            {
                p1bid.Text = "Highest Bid:" + bid1.ToString();
                p2bid.Text = "Highest Bid:" + bid1.ToString();
                p3bid.Text = "Highest Bid:" + bid1.ToString();
                p4bid.Text = "Highest Bid:" + bid1.ToString();
                hibid = bid1;
            }
            if (bid1 > bid2)
            {
                p1bid.Text = "Highest Bid:" + bid1.ToString();
                p2bid.Text = "Highest Bid:" + bid1.ToString();
                p3bid.Text = "Highest Bid:" + bid1.ToString();
                p4bid.Text = "Highest Bid:" + bid1.ToString();
                hibid = bid1;
            }
            if (bid1 > bid3)
            {
                p1bid.Text = "Highest Bid:" + bid1.ToString();
                p2bid.Text = "Highest Bid:" + bid1.ToString();
                p3bid.Text = "Highest Bid:" + bid1.ToString();
                p4bid.Text = "Highest Bid:" + bid1.ToString();
                hibid = bid1;
            }
        }
        void bidding3()
        {
            bool a = false;
            int bidder2 = 0;
            a = int.TryParse(p3txt.Text, out bidder2);

            if (!a || bidder2 > mon3 || bidder2 < bid2 || bidder2 < hibid || bidder2 < minprice)
            {
                p3notif.Visible = true;

            }
            else
            {
                turns3();
                bid2 = bidder2;
                auc1.Visible = false;
                turnss();
                tip3.Visible = false;
                p3timer.Stop();
                quick3 = p4_gameplay.quick3;
                tmr3.Text = quick3 / 60 + ":" + ((quick3 % 60) >= 10 ? (quick3 % 60).ToString() : "0" + (quick3 % 60));
            }

            //compare
            if (bid2 > bid)
            {
                p1bid.Text = "Highest Bid:" + bid2.ToString();
                p2bid.Text = "Highest Bid:" + bid2.ToString();
                p3bid.Text = "Highest Bid:" + bid2.ToString();
                p4bid.Text = "Highest Bid:" + bid2.ToString();
                hibid = bid2;

            }

            if (bid2 > bid1)
            {
                p1bid.Text = "Highest Bid:" + bid2.ToString();
                p2bid.Text = "Highest Bid:" + bid2.ToString();
                p3bid.Text = "Highest Bid:" + bid2.ToString();
                p4bid.Text = "Highest Bid:" + bid2.ToString();
                hibid = bid2;

            }
            if (bid2 > bid3)
            {
                p1bid.Text = "Highest Bid:" + bid2.ToString();
                p2bid.Text = "Highest Bid:" + bid2.ToString();
                p3bid.Text = "Highest Bid:" + bid2.ToString();
                p4bid.Text = "Highest Bid:" + bid2.ToString();
                hibid = bid2;

            }


        }
        void bidding4()
        {
            bool a = false;
            int bidder3 = 0;
            a = int.TryParse(p4txt.Text, out bidder3);

            if (!a || bidder3 > mon4 || bidder3 < bid3 || bidder3 < hibid || bidder3 < minprice)
            {
                p4notif.Visible = true;

            }
            else
            {
                turns4();
                bid3 = bidder3;
                auc2.Visible = false;
                turnss();
                tip4.Visible = false;
                p4timer.Stop();
                quick4 = p4_gameplay.quick4;
                tmr4.Text = quick4 / 60 + ":" + ((quick4 % 60) >= 10 ? (quick4 % 60).ToString() : "0" + (quick4 % 60));
            }

            //compare
            if (bid3 > bid)
            {
                p1bid.Text = "Highest Bid:" + bid3.ToString();
                p2bid.Text = "Highest Bid:" + bid3.ToString();
                p3bid.Text = "Highest Bid:" + bid3.ToString();
                p4bid.Text = "Highest Bid:" + bid3.ToString();
                hibid = bid3;
            }

            if (bid3 > bid1)
            {
                p1bid.Text = "Highest Bid:" + bid3.ToString();
                p2bid.Text = "Highest Bid:" + bid3.ToString();
                p3bid.Text = "Highest Bid:" + bid3.ToString();
                p4bid.Text = "Highest Bid:" + bid3.ToString();
                hibid = bid3;
            }
            if (bid3 > bid2)
            {
                p1bid.Text = "Highest Bid:" + bid3.ToString();
                p2bid.Text = "Highest Bid:" + bid3.ToString();
                p3bid.Text = "Highest Bid:" + bid3.ToString();
                p4bid.Text = "Highest Bid:" + bid3.ToString();
                hibid = bid3;
            }


        }
        void auctioned1()
        {
            if (easternschoolauc1 == 0)
            {
                easternschoolauc1 = 1;

            }
            if (westernschoolauc1 == 0)
            {
                westernschoolauc1 = 1;

            }

            if (visayashighschoolauc1 == 0)
            {
                visayashighschoolauc1 = 1;

            }
            if (southernschoolauc1 == 0)
            {
                southernschoolauc1 = 1;

            }
            if (nationsschoolauc1 == 0)
            {
                nationsschoolauc1 = 1;

            }

            if (westmarketauc1 == 0)
            {
                westmarketauc1 = 1;

            }
            if (nightmarketauc1 == 0)
            {
                nightmarketauc1 = 1;


            }
            if (daymarketauc1 == 0)
            {
                daymarketauc1 = 1;

            }

            if (starmarketauc1 == 0)
            {
                starmarketauc1 = 1;

            }
            if (moonmarketauc1 == 0)
            {

                moonmarketauc1 = 1;

            }
            if (megamarketauc1 == 0)
            {
                megamarketauc1 = 1;

            }

            if (visayashospitalauc1 == 0)
            {
                visayashospitalauc1 = 1;

            }
            if (hobertshospitalauc1 == 0)
            {
                hobertshospitalauc1 = 1;


            }
            if (heartshospitalauc1 == 0)
            {
                heartshospitalauc1 = 1;

            }

            if (internshospitalauc1 == 0)
            {
                internshospitalauc1 = 1;

            }
            if (nationalhealthhospitalauc1 == 0)
            {
                nationalhealthhospitalauc1 = 1;

            }
            if (veteranshospitalauc1 == 0)
            {
                veteranshospitalauc1 = 1;

            }

            if (pearlmallauc1 == 0)
            {
                pearlmallauc1 = 1;

            }
            if (megamallauc1 == 0)
            {
                megamallauc1 = 1;

            }
            if (articmallauc1 == 0)
            {
                articmallauc1 = 1;

            }

            if (heavenlymallauc1 == 0)
            {
                heavenlymallauc1 = 1;

            }
            if (shangrillamallauc1 == 0)
            {
                shangrillamallauc1 = 1;

            }

            if (utility1x1auc1 == 0)
            {
                utility1x1auc1 = 1;

            }
            if (utility1x2auc1 == 0)
            {
                utility1x2auc1 = 1;

            }

            if (transportation1x1auc1 == 0)
            {
                transportation1x1auc1 = 1;

            }
            if (transportation1x2auc1 == 0)
            {
                transportation1x2auc1 = 1;

            }
            if (transportation1x3auc1 == 0)
            {
                transportation1x3auc1 = 1;

            }
            if (transportation1x4auc1 == 0)
            {
                transportation1x4auc1 = 1;

            }
        }
        void auctioned2()
        {
            if (easternschoolauc2 == 0)
            {
                easternschoolauc2 = 1;

            }
            if (westernschoolauc2 == 0)
            {
                westernschoolauc2 = 1;

            }

            if (visayashighschoolauc2 == 0)
            {
                visayashighschoolauc2 = 1;

            }
            if (southernschoolauc2 == 0)
            {
                southernschoolauc2 = 1;

            }
            if (nationsschoolauc2 == 0)
            {
                nationsschoolauc2 = 1;

            }

            if (westmarketauc2 == 0)
            {
                westmarketauc2 = 1;

            }
            if (nightmarketauc2 == 0)
            {
                nightmarketauc2 = 1;


            }
            if (daymarketauc2 == 0)
            {
                daymarketauc2 = 1;

            }

            if (starmarketauc2 == 0)
            {
                starmarketauc2 = 1;

            }
            if (moonmarketauc2 == 0)
            {

                moonmarketauc2 = 1;

            }
            if (megamarketauc2 == 0)
            {
                megamarketauc2 = 1;

            }

            if (visayashospitalauc2 == 0)
            {
                visayashospitalauc2 = 1;

            }
            if (hobertshospitalauc2 == 0)
            {
                hobertshospitalauc2 = 1;


            }
            if (heartshospitalauc2 == 0)
            {
                heartshospitalauc2 = 1;

            }

            if (internshospitalauc2 == 0)
            {
                internshospitalauc2 = 1;

            }
            if (nationalhealthhospitalauc2 == 0)
            {
                nationalhealthhospitalauc2 = 1;

            }
            if (veteranshospitalauc2 == 0)
            {
                veteranshospitalauc2 = 1;

            }

            if (pearlmallauc2 == 0)
            {
                pearlmallauc2 = 1;

            }
            if (megamallauc2 == 0)
            {
                megamallauc2 = 1;

            }
            if (articmallauc2 == 0)
            {
                articmallauc2 = 1;

            }

            if (heavenlymallauc2 == 0)
            {
                heavenlymallauc2 = 1;

            }
            if (shangrillamallauc2 == 0)
            {
                shangrillamallauc2 = 1;

            }

            if (utility2x1auc2 == 0)
            {
                utility2x1auc2 = 1;

            }
            if (utility2x2auc2 == 0)
            {
                utility2x2auc2 = 1;

            }

            if (transportation2x1auc2 == 0)
            {
                transportation2x1auc2 = 1;

            }
            if (transportation2x2auc2 == 0)
            {
                transportation2x2auc2 = 1;

            }
            if (transportation2x3auc2 == 0)
            {
                transportation2x3auc2 = 1;

            }
            if (transportation2x4auc2 == 0)
            {
                transportation2x4auc2 = 1;

            }


        }
        void auctioned3()
        {
            if (easternschoolauc3 == 0)
            {
                easternschoolauc3 = 1;

            }
            if (westernschoolauc3 == 0)
            {
                westernschoolauc3 = 1;

            }

            if (visayashighschoolauc3 == 0)
            {
                visayashighschoolauc3 = 1;

            }
            if (southernschoolauc3 == 0)
            {
                southernschoolauc3 = 1;

            }
            if (nationsschoolauc3 == 0)
            {
                nationsschoolauc3 = 1;

            }

            if (westmarketauc3 == 0)
            {
                westmarketauc3 = 1;

            }
            if (nightmarketauc3 == 0)
            {
                nightmarketauc3 = 1;


            }
            if (daymarketauc3 == 0)
            {
                daymarketauc3 = 1;

            }

            if (starmarketauc3 == 0)
            {
                starmarketauc3 = 1;

            }
            if (moonmarketauc3 == 0)
            {

                moonmarketauc3 = 1;

            }
            if (megamarketauc3 == 0)
            {
                megamarketauc3 = 1;

            }

            if (visayashospitalauc3 == 0)
            {
                visayashospitalauc3 = 1;

            }
            if (hobertshospitalauc3 == 0)
            {
                hobertshospitalauc3 = 1;


            }
            if (heartshospitalauc3 == 0)
            {
                heartshospitalauc3 = 1;

            }

            if (internshospitalauc3 == 0)
            {
                internshospitalauc3 = 1;

            }
            if (nationalhealthhospitalauc3 == 0)
            {
                nationalhealthhospitalauc3 = 1;

            }
            if (veteranshospitalauc3 == 0)
            {
                veteranshospitalauc3 = 1;

            }

            if (pearlmallauc3 == 0)
            {
                pearlmallauc3 = 1;

            }
            if (megamallauc3 == 0)
            {
                megamallauc3 = 1;

            }
            if (articmallauc3 == 0)
            {
                articmallauc3 = 1;

            }

            if (heavenlymallauc3 == 0)
            {
                heavenlymallauc3 = 1;

            }
            if (shangrillamallauc3 == 0)
            {
                shangrillamallauc3 = 1;

            }

            if (utility3x1auc3 == 0)
            {
                utility3x1auc3 = 1;

            }
            if (utility3x2auc3 == 0)
            {
                utility3x2auc3 = 1;

            }

            if (transportation3x1auc3 == 0)
            {
                transportation3x1auc3 = 1;

            }
            if (transportation3x2auc3 == 0)
            {
                transportation3x2auc3 = 1;

            }
            if (transportation3x3auc3 == 0)
            {
                transportation3x3auc3 = 1;

            }
            if (transportation3x4auc3 == 0)
            {
                transportation3x4auc3 = 1;

            }


        }
        void auctioned4()
        {
            if (easternschoolauc4 == 0)
            {
                easternschoolauc4 = 1;

            }
            if (westernschoolauc4 == 0)
            {
                westernschoolauc4 = 1;

            }

            if (visayashighschoolauc4 == 0)
            {
                visayashighschoolauc4 = 1;

            }
            if (southernschoolauc4 == 0)
            {
                southernschoolauc4 = 1;

            }
            if (nationsschoolauc4 == 0)
            {
                nationsschoolauc4 = 1;

            }

            if (westmarketauc4 == 0)
            {
                westmarketauc4 = 1;

            }
            if (nightmarketauc4 == 0)
            {
                nightmarketauc4 = 1;


            }
            if (daymarketauc4 == 0)
            {
                daymarketauc4 = 1;

            }

            if (starmarketauc4 == 0)
            {
                starmarketauc4 = 1;

            }
            if (moonmarketauc4 == 0)
            {

                moonmarketauc4 = 1;

            }
            if (megamarketauc4 == 0)
            {
                megamarketauc4 = 1;

            }

            if (visayashospitalauc4 == 0)
            {
                visayashospitalauc4 = 1;

            }
            if (hobertshospitalauc4 == 0)
            {
                hobertshospitalauc4 = 1;


            }
            if (heartshospitalauc4 == 0)
            {
                heartshospitalauc4 = 1;

            }

            if (internshospitalauc4 == 0)
            {
                internshospitalauc4 = 1;

            }
            if (nationalhealthhospitalauc4 == 0)
            {
                nationalhealthhospitalauc4 = 1;

            }
            if (veteranshospitalauc4 == 0)
            {
                veteranshospitalauc4 = 1;

            }

            if (pearlmallauc4 == 0)
            {
                pearlmallauc4 = 1;

            }
            if (megamallauc4 == 0)
            {
                megamallauc4 = 1;

            }
            if (articmallauc4 == 0)
            {
                articmallauc4 = 1;

            }

            if (heavenlymallauc4 == 0)
            {
                heavenlymallauc4 = 1;

            }
            if (shangrillamallauc4 == 0)
            {
                shangrillamallauc4 = 1;

            }

            if (utility4x1auc4 == 0)
            {
                utility4x1auc4 = 1;

            }
            if (utility4x2auc4 == 0)
            {
                utility4x2auc4 = 1;

            }

            if (transportation4x1auc4 == 0)
            {
                transportation4x1auc4 = 1;

            }
            if (transportation4x2auc4 == 0)
            {
                transportation4x2auc4 = 1;

            }
            if (transportation4x3auc4 == 0)
            {
                transportation4x3auc4 = 1;

            }
            if (transportation4x4auc4 == 0)
            {
                transportation4x4auc4 = 1;

            }


        }
        void aucs1()
        {
            if (easternschoolaucd1 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Eastern_School_Purple;

            }
            else if (westernschoolaucd1 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Western_school;
            }

            if (visayashighschoolaucd1 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Visayas_highschool;
            }
            else if (southernschoolaucd1 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Southern_highschool;

            }
            else if (nationsschoolaucd1 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Nation_s_highschool;
            }

            if (westmarketaucd1 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.West_Market;

            }
            else if (nightmarketaucd1 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Night_market;

            }
            else if (daymarketaucd1 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Day_market;

            }

            if (starmarketaucd1 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Star_market;
            }
            else if (moonmarketaucd1 == 1)
            {

                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Moon_market;

            }
            else if (megamarketaucd1 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Mega_market;

            }

            if (visayashospitalaucd1 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Visayas_hospital;

            }
            else if (hobertshospitalaucd1 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Hobert_s_hospital;

            }
            else if (heartshospitalaucd1 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Hearts_hospital;

            }

            if (internshospitalaucd1 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Intern_s_hospital;

            }
            else if (nationalhealthhospitalaucd1 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.National_healths_hospital;

            }
            else if (veteranshospitalaucd1 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.VETERANS_Hospital;

            }

            if (pearlmallaucd1 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Pearl_Mall;

            }
            else if (megamallaucd1 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Mega_mall;

            }
            else if (articmallaucd1 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Artic_mall;

            }

            if (heavenlymallaucd1 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Heavenly_mall;

            }
            else if (shangrillamallaucd1 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Shangrilla_Mall;
            }

            if (utility1x1aucd1 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Meralco;

            }
            else if (utility1x2aucd1 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Niagra_Fall;
            }

            if (transportation1x1aucd1 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Rosevelt_Station;

            }
            else if (transportation1x2aucd1 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Santolan_Station;

            }
            else if (transportation1x3aucd1 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Quezon_Station;
            }
            else if (transportation1x4aucd1 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Trinoma_Station;
            }
        }
        void aucs2()
        {
            if (easternschoolaucd2 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Eastern_School_Purple_l;

            }
            else if (westernschoolaucd2 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Western_school_l;
            }

            if (visayashighschoolaucd2 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Visayas_highschool_l;
            }
            else if (southernschoolaucd2 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Southern_highschool_l;

            }
            else if (nationsschoolaucd2 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Nation_s_highschool_l;
            }

            if (westmarketaucd2 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.West_market_l;

            }
            else if (nightmarketaucd2 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Night_market_l;

            }
            else if (daymarketaucd2 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Day_market_l;

            }

            if (starmarketaucd2 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Star_market_l;
            }
            else if (moonmarketaucd2 == 1)
            {

                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Moon_market_l;

            }
            else if (megamarketaucd2 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Mega_market_l;

            }

            if (visayashospitalaucd2 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Visayas_hospital_l;

            }
            else if (hobertshospitalaucd2 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Hobert_s_hospital_l;

            }
            else if (heartshospitalaucd2 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Hearts_hospital_l;

            }

            if (internshospitalaucd2 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Intern_s_hospital_l;

            }
            else if (nationalhealthhospitalaucd2 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.National_healths_hospital_l;

            }
            else if (veteranshospitalaucd2 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.VETERANS_Hospital_l;

            }

            if (pearlmallaucd2 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Pearl_Mall_l;

            }
            else if (megamallaucd2 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Mega_mall_l;

            }
            else if (articmallaucd2 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Artic_mall_l;

            }

            if (heavenlymallaucd2 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Heavenly_mall_l;

            }
            else if (shangrillamallaucd2 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Shangrilla_Mall_l;
            }

            if (utility2x1aucd2 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Meralco_l;

            }
            else if (utility2x2aucd2 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Niagra_Fall_l;
            }

            if (transportation2x1aucd2 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Rosevelt_Station_l;

            }
            else if (transportation2x2aucd2 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Santolan_Station_l;

            }
            else if (transportation2x3aucd2 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Quezon_Station_l;
            }
            else if (transportation2x4aucd2 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Trinoma_Station_l;
            }
        }
        void aucs3()
        {
            if (easternschoolaucd3 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Eastern_School_Purple_t;

            }
            else if (westernschoolaucd3 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Western_school_t;
            }

            if (visayashighschoolaucd3 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Visayas_highschool_t;
            }
            else if (southernschoolaucd3 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Southern_highschool_t;

            }
            else if (nationsschoolaucd3 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Nation_s_highschool_t;
            }

            if (westmarketaucd3 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.West_Market_t;

            }
            else if (nightmarketaucd3 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Night_market_t;

            }
            else if (daymarketaucd3 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Day_market_t;

            }

            if (starmarketaucd3 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Star_market_t;
            }
            else if (moonmarketaucd3 == 1)
            {

                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Moon_market_t;

            }
            else if (megamarketaucd3 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Mega_market_t;

            }

            if (visayashospitalaucd3 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Visayas_hospital_t;

            }
            else if (hobertshospitalaucd3 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Hobert_s_hospital_t;

            }
            else if (heartshospitalaucd3 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Hearts_hospital_t;

            }

            if (internshospitalaucd3 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Intern_s_hospital_t;

            }
            else if (nationalhealthhospitalaucd3 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.National_healths_hospital_t;

            }
            else if (veteranshospitalaucd3 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.VETERANS_Hospital_t;

            }

            if (pearlmallaucd3 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Pearl_Mall_t;

            }
            else if (megamallaucd3 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Mega_mall_t;

            }
            else if (articmallaucd3 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Artic_mall_t;

            }

            if (heavenlymallaucd3 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Heavenly_mall_t;

            }
            else if (shangrillamallaucd3 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Shangrilla_Mall_t;
            }

            if (utility3x1aucd3 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Meralco_t;

            }
            else if (utility3x2aucd3 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Niagra_Fall_t;
            }

            if (transportation3x1aucd3 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Rosevelt_Station_t;

            }
            else if (transportation3x2aucd3 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Santolan_Station_t;

            }
            else if (transportation3x3aucd3 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Quezon_Station_t;
            }
            else if (transportation3x4aucd3 == 1)
            {
                auc1.Visible = true;
                auc1.Image = bankers_game_proto.Properties.Resources.Trinoma_Station_t;
            }
        }
        void aucs4()
        {
            if (easternschoolaucd4 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Eastern_School_Purple_r;

            }
            else if (westernschoolaucd4 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Western_school_r;
            }

            if (visayashighschoolaucd4 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Visayas_highschool_r;
            }
            else if (southernschoolaucd4 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Southern_highschool_r;

            }
            else if (nationsschoolaucd4 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Nation_s_highschool_r;
            }

            if (westmarketaucd4 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.West_Market_r;

            }
            else if (nightmarketaucd4 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Night_market_r;

            }
            else if (daymarketaucd4 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Day_market_r;

            }

            if (starmarketaucd4 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Star_market_r;
            }
            else if (moonmarketaucd4 == 1)
            {

                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Moon_market_r;

            }
            else if (megamarketaucd4 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Mega_market_r;

            }

            if (visayashospitalaucd4 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Visayas_hospital_r;

            }
            else if (hobertshospitalaucd4 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Hobert_s_hospital_r;

            }
            else if (heartshospitalaucd4 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Hearts_hospital_r;

            }

            if (internshospitalaucd4 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Intern_s_hospital_r;

            }
            else if (nationalhealthhospitalaucd4 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.National_healths_hospital_r;

            }
            else if (veteranshospitalaucd4 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.VETERANS_Hospital_r;

            }

            if (pearlmallaucd4 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Pearl_Mall_r;

            }
            else if (megamallaucd4 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Mega_mall_r;

            }
            else if (articmallaucd4 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Artic_mall_r;

            }

            if (heavenlymallaucd4 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Heavenly_mall_r;

            }
            else if (shangrillamallaucd4 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Shangrilla_Mall_r;
            }

            if (utility4x1aucd4 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Meralco_r;

            }
            else if (utility4x2aucd4 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Niagra_Fall_r;
            }

            if (transportation4x1aucd4 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Rosevelt_Station_r;

            }
            else if (transportation4x2aucd4 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Santolan_Station_r;

            }
            else if (transportation4x3aucd4 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Quezon_Station_r;
            }
            else if (transportation4x4aucd4 == 1)
            {
                auc2.Visible = true;
                auc2.Image = bankers_game_proto.Properties.Resources.Trinoma_Station_r;
            }
        }
        void quit()
        {
            if (bid == 0 && bid1 == 0 && bid2 == 0 && bid3 == 0 && p1quit1 == 0 && p1quit2 == 1 && p1quit3 == 1 && p1quit4 == 1)
            {
                notif2.Visible = false;
                notif3.Visible = false;
                notif4.Visible = false;
                p4_gameplay.easternschoolaucd1 = 0;
                p4_gameplay.westernschoolaucd1 = 0;
                p4_gameplay.visayashighschoolaucd1 = 0;
                p4_gameplay.southernschoolaucd1 = 0;
                p4_gameplay.nationsschoolaucd1 = 0;
                p4_gameplay.westmarketaucd1 = 0;
                p4_gameplay.nightmarketaucd1 = 0;
                p4_gameplay.daymarketaucd1 = 0;
                p4_gameplay.starmarketaucd1 = 0;
                p4_gameplay.moonmarketaucd1 = 0;
                p4_gameplay.megamarketaucd1 = 0;
                p4_gameplay.visayashospitalaucd1 = 0;
                p4_gameplay.hobertshospitalaucd1 = 0;
                p4_gameplay.heartshospitalaucd1 = 0;
                p4_gameplay.internshospitalaucd1 = 0;
                p4_gameplay.nationalhealthhospitalaucd1 = 0;
                p4_gameplay.veteranshospitalaucd1 = 0;
                p4_gameplay.pearlmallaucd1 = 0;
                p4_gameplay.megamallaucd1 = 0;
                p4_gameplay.articmallaucd1 = 0;
                p4_gameplay.heavenlymallaucd1 = 0;
                p4_gameplay.shangrillamallaucd1 = 0;
                p4_gameplay.utility1x1aucd1 = 0;
                p4_gameplay.utility1x2aucd1 = 0;
                p4_gameplay.transportation1x1aucd1 = 0;
                p4_gameplay.transportation1x2aucd1 = 0;
                p4_gameplay.transportation1x3aucd1 = 0;
                p4_gameplay.transportation1x4aucd1 = 0;


                p4_gameplay.easternschoolaucd2 = 0;
                p4_gameplay.westernschoolaucd2 = 0;
                p4_gameplay.visayashighschoolaucd2 = 0;
                p4_gameplay.southernschoolaucd2 = 0;
                p4_gameplay.nationsschoolaucd2 = 0;
                p4_gameplay.westmarketaucd2 = 0;
                p4_gameplay.nightmarketaucd2 = 0;
                p4_gameplay.daymarketaucd2 = 0;
                p4_gameplay.starmarketaucd2 = 0;
                p4_gameplay.moonmarketaucd2 = 0;
                p4_gameplay.megamarketaucd2 = 0;
                p4_gameplay.visayashospitalaucd2 = 0;
                p4_gameplay.hobertshospitalaucd2 = 0;
                p4_gameplay.heartshospitalaucd2 = 0;
                p4_gameplay.internshospitalaucd2 = 0;
                p4_gameplay.nationalhealthhospitalaucd2 = 0;
                p4_gameplay.veteranshospitalaucd2 = 0;
                p4_gameplay.pearlmallaucd2 = 0;
                p4_gameplay.megamallaucd2 = 0;
                p4_gameplay.articmallaucd2 = 0;
                p4_gameplay.heavenlymallaucd2 = 0;
                p4_gameplay.shangrillamallaucd2 = 0;
                p4_gameplay.utility2x1aucd2 = 0;
                p4_gameplay.utility2x2aucd2 = 0;
                p4_gameplay.transportation2x1aucd2 = 0;
                p4_gameplay.transportation2x2aucd2 = 0;
                p4_gameplay.transportation2x3aucd2 = 0;
                p4_gameplay.transportation2x4aucd2 = 0;

                p4_gameplay.easternschoolaucd3 = 0;
                p4_gameplay.westernschoolaucd3 = 0;
                p4_gameplay.visayashighschoolaucd3 = 0;
                p4_gameplay.southernschoolaucd3 = 0;
                p4_gameplay.nationsschoolaucd3 = 0;
                p4_gameplay.westmarketaucd3 = 0;
                p4_gameplay.nightmarketaucd3 = 0;
                p4_gameplay.daymarketaucd3 = 0;
                p4_gameplay.starmarketaucd3 = 0;
                p4_gameplay.moonmarketaucd3 = 0;
                p4_gameplay.megamarketaucd3 = 0;
                p4_gameplay.visayashospitalaucd3 = 0;
                p4_gameplay.hobertshospitalaucd3 = 0;
                p4_gameplay.heartshospitalaucd3 = 0;
                p4_gameplay.internshospitalaucd3 = 0;
                p4_gameplay.nationalhealthhospitalaucd3 = 0;
                p4_gameplay.veteranshospitalaucd3 = 0;
                p4_gameplay.pearlmallaucd3 = 0;
                p4_gameplay.megamallaucd3 = 0;
                p4_gameplay.articmallaucd3 = 0;
                p4_gameplay.heavenlymallaucd3 = 0;
                p4_gameplay.shangrillamallaucd3 = 0;
                p4_gameplay.utility3x1aucd3 = 0;
                p4_gameplay.utility3x2aucd3 = 0;
                p4_gameplay.transportation3x1aucd3 = 0;
                p4_gameplay.transportation3x2aucd3 = 0;
                p4_gameplay.transportation3x3aucd3 = 0;
                p4_gameplay.transportation3x4aucd3 = 0;

                p4_gameplay.easternschoolaucd4 = 0;
                p4_gameplay.westernschoolaucd4 = 0;
                p4_gameplay.visayashighschoolaucd4 = 0;
                p4_gameplay.southernschoolaucd4 = 0;
                p4_gameplay.nationsschoolaucd4 = 0;
                p4_gameplay.westmarketaucd4 = 0;
                p4_gameplay.nightmarketaucd4 = 0;
                p4_gameplay.daymarketaucd4 = 0;
                p4_gameplay.starmarketaucd4 = 0;
                p4_gameplay.moonmarketaucd4 = 0;
                p4_gameplay.megamarketaucd4 = 0;
                p4_gameplay.visayashospitalaucd4 = 0;
                p4_gameplay.hobertshospitalaucd4 = 0;
                p4_gameplay.heartshospitalaucd4 = 0;
                p4_gameplay.internshospitalaucd4 = 0;
                p4_gameplay.nationalhealthhospitalaucd4 = 0;
                p4_gameplay.veteranshospitalaucd4 = 0;
                p4_gameplay.pearlmallaucd4 = 0;
                p4_gameplay.megamallaucd4 = 0;
                p4_gameplay.articmallaucd4 = 0;
                p4_gameplay.heavenlymallaucd4 = 0;
                p4_gameplay.shangrillamallaucd4 = 0;
                p4_gameplay.utility4x1aucd4 = 0;
                p4_gameplay.utility4x2aucd4 = 0;
                p4_gameplay.transportation4x1aucd4 = 0;
                p4_gameplay.transportation4x2aucd4 = 0;
                p4_gameplay.transportation4x3aucd4 = 0;
                p4_gameplay.transportation4x4aucd4 = 0;

                //auction
                p4_gameplay.easternschoolauc1 = 0;
                p4_gameplay.westernschoolauc1 = 0;
                p4_gameplay.visayashighschoolauc1 = 0;
                p4_gameplay.southernschoolauc1 = 0;
                p4_gameplay.nationsschoolauc1 = 0;
                p4_gameplay.westmarketauc1 = 0;
                p4_gameplay.nightmarketauc1 = 0;
                p4_gameplay.daymarketauc1 = 0;
                p4_gameplay.starmarketauc1 = 0;
                p4_gameplay.moonmarketauc1 = 0;
                p4_gameplay.megamarketauc1 = 0;
                p4_gameplay.visayashospitalauc1 = 0;
                p4_gameplay.hobertshospitalauc1 = 0;
                p4_gameplay.heartshospitalauc1 = 0;
                p4_gameplay.internshospitalauc1 = 0;
                p4_gameplay.nationalhealthhospitalauc1 = 0;
                p4_gameplay.veteranshospitalauc1 = 0;
                p4_gameplay.pearlmallauc1 = 0;
                p4_gameplay.megamallauc1 = 0;
                p4_gameplay.articmallauc1 = 0;
                p4_gameplay.heavenlymallauc1 = 0;
                p4_gameplay.shangrillamallauc1 = 0;
                p4_gameplay.utility1x1auc1 = 0;
                p4_gameplay.utility1x2auc1 = 0;
                p4_gameplay.transportation1x1auc1 = 0;
                p4_gameplay.transportation1x2auc1 = 0;
                p4_gameplay.transportation1x3auc1 = 0;
                p4_gameplay.transportation1x4auc1 = 0;


                p4_gameplay.easternschoolauc2 = 0;
                p4_gameplay.westernschoolauc2 = 0;
                p4_gameplay.visayashighschoolauc2 = 0;
                p4_gameplay.southernschoolauc2 = 0;
                p4_gameplay.nationsschoolauc2 = 0;
                p4_gameplay.westmarketauc2 = 0;
                p4_gameplay.nightmarketauc2 = 0;
                p4_gameplay.daymarketauc2 = 0;
                p4_gameplay.starmarketauc2 = 0;
                p4_gameplay.moonmarketauc2 = 0;
                p4_gameplay.megamarketauc2 = 0;
                p4_gameplay.visayashospitalauc2 = 0;
                p4_gameplay.hobertshospitalauc2 = 0;
                p4_gameplay.heartshospitalauc2 = 0;
                p4_gameplay.internshospitalauc2 = 0;
                p4_gameplay.nationalhealthhospitalauc2 = 0;
                p4_gameplay.veteranshospitalauc2 = 0;
                p4_gameplay.pearlmallauc2 = 0;
                p4_gameplay.megamallauc2 = 0;
                p4_gameplay.articmallauc2 = 0;
                p4_gameplay.heavenlymallauc2 = 0;
                p4_gameplay.shangrillamallauc2 = 0;
                p4_gameplay.utility2x1auc2 = 0;
                p4_gameplay.utility2x2auc2 = 0;
                p4_gameplay.transportation2x1auc2 = 0;
                p4_gameplay.transportation2x2auc2 = 0;
                p4_gameplay.transportation2x3auc2 = 0;
                p4_gameplay.transportation2x4auc2 = 0;

                p4_gameplay.easternschoolauc3 = 0;
                p4_gameplay.westernschoolauc3 = 0;
                p4_gameplay.visayashighschoolauc3 = 0;
                p4_gameplay.southernschoolauc3 = 0;
                p4_gameplay.nationsschoolauc3 = 0;
                p4_gameplay.westmarketauc3 = 0;
                p4_gameplay.nightmarketauc3 = 0;
                p4_gameplay.daymarketauc3 = 0;
                p4_gameplay.starmarketauc3 = 0;
                p4_gameplay.moonmarketauc3 = 0;
                p4_gameplay.megamarketauc3 = 0;
                p4_gameplay.visayashospitalauc3 = 0;
                p4_gameplay.hobertshospitalauc3 = 0;
                p4_gameplay.heartshospitalauc3 = 0;
                p4_gameplay.internshospitalauc3 = 0;
                p4_gameplay.nationalhealthhospitalauc3 = 0;
                p4_gameplay.veteranshospitalauc3 = 0;
                p4_gameplay.pearlmallauc3 = 0;
                p4_gameplay.megamallauc3 = 0;
                p4_gameplay.articmallauc3 = 0;
                p4_gameplay.heavenlymallauc3 = 0;
                p4_gameplay.shangrillamallauc3 = 0;
                p4_gameplay.utility3x1auc3 = 0;
                p4_gameplay.utility3x2auc3 = 0;
                p4_gameplay.transportation3x1auc3 = 0;
                p4_gameplay.transportation3x2auc3 = 0;
                p4_gameplay.transportation3x3auc3 = 0;
                p4_gameplay.transportation3x4auc3 = 0;

                p4_gameplay.easternschoolauc4 = 0;
                p4_gameplay.westernschoolauc4 = 0;
                p4_gameplay.visayashighschoolauc4 = 0;
                p4_gameplay.southernschoolauc4 = 0;
                p4_gameplay.nationsschoolauc4 = 0;
                p4_gameplay.westmarketauc4 = 0;
                p4_gameplay.nightmarketauc4 = 0;
                p4_gameplay.daymarketauc4 = 0;
                p4_gameplay.starmarketauc4 = 0;
                p4_gameplay.moonmarketauc4 = 0;
                p4_gameplay.megamarketauc4 = 0;
                p4_gameplay.visayashospitalauc4 = 0;
                p4_gameplay.hobertshospitalauc4 = 0;
                p4_gameplay.heartshospitalauc4 = 0;
                p4_gameplay.internshospitalauc4 = 0;
                p4_gameplay.nationalhealthhospitalauc4 = 0;
                p4_gameplay.veteranshospitalauc4 = 0;
                p4_gameplay.pearlmallauc4 = 0;
                p4_gameplay.megamallauc4 = 0;
                p4_gameplay.articmallauc4 = 0;
                p4_gameplay.heavenlymallauc4 = 0;
                p4_gameplay.shangrillamallauc4 = 0;
                p4_gameplay.utility4x1auc4 = 0;
                p4_gameplay.utility4x2auc4 = 0;
                p4_gameplay.transportation4x1auc4 = 0;
                p4_gameplay.transportation4x2auc4 = 0;
                p4_gameplay.transportation4x3auc4 = 0;
                p4_gameplay.transportation4x4auc4 = 0;

                pb1notif.Image = bankers_game_proto.Properties.Resources.Fav_CLOSED__;
                btnacc1.Visible = true;
                btndec1.Visible = false;
                p1aucnotif.Text = "The Auction has been cancelled";
                notif1.Visible = true;
            }
            if (bid == 0 && bid1 == 0 && bid2 == 0 && bid3 == 0 && p1quit1 == 1 && p1quit2 == 0 && p1quit3 == 1 && p1quit4 == 1)
            {
                notif1.Visible = false;
                notif3.Visible = false;
                notif4.Visible = false;
                p4_gameplay.easternschoolaucd1 = 0;
                p4_gameplay.westernschoolaucd1 = 0;
                p4_gameplay.visayashighschoolaucd1 = 0;
                p4_gameplay.southernschoolaucd1 = 0;
                p4_gameplay.nationsschoolaucd1 = 0;
                p4_gameplay.westmarketaucd1 = 0;
                p4_gameplay.nightmarketaucd1 = 0;
                p4_gameplay.daymarketaucd1 = 0;
                p4_gameplay.starmarketaucd1 = 0;
                p4_gameplay.moonmarketaucd1 = 0;
                p4_gameplay.megamarketaucd1 = 0;
                p4_gameplay.visayashospitalaucd1 = 0;
                p4_gameplay.hobertshospitalaucd1 = 0;
                p4_gameplay.heartshospitalaucd1 = 0;
                p4_gameplay.internshospitalaucd1 = 0;
                p4_gameplay.nationalhealthhospitalaucd1 = 0;
                p4_gameplay.veteranshospitalaucd1 = 0;
                p4_gameplay.pearlmallaucd1 = 0;
                p4_gameplay.megamallaucd1 = 0;
                p4_gameplay.articmallaucd1 = 0;
                p4_gameplay.heavenlymallaucd1 = 0;
                p4_gameplay.shangrillamallaucd1 = 0;
                p4_gameplay.utility1x1aucd1 = 0;
                p4_gameplay.utility1x2aucd1 = 0;
                p4_gameplay.transportation1x1aucd1 = 0;
                p4_gameplay.transportation1x2aucd1 = 0;
                p4_gameplay.transportation1x3aucd1 = 0;
                p4_gameplay.transportation1x4aucd1 = 0;


                p4_gameplay.easternschoolaucd2 = 0;
                p4_gameplay.westernschoolaucd2 = 0;
                p4_gameplay.visayashighschoolaucd2 = 0;
                p4_gameplay.southernschoolaucd2 = 0;
                p4_gameplay.nationsschoolaucd2 = 0;
                p4_gameplay.westmarketaucd2 = 0;
                p4_gameplay.nightmarketaucd2 = 0;
                p4_gameplay.daymarketaucd2 = 0;
                p4_gameplay.starmarketaucd2 = 0;
                p4_gameplay.moonmarketaucd2 = 0;
                p4_gameplay.megamarketaucd2 = 0;
                p4_gameplay.visayashospitalaucd2 = 0;
                p4_gameplay.hobertshospitalaucd2 = 0;
                p4_gameplay.heartshospitalaucd2 = 0;
                p4_gameplay.internshospitalaucd2 = 0;
                p4_gameplay.nationalhealthhospitalaucd2 = 0;
                p4_gameplay.veteranshospitalaucd2 = 0;
                p4_gameplay.pearlmallaucd2 = 0;
                p4_gameplay.megamallaucd2 = 0;
                p4_gameplay.articmallaucd2 = 0;
                p4_gameplay.heavenlymallaucd2 = 0;
                p4_gameplay.shangrillamallaucd2 = 0;
                p4_gameplay.utility2x1aucd2 = 0;
                p4_gameplay.utility2x2aucd2 = 0;
                p4_gameplay.transportation2x1aucd2 = 0;
                p4_gameplay.transportation2x2aucd2 = 0;
                p4_gameplay.transportation2x3aucd2 = 0;
                p4_gameplay.transportation2x4aucd2 = 0;

                p4_gameplay.easternschoolaucd3 = 0;
                p4_gameplay.westernschoolaucd3 = 0;
                p4_gameplay.visayashighschoolaucd3 = 0;
                p4_gameplay.southernschoolaucd3 = 0;
                p4_gameplay.nationsschoolaucd3 = 0;
                p4_gameplay.westmarketaucd3 = 0;
                p4_gameplay.nightmarketaucd3 = 0;
                p4_gameplay.daymarketaucd3 = 0;
                p4_gameplay.starmarketaucd3 = 0;
                p4_gameplay.moonmarketaucd3 = 0;
                p4_gameplay.megamarketaucd3 = 0;
                p4_gameplay.visayashospitalaucd3 = 0;
                p4_gameplay.hobertshospitalaucd3 = 0;
                p4_gameplay.heartshospitalaucd3 = 0;
                p4_gameplay.internshospitalaucd3 = 0;
                p4_gameplay.nationalhealthhospitalaucd3 = 0;
                p4_gameplay.veteranshospitalaucd3 = 0;
                p4_gameplay.pearlmallaucd3 = 0;
                p4_gameplay.megamallaucd3 = 0;
                p4_gameplay.articmallaucd3 = 0;
                p4_gameplay.heavenlymallaucd3 = 0;
                p4_gameplay.shangrillamallaucd3 = 0;
                p4_gameplay.utility3x1aucd3 = 0;
                p4_gameplay.utility3x2aucd3 = 0;
                p4_gameplay.transportation3x1aucd3 = 0;
                p4_gameplay.transportation3x2aucd3 = 0;
                p4_gameplay.transportation3x3aucd3 = 0;
                p4_gameplay.transportation3x4aucd3 = 0;

                p4_gameplay.easternschoolaucd4 = 0;
                p4_gameplay.westernschoolaucd4 = 0;
                p4_gameplay.visayashighschoolaucd4 = 0;
                p4_gameplay.southernschoolaucd4 = 0;
                p4_gameplay.nationsschoolaucd4 = 0;
                p4_gameplay.westmarketaucd4 = 0;
                p4_gameplay.nightmarketaucd4 = 0;
                p4_gameplay.daymarketaucd4 = 0;
                p4_gameplay.starmarketaucd4 = 0;
                p4_gameplay.moonmarketaucd4 = 0;
                p4_gameplay.megamarketaucd4 = 0;
                p4_gameplay.visayashospitalaucd4 = 0;
                p4_gameplay.hobertshospitalaucd4 = 0;
                p4_gameplay.heartshospitalaucd4 = 0;
                p4_gameplay.internshospitalaucd4 = 0;
                p4_gameplay.nationalhealthhospitalaucd4 = 0;
                p4_gameplay.veteranshospitalaucd4 = 0;
                p4_gameplay.pearlmallaucd4 = 0;
                p4_gameplay.megamallaucd4 = 0;
                p4_gameplay.articmallaucd4 = 0;
                p4_gameplay.heavenlymallaucd4 = 0;
                p4_gameplay.shangrillamallaucd4 = 0;
                p4_gameplay.utility4x1aucd4 = 0;
                p4_gameplay.utility4x2aucd4 = 0;
                p4_gameplay.transportation4x1aucd4 = 0;
                p4_gameplay.transportation4x2aucd4 = 0;
                p4_gameplay.transportation4x3aucd4 = 0;
                p4_gameplay.transportation4x4aucd4 = 0;

                //auction
                p4_gameplay.easternschoolauc1 = 0;
                p4_gameplay.westernschoolauc1 = 0;
                p4_gameplay.visayashighschoolauc1 = 0;
                p4_gameplay.southernschoolauc1 = 0;
                p4_gameplay.nationsschoolauc1 = 0;
                p4_gameplay.westmarketauc1 = 0;
                p4_gameplay.nightmarketauc1 = 0;
                p4_gameplay.daymarketauc1 = 0;
                p4_gameplay.starmarketauc1 = 0;
                p4_gameplay.moonmarketauc1 = 0;
                p4_gameplay.megamarketauc1 = 0;
                p4_gameplay.visayashospitalauc1 = 0;
                p4_gameplay.hobertshospitalauc1 = 0;
                p4_gameplay.heartshospitalauc1 = 0;
                p4_gameplay.internshospitalauc1 = 0;
                p4_gameplay.nationalhealthhospitalauc1 = 0;
                p4_gameplay.veteranshospitalauc1 = 0;
                p4_gameplay.pearlmallauc1 = 0;
                p4_gameplay.megamallauc1 = 0;
                p4_gameplay.articmallauc1 = 0;
                p4_gameplay.heavenlymallauc1 = 0;
                p4_gameplay.shangrillamallauc1 = 0;
                p4_gameplay.utility1x1auc1 = 0;
                p4_gameplay.utility1x2auc1 = 0;
                p4_gameplay.transportation1x1auc1 = 0;
                p4_gameplay.transportation1x2auc1 = 0;
                p4_gameplay.transportation1x3auc1 = 0;
                p4_gameplay.transportation1x4auc1 = 0;


                p4_gameplay.easternschoolauc2 = 0;
                p4_gameplay.westernschoolauc2 = 0;
                p4_gameplay.visayashighschoolauc2 = 0;
                p4_gameplay.southernschoolauc2 = 0;
                p4_gameplay.nationsschoolauc2 = 0;
                p4_gameplay.westmarketauc2 = 0;
                p4_gameplay.nightmarketauc2 = 0;
                p4_gameplay.daymarketauc2 = 0;
                p4_gameplay.starmarketauc2 = 0;
                p4_gameplay.moonmarketauc2 = 0;
                p4_gameplay.megamarketauc2 = 0;
                p4_gameplay.visayashospitalauc2 = 0;
                p4_gameplay.hobertshospitalauc2 = 0;
                p4_gameplay.heartshospitalauc2 = 0;
                p4_gameplay.internshospitalauc2 = 0;
                p4_gameplay.nationalhealthhospitalauc2 = 0;
                p4_gameplay.veteranshospitalauc2 = 0;
                p4_gameplay.pearlmallauc2 = 0;
                p4_gameplay.megamallauc2 = 0;
                p4_gameplay.articmallauc2 = 0;
                p4_gameplay.heavenlymallauc2 = 0;
                p4_gameplay.shangrillamallauc2 = 0;
                p4_gameplay.utility2x1auc2 = 0;
                p4_gameplay.utility2x2auc2 = 0;
                p4_gameplay.transportation2x1auc2 = 0;
                p4_gameplay.transportation2x2auc2 = 0;
                p4_gameplay.transportation2x3auc2 = 0;
                p4_gameplay.transportation2x4auc2 = 0;

                p4_gameplay.easternschoolauc3 = 0;
                p4_gameplay.westernschoolauc3 = 0;
                p4_gameplay.visayashighschoolauc3 = 0;
                p4_gameplay.southernschoolauc3 = 0;
                p4_gameplay.nationsschoolauc3 = 0;
                p4_gameplay.westmarketauc3 = 0;
                p4_gameplay.nightmarketauc3 = 0;
                p4_gameplay.daymarketauc3 = 0;
                p4_gameplay.starmarketauc3 = 0;
                p4_gameplay.moonmarketauc3 = 0;
                p4_gameplay.megamarketauc3 = 0;
                p4_gameplay.visayashospitalauc3 = 0;
                p4_gameplay.hobertshospitalauc3 = 0;
                p4_gameplay.heartshospitalauc3 = 0;
                p4_gameplay.internshospitalauc3 = 0;
                p4_gameplay.nationalhealthhospitalauc3 = 0;
                p4_gameplay.veteranshospitalauc3 = 0;
                p4_gameplay.pearlmallauc3 = 0;
                p4_gameplay.megamallauc3 = 0;
                p4_gameplay.articmallauc3 = 0;
                p4_gameplay.heavenlymallauc3 = 0;
                p4_gameplay.shangrillamallauc3 = 0;
                p4_gameplay.utility3x1auc3 = 0;
                p4_gameplay.utility3x2auc3 = 0;
                p4_gameplay.transportation3x1auc3 = 0;
                p4_gameplay.transportation3x2auc3 = 0;
                p4_gameplay.transportation3x3auc3 = 0;
                p4_gameplay.transportation3x4auc3 = 0;

                p4_gameplay.easternschoolauc4 = 0;
                p4_gameplay.westernschoolauc4 = 0;
                p4_gameplay.visayashighschoolauc4 = 0;
                p4_gameplay.southernschoolauc4 = 0;
                p4_gameplay.nationsschoolauc4 = 0;
                p4_gameplay.westmarketauc4 = 0;
                p4_gameplay.nightmarketauc4 = 0;
                p4_gameplay.daymarketauc4 = 0;
                p4_gameplay.starmarketauc4 = 0;
                p4_gameplay.moonmarketauc4 = 0;
                p4_gameplay.megamarketauc4 = 0;
                p4_gameplay.visayashospitalauc4 = 0;
                p4_gameplay.hobertshospitalauc4 = 0;
                p4_gameplay.heartshospitalauc4 = 0;
                p4_gameplay.internshospitalauc4 = 0;
                p4_gameplay.nationalhealthhospitalauc4 = 0;
                p4_gameplay.veteranshospitalauc4 = 0;
                p4_gameplay.pearlmallauc4 = 0;
                p4_gameplay.megamallauc4 = 0;
                p4_gameplay.articmallauc4 = 0;
                p4_gameplay.heavenlymallauc4 = 0;
                p4_gameplay.shangrillamallauc4 = 0;
                p4_gameplay.utility4x1auc4 = 0;
                p4_gameplay.utility4x2auc4 = 0;
                p4_gameplay.transportation4x1auc4 = 0;
                p4_gameplay.transportation4x2auc4 = 0;
                p4_gameplay.transportation4x3auc4 = 0;
                p4_gameplay.transportation4x4auc4 = 0;
                pb2notif.Image = bankers_game_proto.Properties.Resources.Fav_CLOSED___l;
                btnacc2.Visible = true;
                btndec2.Visible = false;
                p2aucnotif.Text = "The Auction has been cancelled";
                notif2.Visible = true;
            }
            if (bid == 0 && bid1 == 0 && bid2 == 0 && bid3 == 0 && p1quit1 == 1 && p1quit2 == 1 && p1quit3 == 0 && p1quit4 == 1)
            {
                notif2.Visible = false;
                notif1.Visible = false;
                notif4.Visible = false;
                p4_gameplay.easternschoolaucd1 = 0;
                p4_gameplay.westernschoolaucd1 = 0;
                p4_gameplay.visayashighschoolaucd1 = 0;
                p4_gameplay.southernschoolaucd1 = 0;
                p4_gameplay.nationsschoolaucd1 = 0;
                p4_gameplay.westmarketaucd1 = 0;
                p4_gameplay.nightmarketaucd1 = 0;
                p4_gameplay.daymarketaucd1 = 0;
                p4_gameplay.starmarketaucd1 = 0;
                p4_gameplay.moonmarketaucd1 = 0;
                p4_gameplay.megamarketaucd1 = 0;
                p4_gameplay.visayashospitalaucd1 = 0;
                p4_gameplay.hobertshospitalaucd1 = 0;
                p4_gameplay.heartshospitalaucd1 = 0;
                p4_gameplay.internshospitalaucd1 = 0;
                p4_gameplay.nationalhealthhospitalaucd1 = 0;
                p4_gameplay.veteranshospitalaucd1 = 0;
                p4_gameplay.pearlmallaucd1 = 0;
                p4_gameplay.megamallaucd1 = 0;
                p4_gameplay.articmallaucd1 = 0;
                p4_gameplay.heavenlymallaucd1 = 0;
                p4_gameplay.shangrillamallaucd1 = 0;
                p4_gameplay.utility1x1aucd1 = 0;
                p4_gameplay.utility1x2aucd1 = 0;
                p4_gameplay.transportation1x1aucd1 = 0;
                p4_gameplay.transportation1x2aucd1 = 0;
                p4_gameplay.transportation1x3aucd1 = 0;
                p4_gameplay.transportation1x4aucd1 = 0;


                p4_gameplay.easternschoolaucd2 = 0;
                p4_gameplay.westernschoolaucd2 = 0;
                p4_gameplay.visayashighschoolaucd2 = 0;
                p4_gameplay.southernschoolaucd2 = 0;
                p4_gameplay.nationsschoolaucd2 = 0;
                p4_gameplay.westmarketaucd2 = 0;
                p4_gameplay.nightmarketaucd2 = 0;
                p4_gameplay.daymarketaucd2 = 0;
                p4_gameplay.starmarketaucd2 = 0;
                p4_gameplay.moonmarketaucd2 = 0;
                p4_gameplay.megamarketaucd2 = 0;
                p4_gameplay.visayashospitalaucd2 = 0;
                p4_gameplay.hobertshospitalaucd2 = 0;
                p4_gameplay.heartshospitalaucd2 = 0;
                p4_gameplay.internshospitalaucd2 = 0;
                p4_gameplay.nationalhealthhospitalaucd2 = 0;
                p4_gameplay.veteranshospitalaucd2 = 0;
                p4_gameplay.pearlmallaucd2 = 0;
                p4_gameplay.megamallaucd2 = 0;
                p4_gameplay.articmallaucd2 = 0;
                p4_gameplay.heavenlymallaucd2 = 0;
                p4_gameplay.shangrillamallaucd2 = 0;
                p4_gameplay.utility2x1aucd2 = 0;
                p4_gameplay.utility2x2aucd2 = 0;
                p4_gameplay.transportation2x1aucd2 = 0;
                p4_gameplay.transportation2x2aucd2 = 0;
                p4_gameplay.transportation2x3aucd2 = 0;
                p4_gameplay.transportation2x4aucd2 = 0;

                p4_gameplay.easternschoolaucd3 = 0;
                p4_gameplay.westernschoolaucd3 = 0;
                p4_gameplay.visayashighschoolaucd3 = 0;
                p4_gameplay.southernschoolaucd3 = 0;
                p4_gameplay.nationsschoolaucd3 = 0;
                p4_gameplay.westmarketaucd3 = 0;
                p4_gameplay.nightmarketaucd3 = 0;
                p4_gameplay.daymarketaucd3 = 0;
                p4_gameplay.starmarketaucd3 = 0;
                p4_gameplay.moonmarketaucd3 = 0;
                p4_gameplay.megamarketaucd3 = 0;
                p4_gameplay.visayashospitalaucd3 = 0;
                p4_gameplay.hobertshospitalaucd3 = 0;
                p4_gameplay.heartshospitalaucd3 = 0;
                p4_gameplay.internshospitalaucd3 = 0;
                p4_gameplay.nationalhealthhospitalaucd3 = 0;
                p4_gameplay.veteranshospitalaucd3 = 0;
                p4_gameplay.pearlmallaucd3 = 0;
                p4_gameplay.megamallaucd3 = 0;
                p4_gameplay.articmallaucd3 = 0;
                p4_gameplay.heavenlymallaucd3 = 0;
                p4_gameplay.shangrillamallaucd3 = 0;
                p4_gameplay.utility3x1aucd3 = 0;
                p4_gameplay.utility3x2aucd3 = 0;
                p4_gameplay.transportation3x1aucd3 = 0;
                p4_gameplay.transportation3x2aucd3 = 0;
                p4_gameplay.transportation3x3aucd3 = 0;
                p4_gameplay.transportation3x4aucd3 = 0;

                p4_gameplay.easternschoolaucd4 = 0;
                p4_gameplay.westernschoolaucd4 = 0;
                p4_gameplay.visayashighschoolaucd4 = 0;
                p4_gameplay.southernschoolaucd4 = 0;
                p4_gameplay.nationsschoolaucd4 = 0;
                p4_gameplay.westmarketaucd4 = 0;
                p4_gameplay.nightmarketaucd4 = 0;
                p4_gameplay.daymarketaucd4 = 0;
                p4_gameplay.starmarketaucd4 = 0;
                p4_gameplay.moonmarketaucd4 = 0;
                p4_gameplay.megamarketaucd4 = 0;
                p4_gameplay.visayashospitalaucd4 = 0;
                p4_gameplay.hobertshospitalaucd4 = 0;
                p4_gameplay.heartshospitalaucd4 = 0;
                p4_gameplay.internshospitalaucd4 = 0;
                p4_gameplay.nationalhealthhospitalaucd4 = 0;
                p4_gameplay.veteranshospitalaucd4 = 0;
                p4_gameplay.pearlmallaucd4 = 0;
                p4_gameplay.megamallaucd4 = 0;
                p4_gameplay.articmallaucd4 = 0;
                p4_gameplay.heavenlymallaucd4 = 0;
                p4_gameplay.shangrillamallaucd4 = 0;
                p4_gameplay.utility4x1aucd4 = 0;
                p4_gameplay.utility4x2aucd4 = 0;
                p4_gameplay.transportation4x1aucd4 = 0;
                p4_gameplay.transportation4x2aucd4 = 0;
                p4_gameplay.transportation4x3aucd4 = 0;
                p4_gameplay.transportation4x4aucd4 = 0;

                //auction
                p4_gameplay.easternschoolauc1 = 0;
                p4_gameplay.westernschoolauc1 = 0;
                p4_gameplay.visayashighschoolauc1 = 0;
                p4_gameplay.southernschoolauc1 = 0;
                p4_gameplay.nationsschoolauc1 = 0;
                p4_gameplay.westmarketauc1 = 0;
                p4_gameplay.nightmarketauc1 = 0;
                p4_gameplay.daymarketauc1 = 0;
                p4_gameplay.starmarketauc1 = 0;
                p4_gameplay.moonmarketauc1 = 0;
                p4_gameplay.megamarketauc1 = 0;
                p4_gameplay.visayashospitalauc1 = 0;
                p4_gameplay.hobertshospitalauc1 = 0;
                p4_gameplay.heartshospitalauc1 = 0;
                p4_gameplay.internshospitalauc1 = 0;
                p4_gameplay.nationalhealthhospitalauc1 = 0;
                p4_gameplay.veteranshospitalauc1 = 0;
                p4_gameplay.pearlmallauc1 = 0;
                p4_gameplay.megamallauc1 = 0;
                p4_gameplay.articmallauc1 = 0;
                p4_gameplay.heavenlymallauc1 = 0;
                p4_gameplay.shangrillamallauc1 = 0;
                p4_gameplay.utility1x1auc1 = 0;
                p4_gameplay.utility1x2auc1 = 0;
                p4_gameplay.transportation1x1auc1 = 0;
                p4_gameplay.transportation1x2auc1 = 0;
                p4_gameplay.transportation1x3auc1 = 0;
                p4_gameplay.transportation1x4auc1 = 0;


                p4_gameplay.easternschoolauc2 = 0;
                p4_gameplay.westernschoolauc2 = 0;
                p4_gameplay.visayashighschoolauc2 = 0;
                p4_gameplay.southernschoolauc2 = 0;
                p4_gameplay.nationsschoolauc2 = 0;
                p4_gameplay.westmarketauc2 = 0;
                p4_gameplay.nightmarketauc2 = 0;
                p4_gameplay.daymarketauc2 = 0;
                p4_gameplay.starmarketauc2 = 0;
                p4_gameplay.moonmarketauc2 = 0;
                p4_gameplay.megamarketauc2 = 0;
                p4_gameplay.visayashospitalauc2 = 0;
                p4_gameplay.hobertshospitalauc2 = 0;
                p4_gameplay.heartshospitalauc2 = 0;
                p4_gameplay.internshospitalauc2 = 0;
                p4_gameplay.nationalhealthhospitalauc2 = 0;
                p4_gameplay.veteranshospitalauc2 = 0;
                p4_gameplay.pearlmallauc2 = 0;
                p4_gameplay.megamallauc2 = 0;
                p4_gameplay.articmallauc2 = 0;
                p4_gameplay.heavenlymallauc2 = 0;
                p4_gameplay.shangrillamallauc2 = 0;
                p4_gameplay.utility2x1auc2 = 0;
                p4_gameplay.utility2x2auc2 = 0;
                p4_gameplay.transportation2x1auc2 = 0;
                p4_gameplay.transportation2x2auc2 = 0;
                p4_gameplay.transportation2x3auc2 = 0;
                p4_gameplay.transportation2x4auc2 = 0;

                p4_gameplay.easternschoolauc3 = 0;
                p4_gameplay.westernschoolauc3 = 0;
                p4_gameplay.visayashighschoolauc3 = 0;
                p4_gameplay.southernschoolauc3 = 0;
                p4_gameplay.nationsschoolauc3 = 0;
                p4_gameplay.westmarketauc3 = 0;
                p4_gameplay.nightmarketauc3 = 0;
                p4_gameplay.daymarketauc3 = 0;
                p4_gameplay.starmarketauc3 = 0;
                p4_gameplay.moonmarketauc3 = 0;
                p4_gameplay.megamarketauc3 = 0;
                p4_gameplay.visayashospitalauc3 = 0;
                p4_gameplay.hobertshospitalauc3 = 0;
                p4_gameplay.heartshospitalauc3 = 0;
                p4_gameplay.internshospitalauc3 = 0;
                p4_gameplay.nationalhealthhospitalauc3 = 0;
                p4_gameplay.veteranshospitalauc3 = 0;
                p4_gameplay.pearlmallauc3 = 0;
                p4_gameplay.megamallauc3 = 0;
                p4_gameplay.articmallauc3 = 0;
                p4_gameplay.heavenlymallauc3 = 0;
                p4_gameplay.shangrillamallauc3 = 0;
                p4_gameplay.utility3x1auc3 = 0;
                p4_gameplay.utility3x2auc3 = 0;
                p4_gameplay.transportation3x1auc3 = 0;
                p4_gameplay.transportation3x2auc3 = 0;
                p4_gameplay.transportation3x3auc3 = 0;
                p4_gameplay.transportation3x4auc3 = 0;

                p4_gameplay.easternschoolauc4 = 0;
                p4_gameplay.westernschoolauc4 = 0;
                p4_gameplay.visayashighschoolauc4 = 0;
                p4_gameplay.southernschoolauc4 = 0;
                p4_gameplay.nationsschoolauc4 = 0;
                p4_gameplay.westmarketauc4 = 0;
                p4_gameplay.nightmarketauc4 = 0;
                p4_gameplay.daymarketauc4 = 0;
                p4_gameplay.starmarketauc4 = 0;
                p4_gameplay.moonmarketauc4 = 0;
                p4_gameplay.megamarketauc4 = 0;
                p4_gameplay.visayashospitalauc4 = 0;
                p4_gameplay.hobertshospitalauc4 = 0;
                p4_gameplay.heartshospitalauc4 = 0;
                p4_gameplay.internshospitalauc4 = 0;
                p4_gameplay.nationalhealthhospitalauc4 = 0;
                p4_gameplay.veteranshospitalauc4 = 0;
                p4_gameplay.pearlmallauc4 = 0;
                p4_gameplay.megamallauc4 = 0;
                p4_gameplay.articmallauc4 = 0;
                p4_gameplay.heavenlymallauc4 = 0;
                p4_gameplay.shangrillamallauc4 = 0;
                p4_gameplay.utility4x1auc4 = 0;
                p4_gameplay.utility4x2auc4 = 0;
                p4_gameplay.transportation4x1auc4 = 0;
                p4_gameplay.transportation4x2auc4 = 0;
                p4_gameplay.transportation4x3auc4 = 0;
                p4_gameplay.transportation4x4auc4 = 0;
                pb3notif.Image = bankers_game_proto.Properties.Resources.Fav_CLOSED___t;
                btnacc3.Visible = true;
                btndec3.Visible = false;
                p3aucnotif.Text = "The Auction has been cancelled";
                notif3.Visible = true;
            }
            if (bid == 0 && bid1 == 0 && bid2 == 0 && bid3 == 0 && p1quit1 == 1 && p1quit2 == 1 && p1quit3 == 1 && p1quit4 == 0)
            {
                notif2.Visible = false;
                notif3.Visible = false;
                notif1.Visible = false;
                p4_gameplay.easternschoolaucd1 = 0;
                p4_gameplay.westernschoolaucd1 = 0;
                p4_gameplay.visayashighschoolaucd1 = 0;
                p4_gameplay.southernschoolaucd1 = 0;
                p4_gameplay.nationsschoolaucd1 = 0;
                p4_gameplay.westmarketaucd1 = 0;
                p4_gameplay.nightmarketaucd1 = 0;
                p4_gameplay.daymarketaucd1 = 0;
                p4_gameplay.starmarketaucd1 = 0;
                p4_gameplay.moonmarketaucd1 = 0;
                p4_gameplay.megamarketaucd1 = 0;
                p4_gameplay.visayashospitalaucd1 = 0;
                p4_gameplay.hobertshospitalaucd1 = 0;
                p4_gameplay.heartshospitalaucd1 = 0;
                p4_gameplay.internshospitalaucd1 = 0;
                p4_gameplay.nationalhealthhospitalaucd1 = 0;
                p4_gameplay.veteranshospitalaucd1 = 0;
                p4_gameplay.pearlmallaucd1 = 0;
                p4_gameplay.megamallaucd1 = 0;
                p4_gameplay.articmallaucd1 = 0;
                p4_gameplay.heavenlymallaucd1 = 0;
                p4_gameplay.shangrillamallaucd1 = 0;
                p4_gameplay.utility1x1aucd1 = 0;
                p4_gameplay.utility1x2aucd1 = 0;
                p4_gameplay.transportation1x1aucd1 = 0;
                p4_gameplay.transportation1x2aucd1 = 0;
                p4_gameplay.transportation1x3aucd1 = 0;
                p4_gameplay.transportation1x4aucd1 = 0;


                p4_gameplay.easternschoolaucd2 = 0;
                p4_gameplay.westernschoolaucd2 = 0;
                p4_gameplay.visayashighschoolaucd2 = 0;
                p4_gameplay.southernschoolaucd2 = 0;
                p4_gameplay.nationsschoolaucd2 = 0;
                p4_gameplay.westmarketaucd2 = 0;
                p4_gameplay.nightmarketaucd2 = 0;
                p4_gameplay.daymarketaucd2 = 0;
                p4_gameplay.starmarketaucd2 = 0;
                p4_gameplay.moonmarketaucd2 = 0;
                p4_gameplay.megamarketaucd2 = 0;
                p4_gameplay.visayashospitalaucd2 = 0;
                p4_gameplay.hobertshospitalaucd2 = 0;
                p4_gameplay.heartshospitalaucd2 = 0;
                p4_gameplay.internshospitalaucd2 = 0;
                p4_gameplay.nationalhealthhospitalaucd2 = 0;
                p4_gameplay.veteranshospitalaucd2 = 0;
                p4_gameplay.pearlmallaucd2 = 0;
                p4_gameplay.megamallaucd2 = 0;
                p4_gameplay.articmallaucd2 = 0;
                p4_gameplay.heavenlymallaucd2 = 0;
                p4_gameplay.shangrillamallaucd2 = 0;
                p4_gameplay.utility2x1aucd2 = 0;
                p4_gameplay.utility2x2aucd2 = 0;
                p4_gameplay.transportation2x1aucd2 = 0;
                p4_gameplay.transportation2x2aucd2 = 0;
                p4_gameplay.transportation2x3aucd2 = 0;
                p4_gameplay.transportation2x4aucd2 = 0;

                p4_gameplay.easternschoolaucd3 = 0;
                p4_gameplay.westernschoolaucd3 = 0;
                p4_gameplay.visayashighschoolaucd3 = 0;
                p4_gameplay.southernschoolaucd3 = 0;
                p4_gameplay.nationsschoolaucd3 = 0;
                p4_gameplay.westmarketaucd3 = 0;
                p4_gameplay.nightmarketaucd3 = 0;
                p4_gameplay.daymarketaucd3 = 0;
                p4_gameplay.starmarketaucd3 = 0;
                p4_gameplay.moonmarketaucd3 = 0;
                p4_gameplay.megamarketaucd3 = 0;
                p4_gameplay.visayashospitalaucd3 = 0;
                p4_gameplay.hobertshospitalaucd3 = 0;
                p4_gameplay.heartshospitalaucd3 = 0;
                p4_gameplay.internshospitalaucd3 = 0;
                p4_gameplay.nationalhealthhospitalaucd3 = 0;
                p4_gameplay.veteranshospitalaucd3 = 0;
                p4_gameplay.pearlmallaucd3 = 0;
                p4_gameplay.megamallaucd3 = 0;
                p4_gameplay.articmallaucd3 = 0;
                p4_gameplay.heavenlymallaucd3 = 0;
                p4_gameplay.shangrillamallaucd3 = 0;
                p4_gameplay.utility3x1aucd3 = 0;
                p4_gameplay.utility3x2aucd3 = 0;
                p4_gameplay.transportation3x1aucd3 = 0;
                p4_gameplay.transportation3x2aucd3 = 0;
                p4_gameplay.transportation3x3aucd3 = 0;
                p4_gameplay.transportation3x4aucd3 = 0;

                p4_gameplay.easternschoolaucd4 = 0;
                p4_gameplay.westernschoolaucd4 = 0;
                p4_gameplay.visayashighschoolaucd4 = 0;
                p4_gameplay.southernschoolaucd4 = 0;
                p4_gameplay.nationsschoolaucd4 = 0;
                p4_gameplay.westmarketaucd4 = 0;
                p4_gameplay.nightmarketaucd4 = 0;
                p4_gameplay.daymarketaucd4 = 0;
                p4_gameplay.starmarketaucd4 = 0;
                p4_gameplay.moonmarketaucd4 = 0;
                p4_gameplay.megamarketaucd4 = 0;
                p4_gameplay.visayashospitalaucd4 = 0;
                p4_gameplay.hobertshospitalaucd4 = 0;
                p4_gameplay.heartshospitalaucd4 = 0;
                p4_gameplay.internshospitalaucd4 = 0;
                p4_gameplay.nationalhealthhospitalaucd4 = 0;
                p4_gameplay.veteranshospitalaucd4 = 0;
                p4_gameplay.pearlmallaucd4 = 0;
                p4_gameplay.megamallaucd4 = 0;
                p4_gameplay.articmallaucd4 = 0;
                p4_gameplay.heavenlymallaucd4 = 0;
                p4_gameplay.shangrillamallaucd4 = 0;
                p4_gameplay.utility4x1aucd4 = 0;
                p4_gameplay.utility4x2aucd4 = 0;
                p4_gameplay.transportation4x1aucd4 = 0;
                p4_gameplay.transportation4x2aucd4 = 0;
                p4_gameplay.transportation4x3aucd4 = 0;
                p4_gameplay.transportation4x4aucd4 = 0;

                //auction
                p4_gameplay.easternschoolauc1 = 0;
                p4_gameplay.westernschoolauc1 = 0;
                p4_gameplay.visayashighschoolauc1 = 0;
                p4_gameplay.southernschoolauc1 = 0;
                p4_gameplay.nationsschoolauc1 = 0;
                p4_gameplay.westmarketauc1 = 0;
                p4_gameplay.nightmarketauc1 = 0;
                p4_gameplay.daymarketauc1 = 0;
                p4_gameplay.starmarketauc1 = 0;
                p4_gameplay.moonmarketauc1 = 0;
                p4_gameplay.megamarketauc1 = 0;
                p4_gameplay.visayashospitalauc1 = 0;
                p4_gameplay.hobertshospitalauc1 = 0;
                p4_gameplay.heartshospitalauc1 = 0;
                p4_gameplay.internshospitalauc1 = 0;
                p4_gameplay.nationalhealthhospitalauc1 = 0;
                p4_gameplay.veteranshospitalauc1 = 0;
                p4_gameplay.pearlmallauc1 = 0;
                p4_gameplay.megamallauc1 = 0;
                p4_gameplay.articmallauc1 = 0;
                p4_gameplay.heavenlymallauc1 = 0;
                p4_gameplay.shangrillamallauc1 = 0;
                p4_gameplay.utility1x1auc1 = 0;
                p4_gameplay.utility1x2auc1 = 0;
                p4_gameplay.transportation1x1auc1 = 0;
                p4_gameplay.transportation1x2auc1 = 0;
                p4_gameplay.transportation1x3auc1 = 0;
                p4_gameplay.transportation1x4auc1 = 0;


                p4_gameplay.easternschoolauc2 = 0;
                p4_gameplay.westernschoolauc2 = 0;
                p4_gameplay.visayashighschoolauc2 = 0;
                p4_gameplay.southernschoolauc2 = 0;
                p4_gameplay.nationsschoolauc2 = 0;
                p4_gameplay.westmarketauc2 = 0;
                p4_gameplay.nightmarketauc2 = 0;
                p4_gameplay.daymarketauc2 = 0;
                p4_gameplay.starmarketauc2 = 0;
                p4_gameplay.moonmarketauc2 = 0;
                p4_gameplay.megamarketauc2 = 0;
                p4_gameplay.visayashospitalauc2 = 0;
                p4_gameplay.hobertshospitalauc2 = 0;
                p4_gameplay.heartshospitalauc2 = 0;
                p4_gameplay.internshospitalauc2 = 0;
                p4_gameplay.nationalhealthhospitalauc2 = 0;
                p4_gameplay.veteranshospitalauc2 = 0;
                p4_gameplay.pearlmallauc2 = 0;
                p4_gameplay.megamallauc2 = 0;
                p4_gameplay.articmallauc2 = 0;
                p4_gameplay.heavenlymallauc2 = 0;
                p4_gameplay.shangrillamallauc2 = 0;
                p4_gameplay.utility2x1auc2 = 0;
                p4_gameplay.utility2x2auc2 = 0;
                p4_gameplay.transportation2x1auc2 = 0;
                p4_gameplay.transportation2x2auc2 = 0;
                p4_gameplay.transportation2x3auc2 = 0;
                p4_gameplay.transportation2x4auc2 = 0;

                p4_gameplay.easternschoolauc3 = 0;
                p4_gameplay.westernschoolauc3 = 0;
                p4_gameplay.visayashighschoolauc3 = 0;
                p4_gameplay.southernschoolauc3 = 0;
                p4_gameplay.nationsschoolauc3 = 0;
                p4_gameplay.westmarketauc3 = 0;
                p4_gameplay.nightmarketauc3 = 0;
                p4_gameplay.daymarketauc3 = 0;
                p4_gameplay.starmarketauc3 = 0;
                p4_gameplay.moonmarketauc3 = 0;
                p4_gameplay.megamarketauc3 = 0;
                p4_gameplay.visayashospitalauc3 = 0;
                p4_gameplay.hobertshospitalauc3 = 0;
                p4_gameplay.heartshospitalauc3 = 0;
                p4_gameplay.internshospitalauc3 = 0;
                p4_gameplay.nationalhealthhospitalauc3 = 0;
                p4_gameplay.veteranshospitalauc3 = 0;
                p4_gameplay.pearlmallauc3 = 0;
                p4_gameplay.megamallauc3 = 0;
                p4_gameplay.articmallauc3 = 0;
                p4_gameplay.heavenlymallauc3 = 0;
                p4_gameplay.shangrillamallauc3 = 0;
                p4_gameplay.utility3x1auc3 = 0;
                p4_gameplay.utility3x2auc3 = 0;
                p4_gameplay.transportation3x1auc3 = 0;
                p4_gameplay.transportation3x2auc3 = 0;
                p4_gameplay.transportation3x3auc3 = 0;
                p4_gameplay.transportation3x4auc3 = 0;

                p4_gameplay.easternschoolauc4 = 0;
                p4_gameplay.westernschoolauc4 = 0;
                p4_gameplay.visayashighschoolauc4 = 0;
                p4_gameplay.southernschoolauc4 = 0;
                p4_gameplay.nationsschoolauc4 = 0;
                p4_gameplay.westmarketauc4 = 0;
                p4_gameplay.nightmarketauc4 = 0;
                p4_gameplay.daymarketauc4 = 0;
                p4_gameplay.starmarketauc4 = 0;
                p4_gameplay.moonmarketauc4 = 0;
                p4_gameplay.megamarketauc4 = 0;
                p4_gameplay.visayashospitalauc4 = 0;
                p4_gameplay.hobertshospitalauc4 = 0;
                p4_gameplay.heartshospitalauc4 = 0;
                p4_gameplay.internshospitalauc4 = 0;
                p4_gameplay.nationalhealthhospitalauc4 = 0;
                p4_gameplay.veteranshospitalauc4 = 0;
                p4_gameplay.pearlmallauc4 = 0;
                p4_gameplay.megamallauc4 = 0;
                p4_gameplay.articmallauc4 = 0;
                p4_gameplay.heavenlymallauc4 = 0;
                p4_gameplay.shangrillamallauc4 = 0;
                p4_gameplay.utility4x1auc4 = 0;
                p4_gameplay.utility4x2auc4 = 0;
                p4_gameplay.transportation4x1auc4 = 0;
                p4_gameplay.transportation4x2auc4 = 0;
                p4_gameplay.transportation4x3auc4 = 0;
                p4_gameplay.transportation4x4auc4 = 0;
                pb4notif.Image = bankers_game_proto.Properties.Resources.Fav_CLOSED___r;
                btnacc4.Visible = true;
                btndec4.Visible = false;
                p4aucnotif.Text = "The Auction has been cancelled";
                notif4.Visible = true;
                
            }
            if (bid1 > bid && bid1 > bid2 && bid1 > bid3 && p1quit1 == 1 && p1quit2 == 0 && p1quit3 == 1 && p1quit4 == 1)
            {
                p4_gameplay.mon2 = mon2 - hibid;
                auctioned2();
                notif1.Visible = false;
                notif3.Visible = false;
                notif4.Visible = false;
                pb2notif.Image = bankers_game_proto.Properties.Resources.Fav_CLOSED___l;
                btnacc2.Visible = true;
                btndec2.Visible = false;
                p2aucnotif.Text = "Player 2 Won with a bid of " + hibid + "php";
                notif2.Visible = true;
            }

            if (bid2 > bid && bid2 > bid1 && bid2 > bid3 && p1quit1 == 1 && p1quit2 == 1 && p1quit3 == 0 && p1quit4 == 1)
            {
                p4_gameplay.mon3 = mon3 - hibid;
                auctioned3();
                notif1.Visible = false;
                notif2.Visible = false;
                notif4.Visible = false;
                pb3notif.Image = bankers_game_proto.Properties.Resources.Fav_CLOSED___t;
                btnacc3.Visible = true;
                btndec3.Visible = false;
                p3aucnotif.Text = "Player 3 Won with a bid of " + hibid + "php";
                notif3.Visible = true;
            }

            if (bid3 > bid && bid3 > bid1 && bid3 > bid2 && p1quit1 == 1 && p1quit2 == 1 && p1quit3 == 1 && p1quit4 == 0)
            {
                p4_gameplay.mon4 = mon4 - hibid;
                auctioned4();
                notif1.Visible = false;
                notif2.Visible = false;
                notif3.Visible = false;
                pb4notif.Image = bankers_game_proto.Properties.Resources.Fav_CLOSED___r;
                btnacc4.Visible = true;
                btndec4.Visible = false;
                p4aucnotif.Text = "Player 4 Won with a bid of " + hibid + "php";
                notif4.Visible = true;
            }

            if (bid > bid1 && bid > bid2 && bid > bid3 && p1quit1 == 0 && p1quit2 == 1 && p1quit3 == 1 && p1quit4 == 1)
            {
                p4_gameplay.mon = mon - hibid;
                auctioned1();    
                notif1.Visible = true;
                notif2.Visible = false;
                notif3.Visible = false;
                notif4.Visible = false;
                pb1notif.Image = bankers_game_proto.Properties.Resources.Fav_CLOSED__;
                btnacc1.Visible = true;
                btndec1.Visible = false;
                p1aucnotif.Text = "Player 1 Won with a bid of " + hibid + "php";
            
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
            if (btnp3.Enabled == true)
            {
                tip3.Visible = true;
            }
            if (btnp4.Enabled == true)
            {
                tip4.Visible = true;
            }

            if (btnp1.Enabled == false)
            {
                tip1.Visible = false;
            }
            if (btnp2.Enabled == false)
            {
                tip2.Visible = false;
            }
            if (btnp3.Enabled == false)
            {
                tip3.Visible = false;
            }
            if (btnp4.Enabled == false)
            {
                tip4.Visible = false;
            }
        }
        void colorturn()
        {
            if (btnp1.Enabled == false)
            {
                btnp1.BackColor = Color.Gray;
            }
            if (btnp2.Enabled == false)
            {
                btnp2.BackColor = Color.Gray;
            }
            if (btnp3.Enabled == false)
            {
                btnp3.BackColor = Color.Gray;
            }
            if (btnp4.Enabled == false)
            {
                btnp4.BackColor = Color.Gray;
            }

            if (btnp1.Enabled == true)
            {
                btnp1.BackColor = Color.LightSalmon;
            }
            if (btnp2.Enabled == true)
            {
                btnp2.BackColor = Color.LightSkyBlue;
            }
            if (btnp3.Enabled == true)
            {
                btnp3.BackColor = Color.LimeGreen;
            }
            if (btnp4.Enabled == true)
            {
                btnp4.BackColor = Color.Orange;
            }
        }
        void startingenable()
        {
            if (p1quit1 == 0 && p1quit2 == 0 && p1quit3 == 0 && p1quit4 == 0)
            {
                btnp1.Enabled = true;
                btnp2.Enabled = false;
                btnp3.Enabled = false;
                btnp4.Enabled = false;
            }
            if (p1quit1 == 0 && p1quit2 == 0 && p1quit3 == 0 && p1quit4 == 1)
            {
                btnp1.Enabled = true;
                btnp2.Enabled = false;
                btnp3.Enabled = false;
                btnp4.Enabled = false;
            }
            if (p1quit1 == 0 && p1quit2 == 0 && p1quit3 == 1 && p1quit4 == 0)
            {
                btnp1.Enabled = true;
                btnp2.Enabled = false;
                btnp3.Enabled = false;
                btnp4.Enabled = false;
            }
            if (p1quit1 == 0 && p1quit2 == 1 && p1quit3 == 0 && p1quit4 == 0)
            {
                btnp1.Enabled = true;
                btnp2.Enabled = false;
                btnp3.Enabled = false;
                btnp4.Enabled = false;
            }
            if (p1quit1 == 0 && p1quit2 == 0 && p1quit3 == 1 && p1quit4 == 1)
            {
                btnp1.Enabled = true;
                btnp2.Enabled = false;
                btnp3.Enabled = false;
                btnp4.Enabled = false;
            }
            if (p1quit1 == 0 && p1quit2 == 1 && p1quit3 == 0 && p1quit4 == 1)
            {
                btnp1.Enabled = true;
                btnp2.Enabled = false;
                btnp3.Enabled = false;
                btnp4.Enabled = false;
            }
            if (p1quit1 == 0 && p1quit2 == 1 && p1quit3 == 1 && p1quit4 == 0)
            {
                btnp1.Enabled = true;
                btnp2.Enabled = false;
                btnp3.Enabled = false;
                btnp4.Enabled = false;
            }
            //p2
            if (p1quit1 == 1 && p1quit2 == 0 && p1quit3 == 0 && p1quit4 == 0)
            {
                btnp1.Enabled = false;
                btnp2.Enabled = true;
                btnp3.Enabled = false;
                btnp4.Enabled = false;
            }
            if (p1quit1 == 1 && p1quit2 == 0 && p1quit3 == 1 && p1quit4 == 0)
            {
                btnp1.Enabled = false;
                btnp2.Enabled = true;
                btnp3.Enabled = false;
                btnp4.Enabled = false;
            }
            if (p1quit1 == 1 && p1quit2 == 0 && p1quit3 == 0 && p1quit4 == 1)
            {
                btnp1.Enabled = false;
                btnp2.Enabled = true;
                btnp3.Enabled = false;
                btnp4.Enabled = false;
            }

            //p3
            if (p1quit1 == 1 && p1quit2 == 1 && p1quit3 == 0 && p1quit4 == 0)
            {
                btnp1.Enabled = false;
                btnp2.Enabled = false;
                btnp3.Enabled = true;
                btnp4.Enabled = false;
            }

        }
        void quitbidding()
        {

            if (p1quit1 == 1 && p1quit2 == 1 && p1quit3 == 1 && p1quit4 == 0)
            {
                quit();
            }
            if (p1quit1 == 0 && p1quit2 == 1 && p1quit3 == 1 && p1quit4 == 1)
            {
                quit();
            }
            if (p1quit1 == 1 && p1quit2 == 0 && p1quit3 == 1 && p1quit4 == 1)
            {
                quit();
            }
            if (p1quit1 == 1 && p1quit2 == 1 && p1quit3 == 0 && p1quit4 == 1)
            {
                quit();

            }
        }
        void rushtimeout()
        {
            if (p4_gameplay.timer5 == 0)
            {
                p1quit1 = 1;
                p1quit2 = 1;
                p1quit3 = 1;
                p1quit4 = 1;
                quit();
                this.Close();
            }
        }
        void bugsaverquit()
        {

            if (bid > bid1 && p1quit1 == 0 && p1quit2 == 1 && p1quit3 == 1 && p1quit4 == 1 || bid > bid2 && p1quit1 == 0 && p1quit2 == 1 && p1quit3 == 1 && p1quit4 == 1 || bid > bid3 && p1quit1 == 0 && p1quit2 == 1 && p1quit3 == 1 && p1quit4 == 1)
            {
                quit();
                pb1notif.Image = bankers_game_proto.Properties.Resources.Fav_CLOSED__;
                btnacc1.Visible = true;
                btndec1.Visible = false;
                p1aucnotif.Text = "Player 1 Won with a bid of " + hibid + "php";
                notif1.Visible = true;
              
            }
            if (bid1 > bid && p1quit1 == 1 && p1quit2 == 0 && p1quit3 == 1 && p1quit4 == 1 || bid1 > bid2 && p1quit1 == 1 && p1quit2 == 0 && p1quit3 == 1 && p1quit4 == 1 || bid1 > bid3 && p1quit1 == 1 && p1quit2 == 0 && p1quit3 == 1 && p1quit4 == 1)
            {
                quit();
                pb2notif.Image = bankers_game_proto.Properties.Resources.Fav_CLOSED___l;
                btnacc2.Visible = true;
                btndec2.Visible = false;
                p2aucnotif.Text = "Player 2 Won with a bid of " + hibid + "php";
                notif2.Visible = true;
            }
            if (bid2 > bid && p1quit1 == 1 && p1quit2 == 1 && p1quit3 == 0 && p1quit4 == 1 || bid2 > bid3 && p1quit1 == 1 && p1quit2 == 1 && p1quit3 == 0 && p1quit4 == 1 || bid2 > bid1 && p1quit1 == 1 && p1quit2 == 1 && p1quit3 == 0 && p1quit4 == 1)
            {
                quit();
                pb3notif.Image = bankers_game_proto.Properties.Resources.Fav_CLOSED___t;
                btnacc3.Visible = true;
                btndec3.Visible = false;
                p3aucnotif.Text = "Player 3 Won with a bid of " + hibid + "php";
                notif3.Visible = true;
            }
            if (bid3 > bid && p1quit1 == 1 && p1quit2 == 1 && p1quit3 == 1 && p1quit4 == 0 || bid3 > bid2 && p1quit1 == 1 && p1quit2 == 1 && p1quit3 == 1 && p1quit4 == 0 || bid3 > bid1 && p1quit1 == 1 && p1quit2 == 1 && p1quit3 == 1 && p1quit4 == 0)
            {
                quit();
                pb4notif.Image = bankers_game_proto.Properties.Resources.Fav_CLOSED___r;
                btnacc4.Visible = true;
                btndec4.Visible = false;
                p4aucnotif.Text = "Player 4 Won with a bid of " + hibid + "php";
                notif4.Visible = true;
            }

        }
        #endregion

        #region buttons
        private void btn1x0_Click(object sender, EventArgs e)
        {
            p1txt.Text = "";
            input += "0";
            p1txt.Text += input;
            p1notif.Visible = false;
            click.Play();
        }

        private void btn1x1_Click(object sender, EventArgs e)
        {
            p1txt.Text = "";
            input += "1";
            p1txt.Text += input;
            p1notif.Visible = false;
            click.Play();
        }

        private void btn1x6_Click(object sender, EventArgs e)
        {
            p1txt.Text = "";
            input += "6";
            p1txt.Text += input;
            p1notif.Visible = false;
            click.Play();
        }

        private void btn1x7_Click(object sender, EventArgs e)
        {
            p1txt.Text = "";
            input += "7";
            p1txt.Text += input;
            p1notif.Visible = false;
            click.Play();
        }

        private void btn1x5_Click(object sender, EventArgs e)
        {
            p1txt.Text = "";
            input += "5";
            p1txt.Text += input;
            p1notif.Visible = false;
            click.Play();
        }

        private void btn1x2_Click(object sender, EventArgs e)
        {
            p1txt.Text = "";
            input += "2";
            p1txt.Text += input;
            p1notif.Visible = false;
            click.Play();
        }

        private void btn1x3_Click(object sender, EventArgs e)
        {
            p1txt.Text = "";
            input += "3";
            p1txt.Text += input;
            p1notif.Visible = false;
            click.Play();
        }

        private void btn1x4_Click(object sender, EventArgs e)
        {
            p1txt.Text = "";
            input += "4";
            p1txt.Text += input;
            p1notif.Visible = false;
            click.Play();
        }

        private void btn1x9_Click(object sender, EventArgs e)
        {
            p1txt.Text = "";
            input += "9";
            p1txt.Text += input;
            p1notif.Visible = false;
            click.Play();
        }

        private void btn1x8_Click(object sender, EventArgs e)
        {
            p1txt.Text = "";
            input += "8";
            p1txt.Text += input;
            p1notif.Visible = false;
            click.Play();
        }

        private void btn2x0_Click(object sender, EventArgs e)
        {
            p2txt.Text = "";
            input2 += "0";
            p2txt.Text += input2;
            p2notif.Visible = false;
            click.Play();
        }

        private void btn2x1_Click(object sender, EventArgs e)
        {
            p2txt.Text = "";
            input2 += "1";
            p2txt.Text += input2;
            p2notif.Visible = false;
            click.Play();
        }

        private void btn2x2_Click(object sender, EventArgs e)
        {
            p2txt.Text = "";
            input2 += "2";
            p2txt.Text += input2;
            p2notif.Visible = false;
            click.Play();
        }

        private void btn2x3_Click(object sender, EventArgs e)
        {
            p2txt.Text = "";
            input2 += "3";
            p2txt.Text += input2;
            p2notif.Visible = false;
            click.Play();
        }

        private void btn2x4_Click(object sender, EventArgs e)
        {
            p2txt.Text = "";
            input2 += "4";
            p2txt.Text += input2;
            p2notif.Visible = false;
            click.Play();
        }

        private void btn2x5_Click(object sender, EventArgs e)
        {
            p2txt.Text = "";
            input2 += "5";
            p2txt.Text += input2;
            p2notif.Visible = false;
            click.Play();
        }

        private void btn2x6_Click(object sender, EventArgs e)
        {
            p2txt.Text = "";
            input2 += "6";
            p2txt.Text += input2;
            p2notif.Visible = false;
            click.Play();
        }

        private void btn2x7_Click(object sender, EventArgs e)
        {
            p2txt.Text = "";
            input2 += "7";
            p2txt.Text += input2;
            p2notif.Visible = false;
            click.Play();
        }

        private void btn2x8_Click(object sender, EventArgs e)
        {
            p2txt.Text = "";
            input2 += "8";
            p2txt.Text += input2;
            p2notif.Visible = false;
            click.Play();
        }

        private void btn2x9_Click(object sender, EventArgs e)
        {
            p2txt.Text = "";
            input2 += "9";
            p2txt.Text += input2;
            p2notif.Visible = false;
            click.Play();
        }

        private void btn3x0_Click(object sender, EventArgs e)
        {
            p3txt.Text = "";
            input3 += "0";
            p3txt.Text += input3;
            p3notif.Visible = false;
            click.Play();
        }

        private void btn3x1_Click(object sender, EventArgs e)
        {
            p3txt.Text = "";
            input3 += "1";
            p3txt.Text += input3;
            p3notif.Visible = false;
            click.Play();
        }

        private void btn3x2_Click(object sender, EventArgs e)
        {
            p3txt.Text = "";
            input3 += "2";
            p3txt.Text += input3;
            p3notif.Visible = false;
            click.Play();
        }

        private void btn3x3_Click(object sender, EventArgs e)
        {
            p3txt.Text = "";
            input3 += "3";
            p3txt.Text += input3;
            p3notif.Visible = false;
            click.Play();
        }

        private void btn3x4_Click(object sender, EventArgs e)
        {
            p3txt.Text = "";
            input3 += "4";
            p3txt.Text += input3;
            p3notif.Visible = false;
            click.Play();
        }

        private void btn3x5_Click(object sender, EventArgs e)
        {
            p3txt.Text = "";
            input3 += "5";
            p3txt.Text += input3;
            p3notif.Visible = false;
            click.Play();
        }

        private void btn3x6_Click(object sender, EventArgs e)
        {
            p3txt.Text = "";
            input3 += "6";
            p3txt.Text += input3;
            p3notif.Visible = false;
            click.Play();
        }

        private void btn3x7_Click(object sender, EventArgs e)
        {
            p3txt.Text = "";
            input3 += "7";
            p3txt.Text += input3;
            p3notif.Visible = false;
            click.Play();
        }

        private void btn3x8_Click(object sender, EventArgs e)
        {
            p3txt.Text = "";
            input3 += "8";
            p3txt.Text += input3;
            p3notif.Visible = false;
            click.Play();
        }

        private void btn3x9_Click(object sender, EventArgs e)
        {
            p3txt.Text = "";
            input3 += "9";
            p3txt.Text += input3;
            p3notif.Visible = false;
            click.Play();
        }

        private void btn4x0_Click(object sender, EventArgs e)
        {
            p4txt.Text = "";
            input4 += "0";
            p4txt.Text += input4;
            p4notif.Visible = false;
            click.Play();
        }

        private void btn4x1_Click(object sender, EventArgs e)
        {
            p4txt.Text = "";
            input4 += "1";
            p4txt.Text += input4;
            p4notif.Visible = false;
            click.Play();
        }

        private void btn4x2_Click(object sender, EventArgs e)
        {
            p4txt.Text = "";
            input4 += "2";
            p4txt.Text += input4;
            p4notif.Visible = false;
            click.Play();
        }

        private void btn4x3_Click(object sender, EventArgs e)
        {
            p4txt.Text = "";
            input4 += "3";
            p4txt.Text += input4;
            p4notif.Visible = false;
            click.Play();
        }

        private void btn4x4_Click(object sender, EventArgs e)
        {
            p4txt.Text = "";
            input4 += "4";
            p4txt.Text += input4;
            p4notif.Visible = false;
            click.Play();
        }

        private void btn4x5_Click(object sender, EventArgs e)
        {
            p4txt.Text = "";
            input4 += "5";
            p4txt.Text += input4;
            p4notif.Visible = false;
            click.Play();
        }

        private void btn4x6_Click(object sender, EventArgs e)
        {
            p4txt.Text = "";
            input4 += "6";
            p4txt.Text += input4;
            p4notif.Visible = false;
            click.Play();
        }

        private void btn4x7_Click(object sender, EventArgs e)
        {
            p4txt.Text = "";
            input4 += "7";
            p4txt.Text += input4;
            p4notif.Visible = false;
            click.Play();
        }

        private void btn4x8_Click(object sender, EventArgs e)
        {
            p4txt.Text = "";
            input4 += "8";
            p4txt.Text += input4;
            p4notif.Visible = false;

            click.Play();
        }

        private void btn4x9_Click(object sender, EventArgs e)
        {
            p4txt.Text = "";
            input4 += "9";
            p4txt.Text += input4;
            p4notif.Visible = false;
            click.Play();
        }


        #endregion

        #region design
        void icons2()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            groupBox1.BackgroundImage =bankers_game_proto.Properties.Resources.auc;
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            btnp2.Enabled = false;
            btnp4.Enabled = false;
            btnp3.Enabled = false;

            p1mon.Text = "Money:" + mon.ToString();
            p2mon.Text = "Money:" + mon2.ToString();
            p3mon.Text = "Money:" + mon3.ToString();
            p4mon.Text = "Money:" + mon4.ToString();
            btn1x0.BackgroundImage =bankers_game_proto.Properties.Resources.zero;
            btn1x0.BackgroundImageLayout = ImageLayout.Zoom;
            btn1x1.BackgroundImage =bankers_game_proto.Properties.Resources.one;
            btn1x1.BackgroundImageLayout = ImageLayout.Zoom;
            btn1x2.BackgroundImage =bankers_game_proto.Properties.Resources.two;
            btn1x2.BackgroundImageLayout = ImageLayout.Zoom;
            btn1x3.BackgroundImage =bankers_game_proto.Properties.Resources.three;
            btn1x3.BackgroundImageLayout = ImageLayout.Zoom;
            btn1x4.BackgroundImage =bankers_game_proto.Properties.Resources.four;
            btn1x4.BackgroundImageLayout = ImageLayout.Zoom;
            btn1x5.BackgroundImage =bankers_game_proto.Properties.Resources.five;
            btn1x5.BackgroundImageLayout = ImageLayout.Zoom;
            btn1x6.BackgroundImage =bankers_game_proto.Properties.Resources.six;
            btn1x6.BackgroundImageLayout = ImageLayout.Zoom;
            btn1x7.BackgroundImage =bankers_game_proto.Properties.Resources.seven;
            btn1x7.BackgroundImageLayout = ImageLayout.Zoom;
            btn1x8.BackgroundImage =bankers_game_proto.Properties.Resources.eight;
            btn1x8.BackgroundImageLayout = ImageLayout.Zoom;
            btn1x9.BackgroundImage =bankers_game_proto.Properties.Resources.nine;
            btn1x9.BackgroundImageLayout = ImageLayout.Zoom;

            btn2x0.BackgroundImage =bankers_game_proto.Properties.Resources.zero_l;
            btn2x0.BackgroundImageLayout = ImageLayout.Zoom;
            btn2x1.BackgroundImage =bankers_game_proto.Properties.Resources.one_l;
            btn2x1.BackgroundImageLayout = ImageLayout.Zoom;
            btn2x2.BackgroundImage =bankers_game_proto.Properties.Resources.two_l;
            btn2x2.BackgroundImageLayout = ImageLayout.Zoom;
            btn2x3.BackgroundImage =bankers_game_proto.Properties.Resources.three_l;
            btn2x3.BackgroundImageLayout = ImageLayout.Zoom;
            btn2x4.BackgroundImage =bankers_game_proto.Properties.Resources.four_l;
            btn2x4.BackgroundImageLayout = ImageLayout.Zoom;
            btn2x5.BackgroundImage =bankers_game_proto.Properties.Resources.five_l;
            btn2x5.BackgroundImageLayout = ImageLayout.Zoom;
            btn2x6.BackgroundImage =bankers_game_proto.Properties.Resources.six_l;
            btn2x6.BackgroundImageLayout = ImageLayout.Zoom;
            btn2x7.BackgroundImage =bankers_game_proto.Properties.Resources.seven_l;
            btn2x7.BackgroundImageLayout = ImageLayout.Zoom;
            btn2x8.BackgroundImage =bankers_game_proto.Properties.Resources.eight_l;
            btn2x8.BackgroundImageLayout = ImageLayout.Zoom;
            btn2x9.BackgroundImage =bankers_game_proto.Properties.Resources.nine_l;
            btn2x9.BackgroundImageLayout = ImageLayout.Zoom;

            btn3x0.BackgroundImage =bankers_game_proto.Properties.Resources.zero;
            btn3x0.BackgroundImageLayout = ImageLayout.Zoom;
            btn3x1.BackgroundImage =bankers_game_proto.Properties.Resources.one_t;
            btn3x1.BackgroundImageLayout = ImageLayout.Zoom;
            btn3x2.BackgroundImage =bankers_game_proto.Properties.Resources.two_t;
            btn3x2.BackgroundImageLayout = ImageLayout.Zoom;
            btn3x3.BackgroundImage =bankers_game_proto.Properties.Resources.three_t;
            btn3x3.BackgroundImageLayout = ImageLayout.Zoom;
            btn3x4.BackgroundImage =bankers_game_proto.Properties.Resources.four_t;
            btn3x4.BackgroundImageLayout = ImageLayout.Zoom;
            btn3x5.BackgroundImage =bankers_game_proto.Properties.Resources.five_t;
            btn3x5.BackgroundImageLayout = ImageLayout.Zoom;
            btn3x6.BackgroundImage =bankers_game_proto.Properties.Resources.six_t;
            btn3x6.BackgroundImageLayout = ImageLayout.Zoom;
            btn3x7.BackgroundImage =bankers_game_proto.Properties.Resources.seven_t;
            btn3x7.BackgroundImageLayout = ImageLayout.Zoom;
            btn3x8.BackgroundImage =bankers_game_proto.Properties.Resources.eight_t;
            btn3x8.BackgroundImageLayout = ImageLayout.Zoom;
            btn3x9.BackgroundImage =bankers_game_proto.Properties.Resources.nine_t;
            btn3x9.BackgroundImageLayout = ImageLayout.Zoom;

            btn4x0.BackgroundImage =bankers_game_proto.Properties.Resources.zero_l;
            btn4x0.BackgroundImageLayout = ImageLayout.Zoom;
            btn4x1.BackgroundImage =bankers_game_proto.Properties.Resources.one_r;
            btn4x1.BackgroundImageLayout = ImageLayout.Zoom;
            btn4x2.BackgroundImage =bankers_game_proto.Properties.Resources.two_r;
            btn4x2.BackgroundImageLayout = ImageLayout.Zoom;
            btn4x3.BackgroundImage =bankers_game_proto.Properties.Resources.three_r;
            btn4x3.BackgroundImageLayout = ImageLayout.Zoom;
            btn4x4.BackgroundImage =bankers_game_proto.Properties.Resources.four_r;
            btn4x4.BackgroundImageLayout = ImageLayout.Zoom;
            btn4x5.BackgroundImage =bankers_game_proto.Properties.Resources.five_r;
            btn4x5.BackgroundImageLayout = ImageLayout.Zoom;
            btn4x6.BackgroundImage =bankers_game_proto.Properties.Resources.six_r;
            btn4x6.BackgroundImageLayout = ImageLayout.Zoom;
            btn4x7.BackgroundImage =bankers_game_proto.Properties.Resources.seven_r;
            btn4x7.BackgroundImageLayout = ImageLayout.Zoom;
            btn4x8.BackgroundImage =bankers_game_proto.Properties.Resources.eight_r;
            btn4x8.BackgroundImageLayout = ImageLayout.Zoom;
            btn4x9.BackgroundImage =bankers_game_proto.Properties.Resources.nine_r;
            btn4x9.BackgroundImageLayout = ImageLayout.Zoom;


            btnenter1.BackgroundImage =bankers_game_proto.Properties.Resources.check;
            btnenter1.BackgroundImageLayout = ImageLayout.Zoom;
            btnclear1.BackgroundImage =bankers_game_proto.Properties.Resources.eraser;
            btnclear1.BackgroundImageLayout = ImageLayout.Zoom;
            btnquit1.BackgroundImage =bankers_game_proto.Properties.Resources.cancel;
            btnquit1.BackgroundImageLayout = ImageLayout.Zoom;

            btnpass1.BackgroundImage =bankers_game_proto.Properties.Resources.ticket;
            btnpass1.BackgroundImageLayout = ImageLayout.Zoom;


            btnenter2.BackgroundImage =bankers_game_proto.Properties.Resources.check_r;
            btnenter2.BackgroundImageLayout = ImageLayout.Zoom;

            btnclear2.BackgroundImage =bankers_game_proto.Properties.Resources.eraser_l;
            btnclear2.BackgroundImageLayout = ImageLayout.Zoom;

            btnquit2.BackgroundImage =bankers_game_proto.Properties.Resources.cancel;
            btnquit2.BackgroundImageLayout = ImageLayout.Zoom;

            btnpass2.BackgroundImage =bankers_game_proto.Properties.Resources.ticket_l;
            btnpass2.BackgroundImageLayout = ImageLayout.Zoom;

            btnpass3.BackgroundImage =bankers_game_proto.Properties.Resources.ticket_t;
            btnpass3.BackgroundImageLayout = ImageLayout.Zoom;

            btnquit3.BackgroundImage =bankers_game_proto.Properties.Resources.cancel;
            btnquit3.BackgroundImageLayout = ImageLayout.Zoom;

            btnclear3.BackgroundImage =bankers_game_proto.Properties.Resources.eraser_t;
            btnclear3.BackgroundImageLayout = ImageLayout.Zoom;

            btnenter3.BackgroundImage =bankers_game_proto.Properties.Resources.check_t;
            btnenter3.BackgroundImageLayout = ImageLayout.Zoom;


            btnpass4.BackgroundImage =bankers_game_proto.Properties.Resources.ticket_r;
            btnpass4.BackgroundImageLayout = ImageLayout.Zoom;

            btnquit4.BackgroundImage =bankers_game_proto.Properties.Resources.cancel;
            btnquit4.BackgroundImageLayout = ImageLayout.Zoom;

            btnclear4.BackgroundImage =bankers_game_proto.Properties.Resources.eraser_r;
            btnclear4.BackgroundImageLayout = ImageLayout.Zoom;

            btnenter4.BackgroundImage =bankers_game_proto.Properties.Resources.check_l;
            btnenter4.BackgroundImageLayout = ImageLayout.Zoom;


            p3auc.BackgroundImage =bankers_game_proto.Properties.Resources.panel;
            p3auc.BackgroundImageLayout = ImageLayout.Stretch;

            p1auc.BackgroundImage =bankers_game_proto.Properties.Resources.panel;
            p1auc.BackgroundImageLayout = ImageLayout.Stretch;

            p2auc.BackgroundImage =bankers_game_proto.Properties.Resources.panel_r;
            p2auc.BackgroundImageLayout = ImageLayout.Stretch;

            p4auc.BackgroundImage =bankers_game_proto.Properties.Resources.panel_r;
            p4auc.BackgroundImageLayout = ImageLayout.Stretch;

            btnacc1.BackgroundImage =bankers_game_proto.Properties.Resources.check;
            btnacc1.BackgroundImageLayout = ImageLayout.Stretch;
            btnacc2.BackgroundImage =bankers_game_proto.Properties.Resources.check_r;
            btnacc2.BackgroundImageLayout = ImageLayout.Stretch;
            btnacc3.BackgroundImage =bankers_game_proto.Properties.Resources.check_t;
            btnacc3.BackgroundImageLayout = ImageLayout.Stretch;
            btnacc4.BackgroundImage =bankers_game_proto.Properties.Resources.check_l;
            btnacc4.BackgroundImageLayout = ImageLayout.Stretch;

            btndec1.BackgroundImage =bankers_game_proto.Properties.Resources.cancel;
            btndec1.BackgroundImageLayout = ImageLayout.Stretch;
            btndec2.BackgroundImage =bankers_game_proto.Properties.Resources.cancel;
            btndec2.BackgroundImageLayout = ImageLayout.Stretch;
            btndec3.BackgroundImage =bankers_game_proto.Properties.Resources.cancel;
            btndec3.BackgroundImageLayout = ImageLayout.Stretch;
            btndec4.BackgroundImage =bankers_game_proto.Properties.Resources.cancel;
            btndec4.BackgroundImageLayout = ImageLayout.Stretch;

            notif1.BackgroundImage =bankers_game_proto.Properties.Resources.panel;
            notif1.BackgroundImageLayout = ImageLayout.Stretch;

            notif2.BackgroundImage =bankers_game_proto.Properties.Resources.panel_r;
            notif2.BackgroundImageLayout = ImageLayout.Stretch;

            notif3.BackgroundImage =bankers_game_proto.Properties.Resources.panel;
            notif3.BackgroundImageLayout = ImageLayout.Stretch;

            notif4.BackgroundImage =bankers_game_proto.Properties.Resources.panel_r;
            notif4.BackgroundImageLayout = ImageLayout.Stretch;

        }
        void icons()
        {
            btnp1.BackgroundImage =bankers_game_proto.Properties.Resources.p1_d;
            btnp1.BackgroundImageLayout = ImageLayout.Stretch;

            btnp2.BackgroundImage =bankers_game_proto.Properties.Resources.p2_l;
            btnp2.BackgroundImageLayout = ImageLayout.Stretch;

            btnp3.BackgroundImage =bankers_game_proto.Properties.Resources.p3_t;
            btnp3.BackgroundImageLayout = ImageLayout.Stretch;

            btnp4.BackgroundImage =bankers_game_proto.Properties.Resources.p4_r;
            btnp4.BackgroundImageLayout = ImageLayout.Stretch;
        }
        void turnss()
        {
            if (btnp1.Enabled == true && p1quit1 == 0)
            {
                btnp1.Enabled = false;
                notif1.Visible = true;
                pb1notif.Image =bankers_game_proto.Properties.Resources.p1_d;
                p1aucnotif.Text = "Player 1's turn";
                btnacc1.Visible = true;
                btndec1.Visible = false;
            }
            if (btnp2.Enabled == true && p1quit2 == 0)
            {
                btnp2.Enabled = false;
                notif2.Visible = true;
                pb2notif.Image =bankers_game_proto.Properties.Resources.p2_l;
                p2aucnotif.Text = "Player 2's turn";
                btnacc2.Visible = true;
                btndec2.Visible = false;
            }

            if (btnp3.Enabled == true && p1quit3 == 0)
            {
                btnp3.Enabled = false;
                notif3.Visible = true;
                pb3notif.Image =bankers_game_proto.Properties.Resources.p3_t;
                p3aucnotif.Text = "Player 3's turn";
                btnacc3.Visible = true;
                btndec3.Visible = false;
            }

            if (btnp4.Enabled == true && p1quit4 == 0)
            {
                btnp4.Enabled = false;
                notif4.Visible = true;
                pb4notif.Image =bankers_game_proto.Properties.Resources.p4_r;
                p4aucnotif.Text = "Player 4's turn";
                btnacc4.Visible = true;
                btndec4.Visible = false;
            }

        }
        #endregion

        private void btnp4_Click(object sender, EventArgs e)
        {    
            tip4.Visible = true;
            p4auced = 1;
            turn4++;
            p4auc.Visible = true;
            btnp4.Visible = false;
            btnp4.Enabled = false;
            p4bid.Visible = true;
            aucs4();
            quick4 = Settings.timer4;
            tmr4.Text = quick4 / 60 + ":" + ((quick4 % 60) >= 10 ? (quick4 % 60).ToString() : "0" + (quick4 % 60));
            p4timer.Start();
            bugsaverquit();
            p4sound.Play();
        }

        private void btnp1_Click(object sender, EventArgs e)
        {
            tip1.Visible = true; 
            p1auced = 1;
            turn++;
            p1auc.Visible = true;
            btnp1.Visible = false;
            btnp1.Enabled = false;
            p1bid.Visible = true;
            aucs1();
            Thread.Sleep(500);
            quick = Settings.timer1;
            tmr1.Text = quick / 60 + ":" + ((quick % 60) >= 10 ? (quick % 60).ToString() : "0" + (quick % 60));
            p1timer.Start();
            bugsaverquit();
            p1sound.Play();
        }

        private void btnp2_Click(object sender, EventArgs e)
        {
            tip2.Visible = true;
            p2auced = 1;
            turn2++;
            p2auc.Visible = true;
            btnp2.Visible = false;
            btnp2.Enabled = false;
            p2bid.Visible = true;
            aucs2();
            quick2 = Settings.timer2;
            tmr2.Text = quick2 / 60 + ":" + ((quick2 % 60) >= 10 ? (quick2 % 60).ToString() : "0" + (quick2 % 60));
            p2timer.Start();
            bugsaverquit();
            p2sound.Play();
        }

        private void btnp3_Click(object sender, EventArgs e)
        {          
            tip3.Visible = true;
            p3auced = 1;
            turn3++;
            p3auc.Visible = true;
            btnp3.Visible = false;
            btnp3.Enabled = false;
            p3bid.Visible = true;
            aucs3();
            quick3 = Settings.timer3;
            tmr3.Text = quick3 / 60 + ":" + ((quick3 % 60) >= 10 ? (quick3 % 60).ToString() : "0" + (quick3 % 60));
            p3timer.Start();
            bugsaverquit();
            p3sound.Play();
        }

        private void btnpass1_Click(object sender, EventArgs e)
        {
            turns1();
            btnp1.Enabled = false;
            p1bid.Visible = false;
            auc1.Visible = false;
            guide();
            turnss();
            tip1.Visible = false;
            quick = p4_gameplay.quick;
            tmr1.Text = quick / 60 + ":" + ((quick % 60) >= 10 ? (quick % 60).ToString() : "0" + (quick % 60));
            p1timer.Stop();
            disableplayer();
            passed.Play();
        }

        private void btnpass2_Click(object sender, EventArgs e)
        {
            turns2();
            btnp2.Enabled = false;
            p2bid.Visible = false;
            auc2.Visible = false;
            guide();
            turnss();
            tip2.Visible = false;
            quick2 = p4_gameplay.quick2;
            tmr2.Text = quick2 / 60 + ":" + ((quick2 % 60) >= 10 ? (quick2 % 60).ToString() : "0" + (quick2 % 60));
            p2timer.Stop();
            disableplayer();
            passed.Play();
        }

        private void btnpass4_Click(object sender, EventArgs e)
        {
            turns4();
            btnp4.Enabled = false;
            p4bid.Visible = false;
            auc2.Visible = false;
            guide();
            turnss();
            tip4.Visible = false;
            quick4 = p4_gameplay.quick4;
            tmr4.Text = quick4 / 60 + ":" + ((quick4 % 60) >= 10 ? (quick4 % 60).ToString() : "0" + (quick4 % 60));
            p4timer.Stop();
            disableplayer();
            passed.Play();

            if(p1quit1 == 1)
            {
                btnp2.Enabled = true;
                turns4();
                btnp4.Enabled = false;
                p4bid.Visible = false;
                auc2.Visible = false;
                guide();
                turnss();
                tip4.Visible = false;
                quick4 = p4_gameplay.quick4;
                tmr4.Text = quick4 / 60 + ":" + ((quick4 % 60) >= 10 ? (quick4 % 60).ToString() : "0" + (quick4 % 60));
                p4timer.Stop();
                disableplayer();
                passed.Play();

            }
        }

        private void btnpass3_Click(object sender, EventArgs e)
        {
            turns3();
            btnp3.Enabled = false;
            p3bid.Visible = false;
            auc1.Visible = false;
            guide();
            turnss();
            tip3.Visible = false;
            quick3 = p4_gameplay.quick3;
            tmr3.Text = quick3 / 60 + ":" + ((quick3 % 60) >= 10 ? (quick3 % 60).ToString() : "0" + (quick3 % 60));
            p3timer.Stop();
            disableplayer();
            passed.Play();
        }

        private void ruleauc_Tick(object sender, EventArgs e)
        {
    
            colorturn();
            rushtimeout();
            disableplayer();
        }

        private void btnquit1_Click(object sender, EventArgs e)
        {
            notif1.Visible = true;
            pb1notif.Image =bankers_game_proto.Properties.Resources.exit1;
            btnacc1.Visible = true;
            btndec1.Visible = true;
            p1aucnotif.Text = "Do you want to leave auction?";
        }

        private void btnquit2_Click(object sender, EventArgs e)
        {
            notif2.Visible = true;
            pb2notif.Image =bankers_game_proto.Properties.Resources.exit1_l;
            btnacc2.Visible = true;
            btndec2.Visible = true;
            p2aucnotif.Text = "Do you want to leave auction?";
        }

        private void btnquit3_Click(object sender, EventArgs e)
        {
            notif3.Visible = true;
            pb3notif.Image =bankers_game_proto.Properties.Resources.exit_t;
            btnacc3.Visible = true;
            btndec3.Visible = true;
            p3aucnotif.Text = "Do you want to leave auction?";
        }

        private void btnquit4_Click(object sender, EventArgs e)
        {
            notif4.Visible = true;
            pb4notif.Image =bankers_game_proto.Properties.Resources.exit1_r;
            btnacc4.Visible = true;
            btndec4.Visible = true;
            p4aucnotif.Text = "Do you want to leave auction?";
        }

        private void btnclear1_Click(object sender, EventArgs e)
        {
            input = string.Empty;
            p1txt.Text = null;
            p1notif.Visible = false;
            decline.Play();
        }

        private void btnclear2_Click(object sender, EventArgs e)
        {
            input2 = string.Empty;
            p2txt.Text = null;
            p2notif.Visible = false;
            decline.Play();
        }

        private void btnclear3_Click(object sender, EventArgs e)
        {
            input3 = string.Empty;
            p3txt.Text = null;
            p3notif.Visible = false;
            decline.Play();
        }

        private void btnclear4_Click(object sender, EventArgs e)
        {
            input4 = string.Empty;
            p4txt.Text = null;
            p4notif.Visible = false;
            decline.Play();
        }

        private void btnenter1_Click(object sender, EventArgs e)
        {
            bidding1();
            input = string.Empty;
            p1txt.Text = null;
            p1bid.Visible = false;
            btnp1.Enabled = false;
            quit();
            click.Play();
        }

        private void btnenter2_Click(object sender, EventArgs e)
        {
            bidding2();
            input2 = string.Empty;
            p2txt.Text = null;
            p2bid.Visible = false;
            btnp2.Enabled = false;
            quit();
            click.Play();
        }

        private void btnenter3_Click(object sender, EventArgs e)
        {
            bidding3();
            input3 = string.Empty;
            p3txt.Text = null;
            p3bid.Visible = false;
            btnp3.Enabled = false;
            quit();
            click.Play();
        }

        private void btnenter4_Click(object sender, EventArgs e)
        {
            bidding4();
            input4 = string.Empty;
            p4txt.Text = null;
            p4bid.Visible = false;
            btnp4.Enabled = false;
            quit();
            click.Play();
        }

        private void tip1_Click(object sender, EventArgs e)
        {
            click.Play();
            tip1.Visible = false;
            notif1.Visible = true;
            p1aucnotif.Text = "Click the top-hat icon \r\nto the corner bottom-left side to show control-panel";
            pb1notif.Image =bankers_game_proto.Properties.Resources.p1_d;
            btnp1.Enabled = false;
            btnacc1.Visible = true;
            if (p1auced == 1)
            {
                tip1.Visible = false;
                notif1.Visible = true;
                p1aucnotif.Text = "To bid a price, \r\nthe price must be greater than the highest bid or atleast "+minprice+"php";
                pb1notif.Image =bankers_game_proto.Properties.Resources.auction;
                btnp1.Enabled = false;
                btnacc1.Visible = true;
            }
        }

        private void tip2_Click(object sender, EventArgs e)
        {
            click.Play();
            tip2.Visible = false;
            notif2.Visible = true;
            p2aucnotif.Text = "Click the jeep icon \r\nto the corner top-left side to show control-panel";
            pb2notif.Image =bankers_game_proto.Properties.Resources.p2_l;
            btnp2.Enabled = false;
            btnacc2.Visible = true;
            if (p2auced == 1)
            {
                tip2.Visible = false;
                notif2.Visible = true;
                p2aucnotif.Text = "To bid a price, \r\nthe price must be greater than the highest bid or atleast "+minprice+"php";
                pb2notif.Image =bankers_game_proto.Properties.Resources.auction_l;
                btnp2.Enabled = false;
                btnacc2.Visible = true;
            }
        }

        private void tip4_Click(object sender, EventArgs e)
        {
            click.Play();
            tip4.Visible = false;
            notif4.Visible = true;
            p4aucnotif.Text = "Click the tarsier icon \r\nto the corner bottom-right side to show control-panel";
            pb4notif.Image =bankers_game_proto.Properties.Resources.p4_r;
            btnp4.Enabled = false;
            btnacc4.Visible = true;
            if (p4auced == 1)
            {
                tip4.Visible = false;
                notif4.Visible = true;
                p4aucnotif.Text = "To bid a price, \r\nthe price must be greater than the highest bid or atleast "+minprice+"php";
                pb4notif.Image =bankers_game_proto.Properties.Resources.auction_r;
                btnp4.Enabled = false;
                btnacc4.Visible = true;
            }
        }

        private void tip3_Click(object sender, EventArgs e)
        {
            click.Play();
            tip3.Visible = false;
            notif3.Visible = true;
            p3aucnotif.Text = "Click the eagle icon \r\nto the corner top-right side to show control-panel";
            pb3notif.Image =bankers_game_proto.Properties.Resources.p3_t;
            btnp3.Enabled = false;
            btnacc3.Visible = true;

            if (p3auced == 1)
            {
                tip3.Visible = false;
                notif3.Visible = true;
                p3aucnotif.Text = "To bid a price, \r\nthe price must be greater than the highest bid or atleast "+minprice+"php";
                pb3notif.Image =bankers_game_proto.Properties.Resources.auction_t;
                btnp3.Enabled = false;
                btnacc3.Visible = true;
            }
        }

        private void p1timer_Tick(object sender, EventArgs e)
        {
            quick--;
            tmr1.Text = quick / 60 + ":" + ((quick % 60) >= 10 ? (quick % 60).ToString() : "0" + (quick % 60));
            if (quick == 0)
            {
                p1timer.Stop();
                timesup.Play();
                quick = 120;
                tmr1.Text = quick / 60 + ":" + ((quick % 60) >= 10 ? (quick % 60).ToString() : "0" + (quick % 60));
                guide();
                turns1();
                btnp1.Enabled = false;

            }
        }

        private void p2timer_Tick(object sender, EventArgs e)
        {
            quick2--;
            tmr2.Text = quick2 / 60 + ":" + ((quick2 % 60) >= 10 ? (quick2 % 60).ToString() : "0" + (quick2 % 60));
            if (quick2 == 0)
            {
                p2timer.Stop();
                timesup.Play();
                quick2 = 120;
                tmr2.Text = quick2 / 60 + ":" + ((quick2 % 60) >= 10 ? (quick2 % 60).ToString() : "0" + (quick2 % 60));
                guide();
                turns2();
                btnp2.Enabled = false;

            }
        }

        private void p3timer_Tick(object sender, EventArgs e)
        {
            quick3--;
            tmr3.Text = quick3 / 60 + ":" + ((quick3 % 60) >= 10 ? (quick3 % 60).ToString() : "0" + (quick3 % 60));
            if (quick3 == 0)
            {
                p3timer.Stop();
                timesup.Play();
                quick3 = 120;
                tmr3.Text = quick3 / 60 + ":" + ((quick3 % 60) >= 10 ? (quick3 % 60).ToString() : "0" + (quick3 % 60));

                turns3();
                btnp3.Enabled = false;

                guide();
            }
        }

        private void p4timer_Tick(object sender, EventArgs e)
        {
            quick4--;
            tmr4.Text = quick4 / 60 + ":" + ((quick4 % 60) >= 10 ? (quick4 % 60).ToString() : "0" + (quick4 % 60));
            if (quick4 == 0)
            {
                p4timer.Stop();
                timesup.Play();
                quick4 = 120;
                tmr4.Text = quick4 / 60 + ":" + ((quick4 % 60) >= 10 ? (quick4 % 60).ToString() : "0" + (quick4 % 60));

                turns4();
                btnp4.Enabled = false;
                guide();
            }
        }

        private void btnacc4_Click(object sender, EventArgs e)
        {
            if (p4aucnotif.Text.StartsWith("Player 4's turn"))
            {
                notif4.Visible = false;
                btnp4.Enabled = true;
                p1auced = 0;
                p2auced = 0;
                p3auced = 0;
                p4auced = 0;
                colorturn();
                guide();
                click.Play();
            }
            if (p4aucnotif.Text.StartsWith("Click the tarsier icon \r\nto the corner bottom-right side to show control-panel"))
            {
                notif4.Visible = false;
                btnp4.Enabled = true;
                tip4.Visible = true;
                click.Play();
            }
            if (p4aucnotif.Text.StartsWith("To bid a price, \r\nthe price must be greater than the highest bid or atleast " + minprice + "php"))
            {
                notif4.Visible = false;
                p4auc.Enabled = true;
                tip4.Visible = true;
                click.Play();
            }
            if (p4aucnotif.Text.StartsWith("Do you want to leave auction?"))
            {
                p1quit4 = 1;
                btnp4.Enabled = false;
                notif4.Visible = false;
                click.Play();
                if (p1quit4 == 1)
                {

                    btnp4.Enabled = false;
                    p4auc.Visible = false;
                    p1auc.Visible = false;
                    btnp1.Enabled = true;
                    turns4();
                    auc2.Visible = false;
                    guide();
                    tip4.Visible = false;
                    turnss();
                    p4timer.Stop();
                    quit();
                    quitbidding();
                    bugsaverquit();
                    
                }

            }
            if (p4aucnotif.Text.StartsWith("The Auction has been cancelled"))
            {
                p4aucch = 1;
                p4_gameplay.easternschoolaucd1 = 0;
                p4_gameplay.westernschoolaucd1 = 0;
                p4_gameplay.visayashighschoolaucd1 = 0;
                p4_gameplay.southernschoolaucd1 = 0;
                p4_gameplay.nationsschoolaucd1 = 0;
                p4_gameplay.westmarketaucd1 = 0;
                p4_gameplay.nightmarketaucd1 = 0;
                p4_gameplay.daymarketaucd1 = 0;
                p4_gameplay.starmarketaucd1 = 0;
                p4_gameplay.moonmarketaucd1 = 0;
                p4_gameplay.megamarketaucd1 = 0;
                p4_gameplay.visayashospitalaucd1 = 0;
                p4_gameplay.hobertshospitalaucd1 = 0;
                p4_gameplay.heartshospitalaucd1 = 0;
                p4_gameplay.internshospitalaucd1 = 0;
                p4_gameplay.nationalhealthhospitalaucd1 = 0;
                p4_gameplay.veteranshospitalaucd1 = 0;
                p4_gameplay.pearlmallaucd1 = 0;
                p4_gameplay.megamallaucd1 = 0;
                p4_gameplay.articmallaucd1 = 0;
                p4_gameplay.heavenlymallaucd1 = 0;
                p4_gameplay.shangrillamallaucd1 = 0;
                p4_gameplay.utility1x1aucd1 = 0;
                p4_gameplay.utility1x2aucd1 = 0;
                p4_gameplay.transportation1x1aucd1 = 0;
                p4_gameplay.transportation1x2aucd1 = 0;
                p4_gameplay.transportation1x3aucd1 = 0;
                p4_gameplay.transportation1x4aucd1 = 0;


                p4_gameplay.easternschoolaucd2 = 0;
                p4_gameplay.westernschoolaucd2 = 0;
                p4_gameplay.visayashighschoolaucd2 = 0;
                p4_gameplay.southernschoolaucd2 = 0;
                p4_gameplay.nationsschoolaucd2 = 0;
                p4_gameplay.westmarketaucd2 = 0;
                p4_gameplay.nightmarketaucd2 = 0;
                p4_gameplay.daymarketaucd2 = 0;
                p4_gameplay.starmarketaucd2 = 0;
                p4_gameplay.moonmarketaucd2 = 0;
                p4_gameplay.megamarketaucd2 = 0;
                p4_gameplay.visayashospitalaucd2 = 0;
                p4_gameplay.hobertshospitalaucd2 = 0;
                p4_gameplay.heartshospitalaucd2 = 0;
                p4_gameplay.internshospitalaucd2 = 0;
                p4_gameplay.nationalhealthhospitalaucd2 = 0;
                p4_gameplay.veteranshospitalaucd2 = 0;
                p4_gameplay.pearlmallaucd2 = 0;
                p4_gameplay.megamallaucd2 = 0;
                p4_gameplay.articmallaucd2 = 0;
                p4_gameplay.heavenlymallaucd2 = 0;
                p4_gameplay.shangrillamallaucd2 = 0;
                p4_gameplay.utility2x1aucd2 = 0;
                p4_gameplay.utility2x2aucd2 = 0;
                p4_gameplay.transportation2x1aucd2 = 0;
                p4_gameplay.transportation2x2aucd2 = 0;
                p4_gameplay.transportation2x3aucd2 = 0;
                p4_gameplay.transportation2x4aucd2 = 0;

                p4_gameplay.easternschoolaucd3 = 0;
                p4_gameplay.westernschoolaucd3 = 0;
                p4_gameplay.visayashighschoolaucd3 = 0;
                p4_gameplay.southernschoolaucd3 = 0;
                p4_gameplay.nationsschoolaucd3 = 0;
                p4_gameplay.westmarketaucd3 = 0;
                p4_gameplay.nightmarketaucd3 = 0;
                p4_gameplay.daymarketaucd3 = 0;
                p4_gameplay.starmarketaucd3 = 0;
                p4_gameplay.moonmarketaucd3 = 0;
                p4_gameplay.megamarketaucd3 = 0;
                p4_gameplay.visayashospitalaucd3 = 0;
                p4_gameplay.hobertshospitalaucd3 = 0;
                p4_gameplay.heartshospitalaucd3 = 0;
                p4_gameplay.internshospitalaucd3 = 0;
                p4_gameplay.nationalhealthhospitalaucd3 = 0;
                p4_gameplay.veteranshospitalaucd3 = 0;
                p4_gameplay.pearlmallaucd3 = 0;
                p4_gameplay.megamallaucd3 = 0;
                p4_gameplay.articmallaucd3 = 0;
                p4_gameplay.heavenlymallaucd3 = 0;
                p4_gameplay.shangrillamallaucd3 = 0;
                p4_gameplay.utility3x1aucd3 = 0;
                p4_gameplay.utility3x2aucd3 = 0;
                p4_gameplay.transportation3x1aucd3 = 0;
                p4_gameplay.transportation3x2aucd3 = 0;
                p4_gameplay.transportation3x3aucd3 = 0;
                p4_gameplay.transportation3x4aucd3 = 0;

                p4_gameplay.easternschoolaucd4 = 0;
                p4_gameplay.westernschoolaucd4 = 0;
                p4_gameplay.visayashighschoolaucd4 = 0;
                p4_gameplay.southernschoolaucd4 = 0;
                p4_gameplay.nationsschoolaucd4 = 0;
                p4_gameplay.westmarketaucd4 = 0;
                p4_gameplay.nightmarketaucd4 = 0;
                p4_gameplay.daymarketaucd4 = 0;
                p4_gameplay.starmarketaucd4 = 0;
                p4_gameplay.moonmarketaucd4 = 0;
                p4_gameplay.megamarketaucd4 = 0;
                p4_gameplay.visayashospitalaucd4 = 0;
                p4_gameplay.hobertshospitalaucd4 = 0;
                p4_gameplay.heartshospitalaucd4 = 0;
                p4_gameplay.internshospitalaucd4 = 0;
                p4_gameplay.nationalhealthhospitalaucd4 = 0;
                p4_gameplay.veteranshospitalaucd4 = 0;
                p4_gameplay.pearlmallaucd4 = 0;
                p4_gameplay.megamallaucd4 = 0;
                p4_gameplay.articmallaucd4 = 0;
                p4_gameplay.heavenlymallaucd4 = 0;
                p4_gameplay.shangrillamallaucd4 = 0;
                p4_gameplay.utility4x1aucd4 = 0;
                p4_gameplay.utility4x2aucd4 = 0;
                p4_gameplay.transportation4x1aucd4 = 0;
                p4_gameplay.transportation4x2aucd4 = 0;
                p4_gameplay.transportation4x3aucd4 = 0;
                p4_gameplay.transportation4x4aucd4 = 0;

                //auction
                p4_gameplay.easternschoolauc1 = 0;
                p4_gameplay.westernschoolauc1 = 0;
                p4_gameplay.visayashighschoolauc1 = 0;
                p4_gameplay.southernschoolauc1 = 0;
                p4_gameplay.nationsschoolauc1 = 0;
                p4_gameplay.westmarketauc1 = 0;
                p4_gameplay.nightmarketauc1 = 0;
                p4_gameplay.daymarketauc1 = 0;
                p4_gameplay.starmarketauc1 = 0;
                p4_gameplay.moonmarketauc1 = 0;
                p4_gameplay.megamarketauc1 = 0;
                p4_gameplay.visayashospitalauc1 = 0;
                p4_gameplay.hobertshospitalauc1 = 0;
                p4_gameplay.heartshospitalauc1 = 0;
                p4_gameplay.internshospitalauc1 = 0;
                p4_gameplay.nationalhealthhospitalauc1 = 0;
                p4_gameplay.veteranshospitalauc1 = 0;
                p4_gameplay.pearlmallauc1 = 0;
                p4_gameplay.megamallauc1 = 0;
                p4_gameplay.articmallauc1 = 0;
                p4_gameplay.heavenlymallauc1 = 0;
                p4_gameplay.shangrillamallauc1 = 0;
                p4_gameplay.utility1x1auc1 = 0;
                p4_gameplay.utility1x2auc1 = 0;
                p4_gameplay.transportation1x1auc1 = 0;
                p4_gameplay.transportation1x2auc1 = 0;
                p4_gameplay.transportation1x3auc1 = 0;
                p4_gameplay.transportation1x4auc1 = 0;


                p4_gameplay.easternschoolauc2 = 0;
                p4_gameplay.westernschoolauc2 = 0;
                p4_gameplay.visayashighschoolauc2 = 0;
                p4_gameplay.southernschoolauc2 = 0;
                p4_gameplay.nationsschoolauc2 = 0;
                p4_gameplay.westmarketauc2 = 0;
                p4_gameplay.nightmarketauc2 = 0;
                p4_gameplay.daymarketauc2 = 0;
                p4_gameplay.starmarketauc2 = 0;
                p4_gameplay.moonmarketauc2 = 0;
                p4_gameplay.megamarketauc2 = 0;
                p4_gameplay.visayashospitalauc2 = 0;
                p4_gameplay.hobertshospitalauc2 = 0;
                p4_gameplay.heartshospitalauc2 = 0;
                p4_gameplay.internshospitalauc2 = 0;
                p4_gameplay.nationalhealthhospitalauc2 = 0;
                p4_gameplay.veteranshospitalauc2 = 0;
                p4_gameplay.pearlmallauc2 = 0;
                p4_gameplay.megamallauc2 = 0;
                p4_gameplay.articmallauc2 = 0;
                p4_gameplay.heavenlymallauc2 = 0;
                p4_gameplay.shangrillamallauc2 = 0;
                p4_gameplay.utility2x1auc2 = 0;
                p4_gameplay.utility2x2auc2 = 0;
                p4_gameplay.transportation2x1auc2 = 0;
                p4_gameplay.transportation2x2auc2 = 0;
                p4_gameplay.transportation2x3auc2 = 0;
                p4_gameplay.transportation2x4auc2 = 0;

                p4_gameplay.easternschoolauc3 = 0;
                p4_gameplay.westernschoolauc3 = 0;
                p4_gameplay.visayashighschoolauc3 = 0;
                p4_gameplay.southernschoolauc3 = 0;
                p4_gameplay.nationsschoolauc3 = 0;
                p4_gameplay.westmarketauc3 = 0;
                p4_gameplay.nightmarketauc3 = 0;
                p4_gameplay.daymarketauc3 = 0;
                p4_gameplay.starmarketauc3 = 0;
                p4_gameplay.moonmarketauc3 = 0;
                p4_gameplay.megamarketauc3 = 0;
                p4_gameplay.visayashospitalauc3 = 0;
                p4_gameplay.hobertshospitalauc3 = 0;
                p4_gameplay.heartshospitalauc3 = 0;
                p4_gameplay.internshospitalauc3 = 0;
                p4_gameplay.nationalhealthhospitalauc3 = 0;
                p4_gameplay.veteranshospitalauc3 = 0;
                p4_gameplay.pearlmallauc3 = 0;
                p4_gameplay.megamallauc3 = 0;
                p4_gameplay.articmallauc3 = 0;
                p4_gameplay.heavenlymallauc3 = 0;
                p4_gameplay.shangrillamallauc3 = 0;
                p4_gameplay.utility3x1auc3 = 0;
                p4_gameplay.utility3x2auc3 = 0;
                p4_gameplay.transportation3x1auc3 = 0;
                p4_gameplay.transportation3x2auc3 = 0;
                p4_gameplay.transportation3x3auc3 = 0;
                p4_gameplay.transportation3x4auc3 = 0;

                p4_gameplay.easternschoolauc4 = 0;
                p4_gameplay.westernschoolauc4 = 0;
                p4_gameplay.visayashighschoolauc4 = 0;
                p4_gameplay.southernschoolauc4 = 0;
                p4_gameplay.nationsschoolauc4 = 0;
                p4_gameplay.westmarketauc4 = 0;
                p4_gameplay.nightmarketauc4 = 0;
                p4_gameplay.daymarketauc4 = 0;
                p4_gameplay.starmarketauc4 = 0;
                p4_gameplay.moonmarketauc4 = 0;
                p4_gameplay.megamarketauc4 = 0;
                p4_gameplay.visayashospitalauc4 = 0;
                p4_gameplay.hobertshospitalauc4 = 0;
                p4_gameplay.heartshospitalauc4 = 0;
                p4_gameplay.internshospitalauc4 = 0;
                p4_gameplay.nationalhealthhospitalauc4 = 0;
                p4_gameplay.veteranshospitalauc4 = 0;
                p4_gameplay.pearlmallauc4 = 0;
                p4_gameplay.megamallauc4 = 0;
                p4_gameplay.articmallauc4 = 0;
                p4_gameplay.heavenlymallauc4 = 0;
                p4_gameplay.shangrillamallauc4 = 0;
                p4_gameplay.utility4x1auc4 = 0;
                p4_gameplay.utility4x2auc4 = 0;
                p4_gameplay.transportation4x1auc4 = 0;
                p4_gameplay.transportation4x2auc4 = 0;
                p4_gameplay.transportation4x3auc4 = 0;
                p4_gameplay.transportation4x4auc4 = 0;
                click.Play();
                this.Close();
            }
            if (p4aucnotif.Text.StartsWith("Player 4 Won with a bid of " + hibid + "php"))
            {
                p4aucch = 1;
                p4_gameplay.easternschoolaucd1 = 0;
                p4_gameplay.westernschoolaucd1 = 0;
                p4_gameplay.visayashighschoolaucd1 = 0;
                p4_gameplay.southernschoolaucd1 = 0;
                p4_gameplay.nationsschoolaucd1 = 0;
                p4_gameplay.westmarketaucd1 = 0;
                p4_gameplay.nightmarketaucd1 = 0;
                p4_gameplay.daymarketaucd1 = 0;
                p4_gameplay.starmarketaucd1 = 0;
                p4_gameplay.moonmarketaucd1 = 0;
                p4_gameplay.megamarketaucd1 = 0;
                p4_gameplay.visayashospitalaucd1 = 0;
                p4_gameplay.hobertshospitalaucd1 = 0;
                p4_gameplay.heartshospitalaucd1 = 0;
                p4_gameplay.internshospitalaucd1 = 0;
                p4_gameplay.nationalhealthhospitalaucd1 = 0;
                p4_gameplay.veteranshospitalaucd1 = 0;
                p4_gameplay.pearlmallaucd1 = 0;
                p4_gameplay.megamallaucd1 = 0;
                p4_gameplay.articmallaucd1 = 0;
                p4_gameplay.heavenlymallaucd1 = 0;
                p4_gameplay.shangrillamallaucd1 = 0;
                p4_gameplay.utility1x1aucd1 = 0;
                p4_gameplay.utility1x2aucd1 = 0;
                p4_gameplay.transportation1x1aucd1 = 0;
                p4_gameplay.transportation1x2aucd1 = 0;
                p4_gameplay.transportation1x3aucd1 = 0;
                p4_gameplay.transportation1x4aucd1 = 0;


                p4_gameplay.easternschoolaucd2 = 0;
                p4_gameplay.westernschoolaucd2 = 0;
                p4_gameplay.visayashighschoolaucd2 = 0;
                p4_gameplay.southernschoolaucd2 = 0;
                p4_gameplay.nationsschoolaucd2 = 0;
                p4_gameplay.westmarketaucd2 = 0;
                p4_gameplay.nightmarketaucd2 = 0;
                p4_gameplay.daymarketaucd2 = 0;
                p4_gameplay.starmarketaucd2 = 0;
                p4_gameplay.moonmarketaucd2 = 0;
                p4_gameplay.megamarketaucd2 = 0;
                p4_gameplay.visayashospitalaucd2 = 0;
                p4_gameplay.hobertshospitalaucd2 = 0;
                p4_gameplay.heartshospitalaucd2 = 0;
                p4_gameplay.internshospitalaucd2 = 0;
                p4_gameplay.nationalhealthhospitalaucd2 = 0;
                p4_gameplay.veteranshospitalaucd2 = 0;
                p4_gameplay.pearlmallaucd2 = 0;
                p4_gameplay.megamallaucd2 = 0;
                p4_gameplay.articmallaucd2 = 0;
                p4_gameplay.heavenlymallaucd2 = 0;
                p4_gameplay.shangrillamallaucd2 = 0;
                p4_gameplay.utility2x1aucd2 = 0;
                p4_gameplay.utility2x2aucd2 = 0;
                p4_gameplay.transportation2x1aucd2 = 0;
                p4_gameplay.transportation2x2aucd2 = 0;
                p4_gameplay.transportation2x3aucd2 = 0;
                p4_gameplay.transportation2x4aucd2 = 0;

                p4_gameplay.easternschoolaucd3 = 0;
                p4_gameplay.westernschoolaucd3 = 0;
                p4_gameplay.visayashighschoolaucd3 = 0;
                p4_gameplay.southernschoolaucd3 = 0;
                p4_gameplay.nationsschoolaucd3 = 0;
                p4_gameplay.westmarketaucd3 = 0;
                p4_gameplay.nightmarketaucd3 = 0;
                p4_gameplay.daymarketaucd3 = 0;
                p4_gameplay.starmarketaucd3 = 0;
                p4_gameplay.moonmarketaucd3 = 0;
                p4_gameplay.megamarketaucd3 = 0;
                p4_gameplay.visayashospitalaucd3 = 0;
                p4_gameplay.hobertshospitalaucd3 = 0;
                p4_gameplay.heartshospitalaucd3 = 0;
                p4_gameplay.internshospitalaucd3 = 0;
                p4_gameplay.nationalhealthhospitalaucd3 = 0;
                p4_gameplay.veteranshospitalaucd3 = 0;
                p4_gameplay.pearlmallaucd3 = 0;
                p4_gameplay.megamallaucd3 = 0;
                p4_gameplay.articmallaucd3 = 0;
                p4_gameplay.heavenlymallaucd3 = 0;
                p4_gameplay.shangrillamallaucd3 = 0;
                p4_gameplay.utility3x1aucd3 = 0;
                p4_gameplay.utility3x2aucd3 = 0;
                p4_gameplay.transportation3x1aucd3 = 0;
                p4_gameplay.transportation3x2aucd3 = 0;
                p4_gameplay.transportation3x3aucd3 = 0;
                p4_gameplay.transportation3x4aucd3 = 0;

                p4_gameplay.easternschoolaucd4 = 0;
                p4_gameplay.westernschoolaucd4 = 0;
                p4_gameplay.visayashighschoolaucd4 = 0;
                p4_gameplay.southernschoolaucd4 = 0;
                p4_gameplay.nationsschoolaucd4 = 0;
                p4_gameplay.westmarketaucd4 = 0;
                p4_gameplay.nightmarketaucd4 = 0;
                p4_gameplay.daymarketaucd4 = 0;
                p4_gameplay.starmarketaucd4 = 0;
                p4_gameplay.moonmarketaucd4 = 0;
                p4_gameplay.megamarketaucd4 = 0;
                p4_gameplay.visayashospitalaucd4 = 0;
                p4_gameplay.hobertshospitalaucd4 = 0;
                p4_gameplay.heartshospitalaucd4 = 0;
                p4_gameplay.internshospitalaucd4 = 0;
                p4_gameplay.nationalhealthhospitalaucd4 = 0;
                p4_gameplay.veteranshospitalaucd4 = 0;
                p4_gameplay.pearlmallaucd4 = 0;
                p4_gameplay.megamallaucd4 = 0;
                p4_gameplay.articmallaucd4 = 0;
                p4_gameplay.heavenlymallaucd4 = 0;
                p4_gameplay.shangrillamallaucd4 = 0;
                p4_gameplay.utility4x1aucd4 = 0;
                p4_gameplay.utility4x2aucd4 = 0;
                p4_gameplay.transportation4x1aucd4 = 0;
                p4_gameplay.transportation4x2aucd4 = 0;
                p4_gameplay.transportation4x3aucd4 = 0;
                p4_gameplay.transportation4x4aucd4 = 0;

                //auction
                p4_gameplay.easternschoolauc1 = 0;
                p4_gameplay.westernschoolauc1 = 0;
                p4_gameplay.visayashighschoolauc1 = 0;
                p4_gameplay.southernschoolauc1 = 0;
                p4_gameplay.nationsschoolauc1 = 0;
                p4_gameplay.westmarketauc1 = 0;
                p4_gameplay.nightmarketauc1 = 0;
                p4_gameplay.daymarketauc1 = 0;
                p4_gameplay.starmarketauc1 = 0;
                p4_gameplay.moonmarketauc1 = 0;
                p4_gameplay.megamarketauc1 = 0;
                p4_gameplay.visayashospitalauc1 = 0;
                p4_gameplay.hobertshospitalauc1 = 0;
                p4_gameplay.heartshospitalauc1 = 0;
                p4_gameplay.internshospitalauc1 = 0;
                p4_gameplay.nationalhealthhospitalauc1 = 0;
                p4_gameplay.veteranshospitalauc1 = 0;
                p4_gameplay.pearlmallauc1 = 0;
                p4_gameplay.megamallauc1 = 0;
                p4_gameplay.articmallauc1 = 0;
                p4_gameplay.heavenlymallauc1 = 0;
                p4_gameplay.shangrillamallauc1 = 0;
                p4_gameplay.utility1x1auc1 = 0;
                p4_gameplay.utility1x2auc1 = 0;
                p4_gameplay.transportation1x1auc1 = 0;
                p4_gameplay.transportation1x2auc1 = 0;
                p4_gameplay.transportation1x3auc1 = 0;
                p4_gameplay.transportation1x4auc1 = 0;


                p4_gameplay.easternschoolauc2 = 0;
                p4_gameplay.westernschoolauc2 = 0;
                p4_gameplay.visayashighschoolauc2 = 0;
                p4_gameplay.southernschoolauc2 = 0;
                p4_gameplay.nationsschoolauc2 = 0;
                p4_gameplay.westmarketauc2 = 0;
                p4_gameplay.nightmarketauc2 = 0;
                p4_gameplay.daymarketauc2 = 0;
                p4_gameplay.starmarketauc2 = 0;
                p4_gameplay.moonmarketauc2 = 0;
                p4_gameplay.megamarketauc2 = 0;
                p4_gameplay.visayashospitalauc2 = 0;
                p4_gameplay.hobertshospitalauc2 = 0;
                p4_gameplay.heartshospitalauc2 = 0;
                p4_gameplay.internshospitalauc2 = 0;
                p4_gameplay.nationalhealthhospitalauc2 = 0;
                p4_gameplay.veteranshospitalauc2 = 0;
                p4_gameplay.pearlmallauc2 = 0;
                p4_gameplay.megamallauc2 = 0;
                p4_gameplay.articmallauc2 = 0;
                p4_gameplay.heavenlymallauc2 = 0;
                p4_gameplay.shangrillamallauc2 = 0;
                p4_gameplay.utility2x1auc2 = 0;
                p4_gameplay.utility2x2auc2 = 0;
                p4_gameplay.transportation2x1auc2 = 0;
                p4_gameplay.transportation2x2auc2 = 0;
                p4_gameplay.transportation2x3auc2 = 0;
                p4_gameplay.transportation2x4auc2 = 0;

                p4_gameplay.easternschoolauc3 = 0;
                p4_gameplay.westernschoolauc3 = 0;
                p4_gameplay.visayashighschoolauc3 = 0;
                p4_gameplay.southernschoolauc3 = 0;
                p4_gameplay.nationsschoolauc3 = 0;
                p4_gameplay.westmarketauc3 = 0;
                p4_gameplay.nightmarketauc3 = 0;
                p4_gameplay.daymarketauc3 = 0;
                p4_gameplay.starmarketauc3 = 0;
                p4_gameplay.moonmarketauc3 = 0;
                p4_gameplay.megamarketauc3 = 0;
                p4_gameplay.visayashospitalauc3 = 0;
                p4_gameplay.hobertshospitalauc3 = 0;
                p4_gameplay.heartshospitalauc3 = 0;
                p4_gameplay.internshospitalauc3 = 0;
                p4_gameplay.nationalhealthhospitalauc3 = 0;
                p4_gameplay.veteranshospitalauc3 = 0;
                p4_gameplay.pearlmallauc3 = 0;
                p4_gameplay.megamallauc3 = 0;
                p4_gameplay.articmallauc3 = 0;
                p4_gameplay.heavenlymallauc3 = 0;
                p4_gameplay.shangrillamallauc3 = 0;
                p4_gameplay.utility3x1auc3 = 0;
                p4_gameplay.utility3x2auc3 = 0;
                p4_gameplay.transportation3x1auc3 = 0;
                p4_gameplay.transportation3x2auc3 = 0;
                p4_gameplay.transportation3x3auc3 = 0;
                p4_gameplay.transportation3x4auc3 = 0;

                p4_gameplay.easternschoolauc4 = 0;
                p4_gameplay.westernschoolauc4 = 0;
                p4_gameplay.visayashighschoolauc4 = 0;
                p4_gameplay.southernschoolauc4 = 0;
                p4_gameplay.nationsschoolauc4 = 0;
                p4_gameplay.westmarketauc4 = 0;
                p4_gameplay.nightmarketauc4 = 0;
                p4_gameplay.daymarketauc4 = 0;
                p4_gameplay.starmarketauc4 = 0;
                p4_gameplay.moonmarketauc4 = 0;
                p4_gameplay.megamarketauc4 = 0;
                p4_gameplay.visayashospitalauc4 = 0;
                p4_gameplay.hobertshospitalauc4 = 0;
                p4_gameplay.heartshospitalauc4 = 0;
                p4_gameplay.internshospitalauc4 = 0;
                p4_gameplay.nationalhealthhospitalauc4 = 0;
                p4_gameplay.veteranshospitalauc4 = 0;
                p4_gameplay.pearlmallauc4 = 0;
                p4_gameplay.megamallauc4 = 0;
                p4_gameplay.articmallauc4 = 0;
                p4_gameplay.heavenlymallauc4 = 0;
                p4_gameplay.shangrillamallauc4 = 0;
                p4_gameplay.utility4x1auc4 = 0;
                p4_gameplay.utility4x2auc4 = 0;
                p4_gameplay.transportation4x1auc4 = 0;
                p4_gameplay.transportation4x2auc4 = 0;
                p4_gameplay.transportation4x3auc4 = 0;
                p4_gameplay.transportation4x4auc4 = 0;
                click.Play();
                this.Close();
            }
        }

        private void btnacc1_Click(object sender, EventArgs e)
        {

            if (p1aucnotif.Text.StartsWith("Player 1's turn"))
            {
                notif1.Visible = false;
                btnp1.Enabled = true;
                p1auced = 0;
                p2auced = 0;
                p3auced = 0;
                p4auced = 0;
                colorturn();
                guide();
                click.Play();
            }
            if (p1aucnotif.Text.StartsWith("Click the top-hat icon \r\nto the corner bottom-left side to show control-panel"))
            {
                notif1.Visible = false;
                btnp1.Enabled = true;
                tip1.Visible = true;
                click.Play();
            }
            if (p1aucnotif.Text.StartsWith("To bid a price, \r\nthe price must be greater than the highest bid or atleast " + minprice + "php"))
            {
                notif1.Visible = false;
                p1auc.Enabled = true;
                tip1.Visible = true;
                click.Play();
            }
            if (p1aucnotif.Text.StartsWith("Do you want to leave auction?"))
            {
                p1quit1 = 1;
                btnp1.Enabled = false;
                notif1.Visible = false;
                tip1.Visible = false;
                if (p1quit1 == 1)
                {
                    btnp1.Enabled = false;
                    p1auc.Visible = false;
                    turns1();
                    p1auc.Visible = false;
                    auc1.Visible = false;
                    guide();
                    tip1.Visible = false;
                    turnss();
                    p1timer.Stop();
                    quit();
                    quitbidding();
                    bugsaverquit();
                    click.Play();
                }
                if (p1quit1 == 1 && p1quit4 == 1)
                {
                    btnp1.Enabled = false;
                    btnp2.Enabled = true;
                    p1auc.Visible = false;
                    turns1();
                    p1auc.Visible = false;
                    auc1.Visible = false;
                    guide();
                    tip1.Visible = false;
                    turnss();
                    p1timer.Stop();
                    quit();
                    quitbidding();
                    bugsaverquit();
                    guide();
                    click.Play();
                }


                click.Play();
            }
            if (p1aucnotif.Text.StartsWith("The Auction has been cancelled"))
            {
                p4aucch = 1;
                p4_gameplay.easternschoolaucd1 = 0;
                p4_gameplay.westernschoolaucd1 = 0;
                p4_gameplay.visayashighschoolaucd1 = 0;
                p4_gameplay.southernschoolaucd1 = 0;
                p4_gameplay.nationsschoolaucd1 = 0;
                p4_gameplay.westmarketaucd1 = 0;
                p4_gameplay.nightmarketaucd1 = 0;
                p4_gameplay.daymarketaucd1 = 0;
                p4_gameplay.starmarketaucd1 = 0;
                p4_gameplay.moonmarketaucd1 = 0;
                p4_gameplay.megamarketaucd1 = 0;
                p4_gameplay.visayashospitalaucd1 = 0;
                p4_gameplay.hobertshospitalaucd1 = 0;
                p4_gameplay.heartshospitalaucd1 = 0;
                p4_gameplay.internshospitalaucd1 = 0;
                p4_gameplay.nationalhealthhospitalaucd1 = 0;
                p4_gameplay.veteranshospitalaucd1 = 0;
                p4_gameplay.pearlmallaucd1 = 0;
                p4_gameplay.megamallaucd1 = 0;
                p4_gameplay.articmallaucd1 = 0;
                p4_gameplay.heavenlymallaucd1 = 0;
                p4_gameplay.shangrillamallaucd1 = 0;
                p4_gameplay.utility1x1aucd1 = 0;
                p4_gameplay.utility1x2aucd1 = 0;
                p4_gameplay.transportation1x1aucd1 = 0;
                p4_gameplay.transportation1x2aucd1 = 0;
                p4_gameplay.transportation1x3aucd1 = 0;
                p4_gameplay.transportation1x4aucd1 = 0;


                p4_gameplay.easternschoolaucd2 = 0;
                p4_gameplay.westernschoolaucd2 = 0;
                p4_gameplay.visayashighschoolaucd2 = 0;
                p4_gameplay.southernschoolaucd2 = 0;
                p4_gameplay.nationsschoolaucd2 = 0;
                p4_gameplay.westmarketaucd2 = 0;
                p4_gameplay.nightmarketaucd2 = 0;
                p4_gameplay.daymarketaucd2 = 0;
                p4_gameplay.starmarketaucd2 = 0;
                p4_gameplay.moonmarketaucd2 = 0;
                p4_gameplay.megamarketaucd2 = 0;
                p4_gameplay.visayashospitalaucd2 = 0;
                p4_gameplay.hobertshospitalaucd2 = 0;
                p4_gameplay.heartshospitalaucd2 = 0;
                p4_gameplay.internshospitalaucd2 = 0;
                p4_gameplay.nationalhealthhospitalaucd2 = 0;
                p4_gameplay.veteranshospitalaucd2 = 0;
                p4_gameplay.pearlmallaucd2 = 0;
                p4_gameplay.megamallaucd2 = 0;
                p4_gameplay.articmallaucd2 = 0;
                p4_gameplay.heavenlymallaucd2 = 0;
                p4_gameplay.shangrillamallaucd2 = 0;
                p4_gameplay.utility2x1aucd2 = 0;
                p4_gameplay.utility2x2aucd2 = 0;
                p4_gameplay.transportation2x1aucd2 = 0;
                p4_gameplay.transportation2x2aucd2 = 0;
                p4_gameplay.transportation2x3aucd2 = 0;
                p4_gameplay.transportation2x4aucd2 = 0;

                p4_gameplay.easternschoolaucd3 = 0;
                p4_gameplay.westernschoolaucd3 = 0;
                p4_gameplay.visayashighschoolaucd3 = 0;
                p4_gameplay.southernschoolaucd3 = 0;
                p4_gameplay.nationsschoolaucd3 = 0;
                p4_gameplay.westmarketaucd3 = 0;
                p4_gameplay.nightmarketaucd3 = 0;
                p4_gameplay.daymarketaucd3 = 0;
                p4_gameplay.starmarketaucd3 = 0;
                p4_gameplay.moonmarketaucd3 = 0;
                p4_gameplay.megamarketaucd3 = 0;
                p4_gameplay.visayashospitalaucd3 = 0;
                p4_gameplay.hobertshospitalaucd3 = 0;
                p4_gameplay.heartshospitalaucd3 = 0;
                p4_gameplay.internshospitalaucd3 = 0;
                p4_gameplay.nationalhealthhospitalaucd3 = 0;
                p4_gameplay.veteranshospitalaucd3 = 0;
                p4_gameplay.pearlmallaucd3 = 0;
                p4_gameplay.megamallaucd3 = 0;
                p4_gameplay.articmallaucd3 = 0;
                p4_gameplay.heavenlymallaucd3 = 0;
                p4_gameplay.shangrillamallaucd3 = 0;
                p4_gameplay.utility3x1aucd3 = 0;
                p4_gameplay.utility3x2aucd3 = 0;
                p4_gameplay.transportation3x1aucd3 = 0;
                p4_gameplay.transportation3x2aucd3 = 0;
                p4_gameplay.transportation3x3aucd3 = 0;
                p4_gameplay.transportation3x4aucd3 = 0;

                p4_gameplay.easternschoolaucd4 = 0;
                p4_gameplay.westernschoolaucd4 = 0;
                p4_gameplay.visayashighschoolaucd4 = 0;
                p4_gameplay.southernschoolaucd4 = 0;
                p4_gameplay.nationsschoolaucd4 = 0;
                p4_gameplay.westmarketaucd4 = 0;
                p4_gameplay.nightmarketaucd4 = 0;
                p4_gameplay.daymarketaucd4 = 0;
                p4_gameplay.starmarketaucd4 = 0;
                p4_gameplay.moonmarketaucd4 = 0;
                p4_gameplay.megamarketaucd4 = 0;
                p4_gameplay.visayashospitalaucd4 = 0;
                p4_gameplay.hobertshospitalaucd4 = 0;
                p4_gameplay.heartshospitalaucd4 = 0;
                p4_gameplay.internshospitalaucd4 = 0;
                p4_gameplay.nationalhealthhospitalaucd4 = 0;
                p4_gameplay.veteranshospitalaucd4 = 0;
                p4_gameplay.pearlmallaucd4 = 0;
                p4_gameplay.megamallaucd4 = 0;
                p4_gameplay.articmallaucd4 = 0;
                p4_gameplay.heavenlymallaucd4 = 0;
                p4_gameplay.shangrillamallaucd4 = 0;
                p4_gameplay.utility4x1aucd4 = 0;
                p4_gameplay.utility4x2aucd4 = 0;
                p4_gameplay.transportation4x1aucd4 = 0;
                p4_gameplay.transportation4x2aucd4 = 0;
                p4_gameplay.transportation4x3aucd4 = 0;
                p4_gameplay.transportation4x4aucd4 = 0;

                //auction
                p4_gameplay.easternschoolauc1 = 0;
                p4_gameplay.westernschoolauc1 = 0;
                p4_gameplay.visayashighschoolauc1 = 0;
                p4_gameplay.southernschoolauc1 = 0;
                p4_gameplay.nationsschoolauc1 = 0;
                p4_gameplay.westmarketauc1 = 0;
                p4_gameplay.nightmarketauc1 = 0;
                p4_gameplay.daymarketauc1 = 0;
                p4_gameplay.starmarketauc1 = 0;
                p4_gameplay.moonmarketauc1 = 0;
                p4_gameplay.megamarketauc1 = 0;
                p4_gameplay.visayashospitalauc1 = 0;
                p4_gameplay.hobertshospitalauc1 = 0;
                p4_gameplay.heartshospitalauc1 = 0;
                p4_gameplay.internshospitalauc1 = 0;
                p4_gameplay.nationalhealthhospitalauc1 = 0;
                p4_gameplay.veteranshospitalauc1 = 0;
                p4_gameplay.pearlmallauc1 = 0;
                p4_gameplay.megamallauc1 = 0;
                p4_gameplay.articmallauc1 = 0;
                p4_gameplay.heavenlymallauc1 = 0;
                p4_gameplay.shangrillamallauc1 = 0;
                p4_gameplay.utility1x1auc1 = 0;
                p4_gameplay.utility1x2auc1 = 0;
                p4_gameplay.transportation1x1auc1 = 0;
                p4_gameplay.transportation1x2auc1 = 0;
                p4_gameplay.transportation1x3auc1 = 0;
                p4_gameplay.transportation1x4auc1 = 0;


                p4_gameplay.easternschoolauc2 = 0;
                p4_gameplay.westernschoolauc2 = 0;
                p4_gameplay.visayashighschoolauc2 = 0;
                p4_gameplay.southernschoolauc2 = 0;
                p4_gameplay.nationsschoolauc2 = 0;
                p4_gameplay.westmarketauc2 = 0;
                p4_gameplay.nightmarketauc2 = 0;
                p4_gameplay.daymarketauc2 = 0;
                p4_gameplay.starmarketauc2 = 0;
                p4_gameplay.moonmarketauc2 = 0;
                p4_gameplay.megamarketauc2 = 0;
                p4_gameplay.visayashospitalauc2 = 0;
                p4_gameplay.hobertshospitalauc2 = 0;
                p4_gameplay.heartshospitalauc2 = 0;
                p4_gameplay.internshospitalauc2 = 0;
                p4_gameplay.nationalhealthhospitalauc2 = 0;
                p4_gameplay.veteranshospitalauc2 = 0;
                p4_gameplay.pearlmallauc2 = 0;
                p4_gameplay.megamallauc2 = 0;
                p4_gameplay.articmallauc2 = 0;
                p4_gameplay.heavenlymallauc2 = 0;
                p4_gameplay.shangrillamallauc2 = 0;
                p4_gameplay.utility2x1auc2 = 0;
                p4_gameplay.utility2x2auc2 = 0;
                p4_gameplay.transportation2x1auc2 = 0;
                p4_gameplay.transportation2x2auc2 = 0;
                p4_gameplay.transportation2x3auc2 = 0;
                p4_gameplay.transportation2x4auc2 = 0;

                p4_gameplay.easternschoolauc3 = 0;
                p4_gameplay.westernschoolauc3 = 0;
                p4_gameplay.visayashighschoolauc3 = 0;
                p4_gameplay.southernschoolauc3 = 0;
                p4_gameplay.nationsschoolauc3 = 0;
                p4_gameplay.westmarketauc3 = 0;
                p4_gameplay.nightmarketauc3 = 0;
                p4_gameplay.daymarketauc3 = 0;
                p4_gameplay.starmarketauc3 = 0;
                p4_gameplay.moonmarketauc3 = 0;
                p4_gameplay.megamarketauc3 = 0;
                p4_gameplay.visayashospitalauc3 = 0;
                p4_gameplay.hobertshospitalauc3 = 0;
                p4_gameplay.heartshospitalauc3 = 0;
                p4_gameplay.internshospitalauc3 = 0;
                p4_gameplay.nationalhealthhospitalauc3 = 0;
                p4_gameplay.veteranshospitalauc3 = 0;
                p4_gameplay.pearlmallauc3 = 0;
                p4_gameplay.megamallauc3 = 0;
                p4_gameplay.articmallauc3 = 0;
                p4_gameplay.heavenlymallauc3 = 0;
                p4_gameplay.shangrillamallauc3 = 0;
                p4_gameplay.utility3x1auc3 = 0;
                p4_gameplay.utility3x2auc3 = 0;
                p4_gameplay.transportation3x1auc3 = 0;
                p4_gameplay.transportation3x2auc3 = 0;
                p4_gameplay.transportation3x3auc3 = 0;
                p4_gameplay.transportation3x4auc3 = 0;

                p4_gameplay.easternschoolauc4 = 0;
                p4_gameplay.westernschoolauc4 = 0;
                p4_gameplay.visayashighschoolauc4 = 0;
                p4_gameplay.southernschoolauc4 = 0;
                p4_gameplay.nationsschoolauc4 = 0;
                p4_gameplay.westmarketauc4 = 0;
                p4_gameplay.nightmarketauc4 = 0;
                p4_gameplay.daymarketauc4 = 0;
                p4_gameplay.starmarketauc4 = 0;
                p4_gameplay.moonmarketauc4 = 0;
                p4_gameplay.megamarketauc4 = 0;
                p4_gameplay.visayashospitalauc4 = 0;
                p4_gameplay.hobertshospitalauc4 = 0;
                p4_gameplay.heartshospitalauc4 = 0;
                p4_gameplay.internshospitalauc4 = 0;
                p4_gameplay.nationalhealthhospitalauc4 = 0;
                p4_gameplay.veteranshospitalauc4 = 0;
                p4_gameplay.pearlmallauc4 = 0;
                p4_gameplay.megamallauc4 = 0;
                p4_gameplay.articmallauc4 = 0;
                p4_gameplay.heavenlymallauc4 = 0;
                p4_gameplay.shangrillamallauc4 = 0;
                p4_gameplay.utility4x1auc4 = 0;
                p4_gameplay.utility4x2auc4 = 0;
                p4_gameplay.transportation4x1auc4 = 0;
                p4_gameplay.transportation4x2auc4 = 0;
                p4_gameplay.transportation4x3auc4 = 0;
                p4_gameplay.transportation4x4auc4 = 0;
                this.Close();
                click.Play();
            }
            if (p1aucnotif.Text.StartsWith("Player 1 Won with a bid of " + hibid + "php"))
            {
                p4aucch = 1;
                p4_gameplay.easternschoolaucd1 = 0;
                p4_gameplay.westernschoolaucd1 = 0;
                p4_gameplay.visayashighschoolaucd1 = 0;
                p4_gameplay.southernschoolaucd1 = 0;
                p4_gameplay.nationsschoolaucd1 = 0;
                p4_gameplay.westmarketaucd1 = 0;
                p4_gameplay.nightmarketaucd1 = 0;
                p4_gameplay.daymarketaucd1 = 0;
                p4_gameplay.starmarketaucd1 = 0;
                p4_gameplay.moonmarketaucd1 = 0;
                p4_gameplay.megamarketaucd1 = 0;
                p4_gameplay.visayashospitalaucd1 = 0;
                p4_gameplay.hobertshospitalaucd1 = 0;
                p4_gameplay.heartshospitalaucd1 = 0;
                p4_gameplay.internshospitalaucd1 = 0;
                p4_gameplay.nationalhealthhospitalaucd1 = 0;
                p4_gameplay.veteranshospitalaucd1 = 0;
                p4_gameplay.pearlmallaucd1 = 0;
                p4_gameplay.megamallaucd1 = 0;
                p4_gameplay.articmallaucd1 = 0;
                p4_gameplay.heavenlymallaucd1 = 0;
                p4_gameplay.shangrillamallaucd1 = 0;
                p4_gameplay.utility1x1aucd1 = 0;
                p4_gameplay.utility1x2aucd1 = 0;
                p4_gameplay.transportation1x1aucd1 = 0;
                p4_gameplay.transportation1x2aucd1 = 0;
                p4_gameplay.transportation1x3aucd1 = 0;
                p4_gameplay.transportation1x4aucd1 = 0;


                p4_gameplay.easternschoolaucd2 = 0;
                p4_gameplay.westernschoolaucd2 = 0;
                p4_gameplay.visayashighschoolaucd2 = 0;
                p4_gameplay.southernschoolaucd2 = 0;
                p4_gameplay.nationsschoolaucd2 = 0;
                p4_gameplay.westmarketaucd2 = 0;
                p4_gameplay.nightmarketaucd2 = 0;
                p4_gameplay.daymarketaucd2 = 0;
                p4_gameplay.starmarketaucd2 = 0;
                p4_gameplay.moonmarketaucd2 = 0;
                p4_gameplay.megamarketaucd2 = 0;
                p4_gameplay.visayashospitalaucd2 = 0;
                p4_gameplay.hobertshospitalaucd2 = 0;
                p4_gameplay.heartshospitalaucd2 = 0;
                p4_gameplay.internshospitalaucd2 = 0;
                p4_gameplay.nationalhealthhospitalaucd2 = 0;
                p4_gameplay.veteranshospitalaucd2 = 0;
                p4_gameplay.pearlmallaucd2 = 0;
                p4_gameplay.megamallaucd2 = 0;
                p4_gameplay.articmallaucd2 = 0;
                p4_gameplay.heavenlymallaucd2 = 0;
                p4_gameplay.shangrillamallaucd2 = 0;
                p4_gameplay.utility2x1aucd2 = 0;
                p4_gameplay.utility2x2aucd2 = 0;
                p4_gameplay.transportation2x1aucd2 = 0;
                p4_gameplay.transportation2x2aucd2 = 0;
                p4_gameplay.transportation2x3aucd2 = 0;
                p4_gameplay.transportation2x4aucd2 = 0;

                p4_gameplay.easternschoolaucd3 = 0;
                p4_gameplay.westernschoolaucd3 = 0;
                p4_gameplay.visayashighschoolaucd3 = 0;
                p4_gameplay.southernschoolaucd3 = 0;
                p4_gameplay.nationsschoolaucd3 = 0;
                p4_gameplay.westmarketaucd3 = 0;
                p4_gameplay.nightmarketaucd3 = 0;
                p4_gameplay.daymarketaucd3 = 0;
                p4_gameplay.starmarketaucd3 = 0;
                p4_gameplay.moonmarketaucd3 = 0;
                p4_gameplay.megamarketaucd3 = 0;
                p4_gameplay.visayashospitalaucd3 = 0;
                p4_gameplay.hobertshospitalaucd3 = 0;
                p4_gameplay.heartshospitalaucd3 = 0;
                p4_gameplay.internshospitalaucd3 = 0;
                p4_gameplay.nationalhealthhospitalaucd3 = 0;
                p4_gameplay.veteranshospitalaucd3 = 0;
                p4_gameplay.pearlmallaucd3 = 0;
                p4_gameplay.megamallaucd3 = 0;
                p4_gameplay.articmallaucd3 = 0;
                p4_gameplay.heavenlymallaucd3 = 0;
                p4_gameplay.shangrillamallaucd3 = 0;
                p4_gameplay.utility3x1aucd3 = 0;
                p4_gameplay.utility3x2aucd3 = 0;
                p4_gameplay.transportation3x1aucd3 = 0;
                p4_gameplay.transportation3x2aucd3 = 0;
                p4_gameplay.transportation3x3aucd3 = 0;
                p4_gameplay.transportation3x4aucd3 = 0;

                p4_gameplay.easternschoolaucd4 = 0;
                p4_gameplay.westernschoolaucd4 = 0;
                p4_gameplay.visayashighschoolaucd4 = 0;
                p4_gameplay.southernschoolaucd4 = 0;
                p4_gameplay.nationsschoolaucd4 = 0;
                p4_gameplay.westmarketaucd4 = 0;
                p4_gameplay.nightmarketaucd4 = 0;
                p4_gameplay.daymarketaucd4 = 0;
                p4_gameplay.starmarketaucd4 = 0;
                p4_gameplay.moonmarketaucd4 = 0;
                p4_gameplay.megamarketaucd4 = 0;
                p4_gameplay.visayashospitalaucd4 = 0;
                p4_gameplay.hobertshospitalaucd4 = 0;
                p4_gameplay.heartshospitalaucd4 = 0;
                p4_gameplay.internshospitalaucd4 = 0;
                p4_gameplay.nationalhealthhospitalaucd4 = 0;
                p4_gameplay.veteranshospitalaucd4 = 0;
                p4_gameplay.pearlmallaucd4 = 0;
                p4_gameplay.megamallaucd4 = 0;
                p4_gameplay.articmallaucd4 = 0;
                p4_gameplay.heavenlymallaucd4 = 0;
                p4_gameplay.shangrillamallaucd4 = 0;
                p4_gameplay.utility4x1aucd4 = 0;
                p4_gameplay.utility4x2aucd4 = 0;
                p4_gameplay.transportation4x1aucd4 = 0;
                p4_gameplay.transportation4x2aucd4 = 0;
                p4_gameplay.transportation4x3aucd4 = 0;
                p4_gameplay.transportation4x4aucd4 = 0;

                //auction
                p4_gameplay.easternschoolauc1 = 0;
                p4_gameplay.westernschoolauc1 = 0;
                p4_gameplay.visayashighschoolauc1 = 0;
                p4_gameplay.southernschoolauc1 = 0;
                p4_gameplay.nationsschoolauc1 = 0;
                p4_gameplay.westmarketauc1 = 0;
                p4_gameplay.nightmarketauc1 = 0;
                p4_gameplay.daymarketauc1 = 0;
                p4_gameplay.starmarketauc1 = 0;
                p4_gameplay.moonmarketauc1 = 0;
                p4_gameplay.megamarketauc1 = 0;
                p4_gameplay.visayashospitalauc1 = 0;
                p4_gameplay.hobertshospitalauc1 = 0;
                p4_gameplay.heartshospitalauc1 = 0;
                p4_gameplay.internshospitalauc1 = 0;
                p4_gameplay.nationalhealthhospitalauc1 = 0;
                p4_gameplay.veteranshospitalauc1 = 0;
                p4_gameplay.pearlmallauc1 = 0;
                p4_gameplay.megamallauc1 = 0;
                p4_gameplay.articmallauc1 = 0;
                p4_gameplay.heavenlymallauc1 = 0;
                p4_gameplay.shangrillamallauc1 = 0;
                p4_gameplay.utility1x1auc1 = 0;
                p4_gameplay.utility1x2auc1 = 0;
                p4_gameplay.transportation1x1auc1 = 0;
                p4_gameplay.transportation1x2auc1 = 0;
                p4_gameplay.transportation1x3auc1 = 0;
                p4_gameplay.transportation1x4auc1 = 0;


                p4_gameplay.easternschoolauc2 = 0;
                p4_gameplay.westernschoolauc2 = 0;
                p4_gameplay.visayashighschoolauc2 = 0;
                p4_gameplay.southernschoolauc2 = 0;
                p4_gameplay.nationsschoolauc2 = 0;
                p4_gameplay.westmarketauc2 = 0;
                p4_gameplay.nightmarketauc2 = 0;
                p4_gameplay.daymarketauc2 = 0;
                p4_gameplay.starmarketauc2 = 0;
                p4_gameplay.moonmarketauc2 = 0;
                p4_gameplay.megamarketauc2 = 0;
                p4_gameplay.visayashospitalauc2 = 0;
                p4_gameplay.hobertshospitalauc2 = 0;
                p4_gameplay.heartshospitalauc2 = 0;
                p4_gameplay.internshospitalauc2 = 0;
                p4_gameplay.nationalhealthhospitalauc2 = 0;
                p4_gameplay.veteranshospitalauc2 = 0;
                p4_gameplay.pearlmallauc2 = 0;
                p4_gameplay.megamallauc2 = 0;
                p4_gameplay.articmallauc2 = 0;
                p4_gameplay.heavenlymallauc2 = 0;
                p4_gameplay.shangrillamallauc2 = 0;
                p4_gameplay.utility2x1auc2 = 0;
                p4_gameplay.utility2x2auc2 = 0;
                p4_gameplay.transportation2x1auc2 = 0;
                p4_gameplay.transportation2x2auc2 = 0;
                p4_gameplay.transportation2x3auc2 = 0;
                p4_gameplay.transportation2x4auc2 = 0;

                p4_gameplay.easternschoolauc3 = 0;
                p4_gameplay.westernschoolauc3 = 0;
                p4_gameplay.visayashighschoolauc3 = 0;
                p4_gameplay.southernschoolauc3 = 0;
                p4_gameplay.nationsschoolauc3 = 0;
                p4_gameplay.westmarketauc3 = 0;
                p4_gameplay.nightmarketauc3 = 0;
                p4_gameplay.daymarketauc3 = 0;
                p4_gameplay.starmarketauc3 = 0;
                p4_gameplay.moonmarketauc3 = 0;
                p4_gameplay.megamarketauc3 = 0;
                p4_gameplay.visayashospitalauc3 = 0;
                p4_gameplay.hobertshospitalauc3 = 0;
                p4_gameplay.heartshospitalauc3 = 0;
                p4_gameplay.internshospitalauc3 = 0;
                p4_gameplay.nationalhealthhospitalauc3 = 0;
                p4_gameplay.veteranshospitalauc3 = 0;
                p4_gameplay.pearlmallauc3 = 0;
                p4_gameplay.megamallauc3 = 0;
                p4_gameplay.articmallauc3 = 0;
                p4_gameplay.heavenlymallauc3 = 0;
                p4_gameplay.shangrillamallauc3 = 0;
                p4_gameplay.utility3x1auc3 = 0;
                p4_gameplay.utility3x2auc3 = 0;
                p4_gameplay.transportation3x1auc3 = 0;
                p4_gameplay.transportation3x2auc3 = 0;
                p4_gameplay.transportation3x3auc3 = 0;
                p4_gameplay.transportation3x4auc3 = 0;

                p4_gameplay.easternschoolauc4 = 0;
                p4_gameplay.westernschoolauc4 = 0;
                p4_gameplay.visayashighschoolauc4 = 0;
                p4_gameplay.southernschoolauc4 = 0;
                p4_gameplay.nationsschoolauc4 = 0;
                p4_gameplay.westmarketauc4 = 0;
                p4_gameplay.nightmarketauc4 = 0;
                p4_gameplay.daymarketauc4 = 0;
                p4_gameplay.starmarketauc4 = 0;
                p4_gameplay.moonmarketauc4 = 0;
                p4_gameplay.megamarketauc4 = 0;
                p4_gameplay.visayashospitalauc4 = 0;
                p4_gameplay.hobertshospitalauc4 = 0;
                p4_gameplay.heartshospitalauc4 = 0;
                p4_gameplay.internshospitalauc4 = 0;
                p4_gameplay.nationalhealthhospitalauc4 = 0;
                p4_gameplay.veteranshospitalauc4 = 0;
                p4_gameplay.pearlmallauc4 = 0;
                p4_gameplay.megamallauc4 = 0;
                p4_gameplay.articmallauc4 = 0;
                p4_gameplay.heavenlymallauc4 = 0;
                p4_gameplay.shangrillamallauc4 = 0;
                p4_gameplay.utility4x1auc4 = 0;
                p4_gameplay.utility4x2auc4 = 0;
                p4_gameplay.transportation4x1auc4 = 0;
                p4_gameplay.transportation4x2auc4 = 0;
                p4_gameplay.transportation4x3auc4 = 0;
                p4_gameplay.transportation4x4auc4 = 0;
                click.Play();
                this.Close();
            }

        }

        private void btnacc3_Click(object sender, EventArgs e)
        {
            if (p3aucnotif.Text.StartsWith("Player 3's turn"))
            {
                notif3.Visible = false;
                btnp3.Enabled = true;
                p1auced = 0;
                p2auced = 0;
                p3auced = 0;
                p4auced = 0;
                colorturn();
                guide();
                click.Play();
            }
            if (p3aucnotif.Text.StartsWith("Click the eagle icon \r\nto the corner top-right side to show control-panel"))
            {
                notif3.Visible = false;
                btnp3.Enabled = true;
                tip3.Visible = true;
                click.Play();
            }
            if (p3aucnotif.Text.StartsWith("To bid a price, \r\nthe price must be greater than the highest bid or atleast " + minprice + "php"))
            {
                notif3.Visible = false;
                p3auc.Enabled = true;
                tip3.Visible = true;
                click.Play();
            }
            if (p3aucnotif.Text.StartsWith("Do you want to leave auction?"))
            {
                p1quit3 = 1;
                notif3.Visible = false;
                btnp3.Enabled = false;
                if (p1quit3 == 1)
                {
                    btnp3.Enabled = false;
                    btnp3.Visible = false;
                    p3auc.Visible = false;
                    btnp4.Enabled = true;
                    p3auc.Visible = false;
                    turns3();
                    auc1.Visible = false;
                    guide();
                    tip2.Visible = false;
                    turnss();
                    p3timer.Stop();
                    quit();
                    quitbidding();
                    bugsaverquit();

                    click.Play();
                }
                if (p1quit3 == 1 && p1quit4 == 1)
                {
                    notif4.Visible = false;
                    btnp3.Enabled = false;
                    btnp3.Visible = false;
                    p3auc.Visible = false;
                    btnp1.Enabled = true;
                    p3auc.Visible = false;
                    turns3();
                    auc1.Visible = false;
                    guide();
                    tip2.Visible = false;
                    turnss();
                    p3timer.Stop();
                    quit();
                    quitbidding();
                    bugsaverquit();

                    click.Play();
                }
                click.Play();
            }
            if (p3aucnotif.Text.StartsWith("The Auction has been cancelled"))
            {
                p4aucch = 1;
                p4_gameplay.easternschoolaucd1 = 0;
                p4_gameplay.westernschoolaucd1 = 0;
                p4_gameplay.visayashighschoolaucd1 = 0;
                p4_gameplay.southernschoolaucd1 = 0;
                p4_gameplay.nationsschoolaucd1 = 0;
                p4_gameplay.westmarketaucd1 = 0;
                p4_gameplay.nightmarketaucd1 = 0;
                p4_gameplay.daymarketaucd1 = 0;
                p4_gameplay.starmarketaucd1 = 0;
                p4_gameplay.moonmarketaucd1 = 0;
                p4_gameplay.megamarketaucd1 = 0;
                p4_gameplay.visayashospitalaucd1 = 0;
                p4_gameplay.hobertshospitalaucd1 = 0;
                p4_gameplay.heartshospitalaucd1 = 0;
                p4_gameplay.internshospitalaucd1 = 0;
                p4_gameplay.nationalhealthhospitalaucd1 = 0;
                p4_gameplay.veteranshospitalaucd1 = 0;
                p4_gameplay.pearlmallaucd1 = 0;
                p4_gameplay.megamallaucd1 = 0;
                p4_gameplay.articmallaucd1 = 0;
                p4_gameplay.heavenlymallaucd1 = 0;
                p4_gameplay.shangrillamallaucd1 = 0;
                p4_gameplay.utility1x1aucd1 = 0;
                p4_gameplay.utility1x2aucd1 = 0;
                p4_gameplay.transportation1x1aucd1 = 0;
                p4_gameplay.transportation1x2aucd1 = 0;
                p4_gameplay.transportation1x3aucd1 = 0;
                p4_gameplay.transportation1x4aucd1 = 0;


                p4_gameplay.easternschoolaucd2 = 0;
                p4_gameplay.westernschoolaucd2 = 0;
                p4_gameplay.visayashighschoolaucd2 = 0;
                p4_gameplay.southernschoolaucd2 = 0;
                p4_gameplay.nationsschoolaucd2 = 0;
                p4_gameplay.westmarketaucd2 = 0;
                p4_gameplay.nightmarketaucd2 = 0;
                p4_gameplay.daymarketaucd2 = 0;
                p4_gameplay.starmarketaucd2 = 0;
                p4_gameplay.moonmarketaucd2 = 0;
                p4_gameplay.megamarketaucd2 = 0;
                p4_gameplay.visayashospitalaucd2 = 0;
                p4_gameplay.hobertshospitalaucd2 = 0;
                p4_gameplay.heartshospitalaucd2 = 0;
                p4_gameplay.internshospitalaucd2 = 0;
                p4_gameplay.nationalhealthhospitalaucd2 = 0;
                p4_gameplay.veteranshospitalaucd2 = 0;
                p4_gameplay.pearlmallaucd2 = 0;
                p4_gameplay.megamallaucd2 = 0;
                p4_gameplay.articmallaucd2 = 0;
                p4_gameplay.heavenlymallaucd2 = 0;
                p4_gameplay.shangrillamallaucd2 = 0;
                p4_gameplay.utility2x1aucd2 = 0;
                p4_gameplay.utility2x2aucd2 = 0;
                p4_gameplay.transportation2x1aucd2 = 0;
                p4_gameplay.transportation2x2aucd2 = 0;
                p4_gameplay.transportation2x3aucd2 = 0;
                p4_gameplay.transportation2x4aucd2 = 0;

                p4_gameplay.easternschoolaucd3 = 0;
                p4_gameplay.westernschoolaucd3 = 0;
                p4_gameplay.visayashighschoolaucd3 = 0;
                p4_gameplay.southernschoolaucd3 = 0;
                p4_gameplay.nationsschoolaucd3 = 0;
                p4_gameplay.westmarketaucd3 = 0;
                p4_gameplay.nightmarketaucd3 = 0;
                p4_gameplay.daymarketaucd3 = 0;
                p4_gameplay.starmarketaucd3 = 0;
                p4_gameplay.moonmarketaucd3 = 0;
                p4_gameplay.megamarketaucd3 = 0;
                p4_gameplay.visayashospitalaucd3 = 0;
                p4_gameplay.hobertshospitalaucd3 = 0;
                p4_gameplay.heartshospitalaucd3 = 0;
                p4_gameplay.internshospitalaucd3 = 0;
                p4_gameplay.nationalhealthhospitalaucd3 = 0;
                p4_gameplay.veteranshospitalaucd3 = 0;
                p4_gameplay.pearlmallaucd3 = 0;
                p4_gameplay.megamallaucd3 = 0;
                p4_gameplay.articmallaucd3 = 0;
                p4_gameplay.heavenlymallaucd3 = 0;
                p4_gameplay.shangrillamallaucd3 = 0;
                p4_gameplay.utility3x1aucd3 = 0;
                p4_gameplay.utility3x2aucd3 = 0;
                p4_gameplay.transportation3x1aucd3 = 0;
                p4_gameplay.transportation3x2aucd3 = 0;
                p4_gameplay.transportation3x3aucd3 = 0;
                p4_gameplay.transportation3x4aucd3 = 0;

                p4_gameplay.easternschoolaucd4 = 0;
                p4_gameplay.westernschoolaucd4 = 0;
                p4_gameplay.visayashighschoolaucd4 = 0;
                p4_gameplay.southernschoolaucd4 = 0;
                p4_gameplay.nationsschoolaucd4 = 0;
                p4_gameplay.westmarketaucd4 = 0;
                p4_gameplay.nightmarketaucd4 = 0;
                p4_gameplay.daymarketaucd4 = 0;
                p4_gameplay.starmarketaucd4 = 0;
                p4_gameplay.moonmarketaucd4 = 0;
                p4_gameplay.megamarketaucd4 = 0;
                p4_gameplay.visayashospitalaucd4 = 0;
                p4_gameplay.hobertshospitalaucd4 = 0;
                p4_gameplay.heartshospitalaucd4 = 0;
                p4_gameplay.internshospitalaucd4 = 0;
                p4_gameplay.nationalhealthhospitalaucd4 = 0;
                p4_gameplay.veteranshospitalaucd4 = 0;
                p4_gameplay.pearlmallaucd4 = 0;
                p4_gameplay.megamallaucd4 = 0;
                p4_gameplay.articmallaucd4 = 0;
                p4_gameplay.heavenlymallaucd4 = 0;
                p4_gameplay.shangrillamallaucd4 = 0;
                p4_gameplay.utility4x1aucd4 = 0;
                p4_gameplay.utility4x2aucd4 = 0;
                p4_gameplay.transportation4x1aucd4 = 0;
                p4_gameplay.transportation4x2aucd4 = 0;
                p4_gameplay.transportation4x3aucd4 = 0;
                p4_gameplay.transportation4x4aucd4 = 0;

                //auction
                p4_gameplay.easternschoolauc1 = 0;
                p4_gameplay.westernschoolauc1 = 0;
                p4_gameplay.visayashighschoolauc1 = 0;
                p4_gameplay.southernschoolauc1 = 0;
                p4_gameplay.nationsschoolauc1 = 0;
                p4_gameplay.westmarketauc1 = 0;
                p4_gameplay.nightmarketauc1 = 0;
                p4_gameplay.daymarketauc1 = 0;
                p4_gameplay.starmarketauc1 = 0;
                p4_gameplay.moonmarketauc1 = 0;
                p4_gameplay.megamarketauc1 = 0;
                p4_gameplay.visayashospitalauc1 = 0;
                p4_gameplay.hobertshospitalauc1 = 0;
                p4_gameplay.heartshospitalauc1 = 0;
                p4_gameplay.internshospitalauc1 = 0;
                p4_gameplay.nationalhealthhospitalauc1 = 0;
                p4_gameplay.veteranshospitalauc1 = 0;
                p4_gameplay.pearlmallauc1 = 0;
                p4_gameplay.megamallauc1 = 0;
                p4_gameplay.articmallauc1 = 0;
                p4_gameplay.heavenlymallauc1 = 0;
                p4_gameplay.shangrillamallauc1 = 0;
                p4_gameplay.utility1x1auc1 = 0;
                p4_gameplay.utility1x2auc1 = 0;
                p4_gameplay.transportation1x1auc1 = 0;
                p4_gameplay.transportation1x2auc1 = 0;
                p4_gameplay.transportation1x3auc1 = 0;
                p4_gameplay.transportation1x4auc1 = 0;


                p4_gameplay.easternschoolauc2 = 0;
                p4_gameplay.westernschoolauc2 = 0;
                p4_gameplay.visayashighschoolauc2 = 0;
                p4_gameplay.southernschoolauc2 = 0;
                p4_gameplay.nationsschoolauc2 = 0;
                p4_gameplay.westmarketauc2 = 0;
                p4_gameplay.nightmarketauc2 = 0;
                p4_gameplay.daymarketauc2 = 0;
                p4_gameplay.starmarketauc2 = 0;
                p4_gameplay.moonmarketauc2 = 0;
                p4_gameplay.megamarketauc2 = 0;
                p4_gameplay.visayashospitalauc2 = 0;
                p4_gameplay.hobertshospitalauc2 = 0;
                p4_gameplay.heartshospitalauc2 = 0;
                p4_gameplay.internshospitalauc2 = 0;
                p4_gameplay.nationalhealthhospitalauc2 = 0;
                p4_gameplay.veteranshospitalauc2 = 0;
                p4_gameplay.pearlmallauc2 = 0;
                p4_gameplay.megamallauc2 = 0;
                p4_gameplay.articmallauc2 = 0;
                p4_gameplay.heavenlymallauc2 = 0;
                p4_gameplay.shangrillamallauc2 = 0;
                p4_gameplay.utility2x1auc2 = 0;
                p4_gameplay.utility2x2auc2 = 0;
                p4_gameplay.transportation2x1auc2 = 0;
                p4_gameplay.transportation2x2auc2 = 0;
                p4_gameplay.transportation2x3auc2 = 0;
                p4_gameplay.transportation2x4auc2 = 0;

                p4_gameplay.easternschoolauc3 = 0;
                p4_gameplay.westernschoolauc3 = 0;
                p4_gameplay.visayashighschoolauc3 = 0;
                p4_gameplay.southernschoolauc3 = 0;
                p4_gameplay.nationsschoolauc3 = 0;
                p4_gameplay.westmarketauc3 = 0;
                p4_gameplay.nightmarketauc3 = 0;
                p4_gameplay.daymarketauc3 = 0;
                p4_gameplay.starmarketauc3 = 0;
                p4_gameplay.moonmarketauc3 = 0;
                p4_gameplay.megamarketauc3 = 0;
                p4_gameplay.visayashospitalauc3 = 0;
                p4_gameplay.hobertshospitalauc3 = 0;
                p4_gameplay.heartshospitalauc3 = 0;
                p4_gameplay.internshospitalauc3 = 0;
                p4_gameplay.nationalhealthhospitalauc3 = 0;
                p4_gameplay.veteranshospitalauc3 = 0;
                p4_gameplay.pearlmallauc3 = 0;
                p4_gameplay.megamallauc3 = 0;
                p4_gameplay.articmallauc3 = 0;
                p4_gameplay.heavenlymallauc3 = 0;
                p4_gameplay.shangrillamallauc3 = 0;
                p4_gameplay.utility3x1auc3 = 0;
                p4_gameplay.utility3x2auc3 = 0;
                p4_gameplay.transportation3x1auc3 = 0;
                p4_gameplay.transportation3x2auc3 = 0;
                p4_gameplay.transportation3x3auc3 = 0;
                p4_gameplay.transportation3x4auc3 = 0;

                p4_gameplay.easternschoolauc4 = 0;
                p4_gameplay.westernschoolauc4 = 0;
                p4_gameplay.visayashighschoolauc4 = 0;
                p4_gameplay.southernschoolauc4 = 0;
                p4_gameplay.nationsschoolauc4 = 0;
                p4_gameplay.westmarketauc4 = 0;
                p4_gameplay.nightmarketauc4 = 0;
                p4_gameplay.daymarketauc4 = 0;
                p4_gameplay.starmarketauc4 = 0;
                p4_gameplay.moonmarketauc4 = 0;
                p4_gameplay.megamarketauc4 = 0;
                p4_gameplay.visayashospitalauc4 = 0;
                p4_gameplay.hobertshospitalauc4 = 0;
                p4_gameplay.heartshospitalauc4 = 0;
                p4_gameplay.internshospitalauc4 = 0;
                p4_gameplay.nationalhealthhospitalauc4 = 0;
                p4_gameplay.veteranshospitalauc4 = 0;
                p4_gameplay.pearlmallauc4 = 0;
                p4_gameplay.megamallauc4 = 0;
                p4_gameplay.articmallauc4 = 0;
                p4_gameplay.heavenlymallauc4 = 0;
                p4_gameplay.shangrillamallauc4 = 0;
                p4_gameplay.utility4x1auc4 = 0;
                p4_gameplay.utility4x2auc4 = 0;
                p4_gameplay.transportation4x1auc4 = 0;
                p4_gameplay.transportation4x2auc4 = 0;
                p4_gameplay.transportation4x3auc4 = 0;
                p4_gameplay.transportation4x4auc4 = 0;
                this.Close();
                click.Play();
            }
            if (p3aucnotif.Text.StartsWith("Player 3 Won with a bid of " + hibid + "php"))
            {
                p4aucch = 1;
                p4_gameplay.easternschoolaucd1 = 0;
                p4_gameplay.westernschoolaucd1 = 0;
                p4_gameplay.visayashighschoolaucd1 = 0;
                p4_gameplay.southernschoolaucd1 = 0;
                p4_gameplay.nationsschoolaucd1 = 0;
                p4_gameplay.westmarketaucd1 = 0;
                p4_gameplay.nightmarketaucd1 = 0;
                p4_gameplay.daymarketaucd1 = 0;
                p4_gameplay.starmarketaucd1 = 0;
                p4_gameplay.moonmarketaucd1 = 0;
                p4_gameplay.megamarketaucd1 = 0;
                p4_gameplay.visayashospitalaucd1 = 0;
                p4_gameplay.hobertshospitalaucd1 = 0;
                p4_gameplay.heartshospitalaucd1 = 0;
                p4_gameplay.internshospitalaucd1 = 0;
                p4_gameplay.nationalhealthhospitalaucd1 = 0;
                p4_gameplay.veteranshospitalaucd1 = 0;
                p4_gameplay.pearlmallaucd1 = 0;
                p4_gameplay.megamallaucd1 = 0;
                p4_gameplay.articmallaucd1 = 0;
                p4_gameplay.heavenlymallaucd1 = 0;
                p4_gameplay.shangrillamallaucd1 = 0;
                p4_gameplay.utility1x1aucd1 = 0;
                p4_gameplay.utility1x2aucd1 = 0;
                p4_gameplay.transportation1x1aucd1 = 0;
                p4_gameplay.transportation1x2aucd1 = 0;
                p4_gameplay.transportation1x3aucd1 = 0;
                p4_gameplay.transportation1x4aucd1 = 0;


                p4_gameplay.easternschoolaucd2 = 0;
                p4_gameplay.westernschoolaucd2 = 0;
                p4_gameplay.visayashighschoolaucd2 = 0;
                p4_gameplay.southernschoolaucd2 = 0;
                p4_gameplay.nationsschoolaucd2 = 0;
                p4_gameplay.westmarketaucd2 = 0;
                p4_gameplay.nightmarketaucd2 = 0;
                p4_gameplay.daymarketaucd2 = 0;
                p4_gameplay.starmarketaucd2 = 0;
                p4_gameplay.moonmarketaucd2 = 0;
                p4_gameplay.megamarketaucd2 = 0;
                p4_gameplay.visayashospitalaucd2 = 0;
                p4_gameplay.hobertshospitalaucd2 = 0;
                p4_gameplay.heartshospitalaucd2 = 0;
                p4_gameplay.internshospitalaucd2 = 0;
                p4_gameplay.nationalhealthhospitalaucd2 = 0;
                p4_gameplay.veteranshospitalaucd2 = 0;
                p4_gameplay.pearlmallaucd2 = 0;
                p4_gameplay.megamallaucd2 = 0;
                p4_gameplay.articmallaucd2 = 0;
                p4_gameplay.heavenlymallaucd2 = 0;
                p4_gameplay.shangrillamallaucd2 = 0;
                p4_gameplay.utility2x1aucd2 = 0;
                p4_gameplay.utility2x2aucd2 = 0;
                p4_gameplay.transportation2x1aucd2 = 0;
                p4_gameplay.transportation2x2aucd2 = 0;
                p4_gameplay.transportation2x3aucd2 = 0;
                p4_gameplay.transportation2x4aucd2 = 0;

                p4_gameplay.easternschoolaucd3 = 0;
                p4_gameplay.westernschoolaucd3 = 0;
                p4_gameplay.visayashighschoolaucd3 = 0;
                p4_gameplay.southernschoolaucd3 = 0;
                p4_gameplay.nationsschoolaucd3 = 0;
                p4_gameplay.westmarketaucd3 = 0;
                p4_gameplay.nightmarketaucd3 = 0;
                p4_gameplay.daymarketaucd3 = 0;
                p4_gameplay.starmarketaucd3 = 0;
                p4_gameplay.moonmarketaucd3 = 0;
                p4_gameplay.megamarketaucd3 = 0;
                p4_gameplay.visayashospitalaucd3 = 0;
                p4_gameplay.hobertshospitalaucd3 = 0;
                p4_gameplay.heartshospitalaucd3 = 0;
                p4_gameplay.internshospitalaucd3 = 0;
                p4_gameplay.nationalhealthhospitalaucd3 = 0;
                p4_gameplay.veteranshospitalaucd3 = 0;
                p4_gameplay.pearlmallaucd3 = 0;
                p4_gameplay.megamallaucd3 = 0;
                p4_gameplay.articmallaucd3 = 0;
                p4_gameplay.heavenlymallaucd3 = 0;
                p4_gameplay.shangrillamallaucd3 = 0;
                p4_gameplay.utility3x1aucd3 = 0;
                p4_gameplay.utility3x2aucd3 = 0;
                p4_gameplay.transportation3x1aucd3 = 0;
                p4_gameplay.transportation3x2aucd3 = 0;
                p4_gameplay.transportation3x3aucd3 = 0;
                p4_gameplay.transportation3x4aucd3 = 0;

                p4_gameplay.easternschoolaucd4 = 0;
                p4_gameplay.westernschoolaucd4 = 0;
                p4_gameplay.visayashighschoolaucd4 = 0;
                p4_gameplay.southernschoolaucd4 = 0;
                p4_gameplay.nationsschoolaucd4 = 0;
                p4_gameplay.westmarketaucd4 = 0;
                p4_gameplay.nightmarketaucd4 = 0;
                p4_gameplay.daymarketaucd4 = 0;
                p4_gameplay.starmarketaucd4 = 0;
                p4_gameplay.moonmarketaucd4 = 0;
                p4_gameplay.megamarketaucd4 = 0;
                p4_gameplay.visayashospitalaucd4 = 0;
                p4_gameplay.hobertshospitalaucd4 = 0;
                p4_gameplay.heartshospitalaucd4 = 0;
                p4_gameplay.internshospitalaucd4 = 0;
                p4_gameplay.nationalhealthhospitalaucd4 = 0;
                p4_gameplay.veteranshospitalaucd4 = 0;
                p4_gameplay.pearlmallaucd4 = 0;
                p4_gameplay.megamallaucd4 = 0;
                p4_gameplay.articmallaucd4 = 0;
                p4_gameplay.heavenlymallaucd4 = 0;
                p4_gameplay.shangrillamallaucd4 = 0;
                p4_gameplay.utility4x1aucd4 = 0;
                p4_gameplay.utility4x2aucd4 = 0;
                p4_gameplay.transportation4x1aucd4 = 0;
                p4_gameplay.transportation4x2aucd4 = 0;
                p4_gameplay.transportation4x3aucd4 = 0;
                p4_gameplay.transportation4x4aucd4 = 0;

                //auction
                p4_gameplay.easternschoolauc1 = 0;
                p4_gameplay.westernschoolauc1 = 0;
                p4_gameplay.visayashighschoolauc1 = 0;
                p4_gameplay.southernschoolauc1 = 0;
                p4_gameplay.nationsschoolauc1 = 0;
                p4_gameplay.westmarketauc1 = 0;
                p4_gameplay.nightmarketauc1 = 0;
                p4_gameplay.daymarketauc1 = 0;
                p4_gameplay.starmarketauc1 = 0;
                p4_gameplay.moonmarketauc1 = 0;
                p4_gameplay.megamarketauc1 = 0;
                p4_gameplay.visayashospitalauc1 = 0;
                p4_gameplay.hobertshospitalauc1 = 0;
                p4_gameplay.heartshospitalauc1 = 0;
                p4_gameplay.internshospitalauc1 = 0;
                p4_gameplay.nationalhealthhospitalauc1 = 0;
                p4_gameplay.veteranshospitalauc1 = 0;
                p4_gameplay.pearlmallauc1 = 0;
                p4_gameplay.megamallauc1 = 0;
                p4_gameplay.articmallauc1 = 0;
                p4_gameplay.heavenlymallauc1 = 0;
                p4_gameplay.shangrillamallauc1 = 0;
                p4_gameplay.utility1x1auc1 = 0;
                p4_gameplay.utility1x2auc1 = 0;
                p4_gameplay.transportation1x1auc1 = 0;
                p4_gameplay.transportation1x2auc1 = 0;
                p4_gameplay.transportation1x3auc1 = 0;
                p4_gameplay.transportation1x4auc1 = 0;


                p4_gameplay.easternschoolauc2 = 0;
                p4_gameplay.westernschoolauc2 = 0;
                p4_gameplay.visayashighschoolauc2 = 0;
                p4_gameplay.southernschoolauc2 = 0;
                p4_gameplay.nationsschoolauc2 = 0;
                p4_gameplay.westmarketauc2 = 0;
                p4_gameplay.nightmarketauc2 = 0;
                p4_gameplay.daymarketauc2 = 0;
                p4_gameplay.starmarketauc2 = 0;
                p4_gameplay.moonmarketauc2 = 0;
                p4_gameplay.megamarketauc2 = 0;
                p4_gameplay.visayashospitalauc2 = 0;
                p4_gameplay.hobertshospitalauc2 = 0;
                p4_gameplay.heartshospitalauc2 = 0;
                p4_gameplay.internshospitalauc2 = 0;
                p4_gameplay.nationalhealthhospitalauc2 = 0;
                p4_gameplay.veteranshospitalauc2 = 0;
                p4_gameplay.pearlmallauc2 = 0;
                p4_gameplay.megamallauc2 = 0;
                p4_gameplay.articmallauc2 = 0;
                p4_gameplay.heavenlymallauc2 = 0;
                p4_gameplay.shangrillamallauc2 = 0;
                p4_gameplay.utility2x1auc2 = 0;
                p4_gameplay.utility2x2auc2 = 0;
                p4_gameplay.transportation2x1auc2 = 0;
                p4_gameplay.transportation2x2auc2 = 0;
                p4_gameplay.transportation2x3auc2 = 0;
                p4_gameplay.transportation2x4auc2 = 0;

                p4_gameplay.easternschoolauc3 = 0;
                p4_gameplay.westernschoolauc3 = 0;
                p4_gameplay.visayashighschoolauc3 = 0;
                p4_gameplay.southernschoolauc3 = 0;
                p4_gameplay.nationsschoolauc3 = 0;
                p4_gameplay.westmarketauc3 = 0;
                p4_gameplay.nightmarketauc3 = 0;
                p4_gameplay.daymarketauc3 = 0;
                p4_gameplay.starmarketauc3 = 0;
                p4_gameplay.moonmarketauc3 = 0;
                p4_gameplay.megamarketauc3 = 0;
                p4_gameplay.visayashospitalauc3 = 0;
                p4_gameplay.hobertshospitalauc3 = 0;
                p4_gameplay.heartshospitalauc3 = 0;
                p4_gameplay.internshospitalauc3 = 0;
                p4_gameplay.nationalhealthhospitalauc3 = 0;
                p4_gameplay.veteranshospitalauc3 = 0;
                p4_gameplay.pearlmallauc3 = 0;
                p4_gameplay.megamallauc3 = 0;
                p4_gameplay.articmallauc3 = 0;
                p4_gameplay.heavenlymallauc3 = 0;
                p4_gameplay.shangrillamallauc3 = 0;
                p4_gameplay.utility3x1auc3 = 0;
                p4_gameplay.utility3x2auc3 = 0;
                p4_gameplay.transportation3x1auc3 = 0;
                p4_gameplay.transportation3x2auc3 = 0;
                p4_gameplay.transportation3x3auc3 = 0;
                p4_gameplay.transportation3x4auc3 = 0;

                p4_gameplay.easternschoolauc4 = 0;
                p4_gameplay.westernschoolauc4 = 0;
                p4_gameplay.visayashighschoolauc4 = 0;
                p4_gameplay.southernschoolauc4 = 0;
                p4_gameplay.nationsschoolauc4 = 0;
                p4_gameplay.westmarketauc4 = 0;
                p4_gameplay.nightmarketauc4 = 0;
                p4_gameplay.daymarketauc4 = 0;
                p4_gameplay.starmarketauc4 = 0;
                p4_gameplay.moonmarketauc4 = 0;
                p4_gameplay.megamarketauc4 = 0;
                p4_gameplay.visayashospitalauc4 = 0;
                p4_gameplay.hobertshospitalauc4 = 0;
                p4_gameplay.heartshospitalauc4 = 0;
                p4_gameplay.internshospitalauc4 = 0;
                p4_gameplay.nationalhealthhospitalauc4 = 0;
                p4_gameplay.veteranshospitalauc4 = 0;
                p4_gameplay.pearlmallauc4 = 0;
                p4_gameplay.megamallauc4 = 0;
                p4_gameplay.articmallauc4 = 0;
                p4_gameplay.heavenlymallauc4 = 0;
                p4_gameplay.shangrillamallauc4 = 0;
                p4_gameplay.utility4x1auc4 = 0;
                p4_gameplay.utility4x2auc4 = 0;
                p4_gameplay.transportation4x1auc4 = 0;
                p4_gameplay.transportation4x2auc4 = 0;
                p4_gameplay.transportation4x3auc4 = 0;
                p4_gameplay.transportation4x4auc4 = 0;
                this.Close();
                click.Play();
            }
        }

        private void btnacc2_Click(object sender, EventArgs e)
        {
            if (p2aucnotif.Text.StartsWith("Player 2's turn"))
            {
                notif2.Visible = false;
                btnp2.Enabled = true;
                p1auced = 0;
                p2auced = 0;
                p3auced = 0;
                p4auced = 0;
                colorturn();
                guide();
                click.Play();
            }
            if (p2aucnotif.Text.StartsWith("Click the jeep icon \r\nto the corner top-left side to show control-panel"))
            {
                notif2.Visible = false;
                btnp2.Enabled = true;
                tip2.Visible = true;
                click.Play();
            }
            if (p2aucnotif.Text.StartsWith("To bid a price, \r\nthe price must be greater than the highest bid or atleast " + minprice + "php"))
            {
                notif2.Visible = false;
                p2auc.Enabled = true;
                tip2.Visible = true;
                click.Play();
            }
            if (p2aucnotif.Text.StartsWith("Do you want to leave auction?"))
            {
                p1quit2 = 1;
                notif2.Visible = false;
                btnp2.Enabled = false;
                if (p1quit2 == 1)
                {
                    btnp2.Enabled = false;
                    p2auc.Visible = false;
                    btnp3.Enabled = true;
                    p2auc.Visible = false;
                    turns2();
                    auc2.Visible = false;
                    guide();
                    tip2.Visible = false;
                    turnss();
                    p2timer.Stop();
                    quit();
                    quitbidding();
                    bugsaverquit();
                    click.Play();
                }
  
            }
            if (p2aucnotif.Text.StartsWith("The Auction has been cancelled"))
            {
                p4aucch = 1;
                p4_gameplay.easternschoolaucd1 = 0;
                p4_gameplay.westernschoolaucd1 = 0;
                p4_gameplay.visayashighschoolaucd1 = 0;
                p4_gameplay.southernschoolaucd1 = 0;
                p4_gameplay.nationsschoolaucd1 = 0;
                p4_gameplay.westmarketaucd1 = 0;
                p4_gameplay.nightmarketaucd1 = 0;
                p4_gameplay.daymarketaucd1 = 0;
                p4_gameplay.starmarketaucd1 = 0;
                p4_gameplay.moonmarketaucd1 = 0;
                p4_gameplay.megamarketaucd1 = 0;
                p4_gameplay.visayashospitalaucd1 = 0;
                p4_gameplay.hobertshospitalaucd1 = 0;
                p4_gameplay.heartshospitalaucd1 = 0;
                p4_gameplay.internshospitalaucd1 = 0;
                p4_gameplay.nationalhealthhospitalaucd1 = 0;
                p4_gameplay.veteranshospitalaucd1 = 0;
                p4_gameplay.pearlmallaucd1 = 0;
                p4_gameplay.megamallaucd1 = 0;
                p4_gameplay.articmallaucd1 = 0;
                p4_gameplay.heavenlymallaucd1 = 0;
                p4_gameplay.shangrillamallaucd1 = 0;
                p4_gameplay.utility1x1aucd1 = 0;
                p4_gameplay.utility1x2aucd1 = 0;
                p4_gameplay.transportation1x1aucd1 = 0;
                p4_gameplay.transportation1x2aucd1 = 0;
                p4_gameplay.transportation1x3aucd1 = 0;
                p4_gameplay.transportation1x4aucd1 = 0;


                p4_gameplay.easternschoolaucd2 = 0;
                p4_gameplay.westernschoolaucd2 = 0;
                p4_gameplay.visayashighschoolaucd2 = 0;
                p4_gameplay.southernschoolaucd2 = 0;
                p4_gameplay.nationsschoolaucd2 = 0;
                p4_gameplay.westmarketaucd2 = 0;
                p4_gameplay.nightmarketaucd2 = 0;
                p4_gameplay.daymarketaucd2 = 0;
                p4_gameplay.starmarketaucd2 = 0;
                p4_gameplay.moonmarketaucd2 = 0;
                p4_gameplay.megamarketaucd2 = 0;
                p4_gameplay.visayashospitalaucd2 = 0;
                p4_gameplay.hobertshospitalaucd2 = 0;
                p4_gameplay.heartshospitalaucd2 = 0;
                p4_gameplay.internshospitalaucd2 = 0;
                p4_gameplay.nationalhealthhospitalaucd2 = 0;
                p4_gameplay.veteranshospitalaucd2 = 0;
                p4_gameplay.pearlmallaucd2 = 0;
                p4_gameplay.megamallaucd2 = 0;
                p4_gameplay.articmallaucd2 = 0;
                p4_gameplay.heavenlymallaucd2 = 0;
                p4_gameplay.shangrillamallaucd2 = 0;
                p4_gameplay.utility2x1aucd2 = 0;
                p4_gameplay.utility2x2aucd2 = 0;
                p4_gameplay.transportation2x1aucd2 = 0;
                p4_gameplay.transportation2x2aucd2 = 0;
                p4_gameplay.transportation2x3aucd2 = 0;
                p4_gameplay.transportation2x4aucd2 = 0;

                p4_gameplay.easternschoolaucd3 = 0;
                p4_gameplay.westernschoolaucd3 = 0;
                p4_gameplay.visayashighschoolaucd3 = 0;
                p4_gameplay.southernschoolaucd3 = 0;
                p4_gameplay.nationsschoolaucd3 = 0;
                p4_gameplay.westmarketaucd3 = 0;
                p4_gameplay.nightmarketaucd3 = 0;
                p4_gameplay.daymarketaucd3 = 0;
                p4_gameplay.starmarketaucd3 = 0;
                p4_gameplay.moonmarketaucd3 = 0;
                p4_gameplay.megamarketaucd3 = 0;
                p4_gameplay.visayashospitalaucd3 = 0;
                p4_gameplay.hobertshospitalaucd3 = 0;
                p4_gameplay.heartshospitalaucd3 = 0;
                p4_gameplay.internshospitalaucd3 = 0;
                p4_gameplay.nationalhealthhospitalaucd3 = 0;
                p4_gameplay.veteranshospitalaucd3 = 0;
                p4_gameplay.pearlmallaucd3 = 0;
                p4_gameplay.megamallaucd3 = 0;
                p4_gameplay.articmallaucd3 = 0;
                p4_gameplay.heavenlymallaucd3 = 0;
                p4_gameplay.shangrillamallaucd3 = 0;
                p4_gameplay.utility3x1aucd3 = 0;
                p4_gameplay.utility3x2aucd3 = 0;
                p4_gameplay.transportation3x1aucd3 = 0;
                p4_gameplay.transportation3x2aucd3 = 0;
                p4_gameplay.transportation3x3aucd3 = 0;
                p4_gameplay.transportation3x4aucd3 = 0;

                p4_gameplay.easternschoolaucd4 = 0;
                p4_gameplay.westernschoolaucd4 = 0;
                p4_gameplay.visayashighschoolaucd4 = 0;
                p4_gameplay.southernschoolaucd4 = 0;
                p4_gameplay.nationsschoolaucd4 = 0;
                p4_gameplay.westmarketaucd4 = 0;
                p4_gameplay.nightmarketaucd4 = 0;
                p4_gameplay.daymarketaucd4 = 0;
                p4_gameplay.starmarketaucd4 = 0;
                p4_gameplay.moonmarketaucd4 = 0;
                p4_gameplay.megamarketaucd4 = 0;
                p4_gameplay.visayashospitalaucd4 = 0;
                p4_gameplay.hobertshospitalaucd4 = 0;
                p4_gameplay.heartshospitalaucd4 = 0;
                p4_gameplay.internshospitalaucd4 = 0;
                p4_gameplay.nationalhealthhospitalaucd4 = 0;
                p4_gameplay.veteranshospitalaucd4 = 0;
                p4_gameplay.pearlmallaucd4 = 0;
                p4_gameplay.megamallaucd4 = 0;
                p4_gameplay.articmallaucd4 = 0;
                p4_gameplay.heavenlymallaucd4 = 0;
                p4_gameplay.shangrillamallaucd4 = 0;
                p4_gameplay.utility4x1aucd4 = 0;
                p4_gameplay.utility4x2aucd4 = 0;
                p4_gameplay.transportation4x1aucd4 = 0;
                p4_gameplay.transportation4x2aucd4 = 0;
                p4_gameplay.transportation4x3aucd4 = 0;
                p4_gameplay.transportation4x4aucd4 = 0;

                //auction
                p4_gameplay.easternschoolauc1 = 0;
                p4_gameplay.westernschoolauc1 = 0;
                p4_gameplay.visayashighschoolauc1 = 0;
                p4_gameplay.southernschoolauc1 = 0;
                p4_gameplay.nationsschoolauc1 = 0;
                p4_gameplay.westmarketauc1 = 0;
                p4_gameplay.nightmarketauc1 = 0;
                p4_gameplay.daymarketauc1 = 0;
                p4_gameplay.starmarketauc1 = 0;
                p4_gameplay.moonmarketauc1 = 0;
                p4_gameplay.megamarketauc1 = 0;
                p4_gameplay.visayashospitalauc1 = 0;
                p4_gameplay.hobertshospitalauc1 = 0;
                p4_gameplay.heartshospitalauc1 = 0;
                p4_gameplay.internshospitalauc1 = 0;
                p4_gameplay.nationalhealthhospitalauc1 = 0;
                p4_gameplay.veteranshospitalauc1 = 0;
                p4_gameplay.pearlmallauc1 = 0;
                p4_gameplay.megamallauc1 = 0;
                p4_gameplay.articmallauc1 = 0;
                p4_gameplay.heavenlymallauc1 = 0;
                p4_gameplay.shangrillamallauc1 = 0;
                p4_gameplay.utility1x1auc1 = 0;
                p4_gameplay.utility1x2auc1 = 0;
                p4_gameplay.transportation1x1auc1 = 0;
                p4_gameplay.transportation1x2auc1 = 0;
                p4_gameplay.transportation1x3auc1 = 0;
                p4_gameplay.transportation1x4auc1 = 0;


                p4_gameplay.easternschoolauc2 = 0;
                p4_gameplay.westernschoolauc2 = 0;
                p4_gameplay.visayashighschoolauc2 = 0;
                p4_gameplay.southernschoolauc2 = 0;
                p4_gameplay.nationsschoolauc2 = 0;
                p4_gameplay.westmarketauc2 = 0;
                p4_gameplay.nightmarketauc2 = 0;
                p4_gameplay.daymarketauc2 = 0;
                p4_gameplay.starmarketauc2 = 0;
                p4_gameplay.moonmarketauc2 = 0;
                p4_gameplay.megamarketauc2 = 0;
                p4_gameplay.visayashospitalauc2 = 0;
                p4_gameplay.hobertshospitalauc2 = 0;
                p4_gameplay.heartshospitalauc2 = 0;
                p4_gameplay.internshospitalauc2 = 0;
                p4_gameplay.nationalhealthhospitalauc2 = 0;
                p4_gameplay.veteranshospitalauc2 = 0;
                p4_gameplay.pearlmallauc2 = 0;
                p4_gameplay.megamallauc2 = 0;
                p4_gameplay.articmallauc2 = 0;
                p4_gameplay.heavenlymallauc2 = 0;
                p4_gameplay.shangrillamallauc2 = 0;
                p4_gameplay.utility2x1auc2 = 0;
                p4_gameplay.utility2x2auc2 = 0;
                p4_gameplay.transportation2x1auc2 = 0;
                p4_gameplay.transportation2x2auc2 = 0;
                p4_gameplay.transportation2x3auc2 = 0;
                p4_gameplay.transportation2x4auc2 = 0;

                p4_gameplay.easternschoolauc3 = 0;
                p4_gameplay.westernschoolauc3 = 0;
                p4_gameplay.visayashighschoolauc3 = 0;
                p4_gameplay.southernschoolauc3 = 0;
                p4_gameplay.nationsschoolauc3 = 0;
                p4_gameplay.westmarketauc3 = 0;
                p4_gameplay.nightmarketauc3 = 0;
                p4_gameplay.daymarketauc3 = 0;
                p4_gameplay.starmarketauc3 = 0;
                p4_gameplay.moonmarketauc3 = 0;
                p4_gameplay.megamarketauc3 = 0;
                p4_gameplay.visayashospitalauc3 = 0;
                p4_gameplay.hobertshospitalauc3 = 0;
                p4_gameplay.heartshospitalauc3 = 0;
                p4_gameplay.internshospitalauc3 = 0;
                p4_gameplay.nationalhealthhospitalauc3 = 0;
                p4_gameplay.veteranshospitalauc3 = 0;
                p4_gameplay.pearlmallauc3 = 0;
                p4_gameplay.megamallauc3 = 0;
                p4_gameplay.articmallauc3 = 0;
                p4_gameplay.heavenlymallauc3 = 0;
                p4_gameplay.shangrillamallauc3 = 0;
                p4_gameplay.utility3x1auc3 = 0;
                p4_gameplay.utility3x2auc3 = 0;
                p4_gameplay.transportation3x1auc3 = 0;
                p4_gameplay.transportation3x2auc3 = 0;
                p4_gameplay.transportation3x3auc3 = 0;
                p4_gameplay.transportation3x4auc3 = 0;

                p4_gameplay.easternschoolauc4 = 0;
                p4_gameplay.westernschoolauc4 = 0;
                p4_gameplay.visayashighschoolauc4 = 0;
                p4_gameplay.southernschoolauc4 = 0;
                p4_gameplay.nationsschoolauc4 = 0;
                p4_gameplay.westmarketauc4 = 0;
                p4_gameplay.nightmarketauc4 = 0;
                p4_gameplay.daymarketauc4 = 0;
                p4_gameplay.starmarketauc4 = 0;
                p4_gameplay.moonmarketauc4 = 0;
                p4_gameplay.megamarketauc4 = 0;
                p4_gameplay.visayashospitalauc4 = 0;
                p4_gameplay.hobertshospitalauc4 = 0;
                p4_gameplay.heartshospitalauc4 = 0;
                p4_gameplay.internshospitalauc4 = 0;
                p4_gameplay.nationalhealthhospitalauc4 = 0;
                p4_gameplay.veteranshospitalauc4 = 0;
                p4_gameplay.pearlmallauc4 = 0;
                p4_gameplay.megamallauc4 = 0;
                p4_gameplay.articmallauc4 = 0;
                p4_gameplay.heavenlymallauc4 = 0;
                p4_gameplay.shangrillamallauc4 = 0;
                p4_gameplay.utility4x1auc4 = 0;
                p4_gameplay.utility4x2auc4 = 0;
                p4_gameplay.transportation4x1auc4 = 0;
                p4_gameplay.transportation4x2auc4 = 0;
                p4_gameplay.transportation4x3auc4 = 0;
                p4_gameplay.transportation4x4auc4 = 0;
                this.Close();
                click.Play();
            }
            if (p2aucnotif.Text.StartsWith("Player 2 Won with a bid of " + hibid + "php"))
            {
                p4aucch = 1;
                p4_gameplay.easternschoolaucd1 = 0;
                p4_gameplay.westernschoolaucd1 = 0;
                p4_gameplay.visayashighschoolaucd1 = 0;
                p4_gameplay.southernschoolaucd1 = 0;
                p4_gameplay.nationsschoolaucd1 = 0;
                p4_gameplay.westmarketaucd1 = 0;
                p4_gameplay.nightmarketaucd1 = 0;
                p4_gameplay.daymarketaucd1 = 0;
                p4_gameplay.starmarketaucd1 = 0;
                p4_gameplay.moonmarketaucd1 = 0;
                p4_gameplay.megamarketaucd1 = 0;
                p4_gameplay.visayashospitalaucd1 = 0;
                p4_gameplay.hobertshospitalaucd1 = 0;
                p4_gameplay.heartshospitalaucd1 = 0;
                p4_gameplay.internshospitalaucd1 = 0;
                p4_gameplay.nationalhealthhospitalaucd1 = 0;
                p4_gameplay.veteranshospitalaucd1 = 0;
                p4_gameplay.pearlmallaucd1 = 0;
                p4_gameplay.megamallaucd1 = 0;
                p4_gameplay.articmallaucd1 = 0;
                p4_gameplay.heavenlymallaucd1 = 0;
                p4_gameplay.shangrillamallaucd1 = 0;
                p4_gameplay.utility1x1aucd1 = 0;
                p4_gameplay.utility1x2aucd1 = 0;
                p4_gameplay.transportation1x1aucd1 = 0;
                p4_gameplay.transportation1x2aucd1 = 0;
                p4_gameplay.transportation1x3aucd1 = 0;
                p4_gameplay.transportation1x4aucd1 = 0;


                p4_gameplay.easternschoolaucd2 = 0;
                p4_gameplay.westernschoolaucd2 = 0;
                p4_gameplay.visayashighschoolaucd2 = 0;
                p4_gameplay.southernschoolaucd2 = 0;
                p4_gameplay.nationsschoolaucd2 = 0;
                p4_gameplay.westmarketaucd2 = 0;
                p4_gameplay.nightmarketaucd2 = 0;
                p4_gameplay.daymarketaucd2 = 0;
                p4_gameplay.starmarketaucd2 = 0;
                p4_gameplay.moonmarketaucd2 = 0;
                p4_gameplay.megamarketaucd2 = 0;
                p4_gameplay.visayashospitalaucd2 = 0;
                p4_gameplay.hobertshospitalaucd2 = 0;
                p4_gameplay.heartshospitalaucd2 = 0;
                p4_gameplay.internshospitalaucd2 = 0;
                p4_gameplay.nationalhealthhospitalaucd2 = 0;
                p4_gameplay.veteranshospitalaucd2 = 0;
                p4_gameplay.pearlmallaucd2 = 0;
                p4_gameplay.megamallaucd2 = 0;
                p4_gameplay.articmallaucd2 = 0;
                p4_gameplay.heavenlymallaucd2 = 0;
                p4_gameplay.shangrillamallaucd2 = 0;
                p4_gameplay.utility2x1aucd2 = 0;
                p4_gameplay.utility2x2aucd2 = 0;
                p4_gameplay.transportation2x1aucd2 = 0;
                p4_gameplay.transportation2x2aucd2 = 0;
                p4_gameplay.transportation2x3aucd2 = 0;
                p4_gameplay.transportation2x4aucd2 = 0;

                p4_gameplay.easternschoolaucd3 = 0;
                p4_gameplay.westernschoolaucd3 = 0;
                p4_gameplay.visayashighschoolaucd3 = 0;
                p4_gameplay.southernschoolaucd3 = 0;
                p4_gameplay.nationsschoolaucd3 = 0;
                p4_gameplay.westmarketaucd3 = 0;
                p4_gameplay.nightmarketaucd3 = 0;
                p4_gameplay.daymarketaucd3 = 0;
                p4_gameplay.starmarketaucd3 = 0;
                p4_gameplay.moonmarketaucd3 = 0;
                p4_gameplay.megamarketaucd3 = 0;
                p4_gameplay.visayashospitalaucd3 = 0;
                p4_gameplay.hobertshospitalaucd3 = 0;
                p4_gameplay.heartshospitalaucd3 = 0;
                p4_gameplay.internshospitalaucd3 = 0;
                p4_gameplay.nationalhealthhospitalaucd3 = 0;
                p4_gameplay.veteranshospitalaucd3 = 0;
                p4_gameplay.pearlmallaucd3 = 0;
                p4_gameplay.megamallaucd3 = 0;
                p4_gameplay.articmallaucd3 = 0;
                p4_gameplay.heavenlymallaucd3 = 0;
                p4_gameplay.shangrillamallaucd3 = 0;
                p4_gameplay.utility3x1aucd3 = 0;
                p4_gameplay.utility3x2aucd3 = 0;
                p4_gameplay.transportation3x1aucd3 = 0;
                p4_gameplay.transportation3x2aucd3 = 0;
                p4_gameplay.transportation3x3aucd3 = 0;
                p4_gameplay.transportation3x4aucd3 = 0;

                p4_gameplay.easternschoolaucd4 = 0;
                p4_gameplay.westernschoolaucd4 = 0;
                p4_gameplay.visayashighschoolaucd4 = 0;
                p4_gameplay.southernschoolaucd4 = 0;
                p4_gameplay.nationsschoolaucd4 = 0;
                p4_gameplay.westmarketaucd4 = 0;
                p4_gameplay.nightmarketaucd4 = 0;
                p4_gameplay.daymarketaucd4 = 0;
                p4_gameplay.starmarketaucd4 = 0;
                p4_gameplay.moonmarketaucd4 = 0;
                p4_gameplay.megamarketaucd4 = 0;
                p4_gameplay.visayashospitalaucd4 = 0;
                p4_gameplay.hobertshospitalaucd4 = 0;
                p4_gameplay.heartshospitalaucd4 = 0;
                p4_gameplay.internshospitalaucd4 = 0;
                p4_gameplay.nationalhealthhospitalaucd4 = 0;
                p4_gameplay.veteranshospitalaucd4 = 0;
                p4_gameplay.pearlmallaucd4 = 0;
                p4_gameplay.megamallaucd4 = 0;
                p4_gameplay.articmallaucd4 = 0;
                p4_gameplay.heavenlymallaucd4 = 0;
                p4_gameplay.shangrillamallaucd4 = 0;
                p4_gameplay.utility4x1aucd4 = 0;
                p4_gameplay.utility4x2aucd4 = 0;
                p4_gameplay.transportation4x1aucd4 = 0;
                p4_gameplay.transportation4x2aucd4 = 0;
                p4_gameplay.transportation4x3aucd4 = 0;
                p4_gameplay.transportation4x4aucd4 = 0;

                //auction
                p4_gameplay.easternschoolauc1 = 0;
                p4_gameplay.westernschoolauc1 = 0;
                p4_gameplay.visayashighschoolauc1 = 0;
                p4_gameplay.southernschoolauc1 = 0;
                p4_gameplay.nationsschoolauc1 = 0;
                p4_gameplay.westmarketauc1 = 0;
                p4_gameplay.nightmarketauc1 = 0;
                p4_gameplay.daymarketauc1 = 0;
                p4_gameplay.starmarketauc1 = 0;
                p4_gameplay.moonmarketauc1 = 0;
                p4_gameplay.megamarketauc1 = 0;
                p4_gameplay.visayashospitalauc1 = 0;
                p4_gameplay.hobertshospitalauc1 = 0;
                p4_gameplay.heartshospitalauc1 = 0;
                p4_gameplay.internshospitalauc1 = 0;
                p4_gameplay.nationalhealthhospitalauc1 = 0;
                p4_gameplay.veteranshospitalauc1 = 0;
                p4_gameplay.pearlmallauc1 = 0;
                p4_gameplay.megamallauc1 = 0;
                p4_gameplay.articmallauc1 = 0;
                p4_gameplay.heavenlymallauc1 = 0;
                p4_gameplay.shangrillamallauc1 = 0;
                p4_gameplay.utility1x1auc1 = 0;
                p4_gameplay.utility1x2auc1 = 0;
                p4_gameplay.transportation1x1auc1 = 0;
                p4_gameplay.transportation1x2auc1 = 0;
                p4_gameplay.transportation1x3auc1 = 0;
                p4_gameplay.transportation1x4auc1 = 0;


                p4_gameplay.easternschoolauc2 = 0;
                p4_gameplay.westernschoolauc2 = 0;
                p4_gameplay.visayashighschoolauc2 = 0;
                p4_gameplay.southernschoolauc2 = 0;
                p4_gameplay.nationsschoolauc2 = 0;
                p4_gameplay.westmarketauc2 = 0;
                p4_gameplay.nightmarketauc2 = 0;
                p4_gameplay.daymarketauc2 = 0;
                p4_gameplay.starmarketauc2 = 0;
                p4_gameplay.moonmarketauc2 = 0;
                p4_gameplay.megamarketauc2 = 0;
                p4_gameplay.visayashospitalauc2 = 0;
                p4_gameplay.hobertshospitalauc2 = 0;
                p4_gameplay.heartshospitalauc2 = 0;
                p4_gameplay.internshospitalauc2 = 0;
                p4_gameplay.nationalhealthhospitalauc2 = 0;
                p4_gameplay.veteranshospitalauc2 = 0;
                p4_gameplay.pearlmallauc2 = 0;
                p4_gameplay.megamallauc2 = 0;
                p4_gameplay.articmallauc2 = 0;
                p4_gameplay.heavenlymallauc2 = 0;
                p4_gameplay.shangrillamallauc2 = 0;
                p4_gameplay.utility2x1auc2 = 0;
                p4_gameplay.utility2x2auc2 = 0;
                p4_gameplay.transportation2x1auc2 = 0;
                p4_gameplay.transportation2x2auc2 = 0;
                p4_gameplay.transportation2x3auc2 = 0;
                p4_gameplay.transportation2x4auc2 = 0;

                p4_gameplay.easternschoolauc3 = 0;
                p4_gameplay.westernschoolauc3 = 0;
                p4_gameplay.visayashighschoolauc3 = 0;
                p4_gameplay.southernschoolauc3 = 0;
                p4_gameplay.nationsschoolauc3 = 0;
                p4_gameplay.westmarketauc3 = 0;
                p4_gameplay.nightmarketauc3 = 0;
                p4_gameplay.daymarketauc3 = 0;
                p4_gameplay.starmarketauc3 = 0;
                p4_gameplay.moonmarketauc3 = 0;
                p4_gameplay.megamarketauc3 = 0;
                p4_gameplay.visayashospitalauc3 = 0;
                p4_gameplay.hobertshospitalauc3 = 0;
                p4_gameplay.heartshospitalauc3 = 0;
                p4_gameplay.internshospitalauc3 = 0;
                p4_gameplay.nationalhealthhospitalauc3 = 0;
                p4_gameplay.veteranshospitalauc3 = 0;
                p4_gameplay.pearlmallauc3 = 0;
                p4_gameplay.megamallauc3 = 0;
                p4_gameplay.articmallauc3 = 0;
                p4_gameplay.heavenlymallauc3 = 0;
                p4_gameplay.shangrillamallauc3 = 0;
                p4_gameplay.utility3x1auc3 = 0;
                p4_gameplay.utility3x2auc3 = 0;
                p4_gameplay.transportation3x1auc3 = 0;
                p4_gameplay.transportation3x2auc3 = 0;
                p4_gameplay.transportation3x3auc3 = 0;
                p4_gameplay.transportation3x4auc3 = 0;

                p4_gameplay.easternschoolauc4 = 0;
                p4_gameplay.westernschoolauc4 = 0;
                p4_gameplay.visayashighschoolauc4 = 0;
                p4_gameplay.southernschoolauc4 = 0;
                p4_gameplay.nationsschoolauc4 = 0;
                p4_gameplay.westmarketauc4 = 0;
                p4_gameplay.nightmarketauc4 = 0;
                p4_gameplay.daymarketauc4 = 0;
                p4_gameplay.starmarketauc4 = 0;
                p4_gameplay.moonmarketauc4 = 0;
                p4_gameplay.megamarketauc4 = 0;
                p4_gameplay.visayashospitalauc4 = 0;
                p4_gameplay.hobertshospitalauc4 = 0;
                p4_gameplay.heartshospitalauc4 = 0;
                p4_gameplay.internshospitalauc4 = 0;
                p4_gameplay.nationalhealthhospitalauc4 = 0;
                p4_gameplay.veteranshospitalauc4 = 0;
                p4_gameplay.pearlmallauc4 = 0;
                p4_gameplay.megamallauc4 = 0;
                p4_gameplay.articmallauc4 = 0;
                p4_gameplay.heavenlymallauc4 = 0;
                p4_gameplay.shangrillamallauc4 = 0;
                p4_gameplay.utility4x1auc4 = 0;
                p4_gameplay.utility4x2auc4 = 0;
                p4_gameplay.transportation4x1auc4 = 0;
                p4_gameplay.transportation4x2auc4 = 0;
                p4_gameplay.transportation4x3auc4 = 0;
                p4_gameplay.transportation4x4auc4 = 0;
                this.Close();
                click.Play();
            }
        }

        private void btndec2_Click(object sender, EventArgs e)
        {
            if (p2aucnotif.Text.StartsWith("Do you want to leave auction?"))
            {
                notif2.Visible = false;
                p2auc.Enabled = true;
                p2auc.Visible = true;
                decline.Play();
            }
        }

        private void btndec1_Click(object sender, EventArgs e)
        {
            if (p1aucnotif.Text.StartsWith("Do you want to leave auction?"))
            {
                notif1.Visible = false;
                p1auc.Enabled = true;
                p1auc.Visible = true;
                decline.Play();
            }

        }

        private void btndec3_Click(object sender, EventArgs e)
        {
            if (p3aucnotif.Text.StartsWith("Do you want to leave auction?"))
            {
                notif3.Visible = false;
                p3auc.Enabled = true;
                p3auc.Visible = true;
                decline.Play();
            }

        }

        private void btndec4_Click(object sender, EventArgs e)
        {
            if (p4aucnotif.Text.StartsWith("Do you want to leave auction?"))
            {
                notif4.Visible = false;
                p4auc.Enabled = true;
                p4auc.Visible = true;
                decline.Play();
            }

        }



    }
}
