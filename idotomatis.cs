using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealer_BengkelSempurna
{
    class IdOtomatis
    {
        string result;
        public void setID(string firstText, string sp)
        {
            string connectionstring = "integrated security = true; data source = LAPTOP-INB51L5O\\MSSQLSERVER01; initial catalog = DealerBengkelSempurna";
            SqlConnection sqlCon = new SqlConnection(connectionstring);
            SqlCommand sqlCmd;
            int num = 0;
            try
            {
                sqlCmd = new SqlCommand(sp, sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();
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
                if (num < 10)
                {
                    result = firstText + "000" + num;
                }
                else if (num < 100)
                {
                    result = firstText + "00" + num;
                }
                else if (num < 1000)
                {
                    result = firstText + "0" + num;
                }
                else
                {
                    result = firstText + num;
                }
                //dr.Close();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught: {0}", ex);
            }
        }
        public string getID()
        {
            return result;
        }
    }
   
            
}

