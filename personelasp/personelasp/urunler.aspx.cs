using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using ENTITYLAYER;
using BusinesLogicLayer;

namespace personelasp
{
    public partial class urunler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityUrun> urunlist = BLLurun.bllurunlistesi();
            Repeater1.DataSource = urunlist;
            Repeater1.DataBind();
        }
    }
}