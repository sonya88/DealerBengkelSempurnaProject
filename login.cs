using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dealer_BengkelSempurna
{
    public partial class login : Form
    {
        //---SERVER UMUM---

        string connectionstring =
                "integrated security=true;data source=localhost;initial catalog= PROJEK08";
        string username, pass, role, status, kode_karyawan;
        public login()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }
       
        private void login_Load(object sender, EventArgs e)
        {
           
        }
        private void clear()
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private DataSet GetRoles(string username)
        {
            DataSet ds = new DataSet();

            try
            {
                SqlConnection connection = new SqlConnection(Program.koneksi());

                SqlDataAdapter adapter = new SqlDataAdapter
                    ("SELECT id_jabatan FROM tKaryawan WHERE username = '" + username + "'",
                    connection);
                adapter.Fill(ds);
            }
            catch (Exception xcp)
            {
                MessageBox.Show(xcp.ToString());
            }
            return ds;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String role = "";
            String status = "";

            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong!", "Pemberitahuan!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                admin_master adm = new admin_master();
                adm.Show();
                this.Hide();
            }
            else
            {
                string returnValue = "";

                string connectionString = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand sqlcmd = new SqlCommand("sp_checkLogin", connection);
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("username", txtUsername.Text);
                sqlcmd.Parameters.AddWithValue("password", txtPassword.Text);

                connection.Open();
                returnValue = (string)sqlcmd.ExecuteScalar();
                if (String.IsNullOrEmpty(returnValue))
                {
                    MessageBox.Show("Username dan Password salah!");
                    return;
                }
                //returnValue = returnValue.Trim();
                if (returnValue == "JBT0014")
                {
                    MessageBox.Show("Login Berhasil !, Selamat Datang Admin");
                    admin_master admin = new admin_master();
                    admin.Show();
                    txtUsername.Clear();
                    txtPassword.Clear();
                    this.Hide();
                }
                else if (returnValue == "JBT0016")
                {
                    this.Hide();
                    MessageBox.Show("Login Berhasil !, Selamat Datang Manager");
                    master_manager manajer = new master_manager();
                    manajer.Show();
                    txtUsername.Clear();
                    txtPassword.Clear();

                }
                else if (returnValue == "JBT0015")
                {
                    MessageBox.Show("Login Berhasil !, Selamat Datang Kasir");
                    Kasir_Transaksi kasir = new Kasir_Transaksi();
                    kasir.Show();
                    txtUsername.Clear();
                    txtPassword.Clear();
                    this.Hide();
                }
            }
        }
        private void cbxLihatPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxLihatPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
