using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EvalWinApp.DAL
{
    public class ParticipantDB
    {
        public static DataTable GetAllParticipants()
        {
            string connString = "Data Source=WIN-98FG9BJUO00\\sqlexpress;Initial Catalog=AgoraCL;Integrated Security=True"; 
            DataTable dtAllPart = new DataTable();
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    string spName = @"dbo.GellallParticipants";
                    SqlCommand cmdGetAllPart = new SqlCommand(spName, con);
                    cmdGetAllPart.CommandType = CommandType.StoredProcedure;

                    con.Open();

                    SqlDataReader drAllpart = cmdGetAllPart.ExecuteReader();
                    dtAllPart.Load(drAllpart);
                    return dtAllPart;
                }
                catch (SqlException ex)
                {
                    return dtAllPart;
                }
                catch (Exception e)
                {
                    return dtAllPart;
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
