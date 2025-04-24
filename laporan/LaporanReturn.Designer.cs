namespace Dealer_BengkelSempurna.laporan
{
    partial class LaporanReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaporanReturn));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.returPembelianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laporan = new Dealer_BengkelSempurna.Laporan();
            this.lbWaktu = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dateAkhir = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label10 = new System.Windows.Forms.Label();
            this.dateAwal = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbJudul = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLapPenjualan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnKembali = new System.Windows.Forms.Button();
            this.BtnLapRetur = new System.Windows.Forms.Button();
            this.BtnLapPembelian = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.returPembelianTableAdapter = new Dealer_BengkelSempurna.LaporanTableAdapters.ReturPembelianTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnKonfirRetur = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.returPembelianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // returPembelianBindingSource
            // 
            this.returPembelianBindingSource.DataMember = "ReturPembelian";
            this.returPembelianBindingSource.DataSource = this.laporan;
            // 
            // laporan
            // 
            this.laporan.DataSetName = "Laporan";
            this.laporan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(128, 22);
            this.lbUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(200, 28);
            this.lbUser.TabIndex = 18;
            this.lbUser.Text = "Hallo, manager ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(21, 22);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(90, 89);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 104;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.dateAkhir);
            this.panel3.Controls.Add(this.reportViewer1);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.dateAwal);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(337, 208);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1575, 838);
            this.panel3.TabIndex = 171;
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
            // reportViewer1
            // 
            reportDataSource3.Name = "Return";
            reportDataSource3.Value = this.returPembelianBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Dealer_BengkelSempurna.laporan.LaporanRetur.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(159, 169);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1364, 557);
            this.reportViewer1.TabIndex = 152;
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
            // dateAwal
            // 
            this.dateAwal.CustomFormat = "yyyy-MM-dd";
            this.dateAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateAwal.Location = new System.Drawing.Point(350, 60);
            this.dateAwal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateAwal.Name = "dateAwal";
            this.dateAwal.Size = new System.Drawing.Size(298, 26);
            this.dateAwal.TabIndex = 150;
            this.dateAwal.ValueChanged += new System.EventHandler(this.dateAwal_ValueChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.lbWaktu);
            this.panel4.Controls.Add(this.lbUser);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Location = new System.Drawing.Point(1440, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(422, 143);
            this.panel4.TabIndex = 169;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(442, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(516, 48);
            this.label3.TabIndex = 130;
            this.label3.Text = "Halaman Manager - Laporan Retur";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(2118, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 52);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(2067, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 52);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // lbJudul
            // 
            this.lbJudul.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJudul.ForeColor = System.Drawing.Color.Black;
            this.lbJudul.Location = new System.Drawing.Point(785, 67);
            this.lbJudul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbJudul.Name = "lbJudul";
            this.lbJudul.Size = new System.Drawing.Size(486, 35);
            this.lbJudul.TabIndex = 170;
            this.lbJudul.Text = "LAPORAN RETUR";
            this.lbJudul.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(-138, -22);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2200, 58);
            this.panel1.TabIndex = 168;
            // 
            // BtnLapPenjualan
            // 
            this.BtnLapPenjualan.FlatAppearance.BorderSize = 0;
            this.BtnLapPenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLapPenjualan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLapPenjualan.ForeColor = System.Drawing.Color.Black;
            this.BtnLapPenjualan.Location = new System.Drawing.Point(24, 349);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.BtnKonfirRetur);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.BtnKembali);
            this.panel2.Controls.Add(this.BtnLapRetur);
            this.panel2.Controls.Add(this.BtnLapPenjualan);
            this.panel2.Controls.Add(this.BtnLapPembelian);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 1050);
            this.panel2.TabIndex = 172;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Location = new System.Drawing.Point(24, 458);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(264, 5);
            this.panel5.TabIndex = 155;
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
            // BtnLapRetur
            // 
            this.BtnLapRetur.FlatAppearance.BorderSize = 0;
            this.BtnLapRetur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLapRetur.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLapRetur.ForeColor = System.Drawing.Color.Black;
            this.BtnLapRetur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLapRetur.Location = new System.Drawing.Point(24, 414);
            this.BtnLapRetur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnLapRetur.Name = "BtnLapRetur";
            this.BtnLapRetur.Size = new System.Drawing.Size(300, 49);
            this.BtnLapRetur.TabIndex = 58;
            this.BtnLapRetur.Text = "LAPORAN RETUR";
            this.BtnLapRetur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLapRetur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLapRetur.UseVisualStyleBackColor = true;
            // 
            // BtnLapPembelian
            // 
            this.BtnLapPembelian.FlatAppearance.BorderSize = 0;
            this.BtnLapPembelian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLapPembelian.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLapPembelian.ForeColor = System.Drawing.Color.Black;
            this.BtnLapPembelian.Image = ((System.Drawing.Image)(resources.GetObject("BtnLapPembelian.Image")));
            this.BtnLapPembelian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLapPembelian.Location = new System.Drawing.Point(24, 297);
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
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tReturPembelian";
            // 
            // returPembelianTableAdapter
            // 
            this.returPembelianTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(14, 956);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 65);
            this.button2.TabIndex = 166;
            this.button2.Text = "   LOGOUT";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // BtnKonfirRetur
            // 
            this.BtnKonfirRetur.FlatAppearance.BorderSize = 0;
            this.BtnKonfirRetur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKonfirRetur.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKonfirRetur.ForeColor = System.Drawing.Color.Black;
            this.BtnKonfirRetur.Image = ((System.Drawing.Image)(resources.GetObject("BtnKonfirRetur.Image")));
            this.BtnKonfirRetur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKonfirRetur.Location = new System.Drawing.Point(14, 462);
            this.BtnKonfirRetur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnKonfirRetur.Name = "BtnKonfirRetur";
            this.BtnKonfirRetur.Size = new System.Drawing.Size(300, 57);
            this.BtnKonfirRetur.TabIndex = 165;
            this.BtnKonfirRetur.Text = "KONFIRMASI RETUR";
            this.BtnKonfirRetur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKonfirRetur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnKonfirRetur.UseVisualStyleBackColor = true;
            this.BtnKonfirRetur.Click += new System.EventHandler(this.BtnKonfirRetur_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 63);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 163;
            this.pictureBox1.TabStop = false;
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
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(14, 29);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(300, 232);
            this.panel6.TabIndex = 164;
            // 
            // LaporanReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lbJudul);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "LaporanReturn";
            this.Text = "LaporanReturn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.returPembelianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbWaktu;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateAkhir;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateAwal;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbJudul;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnLapPenjualan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnKembali;
        private System.Windows.Forms.Button BtnLapRetur;
        private System.Windows.Forms.Button BtnLapPembelian;
        private System.Windows.Forms.BindingSource returPembelianBindingSource;
        private Laporan laporan;
        private LaporanTableAdapters.ReturPembelianTableAdapter returPembelianTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnKonfirRetur;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
    }
}