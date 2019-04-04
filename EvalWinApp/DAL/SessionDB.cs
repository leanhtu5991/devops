using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EvalWinApp.DAL
{
    public class SessionDB
    {
        public static DataTable getAllSessions()
        {
            DataTable dtAllSess = new DataTable();

            string conString = "Data Source=WIN-98FG9BJUO00\\sqlexpress;Initial Catalog=AgoraCL;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    string spName = @"GetAllSessions";
                    SqlCommand cmdAllSess = new SqlCommand(spName, con);
                    cmdAllSess.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    
                    SqlDataReader rdAllSess = cmdAllSess.ExecuteReader();
                    dtAllSess.Load(rdAllSess);
                }
                catch
                { }
                finally
                {
                    con.Close();
                }
            }
                return dtAllSess;
        }
       
    }
}
