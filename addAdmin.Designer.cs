namespace FInal_project
{
    partial class addAdmin
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.btnsave = new MetroFramework.Controls.MetroButton();
            this.txtadminFname = new System.Windows.Forms.MaskedTextBox();
            this.txtadminContactNUm = new System.Windows.Forms.MaskedTextBox();
            this.txtadminusername = new System.Windows.Forms.MaskedTextBox();
            this.txtadminpassword = new System.Windows.Forms.MaskedTextBox();
            this.btnclose = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtadminEmail = new System.Windows.Forms.MaskedTextBox();
            this.txtmiddlename = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtlastname = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(62, 84);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Full Name :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(64, 224);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Username:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(64, 253);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(66, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Password:";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(62, 194);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(111, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Contact Number:";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(171, 314);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "&Save";
            this.btnsave.UseSelectable = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtadminFname
            // 
            this.txtadminFname.Location = new System.Drawing.Point(180, 84);
            this.txtadminFname.Name = "txtadminFname";
            this.txtadminFname.Size = new System.Drawing.Size(143, 20);
            this.txtadminFname.TabIndex = 7;
            this.txtadminFname.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtadminFname_MaskInputRejected);
            this.txtadminFname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtadminFname_KeyPress);
            // 
            // txtadminContactNUm
            // 
            this.txtadminContactNUm.Location = new System.Drawing.Point(180, 194);
            this.txtadminContactNUm.Name = "txtadminContactNUm";
            this.txtadminContactNUm.Size = new System.Drawing.Size(143, 20);
            this.txtadminContactNUm.TabIndex = 9;
            this.txtadminContactNUm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtadminContactNUm_KeyPress);
            // 
            // txtadminusername
            // 
            this.txtadminusername.Location = new System.Drawing.Point(180, 223);
            this.txtadminusername.Name = "txtadminusername";
            this.txtadminusername.Size = new System.Drawing.Size(143, 20);
            this.txtadminusername.TabIndex = 10;
            this.txtadminusername.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtadminusername_MaskInputRejected);
            // 
            // txtadminpassword
            // 
            this.txtadminpassword.Location = new System.Drawing.Point(180, 253);
            this.txtadminpassword.Name = "txtadminpassword";
            this.txtadminpassword.PasswordChar = '*';
            this.txtadminpassword.Size = new System.Drawing.Size(143, 20);
            this.txtadminpassword.TabIndex = 11;
            this.txtadminpassword.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox5_MaskInputRejected);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(284, 314);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 14;
            this.btnclose.Text = "&Close";
            this.btnclose.UseSelectable = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(64, 166);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(60, 19);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Email ID:";
            // 
            // txtadminEmail
            // 
            this.txtadminEmail.Location = new System.Drawing.Point(180, 165);
            this.txtadminEmail.Name = "txtadminEmail";
            this.txtadminEmail.Size = new System.Drawing.Size(143, 20);
            this.txtadminEmail.TabIndex = 16;
            // 
            // txtmiddlename
            // 
            this.txtmiddlename.Location = new System.Drawing.Point(180, 110);
            this.txtmiddlename.Name = "txtmiddlename";
            this.txtmiddlename.Size = new System.Drawing.Size(143, 20);
            this.txtmiddlename.TabIndex = 18;
            this.txtmiddlename.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtmiddlename_MaskInputRejected);
            this.txtmiddlename.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmiddlename_KeyPress);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(62, 110);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(97, 19);
            this.metroLabel5.TabIndex = 17;
            this.metroLabel5.Text = "Middle Name :";
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(180, 136);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(143, 20);
            this.txtlastname.TabIndex = 20;
            this.txtlastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtlastname_KeyPress);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(62, 136);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(65, 19);
            this.metroLabel7.TabIndex = 19;
            this.metroLabel7.Text = "Last Null :";
            // 
            // addAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 491);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txtmiddlename);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtadminEmail);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.txtadminpassword);
            this.Controls.Add(this.txtadminusername);
            this.Controls.Add(this.txtadminContactNUm);
            this.Controls.Add(this.txtadminFname);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Name = "addAdmin";
            this.Text = "Add New Admin";
            this.Load += new System.EventHandler(this.addAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton btnsave;
        private System.Windows.Forms.MaskedTextBox txtadminFname;
        private System.Windows.Forms.MaskedTextBox txtadminContactNUm;
        private System.Windows.Forms.MaskedTextBox txtadminusername;
        private System.Windows.Forms.MaskedTextBox txtadminpassword;
        private MetroFramework.Controls.MetroButton btnclose;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.MaskedTextBox txtadminEmail;
        private System.Windows.Forms.MaskedTextBox txtmiddlename;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.MaskedTextBox txtlastname;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}