using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaCodigo;
using CapaEntidades;
namespace CapaDao
{
    class clsActoresDao:clsConexion
    {
        public void InsertarActores(clsActores act)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTACTORES", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NOM", act.nombre);
            cmd.Parameters.AddWithValue("@SEX", act.sexo);
            cmd.Parameters.AddWithValue("@PAIS", act.pais);
            cmd.Parameters.AddWithValue("@FECNAC", act.fecnac);
            cmd.ExecuteNonQuery();

        }
        public void ModificarActores(clsActores act)
        {
            SqlCommand cmd = new SqlCommand("SP_ACTUALIZARACTORES", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NOM", act.nombre);
            cmd.Parameters.AddWithValue("@SEX", act.sexo);
            cmd.Parameters.AddWithValue("@PAIS", act.pais);
            cmd.Parameters.AddWithValue("@FECNAC", act.fecnac);
            cmd.Parameters.AddWithValue("@COD", act.codAcotr);
            cmd.ExecuteNonQuery();

        }
        public void EliminarActores(clsActores act)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARACTOR", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@COD", act.codAcotr);
            cmd.ExecuteNonQuery();

        }
    }
}
