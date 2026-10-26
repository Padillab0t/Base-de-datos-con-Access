using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO; // <--- AGREGADO
using System.Text;

namespace EscuelaBaseDeDatos
{
    internal class ConexionBD
    {
        public static OleDbConnection ObtenerConexion()
        {
            string rutaBD = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Datos",
                "escuela.accdb"
            );

            // Se corrigió OLED8 por OLEDB
            string cadenaConexion =
                $"Provider=Microsoft.ACE.OLEDB.12.0;" +
                $"Data Source={rutaBD};";

            // Se crea la conexión y se retorna
            return new OleDbConnection(cadenaConexion);
        }
    }
}