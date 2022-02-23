using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using BusinesLogicLayer;
using ENTITYLAYER;

namespace personelasp
{
    public partial class musterisil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["MUSTERIID"]);
            Entitymusteri ent = new Entitymusteri();
            ent.Musteriid = x;
            BLLmusteri.BLLmusterisil(ent.Musteriid);
            Response.Redirect("MusteriListesi.aspx");
        }
    }
}