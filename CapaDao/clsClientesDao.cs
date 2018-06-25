using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;
namespace CapaCodigo
{
    public class clsClientesDao:clsConexion
    {
        clsclientes oCli = new clsclientes();

        public void InsertarClientes(clsclientes cli)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_CLIENTES", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NOMBRE", cli.nombres);
            cmd.Parameters.AddWithValue("@DIRECCION", cli.direccion);
            cmd.Parameters.AddWithValue("@TELEFONO", cli.telefono);
            cmd.Parameters.AddWithValue("@DNI", cli.dni);
            cmd.ExecuteNonQuery();

        }
        
        //public DataTable llenarClientes()
        //{
        //    try
        //    {
        //        SqlCommand llenar = new SqlCommand("select * from clientes", Conectar());
        //        llenar.CommandType= CommandType.StoredProcedure;

        //    }
        //    catch
        //    {
        //        return llenar;
        //    }
        //}



    }
}
