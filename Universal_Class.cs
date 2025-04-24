using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dealer_BengkelSempurna
{
    class Universal_Class
    {
        public string GetConnectionDB()
        {
            // sekar
            // string ConnectionString = @"Integrated Security=true; Data Source=LAPTOP-2F1SV60V\MSSQLSERVER01; Initial Catalog=TokoSakura";
            // salma
            string connectionstring = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = PROJEK08";
            return connectionstring;
        }

        public string autogenerateID(string firstText, string query)
        {
            string connectionString = GetConnectionDB();
            SqlCommand sqlCmd;
            SqlConnection sqlCon;
            string result = "";
            int num = 0;
            try
            {
                sqlCon = new SqlConnection(connectionString);
                sqlCon.Open();
                sqlCmd = new SqlCommand(query, sqlCon);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                if (reader.Read())
                {
                    string last = reader[0].ToString();
                    num = Convert.ToInt32(last.Remove(0, firstText.Length)) + 1;
                }
                else
                {
                    num = 1;
                }
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal generate id, error: " + ex.Message);
            }
            result = firstText + num.ToString().PadLeft(3, '0');
            return result;
        }


        public void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    ClearTextBoxes(ctrl.Controls);
                }
            }
        }

        public void numberOnly(KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        public void noEmpty(TextBox textBox, Label label)
        {
            if (textBox.Text == "")
            {
                label.Visible = true;
            }
            else
            {
                label.Visible = false;
            }
        }

        public void alphabetOnly(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        public void separatorHarga(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                return;
            }
            else
            {
                textBox.Text = string.Format("{0:n0}", Int32.Parse(textBox.Text));
                textBox.SelectionStart = textBox.Text.Length;
            }
        }



        public string cariSalahSatuData(string namaSP, string namaParameter, string data)
        {
            string hasil = "";
            DataTable ds = new DataTable();
            try
            {
                string connectionString = GetConnectionDB();
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand nama = new SqlCommand(namaSP, con);
                nama.CommandType = CommandType.StoredProcedure;
                nama.Parameters.AddWithValue(namaParameter, data);
                SqlDataAdapter adapter1 = new SqlDataAdapter(nama);
                adapter1.Fill(ds);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            if (ds.Rows.Count != 0)
            {
                hasil = ds.Rows[0][0].ToString();
            }
            return hasil;
        }

        public string tampilDashboard(string namaSP, string tanggalAwal, string tanggalAkhir)
        {
            string hasil = "";
            DataTable ds = new DataTable();
            try
            {
                string connectionString = GetConnectionDB();
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand nama = new SqlCommand(namaSP, con);
                nama.CommandType = CommandType.StoredProcedure;
                nama.Parameters.AddWithValue("TanggalAWal", tanggalAwal);
                nama.Parameters.AddWithValue("TanggalAkhir", tanggalAkhir);
                SqlDataAdapter adapter1 = new SqlDataAdapter(nama);
                adapter1.Fill(ds);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            if (ds.Rows.Count == 0)
            {
                MessageBox.Show("Data tidak ditemukan");
            }
            else
            {
                hasil = ds.Rows[0][0].ToString();
            }
            return hasil;
        }


        public void ubahTampilanData(string namaSP, string namaParameter, DataGridView dg, int kolomData)
        {
            for (int hitungan = 0; hitungan < dg.Rows.Count; hitungan++)
            {
                string data = dg[kolomData, hitungan].Value.ToString();
                dg[kolomData, hitungan].Value = cariSalahSatuData(namaSP, namaParameter, data);
            }
        }
    
}
}

