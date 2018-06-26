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

        public DataTable llenarClientes()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from CLIENTES", Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public DataTable GenerarCodigoCliente()
        {
            SqlDataAdapter da = new SqlDataAdapter("GENERAR_CODIGO_CLIENTE", Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public void EliminarCliente(int i)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_CLIENTE", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", i);
            cmd.ExecuteNonQuery();
        }

        public void ActualizarClientes(clsclientes cli)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_CLIENTES", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", cli.codclient);
            cmd.Parameters.AddWithValue("@NOMBRE", cli.nombres);
            cmd.Parameters.AddWithValue("@DIRECCION", cli.direccion);
            cmd.Parameters.AddWithValue("@TELEFONO", cli.telefono);
            cmd.Parameters.AddWithValue("@DNI", cli.dni);
            cmd.ExecuteNonQuery();
        }
    }
}
