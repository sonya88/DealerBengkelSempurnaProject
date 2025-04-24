namespace Dealer_BengkelSempurna.Master.Member
{
    partial class member
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(member));
            this.lbledit = new System.Windows.Forms.Label();
            this.TxtAlamat = new System.Windows.Forms.TextBox();
            this.TxtNoTelp = new System.Windows.Forms.TextBox();
            this.TxtNoKTP = new System.Windows.Forms.TextBox();
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CbStatus = new System.Windows.Forms.ComboBox();
            this.label33 = new System.Windows.Forms.Label();
            this.TxtNama = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.dgvMember = new System.Windows.Forms.DataGridView();
            this.idpelangganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namapelangganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noKTPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteleponDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewPelangganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJEK8 = new Dealer_BengkelSempurna.PROJEK8();
            this.label29 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnHapus = new System.Windows.Forms.Button();
            this.btncari = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnUbah = new System.Windows.Forms.Button();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbWaktu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbWakt = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button14 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSupplier = new System.Windows.Forms.Button();
            this.BtnMember = new System.Windows.Forms.Button();
            this.BtnPosisi = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.viewPelangganTableAdapter = new Dealer_BengkelSempurna.PROJEK8TableAdapters.viewPelangganTableAdapter();
            this.BtnServices = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPelangganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJEK8)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbledit
            // 
            this.lbledit.AutoSize = true;
            this.lbledit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledit.Location = new System.Drawing.Point(580, 578);
            this.lbledit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbledit.Name = "lbledit";
            this.lbledit.Size = new System.Drawing.Size(513, 22);
            this.lbledit.TabIndex = 123;
            this.lbledit.Text = "*Klik row pada tabel terlebih dahulu untuk mengedit data";
            // 
            // TxtAlamat
            // 
            this.TxtAlamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAlamat.Location = new System.Drawing.Point(245, 215);
            this.TxtAlamat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtAlamat.Multiline = true;
            this.TxtAlamat.Name = "TxtAlamat";
            this.TxtAlamat.Size = new System.Drawing.Size(276, 70);
            this.TxtAlamat.TabIndex = 90;
            // 
            // TxtNoTelp
            // 
            this.TxtNoTelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNoTelp.Location = new System.Drawing.Point(244, 177);
            this.TxtNoTelp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNoTelp.MaxLength = 13;
            this.TxtNoTelp.Name = "TxtNoTelp";
            this.TxtNoTelp.Size = new System.Drawing.Size(277, 28);
            this.TxtNoTelp.TabIndex = 89;
            this.TxtNoTelp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNoTelp_KeyPress);
            // 
            // TxtNoKTP
            // 
            this.TxtNoKTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNoKTP.Location = new System.Drawing.Point(242, 129);
            this.TxtNoKTP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNoKTP.MaxLength = 16;
            this.TxtNoKTP.Name = "TxtNoKTP";
            this.TxtNoKTP.Size = new System.Drawing.Size(276, 28);
            this.TxtNoKTP.TabIndex = 88;
            this.TxtNoKTP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNoKTP_KeyPress);
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnSimpan.FlatAppearance.BorderSize = 0;
            this.BtnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSimpan.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSimpan.ForeColor = System.Drawing.Color.Honeydew;
            this.BtnSimpan.Location = new System.Drawing.Point(43, 525);
            this.BtnSimpan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(115, 37);
            this.BtnSimpan.TabIndex = 85;
            this.BtnSimpan.Text = "SIMPAN";
            this.BtnSimpan.UseVisualStyleBackColor = false;
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(64, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 22);
            this.label5.TabIndex = 84;
            this.label5.Text = "NO TELEPON";
            // 
            // CbStatus
            // 
            this.CbStatus.Enabled = false;
            this.CbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbStatus.FormattingEnabled = true;
            this.CbStatus.Items.AddRange(new object[] {
            "Aktif",
            "Tidak aktif"});
            this.CbStatus.Location = new System.Drawing.Point(244, 293);
            this.CbStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbStatus.Name = "CbStatus";
            this.CbStatus.Size = new System.Drawing.Size(277, 30);
            this.CbStatus.TabIndex = 74;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.Black;
            this.label33.Location = new System.Drawing.Point(63, 80);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(65, 22);
            this.label33.TabIndex = 46;
            this.label33.Text = "NAMA";
            // 
            // TxtNama
            // 
            this.TxtNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNama.Location = new System.Drawing.Point(242, 75);
            this.TxtNama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNama.Name = "TxtNama";
            this.TxtNama.Size = new System.Drawing.Size(276, 28);
            this.TxtNama.TabIndex = 73;
            this.TxtNama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNama_KeyPress);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.Black;
            this.label31.Location = new System.Drawing.Point(63, 134);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(72, 22);
            this.label31.TabIndex = 44;
            this.label31.Text = "NO KTP";
            // 
            // dgvMember
            // 
            this.dgvMember.AllowUserToAddRows = false;
            this.dgvMember.AllowUserToDeleteRows = false;
            this.dgvMember.AllowUserToResizeColumns = false;
            this.dgvMember.AllowUserToResizeRows = false;
            this.dgvMember.AutoGenerateColumns = false;
            this.dgvMember.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvMember.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpelangganDataGridViewTextBoxColumn,
            this.namapelangganDataGridViewTextBoxColumn,
            this.noKTPDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.noteleponDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgvMember.DataSource = this.viewPelangganBindingSource;
            this.dgvMember.Location = new System.Drawing.Point(622, 48);
            this.dgvMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.ReadOnly = true;
            this.dgvMember.RowHeadersVisible = false;
            this.dgvMember.RowHeadersWidth = 62;
            this.dgvMember.Size = new System.Drawing.Size(833, 495);
            this.dgvMember.TabIndex = 71;
            this.dgvMember.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMember_CellClick);
            // 
            // idpelangganDataGridViewTextBoxColumn
            // 
            this.idpelangganDataGridViewTextBoxColumn.DataPropertyName = "id_pelanggan";
            this.idpelangganDataGridViewTextBoxColumn.HeaderText = "id_pelanggan";
            this.idpelangganDataGridViewTextBoxColumn.Name = "idpelangganDataGridViewTextBoxColumn";
            this.idpelangganDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namapelangganDataGridViewTextBoxColumn
            // 
            this.namapelangganDataGridViewTextBoxColumn.DataPropertyName = "nama_pelanggan";
            this.namapelangganDataGridViewTextBoxColumn.HeaderText = "nama_pelanggan";
            this.namapelangganDataGridViewTextBoxColumn.Name = "namapelangganDataGridViewTextBoxColumn";
            this.namapelangganDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noKTPDataGridViewTextBoxColumn
            // 
            this.noKTPDataGridViewTextBoxColumn.DataPropertyName = "no_KTP";
            this.noKTPDataGridViewTextBoxColumn.HeaderText = "no_KTP";
            this.noKTPDataGridViewTextBoxColumn.Name = "noKTPDataGridViewTextBoxColumn";
            this.noKTPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "alamat";
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noteleponDataGridViewTextBoxColumn
            // 
            this.noteleponDataGridViewTextBoxColumn.DataPropertyName = "no_telepon";
            this.noteleponDataGridViewTextBoxColumn.HeaderText = "no_telepon";
            this.noteleponDataGridViewTextBoxColumn.Name = "noteleponDataGridViewTextBoxColumn";
            this.noteleponDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viewPelangganBindingSource
            // 
            this.viewPelangganBindingSource.DataMember = "viewPelanggan";
            this.viewPelangganBindingSource.DataSource = this.pROJEK8;
            // 
            // pROJEK8
            // 
            this.pROJEK8.DataSetName = "PROJEK8";
            this.pROJEK8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(65, 218);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(81, 22);
            this.label29.TabIndex = 42;
            this.label29.Text = "ALAMAT";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbStatus.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.Black;
            this.lbStatus.Location = new System.Drawing.Point(64, 301);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(69, 22);
            this.lbStatus.TabIndex = 58;
            this.lbStatus.Text = "STATUS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.BtnHapus);
            this.panel3.Controls.Add(this.btncari);
            this.panel3.Controls.Add(this.txtCari);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.BtnUbah);
            this.panel3.Controls.Add(this.lbUser);
            this.panel3.Controls.Add(this.lbWaktu);
            this.panel3.Controls.Add(this.lbledit);
            this.panel3.Controls.Add(this.TxtAlamat);
            this.panel3.Controls.Add(this.TxtNoTelp);
            this.panel3.Controls.Add(this.TxtNoKTP);
            this.panel3.Controls.Add(this.BtnSimpan);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.CbStatus);
            this.panel3.Controls.Add(this.label33);
            this.panel3.Controls.Add(this.TxtNama);
            this.panel3.Controls.Add(this.label31);
            this.panel3.Controls.Add(this.dgvMember);
            this.panel3.Controls.Add(this.label29);
            this.panel3.Controls.Add(this.lbStatus);
            this.panel3.Location = new System.Drawing.Point(383, 147);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1481, 849);
            this.panel3.TabIndex = 157;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // BtnHapus
            // 
            this.BtnHapus.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnHapus.FlatAppearance.BorderSize = 0;
            this.BtnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHapus.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHapus.ForeColor = System.Drawing.Color.Honeydew;
            this.BtnHapus.Location = new System.Drawing.Point(406, 526);
            this.BtnHapus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnHapus.Name = "BtnHapus";
            this.BtnHapus.Size = new System.Drawing.Size(115, 37);
            this.BtnHapus.TabIndex = 217;
            this.BtnHapus.Text = "HAPUS";
            this.BtnHapus.UseVisualStyleBackColor = false;
            this.BtnHapus.Click += new System.EventHandler(this.BtnHapus_Click_1);
            // 
            // btncari
            // 
            this.btncari.BackColor = System.Drawing.Color.SteelBlue;
            this.btncari.FlatAppearance.BorderSize = 0;
            this.btncari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncari.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncari.ForeColor = System.Drawing.Color.Honeydew;
            this.btncari.Location = new System.Drawing.Point(459, 31);
            this.btncari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncari.Name = "btncari";
            this.btncari.Size = new System.Drawing.Size(117, 37);
            this.btncari.TabIndex = 216;
            this.btncari.Text = "CARI";
            this.btncari.UseVisualStyleBackColor = false;
            this.btncari.Click += new System.EventHandler(this.btncari_Click);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(146, 38);
            this.txtCari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(277, 26);
            this.txtCari.TabIndex = 215;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(63, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 23);
            this.label6.TabIndex = 214;
            this.label6.Text = "CARI";
            // 
            // BtnUbah
            // 
            this.BtnUbah.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnUbah.FlatAppearance.BorderSize = 0;
            this.BtnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUbah.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUbah.ForeColor = System.Drawing.Color.Honeydew;
            this.BtnUbah.Location = new System.Drawing.Point(222, 525);
            this.BtnUbah.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnUbah.Name = "BtnUbah";
            this.BtnUbah.Size = new System.Drawing.Size(128, 37);
            this.BtnUbah.TabIndex = 159;
            this.BtnUbah.Text = "UBAH";
            this.BtnUbah.UseVisualStyleBackColor = false;
            this.BtnUbah.Click += new System.EventHandler(this.BtnUbah_Click_1);
            // 
            // lbUser
            // 
            this.lbUser.Location = new System.Drawing.Point(1224, 0);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(176, 24);
            this.lbUser.TabIndex = 158;
            // 
            // lbWaktu
            // 
            this.lbWaktu.Location = new System.Drawing.Point(12, 19);
            this.lbWaktu.Name = "lbWaktu";
            this.lbWaktu.Size = new System.Drawing.Size(268, 35);
            this.lbWaktu.TabIndex = 124;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(962, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 40);
            this.label3.TabIndex = 204;
            this.label3.Text = "Pelanggan";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl
            // 
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(835, 26);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(623, 63);
            this.lbl.TabIndex = 203;
            this.lbl.Text = "Dealer Bengkel Sempurna";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(320, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1574, 1014);
            this.panel1.TabIndex = 205;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.Controls.Add(this.lbWakt);
            this.panel4.Location = new System.Drawing.Point(1214, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(353, 77);
            this.panel4.TabIndex = 134;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button14);
            this.panel2.Controls.Add(this.button18);
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BtnSupplier);
            this.panel2.Controls.Add(this.BtnServices);
            this.panel2.Controls.Add(this.BtnMember);
            this.panel2.Controls.Add(this.BtnPosisi);
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 1050);
            this.panel2.TabIndex = 206;
            // 
            // button14
            // 
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.Black;
            this.button14.Image = ((System.Drawing.Image)(resources.GetObject("button14.Image")));
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.Location = new System.Drawing.Point(13, 584);
            this.button14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(300, 49);
            this.button14.TabIndex = 131;
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
            this.button18.Location = new System.Drawing.Point(13, 525);
            this.button18.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(300, 49);
            this.button18.TabIndex = 130;
            this.button18.Text = "    JENIS SUKU CADANG";
            this.button18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button18.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(4, 1097);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(300, 49);
            this.btnLogOut.TabIndex = 126;
            this.btnLogOut.Text = "    LOG-OUT";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(57, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 48);
            this.label1.TabIndex = 125;
            this.label1.Text = "DASHBOARD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnSupplier
            // 
            this.BtnSupplier.FlatAppearance.BorderSize = 0;
            this.BtnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSupplier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupplier.ForeColor = System.Drawing.Color.Black;
            this.BtnSupplier.Image = ((System.Drawing.Image)(resources.GetObject("BtnSupplier.Image")));
            this.BtnSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSupplier.Location = new System.Drawing.Point(13, 450);
            this.BtnSupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSupplier.Name = "BtnSupplier";
            this.BtnSupplier.Size = new System.Drawing.Size(300, 49);
            this.BtnSupplier.TabIndex = 63;
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
            this.BtnMember.Location = new System.Drawing.Point(13, 326);
            this.BtnMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnMember.Name = "BtnMember";
            this.BtnMember.Size = new System.Drawing.Size(300, 49);
            this.BtnMember.TabIndex = 58;
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
            this.BtnPosisi.Location = new System.Drawing.Point(13, 266);
            this.BtnPosisi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPosisi.Name = "BtnPosisi";
            this.BtnPosisi.Size = new System.Drawing.Size(300, 49);
            this.BtnPosisi.TabIndex = 57;
            this.BtnPosisi.Text = "    JABATAN";
            this.BtnPosisi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPosisi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPosisi.UseVisualStyleBackColor = true;
            this.BtnPosisi.Click += new System.EventHandler(this.BtnPosisi_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel12.Controls.Add(this.pictureBox1);
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(318, 232);
            this.panel12.TabIndex = 128;
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
            // viewPelangganTableAdapter
            // 
            this.viewPelangganTableAdapter.ClearBeforeFill = true;
            // 
            // BtnServices
            // 
            this.BtnServices.FlatAppearance.BorderSize = 0;
            this.BtnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnServices.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnServices.ForeColor = System.Drawing.Color.Black;
            this.BtnServices.Image = ((System.Drawing.Image)(resources.GetObject("BtnServices.Image")));
            this.BtnServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnServices.Location = new System.Drawing.Point(13, 385);
            this.BtnServices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnServices.Name = "BtnServices";
            this.BtnServices.Size = new System.Drawing.Size(300, 49);
            this.BtnServices.TabIndex = 61;
            this.BtnServices.Text = "    SERVICES";
            this.BtnServices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnServices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnServices.UseVisualStyleBackColor = true;
            this.BtnServices.Click += new System.EventHandler(this.BtnServices_Click_1);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(13, 840);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 65);
            this.button2.TabIndex = 158;
            this.button2.Text = "   LOGOUT";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "member";
            this.Text = "member";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.member_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPelangganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJEK8)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbledit;
        private System.Windows.Forms.TextBox TxtAlamat;
        private System.Windows.Forms.TextBox TxtNoTelp;
        private System.Windows.Forms.TextBox TxtNoKTP;
        private System.Windows.Forms.Button BtnSimpan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbStatus;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox TxtNama;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.DataGridView dgvMember;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbWaktu;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbWakt;
        private System.Windows.Forms.Button BtnUbah;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSupplier;
        private System.Windows.Forms.Button BtnMember;
        private System.Windows.Forms.Button BtnPosisi;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btncari;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label label6;
        private PROJEK8 pROJEK8;
        private System.Windows.Forms.BindingSource viewPelangganBindingSource;
        private PROJEK8TableAdapters.viewPelangganTableAdapter viewPelangganTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpelangganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namapelangganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noKTPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteleponDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnHapus;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnServices;
    }
}