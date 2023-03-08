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
    public partial class Form5 : Form
    {
        int l;
        bool memes;
        int q;
        int x1, y1, z1, x2, y2, z2;
        int nr;
        int stop_pause = 1;
        int volum = 1;
        int volum_initial;
        int refuz;
        int meme;
        public Form5()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            label1.Text = " ";
            stanga_output.Visible = false;
            stanga_output.BackColor = Color.FromArgb(22, 18, 88);
            ARROW.BackgroundImage = Properties.Resources.left;
            TAB1.BackgroundImage =TAB2.BackgroundImage= Properties.Resources.bars;
            E1.FlatStyle = S1.FlatStyle = SC1.FlatStyle = T1.FlatStyle = FlatStyle.Flat;
            E1.ForeColor = S1.ForeColor = SC1.ForeColor = T1.ForeColor = interogatoriu.ForeColor =DA.ForeColor=NU.ForeColor= Color.White;
            ///rezolutie poze butoane:75X90
            ///rezolutie poza mare:375X450
            x1 = 22; y2 = 18; z1 = 126; //bleumarin
            x2 = 236; y2 = 240; z2 = 241; ///alb



            Next1.Cursor = Next2.Cursor = Prev1.Cursor = Prev2.Cursor = tbn.Cursor = ytb.Cursor = E1.Cursor = E2.Cursor = S1.Cursor = S2.Cursor = SC1.Cursor = SC2.Cursor = T1.Cursor = T2.Cursor = ARROW.Cursor = DA.Cursor = NU.Cursor = TAB1.Cursor = TAB2.Cursor = cauta_pers.Cursor = Cursors.Hand;
            bio1.Cursor = name1.Cursor = time1.Cursor = under1.Cursor = poza1.Cursor = bio2.Cursor = name2.Cursor = time2.Cursor = under2.Cursor = poza2.Cursor = bio3.Cursor = name3.Cursor = time3.Cursor = under3.Cursor = poza3.Cursor = bio4.Cursor = name4.Cursor = time4.Cursor = under4.Cursor = poza4.Cursor = bio5.Cursor = name5.Cursor = time5.Cursor = under5.Cursor = poza5.Cursor = bio6.Cursor = name6.Cursor = time6.Cursor = under6.Cursor = poza6.Cursor = bio7.Cursor = name7.Cursor = time7.Cursor = under7.Cursor = poza7.Cursor = bio8.Cursor = name8.Cursor = time8.Cursor = under8.Cursor = poza8.Cursor = bio9.Cursor = name9.Cursor = time9.Cursor = under9.Cursor = poza9.Cursor = bio10.Cursor = name10.Cursor = time10.Cursor = under10.Cursor = poza10.Cursor = bio11.Cursor = name11.Cursor = time11.Cursor = under11.Cursor = poza11.Cursor = bio12.Cursor = name12.Cursor = time12.Cursor = under12.Cursor = poza12.Cursor = bio13.Cursor = name13.Cursor = time13.Cursor = under13.Cursor = poza13.Cursor = bio14.Cursor = name14.Cursor = time14.Cursor = under14.Cursor = poza14.Cursor = bio15.Cursor = name15.Cursor = time15.Cursor = under15.Cursor = poza15.Cursor = bio16.Cursor = name16.Cursor = time16.Cursor = under16.Cursor = poza16.Cursor = bio17.Cursor = name17.Cursor = time17.Cursor = under17.Cursor = poza17.Cursor = bio18.Cursor = name18.Cursor = time18.Cursor = under18.Cursor = poza18.Cursor = bio19.Cursor = name19.Cursor = time19.Cursor = under19.Cursor = poza19.Cursor = bio20.Cursor = name20.Cursor = time20.Cursor = under20.Cursor = poza20.Cursor = bio21.Cursor = name21.Cursor = time21.Cursor = under21.Cursor = poza21.Cursor = bio22.Cursor = name22.Cursor = time22.Cursor = under22.Cursor = poza22.Cursor = bio23.Cursor = name23.Cursor = time23.Cursor = under23.Cursor = poza23.Cursor = bio24.Cursor = name24.Cursor = time24.Cursor = under24.Cursor = poza24.Cursor = bio25.Cursor = name25.Cursor = time25.Cursor = under25.Cursor = poza25.Cursor = bio26.Cursor = name26.Cursor = time26.Cursor = under26.Cursor = poza26.Cursor = bio27.Cursor = name27.Cursor = time27.Cursor = under27.Cursor = poza27.Cursor = bio28.Cursor = name28.Cursor = time28.Cursor = under28.Cursor = poza28.Cursor = bio29.Cursor = name29.Cursor = time29.Cursor = under29.Cursor = poza29.Cursor = bio30.Cursor = name30.Cursor = time30.Cursor = under30.Cursor = poza30.Cursor = bio31.Cursor = name31.Cursor = time31.Cursor = under31.Cursor = poza31.Cursor = bio32.Cursor = name32.Cursor = time32.Cursor = under32.Cursor = poza32.Cursor = bio33.Cursor = name33.Cursor = time33.Cursor = under33.Cursor = poza33.Cursor = bio34.Cursor = name34.Cursor = time34.Cursor = under34.Cursor = poza34.Cursor = bio35.Cursor = name35.Cursor = time35.Cursor = under35.Cursor = poza35.Cursor = bio36.Cursor = name36.Cursor = time36.Cursor = under36.Cursor = poza36.Cursor = bio37.Cursor = name37.Cursor = time37.Cursor = under37.Cursor = poza37.Cursor = bio38.Cursor = name38.Cursor = time38.Cursor = under38.Cursor = poza38.Cursor = bio39.Cursor = name39.Cursor = time39.Cursor = under39.Cursor = poza39.Cursor = bio40.Cursor = name40.Cursor = time40.Cursor = under40.Cursor = poza40.Cursor = bio41.Cursor = name41.Cursor = time41.Cursor = under41.Cursor = poza41.Cursor = bio42.Cursor = name42.Cursor = time42.Cursor = under42.Cursor = poza42.Cursor = Cursors.Hand;


            Next1.BackColor = Next2.BackColor = Prev1.BackColor = Prev2.BackColor = Color.FromArgb(x1, y1, z1);
            Next1.ForeColor = Next2.ForeColor = Prev1.ForeColor = Prev2.ForeColor = Color.FromArgb(x2, y2, z2);
            Next1.FlatStyle = Next2.FlatStyle = Prev1.FlatStyle = Prev2.FlatStyle=FlatStyle.Flat;
            name1.Text = "Abraham Lincoln"; time1.Text = "12 februarie 1809-15 aprilie 1865";
            name2.Text = "Otto Von Bismark"; time2.Text = "1 aprilie 1815- 30 iulie 1898";
            name3.Text = "Mihail Kogălniceanu"; time3.Text = "6 septembrie 1817–1 iulie 1891";
            name4.Text = "Alexandru Ioan Cuza"; time4.Text = " 20 martie/1 aprilie 1820 –3 mai 1873";
            name5.Text = "Victor Babeș"; time5.Text = "iulie 1854-19 octombrie 1926";
            name6.Text = "Dimitrie A. Sturdza"; time6.Text = "10 martie 1833 –8 octombrie 1914";


            name7.Text = "Carol Davilla"; time7.Text = "8 aprilie 1828-24 august 1884";
            name8.Text = "Nicolae Minovici"; time8.Text = "	23 octombrie 1868-	26 iunie 1941 ";

            name9.Text = "Nikola Tesla"; time9.Text = "10 iulie 1856-7 ianuarie 1943";
           
            name10.Text = "Marie Curie"; time10.Text = "7 noiembrie 1867-4 iulie 1934";
            name11.Text = "Henri Coandă"; time11.Text = "7 iunie 1886-25 noiembrie 1972";
       
            name12.Text = "Regele Carol I"; time12.Text = "20 aprilie 1839-10 octombrie 1914";
          
            
            name13.Text = "Regele Ferdinand I"; time13.Text = "24 august 1865-20 iulie 1927";
            name14.Text = "Ion I.C. Brătianu"; time14.Text = "20 august 1864-24 noiembrie 1927";
            name15.Text = "Regina Maria"; time15.Text = "29 octombrie 1875-18 iulie 1938";
            name16.Text = "Vladimir Il'ič Lenin"; time16.Text = "22 aprilie 1870-21 ianuarie 1924";

            name17.Text = "Emil Racoviță"; time17.Text = "15 noiembrie 1868- 17 noiembrie 1947";

            
           
            name18.Text = "Albert Einstein"; time18.Text = "14 martie 1879-18 aprilie 1955";
           
            name19.Text = "Felix Hoffmann"; time19.Text = "21 ianuarie 1868-8 februarie 1946";
            name20.Text = "Maria Mihăescu"; time20.Text = "1885-1968";

            name21.Text = "Benito Mussolini"; time21.Text = "29 iulie 1883-28 aprilie 1945";
            name22.Text = "Adolf Hitler"; time22.Text = "20 aprilie 1889-30 aprilie 1945";

            name23.Text = "Iosif Vissarionovici Stalin"; time23.Text = "18 decembrie 1878-5 martie 1953";
            name24.Text = "Lavrenti Beria"; time24.Text = "29 martie 1899-23 decembrie 1953";
            name25.Text = "Vyacheslav Molotov"; time25.Text = "9 martie 1890-8 noiembrie 1986";
         
            name26.Text = "Winston Churchill"; time26.Text = "30 noiembrie 1874- 24 ianuarie 1965";
            name27.Text = "George al VI-lea"; time27.Text = "14 decembrie 1895-6 februarie 1952";

           
            name28.Text = "Adolf Eichmann"; time28.Text = "19 martie 1906-1 iunie 1962";
            name29.Text = "Erwin Rommel"; time29.Text = "15 noiembrie 1891-14 octombrie 1944";
            name30.Text = "Hermann Göring"; time30.Text = "12 ianuarie 1893-15 octombrie 1946";
            name31.Text = "Joseph Goebbels"; time31.Text = "29 octombrie 1897-1 mai 1945";
            name32.Text = "Heinrich Himmler"; time32.Text = "7 octombrie 1900-23 mai 1945";
            name33.Text = "Regele Carol II-lea"; time33.Text = "15 octombrie 1893-4 aprilie 1953";
            name34.Text = "Regele Mihai I"; time34.Text = "25 octombrie 1921-5 decembrie 2017";

           

            name35.Text = "Charles de Gaulle"; time35.Text = "22 noiembrie 1890-9 noiembrie 1970";
            name36.Text = "George Marshall"; time36.Text = "31 decembrie 1880-16 octombrie 1959";

            name37.Text = "Gheorghe-Gheorghiu Dej"; time37.Text = "8 noiembrie 1901-19 martie 1965";

            name38.Text = "Nicolae Ceausescu"; time38.Text = "26 ianuarie 1918-25 decembrie 1989";
            name39.Text = "Fidel Castro"; time39.Text = "13 august 1926-25 noiembrie 2016";



            name40.Text = "John.F.Kennedy"; time40.Text = "29 mai 1917-22 noiembrie 1963";
          
            name41.Text = "Richard Nixon"; time41.Text = "9 ianuarie 1913-22 aprilie 1994";
            name42.Text = "Ronald Reagan"; time42.Text = "6 februarie 1911-5 iunie 2004";

            //  pna.AutoScroll = false;


            SC2.FlatStyle = S2.FlatStyle  =T2.FlatStyle =E2.FlatStyle= FlatStyle.Flat;

            SC2.Font = S2.Font = T2.Font = E2.Font = new Font("Microsoft Sans Serif", 20);
            E2.ForeColor = S2.ForeColor = T2.ForeColor = SC2.ForeColor = Color.White;


            poza1.SizeMode = poza2.SizeMode = poza3.SizeMode = poza4.SizeMode = poza5.SizeMode = poza6.SizeMode = poza7.SizeMode = poza8.SizeMode = poza9.SizeMode = poza10.SizeMode = poza11.SizeMode = poza12.SizeMode = poza13.SizeMode = poza14.SizeMode = poza15.SizeMode = poza16.SizeMode = poza17.SizeMode = poza18.SizeMode = poza19.SizeMode = poza20.SizeMode = poza21.SizeMode = poza22.SizeMode = poza23.SizeMode = poza24.SizeMode = poza25.SizeMode = poza26.SizeMode = poza27.SizeMode = poza28.SizeMode = poza29.SizeMode = poza30.SizeMode = poza31.SizeMode = poza32.SizeMode = poza33.SizeMode = poza34.SizeMode = poza35.SizeMode = poza36.SizeMode = poza37.SizeMode = poza38.SizeMode = poza39.SizeMode =poza40.SizeMode=poza41.SizeMode=poza42.SizeMode= PictureBoxSizeMode.StretchImage;

            mafiamember.BackgroundImage = Properties.Resources.mafiot;
            DA.Cursor = NU.Cursor = interogatoriu.Cursor = mafiamember.Cursor = Cursors.Hand;


            Descriere1.ForeColor = Descriere2.ForeColor = Color.White;
            poza1.BackgroundImage = Properties.Resources.p1;
            poza2.BackgroundImage = Properties.Resources.p2;
            poza3.BackgroundImage = Properties.Resources.p3;
            poza4.BackgroundImage = Properties.Resources.p4;
            poza5.BackgroundImage = Properties.Resources.p5;
            poza6.BackgroundImage = Properties.Resources.p6;
            poza7.BackgroundImage = Properties.Resources.p7;
            poza8.BackgroundImage = Properties.Resources.p8;
            poza9.BackgroundImage = Properties.Resources.p9;
            poza10.BackgroundImage = Properties.Resources.p10;
            poza11.BackgroundImage = Properties.Resources.p11;
            poza12.BackgroundImage = Properties.Resources.p12;
            poza13.BackgroundImage = Properties.Resources.p13;
            poza14.BackgroundImage = Properties.Resources.p14;
            poza15.BackgroundImage = Properties.Resources.p15;
            poza16.BackgroundImage = Properties.Resources.p16;
            poza17.BackgroundImage = Properties.Resources.p17;
            poza18.BackgroundImage = Properties.Resources.p18;
            poza19.BackgroundImage = Properties.Resources.p19;
            poza20.BackgroundImage = Properties.Resources.p20;
            poza21.BackgroundImage = Properties.Resources.p21;
            poza22.BackgroundImage = Properties.Resources.p22;
            poza23.BackgroundImage = Properties.Resources.p23;
            poza24.BackgroundImage = Properties.Resources.p24;
            poza25.BackgroundImage = Properties.Resources.p25;
            poza26.BackgroundImage = Properties.Resources.p26;
            poza27.BackgroundImage = Properties.Resources.p27;
            poza28.BackgroundImage = Properties.Resources.p28;
            poza29.BackgroundImage = Properties.Resources.p29;
            poza30.BackgroundImage = Properties.Resources.p30;
            poza31.BackgroundImage = Properties.Resources.p31;
            poza32.BackgroundImage = Properties.Resources.p32;
            poza33.BackgroundImage = Properties.Resources.p33;
            poza34.BackgroundImage = Properties.Resources.p34;
            poza35.BackgroundImage = Properties.Resources.p35;
            poza36.BackgroundImage = Properties.Resources.p36;
            poza37.BackgroundImage = Properties.Resources.p37;
            poza38.BackgroundImage = Properties.Resources.p38;
            poza39.BackgroundImage = Properties.Resources.p39;
            poza40.BackgroundImage = Properties.Resources.p40;
            poza41.BackgroundImage = Properties.Resources.p41;
            poza42.BackgroundImage = Properties.Resources.p42;














            guna2TrackBar1.Cursor = guna2TrackBar2.Cursor = WindowsMediaPlayer.Cursor = play_stop.Cursor=speaker.Cursor = Cursors.Hand;






            ytb.BackgroundImage = Properties.Resources.youtubenegru; ytb.Cursor = Cursors.Hand;

            pnb.Visible = false;



            Descriere1.Font =Descriere2.Font= new Font("Monotype Corsiva", 18);
            name1.Font = name2.Font = name3.Font = name4.Font = name5.Font = name6.Font = name7.Font = name8.Font = name9.Font = name10.Font = name11.Font = name12.Font = name13.Font = name14.Font = name15.Font = name16.Font = name17.Font = name18.Font = name19.Font = name20.Font = name21.Font = name22.Font = name23.Font = name24.Font = name25.Font = name26.Font = name27.Font = name28.Font = name29.Font = name30.Font = name31.Font = name32.Font = name33.Font = name34.Font = name35.Font = name36.Font = name37.Font = name38.Font = name39.Font = name40.Font = name41.Font = name42.Font = new Font("Georgia", 15);
            time1.Font = time2.Font = time3.Font = time4.Font = time5.Font = time6.Font = time7.Font = time8.Font = time9.Font = time10.Font = time11.Font = time12.Font = time13.Font = time14.Font = time15.Font = time16.Font = time17.Font = time18.Font = time19.Font = time20.Font = time21.Font = time22.Font = time23.Font = time24.Font = time25.Font = time26.Font = time27.Font = time28.Font = time29.Font = time30.Font = time31.Font = time32.Font = time33.Font = time34.Font = time35.Font = time36.Font =time37.Font=time38.Font=time39.Font=time40.Font=time41.Font=time42.Font= new Font("Stencil",11);
            under1.FlatStyle = under2.FlatStyle = under3.FlatStyle = under4.FlatStyle = under5.FlatStyle = under6.FlatStyle = under7.FlatStyle = under8.FlatStyle = under9.FlatStyle = under10.FlatStyle = under11.FlatStyle = under12.FlatStyle = under13.FlatStyle = under14.FlatStyle = under15.FlatStyle = under16.FlatStyle = under17.FlatStyle = under18.FlatStyle = under19.FlatStyle = under20.FlatStyle = under21.FlatStyle = under22.FlatStyle = under23.FlatStyle = under24.FlatStyle = under25.FlatStyle = under26.FlatStyle = under27.FlatStyle = under28.FlatStyle = under29.FlatStyle = under30.FlatStyle = under31.FlatStyle = under32.FlatStyle = under33.FlatStyle = under34.FlatStyle = under35.FlatStyle = under36.FlatStyle =under37.FlatStyle=under38.FlatStyle=under39.FlatStyle=under40.FlatStyle=under41.FlatStyle=under42.FlatStyle= FlatStyle.Popup;
            under1.BackColor = under2.BackColor = under3.BackColor = under4.BackColor = under5.BackColor = under6.BackColor = under7.BackColor = under8.BackColor = under9.BackColor = under10.BackColor = under11.BackColor = under12.BackColor = under13.BackColor = under14.BackColor = under15.BackColor = under16.BackColor = under17.BackColor = under18.BackColor = under19.BackColor = under20.BackColor = under21.BackColor = under22.BackColor = under23.BackColor = under24.BackColor = under25.BackColor = under26.BackColor = under27.BackColor = under28.BackColor = under29.BackColor = under30.BackColor = under31.BackColor = under32.BackColor = under33.BackColor = under34.BackColor = under35.BackColor = under36.BackColor = under37.BackColor = under38.BackColor = under39.BackColor = under40.BackColor = under41.BackColor = under42.BackColor = Color.FromArgb(x1, y1, z1);


            cauta_pers.MouseEnter += OnMouseEntercauta_pers; cauta_pers.MouseLeave += OnMouseLeavecauta_pers;


            ytb.MouseEnter += OnMouseEnterytb; ytb.MouseLeave += OnMouseLeaveytb;

            E2.MouseEnter += OnMouseEnterE2;E2.MouseLeave += OnMouseLeaveE2;
            SC2.MouseEnter += OnMouseEnterSC2; SC2.MouseLeave += OnMouseLeaveSC2;
            T2.MouseEnter += OnMouseEnterT2;T2.MouseLeave += OnMouseLeaveT2;
            S2.MouseEnter += OnMouseEnterS2;S2.MouseLeave += OnMouseLeaveS2;





            play_stop.MouseEnter += OnMouseEnterplay_stop; play_stop.MouseLeave += OnMouseLeaveplay_stop;






            bio1.MouseEnter += OnMouseEnterbio1; bio1.MouseLeave += OnMouseLeavebio1;
            name1.MouseEnter += OnMouseEnterbio1; name1.MouseLeave += OnMouseLeavebio1;
            time1.MouseEnter += OnMouseEnterbio1; time1.MouseLeave += OnMouseLeavebio1;
            poza1.MouseEnter += OnMouseEnterbio1; poza1.MouseLeave += OnMouseLeavebio1;
            under1.MouseEnter += OnMouseEnterbio1; under1.MouseLeave += OnMouseLeavebio1;


            bio2.MouseEnter += OnMouseEnterbio2; bio2.MouseLeave += OnMouseLeavebio2;
            name2.MouseEnter += OnMouseEnterbio2; name2.MouseLeave += OnMouseLeavebio2;
            time2.MouseEnter += OnMouseEnterbio2; time2.MouseLeave += OnMouseLeavebio2;
            poza2.MouseEnter += OnMouseEnterbio2; poza2.MouseLeave += OnMouseLeavebio2;
            under2.MouseEnter += OnMouseEnterbio2; under2.MouseLeave += OnMouseLeavebio2;


            bio3.MouseEnter += OnMouseEnterbio3; bio3.MouseLeave += OnMouseLeavebio3;
            name3.MouseEnter += OnMouseEnterbio3; name3.MouseLeave += OnMouseLeavebio3;
            time3.MouseEnter += OnMouseEnterbio3; time3.MouseLeave += OnMouseLeavebio3;
            poza3.MouseEnter += OnMouseEnterbio3; poza3.MouseLeave += OnMouseLeavebio3;
            under3.MouseEnter += OnMouseEnterbio3; under3.MouseLeave += OnMouseLeavebio3;


            bio4.MouseEnter += OnMouseEnterbio4; bio4.MouseLeave += OnMouseLeavebio4;
            name4.MouseEnter += OnMouseEnterbio4; name4.MouseLeave += OnMouseLeavebio4;
            time4.MouseEnter += OnMouseEnterbio4; time4.MouseLeave += OnMouseLeavebio4;
            poza4.MouseEnter += OnMouseEnterbio4; poza4.MouseLeave += OnMouseLeavebio4;
            under4.MouseEnter += OnMouseEnterbio4; under4.MouseLeave += OnMouseLeavebio4;


            bio5.MouseEnter += OnMouseEnterbio5; bio5.MouseLeave += OnMouseLeavebio5;
            name5.MouseEnter += OnMouseEnterbio5; name5.MouseLeave += OnMouseLeavebio5;
            time5.MouseEnter += OnMouseEnterbio5; time5.MouseLeave += OnMouseLeavebio5;
            poza5.MouseEnter += OnMouseEnterbio5; poza5.MouseLeave += OnMouseLeavebio5;
            under5.MouseEnter += OnMouseEnterbio5; under5.MouseLeave += OnMouseLeavebio5;


            bio6.MouseEnter += OnMouseEnterbio6; bio6.MouseLeave += OnMouseLeavebio6;
            name6.MouseEnter += OnMouseEnterbio6; name6.MouseLeave += OnMouseLeavebio6;
            time6.MouseEnter += OnMouseEnterbio6; time6.MouseLeave += OnMouseLeavebio6;
            poza6.MouseEnter += OnMouseEnterbio6; poza6.MouseLeave += OnMouseLeavebio6;
            under6.MouseEnter += OnMouseEnterbio6; under6.MouseLeave += OnMouseLeavebio6;


            bio7.MouseEnter += OnMouseEnterbio7; bio7.MouseLeave += OnMouseLeavebio7;
            name7.MouseEnter += OnMouseEnterbio7; name7.MouseLeave += OnMouseLeavebio7;
            time7.MouseEnter += OnMouseEnterbio7; time7.MouseLeave += OnMouseLeavebio7;
            poza7.MouseEnter += OnMouseEnterbio7; poza7.MouseLeave += OnMouseLeavebio7;
            under7.MouseEnter += OnMouseEnterbio7; under7.MouseLeave += OnMouseLeavebio7;


            bio8.MouseEnter += OnMouseEnterbio8; bio8.MouseLeave += OnMouseLeavebio8;
            name8.MouseEnter += OnMouseEnterbio8; name8.MouseLeave += OnMouseLeavebio8;
            time8.MouseEnter += OnMouseEnterbio8; time8.MouseLeave += OnMouseLeavebio8;
            poza8.MouseEnter += OnMouseEnterbio8; poza8.MouseLeave += OnMouseLeavebio8;
            under8.MouseEnter += OnMouseEnterbio8; under8.MouseLeave += OnMouseLeavebio8;


            bio9.MouseEnter += OnMouseEnterbio9; bio9.MouseLeave += OnMouseLeavebio9;
            name9.MouseEnter += OnMouseEnterbio9; name9.MouseLeave += OnMouseLeavebio9;
            time9.MouseEnter += OnMouseEnterbio9; time9.MouseLeave += OnMouseLeavebio9;
            poza9.MouseEnter += OnMouseEnterbio9; poza9.MouseLeave += OnMouseLeavebio9;
            under9.MouseEnter += OnMouseEnterbio9; under9.MouseLeave += OnMouseLeavebio9;


            bio10.MouseEnter += OnMouseEnterbio10; bio10.MouseLeave += OnMouseLeavebio10;
            name10.MouseEnter += OnMouseEnterbio10; name10.MouseLeave += OnMouseLeavebio10;
            time10.MouseEnter += OnMouseEnterbio10; time10.MouseLeave += OnMouseLeavebio10;
            poza10.MouseEnter += OnMouseEnterbio10; poza10.MouseLeave += OnMouseLeavebio10;
            under10.MouseEnter += OnMouseEnterbio10; under10.MouseLeave += OnMouseLeavebio10;


            bio11.MouseEnter += OnMouseEnterbio11; bio11.MouseLeave += OnMouseLeavebio11;
            name11.MouseEnter += OnMouseEnterbio11; name11.MouseLeave += OnMouseLeavebio11;
            time11.MouseEnter += OnMouseEnterbio11; time11.MouseLeave += OnMouseLeavebio11;
            poza11.MouseEnter += OnMouseEnterbio11; poza11.MouseLeave += OnMouseLeavebio11;
            under11.MouseEnter += OnMouseEnterbio11; under11.MouseLeave += OnMouseLeavebio11;


            bio12.MouseEnter += OnMouseEnterbio12; bio12.MouseLeave += OnMouseLeavebio12;
            name12.MouseEnter += OnMouseEnterbio12; name12.MouseLeave += OnMouseLeavebio12;
            time12.MouseEnter += OnMouseEnterbio12; time12.MouseLeave += OnMouseLeavebio12;
            poza12.MouseEnter += OnMouseEnterbio12; poza12.MouseLeave += OnMouseLeavebio12;
            under12.MouseEnter += OnMouseEnterbio12; under12.MouseLeave += OnMouseLeavebio12;


            bio13.MouseEnter += OnMouseEnterbio13; bio13.MouseLeave += OnMouseLeavebio13;
            name13.MouseEnter += OnMouseEnterbio13; name13.MouseLeave += OnMouseLeavebio13;
            time13.MouseEnter += OnMouseEnterbio13; time13.MouseLeave += OnMouseLeavebio13;
            poza13.MouseEnter += OnMouseEnterbio13; poza13.MouseLeave += OnMouseLeavebio13;
            under13.MouseEnter += OnMouseEnterbio13; under13.MouseLeave += OnMouseLeavebio13;


            bio14.MouseEnter += OnMouseEnterbio14; bio14.MouseLeave += OnMouseLeavebio14;
            name14.MouseEnter += OnMouseEnterbio14; name14.MouseLeave += OnMouseLeavebio14;
            time14.MouseEnter += OnMouseEnterbio14; time14.MouseLeave += OnMouseLeavebio14;
            poza14.MouseEnter += OnMouseEnterbio14; poza14.MouseLeave += OnMouseLeavebio14;
            under14.MouseEnter += OnMouseEnterbio14; under14.MouseLeave += OnMouseLeavebio14;


            bio15.MouseEnter += OnMouseEnterbio15; bio15.MouseLeave += OnMouseLeavebio15;
            name15.MouseEnter += OnMouseEnterbio15; name15.MouseLeave += OnMouseLeavebio15;
            time15.MouseEnter += OnMouseEnterbio15; time15.MouseLeave += OnMouseLeavebio15;
            poza15.MouseEnter += OnMouseEnterbio15; poza15.MouseLeave += OnMouseLeavebio15;
            under15.MouseEnter += OnMouseEnterbio15; under15.MouseLeave += OnMouseLeavebio15;


            bio16.MouseEnter += OnMouseEnterbio16; bio16.MouseLeave += OnMouseLeavebio16;
            name16.MouseEnter += OnMouseEnterbio16; name16.MouseLeave += OnMouseLeavebio16;
            time16.MouseEnter += OnMouseEnterbio16; time16.MouseLeave += OnMouseLeavebio16;
            poza16.MouseEnter += OnMouseEnterbio16; poza16.MouseLeave += OnMouseLeavebio16;
            under16.MouseEnter += OnMouseEnterbio16; under16.MouseLeave += OnMouseLeavebio16;


            bio17.MouseEnter += OnMouseEnterbio17; bio17.MouseLeave += OnMouseLeavebio17;
            name17.MouseEnter += OnMouseEnterbio17; name17.MouseLeave += OnMouseLeavebio17;
            time17.MouseEnter += OnMouseEnterbio17; time17.MouseLeave += OnMouseLeavebio17;
            poza17.MouseEnter += OnMouseEnterbio17; poza17.MouseLeave += OnMouseLeavebio17;
            under17.MouseEnter += OnMouseEnterbio17; under17.MouseLeave += OnMouseLeavebio17;


            bio18.MouseEnter += OnMouseEnterbio18; bio18.MouseLeave += OnMouseLeavebio18;
            name18.MouseEnter += OnMouseEnterbio18; name18.MouseLeave += OnMouseLeavebio18;
            time18.MouseEnter += OnMouseEnterbio18; time18.MouseLeave += OnMouseLeavebio18;
            poza18.MouseEnter += OnMouseEnterbio18; poza18.MouseLeave += OnMouseLeavebio18;
            under18.MouseEnter += OnMouseEnterbio18; under18.MouseLeave += OnMouseLeavebio18;


            bio19.MouseEnter += OnMouseEnterbio19; bio19.MouseLeave += OnMouseLeavebio19;
            name19.MouseEnter += OnMouseEnterbio19; name19.MouseLeave += OnMouseLeavebio19;
            time19.MouseEnter += OnMouseEnterbio19; time19.MouseLeave += OnMouseLeavebio19;
            poza19.MouseEnter += OnMouseEnterbio19; poza19.MouseLeave += OnMouseLeavebio19;
            under19.MouseEnter += OnMouseEnterbio19; under19.MouseLeave += OnMouseLeavebio19;


            bio20.MouseEnter += OnMouseEnterbio20; bio20.MouseLeave += OnMouseLeavebio20;
            name20.MouseEnter += OnMouseEnterbio20; name20.MouseLeave += OnMouseLeavebio20;
            time20.MouseEnter += OnMouseEnterbio20; time20.MouseLeave += OnMouseLeavebio20;
            poza20.MouseEnter += OnMouseEnterbio20; poza20.MouseLeave += OnMouseLeavebio20;
            under20.MouseEnter += OnMouseEnterbio20; under20.MouseLeave += OnMouseLeavebio20;


            bio21.MouseEnter += OnMouseEnterbio21; bio21.MouseLeave += OnMouseLeavebio21;
            name21.MouseEnter += OnMouseEnterbio21; name21.MouseLeave += OnMouseLeavebio21;
            time21.MouseEnter += OnMouseEnterbio21; time21.MouseLeave += OnMouseLeavebio21;
            poza21.MouseEnter += OnMouseEnterbio21; poza21.MouseLeave += OnMouseLeavebio21;
            under21.MouseEnter += OnMouseEnterbio21; under21.MouseLeave += OnMouseLeavebio21;


            bio22.MouseEnter += OnMouseEnterbio22; bio22.MouseLeave += OnMouseLeavebio22;
            name22.MouseEnter += OnMouseEnterbio22; name22.MouseLeave += OnMouseLeavebio22;
            time22.MouseEnter += OnMouseEnterbio22; time22.MouseLeave += OnMouseLeavebio22;
            poza22.MouseEnter += OnMouseEnterbio22; poza22.MouseLeave += OnMouseLeavebio22;
            under22.MouseEnter += OnMouseEnterbio22; under22.MouseLeave += OnMouseLeavebio22;


            bio23.MouseEnter += OnMouseEnterbio23; bio23.MouseLeave += OnMouseLeavebio23;
            name23.MouseEnter += OnMouseEnterbio23; name23.MouseLeave += OnMouseLeavebio23;
            time23.MouseEnter += OnMouseEnterbio23; time23.MouseLeave += OnMouseLeavebio23;
            poza23.MouseEnter += OnMouseEnterbio23; poza23.MouseLeave += OnMouseLeavebio23;
            under23.MouseEnter += OnMouseEnterbio23; under23.MouseLeave += OnMouseLeavebio23;


            bio24.MouseEnter += OnMouseEnterbio24; bio24.MouseLeave += OnMouseLeavebio24;
            name24.MouseEnter += OnMouseEnterbio24; name24.MouseLeave += OnMouseLeavebio24;
            time24.MouseEnter += OnMouseEnterbio24; time24.MouseLeave += OnMouseLeavebio24;
            poza24.MouseEnter += OnMouseEnterbio24; poza24.MouseLeave += OnMouseLeavebio24;
            under24.MouseEnter += OnMouseEnterbio24; under24.MouseLeave += OnMouseLeavebio24;


            bio25.MouseEnter += OnMouseEnterbio25; bio25.MouseLeave += OnMouseLeavebio25;
            name25.MouseEnter += OnMouseEnterbio25; name25.MouseLeave += OnMouseLeavebio25;
            time25.MouseEnter += OnMouseEnterbio25; time25.MouseLeave += OnMouseLeavebio25;
            poza25.MouseEnter += OnMouseEnterbio25; poza25.MouseLeave += OnMouseLeavebio25;
            under25.MouseEnter += OnMouseEnterbio25; under25.MouseLeave += OnMouseLeavebio25;


            bio26.MouseEnter += OnMouseEnterbio26; bio26.MouseLeave += OnMouseLeavebio26;
            name26.MouseEnter += OnMouseEnterbio26; name26.MouseLeave += OnMouseLeavebio26;
            time26.MouseEnter += OnMouseEnterbio26; time26.MouseLeave += OnMouseLeavebio26;
            poza26.MouseEnter += OnMouseEnterbio26; poza26.MouseLeave += OnMouseLeavebio26;
            under26.MouseEnter += OnMouseEnterbio26; under26.MouseLeave += OnMouseLeavebio26;


            bio27.MouseEnter += OnMouseEnterbio27; bio27.MouseLeave += OnMouseLeavebio27;
            name27.MouseEnter += OnMouseEnterbio27; name27.MouseLeave += OnMouseLeavebio27;
            time27.MouseEnter += OnMouseEnterbio27; time27.MouseLeave += OnMouseLeavebio27;
            poza27.MouseEnter += OnMouseEnterbio27; poza27.MouseLeave += OnMouseLeavebio27;
            under27.MouseEnter += OnMouseEnterbio27; under27.MouseLeave += OnMouseLeavebio27;


            bio28.MouseEnter += OnMouseEnterbio28; bio28.MouseLeave += OnMouseLeavebio28;
            name28.MouseEnter += OnMouseEnterbio28; name28.MouseLeave += OnMouseLeavebio28;
            time28.MouseEnter += OnMouseEnterbio28; time28.MouseLeave += OnMouseLeavebio28;
            poza28.MouseEnter += OnMouseEnterbio28; poza28.MouseLeave += OnMouseLeavebio28;
            under28.MouseEnter += OnMouseEnterbio28; under28.MouseLeave += OnMouseLeavebio28;


            bio29.MouseEnter += OnMouseEnterbio29; bio29.MouseLeave += OnMouseLeavebio29;
            name29.MouseEnter += OnMouseEnterbio29; name29.MouseLeave += OnMouseLeavebio29;
            time29.MouseEnter += OnMouseEnterbio29; time29.MouseLeave += OnMouseLeavebio29;
            poza29.MouseEnter += OnMouseEnterbio29; poza29.MouseLeave += OnMouseLeavebio29;
            under29.MouseEnter += OnMouseEnterbio29; under29.MouseLeave += OnMouseLeavebio29;


            bio30.MouseEnter += OnMouseEnterbio30; bio30.MouseLeave += OnMouseLeavebio30;
            name30.MouseEnter += OnMouseEnterbio30; name30.MouseLeave += OnMouseLeavebio30;
            time30.MouseEnter += OnMouseEnterbio30; time30.MouseLeave += OnMouseLeavebio30;
            poza30.MouseEnter += OnMouseEnterbio30; poza30.MouseLeave += OnMouseLeavebio30;
            under30.MouseEnter += OnMouseEnterbio30; under30.MouseLeave += OnMouseLeavebio30;


            bio31.MouseEnter += OnMouseEnterbio31; bio31.MouseLeave += OnMouseLeavebio31;
            name31.MouseEnter += OnMouseEnterbio31; name31.MouseLeave += OnMouseLeavebio31;
            time31.MouseEnter += OnMouseEnterbio31; time31.MouseLeave += OnMouseLeavebio31;
            poza31.MouseEnter += OnMouseEnterbio31; poza31.MouseLeave += OnMouseLeavebio31;
            under31.MouseEnter += OnMouseEnterbio31; under31.MouseLeave += OnMouseLeavebio31;


            bio32.MouseEnter += OnMouseEnterbio32; bio32.MouseLeave += OnMouseLeavebio32;
            name32.MouseEnter += OnMouseEnterbio32; name32.MouseLeave += OnMouseLeavebio32;
            time32.MouseEnter += OnMouseEnterbio32; time32.MouseLeave += OnMouseLeavebio32;
            poza32.MouseEnter += OnMouseEnterbio32; poza32.MouseLeave += OnMouseLeavebio32;
            under32.MouseEnter += OnMouseEnterbio32; under32.MouseLeave += OnMouseLeavebio32;


            bio33.MouseEnter += OnMouseEnterbio33; bio33.MouseLeave += OnMouseLeavebio33;
            name33.MouseEnter += OnMouseEnterbio33; name33.MouseLeave += OnMouseLeavebio33;
            time33.MouseEnter += OnMouseEnterbio33; time33.MouseLeave += OnMouseLeavebio33;
            poza33.MouseEnter += OnMouseEnterbio33; poza33.MouseLeave += OnMouseLeavebio33;
            under33.MouseEnter += OnMouseEnterbio33; under33.MouseLeave += OnMouseLeavebio33;


            bio34.MouseEnter += OnMouseEnterbio34; bio34.MouseLeave += OnMouseLeavebio34;
            name34.MouseEnter += OnMouseEnterbio34; name34.MouseLeave += OnMouseLeavebio34;
            time34.MouseEnter += OnMouseEnterbio34; time34.MouseLeave += OnMouseLeavebio34;
            poza34.MouseEnter += OnMouseEnterbio34; poza34.MouseLeave += OnMouseLeavebio34;
            under34.MouseEnter += OnMouseEnterbio34; under34.MouseLeave += OnMouseLeavebio34;


            bio35.MouseEnter += OnMouseEnterbio35; bio35.MouseLeave += OnMouseLeavebio35;
            name35.MouseEnter += OnMouseEnterbio35; name35.MouseLeave += OnMouseLeavebio35;
            time35.MouseEnter += OnMouseEnterbio35; time35.MouseLeave += OnMouseLeavebio35;
            poza35.MouseEnter += OnMouseEnterbio35; poza35.MouseLeave += OnMouseLeavebio35;
            under35.MouseEnter += OnMouseEnterbio35; under35.MouseLeave += OnMouseLeavebio35;


            bio36.MouseEnter += OnMouseEnterbio36; bio36.MouseLeave += OnMouseLeavebio36;
            name36.MouseEnter += OnMouseEnterbio36; name36.MouseLeave += OnMouseLeavebio36;
            time36.MouseEnter += OnMouseEnterbio36; time36.MouseLeave += OnMouseLeavebio36;
            poza36.MouseEnter += OnMouseEnterbio36; poza36.MouseLeave += OnMouseLeavebio36;
            under36.MouseEnter += OnMouseEnterbio36; under36.MouseLeave += OnMouseLeavebio36;



            bio37.MouseEnter += OnMouseEnterbio37; bio37.MouseLeave += OnMouseLeavebio37;
            name37.MouseEnter += OnMouseEnterbio37; name37.MouseLeave += OnMouseLeavebio37;
            time37.MouseEnter += OnMouseEnterbio37; time37.MouseLeave += OnMouseLeavebio37;
            poza37.MouseEnter += OnMouseEnterbio37; poza37.MouseLeave += OnMouseLeavebio37;
            under37.MouseEnter += OnMouseEnterbio37; under37.MouseLeave += OnMouseLeavebio37;

            bio38.MouseEnter += OnMouseEnterbio38; bio38.MouseLeave += OnMouseLeavebio38;
            name38.MouseEnter += OnMouseEnterbio38; name38.MouseLeave += OnMouseLeavebio38;
            time38.MouseEnter += OnMouseEnterbio38; time38.MouseLeave += OnMouseLeavebio38;
            poza38.MouseEnter += OnMouseEnterbio38; poza38.MouseLeave += OnMouseLeavebio38;
            under38.MouseEnter += OnMouseEnterbio38; under38.MouseLeave += OnMouseLeavebio38;



            bio39.MouseEnter += OnMouseEnterbio39; bio39.MouseLeave += OnMouseLeavebio39;
            name39.MouseEnter += OnMouseEnterbio39; name39.MouseLeave += OnMouseLeavebio39;
            time39.MouseEnter += OnMouseEnterbio39; time39.MouseLeave += OnMouseLeavebio39;
            poza39.MouseEnter += OnMouseEnterbio39; poza39.MouseLeave += OnMouseLeavebio39;
            under39.MouseEnter += OnMouseEnterbio39; under39.MouseLeave += OnMouseLeavebio39;

            bio40.MouseEnter += OnMouseEnterbio40; bio40.MouseLeave += OnMouseLeavebio40;
            name40.MouseEnter += OnMouseEnterbio40; name40.MouseLeave += OnMouseLeavebio40;
            time40.MouseEnter += OnMouseEnterbio40; time40.MouseLeave += OnMouseLeavebio40;
            poza40.MouseEnter += OnMouseEnterbio40; poza40.MouseLeave += OnMouseLeavebio40;
            under40.MouseEnter += OnMouseEnterbio40; under40.MouseLeave += OnMouseLeavebio40;

            bio41.MouseEnter += OnMouseEnterbio41; bio41.MouseLeave += OnMouseLeavebio41;
            name41.MouseEnter += OnMouseEnterbio41; name41.MouseLeave += OnMouseLeavebio41;
            time41.MouseEnter += OnMouseEnterbio41; time41.MouseLeave += OnMouseLeavebio41;
            poza41.MouseEnter += OnMouseEnterbio41; poza41.MouseLeave += OnMouseLeavebio41;
            under41.MouseEnter += OnMouseEnterbio41; under41.MouseLeave += OnMouseLeavebio41;


            bio42.MouseEnter += OnMouseEnterbio42; bio42.MouseLeave += OnMouseLeavebio42;
            name42.MouseEnter += OnMouseEnterbio42; name42.MouseLeave += OnMouseLeavebio42;
            time42.MouseEnter += OnMouseEnterbio42; time42.MouseLeave += OnMouseLeavebio42;
            poza42.MouseEnter += OnMouseEnterbio42; poza42.MouseLeave += OnMouseLeavebio42;
            under42.MouseEnter += OnMouseEnterbio42;under42.MouseLeave += OnMouseLeavebio42;



            interogatoriu.ForeColor = Color.White;
            DA.ForeColor = NU.ForeColor = Color.White;
            DA.MouseEnter += OnMouseEnterDA; DA.MouseLeave += OnMouseLeaveDA;
            NU.MouseEnter += OnMouseEnterNU; NU.MouseLeave += OnMouseLeaveNU;


            SC1.Font = E1.Font = T1.Font = S1.Font = new Font("Microsoft Sans Serif", 20);

            E1.MouseEnter += OnMouseEnterE1; E1.MouseLeave += OnMouseLeaveE1;
            T1.MouseEnter += OnMouseEnterT1; T1.MouseLeave += OnMouseLeaveT1;
            S1.MouseEnter += OnMouseEnterS1; S1.MouseLeave += OnMouseLeaveS1;
            SC1.MouseEnter += OnMouseEnterSC1;SC1.MouseLeave += OnMouseLeaveSC1;

            play_stop.BackgroundImage = Properties.Resources.pauza_video;
            describtion.Text = "Întrerupe"; describtion.Visible = false;

            WindowsMediaPlayer.settings.volume = guna2TrackBar2.Value = 100;
            speaker.BackgroundImage = Properties.Resources.speaker_volume;

            tbn.BackColor = Color.White;

            pna.Visible = true;
            pnb.Visible = false;
         

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


        private void OnMouseEnterSC1(object sender, EventArgs e)
        {
            SC1.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Underline);


        }
        private void OnMouseLeaveSC1(object sender, EventArgs e)
        {
            SC1.Font = new Font("Microsoft Sans Serif", 20);


        }

        private void cauta_pers_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer.Ctlcontrols.stop();
            pnb.Visible = false;
            Descriere1.Visible = poza_mare.Visible = title.Visible = cauta_pers.Visible = false;
            pna.AutoScroll = false;
            E2.Visible = SC2.Visible = S2.Visible = T2.Visible = bio1.Visible = bio2.Visible = bio3.Visible = bio4.Visible = bio5.Visible = bio6.Visible = bio7.Visible = bio8.Visible = bio9.Visible = bio10.Visible = bio11.Visible = bio12.Visible = bio13.Visible = bio14.Visible = bio15.Visible = bio16.Visible = bio17.Visible = bio18.Visible = bio19.Visible = bio20.Visible = bio21.Visible = bio22.Visible = bio23.Visible = bio24.Visible = bio25.Visible = bio26.Visible = bio27.Visible = bio28.Visible = bio29.Visible = bio30.Visible = bio31.Visible = bio32.Visible = bio33.Visible = bio34.Visible = bio35.Visible = bio36.Visible = bio37.Visible = bio38.Visible = bio39.Visible = bio40.Visible = bio41.Visible = bio42.Visible = label1.Visible = true;

            title.Visible = false;
            pna.AutoScroll = true;
        }




        private void OnMouseEnterplay_stop(object sender, EventArgs e)
        {
            describtion.Visible = true;

        }

        private void OnMouseLeaveplay_stop(object sender, EventArgs e)
        {
            describtion.Visible = false;
        }

        void navigare()
        {
            describtion.Visible = false;
            stanga_output.Visible = false;
            TAB1.Visible = TAB2.Visible = true;
      
            pnb.Visible = true;
            Descriere1.Visible = poza_mare.Visible = title.Visible = cauta_pers.Visible = true;
            pna.AutoScroll = false;
            E2.Visible = SC2.Visible = S2.Visible = T2.Visible = bio1.Visible = bio2.Visible = bio3.Visible = bio4.Visible = bio5.Visible = bio6.Visible = bio7.Visible = bio8.Visible = bio9.Visible = bio10.Visible = bio11.Visible = bio12.Visible = bio13.Visible = bio14.Visible = bio15.Visible = bio16.Visible = bio17.Visible = bio18.Visible = bio19.Visible = bio20.Visible = bio21.Visible = bio22.Visible = bio23.Visible = bio24.Visible = bio25.Visible = bio26.Visible = bio27.Visible = bio28.Visible = bio29.Visible = bio30.Visible = bio31.Visible = bio32.Visible = bio33.Visible = bio34.Visible = bio35.Visible = bio36.Visible = bio37.Visible = bio38.Visible = bio39.Visible = bio40.Visible = bio41.Visible = bio42.Visible = label1.Visible = false;

            title.Visible = true;
            studio.Visible = false;

            tbn.Visible = ytb.Visible = true;
            Prev1.Visible = Prev2.Visible = Next1.Visible = Next2.Visible = true;

            Descriere2.Text = "";
            if (nr == 1)
            {
                Prev1.Visible = Prev2.Visible = false;
                Next1.Text = Environment.NewLine + name2.Text; Next2.Text = time2.Text;
              //  WindowsMediaPlayer.URL = "D:/biografii/c1.mp4";
                title.Text = name1.Text + Environment.NewLine + "~" + time1.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q1;
                Descriere1.Text = "  Abraham Lincoln a fost un avocat și om politic american, al șaisprezecelea președinte al Statelor Unite ale Americii, funcție pe care a exercitat-o începând cu luna martie 1861 și până la asasinarea sa în aprilie 1865. Lincoln a condus Statele Unite în timpul Războiului Civil—cel mai sângeros conflict al său, dar și cea mai mare criză morală, constituțională și politică. Prin aceasta, el a conservat Uniunea, a abolit sclavia, a întărit guvernul federal și a modernizat economia. Crescut într-o familie săracă de la Frontiera de vest, Lincoln a fost avocat autodidact în Illinois, lider al Partidului Whig, membru al Camerei Reprezentanților la nivel de stat în anii 1830, apoi congressman federal pentru un mandat în anii 1840. A promovat modernizarea rapidă a economiei prin dezvoltarea sistemului bancar, construcția de canale și căi ferate, și prin impunerea de taxe vamale care să protejeze și să încurajeze construcția de fabrici; s-a opus războiului cu Mexicul în 1846. După o serie de dezbateri intens mediatizate⁠ din 1858, în cadrul cărora Lincoln s-a pronunțat împotriva extinderii sclaviei, a pierdut cursa pentru Senatul SUA în fața arhirivalului său, democratul Stephen A. Douglas.În 1860, Lincoln și-a asigurat candidatura din";
                Descriere2.Text="partea Partidului Republican la președinția SUA, fiind recomandat de faptul că era un moderat dintr - un stat în care rezultatul alegerilor nu era cert. Deși avea foarte puțină susținere în statele în care era permisă sclavia, Lincoln a câștigat lejer în Nord și a fost ales președinte în 1860.Alegerea sa a determinat șapte state sclavagiste din Sud să își declare despărțirea de SUA și să formeze Confederația înainte ca el să preia funcția. Nu s-a găsit niciun compromis sau reconciliere în ce privește sclavia.";

            }
            else if (nr == 2)
            {
                Prev1.Text = Environment.NewLine + name1.Text; Prev2.Text = time1.Text;
                Next1.Text = Environment.NewLine + name3.Text; Next2.Text = time3.Text;
                //WindowsMediaPlayer.URL = "D:/biografii/c2.mp4";
                title.Text = name2.Text + Environment.NewLine + "~" + time2.Text + "~";
                poza_mare.BackgroundImage =  Properties.Resources.q2;
                Descriere1.Text = "Bismarck s-a născut în Schönhausen, în vechea provincie numită „Marca Brandenburg” (Mark Brandenburg), la vest de Berlin. Tatăl său, Ferdinand von Bismarck, era ofițer militar, iar mama sa Wilhelmine Menken provenea dintr-o familie burgheză. Otto von Bismarck a avut mai multi frați, dintre care au supraviețuit până la maturitate doar doi, un frate mai mare și sora mai mică.Educația școlară și - a început - o în școala gimnazială Friedrich -Wilhelm și apoi la liceul umanist Graues Kloster(Mănăstirea Albastră).La vârsta de șaptesprezece ani devine student la Universitatea Georg - August din Göttingen, iar apoi la Universitatea Friedrich -Wilhelm din Berlin. Deși dorea să devină diplomat, a reușit să obțină doar poziții administrative minore în Aachen și Potsdam. Munca depusă în cadrul acestor servicii îi părea plictisitoare și monotonă, drept pentru care deseori neglija îndatoririle sale oficiale, preferând în schimb să se amestece în înalta societate. După moartea mamei sale în 1839, Bismarck preia proprietățile familiei din Pomerania. Circa opt ani mai târziu se întoarce în Schönhausen, unde se implică în politica locală. Se însoară cu aristocrata Johanna von Puttkamer în 1847, cu care a avut o fiică(Marie) și doi ";
                Descriere2.Text="fii(Herbert și Wilhelm).";

            }
            else if (nr == 3)
            {
                Prev1.Text = Environment.NewLine + name2.Text; Prev2.Text = time2.Text;
                Next1.Text = Environment.NewLine + name4.Text; Next2.Text = time4.Text;
              //  WindowsMediaPlayer.URL = "D:/biografii/c3.mp4";
                title.Text = name3.Text + Environment.NewLine + "~" + time3.Text + "~";
                poza_mare.BackgroundImage =  Properties.Resources.q3;
                Descriere1.Text = "  S-a născut la Iași, în familia boierilor moldoveni Kogălniceanu, fiind fiul Vornicului Ilie Kogălniceanu și strănepotul lui Constantin Kogălniceanu (cunoscut pentru că a semnat în anul 1749 documentul prin care a fost desființată iobăgia în Moldova, emis de Prințul Constantin Mavrocordat). Mama lui Mihail, Catinca (născută Stavilla – sau Stavillă), a fost, conform spuselor lui Kogălniceanu, „dintr-o familie românească din Basarabia”. Deși Kogălniceanu a scris, la un moment dat, cu mândrie că „familia mea nu și-a avut originile în oameni sau țări străine”., într-un discurs susținut cu ceva timp înainte de moartea sa, Kogălniceanu a afirmat că mama sa Catinca Stavilla a fost descendentă „a unei familii genoveze, stabilită de secole în colonia Genoveză a Cetății Albe (Akerman), care s-a răspândit în toată Basarabia”.";

            }
            else if (nr == 4)
            {
                Prev1.Text = Environment.NewLine + name3.Text; Prev2.Text = time3.Text;
                Next1.Text = Environment.NewLine + name5.Text; Next2.Text = time5.Text;
               // WindowsMediaPlayer.URL = "D:/biografii/c4.mp4";
                title.Text = name4.Text + Environment.NewLine + "~" + time4.Text + "~";
                 poza_mare.BackgroundImage = Properties.Resources.q4;
                Descriere1.Text = "  Alexandru Ioan Cuza s-a născut la Bârlad, fiind fiul ispravnicului Ioan Cuza, proprietar de pământ în județul Fălciu, și al Sultanei (sau Soltana), membră a familiei de origini fanariote Cozadini.Aparținând clasei tradiționale de boieri din Moldova, Alexandru primește o educație europeană și devine ofițer în armata moldovenească, ajungând la rangul de colonel.S - a căsătorit cu Elena Rosetti în 1844.În anul 1848, precum majoritatea statelor europene, Moldova și Țara Românească au fost cuprinse de febra revoluțiilor. Revolta moldovenilor a fost suprimată repede, dar în Țara Românească revoluționarii au preluat puterea și au guvernat în timpul verii. Tânărul Cuza a participat activ la mișcarea revoluționară de la 1848 din Moldova și la lupta pentru unirea Principatelor. Urmare înclinațiilor liberale manifestate în timpul episodului moldovenesc, este transportat ca prizonier la Viena, de aici fiind eliberat cu ajutor britanic.Revenind în Moldova în timpul domniei Prințului Grigore Alexandru Ghica, a fost numit ministru de război(1858) și a reprezentat orașul Galați în divanul ad-hoc de la Iași.Prin toată activitatea sa politică, Alexandru Ioan Cuza a susținut continuu unirea Moldovei și Țării Românești.";

            }
            else if (nr == 5)
            {
                Prev1.Text = Environment.NewLine + name4.Text; Prev2.Text = time4.Text;
                Next1.Text = Environment.NewLine + name6.Text; Next2.Text = time6.Text;
             //   WindowsMediaPlayer.URL = "D:/biografii/c5.mp4";
                title.Text = name5.Text + Environment.NewLine + "~" + time5.Text + "~";
                 poza_mare.BackgroundImage = Properties.Resources.q5;
                Descriere1.Text = "  Victor Babeș s-a născut în 1854 la Viena. A fost fiul deputatului Vincențiu Babeș, originar din Banat, și al Sophiei Goldschneider, descendenta unei influente familii vieneze. Victor Babeș a obținut bacalaureatul la Gimnaziul Catolic din Budapesta, după care a studiat medicina la Universitatea din Budapesta, apoi la Viena, unde și-a luat doctoratul.Babeș își începe cariera științifică în Budapesta ca asistent în laboratorul de anatomie patologică(1874 - 1881). În urma descoperirilor lui Louis Pasteur, este atras de microbiologie și pleacă la Paris unde lucrează un timp în laboratorul lui Pasteur, apoi cu Victor Cornil. Împreună cu acesta publică primul tratat de bacteriologie intitulat Les bactéries et leur rôle dans l'anatomie et l'histologie pathologiques des maladies infectieuses(1885).În anii 1885 - 1886 lucrează în Berlin în laboratoarele lui Rudolf Virchow și Robert Koch.În 1881 primește titlul de conferențiar(docent privat) iar în 1885 postul de profesor asociat de Histopatologie la Universitatea din Budapesta.În 1887 a fost chemat la București ca profesor la catedra de Anatomie Patologică și Bacteriologie.";

            }
            else if (nr == 6)
            {
                Prev1.Text = Environment.NewLine + name5.Text; Prev2.Text = time5.Text;
                Next1.Text = Environment.NewLine + name7.Text; Next2.Text = time7.Text;
               // WindowsMediaPlayer.URL = "D:/biografii/c6.mp4";
                title.Text = name6.Text + Environment.NewLine + "~" + time6.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q6;
                Descriere1.Text = "  Educat la Academia Mihăileană, și-a continuat studiile în Germania, unde a luat parte la mișcările politice ale vremii. Ulterior, a devenit secretar particular al lui Alexandru Ioan Cuza. După aceea, s-a întors împotriva lui Cuza, fiind un lider al Coaliției Monstruoase, devenind membru în guvernul liberal al lui Ion Brătianu.În 1892 a fost ales lider al partidului ca succesor al lui Dumitru Brătianu. În această calitate a fost ales de patru ori prim-ministru.Deși un om cu mare capacitate de muncă, era reprezentantul al celui mai strâmt naționalism și disprețuia tot ce era „străin”, făcând astfel foarte mult pentru a întârzia dezvoltarea politică și industrială a țării sale.A fost numit secretar permanent al Academiei Române, devenind o autoritate recunoscută în numismatica românească. Ca secretar al academiei, a asistat publicarea colecțiilor de documente istorice făcute de Constantin Hurmuzachi(30 de volume, București, 1876 - 1897), precum și alte acte și documente în afară de pamflete politice minore.";
            }
            else if (nr == 7)
            {
                Prev1.Text = Environment.NewLine + name6.Text; Prev2.Text = time6.Text;
                Next1.Text = Environment.NewLine + name8.Text; Next2.Text = time8.Text;
               // WindowsMediaPlayer.URL = "D:/biografii/c7.mp4";
                title.Text = name7.Text + Environment.NewLine + "~" + time7.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q7;
                Descriere1.Text = "  A urmat cursurile Facultatea de Medicină din Paris, pe care o absolvă în februarie 1853. A sosit în Țara Românească în data de 13 martie 1853, la nici 25 de ani, după ce și-a dat doctoratul la Paris și după ce a ajutat la stingerea epidemiei de holeră din 1849, în Champagne și Cher. Ar fi trebuit să stea în Țara Românească doar 3 ani, dar a rămas până la sfârșitul vieții sale. A venit încă din 1853 în București, invitat fiind de domnul Barbu Știrbei pentru a organiza serviciul sanitar. A contribuit fundamental la organizarea învățământului medical din România. A fost profesor de chimie la Universitatea din București. În 1860 a fost ridicat la rangul de general. A organizat serviciul românesc de ambulanțe, care s-a distins apoi în timpul Războiului de Independență.A modelat viața medicală sub trei domnitori, dintre care doi i-au devenit prieteni. În București, la sosire, l - a impresionat pe domnitorul Barbu Știrbei când s - a prezentat după trei zile cu rezultatele unei prime inspecții sanitare și cu proiecte de reformă.Al doilea domnitor pe care l-a câștigat Davila de partea lui a fost Alexandru Ioan Cuza. Azilului său de orfane, întemeiat la București, i-a dat numele de Elena Doamna, după soția lui Cuza. De acest azil s-a ocupat îndeaproape";
                Descriere2.Text="și Regina Elisabeta.Al treilea domnitor a fost Carol, sub a cărui protecție și-a desăvârșit în cea mai mare măsură opera.";

            }
            else if (nr == 8)
            {
                Prev1.Text = Environment.NewLine + name7.Text; Prev2.Text = time7.Text;
                Next1.Text = Environment.NewLine + name9.Text; Next2.Text = time9.Text;
             //   WindowsMediaPlayer.URL = "D:/biografii/c8.mp4";
                title.Text = name8.Text + Environment.NewLine + "~" + time8.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q8;
                Descriere1.Text = "  Nicolae Minovici s-a născut la 23 octombrie 1868, la Râmnicu Sărat, fiind cel de-al şaptelea copil al familiei lui Ştefan Minovici, un negustor de vite, şi al Sofiei Minovici, originară din Brăila. Interesant este faptul că bunicul său, Ştefan Mina, provenea din Tetovo, oraş din Macedonia, şi a ajuns în Ţara Românească, dorindu-şi să-şi schimbe destinul, însă aici i se schimbă şi numele, din Mina în Minovici." + Environment.NewLine + "  În anul 1891, după absolvirea bacalaureatului, s-a înscris la Şcoala de Belle-Arte, cursuri pe care le-a frecventat timp de un an. Apoi, sub influenţa fratelui său mai mare, Mina, se înscrie la Facultatea de Medicină, însă pasiunea pentru artă avea să-i rămână pentru tot restul vieţii.În anul 1896, Nicolae Minovici a reușit identificarea autorului unui furt săvârșit într-o tipografie cu ajutorul urmelor lăsate de mâini, momentul marcând debutul, în ţara noastră, identificării unui infractor pe baza urmelor digitale." + Environment.NewLine + "  În anul 1898, Nicolae Minovici obţine titlul de doctor în medicină, cu lucrarea „Tatuajele în România”, fiind pentru prima dată în România când această temă era abordată. Pentru realizarea lucrării, el a studiat nu mai puţin de 15.000 de ";
                Descriere2.Text = "tatuaje de pe cadavrele de la Institutul de Medicină Legală.în anul 1904, a publicat lucrarea un „Studiu asupra spânzurării”, o lucrare unică în medicina românească. Nicolae Minovici s-a remarcat prin modul în care a experimentat pe propria persoană efectele autostrangulării, în contextul în care, moartea prin spânzurare era foarte comună în Europa acelor ani."+Environment.NewLine+"  În 28 iulie 1906, a înfiinţat prima Societate de Salvare din Balcani, după modelul celei care fusese creată la Viena. În contextul în care, la vremea aceea, în Capitală existau doar două căruţe care se ocupau de transportul celor care aveau probleme de sănătate, profesorul punea în circulaţie prima ambulanţă a Societăţii de Salvare Bucureşti, care funcţiona cu personal medical, pe bază de voluntariat.";
            }
            else if (nr == 9)
            {
                Prev1.Text = Environment.NewLine + name8.Text; Prev2.Text = time8.Text;
                Next1.Text = Environment.NewLine + name10.Text; Next2.Text = time10.Text;
             //   WindowsMediaPlayer.URL = "D:/biografii/c9.mp4";
                title.Text = name9.Text + Environment.NewLine + "~" + time9.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q9;
                Descriere1.Text = "  Nikola Tesla  a fost un inventator, fizician, inginer mecanic, inginer electrician și unul dintre promotorii cei mai importanți ai electricității comerciale. Tesla este considerat ca fiind un important om de știință al sfârșitului de secol XIX și începutului de secol XX. Invențiile, precum și munca teoretică ale lui Tesla au pus bazele cunoștințelor moderne despre curentul alternativ, puterea electrică, sistemele de curent alternativ, incluzând sistemele polifazice, sistemele de distribuție a puterii și motorul pe curent alternativ, care au determinat cea de-a doua Revoluție Industrială.Amprenta lui Tesla poate fi observată în civilizația modernă oriunde este folosită electricitatea. Pe lângă descoperirile sale despre electromagnetism și inginerie, Tesla este considerat un pionier în domeniile roboticii, balisticii, științei calculatoarelor, fizicii nucleare și fizicii teoretice. Nikola Tesla considera cercetarea diferitelor întrebări ridicate de către știință drept cea mai nobilă metodă de îmbunătățire a condiției umane cu ajutorul principiilor științei și progresului industrial și una care să fie compatibilă cu natura.Cu numele său este denumită unitatea de măsură a inducției magnetice din Sistemul Internațional (1 Tesla = 1T).";

            }
            else if (nr == 10)
            {
                Prev1.Text = Environment.NewLine + name9.Text; Prev2.Text = time9.Text;
                Next1.Text = Environment.NewLine + name11.Text; Next2.Text = time11.Text;
              //  WindowsMediaPlayer.URL = "D:/biografii/c10.mp4";
                title.Text = name10.Text + Environment.NewLine + "~" + time10.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q10;
                Descriere1.Text = "  Marie Curie a fost o savantă poloneză stabilită în Franța, dublu laureată a Premiului Nobel. A fost singura savantă care a primit două premii Nobel în două domenii științifice diferite (fizică și chimie). A introdus în fizică termenul de radioactivitate. Este cunoscută pentru cercetările sale în domeniul elementelor radioactive, al radioactivității naturale și al aplicațiilor acestora în medicină. A fost soția unui laureat al Premiului Nobel, fizicianul Pierre Curie, și mama unei laureate a Premiului Nobel (Irène Joliot-Curie).Cu excepția fiicei sale Ève Curie (scriitoare), toți descendenții săi vor urma cariere științifice.Publicația Time a considerat-o una dintre cele mai influente savante ale secolului al XX-lea.";

            }
            else if (nr == 11)
            {
                Prev1.Text = Environment.NewLine + name10.Text; Prev2.Text = time10.Text;
                Next1.Text = Environment.NewLine + name12.Text; Next2.Text = time12.Text;
             //   WindowsMediaPlayer.URL = "D:/biografii/c11.mp4";
                title.Text = name11.Text + Environment.NewLine + "~" + time11.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q11;
                Descriere1.Text = "  Henri Coandă s-a născut în București, la 7 iunie 1886, fiind al doilea copil al unei familii numeroase. Tatăl lui a fost generalul Constantin Coandă, fost profesor de matematică la Școala națională de poduri și șosele din București și fost prim-ministru al României pentru o scurtă perioadă de timp, în 1918. Mama sa, Aida Danet, a fost fiica medicului francez Gustave Danet, originar din Bretania (Morlaix,Finistère).Încă din copilărie viitorul inginer și fizician era fascinat de miracolul vântului, după își va și aminti mai târziu. Henri Coandă a fost mai întâi elev al Școlii Petrache Poenaru din București, apoi al Liceului Sf. Sava 1896 unde a urmat primele 3 clase, după care, la 13 ani, a fost trimis de tatăl său, care voia să-l îndrume spre cariera militară, la Liceul Militar din Iași 1899.Termină liceul în 1903 primind gradul de sergent major și își continuă studiile la Școala de ofițeri de artilerie, geniu și marină din București.Detașat la un regiment de artilerie de câmp din Germania 1904, este trimis la Technische Hochschule (Universitatea Tehnică) din Berlin-Charlottenburg. Pasionat de probleme tehnice și mai ales de tehnica aviaticii, în 1905 Coandă construiește un avion-rachetă pentru armata română. Între 1907-1908 a urmat de asemenea";
                Descriere2.Text="cursuri universitare în Belgia, la Liège, și la Institutul tehnic Montefiore.";

            }
            else if (nr == 12)
            {
                Prev1.Text = Environment.NewLine + name11.Text; Prev2.Text = time11.Text;
                Next1.Text = Environment.NewLine + name13.Text; Next2.Text = time13.Text;
             //   WindowsMediaPlayer.URL = "D:/biografii/c12.mp4";
                title.Text = name12.Text + Environment.NewLine + "~" + time12.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q12;
                Descriere1.Text = "  Carol I al României a fost domnitorul, apoi regele României, care a condus Principatele Române și apoi România după abdicarea forțată a lui Alexandru Ioan Cuza în urma unei lovituri de stat.Din 1867 a devenit membru de onoare al Academiei Române, iar între 1879 și 1914 a fost protector și președinte de onoare al aceleiași instituții.În cei 48 de ani de domnie (cea mai lungă din istoria statelor românești), Carol I a obținut independența țării, datorită căreia i-a și crescut imens prestigiul, a redresat economia, a dotat România cu o serie de instituții specifice statului modern și a pus bazele unei dinastii. A construit în Munții Carpați Castelul Peleș, care a rămas și acum una dintre cele mai vizitate atracții turistice ale țării. După războiul ruso-turc (1877-1878), România a câștigat Dobrogea (dar a pierdut sudul Basarabiei), iar Carol a dispus ridicarea podului peste Dunăre, între Fetești și Cernavodă, care să lege noua provincie de restul țării.";

            }
            else if (nr == 13)
            {
                Prev1.Text = Environment.NewLine + name12.Text; Prev2.Text = time12.Text;
                Next1.Text = Environment.NewLine + name14.Text; Next2.Text = time14.Text;
              //  WindowsMediaPlayer.URL = "D:/biografii/c13.mp4";
                title.Text = name13.Text + Environment.NewLine + "~" + time13.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q13;
                Descriere1.Text = "  În contextul politic creat de moartea regelui Ferdinand și cea a lui Ion I.C Brătianu, cât și de lipsa de fermitate a regenței conduse de principele Nicolae, Carol s-a întors, în 1930, în România, detronându-și propriul fiu. Domnia lui a fost marcată la început de efectele marii crize economice și financiare. Carol a fragilizat sistemul de partide, numind adesea la guvernare facțiuni minoritare ale partidelor istorice și cochetând cu idea unor guverne de concentrație națională, precum guvernul Iorga-Argetoianu. De asemenea, a permis formarea unei camarile corupte în jurul său, sub patronajul Elenei Lupescu. Către sfârșitul anilor '30, situația politică internă s-a deteriorat sub influența situației internaționale și a acțiunilor regelui, în 1938 fiind instaurată dictatura regală (prin înlăturarea constituției din 1923 și desființarea partidelor politice, înlocuite cu un partid unic, Frontul Renașterii Naționale, patronat de rege).Anul 1940 a consemnat fărâmițarea României Mari ca urmare a pactului dintre Germania și URSS, situație care a avut efecte dezastruoase asupra reputației monarhului român. Reorientarea politicii externe a României către Germania nazistă nu a putut salva regimul lui Carol, care a fost obligat să abdice de către generalul";
                Descriere2.Text="Ion Antonescu, proaspăt numit de el prim - ministru.";

            }
            else if (nr == 14)
            {
                Prev1.Text = Environment.NewLine + name13.Text; Prev2.Text = time13.Text;
                Next1.Text = Environment.NewLine + name15.Text; Next2.Text = time15.Text;
              //  WindowsMediaPlayer.URL = "D:/biografii/c14.mp4";
                title.Text = name14.Text + Environment.NewLine + "~" + time14.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q14;
                Descriere1.Text = "  Educat la Academia Mihăileană, și-a continuat studiile în Germania, unde a luat parte la mișcările politice ale vremii. Ulterior, a devenit secretar particular al lui Alexandru Ioan Cuza. După aceea, s-a întors împotriva lui Cuza, fiind un lider al Coaliției Monstruoase, devenind membru în guvernul liberal al lui Ion Brătianu.În 1892 a fost ales lider al partidului ca succesor al lui Dumitru Brătianu. În această calitate a fost ales de patru ori prim-ministru.Deși un om cu mare capacitate de muncă, era reprezentantul al celui mai strâmt naționalism și disprețuia tot ce era „străin”, făcând astfel foarte mult pentru a întârzia dezvoltarea politică și industrială a țării sale.A fost numit secretar permanent al Academiei Române, devenind o autoritate recunoscută în numismatica românească. Ca secretar al academiei, a asistat publicarea colecțiilor de documente istorice făcute de Constantin Hurmuzachi(30 de volume, București, 1876 - 1897), precum și alte acte și documente în afară de pamflete politice minore.";

            }
            else if (nr == 15)
            {
                Prev1.Text = Environment.NewLine + name14.Text; Prev2.Text = time14.Text;
                Next1.Text = Environment.NewLine + name16.Text; Next2.Text = time16.Text;
              //  WindowsMediaPlayer.URL = "D:/biografii/c15.mp4";
                title.Text = name15.Text + Environment.NewLine + "~" + time15.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q15;
                Descriere1.Text = "  S-a căsătorit la 29 decembrie 1892 cu Ferdinand I, Principele moștenitor al tronului României, încercând încă de la început și reușind să se integreze națiunii care o adoptase ca Principesă și, începând din 1914, ca Regină.A urmărit constant întărirea legăturilor dintre România și Marea Britanie, dovedind reale calități diplomatice în susținerea și apărarea intereselor României.S - a opus intrării României în Primul Război Mondial de partea Puterilor Centrale și a susținut alianța cu Antanta, în vederea susținerii de către aceasta a realizării statului național român.Pe timpul războiului și-a acompaniat soțul în refugiu în Moldova, activând ca soră de caritate în spitalele militare, activitate care a făcut să fie numită în popor „mama răniților”.După moartea Regelui Ferdinand și venirea la putere a fiului său, Carol al II - lea(1930), acesta a reușit îndepărtarea Reginei Maria din viața politică, obligând - o practic să trăiască într-un soi de exil intern la reședințele sale de la Balcic și Bran.";
            }
            else if (nr == 16)
            {
                Prev1.Text = Environment.NewLine + name15.Text; Prev2.Text = time15.Text;
                Next1.Text = Environment.NewLine + name17.Text; Next2.Text = time17.Text;
            //    WindowsMediaPlayer.URL = "D:/biografii/c16.mp4";
                title.Text = name16.Text + Environment.NewLine + "~" + time16.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q16;
                Descriere1.Text = "  Vladimir Lenin s-a născut Vladimir Ilich Ulyanov în 1870 într-o familie de clasă mijlocie din Ulyanovsk, Rusia. Fiul lui Ilya Ulyanov și al Mariei Alexandrovna Ulyanova, el era al treilea dintre cei șase frați dintr-o familie educată și avea să devină primul din clasa sa la liceu. Dar tocmai mediul lor educațional a făcut din familie o țintă a guvernului; tatăl său, inspector al școlilor, a fost amenințat cu pensionare anticipată de oficiali care se îngrijesc de educația publică. În adolescență, Lenin s-a radicalizat politic după ce fratele său mai mare a fost executat în 1887 pentru complotarea asasinării țarului Alexandru al III-lea." + Environment.NewLine + "  Curând a fost arestat pentru activități marxiste și exilat în Siberia. Logodnica și viitoarea sa soție, Nadezhda Krupskaya, i s-au alăturat acolo. Cei doi se vor căsători pe 22 iulie 1898." + Environment.NewLine + "  Ulterior, Lenin s-a mutat în Germania și apoi în Elveția, unde a întâlnit alți marxiști europeni. În acest timp, a adoptat pseudonimul Lenin și a înființat Partidul Bolșevic." + Environment.NewLine + "  Când Lenin s-a întors acasă în Rusia în aprilie 1917, Revoluția Rusă începea";
                Descriere2.Text="deja. Grevele din cauza deficitului de alimente din martie au forțat abdicarea ineptului țar Nicolae al II-lea, punând capăt secolelor de domnie imperială."+Environment.NewLine+ "  Sub comunismul de război, Lenin a naționalizat rapid toate producțiile și industria din Rusia sovietică. El a rechiziționat surplusul de cereale de la fermierii țărani pentru a-și hrăni Armata Roșie.";
            }
            else if (nr == 17)
            {
                Prev1.Text = Environment.NewLine + name16.Text; Prev2.Text = time16.Text;
                Next1.Text = Environment.NewLine + name18.Text; Next2.Text = time18.Text;
              //  WindowsMediaPlayer.URL = "D:/biografii/c17.mp4";
                title.Text = name17.Text + Environment.NewLine + "~" + time17.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q17;
                Descriere1.Text = "  Emil Racoviță și-a petrecut copilăria la Șurănești, la moșia familiei. Și-a început educația la Iași, ca elev al lui Ion Creangă și mai târziu al lui Grigore Cobălcescu, continuând apoi la liceul „Institutele Unite”. Fostul elev al geologului Grigore Cobălcescu studiază la Facultatea de Drept din Paris, după dorința tatălui său, dar audiază concomitent și cursurile Școlii de antropologie. După obținerea cu succes a licenței în drept, se înscrie și la Facultatea de Științe din Universitatea Sorbona, Paris, după absolvirea căreia (1891) lucrează la laboratoarele Arago în cadrul stațiunii de biologie marină de la Banyuls-sur-Mer, unde efectuează o serie de scufundări la adâncimea de 10 m cu un echipament clasic Siebe-Gorman, pentru a studia viața subacvatică. Prezintă teza de doctorat în 1896 cu subiectul Le lobe céphalique et l'encéphale des annélides polychètes.Emil Racoviță înaintea plecării în expediția din Antarctica. La vârsta de numai 25 de ani este ales membru al Societății zoologice din Franța. Este recomandat (1897) să participe ca naturalist al Expediției antarctice belgiene (1897 - 1899) la bordul navei Belgica, condusă de Adrien de Gerlache. Această expediție, care pornește din Anvers în august 1897, avea un caracter internațional, pe lângă belgieni, la ea participând și norvegianul Roald Amundsen ca ofițer secund, medicul american Frederick Cook, meteorologul polonez Antoine Dobrowolski și geologul Henryk Arctowski.";
                Descriere2.Text= "internațional, pe lângă belgieni, la ea participând și norvegianul Roald Amundsen ca ofițer secund, medicul american Frederick Cook, meteorologul polonez Antoine Dobrowolski și geologul Henryk Arctowski."; 

            }
            else if (nr == 18)
            {
                Prev1.Text = Environment.NewLine + name17.Text; Prev2.Text = time17.Text;
                Next1.Text = Environment.NewLine + name19.Text; Next2.Text = time19.Text;
              //  WindowsMediaPlayer.URL = "D:/biografii/c18.mp4";
                title.Text = name18.Text + Environment.NewLine + "~" + time18.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q18;
                Descriere1.Text = "  Albert Einstein a fost un fizician teoretician de etnie evreiască, născut în Germania, apatrid din 1896, elvețian din 1899, emigrat în 1933 în SUA, naturalizat american în 1940, profesor universitar la Berlin și Princeton. A fost autorul teoriei relativității și unul dintre cei mai străluciți oameni de știință ai omenirii.Cele mai multe dintre contribuțiile sale în fizică sunt legate de teoria relativității restrânse (1905), care unesc mecanica cu electromagnetismul, și de teoria relativității generalizate (1915) care extinde principiul relativității mișcării neuniforme, elaborând o nouă teorie a gravitației.Alte contribuții ale sale includ cosmologia relativistă, teoria capilarității, probleme clasice ale mecanicii statistice cu aplicații în mecanica cuantică, explicarea mișcării browniene a moleculelor, probabilitatea tranziției atomice, teoria cuantelor pentru gazul monoatomic, proprietățile termice ale luminii (al căror studiu a condus la elaborarea teoriei fotonice), teoria radiației (ce include emisia stimulată), teoria câmpurilor unitară și geometrizarea fizicii.Cea mai cunoscută formulă a lui Einstein este E = mc² , care cuantifică energia disponibilă a materiei. ";

            }
            else if (nr == 19)
            {
                Prev1.Text = Environment.NewLine + name18.Text; Prev2.Text = time18.Text;
                Next1.Text = Environment.NewLine + name20.Text; Next2.Text = time20.Text;
             //   WindowsMediaPlayer.URL = "D:/biografii/c19.mp4";
                title.Text = name19.Text + Environment.NewLine + "~" + time19.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q19;
                Descriere1.Text = "  Felix Hoffmann a fost un chimist german remarcabil pentru re-sintetizarea diamorfinei, care a fost popularizată sub denumirea comercială Bayer de „heroină”. De asemenea, i se atribuie sinteza aspirinei, deși dacă a făcut acest lucru din proprie inițiativă sau sub instrucțiunea lui Arthur Eichengrün este contestat.";

            }
            else if (nr == 20)
            {
                Prev1.Text = Environment.NewLine + name19.Text; Prev2.Text = time19.Text;
                Next1.Text = Environment.NewLine + name21.Text; Next2.Text = time21.Text;
            //    WindowsMediaPlayer.URL = "D:/biografii/c20.mp4";
                title.Text = name20.Text + Environment.NewLine + "~" + time20.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q20;
                Descriere1.Text = "  Născută în anul 1885 la Diţeşti, în judeţul Prahova, Miţa Biciclista, pe numele ei real Maria Mihăescu s-a dovedit a fi o tânără ambiţioasă care ştia ce vrea.Fiică a unei spălătorese care lucra la un instalator neamţ, tânăra de vreo 14-15 ani a fost remarcată şi luată cu voia ei în începerea „carierei de curtezană”. Devenită o tânără cultă şi învăţată la pension în străinătate, Maria Mihăescu l-a avut ca prim amant pe Regele Leopold al Belgiei. " + Environment.NewLine+ "Ieşea pe străzi de bunăvoie şi îşi alegea singură clienţii, care, de obicei erau persoane cunoscute sau cu mulţi bani.„Era o demimondenă, mă rog, hai să-i spunem în mod vulgar, o curvă de mare lux. Lucru rar la vremea aceea, în anii ‘20, făcea ciclism prin Bucureşti pentru a-şi menţine silueta. Făcuse avere şi una din casele ei era cea în care am locuit noi”, povesteşte istoricul Neagu Djuvara, în cartea „Un secol cu Neagu Djuvara”."+Environment.NewLine+ "  Între cele două veacuri, bicicleta era încă o raritate, iar Miţa a fost prima femeie ce pedala pe marile străzi ale Capitalei. Era o femeie frumoasă, nu prea înaltă, cam de un metru şaizeci, cu părul blond tuns scurt şi cu ochii verzi-albaştri.  Se spune că a fost curtată de bărbaţi celebri precum Nicolae Grigorescu, Octavian Goga şi chiar de Regele Ferdinand despre care se vorbea că i-ar fi făcut cadou casa care se află şi astăzi în apropiere de Piaţa Amzei şi care îi poartă şi numele.Era o femeie avută pentru acea avreme.Deţinea o trăsură, o maşină coupe şi servitori din Polonia.Mânca numai la Athenee Palace şi mergea la cel mai scump coafor de pe Calea Victoriei.A trăit o perioadă la Paris, iar când s-a întors în ţară a continuat să cocheteze cu acel stil de viaţă şi le vorbea tuturor în franceză."+Environment.NewLine+ "  A devenit cunoscută drept Miţa Biciclista prin anul 1898, când a fost văzută de ziaristul George Ranetti plimbându - se cu bicicleta pe Calea Victoriei.Se spunea că acesta era îndrăgostit de ea, dar pentru că îl respingea acesta a poreclit - o „Miţa Biciclista”.";


                Descriere2.Text="Goga şi chiar de Regele Ferdinand despre care se vorbea că i-ar fi făcut cadou casa care se află şi astăzi în apropiere de Piaţa Amzei şi care îi poartă şi numele.Era o femeie avută pentru acea avreme. Deţinea o trăsură, o maşină coupe şi servitori din Polonia. Mânca numai la Athenee Palace şi mergea la cel mai scump coafor de pe Calea Victoriei.A trăit o perioadă la Paris, iar când s-a întors în ţară a continuat să cocheteze cu acel stil de viaţă şi le vorbea tuturor în franceză."+Environment.NewLine+ "  A devenit cunoscută drept Miţa Biciclista prin anul 1898, când a fost văzută de ziaristul George Ranetti plimbându-se cu bicicleta pe Calea Victoriei. Se spunea că acesta era îndrăgostit de ea, dar pentru că îl respingea acesta a poreclit-o „Miţa Biciclista”.";
            
            }
            else if (nr == 21)
            {
                Prev1.Text = Environment.NewLine + name20.Text; Prev2.Text = time20.Text;
                Next1.Text = Environment.NewLine + name22.Text; Next2.Text = time22.Text;
             //   WindowsMediaPlayer.URL = "D:/biografii/c21.mp4";
                title.Text = name21.Text + Environment.NewLine + "~" + time21.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q21;
                Descriere1.Text =  "  Benito Amilcare Andrea Mussolini  a fost conducătorul fascist al Italiei între anii 1922 și 1943. Un socialist Italian celebru, membru marcant al Partidului Socialist Italian a creat un stat fascist utilizând propaganda și teroarea de stat. Folosindu-și carisma, controlul total al mediei și intimidarea rivalilor politici, a ruinat sistemul democratic de guvernare existent. Intrarea sa în cel de-Al Doilea Război Mondial alături de Germania lui Adolf Hitler a făcut din Italia o țintă pentru atacurile Aliaților, ceea ce a dus în final la căderea dictaturii fasciste mussoliniene și moartea lui. În noiembrie 2004 a fost votat al 34-lea mare italian într-un sondaj de opinie TV.";

            }
            else if (nr == 22)
            {
                Prev1.Text = Environment.NewLine + name21.Text; Prev2.Text = time21.Text;
                Next1.Text = Environment.NewLine + name23.Text; Next2.Text = time23.Text;
             //   WindowsMediaPlayer.URL = "D:/biografii/c22.mp4";
                title.Text = name22.Text + Environment.NewLine + "~" + time22.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q22;
                Descriere1.Text = "  Adolf Hitler a fost un politician german de origine austriacă, lider al Partidului Muncitoresc German Național-Socialist (NSDAP), cancelar al Germaniei din 1933, iar din 1934 conducător absolut (Führer) al Germaniei. Ajuns la putere în 1933, Hitler a transformat țara într-o dictatură monopartid bazată pe ideologia totalitaristă și autoritaristă a național-socialismului. Politica sa expansionistă agresivă este considerată principala cauză a izbucnirii celui de-al Doilea Război Mondial, soldat cu pierderi omenești colosale. De numele său sunt legate numeroase crime împotriva umanității, printre care punerea în aplicare a unui plan naționalist și rasist de exterminare în masă a evreilor și altor „indezirabili” din Europa, precum și lichidarea adversarilor politici din Germania. Hitler a fost ales „omul anului” în 1938, de către revista americană Time.";

            }
            else if (nr == 23)
            {
                Prev1.Text = Environment.NewLine + name22.Text; Prev2.Text = time22.Text;
                Next1.Text = Environment.NewLine + name24.Text; Next2.Text = time24.Text;
            //    WindowsMediaPlayer.URL = "D:/biografii/c23.mp4";
                title.Text = name23.Text + Environment.NewLine + "~" + time23.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q23;
                Descriere1.Text = "  Iosif Vissarionovici Stalin din tată gruzin și mamă osetină, a fost un om politic sovietic, fost revoluționar bolșevic devenit după Revoluția din Octombrie conducător politic sovietic. Stalin a devenit Secretar General al Partidului Comunist al Uniunii Sovietice în 1922, în urma morții lui Vladimir Ilici Lenin, câștigând în anii deceniului al treilea lupta pentru putere cu Lev Troțki și consolidându-și pe deplin autoritatea odată cu Marea Epurare, o perioadă de represiune cruntă al cărei apogeu a fost atins în 1937. Stalin a rămas la putere pe tot parcursul celui de-al Doilea Război Mondial, și după încheierea acestuia, până la moartea sa. Din 1946 a deținut și funcția de prim-ministru al Uniunii Sovietice. Ideologia marxist-leninistă ca interpretare a lui Stalin este adeseori numită și stalinism.Sub Stalin, care a înlocuit Noua Politică Economică(NEP) cu planurile cincinale, (introduse în 1928) și agricultura individuală cu agricultura cooperatistă, Uniunea Sovietică a fost transformată dintr - o societate țărănească într - o mare putere industrială mondială la sfârșitul celui de-al patrulea deceniu, țara sa devenind a doua putere economică din lume. Agricultura sovietică, care a fost exploatată pentru finanțarea industrializării, a continuat să fie subdezvoltată pe toată durata deceniului. Colectivizarea a trebuit sa facă față opoziției generalizate a chiaburilor, în fapt, cei mai harnici și gospodari oameni ai satelor, având ca rezultat o luptă înverșunată a multor țărani împotriva autorităților.";

                Descriere2.Text="continuat să fie subdezvoltată pe toată durata deceniului. Colectivizarea a trebuit sa facă față opoziției generalizate a chiaburilor, în fapt, cei mai harnici și gospodari oameni ai satelor, având ca rezultat o luptă înverșunată a multor țărani împotriva autorităților.";

            }
            else if (nr == 24)
            {
                Prev1.Text = Environment.NewLine + name23.Text; Prev2.Text = time23.Text;
                Next1.Text = Environment.NewLine + name25.Text; Next2.Text = time25.Text;
            //    WindowsMediaPlayer.URL = "D:/biografii/c24.mp4";
                title.Text = name24.Text + Environment.NewLine + "~" + time24.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q24;
                Descriere1.Text = "  A fost politician sovietic, mareșal al Uniunii Sovietice și șef al aparatului de securitate sovietic și al poliției secrete(NKVD)."+Environment.NewLine+ "  Beria a fost cel mai longeviv și mai influent șef al poliției secrete staliniste. După invazia sovietică a Poloniei din 1939, el a fost responsabil pentru organizarea masacrului din Katyń (serie de crime în masă a aproximativ 22.000 de ofițeri polonezi și inteligență de către NKVD). Beria a fost responsabil pentru extinderea rețelei extinse a aparatului de represiune sovietic, așa-numitele lagăre Gulag. La momentul invaziei Germaniei în Uniunea Sovietică, Beria a acționat ca un mareșal al Uniunii Sovietice, conducând unități de teren ale NKVD responsabile de sabotaj pe frontul de est. La conferința de la Yalta, Stalin l-a prezentat pe Beria președintelui american Franklin D. Roosevelt drept „Himmler al nostru”. După război, Beria a organizat preluarea de către aparatul sovietic a instituțiilor de stat din Europa de Est și Centrală, precum și aparatul brutal de represiune politică din aceste țări. De asemenea, a supervizat proiectul sovietic al bombei atomice. După moartea lui Stalin, în martie 1953, Beria a devenit vicepremier al Uniunii Sovietice și șef al Ministerului Afacerilor Interne. O lovitură de stat din iunie 1953 l-a îndepărtat de la putere. El a fost acuzat de trădare, condamnat la moarte și executat la 23 decembrie 1953.";

                Descriere2.Text="   O lovitură de stat din iunie 1953 l-a îndepărtat de la putere. El a fost acuzat de trădare, condamnat la moarte și executat la 23 decembrie 1953.";
            
            }
            else if (nr == 25)
            {
                Prev1.Text = Environment.NewLine + name24.Text; Prev2.Text = time24.Text;
                Next1.Text = Environment.NewLine + name26.Text; Next2.Text = time26.Text;
             //   WindowsMediaPlayer.URL = "D:/biografii/c25.mp4";
                title.Text = name25.Text + Environment.NewLine + "~" + time25.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q25;
                Descriere1.Text = "  A fost un politician stalinist și diplomat sovietic, un bolșevic înflăcărat și o figură de frunte în guvernul sovietic încă din anii 1920, când a câștigat puterea ca protejat al lui Iosif Stalin."+Environment.NewLine+ "  Molotov a fost principalul semnatar al pactului nazi-sovietic de neagresiune din 1939 (cunoscut și sub numele de Pactul Molotov) ale cărui dispoziții cele mai importante erau sub forma unui protocol secret care prevedea invazia Poloniei și divizarea Europei de Est-Central între Germania nazistă și Uniunea Sovietică. Molotov știa despre masacrul de la Katyń comis în acel moment de autoritățile sovietice. După cel de-al doilea război mondial, Molotov a fost implicat în negocieri cu aliații occidentali în care a câștigat faima prin abilitățile sale diplomatice. Până la sfârșitul vieții sale, Molotov a fost un fervent comunist și apărător al politicilor și moștenirii lui Stalin împotriva criticilor dure ale succesorilor săi.";
            }
            else if (nr == 26)
            {
                Prev1.Text = Environment.NewLine + name25.Text; Prev2.Text = time25.Text;
                Next1.Text = Environment.NewLine + name27.Text; Next2.Text = time27.Text;
             //   WindowsMediaPlayer.URL = "D:/biografii/c26.mp4";
                title.Text = name26.Text + Environment.NewLine + "~" + time26.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q26;
                Descriere1.Text = "   A fost un politician, ofițer și scriitor britanic. A fost prim-ministru al Marii Britanii în 1940-1945, când a condus-o la victorie în cel de-al doilea război mondial și din nou în 1951-1955." + Environment.NewLine + "  Cea mai mare parte a carierei sale a fost membru al Partidului Conservator, pe care l-a condus în 1940-1955. În 1895, Churchill s-a alăturat armatei britanice și a luat parte la acțiuni în India, războiul englez-sudanez și al doilea război boer, câștigând faima ca corespondent de război neînfricat. Istoria îl amintește pe Churchill ca un lider de război victorios, un adversar acerb al lui Adolf Hitler, campion al luptei până la capăt și al victoriei cu orice preț. El a fost un orator excelent și discursurile sale aprinse au susținut spiritul de luptă dintre conaționali. Discursul său inaugural în Camera Comunelor a definit ceea ce aștepta Marea Britanie în război: „Vreau să spun Camerei, așa cum le-am spus miniștrilor care vin în acest guvern: nu pot decât să vă promit sânge, roi, lacrimi și sudoare” . În 1953, Churchill a primit Premiul Nobel pentru literatură. La rândul său, opiniile sale imperialiste cu privire la problemele rasiale și toleranța la încălcarea drepturilor omului în calificarea mișcărilor de eliberare din țările care ";
                Descriere2.Text="doreau independența față de Imperiul Britanic au stârnit mari controverse. Winston Churchill este de obicei considerat a fi cel mai remarcabil prim-ministru al Marii Britanii și una dintre cele mai importante figuri ale secolului XX."+Environment.NewLine+" Tot Churchill a anticipat tensiunile dintre Est si Vest,ba chiar este cel care a adus metafora de „Cortina de Fier”";
            }
            else if (nr == 27)
            {
                Prev1.Text = Environment.NewLine + name26.Text; Prev2.Text = time26.Text;
                Next1.Text = Environment.NewLine + name28.Text; Next2.Text = time28.Text;
              //  WindowsMediaPlayer.URL = "D:/biografii/c27.mp4";
                title.Text = name27.Text + Environment.NewLine + "~" + time27.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q27;
                Descriere1.Text = "George al VI-lea a fost rege al Marii Britanii, al Irlandei și al altor dominioane britanice, împărat al Indiei din 11 decembrie 1936 până la decesul său din 6 februarie 1952.A fost cunoscut înainte de încoronare ca prințul Albert, în copilărie prinț de York, și mai târziu ducele Albert de York, iar în cercul familiei era chemat „Bertie”. Își datora numele de Albert faptului că s-a născut la 14 decembrie, ziua comemorării decesului Prințului Consort Albert, soțul reginei Victoria. Fiind cel de - al doilea fiu al regelui George al V - lea și - a petrecut primii ani în umbra fratelui său mai mare, Eduard, moștenitorul tronului. A servit în Marina Militară Regală în timpul primului război mondial și după război, a avut o serie de angajamente publice. S - a căsătorit cu Elizabeth Bowes-Lyon, în 1923, și au avut două fiice, Elizabeth(viitoarea regină Elisabeta a II - a) și Margaret.La moartea tatălui său în 1936, Eduard al VIII - lea preia tronul englez.Totuși, în mai puțin de un an, Eduard își exprimă dorința de a se căsători cu americana Wallis Simpson.Din motive politice și religioase premierul britanic, Stanley Baldwin, l-a sfătuit pe rege să nu se căsătorească și să rămână rege.Eduard a abdicat și s - a căsătorit.Prin acest act, unic în 2000";
                Descriere2.Text="de ani de istorie britanică, George al VI - lea devine rege și cel de - al treilea monarh al casei de Windsor.";

            }
            else if (nr == 28)
            {
                Prev1.Text = Environment.NewLine + name27.Text; Prev2.Text = time27.Text;
                Next1.Text = Environment.NewLine + name29.Text; Next2.Text = time29.Text;
              //  WindowsMediaPlayer.URL = "D:/biografii/c28.mp4";
                title.Text = name28.Text + Environment.NewLine + "~" + time28.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q28;
                Descriere1.Text = "";
            }
            else if (nr == 29)
            {
                Prev1.Text = Environment.NewLine + name28.Text; Prev2.Text = time28.Text;
                Next1.Text = Environment.NewLine + name30.Text; Next2.Text = time30.Text;
          //      WindowsMediaPlayer.URL = "D:/biografii/c29.mp4";
                title.Text = name29.Text + Environment.NewLine + "~" + time29.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q29;
                Descriere1.Text = "Erwin Johannes Eugen Rommel a fost unul dintre cei mai distinși și remarcabili feldmareșali ai Germaniei, ai Wehrmacht-ului și al celui de-al doilea război mondial, fiind totodată unul dintre cei mai mari comandanți militari germani. Rommel a fost comandatul general al trupelor germane din Africa, trupele Wehrmacht-ului cunoscute sub numele de Deutsches Afrikakorps, ceea ce i-a atras porecla vulpea deșertului datorită campaniilor militare reușite pe care le-a repurtat pentru armata germană în Campania din Africa de nord. Mai târziu, a fost numit comandantul forțelor germane menite să se opună invaziei aliaților din Normandia.Feldmareșalul Rommel este adesea amintit nu numai pentru remarcabilele sale realizări militare, dar și pentru cavalerismul și respectul arătat adversarilor săi. Este cunoscut ca unul din membrii marcanți ai Wehrmacht - ului care s-a opus ordinelor directe, atunci când acestea încălcau codul onoarei militare și al onoarei umane.Poziția lui Rommel în raport cu național - socialismul(nazismul) german este controversată, dacă se ia în considerație și prietenia lui cu Goebbels șeful propagandei naziste, care - l simpatiza.Rommel a fost considerat de unii, fără dovezi clare, ca făcând posibil parte din grupul de";
                    Descriere2.Text="conspiratori care a intenționat să - l asasineze pe Hitler în încercarea de insurecție antinazistă sub numele de cod „operațiunea Valkiria”.";

            }
            else if (nr == 30)
            {
                Prev1.Text = Environment.NewLine + name29.Text; Prev2.Text = time29.Text;
                Next1.Text = Environment.NewLine + name31.Text; Next2.Text = time31.Text;
              //  WindowsMediaPlayer.URL = "D:/biografii/c30.mp4";
                title.Text = name30.Text + Environment.NewLine + "~" + time30.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q30;
                Descriere1.Text =  "  Hermann Wilhelm Göring, adesea doar Hermann Göring sau Hermann Goering,a fost un aviator militar german, politician, comandant militar, al doilea în ierarhia partidului național-socialist (nazist) și a celui de-al Treilea Reich, după Adolf Hitler, și comandantul aviației militare, Luftwaffe, a Germaniei naziste. Înființarea primelor lagăre hitleriste germane de concentrare (gen închisoare) și a Gestapo-ului (poliția secretă de stat) sunt strâns legate de numele lui Göring. Divizia de tancuri Hermann Göring Panzerdivision (divizia de blindate și parașutiști), care a luptat în Africa și Sicilia, a purtat numele său.";

            }
            else if (nr == 31)
            {
                Prev1.Text = Environment.NewLine + name30.Text; Prev2.Text = time30.Text;
                Next1.Text = Environment.NewLine + name32.Text; Next2.Text = time32.Text;
              //  WindowsMediaPlayer.URL = "D:/biografii/c31.mp4";
                title.Text = name31.Text + Environment.NewLine + "~" + time31.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q31;
                Descriere1.Text = "  Paul Joseph Goebbels a fost un politician german și Ministrul Propagandei Publice în timpul regimului nazist din anul 1933 până în 1945. A fost unul dintre cei mai apropiați colaboratori a lui Adolf Hitler și printre cei mai devotați adepți a ideologiei naziste. Goebbels a fost cunoscut ca fiind zelos, un orator energic și un antisemit virulent.Goebbels a devenit doctor în Filosofie la Universitatea Heidelberg în 1921, după care a lucrat ca jurnalist, funcționar la o bancă și angajat la bursă.A scris, de asemenea, nuvele și piese de teatru, care însă au fost refuzate de editori.A intrat în contact cu Partidul nazist, NSDAP, în 1923, în timpul ocupației franceze a Ruhr-ului, devenind membru în 1924.A fost numit Gauleiter(lider regional de partid) al Berlinului. În acestă funcție și-a folosit atributele propagandiste pentru a combate partidele locale socialiste și comuniste, beneficiind și de ajutorul „Sturmabteilung” (SA).Până în 1928 a fost continuu avansat în ierarhia partidului, devenind unul dintre cei mai proeminenți membri.După ce naziștii au preluat puterea în 1933, Goebbels a fost numit Ministrul Propagandei. Unul dintre primele sale acte a fost să ordoneze arderea cărților evreiești sau cu autori antinaziști -în Berlin în piața Bebelplatz. ";
                    Descriere2.Text="  Dupa numirea sa, atacurile împotriva evreilor germani au devenit și mai feroce, culminând cu pogromul din așa - numita Noapte a pogromului din noiembrie(Noaptea de cristal, Kristallnach), Novemberpogromnacht, în 1938.";

            }
            else if (nr == 32)
            {
                Prev1.Text = Environment.NewLine + name31.Text; Prev2.Text = time31.Text;
                Next1.Text = Environment.NewLine + name33.Text; Next2.Text = time33.Text;
             //   WindowsMediaPlayer.URL = "D:/biografii/c32.mp4";
                title.Text = name32.Text + Environment.NewLine + "~" + time32.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q32;
                Descriere1.Text = "  Heinrich Luitpold Himmler a fost un criminal de război nazist și important colaborator al lui Adolf Hitler și unul din principalii orchestratori ai Holocaustului. Himmler a fost comandantul forței paramilitare SS (Schutzstaffel) și unul dintre liderii naziști de prim rang ai Germaniei naziste. În preajma capitulării Germaniei, Himmler l-a avut ca șef numai pe Hitler în ierarhia politico-administrativă a statului. Având gradul de „Reichsführer-SS” (comandantul suprem al SS-ului), Himmler era concomitent șeful SS-ului și al Poliției Secrete de Stat, poliția politică cunoscută cu numele abreviat Gestapo. Ca fondator și comandant al lagărelor de concentrare naziste și al unităților SS operative Einsatzgruppen înființate pentru a lichida victimele regimului în teritoriile ocupate, Himmler a avut răspunderea supremă pentru exterminarea a milioane de oameni inocenți, care, potrivit ideologiei oficiale și convingerilor lui, nu „meritau să trăiască”.";

            }
            else if (nr == 33)
            {
                Prev1.Text = Environment.NewLine + name32.Text; Prev2.Text = time32.Text;
                Next1.Text = Environment.NewLine + name34.Text; Next2.Text = time34.Text;
            //    WindowsMediaPlayer.URL = "D:/biografii/c33.mp4";
                title.Text = name33.Text + Environment.NewLine + "~" + time33.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q33;
                Descriere1.Text = "  În contextul politic creat de moartea regelui Ferdinand și cea a lui Ion I.C Brătianu, cât și de lipsa de fermitate a regenței conduse de principele Nicolae, Carol s-a întors, în 1930, în România, detronându-și propriul fiu. Domnia lui a fost marcată la început de efectele marii crize economice și financiare. Carol a fragilizat sistemul de partide, numind adesea la guvernare facțiuni minoritare ale partidelor istorice și cochetând cu idea unor guverne de concentrație națională, precum guvernul Iorga-Argetoianu. De asemenea, a permis formarea unei camarile corupte în jurul său, sub patronajul Elenei Lupescu. Către sfârșitul anilor '30, situația politică internă s-a deteriorat sub influența situației internaționale și a acțiunilor regelui, în 1938 fiind instaurată dictatura regală (prin înlăturarea constituției din 1923 și desființarea partidelor politice, înlocuite cu un partid unic, Frontul Renașterii Naționale, patronat de rege).Anul 1940 a consemnat fărâmițarea României Mari ca urmare a pactului dintre Germania și URSS, situație care a avut efecte dezastruoase asupra reputației monarhului român. Reorientarea politicii externe a României către Germania nazistă nu a putut salva regimul lui Carol, care a fost obligat să abdice de către generalul Ion";
                Descriere2.Text="Antonescu, proaspăt numit de el prim - ministru.";

            }
            else if (nr == 34)
            {
                Prev1.Text = Environment.NewLine + name33.Text; Prev2.Text = time33.Text;
                Next1.Text = Environment.NewLine + name35.Text; Next2.Text = time35.Text;
             //   WindowsMediaPlayer.URL = "D:/biografii/c34.mp4";
                title.Text = name34.Text + Environment.NewLine + "~" + time34.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q34;
                Descriere1.Text = "  Mihai a devenit pentru prima dată rege al României în 1927, după moartea bunicului său Ferdinand, întrucât tatăl său renunțase în decembrie 1925 la tron și rămăsese în străinătate.În septembrie 1940 Carol al II-lea i-a acordat puteri discreționare generalului Ion Antonescu, care i-a impus să abdice în favoarea fiului său. Regele Mihai I, în calitate de mareșal și comandant suprem al armatei române, a fost decorat prin jurnalul Consiliului de Miniștri din 8 noiembrie 1941 cu toate cele trei clase ale Ordinului „Mihai Viteazul”, fiind singurul deținător român în această situație, alături de mareșalul Ion Antonescu.La 6 martie 1945, la presiunile ocupantului militar sovietic, regele Mihai a fost silit să accepte un guvern prosovietic dominat de Partidul Comunist Român, prim-ministru fiind numit Petru Groza. Guvernul Groza a fost un guvern minoritar, acceptat numai în urma promisiunilor britanice și americane de a menține un regim democratic în România chiar și în cazul în care sunt îndeplinite cererile politice ale Rusiei. Guvernul era controlat de Frontul Național Democrat, dominat de comuniști.In 30 decembrie 1947 ,regele Mihai a fost silit să abdice.Petru Groza și Gheorghiu-Dej i - au cerut regelui, în seara zilei de 29 decembrie, să vină";
                Descriere2.Text="la București de la reședința sa din Sinaia sub pretextul discutării unei probleme familiale importante și urgente și i - au prezentat o declarație de abdicare.";

            }
            else if (nr == 35)
            {
                Prev1.Text = Environment.NewLine + name34.Text; Prev2.Text = time34.Text;
                Next1.Text = Environment.NewLine + name36.Text; Next2.Text = time36.Text;
             //   WindowsMediaPlayer.URL = "D:/biografii/c35.mp4";
                title.Text = name35.Text + Environment.NewLine + "~" + time35.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q35;
                Descriere1.Text = "  A fost ofițer și om de stat în armata franceză, lider al mișcării de rezistență franceză în timpul celui de-al doilea război mondial și șef al unui guvern interimar al Republicii Franceze în 1944-1946." + Environment.NewLine + "  A fost un ofițer distins al Primului Război Mondial, a fost rănit de mai multe ori și ulterior luat prizonier la Verdun. În perioada interbelică, a promovat o strategie de utilizare a diviziilor blindate mobile în luptă. În timpul invaziei germane din mai 1940 a condus o divizie de tancuri pentru a contraataca unitățile germane. El nu a acceptat încetarea focului guvernului cu Germania și, cu ajutorul lui Winston Churchill, a evadat cu avionul în Anglia, unde a chemat francezii să reziste ocupației și să continue lupta lor. În timpul războiului, el a condus francezii liberi și a devenit liderul incontestabil al rezistenței franceze. De asemenea, a devenit șeful guvernului temporar al Republicii Franceze în iunie 1944. În 1944-1945, armata franceză condusă de De Gaulle s-a transformat într-o a patra putere în coaliția anti-hitleristă din Europa. De Gaulle a introdus reforme economice în Franța, în urma cărora a urmat o perioadă de 30 de ani de creștere economică, cunoscută sub numele de Trente Glorieuses. În 1958, revista";
                Descriere2.Text="Time l-a numit pe De Gaulle Omul anului. A demisionat în 1969 după ce a pierdut un referendum privind reforma Senatului. A murit un an mai târziu la reședința sa din Colombey-les-Deux-Églises. De Gaulle a exercitat o influență enormă asupra multor viitori politicieni francezi și este una dintre cele mai mari figuri din istoria Franței. Multe străzi și monumente din Franța au fost dedicate memoriei sale.";
            }
            else if (nr == 36)
            {
                Prev1.Text = Environment.NewLine + name35.Text; Prev2.Text = time35.Text;
                Next1.Text = Environment.NewLine + name37.Text; Next2.Text = time37.Text;
             //   WindowsMediaPlayer.URL = "D:/biografii/c36.mp4";
                title.Text = name36.Text + Environment.NewLine + "~" + time36.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q36;
                Descriere1.Text = "  A fost comandant-șef și om de stat al US Navy și șef de stat major al armatei SUA sub președinții Franklin D. Roosevelt și Harry S. Truman." + Environment.NewLine + "  Winston Churchill l-a lăudat pe Marshall numindu-l „arhitectul victoriei” care a dus la triumful aliaților în cel de-al doilea război mondial, în ciuda refuzării poziției de comandant suprem al armatei SUA asumată în cele din urmă de Dwight D. Eisenhower, ulterior președinte american. După război, în calitate de secretar de stat, Marshall a cerut un angajament economic și politic considerabil al SUA în reconstrucția postbelică a Europei. „Planul Marshall” îi poartă într-adevăr numele. În 1953, a primit Premiul Nobel pentru Pace. În calitate de șef de stat major, Marshall a fost arhitectul uneia dintre cele mai mari expansiuni militare din istoria SUA. Până la sfârșitul celui de-al doilea război mondial, Marshall a coordonat operațiunile aliate în Europa și Pacific. Revista Times l-a numit Omul anului în 1943.";

            }
            else if (nr == 37)
            {
                Prev1.Text = Environment.NewLine + name36.Text; Prev2.Text = time36.Text;
                Next1.Text = Environment.NewLine + name38.Text; Next2.Text = time38.Text;
             //   WindowsMediaPlayer.URL = "D:/biografii/c37.mp4";
                title.Text = name37.Text + Environment.NewLine + "~" + time37.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q37;
                Descriere1.Text = "  Gheorghe Gheorghiu-Dej a fost liderul comunist al României de după război și președinte al Consiliului de miniștri RPR. După fraudarea alegerilor din 1946 și ascensiunea comuniștilor la putere cu ajutorul armatei de ocupație sovietice, România intră în sfera de influență a URSS. Comunist de vocație, proletarul Dej și-a început cariera în 1933, când a fost arestat în urma grevelor de la atelierele CFR Grivița și condamnat la 12 ani de muncă silnică." + Environment.NewLine + "  După 23 august 1944, susținut de Moscova, preia conducerea PRM și acaparează întreaga putere în stat, elimină partidele istorice și forțează abdicarea Regelui Mihai la 30 decembrie 1947. Proclamă Republica Populara Română ca stat subordonat sovieticilor. Lovitura sa de teatru a fost eliminarea în 1952 de la conducerea PRM a grupului de comuniști cu școala la Moscova: Ana Pauker, Vasile Luca și Theohari Georgescu. Înlăturarea acestor rivali, vechi cominterniști, a fost posibilă cu voia lui Stalin." + Environment.NewLine + "  În 1958, când se retrag trupele sovietice din țară, Dej se distanțează de Moscova, într-o oarecare măsura. La moartea lui în 1965, România era o altă țară decât cea din 1945. Clasa politică tradițională fusese lichidată. Puterea se";
                Descriere2.Text="afla în exclusivitate în mâinile Partidului Muncitoresc român. Industria, finanțele, comerțul, toate erau naționalizate. Țărănimea fusese colectivizată. Dej poartă răspunderea victimelor comunismului și doar în plan economic i se recunosc unele succese, printre care industrializarea și electrificarea țării. Oricum însă, pentru România roșie, lumina avea să vină, mult timp, tot de la răsărit.";
             }
            else if (nr == 38)
            {
                Prev1.Text = Environment.NewLine + name37.Text; Prev2.Text = time37.Text;
                Next1.Text = Environment.NewLine + name39.Text; Next2.Text = time39.Text;
             //   WindowsMediaPlayer.URL = "D:/biografii/c38.mp4";
                title.Text = name38.Text + Environment.NewLine + "~" + time38.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q38;
                Descriere1.Text = "  Nicolae Ceaușescu a fost un dictator român, secretar general al Partidului Comunist Român, șeful de stat al Republicii Socialiste România din 1967 până la căderea regimului comunist, survenită în 22 decembrie 1989. La 22 decembrie 1989, printr-un decret al CFSN semnat de Ion Iliescu, a fost constituit Tribunalul Militar Excepțional. La 25 decembrie 1989, soții Nicolae și Elena Ceaușescu au fost judecați de acest tribunal în cadrul unui proces sumar, condamnați la moarte și executați la câteva minute după pronunțarea sentinței. În iulie 2015, România a interzis prin lege „cultul lui Ceaușescu”.";

            }
            else if (nr == 39)
            {
                Prev1.Text = Environment.NewLine + name38.Text; Prev2.Text = time38.Text;
                Next1.Text = Environment.NewLine + name40.Text; Next2.Text = time40.Text;
              //  WindowsMediaPlayer.URL = "D:/biografii/c39.mp4";
                title.Text = name39.Text + Environment.NewLine + "~" + time39.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q39;
                Descriere1.Text = "  Fidel Alejandro Castro Ruz s-a născut în 1926 la Birán, în estul insulei. Unii istorici susţin că s-ar fi născut în 1927. A crescut în bunăstare, iar după absolvirea facultăţii de Drept a început să profeseze ca avocat, la Havanna. Clienţii săi proveneau mai ales din cartierele sărace ale oraşului."+Environment.NewLine+ "Castro şi-a făcut un scop din a-l înlătura pe Batista şi a început să-şi adune susţinători; printre altele şi Ernesto „Che” Guevara i s-a alăturat.Două tentative de răsturnare a regimului (1953 şi 1955) au eşuat, iar „Comandante en jefe” s-a refugiat în munţi.lanurile revoluţionarului Castro erau de a-l înlătura de la putere pe Batista.La 1 ianuarie 1959, Castro a preluat puterea."+Environment.NewLine+ "  Uniunea Sovietică susţinea financiar Cuba. În 1962, ruşii şi-au instalat pe insulă rachete cu rază medie, lucru care a stârnit furia americanilor. SUA au reacţionat rapid. Aşa-numita „criză cubaneză” a fost rezolvată fără războiul nuclear de care se temea toată lumea.Cu toate acestea, sancţiunile impuse Cubei începând din acelaşi an au influenţat până în ziua de azi relaţiile dintre SUA şi Cuba, respectiv economia ţării din Caraibe. După destrămarea Uniunii Sovietice, situaţia Cubei s-a deteriorat şi mai mult din cauza dependenţei economice de ruşi.";
            }
            else if (nr == 40)
            {
                Prev1.Text = Environment.NewLine + name39.Text; Prev2.Text = time39.Text;
                Next1.Text = Environment.NewLine + name41.Text; Next2.Text = time41.Text;
             //   WindowsMediaPlayer.URL = "D:/biografii/c40.mp4";
                title.Text = name40.Text + Environment.NewLine + "~" + time40.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q40;
                Descriere1.Text = "  John Fitzgerald Kennedy a fost cel de-al treizeci și cincilea președinte al Statelor Unite ale Americii. A servit din 1961 până la en asasinarea sa survenită în ziua de 22 noiembrie 1963, la Dallas, Texas. A fost unul dintre membrii cei mai proeminenți ai familiei Kennedy implicați în politică, fiind totodată considerat un stindard al en liberalismului american.Urmând instrucțiunile tatălui său, Jack a repetat în fiecare discurs electoral fapta sa eroică din Pacificul de sud și moartea tragică a fratelui său. Din culise, tatăl său se ocupa cu administrarea economică și canalizarea sumelor uriașe în mai multe direcții pentru a asigura susținătorii fiului său. În mai 1946 câștigă investitura Partidului Democrat, zdrobește candidatul Republicanilor, de origine italiană, în alegerile din decembrie și este ales pentru prima oară în Congres. Starea sănătății sale era însă critică, suferea și de hernie de disc și de boala Addison.În ianuarie 1960, Kennedy și-a anunțat candidatura la președinția SUA. Atenția sa s-a îndreptat către mass-media, făcând apel direct către poporul american. Rezultatul a fost o victorie zdrobitoare împotriva adversarului său, Hubert Humphrey, în turul preliminar, și victoria împotriva lui Lyndon B. Johnson";
                Descriere2.Text="pentru investitura Partidului Democrat. La 14 iulie 1960, la congresul Partidului Democrat de la Los Angeles, Kennedy a fost investit candidat cu aproape dublul voturilor adversarului său. S-a bazat pe tehnicile moderne cum ar fi sondajele, promovarea cu mass-media și relații cu publicul.";

            }
            else if (nr == 41)
            {
                Prev1.Text = Environment.NewLine + name40.Text; Prev2.Text = time40.Text;
                Next1.Text = Environment.NewLine + name42.Text; Next2.Text = time42.Text;
              //  WindowsMediaPlayer.URL = "D:/biografii/c41.mp4";
                title.Text = name41.Text + Environment.NewLine + "~" + time41.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q41;
                Descriere1.Text = "  Richard Milhous Nixon a fost al treizeci și șaptelea președinte al Statelor Unite, îndeplinind această funcție între 1969 și 1974, când a devenit primul și încă singurul președinte american care a demisionat din funcție. Înainte de președinție, Nixon fusese membru al Camerei Reprezentanților din partea statului California și a Partidului Republican, și apoi senator de California și al treizeci și șaselea vicepreședinte al SUA între 1953 și 1961 în mandatele prezidențiale ale lui Dwight Eisenhower.Nixon a fost vicepreședinte opt ani, după care a candidat la funcția prezidențială la alegerile din 1960, fiind învins la limită de John F. Kennedy, după care a pierdut și alegerile pentru funcția de guvernator al Californiei în 1962. În 1968, a candidat din nou pentru președinție și a fost ales.Deși Nixon a escaladat la început implicarea Statelor Unite în Războiul din Vietnam, a sfârșit prin a retrage SUA din conflict până în 1973. Vizita efectuată de Nixon în 1972.în Republica Populară Chineză a deschis comunicațiile între cele două țări și a dus la normalizarea relațiilor diplomatice. El a inițiat o destindere a relațiilor cu Uniunea Sovietică și a semnat în același an Tratatul Împotriva Rachetelor Balistice.Pe plan intern, administrația sa a";
                Descriere2.Text="adoptat în general politici ce transferau puterea de la Washington către state.";

            }
            else if (nr == 42)
            {
                Next1.Visible = Next2.Visible = false;
                Prev1.Text = Environment.NewLine + name41.Text; Prev2.Text = time41.Text;
                
               //WindowsMediaPlayer.URL = "D:/biografii/c42.mp4";
                title.Text = name42.Text + Environment.NewLine + "~" + time42.Text + "~";
                poza_mare.BackgroundImage = Properties.Resources.q42;
                Descriere1.Text = "Ronald Wilson Reagan, cunoscut mai ales ca Ronald Reagan , a fost cel de-al patruzecilea președinte al Statelor Unite ale Americii. Prin politica sa intransigentă în confruntarea cu Uniunea Sovietică în perioada războiului rece, a avut o contribuție hotărâtoare la prăbușirea comunismului din răsăritul Europei și la afirmarea Statelor Unite ale Americii ca singura super-putere pentru următoarele decenii. Înainte de a deveni președinte, a fost al 33-a guvernator al Californiei, din 1967 până la 1975, după ce a avut o carieră de actor la Hollywood și a fost lider de sindicat.A fost primul președinte de după Dwight D. Eisenhower care a deținut două mandate, după ce o succesiune de cinci președinți anteriori cu un singur mandat, unii din cauza unor împrejurări deosebite.A descris în public Uniunea Sovietică drept „Imperiul Răului”, iar în timpului faimosului discurs de la Poarta Brandenburg, președintele Reagan i-a cerut Secretarului General al Partidului Comunist al Uniunii Sovietice, Mihail Gorbaciov, „dărâmați acest zid!”. A schimbat politica Războiului Rece de la destindere la rollback⁠(d), escaladând cursa înarmării cu URSS, iar în acest răstimp a participat la discuții cu Gorbaciov, care au culminat cu ";
                Descriere2.Text="Tratatul INF⁠(d), care a micșorat arsenalele nucleare ale ambelor țări.Când Reagan a părăsit funcția în 1989, cota sa de popularitate atinsese 68%, egalându-l în acest sens pe Franklin D. Roosevelt.";

            }



            WindowsMediaPlayer.Ctlcontrols.pause();
            stop_pause = 1;
            play_stop.BackgroundImage = Properties.Resources.pauza_video;

            pnb.AutoScroll = true;


            pnb.AutoScrollPosition = new Point(0, 0);
        }

        private void time1_Click(object sender, EventArgs e)
        {
            pna.Visible = false;
        }

        private void OnMouseEnterbio1(object sender, EventArgs e)
        {

            bio1.BackColor = time1.BackColor = name1.BackColor = Color.FromArgb(x1, y1, z1);
            time1.ForeColor = name1.ForeColor = under1.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio1(object sender, EventArgs e)
        {

            bio1.BackColor = time1.BackColor = name1.BackColor = Color.FromArgb(x2, y2, z2);
            time1.ForeColor = name1.ForeColor = under1.BackColor = Color.FromArgb(x1, y1, z1);
        }

        private void OnMouseEnterbio2(object sender, EventArgs e)
        {

            bio2.BackColor = time2.BackColor = name2.BackColor = Color.FromArgb(x1, y1, z1);
            time2.ForeColor = name2.ForeColor = under2.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio2(object sender, EventArgs e)
        {

            bio2.BackColor = time2.BackColor = name2.BackColor = Color.FromArgb(x2, y2, z2);
            time2.ForeColor = name2.ForeColor = under2.BackColor = Color.FromArgb(x1, y1, z1);
        }

        private void OnMouseEnterbio3(object sender, EventArgs e)
        {

            bio3.BackColor = time3.BackColor = name3.BackColor = Color.FromArgb(x1, y1, z1);
            time3.ForeColor = name3.ForeColor = under3.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio3(object sender, EventArgs e)
        {

            bio3.BackColor = time3.BackColor = name3.BackColor = Color.FromArgb(x2, y2, z2);
            time3.ForeColor = name3.ForeColor = under3.BackColor = Color.FromArgb(x1, y1, z1);
        }

        private void OnMouseEnterbio4(object sender, EventArgs e)
        {

            bio4.BackColor = time4.BackColor = name4.BackColor = Color.FromArgb(x1, y1, z1);
            time4.ForeColor = name4.ForeColor = under4.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio4(object sender, EventArgs e)
        {

            bio4.BackColor = time4.BackColor = name4.BackColor = Color.FromArgb(x2, y2, z2);
            time4.ForeColor = name4.ForeColor = under4.BackColor = Color.FromArgb(x1, y1, z1);
        }

        private void OnMouseEnterbio5(object sender, EventArgs e)
        {

            bio5.BackColor = time5.BackColor = name5.BackColor = Color.FromArgb(x1, y1, z1);
            time5.ForeColor = name5.ForeColor = under5.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio5(object sender, EventArgs e)
        {

            bio5.BackColor = time5.BackColor = name5.BackColor = Color.FromArgb(x2, y2, z2);
            time5.ForeColor = name5.ForeColor = under5.BackColor = Color.FromArgb(x1, y1, z1);
        }

        private void OnMouseEnterbio6(object sender, EventArgs e)
        {

            bio6.BackColor = time6.BackColor = name6.BackColor = Color.FromArgb(x1, y1, z1);
            time6.ForeColor = name6.ForeColor = under6.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio6(object sender, EventArgs e)
        {

            bio6.BackColor = time6.BackColor = name6.BackColor = Color.FromArgb(x2, y2, z2);
            time6.ForeColor = name6.ForeColor = under6.BackColor = Color.FromArgb(x1, y1, z1);
        }

        private void OnMouseEnterbio7(object sender, EventArgs e)
        {

            bio7.BackColor = time7.BackColor = name7.BackColor = Color.FromArgb(x1, y1, z1);
            time7.ForeColor = name7.ForeColor = under7.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio7(object sender, EventArgs e)
        {

            bio7.BackColor = time7.BackColor = name7.BackColor = Color.FromArgb(x2, y2, z2);
            time7.ForeColor = name7.ForeColor = under7.BackColor = Color.FromArgb(x1, y1, z1);
        }

        private void OnMouseEnterbio8(object sender, EventArgs e)
        {

            bio8.BackColor = time8.BackColor = name8.BackColor = Color.FromArgb(x1, y1, z1);
            time8.ForeColor = name8.ForeColor = under8.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio8(object sender, EventArgs e)
        {

            bio8.BackColor = time8.BackColor = name8.BackColor = Color.FromArgb(x2, y2, z2);
            time8.ForeColor = name8.ForeColor = under8.BackColor = Color.FromArgb(x1, y1, z1);
        }

        private void OnMouseEnterbio9(object sender, EventArgs e)
        {

            bio9.BackColor = time9.BackColor = name9.BackColor = Color.FromArgb(x1, y1, z1);
            time9.ForeColor = name9.ForeColor = under9.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio9(object sender, EventArgs e)
        {

            bio9.BackColor = time9.BackColor = name9.BackColor = Color.FromArgb(x2, y2, z2);
            time9.ForeColor = name9.ForeColor = under9.BackColor = Color.FromArgb(x1, y1, z1);
        }

        private void OnMouseEnterbio10(object sender, EventArgs e)
        {

            bio10.BackColor = time10.BackColor = name10.BackColor = Color.FromArgb(x1, y1, z1);
            time10.ForeColor = name10.ForeColor = under10.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio10(object sender, EventArgs e)
        {

            bio10.BackColor = time10.BackColor = name10.BackColor = Color.FromArgb(x2, y2, z2);
            time10.ForeColor = name10.ForeColor = under10.BackColor = Color.FromArgb(x1, y1, z1);
        }

        private void OnMouseEnterbio11(object sender, EventArgs e)
        {

            bio11.BackColor = time11.BackColor = name11.BackColor = Color.FromArgb(x1, y1, z1);
            time11.ForeColor = name11.ForeColor = under11.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio11(object sender, EventArgs e)
        {

            bio11.BackColor = time11.BackColor = name11.BackColor = Color.FromArgb(x2, y2, z2);
            time11.ForeColor = name11.ForeColor = under11.BackColor = Color.FromArgb(x1, y1, z1);
        }

        private void OnMouseEnterbio12(object sender, EventArgs e)
        {

            bio12.BackColor = time12.BackColor = name12.BackColor = Color.FromArgb(x1, y1, z1);
            time12.ForeColor = name12.ForeColor = under12.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio12(object sender, EventArgs e)
        {

            bio12.BackColor = time12.BackColor = name12.BackColor = Color.FromArgb(x2, y2, z2);
            time12.ForeColor = name12.ForeColor = under12.BackColor = Color.FromArgb(x1, y1, z1);
        }

        private void OnMouseEnterbio13(object sender, EventArgs e)
        {

            bio13.BackColor = time13.BackColor = name13.BackColor = Color.FromArgb(x1, y1, z1);
            time13.ForeColor = name13.ForeColor = under13.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio13(object sender, EventArgs e)
        {

            bio13.BackColor = time13.BackColor = name13.BackColor = Color.FromArgb(x2, y2, z2);
            time13.ForeColor = name13.ForeColor = under13.BackColor = Color.FromArgb(x1, y1, z1);
        }

        private void OnMouseEnterbio14(object sender, EventArgs e)
        {

            bio14.BackColor = time14.BackColor = name14.BackColor = Color.FromArgb(x1, y1, z1);
            time14.ForeColor = name14.ForeColor = under14.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio14(object sender, EventArgs e)
        {

            bio14.BackColor = time14.BackColor = name14.BackColor = Color.FromArgb(x2, y2, z2);
            time14.ForeColor = name14.ForeColor = under14.BackColor = Color.FromArgb(x1, y1, z1);
        }

        private void OnMouseEnterbio15(object sender, EventArgs e)
        {

            bio15.BackColor = time15.BackColor = name15.BackColor = Color.FromArgb(x1, y1, z1);
            time15.ForeColor = name15.ForeColor = under15.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio15(object sender, EventArgs e)
        {

            bio15.BackColor = time15.BackColor = name15.BackColor = Color.FromArgb(x2, y2, z2);
            time15.ForeColor = name15.ForeColor = under15.BackColor = Color.FromArgb(x1, y1, z1);
        }

        private void OnMouseEnterbio16(object sender, EventArgs e)
        {

            bio16.BackColor = time16.BackColor = name16.BackColor = Color.FromArgb(x1, y1, z1);
            time16.ForeColor = name16.ForeColor = under16.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio16(object sender, EventArgs e)
        {

            bio16.BackColor = time16.BackColor = name16.BackColor = Color.FromArgb(x2, y2, z2);
            time16.ForeColor = name16.ForeColor = under16.BackColor = Color.FromArgb(x1, y1, z1);
        }

        private void OnMouseEnterbio17(object sender, EventArgs e)
        {

            bio17.BackColor = time17.BackColor = name17.BackColor = Color.FromArgb(x1, y1, z1);
            time17.ForeColor = name17.ForeColor = under17.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio17(object sender, EventArgs e)
        {

            bio17.BackColor = time17.BackColor = name17.BackColor = Color.FromArgb(x2, y2, z2);
            time17.ForeColor = name17.ForeColor = under17.BackColor = Color.FromArgb(x1, y1, z1);
        }

        private void OnMouseEnterbio18(object sender, EventArgs e)
        {

            bio18.BackColor = time18.BackColor = name18.BackColor = Color.FromArgb(x1, y1, z1);
            time18.ForeColor = name18.ForeColor = under18.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio18(object sender, EventArgs e)
        {

            bio18.BackColor = time18.BackColor = name18.BackColor = Color.FromArgb(x2, y2, z2);
            time18.ForeColor = name18.ForeColor = under18.BackColor = Color.FromArgb(x1, y1, z1);
        }

        private void OnMouseEnterbio19(object sender, EventArgs e)
        {

            bio19.BackColor = time19.BackColor = name19.BackColor = Color.FromArgb(x1, y1, z1);
            time19.ForeColor = name19.ForeColor = under19.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio19(object sender, EventArgs e)
        {

            bio19.BackColor = time19.BackColor = name19.BackColor = Color.FromArgb(x2, y2, z2);
            time19.ForeColor = name19.ForeColor = under19.BackColor = Color.FromArgb(x1, y1, z1);
        }

        private void OnMouseEnterbio20(object sender, EventArgs e)
        {

            bio20.BackColor = time20.BackColor = name20.BackColor = Color.FromArgb(x1, y1, z1);
            time20.ForeColor = name20.ForeColor = under20.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio20(object sender, EventArgs e)
        {

            bio20.BackColor = time20.BackColor = name20.BackColor = Color.FromArgb(x2, y2, z2);
            time20.ForeColor = name20.ForeColor = under20.BackColor = Color.FromArgb(x1, y1, z1);
        }

        private void OnMouseEnterbio21(object sender, EventArgs e)
        {

            bio21.BackColor = time21.BackColor = name21.BackColor = Color.FromArgb(x1, y1, z1);
            time21.ForeColor = name21.ForeColor = under21.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio21(object sender, EventArgs e)
        {

            bio21.BackColor = time21.BackColor = name21.BackColor = Color.FromArgb(x2, y2, z2);
            time21.ForeColor = name21.ForeColor = under21.BackColor = Color.FromArgb(x1, y1, z1);
        }

        private void OnMouseEnterbio22(object sender, EventArgs e)
        {

            bio22.BackColor = time22.BackColor = name22.BackColor = Color.FromArgb(x1, y1, z1);
            time22.ForeColor = name22.ForeColor = under22.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio22(object sender, EventArgs e)
        {

            bio22.BackColor = time22.BackColor = name22.BackColor = Color.FromArgb(x2, y2, z2);
            time22.ForeColor = name22.ForeColor = under22.BackColor = Color.FromArgb(x1, y1, z1);
        }

        private void OnMouseEnterbio23(object sender, EventArgs e)
        {

            bio23.BackColor = time23.BackColor = name23.BackColor = Color.FromArgb(x1, y1, z1);
            time23.ForeColor = name23.ForeColor = under23.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio23(object sender, EventArgs e)
        {

            bio23.BackColor = time23.BackColor = name23.BackColor = Color.FromArgb(x2, y2, z2);
            time23.ForeColor = name23.ForeColor = under23.BackColor = Color.FromArgb(x1, y1, z1);
        }

        private void OnMouseEnterbio24(object sender, EventArgs e)
        {

            bio24.BackColor = time24.BackColor = name24.BackColor = Color.FromArgb(x1, y1, z1);
            time24.ForeColor = name24.ForeColor = under24.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio24(object sender, EventArgs e)
        {

            bio24.BackColor = time24.BackColor = name24.BackColor = Color.FromArgb(x2, y2, z2);
            time24.ForeColor = name24.ForeColor = under24.BackColor = Color.FromArgb(x1, y1, z1);
        }

        private void OnMouseEnterbio25(object sender, EventArgs e)
        {

            bio25.BackColor = time25.BackColor = name25.BackColor = Color.FromArgb(x1, y1, z1);
            time25.ForeColor = name25.ForeColor = under25.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio25(object sender, EventArgs e)
        {

            bio25.BackColor = time25.BackColor = name25.BackColor = Color.FromArgb(x2, y2, z2);
            time25.ForeColor = name25.ForeColor = under25.BackColor = Color.FromArgb(x1, y1, z1);
        }

        private void OnMouseEnterbio26(object sender, EventArgs e)
        {

            bio26.BackColor = time26.BackColor = name26.BackColor = Color.FromArgb(x1, y1, z1);
            time26.ForeColor = name26.ForeColor = under26.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio26(object sender, EventArgs e)
        {

            bio26.BackColor = time26.BackColor = name26.BackColor = Color.FromArgb(x2, y2, z2);
            time26.ForeColor = name26.ForeColor = under26.BackColor = Color.FromArgb(x1, y1, z1);
        }

        private void OnMouseEnterbio27(object sender, EventArgs e)
        {

            bio27.BackColor = time27.BackColor = name27.BackColor = Color.FromArgb(x1, y1, z1);
            time27.ForeColor = name27.ForeColor = under27.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio27(object sender, EventArgs e)
        {

            bio27.BackColor = time27.BackColor = name27.BackColor = Color.FromArgb(x2, y2, z2);
            time27.ForeColor = name27.ForeColor = under27.BackColor = Color.FromArgb(x1, y1, z1);
        }

        private void OnMouseEnterbio28(object sender, EventArgs e)
        {

            bio28.BackColor = time28.BackColor = name28.BackColor = Color.FromArgb(x1, y1, z1);
            time28.ForeColor = name28.ForeColor = under28.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio28(object sender, EventArgs e)
        {

            bio28.BackColor = time28.BackColor = name28.BackColor = Color.FromArgb(x2, y2, z2);
            time28.ForeColor = name28.ForeColor = under28.BackColor = Color.FromArgb(x1, y1, z1);
        }

        private void OnMouseEnterbio29(object sender, EventArgs e)
        {

            bio29.BackColor = time29.BackColor = name29.BackColor = Color.FromArgb(x1, y1, z1);
            time29.ForeColor = name29.ForeColor = under29.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio29(object sender, EventArgs e)
        {

            bio29.BackColor = time29.BackColor = name29.BackColor = Color.FromArgb(x2, y2, z2);
            time29.ForeColor = name29.ForeColor = under29.BackColor = Color.FromArgb(x1, y1, z1);
        }

        private void OnMouseEnterbio30(object sender, EventArgs e)
        {

            bio30.BackColor = time30.BackColor = name30.BackColor = Color.FromArgb(x1, y1, z1);
            time30.ForeColor = name30.ForeColor = under30.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio30(object sender, EventArgs e)
        {

            bio30.BackColor = time30.BackColor = name30.BackColor = Color.FromArgb(x2, y2, z2);
            time30.ForeColor = name30.ForeColor = under30.BackColor = Color.FromArgb(x1, y1, z1);
        }

        private void OnMouseEnterbio31(object sender, EventArgs e)
        {

            bio31.BackColor = time31.BackColor = name31.BackColor = Color.FromArgb(x1, y1, z1);
            time31.ForeColor = name31.ForeColor = under31.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio31(object sender, EventArgs e)
        {

            bio31.BackColor = time31.BackColor = name31.BackColor = Color.FromArgb(x2, y2, z2);
            time31.ForeColor = name31.ForeColor = under31.BackColor = Color.FromArgb(x1, y1, z1);
        }

        private void OnMouseEnterbio32(object sender, EventArgs e)
        {

            bio32.BackColor = time32.BackColor = name32.BackColor = Color.FromArgb(x1, y1, z1);
            time32.ForeColor = name32.ForeColor = under32.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio32(object sender, EventArgs e)
        {

            bio32.BackColor = time32.BackColor = name32.BackColor = Color.FromArgb(x2, y2, z2);
            time32.ForeColor = name32.ForeColor = under32.BackColor = Color.FromArgb(x1, y1, z1);
        }

        private void OnMouseEnterbio33(object sender, EventArgs e)
        {

            bio33.BackColor = time33.BackColor = name33.BackColor = Color.FromArgb(x1, y1, z1);
            time33.ForeColor = name33.ForeColor = under33.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio33(object sender, EventArgs e)
        {

            bio33.BackColor = time33.BackColor = name33.BackColor = Color.FromArgb(x2, y2, z2);
            time33.ForeColor = name33.ForeColor = under33.BackColor = Color.FromArgb(x1, y1, z1);
        }

        private void OnMouseEnterbio34(object sender, EventArgs e)
        {

            bio34.BackColor = time34.BackColor = name34.BackColor = Color.FromArgb(x1, y1, z1);
            time34.ForeColor = name34.ForeColor = under34.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio34(object sender, EventArgs e)
        {

            bio34.BackColor = time34.BackColor = name34.BackColor = Color.FromArgb(x2, y2, z2);
            time34.ForeColor = name34.ForeColor = under34.BackColor = Color.FromArgb(x1, y1, z1);
        }

        private void OnMouseEnterbio35(object sender, EventArgs e)
        {

            bio35.BackColor = time35.BackColor = name35.BackColor = Color.FromArgb(x1, y1, z1);
            time35.ForeColor = name35.ForeColor = under35.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio35(object sender, EventArgs e)
        {

            bio35.BackColor = time35.BackColor = name35.BackColor = Color.FromArgb(x2, y2, z2);
            time35.ForeColor = name35.ForeColor = under35.BackColor = Color.FromArgb(x1, y1, z1);
        }

        private void OnMouseEnterbio36(object sender, EventArgs e)
        {

            bio36.BackColor = time36.BackColor = name36.BackColor = Color.FromArgb(x1, y1, z1);
            time36.ForeColor = name36.ForeColor = under36.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio36(object sender, EventArgs e)
        {

            bio36.BackColor = time36.BackColor = name36.BackColor = Color.FromArgb(x2, y2, z2);
            time36.ForeColor = name36.ForeColor = under36.BackColor = Color.FromArgb(x1, y1, z1);
        }




        private void OnMouseEnterbio37(object sender, EventArgs e)
        {

            bio37.BackColor = time37.BackColor = name37.BackColor = Color.FromArgb(x1, y1, z1);
            time37.ForeColor = name37.ForeColor = under37.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio37(object sender, EventArgs e)
        {

            bio37.BackColor = time37.BackColor = name37.BackColor = Color.FromArgb(x2, y2, z2);
            time37.ForeColor = name37.ForeColor = under37.BackColor = Color.FromArgb(x1, y1, z1);
        }


        private void OnMouseEnterbio38(object sender, EventArgs e)
        {

            bio38.BackColor = time38.BackColor = name38.BackColor = Color.FromArgb(x1, y1, z1);
            time38.ForeColor = name38.ForeColor = under38.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio38(object sender, EventArgs e)
        {

            bio38.BackColor = time38.BackColor = name38.BackColor = Color.FromArgb(x2, y2, z2);
            time38.ForeColor = name38.ForeColor = under38.BackColor = Color.FromArgb(x1, y1, z1);
        }



        private void OnMouseEnterbio39(object sender, EventArgs e)
        {

            bio39.BackColor = time39.BackColor = name39.BackColor = Color.FromArgb(x1, y1, z1);
            time39.ForeColor = name39.ForeColor = under39.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio39(object sender, EventArgs e)
        {

            bio39.BackColor = time39.BackColor = name39.BackColor = Color.FromArgb(x2, y2, z2);
            time39.ForeColor = name39.ForeColor = under39.BackColor = Color.FromArgb(x1, y1, z1);
        }
        private void OnMouseEnterbio40(object sender, EventArgs e)
        {

            bio40.BackColor = time40.BackColor = name40.BackColor = Color.FromArgb(x1, y1, z1);
            time40.ForeColor = name40.ForeColor = under40.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio40(object sender, EventArgs e)
        {

            bio40.BackColor = time40.BackColor = name40.BackColor = Color.FromArgb(x2, y2, z2);
            time40.ForeColor = name40.ForeColor = under40.BackColor = Color.FromArgb(x1, y1, z1);
        }
        private void OnMouseEnterbio41(object sender, EventArgs e)
        {

            bio41.BackColor = time41.BackColor = name41.BackColor = Color.FromArgb(x1, y1, z1);
            time41.ForeColor = name41.ForeColor = under41.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio41(object sender, EventArgs e)
        {

            bio41.BackColor = time41.BackColor = name41.BackColor = Color.FromArgb(x2, y2, z2);
            time41.ForeColor = name41.ForeColor = under41.BackColor = Color.FromArgb(x1, y1, z1);
        }
        private void OnMouseEnterbio42(object sender, EventArgs e)
        {

            bio42.BackColor = time42.BackColor = name42.BackColor = Color.FromArgb(x1, y1, z1);
            time42.ForeColor = name42.ForeColor = under42.BackColor = Color.FromArgb(x2, y2, z2);
        }
        private void OnMouseLeavebio42(object sender, EventArgs e)
        {

            bio42.BackColor = time42.BackColor = name42.BackColor = Color.FromArgb(x2, y2, z2);
            time42.ForeColor = name42.ForeColor = under42.BackColor = Color.FromArgb(x1, y1, z1);
        }


        private void OnMouseEntercauta_pers(object sender, EventArgs e)
        {
            cauta_pers.ForeColor = Color.FromArgb(x1, y1, z1);
        }
        private void OnMouseLeavecauta_pers(object sender, EventArgs e)
        {

            cauta_pers.ForeColor = Color.FromArgb(x2, y2, z2);

        }

        public enum enmAction
        {
            wait,
            start,
            close
        }

        public enum enmType
        {
            Success,
            Warning,
            Error,
            Info
        }
        private Form_Alert.enmAction action;

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert("Success", "ai gresit", "e core", type);
        }

        void bio()
        {
           
        }

        private void Title1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void bio14_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void time1_Click_1(object sender, EventArgs e)
        {
            nr = 1; navigare();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            nr = 1; navigare();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel30_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel29_Paint(object sender, PaintEventArgs e)
        {

        }





        private void OnMouseEnterE2(object sender, EventArgs e)
        {
            E2.ForeColor = Color.FromArgb(x1, y1, z1);


        }

        private void OnMouseLeaveE2(object sender, EventArgs e)
        {
            E2.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseEnterSC2(object sender, EventArgs e)
        {
            SC2.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void E1_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer.Ctlcontrols.stop();
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }
  
        private void E2_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer.Ctlcontrols.stop();
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }
        private void S1_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer.Ctlcontrols.stop();
            this.Hide();
            var form3 = new Form3();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void S2_Click(object sender, EventArgs e)
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
        private void T2_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer.Ctlcontrols.stop();
            this.Hide();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
        private void SC1_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer.Ctlcontrols.stop();
            this.Hide();
            var form6 = new Form6();
            form6.Closed += (s, args) => this.Close();
            form6.Show();
        }
        private void SC2_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer.Ctlcontrols.stop();
            this.Hide();
            var form6 = new Form6();
            form6.Closed += (s, args) => this.Close();
            form6.Show();
        }

        private void poza1_Click(object sender, EventArgs e)
        {
            nr = 1; navigare();
        }

        private void name1_Click(object sender, EventArgs e)
        {
            nr = 1; navigare();
        }

        private void under1_Click(object sender, EventArgs e)
        {
            nr = 1; navigare();
        }

        private void name2_Click(object sender, EventArgs e)
        {
            nr = 2; navigare();
        }
        private void bio2_Click(object sender, EventArgs e)
        {
            nr = 2; navigare();
        }
        private void time2_Click(object sender, EventArgs e)
        {
            nr = 2; navigare();
        }

        private void under2_Click(object sender, EventArgs e)
        {
            nr = 2; navigare();
        }

        private void poza2_Click(object sender, EventArgs e)
        {
            nr = 2; navigare();
        }

        private void name3_Click(object sender, EventArgs e)
        {
            nr = 3; navigare();
        }

        private void poza3_Click(object sender, EventArgs e)
        {
            nr = 3; navigare();
        }

        private void under3_Click(object sender, EventArgs e)
        {
            nr = 3; navigare();
        }

        private void time3_Click(object sender, EventArgs e)
        {
            nr = 3; navigare();
        }

        private void bio3_Click(object sender, EventArgs e)
        {
            nr = 3; navigare();
        }

        private void name4_Click(object sender, EventArgs e)
        {
            nr = 4; navigare();
        }

        private void poza4_Click(object sender, EventArgs e)
        {
            nr = 4; navigare();
        }

        private void under4_Click(object sender, EventArgs e)
        {
            nr = 4; navigare();
        }

        private void time4_Click(object sender, EventArgs e)
        {
            nr = 4; navigare();
        }

        private void poza5_Click(object sender, EventArgs e)
        {
            nr = 5; navigare();
        }

        private void name5_Click(object sender, EventArgs e)
        {
            nr = 5; navigare();
        }

        private void under5_Click(object sender, EventArgs e)
        {
            nr = 5; navigare();
        }

        private void time5_Click(object sender, EventArgs e)
        {
            nr = 5; navigare();
        }

        private void bio5_Click(object sender, EventArgs e)
        {
            nr = 5; navigare();
        }

        private void poza6_Click(object sender, EventArgs e)
        {
            nr = 6; navigare();
        }

        private void name6_Click(object sender, EventArgs e)
        {
            nr = 6; navigare();
        }
        private void bio6_Click(object sender, EventArgs e)
        {
            nr = 6; navigare();
        }
        private void under6_Click(object sender, EventArgs e)
        {
            nr = 6; navigare();
        }

        private void time6_Click(object sender, EventArgs e)
        {
            nr = 6; navigare();
        }

        private void name7_Click(object sender, EventArgs e)
        {
            nr = 7; navigare();
        }

        private void under7_Click(object sender, EventArgs e)
        {
            nr = 7; navigare();
        }

        private void time7_Click(object sender, EventArgs e)
        {
            nr = 7; navigare();
        }

        private void poza7_Click(object sender, EventArgs e)
        {
            nr = 7; navigare();
        }

        private void bio7_Click(object sender, EventArgs e)
        {
            nr = 7; navigare();
        }

        private void name8_Click(object sender, EventArgs e)
        {
            nr = 8; navigare();
        }

        private void under8_Click(object sender, EventArgs e)
        {
            nr = 8; navigare();
        }

        private void time8_Click(object sender, EventArgs e)
        {
            nr = 8; navigare();
        }

        private void poza8_Click(object sender, EventArgs e)
        {
            nr = 8; navigare();
        }

        private void bio8_Click(object sender, EventArgs e)
        {
            nr = 8; navigare();
        }

        private void name9_Click(object sender, EventArgs e)
        {
            nr = 9; navigare();
        }

        private void poza9_Click(object sender, EventArgs e)
        {
            nr = 9; navigare();
        }

        private void under9_Click(object sender, EventArgs e)
        {
            nr = 9; navigare();
        }

        private void time9_Click(object sender, EventArgs e)
        {
            nr = 9; navigare();
        }

        private void bio9_Click(object sender, EventArgs e)
        {
            nr = 9; navigare();
        }


        private void name10_Click(object sender, EventArgs e)
        {
            nr = 10; navigare();
        }

        private void poza10_Click(object sender, EventArgs e)
        {
            nr = 10; navigare();
        }

        private void bio10_Click(object sender, EventArgs e)
        {
            nr = 10; navigare();
        }
        private void under10_Click(object sender, EventArgs e)
        {
            nr = 10; navigare();
        }

        private void time10_Click(object sender, EventArgs e)
        {
            nr = 10; navigare();
        }

        private void poza11_Click(object sender, EventArgs e)
        {
            nr = 11; navigare();
        }

        private void name11_Click(object sender, EventArgs e)
        {
            nr = 11; navigare();
        }

        private void bio11_Click(object sender, EventArgs e)
        {
            nr = 11; navigare();
        }


        private void under11_Click(object sender, EventArgs e)
        {
            nr = 11; navigare();
        }

        private void time11_Click(object sender, EventArgs e)
        {
            nr = 11; navigare();
        }

        private void name12_Click(object sender, EventArgs e)
        {
            nr = 12; navigare();
        }

        private void under12_Click(object sender, EventArgs e)
        {
            nr = 12; navigare();
        }

        private void time12_Click(object sender, EventArgs e)
        {
            nr = 12; navigare();
        }

        private void poza12_Click(object sender, EventArgs e)
        {
            nr = 12; navigare();
        }

        private void bio12_Click(object sender, EventArgs e)
        {
           nr = 12; navigare();
        }

        private void name13_Click(object sender, EventArgs e)
        {
            nr = 13; navigare();
        }

        private void under13_Click(object sender, EventArgs e)
        {
            nr = 13; navigare();
        }

        private void time13_Click(object sender, EventArgs e)
        {
            nr = 13; navigare();
        }

        private void poza13_Click(object sender, EventArgs e)
        {
            nr = 13; navigare();
        }

        private void bio13_Click(object sender, EventArgs e)
        {
           nr = 13; navigare();
        }

        private void poza14_Click(object sender, EventArgs e)
        {
            nr = 14; navigare();
        }

        private void name14_Click(object sender, EventArgs e)
        {
            nr = 14; navigare();
        }

        private void time14_Click(object sender, EventArgs e)
        {
            nr = 14; navigare();
        }

        private void under14_Click(object sender, EventArgs e)
        {
            nr = 14; navigare();
        }

        private void bio14_Click(object sender, EventArgs e)
        {
           nr = 14; navigare();
        }

        private void poza15_Click(object sender, EventArgs e)
        {
            nr = 15; navigare();
        }

        private void name15_Click(object sender, EventArgs e)
        {
            nr = 15; navigare();
        }

        private void under15_Click(object sender, EventArgs e)
        {
            nr = 15; navigare();
        }

        private void time15_Click(object sender, EventArgs e)
        {
            nr = 15; navigare();
        }
        private void bio15_Click(object sender, EventArgs e)
        {
            nr = 15; navigare();
        }

        private void name16_Click(object sender, EventArgs e)
        {
            nr = 16; navigare();
        }

        private void under16_Click(object sender, EventArgs e)
        {
            nr = 16; navigare();
        }

        private void time16_Click(object sender, EventArgs e)
        {
            nr = 16; navigare();
        }

        private void poza16_Click(object sender, EventArgs e)
        {
            nr = 16; navigare();
        }

        private void bio16_Click(object sender, EventArgs e)
        {
            nr = 16; navigare();
        }

        private void name17_Click(object sender, EventArgs e)
        {
            nr = 17; navigare();
        }

        private void under17_Click(object sender, EventArgs e)
        {
            nr = 17; navigare();
        }

        private void time17_Click(object sender, EventArgs e)
        {
            nr = 17; navigare();
        }

        private void poza17_Click(object sender, EventArgs e)
        {
            nr = 17; navigare();
        }

        private void bio17_Click(object sender, EventArgs e)
        {
            nr = 17; navigare();
        }

        private void name18_Click(object sender, EventArgs e)
        {
            nr = 18; navigare();
        }
      

     

        private void under18_Click(object sender, EventArgs e)
        {
            nr = 18; navigare();
        }

        private void time18_Click(object sender, EventArgs e)
        {
            nr = 18; navigare();
        }

        private void poza18_Click(object sender, EventArgs e)
        {
            nr = 18; navigare();
        }

        private void bio18_Click(object sender, EventArgs e)
        {
            nr = 18; navigare();
        }

        private void poza19_Click(object sender, EventArgs e)
        {
            nr = 19; navigare();
        }

        private void name19_Click(object sender, EventArgs e)
        {
            nr = 19; navigare();
        }

        private void under19_Click(object sender, EventArgs e)
        {
            nr = 19; navigare();
        }

        private void time19_Click(object sender, EventArgs e)
        {
            nr = 19; navigare();
        }

        private void bio19_Click(object sender, EventArgs e)
        {
            nr = 19; navigare();
        }

        private void poza20_Click(object sender, EventArgs e)
        {
            nr = 20; navigare();
        }

        private void name20_Click(object sender, EventArgs e)
        {
            nr = 20; navigare();
        }

        private void time20_Click(object sender, EventArgs e)
        {
            nr = 20; navigare();
        }

        private void under20_Click(object sender, EventArgs e)
        {
            nr = 20; navigare();
        }

        private void bio20_Click(object sender, EventArgs e)
        {
            nr = 20; navigare();
        }

        private void poza21_Click(object sender, EventArgs e)
        {
            nr = 21; navigare();
        }

        private void name21_Click(object sender, EventArgs e)
        {
            nr = 21; navigare();
        }

        private void under21_Click(object sender, EventArgs e)
        {
            nr = 21; navigare();
        }

        private void time21_Click(object sender, EventArgs e)
        {
            nr = 21; navigare();
        }

        private void bio21_Click(object sender, EventArgs e)
        {
            nr = 21; navigare();
        }

        private void poza22_Click(object sender, EventArgs e)
        {
            nr = 22; navigare();
        }

        private void name22_Click(object sender, EventArgs e)
        {
            nr = 22; navigare();
        }

        private void under22_Click(object sender, EventArgs e)
        {
            nr = 22; navigare();
        }

        private void time22_Click(object sender, EventArgs e)
        {
            nr = 22; navigare();
        }

        private void bio22_Click(object sender, EventArgs e)
        {
            nr = 22; navigare();
        }

        private void poza23_Click(object sender, EventArgs e)
        {
            nr = 23; navigare();
        }

        private void name23_Click(object sender, EventArgs e)
        {
            nr = 23; navigare();
        }

        private void under23_Click(object sender, EventArgs e)
        {
            nr = 23; navigare();
        }

        private void time23_Click(object sender, EventArgs e)
        {
            nr = 23; navigare();
        }

        private void bio23_Click(object sender, EventArgs e)
        {
            nr = 23; navigare();
        }

        private void poza24_Click(object sender, EventArgs e)
        {
            nr = 24; navigare();
        }

        private void name24_Click(object sender, EventArgs e)
        {
            nr = 24; navigare();
        }

        private void under24_Click(object sender, EventArgs e)
        {
            nr = 24; navigare();
        }

        private void time24_Click(object sender, EventArgs e)
        {
            nr = 24; navigare();
        }

        private void bio24_Click(object sender, EventArgs e)
        {
            nr = 24; navigare();
        }

        private void poza25_Click(object sender, EventArgs e)
        {
            nr = 25; navigare();
        }

        private void name25_Click(object sender, EventArgs e)
        {
            nr = 25; navigare();
        }

        private void under25_Click(object sender, EventArgs e)
        {
            nr = 25; navigare();
        }

        private void time25_Click(object sender, EventArgs e)
        {
            nr = 25; navigare();
        }

        private void bio25_Click(object sender, EventArgs e)
        {
            nr = 25; navigare();
        }

        private void poza26_Click(object sender, EventArgs e)
        {
            nr = 26; navigare();
        }

        private void name26_Click(object sender, EventArgs e)
        {
            nr = 26; navigare();
        }

        private void under26_Click(object sender, EventArgs e)
        {
            nr = 26; navigare();
        }

        private void time26_Click(object sender, EventArgs e)
        {
            nr = 26; navigare();
        }

        private void bio26_Click(object sender, EventArgs e)
        {
            nr = 26; navigare();
        }

        private void poza27_Click(object sender, EventArgs e)
        {
            nr = 27; navigare();
        }

        private void name27_Click(object sender, EventArgs e)
        {
            nr = 27; navigare();
        }

        private void under27_Click(object sender, EventArgs e)
        {
            nr = 27; navigare();
        }

        private void time27_Click(object sender, EventArgs e)
        {
            nr = 27; navigare();
        }

        private void bio27_Click(object sender, EventArgs e)
        {
            nr = 27; navigare();
        }

        private void poza28_Click(object sender, EventArgs e)
        {
            nr = 28; navigare();
        }

        private void name28_Click(object sender, EventArgs e)
        {
            nr = 28; navigare();
        }

        private void under28_Click(object sender, EventArgs e)
        {
            nr = 28; navigare();
        }

        private void time28_Click(object sender, EventArgs e)
        {
            nr = 28; navigare();
        }

        private void bio28_Click(object sender, EventArgs e)
        {
            nr = 28; navigare();
        }

        private void poza29_Click(object sender, EventArgs e)
        {
            nr = 29; navigare();
        }

        private void name29_Click(object sender, EventArgs e)
        {
            nr = 29; navigare();
        }

        private void under29_Click(object sender, EventArgs e)
        {
            nr = 29; navigare();
        }

        private void time29_Click(object sender, EventArgs e)
        {
            nr = 29; navigare();
        }

        private void bio29_Click(object sender, EventArgs e)
        {
            nr = 29; navigare();
        }

        private void poza30_Click(object sender, EventArgs e)
        {
            nr = 30; navigare();
        }

        private void name30_Click(object sender, EventArgs e)
        {
            nr = 30; navigare();
        }

        private void under30_Click(object sender, EventArgs e)
        {
            nr = 30; navigare();
        }

        private void time30_Click(object sender, EventArgs e)
        {
            nr = 30; navigare();
        }

        private void bio30_Click(object sender, EventArgs e)
        {
            nr = 30; navigare();
        }

        private void poza31_Click(object sender, EventArgs e)
        {
            nr = 31; navigare();
        }

        private void name31_Click(object sender, EventArgs e)
        {
            nr = 31; navigare();
        }

        private void under31_Click(object sender, EventArgs e)
        {
            nr = 31; navigare();
        }

        private void time31_Click(object sender, EventArgs e)
        {
            nr = 31; navigare();
        }

        private void bio31_Click(object sender, EventArgs e)
        {
            nr = 31; navigare();
        }

        private void poza32_Click(object sender, EventArgs e)
        {
            nr = 32; navigare();
        }

        private void name32_Click(object sender, EventArgs e)
        {
            nr = 32; navigare();
        }

        private void under32_Click(object sender, EventArgs e)
        {
            nr = 32; navigare();
        }

        private void time32_Click(object sender, EventArgs e)
        {
            nr = 32; navigare();
        }

        private void bio32_Click(object sender, EventArgs e)
        {
            nr = 32; navigare();
        }

        private void poza33_Click(object sender, EventArgs e)
        {
            nr = 33; navigare();
        }

        private void name33_Click(object sender, EventArgs e)
        {
            nr = 33; navigare();
        }

        private void under33_Click(object sender, EventArgs e)
        {
            nr = 33; navigare();
        }

        private void time33_Click(object sender, EventArgs e)
        {
            nr = 33; navigare();
        }

        private void bio33_Click(object sender, EventArgs e)
        {
            nr = 33; navigare();
        }

        private void name34_Click(object sender, EventArgs e)
        {
            nr = 34; navigare();
        }

        private void poza34_Click(object sender, EventArgs e)
        {
            nr = 34; navigare();
        }

        private void under34_Click(object sender, EventArgs e)
        {
            nr = 34; navigare();
        }

        private void time34_Click(object sender, EventArgs e)
        {
            nr = 34; navigare();
        }

        private void bio34_Click(object sender, EventArgs e)
        {
            nr = 34; navigare();
        }

        private void poza35_Click(object sender, EventArgs e)
        {
            nr = 35; navigare();
        }

        private void name35_Click(object sender, EventArgs e)
        {
            nr = 35; navigare();
        }

        private void under35_Click(object sender, EventArgs e)
        {
            nr = 35; navigare();
        }

        private void time35_Click(object sender, EventArgs e)
        {
            nr = 35; navigare();
        }

        private void bio35_Click(object sender, EventArgs e)
        {
            nr = 35; navigare();
        }

        private void poza36_Click(object sender, EventArgs e)
        {
            nr = 36; navigare();
        }

        private void name36_Click(object sender, EventArgs e)
        {
            nr = 36; navigare();
        }

        private void under36_Click(object sender, EventArgs e)
        {
            nr = 36; navigare();
        }

        private void time36_Click(object sender, EventArgs e)
        {
            nr = 36; navigare();
        }

        private void bio36_Click(object sender, EventArgs e)
        {
            nr = 36; navigare();
        }

        private void poza37_Click(object sender, EventArgs e)
        {
            nr = 37; navigare();
        }

        private void name37_Click(object sender, EventArgs e)
        {
            nr = 37; navigare();
        }

        private void under37_Click(object sender, EventArgs e)
        {
            nr = 37; navigare();
        }

        private void time37_Click(object sender, EventArgs e)
        {
            nr = 37; navigare();
        }
        private void bio37_Click(object sender, EventArgs e)
        {
            nr = 37; navigare();
        }

        private void poza38_Click(object sender, EventArgs e)
        {
            nr = 38; navigare();
        }

        private void name38_Click(object sender, EventArgs e)
        {
            nr = 38; navigare();
        }

        private void under38_Click(object sender, EventArgs e)
        {
            nr = 38; navigare();
        }

        private void time38_Click(object sender, EventArgs e)
        {
            nr = 38; navigare();
        }

        private void bio38_Click(object sender, EventArgs e)
        {
            nr = 38; navigare();
        }

        private void poza39_Click(object sender, EventArgs e)
        {
            nr = 39; navigare();
        }

        private void name39_Click(object sender, EventArgs e)
        {
            nr = 39; navigare();
        }

        private void under39_Click(object sender, EventArgs e)
        {
            nr = 39; navigare();
        }

        private void time39_Click(object sender, EventArgs e)
        {
            nr = 39; navigare();
        }

        private void bio39_Click(object sender, EventArgs e)
        {
            nr = 39; navigare();
        }

        private void poza40_Click(object sender, EventArgs e)
        {
            nr = 40; navigare();
        }

        private void name40_Click(object sender, EventArgs e)
        {
            nr = 40; navigare();
        }

        private void time40_Click(object sender, EventArgs e)
        {
            nr = 40; navigare();
        }

        private void under40_Click(object sender, EventArgs e)
        {
            nr = 40; navigare();
        }

        private void bio40_Click(object sender, EventArgs e)
        {
            nr = 40; navigare();
        }

        private void poza41_Click(object sender, EventArgs e)
        {
            nr = 41; navigare();
        }

        private void name41_Click(object sender, EventArgs e)
        {
            nr = 41; navigare();
        }

        private void under41_Click(object sender, EventArgs e)
        {
            nr = 41; navigare();
        }

        private void time41_Click(object sender, EventArgs e)
        {
            nr = 41; navigare();
        }

        private void bio41_Click(object sender, EventArgs e)
        {
            nr = 41; navigare();
        }

        private void poza42_Click(object sender, EventArgs e)
        {
            nr = 42; navigare();
        }

        private void name42_Click(object sender, EventArgs e)
        {
            nr = 42; navigare();
        }

        private void under42_Click(object sender, EventArgs e)
        {
            nr = 42; navigare();
        }

        private void time42_Click(object sender, EventArgs e)
        {
            nr = 42; navigare();
        }

        private void bio42_Click(object sender, EventArgs e)
        {
            nr = 42; navigare();
        }

        private void Prev2_Click(object sender, EventArgs e)
        {
            if (nr != 1)
            {
                nr--;navigare();
            }
        }

        private void Prev1_Click(object sender, EventArgs e)
        {
            if (nr != 1)
            {
                nr--; navigare();
            }
        }

        private void Next2_Click(object sender, EventArgs e)
        {
            if (nr != 42)
            {
                nr++; navigare();
            }
        }

        private void Next1_Click(object sender, EventArgs e)
        {
            if (nr != 42)
            {
                nr++; navigare();
            }
        }

        private void speaker_Click(object sender, EventArgs e)
        {
            volum = 1 - volum;
            if (volum == 0)
            {
                volum_initial = guna2TrackBar2.Value;
                guna2TrackBar2.Value = 0;

                speaker.BackgroundImage = Properties.Resources.speaker_mute;
            }
            else if (volum == 1)
            {
                guna2TrackBar2.Value = volum_initial;
                speaker.BackgroundImage = Properties.Resources.speaker_volume;
            }


            WindowsMediaPlayer.settings.volume = guna2TrackBar2.Value;
            label12.Text = guna2TrackBar2.Value.ToString() + "%";
        }

        private void guna2TrackBar2_Scroll(object sender, ScrollEventArgs e)
        {
            WindowsMediaPlayer.settings.volume = guna2TrackBar2.Value;
            label12.Text = guna2TrackBar2.Value.ToString() + "%";

            if (guna2TrackBar2.Value == 0) speaker.BackgroundImage = Properties.Resources.speaker_mute;
            else speaker.BackgroundImage = Properties.Resources.speaker_volume;
        }

        private void play_stop_Click(object sender, EventArgs e)
        {
            stop_pause = 1 - stop_pause;
            if (stop_pause == 0)
            {
                WindowsMediaPlayer.Ctlcontrols.pause();
                describtion.Text = "Redă";
                play_stop.BackgroundImage = Properties.Resources.play_video;

            }
            else if (stop_pause == 1)
            {
                WindowsMediaPlayer.Ctlcontrols.play();
                describtion.Text = "Întrerupe";
                play_stop.BackgroundImage = Properties.Resources.pauza_video;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (WindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                guna2TrackBar1.Value = (int)WindowsMediaPlayer.Ctlcontrols.currentPosition;

            }
            label10.Text = WindowsMediaPlayer.Ctlcontrols.currentPositionString + "/" + WindowsMediaPlayer.Ctlcontrols.currentItem.durationString.ToString();
    
        }
        void afis_meme()
        {
            if (meme == 0) interogatoriu.Visible = DA.Visible = NU.Visible = mafiamember.Visible = false;



            if (meme == 1)
            {
                interogatoriu.Visible = DA.Visible = NU.Visible = mafiamember.Visible = false;

                interogatoriu.Text = "Ia zi, vrei niste meme- uri?";
                memes = true; refuz = 0;
                interogatoriu.Visible = mafiamember.Visible = DA.Visible = NU.Visible = true;

            }


        }

        private void guna2TrackBar1_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsMediaPlayer.Ctlcontrols.currentPosition = WindowsMediaPlayer.currentMedia.duration * e.X / guna2TrackBar1.Width;

        }

        private void TAB2_Click(object sender, EventArgs e)
        {
            meme = 1;
            afis_meme();
            TAB2.Visible=false; 
            stanga_output.Visible = true;
        }

        private void TAB1_Click(object sender, EventArgs e)
        {
            meme = 1;
            afis_meme();
            TAB1.Visible = false; stanga_output.Visible = true;
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
            TAB1.Visible =TAB2.Visible= true;
         
           
        }



        void video()
        {
            tbn.Visible = ytb.Visible = false;
            studio.Visible = true;
            play_stop.BackgroundImage = Properties.Resources.pauza_video;
            if (nr == 1) WindowsMediaPlayer.URL = "D:/biografii/b1.mp4";
            else if (nr == 2) WindowsMediaPlayer.URL = "D:/biografii/b2.mp4";
            else if (nr == 3) WindowsMediaPlayer.URL = "D:/biografii/b3.mp4";
            else if (nr == 4) WindowsMediaPlayer.URL = "D:/biografii/b4.mp4";
            else if (nr == 5) WindowsMediaPlayer.URL = "D:/biografii/b5.mp4";
            else if (nr == 6) WindowsMediaPlayer.URL = "D:/biografii/b6.mp4";
            else if (nr == 7) WindowsMediaPlayer.URL = "D:/biografii/b7.mp4";
            else if (nr == 8) WindowsMediaPlayer.URL = "D:/biografii/b8.mp4";
            else if (nr == 9) WindowsMediaPlayer.URL = "D:/biografii/b9.mp4";
            else if (nr == 10) WindowsMediaPlayer.URL = "D:/biografii/b10.mp4";
            else if (nr == 11) WindowsMediaPlayer.URL = "D:/biografii/b11.mp4";
            else if (nr == 12) WindowsMediaPlayer.URL = "D:/biografii/b12.mp4";
            else if (nr == 13) WindowsMediaPlayer.URL = "D:/biografii/b13.mp4";
            else if (nr == 14) WindowsMediaPlayer.URL = "D:/biografii/b14.mp4";
            else if (nr == 15) WindowsMediaPlayer.URL = "D:/biografii/b15.mp4";
            else if (nr == 16) WindowsMediaPlayer.URL = "D:/biografii/b16.mp4";
            else if (nr == 17) WindowsMediaPlayer.URL = "D:/biografii/b17.mp4";
            else if (nr == 18) WindowsMediaPlayer.URL = "D:/biografii/b18.mp4";
            else if (nr == 19) WindowsMediaPlayer.URL = "D:/biografii/b19.mp4";
            else if (nr == 20) WindowsMediaPlayer.URL = "D:/biografii/b20.mp4";
            else if (nr == 21) WindowsMediaPlayer.URL = "D:/biografii/b21.mp4";
            else if (nr == 22) WindowsMediaPlayer.URL = "D:/biografii/b22.mp4";
            else if (nr == 23) WindowsMediaPlayer.URL = "D:/biografii/b23.mp4";
            else if (nr == 24) WindowsMediaPlayer.URL = "D:/biografii/b24.mp4";
            else if (nr == 25) WindowsMediaPlayer.URL = "D:/biografii/b25.mp4";
            else if (nr == 26) WindowsMediaPlayer.URL = "D:/biografii/b26.mp4";
            else if (nr == 27) WindowsMediaPlayer.URL = "D:/biografii/b27.mp4";
            else if (nr == 28) WindowsMediaPlayer.URL = "D:/biografii/b28.mp4";
            else if (nr == 29) WindowsMediaPlayer.URL = "D:/biografii/b29.mp4";
            else if (nr == 30) WindowsMediaPlayer.URL = "D:/biografii/b30.mp4";
            else if (nr == 31) WindowsMediaPlayer.URL = "D:/biografii/b31.mp4";
            else if (nr == 32) WindowsMediaPlayer.URL = "D:/biografii/b32.mp4";
            else if (nr == 33) WindowsMediaPlayer.URL = "D:/biografii/b33.mp4";
            else if (nr == 34) WindowsMediaPlayer.URL = "D:/biografii/b34.mp4";
            else if (nr == 35) WindowsMediaPlayer.URL = "D:/biografii/b35.mp4";
            else if (nr == 36) WindowsMediaPlayer.URL = "D:/biografii/b36.mp4";
            else if (nr == 37) WindowsMediaPlayer.URL = "D:/biografii/b37.mp4";
            else if (nr == 38) WindowsMediaPlayer.URL = "D:/biografii/b38.mp4";
            else if (nr == 39) WindowsMediaPlayer.URL = "D:/biografii/b39.mp4";
            else if (nr == 40) WindowsMediaPlayer.URL = "D:/biografii/b40.mp4";
            else if (nr == 41) WindowsMediaPlayer.URL = "D:/biografii/b41.mp4";
            else if (nr == 42) WindowsMediaPlayer.URL = "D:/biografii/b42.mp4";
        }
        private void button1_Click_1(object sender, EventArgs e)
        {




        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void ytb_Click(object sender, EventArgs e)
        {
            video();
        }

        private void thumbnail_Click(object sender, EventArgs e)
        {
            video();
        }

        private void tbn_Click(object sender, EventArgs e)
        {
            video();
        }

        private void ytb_Click_1(object sender, EventArgs e)
        {
            video();
        }

        private void tbn_Click_1(object sender, EventArgs e)
        {
            video();
        }

        private void WindowsMediaPlayer_DockChanged(object sender, EventArgs e)
        {
            guna2TrackBar2.Value = WindowsMediaPlayer.settings.volume;


            label12.Text = guna2TrackBar2.Value.ToString() + "%";

            if (guna2TrackBar2.Value == 0) speaker.BackgroundImage = Properties.Resources.speaker_mute;
            else speaker.BackgroundImage = Properties.Resources.speaker_volume;
        }

        private void WindowsMediaPlayer_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            stop_pause = 1 - stop_pause;
            if (stop_pause == 0)
            {
                WindowsMediaPlayer.Ctlcontrols.pause();
                describtion.Text = "Redă";
                play_stop.BackgroundImage = Properties.Resources.play_video;

            }
            else if (stop_pause == 1)
            {
                WindowsMediaPlayer.Ctlcontrols.play();
                describtion.Text = "Întrerupe";
                play_stop.BackgroundImage = Properties.Resources.pauza_video;

            }
        }

        private void WindowsMediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (WindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                guna2TrackBar1.Maximum = (int)WindowsMediaPlayer.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else if (WindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();
            }
            else if (WindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                
                    studio.Visible = false;
                    ytb.Visible = tbn.Visible = true;
                
            }
        }

        private void WindowsMediaPlayer_SizeChanged(object sender, EventArgs e)
        {
            guna2TrackBar2.Value = WindowsMediaPlayer.settings.volume;


            label12.Text = guna2TrackBar2.Value.ToString() + "%";

            if (guna2TrackBar2.Value == 0) speaker.BackgroundImage = Properties.Resources.speaker_mute;
            else speaker.BackgroundImage = Properties.Resources.speaker_volume;
        }

        private void OnMouseLeaveytb(object sender, EventArgs e)
        {
            ytb.BackgroundImage = Properties.Resources.youtubenegru;

        }


        private void OnMouseEnterytb(object sender, EventArgs e)
        {
            ytb.BackgroundImage = Properties.Resources.youtuberosu;

        }

        private void OnMouseLeaveSC2(object sender, EventArgs e)
        {
            SC2.ForeColor = Color.FromArgb(x2, y2, z2);

        }


        private void OnMouseEnterT2(object sender, EventArgs e)
        {
            T2.ForeColor = Color.FromArgb(x1, y1, z1);

        }

        private void OnMouseLeaveT2(object sender, EventArgs e)
        {
            T2.ForeColor = Color.FromArgb(x2, y2, z2);

        }

        private void OnMouseEnterS2(object sender, EventArgs e)
        {
            S2.ForeColor = Color.FromArgb(x1, y1, z1);

        }

        private void OnMouseLeaveS2(object sender, EventArgs e)
        {
            S2.ForeColor = Color.FromArgb(x2, y2, z2);

        }
    }
}
