using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace PROYECTOTUTI
{
    internal class BaseDeDatos
    {
        public SqlConnection oCon;
        public SqlCommand oCom;
        public SqlDataAdapter oDA;

        string Cadena;
        private static string cadenaConexion = "server= DESKTOP-95KD8UJ\\SQLEXPRESS02 ; database = TutiShop ; INTEGRATED SECURITY = true;";
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection oCon = new SqlConnection(cadenaConexion);
            return oCon;
        }
        public BaseDeDatos()
        {
            oCon = ObtenerConexion();
            oCon.Open();
        }
        public bool cerrarConexion()
        {
            oCon.Close();
            return true;
        }
        public bool insertarDatos(string Tabla, string Campos, string Datos)
        {
            try
            {
                ObtenerConexion();
                if (oCon.State == ConnectionState.Closed)
                {
                    oCon.Open();
                }
                Cadena = "Insert into " + Tabla + " (" + Campos + ") values( " + Datos + ")";
                oCom = new SqlCommand(Cadena, oCon);
                oCom.ExecuteNonQuery();
                cerrarConexion();
                if (oCon.State == ConnectionState.Open)
                {
                    oCon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            return true;

        }

        public bool eliminarDatos(string Tabla, string Condicion)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    if (Tabla == "Productos")
                    {
                        string codigoProducto = Condicion.Split('=')[1].Trim().Replace("'", "");
                        string eliminarImagenes = "DELETE FROM ImagenesProducto WHERE CodigoProducto = @CodigoProducto";
                        using (SqlCommand comandoImagenes = new SqlCommand(eliminarImagenes, conexion))
                        {
                            comandoImagenes.Parameters.AddWithValue("@CodigoProducto", codigoProducto);
                            comandoImagenes.ExecuteNonQuery();
                        }
                    }

                    string eliminarProducto = "DELETE FROM " + Tabla + " WHERE " + Condicion;
                    using (SqlCommand comandoProducto = new SqlCommand(eliminarProducto, conexion))
                    {
                        comandoProducto.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
                return false;
            }
            return true;
        }

        public void eliminarDatos2(string tabla, string condicion, int idSucursal)
        {
            try
            {
                using (SqlConnection oCon = ObtenerConexion())
                {
                    oCon.Open();
                    using (SqlCommand oCom = new SqlCommand($"DELETE FROM {tabla} WHERE {condicion} AND IDSucursal = @vIDSucursal", oCon))
                    {
                        oCom.Parameters.AddWithValue("@vIDSucursal", idSucursal);
                        oCom.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void eliminarImagenesProducto(int codigo, int idSucursal)
        {
            try
            {
                using (SqlConnection oCon = ObtenerConexion())
                {
                    oCon.Open();
                    using (SqlCommand oCom = new SqlCommand(
                        "DELETE FROM ImagenesProducto WHERE CodigoProducto = @vCodigo AND IDSucursal = @vIDSucursal", oCon))
                    {
                        oCom.Parameters.AddWithValue("@vCodigo", codigo);
                        oCom.Parameters.AddWithValue("@vIDSucursal", idSucursal);
                        oCom.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar las imágenes del producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool actualizarDatos(string Tabla, string Datos, string Condicion)
        {
            try
            {
                ObtenerConexion();
                if (oCon.State == ConnectionState.Closed)
                {
                    oCon.Open();
                }
                Cadena = "Update " + Tabla + " set " + Datos + " where " + Condicion;
                oCom = new SqlCommand(Cadena, oCon);
                oCom.ExecuteNonQuery();
                cerrarConexion();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }

        }

        public DataTable retornaRegistros(string Sentencia, params SqlParameter[] parametros)
        {
            DataTable oDT = new DataTable();
            if (Sentencia.Length > 0)
            {
                try
                {
                    ObtenerConexion();
                    oCom = new SqlCommand(Sentencia, oCon);

                    if (parametros != null)
                    {
                        oCom.Parameters.AddRange(parametros);
                    }

                    oDA = new SqlDataAdapter(oCom);
                    oDA.Fill(oDT);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al retornar registros: " + ex.Message);
                }
                finally
                {
                    cerrarConexion();
                }
            }
            return oDT;
        }

        public string InsertarProducto(int Codigo, string NombreProducto, string Talla, int Cantidad, float PrecioUnitario, string Color, string Marca, string Categoria, string SubCategoria, float Descuento, int IDSucursal, List<Image> imagenes)
        {
            string mensaje = "Se insertó correctamente";
            try
            {
                using (SqlConnection oCon = ObtenerConexion())
                {
                    oCon.Open();
                    using (SqlCommand oCom = new SqlCommand(
                        "INSERT INTO Productos (Codigo, NombreProducto, Talla, EnStock, PrecioUnitario, Color, Marca, Categoria, SubCategoria, Descuento, IDSucursal) " +
                        "VALUES (@vCodigo, @vNombreProducto, @vTalla, @vEnStock, @vPrecioUnitario, @vColor, @vMarca, @vCategoria, @vSubCategoria, @vDescuento, @vIDSucursal)", oCon))
                    {
                        oCom.Parameters.AddWithValue("@vCodigo", Codigo);
                        oCom.Parameters.AddWithValue("@vNombreProducto", NombreProducto);
                        oCom.Parameters.AddWithValue("@vTalla", Talla);
                        oCom.Parameters.AddWithValue("@vEnStock", Cantidad);
                        oCom.Parameters.AddWithValue("@vPrecioUnitario", PrecioUnitario);
                        oCom.Parameters.AddWithValue("@vColor", Color);
                        oCom.Parameters.AddWithValue("@vMarca", Marca);
                        oCom.Parameters.AddWithValue("@vCategoria", Categoria);
                        oCom.Parameters.AddWithValue("@vSubCategoria", SubCategoria);
                        oCom.Parameters.AddWithValue("@vDescuento", Descuento);
                        oCom.Parameters.AddWithValue("@vIDSucursal", IDSucursal);

                        oCom.ExecuteNonQuery();
                    }

                    // IMAGENES
                    foreach (var imagen in imagenes)
                    {
                        using (SqlCommand oComImg = new SqlCommand(
                            "INSERT INTO ImagenesProducto (CodigoProducto, Imagen) " +
                            "VALUES (@vCodigoProducto, @vImagen)", oCon))
                        {
                            oComImg.Parameters.AddWithValue("@vCodigoProducto", Codigo);

                            using (MemoryStream ms = new MemoryStream())
                            {
                                imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                                oComImg.Parameters.AddWithValue("@vImagen", ms.ToArray());
                            }

                            oComImg.ExecuteNonQuery();
                        }
                    }
                } 
            }
            catch (SqlException ex)
            {
                mensaje = "Error de base de datos: " + ex.Message;
            }
            catch (Exception ex)
            {
                mensaje = "Error inesperado: " + ex.Message;
            }
            return mensaje;
        }

        public string ActualizarProducto(int Codigo, string NombreProducto, string Talla, int Cantidad, float PrecioUnitario, string Color, string Marca, string Categoria, string SubCategoria, float Descuento, int IDSucursal)
        {
            string mensaje = "Se actualizó correctamente";
            try
            {
                using (SqlConnection oCon = ObtenerConexion())
                {
                    oCon.Open();
                    using (SqlCommand oCom = new SqlCommand(
                        "UPDATE Productos SET " +
                        "NombreProducto = @vNombreProducto, " +
                        "Talla = @vTalla, " +
                        "EnStock = @vEnStock, " +
                        "PrecioUnitario = @vPrecioUnitario, " +
                        "Color = @vColor, " +
                        "Marca = @vMarca, " +
                        "Categoria = @vCategoria, " +
                        "SubCategoria = @vSubCategoria, " +
                        "Descuento = @vDescuento, " +
                        "IDSucursal = @vIDSucursal " +
                        "WHERE Codigo = @vCodigo", oCon))
                    {
                        oCom.Parameters.AddWithValue("@vCodigo", Codigo);
                        oCom.Parameters.AddWithValue("@vNombreProducto", NombreProducto);
                        oCom.Parameters.AddWithValue("@vTalla", Talla);
                        oCom.Parameters.AddWithValue("@vEnStock", Cantidad);
                        oCom.Parameters.AddWithValue("@vPrecioUnitario", PrecioUnitario);
                        oCom.Parameters.AddWithValue("@vColor", Color);
                        oCom.Parameters.AddWithValue("@vMarca", Marca);
                        oCom.Parameters.AddWithValue("@vCategoria", Categoria);
                        oCom.Parameters.AddWithValue("@vSubCategoria", SubCategoria);
                        oCom.Parameters.AddWithValue("@vDescuento", Descuento);
                        oCom.Parameters.AddWithValue("@vIDSucursal", IDSucursal);

                        oCom.ExecuteNonQuery();
                    }
                } 
            }
            catch (SqlException ex)
            {
                mensaje = "Error de base de datos: " + ex.Message;
            }
            catch (Exception ex)
            {
                mensaje = "Error inesperado: " + ex.Message;
            }
            return mensaje;
        }

        public string GenerarNuevoIDEmpleado()
        {
            string nuevoID = "E0004"; 

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string query = "SELECT MAX(idEmpleado) AS UltimoID FROM InicioSesion01";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        string ultimoID = result.ToString();
                        if (!string.IsNullOrEmpty(ultimoID))
                        {
                            int numero = int.Parse(ultimoID.Substring(1)) + 1;
                            nuevoID = "E" + numero.ToString("D4");
                        }
                    }
                }
            }

            return nuevoID;
        }
        public void ejecutarComando(string consulta)
        {
            try
            {
                oCon.Open();
                SqlCommand comando = new SqlCommand(consulta, oCon);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar comando: " + ex.Message);
            }
            finally
            {
                oCon.Close();
            }
        }
        public string AgregarPedido(string proveedor, string producto, int nuevaCant, string fecha, string Hora, decimal precioUnitario, decimal subtotal)
        {
            string mensaje = "Pedido agregado correctamente.";
            try
            {
                ObtenerConexion();
                if (oCon.State == ConnectionState.Closed)
                {
                    oCon.Open();
                }

                string consulta = @"INSERT INTO Pedidos (Proveedor, Producto, NuevaCant, Fecha, Hora, PrecioUnitario, SubTotal) 
                VALUES (@Proveedor, @Producto, @NuevaCant, @Fecha, @Hora, @PrecioUnitario, @SubTotal)";

                using (SqlCommand comando = new SqlCommand(consulta, oCon))
                {
                    comando.Parameters.AddWithValue("@Proveedor", proveedor);
                    comando.Parameters.AddWithValue("@Producto", producto);
                    comando.Parameters.AddWithValue("@NuevaCant", nuevaCant);
                    comando.Parameters.AddWithValue("@Fecha", fecha);
                    comando.Parameters.AddWithValue("@Hora", Hora);
                    comando.Parameters.AddWithValue("@PrecioUnitario", precioUnitario);
                    comando.Parameters.AddWithValue("@SubTotal", subtotal);

                    comando.ExecuteNonQuery();
                }

                oCon.Close();
                if (oCon.State == ConnectionState.Open)
                {
                    oCon.Close();
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al agregar pedido: " + ex.Message;
            }
            return mensaje;
        }
        public string RegistrarHistorialPedido(string proveedor, string producto, int cantidad, DateTime fechaHora, int idPedido, decimal precioUnitario, decimal subtotal)
        {
            string mensaje = "Pedido registrado exitosamente";
            try
            {
                ObtenerConexion();
                if (oCon.State == ConnectionState.Closed)
                {
                    oCon.Open();
                }
                using (SqlCommand oCom = new SqlCommand("INSERT INTO HistorialPedidos (Proveedor, Producto, Cantidad, Fecha, Hora, idPedido, PrecioUnitario, Subtotal) " +
                                                        "VALUES (@Proveedor, @Producto, @Cantidad, @Fecha, @Hora, @idPedido, @PrecioUnitario, @Subtotal)", oCon))
                {
                    oCom.Parameters.AddWithValue("@Proveedor", proveedor);
                    oCom.Parameters.AddWithValue("@Producto", producto);
                    oCom.Parameters.AddWithValue("@Cantidad", cantidad);
                    oCom.Parameters.AddWithValue("@Fecha", fechaHora.Date);
                    oCom.Parameters.AddWithValue("@Hora", fechaHora.ToString("HH:mm:ss"));
                    oCom.Parameters.AddWithValue("@idPedido", idPedido);
                    oCom.Parameters.AddWithValue("@PrecioUnitario", precioUnitario);
                    oCom.Parameters.AddWithValue("@Subtotal", subtotal);
                    oCom.ExecuteNonQuery();
                }
                oCon.Close();
                if (oCon.State == ConnectionState.Open)
                {
                    oCon.Close();
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al registrar en historial: " + ex.Message;
            }
            return mensaje;
        }
    }
}
