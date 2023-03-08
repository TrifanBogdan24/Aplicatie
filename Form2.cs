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
    public partial class Form2 : Form
    {
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
        bool acces_tasta,acces_variante = false,aces=false;
        int aspect = 1;
        int question_number;
        int nr = 0;
        int question,corecte_generale, corecte_t1, corecte_t2, corecte_t3, corecte_t4,corecte_t5,corecte_genarale;
        bool aces_generale=false, aces_t1=false, aces_t2=false, aces_t3=false,aces_t4=false,aces_t5=false;

        string s1, s2, s3, s4, s5;
        int r1, r2;

       
        int x1, x2, y1, y2, z1, z2;
        int v,inserat;

        int it_c=0, it_g = 0;
        string sir;
        string motivator;
        double percentage;

        int meme;
        int refuz;
        bool memes;

        int culoare_buttoane;

        string str, str1, str2;

        int r, g, b;
        string q;

        int pozitie;

        int frecv;

        bool first_back = true, first_intrebare = true, first_descriere = true;


        int type; //1(variante); 2- an;3 -raspuns dublu; 4 - inserare


        private int quick = 1200; //o secunda = 60

        bool merge_cronometrul = false;



        int frecventa=0, aspect_variante=1, aspect_cronometru=1,frecv_ok=0;
        int aux_variante, aux_cronometru;


        int which_one;
        int nr_inserare;



         private int under = 25; //o secunda = 60

        bool schimbare = false,schimbare1=false,schimbare2=false;
        bool afis1,afis2;

        public Form2()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            culoare_buttoane = 6;
            change_color();

            //      negru, alb, galben




            timp.Visible = imagine_ceas.Visible = false;
            stanga_output.Visible = false;
            stanga_output.BackColor = Color.FromArgb(22, 18, 88);
            TAB.BackgroundImage = Properties.Resources.bars;
            TAB.BackColor = Color.FromArgb(0, 0, 0, 0);


            ARROW.BackgroundImage = Properties.Resources.left;
            panel1.BackgroundImage = Properties.Resources.bakcground1;

            x1 = 22; y1 = 18; z1 = 126; //bleumarin
            x2 = 236; y2 = 240; z2 = 241; ///alb




            E2.BackColor = S2.BackColor = SC2.BackColor = Biog2.BackColor = Color.FromArgb(0, x1, y1, z1);
            E2.ForeColor = S2.ForeColor = Biog2.ForeColor = SC2.ForeColor = Color.FromArgb(x2, y2, z2);

            E1.FlatStyle = E2.FlatStyle = SC1.FlatStyle = SC2.FlatStyle = Biog1.FlatStyle = Biog2.FlatStyle = S1.FlatStyle = S2.FlatStyle = FlatStyle.Flat;

            E1.Font = SC1.Font = S1.Font = Biog1.Font = new Font("Microsoft Sans Serif", 20);
            E1.ForeColor = SC1.ForeColor = S1.ForeColor = Biog1.ForeColor = Color.FromArgb(x2, y2, z2);


            E2.Font = SC2.Font = S2.Font = Biog2.Font = new Font("Microsoft Sans Serif", 20);


            SC1.ForeColor = S1.ForeColor = Biog1.ForeColor = Color.FromArgb(x2, y2, z2);



            E2.MouseEnter += OnMouseEnterE2; E2.MouseLeave += OnMouseLeaveE2;
            Biog2.MouseEnter += OnMouseEnterBiog2; Biog2.MouseLeave += OnMouseLeaveBiog2;
            S2.MouseEnter += OnMouseEnterS2; S2.MouseLeave += OnMouseLeaveS2;
            SC2.MouseEnter += OnMouseEnterSC2; SC2.MouseLeave += OnMouseLeaveSC2;

            E1.MouseEnter += OnMouseEnterE1; E1.MouseLeave += OnMouseLeaveE1;
            SC1.MouseEnter += OnMouseEnterSC1; SC1.MouseLeave += OnMouseLeaveSC1;
            S1.MouseEnter += OnMouseEnterS1; S1.MouseLeave += OnMouseLeaveS1;
            Biog1.MouseEnter += OnMouseEnterBiog1; Biog1.MouseLeave += OnMouseLeaveBiog1;

            Q1.FlatStyle = Q2.FlatStyle = Q3.FlatStyle = Q4.FlatStyle = Q5.FlatStyle = Q6.FlatStyle = FlatStyle.Flat;
            Q1.BackColor = Q2.BackColor = Q3.BackColor = Q4.BackColor = Q5.BackColor = Q6.BackColor = Color.FromArgb(0, x1, y1, z1);

            Q1.ForeColor = Q2.ForeColor = Q3.ForeColor = Q4.ForeColor = Q5.ForeColor = Q6.ForeColor = Color.FromArgb(x2, y2, z2);


            Q1.Cursor = Q2.Cursor = Q3.Cursor = Q4.Cursor = Q5.Cursor =Q6.Cursor= E1.Cursor = E2.Cursor = S1.Cursor = S2.Cursor = SC1.Cursor = SC2.Cursor = Biog1.Cursor = Biog2.Cursor = TAB.Cursor = ARROW.Cursor = Cursors.Hand;


            qlabel.ForeColor =descriere.ForeColor= Color.FromArgb(22, 18, 126);


            //  pictureBox1.BackgroundImage = Properties.Resources.mafiot;

            //       mafiamember.Visible = interogatoriu.Visible = false;

            meme = 0; refuz = 0; memes = false;
            interogatoriu.Visible = DA.Visible = NU.Visible = mafiamember.Visible = false;


            interogatoriu.Visible = DA.Visible = NU.Visible = mafiamember.Visible = false;

            interogatoriu.ForeColor = Color.White;
            DA.ForeColor = NU.ForeColor = Color.White;
            DA.MouseEnter += OnMouseEnterDA; DA.MouseLeave += OnMouseLeaveDA;
            NU.MouseEnter += OnMouseEnterNU; NU.MouseLeave += OnMouseLeaveNU;

            panel2.Visible = false;


            underline_inserare_rasp.Visible = false;


            //color picker




            Close.BackgroundImage = Properties.Resources.square_remove_button__1_;
            Close.Cursor = radioButton1.Cursor = radioButton2.Cursor =mostra_rot.Cursor= Cursors.Hand;


            Close.MouseEnter += OnMouseEnterClose;
            Close.MouseLeave += OnMouseLeaveClose;


            comboBox1.DataSource = typeof(Color).GetProperties()
    .Where(x => x.PropertyType == typeof(Color))
    .Select(x => x.GetValue(null)).ToList();



            comboBox1.MaxDropDownItems = 10;
            comboBox1.IntegralHeight = false;
            comboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DrawItem += comboBox1_DrawItem;













            cul_intrebare.BackColor = qlabel.ForeColor;
            cul_descriere.BackColor = descriere.ForeColor;
            cul_back.BackColor = panel1.BackColor;
            r = 255; g = 255; b = 255;

            aux_back.Visible = aux_descriere.Visible = aux_intrebare.Visible = aux_rot.Visible = false;



            aux_back.BackColor = cul_back.BackColor;
            aux_intrebare.BackColor = cul_intrebare.BackColor;
            aux_descriere.BackColor = cul_descriere.BackColor;

            aux_rot.BorderColor = tasta1.BorderColor;
            aux_rot.OnHoverBorderColor = tasta1.OnHoverBorderColor;
            aux_rot.ButtonColor = tasta1.ButtonColor;
            aux_rot.OnHoverButtonColor = tasta1.OnHoverButtonColor;
            aux_rot.TextColor = tasta1.TextColor;
            aux_rot.OnHoverTextColor = tasta1.OnHoverTextColor;





            rosu.Value = verde.Value = albastru.Value = 255;
            red.Text = green.Text = blue.Text = "255";


            mostra_rot.BorderColor = bordercolorbotton.BackColor = tasta7.BorderColor;

            mostra_rot.ButtonColor = buttoncolorbutton.BackColor = tasta7.ButtonColor;

            mostra_rot.TextColor = textcolorbutton.BackColor = tasta7.TextColor;

            mostra_rot.OnHoverBorderColor = hbordercolorbotton.BackColor = tasta7.OnHoverBorderColor;

            mostra_rot.OnHoverButtonColor = hbuttoncolorbutton.BackColor = tasta7.OnHoverButtonColor;


            mostra_rot.OnHoverTextColor = htextcolorbutton.BackColor = tasta7.OnHoverTextColor;


            cul_back.Visible = cul_descriere.Visible = cul_intrebare.Visible = true;
            aux_back.Visible = aux_intrebare.Visible = aux_descriere.Visible = aux_rot.Visible= true;

            tasta0.Font = tasta1.Font = tasta2.Font = tasta3.Font = tasta4.Font = tasta5.Font = tasta6.Font = tasta7.Font = tasta8.Font = tasta9.Font = tasta_sterge.Font = new Font("Microsoft Sans Serif", 20);




            //gata cu color picker

            mafiamember.BackgroundImage = Properties.Resources.mafiot;
            DA.Cursor = NU.Cursor = interogatoriu.Cursor = mafiamember.Cursor = Cursors.Hand;

            underline1.Visible = underline2.Visible = false;
            cul_back.Visible = cul_descriere.Visible = cul_intrebare.Visible = false;
            aux_back.Visible = aux_intrebare.Visible = aux_descriere.Visible = aux_rot.Visible = false;

            timp.Visible = imagine_ceas.Visible = false;

            descriere.Visible = false;

            
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;


            under = 0;
            progrestime.Interval = 1;
            progrestime.Tick += new EventHandler(progrestime_Tick);
            progrestime.Enabled = true;

        }


        


        private void OnMouseEnterClose(object sender, EventArgs e)
        {
           Close.BackgroundImage = Properties.Resources.square_remove_button;
        }
        private void OnMouseLeaveClose(object sender, EventArgs e)
        {
            Close.BackgroundImage = Properties.Resources.square_remove_button__1_;
        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index >= 0)
            {

                var txt = comboBox1.GetItemText(comboBox1.Items[e.Index]);
                var color = (Color)comboBox1.Items[e.Index];
                var r1 = new Rectangle(e.Bounds.Left + 1, e.Bounds.Top + 1,
                    2 * (e.Bounds.Height - 2), e.Bounds.Height - 2);
                var r2 = Rectangle.FromLTRB(r1.Right + 2, e.Bounds.Top,
                    e.Bounds.Right, e.Bounds.Bottom);
                using (var b = new SolidBrush(color))
                    e.Graphics.FillRectangle(b, r1);
                e.Graphics.DrawRectangle(Pens.Black, r1);
                TextRenderer.DrawText(e.Graphics, txt, comboBox1.Font, r2,
                    comboBox1.ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            }
        }





















        bool IsDigitsOnly(string str)
        {

            if (str == "*primul an"||str=="al doilea an") return true;
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
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
            Error,
            Nothing,
            Final,
            Perfect
        }
        private Form_Alert.enmAction action;

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert("Success", motivator, sir, type);
        }
        //tot:1-125
        //ww1:27-65
        //ww2:66-99
        //razboiul rece:100-125




        void change_color()
        {
            if (culoare_buttoane == 5) //albastru pe negru
            {
                tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = Color.White;
                tasta0.FlatStyle = tasta1.FlatStyle = tasta2.FlatStyle = tasta3.FlatStyle = tasta4.FlatStyle = tasta5.FlatStyle = tasta6.FlatStyle = tasta7.FlatStyle = tasta8.FlatStyle = tasta9.FlatStyle = tasta_sterge.FlatStyle = FlatStyle.Flat;
                tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor = Color.White;
                tasta0.TextColor = tasta1.TextColor = tasta2.TextColor = tasta3.TextColor = tasta4.TextColor = tasta5.TextColor = tasta6.TextColor = tasta6.TextColor = tasta7.TextColor = tasta8.TextColor = tasta9.TextColor = tasta_sterge.TextColor = Color.FromArgb(22,18,126);
                   

                tasta0.Cursor = tasta1.Cursor = tasta2.Cursor = tasta3.Cursor = tasta4.Cursor = tasta5.Cursor = tasta6.Cursor = tasta7.Cursor = tasta8.Cursor = tasta9.Cursor = tasta_sterge.Cursor = V1.Cursor = V01.Cursor = V2.Cursor = V02.Cursor = V3.Cursor = V03.Cursor = V4.Cursor = V04.Cursor = OK.Cursor = Enter.Cursor = format.Cursor = Cursors.Hand;


                tasta0.BorderColor = tasta1.BorderColor = tasta2.BorderColor = tasta3.BorderColor = tasta4.BorderColor = tasta5.BorderColor = tasta6.BorderColor = tasta7.BorderColor = tasta8.BorderColor = tasta9.BorderColor = tasta_sterge.BorderColor = Color.FromArgb(22, 18, 126);
                tasta0.OnHoverBorderColor = tasta1.OnHoverBorderColor = tasta2.OnHoverBorderColor = tasta3.OnHoverBorderColor = tasta4.OnHoverBorderColor = tasta5.OnHoverBorderColor = tasta6.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta8.OnHoverBorderColor = tasta9.OnHoverBorderColor = tasta_sterge.OnHoverBorderColor = Color.FromArgb(22, 18, 126);
                tasta0.OnHoverButtonColor = tasta1.OnHoverButtonColor = tasta2.OnHoverButtonColor = tasta3.OnHoverButtonColor = tasta4.OnHoverButtonColor = tasta5.OnHoverButtonColor = tasta6.OnHoverButtonColor = tasta7.OnHoverButtonColor = tasta8.OnHoverButtonColor = tasta9.OnHoverButtonColor = tasta_sterge.OnHoverButtonColor = Color.FromArgb(22,18,126);
                tasta0.OnHoverTextColor = tasta1.OnHoverTextColor = tasta2.OnHoverTextColor = tasta3.OnHoverTextColor = tasta4.OnHoverTextColor = tasta5.OnHoverTextColor = tasta6.OnHoverTextColor = tasta7.OnHoverTextColor = tasta8.OnHoverTextColor = tasta9.OnHoverTextColor = tasta_sterge.OnHoverTextColor = Color.Black;

                tasta_sterge.BackColor = Color.White;
            }else if (culoare_buttoane == 6) //albastr si alb
            {
               tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = Color.White;
                tasta0.FlatStyle = tasta1.FlatStyle = tasta2.FlatStyle = tasta3.FlatStyle = tasta4.FlatStyle = tasta5.FlatStyle = tasta6.FlatStyle = tasta7.FlatStyle = tasta8.FlatStyle = tasta9.FlatStyle = tasta_sterge.FlatStyle = FlatStyle.Flat;
                tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor = Color.White;
                tasta0.ButtonColor = tasta1.ButtonColor = tasta2.ButtonColor = tasta3.ButtonColor = tasta4.ButtonColor = tasta5.ButtonColor = tasta6.ButtonColor = tasta7.ButtonColor = tasta8.ButtonColor = tasta9.ButtonColor = tasta_sterge.ButtonColor = Color.White;
                tasta0.TextColor = tasta1.TextColor = tasta2.TextColor = tasta3.TextColor = tasta4.TextColor = tasta5.TextColor = tasta6.TextColor = tasta6.TextColor = tasta7.TextColor = tasta8.TextColor = tasta9.TextColor = tasta_sterge.TextColor = Color.FromArgb(22, 18, 126);

                tasta0.Cursor = tasta1.Cursor = tasta2.Cursor = tasta3.Cursor = tasta4.Cursor = tasta5.Cursor = tasta6.Cursor = tasta7.Cursor = tasta8.Cursor = tasta9.Cursor = tasta_sterge.Cursor = V1.Cursor = V01.Cursor = V2.Cursor = V02.Cursor = V3.Cursor = V03.Cursor = V4.Cursor = V04.Cursor = OK.Cursor = Enter.Cursor = format.Cursor = Cursors.Hand;


                tasta0.BorderColor = tasta1.BorderColor = tasta2.BorderColor = tasta3.BorderColor = tasta4.BorderColor = tasta5.BorderColor = tasta6.BorderColor = tasta7.BorderColor = tasta8.BorderColor = tasta9.BorderColor = tasta_sterge.BorderColor = Color.FromArgb(22, 18, 126);
                tasta0.OnHoverBorderColor = tasta1.OnHoverBorderColor = tasta2.OnHoverBorderColor = tasta3.OnHoverBorderColor = tasta4.OnHoverBorderColor = tasta5.OnHoverBorderColor = tasta5.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta8.OnHoverBorderColor = tasta9.OnHoverBorderColor = tasta_sterge.OnHoverBorderColor = Color.FromArgb(22, 18, 126);
                tasta0.OnHoverButtonColor = tasta1.OnHoverButtonColor = tasta2.OnHoverButtonColor = tasta3.OnHoverButtonColor = tasta4.OnHoverButtonColor = tasta5.OnHoverButtonColor = tasta6.OnHoverButtonColor = tasta7.OnHoverButtonColor = tasta8.OnHoverButtonColor = tasta9.OnHoverButtonColor = tasta_sterge.OnHoverButtonColor = Color.FromArgb(22, 18, 126);
                tasta0.OnHoverTextColor = tasta1.OnHoverTextColor = tasta2.OnHoverTextColor = tasta3.OnHoverTextColor = tasta4.OnHoverTextColor = tasta5.OnHoverTextColor = tasta6.OnHoverTextColor = tasta7.OnHoverTextColor = tasta8.OnHoverTextColor = tasta9.OnHoverTextColor = tasta_sterge.OnHoverTextColor = Color.White;
                tasta_sterge.BackColor = Color.White;
            }else if (culoare_buttoane == 1) //rosu si negru
            {
                tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = Color.White;
                tasta0.FlatStyle = tasta1.FlatStyle = tasta2.FlatStyle = tasta3.FlatStyle = tasta4.FlatStyle = tasta5.FlatStyle = tasta6.FlatStyle = tasta7.FlatStyle = tasta8.FlatStyle = tasta9.FlatStyle = tasta_sterge.FlatStyle = FlatStyle.Flat;
                tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor = Color.White;
                tasta0.TextColor = tasta1.TextColor = tasta2.TextColor = tasta3.TextColor = tasta4.TextColor = tasta5.TextColor = tasta6.TextColor = tasta6.TextColor = tasta7.TextColor = tasta8.TextColor = tasta9.TextColor = tasta_sterge.TextColor = Color.Red;


                tasta0.Cursor = tasta1.Cursor = tasta2.Cursor = tasta3.Cursor = tasta4.Cursor = tasta5.Cursor = tasta6.Cursor = tasta7.Cursor = tasta8.Cursor = tasta9.Cursor = tasta_sterge.Cursor = V1.Cursor = V01.Cursor = V2.Cursor = V02.Cursor = V3.Cursor = V03.Cursor = V4.Cursor = V04.Cursor = OK.Cursor = Enter.Cursor = format.Cursor = Cursors.Hand;


                tasta0.BorderColor = tasta1.BorderColor = tasta2.BorderColor = tasta3.BorderColor = tasta4.BorderColor = tasta5.BorderColor = tasta6.BorderColor = tasta7.BorderColor = tasta8.BorderColor = tasta9.BorderColor = tasta_sterge.BorderColor = Color.Red;
                tasta0.OnHoverBorderColor = tasta1.OnHoverBorderColor = tasta2.OnHoverBorderColor = tasta3.OnHoverBorderColor = tasta4.OnHoverBorderColor = tasta5.OnHoverBorderColor =tasta6.OnHoverBorderColor= tasta7.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta8.OnHoverBorderColor = tasta9.OnHoverBorderColor = tasta_sterge.OnHoverBorderColor = Color.Red;
                tasta0.OnHoverButtonColor = tasta1.OnHoverButtonColor = tasta2.OnHoverButtonColor = tasta3.OnHoverButtonColor = tasta4.OnHoverButtonColor = tasta5.OnHoverButtonColor = tasta6.OnHoverButtonColor = tasta7.OnHoverButtonColor = tasta8.OnHoverButtonColor = tasta9.OnHoverButtonColor = tasta_sterge.OnHoverButtonColor = Color.Red;
                tasta0.OnHoverTextColor = tasta1.OnHoverTextColor = tasta2.OnHoverTextColor = tasta3.OnHoverTextColor = tasta4.OnHoverTextColor = tasta5.OnHoverTextColor = tasta6.OnHoverTextColor = tasta7.OnHoverTextColor = tasta8.OnHoverTextColor = tasta9.OnHoverTextColor = tasta_sterge.OnHoverTextColor = Color.Black;

                tasta_sterge.BackColor = Color.White;
            }else if (culoare_buttoane == 2)  //rosu si alb
            {
                tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = Color.White;
                tasta0.FlatStyle = tasta1.FlatStyle = tasta2.FlatStyle = tasta3.FlatStyle = tasta4.FlatStyle = tasta5.FlatStyle = tasta6.FlatStyle = tasta7.FlatStyle = tasta8.FlatStyle = tasta9.FlatStyle = tasta_sterge.FlatStyle = FlatStyle.Flat;
                tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor = Color.White;
                tasta0.ButtonColor = tasta1.ButtonColor = tasta2.ButtonColor = tasta3.ButtonColor = tasta4.ButtonColor = tasta5.ButtonColor = tasta6.ButtonColor = tasta7.ButtonColor = tasta8.ButtonColor = tasta9.ButtonColor = tasta_sterge.ButtonColor = Color.White;
                tasta0.TextColor = tasta1.TextColor = tasta2.TextColor = tasta3.TextColor = tasta4.TextColor = tasta5.TextColor = tasta6.TextColor = tasta6.TextColor = tasta7.TextColor = tasta8.TextColor = tasta9.TextColor = tasta_sterge.TextColor = Color.Red;

                tasta0.Cursor = tasta1.Cursor = tasta2.Cursor = tasta3.Cursor = tasta4.Cursor = tasta5.Cursor = tasta6.Cursor = tasta7.Cursor = tasta8.Cursor = tasta9.Cursor = tasta_sterge.Cursor = V1.Cursor = V01.Cursor = V2.Cursor = V02.Cursor = V3.Cursor = V03.Cursor = V4.Cursor = V04.Cursor = OK.Cursor = Enter.Cursor = format.Cursor = Cursors.Hand;


                tasta0.BorderColor = tasta1.BorderColor = tasta2.BorderColor = tasta3.BorderColor = tasta4.BorderColor = tasta5.BorderColor = tasta6.BorderColor = tasta7.BorderColor = tasta8.BorderColor = tasta9.BorderColor = tasta_sterge.BorderColor = Color.Red;
                tasta0.OnHoverBorderColor = tasta1.OnHoverBorderColor = tasta2.OnHoverBorderColor = tasta3.OnHoverBorderColor = tasta4.OnHoverBorderColor = tasta5.OnHoverBorderColor = tasta5.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta8.OnHoverBorderColor = tasta9.OnHoverBorderColor = tasta_sterge.OnHoverBorderColor = Color.Red;
                tasta0.OnHoverButtonColor = tasta1.OnHoverButtonColor = tasta2.OnHoverButtonColor = tasta3.OnHoverButtonColor = tasta4.OnHoverButtonColor = tasta5.OnHoverButtonColor = tasta6.OnHoverButtonColor = tasta7.OnHoverButtonColor = tasta8.OnHoverButtonColor = tasta9.OnHoverButtonColor = tasta_sterge.OnHoverButtonColor = Color.Red;
                tasta0.OnHoverTextColor = tasta1.OnHoverTextColor = tasta2.OnHoverTextColor = tasta3.OnHoverTextColor = tasta4.OnHoverTextColor = tasta5.OnHoverTextColor = tasta6.OnHoverTextColor = tasta7.OnHoverTextColor = tasta8.OnHoverTextColor = tasta9.OnHoverTextColor = tasta_sterge.OnHoverTextColor = Color.White;
                tasta_sterge.BackColor = Color.White;
            }else if (culoare_buttoane == 3) //galben si negru
            {
                 tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = Color.White;
                tasta0.FlatStyle = tasta1.FlatStyle = tasta2.FlatStyle = tasta3.FlatStyle = tasta4.FlatStyle = tasta5.FlatStyle = tasta6.FlatStyle = tasta7.FlatStyle = tasta8.FlatStyle = tasta9.FlatStyle = tasta_sterge.FlatStyle = FlatStyle.Flat;
                tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor = Color.White;
                tasta0.TextColor = tasta1.TextColor = tasta2.TextColor = tasta3.TextColor = tasta4.TextColor = tasta5.TextColor = tasta6.TextColor = tasta6.TextColor = tasta7.TextColor = tasta8.TextColor = tasta9.TextColor = tasta_sterge.TextColor = Color.Goldenrod;


                tasta0.Cursor = tasta1.Cursor = tasta2.Cursor = tasta3.Cursor = tasta4.Cursor = tasta5.Cursor = tasta6.Cursor = tasta7.Cursor = tasta8.Cursor = tasta9.Cursor = tasta_sterge.Cursor = V1.Cursor = V01.Cursor = V2.Cursor = V02.Cursor = V3.Cursor = V03.Cursor = V4.Cursor = V04.Cursor = OK.Cursor = Enter.Cursor = format.Cursor = Cursors.Hand;


                tasta0.BorderColor = tasta1.BorderColor = tasta2.BorderColor = tasta3.BorderColor = tasta4.BorderColor = tasta5.BorderColor = tasta6.BorderColor = tasta7.BorderColor = tasta8.BorderColor = tasta9.BorderColor = tasta_sterge.BorderColor = Color.Goldenrod;
                tasta0.OnHoverBorderColor = tasta1.OnHoverBorderColor = tasta2.OnHoverBorderColor = tasta3.OnHoverBorderColor = tasta4.OnHoverBorderColor = tasta5.OnHoverBorderColor = tasta6.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta8.OnHoverBorderColor = tasta9.OnHoverBorderColor = tasta_sterge.OnHoverBorderColor = Color.Goldenrod;
                tasta0.OnHoverButtonColor = tasta1.OnHoverButtonColor = tasta2.OnHoverButtonColor = tasta3.OnHoverButtonColor = tasta4.OnHoverButtonColor = tasta5.OnHoverButtonColor = tasta6.OnHoverButtonColor = tasta7.OnHoverButtonColor = tasta8.OnHoverButtonColor = tasta9.OnHoverButtonColor = tasta_sterge.OnHoverButtonColor = Color.Goldenrod;
                tasta0.OnHoverTextColor = tasta1.OnHoverTextColor = tasta2.OnHoverTextColor = tasta3.OnHoverTextColor = tasta4.OnHoverTextColor = tasta5.OnHoverTextColor = tasta6.OnHoverTextColor = tasta7.OnHoverTextColor = tasta8.OnHoverTextColor = tasta9.OnHoverTextColor = tasta_sterge.OnHoverTextColor = Color.Black;

                tasta_sterge.BackColor = Color.White;
            }else if (culoare_buttoane == 4)
            {
                tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = Color.White;
                tasta0.FlatStyle = tasta1.FlatStyle = tasta2.FlatStyle = tasta3.FlatStyle = tasta4.FlatStyle = tasta5.FlatStyle = tasta6.FlatStyle = tasta7.FlatStyle = tasta8.FlatStyle = tasta9.FlatStyle = tasta_sterge.FlatStyle = FlatStyle.Flat;
                tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor = Color.White;
                tasta0.ButtonColor = tasta1.ButtonColor = tasta2.ButtonColor = tasta3.ButtonColor = tasta4.ButtonColor = tasta5.ButtonColor = tasta6.ButtonColor = tasta7.ButtonColor = tasta8.ButtonColor = tasta9.ButtonColor = tasta_sterge.ButtonColor = Color.White;
                tasta0.TextColor = tasta1.TextColor = tasta2.TextColor = tasta3.TextColor = tasta4.TextColor = tasta5.TextColor = tasta6.TextColor = tasta6.TextColor = tasta7.TextColor = tasta8.TextColor = tasta9.TextColor = tasta_sterge.TextColor = Color.Goldenrod;

                tasta0.Cursor = tasta1.Cursor = tasta2.Cursor = tasta3.Cursor = tasta4.Cursor = tasta5.Cursor = tasta6.Cursor = tasta7.Cursor = tasta8.Cursor = tasta9.Cursor = tasta_sterge.Cursor = V1.Cursor = V01.Cursor = V2.Cursor = V02.Cursor = V3.Cursor = V03.Cursor = V4.Cursor = V04.Cursor = OK.Cursor = Enter.Cursor = format.Cursor = Cursors.Hand;


                tasta0.BorderColor = tasta1.BorderColor = tasta2.BorderColor = tasta3.BorderColor = tasta4.BorderColor = tasta5.BorderColor = tasta6.BorderColor = tasta7.BorderColor = tasta8.BorderColor = tasta9.BorderColor = tasta_sterge.BorderColor = Color.Goldenrod;
                tasta0.OnHoverBorderColor = tasta1.OnHoverBorderColor = tasta2.OnHoverBorderColor = tasta3.OnHoverBorderColor = tasta4.OnHoverBorderColor = tasta5.OnHoverBorderColor = tasta5.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta8.OnHoverBorderColor = tasta9.OnHoverBorderColor = tasta_sterge.OnHoverBorderColor = Color.Goldenrod;
                tasta0.OnHoverButtonColor = tasta1.OnHoverButtonColor = tasta2.OnHoverButtonColor = tasta3.OnHoverButtonColor = tasta4.OnHoverButtonColor = tasta5.OnHoverButtonColor = tasta6.OnHoverButtonColor = tasta7.OnHoverButtonColor = tasta8.OnHoverButtonColor = tasta9.OnHoverButtonColor = tasta_sterge.OnHoverButtonColor = Color.Goldenrod;
                tasta0.OnHoverTextColor = tasta1.OnHoverTextColor = tasta2.OnHoverTextColor = tasta3.OnHoverTextColor = tasta4.OnHoverTextColor = tasta5.OnHoverTextColor = tasta6.OnHoverTextColor = tasta7.OnHoverTextColor = tasta8.OnHoverTextColor = tasta9.OnHoverTextColor = tasta_sterge.OnHoverTextColor = Color.White;
                tasta_sterge.BackColor = Color.White;
            }
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
        private void Q1_Click(object sender, EventArgs e)
        {
            
            meme = 1;
            afis_meme();
            panel1.Visible = stanga_output.Visible = false;TAB.Visible = true;
            TEST.Visible = true;

            question = 1;
            multiple_choice();
            qlabel.Text = "Care a fost tara in care au inceput luptele pasoptiste?";

            imagine_test.Image = Properties.Resources.intrebare_nr_2;

            V01.Text = V1.Text = "Italia";  //c
            V02.Text = V2.Text = "Romania";
            V03.Text = V3.Text = "Franta";
            V04.Text = V4.Text = "Austro-Ungaria";
            descriere.Text = "In Italia a izbucnt in ianuarie 1848,in Franta – in februarie 1848,iar in statele germane cat si in imperiul Austro-Ungar in martie.";


            aces_generale = aces_t1 = aces_t2 = aces_t3 = aces_t4 =aces_t5= false;
            aces_t1 = true;
            an.ReadOnly = true;
            corecte_genarale = corecte_t1 = corecte_t2 = corecte_t3 = corecte_t4 = corecte_t5 = 0;

            timp.Visible = imagine_ceas.Visible = true;
    
            if (aspect_cronometru == 1) timp.Text = "25s";
            else if (aspect_cronometru == 0) timp.Text = "25 : 00";

            timp.Value = 100; timp.ProgressColor = timp.ForeColor = Color.FromArgb(30, 208, 34);


            if (TEST.BackColor != Color.White || qlabel.ForeColor != Color.FromArgb(22, 18, 126) || descriere.ForeColor != Color.FromArgb(22, 18, 126) || tasta_sterge.ButtonColor != Color.White || tasta_sterge.TextColor != Color.FromArgb(22, 18, 126) || tasta_sterge.BorderColor != Color.FromArgb(22, 18, 126) || tasta_sterge.OnHoverBorderColor != Color.FromArgb(22, 18, 126) || tasta_sterge.OnHoverButtonColor != Color.FromArgb(22, 18, 126) || tasta_sterge.OnHoverTextColor != Color.White) { format.Text = "Resetează aspectul"; format.Visible = true; }
            else if (TEST.BackColor == Color.White && qlabel.ForeColor == Color.FromArgb(22, 18, 126) && descriere.ForeColor == Color.FromArgb(22, 18, 126) && tasta_sterge.ButtonColor == Color.White && tasta_sterge.TextColor == Color.FromArgb(22, 18, 126) && tasta_sterge.BorderColor == Color.FromArgb(22, 18, 126) && tasta_sterge.OnHoverBorderColor == Color.FromArgb(22, 18, 126) && tasta_sterge.OnHoverButtonColor == Color.FromArgb(22, 18, 126) && tasta_sterge.OnHoverTextColor == Color.White) { format.Text = "Schimă aspectul"; format.Visible = false; }

            
            quick = 1500;
        }


        private void Q2_Click(object sender, EventArgs e)
        {



            if (TEST.BackColor != Color.White || qlabel.ForeColor != Color.FromArgb(22, 18, 126) || descriere.ForeColor != Color.FromArgb(22, 18, 126) || tasta_sterge.ButtonColor != Color.White || tasta_sterge.TextColor != Color.FromArgb(22, 18, 126) || tasta_sterge.BorderColor != Color.FromArgb(22, 18, 126) || tasta_sterge.OnHoverBorderColor != Color.FromArgb(22, 18, 126) || tasta_sterge.OnHoverButtonColor != Color.FromArgb(22, 18, 126) || tasta_sterge.OnHoverTextColor != Color.White) { format.Text = "Resetează aspectul"; format.Visible = true; }
            else if (TEST.BackColor == Color.White && qlabel.ForeColor == Color.FromArgb(22, 18, 126) && descriere.ForeColor == Color.FromArgb(22, 18, 126) && tasta_sterge.ButtonColor == Color.White && tasta_sterge.TextColor == Color.FromArgb(22, 18, 126) && tasta_sterge.BorderColor == Color.FromArgb(22, 18, 126) && tasta_sterge.OnHoverBorderColor == Color.FromArgb(22, 18, 126) && tasta_sterge.OnHoverButtonColor == Color.FromArgb(22, 18, 126) && tasta_sterge.OnHoverTextColor == Color.White) { format.Text = "Schimă aspectul"; format.Visible = false; }

            meme = 1;
            afis_meme();
            panel1.Visible = stanga_output.Visible = false; TAB.Visible = true;
            TEST.Visible = true;
            question = 13;
            
            multiple_choice();
            imagine_test.Image = Properties.Resources.intrebare_nr_32;
            qlabel.Text = "Caii au reprezentat principalul mijloc de deplasare in Primul Razboi Mondial. Acestia luau parte la batalii,iar cei care mureau erau folositi pe post de hrana.Cati cai au murit in Marele Razboi?";
            V01.Text = V1.Text = "40 de milione";
            V02.Text = V2.Text = "1,3 milioane";
            V03.Text = V3.Text = "8 milioane"; //c
            V04.Text = V4.Text = "10 de milioane";
            descriere.Text = "";
            //https://www.historia.ro/sectiune/general/articol/top-5-animale-ale-razboiului-de-la-cai-la-licurici
            aces_generale = aces_t1 = aces_t2 = aces_t3 = aces_t4 =aces_t5= false;
            aces_t2 = true;

            timp.Visible = imagine_ceas.Visible = true;


            corecte_genarale = corecte_t1 = corecte_t2 = corecte_t3 = corecte_t4 =corecte_t5= 0;

         
            if (aspect_cronometru == 1) timp.Text = "25s";
            else if (aspect_cronometru == 0) timp.Text = "25 : 00";


           
            timp.Value = 100; timp.ProgressColor = timp.ForeColor = Color.FromArgb(30, 208, 34);

            quick = 1500;
        }



        private void Q3_Click(object sender, EventArgs e)
        {
            if (TEST.BackColor != Color.White || qlabel.ForeColor != Color.FromArgb(22, 18, 126) || descriere.ForeColor != Color.FromArgb(22, 18, 126) || tasta_sterge.ButtonColor != Color.White || tasta_sterge.TextColor != Color.FromArgb(22, 18, 126) || tasta_sterge.BorderColor != Color.FromArgb(22, 18, 126) || tasta_sterge.OnHoverBorderColor != Color.FromArgb(22, 18, 126) || tasta_sterge.OnHoverButtonColor != Color.FromArgb(22, 18, 126) || tasta_sterge.OnHoverTextColor != Color.White) { format.Text = "Resetează aspectul"; format.Visible = true; }
            else if (TEST.BackColor == Color.White && qlabel.ForeColor == Color.FromArgb(22, 18, 126) && descriere.ForeColor == Color.FromArgb(22, 18, 126) && tasta_sterge.ButtonColor == Color.White && tasta_sterge.TextColor == Color.FromArgb(22, 18, 126) && tasta_sterge.BorderColor == Color.FromArgb(22, 18, 126) && tasta_sterge.OnHoverBorderColor == Color.FromArgb(22, 18, 126) && tasta_sterge.OnHoverButtonColor == Color.FromArgb(22, 18, 126) && tasta_sterge.OnHoverTextColor == Color.White) { format.Text = "Schimă aspectul"; format.Visible = false; }

            meme = 1;
            afis_meme();
            panel1.Visible = stanga_output.Visible = false; TAB.Visible = true;
            TEST.Visible = true;



            question = 22;
            corecte_t3 = 0;

            multiple_choice();
            imagine_test.Image = Properties.Resources.intrebare_nr_48;
            qlabel.Text = "Care Rege al Romaniei i-a daruit Mitei biciclista casa care ii poarta numele?";
            V01.Text = V1.Text = "Carol I";
            V02.Text = V2.Text = "Carol al II-lea";
            V03.Text = V3.Text = "Ferdinand I";  //c
            V04.Text = V4.Text = "Mihai I";
            descriere.Text = "";
            aces_generale = aces_t1 = aces_t2 = aces_t3 = aces_t4 =aces_t5= false;
            aces_t3 = true;
            corecte_genarale = corecte_t1 = corecte_t2 = corecte_t3 = corecte_t4 = corecte_t5 = 0;

            timp.Visible = imagine_ceas.Visible = true;
         
            if (aspect_cronometru == 1) timp.Text = "25s";
            else if (aspect_cronometru == 0) timp.Text = "25 : 00";

            timp.Value = 100; timp.ProgressColor = timp.ForeColor = Color.FromArgb(30, 208, 34);
            quick = 1500;

        }




        private void Q4_Click(object sender, EventArgs e)
        {
            if (TEST.BackColor != Color.White || qlabel.ForeColor != Color.FromArgb(22, 18, 126) || descriere.ForeColor != Color.FromArgb(22, 18, 126) || tasta_sterge.ButtonColor != Color.White || tasta_sterge.TextColor != Color.FromArgb(22, 18, 126) || tasta_sterge.BorderColor != Color.FromArgb(22, 18, 126) || tasta_sterge.OnHoverBorderColor != Color.FromArgb(22, 18, 126) || tasta_sterge.OnHoverButtonColor != Color.FromArgb(22, 18, 126) || tasta_sterge.OnHoverTextColor != Color.White) { format.Text = "Resetează aspectul"; format.Visible = true; }
            else if (TEST.BackColor == Color.White && qlabel.ForeColor == Color.FromArgb(22, 18, 126) && descriere.ForeColor == Color.FromArgb(22, 18, 126) && tasta_sterge.ButtonColor == Color.White && tasta_sterge.TextColor == Color.FromArgb(22, 18, 126) && tasta_sterge.BorderColor == Color.FromArgb(22, 18, 126) && tasta_sterge.OnHoverBorderColor == Color.FromArgb(22, 18, 126) && tasta_sterge.OnHoverButtonColor == Color.FromArgb(22, 18, 126) && tasta_sterge.OnHoverTextColor == Color.White) { format.Text = "Schimă aspectul"; format.Visible = false; }

            meme = 1;
            afis_meme();

            panel1.Visible = stanga_output.Visible = false; TAB.Visible = true;
            TEST.Visible = true;


            question = 30;

            multiple_choice();
            imagine_test.Image = Properties.Resources.intrebare_nr_68;
            qlabel.Text = "In timpul Celui De Al Doilea Razboi Mondial,la conducerea SUA s-a aflat";
            V01.Text = V1.Text = "Harbert Hoover";
            V02.Text = V2.Text = "Robert D. Rooselvelt"; //c
            V03.Text = V3.Text = "Harry Truman";
            V04.Text = V4.Text = "Dwight Eisnehower";
            descriere.Text = "";
            aces_generale = aces_t1 = aces_t2 = aces_t3 = aces_t4=aces_t5 =false;
            aces_t4 = true;
           
            corecte_genarale = corecte_t1 = corecte_t2 = corecte_t3 = corecte_t4 = corecte_t5 = 0;


            timp.Visible = imagine_ceas.Visible = true;

            if (aspect_cronometru == 1) timp.Text = "25s";
            else if (aspect_cronometru == 0) timp.Text = "25 : 00";

            timp.Value = 100; timp.ProgressColor = timp.ForeColor = Color.FromArgb(30, 208, 34);

            quick = 1500;

        }
        private void Q5_Click(object sender, EventArgs e)
        {
            if (TEST.BackColor != Color.White || qlabel.ForeColor != Color.FromArgb(22, 18, 126) || descriere.ForeColor != Color.FromArgb(22, 18, 126) || tasta_sterge.ButtonColor != Color.White || tasta_sterge.TextColor != Color.FromArgb(22, 18, 126) || tasta_sterge.BorderColor != Color.FromArgb(22, 18, 126) || tasta_sterge.OnHoverBorderColor != Color.FromArgb(22, 18, 126) || tasta_sterge.OnHoverButtonColor != Color.FromArgb(22, 18, 126) || tasta_sterge.OnHoverTextColor != Color.White) { format.Text = "Resetează aspectul"; format.Visible = false; }
            else if (TEST.BackColor == Color.White || qlabel.ForeColor == Color.FromArgb(22, 18, 126) || descriere.ForeColor == Color.FromArgb(22, 18, 126) || tasta_sterge.ButtonColor == Color.White || tasta_sterge.TextColor == Color.FromArgb(22, 18, 126) || tasta_sterge.BorderColor == Color.FromArgb(22, 18, 126) || tasta_sterge.OnHoverBorderColor == Color.FromArgb(22, 18, 126) || tasta_sterge.OnHoverButtonColor == Color.FromArgb(22, 18, 126) || tasta_sterge.OnHoverTextColor == Color.White) { format.Text = "Resetează aspectul"; format.Visible = true; }

            meme = 1;
            afis_meme();
            panel1.Visible = stanga_output.Visible = false; TAB.Visible = true;
            TEST.Visible = true;


            question = 52;
            intrebare_an();
            imagine_test.Image = Properties.Resources.intrebare_nr_117;
            qlabel.Text = "In ce an a fost proclamata Republica Populara Romania ?"; //1947
            descriere.Text = "";
            aces_generale = aces_t1 = aces_t2 = aces_t3 = aces_t4 =aces_t5= false;
            aces_t5 = true;
            corecte_genarale = corecte_t1 = corecte_t2 = corecte_t3 = corecte_t4 = corecte_t5 = 0;
            timp.Visible = imagine_ceas.Visible = true;

            if (aspect_cronometru == 1) timp.Text = "25s";
            else if (aspect_cronometru == 0) timp.Text = "25 : 00";

            timp.Value = 100; timp.ProgressColor = timp.ForeColor = Color.FromArgb(30, 208, 34);

            quick = 1500;
        }

        private void Q6_Click(object sender, EventArgs e)
        {
            if (TEST.BackColor != Color.White || qlabel.ForeColor != Color.FromArgb(22, 18, 126) || descriere.ForeColor != Color.FromArgb(22, 18, 126) || tasta_sterge.ButtonColor != Color.White || tasta_sterge.TextColor != Color.FromArgb(22, 18, 126) || tasta_sterge.BorderColor != Color.FromArgb(22, 18, 126) || tasta_sterge.OnHoverBorderColor != Color.FromArgb(22, 18, 126) || tasta_sterge.OnHoverButtonColor != Color.FromArgb(22, 18, 126) || tasta_sterge.OnHoverTextColor != Color.White) { format.Text = "Resetează aspectul"; format.Visible = true; }
            else if (TEST.BackColor == Color.White && qlabel.ForeColor == Color.FromArgb(22, 18, 126) && descriere.ForeColor == Color.FromArgb(22, 18, 126) && tasta_sterge.ButtonColor == Color.White && tasta_sterge.TextColor == Color.FromArgb(22, 18, 126) && tasta_sterge.BorderColor == Color.FromArgb(22, 18, 126) && tasta_sterge.OnHoverBorderColor == Color.FromArgb(22, 18, 126) && tasta_sterge.OnHoverButtonColor == Color.FromArgb(22, 18, 126) && tasta_sterge.OnHoverTextColor == Color.White) { format.Text = "Schimă aspectul"; format.Visible = false; }


            meme = 1;
            afis_meme();
            panel1.Visible = stanga_output.Visible = false; TAB.Visible = true;
            TEST.Visible = true;

            question = 1;
            multiple_choice();
            qlabel.Text = "Care a fost tara in care au inceput luptele pasoptiste?";

            imagine_test.Image = Properties.Resources.intrebare_nr_2;

            V01.Text = V1.Text = "Italia";  //c
            V02.Text = V2.Text = "Romania";
            V03.Text = V3.Text = "Franta";
            V04.Text = V4.Text = "Austro-Ungaria";
            descriere.Text = "In Italia a izbucnt in ianuarie 1848,in Franta – in februarie 1848,iar in statele germane cat si in imperiul Austro-Ungar in martie.";

            corecte_genarale = corecte_t1 = corecte_t2 = corecte_t3 = corecte_t4 = corecte_t5 = 0;

            aces_generale = aces_t1 = aces_t2 = aces_t3 = aces_t4=aces_t5 = false;
            aces_generale = true;
            an.ReadOnly = true;
            timp.Visible = imagine_ceas.Visible = true;

       
            if (aspect_cronometru == 1) timp.Text = "25s";
            else if (aspect_cronometru == 0) timp.Text = "25 : 00";

            timp.Value = 100; timp.ProgressColor = timp.ForeColor = Color.FromArgb(30, 208, 34);
            quick = 1500;

        }


        private void OnMouseEnterQ1(object sender, EventArgs e)
        {

            Q1.BackColor = Color.FromArgb(0, x2, y2, z2);
            Q1.ForeColor = Color.FromArgb(x1, y1, z1);
            
        }
        private void OnMouseLeaveQ1(object sender, EventArgs e)
        {
            Q1.BackColor = Color.FromArgb(0, x1, y1, z1);
            Q1.ForeColor = Color.FromArgb(x2, y2, z2);
        }

        private void OnMouseEnterE2(object sender, EventArgs e)
        {

            E2.BackColor = Color.FromArgb(x1,y1,z1);
            E2.ForeColor = Color.Goldenrod;
        }
        private void OnMouseLeaveE2(object sender, EventArgs e)
        {
            E2.BackColor =E2.ForeColor= Color.FromArgb(0, x2, y2, z2);
        }

        private void OnMouseEnterBiog2(object sender, EventArgs e)
        {

            Biog2.BackColor = Color.FromArgb(x1, y1, z1);
            Biog2.ForeColor = Color.Goldenrod;
        }
        private void OnMouseLeaveBiog2(object sender, EventArgs e)
        {
            Biog2.BackColor = Biog2.ForeColor = Color.FromArgb(0, x2, y2, z2);
        }

        private void OnMouseEnterS2(object sender, EventArgs e)
        {

            S2.BackColor = Color.FromArgb(x1, y1, z1);
            S2.ForeColor = Color.Goldenrod;
        }
        private void OnMouseLeaveS2(object sender, EventArgs e)
        {
            S2.BackColor = S2.ForeColor = Color.FromArgb(0, x2, y2, z2);
        }


        private void OnMouseEnterSC2(object sender, EventArgs e)
        {

            SC2.BackColor = Color.FromArgb(x1, y1, z1);
            SC2.ForeColor = Color.Goldenrod;
        }
        private void OnMouseLeaveSC2(object sender, EventArgs e)
        {
            SC2.BackColor = SC2.ForeColor = Color.FromArgb(0, x2, y2, z2);
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





        private void TAB_Click(object sender, EventArgs e)
        {
            meme = 1;
            afis_meme();
            stanga_output.Visible = true;
            TAB.Visible = false;
        }
        private void ARROW_Click(object sender, EventArgs e)
        {
            meme = 1;
            afis_meme();
            stanga_output.Visible = false;
            TAB.Visible = true;
        }
        private void V01_Click(object sender, EventArgs e)
        {
            if (acces_variante == true)
            {
                acces_variante = false;
                OK.Visible = true;

                descriere.Visible = true;
                merge_cronometrul = false;
                v = 1;
               
                corect();
                
            }
        }



        private void V1_Click(object sender, EventArgs e)
        {
            if (acces_variante == true)
            {
                acces_variante = false;
                OK.Visible = true;
                merge_cronometrul = false;
                descriere.Visible = true;
                v = 1;
                corect();
    
            }
        }




        private void V2_Click(object sender, EventArgs e)
        {
            if (acces_variante == true)
            {

                acces_variante = false;
                OK.Visible = true;

                descriere.Visible = true;
                merge_cronometrul = false;
                v = 2;
                corect();
            }
        }



        private void V02_Click(object sender, EventArgs e)
        {
            if (acces_variante == true)
            {

                acces_variante = false;
                OK.Visible = true;
                merge_cronometrul = false;
                descriere.Visible = true;
                v = 2;
                corect();

            }
        }


        private void V3_Click(object sender, EventArgs e)
        {
            if (acces_variante == true)
            {
                acces_variante = false;
                OK.Visible = true;
                merge_cronometrul = false;
                descriere.Visible = true;
                v = 3;
                corect();





            }
        }



        private void V03_Click(object sender, EventArgs e)
        {
            if (acces_variante == true)
            {
                acces_variante = false;
                OK.Visible = true;
                merge_cronometrul = false;
                descriere.Visible = true;
                v = 3;
                corect();
         





            }
        }




        private void V04_Click(object sender, EventArgs e)
        {
            if (acces_variante == true)
            {
                acces_variante = false;
                OK.Visible = true;
                merge_cronometrul = false;
                descriere.Visible = true;


                v = 4;
                corect();
            }
        }

        private void V4_Click(object sender, EventArgs e)
        {
            if (acces_variante == true)
            {
                acces_variante = false;
                OK.Visible = true;
                merge_cronometrul = false;
                descriere.Visible = true;

                v = 4;
                corect();
            }
        }





        //tot:1-62
        //ww1:13-22
        //interbelica:23-29
        //ww2:30-51
        //cold war:52-62




        void corect()
        {
            bool ok = false;
            format.Visible = true;format.Text = "Schimbă aspectul";
            if (question == 1 || question == 2 || question == 14 || question == 32)
            {
                sir = V1.Text;
                if (v == 1)
                {
                    V01.BackColor = V1.BackColor = Color.Green;
                    ok = true;

                 

                }else if (v == 2)
                {
                    V02.BackColor = V2.BackColor = Color.Red;
                    V01.BackColor = V1.BackColor = Color.Lime;
                }else if (v == 3)
                {
                    V03.BackColor = V3.BackColor = Color.Red;
                    V01.BackColor = V1.BackColor = Color.Lime;
                }
                else if (v == 4)
                {
                    V04.BackColor = V4.BackColor = Color.Red;
                    V01.BackColor = V1.BackColor = Color.Lime;
                }
            }else if(question==9 || question == 11 || question == 26 || question == 30 || question == 33 || question == 34 || question == 44 || question == 50 || question == 54)
            {
                sir = V2.Text;
                if (v == 1)
                {
                    V02.BackColor = V2.BackColor = Color.Lime;
                    V01.BackColor = V1.BackColor = Color.Red;
                }
                else if (v == 2)
                {
                    V02.BackColor = V2.BackColor = Color.Green;
                    ok = true;

                }
                else if (v == 3)
                {
                    V03.BackColor = V3.BackColor = Color.Red;
                    V02.BackColor = V2.BackColor = Color.Lime;
                }
                else if (v == 4)
                {
                    V04.BackColor = V4.BackColor = Color.Red;
                    V02.BackColor = V2.BackColor = Color.Lime;
                }
            }else if (question == 12 || question == 13 || question == 15 || question == 21 || question == 22 || question == 28 || question == 31)
            {
                sir = V3.Text;
                if (v == 1)
                {
                    V03.BackColor = V3.BackColor = Color.Lime;
                    V01.BackColor = V1.BackColor = Color.Red;
                }
                else if (v == 2)
                {
                    V03.BackColor = V3.BackColor = Color.Lime;
                    V02.BackColor = V2.BackColor = Color.Red;
                }
                else if (v == 3)
                {
                    V03.BackColor = V3.BackColor = Color.Green;
                    ok = true;
             
                }
                else if (v == 4)
                {
                    V03.BackColor = V3.BackColor = Color.Lime;
                    V04.BackColor = V4.BackColor = Color.Red;
                }
            }else if (question == 4 || question == 8 || question == 35 || question == 42 || question == 49)
            { sir = V4.Text ;
                if (v == 1)
                {
                    V04.BackColor = V4.BackColor = Color.Lime;
                    V01.BackColor = V1.BackColor = Color.Red;
                }
                else if (v == 2)
                {
                    V04.BackColor = V4.BackColor = Color.Lime;
                    V02.BackColor = V2.BackColor = Color.Red;
                }
                else if (v == 3)
                {
                    V04.BackColor = V4.BackColor = Color.Lime;
                    V03.BackColor = V3.BackColor = Color.Red;
                }
                else if (v == 4)
                {
                    V04.BackColor = V4.BackColor = Color.Green;
                    ok = true;
                    sir = V4.Text;
                }
            }

            if (ok == true)
            {
                it_c++; it_g = 0;
                if (it_c == 1) motivator = "Bravo!";
                else if (it_c == 2) motivator = "Bună treabă!";
                else if (it_c == 3) motivator = "Te descurci minunat!";
                else if (it_c == 4) motivator = "Continua tot asa!";
                else if (it_c == 5) motivator = "Excelent!!!";
                else if (it_c == 6) motivator = "Bravooss!!";
                else it_c = 0;
                this.Alert("Success ", Form_Alert.enmType.Success);




                corecte_genarale++;

                if (question >= 1 && question <= 12) corecte_t1++;
                if (question >= 13 && question <= 21) corecte_t2++;
                if (question >= 22 && question <= 29) corecte_t3++;
                if (question >= 30 && question <= 51) corecte_t4++;
                if (question >= 52 && question <= 62) corecte_t5++;

            }
            else
            {
                it_c = 0;it_g++;

                if (it_g == 1) motivator = "Nu  te lăsa descurajat!";
                else if (it_g == 2) motivator = "Nu fii dezamagit!";
                else if (it_g == 3) motivator = "Mai incearca!";
                else if (it_g == 4) motivator = "Poate ai succes la următoarea...";
                else it_g = 0;
                this.Alert("Error", Form_Alert.enmType.Error);
            }

        }



    
        private void OK_Click(object sender, EventArgs e)
        {
            bool next = false;
            

            if (panel2.Visible == true)
            {
                frecv_ok = 1 - frecv_ok;
                if (frecv_ok == 1)
                {
                    frecv_ok = 1;
                    MessageBox.Show("Daca treceti la urmatoarea intrebare, tot progresul nesalvat in cadrul fesrestei de customizare va disparea!");
                    next = false;
                }
                else if (frecv_ok == 0)
                {
                    

                    frecv_ok = frecv = 0;
                    panel2.Visible = false;
                    next = true;

                    first_back = first_descriere = first_intrebare = true;

                    cul_back.BackColor = aux_back.BackColor;
                    cul_intrebare.BackColor = aux_intrebare.BackColor;
                    cul_descriere.BackColor = aux_descriere.BackColor;

                    mostra_rot.BorderColor = aux_rot.BorderColor;
                    mostra_rot.OnHoverBorderColor = aux_rot.OnHoverBorderColor;
                    mostra_rot.ButtonColor = aux_rot.ButtonColor;
                    mostra_rot.OnHoverButtonColor = aux_rot.OnHoverButtonColor;
                    mostra_rot.TextColor = aux_rot.TextColor;
                    mostra_rot.OnHoverTextColor = aux_rot.OnHoverTextColor;

                    bordercolorbotton.BackColor = mostra_rot.BorderColor;
                    hbordercolorbotton.BackColor = mostra_rot.OnHoverBorderColor;

                    buttoncolorbutton.BackColor = mostra_rot.ButtonColor;
                    hbuttoncolorbutton.BackColor = mostra_rot.OnHoverButtonColor;

                    textcolorbutton.BackColor = mostra_rot.TextColor;
                    htextcolorbutton.BackColor = mostra_rot.OnHoverTextColor;

                    tasta0.FlatStyle = FlatStyle.Flat;


                    inserare1.BackColor = inserare2.BackColor = inserare_raspuns.BackColor = TEST.BackColor = inserare1.BackColor = inserare2.BackColor = inserare_raspuns.BackColor = imagine_ceas.BackColor = descriere.BackColor = timp.BackColor = qlabel.BackColor = cul_back.BackColor;


                    tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor = cul_back.BackColor;
                    tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = cul_back.BackColor;

                    tasta0.ButtonColor = tasta1.ButtonColor = tasta2.ButtonColor = tasta3.ButtonColor = tasta4.ButtonColor = tasta5.ButtonColor = tasta6.ButtonColor = tasta7.ButtonColor = tasta8.ButtonColor = tasta9.ButtonColor = tasta_sterge.ButtonColor = mostra_rot.ButtonColor;

                    tasta0.BorderColor = tasta1.BorderColor = tasta2.BorderColor = tasta3.BorderColor = tasta4.BorderColor = tasta5.BorderColor = tasta6.BorderColor = tasta7.BorderColor = tasta8.BorderColor = tasta9.BorderColor = tasta_sterge.BorderColor = mostra_rot.BorderColor;
                    tasta0.OnHoverBorderColor = tasta1.OnHoverBorderColor = tasta2.OnHoverBorderColor = tasta3.OnHoverBorderColor = tasta4.OnHoverBorderColor = tasta5.OnHoverBorderColor = tasta6.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta8.OnHoverBorderColor = tasta9.OnHoverBorderColor = tasta_sterge.OnHoverBorderColor = mostra_rot.OnHoverBorderColor;
                    tasta0.OnHoverButtonColor = tasta1.OnHoverButtonColor = tasta2.OnHoverButtonColor = tasta3.OnHoverButtonColor = tasta4.OnHoverButtonColor = tasta5.OnHoverButtonColor = tasta6.OnHoverButtonColor = tasta7.OnHoverButtonColor = tasta8.OnHoverButtonColor = tasta9.OnHoverButtonColor = tasta_sterge.OnHoverButtonColor = mostra_rot.OnHoverButtonColor;
                    tasta0.TextColor = tasta1.TextColor = tasta2.TextColor = tasta3.TextColor = tasta4.TextColor = tasta5.TextColor = tasta6.TextColor = tasta6.TextColor = tasta7.TextColor = tasta8.TextColor = tasta9.TextColor = tasta_sterge.TextColor = mostra_rot.TextColor;

                    tasta0.OnHoverTextColor = tasta1.OnHoverTextColor = tasta2.OnHoverTextColor = tasta3.OnHoverTextColor = tasta4.OnHoverTextColor = tasta5.OnHoverTextColor = tasta6.OnHoverTextColor = tasta7.OnHoverTextColor = tasta8.OnHoverTextColor = tasta9.OnHoverTextColor = tasta_sterge.OnHoverTextColor = mostra_rot.OnHoverTextColor;


                    if (pozitie == 1) mostra.BackColor = cul_back.BackColor;
                    else if (pozitie == 2) mostra.BackColor = intrebare.BackColor;
                    else if (pozitie == 3) mostra.BackColor = description.BackColor;


                    aspect_cronometru = aux_cronometru;

                    if (aspect_cronometru == 0) timp.Text = (quick / 60) + ":" + ((quick % 60) >= 10 ? (quick % 60).ToString() : "0" + (quick % 60));
                    else if (aspect_cronometru == 1) timp.Text = Convert.ToString(quick / 60) + "s";



                    aspect_variante = aux_variante;

                    if (which_one == 1)
                    {
                        if (V01.Visible == true || V1.Visible == true)
                        {
                            if (aspect_variante == 1)
                            {

                                V1.Visible = V2.Visible = V3.Visible = V4.Visible = true;
                                V01.Visible = V02.Visible = V03.Visible = V04.Visible = false;


                                radioButton1.Checked = true; radioButton2.Checked = false;
                            }
                            else if (aspect_variante == 0)
                            {

                                if (V1.Visible == true || V01.Visible == true)
                                {
                                    V1.Visible = V2.Visible = V3.Visible = V4.Visible = false;
                                    V01.Visible = V02.Visible = V03.Visible = V04.Visible = true;
                                }

                                radioButton1.Checked = false; radioButton2.Checked = true;
                            }
                        }
                      

                    }
                    else if (which_one == 2)
                    {
                        if (aspect_cronometru == 1) { radioButton1.Checked = true; radioButton2.Checked = false; }
                        else if (aspect_cronometru == 0) { radioButton1.Checked = false; radioButton2.Checked = true; }
                    }
                }
            }
            else next = true;

            if (next == true)
            {
                

                
                if (TEST.BackColor != Color.White || qlabel.ForeColor != Color.FromArgb(22, 18, 126) || descriere.ForeColor != Color.FromArgb(22, 18, 126) || tasta_sterge.ButtonColor != Color.White || tasta_sterge.TextColor != Color.FromArgb(22, 18, 126) || tasta_sterge.BorderColor != Color.FromArgb(22, 18, 126) || tasta_sterge.OnHoverBorderColor != Color.FromArgb(22, 18, 126) || tasta_sterge.OnHoverButtonColor != Color.FromArgb(22, 18, 126) || tasta_sterge.OnHoverTextColor != Color.White) { format.Text = "Resetează aspectul"; format.Visible = true; }
                else if (TEST.BackColor == Color.White && qlabel.ForeColor == Color.FromArgb(22, 18, 126) && descriere.ForeColor == Color.FromArgb(22, 18, 126) && tasta_sterge.ButtonColor == Color.White && tasta_sterge.TextColor == Color.FromArgb(22, 18, 126) && tasta_sterge.BorderColor == Color.FromArgb(22, 18, 126) && tasta_sterge.OnHoverBorderColor == Color.FromArgb(22, 18, 126) && tasta_sterge.OnHoverButtonColor == Color.FromArgb(22, 18, 126) && tasta_sterge.OnHoverTextColor == Color.White) { format.Text = "Schimă aspectul"; format.Visible = false; }
                

                OK.Visible = false;

                question++;

                panel2.Visible = false;

                descriere.Visible = false;


                underline1.Visible = underline2.Visible = underline_inserare_rasp.Visible = false;
                if (question == 1)
                {

                    multiple_choice();
                    qlabel.Text = "Care a fost tara in care au inceput luptele pasoptiste?";

                    imagine_test.Image = Properties.Resources.intrebare_nr_2;

                    V01.Text = V1.Text = "Italia";  //c
                    V02.Text = V2.Text = "Romania";
                    V03.Text = V3.Text = "Franta";
                    V04.Text = V4.Text = "Austro-Ungaria";
                    descriere.Text = "In Italia a izbucnt in ianuarie 1848,in Franta – in februarie 1848,iar in statele germane cat si in imperiul Austro-Ungar in martie.";



                }
                else if (question == 2)
                {
                    multiple_choice();
                    qlabel.Text = "Parlamentul de la Frankfurt care a activat pana in martie 1849,a avut ca scop:";
                    V01.Text = V1.Text = "unificarea Germaniei"; //c
                    V02.Text = V2.Text = "asigurarea pacii";
                    V3.Text = V3.Text = "protejarea burgheziei";
                    V04.Text = V4.Text = "alt scop";

                    imagine_test.Image = Properties.Resources.intrebare_nr_4;
                    descriere.Text = "";


                }
                else if (question == 3)
                {
                    intrebare_an();
                    qlabel.Text = "In ce an a avut loc republica de la Ploiesti?"; //1870
                    imagine_test.Image = Properties.Resources.intrebare_nr_7;
                    descriere.Text = "Republica de la Ploiești este denumirea unei mișcări din data de 8 august 1870, considerată ca fiind ultima mare încercare de revoluție din spațiul românesc al secolului al XIX-lea sau ultimul val al revoluției de la 1848.";
                    descriere.Text = "";



                }
                else if (question == 4)
                {
                    multiple_choice();

                    qlabel.Text = "In ce localitate au fost puse primele sonde de petrol din lume?";
                    imagine_test.Image = Properties.Resources.intrebare_nr_10;

                    V01.Text = V1.Text = "Bucuresti";
                    V02.Text = V2.Text = "Constanta";
                    V03.Text = V3.Text = "Ploiesti";
                    V04.Text = V4.Text = "Lucacesti";//c
                    descriere.Text = "";




                }
                else if (question == 5)
                {
                    intrebare_an();

                    qlabel.Text = "In ce an a fost construita prima rafinarie de petrol din Romania?";//1857
                    imagine_test.Image = Properties.Resources.intrebare_nr_11_1;
                    descriere.Text = "";


                }
                else if (question == 6)
                {
                    intrebare_an();
                    qlabel.Text = "Cati regi a avut Romania de-a lungul isotriei?"; //4
                    imagine_test.Image = Properties.Resources.intrebare_nr_13_1;
                    descriere.Text = "";



                }
                else if (question == 7)
                {
                    dual();
                    qlabel.Text = "Intre ce ani a avut loc Razboiul Civil American?";//1861-1865
                    imagine_test.Image = Properties.Resources.intrebare_nr_14;
                    descriere.Text = "";


                }
                else if (question == 8)
                {
                    multiple_choice();
                    qlabel.Text = "In ce an a fost achizitionata Alaska de catre SUA pentru 10 milioane de dolari?";
                    imagine_test.Image = Properties.Resources.intrebare_nr_15;
                    V01.Text = V1.Text = "1865";
                    V02.Text = V2.Text = "1866";
                    V03.Text = V3.Text = "1867";
                    V04.Text = V4.Text = "niciun raspuns nu este corect"; //c
                    descriere.Text = "Alaska nu a fost cumparata cu 10 milioane de dolari,ci cu 7.2 ,iar achizitia teritoriului s-a realizat in 1867";


                }
                else if (question == 9)
                {
                    multiple_choice();
                    qlabel.Text = "Cine a scris primul tratat de bacteorologie din lume?";
                    imagine_test.Image = Properties.Resources.intrebare_nr_17;
                    V01.Text = V1.Text = "Luis Pasteur";
                    V02.Text = V2.Text = "Victor Babes";  //c
                    V03.Text = V3.Text = "Robert Goch";
                    V04.Text = V4.Text = "Paul Ehrlic";
                    descriere.Text = "(Victor Babes a sris alaturi de Victor Andre Cornil,in anul 1885, primul tratat de bacteorologie";


                }
                else if (question == 10)
                {
                    un_sg_rasp();

                    imagine_test.Image = Properties.Resources.intrebare_nr_24;
                    qlabel.Text = "Care este denumirea orasului port pentru care Rusia a pornit un razboi impotriva Rusiei?";  //Port Arthur
                    descriere.Text = "";


                }
                else if (question == 11)
                {
                    multiple_choice();
                    imagine_test.Image = Properties.Resources.intrebare_nr_25;
                    qlabel.Text = "Cand a izbucnit Primul Razboi Balcanic?";
                    V01.Text = V1.Text = "30 mai 1913";
                    V02.Text = V2.Text = "8 octombire 1912";  //c
                    V03.Text = V3.Text = "18 mai 1913";
                    V04.Text = V4.Text = "18 iulie 1913";
                    descriere.Text = "";


                }
                else if (question == 12)
                {
                    multiple_choice();
                    imagine_test.Image = Properties.Resources.intrebare_nr_26;
                    qlabel.Text = "In timpul Celui De Al Doilea Razboi Balcanic,desfasurat in vara lui 1914,Romania a castigat:";
                    V01.Text = V1.Text = "Transilvania";
                    V02.Text = V2.Text = "Criseana";
                    V03.Text = V3.Text = "Cadrilaterul"; //c
                    V04.Text = V4.Text = "Basarabia";
                    descriere.Text = "";



                }
                else if (question == 13)
                {
                    if (aces_t1 == true)
                    {
                        timp.Visible = imagine_ceas.Visible = false;
                        panel1.Visible = true;
                        descriere.Visible = false;

                        double percentage = (int)Math.Round((double)(corecte_t1 * 100) / 12);
                        if (corecte_t1 <= 6) MessageBox.Show("Mai ai de invatat!" + Environment.NewLine + "Scor:" + percentage + "%");
                        else if (corecte_t1 >= 7 && corecte_t1 <= 9) MessageBox.Show("Se putea si mai bine!" + Environment.NewLine + "Scor:" + percentage + "%");
                        else if (corecte_t1 >= 10 && corecte_t1 <= 11) MessageBox.Show("Impresionant!" + Environment.NewLine + "Scor:" + percentage + "%");
                        else if (corecte_t1 == 12) MessageBox.Show("Ai facut ca la carte!Bravo!" + Environment.NewLine + "Scor:" + percentage + "%");
                     




                        if (corecte_t1 == 7)
                        {
                            motivator = "Puncataj : 100/100" + '\n' + "Meriti acest premiu!";
                            this.Alert("Final", Form_Alert.enmType.Perfect);
                        }
                        else
                        {
                            motivator = "Punctaj:" + Convert.ToString(corecte_t1) + "/12";
                            this.Alert("Final", Form_Alert.enmType.Final);
                        }
                    
                    }
                    else
                    {
                        multiple_choice();
                        imagine_test.Image = Properties.Resources.intrebare_nr_32;
                        qlabel.Text = "Caii sunt considerati eroii Primului Razboi Mondial. Cati cai au murit in Marele Razboi?";
                        V01.Text = V1.Text = "40 de milione";
                        V02.Text = V2.Text = "1,3 milioane";
                        V03.Text = V3.Text = "8 milioane"; //c
                        V04.Text = V4.Text = "10 de milioane";
                        descriere.Text = "";
                        //https://www.historia.ro/sectiune/general/articol/top-5-animale-ale-razboiului-de-la-cai-la-licurici



                    }

                }
                else if (question == 14)
                {
                    multiple_choice();
                    imagine_test.Image = Properties.Resources.intrebare_nr_33;
                    qlabel.Text = "Unde au fost trase cele mai multe focuri de artilerie?";
                    V01.Text = V1.Text = "Somme";  //c
                    V02.Text = V2.Text = "Messines";
                    V03.Text = V3.Text = "Marna";
                    V04.Text = V4.Text = "Verdun";
                    descriere.Text = "La Somme au fost trase 4 milioane de astfel de focuri";


                }
                else if (question == 15)
                {
                    multiple_choice();
                    imagine_test.Image = Properties.Resources.intrebare_nr_34;
                    qlabel.Text = "Care a fost cea mai sangeroasa batalie din timpul Marelui Razboi?";
                    V01.Text = V1.Text = "Somme";
                    V02.Text = V2.Text = "Marna";
                    V03.Text = V3.Text = "Verdun"; //c
                    V04.Text = V4.Text = "alt raspuns";
                    descriere.Text = "Numărul de morți, răniți și dispăruți se ridică la 700 000 de persoane";

                }
                else if (question == 16)
                {
                    intrebare_an();
                    imagine_test.Image = Properties.Resources.intrebare_nr_35;
                    qlabel.Text = "In ce an a intrat Romania in Marele Razboi?"; //1916
                    descriere.Text = "27 august 1916";

                }
                else if (question == 17)
                {
                    un_sg_rasp();
                    imagine_test.Image = Properties.Resources.intrebare_nr_37;
                    qlabel.Text = "Numeste orasul in care autoritatile romane s-au retras in WW1.";
                    //Iasi
                    descriere.Text = "";


                }
                else if (question == 18)
                {
                    un_sg_rasp();
                    imagine_test.Image = Properties.Resources.tezaurRomania;
                    qlabel.Text = "Numeste tara in care Romania si-a trimis, spre depozitare in sigaranta, aurul si obiecte de valoare.";
                    //Rusia
                    descriere.Text = "";


                }
                else if (question == 19)
                {
                    intrebare_an();
                    imagine_test.Image = Properties.Resources.intrebare_nr_39;
                    qlabel.Text = "In ce an au intrat SUA in razboi?";//1917
                    descriere.Text = "";


                }
                else if (question == 20)
                {
                    intrebare_an();
                    imagine_test.Image = Properties.Resources.intrebare_nr_40;
                    qlabel.Text = "In ce an iesit Rusia din Razboi?"; //1917
                    descriere.Text = "";


                }
                else if (question == 21)
                {
                    multiple_choice();
                    imagine_test.Image = Properties.Resources.intrebare_nr_43;
                    qlabel.Text = "Cand au fost folosite primele tancuri din istorie?";
                    V01.Text = V1.Text = "1914";
                    V02.Text = V2.Text = "1915";
                    V03.Text = V3.Text = "1916"; //c
                    V04.Text = V4.Text = "1918";
                    descriere.Text = "Pe data de 15 sept. 1916 primele tancuri-mk1- au luat parte la batalia de pe Somme";


                }
                else if (question == 22)
                {
                    if (aces_t2 == true)
                    {
                        descriere.Visible = false;
                        timp.Visible = imagine_ceas.Visible = false;
                        panel1.Visible = true;
                        double percentage = (double)Math.Round((double)(corecte_t2 * 100) / 9);

                        string s;


                        percentage = (int)Math.Round((double)(corecte_t2 * 100) / 9);
                        if (corecte_t2 <= 4) MessageBox.Show("Mai ai de invatat!" + Environment.NewLine + "Scor:" + percentage + "%");
                        else if (corecte_t2 >= 4 && corecte_t2 <= 6) MessageBox.Show("Se putea si mai bine!" + Environment.NewLine + "Scor:" + percentage + "%");
                        else if (corecte_t2 >= 7 && corecte_t2 <= 9) MessageBox.Show("Impresionant!" + Environment.NewLine + "Scor:" + percentage + "%");
                        else if (corecte_t2 == 10) MessageBox.Show("Ai facut ca la carte!Bravo!" + Environment.NewLine + "Scor:" + percentage + "%");


                        


                        if (corecte_t2 == 9)
                        {
                            motivator = "Puncataj : 100/100" + '\n' + "Meriti acest premiu!";
                            this.Alert("Final", Form_Alert.enmType.Perfect);
                        }
                        else
                        {
                            motivator = "Punctaj:" + Convert.ToString(corecte_t2) + "/9";
                            this.Alert("Final", Form_Alert.enmType.Final);
                        }
                        
                    }
                    else
                    {
                        multiple_choice();
                        imagine_test.Image = Properties.Resources.intrebare_nr_48;
                        qlabel.Text = "Care Rege al Romaniei i-a daruit Mitei biciclista casa care ii poarta numele?";
                        V01.Text = V1.Text = "Carol I";
                        V02.Text = V2.Text = "Carol al II-lea";
                        V03.Text = V3.Text = "Ferdinand I";  //c
                        V04.Text = V4.Text = "Mihai I";
                        descriere.Text = "";
                    }

                }
                else if (question == 23)
                {
                    un_sg_rasp();
                    imagine_test.Image = Properties.Resources.rinruhr1;
                    qlabel.Text = "Care este regiunea ocupata de francezi dorita faptului ca Germania nu a platit dezpagubirile de razboi?";
                    //rin-ruhr/ rurh



                }
                else if (question == 24)
                {
                    intrebare_an();
                    imagine_test.Image = Properties.Resources.intrebare_nr_52;
                    qlabel.Text = "In ce an Benito Mussolini a luat puterea in Italia?";//1922
                    descriere.Text = "";
                }
                else if (question == 25)
                {
                    intrebare_an();
                    imagine_test.Image = Properties.Resources.intrebare_nr_53;
                    qlabel.Text = "In ce an Adolf Hitler a incercat sa dobandeasca controlul printr-un puci?";//1923
                    descriere.Text = "";


                }
                else if (question == 26)
                {
                    multiple_choice();
                    imagine_test.Image = Properties.Resources.intrebare_nr_54;
                    qlabel.Text = "In ce oras a avut loc puciul respectiv?";
                    V01.Text = V1.Text = "Berlin";
                    V02.Text = V2.Text = "Munchen"; //c
                    V03.Text = V3.Text = "Hamburg";
                    V04.Text = V4.Text = "Frankfurt";
                    descriere.Text = "";



                }
                else if (question == 27)
                {
                    un_sg_rasp();
                    imagine_test.Image = Properties.Resources.intrebare_nr_58;
                    qlabel.Text = "In ce oras a avut loc Masacrul de Valentine's Day?";
                    //1929;

                }
                else if (question == 28)
                {
                    multiple_choice();
                    imagine_test.Image = Properties.Resources.intrebare_nr_56;
                    qlabel.Text = "Dupa terminarea Marelui Razboi,cand s-au intors  acasa soldatii americani,nu au mai avut in ce se isi inece amarul.In ce perioda a activat legea prohibitiei?";
                    V01.Text = V1.Text = "1918-1930";
                    V02.Text = V2.Text = "1918-1933";
                    V03.Text = V3.Text = "1920-1930"; //c
                    V04.Text = V4.Text = "1920-1933";
                    descriere.Text = "";


                }
                else if (question == 29)
                {
                    intrebare_an();
                    imagine_test.Image = Properties.Resources.intrebare_nr_65;
                    qlabel.Text = "In ce an a devenit Adolf Hitler Cancelarul Germaniei?";//1933
                    descriere.Text = "";


                }
                else if (question == 30)
                {
                    if (aces_t3 == true)
                    {
                        timp.Visible = imagine_ceas.Visible = false;
                        descriere.Visible = false;
                        panel1.Visible = true;
                        double percentage = (double)Math.Round((double)(corecte_t3 * 100) / 8);

                        string s;
     

                        if (corecte_t3 <= 3) MessageBox.Show("Mai ai de invatat!" + Environment.NewLine + "Scor:" + percentage + "%");
                        else if (corecte_t3 >= 4 && corecte_t3 <= 5) MessageBox.Show("Se putea si mai bine!" + Environment.NewLine + "Scor:" + percentage + "%");
                        else if (corecte_t3 >= 6 && corecte_t3 <= 7) MessageBox.Show("Impresionant!" + Environment.NewLine + "Scor:" + percentage + "%");
                        else if (corecte_t3 == 8) MessageBox.Show("Ai facut ca la carte!Bravo!" + Environment.NewLine + "Scor:" + percentage + "%");


                        if (corecte_t3 == 8)
                        {
                            motivator = "Puncataj : 100/100" + '\n' + "Meriti acest premiu!";
                            this.Alert("Final", Form_Alert.enmType.Perfect);
                        }
                        else
                        {
                            motivator = "Punctaj:" + Convert.ToString(corecte_t3) + "/8";
                            this.Alert("Final", Form_Alert.enmType.Final);
                        }
                 
                    }
                    else
                    {
                        multiple_choice();
                        imagine_test.Image = Properties.Resources.intrebare_nr_68;
                        qlabel.Text = "Cine s-a aflat in timpul Celui De Al Doilea Razboi Mondial?";
                        V01.Text = V1.Text = "Harbert Hoover";
                        V02.Text = V2.Text = "Robert D. Rooselvelt"; //c
                        V03.Text = V3.Text = "Harry Truman";
                        V04.Text = V4.Text = "Dwight Eisnehower";
                        descriere.Text = "";


                    }

                }
                else if (question == 31)
                {
                    multiple_choice();
                    imagine_test.Image = Properties.Resources.intrebare_nr_70;
                    qlabel.Text = "Personalitatea din imagine,comandantul suprem al SS, este :";
                    V01.Text = V1.Text = "Joseph Goebbels";
                    V02.Text = V2.Text = "Erwin Rommel";
                    V03.Text = V3.Text = "Heinrich Himmler"; //c
                    V04.Text = V4.Text = "Herman Göring";
                    descriere.Text = "";



                }
                else if (question == 32)
                {
                    multiple_choice();
                    imagine_test.Image = Properties.Resources.intrebare_nr_72;
                    qlabel.Text = "Personalitatea din imagine, comandantul aviației militare a Germaniei naziste,Luftwaffe,este :";
                    V01.Text = V1.Text = "Herman Göring"; //c
                    V02.Text = V2.Text = "Erwin Rommel";
                    V03.Text = V3.Text = "Otto Ranke";
                    V04.Text = V4.Text = "Joseph Goebbels";
                    descriere.Text = "";


                }
                else if (question == 33)
                {
                    multiple_choice();
                    imagine_test.Image = Properties.Resources.intrebare_nr_73;
                    qlabel.Text = "Personalitatea din imagine, Ministrul Propagandei Publice în timpul regimului nazist,este:";
                    V01.Text = V1.Text = "Herman Göring";
                    V02.Text = V2.Text = "Joseph Goebbels";//c
                    V03.Text = V3.Text = "Heinrich Himmler";
                    V04.Text = V4.Text = "Erwin Rommel";
                    descriere.Text = "";


                }
                else if (question == 34)
                {
                    multiple_choice();
                    imagine_test.Image = Properties.Resources.intrebare_nr_74;
                    qlabel.Text = "Personalitatea din imagine este:";
                    V01.Text = V1.Text = "Heinrich Himmler";
                    V02.Text = V2.Text = "Erwin Rommel";//c
                    V03.Text = V3.Text = "Joseph Goebbels";
                    V04.Text = V4.Text = "Herman Göring";
                    descriere.Text = "(Datorita campaniilor sale din nordul Africii poarta porecla de “Vulpea de desert”";
                    descriere.Visible = true;

                }
                else if (question == 35)
                {
                    multiple_choice();
                    imagine_test.Image = Properties.Resources.intrebare_nr_78;
                    qlabel.Text = "Mambrii Axei au fost:";
                    V01.Text = V1.Text = "Germania";
                    V02.Text = V2.Text = "Italia";
                    V03.Text = V3.Text = "Japonia";
                    V04.Text = V4.Text = "toate variantele sunt corecte"; //c
                    descriere.Text = "Axa Berlin-Roma-Tokio a reprezentat alianta care a luptat impotriva aliatilor.";

                }
                else if (question == 36)
                {
                    un_sg_rasp();

                    imagine_test.Image = Properties.Resources.intrebare_nr_81;
                    qlabel.Text = "Numeste o tara europena care nu a participat la Cel De Al Doilea Razboi Mondial.";
                    descriere.Text = "Un porumbel tinand in plisc o ramura de maslin este simbolul pacii.";
                    descriere.Visible = true;
                }
                else if (question == 37)
                {
                    un_sg_rasp();

                    imagine_test.Image = Properties.Resources.intrebare_nr_85;
                    qlabel.Text = "Care este numele complet al primului informatician din lume.persoana responsabila de spargerea sistemelor de comunicatii naziste?";  //Alan Turing
                    descriere.Text = "";

                }
                else if (question == 38)
                {
                    intrebare_an();

                    imagine_test.Image = Properties.Resources.intrebare_nr_86;
                    qlabel.Text = "In ce an afost semnat pactul de neagresiune Ribbentrop-Molotov,de ministrul de externe german si omologul sau:";
                    descriere.Text = "Pactul de impartire a Europei in sfere de influenta a fost semnat pe data de 23 august 1939,dar avea sa fie incalcat cand Hitler a invadat URSS in 1941";


                }
                else if (question == 39)
                {
                    intrebare_an();

                    imagine_test.Image = Properties.Resources.intrebare_nr_87;
                    qlabel.Text = "In ce an Romania a fost fortata sa cedeze Cadrilaterul, Nordul Bucovinei, Basarabia si Transilvania de Nord?"; //1940
                    descriere.Text = "";


                }
                else if (question == 40)
                {
                    intrebare_an();
                    imagine_test.Image = Properties.Resources.intrebare_nr_88;

                    qlabel.Text = "In ce an izbucnit Razboiul de Iarna?"; //1939


                }
                else if (question == 41)
                {
                    intrebare_an();
                    imagine_test.Image = Properties.Resources.intrebare_nr_90;
                    qlabel.Text = "In ce an a avut loc evacuarea de la Dunkerque?"; //1940
                    descriere.Text = "Hitler nu a reusit sa inteleaga Blitzkrieg,care era un razboi foarte dinamic.Nici lui,nici lui Churchill nu i-a venit sa creada cat teren castigasera nemtii in doar cateva zile.Odata ce Hitler a invervenit in coordonarea Blitzkrieg,acesta i-a redus eficienta.";

                }
                else if (question == 42)
                {
                    multiple_choice();
                    imagine_test.Image = Properties.Resources.intrebare_nr_92;
                    qlabel.Text = "In ce tara si-a trimis Hitler o parte semnificativa din rezervele de aur pentru depozitare in timpul Celui De Al Doilea Razboi Mondial?";
                    V01.Text = V1.Text = "Austria";
                    V02.Text = V2.Text = "Ungaria";
                    V03.Text = V3.Text = "Italia";
                    V04.Text = V4.Text = "Elvetia";//c
                    descriere.Text = "Elvetia evea sa fie cunoscuta pentru paradisul bancar pe care il avea, ba mai mult decat atat, Elvetia nu doar ca depozitat banii Germaniei naziste, dar a si ajutat-o de-a lungul istoriei(Nestle oferea mancare soldailor germani, iar evreii nu erau lasati sa refugieze in tara).";

                }
                else if (question == 43)
                {
                    intrebare_an();
                    imagine_test.Image = Properties.Resources.intrebare_nr_94;
                    qlabel.Text = "In ce an a incercat Mussolini sa invadeze Grecia?";//1941
                    descriere.Text = "";

                }
                else if (question == 44)
                {
                    multiple_choice();
                    imagine_test.Image = Properties.Resources.intrebare_nr_95;
                    qlabel.Text = "Ce stat i-a ajutat pe grecii sa castige razboiul?";
                    V01.Text = V1.Text = "SUA";
                    V02.Text = V2.Text = "Marea Britanie"; //c
                    V03.Text = V3.Text = "Bulgaria";
                    V04.Text = V4.Text = "URSS";
                    descriere.Text = "";

                }
                else if (question == 45)
                {
                    intrebare_an();
                    imagine_test.Image = Properties.Resources.intrebare_nr_97;
                    qlabel.Text = "In ce an japonezii au bombardat Pearl Harbor,distrugand jumatate din flota din Hawaii?"; //1941
                    descriere.Text = "Atacul Pearl Harbour-ului s-a intamplat pe 7 decembrie 1941.A doua zi presedintele Franklin Rooselvelt a declarat razboi Japoniei.Pentru a transporta presedintele in siguranta,serviciile secrete i-au facut rost de o masina antiglont-masina lui Al Capone";

                }
                else if (question == 46)
                {
                    dual();
                    imagine_test.Image = Properties.Resources.intrebare_nr_99;
                    qlabel.Text = "Intre ce ani a avut loc asediul Leningradului?";//1941-1944
                    descriere.Text = "";

                }
                else if (question == 47)
                {
                    dual();
                    imagine_test.Image = Properties.Resources.intrebare_nr_100;
                    qlabel.Text = "Intre ce ani a avut loc Batalia Stalingradului?";//1942-1943
                    descriere.Text = "";

                }
                else if (question == 48)
                {
                    intrebare_an();
                    imagine_test.Image = Properties.Resources.intrebare_nr_101;
                    qlabel.Text = "In ce an a avut loc invazia Siciliei de catre trupele aliate?";//1943
                    descriere.Text = "";

                }
                else if (question == 49)
                {
                    multiple_choice();
                    imagine_test.Image = Properties.Resources.intrebare_nr_102;
                    qlabel.Text = "In urma carei conferinte,Stalin si Churchill au decis impartirea Europei in sfere de influente britanico-ruse?";
                    V01.Text = V1.Text = "Quebec";
                    V02.Text = V2.Text = "Teheran";
                    V03.Text = V3.Text = "Ialta";
                    V04.Text = V4.Text = "Moscova"; //c
                    descriere.Text = "Romania:90%-URSS;10%-UK" + Environment.NewLine + "Grecia:10%-URSS;90%-UK" + Environment.NewLine + "Iugoslavia:50%-URSS;10%-UK" + Environment.NewLine + "Bulgaria:75%-URSS;25%-UK" + Environment.NewLine + "Desi Stalin si Churchill sa imparta controlul in Iugoslavia in mod egal,la fiecare 6 englezi in parlament existau 25 de rusi. ";
                    descriere.Visible = true;


                }
                else if (question == 50)
                {
                    multiple_choice();
                    imagine_test.Image = Properties.Resources.intrebare_nr_103;
                    qlabel.Text = "Ce obiective importante din Romania au bombardat Alitatii in anul 1944, datorita implicarii acesteia in razboi de parte Germaniei?";
                    V01.Text = V1.Text = "Bucurestiul si Flota Navala";
                    V02.Text = V2.Text = "Bucurestiul si rafinariile de petrol de la Ploiesti"; //c
                    V03.Text = V3.Text = "Rafinariile de petrol de la Ploiesti si Flota Navala";
                    V04.Text = V4.Text = "Flota Navala si Aviatia Regala Romana";
                    descriere.Text = "";


                }
                else if (question == 51)
                {

                    un_sg_rasp();

                    imagine_test.Image = Properties.Resources.intrebare_nr_111;
                    qlabel.Text = "Ca urmare a Celui De Al Doilea Razboi Mondial,ce exclava a castigat Rusia?";
                    //Könisberg  / Kaliningrad

                    descriere.Text = "Initial,orasul s-a numit Könisberg,dar rusii au decimat populatia germana si l-au redenumit ulterior Kaliningrad.";



                }
                else if (question == 52)
                {
                    if (aces_t4 == true)
                    {
                        timp.Visible = imagine_ceas.Visible = false;
                        descriere.Visible = false;
                        panel1.Visible = true;
                        double percentage = (double)Math.Round((double)(corecte_t4 * 100) / 22);

                        string s;

                        if (corecte_t4 <= 10) MessageBox.Show("Mai ai de invatat!" + Environment.NewLine + "Scor:" + percentage + "%");
                        else if (corecte_t4 >= 11 && corecte_t4 <= 15) MessageBox.Show("Se putea si mai bine!" + Environment.NewLine + "Scor:" + percentage + "%");
                        else if (corecte_t4 >= 16 && corecte_t4 <= 21) MessageBox.Show("Impresionant!" + Environment.NewLine + "Scor:" + percentage + "%");
                        else if (corecte_t4 == 22) MessageBox.Show("Ai facut ca la carte!Bravo!" + Environment.NewLine + "Scor:" + percentage + "%");

                        



                        if (corecte_t4 == 22)
                        {
                            motivator = "Puncataj : 100/100" + '\n' + "Meriti acest premiu!";
                            this.Alert("Final", Form_Alert.enmType.Perfect);
                        }
                        else
                        {
                            motivator = "Punctaj:" + Convert.ToString(corecte_t4) + "/22";
                            this.Alert("Final", Form_Alert.enmType.Final);
                        }
                   
                    }
                    else
                    {
                        intrebare_an();
                        imagine_test.Image = Properties.Resources.intrebare_nr_117;
                        qlabel.Text = "In ce an a fost proclamata Republica Populara Romania ?"; //1947
                        descriere.Text = "";

                    }



                }
                else if (question == 53)
                {
                    intrebare_an();
                    imagine_test.Image = Properties.Resources.intrebare_nr_123;
                    qlabel.Text = "Care este “Anul Africii”?";  //1960
                    descriere.Text = "";

                }
                else if (question == 54)
                {
                    multiple_choice();
                    imagine_test.Image = Properties.Resources.intrebare_nr_124;
                    qlabel.Text = "Cine i-a dat Zidului Berlinului denumirea metaforica “Cortina de Fier”?";
                    V01.Text = V1.Text = "Franklin Deleano Rooselvelt";
                    V02.Text = V2.Text = "Winston Churchill";  //c
                    V03.Text = V3.Text = "George al VI-lea";
                    V04.Text = V4.Text = "Iosef Stalin";
                    descriere.Text = "";

                }
                else if (question == 55)
                {
                    intrebare_an();
                    imagine_test.Image = Properties.Resources.intrebare_nr_125png;
                    qlabel.Text = "In ce an a fost semnat Tratatul Antarcticii,prin care se interzice desfasurarea de actiuni militare sau miniere in cadrul continentului?";
                    //1961
                    descriere.Text = "";

                }
                else if (question == 56)
                {
                    un_sg_rasp();

                    imagine_test.Image = Properties.Resources.intrebare_nr_126;
                    qlabel.Text = "Care este numele complet a personalitatii din imagine?";
                    //Fidel Castro
                    descriere.Text = "";

                }
                else if (question == 57)
                {
                    un_sg_rasp();

                    imagine_test.Image = Properties.Resources.intrebare_nr_127;
                    qlabel.Text = "Care este numele complet a personalitatii din imagine?";
                    //JFK/ J.F.K./ John Fitzgerald Kennedy
                    descriere.Text = "";

                }
                else if (question == 58)
                {
                    un_sg_rasp();

                    imagine_test.Image = Properties.Resources.intrebare_nr_128;
                    qlabel.Text = "Care este numele complet a personalitatii din imagine?";
                    //Ronald Reagan
                    descriere.Text = "";

                }
                else if (question == 59)
                {
                    intrebare_an();
                    imagine_test.Image = Properties.Resources.intrebare_nr_132;
                    qlabel.Text = "In ce an a avut loc criza rachetelor din Cuba?";
                    //1962
                    descriere.Text = "";

                }
                else if (question == 60)
                {
                    intrebare_an();
                    imagine_test.Image = Properties.Resources.intrebare_nr_134;
                    qlabel.Text = "Cate zile a durat criza ostaticilor din Iran?";
                    //444
                    descriere.Text = "A fost orhestrata de studenti musulmani care au luat 52 de ostatici americani de la ambasada SUA din Teheran.Asediul a inceput pe 4 noiembre 1979 si s-a inchiat pe 20 ianuarie 1989";

                }
                else if (question == 61)
                {
                    intrebare_an();
                    imagine_test.Image = Properties.Resources.intrebare_nr_138;
                    qlabel.Text = "Cate membre ale tratatului de la Varsovia care nu au atacat Cehoslovacia?";
                    //2
                    descriere.Text = "Albania si Romania au fost singurele care s-au opus dur acestei operatiuni (Ceausescu avea sa critice dur actiunile U.R.S.S.-ului),iar Germania de Est a primit ordin de la Moscova sa nu se implice.";

                }
                else if (question == 62)
                {
                    intrebare_an();
                    imagine_test.Image = Properties.Resources.intrebare_nr_142;
                    qlabel.Text = "In ce an au avut loc destramarea URSS si Reunificarea Germaniei?";
                    //1991
                    descriere.Text = "";

                }
                else if (question == 63)
                {
                    if (aces_t5 == true)
                    {
                        timp.Visible = imagine_ceas.Visible = false;
                        descriere.Visible = false;
                        panel1.Visible = true;
                        double percentage = (double)Math.Round((double)(corecte_t5 * 100) / 11);

                        string s;

                        if (corecte_t5 <= 4) MessageBox.Show("Mai ai de invatat!" + Environment.NewLine + "Scor:" + percentage + "%");
                        else if (corecte_t5 >= 5 && corecte_t5 <= 7) MessageBox.Show("Se putea si mai bine!" + Environment.NewLine + "Scor:" + percentage + "%");
                        else if (corecte_t5 >= 8 && corecte_t5 <= 10) MessageBox.Show("Impresionant!" + Environment.NewLine + "Scor:" + percentage + "%");
                        else if (corecte_t5 == 11) MessageBox.Show("Ai facut ca la carte!Bravo!" + Environment.NewLine + "Scor:" + percentage + "%");
      

                        if (corecte_t5 == 7)
                        {
                            motivator = "Puncataj : 100/100" + '\n' + "Meriti acest premiu!";
                            this.Alert("Final", Form_Alert.enmType.Perfect);
                        }
                        else
                        {
                            motivator = "Punctaj:" + Convert.ToString(corecte_t5) + "/11";
                            this.Alert("Final", Form_Alert.enmType.Final);
                        }
                        

                    }
                    else if (aces_generale == true)
                    {
                        timp.Visible = imagine_ceas.Visible = false;
                        descriere.Visible = false;
                        panel1.Visible = true;
                        double percentage = (double)Math.Round((double)(corecte_genarale * 100) / 62);

                        string s;

                        if (corecte_genarale <= 25) MessageBox.Show("Mai ai de invatat!" + Environment.NewLine + "Scor:" + percentage + "%");
                        else if (corecte_genarale >= 26 && corecte_genarale <= 45) MessageBox.Show("Se putea si mai bine!" + Environment.NewLine + "Scor:" + percentage + "%");
                        else if (corecte_genarale >= 46 && corecte_genarale <= 61) MessageBox.Show("Impresionant!" + Environment.NewLine + "Scor:" + percentage + "%");
                        else if (corecte_genarale == 62) MessageBox.Show("Ai facut ca la carte!Bravo!" + Environment.NewLine + "Scor:" + percentage + "%");
                     



                        if (corecte_genarale == 62)
                        {
                            motivator = "Puncataj : 100/100" + '\n' + "Meriti acest premiu!";
                            this.Alert("Final", Form_Alert.enmType.Perfect);
                        }
                        else
                        {
                            motivator = "Punctaj:" + Convert.ToString(corecte_genarale) + "/62";
                            this.Alert("Final", Form_Alert.enmType.Final);
                        }

                    }




                }




                if (aspect == 1) timp.Text = "25s";
                else if (aspect == 0) timp.Text = "25:00";

                timp.Value = 100; timp.ProgressColor = timp.ForeColor = Color.FromArgb(30, 208, 34);
                quick = 1500;
            }
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            format.Visible = true;format.Text = "Schimbă aspectul";
            inserare_raspuns.ReadOnly = true;
            inserare2.ReadOnly = true;
            inserare1.ReadOnly = true;

            merge_cronometrul = false;
            descriere.Visible = true;

            if (inserare_raspuns.Text == "*insereaza raspunsul") inserare_raspuns.Text = "  ";

            if (inserare1.Text == "*primul an") inserare1.Text = "";
            if (inserare2.Text == "*al doilea an") inserare2.Text = "";




            if (aces == true||acces_variante==true||acces_tasta==true)
            {
                aces = false;
                OK.Visible = true;



                int ad=0;
                Enter.Visible = false;

                bool incercat = true;

                str = inserare_raspuns.Text;str = str.Trim();
                str1 = inserare1.Text;str1 = str1.Trim();
               string  str2 = inserare2.Text;str2=str2.Trim();
             


                if (question == 3)
                    {

                        descriere.Visible = true;

                        if (an.Text == "1870") { an.ForeColor = Color.Green; ad = 1; }
                        else { an.ForeColor = Color.Red; rasp_corect.Text = "1870"; rasp_corect.Visible = true; }
                        sir = "1870";
                    }
                    else if (question == 5)
                    {
                        imagine_test.Image = Properties.Resources.intrebare_nr_11_2;
                        if (an.Text == "1857") { an.ForeColor = Color.Green; ad = 1; }
                        else { an.ForeColor = Color.Red; rasp_corect.Text = "1857"; rasp_corect.Visible = true; }
                        sir = "1857";
                    }
                    else if (question == 6)
                    {
                        imagine_test.Image = Properties.Resources.intrebare_nr_13_2;
                        descriere.Text = "Romania a avut doar 4 regi,acestia fiind:Carol I,Ferdinand I,Carol al II-lea si Mihai I";
                        descriere.Visible = true;
                        if (an.Text == "4") { an.ForeColor = Color.Green; ad = 1; }
                        else { an.ForeColor = Color.Red; rasp_corect.Text = "4"; rasp_corect.Visible = true; }
                        sir = "4";
                    }
                    else if (question == 7)
                    {
                    
                        bool c = true;
                        if (str1 == "1861") inserare1.ForeColor = Color.Green;
                        else { c = false; inserare1.ForeColor = Color.Red; }
                        if (str2 == "1865") inserare2.ForeColor = Color.Green;
                        else { c = false; inserare2.ForeColor = Color.Red; }

                        if (c == false) { rasp_corect.Text = "1861-1865"; rasp_corect.Visible = true; }
                        else ad = 1;
                        sir = "1861-1865";
                    }
                    else if (question == 10)
                    {

                        str = inserare_raspuns.Text;
                        str = str.Trim();




                        str1 = str;
                        str1 = str1.ToLower(); str1 = str1.Replace(" ", String.Empty);



                        if (str == "Port Arthur" || str == "PORT ARTHUR" || str == "Port  Arthur" || str == "PORT  ARTHUR" || str == "Port   Arthur" || str == "PORT   ARTHUR" || str == "Port    Arthur" || str == "PORT    ARTHUR" || str == "Port     Arthur" || str == "PORT     ARTHUR") { inserare_raspuns.ForeColor = Color.Green; ad = 1; }
                        else if (str1 == "portarthur") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „Port Arthur”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                        else { inserare_raspuns.ForeColor = Color.Red; rasp_corect.Text = "Port Arthur"; rasp_corect.Visible = true; }
                        sir = "Port Arthur";

                    }
                    else if (question == 16)
                    {
                        if (an.Text == "1916") { an.ForeColor = Color.Green; ad = 1; }
                        else { an.ForeColor = Color.Red; rasp_corect.Text = "1916"; rasp_corect.Visible = true; }
                        sir = "1916";
                    }
                    else if (question == 17)
                    {
                        str = inserare_raspuns.Text;
                        str = str.Trim();




                        str1 = str;
                        str1 = str1.ToLower();
                        str2 = inserare_raspuns.Text;
                        str2 = str2.ToUpper();

                        str1 = str1.Replace(" ", String.Empty);



                        if (str == "Iasi" || str == "Iași" || str == "IASI" || str == "IAȘI") { inserare_raspuns.ForeColor = Color.Green; ad = 1; }
                        else if (str1 == "iasi") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „Iasi”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                        else if (str1 == "iași") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „Iași”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                        else { inserare_raspuns.ForeColor = Color.Red; rasp_corect.Text = "Iași"; rasp_corect.Visible = true; }
                        sir = "Iași";
                    }
                    else if (question == 18)
                    {
                        str = inserare_raspuns.Text;
                        str = str.Trim();




                        str1 = str;
                        str1 = str1.ToLower(); str1 = str1.Replace(" ", String.Empty);


                        if (str == "Rusia" || str == "RUSIA") { inserare_raspuns.ForeColor = Color.Green; ad = 1; }
                        else if (str1 == "rusia") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „Rusia”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                        else { inserare_raspuns.ForeColor = Color.Red; rasp_corect.Text = "Rusia"; rasp_corect.Visible = true; }
                        sir = "Rusia";
                    }
                    else if (question == 19)
                    {
                        if (an.Text == "1917") { an.ForeColor = Color.Green; ad = 1; }
                        else { an.ForeColor = Color.Red; rasp_corect.Text = "1917"; rasp_corect.Visible = true; }
                        sir = "1917";
                    }
                    else if (question == 20)
                    {
                        if (an.Text == "1917") { an.ForeColor = Color.Green; ad = 1; }
                        else { an.ForeColor = Color.Red; rasp_corect.Text = "1917"; rasp_corect.Visible = true; }
                        sir = "1917";
                    }
                    else if (question == 23)
                    {
                        imagine_test.Image = Properties.Resources.rinruhr2;
                        str = inserare_raspuns.Text;
                        str = str.Trim();




                        str1 = str;
                        str1 = str1.ToLower(); str1 = str1.Replace(" ", String.Empty);



                        if (str == "Rin-Ruhr" || str == "Ruhr" || str == "RIN-RUHR" || str == "RUHR") { inserare_raspuns.ForeColor = Color.Green; ad = 1; }
                        else if (str1 == "ruhr") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „Ruhr”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                        else if (str1 == "rin-ruhr") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „Rin-Ruhr”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                        else { inserare_raspuns.ForeColor = Color.Red; rasp_corect.Text = "Rin-Ruhr"; rasp_corect.Visible = true; }
                        sir = "Rin-Ruhr";
                    }
                    else if (question == 24)
                    {
                        if (an.Text == "1922") { an.ForeColor = Color.Green; ad = 1; }
                        else { an.ForeColor = Color.Red; rasp_corect.Text = "1922"; rasp_corect.Visible = true; }
                        sir = "1922";
                    }
                    else if (question == 25)
                    {
                        if (an.Text == "1923") { an.ForeColor = Color.Green; ad = 1; }
                        else { an.ForeColor = Color.Red; an.ForeColor = Color.Red; rasp_corect.Text = "1923"; rasp_corect.Visible = true; }
                        sir = "1923";
                    }
                    else if (question == 27)
                    {
                        str = inserare_raspuns.Text;
                        str = str.Trim();




                        str1 = str;
                        str1 = str1.ToLower(); str1 = str1.Replace(" ", String.Empty);



                        if (str == "Chicago" || str == "CHICAGO") { inserare_raspuns.ForeColor = Color.Green; ad = 1; }
                        else if (str1 == "chicago") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „Chicago”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                        else { inserare_raspuns.ForeColor = Color.Red; rasp_corect.Text = "Chicago"; rasp_corect.Visible = true; }
                        sir = "Chicago";
                    }
                    else if (question == 29)
                    {
                        if (an.Text == "1933") { an.ForeColor = Color.Green; ad = 1; }
                        else { an.ForeColor = Color.Red; rasp_corect.Text = "1933"; rasp_corect.Visible = true; }
                        sir = "1933";
                    }
                    else if (question == 36)
                    {

                        str = inserare_raspuns.Text;
                        str = str.Trim();




                        str1 = str;
                        str1 = str1.ToLower(); str1 = str1.Replace(" ", String.Empty);




                        if (str == "Elvetia" || str == "ELVETIA" || str == "Elveția" || str == "ELVEȚIA" || str == "Spania" || str == "SPANIA" || str == "Portugalia" || str == "PORTUGALIA" || str == "Irlanda" || str == "IRLANDA" || str == "Suedia" || str == "SUEDIA") { inserare_raspuns.ForeColor = Color.Green; ad = 1; }
                        else if (str1 == "elvetia") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „Elvetia”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                        else if (str1 == "elveția") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „Elveția”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                        else if (str1 == "spania") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „Spania”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                        else if (str1 == "portugalia") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „Portugalia”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                        else if (str1 == "irlanda") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „Irlanda”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                        else if (str1 == "suedia") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „Suedia”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                        else { inserare_raspuns.ForeColor = Color.Red; ad = 0; rasp_corect.Text = "Elvetia"; rasp_corect.Visible = true; }
                        descriere.Text = "Un porumbel tinand in plisc o ramura de maslin este simbolul pacii.Singurele tari europene care nu au participat la razboi sunt:Portugalia,Spania,Elvetia,Suedia si Irlanda";
                        descriere.Visible = true;
                        sir = "Elvetia";

                    }
                    else if (question == 37)
                    {
                        str = inserare_raspuns.Text;
                        str = str.Trim();




                        str1 = str;
                        str1 = str1.ToLower(); str1 = str1.Replace(" ", String.Empty);


                        if (str == "Alan Turing" || str == "ALAN TURING" || str == "Alan  Turing" || str == "ALAN  TURING" || str == "Alan  Turing" || str == "ALAN   TURING" || str == "Alan    Turing" || str == "ALAN    TURING" || str == "Alan     Turing" || str == "ALAN     TURING") { inserare_raspuns.ForeColor = Color.Green; ad = 1; }
                        else if (str1 == "alanturing") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „Chicago”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                        else { inserare_raspuns.ForeColor = Color.Red; ; rasp_corect.Text = "Alan Turing"; rasp_corect.Visible = true; }
                        sir = "Alan Turing";
                    }
                    else if (question == 38)
                    {
                        if (an.Text == "1939") { an.ForeColor = Color.Green; ad = 1; }
                        else { an.ForeColor = Color.Red; rasp_corect.Text = "1939"; rasp_corect.Visible = true; }
                        sir = "1939";
                    }
                    else if (question == 39)
                    {
                        imagine_test.Image = Properties.Resources.intrebare87_2;
                        if (an.Text == "1940") { an.ForeColor = Color.Green; ad = 1; }
                        else { an.ForeColor = Color.Red; rasp_corect.Text = "1940"; rasp_corect.Visible = true; }
                        sir = "1940";
                    }
                    else if (question == 40)
                    {
                        if (an.Text == "1939") { an.ForeColor = Color.Green; ad = 1; }
                        else { an.ForeColor = Color.Red; rasp_corect.Text = "1939"; rasp_corect.Visible = true; }
                        sir = "1939";
                    }
                    else if (question == 41)
                    {

                        if (an.Text == "1940") { an.ForeColor = Color.Green; ad = 1; }
                        else { an.ForeColor = Color.Red; rasp_corect.Text = "1940"; rasp_corect.Visible = true; }
                        sir = "1940";
                    }
                    else if (question == 43)
                    {
                        if (an.Text == "1941") { an.ForeColor = Color.Green; ad = 1; }
                        else { an.ForeColor = Color.Red; rasp_corect.Text = "1941"; rasp_corect.Visible = true; }
                        sir = "1941";
                    }
                    else if (question == 45)
                    {
                        if (an.Text == "1941") { an.ForeColor = Color.Green; ad = 1; }
                        else { an.ForeColor = Color.Red; rasp_corect.Text = "1941"; rasp_corect.Visible = true; }
                        sir = "1941";
                    }
                    else if (question == 46)
                    {

                        bool c = true;
                        if (str1 == "1941") inserare1.ForeColor = Color.Green;
                        else { c = false; inserare1.ForeColor = Color.Red; }
                        if (str2 == "1944") inserare2.ForeColor = Color.Green;
                        else { c = false; inserare2.ForeColor = Color.Red; }

                        if (c == false) { rasp_corect.Text = "1941-1944"; rasp_corect.Visible = true; }
                        else ad = 1;

                        sir = "1941-1944";
                    }
                    else if (question == 47)
                    {
                        bool c = true;
                        if (str1== "1942") inserare1.ForeColor = Color.Green;
                        else { c = false; inserare1.ForeColor = Color.Red; }
                        if (str2 == "1943") inserare2.ForeColor = Color.Green;
                        else { c = false; inserare2.ForeColor = Color.Red; }

                        if (c == false) { rasp_corect.Text = "1942-1943"; rasp_corect.Visible = true; }
                        else ad = 1;
                        sir = "1942-1943";
                    }
                    else if (question == 48)
                    {
                        if (an.Text == "1943") { an.ForeColor = Color.Green; ad = 1; }
                        else { an.ForeColor = Color.Red; rasp_corect.Text = "1943"; rasp_corect.Visible = true; }
                        sir = "1943";
                    }
                    else if (question == 51)
                    {

                        str = inserare_raspuns.Text;
                        str = str.Trim();




                        str1 = str;
                        str1 = str1.ToLower(); str1 = str1.Replace(" ", String.Empty);




                        if (str == "Kaliningrad" || str == "KALININGRAD" || str == "Königsberg" || str == "KÖNIGSBERG" || str == "Konigsberg" || str == "KONIGSBERG") { inserare_raspuns.ForeColor = Color.Green; ad = 1; }
                        else if (str1 == "kaliningrad") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „Kaliningrad”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                        else if (str1 == "Königsberg") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „Königsberg”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                        else if (str1 == "Konigsberg") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „Konigsberg”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                        else { inserare_raspuns.ForeColor = Color.Red; rasp_corect.Text = "Königsberg"; rasp_corect.Visible = true; }
                        sir = "Konigsberg";

                    }
                    else if (question == 52)
                    {
                        if (an.Text == "1947") { an.ForeColor = Color.Green; ad = 1; }
                        else { an.ForeColor = Color.Red; rasp_corect.Text = "1947"; rasp_corect.Visible = true; }
                        sir = "1947";
                    }
                    else if (question == 53)
                    {
                        if (an.Text == "1960") { an.ForeColor = Color.Green; ad = 1; }
                        else { an.ForeColor = Color.Red; rasp_corect.Text = "1960"; rasp_corect.Visible = true; }
                        sir = "1960";

                    }
                    else if (question == 55)
                    {
                        if (an.Text == "1961") { an.ForeColor = Color.Green; ad = 1; }
                        else { an.ForeColor = Color.Red; rasp_corect.Text = "1961"; rasp_corect.Visible = true; }

                        sir = "1961";
                    }
                    else if (question == 56)
                    {
                        str = inserare_raspuns.Text;
                        str = str.Trim();




                        str1 = str;
                        str1 = str1.ToLower(); str1 = str1.Replace(" ", String.Empty);

                        if (str == "Fidel Castro" || str == "FIDEL CASTRO" || str == "Fidel  Castro" || str == "FIDEL  CASTRO" || str == "Fidel   Castro" || str == "FIDEL   CASTRO" || str == "Fidel    Castro" || str == "FIDEL    CASTRO" || str == "Fidel     Castro" || str == "FIDEL     CASTRO") { inserare_raspuns.ForeColor = Color.Green; ad = 1; }
                        else if (str1 == "fidelcastro") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Raspunsul este corect, dar se scrie „Fidel Castro”, nu „" + str + "”" + Environment.NewLine + "Ai grija la urmatoarele aspecte:" + Environment.NewLine + "-unde pui spatiile si cate pui" + Environment.NewLine + "-unde folosesti majuscule;" + Environment.NewLine + "-intre cuvinte se pune doar un spatiu;" + Environment.NewLine + "-nu se pune spatiu intre o liter si un semn de punctuatie/ de ortografie;"); }
                        else { inserare_raspuns.ForeColor = Color.Red; rasp_corect.Text = "Fidel Castro"; rasp_corect.Visible = true; }
                        sir = "Fidel Castro";

                    }
                    else if (question == 57)
                    {

                        str = inserare_raspuns.Text;
                        str = str.Trim();




                        str1 = str;
                        str1 = str1.ToLower(); str1 = str1.Replace(" ", String.Empty);




                        if (str == "JFK" || str == "J.F.K." || str == "John Fitzgerald Kennedy" || str == "JOHN FITZGERALD KENNEDY" || str == "John F. Kennedy" || str == "JOHN F. KENNEDY") { inserare_raspuns.ForeColor = Color.Green; ad = 1; }
                        else if (str1 == "jfk") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „JFK”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                        else if (str1 == "j.f.k.") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „j.f.k.”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                        else if (str1 == "johnfitzgeraldkennedy") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „John Fitzgerald Kennedy”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                        else if (str1 == "johnf.kennedy") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „John F. Kennedy”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                        else { inserare_raspuns.ForeColor = Color.Red; rasp_corect.Text = "John Fitzgerald Kennedy"; rasp_corect.Visible = true; }
                        sir = "John Fitzgerald Kennedy";

                    }
                    else if (question == 58)
                    {
                        str = inserare_raspuns.Text;
                        str = str.Trim();




                        str1 = str;
                        str1 = str1.ToLower(); str1 = str1.Replace(" ", String.Empty);

                        if (str == "Ronald Reagan" || str == "RONALD REAGAN" || str == "Ronald  Reagan" || str == "RONALD  REAGAN" || str == "Ronald   Reagan" || str == "RONALD   REAGAN" || str == "Ronald    Reagan" || str == "RONALD    REAGAN" || str == "Ronald     Reagan" || str == "RONALD     REAGAN") { inserare_raspuns.ForeColor = Color.Green; ad = 1; }
                        else if (str1 == "ronaldreagan") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Raspunsul este corect, dar se scrie „Ronald Reagan”, nu „" + str + "”" + Environment.NewLine + "Ai grija la urmatoarele aspecte:" + Environment.NewLine + "-unde pui spatiile si cate pui" + Environment.NewLine + "-unde folosesti majuscule;" + Environment.NewLine + "-intre cuvinte se pune doar un spatiu;" + Environment.NewLine + "-nu se pune spatiu intre o liter si un semn de punctuatie/ de ortografie;"); }
                        else { inserare_raspuns.ForeColor = Color.Red; rasp_corect.Text = "Ronald Reagan"; rasp_corect.Visible = true; }

                        sir = "Ronald Reagan";
                    }
                    else if (question == 59)
                    {
                        if (an.Text == "1962") { an.ForeColor = Color.Green; ad = 1; }
                        else { an.ForeColor = Color.Red; rasp_corect.Text = "1962"; rasp_corect.Visible = true; }
                        sir = "1962";
                    }
                    else if (question == 60)
                    {
                        if (an.Text == "444") { an.ForeColor = Color.Green; ad = 1; }
                        else { an.ForeColor = Color.Red; rasp_corect.Text = "444"; rasp_corect.Visible = true; }
                        sir = "444";
                    }
                    else if (question == 61)
                    {
                        if (an.Text == "3") { an.ForeColor = Color.Green; ad = 1; }
                        else { an.ForeColor = Color.Red; rasp_corect.Text = "3"; rasp_corect.Visible = true; }
                        sir = "3";
                    }
                    else if (question == 62)
                    {
                        if (an.Text == "1991") { an.ForeColor = Color.Green; ad = 1; }
                        else { an.ForeColor = Color.Red; rasp_corect.Text = "1991"; rasp_corect.Visible = true; }
                        sir = "1991";
                    }



                if (type == 2 && an.Text == "") this.Alert("Nothing", Form_Alert.enmType.Nothing);
                else if (type == 3 && (str1 == "" || str2 == ""))
                {
                    inserare1.BackColor = inserare2.BackColor = inserare_raspuns.BackColor = TEST.BackColor;
                    this.Alert("Nothing", Form_Alert.enmType.Nothing); }
                else if (type == 4 && str == "")
                {
                    inserare1.BackColor = inserare2.BackColor = inserare_raspuns.BackColor = TEST.BackColor;

                    underline_inserare_rasp.Value = 0;
                    underline_inserare_rasp.FillColor = Color.Red; this.Alert("Nothing", Form_Alert.enmType.Nothing);
                }
                else
                {
                    if (ad == 1)
                    {
                        underline_inserare_rasp.Value = 0;
                        underline_inserare_rasp.FillColor = Color.Green;

                        inserare_raspuns.BackColor = inserare1.BackColor = inserare2.BackColor = TEST.BackColor;

                        it_c++; it_g = 0;
                        if (it_c == 1) motivator = "Bravo!";
                        else if (it_c == 2) motivator = "Bună treabă!";
                        else if (it_c == 3) motivator = "Te descurci minunat!";
                        else if (it_c == 4) motivator = "Continua tot asa!";
                        else if (it_c == 5) motivator = "Excelent!!!";
                        else if (it_c == 6) motivator = "Bravooss!!";
                        else it_c = 0;
                        this.Alert("Success ", Form_Alert.enmType.Success);




                        corecte_genarale++;

                        if (question >= 1 && question <= 12) corecte_t1++;
                        if (question >= 13 && question <= 22) corecte_t2++;
                        if (question >= 23 && question <= 29) corecte_t3++;
                        if (question >= 30 && question <= 51) corecte_t4++;
                        if (question >= 52 && question <= 62) corecte_t5++;


                    }
                    else
                    {
                        underline_inserare_rasp.Value = 0;
                        underline_inserare_rasp.FillColor = Color.Red;

                        inserare1.BackColor = inserare2.BackColor = inserare_raspuns.BackColor = TEST.BackColor;
                        it_c = 0; it_g++;

                        if (it_g == 1) motivator = "Nu te lăsa descurajat!";
                        else if (it_g == 2) motivator = "Nu fii dezamagit!";
                        else if (it_g == 3) motivator = "Mai incearca!";
                        else if (it_g == 4) motivator = "Poate ai succes la următoarea...";
                        else it_g = 0;
                        this.Alert("Error", Form_Alert.enmType.Error);
                    }
                }

                
                
                   
                


                

            }
        }





   



        private void format_Click(object sender, EventArgs e)
        {
            if(format.Text=="Resetează aspectul")
            {
                inserare1.BackColor = inserare2.BackColor = inserare_raspuns.BackColor = cul_back.BackColor = TEST.BackColor = imagine_ceas.BackColor = descriere.BackColor = qlabel.BackColor = timp.InnerColor = timp.BackColor = aux_back.BackColor = Color.White;
                descriere.ForeColor = qlabel.ForeColor = Color.FromArgb(22, 18, 126);
                cul_intrebare.BackColor = cul_descriere.BackColor = Color.FromArgb(22, 18, 126);


                mostra_rot.BackColor = tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = Color.White;
                mostra_rot.FlatStyle = tasta0.FlatStyle = tasta1.FlatStyle = tasta2.FlatStyle = tasta3.FlatStyle = tasta4.FlatStyle = tasta5.FlatStyle = tasta6.FlatStyle = tasta7.FlatStyle = tasta8.FlatStyle = tasta9.FlatStyle = tasta_sterge.FlatStyle = FlatStyle.Flat;
                mostra_rot.ForeColor = tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor = Color.White;
                mostra_rot.ButtonColor = tasta0.ButtonColor = tasta1.ButtonColor = tasta2.ButtonColor = tasta3.ButtonColor = tasta4.ButtonColor = tasta5.ButtonColor = tasta6.ButtonColor = tasta7.ButtonColor = tasta8.ButtonColor = tasta9.ButtonColor = tasta_sterge.ButtonColor = Color.White;
                mostra_rot.TextColor = tasta0.TextColor = tasta1.TextColor = tasta2.TextColor = tasta3.TextColor = tasta4.TextColor = tasta5.TextColor = tasta6.TextColor = tasta6.TextColor = tasta7.TextColor = tasta8.TextColor = tasta9.TextColor = tasta_sterge.TextColor = Color.FromArgb(22, 18, 126);

                mostra_rot.BorderColor = tasta0.BorderColor = tasta1.BorderColor = tasta2.BorderColor = tasta3.BorderColor = tasta4.BorderColor = tasta5.BorderColor = tasta6.BorderColor = tasta7.BorderColor = tasta8.BorderColor = tasta9.BorderColor = tasta_sterge.BorderColor = Color.FromArgb(22, 18, 126);
                mostra_rot.OnHoverBorderColor = tasta0.OnHoverBorderColor = tasta1.OnHoverBorderColor = tasta2.OnHoverBorderColor = tasta3.OnHoverBorderColor = tasta4.OnHoverBorderColor = tasta5.OnHoverBorderColor = tasta6.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta8.OnHoverBorderColor = tasta9.OnHoverBorderColor = tasta_sterge.OnHoverBorderColor = Color.FromArgb(22, 18, 126);
                mostra_rot.OnHoverButtonColor = tasta0.OnHoverButtonColor = tasta1.OnHoverButtonColor = tasta2.OnHoverButtonColor = tasta3.OnHoverButtonColor = tasta4.OnHoverButtonColor = tasta5.OnHoverButtonColor = tasta6.OnHoverButtonColor = tasta7.OnHoverButtonColor = tasta8.OnHoverButtonColor = tasta9.OnHoverButtonColor = tasta_sterge.OnHoverButtonColor = Color.FromArgb(22, 18, 126);
                mostra_rot.OnHoverTextColor = tasta0.OnHoverTextColor = tasta1.OnHoverTextColor = tasta2.OnHoverTextColor = tasta3.OnHoverTextColor = tasta4.OnHoverTextColor = tasta5.OnHoverTextColor = tasta6.OnHoverTextColor = tasta7.OnHoverTextColor = tasta8.OnHoverTextColor = tasta9.OnHoverTextColor = tasta_sterge.OnHoverTextColor = Color.White;
                tasta_sterge.BackColor = Color.White;

                bordercolorbotton.BackColor = mostra_rot.BorderColor; hbordercolorbotton.BackColor = mostra_rot.OnHoverBorderColor;

                buttoncolorbutton.BackColor = mostra_rot.ButtonColor; hbuttoncolorbutton.BackColor = mostra_rot.OnHoverButtonColor;
                textcolorbutton.BackColor = mostra_rot.TextColor; htextcolorbutton.BackColor = mostra_rot.OnHoverTextColor;



                first_back = first_descriere = first_intrebare = true;


                if (pozitie == 1) mostra.BackColor = Color.White;
                else mostra.BackColor = Color.FromArgb(22, 18, 126);

                aux_back.BackColor = cul_back.BackColor;
                aux_intrebare.BackColor = cul_intrebare.BackColor;
                aux_descriere.BackColor = cul_descriere.BackColor;

                aux_rot.BorderColor = tasta1.BorderColor;
                aux_rot.OnHoverBorderColor = tasta1.OnHoverBorderColor;
                aux_rot.ButtonColor = tasta1.ButtonColor;
                aux_rot.OnHoverButtonColor = tasta1.OnHoverButtonColor;
                aux_rot.TextColor = tasta1.TextColor;
                aux_rot.OnHoverTextColor = tasta1.OnHoverTextColor;


                aspect_cronometru = 1;

                timp.Text = Convert.ToString(quick / 60) + "s";



                aspect_variante = aspect_cronometru = 1;

                if (V01.Visible==true||V01.Visible==true)
                {

                    V1.Visible = V2.Visible = V3.Visible = V4.Visible = true;
                    V01.Visible = V02.Visible = V03.Visible = V04.Visible = false;



                    radioButton1.Checked = true; radioButton2.Checked = false;






                }
                else if (which_one == 2)
                {
                    radioButton1.Checked = true; radioButton2.Checked = false;
                }


                format.Visible = false;
            }
            else
            {
                panel2.Visible = true;


                aux_cronometru = aspect_cronometru;
                aux_variante = aspect_variante;

                descriere.Text = "descriere";
                qlabel.Text = "Intrebare";



                cul_intrebare.BackColor = qlabel.ForeColor;
                cul_descriere.BackColor = descriere.ForeColor;
                cul_back.BackColor = panel1.BackColor;
                r = 255; g = 255; b = 255;

                aux_back.Visible = aux_descriere.Visible = aux_intrebare.Visible = aux_rot.Visible = false;



                aux_back.BackColor = cul_back.BackColor;
                aux_intrebare.BackColor = cul_intrebare.BackColor;
                aux_descriere.BackColor = cul_descriere.BackColor;

                aux_rot.BorderColor = tasta1.BorderColor;
                aux_rot.OnHoverBorderColor = tasta1.OnHoverBorderColor;
                aux_rot.ButtonColor = tasta1.ButtonColor;
                aux_rot.OnHoverButtonColor = tasta1.OnHoverButtonColor;
                aux_rot.TextColor = tasta1.TextColor;
                aux_rot.OnHoverTextColor = tasta1.OnHoverTextColor;





                rosu.Value = verde.Value = albastru.Value = 255;
                red.Text = green.Text = blue.Text = "255";


                mostra_rot.BorderColor = bordercolorbotton.BackColor = tasta7.BorderColor;

                mostra_rot.ButtonColor = buttoncolorbutton.BackColor = tasta7.ButtonColor;

                mostra_rot.TextColor = textcolorbutton.BackColor = tasta7.TextColor;

                mostra_rot.OnHoverBorderColor = hbordercolorbotton.BackColor = tasta7.OnHoverBorderColor;

                mostra_rot.OnHoverButtonColor = hbuttoncolorbutton.BackColor = tasta7.OnHoverButtonColor;


                mostra_rot.OnHoverTextColor = htextcolorbutton.BackColor = tasta7.OnHoverTextColor;


                cul_back.Visible = cul_descriere.Visible = cul_intrebare.Visible = false;



                aux_cronometru = aspect_cronometru;
                aux_variante = aspect_variante;


                if (type == 1)
                {
                    if (variante.BackColor != Color.FromArgb(0, 102, 204))
                    {
                        bck.ForeColor = intrebare.ForeColor = description.ForeColor = taste.ForeColor = variante.ForeColor = Cronometru.ForeColor = Color.FromArgb(0, 102, 204);
                        bck.BackColor = intrebare.BackColor = description.BackColor = taste.BackColor = variante.BackColor = Cronometru.BackColor = Color.White;

                        variante.ForeColor = Color.White; variante.BackColor = Color.FromArgb(0, 102, 204);


                        radioButton1.Visible = radioButton2.Visible = true;
                        label4.Visible = btr1.Visible = btr2.Visible = btr3.Visible = label6.Visible = bordercolorbotton.Visible = buttoncolorbutton.Visible = textcolorbutton.Visible = hbordercolorbotton.Visible = hbuttoncolorbutton.Visible = htextcolorbutton.Visible = mostra_rot.Visible = bordercolorbotton.Visible = buttoncolorbutton.Visible = textcolorbutton.Visible = hbordercolorbotton.Visible = hbuttoncolorbutton.Visible = htextcolorbutton.Visible = mostra.Visible = comboBox1.Visible = label5.Visible = label1.Visible = label2.Visible = rosu.Visible = verde.Visible = albastru.Visible = red.Visible = green.Visible = blue.Visible = false;


                        which_one = 1;
                        if (aspect_variante == 1) { V1.Visible = V2.Visible = V3.Visible = V4.Visible = true; V01.Visible = V02.Visible = V03.Visible = V04.Visible = false; }
                        else if (aspect_variante == 0) { V01.Visible = V02.Visible = V03.Visible = V04.Visible = true; V1.Visible = V2.Visible = V3.Visible = V4.Visible = false; }



                        if (aspect_variante == 1) { radioButton1.Checked = true; radioButton2.Checked = false; }
                        else if (aspect_variante == 0) { radioButton1.Checked = false; radioButton2.Checked = true; }

                    }




                    dsc.Text = "Schimbă modul in care sunt aranjate variantele de raspuns.";
                }
                else if (type == 2)
                {
                    if (taste.BackColor != Color.FromArgb(0, 102, 204))
                    {

                        bck.ForeColor = intrebare.ForeColor = description.ForeColor = taste.ForeColor = variante.ForeColor = Cronometru.ForeColor = Color.FromArgb(0, 102, 204);
                        bck.BackColor = intrebare.BackColor = description.BackColor = taste.BackColor = variante.BackColor = Cronometru.BackColor = Color.White;

                        taste.ForeColor = Color.White; taste.BackColor = Color.FromArgb(0, 102, 204);
                        radioButton1.Visible = radioButton2.Visible = false;
                        mostra.Visible = comboBox1.Visible = label5.Visible = label1.Visible = label2.Visible = rosu.Visible = verde.Visible = albastru.Visible = red.Visible = green.Visible = blue.Visible = false;
                        label4.Visible = label6.Visible = mostra_rot.Visible = btr1.Visible = btr2.Visible = btr3.Visible = bordercolorbotton.Visible = buttoncolorbutton.Visible = textcolorbutton.Visible = hbordercolorbotton.Visible = hbuttoncolorbutton.Visible = htextcolorbutton.Visible = true;
                        dsc.Text = "Schimbă culorile tastelor.";
                    }
                }
                else if (type == 3 || type == 4)
                {
                    if (bck.BackColor != Color.FromArgb(0, 102, 204))
                    {
                        if (first_back == true)
                        {

                            cul_back.BackColor = mostra.BackColor = panel1.BackColor;
                        }
                        else mostra.BackColor = cul_back.BackColor;

                        bck.ForeColor = intrebare.ForeColor = description.ForeColor = taste.ForeColor = variante.ForeColor = Cronometru.ForeColor = Color.FromArgb(0, 102, 204);
                        bck.BackColor = intrebare.BackColor = description.BackColor = taste.BackColor = variante.BackColor = Cronometru.BackColor = Color.White;

                        bck.ForeColor = Color.White; bck.BackColor = Color.FromArgb(0, 102, 204);
                        label4.Visible = btr1.Visible = btr2.Visible = btr3.Visible = label6.Visible = bordercolorbotton.Visible = buttoncolorbutton.Visible = textcolorbutton.Visible = hbordercolorbotton.Visible = hbuttoncolorbutton.Visible = htextcolorbutton.Visible = mostra_rot.Visible = radioButton1.Visible = radioButton2.Visible = false;
                        mostra.Visible = comboBox1.Visible = label5.Visible = label1.Visible = label2.Visible = rosu.Visible = verde.Visible = albastru.Visible = red.Visible = green.Visible = blue.Visible = true;


                        rosu.Value = albastru.Value = verde.Value = 255;
                        red.Text = green.Text = blue.Text = "255";
                        dsc.Text = "Schimbă culoarea backgroundului.";

                        pozitie = 1;
                    }
                }

            }


            /*
            if (aspect == 1)
            {

                V01.Visible = V02.Visible = V03.Visible = V04.Visible = true;
                V1.Visible = V2.Visible = V3.Visible = V4.Visible = false;
            }
            else if (aspect == 0)
            {

                V01.Visible = V02.Visible = V03.Visible = V04.Visible = false;
                V1.Visible = V2.Visible = V3.Visible = V4.Visible = true;
            }
            aspect = 1 - aspect;
            */
        }

        private void red_TextChanged(object sender, EventArgs e)
        {
            q = red.Text;
            int nr;

            if (IsDigitsOnly(q) == true)
            {

                if (q.Length > 0)
                {
                    nr = Convert.ToInt32(q);
                    if (nr <= 255)
                    {
                        r = nr;
                        mostra.BackColor = Color.FromArgb(r, g, b);
                        rosu.Value = r;

                        if (pozitie == 1)
                        {
                            first_back = false;
                            cul_back.BackColor = mostra.BackColor;
                            inserare1.BackColor = inserare2.BackColor = inserare_raspuns.BackColor= TEST.BackColor = imagine_ceas.BackColor = qlabel.BackColor=descriere.BackColor= Cronometru.BackColor = timp.BackColor = tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor = mostra.BackColor;


                        }
                        else if (pozitie == 2)
                        {
                            first_intrebare = false;
                            cul_intrebare.BackColor = mostra.BackColor;
                            qlabel.ForeColor = mostra.BackColor;

                        }
                        else if (pozitie == 3)
                        {
                            first_descriere = false;
                            cul_descriere.BackColor = mostra.BackColor;
                            descriere.ForeColor = mostra.BackColor;
                        }

                        Cronometru.ForeColor = Color.FromArgb(0, 102, 204); Cronometru.BackColor = Color.White;

                    }
                    else if (nr > 255)
                    {


                        nr = nr / 10;
                        q = Convert.ToString(nr);
                        red.Text = q;
                        MessageBox.Show("Pentru a obtinie o culoare folosind cod RGB, inserati un NUMAR POZITIV SI INTREG, cuprins intre 0 si 255!");
                    }

                }
            }
            else MessageBox.Show("Pentru a obtinie o culoare folosind cod RGB, inserati un NUMAR, cuprins intre 0 si 255!");

        }

        private void green_TextChanged(object sender, EventArgs e)
        {
            q = green.Text;
            int nr;

            if (IsDigitsOnly(q) == true)
            {

                if (q.Length > 0)
                {
                    nr = Convert.ToInt32(q);
                    if (nr <= 255)
                    {
                        g = nr;
                        mostra.BackColor = Color.FromArgb(r, g, b);
                        verde.Value = g;

                     

                        if (pozitie == 1)
                        {
                            first_back = false;
                            cul_back.BackColor = mostra.BackColor;
                            inserare1.BackColor = inserare2.BackColor = inserare_raspuns.BackColor = TEST.BackColor = imagine_ceas.BackColor = qlabel.BackColor = descriere.BackColor = Cronometru.BackColor = timp.BackColor =  tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor = mostra.BackColor;


                        }
                        else if (pozitie == 2)
                        {
                            first_intrebare = false;
                            cul_intrebare.BackColor = mostra.BackColor;
                            qlabel.ForeColor = mostra.BackColor;

                        }
                        else if (pozitie == 3)
                        {
                            first_descriere = false;
                            cul_descriere.BackColor = mostra.BackColor;
                            descriere.ForeColor = mostra.BackColor;
                        }


                        Cronometru.ForeColor = Color.FromArgb(0, 102, 204); Cronometru.BackColor = Color.White;

                    }
                    else if (nr > 255)
                    {


                        nr = nr / 10;
                        q = Convert.ToString(nr);
                        green.Text = q;
                        MessageBox.Show("Pentru a obtinie o culoare folosind cod RGB, inserati un NUMAR POZITIV SI INTREG, cuprins intre 0 si 255!");
                    }

                }
            }
            else MessageBox.Show("Pentru a obtinie o culoare folosind cod RGB, inserati un NUMAR, cuprins intre 0 si 255!");

        }

        private void blue_TextChanged(object sender, EventArgs e)
        {
            q = blue.Text;
            int nr;

            if (IsDigitsOnly(q) == true)
            {

                if (q.Length > 0)
                {
                    nr = Convert.ToInt32(q);
                    if (nr <= 255)
                    {
                        b = nr;
                        mostra.BackColor = Color.FromArgb(r, g, b);
                        albastru.Value = b;



                        if (pozitie == 1)
                        {
                            first_back = false;
                            cul_back.BackColor = mostra.BackColor;
                            inserare1.BackColor = inserare2.BackColor = inserare_raspuns.BackColor = TEST.BackColor = imagine_ceas.BackColor = qlabel.BackColor = descriere.BackColor = Cronometru.BackColor = timp.BackColor =  tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor = mostra.BackColor;

                        }
                        else if (pozitie == 2)
                        {
                            first_intrebare = false;
                            cul_intrebare.BackColor = mostra.BackColor;
                            qlabel.ForeColor = mostra.BackColor;

                        }
                        else if (pozitie == 3)
                        {
                            first_descriere = false;
                            cul_descriere.BackColor = mostra.BackColor;
                            descriere.ForeColor = mostra.BackColor;
                        }

                        Cronometru.ForeColor = Color.FromArgb(0, 102, 204); Cronometru.BackColor = Color.White;

                    }
                    else if (nr > 255)
                    {


                        nr = nr / 10;
                        q = Convert.ToString(nr);
                        blue.Text = q;
                        MessageBox.Show("Pentru a obtinie o culoare folosind cod RGB, inserati un NUMAR POZITIV SI INTREG, cuprins intre 0 si 255!");
                    }

                }
            }
            else MessageBox.Show("Pentru a obtinie o culoare folosind cod RGB, inserati un NUMAR, cuprins intre 0 si 255!");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
                mostra.BackColor = (Color)comboBox1.SelectedValue;


            if (pozitie == 1)
            {
                first_back = false;
                cul_back.BackColor = mostra.BackColor;
                inserare1.BackColor = inserare2.BackColor = inserare_raspuns.BackColor = inserare1.BackColor = inserare2.BackColor = inserare_raspuns.BackColor=TEST.BackColor = imagine_ceas.BackColor = qlabel.BackColor = descriere.BackColor = Cronometru.BackColor = timp.BackColor =  tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor = mostra.BackColor;

            }
            else if (pozitie == 2)
            {
                first_intrebare = false;
                cul_intrebare.BackColor = mostra.BackColor;
                qlabel.ForeColor = mostra.BackColor;

            }
            else if (pozitie == 3)
            {
                first_descriere = false;
                cul_descriere.BackColor = mostra.BackColor;
                descriere.ForeColor = mostra.BackColor;
            }
        }

        private void rosu_Scroll(object sender, EventArgs e)
        {
            q = rosu.Value.ToString();
            red.Text = q;
            r = Convert.ToInt32(q);


            mostra.BackColor = Color.FromArgb(r, g, b);
          

           

            if (pozitie == 1)
            {
                first_back = false;
                cul_back.BackColor = mostra.BackColor;
                inserare1.BackColor = inserare2.BackColor = inserare_raspuns.BackColor = TEST.BackColor =imagine_ceas.BackColor= qlabel.BackColor = descriere.BackColor = Cronometru.BackColor = timp.BackColor = tasta0.BackColor=tasta1.BackColor=tasta2.BackColor=tasta3.BackColor=tasta4.BackColor=tasta5.BackColor=tasta6.BackColor=tasta7.BackColor=tasta8.BackColor=tasta9.BackColor=tasta_sterge.BackColor=tasta0.ForeColor=tasta1.ForeColor=tasta2.ForeColor=tasta3.ForeColor=tasta4.ForeColor=tasta5.ForeColor=tasta6.ForeColor=tasta7.ForeColor=tasta8.ForeColor=tasta9.ForeColor=tasta_sterge.ForeColor= mostra.BackColor;

            }
            else if (pozitie == 2)
            {
                first_intrebare = false;
                cul_intrebare.BackColor = mostra.BackColor;
                qlabel.ForeColor = mostra.BackColor;

            }
            else if (pozitie == 3)
            {
                first_descriere = false;
                cul_descriere.BackColor = mostra.BackColor;
                descriere.ForeColor = mostra.BackColor;
            }



            Cronometru.ForeColor = Color.FromArgb(0, 102, 204); Cronometru.BackColor = Color.White;

        }

        private void verde_Scroll(object sender, EventArgs e)
        {
            q = verde.Value.ToString();
            green.Text = q;
            g = Convert.ToInt32(q);


            mostra.BackColor = Color.FromArgb(r, g, b);

            bool apasat;

            if (Cronometru.ForeColor == Color.White) apasat = true;
            else apasat = false;
            if (pozitie == 1)
            {
                first_back = false;
                cul_back.BackColor = mostra.BackColor;
                inserare1.BackColor = inserare2.BackColor = inserare_raspuns.BackColor = TEST.BackColor = imagine_ceas.BackColor = qlabel.BackColor = descriere.BackColor = Cronometru.BackColor = timp.BackColor =  tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor = mostra.BackColor;


            }
            else if (pozitie == 2)
            {
                first_intrebare = false;
                cul_intrebare.BackColor = mostra.BackColor;
                qlabel.ForeColor = mostra.BackColor;

            }
            else if (pozitie == 3)
            {
                first_descriere = false;
                cul_descriere.BackColor = mostra.BackColor;
                descriere.ForeColor = mostra.BackColor;
            }


            Cronometru.ForeColor = Color.FromArgb(0, 102, 204); Cronometru.BackColor = Color.White;

        }

        private void albastru_Scroll(object sender, EventArgs e)
        {
            q = albastru.Value.ToString();
            blue.Text = q;
            b = Convert.ToInt32(q);
            mostra.BackColor = Color.FromArgb(r, g, b);

          
            if (pozitie == 1)
            {
                first_back = false;
                cul_back.BackColor = mostra.BackColor;
                inserare1.BackColor = inserare2.BackColor = inserare_raspuns.BackColor = TEST.BackColor = imagine_ceas.BackColor = qlabel.BackColor = descriere.BackColor = Cronometru.BackColor = timp.BackColor =  tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor = mostra.BackColor;


            }
            else if (pozitie == 2)
            {
                first_intrebare = false;
                cul_intrebare.BackColor = mostra.BackColor;
                qlabel.ForeColor = mostra.BackColor;

            }
            else if (pozitie == 3)
            {
                first_descriere = false;
                cul_descriere.BackColor = mostra.BackColor;
                descriere.ForeColor = mostra.BackColor;
            }





            Cronometru.ForeColor = Color.FromArgb(0, 102, 204); Cronometru.BackColor = Color.White;

        }

        private void mostra_Click(object sender, EventArgs e)
        {
            ColorDialog colorpicker = new ColorDialog();
            if (colorpicker.ShowDialog() == DialogResult.OK) mostra.BackColor = colorpicker.Color;
            bool apasat;



            if (pozitie == 1)
            {
                first_back = false;
                cul_back.BackColor = mostra.BackColor;
                TEST.BackColor =inserare1.BackColor=inserare2.BackColor=inserare_raspuns.BackColor=imagine_ceas.BackColor= qlabel.BackColor = descriere.BackColor = Cronometru.BackColor=timp.BackColor= tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor = mostra.BackColor;
                

            }
            else if (pozitie == 2)
            {
                first_intrebare = false;
                cul_intrebare.BackColor = mostra.BackColor;
                qlabel.ForeColor = mostra.BackColor;

            }
            else if (pozitie == 3)
            {
                first_descriere = false;
                cul_descriere.BackColor = mostra.BackColor;
                descriere.ForeColor = mostra.BackColor;
            }





            Cronometru.ForeColor = Color.FromArgb(0, 102, 204); Cronometru.BackColor = Color.White;

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            inserare1.BackColor = inserare2.BackColor = inserare_raspuns.BackColor = cul_back.BackColor = TEST.BackColor = imagine_ceas.BackColor = descriere.BackColor=qlabel.BackColor=timp.InnerColor=timp.BackColor= aux_back.BackColor = Color.White;
            descriere.ForeColor = qlabel.ForeColor = Color.FromArgb(22, 18, 126);
            cul_intrebare.BackColor = cul_descriere.BackColor = Color.FromArgb(22, 18, 126);


            mostra_rot.BackColor = tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = Color.White;
            mostra_rot.FlatStyle = tasta0.FlatStyle = tasta1.FlatStyle = tasta2.FlatStyle = tasta3.FlatStyle = tasta4.FlatStyle = tasta5.FlatStyle = tasta6.FlatStyle = tasta7.FlatStyle = tasta8.FlatStyle = tasta9.FlatStyle = tasta_sterge.FlatStyle = FlatStyle.Flat;
            mostra_rot.ForeColor = tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor = Color.White;
            mostra_rot.ButtonColor = tasta0.ButtonColor = tasta1.ButtonColor = tasta2.ButtonColor = tasta3.ButtonColor = tasta4.ButtonColor = tasta5.ButtonColor = tasta6.ButtonColor = tasta7.ButtonColor = tasta8.ButtonColor = tasta9.ButtonColor = tasta_sterge.ButtonColor = Color.White;
            mostra_rot.TextColor = tasta0.TextColor = tasta1.TextColor = tasta2.TextColor = tasta3.TextColor = tasta4.TextColor = tasta5.TextColor = tasta6.TextColor = tasta6.TextColor = tasta7.TextColor = tasta8.TextColor = tasta9.TextColor = tasta_sterge.TextColor = Color.FromArgb(22, 18, 126);

            mostra_rot.BorderColor = tasta0.BorderColor = tasta1.BorderColor = tasta2.BorderColor = tasta3.BorderColor = tasta4.BorderColor = tasta5.BorderColor = tasta6.BorderColor = tasta7.BorderColor = tasta8.BorderColor = tasta9.BorderColor = tasta_sterge.BorderColor = Color.FromArgb(22, 18, 126);
            mostra_rot.OnHoverBorderColor = tasta0.OnHoverBorderColor = tasta1.OnHoverBorderColor = tasta2.OnHoverBorderColor = tasta3.OnHoverBorderColor = tasta4.OnHoverBorderColor = tasta5.OnHoverBorderColor = tasta6.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta8.OnHoverBorderColor = tasta9.OnHoverBorderColor = tasta_sterge.OnHoverBorderColor = Color.FromArgb(22, 18, 126);
            mostra_rot.OnHoverButtonColor = tasta0.OnHoverButtonColor = tasta1.OnHoverButtonColor = tasta2.OnHoverButtonColor = tasta3.OnHoverButtonColor = tasta4.OnHoverButtonColor = tasta5.OnHoverButtonColor = tasta6.OnHoverButtonColor = tasta7.OnHoverButtonColor = tasta8.OnHoverButtonColor = tasta9.OnHoverButtonColor = tasta_sterge.OnHoverButtonColor = Color.FromArgb(22, 18, 126);
            mostra_rot.OnHoverTextColor = tasta0.OnHoverTextColor = tasta1.OnHoverTextColor = tasta2.OnHoverTextColor = tasta3.OnHoverTextColor = tasta4.OnHoverTextColor = tasta5.OnHoverTextColor = tasta6.OnHoverTextColor = tasta7.OnHoverTextColor = tasta8.OnHoverTextColor = tasta9.OnHoverTextColor = tasta_sterge.OnHoverTextColor = Color.White;
            tasta_sterge.BackColor = Color.White;

            bordercolorbotton.BackColor = mostra_rot.BorderColor; hbordercolorbotton.BackColor = mostra_rot.OnHoverBorderColor;

            buttoncolorbutton.BackColor = mostra_rot.ButtonColor; hbuttoncolorbutton.BackColor = mostra_rot.OnHoverButtonColor;
            textcolorbutton.BackColor = mostra_rot.TextColor; htextcolorbutton.BackColor = mostra_rot.OnHoverTextColor;

            

            first_back = first_descriere = first_intrebare = true;


            if (pozitie == 1) mostra.BackColor = Color.White;
            else mostra.BackColor = Color.FromArgb(22, 18, 126);

            aux_back.BackColor = cul_back.BackColor;
            aux_intrebare.BackColor = cul_intrebare.BackColor;
            aux_descriere.BackColor = cul_descriere.BackColor;

            aux_rot.BorderColor = tasta1.BorderColor;
            aux_rot.OnHoverBorderColor = tasta1.OnHoverBorderColor;
            aux_rot.ButtonColor = tasta1.ButtonColor;
            aux_rot.OnHoverButtonColor = tasta1.OnHoverButtonColor;
            aux_rot.TextColor = tasta1.TextColor;
            aux_rot.OnHoverTextColor = tasta1.OnHoverTextColor;


            aspect_cronometru = 1;

            timp.Text = Convert.ToString(quick / 60) + "s";



            aspect_variante =aspect_cronometru= 1;

            if (which_one == 1)
            {
               
                    V1.Visible = V2.Visible = V3.Visible = V4.Visible = true;
                    V01.Visible = V02.Visible = V03.Visible = V04.Visible = false;
                

               
                    radioButton1.Checked = true; radioButton2.Checked = false;
                

                
            
              

            }else if (which_one == 2)
            {
                radioButton1.Checked = true; radioButton2.Checked = false;
            }

        }
        private void bck_Click(object sender, EventArgs e)
        {
          
            if (bck.BackColor != Color.FromArgb(0, 102, 204))
            {
                if (first_back == true)
                {

                    cul_back.BackColor = mostra.BackColor =TEST.BackColor;
                }
                else mostra.BackColor = cul_back.BackColor;

                if (descriere.Text == "") descriere.Text = "descriere";
                qlabel.Text = "Intrebare";


                bck.ForeColor = intrebare.ForeColor = description.ForeColor = taste.ForeColor = variante.ForeColor =Cronometru.ForeColor= Color.FromArgb(0, 102, 204);
                bck.BackColor = intrebare.BackColor = description.BackColor = taste.BackColor = variante.BackColor =Cronometru.BackColor= Color.White;


                 bck.ForeColor = Color.White; bck.BackColor = Color.FromArgb(0, 102, 204);
                label4.Visible = btr1.Visible = btr2.Visible = btr3.Visible = label6.Visible = bordercolorbotton.Visible = buttoncolorbutton.Visible = textcolorbutton.Visible = hbordercolorbotton.Visible = hbuttoncolorbutton.Visible = htextcolorbutton.Visible = mostra_rot.Visible = radioButton1.Visible = radioButton2.Visible = false;
                mostra.Visible = comboBox1.Visible = label5.Visible = label1.Visible = label2.Visible = rosu.Visible = verde.Visible = albastru.Visible = red.Visible = green.Visible = blue.Visible = true;


                rosu.Value = albastru.Value = verde.Value = 255;
                red.Text = green.Text = blue.Text = "255";
                dsc.Text = "Schimbă culoarea backgroundului.";

                pozitie = 1;
            }
        }
        private void intrebare_Click(object sender, EventArgs e)
        {
            if (intrebare.BackColor != Color.FromArgb(0, 102, 204))
            {
                if (first_intrebare == true)
                {

                    cul_intrebare.BackColor = mostra.BackColor = qlabel.ForeColor;
                }
                else mostra.BackColor = cul_intrebare.BackColor;

                bck.ForeColor = intrebare.ForeColor = description.ForeColor = taste.ForeColor = variante.ForeColor =Cronometru.ForeColor= Color.FromArgb(0, 102, 204);
                bck.BackColor = intrebare.BackColor = description.BackColor = taste.BackColor = variante.BackColor =Cronometru.BackColor= Color.White;

                intrebare.ForeColor = Color.White; intrebare.BackColor = Color.FromArgb(0, 102, 204);

                label4.Visible = btr1.Visible = btr2.Visible = btr3.Visible = label6.Visible = bordercolorbotton.Visible = buttoncolorbutton.Visible = textcolorbutton.Visible = hbordercolorbotton.Visible = hbuttoncolorbutton.Visible = htextcolorbutton.Visible = mostra_rot.Visible = radioButton1.Visible = radioButton2.Visible = false;
                mostra.Visible = comboBox1.Visible = label5.Visible = label1.Visible = label2.Visible = rosu.Visible = verde.Visible = albastru.Visible = red.Visible = green.Visible = blue.Visible = true;
                rosu.Value = albastru.Value = verde.Value = 255;
                red.Text = green.Text = blue.Text = "255";
                dsc.Text = "Schimbă culoarea intrebarii.";
                pozitie = 2;

                if (descriere.Text == "") descriere.Text = "descriere";
                qlabel.Text = "Intrebare";
            }
        }

        private void description_Click(object sender, EventArgs e)
        {
             if (description.BackColor != Color.FromArgb(0, 102, 204))
            {
                if (first_descriere == true)
                {

                    cul_descriere.BackColor = mostra.BackColor = descriere.ForeColor;
                }
                else mostra.BackColor = cul_descriere.BackColor;


                bck.ForeColor = intrebare.ForeColor = description.ForeColor = taste.ForeColor = variante.ForeColor =Cronometru.ForeColor= Color.FromArgb(0, 102, 204);
                bck.BackColor = intrebare.BackColor = description.BackColor = taste.BackColor = variante.BackColor =Cronometru.BackColor= Color.White;

                description.ForeColor = Color.White; description.BackColor = Color.FromArgb(0, 102, 204);
                label4.Visible = btr1.Visible = btr2.Visible = btr3.Visible = label6.Visible = bordercolorbotton.Visible = buttoncolorbutton.Visible = textcolorbutton.Visible = hbordercolorbotton.Visible = hbuttoncolorbutton.Visible = htextcolorbutton.Visible = mostra_rot.Visible = radioButton1.Visible = radioButton2.Visible = false;
                mostra.Visible = comboBox1.Visible = label5.Visible = label1.Visible = label2.Visible = rosu.Visible = verde.Visible = albastru.Visible = red.Visible = green.Visible = blue.Visible = true;
                rosu.Value = albastru.Value = verde.Value = 255;
                red.Text = green.Text = blue.Text = "255";
                dsc.Text = "Schimbă culoarea descrierii.";

                pozitie = 3;

                if (descriere.Text == "") descriere.Text = "descriere";
                qlabel.Text = "Intrebare";
            }
        }

        private void taste_Click(object sender, EventArgs e)
        {
            if (taste.BackColor != Color.FromArgb(0, 102, 204))
            {

                bck.ForeColor = intrebare.ForeColor = description.ForeColor = taste.ForeColor = variante.ForeColor =Cronometru.ForeColor =Color.FromArgb(0, 102, 204);
                bck.BackColor = intrebare.BackColor = description.BackColor = taste.BackColor = variante.BackColor =Cronometru.BackColor= Color.White;

                taste.ForeColor = Color.White; taste.BackColor = Color.FromArgb(0, 102, 204);
                radioButton1.Visible = radioButton2.Visible = false;
                mostra.Visible = comboBox1.Visible = label5.Visible = label1.Visible = label2.Visible = rosu.Visible = verde.Visible = albastru.Visible = red.Visible = green.Visible = blue.Visible = false;
                label4.Visible = label6.Visible = mostra_rot.Visible = btr1.Visible = btr2.Visible = btr3.Visible = bordercolorbotton.Visible = buttoncolorbutton.Visible = textcolorbutton.Visible = hbordercolorbotton.Visible = hbuttoncolorbutton.Visible = htextcolorbutton.Visible = true;
                dsc.Text = "Schimbă culorile tastelor.";

                underline1.Visible = underline1.Visible = underline2.Visible = false;
                if (descriere.Text == "") descriere.Text = "descriere";
                qlabel.Text = "Intrebare";
                V01.Visible = V1.Visible = V02.Visible = V2.Visible = V03.Visible = V3.Visible = V04.Visible = V4.Visible = rasp_corect.Visible = inserare1.Visible = inserare2.Visible = false;
 
                an.Visible=tasta0.Visible = tasta1.Visible = tasta2.Visible = tasta3.Visible = tasta4.Visible = tasta5.Visible = tasta6.Visible = tasta7.Visible = tasta8.Visible = tasta9.Visible = tasta_sterge.Visible = true;

                which_one = 0;
            }

        }

        private void variante_Click(object sender, EventArgs e)
        {
            if (variante.BackColor != Color.FromArgb(0, 102, 204))
            {
                bck.ForeColor = intrebare.ForeColor = description.ForeColor = taste.ForeColor = variante.ForeColor = Cronometru.ForeColor = Color.FromArgb(0, 102, 204);
                bck.BackColor = intrebare.BackColor = description.BackColor = taste.BackColor = variante.BackColor = Cronometru.BackColor = Color.White;

                variante.ForeColor = Color.White; variante.BackColor = Color.FromArgb(0, 102, 204);

                radioButton1.Text = "Câte două variante de răspuns pe linie";
                radioButton2.Text = "Câte o variantă de răspuns pe linie";

                
                radioButton1.Visible = radioButton2.Visible = true;
                label4.Visible = btr1.Visible = btr2.Visible = btr3.Visible = label6.Visible = bordercolorbotton.Visible = buttoncolorbutton.Visible = textcolorbutton.Visible = hbordercolorbotton.Visible = hbuttoncolorbutton.Visible = htextcolorbutton.Visible = mostra_rot.Visible = bordercolorbotton.Visible = buttoncolorbutton.Visible = textcolorbutton.Visible = hbordercolorbotton.Visible = hbuttoncolorbutton.Visible = htextcolorbutton.Visible = mostra.Visible = comboBox1.Visible = label5.Visible = label1.Visible = label2.Visible = rosu.Visible = verde.Visible = albastru.Visible = red.Visible = green.Visible = blue.Visible = false;

                underline1.Visible = underline1.Visible = underline2.Visible = false;
                descriere.Text = "descriere";
                qlabel.Text = "Intrebare";

                rasp_corect.Visible = inserare1.Visible = inserare2.Visible = an.Visible = tasta0.Visible = tasta1.Visible = tasta2.Visible = tasta3.Visible = tasta4.Visible = tasta5.Visible = tasta6.Visible = tasta7.Visible = tasta8.Visible = tasta9.Visible = tasta_sterge.Visible = false;

                


                which_one = 1;
                if (aspect_variante == 1) { V1.Visible = V2.Visible = V3.Visible = V4.Visible = true; V01.Visible = V02.Visible = V03.Visible = V04.Visible = false; }
                else if (aspect_variante == 0) { V01.Visible = V02.Visible = V03.Visible = V04.Visible = true; V1.Visible = V2.Visible = V3.Visible = V4.Visible = false; }



                if (aspect_variante == 1) { radioButton1.Checked = true; radioButton2.Checked = false; }
                else if(aspect_variante == 0) { radioButton1.Checked = false; radioButton2.Checked = true; }

            }




            dsc.Text = "Schimbă modul in care sunt aranjate variantele de raspuns.";
        }

        private void bordercolorbotton_Click(object sender, EventArgs e)
        {
            ColorDialog colorpicker = new ColorDialog();
            if (colorpicker.ShowDialog() == DialogResult.OK) bordercolorbotton.BackColor = colorpicker.Color;
            mostra_rot.BorderColor = bordercolorbotton.BackColor;

            tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = mostra_rot.BackColor;
            tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor = mostra_rot.ForeColor;
            tasta0.ButtonColor = tasta1.ButtonColor = tasta2.ButtonColor = tasta3.ButtonColor = tasta4.ButtonColor = tasta5.ButtonColor = tasta6.ButtonColor = tasta7.ButtonColor = tasta8.ButtonColor = tasta9.ButtonColor = tasta_sterge.ButtonColor = mostra_rot.ButtonColor;
            tasta0.TextColor = tasta1.TextColor = tasta2.TextColor = tasta3.TextColor = tasta4.TextColor = tasta5.TextColor = tasta6.TextColor = tasta6.TextColor = tasta7.TextColor = tasta8.TextColor = tasta9.TextColor = tasta_sterge.TextColor = mostra_rot.TextColor;



            tasta0.BorderColor = tasta1.BorderColor = tasta2.BorderColor = tasta3.BorderColor = tasta4.BorderColor = tasta5.BorderColor = tasta6.BorderColor = tasta7.BorderColor = tasta8.BorderColor = tasta9.BorderColor = tasta_sterge.BorderColor = mostra_rot.BorderColor;
            tasta0.OnHoverBorderColor = tasta1.OnHoverBorderColor = tasta2.OnHoverBorderColor = tasta3.OnHoverBorderColor = tasta4.OnHoverBorderColor = tasta5.OnHoverBorderColor = tasta6.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta8.OnHoverBorderColor = tasta9.OnHoverBorderColor = tasta_sterge.OnHoverBorderColor = mostra_rot.OnHoverBorderColor;
            tasta0.OnHoverButtonColor = tasta1.OnHoverButtonColor = tasta2.OnHoverButtonColor = tasta3.OnHoverButtonColor = tasta4.OnHoverButtonColor = tasta5.OnHoverButtonColor = tasta6.OnHoverButtonColor = tasta7.OnHoverButtonColor = tasta8.OnHoverButtonColor = tasta9.OnHoverButtonColor = tasta_sterge.OnHoverButtonColor = mostra_rot.OnHoverButtonColor;
            tasta0.OnHoverTextColor = tasta1.OnHoverTextColor = tasta2.OnHoverTextColor = tasta3.OnHoverTextColor = tasta4.OnHoverTextColor = tasta5.OnHoverTextColor = tasta6.OnHoverTextColor = tasta7.OnHoverTextColor = tasta8.OnHoverTextColor = tasta9.OnHoverTextColor = tasta_sterge.OnHoverTextColor = mostra_rot.OnHoverTextColor;


            tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor = cul_back.BackColor;
            tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = cul_back.BackColor;

        }

        private void hbordercolorbotton_Click(object sender, EventArgs e)
        {
            ColorDialog colorpicker = new ColorDialog();
            if (colorpicker.ShowDialog() == DialogResult.OK) hbordercolorbotton.BackColor = colorpicker.Color;
            mostra_rot.OnHoverBorderColor = hbordercolorbotton.BackColor;
            tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = mostra_rot.BackColor;
            tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor = mostra_rot.ForeColor;
            tasta0.ButtonColor = tasta1.ButtonColor = tasta2.ButtonColor = tasta3.ButtonColor = tasta4.ButtonColor = tasta5.ButtonColor = tasta6.ButtonColor = tasta7.ButtonColor = tasta8.ButtonColor = tasta9.ButtonColor = tasta_sterge.ButtonColor = mostra_rot.ButtonColor;
            tasta0.TextColor = tasta1.TextColor = tasta2.TextColor = tasta3.TextColor = tasta4.TextColor = tasta5.TextColor = tasta6.TextColor = tasta6.TextColor = tasta7.TextColor = tasta8.TextColor = tasta9.TextColor = tasta_sterge.TextColor = mostra_rot.TextColor;



            tasta0.BorderColor = tasta1.BorderColor = tasta2.BorderColor = tasta3.BorderColor = tasta4.BorderColor = tasta5.BorderColor = tasta6.BorderColor = tasta7.BorderColor = tasta8.BorderColor = tasta9.BorderColor = tasta_sterge.BorderColor = mostra_rot.BorderColor;
            tasta0.OnHoverBorderColor = tasta1.OnHoverBorderColor = tasta2.OnHoverBorderColor = tasta3.OnHoverBorderColor = tasta4.OnHoverBorderColor = tasta5.OnHoverBorderColor = tasta6.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta8.OnHoverBorderColor = tasta9.OnHoverBorderColor = tasta_sterge.OnHoverBorderColor = mostra_rot.OnHoverBorderColor;
            tasta0.OnHoverButtonColor = tasta1.OnHoverButtonColor = tasta2.OnHoverButtonColor = tasta3.OnHoverButtonColor = tasta4.OnHoverButtonColor = tasta5.OnHoverButtonColor = tasta6.OnHoverButtonColor = tasta7.OnHoverButtonColor = tasta8.OnHoverButtonColor = tasta9.OnHoverButtonColor = tasta_sterge.OnHoverButtonColor = mostra_rot.OnHoverButtonColor;
            tasta0.OnHoverTextColor = tasta1.OnHoverTextColor = tasta2.OnHoverTextColor = tasta3.OnHoverTextColor = tasta4.OnHoverTextColor = tasta5.OnHoverTextColor = tasta6.OnHoverTextColor = tasta7.OnHoverTextColor = tasta8.OnHoverTextColor = tasta9.OnHoverTextColor = tasta_sterge.OnHoverTextColor = mostra_rot.OnHoverTextColor;



            tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor = cul_back.BackColor;
            tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = cul_back.BackColor;

        }

        private void buttoncolorbutton_Click(object sender, EventArgs e)
        {
            ColorDialog colorpicker = new ColorDialog();
            if (colorpicker.ShowDialog() == DialogResult.OK) buttoncolorbutton.BackColor = colorpicker.Color;
            mostra_rot.ButtonColor = buttoncolorbutton.BackColor;

            tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = mostra_rot.BackColor;
            tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor = mostra_rot.ForeColor;
            tasta0.ButtonColor = tasta1.ButtonColor = tasta2.ButtonColor = tasta3.ButtonColor = tasta4.ButtonColor = tasta5.ButtonColor = tasta6.ButtonColor = tasta7.ButtonColor = tasta8.ButtonColor = tasta9.ButtonColor = tasta_sterge.ButtonColor = mostra_rot.ButtonColor;
            tasta0.TextColor = tasta1.TextColor = tasta2.TextColor = tasta3.TextColor = tasta4.TextColor = tasta5.TextColor = tasta6.TextColor = tasta6.TextColor = tasta7.TextColor = tasta8.TextColor = tasta9.TextColor = tasta_sterge.TextColor = mostra_rot.TextColor;



            tasta0.BorderColor = tasta1.BorderColor = tasta2.BorderColor = tasta3.BorderColor = tasta4.BorderColor = tasta5.BorderColor = tasta6.BorderColor = tasta7.BorderColor = tasta8.BorderColor = tasta9.BorderColor = tasta_sterge.BorderColor = mostra_rot.BorderColor;
            tasta0.OnHoverBorderColor = tasta1.OnHoverBorderColor = tasta2.OnHoverBorderColor = tasta3.OnHoverBorderColor = tasta4.OnHoverBorderColor = tasta5.OnHoverBorderColor = tasta6.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta8.OnHoverBorderColor = tasta9.OnHoverBorderColor = tasta_sterge.OnHoverBorderColor = mostra_rot.OnHoverBorderColor;
            tasta0.OnHoverButtonColor = tasta1.OnHoverButtonColor = tasta2.OnHoverButtonColor = tasta3.OnHoverButtonColor = tasta4.OnHoverButtonColor = tasta5.OnHoverButtonColor = tasta6.OnHoverButtonColor = tasta7.OnHoverButtonColor = tasta8.OnHoverButtonColor = tasta9.OnHoverButtonColor = tasta_sterge.OnHoverButtonColor = mostra_rot.OnHoverButtonColor;
            tasta0.OnHoverTextColor = tasta1.OnHoverTextColor = tasta2.OnHoverTextColor = tasta3.OnHoverTextColor = tasta4.OnHoverTextColor = tasta5.OnHoverTextColor = tasta6.OnHoverTextColor = tasta7.OnHoverTextColor = tasta8.OnHoverTextColor = tasta9.OnHoverTextColor = tasta_sterge.OnHoverTextColor = mostra_rot.OnHoverTextColor;


            tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor = cul_back.BackColor;
            tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = cul_back.BackColor;

        }

        private void hbuttoncolorbutton_Click(object sender, EventArgs e)
        {
            ColorDialog colorpicker = new ColorDialog();
            if (colorpicker.ShowDialog() == DialogResult.OK) hbuttoncolorbutton.BackColor = colorpicker.Color;
            mostra_rot.OnHoverButtonColor = hbuttoncolorbutton.BackColor;

            tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = mostra_rot.BackColor;
            tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor = mostra_rot.ForeColor;
            tasta0.ButtonColor = tasta1.ButtonColor = tasta2.ButtonColor = tasta3.ButtonColor = tasta4.ButtonColor = tasta5.ButtonColor = tasta6.ButtonColor = tasta7.ButtonColor = tasta8.ButtonColor = tasta9.ButtonColor = tasta_sterge.ButtonColor = mostra_rot.ButtonColor;
            tasta0.TextColor = tasta1.TextColor = tasta2.TextColor = tasta3.TextColor = tasta4.TextColor = tasta5.TextColor = tasta6.TextColor = tasta6.TextColor = tasta7.TextColor = tasta8.TextColor = tasta9.TextColor = tasta_sterge.TextColor = mostra_rot.TextColor;



            tasta0.BorderColor = tasta1.BorderColor = tasta2.BorderColor = tasta3.BorderColor = tasta4.BorderColor = tasta5.BorderColor = tasta6.BorderColor = tasta7.BorderColor = tasta8.BorderColor = tasta9.BorderColor = tasta_sterge.BorderColor = mostra_rot.BorderColor;
            tasta0.OnHoverBorderColor = tasta1.OnHoverBorderColor = tasta2.OnHoverBorderColor = tasta3.OnHoverBorderColor = tasta4.OnHoverBorderColor = tasta5.OnHoverBorderColor = tasta6.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta8.OnHoverBorderColor = tasta9.OnHoverBorderColor = tasta_sterge.OnHoverBorderColor = mostra_rot.OnHoverBorderColor;
            tasta0.OnHoverButtonColor = tasta1.OnHoverButtonColor = tasta2.OnHoverButtonColor = tasta3.OnHoverButtonColor = tasta4.OnHoverButtonColor = tasta5.OnHoverButtonColor = tasta6.OnHoverButtonColor = tasta7.OnHoverButtonColor = tasta8.OnHoverButtonColor = tasta9.OnHoverButtonColor = tasta_sterge.OnHoverButtonColor = mostra_rot.OnHoverButtonColor;
            tasta0.OnHoverTextColor = tasta1.OnHoverTextColor = tasta2.OnHoverTextColor = tasta3.OnHoverTextColor = tasta4.OnHoverTextColor = tasta5.OnHoverTextColor = tasta6.OnHoverTextColor = tasta7.OnHoverTextColor = tasta8.OnHoverTextColor = tasta9.OnHoverTextColor = tasta_sterge.OnHoverTextColor = mostra_rot.OnHoverTextColor;



            tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor = cul_back.BackColor;
            tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = cul_back.BackColor;

        }

        private void textcolorbutton_Click(object sender, EventArgs e)
        {
            ColorDialog colorpicker = new ColorDialog();
            if (colorpicker.ShowDialog() == DialogResult.OK) textcolorbutton.BackColor = colorpicker.Color;
            mostra_rot.TextColor = textcolorbutton.BackColor;

            tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = mostra_rot.BackColor;
            tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor = mostra_rot.ForeColor;
            tasta0.ButtonColor = tasta1.ButtonColor = tasta2.ButtonColor = tasta3.ButtonColor = tasta4.ButtonColor = tasta5.ButtonColor = tasta6.ButtonColor = tasta7.ButtonColor = tasta8.ButtonColor = tasta9.ButtonColor = tasta_sterge.ButtonColor = mostra_rot.ButtonColor;
            tasta0.TextColor = tasta1.TextColor = tasta2.TextColor = tasta3.TextColor = tasta4.TextColor = tasta5.TextColor = tasta6.TextColor = tasta6.TextColor = tasta7.TextColor = tasta8.TextColor = tasta9.TextColor = tasta_sterge.TextColor = mostra_rot.TextColor;



            tasta0.BorderColor = tasta1.BorderColor = tasta2.BorderColor = tasta3.BorderColor = tasta4.BorderColor = tasta5.BorderColor = tasta6.BorderColor = tasta7.BorderColor = tasta8.BorderColor = tasta9.BorderColor = tasta_sterge.BorderColor = mostra_rot.BorderColor;
            tasta0.OnHoverBorderColor = tasta1.OnHoverBorderColor = tasta2.OnHoverBorderColor = tasta3.OnHoverBorderColor = tasta4.OnHoverBorderColor = tasta5.OnHoverBorderColor = tasta6.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta8.OnHoverBorderColor = tasta9.OnHoverBorderColor = tasta_sterge.OnHoverBorderColor = mostra_rot.OnHoverBorderColor;
            tasta0.OnHoverButtonColor = tasta1.OnHoverButtonColor = tasta2.OnHoverButtonColor = tasta3.OnHoverButtonColor = tasta4.OnHoverButtonColor = tasta5.OnHoverButtonColor = tasta6.OnHoverButtonColor = tasta7.OnHoverButtonColor = tasta8.OnHoverButtonColor = tasta9.OnHoverButtonColor = tasta_sterge.OnHoverButtonColor = mostra_rot.OnHoverButtonColor;
            tasta0.OnHoverTextColor = tasta1.OnHoverTextColor = tasta2.OnHoverTextColor = tasta3.OnHoverTextColor = tasta4.OnHoverTextColor = tasta5.OnHoverTextColor = tasta6.OnHoverTextColor = tasta7.OnHoverTextColor = tasta8.OnHoverTextColor = tasta9.OnHoverTextColor = tasta_sterge.OnHoverTextColor = mostra_rot.OnHoverTextColor;



            tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor = cul_back.BackColor;
            tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = cul_back.BackColor;

        }

        private void htextcolorbutton_Click(object sender, EventArgs e)
        {
            ColorDialog colorpicker = new ColorDialog();
            if (colorpicker.ShowDialog() == DialogResult.OK) htextcolorbutton.BackColor = colorpicker.Color;
            mostra_rot.OnHoverTextColor = htextcolorbutton.BackColor;

            tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = mostra_rot.BackColor;
            tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor = mostra_rot.ForeColor;
            tasta0.ButtonColor = tasta1.ButtonColor = tasta2.ButtonColor = tasta3.ButtonColor = tasta4.ButtonColor = tasta5.ButtonColor = tasta6.ButtonColor = tasta7.ButtonColor = tasta8.ButtonColor = tasta9.ButtonColor = tasta_sterge.ButtonColor = mostra_rot.ButtonColor;
            tasta0.TextColor = tasta1.TextColor = tasta2.TextColor = tasta3.TextColor = tasta4.TextColor = tasta5.TextColor = tasta6.TextColor = tasta6.TextColor = tasta7.TextColor = tasta8.TextColor = tasta9.TextColor = tasta_sterge.TextColor = mostra_rot.TextColor;



            tasta0.BorderColor = tasta1.BorderColor = tasta2.BorderColor = tasta3.BorderColor = tasta4.BorderColor = tasta5.BorderColor = tasta6.BorderColor = tasta7.BorderColor = tasta8.BorderColor = tasta9.BorderColor = tasta_sterge.BorderColor = mostra_rot.BorderColor;
            tasta0.OnHoverBorderColor = tasta1.OnHoverBorderColor = tasta2.OnHoverBorderColor = tasta3.OnHoverBorderColor = tasta4.OnHoverBorderColor = tasta5.OnHoverBorderColor = tasta6.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta8.OnHoverBorderColor = tasta9.OnHoverBorderColor = tasta_sterge.OnHoverBorderColor = mostra_rot.OnHoverBorderColor;
            tasta0.OnHoverButtonColor = tasta1.OnHoverButtonColor = tasta2.OnHoverButtonColor = tasta3.OnHoverButtonColor = tasta4.OnHoverButtonColor = tasta5.OnHoverButtonColor = tasta6.OnHoverButtonColor = tasta7.OnHoverButtonColor = tasta8.OnHoverButtonColor = tasta9.OnHoverButtonColor = tasta_sterge.OnHoverButtonColor = mostra_rot.OnHoverButtonColor;
            tasta0.OnHoverTextColor = tasta1.OnHoverTextColor = tasta2.OnHoverTextColor = tasta3.OnHoverTextColor = tasta4.OnHoverTextColor = tasta5.OnHoverTextColor = tasta6.OnHoverTextColor = tasta7.OnHoverTextColor = tasta8.OnHoverTextColor = tasta9.OnHoverTextColor = tasta_sterge.OnHoverTextColor = mostra_rot.OnHoverTextColor;



            tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor = cul_back.BackColor;
            tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = cul_back.BackColor;

        }

        private void Cancel_Click(object sender, EventArgs e)
        {   


            first_back = first_descriere = first_intrebare = true;

            cul_back.BackColor = aux_back.BackColor;
            cul_intrebare.BackColor = aux_intrebare.BackColor;
            cul_descriere.BackColor = aux_descriere.BackColor;

            mostra_rot.BorderColor = aux_rot.BorderColor;
            mostra_rot.OnHoverBorderColor = aux_rot.OnHoverBorderColor;
            mostra_rot.ButtonColor = aux_rot.ButtonColor;
            mostra_rot.OnHoverButtonColor = aux_rot.OnHoverButtonColor;
            mostra_rot.TextColor = aux_rot.TextColor;
            mostra_rot.OnHoverTextColor = aux_rot.OnHoverTextColor;

            bordercolorbotton.BackColor = mostra_rot.BorderColor;
            hbordercolorbotton.BackColor = mostra_rot.OnHoverBorderColor;

            buttoncolorbutton.BackColor = mostra_rot.ButtonColor;
            hbuttoncolorbutton.BackColor = mostra_rot.OnHoverButtonColor;

            textcolorbutton.BackColor = mostra_rot.TextColor;
            htextcolorbutton.BackColor = mostra_rot.OnHoverTextColor;

            tasta0.FlatStyle = FlatStyle.Flat;


            inserare1.BackColor = inserare2.BackColor = inserare_raspuns.BackColor=TEST.BackColor = imagine_ceas.BackColor = descriere.BackColor=timp.BackColor =qlabel.BackColor=  cul_back.BackColor;


            tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor =cul_back.BackColor;
            tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = cul_back.BackColor;

            tasta0.ButtonColor = tasta1.ButtonColor = tasta2.ButtonColor = tasta3.ButtonColor = tasta4.ButtonColor = tasta5.ButtonColor = tasta6.ButtonColor = tasta7.ButtonColor = tasta8.ButtonColor = tasta9.ButtonColor = tasta_sterge.ButtonColor = mostra_rot.ButtonColor;

            tasta0.BorderColor = tasta1.BorderColor = tasta2.BorderColor = tasta3.BorderColor = tasta4.BorderColor = tasta5.BorderColor = tasta6.BorderColor = tasta7.BorderColor = tasta8.BorderColor = tasta9.BorderColor = tasta_sterge.BorderColor = mostra_rot.BorderColor;
            tasta0.OnHoverBorderColor = tasta1.OnHoverBorderColor = tasta2.OnHoverBorderColor = tasta3.OnHoverBorderColor = tasta4.OnHoverBorderColor = tasta5.OnHoverBorderColor = tasta6.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta8.OnHoverBorderColor = tasta9.OnHoverBorderColor = tasta_sterge.OnHoverBorderColor = mostra_rot.OnHoverBorderColor;
            tasta0.OnHoverButtonColor = tasta1.OnHoverButtonColor = tasta2.OnHoverButtonColor = tasta3.OnHoverButtonColor = tasta4.OnHoverButtonColor = tasta5.OnHoverButtonColor = tasta6.OnHoverButtonColor = tasta7.OnHoverButtonColor = tasta8.OnHoverButtonColor = tasta9.OnHoverButtonColor = tasta_sterge.OnHoverButtonColor = mostra_rot.OnHoverButtonColor;
            tasta0.TextColor = tasta1.TextColor = tasta2.TextColor = tasta3.TextColor = tasta4.TextColor = tasta5.TextColor = tasta6.TextColor = tasta6.TextColor = tasta7.TextColor = tasta8.TextColor = tasta9.TextColor = tasta_sterge.TextColor = mostra_rot.TextColor;

            tasta0.OnHoverTextColor = tasta1.OnHoverTextColor = tasta2.OnHoverTextColor = tasta3.OnHoverTextColor = tasta4.OnHoverTextColor = tasta5.OnHoverTextColor = tasta6.OnHoverTextColor = tasta7.OnHoverTextColor = tasta8.OnHoverTextColor = tasta9.OnHoverTextColor = tasta_sterge.OnHoverTextColor = mostra_rot.OnHoverTextColor;


            if (pozitie == 1) mostra.BackColor = cul_back.BackColor;
            else if (pozitie == 2) mostra.BackColor = intrebare.BackColor;
            else if (pozitie == 3) mostra.BackColor = description.BackColor;


            aspect_cronometru = aux_cronometru;

            if (aspect_cronometru == 0) timp.Text = (quick / 60) + ":" + ((quick % 60) >= 10 ? (quick % 60).ToString() : "0" + (quick % 60));
            else if (aspect_cronometru == 1) timp.Text = Convert.ToString(quick / 60) + "s";



            aspect_variante = aux_variante;

            if (which_one == 1)
            {
                if (aspect_variante == 1)
                {
                    
                        V1.Visible = V2.Visible = V3.Visible = V4.Visible = true;
                        V01.Visible = V02.Visible = V03.Visible = V04.Visible = false;
                    
                   
                    radioButton1.Checked = true;radioButton2.Checked = false;
                }else if (aspect_variante == 0)
                {

                    if (V1.Visible == true || V01.Visible == true)
                    {
                        V1.Visible = V2.Visible = V3.Visible = V4.Visible = false;
                        V01.Visible = V02.Visible = V03.Visible = V04.Visible = true;
                    }
         
                    radioButton1.Checked = false; radioButton2.Checked = true;
                }
         
            }else if (which_one == 2)
            {
                if (aspect_cronometru == 1) { radioButton1.Checked = true; radioButton2.Checked = false; }
                else if (aspect_cronometru == 0) { radioButton1.Checked = false; radioButton2.Checked = true; }
            }
        }

        private void Memorise_Click(object sender, EventArgs e)
        {

            aux_back.BackColor = cul_back.BackColor;
            aux_intrebare.BackColor = cul_intrebare.BackColor;
            aux_descriere.BackColor = cul_descriere.BackColor;

            aux_rot.BorderColor = tasta1.BorderColor;
            aux_rot.OnHoverBorderColor = tasta1.OnHoverBorderColor;
            aux_rot.ButtonColor = tasta1.ButtonColor;
            aux_rot.OnHoverButtonColor = tasta1.OnHoverButtonColor;
            aux_rot.TextColor = tasta1.TextColor;
            aux_rot.OnHoverTextColor = tasta1.OnHoverTextColor;

            first_back = first_descriere = first_intrebare = true;

            TEST.BackColor = imagine_ceas.BackColor = cul_back.BackColor;
            qlabel.ForeColor = cul_intrebare.BackColor;
            descriere.ForeColor = cul_descriere.BackColor;

            TEST.BackColor = descriere.BackColor =  cul_back.BackColor;

            tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = TEST.BackColor;
            tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor = TEST.BackColor;
            tasta0.ButtonColor = tasta1.ButtonColor = tasta2.ButtonColor = tasta3.ButtonColor = tasta4.ButtonColor = tasta5.ButtonColor = tasta6.ButtonColor = tasta7.ButtonColor = tasta8.ButtonColor = tasta9.ButtonColor = tasta_sterge.ButtonColor = mostra_rot.ButtonColor;
            tasta0.TextColor = tasta1.TextColor = tasta2.TextColor = tasta3.TextColor = tasta4.TextColor = tasta5.TextColor = tasta6.TextColor = tasta6.TextColor = tasta7.TextColor = tasta8.TextColor = tasta9.TextColor = tasta_sterge.TextColor = mostra_rot.TextColor;



            tasta0.BorderColor = tasta1.BorderColor = tasta2.BorderColor = tasta3.BorderColor = tasta4.BorderColor = tasta5.BorderColor = tasta6.BorderColor = tasta7.BorderColor = tasta8.BorderColor = tasta9.BorderColor = tasta_sterge.BorderColor = mostra_rot.BorderColor;
            tasta0.OnHoverBorderColor = tasta1.OnHoverBorderColor = tasta2.OnHoverBorderColor = tasta3.OnHoverBorderColor = tasta4.OnHoverBorderColor = tasta5.OnHoverBorderColor = tasta6.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta8.OnHoverBorderColor = tasta9.OnHoverBorderColor = tasta_sterge.OnHoverBorderColor = mostra_rot.OnHoverBorderColor;
            tasta0.OnHoverButtonColor = tasta1.OnHoverButtonColor = tasta2.OnHoverButtonColor = tasta3.OnHoverButtonColor = tasta4.OnHoverButtonColor = tasta5.OnHoverButtonColor = tasta6.OnHoverButtonColor = tasta7.OnHoverButtonColor = tasta8.OnHoverButtonColor = tasta9.OnHoverButtonColor = tasta_sterge.OnHoverButtonColor = mostra_rot.OnHoverButtonColor;
            tasta0.OnHoverTextColor = tasta1.OnHoverTextColor = tasta2.OnHoverTextColor = tasta3.OnHoverTextColor = tasta4.OnHoverTextColor = tasta5.OnHoverTextColor = tasta6.OnHoverTextColor = tasta7.OnHoverTextColor = tasta8.OnHoverTextColor = tasta9.OnHoverTextColor = tasta_sterge.OnHoverTextColor = mostra_rot.OnHoverTextColor;


            aux_cronometru = aspect_cronometru;
            aux_variante = aspect_variante;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (which_one == 1)
            {
                aspect_variante = 0;
                V1.Visible = V2.Visible = V3.Visible = V4.Visible = false;
                V01.Visible = V02.Visible = V03.Visible = V04.Visible = true;
            }
            else if (which_one == 2)
            {
                aspect_cronometru = 0;
                timp.Text = (quick / 60) + ":" + ((quick % 60) >= 10 ? (quick % 60).ToString() : "0" + (quick % 60));




            }
        }

        private void btr1_Click(object sender, EventArgs e)
        {
             mostra_rot.BackColor = tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = Color.White;
            mostra_rot.FlatStyle = tasta0.FlatStyle = tasta1.FlatStyle = tasta2.FlatStyle = tasta3.FlatStyle = tasta4.FlatStyle = tasta5.FlatStyle = tasta6.FlatStyle = tasta7.FlatStyle = tasta8.FlatStyle = tasta9.FlatStyle = tasta_sterge.FlatStyle = FlatStyle.Flat;
            mostra_rot.ForeColor = tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor = Color.White;
            mostra_rot.ButtonColor = tasta0.ButtonColor = tasta1.ButtonColor = tasta2.ButtonColor = tasta3.ButtonColor = tasta4.ButtonColor = tasta5.ButtonColor = tasta6.ButtonColor = tasta7.ButtonColor = tasta8.ButtonColor = tasta9.ButtonColor = tasta_sterge.ButtonColor = Color.White;
            mostra_rot.TextColor = tasta0.TextColor = tasta1.TextColor = tasta2.TextColor = tasta3.TextColor = tasta4.TextColor = tasta5.TextColor = tasta6.TextColor = tasta6.TextColor = tasta7.TextColor = tasta8.TextColor = tasta9.TextColor = tasta_sterge.TextColor = Color.Red;



            mostra_rot.BorderColor = tasta0.BorderColor = tasta1.BorderColor = tasta2.BorderColor = tasta3.BorderColor = tasta4.BorderColor = tasta5.BorderColor = tasta6.BorderColor = tasta7.BorderColor = tasta8.BorderColor = tasta9.BorderColor = tasta_sterge.BorderColor = Color.Red;
            mostra_rot.OnHoverBorderColor = tasta0.OnHoverBorderColor = tasta1.OnHoverBorderColor = tasta2.OnHoverBorderColor = tasta3.OnHoverBorderColor = tasta4.OnHoverBorderColor = tasta5.OnHoverBorderColor = tasta6.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta8.OnHoverBorderColor = tasta9.OnHoverBorderColor = tasta_sterge.OnHoverBorderColor = Color.Red;
            mostra_rot.OnHoverButtonColor = tasta0.OnHoverButtonColor = tasta1.OnHoverButtonColor = tasta2.OnHoverButtonColor = tasta3.OnHoverButtonColor = tasta4.OnHoverButtonColor = tasta5.OnHoverButtonColor = tasta6.OnHoverButtonColor = tasta7.OnHoverButtonColor = tasta8.OnHoverButtonColor = tasta9.OnHoverButtonColor = tasta_sterge.OnHoverButtonColor = Color.Red;
            mostra_rot.OnHoverTextColor = tasta0.OnHoverTextColor = tasta1.OnHoverTextColor = tasta2.OnHoverTextColor = tasta3.OnHoverTextColor = tasta4.OnHoverTextColor = tasta5.OnHoverTextColor = tasta6.OnHoverTextColor = tasta7.OnHoverTextColor = tasta8.OnHoverTextColor = tasta9.OnHoverTextColor = tasta_sterge.OnHoverTextColor = Color.White;
            tasta_sterge.BackColor = Color.White;


            bordercolorbotton.BackColor = mostra_rot.BorderColor; hbordercolorbotton.BackColor = mostra_rot.OnHoverBorderColor;

            buttoncolorbutton.BackColor = mostra_rot.ButtonColor; hbuttoncolorbutton.BackColor = mostra_rot.OnHoverButtonColor;
            textcolorbutton.BackColor = mostra_rot.TextColor; htextcolorbutton.BackColor = mostra_rot.OnHoverTextColor;


            tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = TEST.BackColor;
            tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor =TEST.BackColor;

        }

        private void stanga_output_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cul_descriere_Click(object sender, EventArgs e)
        {

        }

        private void inserare1_TextChanged(object sender, EventArgs e)
        {

        }
        private void inserare1_Click(object sender, EventArgs e)
        {
            nr_inserare = 1;
            if (inserare1.Text == "*primul an")
            {
                
                inserare1.ForeColor = Color.Black;
                inserare1.Text = " ";

                schimbare = true;
                under = 100;



            }
        }

        private void inserare2_TextChanged(object sender, EventArgs e)
        {

        }

        private void inserare_raspuns_TextChanged(object sender, EventArgs e)
        {
            if (inserare_raspuns.ForeColor != Color.Red && inserare_raspuns.ForeColor != Color.Green)
            {
                if (schimbare == true && inserare_raspuns.Text == "") { underline_inserare_rasp.Value = 0; inserare_raspuns.ForeColor = Color.Gray; inserare_raspuns.Text = "*insereaza raspunsul"; schimbare = false; }

                if (schimbare == false && inserare_raspuns.Text == "") { inserare_raspuns.ForeColor = Color.Black; schimbare = true; under = 50; }

                for (int i = 0; i <= 127; i++)
                {

                    char c = Convert.ToChar(i);
                    if (inserare_raspuns.Text == c + "*insereaza raspunsul") { underline_inserare_rasp.Value = 0; inserare_raspuns.Text = Convert.ToChar(i) + ""; inserare_raspuns.ForeColor = Color.Black; schimbare = true; under = 50; }
                    else if (inserare_raspuns.Text == "*" + c + "insereaza raspunsul") { underline_inserare_rasp.Value = 0; inserare_raspuns.Text = Convert.ToChar(i) + ""; inserare_raspuns.ForeColor = Color.Black; schimbare = true; under = 50; }
                    else if (inserare_raspuns.Text == "*i" + c + "nsereaza raspunsul") { underline_inserare_rasp.Value = 0; inserare_raspuns.Text = Convert.ToChar(i) + ""; inserare_raspuns.ForeColor = Color.Black; schimbare = true; under = 50; }
                    else if (inserare_raspuns.Text == "*in" + c + "sereaza raspunsul") { underline_inserare_rasp.Value = 0; inserare_raspuns.Text = Convert.ToChar(i) + ""; inserare_raspuns.ForeColor = Color.Black; schimbare = true; under = 50; }
                    else if (inserare_raspuns.Text == "*ins" + c + "ereaza raspunsul") { underline_inserare_rasp.Value = 0; inserare_raspuns.Text = Convert.ToChar(i) + ""; inserare_raspuns.ForeColor = Color.Black; schimbare = true; under = 50; }
                    else if (inserare_raspuns.Text == "*inse" + c + "reaza raspunsul") { underline_inserare_rasp.Value = 0; inserare_raspuns.Text = Convert.ToChar(i) + ""; inserare_raspuns.ForeColor = Color.Black; schimbare = true; under = 50; }
                    else if (inserare_raspuns.Text == "*inser" + c + "eaza raspunsul") { underline_inserare_rasp.Value = 0; inserare_raspuns.Text = Convert.ToChar(i) + ""; inserare_raspuns.ForeColor = Color.Black; schimbare = true; under = 50; }
                    else if (inserare_raspuns.Text == "*insere" + c + "aza raspunsul") { underline_inserare_rasp.Value = 0; inserare_raspuns.Text = Convert.ToChar(i) + ""; inserare_raspuns.ForeColor = Color.Black; schimbare = true; under = 50; }
                    else if (inserare_raspuns.Text == "*inserea" + c + "za raspunsul") { underline_inserare_rasp.Value = 0; inserare_raspuns.Text = Convert.ToChar(i) + ""; inserare_raspuns.ForeColor = Color.Black; schimbare = true; under = 50; }
                    else if (inserare_raspuns.Text == "*insereaz" + c + "a raspunsul") { underline_inserare_rasp.Value = 0; inserare_raspuns.Text = Convert.ToChar(i) + ""; inserare_raspuns.ForeColor = Color.Black; schimbare = true; under = 50; }
                    else if (inserare_raspuns.Text == "*insereaza" + c + " raspunsul") { underline_inserare_rasp.Value = 0; inserare_raspuns.Text = Convert.ToChar(i) + ""; inserare_raspuns.ForeColor = Color.Black; schimbare = true; under = 50; }
                    else if (inserare_raspuns.Text == "*insereaza " + c + "raspunsul") { underline_inserare_rasp.Value = 0; inserare_raspuns.Text = Convert.ToChar(i) + ""; inserare_raspuns.ForeColor = Color.Black; schimbare = true; under = 50; }
                    else if (inserare_raspuns.Text == "*insereaz " + c + "raspunsul") { underline_inserare_rasp.Value = 0; inserare_raspuns.Text = Convert.ToChar(i) + ""; inserare_raspuns.ForeColor = Color.Black; schimbare = true; under = 50; }
                    else if (inserare_raspuns.Text == "*insereaza r" + c + "aspunsul") { underline_inserare_rasp.Value = 0; inserare_raspuns.Text = Convert.ToChar(i) + ""; inserare_raspuns.ForeColor = Color.Black; schimbare = true; under = 50; }
                    else if (inserare_raspuns.Text == "*insereaza ra" + c + "aspunsul") { underline_inserare_rasp.Value = 0; inserare_raspuns.Text = Convert.ToChar(i) + ""; inserare_raspuns.ForeColor = Color.Black; schimbare = true; under = 50; }
                    else if (inserare_raspuns.Text == "*insereaza ras" + c + "punsul") { underline_inserare_rasp.Value = 0; inserare_raspuns.Text = Convert.ToChar(i) + ""; inserare_raspuns.ForeColor = Color.Black; schimbare = true; under = 50; }
                    else if (inserare_raspuns.Text == "*insereaza rasp" + c + "unsul") { underline_inserare_rasp.Value = 0; inserare_raspuns.Text = Convert.ToChar(i) + ""; inserare_raspuns.ForeColor = Color.Black; schimbare = true; under = 50; }
                    else if (inserare_raspuns.Text == "*insereaza raspu" + c + "nsul") { underline_inserare_rasp.Value = 0; inserare_raspuns.Text = Convert.ToChar(i) + ""; inserare_raspuns.ForeColor = Color.Black; schimbare = true; under = 50; }
                    else if (inserare_raspuns.Text == "*insereaza raspun" + c + "sul") { underline_inserare_rasp.Value = 0; inserare_raspuns.Text = Convert.ToChar(i) + ""; inserare_raspuns.ForeColor = Color.Black; schimbare = true; under = 50; }
                    else if (inserare_raspuns.Text == "*insereaza raspuns" + c + "ul") { underline_inserare_rasp.Value = 0; inserare_raspuns.Text = Convert.ToChar(i) + ""; inserare_raspuns.ForeColor = Color.Black; schimbare = true; under = 50; }
                    else if (inserare_raspuns.Text == "*insereaza raspunsu" + c + "l") { underline_inserare_rasp.Value = 0; inserare_raspuns.Text = Convert.ToChar(i) + ""; inserare_raspuns.ForeColor = Color.Black; schimbare = true; under = 50; }
                    else if (inserare_raspuns.Text == "*insereaza raspunsul" + c) { underline_inserare_rasp.Value = 0; inserare_raspuns.Text = Convert.ToChar(i) + ""; inserare_raspuns.ForeColor = Color.Black; schimbare = true; under = 50; }

                }
            }

        }

        private void inserare_raspuns_Click(object sender, EventArgs e)
        {
            if (inserare_raspuns.Text == "*insereaza raspunsul")
            {

                inserare_raspuns.ForeColor = Color.Black;
                inserare_raspuns.Text = "";
                
                schimbare = true;
                under = 50;


             
            }


        }

        private void TEST_Paint(object sender, PaintEventArgs e)
        {

        }

        private void inserare2_Click(object sender, EventArgs e)
        {
            nr_inserare = 2;
            if (inserare2.Text == "*al doilea an")
            {

                inserare2.ForeColor = Color.Black;
                inserare2.Text = " ";

                schimbare = true;
                under = 100;



            }

        }

        private void Biog2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form5 = new Form5();
            form5.Closed += (s, args) => this.Close();
            form5.Show();
        }

        private void Biog1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form5 = new Form5();
            form5.Closed += (s, args) => this.Close();
            form5.Show();
        }

        private void SC2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form6 = new Form6();
            form6.Closed += (s, args) => this.Close();
            form6.Show();
        }

        private void underline_inserare_rasp_ValueChanged(object sender, EventArgs e)
        {
  
        }

 

        private void progrestime_Tick(object sender, EventArgs e)
        {
            if (under > 0)
            {
                under--;
                if (type == 4) underline_inserare_rasp.Value = (50 - under) * 2;
                else if (type == 3)
                {
                    if (nr_inserare == 1) underline1.Value = 100 - under;
                    else if (nr_inserare == 2) underline2.Value = 100 - under;
                }
            }
        }

        private void progrestime_Tick_1(object sender, EventArgs e)
        {
            if (under > 0)
            {
                under--;
                if(type==4)underline_inserare_rasp.Value = (50 - under) * 2;
                else if (type == 3)
                {
                    if (nr_inserare == 1) underline1.Value = 100 - under;
                    else if(nr_inserare==2) underline2.Value = 100 - under;
                }
            }
        }

        private void btr2_Click(object sender, EventArgs e)
        {
             mostra_rot.BackColor = tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = Color.White;
            mostra_rot.FlatStyle = tasta0.FlatStyle = tasta1.FlatStyle = tasta2.FlatStyle = tasta3.FlatStyle = tasta4.FlatStyle = tasta5.FlatStyle = tasta6.FlatStyle = tasta7.FlatStyle = tasta8.FlatStyle = tasta9.FlatStyle = tasta_sterge.FlatStyle = FlatStyle.Flat;
            mostra_rot.ForeColor = tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor = Color.White;
            mostra_rot.ButtonColor = tasta0.ButtonColor = tasta1.ButtonColor = tasta2.ButtonColor = tasta3.ButtonColor = tasta4.ButtonColor = tasta5.ButtonColor = tasta6.ButtonColor = tasta7.ButtonColor = tasta8.ButtonColor = tasta9.ButtonColor = tasta_sterge.ButtonColor = Color.White;
            mostra_rot.TextColor = tasta0.TextColor = tasta1.TextColor = tasta2.TextColor = tasta3.TextColor = tasta4.TextColor = tasta5.TextColor = tasta6.TextColor = tasta6.TextColor = tasta7.TextColor = tasta8.TextColor = tasta9.TextColor = tasta_sterge.TextColor = Color.Goldenrod;



            mostra_rot.BorderColor = tasta0.BorderColor = tasta1.BorderColor = tasta2.BorderColor = tasta3.BorderColor = tasta4.BorderColor = tasta5.BorderColor = tasta6.BorderColor = tasta7.BorderColor = tasta8.BorderColor = tasta9.BorderColor = tasta_sterge.BorderColor = Color.Goldenrod;
            mostra_rot.OnHoverBorderColor = tasta0.OnHoverBorderColor = tasta1.OnHoverBorderColor = tasta2.OnHoverBorderColor = tasta3.OnHoverBorderColor = tasta4.OnHoverBorderColor = tasta5.OnHoverBorderColor = tasta6.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta8.OnHoverBorderColor = tasta9.OnHoverBorderColor = tasta_sterge.OnHoverBorderColor = Color.Goldenrod;
            mostra_rot.OnHoverButtonColor = tasta0.OnHoverButtonColor = tasta1.OnHoverButtonColor = tasta2.OnHoverButtonColor = tasta3.OnHoverButtonColor = tasta4.OnHoverButtonColor = tasta5.OnHoverButtonColor = tasta6.OnHoverButtonColor = tasta7.OnHoverButtonColor = tasta8.OnHoverButtonColor = tasta9.OnHoverButtonColor = tasta_sterge.OnHoverButtonColor = Color.Goldenrod;
            mostra_rot.OnHoverTextColor = tasta0.OnHoverTextColor = tasta1.OnHoverTextColor = tasta2.OnHoverTextColor = tasta3.OnHoverTextColor = tasta4.OnHoverTextColor = tasta5.OnHoverTextColor = tasta6.OnHoverTextColor = tasta7.OnHoverTextColor = tasta8.OnHoverTextColor = tasta9.OnHoverTextColor = tasta_sterge.OnHoverTextColor = Color.White;
            tasta_sterge.BackColor = Color.White;


            bordercolorbotton.BackColor = mostra_rot.BorderColor; hbordercolorbotton.BackColor = mostra_rot.OnHoverBorderColor;

            buttoncolorbutton.BackColor = mostra_rot.ButtonColor; hbuttoncolorbutton.BackColor = mostra_rot.OnHoverButtonColor;
            textcolorbutton.BackColor = mostra_rot.TextColor; htextcolorbutton.BackColor = mostra_rot.OnHoverTextColor;


            tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = TEST.BackColor;
            tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor = TEST.BackColor;

        }

        private void btr3_Click(object sender, EventArgs e)
        {
            mostra_rot.BackColor = tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = Color.White;
            mostra_rot.FlatStyle = tasta0.FlatStyle = tasta1.FlatStyle = tasta2.FlatStyle = tasta3.FlatStyle = tasta4.FlatStyle = tasta5.FlatStyle = tasta6.FlatStyle = tasta7.FlatStyle = tasta8.FlatStyle = tasta9.FlatStyle = tasta_sterge.FlatStyle = FlatStyle.Flat;
            mostra_rot.ForeColor = tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor = Color.White;
            mostra_rot.ButtonColor = tasta0.ButtonColor = tasta1.ButtonColor = tasta2.ButtonColor = tasta3.ButtonColor = tasta4.ButtonColor = tasta5.ButtonColor = tasta6.ButtonColor = tasta7.ButtonColor = tasta8.ButtonColor = tasta9.ButtonColor = tasta_sterge.ButtonColor = Color.White;
            mostra_rot.TextColor = tasta0.TextColor = tasta1.TextColor = tasta2.TextColor = tasta3.TextColor = tasta4.TextColor = tasta5.TextColor = tasta6.TextColor = tasta6.TextColor = tasta7.TextColor = tasta8.TextColor = tasta9.TextColor = tasta_sterge.TextColor = Color.FromArgb(22, 18, 126);

            mostra_rot.BorderColor = tasta0.BorderColor = tasta1.BorderColor = tasta2.BorderColor = tasta3.BorderColor = tasta4.BorderColor = tasta5.BorderColor = tasta6.BorderColor = tasta7.BorderColor = tasta8.BorderColor = tasta9.BorderColor = tasta_sterge.BorderColor = Color.FromArgb(22, 18, 126);
            mostra_rot.OnHoverBorderColor = tasta0.OnHoverBorderColor = tasta1.OnHoverBorderColor = tasta2.OnHoverBorderColor = tasta3.OnHoverBorderColor = tasta4.OnHoverBorderColor = tasta5.OnHoverBorderColor = tasta6.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta8.OnHoverBorderColor = tasta9.OnHoverBorderColor = tasta_sterge.OnHoverBorderColor = Color.FromArgb(22, 18, 126);
            mostra_rot.OnHoverButtonColor = tasta0.OnHoverButtonColor = tasta1.OnHoverButtonColor = tasta2.OnHoverButtonColor = tasta3.OnHoverButtonColor = tasta4.OnHoverButtonColor = tasta5.OnHoverButtonColor = tasta6.OnHoverButtonColor = tasta7.OnHoverButtonColor = tasta8.OnHoverButtonColor = tasta9.OnHoverButtonColor = tasta_sterge.OnHoverButtonColor = Color.FromArgb(22, 18, 126);
            mostra_rot.OnHoverTextColor = tasta0.OnHoverTextColor = tasta1.OnHoverTextColor = tasta2.OnHoverTextColor = tasta3.OnHoverTextColor = tasta4.OnHoverTextColor = tasta5.OnHoverTextColor = tasta6.OnHoverTextColor = tasta7.OnHoverTextColor = tasta8.OnHoverTextColor = tasta9.OnHoverTextColor = tasta_sterge.OnHoverTextColor = Color.White;
            tasta_sterge.BackColor = Color.White;

            bordercolorbotton.BackColor = mostra_rot.BorderColor; hbordercolorbotton.BackColor = mostra_rot.OnHoverBorderColor;

            buttoncolorbutton.BackColor = mostra_rot.ButtonColor; hbuttoncolorbutton.BackColor = mostra_rot.OnHoverButtonColor;
            textcolorbutton.BackColor = mostra_rot.TextColor; htextcolorbutton.BackColor = mostra_rot.OnHoverTextColor;

            tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = TEST.BackColor;
            tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor = TEST.BackColor;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Cronometru.BackColor != Color.FromArgb(0, 102, 204))
            {
                bck.ForeColor = intrebare.ForeColor = description.ForeColor = taste.ForeColor = variante.ForeColor = Color.FromArgb(0, 102, 204);
                bck.BackColor = intrebare.BackColor = description.BackColor = taste.BackColor = variante.BackColor = Color.White;

                Cronometru.ForeColor = Color.White; Cronometru.BackColor = Color.FromArgb(0, 102, 204);
                
                
                radioButton1.Text = "Timp exprimat doar in secunde.";
                radioButton2.Text = "Timp exrpimat in secunde si milisecunde.";
               
                radioButton1.Visible = radioButton2.Visible = true;
                label4.Visible = btr1.Visible = btr2.Visible = btr3.Visible = label6.Visible = bordercolorbotton.Visible = buttoncolorbutton.Visible = textcolorbutton.Visible = hbordercolorbotton.Visible = hbuttoncolorbutton.Visible = htextcolorbutton.Visible = mostra_rot.Visible = bordercolorbotton.Visible = buttoncolorbutton.Visible = textcolorbutton.Visible = hbordercolorbotton.Visible = hbuttoncolorbutton.Visible = htextcolorbutton.Visible = mostra.Visible = comboBox1.Visible = label5.Visible = label1.Visible = label2.Visible = rosu.Visible = verde.Visible = albastru.Visible = red.Visible = green.Visible = blue.Visible = false;

              
                if (descriere.Text == "") descriere.Text = "descriere";
                qlabel.Text = "Intrebare";


                which_one = 2;

                if (aspect_cronometru == 1) { radioButton1.Checked = true; radioButton2.Checked = false; }
                else if (aspect_cronometru == 0) { radioButton1.Checked = false; radioButton2.Checked = true; }


            }




            dsc.Text = "Schimbă afisajul cronometrului.";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (which_one == 1)
            {
                aspect_variante = 1;
                V1.Visible = V2.Visible = V3.Visible = V4.Visible = true;
                V01.Visible = V02.Visible = V03.Visible = V04.Visible = false;
            }else if (which_one == 2)
            {
                aspect_cronometru = 1;

                timp.Text = Convert.ToString(quick / 60) + "s";
                if (quick < 60) timp.Text = "<1s";


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Cronometru_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (merge_cronometrul == true)
            {
                if (quick > 0)
                {
                    timp.Font = new Font("Microsoft Sans Seri", 28, FontStyle.Bold);

                    if (quick == 1500)
                    {
                        if (aspect == 1) timp.Text = "25s";
                        else if (aspect == 0) timp.Text = "25:00";
                    }

                    quick--;
                  
                    timp.Value = quick * 100 / 1500;
                    if (aspect_cronometru == 0)
                    {
                        timp.Text = (quick / 60) + ":" + ((quick % 60) >= 10 ? (quick % 60).ToString() : "0" + (quick % 60));

                    }
                    else if (aspect_cronometru == 1)
                    {
                        timp.Text = Convert.ToString(quick / 60) + "s";
                        if (quick < 60) timp.Text = "<1s";
                    }
                   
                    int nr;
                    nr = quick / 60;

                    //  timp.Text = Convert.ToString(nr + 1) + "s";
                    //    timp.Text = Convert.ToString(nr) + "s";
                    if (nr == 26) timp.ProgressColor = timp.ForeColor = Color.FromArgb(30, 208, 34);
                    else if (nr ==25||nr==24) timp.ProgressColor = timp.ForeColor = Color.FromArgb(31, 208, 30);
                    else if (nr == 23||nr==22) timp.ProgressColor = timp.ForeColor = Color.FromArgb(36, 208, 30);
                    else if (nr == 21 || nr == 21) timp.ProgressColor = timp.ForeColor = Color.FromArgb(42, 208, 30);
                    else if (nr == 20 || nr == 19) timp.ProgressColor = timp.ForeColor = Color.FromArgb(44, 208, 30);
                    else if ( nr==18||nr==17) timp.ProgressColor = timp.ForeColor = Color.FromArgb(63, 208, 30);
                    else if (nr == 16||nr==15) timp.ProgressColor = timp.ForeColor = Color.FromArgb(117, 208, 30);
                    else if (nr == 13||nr==14) timp.ProgressColor = timp.ForeColor = Color.FromArgb(208, 189, 30);
                    else if (nr == 12) timp.ProgressColor = timp.ForeColor = Color.FromArgb(214, 194, 29);
                    else if (nr == 11||nr==10) timp.ProgressColor = timp.ForeColor = Color.FromArgb(216, 196, 27);
                    else if (nr ==8||nr==9) timp.ProgressColor = timp.ForeColor = Color.FromArgb(214, 194, 29);
                    else if (nr == 6 || nr == 7) timp.ProgressColor = timp.ForeColor = Color.FromArgb(255, 131, 21);
                    else if (nr == 6 || nr == 4) timp.ProgressColor = timp.ForeColor = Color.FromArgb(255, 92, 21);
                    else if (nr == 3) timp.ProgressColor = timp.ForeColor = Color.FromArgb(255, 49, 21);
                    else if (nr == 2 || nr == 1) timp.ProgressColor = timp.ForeColor = Color.FromArgb(255, 0, 0);





                }
                else if (quick == 0)
                {
                    format.Visible = true;
                    OK.Visible = true;
                    aces =acces_tasta=acces_variante= false;
                    inserare_raspuns.ReadOnly = inserare1.ReadOnly = inserare2.ReadOnly = true;

                    timp.Text = "TIMP EXPIRAT!";timp.Value = 100;

                    timp.Font = new Font("Microsoft Sans Seri", 10);


                    if (inserare_raspuns.Text == "*insereaza raspunsul") inserare_raspuns.Text = "  ";
                    Enter.Visible = false;

                    if (type == 1)
                    {
                        if (V1.BackColor == Color.White && V01.BackColor == Color.White && V2.BackColor == Color.White && V02.BackColor == Color.White && V3.BackColor == Color.White && V03.BackColor == Color.White && V04.BackColor == Color.White && V4.BackColor == Color.White)
                        {
                            qlabel.Text = "nici nu ai incercat";

                            if (question == 1 || question == 2 || question == 14 || question == 32)
                            {
                                V1.BackColor = V01.BackColor = Color.Yellow;
                                V1.ForeColor = V01.ForeColor = Color.Red;
                            }
                            else if (question == 9 || question == 11 || question == 26 || question == 30 || question == 33 || question == 34 || question == 44 || question == 50 || question == 54)
                            {
                                V2.BackColor = V02.BackColor = Color.Yellow;
                                V2.ForeColor = V02.ForeColor = Color.Red;
                            }
                            else if (question == 12 || question == 13 || question == 15 || question == 21 || question == 22 || question == 28 || question == 31)
                            {
                                V3.BackColor = V03.BackColor = Color.Yellow;
                                V3.ForeColor = V03.ForeColor = Color.Red;
                            }
                            else if (question == 4 || question == 8 || question == 35 || question == 42 || question == 49)
                            {
                                V4.BackColor = V04.BackColor = Color.Yellow;
                                V4.ForeColor = V04.ForeColor = Color.Red;
                            }
                        }

                    }
                    else if (type == 2)
                    {



                        inserare_raspuns.ReadOnly = true;
                        inserare2.ReadOnly = true;
                        inserare1.ReadOnly = true;

                        merge_cronometrul = false;
                        descriere.Visible = true;

                        aces = false;
                        OK.Visible = true;



                        int ad = 0;
                        Enter.Visible = false;

                        if (question == 3)
                        {

                            descriere.Visible = true;
                            if (an.Text == "1870") { an.ForeColor = Color.Green; ad = 1; }
                            else { an.ForeColor = Color.Red; rasp_corect.Text = "1870"; rasp_corect.Visible = true; }
                            sir = "1870";
                        }
                        else if (question == 5)
                        {
                            imagine_test.Image = Properties.Resources.intrebare_nr_11_2;
                            if (an.Text == "1857") { an.ForeColor = Color.Green; ad = 1; }
                            else { an.ForeColor = Color.Red; rasp_corect.Text = "1857"; rasp_corect.Visible = true; }
                            sir = "1857";
                        }
                        else if (question == 6)
                        {
                            imagine_test.Image = Properties.Resources.intrebare_nr_13_2;
                            descriere.Text = "Romania a avut doar 4 regi,acestia fiind:Carol I,Ferdinand I,Carol al II-lea si Mihai I";
                            descriere.Visible = true;
                            if (an.Text == "4") { an.ForeColor = Color.Green; ad = 1; }
                            else { an.ForeColor = Color.Red; rasp_corect.Text = "4"; rasp_corect.Visible = true; }
                            sir = "4";
                        }
                        else if (question == 16)
                        {
                            if (an.Text == "1916") { an.ForeColor = Color.Green; ad = 1; }
                            else { an.ForeColor = Color.Red; rasp_corect.Text = "1916"; rasp_corect.Visible = true; }
                            sir = "1916";
                        }
                        else if (question == 19)
                        {
                            if (an.Text == "1917") { an.ForeColor = Color.Green; ad = 1; }
                            else { an.ForeColor = Color.Red; rasp_corect.Text = "1917"; rasp_corect.Visible = true; }
                            sir = "1917";
                        }
                        else if (question == 20)
                        {
                            if (an.Text == "1917") { an.ForeColor = Color.Green; ad = 1; }
                            else { an.ForeColor = Color.Red; rasp_corect.Text = "1917"; rasp_corect.Visible = true; }
                            sir = "1917";
                        }
                        else if (question == 24)
                        {
                            if (an.Text == "1922") { an.ForeColor = Color.Green; ad = 1; }
                            else { an.ForeColor = Color.Red; rasp_corect.Text = "1922"; rasp_corect.Visible = true; }
                            sir = "1922";
                        }
                        else if (question == 25)
                        {
                            if (an.Text == "1923") { an.ForeColor = Color.Green; ad = 1; }
                            else { an.ForeColor = Color.Red; an.ForeColor = Color.Red; rasp_corect.Text = "1923"; rasp_corect.Visible = true; }
                            sir = "1923";
                        }
                        else if (question == 29)
                        {
                            if (an.Text == "1933") { an.ForeColor = Color.Green; ad = 1; }
                            else { an.ForeColor = Color.Red; rasp_corect.Text = "1933"; rasp_corect.Visible = true; }
                            sir = "1933";
                        }
                        else if (question == 38)
                        {
                            if (an.Text == "1939") { an.ForeColor = Color.Green; ad = 1; }
                            else { an.ForeColor = Color.Red; rasp_corect.Text = "1939"; rasp_corect.Visible = true; }
                            sir = "1939";
                        }
                        else if (question == 39)
                        {
                            imagine_test.Image = Properties.Resources.intrebare87_2;
                            if (an.Text == "1940") { an.ForeColor = Color.Green; ad = 1; }
                            else { an.ForeColor = Color.Red; rasp_corect.Text = "1940"; rasp_corect.Visible = true; }
                            sir = "1940";
                        }
                        else if (question == 40)
                        {
                            if (an.Text == "1939") { an.ForeColor = Color.Green; ad = 1; }
                            else { an.ForeColor = Color.Red; rasp_corect.Text = "1939"; rasp_corect.Visible = true; }
                            sir = "1939";
                        }
                        else if (question == 41)
                        {

                            if (an.Text == "1940") { an.ForeColor = Color.Green; ad = 1; }
                            else { an.ForeColor = Color.Red; rasp_corect.Text = "1940"; rasp_corect.Visible = true; }
                            sir = "1940";
                        }
                        else if (question == 43)
                        {
                            if (an.Text == "1941") { an.ForeColor = Color.Green; ad = 1; }
                            else { an.ForeColor = Color.Red; rasp_corect.Text = "1941"; rasp_corect.Visible = true; }
                            sir = "1941";
                        }
                        else if (question == 45)
                        {
                            if (an.Text == "1941") { an.ForeColor = Color.Green; ad = 1; }
                            else { an.ForeColor = Color.Red; rasp_corect.Text = "1941"; rasp_corect.Visible = true; }
                            sir = "1941";
                        }
                        else if (question == 48)
                        {
                            if (an.Text == "1943") { an.ForeColor = Color.Green; ad = 1; }
                            else { an.ForeColor = Color.Red; rasp_corect.Text = "1943"; rasp_corect.Visible = true; }
                            sir = "1943";
                        }
                        else if (question == 52)
                        {
                            if (an.Text == "1947") { an.ForeColor = Color.Green; ad = 1; }
                            else { an.ForeColor = Color.Red; rasp_corect.Text = "1947"; rasp_corect.Visible = true; }
                            sir = "1947";
                        }
                        else if (question == 53)
                        {
                            if (an.Text == "1960") { an.ForeColor = Color.Green; ad = 1; }
                            else { an.ForeColor = Color.Red; rasp_corect.Text = "1960"; rasp_corect.Visible = true; }
                            sir = "1960";

                        }
                        else if (question == 55)
                        {
                            if (an.Text == "1961") { an.ForeColor = Color.Green; ad = 1; }
                            else { an.ForeColor = Color.Red; rasp_corect.Text = "1961"; rasp_corect.Visible = true; }

                            sir = "1961";
                        }
                        else if (question == 59)
                        {
                            if (an.Text == "1962") { an.ForeColor = Color.Green; ad = 1; }
                            else { an.ForeColor = Color.Red; rasp_corect.Text = "1962"; rasp_corect.Visible = true; }
                            sir = "1962";
                        }
                        else if (question == 60)
                        {
                            if (an.Text == "444") { an.ForeColor = Color.Green; ad = 1; }
                            else { an.ForeColor = Color.Red; rasp_corect.Text = "444"; rasp_corect.Visible = true; }
                            sir = "444";
                        }
                        else if (question == 61)
                        {
                            if (an.Text == "3") { an.ForeColor = Color.Green; ad = 1; }
                            else { an.ForeColor = Color.Red; rasp_corect.Text = "3"; rasp_corect.Visible = true; }
                            sir = "3";
                        }
                        else if (question == 62)
                        {
                            if (an.Text == "1991") { an.ForeColor = Color.Green; ad = 1; }
                            else { an.ForeColor = Color.Red; rasp_corect.Text = "1991"; rasp_corect.Visible = true; }
                            sir = "1991";
                        }




                        if (nr == 0) this.Alert("Success ", Form_Alert.enmType.Nothing);
                        else
                        {
                            if (ad == 1)
                            {

                                it_c++; it_g = 0;
                                if (it_c == 1) motivator = "Bravo!";
                                else if (it_c == 2) motivator = "Bună treabă!";
                                else if (it_c == 3) motivator = "Te descurci minunat!";
                                else if (it_c == 4) motivator = "Continua tot asa!";
                                else if (it_c == 5) motivator = "Excelent!!!";
                                else if (it_c == 6) motivator = "Bravooss!!";
                                else it_c = 0;
                                this.Alert("Success ", Form_Alert.enmType.Success);




                                corecte_genarale++;

                                if (question >= 1 && question <= 12) corecte_t1++;
                                if (question >= 13 && question <= 21) corecte_t2++;
                                if (question >= 22 && question <= 29) corecte_t3++;
                                if (question >= 30 && question <= 51) corecte_t4++;
                                if (question >= 52 && question <= 62) corecte_t5++;


                            }
                            else
                            {

                                it_c = 0; it_g++;

                                if (it_g == 1) motivator = "Nu te lăsa descurajat!";
                                else if (it_g == 2) motivator = "Nu fii dezamagit!";
                                else if (it_g == 3) motivator = "Mai incearca!";
                                else if (it_g == 4) motivator = "Poate ai succes la următoarea...";
                                else it_g = 0;
                                this.Alert("Error", Form_Alert.enmType.Error);
                            }





                        }
                    }
                    else if (type == 3)
                    {


                        inserare_raspuns.ReadOnly = true;
                        inserare2.ReadOnly = true;
                        inserare1.ReadOnly = true;

                        merge_cronometrul = false;
                        descriere.Visible = true;

                        aces = false;
                        OK.Visible = true;



                        int ad = 0;
                        Enter.Visible = false;
                        if (question == 7)
                        {
                            bool c = true;
                            if (inserare1.Text == "1861") inserare1.ForeColor = Color.Green;
                            else { c = false; inserare1.ForeColor = Color.Red; }
                            if (inserare2.Text == "1865") inserare2.ForeColor = Color.Green;
                            else { c = false; inserare2.ForeColor = Color.Red; }

                            if (c == false) { rasp_corect.Text = "1861-1865"; rasp_corect.Visible = true; }
                            else ad = 1;
                            sir = "1861-1865";
                        }
                        else if (question == 46)
                        {
                            bool c = true;
                            if (inserare1.Text == "1941") inserare1.ForeColor = Color.Green;
                            else { c = false; inserare1.ForeColor = Color.Red; }
                            if (inserare2.Text == "1944") inserare2.ForeColor = Color.Green;
                            else { c = false; inserare2.ForeColor = Color.Red; }

                            if (c == false) { rasp_corect.Text = "1941-1944"; rasp_corect.Visible = true; }
                            else ad = 1;

                            sir = "1941-1944";
                        }
                        else if (question == 47)
                        {
                            bool c = true;
                            if (inserare1.Text == "1942") inserare1.ForeColor = Color.Green;
                            else { c = false; inserare1.ForeColor = Color.Red; }
                            if (inserare2.Text == "1943") inserare2.ForeColor = Color.Green;
                            else { c = false; inserare2.ForeColor = Color.Red; }

                            if (c == false) { rasp_corect.Text = "1942-1943"; rasp_corect.Visible = true; }
                            else ad = 1;
                            sir = "1942-1943";
                        }

                        str1 = inserare1.Text;
                        str1 = str1.Trim();
                        str2 = inserare2.Text;
                        str2 = str2.Trim();

                        if (str1 == "" || str2 == "") this.Alert("Success ", Form_Alert.enmType.Nothing);
                        else
                        {
                            if (ad == 1)
                            {
                                it_c++; it_g = 0;
                                if (it_c == 1) motivator = "Bravo!";
                                else if (it_c == 2) motivator = "Bună treabă!";
                                else if (it_c == 3) motivator = "Te descurci minunat!";
                                else if (it_c == 4) motivator = "Continua tot asa!";
                                else if (it_c == 5) motivator = "Excelent!!!";
                                else if (it_c == 6) motivator = "Bravooss!!";
                                else it_c = 0;
                                this.Alert("Success ", Form_Alert.enmType.Success);




                                corecte_genarale++;

                                if (question >= 1 && question <= 12) corecte_t1++;
                                if (question >= 13 && question <= 22) corecte_t2++;
                                if (question >= 23 && question <= 29) corecte_t3++;
                                if (question >= 30 && question <= 51) corecte_t4++;
                                if (question >= 52 && question <= 62) corecte_t5++;


                            }
                            else
                            {
                                it_c = 0; it_g++;

                                if (it_g == 1) motivator = "Nu te lăsa descurajat!";
                                else if (it_g == 2) motivator = "Nu fii dezamagit!";
                                else if (it_g == 3) motivator = "Mai incearca!";
                                else if (it_g == 4) motivator = "Poate ai succes la următoarea...";
                                else it_g = 0;
                                this.Alert("Error", Form_Alert.enmType.Error);
                            }
                        }





                    }
                    else if (type == 4)
                    {   if (inserare_raspuns.Text == "*insereaza raspunsul") inserare_raspuns.Text = "   ";
                        str = inserare_raspuns.Text;
                        str = str.Trim();


                        inserare_raspuns.ReadOnly = true;
                        inserare2.ReadOnly = true;
                        inserare1.ReadOnly = true;

                        merge_cronometrul = false;
                        descriere.Visible = true;

                        aces = false;
                        OK.Visible = true;



                        int ad = 0;
                        Enter.Visible = false;

                        if (question == 10)
                        {

                            str = inserare_raspuns.Text;
                            str = str.Trim();




                            str1 = str;
                            str1 = str1.ToLower(); str1 = str1.Replace(" ", String.Empty);



                            if (str == "Port Arthur" || str == "PORT ARTHUR" || str == "Port  Arthur" || str == "PORT  ARTHUR" || str == "Port   Arthur" || str == "PORT   ARTHUR" || str == "Port    Arthur" || str == "PORT    ARTHUR" || str == "Port     Arthur" || str == "PORT     ARTHUR") { inserare_raspuns.ForeColor = Color.Green; ad = 1; }
                            else if (str1 == "portarthur") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „Port Arthur”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                            else { inserare_raspuns.ForeColor = Color.Red; rasp_corect.Text = "Port Arthur"; rasp_corect.Visible = true; }
                            sir = "Port Arthur";

                        }
                        else if (question == 17)
                        {
                            str = inserare_raspuns.Text;
                            str = str.Trim();




                            str1 = str;
                            str1 = str1.ToLower();
                            str2 = inserare_raspuns.Text;
                            str2 = str2.ToUpper();

                            str1 = str1.Replace(" ", String.Empty);



                            if (str == "Iasi" || str == "Iași" || str == "IASI" || str == "IAȘI") { inserare_raspuns.ForeColor = Color.Green; ad = 1; }
                            else if (str1 == "iasi") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „Iasi”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                            else if (str1 == "iași") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „Iași”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                            else { inserare_raspuns.ForeColor = Color.Red; rasp_corect.Text = "Iași"; rasp_corect.Visible = true; }
                            sir = "Iași";
                        }
                        else if (question == 18)
                        {
                            str = inserare_raspuns.Text;
                            str = str.Trim();




                            str1 = str;
                            str1 = str1.ToLower(); str1 = str1.Replace(" ", String.Empty);


                            if (str == "Rusia" || str == "RUSIA") { inserare_raspuns.ForeColor = Color.Green; ad = 1; }
                            else if (str1 == "rusia") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „Rusia”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                            else { inserare_raspuns.ForeColor = Color.Red; rasp_corect.Text = "Rusia"; rasp_corect.Visible = true; }
                            sir = "Rusia";
                        }
                        else if (question == 23)
                        {
                            imagine_test.Image = Properties.Resources.rinruhr2;
                            str = inserare_raspuns.Text;
                            str = str.Trim();




                            str1 = str;
                            str1 = str1.ToLower(); str1 = str1.Replace(" ", String.Empty);



                            if (str == "Rin-Ruhr" || str == "Ruhr" || str == "RIN-RUHR" || str == "RUHR") { inserare_raspuns.ForeColor = Color.Green; ad = 1; }
                            else if (str1 == "ruhr") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „Ruhr”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                            else if (str1 == "rin-ruhr") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „Rin-Ruhr”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                            else { inserare_raspuns.ForeColor = Color.Red; rasp_corect.Text = "Rin-Ruhr"; rasp_corect.Visible = true; }
                            sir = "Rin-Ruhr";
                        }
                        else if (question == 27)
                        {
                            str = inserare_raspuns.Text;
                            str = str.Trim();




                            str1 = str;
                            str1 = str1.ToLower(); str1 = str1.Replace(" ", String.Empty);



                            if (str == "Chicago" || str == "CHICAGO") { inserare_raspuns.ForeColor = Color.Green; ad = 1; }
                            else if (str1 == "chicago") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „Chicago”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                            else { inserare_raspuns.ForeColor = Color.Red; rasp_corect.Text = "Chicago"; rasp_corect.Visible = true; }
                            sir = "Chicago";
                        }
                        else if (question == 36)
                        {

                            str = inserare_raspuns.Text;
                            str = str.Trim();




                            str1 = str;
                            str1 = str1.ToLower(); str1 = str1.Replace(" ", String.Empty);




                            if (str == "Elvetia" || str == "ELVETIA" || str == "Elveția" || str == "ELVEȚIA" || str == "Spania" || str == "SPANIA" || str == "Portugalia" || str == "PORTUGALIA" || str == "Irlanda" || str == "IRLANDA" || str == "Suedia" || str == "SUEDIA") { inserare_raspuns.ForeColor = Color.Green; ad = 1; }
                            else if (str1 == "elvetia") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „Elvetia”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                            else if (str1 == "elveția") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „Elveția”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                            else if (str1 == "spania") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „Spania”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                            else if (str1 == "portugalia") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „Portugalia”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                            else if (str1 == "irlanda") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „Irlanda”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                            else if (str1 == "suedia") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „Suedia”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                            else { inserare_raspuns.ForeColor = Color.Red; rasp_corect.Text = "Elveția"; rasp_corect.Visible = true; }
                            descriere.Text = "Un porumbel tinand in plisc o ramura de maslin este simbolul pacii.Singurele tari europene care nu au participat la razboi sunt:Portugalia,Spania,Elvetia, Suedia si Irlanda";
                            descriere.Visible = true;
                            sir = "Elvetia";

                        }
                        else if (question == 37)
                        {
                            str = inserare_raspuns.Text;
                            str = str.Trim();




                            str1 = str;
                            str1 = str1.ToLower(); str1 = str1.Replace(" ", String.Empty);


                            if (str == "Alan Turing" || str == "ALAN TURING" || str == "Alan  Turing" || str == "ALAN  TURING" || str == "Alan  Turing" || str == "ALAN   TURING" || str == "Alan    Turing" || str == "ALAN    TURING" || str == "Alan     Turing" || str == "ALAN     TURING") { inserare_raspuns.ForeColor = Color.Green; ad = 1; }
                            else if (str1 == "alanturing") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „Chicago”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                            else { inserare_raspuns.ForeColor = Color.Red; ; rasp_corect.Text = "Alan Turing"; rasp_corect.Visible = true; }
                            sir = "Alan Turing";
                        }
                        else if (question == 51)
                        {

                            str = inserare_raspuns.Text;
                            str = str.Trim();




                            str1 = str;
                            str1 = str1.ToLower(); str1 = str1.Replace(" ", String.Empty);




                            if (str == "Kaliningrad" || str == "KALININGRAD" || str == "Königsberg" || str == "KÖNIGSBERG" || str == "Konigsberg" || str == "KONIGSBERG") { inserare_raspuns.ForeColor = Color.Green; ad = 1; }
                            else if (str1 == "kaliningrad") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „Kaliningrad”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                            else if (str1 == "Königsberg") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „Königsberg”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                            else if (str1 == "Konigsberg") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „Konigsberg”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                            else { inserare_raspuns.ForeColor = Color.Red; rasp_corect.Text = "Königsberg"; rasp_corect.Visible = true; }
                            sir = "Konigsberg";

                        }
                        else if (question == 56)
                        {
                            str = inserare_raspuns.Text;
                            str = str.Trim();




                            str1 = str;
                            str1 = str1.ToLower(); str1 = str1.Replace(" ", String.Empty);

                            if (str == "Fidel Castro" || str == "FIDEL CASTRO" || str == "Fidel  Castro" || str == "FIDEL  CASTRO" || str == "Fidel   Castro" || str == "FIDEL   CASTRO" || str == "Fidel    Castro" || str == "FIDEL    CASTRO" || str == "Fidel     Castro" || str == "FIDEL     CASTRO") { inserare_raspuns.ForeColor = Color.Green; ad = 1; }
                            else if (str1 == "fidelcastro") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Raspunsul este corect, dar se scrie „Fidel Castro”, nu „" + str + "”" + Environment.NewLine + "Ai grija la urmatoarele aspecte:" + Environment.NewLine + "-unde pui spatiile si cate pui" + Environment.NewLine + "-unde folosesti majuscule;" + Environment.NewLine + "-intre cuvinte se pune doar un spatiu;" + Environment.NewLine + "-nu se pune spatiu intre o liter si un semn de punctuatie/ de ortografie;"); }
                            else { inserare_raspuns.ForeColor = Color.Red; rasp_corect.Text = "Fidel Castro"; rasp_corect.Visible = true; }
                            sir = "Fidel Castro";

                        }
                        else if (question == 57)
                        {

                            str = inserare_raspuns.Text;
                            str = str.Trim();




                            str1 = str;
                            str1 = str1.ToLower(); str1 = str1.Replace(" ", String.Empty);




                            if (str == "JFK" || str == "J.F.K." || str == "John Fitzgerald Kennedy" || str == "JOHN FITZGERALD KENNEDY" || str == "John F. Kennedy" || str == "JOHN F. KENNEDY") { inserare_raspuns.ForeColor = Color.Green; ad = 1; }
                            else if (str1 == "jfk") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „JFK”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                            else if (str1 == "j.f.k.") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „j.f.k.”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                            else if (str1 == "johnfitzgeraldkennedy") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „John Fitzgerald Kennedy”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                            else if (str1 == "johnf.kennedy") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Răspunsul este corect, dar se scrie „John F. Kennedy”, nu „" + str + "”" + Environment.NewLine + "Ai grijă la următoarele aspecte:" + Environment.NewLine + "-unde pui spațiile si câte pui" + Environment.NewLine + "-unde folosești majuscule;" + Environment.NewLine + "-între cuvinte se pune doar un spațiu;" + Environment.NewLine + "-nu se pune spațiu între o literă și un semn de punctuație/ de ortografie;"); }
                            else { inserare_raspuns.ForeColor = Color.Red; rasp_corect.Text = "John Fitzgerald Kennedy"; rasp_corect.Visible = true; }
                            sir = "John Fitzgerald Kennedy";

                        }
                        else if (question == 58)
                        {
                            str = inserare_raspuns.Text;
                            str = str.Trim();




                            str1 = str;
                            str1 = str1.ToLower(); str1 = str1.Replace(" ", String.Empty);

                            if (str == "Ronald Reagan" || str == "RONALD REAGAN" || str == "Ronald  Reagan" || str == "RONALD  REAGAN" || str == "Ronald   Reagan" || str == "RONALD   REAGAN" || str == "Ronald    Reagan" || str == "RONALD    REAGAN" || str == "Ronald     Reagan" || str == "RONALD     REAGAN") { inserare_raspuns.ForeColor = Color.Green; ad = 1; }
                            else if (str1 == "ronaldreagan") { inserare_raspuns.ForeColor = Color.Green; ad = 1; MessageBox.Show("Raspunsul este corect, dar se scrie „Ronald Reagan”, nu „" + str + "”" + Environment.NewLine + "Ai grija la urmatoarele aspecte:" + Environment.NewLine + "-unde pui spatiile si cate pui" + Environment.NewLine + "-unde folosesti majuscule;" + Environment.NewLine + "-intre cuvinte se pune doar un spatiu;" + Environment.NewLine + "-nu se pune spatiu intre o liter si un semn de punctuatie/ de ortografie;"); }
                            else { inserare_raspuns.ForeColor = Color.Red; rasp_corect.Text = "Ronald Reagan"; rasp_corect.Visible = true; }

                            sir = "Ronald Reagan";
                        }


                        
                        if (inserare_raspuns.Text == "*insereaza raspunsul") inserare_raspuns.Text = "  ";
                        str = inserare_raspuns.Text;
                        str = str.Trim();
                        if (str == ""||inserare_raspuns.Text=="*insereaza raspunsul") 
                        {
                            underline_inserare_rasp.Value = 0;
                            underline_inserare_rasp.FillColor = Color.Red;
                            this.Alert("Success ", Form_Alert.enmType.Nothing);
                        } else
                        {
                            if (ad == 1)
                            {
                                underline_inserare_rasp.Value = 0;
                                underline_inserare_rasp.FillColor = Color.Green;
                                it_c++; it_g = 0;
                                if (it_c == 1) motivator = "Bravo!";
                                else if (it_c == 2) motivator = "Bună treabă!";
                                else if (it_c == 3) motivator = "Te descurci minunat!";
                                else if (it_c == 4) motivator = "Continua tot asa!";
                                else if (it_c == 5) motivator = "Excelent!!!";
                                else if (it_c == 6) motivator = "Bravooss!!";
                                else it_c = 0;
                                this.Alert("Success ", Form_Alert.enmType.Success);




                                corecte_genarale++;

                                if (question >= 1 && question <= 12) corecte_t1++;
                                if (question >= 13 && question <= 22) corecte_t2++;
                                if (question >= 23 && question <= 29) corecte_t3++;
                                if (question >= 30 && question <= 51) corecte_t4++;
                                if (question >= 52 && question <= 62) corecte_t5++;


                            }
                            else
                            {
                                underline_inserare_rasp.Value = 0;
                                underline_inserare_rasp.FillColor = Color.Red;
                                it_c = 0; it_g++;

                                if (it_g == 1) motivator = "Nu te lăsa descurajat!";
                                else if (it_g == 2) motivator = "Nu fii dezamagit!";
                                else if (it_g == 3) motivator = "Mai incearca!";
                                else if (it_g == 4) motivator = "Poate ai succes la următoarea...";
                                else it_g = 0;
                                this.Alert("Error", Form_Alert.enmType.Error);
                            }

                        }




                    }
                    
                }
            }
  
        }

        private void timp_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            frecv = 1 - frecv;
            if (frecv == 1)
            {
                frecv = 1;
                MessageBox.Show("Daca inchideti aceasta fereastra, tot progresul nesalvat va disparea!");
            }else if (frecv == 0)
            {
                frecv_ok = frecv = 0;
                panel2.Visible = false;
                first_back = first_descriere = first_intrebare = true;

                cul_back.BackColor = aux_back.BackColor;
                cul_intrebare.BackColor = aux_intrebare.BackColor;
                cul_descriere.BackColor = aux_descriere.BackColor;

                mostra_rot.BorderColor = aux_rot.BorderColor;
                mostra_rot.OnHoverBorderColor = aux_rot.OnHoverBorderColor;
                mostra_rot.ButtonColor = aux_rot.ButtonColor;
                mostra_rot.OnHoverButtonColor = aux_rot.OnHoverButtonColor;
                mostra_rot.TextColor = aux_rot.TextColor;
                mostra_rot.OnHoverTextColor = aux_rot.OnHoverTextColor;

                bordercolorbotton.BackColor = mostra_rot.BorderColor;
                hbordercolorbotton.BackColor = mostra_rot.OnHoverBorderColor;

                buttoncolorbutton.BackColor = mostra_rot.ButtonColor;
                hbuttoncolorbutton.BackColor = mostra_rot.OnHoverButtonColor;

                textcolorbutton.BackColor = mostra_rot.TextColor;
                htextcolorbutton.BackColor = mostra_rot.OnHoverTextColor;

                tasta0.FlatStyle = FlatStyle.Flat;


                inserare1.BackColor = inserare2.BackColor = inserare_raspuns.BackColor = TEST.BackColor = imagine_ceas.BackColor = descriere.BackColor = timp.BackColor = qlabel.BackColor = cul_back.BackColor;


                tasta0.ForeColor = tasta1.ForeColor = tasta2.ForeColor = tasta3.ForeColor = tasta4.ForeColor = tasta5.ForeColor = tasta6.ForeColor = tasta7.ForeColor = tasta8.ForeColor = tasta9.ForeColor = tasta_sterge.ForeColor = cul_back.BackColor;
                tasta0.BackColor = tasta1.BackColor = tasta2.BackColor = tasta3.BackColor = tasta4.BackColor = tasta5.BackColor = tasta6.BackColor = tasta7.BackColor = tasta8.BackColor = tasta9.BackColor = tasta_sterge.BackColor = cul_back.BackColor;

                tasta0.ButtonColor = tasta1.ButtonColor = tasta2.ButtonColor = tasta3.ButtonColor = tasta4.ButtonColor = tasta5.ButtonColor = tasta6.ButtonColor = tasta7.ButtonColor = tasta8.ButtonColor = tasta9.ButtonColor = tasta_sterge.ButtonColor = mostra_rot.ButtonColor;

                tasta0.BorderColor = tasta1.BorderColor = tasta2.BorderColor = tasta3.BorderColor = tasta4.BorderColor = tasta5.BorderColor = tasta6.BorderColor = tasta7.BorderColor = tasta8.BorderColor = tasta9.BorderColor = tasta_sterge.BorderColor = mostra_rot.BorderColor;
                tasta0.OnHoverBorderColor = tasta1.OnHoverBorderColor = tasta2.OnHoverBorderColor = tasta3.OnHoverBorderColor = tasta4.OnHoverBorderColor = tasta5.OnHoverBorderColor = tasta6.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta7.OnHoverBorderColor = tasta8.OnHoverBorderColor = tasta9.OnHoverBorderColor = tasta_sterge.OnHoverBorderColor = mostra_rot.OnHoverBorderColor;
                tasta0.OnHoverButtonColor = tasta1.OnHoverButtonColor = tasta2.OnHoverButtonColor = tasta3.OnHoverButtonColor = tasta4.OnHoverButtonColor = tasta5.OnHoverButtonColor = tasta6.OnHoverButtonColor = tasta7.OnHoverButtonColor = tasta8.OnHoverButtonColor = tasta9.OnHoverButtonColor = tasta_sterge.OnHoverButtonColor = mostra_rot.OnHoverButtonColor;
                tasta0.TextColor = tasta1.TextColor = tasta2.TextColor = tasta3.TextColor = tasta4.TextColor = tasta5.TextColor = tasta6.TextColor = tasta6.TextColor = tasta7.TextColor = tasta8.TextColor = tasta9.TextColor = tasta_sterge.TextColor = mostra_rot.TextColor;

                tasta0.OnHoverTextColor = tasta1.OnHoverTextColor = tasta2.OnHoverTextColor = tasta3.OnHoverTextColor = tasta4.OnHoverTextColor = tasta5.OnHoverTextColor = tasta6.OnHoverTextColor = tasta7.OnHoverTextColor = tasta8.OnHoverTextColor = tasta9.OnHoverTextColor = tasta_sterge.OnHoverTextColor = mostra_rot.OnHoverTextColor;


                if (pozitie == 1) mostra.BackColor = cul_back.BackColor;
                else if (pozitie == 2) mostra.BackColor = intrebare.BackColor;
                else if (pozitie == 3) mostra.BackColor = description.BackColor;


                aspect_cronometru = aux_cronometru;

                if (aspect_cronometru == 0) timp.Text = (quick / 60) + ":" + ((quick % 60) >= 10 ? (quick % 60).ToString() : "0" + (quick % 60));
                else if (aspect_cronometru == 1) timp.Text = Convert.ToString(quick / 60) + "s";



                aspect_variante = aux_variante;

                if (which_one == 1)
                {
                    if (aspect_variante == 1)
                    {

                        V1.Visible = V2.Visible = V3.Visible = V4.Visible = true;
                        V01.Visible = V02.Visible = V03.Visible = V04.Visible = false;


                        radioButton1.Checked = true; radioButton2.Checked = false;
                    }
                    else if (aspect_variante == 0)
                    {

                        if (V1.Visible == true || V01.Visible == true)
                        {
                            V1.Visible = V2.Visible = V3.Visible = V4.Visible = false;
                            V01.Visible = V02.Visible = V03.Visible = V04.Visible = true;
                        }

                        radioButton1.Checked = false; radioButton2.Checked = true;
                    }

                }
                else if (which_one == 2)
                {
                    if (aspect_cronometru == 1) { radioButton1.Checked = true; radioButton2.Checked = false; }
                    else if (aspect_cronometru == 0) { radioButton1.Checked = false; radioButton2.Checked = true; }
                }
            }
        
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

        private void mafiamember_Click(object sender, EventArgs e)
        {
            meme++; afis_meme();
        }

        private void SC1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form6 = new Form6();
            form6.Closed += (s, args) => this.Close();
            form6.Show();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

   

        void multiple_choice()
        {
            underline_inserare_rasp.Visible = false;
            type = 1;
            an.ForeColor = inserare2.ForeColor = inserare1.ForeColor =  inserare_raspuns.ForeColor = Color.Black;


            V01.BackColor = V02.BackColor = V03.BackColor = V04.BackColor = V1.BackColor = V2.BackColor = V3.BackColor = V4.BackColor = Color.White;
            V01.ForeColor = V02.ForeColor = V03.ForeColor = V04.ForeColor = V1.ForeColor = V2.ForeColor = V3.ForeColor = V4.ForeColor = Color.Black;
            Enter.Visible = false;

            descriere.Visible = false;
            inserare2.Visible = inserare1.Visible = false;
            inserare_raspuns.Visible = false; rasp_corect.Visible = false;
            underline1.Visible = underline2.Visible = tasta0.Visible = tasta1.Visible = tasta2.Visible = tasta3.Visible = tasta4.Visible = tasta5.Visible = tasta6.Visible = tasta7.Visible = tasta8.Visible = tasta9.Visible = tasta_sterge.Visible = false;
            OK.Visible = false;

            an.Visible = false; rasp_corect.Visible = false;
            descriere.Text = "";

            if (aspect_variante == 1) { V1.Visible = V2.Visible = V3.Visible = V4.Visible = true; V01.Visible = V02.Visible = V03.Visible = V04.Visible = false; }
            else if (aspect_variante == 0) { V1.Visible = V2.Visible = V3.Visible = V4.Visible =false; V01.Visible = V02.Visible = V03.Visible = V04.Visible =true; }
           
            aces = acces_tasta=false;
            acces_variante = true;
            inserare_raspuns.ReadOnly = inserare1.ReadOnly = inserare2.ReadOnly = false;


            merge_cronometrul = true;


           
        }

      

        void intrebare_an()
        {
            underline_inserare_rasp.Visible = false;
            type = 2;

            an.ForeColor = inserare2.ForeColor = inserare1.ForeColor = inserare_raspuns.ForeColor = Color.Black;

            underline1.Visible = underline2.Visible = V01.Visible = V02.Visible = V03.Visible = V04.Visible = V1.Visible = V2.Visible = V3.Visible = V4.Visible = false;

            descriere.Text = "";

            inserare_raspuns.Visible = false;

            descriere.Visible = false;
            OK.Visible = false;
            inserare2.Visible = inserare1.Visible = false;
         
            tasta0.Visible = tasta1.Visible = tasta2.Visible = tasta3.Visible = tasta4.Visible = tasta5.Visible = tasta6.Visible = tasta7.Visible = tasta8.Visible = tasta9.Visible = tasta_sterge.Visible = true;
            an.BackColor = Color.White;
            rasp_corect.Visible = false;
            Enter.Visible = true; an.Visible = true;
            an.Text = ""; nr = 0;
           
            aces = true;



            acces_variante=  aces = false;
            acces_tasta = true;
            

            inserare_raspuns.ReadOnly = inserare1.ReadOnly = inserare2.ReadOnly = false;



            merge_cronometrul = true;


        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {

        }

 

        void dual()
        {

            underline_inserare_rasp.Visible = false;

            type = 3;
            an.ForeColor = inserare2.ForeColor = inserare1.ForeColor =  inserare_raspuns.ForeColor = Color.Black;


            V01.Visible = V02.Visible = V03.Visible = V04.Visible = V1.Visible = V2.Visible = V3.Visible = V4.Visible = false;

            OK.Visible = false;
            an.Visible = rasp_corect.Visible = false;
 
            inserare_raspuns.Visible = false;
            descriere.Visible = false;
            rasp_corect.Visible = false;
    
            descriere.Text = "";
            tasta0.Visible = tasta1.Visible = tasta2.Visible = tasta3.Visible = tasta4.Visible = tasta5.Visible = tasta6.Visible = tasta7.Visible = tasta8.Visible = tasta9.Visible = tasta_sterge.Visible = false;
           
            inserare2.ForeColor = inserare1.ForeColor = Color.Black;
            inserare2.Text = inserare1.Text = "";
            inserare2.Visible = inserare1.Visible = true;

            Enter.Visible = true;
            acces_tasta = acces_variante = false;
            aces = true;

       
            
            inserare_raspuns.ReadOnly = true;
            inserare2.ReadOnly = inserare1.ReadOnly = false;



            inserare_raspuns.ReadOnly = inserare1.ReadOnly = inserare2.ReadOnly = false;
            underline1.Visible = underline2.Visible = true;
            schimbare1 = schimbare2 = false;
            inserare1.ForeColor = inserare2.ForeColor = Color.Gray;
            underline1.Value = underline2.Value = 0;
            inserare1.Text = "*primul an"; inserare2.Text = "*al doilea an";

            merge_cronometrul = true;
        }

        
        void un_sg_rasp()
        {
           
            type = 4;
            an.ForeColor = inserare2.ForeColor = inserare1.ForeColor = inserare_raspuns.ForeColor = Color.Black;

           

            OK.Visible = false;
            underline1.Visible = underline2.Visible = V01.Visible = V02.Visible = V03.Visible = V04.Visible = V1.Visible = V2.Visible = V3.Visible = V4.Visible = false;
           
            descriere.Visible = false;
            tasta0.Visible = tasta1.Visible = tasta2.Visible = tasta3.Visible = tasta4.Visible = tasta5.Visible = tasta6.Visible = tasta7.Visible = tasta8.Visible = tasta9.Visible = tasta_sterge.Visible = false;
 
            an.Visible = false;
            inserare2.Visible = inserare1.Visible = false;
         
            rasp_corect.Visible = false;
            descriere.Text = "";

            Enter.Visible = true;
           
            inserare_raspuns.ForeColor = Color.Black;


            inserare_raspuns.Visible = true;
            acces_tasta = acces_variante = false;
            aces = true;

    

            inserare_raspuns.ReadOnly = false;
            inserare2.ReadOnly = inserare1.ReadOnly = true;

            inserare_raspuns.ReadOnly = inserare1.ReadOnly = inserare2.ReadOnly = false;


            merge_cronometrul = true;

            underline_inserare_rasp.FillColor = Color.Gray;
            underline_inserare_rasp.Visible = true;underline_inserare_rasp.Value = 0;
            inserare_raspuns.ForeColor = Color.Gray;
            schimbare = false;
            inserare_raspuns.Text = "*insereaza raspunsul";




        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }



        private void tasta_sterge_Click(object sender, EventArgs e)
        {
            if (acces_tasta == true)
            {

                nr = nr / 10;
                if (nr != 0) an.Text = Convert.ToString(nr);
                else an.Text = "";
                this.Refresh();


            }
        }

   

        private void tasta0_Click(object sender, EventArgs e)
        {
            if (acces_tasta == true)
            {
                if (nr < 99999)
                {
                    nr = nr * 10 ;
                    an.Text = Convert.ToString(nr);
                    this.Refresh();
                }

            }
        }



        private void tasta1_Click(object sender, EventArgs e)
        {
            if (acces_tasta == true)
            {
                if (nr < 99999)
                {
                    nr = nr * 10 + 1;
                    an.Text = Convert.ToString(nr);
                    this.Refresh();
                }

            }
        }

        private void tasta2_Click(object sender, EventArgs e)
        {
            if (acces_tasta == true)
            {
                if (nr < 99999)
                {
                    nr = nr * 10 + 2;
                    an.Text = Convert.ToString(nr);
                    this.Refresh();
                }

            }
        }

       

        private void tasta3_Click(object sender, EventArgs e)
        {
            if (acces_tasta == true)
            {
                if (nr < 99999)
                {
                    nr = nr * 10 + 3;
                    an.Text = Convert.ToString(nr);
                    this.Refresh();
                }

            }
        }

        private void tasta4_Click(object sender, EventArgs e)
        {
            if (acces_tasta == true)
            {
                if (nr < 99999)
                {
                    nr = nr * 10 + 4;
                    an.Text = Convert.ToString(nr);
                    this.Refresh();
                }

            }
        }

        private void tasta5_Click(object sender, EventArgs e)
        {
            if (acces_tasta == true)
            {
                if (nr < 99999)
                {
                    nr = nr * 10 + 5;
                    an.Text = Convert.ToString(nr);
                    this.Refresh();
                }

            }
        }

        private void tasta6_Click(object sender, EventArgs e)
        {
            if (acces_tasta == true)
            {
                if (nr < 99999)
                {
                    nr = nr * 10 + 6;
                    an.Text = Convert.ToString(nr);
                    this.Refresh();
                }

            }
        }

        private void tasta7_Click(object sender, EventArgs e)
        {
            if (acces_tasta == true)
            {
                if (nr < 99999)
                {
                    nr = nr * 10 + 7;
                    an.Text = Convert.ToString(nr);
                    this.Refresh();
                }

            }
        }

        private void tasta8_Click(object sender, EventArgs e)
        {
            if (acces_tasta == true)
            {
                if (nr < 99999)
                {
                    nr = nr * 10 + 8;
                    an.Text = Convert.ToString(nr);
                    this.Refresh();
                }

            }
        }

        private void tasta9_Click(object sender, EventArgs e)
        {
            if (acces_tasta == true)
            {
                if (nr < 99999)
                {
                    nr = nr * 10 + 9;
                    an.Text = Convert.ToString(nr);
                    this.Refresh();
                }

            }
        }



        private void E1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void E2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void S1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new Form3();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void S2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new Form3();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
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
