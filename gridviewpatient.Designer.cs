namespace FInal_project
{
    partial class gridviewpatient
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metropatient = new MetroFramework.Controls.MetroGrid();
            this.patientDetailBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.medicalDiagonsisDBDataSet13 = new FInal_project.MedicalDiagonsisDBDataSet13();
            this.patientDetailBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.medicalDiagonsisDBDataSet11 = new FInal_project.MedicalDiagonsisDBDataSet1();
            this.patientDetailBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.medicalDiagonsisDBDataSet1 = new FInal_project.MedicalDiagonsisDBDataSet();
            this.patientDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientDetailTableAdapter = new FInal_project.MedicalDiagonsisDBDataSetTableAdapters.PatientDetailTableAdapter();
            this.patientDetailBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtfilterDB = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.patientDetailTableAdapter1 = new FInal_project.MedicalDiagonsisDBDataSet1TableAdapters.PatientDetailTableAdapter();
            this.patientDetailTableAdapter2 = new FInal_project.MedicalDiagonsisDBDataSet13TableAdapters.PatientDetailTableAdapter();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientfnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientmiddlenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientlnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodgroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diseasefoundDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View_Patient = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Update_Patient = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete_patient = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Ward = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metropatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDiagonsisDBDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDiagonsisDBDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDiagonsisDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // metropatient
            // 
            this.metropatient.AllowUserToAddRows = false;
            this.metropatient.AllowUserToDeleteRows = false;
            this.metropatient.AllowUserToResizeRows = false;
            this.metropatient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metropatient.AutoGenerateColumns = false;
            this.metropatient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metropatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metropatient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metropatient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metropatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metropatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metropatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIDDataGridViewTextBoxColumn,
            this.patientfnameDataGridViewTextBoxColumn,
            this.patientmiddlenameDataGridViewTextBoxColumn,
            this.patientlnameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.contactnumDataGridViewTextBoxColumn,
            this.bloodgroupDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.zoneDataGridViewTextBoxColumn,
            this.diseasefoundDataGridViewTextBoxColumn,
            this.View_Patient,
            this.Update_Patient,
            this.Delete_patient,
            this.Ward,
            this.Column1,
            this.Column2,
            this.Column3});
            this.metropatient.DataSource = this.patientDetailBindingSource4;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metropatient.DefaultCellStyle = dataGridViewCellStyle2;
            this.metropatient.EnableHeadersVisualStyles = false;
            this.metropatient.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metropatient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metropatient.Location = new System.Drawing.Point(3, 69);
            this.metropatient.Name = "metropatient";
            this.metropatient.ReadOnly = true;
            this.metropatient.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metropatient.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metropatient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metropatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metropatient.Size = new System.Drawing.Size(1257, 374);
            this.metropatient.TabIndex = 20;
            this.metropatient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroadmin_CellClick);
            this.metropatient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroadmin_CellContentClick);
            // 
            // patientDetailBindingSource4
            // 
            this.patientDetailBindingSource4.DataMember = "PatientDetail";
            this.patientDetailBindingSource4.DataSource = this.medicalDiagonsisDBDataSet13;
            // 
            // medicalDiagonsisDBDataSet13
            // 
            this.medicalDiagonsisDBDataSet13.DataSetName = "MedicalDiagonsisDBDataSet13";
            this.medicalDiagonsisDBDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientDetailBindingSource3
            // 
            this.patientDetailBindingSource3.DataMember = "PatientDetail";
            this.patientDetailBindingSource3.DataSource = this.medicalDiagonsisDBDataSet11;
            // 
            // medicalDiagonsisDBDataSet11
            // 
            this.medicalDiagonsisDBDataSet11.DataSetName = "MedicalDiagonsisDBDataSet1";
            this.medicalDiagonsisDBDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientDetailBindingSource2
            // 
            this.patientDetailBindingSource2.DataMember = "PatientDetail";
            this.patientDetailBindingSource2.DataSource = this.medicalDiagonsisDBDataSet1;
            // 
            // medicalDiagonsisDBDataSet1
            // 
            this.medicalDiagonsisDBDataSet1.DataSetName = "MedicalDiagonsisDBDataSet1";
            this.medicalDiagonsisDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientDetailBindingSource
            // 
            this.patientDetailBindingSource.DataMember = "PatientDetail";
            this.patientDetailBindingSource.DataSource = this.medicalDiagonsisDBDataSet1;
            // 
            // patientDetailTableAdapter
            // 
            this.patientDetailTableAdapter.ClearBeforeFill = true;
            // 
            // patientDetailBindingSource1
            // 
            this.patientDetailBindingSource1.DataMember = "PatientDetail";
            this.patientDetailBindingSource1.DataSource = this.medicalDiagonsisDBDataSet1;
            // 
            // txtfilterDB
            // 
            // 
            // 
            // 
            this.txtfilterDB.CustomButton.Image = null;
            this.txtfilterDB.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txtfilterDB.CustomButton.Name = "";
            this.txtfilterDB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtfilterDB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtfilterDB.CustomButton.TabIndex = 1;
            this.txtfilterDB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtfilterDB.CustomButton.UseSelectable = true;
            this.txtfilterDB.CustomButton.Visible = false;
            this.txtfilterDB.Lines = new string[0];
            this.txtfilterDB.Location = new System.Drawing.Point(165, 27);
            this.txtfilterDB.MaxLength = 32767;
            this.txtfilterDB.Name = "txtfilterDB";
            this.txtfilterDB.PasswordChar = '\0';
            this.txtfilterDB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtfilterDB.SelectedText = "";
            this.txtfilterDB.SelectionLength = 0;
            this.txtfilterDB.SelectionStart = 0;
            this.txtfilterDB.ShortcutsEnabled = true;
            this.txtfilterDB.Size = new System.Drawing.Size(164, 23);
            this.txtfilterDB.TabIndex = 28;
            this.txtfilterDB.UseSelectable = true;
            this.txtfilterDB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtfilterDB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtfilterDB.TextChanged += new System.EventHandler(this.txtfilterDB_TextChanged);
            this.txtfilterDB.Click += new System.EventHandler(this.txtfilterDB_Click_1);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(31, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(112, 19);
            this.metroLabel1.TabIndex = 27;
            this.metroLabel1.Text = "Search for Patient";
            // 
            // patientDetailTableAdapter1
            // 
            this.patientDetailTableAdapter1.ClearBeforeFill = true;
            // 
            // patientDetailTableAdapter2
            // 
            this.patientDetailTableAdapter2.ClearBeforeFill = true;
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "patientID";
            this.patientIDDataGridViewTextBoxColumn.FillWeight = 80F;
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "patientID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            this.patientIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.patientIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // patientfnameDataGridViewTextBoxColumn
            // 
            this.patientfnameDataGridViewTextBoxColumn.DataPropertyName = "patient_fname";
            this.patientfnameDataGridViewTextBoxColumn.FillWeight = 80F;
            this.patientfnameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.patientfnameDataGridViewTextBoxColumn.Name = "patientfnameDataGridViewTextBoxColumn";
            this.patientfnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.patientfnameDataGridViewTextBoxColumn.Width = 80;
            // 
            // patientmiddlenameDataGridViewTextBoxColumn
            // 
            this.patientmiddlenameDataGridViewTextBoxColumn.DataPropertyName = "patient_middlename";
            this.patientmiddlenameDataGridViewTextBoxColumn.FillWeight = 80F;
            this.patientmiddlenameDataGridViewTextBoxColumn.HeaderText = "Middle Name";
            this.patientmiddlenameDataGridViewTextBoxColumn.Name = "patientmiddlenameDataGridViewTextBoxColumn";
            this.patientmiddlenameDataGridViewTextBoxColumn.ReadOnly = true;
            this.patientmiddlenameDataGridViewTextBoxColumn.Width = 80;
            // 
            // patientlnameDataGridViewTextBoxColumn
            // 
            this.patientlnameDataGridViewTextBoxColumn.DataPropertyName = "patient_lname";
            this.patientlnameDataGridViewTextBoxColumn.FillWeight = 80F;
            this.patientlnameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.patientlnameDataGridViewTextBoxColumn.Name = "patientlnameDataGridViewTextBoxColumn";
            this.patientlnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.patientlnameDataGridViewTextBoxColumn.Width = 80;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.FillWeight = 80F;
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Width = 80;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.FillWeight = 80F;
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            this.ageDataGridViewTextBoxColumn.Width = 80;
            // 
            // contactnumDataGridViewTextBoxColumn
            // 
            this.contactnumDataGridViewTextBoxColumn.DataPropertyName = "contactnum";
            this.contactnumDataGridViewTextBoxColumn.FillWeight = 80F;
            this.contactnumDataGridViewTextBoxColumn.HeaderText = "Contact ";
            this.contactnumDataGridViewTextBoxColumn.Name = "contactnumDataGridViewTextBoxColumn";
            this.contactnumDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactnumDataGridViewTextBoxColumn.Width = 80;
            // 
            // bloodgroupDataGridViewTextBoxColumn
            // 
            this.bloodgroupDataGridViewTextBoxColumn.DataPropertyName = "bloodgroup";
            this.bloodgroupDataGridViewTextBoxColumn.FillWeight = 80F;
            this.bloodgroupDataGridViewTextBoxColumn.HeaderText = "Blood Group";
            this.bloodgroupDataGridViewTextBoxColumn.Name = "bloodgroupDataGridViewTextBoxColumn";
            this.bloodgroupDataGridViewTextBoxColumn.ReadOnly = true;
            this.bloodgroupDataGridViewTextBoxColumn.Width = 80;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.FillWeight = 80F;
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityDataGridViewTextBoxColumn.Width = 80;
            // 
            // zoneDataGridViewTextBoxColumn
            // 
            this.zoneDataGridViewTextBoxColumn.DataPropertyName = "Ward";
            this.zoneDataGridViewTextBoxColumn.FillWeight = 80F;
            this.zoneDataGridViewTextBoxColumn.HeaderText = "Ward";
            this.zoneDataGridViewTextBoxColumn.Name = "zoneDataGridViewTextBoxColumn";
            this.zoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.zoneDataGridViewTextBoxColumn.Width = 80;
            // 
            // diseasefoundDataGridViewTextBoxColumn
            // 
            this.diseasefoundDataGridViewTextBoxColumn.DataPropertyName = "diseasefound";
            this.diseasefoundDataGridViewTextBoxColumn.FillWeight = 80F;
            this.diseasefoundDataGridViewTextBoxColumn.HeaderText = "DiseaseFound";
            this.diseasefoundDataGridViewTextBoxColumn.Name = "diseasefoundDataGridViewTextBoxColumn";
            this.diseasefoundDataGridViewTextBoxColumn.ReadOnly = true;
            this.diseasefoundDataGridViewTextBoxColumn.Width = 80;
            // 
            // View_Patient
            // 
            this.View_Patient.FillWeight = 90F;
            this.View_Patient.HeaderText = "Action";
            this.View_Patient.Name = "View_Patient";
            this.View_Patient.ReadOnly = true;
            this.View_Patient.Text = "View";
            this.View_Patient.UseColumnTextForButtonValue = true;
            // 
            // Update_Patient
            // 
            this.Update_Patient.FillWeight = 90F;
            this.Update_Patient.HeaderText = "Action";
            this.Update_Patient.Name = "Update_Patient";
            this.Update_Patient.ReadOnly = true;
            this.Update_Patient.Text = "Update";
            this.Update_Patient.UseColumnTextForButtonValue = true;
            // 
            // Delete_patient
            // 
            this.Delete_patient.FillWeight = 90F;
            this.Delete_patient.HeaderText = "Action";
            this.Delete_patient.Name = "Delete_patient";
            this.Delete_patient.ReadOnly = true;
            this.Delete_patient.Text = "Delete";
            this.Delete_patient.UseColumnTextForButtonValue = true;
            this.Delete_patient.Width = 90;
            // 
            // Ward
            // 
            this.Ward.DataPropertyName = "zone";
            this.Ward.HeaderText = "Ward";
            this.Ward.Name = "Ward";
            this.Ward.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "zone";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "zone";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "zone";
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // gridviewpatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtfilterDB);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metropatient);
            this.Name = "gridviewpatient";
            this.Size = new System.Drawing.Size(1280, 461);
            this.Load += new System.EventHandler(this.gridviewpatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metropatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDiagonsisDBDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDiagonsisDBDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDiagonsisDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metropatient;
        private System.Windows.Forms.BindingSource patientDetailBindingSource;
        private MedicalDiagonsisDBDataSet medicalDiagonsisDBDataSet1;
        private MedicalDiagonsisDBDataSetTableAdapters.PatientDetailTableAdapter patientDetailTableAdapter;
        private System.Windows.Forms.BindingSource patientDetailBindingSource1;
        private System.Windows.Forms.BindingSource patientDetailBindingSource2;
        private MetroFramework.Controls.MetroTextBox txtfilterDB;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.BindingSource patientDetailBindingSource3;
        private MedicalDiagonsisDBDataSet1 medicalDiagonsisDBDataSet11;
        private MedicalDiagonsisDBDataSet1TableAdapters.PatientDetailTableAdapter patientDetailTableAdapter1;
        private System.Windows.Forms.BindingSource patientDetailBindingSource4;
        private MedicalDiagonsisDBDataSet13 medicalDiagonsisDBDataSet13;
        private MedicalDiagonsisDBDataSet13TableAdapters.PatientDetailTableAdapter patientDetailTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientfnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientmiddlenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientlnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodgroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diseasefoundDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn View_Patient;
        private System.Windows.Forms.DataGridViewButtonColumn Update_Patient;
        private System.Windows.Forms.DataGridViewButtonColumn Delete_patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ward;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
