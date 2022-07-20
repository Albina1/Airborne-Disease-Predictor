using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInal_project
{
    

    
    public partial class InsertPatientID : MetroFramework.Forms.MetroForm
    {
        public static string valueid;

        MedicalDiagnosisDBDataContext dc = new MedicalDiagnosisDBDataContext();
        PatientDetail pd = new PatientDetail();
        Probability_of_disease pro = new Probability_of_disease();

        List<PatientDetail> patientlist;
        List<Probability_of_disease> problist;



        public InsertPatientID()
        {
            InitializeComponent();
        }

        private void InsertPatientID_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            patientlist = dc.PatientDetails.ToList();
            problist = dc.Probability_of_diseases.ToList();
            
            int i;
            int total = patientlist.Count();
            int totalMatch = 0;
            for (i = 0; i < total; i++)
            {
                if (txtpatientID.Text == patientlist[i].patientID.ToString() && txtpatientContactnum.Text == patientlist[i].contactnum)
                {
                    totalMatch++;
                    break;
                }
            }
            if (totalMatch == 1)
            {
                problist = dc.Probability_of_diseases.ToList();
                int id = Convert.ToInt32(txtpatientID.Text);
                txtpatientID.Text = "";
                txtpatientContactnum.Text = "";
                this.Hide();
            ViewreportfromPatientID op = new ViewreportfromPatientID(id);
                op.Show();


                










            }
            else
            {
                MessageBox.Show("Patient ID and contact number are not matched. ");
            }
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtpatientID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                SendKeys.Send("tab");
            }
        }

        private void txtpatientContactnum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                SendKeys.Send("tab");
            }
        }
    }
}

