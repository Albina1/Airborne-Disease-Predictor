namespace FInal_project
{
    partial class frmain
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
            this.mpanel = new MetroFramework.Controls.MetroPanel();
            this.mlback = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // mpanel
            // 
            this.mpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mpanel.HorizontalScrollbarBarColor = true;
            this.mpanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mpanel.HorizontalScrollbarSize = 10;
            this.mpanel.Location = new System.Drawing.Point(23, 55);
            this.mpanel.Name = "mpanel";
            this.mpanel.Size = new System.Drawing.Size(890, 459);
            this.mpanel.TabIndex = 0;
            this.mpanel.VerticalScrollbarBarColor = true;
            this.mpanel.VerticalScrollbarHighlightOnWheel = false;
            this.mpanel.VerticalScrollbarSize = 10;
            this.mpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mpanel_Paint);
            // 
            // mlback
            // 
            this.mlback.ForeColor = System.Drawing.Color.DodgerBlue;
            this.mlback.Image = global::FInal_project.Properties.Resources.left;
            this.mlback.ImageSize = 33;
            this.mlback.Location = new System.Drawing.Point(26, 15);
            this.mlback.Name = "mlback";
            this.mlback.Size = new System.Drawing.Size(48, 38);
            this.mlback.TabIndex = 1;
            this.mlback.UseSelectable = true;
            this.mlback.Click += new System.EventHandler(this.mback_Click);
            // 
            // frmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 547);
            this.Controls.Add(this.mlback);
            this.Controls.Add(this.mpanel);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "frmain";
            this.Text = "       Air Borne Disease Predictor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mpanel;
        private MetroFramework.Controls.MetroLink mlback;


    }
}

