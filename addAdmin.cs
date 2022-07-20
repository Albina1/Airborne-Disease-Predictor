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
    public partial class addAdmin : MetroFramework.Forms.MetroForm
    {
        public static int id = -1;
        MedicalDiagnosisDBDataContext dc;
        List<AdminPanel2> adminList; 
        public addAdmin()
        {
            InitializeComponent();
        }
        public addAdmin(int Id)
        {
            InitializeComponent();
            id = Id;
            dc = new MedicalDiagnosisDBDataContext();
            adminList = dc.AdminPanel2s.ToList();
        }


        public void load_newAdmin()
        {
            MedicalDiagnosisDBDataContext dc = new MedicalDiagnosisDBDataContext();
            AdminPanel2 obj = new AdminPanel2();
        }


        private void addAdmin_Load(object sender, EventArgs e)
        {
            //btnsave.Show();
            
        }
        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            MedicalDiagnosisDBDataContext dc = new MedicalDiagnosisDBDataContext();

            AdminPanel2 obj = new AdminPanel2();

            obj.first_name = txtadminFname.Text;
            obj.middle_name = txtmiddlename.Text;
            obj.Last_name = txtlastname.Text;
            obj.email_ID = txtadminEmail.Text;
            obj.contact = txtadminContactNUm.Text;
            obj.username = txtadminusername.Text;
            obj.password = txtadminpassword.Text;

            dc.AdminPanel2s.InsertOnSubmit(obj);
            dc.SubmitChanges();
            MessageBox.Show("New Admin Add Sucessfully");
            //settingadmin op = new settingadmin(); //reloading to main page after adding new admin
            //op.Show();



        }

        private void txtadminFname_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            /*foreach (Control ctrl in this.Controls)
            { 
            if (ctrl is TextBox )
            {

                TextBox tb = ctrl as TextBox;
                tb.Clear();
            }
            } */
            txtadminFname.Focus();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void txtmiddlename_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtadminContactNUm_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }

        }

        private void txtadminusername_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtadminFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) 
            {

                e.Handled = true;
            }
            
        }

        private void txtmiddlename_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void txtlastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {

                e.Handled = true;
            }
        }
    }
}
