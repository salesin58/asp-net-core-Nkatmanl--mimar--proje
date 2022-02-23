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
    public partial class personel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Entitypersonel> perlis = BLLpersonel.BLLpersonellistesi();
            Repeater1.DataSource = perlis;
            Repeater1.DataBind();
        }
    }
}