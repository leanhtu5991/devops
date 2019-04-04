using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EvalWinApp.DAL
{
    public class FormationDB
    {
        public static DataTable GetAllFormations()
        {
            string connString = "Data Source=WIN-98FG9BJUO00\\sqlexpress;Initial Catalog=AgoraCL;Integrated Security=True";
            DataTable dtGetForm = new DataTable();
            using (SqlConnection con = new SqlConnection(connString))
            {
                

                try
                {
                    string spName = @"dbo.GetAllFormations";
                    SqlCommand cmdGetForm = new SqlCommand(spName, con);
                    cmdGetForm.CommandType = CommandType.StoredProcedure;

                    con.Open();
                    SqlDataReader drGetForm = cmdGetForm.ExecuteReader();
                    dtGetForm.Load(drGetForm);
                }
                catch (Exception e)
                {
                    
                }
                finally
                {
                    con.Close();
                }


                return dtGetForm;
            }
            
        }

        public static string AddOneFormation(string titre, string description, string programme)
        {
            string status = "Not started....";
            string connString = "Data Source=WIN-98FG9BJUO00\\sqlexpress;Initial Catalog=AgoraCL;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string spName = @"CreateFormation";
                SqlCommand cmdCreFormation = new SqlCommand(spName, conn);
                cmdCreFormation.CommandType = CommandType.StoredProcedure;

                //Paramètre libelle
                SqlParameter titreParam= new SqlParameter();
                titreParam.ParameterName = "@titre";
                titreParam.Value = titre;
                cmdCreFormation.Parameters.Add(titreParam);

                //Paramètre Description
                SqlParameter descParam = new SqlParameter();
                descParam.ParameterName = "@description";
                descParam.Value = description;
                cmdCreFormation.Parameters.Add(descParam);


                //Paramètre programme
                SqlParameter progParam = new SqlParameter();
                progParam.ParameterName = @"programme";
                progParam.Value = programme;
                cmdCreFormation.Parameters.Add(progParam);

                try
                {
                    conn.Open();
                    cmdCreFormation.ExecuteNonQuery();
                    status = "Enregistrement ok";
                }
                catch (Exception e)
                {
                    status = "Erreur détectée: " + e.Message;
                }
                finally
                {
                    conn.Close();
                }

                //paramètre date
            }
            
            return status;
        }
    }
}
