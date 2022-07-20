using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInal_project
{
    public partial class gridviewpatient : UserControl
    {
        MedicalDiagnosisDBDataContext dc;
        public gridviewpatient()
        {
            InitializeComponent();
            dc = new MedicalDiagnosisDBDataContext();

            metropatient.DataSource = dc.PatientDetails;
        }

        private void load_gridviewpatient()
        {
            dc = new MedicalDiagnosisDBDataContext();
            metropatient.DataSource = dc.PatientDetails;

        }

        private void gridviewpatient_Load(object sender, EventArgs e)
        {
            load_gridviewpatient();

        }

        private void metroadmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {

                int id = Convert.ToInt32(metropatient[0, e.RowIndex].Value);
                {
                    if (e.ColumnIndex == metropatient.Columns["View_Patient"].Index)
                    {
                        collection_viewpatient obj1 = new collection_viewpatient(id);

                        obj1.Show();
                    }

                    if (e.ColumnIndex == metropatient.Columns["Update_Patient"].Index)
                    {
                        //MessageBox.Show("thifasdfa");
                        Update_patient obj2 = new Update_patient(id);

                        obj2.Show();
                        load_gridviewpatient(); 


                    }
                    if (e.ColumnIndex == metropatient.Columns["Delete_patient"].Index)
                    {

                        //int AdminID= Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                        PatientDetail obj = dc.PatientDetails.SingleOrDefault(E => E.patientID == id);
                        dc.PatientDetails.DeleteOnSubmit(obj);
                        dc.SubmitChanges();
                        load_gridviewpatient();  // to refresh data grid everytime we make action
                    }
                }
            }
        }
            


        private void metroadmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void btn_filter_search_Click(object sender, EventArgs e)
        {
            
        }

        private void txtfilterDB_Click_1(object sender, EventArgs e)
        {
            //metropatient.DataSource = dc.PatientDetails.Where(x => x.patient_fname.Contains(txtfilterDB.Text)
            //                                                  || x.patient_lname.Contains(txtfilterDB.Text)
            //                                                  || x.gender.Contains(txtfilterDB.Text)
            //                                                  || x.age.Contains(txtfilterDB.Text)
            //                                                  || x.city.Contains(txtfilterDB.Text)).ToList();
            //list here more for filtering
        }

       
        

        private void txtfilterDB_TextChanged(object sender, EventArgs e)
        {
            metropatient.DataSource = dc.PatientDetails.Where(x => x.patient_fname.Contains(txtfilterDB.Text)
                                                              || x.patient_lname.Contains(txtfilterDB.Text)
                                                              || x.patient_middlename.Contains(txtfilterDB.Text)
                                                              || x.gender.Contains(txtfilterDB.Text)
                                                              || x.age.Contains(txtfilterDB.Text)
                                                              || x.city.Contains(txtfilterDB.Text)
                                                              || x.bloodgroup.Contains(txtfilterDB.Text)
                                                              || x.zone.Contains(txtfilterDB.Text)).ToList();
            // list db entity for more filter option
                                                             
        }
    


}
}




