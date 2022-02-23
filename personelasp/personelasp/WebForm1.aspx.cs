using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ENTITYLAYER;
using BusinesLogicLayer;
using DataAccessLayer;
namespace personelasp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Entitydepartman> deplist = BllDepartman.BLLDepartmanListele();
            Repeater1.DataSource = deplist;
            Repeater1.DataBind();
        }
    }
}