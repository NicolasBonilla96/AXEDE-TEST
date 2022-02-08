using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Hoteles_webService.Entidades;
using System.Data;

namespace Hoteles_webService.ClasesProcedimientos
{
    public class hotelesProcedimientos
    {
        public static Hoteles Hoteles(DataSet ds)
        {
            Hoteles Hoteles = new Hoteles();
            if(ds.Tables[0].Rows.Count != 0)
            {
                int indiceFila = 0;
                foreach(DataRow fila in ds.Tables[0].Rows)
                {
                    foreach(DataColumn columna in ds.Tables[0].Columns)
                    {
                        switch (columna.ColumnName)
                        {
                            case "id_hotel":
                                if (!String.IsNullOrEmpty(ds.Tables[0].Rows[indiceFila][columna.ColumnName].ToString()))
                                {
                                    Hoteles.id_hotel = Convert.ToInt32(ds.Tables[0].Rows[indiceFila][columna.ColumnName].ToString());
                                }
                                break;
                            case "ciudad":
                                Hoteles.ciudad = ds.Tables[0].Rows[indiceFila][columna.ColumnName].ToString();
                                break;
                            case "id_estandar":
                                if (!String.IsNullOrEmpty(ds.Tables[0].Rows[indiceFila][columna.ColumnName].ToString()))
                                {
                                    Hoteles.id_estandar = Convert.ToInt32(ds.Tables[0].Rows[indiceFila][columna.ColumnName].ToString());
                                }
                                break;
                            case "hab_estandar":
                                if (!String.IsNullOrEmpty(ds.Tables[0].Rows[indiceFila][columna.ColumnName].ToString()))
                                {
                                    Hoteles.hab_estandar = Convert.ToInt32(ds.Tables[0].Rows[indiceFila][columna.ColumnName].ToString());
                                }
                                break;
                            case "id_vip":
                                if (!String.IsNullOrEmpty(ds.Tables[0].Rows[indiceFila][columna.ColumnName].ToString()))
                                {
                                    Hoteles.id_vip = Convert.ToInt32(ds.Tables[0].Rows[indiceFila][columna.ColumnName].ToString());
                                }
                                break;
                            case "hab_vip":
                                if (!String.IsNullOrEmpty(ds.Tables[0].Rows[indiceFila][columna.ColumnName].ToString()))
                                {
                                    Hoteles.hab_vip = Convert.ToInt32(ds.Tables[0].Rows[indiceFila][columna.ColumnName].ToString());
                                }
                                break;
                            case "id_premium":
                                if (!String.IsNullOrEmpty(ds.Tables[0].Rows[indiceFila][columna.ColumnName].ToString()))
                                {
                                    Hoteles.id_premium = Convert.ToInt32(ds.Tables[0].Rows[indiceFila][columna.ColumnName].ToString());
                                }
                                break;
                            case "hab_premium":
                                if (!String.IsNullOrEmpty(ds.Tables[0].Rows[indiceFila][columna.ColumnName].ToString()))
                                {
                                    Hoteles.hab_premium = Convert.ToInt32(ds.Tables[0].Rows[indiceFila][columna.ColumnName].ToString());
                                }
                                break;
                            case "cupo":
                                if (!String.IsNullOrEmpty(ds.Tables[0].Rows[indiceFila][columna.ColumnName].ToString()))
                                {
                                    Hoteles.cupo = Convert.ToInt32(ds.Tables[0].Rows[indiceFila][columna.ColumnName].ToString());
                                }
                                break;
                        }
                    }
                    indiceFila++;
                }
            }
            return Hoteles;
        }

        public static List<Hoteles> lista_hoteles(DataSet ds)
        {
            List<Hoteles> lst_hoteles = new List<Hoteles>();
            if(ds.Tables[0].Rows.Count != 0)
            {
                int indiceFila = 0;
                foreach(DataRow fila in ds.Tables[0].Rows)
                {
                    Hoteles Hoteles = new Hoteles();
                    foreach(DataColumn columna in ds.Tables[0].Columns)
                    {
                        switch (columna.ColumnName)
                        {
                            case "id_hotel":
                                if (!String.IsNullOrEmpty(ds.Tables[0].Rows[indiceFila][columna.ColumnName].ToString()))
                                {
                                    Hoteles.id_hotel = Convert.ToInt32(ds.Tables[0].Rows[indiceFila][columna.ColumnName].ToString());
                                }
                                break;
                            case "ciudad":
                                Hoteles.ciudad = ds.Tables[0].Rows[indiceFila][columna.ColumnName].ToString();
                                break;
                            case "id_estandar":
                                if (!String.IsNullOrEmpty(ds.Tables[0].Rows[indiceFila][columna.ColumnName].ToString()))
                                {
                                    Hoteles.id_estandar = Convert.ToInt32(ds.Tables[0].Rows[indiceFila][columna.ColumnName].ToString());
                                }
                                break;
                            case "hab_estandar":
                                if (!String.IsNullOrEmpty(ds.Tables[0].Rows[indiceFila][columna.ColumnName].ToString()))
                                {
                                    Hoteles.hab_estandar = Convert.ToInt32(ds.Tables[0].Rows[indiceFila][columna.ColumnName].ToString());
                                }
                                break;
                            case "id_vip":
                                if (!String.IsNullOrEmpty(ds.Tables[0].Rows[indiceFila][columna.ColumnName].ToString()))
                                {
                                    Hoteles.id_vip = Convert.ToInt32(ds.Tables[0].Rows[indiceFila][columna.ColumnName].ToString());
                                }
                                break;
                            case "hab_vip":
                                if (!String.IsNullOrEmpty(ds.Tables[0].Rows[indiceFila][columna.ColumnName].ToString()))
                                {
                                    Hoteles.hab_vip = Convert.ToInt32(ds.Tables[0].Rows[indiceFila][columna.ColumnName].ToString());
                                }
                                break;
                            case "id_premium":
                                if (!String.IsNullOrEmpty(ds.Tables[0].Rows[indiceFila][columna.ColumnName].ToString()))
                                {
                                    Hoteles.id_premium = Convert.ToInt32(ds.Tables[0].Rows[indiceFila][columna.ColumnName].ToString());
                                }
                                break;
                            case "hab_premium":
                                if (!String.IsNullOrEmpty(ds.Tables[0].Rows[indiceFila][columna.ColumnName].ToString()))
                                {
                                    Hoteles.hab_premium = Convert.ToInt32(ds.Tables[0].Rows[indiceFila][columna.ColumnName].ToString());
                                }
                                break;
                            case "cupo":
                                if (!String.IsNullOrEmpty(ds.Tables[0].Rows[indiceFila][columna.ColumnName].ToString()))
                                {
                                    Hoteles.cupo = Convert.ToInt32(ds.Tables[0].Rows[indiceFila][columna.ColumnName].ToString());
                                }
                                break;
                        }
                    }
                    indiceFila++;
                    lst_hoteles.Add(Hoteles);
                }
            }
            return lst_hoteles;
        }

        //public static List<Hoteles> GetAllFromHoteles()
        //{
        //    SqlConnection conexion = Entidades.dataBase.ConexionBD();
        //    conexion.Open();
        //    SqlDataAdapter sda = new SqlDataAdapter("GetAllFromHoteles", conexion);
        //    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
        //    DataSet ds = new DataSet();
        //    sda.Fill(ds);
        //    sda.Dispose();
        //    conexion.Close();
        //    return lista_hoteles(ds);
        //} 
    }
}