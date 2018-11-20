using AlmacenDeBebidasRP.DBConnection;
using AlmacenDeBebidasRP.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AlmacenDeBebidasRP.DB.DAO
{
    public class ProductoDAO
    {

        private ConexionDB conexion;

        public ProductoDAO() { this.conexion = new ConexionDB(); }

        public bool AgregarProducto(Producto producto)
        {
            String consultaVerificacion = "SELECT * FROM Stock WHERE ID_PRODUCTO=" + producto.GetIDProducto();
            List<Producto> productosExistentes = this.EjecutarConsultaDeLectura(consultaVerificacion);
            if (productosExistentes.Count() > 0) return false;
            else
            {
                String consulta = "INSERT INTO Stock(ID_PRODUCTO, NOMBRE, CATEGORIA, ORIGEN, PRECIO_USS, PRECIO_ARS) VALUES(";
                consulta += producto.GetIDProducto();
                consulta += ",";
                consulta += "'" + producto.GetNombreProducto() + "'";
                consulta += ",";
                consulta += "'" + producto.GetCategoria() + "'";
                consulta += ",";
                consulta += "'" + producto.GetOrigen() + "'";
                consulta += ",";
                if (producto.GetPrecioUss() == null)
                {
                    consulta += "NULL";
                }
                else
                {
                    consulta += producto.GetPrecioUss();
                }
                consulta += ",";
                consulta += producto.GetPrecioArs();
                consulta += ")";

                this.EjecutarConsultaDeEscritura(consulta);
                return true;
            }
        }

        public bool EliminarProducto(int idProducto)
        {
            String consultaVerificacion = "SELECT * FROM Stock WHERE ID_PRODUCTO=" + idProducto;
            List<Producto> productos = this.EjecutarConsultaDeLectura(consultaVerificacion);
            if (productos.Count() == 1)
            {
                String consultaEliminacion = "DELETE FROM Stock WHERE ID_PRODUCTO=" + idProducto;
                this.EjecutarConsultaDeEscritura(consultaEliminacion);
                return true;
            }
            else if (productos.Count() == 0) return false;
            else throw new Exception("ERROR: Hay varios productos con dicho ID");
        }

        public List<Producto> BuscarProductos(String clausulaWhere)
        {
            String consulta = "SELECT * FROM Stock WHERE " + clausulaWhere;
            return this.EjecutarConsultaDeLectura(consulta);
        }

        private void EjecutarConsultaDeEscritura(String SQL)
        {
            conexion.GetConexion().Open();
            SqlCommand comando = new SqlCommand(SQL, this.conexion.GetConexion());
            comando.ExecuteNonQuery();
            conexion.GetConexion().Close();
        }

        private List<Producto> EjecutarConsultaDeLectura(String consultaSQL)
        {
            conexion.GetConexion().Open();
            SqlCommand comando = new SqlCommand(consultaSQL, this.conexion.GetConexion());
            SqlDataReader dataReader = comando.ExecuteReader();
            List<Producto> productos = this.ParsearProductos(dataReader);
            dataReader.Close();
            conexion.GetConexion().Close();
            return productos;
        }

        public bool ModificarProducto(int idProducto, Producto nuevoProducto)
        {
            String consulta = "UPDATE Stock SET ";
            consulta += "NOMBRE = ";
            consulta += "'" + nuevoProducto.GetNombreProducto() + "'";
            consulta += ", CATEGORIA = ";
            consulta += "'" + nuevoProducto.GetCategoria() + "'";
            consulta += ", ORIGEN = ";
            consulta += "'" + nuevoProducto.GetOrigen() + "'";
            consulta += ", ";
            if (nuevoProducto.GetPrecioUss() == null)
            {
                consulta += "PRECIO_USS = NULL";
            }
            else
            {
                consulta += "PRECIO_USS = ";
                consulta += nuevoProducto.GetPrecioUss();
            }
            consulta += ", PRECIO_ARS = ";
            consulta += nuevoProducto.GetPrecioArs();
            consulta += (" WHERE ID_PRODUCTO = " + idProducto);

            this.EjecutarConsultaDeEscritura(consulta);
            return true;
        }

        private List<Producto> ParsearProductos(SqlDataReader sqlDataReader)
        {
            List<Producto> productos = new List<Producto>();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    int id = (int)sqlDataReader["ID_PRODUCTO"];
                    String nombre = sqlDataReader["NOMBRE"].ToString();
                    String categoria = sqlDataReader["CATEGORIA"].ToString();
                    String origen = sqlDataReader["ORIGEN"].ToString();
                    double precio;
                    if (origen == "NACIONAL")
                    {
                        precio = Double.Parse(sqlDataReader["PRECIO_ARS"].ToString());
                    }
                    else
                    {
                        precio = Double.Parse(sqlDataReader["PRECIO_USS"].ToString());
                    }
                    productos.Add(new Producto(id, nombre, categoria, origen, precio));
                }
            }
            return productos;
        }


    }
}