using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dealer_BengkelSempurna.Master.Posisi;
using System.Data.SqlClient;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Data;
using Dealer_BengkelSempurna.Master.Member;
using Dealer_BengkelSempurna.Master.Services;

namespace Dealer_BengkelSempurna
{
    static class Program
    {
        private static readonly object sqlCon;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new admin_master());
        }

        
        public static string koneksi()
        {
            return "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = DealerBengkelSempurna";
        }

        public static string toRupiah(int angka)
        {
            return String.Format(CultureInfo.CreateSpecificCulture("id-id"), "{0:N}", angka);
        }

        public static int toAngka(string rupiah)
        {
            return int.Parse(Regex.Replace(rupiah, @",.*|\D", ""));
        }

        public static string autogenerateID(string firstText, string sp)
        {
            string result = "";
            string connectionstring = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = DealerBengkelSempurna";
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            SqlCommand sqlCmd;
            int num = 0;
            try
            {
                sqlCmd = new SqlCommand(sp, connection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader dr = sqlCmd.ExecuteReader();
                dr.Read();
                if (dr["idReturn"].ToString() == "")
                {
                    num = 1;
                }
                else
                {
                    num = Int32.Parse(dr["idReturn"].ToString());
                }
                if (num < 10000)
                {
                    result = firstText + "000" + num;
                }
                else if (num < 100000)
                {
                    result = firstText + "00" + num;
                }
                else if (num < 1000000)
                {
                    result = firstText + "0" + num;
                }
                else
                {
                    result = firstText + num;
                }
                dr.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught: {0}", ex);
            }

            return result;
        }
    }
}
