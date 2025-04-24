namespace Dealer_BengkelSempurna.Master.JenisKendaraan
{
    partial class JenisKendaraan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JenisKendaraan));
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnServices = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.BtnSupplier = new System.Windows.Forms.Button();
            this.BtnMember = new System.Windows.Forms.Button();
            this.BtnPosisi = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCari = new System.Windows.Forms.Button();
            this.txtCariID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbWaktu = new System.Windows.Forms.Label();
            this.lbledit = new System.Windows.Forms.Label();
            this.TxtNamaJenis = new System.Windows.Forms.TextBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnHapus = new System.Windows.Forms.Button();
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.dgvPosisi = new System.Windows.Forms.DataGridView();
            this.kodeJenisKendaraanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaJenisKendaraanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailJenisKendaraanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewJenisKendaraanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJEK8 = new Dealer_BengkelSempurna.PROJEK8();
            this.lbUser = new System.Windows.Forms.Label();
            this.viewJenisKendaraanTableAdapter = new Dealer_BengkelSempurna.PROJEK8TableAdapters.ViewJenisKendaraanTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbWakt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewJenisKendaraanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJEK8)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.Location = new System.Drawing.Point(168, 228);
            this.txtDeskripsi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.Size = new System.Drawing.Size(277, 26);
            this.txtDeskripsi.TabIndex = 133;
            this.txtDeskripsi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeskripsi_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.BtnServices);
            this.panel2.Controls.Add(this.button14);
            this.panel2.Controls.Add(this.button18);
            this.panel2.Controls.Add(this.BtnSupplier);
            this.panel2.Controls.Add(this.BtnMember);
            this.panel2.Controls.Add(this.BtnPosisi);
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 944);
            this.panel2.TabIndex = 202;
            // 
            // BtnServices
            // 
            this.BtnServices.FlatAppearance.BorderSize = 0;
            this.BtnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnServices.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnServices.ForeColor = System.Drawing.Color.Black;
            this.BtnServices.Image = ((System.Drawing.Image)(resources.GetObject("BtnServices.Image")));
            this.BtnServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnServices.Location = new System.Drawing.Point(0, 367);
            this.BtnServices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnServices.Name = "BtnServices";
            this.BtnServices.Size = new System.Drawing.Size(300, 49);
            this.BtnServices.TabIndex = 137;
            this.BtnServices.Text = "    SERVICES";
            this.BtnServices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnServices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnServices.UseVisualStyleBackColor = true;
            this.BtnServices.Click += new System.EventHandler(this.BtnServices_Click);
            // 
            // button14
            // 
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.Black;
            this.button14.Image = ((System.Drawing.Image)(resources.GetObject("button14.Image")));
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.Location = new System.Drawing.Point(0, 535);
            this.button14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(439, 49);
            this.button14.TabIndex = 136;
            this.button14.Text = "    JENIS KENDARAAN";
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button18
            // 
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ForeColor = System.Drawing.Color.Black;
            this.button18.Image = ((System.Drawing.Image)(resources.GetObject("button18.Image")));
            this.button18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button18.Location = new System.Drawing.Point(0, 476);
            this.button18.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(390, 49);
            this.button18.TabIndex = 135;
            this.button18.Text = "    JENIS SUKU CADANG";
            this.button18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button18.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // BtnSupplier
            // 
            this.BtnSupplier.FlatAppearance.BorderSize = 0;
            this.BtnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSupplier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupplier.ForeColor = System.Drawing.Color.Black;
            this.BtnSupplier.Image = ((System.Drawing.Image)(resources.GetObject("BtnSupplier.Image")));
            this.BtnSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSupplier.Location = new System.Drawing.Point(0, 417);
            this.BtnSupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSupplier.Name = "BtnSupplier";
            this.BtnSupplier.Size = new System.Drawing.Size(300, 49);
            this.BtnSupplier.TabIndex = 134;
            this.BtnSupplier.Text = "    SUPPLIER";
            this.BtnSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSupplier.UseVisualStyleBackColor = true;
            this.BtnSupplier.Click += new System.EventHandler(this.BtnSupplier_Click);
            // 
            // BtnMember
            // 
            this.BtnMember.FlatAppearance.BorderSize = 0;
            this.BtnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMember.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMember.ForeColor = System.Drawing.Color.Black;
            this.BtnMember.Image = ((System.Drawing.Image)(resources.GetObject("BtnMember.Image")));
            this.BtnMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMember.Location = new System.Drawing.Point(0, 320);
            this.BtnMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnMember.Name = "BtnMember";
            this.BtnMember.Size = new System.Drawing.Size(300, 49);
            this.BtnMember.TabIndex = 133;
            this.BtnMember.Text = "    PELANGGAN";
            this.BtnMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMember.UseVisualStyleBackColor = true;
            this.BtnMember.Click += new System.EventHandler(this.BtnMember_Click);
            // 
            // BtnPosisi
            // 
            this.BtnPosisi.FlatAppearance.BorderSize = 0;
            this.BtnPosisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPosisi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPosisi.ForeColor = System.Drawing.Color.Black;
            this.BtnPosisi.Image = ((System.Drawing.Image)(resources.GetObject("BtnPosisi.Image")));
            this.BtnPosisi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPosisi.Location = new System.Drawing.Point(0, 267);
            this.BtnPosisi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPosisi.Name = "BtnPosisi";
            this.BtnPosisi.Size = new System.Drawing.Size(300, 49);
            this.BtnPosisi.TabIndex = 132;
            this.BtnPosisi.Text = "    JABATAN";
            this.BtnPosisi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPosisi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPosisi.UseVisualStyleBackColor = true;
            this.BtnPosisi.Click += new System.EventHandler(this.BtnPosisi_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel12.Controls.Add(this.label1);
            this.panel12.Controls.Add(this.pictureBox1);
            this.panel12.Location = new System.Drawing.Point(-9, 5);
            this.panel12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(318, 232);
            this.panel12.TabIndex = 129;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(60, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 48);
            this.label1.TabIndex = 126;
            this.label1.Text = "DASHBOARD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnCari);
            this.panel3.Controls.Add(this.txtCariID);
            this.panel3.Controls.Add(this.txtDeskripsi);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lbWaktu);
            this.panel3.Controls.Add(this.lbledit);
            this.panel3.Controls.Add(this.TxtNamaJenis);
            this.panel3.Controls.Add(this.BtnClear);
            this.panel3.Controls.Add(this.BtnHapus);
            this.panel3.Controls.Add(this.BtnSimpan);
            this.panel3.Controls.Add(this.label33);
            this.panel3.Controls.Add(this.dgvPosisi);
            this.panel3.Location = new System.Drawing.Point(308, 125);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1602, 805);
            this.panel3.TabIndex = 205;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 212;
            this.label3.Text = "Cari               :";
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCari.FlatAppearance.BorderSize = 0;
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCari.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari.ForeColor = System.Drawing.Color.Honeydew;
            this.btnCari.Location = new System.Drawing.Point(445, 97);
            this.btnCari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(99, 39);
            this.btnCari.TabIndex = 211;
            this.btnCari.Text = "CARI";
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // txtCariID
            // 
            this.txtCariID.Location = new System.Drawing.Point(159, 105);
            this.txtCariID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCariID.Name = "txtCariID";
            this.txtCariID.Size = new System.Drawing.Size(278, 26);
            this.txtCariID.TabIndex = 210;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 23);
            this.label2.TabIndex = 132;
            this.label2.Text = "Nama            :";
            // 
            // lbWaktu
            // 
            this.lbWaktu.Location = new System.Drawing.Point(3, 10);
            this.lbWaktu.Name = "lbWaktu";
            this.lbWaktu.Size = new System.Drawing.Size(157, 36);
            this.lbWaktu.TabIndex = 130;
            // 
            // lbledit
            // 
            this.lbledit.AutoSize = true;
            this.lbledit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledit.Location = new System.Drawing.Point(548, 575);
            this.lbledit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbledit.Name = "lbledit";
            this.lbledit.Size = new System.Drawing.Size(513, 22);
            this.lbledit.TabIndex = 124;
            this.lbledit.Text = "*Klik row pada tabel terlebih dahulu untuk mengedit data";
            // 
            // TxtNamaJenis
            // 
            this.TxtNamaJenis.Location = new System.Drawing.Point(168, 175);
            this.TxtNamaJenis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNamaJenis.Name = "TxtNamaJenis";
            this.TxtNamaJenis.Size = new System.Drawing.Size(277, 26);
            this.TxtNamaJenis.TabIndex = 109;
            this.TxtNamaJenis.TextChanged += new System.EventHandler(this.TxtNamaJenis_TextChanged);
            this.TxtNamaJenis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNamaJenis_KeyPress);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnClear.FlatAppearance.BorderSize = 0;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.Honeydew;
            this.BtnClear.Location = new System.Drawing.Point(234, 523);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(128, 37);
            this.BtnClear.TabIndex = 87;
            this.BtnClear.Text = "UBAH";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnHapus
            // 
            this.BtnHapus.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnHapus.FlatAppearance.BorderSize = 0;
            this.BtnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHapus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHapus.ForeColor = System.Drawing.Color.Honeydew;
            this.BtnHapus.Location = new System.Drawing.Point(416, 523);
            this.BtnHapus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnHapus.Name = "BtnHapus";
            this.BtnHapus.Size = new System.Drawing.Size(128, 37);
            this.BtnHapus.TabIndex = 86;
            this.BtnHapus.Text = "HAPUS";
            this.BtnHapus.UseVisualStyleBackColor = false;
            this.BtnHapus.Click += new System.EventHandler(this.BtnHapus_Click);
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnSimpan.FlatAppearance.BorderSize = 0;
            this.BtnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSimpan.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSimpan.ForeColor = System.Drawing.Color.Honeydew;
            this.BtnSimpan.Location = new System.Drawing.Point(56, 523);
            this.BtnSimpan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(128, 37);
            this.BtnSimpan.TabIndex = 85;
            this.BtnSimpan.Text = "SIMPAN";
            this.BtnSimpan.UseVisualStyleBackColor = false;
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.Black;
            this.label33.Location = new System.Drawing.Point(1, 219);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(156, 23);
            this.label33.TabIndex = 46;
            this.label33.Text = "Deskripsi         :";
            // 
            // dgvPosisi
            // 
            this.dgvPosisi.AllowUserToAddRows = false;
            this.dgvPosisi.AllowUserToDeleteRows = false;
            this.dgvPosisi.AllowUserToResizeColumns = false;
            this.dgvPosisi.AllowUserToResizeRows = false;
            this.dgvPosisi.AutoGenerateColumns = false;
            this.dgvPosisi.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvPosisi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPosisi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPosisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosisi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeJenisKendaraanDataGridViewTextBoxColumn,
            this.namaJenisKendaraanDataGridViewTextBoxColumn,
            this.detailJenisKendaraanDataGridViewTextBoxColumn});
            this.dgvPosisi.DataSource = this.viewJenisKendaraanBindingSource;
            this.dgvPosisi.Location = new System.Drawing.Point(552, 85);
            this.dgvPosisi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPosisi.Name = "dgvPosisi";
            this.dgvPosisi.ReadOnly = true;
            this.dgvPosisi.RowHeadersVisible = false;
            this.dgvPosisi.RowHeadersWidth = 62;
            this.dgvPosisi.Size = new System.Drawing.Size(885, 486);
            this.dgvPosisi.TabIndex = 71;
            this.dgvPosisi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPosisi_CellClick);
            this.dgvPosisi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPosisi_CellContentClick);
            // 
            // kodeJenisKendaraanDataGridViewTextBoxColumn
            // 
            this.kodeJenisKendaraanDataGridViewTextBoxColumn.DataPropertyName = "Kode_Jenis_Kendaraan";
            this.kodeJenisKendaraanDataGridViewTextBoxColumn.HeaderText = "Kode_Jenis_Kendaraan";
            this.kodeJenisKendaraanDataGridViewTextBoxColumn.Name = "kodeJenisKendaraanDataGridViewTextBoxColumn";
            this.kodeJenisKendaraanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaJenisKendaraanDataGridViewTextBoxColumn
            // 
            this.namaJenisKendaraanDataGridViewTextBoxColumn.DataPropertyName = "Nama_Jenis_Kendaraan";
            this.namaJenisKendaraanDataGridViewTextBoxColumn.HeaderText = "Nama_Jenis_Kendaraan";
            this.namaJenisKendaraanDataGridViewTextBoxColumn.Name = "namaJenisKendaraanDataGridViewTextBoxColumn";
            this.namaJenisKendaraanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detailJenisKendaraanDataGridViewTextBoxColumn
            // 
            this.detailJenisKendaraanDataGridViewTextBoxColumn.DataPropertyName = "Detail_Jenis_Kendaraan";
            this.detailJenisKendaraanDataGridViewTextBoxColumn.HeaderText = "Detail_Jenis_Kendaraan";
            this.detailJenisKendaraanDataGridViewTextBoxColumn.Name = "detailJenisKendaraanDataGridViewTextBoxColumn";
            this.detailJenisKendaraanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viewJenisKendaraanBindingSource
            // 
            this.viewJenisKendaraanBindingSource.DataMember = "ViewJenisKendaraan";
            this.viewJenisKendaraanBindingSource.DataSource = this.pROJEK8;
            // 
            // pROJEK8
            // 
            this.pROJEK8.DataSetName = "PROJEK8";
            this.pROJEK8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbUser
            // 
            this.lbUser.Location = new System.Drawing.Point(1679, 73);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(100, 23);
            this.lbUser.TabIndex = 209;
            // 
            // viewJenisKendaraanTableAdapter
            // 
            this.viewJenisKendaraanTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 756);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 65);
            this.button2.TabIndex = 158;
            this.button2.Text = "   LOGOUT";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.Controls.Add(this.lbWakt);
            this.panel4.Location = new System.Drawing.Point(1531, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(368, 99);
            this.panel4.TabIndex = 203;
            // 
            // lbWakt
            // 
            this.lbWakt.AutoSize = true;
            this.lbWakt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWakt.Location = new System.Drawing.Point(33, 50);
            this.lbWakt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWakt.Name = "lbWakt";
            this.lbWakt.Size = new System.Drawing.Size(0, 23);
            this.lbWakt.TabIndex = 115;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1007, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 40);
            this.label4.TabIndex = 205;
            this.label4.Text = "Jenis Kendaraan";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl
            // 
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(875, 14);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(623, 63);
            this.lbl.TabIndex = 204;
            this.lbl.Text = "Dealer Bengkel Sempurna";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // JenisKendaraan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 944);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lbUser);
            this.Name = "JenisKendaraan";
            this.Text = "JenisKendaraan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.JenisKendaraan_Load);
            this.panel2.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewJenisKendaraanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJEK8)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDeskripsi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbWaktu;
        private System.Windows.Forms.Label lbledit;
        private System.Windows.Forms.TextBox TxtNamaJenis;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnHapus;
        private System.Windows.Forms.Button BtnSimpan;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.DataGridView dgvPosisi;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button BtnSupplier;
        private System.Windows.Forms.Button BtnMember;
        private System.Windows.Forms.Button BtnPosisi;
        private System.Windows.Forms.Button BtnServices;
        private System.Windows.Forms.TextBox txtCariID;
        private System.Windows.Forms.Button btnCari;
        private PROJEK8 pROJEK8;
        private System.Windows.Forms.BindingSource viewJenisKendaraanBindingSource;
        private PROJEK8TableAdapters.ViewJenisKendaraanTableAdapter viewJenisKendaraanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeJenisKendaraanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaJenisKendaraanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailJenisKendaraanDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbWakt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl;
    }
}