using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Hoteles_webService
{
    /// <summary>
    /// Descripción breve de MetodosWeb_Hoteles
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class MetodosWeb_Hoteles : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet GetAllFromHoteles()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source = DESKTOP-IMJK6TH; Initial Catalog = Prueba_AXEDE; Integrated Security = true";
            SqlDataAdapter sqlData = new SqlDataAdapter("exec GetAllFromHoteles",conexion);
            DataSet ds = new DataSet();
            sqlData.Fill(ds);
            return ds;
        }

        [WebMethod]
        public DataSet GetAllFromDisponibles()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source = DESKTOP-IMJK6TH; Initial Catalog = Prueba_AXEDE; Integrated Security = true";
            SqlDataAdapter sqlData = new SqlDataAdapter("exec GetAllFromDisponibilidadByCriterios", conexion);
            DataSet ds = new DataSet();
            sqlData.Fill(ds);
            return ds;
        }

    }
}
