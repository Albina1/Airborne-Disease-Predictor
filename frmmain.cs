using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FInal_project
{
    public partial class frmain : MetroFramework.Forms.MetroForm
    {
        //when object needs to cordinate across the system
        static frmain _instance;
        public static frmain Instance
        {
        get
        {
            if (_instance== null)
            _instance= new frmain();
            return _instance;
        }
         }

        public MetroFramework.Controls.MetroPanel MetroContainer
        {
            get { return mpanel; }
            set { mpanel=value; }
        }

        public MetroFramework.Controls.MetroLink MetroBack
        {

            get { return mlback; }
            set { mlback = value; }
        }

        public frmain()
        {
            Thread t = new Thread(new ThreadStart(loading));
            InitializeComponent();
            t.Start();
            for (int i = 0; i < 100; i++) // for 1 milli second
               Thread.Sleep(1);//demo
            t.Abort(); // completed




            


        }

        void loading()
        {
            //Splash frm = new Splash();
           // Application.Run(frm);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mlback.Visible = false;
            _instance = this;
            ucdashboard uc= new ucdashboard();
            uc.Dock = DockStyle.Fill;
            mpanel.Controls.Add(uc);


        }

        private void btnhome_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            using (frmain frm = new frmain())
            {
                frm.ShowDialog();
            }
        }

        private void mback_Click(object sender, EventArgs e)
        {
            mpanel.Controls["ucdashboard"].BringToFront();
            mlback.Visible = false;

        }

        private void mpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
