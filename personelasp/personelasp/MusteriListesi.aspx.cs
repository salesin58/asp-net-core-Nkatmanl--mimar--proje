using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ENTITYLAYER;
using DataAccessLayer;
using BusinesLogicLayer;
namespace personelasp
{
    public partial class MusteriListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Entitymusteri> muslis = BLLmusteri.BLLmusterilistesi();
            Repeater1.DataSource = muslis;
            Repeater1.DataBind();
        }
    }
}