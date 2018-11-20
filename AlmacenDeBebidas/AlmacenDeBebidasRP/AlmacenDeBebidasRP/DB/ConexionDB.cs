using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AlmacenDeBebidasRP.DBConnection
{
    public class ConexionDB
    {

        private SqlConnection conexion;

        public ConexionDB()
        {
            conexion = new SqlConnection(
                "Data Source = localhost;" +
                "Initial Catalog = AlmacenDeBebidasRP;" +
                "Integrated Security = True;"
                );
        }

        internal void abrir()
        {
            throw new NotImplementedException();
        }

        public SqlConnection GetConexion() { return this.conexion; }

    }
}