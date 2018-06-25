using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Data.SqlClient;

namespace CapaCodigo
{
    public class clsEmpleadosDao :clsConexion
    {
        public Boolean VerificarAcceso(clsEmpleadoEntity  em)
        {
           
            SqlCommand cmd = new SqlCommand("PA_ACCESO_SISTEMA", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@USU", em.ususario);
            cmd.Parameters.AddWithValue("@CLAVE", em.clave);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
