using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie
{
    public partial class Form6 : Form
    {
        bool memes;
        int nr = 1;
        int t = 0;
        int r, g, b;
        int refuz = 0;
        int stop_pause=1;
        int volum = 1;
        int volum_initial;
        int meme;
        public Form6()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            stanga_output.Visible = false;
            TAB.BackgroundImage = Properties.Resources.bars;
           
            stanga_output.BackColor = Color.FromArgb(22, 18, 88);
            ARROW.BackgroundImage = Properties.Resources.left;
            E1.FlatStyle = Biog1.FlatStyle = S1.FlatStyle = T1.FlatStyle = FlatStyle.Flat;
            E1.Font = Biog1.Font = S1.Font = T1.Font = new Font("Microsoft Sans Serif", 20);
            E1.ForeColor = Biog1.ForeColor = T1.ForeColor =S1.ForeColor = Color.FromArgb(236, 240,241);


            B1.FlatStyle = B2.FlatStyle = B3.FlatStyle = B4.FlatStyle = B5.FlatStyle = B6.FlatStyle = B7.FlatStyle = B8.FlatStyle = B9.FlatStyle = B10.FlatStyle = B11.FlatStyle = B12.FlatStyle = B13.FlatStyle = B14.FlatStyle = B15.FlatStyle = B16.FlatStyle = B17.FlatStyle = B18.FlatStyle = B19.FlatStyle = B20.FlatStyle = B21.FlatStyle = B22.FlatStyle = B23.FlatStyle = B24.FlatStyle = B25.FlatStyle = B26.FlatStyle = B27.FlatStyle = B28.FlatStyle = B29.FlatStyle = B30.FlatStyle = B31.FlatStyle = B32.FlatStyle = B33.FlatStyle = B34.FlatStyle = B35.FlatStyle = B36.FlatStyle = B37.FlatStyle = B38.FlatStyle = B39.FlatStyle = B40.FlatStyle = B41.FlatStyle = B42.FlatStyle = B43.FlatStyle = B44.FlatStyle = B45.FlatStyle = B46.FlatStyle = B47.FlatStyle = B48.FlatStyle = B49.FlatStyle = B50.FlatStyle = B51.FlatStyle = B52.FlatStyle = B53.FlatStyle = B54.FlatStyle = B55.FlatStyle = B56.FlatStyle = B57.FlatStyle = B58.FlatStyle = B59.FlatStyle = B60.FlatStyle = B61.FlatStyle = B62.FlatStyle = B63.FlatStyle = B64.FlatStyle = B65.FlatStyle = FlatStyle.Flat;

            E1.MouseEnter += OnMouseEnterE1; E1.MouseLeave += OnMouseLeaveE1;
            T1.MouseEnter += OnMouseEnterT1; T1.MouseLeave += OnMouseLeaveT1;
            S1.MouseEnter += OnMouseEnterS1; S1.MouseLeave += OnMouseLeaveS1;
            Biog1.MouseEnter += OnMouseEnterBiog1; Biog1.MouseLeave += OnMouseLeaveBiog1;
            
            
            L1.BackColor = Color.FromArgb(0, 0, 0, 0);
            nr = 1;


            play_stop.Cursor = speaker.Cursor = guna2TrackBar1.Cursor = guna2TrackBar2.Cursor = E1.Cursor = T1.Cursor = Biog1.Cursor = S1.Cursor = ARROW.Cursor = TAB.Cursor = DA.Cursor = NU.Cursor = Cursors.Hand;
            
            /**
            button1.Text = "Show";
            button2.Text = "Hide";
     **/
            L1.Text = "Prima Sonda si Rafinarie De Petrol Din Lume (A Fost In Romania)";
            L2.Text = "Why the Shortest War in History Lasted 38 Minutes";
            L3.Text = "First World War tech: Zeppelins";
            L4.Text = "Carrier Pigeons (World War I)";
            L5.Text = "Sniper Decoys: Fake Horse and other Dummies";
            L6.Text = "Flamethrower Trooper (World War I)";
            L7.Text = "Sniper Decoys: Dummy Heads";
            L8.Text = "How were trees used to kill and spy in WWI?";
            L9.Text = "Tunnel Warfare During World War 1 I THE GREAT WAR Special";
            L10.Text = "Armoured Trains of World War 1 I THE GREAT WAR Special feat. Military History Visualized";
            L11.Text = "The Edge of the Abyss - Mountain Warfare On The Italian Front I THE GREAT WAR Special";
            L12.Text = "Poison Gas Warfare In WW1 I THE GREAT WAR Special";
            L13.Text = "Reinventing Cavalry in WW1 - Bulgarian General Ivan Kolev I WHO DID WHAT IN WW1?";
            L14.Text = "Cavalry in WW1 - Between Tradition and Machine Gun Fire I THE GREAT WAR Special";
            L15.Text = "The Most Decorated Dog of WWI";
            L16.Text = "World of Tanks: What is a tank? History of tanks";
            L17.Text = "Boy Soldiers (World War I)";
            L18.Text = "A Short History of the Poppy";
            L19.Text = "The facial prosthetics of World War I";
            L20.Text = "Escrocul Care A Vândut Turnul Eiffel... De Două Ori - OAI#5";
            L21.Text = "How the Hindenburg killed an entire industry";
            L22.Text = "Germania în anii '30 (pe SPEED)";
            L23.Text = "Când Au Intrat Germanii În Franța (Pe SPEED)";
            L24.Text = "Fanta: How One Man In Nazi Germany Created a Global Soda";
            L25.Text = "Bear Who Fought Alongside Soldiers in World War 2";
            L26.Text = "Schwerer Gustav - Rail Super Gun (Behemoth)";
            L27.Text = "Dragons Teeth (World War II Tech)";
            L28.Text = "How Hitler Survived Assassination Attempts";
            L29.Text = "The Nazi Weather Station in North America";
            L30.Text = "Why Did The Nazis Have A Secret Base in the Arctic?";
            L31.Text = "Stolen WWII Gold Found in German Tunnels | In Search Of (Season 2) | History";
            L32.Text = "How the Swiss Protected Hitler's Gold";
            L33.Text = "The Nazi Gold Train";
            L34.Text = "Raiders of the Lost Art - Hitler's Secret Treasure Castle";
            L35.Text = "The Real Castle Wolfenstein";
            L36.Text = "The Ship that escaped capture disguised as a tropical island";
            L37.Text = "Germanii Și Armata Fantomă - OAI#6";
            L38.Text = "The US Army & German Wehrmacht VS Waffen SS - Battle for Castle Itter 1945";
         
            L39.Text = "Chef Boyardee Goes to War";
     
            L40.Text = "Why the Soviets doctored this iconic photo";
            L41.Text = "Why Japan and Russia are Technically Still Fighting WWII";
            L42.Text = "BMW: The Dark Story of a German Dynasty";
            L43.Text = "Nutella: The Miracle of WW2";
            L44.Text = "Why Did So Many German Officers Flee to Argentina after WW2?";
            L45.Text = "The secret history of fondue";
            L46.Text = "Saint Petersburg's Gilded Church of Blood and Potatoes";
            L47.Text = "Berlin Airlift: The Cold War Begins - Extra History";
            L48.Text = "Why Soviet Russia Invented A Clear Coca Cola?";
            L49.Text = "Secret Cold War Gadgets";
            L50.Text = "How the US Government Kept a Town of 75,000 Secret";
            L51.Text = "The CIA's 638 Attempts to Assassinate Castro";
            L52.Text = "What was Superglue used for in the Vietnam War?";
            L53.Text = "What was duct tape used for in the Vietnam war?";
            L54.Text = "Helmet Graffiti in the Vietnam War";
            L55.Text = "Death cards (The Vietnam War)";
            L56.Text = "How Tootsie Rolls Saved the Troops";
            L57.Text = "Tancurile Rusesti Topite de Laserul Romanesc in 1968";
            L58.Text = "Insula SCUFUNDATĂ de CEAUȘESCU";
            L59.Text = "The 8-Year Long Worst Traffic Jam in History";
            L60.Text = "The Bit of East Germany That Might Still Exist";
            L61.Text = "Why There's a Completely Russian Town in Norway";
            L62.Text = "The Football war (Weird Wars)";
            L63.Text = "How This Lake in Northwest Asia Got Deadlier Than Chernobyl";
            L64.Text = "How Pepsi Became The 6th Largest Military In The World";
            L65.Text = "That Time When Kazakhstan Was the Entire USSR For 4 Days";

            B1.Cursor = L1.Cursor = P1.Cursor = B2.Cursor = L2.Cursor = P2.Cursor = B3.Cursor = L3.Cursor = P3.Cursor = B4.Cursor = L4.Cursor = P4.Cursor = B5.Cursor = L5.Cursor = P5.Cursor = B6.Cursor = L6.Cursor = P6.Cursor = B7.Cursor = L7.Cursor = P7.Cursor = B8.Cursor = L8.Cursor = P8.Cursor = B9.Cursor = L9.Cursor = P9.Cursor = B10.Cursor = L10.Cursor = P10.Cursor = B11.Cursor = L11.Cursor = P11.Cursor = B12.Cursor = L12.Cursor = P12.Cursor = B13.Cursor = L13.Cursor = P13.Cursor = B14.Cursor = L14.Cursor = P14.Cursor = B15.Cursor = L15.Cursor = P15.Cursor = B16.Cursor = L16.Cursor = P16.Cursor = B17.Cursor = L17.Cursor = P17.Cursor = B18.Cursor = L18.Cursor = P18.Cursor = B19.Cursor = L19.Cursor = P19.Cursor = B20.Cursor = L20.Cursor = P20.Cursor = B21.Cursor = L21.Cursor = P21.Cursor = B22.Cursor = L22.Cursor = P22.Cursor = B23.Cursor = L23.Cursor = P23.Cursor = B24.Cursor = L24.Cursor = P24.Cursor = B25.Cursor = L25.Cursor = P25.Cursor = B26.Cursor = L26.Cursor = P26.Cursor = B27.Cursor = L27.Cursor = P27.Cursor = B28.Cursor = L28.Cursor = P28.Cursor = B29.Cursor = L29.Cursor = P29.Cursor = B30.Cursor = L30.Cursor = P30.Cursor = B31.Cursor = L31.Cursor = P31.Cursor = B32.Cursor = L32.Cursor = P32.Cursor = B33.Cursor = L33.Cursor = P33.Cursor = B34.Cursor = L34.Cursor = P34.Cursor = B35.Cursor = L35.Cursor = P35.Cursor = B36.Cursor = L36.Cursor = P36.Cursor = B37.Cursor = L37.Cursor = P37.Cursor = B38.Cursor = L38.Cursor = P38.Cursor = B39.Cursor = L39.Cursor = P39.Cursor = B40.Cursor = L40.Cursor = P40.Cursor = B41.Cursor = L41.Cursor = P41.Cursor = B42.Cursor = L42.Cursor = P42.Cursor = B43.Cursor = L43.Cursor = P43.Cursor = B44.Cursor = L44.Cursor = P44.Cursor = B45.Cursor = L45.Cursor = P45.Cursor = B46.Cursor = L46.Cursor = P46.Cursor = B47.Cursor = L47.Cursor = P47.Cursor = B48.Cursor = L48.Cursor = P48.Cursor = B49.Cursor = L49.Cursor = P49.Cursor = B50.Cursor = L50.Cursor = P50.Cursor = B51.Cursor = L51.Cursor = P51.Cursor = B52.Cursor = L52.Cursor = P52.Cursor = B53.Cursor = L53.Cursor = P53.Cursor = B54.Cursor = L54.Cursor = P54.Cursor = B55.Cursor = L55.Cursor = P55.Cursor = B56.Cursor = L56.Cursor = P56.Cursor = B57.Cursor = L57.Cursor = P57.Cursor = B58.Cursor = L58.Cursor = P58.Cursor = B59.Cursor = L59.Cursor = P59.Cursor = B60.Cursor = L60.Cursor = P60.Cursor = B61.Cursor = L61.Cursor = P61.Cursor = B62.Cursor = L62.Cursor = P62.Cursor = B63.Cursor = L63.Cursor = P63.Cursor = B64.Cursor = L64.Cursor = P64.Cursor = B65.Cursor = L65.Cursor = P65.Cursor = Cursors.Hand;

            mafiamember.BackgroundImage = Properties.Resources.mafiot;
            DA.Cursor = NU.Cursor = interogatoriu.Cursor = mafiamember.Cursor = Cursors.Hand;

            P1.BackgroundImage = Properties.Resources.tbn1;
            P2.BackgroundImage = Properties.Resources.tbn2;
            P3.BackgroundImage = Properties.Resources.tbn3;
            P4.BackgroundImage = Properties.Resources.tbn4;
            P5.BackgroundImage = Properties.Resources.tbn5;
            P6.BackgroundImage = Properties.Resources.tbn6;
            P7.BackgroundImage = Properties.Resources.tbn7;
            P8.BackgroundImage = Properties.Resources.tbn8;
            P9.BackgroundImage = Properties.Resources.tbn9;
            P10.BackgroundImage = Properties.Resources.tbn10;
            P11.BackgroundImage = Properties.Resources.tbn11;
            P12.BackgroundImage = Properties.Resources.tbn12;
            P13.BackgroundImage = Properties.Resources.tbn13;
            P14.BackgroundImage = Properties.Resources.tbn14;
            P15.BackgroundImage = Properties.Resources.tbn15;
            P16.BackgroundImage = Properties.Resources.tbn16;
            P17.BackgroundImage = Properties.Resources.tbn17;
            P18.BackgroundImage = Properties.Resources.tbn18;
            P19.BackgroundImage = Properties.Resources.tbn19;
            P20.BackgroundImage = Properties.Resources.tbn20;
            P21.BackgroundImage = Properties.Resources.tbn21;
            P22.BackgroundImage = Properties.Resources.tbn22;
            P23.BackgroundImage = Properties.Resources.tbn23;
            P24.BackgroundImage = Properties.Resources.tbn24;
            P25.BackgroundImage = Properties.Resources.tbn25;
           P26.BackgroundImage = Properties.Resources.tbn26;
            P27.BackgroundImage = Properties.Resources.tbn27;
            P28.BackgroundImage = Properties.Resources.tbn28;
            P29.BackgroundImage = Properties.Resources.tbn29;
            P30.BackgroundImage = Properties.Resources.tbn30;
            P31.BackgroundImage = Properties.Resources.tbn31;
            P32.BackgroundImage = Properties.Resources.tbn32;
            P33.BackgroundImage = Properties.Resources.tbn33;
            P34.BackgroundImage = Properties.Resources.tbn34;
            P35.BackgroundImage = Properties.Resources.tbn35;
            P36.BackgroundImage = Properties.Resources.tbn36;
            P37.BackgroundImage = Properties.Resources.tbn37;
            P38.BackgroundImage = Properties.Resources.tbn38;
            P39.BackgroundImage = Properties.Resources.tbn39;
            P40.BackgroundImage = Properties.Resources.tbn40;
            P41.BackgroundImage = Properties.Resources.tbn41;
            P42.BackgroundImage = Properties.Resources.tbn42;
            P43.BackgroundImage = Properties.Resources.tbn43;
            P44.BackgroundImage = Properties.Resources.tbn44;
            P45.BackgroundImage = Properties.Resources.tbn45;
            P46.BackgroundImage = Properties.Resources.tbn46;
            P47.BackgroundImage = Properties.Resources.tbn47;
            P48.BackgroundImage = Properties.Resources.tbn48;
            P49.BackgroundImage = Properties.Resources.tbn49;
            P50.BackgroundImage = Properties.Resources.tbn50;
            P51.BackgroundImage = Properties.Resources.tbn51;
            P52.BackgroundImage = Properties.Resources.tbn52;
            P53.BackgroundImage = Properties.Resources.tbn53;
            P54.BackgroundImage = Properties.Resources.tbn54;
            P55.BackgroundImage = Properties.Resources.tbn55;
            P56.BackgroundImage = Properties.Resources.tbn56;
            P57.BackgroundImage = Properties.Resources.tbn57;
            P58.BackgroundImage = Properties.Resources.tbn58;
            P59.BackgroundImage = Properties.Resources.tbn59;
            P60.BackgroundImage = Properties.Resources.tbn60;
            P61.BackgroundImage = Properties.Resources.tbn61;
            P62.BackgroundImage = Properties.Resources.tbn62;
            P63.BackgroundImage = Properties.Resources.tbn63;
            P64.BackgroundImage = Properties.Resources.tbn64;
            P65.BackgroundImage = Properties.Resources.tbn65;

            r = 22;g = 18;b = 126;
            L1.TextAlign = L2.TextAlign = L3.TextAlign = L4.TextAlign = L5.TextAlign = L6.TextAlign = L7.TextAlign = L8.TextAlign = L9.TextAlign = L10.TextAlign = L11.TextAlign = L12.TextAlign = L13.TextAlign = L14.TextAlign = L15.TextAlign = L16.TextAlign = L17.TextAlign = L18.TextAlign = L19.TextAlign = L20.TextAlign = L21.TextAlign = L22.TextAlign = L23.TextAlign = L24.TextAlign = L25.TextAlign = L26.TextAlign = L27.TextAlign = L28.TextAlign = L29.TextAlign = L30.TextAlign = L31.TextAlign = L32.TextAlign = L33.TextAlign = L34.TextAlign = L35.TextAlign = L36.TextAlign = L37.TextAlign = L38.TextAlign = L39.TextAlign = L40.TextAlign = L41.TextAlign = L42.TextAlign = L43.TextAlign = L44.TextAlign = L45.TextAlign = L46.TextAlign = L47.TextAlign = L48.TextAlign = L49.TextAlign = L50.TextAlign = L51.TextAlign = L52.TextAlign = L53.TextAlign = L54.TextAlign = L55.TextAlign = L56.TextAlign = L57.TextAlign = L58.TextAlign = L59.TextAlign = L60.TextAlign = L61.TextAlign = L62.TextAlign = L63.TextAlign = L64.TextAlign = L65.TextAlign = ContentAlignment.MiddleLeft;

            B1.MouseEnter += OnMouseEnterB1; B1.MouseLeave += OnMouseLeaveB1;
            L1.MouseEnter += OnMouseEnterB1; L1.MouseLeave += OnMouseLeaveB1;
            P1.MouseEnter += OnMouseEnterB1; P1.MouseLeave += OnMouseLeaveB1;

            B2.MouseEnter += OnMouseEnterB2; B2.MouseLeave += OnMouseLeaveB2;
            L2.MouseEnter += OnMouseEnterB2; L2.MouseLeave += OnMouseLeaveB2;
            P2.MouseEnter += OnMouseEnterB2; P2.MouseLeave += OnMouseLeaveB2;

            B3.MouseEnter += OnMouseEnterB3; B3.MouseLeave += OnMouseLeaveB3;
            L3.MouseEnter += OnMouseEnterB3; L3.MouseLeave += OnMouseLeaveB3;
            P3.MouseEnter += OnMouseEnterB3; P3.MouseLeave += OnMouseLeaveB3;

            B4.MouseEnter += OnMouseEnterB4; B4.MouseLeave += OnMouseLeaveB4;
            L4.MouseEnter += OnMouseEnterB4; L4.MouseLeave += OnMouseLeaveB4;
            P4.MouseEnter += OnMouseEnterB4; P4.MouseLeave += OnMouseLeaveB4;

            B5.MouseEnter += OnMouseEnterB5; B5.MouseLeave += OnMouseLeaveB5;
            L5.MouseEnter += OnMouseEnterB5; L5.MouseLeave += OnMouseLeaveB5;
            P5.MouseEnter += OnMouseEnterB5; P5.MouseLeave += OnMouseLeaveB5;

            B6.MouseEnter += OnMouseEnterB6; B6.MouseLeave += OnMouseLeaveB6;
            L6.MouseEnter += OnMouseEnterB6; L6.MouseLeave += OnMouseLeaveB6;
            P6.MouseEnter += OnMouseEnterB6; P6.MouseLeave += OnMouseLeaveB6;

            B7.MouseEnter += OnMouseEnterB7; B7.MouseLeave += OnMouseLeaveB7;
            L7.MouseEnter += OnMouseEnterB7; L7.MouseLeave += OnMouseLeaveB7;
            P7.MouseEnter += OnMouseEnterB7; P7.MouseLeave += OnMouseLeaveB7;

            B8.MouseEnter += OnMouseEnterB8; B8.MouseLeave += OnMouseLeaveB8;
            L8.MouseEnter += OnMouseEnterB8; L8.MouseLeave += OnMouseLeaveB8;
            P8.MouseEnter += OnMouseEnterB8; P8.MouseLeave += OnMouseLeaveB8;

            B9.MouseEnter += OnMouseEnterB9; B9.MouseLeave += OnMouseLeaveB9;
            L9.MouseEnter += OnMouseEnterB9; L9.MouseLeave += OnMouseLeaveB9;
            P9.MouseEnter += OnMouseEnterB9; P9.MouseLeave += OnMouseLeaveB9;

            B10.MouseEnter += OnMouseEnterB10; B10.MouseLeave += OnMouseLeaveB10;
            L10.MouseEnter += OnMouseEnterB10; L10.MouseLeave += OnMouseLeaveB10;
            P10.MouseEnter += OnMouseEnterB10; P10.MouseLeave += OnMouseLeaveB10;

            B11.MouseEnter += OnMouseEnterB11; B11.MouseLeave += OnMouseLeaveB11;
            L11.MouseEnter += OnMouseEnterB11; L11.MouseLeave += OnMouseLeaveB11;
            P11.MouseEnter += OnMouseEnterB11; P11.MouseLeave += OnMouseLeaveB11;

            B12.MouseEnter += OnMouseEnterB12; B12.MouseLeave += OnMouseLeaveB12;
            L12.MouseEnter += OnMouseEnterB12; L12.MouseLeave += OnMouseLeaveB12;
            P12.MouseEnter += OnMouseEnterB12; P12.MouseLeave += OnMouseLeaveB12;

            B13.MouseEnter += OnMouseEnterB13; B13.MouseLeave += OnMouseLeaveB13;
            L13.MouseEnter += OnMouseEnterB13; L13.MouseLeave += OnMouseLeaveB13;
            P13.MouseEnter += OnMouseEnterB13; P13.MouseLeave += OnMouseLeaveB13;

            B14.MouseEnter += OnMouseEnterB14; B14.MouseLeave += OnMouseLeaveB14;
            L14.MouseEnter += OnMouseEnterB14; L14.MouseLeave += OnMouseLeaveB14;
            P14.MouseEnter += OnMouseEnterB14; P14.MouseLeave += OnMouseLeaveB14;

            B15.MouseEnter += OnMouseEnterB15; B15.MouseLeave += OnMouseLeaveB15;
            L15.MouseEnter += OnMouseEnterB15; L15.MouseLeave += OnMouseLeaveB15;
            P15.MouseEnter += OnMouseEnterB15; P15.MouseLeave += OnMouseLeaveB15;

            B16.MouseEnter += OnMouseEnterB16; B16.MouseLeave += OnMouseLeaveB16;
            L16.MouseEnter += OnMouseEnterB16; L16.MouseLeave += OnMouseLeaveB16;
            P16.MouseEnter += OnMouseEnterB16; P16.MouseLeave += OnMouseLeaveB16;

            B17.MouseEnter += OnMouseEnterB17; B17.MouseLeave += OnMouseLeaveB17;
            L17.MouseEnter += OnMouseEnterB17; L17.MouseLeave += OnMouseLeaveB17;
            P17.MouseEnter += OnMouseEnterB17; P17.MouseLeave += OnMouseLeaveB17;

            B18.MouseEnter += OnMouseEnterB18; B18.MouseLeave += OnMouseLeaveB18;
            L18.MouseEnter += OnMouseEnterB18; L18.MouseLeave += OnMouseLeaveB18;
            P18.MouseEnter += OnMouseEnterB18; P18.MouseLeave += OnMouseLeaveB18;

            B19.MouseEnter += OnMouseEnterB19; B19.MouseLeave += OnMouseLeaveB19;
            L19.MouseEnter += OnMouseEnterB19; L19.MouseLeave += OnMouseLeaveB19;
            P19.MouseEnter += OnMouseEnterB19; P19.MouseLeave += OnMouseLeaveB19;

            B20.MouseEnter += OnMouseEnterB20; B20.MouseLeave += OnMouseLeaveB20;
            L20.MouseEnter += OnMouseEnterB20; L20.MouseLeave += OnMouseLeaveB20;
            P20.MouseEnter += OnMouseEnterB20; P20.MouseLeave += OnMouseLeaveB20;

            B21.MouseEnter += OnMouseEnterB21; B21.MouseLeave += OnMouseLeaveB21;
            L21.MouseEnter += OnMouseEnterB21; L21.MouseLeave += OnMouseLeaveB21;
            P21.MouseEnter += OnMouseEnterB21; P21.MouseLeave += OnMouseLeaveB21;

            B22.MouseEnter += OnMouseEnterB22; B22.MouseLeave += OnMouseLeaveB22;
            L22.MouseEnter += OnMouseEnterB22; L22.MouseLeave += OnMouseLeaveB22;
            P22.MouseEnter += OnMouseEnterB22; P22.MouseLeave += OnMouseLeaveB22;

            B23.MouseEnter += OnMouseEnterB23; B23.MouseLeave += OnMouseLeaveB23;
            L23.MouseEnter += OnMouseEnterB23; L23.MouseLeave += OnMouseLeaveB23;
            P23.MouseEnter += OnMouseEnterB23; P23.MouseLeave += OnMouseLeaveB23;

            B24.MouseEnter += OnMouseEnterB24; B24.MouseLeave += OnMouseLeaveB24;
            L24.MouseEnter += OnMouseEnterB24; L24.MouseLeave += OnMouseLeaveB24;
            P24.MouseEnter += OnMouseEnterB24; P24.MouseLeave += OnMouseLeaveB24;

            B25.MouseEnter += OnMouseEnterB25; B25.MouseLeave += OnMouseLeaveB25;
            L25.MouseEnter += OnMouseEnterB25; L25.MouseLeave += OnMouseLeaveB25;
            P25.MouseEnter += OnMouseEnterB25; P25.MouseLeave += OnMouseLeaveB25;

            B26.MouseEnter += OnMouseEnterB26; B26.MouseLeave += OnMouseLeaveB26;
            L26.MouseEnter += OnMouseEnterB26; L26.MouseLeave += OnMouseLeaveB26;
            P26.MouseEnter += OnMouseEnterB26; P26.MouseLeave += OnMouseLeaveB26;

            B27.MouseEnter += OnMouseEnterB27; B27.MouseLeave += OnMouseLeaveB27;
            L27.MouseEnter += OnMouseEnterB27; L27.MouseLeave += OnMouseLeaveB27;
            P27.MouseEnter += OnMouseEnterB27; P27.MouseLeave += OnMouseLeaveB27;

            B28.MouseEnter += OnMouseEnterB28; B28.MouseLeave += OnMouseLeaveB28;
            L28.MouseEnter += OnMouseEnterB28; L28.MouseLeave += OnMouseLeaveB28;
            P28.MouseEnter += OnMouseEnterB28; P28.MouseLeave += OnMouseLeaveB28;

            B29.MouseEnter += OnMouseEnterB29; B29.MouseLeave += OnMouseLeaveB29;
            L29.MouseEnter += OnMouseEnterB29; L29.MouseLeave += OnMouseLeaveB29;
            P29.MouseEnter += OnMouseEnterB29; P29.MouseLeave += OnMouseLeaveB29;

            B30.MouseEnter += OnMouseEnterB30; B30.MouseLeave += OnMouseLeaveB30;
            L30.MouseEnter += OnMouseEnterB30; L30.MouseLeave += OnMouseLeaveB30;
            P30.MouseEnter += OnMouseEnterB30; P30.MouseLeave += OnMouseLeaveB30;

            B31.MouseEnter += OnMouseEnterB31; B31.MouseLeave += OnMouseLeaveB31;
            L31.MouseEnter += OnMouseEnterB31; L31.MouseLeave += OnMouseLeaveB31;
            P31.MouseEnter += OnMouseEnterB31; P31.MouseLeave += OnMouseLeaveB31;

            B32.MouseEnter += OnMouseEnterB32; B32.MouseLeave += OnMouseLeaveB32;
            L32.MouseEnter += OnMouseEnterB32; L32.MouseLeave += OnMouseLeaveB32;
            P32.MouseEnter += OnMouseEnterB32; P32.MouseLeave += OnMouseLeaveB32;

            B33.MouseEnter += OnMouseEnterB33; B33.MouseLeave += OnMouseLeaveB33;
            L33.MouseEnter += OnMouseEnterB33; L33.MouseLeave += OnMouseLeaveB33;
            P33.MouseEnter += OnMouseEnterB33; P33.MouseLeave += OnMouseLeaveB33;

            B34.MouseEnter += OnMouseEnterB34; B34.MouseLeave += OnMouseLeaveB34;
            L34.MouseEnter += OnMouseEnterB34; L34.MouseLeave += OnMouseLeaveB34;
            P34.MouseEnter += OnMouseEnterB34; P34.MouseLeave += OnMouseLeaveB34;

            B35.MouseEnter += OnMouseEnterB35; B35.MouseLeave += OnMouseLeaveB35;
            L35.MouseEnter += OnMouseEnterB35; L35.MouseLeave += OnMouseLeaveB35;
            P35.MouseEnter += OnMouseEnterB35; P35.MouseLeave += OnMouseLeaveB35;

            B36.MouseEnter += OnMouseEnterB36; B36.MouseLeave += OnMouseLeaveB36;
            L36.MouseEnter += OnMouseEnterB36; L36.MouseLeave += OnMouseLeaveB36;
            P36.MouseEnter += OnMouseEnterB36; P36.MouseLeave += OnMouseLeaveB36;

            B37.MouseEnter += OnMouseEnterB37; B37.MouseLeave += OnMouseLeaveB37;
            L37.MouseEnter += OnMouseEnterB37; L37.MouseLeave += OnMouseLeaveB37;
            P37.MouseEnter += OnMouseEnterB37; P37.MouseLeave += OnMouseLeaveB37;

            B38.MouseEnter += OnMouseEnterB38; B38.MouseLeave += OnMouseLeaveB38;
            L38.MouseEnter += OnMouseEnterB38; L38.MouseLeave += OnMouseLeaveB38;
            P38.MouseEnter += OnMouseEnterB38; P38.MouseLeave += OnMouseLeaveB38;

            B39.MouseEnter += OnMouseEnterB39; B39.MouseLeave += OnMouseLeaveB39;
            L39.MouseEnter += OnMouseEnterB39; L39.MouseLeave += OnMouseLeaveB39;
            P39.MouseEnter += OnMouseEnterB39; P39.MouseLeave += OnMouseLeaveB39;

            B40.MouseEnter += OnMouseEnterB40; B40.MouseLeave += OnMouseLeaveB40;
            L40.MouseEnter += OnMouseEnterB40; L40.MouseLeave += OnMouseLeaveB40;
            P40.MouseEnter += OnMouseEnterB40; P40.MouseLeave += OnMouseLeaveB40;

            B41.MouseEnter += OnMouseEnterB41; B41.MouseLeave += OnMouseLeaveB41;
            L41.MouseEnter += OnMouseEnterB41; L41.MouseLeave += OnMouseLeaveB41;
            P41.MouseEnter += OnMouseEnterB41; P41.MouseLeave += OnMouseLeaveB41;

            B42.MouseEnter += OnMouseEnterB42; B42.MouseLeave += OnMouseLeaveB42;
            L42.MouseEnter += OnMouseEnterB42; L42.MouseLeave += OnMouseLeaveB42;
            P42.MouseEnter += OnMouseEnterB42; P42.MouseLeave += OnMouseLeaveB42;

            B43.MouseEnter += OnMouseEnterB43; B43.MouseLeave += OnMouseLeaveB43;
            L43.MouseEnter += OnMouseEnterB43; L43.MouseLeave += OnMouseLeaveB43;
            P43.MouseEnter += OnMouseEnterB43; P43.MouseLeave += OnMouseLeaveB43;

            B44.MouseEnter += OnMouseEnterB44; B44.MouseLeave += OnMouseLeaveB44;
            L44.MouseEnter += OnMouseEnterB44; L44.MouseLeave += OnMouseLeaveB44;
            P44.MouseEnter += OnMouseEnterB44; P44.MouseLeave += OnMouseLeaveB44;

            B45.MouseEnter += OnMouseEnterB45; B45.MouseLeave += OnMouseLeaveB45;
            L45.MouseEnter += OnMouseEnterB45; L45.MouseLeave += OnMouseLeaveB45;
            P45.MouseEnter += OnMouseEnterB45; P45.MouseLeave += OnMouseLeaveB45;

            B46.MouseEnter += OnMouseEnterB46; B46.MouseLeave += OnMouseLeaveB46;
            L46.MouseEnter += OnMouseEnterB46; L46.MouseLeave += OnMouseLeaveB46;
            P46.MouseEnter += OnMouseEnterB46; P46.MouseLeave += OnMouseLeaveB46;

            B47.MouseEnter += OnMouseEnterB47; B47.MouseLeave += OnMouseLeaveB47;
            L47.MouseEnter += OnMouseEnterB47; L47.MouseLeave += OnMouseLeaveB47;
            P47.MouseEnter += OnMouseEnterB47; P47.MouseLeave += OnMouseLeaveB47;

            B48.MouseEnter += OnMouseEnterB48; B48.MouseLeave += OnMouseLeaveB48;
            L48.MouseEnter += OnMouseEnterB48; L48.MouseLeave += OnMouseLeaveB48;
            P48.MouseEnter += OnMouseEnterB48; P48.MouseLeave += OnMouseLeaveB48;

            B49.MouseEnter += OnMouseEnterB49; B49.MouseLeave += OnMouseLeaveB49;
            L49.MouseEnter += OnMouseEnterB49; L49.MouseLeave += OnMouseLeaveB49;
            P49.MouseEnter += OnMouseEnterB49; P49.MouseLeave += OnMouseLeaveB49;

            B50.MouseEnter += OnMouseEnterB50; B50.MouseLeave += OnMouseLeaveB50;
            L50.MouseEnter += OnMouseEnterB50; L50.MouseLeave += OnMouseLeaveB50;
            P50.MouseEnter += OnMouseEnterB50; P50.MouseLeave += OnMouseLeaveB50;

            B51.MouseEnter += OnMouseEnterB51; B51.MouseLeave += OnMouseLeaveB51;
            L51.MouseEnter += OnMouseEnterB51; L51.MouseLeave += OnMouseLeaveB51;
            P51.MouseEnter += OnMouseEnterB51; P51.MouseLeave += OnMouseLeaveB51;

            B52.MouseEnter += OnMouseEnterB52; B52.MouseLeave += OnMouseLeaveB52;
            L52.MouseEnter += OnMouseEnterB52; L52.MouseLeave += OnMouseLeaveB52;
            P52.MouseEnter += OnMouseEnterB52; P52.MouseLeave += OnMouseLeaveB52;

            B53.MouseEnter += OnMouseEnterB53; B53.MouseLeave += OnMouseLeaveB53;
            L53.MouseEnter += OnMouseEnterB53; L53.MouseLeave += OnMouseLeaveB53;
            P53.MouseEnter += OnMouseEnterB53; P53.MouseLeave += OnMouseLeaveB53;

            B54.MouseEnter += OnMouseEnterB54; B54.MouseLeave += OnMouseLeaveB54;
            L54.MouseEnter += OnMouseEnterB54; L54.MouseLeave += OnMouseLeaveB54;
            P54.MouseEnter += OnMouseEnterB54; P54.MouseLeave += OnMouseLeaveB54;

            B55.MouseEnter += OnMouseEnterB55; B55.MouseLeave += OnMouseLeaveB55;
            L55.MouseEnter += OnMouseEnterB55; L55.MouseLeave += OnMouseLeaveB55;
            P55.MouseEnter += OnMouseEnterB55; P55.MouseLeave += OnMouseLeaveB55;

            B56.MouseEnter += OnMouseEnterB56; B56.MouseLeave += OnMouseLeaveB56;
            L56.MouseEnter += OnMouseEnterB56; L56.MouseLeave += OnMouseLeaveB56;
            P56.MouseEnter += OnMouseEnterB56; P56.MouseLeave += OnMouseLeaveB56;

            B57.MouseEnter += OnMouseEnterB57; B57.MouseLeave += OnMouseLeaveB57;
            L57.MouseEnter += OnMouseEnterB57; L57.MouseLeave += OnMouseLeaveB57;
            P57.MouseEnter += OnMouseEnterB57; P57.MouseLeave += OnMouseLeaveB57;

            B58.MouseEnter += OnMouseEnterB58; B58.MouseLeave += OnMouseLeaveB58;
            L58.MouseEnter += OnMouseEnterB58; L58.MouseLeave += OnMouseLeaveB58;
            P58.MouseEnter += OnMouseEnterB58; P58.MouseLeave += OnMouseLeaveB58;

            B59.MouseEnter += OnMouseEnterB59; B59.MouseLeave += OnMouseLeaveB59;
            L59.MouseEnter += OnMouseEnterB59; L59.MouseLeave += OnMouseLeaveB59;
            P59.MouseEnter += OnMouseEnterB59; P59.MouseLeave += OnMouseLeaveB59;

            B60.MouseEnter += OnMouseEnterB60; B60.MouseLeave += OnMouseLeaveB60;
            L60.MouseEnter += OnMouseEnterB60; L60.MouseLeave += OnMouseLeaveB60;
            P60.MouseEnter += OnMouseEnterB60; P60.MouseLeave += OnMouseLeaveB60;

            B61.MouseEnter += OnMouseEnterB61; B61.MouseLeave += OnMouseLeaveB61;
            L61.MouseEnter += OnMouseEnterB61; L61.MouseLeave += OnMouseLeaveB61;
            P61.MouseEnter += OnMouseEnterB61; P61.MouseLeave += OnMouseLeaveB61;

            B62.MouseEnter += OnMouseEnterB62; B62.MouseLeave += OnMouseLeaveB62;
            L62.MouseEnter += OnMouseEnterB62; L62.MouseLeave += OnMouseLeaveB62;
            P62.MouseEnter += OnMouseEnterB62; P62.MouseLeave += OnMouseLeaveB62;

            B63.MouseEnter += OnMouseEnterB63; B63.MouseLeave += OnMouseLeaveB63;
            L63.MouseEnter += OnMouseEnterB63; L63.MouseLeave += OnMouseLeaveB63;
            P63.MouseEnter += OnMouseEnterB63; P63.MouseLeave += OnMouseLeaveB63;

            B64.MouseEnter += OnMouseEnterB64; B64.MouseLeave += OnMouseLeaveB64;
            L64.MouseEnter += OnMouseEnterB64; L64.MouseLeave += OnMouseLeaveB64;
            P64.MouseEnter += OnMouseEnterB64; P64.MouseLeave += OnMouseLeaveB64;

            B65.MouseEnter += OnMouseEnterB65; B65.MouseLeave += OnMouseLeaveB65;
            L65.MouseEnter += OnMouseEnterB65; L65.MouseLeave += OnMouseLeaveB65;
            P65.MouseEnter += OnMouseEnterB65; P65.MouseLeave += OnMouseLeaveB65;
            play_stop.MouseEnter += OnMouseEnterplay_stop; play_stop.MouseLeave += OnMouseLeaveplay_stop;


            interogatoriu.ForeColor = Color.White;
            DA.ForeColor = NU.ForeColor = Color.White;
            DA.MouseEnter += OnMouseEnterDA; DA.MouseLeave += OnMouseLeaveDA;
            NU.MouseEnter += OnMouseEnterNU; NU.MouseLeave += OnMouseLeaveNU;

            play_stop.BackgroundImage = Properties.Resources.pauza_video;
            description.Text = "Întrerupe";description.Visible = false;

            WindowsMediaPlayer.settings.volume = guna2TrackBar2.Value = 100;
            speaker.BackgroundImage = Properties.Resources.speaker_volume;





            nr = 1;navigare();

        }
        private void OnMouseEnterDA(object sender, EventArgs e)
        {
            DA.BackColor = Color.FromArgb(198, 131, 14);
            DA.ForeColor = Color.FromArgb(22, 18, 88);

        }

        private void OnMouseLeaveDA(object sender, EventArgs e)
        {
            DA.BackColor = Color.FromArgb(22, 18, 88);
            DA.ForeColor = Color.White;

        }

        private void OnMouseEnterNU(object sender, EventArgs e)
        {
            NU.BackColor = Color.FromArgb(198, 131, 14);
            NU.ForeColor = Color.FromArgb(22, 18, 88);

        }

        private void OnMouseLeaveNU(object sender, EventArgs e)
        {
            NU.BackColor = Color.FromArgb(22, 18, 88);
            NU.ForeColor = Color.White;

        }


        private void OnMouseEnterE1(object sender, EventArgs e)
        {
            E1.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Underline);


        }
        private void OnMouseLeaveE1(object sender, EventArgs e)
        {
            E1.Font = new Font("Microsoft Sans Serif", 20);


        }



        private void OnMouseEnterS1(object sender, EventArgs e)
        {
            S1.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Underline);


        }
        private void OnMouseLeaveS1(object sender, EventArgs e)
        {
            S1.Font = new Font("Microsoft Sans Serif", 20);


        }
        private void OnMouseEnterT1(object sender, EventArgs e)
        {
            T1.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Underline);


        }
        private void OnMouseLeaveT1(object sender, EventArgs e)
        {
            T1.Font = new Font("Microsoft Sans Serif", 20);


        }


        private void OnMouseEnterBiog1(object sender, EventArgs e)
        {
            Biog1.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Underline);


        }
        private void OnMouseLeaveBiog1(object sender, EventArgs e)
        {
            Biog1.Font = new Font("Microsoft Sans Serif", 20);


        }


        private void OnMouseEnterplay_stop(object sender, EventArgs e)
        {
            description.Visible = true;

        }

        private void OnMouseLeaveplay_stop(object sender, EventArgs e)
        {
             description.Visible = false;
        }


        private void OnMouseEnterB1(object sender, EventArgs e)
        {
            B1.BackColor =L1.BackColor=  Color.Silver;
    
        }

        private void OnMouseLeaveB1(object sender, EventArgs e)
        {
            B1.BackColor = L1.BackColor = Color.White;
        }


        private void OnMouseEnterB2(object sender, EventArgs e)
        {
            B2.BackColor = L2.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB2(object sender, EventArgs e)
        {
            B2.BackColor = L2.BackColor = Color.White;
        }


        private void OnMouseEnterB3(object sender, EventArgs e)
        {
            B3.BackColor = L3.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB3(object sender, EventArgs e)
        {
            B3.BackColor = L3.BackColor = Color.White;
        }


        private void OnMouseEnterB4(object sender, EventArgs e)
        {
            B4.BackColor = L4.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB4(object sender, EventArgs e)
        {
            B4.BackColor = L4.BackColor = Color.White;
        }


        private void OnMouseEnterB5(object sender, EventArgs e)
        {
            B5.BackColor = L5.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB5(object sender, EventArgs e)
        {
            B5.BackColor = L5.BackColor = Color.White;
        }


        private void OnMouseEnterB6(object sender, EventArgs e)
        {
            B6.BackColor = L6.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB6(object sender, EventArgs e)
        {
            B6.BackColor = L6.BackColor = Color.White;
        }


        private void OnMouseEnterB7(object sender, EventArgs e)
        {
            B7.BackColor = L7.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB7(object sender, EventArgs e)
        {
            B7.BackColor = L7.BackColor = Color.White;
        }


        private void OnMouseEnterB8(object sender, EventArgs e)
        {
            B8.BackColor = L8.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB8(object sender, EventArgs e)
        {
            B8.BackColor = L8.BackColor = Color.White;
        }


        private void OnMouseEnterB9(object sender, EventArgs e)
        {
            B9.BackColor = L9.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB9(object sender, EventArgs e)
        {
            B9.BackColor = L9.BackColor = Color.White;
        }


        private void OnMouseEnterB10(object sender, EventArgs e)
        {
            B10.BackColor = L10.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB10(object sender, EventArgs e)
        {
            B10.BackColor = L10.BackColor = Color.White;
        }


        private void OnMouseEnterB11(object sender, EventArgs e)
        {
            B11.BackColor = L11.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB11(object sender, EventArgs e)
        {
            B11.BackColor = L11.BackColor = Color.White;
        }


        private void OnMouseEnterB12(object sender, EventArgs e)
        {
            B12.BackColor = L12.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB12(object sender, EventArgs e)
        {
            B12.BackColor = L12.BackColor = Color.White;
        }


        private void OnMouseEnterB13(object sender, EventArgs e)
        {
            B13.BackColor = L13.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB13(object sender, EventArgs e)
        {
            B13.BackColor = L13.BackColor = Color.White;
        }


        private void OnMouseEnterB14(object sender, EventArgs e)
        {
            B14.BackColor = L14.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB14(object sender, EventArgs e)
        {
            B14.BackColor = L14.BackColor = Color.White;
        }


        private void OnMouseEnterB15(object sender, EventArgs e)
        {
            B15.BackColor = L15.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB15(object sender, EventArgs e)
        {
            B15.BackColor = L15.BackColor = Color.White;
        }


        private void OnMouseEnterB16(object sender, EventArgs e)
        {
            B16.BackColor = L16.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB16(object sender, EventArgs e)
        {
            B16.BackColor = L16.BackColor = Color.White;
        }


        private void OnMouseEnterB17(object sender, EventArgs e)
        {
            B17.BackColor = L17.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB17(object sender, EventArgs e)
        {
            B17.BackColor = L17.BackColor = Color.White;
        }


        private void OnMouseEnterB18(object sender, EventArgs e)
        {
            B18.BackColor = L18.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB18(object sender, EventArgs e)
        {
            B18.BackColor = L18.BackColor = Color.White;
        }


        private void OnMouseEnterB19(object sender, EventArgs e)
        {
            B19.BackColor = L19.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB19(object sender, EventArgs e)
        {
            B19.BackColor = L19.BackColor = Color.White;
        }


        private void OnMouseEnterB20(object sender, EventArgs e)
        {
            B20.BackColor = L20.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB20(object sender, EventArgs e)
        {
            B20.BackColor = L20.BackColor = Color.White;
        }


        private void OnMouseEnterB21(object sender, EventArgs e)
        {
            B21.BackColor = L21.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB21(object sender, EventArgs e)
        {
            B21.BackColor = L21.BackColor = Color.White;
        }


        private void OnMouseEnterB22(object sender, EventArgs e)
        {
            B22.BackColor = L22.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB22(object sender, EventArgs e)
        {
            B22.BackColor = L22.BackColor = Color.White;
        }


        private void OnMouseEnterB23(object sender, EventArgs e)
        {
            B23.BackColor = L23.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB23(object sender, EventArgs e)
        {
            B23.BackColor = L23.BackColor = Color.White;
        }


        private void OnMouseEnterB24(object sender, EventArgs e)
        {
            B24.BackColor = L24.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB24(object sender, EventArgs e)
        {
            B24.BackColor = L24.BackColor = Color.White;
        }


        private void OnMouseEnterB25(object sender, EventArgs e)
        {
            B25.BackColor = L25.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB25(object sender, EventArgs e)
        {
            B25.BackColor = L25.BackColor = Color.White;
        }


        private void OnMouseEnterB26(object sender, EventArgs e)
        {
            B26.BackColor = L26.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB26(object sender, EventArgs e)
        {
            B26.BackColor = L26.BackColor = Color.White;
        }


        private void OnMouseEnterB27(object sender, EventArgs e)
        {
            B27.BackColor = L27.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB27(object sender, EventArgs e)
        {
            B27.BackColor = L27.BackColor = Color.White;
        }


        private void OnMouseEnterB28(object sender, EventArgs e)
        {
            B28.BackColor = L28.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB28(object sender, EventArgs e)
        {
            B28.BackColor = L28.BackColor = Color.White;
        }


        private void OnMouseEnterB29(object sender, EventArgs e)
        {
            B29.BackColor = L29.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB29(object sender, EventArgs e)
        {
            B29.BackColor = L29.BackColor = Color.White;
        }


        private void OnMouseEnterB30(object sender, EventArgs e)
        {
            B30.BackColor = L30.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB30(object sender, EventArgs e)
        {
            B30.BackColor = L30.BackColor = Color.White;
        }


        private void OnMouseEnterB31(object sender, EventArgs e)
        {
            B31.BackColor = L31.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB31(object sender, EventArgs e)
        {
            B31.BackColor = L31.BackColor = Color.White;
        }


        private void OnMouseEnterB32(object sender, EventArgs e)
        {
            B32.BackColor = L32.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB32(object sender, EventArgs e)
        {
            B32.BackColor = L32.BackColor = Color.White;
        }


        private void OnMouseEnterB33(object sender, EventArgs e)
        {
            B33.BackColor = L33.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB33(object sender, EventArgs e)
        {
            B33.BackColor = L33.BackColor = Color.White;
        }


        private void OnMouseEnterB34(object sender, EventArgs e)
        {
            B34.BackColor = L34.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB34(object sender, EventArgs e)
        {
            B34.BackColor = L34.BackColor = Color.White;
        }


        private void OnMouseEnterB35(object sender, EventArgs e)
        {
            B35.BackColor = L35.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB35(object sender, EventArgs e)
        {
            B35.BackColor = L35.BackColor = Color.White;
        }


        private void OnMouseEnterB36(object sender, EventArgs e)
        {
            B36.BackColor = L36.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB36(object sender, EventArgs e)
        {
            B36.BackColor = L36.BackColor = Color.White;
        }


        private void OnMouseEnterB37(object sender, EventArgs e)
        {
            B37.BackColor = L37.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB37(object sender, EventArgs e)
        {
            B37.BackColor = L37.BackColor = Color.White;
        }


        private void OnMouseEnterB38(object sender, EventArgs e)
        {
            B38.BackColor = L38.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB38(object sender, EventArgs e)
        {
            B38.BackColor = L38.BackColor = Color.White;
        }


        private void OnMouseEnterB39(object sender, EventArgs e)
        {
            B39.BackColor = L39.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB39(object sender, EventArgs e)
        {
            B39.BackColor = L39.BackColor = Color.White;
        }


        private void OnMouseEnterB40(object sender, EventArgs e)
        {
            B40.BackColor = L40.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB40(object sender, EventArgs e)
        {
            B40.BackColor = L40.BackColor = Color.White;
        }


        private void OnMouseEnterB41(object sender, EventArgs e)
        {
            B41.BackColor = L41.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB41(object sender, EventArgs e)
        {
            B41.BackColor = L41.BackColor = Color.White;
        }


        private void OnMouseEnterB42(object sender, EventArgs e)
        {
            B42.BackColor = L42.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB42(object sender, EventArgs e)
        {
            B42.BackColor = L42.BackColor = Color.White;
        }


        private void OnMouseEnterB43(object sender, EventArgs e)
        {
            B43.BackColor = L43.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB43(object sender, EventArgs e)
        {
            B43.BackColor = L43.BackColor = Color.White;
        }


        private void OnMouseEnterB44(object sender, EventArgs e)
        {
            B44.BackColor = L44.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB44(object sender, EventArgs e)
        {
            B44.BackColor = L44.BackColor = Color.White;
        }


        private void OnMouseEnterB45(object sender, EventArgs e)
        {
            B45.BackColor = L45.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB45(object sender, EventArgs e)
        {
            B45.BackColor = L45.BackColor = Color.White;
        }


        private void OnMouseEnterB46(object sender, EventArgs e)
        {
            B46.BackColor = L46.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB46(object sender, EventArgs e)
        {
            B46.BackColor = L46.BackColor = Color.White;
        }


        private void OnMouseEnterB47(object sender, EventArgs e)
        {
            B47.BackColor = L47.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB47(object sender, EventArgs e)
        {
            B47.BackColor = L47.BackColor = Color.White;
        }


        private void OnMouseEnterB48(object sender, EventArgs e)
        {
            B48.BackColor = L48.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB48(object sender, EventArgs e)
        {
            B48.BackColor = L48.BackColor = Color.White;
        }


        private void OnMouseEnterB49(object sender, EventArgs e)
        {
            B49.BackColor = L49.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB49(object sender, EventArgs e)
        {
            B49.BackColor = L49.BackColor = Color.White;
        }


        private void OnMouseEnterB50(object sender, EventArgs e)
        {
            B50.BackColor = L50.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB50(object sender, EventArgs e)
        {
            B50.BackColor = L50.BackColor = Color.White;
        }


        private void OnMouseEnterB51(object sender, EventArgs e)
        {
            B51.BackColor = L51.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB51(object sender, EventArgs e)
        {
            B51.BackColor = L51.BackColor = Color.White;
        }


        private void OnMouseEnterB52(object sender, EventArgs e)
        {
            B52.BackColor = L52.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB52(object sender, EventArgs e)
        {
            B52.BackColor = L52.BackColor = Color.White;
        }


        private void OnMouseEnterB53(object sender, EventArgs e)
        {
            B53.BackColor = L53.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB53(object sender, EventArgs e)
        {
            B53.BackColor = L53.BackColor = Color.White;
        }


        private void OnMouseEnterB54(object sender, EventArgs e)
        {
            B54.BackColor = L54.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB54(object sender, EventArgs e)
        {
            B54.BackColor = L54.BackColor = Color.White;
        }


        private void OnMouseEnterB55(object sender, EventArgs e)
        {
            B55.BackColor = L55.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB55(object sender, EventArgs e)
        {
            B55.BackColor = L55.BackColor = Color.White;
        }


        private void OnMouseEnterB56(object sender, EventArgs e)
        {
            B56.BackColor = L56.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB56(object sender, EventArgs e)
        {
            B56.BackColor = L56.BackColor = Color.White;
        }


        private void OnMouseEnterB57(object sender, EventArgs e)
        {
            B57.BackColor = L57.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB57(object sender, EventArgs e)
        {
            B57.BackColor = L57.BackColor = Color.White;
        }


        private void OnMouseEnterB58(object sender, EventArgs e)
        {
            B58.BackColor = L58.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB58(object sender, EventArgs e)
        {
            B58.BackColor = L58.BackColor = Color.White;
        }


        private void OnMouseEnterB59(object sender, EventArgs e)
        {
            B59.BackColor = L59.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB59(object sender, EventArgs e)
        {
            B59.BackColor = L59.BackColor = Color.White;
        }


        private void OnMouseEnterB60(object sender, EventArgs e)
        {
            B60.BackColor = L60.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB60(object sender, EventArgs e)
        {
            B60.BackColor = L60.BackColor = Color.White;
        }


        private void OnMouseEnterB61(object sender, EventArgs e)
        {
            B61.BackColor = L61.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB61(object sender, EventArgs e)
        {
            B61.BackColor = L61.BackColor = Color.White;
        }


        private void OnMouseEnterB62(object sender, EventArgs e)
        {
            B62.BackColor = L62.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB62(object sender, EventArgs e)
        {
            B62.BackColor = L62.BackColor = Color.White;
        }


        private void OnMouseEnterB63(object sender, EventArgs e)
        {
            B63.BackColor = L63.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB63(object sender, EventArgs e)
        {
            B63.BackColor = L63.BackColor = Color.White;
        }


        private void OnMouseEnterB64(object sender, EventArgs e)
        {
            B64.BackColor = L64.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB64(object sender, EventArgs e)
        {
            B64.BackColor = L64.BackColor = Color.White;
        }


        private void OnMouseEnterB65(object sender, EventArgs e)
        {
            B65.BackColor = L65.BackColor = Color.Silver;
        }

        private void OnMouseLeaveB65(object sender, EventArgs e)
        {
            B65.BackColor = L65.BackColor = Color.White;
        }
        /*
        private void button2_Click(object sender, EventArgs e)
        {
            thumbnailuri.Visible = false;
            button2.Visible = false;
            button1.Visible = true;
            WindowsMediaPlayer.Size = new Size(1311, 622);
            WindowsMediaPlayer.Location = new Point(2, 0);
            panel2.Size = new Size(1310, 110);
            panel2.Location = new Point(4, 628);
            guna2TrackBar1.Size = new Size(1144, 24);
            guna2TrackBar1.Location = new Point(73, 11);
          
            guna2TrackBar2.Size = new Size(757, 25);
            guna2TrackBar2.Location = new Point(386, 56);
            label12.Size = new Size(34, 13);
            label12.Location = new Point(1241,60);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            thumbnailuri.Visible = true;
            button1.Visible = false;
            button2.Visible = true;
            WindowsMediaPlayer.Size = new Size(1009, 622);
            WindowsMediaPlayer.Location = new Point(2, 0);
            panel2.Size = new Size(1009, 622);
            panel2.Location = new Point(4, 628);
            guna2TrackBar1.Size = new Size(859,24);
            guna2TrackBar1.Location = new Point(73,11);
            
            guna2TrackBar2.Size = new Size(526, 25);
            label12.Size = new Size(27, 13);
            label12.Location = new Point(956, 59);

        }


        */
        void afis_meme()
        {
            if (meme == 0) interogatoriu.Visible = DA.Visible = NU.Visible = mafiamember.Visible = false;



            if (meme == 1)
            {
                interogatoriu.Visible = DA.Visible = NU.Visible = mafiamember.Visible = false;

                interogatoriu.Text = "Vrei niste meme- uri?";
                memes = true; refuz = 0;
                interogatoriu.Visible = mafiamember.Visible = DA.Visible = NU.Visible = true;

            }


        }


        void navigare()
        {
            L1.BackColor = B1.BackColor = L2.BackColor = B2.BackColor = L3.BackColor = B3.BackColor = L4.BackColor = B4.BackColor = L5.BackColor = B5.BackColor = L6.BackColor = B6.BackColor = L7.BackColor = B7.BackColor = L8.BackColor = B8.BackColor = L9.BackColor = B9.BackColor = L10.BackColor = B10.BackColor = L11.BackColor = B11.BackColor = L12.BackColor = B12.BackColor = L13.BackColor = B13.BackColor = L14.BackColor = B14.BackColor = L15.BackColor = B15.BackColor = L16.BackColor = B16.BackColor = L17.BackColor = B17.BackColor = L18.BackColor = B18.BackColor = L19.BackColor = B19.BackColor = L20.BackColor = B20.BackColor = L21.BackColor = B21.BackColor = L22.BackColor = B22.BackColor = L23.BackColor = B23.BackColor = L24.BackColor = B24.BackColor = L25.BackColor = B25.BackColor = L26.BackColor = B26.BackColor = L27.BackColor = B27.BackColor = L28.BackColor = B28.BackColor = L29.BackColor = B29.BackColor = L30.BackColor = B30.BackColor = L31.BackColor = B31.BackColor = L32.BackColor = B32.BackColor = L33.BackColor = B33.BackColor = L34.BackColor = B34.BackColor = L35.BackColor = B35.BackColor = L36.BackColor = B36.BackColor = L37.BackColor = B37.BackColor = L38.BackColor = B38.BackColor = L39.BackColor = B39.BackColor = L40.BackColor = B40.BackColor = L41.BackColor = B41.BackColor = L42.BackColor = B42.BackColor = L43.BackColor = B43.BackColor = L44.BackColor = B44.BackColor = L45.BackColor = B45.BackColor = L46.BackColor = B46.BackColor = L47.BackColor = B47.BackColor = L48.BackColor = B48.BackColor = L49.BackColor = B49.BackColor = L50.BackColor = B50.BackColor = L51.BackColor = B51.BackColor = L52.BackColor = B52.BackColor = L53.BackColor = B53.BackColor = L54.BackColor = B54.BackColor = L55.BackColor = B55.BackColor = L56.BackColor = B56.BackColor = L57.BackColor = B57.BackColor = L58.BackColor = B58.BackColor = L59.BackColor = B59.BackColor = L60.BackColor = B60.BackColor = L61.BackColor = B61.BackColor = L62.BackColor = B62.BackColor = L63.BackColor = B63.BackColor = L64.BackColor = B64.BackColor = L65.BackColor = B65.BackColor = Color.White;
            L1.ForeColor = L2.ForeColor = L3.ForeColor = L4.ForeColor = L5.ForeColor = L6.ForeColor = L7.ForeColor = L8.ForeColor = L9.ForeColor = L10.ForeColor = L11.ForeColor = L12.ForeColor = L13.ForeColor = L14.ForeColor = L15.ForeColor = L16.ForeColor = L17.ForeColor = L18.ForeColor = L19.ForeColor = L20.ForeColor = L21.ForeColor = L22.ForeColor = L23.ForeColor = L24.ForeColor = L25.ForeColor = L26.ForeColor = L27.ForeColor = L28.ForeColor = L29.ForeColor = L30.ForeColor = L31.ForeColor = L32.ForeColor = L33.ForeColor = L34.ForeColor = L35.ForeColor = L36.ForeColor = L37.ForeColor = L38.ForeColor = L39.ForeColor = L40.ForeColor = L41.ForeColor = L42.ForeColor = L43.ForeColor = L44.ForeColor = L45.ForeColor = L46.ForeColor = L47.ForeColor = L48.ForeColor = L49.ForeColor = L50.ForeColor = L51.ForeColor = L52.ForeColor = L53.ForeColor = L54.ForeColor = L55.ForeColor = L56.ForeColor = L57.ForeColor = L58.ForeColor = L59.ForeColor = L60.ForeColor = L61.ForeColor = L62.ForeColor = L63.ForeColor = L64.ForeColor = L65.ForeColor = Color.Black;
            stop_pause = 1;
            play_stop.BackgroundImage = Properties.Resources.pauza_video;
            if (nr == 1)
            {
                L1.BackColor = B1.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c1.mp4";
                Title.Text = L1.Text;
            }
            else if (nr == 2)
            {
                L2.BackColor = B2.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c2.mp4";
                Title.Text = L2.Text;
            }
            else if (nr == 3)
            {
                L3.BackColor = B3.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c3.mp4";
                Title.Text = L3.Text;
            }
            else if (nr == 4)
            {
                L4.BackColor = B4.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c4.mp4";
                Title.Text = L4.Text;
            }
            else if (nr == 5)
            {
                L5.BackColor = B5.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c5.mp4";
                Title.Text = L5.Text;
            }
            else if (nr == 6)
            {
                L6.BackColor = B6.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c6.mp4";
                Title.Text = L6.Text;
            }
            else if (nr == 7)
            {
                L7.BackColor = B7.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c7.mp4";
                Title.Text = L7.Text;
            }
            else if (nr == 8)
            {
                L8.BackColor = B8.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c8.mp4";
                Title.Text = L8.Text;
            }
            else if (nr == 9)
            {
                L9.BackColor = B9.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c9.mp4";
                Title.Text = L9.Text;
            }
            else if (nr == 10)
            {
                L10.BackColor = B10.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c10.mp4";
                Title.Text = L10.Text;
            }
            else if (nr == 11)
            {
                L11.BackColor = B11.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c11.mp4";
                Title.Text = L11.Text;
            }
            else if (nr == 12)
            {
                L12.BackColor = B12.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c12.mp4";
                Title.Text = L12.Text;
            }
            else if (nr == 13)
            {
                L13.BackColor = B13.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c13.mp4";
                Title.Text = L13.Text;
            }
            else if (nr == 14)
            {
                L14.BackColor = B14.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c14.mp4";
                Title.Text = L14.Text;
            }
            else if (nr == 15)
            {
                L15.BackColor = B15.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c15.mp4";
                Title.Text = L15.Text;
            }
            else if (nr == 16)
            {
                L16.BackColor = B16.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c16.mp4";
                Title.Text = L16.Text;
            }
            else if (nr == 17)
            {
                L17.BackColor = B17.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c17.mp4";
                Title.Text = L17.Text;
            }
            else if (nr == 18)
            {
                L18.BackColor = B18.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c18.mp4";
                Title.Text = L18.Text;
            }
            else if (nr == 19)
            {
                L19.BackColor = B19.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c19.mp4";
                Title.Text = L19.Text;
            }
            else if (nr == 20)
            {
                L20.BackColor = B20.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c20.mp4";
                Title.Text = L20.Text;
            }
            else if (nr == 21)
            {
                L21.BackColor = B21.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c21.mp4";
                Title.Text = L21.Text;
            }
            else if (nr == 22)
            {
                L22.BackColor = B22.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c22.mp4";
                Title.Text = L22.Text;
            }
            else if (nr == 23)
            {
                L23.BackColor = B23.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c23.mp4";
                Title.Text = L23.Text;
            }
            else if (nr == 24)
            {
                L24.BackColor = B24.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c24.mp4";
                Title.Text = L24.Text;
            }
            else if (nr == 25)
            {
                L25.BackColor = B25.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c25.mp4";
                Title.Text = L25.Text;
            }
            else if (nr == 26)
            {
                L26.BackColor = B26.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c26.mp4";
                Title.Text = L26.Text;
            }
            else if (nr == 27)
            {
                L27.BackColor = B27.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c27.mp4";
                Title.Text = L27.Text;
            }
            else if (nr == 28)
            {
                L28.BackColor = B28.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c28.mp4";
                Title.Text = L28.Text;
            }
            else if (nr == 29)
            {
                L29.BackColor = B29.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c29.mp4";
                Title.Text = L29.Text;
            }
            else if (nr == 30)
            {
                L30.BackColor = B30.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c30.mp4";
                Title.Text = L30.Text;
            }
            else if (nr == 31)
            {
                L31.BackColor = B31.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c31.mp4";
                Title.Text = L31.Text;
            }
            else if (nr == 32)
            {
                L32.BackColor = B32.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c32.mp4";
                Title.Text = L32.Text;
            }
            else if (nr == 33)
            {
                L33.BackColor = B33.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c33.mp4";
                Title.Text = L33.Text;
            }
            else if (nr == 34)
            {
                L34.BackColor = B34.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c34.mp4";
                Title.Text = L34.Text;
            }
            else if (nr == 35)
            {
                L35.BackColor = B35.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c35.mp4";
                Title.Text = L35.Text;
            }
            else if (nr == 36)
            {
                L36.BackColor = B36.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c36.mp4";
                Title.Text = L36.Text;
            }
            else if (nr == 37)
            {
                L37.BackColor = B37.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c37.mp4";
                Title.Text = L37.Text;
            }
            else if (nr == 38)
            {
                L38.BackColor = B38.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c38.mp4";
                Title.Text = L38.Text;
            }
            else if (nr == 39)
            {
                L39.BackColor = B39.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c39.mp4";
                Title.Text = L39.Text;
            }
            else if (nr == 40)
            {
                L40.BackColor = B40.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c40.mp4";
                Title.Text = L40.Text;
            }
            else if (nr == 41)
            {
                L41.BackColor = B41.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c41.mp4";
                Title.Text = L41.Text;
            }
            else if (nr == 42)
            {
                L42.BackColor = B42.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c42.mp4";
                Title.Text = L42.Text;
            }
            else if (nr == 43)
            {
                L43.BackColor = B43.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c43.mp4";
                Title.Text = L43.Text;
            }
            else if (nr == 44)
            {
                L44.BackColor = B44.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c44.mp4";
                Title.Text = L44.Text;
            }
            else if (nr == 45)
            {
                L45.BackColor = B45.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c45.mp4";
                Title.Text = L45.Text;
            }
            else if (nr == 46)
            {
                L46.BackColor = B46.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c46.mp4";
                Title.Text = L46.Text;
            }
            else if (nr == 47)
            {
                L47.BackColor = B47.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c47.mp4";
                Title.Text = L47.Text;
            }
            else if (nr == 48)
            {
                L48.BackColor = B48.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c48.mp4";
                Title.Text = L48.Text;
            }
            else if (nr == 49)
            {
                L49.BackColor = B49.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c49.mp4";
                Title.Text = L49.Text;
            }
            else if (nr == 50)
            {
                L50.BackColor = B50.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c50.mp4";
                Title.Text = L50.Text;
            }
            else if (nr == 51)
            {
                L51.BackColor = B51.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c51.mp4";
                Title.Text = L51.Text;
            }
            else if (nr == 52)
            {
                L52.BackColor = B52.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c52.mp4";
                Title.Text = L52.Text;
            }
            else if (nr == 53)
            {
                L53.BackColor = B53.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c53.mp4";
                Title.Text = L53.Text;
            }
            else if (nr == 54)
            {
                L54.BackColor = B54.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c54.mp4";
                Title.Text = L54.Text;
            }
            else if (nr == 55)
            {
                L55.BackColor = B55.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c55.mp4";
                Title.Text = L55.Text;
            }
            else if (nr == 56)
            {
                L56.BackColor = B56.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c56.mp4";
                Title.Text = L56.Text;
            }
            else if (nr == 57)
            {
                L57.BackColor = B57.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c57.mp4";
                Title.Text = L57.Text;
            }
            else if (nr == 58)
            {
                L58.BackColor = B58.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c58.mp4";
                Title.Text = L58.Text;
            }
            else if (nr == 59)
            {
                L59.BackColor = B59.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c59.mp4";
                Title.Text = L59.Text;
            }
            else if (nr == 60)
            {
                L60.BackColor = B60.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c60.mp4";
                Title.Text = L60.Text;
            }
            else if (nr == 61)
            {
                L61.BackColor = B61.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c61.mp4";
                Title.Text = L61.Text;
            }
            else if (nr == 62)
            {
                L62.BackColor = B62.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c62.mp4";
                Title.Text = L62.Text;
            }
            else if (nr == 63)
            {
                L63.BackColor = B63.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c63.mp4";
                Title.Text = L63.Text;
            }
            else if (nr == 64)
            {
                L64.BackColor = B64.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c64.mp4";
                Title.Text = L64.Text;
            }
            else if (nr == 65)
            {
                L65.BackColor = B65.BackColor = Color.Gold;
                WindowsMediaPlayer.URL = "D:/sursa/c65.mp4";
                Title.Text = L65.Text;
            }
            t = 1;
        }
     

        private void timer1_Tick(object sender, EventArgs e)
        {

     
            if (WindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                guna2TrackBar1.Value = (int)WindowsMediaPlayer.Ctlcontrols.currentPosition;

            }
            label10.Text = WindowsMediaPlayer.Ctlcontrols.currentPositionString + "/" + WindowsMediaPlayer.Ctlcontrols.currentItem.durationString.ToString();
            if (WindowsMediaPlayer.Ctlcontrols.currentPositionString == WindowsMediaPlayer.Ctlcontrols.currentItem.durationString.ToString())
            {
                if (nr != 65)
                {
                    nr++;
                    navigare();
                }
            }


        }

        private void guna2TrackBar1_Scroll_1(object sender, ScrollEventArgs e)
        {
            
        }

        private void WindowsMediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (WindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                guna2TrackBar1.Maximum = (int)WindowsMediaPlayer.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else
            if (WindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();
            }
            else
            if (WindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                guna2TrackBar1.Value = 0;
            }
        }

    

        private void WindowsMediaPlayer_Enter(object sender, EventArgs e)
        {
           
        }

        private void guna2TrackBar2_Scroll(object sender, ScrollEventArgs e)
        {
            WindowsMediaPlayer.settings.volume = guna2TrackBar2.Value;
            label12.Text = guna2TrackBar2.Value.ToString() + "%";

            if (guna2TrackBar2.Value == 0) speaker.BackgroundImage = Properties.Resources.speaker_mute;
            else speaker.BackgroundImage = Properties.Resources.speaker_volume;
        }



        private void pictureBox12_Click(object sender, EventArgs e)
        {
                if (t != 0)
                {/**
                    if (nr > 1)
                    {
                    nr--;
                    if (nr == 3)
                        WindowsMediaPlayer.URL = "C:/Users/ignat/Videos/Captures/Regele Carol I.mp4";
                    if (nr == 4)
                        WindowsMediaPlayer.URL = "C:/Users/ignat/Videos/Captures/Regele Ferdinand - Regele României Mari.mp4";
                    if (nr == 5)
                        WindowsMediaPlayer.URL = "C:/Users/ignat/Videos/Captures/yt1s.com - Romania si dictaturile ei  Carol II_360p.mp4";
                    if (nr == 6)
                        WindowsMediaPlayer.URL = "C:/Users/ignat/Videos/Captures/Români care au schimbat lumea_ Regele Mihai (@TVR1).mp4";
                    if (nr == 7)
                        WindowsMediaPlayer.URL = "C:/Users/ignat/Videos/Captures/Regina Maria A Romaniei.mp4";
                    if (nr == 8)
                        WindowsMediaPlayer.URL = "C:/Users/ignat/Videos/Captures/yt1s.com - Dictatura lui Nicolae Ceausescu  full_360p.mp4";
                    if (nr == 9)
                        WindowsMediaPlayer.URL = "C:/Users/ignat/Videos/Captures/Adevăruri despre trecut_ Elena Ceauşescu - faraoana (@TVR1).mp4";
                    if (nr == 10)
                        WindowsMediaPlayer.URL = "C:/Users/ignat/Videos/Captures/yt1s.com - O viata pentru o idee  Emil Racovita_480p.mp4";
                    if (nr == 11)
                        WindowsMediaPlayer.URL = "C:/Users/ignat/Videos/Captures/Henri Coanda.mp4";
                    if (nr == 12)
                        WindowsMediaPlayer.URL = "C:/Users/ignat/Videos/Captures/Alexander Graham Bell Biography.mp4";
                    if (nr == 13)
                        WindowsMediaPlayer.URL = "C:/Users/ignat/Videos/Captures/Marie Curie Biography.mp4";
                    if (nr == 14)
                        WindowsMediaPlayer.URL = "C:/Users/ignat/Videos/Captures/8 LUCRURI pe care NU le STIAI despre NIKOLA TESLA.mp4";
                    if (nr == 15)
                        WindowsMediaPlayer.URL = "C:/Users/ignat/Videos/Captures/Biografie - Albert Einstein.mp4";
                    if (nr == 16)
                        WindowsMediaPlayer.URL = "C:/Users/ignat/Videos/Captures/Yuri Gagarin Biography.mp4";
                    if (nr == 17)
                        WindowsMediaPlayer.URL = "C:/Users/ignat/Videos/Captures/Neil Armstrong Biography in English _ American Astronaut.mp4";
                    if (nr == 18)
                        WindowsMediaPlayer.URL = "C:/Users/ignat/Videos/Captures/John F. Kennedy - The United States' 35th President _ Mini Bio _ Biography.mp4";
                    if (nr == 19)
                        WindowsMediaPlayer.URL = "C:/Users/ignat/Videos/Captures/President Richard Nixon Biography.mp4";
                    if (nr == 20)
                        WindowsMediaPlayer.URL = "C:/Users/ignat/Videos/Captures/President Gerald Ford Biography.mp4";
                    if (nr == 21)
                        WindowsMediaPlayer.URL = "C:/Users/ignat/Videos/Captures/President Ronald Reagan Biography___.mp4";
                    if (nr == 22)
                        WindowsMediaPlayer.URL = "C:/Users/ignat/Videos/Captures/President George H Bush Biography.mp4";
                    if (nr == 2)
                        WindowsMediaPlayer.URL = "C:/Users/ignat/Videos/Captures/yt1s.com - 150 de ani de la naşterea lui Ion I C Brătianu vizionarul României moderne_360p (1).mp4";
                     if (nr == 1)
                         WindowsMediaPlayer.URL = "C:/Users/ignat/Videos/Captures/Otto von Bismarck_ The Iron Chancellor.mp4";
                    }
                  **/
            }

        }



        private void pictureBox19_Click(object sender, EventArgs e)
        {
            nr = 14;
            t = 1;
        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            nr = 8;
            t = 1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            nr = 1;
            t = 1;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            nr = 1;
            t = 1;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            nr = 1;
            t = 1;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            nr = 2;
            t = 1;
            label10.Text = "00:00";
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            nr = 2;
            t = 1;
            label10.Text = "00:00";
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            nr = 2;
            t = 1;
            label10.Text = "00:00";
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            nr = 3;
            t = 1;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
             nr = 3;
            t = 1;
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            nr = 3;
            t = 1;
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            nr = 4;
            t = 1;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            nr = 4;
            t = 1;
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            nr = 4;
            t = 1;
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
             nr = 5;
            t = 1;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            nr = 5;
            t = 1;
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            nr = 5;
            t = 1;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            nr = 6;
            t = 1;
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            nr = 6;
            t = 1;
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            nr = 6;
            t = 1;
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            nr = 7;
            t = 1;
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            nr = 7;
            t = 1;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            nr = 7;
            t = 1;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
           nr = 8;
            t = 1;
        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            nr = 8;
            t = 1;
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            nr = 9;
            t = 1;
        }

        private void label9_Click_1(object sender, EventArgs e)
        {
            nr = 9;
            t = 1;
        }

        private void pictureBox10_Click_1(object sender, EventArgs e)
        {
            nr = 9;
            t = 1;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            nr = 10;
            t = 1;
        }

        private void label13_Click(object sender, EventArgs e)
        {
           nr = 10;
            t = 1;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
             nr = 10;
            t = 1;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            nr = 11;
            t = 1;
        }

        private void label14_Click(object sender, EventArgs e)
        { nr = 11;
            t = 1;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
           nr = 11;
            t = 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            nr = 12;
            t = 1;
        }

        private void label15_Click(object sender, EventArgs e)
        {

           nr = 12;
            t = 1;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

            nr = 12;
            t = 1;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            nr = 13;
            t = 1;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            nr = 13;
            t = 1;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            nr = 13;
            t = 1;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            nr = 14;
            t = 1;
        }

        private void label17_Click(object sender, EventArgs e)
        {
             nr = 14;
            t = 1;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            nr = 15;
            t = 1;
        }

        private void label18_Click(object sender, EventArgs e)
        {
            nr = 15;
            t = 1;
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            nr = 15;
            t = 1;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            nr = 16;
            t = 1;

        }

        private void label19_Click(object sender, EventArgs e)
        {
            nr = 16;
            t = 1;
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            nr = 16;
            t = 1;
        }

        private void button19_Click(object sender, EventArgs e)
        {
             nr = 17;
            t = 1;
        }

        private void label20_Click(object sender, EventArgs e)
        {
            nr = 17;
            t = 1;
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
         ///   WindowsMediaPlayer.URL = "C:/Users/ignat/Videos/Captures/Neil Armstrong Biography in English _ American Astronaut.mp4";
            nr = 17;
            t = 1;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            nr = 18;
            t = 1;
        }

        private void label21_Click(object sender, EventArgs e)
        {
             nr = 18;
            t = 1;
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
             nr = 18;
            t = 1;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            nr = 19;
            t = 1;
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            nr = 19;
            t = 1;
        }

        private void label22_Click(object sender, EventArgs e)
        {
            nr = 19;
            t = 1;
        }

  
        /*
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pauza.Visible = true;
            WindowsMediaPlayer.Ctlcontrols.play();
        }
        */

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pauza.Visible = false;
            pictureBox1.Visible = true;
            WindowsMediaPlayer.Ctlcontrols.pause();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer.Ctlcontrols.stop();
            label10.Text = "00:00";
           
            pauza.Visible = false;
            pictureBox1.Visible = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            nr = 20;
            t = 1;
        }

        private void label23_Click(object sender, EventArgs e)
        {
            nr = 20;
            t = 1;
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
           nr = 20;
            t = 1;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer.URL = "C:/Users/ignat/Videos/Captures/President Ronald Reagan Biography___.mp4";
            nr = 21;
            t = 1;
        }

        private void label24_Click(object sender, EventArgs e)
        {
            nr = 21;
            t = 1;
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            nr = 21;
            t = 1;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            nr = 22;
            t = 1;
        }

        private void label25_Click(object sender, EventArgs e)
        {
            nr = 22;
            t = 1;
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            nr = 22;
            t = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox26_Click_1(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox25_Click_1(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    
        private void P1_Click(object sender, EventArgs e)
        {
            if (nr != 1) { nr = 1; navigare(); }
        }

        private void L1_Click(object sender, EventArgs e)
        {
            if (nr != 1) { nr = 1; navigare(); }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (nr != 1) { nr = 1; navigare(); }
        }

        private void P2_Click(object sender, EventArgs e)
        {
            if (nr != 2) { nr = 2; navigare(); }
        }

        private void L2_Click(object sender, EventArgs e)
        {
            if (nr != 2) { nr = 2; navigare(); }
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (nr != 2) { nr = 2; navigare(); }
        }

     

        private void P3_Click(object sender, EventArgs e)
        {
            if (nr != 3) { nr = 3; navigare(); }
        }

        private void L3_Click(object sender, EventArgs e)
        {
            if (nr != 3) { nr = 3; navigare(); }
        }

        private void B3_Click(object sender, EventArgs e)
        {
            if (nr != 3) { nr = 3; navigare(); }
        }

        private void P4_Click(object sender, EventArgs e)
        {
            if (nr != 4) { nr = 4; navigare(); }
        }

        private void L4_Click(object sender, EventArgs e)
        {
            if (nr != 4) { nr = 4; navigare(); }
        }

        private void B4_Click(object sender, EventArgs e)
        {
            if (nr != 4) { nr = 4; navigare(); }
        }

        private void P5_Click(object sender, EventArgs e)
        {
            if (nr != 5) { nr = 5; navigare(); }
        }

        private void L5_Click(object sender, EventArgs e)
        {
            if (nr != 5) { nr = 5; navigare(); }
        }

        private void B5_Click(object sender, EventArgs e)
        {
            if (nr != 5) { nr = 5; navigare(); }
        }

        private void P6_Click(object sender, EventArgs e)
        {
            if (nr != 6) { nr = 6; navigare(); }
        }

        private void L6_Click(object sender, EventArgs e)
        {
            if (nr != 6) { nr = 6; navigare(); }
        }

        private void B6_Click(object sender, EventArgs e)
        {
            if (nr != 6) { nr = 6; navigare(); }
        }

        private void P7_Click(object sender, EventArgs e)
        {
            if (nr != 7) { nr = 7; navigare(); }
        }

        private void L7_Click(object sender, EventArgs e)
        {
            if (nr != 7) { nr = 7; navigare(); }
        }

        private void B7_Click(object sender, EventArgs e)
        {
            if (nr != 7) { nr = 7; navigare(); }
        }

        private void P8_Click(object sender, EventArgs e)
        {
            if (nr != 8) { nr = 8; navigare(); }
        }

        private void L8_Click(object sender, EventArgs e)
        {
            if (nr != 8) { nr = 8; navigare(); }
        }

        private void B8_Click(object sender, EventArgs e)
        {
            if (nr != 8) { nr = 8; navigare(); }
        }

        private void P9_Click(object sender, EventArgs e)
        {
            if (nr != 9) { nr = 9; navigare(); }
        }

        private void L9_Click(object sender, EventArgs e)
        {
            if (nr != 9) { nr = 9; navigare(); }
        }

        private void B9_Click(object sender, EventArgs e)
        {
            if (nr != 9) { nr = 9; navigare(); }
        }

        private void P10_Click(object sender, EventArgs e)
        {
            if (nr != 10) { nr = 10; navigare(); }
        }

        private void L10_Click(object sender, EventArgs e)
        {
            if (nr != 10) { nr = 10; navigare(); }
        }

        private void B10_Click(object sender, EventArgs e)
        {
            if (nr != 10) { nr = 10; navigare(); }
        }

        private void P11_Click(object sender, EventArgs e)
        {
            if (nr != 11) { nr = 11; navigare(); }
        }

        private void L11_Click(object sender, EventArgs e)
        {
            if (nr != 11) { nr = 11; navigare(); }
        }

        private void B11_Click(object sender, EventArgs e)
        {
            if (nr != 11) { nr = 11; navigare(); }
        }

        private void P12_Click(object sender, EventArgs e)
        {
            if (nr != 12) { nr = 12; navigare(); }
        }

        private void L12_Click(object sender, EventArgs e)
        {
            if (nr != 12) { nr = 12; navigare(); }
        }

        private void B12_Click(object sender, EventArgs e)
        {
            if (nr != 12) { nr = 12; navigare(); }
        }

        private void P13_Click(object sender, EventArgs e)
        {
            if (nr != 13) { nr = 13; navigare(); }
        }

        private void L13_Click(object sender, EventArgs e)
        {
            if (nr != 13) { nr = 13; navigare(); }
        }

        private void B13_Click(object sender, EventArgs e)
        {
            if (nr != 13) { nr = 13; navigare(); }
        }

        private void P14_Click(object sender, EventArgs e)
        {
            if (nr != 14) { nr = 14; navigare(); }
        }

        private void L14_Click(object sender, EventArgs e)
        {
            if (nr != 14) { nr = 14; navigare(); }
        }

        private void B14_Click(object sender, EventArgs e)
        {
            if (nr != 14) { nr = 14; navigare(); }
        }

        private void P15_Click(object sender, EventArgs e)
        {
            if (nr != 15) { nr = 15; navigare(); }
        }

        private void L15_Click(object sender, EventArgs e)
        {
            if (nr != 15) { nr = 15; navigare(); }
        }

        private void B15_Click(object sender, EventArgs e)
        {
            if (nr != 15) { nr = 15; navigare(); }
        }

        private void P16_Click(object sender, EventArgs e)
        {
            if (nr != 16) { nr = 16; navigare(); }
        }

        private void L16_Click(object sender, EventArgs e)
        {
            if (nr != 16) { nr = 16; navigare(); }
        }

        private void B16_Click(object sender, EventArgs e)
        {
            if (nr != 16) { nr = 16; navigare(); }
        }

        private void P17_Click(object sender, EventArgs e)
        {
            if (nr != 17) { nr = 17; navigare(); }
        }

        private void L17_Click(object sender, EventArgs e)
        {
            if (nr != 17) { nr = 17; navigare(); }
        }

        private void B17_Click(object sender, EventArgs e)
        {
            if (nr != 17) { nr = 17; navigare(); }
        }

        private void P18_Click(object sender, EventArgs e)
        {
            if (nr != 18) { nr = 18; navigare(); }
        }

        private void L18_Click(object sender, EventArgs e)
        {
            if (nr != 18) { nr = 18; navigare(); }
        }

        private void B18_Click(object sender, EventArgs e)
        {
            if (nr != 18) { nr = 18; navigare(); }
        }

        private void P19_Click(object sender, EventArgs e)
        {
            if (nr != 19) { nr = 19; navigare(); }
        }

        private void L19_Click(object sender, EventArgs e)
        {
            if (nr != 19) { nr = 19; navigare(); }
        }

        private void B19_Click(object sender, EventArgs e)
        {
            if (nr != 19) { nr = 19; navigare(); }
        }

        private void P20_Click(object sender, EventArgs e)
        {
            if (nr != 20) { nr = 20; navigare(); }
        }

        private void L20_Click(object sender, EventArgs e)
        {
            if (nr != 20) { nr = 20; navigare(); }
        }

        private void B20_Click(object sender, EventArgs e)
        {
            if (nr != 20) { nr = 20; navigare(); }
        }

        private void P21_Click(object sender, EventArgs e)
        {
            if (nr != 21) { nr = 21; navigare(); }
        }

        private void L21_Click(object sender, EventArgs e)
        {
            if (nr != 21) { nr = 21; navigare(); }
        }

        private void B21_Click(object sender, EventArgs e)
        {
            if (nr != 21) { nr = 21; navigare(); }
        }

        private void P22_Click(object sender, EventArgs e)
        {
            if (nr != 22) { nr = 22; navigare(); }
        }

        private void L22_Click(object sender, EventArgs e)
        {
            if (nr != 22) { nr = 22; navigare(); }
        }

        private void B22_Click(object sender, EventArgs e)
        {
            if (nr != 22) { nr = 22; navigare(); }
        }

        private void P23_Click(object sender, EventArgs e)
        {
            if (nr != 23) { nr = 23; navigare(); }
        }

        private void L23_Click(object sender, EventArgs e)
        {
            if (nr != 23) { nr = 23; navigare(); }
        }

        private void B23_Click(object sender, EventArgs e)
        {
            if (nr != 23) { nr = 23; navigare(); }
        }

        private void P24_Click(object sender, EventArgs e)
        {
            if (nr != 24) { nr = 24; navigare(); }
        }

        private void L24_Click(object sender, EventArgs e)
        {
            if (nr != 24) { nr = 24; navigare(); }
        }

        private void B24_Click(object sender, EventArgs e)
        {
            if (nr != 24) { nr = 24; navigare(); }
        }

        private void P25_Click(object sender, EventArgs e)
        {
            if (nr != 25) { nr = 25; navigare(); }
        }

        private void L25_Click(object sender, EventArgs e)
        {
            if (nr != 25) { nr = 25; navigare(); }
        }

        private void B25_Click(object sender, EventArgs e)
        {
            if (nr != 25) { nr = 25; navigare(); }
        }

        private void P26_Click(object sender, EventArgs e)
        {
            if (nr != 26) { nr = 26; navigare(); }
        }

        private void L26_Click(object sender, EventArgs e)
        {
            if (nr != 26) { nr = 26; navigare(); }
        }

        private void B26_Click(object sender, EventArgs e)
        {
            if (nr != 26) { nr = 26; navigare(); }
        }

        private void P27_Click(object sender, EventArgs e)
        {
            if (nr != 27) { nr = 27; navigare(); }
        }

        private void L27_Click(object sender, EventArgs e)
        {
            if (nr != 27) { nr = 27; navigare(); }
        }

        private void B27_Click(object sender, EventArgs e)
        {
            if (nr != 27) { nr = 27; navigare(); }
        }

        private void P28_Click(object sender, EventArgs e)
        {
            if (nr != 28) { nr = 28; navigare(); }
        }

        private void L28_Click(object sender, EventArgs e)
        {
            if (nr != 28) { nr = 28; navigare(); }
        }

        private void B28_Click(object sender, EventArgs e)
        {
            if (nr != 28) { nr = 28; navigare(); }
        }

        private void P29_Click(object sender, EventArgs e)
        {
            if (nr != 29) { nr = 29; navigare(); }
        }

        private void L29_Click(object sender, EventArgs e)
        {
            if (nr != 29) { nr = 29; navigare(); }
        }

        private void B29_Click(object sender, EventArgs e)
        {
            if (nr != 29) { nr = 29; navigare(); }
        }

        private void P30_Click(object sender, EventArgs e)
        {
            if (nr != 30) { nr = 30; navigare(); }
        }

        private void L30_Click(object sender, EventArgs e)
        {
            if (nr != 30) { nr = 30; navigare(); }
        }

        private void B30_Click(object sender, EventArgs e)
        {
            if (nr != 30) { nr = 30; navigare(); }
        }

        private void P31_Click(object sender, EventArgs e)
        {
            if (nr != 31) { nr = 31; navigare(); }
        }

        private void L31_Click(object sender, EventArgs e)
        {
            if (nr != 31) { nr = 31; navigare(); }
        }

        private void B31_Click(object sender, EventArgs e)
        {
            if (nr != 31) { nr = 31; navigare(); }
        }

        private void P32_Click(object sender, EventArgs e)
        {
            if (nr != 32) { nr = 32; navigare(); }
        }

        private void L32_Click(object sender, EventArgs e)
        {
            if (nr != 32) { nr = 32; navigare(); }
        }

        private void B32_Click(object sender, EventArgs e)
        {
            if (nr != 32) { nr = 32; navigare(); }
        }

        private void P33_Click(object sender, EventArgs e)
        {
            if (nr != 33) { nr = 33; navigare(); }
        }

        private void L33_Click(object sender, EventArgs e)
        {
            if (nr != 33) { nr = 33; navigare(); }
        }

        private void B33_Click(object sender, EventArgs e)
        {
            if (nr != 33) { nr = 33; navigare(); }
        }

        private void P34_Click(object sender, EventArgs e)
        {
            if (nr != 34) { nr = 33; navigare(); }
        }

        private void L34_Click(object sender, EventArgs e)
        {
            if (nr != 34) { nr = 34; navigare(); }
        }

        private void B34_Click(object sender, EventArgs e)
        {
            if (nr != 34) { nr = 34; navigare(); }
        }

        private void P35_Click(object sender, EventArgs e)
        {
            if (nr != 35) { nr = 34; navigare(); }
        }

        private void L35_Click(object sender, EventArgs e)
        {
            if (nr != 35) { nr = 35; navigare(); }
        }

        private void B35_Click(object sender, EventArgs e)
        {
            if (nr != 35) { nr = 35; navigare(); }
        }

        private void P36_Click(object sender, EventArgs e)
        {
            if (nr != 36) { nr = 35; navigare(); }
        }

        private void L36_Click(object sender, EventArgs e)
        {
            if (nr != 36) { nr = 35; navigare(); }
        }

        private void B36_Click(object sender, EventArgs e)
        {
            if (nr != 36) { nr = 36; navigare(); }
        }

        private void P37_Click(object sender, EventArgs e)
        {
            if (nr != 37) { nr = 37; navigare(); }
        }

        private void L37_Click(object sender, EventArgs e)
        {
            if (nr != 37) { nr = 37; navigare(); }
        }

        private void B37_Click(object sender, EventArgs e)
        {
            if (nr != 37) { nr = 37; navigare(); }
        }

        private void P38_Click(object sender, EventArgs e)
        {
            if (nr != 38) { nr = 38; navigare(); }
        }

        private void L38_Click(object sender, EventArgs e)
        {
            if (nr != 38) { nr = 38; navigare(); }
        }

        private void B38_Click(object sender, EventArgs e)
        {
            if (nr != 38) { nr = 38; navigare(); }
        }

        private void P39_Click(object sender, EventArgs e)
        {
            if (nr != 39) { nr = 39; navigare(); }
        }

        private void L39_Click(object sender, EventArgs e)
        {
            if (nr != 39) { nr = 39; navigare(); }
        }

        private void B39_Click(object sender, EventArgs e)
        {
            if (nr != 39) { nr = 39; navigare(); }
        }

        private void P40_Click(object sender, EventArgs e)
        {
            if (nr != 40) { nr = 40; navigare(); }
        }

        private void L40_Click(object sender, EventArgs e)
        {
            if (nr != 40) { nr = 40; navigare(); }
        }

        private void B40_Click(object sender, EventArgs e)
        {
            if (nr != 40) { nr = 40; navigare(); }
        }

        private void P41_Click(object sender, EventArgs e)
        {
            if (nr != 41) { nr = 41; navigare(); }
        }

        private void L41_Click(object sender, EventArgs e)
        {
            if (nr != 41) { nr = 41; navigare(); }
        }

        private void B41_Click(object sender, EventArgs e)
        {
            if (nr != 41) { nr = 41; navigare(); }
        }

        private void P42_Click(object sender, EventArgs e)
        {
            if (nr != 42) { nr = 42; navigare(); }
        }

        private void L42_Click(object sender, EventArgs e)
        {
            if (nr != 42) { nr = 42; navigare(); }
        }

        private void B42_Click(object sender, EventArgs e)
        {
            if (nr != 42) { nr = 42; navigare(); }
        }

        private void P43_Click(object sender, EventArgs e)
        {
            if (nr != 43) { nr = 43; navigare(); }
        }

        private void L43_Click(object sender, EventArgs e)
        {
            if (nr != 43) { nr = 43; navigare(); }
        }

        private void B43_Click(object sender, EventArgs e)
        {
            if (nr != 43) { nr = 43; navigare(); }
        }

        private void P44_Click(object sender, EventArgs e)
        {
            if (nr != 44) { nr = 44; navigare(); }
        }

        private void L44_Click(object sender, EventArgs e)
        {
            if (nr != 44) { nr = 44; navigare(); }
        }

        private void B44_Click(object sender, EventArgs e)
        {
            if (nr != 44) { nr = 44; navigare(); }
        }

        private void P45_Click(object sender, EventArgs e)
        {
            if (nr != 45) { nr = 45; navigare(); }
        }

        private void L45_Click(object sender, EventArgs e)
        {
            if (nr != 45) { nr = 45; navigare(); }
        }

        private void B45_Click(object sender, EventArgs e)
        {
            if (nr != 45) { nr = 45; navigare(); }
        }

        private void P46_Click(object sender, EventArgs e)
        {
            if (nr != 46) { nr = 46; navigare(); }
        }

        private void L46_Click(object sender, EventArgs e)
        {
            if (nr != 46) { nr = 46; navigare(); }
        }

        private void B46_Click(object sender, EventArgs e)
        {
            if (nr != 46) { nr = 46; navigare(); }
        }

        private void P47_Click(object sender, EventArgs e)
        {
            if (nr != 47) { nr = 47; navigare(); }
        }

        private void L47_Click(object sender, EventArgs e)
        {
            if (nr != 47) { nr = 47; navigare(); }
        }

        private void B47_Click(object sender, EventArgs e)
        {
            if (nr != 47) { nr = 47; navigare(); }
        }

        private void P48_Click(object sender, EventArgs e)
        {
            if (nr != 48) { nr = 48; navigare(); }
        }

        private void L48_Click(object sender, EventArgs e)
        {
            if (nr != 48) { nr = 48; navigare(); }
        }

        private void B48_Click(object sender, EventArgs e)
        {
            if (nr != 48) { nr = 48; navigare(); }
        }

        private void P49_Click(object sender, EventArgs e)
        {
            if (nr != 49) { nr = 49; navigare(); }
        }

        private void L49_Click(object sender, EventArgs e)
        {
            if (nr != 49) { nr = 49; navigare(); }
        }

        private void B49_Click(object sender, EventArgs e)
        {
            if (nr != 49) { nr = 49; navigare(); }
        }

        private void P50_Click(object sender, EventArgs e)
        {
            if (nr != 50) { nr = 50; navigare(); }
        }

        private void L50_Click(object sender, EventArgs e)
        {
            if (nr != 50) { nr = 50; navigare(); }
        }

        private void B50_Click(object sender, EventArgs e)
        {
            if (nr != 50) { nr = 50; navigare(); }
        }

        private void P51_Click(object sender, EventArgs e)
        {
            if (nr != 51) { nr = 51; navigare(); }
        }

        private void L51_Click(object sender, EventArgs e)
        {
            if (nr != 51) { nr = 51; navigare(); }
        }

        private void B51_Click(object sender, EventArgs e)
        {
            if (nr != 51) { nr = 51; navigare(); }
        }

        private void P52_Click(object sender, EventArgs e)
        {
            if (nr != 52) { nr = 52; navigare(); }
        }

        private void L52_Click(object sender, EventArgs e)
        {
            if (nr != 52) { nr = 52; navigare(); }
        }

        private void B52_Click(object sender, EventArgs e)
        {
            if (nr != 52) { nr = 52; navigare(); }
        }

        private void P53_Click(object sender, EventArgs e)
        {
            if (nr != 53) { nr = 53; navigare(); }
        }

        private void L53_Click(object sender, EventArgs e)
        {
            if (nr != 53) { nr = 53; navigare(); }
        }

        private void B53_Click(object sender, EventArgs e)
        {
            if (nr != 53) { nr = 53; navigare(); }
        }

        private void P54_Click(object sender, EventArgs e)
        {
            if (nr != 54) { nr = 54; navigare(); }
        }

        private void L54_Click(object sender, EventArgs e)
        {
            if (nr != 54) { nr = 54; navigare(); }
        }

        private void B54_Click(object sender, EventArgs e)
        {
            if (nr != 54) { nr = 54; navigare(); }
        }

        private void P55_Click(object sender, EventArgs e)
        {
            if (nr != 55) { nr = 55; navigare(); }
        }

        private void L55_Click(object sender, EventArgs e)
        {
            if (nr != 55) { nr = 55; navigare(); }
        }

        private void B55_Click(object sender, EventArgs e)
        {
            if (nr != 55) { nr = 55; navigare(); }
        }

        private void L56_Click(object sender, EventArgs e)
        {
            if (nr != 56) { nr = 56; navigare(); }

        }

        private void P56_Click(object sender, EventArgs e)
        {
            if (nr != 56) { nr = 56; navigare(); }
        }

        private void B56_Click(object sender, EventArgs e)
        {
            if (nr != 56) { nr = 56; navigare(); }
        }

        private void P57_Click(object sender, EventArgs e)
        {
            if (nr != 57) { nr = 57; navigare(); }
        }

        private void L57_Click(object sender, EventArgs e)
        {
            if (nr != 57) { nr = 57; navigare(); }
        }

        private void B57_Click(object sender, EventArgs e)
        {
            if (nr != 57) { nr = 57; navigare(); }
        }

        private void P58_Click(object sender, EventArgs e)
        {
            if (nr != 58) { nr = 58; navigare(); }
        }

        private void L58_Click(object sender, EventArgs e)
        {
            if (nr != 58) { nr = 58; navigare(); }
        }

        private void B58_Click(object sender, EventArgs e)
        {
            if (nr != 58) { nr = 58; navigare(); }
        }

        private void P59_Click(object sender, EventArgs e)
        {
            if (nr != 59) { nr = 59; navigare(); }
        }

        private void B59_Click(object sender, EventArgs e)
        {
            if (nr != 59) { nr = 59; navigare(); }
        }

        private void L59_Click(object sender, EventArgs e)
        {
            if (nr != 59) { nr = 59; navigare(); }
        }

        private void P60_Click(object sender, EventArgs e)
        {
            if (nr != 60) { nr = 60; navigare(); }
        }

        private void L60_Click(object sender, EventArgs e)
        {
            if (nr != 60) { nr = 60; navigare(); }
        }

        private void B60_Click(object sender, EventArgs e)
        {
            if (nr != 60) { nr = 60; navigare(); }
        }

        private void P61_Click(object sender, EventArgs e)
        {
            if (nr != 61) { nr = 61; navigare(); }
        }

        private void L61_Click(object sender, EventArgs e)
        {
            if (nr != 61) { nr = 61; navigare(); }
        }

        private void B61_Click(object sender, EventArgs e)
        {
            if (nr != 61) { nr = 61; navigare(); }
        }

        private void P62_Click(object sender, EventArgs e)
        {
            if (nr != 62) { nr = 62; navigare(); }
        }

        private void L62_Click(object sender, EventArgs e)
        {
            if (nr != 62) { nr = 62; navigare(); }
        }

        private void B62_Click(object sender, EventArgs e)
        {
            if (nr != 62) { nr = 62; navigare(); }
        }

        private void P63_Click(object sender, EventArgs e)
        {
            if (nr != 63) { nr = 63; navigare(); }
        }

        private void L63_Click(object sender, EventArgs e)
        {
            if (nr != 63) { nr = 63; navigare(); }
        }

        private void B63_Click(object sender, EventArgs e)
        {
            if (nr != 63) { nr = 63; navigare(); }
        }

        private void P64_Click(object sender, EventArgs e)
        {
            if (nr != 64) { nr = 64; navigare(); }
        }

        private void L64_Click(object sender, EventArgs e)
        {
            if (nr != 64) { nr = 64; navigare(); }
        }

        private void B64_Click(object sender, EventArgs e)
        {
            if (nr != 64) { nr = 64; navigare(); }
        }

        private void P65_Click(object sender, EventArgs e)
        {
            if (nr != 65) { nr = 65; navigare(); }
        }

        private void L65_Click(object sender, EventArgs e)
        {
            if (nr != 65) { nr = 65; navigare(); }
        }

        private void B65_Click(object sender, EventArgs e)
        {
            if (nr != 65) { nr = 65; navigare(); }
        }


        private void B9_BackgroundImageChanged(object sender, EventArgs e)
        {

        }

        private void B31_BackgroundImageChanged(object sender, EventArgs e)
        {

        }

        private void L54_BindingContextChanged(object sender, EventArgs e)
        {

        }


        private void B1_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 1) L1.BackColor = B1.BackColor = Color.Gold;
        }
        private void L1_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 1) L1.BackColor = B1.BackColor = Color.Gold;
        }
        private void B2_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 2) L2.BackColor = B2.BackColor = Color.Gold;
        }
        private void L2_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 2) L2.BackColor = B2.BackColor = Color.Gold;
        }
        private void B3_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 3) L3.BackColor = B3.BackColor = Color.Gold;
        }
        private void L3_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 3) L3.BackColor = B3.BackColor = Color.Gold;
        }
        private void B4_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 4) L4.BackColor = B4.BackColor = Color.Gold;
        }
        private void L4_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 4) L4.BackColor = B4.BackColor = Color.Gold;
        }
        private void B5_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 5) L5.BackColor = B5.BackColor = Color.Gold;
        }
        private void L5_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 5) L5.BackColor = B5.BackColor = Color.Gold;
        }
        private void B6_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 6) L6.BackColor = B6.BackColor = Color.Gold;
        }
        private void L6_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 6) L6.BackColor = B6.BackColor = Color.Gold;
        }
        private void B7_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 7) L7.BackColor = B7.BackColor = Color.Gold;
        }
        private void L7_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 7) L7.BackColor = B7.BackColor = Color.Gold;
        }
        private void B8_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 8) L8.BackColor = B8.BackColor = Color.Gold;
        }
        private void L8_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 8) L8.BackColor = B8.BackColor = Color.Gold;
        }
        private void B9_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 9) L9.BackColor = B9.BackColor = Color.Gold;
        }
        private void L9_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 9) L9.BackColor = B9.BackColor = Color.Gold;
        }
        private void B10_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 10) L10.BackColor = B10.BackColor = Color.Gold;
        }
        private void L10_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 10) L10.BackColor = B10.BackColor = Color.Gold;
        }
        private void B11_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 11) L11.BackColor = B11.BackColor = Color.Gold;
        }
        private void L11_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 11) L11.BackColor = B11.BackColor = Color.Gold;
        }
        private void B12_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 12) L12.BackColor = B12.BackColor = Color.Gold;
        }
        private void L12_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 12) L12.BackColor = B12.BackColor = Color.Gold;
        }
        private void B13_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 13) L13.BackColor = B13.BackColor = Color.Gold;
        }
        private void L13_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 13) L13.BackColor = B13.BackColor = Color.Gold;
        }
        private void B14_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 14) L14.BackColor = B14.BackColor = Color.Gold;
        }
        private void L14_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 14) L14.BackColor = B14.BackColor = Color.Gold;
        }
        private void B15_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 15) L15.BackColor = B15.BackColor = Color.Gold;
        }
        private void L15_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 15) L15.BackColor = B15.BackColor = Color.Gold;
        }
        private void B16_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 16) L16.BackColor = B16.BackColor = Color.Gold;
        }
        private void L16_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 16) L16.BackColor = B16.BackColor = Color.Gold;
        }
        private void B17_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 17) L17.BackColor = B17.BackColor = Color.Gold;
        }
        private void L17_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 17) L17.BackColor = B17.BackColor = Color.Gold;
        }
        private void B18_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 18) L18.BackColor = B18.BackColor = Color.Gold;
        }
        private void L18_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 18) L18.BackColor = B18.BackColor = Color.Gold;
        }
        private void B19_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 19) L19.BackColor = B19.BackColor = Color.Gold;
        }
        private void L19_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 19) L19.BackColor = B19.BackColor = Color.Gold;
        }
        private void B20_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 20) L20.BackColor = B20.BackColor = Color.Gold;
        }
        private void L20_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 20) L20.BackColor = B20.BackColor = Color.Gold;
        }
        private void B21_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 21) L21.BackColor = B21.BackColor = Color.Gold;
        }
        private void L21_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 21) L21.BackColor = B21.BackColor = Color.Gold;
        }
        private void B22_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 22) L22.BackColor = B22.BackColor = Color.Gold;
        }
        private void L22_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 22) L22.BackColor = B22.BackColor = Color.Gold;
        }
        private void B23_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 23) L23.BackColor = B23.BackColor = Color.Gold;
        }
        private void L23_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 23) L23.BackColor = B23.BackColor = Color.Gold;
        }
        private void B24_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 24) L24.BackColor = B24.BackColor = Color.Gold;
        }
        private void L24_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 24) L24.BackColor = B24.BackColor = Color.Gold;
        }
        private void B25_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 25) L25.BackColor = B25.BackColor = Color.Gold;
        }
        private void L25_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 25) L25.BackColor = B25.BackColor = Color.Gold;
        }
        private void B26_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 26) L26.BackColor = B26.BackColor = Color.Gold;
        }
        private void L26_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 26) L26.BackColor = B26.BackColor = Color.Gold;
        }
        private void B27_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 27) L27.BackColor = B27.BackColor = Color.Gold;
        }
        private void L27_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 27) L27.BackColor = B27.BackColor = Color.Gold;
        }
        private void B28_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 28) L28.BackColor = B28.BackColor = Color.Gold;
        }
        private void L28_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 28) L28.BackColor = B28.BackColor = Color.Gold;
        }
        private void B29_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 29) L29.BackColor = B29.BackColor = Color.Gold;
        }
        private void L29_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 29) L29.BackColor = B29.BackColor = Color.Gold;
        }
        private void B30_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 30) L30.BackColor = B30.BackColor = Color.Gold;
        }
        private void L30_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 30) L30.BackColor = B30.BackColor = Color.Gold;
        }
        private void B31_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 31) L31.BackColor = B31.BackColor = Color.Gold;
        }
        private void L31_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 31) L31.BackColor = B31.BackColor = Color.Gold;
        }
        private void B32_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 32) L32.BackColor = B32.BackColor = Color.Gold;
        }
        private void L32_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 32) L32.BackColor = B32.BackColor = Color.Gold;
        }
        private void B33_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 33) L33.BackColor = B33.BackColor = Color.Gold;
        }
        private void L33_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 33) L33.BackColor = B33.BackColor = Color.Gold;
        }
        private void B34_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 34) L34.BackColor = B34.BackColor = Color.Gold;
        }
        private void L34_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 34) L34.BackColor = B34.BackColor = Color.Gold;
        }
        private void B35_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 35) L35.BackColor = B35.BackColor = Color.Gold;
        }
        private void L35_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 35) L35.BackColor = B35.BackColor = Color.Gold;
        }
        private void B36_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 36) L36.BackColor = B36.BackColor = Color.Gold;
        }
        private void L36_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 36) L36.BackColor = B36.BackColor = Color.Gold;
        }
        private void B37_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 37) L37.BackColor = B37.BackColor = Color.Gold;
        }
        private void L37_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 37) L37.BackColor = B37.BackColor = Color.Gold;
        }
        private void B38_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 38) L38.BackColor = B38.BackColor = Color.Gold;
        }
        private void L38_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 38) L38.BackColor = B38.BackColor = Color.Gold;
        }
        private void B39_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 39) L39.BackColor = B39.BackColor = Color.Gold;
        }
        private void L39_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 39) L39.BackColor = B39.BackColor = Color.Gold;
        }
        private void B40_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 40) L40.BackColor = B40.BackColor = Color.Gold;
        }
        private void L40_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 40) L40.BackColor = B40.BackColor = Color.Gold;
        }
        private void B41_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 41) L41.BackColor = B41.BackColor = Color.Gold;
        }
        private void L41_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 41) L41.BackColor = B41.BackColor = Color.Gold;
        }
        private void B42_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 42) L42.BackColor = B42.BackColor = Color.Gold;
        }
        private void L42_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 42) L42.BackColor = B42.BackColor = Color.Gold;
        }
        private void B43_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 43) L43.BackColor = B43.BackColor = Color.Gold;
        }
        private void L43_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 43) L43.BackColor = B43.BackColor = Color.Gold;
        }
        private void B44_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 44) L44.BackColor = B44.BackColor = Color.Gold;
        }
        private void L44_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 44) L44.BackColor = B44.BackColor = Color.Gold;
        }
        private void B45_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 45) L45.BackColor = B45.BackColor = Color.Gold;
        }
        private void L45_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 45) L45.BackColor = B45.BackColor = Color.Gold;
        }
        private void B46_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 46) L46.BackColor = B46.BackColor = Color.Gold;
        }
        private void L46_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 46) L46.BackColor = B46.BackColor = Color.Gold;
        }
        private void B47_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 47) L47.BackColor = B47.BackColor = Color.Gold;
        }
        private void L47_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 47) L47.BackColor = B47.BackColor = Color.Gold;
        }
        private void B48_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 48) L48.BackColor = B48.BackColor = Color.Gold;
        }
        private void L48_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 48) L48.BackColor = B48.BackColor = Color.Gold;
        }
        private void B49_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 49) L49.BackColor = B49.BackColor = Color.Gold;
        }
        private void L49_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 49) L49.BackColor = B49.BackColor = Color.Gold;
        }
        private void B50_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 50) L50.BackColor = B50.BackColor = Color.Gold;
        }
        private void L50_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 50) L50.BackColor = B50.BackColor = Color.Gold;
        }
        private void B51_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 51) L51.BackColor = B51.BackColor = Color.Gold;
        }
        private void L51_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 51) L51.BackColor = B51.BackColor = Color.Gold;
        }
        private void B52_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 52) L52.BackColor = B52.BackColor = Color.Gold;
        }
        private void L52_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 52) L52.BackColor = B52.BackColor = Color.Gold;
        }
        private void B53_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 53) L53.BackColor = B53.BackColor = Color.Gold;
        }
        private void L53_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 53) L53.BackColor = B53.BackColor = Color.Gold;
        }
        private void B54_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 54) L54.BackColor = B54.BackColor = Color.Gold;
        }
        private void L54_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 54) L54.BackColor = B54.BackColor = Color.Gold;
        }
        private void B55_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 55) L55.BackColor = B55.BackColor = Color.Gold;
        }
        private void L55_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 55) L55.BackColor = B55.BackColor = Color.Gold;
        }
        private void B56_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 56) L56.BackColor = B56.BackColor = Color.Gold;
        }
        private void L56_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 56) L56.BackColor = B56.BackColor = Color.Gold;
        }
        private void B57_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 57) L57.BackColor = B57.BackColor = Color.Gold;
        }
        private void L57_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 57) L57.BackColor = B57.BackColor = Color.Gold;
        }
        private void B58_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 58) L58.BackColor = B58.BackColor = Color.Gold;
        }
        private void L58_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 58) L58.BackColor = B58.BackColor = Color.Gold;
        }
        private void B59_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 59) L59.BackColor = B59.BackColor = Color.Gold;
        }
        private void L59_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 59) L59.BackColor = B59.BackColor = Color.Gold;
        }
        private void B60_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 60) L60.BackColor = B60.BackColor = Color.Gold;
        }
        private void L60_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 60) L60.BackColor = B60.BackColor = Color.Gold;
        }
        private void B61_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 61) L61.BackColor = B61.BackColor = Color.Gold;
        }
        private void L61_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 61) L61.BackColor = B61.BackColor = Color.Gold;
        }
        private void B62_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 62) L62.BackColor = B62.BackColor = Color.Gold;
        }
        private void L62_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 62) L62.BackColor = B62.BackColor = Color.Gold;
        }
        private void B63_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 63) L63.BackColor = B63.BackColor = Color.Gold;
        }
        private void L63_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 63) L63.BackColor = B63.BackColor = Color.Gold;
        }
        private void B64_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 64) L64.BackColor = B64.BackColor = Color.Gold;
        }
        private void L64_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 64) L64.BackColor = B64.BackColor = Color.Gold;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void WindowsMediaPlayer_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            stop_pause = 1 - stop_pause;
            if (stop_pause == 0)
            {
                WindowsMediaPlayer.Ctlcontrols.pause();
                description.Text = "Redă";
                play_stop.BackgroundImage = Properties.Resources.play_video;

            }
            else if (stop_pause == 1)
            {
                WindowsMediaPlayer.Ctlcontrols.play();
                description.Text = "Întrerupe";
                play_stop.BackgroundImage = Properties.Resources.pauza_video;

            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void speaker_Click(object sender, EventArgs e)
        {   volum = 1 - volum;
            if (volum == 0)
            {
                volum_initial = guna2TrackBar2.Value;
                guna2TrackBar2.Value = 0;

                speaker.BackgroundImage = Properties.Resources.speaker_mute;
            }else if (volum == 1)
            {   
                guna2TrackBar2.Value = volum_initial;
                speaker.BackgroundImage = Properties.Resources.speaker_volume;
            }


            WindowsMediaPlayer.settings.volume = guna2TrackBar2.Value;
            label12.Text = guna2TrackBar2.Value.ToString() + "%";
        }

        private void WindowsMediaPlayer_EndOfStream(object sender, AxWMPLib._WMPOCXEvents_EndOfStreamEvent e)
        {
          
        }

        private void WindowsMediaPlayer_Resize(object sender, EventArgs e)
        {
            guna2TrackBar2.Value = WindowsMediaPlayer.settings.volume;

              
            label12.Text = guna2TrackBar2.Value.ToString() + "%";

            if (guna2TrackBar2.Value == 0) speaker.BackgroundImage = Properties.Resources.speaker_mute;
            else speaker.BackgroundImage = Properties.Resources.speaker_volume;
        }

        private void WindowsMediaPlayer_DockChanged(object sender, EventArgs e)
        {

            guna2TrackBar2.Value = WindowsMediaPlayer.settings.volume;


            label12.Text = guna2TrackBar2.Value.ToString() + "%";

            if (guna2TrackBar2.Value == 0) speaker.BackgroundImage = Properties.Resources.speaker_mute;
            else speaker.BackgroundImage = Properties.Resources.speaker_volume;
        }

        private void WindowsMediaPlayer_SizeChanged(object sender, EventArgs e)
        {

            guna2TrackBar2.Value = WindowsMediaPlayer.settings.volume;


            label12.Text = guna2TrackBar2.Value.ToString() + "%";

            if (guna2TrackBar2.Value == 0) speaker.BackgroundImage = Properties.Resources.speaker_mute;
            else speaker.BackgroundImage = Properties.Resources.speaker_volume;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void play_stop_Click(object sender, EventArgs e)
        {
            stop_pause = 1 - stop_pause;
            if (stop_pause == 0)
            {
                WindowsMediaPlayer.Ctlcontrols.pause();
                description.Text = "Redă";
                play_stop.BackgroundImage = Properties.Resources.play_video;

            }
            else if (stop_pause == 1)
            {
                WindowsMediaPlayer.Ctlcontrols.play();
                description.Text = "Întrerupe";
                play_stop.BackgroundImage = Properties.Resources.pauza_video;
              
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void E1_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer.Ctlcontrols.stop();
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void Biog1_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer.Ctlcontrols.stop();
            this.Hide();
            var form5= new Form5();
            form5.Closed += (s, args) => this.Close();
            form5.Show();
        }

        private void S1_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer.Ctlcontrols.stop();
            this.Hide();
            var form3 = new Form3();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void T1_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer.Ctlcontrols.stop();
           
            this.Hide();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void DA_Click(object sender, EventArgs e)
        {
            if (refuz == 2)
            {
                interogatoriu.Visible = DA.Visible = NU.Visible = mafiamember.Visible = false;

            }
            else
            {
                DA.Visible = NU.Visible = false;
                interogatoriu.Text = "Ma gandeam ca o sa- ti placa...";

                var form4 = new Form4();
                form4.Closed += (s, args) => this.Close();
                form4.Show();
            }
        }

        private void NU_Click(object sender, EventArgs e)
        {
            refuz++;
            if (refuz == 1)
            {
                interogatoriu.Text = "Poate fi ultima sansa de a vedea meme- uri.";
            }
            else if (refuz == 2)
            {
                interogatoriu.Text = "Esti sigur ca vrei sa ma refuzi?";
            }
            else if (refuz == 3)
            {

                var form4 = new Form4();
                form4.Closed += (s, args) => this.Close();
                form4.Show();

                DA.Visible = NU.Visible = false;
                interogatoriu.Text = "Asa ma gandeam si eu!";
            }
        }

        private void ARROW_Click(object sender, EventArgs e)
        {
            stanga_output.Visible = false;
            TAB.Visible = true;
           
            thumbnailuri.Visible = true;

        }

        private void TAB_Click(object sender, EventArgs e)
        {
            meme = 1;
            afis_meme();
            stanga_output.Visible = true;

            TAB.Visible = false;
            thumbnailuri.Visible = false;
        }

        private void guna2TrackBar1_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsMediaPlayer.Ctlcontrols.currentPosition = WindowsMediaPlayer.currentMedia.duration * e.X / guna2TrackBar1.Width;

        }

        private void guna2TrackBar1_MouseDown_1(object sender, MouseEventArgs e)
        {
            WindowsMediaPlayer.Ctlcontrols.currentPosition = WindowsMediaPlayer.currentMedia.duration * e.X / guna2TrackBar1.Width;

        }

        private void guna2TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            if ( guna2TrackBar1.Value==100)
            {
                if (nr != 65) { nr++; navigare(); }
            
                
            }
        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void B65_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 65) L65.BackColor = B65.BackColor = Color.Gold;
        }
        private void L65_BackColorChanged(object sender, EventArgs e)
        {
            if (nr == 65) L65.BackColor = B65.BackColor = Color.Gold;
        }
    }
}
