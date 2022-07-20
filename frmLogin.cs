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
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {

        MedicalDiagnosisDBDataContext dc;
        List<AdminPanel2> adminList;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            dc = new MedicalDiagnosisDBDataContext();
            adminList = dc.AdminPanel2s.ToList();
            int i;
            int total = adminList.Count();
            int totalMatch = 0;
            for (i = 0; i < total; i++)
            {
                if (txtusername.Text == adminList[i].username && txtpassword.Text == adminList[i].password)
                {
                    totalMatch++;
                    break;
                }
            }
            if (totalMatch == 1)
            {
                txtusername.Text = "";
                txtpassword.Text = "";
                this.Hide();
                if (!frmain.Instance.MetroContainer.Controls.ContainsKey("settingadmin"))
                {
                   
                    settingadmin uc = new settingadmin(adminList[i].username);
                    uc.Dock = DockStyle.Fill;
                    frmain.Instance.MetroContainer.Controls.Add(uc);


                }
                frmain.Instance.MetroContainer.Controls["settingadmin"].BringToFront();
                frmain.Instance.MetroBack.Visible = true;
            }
            else
            {

                MessageBox.Show("Invalid Username Or Password");

            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
