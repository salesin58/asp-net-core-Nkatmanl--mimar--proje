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
    public partial class musteriguncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["MUSTERIID"]);
            TextBox3.Text = x.ToString();
            Entitymusteri ent = new Entitymusteri();
            if (Page.IsPostBack==false)
            {
                List<Entitymusteri> muslist = BLLmusteri.bllmusterigetir(x);
                TextBox1.Text = muslist[0].Musteriad.ToString();
                TextBox2.Text = muslist[0].Musterisoyad.ToString();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Entitymusteri ent = new Entitymusteri();
            ent.Musteriad = TextBox1.Text;
            ent.Musterisoyad = TextBox2.Text;
            ent.Musteriid =  int.Parse( TextBox3.Text);
            BLLmusteri.bllmusteriguncelle(ent);
            Response.Redirect("MusteriListesi.aspx");
        }
    }
}