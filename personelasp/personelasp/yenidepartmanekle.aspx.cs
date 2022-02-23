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
    public partial class yenidepartmanekle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Entitydepartman ent = new Entitydepartman();
            ent.Departmanad = TextBox1.Text;
            BllDepartman.BLLdepartmanekle(ent);

        }
    }
}