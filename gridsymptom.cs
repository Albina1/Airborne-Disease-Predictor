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
    public partial class gridsymptom : UserControl
    {
        MedicalDiagnosisDBDataContext dc;
        public gridsymptom()
        {
            InitializeComponent();

            dc = new MedicalDiagnosisDBDataContext();

            gridviewmumps.DataSource= dc.mumps_Diseases;
            gridmeasles.DataSource = dc.measlesDiseases;
            gridviewtber.DataSource = dc.tubuerculosisDiseases;
            gridviewinfluenza.DataSource = dc.influenzaDiseases;


            //gridviewkalazar.DataSource = dc.influenzaDiseases;
            //gridviewTB.DataSource = dc.tubuerculosisDiseases;

        }

        private void load_symptoms()
        {
            dc = new MedicalDiagnosisDBDataContext();
            gridviewmumps.DataSource = dc.mumps_Diseases;
            gridmeasles.DataSource = dc.measlesDiseases;
            gridviewinfluenza.DataSource = dc.influenzaDiseases;

        }
        private void gridsymptom_Load(object sender, EventArgs e)
        {
            load_symptoms();
        }

        private void gridmumps_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }

        private void gridTB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
