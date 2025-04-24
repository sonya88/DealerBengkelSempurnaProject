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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(services));
            this.lbledit = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtJenisSer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.dgvJenisSer = new System.Windows.Forms.DataGridView();
            this.idserviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisserviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJEK8 = new Dealer_BengkelSempurna.PROJEK8();
            this.lbStatus = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btncari = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnUbah = new System.Windows.Forms.Button();
            this.BtnHapus = new System.Windows.Forms.Button();
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.lbUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbWakt = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button14 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSupplier = new System.Windows.Forms.Button();
            this.BtnServices = new System.Windows.Forms.Button();
            this.BtnMember = new System.Windows.Forms.Button();
            this.BtnPosisi = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.viewServiceTableAdapter = new Dealer_BengkelSempurna.PROJEK8TableAdapters.ViewServiceTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJenisSer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewServiceBindingSource)).BeginInit();
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
            this.cbStatus.Location = new System.Drawing.Point(229, 285);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(278, 28);
            this.cbStatus.TabIndex = 109;
            this.cbStatus.Visible = false;
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(265, 228);
            this.txtHarga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(242, 26);
            this.txtHarga.TabIndex = 108;
            this.txtHarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHarga_KeyPress);
            this.txtHarga.Leave += new System.EventHandler(this.txtHarga_Leave);
            // 
            // txtJenisSer
            // 
            this.txtJenisSer.Location = new System.Drawing.Point(229, 171);
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
            this.label1.Location = new System.Drawing.Point(227, 229);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 23);
            this.label1.TabIndex = 89;
            this.label1.Text = "RP.";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.Black;
            this.label33.Location = new System.Drawing.Point(51, 177);
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
            this.label31.Location = new System.Drawing.Point(51, 229);
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
            this.dgvJenisSer.AutoGenerateColumns = false;
            this.dgvJenisSer.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvJenisSer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJenisSer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJenisSer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJenisSer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idserviceDataGridViewTextBoxColumn,
            this.jenisserviceDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgvJenisSer.DataSource = this.viewServiceBindingSource;
            this.dgvJenisSer.Location = new System.Drawing.Point(554, 74);
            this.dgvJenisSer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvJenisSer.Name = "dgvJenisSer";
            this.dgvJenisSer.ReadOnly = true;
            this.dgvJenisSer.RowHeadersVisible = false;
            this.dgvJenisSer.RowHeadersWidth = 62;
            this.dgvJenisSer.Size = new System.Drawing.Size(886, 492);
            this.dgvJenisSer.TabIndex = 71;
            this.dgvJenisSer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJenisSer_CellClick);
            this.dgvJenisSer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJenisSer_CellContentClick);
            // 
            // idserviceDataGridViewTextBoxColumn
            // 
            this.idserviceDataGridViewTextBoxColumn.DataPropertyName = "id_service";
            this.idserviceDataGridViewTextBoxColumn.HeaderText = "id_service";
            this.idserviceDataGridViewTextBoxColumn.Name = "idserviceDataGridViewTextBoxColumn";
            this.idserviceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jenisserviceDataGridViewTextBoxColumn
            // 
            this.jenisserviceDataGridViewTextBoxColumn.DataPropertyName = "jenis_service";
            this.jenisserviceDataGridViewTextBoxColumn.HeaderText = "jenis_service";
            this.jenisserviceDataGridViewTextBoxColumn.Name = "jenisserviceDataGridViewTextBoxColumn";
            this.jenisserviceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "harga";
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            this.hargaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viewServiceBindingSource
            // 
            this.viewServiceBindingSource.DataMember = "ViewService";
            this.viewServiceBindingSource.DataSource = this.pROJEK8;
            // 
            // pROJEK8
            // 
            this.pROJEK8.DataSetName = "PROJEK8";
            this.pROJEK8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.Black;
            this.lbStatus.Location = new System.Drawing.Point(51, 285);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(74, 23);
            this.lbStatus.TabIndex = 58;
            this.lbStatus.Text = "STATUS";
            this.lbStatus.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btncari);
            this.panel3.Controls.Add(this.txtCari);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.BtnUbah);
            this.panel3.Controls.Add(this.BtnHapus);
            this.panel3.Controls.Add(this.BtnSimpan);
            this.panel3.Controls.Add(this.lbUser);
            this.panel3.Controls.Add(this.lbledit);
            this.panel3.Controls.Add(this.cbStatus);
            this.panel3.Controls.Add(this.txtHarga);
            this.panel3.Controls.Add(this.txtJenisSer);
            this.panel3.Controls.Add(this.label1);
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
            // btncari
            // 
            this.btncari.BackColor = System.Drawing.Color.SteelBlue;
            this.btncari.FlatAppearance.BorderSize = 0;
            this.btncari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncari.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncari.ForeColor = System.Drawing.Color.Honeydew;
            this.btncari.Location = new System.Drawing.Point(429, 103);
            this.btncari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncari.Name = "btncari";
            this.btncari.Size = new System.Drawing.Size(117, 37);
            this.btncari.TabIndex = 213;
            this.btncari.Text = "CARI";
            this.btncari.UseVisualStyleBackColor = false;
            this.btncari.Click += new System.EventHandler(this.btncari_Click);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(135, 103);
            this.txtCari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(277, 26);
            this.txtCari.TabIndex = 212;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(52, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 23);
            this.label6.TabIndex = 211;
            this.label6.Text = "CARI";
            // 
            // BtnUbah
            // 
            this.BtnUbah.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnUbah.FlatAppearance.BorderSize = 0;
            this.BtnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUbah.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUbah.ForeColor = System.Drawing.Color.Honeydew;
            this.BtnUbah.Location = new System.Drawing.Point(170, 465);
            this.BtnUbah.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnUbah.Name = "BtnUbah";
            this.BtnUbah.Size = new System.Drawing.Size(110, 37);
            this.BtnUbah.TabIndex = 163;
            this.BtnUbah.Text = "UBAH";
            this.BtnUbah.UseVisualStyleBackColor = false;
            this.BtnUbah.Click += new System.EventHandler(this.BtnUbah_Click_1);
            // 
            // BtnHapus
            // 
            this.BtnHapus.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnHapus.FlatAppearance.BorderSize = 0;
            this.BtnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHapus.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHapus.ForeColor = System.Drawing.Color.Honeydew;
            this.BtnHapus.Location = new System.Drawing.Point(330, 465);
            this.BtnHapus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnHapus.Name = "BtnHapus";
            this.BtnHapus.Size = new System.Drawing.Size(115, 37);
            this.BtnHapus.TabIndex = 162;
            this.BtnHapus.Text = "HAPUS";
            this.BtnHapus.UseVisualStyleBackColor = false;
            this.BtnHapus.Click += new System.EventHandler(this.BtnHapus_Click_1);
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnSimpan.FlatAppearance.BorderSize = 0;
            this.BtnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSimpan.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSimpan.ForeColor = System.Drawing.Color.Honeydew;
            this.BtnSimpan.Location = new System.Drawing.Point(11, 464);
            this.BtnSimpan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(98, 37);
            this.BtnSimpan.TabIndex = 161;
            this.BtnSimpan.Text = "SIMPAN";
            this.BtnSimpan.UseVisualStyleBackColor = false;
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click_1);
            // 
            // lbUser
            // 
            this.lbUser.Location = new System.Drawing.Point(1297, 0);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(219, 36);
            this.lbUser.TabIndex = 127;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(715, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 40);
            this.label3.TabIndex = 208;
            this.label3.Text = "Service";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl
            // 
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(850, 26);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(623, 63);
            this.lbl.TabIndex = 207;
            this.lbl.Text = "Dealer Bengkel Sempurna";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(335, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1574, 1014);
            this.panel1.TabIndex = 209;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.panel2.Controls.Add(this.label2);
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
            this.panel2.TabIndex = 210;
            // 
            // button14
            // 
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.Black;
            this.button14.Image = ((System.Drawing.Image)(resources.GetObject("button14.Image")));
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.Location = new System.Drawing.Point(4, 562);
            this.button14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(300, 49);
            this.button14.TabIndex = 131;
            this.button14.Text = "    JENIS KENDARAAN";
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ForeColor = System.Drawing.Color.Black;
            this.button18.Image = ((System.Drawing.Image)(resources.GetObject("button18.Image")));
            this.button18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button18.Location = new System.Drawing.Point(4, 503);
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
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(57, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 48);
            this.label2.TabIndex = 125;
            this.label2.Text = "DASHBOARD";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BtnSupplier
            // 
            this.BtnSupplier.FlatAppearance.BorderSize = 0;
            this.BtnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSupplier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupplier.ForeColor = System.Drawing.Color.Black;
            this.BtnSupplier.Image = ((System.Drawing.Image)(resources.GetObject("BtnSupplier.Image")));
            this.BtnSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSupplier.Location = new System.Drawing.Point(0, 444);
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
            // BtnServices
            // 
            this.BtnServices.FlatAppearance.BorderSize = 0;
            this.BtnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnServices.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnServices.ForeColor = System.Drawing.Color.Black;
            this.BtnServices.Image = ((System.Drawing.Image)(resources.GetObject("BtnServices.Image")));
            this.BtnServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnServices.Location = new System.Drawing.Point(4, 385);
            this.BtnServices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnServices.Name = "BtnServices";
            this.BtnServices.Size = new System.Drawing.Size(300, 49);
            this.BtnServices.TabIndex = 61;
            this.BtnServices.Text = "    SERVICES";
            this.BtnServices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnServices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnServices.UseVisualStyleBackColor = true;
            this.BtnServices.Click += new System.EventHandler(this.BtnServices_Click);
            // 
            // BtnMember
            // 
            this.BtnMember.FlatAppearance.BorderSize = 0;
            this.BtnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMember.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMember.ForeColor = System.Drawing.Color.Black;
            this.BtnMember.Image = ((System.Drawing.Image)(resources.GetObject("BtnMember.Image")));
            this.BtnMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMember.Location = new System.Drawing.Point(4, 326);
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
            this.BtnPosisi.Location = new System.Drawing.Point(4, 260);
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
            // viewServiceTableAdapter
            // 
            this.viewServiceTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(13, 868);
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
            // services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.panel1);
            this.Name = "services";
            this.Text = "services";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.services_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJenisSer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJEK8)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbledit;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtJenisSer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.DataGridView dgvJenisSer;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbWakt;
        private System.Windows.Forms.Button BtnUbah;
        private System.Windows.Forms.Button BtnHapus;
        private System.Windows.Forms.Button BtnSimpan;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSupplier;
        private System.Windows.Forms.Button BtnServices;
        private System.Windows.Forms.Button BtnMember;
        private System.Windows.Forms.Button BtnPosisi;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btncari;
        private PROJEK8 pROJEK8;
        private System.Windows.Forms.BindingSource viewServiceBindingSource;
        private PROJEK8TableAdapters.ViewServiceTableAdapter viewServiceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idserviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisserviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}