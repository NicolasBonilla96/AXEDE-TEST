using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aplicación_Hoteles
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MetodosWeb_Hoteles.MetodosWeb_HotelesSoapClient WS = new MetodosWeb_Hoteles.MetodosWeb_HotelesSoapClient();
            DataSet ds = WS.GetAllFromHoteles();
            gvHotel.DataSource = WS;
            gvHotel.DataBind();
            gvHotel.Visible = true;
        }

        protected void btnBuscar_click(object sender, EventArgs e)
        {
            MetodosWeb_Hoteles.MetodosWeb_HotelesSoapClient WS = new MetodosWeb_Hoteles.MetodosWeb_HotelesSoapClient();
            DataSet ds = WS.GetAllFromDisponibilidadByCriterios(txtFechaInicio, txtFechaFin, ddlHotel, ddlTipoHab, txtCupo);
            gvHotel.DataSource = WS;
            gvHotel.DataBind();
            gvHotel.Visible = true;
        }
    }
}