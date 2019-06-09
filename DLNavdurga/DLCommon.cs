using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
namespace DLNavdurga
{
    public class DLCommon
    {
        public static DataTable GetDataTable(string sQuery)
        {            
            DataTable dtPrescription = new DataTable();
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            string MyConnection2 = ConfigurationManager.ConnectionStrings["MySQL"].ToString();
            try
            {
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(sQuery, MyConn2);
                MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                MySqlCommandBuilder builder = new MySqlCommandBuilder(MyAdapter);  
                MyAdapter.Fill(dtPrescription);
            }
            catch (Exception e)
            {
                string str = e.Message;
                System.Windows.Forms.MessageBox.Show(str);
            }
            return dtPrescription;
        }
        public static DataTable SaveDetails(string sQuery)
        {
            DataTable dtPrescription = new DataTable();
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            string MyConnection2 = ConfigurationManager.ConnectionStrings["MySQL"].ToString();
            try
            {
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(sQuery, MyConn2);
                MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                MySqlCommandBuilder builder = new MySqlCommandBuilder(MyAdapter);
                MyAdapter.Fill(dtPrescription);
            }
            catch (Exception e)
            { }
            return null;
        }



        public static bool SaveDataTable(string sQuery, DataTable dtPrescription)
        {
            //string Query = "select * from db_navdurgahospital.tbl_prescription;";
            MySqlDataAdapter MyAdapter;
            string MyConnection2 = ConfigurationManager.ConnectionStrings["MySQL"].ToString();
            try
            {
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(sQuery, MyConn2);
                MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                MySqlCommandBuilder builder = new MySqlCommandBuilder(MyAdapter);
                MyAdapter.UpdateCommand = builder.GetUpdateCommand();
                MyAdapter.DeleteCommand = builder.GetDeleteCommand();
                MyAdapter.InsertCommand = builder.GetInsertCommand();

                MyAdapter.Update(dtPrescription);
            }
            catch (Exception e)
            { return false; }
            return true;
        }

        static public string ExecuteScalar(string sQuery)
        {
            String retValue = String.Empty;
            string MyConnection2 = ConfigurationManager.ConnectionStrings["MySQL"].ToString();
            using (MySqlConnection conn = new MySqlConnection(MyConnection2))
            {
                MySqlCommand cmd = new MySqlCommand(sQuery, conn);                
                try
                {
                    conn.Open();
                    retValue = cmd.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return retValue;
        }

        static public void ExecuteNonQuery(string sQuery)
        {            
            string MyConnection2 = ConfigurationManager.ConnectionStrings["MySQL"].ToString();
            using (MySqlConnection conn = new MySqlConnection(MyConnection2))
            {
                MySqlCommand cmd = new MySqlCommand(sQuery, conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
