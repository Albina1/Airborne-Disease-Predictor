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
    public partial class FInalReport : MetroFramework.Forms.MetroForm
    {
        
        MedicalDiagnosisDBDataContext dc = new MedicalDiagnosisDBDataContext();
        PatientDetail pd = new PatientDetail();
        DiagnosisDisease dd = new DiagnosisDisease();
        Probability_of_disease pp = new Probability_of_disease();
        List<PatientDetail> patientLists = new List<PatientDetail>();
        List<DiagnosisDisease> symptomList = new List<DiagnosisDisease>();
        List<Probability_of_disease> probList = new List<Probability_of_disease>();
        int patientID;
        public FInalReport()
        {
            InitializeComponent();
        }

        
        private void FInalReport_Load(object sender, EventArgs e)
        {
            // for patient detail in head
            patientLists = dc.PatientDetails.ToList();
            symptomList = dc.DiagnosisDiseases.ToList();
            probList = dc.Probability_of_diseases.ToList();
            patientID = patientLists[patientLists.Count() - 1].patientID;
            lblPatientID.Text = patientID.ToString();
            lblfullname.Text = patientLists[patientLists.Count() - 1].patient_fname.ToString()+ " " + patientLists[patientLists.Count() - 1].patient_middlename.ToString() +" "+ patientLists[patientLists.Count() - 1].patient_lname.ToString();
            lblgender.Text = patientLists[patientLists.Count() - 1].gender.ToString();
            lblage.Text = patientLists[patientLists.Count() - 1].age.ToString();
            lblcontact.Text = patientLists[patientLists.Count() - 1].contactnum.ToString();
            lblbloodgroup.Text = patientLists[patientLists.Count() - 1].bloodgroup.ToString();
            lblcity.Text = patientLists[patientLists.Count() - 1].city.ToString();
            lblzone.Text = patientLists[patientLists.Count() - 1].zone.ToString();
            //if ()
            lbldiseasefound.Text= patientLists[patientLists.Count() - 1].diseasefound.ToString();

            //lbldiseasefound.Text = Symptom_selection.disease_found; // for displaying disease in final report


            // this is for bar graph
            this.chart1.Series["Disease"].Points.AddXY("measles", probList[probList.Count() - 1].measles_probability.ToString());
            this.chart1.Series["Disease"].Points.AddXY("influenza", probList[probList.Count() - 1].influenza_probability.ToString());
            this.chart1.Series["Disease"].Points.AddXY("Tuberculosis", probList[probList.Count() - 1].tuberculosis_probability.ToString());
            this.chart1.Series["Disease"].Points.AddXY("mumps", probList[probList.Count() - 1].mumps_probability.ToString());


            Probability_of_disease pod = new Probability_of_disease();
            double mala1 = pod.measles_probability;
            double kala2 = pod.influenza_probability;
            double tubo3 = pod.tuberculosis_probability;
            double typo4 = pod.mumps_probability;

            //double[] array1 = { mala1,kala2,tubo3,typo4};

            // Find maximum probability of disease
            //Console.WriteLine(array1.Max());
            //df.Text = array1.Max().ToString();

            string symptoms = "";
            int count = 0;
            for (int i=0; i< symptomList.Count(); i++)
            {
                if ( symptomList[i].patientID == patientID)
                {
                    count++;
                    if (count%3 == 0)
                    {
                        symptoms = symptoms + symptomList[i].symptom + ",\n";

                    }else
                    symptoms = symptoms + symptomList[i].symptom + ", ";
                }
            }

            //lblDisplaySymptom.Text = symptoms;

            lblDisplaySymptom.Text = symptoms;
            List<PatientDetail> patientList = new List<PatientDetail>();
            patientList = dc.PatientDetails.ToList();
            List<MedicineDetail> medicineList = dc.MedicineDetails.ToList();
            string medicinePrescribed = "";
            for (int i = 0; i < dc.MedicineDetails.Count(); i++)
            {
                int j;
                for (j = 0; j < dc.PatientDetails.Count(); j++)
                {
                    if (patientList[j].patientID == patientID)
                    {
                        break;
                    }
                }

                //MessageBox.Show(medicineList[i].DiseaseName);
                if (patientList[j].diseasefound == medicineList[i].DiseaseName)
                {
                    medicinePrescribed = medicinePrescribed + medicineList[i].MedicineName+ ", ";
                  //  MessageBox.Show(medicinePrescribed.ToString());
                }




            }

            lblMedicinePrescribe.Text = medicinePrescribed;
            }

            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void df_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblPatientID_Click(object sender, EventArgs e)
        {

        }

        private void LBLID_Click(object sender, EventArgs e)
        {

        }

        private void lblzone_Click(object sender, EventArgs e)
        {

        }

        private void lblcity_Click(object sender, EventArgs e)
        {

        }

        private void lblbloodgroup_Click(object sender, EventArgs e)
        {

        }

        private void lblcontact_Click(object sender, EventArgs e)
        {

        }

        private void lblage_Click(object sender, EventArgs e)
        {

        }

        private void lblgender_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblDisplaySymptom_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void lblMedicinePrescribe_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void viewreport_level2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        Bitmap bmp;
        private void metroButton1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            //printPreviewDialog1.ShowDialog();
            //printDocument1.Print();

          
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        

        private void diseasediagnogrpbox_Enter(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}      
    
