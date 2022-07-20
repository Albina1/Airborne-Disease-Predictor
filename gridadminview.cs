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
    public partial class gridadminview : UserControl
    {
        MedicalDiagnosisDBDataContext dc;
        public gridadminview()
        {
            InitializeComponent();
            dc = new MedicalDiagnosisDBDataContext();

            metroadmin.DataSource = dc.AdminPanel2s;
        }

        private void load_gridadminview()
        {
            dc = new MedicalDiagnosisDBDataContext();
            metroadmin.DataSource = dc.AdminPanel2s;

        }

        private void metroadmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroadmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MedicalDiagnosisDBDataContext dc = new MedicalDiagnosisDBDataContext();

            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {

                int id = Convert.ToInt32(metroadmin[0, e.RowIndex].Value);
                {
                    if (e.ColumnIndex == metroadmin.Columns["View_admin"].Index)
                    {

                        ViewAdmintab obj = new ViewAdmintab(id);

                        obj.Show();


                    }


                    if (e.ColumnIndex == metroadmin.Columns["Update_admin"].Index)
                    {

                        Update_admin obj = new Update_admin(id);

                        obj.Show();


                    }
                    if (e.ColumnIndex == metroadmin.Columns["Delete_admin"].Index)
                    {
                        //int AdminID= Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                        AdminPanel2 obj = dc.AdminPanel2s.SingleOrDefault(E => E.AdminID == id);
                        dc.AdminPanel2s.DeleteOnSubmit(obj);
                        dc.SubmitChanges();
                        load_gridadminview();


                    }
                }
            }

        }

        

        private void gridadminview_Load(object sender, EventArgs e)
        {
            load_gridadminview();
        }
    }
        }
    
