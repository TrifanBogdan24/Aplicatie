using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Aplicatie
{
    public partial class Form1 : Form
    {
        int x1, y1, z1, x2, y2, z2;
        int nr;
        int meme;
        int refuz;
        bool memes;


        
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // width of ellipse
          int nHeightEllipse // height of ellipse
      );
        public Form1()
        {
            InitializeComponent();

           this.WindowState = FormWindowState.Maximized;
          //   this.StartPosition = FormStartPosition.CenterScreen;
           


            stanga_output.BackColor = Color.FromArgb(198, 131, 14);
            stanga_output.Visible = true;
            ARROW.Visible =  SC1.Visible = S1.Visible = Biog1.Visible = T1.Visible = false;

            x1 = 22;y2 = 18;z1 = 126; //bleumarin
            x2 = 236;y2 = 240;z2 = 241; ///alb


            meme = 0;refuz = 0;memes = false;
            interogatoriu.Visible = DA.Visible = NU.Visible = mafiamember.Visible = false;
          

            //ptr scis 124, 75, 23

            

            ARROW.BackgroundImage = Properties.Resources.left;



            TAB.BackgroundImage = Properties.Resources.bars;
            TAB2.Image=TAB.Image= Properties.Resources.bars;

             panel2.BackColor= panel1.BackColor = Color.FromArgb(198, 131, 14) ;


 
           S2.ForeColor=Biog2.ForeColor=T2.ForeColor=SC2.ForeColor =Color.FromArgb(x2,y2,z2);
            
             SC1.FlatStyle = SC2.FlatStyle = Biog1.FlatStyle = Biog2.FlatStyle = T1.FlatStyle = T2.FlatStyle =S1.FlatStyle=S2.FlatStyle= FlatStyle.Flat;

           SC1.Font = S1.Font = T1.Font = Biog1.Font = new Font("Microsoft Sans Serif",20);

             SC2.Font = S2.Font = T2.Font = Biog2.Font = new Font("Microsoft Sans Serif", 20);

          //  Color.FromArgb(x2, y2, z2);
           
           
            SC1.ForeColor = S1.ForeColor = T1.ForeColor = Biog1.ForeColor = Color.FromArgb(x2,y2,z2);
           
            cauta_events.BackColor = Color.FromArgb(198, 131, 14);
            cauta_events.ForeColor = Color.FromArgb(x2,y2,z2);
            cauta_events.FlatStyle = FlatStyle.Flat;
           
            cauta_events.Font = new Font("Micorsoft Sans Serif",20);

           
            ARROW.Cursor = TAB2.Cursor = TAB.Cursor = Biog1.Cursor = Biog2.Cursor = SC1.Cursor = SC2.Cursor = T1.Cursor = T2.Cursor = S1.Cursor = S2.Cursor = Cursors.Hand;
            Biog2.MouseEnter += OnMouseEnterBiog2;
            Biog2.MouseLeave += OnMouseLeaveBiog2;

            SC2.MouseEnter += OnMouseEnterSC2; SC2.MouseLeave += OnMouseLeaveSC2;
            T2.MouseEnter += OnMouseEnterT2;
            T2.MouseLeave += OnMouseLeaveT2;
            S2.MouseEnter += OnMouseEnterS2;
            S2.MouseLeave += OnMouseLeaveS2;

            T1.MouseEnter += OnMouseEnterT1; T1.MouseLeave += OnMouseLeaveT1;
            SC1.MouseEnter += OnMouseEnterSC1; SC1.MouseLeave += OnMouseLeaveSC1;
            S1.MouseEnter += OnMouseEnterS1; S1.MouseLeave += OnMouseLeaveS1;
            Biog1.MouseEnter += OnMouseEnterBiog1; Biog1.MouseLeave += OnMouseLeaveBiog1;
            cauta_events.MouseEnter += OnMouseEntercauta_events1;cauta_events.MouseLeave += OnMouseLeavecauta_events1;
            panel2.Visible = false;

            P1.Font = P2.Font = P3.Font = P4.Font = P5.Font = P6.Font = P7.Font = P8.Font = P9.Font = P10.Font = P11.Font = P12.Font = P13.Font = P14.Font = P15.Font = P16.Font = P17.Font = P18.Font = P19.Font = P20.Font = P21.Font = P22.Font = P23.Font = P24.Font = P25.Font = P26.Font = P27.Font = P28.Font = P29.Font = P30.Font = P31.Font = P32.Font = P33.Font = P34.Font = P35.Font = P36.Font = P37.Font = P38.Font = P39.Font = P40.Font = P41.Font = P42.Font = P43.Font = P44.Font = P45.Font = P46.Font = P47.Font = P48.Font = P49.Font = P50.Font = P51.Font = P52.Font = P53.Font = P54.Font = P55.Font = P56.Font = P57.Font = P58.Font = P59.Font = P60.Font = P61.Font = P62.Font = P63.Font = P64.Font = P65.Font = P66.Font = P67.Font = P68.Font = P69.Font = P70.Font = P71.Font = P72.Font = P73.Font = P74.Font = P75.Font = P76.Font = P77.Font = P78.Font = P79.Font = P80.Font = P81.Font = P82.Font = P83.Font = P84.Font = P85.Font = P86.Font = P87.Font = P88.Font = P89.Font = P90.Font = P91.Font = P92.Font = P93.Font = P94.Font = P95.Font = P96.Font = P97.Font = P98.Font = P99.Font = P100.Font = P101.Font = P102.Font = P103.Font = P104.Font = P105.Font = P106.Font = P107.Font = P108.Font = P109.Font = P110.Font = P111.Font = P112.Font = P113.Font = P114.Font = P115.Font = P116.Font = P117.Font = P118.Font = P119.Font = P120.Font = P121.Font = P122.Font = P123.Font = P124.Font = P125.Font = P126.Font = P127.Font = P128.Font = P129.Font = P130.Font = P131.Font = P132.Font = P133.Font = P134.Font = P135.Font = P136.Font = P137.Font = P138.Font = P139.Font = P140.Font = P141.Font = P142.Font = P143.Font = P144.Font = P145.Font = P146.Font = P147.Font = P148.Font = P149.Font = P150.Font = P151.Font = P152.Font = P153.Font = P154.Font = P155.Font = P156.Font = P157.Font = P158.Font = P159.Font = P160.Font = P161.Font = P162.Font = P163.Font = P164.Font = P165.Font = P166.Font = P167.Font = P168.Font = P169.Font = new Font("Microsoft Sans Serif", 14);
            Q1.Font = Q2.Font = Q3.Font = Q4.Font = Q5.Font = Q6.Font = Q7.Font = Q8.Font = Q9.Font = Q10.Font = Q11.Font = Q12.Font = Q13.Font = Q14.Font = Q15.Font = Q16.Font = Q17.Font = Q18.Font = Q19.Font = Q20.Font = Q21.Font = Q22.Font = Q23.Font = Q24.Font = Q25.Font = Q26.Font = Q27.Font = Q28.Font = Q29.Font = Q30.Font = Q31.Font = Q32.Font = Q33.Font = Q34.Font = Q35.Font = Q36.Font = Q37.Font = Q38.Font = Q39.Font =  Q41.Font = Q42.Font =  Q44.Font = Q46.Font = Q47.Font = Q48.Font = Q49.Font = Q50.Font = Q51.Font = Q52.Font =  Q54.Font = Q55.Font = Q56.Font = Q58.Font = Q59.Font = Q60.Font = Q61.Font = Q62.Font = Q63.Font = Q64.Font = Q65.Font = Q66.Font = Q67.Font = Q68.Font = Q69.Font = Q70.Font = Q71.Font = Q72.Font = Q73.Font = Q74.Font = Q75.Font = Q76.Font = Q77.Font = Q78.Font = Q79.Font = Q80.Font = Q81.Font = Q82.Font = Q83.Font = Q84.Font = Q85.Font = Q86.Font = Q87.Font = Q88.Font = Q89.Font = Q90.Font = Q91.Font = Q92.Font = Q93.Font = Q94.Font = Q95.Font = Q96.Font = Q97.Font = Q98.Font = Q99.Font = Q100.Font = Q101.Font = Q102.Font = Q103.Font = Q104.Font = Q105.Font = Q106.Font = Q107.Font = Q108.Font = Q109.Font = Q110.Font = Q111.Font = Q112.Font = Q113.Font = Q114.Font = Q115.Font = Q116.Font = Q117.Font = Q118.Font = Q119.Font = Q120.Font = Q121.Font = Q122.Font = Q123.Font = Q124.Font = Q125.Font = Q126.Font = Q127.Font = Q128.Font = Q129.Font = Q130.Font = Q131.Font = Q132.Font = Q133.Font = Q134.Font = Q135.Font = Q136.Font = Q137.Font = Q138.Font = Q139.Font = Q140.Font = Q141.Font = Q142.Font = Q143.Font = Q144.Font = Q145.Font = Q146.Font = Q147.Font = Q148.Font = Q149.Font = Q150.Font = Q151.Font = Q152.Font = Q153.Font = Q154.Font = Q156.Font = Q157.Font = Q158.Font = Q159.Font = Q160.Font = Q161.Font = Q162.Font = Q163.Font = Q164.Font = Q165.Font = Q166.Font = Q167.Font = Q168.Font = Q169.Font = new Font("Microsoft Sans Serif", 12);

            P1.FlatStyle = P2.FlatStyle = P3.FlatStyle = P4.FlatStyle = P5.FlatStyle = P6.FlatStyle = P7.FlatStyle = P8.FlatStyle = P9.FlatStyle = P10.FlatStyle = P11.FlatStyle = P12.FlatStyle = P13.FlatStyle = P14.FlatStyle = P15.FlatStyle = P16.FlatStyle = P17.FlatStyle = P18.FlatStyle = P19.FlatStyle = P20.FlatStyle = P21.FlatStyle = P22.FlatStyle = P23.FlatStyle = P24.FlatStyle = P25.FlatStyle = P26.FlatStyle = P27.FlatStyle = P28.FlatStyle = P29.FlatStyle = P30.FlatStyle = P31.FlatStyle = P32.FlatStyle = P33.FlatStyle = P34.FlatStyle = P35.FlatStyle = P36.FlatStyle = P37.FlatStyle = P38.FlatStyle = P39.FlatStyle = P40.FlatStyle = P41.FlatStyle = P42.FlatStyle = P43.FlatStyle = P44.FlatStyle = P45.FlatStyle = P46.FlatStyle = P47.FlatStyle = P48.FlatStyle = P49.FlatStyle = P50.FlatStyle = P51.FlatStyle = P52.FlatStyle = P53.FlatStyle = P54.FlatStyle = P55.FlatStyle = P56.FlatStyle = P57.FlatStyle = P58.FlatStyle = P59.FlatStyle = P60.FlatStyle = P61.FlatStyle = P62.FlatStyle = P63.FlatStyle = P64.FlatStyle = P65.FlatStyle = P66.FlatStyle = P67.FlatStyle = P68.FlatStyle = P69.FlatStyle = P70.FlatStyle = P71.FlatStyle = P72.FlatStyle = P73.FlatStyle = P74.FlatStyle = P75.FlatStyle = P76.FlatStyle = P77.FlatStyle = P78.FlatStyle = P79.FlatStyle = P80.FlatStyle = P81.FlatStyle = P82.FlatStyle = P83.FlatStyle = P84.FlatStyle = P85.FlatStyle = P86.FlatStyle = P87.FlatStyle = P88.FlatStyle = P89.FlatStyle = P90.FlatStyle = P91.FlatStyle = P92.FlatStyle = P93.FlatStyle = P94.FlatStyle = P95.FlatStyle = P96.FlatStyle = P97.FlatStyle = P98.FlatStyle = P99.FlatStyle = P100.FlatStyle = P101.FlatStyle = P102.FlatStyle = P103.FlatStyle = P104.FlatStyle = P105.FlatStyle = P106.FlatStyle = P107.FlatStyle = P108.FlatStyle = P109.FlatStyle = P110.FlatStyle = P111.FlatStyle = P112.FlatStyle = P113.FlatStyle = P114.FlatStyle = P115.FlatStyle = P116.FlatStyle = P117.FlatStyle = P118.FlatStyle = P119.FlatStyle = P120.FlatStyle = P121.FlatStyle = P122.FlatStyle = P123.FlatStyle = P124.FlatStyle = P125.FlatStyle = P126.FlatStyle = P127.FlatStyle = P128.FlatStyle = P129.FlatStyle = P130.FlatStyle = P131.FlatStyle = P132.FlatStyle = P133.FlatStyle = P134.FlatStyle = P135.FlatStyle = P136.FlatStyle = P137.FlatStyle = P138.FlatStyle = P139.FlatStyle = P140.FlatStyle = P141.FlatStyle = P142.FlatStyle = P143.FlatStyle = P144.FlatStyle = P145.FlatStyle = P146.FlatStyle = P147.FlatStyle = P148.FlatStyle = P149.FlatStyle = P150.FlatStyle = P151.FlatStyle = P152.FlatStyle = P153.FlatStyle = P154.FlatStyle = P155.FlatStyle = P156.FlatStyle = P157.FlatStyle = P158.FlatStyle = P159.FlatStyle = P160.FlatStyle = P161.FlatStyle = P162.FlatStyle = P163.FlatStyle = P164.FlatStyle = P165.FlatStyle = P166.FlatStyle = P167.FlatStyle = P168.FlatStyle = P169.FlatStyle =  Q1.FlatStyle = Q2.FlatStyle = Q3.FlatStyle = Q4.FlatStyle = Q5.FlatStyle = Q6.FlatStyle = Q7.FlatStyle = Q8.FlatStyle = Q9.FlatStyle = Q10.FlatStyle = Q11.FlatStyle = Q12.FlatStyle = Q13.FlatStyle = Q14.FlatStyle = Q15.FlatStyle = Q16.FlatStyle = Q17.FlatStyle = Q18.FlatStyle = Q19.FlatStyle = Q20.FlatStyle = Q21.FlatStyle = Q22.FlatStyle = Q23.FlatStyle = Q24.FlatStyle = Q25.FlatStyle = Q26.FlatStyle = Q27.FlatStyle = Q28.FlatStyle = Q29.FlatStyle = Q30.FlatStyle = Q31.FlatStyle = Q32.FlatStyle = Q33.FlatStyle = Q34.FlatStyle = Q35.FlatStyle = Q36.FlatStyle = Q37.FlatStyle = Q38.FlatStyle = Q39.FlatStyle =  Q41.FlatStyle = Q42.FlatStyle =Q44.FlatStyle= Q46.FlatStyle = Q47.FlatStyle = Q48.FlatStyle = Q49.FlatStyle = Q50.FlatStyle = Q51.FlatStyle = Q52.FlatStyle =  Q54.FlatStyle = Q55.FlatStyle = Q56.FlatStyle  = Q58.FlatStyle = Q59.FlatStyle = Q60.FlatStyle = Q61.FlatStyle = Q62.FlatStyle = Q63.FlatStyle = Q64.FlatStyle = Q65.FlatStyle = Q66.FlatStyle = Q67.FlatStyle = Q68.FlatStyle = Q69.FlatStyle = Q70.FlatStyle = Q71.FlatStyle = Q72.FlatStyle = Q73.FlatStyle = Q74.FlatStyle = Q75.FlatStyle = Q76.FlatStyle = Q77.FlatStyle = Q78.FlatStyle = Q79.FlatStyle = Q80.FlatStyle = Q81.FlatStyle = Q82.FlatStyle = Q83.FlatStyle = Q84.FlatStyle = Q85.FlatStyle = Q86.FlatStyle = Q87.FlatStyle = Q88.FlatStyle = Q89.FlatStyle = Q90.FlatStyle = Q91.FlatStyle = Q92.FlatStyle = Q93.FlatStyle = Q94.FlatStyle = Q95.FlatStyle = Q96.FlatStyle = Q97.FlatStyle = Q98.FlatStyle = Q99.FlatStyle = Q100.FlatStyle = Q101.FlatStyle = Q102.FlatStyle = Q103.FlatStyle = Q104.FlatStyle = Q105.FlatStyle = Q106.FlatStyle = Q107.FlatStyle = Q108.FlatStyle = Q109.FlatStyle = Q110.FlatStyle = Q111.FlatStyle = Q112.FlatStyle = Q113.FlatStyle = Q114.FlatStyle = Q115.FlatStyle = Q116.FlatStyle = Q117.FlatStyle = Q118.FlatStyle = Q119.FlatStyle = Q120.FlatStyle = Q121.FlatStyle = Q122.FlatStyle = Q123.FlatStyle = Q124.FlatStyle = Q125.FlatStyle = Q126.FlatStyle = Q127.FlatStyle = Q128.FlatStyle = Q129.FlatStyle = Q130.FlatStyle = Q131.FlatStyle = Q132.FlatStyle = Q133.FlatStyle = Q134.FlatStyle = Q135.FlatStyle = Q136.FlatStyle = Q137.FlatStyle = Q138.FlatStyle = Q139.FlatStyle = Q140.FlatStyle = Q141.FlatStyle = Q142.FlatStyle = Q143.FlatStyle = Q144.FlatStyle = Q145.FlatStyle = Q146.FlatStyle = Q147.FlatStyle = Q148.FlatStyle = Q149.FlatStyle = Q150.FlatStyle = Q151.FlatStyle = Q152.FlatStyle = Q153.FlatStyle = Q154.FlatStyle =  Q156.FlatStyle = Q157.FlatStyle = Q158.FlatStyle = Q159.FlatStyle = Q160.FlatStyle = Q161.FlatStyle = Q162.FlatStyle = Q163.FlatStyle = Q164.FlatStyle = Q165.FlatStyle = Q166.FlatStyle = Q167.FlatStyle = Q168.FlatStyle = Q169.FlatStyle = FlatStyle.Flat;

            P1.BackColor = P2.BackColor = P3.BackColor = P4.BackColor = P5.BackColor = P6.BackColor = P7.BackColor = P8.BackColor = P9.BackColor = P10.BackColor = P11.BackColor = P12.BackColor = P13.BackColor = P14.BackColor = P15.BackColor = P16.BackColor = P17.BackColor = P18.BackColor = P19.BackColor = P20.BackColor = P21.BackColor = P22.BackColor = P23.BackColor = P24.BackColor = P25.BackColor = P26.BackColor = P27.BackColor = P28.BackColor = P29.BackColor = P30.BackColor = P31.BackColor = P32.BackColor = P33.BackColor = P34.BackColor = P35.BackColor = P36.BackColor = P37.BackColor = P38.BackColor = P39.BackColor = P40.BackColor = P41.BackColor = P42.BackColor = P43.BackColor = P44.BackColor = P45.BackColor = P46.BackColor = P47.BackColor = P48.BackColor = P49.BackColor = P50.BackColor = P51.BackColor = P52.BackColor = P53.BackColor = P54.BackColor = P55.BackColor = P56.BackColor = P57.BackColor = P58.BackColor = P59.BackColor = P60.BackColor = P61.BackColor = P62.BackColor = P63.BackColor = P64.BackColor = P65.BackColor = P66.BackColor = P67.BackColor = P68.BackColor = P69.BackColor = P70.BackColor = P71.BackColor = P72.BackColor = P73.BackColor = P74.BackColor = P75.BackColor = P76.BackColor = P77.BackColor = P78.BackColor = P79.BackColor = P80.BackColor = P81.BackColor = P82.BackColor = P83.BackColor = P84.BackColor = P85.BackColor = P86.BackColor = P87.BackColor = P88.BackColor = P89.BackColor = P90.BackColor = P91.BackColor = P92.BackColor = P93.BackColor = P94.BackColor = P95.BackColor = P96.BackColor = P97.BackColor = P98.BackColor = P99.BackColor = P100.BackColor = P101.BackColor = P102.BackColor = P103.BackColor = P104.BackColor = P105.BackColor = P106.BackColor = P107.BackColor = P108.BackColor = P109.BackColor = P110.BackColor = P111.BackColor = P112.BackColor = P113.BackColor = P114.BackColor = P115.BackColor = P116.BackColor = P117.BackColor = P118.BackColor = P119.BackColor = P120.BackColor = P121.BackColor = P122.BackColor = P123.BackColor = P124.BackColor = P125.BackColor = P126.BackColor = P127.BackColor = P128.BackColor = P129.BackColor = P130.BackColor = P131.BackColor = P132.BackColor = P133.BackColor = P134.BackColor = P135.BackColor = P136.BackColor = P137.BackColor = P138.BackColor = P139.BackColor = P140.BackColor = P141.BackColor = P142.BackColor = P143.BackColor = P144.BackColor = P145.BackColor = P146.BackColor = P147.BackColor = P148.BackColor = P149.BackColor = P150.BackColor = P151.BackColor = P152.BackColor = P153.BackColor = P154.BackColor = P155.BackColor = P156.BackColor = P157.BackColor = P158.BackColor = P159.BackColor = P160.BackColor = P161.BackColor = P162.BackColor = P163.BackColor = P164.BackColor = P165.BackColor = P166.BackColor = P167.BackColor = P168.BackColor = P169.BackColor =Q1.BackColor = Q2.BackColor = Q3.BackColor = Q4.BackColor = Q5.BackColor = Q6.BackColor = Q7.BackColor = Q8.BackColor = Q9.BackColor = Q10.BackColor = Q11.BackColor = Q12.BackColor = Q13.BackColor = Q14.BackColor = Q15.BackColor = Q16.BackColor = Q17.BackColor = Q18.BackColor = Q19.BackColor = Q20.BackColor = Q21.BackColor = Q22.BackColor = Q23.BackColor = Q24.BackColor = Q25.BackColor = Q26.BackColor = Q27.BackColor = Q28.BackColor = Q29.BackColor = Q30.BackColor = Q31.BackColor = Q32.BackColor = Q33.BackColor = Q34.BackColor = Q35.BackColor = Q36.BackColor = Q37.BackColor = Q38.BackColor = Q39.BackColor = Q41.BackColor = Q42.BackColor =  Q44.BackColor  = Q46.BackColor = Q47.BackColor = Q48.BackColor = Q49.BackColor = Q50.BackColor = Q51.BackColor = Q52.BackColor =  Q54.BackColor = Q55.BackColor = Q56.BackColor =  Q58.BackColor = Q59.BackColor = Q60.BackColor = Q61.BackColor = Q62.BackColor = Q63.BackColor = Q64.BackColor = Q65.BackColor = Q66.BackColor = Q67.BackColor = Q68.BackColor = Q69.BackColor = Q70.BackColor = Q71.BackColor = Q72.BackColor = Q73.BackColor = Q74.BackColor = Q75.BackColor = Q76.BackColor = Q77.BackColor = Q78.BackColor = Q79.BackColor = Q80.BackColor = Q81.BackColor = Q82.BackColor = Q83.BackColor = Q84.BackColor = Q85.BackColor = Q86.BackColor = Q87.BackColor = Q88.BackColor = Q89.BackColor = Q90.BackColor = Q91.BackColor = Q92.BackColor = Q93.BackColor = Q94.BackColor = Q95.BackColor = Q96.BackColor = Q97.BackColor = Q98.BackColor = Q99.BackColor = Q100.BackColor = Q101.BackColor = Q102.BackColor = Q103.BackColor = Q104.BackColor = Q105.BackColor = Q106.BackColor = Q107.BackColor = Q108.BackColor = Q109.BackColor = Q110.BackColor = Q111.BackColor = Q112.BackColor = Q113.BackColor = Q114.BackColor = Q115.BackColor = Q116.BackColor = Q117.BackColor = Q118.BackColor = Q119.BackColor = Q120.BackColor = Q121.BackColor = Q122.BackColor = Q123.BackColor = Q124.BackColor = Q125.BackColor = Q126.BackColor = Q127.BackColor = Q128.BackColor = Q129.BackColor = Q130.BackColor = Q131.BackColor = Q132.BackColor = Q133.BackColor = Q134.BackColor = Q135.BackColor = Q136.BackColor = Q137.BackColor = Q138.BackColor = Q139.BackColor = Q140.BackColor = Q141.BackColor = Q142.BackColor = Q143.BackColor = Q144.BackColor = Q145.BackColor = Q146.BackColor = Q147.BackColor = Q148.BackColor = Q149.BackColor = Q150.BackColor = Q151.BackColor = Q152.BackColor = Q153.BackColor = Q154.BackColor =  Q156.BackColor = Q157.BackColor = Q158.BackColor = Q159.BackColor = Q160.BackColor = Q161.BackColor = Q162.BackColor = Q163.BackColor = Q164.BackColor = Q165.BackColor = Q166.BackColor = Q167.BackColor = Q168.BackColor = Q169.BackColor = Color.FromArgb(x2, y2, z2);
            P1.ForeColor = P2.ForeColor = P3.ForeColor = P4.ForeColor = P5.ForeColor = P6.ForeColor = P7.ForeColor = P8.ForeColor = P9.ForeColor = P10.ForeColor = P11.ForeColor = P12.ForeColor = P13.ForeColor = P14.ForeColor = P15.ForeColor = P16.ForeColor = P17.ForeColor = P18.ForeColor = P19.ForeColor = P20.ForeColor = P21.ForeColor = P22.ForeColor = P23.ForeColor = P24.ForeColor = P25.ForeColor = P26.ForeColor = P27.ForeColor = P28.ForeColor = P29.ForeColor = P30.ForeColor = P31.ForeColor = P32.ForeColor = P33.ForeColor = P34.ForeColor = P35.ForeColor = P36.ForeColor = P37.ForeColor = P38.ForeColor = P39.ForeColor = P40.ForeColor = P41.ForeColor = P42.ForeColor = P43.ForeColor = P44.ForeColor = P45.ForeColor = P46.ForeColor = P47.ForeColor = P48.ForeColor = P49.ForeColor = P50.ForeColor = P51.ForeColor = P52.ForeColor = P53.ForeColor = P54.ForeColor = P55.ForeColor = P56.ForeColor = P57.ForeColor = P58.ForeColor = P59.ForeColor = P60.ForeColor = P61.ForeColor = P62.ForeColor = P63.ForeColor = P64.ForeColor = P65.ForeColor = P66.ForeColor = P67.ForeColor = P68.ForeColor = P69.ForeColor = P70.ForeColor = P71.ForeColor = P72.ForeColor = P73.ForeColor = P74.ForeColor = P75.ForeColor = P76.ForeColor = P77.ForeColor = P78.ForeColor = P79.ForeColor = P80.ForeColor = P81.ForeColor = P82.ForeColor = P83.ForeColor = P84.ForeColor = P85.ForeColor = P86.ForeColor = P87.ForeColor = P88.ForeColor = P89.ForeColor = P90.ForeColor = P91.ForeColor = P92.ForeColor = P93.ForeColor = P94.ForeColor = P95.ForeColor = P96.ForeColor = P97.ForeColor = P98.ForeColor = P99.ForeColor = P100.ForeColor = P101.ForeColor = P102.ForeColor = P103.ForeColor = P104.ForeColor = P105.ForeColor = P106.ForeColor = P107.ForeColor = P108.ForeColor = P109.ForeColor = P110.ForeColor = P111.ForeColor = P112.ForeColor = P113.ForeColor = P114.ForeColor = P115.ForeColor = P116.ForeColor = P117.ForeColor = P118.ForeColor = P119.ForeColor = P120.ForeColor = P121.ForeColor = P122.ForeColor = P123.ForeColor = P124.ForeColor = P125.ForeColor = P126.ForeColor = P127.ForeColor = P128.ForeColor = P129.ForeColor = P130.ForeColor = P131.ForeColor = P132.ForeColor = P133.ForeColor = P134.ForeColor = P135.ForeColor = P136.ForeColor = P137.ForeColor = P138.ForeColor = P139.ForeColor = P140.ForeColor = P141.ForeColor = P142.ForeColor = P143.ForeColor = P144.ForeColor = P145.ForeColor = P146.ForeColor = P147.ForeColor = P148.ForeColor = P149.ForeColor = P150.ForeColor = P151.ForeColor = P152.ForeColor = P153.ForeColor = P154.ForeColor = P155.ForeColor = P156.ForeColor = P157.ForeColor = P158.ForeColor = P159.ForeColor = P160.ForeColor = P161.ForeColor = P162.ForeColor = P163.ForeColor = P164.ForeColor = P165.ForeColor = P166.ForeColor = P167.ForeColor = P168.ForeColor = P169.ForeColor =  Q1.ForeColor = Q2.ForeColor = Q3.ForeColor = Q4.ForeColor = Q5.ForeColor = Q6.ForeColor = Q7.ForeColor = Q8.ForeColor = Q9.ForeColor = Q10.ForeColor = Q11.ForeColor = Q12.ForeColor = Q13.ForeColor = Q14.ForeColor = Q15.ForeColor = Q16.ForeColor = Q17.ForeColor = Q18.ForeColor = Q19.ForeColor = Q20.ForeColor = Q21.ForeColor = Q22.ForeColor = Q23.ForeColor = Q24.ForeColor = Q25.ForeColor = Q26.ForeColor = Q27.ForeColor = Q28.ForeColor = Q29.ForeColor = Q30.ForeColor = Q31.ForeColor = Q32.ForeColor = Q33.ForeColor = Q34.ForeColor = Q35.ForeColor = Q36.ForeColor = Q37.ForeColor = Q38.ForeColor = Q39.ForeColor =  Q41.ForeColor = Q42.ForeColor = Q44.ForeColor  = Q46.ForeColor = Q47.ForeColor = Q48.ForeColor = Q49.ForeColor = Q50.ForeColor = Q51.ForeColor = Q52.ForeColor =  Q54.ForeColor = Q55.ForeColor = Q56.ForeColor = Q58.ForeColor = Q59.ForeColor = Q60.ForeColor = Q61.ForeColor = Q62.ForeColor = Q63.ForeColor = Q64.ForeColor = Q65.ForeColor = Q66.ForeColor = Q67.ForeColor = Q68.ForeColor = Q69.ForeColor = Q70.ForeColor = Q71.ForeColor = Q72.ForeColor = Q73.ForeColor = Q74.ForeColor = Q75.ForeColor = Q76.ForeColor = Q77.ForeColor = Q78.ForeColor = Q79.ForeColor = Q80.ForeColor = Q81.ForeColor = Q82.ForeColor = Q83.ForeColor = Q84.ForeColor = Q85.ForeColor = Q86.ForeColor = Q87.ForeColor = Q88.ForeColor = Q89.ForeColor = Q90.ForeColor = Q91.ForeColor = Q92.ForeColor = Q93.ForeColor = Q94.ForeColor = Q95.ForeColor = Q96.ForeColor = Q97.ForeColor = Q98.ForeColor = Q99.ForeColor = Q100.ForeColor = Q101.ForeColor = Q102.ForeColor = Q103.ForeColor = Q104.ForeColor = Q105.ForeColor = Q106.ForeColor = Q107.ForeColor = Q108.ForeColor = Q109.ForeColor = Q110.ForeColor = Q111.ForeColor = Q112.ForeColor = Q113.ForeColor = Q114.ForeColor = Q115.ForeColor = Q116.ForeColor = Q117.ForeColor = Q118.ForeColor = Q119.ForeColor = Q120.ForeColor = Q121.ForeColor = Q122.ForeColor = Q123.ForeColor = Q124.ForeColor = Q125.ForeColor = Q126.ForeColor = Q127.ForeColor = Q128.ForeColor = Q129.ForeColor = Q130.ForeColor = Q131.ForeColor = Q132.ForeColor = Q133.ForeColor = Q134.ForeColor = Q135.ForeColor = Q136.ForeColor = Q137.ForeColor = Q138.ForeColor = Q139.ForeColor = Q140.ForeColor = Q141.ForeColor = Q142.ForeColor = Q143.ForeColor = Q144.ForeColor = Q145.ForeColor = Q146.ForeColor = Q147.ForeColor = Q148.ForeColor = Q149.ForeColor = Q150.ForeColor = Q151.ForeColor = Q152.ForeColor = Q153.ForeColor = Q154.ForeColor =  Q156.ForeColor = Q157.ForeColor = Q158.ForeColor = Q159.ForeColor = Q160.ForeColor = Q161.ForeColor = Q162.ForeColor = Q163.ForeColor = Q164.ForeColor = Q165.ForeColor = Q166.ForeColor = Q167.ForeColor = Q168.ForeColor = Q169.ForeColor = Color.FromArgb(x1,y1,z1);
           Next1.Cursor=Next2.Cursor=Prev1.Cursor=Prev2.Cursor=cauta_events.Cursor= P1.Cursor = P2.Cursor = P3.Cursor = P4.Cursor = P5.Cursor = P6.Cursor = P7.Cursor = P8.Cursor = P9.Cursor = P10.Cursor = P11.Cursor = P12.Cursor = P13.Cursor = P14.Cursor = P15.Cursor = P16.Cursor = P17.Cursor = P18.Cursor = P19.Cursor = P20.Cursor = P21.Cursor = P22.Cursor = P23.Cursor = P24.Cursor = P25.Cursor = P26.Cursor = P27.Cursor = P28.Cursor = P29.Cursor = P30.Cursor = P31.Cursor = P32.Cursor = P33.Cursor = P34.Cursor = P35.Cursor = P36.Cursor = P37.Cursor = P38.Cursor = P39.Cursor = P40.Cursor = P41.Cursor = P42.Cursor = P43.Cursor = P44.Cursor = P45.Cursor = P46.Cursor = P47.Cursor = P48.Cursor = P49.Cursor = P50.Cursor = P51.Cursor = P52.Cursor = P53.Cursor = P54.Cursor = P55.Cursor = P56.Cursor = P57.Cursor = P58.Cursor = P59.Cursor = P60.Cursor = P61.Cursor = P62.Cursor = P63.Cursor = P64.Cursor = P65.Cursor = P66.Cursor = P67.Cursor = P68.Cursor = P69.Cursor = P70.Cursor = P71.Cursor = P72.Cursor = P73.Cursor = P74.Cursor = P75.Cursor = P76.Cursor = P77.Cursor = P78.Cursor = P79.Cursor = P80.Cursor = P81.Cursor = P82.Cursor = P83.Cursor = P84.Cursor = P85.Cursor = P86.Cursor = P87.Cursor = P88.Cursor = P89.Cursor = P90.Cursor = P91.Cursor = P92.Cursor = P93.Cursor = P94.Cursor = P95.Cursor = P96.Cursor = P97.Cursor = P98.Cursor = P99.Cursor = P100.Cursor = P101.Cursor = P102.Cursor = P103.Cursor = P104.Cursor = P105.Cursor = P106.Cursor = P107.Cursor = P108.Cursor = P109.Cursor = P110.Cursor = P111.Cursor = P112.Cursor = P113.Cursor = P114.Cursor = P115.Cursor = P116.Cursor = P117.Cursor = P118.Cursor = P119.Cursor = P120.Cursor = P121.Cursor = P122.Cursor = P123.Cursor = P124.Cursor = P125.Cursor = P126.Cursor = P127.Cursor = P128.Cursor = P129.Cursor = P130.Cursor = P131.Cursor = P132.Cursor = P133.Cursor = P134.Cursor = P135.Cursor = P136.Cursor = P137.Cursor = P138.Cursor = P139.Cursor = P140.Cursor = P141.Cursor = P142.Cursor = P143.Cursor = P144.Cursor = P145.Cursor = P146.Cursor = P147.Cursor = P148.Cursor = P149.Cursor = P150.Cursor = P151.Cursor = P152.Cursor = P153.Cursor = P154.Cursor = P155.Cursor = P156.Cursor = P157.Cursor = P158.Cursor = P159.Cursor = P160.Cursor = P161.Cursor = P162.Cursor = P163.Cursor = P164.Cursor = P165.Cursor = P166.Cursor = P167.Cursor = P168.Cursor = P169.Cursor =  Q1.Cursor = Q2.Cursor = Q3.Cursor = Q4.Cursor = Q5.Cursor = Q6.Cursor = Q7.Cursor = Q8.Cursor = Q9.Cursor = Q10.Cursor = Q11.Cursor = Q12.Cursor = Q13.Cursor = Q14.Cursor = Q15.Cursor = Q16.Cursor = Q17.Cursor = Q18.Cursor = Q19.Cursor = Q20.Cursor = Q21.Cursor = Q22.Cursor = Q23.Cursor = Q24.Cursor = Q25.Cursor = Q26.Cursor = Q27.Cursor = Q28.Cursor = Q29.Cursor = Q30.Cursor = Q31.Cursor = Q32.Cursor = Q33.Cursor = Q34.Cursor = Q35.Cursor = Q36.Cursor = Q37.Cursor = Q38.Cursor = Q39.Cursor =  Q41.Cursor = Q42.Cursor = Q44.Cursor =  Q46.Cursor = Q47.Cursor = Q48.Cursor = Q49.Cursor = Q50.Cursor = Q51.Cursor = Q52.Cursor = Q54.Cursor = Q55.Cursor = Q56.Cursor = Q58.Cursor = Q59.Cursor = Q60.Cursor = Q61.Cursor = Q62.Cursor = Q63.Cursor = Q64.Cursor = Q65.Cursor = Q66.Cursor = Q67.Cursor = Q68.Cursor = Q69.Cursor = Q70.Cursor = Q71.Cursor = Q72.Cursor = Q73.Cursor = Q74.Cursor = Q75.Cursor = Q76.Cursor = Q77.Cursor = Q78.Cursor = Q79.Cursor = Q80.Cursor = Q81.Cursor = Q82.Cursor = Q83.Cursor = Q84.Cursor = Q85.Cursor = Q86.Cursor = Q87.Cursor = Q88.Cursor = Q89.Cursor = Q90.Cursor = Q91.Cursor = Q92.Cursor = Q93.Cursor = Q94.Cursor = Q95.Cursor = Q96.Cursor = Q97.Cursor = Q98.Cursor = Q99.Cursor = Q100.Cursor = Q101.Cursor = Q102.Cursor = Q103.Cursor = Q104.Cursor = Q105.Cursor = Q106.Cursor = Q107.Cursor = Q108.Cursor = Q109.Cursor = Q110.Cursor = Q111.Cursor = Q112.Cursor = Q113.Cursor = Q114.Cursor = Q115.Cursor = Q116.Cursor = Q117.Cursor = Q118.Cursor = Q119.Cursor = Q120.Cursor = Q121.Cursor = Q122.Cursor = Q123.Cursor = Q124.Cursor = Q125.Cursor = Q126.Cursor = Q127.Cursor = Q128.Cursor = Q129.Cursor = Q130.Cursor = Q131.Cursor = Q132.Cursor = Q133.Cursor = Q134.Cursor = Q135.Cursor = Q136.Cursor = Q137.Cursor = Q138.Cursor = Q139.Cursor = Q140.Cursor = Q141.Cursor = Q142.Cursor = Q143.Cursor = Q144.Cursor = Q145.Cursor = Q146.Cursor = Q147.Cursor = Q148.Cursor = Q149.Cursor = Q150.Cursor = Q151.Cursor = Q152.Cursor = Q153.Cursor = Q154.Cursor = Q156.Cursor = Q157.Cursor = Q158.Cursor = Q159.Cursor = Q160.Cursor = Q161.Cursor = Q162.Cursor = Q163.Cursor = Q164.Cursor = Q165.Cursor = Q166.Cursor = Q167.Cursor = Q168.Cursor = Q169.Cursor =  Cursors.Hand;



            mafiamember.BackgroundImage = Properties.Resources.mafiot;
            DA.Cursor = NU.Cursor = interogatoriu.Cursor = mafiamember.Cursor = Cursors.Hand;

            //Pasoptism:
            P1.Text = "În Italia ";Q1.Text = "27 ianuarie 1848";
            P2.Text = "În Franța";Q2.Text = "22 februarie 1848";
            P3.Text = "În Germania";Q3.Text = "14 martie 1848";
            P4.Text = "În Austro-Ungaria";Q4.Text = "15 martie 1848";
            P5.Text = "In Ungaria";Q5.Text = "15 martie 1848";
            P6.Text = "În România ";Q6.Text = "27 martie 1848";

            //Urmarile Pasoptismului

            P7.Text = "Unirea Principatelor Române";Q7.Text = "24 ianuarie 1859";
            P8.Text = "Republica de la Ploieşti";Q8.Text = "8 august 1870";
            P9.Text = "Unificarea Germaniei";Q9.Text = "18 ianuarie 1871";
            P10.Text = "Unificarea Italiei";Q10.Text = "9 ocotmbrie 1871";

            //La Belle Epoque
            P11.Text = "Românii-Pionierii petrolului";Q11.Text = "1840-1857";
            P12.Text = "Primul oraş iluminat cu gaz lampant "; Q12.Text = "1 aprilie 1857";
            P13.Text = "Războiul Civil American"; Q13.Text = "12 apr. 1861 – 9 mai 1865";
            P14.Text = "SUA cumpără Alaska";Q14.Text = "18 octombrie 1867";
            P15.Text = "Congresul de la Berlin";Q15.Text = "13 iunie – 13 iulie 1878";
            P16.Text = "Tripla Alianță";Q16.Text = "1883";
            P17.Text = "Primul oraş iluminat electric din Europa";Q17.Text = "12 noiembrie 1884";
            P18.Text = "Primul tratat de bacteorologie din lume";Q18.Text = "1885";
            P19.Text = "Alianța fracno-rusă";Q19.Text = "1891-1893";
            P20.Text = "Războiul Spaniolo-American";Q20.Text = "25 aprilie-12 august 1898";
            P21.Text = "Războaiele bananierelor";Q21.Text = "1898 - 1938";
            P22.Text = "Blocada navală a Venezuelei";Q22.Text = "dec. 1902- feb. 1903";
            P23.Text = "Războiul Ruso-japonez";Q23.Text = "8 feb. 1904 – 5 sept. 1905";
            P24.Text = "Antanta Cordiala";Q24.Text = "8 aprilie 1904";
            P25.Text = "Revoluția rusă din 1905";Q25.Text = "22 ian. 1905 – 16 iun. 1907";
            P26.Text = "Prima criză marocană";Q26.Text = "martie 1905-mai 1906";
            P27.Text = "Marea rascoala taraneasca";Q27.Text = "21 feb. 1907 – 5 apr. 1907";
            P28.Text = "Convenția anglo-rusă";Q28.Text = "31 august 1907";
            P29.Text = "Criza bosniaca";Q29.Text = "1908-1909";
            P30.Text = "Motoul cu reacție ";Q30.Text = "1910";
            P31.Text = "Criza Agadir";Q31.Text = "aprilie-iulie 1911";
            P32.Text = "Scufundarea Titanicului";Q32.Text = "14 aprilie 1912";
            P33.Text = "Războiul Italo-Turc";Q33.Text = "29 sept.1911-18 oct. 1912";
            P34.Text = "Primul Război Balcanic";Q34.Text = "8 oct. 1912 – 30 mai 1913";
            P35.Text = "Al Doilea Război Balcanic";Q35.Text = "16 iun. 1913–18 iul. 1913";
            P36.Text = "Tratatul de la Constantinopol";Q36.Text = "29 septembrie 1913";
        
            
            
            //ww1
            P37.Text = "Atentatul de le Sarajevo"; Q37.Text = "28 iunie 1914";
            P38.Text = "Austro-Ungaria declară război Serbiei "; Q38.Text = "28 iulie 1914";
            P39.Text = "Germania atacă Luxemburg şi Belgia"; Q39.Text = "01 august 1914";
            P40.Text = "Anul 1914";// Q40.Text = "";
            P41.Text = "Polonezii şi Primul Război Mondial "; Q41.Text = "8 august 1914";
            P42.Text = "Craciunul ȋn tranşee"; Q42.Text = "25-31 dec. 1914";
            P43.Text = "Anul 1915"; //Q43.Text = "";
            P44.Text = "Acordul Claveland "; Q44.Text = "22 octombrie 1915";
            P45.Text = "Anul 1916"; //Q45.Text="";
            P46.Text = "Bătălia de la Verdun";Q46.Text = "21 feb. 1916–18 dec. 1916";
            P47.Text = "Participarea României la Marele Război"; Q47.Text = "17 aprlie 1916";
            P48.Text = "Bătălia de pe Somme"; Q48.Text = "1 iul. 1916 – 18 nov. 1916";
            P49.Text = "Noua capitală a României"; Q49.Text = "noimbrie 1916";
            P50.Text = "Tezaurul României trimis la Moscova"; Q50.Text = "12-14 dec. 1916";
            P51.Text = "Actul din 5 noimbrie 1916 "; Q51.Text = "5 noimbrie 1916 ";
            P52.Text = "Asasinarea lui Rasptin "; Q52.Text = "30 decembrie 1916";
            P53.Text = "Anul 1917"; //Q53.Text = "";
            P54.Text ="Februarie si Octombrie"+Environment.NewLine+ "Revoluțiile bolsevice din Rusia "; Q54.Text = "8 martie 1917";
            P55.Text = "Vladimir Lenin se ȋntoarce in Rusia"; Q55.Text = "9 aprilie 1917";
            P56.Text = "Mărăşti,Mărăşeşti şi Oituz"; Q56.Text = "11 iulie-1 august 1917";

            P57.Text = "Anul 1918";// Q57.Text = "";
            P58.Text = "Cele 14 puncte"; Q58.Text = "8 ianuarie 1918";
            P59.Text = "Proclamarea Republicii Germane "; Q59.Text = "9 noiembrie 1918";
            P60.Text = "Polonia ȋşi recâstigă independența "; Q60.Text = "11 noiembrie 1918";
            P61.Text = "Marea Unire "; Q61.Text = "1 dec. 1918";
            P62.Text = "Luptele pentru granițele celei de a Doua Republici Poloneze"; Q62.Text = "1 inauarie 1919";
            P63.Text = "Declararea  Republicii Sovietice Ungare "; Q63.Text = "21 martie 1919";
            P64.Text = "Tratatul de pace de la Versailles "; Q64.Text = "28 iunie 1919";
            P65.Text = "România şi Conferința de Pace de la Paris"; Q65.Text = "28 octombrie 1920";
            P66.Text = "Linia Magniot"; Q66.Text = "1920-1940";
            P67.Text = "Arcul de triumf de la Bucureşti "; Q67.Text = "1922-1936";
            P68.Text = "Mausoleul de la Mărășești"; Q68.Text = "1923-18 septembrie 1938";
            P69.Text = "Crucea Eroilor Neamului de pe Muntele Caraiman "; Q69.Text = "1924-1928";

            

            //perioda interbelica

            P70.Text = "România interbelica "; Q70.Text = "1919-1938";
            P71.Text = "Benito Mussolini şi fascismul "; Q71.Text = "23 martie 1919";
            P72.Text = "Prohibitie"; Q72.Text = "1920-1933";
            P73.Text = "Tratatul Traianon "; Q73.Text = "4 iunie 1920";
            P74.Text = "Ungaria semnează Pactul de la Traianon "; Q74.Text = "4 iunie 1920";
            P75.Text = "Asediul Budapestei de trupele romane"; Q75.Text = "13 nov. 1918-3 aug. 1919";
            P76.Text = "Bătălia Varşoviei "; Q76.Text = "13-25 august 1920";
            P77.Text = "Inventia insulinei "; Q77.Text = "1922";

            P78.Text = "Propunerea autonomiei Slovaiciei"; Q78.Text = "22 ian. 1922";
            P79.Text = "Marsul asupra Romei "; Q79.Text = "22 ocotmbrie 1922";
            P80.Text = "Ocupația regiunii Ruhr"; Q80.Text = "11 ianuarie 1923";
            P81.Text = "Considerarea Marii Uniri "; Q81.Text = "27 martie 1923";
           
            P82.Text = "Hitler şi puciul "; Q82.Text = "8 noiembrie 1923 ";
            P83.Text = "Marşul spre Munchen"; Q83.Text = "9 noiembrie 1923";
            P84.Text = "Aerodinamica maşinilor "; Q84.Text = "1924";
            P85.Text = "Trezoreria și reforma valutară a lui Grabski "; Q85.Text = "1 aprilie 1924";
            P86.Text = "Construcția portului din Gdynia "; Q86.Text = "01 februarie 1926";
            P87.Text = "Tratatul Balcanic "; Q87.Text = "26 martie 1926";
            P88.Text = "Alianțele României  "; Q88.Text = "26 martie 1926";
            P89.Text = "Pengő,noua valută"; Q89.Text = "1 ian.1927";
            P90.Text = "Masacrul de Valentine’s Day"; Q90.Text = "14 februarie 1929";
            P91.Text = "Scaunul cu ejecție "; Q91.Text = "2 aprilie 1930";
            P92.Text = "Adolf Hitler devine Cancelarul Germaniei "; Q92.Text = "30 ianuarie 1933";
            P93.Text = "New Deal "; Q93.Text = "1933-1936";
            P94.Text = "Relațiile dintre România si URSS"; Q94.Text = "8 iunie 1934";
            P95.Text = "Mitingul Partidului Nazist "; Q95.Text = "15 septembrie 1935";
            P96.Text = "Primul decret anti-semit "; Q96.Text = "29 mai 1938";
            P97.Text = "Semnarea Acordului de la Munchen "; Q97.Text = "29 septembrie 1938";
            P98.Text = "Declarare autonomiei Slovaciei "; Q98.Text = "06 octombrie 1938";
            P99.Text = "Masacrarea populației de evrei din Germania "; Q99.Text = "8-10 noiembrie 1938";
            
            //ww2:
            P100.Text = "Invazia Poloniei "; Q100.Text = "1 sepmbrie 1939";
            P101.Text = "Polonezii din afara țării "; Q101.Text = "1939-1945";
            P102.Text = "Inazia Cehoslovaciei "; Q102.Text = "15 martie 1939 – 8 mai 1945";
            P103.Text = "Anul dezmembrarilor teritoriale";Q103.Text = "1940";
            P104.Text = "Pactul Ribbentrop-Molotov "; Q104.Text = "23 august 1939";
            P105.Text = "Războiul de Iarnă "; Q105.Text = "30 nov. 1939 – 13 mar. 1940";
            P106.Text = "Războiul Blitzkrieg"; Q106.Text = "1940";
            P107.Text = "Evacuarea de la Dunkerque"; Q107.Text = "26 mai 1940 – 4 iun. 1940";
            P108.Text = "Lend-Lease"; Q108.Text = "11 martie 1941";
            P109.Text = "Operațiunea Marița"; Q109.Text = "6 aprilie 1941";
            P110.Text = "Operațiunea Barbarossa "; Q110.Text = "22 iunie 1941";
            P111.Text = "Inființarea SAS"; Q111.Text = "1 iulie 1941";
            P112.Text = "Asediul Leningradului "; Q112.Text = "9 septembrie 1941";
            P113.Text = "Atacul de la Pearl Harbour"; Q113.Text = "7 decembrie 1941";
            P114.Text = "Batălia de la Stalingrad "; Q114.Text = "23 septembrie 1942";
            P115.Text = "Zidul Atlanticlui"; Q115.Text = "1942-1945";
            P116.Text = "Răscoală în ghetoul din Varșovia"; Q116.Text = "19 aprilie 1943";
            P117.Text = "Invazia Siciliei"; Q117.Text = "09 iul. 1943";
            P118.Text = "Conferinta de la Teheran"; Q118.Text = "28 nov. 1943 – 1 dec. 1943";

            P119.Text = "Ziua Z"; Q119.Text = "06 iunie 1944";
            P120.Text = "Încercarea de a-l asasina pa Hitler "; Q120.Text = "20 iulie 1944";
            P121.Text = "Răscoala de la Varșovia"; Q121.Text = "01 august 1944";
            P122.Text = "Lovitura de stat a Regelui "; Q122.Text = "23 august 1944";
            P123.Text = "Răscoala militara in Slovacia"; Q123.Text = "29 august 1944";
            P124.Text = "Conferința de la Moscova "; Q124.Text = "09 octombrie 1944";
             P125.Text = "Negocierile de la Ialta"; Q125.Text = "4-11 februarie 1945";
            P126.Text = "Cehoslovacia si programul parlamentar "; Q126.Text = "05 aprilie 1945";
            P127.Text = "Germania capitulează neconondiționat"; Q127.Text = "7 mai 1945";
            P128.Text = "Procesul celor 16"; Q128.Text = "17 iunie 1945";
            P129.Text = "Conferința de la Postdam "; Q129.Text = "17 iulie-2 august 1945";
            P130.Text = "Japonia este bombardata "; Q130.Text = "6-9 august 1945";
            P131.Text = "Auchwitz-ul este eliberat de trupele sovietice "; Q131.Text = "27 ianuarie 1945";
            P132.Text = "Procesele Nuemberg"; Q132.Text = "01 octombire 1946";

            
            //razboiul rece
            P133.Text = "Războiul Rece "; Q133.Text = "1947-1991";
            P134.Text = "Regele Mihai I este inlăturat de la putere"; Q134.Text = "30 dec 1947";
            P135.Text = "Planul Marhall "; Q135.Text = "01 iunie 1947";
            P136.Text = "CAER-omologul sovietic al Planului Marshall "; Q136.Text = "1947";
            P137.Text = "Proclamarea Republcii Populare România "; Q137.Text = "30 decembrie 1947";
            P138.Text = "Rezistenţa armată anticomunistă";Q138.Text = "1 ian. 1948";
            P139.Text = "Naționalizarea intreprinderilor "; Q139.Text = "11 iunie 1948";
            P140.Text = "Colectivizare agriculturii"; Q140.Text = "03 martie 1949";
            P141.Text = "Războiul Coreean "; Q141.Text = "25 iunie 1950- 27 iulie 1953";
            P142.Text = "Procesul judecătoresc al episcopilor catolici"; Q142.Text = "15 ianuarie 1951";
            P143.Text = "Est-berlinezii se răscoală"; Q143.Text = "17 iunie 1953";
            P144.Text = "Pactul de la Varsovia"; Q144.Text = "14 mai 1955";
            P145.Text = "Romania şi Pactul de la Varşovia "; Q145.Text = "14 mai 1955";
            P146.Text = "Criza Canalului Suez"; Q146.Text = "octombrie 1956-martie 1957";
            P147.Text = "România şi Revoluția Ungară "; Q147.Text = "23 octombrie 1956";
            P148.Text = "URSS ȋnăbuşeste Revoluția Ungară "; Q148.Text = "04 noimbrie 1956";
            P149.Text = "Anul Africii  "; Q149.Text = "1960";
            P150.Text = "Tratatul Antarcticii "; Q150.Text = "23 iunie 1961";
            P151.Text = "Zidul Berlinului "; Q151.Text = "13 august 1961";
            P152.Text = "Războiul din Vietnam"; Q152.Text = "1 noimbire 1961-30 aprilie 1975";
            P153.Text = "Criza Rachetlor din Cuba"; Q153.Text = "16 oct. 1962 – 28 oct. 1962";
            P154.Text = "Războiul de Șase Zile"; Q154.Text = "5 iun. 1967 – 10 iun. 1967";
            P155.Text = "1968"; //Q155.Text = "";
            P156.Text = "Primăvara de la Praga"; Q156.Text = "1968";
            P157.Text = "Invazia Cehoslovaciei"; Q157.Text = "20-21 august 1968";
            P158.Text = "Atitudinea României față de primăvara de la Praga"; Q158.Text = "20-21 august 1968";

            P159.Text = "Ceauşescu construieşte Transfăgărăşan"; Q159.Text = "1970-1974";
            P160.Text = "Masacrul de Munchen"; Q160.Text = "5 sept. 1972 – 6 sept. 1972";
            P161.Text = "Războiul de Iom Kipur"; Q161.Text = "6 oct. 1973 – 24 oct. 1973";
            P162.Text = "Proteste ȋn Polonia"; Q162.Text = "25 iunie 1976";
            P163.Text = "Criza ostaticilor din Iran"; Q163.Text = "4 nov. 1979-29ian .1981";
            P164.Text = "Invadarea Afganistanului "; Q164.Text = "27 dec. 1979 – 15 feb.1989";
            P165.Text = "Masacrul din Tianamen"; Q165.Text = "4 iunie 1989";
            P166.Text = "Zidul Berlinului este dărâmat"; Q166.Text = "09 noiembrie 1989";
            P167.Text = "Revoluția ȋn Romania"; Q167.Text = "16-22 dec.1989";
            P168.Text = "Reunificarea Germaniei";Q168.Text = "03 octombrie 1990";
            P169.Text = "Dizolvarea URSS ";Q169.Text = "26 decembrie 1991";


        
            
            Title1.Font = new Font("Cooper Black", 20);
   Countries1.Font = new Font("Courier New", 13);
            Date1.Font = new Font("Courier New",13);
          Countries1.ForeColor = Date1.ForeColor = Color.FromArgb(x2,y2,z2);

            Prev1.BackColor = Prev2.BackColor = Next1.BackColor = Next2.BackColor =Color.FromArgb (x1,y1,z1);
            Prev1.ForeColor = Prev2.ForeColor = Next1.ForeColor = Next2.ForeColor = Color.FromArgb(x2,y2,z2);
            Prev1.FlatStyle = Prev2.FlatStyle = Next1.FlatStyle = Next2.FlatStyle = FlatStyle.Flat;

            


            P1.MouseEnter += OnMouseEnterP1; P1.MouseLeave += OnMouseLeaveP1;
            Q1.MouseEnter += OnMouseEnterP1; Q1.MouseLeave += OnMouseLeaveP1;
            P2.MouseEnter += OnMouseEnterP2; P2.MouseLeave += OnMouseLeaveP2;
            Q2.MouseEnter += OnMouseEnterP2; Q2.MouseLeave += OnMouseLeaveP2;
            P3.MouseEnter += OnMouseEnterP3; P3.MouseLeave += OnMouseLeaveP3;
            Q3.MouseEnter += OnMouseEnterP3; Q3.MouseLeave += OnMouseLeaveP3;
            P4.MouseEnter += OnMouseEnterP4; P4.MouseLeave += OnMouseLeaveP4;
            Q4.MouseEnter += OnMouseEnterP4; Q4.MouseLeave += OnMouseLeaveP4;
            P5.MouseEnter += OnMouseEnterP5; P5.MouseLeave += OnMouseLeaveP5;
            Q5.MouseEnter += OnMouseEnterP5; Q5.MouseLeave += OnMouseLeaveP5;
            P6.MouseEnter += OnMouseEnterP6; P6.MouseLeave += OnMouseLeaveP6;
            Q6.MouseEnter += OnMouseEnterP6; Q6.MouseLeave += OnMouseLeaveP6;
            P7.MouseEnter += OnMouseEnterP7; P7.MouseLeave += OnMouseLeaveP7;
            Q7.MouseEnter += OnMouseEnterP7; Q7.MouseLeave += OnMouseLeaveP7;
            P8.MouseEnter += OnMouseEnterP8; P8.MouseLeave += OnMouseLeaveP8;
            Q8.MouseEnter += OnMouseEnterP8; Q8.MouseLeave += OnMouseLeaveP8;
            P9.MouseEnter += OnMouseEnterP9; P9.MouseLeave += OnMouseLeaveP9;
            Q9.MouseEnter += OnMouseEnterP9; Q9.MouseLeave += OnMouseLeaveP9;
            P10.MouseEnter += OnMouseEnterP10; P10.MouseLeave += OnMouseLeaveP10;
            Q10.MouseEnter += OnMouseEnterP10; Q10.MouseLeave += OnMouseLeaveP10;
            P11.MouseEnter += OnMouseEnterP11; P11.MouseLeave += OnMouseLeaveP11;
            Q11.MouseEnter += OnMouseEnterP11; Q11.MouseLeave += OnMouseLeaveP11;
            P12.MouseEnter += OnMouseEnterP12; P12.MouseLeave += OnMouseLeaveP12;
            Q12.MouseEnter += OnMouseEnterP12; Q12.MouseLeave += OnMouseLeaveP12;
            P13.MouseEnter += OnMouseEnterP13; P13.MouseLeave += OnMouseLeaveP13;
            Q13.MouseEnter += OnMouseEnterP13; Q13.MouseLeave += OnMouseLeaveP13;
            P14.MouseEnter += OnMouseEnterP14; P14.MouseLeave += OnMouseLeaveP14;
            Q14.MouseEnter += OnMouseEnterP14; Q14.MouseLeave += OnMouseLeaveP14;
            P15.MouseEnter += OnMouseEnterP15; P15.MouseLeave += OnMouseLeaveP15;
            Q15.MouseEnter += OnMouseEnterP15; Q15.MouseLeave += OnMouseLeaveP15;
            P16.MouseEnter += OnMouseEnterP16; P16.MouseLeave += OnMouseLeaveP16;
            Q16.MouseEnter += OnMouseEnterP16; Q16.MouseLeave += OnMouseLeaveP16;
            P17.MouseEnter += OnMouseEnterP17; P17.MouseLeave += OnMouseLeaveP17;
            Q17.MouseEnter += OnMouseEnterP17; Q17.MouseLeave += OnMouseLeaveP17;
            P18.MouseEnter += OnMouseEnterP18; P18.MouseLeave += OnMouseLeaveP18;
            Q18.MouseEnter += OnMouseEnterP18; Q18.MouseLeave += OnMouseLeaveP18;
            P19.MouseEnter += OnMouseEnterP19; P19.MouseLeave += OnMouseLeaveP19;
            Q19.MouseEnter += OnMouseEnterP19; Q19.MouseLeave += OnMouseLeaveP19;
            P20.MouseEnter += OnMouseEnterP20; P20.MouseLeave += OnMouseLeaveP20;
            Q20.MouseEnter += OnMouseEnterP20; Q20.MouseLeave += OnMouseLeaveP20;
            P21.MouseEnter += OnMouseEnterP21; P21.MouseLeave += OnMouseLeaveP21;
            Q21.MouseEnter += OnMouseEnterP21; Q21.MouseLeave += OnMouseLeaveP21;
            P22.MouseEnter += OnMouseEnterP22; P22.MouseLeave += OnMouseLeaveP22;
            Q22.MouseEnter += OnMouseEnterP22; Q22.MouseLeave += OnMouseLeaveP22;
            P23.MouseEnter += OnMouseEnterP23; P23.MouseLeave += OnMouseLeaveP23;
            Q23.MouseEnter += OnMouseEnterP23; Q23.MouseLeave += OnMouseLeaveP23;
            P24.MouseEnter += OnMouseEnterP24; P24.MouseLeave += OnMouseLeaveP24;
            Q24.MouseEnter += OnMouseEnterP24; Q24.MouseLeave += OnMouseLeaveP24;
            P25.MouseEnter += OnMouseEnterP25; P25.MouseLeave += OnMouseLeaveP25;
            Q25.MouseEnter += OnMouseEnterP25; Q25.MouseLeave += OnMouseLeaveP25;
            P26.MouseEnter += OnMouseEnterP26; P26.MouseLeave += OnMouseLeaveP26;
            Q26.MouseEnter += OnMouseEnterP26; Q26.MouseLeave += OnMouseLeaveP26;
            P27.MouseEnter += OnMouseEnterP27; P27.MouseLeave += OnMouseLeaveP27;
            Q27.MouseEnter += OnMouseEnterP27; Q27.MouseLeave += OnMouseLeaveP27;
            P28.MouseEnter += OnMouseEnterP28; P28.MouseLeave += OnMouseLeaveP28;
            Q28.MouseEnter += OnMouseEnterP28; Q28.MouseLeave += OnMouseLeaveP28;
            P29.MouseEnter += OnMouseEnterP29; P29.MouseLeave += OnMouseLeaveP29;
            Q29.MouseEnter += OnMouseEnterP29; Q29.MouseLeave += OnMouseLeaveP29;
            P30.MouseEnter += OnMouseEnterP30; P30.MouseLeave += OnMouseLeaveP30;
            Q30.MouseEnter += OnMouseEnterP30; Q30.MouseLeave += OnMouseLeaveP30;
            P31.MouseEnter += OnMouseEnterP31; P31.MouseLeave += OnMouseLeaveP31;
            Q31.MouseEnter += OnMouseEnterP31; Q31.MouseLeave += OnMouseLeaveP31;
            P32.MouseEnter += OnMouseEnterP32; P32.MouseLeave += OnMouseLeaveP32;
            Q32.MouseEnter += OnMouseEnterP32; Q32.MouseLeave += OnMouseLeaveP32;
            P33.MouseEnter += OnMouseEnterP33; P33.MouseLeave += OnMouseLeaveP33;
            Q33.MouseEnter += OnMouseEnterP33; Q33.MouseLeave += OnMouseLeaveP33;
            P34.MouseEnter += OnMouseEnterP34; P34.MouseLeave += OnMouseLeaveP34;
            Q34.MouseEnter += OnMouseEnterP34; Q34.MouseLeave += OnMouseLeaveP34;
            P35.MouseEnter += OnMouseEnterP35; P35.MouseLeave += OnMouseLeaveP35;
            Q35.MouseEnter += OnMouseEnterP35; Q35.MouseLeave += OnMouseLeaveP35;
            P36.MouseEnter += OnMouseEnterP36; P36.MouseLeave += OnMouseLeaveP36;
            Q36.MouseEnter += OnMouseEnterP36; Q36.MouseLeave += OnMouseLeaveP36;
            P37.MouseEnter += OnMouseEnterP37; P37.MouseLeave += OnMouseLeaveP37;
            Q37.MouseEnter += OnMouseEnterP37; Q37.MouseLeave += OnMouseLeaveP37;
            P38.MouseEnter += OnMouseEnterP38; P38.MouseLeave += OnMouseLeaveP38;
            Q38.MouseEnter += OnMouseEnterP38; Q38.MouseLeave += OnMouseLeaveP38;
            P39.MouseEnter += OnMouseEnterP39; P39.MouseLeave += OnMouseLeaveP39;
            Q39.MouseEnter += OnMouseEnterP39; Q39.MouseLeave += OnMouseLeaveP39;
            P40.MouseEnter += OnMouseEnterP40; P40.MouseLeave += OnMouseLeaveP40;
           P41.MouseEnter += OnMouseEnterP41; P41.MouseLeave += OnMouseLeaveP41;
            Q41.MouseEnter += OnMouseEnterP41; Q41.MouseLeave += OnMouseLeaveP41;
            P42.MouseEnter += OnMouseEnterP42; P42.MouseLeave += OnMouseLeaveP42;
            Q42.MouseEnter += OnMouseEnterP42; Q42.MouseLeave += OnMouseLeaveP42;
            P43.MouseEnter += OnMouseEnterP43; P43.MouseLeave += OnMouseLeaveP43;
            P44.MouseEnter += OnMouseEnterP44; P44.MouseLeave += OnMouseLeaveP44;
            Q44.MouseEnter += OnMouseEnterP44; Q44.MouseLeave += OnMouseLeaveP44;
            P45.MouseEnter += OnMouseEnterP45; P45.MouseLeave += OnMouseLeaveP45;
            
            P46.MouseEnter += OnMouseEnterP46; P46.MouseLeave += OnMouseLeaveP46;
            Q46.MouseEnter += OnMouseEnterP46; Q46.MouseLeave += OnMouseLeaveP46;
            P47.MouseEnter += OnMouseEnterP47; P47.MouseLeave += OnMouseLeaveP47;
            Q47.MouseEnter += OnMouseEnterP47; Q47.MouseLeave += OnMouseLeaveP47;
            P48.MouseEnter += OnMouseEnterP48; P48.MouseLeave += OnMouseLeaveP48;
            Q48.MouseEnter += OnMouseEnterP48; Q48.MouseLeave += OnMouseLeaveP48;
            P49.MouseEnter += OnMouseEnterP49; P49.MouseLeave += OnMouseLeaveP49;
            Q49.MouseEnter += OnMouseEnterP49; Q49.MouseLeave += OnMouseLeaveP49;
            P50.MouseEnter += OnMouseEnterP50; P50.MouseLeave += OnMouseLeaveP50;
            Q50.MouseEnter += OnMouseEnterP50; Q50.MouseLeave += OnMouseLeaveP50;
            P51.MouseEnter += OnMouseEnterP51; P51.MouseLeave += OnMouseLeaveP51;
            Q51.MouseEnter += OnMouseEnterP51; Q51.MouseLeave += OnMouseLeaveP51;
            P52.MouseEnter += OnMouseEnterP52; P52.MouseLeave += OnMouseLeaveP52;
            Q52.MouseEnter += OnMouseEnterP52; Q52.MouseLeave += OnMouseLeaveP52;
            P53.MouseEnter += OnMouseEnterP53; P53.MouseLeave += OnMouseLeaveP53;
            P54.MouseEnter += OnMouseEnterP54; P54.MouseLeave += OnMouseLeaveP54;
            Q54.MouseEnter += OnMouseEnterP54; Q54.MouseLeave += OnMouseLeaveP54;
            P55.MouseEnter += OnMouseEnterP55; P55.MouseLeave += OnMouseLeaveP55;
            Q55.MouseEnter += OnMouseEnterP55; Q55.MouseLeave += OnMouseLeaveP55;
            P56.MouseEnter += OnMouseEnterP56; P56.MouseLeave += OnMouseLeaveP56;
            Q56.MouseEnter += OnMouseEnterP56; Q56.MouseLeave += OnMouseLeaveP56;
            P57.MouseEnter += OnMouseEnterP57; P57.MouseLeave += OnMouseLeaveP57;
            P58.MouseEnter += OnMouseEnterP58; P58.MouseLeave += OnMouseLeaveP58;
            Q58.MouseEnter += OnMouseEnterP58; Q58.MouseLeave += OnMouseLeaveP58;
            P59.MouseEnter += OnMouseEnterP59; P59.MouseLeave += OnMouseLeaveP59;
            Q59.MouseEnter += OnMouseEnterP59; Q59.MouseLeave += OnMouseLeaveP59;
            P60.MouseEnter += OnMouseEnterP60; P60.MouseLeave += OnMouseLeaveP60;
            Q60.MouseEnter += OnMouseEnterP60; Q60.MouseLeave += OnMouseLeaveP60;
            P61.MouseEnter += OnMouseEnterP61; P61.MouseLeave += OnMouseLeaveP61;
            Q61.MouseEnter += OnMouseEnterP61; Q61.MouseLeave += OnMouseLeaveP61;
            P62.MouseEnter += OnMouseEnterP62; P62.MouseLeave += OnMouseLeaveP62;
            Q62.MouseEnter += OnMouseEnterP62; Q62.MouseLeave += OnMouseLeaveP62;
            P63.MouseEnter += OnMouseEnterP63; P63.MouseLeave += OnMouseLeaveP63;
            Q63.MouseEnter += OnMouseEnterP63; Q63.MouseLeave += OnMouseLeaveP63;
            P64.MouseEnter += OnMouseEnterP64; P64.MouseLeave += OnMouseLeaveP64;
            Q64.MouseEnter += OnMouseEnterP64; Q64.MouseLeave += OnMouseLeaveP64;
            P65.MouseEnter += OnMouseEnterP65; P65.MouseLeave += OnMouseLeaveP65;
            Q65.MouseEnter += OnMouseEnterP65; Q65.MouseLeave += OnMouseLeaveP65;
            P66.MouseEnter += OnMouseEnterP66; P66.MouseLeave += OnMouseLeaveP66;
            Q66.MouseEnter += OnMouseEnterP66; Q66.MouseLeave += OnMouseLeaveP66;
            P67.MouseEnter += OnMouseEnterP67; P67.MouseLeave += OnMouseLeaveP67;
            Q67.MouseEnter += OnMouseEnterP67; Q67.MouseLeave += OnMouseLeaveP67;
            P68.MouseEnter += OnMouseEnterP68; P68.MouseLeave += OnMouseLeaveP68;
            Q68.MouseEnter += OnMouseEnterP68; Q68.MouseLeave += OnMouseLeaveP68;
            P69.MouseEnter += OnMouseEnterP69; P69.MouseLeave += OnMouseLeaveP69;
            Q69.MouseEnter += OnMouseEnterP69; Q69.MouseLeave += OnMouseLeaveP69;
            P70.MouseEnter += OnMouseEnterP70; P70.MouseLeave += OnMouseLeaveP70;
            Q70.MouseEnter += OnMouseEnterP70; Q70.MouseLeave += OnMouseLeaveP70;
            P71.MouseEnter += OnMouseEnterP71; P71.MouseLeave += OnMouseLeaveP71;
            Q71.MouseEnter += OnMouseEnterP71; Q71.MouseLeave += OnMouseLeaveP71;
            P72.MouseEnter += OnMouseEnterP72; P72.MouseLeave += OnMouseLeaveP72;
            Q72.MouseEnter += OnMouseEnterP72; Q72.MouseLeave += OnMouseLeaveP72;
            P73.MouseEnter += OnMouseEnterP73; P73.MouseLeave += OnMouseLeaveP73;
            Q73.MouseEnter += OnMouseEnterP73; Q73.MouseLeave += OnMouseLeaveP73;
            P74.MouseEnter += OnMouseEnterP74; P74.MouseLeave += OnMouseLeaveP74;
            Q74.MouseEnter += OnMouseEnterP74; Q74.MouseLeave += OnMouseLeaveP74;
            P75.MouseEnter += OnMouseEnterP75; P75.MouseLeave += OnMouseLeaveP75;
            Q75.MouseEnter += OnMouseEnterP75; Q75.MouseLeave += OnMouseLeaveP75;
            P76.MouseEnter += OnMouseEnterP76; P76.MouseLeave += OnMouseLeaveP76;
            Q76.MouseEnter += OnMouseEnterP76; Q76.MouseLeave += OnMouseLeaveP76;
            P77.MouseEnter += OnMouseEnterP77; P77.MouseLeave += OnMouseLeaveP77;
            Q77.MouseEnter += OnMouseEnterP77; Q77.MouseLeave += OnMouseLeaveP77;
            P78.MouseEnter += OnMouseEnterP78; P78.MouseLeave += OnMouseLeaveP78;
            Q78.MouseEnter += OnMouseEnterP78; Q78.MouseLeave += OnMouseLeaveP78;
            P79.MouseEnter += OnMouseEnterP79; P79.MouseLeave += OnMouseLeaveP79;
            Q79.MouseEnter += OnMouseEnterP79; Q79.MouseLeave += OnMouseLeaveP79;
            P80.MouseEnter += OnMouseEnterP80; P80.MouseLeave += OnMouseLeaveP80;
            Q80.MouseEnter += OnMouseEnterP80; Q80.MouseLeave += OnMouseLeaveP80;
            P81.MouseEnter += OnMouseEnterP81; P81.MouseLeave += OnMouseLeaveP81;
            Q81.MouseEnter += OnMouseEnterP81; Q81.MouseLeave += OnMouseLeaveP81;
            P82.MouseEnter += OnMouseEnterP82; P82.MouseLeave += OnMouseLeaveP82;
            Q82.MouseEnter += OnMouseEnterP82; Q82.MouseLeave += OnMouseLeaveP82;
            P83.MouseEnter += OnMouseEnterP83; P83.MouseLeave += OnMouseLeaveP83;
            Q83.MouseEnter += OnMouseEnterP83; Q83.MouseLeave += OnMouseLeaveP83;
            P84.MouseEnter += OnMouseEnterP84; P84.MouseLeave += OnMouseLeaveP84;
            Q84.MouseEnter += OnMouseEnterP84; Q84.MouseLeave += OnMouseLeaveP84;
            P85.MouseEnter += OnMouseEnterP85; P85.MouseLeave += OnMouseLeaveP85;
            Q85.MouseEnter += OnMouseEnterP85; Q85.MouseLeave += OnMouseLeaveP85;
            P86.MouseEnter += OnMouseEnterP86; P86.MouseLeave += OnMouseLeaveP86;
            Q86.MouseEnter += OnMouseEnterP86; Q86.MouseLeave += OnMouseLeaveP86;
            P87.MouseEnter += OnMouseEnterP87; P87.MouseLeave += OnMouseLeaveP87;
            Q87.MouseEnter += OnMouseEnterP87; Q87.MouseLeave += OnMouseLeaveP87;
            P88.MouseEnter += OnMouseEnterP88; P88.MouseLeave += OnMouseLeaveP88;
            Q88.MouseEnter += OnMouseEnterP88; Q88.MouseLeave += OnMouseLeaveP88;
            P89.MouseEnter += OnMouseEnterP89; P89.MouseLeave += OnMouseLeaveP89;
            Q89.MouseEnter += OnMouseEnterP89; Q89.MouseLeave += OnMouseLeaveP89;
            P90.MouseEnter += OnMouseEnterP90; P90.MouseLeave += OnMouseLeaveP90;
            Q90.MouseEnter += OnMouseEnterP90; Q90.MouseLeave += OnMouseLeaveP90;
            P91.MouseEnter += OnMouseEnterP91; P91.MouseLeave += OnMouseLeaveP91;
            Q91.MouseEnter += OnMouseEnterP91; Q91.MouseLeave += OnMouseLeaveP91;
            P92.MouseEnter += OnMouseEnterP92; P92.MouseLeave += OnMouseLeaveP92;
            Q92.MouseEnter += OnMouseEnterP92; Q92.MouseLeave += OnMouseLeaveP92;
            P93.MouseEnter += OnMouseEnterP93; P93.MouseLeave += OnMouseLeaveP93;
            Q93.MouseEnter += OnMouseEnterP93; Q93.MouseLeave += OnMouseLeaveP93;
            P94.MouseEnter += OnMouseEnterP94; P94.MouseLeave += OnMouseLeaveP94;
            Q94.MouseEnter += OnMouseEnterP94; Q94.MouseLeave += OnMouseLeaveP94;
            P95.MouseEnter += OnMouseEnterP95; P95.MouseLeave += OnMouseLeaveP95;
            Q95.MouseEnter += OnMouseEnterP95; Q95.MouseLeave += OnMouseLeaveP95;
            P96.MouseEnter += OnMouseEnterP96; P96.MouseLeave += OnMouseLeaveP96;
            Q96.MouseEnter += OnMouseEnterP96; Q96.MouseLeave += OnMouseLeaveP96;
            P97.MouseEnter += OnMouseEnterP97; P97.MouseLeave += OnMouseLeaveP97;
            Q97.MouseEnter += OnMouseEnterP97; Q97.MouseLeave += OnMouseLeaveP97;
            P98.MouseEnter += OnMouseEnterP98; P98.MouseLeave += OnMouseLeaveP98;
            Q98.MouseEnter += OnMouseEnterP98; Q98.MouseLeave += OnMouseLeaveP98;
            P99.MouseEnter += OnMouseEnterP99; P99.MouseLeave += OnMouseLeaveP99;
            Q99.MouseEnter += OnMouseEnterP99; Q99.MouseLeave += OnMouseLeaveP99;
            P100.MouseEnter += OnMouseEnterP100; P100.MouseLeave += OnMouseLeaveP100;
            Q100.MouseEnter += OnMouseEnterP100; Q100.MouseLeave += OnMouseLeaveP100;
            P101.MouseEnter += OnMouseEnterP101; P101.MouseLeave += OnMouseLeaveP101;
            Q101.MouseEnter += OnMouseEnterP101; Q101.MouseLeave += OnMouseLeaveP101;
            P102.MouseEnter += OnMouseEnterP102; P102.MouseLeave += OnMouseLeaveP102;
            Q102.MouseEnter += OnMouseEnterP102; Q102.MouseLeave += OnMouseLeaveP102;
            P103.MouseEnter += OnMouseEnterP103; P103.MouseLeave += OnMouseLeaveP103;
            Q103.MouseEnter += OnMouseEnterP103; Q103.MouseLeave += OnMouseLeaveP103;
            P104.MouseEnter += OnMouseEnterP104; P104.MouseLeave += OnMouseLeaveP104;
            Q104.MouseEnter += OnMouseEnterP104; Q104.MouseLeave += OnMouseLeaveP104;
            P105.MouseEnter += OnMouseEnterP105; P105.MouseLeave += OnMouseLeaveP105;
            Q105.MouseEnter += OnMouseEnterP105; Q105.MouseLeave += OnMouseLeaveP105;
            P106.MouseEnter += OnMouseEnterP106; P106.MouseLeave += OnMouseLeaveP106;
            Q106.MouseEnter += OnMouseEnterP106; Q106.MouseLeave += OnMouseLeaveP106;
            P107.MouseEnter += OnMouseEnterP107; P107.MouseLeave += OnMouseLeaveP107;
            Q107.MouseEnter += OnMouseEnterP107; Q107.MouseLeave += OnMouseLeaveP107;
            P108.MouseEnter += OnMouseEnterP108; P108.MouseLeave += OnMouseLeaveP108;
            Q108.MouseEnter += OnMouseEnterP108; Q108.MouseLeave += OnMouseLeaveP108;
            P109.MouseEnter += OnMouseEnterP109; P109.MouseLeave += OnMouseLeaveP109;
            Q109.MouseEnter += OnMouseEnterP109; Q109.MouseLeave += OnMouseLeaveP109;
            P110.MouseEnter += OnMouseEnterP110; P110.MouseLeave += OnMouseLeaveP110;
            Q110.MouseEnter += OnMouseEnterP110; Q110.MouseLeave += OnMouseLeaveP110;
            P111.MouseEnter += OnMouseEnterP111; P111.MouseLeave += OnMouseLeaveP111;
            Q111.MouseEnter += OnMouseEnterP111; Q111.MouseLeave += OnMouseLeaveP111;
            P112.MouseEnter += OnMouseEnterP112; P112.MouseLeave += OnMouseLeaveP112;
            Q112.MouseEnter += OnMouseEnterP112; Q112.MouseLeave += OnMouseLeaveP112;
            P113.MouseEnter += OnMouseEnterP113; P113.MouseLeave += OnMouseLeaveP113;
            Q113.MouseEnter += OnMouseEnterP113; Q113.MouseLeave += OnMouseLeaveP113;
            P114.MouseEnter += OnMouseEnterP114; P114.MouseLeave += OnMouseLeaveP114;
            Q114.MouseEnter += OnMouseEnterP114; Q114.MouseLeave += OnMouseLeaveP114;
            P115.MouseEnter += OnMouseEnterP115; P115.MouseLeave += OnMouseLeaveP115;
            Q115.MouseEnter += OnMouseEnterP115; Q115.MouseLeave += OnMouseLeaveP115;
            P116.MouseEnter += OnMouseEnterP116; P116.MouseLeave += OnMouseLeaveP116;
            Q116.MouseEnter += OnMouseEnterP116; Q116.MouseLeave += OnMouseLeaveP116;
            P117.MouseEnter += OnMouseEnterP117; P117.MouseLeave += OnMouseLeaveP117;
            Q117.MouseEnter += OnMouseEnterP117; Q117.MouseLeave += OnMouseLeaveP117;
            P118.MouseEnter += OnMouseEnterP118; P118.MouseLeave += OnMouseLeaveP118;
            Q118.MouseEnter += OnMouseEnterP118; Q118.MouseLeave += OnMouseLeaveP118;
            P119.MouseEnter += OnMouseEnterP119; P119.MouseLeave += OnMouseLeaveP119;
            Q119.MouseEnter += OnMouseEnterP119; Q119.MouseLeave += OnMouseLeaveP119;
            P120.MouseEnter += OnMouseEnterP120; P120.MouseLeave += OnMouseLeaveP120;
            Q120.MouseEnter += OnMouseEnterP120; Q120.MouseLeave += OnMouseLeaveP120;
            P121.MouseEnter += OnMouseEnterP121; P121.MouseLeave += OnMouseLeaveP121;
            Q121.MouseEnter += OnMouseEnterP121; Q121.MouseLeave += OnMouseLeaveP121;
            P122.MouseEnter += OnMouseEnterP122; P122.MouseLeave += OnMouseLeaveP122;
            Q122.MouseEnter += OnMouseEnterP122; Q122.MouseLeave += OnMouseLeaveP122;
            P123.MouseEnter += OnMouseEnterP123; P123.MouseLeave += OnMouseLeaveP123;
            Q123.MouseEnter += OnMouseEnterP123; Q123.MouseLeave += OnMouseLeaveP123;
            P124.MouseEnter += OnMouseEnterP124; P124.MouseLeave += OnMouseLeaveP124;
            Q124.MouseEnter += OnMouseEnterP124; Q124.MouseLeave += OnMouseLeaveP124;
            P125.MouseEnter += OnMouseEnterP125; P125.MouseLeave += OnMouseLeaveP125;
            Q125.MouseEnter += OnMouseEnterP125; Q125.MouseLeave += OnMouseLeaveP125;
            P126.MouseEnter += OnMouseEnterP126; P126.MouseLeave += OnMouseLeaveP126;
            Q126.MouseEnter += OnMouseEnterP126; Q126.MouseLeave += OnMouseLeaveP126;
            P127.MouseEnter += OnMouseEnterP127; P127.MouseLeave += OnMouseLeaveP127;
            Q127.MouseEnter += OnMouseEnterP127; Q127.MouseLeave += OnMouseLeaveP127;
            P128.MouseEnter += OnMouseEnterP128; P128.MouseLeave += OnMouseLeaveP128;
            Q128.MouseEnter += OnMouseEnterP128; Q128.MouseLeave += OnMouseLeaveP128;
            P129.MouseEnter += OnMouseEnterP129; P129.MouseLeave += OnMouseLeaveP129;
            Q129.MouseEnter += OnMouseEnterP129; Q129.MouseLeave += OnMouseLeaveP129;
            P130.MouseEnter += OnMouseEnterP130; P130.MouseLeave += OnMouseLeaveP130;
            Q130.MouseEnter += OnMouseEnterP130; Q130.MouseLeave += OnMouseLeaveP130;
            P131.MouseEnter += OnMouseEnterP131; P131.MouseLeave += OnMouseLeaveP131;
            Q131.MouseEnter += OnMouseEnterP131; Q131.MouseLeave += OnMouseLeaveP131;
            P132.MouseEnter += OnMouseEnterP132; P132.MouseLeave += OnMouseLeaveP132;
            Q132.MouseEnter += OnMouseEnterP132; Q132.MouseLeave += OnMouseLeaveP132;
            P133.MouseEnter += OnMouseEnterP133; P133.MouseLeave += OnMouseLeaveP133;
            Q133.MouseEnter += OnMouseEnterP133; Q133.MouseLeave += OnMouseLeaveP133;
            P134.MouseEnter += OnMouseEnterP134; P134.MouseLeave += OnMouseLeaveP134;
            Q134.MouseEnter += OnMouseEnterP134; Q134.MouseLeave += OnMouseLeaveP134;
            P135.MouseEnter += OnMouseEnterP135; P135.MouseLeave += OnMouseLeaveP135;
            Q135.MouseEnter += OnMouseEnterP135; Q135.MouseLeave += OnMouseLeaveP135;
            P136.MouseEnter += OnMouseEnterP136; P136.MouseLeave += OnMouseLeaveP136;
            Q136.MouseEnter += OnMouseEnterP136; Q136.MouseLeave += OnMouseLeaveP136;
            P137.MouseEnter += OnMouseEnterP137; P137.MouseLeave += OnMouseLeaveP137;
            Q137.MouseEnter += OnMouseEnterP137; Q137.MouseLeave += OnMouseLeaveP137;
            P138.MouseEnter += OnMouseEnterP138; P138.MouseLeave += OnMouseLeaveP138;
            Q138.MouseEnter += OnMouseEnterP138; Q138.MouseLeave += OnMouseLeaveP138;
            P139.MouseEnter += OnMouseEnterP139; P139.MouseLeave += OnMouseLeaveP139;
            Q139.MouseEnter += OnMouseEnterP139; Q139.MouseLeave += OnMouseLeaveP139;
            P140.MouseEnter += OnMouseEnterP140; P140.MouseLeave += OnMouseLeaveP140;
            Q140.MouseEnter += OnMouseEnterP140; Q140.MouseLeave += OnMouseLeaveP140;
            P141.MouseEnter += OnMouseEnterP141; P141.MouseLeave += OnMouseLeaveP141;
            Q141.MouseEnter += OnMouseEnterP141; Q141.MouseLeave += OnMouseLeaveP141;
            P142.MouseEnter += OnMouseEnterP142; P142.MouseLeave += OnMouseLeaveP142;
            Q142.MouseEnter += OnMouseEnterP142; Q142.MouseLeave += OnMouseLeaveP142;
            P143.MouseEnter += OnMouseEnterP143; P143.MouseLeave += OnMouseLeaveP143;
            Q143.MouseEnter += OnMouseEnterP143; Q143.MouseLeave += OnMouseLeaveP143;
            P144.MouseEnter += OnMouseEnterP144; P144.MouseLeave += OnMouseLeaveP144;
            Q144.MouseEnter += OnMouseEnterP144; Q144.MouseLeave += OnMouseLeaveP144;
            P145.MouseEnter += OnMouseEnterP145; P145.MouseLeave += OnMouseLeaveP145;
            Q145.MouseEnter += OnMouseEnterP145; Q145.MouseLeave += OnMouseLeaveP145;
            P146.MouseEnter += OnMouseEnterP146; P146.MouseLeave += OnMouseLeaveP146;
            Q146.MouseEnter += OnMouseEnterP146; Q146.MouseLeave += OnMouseLeaveP146;
            P147.MouseEnter += OnMouseEnterP147; P147.MouseLeave += OnMouseLeaveP147;
            Q147.MouseEnter += OnMouseEnterP147; Q147.MouseLeave += OnMouseLeaveP147;
            P148.MouseEnter += OnMouseEnterP148; P148.MouseLeave += OnMouseLeaveP148;
            Q148.MouseEnter += OnMouseEnterP148; Q148.MouseLeave += OnMouseLeaveP148;
            P149.MouseEnter += OnMouseEnterP149; P149.MouseLeave += OnMouseLeaveP149;
            Q149.MouseEnter += OnMouseEnterP149; Q149.MouseLeave += OnMouseLeaveP149;
            P150.MouseEnter += OnMouseEnterP150; P150.MouseLeave += OnMouseLeaveP150;
            Q150.MouseEnter += OnMouseEnterP150; Q150.MouseLeave += OnMouseLeaveP150;
            P151.MouseEnter += OnMouseEnterP151; P151.MouseLeave += OnMouseLeaveP151;
            Q151.MouseEnter += OnMouseEnterP151; Q151.MouseLeave += OnMouseLeaveP151;
            P152.MouseEnter += OnMouseEnterP152; P152.MouseLeave += OnMouseLeaveP152;
            Q152.MouseEnter += OnMouseEnterP152; Q152.MouseLeave += OnMouseLeaveP152;
            P153.MouseEnter += OnMouseEnterP153; P153.MouseLeave += OnMouseLeaveP153;
            Q153.MouseEnter += OnMouseEnterP153; Q153.MouseLeave += OnMouseLeaveP153;
            P154.MouseEnter += OnMouseEnterP154; P154.MouseLeave += OnMouseLeaveP154;
            Q154.MouseEnter += OnMouseEnterP154; Q154.MouseLeave += OnMouseLeaveP154;
            P155.MouseEnter += OnMouseEnterP155; P155.MouseLeave += OnMouseLeaveP155;
           
            P156.MouseEnter += OnMouseEnterP156; P156.MouseLeave += OnMouseLeaveP156;
            Q156.MouseEnter += OnMouseEnterP156; Q156.MouseLeave += OnMouseLeaveP156;
            P157.MouseEnter += OnMouseEnterP157; P157.MouseLeave += OnMouseLeaveP157;
            Q157.MouseEnter += OnMouseEnterP157; Q157.MouseLeave += OnMouseLeaveP157;
            P158.MouseEnter += OnMouseEnterP158; P158.MouseLeave += OnMouseLeaveP158;
            Q158.MouseEnter += OnMouseEnterP158; Q158.MouseLeave += OnMouseLeaveP158;
            P159.MouseEnter += OnMouseEnterP159; P159.MouseLeave += OnMouseLeaveP159;
            Q159.MouseEnter += OnMouseEnterP159; Q159.MouseLeave += OnMouseLeaveP159;
            P160.MouseEnter += OnMouseEnterP160; P160.MouseLeave += OnMouseLeaveP160;
            Q160.MouseEnter += OnMouseEnterP160; Q160.MouseLeave += OnMouseLeaveP160;
            P161.MouseEnter += OnMouseEnterP161; P161.MouseLeave += OnMouseLeaveP161;
            Q161.MouseEnter += OnMouseEnterP161; Q161.MouseLeave += OnMouseLeaveP161;
            P162.MouseEnter += OnMouseEnterP162; P162.MouseLeave += OnMouseLeaveP162;
            Q162.MouseEnter += OnMouseEnterP162; Q162.MouseLeave += OnMouseLeaveP162;
            P163.MouseEnter += OnMouseEnterP163; P163.MouseLeave += OnMouseLeaveP163;
            Q163.MouseEnter += OnMouseEnterP163; Q163.MouseLeave += OnMouseLeaveP163;
            P164.MouseEnter += OnMouseEnterP164; P164.MouseLeave += OnMouseLeaveP164;
            Q164.MouseEnter += OnMouseEnterP164; Q164.MouseLeave += OnMouseLeaveP164;
            P165.MouseEnter += OnMouseEnterP165; P165.MouseLeave += OnMouseLeaveP165;
            Q165.MouseEnter += OnMouseEnterP165; Q165.MouseLeave += OnMouseLeaveP165;
            P166.MouseEnter += OnMouseEnterP166; P166.MouseLeave += OnMouseLeaveP166;
            Q166.MouseEnter += OnMouseEnterP166; Q166.MouseLeave += OnMouseLeaveP166;
            P167.MouseEnter += OnMouseEnterP167; P167.MouseLeave += OnMouseLeaveP167;
            Q167.MouseEnter += OnMouseEnterP167; Q167.MouseLeave += OnMouseLeaveP167;
            P168.MouseEnter += OnMouseEnterP168; P168.MouseLeave += OnMouseLeaveP168;
            Q168.MouseEnter += OnMouseEnterP168; Q168.MouseLeave += OnMouseLeaveP168;
            P169.MouseEnter += OnMouseEnterP169; P169.MouseLeave += OnMouseLeaveP169;
            Q169.MouseEnter += OnMouseEnterP169; Q169.MouseLeave += OnMouseLeaveP169;
           

            //  pictureBox1.BackgroundImage = Properties.Resources.mafiot;

            //       mafiamember.Visible = interogatoriu.Visible = false;


            interogatoriu.Visible =DA.Visible=NU.Visible=mafiamember.Visible= false;

            interogatoriu.ForeColor = Color.White;
            DA.ForeColor = NU.ForeColor = Color.White;
            DA.MouseEnter += OnMouseEnterDA; DA.MouseLeave += OnMouseLeaveDA;
            NU.MouseEnter += OnMouseEnterNU; NU.MouseLeave += OnMouseLeaveNU;

            

        }

        private const int CS_DropShadow = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        void shift_tab(int nr)
        {
               meme = 0; afis_meme();
            panel2.AutoScroll = false;
            ARROW.Visible = T1.Visible = SC1.Visible = S1.Visible = Biog1.Visible = false;
            stanga_output.BackColor = Color.FromArgb(198, 131, 14);
            
            materialvideo1.Visible = WB1.Visible = false;
            Descriere2.Visible = false;
            Descriere1.Visible = true;

            panel1.AutoScroll = panel2.AutoScroll = false;
            panel2.Visible = true;
            TAB.Visible = true;
            TAB2.Visible = true;
            Descriere2.Font = Descriere1.Font = new Font("Courier New", 13);


        //    webBrowser1.Visible = WB1.Visible = false;
            
            
            if (nr == 1) Prev1.Visible = Prev2.Visible = false;
            else if (nr == 170) Next1.Visible = Next2.Visible = false;
            else Prev1.Visible = Prev2.Visible = Next1.Visible = Next2.Visible = true;

            if (nr == 1)
            {
               

                Next1.Text = Environment.NewLine + P2.Text; Next2.Text = Q2.Text;
                Title1.Text = P1.Text; Date1.Text = "|Perioada:" + Q1.Text;
                Countries1.Text = "|Italia";

                Descriere1.Text = "  A izbucnit pe 12 ian. 1848,cu o revoltă populară  la Palermo.Pe 27 ian.,a ȋnceput o revoluție la Neapole, iar regele a fost nevoit să accepte constituția. În Nord,doar Regatul Piemontului şi Sardiniei au rezistat presiunilor habsurgilor şi au scăpat de mişcări revoluționare pentru că a adoptat o constituție. Constituții au fost adoptate şi ȋn Neapole, statul Papal şi Toscana,iar Veneția si Milano şi-au proclamat independența de sub austrieci .Sub o puternică presiune populară,regele Piemontului a primit voluntari din toată Italia şi a atacat Lombardia,stăpânită de austrieci.";


                string html = "<html><head>";
                html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
                html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='600' height='300' frameborder='0' allowfullscreen></iframe>";
                html += "</body></html>";
             
            }
            else if (nr == 2)
            {
                Prev1.Text = Environment.NewLine + P1.Text; Prev2.Text = Q1.Text;
                Next1.Text = Environment.NewLine + P3.Text; Next2.Text = Q3.Text;
                Title1.Text = P2.Text; Date1.Text = "|Perioada:" + Q2.Text;
                Countries1.Text = "|Franța";

                Descriere1.Text = "  Influențată de mişcările revoluționare din Italia,revoluția ȋn Franța a izbucnit pe 22 februarie 1848 cu puternice manifestări  ȋn stradă .Acestea au fost reprimate şi pe 25 februarie a fost proclamată Republica. S-a reconstituit un Gurvern Provizoriu,a cărui primă reformă  a fost intrdocerea votului universal.Printre voturile proclamate şi aplicate a fost şi dreptul de muncă şi de aceea au fost ȋnfiintate ateliere naționale(o soluție pentru a oferi o sursă de câştig şomerilor.) Deoarece atelierele naționale produceau pe stoc, s-a hotărât desființarea lor pe 4 iunie 1848.Parizienii s-au răsculat din nou, iar pentru a pune capăt luptelor a fost ales ca preşedinte al Republicii Ludovic Napoleon Bonaparte.";
            }
            else if (nr == 3)
            {
                Prev1.Text = Environment.NewLine + P2.Text; Prev2.Text = Q2.Text;
                Next1.Text = Environment.NewLine + P4.Text; Next2.Text = Q4.Text;
                Title1.Text = P3.Text; Date1.Text = "|Perioada:" + Q3.Text;
                Countries1.Text = "|Germnaia";

                Descriere1.Text = "  Luptele revoluționare au izbucnit la Berlin pe 14 martie 1848 prin manifestări populare.Se cerea alungarea cancelarului Bismark,iar regele a făcut acest lucru sperând că revoluționarii se vor potoli. În mai 1848 s-a creat Parlamentul de la Frankfurt, primul parlament cu vot universal care avea ca scop unificarea Germaniei care a activat până ȋn 1849, când s-a autodizolvat. În martie 1849 a fost aleasă o nouă constituție, iar Parlamentul i-a oferit coroană regelui Prusiei, Frederic. Acesta a refuzat,spunând că “nu acceptă o coroană din gunoi! ”.";
            }
            else if (nr == 4)
            {
                Prev1.Text = Environment.NewLine + P3.Text; Prev2.Text = Q3.Text;
                Next1.Text = Environment.NewLine + P5.Text; Next2.Text = Q5.Text;
                Title1.Text = P4.Text; Date1.Text = "|Perioada:" + Q4.Text;
                Countries1.Text = "|Austro-Ungaria";

                Descriere1.Text = "  În zona austriacă a spațiului,revoluția a ȋnceput la Praga,Pesta si Viena. Prim-ministrul a fost demis,au fost promise reforme democratice şi o constitutie liberal.Cancelarul Meternik a fost demis,iar Dieta din Pozsony a votat o serie de legi care prevedeau desființarea iobagiei şi ȋmpropietărirea țăranilor.";
            }
            else if (nr == 5)
            {
                Prev1.Text = Environment.NewLine + P4.Text; Prev2.Text = Q4.Text;
                Next1.Text = Environment.NewLine + P6.Text; Next2.Text = Q6.Text;
                Title1.Text = P5.Text; Date1.Text = "|Perioada:" + Q5.Text;
                Countries1.Text = "|Ungaria";

                Descriere1.Text = "  Pentru a  atrage  de partea sa naționalitățile din Imperiu,ȋmpăratul a elaborat o constituție ȋn martie 1849 prin care se recunoştea existenta tuturor minoritățitlor din Imperiu. In aceste condiții, revoluționarilor maghiari le era teamă că românii se vor uni cu imperialii ȋmpotriva lor. La insistențele lui Nicolae Bălcescu au avut loc tratative ȋntre conducătorul revoluției maghiare şi Avram Iancu,ȋn urma cărora ungurii recunoşteau existența națiunii române şi drepturi egale cu ea ȋn Transilvania.Pe 1 august 1849,revoluția a fost ȋnfrântă de austrieci.";
            }
            else if (nr == 6)
            {
                Prev1.Text = Environment.NewLine + P5.Text; Prev2.Text = Q5.Text;
                Next1.Text = Environment.NewLine + P7.Text; Next2.Text = Q7.Text;
                Title1.Text = P6.Text; Date1.Text = "|Perioada:" + Q6.Text;
                Countries1.Text = "|România";
                Descriere1.Visible = false;Descriere2.Visible = true;
                Descriere2.Text = "  Revoluția Română de la 1848 a fost parte a revoluției europene din același an și expresie a procesului de afirmare a națiunii române și a conștiinței naționale. Un factor deosebit de important l-a constituit Revoluția Franceză din februarie 1848 care a avut repercusiuni asupra întregii Europe.Deoarece Franța era un stat național unitar, revoluția de aici a avut un predominant caracter social."+Environment.NewLine+ "  Revoluția Română de la 1848 s-a desfășurat în condițiile în care părți din teritoriul național se aflau în stăpânirea imperiilor vecine (Transilvania, Bucovina, Basarabia), în timp ce Moldova și Țara Românească erau constrânse să accepte protectoratul Rusiei țariste și suzeranitatea Imperiului Otoman.";
            }
            else if (nr == 7)
            {
                Prev1.Text = Environment.NewLine + P6.Text; Prev2.Text = Q6.Text;
                Next1.Text = Environment.NewLine + P8.Text; Next2.Text = Q8.Text;
                Title1.Text = P7.Text; Date1.Text = "|Perioada:" + Q7.Text;
                Countries1.Text = "|România";

                Descriere1.Text = " Unirea Principatelor Române a avut loc la jumătatea secolului al XIX-lea prin unirea statelor Moldova și Țara Românească sub numele Principatele Unite ale Moldovei și Țării Românești. Procesul unirii, bazat pe puternica apropiere culturală și economică între cele două țări, a cunoscut o etapă decisivă, care s-a dovedit a fi ireversibilă, prin alegerea colonelului moldovean Alexandru Ioan Cuza ca domnitor al ambelor principate, la 5 ianuarie 1859 în Moldova și la 24 ianuarie 1859 în Țara Românească.";
            }
            else if (nr == 8)
            {
                Prev1.Text = Environment.NewLine + P7.Text; Prev2.Text = Q7.Text;
                Next1.Text = Environment.NewLine + P9.Text; Next2.Text = Q9.Text;
                Title1.Text = P8.Text; Date1.Text = "|Perioada:" + Q8.Text;
                Countries1.Text = "|România";

                Descriere1.Text = "  Republica de la Ploiești este denumirea unei mișcări din data de 8 august 1870, considerată ca fiind ultima mare încercare de revoluție din spațiul românesc al secolului al XIX-lea sau ultimul val al revoluției de la 1848. În istoriografia românească de dinainte de 1989, această mișcare a fost considerată ca fiind antidinastică."+Environment.NewLine+ "  Această mișcare conspirativă nu este ceea ce a fost prezentat de presa vremii ori de literatura lui Caragiale, ca o acțiune subversivă a unui grup de cheflii, ci o mișcare organizată care a căutat înlăturarea monarhiei regelui Carol I al României. La această mișcare au participat aproximativ 3000 de oameni, printre ei s-a aflat și tânărul I.L.Caragiale care avea să descrie cu umor isprăvile sale din acea epocă. Evenimentul este o parte memorabilă din istoria Ploieștiului.";
            }
            else if (nr == 9)
            {
                Prev1.Text = Environment.NewLine + P8.Text; Prev2.Text = Q8.Text;
                Next1.Text = Environment.NewLine + P10.Text; Next2.Text = Q10.Text;
                Title1.Text = P9.Text; Date1.Text = "|Perioada:" + Q9.Text;
                Countries1.Text = "|Germania";

                Descriere1.Text = "  Germania s-a unificat ȋn etape,ȋn jurul Prusiei.In 1864,Prusia a infrant Danemarca si a lipit ducatul Schleswig.Victorioasă ȋn război cu Austria,Prusia a format Confederația Germană de Nord,pe care o domina şi din care Austria era exclusă. Prin Victoria asupra Franței,ȋn războiul 1870-1877 au fost anexate Alsacia şi Sorena,iar Wilhelm I a fost  ȋmpărat al Imperiului German.În procesul de unificare,un rol ȋnsemnat l-a avut cancelarul prusac Otto von Bismark.";
            }
            else if (nr == 10)
            {
                Prev1.Text = Environment.NewLine + P9.Text; Prev2.Text = Q9.Text;
                Next1.Text = Environment.NewLine + P11.Text; Next2.Text = Q11.Text;
                Title1.Text = P10.Text; Date1.Text = "|Perioada:" + Q10.Text;
                Countries1.Text = "|Italia";

                Descriere1.Text = "  Unificarea politică a Italiei s-a desfăşurat ȋn etape,ȋn jurul Regatului Piemontului si Sardiniei. Lombardia a fost eliberată de sub stăpânirea Austriei cu ajutorul Frantei(1859);Modena,Regatul Neapolelului, Parma şi Toscana s-au unificat cu Piemontul ȋn 1860.Victor Emanuel al II-lea a fost proclamat rege al Italiei(1861).În 1866 Veneția a fost eliberată de sub stăpânirea austriacă.În procesul de unificare a Italiei s-au remarcat regele Victor Emanuel al II-lea,Camillor Cavour,Giuseppe Garibaldi. ";
            }
            else if (nr == 11)
            {
                Prev1.Text = Environment.NewLine + P10.Text; Prev2.Text = Q10.Text;
                Next1.Text = Environment.NewLine + P12.Text; Next2.Text = Q12.Text;
                Title1.Text = P11.Text; Date1.Text = "|Perioada:" + Q11.Text;
                Countries1.Text = "|România";

                Descriere1.Text = "  Prima sondă de petrol din lume a fost construită ȋn România.Pompele de petrol care forau la 150 de metri adâncime au fost puse ȋn funcțune ȋn 1840 ȋn localitatea Lucacesti,județul Bacău.Prima rafinărie din lume a fost ridicată la marginea oraşului Ploieşti de fratii Mehedințeanu ȋn 1857.România a fost şi prima țară din lume cu o producție ȋnregistrată oficial ȋn statisticile internaționale.Revista “The Sience of Petroleum” certifică la 1938 că România avea ȋn anul 1857 o producție de 275 de tone de petrol. ";
            }
            else if (nr == 12)
            {
                Prev1.Text = Environment.NewLine + P11.Text; Prev2.Text = Q11.Text;
                Next1.Text = Environment.NewLine + P13.Text; Next2.Text = Q13.Text;
                Title1.Text = P12.Text; Date1.Text = "|Perioada:" + Q12.Text;
                Countries1.Text = "|România";

                Descriere1.Text = "  În anul 1857,Bucureştiul a devenit primul oraş din lume iluminat cu gaz lampant.Despre  acest eveniment. Jurnaliştii italieni de la Mettali Rari au scris “La 1 aprilie 1857,o mie de lămpi cu fitiluri au iluminat străzile Bucureştiului,capitala care a devenit primul oraş din lume iluminat cu petrol.”.S-a născut astfel o noua meserie-cea de lampagiu. Acesta avea datoria să aprindă şi să stinga lămpile, să curețe sticlele felinarelor şi să aibă grijă de acestea să funcționze ȋn mod corect.Această dată importantă marchează trecerea de la ulei de rapiță la petrol rafinat.";
            }
            else if (nr == 13)
            {
                Prev1.Text = Environment.NewLine + P12.Text; Prev2.Text = Q12.Text;
                Next1.Text = Environment.NewLine + P14.Text; Next2.Text = Q14.Text;
                Title1.Text = P13.Text; Date1.Text = "|Perioada:" + Q13.Text;
                Countries1.Text = "|S.U.A.";

                Descriere1.Text = "  Războiul Civil American, deseori denumit Războiul de secesiune (în engleză War of Secession), Războiul dintre state (în engleză War Between the States), sau Războiul dintre Nord și Sud a fost un conflict politic și militar de patru ani (1861–1865) dintre Uniunea sau Statele din Nord ale Statelor Unite ale Americii (care și-a păstrat neschimbată denumirea sa oficială adoptată cu ocazia scrierii Constituției SUA, Statele Unite ale Americii) și Statele din Sud ale acesteia, și anume șapte, mai apoi unsprezece state, care au părăsit pe rând Uniunea în 1860–1861, alcătuind entitatea statală federală denumită Statele Confederate ale Americii (în engleză Confederate States of America).";
            }
            else if (nr == 14)
            {
                Prev1.Text = Environment.NewLine + P13.Text; Prev2.Text = Q13.Text;
                Next1.Text = Environment.NewLine + P15.Text; Next2.Text = Q15.Text;
                Title1.Text = P14.Text; Date1.Text = "|Perioada:" + Q14.Text;
                Countries1.Text = "|S.U.A. si Rusia";

                Descriere1.Text = "  Achiziția teritoriului Alaska reprezintă cumpărarea teritoriului Alaska de către Statele Unite ale Americii de la Imperiul Rus în 1867 pentru 7,2 milioane de dolari. Achiziția, efectuată la inițiativa Secretarului de Stat american William H. Seward, s-a concretizat prin anexarea de către SUA a unui teritoriu cu o suprafață de 1.518.800 km². Inițial organizat sub numele de departmentul Alaska, zona a devenit apoi districtul Alaska și teritoriul Alaska înainte de a fi admis ca stat în Statele Unite ale Americii în 1959. Ceremonia de transfer a avut loc la Sitka la 18 octombrie 1867. Esclava Statelor Unite le-a adus un plus economic, datorita resurselor de petrol.";
            }
            else if (nr == 15)
            {
                Prev1.Text = Environment.NewLine + P14.Text; Prev2.Text = Q14.Text;
                Next1.Text = Environment.NewLine + P16.Text; Next2.Text = Q16.Text;
                Title1.Text = P15.Text; Date1.Text = "|Perioada:" + Q15.Text;
                Countries1.Text = "|Imperiul German";

                Descriere1.Text = "  Congresul de la Berlin (13 iunie – 13 iulie 1878, Berlin, Imperiul German) a fost o întâlnire a principalelor puteri europene ale vremii și reprezentanți ai Imperiului Otoman. Congresul s-a desfășurat în urma conflictului dintre Imperiul Țarist și cel Otoman (1877-1878) și a avut drept scop principal reorganizarea Țărilor Balcanice. Cancelarul Otto von Bismarck a fost cel care a încercat să echilibreze balanța între interesele divergente avute în zonă de Imperiul Britanic, Imperiul Austro-Ungar și Imperiul Rus.";
            }
            else if (nr == 16)
            {
                Prev1.Text = Environment.NewLine + P15.Text; Prev2.Text = Q15.Text;
                Next1.Text = Environment.NewLine + P17.Text; Next2.Text = Q17.Text;
                Title1.Text = P16.Text; Date1.Text = "|Perioada:" + Q16.Text;
                Countries1.Text = "|Germania, Austro-Ungaria și Italia";

                Descriere1.Text = "  Tripla Alianță sau Puterile Centrale, cum mai este cunoscută, a fost încheiată între Germania, Austro-Ungaria și Italia, astfel luând naștere una dintre cele mai faimoase alianțe din întreaga istorie."+Environment.NewLine+ "  Alianța a fost încheiată la inițiativa cancelarului Otto von Bismarck (“cancelarul de fier” al Germaniei), fiind, inițial, una de ordin defensiv, adică doar în cazul în care Franța ar fi atacat pe unul din membrii acesteia, ceilalți ar fi fost nevoiți să intervină și să declare război Franței. La baza acestei alianțe stă tratatul secret negociat de von Bismarck cu Austro-Ungaria în 1879, care sporea puterea în zonă a celor două state. Austro-Ungaria câștiga un aliat puternic în lupta de rezistență dusă împotriva expansionismului rusesc, iar Germania devenea și mai puternică în cadrul eventualelor conflicte cu Franța, refăcută după încheierea războiului din 1870-1871.";
            }
            else if (nr == 17)
            {
                Prev1.Text = Environment.NewLine + P16.Text; Prev2.Text = Q16.Text;
                Next1.Text = Environment.NewLine + P18.Text; Next2.Text = Q18.Text;
                Title1.Text = P17.Text; Date1.Text = "|Perioada:" + Q17.Text;
                Countries1.Text = "|România";

                Descriere1.Text = "  Printre multe alte reușite ale Romaniei se distinge și evenimentul din 12 noiembrie 1884 când, în Timișoara, au fost aprinse 731 de lămpi electrice, o premieră în Europa, lucru care a transformat orașul de pe Bega în primul oraș iluminat electric din Europa.În acea zi, lămpile incandescente cu filament din cărbune au iluminat un traseu stradal cu o lungime de 59 de km, o performanţă realizată în mai puţin de doi ani de către societatea Anglo-Austriacă „Bruch Electrical Company Ltd.”, cu sediul la Viena. Pe timp de noapte, până şi cele mai înguste străduţe au devenit puncte luminoase pe harta oraşului, datorită lămpilor incandescente cu filamentul din cărbune, sporind protecţia dar şi confortul celor care se plimbau prin urbea de pe Bega la ore târzii.";
            }
            else if (nr == 18)
            {
                Prev1.Text = Environment.NewLine + P17.Text; Prev2.Text = Q17.Text;
                Next1.Text = Environment.NewLine + P19.Text; Next2.Text = Q19.Text;
                Title1.Text = P18.Text; Date1.Text = "|Perioada:" + Q18.Text;
                Countries1.Text = "|Victor Babes";

                Descriere1.Text = "  Pentru studenții de biologie , acesta este sigur un lucru interesant : Victor Babeş a scris primul tratat de bacteorologie din lume,ȋn colaborare cu Victor Andre Cornil ȋn 1885. El a făcut contribuții semnificative pentru studiul leprei,a tuberculozei şi rabiei, pentru care a introdus un vaccin. El este considerat al doilea biolog al rabiei din lume, dupa Pasteur, şi considerat părintele seroterapiei.";
            }
            else if (nr == 19)
            {
                Prev1.Text = Environment.NewLine + P18.Text; Prev2.Text = Q18.Text;
                Next1.Text = Environment.NewLine + P20.Text; Next2.Text = Q20.Text;
                Title1.Text = P19.Text; Date1.Text = "|Perioada:" + Q19.Text;
                Countries1.Text = "|Franța și Rusia";

                Descriere1.Text = "  Alianța franco-rusă sau Apropierea ruso-franceză a fost o alianță formată conform înțelegerilor bilaterale din 1891–1893 și care a durat până în 1917. Consolidarea Imperiului German, crearea Triplei Alianțe din 1882 și exacerbarea contradicțiilor franco-germane și ruso-germane din deceniul al nouălea al secolului al XIX-lea au dus la o politică externă comună și interesele militare strategice reciproce între Franța și Rusia. Dezvoltarea legăturilor financiare dintre cele două țări a creat premisele economice pentru Alianța Russo-Franceză.";
            }
            else if (nr == 20)
            {
                Prev1.Text = Environment.NewLine + P19.Text; Prev2.Text = Q19.Text;
                Next1.Text = Environment.NewLine + P21.Text; Next2.Text = Q21.Text;
                Title1.Text = P20.Text; Date1.Text = "|Perioada:" + Q20.Text;
                Countries1.Text = "|S.U.A. si Spania";

                Descriere1.Text = "  Războiul Spaniolo-Amercian a început după ce Statele Unite au intervenit diplomatic pe în favoarea cubanezilor,cerând Spaneiei rezolvarea pașnică a problemei independenței Cubei față de fosta mare putere colonială a ambelor Americi. Refuzul Spaniei, dar si dorinta Uniunii de a trece în posesia unor teritoriile spaniole,de pe continentul american. Războiul s-a terminat după ce flota SUA a invins Spania în Filipine și în Cuba. La doar 109 zile de la izbucnirea războiului a fost semnat tratatul de la Paris, care a pus capăt conflictului. SUA au dobandit fostele colonii spaniole Porto Rico, Filipine și Guam,iar Sub jurisdicția Guvernului Militar al Statelor Unite, SUA a ocupat Cuba până în 1902.";
            }
            else if (nr == 21)
            {
                Prev1.Text = Environment.NewLine + P20.Text; Prev2.Text = Q20.Text;
                Next1.Text = Environment.NewLine + P22.Text; Next2.Text = Q22.Text;
                Title1.Text = P21.Text; Date1.Text = "|Perioada:" + Q21.Text;
                Countries1.Text = "|S.U.A. si America Centrala";

                Descriere1.Text = "  Războaiele bananierelor au reprezentat o serie de conflicte ȋn care SUA au invadat-o țări din America Centrală şi Latină,printre care se numără Cuba,Nicaragua,Haiti, Republica Dominicană,cu scopul de a pune mononopol pe economiile acestora. Compania “United Fruit Company”  a dominat piețele acestora , făcând bani grei din cultivarea,transportarea şi vânzarea bananelor şi a trestiei de zahăr . Atrocitatile asupra Americii de Sud s-au terminat tarziu, iar efectele acestora sunt vizibile si astazi.";
            }
            else if (nr == 22)
            {
                Prev1.Text = Environment.NewLine + P21.Text; Prev2.Text = Q21.Text;
                Next1.Text = Environment.NewLine + P23.Text; Next2.Text = Q23.Text;
                Title1.Text = P22.Text; Date1.Text = "|Perioada:" + Q22.Text;
                Countries1.Text = "|Venezuela";

                Descriere1.Text = "  Criza venezueleană din 1902–1903 a fost o blocadă navală impusă Venezuelei de Regatul Unit, Germania și Italia din decembrie 1902 până în februarie 1903, după ce președintele Cipriano Castro a refuzat să plătească datoria externă și paguble suferie de citățenii europenei în ultimele războaie civile din țară. Castro a crezut că, în conformitate cu Doctrina Monroe americană, SUA avea să intervină ca să prevină o acțiune militară europeană. Cu toate acestea, în acele momente, președintele SUA Theodore Roosevelt și Departamentul de Stat au considerat că doctrina se aplică mai degrabă în cazul ocupării unor teritorii americane de către europenei, ceea ce nu părea că era cazul. Cum puterile europene oferiseră promisiuni că nu vor trece la ocuparea de teritorii, SUA s-a declarat în mod oficial neutre și au permis insituirea blocadei fără vreo obiecție.";
            }
            else if (nr == 23)
            {
                Prev1.Text = Environment.NewLine + P22.Text; Prev2.Text = Q22.Text;
                Next1.Text = Environment.NewLine + P24.Text; Next2.Text = Q24.Text;
                Title1.Text = P23.Text; Date1.Text = "|Perioada:" + Q23.Text;
                Countries1.Text = "|Rusia si Japonia";

                Descriere1.Text = "  Războiul ruso-japonez (1904–1905) a fost un conflict generat de ambițiile imperialiste ale Imperiului Rus și ale Imperiului Japonez în privința Manciuriei și Coreei. Principalele teatre de război au fost Port Arthur și Peninsula Liaodong, împreună cu calea ferată care lega Port Arthur de Harbin. Rușii căutau de multă vreme un port ale cărui ape să nu înghețe în timpul iernii. Japonezii au intrat în război datorită nevoii strategice de stăvilire a expansiunii rusești către Coreea.";
            }
            else if (nr == 24)
            {
                Prev1.Text = Environment.NewLine + P23.Text; Prev2.Text = Q23.Text;
                Next1.Text = Environment.NewLine + P25.Text; Next2.Text = Q25.Text;
                Title1.Text = P24.Text; Date1.Text = "|Perioada:" + Q24.Text;
                Countries1.Text = "|Regatul Unit si Franta";

                Descriere1.Text = "  Antanta Cordială reprezintă o serie de acorduri semnate, la 8 aprilie 1904, între Regatul Unit și Republica Franceză. Dincolo de problemele imediate ridicate de expansiunea colonială tratate de acest acord, semnarea Antantei Cordiale a marcat sfârșitul unui mileniu de conflicte intermitente între cele două țări și statele predecesoare ale lor, și începutul unei coexistențe pașnice care continuă și în prezent. Antanta Cordială, împreună cu alianța anglo-rusă și cu alianța ruso-franceză, a alcătuit sistemul de alianțe denumit Tripla Înțelegere între Regatul Unit, Franța și Rusia, alianță ce a constituit tabăra învingătoare în Primul Război Mondial.";
            }
            else if (nr == 25)
            {
                Prev1.Text = Environment.NewLine + P24.Text; Prev2.Text = Q24.Text;
                Next1.Text = Environment.NewLine + P26.Text; Next2.Text = Q26.Text;
                Title1.Text = P25.Text; Date1.Text = "|Perioada:" + Q25.Text;
                Countries1.Text = "|Rusia";

                Descriere1.Visible = false;Descriere2.Visible = true;
                Descriere2.Font = new Font("Courier New", 12);
                Descriere2.Text = "  Revoluția Rusă din 1905 A constat într-un val de acțiuni de protest care au avut loc pe tot parcursul anului. Deși protagoniștii acestor acțiuni au împărtășit multe dintre cerințe, în realitate nu a existat nicio coordonare între ele. De multe ori au fost acte izolate care au avut loc în toată Rusia.La sfârșitul secolului al XIX-lea, structura socială și economică a Rusiei era aproape feudală, chiar dacă acel sistem fusese abolit oficial în 1861. Realitatea, mai ales în mediul rural, este că nobilii erau încă proprietarii pământului, în timp ce țăranii trăiau în sărăcie." + Environment.NewLine + "  Un marș pașnic al muncitorilor din ianuarie 1905 a marcat începutul revoluției. Soldații țarului au tras fără discriminare asupra protestatarilor. În curând, protestele s-au răspândit în toată Rusia. La sfârșitul anului, țarul a trebuit să recunoască anumite drepturi de muncă și politice, deși erau doar reforme cosmetice.Rusia, spre deosebire de ceea ce se întâmplase în restul Europei, menținuse un sistem politic ancorat în absolutism. Din punct de vedere economic, abia în 1861 feudalismul a fost abolit, deși în zonele rurale schimbarea a fost minimă." + Environment.NewLine + "  Însăși structura societății a provocat mari inegalități în țară. Clasele sociale erau foarte ierarhizate, cu aristocrația în vârf și muncitorii și țăranii în partea de jos. La mijloc, o burghezie liberală care nu reușise să se dezvolte la fel de mult ca în restul Europei.Rusia începuse să se industrializeze foarte târziu. Marea majoritate a industriei create a fost localizată în orașe și a fost în mâinile străinilor sau a statului."+Environment.NewLine+ "  Opinia generală a tuturor cercetătorilor este că marea consecință a Revoluției din 1905 a fost că a servit ca repetiție generală pentru cea care avea să aibă loc în 1917.";
            }
            else if (nr == 26)
            {
                Prev1.Text = Environment.NewLine + P25.Text; Prev2.Text = Q25.Text;
                Next1.Text = Environment.NewLine + P27.Text; Next2.Text = Q27.Text;
                Title1.Text = P26.Text; Date1.Text = "|Perioada:" + Q26.Text;
                Countries1.Text = "|International";

                Descriere1.Text = "  Prima criză marocană, cunoscută și cu numele Criza Tangerului, a fost o criză internațională din perioada martie 1905 – mai 1906 generată de neînțelegerile cu privire la controlul asupra Marocului. Criza a dus la înrăutățirea relațiilor Germaniei atât cu Franța cât și cu Regatul Unit și a dus la întărirea relațiilor franco-britanice în cadrul Antantei.";
            }
            else if (nr == 27)
            {
                Prev1.Text = Environment.NewLine + P26.Text; Prev2.Text = Q26.Text;
                Next1.Text = Environment.NewLine + P28.Text; Next2.Text = Q28.Text;
                Title1.Text = P27.Text; Date1.Text = "|Perioada:" + Q27.Text;
                Countries1.Text = "|România";

                Descriere1.Text = "  Răscoala din România a durat din februarie până în aprilie. Țăranii s-au răsculat deoarece pământurile nu erau distribuite în mod egal și se aflau în mâinile câtorva mari proprietari. Mii de persoane au fost ucise când armata română a reprimat revolta. Evenimentele au inspirat mulți scriitori și artiști români. Principala cauză s a datorat incapacității instituțiilor statului de a supraveghea respectarea legii în domeniul contractelor agricole ce aveau rolul de a intermedia înțelegerile dintre proprietari și țărani,spre exemplu în județul Iași prefectul, Constantin Stere, se întelege cu arendașii și muncitorii agricoli pentru scăderea/revenirea la un preț de 35-40 lei pe hectar dezamorsând conflictual.In literature,au fost subiectul unuia dintre cele mai bune romane interbelice, “Răscoala”, de Liviu Rebreanu, publicat în 1932. Alt roman care prezintă viața țăranului român înainte și în timpul revoluției este “Ciulinii Bărăganului” de Panait Istrati.";
            }
            else if (nr == 28)
            {
                Prev1.Text = Environment.NewLine + P27.Text; Prev2.Text = Q27.Text;
                Next1.Text = Environment.NewLine + P29.Text; Next2.Text = Q29.Text;
                Title1.Text = P28.Text; Date1.Text = "|Perioada:" + Q28.Text;
                Countries1.Text = "|Regatul Unit și Rusia ";

                Descriere1.Text = "  Convenția anglo-rusă din 1907 sau Convenția dintre Regatul Unit și Rusia cu privire la Persia, Afganistan și Tibet, a fost semnat pe 31 august 1907 în St. Petersburg, Rusia. Convenția a pus capăt rivalității îndelungate al celor două puteri din Asia Centrală și a permis să-i surclaseze pe germani, care amenințau să lege Berlinul cu Bagdadul cu o nouă cale ferată, fapt care ar fi atras în mod definitiv Imperiul Otoman în sfera de influență a Germaniei.";
            }
            else if (nr == 29)
            {
                Prev1.Text = Environment.NewLine + P28.Text; Prev2.Text = Q28.Text;
                Next1.Text = Environment.NewLine + P30.Text; Next2.Text = Q30.Text;
                Title1.Text = P29.Text; Date1.Text = "|Perioada:" + Q29.Text;
                Countries1.Text = "|Austro-Ungaria";

                Descriere1.Text = "  Criza bosniacă din 1908-1909, cunoscută de asemenea cu numele de Criza anexării a izbucnit în opinia publicului când Austro-Ungaria a declarat pe 6 octombrie 1908 anexarea Bosniei și Herțegovinei. Rusia, Imperiul Otoman, Britania, Italia, Serbia, Muntenegru, Germania și Franța au avut un interes în aceste evenimente. În aprilie 1909, Tratatul de la Berlin fost modificat pentru a accepta noul status quo-ul punând capăt crizei. Criza a deteriorat permanent relațiile dintre Austro-Ungaria, pe de-o parte și Rusia și Serbia de cealaltă parte. Anexarea și reacțiile anexării au fost cauze care au contribuit la izbucnirea Primului Război Mondial.";
            }
            else if (nr == 30)
            {
                Prev1.Text = Environment.NewLine + P29.Text; Prev2.Text = Q29.Text;
                Next1.Text = Environment.NewLine + P31.Text; Next2.Text = Q31.Text;
                Title1.Text = P30.Text; Date1.Text = "|Perioada:" + Q30.Text;
                Countries1.Text = "|Henri Coandă";

                Descriere1.Text = "  În zilele de azi, un zbor cu avionul este un lucru obişnuit,dar ştiați ca primul jet propulsor,numit Coana 1910, a fost construit şi proiectat de românul Henri Coanda? În 1910, inventatorul a creat un sistem de propulsie folosit pentru avioanele cu reactive. Aeroportul din Bucureşti ȋi poartă numele.";
            }
            else if (nr == 31)
            {
                Prev1.Text = Environment.NewLine + P30.Text; Prev2.Text = Q30.Text;
                Next1.Text = Environment.NewLine + P32.Text; Next2.Text = Q32.Text;
                Title1.Text = P31.Text; Date1.Text = "|Perioada:" + Q31.Text;
                Countries1.Text = "|Internțional";

                Descriere1.Text = "  Criza Agadir, Incidentul Agadir, A doua criză marocană ori , a fost o criză internațională scurtă declanșată de desfășurarea unor forțe importante franceze în adâncimea teritoriului Marocului în aprilie 1911. Germania nu avea nicio obiecțiune la expansiunea franceză în zonă, dar dorea să primească compensații teritoriale pentru aceasta. Berlin a trimis în zonă o canonieră, iar pe plan intern a permis agitații naționaliste. Negocierile dintre Berlin și Paris au dus la rezolvarea crizei: Franța a preluat controlul asupra Marocului, care a fost transformat în protectorat, iar Germania a primit concesiuni teritoriale în Congo Francez, în vreme ce Spania a fost satisfăcută de modificarea graniței marocane. Guvernul britanic, în schimb, a fost alarmat de abordarea agresivă a guvernului german a neînțelegerilor cu francezii.";
            }
            else if (nr == 32)
            {
                Prev1.Text = Environment.NewLine + P31.Text; Prev2.Text = Q31.Text;
                Next1.Text = Environment.NewLine + P33.Text; Next2.Text = Q33.Text;
                Title1.Text = P32.Text; Date1.Text = "|Perioada:" + Q32.Text;
                Countries1.Text = "|Internțional";
                Descriere1.Visible = false;Descriere2.Visible = true;
                Descriere2.Text = "  RMS Titanic a fost cel mai mare pachebot din lume când a plecat în călătoria sa inaugurală din Southampton, Anglia cu destinația New York, pe 10 aprilie 1912. La patru zile de la plecare, la ora 23:40 în data de 14 aprilie 1912, s-a ciocnit de un aisberg provocând o tăietură în carenă pe o lungime de 90 m.In urma naufragiului,1514 oameni au murit,iar 710 au reusit sa supravietuiasca cu ajutorul a 20 de barci de salvare. Conștienți că bărcile nu sunt suficiente pentru toți, ofițerii încep să pună în bărci doar femeile și copiii."+Environment.NewLine+ "  Povestea scufundării Titanicului este o poveste de lașitate și eroism: un băiat ce a intrat într-o barcă de salvare deghizat în femeie, mai mulți bărbați ce s-au furișat în barcă și au stat ascunși sub fustele femeilor.  Însă orchestra care a cântat până la sfârșit,iar poștașii care au murit înecați în vapor încercând să salveze corespondența și multe alte povești de eroism. La ora 2:20, 15 aprilie 1912 Titanicul a dispărut complet în ocean. Cele două bucăți ale sale se află la o adâncime de 4 km pe fundul mării și se află la o distanță de aproape 2 km una față de alta.";
            }
            else if (nr == 33)
            {
                Prev1.Text = Environment.NewLine + P32.Text; Prev2.Text = Q32.Text;
                Next1.Text = Environment.NewLine + P34.Text; Next2.Text = Q34.Text;
                Title1.Text = P33.Text; Date1.Text = "|Perioada:" + Q33.Text;
                Countries1.Text = "|Italia si Turcia";

                Descriere1.Text = "  Războiul Italo-Turc sau Războiul turco-italian a fost purtat între Imperiul Otoman și Italia între 29 septembrie 1911 - 18 octombrie 1912.Ca urmare a acestui conflict, Italia a primit provinciile otomane Tripolitania, Fezzan, și Cirenaica. Aceste provincii au format nou colonie italiană Libia.";
            }
            else if (nr == 34)
            {
                Prev1.Text = Environment.NewLine + P33.Text; Prev2.Text = Q33.Text;
                Next1.Text = Environment.NewLine + P35.Text; Next2.Text = Q35.Text;
                Title1.Text = P34.Text; Date1.Text = "|Perioada:" + Q34.Text;
                Countries1.Text = "|Țările Balcanice";

                Descriere1.Text = "  În timpul războaielor balcanice, Liga Balcanică (Serbia, Muntenegru, Grecia, și Bulgaria) întâi au cucerit teritoriile otomane Macedonia și cea mai mare parte a Traciei, iar apoi au intrat în conflict între ele asupra împărțirii acestor teritorii." + Environment.NewLine + "  Tensiunile dintre statele balcanice legate de aspirațiile lor rivale în Rumelia, Rumelia Orientală, Tracia și Macedonia s-au mai domolit după intervenția Marilor Puteri la jumătatea secolului al XIX-lea, care au intenționat atât asigurarea unei protecții sporite majorității creștine și a păstrării status quo-ului. Problema viabilității stăpânirii otomane s-a pus însă din nou după revoluția Junilor Turci din iulie 1908, care l-a obligat pe sultan să repromulge constituția suspendată.";
            }
            else if (nr == 35)
            {
                Prev1.Text = Environment.NewLine + P34.Text; Prev2.Text = Q34.Text;
                Next1.Text = Environment.NewLine + P36.Text; Next2.Text = Q36.Text;
                Title1.Text = P35.Text; Date1.Text = "|Perioada:" + Q35.Text;
                Countries1.Text = "|Țările Balcanice";
                Descriere1.Visible = false; Descriere2.Visible = true;
                Descriere2.Text = "  Cel de-al doilea război balcanic a avut loc în 1913 între Bulgaria pe de o parte și în principal Grecia și Serbia pe cealaltă. Temându-se de apariția unei Bulgarii mari și puternice la frontierele ei sudice și la posibilele revendicări teritoriale față de Dobrogea de Nord obținută în 1878, România a intervenit și ea militar împotriva Bulgariei. Totodată Imperiul Otoman s-a folosit de prilej pentru a redobândi unele teritorii pierdute. Când trupele românești au invadat nordul Bulgariei și se apropiau de capitala Sofia, Bulgaria a cerut armistițiu. Prin tratatul de la București, Bulgaria a fost forțată să renunțe la o bună parte din teritoriile obținute după primul război balcanic către Serbia, Grecia și Imperiul Otoman și să facă concesii României în nord în schimbul păstrării restului teritoriului obținut anterior. Rezultatul a făcut din aliatul Rusiei, Serbia, o putere regională importantă, alarmând astfel Austro-Ungaria și fiind astfel o cauză importantă de izbucnire a Primului Război Mondial." + Environment.NewLine + "  În conformitate cu prevederile tratatului de pace de la București, Bulgaria ceda României porțiunea cunoscută ca Dobrogea de Sud (Cadrilaterul), de la vest de Tutrakan (Turtucaia) până la malul vestic al Mării Negre, la sud de Kranevo (Ecrene). Cadrilaterul avea o suprafață de aproximativ 6.960 km², o populație de circa 286.000 de locuitori și includea fortăreața Silistra și orașele Turtucaia (port la Dunăre) și Balcic (port la Marea Neagră)."; ;
            }
            else if (nr == 36)
            {
                Prev1.Text = Environment.NewLine + P35.Text; Prev2.Text = Q35.Text;
                Next1.Text = Environment.NewLine + P37.Text; Next2.Text = Q37.Text;
                Title1.Text = P36.Text; Date1.Text = "|Perioada:" + Q36.Text;
                Countries1.Text = "|Țările Balcanice";

                Descriere1.Text = "  Tratatul de la Constantinopol, încheiat între Imperiul Otoman și Regatul Bulgariei, a marcat sfârșitul Războaielor Balcanice (1912-1913). Patru state balcanice (Bulgaria, Serbia, Grecia și Muntenegru) au învins Imperiul Otoman în primul război. În cel de-al doilea război balcanic, Bulgaria a luptat împotriva tuturor aliaților săi inițiali din primul război și s-a confruntat, de asemenea, cu un atac surpriză din partea României, la nord. Conflictele s-au încheiat catastrofal pentru Imperiul Otoman, care a pierdut cea mai mare parte a teritoriului său din Europa. Cu toate acestea, Imperiul Otoman și Bulgaria se aliază ulterior în cadrul Puterilor Centrale în Primul Război Mondial.";
            }
            else if (nr == 37)
            {
                Prev1.Text = Environment.NewLine + P36.Text; Prev2.Text = Q36.Text;
                Next1.Text = Environment.NewLine + P38.Text; Next2.Text = Q38.Text;
                Title1.Text = P37.Text; Date1.Text = "|Perioada:" + Q37.Text;

                Countries1.Text = "|Serbia";

                Descriere1.Text = "  Cauza directă a Primului Război Mondial a fost ȋncercarea reuşită de a-l asasina pearhiducele Franz Ferdinand (succesorul la tronul Austro-Ungariei) la data de 28 iunie 1914. Imediat,două tabere beligerante au stat una ȋmpotriva celeilalte :Antanta(formată inițial din Franța,Marea Britanie şi Rusia, ajutate din 1917 de SUA) şi Puterile Centrale(Germania şi Austro-Ungaria). Spre deosebire de alta lupte, Primul Război Mondial a fost un război de uzură, purtat ȋn tranşee,cu mici dobândiri teritoriale pe frontul de Vest,ȋn timp ce frontul de Est a fost mult mai dinamic.Nu doar atentatul a provocat un război de aşa proporții,dar şi relațiile reci,duşmănoase,ale popoarelor,relații dobândite ȋn mulți ani de conflicte.";
            }
            else if (nr == 38)
            {
                Prev1.Text = Environment.NewLine + P37.Text; Prev2.Text = Q37.Text;
                Next1.Text = Environment.NewLine + P39.Text; Next2.Text = Q39.Text;
                Title1.Text = P38.Text; Date1.Text = "|Perioada:" + Q38.Text;
                Countries1.Text = "|Austro-Ungaria si Serbia";

                Descriere1.Text = "  Arhiducele Franz Ferdinand,succesorul la tronul Austro-Ungariei, a fost omorât ȋn urma unui atentat de sârbul Gavrilo Princip.Imperiul a ripostat ȋmpotriva Serbiei prin intervenție militară,o decizie pe care Ungaria a luat-o,deşi guvernul nu a vrut să sprijine inițial un asemenea răspuns.Desfăşurarea Primului Război Mondial nu numai că a adus rezultate mixte pe front,ci şi un eşec pentru Austro-Ungaria.";
            }
            else if (nr == 39)
            {
                Next2.Visible = false;
                Prev1.Text = Environment.NewLine + P38.Text; Prev2.Text = Q38.Text;
                Next1.Text =  P40.Text; 
                Title1.Text = P39.Text; Date1.Text = "|Perioada:" + Q39.Text;
                Countries1.Text = "|Germania";

                Descriere1.Text = "   Uciderea succesorului la tronul Austro-Ungariei şi a soției acestuia de către un sârb-bosniac ȋn Sarajevo, aruncă ȋntreaga Europă ȋntr-o criză diplomatică .Când Austro-Ungaria a vrut să pedepsească Serbia cu ajutorul Imperiului German,obligațiile de alianță reciprocă intră ȋn vigoare. După câteva săptămâni de negocieri,tratate şi ,ȋn final,mobilizări,trupe germane marşăluiesc spre statele neutre Luxemburg şi Belgia. Primul Război Mondial ȋncepe.";
            }
            else if (nr == 40)
            {
                Prev1.Text = Environment.NewLine + P39.Text; Prev2.Text = Q39.Text;
                Next1.Text = Environment.NewLine + P41.Text; Next2.Text = Q41.Text;
                Title1.Text = P40.Text; Date1.Text = "|Perioada:1914" ;
                Countries1.Text = "|Internațional";

                Descriere1.Text = "Frontul de Vest"+Environment.NewLine+ "   Germania intenționează să poarte un război fulger asupra Franței,iar mai apoi asupra Rusiei. Înaintarea germană a fost oprită de francezi pe râul Marna,iar războiul s-a transformat ȋntr-unul de uzură,ce antrena un număr mare de oameni şi resurse."+Environment.NewLine+Environment.NewLine+"Frontul de Sud"+Environment.NewLine+ "   Serbia a fost infrântă ȋn 3 săptămâni şi ocupată de armatele germano-austro-ungara. Sârbii şi-au continuat lupta prin partizani,când frontul de Sud a fost activat. Italia şi-a proclamat neutralitea, deşi făcea parte din Tripla Alianță.";
            }
            else if (nr == 41)
            {
                Prev2.Visible = false;
                Prev1.Text = P40.Text; 
                Next1.Text = Environment.NewLine + P42.Text; Next2.Text = Q42.Text;
                Title1.Text = P41.Text; Date1.Text = "|Perioada:" + Q41.Text;
                Countries1.Text = "|Polonia";

                Descriere1.Text = "  În timpul Primului Război Mondial.Polonezii s-au aflat ȋntr-o situație dificilă.Fiecare dintre forțele ocupante- Rusia,Austria şi Prusia- a ȋncercat să-i folosească ca să lupte de partea lor.Polonezii au făcut tot ce le-a stat ȋn puțintă ca  armata Poloniei să nu fie folosită ȋn acest scop.Ei sperau crearea unei Polonii independente cu ajutorul statelor câstigătoare.Infrângerea Puterilor Centrale şi izbucnirea revoluției Ruse au deschis drumul polonezilor spre un stat liber.";
            }
            else if (nr == 42)
            {
                Next2.Visible = false;
                Prev1.Text = Environment.NewLine + P41.Text; Prev2.Text = Q41.Text;
                Next1.Text =  P43.Text; 
                Title1.Text = P42.Text; Date1.Text = "|Perioada:" + Q42.Text;
                Countries1.Text = "|Regatul Unit,Franța,Imperiul German";
                
                Descriere1.Text = "  În seara de Crăciun a anului 1914,ȋn plin război mondial,pe frontul de vest,soldații britanici au auzit trupele germane cântând colinde ȋn tranşeele opuse.La scurt timp,au cântat şi ei,iar din fiecare tabără a ȋnceput să se strige “Crăciun Fericit!” făcând,ȋn glumă,invitație de a sărbători Crăciunul ȋmpreună. Ce a urmat bate orice film hollywoodian:soldații care mai devreme se ȋmpuşcau făceau schimb de ciocolată şi țigări,ba chiar ȋntre cele două tabere s-a ȋncins un meci de fotbal.În unele porțiuni,Armistițiul de Crăciun a durat până de anul nou.Pentru ȋncheierea armistițiului englezii au tras trei focuri de armă ȋn aer şi  au ridicat un steag pe care srica “Crăciun fericit!”.Germanii au răspuns ridicând o pânză pe care scria “Multumim!”,iar căpitanul a tras două focuri ȋn plan vertical.Era semnul că războiul reȋncepea.";
            }
            else if (nr == 43)
            {
                Prev1.Text = Environment.NewLine + P42.Text; Prev2.Text = Q42.Text;
                Next1.Text = Environment.NewLine + P44.Text; Next2.Text = Q44.Text;
                Title1.Text = P43.Text; Date1.Text = "|Perioda:1915" ;
               
                Countries1.Text = "|Internațional";
                Descriere1.Visible = false; Descriere2.Visible = true;
                Descriere2.Font = new Font("Courier New", 12);
                Descriere2.Text = "Frontul de Vest"+Environment.NewLine+ "   Războiul de mşcare s-a transformat ȋntr-unul de uzură,ȋn care armatele s-au ȋngropat in tranşee. Frontul este constituit de 2 linii paralele,separate de un spațiu “al nimănui”.Ambele părți au adus tot felul de inovații,precum mortire,grenade de mână,aruncătorare de mine,lansatoare de flăcări.Pentru protejarea soldaților se vor folosi cască de fier,mască de gaze ."+Environment.NewLine+ Environment.NewLine+"Frontul de Sud"+Environment.NewLine+ "   Intrarea Italiei ȋn război de partea Antantei a facut ca situația sa fie favorabilă pentru Antantamdesu,ȋn acelaşi an,Bulgaria intrase ȋn război de partea Puterilor Centrale. Alianța din urmă au reusit să obțină victorii şi să scoată țara din război."+Environment.NewLine+Environment.NewLine+ "Frontul de Est"+Environment.NewLine+ "  În anul 1915,Germania şi-a indreptat ȋntregul efort asupra unei Rusii nepregătite de un astfel de război, care s-a văzut nevoită sa bată ȋn retragere. Ruşii erau echipați necorespunzător,unii soldati neavând armament sau haine.Pentru a-i ajuta pe ruşi,aliații au ȋncercat să deschidă ofensiva ȋn Vest şi ȋn Dardanele.   ";
            }
            else if (nr == 44)
            {
                Prev2.Visible = false;
                Next2.Visible = false;
                Prev1.Text = P43.Text; 
                Next1.Text =  P45.Text; 
                Title1.Text = P44.Text; Date1.Text = "|Perioada:" + Q44.Text;
                Countries1.Text = "|Cehoslovacia";

                Descriere1.Text = "  Organizația Umbrella a slovacilor din SUA (Liga Slovacă) din Octombrie 1915 ȋn Cleveland a semnat o ȋnțelegere cu reprezentativii cu Cehii Amercani pe un program comun: unificarea viitoare a ambelor țări ȋntr-o uniune federală. Slovacii din diaspora se lugau de evenimentele legate de război drept o oportunitate care, ȋn circumstanțe favorabile ,ar putea ajuta ȋntreaga națiune să emancipeze de la surpimarea națională.  S-au organizat treptat diferite fluxuri de rezistență străină și internă slovacă împotriva statului cu un obiectiv comun: distrugerea Austro-Ungariei.";
            }
            else if (nr == 45)
            {
                Prev1.Text = Environment.NewLine + P44.Text; Prev2.Text = Q44.Text;
                Next1.Text = Environment.NewLine + P46.Text; Next2.Text = Q46.Text;
                Title1.Text = P45.Text; Date1.Text = "|Perioada:1916" ;
                Countries1.Text = "|Internațional";

                Descriere1.Text = "Frontul de Vest"+Environment.NewLine+ "  Armata germană a aplicat o tactică numita “strategia uzurii”, care insemna atacarea Verdunului in speranta că francezii ȋsi vor concentra ȋntregul efort pentru apărarea Verdunului.Aliații au răspuns cu un atac pe râul Somme,unde au folosit pentru prima dată tancul."+Environment.NewLine+Environment.NewLine+ "Frontul de Est"+Environment.NewLine+ "    In august 1916,România a intrat de parte Antantei. Aceasta,profitând de elementul surpriză au intrat ȋn Transilvania şi ȋn 3 săptămâni au cucerit o treime din ea. Apoi,armatele-austro-ungare-bulgare au spart linia Dunării şi au ȋnceput sa cucerească oraşele din Muntenia .Oficialitățile române au fost nevoite să se retragă la Iasi."+Environment.NewLine+ Environment.NewLine+"Frontul de Sud"+Environment.NewLine+ "  Nu s-a intamplat nimic in anul 1916 in aceasta zona.";
            }
            else if (nr == 46)
            {
                Prev2.Visible = false;
                Prev1.Text =  P45.Text; 
                Next1.Text = Environment.NewLine + P47.Text; Next2.Text = Q47.Text;
                Title1.Text = P46.Text; Date1.Text = "|Perioada:" + Q46.Text;
                Countries1.Text = "|Franța";

                Descriere1.Text = "  Bătălia de la Verdun a durat până în decembrie 1916. A fost cea mai lungă bătălie din Primul Război Mondial. Pe durata sa, francezii au respins o importantă ofensivă germană. A fost una dintre cele mai sângeroase și mai feroce bătălii din acest război; luptele s-au dat pe dealurile din partea de nord a orașului Verdun-sur-Meuse, în nord-estul Franței. Batalia a mai fost numită și „Abatorul” deoarece numărul de morți, răniți și dispăruți se ridică la 700 000 de persoane. Bătălia de la Verdun a fost cunoscută după remarca « Ils ne passeront pas » (Ei NU vor trece) atribuită lui Robert Nivelle."+Environment.NewLine+ "  Pentru francezi bătălia de la Verdun a fost, după cea de la Marna, al doilea moment culminant al Primul război mondial.La Verdun s-au tras cele mai multe salve de tun,si anume 4 milioane de astfel de focuri.";
            }
            else if (nr == 47)
            {
                Prev1.Text = Environment.NewLine + P46.Text; Prev2.Text = Q46.Text;
                Next1.Text = Environment.NewLine + P48.Text; Next2.Text = Q48.Text;
                Title1.Text = P47.Text; Date1.Text = "|Perioada:" + Q47.Text;
                Countries1.Text = "|România";

                Descriere1.Text = "  După doi ani de neutralitate, când România și-a negociat intrarea în război cu reprezentanții ambelor tabere, la 4/17 august 1916 București semnează un acord de alianță și o convenție militară cu Antanta și declară război Austro-Ungariei la 14 august 1916 Trupele române traversează Carpații și țara intră în război cu scopul de a elibera Transilvania, Banatul și Bucovina. Evoluția ulterioară a evenimentelor din Rusia a permis câștigul suplimentar al Basarabiei, făcând posibilă realizarea Marii Uniri.";
            }
            else if (nr == 48)
            {
                Prev1.Text = Environment.NewLine + P47.Text; Prev2.Text = Q47.Text;
                Next1.Text = Environment.NewLine + P49.Text; Next2.Text = Q49.Text;
                Title1.Text = P48.Text; Date1.Text = "|Perioada:" + Q48.Text;
                Countries1.Text = "|Regatul Unit,Franța,Imperiul German";
                Descriere1.Visible = false;Descriere2.Visible = true;
                Descriere2.Font = new Font("Courier New", 12);
                Descriere2.Text = "  Bătălia de pe Somme ocupă un loc important în memoria colectivă a armatei britanice. A fost una dintre cele mai lungi bătălii din timpul războiului (încheindu-se pe 19 noiembrie, 4 luni mai târziu) și a fost prima mare operațiune lansată de armata britanică pe Frontul de Vest.noiembrie, 4 luni mai târziu) și a fost prima mare operațiune lansată de armata britanică pe Frontul de Vest. Bătălia de pe Somme a durat 141 de zile și ea poate fi împărțită în șase perioade distincte. Au existat trei perioade de lupte intense pe un front larg-pe 1 iulie, pe 14 iulie și între 15 și 25 septembrie. Între aceste perioade putem vorbi de două episoade de lupte continue, dar mai puțin extinse, între 2 și 13 iulie și 15 iulie și 14 septembrie. Iar într-un final, perioada cuprinsă între sfârșitul lunii septembrie și sfârșitul bătăliei, în care toate operațiunile au fost zădărnicite de vremea rea.Englezii si francezii  doreu să se folosească de o nouă armă, anume Tancul (englezii aveau 50 de tancuri noi), pentru a cauza panică în rândul germanilor. Tancul, fără alt sprijin, nu avea prea mare valoare, și doar tunurile mari puteau distruge apărarea nemților.";
            }
            else if (nr == 49)
            {
                Prev1.Text = Environment.NewLine + P48.Text; Prev2.Text = Q48.Text;
                Next1.Text = Environment.NewLine + P50.Text; Next2.Text = Q50.Text;
                Title1.Text = P49.Text; Date1.Text = "|Perioada:" + Q49.Text;
                Countries1.Text = "|România";
                Descriere1.Visible = false; Descriere2.Visible = true;
                Descriere2.Text = "  În noiembrie 1916,a fost spart frontul românesc pe linia Carpaților,pe Jiu şi,pe rând, germanii au ocupat oraşele din Muntenia.În decembrie a fost ocupat Bucureştiul,iar autoritățile române au fost nevoite să se retragă la Iasi. Retragerea la Iași a fost un proces început în octombrie 1916 și terminat la începutul lunii decembrie 1916. La 11/24 noiembrie, s-a luat decizia de a muta la Iași arhivele instituților centrale, de a convoca, în fosta capitală a Moldovei, Parlamentul și de a trimite în Rusia tezaurul Băncii Naționale. Până la începutul lunii decembrie 1916, au ajuns în Iași atât autoritățile centrale, cât și circa 200 000 de refugiați. "+Environment.NewLine+ "  Administrația locală din Iași nu a fost pregătită pentru valul de refugiați și nici pentru instalarea în localuri proprii a instituțiilor centrale, tot așa cum guvernul nu conturase un plan de retragere în vechea capitală a Moldovei, ca măsură de siguranță. Supraaglomerarea orașului a produs efecte multiple: spațiile de locuire erau greu de găsit și insuficiente, penuria de alimente, răspândirea de boli (mai ales epidemia de tifos), mortalitate mare, distrugerile produse orașului.";
            }
            else if (nr == 50)
            {
                Prev1.Text = Environment.NewLine + P49.Text; Prev2.Text = Q49.Text;
                Next1.Text = Environment.NewLine + P51.Text; Next2.Text = Q51.Text;
                Title1.Text = P50.Text; Date1.Text = "|Perioada:" + Q50.Text;
                Countries1.Text = "|România";
                Descriere1.Visible = false; Descriere2.Visible = true;
                Descriere2.Text = "  Tezaurul român este tezaurul care a fost trimis în Rusia în timpul Primului Război Mondial și care nu a mai fost niciodată returnat în întregime. El includea tezaurul Băncii Naționale a României (93,4 tone de aur,dintre care 91 de monede si restul de lingouri de aur), valori aparținând unor diverse bănci românești private, societăți comerciale, persoane particulare, colecții de artă, bijuterii, arhive, etc. Toate acestea au fost transportate din România spre Rusia țaristă , cu scopul de a fi adăpostite de armatele Puterilor Centrale, care ocupaseră o parte însemnată a României și amenințau să ocupe întreg teritoriul național. "+Environment.NewLine+ "    Între 12 și 14 decembrie 1916, în gara Iași, s-au încărcat în 17 vagoane. Acesta avea sa reprezinte primul transport din trei astfel de seturi. După Marea Revoluție din Octombrie și preluarea puterii de către comuniști, sub conducerea lui Lenin, proaspăt instalata putere sovietică a sechestrat tezaurul și a refuzat restituirea acestuia. ";
            }
            else if (nr == 51)
            {
                Prev1.Text = Environment.NewLine + P50.Text; Prev2.Text = Q50.Text;
                Next1.Text = Environment.NewLine + P52.Text; Next2.Text = Q52.Text;
                Title1.Text = P51.Text; Date1.Text = "|Perioada:" + Q51.Text;
                Countries1.Text = "|Polonia";

                Descriere1.Text = "  Actul din 5 noiembrie 1916 în care împărații germani și austrieci au promis un Regat independent al Poloniei a fost primul semn că cazul polonez a devenit o chestiune internațională în timpul Primului Război Mondial. Diplomații polonezi, cu Roman Dmowski drept cel mai proeminent, au fost activi făcând Antanta să vadă necesară înființarea unui stat polonez. În ianuarie 1918, președintele SUA Wilson a spus că ar trebui înființat un stat polonez independent și să aibă acces la mare, în timp ce Franța, Marea Britanie și Italia au fost de acord.";
            }
            else if (nr == 52)
            {
                Next2.Visible = false;
                Prev1.Text = Environment.NewLine + P51.Text; Prev2.Text = Q51.Text;
                Next1.Text =  P53.Text;
                Title1.Text = P52.Text; Date1.Text = "|Perioada:" + Q52.Text;
                Countries1.Text = "|Rusia";

                Descriere1.Text = "  Grigori Rasputin a fost un călugăr rus,considerat nebun,pe care familia Romanov l-a introdus pe scena politică datorită puterilor magice pe care le avea ȋn vinderea fiului Alexei ce suferea de hemofilie. Răspuțin a crescut uşor ȋn ochii publicului datorită prezența lui ȋn viața familiei regale,pe care o ajuta să ia decizii,dar şi stilului de viață dubios. Datorită influenței lui controversate,Prințul Felix Yosupov şi Marele Duce  Dimitrie Pavlovic s-au hotărât să-l asasineze.Moartea lui a fost marcată de legende urbane care descriu cum  mâncarea otrăvită oferită de gazde nu a avut niciun efect asupra lui Rasputin,care ulterior a fost ȋmpuşcat şi aruncat ȋn apele râului Malaya Lefco";
            }
            else if (nr == 53)
            {
                Prev1.Text = Environment.NewLine + P52.Text; Prev2.Text = Q52.Text;
                Next1.Text = Environment.NewLine + P54.Text; Next2.Text = Q54.Text;
                Title1.Text = P53.Text; Date1.Text = "|Perioada:" ;
                Countries1.Text = "|Internațional";
                Descriere1.Visible = false;Descriere2.Visible = true;
                Descriere2.Text = "Frontul de Vest"+Environment.NewLine+ "   Nu s-au ȋnregistrat schimbări ȋn tactică folosită de cele două tabere,de aceea Germania a fost nevoită să declanşeze un război submarin ȋmpotriva neutrilor şi vaselor lor comerciale.În aceste condiții,SUA vor intră ȋn război de partea Antantei."+Environment.NewLine+Environment.NewLine+ "Frontul de Est"+Environment.NewLine+ "   In februarie-martie 1917,Rusia s-a desfăşurat o revoluția burghezo-democratică,ȋn urma căreia burghezia ajunge la putere. În toamna anului 1917,Vladimir Lenin a declanşat o nouă revoluție şi a preluat puterea,ȋnlăturând de la conducerea monarhia şi burghezia.Printre obiectivele lui Leni s-au aflat retragerea Rusiei din război,oferirea de pământ țăranilor şi asigurarea hranei."+Environment.NewLine+Environment.NewLine+"Frontul de Sud"+Environment.NewLine+ "  Lucrurile au rămas neschimbate,Italia fiind şi ea scoasă din război.În aceste condiții,Puterile centrale erau cele care se aflau ȋn avantaj.";
            }
            else if (nr == 54)
            {
                Prev2.Visible = false;
                Prev1.Text =  P53.Text; 
                Next1.Text = Environment.NewLine + P55.Text; Next2.Text = Q55.Text;
                Title1.Text = "Februarie si Octombrie-Revoluțiile bolsevice din Rusia "; Date1.Text = "|Perioada:" + Q54.Text;
                Countries1.Text = "|Rusia";

                Descriere1.Text = "  În timpul unui alt val de grevă a muncitorilor din Rusia în 1917, soldații au refuzat să tragă asupra protestatarilor. Odată ce țarul a fost forțat să abdice, controlul asupra haosului care a urmat a fost preluat progresiv de Lenin, liderul bolșevic. Un război civil a izbucnit între bolșevici și susținătorii vechii ordine. După destrămarea imperiului Romanov, au apărut republicile baltice independente: Finlanda, Lituania, Letonia și Estonia. ";

            }
            else if (nr == 55)
            {
                Prev1.Text = Environment.NewLine + P54.Text; Prev2.Text = Q54.Text;
                Next1.Text = Environment.NewLine + P56.Text; Next2.Text = Q56.Text;
                Title1.Text = P55.Text; Date1.Text = "|Perioada" + Q55.Text;
                 Countries1.Text = "|Rusia";

                Descriere1.Text = "  După Revoluția din Februarie a anului 1917,guvernul German il ajută pe Vladimir Il'ič Lenin-un socialist exilat ȋn urma revoluției din 1905-să se ȋntoarcă ȋn Rusia.Acesta a fost exilat in Elvetia dupa revolutia din 1905.La schimb,Imperiul German cere ȋncetarea focurilor ca sa urmeze rascoala.Lenin calatoreste intr-un tren sigilat,de la Zurich la Petrograd. Revolutia din Octombrie a fost un success,iar iar in martie 1918 este semnat tratatul ruso-german de la Brest-Litovsk.";

            }
            else if (nr == 56)
            {
                Next2.Visible = false;
                Prev1.Text = Environment.NewLine + P55.Text; Prev2.Text = Q55.Text;
                Next1.Text =  P57.Text; 
                Title1.Text = P56.Text; Date1.Text = "|Perioada:" + Q56.Text;
                
                Countries1.Text = "|România";
                Descriere1.Visible = false; Descriere2.Visible = true;
                Descriere2.Font = new Font("Courier New", 12);
                Descriere2.Text = "  Bătălia de la Mărăști a fost una din principalele bătălii desfășurate pe teritoriul României în timpul Primului Război Mondial. S-a desfășurat între 11/24 iulie 1917 și 19 iulie/1 august 1917 și a fost o operațiune ofensivă a armatei române și armatei ruse cu scopul de a încercui și distruge Armata a 9-a Germană. Operațiunea a fost planificată a se desfășura în paralel cu operațiunea ofensivă de la Nămoloasa la care s-a renunțat între timp." + Environment.NewLine + "  A Treia Bătălie de la Oituz a fost o confruntare militară complexă desfășurată între armata română sprijinită de trupele Republicii Ruse, împotriva trupelor germane și austro-ungare, în timpul campaniei militare românești din 1917 din Primul Război Mondial. Bătălia – purtată în perioada 26 iulie/8 august – 9/22 august 1917 s-a desfășurat pe axele principale ale văilor Slănicului, Oituzului și Cașinului din județul Bacău și a avut ca scop strategic - de partea Puterilor Centrale pătrunderea în valea Trotușului spre Onești și apoi spre Adjud pentru a se face joncțiunea cu armatele amice aflate în ofensivă la Mărășești, iar de partea României pe acela de apărare și de menținere a liniei frontului." + Environment.NewLine + "  Bătălia de la Mărășești a fost o serie de acțiuni militare complexe desfășurate pe Frontul Român, în perioada 24 iulie/6 august – 6 august/19 august 1917 în zona Vrancei în spațiul dintre râurile Siret și Putna și aliniamentul Muncelu - Mărășești. Bătălia a avut ca rezultat eșecul ofensivei germane și stabilizarea frontului din zonă, până la sfârșitul conflagrației.";

            }
            else if (nr == 57)
            {
                Prev1.Text = Environment.NewLine + P56.Text; Prev2.Text = Q56.Text;
                Next1.Text = Environment.NewLine + P58.Text; Next2.Text = Q58.Text;
                Title1.Text = P57.Text; Date1.Text = "|Perioada:1918" ;
                Countries1.Text = "|Internațional";

                Descriere1.Text = "Frontul de Est"+Environment.NewLine+ "  În  martie-aprilie România  ȋncheie pacea cu Puterile Centrale,iar teritoriul său este ocupat de trupele germane-austro-ungare.În noiembrie 1918,Regele Ferdinand a dat un ultimatum Germaniei,iar pe 10 noiembrie 1918 i-a declarat război."+Environment.NewLine+Environment.NewLine+ "  Frontul de Vest"+Environment.NewLine+ "   Contribuția SUA a făcut ca să se activeze frontul de pe Marna ȋn vara lui 1918.Trupele germane au dat ȋn retragere ,iar in toamna au ȋnceput capitularile. În septembrie 1918-Bulgaria; 3 noiembrie –Austro-Ungaria;11 noiembrie-Germania."+Environment.NewLine+Environment.NewLine+ "Frontul de Sud"+Environment.NewLine+ "  A fost deschis frontul de la Salonie,iar Italia a reintrat in luptă,reuşind să obțină victorii.";
            }
            else if (nr == 58)
            {
                Prev2.Visible = false;
                Prev1.Text =  P57.Text; 
                Next1.Text = Environment.NewLine + P59.Text; Next2.Text = Q59.Text;
                Title1.Text = P58.Text; Date1.Text = "|Perioada:" + Q58.Text;
                Countries1.Text = "|S.U.A.";

                Descriere1.Text = "  Cele paisprezece puncte au fost prezentate de Președintele Statelor Unite ale Americii, Woodrow Wilson, în sesiunea comună a Congresului din 8 ianuarie 1918. În discursul său, Wilson a încercat să stabilească un proiect viabil pentru restabilirea păcii în Europa după încheierea Primului Război Mondial. Idealismul demonstrat de Wilson în timpul discursului sus-numit i-a oferit președintelui american o poziție de conducere morală printre Aliați și a încurajat Puterile Centrale să semneze armistițiile.";
            }
            else if (nr == 59)
            {
                Prev1.Text = Environment.NewLine + P58.Text; Prev2.Text = Q58.Text;
                Next1.Text = Environment.NewLine + P60.Text; Next2.Text = Q60.Text;
                Title1.Text = P59.Text; Date1.Text = "|Perioada:" + Q59.Text;
                Countries1.Text = "|Germania";

                Descriere1.Text = "  După patru ani de război și o blocadă navală care lasă mulți oameni înfometați, Imperiul German este complet distrus. Când la începutul lunii noiembrie marinarii refuză să respecte ordinele de pe navele de război, o revoluție se răspândește în toată Germania. După aceea, împăratul Wilhelm al II-lea fuge în exil,iar proclamarea republicii de către Scheidemann este consecința logică. Două zile mai târziu, încetarea focului este semnată. Constituția Republicii Weimar intră în vigoare în august 1919.";
            }
            else if (nr == 60)
            {
                Prev1.Text = Environment.NewLine + P59.Text; Prev2.Text = Q59.Text;
                Next1.Text = Environment.NewLine + P61.Text; Next2.Text = Q61.Text;
                Title1.Text = P60.Text; Date1.Text = "|Perioada:" + Q60.Text;
                Countries1.Text = "|Polonia";

                Descriere1.Text = "  La 11 noiembrie 1918, Consiliul de Regență - o autoritate provizorie pe teritoriul polonez - a adoptat un decret privind transferul comandamentului militar către Józef Piłsudski, comandantul Legiunilor (o unitate militară poloneză) tocmai eliberat din captivitatea germană. Decretul a fost susținut de aproape toate grupurile politice. 11 noiembrie a fost considerată ziua în care Polonia și-a recâștigat independența. Pe străzile orașelor poloneze a început dezarmarea spontană a germanilor și austriecilor.";
            }
            else if (nr == 61)
            {
                Prev1.Text = Environment.NewLine + P60.Text; Prev2.Text = Q60.Text;
                Next1.Text = Environment.NewLine + P62.Text; Next2.Text = Q62.Text;
                Title1.Text = P61.Text; Date1.Text = "|Perioada" + Q61.Text;
                Countries1.Text = "|România";

                Descriere1.Text = "  În contextul primului război mondial și al căderii imperiilor multinaționale, românii din teritoriile situate în afara granițelor țării și-au intensificat lupta pentru a ieși din sub autoritatea Rusiei și a Austro-Ungariei și a se uni cu România. Au fost înființate organe reprezentative: Sfatul Țării din Basarabia, Congresul General al Bucovinei, Marea Adunare Națională din Transilvania. Unul câte unul în timpul anului 1918 au decis să se unească cu patria mamă. Astfel, procesul de construire a statului național unitar român a fost realizat.";
            }
            else if (nr == 62)
            {
                Prev1.Text = Environment.NewLine + P61.Text; Prev2.Text = Q61.Text;
                Next1.Text = Environment.NewLine + P63.Text; Next2.Text = Q63.Text;
                Title1.Text = P62.Text; Date1.Text = "|Perioada:" + Q62.Text;
                Countries1.Text = "|Polonia";

                Descriere1.Text = "  Tânărul stat polonez a trebuit să lupte singur pentru noile sale granițe. În regiunea Poloniei Mari, polonezii au început și au câștigat o răscoală împotriva germanilor. În teritoriile controversate din Silezia Superioară, referendumul Varmia și Mazuria au fost avute în vedere în temeiul Tratatului de la Versailles. Nemulțumiți de soluție, polonezii din Silezia au făcut trei răscoale împotriva autorității germane în 1919–21. Silezia a fost în cele din urmă împărțită între ambele țări. Un război polono-ucrainean a izbucnit în est.";
            }
            else if (nr == 63)
            {
                Prev1.Text = Environment.NewLine + P62.Text; Prev2.Text = Q62.Text;
                Next1.Text = Environment.NewLine + P64.Text; Next2.Text = Q64.Text;
                Title1.Text = P63.Text; Date1.Text = "|Perioada:" + Q63.Text;
                Countries1.Text = "|Ungaria";

                Descriere1.Text = "  În cele 133 de zile ale dictaturii proletariatului, social-democrații și comuniștii au venit la putere în Ungaria. Imitând exemplul sovietic, politica și afacerile economice au fost transformate în timp ce fabricile erau naționalizate. Țăranii nu mai susțineau noul sistem, în timp ce înrăutățirea condițiilor de viață îi făcea pe muncitori dezamăgiți. Antanta a refuzat să recunoască noul sistem, care nu putea opri ocuparea teritoriilor Ungariei de către țările vecine.";
            }
            else if (nr == 64)
            {
                Prev1.Text = Environment.NewLine + P63.Text; Prev2.Text = Q63.Text;
                Next1.Text = Environment.NewLine + P65.Text; Next2.Text = Q65.Text;
                Title1.Text = P64.Text; Date1.Text = "|Perioada:" + Q64.Text;
                Countries1.Text = "|Internațional";

                Descriere1.Text = "  Într-o ceremonie sumbră, delegația germană este obligată să semneze Tratatul de pace de la Versailles. Formalitățile au loc în Sala Oglinzilor din Palatul francez de la Versailles, același loc în care al doilea imperiu german fusese declarat în ianuarie 1871. Tratatul include concesiunile teritoriale germane și plata unor reparații grele. Cu toate acestea, articolul 231 provoacă cea mai mare amărăciune din Germania, impunând Imperiului să își asume responsabilitatea exclusivă pentru izbucnirea războiului. Totodata,s-a decis si dezarmarea Germaniei,atat incat sa nu fie nicioadata atat de puternica sa atace Franta din nou. Tara va avea de suferit o mare criza economica din cauza acestui tratat,iar S.U.A. îi va acorda împrumuturi pentru a plăti reparațiile de război.";
            }
            else if (nr == 65)
            {
                Prev1.Text = Environment.NewLine + P64.Text; Prev2.Text = Q64.Text;
                Next1.Text = Environment.NewLine + P66.Text; Next2.Text = Q66.Text;
                Title1.Text = P65.Text; Date1.Text = "|Perioada:" + Q65.Text;
                Countries1.Text = "|România";

                Descriere1.Text = "  La sfârșitul războiului, pentru a-și recunoaște noile frontiere, România a condus o intensă activitate diplomatică în timpul Conferinței Paris Pace, care avea ca scop construirea unei noi ordini politice și teritoriale în Europa și în lume și prevenirea unui nou conflict internațional. După mai multe negocieri, noile frontiere au fost incluse în tratatele de pace de la Saint-Germain (10 septembrie 1919) cu Austria, de Neuilly-sur-Seine (27 noiembrie 1919) cu Bulgaria, de Trianon (4 iunie 1920) cu Ungaria și de Paris (28 octombrie 1920) cu marile puteri.";
            }
            else if (nr == 66)
            {
                Prev1.Text = Environment.NewLine + P65.Text; Prev2.Text = Q65.Text;
                Next1.Text = Environment.NewLine + P67.Text; Next2.Text = Q67.Text;
                Title1.Text = P66.Text; Date1.Text = "|Perioada:" + Q66.Text;
                Countries1.Text = "|Franța";

                Descriere1.Text = "  Linia Maginot(ce poartă numele ministrului francez al apărării André Maginot care a proiectat-o) a constat dintr-un șir de fortificații de beton, obstacole antitanc, dotate cu artilerie grea, cazemate, mitraliere și alte elemente de apărare, construite între anii 1920-1930 și modernizate între anii 1930-1940, pe care Franța a construit-o de-a lungul graniței sale cu Germania, Belgia, Luxemburg, Elveția și Italia, pe baza experienței sale din Primul Război Mondial și pentru a se pregăti pentru un eventual atac, în special din partea Germaniei.";
            }
            else if (nr == 67)
            {
                Prev1.Text = Environment.NewLine + P66.Text; Prev2.Text = Q66.Text;
                Next1.Text = Environment.NewLine + P68.Text; Next2.Text = Q68.Text;
                Title1.Text = P67.Text; Date1.Text = "|Perioada" + Q67.Text;
                Countries1.Text = "|România";

                Descriere1.Text = "  Arcul de triumf de la Bucuresti a fost ridicat Împreună cu Catedrala Încoronării din Alba Iulia, cu Mausoleul de la Mărășești,cu Crucea Eroilor Neamului de pe Muntele Caraiman, și cu Mormântul Eroului Necunoscut din Parcul Carol I cu scopu de a aminti  de victoria Romaniei dupa Primul Razboi Mondial. în 1922, în contextul încoronării regelui Ferdinand I și a reginei Maria ca suverani ai României Mari, comisia pentru organizarea serbărilor încoronării a apelat la serviciile arhitectului Petre Antonescu pentru ridicarea unui impunător Arc de Triumf în zona nordică a capitalei.";
            }
            else if (nr == 68)
            {
                Prev1.Text = Environment.NewLine + P67.Text; Prev2.Text = Q67.Text;
                Next1.Text = Environment.NewLine + P69.Text; Next2.Text = Q69.Text;
                Title1.Text = P68.Text; Date1.Text = "|Perioada:" + Q68.Text;
                Countries1.Text = "|România";

                Descriere1.Text = "  Mausoleul de la Mărășești este un monument istoric dedicate eroilor Primului Război Mondial ,cazuti pe frontul de lupta din localitatea careia ii poarta numele.  480 de ofițeri și 21.000 de soldați români in timpul bataliei. Monumentul, printre cele mai importante din Europa, a fost realizat după planurile arhitecților George Cristinel și Constantin Pomponiu,la initiativa Reginei Maria si a altor personalitati de rang ale epocii. Monumentul mausoleul adăpostește rămășițele a 5073 de soldați și ofițeri, în 154 de cripte individuale și 9 cripte comune de pe 18 culoare.";
            }
            else if (nr == 69)
            {
                Prev1.Text = Environment.NewLine + P68.Text; Prev2.Text = Q68.Text;
                Next1.Text = Environment.NewLine + P70.Text; Next2.Text = Q70.Text;
                Title1.Text = P69.Text; Date1.Text = "|Perioada" + Q69.Text;
                Countries1.Text = "|România";

                Descriere1.Text = "  Crucea Eroilor de pe Muntele Caraiman este un monument ridicat la porunca Reginei Maria ȋntre anii 1924-1928,ȋn cinstea celor 30 000 de soldati căzuți pe fronturile din Valea Prahovei. Acesta este desemnată drept cea mai mare cruce amplasată pe un vârf montan,fiind amplasată la altitudinea de 2291 m.Se spune că ideea construirii acestui monument a apărut ȋn visul Reginei Maria care a văzut Muntii Bucegi „stropiți cu sângele eroilor”.";
            }
            else if (nr == 70)
            {
                Prev1.Text = Environment.NewLine + P69.Text; Prev2.Text = Q69.Text;
                Next1.Text = Environment.NewLine + P71.Text; Next2.Text = Q71.Text;
                Title1.Text = P70.Text; Date1.Text = "|Perioada:" + Q70.Text;
                Countries1.Text = "|România";

                Descriere1.Text = "  Viața politică românească a suferit schimbări importante după Marea Unire din 1918. Temeiul sistemului de stat a fost noua constituție din 1923 care, prin includerea reformelor democratice promise din 1917–1918, a devenit baza vieții politice, judiciare, sociale și economice a României până în Februarie 1938. Totuși, subminat de factori interni și sub presiunea evenimentelor naționale, acest sistem democratic a fost abandonat în 1938 și înlocuit cu un regim monarhic autoritar. În perioada interbelică, România a asistat la remarcabile realizări culturale, artistice, științifice și tehnice.";
            }
            else if (nr == 71)
            {
                Prev1.Text = Environment.NewLine + P70.Text; Prev2.Text = Q70.Text;
                Next1.Text = Environment.NewLine + P72.Text; Next2.Text = Q72.Text;
                Title1.Text = P71.Text; Date1.Text = "|Perioada:" + Q71.Text;
                Countries1.Text = "|Italia";

                Descriere1.Text = "  La scurt  timp după ȋncheierea Primului Război Mondial,Benito Mussolini fondează pe data de 23 martie 1919 primul grup de natură fascista,alcătuit inițial din veterani de război. Ulterior,Mussolini ia sub simbolul fascist şi italieni bogați,proprietari de companii şi terenuri.Urmează ca ȋn 1921 să ȋnființeze Partidul Popular Fascist.";
            }
            else if (nr == 72)
            {
                Prev1.Text = Environment.NewLine + P71.Text; Prev2.Text = Q71.Text;
                Next1.Text = Environment.NewLine + P73.Text; Next2.Text = Q73.Text;
                Title1.Text = P72.Text; Date1.Text = "|Perioada:" + Q72.Text;
                Countries1.Text = "|S.U.A.";

                Descriere1.Text = "    Soldații americani care s-au întors din Europa, de la război, au găsit acasă o Americă foarte diferită de cea pe care o părăsiseră cu câțiva ani în urmă. În absența lor, Constituției îi fuseseră adăugate două amendamente, prin era interzisa producerea, vânzărea și transportului de alcool,iar femeile aveau dreptul la vot.Bauturile alcoolice au ajuns sa fie aruncate in canalizare, iar clanuri mafiote au facut averi uriase de urma procurarii si transportarii acestora.”Al” Capone a fost cel mai mare gangster care facea contrbanda cu alcool.  foarte multe otrăvuri și mult alcool metilic au luat locul vechiului whiskey pur, mare parte din populație s-au obișnuit cu indiferența față de lege și încălcarea ei."+Environment.NewLine+ "  Până la sfârșitul deceniului trei, națiunea se săturase deja de acest experiment. Exasperarea cauzată de eșecul său și ideea că taxele impuse pe alcool vor furniza veniturile necesare pentru alte programe naționale au dus în cele din urmă, în 1933, la ratificarea amendamentului 21.";
            }
            else if (nr == 73)
            {
                Prev1.Text = Environment.NewLine + P72.Text; Prev2.Text = Q72.Text;
                Next1.Text = Environment.NewLine + P74.Text; Next2.Text = Q74.Text;
                Title1.Text = P73.Text; Date1.Text = "|Perioada:" + Q73.Text;
                Countries1.Text = "|Slovacia";

                Descriere1.Text = "  Tratatul de la Trianon a delimitat granița de sud a Slovaciei. Această graniță a fost decisă în cel mai complicat mod. În zona cu populație mixtă, s-a decis nu numai în funcție de dreptul acceptat de autodeterminare, ci și în funcție de factorii economici și militari-strategici. Eforturile maghiare de a-l revizui și a se apăra împotriva anti-revizionismului au devenit o componentă politică cheie a ambelor țări în deceniile următoare. Transmiterea a douăzeci și cinci de sate către Polonia a devenit o problemă pentru granițele slovace din nord.";
            }
            else if (nr == 74)
            {
                Prev1.Text = Environment.NewLine + P73.Text; Prev2.Text = Q73.Text;
                Next1.Text = Environment.NewLine + P75.Text; Next2.Text = Q75.Text;
                Title1.Text = P74.Text; Date1.Text = "|Perioada:" + Q74.Text;
                Countries1.Text = "|Ungaria";

                Descriere1.Text = "  Conform acordului de pace semnat în Palatul Trianon din Versailles, două treimi din teritoriul istoric al Ungariei a fost anexat națiunilor vecine; o treime din toți maghiarii - mai mult de trei milioane de oameni - s-au trezit ulterior sub control străin. Presată între noile sale granițe, Ungaria a devenit un stat național a cărui populație era nouăzeci și două la sută maghiară, totuși s-a găsit încă existând într-o pace care a declanșat conflicte serioase între Ungaria și națiunile vecine.";
            }
            else if (nr == 75)
            {
                Prev1.Text = Environment.NewLine + P74.Text; Prev2.Text = Q74.Text;
                Next1.Text = Environment.NewLine + P76.Text; Next2.Text = Q76.Text;
                Title1.Text = P75.Text; Date1.Text = "|Perioada:" + Q75.Text;
                Countries1.Text = "|România și Ungaria";

                Descriere1.Text = "  In contextul creearii unei Ungarii ostile,care a devenit in 1919 comunista condusa de comuniştilor lui Bela Kun, armata romana a fost nevoita sa intervina pentru a nu pierde Transilvania. Pe acest fond, la 4 August 1919, Armata Română intră în Budapesta."+Environment.NewLine+ "  Trupele române au trecut râul Tisa şi într-un ritm foarte rapid şi au intrat în Budapesta. Armata Română a ocupat estul a ceea ce era atunci Ungaria până la 28 martie 1920..In urma infragerii suferite de maghiari,la putere, va veni un lider politic conservator, Miklos Horthy. Bela Kun şi apropiaţii lor fug la Viena. Liderul comunist maghiar nu îi va ierta niciodată lui Cristian Racovski că şi-a trimis soldaţii contra ruşilor albi în loc să îl ajute să dezmembreze România. Peste ceva mai mult de 10 ani, amândoi vor fi ucişi de Stalin.";
            }
            else if (nr == 76)
            {
                Prev1.Text = Environment.NewLine + P75.Text; Prev2.Text = Q75.Text;
                Next1.Text = Environment.NewLine + P77.Text; Next2.Text = Q77.Text;
                Title1.Text = P76.Text; Date1.Text = "|Perioada:" + Q76.Text;
                Countries1.Text = "|Polonia și Rusia";

                Descriere1.Text = "  Forma frontierei de est a fost decisă de victoria poloneză în războiul cu bolșevicii a căror bătălie cheie - Bătălia de la Varșovia - a avut loc în august 1920. Nu numai că s-a încheiat cu o victorie poloneză, dar se spune că a oprit marșul. a bolșevicilor din vestul Europei. În consecință, este inclus pe lista bătăliilor care au schimbat cursul istoriei lumii. Războiul s-a încheiat la 18 martie 1921 cu Tratatul de la Riga,iar polonezii nu au uitat ce le-au facut rusii cand Stalin a incercat sa creeze o serie de state tampon care sa ferească Rusia de autoritățiile germane după Al Doilea Război Mondial.";
            }
            else if (nr == 77)
            {
                Prev1.Text = Environment.NewLine + P76.Text; Prev2.Text = Q76.Text;
                Next1.Text = Environment.NewLine + P78.Text; Next2.Text = Q78.Text;
                Title1.Text = P77.Text; Date1.Text = "|Perioada:" + Q77.Text;
                Countries1.Text = "|Nicolae Constantin Paulescu";

                Descriere1.Text = "   Insulina,folosită pentru tratarea persoanelor ce suferea de diabet,a fost descoperită de psihologul şi profesorul de medicină român Nicolae Constatni Paulescu ȋn anul 1922. În 1916,a reuşit să dezvolte cu succes un extract pancreat,testat pe un câine diabetic,care s-a dovedit a avea un efect normalizator asupra nivelului de zahăr din sânge.Paulescu şi-a patentat invenția,dar nu a primit recunoaştere la vremea respectivă.";

            }
            else if (nr == 78)
            {
                Prev1.Text = Environment.NewLine + P77.Text; Prev2.Text = Q77.Text;
                Next1.Text = Environment.NewLine + P79.Text; Next2.Text = Q79.Text;
                Title1.Text = P78.Text; Date1.Text = "|Perioada:" + Q78.Text;
                Countries1.Text = "|Slovacia";

                Descriere1.Text = "  Propunerea pentru soluționarea poziției discutabile a Slovaciei în noua țară ca administrație autonomă a fost înaintată parlamentului cehoslovac pentru prima dată. Reprezentanții slovaci au depus fără succes cerința unui control mai autonom al afacerilor slovace în perioada următoare. Apoi, două concepte s-au ciocnit în timpul istoriei interbelice a Cehoslovaciei: autonomiștii slovaci și-au bazat ideile pe o națiune slovacă separată cu cerințe specifice, în timp ce partidele guvernamentale decisive au folosit ideea unei națiuni cehoslovace uniforme ca bază a unui stat centralizat.";

            }
            else if (nr == 79)
            {
                Prev1.Text = Environment.NewLine + P78.Text; Prev2.Text = Q78.Text;
                Next1.Text = Environment.NewLine + P80.Text; Next2.Text = Q80.Text;
                Title1.Text = P79.Text; Date1.Text = "|Perioada:" + Q79.Text;
                Countries1.Text = "|Italia";

                Descriere1.Text = "   In drumul lui spre putere,Benito Mussolini declanşează “Marşul asupra Romei” , în fruntea unei mişcări populare şi politice, profitand de moralul scazut al italineilor si sentimentul acestora de nemulţumire generală dintr-o ţară debusolată, săracă,coruptă,plină de benzi mafioate. La ordinul său, mii de fasciști s-au îndreaptat spre Roma. Deşi Armata îi garantase superioritatea în cazul unei confruntări cu rebeliunea de muncitori grevişti care porniseră spre capital,Regel Victor Emanuel al III-lea alege pe Mussolini să formeze guvernul, în calitate de prim-ministru.Neputinta Italiei de a opri o simpla mişcare populară ,orchestrată de fostul tânăr editor al ziarului socialist “Avanti!”,ajuns ulterior editor al propriului ziar fascist ”Il Popolo d’Italia” ,avea sa determine un pictor austriac ratat sa incerce să ia puterea ȋn Germania. Situația politico-economică a Europei interbelice a servit drept treaptă de lansare a partidelor de extremă stângă.";
            }
            else if (nr == 80)
            {
                Prev1.Text = Environment.NewLine + P79.Text; Prev2.Text = Q79.Text;
                Next1.Text = Environment.NewLine + P81.Text; Next2.Text = Q81.Text;
                Title1.Text = P80.Text; Date1.Text = "|Perioada:" + Q80.Text;
                Countries1.Text = "|Germania";

                Descriere1.Text = "  Când Germania rămâne în urmă cu plata despăgubirilor de război, trupele franceze și belgiene ocupă regiunea industrială Rin-Ruhr. Guvernul de la Berlin cere rezistență pasivă în rândul populației locale împotriva acestei acțiuni umilitoare. Cu toate acestea, plățile de înlocuire a veniturilor către muncitorii în grevă golesc rapid trezoreria statului. Rezultatul este hiperinflația, încă o experiență traumatică în memoria colectivă germană de astăzi și acte de sabotaj din partea grupurilor voluntare de dreapta. Guvernul german a propus poporul sa faca greva,dar armata franceza nu a tolerat acest comportament. ";
            }
            else if (nr == 81)
            {
                Prev1.Text = Environment.NewLine + P80.Text; Prev2.Text = Q80.Text;
                Next1.Text = Environment.NewLine + P82.Text; Next2.Text = Q82.Text;
                Title1.Text = P81.Text; Date1.Text = "|Perioada:" + Q81.Text;
                Countries1.Text = "|România";

                Descriere1.Text = "  Fiecare provincie de unire avea propriile legi, propria organizație politică și administrativă. Între 1919 și 1925 au fost adoptate o serie de măsuri prin care legislația și instituțiile statului au fost armonizate: în 1920 - Legea unificării monetare; în 1921 - reforme financiare și funciare; în 1923 - Constituția României Mari (care stabilea votul direct, secret și obligatoriu - pentru bărbații cu vârsta peste douăzeci și unu de ani); în 1924 - reforme în educație și justiție; în 1925 - reforme în administrație.Legile financiare si monetare au fost adoptate pentru ca,dupa Unire,fiecare teritoriu nou cucerit  de Romania avea propia monedă,iar liderii români au fost nevoiți să le convertească pe toate ȋntr-una singură. ";
            }
            else if (nr == 82)
            {
                Prev1.Text = Environment.NewLine + P81.Text; Prev2.Text = Q81.Text;
                Next1.Text = Environment.NewLine + P83.Text; Next2.Text = Q83.Text;
                Title1.Text = P82.Text; Date1.Text = "|Perioada" + Q82.Text;
                Countries1.Text = "|Germania";

                Descriere1.Text = "  Inspirat de mişcările fasciste din Italia şi determinat de situția economică ȋn care se află Republica de la Wimar, Adolf Hitler a plănuit să forțeze cațiva 3 politicieni bavarezi-Gustav Ritter von Kahr, Otto von Moser şi Hans Ritter von Seisser - să i se alature şi să mărşăluiască spre Berlin. Hitler ,alături de alți membri de elita nazişti,precum Hermnann Goering,au ȋnconjurat barul din Munchen unde politicienii planificaseră să țină un discurs.Deşi publicului nu ii era cunoscută această personalitate,ȋn doar câteva propoziții energice,Hitler a reuşit să-l convingă ȋn legătură cu ideile sale,iar,ca să şi le legitimeze,s-a folosit de prezența ȋn grupul nazist a lui Erich Ludendorff,veteran de război.Deşi Hitler a făcut un plan ca la carte , a făcut greşeala să părăsească berăria,timp ȋn care politicienii bavarezi au scăpat.";
            }
            else if (nr == 83)
            {
                Prev1.Text = Environment.NewLine + P82.Text; Prev2.Text = Q82.Text;
                Next1.Text = Environment.NewLine + P84.Text; Next2.Text = Q84.Text;
                Title1.Text = P83.Text; Date1.Text = "|Perioada" + Q83.Text;
                Countries1.Text = "|Germania";

                Descriere1.Text = "  Deşi ȋncercarea lor de a dobândi puterea folosindu-se ȋn mod strategic de trei bavarezi a eşuat, Hitler, Ludendorff şi alți 2000 de nazişti au pus ȋn aplicare un plan pentru a lua controlul asupra oraşului Munchen,marşăluind.Deşi au trecut de prima baricadă a poliției neatinşi,asta nu s-a ȋntâmplat şi pentru a doua .A urmat un foc de arme de aproape 30 de secunde,şi in care patru polițişti bavarezi au fost ucisi,iar Hitler şi-a dislocat umărul.Liderul nazist a căutat refugiu la un prieten din apropierea oraşului. Poliția l-a găsit cu uşurință ,iar ȋn timpul procesului,judecătorii l-au lăsat să țină un discurs,ȋn urma căruia a câştigat doar 5 ani de puşcărie.";
            }
            else if (nr == 84)
            {
                Prev1.Text = Environment.NewLine + P83.Text; Prev2.Text = Q83.Text;
                Next1.Text = Environment.NewLine + P85.Text; Next2.Text = Q85.Text;
                Title1.Text = P84.Text; Date1.Text = "|Perioada:" + Q84.Text;
                Countries1.Text = "|Aurel Persu";

                Descriere1.Text = "    Maşinile din zilele de azi sunt din ce in ce mai moderne, mai puternice şi mai polivalente;dar nu au fost niciodata aşa.Aurel Persu este inginerul roman care a contribuit la desing-ul maşinilor pe care le ştim noi  astăzi.El a fost primul care a poziționat rotile autoturismelor ȋnăuntrul maşinilor,ideea lui principală a fost să ofere maşinilor o formă aerodinamică .El a ajuns la concluzia că acestea trebuie să semene cu o picătură de apă .A obținut patent asupra descoperirlor sale ȋn anul 1924,ȋn Germania.";
            }
            else if (nr == 85)
            {
                Prev1.Text = Environment.NewLine + P84.Text; Prev2.Text = Q84.Text;
                Next1.Text = Environment.NewLine + P86.Text; Next2.Text = Q86.Text;
                Title1.Text = P85.Text; Date1.Text = "|Perioada:" + Q85.Text;
                Countries1.Text = "|Polonia";

                Descriere1.Text = "  După 123 de ani de partiții, economia era învechită și afectată de război. În curând au fost adoptate multe reforme, inclusiv reforma trezoreriei și valutare a lui Władysław Grabski, care a avut o importanță cheie pentru economie și a împiedicat hiperinflația. S-a stabilit o nouă monedă: zlotul polonez. În 1926, a început construcția unui port polonez din Marea Baltică în Gdynia. Odată cu încheierea crizei de la sfârșitul anilor 1930, au început lucrările la Regiunea industrială centrală (COP), inclusiv o serie de fabrici industriale.";
            }
            else if (nr == 86)
            {
                Prev1.Text = Environment.NewLine + P85.Text; Prev2.Text = Q85.Text;
                Next1.Text = Environment.NewLine + P87.Text; Next2.Text = Q87.Text;
                Title1.Text = P86.Text; Date1.Text = "|Perioada:" + Q86.Text;
                Countries1.Text = "|Polonia";

                Descriere1.Text = "  În perioada interbelică de două decenii, societatea poloneză era foarte diversă, polonezii constituind doar 64% din populație și restul minorităților etnice. După 123 de ani de partiții, economia era învechită și afectată de război. În curând au fost efectuate multe reforme, inclusiv o reformă agrară. În 1926, a început construcția unui port polonez din Marea Baltică în Gdynia. Odată cu încheierea crizei de la sfârșitul anilor 1930, au început lucrările la Regiunea industrială centrală, inclusiv o serie de fabrici industriale.";
            }
            else if (nr == 87)
            {
                Prev1.Text = Environment.NewLine + P86.Text; Prev2.Text = Q86.Text;
                Next1.Text = Environment.NewLine + P88.Text; Next2.Text = Q88.Text;
                Title1.Text = P87.Text; Date1.Text = "|Perioada:" + Q87.Text;
                Countries1.Text = "|Româmia";

                Descriere1.Text = "  Înțelegerea Balcanică a fost o alianță formată pe 9 februarie 1934, la Atena, de către Iugoslavia, România, Grecia și Turcia cu un caracter defensiv, în cazul izbucnirii unui război, țările aliate își puteau apăra granițel.Confruntată cu politica revizionistă a unui număr important de vecini (Ungaria, Bulgaria, Uniunea Sovietică), România s-a alăturat eforturilor altor state din regiune interesate să construiască alianțe defensive menite să protejeze tratatele și să păstreze status quo-ul teritorial. Astfel, în 1921, România a participat la crearea Micii Antante, împreună cu Cehoslovacia și Regatul sârbilor, croaților și slovenilor, iar în 1934 a alcătuit Pactul balcanic, împreună cu Iugoslavia, Grecia și Turcia.";
            }
            else if (nr == 88)
            {
                Prev1.Text = Environment.NewLine + P87.Text; Prev2.Text = Q87.Text;
                Next1.Text = Environment.NewLine + P89.Text; Next2.Text = Q89.Text;
                Title1.Text = P88.Text; Date1.Text = "|Perioada:" + Q88.Text;
                Countries1.Text = "|Româmia";

                Descriere1.Text = "  În cadrul politicii sale externe, pentru consolidarea unității și integrității teritoriale, România a semnat tratate de alianță cu Polonia (1921 și 1926), Franța (1926) și Italia (1926). În același timp, prin Nicolae Titulescu, a fost implicat activ în crearea unui sistem de securitate colectivă care să contribuie la conservarea sistemului de la Versailles.";
            }
            else if (nr == 89)
            {
                Prev1.Text = Environment.NewLine + P88.Text; Prev2.Text = Q88.Text;
                Next1.Text = Environment.NewLine + P90.Text; Next2.Text = Q90.Text;
                Title1.Text = P89.Text; Date1.Text = "|Perioada:" + Q89.Text;
                Countries1.Text = "|Ungaria";

                Descriere1.Text = "  Prăbusirea economiei a fost oprită prin politici de consolidare creditate primului ministru István Bethlen. Sprijinul financiar pentru introducerea pengő, o nouă monedă utilizată pentru a înlocui coroana instabilă, a fost posibilă datorită unui împrumut de 307 milioane de coroane de aur de la Alianța Populară. Acest pas nu numai că a reprezentat integrarea națiunii în sistemul de pace format de Antantă, ci a rupt și izolarea care prinsese poziția Ungariei în afaceri externe.";
            }
            else if (nr == 90)
            {
                Prev1.Text = Environment.NewLine + P89.Text; Prev2.Text = Q89.Text;
                Next1.Text = Environment.NewLine + P91.Text; Next2.Text = Q91.Text;
                Title1.Text = P90.Text; Date1.Text = "|Perioada:" + Q90.Text;
                Countries1.Text = "|S.U.A.";

                Descriere1.Text = "  In orasul Chicago,aflat la culmea contrabandei cu bauturi alcoolice din timpul prohibitiei, membrii irlandezi ai unei organizatii mafiote au fost omorati fara mila,se crede, de oamenii lui “Al” Capone.In ziua de 14 februarie a anului 1929,patru barbati bine inarmati,dintre care doi erau deghizati in politisti,care nu pareau sa intre in atmosfera de Velentine’s Day.In schimb,acestia au intrat in garajul cu numarul 2122,care era locul de intalnire al mafiotilor din Morna North Side Gang.Pentru cateva momente,  s-au auzit focuri de arma ce au omorat sapte oameni,apoi cei imbracati in politisti au iesit alaturi de  doi infractori cu mainile sus.Obiectivul masacrului, ce se crede a fi orchestrat de “Al” Capone ,a fost liderul bandei mafioate irlandeze-Bags Moran- .Acesta se afla la o cafenea in timpul loviturii, spunand ca “numai Capone omoara asa”. Capone se afla in Florida in timpul masacrului.";
            }
            else if (nr == 91)
            {
                Prev1.Text = Environment.NewLine + P90.Text; Prev2.Text = Q90.Text;
                Next1.Text = Environment.NewLine + P92.Text; Next2.Text = Q92.Text;
                Title1.Text = P91.Text; Date1.Text = "|Perioada:" + Q91.Text;
                Countries1.Text = "|Anastase Dragomir";

                Descriere1.Text = "    Scaunul cu ejectie,echipat cu o paraşută, este folosit de toate avioanele de vânătoare din lume. Anastase Dragomir si Nastase Dobrescu,inventarii acestuia,au testat invenția ȋn anul 1929 ,mai intâi ȋn Franța , la aeroportul Paris-Orly , şi apoi in România,la aeroportul Băneasa. În anul următor, Dragomir și Dobrescu au obținut patentarea oficială a acelui  ”cockpit catapultabil” la Oficiul francez de invenții  2 aprilie 1930 (dar cu prioritatea patentării datată anterior la 3 noiembrie 1928";
            }
            else if (nr == 92)
            {
                Prev1.Text = Environment.NewLine + P91.Text; Prev2.Text = Q91.Text;
                Next1.Text = Environment.NewLine + P93.Text; Next2.Text = Q93.Text;
                Title1.Text = P92.Text; Date1.Text = "|Perioada:" + Q92.Text;
                Countries1.Text = "|Germania";

                Descriere1.Text = "  Preşedintele Paul von Hindenburg il numeşte pe Adolf Hitler Cancelarul guvernului Partidului Nazist şi Partidul Popular Național German . Partidul nazist este cel mai puternic partid din Reichstag, parlamentul național, dar necesită un partener de coaliție pentru a forma guvernul. Hitler folosește focul Reichstag în februarie 1933 pentru a pune în aplicare numeroase legi, care abolesc democrația și instituie o dictatură. După moartea lui Hindenburg, Hitler își asumă funcția și preia titlul cancelar Führer și Reich.";
            }
            else if (nr == 93)
            {
                Prev1.Text = Environment.NewLine + P92.Text; Prev2.Text = Q92.Text;
                Next1.Text = Environment.NewLine + P94.Text; Next2.Text = Q94.Text;
                Title1.Text = P93.Text; Date1.Text = "|Perioada:" + Q93.Text;
                Countries1.Text = "S.U.A.";

                Descriere1.Text = "    New Deal a fost o serie de programe economice adoptate in Statele Unite ale Americii,ca răspuns la Marea criză economică. Franklin Rooselvelt a incercat ,prin programul New Deal a incercat să dea tineretului mai multe locuri de muncă ,să ofere electricitate fermierilor,să ȋmbunătățească modul de funcționare al băncilor americane şi multe altele.New Deal-ul a reuşit să scoată o țară din impas. ";
            }
            else if (nr == 94)
            {
                Prev1.Text = Environment.NewLine + P93.Text; Prev2.Text = Q93.Text;
                Next1.Text = Environment.NewLine + P95.Text; Next2.Text = Q95.Text;
                Title1.Text = P94.Text; Date1.Text = "|Perioada:" + Q94.Text;
                Countries1.Text = "|România și U.R.S.S.";

                Descriere1.Text = "  Odată cu Revoluția Rusă din 1917,unul dintre obiectivele lui Lenin a fost părăsirea războiului  și guvernul bolșevic nu a fost invitat la Conferința de Pace; de aceea unirea Basarabiei cu România a fost recunoscută de marile puteri printr-un tratat separat semnat la Paris în 1920. Rusia sovietică, apoi URSS, au purtat unele negocieri cu România privind restabilirea rezervelor de aur și recunoașterea din 27 martie 1918 acționează la Copenhaga în 1920 și la Viena în 1924. Cu toate acestea, nici acestea, nici negocierile dintre 1934 și 1936 nu au reușit să rezolve problema Basarabiei din cauza opoziției sovietice. ";
            }
            else if (nr == 95)
            {
                Prev1.Text = Environment.NewLine + P94.Text; Prev2.Text = Q94.Text;
                Next1.Text = Environment.NewLine + P96.Text; Next2.Text = Q96.Text;
                Title1.Text = P95.Text; Date1.Text = "|Perioada:" + Q95.Text;
                Countries1.Text = "|Germania";

                Descriere1.Text = "   La doi ani de la preluarea puterii, statul Führer este înființat și toată opoziția democratică este eliminată. Legile de la Nürnberg sunt adoptate la miting-ul Partidului Nazist de la Nürnberg. Legile discriminează cetățenii evrei și îi exclud din viața publică din Reich, dand vina pe ei pentru toate problemele lumii si pentru infrangerea dureroasa a Germaniei. În viitor, de exemplu, căsătoriile sau relațiile sexuale între cetățeni evrei și neevrei sunt interzise. Legile de la Nürnberg formează ulterior baza persecuției continue a evreilor europe.";
            }
            else if (nr == 96)
            {
                Prev1.Text = Environment.NewLine + P95.Text; Prev2.Text = Q95.Text;
                Next1.Text = Environment.NewLine + P97.Text; Next2.Text = Q97.Text;
                Title1.Text = P96.Text; Date1.Text = "|Perioada:" + Q96.Text;
                Countries1.Text = "|Ungaria";

                Descriere1.Text = "  Pe măsură ce influența sa a crescut, Germania a fost modelul politic pentru noile state din Europa Centrală. Germania a profitat de faptul că tratatele de pace de la Versailles nu au rezolvat nici conflictele regiunii, nici problemele acesteia, care au fost agravate de prezența Uniunii Sovietice în Est. Mișcările radicale au luat avânt și în Ungaria. În timp ce primul decret antisemit s-a bazat pe religie, restricția din al doilea și al treilea decret anti-evreiesc a fost trasă pe bază de rasă.";
            }
            else if (nr == 97)
            {
                Prev1.Text = Environment.NewLine + P96.Text; Prev2.Text = Q96.Text;
                Next1.Text = Environment.NewLine + P98.Text; Next2.Text = Q98.Text;
                Title1.Text = P97.Text; Date1.Text = "|Perioada:" + Q97.Text;
                Countries1.Text = "|Germania";

                Descriere1.Text = "  Puterile victorioase din Primul Război Mondial nu sunt pregătite să intre în război pentru păstrarea libertății și a dreptății. După așa-numita anexare Anschluss a Austriei din martie, Hitler dorește să aducă și  regiunile din Munții Sudeti in care se vorbeste germană, o parte a Republicii Cehoslovace , „acasă la Reich” sub amenințare de violență. La München, Anglia, Franța, Italia și Germania sunt de acord cu ocuparea germană a acestui teritoriu.Cehoslovacia trebuie să respecte această rezoluție. Politicienii occidentali anunță cu încredere pacea pentru timpul nostru.";
            }
            else if (nr == 98)
            {
                Prev1.Text = Environment.NewLine + P97.Text; Prev2.Text = Q97.Text;
                Next1.Text = Environment.NewLine + P99.Text; Next2.Text = Q99.Text;
                Title1.Text = P98.Text; Date1.Text = "|Perioada:" + Q98.Text;
                Countries1.Text = "|Slovacia";

                Descriere1.Text = "  Politicienii din Partidul Popular Slovac al Hlinka au profitat de vidul dictatului post-München al Cehoslovaciei pentru a face cereri de autonomie a Slovaciei la o întâlnire de la Žilina. Ca urmare a noului val de probleme internaționale legate de drepturile națiunilor la autodeterminare, s-a discutat și despre autonomia slovacă în cadrul Ungariei sau al unui stat slovac separat, dar ambele concepte au fost respinse. Propunerea Partidului respectiv a fost acceptată și de partidele politice slovace de dreapta. Parlamentul cehoslovac a aprobat-o în noiembrie, iar Republica Cehoslovacă a devenit o triplă federație.";
            }
            else if (nr == 99)
            {
                Prev1.Text = Environment.NewLine + P98.Text; Prev2.Text = Q98.Text;
                Next1.Text = Environment.NewLine + P100.Text; Next2.Text = Q100.Text;
                Title1.Text = P99.Text; Date1.Text = "|Perioada:" + Q99.Text;
                Countries1.Text = "|Germania";

                Descriere1.Text = "  Un asasinat comis de un evreu polonez la Paris formează pretextul pentru pogromuri planificate de mult peste Reich. Peste trei zile, evreii sunt arestați, umiliți și bătuți. Mulți cetățeni evrei mor, iar sinagogile și magazinele evreiești sunt arse în toată Germania. Revoltele sunt organizate de ‘Sturm-Abteilungen’ (trupe de furtună sau SA). Cu toate acestea, în unele locuri, nemții care nu erau evrei încearcă să-i ajute pe evrei. În acest fel, de exemplu, un polițist a împiedicat distrugerea ‘Noii sinagogi’ din Berlin.";
            }
            else if (nr == 100)
            {
                Prev1.Text = Environment.NewLine + P99.Text; Prev2.Text = Q99.Text;
                Next1.Text = Environment.NewLine + P101.Text; Next2.Text = Q101.Text;
                Title1.Text = P100.Text; Date1.Text = "|Perioada:" + Q100.Text;
                Countries1.Text = "|Polonia";

                Descriere1.Text = "  Prepararea Germaniei pentru un război a inceput cu mult timp ȋn urma invaziei Poloniei,desfăsurată intre 1 septembrie şi 6 octombrie 1939. Hitler a vândut vechiul armament pentru a putea construi unul nou. “Fall Weiss” a fost planul Germaniei naziste de invadate cu succes Polonia din trei direcții .Drept răspuns,Franța şi Marea Britanie au declarat război Germnaia,dar niciuna nu a făcut nimic,cu frica repetării istoriei şi a unui război de tranşee sângeros şi costisitor.";
            }
            else if (nr == 101)
            {
                Prev1.Text = Environment.NewLine + P100.Text; Prev2.Text = Q100.Text;
                Next1.Text = Environment.NewLine + P102.Text; Next2.Text = Q102.Text;
                Title1.Text = P101.Text; Date1.Text = "|Perioada:" + Q101.Text;
                Countries1.Text = "|Polonia";

                Descriere1.Text = "  În timpul celui de-al doilea război mondial, mii de polonezi luptau pe diferite fronturi, oferindu-se voluntari ca membri ai unităților militare poloneze. Soldații polonezi au participat activ la luptele de apărare din Franța, bătălia aeriană a Marii Britanii, luptele pentru Tobruk și frontul italian în bătălia victorioasă, dar extrem de grea, pentru muntele și mănăstirea Monte Cassino.Ba chiar,un detasament polonez care a lutat cu britanicii , a luat un urs care,ulterior,a participat la cateva batalii. URSS a înființat și o unitate militară poloneză care îi trimitea pe polonezi pe front, printre altele, în bătălia de la Lenino și apoi în marșul asupra Berlinului.Guvernul s-a retras la Londra si,alaturi de comunitatea din diaspora, a facut presiuni mari pe Churchill si Rooselvelt sa negocieze la Ialta formarea unui stat polonez independent si democratic.";

            }
            else if (nr == 102)
            {
                Prev1.Text = Environment.NewLine + P101.Text; Prev2.Text = Q101.Text;
                Next1.Text = Environment.NewLine + P103.Text; Next2.Text = Q103.Text;
                Title1.Text = P102.Text; Date1.Text = "|Perioada:" + Q102.Text;
                Countries1.Text = "|Cehoslovacia";

                Descriere1.Text = "  În ziua de 15 martie 1939, trupele germane au ocupat Boemia și Moravia. Statul cehoslovac a dispărut de pe harta politică a Europei pentru aproape șase ani. Au fost înființate statul-marionetă Protectoratul Boemiei și Moraviei, care era sub controlul total al Germaniei Naziste, și Republica Slovacia, stat satelit al Reichului, dar care nu a fost ocupat de trupele germane. Statutul protectoratului Boemiei și Moraviei era stabilit de un ordin al lui Hitler din 16 martie 1939. Protectoratul Boemiei și Moraviei nu avea o reprezentare clară peste graniță și nici armată națională. Guvernul local avea mai degrabă un rol consultativ. ";

            }
            else if (nr == 103)
            {
                Prev1.Text = Environment.NewLine + P102.Text; Prev2.Text = Q102.Text;
                Next1.Text = Environment.NewLine + P104.Text; Next2.Text = Q104.Text;
                Title1.Text = P103.Text; Date1.Text = "|Perioada:" + Q103.Text;
                Countries1.Text = "|International";
                Descriere1.Visible = false;Descriere2.Visible = true;
                Descriere2.Text = "   Anul 1940, anul anexarilor si al cuceririlor teritoriale, schimba granitele Europei. Hitler pare de neorpit; invadeaza Luxemburg, Olanda, Belgia , iar Danemarca se preada in doar sase ore. Franta capituleaza in acest an,iar in Marea Britanie, Winston Churchill este numit premier.  In 62 de zile, Hitler invadeaza Norvegia pentru resursele de metal, pe care avea sa le foloseasca pentru a produce tancuri si munitie." + Environment.NewLine + "   Pe plan extern, Romania este inconjurata de vecini ostili si, izolata, se vede novoita sa cedeze din teritorii. Pe data de 26 iunie, URSS cere Nordul Bucovinei si toata Basarabia,iar Molotov transmite un ultimatum de 24 de ore. Romania nu putea faca fata unui conflict cu rusii (pierdem 50 de mii de km patrati).Pe 28 iunie, teritoriile sunt cedate –fara lupta- URSS-ului. Natiunea tine un minut de reculegere" + Environment.NewLine + "    Germania ne forteaza sa renuntam si la Transilvania de Nord si la Cadrilater, Hitler amenintand cu distrugerea Romaniei in caz contrar. Pe data de 30 august este semnat Dictatul de la Viena. Ministrul Manuilescu este socat de harta prezentata. Pe 7 septembrie, Cadrileterul i se cedeaza Bulgareiei.";
            }
            else if (nr == 104)
            {
                Prev1.Text = Environment.NewLine + P103.Text; Prev2.Text = Q103.Text;
                Next1.Text = Environment.NewLine + P105.Text; Next2.Text = Q105.Text;
                Title1.Text = P104.Text; Date1.Text = "|Perioada:" + Q104.Text;
                Countries1.Text = "|Germania nazistă și U.R.S.S.";

                Descriere1.Text = "  Dupa invadarea Poloniei, la data de 23 august 1939,ministrul de externe al Germaniei-Joachim von Ribbentrop- şi omologul lui sovietic-Veaceslav Mihailovici Molotov- au semnat un pact de neagresiune ȋn care au ȋmpărțit Europa ȋn sfere de influență germano-ruse. În urma Pactului, Polonia avea să fie ocupată de către cele două țări. ";
            }
            else if (nr == 105)
            {
                Prev1.Text = Environment.NewLine + P104.Text; Prev2.Text = Q104.Text;
                Next1.Text = Environment.NewLine + P106.Text; Next2.Text = Q106.Text;
                Title1.Text = P105.Text; Date1.Text = "|Perioada:" + Q105.Text;
                Countries1.Text = "|Finlanda și U.R.S.S.";

                Descriere1.Text = "  Iosif Stalin era ȋngrijorat de poziția Findlandei,care la acea vreme era foarte aproape de Leningrad. Stalin a cerut țării să cedeze URSS-ului teritoriul.Acesta a cerut ajutor Suediei,Franței şi Marii Britanii,dar fără success.Pe data de 30 noiembrie 1939,Stalin a invadat Finlanda, țară care a purtat un război de gherilă impotriva sovieticilor,la finalul căruia a fost nevoită să cedeze URSS-ului 11% din teritoriu.";
            }
            else if (nr == 106)
            {
                Prev1.Text = Environment.NewLine + P105.Text; Prev2.Text = Q105.Text;
                Next1.Text = Environment.NewLine + P107.Text; Next2.Text = Q107.Text;
                Title1.Text = P106.Text; Date1.Text = "|Perioada:" + Q106.Text;
                Countries1.Text = "|Germania";

                Descriere1.Text = "   În toamna anului 1939 a avut o ȋntâlnire hotărâtoare ȋntre doi ofițeri de Rang inalt:Erich von Manstein,un general berlinez cu temperament volcanic; şi Heinz Guderian ,un general specialist ȋn tancuri din Prusia Răsăriteană. Cei doi au pus la cale ceea ce avea să fie cunoscut ȋn istorie drept “Blitzkrieg”, un război fulger mânit să lovească acolo unde Aliatii se asteptau mai puțin.Cei doi s-au sfătuit că este bine ca Wehrmachtul să traverseze munții prin Ardeni,evitând astfel un război de uzură. Drogurile, menite sa soldatii treji,au jucat un rol important in castigarea acestui razboi. Nici Hitler,nic Winston Churchill nu le-a venit să creadă că Franța,cea mai mare putere de la aceea vreme,a fost cucerită ȋn doar câteva săptămâni.";
            }
            else if (nr == 107)
            {
                Prev1.Text = Environment.NewLine + P106.Text; Prev2.Text = Q106.Text;
                Next1.Text = Environment.NewLine + P108.Text; Next2.Text = Q108.Text;
                Title1.Text = P107.Text; Date1.Text = "|Perioada:" + Q107.Text;
                Countries1.Text = "|Germania";

                Descriere1.Text = "  În timpul invaziei Franței,Adolf Hitler,care s-a sfătuit cu Goring, a dat un mistros “ordin de oprire” la Dunqerque sub pretextul că va folosi Luftwaffe pentru a dobândi o victorie. Aliații au profitat din plin de această oportunitate,salvând peste 340 000 de soldați francezi, englezi şi belgieni. De abia după 11 zile,s-a dat ordine să continue invazia. Armata germană nu a găsit decât echipamentele englezilor şi 80.000 de soldați francezi care nu mai ȋncăpuseră pe navele engleze. ";
            }
            else if (nr == 108)
            {
                Prev1.Text = Environment.NewLine + P107.Text; Prev2.Text = Q107.Text;
                Next1.Text = Environment.NewLine + P109.Text; Next2.Text = Q109.Text;
                Title1.Text = P108.Text; Date1.Text = "|Perioada:" + Q108.Text;
                Countries1.Text = "|S.U.A.";

                Descriere1.Text = "    Legea privind împrumutul-închiriere,semnata la data de 11 martie 1941, a declarat că guvernul SUA ar putea împrumuta sau arenda provizii de război oricărei națiuni considerate „vitale pentru apărarea Statelor Unite”. Conform acestei politici, Statele Unite au fost în măsură să furnizeze ajutor militar aliaților săi străini în timpul Celui De Al Doilea Război Mondial, rămânând în continuare oficial neutri în conflict. "+Environment.NewLine+ "    Până la sfârșitul anului 1941, politica Lend-Lease a fost extinsă pentru a include și alți aliați americani, inclusiv China și Uniunea Sovietică. Până la sfârșitul celui de-al doilea război mondial, Statele Unite l-ar folosi pentru a oferi un ajutor de aproximativ 50 de miliarde de dolari în mai mult de 30 de națiuni din întreaga lume, din mișcarea liberă franceză condusă de Charles de Gaulle și guvernele în exil din Polonia, Olanda și Norvegia până în Australia, Noua Zeelandă, Brazilia, Paraguay și Peru.";
            }
            else if (nr == 109)
            {
                Prev1.Text = Environment.NewLine + P108.Text; Prev2.Text = Q108.Text;
                Next1.Text = Environment.NewLine + P110.Text; Next2.Text = Q110.Text;
                Title1.Text = P109.Text; Date1.Text = "|Perioada:" + Q109.Text;
                Countries1.Text = "|Italia și Grecia";

                Descriere1.Text = "   În incercarea dictatorului fascist Benito Mussolini de a reface Imperiul Roman, acesta a cucerit Nordul Africii cu succes.Apoi,şi-a ȋndreptat atenția spre Grecia,care era de o importanță uriaşă ȋn cucerirea spațiului din Mediterană.Folosindu-se de teritoriul albanez recent anexat,Mussolini a orchestrat Bătălia Greciei,cunoscută și ca Operațiunea Marița. Pe când grecii erau ȋnarmați foarte prost,marea majoritate a echipemntului era invechit,trupele italiene au fost incetinite de terenul stancos si de vremea neprielnică. Mentalitatea soldaților,asemănătoare celor din  Marele Război,a jucat un rol important ȋn acest război ȋn care Grecia,sprijinită de Marea Britanie,a ȋnvins Italia fascistă,pe care Hitler o ajuta. Hitler avea să dea mai târziu vina pe Mussolini pentru pierderea celui de- al Doliea Război Mondial.";
            }
            else if (nr == 110)
            {
                Prev1.Text = Environment.NewLine + P109.Text; Prev2.Text = Q109.Text;
                Next1.Text = Environment.NewLine + P111.Text; Next2.Text = Q111.Text;
                Title1.Text = P110.Text; Date1.Text = "|Perioada:" + Q110.Text;
                Countries1.Text = "|Germania și U.R.S.S.";

                Descriere1.Text = "  Deşi Hitler semnase cu Stalin un pact de neagresiune,acesta nu l-a respectat,invadând URSS la data de 22 iunie 1914,ȋn cadrul unei operatiuni care purta numele ȋmparatului româno - german Frederic Barbarossa(a trait intre 1112 - 1190). Asa cum şi Napoleon a fost ȋnfrânt de iarna rusească, Germania a repetat, suferind o ȋnfrângere umilitoare datorită condițiilor meteorologice neprielnice unei invazii.";
            }
            else if (nr == 111)
            {
                Prev1.Text = Environment.NewLine + P110.Text; Prev2.Text = Q110.Text;
                Next1.Text = Environment.NewLine + P112.Text; Next2.Text = Q112.Text;
                Title1.Text = P111.Text; Date1.Text = "|Perioada:" + Q111.Text;
                Countries1.Text = "|Marea Britanie";

                Descriere1.Text = "    În limba engleză “Special Air Sevice”(SAS) este o unitate militară ȋnființată de către ofițerul David Stirling in 1941, cu scopul de a o folosi ȋn campaniile militare din Africa din Nord.Prima ei misiune a fost Operațiunea Squater,care a fost un eşec.Britanici au ȋnvățat din propriile greşeli,iar SAS a devenit din ce ȋn ce mai puternică.Aceasta a fost desființată după Al Doliea Război Mondial şi reȋnființată şn 1947.";
            }
            else if (nr == 112)
            {
                Prev1.Text = Environment.NewLine + P111.Text; Prev2.Text = Q111.Text;
                Next1.Text = Environment.NewLine + P113.Text; Next2.Text = Q113.Text;
                Title1.Text = P112.Text; Date1.Text = "|Perioada:" + Q112.Text;
                Countries1.Text = "|Germania și U.R.S.S.";

                Descriere1.Text = "  In operațiunea lui Hitler de a invada URSS,acesta a asediat timp de 872 de zile oraşul Leningrad,astăzi Sankt Petersburg.Pentru apărare,ruşii s-au folosit de sârma ghimpata,fortificații defensive, obstacole de tot felul şi armament greu.Odată cu venirea iernii,trupele germane nu au putut rezista climatului dur ,acestea nefiind echipate corespunzător, iar Lacul Ladoga,odată inghetat,era folosit pentru a transporta bunuri şi oameni. Asediul Leningradului a sfârsit la data de 27 ianuarie 1944.";
            }
            else if (nr == 113)
            {
                Prev1.Text = Environment.NewLine + P112.Text; Prev2.Text = Q112.Text;
                Next1.Text = Environment.NewLine + P114.Text; Next2.Text = Q114.Text;
                Title1.Text = P113.Text; Date1.Text = "|Perioada:" + Q113.Text;
                Countries1.Text = "|S.U.A.";

                Descriere1.Text = "     Cauza atacului Pearl Harbour a stârnit,şi ȋncă mai stârneşte multe controverse,unele surse spunând că SUA a atacat o navă comercială japoneză,iar altele sustinând că japonezii au atacat primii,iar americanii au ripostat. Ce este ȋnsă sigur este că,la data de 7 decembrie 1941,piloții aviației japoneze au bombardat Pearl Harbour,distrugând jumătate din flota care se afla acolo.Numărul sufletelor pierdute se ridica la 2400.";
            }
            else if (nr == 114)
            {
                Prev1.Text = Environment.NewLine + P113.Text; Prev2.Text = Q113.Text;
                Next1.Text = Environment.NewLine + P115.Text; Next2.Text = Q115.Text;
                Title1.Text = P114.Text; Date1.Text = "|Perioada:" + Q114.Text;
                Countries1.Text = "|Germania și U.R.S.S.";

                Descriere1.Text = "   Prin Bătălia de la Stalingrad,Adolf Hitler a ȋncercat să asedieze oraşul,iar datorită faptului că purta numele dictatorului sovietic,să scadă moralul populației ruse.Bătălia a ținut doi ani lungi şi răi,ȋn care femeile şi copii din URSS au fost nevoiți să participe la bătălie,construind tranşee şi luptând ȋmpotriva nemților cu artilerie grea şi puşti cu luneta. După 163 de zile,Stalingradul a scăpat de sub trupele naziste, care l-au lăsat devastat.In urma Bătăliei de la Stalingrad,doar o singură clădire a mai rămas in picioare. ";
            }
            else if (nr == 115)
            {
                Prev1.Text = Environment.NewLine + P114.Text; Prev2.Text = Q114.Text;
                Next1.Text = Environment.NewLine + P116.Text; Next2.Text = Q116.Text;
                Title1.Text = P115.Text; Date1.Text = "|Perioada:" + Q115.Text;
                Countries1.Text = "|Germania";

                Descriere1.Text = "   Odată ocuparea unor porțiuni semnificative de teritoriu,incluzând Polonia,Norvegia,Franta,Cehoslovacia, Belgia si Danemarca,Hitler era ingrijorat de o intervenție a Aliațiilor pe frontul de Vest. Acesta a fost motivat să construiască de-a lungul coastei atlantice,o serie de fortificații menită să protejeze Germania ȋn acest scop.Zidul Atlanticului semăna cu Linia Magniot.Totuşi,acesta a fost penetrat cu uşurință pe  data de 6 iunie 1944.";
            }
            else if (nr == 116)
            {
                Prev1.Text = Environment.NewLine + P115.Text; Prev2.Text = Q115.Text;
                Next1.Text = Environment.NewLine + P117.Text; Next2.Text = Q117.Text;
                Title1.Text = P116.Text; Date1.Text = "|Perioada" + Q116.Text;
                Countries1.Text = "|Polonia";

                Descriere1.Text = "  Ocupanții germani i-au tratat pe evreii polonezi cu o cruzime deosebită. Hitler a căutat să extermine națiunea evreiască. Au fost înființate ghetouri unde trebuiau să locuiască evreii și apoi lagăre de concentrare unde erau uciși. Polonia a fost singura țară europeană în care ajutoarele evreilor au condamnat pedeapsa cu moartea atât pentru ajutor, cât și pentru familie. Răscoala din ghetoul de la Varșovia (19 aprilie 1943) a fost un mare act de eroism evreiesc, fiind condamnată să eșueze de la început. Luptătorii au preferat să moară cu brațele în mână.";
            }
            else if (nr == 117)
            {
                Prev1.Text = Environment.NewLine + P116.Text; Prev2.Text = Q116.Text;
                Next1.Text = Environment.NewLine + P118.Text; Next2.Text = Q118.Text;
                Title1.Text = P117.Text; Date1.Text = "|Perioada:" + Q117.Text;
                Countries1.Text = "|Italia";

                Descriere1.Text = "  În timpul Conferinței de două săptămâni din portul Casablanca,Winston Churhill a prezentat SUA propunerea lui ȋndrăzneață de a cuceri Italia fascist ,dând naştere astfel operațiunii Husky, desfăşurată intre  9 iul.1943–17 aug.1943. Trupe americane şi britanice din Africa din Nord au fost folosite pentru a cucerii Peninsula Italica. Datorita moralului foarte scazut al populatiei,au fost incidente in care italienii s-au predatat, au trecut de partea Aliațiilor sau pur şi simplu s-au retras,iar guvernul italian a părăsit Roma, lăsându-le pe Mussolini de unul singur.  ";
            }
            else if (nr == 118)
            {
                Prev1.Text = Environment.NewLine + P117.Text; Prev2.Text = Q117.Text;
                Next1.Text = Environment.NewLine + P119.Text; Next2.Text = Q119.Text;
                Title1.Text = P118.Text; Date1.Text = "|Perioada:" + Q118.Text;
                Countries1.Text = "|S.U.A, Regatul Unit și U.R.S.S.";
                Descriere1.Visible = false;Descriere2.Visible = true;
                Descriere2.Text = "  Conferința de la Teheran a fost organizată pentru punerea la punct a unor probleme privitoare la desfășurarea celui de-Al Doilea Război Mondial și organizarea lumii postbelice, ca urmare a victoriilor Aliaților. Principalele subiecte discutate, problema Germaniei postbelice, debarcarea din Normandia. Conferința de la Teheran a fost prima întâlnire a „Celor Trei Mari”."+Environment.NewLine+ "    În drum spre capitala iraniană, Franklin Delano Roosevelt și Winston Churchill s-au oprit la Cairo,unde s-au întâlnit cu Jiang Jieshi, conducătorul naționaliștilor chinezi. Cu această ocazie, cei trei au semnat o Declarație. În acest document, afirmau hotărârea neclintită de a purta război „pentru a pune capăt agresiunii Japoniei și de a-l pedepsi pe agresor, fără a tinde prin aceasta la obținerea unor avantaje pentru ele și fără să aibă cea mai mică intenție de extindere a teritoriilor lor”."+Environment.NewLine+ "    În privinţa Conferinţei de la Teheran, concluzia specialiștilor este că oricâte propuneri de bună-credinţă s-ar fi avansat, ele au fost rând pe rând refuzate, în funcţie de interesele care primau în zonele conflictuale, în funcţie de capacităţile de soluţionare pe care le aveau la îndemână, în funcţie de necesităţile care trebuia satisfăcute. Războiul era în plină desfăşurare. Armatele implicate în război făceau victime nevinovate. Oamenii politici nu se puteau pune de acord în privinţa obiectivelor importante ale conflictului.";

            }
            else if (nr == 119)
            {
                Prev1.Text = Environment.NewLine + P118.Text; Prev2.Text = Q118.Text;
                Next1.Text = Environment.NewLine + P120.Text; Next2.Text = Q120.Text;
                Title1.Text = P119.Text; Date1.Text = "|Perioada:" + Q119.Text;
                Countries1.Text = "|S.U.A.";

                Descriere1.Text = "  La data de 6 iunie 1944,Aliații au invadat teritoriul francez ocupat de Germania , penetrând Zidul Atlanticului menit să protejeze intreaga Germaniea nazistă de un astfel de atac. Trupe americane ,britanice ,dar şi canadiene(deoarece Canada făcea,şi ȋncă face parte din dominioanele Marii Britanii.). Acțiunea de invazie a Normandiei a avut un efect de cleşte asupra nemților,ȋncolțiti la Est de URSS şi la Vest la Aliați. Drept răspuns, Hitler a ordonat retragerea diviziilor de panzare în pădurea din apropiere. ";

            }
            else if (nr == 120)
            {
                Prev1.Text = Environment.NewLine + P119.Text; Prev2.Text = Q119.Text;
                Next1.Text = Environment.NewLine + P121.Text; Next2.Text = Q121.Text;
                Title1.Text = P120.Text; Date1.Text = "|Perioada:" + Q120.Text;
                Countries1.Text = "|Germania";

                Descriere1.Text = "  Când începe să fie clar că Reich pierde războiul, un cerc conservator extras din armată, aristocrație și oficiali planifică uciderea lui Hitler și o lovitură de stat. Colonelul Claus Schenk Graf von Stauffenberg plasează o bombă în „Bârlogul Lupului” (Wolfsschanze), un post de comandă din Prusia de Est. Bomba detonează, dar Hitler supraviețuiește. După încercarea eșuată de asasinat, putch-ul se destramă rapid. Conspiratorii sunt condamnați la moarte și executați. 20 iulie este acum o zi de comemorare în Germania.";

            }
            else if (nr == 121)
            {
                Prev1.Text = Environment.NewLine + P120.Text; Prev2.Text = Q120.Text;
                Next1.Text = Environment.NewLine + P122.Text; Next2.Text = Q122.Text;
                Title1.Text = P121.Text; Date1.Text = "|Perioada:" + Q121.Text;
                Countries1.Text = "|Polonia";

                Descriere1.Text = "  De-a lungul ocupației sovietice și germane, polonezii luptau împotriva invadatorilor participând la mișcarea de rezistență subterană (inițial Uniunea luptei armate, mai târziu armata de origine). Autoapărarea a fost organizată și cetățenii erau pregătiți pentru lupta viitoare. Operațiunile armate au venit și cu timpul. Au existat execuții ale unor criminali de război germani. În 1944, s-a organizat Răscoala de la Varșovia împotriva germanilor, unde peste 40.000 de soldați au luptat timp de două luni.In tot acest timp, trupele sovietice au asteptat la prtile Varsoviei si au lasat rezistenta sa se macelareasca cu nazistii.";


            }
            else if (nr == 122)
            {
                Prev1.Text = Environment.NewLine + P121.Text; Prev2.Text = Q121.Text;
                Next1.Text = Environment.NewLine + P123.Text; Next2.Text = Q123.Text;
                Title1.Text = P122.Text; Date1.Text = "|Perioada:" + Q122.Text;
                Countries1.Text = "|România";
                Descriere1.Visible = false;Descriere2.Visible = true;
                Descriere2.Text ="  In contextul in care Romania era furnizorul principal de combustibil al Germaniei Naziste, aliatii s-au decis pe 4 aprilie sa bombardeze Bucurestiul si rafinariile de petrol din jurul Ploiestului. Scopul bombardamentelor era sa rupa orice modalitate a Romaniei de a trimite petrol lui Hitler. "+Environment.NewLine+ "  Rezultatele dezastruoase ale participării României la războiul antisovietic au creat un profund sentiment de nemulțumire în interiorul țării. Coroborat cu presiuni externe dar si de bombardarea Bucurestiului si a rafinariilor din jurul Ploiestiului care furnizau combustibil nazistilor, acest lucru a condus la răsturnarea regimului Antonescu prin lovitura de stat din 23 august 1944. Acest act a fost urmat de aderarea României la coaliția aliaților în războiul antinazist. În același timp, însă, România a fost ocupată de Armata Roșie, care a devenit principalul instrument pentru transformarea țării într-un satelit sovietic.";

            }
            else if (nr == 123)
            {
                Prev1.Text = Environment.NewLine + P122.Text; Prev2.Text = Q122.Text;
                Next1.Text = Environment.NewLine + P124.Text; Next2.Text = Q124.Text;
                Title1.Text = P123.Text; Date1.Text = "|Perioada:" + Q123.Text;
                Countries1.Text = "|Slovacia";

                Descriere1.Text = "  Răscoala națională slovacă a fost punctul culminant al două fluxuri de rezistență slovacă - civică și comunistă - cu obiectivul clar de a se desprinde de Germania. Este una dintre cele mai mari răscoale europene de rezistență antifascistă din război. După ce răscoala a fost învinsă, partizanii au continuat să lupte în munți. Liderii răscoalei au manifestat voința de a reînnoi Republica Cehoslovacă, dar nu conform conceptului de pre-război al Cehoslovaciei, ci mai degrabă ca stat al națiunilor egale.";
            }
            else if (nr == 124)
            {
                Prev1.Text = Environment.NewLine + P123.Text; Prev2.Text = Q123.Text;
                Next1.Text = Environment.NewLine + P125.Text; Next2.Text = Q125.Text;
                Title1.Text = P124.Text; Date1.Text = "|Perioada:" + Q124.Text;
                
                Countries1.Text = "|S.U.A, Regatul Unit și U.R.S.S.";

                Descriere1.Text = "  În timpul Conferinței de la Mosova, Iosif Stalin şi Winston Churchill s-au ȋntâlnit la palatul Kremlin pentru a decide soarta Europei de Est, pe care au ȋmpărțit-o ȋn sfere britanico-ruse,ȋn  Marea Britanie avea să dețină 90% din puterea asupra Greciei,pentru că pierduseră 41 000 de soldați in 1941, rămânându-i lui Stalin doar 10%. Oferta lui Churchill a fost pregătită sub forma unui tabere .In România , URSS să aibă o influență de 90% ,iar Marea Britanie de 10%.Aceaste propuneri urmau să fie inversate ȋn cazul Greciei,iar Ungaria şi Iugoslavia aveau să fie ȋmpărțite ȋn mod egal,ȋn vreme ce URSS aveau să dețină trei sferturi din Bulgaria,ȋn timp ce Marea Britanie doar un sfert.";

            }
            else if (nr == 125)
            {
                Prev1.Text = Environment.NewLine + P124.Text; Prev2.Text = Q124.Text;
                Next1.Text = Environment.NewLine + P126.Text; Next2.Text = Q126.Text;
                Title1.Text = P125.Text; Date1.Text = "|Perioada:" + Q125.Text;
                Countries1.Text = "|S.U.A, Regatul Unit și U.R.S.S.";
                Descriere1.Visible = false;
                Descriere2.Visible = true;
                Descriere2.Font = new Font("Courier New", 11 );
                Descriere2.Text = "Decizii generale:"+Environment.NewLine+ "Națiunile Unite - s-a decis ca conferința de deschidere a ONU să aibă loc la 25 aprilie 1945 la San Francisco, cu delegații din toate țările care au semnat Declarația Națiunilor Unite. Trei Mari au fost de acord că deciziile consiliului de securitate (Marea Britanie, SUA, URSS, Franța, China) vor fi luate în unanimitate."+Environment.NewLine+ "Reparațiile din Germania - cei Trei Mari, incapabili să cadă de acord cu privire la problema reparațiilor, au decis să înființeze o Comisie de reparații care se va întruni la Moscova. Va decide cu privire la suma și forma reparațiilor pentru fiecare țară, cu prioritate acordată celor care au suferit cel mai mult și care au purtat sarcina principală a războiului."+Environment.NewLine+Environment.NewLine+ "Declarația privind Europa eliberată - Cei Trei Mari au emis declarația că națiunile eliberate din Europa au dreptul de a crea instituții democratice la alegerea lor. Cele trei guverne trebuiau să ajute și să asiste acest proces."+Environment.NewLine+Environment.NewLine+"Decizii despre state si granite:"+Environment.NewLine+ "Germania-Împărțirea Germaniei în 4 zone de ocupare. Franței i se va acorda o zonă și un loc în Comisia de control și pentru Germania. În viitor, Germania va rămâne dezmembrată și aliații vor înființa un comitet special pentru a decide cu privire la această chestiune."+Environment.NewLine+Environment.NewLine+ "Polonia-Va fi creat un nou guvern (Guvernul provizoriu al unității naționale), pe baza guvernului comunist creat deja în Polonia. Politicienii din alte partide ar trebui să fie incluși în acesta. Guvernul în exil din Londra nu mai era considerat un reprezentant legal al țării. Granița estică poloneză va fi stabilită pe „linia Curzon”, lăsând 1/3 din teritoriul polonez către URSS."+Environment.NewLine+Environment.NewLine+ "Iugoslavia - cei Trei Mari au decis să sprijine acordul dintre liderul partizan Josip Broz Tito și Ivan Subasić (prim-ministru în exil). Ar fi trebuit să creeze împreună un nou guvern."+Environment.NewLine+Environment.NewLine+ "Japonia - Insulele Kurile și Sahalinul de Sud vor fi date URSS după predarea Japoniei.";
            }
            else if (nr == 126)
            {
                Prev1.Text = Environment.NewLine + P125.Text; Prev2.Text = Q125.Text;
                Next1.Text = Environment.NewLine + P127.Text; Next2.Text = Q127.Text;
                Title1.Text = P126.Text; Date1.Text = "|Perioada:" + Q126.Text;
                Countries1.Text = "|Cehoslovacia";

                Descriere1.Text = "  Primul program guvernamental al reînnoitei Republici Cehoslovace a stabilit sarcini pentru guvern la sfârșitul războiului. De asemenea, a confirmat principiile care au devenit piloni ai sistemului „democrației oamenilor”, care a fost de fapt o conversie la noul regim totalitar. Acest program a rezultat din compromisurile dintre reprezentanții din centrele de rezistență străină din Londra și Moscova și din strategia inteligentă a comuniștilor slovaci și cehi întăriți, susținuți de Moscova. Acest lucru a diminuat co-egalitatea declarată slovacă-cehă.";
            }
            else if (nr == 127)
            {
                Prev1.Text = Environment.NewLine + P126.Text; Prev2.Text = Q126.Text;
                Next1.Text = Environment.NewLine + P128.Text; Next2.Text = Q128.Text;
                Title1.Text = P127.Text; Date1.Text = "|Perioada:" + Q127.Text;
                Countries1.Text = "|Germania";

                Descriere1.Text = "   Dupã multe lupte,trupele sovietice a ajuns ȋntr-un final la Berlin.  La 7 mai ,ora 02:40, generalul german Alfred Jodl a semnat actul de predare al Germaniei naziste.Actul a fost semnat de generalul-maior Ivan Susloparov (reprezentant al lui Stalin la Comandamentul Aliat) și din partea SUA de Generalul Beddel Smith. Capitularea Germaniei naziste a intrat în vigoare la 8 mai,in Europa,la ora 23:01,iar la Moscova,datorită diferenței de fust orar-in ziua de 9 mai.Winston Churchill, alaturi de Regele Geroge VI, a salutat poporul englez,in timp ce in Statele Unite fluturau steagurile , datorită perioadei de doliu de după moarte lui Rooselvelt.";
            }
            else if (nr == 128)
            {
                Prev1.Text = Environment.NewLine + P127.Text; Prev2.Text = Q127.Text;
                Next1.Text = Environment.NewLine + P129.Text; Next2.Text = Q129.Text;
                Title1.Text = P128.Text; Date1.Text = "|Perioada:" + Q128.Text;
                Countries1.Text = "|Polonia";

                Descriere1.Text = "  Nici guvernul polonez din timpul războiului din Londra, nici comanda HA din Polonia nu au recunoscut acordurile de la Yalta. Soldații HA au continuat o luptă de gherilă cu Armata Roșie și NKVD care ocupă Polonia. Pentru a combate rezistența, Stalin i-a invitat pe șaisprezece lideri ai statului clandestin la discuțiile de la Moscova și i-a arestat și condamnat la pedepse lungi de închisoare. Soldații HA au devenit „criminali” căutați de aparatul de securitate, torturați în închisori și uciși, în timp ce memoria eroilor a fost ștearsă.";
            }
            else if (nr == 129)
            {
                Prev1.Text = Environment.NewLine + P128.Text; Prev2.Text = Q128.Text;
                Next1.Text = Environment.NewLine + P130.Text; Next2.Text = Q130.Text;
                Title1.Text = P129.Text; Date1.Text = "|Perioada:" + Q129.Text;
                Countries1.Text = "|S.U.A, Regatul Unit și U.R.S.S.";
                Descriere1.Visible = false;
                Descriere2.Visible = true;
                Descriere2.Font = new Font("Courier New", 12);
                Descriere2.Text = "Decizii generale:"+Environment.NewLine+ "Germania-Germania vor fi guvernate de Comisia de control aliată. Țara va suferi următoarele modificări (denumite ulterior 4 'D'):"+Environment.NewLine+ "Demilitarizarea - distrugerea tuturor formațiunilor militare, armele care vor fi preluate de aliați, industria militară care va fi distrusă"+Environment.NewLine+ "Decartelizarea - restructurarea economiei de la grupurile mari de monopol (carteluri) la piața liberă"+Environment.NewLine+ "Denazificarea - distrugerea partidului nazist (NSDAP) și a tuturor instituțiilor afiliate acestuia pentru a eradica nazismul"+Environment.NewLine+ "Democratizarea - transformarea Germaniei înapoi într-o țară democratică"+Environment.NewLine+Environment.NewLine+ "Germania va fi împărțită de aliați în 4 zone de ocupație: britanici americani, francezi și sovietici. Berlinul care se afla în zona de ocupație sovietică va fi, de asemenea, împărțit în patru zone."+Environment.NewLine+Environment.NewLine+ "Austria - va fi împărțită în 4 zone de ocupații, precum și capitala Viena" + Environment.NewLine+ "Orașul Konigsberg și zona sa vor fi transferate către URSS."+Environment.NewLine+Environment.NewLine+ "Polonia - cea mai mare parte a frontierei de est confirmată pe „linia Curzon”. Fostele teritorii germane până la râul Oder și râul Neisse, cea mai mare parte a Prusiei de Est, precum și fostul oraș liber Danzig va fi sub administrația poloneză până la o soluționare a păcii.";
            
            }
            else if (nr == 130)
            {
                Prev1.Text = Environment.NewLine + P129.Text; Prev2.Text = Q129.Text;
                Next1.Text = Environment.NewLine + P131.Text; Next2.Text = Q131.Text;
                Title1.Text = P130.Text; Date1.Text = "|Perioada" + Q130.Text;
                Countries1.Text = "|Japonia";

                Descriere1.Text = "    La data de 16 iulie 1945, în deșertul New Mexico, a fost testată prima armă nucleară. Pe 6 august 1945, Hiroshima este bombardată cu o astfel de armă.Aceasta nu a capitulat inițial,ci de abia după The Fat Man a fost detunată deasupra oraşului Nagasaki. SUA au incheiat astfel Cel De Al Doilea Război Mondial,o perioadă prea sumbră din istoria omenirii,dar şi războiul purtat cu Japonia. Totuşi,ȋntre Japonia şi URSS nu a fost semnat niciun acord sau tratat,acestea rămânând “teoretic” in război,deşi “practic” nu mai aveau loc conflicte ȋntre cele două.";
            }
            else if (nr == 131)
            {
                Prev1.Text = Environment.NewLine + P130.Text; Prev2.Text = Q130.Text;
                Next1.Text = Environment.NewLine + P132.Text; Next2.Text = Q132.Text;
                Title1.Text = P131.Text; Date1.Text = "|Perioada" + Q131.Text;
                Countries1.Text = "|Germania";

                Descriere1.Text = "  Cel mai mare lagăr de concentrare și exterminare german operat de naziști se află în Auschwitz (astăzi Oświęcim). Din 1940, tabăra este condusă de Schutzstaffel sau SS. În lagăr, milioane de oameni sunt torturați și exploatați în condiții de nedescris. Numărul real de decese cauzate de malnutriție, boli și gaze este necunoscut, dar se presupune că aproximativ 1,5 milioane de victime au murit acolo. În Germania, data eliberării lagărelor este o zi de comemorare.";
            }
            else if (nr == 132)
            {
                Prev1.Text = Environment.NewLine + P131.Text; Prev2.Text = Q131.Text;
                Next1.Text = Environment.NewLine + P133.Text; Next2.Text = Q133.Text;
                Title1.Text = P132.Text; Date1.Text = "|Perioada" + Q132.Text;
                Countries1.Text = "|Germania";
                 
                Descriere1.Text = "  Procesele în fața unui tribunal militar internațional durează zece luni înainte de pronunțarea verdictelor. Doisprezece dintre cei 24 de acuzați sunt condamnați la moarte, alții primesc pedepse cu închisoarea. Toate atrocitățile comise de regimul nazist sunt detaliate în timpul procesului, chiar dacă unele secțiuni ale publicului german vor să suprime evenimentele. Procesul pentru crime de război Ulm Einsatzgruppen sau echipa morții din 1958 și traseele din 1963-65 din Frankfurt Auschwitz sporesc din nou conștientizarea germană a crimelor.";
            }
            else if (nr == 133)
            {
                Prev1.Text = Environment.NewLine + P132.Text; Prev2.Text = Q132.Text;
                Next1.Text = Environment.NewLine + P134.Text; Next2.Text = Q134.Text;
                Title1.Text = P133.Text; Date1.Text = "|Perioada:" + Q133.Text;
                Countries1.Text = "|Internațional";

                Descriere1.Text = "     Războiul Rece a fost,aşa cum ne transmite şi numele, o perioadă in care relațiile dintre superputerile lumii s-au inrăutatit,ajungând la apogeu ȋn timpul Crizei Rachetelor din Cuba,ȋn care URSS şi SUA s-au aflat la un pas de distanța de un conflict nuclear.Ambele părti au dat vina pe Conferința de la Ialta ,dar şi pe cea de la Moscova (şi care a fost semnat Acordul de Procentaj) pentru distrugerea relațiilor dintre țări, altădată bune. Odată cu dizolvarea URSS-ului ȋn 1991,Războiul s-a  ȋncheiat.";
            }
            else if (nr == 134)
            {
                Prev1.Text = Environment.NewLine + P133.Text; Prev2.Text = Q133.Text;
                Next1.Text = Environment.NewLine + P135.Text; Next2.Text = Q135.Text;
                Title1.Text = P134.Text; Date1.Text = "|Perioada:" + Q134.Text;
                Countries1.Text = "|România";

                Descriere1.Text = "  Lovitura de stat de la 30 decembrie 1947  reprezintă acțiunea ilegală, de forță, petrecută în perioada 30 decembrie 1947 - 3 ianuarie 1948 prin care comuniștii români, sprijiniți de ocupanții militari sovietici, au impus Regelui Mihai, prin șantaj și amenințare, semnarea unui act de abdicare, au proclamat Republica Populară Română și au silit Familia Regală să părăsească țara într-un exil forțat care a durat până în anul 1997.";
            }
            else if (nr == 135)
            {
                Prev1.Text = Environment.NewLine + P134.Text; Prev2.Text = Q134.Text;
                Next1.Text = Environment.NewLine + P136.Text; Next2.Text = Q136.Text;
                Title1.Text = P135.Text; Date1.Text = "|Perioada:" + Q135.Text;
                Countries1.Text = "|Internațional";

                Descriere1.Text = "  În iunie 1947, secretarul de stat american George Marshall și-a prezentat planul de reconstituire a economiei europene. Ajutorul urma să fie acordat sub formă de alimente, subvenții pentru achiziționarea de echipamente, îmbunătățirea sistemelor de transport, investiții etc. Propunerea, adoptată în aprilie 1948, a fost cunoscută sub numele de Planul Marshall sau Programul european de redresare. Administrația SUA a dorit redresarea economică și stabilizarea politică în Europa, inclusiv în Regatul Unit, Franța și Italia, care s-au confruntat cu dificultăți financiare după cel de-al doilea război mondial.";
            }
            else if (nr == 136)
            {
                Prev1.Text = Environment.NewLine + P135.Text; Prev2.Text = Q135.Text;
                Next1.Text = Environment.NewLine + P137.Text; Next2.Text = Q137.Text;
                Title1.Text = P136.Text; Date1.Text = "|Perioada:" + Q136.Text;
                Countries1.Text = "|Internațional";

                Descriere1.Text = "   Odată cu punerea ȋn aplicarea a Planului Marshall,creat de secretarul de stat  George Marshall, Uniunea Sovietică a fost nevoită sa creeze un sistem de ajutor reciproc asemănător.CAER-Consiliul de Ajutor Economic Reciproc- a fost initiațive Uniunii Sovietice şi includea : URSS , RDG, Bulgaria, Polonia, Cehoslovacia, Ungaria și România. Alte țări comuniste neeuropene (Mongolia, Cuba, Vietnam) au luat și ele parte în ultimii ani la unele sesiuni ale Consiliului. La activitatea CAER nu au luat parte Republica Populară Chineză, Coreea de Nord și Albania.  CAER nu a reușit să îndeplinească rolul pentru care fusese creat, în principal datorită sistemului planificat centralizat al economiei statelor member.";
            }
            else if (nr == 137)
            {
                Prev1.Text = Environment.NewLine + P136.Text; Prev2.Text = Q136.Text;
                Next1.Text = Environment.NewLine + P138.Text; Next2.Text = Q138.Text;
                Title1.Text = P137.Text; Date1.Text = "|Perioada:" + Q137.Text;
                Countries1.Text = "|România";
                Descriere1.Visible = false;Descriere2.Visible = true;
                Descriere2.Text = "  Republica Populară Română a fost numele oficial purtat de statul român de la abdicarea forțată a Regelui Mihai I al României, eveniment petrecut pe 30 decembrie 1947, până la adoptarea constituției din 1965 care proclama Republica Socialistă România , la 21 august 1965."+Environment.NewLine+ "  Din anul 1954 , grafia numelui țării a fost schimbată în Republica Populară Romînă, conform normelor ortografice din acea perioadă. În anul 1963 s-a revenit la scrierea cu „â” a numelui țării : Republica Populară Română."+Environment.NewLine+ "  Imnul de stat al Republicii Populare Române a fost Zdrobite cătușe, din 1948 până în 1953, schimbat apoi de Te slăvim, Românie! (care a rămas imn de stat și după proclamarea Republicii Socialiste România, până în anul 1977). Ambele au muzica scrisă de Matei Socor.";
            }
            else if (nr == 138)
            {
                Prev1.Text = Environment.NewLine + P137.Text; Prev2.Text = Q137.Text;
                Next1.Text = Environment.NewLine + P139.Text; Next2.Text = Q139.Text;
                Title1.Text = P138.Text; Date1.Text = "|Perioada:" + Q138.Text;
                Countries1.Text = "|România";

                Descriere1.Text = "  Rezistenţa armată a fost o formă de opoziţie manifestată în a doua parte a anilor 1940 şi în anii 1950, când pe teritoriul întregii ţări au fost create mai multe grupuri de partizani care au luptat cu arma în mână împotriva regimului comunist. Deşi a activat în condiţii dintre cele mai vitrege, mişcarea de rezistenţă a reuşit să supravieţuiască o perioadă relativ lungă, de circa un deceniu şi jumătate. La capătul acesteia, cei mai mulţi dintre membri săi au fost ucişi în confruntările cu trupele de securitate, arestaţi, condamnaţi la ani grei de închisoare sau executaţi.";
            }
            else if (nr == 139)
            {
                Prev1.Text = Environment.NewLine + P138.Text; Prev2.Text = Q138.Text;
                Next1.Text = Environment.NewLine + P140.Text; Next2.Text = Q140.Text;
                Title1.Text = P139.Text; Date1.Text = "|Perioada:" + Q139.Text;
                Countries1.Text = "|România";

                Descriere1.Text = "  La 11 iunie 1948 a fost adoptată legea privind naționalizarea întreprinderilor industriale, bancare, de asigurări, miniere și de transport. Această lege prevedea abolirea majorității proprietății private în domeniul economic. Mijloacele de producție și instrumentele financiare au fost transferate în mâinile statului sau, potrivit propagandei comuniste, au devenit proprietatea întregului popor.";
            }
            else if (nr == 140)
            {
                Prev1.Text = Environment.NewLine + P139.Text; Prev2.Text = Q139.Text;
                Next1.Text = Environment.NewLine + P141.Text; Next2.Text = Q141.Text;
                Title1.Text = P140.Text; Date1.Text = "|Perioada:" + Q140.Text;
                Countries1.Text = "|România";

                Descriere1.Text = "  Începutul procesului de colectivizare a agriculturii din România a fost decis în timpul Plenarii Comitetului Central PMR din 3 până la 5 martie 1949. Prin abolirea proprietății private a țăranilor statul comunist a urmărit abolirea relațiilor capitaliste din zonele rurale și preluarea controlului asupra întregii agriculturi. În timpul procesului de colectivizare, declarat finalizat în 1962, au avut loc mai multe revolte țărănești din cauza abuzurilor comise de autorități."+Environment.NewLine+ "  La 11 iunie 1948 a fost adoptată legea privind naționalizarea întreprinderilor industriale, bancare, de asigurări, miniere și de transport. Această lege prevedea abolirea majorității proprietății private în domeniul economic. Mijloacele de producție și instrumentele financiare au fost transferate în mâinile statului sau, potrivit propagandei comuniste, au devenit proprietatea întregului popor.";
            }
            else if (nr == 141)
            {
                Prev1.Text = Environment.NewLine + P140.Text; Prev2.Text = Q140.Text;
                Next1.Text = Environment.NewLine + P142.Text; Next2.Text = Q142.Text;
                Title1.Text = P141.Text; Date1.Text = "|Perioada:" + Q141.Text;
                Countries1.Text = "|Coreea și S.U.A";

                Descriere1.Text = "   După al Doilea Război Mondial,trupele sovietice ocupau nordul Coreei,ȋn timp ce americanii –sudul. Acestea au părăsit ulterior țara,care a fost impărtită ulterior in a doua.Motivați de mentalitatea de domino,adică dacă un stat nu se supune modelui american,atunci alte state vor lua exemplul care se răspândeşte ca o molimă. Odată cu invadarea Coreei de Sud,Harry Truman a fost nevoit să suprimeze această mişcare.Eisenhower,care a devenit preşedinte in 1953, a ȋncheiat conflictul";
            }
            else if (nr == 142)
            {
                Prev1.Text = Environment.NewLine + P141.Text; Prev2.Text = Q141.Text;
                Next1.Text = Environment.NewLine + P143.Text; Next2.Text = Q143.Text;
                Title1.Text = P142.Text; Date1.Text = "|Perioada:" + Q142.Text;
                Countries1.Text = "|Slovacia";

                Descriere1.Text = "  Biserica a rămas ultimul adversar serios al obiectivului Partidului Comunist de a institui o dictatură totalitară în Republica Cehoslovacă. Arată procesele demnitarilor bisericii cu scopul de a „dezvălui” biserica ca dușman de stat și Vaticanul ca instrument al „imperialismului american.” Astfel de procese în Slovacia aveau o natură specifică - pentru a oferi dovezi ale fiabilității și inutilității Slovaciei care rezistă unui sistem centralist. stat. Pași suplimentari împotriva bisericii au urmat încercărilor spectaculoase.";
            }
            else if (nr == 143)
            {
                Prev1.Text = Environment.NewLine + P142.Text; Prev2.Text = Q142.Text;
                Next1.Text = Environment.NewLine + P144.Text; Next2.Text = Q144.Text;
                Title1.Text = P143.Text; Date1.Text = "|Perioada:" + Q143.Text;
                Countries1.Text = "|Germania";

                Descriere1.Text = "  Când muncitorii angajați în construcția „Stalinallee” din Berlinul de Est protestează împotriva creșterii normelor lor de muncă și a standardelor de lucru, o revoltă populară se dezvoltă în toată RDG. Nemulțumirea față de lipsa economiei, opresiunea politică și conformitatea socială declanșează revolta civilă. Cu sprijinul tancurilor sovietice, Partidul Unității Socialiste din Germania (SED) zdrobește răscoala. În acest fel,SED continuă să păstreze puterea până în 1989.";
            }
            else if (nr == 144)
            {
                Prev1.Text = Environment.NewLine + P143.Text; Prev2.Text = Q143.Text;
                Next1.Text = Environment.NewLine + P145.Text; Next2.Text = Q145.Text;
                Title1.Text = P144.Text; Date1.Text = "|Perioada:" + Q144.Text;
                Countries1.Text = "|Europa de Est";

                Descriere1.Text = "   Odată cu devenirea Germaniei de Vest membră NATO, URSS s-a văzut nevoită să gasească o metodă de a se apăra de statele democratice. Folosindu-se de statele comuniste din Europa de Est ,care a reprezentat un tampon intre Uniunea Sovietică şi NATO. Pactul a fost semnat la data de 14 mai 1955,de Albania(care ulterior avea sa se retraga in 1968),Cehoslovacia,Polonia,Romania,Ungaria si URSS. Scopul acesta a fost de a creea ajutor comun pentru statele menționate,dar a fost folosit de către Uniunea Sovietică pentru a inăbuşi revolte ȋn statele satelit.";
            }
            else if (nr == 145)
            {
                Prev1.Text = Environment.NewLine + P144.Text; Prev2.Text = Q144.Text;
                Next1.Text = Environment.NewLine + P146.Text; Next2.Text = Q146.Text;
                Title1.Text = P145.Text; Date1.Text = "|Perioada:" + Q145.Text;
                Countries1.Text = "|România";

                Descriere1.Text = "  Organizația Tratatului de la Varșovia (1955-1991) a fost o alianță politică și militară a țărilor din Europa de Est condusă de URSS. Tratatul de la Varșovia a fost semnat la 14 mai 1955, ca un echilibru împotriva amenințării reprezentate de NATO. În anii 1960, România a început să conteste principiul comandamentului unificat în cadrul alianței și subordonarea armatei sale către o structură militară condusă de mareșali ai Uniunii Sovietice. În plus, după 1968, România nu a mai permis pe teritoriul său să aibă loc manevre militare comune comune ale armatelor din țările Tratatului de la Varșovia.";
            }
            else if (nr == 146)
            {
                Prev1.Text = Environment.NewLine + P145.Text; Prev2.Text = Q145.Text;
                Next1.Text = Environment.NewLine + P147.Text; Next2.Text = Q147.Text;
                Title1.Text = P146.Text; Date1.Text = "|Perioada:" + Q146.Text;
                Countries1.Text = "|Egipt, Franța și Regatul Unit";

                Descriere1.Text = "  Criza Suezului a fost precipitată de către deciziile din luna iulie a anului 1956 ale preşedintelui Egiptului, Gamal Abdel Nasser, care urmăreau naţionalizarea Canalului Suez, care era controlat de către Marea Britanie şi Franţa. Mai mult de două treimi din petrolul utilizat de către europeni era transportat prin acest canal ce leagă Marea Roşie de Marea Mediterană. În situaţia în care Franţa a obiectat faţă de sprijinirea de către Nasser a rebelilor din colonia francză Algeria, iar Israelul era angajat în bătălii sporadice cu Egiptul, Marea Britanie s-a alăturat acestora şi a avut loc o triplă invazie pe data de 29 octombrie 1956. Forţele armate ale Israelului au atacat Peninsula Sinai, iar două zile mai tâziu, susţinând că protejau canalul, forţele anglo-franceze au început bombardarea ţintelor egiptene. Pe 5 noiembrie, trupele de paraşutişti şi marina anglo-franceză au început să ocupe poziţii strategice din zona Canalului Suez. "+Environment.NewLine+ "    Forţele franco-engleze au părăsit Egiptul în decembrie 1956, iar cele ale Israelului în martie 1957. Ulterior, Egiptul a deschis canalul în vederea comerţului extern. Această criză a evidenţiat faptul că vechile puteri coloniale, Marea Britanie şi Franţa, au fost înlocuite de către forţa Statelor Unite şi a Uninii Sovietice.";
            }
            else if (nr == 147)
            {
                Prev1.Text = Environment.NewLine + P146.Text; Prev2.Text = Q146.Text;
                Next1.Text = Environment.NewLine + P148.Text; Next2.Text = Q148.Text;
                Title1.Text = P147.Text; Date1.Text = "|Perioada:" + Q147.Text;
                Countries1.Text = "|România";
                Descriere1.Text = "  În toamna anului 1956, influența evenimentelor din Ungaria s-a simțit și în România. Cele mai vizibile au fost mișcările în rândul studenților, dar nemulțumirea față de regim a fost exprimată la nivelul tuturor categoriilor sociale, inclusiv a armatei. Conducerea Partidului Muncitoresc Român a rămas unită, totuși, și printr-o politică vicleană de a combina măsuri de îmbunătățire a situației sociale și economice a populației cu măsuri represive, a reușit să țină lucrurile sub control. Când Nikita Hrușciov a decis să intervină cu forță pentru a pune capăt revoluției maghiare, liderii români au susținut această decizie. De asemenea, în conformitate cu Uniunea Sovietică și noul guvern maghiar condus de Janos Kadar, România a oferit azil pentru o vreme lui Imre Nagy și altor membri ai guvernului revoluționar.";

            }
            else if (nr == 148)
            {
                Prev1.Text = Environment.NewLine + P147.Text; Prev2.Text = Q147.Text;
                Next1.Text = Environment.NewLine + P149.Text; Next2.Text = Q149.Text;
                Title1.Text = P148.Text; Date1.Text = "|Perioada:" + Q148.Text;
                Countries1.Text = "|Ungaria";

                Descriere1.Text = "  Uniunea Sovietică a decis că evenimentele din Ungaria reprezintă o amenințare la adresa stabilității Blocului de Est. Criza de la Suez a atras atenția puterilor occidentale, iar Uniunea Sovietică a folosit forța militară pentru a zdrobi revoluția maghiară. Guvernul lui János Kádár, noul șef al partidului comunist maghiar, a etichetat revolta drept contrarevoluție și a luat represalii sângeroase. Imre Nagy, care a servit ca șef al guvernului în timpul revoluției, a fost condamnat la moarte și executat.";
            }
            else if (nr == 149)
            {
                Prev1.Text = Environment.NewLine + P148.Text; Prev2.Text = Q148.Text;
                Next1.Text = Environment.NewLine + P150.Text; Next2.Text = Q150.Text;
                Title1.Text = P149.Text; Date1.Text = "|" + Q149.Text;
                Countries1.Text = "|Internațional";
               
                Descriere1.Text = "  1960 este denumit Anul Africii datorită unei serii de evenimente care au avut loc în cursul anului - în principal independența a șaptesprezece națiuni africane - care au evidențiat sentimentele pan-africane în creștere pe continent. Anul a adus punctul culminant al mișcărilor de independență africane și apariția ulterioară a Africii ca forță majoră în Organizația Națiunilor Unite.Astfel,dominatia coloniala a Frantei si a Marii Britanii a luat sfarsit.";
            }
            else if (nr == 150)
            {
                Prev1.Text = Environment.NewLine + P149.Text; Prev2.Text = Q149.Text;
                Next1.Text = Environment.NewLine + P151.Text; Next2.Text = Q151.Text;
                Title1.Text = P150.Text; Date1.Text = "|Perioada:" + Q150.Text;
               
                Countries1.Text = "|Internațional";
                Descriere1.Visible = false; Descriere2.Visible = true;
                Descriere2.Text = "  La scurt timp dupa ce SUA au testat trei bombe atomice in Antrctica, a fost deschis pentru semnare la 1 decembrie 1959, și a intrat oficial în vigoare la 23 iunie 1961. militare pe continent. Tratatul a fost primul acord de control al armamentului semnat în timpul Războiului Rece.  Obiectivul principal al tratatului este cel de a asigura în interesul întregii omeniri că Antarctica va continua să fie pentru totdeauna utilizată exclusiv în scopuri pașnice și că nu va deveni scena sau obiectul discordiei internaționale. Tratatul interzice orice măsură de natură militară, dar nu și prezența personalului militar."+Environment.NewLine+ "   Impreună cu o serie de alte tratate colaterale,a reglementeaza relațiile internaționale în raport cu Antarctida, singurul continent de pe Pământ fără populație umană băștinașă. În acest tratat, Antarctica este definită ca fiind tot uscatul, împreună cu banchizele aflate la sud de paralela de 60° latitudine sudică. Tratatul, care a intrat în vigoare în 1961 fiind semnat în total de 47 de țări, face din Antarctica o rezervație științifică, stabilește libertatea de cercetare științifică și interzice activitățile Primii semnatari au fost cele 12 țări active în Antarctica în timpul Anului Geofizic Internațional 1957–1958 și care au acceptat invitația Statelor Unite la conferința la care acesta a fost negociat.Cele 12 țări aveau interese semnificative în Antarctica la acea vreme: Argentina, Australia, Belgia, Chile, Franța, Japonia, Noua Zeelandă, Norvegia, Africa de Sud, Uniunea Sovietică, Regatul Unit și Statele Unite.Aceste țări înființaseră peste 50 de stații antarctic pentru AGI.";
            }
            else if (nr == 151)
            {
                Prev1.Text = Environment.NewLine + P150.Text; Prev2.Text = Q150.Text;
                Next1.Text = Environment.NewLine + P152.Text; Next2.Text = Q152.Text;
                Title1.Text = P151.Text; Date1.Text = "|Perioada:" + Q151.Text;
                Countries1.Text = "|Germania";

                Descriere1.Text = "  Șeful statului RDG, Walter Albricht, anunță „Nimeni nu are intenția de a ridica un zid.” La scurt timp după aceea, sectorul sovietic din Berlin este totuși separat de sectoarele occidentale prin construirea unui zid. Construirea zidului pare să prevină exodul în masă al cetățenilor RDG nemulțumiți. „Zidul de protecție antifascist” este extins cu gardieni și arme automate într-o barieră de nepătruns. Zidul este responsabil pentru 138 de decese până în 1989. Denumirea metaforice de „Cortina de fier” a fost data de Winston Churchill care a anticipat ascensiunea comunistilor.";
            }
            else if (nr == 152)
            {
                Prev1.Text = Environment.NewLine + P151.Text; Prev2.Text = Q151.Text;
                Next1.Text = Environment.NewLine + P153.Text; Next2.Text = Q153.Text;
                Title1.Text = P152.Text; Date1.Text = "|Perioada:" + Q152.Text;
                Countries1.Text = "|Vietnamul de Nord(sprijinit de sovietici) și Vietnamul de Sud(sprijinit de S.U.A.)";

                Descriere1.Text = "  Războiul din Vietnam  a avut loc între 1 noiembrie 1961 și 30 aprilie 1975,odata cu căderea Saigonului. Războiul a fost purtat între Republica Democrată Vietnam (Vietnamul de Nord),  sprijinită de China și Uniunea Sovietică, și Republica Vietnam (Vietnamul de Sud), sprijinită de Statele Unite. Conflictul s-a încheiat cu înfrângerea Vietnamului de Sud și unificarea țării sub conducere comunistă. Trupele americane s-au retras din Vietnam, războiul fiind considerat unul dintre marile eșecuri ale politicii externe americane.";
            }
            else if (nr == 153)
            {
                Prev1.Text = Environment.NewLine + P152.Text; Prev2.Text = Q152.Text;
                Next1.Text = Environment.NewLine + P154.Text; Next2.Text = Q154.Text;
                Title1.Text = P153.Text; Date1.Text = "|Perioada:" + Q153.Text;
                Countries1.Text = "|S.U.A. , Cuba și U.R.S.S.";

                Descriere1.Text = "  Criza Rachetelor din Cuba a adus cele două puteri mondiale-SUA si URSS- pe punctul unui conflict nuclear. După ce Nikita Hrușciov a semnat un acord cu Fidel Castro prin care inarma Cuba cu bombe atomice.Preşedintele John F. Kennedy nu a protestat atunci când URSS a trimis in Cuba rachete sol-aer,dar nu şi când fotografii luate de avioane sofisticate au arătat ca țara dispunea de rachete nucleare. SUA au trecut ȋn stadiul de alertă DEFCON 2-insemnând un pas distanță față de războiul nuclear. Kennedy a reacționat rapid,impunând o blocadă Cubei şi negociind ȋn acelasi timp cu liderul sovietic ȋndepărtarea arsenalul de distrugere ȋn masă.";
            }
            else if (nr == 154)
            {
                Next2.Visible = false;
                Prev1.Text = Environment.NewLine + P153.Text; Prev2.Text = Q153.Text;
                Next1.Text =  P155.Text; 
                Title1.Text = P154.Text; Date1.Text = "|Perioada:" + Q154.Text;
                Countries1.Text = "|Orientul Mijlociu";

                Descriere1.Text = "  La 5 iunie 1967, la orele 7 dimineața, aviația israeliană declanșa “Operațiunea Focus”, distrugînd în răstimp de circa trei ore, în două mari valuri de bombardamente, aproximativ 310 aparate de luptă egiptene, practic întreaga forță aviatică egipteană, și pistele a 16 aeroporturi militare din Sinai și Egipt. Era începutul a ceea ce avea să intre în istorie ca „Războiul de Șase Zile”, un conflict militar între Israel și cele trei puteri arabe învecinate,in urma caruia   Israelul a preluat de la Siria controlul asupra regiunii Golan, Peninsula Sinai de la Egipt și Estul Ierusalimului de la Iordania.. În dimineața zilei de 7 iunie era anunțată cucerirea vechiului oraș al Ierusalimului și a localității Ramalah; flota israeliană ajungea în aceeași zi la Sharm-el-Sheik, în Golful Aquaba, a cărui închidere de către egipteni crease deja un ”casus bell”i. În aceeazi zi, liderul egiptean, Naser, refuza inițiativa Consiliului de Securitate ONU pentru o încetare a focului.";
            }
            else if (nr == 155)
            {
                Prev1.Text = Environment.NewLine + P154.Text; Prev2.Text = Q154.Text;
                Next1.Text = Environment.NewLine + P156.Text; Next2.Text = Q156.Text;
                Title1.Text = P155.Text; Date1.Text = "|1968" ;
                Countries1.Text = "|Internațional";

                Descriere1.Text = "  Evenimentele din Cehoslovacia au agitat considerabil Polonia. În speranța unei mai multe democrații, intelectualii și studenții au intrat în grevă. Protestele au fost declanșate direct de interzicerea spectacolului teatral al epopeii naționale poloneze - „Dziady” a lui Mickiewicz. Studenții au fost înăbușiți brutal de către ZOMO și forțele miliției. Protestele au fost folosite de autoritățile comuniste ca pretext pentru contracararea antidemocratică și antisemită.";
            }
            else if (nr == 156)
            {
                Prev2.Visible = false;
                Prev1.Text =  P155.Text; 
                Next1.Text = Environment.NewLine + P157.Text; Next2.Text = Q157.Text;
                Title1.Text = P156.Text; Date1.Text = "|Perioada:" + Q156.Text;
                Countries1.Text = "|Cehoslovacia";

                Descriere1.Text = "  Primăvara de la Praga a fost o perioadă de libertate politică din Cehoslovacia, care a început în primăvara anului 1968, atunci când a venit la putere Alexander Dubček și a durat până în 20 august, același an, când a avut loc invazia Cehoslovaciei de către statele Pactului de la Varșovia, cu excepția RPS Albania și a Republicii Socialiste România.";
            }
            else if (nr == 157)
            {
                Prev1.Text = Environment.NewLine + P156.Text; Prev2.Text = Q156.Text;
                Next1.Text = Environment.NewLine + P158.Text; Next2.Text = Q158.Text;
                Title1.Text = P157.Text; Date1.Text = "|Perioada:" + Q157.Text;
                Countries1.Text = "|Cehoslovacia";

                Descriere1.Text = "  Invazia Cehoslovaciei, oficial Operațiunea Dunărea, a fost ocuparea Republicii Socialiste Cehoslovace de către forțe armate din cinci state membre în Pactul de la Varșovia - Uniunea Sovietică, R.P. Bulgaria, R.P. Ungară, RDG și R.P. Polonă – în noaptea de 20–21 august 1968. Aproximativ 250.000 de soldați au ocupat atunci Cehoslovacia. Două state membre ale Pactului de la Varșovia, anume Albania și România, au refuzat să participe. Forțele est-germane nu au participat nici ele la invazie, cu excepția câtorva specialiști, după ce Moscova le-a ordonat cu doar câteva ore înaintea invaziei să nu treacă granița cu Cehoslovacia. 137 de civili cehoslovaci au fost uciș și 500 au fost grav răniți în timpul ocupației. ";
            }
            else if (nr == 158)
            {
                Prev1.Text = Environment.NewLine + P157.Text; Prev2.Text = Q157.Text;
                Next1.Text = Environment.NewLine + P159.Text; Next2.Text = Q159.Text;
                Title1.Text = P158.Text; Date1.Text = "|Perioada:" + Q158.Text;
                Countries1.Text = "|România";

                Descriere1.Text = "  În noaptea de 20/21 august 1968, trupele a cinci state membre ale Tratatului de la Varşovia au pătruns în Ceholsovacia pentru a pune capăt „Primăverii de la Praga”.  În aceste condiţii, regimul de la Bucureşti a condamnat public, în termeni răspicaţi, intervenţia, afirmându-şi  solidaritatea cu poporul ceh şi slovac. În faţa unei posibile intervenţii sovetice şi în România, regimul de la Bucureşti a mobilizat armata, a creat gărzi patriotice înarmate şi a căutat să afle în ce măsură putea primi sprijin internaţional. Acest eveniment l-a determinat pe Ceausescu sa construiasca Transfagarasanul si sa transforme Serviciul de Securitate intr-o armata de gherila.";
            }
            else if (nr == 159)
            {
                Prev1.Text = Environment.NewLine + P158.Text; Prev2.Text = Q158.Text;
                Next1.Text = Environment.NewLine + P160.Text; Next2.Text = Q160.Text;
                Title1.Text = P159.Text; Date1.Text = "|Perioada:" + Q159.Text;
                Countries1.Text = "|România";
                Descriere1.Visible = false;Descriere2.Visible = true;
                Descriere2.Text = "  Poate unul dintre cele cele mai frumoase drumuri din lume,Transfăgărășanul a fost construit între anii 1970 – 1974, la inițiativa lui Nicolae Ceaușescu. Deși la momentul respectiv România avea deja mai multe treceri ale Carpaților Meridionali moștenite dinainte de perioada comunistă (Șoseaua Alpină Novaci-Săliște ori vechea Șosea Câmpina-Predeal) sau făcute în primii ani ai regimului (drumul Bumbești Jiu-Petroșani), invazia Cehoslovaciei din 1968 de către trupele sovietice și ușurința cu care puteau fi blocate sau atacate trecerile existente între Transilvania și Muntenia (care, cu o singură excepție, urmau cursul unor râuri) determină inițierea de urgență a proiectului Transfăgărășanului - un drum strategic care să lege garnizoanele Piteștiului și Sibiului. "+Environment.NewLine+ "    În notele de fundamentare ale proiectului se menționează, totodată, ca motive deschiderea bazinelor forestiere din masivul Făgăraș, folosirea mai rațională a pășunilor alpine și realizarea unui centru turistic montan în zona Lacului Bâlea.Tunelul Capra - Bâlea este cel mai lung din România, cu o lungime de 887.Pentru relizarea drumului s - au folosit 20 de tone de dinamită";
            }
            else if (nr == 160)
            {
                Prev1.Text = Environment.NewLine + P159.Text; Prev2.Text = Q159.Text;
                Next1.Text = Environment.NewLine + P161.Text; Next2.Text = Q161.Text;
                Title1.Text = P160.Text; Date1.Text = "|Perioada:" + Q160.Text;
                Countries1.Text = "|Gruparea Septembrie Negru";

                Descriere1.Text = "    La 4:30 AM 5sept.1972 , când sportivii dormeau, 8 membri ai grupării teroriste Septembrie Negru, îmbrăcați în treninguri negre, și purtând sacoșe pline cu armament, s-au cățărat peste gardul înalt de 2 metri și au intrat, cu ajutorul unor chei furate, în clădirea din Connolystraße nr. 31, unde erau cazați atleții israelieni.Rezultatul masacrului a fost moartea tuturor celor 11 membri ai delegației sportive israeliene și a unui polițist vest-german. 5 din cei 8 teroriști, membri ai grupului palestinian Septembrie Negru, au fost și ei uciși de polițiști vest-germani în cadrul unei încercări eșuate de a-i elibera pe ostatecii israelieni. Drept răzbunare, Israelul a efectuat două operațiuni: o infiltrare în Liban în 1973, operațiune cunoscută sub numele de „Primăvara tinereții” și operațiunea „Mânia lui Dumnezeu” ,operațiune care se pare că a durat timp de mai mulți ani.";
            }
            else if (nr == 161)
            {
                Prev1.Text = Environment.NewLine + P160.Text; Prev2.Text = Q160.Text;
                Next1.Text = Environment.NewLine + P162.Text; Next2.Text = Q162.Text;
                Title1.Text = P161.Text; Date1.Text = "|Perioada:" + Q161.Text;
                Countries1.Text = "|Orientul Mijlociu";
                Descriere1.Visible = false;Descriere2.Visible = true;
                Descriere2.Text = "    Războiului de Yom Kippur nu a fost decât efectul Războiului celor Șase zile din iunie 1967, atunci când Forțele de Apărare ale Israelului  au preluat controlul asupra regiunilor Golan, Peninsula Sinai și Estul Ierusalimului."+Environment.NewLine+ "      Fara niciun avertisment, 222 de avioane de tip MIG si Suhoi au acoperit cerul albastru de vara si au pulverizat in cateva minute defensiva israeliana de pe flancul estic al Canalului Suez. Simultan, la cateva sute de kilometri mai la nord, dealurile regiunii Golan erau zguduite de exploziile produse de bombele aruncate de MIG-urile siriene. 900 de tancuri și 40,000 de trupe de infanterie pătrundeau pe teritoriul Israelului. "+Environment.NewLine+ "  Prețurile petrolului au sărit în aer iar spectrul unui război nuclear se vedea cu ochiul liber. Cu toate că acest conflict nu a durat decât o lună de zile, bătălia a avut un impact enorm și nu numai în Orientul Mijlociu.";
            }
            else if (nr == 162)
            {
                Prev1.Text = Environment.NewLine + P161.Text; Prev2.Text = Q161.Text;
                Next1.Text = Environment.NewLine + P163.Text; Next2.Text = Q163.Text;
                Title1.Text = P162.Text; Date1.Text = "|Perioada:" + Q162.Text;
                Countries1.Text = "|Polonia";

                Descriere1.Text = "  În 1976 s-au reînnoit protestele muncitorilor, în Radom și Ursus, cu miliția suprimându-i brutal. Mulți muncitori au fost reținuți sau bătuți. După aceea, un grup de activiști de opoziție au decis să înființeze Comitetul de Apărare a Muncitorilor, care a devenit baza opoziției democratice poloneze. Aproape simultan, au apărut alte organizații bazate pe opoziție, cum ar fi Mișcarea pentru apărarea drepturilor omului și civice și Confederația Poloniei Independente.";
            }
            else if (nr == 163)
            {
                Prev1.Text = Environment.NewLine + P162.Text; Prev2.Text = Q162.Text;
                Next1.Text = Environment.NewLine + P164.Text; Next2.Text = Q164.Text;
                Title1.Text = P163.Text; Date1.Text = "|Perioada:" + Q163.Text;
                Countries1.Text = "|Iran și S.U.A.";

                Descriere1.Text = "  Criza ostaticilor din Iran a reprezentat un conflict diplomatic între Statele Unite și Iran. Cincizeci și doi de diplomați și cetățeni americani au fost ținuți ostatici după ce un grup de studenți iranieni aparținând studenți musulmani adepți ai liniei Iman care au sprijinit revoluția Iraniană, au preluat ambasada Statelor Unite ale Americii la Teheran şi ostatici confiscați. Ostaticii au fost ținuți 444 de zile de la 4 noiembrie 1979 până la 20 ianuarie 1981.";
            }
            else if (nr == 164)
            {
                Prev1.Text = Environment.NewLine + P163.Text; Prev2.Text = Q163.Text;
                Next1.Text = Environment.NewLine + P165.Text; Next2.Text = Q165.Text;
                Title1.Text = P164.Text; Date1.Text = "|Perioada:" + Q164.Text;
                Countries1.Text = "|Afganistan și U.R.S.S.";

                Descriere1.Text = "  In decembrie 1979,trupele sovitice au intrat in Afganistan in incercarea de a raspandi comunismul.Intervenția Uniunii Sovietice, așa cum era ea denumită de cealaltă parte a Cortinei de Fier, a ucis două milioane de afgani, a determinat alți șapte să fugă, alături de moartea a peste 14.000 de soldați sovietici.Operatiune orchestrata de URSS s-a dovedit a fi foarte costisitoare si aproape ca a sfaramat relatiile dintre aceasta si SUA. Mihail Gorbaciov a vazut invadarea Afganistanului drept o lovitura la economia fragila a Rusiei,iar oamenii erau satuli de un razboi sangeros.Chiar daca in 1989 trupele s-au retras, musulmanii rebeli au preluat cu succes controlul asupra Afganistanului.";
            }
            else if (nr == 165)
            {
                Prev1.Text = Environment.NewLine + P164.Text; Prev2.Text = Q164.Text;
                Next1.Text = Environment.NewLine + P166.Text; Next2.Text = Q166.Text;
                Title1.Text = P165.Text; Date1.Text = "|Perioada:" + Q165.Text;
                Countries1.Text = "|China";
                Descriere1.Visible = false;Descriere2.Visible = true;
                Descriere2.Text = "  Pe 4 iunie 1989, tancurile au luat cu asalt străzile capitalei chineze Beijing, pentru a dizolva protestele pașnice din Piața Păcii Divine (Tiananmen). Studenții și alți locuitori manifestau de mai multe săptămâni cerând reforme democratice. La sfârșitul lui aprilie, zeci de mii de locuitori ai Beijingului se solidarizaseră cu cei 100.000 de studenți care protestau pe stradă. Mișcarea a atins multe alte orașe din China. „Peste tot se auzeau focuri de armă. Era ca pe un câmp de război”. Rezistența curajoasă a multor cetățeni chinezi a permis retragerea pașnică din piață a majorității studenților.Supraviețuitorii nu erau însă defel în siguranță. Guvernul chinez a făcut totul pentru a-i aresta mai ales pe liderii studenților. Mulți au fugit în străinătate, mai ales în SUA și Franța. Cei mai puțin norocoși, au făcut ani grei de închisoare, până când China a cedat presiunilor internaționale și le-a permis celor arestați să părăsească țara."+Environment.NewLine+ "  Dupa mascara,gurvernul chinez a trimis facturi familiilor protestatarilor pentru plata gloantelor folosite de aramata.";
            }
            else if (nr == 166)
            {
                Prev1.Text = Environment.NewLine + P165.Text; Prev2.Text = Q165.Text;
                Next1.Text = Environment.NewLine + P167.Text; Next2.Text = Q167.Text;
                Title1.Text = P166.Text; Date1.Text = "|Perioada:" + Q166.Text;
                Countries1.Text = "|Germania";

                Descriere1.Text = "  Încurajați de politicile de reformă ale Uniunii Sovietice, cetățenii est-germani încep și ei să protesteze. Exodul în masă al cetățenilor RDG prin Ungaria și Cehoslovacia și demonstrațiile de luni de la Leipzig plasează conducerea statului sub o presiune enormă. Într-o conferință de presă neînțelegere, oficialul partidului SED, Günther Schabowski, anunță introducerea imediată a libertății de circulație pentru cetățenii RDG. Mii de oameni se înghesuie direct la punctele de trecere a frontierei din Berlin. Zidul a căzut.";
            }
            else if (nr == 167)
            {
                Prev1.Text = Environment.NewLine + P166.Text; Prev2.Text = Q166.Text;
                Next1.Text = Environment.NewLine + P168.Text; Next2.Text = Q168.Text;
                Title1.Text = P167.Text; Date1.Text = "|Perioada:" + Q167.Text;
                Countries1.Text = "|România";

                Descriere1.Text = "  Revoluția Română din 1989 a constat într-o serie de proteste, lupte de stradă și demonstrații desfășurate în România, între 16 și 25 decembrie 1989, care au dus la căderea dictatorului Nicolae Ceaușescu și la sfârșitul regimului comunist din România.  Demonstrațiile din ce în ce mai ample au culminat cu procesul și execuția soților Ceaușescu.  Înainte de revoluția română, toate celelalte state est-europene trecuseră în mod pașnic la democrație; România a fost singura țară din blocul estic care a trecut printr-o revoluție violentă și în care conducătorii comuniști au fost executați.";
            }
            else if (nr == 168)
            {
                Prev1.Text = Environment.NewLine + P167.Text; Prev2.Text = Q167.Text;
                Next1.Text = Environment.NewLine + P169.Text; Next2.Text = Q169.Text;
                Title1.Text = P168.Text; Date1.Text = "|Perioada:" + Q168.Text;
                Countries1.Text = "|Germania";

                Descriere1.Text = "  La miezul nopții, 3 octombrie, are loc Reunificarea Germaniei odată cu aderarea fostei RDG la Republica Federală Germania. Sute de mii se adună pentru a sărbători la Berlin cu artificii și muzică de sărbătoare. Odată cu punerea în aplicare a „Acordului Two Plus Four” la 15 martie 1991 între cele două state germane și fostele forțe de ocupație, Germania își recapătă suveranitatea deplină a statului. 3 octombrie este acum sărbătorită ca o sărbătoare publică, „Ziua unității germane”.";
            }
            else if (nr == 169)
            {
                Next1.Visible=Next2.Visible = false;
                Prev1.Text = Environment.NewLine + P168.Text; Prev2.Text = Q168.Text;
             
                Date1.Text = "|Perioada:" + Q169.Text;
                Countries1.Text = "|URSS";

                Descriere1.Text = "  Independența țărilor est-central europene, sigilată odată cu dizolvarea Pactului de la Varșovia în 1991, în timp ce URSS a fost afectată de criză, a făcut posibilă reunificarea Germaniei. Aceste evenimente au dus, de asemenea, la dizolvarea URSS în decembrie a aceluiasi an și la apariția unui număr de țări post-sovietice pe teritoriul său. Moștenirea URSS sub formă de acorduri internaționale, în principal în ceea ce privește armele nucleare, a fost preluată de Federația Rusă, încă blocată într-o criză.";
            }
           
            
        }


        



        private void OnMouseEnterP1(object sender, EventArgs e)
        {
            P1.BackColor = Q1.BackColor = Color.FromArgb(x1, y1, z1);
            P1.ForeColor = Q1.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP1(object sender, EventArgs e)
        {
            P1.BackColor = Q1.BackColor = Color.FromArgb(x2, y2, z2);
            P1.ForeColor = Q1.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP2(object sender, EventArgs e)
        {
            P2.BackColor = Q2.BackColor = Color.FromArgb(x1, y1, z1);
            P2.ForeColor = Q2.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP2(object sender, EventArgs e)
        {
            P2.BackColor = Q2.BackColor = Color.FromArgb(x2, y2, z2);
            P2.ForeColor = Q2.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP3(object sender, EventArgs e)
        {
            P3.BackColor = Q3.BackColor = Color.FromArgb(x1, y1, z1);
            P3.ForeColor = Q3.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP3(object sender, EventArgs e)
        {
            P3.BackColor = Q3.BackColor = Color.FromArgb(x2, y2, z2);
            P3.ForeColor = Q3.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP4(object sender, EventArgs e)
        {
            P4.BackColor = Q4.BackColor = Color.FromArgb(x1, y1, z1);
            P4.ForeColor = Q4.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP4(object sender, EventArgs e)
        {
            P4.BackColor = Q4.BackColor = Color.FromArgb(x2, y2, z2);
            P4.ForeColor = Q4.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP5(object sender, EventArgs e)
        {
            P5.BackColor = Q5.BackColor = Color.FromArgb(x1, y1, z1);
            P5.ForeColor = Q5.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP5(object sender, EventArgs e)
        {
            P5.BackColor = Q5.BackColor = Color.FromArgb(x2, y2, z2);
            P5.ForeColor = Q5.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP6(object sender, EventArgs e)
        {
            P6.BackColor = Q6.BackColor = Color.FromArgb(x1, y1, z1);
            P6.ForeColor = Q6.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP6(object sender, EventArgs e)
        {
            P6.BackColor = Q6.BackColor = Color.FromArgb(x2, y2, z2);
            P6.ForeColor = Q6.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP7(object sender, EventArgs e)
        {
            P7.BackColor = Q7.BackColor = Color.FromArgb(x1, y1, z1);
            P7.ForeColor = Q7.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP7(object sender, EventArgs e)
        {
            P7.BackColor = Q7.BackColor = Color.FromArgb(x2, y2, z2);
            P7.ForeColor = Q7.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP8(object sender, EventArgs e)
        {
            P8.BackColor = Q8.BackColor = Color.FromArgb(x1, y1, z1);
            P8.ForeColor = Q8.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP8(object sender, EventArgs e)
        {
            P8.BackColor = Q8.BackColor = Color.FromArgb(x2, y2, z2);
            P8.ForeColor = Q8.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP9(object sender, EventArgs e)
        {
            P9.BackColor = Q9.BackColor = Color.FromArgb(x1, y1, z1);
            P9.ForeColor = Q9.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP9(object sender, EventArgs e)
        {
            P9.BackColor = Q9.BackColor = Color.FromArgb(x2, y2, z2);
            P9.ForeColor = Q9.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP10(object sender, EventArgs e)
        {
            P10.BackColor = Q10.BackColor = Color.FromArgb(x1, y1, z1);
            P10.ForeColor = Q10.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP10(object sender, EventArgs e)
        {
            P10.BackColor = Q10.BackColor = Color.FromArgb(x2, y2, z2);
            P10.ForeColor = Q10.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP11(object sender, EventArgs e)
        {
            P11.BackColor = Q11.BackColor = Color.FromArgb(x1, y1, z1);
            P11.ForeColor = Q11.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP11(object sender, EventArgs e)
        {
            P11.BackColor = Q11.BackColor = Color.FromArgb(x2, y2, z2);
            P11.ForeColor = Q11.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP12(object sender, EventArgs e)
        {
            P12.BackColor = Q12.BackColor = Color.FromArgb(x1, y1, z1);
            P12.ForeColor = Q12.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP12(object sender, EventArgs e)
        {
            P12.BackColor = Q12.BackColor = Color.FromArgb(x2, y2, z2);
            P12.ForeColor = Q12.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP13(object sender, EventArgs e)
        {
            P13.BackColor = Q13.BackColor = Color.FromArgb(x1, y1, z1);
            P13.ForeColor = Q13.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP13(object sender, EventArgs e)
        {
            P13.BackColor = Q13.BackColor = Color.FromArgb(x2, y2, z2);
            P13.ForeColor = Q13.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP14(object sender, EventArgs e)
        {
            P14.BackColor = Q14.BackColor = Color.FromArgb(x1, y1, z1);
            P14.ForeColor = Q14.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP14(object sender, EventArgs e)
        {
            P14.BackColor = Q14.BackColor = Color.FromArgb(x2, y2, z2);
            P14.ForeColor = Q14.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP15(object sender, EventArgs e)
        {
            P15.BackColor = Q15.BackColor = Color.FromArgb(x1, y1, z1);
            P15.ForeColor = Q15.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP15(object sender, EventArgs e)
        {
            P15.BackColor = Q15.BackColor = Color.FromArgb(x2, y2, z2);
            P15.ForeColor = Q15.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP16(object sender, EventArgs e)
        {
            P16.BackColor = Q16.BackColor = Color.FromArgb(x1, y1, z1);
            P16.ForeColor = Q16.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP16(object sender, EventArgs e)
        {
            P16.BackColor = Q16.BackColor = Color.FromArgb(x2, y2, z2);
            P16.ForeColor = Q16.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP17(object sender, EventArgs e)
        {
            P17.BackColor = Q17.BackColor = Color.FromArgb(x1, y1, z1);
            P17.ForeColor = Q17.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP17(object sender, EventArgs e)
        {
            P17.BackColor = Q17.BackColor = Color.FromArgb(x2, y2, z2);
            P17.ForeColor = Q17.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP18(object sender, EventArgs e)
        {
            P18.BackColor = Q18.BackColor = Color.FromArgb(x1, y1, z1);
            P18.ForeColor = Q18.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP18(object sender, EventArgs e)
        {
            P18.BackColor = Q18.BackColor = Color.FromArgb(x2, y2, z2);
            P18.ForeColor = Q18.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP19(object sender, EventArgs e)
        {
            P19.BackColor = Q19.BackColor = Color.FromArgb(x1, y1, z1);
            P19.ForeColor = Q19.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP19(object sender, EventArgs e)
        {
            P19.BackColor = Q19.BackColor = Color.FromArgb(x2, y2, z2);
            P19.ForeColor = Q19.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP20(object sender, EventArgs e)
        {
            P20.BackColor = Q20.BackColor = Color.FromArgb(x1, y1, z1);
            P20.ForeColor = Q20.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP20(object sender, EventArgs e)
        {
            P20.BackColor = Q20.BackColor = Color.FromArgb(x2, y2, z2);
            P20.ForeColor = Q20.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP21(object sender, EventArgs e)
        {
            P21.BackColor = Q21.BackColor = Color.FromArgb(x1, y1, z1);
            P21.ForeColor = Q21.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP21(object sender, EventArgs e)
        {
            P21.BackColor = Q21.BackColor = Color.FromArgb(x2, y2, z2);
            P21.ForeColor = Q21.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP22(object sender, EventArgs e)
        {
            P22.BackColor = Q22.BackColor = Color.FromArgb(x1, y1, z1);
            P22.ForeColor = Q22.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP22(object sender, EventArgs e)
        {
            P22.BackColor = Q22.BackColor = Color.FromArgb(x2, y2, z2);
            P22.ForeColor = Q22.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP23(object sender, EventArgs e)
        {
            P23.BackColor = Q23.BackColor = Color.FromArgb(x1, y1, z1);
            P23.ForeColor = Q23.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP23(object sender, EventArgs e)
        {
            P23.BackColor = Q23.BackColor = Color.FromArgb(x2, y2, z2);
            P23.ForeColor = Q23.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP24(object sender, EventArgs e)
        {
            P24.BackColor = Q24.BackColor = Color.FromArgb(x1, y1, z1);
            P24.ForeColor = Q24.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP24(object sender, EventArgs e)
        {
            P24.BackColor = Q24.BackColor = Color.FromArgb(x2, y2, z2);
            P24.ForeColor = Q24.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP25(object sender, EventArgs e)
        {
            P25.BackColor = Q25.BackColor = Color.FromArgb(x1, y1, z1);
            P25.ForeColor = Q25.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP25(object sender, EventArgs e)
        {
            P25.BackColor = Q25.BackColor = Color.FromArgb(x2, y2, z2);
            P25.ForeColor = Q25.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP26(object sender, EventArgs e)
        {
            P26.BackColor = Q26.BackColor = Color.FromArgb(x1, y1, z1);
            P26.ForeColor = Q26.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP26(object sender, EventArgs e)
        {
            P26.BackColor = Q26.BackColor = Color.FromArgb(x2, y2, z2);
            P26.ForeColor = Q26.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP27(object sender, EventArgs e)
        {
            P27.BackColor = Q27.BackColor = Color.FromArgb(x1, y1, z1);
            P27.ForeColor = Q27.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP27(object sender, EventArgs e)
        {
            P27.BackColor = Q27.BackColor = Color.FromArgb(x2, y2, z2);
            P27.ForeColor = Q27.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP28(object sender, EventArgs e)
        {
            P28.BackColor = Q28.BackColor = Color.FromArgb(x1, y1, z1);
            P28.ForeColor = Q28.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP28(object sender, EventArgs e)
        {
            P28.BackColor = Q28.BackColor = Color.FromArgb(x2, y2, z2);
            P28.ForeColor = Q28.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP29(object sender, EventArgs e)
        {
            P29.BackColor = Q29.BackColor = Color.FromArgb(x1, y1, z1);
            P29.ForeColor = Q29.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP29(object sender, EventArgs e)
        {
            P29.BackColor = Q29.BackColor = Color.FromArgb(x2, y2, z2);
            P29.ForeColor = Q29.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP30(object sender, EventArgs e)
        {
            P30.BackColor = Q30.BackColor = Color.FromArgb(x1, y1, z1);
            P30.ForeColor = Q30.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP30(object sender, EventArgs e)
        {
            P30.BackColor = Q30.BackColor = Color.FromArgb(x2, y2, z2);
            P30.ForeColor = Q30.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP31(object sender, EventArgs e)
        {
            P31.BackColor = Q31.BackColor = Color.FromArgb(x1, y1, z1);
            P31.ForeColor = Q31.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP31(object sender, EventArgs e)
        {
            P31.BackColor = Q31.BackColor = Color.FromArgb(x2, y2, z2);
            P31.ForeColor = Q31.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP32(object sender, EventArgs e)
        {
            P32.BackColor = Q32.BackColor = Color.FromArgb(x1, y1, z1);
            P32.ForeColor = Q32.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP32(object sender, EventArgs e)
        {
            P32.BackColor = Q32.BackColor = Color.FromArgb(x2, y2, z2);
            P32.ForeColor = Q32.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP33(object sender, EventArgs e)
        {
            P33.BackColor = Q33.BackColor = Color.FromArgb(x1, y1, z1);
            P33.ForeColor = Q33.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP33(object sender, EventArgs e)
        {
            P33.BackColor = Q33.BackColor = Color.FromArgb(x2, y2, z2);
            P33.ForeColor = Q33.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP34(object sender, EventArgs e)
        {
            P34.BackColor = Q34.BackColor = Color.FromArgb(x1, y1, z1);
            P34.ForeColor = Q34.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP34(object sender, EventArgs e)
        {
            P34.BackColor = Q34.BackColor = Color.FromArgb(x2, y2, z2);
            P34.ForeColor = Q34.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP35(object sender, EventArgs e)
        {
            P35.BackColor = Q35.BackColor = Color.FromArgb(x1, y1, z1);
            P35.ForeColor = Q35.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP35(object sender, EventArgs e)
        {
            P35.BackColor = Q35.BackColor = Color.FromArgb(x2, y2, z2);
            P35.ForeColor = Q35.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP36(object sender, EventArgs e)
        {
            P36.BackColor = Q36.BackColor = Color.FromArgb(x1, y1, z1);
            P36.ForeColor = Q36.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP36(object sender, EventArgs e)
        {
            P36.BackColor = Q36.BackColor = Color.FromArgb(x2, y2, z2);
            P36.ForeColor = Q36.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP37(object sender, EventArgs e)
        {
            P37.BackColor = Q37.BackColor = Color.FromArgb(x1, y1, z1);
            P37.ForeColor = Q37.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP37(object sender, EventArgs e)
        {
            P37.BackColor = Q37.BackColor = Color.FromArgb(x2, y2, z2);
            P37.ForeColor = Q37.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP38(object sender, EventArgs e)
        {
            P38.BackColor = Q38.BackColor = Color.FromArgb(x1, y1, z1);
            P38.ForeColor = Q38.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP38(object sender, EventArgs e)
        {
            P38.BackColor = Q38.BackColor = Color.FromArgb(x2, y2, z2);
            P38.ForeColor = Q38.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP39(object sender, EventArgs e)
        {
            P39.BackColor = Q39.BackColor = Color.FromArgb(x1, y1, z1);
            P39.ForeColor = Q39.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP39(object sender, EventArgs e)
        {
            P39.BackColor = Q39.BackColor = Color.FromArgb(x2, y2, z2);
            P39.ForeColor = Q39.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP40(object sender, EventArgs e)
        {
            P40.BackColor =  Color.FromArgb(x1, y1, z1);
            P40.ForeColor =  Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP40(object sender, EventArgs e)
        {
            P40.BackColor =  Color.FromArgb(x2, y2, z2);
            P40.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP41(object sender, EventArgs e)
        {
            P41.BackColor = Q41.BackColor = Color.FromArgb(x1, y1, z1);
            P41.ForeColor = Q41.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP41(object sender, EventArgs e)
        {
            P41.BackColor = Q41.BackColor = Color.FromArgb(x2, y2, z2);
            P41.ForeColor = Q41.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP42(object sender, EventArgs e)
        {
            P42.BackColor = Q42.BackColor = Color.FromArgb(x1, y1, z1);
            P42.ForeColor = Q42.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP42(object sender, EventArgs e)
        {
            P42.BackColor = Q42.BackColor = Color.FromArgb(x2, y2, z2);
            P42.ForeColor = Q42.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP43(object sender, EventArgs e)
        {
            P43.BackColor =  Color.FromArgb(x1, y1, z1);
            P43.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP43(object sender, EventArgs e)
        {
            P43.BackColor =  Color.FromArgb(x2, y2, z2);
            P43.ForeColor =  Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP44(object sender, EventArgs e)
        {
            P44.BackColor = Q44.BackColor = Color.FromArgb(x1, y1, z1);
            P44.ForeColor = Q44.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP44(object sender, EventArgs e)
        {
            P44.BackColor = Q44.BackColor = Color.FromArgb(x2, y2, z2);
            P44.ForeColor = Q44.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP45(object sender, EventArgs e)
        {
            P45.BackColor = Color.FromArgb(x1, y1, z1);
            P45.ForeColor =  Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP45(object sender, EventArgs e)
        {
            P45.BackColor =  Color.FromArgb(x2, y2, z2);
            P45.ForeColor =  Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP46(object sender, EventArgs e)
        {
            P46.BackColor = Q46.BackColor = Color.FromArgb(x1, y1, z1);
            P46.ForeColor = Q46.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP46(object sender, EventArgs e)
        {
            P46.BackColor = Q46.BackColor = Color.FromArgb(x2, y2, z2);
            P46.ForeColor = Q46.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP47(object sender, EventArgs e)
        {
            P47.BackColor = Q47.BackColor = Color.FromArgb(x1, y1, z1);
            P47.ForeColor = Q47.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP47(object sender, EventArgs e)
        {
            P47.BackColor = Q47.BackColor = Color.FromArgb(x2, y2, z2);
            P47.ForeColor = Q47.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP48(object sender, EventArgs e)
        {
            P48.BackColor = Q48.BackColor = Color.FromArgb(x1, y1, z1);
            P48.ForeColor = Q48.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP48(object sender, EventArgs e)
        {
            P48.BackColor = Q48.BackColor = Color.FromArgb(x2, y2, z2);
            P48.ForeColor = Q48.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP49(object sender, EventArgs e)
        {
            P49.BackColor = Q49.BackColor = Color.FromArgb(x1, y1, z1);
            P49.ForeColor = Q49.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP49(object sender, EventArgs e)
        {
            P49.BackColor = Q49.BackColor = Color.FromArgb(x2, y2, z2);
            P49.ForeColor = Q49.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP50(object sender, EventArgs e)
        {
            P50.BackColor = Q50.BackColor = Color.FromArgb(x1, y1, z1);
            P50.ForeColor = Q50.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP50(object sender, EventArgs e)
        {
            P50.BackColor = Q50.BackColor = Color.FromArgb(x2, y2, z2);
            P50.ForeColor = Q50.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP51(object sender, EventArgs e)
        {
            P51.BackColor = Q51.BackColor = Color.FromArgb(x1, y1, z1);
            P51.ForeColor = Q51.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP51(object sender, EventArgs e)
        {
            P51.BackColor = Q51.BackColor = Color.FromArgb(x2, y2, z2);
            P51.ForeColor = Q51.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP52(object sender, EventArgs e)
        {
            P52.BackColor = Q52.BackColor = Color.FromArgb(x1, y1, z1);
            P52.ForeColor = Q52.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP52(object sender, EventArgs e)
        {
            P52.BackColor = Q52.BackColor = Color.FromArgb(x2, y2, z2);
            P52.ForeColor = Q52.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP53(object sender, EventArgs e)
        {
            P53.BackColor = Color.FromArgb(x1, y1, z1);
            P53.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP53(object sender, EventArgs e)
        {
            P53.BackColor =  Color.FromArgb(x2, y2, z2);
            P53.ForeColor =  Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP54(object sender, EventArgs e)
        {
            P54.BackColor = Q54.BackColor = Color.FromArgb(x1, y1, z1);
            P54.ForeColor = Q54.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP54(object sender, EventArgs e)
        {
            P54.BackColor = Q54.BackColor = Color.FromArgb(x2, y2, z2);
            P54.ForeColor = Q54.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP55(object sender, EventArgs e)
        {
            P55.BackColor = Q55.BackColor = Color.FromArgb(x1, y1, z1);
            P55.ForeColor = Q55.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP55(object sender, EventArgs e)
        {
            P55.BackColor = Q55.BackColor = Color.FromArgb(x2, y2, z2);
            P55.ForeColor = Q55.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP56(object sender, EventArgs e)
        {
            P56.BackColor = Q56.BackColor = Color.FromArgb(x1, y1, z1);
            P56.ForeColor = Q56.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP56(object sender, EventArgs e)
        {
            P56.BackColor = Q56.BackColor = Color.FromArgb(x2, y2, z2);
            P56.ForeColor = Q56.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP57(object sender, EventArgs e)
        {
            P57.BackColor =  Color.FromArgb(x1, y1, z1);
            P57.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP57(object sender, EventArgs e)
        {
            P57.BackColor =  Color.FromArgb(x2, y2, z2);
            P57.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP58(object sender, EventArgs e)
        {
            P58.BackColor = Q58.BackColor = Color.FromArgb(x1, y1, z1);
            P58.ForeColor = Q58.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP58(object sender, EventArgs e)
        {
            P58.BackColor = Q58.BackColor = Color.FromArgb(x2, y2, z2);
            P58.ForeColor = Q58.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP59(object sender, EventArgs e)
        {
            P59.BackColor = Q59.BackColor = Color.FromArgb(x1, y1, z1);
            P59.ForeColor = Q59.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP59(object sender, EventArgs e)
        {
            P59.BackColor = Q59.BackColor = Color.FromArgb(x2, y2, z2);
            P59.ForeColor = Q59.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP60(object sender, EventArgs e)
        {
            P60.BackColor = Q60.BackColor = Color.FromArgb(x1, y1, z1);
            P60.ForeColor = Q60.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP60(object sender, EventArgs e)
        {
            P60.BackColor = Q60.BackColor = Color.FromArgb(x2, y2, z2);
            P60.ForeColor = Q60.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP61(object sender, EventArgs e)
        {
            P61.BackColor = Q61.BackColor = Color.FromArgb(x1, y1, z1);
            P61.ForeColor = Q61.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP61(object sender, EventArgs e)
        {
            P61.BackColor = Q61.BackColor = Color.FromArgb(x2, y2, z2);
            P61.ForeColor = Q61.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP62(object sender, EventArgs e)
        {
            P62.BackColor = Q62.BackColor = Color.FromArgb(x1, y1, z1);
            P62.ForeColor = Q62.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP62(object sender, EventArgs e)
        {
            P62.BackColor = Q62.BackColor = Color.FromArgb(x2, y2, z2);
            P62.ForeColor = Q62.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP63(object sender, EventArgs e)
        {
            P63.BackColor = Q63.BackColor = Color.FromArgb(x1, y1, z1);
            P63.ForeColor = Q63.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP63(object sender, EventArgs e)
        {
            P63.BackColor = Q63.BackColor = Color.FromArgb(x2, y2, z2);
            P63.ForeColor = Q63.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP64(object sender, EventArgs e)
        {
            P64.BackColor = Q64.BackColor = Color.FromArgb(x1, y1, z1);
            P64.ForeColor = Q64.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP64(object sender, EventArgs e)
        {
            P64.BackColor = Q64.BackColor = Color.FromArgb(x2, y2, z2);
            P64.ForeColor = Q64.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP65(object sender, EventArgs e)
        {
            P65.BackColor = Q65.BackColor = Color.FromArgb(x1, y1, z1);
            P65.ForeColor = Q65.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP65(object sender, EventArgs e)
        {
            P65.BackColor = Q65.BackColor = Color.FromArgb(x2, y2, z2);
            P65.ForeColor = Q65.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP66(object sender, EventArgs e)
        {
            P66.BackColor = Q66.BackColor = Color.FromArgb(x1, y1, z1);
            P66.ForeColor = Q66.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP66(object sender, EventArgs e)
        {
            P66.BackColor = Q66.BackColor = Color.FromArgb(x2, y2, z2);
            P66.ForeColor = Q66.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP67(object sender, EventArgs e)
        {
            P67.BackColor = Q67.BackColor = Color.FromArgb(x1, y1, z1);
            P67.ForeColor = Q67.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP67(object sender, EventArgs e)
        {
            P67.BackColor = Q67.BackColor = Color.FromArgb(x2, y2, z2);
            P67.ForeColor = Q67.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP68(object sender, EventArgs e)
        {
            P68.BackColor = Q68.BackColor = Color.FromArgb(x1, y1, z1);
            P68.ForeColor = Q68.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP68(object sender, EventArgs e)
        {
            P68.BackColor = Q68.BackColor = Color.FromArgb(x2, y2, z2);
            P68.ForeColor = Q68.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP69(object sender, EventArgs e)
        {
            P69.BackColor = Q69.BackColor = Color.FromArgb(x1, y1, z1);
            P69.ForeColor = Q69.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP69(object sender, EventArgs e)
        {
            P69.BackColor = Q69.BackColor = Color.FromArgb(x2, y2, z2);
            P69.ForeColor = Q69.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP70(object sender, EventArgs e)
        {
            P70.BackColor = Q70.BackColor = Color.FromArgb(x1, y1, z1);
            P70.ForeColor = Q70.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP70(object sender, EventArgs e)
        {
            P70.BackColor = Q70.BackColor = Color.FromArgb(x2, y2, z2);
            P70.ForeColor = Q70.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP71(object sender, EventArgs e)
        {
            P71.BackColor = Q71.BackColor = Color.FromArgb(x1, y1, z1);
            P71.ForeColor = Q71.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP71(object sender, EventArgs e)
        {
            P71.BackColor = Q71.BackColor = Color.FromArgb(x2, y2, z2);
            P71.ForeColor = Q71.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP72(object sender, EventArgs e)
        {
            P72.BackColor = Q72.BackColor = Color.FromArgb(x1, y1, z1);
            P72.ForeColor = Q72.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP72(object sender, EventArgs e)
        {
            P72.BackColor = Q72.BackColor = Color.FromArgb(x2, y2, z2);
            P72.ForeColor = Q72.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP73(object sender, EventArgs e)
        {
            P73.BackColor = Q73.BackColor = Color.FromArgb(x1, y1, z1);
            P73.ForeColor = Q73.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP73(object sender, EventArgs e)
        {
            P73.BackColor = Q73.BackColor = Color.FromArgb(x2, y2, z2);
            P73.ForeColor = Q73.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP74(object sender, EventArgs e)
        {
            P74.BackColor = Q74.BackColor = Color.FromArgb(x1, y1, z1);
            P74.ForeColor = Q74.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP74(object sender, EventArgs e)
        {
            P74.BackColor = Q74.BackColor = Color.FromArgb(x2, y2, z2);
            P74.ForeColor = Q74.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP75(object sender, EventArgs e)
        {
            P75.BackColor = Q75.BackColor = Color.FromArgb(x1, y1, z1);
            P75.ForeColor = Q75.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP75(object sender, EventArgs e)
        {
            P75.BackColor = Q75.BackColor = Color.FromArgb(x2, y2, z2);
            P75.ForeColor = Q75.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP76(object sender, EventArgs e)
        {
            P76.BackColor = Q76.BackColor = Color.FromArgb(x1, y1, z1);
            P76.ForeColor = Q76.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP76(object sender, EventArgs e)
        {
            P76.BackColor = Q76.BackColor = Color.FromArgb(x2, y2, z2);
            P76.ForeColor = Q76.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP77(object sender, EventArgs e)
        {
            P77.BackColor = Q77.BackColor = Color.FromArgb(x1, y1, z1);
            P77.ForeColor = Q77.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP77(object sender, EventArgs e)
        {
            P77.BackColor = Q77.BackColor = Color.FromArgb(x2, y2, z2);
            P77.ForeColor = Q77.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP78(object sender, EventArgs e)
        {
            P78.BackColor = Q78.BackColor = Color.FromArgb(x1, y1, z1);
            P78.ForeColor = Q78.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP78(object sender, EventArgs e)
        {
            P78.BackColor = Q78.BackColor = Color.FromArgb(x2, y2, z2);
            P78.ForeColor = Q78.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP79(object sender, EventArgs e)
        {
            P79.BackColor = Q79.BackColor = Color.FromArgb(x1, y1, z1);
            P79.ForeColor = Q79.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP79(object sender, EventArgs e)
        {
            P79.BackColor = Q79.BackColor = Color.FromArgb(x2, y2, z2);
            P79.ForeColor = Q79.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP80(object sender, EventArgs e)
        {
            P80.BackColor = Q80.BackColor = Color.FromArgb(x1, y1, z1);
            P80.ForeColor = Q80.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP80(object sender, EventArgs e)
        {
            P80.BackColor = Q80.BackColor = Color.FromArgb(x2, y2, z2);
            P80.ForeColor = Q80.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP81(object sender, EventArgs e)
        {
            P81.BackColor = Q81.BackColor = Color.FromArgb(x1, y1, z1);
            P81.ForeColor = Q81.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP81(object sender, EventArgs e)
        {
            P81.BackColor = Q81.BackColor = Color.FromArgb(x2, y2, z2);
            P81.ForeColor = Q81.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP82(object sender, EventArgs e)
        {
            P82.BackColor = Q82.BackColor = Color.FromArgb(x1, y1, z1);
            P82.ForeColor = Q82.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP82(object sender, EventArgs e)
        {
            P82.BackColor = Q82.BackColor = Color.FromArgb(x2, y2, z2);
            P82.ForeColor = Q82.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP83(object sender, EventArgs e)
        {
            P83.BackColor = Q83.BackColor = Color.FromArgb(x1, y1, z1);
            P83.ForeColor = Q83.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP83(object sender, EventArgs e)
        {
            P83.BackColor = Q83.BackColor = Color.FromArgb(x2, y2, z2);
            P83.ForeColor = Q83.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP84(object sender, EventArgs e)
        {
            P84.BackColor = Q84.BackColor = Color.FromArgb(x1, y1, z1);
            P84.ForeColor = Q84.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP84(object sender, EventArgs e)
        {
            P84.BackColor = Q84.BackColor = Color.FromArgb(x2, y2, z2);
            P84.ForeColor = Q84.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP85(object sender, EventArgs e)
        {
            P85.BackColor = Q85.BackColor = Color.FromArgb(x1, y1, z1);
            P85.ForeColor = Q85.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP85(object sender, EventArgs e)
        {
            P85.BackColor = Q85.BackColor = Color.FromArgb(x2, y2, z2);
            P85.ForeColor = Q85.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP86(object sender, EventArgs e)
        {
            P86.BackColor = Q86.BackColor = Color.FromArgb(x1, y1, z1);
            P86.ForeColor = Q86.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP86(object sender, EventArgs e)
        {
            P86.BackColor = Q86.BackColor = Color.FromArgb(x2, y2, z2);
            P86.ForeColor = Q86.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP87(object sender, EventArgs e)
        {
            P87.BackColor = Q87.BackColor = Color.FromArgb(x1, y1, z1);
            P87.ForeColor = Q87.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP87(object sender, EventArgs e)
        {
            P87.BackColor = Q87.BackColor = Color.FromArgb(x2, y2, z2);
            P87.ForeColor = Q87.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP88(object sender, EventArgs e)
        {
            P88.BackColor = Q88.BackColor = Color.FromArgb(x1, y1, z1);
            P88.ForeColor = Q88.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP88(object sender, EventArgs e)
        {
            P88.BackColor = Q88.BackColor = Color.FromArgb(x2, y2, z2);
            P88.ForeColor = Q88.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP89(object sender, EventArgs e)
        {
            P89.BackColor = Q89.BackColor = Color.FromArgb(x1, y1, z1);
            P89.ForeColor = Q89.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP89(object sender, EventArgs e)
        {
            P89.BackColor = Q89.BackColor = Color.FromArgb(x2, y2, z2);
            P89.ForeColor = Q89.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP90(object sender, EventArgs e)
        {
            P90.BackColor = Q90.BackColor = Color.FromArgb(x1, y1, z1);
            P90.ForeColor = Q90.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP90(object sender, EventArgs e)
        {
            P90.BackColor = Q90.BackColor = Color.FromArgb(x2, y2, z2);
            P90.ForeColor = Q90.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP91(object sender, EventArgs e)
        {
            P91.BackColor = Q91.BackColor = Color.FromArgb(x1, y1, z1);
            P91.ForeColor = Q91.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP91(object sender, EventArgs e)
        {
            P91.BackColor = Q91.BackColor = Color.FromArgb(x2, y2, z2);
            P91.ForeColor = Q91.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP92(object sender, EventArgs e)
        {
            P92.BackColor = Q92.BackColor = Color.FromArgb(x1, y1, z1);
            P92.ForeColor = Q92.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP92(object sender, EventArgs e)
        {
            P92.BackColor = Q92.BackColor = Color.FromArgb(x2, y2, z2);
            P92.ForeColor = Q92.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP93(object sender, EventArgs e)
        {
            P93.BackColor = Q93.BackColor = Color.FromArgb(x1, y1, z1);
            P93.ForeColor = Q93.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP93(object sender, EventArgs e)
        {
            P93.BackColor = Q93.BackColor = Color.FromArgb(x2, y2, z2);
            P93.ForeColor = Q93.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP94(object sender, EventArgs e)
        {
            P94.BackColor = Q94.BackColor = Color.FromArgb(x1, y1, z1);
            P94.ForeColor = Q94.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP94(object sender, EventArgs e)
        {
            P94.BackColor = Q94.BackColor = Color.FromArgb(x2, y2, z2);
            P94.ForeColor = Q94.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP95(object sender, EventArgs e)
        {
            P95.BackColor = Q95.BackColor = Color.FromArgb(x1, y1, z1);
            P95.ForeColor = Q95.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP95(object sender, EventArgs e)
        {
            P95.BackColor = Q95.BackColor = Color.FromArgb(x2, y2, z2);
            P95.ForeColor = Q95.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP96(object sender, EventArgs e)
        {
            P96.BackColor = Q96.BackColor = Color.FromArgb(x1, y1, z1);
            P96.ForeColor = Q96.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP96(object sender, EventArgs e)
        {
            P96.BackColor = Q96.BackColor = Color.FromArgb(x2, y2, z2);
            P96.ForeColor = Q96.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP97(object sender, EventArgs e)
        {
            P97.BackColor = Q97.BackColor = Color.FromArgb(x1, y1, z1);
            P97.ForeColor = Q97.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP97(object sender, EventArgs e)
        {
            P97.BackColor = Q97.BackColor = Color.FromArgb(x2, y2, z2);
            P97.ForeColor = Q97.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP98(object sender, EventArgs e)
        {
            P98.BackColor = Q98.BackColor = Color.FromArgb(x1, y1, z1);
            P98.ForeColor = Q98.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP98(object sender, EventArgs e)
        {
            P98.BackColor = Q98.BackColor = Color.FromArgb(x2, y2, z2);
            P98.ForeColor = Q98.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP99(object sender, EventArgs e)
        {
            P99.BackColor = Q99.BackColor = Color.FromArgb(x1, y1, z1);
            P99.ForeColor = Q99.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP99(object sender, EventArgs e)
        {
            P99.BackColor = Q99.BackColor = Color.FromArgb(x2, y2, z2);
            P99.ForeColor = Q99.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP100(object sender, EventArgs e)
        {
            P100.BackColor = Q100.BackColor = Color.FromArgb(x1, y1, z1);
            P100.ForeColor = Q100.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP100(object sender, EventArgs e)
        {
            P100.BackColor = Q100.BackColor = Color.FromArgb(x2, y2, z2);
            P100.ForeColor = Q100.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP101(object sender, EventArgs e)
        {
            P101.BackColor = Q101.BackColor = Color.FromArgb(x1, y1, z1);
            P101.ForeColor = Q101.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP101(object sender, EventArgs e)
        {
            P101.BackColor = Q101.BackColor = Color.FromArgb(x2, y2, z2);
            P101.ForeColor = Q101.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP102(object sender, EventArgs e)
        {
            P102.BackColor = Q102.BackColor = Color.FromArgb(x1, y1, z1);
            P102.ForeColor = Q102.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP102(object sender, EventArgs e)
        {
            P102.BackColor = Q102.BackColor = Color.FromArgb(x2, y2, z2);
            P102.ForeColor = Q102.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP103(object sender, EventArgs e)
        {
            P103.BackColor = Q103.BackColor = Color.FromArgb(x1, y1, z1);
            P103.ForeColor = Q103.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP103(object sender, EventArgs e)
        {
            P103.BackColor = Q103.BackColor = Color.FromArgb(x2, y2, z2);
            P103.ForeColor = Q103.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP104(object sender, EventArgs e)
        {
            P104.BackColor = Q104.BackColor = Color.FromArgb(x1, y1, z1);
            P104.ForeColor = Q104.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP104(object sender, EventArgs e)
        {
            P104.BackColor = Q104.BackColor = Color.FromArgb(x2, y2, z2);
            P104.ForeColor = Q104.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP105(object sender, EventArgs e)
        {
            P105.BackColor = Q105.BackColor = Color.FromArgb(x1, y1, z1);
            P105.ForeColor = Q105.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP105(object sender, EventArgs e)
        {
            P105.BackColor = Q105.BackColor = Color.FromArgb(x2, y2, z2);
            P105.ForeColor = Q105.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP106(object sender, EventArgs e)
        {
            P106.BackColor = Q106.BackColor = Color.FromArgb(x1, y1, z1);
            P106.ForeColor = Q106.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP106(object sender, EventArgs e)
        {
            P106.BackColor = Q106.BackColor = Color.FromArgb(x2, y2, z2);
            P106.ForeColor = Q106.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP107(object sender, EventArgs e)
        {
            P107.BackColor = Q107.BackColor = Color.FromArgb(x1, y1, z1);
            P107.ForeColor = Q107.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP107(object sender, EventArgs e)
        {
            P107.BackColor = Q107.BackColor = Color.FromArgb(x2, y2, z2);
            P107.ForeColor = Q107.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP108(object sender, EventArgs e)
        {
            P108.BackColor = Q108.BackColor = Color.FromArgb(x1, y1, z1);
            P108.ForeColor = Q108.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP108(object sender, EventArgs e)
        {
            P108.BackColor = Q108.BackColor = Color.FromArgb(x2, y2, z2);
            P108.ForeColor = Q108.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP109(object sender, EventArgs e)
        {
            P109.BackColor = Q109.BackColor = Color.FromArgb(x1, y1, z1);
            P109.ForeColor = Q109.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP109(object sender, EventArgs e)
        {
            P109.BackColor = Q109.BackColor = Color.FromArgb(x2, y2, z2);
            P109.ForeColor = Q109.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP110(object sender, EventArgs e)
        {
            P110.BackColor = Q110.BackColor = Color.FromArgb(x1, y1, z1);
            P110.ForeColor = Q110.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP110(object sender, EventArgs e)
        {
            P110.BackColor = Q110.BackColor = Color.FromArgb(x2, y2, z2);
            P110.ForeColor = Q110.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP111(object sender, EventArgs e)
        {
            P111.BackColor = Q111.BackColor = Color.FromArgb(x1, y1, z1);
            P111.ForeColor = Q111.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP111(object sender, EventArgs e)
        {
            P111.BackColor = Q111.BackColor = Color.FromArgb(x2, y2, z2);
            P111.ForeColor = Q111.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP112(object sender, EventArgs e)
        {
            P112.BackColor = Q112.BackColor = Color.FromArgb(x1, y1, z1);
            P112.ForeColor = Q112.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP112(object sender, EventArgs e)
        {
            P112.BackColor = Q112.BackColor = Color.FromArgb(x2, y2, z2);
            P112.ForeColor = Q112.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP113(object sender, EventArgs e)
        {
            P113.BackColor = Q113.BackColor = Color.FromArgb(x1, y1, z1);
            P113.ForeColor = Q113.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP113(object sender, EventArgs e)
        {
            P113.BackColor = Q113.BackColor = Color.FromArgb(x2, y2, z2);
            P113.ForeColor = Q113.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP114(object sender, EventArgs e)
        {
            P114.BackColor = Q114.BackColor = Color.FromArgb(x1, y1, z1);
            P114.ForeColor = Q114.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP114(object sender, EventArgs e)
        {
            P114.BackColor = Q114.BackColor = Color.FromArgb(x2, y2, z2);
            P114.ForeColor = Q114.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP115(object sender, EventArgs e)
        {
            P115.BackColor = Q115.BackColor = Color.FromArgb(x1, y1, z1);
            P115.ForeColor = Q115.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP115(object sender, EventArgs e)
        {
            P115.BackColor = Q115.BackColor = Color.FromArgb(x2, y2, z2);
            P115.ForeColor = Q115.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP116(object sender, EventArgs e)
        {
            P116.BackColor = Q116.BackColor = Color.FromArgb(x1, y1, z1);
            P116.ForeColor = Q116.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP116(object sender, EventArgs e)
        {
            P116.BackColor = Q116.BackColor = Color.FromArgb(x2, y2, z2);
            P116.ForeColor = Q116.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP117(object sender, EventArgs e)
        {
            P117.BackColor = Q117.BackColor = Color.FromArgb(x1, y1, z1);
            P117.ForeColor = Q117.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP117(object sender, EventArgs e)
        {
            P117.BackColor = Q117.BackColor = Color.FromArgb(x2, y2, z2);
            P117.ForeColor = Q117.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP118(object sender, EventArgs e)
        {
            P118.BackColor = Q118.BackColor = Color.FromArgb(x1, y1, z1);
            P118.ForeColor = Q118.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP118(object sender, EventArgs e)
        {
            P118.BackColor = Q118.BackColor = Color.FromArgb(x2, y2, z2);
            P118.ForeColor = Q118.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP119(object sender, EventArgs e)
        {
            P119.BackColor = Q119.BackColor = Color.FromArgb(x1, y1, z1);
            P119.ForeColor = Q119.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP119(object sender, EventArgs e)
        {
            P119.BackColor = Q119.BackColor = Color.FromArgb(x2, y2, z2);
            P119.ForeColor = Q119.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP120(object sender, EventArgs e)
        {
            P120.BackColor = Q120.BackColor = Color.FromArgb(x1, y1, z1);
            P120.ForeColor = Q120.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP120(object sender, EventArgs e)
        {
            P120.BackColor = Q120.BackColor = Color.FromArgb(x2, y2, z2);
            P120.ForeColor = Q120.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP121(object sender, EventArgs e)
        {
            P121.BackColor = Q121.BackColor = Color.FromArgb(x1, y1, z1);
            P121.ForeColor = Q121.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP121(object sender, EventArgs e)
        {
            P121.BackColor = Q121.BackColor = Color.FromArgb(x2, y2, z2);
            P121.ForeColor = Q121.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP122(object sender, EventArgs e)
        {
            P122.BackColor = Q122.BackColor = Color.FromArgb(x1, y1, z1);
            P122.ForeColor = Q122.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP122(object sender, EventArgs e)
        {
            P122.BackColor = Q122.BackColor = Color.FromArgb(x2, y2, z2);
            P122.ForeColor = Q122.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP123(object sender, EventArgs e)
        {
            P123.BackColor = Q123.BackColor = Color.FromArgb(x1, y1, z1);
            P123.ForeColor = Q123.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP123(object sender, EventArgs e)
        {
            P123.BackColor = Q123.BackColor = Color.FromArgb(x2, y2, z2);
            P123.ForeColor = Q123.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP124(object sender, EventArgs e)
        {
            P124.BackColor = Q124.BackColor = Color.FromArgb(x1, y1, z1);
            P124.ForeColor = Q124.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP124(object sender, EventArgs e)
        {
            P124.BackColor = Q124.BackColor = Color.FromArgb(x2, y2, z2);
            P124.ForeColor = Q124.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP125(object sender, EventArgs e)
        {
            P125.BackColor = Q125.BackColor = Color.FromArgb(x1, y1, z1);
            P125.ForeColor = Q125.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP125(object sender, EventArgs e)
        {
            P125.BackColor = Q125.BackColor = Color.FromArgb(x2, y2, z2);
            P125.ForeColor = Q125.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP126(object sender, EventArgs e)
        {
            P126.BackColor = Q126.BackColor = Color.FromArgb(x1, y1, z1);
            P126.ForeColor = Q126.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP126(object sender, EventArgs e)
        {
            P126.BackColor = Q126.BackColor = Color.FromArgb(x2, y2, z2);
            P126.ForeColor = Q126.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP127(object sender, EventArgs e)
        {
            P127.BackColor = Q127.BackColor = Color.FromArgb(x1, y1, z1);
            P127.ForeColor = Q127.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP127(object sender, EventArgs e)
        {
            P127.BackColor = Q127.BackColor = Color.FromArgb(x2, y2, z2);
            P127.ForeColor = Q127.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP128(object sender, EventArgs e)
        {
            P128.BackColor = Q128.BackColor = Color.FromArgb(x1, y1, z1);
            P128.ForeColor = Q128.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP128(object sender, EventArgs e)
        {
            P128.BackColor = Q128.BackColor = Color.FromArgb(x2, y2, z2);
            P128.ForeColor = Q128.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP129(object sender, EventArgs e)
        {
            P129.BackColor = Q129.BackColor = Color.FromArgb(x1, y1, z1);
            P129.ForeColor = Q129.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP129(object sender, EventArgs e)
        {
            P129.BackColor = Q129.BackColor = Color.FromArgb(x2, y2, z2);
            P129.ForeColor = Q129.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP130(object sender, EventArgs e)
        {
            P130.BackColor = Q130.BackColor = Color.FromArgb(x1, y1, z1);
            P130.ForeColor = Q130.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP130(object sender, EventArgs e)
        {
            P130.BackColor = Q130.BackColor = Color.FromArgb(x2, y2, z2);
            P130.ForeColor = Q130.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP131(object sender, EventArgs e)
        {
            P131.BackColor = Q131.BackColor = Color.FromArgb(x1, y1, z1);
            P131.ForeColor = Q131.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP131(object sender, EventArgs e)
        {
            P131.BackColor = Q131.BackColor = Color.FromArgb(x2, y2, z2);
            P131.ForeColor = Q131.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP132(object sender, EventArgs e)
        {
            P132.BackColor = Q132.BackColor = Color.FromArgb(x1, y1, z1);
            P132.ForeColor = Q132.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP132(object sender, EventArgs e)
        {
            P132.BackColor = Q132.BackColor = Color.FromArgb(x2, y2, z2);
            P132.ForeColor = Q132.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP133(object sender, EventArgs e)
        {
            P133.BackColor = Q133.BackColor = Color.FromArgb(x1, y1, z1);
            P133.ForeColor = Q133.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP133(object sender, EventArgs e)
        {
            P133.BackColor = Q133.BackColor = Color.FromArgb(x2, y2, z2);
            P133.ForeColor = Q133.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP134(object sender, EventArgs e)
        {
            P134.BackColor = Q134.BackColor = Color.FromArgb(x1, y1, z1);
            P134.ForeColor = Q134.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP134(object sender, EventArgs e)
        {
            P134.BackColor = Q134.BackColor = Color.FromArgb(x2, y2, z2);
            P134.ForeColor = Q134.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP135(object sender, EventArgs e)
        {
            P135.BackColor = Q135.BackColor = Color.FromArgb(x1, y1, z1);
            P135.ForeColor = Q135.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP135(object sender, EventArgs e)
        {
            P135.BackColor = Q135.BackColor = Color.FromArgb(x2, y2, z2);
            P135.ForeColor = Q135.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP136(object sender, EventArgs e)
        {
            P136.BackColor = Q136.BackColor = Color.FromArgb(x1, y1, z1);
            P136.ForeColor = Q136.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP136(object sender, EventArgs e)
        {
            P136.BackColor = Q136.BackColor = Color.FromArgb(x2, y2, z2);
            P136.ForeColor = Q136.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP137(object sender, EventArgs e)
        {
            P137.BackColor = Q137.BackColor = Color.FromArgb(x1, y1, z1);
            P137.ForeColor = Q137.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP137(object sender, EventArgs e)
        {
            P137.BackColor = Q137.BackColor = Color.FromArgb(x2, y2, z2);
            P137.ForeColor = Q137.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP138(object sender, EventArgs e)
        {
            P138.BackColor = Q138.BackColor = Color.FromArgb(x1, y1, z1);
            P138.ForeColor = Q138.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP138(object sender, EventArgs e)
        {
            P138.BackColor = Q138.BackColor = Color.FromArgb(x2, y2, z2);
            P138.ForeColor = Q138.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP139(object sender, EventArgs e)
        {
            P139.BackColor = Q139.BackColor = Color.FromArgb(x1, y1, z1);
            P139.ForeColor = Q139.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP139(object sender, EventArgs e)
        {
            P139.BackColor = Q139.BackColor = Color.FromArgb(x2, y2, z2);
            P139.ForeColor = Q139.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP140(object sender, EventArgs e)
        {
            P140.BackColor = Q140.BackColor = Color.FromArgb(x1, y1, z1);
            P140.ForeColor = Q140.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP140(object sender, EventArgs e)
        {
            P140.BackColor = Q140.BackColor = Color.FromArgb(x2, y2, z2);
            P140.ForeColor = Q140.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP141(object sender, EventArgs e)
        {
            P141.BackColor = Q141.BackColor = Color.FromArgb(x1, y1, z1);
            P141.ForeColor = Q141.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP141(object sender, EventArgs e)
        {
            P141.BackColor = Q141.BackColor = Color.FromArgb(x2, y2, z2);
            P141.ForeColor = Q141.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP142(object sender, EventArgs e)
        {
            P142.BackColor = Q142.BackColor = Color.FromArgb(x1, y1, z1);
            P142.ForeColor = Q142.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP142(object sender, EventArgs e)
        {
            P142.BackColor = Q142.BackColor = Color.FromArgb(x2, y2, z2);
            P142.ForeColor = Q142.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP143(object sender, EventArgs e)
        {
            P143.BackColor = Q143.BackColor = Color.FromArgb(x1, y1, z1);
            P143.ForeColor = Q143.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP143(object sender, EventArgs e)
        {
            P143.BackColor = Q143.BackColor = Color.FromArgb(x2, y2, z2);
            P143.ForeColor = Q143.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP144(object sender, EventArgs e)
        {
            P144.BackColor = Q144.BackColor = Color.FromArgb(x1, y1, z1);
            P144.ForeColor = Q144.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP144(object sender, EventArgs e)
        {
            P144.BackColor = Q144.BackColor = Color.FromArgb(x2, y2, z2);
            P144.ForeColor = Q144.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP145(object sender, EventArgs e)
        {
            P145.BackColor = Q145.BackColor = Color.FromArgb(x1, y1, z1);
            P145.ForeColor = Q145.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP145(object sender, EventArgs e)
        {
            P145.BackColor = Q145.BackColor = Color.FromArgb(x2, y2, z2);
            P145.ForeColor = Q145.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP146(object sender, EventArgs e)
        {
            P146.BackColor = Q146.BackColor = Color.FromArgb(x1, y1, z1);
            P146.ForeColor = Q146.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP146(object sender, EventArgs e)
        {
            P146.BackColor = Q146.BackColor = Color.FromArgb(x2, y2, z2);
            P146.ForeColor = Q146.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP147(object sender, EventArgs e)
        {
            P147.BackColor = Q147.BackColor = Color.FromArgb(x1, y1, z1);
            P147.ForeColor = Q147.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP147(object sender, EventArgs e)
        {
            P147.BackColor = Q147.BackColor = Color.FromArgb(x2, y2, z2);
            P147.ForeColor = Q147.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP148(object sender, EventArgs e)
        {
            P148.BackColor = Q148.BackColor = Color.FromArgb(x1, y1, z1);
            P148.ForeColor = Q148.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP148(object sender, EventArgs e)
        {
            P148.BackColor = Q148.BackColor = Color.FromArgb(x2, y2, z2);
            P148.ForeColor = Q148.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP149(object sender, EventArgs e)
        {
            P149.BackColor = Q149.BackColor = Color.FromArgb(x1, y1, z1);
            P149.ForeColor = Q149.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP149(object sender, EventArgs e)
        {
            P149.BackColor = Q149.BackColor = Color.FromArgb(x2, y2, z2);
            P149.ForeColor = Q149.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP150(object sender, EventArgs e)
        {
            P150.BackColor = Q150.BackColor = Color.FromArgb(x1, y1, z1);
            P150.ForeColor = Q150.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP150(object sender, EventArgs e)
        {
            P150.BackColor = Q150.BackColor = Color.FromArgb(x2, y2, z2);
            P150.ForeColor = Q150.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP151(object sender, EventArgs e)
        {
            P151.BackColor = Q151.BackColor = Color.FromArgb(x1, y1, z1);
            P151.ForeColor = Q151.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP151(object sender, EventArgs e)
        {
            P151.BackColor = Q151.BackColor = Color.FromArgb(x2, y2, z2);
            P151.ForeColor = Q151.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP152(object sender, EventArgs e)
        {
            P152.BackColor = Q152.BackColor = Color.FromArgb(x1, y1, z1);
            P152.ForeColor = Q152.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP152(object sender, EventArgs e)
        {
            P152.BackColor = Q152.BackColor = Color.FromArgb(x2, y2, z2);
            P152.ForeColor = Q152.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP153(object sender, EventArgs e)
        {
            P153.BackColor = Q153.BackColor = Color.FromArgb(x1, y1, z1);
            P153.ForeColor = Q153.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP153(object sender, EventArgs e)
        {
            P153.BackColor = Q153.BackColor = Color.FromArgb(x2, y2, z2);
            P153.ForeColor = Q153.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP154(object sender, EventArgs e)
        {
            P154.BackColor = Q154.BackColor = Color.FromArgb(x1, y1, z1);
            P154.ForeColor = Q154.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP154(object sender, EventArgs e)
        {
            P154.BackColor = Q154.BackColor = Color.FromArgb(x2, y2, z2);
            P154.ForeColor = Q154.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP155(object sender, EventArgs e)
        {
            P155.BackColor =  Color.FromArgb(x1, y1, z1);
            P155.ForeColor =  Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP155(object sender, EventArgs e)
        {
            P155.BackColor =  Color.FromArgb(x2, y2, z2);
            P155.ForeColor =  Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP156(object sender, EventArgs e)
        {
            P156.BackColor = Q156.BackColor = Color.FromArgb(x1, y1, z1);
            P156.ForeColor = Q156.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP156(object sender, EventArgs e)
        {
            P156.BackColor = Q156.BackColor = Color.FromArgb(x2, y2, z2);
            P156.ForeColor = Q156.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP157(object sender, EventArgs e)
        {
            P157.BackColor = Q157.BackColor = Color.FromArgb(x1, y1, z1);
            P157.ForeColor = Q157.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP157(object sender, EventArgs e)
        {
            P157.BackColor = Q157.BackColor = Color.FromArgb(x2, y2, z2);
            P157.ForeColor = Q157.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP158(object sender, EventArgs e)
        {
            P158.BackColor = Q158.BackColor = Color.FromArgb(x1, y1, z1);
            P158.ForeColor = Q158.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP158(object sender, EventArgs e)
        {
            P158.BackColor = Q158.BackColor = Color.FromArgb(x2, y2, z2);
            P158.ForeColor = Q158.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP159(object sender, EventArgs e)
        {
            P159.BackColor = Q159.BackColor = Color.FromArgb(x1, y1, z1);
            P159.ForeColor = Q159.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP159(object sender, EventArgs e)
        {
            P159.BackColor = Q159.BackColor = Color.FromArgb(x2, y2, z2);
            P159.ForeColor = Q159.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP160(object sender, EventArgs e)
        {
            P160.BackColor = Q160.BackColor = Color.FromArgb(x1, y1, z1);
            P160.ForeColor = Q160.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP160(object sender, EventArgs e)
        {
            P160.BackColor = Q160.BackColor = Color.FromArgb(x2, y2, z2);
            P160.ForeColor = Q160.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP161(object sender, EventArgs e)
        {
            P161.BackColor = Q161.BackColor = Color.FromArgb(x1, y1, z1);
            P161.ForeColor = Q161.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP161(object sender, EventArgs e)
        {
            P161.BackColor = Q161.BackColor = Color.FromArgb(x2, y2, z2);
            P161.ForeColor = Q161.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP162(object sender, EventArgs e)
        {
            P162.BackColor = Q162.BackColor = Color.FromArgb(x1, y1, z1);
            P162.ForeColor = Q162.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP162(object sender, EventArgs e)
        {
            P162.BackColor = Q162.BackColor = Color.FromArgb(x2, y2, z2);
            P162.ForeColor = Q162.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP163(object sender, EventArgs e)
        {
            P163.BackColor = Q163.BackColor = Color.FromArgb(x1, y1, z1);
            P163.ForeColor = Q163.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP163(object sender, EventArgs e)
        {
            P163.BackColor = Q163.BackColor = Color.FromArgb(x2, y2, z2);
            P163.ForeColor = Q163.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP164(object sender, EventArgs e)
        {
            P164.BackColor = Q164.BackColor = Color.FromArgb(x1, y1, z1);
            P164.ForeColor = Q164.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP164(object sender, EventArgs e)
        {
            P164.BackColor = Q164.BackColor = Color.FromArgb(x2, y2, z2);
            P164.ForeColor = Q164.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP165(object sender, EventArgs e)
        {
            P165.BackColor = Q165.BackColor = Color.FromArgb(x1, y1, z1);
            P165.ForeColor = Q165.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP165(object sender, EventArgs e)
        {
            P165.BackColor = Q165.BackColor = Color.FromArgb(x2, y2, z2);
            P165.ForeColor = Q165.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP166(object sender, EventArgs e)
        {
            P166.BackColor = Q166.BackColor = Color.FromArgb(x1, y1, z1);
            P166.ForeColor = Q166.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP166(object sender, EventArgs e)
        {
            P166.BackColor = Q166.BackColor = Color.FromArgb(x2, y2, z2);
            P166.ForeColor = Q166.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP167(object sender, EventArgs e)
        {
            P167.BackColor = Q167.BackColor = Color.FromArgb(x1, y1, z1);
            P167.ForeColor = Q167.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP167(object sender, EventArgs e)
        {
            P167.BackColor = Q167.BackColor = Color.FromArgb(x2, y2, z2);
            P167.ForeColor = Q167.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP168(object sender, EventArgs e)
        {
            P168.BackColor = Q168.BackColor = Color.FromArgb(x1, y1, z1);
            P168.ForeColor = Q168.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP168(object sender, EventArgs e)
        {
            P168.BackColor = Q168.BackColor = Color.FromArgb(x2, y2, z2);
            P168.ForeColor = Q168.ForeColor = Color.FromArgb(x1, y1, z1);

        }
        private void OnMouseEnterP169(object sender, EventArgs e)
        {
            P169.BackColor = Q169.BackColor = Color.FromArgb(x1, y1, z1);
            P169.ForeColor = Q169.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseLeaveP169(object sender, EventArgs e)
        {
            P169.BackColor = Q169.BackColor = Color.FromArgb(x2, y2, z2);
            P169.ForeColor = Q169.ForeColor = Color.FromArgb(x1, y1, z1);

        }
    




        






        
        
        
        




        private void OnMouseEntercauta_events1(object sender, EventArgs e)
        {
            cauta_events.ForeColor = Color.FromArgb(x1,y1,z1);
        }
        private void OnMouseLeavecauta_events1(object sender, EventArgs e)
        {

            cauta_events.ForeColor = Color.FromArgb(x2, y2, z2);

        }










        private void OnMouseEnterT1(object sender, EventArgs e)
        {
            T1.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Underline);


        }
        private void OnMouseLeaveT1(object sender, EventArgs e)
        {
            T1.Font = new Font("Microsoft Sans Serif", 20);


        }
        private void OnMouseEnterS1(object sender, EventArgs e)
        {
            S1.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Underline);


        }
        private void OnMouseLeaveS1(object sender, EventArgs e)
        {
            S1.Font = new Font("Microsoft Sans Serif", 20);


        }
        private void OnMouseEnterSC1(object sender, EventArgs e)
        {
            SC1.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Underline);


        }
        private void OnMouseLeaveSC1(object sender, EventArgs e)
        {
            SC1.Font = new Font("Microsoft Sans Serif", 20);


        }


        private void OnMouseEnterBiog1(object sender, EventArgs e)
        {
            Biog1.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Underline);


        }
        private void OnMouseLeaveBiog1(object sender, EventArgs e)
        {
            Biog1.Font = new Font("Microsoft Sans Serif", 20);


        }


        private void OnMouseEnterBiog2(object sender, EventArgs e)
        {
            Biog2.ForeColor = Color.FromArgb(x1,y1,z1);
            

        }

        private void OnMouseLeaveBiog2(object sender, EventArgs e)
        {
            Biog2.ForeColor = Color.FromArgb(x2, y2, z2);

        }
        private void OnMouseEnterSC2(object sender, EventArgs e)
        {
            SC2.ForeColor = Color.FromArgb(x1, y1, z1);

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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void TAB_Click(object sender, EventArgs e)
        {
            interogatoriu.Visible = DA.Visible = NU.Visible = mafiamember.Visible = true;
            stanga_output.Visible = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void TAB_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TAB_Click_1(object sender, EventArgs e)
        {
            interogatoriu.Visible = DA.Visible = NU.Visible = mafiamember.Visible = true;
            S1.Visible = SC1.Visible = T1.Visible = Biog1.Visible = true;
            stanga_output.BackColor = Color.FromArgb(22, 18, 88);
            TAB.Visible = false;
            ARROW.Visible = true;
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void ARROW_Click(object sender, EventArgs e)
        {

            interogatoriu.Visible = DA.Visible = NU.Visible = mafiamember.Visible = false;
            S1.Visible = SC1.Visible = T1.Visible = Biog1.Visible = false;
            stanga_output.BackColor = Color.FromArgb(198, 131, 14);
            TAB.Visible=true;
            ARROW.Visible = false;
            TAB2.Visible = true;
        }

        private void Biog2_Click(object sender, EventArgs e)
        {

        }

        private void TAB2_Click(object sender, EventArgs e)
        {
            interogatoriu.Visible = DA.Visible = NU.Visible = mafiamember.Visible = true;
            ARROW.Visible = T1.Visible = Biog1.Visible =  S1.Visible=SC1.Visible= true;
            stanga_output.BackColor = Color.FromArgb(22, 18, 88);
            TAB2.Visible = false;
        }

        private void TAB2_Click_1(object sender, EventArgs e)
        {
            interogatoriu.Visible = DA.Visible = NU.Visible = mafiamember.Visible = true;
            ARROW.Visible = T1.Visible = Biog1.Visible =  S1.Visible=SC1.Visible= true;
            stanga_output.BackColor = Color.FromArgb(22,18 , 88);
            TAB2.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Prev2_Click(object sender, EventArgs e)
        {
            nr--;
            shift_tab(nr);
        }

        private void Prev1_Click(object sender, EventArgs e)
        {
            nr--;
            shift_tab(nr);
        }

        private void Next1_Click(object sender, EventArgs e)
        {
            nr++;
            shift_tab(nr);
        }

        private void Next2_Click(object sender, EventArgs e)
        {
            nr++;
            shift_tab(nr);
        }

        private void cauta_events_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            panel1.AutoScroll = true;


        }

        private void T1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void T2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void P1_Click(object sender, EventArgs e)
        {
            nr = 1;
            shift_tab(1);
        }

        private void cauta_events_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            panel1.AutoScroll = true;
        }

        private void TAB2_Click_2(object sender, EventArgs e)
        {

            meme = 1;
            afis_meme();
            ARROW.Visible = T1.Visible = Biog1.Visible =  S1.Visible = SC1.Visible = true;
            stanga_output.BackColor = Color.FromArgb(22, 18, 88);
            TAB2.Visible = false;
        }

        private void Next1_Click_1(object sender, EventArgs e)
        {
            nr++;
            shift_tab(nr);
        }

        private void Prev1_Click_1(object sender, EventArgs e)
        {
            nr--;
            shift_tab(nr);
        }

        private void Prev2_Click_1(object sender, EventArgs e)
        {
            nr--;
            shift_tab(nr);
        }



        private void T2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
        private void S1_Click(object sender, EventArgs e)
        {
            var form3 = new Form3();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void S2_Click(object sender, EventArgs e)
        {
            var form3 = new Form3();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }
        private void TAB_Click_2(object sender, EventArgs e)
        {
            meme = 1;
            ARROW.Visible = T1.Visible = Biog1.Visible =  S1.Visible = SC1.Visible = true;
            stanga_output.BackColor = Color.FromArgb(22, 18, 88);
            TAB.Visible = false;
        }


        private void TAB_Click_3(object sender, EventArgs e)
        {
            meme = 1;
            afis_meme();
            ARROW.Visible = T1.Visible = Biog1.Visible =  S1.Visible = SC1.Visible = true;
            stanga_output.BackColor = Color.FromArgb(22, 18, 88);
            TAB.Visible = false;
        }

        private void P1_Click_1(object sender, EventArgs e)
        {

            nr = 1;
            shift_tab(nr);
        }

        private void Q1_Click(object sender, EventArgs e)
        {

            nr = 1;
            shift_tab(nr);
        }

        private void P2_Click(object sender, EventArgs e)
        {
         
            nr = 2;
            shift_tab(nr);
        }

        private void Q2_Click(object sender, EventArgs e)
        {
  
            nr = 2;
            shift_tab(nr);
        }

        private void P2_Click_1(object sender, EventArgs e)
        {
           
            nr = 2;
            shift_tab(nr);
        }

        private void Q2_Click_1(object sender, EventArgs e)
        {
        
            nr = 2;
            shift_tab(nr);
        }

        private void P1_Click_2(object sender, EventArgs e)
        {
    
            nr = 1;
            shift_tab(nr);
        }

        private void P3_Click(object sender, EventArgs e)
        {
 
            nr = 3;
            shift_tab(nr);
        }

        private void Q3_Click(object sender, EventArgs e)
        {
 
            nr = 3;
            shift_tab(nr);
        }

        private void P4_Click(object sender, EventArgs e)
        {

            nr = 4;
            shift_tab(nr);
        }

        private void Q4_Click(object sender, EventArgs e)
        {

            nr = 4;
            shift_tab(nr);
        }

        private void P5_Click(object sender, EventArgs e)
        {
        
            nr = 5;
            shift_tab(nr);
        }

        private void Q5_Click(object sender, EventArgs e)
        {
         
            nr = 5;
            shift_tab(nr);
        }

        private void P6_Click(object sender, EventArgs e)
        { 
            nr = 6;
            shift_tab(nr);
        }

        private void Q6_Click(object sender, EventArgs e)
        {
     
            nr = 6;
            shift_tab(nr);
        }

        private void P7_Click(object sender, EventArgs e)
        {
        
            nr = 7;
            shift_tab(nr);
        }

        private void Q7_Click(object sender, EventArgs e)
        {
        
            nr = 7;
            shift_tab(nr);
        }

        private void P8_Click(object sender, EventArgs e)
        {
      
            nr = 8;
            shift_tab(nr);
        }

        private void Q8_Click(object sender, EventArgs e)
        {
        
            nr = 8;
            shift_tab(nr);
        }

        private void P9_Click(object sender, EventArgs e)
        {
         
            nr = 9;
            shift_tab(nr);
        }

        private void Q9_Click(object sender, EventArgs e)
        { 
            nr = 9;
            shift_tab(nr);
        }

        private void P10_Click(object sender, EventArgs e)
        {
            nr = 10;
            shift_tab(nr);
        }

        private void Q10_Click(object sender, EventArgs e)
        {
            nr = 10;
            shift_tab(nr);
        }

        private void P11_Click(object sender, EventArgs e)
        {
            nr = 11;
            shift_tab(nr);
        }

        private void Q11_Click(object sender, EventArgs e)
        {
            nr = 11;
            shift_tab(nr);
        }

        private void P12_Click(object sender, EventArgs e)
        {
            nr = 12;
            shift_tab(nr);
        }

        private void Q12_Click(object sender, EventArgs e)
        {
            nr = 12;
            shift_tab(nr);
        }

        private void P13_Click(object sender, EventArgs e)
        {
            nr = 13;
            shift_tab(nr);
        }

        private void Q13_Click(object sender, EventArgs e)
        {
            nr = 13;
            shift_tab(nr);
        }

        private void P14_Click(object sender, EventArgs e)
        {
            nr = 14;
            shift_tab(nr);
        }

        private void Q14_Click(object sender, EventArgs e)
        {
            nr = 14;
            shift_tab(nr);
        }

        private void P15_Click(object sender, EventArgs e)
        {
            nr = 15;
            shift_tab(nr);
        }

        private void Q15_Click(object sender, EventArgs e)
        {
            nr = 15;
            shift_tab(nr);
        }

        private void P16_Click(object sender, EventArgs e)
        {
            nr = 16;
            shift_tab(nr);
        }

        private void Q16_Click(object sender, EventArgs e)
        {
            nr = 16;
            shift_tab(nr);
        }

        private void P17_Click(object sender, EventArgs e)
        {
            nr = 17;
            shift_tab(nr);
        }

        private void Q17_Click(object sender, EventArgs e)
        {
            nr = 17;
            shift_tab(nr);
        }

        private void P18_Click(object sender, EventArgs e)
        {
            nr = 18;
            shift_tab(nr);
        }

        private void Q18_Click(object sender, EventArgs e)
        {
            nr = 18;
            shift_tab(nr);
        }

        private void P19_Click(object sender, EventArgs e)
        {
            nr = 19;
            shift_tab(nr);
        }

        private void Q19_Click(object sender, EventArgs e)
        {
            nr = 19;
            shift_tab(nr);
        }

        private void P20_Click(object sender, EventArgs e)
        {
            nr = 20;
            shift_tab(nr);
        }

        private void Q20_Click(object sender, EventArgs e)
        {
            nr = 20;
            shift_tab(nr);
        }

        private void P21_Click(object sender, EventArgs e)
        {
            nr = 21;
            shift_tab(nr);
        }

        private void Q21_Click(object sender, EventArgs e)
        {
            nr = 21;
            shift_tab(nr);
        }

        private void P22_Click(object sender, EventArgs e)
        {
            nr = 22;
            shift_tab(nr);
        }

        private void Q22_Click(object sender, EventArgs e)
        {
            nr = 22;
            shift_tab(nr);
        }

        private void P23_Click(object sender, EventArgs e)
        {
            nr = 23;
            shift_tab(nr);
        }

        private void Q23_Click(object sender, EventArgs e)
        {
            nr = 23;
            shift_tab(nr);
        }

        private void P24_Click(object sender, EventArgs e)
        {
            nr = 24;
            shift_tab(nr);
        }

        private void Q24_Click(object sender, EventArgs e)
        {
            nr = 24;
            shift_tab(nr);
        }

        private void P25_Click(object sender, EventArgs e)
        {
            nr = 25;
            shift_tab(nr);
        }

        private void Q25_Click(object sender, EventArgs e)
        {
            nr = 25;
            shift_tab(nr);
        }

        private void P26_Click(object sender, EventArgs e)
        {
            nr = 26;
            shift_tab(nr);
        }

        private void Q26_Click(object sender, EventArgs e)
        {
            nr = 26;
            shift_tab(nr);
        }

        private void P27_Click(object sender, EventArgs e)
        {
            nr = 27;
            shift_tab(nr);
        }

        private void Q27_Click(object sender, EventArgs e)
        {
            nr = 27;
            shift_tab(nr);
        }

        private void P28_Click(object sender, EventArgs e)
        {
            nr = 28;
            shift_tab(nr);
        }

        private void Q28_Click(object sender, EventArgs e)
        {
            nr = 28;
            shift_tab(nr);
        }

        private void P29_Click(object sender, EventArgs e)
        {
            nr = 29;
            shift_tab(nr);
        }

        private void Q29_Click(object sender, EventArgs e)
        {
            nr = 29;
            shift_tab(nr);
        }

        private void P30_Click(object sender, EventArgs e)
        {
            nr = 30;
            shift_tab(nr);
        }

        private void Q30_Click(object sender, EventArgs e)
        {
            nr = 30;
            shift_tab(nr);
        }

        private void P31_Click(object sender, EventArgs e)
        {
            nr = 31;
            shift_tab(nr);
        }

        private void Q31_Click(object sender, EventArgs e)
        {
            nr = 31;
            shift_tab(nr);
        }

        private void P32_Click(object sender, EventArgs e)
        {
            nr = 32;
            shift_tab(nr);
        }

        private void Q32_Click(object sender, EventArgs e)
        {
            nr = 32;
            shift_tab(nr);
        }

        private void P33_Click(object sender, EventArgs e)
        {
            nr = 33;
            shift_tab(nr);
        }

        private void Q33_Click(object sender, EventArgs e)
        {
            nr = 33;
            shift_tab(nr);
        }

        private void P34_Click(object sender, EventArgs e)
        {
            nr = 34;
            shift_tab(nr);
        }

        private void Q34_Click(object sender, EventArgs e)
        {
            nr = 34;
            shift_tab(nr);
        }

        private void P35_Click(object sender, EventArgs e)
        {
            nr = 35;
            shift_tab(nr);
        }

        private void Q35_Click(object sender, EventArgs e)
        {
            nr = 35;
            shift_tab(nr);
        }

        private void P36_Click(object sender, EventArgs e)
        {
            nr = 36;
            shift_tab(nr);
        }

        private void Q36_Click(object sender, EventArgs e)
        {
            nr = 36;
            shift_tab(nr);
        }

        private void P37_Click(object sender, EventArgs e)
        {
            nr = 37;
            shift_tab(nr);
        }

        private void Q37_Click(object sender, EventArgs e)
        {
            nr = 37;
            shift_tab(nr);
        }

        private void P38_Click(object sender, EventArgs e)
        {
            nr = 38;
            shift_tab(nr);
        }

        private void Q38_Click(object sender, EventArgs e)
        {
            nr = 38;
            shift_tab(nr);
        }

        private void P39_Click(object sender, EventArgs e)
        {
            nr = 39;
            shift_tab(nr);
        }

        private void Q39_Click(object sender, EventArgs e)
        {
            nr = 39;
            shift_tab(nr);
        }

        private void P40_Click(object sender, EventArgs e)
        {
            nr = 40;
            shift_tab(nr);
        }

        private void P41_Click(object sender, EventArgs e)
        {
            nr = 41;
            shift_tab(nr);
        }

        private void Q41_Click(object sender, EventArgs e)
        {
            nr = 41;
            shift_tab(nr);
        }

        private void P42_Click(object sender, EventArgs e)
        {
            nr = 42;
            shift_tab(nr);
        }

        private void Q42_Click(object sender, EventArgs e)
        {
            nr = 42;
            shift_tab(nr);
        }

        private void P43_Click(object sender, EventArgs e)
        {
            nr = 43;
            shift_tab(nr);
        }

        private void P44_Click(object sender, EventArgs e)
        {
            nr = 44;
            shift_tab(nr);
        }

        private void Q44_Click(object sender, EventArgs e)
        {
            nr = 44;
            shift_tab(nr);
        }
        private void P45_Click(object sender, EventArgs e)
        {
            nr = 45;
            shift_tab(nr);
        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void P46_Click(object sender, EventArgs e)
        {
            nr = 46;
            shift_tab(nr);
        }

        private void Q46_Click(object sender, EventArgs e)
        {
            nr = 46;
            shift_tab(nr);
        }

        private void P47_Click(object sender, EventArgs e)
        {
            nr = 47;
            shift_tab(nr);
        }

        private void Q47_Click(object sender, EventArgs e)
        {
            nr = 47;
            shift_tab(nr);
        }

        private void P48_Click(object sender, EventArgs e)
        {
            nr = 48;
            shift_tab(nr);
        }

        private void Q48_Click(object sender, EventArgs e)
        {
            nr = 48;
            shift_tab(nr);
        }

        private void P49_Click(object sender, EventArgs e)
        {
            nr = 49;
            shift_tab(nr);
        }

        private void Q49_Click(object sender, EventArgs e)
        {
            nr = 49;
            shift_tab(nr);
        }

        private void P50_Click(object sender, EventArgs e)
        {
            nr = 50;
            shift_tab(nr);
        }

        private void Q50_Click(object sender, EventArgs e)
        {
            nr = 50;
            shift_tab(nr);
        }

        private void P51_Click(object sender, EventArgs e)
        {
            nr = 51;
            shift_tab(nr);
        }

        private void Q51_Click(object sender, EventArgs e)
        {
            nr = 51;
            shift_tab(nr);
        }

        private void P52_Click(object sender, EventArgs e)
        {
            nr = 52;
            shift_tab(nr);
        }

        private void Q52_Click(object sender, EventArgs e)
        {
            nr = 52;
            shift_tab(nr);
        }

        private void P53_Click(object sender, EventArgs e)
        {
            nr = 53;
            shift_tab(nr);
        }

        private void P54_Click(object sender, EventArgs e)
        {
            nr = 54;
            shift_tab(nr);
        }

        private void Q54_Click(object sender, EventArgs e)
        {
            nr = 54;
            shift_tab(nr);
        }

        private void P55_Click(object sender, EventArgs e)
        {
            nr = 55;
            shift_tab(nr);
        }

        private void Q55_Click(object sender, EventArgs e)
        {
            nr = 55;
            shift_tab(nr);
        }

        private void P56_Click(object sender, EventArgs e)
        {
            nr = 56;
            shift_tab(nr);
        }

        private void Q56_Click(object sender, EventArgs e)
        {
            nr = 56;
            shift_tab(nr);
        }

        private void P57_Click(object sender, EventArgs e)
        {
            nr = 57;
            shift_tab(nr);
        }

        private void P58_Click(object sender, EventArgs e)
        {
            nr = 58;
            shift_tab(nr);
        }

        private void Q58_Click(object sender, EventArgs e)
        {
            nr = 58;
            shift_tab(nr);
        }

        private void P59_Click(object sender, EventArgs e)
        {
            nr = 59;
            shift_tab(nr);
        }

        private void Q59_Click(object sender, EventArgs e)
        {
            nr = 59;
            shift_tab(nr);
        }

        private void P60_Click(object sender, EventArgs e)
        {
            nr = 60;
            shift_tab(nr);
        }

        private void Q60_Click(object sender, EventArgs e)
        {
            nr = 60;
            shift_tab(nr);
        }

        private void P61_Click(object sender, EventArgs e)
        {
            nr = 61;
            shift_tab(nr);
        }

        private void Q61_Click(object sender, EventArgs e)
        {
            nr = 61;
            shift_tab(nr);
        }

        private void P62_Click(object sender, EventArgs e)
        {
            nr = 62;
            shift_tab(nr);
        }

        private void Q62_Click(object sender, EventArgs e)
        {
            nr = 62;
            shift_tab(nr);
        }

        private void P63_Click(object sender, EventArgs e)
        {
            nr = 63;
            shift_tab(nr);
        }

        private void Q63_Click(object sender, EventArgs e)
        {
            nr = 63;
            shift_tab(nr);
        }

        private void P64_Click(object sender, EventArgs e)
        {
            nr = 64;
            shift_tab(nr);
        }

        private void Q64_Click(object sender, EventArgs e)
        {
            nr = 64;
            shift_tab(nr);
        }

        private void P65_Click(object sender, EventArgs e)
        {
            nr = 65;
            shift_tab(nr);
        }

        private void Q65_Click(object sender, EventArgs e)
        {
            nr = 65;
            shift_tab(nr);
        }

        private void P66_Click(object sender, EventArgs e)
        {
            nr = 66;
            shift_tab(nr);
        }

        private void Q66_Click(object sender, EventArgs e)
        {
            nr = 66;
            shift_tab(nr);
        }

        private void P67_Click(object sender, EventArgs e)
        {
            nr = 67;
            shift_tab(nr);
        }

        private void Q67_Click(object sender, EventArgs e)
        {
            nr = 67;
            shift_tab(nr);
        }

        private void P68_Click(object sender, EventArgs e)
        {
            nr = 68;
            shift_tab(nr);
        }

        private void Q68_Click(object sender, EventArgs e)
        {
            nr = 68;
            shift_tab(nr);
        }

        private void P69_Click(object sender, EventArgs e)
        {
            nr = 69;
            shift_tab(nr);
        }

        private void Q69_Click(object sender, EventArgs e)
        {
            nr = 69;
            shift_tab(nr);
        }

        private void P70_Click(object sender, EventArgs e)
        {
            nr = 70;
            shift_tab(nr);
        }

        private void Q70_Click(object sender, EventArgs e)
        {
            nr = 70;
            shift_tab(nr);
        }

        private void P71_Click(object sender, EventArgs e)
        {
            nr = 71;
            shift_tab(nr);
        }

        private void Q71_Click(object sender, EventArgs e)
        {
            nr = 71;
            shift_tab(nr);
        }

        private void P72_Click(object sender, EventArgs e)
        {
            nr = 72;
            shift_tab(nr);
        }

        private void Q72_Click(object sender, EventArgs e)
        {
            nr = 72;
            shift_tab(nr);
        }

        private void P73_Click(object sender, EventArgs e)
        {
            nr = 73;
            shift_tab(nr);
        }

        private void Q73_Click(object sender, EventArgs e)
        {
            nr = 73;
            shift_tab(nr);
        }

        private void P74_Click(object sender, EventArgs e)
        {
            nr = 74;
            shift_tab(nr);
        }

        private void Q74_Click(object sender, EventArgs e)
        {
            nr = 74;
            shift_tab(nr);
        }

        private void P75_Click(object sender, EventArgs e)
        {
            nr = 75;
            shift_tab(nr);
        }

        private void Q75_Click(object sender, EventArgs e)
        {
            nr = 75;
            shift_tab(nr);
        }

        private void P76_Click(object sender, EventArgs e)
        {
            nr = 76;
            shift_tab(nr);
        }

        private void Q76_Click(object sender, EventArgs e)
        {
            nr = 76;
            shift_tab(nr);
        }

        private void P77_Click(object sender, EventArgs e)
        {
            nr = 77;
            shift_tab(nr);
        }

        private void Q77_Click(object sender, EventArgs e)
        {
            nr = 77;
            shift_tab(nr);
        }

        private void P78_Click(object sender, EventArgs e)
        {
            nr = 78;
            shift_tab(nr);
        }

        private void Q78_Click(object sender, EventArgs e)
        {
            nr = 78;
            shift_tab(nr);
        }

        private void P79_Click(object sender, EventArgs e)
        {
            nr = 79;
            shift_tab(nr);
        }

        private void Q79_Click(object sender, EventArgs e)
        {
            nr = 79;
            shift_tab(nr);
        }

        private void P80_Click(object sender, EventArgs e)
        {
            nr = 80;
            shift_tab(nr);
        }

        private void Q80_Click(object sender, EventArgs e)
        {
            nr = 80;
            shift_tab(nr);
        }

        private void P81_Click(object sender, EventArgs e)
        {
            nr = 81;
            shift_tab(nr);
        }

        private void Q81_Click(object sender, EventArgs e)
        {
            nr = 81;
            shift_tab(nr);
        }

        private void P82_Click(object sender, EventArgs e)
        {
            nr = 82;
            shift_tab(nr);
        }

        private void Q82_Click(object sender, EventArgs e)
        {
            nr = 82;
            shift_tab(nr);
        }

        private void P83_Click(object sender, EventArgs e)
        {
            nr = 83;
            shift_tab(nr);
        }

        private void Q83_Click(object sender, EventArgs e)
        {
            nr = 83;
            shift_tab(nr);
        }

        private void P84_Click(object sender, EventArgs e)
        {
            nr = 84;
            shift_tab(nr);
        }

        private void Q84_Click(object sender, EventArgs e)
        {
            nr = 84;
            shift_tab(nr);
        }

        private void P85_Click(object sender, EventArgs e)
        {
            nr = 85;
            shift_tab(nr);
        }

        private void Q85_Click(object sender, EventArgs e)
        {
            nr = 85;
            shift_tab(nr);
        }

        private void P86_Click(object sender, EventArgs e)
        {
            nr = 86;
            shift_tab(nr);
        }

        private void Q86_Click(object sender, EventArgs e)
        {
            nr = 86;
            shift_tab(nr);
        }

        private void P87_Click(object sender, EventArgs e)
        {
            nr = 87;
            shift_tab(nr);
        }

        private void Q87_Click(object sender, EventArgs e)
        {
            nr = 87;
            shift_tab(nr);
        }

        private void P88_Click(object sender, EventArgs e)
        {
            nr = 88;
            shift_tab(nr);
        }

        private void Q88_Click(object sender, EventArgs e)
        {
            nr = 88;
            shift_tab(nr);
        }

        private void P89_Click(object sender, EventArgs e)
        {
            nr = 89;
            shift_tab(nr);
        }

        private void Q89_Click(object sender, EventArgs e)
        {
            nr = 89;
            shift_tab(nr);
        }

        private void P90_Click(object sender, EventArgs e)
        {
            nr = 90;
            shift_tab(nr);
        }

        private void Q90_Click(object sender, EventArgs e)
        {
            nr = 90;
            shift_tab(nr);
        }

        private void P91_Click(object sender, EventArgs e)
        {
            nr = 91;
            shift_tab(nr);
        }

        private void Q91_Click(object sender, EventArgs e)
        {
            nr = 91;
            shift_tab(nr);
        }

        private void P92_Click(object sender, EventArgs e)
        {
            nr = 92;
            shift_tab(nr);
        }

        private void Q92_Click(object sender, EventArgs e)
        {
            nr = 92;
            shift_tab(nr);
        }

        private void P93_Click(object sender, EventArgs e)
        {
            nr = 93;
            shift_tab(nr);
        }

        private void Q93_Click(object sender, EventArgs e)
        {
            nr = 93;
            shift_tab(nr);
        }

        private void P94_Click(object sender, EventArgs e)
        {
            nr = 94;
            shift_tab(nr);
        }

        private void Q94_Click(object sender, EventArgs e)
        {
            nr = 94;
            shift_tab(nr);
        }

        private void P95_Click(object sender, EventArgs e)
        {
            nr = 95;
            shift_tab(nr);
        }

        private void Q95_Click(object sender, EventArgs e)
        {
            nr = 95;
            shift_tab(nr);
        }

        private void P96_Click(object sender, EventArgs e)
        {
            nr = 96;
            shift_tab(nr);
        }

        private void Q96_Click(object sender, EventArgs e)
        {
            nr = 96;
            shift_tab(nr);
        }

        private void P97_Click(object sender, EventArgs e)
        {
            nr = 97;
            shift_tab(nr);
        }

        private void Q97_Click(object sender, EventArgs e)
        {
            nr = 97;
            shift_tab(nr);
        }

        private void P98_Click(object sender, EventArgs e)
        {
            nr = 98;
            shift_tab(nr);
        }

        private void Q98_Click(object sender, EventArgs e)
        {
            nr = 98;
            shift_tab(nr);
        }

        private void P99_Click(object sender, EventArgs e)
        {
            nr = 99;
            shift_tab(nr);
        }

        private void Q99_Click(object sender, EventArgs e)
        {
            nr = 99;
            shift_tab(nr);
        }

        private void P100_Click(object sender, EventArgs e)
        {
            nr = 100;
            shift_tab(nr);
        }

        private void Q100_Click(object sender, EventArgs e)
        {
            nr = 100;
            shift_tab(nr);
        }

        private void P101_Click(object sender, EventArgs e)
        {
            nr = 101;
            shift_tab(nr);
        }

        private void Q101_Click(object sender, EventArgs e)
        {
            nr = 101;
            shift_tab(nr);
        }

        private void P102_Click(object sender, EventArgs e)
        {
            nr = 102;
            shift_tab(nr);
        }

        private void Q102_Click(object sender, EventArgs e)
        {
            nr = 102;
            shift_tab(nr);
        }

        private void P103_Click(object sender, EventArgs e)
        {
            nr = 103;
            shift_tab(nr);
        }

        private void Q103_Click(object sender, EventArgs e)
        {
            nr = 103;
            shift_tab(nr);
        }

        private void P104_Click(object sender, EventArgs e)
        {
            nr = 104;
            shift_tab(nr);
        }

        private void Q104_Click(object sender, EventArgs e)
        {
            nr = 104;
            shift_tab(nr);
        }

        private void P105_Click(object sender, EventArgs e)
        {
            nr = 105;
            shift_tab(nr);
        }

        private void Q105_Click(object sender, EventArgs e)
        {
            nr = 105;
            shift_tab(nr);
        }

        private void P106_Click(object sender, EventArgs e)
        {
            nr = 106;
            shift_tab(nr);
        }

        private void Q106_Click(object sender, EventArgs e)
        {
            nr = 106;
            shift_tab(nr);
        }

        private void P107_Click(object sender, EventArgs e)
        {
            nr = 107;
            shift_tab(nr);
        }

        private void Q107_Click(object sender, EventArgs e)
        {
            nr = 107;
            shift_tab(nr);
        }

        private void P108_Click(object sender, EventArgs e)
        {
            nr = 108;
            shift_tab(nr);
        }

        private void Q108_Click(object sender, EventArgs e)
        {
            nr = 108;
            shift_tab(nr);
        }

        private void P109_Click(object sender, EventArgs e)
        {
            nr = 109;
            shift_tab(nr);
        }

        private void Q109_Click(object sender, EventArgs e)
        {
            nr = 109;
            shift_tab(nr);
        }

        private void P110_Click(object sender, EventArgs e)
        {
            nr = 110;
            shift_tab(nr);
        }

        private void Q110_Click(object sender, EventArgs e)
        {
            nr = 110;
            shift_tab(nr);
        }

        private void P111_Click(object sender, EventArgs e)
        {
            nr = 111;
            shift_tab(nr);
        }

        private void Q111_Click(object sender, EventArgs e)
        {
            nr = 111;
            shift_tab(nr);
        }

        private void P112_Click(object sender, EventArgs e)
        {
            nr = 112;
            shift_tab(nr);
        }

        private void Q112_Click(object sender, EventArgs e)
        {
            nr = 112;
            shift_tab(nr);
        }

        private void P113_Click(object sender, EventArgs e)
        {
            nr = 113;
            shift_tab(nr);
        }

        private void Q113_Click(object sender, EventArgs e)
        {
            nr = 113;
            shift_tab(nr);
        }

        private void P114_Click(object sender, EventArgs e)
        {
            nr = 114;
            shift_tab(nr);
        }

        private void Q114_Click(object sender, EventArgs e)
        {
            nr = 114;
            shift_tab(nr);
        }

        private void P115_Click(object sender, EventArgs e)
        {
            nr = 115;
            shift_tab(nr);
        }

        private void Q115_Click(object sender, EventArgs e)
        {
            nr = 115;
            shift_tab(nr);
        }

        private void P116_Click(object sender, EventArgs e)
        {
            nr = 116;
            shift_tab(nr);
        }

        private void Q116_Click(object sender, EventArgs e)
        {
            nr = 116;
            shift_tab(nr);
        }

        private void P117_Click(object sender, EventArgs e)
        {
            nr = 117;
            shift_tab(nr);
        }

        private void Q117_Click(object sender, EventArgs e)
        {
            nr = 117;
            shift_tab(nr);
        }

        private void P118_Click(object sender, EventArgs e)
        {
            nr = 118;
            shift_tab(nr);
        }

        private void Q118_Click(object sender, EventArgs e)
        {
            nr = 118;
            shift_tab(nr);
        }

        private void P119_Click(object sender, EventArgs e)
        {
            nr = 119;
            shift_tab(nr);
        }

        private void Q119_Click(object sender, EventArgs e)
        {
            nr = 119;
            shift_tab(nr);
        }

        private void P120_Click(object sender, EventArgs e)
        {
            nr = 120;
            shift_tab(nr);
        }

        private void Q120_Click(object sender, EventArgs e)
        {
            nr = 120;
            shift_tab(nr);
        }

        private void P121_Click(object sender, EventArgs e)
        {
            nr = 121;
            shift_tab(nr);
        }

        private void Q121_Click(object sender, EventArgs e)
        {
            nr = 121;
            shift_tab(nr);
        }

        private void P122_Click(object sender, EventArgs e)
        {
            nr = 122;
            shift_tab(nr);
        }

        private void Q122_Click(object sender, EventArgs e)
        {
            nr = 122;
            shift_tab(nr);
        }

        private void P123_Click(object sender, EventArgs e)
        {
            nr = 123;
            shift_tab(nr);
        }

        private void Q123_Click(object sender, EventArgs e)
        {
            nr = 123;
            shift_tab(nr);
        }

        private void P124_Click(object sender, EventArgs e)
        {
            nr = 124;
            shift_tab(nr);
        }

        private void Q124_Click(object sender, EventArgs e)
        {
            nr = 124;
            shift_tab(nr);
        }

        private void P125_Click(object sender, EventArgs e)
        {
            nr = 125;
            shift_tab(nr);
        }

        private void Q125_Click(object sender, EventArgs e)
        {
            nr = 125;
            shift_tab(nr);
        }

        private void P126_Click(object sender, EventArgs e)
        {
            nr = 126;
            shift_tab(nr);
        }

        private void Q126_Click(object sender, EventArgs e)
        {
            nr = 126;
            shift_tab(nr);
        }

        private void P127_Click(object sender, EventArgs e)
        {
            nr = 127;
            shift_tab(nr);
        }

        private void Q127_Click(object sender, EventArgs e)
        {
            nr = 127;
            shift_tab(nr);
        }

        private void P128_Click(object sender, EventArgs e)
        {
            nr = 128;
            shift_tab(nr);
        }

        private void Q128_Click(object sender, EventArgs e)
        {
            nr = 128;
            shift_tab(nr);
        }

        private void P129_Click(object sender, EventArgs e)
        {
            nr = 129;
            shift_tab(nr);
        }

        private void Q129_Click(object sender, EventArgs e)
        {
            nr = 129;
            shift_tab(nr);
        }

        private void P130_Click(object sender, EventArgs e)
        {
            nr = 130;
            shift_tab(nr);
        }

        private void Q130_Click(object sender, EventArgs e)
        {
            nr = 130;
            shift_tab(nr);
        }

        private void P131_Click(object sender, EventArgs e)
        {
            nr = 131;
            shift_tab(nr);
        }

        private void Q131_Click(object sender, EventArgs e)
        {
            nr = 131;
            shift_tab(nr);
        }

        private void P132_Click(object sender, EventArgs e)
        {
            nr = 132;
            shift_tab(nr);
        }

        private void Q132_Click(object sender, EventArgs e)
        {
            nr = 132;
            shift_tab(nr);
        }

        private void P133_Click(object sender, EventArgs e)
        {
            nr = 133;
            shift_tab(nr);
        }

        private void Q133_Click(object sender, EventArgs e)
        {
            nr = 133;
            shift_tab(nr);
        }

        private void P134_Click(object sender, EventArgs e)
        {
            nr = 134;
            shift_tab(nr);
        }

        private void Q134_Click(object sender, EventArgs e)
        {
            nr = 134;
            shift_tab(nr);
        }

        private void P135_Click(object sender, EventArgs e)
        {
            nr = 135;
            shift_tab(nr);
        }

        private void Q135_Click(object sender, EventArgs e)
        {
            nr = 135;
            shift_tab(nr);
        }

        private void P136_Click(object sender, EventArgs e)
        {
            nr = 136;
            shift_tab(nr);
        }

        private void Q136_Click(object sender, EventArgs e)
        {
            nr = 136;
            shift_tab(nr);
        }

        private void P137_Click(object sender, EventArgs e)
        {
            nr = 137;
            shift_tab(nr);
        }

        private void Q137_Click(object sender, EventArgs e)
        {
            nr = 137;
            shift_tab(nr);
        }

        private void P138_Click(object sender, EventArgs e)
        {
            nr = 138;
            shift_tab(nr);
        }

        private void Q138_Click(object sender, EventArgs e)
        {
            nr = 138;
            shift_tab(nr);
        }

        private void P139_Click(object sender, EventArgs e)
        {
            nr = 139;
            shift_tab(nr);
        }

        private void Q139_Click(object sender, EventArgs e)
        {
            nr = 139;
            shift_tab(nr);
        }

        private void P140_Click(object sender, EventArgs e)
        {
            nr = 140;
            shift_tab(nr);
        }

        private void Q140_Click(object sender, EventArgs e)
        {
            nr = 140;
            shift_tab(nr);
        }

        private void P141_Click(object sender, EventArgs e)
        {
            nr = 141;
            shift_tab(nr);
        }

        private void Q141_Click(object sender, EventArgs e)
        {
            nr = 141;
            shift_tab(nr);
        }

        private void P142_Click(object sender, EventArgs e)
        {
            nr = 142;
            shift_tab(nr);
        }

        private void Q142_Click(object sender, EventArgs e)
        {
            nr = 142;
            shift_tab(nr);
        }

        private void P143_Click(object sender, EventArgs e)
        {
            nr = 143;
            shift_tab(nr);
        }

        private void Q143_Click(object sender, EventArgs e)
        {
            nr = 143;
            shift_tab(nr);
        }

        private void P144_Click(object sender, EventArgs e)
        {
            nr = 144;
            shift_tab(nr);
        }

        private void Q144_Click(object sender, EventArgs e)
        {
            nr = 144;
            shift_tab(nr);
        }

        private void P145_Click(object sender, EventArgs e)
        {
            nr = 145;
            shift_tab(nr);
        }

        private void Q145_Click(object sender, EventArgs e)
        {
            nr = 145;
            shift_tab(nr);
        }

        private void P146_Click(object sender, EventArgs e)
        {
            nr = 146;
            shift_tab(nr);
        }

        private void Q146_Click(object sender, EventArgs e)
        {
            nr = 146;
            shift_tab(nr);
        }

        private void P147_Click(object sender, EventArgs e)
        {
            nr = 147;
            shift_tab(nr);
        }

        private void Q147_Click(object sender, EventArgs e)
        {
            nr = 147;
            shift_tab(nr);
        }

        private void P148_Click(object sender, EventArgs e)
        {
            nr = 148;
            shift_tab(nr);
        }

        private void Q148_Click(object sender, EventArgs e)
        {
            nr = 148;
            shift_tab(nr);
        }

        private void P149_Click(object sender, EventArgs e)
        {
            nr = 149;
            shift_tab(nr);
        }

        private void Q149_Click(object sender, EventArgs e)
        {
            nr = 149;
            shift_tab(nr);
        }

        private void P150_Click(object sender, EventArgs e)
        {
            nr = 150;
            shift_tab(nr);
        }

        private void Q150_Click(object sender, EventArgs e)
        {
            nr = 150;
            shift_tab(nr);
        }

        private void P151_Click(object sender, EventArgs e)
        {
            nr = 151;
            shift_tab(nr);
        }

        private void Q151_Click(object sender, EventArgs e)
        {
            nr = 151;
            shift_tab(nr);
        }

        private void P152_Click(object sender, EventArgs e)
        {
            nr = 152;
            shift_tab(nr);
        }

        private void Q152_Click(object sender, EventArgs e)
        {
            nr = 152;
            shift_tab(nr);
        }

        private void P153_Click(object sender, EventArgs e)
        {
            nr = 153;
            shift_tab(nr);
        }

        private void Q153_Click(object sender, EventArgs e)
        {
            nr = 153;
            shift_tab(nr);
        }

        private void P154_Click(object sender, EventArgs e)
        {
            nr = 154;
            shift_tab(nr);
        }

        private void Q154_Click(object sender, EventArgs e)
        {
            nr = 154;
            shift_tab(nr);
        }

        private void P155_Click(object sender, EventArgs e)
        {
            nr = 155;
            shift_tab(nr);
        }

        private void P156_Click(object sender, EventArgs e)
        {
            nr = 156;
            shift_tab(nr);
        }

        private void Q156_Click(object sender, EventArgs e)
        {
            nr = 156;
            shift_tab(nr);
        }

        private void P157_Click(object sender, EventArgs e)
        {
            nr = 157;
            shift_tab(nr);
        }

        private void Q157_Click(object sender, EventArgs e)
        {
            nr = 157;
            shift_tab(nr);
        }

        private void P158_Click(object sender, EventArgs e)
        {
            nr = 158;
            shift_tab(nr);
        }

        private void Q158_Click(object sender, EventArgs e)
        {
            nr = 158;
            shift_tab(nr);
        }

        private void P159_Click(object sender, EventArgs e)
        {
            nr = 159;
            shift_tab(nr);
        }

        private void Q159_Click(object sender, EventArgs e)
        {
            nr = 159;
            shift_tab(nr);
        }

        private void P160_Click(object sender, EventArgs e)
        {
            nr = 160;
            shift_tab(nr);
        }

        private void Q160_Click(object sender, EventArgs e)
        {
            nr = 160;
            shift_tab(nr);
        }

        private void P161_Click(object sender, EventArgs e)
        {
            nr = 161;
            shift_tab(nr);
        }
        private void Q161_Click(object sender, EventArgs e)
        {
            nr = 161;
            shift_tab(nr);
        }
        private void P162_Click(object sender, EventArgs e)
        {
            nr = 162;
            shift_tab(nr);
        }

        private void Q162_Click(object sender, EventArgs e)
        {
            nr = 162;
            shift_tab(nr);
        }

        private void P163_Click(object sender, EventArgs e)
        {

            nr = 163;
            shift_tab(nr);
        }

        private void Q163_Click(object sender, EventArgs e)
        {
            nr = 163;
            shift_tab(nr);
        }

        private void P164_Click(object sender, EventArgs e)
        {
            nr = 164;
            shift_tab(nr);
        }

        private void Q164_Click(object sender, EventArgs e)
        {
            nr = 164;
            shift_tab(nr);
        }

        private void P165_Click(object sender, EventArgs e)
        {
            nr = 165;
            shift_tab(nr);
        }

        private void Q165_Click(object sender, EventArgs e)
        {
            nr = 165;
            shift_tab(nr);
        }

        private void P166_Click(object sender, EventArgs e)
        {
            nr = 166;
            shift_tab(nr);
        }

        private void Q166_Click(object sender, EventArgs e)
        {
            nr = 166;
            shift_tab(nr);
        }

        private void P167_Click(object sender, EventArgs e)
        {
            nr = 167;
            shift_tab(nr);
        }

        private void Q167_Click(object sender, EventArgs e)
        {
            nr = 167;
            shift_tab(nr);
        }

        private void P168_Click(object sender, EventArgs e)
        {
            nr = 168;
            shift_tab(nr);
        }

        private void Q168_Click(object sender, EventArgs e)
        {
            nr = 168;
            shift_tab(nr);
        }

        private void P169_Click(object sender, EventArgs e)
        {
            nr = 169;
            shift_tab(nr);
        }

        private void Q169_Click(object sender, EventArgs e)
        {
            nr = 169;
            shift_tab(nr);
        }

        private void P170_Click(object sender, EventArgs e)
        {
            nr = 170;
            shift_tab(nr);

        }

        private void mafiamember_Click(object sender, EventArgs e)
        {
            meme++;
            afis_meme();
         
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

        private void Biog2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var form5 = new Form5();
            form5.Closed += (s, args) => this.Close();
            form5.Show();
        }

        private void NU_Click(object sender, EventArgs e)
        { 
        }

        private void DA_Click(object sender, EventArgs e)
        {
            
        }

        private void Next2_Click_1(object sender, EventArgs e)
        {
            nr++;
            shift_tab(nr);
        }



        private void mafiamember_Click_1(object sender, EventArgs e)
        {
            meme++;afis_meme();
        }

        private void DA_Click_3(object sender, EventArgs e)
        {
            if (refuz == 2)
            {
                interogatoriu.Visible = DA.Visible = NU.Visible = mafiamember.Visible = false;

            }else
            {
                DA.Visible = NU.Visible = false;
                interogatoriu.Text = "Ma gandeam ca o sa- ti placa...";

                var form4 = new Form4();
                form4.Closed += (s, args) => this.Close();
                form4.Show();
            }
        }

        private void NU_Click_3(object sender, EventArgs e)
        {
            refuz++;
            if (refuz == 1)
            {
                interogatoriu.Text = "Poate fi ultima sansa de a vedea meme- uri.";
            }else if (refuz == 2)
            {
                interogatoriu.Text = "Esti sigur ca vrei sa ma refuzi?";
            }else if (refuz == 3)
            {
               
                var form4 = new Form4();
                form4.Closed += (s, args) => this.Close();
                form4.Show();

                DA.Visible = NU.Visible = false;
                interogatoriu.Text = "Asa ma gandeam si eu!";
            }
        }

        private void stanga_output_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Q1_Click_1(object sender, EventArgs e)
        {
            nr = 1;
            shift_tab(nr);
        }

        private void SC2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form6 = new Form6();
            form6.Closed += (s, args) => this.Close();
            form6.Show();
        }

        private void label36_Click(object sender, EventArgs e)
        {

           
        }

        private void events_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }


        void afis_meme()
        {
            if(meme==0)interogatoriu.Visible = DA.Visible = NU.Visible = mafiamember.Visible = false;

            if (memes == false)
            {
                if (meme == 1)
                {
                    interogatoriu.Visible = DA.Visible = NU.Visible = mafiamember.Visible = false;

                    interogatoriu.Visible = mafiamember.Visible = true;
                    interogatoriu.Text = "Hey, tu! Apasa-ma ca sa comunicam!";
                }
                else if (meme == 2)
                {
                    interogatoriu.Visible = DA.Visible = NU.Visible = mafiamember.Visible = false;

                    interogatoriu.Text = "Eu apar odata cu panel-ul albastru.";
                    interogatoriu.Visible = mafiamember.Visible = true;
                }
                else if (meme == 3)
                {
                    interogatoriu.Visible = DA.Visible = NU.Visible = mafiamember.Visible = false;

                    interogatoriu.Text = "Si dispar odata cu el.";
                    interogatoriu.Visible = mafiamember.Visible = true;
                }
                else if (meme == 4)
                {
                    interogatoriu.Visible = DA.Visible = NU.Visible = mafiamember.Visible = false;

                    interogatoriu.Text = "Sper ca ai retinut...";
                    interogatoriu.Visible = mafiamember.Visible = true;
                }
                else if (meme == 5)
                {
                    interogatoriu.Visible = DA.Visible = NU.Visible = mafiamember.Visible = false;

                    interogatoriu.Text = "Ia zi, vrei niste meme- uri?";
                    memes = true; refuz = 0;
                    interogatoriu.Visible = mafiamember.Visible = DA.Visible = NU.Visible = true;
                  
                }
            }else
            {
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
}
