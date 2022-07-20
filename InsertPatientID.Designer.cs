namespace FInal_project
{
    partial class InsertPatientID
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
            this.validatePatientID = new MetroFramework.Controls.MetroButton();
            this.btncancel = new MetroFramework.Controls.MetroButton();
            this.txtpatientID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtpatientContactnum = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // validatePatientID
            // 
            this.validatePatientID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.validatePatientID.Location = new System.Drawing.Point(544, 296);
            this.validatePatientID.Name = "validatePatientID";
            this.validatePatientID.Size = new System.Drawing.Size(92, 34);
            this.validatePatientID.TabIndex = 2;
            this.validatePatientID.Text = "Validate";
            this.validatePatientID.UseSelectable = true;
            this.validatePatientID.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btncancel
            // 
            this.btncancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancel.Location = new System.Drawing.Point(645, 296);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(84, 34);
            this.btncancel.TabIndex = 3;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseSelectable = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // txtpatientID
            // 
            this.txtpatientID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtpatientID.CustomButton.Image = null;
            this.txtpatientID.CustomButton.Location = new System.Drawing.Point(165, 2);
            this.txtpatientID.CustomButton.Name = "";
            this.txtpatientID.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtpatientID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtpatientID.CustomButton.TabIndex = 1;
            this.txtpatientID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtpatientID.CustomButton.UseSelectable = true;
            this.txtpatientID.CustomButton.Visible = false;
            this.txtpatientID.Lines = new string[0];
            this.txtpatientID.Location = new System.Drawing.Point(544, 219);
            this.txtpatientID.MaxLength = 32767;
            this.txtpatientID.Name = "txtpatientID";
            this.txtpatientID.PasswordChar = '\0';
            this.txtpatientID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpatientID.SelectedText = "";
            this.txtpatientID.SelectionLength = 0;
            this.txtpatientID.SelectionStart = 0;
            this.txtpatientID.ShortcutsEnabled = true;
            this.txtpatientID.Size = new System.Drawing.Size(185, 22);
            this.txtpatientID.TabIndex = 0;
            this.txtpatientID.UseSelectable = true;
            this.txtpatientID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtpatientID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtpatientID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpatientID_KeyDown);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(455, 219);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Patient ID :";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // txtpatientContactnum
            // 
            this.txtpatientContactnum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtpatientContactnum.CustomButton.Image = null;
            this.txtpatientContactnum.CustomButton.Location = new System.Drawing.Point(165, 2);
            this.txtpatientContactnum.CustomButton.Name = "";
            this.txtpatientContactnum.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtpatientContactnum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtpatientContactnum.CustomButton.TabIndex = 1;
            this.txtpatientContactnum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtpatientContactnum.CustomButton.UseSelectable = true;
            this.txtpatientContactnum.CustomButton.Visible = false;
            this.txtpatientContactnum.Lines = new string[0];
            this.txtpatientContactnum.Location = new System.Drawing.Point(544, 256);
            this.txtpatientContactnum.MaxLength = 32767;
            this.txtpatientContactnum.Name = "txtpatientContactnum";
            this.txtpatientContactnum.PasswordChar = '\0';
            this.txtpatientContactnum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpatientContactnum.SelectedText = "";
            this.txtpatientContactnum.SelectionLength = 0;
            this.txtpatientContactnum.SelectionStart = 0;
            this.txtpatientContactnum.ShortcutsEnabled = true;
            this.txtpatientContactnum.Size = new System.Drawing.Size(185, 22);
            this.txtpatientContactnum.TabIndex = 1;
            this.txtpatientContactnum.UseSelectable = true;
            this.txtpatientContactnum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtpatientContactnum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtpatientContactnum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpatientContactnum_KeyDown);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(415, 259);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(111, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Contact Number:";
            // 
            // InsertPatientID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 513);
            this.Controls.Add(this.txtpatientContactnum);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.validatePatientID);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.txtpatientID);
            this.Controls.Add(this.metroLabel1);
            this.Name = "InsertPatientID";
            this.Text = "Please !! Insert Patient\'s ID";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InsertPatientID_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton validatePatientID;
        private MetroFramework.Controls.MetroButton btncancel;
        private MetroFramework.Controls.MetroTextBox txtpatientID;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtpatientContactnum;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}