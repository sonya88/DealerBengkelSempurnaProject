namespace Dealer_BengkelSempurna.laporan
{
    partial class Laporan_Penjualan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laporan_Penjualan));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.penjualan1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJEK8 = new Dealer_BengkelSempurna.PROJEK8();
            this.BtnLapPembelian = new System.Windows.Forms.Button();
            this.BtnLapPenjualan = new System.Windows.Forms.Button();
            this.BtnLapRetur = new System.Windows.Forms.Button();
            this.BtnKonfirRetur = new System.Windows.Forms.Button();
            this.BtnKembali = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateAwal = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dateAkhir = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lbJudul = new System.Windows.Forms.Label();
            this.penjualan1TableAdapter = new Dealer_BengkelSempurna.PROJEK8TableAdapters.Penjualan1TableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lbWaktu = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.penjualan1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJEK8)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel12.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // penjualan1BindingSource
            // 
            this.penjualan1BindingSource.DataMember = "Penjualan1";
            this.penjualan1BindingSource.DataSource = this.pROJEK8;
            // 
            // pROJEK8
            // 
            this.pROJEK8.DataSetName = "PROJEK8";
            this.pROJEK8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnLapPembelian
            // 
            this.BtnLapPembelian.FlatAppearance.BorderSize = 0;
            this.BtnLapPembelian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLapPembelian.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLapPembelian.ForeColor = System.Drawing.Color.Black;
            this.BtnLapPembelian.Image = ((System.Drawing.Image)(resources.GetObject("BtnLapPembelian.Image")));
            this.BtnLapPembelian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLapPembelian.Location = new System.Drawing.Point(0, 252);
            this.BtnLapPembelian.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnLapPembelian.Name = "BtnLapPembelian";
            this.BtnLapPembelian.Size = new System.Drawing.Size(315, 55);
            this.BtnLapPembelian.TabIndex = 56;
            this.BtnLapPembelian.Text = "LAPORAN PEMBELIAN";
            this.BtnLapPembelian.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLapPembelian.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLapPembelian.UseVisualStyleBackColor = true;
            this.BtnLapPembelian.Click += new System.EventHandler(this.BtnLapPembelian_Click);
            // 
            // BtnLapPenjualan
            // 
            this.BtnLapPenjualan.FlatAppearance.BorderSize = 0;
            this.BtnLapPenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLapPenjualan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLapPenjualan.ForeColor = System.Drawing.Color.Black;
            this.BtnLapPenjualan.Location = new System.Drawing.Point(0, 315);
            this.BtnLapPenjualan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnLapPenjualan.Name = "BtnLapPenjualan";
            this.BtnLapPenjualan.Size = new System.Drawing.Size(326, 55);
            this.BtnLapPenjualan.TabIndex = 57;
            this.BtnLapPenjualan.Text = "LAPORAN PENJUALAN";
            this.BtnLapPenjualan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLapPenjualan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLapPenjualan.UseVisualStyleBackColor = true;
            this.BtnLapPenjualan.Click += new System.EventHandler(this.BtnLapPenjualan_Click);
            // 
            // BtnLapRetur
            // 
            this.BtnLapRetur.FlatAppearance.BorderSize = 0;
            this.BtnLapRetur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLapRetur.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLapRetur.ForeColor = System.Drawing.Color.Black;
            this.BtnLapRetur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLapRetur.Location = new System.Drawing.Point(0, 374);
            this.BtnLapRetur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnLapRetur.Name = "BtnLapRetur";
            this.BtnLapRetur.Size = new System.Drawing.Size(300, 49);
            this.BtnLapRetur.TabIndex = 58;
            this.BtnLapRetur.Text = "LAPORAN RETUR";
            this.BtnLapRetur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLapRetur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLapRetur.UseVisualStyleBackColor = true;
            this.BtnLapRetur.Click += new System.EventHandler(this.BtnLapRetur_Click);
            // 
            // BtnKonfirRetur
            // 
            this.BtnKonfirRetur.FlatAppearance.BorderSize = 0;
            this.BtnKonfirRetur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKonfirRetur.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKonfirRetur.ForeColor = System.Drawing.Color.Black;
            this.BtnKonfirRetur.Image = ((System.Drawing.Image)(resources.GetObject("BtnKonfirRetur.Image")));
            this.BtnKonfirRetur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKonfirRetur.Location = new System.Drawing.Point(4, 433);
            this.BtnKonfirRetur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnKonfirRetur.Name = "BtnKonfirRetur";
            this.BtnKonfirRetur.Size = new System.Drawing.Size(300, 57);
            this.BtnKonfirRetur.TabIndex = 130;
            this.BtnKonfirRetur.Text = "KONFIRMASI RETUR";
            this.BtnKonfirRetur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKonfirRetur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnKonfirRetur.UseVisualStyleBackColor = true;
            this.BtnKonfirRetur.Click += new System.EventHandler(this.BtnKonfirRetur_Click);
            // 
            // BtnKembali
            // 
            this.BtnKembali.FlatAppearance.BorderSize = 0;
            this.BtnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKembali.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKembali.ForeColor = System.Drawing.Color.Honeydew;
            this.BtnKembali.Image = ((System.Drawing.Image)(resources.GetObject("BtnKembali.Image")));
            this.BtnKembali.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKembali.Location = new System.Drawing.Point(12, 1069);
            this.BtnKembali.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnKembali.Name = "BtnKembali";
            this.BtnKembali.Size = new System.Drawing.Size(300, 65);
            this.BtnKembali.TabIndex = 131;
            this.BtnKembali.Text = "   KEMBALI";
            this.BtnKembali.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKembali.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnKembali.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Location = new System.Drawing.Point(26, 374);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(264, 5);
            this.panel5.TabIndex = 155;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.BtnKembali);
            this.panel2.Controls.Add(this.BtnKonfirRetur);
            this.panel2.Controls.Add(this.BtnLapRetur);
            this.panel2.Controls.Add(this.BtnLapPenjualan);
            this.panel2.Controls.Add(this.BtnLapPembelian);
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 1050);
            this.panel2.TabIndex = 164;
            // 
            // dateAwal
            // 
            this.dateAwal.CustomFormat = "yyyy-MM-dd";
            this.dateAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateAwal.Location = new System.Drawing.Point(341, 66);
            this.dateAwal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateAwal.Name = "dateAwal";
            this.dateAwal.Size = new System.Drawing.Size(298, 26);
            this.dateAwal.TabIndex = 150;
            this.dateAwal.ValueChanged += new System.EventHandler(this.dateAwal_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(168, 66);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 22);
            this.label10.TabIndex = 151;
            this.label10.Text = "TANGGAL AWAL";
            // 
            // dateAkhir
            // 
            this.dateAkhir.CustomFormat = "yyyy-MM-dd";
            this.dateAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateAkhir.Location = new System.Drawing.Point(1150, 60);
            this.dateAkhir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateAkhir.Name = "dateAkhir";
            this.dateAkhir.Size = new System.Drawing.Size(298, 26);
            this.dateAkhir.TabIndex = 153;
            this.dateAkhir.ValueChanged += new System.EventHandler(this.dateAkhir_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(969, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 22);
            this.label4.TabIndex = 154;
            this.label4.Text = "TANGGAL AKHIR";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.reportViewer1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.dateAkhir);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.dateAwal);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(349, 182);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1681, 806);
            this.panel3.TabIndex = 163;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.penjualan1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Dealer_BengkelSempurna.laporan.RDLC.Penjualan.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(124, 200);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1262, 536);
            this.reportViewer1.TabIndex = 155;
            // 
            // lbJudul
            // 
            this.lbJudul.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJudul.ForeColor = System.Drawing.Color.Black;
            this.lbJudul.Location = new System.Drawing.Point(868, 63);
            this.lbJudul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbJudul.Name = "lbJudul";
            this.lbJudul.Size = new System.Drawing.Size(486, 35);
            this.lbJudul.TabIndex = 162;
            this.lbJudul.Text = "LAPORAN PENJUALAN";
            this.lbJudul.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // penjualan1TableAdapter
            // 
            this.penjualan1TableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(4, 927);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 65);
            this.button2.TabIndex = 160;
            this.button2.Text = "   LOGOUT";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(8, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(300, 232);
            this.panel6.TabIndex = 130;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(46, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 38);
            this.label1.TabIndex = 157;
            this.label1.Text = "DASHBOARD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 129;
            this.pictureBox1.TabStop = false;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel12.Controls.Add(this.pictureBox1);
            this.panel12.Controls.Add(this.panel6);
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(316, 232);
            this.panel12.TabIndex = 128;
            // 
            // lbWaktu
            // 
            this.lbWaktu.AutoSize = true;
            this.lbWaktu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWaktu.Location = new System.Drawing.Point(120, 91);
            this.lbWaktu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWaktu.Name = "lbWaktu";
            this.lbWaktu.Size = new System.Drawing.Size(0, 23);
            this.lbWaktu.TabIndex = 115;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.lbWaktu);
            this.panel4.Location = new System.Drawing.Point(1490, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(422, 143);
            this.panel4.TabIndex = 161;
            // 
            // Laporan_Penjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbJudul);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "Laporan_Penjualan";
            this.Text = "Laporan_Penjualan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Laporan_Penjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.penjualan1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJEK8)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnLapPembelian;
        private System.Windows.Forms.Button BtnLapPenjualan;
        private System.Windows.Forms.Button BtnLapRetur;
        private System.Windows.Forms.Button BtnKonfirRetur;
        private System.Windows.Forms.Button BtnKembali;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateAwal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateAkhir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbJudul;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource penjualan1BindingSource;
        private PROJEK8 pROJEK8;
        private PROJEK8TableAdapters.Penjualan1TableAdapter penjualan1TableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbWaktu;
        private System.Windows.Forms.Panel panel4;
    }
}