namespace Dealer_BengkelSempurna.Master.Services
{
    partial class services
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(services));
            this.lbledit = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtJenisSer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnHapus = new System.Windows.Forms.Button();
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rbTidakAktif = new System.Windows.Forms.RadioButton();
            this.rbAktif = new System.Windows.Forms.RadioButton();
            this.label33 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.dgvJenisSer = new System.Windows.Forms.DataGridView();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbJudul = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnUbah = new System.Windows.Forms.Button();
            this.BtnTambah = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbWaktu = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJenisSer)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel12.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbledit
            // 
            this.lbledit.AutoSize = true;
            this.lbledit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledit.Location = new System.Drawing.Point(549, 571);
            this.lbledit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbledit.Name = "lbledit";
            this.lbledit.Size = new System.Drawing.Size(513, 22);
            this.lbledit.TabIndex = 125;
            this.lbledit.Text = "*Klik row pada tabel terlebih dahulu untuk mengedit data";
            // 
            // cbStatus
            // 
            this.cbStatus.Enabled = false;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Tersedia",
            "Tidak tersedia"});
            this.cbStatus.Location = new System.Drawing.Point(230, 194);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(278, 28);
            this.cbStatus.TabIndex = 109;
            this.cbStatus.Visible = false;
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(266, 137);
            this.txtHarga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(242, 26);
            this.txtHarga.TabIndex = 108;
            this.txtHarga.TextChanged += new System.EventHandler(this.txtHarga_TextChanged);
            this.txtHarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHarga_KeyPress);
            // 
            // txtJenisSer
            // 
            this.txtJenisSer.Location = new System.Drawing.Point(230, 80);
            this.txtJenisSer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtJenisSer.Name = "txtJenisSer";
            this.txtJenisSer.Size = new System.Drawing.Size(278, 26);
            this.txtJenisSer.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(228, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 23);
            this.label1.TabIndex = 89;
            this.label1.Text = "RP.";
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnClear.FlatAppearance.BorderSize = 0;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.Honeydew;
            this.BtnClear.Location = new System.Drawing.Point(330, 529);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(128, 37);
            this.BtnClear.TabIndex = 87;
            this.BtnClear.Text = "CLEAR";
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
            this.BtnHapus.Location = new System.Drawing.Point(194, 529);
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
            this.BtnSimpan.Location = new System.Drawing.Point(57, 529);
            this.BtnSimpan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(128, 37);
            this.BtnSimpan.TabIndex = 85;
            this.BtnSimpan.Text = "SIMPAN";
            this.BtnSimpan.UseVisualStyleBackColor = false;
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAll.Location = new System.Drawing.Point(838, 38);
            this.rbAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(96, 26);
            this.rbAll.TabIndex = 80;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "Semua";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(549, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 79;
            this.label4.Text = "Status :";
            // 
            // rbTidakAktif
            // 
            this.rbTidakAktif.AutoSize = true;
            this.rbTidakAktif.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTidakAktif.Location = new System.Drawing.Point(700, 38);
            this.rbTidakAktif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbTidakAktif.Name = "rbTidakAktif";
            this.rbTidakAktif.Size = new System.Drawing.Size(123, 26);
            this.rbTidakAktif.TabIndex = 78;
            this.rbTidakAktif.TabStop = true;
            this.rbTidakAktif.Text = "Tidak Aktif";
            this.rbTidakAktif.UseVisualStyleBackColor = true;
            this.rbTidakAktif.CheckedChanged += new System.EventHandler(this.rbTidakAktif_CheckedChanged);
            // 
            // rbAktif
            // 
            this.rbAktif.AutoSize = true;
            this.rbAktif.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAktif.Location = new System.Drawing.Point(622, 38);
            this.rbAktif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbAktif.Name = "rbAktif";
            this.rbAktif.Size = new System.Drawing.Size(72, 26);
            this.rbAktif.TabIndex = 77;
            this.rbAktif.TabStop = true;
            this.rbAktif.Text = "Aktif";
            this.rbAktif.UseVisualStyleBackColor = true;
            this.rbAktif.CheckedChanged += new System.EventHandler(this.rbAktif_CheckedChanged);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.Black;
            this.label33.Location = new System.Drawing.Point(52, 86);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(145, 23);
            this.label33.TabIndex = 46;
            this.label33.Text = "JENIS SERVICE";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.Black;
            this.label31.Location = new System.Drawing.Point(52, 138);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(83, 23);
            this.label31.TabIndex = 44;
            this.label31.Text = "HARGA";
            // 
            // dgvJenisSer
            // 
            this.dgvJenisSer.AllowUserToAddRows = false;
            this.dgvJenisSer.AllowUserToDeleteRows = false;
            this.dgvJenisSer.AllowUserToResizeColumns = false;
            this.dgvJenisSer.AllowUserToResizeRows = false;
            this.dgvJenisSer.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvJenisSer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJenisSer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJenisSer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJenisSer.Location = new System.Drawing.Point(554, 74);
            this.dgvJenisSer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvJenisSer.Name = "dgvJenisSer";
            this.dgvJenisSer.ReadOnly = true;
            this.dgvJenisSer.RowHeadersVisible = false;
            this.dgvJenisSer.RowHeadersWidth = 62;
            this.dgvJenisSer.Size = new System.Drawing.Size(886, 492);
            this.dgvJenisSer.TabIndex = 71;
            this.dgvJenisSer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJenisSer_CellClick);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.Black;
            this.lbStatus.Location = new System.Drawing.Point(52, 194);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(74, 23);
            this.lbStatus.TabIndex = 58;
            this.lbStatus.Text = "STATUS";
            this.lbStatus.Visible = false;
            // 
            // lbJudul
            // 
            this.lbJudul.BackColor = System.Drawing.Color.Transparent;
            this.lbJudul.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJudul.ForeColor = System.Drawing.Color.White;
            this.lbJudul.Location = new System.Drawing.Point(907, 87);
            this.lbJudul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbJudul.Name = "lbJudul";
            this.lbJudul.Size = new System.Drawing.Size(412, 40);
            this.lbJudul.TabIndex = 163;
            this.lbJudul.Text = "TAMBAH SERVICE";
            this.lbJudul.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Honeydew;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1264, 837);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 65);
            this.button2.TabIndex = 162;
            this.button2.Text = "   KEMBALI";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnUbah
            // 
            this.BtnUbah.FlatAppearance.BorderSize = 0;
            this.BtnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUbah.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUbah.ForeColor = System.Drawing.Color.Honeydew;
            this.BtnUbah.Image = ((System.Drawing.Image)(resources.GetObject("BtnUbah.Image")));
            this.BtnUbah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUbah.Location = new System.Drawing.Point(956, 837);
            this.BtnUbah.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnUbah.Name = "BtnUbah";
            this.BtnUbah.Size = new System.Drawing.Size(300, 57);
            this.BtnUbah.TabIndex = 159;
            this.BtnUbah.Text = "   UBAH";
            this.BtnUbah.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUbah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUbah.UseVisualStyleBackColor = true;
            this.BtnUbah.Click += new System.EventHandler(this.BtnUbah_Click);
            // 
            // BtnTambah
            // 
            this.BtnTambah.FlatAppearance.BorderSize = 0;
            this.BtnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTambah.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTambah.ForeColor = System.Drawing.Color.Honeydew;
            this.BtnTambah.Image = ((System.Drawing.Image)(resources.GetObject("BtnTambah.Image")));
            this.BtnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTambah.Location = new System.Drawing.Point(646, 837);
            this.BtnTambah.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnTambah.Name = "BtnTambah";
            this.BtnTambah.Size = new System.Drawing.Size(300, 57);
            this.BtnTambah.TabIndex = 158;
            this.BtnTambah.Text = "   TAMBAH";
            this.BtnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTambah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnTambah.UseVisualStyleBackColor = true;
            this.BtnTambah.Click += new System.EventHandler(this.BtnTambah_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Honeydew;
            this.label6.Location = new System.Drawing.Point(620, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(450, 48);
            this.label6.TabIndex = 129;
            this.label6.Text = "Halaman Admin - Master Services";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1989, 3);
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
            this.button3.Location = new System.Drawing.Point(1936, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 52);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(186, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1775, 58);
            this.panel1.TabIndex = 160;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(48, 24);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(162, 149);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 65;
            this.pictureBox4.TabStop = false;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.RosyBrown;
            this.panel12.Controls.Add(this.pictureBox4);
            this.panel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(296, 203);
            this.panel12.TabIndex = 129;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lbUser);
            this.panel3.Controls.Add(this.lbWaktu);
            this.panel3.Controls.Add(this.lbledit);
            this.panel3.Controls.Add(this.cbStatus);
            this.panel3.Controls.Add(this.txtHarga);
            this.panel3.Controls.Add(this.txtJenisSer);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.BtnClear);
            this.panel3.Controls.Add(this.BtnHapus);
            this.panel3.Controls.Add(this.BtnSimpan);
            this.panel3.Controls.Add(this.rbAll);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.rbTidakAktif);
            this.panel3.Controls.Add(this.rbAktif);
            this.panel3.Controls.Add(this.label33);
            this.panel3.Controls.Add(this.label31);
            this.panel3.Controls.Add(this.dgvJenisSer);
            this.panel3.Controls.Add(this.lbStatus);
            this.panel3.Location = new System.Drawing.Point(341, 167);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1518, 672);
            this.panel3.TabIndex = 164;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lbUser
            // 
            this.lbUser.Location = new System.Drawing.Point(1297, 0);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(219, 36);
            this.lbUser.TabIndex = 127;
            // 
            // lbWaktu
            // 
            this.lbWaktu.Location = new System.Drawing.Point(-2, -2);
            this.lbWaktu.Name = "lbWaktu";
            this.lbWaktu.Size = new System.Drawing.Size(219, 36);
            this.lbWaktu.TabIndex = 126;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RosyBrown;
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 1050);
            this.panel2.TabIndex = 161;
            // 
            // services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.lbJudul);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnUbah);
            this.Controls.Add(this.BtnTambah);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "services";
            this.Text = "services";
            this.Load += new System.EventHandler(this.services_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJenisSer)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbledit;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtJenisSer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnHapus;
        private System.Windows.Forms.Button BtnSimpan;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbTidakAktif;
        private System.Windows.Forms.RadioButton rbAktif;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.DataGridView dgvJenisSer;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbJudul;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnUbah;
        private System.Windows.Forms.Button BtnTambah;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbWaktu;
    }
}