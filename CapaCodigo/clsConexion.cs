using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace CapaCodigo
{
    public abstract class clsConexion
    {
        protected SqlConnection Conectar()
        {
            SqlConnection
            cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["xcon"].ConnectionString);
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
            else
            {
                cnx.Open();
            }
            return cnx;
        }
    }
}
