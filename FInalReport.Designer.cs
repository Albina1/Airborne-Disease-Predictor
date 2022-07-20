namespace FInal_project
{
    partial class FInalReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.reportRichtextbox = new System.Windows.Forms.RichTextBox();
            this.lblMedicinePrescribe = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbldiseasefound = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.diseasediagnogrpbox = new System.Windows.Forms.GroupBox();
            this.lblDisplaySymptom = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblfullname = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblcontact = new System.Windows.Forms.Label();
            this.lblbloodgroup = new System.Windows.Forms.Label();
            this.lblcity = new System.Windows.Forms.Label();
            this.lblzone = new System.Windows.Forms.Label();
            this.LBLID = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btncancel = new MetroFramework.Controls.MetroButton();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.diseasediagnogrpbox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportRichtextbox
            // 
            this.reportRichtextbox.Location = new System.Drawing.Point(212, 33);
            this.reportRichtextbox.Name = "reportRichtextbox";
            this.reportRichtextbox.Size = new System.Drawing.Size(821, 681);
            this.reportRichtextbox.TabIndex = 0;
            this.reportRichtextbox.Text = "";
            this.reportRichtextbox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // lblMedicinePrescribe
            // 
            this.lblMedicinePrescribe.AutoSize = true;
            this.lblMedicinePrescribe.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicinePrescribe.Location = new System.Drawing.Point(262, 37);
            this.lblMedicinePrescribe.Name = "lblMedicinePrescribe";
            this.lblMedicinePrescribe.Size = new System.Drawing.Size(81, 19);
            this.lblMedicinePrescribe.TabIndex = 9;
            this.lblMedicinePrescribe.Text = "\"Medicine\"";
            this.lblMedicinePrescribe.Click += new System.EventHandler(this.lblMedicinePrescribe_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblMedicinePrescribe);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(233, 587);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(717, 68);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Medicine Suggested:";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(27, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(236, 57);
            this.label12.TabIndex = 2;
            this.label12.Text = "You should probably take the drug: \r\n\r\n \r\n";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "You\'re probably diagonsised with the Disease : \r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbldiseasefound
            // 
            this.lbldiseasefound.AutoSize = true;
            this.lbldiseasefound.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiseasefound.Location = new System.Drawing.Point(349, 37);
            this.lbldiseasefound.Name = "lbldiseasefound";
            this.lbldiseasefound.Size = new System.Drawing.Size(118, 19);
            this.lbldiseasefound.TabIndex = 9;
            this.lbldiseasefound.Text = "DISEASE_FOUND";
            this.lbldiseasefound.Click += new System.EventHandler(this.df_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(17, 59);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Disease";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(644, 179);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // diseasediagnogrpbox
            // 
            this.diseasediagnogrpbox.Controls.Add(this.chart1);
            this.diseasediagnogrpbox.Controls.Add(this.lbldiseasefound);
            this.diseasediagnogrpbox.Controls.Add(this.label2);
            this.diseasediagnogrpbox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diseasediagnogrpbox.Location = new System.Drawing.Point(244, 336);
            this.diseasediagnogrpbox.Name = "diseasediagnogrpbox";
            this.diseasediagnogrpbox.Size = new System.Drawing.Size(717, 245);
            this.diseasediagnogrpbox.TabIndex = 16;
            this.diseasediagnogrpbox.TabStop = false;
            this.diseasediagnogrpbox.Text = "Disease Diagnosised:";
            this.diseasediagnogrpbox.Enter += new System.EventHandler(this.diseasediagnogrpbox_Enter);
            // 
            // lblDisplaySymptom
            // 
            this.lblDisplaySymptom.AutoSize = true;
            this.lblDisplaySymptom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplaySymptom.Location = new System.Drawing.Point(27, 27);
            this.lblDisplaySymptom.Name = "lblDisplaySymptom";
            this.lblDisplaySymptom.Size = new System.Drawing.Size(132, 19);
            this.lblDisplaySymptom.TabIndex = 0;
            this.lblDisplaySymptom.Text = "lblDisplaySymptom";
            this.lblDisplaySymptom.Click += new System.EventHandler(this.lblDisplaySymptom_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDisplaySymptom);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(244, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(717, 142);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Symptoms Selected :";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Full Name:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(27, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 19);
            this.label13.TabIndex = 1;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(254, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "City :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Blood Group:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(449, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ward:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(445, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Contact Number:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 19);
            this.label10.TabIndex = 7;
            this.label10.Text = "Gender:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // lblfullname
            // 
            this.lblfullname.AutoSize = true;
            this.lblfullname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfullname.Location = new System.Drawing.Point(129, 27);
            this.lblfullname.Name = "lblfullname";
            this.lblfullname.Size = new System.Drawing.Size(74, 19);
            this.lblfullname.TabIndex = 8;
            this.lblfullname.Text = "Full Name";
            this.lblfullname.Click += new System.EventHandler(this.label11_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(111, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 19);
            this.label14.TabIndex = 8;
            this.label14.Click += new System.EventHandler(this.label11_Click);
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(129, 51);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(56, 19);
            this.lblgender.TabIndex = 9;
            this.lblgender.Text = "Gender";
            this.lblgender.Click += new System.EventHandler(this.lblgender_Click);
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(300, 51);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(33, 19);
            this.lblage.TabIndex = 10;
            this.lblage.Text = "age";
            this.lblage.Click += new System.EventHandler(this.lblage_Click);
            // 
            // lblcontact
            // 
            this.lblcontact.AutoSize = true;
            this.lblcontact.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontact.Location = new System.Drawing.Point(580, 55);
            this.lblcontact.Name = "lblcontact";
            this.lblcontact.Size = new System.Drawing.Size(57, 19);
            this.lblcontact.TabIndex = 11;
            this.lblcontact.Text = "contact";
            this.lblcontact.Click += new System.EventHandler(this.lblcontact_Click);
            // 
            // lblbloodgroup
            // 
            this.lblbloodgroup.AutoSize = true;
            this.lblbloodgroup.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbloodgroup.Location = new System.Drawing.Point(133, 76);
            this.lblbloodgroup.Name = "lblbloodgroup";
            this.lblbloodgroup.Size = new System.Drawing.Size(28, 19);
            this.lblbloodgroup.TabIndex = 12;
            this.lblbloodgroup.Text = "BG";
            this.lblbloodgroup.Click += new System.EventHandler(this.lblbloodgroup_Click);
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcity.Location = new System.Drawing.Point(300, 76);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(32, 19);
            this.lblcity.TabIndex = 13;
            this.lblcity.Text = "city";
            this.lblcity.Click += new System.EventHandler(this.lblcity_Click);
            // 
            // lblzone
            // 
            this.lblzone.AutoSize = true;
            this.lblzone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblzone.Location = new System.Drawing.Point(580, 78);
            this.lblzone.Name = "lblzone";
            this.lblzone.Size = new System.Drawing.Size(41, 19);
            this.lblzone.TabIndex = 14;
            this.lblzone.Text = "ward";
            this.lblzone.Click += new System.EventHandler(this.lblzone_Click);
            // 
            // LBLID
            // 
            this.LBLID.AutoSize = true;
            this.LBLID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLID.Location = new System.Drawing.Point(445, 32);
            this.LBLID.Name = "LBLID";
            this.LBLID.Size = new System.Drawing.Size(77, 19);
            this.LBLID.TabIndex = 15;
            this.LBLID.Text = "Patient ID:";
            this.LBLID.Click += new System.EventHandler(this.LBLID_Click);
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.Location = new System.Drawing.Point(580, 31);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(23, 19);
            this.lblPatientID.TabIndex = 16;
            this.lblPatientID.Text = "ID";
            this.lblPatientID.Click += new System.EventHandler(this.lblPatientID_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPatientID);
            this.groupBox1.Controls.Add(this.LBLID);
            this.groupBox1.Controls.Add(this.lblzone);
            this.groupBox1.Controls.Add(this.lblcity);
            this.groupBox1.Controls.Add(this.lblbloodgroup);
            this.groupBox1.Controls.Add(this.lblcontact);
            this.groupBox1.Controls.Add(this.lblage);
            this.groupBox1.Controls.Add(this.lblgender);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lblfullname);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(244, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 104);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient\'s Detail:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(259, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 19);
            this.label9.TabIndex = 6;
            this.label9.Text = "Age:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "MEDICAL REPORT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btncancel
            // 
            this.btncancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancel.Location = new System.Drawing.Point(1071, 649);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(113, 40);
            this.btncancel.TabIndex = 19;
            this.btncancel.Text = "Close";
            this.btncancel.UseSelectable = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // FInalReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 709);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.diseasediagnogrpbox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportRichtextbox);
            this.Name = "FInalReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FInalReport_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.diseasediagnogrpbox.ResumeLayout(false);
            this.diseasediagnogrpbox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox reportRichtextbox;
        private System.Windows.Forms.Label lblMedicinePrescribe;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbldiseasefound;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox diseasediagnogrpbox;
        private System.Windows.Forms.Label lblDisplaySymptom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblfullname;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblcontact;
        private System.Windows.Forms.Label lblbloodgroup;
        private System.Windows.Forms.Label lblcity;
        private System.Windows.Forms.Label lblzone;
        private System.Windows.Forms.Label LBLID;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        //private aboutus aboutus1;
        private System.Windows.Forms.Label label12;
        private MetroFramework.Controls.MetroButton btncancel;
    }
}