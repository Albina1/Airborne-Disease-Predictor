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
    public partial class collection_viewpatient : MetroFramework.Forms.MetroForm
    {
        public static int id = -1;
        MedicalDiagnosisDBDataContext dc;
        List<PatientDetail> patientList; 

        public collection_viewpatient()
        {
            InitializeComponent();

        }
        public collection_viewpatient(int Id)
        {
            
            InitializeComponent();
            id = Id;
            dc = new MedicalDiagnosisDBDataContext();
            patientList = dc.PatientDetails.ToList();
        }


        
        private void viewpatient_Load(object sender, EventArgs e)
        {
            
            if (id != -1)
            {
                for (int i = 0; i < patientList.Count(); i++)
                {
                    if (patientList[i].patientID == id)
                    {


                        txtfirstname.Text = patientList[i].patient_fname.ToString();

                        if (patientList[i].patient_middlename == null)
                        {
                            txtmiddlename.Text = "";
                        }
                        else

                            txtmiddlename.Text = patientList[i].patient_middlename.ToString();

                        txtlastname.Text = patientList[i].patient_lname.ToString();
                        txtgender.Text = patientList[i].gender.ToString();
                        txtage.Text = patientList[i].age.ToString();
                        txtcontact.Text = patientList[i].contactnum.ToString();
                        txtbloodgroup.Text = patientList[i].bloodgroup.ToString();
                        txtcity.Text = patientList[i].city.ToString();
                        txtzone.Text = patientList[i].zone.ToString();
                        txtdiseasefound.Text= patientList[i].diseasefound.ToString();



                        break;
                    }
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtdiseasefound_Click(object sender, EventArgs e)
        {

        }
    }

      
}