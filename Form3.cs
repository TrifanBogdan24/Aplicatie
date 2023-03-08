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


    public partial class Form3 : Form
    {
        int q = 1, an1 = 1840,an2=1999,nr_events=0,poz=1,i,anactual;
        int x1, y1, z1, x2, y2, z2;



        int panel_sus_jos = 0;



        int frecv_eror=1;

        bool s1, s2, s3, s4, s5, s6, s7, s8, stot;

        bool schimba_in_galben = false;
        int meme;
        int refuz;
        bool memes;

        // v memoreaza numarul celui mai apropiat eveniment,fiind >= an1
        int[] v = new int[99999];
        int[] fiz = new int[99999];
        int[] ch = new int[99999];
        int[] biol = new int[99999];
        int[] coms = new int[99999];
    
        int[] space = new int[99999];
        int[] earth = new int[99999];
        int[] fd = new int[9999];

        int[] an_event = new int[200];
        int[] an_fiz = new int[200];
        int[] an_ch = new int[200];
        int[] an_bio = new int[99999];
        int[] an_comms = new int[200];
        int[] an_food = new int[200];
        int[] an_space = new int[200];
        int[] an_earth = new int[200];
        string a1, a2,ev;
       

        bool ok = false;
        public Form3()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            //pt background : 251, 239, 146





            bool toate, fizica, chimie, bio, geogra, comms, IT, food,inve,transp;

            toate = fizica = chimie = bio = geogra = comms = IT = food =inve=transp= false;

            toate = true;

      

            background1.BackColor =title1.BackColor=descriere1.BackColor= data1.BackColor=Color.FromArgb(228, 211, 82);
         
           TAB.BackgroundImage = Properties.Resources.bars;
            an_nr1.ForeColor=an_nr2.ForeColor =desp.ForeColor= Color.FromArgb(20, 156, 8);
           an_nr1.Font =an_nr2.Font=desp.Font= new Font("Stencil",24);

            C1.Font = C2.Font = new Font("Stencil", 12);
           
            data1.Font=title1.Font = new Font("Georgia", 16,FontStyle.Bold);

            descriere1.Font = new Font("Monotype Corsiva", 18);

            C1.Visible = C2.Visible = false;
            //descriere1.Font=descriere2.Font=new Font("Poor Richard",14);
            
            imagine1.Visible = false;
            Q11.FlatStyle = Q12.FlatStyle = Q13.FlatStyle = numaratoare1.FlatStyle = FlatStyle.Flat;
            Q11.BackColor = Q12.BackColor = Q13.BackColor = numaratoare1.BackColor = Color.FromArgb(228, 211, 82);

            next11.Cursor = next12.Cursor = prev11.Cursor = prev12.Cursor = Cursors.Hand;


            ARROW.Cursor = T1.Cursor = E1.Cursor = SC1.Cursor = Biog1.Cursor = TAB.Cursor=Cursors.Hand;
            Q11.Cursor = Q12.Cursor = Q13.Cursor =  Cursors.Hand;
            Next.Cursor = Prev.Cursor = Cursors.Hand;
            Next.BackgroundImage = Properties.Resources.next;
            Prev.BackgroundImage = Properties.Resources.predecesor;

            stanga_output.Visible = false;
            ARROW.BackgroundImage = Properties.Resources.left;


            x1 = 22; y2 = 18; z1 = 126; //bleumarin
            x2 = 236; y2 = 240; z2 = 241; ///alb

            stanga_output.BackColor = Color.FromArgb(22, 18, 88);

            E1.ForeColor=Biog1.ForeColor=SC1.ForeColor=T1.ForeColor =Color.FromArgb(x2,y2,z2);
            
             E1.FlatStyle = SC1.FlatStyle = Biog1.FlatStyle = T1.FlatStyle = T1.FlatStyle =  FlatStyle.Flat;

           SC1.Font = E1.Font = T1.Font = Biog1.Font = new Font("Microsoft Sans Serif",20);

       
          //  Color.FromArgb(x2, y2, z2);
           
           
            SC1.ForeColor = E1.ForeColor = T1.ForeColor = Biog1.ForeColor = Color.FromArgb(x2,y2,z2);
          
            
            T1.MouseEnter += OnMouseEnterT1; T1.MouseLeave += OnMouseLeaveT1;
            SC1.MouseEnter += OnMouseEnterSC1; SC1.MouseLeave += OnMouseLeaveSC1;
            E1.MouseEnter += OnMouseEnterE1; E1.MouseLeave += OnMouseLeaveE1;
            Biog1.MouseEnter += OnMouseEnterBiog1; Biog1.MouseLeave += OnMouseLeaveBiog1;

            an_nr1.MouseEnter += OnMouseEnteran1;
            an_nr2.MouseEnter += OnMouseEnteran2;


            next11.MouseEnter += OnMouseEnternext11;next11.MouseLeave += OnMouseLeavenext11;
            next12.MouseEnter += OnMouseEnternext11; next12.MouseLeave += OnMouseLeavenext11;


            prev11.MouseEnter += OnMouseEnterprev11; prev11.MouseLeave += OnMouseLeaveprev11;
            prev12.MouseEnter += OnMouseEnterprev11; prev12.MouseLeave += OnMouseLeaveprev11;

            error1.Visible = false;




            susjos.BackgroundImage = Properties.Resources.sus_c1;
            
            //panel1.MouseEnter += OnMouseEnterpanel1;

            for (i = an1; i <= an2; i++) C1.Items.Add(i);
            for (i = an1; i <= an2; i++) C2.Items.Add(i);


            Prev.Visible = false;


            v[1840] = 1;
            for (i = 1841; i <= 1853; i++) v[i] = 2;
            v[1854] = 4;
            for (i = 1855; i <= 1856; i++) v[i] = 5;
            v[1857] = 6;
            for (i = 1859; i <= 1860; i++) v[i] = 7;

            for(i=1861;i<=1862;i++)v[i]=8;


            for (i = 1863; i <= 1866; i++) v[i] = 9;

            v[1867] = 10;
            for (i = 1868; i <= 1869; i++) v[i] = 11;
            
            for (i = 1870; i <= 1871; i++) v[i] = 13;

            for (i = 1872; i <= 1876; i++) v[i] = 14;


            v[1877] = 15;
            for (i = 1877; i <= 1879; i++) v[i] = 16;

            for (i = 1880; i <= 1881; i++) v[i] = 17;

            for (i = 1882; i <= 1884; i++) v[i] = 18;

            v[1885] = 19;
            v[1886] = 22;
           
            for (i = 1887; i <= 1888; i++) v[i] = 24;

            for (i = 1889; i <= 1891; i++) v[i] = 25;

            for (i = 1892; i <= 1893; i++) v[i] = 27;

            v[1894] = 28;

            for (i = 1895; i <= 1896; i++) v[i] = 29;

            v[1897] = 30;
            for(i=1898;i<=1901;i++)v[i]=32;


            for (i = 1902; i <= 1903; i++) v[i] = 34;

            for (i = 1904; i <= 1905; i++) v[i] = 36;

            for (i = 1906; i <= 1908; i++) v[i] = 37;

            for (i = 1909; i <= 1910; i++) v[i] = 38;

            v[1911] = 39;

            for (i = 1912; i <= 1913; i++) v[i] = 40;

            v[1914] = 41;

            for (i = 1915; i <= 1917; i++) v[i] = 43;

            for (i = 1918; i <= 1920; i++) v[i] = 44;

            for (i = 1921; i <= 1922; i++) v[i] = 45;

            for (i = 1923; i <= 1924; i++) v[i] = 46;

            for (i = 1925; i <= 1928; i++) v[i] = 47;

            for (i = 1929; i <= 1930; i++) v[i] = 48;

            v[1931] = 49;

            v[1932] = 51;

            for (i = 1933; i <= 1935; i++) v[i] = 53;


            v[1936] = 55;

            for (i = 1937; i <= 1944; i++) v[i] = 58;

            v[1945]= 59;

            for (i = 1946; i <= 1947; i++) v[i] = 60;

            v[1948] = 61;

            for (i = 1949; i <= 1952; i++) v[i] = 62;

            for (i = 1953; i <= 1956; i++) v[i] = 63;

            v[1957] = 64;
            v[1958] = 66;
            v[1959] = 69;

            v[1960] = 71;
            v[1961] = 72;
            for (i = 1962; i <= 1964; i++) v[i] = 77;
            v[1965] = 78;
            for (i=1966; i <= 1968; i++) v[i] = 81;
            v[1969] = 83;
            for (i = 1970; i <= 1971; i++) v[i] = 84;
            v[1972] = 86;
            for (i = 1973; i <= 1975; i++) v[i] = 87;
            v[1976] = 88;
            v[1977] = 89;
            v[1978] = 90;
            for (i = 1979; i <= 1982; i++) v[i] = 91;
            for (i = 1983; i <= 1984; i++) v[i] = 92;
            v[1985] = 93;
            v[1986]= 93;
            v[1987] = 96;
            v[1988] = 97;
            v[1989] = 98;
            v[1990] = 99;
            for (i =1991; i <=1994;i++)v[i] = 100;
            for (i = 1995; i <= 1996; i++) v[i] = 101;
            for (i = 1997; i <= 1998; i++) v[i] = 103;
            v[1999] = 104;





            an_event[1] = 1840;
            an_event[2] = 1853;
            an_event[3] = 1853;
            an_event[4] = 1854;
            an_event[5] = 1856;
            an_event[6] = 1857;
            an_event[7] = 1860;
            an_event[8] = 1862;
            an_event[9] = 1866;
            an_event[10] = 1867;
            an_event[11] = 1869;
            an_event[12] = 1869;
            an_event[13] = 1871;
            an_event[14] = 1876;



            an_event[15] = 1877;
            an_event[16] = 1879;
            an_event[17] = 1881;
            an_event[18] = 1884;
            an_event[19] = 1885;
            an_event[20] = 1885;
            an_event[21] = 1885;
            an_event[22] = 1886;
            an_event[23] = 1886;
            an_event[24] = 1876;
            an_event[25] = 1888;
            an_event[26] = 1891;
            an_event[27] = 1891;
            an_event[28] = 1893;
            an_event[29] = 1894;
            an_event[30] = 1896;
            an_event[31] = 1897;
            an_event[32] = 1897;
            an_event[33] = 1901;
            an_event[34] = 1903;
            an_event[35] = 1903;
            an_event[36] = 1905;
            an_event[37] = 1908;
            an_event[38] = 1910;
            an_event[39] = 1911;
            an_event[40] = 1913;
            an_event[41] = 1914;
            an_event[42] = 1914;
            an_event[43] = 1917;
            an_event[44] = 1920;
            an_event[45] = 1922;
            an_event[46] = 1924;
            an_event[47] = 1928;
            an_event[48] = 1930;
            an_event[49] = 1931;
            an_event[50] = 1931;
            
            an_event[51] = 1932;
            an_event[52] = 1932;
            an_event[53] = 1935;
            an_event[54] = 1935;
            an_event[55] = 1936;
            an_event[56] = 1936;
            an_event[57] = 1936;
            an_event[58] = 1944;
            an_event[59] = 1945;
            an_event[60] = 1947;

            an_event[61] = 1948;
            an_event[62] = 1952;
            an_event[63] = 1956;
            an_event[64] = 1957;
            an_event[65] = 1957;
            an_event[66] = 1958;
            an_event[67] = 1958;
            an_event[68] = 1958;
            an_event[69] = 1959;
            an_event[70] = 1959;

            an_event[71] = 1960;
            an_event[72] = 1961;
            an_event[73] = 1961;
            an_event[74] = 1961;
            an_event[75] = 1961;

            an_event[76] = 1961;
            an_event[77] = 1964;
            an_event[78] = 1965;
            an_event[79] = 1965;
            an_event[80] = 1965;
            an_event[81] = 1968;
            an_event[82] = 1968;
            an_event[83] = 1969;
            an_event[84] = 1971;
            an_event[85] = 1971;
            an_event[86] = 1972;
            an_event[87] = 1975;
            an_event[88] = 1976;
            an_event[89] = 1977;
            an_event[90] = 1978;
            an_event[91] = 1982;
            an_event[92] = 1984;
            an_event[93] = 1985;
            an_event[94] = 1986;
            an_event[95] = 1986;
            an_event[96] = 1987;
            an_event[97] = 1988;
            an_event[98] = 1989;

            an_event[99] = 1990;
            an_event[100] = 1994;
            an_event[101] = 1996;
            an_event[102] = 1996;
            an_event[103] = 1998;
            an_event[104] = 1999;












            for (i = 1840; i <= 1860; i++) fiz[i] = 1;
            for (i = 1861; i <= 1876; i++) fiz[i] = 2;
            fiz[1877] = 3;
            for (i = 1878; i <= 1879; i++) fiz[i] = 4;
            for (i = 1880; i <= 1881; i++) fiz[i] = 5;
            for (i = 1882; i <= 1884; i++) fiz[i] = 6;
            for (i = 1885; i <= 1886; i++) fiz[i] = 7;
            for (i = 1887; i <= 1893; i++) fiz[i] = 8;
            for (i = 1894; i <= 1905; i++) fiz[i] = 9;
            for (i = 1906; i <= 1910; i++) fiz[i] = 10;
            for (i = 1911; i <= 1917; i++) fiz[i] = 11;
            for (i = 1918; i <= 1924; i++) fiz[i] = 12;
            for (i = 1925; i <= 1930; i++) fiz[i] = 13;
            for (i = 1931; i <= 1959; i++) fiz[i] = 14;
            for (i = 1960; i <= 1988; i++) fiz[i] = 15;

            an_fiz[1] = 1860;
            an_fiz[2] = 1876;
            an_fiz[3] = 1877;
            an_fiz[4] = 1879;
            an_fiz[5] = 1881;
            an_fiz[6] = 1884;
            an_fiz[7] = 1886;
            an_fiz[8] = 1893;
            an_fiz[9] = 1905;
            an_fiz[10] = 1910;
            an_fiz[11] = 1917;
            an_fiz[12] = 1924;
            an_fiz[13] = 1930;
            an_fiz[14] = 1959;
            an_fiz[15] = 1988;







           
            ch[1840] = 1;
            for (i = 1841; i <= 1856; i++) ch[i] = 2;
            ch[1857] = 3;
            for (i = 1858; i <= 1867; i++) ch[i] = 4;
            for (i = 1868; i <= 1869; i++) ch[i] = 5;
            for (i = 1870; i <= 1886; i++)ch[i] = 6;
            for (i = 1887; i <= 1894; i++) ch[i] = 7;
            for (i = 1895; i <= 1897; i++) ch[i] = 8;
            for (i = 1898; i <= 1903; i++) ch[i] = 9;
            for (i = 1904; i <= 1914; i++) ch[i] = 10;
            for (i = 1915; i <= 1932; i++) ch[i] = 11;
            for (i = 1933; i <= 1935; i++) ch[i] = 12;

            an_ch[1] = 1840;
            an_ch[2] = 1856;
            an_ch[3] = 1857;
            an_ch[4] = 1867;
            an_ch[5] = 1869;
            an_ch[6] = 1866;
            an_ch[7] = 1894;
            an_ch[8] = 1897;
            an_ch[9] = 1903;
            an_ch[10] = 1914;
            an_ch[11] = 1932;
            an_ch[12] = 1935;








            for (i = 1840; i <= 1853; i++) biol[i] = 1;
            for (i = 1854; i <= 1885; i++) biol[i] = 2;
            for (i = 1886; i <= 1891; i++) biol[i] = 4;
            for (i = 1892; i <= 1897; i++) biol[i] = 5;
            for (i = 1898; i <= 1901;i++) biol[i] = 6;
            for (i = 1902; i <= 1908; i++) biol[i] = 7;
            for (i = 1909; i <= 1922; i++) biol[i] = 8;
            for (i = 1923; i <= 1928; i++) biol[i] = 9;
            for (i = 1929; i <= 1931; i++) biol[i] = 10;
            for (i = 1932; i <= 1952; i++) biol[i] = 11;
            for (i = 1953; i <= 1978; i++) biol[i] = 12;
            for (i = 1979; i <= 1996; i++) biol[i] = 13;

            an_bio[1] = 1853;
            an_bio[2] = an_bio[3] = 1885;
            an_bio[4] = 1891;
            an_bio[5] = 1897;
            an_bio[6] = 1901;
            an_bio[7] = 1908;
            an_bio[8] = 1922;
            an_bio[9] =1928;
            an_bio[10] = 1931;
            an_bio[11]=1952;
            an_bio[12] = 1978;
            an_bio[13] = an_bio[14] = 14;

                



            for (i = 1840; i <= 1866; i++) earth[i] = 1;
            for (i = 1867; i <= 1911; i++) earth[i] = 2;
            for (i = 1912; i <= 1913; i++) earth[i] = 3;
            for (i = 1914; i <= 1960; i++) earth[i] = 4;
            earth[1961] = 5;
            for (i = 1962; i <= 1965; i++) earth[i] = 6;
            for (i = 1966; i <= 1976; i++) earth[i] = 7;
            earth[1977] = 8;
            for (i = 1978; i <= 1986; i++) earth[i] = 9;
            earth[1987] = 11;
            for (i = 1988; i <= 1994; i++) earth[i] = 12;

            an_earth[1] = 1866;
            an_earth[2] = 1911;
            an_earth[3] = 1913;
            an_earth[4] = 1960;
            an_earth[5] = 1961;
            an_earth[6] = 1965;
            an_earth[7] = 1976;
            an_earth[8] = 1977;
            an_earth[9] = 1986;
            an_earth[10] = 1986;
            an_earth[11] = 1987;
            an_earth[12] = 1994;

            an_earth[13] = 2000;




           
            for (i = 1840; i <= 1876; i++) coms[i] = 1;
            for (i = 1877; i <= 1886; i++) coms[i] = 2;
            for (i = 1887; i <= 1901; i++) coms[i] = 3;
            for (i = 1902; i <= 1920; i++) coms[i] = 4;
            for (i = 1921; i <= 1931; i++) coms[i] = 5;
            coms[1932] = 6;
            for (i = 1933; i <= 1935; i++) coms[i] = 7;
            for (i = 1936; i <= 1944; i++) coms[i] = 8;
            for (i = 1945; i <= 1947; i++) coms[i] = 9;
            coms[1948] = 10;
            for (i = 1949; i <= 1956; i++) coms[i] = 11;
            for (i = 1957; i <= 1958; i++) coms[i] = 12;
            for (i = 1959; i <= 1961; i++) coms[i] = 13;
            for (i = 1962; i <= 1968; i++) coms[i] = 14;
            for (i = 1969; i <= 1971; i++) coms[i] = 16;
            for (i = 1972; i <= 1982; i++) coms[i] = 18;
            for (i = 1983; i <= 1984; i++) coms[i] = 19;
            coms[1985] = 20;
            for (i = 1986; i <= 1989; i++) coms[i] = 21;
            for (i = 1990; i <= 1999; i++) coms[i] = 22;


            an_comms[1] = 1876;
            an_comms[2] = 1886;
            an_comms[3] = 1901;
            an_comms[4] = 1920;
            an_comms[5] = 1931;
            an_comms[6] = 1932;
            an_comms[7] = 1935;
            an_comms[8] = 1944;
            an_comms[9] = 1947;
            an_comms[10] = 1948;
            an_comms[11] = 1956;
            an_comms[12] = 1958;
            an_comms[13] = 1961;
            an_comms[14] = 1968;
            an_comms[15] = 1968;
            an_comms[16] = 1971;
            an_comms[17] = 1971;
            an_comms[18] = 1982;
            an_comms[19] = 1984;
            an_comms[20] = 1985;
            an_comms[21] = 1989;
            an_comms[22] = 1999;





            for (i = 1840; i <= 1957; i++) space[i] = 1;
            space[1958] = 3;
            space[1959] = 6;
            for (i = 1960; i <= 1961; i++) space[i] = 7;
            for (i= 1962; i <= 1965; i++) space[i] = 11;
            for (i = 1966; i <= 1969; i++) space[i] = 13;
            for (i = 1970; i <= 1972; i++) space[i] = 14;
            for (i = 1973; i <= 1975; i++) space[i] = 15;
            for (i = 1976; i <= 1998; i++) space[i] = 16;

            an_space[1] = an_space[2] = 1957;
            an_space[3] =an_space[4]=an_space[5]= 1958;
            an_space[6] = 1959;
            an_space[7] =an_space[8]=an_space[9]=an_space[10]= 1961;
            an_space[11] =an_space[12]= 1965;
            an_space[13] = 1969;
            an_space[14] = 1972;
            an_space[15] = 1975;
            an_space[16] = 1998;





            for (i = 1840; i <= 1853; i++) fd[i] = 1;
            for (i = 1854; i <= 1862; i++) fd[i] = 2;
            for (i = 1863; i <= 1869; i++) fd[i] = 3;
            for (i = 1870; i <= 1891; i++) fd[i] = 4;
            for (i = 1892; i <= 1936; i++) fd[i] = 5;
            an_food[1] = 1853;
            an_food[2] = 1862;
            an_food[3] = 1869;
            an_food[4] = 1891;
            an_food[5] = 1936;

            //albastru 127, 184, 234 
            //turcuaz 114, 219, 192
            //violet 239, 224, 255
            //rosu 251, 148, 140

            pictureBox1.BackgroundImage = Properties.Resources.eror2;
            pictureBox1.Visible = false;

            frecv_eror = 1;

            /*
   * subiecte(8):
   * Toate(228, 211, 82)
   * Fizica(2,70,148)
   * Chimie(49, 22, 145)
   * Biologie(45, 81, 40)
   * Geografie si Mediu (66, 160, 40 )
   * Tehnologia Comunicatiilor  (195, 57, 29)

   * Cursa spatiala(10, 5, 53)


   * Gastronomie(213, 151, 85)

   */
            subiect.Text = "Cultura generala";
            s1 = s2 = s3 = s4 = s5 = s6 = s7 = false;
            stot = true;

            poz = 1;q = 1;
            navigare();



            //   prev12.BackColor = Color.FromArgb(0, 0, 0, 0);


            subiecte.Visible = false;
            stot = true;


          

            s1 = s2 = s3 = s4 = s5 = s6 = s7 = s8 = false;



            icon.BackgroundImage = Properties.Resources.light_bulb;
            desp.ForeColor=an_nr1.ForeColor = an_nr2.ForeColor = subiect.ForeColor = subiecte.BackColor = Color.FromArgb(228, 211, 82);
            susjos.BackgroundImage = Properties.Resources.jos_c1;
            subiect.Text = "Cultura generala";
            sub1.Text = "Fizica";
            sub2.Text = "Chimie";
            sub3.Text = "Biologie";
            sub4.Text = "Geografie si Mediu";
            sub5.Text = "Tehnologia comunicatiilor";
            sub6.Text = "Cursa spatiala";
            sub7.Text = "Gastronomie";
            sub1.ForeColor = sub2.ForeColor = sub3.ForeColor = sub4.ForeColor = sub5.ForeColor = sub6.ForeColor = sub7.ForeColor = Color.Gray;






            //  pictureBox1.BackgroundImage = Properties.Resources.mafiot;

            //       mafiamember.Visible = interogatoriu.Visible = false;

            mafiamember.BackgroundImage = Properties.Resources.mafiot;
            DA.Cursor = NU.Cursor = interogatoriu.Cursor = mafiamember.Cursor = Cursors.Hand;

            meme = 0; refuz = 0; memes = false;
            interogatoriu.Visible = DA.Visible = NU.Visible = mafiamember.Visible = false;


            interogatoriu.Visible = DA.Visible = NU.Visible = mafiamember.Visible = false;

            interogatoriu.ForeColor = Color.White;
            DA.ForeColor = NU.ForeColor = Color.White;
            DA.MouseEnter += OnMouseEnterDA; DA.MouseLeave += OnMouseLeaveDA;
            NU.MouseEnter += OnMouseEnterNU; NU.MouseLeave += OnMouseLeaveNU;


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


        void preferinte(string ti)
        {
            C1.Items.Clear();
            C2.Items.Clear();
            for(int i=1840;i<=1999;i++)
            {
                C1.Items.Add(i);
                C2.Items.Add(i);
            }
            an1 = 1840;an2 = 1999;
            an_nr1.Text = "1840";an_nr2.Text = "1999";

            sub1.ForeColor = sub2.ForeColor = sub3.ForeColor = sub4.ForeColor = sub5.ForeColor = sub6.ForeColor = sub7.ForeColor = Color.Gray;


            pictureBox1.Visible = false;
            background1.Visible = descriere1.Visible = data1.Visible = title1.Visible = imagine1.Visible = Next.Visible = Prev.Visible = true;

            background1.Visible = true;


            subiecte.Visible = false;
            if(ti== "Cultura generala")
            {
                stot = s1 = s2 = s3 = s4 = s5 = s6 = s7 = s8 = false;
                stot = true;
                icon.BackgroundImage = Properties.Resources.light_bulb;
                desp.ForeColor = an_nr1.ForeColor = an_nr2.ForeColor =subiect.ForeColor=subiecte.BackColor= Color.FromArgb(228, 211, 82);
                susjos.BackgroundImage = Properties.Resources.jos_c1;
                subiect.Text = "Cultura generala";
                sub1.Text = "Fizica";
                sub2.Text = "Chimie";
                sub3.Text = "Biologie";
                sub4.Text = "Geografie si Mediu";
                sub5.Text = "Tehnologia comunicatiilor";
                sub6.Text = "Cursa spatiala";
                sub7.Text = "Gastronomie";

              
             
            }
            else if (ti == "Fizica")
            {
                stot = s1 = s2 = s3 = s4 = s5 = s6 = s7 = s8 = false;
                s1 = true;
                icon.BackgroundImage = Properties.Resources.physics__1_;
                desp.ForeColor = an_nr1.ForeColor = an_nr2.ForeColor = subiect.ForeColor = subiecte.BackColor = Color.FromArgb(2, 70, 148);
                susjos.BackgroundImage = Properties.Resources.jos_c2;

                subiect.Text = "Fizica";
                sub1.Text = "Chimie";
                sub2.Text = "Biologie";
                sub3.Text = "Geografie si Mediu";
                sub4.Text = "Tehnologia comunicatiilor";
                sub5.Text = "Cursa spatiala";
                sub6.Text = "Gastronomie";
                sub7.Text = "Cultura generala";
              

            }
            else if (ti == "Chimie")
            {
                stot = s1 = s2 = s3 = s4 = s5 = s6 = s7 = s8 = false;
                s2 = true;
                icon.BackgroundImage = Properties.Resources.chemistry;
                desp.ForeColor = an_nr1.ForeColor = an_nr2.ForeColor = subiect.ForeColor = subiecte.BackColor = Color.FromArgb(49, 22, 145);
                susjos.BackgroundImage = Properties.Resources.jos_c3;


                subiect.Text = "Chimie";
            
                sub1.Text = "Fizica";
                sub2.Text = "Biologie";
                sub3.Text = "Geografie si Mediu";
                sub4.Text = "Tehnologia comunicatiilor";
                sub5.Text = "Cursa spatiala";
                sub6.Text = "Gastronomie";
                sub7.Text = "Cultura generala";
           

            }
            else if (ti == "Biologie")
            {

                stot = s1 = s2 = s3 = s4 = s5 = s6 = s7 = s8 = false;
                s3 = true;
                icon.BackgroundImage = Properties.Resources.microscope;
                desp.ForeColor = an_nr1.ForeColor = an_nr2.ForeColor = subiect.ForeColor = subiecte.BackColor = Color.FromArgb(45, 81, 40);
                susjos.BackgroundImage = Properties.Resources.jos_c4;


                subiect.Text = "Biologie";
                sub1.Text = "Fizica";
                sub2.Text = "Chimie";
                sub3.Text = "Geografie si Mediu";
                sub4.Text = "Tehnologia comunicatiilor";
                sub5.Text = "Cursa spatiala";
                sub6.Text = "Gastronomie";
                sub7.Text = "Cultura generala";
            
            }
            else if(ti=="Geografie si Mediu")
            {

                stot = s1 = s2 = s3 = s4 = s5 = s6 = s7 = s8 = false;
                s4 = true;
                icon.BackgroundImage = Properties.Resources.earth_globe;
                desp.ForeColor = an_nr1.ForeColor = an_nr2.ForeColor = subiect.ForeColor = subiecte.BackColor = Color.FromArgb(66, 160, 40);
                susjos.BackgroundImage = Properties.Resources.jos_c5;


                subiect.Text = "Geografie si Mediu";
                sub1.Text = "Fizica";
                sub2.Text = "Chimie";
                sub3.Text = "Biologie";
                sub4.Text = "Tehnologia comunicatiilor";
                sub5.Text = "Cursa spatiala";
                sub6.Text = "Gastronomie";
                sub7.Text = "Cultura generala";
           
            }
            else if(ti=="Tehnologia comunicatiilor")
            {

                stot = s1 = s2 = s3 = s4 = s5 = s6 = s7 = s8 = false;
                s5 = true;
                icon.BackgroundImage = Properties.Resources.communication;
                desp.ForeColor = an_nr1.ForeColor = an_nr2.ForeColor = subiect.ForeColor = subiecte.BackColor = Color.FromArgb(195, 57, 29);
                susjos.BackgroundImage = Properties.Resources.jos_c6;

                subiect.Text = "Tehnologia comunicatiilor";
                sub1.Text = "Geografie si Mediu";
                sub2.Text = "Fizica";
                sub3.Text = "Chimie";
                sub4.Text = "Biologie";
                sub5.Text = "Cursa spatiala";
                sub6.Text = "Gastronomie";
                sub7.Text = "Cultura generala";
               
            }
            else if(ti=="Cursa spatiala")
            {
                stot = s1 = s2 = s3 = s4 = s5 = s6 = s7 = s8 = false;
                s6 = true;
                icon.BackgroundImage = Properties.Resources.solar_system;
                desp.ForeColor = an_nr1.ForeColor = an_nr2.ForeColor = subiect.ForeColor = subiecte.BackColor = Color.FromArgb(10, 5, 53);
                susjos.BackgroundImage = Properties.Resources.jos_c7;
               
                
                subiect.Text = "Cursa spatiala";
                sub1.Text = "Tehnologia comunicatiilor";
                sub2.Text = "Geografie si Mediu";
                sub3.Text = "Fizica";
                sub4.Text = "Chimie";
                sub5.Text = "Biologie";
                sub6.Text = "Gastronomie";
                sub7.Text = "Cultura generala";
            }
            else if(ti== "Gastronomie")
            {
                stot = s1 = s2 = s3 = s4 = s5 = s6 = s7 = s8 = false;
                s7 = true;
                icon.BackgroundImage = Properties.Resources.frying_pan;
                desp.ForeColor=an_nr1.ForeColor = an_nr2.ForeColor = subiect.ForeColor = subiecte.BackColor = Color.FromArgb(213, 151, 85);
                susjos.BackgroundImage = Properties.Resources.jos_c8;
                subiect.Text = "Gastronomie";
              
                sub1.Text = "Fizica";
                sub2.Text = "Chimie";
                sub3.Text = "Biologie";
                sub4.Text = "Geografie si Mediu";
                sub5.Text = "Tehnologia comunicatiilor";
                sub6.Text = "Cursa spatiala";
                sub7.Text = "Cultura generala";
            }





            q = 1; poz = 1;
            navigare();

        }
        private void icon_Click(object sender, EventArgs e)
        {

            panel_sus_jos = 1 - panel_sus_jos;

            if (panel_sus_jos == 1)
            {
                stanga_output.Visible = false;
                TAB.Visible = true;
                subiecte.Visible = true;
                if (stot == true) susjos.BackgroundImage = Properties.Resources.sus_c1;
                else if (s1 == true) susjos.BackgroundImage = Properties.Resources.sus_c2;
                else if (s2 == true) susjos.BackgroundImage = Properties.Resources.sus_c3;
                else if (s3 == true) susjos.BackgroundImage = Properties.Resources.sus_c4;
                else if (s4 == true) susjos.BackgroundImage = Properties.Resources.sus_c5;
                else if (s5 == true) susjos.BackgroundImage = Properties.Resources.sus_c6;
                else if (s6 == true) susjos.BackgroundImage = Properties.Resources.sus_c7;
                else if (s7 == true) susjos.BackgroundImage = Properties.Resources.sus_c8;


               
               
            }
            else
            {
                if (stot == true) susjos.BackgroundImage = Properties.Resources.jos_c1;
                else if (s1 == true) susjos.BackgroundImage = Properties.Resources.jos_c2;
                else if (s2 == true) susjos.BackgroundImage = Properties.Resources.jos_c3;
                else if (s3 == true) susjos.BackgroundImage = Properties.Resources.jos_c4;
                else if (s4 == true) susjos.BackgroundImage = Properties.Resources.jos_c5;
                else if (s5 == true) susjos.BackgroundImage = Properties.Resources.jos_c6;
                else if (s6 == true) susjos.BackgroundImage = Properties.Resources.jos_c7;
                else if (s7 == true) susjos.BackgroundImage = Properties.Resources.jos_c8;


                subiecte.Visible = false;
                stanga_output.Visible = false;
                TAB.Visible = true;
            }
            
          
        }

        private void subiect_Click(object sender, EventArgs e)
        {
            panel_sus_jos = 1 - panel_sus_jos;

            if (panel_sus_jos == 1)
            {
                stanga_output.Visible = false;
                TAB.Visible = true;
                subiecte.Visible = true;
                if (stot == true) susjos.BackgroundImage = Properties.Resources.sus_c1;
                else if (s1 == true) susjos.BackgroundImage = Properties.Resources.sus_c2;
                else if (s2 == true) susjos.BackgroundImage = Properties.Resources.sus_c3;
                else if (s3 == true) susjos.BackgroundImage = Properties.Resources.sus_c4;
                else if (s4 == true) susjos.BackgroundImage = Properties.Resources.sus_c5;
                else if (s5 == true) susjos.BackgroundImage = Properties.Resources.sus_c6;
                else if (s6 == true) susjos.BackgroundImage = Properties.Resources.sus_c7;
                else if (s7 == true) susjos.BackgroundImage = Properties.Resources.sus_c8;


               
                
            }
            else
            {
                if (stot == true) susjos.BackgroundImage = Properties.Resources.jos_c1;
                else if (s1 == true) susjos.BackgroundImage = Properties.Resources.jos_c2;
                else if (s2 == true) susjos.BackgroundImage = Properties.Resources.jos_c3;
                else if (s3 == true) susjos.BackgroundImage = Properties.Resources.jos_c4;
                else if (s4 == true) susjos.BackgroundImage = Properties.Resources.jos_c5;
                else if (s5 == true) susjos.BackgroundImage = Properties.Resources.jos_c6;
                else if (s6 == true) susjos.BackgroundImage = Properties.Resources.jos_c7;
                else if (s7 == true) susjos.BackgroundImage = Properties.Resources.jos_c8;


                subiecte.Visible = false;
                stanga_output.Visible = false;
                TAB.Visible = true;
            }

        }


        private void susjos_Click(object sender, EventArgs e)
        {
            panel_sus_jos = 1 - panel_sus_jos;

            if (panel_sus_jos == 1)
            {
                subiecte.Visible = true;
                stanga_output.Visible = false;
                TAB.Visible = true;
                if (stot == true) susjos.BackgroundImage = Properties.Resources.sus_c1;
                else if (s1 == true) susjos.BackgroundImage = Properties.Resources.sus_c2;
                else if (s2 == true) susjos.BackgroundImage = Properties.Resources.sus_c3;
                else if (s3 == true) susjos.BackgroundImage = Properties.Resources.sus_c4;
                else if (s4 == true) susjos.BackgroundImage = Properties.Resources.sus_c5;
                else if (s5 == true) susjos.BackgroundImage = Properties.Resources.sus_c6;
                else if (s6 == true) susjos.BackgroundImage = Properties.Resources.sus_c7;
                else if (s7 == true) susjos.BackgroundImage = Properties.Resources.sus_c8;


                
            }
            else
            {
                if (stot == true) susjos.BackgroundImage = Properties.Resources.jos_c1;
                else if (s1 == true) susjos.BackgroundImage = Properties.Resources.jos_c2;
                else if (s2 == true) susjos.BackgroundImage = Properties.Resources.jos_c3;
                else if (s3 == true) susjos.BackgroundImage = Properties.Resources.jos_c4;
                else if (s4 == true) susjos.BackgroundImage = Properties.Resources.jos_c5;
                else if (s5 == true) susjos.BackgroundImage = Properties.Resources.jos_c6;
                else if (s6 == true) susjos.BackgroundImage = Properties.Resources.jos_c7;
                else if (s7 == true) susjos.BackgroundImage = Properties.Resources.jos_c8;


                subiecte.Visible = false;
                stanga_output.Visible = false;
                TAB.Visible = true;
            }

        }

        private void C1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stot == true) susjos.BackgroundImage = Properties.Resources.jos_c1;
            else if (s1 == true) susjos.BackgroundImage = Properties.Resources.jos_c2;
            else if (s2 == true) susjos.BackgroundImage = Properties.Resources.jos_c3;
            else if (s3 == true) susjos.BackgroundImage = Properties.Resources.jos_c4;
            else if (s4 == true) susjos.BackgroundImage = Properties.Resources.jos_c5;
            else if (s5 == true) susjos.BackgroundImage = Properties.Resources.jos_c6;
            else if (s6 == true) susjos.BackgroundImage = Properties.Resources.jos_c7;
            else if (s7 == true) susjos.BackgroundImage = Properties.Resources.jos_c8;
            an_nr1.Text = C1.Text;
            an1 = Convert.ToInt32(C1.Text);
            C2.Items.Clear();
            for (i = an1; i <= 1999; i++) C2.Items.Add(i);
            
            if(stot==true)
            {
                if ((an1 >= 1841 && an2 <= 1852) || (an1 >= 1855 && an2 <= 1855) || (an1 >= 1859 && an2 <= 1859) || (an1 >= 1861 && an2 <= 1861) || (an1 >= 1863 && an2 <= 1865) || (an1 >= 1868 && an2 <= 1868) || (an1 >= 1870 && an1 <= 1870) || (an1 >= 1872 && an2 <= 1875) || (an1 >= 1878 && an2 <= 1878) || (an1 >= 1880 && an2 <= 1880) || (an1 >= 1882 && an2 <= 1883) || (an1 >= 1887 && an2 <= 1887) || (an1 >= 1889 && an2 <= 1890) || (an1 >= 1892 && an2 <= 1892) || (an1 >= 1895 && an2 <= 1895) || (an1 >= 1898 && an2 <= 1900) || (an1 >= 1902 && an2 <= 1902) || (an1 >= 1904 && an2 <= 1904) || (an1 >= 1906 && an2 <= 1907) || (an1 >= 1909 && an2 <= 1909) || (an1 >= 1912 && an2 <= 1912) || (an1 >= 1915 && an2 <= 1916) || (an1 >= 2928 && an2 <= 1919) || (an1 >= 1921 && an2 <= 1921) || (an1 >= 1923 && an2 <= 1923) || (an1 >= 1925 && an2 <= 1927) || (an1 >= 1929 && an2 <= 1929) || (an1 >= 1933 && an1 <= 1934) || (an1 >= 1937 && an2 <= 1943) || (an1 >= 1946 && an2 <= 1946) || (an1 >= 1949 && an2 <= 1951) || (an1 >= 1953 && an2 <= 1955) || (an1 >= 1962 && an2 <= 1963) || (an1 >= 1966 && an2 <= 1967) || (an1 >= 1970 && an2 <= 1970) || (an1 >= 1973 && an2 <= 1974) || (an1 >= 1979 && an2 <= 1981) || (an1 >= 1983 && an2 <= 1983) || (an1 >= 1991 && an2 <= 1993) || (an1 >= 1995 && an2 <= 1995) || (an1 >= 1997 && an2 <= 1997))
                {
                    background1.Visible = descriere1.Visible = Q11.Visible = Q12.Visible = Q13.Visible = data1.Visible = title1.Visible = imagine1.Visible = Next.Visible = Prev.Visible = false;
                    pictureBox1.Visible = true;
                    ok = false;
                    error1.Visible = true;
                }
                else
                {
                    pictureBox1.Visible = false;
                    background1.Visible = descriere1.Visible = data1.Visible = title1.Visible = imagine1.Visible = Next.Visible = Prev.Visible = true;

                    background1.Visible = true;
                    Prev.Visible = false;
                    if (poz != v[an1])
                    {
                        Prev.Visible = false;
                        poz = v[an1];

                        q = 1;
                        navigare();
                    }
                }
            }else if (s1 == true) //fizica
            {
                if ((an1 >= 1840 && an2 <= 1859) || (an1 >= 1861 && an2 <= 1875) || (an1 >= 1878 && an2 <= 1878) || (an1 >= 1880 && an2 <= 1880) || (an1 >= 1882 && an2 <= 1883) || (an1 >= 1885 && an2 <= 1885) || (an1 >= 1887 && an2 <= 1892) || (an1 >= 1894 && an2 <= 1904) || (an1 >= 1906 && an2 <= 1909) || (an1 >= 1911 && an2 <= 1916) || (an1 >= 1918 && an2 <= 1923)||(an1>=1925&&an2<=1929)||(an1>=1930&&an2<=1958)||(an1>=1960&&an2<=1987)||(an1>=1989&&an2<=1999))              
                {
                    background1.Visible = descriere1.Visible = Q11.Visible = Q12.Visible = Q13.Visible = data1.Visible = title1.Visible = imagine1.Visible = Next.Visible = Prev.Visible = false;
                    pictureBox1.Visible = true;
                    ok = false;
                    error1.Visible = true;
                }else
                {
                    pictureBox1.Visible = false;
                    background1.Visible = descriere1.Visible = data1.Visible = title1.Visible = imagine1.Visible = Next.Visible = Prev.Visible = true;

                    background1.Visible = true;
                    Prev.Visible = false;
                    if (poz != fiz[an1])
                    {
                        Prev.Visible = false;
                        poz = fiz[an1];
                  
                        q = 1;
                        navigare();
                    }
                }
            }else if (s2 == true)
            {
                if ((an1 >= 1841 && an2 <= 1856) || (an1 >= 1858 && an2 <= 1866) || (an1 >= 1868 && an2 <= 1868) || (an1 >= 1870 && an2 <= 1885) || (an1 >= 1887 && an2 <= 1894) || (an1 >= 1895 && an2 <= 1896) || (an1 >= 1898 && an2 <= 1902) || (an1 >= 1904 && an2 <= 1913) || (an1 >= 2925 && an2 <= 1931) || (an1 >= 1933 && an2 <= 1934) || an1 > 1935)
                {
                    background1.Visible = descriere1.Visible = Q11.Visible = Q12.Visible = Q13.Visible = data1.Visible = title1.Visible = imagine1.Visible = Next.Visible = Prev.Visible = false;
                    pictureBox1.Visible = true;
                    ok = false;
                    error1.Visible = true;
                }
                else
                {
                    pictureBox1.Visible = false;
                    background1.Visible = descriere1.Visible = data1.Visible = title1.Visible = imagine1.Visible = Next.Visible = Prev.Visible = true;

                    background1.Visible = true;
                    Prev.Visible = false;
                    if (poz != ch[an1])
                    {
                        Prev.Visible = false;
                        poz = ch[an1];

                        q = 1;
                       
                        navigare();
                    }
                }
            }else if (s3 == true)
            {
                if ((an1 >= 1840 && an2 <= 1852) || (an1 >= 1854 && an2 <= 1884) || (an1 >= 1886 && an2 <= 1890) || (an1 >= 1892 && an2 <= 1896) || (an1 >= 1898 && an2 <= 1900) || (an1 >= 1902 && an2 <= 1907) || (an1 >= 1909 && an2 <= 1922) || (an1 >= 1923 && an2 <= 1927) || (an1 >= 1929 && an2 <= 1930) || (an1 >= 1932 && an2 <= 1951) || (an1 >= 1953 && an2 <= 1977) || (an1 >= 1979 && an2 <= 1996) || an1 > 1996)
                {
                    background1.Visible = descriere1.Visible = Q11.Visible = Q12.Visible = Q13.Visible = data1.Visible = title1.Visible = imagine1.Visible = Next.Visible = Prev.Visible = false;
                    pictureBox1.Visible = true;
                    ok = false;
                    error1.Visible = true;
                }else
                {
                    pictureBox1.Visible = false;
                    background1.Visible = descriere1.Visible = data1.Visible = title1.Visible = imagine1.Visible = Next.Visible = Prev.Visible = true;

                    background1.Visible = true;
                    Prev.Visible = false;
                    if (poz != biol[an1])
                    {
                        Prev.Visible = false;
                        poz = biol[an1];

                        q = 1;
                        navigare();
                    }
                }

            }else if(s4==true)
            {
                if ((an1 >= 1840 && an2 <= 1865) || (an1 >= 1867 && an2 <= 1910) || (an1 >= 1912 && an2 <= 1912) || (an1 >= 1914 && an2 <= 1959) || (an1 >= 1962 && an2 <= 1964) || (an1 >= 1966 && an2 <= 1975) || (an1 >= 1978 && an2 <= 1986) || (an1 >= 1988 && an2 <= 1993) || an1 > 1995)
                {
                    background1.Visible = descriere1.Visible = Q11.Visible = Q12.Visible = Q13.Visible = data1.Visible = title1.Visible = imagine1.Visible = Next.Visible = Prev.Visible = false;
                    pictureBox1.Visible = true;
                    ok = false;
                    error1.Visible = true;
                }else
                {
                    pictureBox1.Visible = false;
                    background1.Visible = descriere1.Visible = data1.Visible = title1.Visible = imagine1.Visible = Next.Visible = Prev.Visible = true;

                    background1.Visible = true;
                    Prev.Visible = false;
                    if (poz !=earth[an1])
                    {
                        Prev.Visible = false;
                        poz = earth[an1];

                        q = 1;
                        navigare();
                    }
                }
            }else if (s5 == true)
            {
                if ((an1 >= 1840 && an2 <= 1875) || (an1>=1877&&an2<=1886)||(an1>=1887&&an2<=1900)||(an1>=1902&&an2<=1919)||(an1>=1921&&an2<=1930)||(an1>=1933&&an2<=1934)||(an1>=1936&&an2<=1943)||(an1>=1945&&an2<=1946)||(an1>=1949&&an2<=1955)||(an1>=1957&&an2<=1957)||(an1>=1959&&an2<=1960)||(an1>=1962&&an2<=1967)||(an1>=1969&&an2<=1970)||(an1>=1972&&an2<=1981)||(an1>=1983&&an2<=1983)||(an1>=1986&&an2<=1988)||(an1>=1990&&an2<=1999))
                {
                    background1.Visible = descriere1.Visible = Q11.Visible = Q12.Visible = Q13.Visible = data1.Visible = title1.Visible = imagine1.Visible = Next.Visible = Prev.Visible = false;
                    pictureBox1.Visible = true;
                    ok = false;
                    error1.Visible = true;
                }
                else
                {
                    pictureBox1.Visible = false;
                    background1.Visible = descriere1.Visible = data1.Visible = title1.Visible = imagine1.Visible = Next.Visible = Prev.Visible = true;

                    background1.Visible = true;
                    Prev.Visible = false;
                   


                    if (poz != coms[an1])
                    {
                        Prev.Visible = false;
                        poz = coms[an1];

                      

                        q = 1;
                        navigare();
                    }
                }
            }else if (s6 == true)
            {
                if ((an1 >= 1840 && an2 <= 1956) || (an1 >= 1960 && an2 <= 1960) || (an1 >= 1962 && an2 <= 1964) || (an1 >= 1966 && an2 <= 1968) || (an1 >= 1970 && an2 <= 1971) || (an1 >= 1973 && an2 <= 1974) || (an1 >= 1976 && an2 <= 1997) || an1 > 1998)
                {
                    background1.Visible = descriere1.Visible = Q11.Visible = Q12.Visible = Q13.Visible = data1.Visible = title1.Visible = imagine1.Visible = Next.Visible = Prev.Visible = false;
                    pictureBox1.Visible = true;
                    ok = false;
                    error1.Visible = true;
                }else
                {
                    pictureBox1.Visible = false;
                    background1.Visible = descriere1.Visible = data1.Visible = title1.Visible = imagine1.Visible = Next.Visible = Prev.Visible = true;

                    background1.Visible = true;
                    Prev.Visible = false;



                    if (poz != space[an1])
                    {
                        Prev.Visible = false;
                        poz = space[an1];



                        q = 1;
                        navigare();
                    }
                }

              
            }else if (s7 == true)
            {
                if ((an1 >= 1840 && an2 <= 1852) || (an1 >= 1854 && an2 <= 1861) || (an1 >= 1863 && an2 <= 1868) || (an1 >= 1870 && an2 <= 1890) || (an1 >= 1892 && an2 <= 1935) || an1 > 1936)
                {
                    background1.Visible = descriere1.Visible = Q11.Visible = Q12.Visible = Q13.Visible = data1.Visible = title1.Visible = imagine1.Visible = Next.Visible = Prev.Visible = false;
                    pictureBox1.Visible = true;
                    ok = false;
                }else
                {
                    pictureBox1.Visible = false;
                    background1.Visible = descriere1.Visible = data1.Visible = title1.Visible = imagine1.Visible = Next.Visible = Prev.Visible = true;

                    background1.Visible = true;
                    Prev.Visible = false;



                    if (poz != fd[an1])
                    {
                        Prev.Visible = false;
                        poz = fd[an1];



                        q = 1;
                        navigare();
                    }
                }
            }
            



        }

        private void C2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stot == true) susjos.BackgroundImage = Properties.Resources.jos_c1;
            else if (s1 == true) susjos.BackgroundImage = Properties.Resources.jos_c2;
            else if (s2 == true) susjos.BackgroundImage = Properties.Resources.jos_c3;
            else if (s3 == true) susjos.BackgroundImage = Properties.Resources.jos_c4;
            else if (s4 == true) susjos.BackgroundImage = Properties.Resources.jos_c5;
            else if (s5 == true) susjos.BackgroundImage = Properties.Resources.jos_c6;
            else if (s6 == true) susjos.BackgroundImage = Properties.Resources.jos_c7;
            else if (s7 == true) susjos.BackgroundImage = Properties.Resources.jos_c8;
            an2 = Convert.ToInt32(C2.Text);
            an_nr2.Text = C2.Text;
           
            C1.Items.Clear();
            for (i = 1840; i <= an2; i++) C1.Items.Add(i);

            if (stot == true)
            {
                if ((an1 >= 1841 && an2 <= 1852) || (an1 >= 1855 && an2 <= 1855) || (an1 >= 1859 && an2 <= 1859) || (an1 >= 1861 && an2 <= 1861) || (an1 >= 1863 && an2 <= 1865) || (an1 >= 1868 && an2 <= 1868) || (an1 >= 1870 && an1 <= 1870) || (an1 >= 1872 && an2 <= 1875) || (an1 >= 1878 && an2 <= 1878) || (an1 >= 1880 && an2 <= 1880) || (an1 >= 1882 && an2 <= 1883) || (an1 >= 1887 && an2 <= 1887) || (an1 >= 1889 && an2 <= 1890) || (an1 >= 1892 && an2 <= 1892) || (an1 >= 1895 && an2 <= 1895) || (an1 >= 1898 && an2 <= 1900) || (an1 >= 1902 && an2 <= 1902) || (an1 >= 1904 && an2 <= 1904) || (an1 >= 1906 && an2 <= 1907) || (an1 >= 1909 && an2 <= 1909) || (an1 >= 1912 && an2 <= 1912) || (an1 >= 1915 && an2 <= 1916) || (an1 >= 2928 && an2 <= 1919) || (an1 >= 1921 && an2 <= 1921) || (an1 >= 1923 && an2 <= 1923) || (an1 >= 1925 && an2 <= 1927) || (an1 >= 1929 && an2 <= 1929) || (an1 >= 1933 && an1 <= 1934) || (an1 >= 1937 && an2 <= 1943) || (an1 >= 1946 && an2 <= 1946) || (an1 >= 1949 && an2 <= 1951) || (an1 >= 1953 && an2 <= 1955) || (an1 >= 1962 && an2 <= 1963) || (an1 >= 1966 && an2 <= 1967) || (an1 >= 1970 && an2 <= 1970) || (an1 >= 1973 && an2 <= 1974) || (an1 >= 1979 && an2 <= 1981) || (an1 >= 1983 && an2 <= 1983) || (an1 >= 1991 && an2 <= 1993) || (an1 >= 1995 && an2 <= 1995) || (an1 >= 1997 && an2 <= 1997))
                {
                    background1.Visible = descriere1.Visible = Q11.Visible = Q12.Visible = Q13.Visible = data1.Visible = title1.Visible = imagine1.Visible = Next.Visible = Prev.Visible = false;
                    pictureBox1.Visible = true;
                    ok = false;
                    error1.Visible = true;
                }
                else
                {
                    pictureBox1.Visible = false;
                    background1.Visible = descriere1.Visible = data1.Visible = title1.Visible = imagine1.Visible = Next.Visible = Prev.Visible = true;

                    background1.Visible = true;
                    if (poz == v[an1])
                    {
                        Prev.Visible = false;
                        poz = v[an1];
                        q = 1;
                        navigare();
                    }
                    if (an_event[poz] > an2)
                    {

                        poz = v[an1];
                        q = 1;
                        navigare();
                    }
                }
            
            
            
            }else if (s1 == true)
            {
                if ((an1 >= 1840 && an2 <= 1859) || (an1 >= 1861 && an2 <= 1875) || (an1 >= 1878 && an2 <= 1878) || (an1 >= 1880 && an2 <= 1880) || (an1 >= 1882 && an2 <= 1883) || (an1 >= 1885 && an2 <= 1885) || (an1 >= 1887 && an2 <= 1892) || (an1 >= 1894 && an2 <= 1904) || (an1 >= 1906 && an2 <= 1909) || (an1 >= 1911 && an2 <= 1916) || (an1 >= 1918 && an2 <= 1923) || (an1 >= 1925 && an2 <= 1929) || (an1 >= 1930 && an2 <= 1958) || (an1 >= 1960 && an2 <= 1987) || (an1 >= 1989 && an2 <= 1999))
                {
                    background1.Visible = descriere1.Visible = Q11.Visible = Q12.Visible = Q13.Visible = data1.Visible = title1.Visible = imagine1.Visible = Next.Visible = Prev.Visible = false;
                    pictureBox1.Visible = true;
                    ok = false;
                    error1.Visible = true;
                }
                else
                {
                    pictureBox1.Visible = false;
                    background1.Visible = descriere1.Visible = data1.Visible = title1.Visible = imagine1.Visible = Next.Visible = Prev.Visible = true;

                    background1.Visible = true;
                    if (poz == fiz[an1])
                    {
                        Prev.Visible = false;
                        poz = fiz[an1];
                        q = 1;
                        navigare();
                    }
                    if (an_fiz[poz] > an2)
                    {

                        poz = fiz[an1];
                        q = 1;
                        navigare();
                    }
                }
            }
            else if (s2 == true)
            {
                if ((an1 >= 1841 && an2 <= 1856) || (an1 >= 1858 && an2 <= 1866) || (an1 >= 1868 && an2 <= 1868) || (an1 >= 1870 && an2 <= 1885) || (an1 >= 1887 && an2 <= 1894) || (an1 >= 1895 && an2 <= 1896) || (an1 >= 1898 && an2 <= 1902) || (an1 >= 1904 && an2 <= 1913) || (an1 >= 2925 && an2 <= 1931) || (an1 >= 1933 && an2 <= 1934) || an1 > 1935)
                {
                    background1.Visible = descriere1.Visible = Q11.Visible = Q12.Visible = Q13.Visible = data1.Visible = title1.Visible = imagine1.Visible = Next.Visible = Prev.Visible = false;
                    pictureBox1.Visible = true;
                    ok = false;
                    error1.Visible = true;
                }else
                {
                    pictureBox1.Visible = false;
                    background1.Visible = descriere1.Visible = data1.Visible = title1.Visible = imagine1.Visible = Next.Visible = Prev.Visible = true;

                    background1.Visible = true;
                    if (poz == ch[an1])
                    {
                        Prev.Visible = false;
                        poz = ch[an1];
                        q = 1;
                        navigare();
                    }
                    if (an_ch[poz] > an2)
                    {

                        poz = ch[an1];
                        q = 1;
                        navigare();
                    }
                }
            }else if (s3 == true)
            {
                if ((an1 >= 1840 && an2 <= 1852) || (an1 >= 1854 && an2 <= 1884) || (an1 >= 1886 && an2 <= 1890) || (an1 >= 1892 && an2 <= 1896) || (an1 >= 1898 && an2 <= 1900) || (an1 >= 1902 && an2 <= 1907) || (an1 >= 1909 && an2 <= 1922) || (an1 >= 1923 && an2 <= 1927) || (an1 >= 1929 && an2 <= 1930) || (an1 >= 1932 && an2 <= 1951) || (an1 >= 1953 && an2 <= 1977) || (an1 >= 1979 && an2 <= 1996) || an1 > 1996)
                {
                    background1.Visible = descriere1.Visible = Q11.Visible = Q12.Visible = Q13.Visible = data1.Visible = title1.Visible = imagine1.Visible = Next.Visible = Prev.Visible = false;
                    pictureBox1.Visible = true;
                    ok = false;
                    error1.Visible = true;
                }else
                {
                    pictureBox1.Visible = false;
                    background1.Visible = descriere1.Visible = data1.Visible = title1.Visible = imagine1.Visible = Next.Visible = Prev.Visible = true;

                    background1.Visible = true;
                    if (poz == biol[an1])
                    {
                        Prev.Visible = false;
                        poz = biol[an1];
                        q = 1;
                        navigare();
                    }
                    if (an_bio[poz] > an2)
                    {

                        poz = biol[an1];
                        q = 1;
                        navigare();
                    }
                }
            }
            else if(s4==true)
            {
                if ((an1 >= 1840 && an2 <= 1865) || (an1 >= 1867 && an2 <= 1910) || (an1 >= 1912 && an2 <= 1912) || (an1 >= 1914 && an2 <= 1959) || (an1 >= 1962 && an2 <= 1964) || (an1 >= 1966 && an2 <= 1975) || (an1 >= 1978 && an2 <= 1986) || (an1 >= 1988 && an2 <= 1993) || an1 > 1995)
                {
                    background1.Visible = descriere1.Visible = Q11.Visible = Q12.Visible = Q13.Visible = data1.Visible = title1.Visible = imagine1.Visible = Next.Visible = Prev.Visible = false;
                    pictureBox1.Visible = true;
                    ok = false;
                    error1.Visible = true;
                }else
                {
                    pictureBox1.Visible = false;
                    background1.Visible = descriere1.Visible = data1.Visible = title1.Visible = imagine1.Visible = Next.Visible = Prev.Visible = true;

                    background1.Visible = true;
                    if (poz == earth[an1])
                    {
                        Prev.Visible = false;
                        poz = earth[an1];
                        q = 1;
                        navigare();
                    }
                    if (an_earth[poz] > an2)
                    {

                        poz = earth[an1];
                        q = 1;
                        navigare();
                    }
                }
            }else if (s5 == true)
            {
                if ((an1 >= 1840 && an2 <= 1875) || (an1 >= 1877 && an2 <= 1886) || (an1 >= 1887 && an2 <= 1900) || (an1 >= 1902 && an2 <= 1919) || (an1 >= 1921 && an2 <= 1930) || (an1 >= 1933 && an2 <= 1934) || (an1 >= 1936 && an2 <= 1943) || (an1 >= 1945 && an2 <= 1946) || (an1 >= 1949 && an2 <= 1955) || (an1 >= 1957 && an2 <= 1957) || (an1 >= 1959 && an2 <= 1960) || (an1 >= 1962 && an2 <= 1967) || (an1 >= 1969 && an2 <= 1970) || (an1 >= 1972 && an2 <= 1981) || (an1 >= 1983 && an2 <= 1983) || (an1 >= 1986 && an2 <= 1988) || (an1 >= 1990 && an2 <= 1999))
                {
                    background1.Visible = descriere1.Visible = Q11.Visible = Q12.Visible = Q13.Visible = data1.Visible = title1.Visible = imagine1.Visible = Next.Visible = Prev.Visible = false;
                    pictureBox1.Visible = true;
                    ok = false;
                    error1.Visible = true;
                }else
                {
                    pictureBox1.Visible = false;
                    background1.Visible = descriere1.Visible = data1.Visible = title1.Visible = imagine1.Visible = Next.Visible = Prev.Visible = true;

                    background1.Visible = true;
                    if (poz == coms[an1])
                    {
                        Prev.Visible = false;
                        poz = coms[an1];
                        q = 1;
                    
                        navigare();
                    }
                    if (an_comms[poz] > an2)
                    {

                        poz = coms[an1];

                    
                        q = 1;
                   
                        navigare();
                    }
                }
            }else if (s6 == true)
            {
                if ((an1 >= 1840 && an2 <= 1956) || (an1 >= 1960 && an2 <= 1960) || (an1 >= 1962 && an2 <= 1964) || (an1 >= 1966 && an2 <= 1968) || (an1 >= 1970 && an2 <= 1971) || (an1 >= 1973 && an2 <= 1974) || (an1 >= 1976 && an2 <= 1997) || an1 > 1998)
                {
                    background1.Visible = descriere1.Visible = Q11.Visible = Q12.Visible = Q13.Visible = data1.Visible = title1.Visible = imagine1.Visible = Next.Visible = Prev.Visible = false;
                    pictureBox1.Visible = true;
                    ok = false;
                    error1.Visible = true;
                }else
                {
                    pictureBox1.Visible = false;
                    background1.Visible = descriere1.Visible = data1.Visible = title1.Visible = imagine1.Visible = Next.Visible = Prev.Visible = true;

                    background1.Visible = true;
                    if (poz == space[an1])
                    {
                        Prev.Visible = false;
                        poz = space[an1];
                        q = 1;

                        navigare();
                    }
                    if (an_space[poz] > an2)
                    {

                        poz = space[an1];


                        q = 1;

                        navigare();
                    }
                }
        
            }else if (s7 == true)
            {
                if ((an1 >= 1840 && an2 <= 1852) || (an1 >= 1854 && an2 <= 1861) || (an1 >= 1863 && an2 <= 1868) || (an1 >= 1870 && an2 <= 1890) || (an1 >= 1892 && an2 <= 1935) || an1 > 1936)
                {
                    background1.Visible = descriere1.Visible = Q11.Visible = Q12.Visible = Q13.Visible = data1.Visible = title1.Visible = imagine1.Visible = Next.Visible = Prev.Visible = false;
                    pictureBox1.Visible = true;
                    ok = false;
                }else
                {
                    pictureBox1.Visible = false;
                    background1.Visible = descriere1.Visible = data1.Visible = title1.Visible = imagine1.Visible = Next.Visible = Prev.Visible = true;

                    background1.Visible = true;
                    if (poz == fd[an1])
                    {
                        Prev.Visible = false;
                        poz = fd[an1];
                        q = 1;

                        navigare();
                    }
                    if (an_food[poz] > an2)
                    {

                        poz =fd[an1];


                        q = 1;

                        navigare();
                    }
                }
            }
         
            //rezolutie eroare:1320X570


        }
        private void OnMouseEnterpanel1(object sender, EventArgs e)
        {
            C1.Visible = C2.Visible = false;


        }

        private void OnMouseFormT1(object sender, EventArgs e)
        {
            C1.Visible = C2.Visible = false;


        }

        private void TAB_Click_1(object sender, EventArgs e)
        {
            C1.Visible = C2.Visible = false;
            ARROW.Visible = T1.Visible = E1.Visible = SC1.Visible = Biog1.Visible = true;
            stanga_output.Visible = true;
            stanga_output.BackColor = Color.FromArgb(22, 18, 88);
            TAB.Visible = false;
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            panel_sus_jos = 0;
            if (stot == true) susjos.BackgroundImage = Properties.Resources.jos_c1;
            else if (s1 == true) susjos.BackgroundImage = Properties.Resources.jos_c2;
            else if (s2 == true) susjos.BackgroundImage = Properties.Resources.jos_c3;
            else if (s3 == true) susjos.BackgroundImage = Properties.Resources.jos_c4;
            else if (s4 == true) susjos.BackgroundImage = Properties.Resources.jos_c5;
            else if (s5 == true) susjos.BackgroundImage = Properties.Resources.jos_c6;
            else if (s6 == true) susjos.BackgroundImage = Properties.Resources.jos_c7;
            else if (s7 == true) susjos.BackgroundImage = Properties.Resources.jos_c8;
            C1.Visible = C2.Visible = false;
            Prev.Visible = Next.Visible = true;
            C1.Visible = C2.Visible = false;
            stanga_output.Visible = false;
            TAB.Visible = true;

            if(stot==true)
            {
                if (an_event[poz] == an1) Prev.Visible = false;
            }else if (s1 == true)
            {
                if (an_fiz[poz] == an1) Prev.Visible = false;
            }
            
            poz--;q = 1;
            navigare();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            panel_sus_jos = 0;
            if (stot == true) susjos.BackgroundImage = Properties.Resources.jos_c1;
            else if (s1 == true) susjos.BackgroundImage = Properties.Resources.jos_c2;
            else if (s2 == true) susjos.BackgroundImage = Properties.Resources.jos_c3;
            else if (s3 == true) susjos.BackgroundImage = Properties.Resources.jos_c4;
            else if (s4 == true) susjos.BackgroundImage = Properties.Resources.jos_c5;
            else if (s5 == true) susjos.BackgroundImage = Properties.Resources.jos_c6;
            else if (s6 == true) susjos.BackgroundImage = Properties.Resources.jos_c7;
            else if (s7 == true) susjos.BackgroundImage = Properties.Resources.jos_c8;
            C1.Visible = C2.Visible = false;
            Prev.Visible = Next.Visible = true;


            C1.Visible = C2.Visible = false;
            stanga_output.Visible = false;
            TAB.Visible = true;

            poz++;q = 1;
       
            navigare();
        }
        private void Prev_Click_1(object sender, EventArgs e)
        {
            panel_sus_jos = 0;
            if (stot == true) susjos.BackgroundImage = Properties.Resources.jos_c1;
            else if (s1 == true) susjos.BackgroundImage = Properties.Resources.jos_c2;
            else if (s2 == true) susjos.BackgroundImage = Properties.Resources.jos_c3;
            else if (s3 == true) susjos.BackgroundImage = Properties.Resources.jos_c4;
            else if (s4 == true) susjos.BackgroundImage = Properties.Resources.jos_c5;
            else if (s5 == true) susjos.BackgroundImage = Properties.Resources.jos_c6;
            else if (s6 == true) susjos.BackgroundImage = Properties.Resources.jos_c7;
            else if (s7 == true) susjos.BackgroundImage = Properties.Resources.jos_c8;
            C1.Visible = C2.Visible = false;
            Prev.Visible = Next.Visible = true;


            C1.Visible = C2.Visible = false;
            stanga_output.Visible = false;
            TAB.Visible = true;
            subiecte.Visible = false;
            if (stot == true)
            {
                if (an_event[poz] == an1) Prev.Visible = false;
            }else if (s1 == true)
            {
                if (an_fiz[poz] == an1) Prev.Visible = false;
            }
           
            poz--;q = 1;
            navigare();
        }

        private void Next_Click_1(object sender, EventArgs e)
        {
            panel_sus_jos = 0;
            if (stot == true) susjos.BackgroundImage = Properties.Resources.jos_c1;
            else if (s1 == true) susjos.BackgroundImage = Properties.Resources.jos_c2;
            else if (s2 == true) susjos.BackgroundImage = Properties.Resources.jos_c3;
            else if (s3 == true) susjos.BackgroundImage = Properties.Resources.jos_c4;
            else if (s4 == true) susjos.BackgroundImage = Properties.Resources.jos_c5;
            else if (s5 == true) susjos.BackgroundImage = Properties.Resources.jos_c6;
            else if (s6 == true) susjos.BackgroundImage = Properties.Resources.jos_c7;
            else if (s7 == true) susjos.BackgroundImage = Properties.Resources.jos_c8;
            C1.Visible = C2.Visible = false;
            Prev.Visible = Next.Visible = true;

            C1.Visible = C2.Visible = false;
            stanga_output.Visible = false;
            TAB.Visible = true;

            subiecte.Visible = false;
            poz++;q = 1;

            navigare();
        }
        private void Q11_Click(object sender, EventArgs e)
        {

            if (q != 1)
            {
                if (stot == true) susjos.BackgroundImage = Properties.Resources.jos_c1;
                else if (s1 == true) susjos.BackgroundImage = Properties.Resources.jos_c2;
                else if (s2 == true) susjos.BackgroundImage = Properties.Resources.jos_c3;
                else if (s3 == true) susjos.BackgroundImage = Properties.Resources.jos_c4;
                else if (s4 == true) susjos.BackgroundImage = Properties.Resources.jos_c5;
                else if (s5 == true) susjos.BackgroundImage = Properties.Resources.jos_c6;
                else if (s6 == true) susjos.BackgroundImage = Properties.Resources.jos_c7;
                else if (s7 == true) susjos.BackgroundImage = Properties.Resources.jos_c8;
                if (stot == true) susjos.BackgroundImage = Properties.Resources.jos_c1;
                else if (s1 == true) susjos.BackgroundImage = Properties.Resources.jos_c2;
                else if (s2 == true) susjos.BackgroundImage = Properties.Resources.jos_c3;
                else if (s3 == true) susjos.BackgroundImage = Properties.Resources.jos_c4;
                else if (s4 == true) susjos.BackgroundImage = Properties.Resources.jos_c5;
                else if (s5 == true) susjos.BackgroundImage = Properties.Resources.jos_c6;
                else if (s6 == true) susjos.BackgroundImage = Properties.Resources.jos_c7;
                else if (s7 == true) susjos.BackgroundImage = Properties.Resources.jos_c8;
                C1.Visible = C2.Visible = false;
                Q11.ButtonColor = Color.MediumBlue;
                Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(228, 211, 82);

                C1.Visible = C2.Visible = false;
                stanga_output.Visible = false;
                TAB.Visible = true;

                q = 1;
                navigare();
            }


        }
        private void Q11_Click_1(object sender, EventArgs e)
        {
         if(q!=1)
            {
                panel_sus_jos = 0;
                if (stot == true) susjos.BackgroundImage = Properties.Resources.jos_c1;
                else if (s1 == true) susjos.BackgroundImage = Properties.Resources.jos_c2;
                else if (s2 == true) susjos.BackgroundImage = Properties.Resources.jos_c3;
                else if (s3 == true) susjos.BackgroundImage = Properties.Resources.jos_c4;
                else if (s4 == true) susjos.BackgroundImage = Properties.Resources.jos_c5;
                else if (s5 == true) susjos.BackgroundImage = Properties.Resources.jos_c6;
                else if (s6 == true) susjos.BackgroundImage = Properties.Resources.jos_c7;
                else if (s7 == true) susjos.BackgroundImage = Properties.Resources.jos_c8;
                if (stot == true) susjos.BackgroundImage = Properties.Resources.jos_c1;
                else if (s1 == true) susjos.BackgroundImage = Properties.Resources.jos_c2;
                else if (s2 == true) susjos.BackgroundImage = Properties.Resources.jos_c3;
                else if (s3 == true) susjos.BackgroundImage = Properties.Resources.jos_c4;
                else if (s4 == true) susjos.BackgroundImage = Properties.Resources.jos_c5;
                else if (s5 == true) susjos.BackgroundImage = Properties.Resources.jos_c6;
                else if (s6 == true) susjos.BackgroundImage = Properties.Resources.jos_c7;
                else if (s7 == true) susjos.BackgroundImage = Properties.Resources.jos_c8;
                subiecte.Visible = false;
                C1.Visible = C2.Visible = false;
                Q11.ButtonColor = Color.MediumBlue;
                Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(228, 211, 82);

                C1.Visible = C2.Visible = false;
                stanga_output.Visible = false;
                TAB.Visible = true;

                q = 1;
                navigare();
            }
                
            
           
        }

       
        private void Q12_Click(object sender, EventArgs e)
        {


            if (q != 2)
            {
                if (stot == true) susjos.BackgroundImage = Properties.Resources.jos_c1;
                else if (s1 == true) susjos.BackgroundImage = Properties.Resources.jos_c2;
                else if (s2 == true) susjos.BackgroundImage = Properties.Resources.jos_c3;
                else if (s3 == true) susjos.BackgroundImage = Properties.Resources.jos_c4;
                else if (s4 == true) susjos.BackgroundImage = Properties.Resources.jos_c5;
                else if (s5 == true) susjos.BackgroundImage = Properties.Resources.jos_c6;
                else if (s6 == true) susjos.BackgroundImage = Properties.Resources.jos_c7;
                else if (s7 == true) susjos.BackgroundImage = Properties.Resources.jos_c8;
                C1.Visible = C2.Visible = false;
                Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                Q13.ButtonColor = Color.FromArgb(228, 211, 82);

                C1.Visible = C2.Visible = false;
                stanga_output.Visible = false;
                TAB.Visible = true; q = 2;
                q = 2;
                navigare();
            }



        }
        private void Q12_Click_1(object sender, EventArgs e)
        {

            if(q!=2)
            {
                panel_sus_jos = 0;
                if (stot == true) susjos.BackgroundImage = Properties.Resources.jos_c1;
                else if (s1 == true) susjos.BackgroundImage = Properties.Resources.jos_c2;
                else if (s2 == true) susjos.BackgroundImage = Properties.Resources.jos_c3;
                else if (s3 == true) susjos.BackgroundImage = Properties.Resources.jos_c4;
                else if (s4 == true) susjos.BackgroundImage = Properties.Resources.jos_c5;
                else if (s5 == true) susjos.BackgroundImage = Properties.Resources.jos_c6;
                else if (s6 == true) susjos.BackgroundImage = Properties.Resources.jos_c7;
                else if (s7 == true) susjos.BackgroundImage = Properties.Resources.jos_c8;
                subiecte.Visible = false;
                C1.Visible = C2.Visible = false;
                Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                Q13.ButtonColor = Color.FromArgb(228, 211, 82);

                C1.Visible = C2.Visible = false;
                stanga_output.Visible = false;
                TAB.Visible = true; q = 2;
                q = 2;
                navigare();
            }
              
            
            
        }

      
        private void Q13_Click(object sender, EventArgs e)
        {

            if (q != 3)
            {
                C1.Visible = C2.Visible = false;
                Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.MediumBlue;

                C1.Visible = C2.Visible = false;
                stanga_output.Visible = false;
                TAB.Visible = true;
                q = 3;
                navigare();
            }

        }
        private void Q13_Click_1(object sender, EventArgs e)
        {
           if(q!=3)
            {
                panel_sus_jos = 0;
                subiecte.Visible = false;
                C1.Visible = C2.Visible = false;
                Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.MediumBlue;

                C1.Visible = C2.Visible = false;
                stanga_output.Visible = false;
                TAB.Visible = true;
                q = 3;
                navigare();
            }
               
            
            
        }
        private void ARROW_Click(object sender, EventArgs e)
        {
            panel_sus_jos = 0;
            C1.Visible = C2.Visible = false;
            stanga_output.Visible = false;
            TAB.Visible = true;

            if (stot == true) susjos.BackgroundImage = Properties.Resources.jos_c1;
            else if (s1 == true) susjos.BackgroundImage = Properties.Resources.jos_c2;
            else if (s2 == true) susjos.BackgroundImage = Properties.Resources.jos_c3;
            else if (s3 == true) susjos.BackgroundImage = Properties.Resources.jos_c4;
            else if (s4 == true) susjos.BackgroundImage = Properties.Resources.jos_c5;
            else if (s5 == true) susjos.BackgroundImage = Properties.Resources.jos_c6;
            else if (s6 == true) susjos.BackgroundImage = Properties.Resources.jos_c7;
            else if (s7 == true) susjos.BackgroundImage = Properties.Resources.jos_c8;
        }

        private void E1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void Biog1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form5 = new Form5();
            form5.Closed += (s, args) => this.Close();
            form5.Show();
        }

        private void SC1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form6 = new Form6();
            form6.Closed += (s, args) => this.Close();
            form6.Show();
        }

        private void T1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void descriere1_Click(object sender, EventArgs e)
        {

        }

        private void title1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void sub1_Click(object sender, EventArgs e)
        {
            preferinte(sub1.Text);
        }

        private void sub2_Click(object sender, EventArgs e)
        {
            preferinte(sub2.Text);
        }

        private void sub3_Click(object sender, EventArgs e)
        {
            preferinte(sub3.Text);
        }

        private void sub4_Click(object sender, EventArgs e)
        {
            preferinte(sub4.Text);
        }

        private void sub5_Click(object sender, EventArgs e)
        {
            preferinte(sub5.Text);
        }

        private void sub6_Click(object sender, EventArgs e)
        {
            preferinte(sub6.Text);
        }

        private void sub7_Click(object sender, EventArgs e)
        {
            preferinte(sub7.Text);
        }

        private void an_nr1_Click(object sender, EventArgs e)
        {

        }

        private void next12_Click(object sender, EventArgs e)
        {
    
            urmatorul();
           
        }

     

        private void next11_Click(object sender, EventArgs e)
        {
            urmatorul();
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

        private void mafiamember_Click(object sender, EventArgs e)
        {
            meme++; afis_meme();
        }

        private void prev12_Click(object sender, EventArgs e)
        {
            predecesorul();
          
        }

        private void prev11_Click(object sender, EventArgs e)
        {
            predecesorul();
        }

    

      
        void urmatorul()
        {

            panel_sus_jos = 0;
            if (stot == true) susjos.BackgroundImage = Properties.Resources.jos_c1;
            else if (s1 == true) susjos.BackgroundImage = Properties.Resources.jos_c2;
            else if (s2 == true) susjos.BackgroundImage = Properties.Resources.jos_c3;
            else if (s3 == true) susjos.BackgroundImage = Properties.Resources.jos_c4;
            else if (s4 == true) susjos.BackgroundImage = Properties.Resources.jos_c5;
            else if (s5 == true) susjos.BackgroundImage = Properties.Resources.jos_c6;
            else if (s6 == true) susjos.BackgroundImage = Properties.Resources.jos_c7;
            else if (s7 == true) susjos.BackgroundImage = Properties.Resources.jos_c8;
            if (stot == true)
            {
                if (q + 1 <= 3 && (poz == 18 || poz == 33 || poz == 76 || poz == 77))
                {
                    subiecte.Visible = false;
                    stanga_output.Visible = false; TAB.Visible = true;
                    q++;
                    navigare();
                }


                if (q + 1 <= 2 && (poz == 4 || poz == 5 || poz == 6 || poz == 10 || poz == 11 || poz == 16 || poz == 21 || poz == 39 || poz == 40 || poz == 58 || poz == 60 || poz == 64 || poz == 65 || poz == 66 || poz == 67 || poz == 68 || poz == 71 || poz == 72 || poz == 73 || poz == 74 || poz == 79 || poz == 83 || poz == 93))
                {
                    subiecte.Visible = false;
                    stanga_output.Visible = false; TAB.Visible = true;
                    q++;
                    navigare();
                }
            }
            else if (s1 == true)
            {
                if (q + 1 <= 3 && poz == 6)
                {
                    subiecte.Visible = false;
                    stanga_output.Visible = false; TAB.Visible = true;
                    q++;
                    navigare();
                }

                if (q + 1 <= 2 && poz == 4)
                {
                    subiecte.Visible = false;
                    stanga_output.Visible = false; TAB.Visible = true;
                    q++;
                    navigare();
                }
            }
            else if (s2 == true)
            {
                if (q + 1 <= 2 && (poz == 2 || poz == 3 || poz == 4))
                {
                    subiecte.Visible = false;
                    stanga_output.Visible = false; TAB.Visible = true;
                    q++;
                    navigare();
                }
            }
            else if (s3 == true)
            {

            }else if (s4 == true)
            {
                if(q+1<=2&& (poz == 2 || poz == 3 || poz == 4))
                {
                    subiecte.Visible = false;
                    stanga_output.Visible = false; TAB.Visible = true;
                    q++;
                    navigare();
                }

                if(q+1<=3&& poz == 5)
                {
                    subiecte.Visible = false;
                    stanga_output.Visible = false; TAB.Visible = true;
                    q++;
                    navigare();
                }
            }else if (s5 == true)
            {
                if (q + 1 <= 2 && (poz==8||poz==9||poz==12||poz==20))
                {
                    subiecte.Visible = false;
                    stanga_output.Visible = false; TAB.Visible = true;
                    q++;
                    navigare();
                }

                if (q + 1 <= 3 && poz == 3)
                {
                    subiecte.Visible = false;
                    stanga_output.Visible = false; TAB.Visible = true;
                    q++;
                    navigare();
                }
            }else if (s6 == true)
            {
                if (q + 1 <= 2 && (poz == 1 || poz == 2 || poz == 3 || poz == 4 || poz == 8 || poz == 9 || poz == 10 || poz == 12 || poz == 13))
                {
                    subiecte.Visible = false;
                    stanga_output.Visible = false; TAB.Visible = true;
                    q++;
                    navigare();
                }
            }else if (s7 == true)
            {
                if (q + 1 <= 2 && poz == 3)
                {
                    subiecte.Visible = false;
                    stanga_output.Visible = false; TAB.Visible = true;
                    q++;
                    navigare();
                }
            }
        }

        void predecesorul()
        {
            panel_sus_jos = 0;

            if (stot == true) susjos.BackgroundImage = Properties.Resources.jos_c1;
            else if (s1 == true) susjos.BackgroundImage = Properties.Resources.jos_c2;
            else if (s2 == true) susjos.BackgroundImage = Properties.Resources.jos_c3;
            else if (s3 == true) susjos.BackgroundImage = Properties.Resources.jos_c4;
            else if (s4 == true) susjos.BackgroundImage = Properties.Resources.jos_c5;
            else if (s5 == true) susjos.BackgroundImage = Properties.Resources.jos_c6;
            else if (s6 == true) susjos.BackgroundImage = Properties.Resources.jos_c7;
            else if (s7 == true) susjos.BackgroundImage = Properties.Resources.jos_c8;
            if (q > 1)
                {
                    subiecte.Visible = false;
                    stanga_output.Visible = false; TAB.Visible = true;
                    q--;
                    navigare();
                }
            
          
        }
        private void TAB_Click(object sender, EventArgs e)
        {
            meme = 1;
            afis_meme();

            panel_sus_jos = 0;
            stanga_output.Visible = true;
            E1.Visible = SC1.Visible = T1.Visible = Biog1.Visible = true;
            TAB.Visible = false;
            subiecte.Visible = false;

           
            if (stot == true) susjos.BackgroundImage = Properties.Resources.jos_c1;
            else if(s1==true) susjos.BackgroundImage = Properties.Resources.jos_c2;
            else if(s2==true) susjos.BackgroundImage = Properties.Resources.jos_c3;
            else if(s3==true) susjos.BackgroundImage = Properties.Resources.jos_c4;
            else if(s4==true) susjos.BackgroundImage = Properties.Resources.jos_c5;
            else if(s5==true) susjos.BackgroundImage = Properties.Resources.jos_c6;
            else if(s6==true) susjos.BackgroundImage = Properties.Resources.jos_c7;
            else if(s7==true) susjos.BackgroundImage = Properties.Resources.jos_c8;

        }

        private void OnMouseEnteran1(object sender, EventArgs e)
        {
            C2.Visible = false;
            C1.Visible = true;

        }

        private void OnMouseEnteran2(object sender, EventArgs e)
        {
            C2.Visible = true;
            C1.Visible = false;

        }



        void navigare()
        {
            a1 = Convert.ToString(an1);
            a2 = Convert.ToString(an2);
            ev = Convert.ToString(nr_events);

            an_nr1.Text = Convert.ToString(a1);
           
            an_nr2.Text = Convert.ToString(a2);
           

            title1.Visible = data1.Visible = descriere1.Visible = true;


            an1 = Convert.ToInt32(an_nr1.Text);
            an2 = Convert.ToInt32(an_nr2.Text);



          

            if(ok==false)
            {
                frecv_eror++;
                if (frecv_eror > 5) frecv_eror = 1;

                if (frecv_eror == 1) pictureBox1.BackgroundImage = Properties.Resources.eror2;
                else if (frecv_eror == 2) pictureBox1.BackgroundImage = Properties.Resources.eror3;
                else if (frecv_eror == 3) pictureBox1.BackgroundImage = Properties.Resources.eror4;
                else if (frecv_eror == 4) pictureBox1.BackgroundImage = Properties.Resources.eror5;
                else if (frecv_eror == 5) pictureBox1.BackgroundImage = Properties.Resources.eroare6;
                
            }
            error1.Visible = false;
            ok = true;
            Prev.Visible = Next.Visible = true;


  




            if (stot == true)
            {
                if (v[an1] == poz) Prev.Visible = false;
                if (an_event[poz + 1] > an2) Next.Visible = false;
            }
            else if (s1 == true)
            {
                if (fiz[an1] == poz) Prev.Visible = false;
                if (an_fiz[poz + 1] > an2) Next.Visible = false;
            }else if (s2 == true)
            {
                if (ch[an1] == poz) Prev.Visible = false;
                if (an_ch[poz + 1] > an2) Next.Visible = false;
            }else if (s3 == true)
            {
                if (biol[an1] == poz) Prev.Visible = false;
                if (biol[poz + 1] > an2) Next.Visible = false;
            }
            else if (s4 == true)
            {
                if (earth[an1] == poz) Prev.Visible = false;
                if (earth[poz + 1] > an2) Next.Visible = false;
            }else if (s5 == true)
            {
                if (coms[an1] == poz) Prev.Visible = false;
                if (an_comms[poz + 1] > an2) Next.Visible = false;
            }else if (s6 == true)
            {
                if (space[an1] == poz) Prev.Visible = false;
                if (an_space[poz + 1] > an2) Next.Visible = false;
            }else if (s7 == true)
            {
                if (fd[an1] == poz) Prev.Visible = false;
                if (an_food[poz + 1] > an2) Next.Visible = false;
            }

            descriere1.ForeColor = title1.ForeColor = data1.ForeColor = Color.Black;

            //albastru 127, 184, 234 
            //turcuaz 114, 219, 192
            //rosulet 239, 224, 255
            //rosu 251, 148, 140
            //galben 228, 211, 82
            //verde 127, 246, 117



            next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = false;


     

            schimba_in_galben = false;





            if(s5==true)
            {
                if (an1 >= 1920 && an2 <= 1929) { poz = 4;Next.Visible = Prev.Visible = false; }
            }




            if (q == 1)
            {
                Q11.ButtonColor = Color.MediumBlue;
                Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(228, 211, 82);
            }
            
            Q11.Visible = Q12.Visible = Q13.Visible = numaratoare1.Visible = false;
            imagine1.Visible = true;
            //435X490


            next11.BackgroundImage = next12.BackgroundImage = Properties.Resources.nect_alb;
            prev11.BackgroundImage = prev12.BackgroundImage = Properties.Resources.prev_alb;




            if (stot == true)
            {



                if (poz == 1)
                {
                    if (an1 <= 1840 && an2 >= 1840)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 246, 117);

                        imagine1.BackgroundImage = Properties.Resources.stiinta1_1;
                        title1.Text = "Prima sonda de petrol";
                        data1.Text = "-1840-";
                        descriere1.Text = "  Prima sonda de petrol a fost construita in Romania.Pompele de petrol care forau de 150 de metri adancime au fost puse in functiune in anul 1840 in localitatea Lucacesti,judetul Bacau. Romania a fost si prima tara din lume cu o productie inregistrata official in statisticile internationale.Revista “The Science of Petroleum” certifica la 1938 ca tara noastra avea in 1857 o productie de 275 de tone de petrol. ";

                    }

                }
                else if (poz == 2)
                {
                    if (an1 <= 1853 && an2 >= 1853)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(239, 224, 255);
                        imagine1.BackgroundImage = Properties.Resources.stiinta2_1;
                        title1.Text = "Seringa";
                        data1.Text = "-1853-";
                        descriere1.Text = "  Primul ac hipodermic a fost realizat probabil demedicul francez  Francis Rynd la Dublin în 1844, folosind tehnologia de recoacere a marginilor unei benzi plate de oțel pliate pentru a realiza un tub." + Environment.NewLine + Environment.NewLine + "  Chiar daca Rydn a inventat acul gol din metal a fost inventat în 1844,primele dispozitive recunoscute ca seringi hipodermice au fost inventate în mod independent practic simultan în 1853 de către medicul scoțian Alexander Wood și chirurgul francez Charles Gabriel Pravaz.";
                    }

                }
                else if (poz == 3)
                {
                    if (an1 <= 1853 && an2 >= 1853)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);
                        imagine1.BackgroundImage = Properties.Resources.stiinta3_1;
                        title1.Text = "Acidul margaric";
                        data1.Text = "-1853-";
                        descriere1.Text = "  Originea margarinei incepe cu descoperirea acidului margaric, realizata de chimistul francez, Michel Eugene Cevreul, in 1813. Cercetatorii de atunci au constatat ca acidul margaric este unul din cei trei acizi grasi care, in combinatie, formau majoritatea grasimilor animale. In anul 1853, chimistul german Wilhelm Heinrich Heintz a analizat acidul margaric ca o simpla combinatiei de acid steraic si a necunoscutului acid palmitic.";
                    }
                }
                else if (poz == 4)
                {

                    if (an1 <= 1854 && an2 >= 1854)
                    {
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;
                        if (q > 2) q = 2;
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;

                        title1.Text = "Prima cale ferata din Romania";
                        data1.Text = "-20 august 1854-";
                        anactual = 1854;
                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(251, 148, 140);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta4_1;
                            numaratoare1.Text = "1 din 2";
                            descriere1.Text = "  Pe actualul teritoriu al României, prima linie a fost deschisă pe 20 august 1854 şi făcea legătura între Oraviţa (în Banat) şi Baziaş, un port la Dunăre. Având o lungime de 62,5 km, linia a fost folosită iniţial doar pentru transportul cărbunelui. Începând cu 12 ianuarie 1855, linia a fost administrată de Căile Ferate Austriece, Banatul fiind în acel timp parte a Imperiului Austriac. Relaţia Oraviţa - Baziaş a fost deschisă şi pentru traficul de pasageri la 1 noiembrie 1856, după ce au fost efectuate diverse îmbunatăţiri tehnice la linie. CFR, ca instituţie, a fost fondată în 1880, iar prima cale ferată pe teritoriul actual al României a fost deschisa în 1854.";
                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(239, 224, 255);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta4_2;
                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  Gara de Nord din Bucureşti a fost inaugurată la 10 septembrie 1868. În ianuarie 1880 Parlamentul României a votat pentru transferul liniei Vârciorova - Roman din administrarea privată a consorţiului Strousberg în administrare naţională, iar guvernul a înfiinţat instituţia Căilor Ferate Române, care continuă să existe şi astăzi,iar Prima linie dublată fusese deschisă la 25 ianuarie 1895 pe distanţa de 14 km dintre Iaşi şi Leţcani, cu scopul de a facilita lucrările de construcţie a liniei Iaşi .";

                        }
                    }
                }
                else if (poz == 5)
                {
                    if (an1 <= 1856 && an2 >= 1856)
                    {

                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;
                        if (q > 2) q = 2;
                        title1.Text = "Prima rafinarie de petrol";
                        data1.Text = "-1856-";
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        anactual = 1856;
                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 184, 234);
                            Q11.ButtonColor = Color.MediumBlue;

                            imagine1.BackgroundImage = Properties.Resources.stiinta5_1;
                            numaratoare1.Text = "1 din 2";

                            descriere1.Text = "   Romania este un pionier al rafinarii petrolului,prima rafinarie din lume a fost construita la marginea orasului Ploiesti.”Fabrica de gaz” asa cum au denumit-o intemeietorii ei-fratii Mehedinteanu- a fost ridicata in 1856,devenind prima distilerie sistematica de petrol. Rafinaria a fost inaugurata in anul 1857.Instalatiile rafinariei erau rudimentare;aceasta folosea vase cilindrice din fier/fonta pe care la incalzea cu lemne.Rafinaria avea o suprafata de doar 4 hectare,iar productia zilnica ajungea la aproape 7 tone.";

                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(251, 148, 140);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta5_2;
                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  Orasul Ploiesti a fost supranumit in secolul 19. “capitala aurului negru”. Lichidul produs la Ploiesti avea calitati deosebite: era incolor si inodor, ardea cu o flacara luminoasa de intensitate si forma constanta, fara fum si fara sa lase cenusa sau compusi rasinosi in fitil.";

                        }

                    }
                }
                else if (poz == 6)
                {
                    if (an1 <= 1857 && an2 >= 1857)
                    {
                        title1.Text = "Primul oras iluminat cu petrol lampant ";
                        data1.Text = "- 1 arpilie 1857 -";
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        anactual = 1857;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;
                        if (q > 2) q = 2;
                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(228, 211, 82);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta6_1;
                            numaratoare1.Text = "1 din 2";
                            descriere1.Text = "  In 1857,Bucurestiul a fost primul oras iluminat cu petrol lampant.în Bucureşti erau peste 785 de felinare alimentate cu petrol lampant, urmând ca – la începutul secolului 20 – să existe 3.060 de felinare cu petrol, 990 cu ulei mineral, 400 cu gaz aerian şi 200 cu becuri electrice, numite şi „lămpi cu arc voltaic”.";
                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 184, 234);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta6_2;
                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  Fraţii Mehedinteanu au reuşit să ofere servicii de iluminat cu petrol lampant pentru 336 de lei pentru fiecare felinar.Aşadar, de pe 1 aprilie 1857, Bucureştiul era iluminat cu 1.000 de astfel de lămpi. Odată cu introducerea acestor lămpi, în Bucureşti a apărut o nouă meserie, cea de lampagiu.Lampagii aveau de rezolvat o muncă solicitantă, fiind nevoiţi în fiecare zi să aprină şi să stingă lămpile care luminau Bucureştiul. ";

                        }

                    }
                }
                else if (poz == 7)
                {
                    if (an1 <= 1860 && an2 >= 1860)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);

                        title1.Text = "Fonutograful";
                        data1.Text = "-9 aprilie 1860-";
                        anactual = 1860;
                        imagine1.BackgroundImage = Properties.Resources.stiinta7_1;
                        descriere1.Text = "  Un francez pe nume Edouard-Leon Scott de Martinville a inventat un dispozitiv numit „fongoraf” , iar pe data de 9 aprilie 1860 a inregistrat pe cineva cantand <<Au clair de la lune, Pierrot repondit.>>.Trebuie remarcat faptul că această reprezentare grafică nu mai putea fi citită și redată, cum se va întâmpla mai târziu la dispozitivul lui Edison.";
                    }
                }
                else if (poz == 8)
                {
                    if (an1 <= 1862 && an2 >= 1862)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 184, 234);

                        title1.Text = "Pasteurizarea";
                        data1.Text = "-20 aprilie 1862-";
                        anactual = 1862;
                        imagine1.BackgroundImage = Properties.Resources.stiinta8_1;
                        descriere1.Text = "  În 1856, un industriaş l-a rugat pe Luis Pasteur să afle de ce vinul şi berea se acresc odată cu trecerea timpului. Pasteur a demonstrat că atât fermentaţia, cât şi alterarea erau provocate tot de microorganisme. Omul de ştiinţă a prezentat o modalitate prin care se poate preîntâmpina alterarea, numită astăzi ''pasteurizare''. Încălzind vinul până la 50 de grade Celsius, sunt omorâte microorganismele care îl pot altera. Procesul de pasteurizare a fost testat cu succes la 20 aprilie 1862.";
                    }
                }
                else if (poz == 9)
                {
                    if (an1 <= 1866 && an2 >= 1866)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 246, 117);


                        title1.Text = "Ecologia";
                        data1.Text = "-1866-";
                        anactual = 1866;
                        imagine1.BackgroundImage = Properties.Resources.stiinta9_1;
                        descriere1.Text = "  Ca stiinta ,ecologia a aparut ca ramura a biologiei. In 1866 ,Ernst Heckela lansat termenul de „ecologie”, intelegand prin el studiull relatiilor dintre toate elementele mediului inconjurator. Ernst a pus atunci probema conservarii unei spceii, prin creearea unor rezervatii naturale. Cu timoul, ecologia a devenit o stiinta in sine,analizand fenomenul complex al echilibrului mediului inconjurator din punct de vedre teologic, politic si economic. ";
                    }
                }
                else if (poz == 10)
                {
                    if (an1 <= 1867 && an2 >= 1867)
                    {
                        title1.Text = "Introducerea dinamitei";
                        data1.Text = "-14 iulie 1867-";
                        anactual = 1867;
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;
                        if (q > 2) q = 2;
                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(228, 211, 82);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta10_1;
                            numaratoare1.Text = "1 din 2";

                            descriere1.Text = "  In 1867, inventatorul suedez Alfred Nobel a realizat prima demonstrație cu dinamită, în Merstham Quarry, Surrey. Cu un an înainte, el reușise să producă substanța despre care credea că este o formă a nitroglicerinei mai sigură și mai ușor de manevrat. Preocuparea sa pentru siguranță crescuse mult de când își pierduse un frate într-o explozie survenită la fabrica sa din Stockholm, în 1864. Scopul pentru care Nobel era interesat să producă dinamită era utilizarea acesteia în construcții. ";
                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(251, 148, 140);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.science10_2;
                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  După ce a încercat mai multe variante de combinații ale nitroglicerinei cu diferite tipuri de substanțe, Alfred Nobel a descoperit compusul chimic despre care era convins că va funcționa așa cum își dorise: diatomitul. Amestecată cu nitroglicerina, această rocă sedimentară silicioasă se transformă într-o pastă. După solidificare, noua substanță are aceeași forță de explozie ca a nitroglicerinei, dar este mult mai stabilă și rezistă la șocurile mecanice, ceea ce facilitează transportul și manipularea în condiții de siguranță. Alfred Nobel a denumit noua substanță ”dinamită”, cuvânt care provine din grecescul dynamis (putere, forță).";

                        }
                    }
                }
                else if (poz == 11)
                {
                    if (an1 <= 1869 && an2 >= 1869)
                    {
                        title1.Text = "Margarina ";
                        data1.Text = "-1869-";
                        anactual = 1869;
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;
                        if (q > 2) q = 2;
                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 246, 117);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta11_1;
                            numaratoare1.Text = "1 din 2";
                            descriere1.Text = "  Imparatul Napoleon al III-lea al Frantei a oferit un premiu pentru cel care putea inventa o alternativa satisfacatoare a untului, potrivita pentru a fi folosita de catre fortele armate si de catre clasele sociale inferioare.Chimistul francez, Hippolyte Mege-Mouries a inventat substanta numita “oleomargarina”, nume care a fost scurtat ulterior in “margarina”. Chimistul și-a patentat invenția în anul 1869. În 1871, Mege-Mouries și-a vândut brevetul companiei olandeze “Jurgens”, acum parte din “Unilever”.";
                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(228, 211, 82);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;

                            imagine1.BackgroundImage = Properties.Resources.stiinta11_2;
                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = " În același an, farmacistul german Benedict Klein și-a deschis prima fabrică de margarină. Principala materie prima din formulă originală a margarinei a fost grăsimea de vită, dar în anul 1871, Herny W. Bradley și-a patentat procedeul de fabricare a margarinei ce combină uleiuri vegetale cu grăsimi animale. ";

                        }
                    }
                }
                else if (poz == 12)
                {
                    if (an1 <= 1869 && an2 >= 1869)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(251, 148, 140);

                        title1.Text = "Tabelul periodic";
                        data1.Text = "-17 februarie 1869-";
                        anactual = 1869;
                        imagine1.BackgroundImage = Properties.Resources.stiinta12_1;
                        descriere1.Text = "  În 1869 chimistul rus Dimitri Mendeleev a început dezvoltarea tabelului periodic, aranjând elementele chimice după masa atomică. El a prezis descoperirea altor elemente și a lăsat spații deschise în tabelul său periodic." + Environment.NewLine + Environment.NewLine + "  Istoricii consideră de obicei un eveniment care marchează nașterea formală a tabelului periodic modern: la 17 februarie 1869, un profesor rus de chimie, Dimitri Ivanovici Mendeleev, a finalizat prima dintre numeroasele sale diagrame periodice.";
                    }
                }
                else if (poz == 13)
                {
                    if (an1 <= 1871 && an2 >= 1871)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(239, 224, 255);

                        title1.Text = "Felinare cu gaz aerian";
                        data1.Text = "-1871-";
                        anactual = 1871;
                        imagine1.BackgroundImage = Properties.Resources.stiinta13_1;
                        descriere1.Text = "  În anul 1871, spun istoricii, a fost introdus iluminatul cu gaz aerian şi încă din anul 1868 au fost montate pe străzile Bucureştiului ţevi care să asigure amplasarea a 4.000 de felinare. „În luna decembrie a anului 1871, la Capşa a fost introdus iluminatul cu gaz aerian, fiind montate opt becuri.";
                    }
                }
                else if (poz == 14)
                {
                    if (an1 <= 1876 && an2 >= 1876)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);

                        title1.Text = "Primul telefon";
                        data1.Text = "-14 februarie 1876-";
                        anactual = 1876;
                        imagine1.BackgroundImage = Properties.Resources.stiinta14_1;

                        descriere1.Text = "    În perioda 1876–1877, a apărut o nouă invenție numită telefon. Nu este ușor să se determinam cine a fost inventatorul. Atât Alexander Graham Bell, cât și Elisha Gray au depus la 14 februarie 1876 cereri de brevet independente privind telefoanele la Oficiul de Brevete din Washington." + Environment.NewLine + "    Până în 1900 existau aproape 600.000 de telefoane în sistemul telefonic al lui Bell; acest număr a ajuns la 2,2 milioane de telefoane până în 1905 și 5,8 milioane până în 1910. În 1915 a început să funcționeze linia telefonică transcontinentală.";



                    }



                }
                else if (poz == 15)
                {
                    if (an1 <= 1877 && an2 >= 1877)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);

                        title1.Text = "Fonograful";
                        data1.Text = "-1877-";
                        anactual = 1877;
                        imagine1.BackgroundImage = Properties.Resources.stiinta15_1;
                        descriere1.Text = "  Primul fonograf a fost inventat de Thomas Edison în 1877 la laboratorul Menlo Park. O bucată de folie de tablă a fost înfășurată în jurul cilindrului din mijloc. Ai strigat un scurt mesaj în piesa de pe o parte a cilindrului în timp ce întorceai mânerul. În interiorul acestei piese era un ac. Vocea ta ar face ca acul să tremure sau să vibreze. Vibrațiile sonore ar trece prin ac și ar face o linie sau o canelură în folia de tablă. Un ac de cealaltă parte ar putea reda ceea ce tocmai ați înregistrat.";
                    }
                }
                else if (poz == 16)
                {
                    if (an1 <= 1879 && an2 >= 1879)
                    {
                        title1.Text = "Becul";
                        data1.Text = "-21 ocombrie 1879-";
                        anactual = 1879;
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;
                        if (q > 2) q = 2;
                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(228, 211, 82);
                            Q11.ButtonColor = Color.MediumBlue;

                            imagine1.BackgroundImage = Properties.Resources.stiinta16_1;
                            numaratoare1.Text = "1 din 2";
                            descriere1.Text = "  Este foarte important sa stii ca becul se mandreste cu doi inventatori care au contribuit in egala masura la aparitia acestui element revolutionar. Inventia acestuia a fost facuta de catre Thomas Edison din Statele Unite ale Americii si Sir Joseph Wilson Swan din Anglia." + Environment.NewLine + "  Sir Joseph Wilson Swan este cel care a creat becul, insa acest chimist din Regatul Unit nu a reusit sa mentina vidul interior, lucru care l-a facut Thomas Edison mai tarziu, cu ajutorul unui filament. Astfel, Sir Joseph a pus bazele acestei inventii, iar Edison a reusit sa faca un bec sa lumineze timp de 40 de ore fara incetare.";
                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(228, 211, 82);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;

                            imagine1.BackgroundImage = Properties.Resources.stiinta16_2;
                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  In urma acestei descoperiri, cele doua genii si-au unit fortele si au realizat o companie cu numele de Edison-Swan United, care a reusit sa devina cea mai mare producatoare de becuri din lume." + Environment.NewLine + "  Tot el a raspuns, in cadrul unui interviu, ceva ce a ramas un citat celebru. La intrebarea „Cum te-ai simtit cand ai dat gres de atat de multe ori in inventarea becului?”, el a raspuns: „Nu am dat gres nici macar o data. Am dovedit cu succes de 10.000 de ori cum nu se face un bec”.";

                        }
                    }
                }
                else if (poz == 17)
                {
                    if (an1 <= 1881 && an2 >= 1881)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 184, 234);

                        title1.Text = "Scaunul electric";
                        data1.Text = "-1881-";
                        anactual = 1881;
                        imagine1.BackgroundImage = Properties.Resources.stiinta17_1;
                        descriere1.Text = "  Această metodă de execuție, concepută în 1881 de un medic dentist din Buffalo, New York, numit Alfred P. Southwick, a fost dezvoltată de-a lungul anilor 1880 ca o presupusă alternativă umană la spânzurare și folosită pentru prima dată în 1890.Pana in prezent, 4.374 si-au vazut sfarsitul intr-un scaun electric si s-au inregistrat 37 de executii eronate. ";
                    }
                }
                else if (poz == 18)
                {
                    if (an1 <= 1884 && an2 >= 1884)
                    {
                        title1.Text = "Primul oras iluminat electric din Europa";
                        data1.Text = "-12 noiembrie 1884-";
                        anactual = 1884;

                        Q11.Visible = Q12.Visible = Q13.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;
                        if (q > 3) q = 3;

                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 246, 117);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta18_1;
                            numaratoare1.Text = "1 din 3";
                            descriere1.Text = "  Printre multe alte reușite ale Romaniei,se distinge și evenimentul din 12 noiembrie 1884 când, în Timișoara, au fost aprinse 731 de lămpi electrice, o premieră în Europa, lucru care a transformat orașul de pe Bega în primul oraș iluminat electric din Europa si de pe actualul teritoriu al Romaniei.";
                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(251, 148, 140);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta18_2;
                            numaratoare1.Text = "2 din 3";
                            descriere1.Text = "  În acea zi, lămpile incandescente cu filament din cărbune au iluminat un traseu stradal cu o lungime de 59 de km, o performanţă realizată în mai puţin de doi ani de către societatea Anglo-Austriacă „Bruch Electrical Company Ltd.”, cu sediul la Viena.";

                        }
                        else if (q == 3)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 184, 234);
                            Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta18_3;
                            numaratoare1.Text = "3 din 3";
                            descriere1.Text = "Luminile orasului au fost aprinse cu ajutorul uzinei hidroelectrica de pa lacul de acumulare al canalului Bega. Aceasta este una dintre primele centrale construite in Europa si prima centrala-baraj construita pe teritoriul actual al Romaniei.";

                        }


                    }
                }
                else if (poz == 19)
                {
                    if (an1 <= 1885 && an2 >= 1885)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);

                        title1.Text = "Primul tratat de bactereologie(Victor Babes)";
                        data1.Text = "-1885-";
                        anactual = 1885;
                        imagine1.BackgroundImage = Properties.Resources.stiinta19_1;
                        descriere1.Text = "  Pentru studentii de biologie,acest lucru este sigur interesant:Victor Babes a sris primul tratat de bactereologie din lume, in colaborarea cu omul de stiinta francez Victor André Cornil,in anul 1885. El a facut contributii semnificative pentru studiul leprei,a tuberculozei si a rabiei,pentru care a introdus un vaccin. Babes este considerat al doilea biologist de rabie,dupa Luis Pasteur, si parintele scleroterapiei,un precursor al imunologiei moderne";
                    }

                }
                else if (poz == 20)
                {
                    if (an1 <= 1885 && an2 >= 1885)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 184, 234);
                        title1.Text = "Vaccin pentru turbare";
                        data1.Text = "-6 iunie 1885-";
                        anactual = 1885;
                        imagine1.BackgroundImage = Properties.Resources.stiinta20_1;
                        descriere1.Text = "  Cercetările sale asupra turbării încep în 1880. Pasteur constată că măduva spinării de animal infectat uscată ar putea împiedica apariția acestei grave îmbolnăviri. După multiple încercări de a obține un preparat cu calități de vaccin și după multe ezitări, Pasteur face prima încercare la un copil mușcat de un câine turbat. La 6 iunie 1885, începe prima serie de injecții și, trei luni mai târziu, copilul este salvat.";
                    }
                }
                else if (poz == 21)
                {
                    if (an1 <= 1885 && an2 >= 1885)
                    {

                        title1.Text = "Inventarea masinii";
                        data1.Text = "-1885-";
                        anactual = 1885;
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;
                        if (q > 2) q = 2;


                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(228, 211, 82);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta21_11;
                            numaratoare1.Text = "1 din 2";

                            descriere1.Text = "   La varsta de doar cincisprezece ani, inginerul Karl Benz a incercat sa proiecteze o caruta fara cai, pentru care a muncit aproape douazeci de ani.Astfel,dupa doua decenii de dedicare, a numit primul automobil din lume “Benz Patent Motorwagen”.Spre deosebire de alti inventatorii ai vremii, Karl Benz nu a stiut cum sa isi comercializeze produsului.El,alaturi de familia lui,era singurul care stia de existent vehiculelor.";

                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 246, 117);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta21_2;
                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  Sotia lui,Bertha Benz, a preluat initiativa , pornind in 1888 alaturi de cei doi fii intr-o calatorie de 106 de km,menita sa popularizeze  inventia. Societatea dominata de biserica catolica(prea coservatoare si reticienta fata de noile inventii) era ingrozita de vehiculul pe care Bertha il conducea. ";

                        }

                    }
                }
                else if (poz == 22)
                {
                    if (an1 <= 1886 && an2 >= 1886)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 184, 234);

                        title1.Text = "Undele radio";
                        data1.Text = "-1886-";
                        anactual = 1886;
                        imagine1.BackgroundImage = Properties.Resources.stiinta21_1;
                        descriere1.Text = "  Undele radio au fost identificate și studiate pentru prima dată de către fizicianul german Heinrich Hertz în 1886. Primele emițătoare și receptoare radio practice au fost dezvoltate în jurul anului 1895–1896 de italianul Guglielmo Marconi, iar radioul a început să fie utilizat comercial în jurul anului 1900.";
                    
                    }
                }
                else if (poz == 23)
                {
                    if (an1 <= 1886 && an2 >= 1886)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);
                        title1.Text = "Radioactivitate";
                        data1.Text = "-1886-";
                        anactual = 1886;
                        imagine1.BackgroundImage = Properties.Resources.stiinta23_1;
                        descriere1.Text = "  În 1886 fizicianul francez Antoine Bequerel a descoperit prima dată radioactivitatea. Studentul Thomson din Noua Zeelandă, Ernest Rutherford, a numit trei tipuri de radiații; razele alfa, beta și gamma. Marie și Pierre Curie au început să lucreze la radiațiile de uraniu și toriu și apoi au descoperit radiul și poloniul. Au descoperit că particulele beta erau încărcate negativ.";
                    }
                }
                else if (poz == 24)
                {
                    if (an1 <= 1888 && an2 >= 1888)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);
                        title1.Text = "Prima benzinarie din istorie";
                        data1.Text = "-1888-";
                        imagine1.BackgroundImage = Properties.Resources.stiinta24_1;
                        descriere1.Text = "   Pentru a popilariza inventia sotului ei,Berthe Benz a pornit intr-o calatorie spre casa parinteasca cu masina.I-a luat Berthei Benz 12 ore pentru a finaliza drumul de 106km pana la casa parintilor ei din Pforzheim.In timpul calatoriei, sotia inginerului-a carui nume avea sa ajunga in cartile de istorie datorita faptului ca a inventat primul vehicul din lume- a ramas blocata intr-un sat din Germania. Masina se stricase.Farmacia de la care a cumparat 10 litri de ligroină avea sa devina prima benzinarie din istorie.";
                    }
                }
                else if (poz == 25)
                {
                    if (an1 <= 1891 && an2 >= 1891)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(251, 148, 140);
                        title1.Text = "Descoperirea neuronului";
                        data1.Text = "-13 iulie 1891-";
                        anactual = 1891;
                        imagine1.BackgroundImage = Properties.Resources.stiinta25_1;
                        descriere1.Text = "  Pe data de 13 iulie 1891 termenul ”neuron” a fost menționat, pentru prima dată, într-un articol științific, cu sensul de celulă a sistemului nervos. Cel care l-a ”botezat” a fost anatomistul german Heinrich Wilhelm Gottfried von Waldeyer-Hartz, în numărul din 13 iulie al publicației Berliner Klinische. Wochenschrift. Anterior, cuvântul ”neuron” mai apăruse și în alte lucrări științifice, însă cu alte sensuri. De exemplu, cercetătorul B.T. Lowne numise așa partea neuronală a ochiului compus al artropodelor.";
                    }
                }
                else if (poz == 26)
                {
                    if (an1 <= 1891 && an2 >= 1891)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);
                        title1.Text = "Pudra de copt";
                        data1.Text = "-1891-";
                        anactual = 1891;
                        imagine1.BackgroundImage = Properties.Resources.stiinta26_1;
                        descriere1.Text = "  In 1891,un chimist pe nume August Oetker impacheteaza plicuri mici de praf de copt si scrie carti de bucate care sa vand in 18,4 milioane de exemplare. La 21 septembrie 1903, Oetker a depus un brevet pentru procedura sa de fabricare a pudrei de copt de lungă durată sau a făinii gata preparate.";
                    }
                }
                else if (poz == 27)
                {
                    if (an1 <= 1893 && an2 >= 1893)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);
                        title1.Text = "Prima centrala hidroelectrica";
                        data1.Text = "-1893-";
                        anactual = 1893;
                        imagine1.BackgroundImage = Properties.Resources.stiinta27_1;
                        descriere1.Text = "  La Cascada Niagara s-a construit primă centrală hidroelectrică datorită descoperirilor lui Tesla în 1893, reușind în 1896 să transmită electricitate orașului Buffalo, New York. Cu sprijinul financiar al lui George Westinghouse, curentul alternativ l-a înlocuit pe cel continuu. Tesla a fost considerat de atunci înainte fondatorul industriei electrice.";
                    }
                }
                else if (poz == 28)
                {
                    if (an1 <= 1894 && an2 >= 1894)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(251, 148, 140);
                        title1.Text = "Gazele nobile";
                        data1.Text = "-1894-";
                        anactual = 1894;
                        imagine1.BackgroundImage = Properties.Resources.stiinta28_1;
                        descriere1.Text = "  În 1894 Sir William Ramsay și Lord Rayleigh au descoperit gazele nobile, care au fost adăugate la tabelul periodic sub forma grupului 0.";
                    }
                }
                else if (poz == 29)
                {
                    if (an1 <= 1896 && an2 >= 1896)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 184, 234);
                        title1.Text = "Primul raufacator identificat dupa amprente";
                        data1.Text = "-1896-";
                        anactual = 1896;
                        imagine1.BackgroundImage = Properties.Resources.stiinta29_1;
                        descriere1.Text = "   Nicolae Minovici a fost primul roman care a identificat un raufacator dupa amprente.In 1896, a reusit sa gaseasca un hot pe baza urmelor digitale.";
                    }
                }
                else if (poz == 30)
                {
                    if (an1 <= 1897 && an2 >= 1897)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);

                        title1.Text = "Descoperirea electronilor";
                        data1.Text = "-1897-";
                        anactual = 1897;
                        imagine1.BackgroundImage = Properties.Resources.stiinta30_1;
                        descriere1.Text = "  În 1897 fizicianul englez J. J. Thomson a descoperit mai întâi electroni; mici particule încărcate negativ într-un atom. John Townsend și Robert Millikan au reusit sa determine sarcina și masa exacta acestei particule.";
                    }
                }
                else if (poz == 31)
                {
                    if (an1 <= 1897 && an2 >= 1897)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);

                        title1.Text = "Aspirina si heroina";
                        data1.Text = "-11 si 22 august 1897-";
                        anactual = 1897;
                        imagine1.BackgroundImage = Properties.Resources.stiinta31_11;
                        descriere1.Text = "  Anul 1897 a fost anul de glorie al chimistului german Felix Hoffmann , care a devenit faimos pentru sintetizarea la data de 11 august a acestui an aspirinei,una dintre cele mai utile medicamente , iar la doar 11 zile a descoperit heroina,cea mai daunatoare subsanta narcotica." + Environment.NewLine + Environment.NewLine + "  Cele doua medicamente au fost sintetizate in laboratoarele Bayer. „Aspirina”,remediul tuturor durerilor, comercializata pentru prima dată in 1899, inițial sub formă de pulbere livrată în sticle de ochelari .";

                    }
           
                }
                else if (poz == 32)
                {
                    if (an1 <= 1901 && an2 >= 1901)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(251, 148, 140);

                        title1.Text = "Descoperirea grupelor sanguine";
                        data1.Text = "-1901-";
                        anactual = 1901;
                        imagine1.BackgroundImage = Properties.Resources.stiinta32_1;
                        descriere1.Text = "Medicul austriac Karl Landsteiner descoperă grupele sanguine, ceea ce permite realizarea de progrese medicale majore, cum ar fi transfuziile sigure și identificarea urmelor de sânge în domeniul medicinii legale. Medicul însuși avea grupa sanguină O.";

                    }

                }
                else if (poz == 33)
                {
                    if (an1 <= 1901 && an2 >= 1901)
                    {
                        title1.Text = "Primul semnal radio transmis peste Atlantic";
                        data1.Text = "-12 decembrie 1901-";
                        anactual = 1901;
                        Q11.Visible = Q12.Visible = Q13.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;

                        if (q > 3) q = 3;
                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(228, 211, 82);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta33_1;
                            numaratoare1.Text = "1 din 3";

                            descriere1.Text = "  Inventatorul și inginerul italian Guglielmo Marconi trimite primul semnal radio peste Oceanul Atlantic. Acest semnal era constituit din cele trei puncte ce formează litera „S“ în Codul Morse.Transmisia a fost realizată din Anglia către Canada și a reprezentat prima radiocomunicație transatlantică.Anterior zilei de 12 decembrie 1901, Marconi avusese o altă tentativă de a transmite un semnal peste Atlantic, dar aceasta a fost fără succes.";
                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 184, 234);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta33_2;
                            numaratoare1.Text = "2 din 3";
                            descriere1.Text = "  La 19 ianuarie 1903, el reușește să transmită primul mesaj radio transatlantic, din partea președintelui SUA, Theodore Roosevelt, către regele Angliei, Eduard al VII-lea. Tehnologia lui Marconi a primit aprecieri pentru modul în care a contribuit la salvarea a sute de persoane aflate la bordul vasului Titanic, în 1912, când a permis recepționarea unui semnal de pericol trimis de către operatorul radio al navei. În urma acestui dezastru a fost modificată legislația, pentru ca aceasta să permită îmbunătățirea comunicațiilor radio și a siguranței maritime. în 1907 Marconi a recepționat prima dată un semnal radio din Canada, și anume semnul „X” din Codul Morse.";

                        }
                        else if (q == 3)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(228, 211, 82);
                            Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta33_3;
                            numaratoare1.Text = "3 din 3";
                            descriere1.Text = "  Chiar daca stia ca Marconi foloseste tehonolgii descoperite de el,inventatorul Nikola Tesla a spus “Lasa-l sa-mi foloseasca inventiile mele.Face treaba buna.”";

                        }
                    }

                }
                else if (poz == 34)
                {
                    if (an1 <= 1903 && an2 >= 1903)
                    {

                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);

                        title1.Text = "Marie Curie";
                        data1.Text = "-10 decembrie 1903-";
                        anactual = 1903;
                        imagine1.BackgroundImage = Properties.Resources.stiinta34_1;
                        descriere1.Text = "  Marie Curie devine prima femeie care câștigă Premiul Nobel. Născută în Polonia, sub numele de Maria Salomea Skłodowska, ea este singura femeie căreia i s-a decernat premiul de două ori, pentru fizică și pentru chimie. Astăzi, UE îi sprijină pe cercetători prin intermediul programului Marie Skłodowska-Curie. Nouă cercetători participanți la program au fost ulterior recompensați cu Premiul Nobel.";

                    }

                }
                else if (poz == 35)
                {
                    if (an1 <= 1903 && an2 >= 1903)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);

                        title1.Text = "Primul zbor cu avionul";
                        data1.Text = "-17 decembrie 1903-";
                        anactual = 1903;
                        imagine1.BackgroundImage = Properties.Resources.stinta35_1;

                        descriere1.Text = "  Frații americani Orville și Wilbur Wright, producători de biciclete, efectuează cu succes primul zbor motorizat.";

                    }

                }
                else if (poz == 36)
                {
                    if (an1 <= 1905 && an2 >= 1905)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);

                        imagine1.BackgroundImage = Properties.Resources.stiinta36_1;
                        title1.Text = "Albert Einstein";
                        data1.Text = "-27 septembrie 1905-";
                        anactual = 1905;
                        descriere1.Text = "  1905 este „anul miraculos” pentru omul de știință de origine germană Albert Einstein. Acesta marchează o adevărată revoluție în domeniul științei, printr-o serie de lucrări privind diverse aspecte legate de lumină, materie, timp și spațiu. Acestea includ una dintre cele mai celebre ecuații matematice din toate timpurile: E = mc². Un deceniu mai târziu, Einstein prezintă teoria relativității generale." + Environment.NewLine + Environment.NewLine + "  „Pune mâna pe o sobă fierbinte un minut și ți se va părea o oră. Stai cu o fată frumoasă o oră și ți se va părea un minut. Aceasta e relativitatea.” – Albert Einstein";

                    }

                }
                else if (poz == 37)
                {
                    if (an1 <= 1908 && an2 >= 1908)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);

                        title1.Text = "„Bătrânul din La Chapelle”";
                        data1.Text = "-03 august 1908-";
                        anactual = 1908;
                        imagine1.BackgroundImage = Properties.Resources.stiinta37_1;
                        descriere1.Text = "   În La Chapelle-aux-Saints (Franța), frații Amédée și Jean Bouyssonie, alături de Louis Bardon, descoperă rămășițele fosilizate, vechi de 60 000 de ani, ale unui bărbat din Neanderthal, aproape întreg, care va fi denumit „bătrânul din La Chapelle”." + Environment.NewLine + Environment.NewLine + "  Acesta este primul specimen de Neanderthal găsit într-un context arheologic original și primul care a fost excavat de experți și studiat cu atenție. Deoarece scheletul se afla într-o poziție flexată, fetală, fiind așezat cu grijă pe solul peșterii, experții care l-au excavat au susținut că „bătrânul” a fost înmormântat de contemporanii săi din Neanderthal. Nu se cunoaște cauza decesului.";
                    }
                }
                else if (poz == 38)
                {
                    if (an1 <= 1910 && an2 >= 1910)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);


                        title1.Text = "Avionul lui Henri Coandă";
                        data1.Text = "-1910-";
                        anactual = 1910;
                        imagine1.BackgroundImage = Properties.Resources.stiinta38_1;
                        descriere1.Text = "  Astazi, un zbor cu avionul a ajuns o normalitatea.dar stiati ca primul motor cu propulsie a fost proiectat si construit de Henrie Coanda? in anul 1910,inventatorul roman a creeat un sistem de propulsive folosit in avioanele cu reactive. Aeroportul din Bucuresti ii poarta astazi numele.";
                    }
                }
                else if (poz == 39)
                {
                    if (an1 <= 1911 && an2 >= 1911)
                    {
                        title1.Text = "Polul Sud este atins";
                        data1.Text = "-14 decembrie 1911-";
                        anactual = 1911;
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;

                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 184, 234);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta39_1;
                            numaratoare1.Text = "1 din 2";
                            descriere1.Text = "  In geografie,secolul 20 incepe cu o cursa spre Polul Sud dintre ecjipa britanica a lui Robert Falcon Scott si exploratorul norvegian Ronald Amundsen.Pe data de 18 octombrei 1911,achipa de exploratori norvegieni isi incepe traseul spre Pol.Acesta porneste din Golful Balenelor,mai precis de pe banchiza Ross.De abia trei saptamani mai tarziu,englezii se aventureaza si ei in Antarctica,acestia alegand sa porneasca din Golful McMurdo";

                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 184, 234);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta39_2;
                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  Amundsen are un avantaj de 96 de km,ce ii permite sa infiga steagul norvegian in Polul Sud,la ora 3 dupa-amiaza,pe data de 14 dec. 1911. Capitanul Scott ajunge de abia peste 33 de zile,pe 17 ianuarie 1912.Datorita conditiilor meteorologice dure, britanicii nu mai reusit sa paraseasca Antarctica.";

                        }
                    }
                }
                else if (poz == 40)
                {
                    if (an1 <= 1913 && an2 >= 1913)
                    {
                        title1.Text = "Canalul Panama";
                        descriere1.Text = "-1913-";
                        anactual = 1913;
                        numaratoare1.Text = "1 din 2";
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;

                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 184, 234);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta40_1;
                            numaratoare1.Text = "1 din 2";

                            descriere1.Text = "  Prima încercare de a construi o cale navigabilă pe istmul Panama datează din anul 1879. Către anul 1888 a fost cheltuită suma de 300 de milioane de dolari (aproape de 2 ori mai mult decât se estima la inceput), realizânduse doar o treime din proiect. Au existat mai multe motive: proiectarea incorectă (Ferdinand de Lesseps a insistat ca acest canal să fie săpat la nivelul mării), dar şi imposibilitatea tratării bolilor, precum malaria şi febra galbenă. Războiul spaniolo-american din anul 1898 a influenţat Statele Unite să decidă construirea unui canal pe istmul Panama, cu scopul de a-şi spori influenţa în zonele vestice.  ";

                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(228, 211, 82);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta40_2;
                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  În anul 1901, Statele Unite au încheiat un tratat cu Marea Britanie, potrivit căruia ei deţineau dreptul exclusiv asupra construirii canalului.Americanii au profitat, acordând un ajutor statului Panama, pentru ca acesta să se desprindă de sub influenţa Columbiei şi să işi câştige independenţa, şi au determinat autorităţile locale sa le concesioneze canalul, care a devenit astfel zonă sub controlul SUA.In toamna anului 1913,presedintele Woodrow Wilson apasa de la Washington butonul electric care deschide stavilarele canalului Panama,unind astfel pentru totdeauna cele doua oceane.";

                        }
                    }
                }
                else if (poz == 41)
                {
                    if (an1 <= 1914 && an2 >= 1914)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 184, 234);

                        title1.Text = "Descoperirea protonilor";
                        data1.Text = "-1914-";
                        anactual = 1914;
                        imagine1.BackgroundImage = Properties.Resources.stiinta41_1;
                        descriere1.Text = "  În 1914, Rutherford a identificat pentru prima dată protoni în nucleul atomic. De asemenea, el a transmutat pentru prima dată un atom de azot într-un atom de oxigen. Fizicianul englez Henry Moseley a furnizat numere atomice, pe baza numărului de electroni dintr-un atom, mai degrabă decât pe baza masei atomice.";
                    }
                }
                else if (poz == 42)
                {
                    if (an1 <= 1914 && an2 >= 1914)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 184, 234);
                        title1.Text = "Inventarea parașutei";
                        data1.Text = "-25 august 1914-";
                        anactual = 1914;
                        imagine1.BackgroundImage = Properties.Resources.stiinta42_1;
                        descriere1.Text = "  Inventatorul slovac Štefan Banič primește un brevet pentru parașuta sa militară. Este vorba despre prima parașută utilizată activ, care mai târziu va deveni parte din echipamentul standard al piloților.";
                    }
                }
                else if (poz == 43)
                {
                    if (an1 <= 1917 && an2 >= 1917)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);
                        title1.Text = "Einstein publică o lucrare revoluționară";
                        data1.Text = "-1917-";
                        anactual = 1917;
                        imagine1.BackgroundImage = Properties.Resources.stiinta43_1;
                        descriere1.Text = "  În 1917, Einstein a publicat o lucrare intitulată „Considerații cosmologice ale teoriei generale a relativității” care aplica relativitatea generală universului. Ca prim model relativist al universului, lucrarea, cunoscută mai târziu sub titlul „Universul static al lui Einstein” sau „Lumea lui Einstein”, a pus bazele cosmologiei teoretice moderne – descrierea universului în ansamblu, a găurilor negre, a stelelor neutronice și a micilor corecții la orbitele planetelor și ale navelor spațiale din sistemul nostru solar. Această lucrare ne-a schimbat percepția asupra cosmosului pentru totdeauna.";
                    }
                }
                else if (poz == 44)
                {
                    if (an1 <= 1920 && an2 >= 1920)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);
                        title1.Text = "Radioul";
                        data1.Text = "-1920-";
                        anactual = 1920;
                        imagine1.BackgroundImage = Properties.Resources.stiinta44_1;
                        descriere1.Text = "  Nașterea emisiunilor publice de radio este creditată lui Lee de Forest. A fost descrisă drept „fabrica de sunete”. Ideea radioului ca divertisment a luat avânt în 1920, odată cu deschiderea primelor posturi de radio stabilite special pentru difuzarea către public, precum KDKA din Pittsburgh și WWJ din Detroit." + Environment.NewLine + "  Popularitatea sa a crescut rapid la sfârșitul anilor 1920 și începutul anilor 1930, iar până în 1934, 60 la sută din gospodăriile națiunii aveau aparate de radio. Un milion și jumătate de mașini au fost, de asemenea, echipate cu ele. Anii 1930 au fost Epoca de Aur a radioului.";


                    }
                }
                else if (poz == 45)
                {
                    if (an1 <= 1922 && an2 >= 1922)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);
                        title1.Text = "Inventia insulinei(Nicolae Constantin Paulescu)";
                        data1.Text = "-1922-";
                        anactual = 1922;
                        imagine1.BackgroundImage = Properties.Resources.stiinta45_1;
                        descriere1.Text = "  Sigur ati auzit despre insulin si poate ca stitit ca este folosita in tratarea persoanelor ce sufera de diabet. Pancreatina,ulterior denumita insulin,a fost descoperita de psihologul si profesorul de medicinca Nicolae Constantin Paulescu in anul 1922.In 1916,a reusit sa dezvolte un extract pancreatic,pe care l-a testat cu success pe un caine diabetic.S-a dovedit ca are un efect normalizator asupra nivelului de zahar din sange. Paulescu si-a publicat descoperirile de mai multe ori la o revista din Franta in anul 1921,ba chiar si-a patentat descoperirea,dar,din pacate,nu a fost recunoscut la aceea vreme.";
                    }
                }
                else if (poz == 46)
                {
                    if (an1 <= 1924 && an2 >= 1924)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);
                        title1.Text = "Aerodinamica masinilor(Aurel Persu)";
                        data1.Text = "-1924-";
                        anactual = 1924;
                        imagine1.BackgroundImage = Properties.Resources.stiinta46_1;
                        descriere1.Text = "  Masinile din zile de astazi sunt din ce in ce mai modern,mai puternice si mai polivalente,dar lucrurile nu au fost niciodata chiar asa. Aurel Persu este inginerul roman care a contribuit la desing-ul masinii pe care o stim noi astazi. El a fost primul care a pozitionat rotile in interiorul caroseriei,iar principala lui idee este de a oferi  vehiculelor o forma aerodinamica,care sa reduca fortele de frecare,ajungand la conclusia ca masinile ar trebui sa imite,pe cat posibil,forma unei picaturi de apa.In 1924 a obtinut patent pentru descoperirile sale,in Germania,acolo unde a proiectat modelul masinii aerodinamice.";
                    }
                }
                else if (poz == 47)
                {
                    if (an1 <= 1928 && an2 >= 1928)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);
                        title1.Text = "Descoperirea penicilinei";
                        data1.Text = "-28 septembrie 1928-";
                        anactual = 1928;
                        imagine1.BackgroundImage = Properties.Resources.stiinta47_1;
                        descriere1.Text = "  Alexander Fleming, medic și bacteriolog scoțian, descoperă din întâmplare penicilina. Un deceniu și jumătate mai târziu, acest antibiotic salvează primul pacient.Penicilina este folosita pentru a trata infectiile de bacterii(precum pneumonia,tuberculoza,gonoree sau febra reumatica).Dupa ce s-a intors dintr-o vacanta,Fleming a observant ca niste farfuri Petri ce contineau  stafilococ au fost contaminate cu mucegai, penicillium notatum,care prevenea cresterea bacteriilor. “Cand m-am trezit dupa rasaritul din 28 septembrie 1928, eu sigur nu am planuit sa revolutionez medicina descoperind primul antibiotic din lume” a scris Fleming.";
                    }
                }
                else if (poz == 48)
                {
                    if (an1 <= 1930 && an2 >= 1930)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);
                        title1.Text = "Scaunul de evacuare";
                        data1.Text = "-2 aprilie 1930-";
                        anactual = 1930;
                        imagine1.BackgroundImage = Properties.Resources.stiinta48_1;
                        descriere1.Text = "  Amenajarea modernă pentru un scaun de evacuare a fost introdusă pentru prima dată de inventatorul român Anastase Dragomir,alaturi de  Tănase Dobrescu, la sfârșitul anilor 1920. Designul avea o celulă parașutată (un scaun descărcabil de pe o aeronavă sau alt vehicul). A fost testat cu succes la 25 august 1929 la Aeroportul Paris-Orly de lângă Paris și în octombrie 1929 la Băneasa , lângă București . Pe 2 aprilie 1930,Dragomir si Dobrescu au obtinut  patent pentru „cabina sa capabilă de catapultare” la Oficiul francez de inventii.";
                    }
                }
                else if (poz == 49)
                {
                    if (an1 <= 1931 && an2 >= 1931)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);
                        title1.Text = "Discul de vinil";
                        data1.Text = "-1931-";
                        anactual = 1931;
                        imagine1.BackgroundImage = Properties.Resources.stiinta49_1;
                        numaratoare1.Text = "1 din 2";
                        descriere1.Text = "   În 1931, RCA Victor a lansat primul disc de vinil de lungă durată disponibil comercial, comercializat ca discuri de transcriere de programe. Aceste discuri revoluționare au fost proiectate pentru redare la 33 1⁄3 rpm și au fost apăsate pe un disc flexibil din plastic cu diametrul de 30 cm, cu o durată de aproximativ zece minute de redare pe fiecare parte." + Environment.NewLine + Environment.NewLine + "  Peter Goldmark este cel care ia premiul ca inventator al discului de vinil pe care îl cunoașteți astăzi. Născut în 1906, Goldmark a ajuns să lucreze la Columbia Records ca inginer și a fost dezvoltatorul cheie al discului LP de 33 1/3 rpm.";


                    }
                }
                else if (poz == 50)
                {
                    if (an1 <= 1931 && an2 >= 1931)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);
                        title1.Text = "Otto Heinrich Warburg câștigă Premiul Nobel";
                        data1.Text = "-10 decembrie 1931-";
                        anactual = 1931;
                        imagine1.BackgroundImage = Properties.Resources.stiinta50_1;
                        descriere1.Text = "  Fiziologul și medicul german Otto Heinrich Warburg a primit Premiul Nobel pentru Fiziologie sau Medicină. El a studiat metabolismul tumorilor și respirația celulelor, în special a celulelor canceroase, iar premiul i-a fost decernat pentru „descoperirea naturii și a modului de acțiune al enzimelor respiratorii”. Warburg a fost nominalizat de 47 de ori la Premiul Nobel de-a lungul carierei sale.";
                    }
                }
                else if (poz == 51)
                {
                    if (an1 <= 1932 && an2 >= 1932)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 184, 234);
                        title1.Text = "Descopeirea neutronilor";
                        data1.Text = "-1932-";
                        imagine1.BackgroundImage = Properties.Resources.stiinta51_1;
                        descriere1.Text = "  În 1932, James Chadwick a descoperit pentru prima dată neutroni și s-au identificat izotopi. Aceasta a fost baza completă pentru tabelul periodic. În același an, englezul Cockroft și irlandezul Walton au împărțit mai întâi un atom bombardând litiu într-un accelerator de particule, schimbându-l în doi nuclei de heliu.";
                    }
                }
                else if (poz == 52)
                {
                    if (an1 <= 1932 && an2 >= 1932)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);

                        title1.Text = "Se inaugurează BBC World Service";
                        data1.Text = "-19 decembrie 1932-";
                        anactual = 1932;
                        imagine1.BackgroundImage = Properties.Resources.stiinta52_1;
                        descriere1.Text = "  BBC World Service și-a început transmisia sub denumirea de BBC Empire Service, folosind o instalație radio cu unde scurte din Daventry, Regatul Unit. În primul său mesaj de Crăciun, regele George al V-lea a descris serviciul ca fiind destinat „bărbaților și femeilor, atât de izolați de zăpadă, deșert sau mare, încât doar vocile din aer pot ajunge la ei”.";
                    }
                }
                else if (poz == 53)
                {
                    if (an1 <= 1935 && an2 >= 1935)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);

                        title1.Text = "Prima transmisiune a unei televiziuni publice";
                        data1.Text = "-22 martie 1935-";
                        anactual = 1935;
                        imagine1.BackgroundImage = Properties.Resources.stiinta53_1;
                        descriere1.Text = "  Primul program al unei televiziuni publice (transmis de stația de televiziune Paul Nipkow) a fost difuzat din Funkturm, Berlin (Germania). Postul de televiziune transmitea doar în Berlin și în împrejurimi, dar a devenit foarte popular când a difuzat Jocurile Olimpice de vară din 1936 de la Berlin.";
                    }
                }
                else if (poz == 54)
                {
                    if (an1 <= 1935 && an2 >= 1935)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);

                        title1.Text = "Irene Joliot-Curie câștigă Premiul Nobel";
                        data1.Text = "-10 decembrie 1935-";
                        anactual = 1935;
                        imagine1.BackgroundImage = Properties.Resources.stiinta54_1;
                        descriere1.Text = "  Premiul Nobel pentru Chimie a fost decernat savantei franceze Irene Joliot-Curie (fiica lui Marie Curie) și soțului acesteia, Frédéric Joliot, pentru descoperirea radioactivității artificiale.";
                    }
                }
                else if (poz == 55)
                {
                    if (an1 <= 1936 && an2 >= 1936)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(114, 219, 192);

                        title1.Text = "Invenția aparatului foto de mici dimensiuni";
                        data1.Text = "-1936-";
                        anactual = 1936;
                        imagine1.BackgroundImage = Properties.Resources.stiinta55_1;
                        descriere1.Text = "  Fotograful Walter Zapp, un leton de origine germană, inventează un aparat de fotografiat atât de mic încât încape în palma mâinii. Acesta devine un articol indispensabil pentru serviciile secrete din lumea întreagă – chiar și James Bond are unul.";
                    }
                }
                else if (poz == 56)
                {
                    if (an1 <= 1936 && an2 >= 1936)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(239, 224, 255);

                        imagine1.BackgroundImage = Properties.Resources.stiinta56_1;
                        title1.Text = "Ochelarii 3D(Teodor Ionescu)";
                        data1.Text = "-1936-";
                        anactual = 1936;

                        descriere1.Text = "   In zilele de astazi,ochelarii 3D sunt folositi in mai toate cinematografele si ne-au revolutionat viata, de la carti pentru cei mici pana la arta stradala. Dar cinematografia 3D isi are originile in patentul din 1936 al lui Teodor Ionescu pentru proiectarea imaginilor 3D pe ecranele cinematografelor si chiar a televizoarelor.In timp ce imaginile 3D au fost inventate mai devreme de catre Sir Charles Wheatstone, Ionescu a fost cel care i-a adaptat pentru divertisment si publicul larg.";
                    }
                }
                else if (poz == 57)
                {
                    if (an1 <= 1936 && an2 >= 1936)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(239, 224, 255);

                        title1.Text = "Crenvurstii medicinali sovietici";
                        data1.Text = "-1936-";
                        anactual = 1936;
                        imagine1.BackgroundImage = Properties.Resources.stiinta57_1;

                        descriere1.Text = "  Crenvurstii, raspanditi rapid si asociati cu berea in intreaga Europa, au ajuns in Rusia tarista asociati cu vodca, iar mai taziu erau serviti in restaurante ca „felul doi”, cu mustar iute si garnitura din piure de cartofi, indulcit cu zahar." + Environment.NewLine + Environment.NewLine + "  In 1936, medicilor rusi li s-a parut ca acesti carnaciori fragezi sunt indicati pentru tonifierea bolnavilor si astfel au aparut sub denumirea de „carnati medicinali”.Alaturi de ceaiurile medicinale, crenvurstii sovietici au reprezentat multa vreme un constituent de baza al medicinii naturiste";



                    }
                }
                else if (poz == 58)
                {
                    if (an1 <= 1944 && an2 >= 1944)
                    {
                        title1.Text = "Se instalează prima conductă petrolieră subacvatică din lume";
                        data1.Text = "-12 august 1944-";
                        anactual = 1944;
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;

                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(239, 224, 255);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta58_1;
                            numaratoare1.Text = "1 din 2";
                            descriere1.Text = "  Prima conductă petrolieră subacvatică din lume este amplasată între Regatul Unit și Franța. Operațiunea Pluto (Pipe Line Under The Ocean – Petroduct sub ocean) a fost o operațiune din cel de-al Doilea Război Mondial condusă de ingineri britanici, companii petroliere și forțele armate britanice pentru a construi conducte petroliere sub Canalul Mânecii, între Anglia și Franța, în sprijinul Operațiunii Overlord, invazia Normandiei de către forțele aliate în iunie 1944.";
                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(114, 219, 192);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta58_2;
                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  Conductele au fost considerate necesare pentru diminuarea dependenței de navele petroliere, care puteau fi încetinite de vremea rea, erau vulnerabile la submarinele germane și de care era nevoie și în Războiul din Pacific.";
                        }

                    }
                }
                else if (poz == 59)
                {
                    if (an1 <= 1945 && an2 >= 1945)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(251, 148, 140);

                        title1.Text = "Arma nucleara ";
                        data1.Text = "-16 iulie 1945-";
                        anactual = 1945;
                        imagine1.BackgroundImage = Properties.Resources.stiinta59_1;
                        descriere1.Text = "  Prima explozie nucleară din lume a avut loc pe 16 iulie 1945, când un dispozitiv de implozie a plutoniului a fost testat într-un loc situat la 210 mile sud de Los Alamos,in desertul New Mexico, pe câmpiile sterpe din zona de bombardament Alamogordo, cunoscută sub numele de Jornada del Muerto.";
                    }
                }
                else if (poz == 60)
                {
                    if (an1 <= 1947 && an2 >= 1947)
                    {
                        title1.Text = "Tranzistorul";
                        data1.Text = "-23 decembrie 1947-";
                        anactual = 1947;
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;

                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 184, 234);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta60_1;
                            numaratoare1.Text = "1 din 2";
                            descriere1.Text = "  Tranzistorul a fost demonstrat cu succes pe 23 decembrie 1947 la Laboratoarele Bell din Murray Hill, New Jersey. Bell Labs este brațul de cercetare al American Telephone and Telegraph (AT&T). Cei trei indivizi cărora li s-a atribuit invenția tranzistorului au fost William Shockley, John Bardeen și Walter Brattain.";
                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(228, 211, 82);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta60_2;
                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  Fără să-i spună lui Shockley schimbările pe care le făceau anchetei, Bardeen și Brattain au lucrat. La 16 decembrie 1947, au construit tranzistorul de contact punct, realizat din benzi de folie de aur pe un triunghi de plastic, împins în jos în contact cu o placă de germaniu.";

                        }
                    }
                }
                else if (poz == 61)
                {
                    if (an1 <= 1948 && an2 >= 1948)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(239, 224, 255);
                        title1.Text = "Un computer numit “Baby”";
                        data1.Text = "-21 iunie 1948-";
                        anactual = 1948;
                        imagine1.BackgroundImage = Properties.Resources.stiinta61_1;
                        descriere1.Text = "  Cand o masinarie, numita in gluma “Baby”, a fost pusa la viata pentru prima oar ape data de 21 iunie 1948, a devenit primul computer din lume , iar nimic nu va fi la fel din nou. Proiectat de Tom Kilburn si de Freddie Williams, doi oameni de stiinta la Universitatea Manchster din Mare Britanie, “Baby” a fost primul dopzitiv care a avut componentele care sa gasesc intr-un PC din zilele de azi. Acesta nu numai ca putea stoca  date ,dar si un scurt porgam pentru utilizator, in memorie electronica si putea procesa la viteze pe masura. Primul computer aparut vreodata a fost suficient de mare cat sa ocupe o camera intreaga, in timp ce un telefonul modern ocupa mai putin spatiu si poate memora mai multe milioane de bytes decat a putut “Baby”.";
                    }
                }
                else if (poz == 62)
                {
                    if (an1 <= 1952 && an2 >= 1952)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(251, 148, 140);

                        title1.Text = "Crema anti-imbatranire ( Ana Alsan )";
                        data1.Text = "-1952-";
                        anactual = 1952;
                        imagine1.BackgroundImage = Properties.Resources.stiinta62_1;
                        descriere1.Text = "  Astazi,produsele anti-imbatranire sunt un adevarat miracol pentru doamnele care cauta un aspect mai tanar. Unul dintre primii oameni de stiinta care a descoperit efectele procainei,care se gasesc in prdusele moderne Gerovital H3 si Alsavital,Ana Alsan a infiintat primul Institut de Geriatrie(Ramură a medicinei consacrată persoanelor vârstnice, și care studiază și îngrijește bolile bătrâneții; ansamblu de măsuri recomandate în vederea întârzierii apariției senilității) din Lume in 1952. Printre pacientii acesteia, se numara Charles de Gaulle,Charlie Chaplin si John F. Kennedy. ";
                    }
                }
                else if (poz == 63)
                {
                    if (an1 <= 1956 && an2 >= 1956)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(239, 224, 255);
                        title1.Text = "Hard Disk";
                        data1.Text = "-1956-";
                        anactual = 1956;
                        imagine1.BackgroundImage = Properties.Resources.stiinta63_1;
                        descriere1.Text = "  Informat de ideile lui Jacob Rabinow de la NBS, IBM a dezvoltat și livrat prima unitate hard disk comercială (HDD), unitatea de stocare pe disc Model 350, către Zellerbach Paper, San Francisco, în iunie 1956, ca parte a IBM 305 RAMAC (Random Access Method of Contabilitate și control).";

                    }

                }
                else if (poz == 64)
                {
                    if (an1 <= 1957 && an2 >= 1957)
                    {
                        title1.Text = "Primul satelit este lansat in spatiu";
                        data1.Text = "-04 octombrie 1957-";
                        anactual = 1957;
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;

                        if (q == 1)
                        {
                            next11.BackgroundImage = next12.BackgroundImage = Properties.Resources.next_g_2;
                            prev11.BackgroundImage = prev12.BackgroundImage = Properties.Resources.prev_g_1;

                            schimba_in_galben = true;

                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(10, 5, 53);
                            Q11.ButtonColor = Color.MediumBlue;

                            descriere1.ForeColor = title1.ForeColor = data1.ForeColor = Color.Goldenrod;

                            imagine1.BackgroundImage = Properties.Resources.stiinta64_1;
                            numaratoare1.Text = "1 din 2";

                            descriere1.Text = "  Începe „era spațială”, când Uniunea Sovietică lansează pe orbită un satelit de mărimea unei mingi de baschet / a unui cuptor cu microunde, denumit Sputnik 1.Acesta cantarea 80 de kilograme si a orbitat doua luni in jurul Pamantului. Lansarea cu succes a șocat lumea, oferind fostei Uniuni Sovietice distincția de a pune în spațiu primul obiect creat de om. Sputnik a provocat isterie în rândul americanilor, care se relaxaseră crezând că sunt superiori din punct de vedere tehnologic comuniștilor. Dacă un satelit sovietic ar putea zbura peste cerul SUA, atunci cu siguranță rachetele nucleare sovietice ar putea dezlănțui furia pe solul SUA.";
                        }
                        else if (q == 2)
                        {
                            next11.BackgroundImage = next12.BackgroundImage = Properties.Resources.nect_alb;
                            prev11.BackgroundImage = prev12.BackgroundImage = Properties.Resources.prev_alb;
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(213, 151, 85);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta64_2;
                            numaratoare1.Text = "2 din 2";

                            descriere1.Text = "  Câțiva ani mai târziu, la 12 aprilie 1961, cosmonautul rus Yuri Gagarin decolează de pe aceeași platformă de lansare, devenind primul om care ajunge în spațiu.";

                        }
                    }
                }
                else if (poz == 65)
                {
                    if (an1 <= 1957 && an2 >= 1957)
                    {
                        title1.Text = "Laika-primul animal in spatiu";
                        data1.Text = "-3 noiembrie 1957-";
                        anactual = 1957;
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;

                        if (q == 1)
                        {
                            next11.BackgroundImage = next12.BackgroundImage = Properties.Resources.nect_alb;
                            prev11.BackgroundImage = prev12.BackgroundImage = Properties.Resources.prev_alb;
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(114, 219, 192);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta65_1;
                            numaratoare1.Text = "1 din 2";
                            descriere1.Text = "  Laika, numită inițial Kudreavka  a fost antrenată cu alți doi câini, și aleasă să ocupe nava sovietică Sputnik 2 care a fost lansată în spațiu pe data de 3 noiembrie 1957 de la Cosmodromul Baikonur din Khasahstanul sovietic.";
                        }
                        else if (q == 2)
                        {
                            next11.BackgroundImage = next12.BackgroundImage = Properties.Resources.next_g_2;
                            prev11.BackgroundImage = prev12.BackgroundImage = Properties.Resources.prev_g_1;
                            schimba_in_galben = true;

                            descriere1.ForeColor = data1.ForeColor = title1.ForeColor = Color.Goldenrod;
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(56, 26, 126);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta65_2_;

                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  Laika,un fost caine vagabond cules de pe strazile Moscovei, si-a gasit sfarsitul in satelitul –care a fost proiectat doar pentru un drum dus,nu si intors-a supraviețuit pe orbită timp de patru zile și apoi a murit când cabina s-a supraîncălzit.";

                        }


                    }
                }
                else if (poz == 66)
                {
                    if (an1 <= 1958 && an2 >= 1959)
                    {

                        title1.Text = "Primul microcip";
                        data1.Text = "- 12 sepembrie 1958 -";
                        anactual = 1958;

                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;

                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 184, 234);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta66_1;
                            numaratoare1.Text = "1 din 2";
                            descriere1.Text = "  Texas Instruments îl sărbătorește pe cel din nordul Texasului, care a făcut posibil circuitul integrat - microcipul. La 12 septembrie 1958, Jack Kilby, inginer TI, a inventat circuitul integrat." + Environment.NewLine + "  El a revoluționat industria electronică, contribuind la răspândirea telefoanelor mobile și a computerelor astăzi.";
                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(239, 224, 255);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta66_2;
                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  Nu a durat mult până când Kilby și-a pus amprenta la TI. La doar câteva luni după ce s-a alăturat companiei din Dallas, în 1958, a efectuat o demonstrație de laborator pe primul său microcip pe 12 septembrie." + Environment.NewLine + "  Ulterior, Kilby a ajutat la inventarea calculatorului de mână și a imprimantei termice utilizate în terminalele de date portabile.";
                        }


                    }
                }
                else if (poz == 67)
                {
                    if (an1 <= 1958 && an2 >= 1958)
                    {

                        title1.Text = "NASA";
                        data1.Text = "-29 iulie 1958-";
                        anactual = 1958;
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;

                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 184, 234);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta67_1;
                            numaratoare1.Text = "1 din 2";
                            descriere1.Text = "  Pentru a recupera progresul înregistrat de Uniunea Sovietică, a fost înființată NASA la 29 iulie 1958 pentru a administra și a realiza proiecte de astronautică civilă, care anterior erau susținute de diverse ramuri ale Forțelor Armate ale Statelor Unite, pentru a recupera progresul înregistrat de Uniunea Sovietică. NASA a preluat centrele de cercetare de la Comitetul Național Consultativ pentru Aeronautică (NACA), care anterior era îndreptată spre cercetare în domeniul aeronautic.";
                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 184, 234);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta67_2;
                            numaratoare1.Text = "1 din 2";
                            descriere1.Text = "  Noua agenție are o orientare civilă distinctă, încurajând aplicațiile pașnice în știința spațială. De la înființarea sa, majoritatea eforturilor de explorare spațială din SUA au fost conduse de NASA, inclusiv misiunile Apollo, stația spațială Skylab și, ulterior, naveta spațială. NASA sprijină Stația Spațială Internațională și supraveghează dezvoltarea vehiculului multifuncțional Orion, a sistemului de lansare spațială și a vehiculelor comerciale cu echipaj. "; ;

                        }
                    }
                }
                else if (poz == 68)
                {
                    if (an1 <= 1958 && an2 >= 1958)
                    {
                        title1.Text = "Mercury";
                        data1.Text = "- 1958-";
                        anactual = 1958;
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;

                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 184, 234);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta68_1;
                            numaratoare1.Text = "1 din 2";
                            descriere1.Text = "  Project Mercury a fost programul NASA care a pus primii astronauți americani în spațiu. Astronauții au realizat în total șase zboruri spațiale în timpul Proiectului Mercur. Două dintre aceste zboruri au ajuns în spațiu și au coborât imediat. Acestea se numesc zboruri suborbitale.Ceilalți patru au intrat pe orbită și au încercuit Pământul. Primul dintre aceste șase zboruri a fost efectuat în 1961.Ultimul zbor a fost efectuat în 1963,iar rachetele folosite au fost initial construite cu scopul de focoase nucleare.";
                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(228, 211, 82);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta68_2;
                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  Proiectul a fost numit Mercur după un zeu roman care a fost foarte rapid. Fiecare astronaut și-a numit nava spațială. Alan Shepard a inclus un 7 în numele capsulei sale Mercury. Acest lucru s-a întâmplat pentru că a fost realizat al șaptelea. Ceilalți astronauți au inclus și un 7. Aceasta a fost în cinstea celor șapte astronauți aleși pentru proiect.";

                        }
                    }

                }
                else if (poz == 69)
                {
                    if (an1 <= 1959 && an2 >= 1959)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 184, 234);
                        title1.Text = "Avionul Racheta";
                        data1.Text = "- 1959-";
                        anactual = 1959;
                        imagine1.BackgroundImage = Properties.Resources.stiinta69_1;


                        descriere1.Text = "  In anul 1959 este pusa in functiune si data testarii X-15 ,o aeronava rachetă supersonică experimentală NACA, dezvoltată în colaborare cu Forțele Aeriene și Marina din SUA. Proiectul avea un fuselaj subțire, cu carenaje de-a lungul laturii care conținea combustibil și unul dintre primele sisteme de control computerizate." + Environment.NewLine + Environment.NewLine + "  Doisprezece piloți au fost selectați pentru a zbura cu acest avion.  Un total de 199 de zboruri au fost făcute între 1959 și 1968, rezultând recordul mondial oficial pentru cea mai mare viteză realizată vreodată de o aeronavă echipată cu motor cu o viteză maximă de 7.273 km/h. Recordul de altitudine pentru X-15 a fost de 107,96 km.";

                    }
                }
                else if (poz == 70)
                {
           
                    if (an1 <= 1959 && an2 >= 1959)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);
                        title1.Text = "Luna este atinsa ";
                        data1.Text = "-14 septembrie 1959-";
                        anactual = 1959;
                        imagine1.BackgroundImage = Properties.Resources.stiinta70_1;
                        descriere1.Text = "   Explorarea fizică a Lunii a început atunci când Luna 2, o sondă spațială lansată de Uniunea Sovietică, s-a prăbușit pe suprafața Lunii pe 14 septembrie 1959. Până atunci singurul mijloc disponibil de explorare a Lunii a fost observația de pe Pământ.";
                    }
                }
                else if (poz == 71)
                {
                    if (an1 <= 1960 && an2 >= 1960)
                    {
                        title1.Text = "Gropa Marianelor este atinsa";
                        data1.Text = "-23 ianuarie 1960-";
                        anactual = 1960;
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;

                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(228, 211, 82);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta71_1;
                            numaratoare1.Text = "1 din 2";
                            descriere1.Text = "  Groapa Marianelor se află la nord de ecuator în apropiere de Insulele Mariane ce aparțin de Melanezia. Groapa se află situată la circa 2.000 km est de Insulele Filipine și la sud de insula Guam. La nord groapa se continuă în groapa Bonin, care continuă, la rândul ei, mai departe în nord în groapa Japoniei.";
                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 184, 234);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta71_2;
                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  La 23 ianuarie 1960, Groapa Marianelor a fost vizitată de Jacques Piccard și locotenentul american  oceanograful elvetian  Don Walsh. James Cameron este “prima persoana din lume care a atins fundul oceanului, singur, in cea mai adanca zona din scoarta terestra, la o adancime record de 10.898 de metri, luni, 26 martie, la ora locala 07.52 (duminica, 25 martie, ora 22.52 GMT)”, a anuntat, de la Washington, acest grup american specializat geografie si stiinte naturale. Submarinul folosit de Cameron, “Deepsea Challenger”, a ajuns insa la 11 km adancime in Oceanul Pacific.";

                        }

                    }
                }
                else if (poz == 72)
                {
                    if (an1 <= 1961 && an2 >= 1961)
                    {
                        title1.Text = "Gemini";


                        data1.Text = "- 1961 -";
                        anactual = 1961;
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;

                        if (q == 1)
                        {
                            next11.BackgroundImage = next12.BackgroundImage = Properties.Resources.next_g_2;
                            prev11.BackgroundImage = prev12.BackgroundImage = Properties.Resources.prev_g_1;
                            schimba_in_galben = true;
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(10, 5, 53);
                            Q11.ButtonColor = Color.MediumBlue;

                            descriere1.ForeColor = title1.ForeColor = data1.ForeColor = Color.Goldenrod;

                            imagine1.BackgroundImage = Properties.Resources.stiinta72_1;
                            numaratoare1.Text = "1 din 2";
                            descriere1.Text = "  NASA a numit nava spațială și programul Gemini după constelația Gemini. Numele este în latină pentru „gemeni”. NASA a folosit acest nume deoarece capsula Gemeni ar transporta două persoane.";

                        }
                        else if (q == 2)
                        {
                            next11.BackgroundImage = next12.BackgroundImage = Properties.Resources.nect_alb;
                            prev11.BackgroundImage = prev12.BackgroundImage = Properties.Resources.prev_alb;
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(228, 211, 82);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta72_2;
                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  Capsula Gemenilor a zburat pe o rachetă Titan II. Titan II în două etape a fost inițial o focoasa. NASA a modificat racheta pentru a putea transporta oameni. Înainte ca primii astronauți să zboare pe el, a lansat fără echipaj, astfel încât NASA să-și poată testa siguranța. Gemini 4 a inclus prima plimbare spatiala din istorie.";
                        }

                    }
                }
                else if (poz == 73)
                {
                    if (an1 <= 1961 && an2 >= 1961)
                    {
                        title1.Text = "Apollo";
                        data1.Text = "- 1961 -";
                        anactual = 1961;
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;

                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(213, 151, 85);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta73_1;
                            numaratoare1.Text = "1 din 2";
                            descriere1.Text = "   În 1961, J.F.K. a provocat națiunea să aterizeze astronauți pe Lună până la sfârșitul deceniului. NASA a întâmpinat această provocare cu programul Apollo. A fost prima dată când ființele umane au părăsit orbita Pământului și au vizitat o altă lume. Apollo a fost programul NASA care a avut ca rezultat astronauții americani să facă un total de 11 zboruri spațiale și să meargă pe Lună.";
                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(228, 211, 82);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta73_2;

                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  Silverstein de la NASA a ales numele „Apollo” după ce a analizat acasă o carte de mitologie într-o seară din 1960. El a spus că imaginea „Apollo călărind carul său peste soare este potrivită pentru marea scară a programului propus”.";
                        }

                    }
                }
                else if (poz == 74)
                {
                    if (an1 <= 1961 && an2 >= 1961)
                    {
                        title1.Text = "Primul om in spatiu";
                        data1.Text = "- 12 aprilie 1961 -";
                        anactual = 1961;

                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;

                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;

                        if (q == 1)
                        {
                            next11.BackgroundImage = next12.BackgroundImage = Properties.Resources.next_g_2;
                            prev11.BackgroundImage = prev12.BackgroundImage = Properties.Resources.prev_g_1;
                            schimba_in_galben = true;

                            descriere1.ForeColor = title1.ForeColor = data1.ForeColor = Color.Goldenrod;
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(10, 5, 53);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta74_1;
                            numaratoare1.Text = "1 din 2";
                            descriere1.Text = "  Yuri Gagarin a fost un cosmonaut sovietic, primul om care a ajuns în spațiul cosmic pe date de 12 aprilie 1961 . Calatoria lui a durat 108 de minute si a obirtat in jurul Pamantului o data si un pic in aeronava Uniunii Sovietice Vostok.Chiar si astazi, numele cosmonautului a ramas pe multe din muzeele din Rusia si poarta un loc de onoare pe holurile Kremlinului. ";
                        }
                        else if (q == 2)
                        {
                            next11.BackgroundImage = next12.BackgroundImage = Properties.Resources.nect_alb;
                            prev11.BackgroundImage = prev12.BackgroundImage = Properties.Resources.prev_alb;

                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(228, 211, 82);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta74_2;
                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  Satelitul a reusit sa se indeparteze cu 327 de kilometri de Terra. Vostok 1 nu avea motoare care să-i încetinească reintrarea și nici o cale de aterizare în siguranță. La aproximativ 7 km în sus, Gagarin a ieșit din nava spațială și a parașutat pe Pământ. Pentru ca misiunea să fie luată în considerare ca un zbor spațial oficial, Fédération Aéronautique Internationale (FAI), organul de conducere pentru înregistrările aerospațiale, a stabilit că pilotul trebuie să aterizeze cu nava spațială. Liderii sovietici au indicat că Gagarin a atins cu Vostok 1 și nu au dezvăluit că el a expulzat până în 1971. Indiferent, Gagarin a stabilit încă recordul ca prima persoană care a părăsit orbita Pământului și a călătorit în spațiu.";

                        }
                    }

                }
                else if (poz == 75)
                {
                    if (an1 <= 1961 && an2 >= 1961)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(239, 224, 255);
                        imagine1.BackgroundImage = Properties.Resources.stiinta75_1;
                        title1.Text = "Primul circuit integrat ";
                        data1.Text = "-25 aprilie 1961-";
                        anactual = 1961;
                        descriere1.Text = "  În timp ce se afla la Fairchild, Noyce a dezvoltat circuitul integrat. Același concept a fost inventat de Jack Kilby la Texas Instruments din Dallas cu câteva luni în urmă. În iulie 1959 Noyce a depus un brevet pentru concepția sa despre circuitul integrat." + Environment.NewLine + "   La 25 aprilie 1961, biroul de brevete a acordat primul brevet pentru un circuit integrat lui Robert Noyce în timp ce cererea lui Kilby era încă analizată.";
                    }
                }
                else if (poz == 76)
                {
                    if (an1 <= 1961 && an2 >= 1961)
                    {
                        title1.Text = "Tratatul Antarcticii";
                        data1.Text = "-23 iunie 1961-";
                        anactual = 1961;
                        Q11.Visible = Q12.Visible = Q13.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;

                        if (q == 1)
                        {
                            next11.BackgroundImage = next12.BackgroundImage = Properties.Resources.nect_alb;
                            prev11.BackgroundImage = prev12.BackgroundImage = Properties.Resources.prev_alb;
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(114, 219, 192);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta76_1;
                            numaratoare1.Text = "1 din 3";
                            descriere1.Text = "  La scurt timp dupa ce SUA au testat trei bombe atomice in Antrctica, a fost deschis pentru semnare la 1 decembrie 1959, și a intrat oficial în vigoare la 23 iunie 1961. militare pe continent. Tratatul a fost primul acord de control al armamentului semnat în timpul Războiului Rece.  Obiectivul principal al tratatului este cel de a asigura în interesul întregii omeniri că Antarctica va continua să fie pentru totdeauna utilizată exclusiv în scopuri pașnice și că nu va deveni scena sau obiectul discordiei internaționale. Tratatul interzice orice măsură de natură militară, dar nu și prezența personalului militar.";

                        }
                        else if (q == 2)
                        {
                            next11.BackgroundImage = next12.BackgroundImage = Properties.Resources.nect_alb;
                            prev11.BackgroundImage = prev12.BackgroundImage = Properties.Resources.prev_alb;
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 184, 234);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta76_2;
                            numaratoare1.Text = "2 din 3";
                            descriere1.Text = "  Impreună cu o serie de alte tratate colaterale,a reglementeaza relațiile internaționale în raport cu Antarctida, singurul continent de pe Pământ fără populație umană băștinașă. În acest tratat, Antarctica este definită ca fiind tot uscatul, împreună cu banchizele aflate la sud de paralela de 60° latitudine sudică. Tratatul, care a intrat în vigoare în 1961 fiind semnat în total de 47 de țări, face din Antarctica o rezervație științifică, stabilește libertatea de cercetare științifică și interzice activitățile. ";


                        }
                        else if (q == 3)
                        {
                            next11.BackgroundImage = next12.BackgroundImage = Properties.Resources.next_g_2;
                            prev11.BackgroundImage = prev12.BackgroundImage = Properties.Resources.prev_g_1;
                            schimba_in_galben = true;
                            descriere1.ForeColor = title1.ForeColor = data1.ForeColor = Color.Goldenrod;
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(10, 5, 53);

                            Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta76_3;
                            numaratoare1.Text = "3 din 3";
                            descriere1.Text = "  Primii semnatari au fost cele 12 țări active în Antarctica în timpul Anului Geofizic Internațional 1957–1958 și care au acceptat invitația Statelor Unite la conferința la care acesta a fost negociat. Cele 12 țări aveau interese semnificative în Antarctica la acea vreme: Argentina, Australia, Belgia, Chile, Franța, Japonia, Noua Zeelandă, Norvegia, Africa de Sud, Uniunea Sovietică, Regatul Unit și Statele Unite. Aceste țări înființaseră peste 50 de stații antarctic pentru AGI.";

                        }
                    }
                }
                else if (poz == 77)
                {
                    if (an1 <= 1964 && an2 >= 1964)
                    {
                        title1.Text = "Nutella";
                        data1.Text = "- 1964 -";
                        anactual = 1964;
                        Q11.Visible = Q12.Visible = Q13.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;

                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(224, 55, 50);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta77_1;
                            numaratoare1.Text = "1 din 3";
                            descriere1.Text = "   Primul borcan din ceea ce numim acum Nutella a fost vândut de la o brutărie din Alba, Piemont. Nu după mult timp, răspândirea ciocolatei cu alune a cucerit întreaga lume." + Environment.NewLine + "  Dar istoria neobișnuită și uneori controversată a răspândirii de renume mondial ar putea surprinde chiar și cei mai dedicați fani ai săi.Aceasta ciocolata are si o zi mondiala prorpie , aceasta fiind data de 5 februarie.";
                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(130, 66, 13);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta77_2;
                            numaratoare1.Text = "2 din 3";
                            descriere1.Text = "  Când Michele Ferrero, fiul unui mic producător de patiserie din oraș, a decis să calce pe urmele tatălui său, a avut începuturi umile. Nutella este uneori numită „rețetă de austeritate”, deoarece la vremea respectivă, în anii 1950, Cel De-Al Doilea Război Mondial și raționamentul lăsaseră  Italia cu o cantitate mica de ciocolata. Nutella a fost creata pentru a hrani populatia Italiei, cu un moral scazut dupa un asemenea razboi care a devastat infrastructura. Regiunile nordice ale tarii, relativ industrializate si cu forta de munca sustenabila, au facilitat dezvoltarea produsului.";


                        }
                        else if (q == 3)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(228, 211, 82);
                            Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta77_3;
                            numaratoare1.Text = "3 din 3";
                            descriere1.Text = "  Adăugarea de alune, care erau mai ieftine și mai ușor disponibile decât cacao, a făcut ca răspândirea să fie mult mai accesibilă. Dar nu a fost doar ideea lui Ferrero, producătorii Nutella din Torino. De fapt, orașul a fost cunoscut pentru producerea de ciocolată cu infuzie de alună, încă din vremea lui Napeleon." + Environment.NewLine + "  Crema de ciocolată cu alune a fost inventată în oraș în 1806, când războaiele lui Napoleon din America de Sud au făcut boabele de cacao atât de scumpe din în regatul Savoia, încât ciocolaterii locali au ieșit din afaceri - până când s-au lovit de ideea de a folosi produse locale alunele pentru a-și face ciocolata să meargă mai departe.";

                        }
                    }
                }
                else if (poz == 78)
                {
                    if (an1 <= 1965 && an2 >= 1965)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 184, 234);
                        imagine1.BackgroundImage = Properties.Resources.stiinta78_1;
                        title1.Text = "Prima plimbare spatiala ";
                        data1.Text = "-14 martie 1965-";
                        anactual = 1965;
                        descriere1.Text = "  La 18 martie 1965, cosmonautul sovietic Alexei Leonov a realizat prima plimbare spațială din istorie în timpul unei excursii de 10 minute în misiunea Voskhod 2, bătându-i pe americani cu aproape trei luni. În timpul misiunii Gemeni IV din iunie 1965, Ed White a devenit primul american care a condus o plimbare spațială.";
                    }

                }
                else if (poz == 79)
                {
                    if (an1 <= 1965 && an2 >= 1965)
                    {
                        title1.Text = "Skylab";
                        data1.Text = "- 1965 -";
                        anactual = 1965;
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;

                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 184, 234);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta79_1;
                            numaratoare1.Text = "1 din 2";
                            descriere1.Text = "  Skylab a fost prima și singura stație spațială americană construită independent.[49] Conceput în 1965 ca un atelier care urma să fie construit în spațiu din stadiul superior a lui Saturn IB, stația de 77.088 kg a fost construită pe Pământ și lansată la 14 mai 1973, pe o orbită la 435 km înclinată la 50° față de ecuator. Acesta a inclus un laborator pentru studierea efectelor microgravității și un observator solar. ";
                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 184, 234);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta79_2;
                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  NASA a planificat să aibă o navetă spațială pe ea și să ridice Skylab la o altitudine mai înaltă și mai sigură, dar naveta nu era pregătită să zboare înainte de reîntoarcerea lui Skylab la 11 iulie 1979.Pentru a economisi costurile, NASA a folosit pentru lansarea Skylab una dintre rachetele Saturn V.";

                        }

                    }

                }
                else if (poz == 80)
                {
                    if (an1 <= 1965 && an2 >= 1965)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 246, 117);
                        imagine1.BackgroundImage = Properties.Resources.stiinta80_1;
                        title1.Text = "Se inaugurează tunelul Mont Blanc";
                        data1.Text = "-16 iulie 1965-";
                        anactual = 1965;
                        descriere1.Text = "  Se inaugurează tunelul Mont Blanc, un tunel rutier construit sub masivul Mont Blanc în Alpi. Tunelul este una dintre principalele rute de transport transalpin, în special pentru Italia, care se bazează pe tunel pentru a transporta până la o treime din mărfurile care ajung în nordul Europei.";
                    }

                }
                else if (poz == 81)
                {
        
                    if (an1 <= 1968 && an2 >= 1968)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(45, 81, 40);
                        imagine1.BackgroundImage = Properties.Resources.stiinta81_1;
                        title1.Text = "RAM";
                        data1.Text = "-1968-";
                        anactual = 1968;
                        descriere1.Text = "  Un bit de date ar putea fi stocat pe inel și accesat în orice moment. Cu toate acestea, memoria RAM(random acces memory), așa cum o cunoaștem astăzi, ca memorie în stare solidă, a fost inventată pentru prima dată în 1968 de Robert Dennard. Cunoscuți în mod specific ca memorie dinamică cu acces aleatoriu sau DRAM, tranzistoarele au fost utilizate pentru a stoca biți de date.";
                    }
                }
                else if (poz == 82)
                {
   
                    if (an1 <= 1968 && an2 >= 1968)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(239, 224, 255);
                        imagine1.BackgroundImage = Properties.Resources.stiinta82_1;
                        title1.Text = "Imprimanta cu laser";
                        data1.Text = "-1968-";
                        anactual = 1968;
                        descriere1.Text = "  Prima imprimantă de computer proiectată a fost un aparat acționat mecanic de Charles Babbage pentru motorul său diferențiat în secolul al XIX-lea; cu toate acestea, designul său de imprimantă mecanică nu a fost construit decât în 2000. Prima imprimantă electronică a fost EP-101, inventată de compania japoneză Epson și lansată în 1968." + Environment.NewLine + Environment.NewLine + "  In 1969,Gary Starkweather a inventat imprimanta laser în laboratorul de cercetare Xerox din Webster, New York.";
                    }
                }
                else if (poz == 83)
                {
                    if (an1 <= 1969 && an2 >= 1969)
                    {
                        title1.Text = "Aselenizarea lui Neil Armstrong ";
                        data1.Text = "-20 iulie 1969-";
                        anactual = 1969;
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;

                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(228, 211, 82);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta83_1;
                            numaratoare1.Text = "1 din 2";
                            descriere1.Text = "  Neil Armstrong este un fost astronaut American, primul om care a pășit pe Lună pe data 20 iulie 1969, în timpul misiunii Apollo 11. Cu ocazia coborârii pe suprafața Lunii, Armstrong a rostit „Un pas mic pentru om, un salt uriaș pentru omenire”, citat devenit ulterior celebru. La aselenizare a participat și astronautul Buzz Aldrin. Evenimentul a fost urmărit de milioane de oameni din întreaga lume. Misiunea a fost una reușită, în ciuda scepticismului multora (chiar Neil Armstrong a declarat ulterior că înainte de misiune considera că există 50% șanse să revină pe Pământ de pe suprafața lunară).";
                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(251, 148, 140);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta83_2;
                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  Programul Apollo al NASA a fost prima, și până în prezent singura, misiune spațială în care oamenii au ajuns pe suprafața Lunii. "; ;
                        }

                    }


                }
                else if (poz == 84)
                {
                    if (an1 <= 1971 && an2 >= 1971)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(224, 55, 50);


                        imagine1.BackgroundImage = Properties.Resources.stiinta84_1;
                        title1.Text = "Microprocesorul";
                        data1.Text = "1971";
                        anactual = 1971;
                        descriere1.Text = "  Creat în ianuarie 1971 de o echipă de arhitecți logici și ingineri de siliciu - Federico Faggin, Marcian (Ted) Hoff, Stanley Mazor și Masatoshi Shima - pentru producătorul japonez de calculatoare Busicom, elementul central al setului de patru cipuri a fost modelul 4004, descris inițial ca procesor microprogramabil pe 4 biți.";
                    }
                }
                else if (poz == 85)
                {
                    if (an1 <= 1971 && an2 >= 1971)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(224, 55, 50);

                        imagine1.BackgroundImage = Properties.Resources.stiinta85_1;
                        title1.Text = "Primul e-mail din lume";
                        data1.Text = "-1971-";
                        anactual = 1971;
                        descriere1.Text = "  Programatorul american Ray Tomlinson trimite primul e-mail: un mesaj-test către el însuși. În 2017, în fiecare zi au fost trimise și primite, în lumea întreagă, circa 269 de miliarde de e-mailuri. Până în 2022, numărul acestora ar urma să ajungă la peste 333 de miliarde!";
                    }
                }
                else if (poz == 86)
                {
                    if (an1 <= 1972 && an2 >= 1972)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 184, 234);
                        imagine1.BackgroundImage = Properties.Resources.stiinta86_1;
                        title1.Text = "Apollo-Soyuz";
                        data1.Text = "- 1972 -";
                        anactual = 1972;
                        descriere1.Text = "  La 24 mai 1972, președintele american Richard M. Nixon și premierul sovietic Alexei Kosîghin au semnat un acord de asociere pentru o misiune spațială cu echipaj comun și au declarat intenția ca toate viitoarele nave spațiale cu echipaj internațional să fie capabile să se cupleze între ele.";
                    }
                }
                else if (poz == 87)
                {
                    if (an1 <= 1975 && an2 >= 1975)
                    {

                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 184, 234);
                        imagine1.BackgroundImage = Properties.Resources.stiinta87_1;
                        title1.Text = "E.S.A.";
                        data1.Text = "- 31 mai 1975 -";
                        anactual = 1975;
                        descriere1.Text = "  Agenția Spațială Europeană este o organizație interguvernamentală cu sediul la Paris, a carui scop este cel al asigurării și dezvoltării cooperării, exclusiv pașnice, între statele europene în domeniile cercetării și tehnologiei spațiale. Coordonează proiectele spațiale puse în comun de peste douăzeci de țări europene. este a treia agenție spațială în lume, după NASA și Agenția Federală Spațială Rusă, a fost fondată la 31 mai 1975.Țările participante la ESA nu fac parte, în mod necesar, din Uniunea Europeană și invers.";
                    }
                }
                else if (poz == 88)
                {
                    if (an1 <= 1976 && an2 >= 1976)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(114, 219, 192);
                        imagine1.BackgroundImage = Properties.Resources.stiinta88_1;
                        title1.Text = "Apele de îmbăiere devin mai sigure";
                        data1.Text = "-1976-";
                        anactual = 1976;
                        descriere1.Text = "  Se introduc standardele privind apa de îmbăiere pentru a garanta că apa în care înotăm este curată. Marea majoritate a zonelor de îmbăiere îndeplinesc cele mai ridicate și mai exigente standarde de calitate ale UE, primind calificativul „excelent”.";
                    }
                }
                else if (poz == 89)
                {
                    if (an1 <= 1977 && an2 >= 1977)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(239, 224, 255);
                        imagine1.BackgroundImage = Properties.Resources.stiinta89_1;
                        title1.Text = "Cutremurul din Vrancea";
                        data1.Text = "-04 martie 1977-";
                        descriere1.Text = "  Cutremurul din Munții Vrancei (România) a fost resimțit în toată regiunea Balcanilor. Acesta a avut o magnitudine de 7,2, fiind al doilea cel mai puternic cutremur înregistrat în România în secolul al XX-lea. Cutremurul a omorât peste 1 500 de persoane în România și a rănit peste 11300 .  Printre victime s-au numărat actorul Toma Caragiu și scriitorii A. E. Bakonsky, Alexandru Ivasiuc și Corneliu M. Popescu. Conducătorul comunist Nicolae Ceaușescu și-a suspendat vizita oficială în Nigeria și a declarat stare de urgență.";
                    }
                }
                else if (poz == 90)
                {
                    if (an1 <= 1978 && an2 >= 1978)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(239, 224, 255);
                        imagine1.BackgroundImage = Properties.Resources.stiinta90_1;
                        title1.Text = "Primul copil conceput într-o eprubetă";
                        data1.Text = "-25 iulie 1978-";
                        anactual = 1978;
                        descriere1.Text = "  Louise Brown, primul copil din lume conceput într-o eprubetă, se naște în Regatul Unit, în urma unei proceduri de fertilizare in vitro (FIV). De atunci, milioane de copii au fost aduși pe lume cu ajutorul acestei tehnici.";
                    }
                }
                else if (poz == 91)
                {
                    if (an1 <= 1982 && an2 >= 1982)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(224, 55, 50);
                        imagine1.BackgroundImage = Properties.Resources.stiinta91_1;
                        title1.Text = "CD-urile";
                        data1.Text = "-1982-";
                        anactual = 1982;
                        descriere1.Text = "  CD-urile au fost puse la dispoziția publicului în 1982 și au devenit rapid cel mai eficient mod de stocare a muzicii. Înainte de CD-uri, muzica era stocată și redată pe casete de vinil și casetă." + Environment.NewLine + Environment.NewLine + "  Lansat pe CD în mai 1985, albumul de succes a devenit un pilon muzical, iar fanii de vinil și audiofilii au început să cumpere CD playere în masă pentru a adopta formatul în creștere. În 1988, vânzările de CD-uri au eclipsat vinilul și au depășit caseta în 1991.";
                    }
                }
                else if (poz == 92)
                {
                    if (an1 <= 1984 && an2 >= 1984)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(10, 59, 205);
                        imagine1.BackgroundImage = Properties.Resources.stiinta92_1;
                        title1.Text = "Creaare domeniilor ";
                        data1.Text = "-1984-";
                        anactual = 1984;
                        descriere1.Text = "  În 1984, este creat sistemul numelui de domeniu. Dacă inițial, fiecare adresă era recunoscută printr-un IP, ulterior acestea au devenit greu de reținut, pe măsură ce numărul lor crestea.";
                    }
                }
                else if (poz == 93)
                {

                    if (an1 <= 1985 && an2 >= 1985)
                    {
                        title1.Text = "Aparitia domeniilor";
                        data1.Text = "-1985-";
                        anactual = 1985;
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;


                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(130, 66, 13);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta93_1;
                            numaratoare1.Text = "1 din 2";
                            descriere1.Text = "  Începând cu 1985, au fost lansate primele TLDs generice: .com, .edu, .gov, .mil, .net și .org." + Environment.NewLine + Environment.NewLine + "  Primul domeniu, nordu.net (Nordic Infrstructure for Research and Education) a fost creat în prima zi a anului 1985." + Environment.NewLine + Environment.NewLine + "  La data de 15 martie 1985,este inregistrat primul domeniu comercial (.com) : symbolics.com (aferent unei companii IT) ";
                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 184, 234);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta93_2;
                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  În ceea ce privește domeniile .org, primul domeniu .org a fost înregistrat pe 10 iulie 1985 (mitre.org, aparținând Mitre Corporation)." + Environment.NewLine + Environment.NewLine + "  Primul domeniul .edu a fost înregistrat de University of California, Berkeley – berkeley.edu.";
                        }

                    }
                }
                else if (poz == 94)
                {
                    if (an1 <= 1986 && an2 >= 1986)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(251, 148, 140);
                        imagine1.BackgroundImage = Properties.Resources.stiinta94_1;
                        title1.Text = "Chernobyl";
                        data1.Text = "-25-26 aprilie 1986-";
                        anactual = 1986;
                        descriere1.Text = "  In noaptea de 25 spre 26 aprilie a anului 1986,are loc cel mai mare accident din istoria omenirii. In nordul Ucrainei, reactorul 4 de la centrala nucleara explodeaza,imprastiind in aer radiatii.Doi oameni mor instant,dar avea sa pune capat vietile a mii de oameni ce mor din cauza cancerului de tiroida.In detrimentul a 36 de ore,locuitorii orasului Pripyat sunt evacuati. Astazi , orasul ce obisnuia sa adaposteasca 50.000 de oameni este o ruina.Radiatiile ajung pana in Suedia si Canada,dar Kremlinul alege sa musamalizeze tot. Cativa ingineri curajosi se implica in oprirea radiatiilor. Sunt chemati mineri pentru a curata acoperisul reactorilui plin de elemente radioactive.Acele aparatelor Geiger indica maximul.";
                    }
             
                }
                else if (poz == 95)
                {
                    if (an1 <= 1986 && an2 >= 1986)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(45, 81, 40);
                        imagine1.BackgroundImage = Properties.Resources.stiinta95_1;
                        title1.Text = "Echipa sinucigasa";
                        data1.Text = "-1986-";
                        descriere1.Text = "  In urma exploziei reactorului 4 de la Chernobyl,radiatiile au fost imprastiate peste tot. Bazinul de apa de sub centrala atomica s-ar fi eveporat in doar cateva clipe daca ar fi atins reactorul, generand o explozie de o putere de  3-5 megatone,capabila sa sterga Europa de pe fata Pamantului. Trei suflete curajoase, inginerul superior Valeri Bespalov, inginerul mecanic Alexei Ananenko și supraveghetorul de schimburi Boris Baranov, s-au oferit voluntari pentru a intra în uzină și a deschide stavilarele.Acestia au resit  sa goleasca cu succes bazinul ce adapostea 18 milioane de litri de apa.Cu totii au supravietuit misiunii.";
                    }
                }
                else if (poz == 96)
                {
                    if (an1 <= 1987 && an2 >= 1987)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 246, 117);
                        imagine1.BackgroundImage = Properties.Resources.stiinta96_1;
                        title1.Text = "Acordul de la Montréal";
                        data1.Text = "-16 septembrie 1987-";
                        anactual = 1987;
                        descriere1.Text = "  La Montréal, în Canada, comunitatea internațională decide să ia măsuri pentru a reduce gaura din stratul de ozon, scutul de protecție din atmosfera Pământului care ne apără de efectele dăunătoare ale Soarelui. Soluția propusă este eliminarea progresivă a producției de substanțe nocive care afectează stratul de ozon. Acțiunile întreprinse de țări din întreaga lume contribuie treptat la îndeplinirea obiectivului stabilit. Acordul a fost semnat de 197 de țări, inclusiv de toate statele UE, și este considerat de mulți ca fiind cea mai reușită acțiune globală în materie de protecție a mediului.";
                    }
                }
                else if (poz == 97)
                {
                    if (an1 <= 1988 && an2 >= 1988)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 184, 234);
                        imagine1.BackgroundImage = Properties.Resources.stiinta97_1;
                        title1.Text = "Stephen Hawking";
                        data1.Text = "-01 aprilie 1988-";
                        anactual = 1988;
                        descriere1.Text = "  Se publică “A Brief History of Time” („O scurtă istorie a timpului”), cartea fizicianului britanic Stephen Hawking care îi ajută pe nespecialiști să înțeleagă o parte din misterele Universului. Cartea devine bestseller la nivel mondial. Profesorul Hawking și-a dezvoltat teoria finală cu privire la originea Universului în colaborare cu profesorul Thomas Hertog de la Universitatea Leuven din Belgia, care a beneficiat de finanțare UE. Studiul s-a publicat postum, la scurt timp după moartea lui Stephen Hawking în 2018.";
                    }
                }
                else if (poz == 98)
                {
                    if (an1 <= 1989 && an2 >= 1989)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(251, 148, 140);
                        imagine1.BackgroundImage = Properties.Resources.stiinta98_1;
                        title1.Text = "World Wide Web";
                        data1.Text = "-1989-";
                        anactual = 1989;
                        descriere1.Text = "  Tim Berners-Lee, inginer și informatician britanic, creează web-ul – „World Wide Web” sau „www”. Primul site din lume este lansat la 6 august 1991.";
                    }
                }
                else if (poz == 99)
                {
                    if (an1 <= 1990 && an2 >= 1990)
                    {
                        descriere1.ForeColor = title1.ForeColor = data1.ForeColor = Color.Goldenrod;

                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(10, 5, 53);
                        imagine1.BackgroundImage = Properties.Resources.stiinta99_1;
                        title1.Text = "Telescopul spațial Hubble";
                        data1.Text = "-24 aprilie 1990-";
                        anactual = 1990;
                        descriere1.Text = "  Se lansează pe orbită telescopul spațial Hubble, un proiect comun realizat de NASA, din SUA, și Agenția Spațială Europeană (care face posibilă cooperarea pe proiecte spațiale a 22 de țări europene)." + Environment.NewLine + "  Datorită telescopului Hubble, astronomii au găsit cea mai îndepărtată stea văzută vreodată și au identificat nouă stele-monstru de 30 de milioane de ori mai strălucitoare decât Soarele.";
                    }
                }
                else if (poz == 100)
                {
                    if (an1 <= 1994 && an2 >= 1994)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 184, 234);
                        imagine1.BackgroundImage = Properties.Resources.stiinta100_1;
                        title1.Text = "Prima taxă pe pungile din plastic și hârtie";
                        data1.Text = "-1994-";
                        anactual = 1994;
                        descriere1.Text = "  Danemarca devine prima țară din lume care introduce o taxă pe pungile din plastic și hârtie. Legislația UE prevede că toate statele membre trebuie să ia măsuri  pentru a reduce utilizarea pungilor din plastic.";
                    }
                }
                else if (poz == 101)
                {
                    if (an1 <= 1996 && an2 >= 1996)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(251, 148, 140);
                        imagine1.BackgroundImage = Properties.Resources.stiinta101_1;
                        title1.Text = "Boala vacii nebune";
                        data1.Text = "-27 martie 1996-";
                        anactual = 1996;
                        descriere1.Text = "  Comisia impune o interdicție la nivel mondial la exportul de carne de vită și produse din carne de vită provenind din Regatul Unit, ca urmare a izbucnirii unei epidemii cunoscute sub denumirea de „boala vacii nebune”. Ca răspuns la această situație și la alte crize alimentare survenite pe parcursul anilor ’90, UE elaborează norme alimentare mai stricte și înființează, în 2002, Autoritatea Europeană pentru Siguranța Alimentară, cu sediul la Parma, în Italia. Aceasta oferă consiliere științifică pe marginea riscurilor asociate lanțului alimentar.";
                    }
                }
                else if (poz == 102)
                {
                    if (an1 <= 1996 && an2 >= 1966)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 246, 117);
                        imagine1.BackgroundImage = Properties.Resources.stiinta102_1;
                        title1.Text = "Oaia Dolly";
                        data1.Text = "-05 iulie 1996-";
                        anactual = 1996;
                        descriere1.Text = "  Oamenii de știință din Scoția realizează un progres major, reușind să cloneze o oaie plecând de la o singură celulă prelevată de la o ovină în vârstă de șase ani. Oaia Dolly este copia identică a părintelui său.";
                    }
                }
                else if (poz == 103)
                {
                    if (an1 <= 1998 && an2 >= 1998)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 184, 234);
                        imagine1.BackgroundImage = Properties.Resources.stiinta103_1;
                        title1.Text = "Stația Spațială Internațională";
                        data1.Text = "-20 noiembrie 1998-";
                        anactual = 1998;
                        descriere1.Text = "  Crearea Stației spațiale internaționale începe cu lansarea pe orbită în jurul Pământului a modulului Zarya. Agenția Spațială Europeană devine partener cu drepturi depline când laboratorul Columbus (centrul european de cercetare în spațiu) se alătură stației în februarie 2008. Stația spațială internațională, care face turul complet al Pământului în 90 de minute, acționează ca bază pentru echipajele de astronauți care desfășoară experimente științifice și studiază efectele pe care le are șederea în spațiu asupra corpului omenesc. Stația reprezintă unul din primii pași ai planului NASA de explorare a altor lumi.";
                    }
                }
                else if (poz == 104)
                {
                
                    if (an1 <= 1999 && an2 >= 1999)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(239, 224, 255);
                        imagine1.BackgroundImage = Properties.Resources.stiinta104_1;
                        title1.Text = "Inventia CD-ROM-ului";
                        data1.Text = "-1999-";
                        anactual = 1999;
                        descriere1.Text = "  In timp ce astazi sunt folosite stick-urile USB,HDD externe si serviciile de memorare in Cloud, unii dintre noi am prins vremurile cand stocam informative folosind CD-ROM.Eugen Pavel este omul de stiinta roman care a inventat Hyper CD-ROM,un mediu optic de stocare a datelor care are o capacitate de 1,000,000 de GB ,echivalentul a 10,000 de CD-uri.In noimbrei 1999,si-a prezentat inventia la cea de a 48-a Expozitie Mondiala de Inovatii si Noi Tehnologii in Bruxelles si a primit recunoastere de la numeroase tari,printre care SUA,Canada,Japonia si Israel.";
                        Next.Visible = false;
                    }

                }
           
            
            
            
            
            
            
            
            
            
            
            
            }else if (s1 == true)  ///Fizica
            {
                if (poz == 1)
                {
                    if (an1 <= 1860 && an2 >= 1860)
                    {
                        Prev.Visible = false;
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);

                        title1.Text = "Fonutograful";
                        data1.Text = "-9 aprilie 1860-";
                        anactual = 1860;
                        imagine1.BackgroundImage = Properties.Resources.stiinta7_1;
                        descriere1.Text = "  Un francez pe nume Edouard-Leon Scott de Martinville a inventat un dispozitiv numit „fongoraf” , iar pe data de 9 aprilie 1860 a inregistrat pe cineva cantand <<Au clair de la lune, Pierrot repondit.>>.Trebuie remarcat faptul că această reprezentare grafică nu mai putea fi citită și redată, cum se va întâmpla mai târziu la dispozitivul lui Edison.";
                    }
                }
                else if (poz == 2)
                {
                    if (an1 <= 1876 && an2 >= 1876)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);

                        title1.Text = "Primul telefon";
                        data1.Text = "-14 februarie 1876-";
                        anactual = 1876;
                        imagine1.BackgroundImage = Properties.Resources.stiinta14_1;

                        descriere1.Text = "    În perioda 1876–1877, a apărut o nouă invenție numită telefon. Nu este ușor să se determinam cine a fost inventatorul. Atât Alexander Graham Bell, cât și Elisha Gray au depus la 14 februarie 1876 cereri de brevet independente privind telefoanele la Oficiul de Brevete din Washington." + Environment.NewLine + "    Până în 1900 existau aproape 600.000 de telefoane în sistemul telefonic al lui Bell; acest număr a ajuns la 2,2 milioane de telefoane până în 1905 și 5,8 milioane până în 1910. În 1915 a început să funcționeze linia telefonică transcontinentală.";



                    }
                }
                else if(poz==3)
                {
                    if (an1 <= 1877 && an2 >= 1877)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);

                        title1.Text = "Fonograful";
                        data1.Text = "-1877-";
                        anactual = 1877;
                        imagine1.BackgroundImage = Properties.Resources.stiinta15_1;
                        descriere1.Text = "  Primul fonograf a fost inventat de Thomas Edison în 1877 la laboratorul Menlo Park. O bucată de folie de tablă a fost înfășurată în jurul cilindrului din mijloc. Ai strigat un scurt mesaj în piesa de pe o parte a cilindrului în timp ce întorceai mânerul. În interiorul acestei piese era un ac. Vocea ta ar face ca acul să tremure sau să vibreze. Vibrațiile sonore ar trece prin ac și ar face o linie sau o canelură în folia de tablă. Un ac de cealaltă parte ar putea reda ceea ce tocmai ați înregistrat.";
                    }
                }else if (poz == 4)
                {
                    title1.Text = "Becul";
                    data1.Text = "-21 ocombrie 1879-";
                    anactual = 1879;
                    Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                    next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;
                    if (q > 2) q = 2;
                    if (q == 1)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(228, 211, 82);
                        Q11.ButtonColor = Color.MediumBlue;

                        imagine1.BackgroundImage = Properties.Resources.stiinta16_1;
                        numaratoare1.Text = "1 din 2";
                        descriere1.Text = "  Este foarte important sa stii ca becul se mandreste cu doi inventatori care au contribuit in egala masura la aparitia acestui element revolutionar. Inventia acestuia a fost facuta de catre Thomas Edison din Statele Unite ale Americii si Sir Joseph Wilson Swan din Anglia." + Environment.NewLine + "  Sir Joseph Wilson Swan este cel care a creat becul, insa acest chimist din Regatul Unit nu a reusit sa mentina vidul interior, lucru care l-a facut Thomas Edison mai tarziu, cu ajutorul unui filament. Astfel, Sir Joseph a pus bazele acestei inventii, iar Edison a reusit sa faca un bec sa lumineze timp de 40 de ore fara incetare.";
                    }
                    else if (q == 2)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(228, 211, 82);
                        Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;

                        imagine1.BackgroundImage = Properties.Resources.stiinta16_2;
                        numaratoare1.Text = "2 din 2";
                        descriere1.Text = "  In urma acestei descoperiri, cele doua genii si-au unit fortele si au realizat o companie cu numele de Edison-Swan United, care a reusit sa devina cea mai mare producatoare de becuri din lume." + Environment.NewLine + "  Tot el a raspuns, in cadrul unui interviu, ceva ce a ramas un citat celebru. La intrebarea „Cum te-ai simtit cand ai dat gres de atat de multe ori in inventarea becului?”, el a raspuns: „Nu am dat gres nici macar o data. Am dovedit cu succes de 10.000 de ori cum nu se face un bec”.";

                    }
                }else if (poz == 5)
                {
                    if (an1 <= 1881 && an2 >= 1881)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 184, 234);

                        title1.Text = "Scaunul electric";
                        data1.Text = "-1881-";
                        anactual = 1881;
                        imagine1.BackgroundImage = Properties.Resources.stiinta17_1;
                        descriere1.Text = "  Această metodă de execuție, concepută în 1881 de un medic dentist din Buffalo, New York, numit Alfred P. Southwick, a fost dezvoltată de-a lungul anilor 1880 ca o presupusă alternativă umană la spânzurare și folosită pentru prima dată în 1890.Pana in prezent, 4.374 si-au vazut sfarsitul intr-un scaun electric si s-au inregistrat 37 de executii eronate. ";
                    }
                }else if (poz == 6)
                {
                    if (an1 <= 1884 && an2 >= 1884)
                    {
                        title1.Text = "Primul oras iluminat electric din Europa";
                        data1.Text = "-12 noiembrie 1884-";
                        anactual = 1884;

                        Q11.Visible = Q12.Visible = Q13.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;
                        if (q > 3) q = 3;

                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 246, 117);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta18_1;
                            numaratoare1.Text = "1 din 3";
                            descriere1.Text = "  Printre multe alte reușite ale Romaniei,se distinge și evenimentul din 12 noiembrie 1884 când, în Timișoara, au fost aprinse 731 de lămpi electrice, o premieră în Europa, lucru care a transformat orașul de pe Bega în primul oraș iluminat electric din Europa si de pe actualul teritoriu al Romaniei.";
                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(251, 148, 140);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta18_2;
                            numaratoare1.Text = "2 din 3";
                            descriere1.Text = "  În acea zi, lămpile incandescente cu filament din cărbune au iluminat un traseu stradal cu o lungime de 59 de km, o performanţă realizată în mai puţin de doi ani de către societatea Anglo-Austriacă „Bruch Electrical Company Ltd.”, cu sediul la Viena.";

                        }
                        else if (q == 3)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 184, 234);
                            Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta18_3;
                            numaratoare1.Text = "3 din 3";
                            descriere1.Text = "Luminile orasului au fost aprinse cu ajutorul uzinei hidroelectrica de pa lacul de acumulare al canalului Bega. Aceasta este una dintre primele centrale construite in Europa si prima centrala-baraj construita pe teritoriul actual al Romaniei.";

                        }
                    }
                }else if (poz == 7)
                {
                    if (an1 <= 1886 && an2 >= 1886)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 184, 234);

                        title1.Text = "Undele radio";
                        data1.Text = "-1886-";
                        anactual = 1886;
                        imagine1.BackgroundImage = Properties.Resources.stiinta21_1;
                        descriere1.Text = "  Undele radio au fost identificate și studiate pentru prima dată de către fizicianul german Heinrich Hertz în 1886. Primele emițătoare și receptoare radio practice au fost dezvoltate în jurul anului 1895–1896 de italianul Guglielmo Marconi, iar radioul a început să fie utilizat comercial în jurul anului 1900.";

                    }
                }else if (poz == 8)
                {
                    if (an1 <= 1893 && an2 >= 1893)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);
                        title1.Text = "Prima centrala hidroelectrica";
                        data1.Text = "-1893-";
                        anactual = 1893;
                        imagine1.BackgroundImage = Properties.Resources.stiinta27_1;
                        descriere1.Text = "  La Cascada Niagara s-a construit primă centrală hidroelectrică datorită descoperirilor lui Tesla în 1893, reușind în 1896 să transmită electricitate orașului Buffalo, New York. Cu sprijinul financiar al lui George Westinghouse, curentul alternativ l-a înlocuit pe cel continuu. Tesla a fost considerat de atunci înainte fondatorul industriei electrice.";
                    }
                }else if (poz == 9)
                {
                    if (an1 <= 1905 && an2 >= 1905)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);

                        imagine1.BackgroundImage = Properties.Resources.stiinta36_1;
                        title1.Text = "Albert Einstein";
                        data1.Text = "-27 septembrie 1905-";
                        anactual = 1905;
                        descriere1.Text = "  1905 este „anul miraculos” pentru omul de știință de origine germană Albert Einstein. Acesta marchează o adevărată revoluție în domeniul științei, printr-o serie de lucrări privind diverse aspecte legate de lumină, materie, timp și spațiu. Acestea includ una dintre cele mai celebre ecuații matematice din toate timpurile: E = mc². Un deceniu mai târziu, Einstein prezintă teoria relativității generale." + Environment.NewLine + Environment.NewLine + "  „Pune mâna pe o sobă fierbinte un minut și ți se va părea o oră. Stai cu o fată frumoasă o oră și ți se va părea un minut. Aceasta e relativitatea.” – Albert Einstein";

                    }
                }else if (poz == 10)
                {
                    if (an1 <= 1910 && an2 >= 1910)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);


                        title1.Text = "Avionul lui Henri Coandă";
                        data1.Text = "-1910-";
                        anactual = 1910;
                        imagine1.BackgroundImage = Properties.Resources.stiinta38_1;
                        descriere1.Text = "  Astazi, un zbor cu avionul a ajuns o normalitatea.dar stiati ca primul motor cu propulsie a fost proiectat si construit de Henrie Coanda? in anul 1910,inventatorul roman a creeat un sistem de propulsive folosit in avioanele cu reactive. Aeroportul din Bucuresti ii poarta astazi numele.";
                    }
                }else if (poz == 11)
                {
                    if (an1 <= 1917 && an2 >= 1917)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);
                        title1.Text = "Einstein publică o lucrare revoluționară";
                        data1.Text = "-1917-";
                        anactual = 1917;
                        imagine1.BackgroundImage = Properties.Resources.stiinta43_1;
                        descriere1.Text = "  În 1917, Einstein a publicat o lucrare intitulată „Considerații cosmologice ale teoriei generale a relativității” care aplica relativitatea generală universului. Ca prim model relativist al universului, lucrarea, cunoscută mai târziu sub titlul „Universul static al lui Einstein” sau „Lumea lui Einstein”, a pus bazele cosmologiei teoretice moderne – descrierea universului în ansamblu, a găurilor negre, a stelelor neutronice și a micilor corecții la orbitele planetelor și ale navelor spațiale din sistemul nostru solar. Această lucrare ne-a schimbat percepția asupra cosmosului pentru totdeauna.";
                    }
                }else if (poz == 12)
                {
                    if (an1 <= 1924 && an2 >= 1924)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);
                        title1.Text = "Aerodinamica masinilor(Aurel Persu)";
                        data1.Text = "-1924-";
                        anactual = 1924;
                        imagine1.BackgroundImage = Properties.Resources.stiinta46_1;
                        descriere1.Text = "  Masinile din zile de astazi sunt din ce in ce mai modern,mai puternice si mai polivalente,dar lucrurile nu au fost niciodata chiar asa. Aurel Persu este inginerul roman care a contribuit la desing-ul masinii pe care o stim noi astazi. El a fost primul care a pozitionat rotile in interiorul caroseriei,iar principala lui idee este de a oferi  vehiculelor o forma aerodinamica,care sa reduca fortele de frecare,ajungand la conclusia ca masinile ar trebui sa imite,pe cat posibil,forma unei picaturi de apa.In 1924 a obtinut patent pentru descoperirile sale,in Germania,acolo unde a proiectat modelul masinii aerodinamice.";
                    }
                }else if (poz == 13)
                {
                    if (an1 <= 1930 && an2 >= 1930)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);
                        title1.Text = "Scaunul de evacuare";
                        data1.Text = "-2 aprilie 1930-";
                        anactual = 1930;
                        imagine1.BackgroundImage = Properties.Resources.stiinta48_1;
                        descriere1.Text = "  Amenajarea modernă pentru un scaun de evacuare a fost introdusă pentru prima dată de inventatorul român Anastase Dragomir,alaturi de  Tănase Dobrescu, la sfârșitul anilor 1920. Designul avea o celulă parașutată (un scaun descărcabil de pe o aeronavă sau alt vehicul). A fost testat cu succes la 25 august 1929 la Aeroportul Paris-Orly de lângă Paris și în octombrie 1929 la Băneasa , lângă București . Pe 2 aprilie 1930,Dragomir si Dobrescu au obtinut  patent pentru „cabina sa capabilă de catapultare” la Oficiul francez de inventii.";
                    }
                }else if (poz == 14)
                {
                    if (an1 <= 1959 && an2 >= 1968)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 184, 234);
                        title1.Text = "Avionul Racheta";
                        data1.Text = "- 1959-";
                        anactual = 1959;
                        imagine1.BackgroundImage = Properties.Resources.stiinta69_1;


                        descriere1.Text = "  In anul 1959 este pusa in functiune si data testarii X-15 ,o aeronava rachetă supersonică experimentală NACA, dezvoltată în colaborare cu Forțele Aeriene și Marina din SUA. Proiectul avea un fuselaj subțire, cu carenaje de-a lungul laturii care conținea combustibil și unul dintre primele sisteme de control computerizate." + Environment.NewLine + Environment.NewLine + "  Doisprezece piloți au fost selectați pentru a zbura cu acest avion.  Un total de 199 de zboruri au fost făcute între 1959 și 1968, rezultând recordul mondial oficial pentru cea mai mare viteză realizată vreodată de o aeronavă echipată cu motor cu o viteză maximă de 7.273 km/h. Recordul de altitudine pentru X-15 a fost de 107,96 km.";

                    }
                }else if (poz == 15)
                {
                    if (an1 <= 1988 && an2 >= 1988)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 184, 234);
                        imagine1.BackgroundImage = Properties.Resources.stiinta97_1;
                        title1.Text = "Stephen Hawking";
                        data1.Text = "-01 aprilie 1988-";
                        anactual = 1988;
                        descriere1.Text = "  Se publică “A Brief History of Time” („O scurtă istorie a timpului”), cartea fizicianului britanic Stephen Hawking care îi ajută pe nespecialiști să înțeleagă o parte din misterele Universului. Cartea devine bestseller la nivel mondial. Profesorul Hawking și-a dezvoltat teoria finală cu privire la originea Universului în colaborare cu profesorul Thomas Hertog de la Universitatea Leuven din Belgia, care a beneficiat de finanțare UE. Studiul s-a publicat postum, la scurt timp după moartea lui Stephen Hawking în 2018.";
                        Next.Visible = false;
                    }
                }
            }else if (s2 == true) ///chimie
            {
                if(poz==1)
                {
                    if (an1 <= 1840 && an2 >= 1840)
                    {
                        Prev.Visible = false;
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 246, 117);

                        imagine1.BackgroundImage = Properties.Resources.stiinta1_1;
                        title1.Text = "Prima sonda de petrol";
                        data1.Text = "-1840-";
                        descriere1.Text = "  Prima sonda de petrol a fost construita in Romania.Pompele de petrol care forau de 150 de metri adancime au fost puse in functiune in anul 1840 in localitatea Lucacesti,judetul Bacau. Romania a fost si prima tara din lume cu o productie inregistrata official in statisticile internationale.Revista “The Science of Petroleum” certifica la 1938 ca tara noastra avea in 1857 o productie de 275 de tone de petrol. ";

                    }
                }else if (poz == 2)
                {
                    if (an1 <= 1856 && an2 >= 1856)
                    {

                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;
                        if (q > 2) q = 2;
                        title1.Text = "Prima rafinarie de petrol";
                        data1.Text = "-1856-";
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        anactual = 1856;
                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 184, 234);
                            Q11.ButtonColor = Color.MediumBlue;

                            imagine1.BackgroundImage = Properties.Resources.stiinta5_1;
                            numaratoare1.Text = "1 din 2";

                            descriere1.Text = "   Romania este un pionier al rafinarii petrolului,prima rafinarie din lume a fost construita la marginea orasului Ploiesti.”Fabrica de gaz” asa cum au denumit-o intemeietorii ei-fratii Mehedinteanu- a fost ridicata in 1856,devenind prima distilerie sistematica de petrol. Rafinaria a fost inaugurata in anul 1857.Instalatiile rafinariei erau rudimentare;aceasta folosea vase cilindrice din fier/fonta pe care la incalzea cu lemne.Rafinaria avea o suprafata de doar 4 hectare,iar productia zilnica ajungea la aproape 7 tone.";

                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(251, 148, 140);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta5_2;
                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  Orasul Ploiesti a fost supranumit in secolul 19. “capitala aurului negru”. Lichidul produs la Ploiesti avea calitati deosebite: era incolor si inodor, ardea cu o flacara luminoasa de intensitate si forma constanta, fara fum si fara sa lase cenusa sau compusi rasinosi in fitil.";

                        }

                    }
                }else if (poz == 3)
                {
                    if (an1 <= 1857 && an2 >= 1857)
                    {
                        title1.Text = "Primul oras iluminat cu petrol lampant ";
                        data1.Text = "- 1 arpilie 1857 -";
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        anactual = 1857;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;
                        if (q > 2) q = 2;
                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(228, 211, 82);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta6_1;
                            numaratoare1.Text = "1 din 2";
                            descriere1.Text = "  In 1857,Bucurestiul a fost primul oras iluminat cu petrol lampant.în Bucureşti erau peste 785 de felinare alimentate cu petrol lampant, urmând ca – la începutul secolului 20 – să existe 3.060 de felinare cu petrol, 990 cu ulei mineral, 400 cu gaz aerian şi 200 cu becuri electrice, numite şi „lămpi cu arc voltaic”.";
                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 184, 234);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta6_2;
                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  Fraţii Mehedinteanu au reuşit să ofere servicii de iluminat cu petrol lampant pentru 336 de lei pentru fiecare felinar.Aşadar, de pe 1 aprilie 1857, Bucureştiul era iluminat cu 1.000 de astfel de lămpi. Odată cu introducerea acestor lămpi, în Bucureşti a apărut o nouă meserie, cea de lampagiu.Lampagii aveau de rezolvat o muncă solicitantă, fiind nevoiţi în fiecare zi să aprină şi să stingă lămpile care luminau Bucureştiul. ";

                        }

                    }
                }else if (poz == 4)
                {
                    if (an1 <= 1867 && an2 >= 1867)
                    {
                        title1.Text = "Introducerea dinamitei";
                        data1.Text = "-14 iulie 1867-";
                        anactual = 1867;
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;
                        if (q > 2) q = 2;
                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(228, 211, 82);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta10_1;
                            numaratoare1.Text = "1 din 2";

                            descriere1.Text = "  In 1867, inventatorul suedez Alfred Nobel a realizat prima demonstrație cu dinamită, în Merstham Quarry, Surrey. Cu un an înainte, el reușise să producă substanța despre care credea că este o formă a nitroglicerinei mai sigură și mai ușor de manevrat. Preocuparea sa pentru siguranță crescuse mult de când își pierduse un frate într-o explozie survenită la fabrica sa din Stockholm, în 1864. Scopul pentru care Nobel era interesat să producă dinamită era utilizarea acesteia în construcții. ";
                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(251, 148, 140);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.science10_2;
                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  După ce a încercat mai multe variante de combinații ale nitroglicerinei cu diferite tipuri de substanțe, Alfred Nobel a descoperit compusul chimic despre care era convins că va funcționa așa cum își dorise: diatomitul. Amestecată cu nitroglicerina, această rocă sedimentară silicioasă se transformă într-o pastă. După solidificare, noua substanță are aceeași forță de explozie ca a nitroglicerinei, dar este mult mai stabilă și rezistă la șocurile mecanice, ceea ce facilitează transportul și manipularea în condiții de siguranță. Alfred Nobel a denumit noua substanță ”dinamită”, cuvânt care provine din grecescul dynamis (putere, forță).";

                        }
                    }
                }else if (poz == 5)
                {
                    if (an1 <= 1869 && an2 >= 1869)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(251, 148, 140);

                        title1.Text = "Tabelul periodic";
                        data1.Text = "-17 februarie 1869-";
                        anactual = 1869;
                        imagine1.BackgroundImage = Properties.Resources.stiinta12_1;
                        descriere1.Text = "  În 1869 chimistul rus Dimitri Mendeleev a început dezvoltarea tabelului periodic, aranjând elementele chimice după masa atomică. El a prezis descoperirea altor elemente și a lăsat spații deschise în tabelul său periodic." + Environment.NewLine + Environment.NewLine + "  Istoricii consideră de obicei un eveniment care marchează nașterea formală a tabelului periodic modern: la 17 februarie 1869, un profesor rus de chimie, Dimitri Ivanovici Mendeleev, a finalizat prima dintre numeroasele sale diagrame periodice.";
                    }
                }else if (poz == 6)
                {
                    if (an1 <= 1886 && an2 >= 1886)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);
                        title1.Text = "Radioactivitate";
                        data1.Text = "-1886-";
                        anactual = 1886;
                        imagine1.BackgroundImage = Properties.Resources.stiinta23_1;
                        descriere1.Text = "  În 1886 fizicianul francez Antoine Bequerel a descoperit prima dată radioactivitatea. Studentul Thomson din Noua Zeelandă, Ernest Rutherford, a numit trei tipuri de radiații; razele alfa, beta și gamma. Marie și Pierre Curie au început să lucreze la radiațiile de uraniu și toriu și apoi au descoperit radiul și poloniul. Au descoperit că particulele beta erau încărcate negativ.";
                    }
                }else if (poz == 7)
                {
                    if (an1 <= 1894 && an2 >= 1894)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(251, 148, 140);
                        title1.Text = "Gazele nobile";
                        data1.Text = "-1894-";
                        anactual = 1894;
                        imagine1.BackgroundImage = Properties.Resources.stiinta28_1;
                        descriere1.Text = "  În 1894 Sir William Ramsay și Lord Rayleigh au descoperit gazele nobile, care au fost adăugate la tabelul periodic sub forma grupului 0.";
                    }
                }else if (poz == 8)
                {
                    if (an1 <= 1897 && an2 >= 1897)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);

                        title1.Text = "Descoperirea electronilor";
                        data1.Text = "-1897-";
                        anactual = 1897;
                        imagine1.BackgroundImage = Properties.Resources.stiinta30_1;
                        descriere1.Text = "  În 1897 fizicianul englez J. J. Thomson a descoperit mai întâi electroni; mici particule încărcate negativ într-un atom. John Townsend și Robert Millikan au reusit sa determine sarcina și masa exacta acestei particule.";
                    }
                }else if (poz == 9)
                {
                    if (an1 <= 1903 && an2 >= 1903)
                    {

                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);

                        title1.Text = "Marie Curie";
                        data1.Text = "-10 decembrie 1903-";
                        anactual = 1903;
                        imagine1.BackgroundImage = Properties.Resources.stiinta34_1;
                        descriere1.Text = "  Marie Curie devine prima femeie care câștigă Premiul Nobel. Născută în Polonia, sub numele de Maria Salomea Skłodowska, ea este singura femeie căreia i s-a decernat premiul de două ori, pentru fizică și pentru chimie. Astăzi, UE îi sprijină pe cercetători prin intermediul programului Marie Skłodowska-Curie. Nouă cercetători participanți la program au fost ulterior recompensați cu Premiul Nobel.";

                    }
                }else if (poz == 10)
                {
                    if (an1 <= 1914 && an2 >= 1914)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 184, 234);

                        title1.Text = "Descoperirea protonilor";
                        data1.Text = "-1914-";
                        anactual = 1914;
                        imagine1.BackgroundImage = Properties.Resources.stiinta41_1;
                        descriere1.Text = "  În 1914, Rutherford a identificat pentru prima dată protoni în nucleul atomic. De asemenea, el a transmutat pentru prima dată un atom de azot într-un atom de oxigen. Fizicianul englez Henry Moseley a furnizat numere atomice, pe baza numărului de electroni dintr-un atom, mai degrabă decât pe baza masei atomice.";
                    }
                }else if (poz == 11)
                {
                    if (an1 <= 1932 && an2 >= 1932)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 184, 234);
                        title1.Text = "Descopeirea neutronilor";
                        data1.Text = "-1932-";
                        imagine1.BackgroundImage = Properties.Resources.stiinta51_1;
                        descriere1.Text = "  În 1932, James Chadwick a descoperit pentru prima dată neutroni și s-au identificat izotopi. Aceasta a fost baza completă pentru tabelul periodic. În același an, englezul Cockroft și irlandezul Walton au împărțit mai întâi un atom bombardând litiu într-un accelerator de particule, schimbându-l în doi nuclei de heliu.";
                    }
                }else if (poz == 12)
                {
                    if (an1 <= 1935 && an2 >= 1935)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);

                        title1.Text = "Irene Joliot-Curie câștigă Premiul Nobel";
                        data1.Text = "-10 decembrie 1935-";
                        anactual = 1935;
                        imagine1.BackgroundImage = Properties.Resources.stiinta54_1;
                        descriere1.Text = "  Premiul Nobel pentru Chimie a fost decernat savantei franceze Irene Joliot-Curie (fiica lui Marie Curie) și soțului acesteia, Frédéric Joliot, pentru descoperirea radioactivității artificiale.";
                        Next.Visible = false;
                    }
                }
            
            
            
            
            
            
            
            
            
            
            }else if (s3 == true)   ///biologie
            {
                if(poz==1)
                {
                    if (an1 <= 1853 && an2 >= 1853)
                    {
                        Prev.Visible = false;
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(239, 224, 255);
                        imagine1.BackgroundImage = Properties.Resources.stiinta2_1;
                        title1.Text = "Seringa";
                        data1.Text = "-1853-";
                        descriere1.Text = "  Primul ac hipodermic a fost realizat probabil demedicul francez  Francis Rynd la Dublin în 1844, folosind tehnologia de recoacere a marginilor unei benzi plate de oțel pliate pentru a realiza un tub." + Environment.NewLine + Environment.NewLine + "  Chiar daca Rydn a inventat acul gol din metal a fost inventat în 1844,primele dispozitive recunoscute ca seringi hipodermice au fost inventate în mod independent practic simultan în 1853 de către medicul scoțian Alexander Wood și chirurgul francez Charles Gabriel Pravaz.";
                    }
                }else if (poz == 2)
                {
                    if (an1 <= 1885 && an2 >= 1885)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);

                        title1.Text = "Primul tratat de bactereologie(Victor Babes)";
                        data1.Text = "-1885-";
                        anactual = 1885;
                        imagine1.BackgroundImage = Properties.Resources.stiinta19_1;
                        descriere1.Text = "  Pentru studentii de biologie,acest lucru este sigur interesant:Victor Babes a sris primul tratat de bactereologie din lume, in colaborarea cu omul de stiinta francez Victor André Cornil,in anul 1885. El a facut contributii semnificative pentru studiul leprei,a tuberculozei si a rabiei,pentru care a introdus un vaccin. Babes este considerat al doilea biologist de rabie,dupa Luis Pasteur, si parintele scleroterapiei,un precursor al imunologiei moderne";
                    }
                 
                }else if (poz == 3)
                {
                    if (an1 <= 1885 && an2 >= 1885)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 184, 234);
                        title1.Text = "Vaccin pentru turbare";
                        data1.Text = "-6 iunie 1885-";
                        anactual = 1885;
                        imagine1.BackgroundImage = Properties.Resources.stiinta20_1;
                        descriere1.Text = "  Cercetările sale asupra turbării încep în 1880. Pasteur constată că măduva spinării de animal infectat uscată ar putea împiedica apariția acestei grave îmbolnăviri. După multiple încercări de a obține un preparat cu calități de vaccin și după multe ezitări, Pasteur face prima încercare la un copil mușcat de un câine turbat. La 6 iunie 1885, începe prima serie de injecții și, trei luni mai târziu, copilul este salvat.";
                    }
                }else if (poz == 4)
                {
                    if (an1 <= 1891 && an2 >= 1891)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(251, 148, 140);
                        title1.Text = "Descoperirea neuronului";
                        data1.Text = "-13 iulie 1891-";
                        anactual = 1891;
                        imagine1.BackgroundImage = Properties.Resources.stiinta25_1;
                        descriere1.Text = "  Pe data de 13 iulie 1891 termenul ”neuron” a fost menționat, pentru prima dată, într-un articol științific, cu sensul de celulă a sistemului nervos. Cel care l-a ”botezat” a fost anatomistul german Heinrich Wilhelm Gottfried von Waldeyer-Hartz, în numărul din 13 iulie al publicației Berliner Klinische. Wochenschrift. Anterior, cuvântul ”neuron” mai apăruse și în alte lucrări științifice, însă cu alte sensuri. De exemplu, cercetătorul B.T. Lowne numise așa partea neuronală a ochiului compus al artropodelor.";
                    }
                }else if (poz == 5)
                {
                    if (an1 <= 1897 && an2 >= 1897)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);

                        title1.Text = "Aspirina si heroina";
                        data1.Text = "-11 si 22 august 1897-";
                        anactual = 1897;
                        imagine1.BackgroundImage = Properties.Resources.stiinta31_11;
                        descriere1.Text = "  Anul 1897 a fost anul de glorie al chimistului german Felix Hoffmann , care a devenit faimos pentru sintetizarea la data de 11 august a acestui an aspirinei,una dintre cele mai utile medicamente , iar la doar 11 zile a descoperit heroina,cea mai daunatoare subsanta narcotica." + Environment.NewLine + Environment.NewLine + "  Cele doua medicamente au fost sintetizate in laboratoarele Bayer. „Aspirina”,remediul tuturor durerilor, comercializata pentru prima dată in 1899, inițial sub formă de pulbere livrată în sticle de ochelari .";

                    }
                 
                }else if (poz == 6)
                {
                    if (an1 <= 1901 && an2 >= 1901)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(251, 148, 140);

                        title1.Text = "Descoperirea grupelor sanguine";
                        data1.Text = "-1901-";
                        anactual = 1901;
                        imagine1.BackgroundImage = Properties.Resources.stiinta32_1;
                        descriere1.Text = "Medicul austriac Karl Landsteiner descoperă grupele sanguine, ceea ce permite realizarea de progrese medicale majore, cum ar fi transfuziile sigure și identificarea urmelor de sânge în domeniul medicinii legale. Medicul însuși avea grupa sanguină O.";

                    }
                }else if (poz == 7)
                {
                    if (an1 <= 1908 && an2 >= 1908)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);

                        title1.Text = "„Bătrânul din La Chapelle”";
                        data1.Text = "-03 august 1908-";
                        anactual = 1908;
                        imagine1.BackgroundImage = Properties.Resources.stiinta37_1;
                        descriere1.Text = "   În La Chapelle-aux-Saints (Franța), frații Amédée și Jean Bouyssonie, alături de Louis Bardon, descoperă rămășițele fosilizate, vechi de 60 000 de ani, ale unui bărbat din Neanderthal, aproape întreg, care va fi denumit „bătrânul din La Chapelle”." + Environment.NewLine + Environment.NewLine + "  Acesta este primul specimen de Neanderthal găsit într-un context arheologic original și primul care a fost excavat de experți și studiat cu atenție. Deoarece scheletul se afla într-o poziție flexată, fetală, fiind așezat cu grijă pe solul peșterii, experții care l-au excavat au susținut că „bătrânul” a fost înmormântat de contemporanii săi din Neanderthal. Nu se cunoaște cauza decesului.";
                    }
                }else if (poz == 8)
                {
                    if (an1 <= 1922 && an2 >= 1922)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);
                        title1.Text = "Inventia insulinei(Nicolae Constantin Paulescu)";
                        data1.Text = "-1922-";
                        anactual = 1922;
                        imagine1.BackgroundImage = Properties.Resources.stiinta45_1;
                        descriere1.Text = "  Sigur ati auzit despre insulin si poate ca stitit ca este folosita in tratarea persoanelor ce sufera de diabet. Pancreatina,ulterior denumita insulin,a fost descoperita de psihologul si profesorul de medicinca Nicolae Constantin Paulescu in anul 1922.In 1916,a reusit sa dezvolte un extract pancreatic,pe care l-a testat cu success pe un caine diabetic.S-a dovedit ca are un efect normalizator asupra nivelului de zahar din sange. Paulescu si-a publicat descoperirile de mai multe ori la o revista din Franta in anul 1921,ba chiar si-a patentat descoperirea,dar,din pacate,nu a fost recunoscut la aceea vreme.";
                    }
                }else if (poz == 9)
                {
                    if (an1 <= 1928 && an2 >= 1928)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);
                        title1.Text = "Descoperirea penicilinei";
                        data1.Text = "-28 septembrie 1928-";
                        anactual = 1928;
                        imagine1.BackgroundImage = Properties.Resources.stiinta47_1;
                        descriere1.Text = "  Alexander Fleming, medic și bacteriolog scoțian, descoperă din întâmplare penicilina. Un deceniu și jumătate mai târziu, acest antibiotic salvează primul pacient.Penicilina este folosita pentru a trata infectiile de bacterii(precum pneumonia,tuberculoza,gonoree sau febra reumatica).Dupa ce s-a intors dintr-o vacanta,Fleming a observant ca niste farfuri Petri ce contineau  stafilococ au fost contaminate cu mucegai, penicillium notatum,care prevenea cresterea bacteriilor. “Cand m-am trezit dupa rasaritul din 28 septembrie 1928, eu sigur nu am planuit sa revolutionez medicina descoperind primul antibiotic din lume” a scris Fleming.";
                    }
                }else if (poz == 10)
                {
                    if (an1 <= 1931 && an2 >= 1931)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);
                        title1.Text = "Otto Heinrich Warburg câștigă Premiul Nobel";
                        data1.Text = "-10 decembrie 1931-";
                        anactual = 1931;
                        imagine1.BackgroundImage = Properties.Resources.stiinta50_1;
                        descriere1.Text = "  Fiziologul și medicul german Otto Heinrich Warburg a primit Premiul Nobel pentru Fiziologie sau Medicină. El a studiat metabolismul tumorilor și respirația celulelor, în special a celulelor canceroase, iar premiul i-a fost decernat pentru „descoperirea naturii și a modului de acțiune al enzimelor respiratorii”. Warburg a fost nominalizat de 47 de ori la Premiul Nobel de-a lungul carierei sale.";
                    }
                }else if (poz == 11)
                {
                    if (an1 <= 1952 && an2 >= 1952)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(251, 148, 140);

                        title1.Text = "Crema anti-imbatranire ( Ana Alsan )";
                        data1.Text = "-1952-";
                        anactual = 1952;
                        imagine1.BackgroundImage = Properties.Resources.stiinta62_1;
                        descriere1.Text = "  Astazi,produsele anti-imbatranire sunt un adevarat miracol pentru doamnele care cauta un aspect mai tanar. Unul dintre primii oameni de stiinta care a descoperit efectele procainei,care se gasesc in prdusele moderne Gerovital H3 si Alsavital,Ana Alsan a infiintat primul Institut de Geriatrie(Ramură a medicinei consacrată persoanelor vârstnice, și care studiază și îngrijește bolile bătrâneții; ansamblu de măsuri recomandate în vederea întârzierii apariției senilității) din Lume in 1952. Printre pacientii acesteia, se numara Charles de Gaulle,Charlie Chaplin si John F. Kennedy. ";
                    }
                }
                else if(poz==12)
                {
                    if (an1 <= 1978 && an2 >= 1978)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(239, 224, 255);
                        imagine1.BackgroundImage = Properties.Resources.stiinta90_1;
                        title1.Text = "Primul copil conceput într-o eprubetă";
                        data1.Text = "-25 iulie 1978-";
                        anactual = 1978;
                        descriere1.Text = "  Louise Brown, primul copil din lume conceput într-o eprubetă, se naște în Regatul Unit, în urma unei proceduri de fertilizare in vitro (FIV). De atunci, milioane de copii au fost aduși pe lume cu ajutorul acestei tehnici.";
                    }
                }else if (poz == 13)
                {
                    if (an1 <= 1996 && an2 >= 1996)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(251, 148, 140);
                        imagine1.BackgroundImage = Properties.Resources.stiinta101_1;
                        title1.Text = "Boala vacii nebune";
                        data1.Text = "-27 martie 1996-";
                        anactual = 1996;
                        descriere1.Text = "  Comisia impune o interdicție la nivel mondial la exportul de carne de vită și produse din carne de vită provenind din Regatul Unit, ca urmare a izbucnirii unei epidemii cunoscute sub denumirea de „boala vacii nebune”. Ca răspuns la această situație și la alte crize alimentare survenite pe parcursul anilor ’90, UE elaborează norme alimentare mai stricte și înființează, în 2002, Autoritatea Europeană pentru Siguranța Alimentară, cu sediul la Parma, în Italia. Aceasta oferă consiliere științifică pe marginea riscurilor asociate lanțului alimentar.";
                    }
                 
                }else if (poz == 14)
                {
                    if (an1 <= 1996 && an2 >= 1966)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 246, 117);
                        imagine1.BackgroundImage = Properties.Resources.stiinta102_1;
                        title1.Text = "Oaia Dolly";
                        data1.Text = "-05 iulie 1996-";
                        anactual = 1996;
                        descriere1.Text = "  Oamenii de știință din Scoția realizează un progres major, reușind să cloneze o oaie plecând de la o singură celulă prelevată de la o ovină în vârstă de șase ani. Oaia Dolly este copia identică a părintelui său.";
                        Next.Visible = false;
                    }
                }
            
            
            
            
            
            
            
            
            
            
            }else if (s4 == true) /// Geografie si Mediu
            {
                if(poz==1)
                {
                    if (an1 <= 1866 && an2 >= 1866)
                    {
                        Prev.Visible = false;
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 246, 117);


                        title1.Text = "Ecologia";
                        data1.Text = "-1866-";
                        anactual = 1866;
                        imagine1.BackgroundImage = Properties.Resources.stiinta9_1;
                        descriere1.Text = "  Ca stiinta ,ecologia a aparut ca ramura a biologiei. In 1866 ,Ernst Heckela lansat termenul de „ecologie”, intelegand prin el studiull relatiilor dintre toate elementele mediului inconjurator. Ernst a pus atunci probema conservarii unei spceii, prin creearea unor rezervatii naturale. Cu timoul, ecologia a devenit o stiinta in sine,analizand fenomenul complex al echilibrului mediului inconjurator din punct de vedre teologic, politic si economic. ";
                    }
                }else if (poz == 2)
                {
                    if (an1 <= 1911 && an2 >= 1911)
                    {
                        title1.Text = "Polul Sud este atins";
                        data1.Text = "-14 decembrie 1911-";
                        anactual = 1911;
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;

                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 184, 234);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta39_1;
                            numaratoare1.Text = "1 din 2";
                            descriere1.Text = "  In geografie,secolul 20 incepe cu o cursa spre Polul Sud dintre ecjipa britanica a lui Robert Falcon Scott si exploratorul norvegian Ronald Amundsen.Pe data de 18 octombrei 1911,achipa de exploratori norvegieni isi incepe traseul spre Pol.Acesta porneste din Golful Balenelor,mai precis de pe banchiza Ross.De abia trei saptamani mai tarziu,englezii se aventureaza si ei in Antarctica,acestia alegand sa porneasca din Golful McMurdo";

                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 184, 234);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta39_2;
                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  Amundsen are un avantaj de 96 de km,ce ii permite sa infiga steagul norvegian in Polul Sud,la ora 3 dupa-amiaza,pe data de 14 dec. 1911. Capitanul Scott ajunge de abia peste 33 de zile,pe 17 ianuarie 1912.Datorita conditiilor meteorologice dure, britanicii nu mai reusit sa paraseasca Antarctica.";

                        }
                    }
                }
                else if(poz==3)
                {
  
                    if (an1 <= 1913 && an2 >= 1913)
                    {
                        title1.Text = "Canalul Panama";
                        descriere1.Text = "-1913-";
                        anactual = 1913;
                        numaratoare1.Text = "1 din 2";
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;

                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 184, 234);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta40_1;
                            numaratoare1.Text = "1 din 2";

                            descriere1.Text = "  Prima încercare de a construi o cale navigabilă pe istmul Panama datează din anul 1879. Către anul 1888 a fost cheltuită suma de 300 de milioane de dolari (aproape de 2 ori mai mult decât se estima la inceput), realizânduse doar o treime din proiect. Au existat mai multe motive: proiectarea incorectă (Ferdinand de Lesseps a insistat ca acest canal să fie săpat la nivelul mării), dar şi imposibilitatea tratării bolilor, precum malaria şi febra galbenă. Războiul spaniolo-american din anul 1898 a influenţat Statele Unite să decidă construirea unui canal pe istmul Panama, cu scopul de a-şi spori influenţa în zonele vestice.  ";

                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(228, 211, 82);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta40_2;
                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  În anul 1901, Statele Unite au încheiat un tratat cu Marea Britanie, potrivit căruia ei deţineau dreptul exclusiv asupra construirii canalului.Americanii au profitat, acordând un ajutor statului Panama, pentru ca acesta să se desprindă de sub influenţa Columbiei şi să işi câştige independenţa, şi au determinat autorităţile locale sa le concesioneze canalul, care a devenit astfel zonă sub controlul SUA.In toamna anului 1913,presedintele Woodrow Wilson apasa de la Washington butonul electric care deschide stavilarele canalului Panama,unind astfel pentru totdeauna cele doua oceane.";

                        }
                    }
                }
                else if (poz == 4)
                {
                    if (an1 <= 1960 && an2 >= 1960)
                    {
                        title1.Text = "Gropa Marianelor este atinsa";
                        data1.Text = "-23 ianuarie 1960-";
                        anactual = 1960;
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;

                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(228, 211, 82);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta71_1;
                            numaratoare1.Text = "1 din 2";
                            descriere1.Text = "  Groapa Marianelor se află la nord de ecuator în apropiere de Insulele Mariane ce aparțin de Melanezia. Groapa se află situată la circa 2.000 km est de Insulele Filipine și la sud de insula Guam. La nord groapa se continuă în groapa Bonin, care continuă, la rândul ei, mai departe în nord în groapa Japoniei.";
                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 184, 234);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta71_2;
                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  La 23 ianuarie 1960, Groapa Marianelor a fost vizitată de Jacques Piccard și locotenentul american  oceanograful elvetian  Don Walsh. James Cameron este “prima persoana din lume care a atins fundul oceanului, singur, in cea mai adanca zona din scoarta terestra, la o adancime record de 10.898 de metri, luni, 26 martie, la ora locala 07.52 (duminica, 25 martie, ora 22.52 GMT)”, a anuntat, de la Washington, acest grup american specializat geografie si stiinte naturale. Submarinul folosit de Cameron, “Deepsea Challenger”, a ajuns insa la 11 km adancime in Oceanul Pacific.";

                        }

                    }
                }else if (poz == 5)
                {
                    if (an1 <= 1961 && an2 >= 1961)
                    {
                        title1.Text = "Tratatul Antarcticii";
                        data1.Text = "-23 iunie 1961-";
                        anactual = 1961;
                        Q11.Visible = Q12.Visible = Q13.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;

                        if (q == 1)
                        {
                            next11.BackgroundImage = next12.BackgroundImage = Properties.Resources.nect_alb;
                            prev11.BackgroundImage = prev12.BackgroundImage = Properties.Resources.prev_alb;
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(114, 219, 192);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta76_1;
                            numaratoare1.Text = "1 din 3";
                            descriere1.Text = "  La scurt timp dupa ce SUA au testat trei bombe atomice in Antrctica, a fost deschis pentru semnare la 1 decembrie 1959, și a intrat oficial în vigoare la 23 iunie 1961. militare pe continent. Tratatul a fost primul acord de control al armamentului semnat în timpul Războiului Rece.  Obiectivul principal al tratatului este cel de a asigura în interesul întregii omeniri că Antarctica va continua să fie pentru totdeauna utilizată exclusiv în scopuri pașnice și că nu va deveni scena sau obiectul discordiei internaționale. Tratatul interzice orice măsură de natură militară, dar nu și prezența personalului militar.";

                        }
                        else if (q == 2)
                        {
                            next11.BackgroundImage = next12.BackgroundImage = Properties.Resources.nect_alb;
                            prev11.BackgroundImage = prev12.BackgroundImage = Properties.Resources.prev_alb;
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 184, 234);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta76_2;
                            numaratoare1.Text = "2 din 3";
                            descriere1.Text = "  Impreună cu o serie de alte tratate colaterale,a reglementeaza relațiile internaționale în raport cu Antarctida, singurul continent de pe Pământ fără populație umană băștinașă. În acest tratat, Antarctica este definită ca fiind tot uscatul, împreună cu banchizele aflate la sud de paralela de 60° latitudine sudică. Tratatul, care a intrat în vigoare în 1961 fiind semnat în total de 47 de țări, face din Antarctica o rezervație științifică, stabilește libertatea de cercetare științifică și interzice activitățile. ";


                        }
                        else if (q == 3)
                        {
                            next11.BackgroundImage = next12.BackgroundImage = Properties.Resources.next_g_2;
                            prev11.BackgroundImage = prev12.BackgroundImage = Properties.Resources.prev_g_1;
                            schimba_in_galben = true;
                            descriere1.ForeColor = title1.ForeColor = data1.ForeColor = Color.Goldenrod;
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(10, 5, 53);

                            Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta76_3;
                            numaratoare1.Text = "3 din 3";
                            descriere1.Text = "  Primii semnatari au fost cele 12 țări active în Antarctica în timpul Anului Geofizic Internațional 1957–1958 și care au acceptat invitația Statelor Unite la conferința la care acesta a fost negociat. Cele 12 țări aveau interese semnificative în Antarctica la acea vreme: Argentina, Australia, Belgia, Chile, Franța, Japonia, Noua Zeelandă, Norvegia, Africa de Sud, Uniunea Sovietică, Regatul Unit și Statele Unite. Aceste țări înființaseră peste 50 de stații antarctic pentru AGI.";

                        }
                    }
                }else if (poz == 6)
                {
                    if (an1 <= 1965 && an2 >= 1965)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 246, 117);
                        imagine1.BackgroundImage = Properties.Resources.stiinta80_1;
                        title1.Text = "Se inaugurează tunelul Mont Blanc";
                        data1.Text = "-16 iulie 1965-";
                        anactual = 1965;
                        descriere1.Text = "  Se inaugurează tunelul Mont Blanc, un tunel rutier construit sub masivul Mont Blanc în Alpi. Tunelul este una dintre principalele rute de transport transalpin, în special pentru Italia, care se bazează pe tunel pentru a transporta până la o treime din mărfurile care ajung în nordul Europei.";
                    }
                   
                }else if (poz == 7)
                {
                    if (an1 <= 1976 && an2 >= 1976)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(114, 219, 192);
                        imagine1.BackgroundImage = Properties.Resources.stiinta88_1;
                        title1.Text = "Apele de îmbăiere devin mai sigure";
                        data1.Text = "-1976-";
                        anactual = 1976;
                        descriere1.Text = "  Se introduc standardele privind apa de îmbăiere pentru a garanta că apa în care înotăm este curată. Marea majoritate a zonelor de îmbăiere îndeplinesc cele mai ridicate și mai exigente standarde de calitate ale UE, primind calificativul „excelent”.";
                    }
                   
                }else if (poz == 8)
                {
                    if (an1 <= 1977 && an2 >= 1977)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(239, 224, 255);
                        imagine1.BackgroundImage = Properties.Resources.stiinta89_1;
                        title1.Text = "Cutremurul din Vrancea";
                        data1.Text = "-04 martie 1977-";
                        descriere1.Text = "  Cutremurul din Munții Vrancei (România) a fost resimțit în toată regiunea Balcanilor. Acesta a avut o magnitudine de 7,2, fiind al doilea cel mai puternic cutremur înregistrat în România în secolul al XX-lea. Cutremurul a omorât peste 1 500 de persoane în România și a rănit peste 11300 .  Printre victime s-au numărat actorul Toma Caragiu și scriitorii A. E. Bakonsky, Alexandru Ivasiuc și Corneliu M. Popescu. Conducătorul comunist Nicolae Ceaușescu și-a suspendat vizita oficială în Nigeria și a declarat stare de urgență.";
                    }
                }
                else if (poz == 9)
                {
                    if (an1 <= 1986 && an2 >= 1986)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(251, 148, 140);
                        imagine1.BackgroundImage = Properties.Resources.stiinta94_1;
                        title1.Text = "Chernobyl";
                        data1.Text = "-25-26 aprilie 1986-";
                        anactual = 1986;
                        descriere1.Text = "  In noaptea de 25 spre 26 aprilie a anului 1986,are loc cel mai mare accident din istoria omenirii. In nordul Ucrainei, reactorul 4 de la centrala nucleara explodeaza,imprastiind in aer radiatii.Doi oameni mor instant,dar avea sa pune capat vietile a mii de oameni ce mor din cauza cancerului de tiroida.In detrimentul a 36 de ore,locuitorii orasului Pripyat sunt evacuati. Astazi , orasul ce obisnuia sa adaposteasca 50.000 de oameni este o ruina.Radiatiile ajung pana in Suedia si Canada,dar Kremlinul alege sa musamalizeze tot. Cativa ingineri curajosi se implica in oprirea radiatiilor. Sunt chemati mineri pentru a curata acoperisul reactorilui plin de elemente radioactive.Acele aparatelor Geiger indica maximul.";
                    }
                   
                }else if (poz == 10)
                {
                    if (an1 <= 1986 && an2 >= 1986)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(45, 81, 40);
                        imagine1.BackgroundImage = Properties.Resources.stiinta95_1;
                        title1.Text = "Echipa sinucigasa";
                        data1.Text = "-1986-";
                        descriere1.Text = "  In urma exploziei reactorului 4 de la Chernobyl,radiatiile au fost imprastiate peste tot. Bazinul de apa de sub centrala atomica s-ar fi eveporat in doar cateva clipe daca ar fi atins reactorul, generand o explozie de o putere de  3-5 megatone,capabila sa sterga Europa de pe fata Pamantului. Trei suflete curajoase, inginerul superior Valeri Bespalov, inginerul mecanic Alexei Ananenko și supraveghetorul de schimburi Boris Baranov, s-au oferit voluntari pentru a intra în uzină și a deschide stavilarele.Acestia au resit  sa goleasca cu succes bazinul ce adapostea 18 milioane de litri de apa.Cu totii au supravietuit misiunii.";
                    }
                  
                }else if (poz == 11)
                {
                    if (an1 <= 1987 && an2 >= 1987)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 246, 117);
                        imagine1.BackgroundImage = Properties.Resources.stiinta96_1;
                        title1.Text = "Acordul de la Montréal";
                        data1.Text = "-16 septembrie 1987-";
                        anactual = 1987;
                        descriere1.Text = "  La Montréal, în Canada, comunitatea internațională decide să ia măsuri pentru a reduce gaura din stratul de ozon, scutul de protecție din atmosfera Pământului care ne apără de efectele dăunătoare ale Soarelui. Soluția propusă este eliminarea progresivă a producției de substanțe nocive care afectează stratul de ozon. Acțiunile întreprinse de țări din întreaga lume contribuie treptat la îndeplinirea obiectivului stabilit. Acordul a fost semnat de 197 de țări, inclusiv de toate statele UE, și este considerat de mulți ca fiind cea mai reușită acțiune globală în materie de protecție a mediului.";
                    }
                }else if (poz == 12)
                {
                    if (an1 <= 1994 && an2 >= 1994)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 184, 234);
                        imagine1.BackgroundImage = Properties.Resources.stiinta100_1;
                        title1.Text = "Prima taxă pe pungile din plastic și hârtie";
                        data1.Text = "-1994-";
                        anactual = 1994;
                        descriere1.Text = "  Danemarca devine prima țară din lume care introduce o taxă pe pungile din plastic și hârtie. Legislația UE prevede că toate statele membre trebuie să ia măsuri  pentru a reduce utilizarea pungilor din plastic.";
                        Next.Visible = false;
                    }
                }
           
            
            
            
            
            
            
            
            
            
            
            
            }else if (s5 == true)                ////TELECOMUNICATII
            {

                if (poz == 1)
                {
                    if (an1 <= 1876 && an2 >= 1876)
                    {
                        Prev.Visible = false;
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);

                        title1.Text = "Primul telefon";
                        data1.Text = "-14 februarie 1876-";
                        anactual = 1876;
                        imagine1.BackgroundImage = Properties.Resources.stiinta14_1;

                        descriere1.Text = "    În perioda 1876–1877, a apărut o nouă invenție numită telefon. Nu este ușor să se determinam cine a fost inventatorul. Atât Alexander Graham Bell, cât și Elisha Gray au depus la 14 februarie 1876 cereri de brevet independente privind telefoanele la Oficiul de Brevete din Washington." + Environment.NewLine + "    Până în 1900 existau aproape 600.000 de telefoane în sistemul telefonic al lui Bell; acest număr a ajuns la 2,2 milioane de telefoane până în 1905 și 5,8 milioane până în 1910. În 1915 a început să funcționeze linia telefonică transcontinentală.";



                    }
                }else if (poz == 2)
                {
                    if (an1 <= 1886 && an2 >= 1886)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 184, 234);

                        title1.Text = "Undele radio";
                        data1.Text = "-1886-";
                        anactual = 1886;
                        imagine1.BackgroundImage = Properties.Resources.stiinta21_1;
                        descriere1.Text = "  Undele radio au fost identificate și studiate pentru prima dată de către fizicianul german Heinrich Hertz în 1886. Primele emițătoare și receptoare radio practice au fost dezvoltate în jurul anului 1895–1896 de italianul Guglielmo Marconi, iar radioul a început să fie utilizat comercial în jurul anului 1900.";

                    }
                }else if (poz == 3)
                {
                    if (an1 <= 1901 && an2 >= 1901)
                    {
                       
                        title1.Text = "Primul semnal radio transmis peste Atlantic";
                        data1.Text = "-12 decembrie 1901-";
                        anactual = 1901;
                        Q11.Visible = Q12.Visible = Q13.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;

                        if (q > 3) q = 3;
                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(228, 211, 82);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta33_1;
                            numaratoare1.Text = "1 din 3";

                            descriere1.Text = "  Inventatorul și inginerul italian Guglielmo Marconi trimite primul semnal radio peste Oceanul Atlantic. Acest semnal era constituit din cele trei puncte ce formează litera „S“ în Codul Morse.Transmisia a fost realizată din Anglia către Canada și a reprezentat prima radiocomunicație transatlantică.Anterior zilei de 12 decembrie 1901, Marconi avusese o altă tentativă de a transmite un semnal peste Atlantic, dar aceasta a fost fără succes.";
                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 184, 234);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta33_2;
                            numaratoare1.Text = "2 din 3";
                            descriere1.Text = "  La 19 ianuarie 1903, el reușește să transmită primul mesaj radio transatlantic, din partea președintelui SUA, Theodore Roosevelt, către regele Angliei, Eduard al VII-lea. Tehnologia lui Marconi a primit aprecieri pentru modul în care a contribuit la salvarea a sute de persoane aflate la bordul vasului Titanic, în 1912, când a permis recepționarea unui semnal de pericol trimis de către operatorul radio al navei. În urma acestui dezastru a fost modificată legislația, pentru ca aceasta să permită îmbunătățirea comunicațiilor radio și a siguranței maritime. în 1907 Marconi a recepționat prima dată un semnal radio din Canada, și anume semnul „X” din Codul Morse.";

                        }
                        else if (q == 3)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(228, 211, 82);
                            Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta33_3;
                            numaratoare1.Text = "3 din 3";
                            descriere1.Text = "  Chiar daca stia ca Marconi foloseste tehonolgii descoperite de el,inventatorul Nikola Tesla a spus “Lasa-l sa-mi foloseasca inventiile mele.Face treaba buna.”";

                        }
                    }
                }else if (poz == 4)
                {
                    if (an1 <= 1920 && an2 >= 1920)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);
                        title1.Text = "Radioul";
                        data1.Text = "-1920s-";
                        anactual = 1920;
                        imagine1.BackgroundImage = Properties.Resources.stiinta44_1;
                        descriere1.Text = "  Nașterea emisiunilor publice de radio este creditată lui Lee de Forest. A fost descrisă drept „fabrica de sunete”. Ideea radioului ca divertisment a luat avânt în 1920, odată cu deschiderea primelor posturi de radio stabilite special pentru difuzarea către public, precum KDKA din Pittsburgh și WWJ din Detroit." + Environment.NewLine + "  Popularitatea sa a crescut rapid la sfârșitul anilor 1920 și începutul anilor 1930, iar până în 1934, 60 la sută din gospodăriile națiunii aveau aparate de radio. Un milion și jumătate de mașini au fost, de asemenea, echipate cu ele. Anii 1930 au fost Epoca de Aur a radioului.";


                    }
                }else if (poz == 5)
                {
                    if (an1 <= 1931 && an2 >= 1931)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);
                        title1.Text = "Discul de vinil";
                        data1.Text = "-1931-";
                        anactual = 1931;
                        imagine1.BackgroundImage = Properties.Resources.stiinta49_1;
                        numaratoare1.Text = "1 din 2";
                        descriere1.Text = "   În 1931, RCA Victor a lansat primul disc de vinil de lungă durată disponibil comercial, comercializat ca discuri de transcriere de programe. Aceste discuri revoluționare au fost proiectate pentru redare la 33 1⁄3 rpm și au fost apăsate pe un disc flexibil din plastic cu diametrul de 30 cm, cu o durată de aproximativ zece minute de redare pe fiecare parte." + Environment.NewLine + Environment.NewLine + "  Peter Goldmark este cel care ia premiul ca inventator al discului de vinil pe care îl cunoașteți astăzi. Născut în 1906, Goldmark a ajuns să lucreze la Columbia Records ca inginer și a fost dezvoltatorul cheie al discului LP de 33 1/3 rpm.";


                    }
                }else if (poz == 6)
                {
                    if (an1 <= 1932 && an2 >= 1932)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);

                        title1.Text = "Se inaugurează BBC World Service";
                        data1.Text = "-19 decembrie 1932-";
                        anactual = 1932;
                        imagine1.BackgroundImage = Properties.Resources.stiinta52_1;
                        descriere1.Text = "  BBC World Service și-a început transmisia sub denumirea de BBC Empire Service, folosind o instalație radio cu unde scurte din Daventry, Regatul Unit. În primul său mesaj de Crăciun, regele George al V-lea a descris serviciul ca fiind destinat „bărbaților și femeilor, atât de izolați de zăpadă, deșert sau mare, încât doar vocile din aer pot ajunge la ei”.";
                    }
                }else if (poz == 7)
                {
                    if (an1 <= 1935 && an2 >= 1935)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);

                        title1.Text = "Prima transmisiune a unei televiziuni publice";
                        data1.Text = "-22 martie 1935-";
                        anactual = 1935;
                        imagine1.BackgroundImage = Properties.Resources.stiinta53_1;
                        descriere1.Text = "  Primul program al unei televiziuni publice (transmis de stația de televiziune Paul Nipkow) a fost difuzat din Funkturm, Berlin (Germania). Postul de televiziune transmitea doar în Berlin și în împrejurimi, dar a devenit foarte popular când a difuzat Jocurile Olimpice de vară din 1936 de la Berlin.";
                    }
                }else if (poz == 8)
                {
                    if (an1 <= 1944 && an2 >= 1944)
                    {
                        title1.Text = "Se instalează prima conductă petrolieră subacvatică din lume";
                        data1.Text = "-12 august 1944-";
                        anactual = 1944;
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;

                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(239, 224, 255);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta58_1;
                            numaratoare1.Text = "1 din 2";
                            descriere1.Text = "  Prima conductă petrolieră subacvatică din lume este amplasată între Regatul Unit și Franța. Operațiunea Pluto (Pipe Line Under The Ocean – Petroduct sub ocean) a fost o operațiune din cel de-al Doilea Război Mondial condusă de ingineri britanici, companii petroliere și forțele armate britanice pentru a construi conducte petroliere sub Canalul Mânecii, între Anglia și Franța, în sprijinul Operațiunii Overlord, invazia Normandiei de către forțele aliate în iunie 1944.";
                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(114, 219, 192);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta58_2;
                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  Conductele au fost considerate necesare pentru diminuarea dependenței de navele petroliere, care puteau fi încetinite de vremea rea, erau vulnerabile la submarinele germane și de care era nevoie și în Războiul din Pacific.";
                        }

                    }
                }else if (poz == 9)
                {
                    if (an1 <= 1947 && an2 >= 1947)
                    {
                        title1.Text = "Tranzistorul";
                        data1.Text = "-23 decembrie 1947-";
                        anactual = 1947;
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;

                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 184, 234);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta60_1;
                            numaratoare1.Text = "1 din 2";
                            descriere1.Text = "  Tranzistorul a fost demonstrat cu succes pe 23 decembrie 1947 la Laboratoarele Bell din Murray Hill, New Jersey. Bell Labs este brațul de cercetare al American Telephone and Telegraph (AT&T). Cei trei indivizi cărora li s-a atribuit invenția tranzistorului au fost William Shockley, John Bardeen și Walter Brattain.";
                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(228, 211, 82);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta60_2;
                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  Fără să-i spună lui Shockley schimbările pe care le făceau anchetei, Bardeen și Brattain au lucrat. La 16 decembrie 1947, au construit tranzistorul de contact punct, realizat din benzi de folie de aur pe un triunghi de plastic, împins în jos în contact cu o placă de germaniu.";

                        }
                    }
                }else if (poz == 10)
                {
                    if (an1 <= 1948 && an2 >= 1948)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(239, 224, 255);
                        title1.Text = "Un computer numit “Baby”";
                        data1.Text = "-21 iunie 1948-";
                        anactual = 1948;
                        imagine1.BackgroundImage = Properties.Resources.stiinta61_1;
                        descriere1.Text = "  Cand o masinarie, numita in gluma “Baby”, a fost pusa la viata pentru prima oar ape data de 21 iunie 1948, a devenit primul computer din lume , iar nimic nu va fi la fel din nou. Proiectat de Tom Kilburn si de Freddie Williams, doi oameni de stiinta la Universitatea Manchster din Mare Britanie, “Baby” a fost primul dopzitiv care a avut componentele care sa gasesc intr-un PC din zilele de azi. Acesta nu numai ca putea stoca  date ,dar si un scurt porgam pentru utilizator, in memorie electronica si putea procesa la viteze pe masura. Primul computer aparut vreodata a fost suficient de mare cat sa ocupe o camera intreaga, in timp ce un telefonul modern ocupa mai putin spatiu si poate memora mai multe milioane de bytes decat a putut “Baby”.";
                    }
                }else if (poz == 11)
                {
                    if (an1 <= 1956 && an2 >= 1956)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(239, 224, 255);
                        title1.Text = "Hard Disk";
                        data1.Text = "-1956-";
                        anactual = 1956;
                        imagine1.BackgroundImage = Properties.Resources.stiinta63_1;
                        descriere1.Text = "  Informat de ideile lui Jacob Rabinow de la NBS, IBM a dezvoltat și livrat prima unitate hard disk comercială (HDD), unitatea de stocare pe disc Model 350, către Zellerbach Paper, San Francisco, în iunie 1956, ca parte a IBM 305 RAMAC (Random Access Method of Contabilitate și control).";

                    }
                }else if (poz == 12)
                {
                    if (an1 <= 1958 && an2 >= 1959)
                    {

                        title1.Text = "Primul microcip";
                        data1.Text = "- 12 sepembrie 1958 -";
                        anactual = 1958;

                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;

                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 184, 234);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta66_1;
                            numaratoare1.Text = "1 din 2";
                            descriere1.Text = "  Texas Instruments îl sărbătorește pe cel din nordul Texasului, care a făcut posibil circuitul integrat - microcipul. La 12 septembrie 1958, Jack Kilby, inginer TI, a inventat circuitul integrat." + Environment.NewLine + "  El a revoluționat industria electronică, contribuind la răspândirea telefoanelor mobile și a computerelor astăzi.";
                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(239, 224, 255);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta66_2;
                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  Nu a durat mult până când Kilby și-a pus amprenta la TI. La doar câteva luni după ce s-a alăturat companiei din Dallas, în 1958, a efectuat o demonstrație de laborator pe primul său microcip pe 12 septembrie." + Environment.NewLine + "  Ulterior, Kilby a ajutat la inventarea calculatorului de mână și a imprimantei termice utilizate în terminalele de date portabile.";
                        }


                    }
                }else if (poz == 13)
                {
                    if (an1 <= 1961 && an2 >= 1961)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(239, 224, 255);
                        imagine1.BackgroundImage = Properties.Resources.stiinta75_1;
                        title1.Text = "Primul circuit integrat ";
                        data1.Text = "-25 aprilie 1961-";
                        anactual = 1961;
                        descriere1.Text = "  În timp ce se afla la Fairchild, Noyce a dezvoltat circuitul integrat. Același concept a fost inventat de Jack Kilby la Texas Instruments din Dallas cu câteva luni în urmă. În iulie 1959 Noyce a depus un brevet pentru concepția sa despre circuitul integrat." + Environment.NewLine + "   La 25 aprilie 1961, biroul de brevete a acordat primul brevet pentru un circuit integrat lui Robert Noyce în timp ce cererea lui Kilby era încă analizată.";
                    }
                   
           
                }else if (poz == 14)
                {
                    if (an1 <= 1968 && an2 >= 1968)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(45, 81, 40);
                        imagine1.BackgroundImage = Properties.Resources.stiinta81_1;
                        title1.Text = "RAM";
                        data1.Text = "-1968-";
                        anactual = 1968;
                        descriere1.Text = "  Un bit de date ar putea fi stocat pe inel și accesat în orice moment. Cu toate acestea, memoria RAM(random acces memory), așa cum o cunoaștem astăzi, ca memorie în stare solidă, a fost inventată pentru prima dată în 1968 de Robert Dennard. Cunoscuți în mod specific ca memorie dinamică cu acces aleatoriu sau DRAM, tranzistoarele au fost utilizate pentru a stoca biți de date.";
                    }
                }else if (poz == 15)
                {
                    if (an1 <= 1968 && an2 >= 1968)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(239, 224, 255);
                        imagine1.BackgroundImage = Properties.Resources.stiinta82_1;
                        title1.Text = "Imprimanta cu laser";
                        data1.Text = "-1968-";
                        anactual = 1968;
                        descriere1.Text = "  Prima imprimantă de computer proiectată a fost un aparat acționat mecanic de Charles Babbage pentru motorul său diferențiat în secolul al XIX-lea; cu toate acestea, designul său de imprimantă mecanică nu a fost construit decât în 2000. Prima imprimantă electronică a fost EP-101, inventată de compania japoneză Epson și lansată în 1968." + Environment.NewLine + Environment.NewLine + "  In 1969,Gary Starkweather a inventat imprimanta laser în laboratorul de cercetare Xerox din Webster, New York.";
                    }
                }else if (poz == 16)
                {
                    if (an1 <= 1971 && an2 >= 1971)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(224, 55, 50);


                        imagine1.BackgroundImage = Properties.Resources.stiinta84_1;
                        title1.Text = "Microprocesorul";
                        data1.Text = "1971";
                        anactual = 1971;
                        descriere1.Text = "  Creat în ianuarie 1971 de o echipă de arhitecți logici și ingineri de siliciu - Federico Faggin, Marcian (Ted) Hoff, Stanley Mazor și Masatoshi Shima - pentru producătorul japonez de calculatoare Busicom, elementul central al setului de patru cipuri a fost modelul 4004, descris inițial ca procesor microprogramabil pe 4 biți.";
                    }
              
                  
                }else if (poz == 17)
                {
                    if (an1 <= 1971 && an2 >= 1971)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(224, 55, 50);

                        imagine1.BackgroundImage = Properties.Resources.stiinta85_1;
                        title1.Text = "Primul e-mail din lume";
                        data1.Text = "-1971-";
                        anactual = 1971;
                        descriere1.Text = "  Programatorul american Ray Tomlinson trimite primul e-mail: un mesaj-test către el însuși. În 2017, în fiecare zi au fost trimise și primite, în lumea întreagă, circa 269 de miliarde de e-mailuri. Până în 2022, numărul acestora ar urma să ajungă la peste 333 de miliarde!";
                    }
                }else if (poz == 18)
                {
                    if (an1 <= 1982 && an2 >= 1982)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(224, 55, 50);
                        imagine1.BackgroundImage = Properties.Resources.stiinta91_1;
                        title1.Text = "CD-urile";
                        data1.Text = "-1982-";
                        anactual = 1982;
                        descriere1.Text = "  CD-urile au fost puse la dispoziția publicului în 1982 și au devenit rapid cel mai eficient mod de stocare a muzicii. Înainte de CD-uri, muzica era stocată și redată pe casete de vinil și casetă." + Environment.NewLine + Environment.NewLine + "  Lansat pe CD în mai 1985, albumul de succes a devenit un pilon muzical, iar fanii de vinil și audiofilii au început să cumpere CD playere în masă pentru a adopta formatul în creștere. În 1988, vânzările de CD-uri au eclipsat vinilul și au depășit caseta în 1991.";
                    }
                }else if (poz == 19)
                {
                    if (an1 <= 1984 && an2 >= 1984)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(10, 59, 205);
                        imagine1.BackgroundImage = Properties.Resources.stiinta92_1;
                        title1.Text = "Creaare domeniilor ";
                        data1.Text = "-1984-";
                        anactual = 1984;
                        descriere1.Text = "  În 1984, este creat sistemul numelui de domeniu. Dacă inițial, fiecare adresă era recunoscută printr-un IP, ulterior acestea au devenit greu de reținut, pe măsură ce numărul lor crestea.";
                    }
                }else if (poz == 20)
                {
                    if (an1 <= 1985 && an2 >= 1985)
                    {
                        title1.Text = "Aparitia domeniilor";
                        data1.Text = "-1985-";
                        anactual = 1985;
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;


                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(130, 66, 13);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta93_1;
                            numaratoare1.Text = "1 din 2";
                            descriere1.Text = "  Începând cu 1985, au fost lansate primele TLDs generice: .com, .edu, .gov, .mil, .net și .org." + Environment.NewLine + Environment.NewLine + "  Primul domeniu, nordu.net (Nordic Infrstructure for Research and Education) a fost creat în prima zi a anului 1985." + Environment.NewLine + Environment.NewLine + "  La data de 15 martie 1985,este inregistrat primul domeniu comercial (.com) : symbolics.com (aferent unei companii IT) ";
                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 184, 234);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta93_2;
                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  În ceea ce privește domeniile .org, primul domeniu .org a fost înregistrat pe 10 iulie 1985 (mitre.org, aparținând Mitre Corporation)." + Environment.NewLine + Environment.NewLine + "  Primul domeniul .edu a fost înregistrat de University of California, Berkeley – berkeley.edu.";
                        }

                    }
                }else if (poz == 21)
                {
                    if (an1 <= 1989 && an2 >= 1989)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(251, 148, 140);
                        imagine1.BackgroundImage = Properties.Resources.stiinta98_1;
                        title1.Text = "World Wide Web";
                        data1.Text = "-1989-";
                        anactual = 1989;
                        descriere1.Text = "  Tim Berners-Lee, inginer și informatician britanic, creează web-ul – „World Wide Web” sau „www”. Primul site din lume este lansat la 6 august 1991.";
                    }
               
                }else if (poz == 22)
                {
                    if (an1 <= 1999 && an2 >= 1999)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(239, 224, 255);
                        imagine1.BackgroundImage = Properties.Resources.stiinta104_1;
                        title1.Text = "Inventia CD-ROM-ului";
                        data1.Text = "-1999-";
                        anactual = 1999;
                        descriere1.Text = "  In timp ce astazi sunt folosite stick-urile USB,HDD externe si serviciile de memorare in Cloud, unii dintre noi am prins vremurile cand stocam informative folosind CD-ROM.Eugen Pavel este omul de stiinta roman care a inventat Hyper CD-ROM,un mediu optic de stocare a datelor care are o capacitate de 1,000,000 de GB ,echivalentul a 10,000 de CD-uri.In noimbrei 1999,si-a prezentat inventia la cea de a 48-a Expozitie Mondiala de Inovatii si Noi Tehnologii in Bruxelles si a primit recunoastere de la numeroase tari,printre care SUA,Canada,Japonia si Israel.";
                        Next.Visible = false;
                    }
                }
           
            
            
            
            
            
            }else if (s6 == true)  ///CURSA SPATIALA
            {
                if (poz == 1)
                {
                    if (an1 <= 1957 && an2 >= 1957)
                    {

                        Prev.Visible = false;
                        title1.Text = "Primul satelit este lansat in spatiu";
                        data1.Text = "-04 octombrie 1957-";
                        anactual = 1957;
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;

                        if (q == 1)
                        {
                            next11.BackgroundImage = next12.BackgroundImage = Properties.Resources.next_g_2;
                            prev11.BackgroundImage = prev12.BackgroundImage = Properties.Resources.prev_g_1;

                            schimba_in_galben = true;

                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(10, 5, 53);
                            Q11.ButtonColor = Color.MediumBlue;

                            descriere1.ForeColor = title1.ForeColor = data1.ForeColor = Color.Goldenrod;

                            imagine1.BackgroundImage = Properties.Resources.stiinta64_1;
                            numaratoare1.Text = "1 din 2";

                            descriere1.Text = "  Începe „era spațială”, când Uniunea Sovietică lansează pe orbită un satelit de mărimea unei mingi de baschet / a unui cuptor cu microunde, denumit Sputnik 1.Acesta cantarea 80 de kilograme si a orbitat doua luni in jurul Pamantului. Lansarea cu succes a șocat lumea, oferind fostei Uniuni Sovietice distincția de a pune în spațiu primul obiect creat de om. Sputnik a provocat isterie în rândul americanilor, care se relaxaseră crezând că sunt superiori din punct de vedere tehnologic comuniștilor. Dacă un satelit sovietic ar putea zbura peste cerul SUA, atunci cu siguranță rachetele nucleare sovietice ar putea dezlănțui furia pe solul SUA.";
                        }
                        else if (q == 2)
                        {
                            next11.BackgroundImage = next12.BackgroundImage = Properties.Resources.nect_alb;
                            prev11.BackgroundImage = prev12.BackgroundImage = Properties.Resources.prev_alb;
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(213, 151, 85);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta64_2;
                            numaratoare1.Text = "2 din 2";

                            descriere1.Text = "  Câțiva ani mai târziu, la 12 aprilie 1961, cosmonautul rus Yuri Gagarin decolează de pe aceeași platformă de lansare, devenind primul om care ajunge în spațiu.";

                        }
                    }
                }else if (poz == 2)
                {
                    if (an1 <= 1957 && an2 >= 1957)
                    {
                        title1.Text = "Laika-primul animal in spatiu";
                        data1.Text = "-3 noiembrie 1957-";
                        anactual = 1957;
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;

                        if (q == 1)
                        {
                            next11.BackgroundImage = next12.BackgroundImage = Properties.Resources.nect_alb;
                            prev11.BackgroundImage = prev12.BackgroundImage = Properties.Resources.prev_alb;
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(114, 219, 192);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta65_1;
                            numaratoare1.Text = "1 din 2";
                            descriere1.Text = "  Laika, numită inițial Kudreavka  a fost antrenată cu alți doi câini, și aleasă să ocupe nava sovietică Sputnik 2 care a fost lansată în spațiu pe data de 3 noiembrie 1957 de la Cosmodromul Baikonur din Khasahstanul sovietic.";
                        }
                        else if (q == 2)
                        {
                            next11.BackgroundImage = next12.BackgroundImage = Properties.Resources.next_g_2;
                            prev11.BackgroundImage = prev12.BackgroundImage = Properties.Resources.prev_g_1;
                            schimba_in_galben = true;

                            descriere1.ForeColor = data1.ForeColor = title1.ForeColor = Color.Goldenrod;
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(56, 26, 126);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta65_2_;

                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  Laika,un fost caine vagabond cules de pe strazile Moscovei, si-a gasit sfarsitul in satelitul –care a fost proiectat doar pentru un drum dus,nu si intors-a supraviețuit pe orbită timp de patru zile și apoi a murit când cabina s-a supraîncălzit.";

                        }


                    }
                }else if (poz == 3)
                {
                    if (an1 <= 1958 && an2 >= 1958)
                    {

                        title1.Text = "NASA";
                        data1.Text = "-29 iulie 1958-";
                        anactual = 1958;
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;

                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 184, 234);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta67_1;
                            numaratoare1.Text = "1 din 2";
                            descriere1.Text = "  Pentru a recupera progresul înregistrat de Uniunea Sovietică, a fost înființată NASA la 29 iulie 1958 pentru a administra și a realiza proiecte de astronautică civilă, care anterior erau susținute de diverse ramuri ale Forțelor Armate ale Statelor Unite, pentru a recupera progresul înregistrat de Uniunea Sovietică. NASA a preluat centrele de cercetare de la Comitetul Național Consultativ pentru Aeronautică (NACA), care anterior era îndreptată spre cercetare în domeniul aeronautic.";
                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 184, 234);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta67_2;
                            numaratoare1.Text = "1 din 2";
                            descriere1.Text = "  Noua agenție are o orientare civilă distinctă, încurajând aplicațiile pașnice în știința spațială. De la înființarea sa, majoritatea eforturilor de explorare spațială din SUA au fost conduse de NASA, inclusiv misiunile Apollo, stația spațială Skylab și, ulterior, naveta spațială. NASA sprijină Stația Spațială Internațională și supraveghează dezvoltarea vehiculului multifuncțional Orion, a sistemului de lansare spațială și a vehiculelor comerciale cu echipaj. "; ;

                        }
                    }
                   
                }else if (poz == 4)
                {
                    if (an1 <= 1958 && an2 >= 1958)
                    {
                        title1.Text = "Mercury";
                        data1.Text = "- 1958-1958 -";
                        anactual = 1958;
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;

                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 184, 234);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta68_1;
                            numaratoare1.Text = "1 din 2";
                            descriere1.Text = "  Project Mercury a fost programul NASA care a pus primii astronauți americani în spațiu. Astronauții au realizat în total șase zboruri spațiale în timpul Proiectului Mercur. Două dintre aceste zboruri au ajuns în spațiu și au coborât imediat. Acestea se numesc zboruri suborbitale.Ceilalți patru au intrat pe orbită și au încercuit Pământul. Primul dintre aceste șase zboruri a fost efectuat în 1961.Ultimul zbor a fost efectuat în 1963,iar rachetele folosite au fost initial construite cu scopul de focoase nucleare.";
                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(228, 211, 82);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta68_2;
                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  Proiectul a fost numit Mercur după un zeu roman care a fost foarte rapid. Fiecare astronaut și-a numit nava spațială. Alan Shepard a inclus un 7 în numele capsulei sale Mercury. Acest lucru s-a întâmplat pentru că a fost realizat al șaptelea. Ceilalți astronauți au inclus și un 7. Aceasta a fost în cinstea celor șapte astronauți aleși pentru proiect.";

                        }
                    }
                }else if (poz == 6)
                {
                    if (an1 <= 1959 && an2 >= 1968)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 184, 234);
                        title1.Text = "Avionul Racheta";
                        data1.Text = "- 1959-";
                        anactual = 1959;
                        imagine1.BackgroundImage = Properties.Resources.stiinta69_1;


                        descriere1.Text = "  In anul 1959 este pusa in functiune si data testarii X-15 ,o aeronava rachetă supersonică experimentală NACA, dezvoltată în colaborare cu Forțele Aeriene și Marina din SUA. Proiectul avea un fuselaj subțire, cu carenaje de-a lungul laturii care conținea combustibil și unul dintre primele sisteme de control computerizate." + Environment.NewLine + Environment.NewLine + "  Doisprezece piloți au fost selectați pentru a zbura cu acest avion.  Un total de 199 de zboruri au fost făcute între 1959 și 1968, rezultând recordul mondial oficial pentru cea mai mare viteză realizată vreodată de o aeronavă echipată cu motor cu o viteză maximă de 7.273 km/h. Recordul de altitudine pentru X-15 a fost de 107,96 km.";

                    }
                   
                }else if (poz == 7)
                {
                    if (an1 <= 1959 && an2 >= 1959)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);
                        title1.Text = "Luna este atinsa ";
                        data1.Text = "-14 septembrie 1959-";
                        anactual = 1959;
                        imagine1.BackgroundImage = Properties.Resources.stiinta70_1;
                        descriere1.Text = "   Explorarea fizică a Lunii a început atunci când Luna 2, o sondă spațială lansată de Uniunea Sovietică, s-a prăbușit pe suprafața Lunii pe 14 septembrie 1959. Până atunci singurul mijloc disponibil de explorare a Lunii a fost observația de pe Pământ.";
                    }
                }else if (poz == 8)
                {

                    if (an1 <= 1961 && an2 >= 1961)
                    {
                        title1.Text = "Gemini";


                        data1.Text = "- 1961 -";
                        anactual = 1961;
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;

                        if (q == 1)
                        {
                            next11.BackgroundImage = next12.BackgroundImage = Properties.Resources.next_g_2;
                            prev11.BackgroundImage = prev12.BackgroundImage = Properties.Resources.prev_g_1;
                            schimba_in_galben = true;
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(10, 5, 53);
                            Q11.ButtonColor = Color.MediumBlue;

                            descriere1.ForeColor = title1.ForeColor = data1.ForeColor = Color.Goldenrod;

                            imagine1.BackgroundImage = Properties.Resources.stiinta72_1;
                            numaratoare1.Text = "1 din 2";
                            descriere1.Text = "  NASA a numit nava spațială și programul Gemini după constelația Gemini. Numele este în latină pentru „gemeni”. NASA a folosit acest nume deoarece capsula Gemeni ar transporta două persoane.";

                        }
                        else if (q == 2)
                        {
                            next11.BackgroundImage = next12.BackgroundImage = Properties.Resources.nect_alb;
                            prev11.BackgroundImage = prev12.BackgroundImage = Properties.Resources.prev_alb;
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(228, 211, 82);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta72_2;
                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  Capsula Gemenilor a zburat pe o rachetă Titan II. Titan II în două etape a fost inițial o focoasa. NASA a modificat racheta pentru a putea transporta oameni. Înainte ca primii astronauți să zboare pe el, a lansat fără echipaj, astfel încât NASA să-și poată testa siguranța. Gemini 4 a inclus prima plimbare spatiala din istorie.";
                        }

                    }




                }else if (poz == 9)
                {
                    if (an1 <= 1961 && an2 >= 1961)
                    {
                        title1.Text = "Apollo";
                        data1.Text = "- 1961 -";
                        anactual = 1961;
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;

                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(213, 151, 85);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta73_1;
                            numaratoare1.Text = "1 din 2";
                            descriere1.Text = "   În 1961, J.F.K. a provocat națiunea să aterizeze astronauți pe Lună până la sfârșitul deceniului. NASA a întâmpinat această provocare cu programul Apollo. A fost prima dată când ființele umane au părăsit orbita Pământului și au vizitat o altă lume. Apollo a fost programul NASA care a avut ca rezultat astronauții americani să facă un total de 11 zboruri spațiale și să meargă pe Lună.";
                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(228, 211, 82);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta73_2;

                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  Silverstein de la NASA a ales numele „Apollo” după ce a analizat acasă o carte de mitologie într-o seară din 1960. El a spus că imaginea „Apollo călărind carul său peste soare este potrivită pentru marea scară a programului propus”.";
                        }

                    }
                }else if (poz ==10)
                {
                    if (an1 <= 1961 && an2 >= 1961)
                    {
                        title1.Text = "Primul om in spatiu";
                        data1.Text = "- 12 aprilie 1961 -";
                        anactual = 1961;

                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;

                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;

                        if (q == 1)
                        {
                            next11.BackgroundImage = next12.BackgroundImage = Properties.Resources.next_g_2;
                            prev11.BackgroundImage = prev12.BackgroundImage = Properties.Resources.prev_g_1;
                            schimba_in_galben = true;

                            descriere1.ForeColor = title1.ForeColor = data1.ForeColor = Color.Goldenrod;
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(10, 5, 53);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta74_1;
                            numaratoare1.Text = "1 din 2";
                            descriere1.Text = "  Yuri Gagarin a fost un cosmonaut sovietic, primul om care a ajuns în spațiul cosmic pe date de 12 aprilie 1961 . Calatoria lui a durat 108 de minute si a obirtat in jurul Pamantului o data si un pic in aeronava Uniunii Sovietice Vostok.Chiar si astazi, numele cosmonautului a ramas pe multe din muzeele din Rusia si poarta un loc de onoare pe holurile Kremlinului. ";
                        }
                        else if (q == 2)
                        {
                            next11.BackgroundImage = next12.BackgroundImage = Properties.Resources.nect_alb;
                            prev11.BackgroundImage = prev12.BackgroundImage = Properties.Resources.prev_alb;

                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(228, 211, 82);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta74_2;
                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  Satelitul a reusit sa se indeparteze cu 327 de kilometri de Terra. Vostok 1 nu avea motoare care să-i încetinească reintrarea și nici o cale de aterizare în siguranță. La aproximativ 7 km în sus, Gagarin a ieșit din nava spațială și a parașutat pe Pământ. Pentru ca misiunea să fie luată în considerare ca un zbor spațial oficial, Fédération Aéronautique Internationale (FAI), organul de conducere pentru înregistrările aerospațiale, a stabilit că pilotul trebuie să aterizeze cu nava spațială. Liderii sovietici au indicat că Gagarin a atins cu Vostok 1 și nu au dezvăluit că el a expulzat până în 1971. Indiferent, Gagarin a stabilit încă recordul ca prima persoană care a părăsit orbita Pământului și a călătorit în spațiu.";

                        }
                    }
                }else if (poz == 11)
                {
                    if (an1 <= 1965 && an2 >= 1965)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 184, 234);
                        imagine1.BackgroundImage = Properties.Resources.stiinta78_1;
                        title1.Text = "Prima plimbare spatiala ";
                        data1.Text = "-14 martie 1965-";
                        anactual = 1965;
                        descriere1.Text = "  La 18 martie 1965, cosmonautul sovietic Alexei Leonov a realizat prima plimbare spațială din istorie în timpul unei excursii de 10 minute în misiunea Voskhod 2, bătându-i pe americani cu aproape trei luni. În timpul misiunii Gemeni IV din iunie 1965, Ed White a devenit primul american care a condus o plimbare spațială.";
                    }
                }else if (poz == 12)
                {
                    if (an1 <= 1965 && an2 >= 1965)
                    {
                        title1.Text = "Skylab";
                        data1.Text = "- 1965 -";
                        anactual = 1965;
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;

                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 184, 234);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta79_1;
                            numaratoare1.Text = "1 din 2";
                            descriere1.Text = "  Skylab a fost prima și singura stație spațială americană construită independent.[49] Conceput în 1965 ca un atelier care urma să fie construit în spațiu din stadiul superior a lui Saturn IB, stația de 77.088 kg a fost construită pe Pământ și lansată la 14 mai 1973, pe o orbită la 435 km înclinată la 50° față de ecuator. Acesta a inclus un laborator pentru studierea efectelor microgravității și un observator solar. ";
                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 184, 234);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta79_2;
                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  NASA a planificat să aibă o navetă spațială pe ea și să ridice Skylab la o altitudine mai înaltă și mai sigură, dar naveta nu era pregătită să zboare înainte de reîntoarcerea lui Skylab la 11 iulie 1979.Pentru a economisi costurile, NASA a folosit pentru lansarea Skylab una dintre rachetele Saturn V.";

                        }

                    }
                }else if (poz == 13)
                {
                    if (an1 <= 1969 && an2 >= 1969)
                    {
                        title1.Text = "Aselenizarea lui Neil Armstrong ";
                        data1.Text = "-20 iulie 1969-";
                        anactual = 1969;
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;

                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(228, 211, 82);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta83_1;
                            numaratoare1.Text = "1 din 2";
                            descriere1.Text = "  Neil Armstrong este un fost astronaut American, primul om care a pășit pe Lună pe data 20 iulie 1969, în timpul misiunii Apollo 11. Cu ocazia coborârii pe suprafața Lunii, Armstrong a rostit „Un pas mic pentru om, un salt uriaș pentru omenire”, citat devenit ulterior celebru. La aselenizare a participat și astronautul Buzz Aldrin. Evenimentul a fost urmărit de milioane de oameni din întreaga lume. Misiunea a fost una reușită, în ciuda scepticismului multora (chiar Neil Armstrong a declarat ulterior că înainte de misiune considera că există 50% șanse să revină pe Pământ de pe suprafața lunară).";
                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(251, 148, 140);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta83_2;
                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = "  Programul Apollo al NASA a fost prima, și până în prezent singura, misiune spațială în care oamenii au ajuns pe suprafața Lunii. "; ;
                        }

                    }
                }else if (poz == 14)
                {
                    if (an1 <= 1972 && an2 >= 1972)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 184, 234);
                        imagine1.BackgroundImage = Properties.Resources.stiinta86_1;
                        title1.Text = "Apollo-Soyuz";
                        data1.Text = "-1972 -";
                        anactual = 1972;
                        descriere1.Text = "  La 24 mai 1972, președintele american Richard M. Nixon și premierul sovietic Alexei Kosîghin au semnat un acord de asociere pentru o misiune spațială cu echipaj comun și au declarat intenția ca toate viitoarele nave spațiale cu echipaj internațional să fie capabile să se cupleze între ele.";
                    }
              
                }else if (poz == 15)
                {
                    if (an1 <= 1975 && an2 >= 1975)
                    {

                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 184, 234);
                        imagine1.BackgroundImage = Properties.Resources.stiinta87_1;
                        title1.Text = "E.S.A.";
                        data1.Text = "- 31 mai 1975 -";
                        anactual = 1975;
                        descriere1.Text = "  Agenția Spațială Europeană este o organizație interguvernamentală cu sediul la Paris, a carui scop este cel al asigurării și dezvoltării cooperării, exclusiv pașnice, între statele europene în domeniile cercetării și tehnologiei spațiale. Coordonează proiectele spațiale puse în comun de peste douăzeci de țări europene. este a treia agenție spațială în lume, după NASA și Agenția Federală Spațială Rusă, a fost fondată la 31 mai 1975.Țările participante la ESA nu fac parte, în mod necesar, din Uniunea Europeană și invers.";
                    }
                 
                }else if (poz == 16)
                {
                    if (an1 <= 1998 && an2 >= 1998)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 184, 234);
                        imagine1.BackgroundImage = Properties.Resources.stiinta103_1;
                        title1.Text = "Stația Spațială Internațională";
                        data1.Text = "-20 noiembrie 1998-";
                        anactual = 1998;
                        descriere1.Text = "  Crearea Stației spațiale internaționale începe cu lansarea pe orbită în jurul Pământului a modulului Zarya. Agenția Spațială Europeană devine partener cu drepturi depline când laboratorul Columbus (centrul european de cercetare în spațiu) se alătură stației în februarie 2008. Stația spațială internațională, care face turul complet al Pământului în 90 de minute, acționează ca bază pentru echipajele de astronauți care desfășoară experimente științifice și studiază efectele pe care le are șederea în spațiu asupra corpului omenesc. Stația reprezintă unul din primii pași ai planului NASA de explorare a altor lumi.";
                        Next.Visible = false;
                    }
                }
            
            
            
            
            
            
            }else if (s7 == true)  // gastronomie
            {
                if (poz == 1)
                {
                    if (an1 <= 1853 && an2 >= 1853)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);
                        imagine1.BackgroundImage = Properties.Resources.stiinta3_1;
                        title1.Text = "Acidul margaric";
                        data1.Text = "-1853-";
                        descriere1.Text = "  Originea margarinei incepe cu descoperirea acidului margaric, realizata de chimistul francez, Michel Eugene Cevreul, in 1813. Cercetatorii de atunci au constatat ca acidul margaric este unul din cei trei acizi grasi care, in combinatie, formau majoritatea grasimilor animale. In anul 1853, chimistul german Wilhelm Heinrich Heintz a analizat acidul margaric ca o simpla combinatiei de acid steraic si a necunoscutului acid palmitic.";

                        Prev.Visible = false;
                    }
                }else if (poz == 2)
                {
                    if (an1 <= 1862 && an2 >= 1862)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(127, 184, 234);

                        title1.Text = "Pasteurizarea";
                        data1.Text = "-20 aprilie 1862-";
                        anactual = 1862;
                        imagine1.BackgroundImage = Properties.Resources.stiinta8_1;
                        descriere1.Text = "  În 1856, un industriaş l-a rugat pe Luis Pasteur să afle de ce vinul şi berea se acresc odată cu trecerea timpului. Pasteur a demonstrat că atât fermentaţia, cât şi alterarea erau provocate tot de microorganisme. Omul de ştiinţă a prezentat o modalitate prin care se poate preîntâmpina alterarea, numită astăzi ''pasteurizare''. Încălzind vinul până la 50 de grade Celsius, sunt omorâte microorganismele care îl pot altera. Procesul de pasteurizare a fost testat cu succes la 20 aprilie 1862.";
                    }
                }else if (poz == 3)
                {
                    if (an1 <= 1869 && an2 >= 1869)
                    {
                        title1.Text = "Margarina ";
                        data1.Text = "-1869-";
                        anactual = 1869;
                        Q11.Visible = Q12.Visible = numaratoare1.Visible = true;
                        next11.Visible = next12.Visible = prev11.Visible = prev12.Visible = true;
                        if (q > 2) q = 2;
                        if (q == 1)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(127, 246, 117);
                            Q11.ButtonColor = Color.MediumBlue;
                            imagine1.BackgroundImage = Properties.Resources.stiinta11_1;
                            numaratoare1.Text = "1 din 2";
                            descriere1.Text = "  Imparatul Napoleon al III-lea al Frantei a oferit un premiu pentru cel care putea inventa o alternativa satisfacatoare a untului, potrivita pentru a fi folosita de catre fortele armate si de catre clasele sociale inferioare.Chimistul francez, Hippolyte Mege-Mouries a inventat substanta numita “oleomargarina”, nume care a fost scurtat ulterior in “margarina”. Chimistul și-a patentat invenția în anul 1869. În 1871, Mege-Mouries și-a vândut brevetul companiei olandeze “Jurgens”, acum parte din “Unilever”.";
                        }
                        else if (q == 2)
                        {
                            background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Q11.BackColor = Q12.BackColor = Q11.ForeColor = Q12.ForeColor = Q13.BackColor = Q13.ForeColor = numaratoare1.BackColor = numaratoare1.ForeColor = Q11.ButtonColor = Q12.ButtonColor = Q13.ButtonColor = Color.FromArgb(228, 211, 82);
                            Q11.ButtonColor = Q12.ButtonColor = Color.MediumBlue;

                            imagine1.BackgroundImage = Properties.Resources.stiinta11_2;
                            numaratoare1.Text = "2 din 2";
                            descriere1.Text = " În același an, farmacistul german Benedict Klein și-a deschis prima fabrică de margarină. Principala materie prima din formulă originală a margarinei a fost grăsimea de vită, dar în anul 1871, Herny W. Bradley și-a patentat procedeul de fabricare a margarinei ce combină uleiuri vegetale cu grăsimi animale. ";

                        }
                    }
                }else if (poz == 4)
                {
                    if (an1 <= 1891 && an2 >= 1891)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(228, 211, 82);
                        title1.Text = "Pudra de copt";
                        data1.Text = "-1891-";
                        anactual = 1891;
                        imagine1.BackgroundImage = Properties.Resources.stiinta26_1;
                        descriere1.Text = "  In 1891,un chimist pe nume August Oetker impacheteaza plicuri mici de praf de copt si scrie carti de bucate care sa vand in 18,4 milioane de exemplare. La 21 septembrie 1903, Oetker a depus un brevet pentru procedura sa de fabricare a pudrei de copt de lungă durată sau a făinii gata preparate.";
                    }
                }else if (poz == 5)
                {
                    if (an1 <= 1936 && an2 >= 1936)
                    {
                        background1.BackColor = title1.BackColor = descriere1.BackColor = data1.BackColor = Color.FromArgb(239, 224, 255);

                        title1.Text = "Crenvurstii medicinali sovietici";
                        data1.Text = "-1936-";
                        anactual = 1936;
                        imagine1.BackgroundImage = Properties.Resources.stiinta57_1;

                        descriere1.Text = "  Crenvurstii, raspanditi rapid si asociati cu berea in intreaga Europa, au ajuns in Rusia tarista asociati cu vodca, iar mai taziu erau serviti in restaurante ca „felul doi”, cu mustar iute si garnitura din piure de cartofi, indulcit cu zahar." + Environment.NewLine + Environment.NewLine + "  In 1936, medicilor rusi li s-a parut ca acesti carnaciori fragezi sunt indicati pentru tonifierea bolnavilor si astfel au aparut sub denumirea de „carnati medicinali”.Alaturi de ceaiurile medicinale, crenvurstii sovietici au reprezentat multa vreme un constituent de baza al medicinii naturiste";


                        Next.Visible = false;
                    }
                }
            }
        }



        private void subiecte_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void OnMouseEnterT1(object sender, EventArgs e)
        {
            C1.Visible = C2.Visible = false;
            T1.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Underline);


        }
        private void OnMouseLeaveT1(object sender, EventArgs e)
        {
            T1.Font = new Font("Microsoft Sans Serif", 20);


        }
        private void OnMouseEnterE1(object sender, EventArgs e)
        {
            C1.Visible = C2.Visible = false;
            E1.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Underline);


        }
        private void OnMouseLeaveE1(object sender, EventArgs e)
        {
           
            E1.Font = new Font("Microsoft Sans Serif", 20);


        }
        private void OnMouseEnterSC1(object sender, EventArgs e)
        {
            C1.Visible = C2.Visible = false;
            SC1.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Underline);


        }
        private void OnMouseLeaveSC1(object sender, EventArgs e)
        {
           
            SC1.Font = new Font("Microsoft Sans Serif", 20);


        }


        private void OnMouseEnterBiog1(object sender, EventArgs e)
        {
            C1.Visible = C2.Visible = false;
            Biog1.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Underline);


        }
        private void OnMouseLeaveBiog1(object sender, EventArgs e)
        {
            Biog1.Font = new Font("Microsoft Sans Serif", 20);


        }


        private void OnMouseEnternext11(object sender, EventArgs e)
        {
            next11.BackgroundImage = next12.BackgroundImage = Properties.Resources.next_negru;

            if( schimba_in_galben==true)
            {
                next11.BackgroundImage = next12.BackgroundImage = Properties.Resources.next__g_2;
               
   
            }
           


        }
        private void OnMouseLeavenext11(object sender, EventArgs e)
        {

            next11.BackgroundImage = next12.BackgroundImage = Properties.Resources.nect_alb;
            if (schimba_in_galben == true)
            {
                next11.BackgroundImage = next12.BackgroundImage = Properties.Resources.next_g_2;


            }
            if (schimba_in_galben == true)
            {
                next11.BackgroundImage = next12.BackgroundImage = Properties.Resources.next_g_2;

            }
        }

    

        private void OnMouseEnterprev11(object sender, EventArgs e)
        {
            prev11.BackgroundImage = prev12.BackgroundImage = Properties.Resources.prev_negru;
            if (schimba_in_galben == true)
            {
                prev11.BackgroundImage = prev12.BackgroundImage = Properties.Resources.prev_g_2;


            }
            if (schimba_in_galben == true)
            {
                prev11.BackgroundImage = prev12.BackgroundImage = Properties.Resources.prev_g_2;

            }
        }
        private void OnMouseLeaveprev11(object sender, EventArgs e)
        {

            prev11.BackgroundImage = prev12.BackgroundImage = Properties.Resources.prev_alb ;
            if (schimba_in_galben == true)
            {
                prev11.BackgroundImage = prev12.BackgroundImage = Properties.Resources.prev_g_1;


            }
            if (schimba_in_galben == true)
            {
                prev11.BackgroundImage = prev12.BackgroundImage = Properties.Resources.prev_g_1;

            }
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



    }
}
