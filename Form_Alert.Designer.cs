namespace Aplicatie
{
    partial class Form_Alert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Alert));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.xulet = new System.Windows.Forms.PictureBox();
            this.corect = new System.Windows.Forms.PictureBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.inchidere = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xulet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corect)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.xulet);
            this.panel1.Controls.Add(this.corect);
            this.panel1.Controls.Add(this.lblMsg);
            this.panel1.Controls.Add(this.inchidere);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 108);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // xulet
            // 
            this.xulet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xulet.BackgroundImage")));
            this.xulet.Location = new System.Drawing.Point(487, 28);
            this.xulet.Name = "xulet";
            this.xulet.Size = new System.Drawing.Size(48, 50);
            this.xulet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xulet.TabIndex = 9;
            this.xulet.TabStop = false;
            this.xulet.Click += new System.EventHandler(this.xulet_Click_3);
            // 
            // corect
            // 
            this.corect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("corect.BackgroundImage")));
            this.corect.Location = new System.Drawing.Point(0, 28);
            this.corect.Name = "corect";
            this.corect.Size = new System.Drawing.Size(48, 50);
            this.corect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.corect.TabIndex = 8;
            this.corect.TabStop = false;
            this.corect.Click += new System.EventHandler(this.corect_Click_2);
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMsg.Location = new System.Drawing.Point(47, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(440, 108);
            this.lblMsg.TabIndex = 7;
            this.lblMsg.Text = "label1";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMsg.Click += new System.EventHandler(this.lblMsg_Click_2);
            // 
            // inchidere
            // 
            this.inchidere.Location = new System.Drawing.Point(0, 0);
            this.inchidere.Name = "inchidere";
            this.inchidere.Size = new System.Drawing.Size(535, 108);
            this.inchidere.TabIndex = 0;
            this.inchidere.Text = "label1";
            this.inchidere.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form_Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(535, 108);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Alert";
            this.Text = "Form_Alert";
            this.Load += new System.EventHandler(this.Form_Alert_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xulet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox xulet;
        private System.Windows.Forms.PictureBox corect;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label inchidere;
    }
}