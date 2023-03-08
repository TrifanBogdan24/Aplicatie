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
    public partial class Form_Alert : Form
    {
        int ceform;
        public Form_Alert()
        {
            InitializeComponent();
            inchidere.Cursor = xulet.Cursor = lblMsg.Cursor = corect.Cursor = Cursors.Hand;
            inchidere.Text = "";
  
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


        private int x, y;
        public void showAlert(string msg, string rasp1, string rasp2, enmType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            lblMsg.ForeColor = Color.FromArgb(240,240,240);
            switch (type)
            {  
                case enmType.Success:

                    Top = 20;
                    Left = Screen.PrimaryScreen.Bounds.Width - Width - 20;
                    this.BackColor = Color.DarkRed;
                    ceform = 1;
                    xulet.BackgroundImage = Properties.Resources.x_button;
                    corect.BackgroundImage = Properties.Resources.approved;
                    lblMsg.Text = rasp1 + '\n' + "Raspuns corect:" + rasp2;
                    break;
                case enmType.Error:
                    Top = 20;
                    Left = Screen.PrimaryScreen.Bounds.Width - Width - 20;
                    ceform = 1;
                    this.BackColor = Color.DarkRed;
                    xulet.BackgroundImage = Properties.Resources.x_button__1_;
                    corect.BackgroundImage = Properties.Resources.approved;
                    lblMsg.Text = rasp1 + '\n' + "Raspuns corect:" + rasp2;
                    break;


                case enmType.Nothing:
                    Top = 20;
                    Left = Screen.PrimaryScreen.Bounds.Width - Width - 20;
                    ceform = 1;
                    this.BackColor = Color.Yellow;
                    xulet.BackgroundImage = Properties.Resources.x_button__1_;
                    corect.BackgroundImage = Properties.Resources.dece;
                    lblMsg.Text = "Nici macar nu ai incercat!";lblMsg.ForeColor = Color.Red;
                    break;


                case enmType.Final:

                    xulet.BackgroundImage = Properties.Resources.x_button__2_;
                    corect.BackgroundImage = Properties.Resources.positive_vote;
                    this.BackColor = Color.FromArgb(22,18,126);
                    lblMsg.Text = rasp1;
                    for (int i = 1; i < 10; i++)
                    {
                        ceform = 2;
                        fname = "alert" + i.ToString();
                        Form_Alert frm = (Form_Alert)Application.OpenForms[fname];

                        if (frm == null)
                        {
                            this.Name = fname;
                            this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                            this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                            this.Location = new Point(this.x, this.y);
                            break;

                        }

                    }
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
                    break;

                case enmType.Perfect:

                    xulet.BackgroundImage = Properties.Resources.x_button__3_;
                    corect.BackgroundImage = Properties.Resources.trophy;
                    this.BackColor = Color.Goldenrod;
                    lblMsg.Text = rasp1;
                    for (int i = 1; i < 10; i++)
                    {
                        ceform = 2;
                        fname = "alert" + i.ToString();
                        Form_Alert frm = (Form_Alert)Application.OpenForms[fname];

                        if (frm == null)
                        {
                            this.Name = fname;
                            this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                            this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                            this.Location = new Point(this.x, this.y);
                            break;

                        }

                    }
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
                    break;

            }

         
            
           
            switch (type)
            {
                case enmType.Success:

                    this.BackColor = Color.SeaGreen;
                    xulet.BackgroundImage = Properties.Resources.x_button;
                    lblMsg.Text = rasp1;
                    break;
                case enmType.Error:

                    this.BackColor = Color.DarkRed;
                    xulet.BackgroundImage = Properties.Resources.x_button__1_;
                    xulet.BackgroundImage = Properties.Resources.x_button__1_;
                    lblMsg.Text = rasp1+'\n'+"Raspuns corect:"+rasp2;
                    break;

            }



        

            this.Show();
            this.action = enmAction.start;
            this.timer1.Interval = 1;
            this.timer1.Start();
        }



        private void Form_Alert_Load(object sender, EventArgs e)
        {
           
        }

        private void lblMsg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    
                    
                    if(ceform==2)timer1.Interval = 4000;
                    else if(ceform==1) timer1.Interval = 100;
                    action = enmAction.close;
                    break;
                case Form_Alert.enmAction.start:
                    this.timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = Form_Alert.enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        private void corect_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xulet_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void corect_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMsg_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xulet_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void corect_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xulet_Click_3(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMsg_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xulet_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
