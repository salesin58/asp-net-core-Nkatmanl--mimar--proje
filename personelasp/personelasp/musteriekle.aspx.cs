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
    public partial class musteriekle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Entitymusteri ent = new Entitymusteri();
            ent.Musteriad = TextBox1.Text;
            ent.Musterisoyad = TextBox2.Text;
            BLLmusteri.BLLmusterıekle(ent);
        }
    }
}