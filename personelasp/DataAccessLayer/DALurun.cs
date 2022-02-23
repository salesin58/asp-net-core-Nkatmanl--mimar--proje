using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ENTITYLAYER;

namespace DataAccessLayer
{
    public class DALurun
    {
        public static List<EntityUrun> urunlistesi()
        {
            List<EntityUrun> degerler = new List<EntityUrun>();
            SqlCommand komut = new SqlCommand("SELECT * FROM TBLURUN", sqlbaglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityUrun ent = new EntityUrun();
                ent.Urunid = int.Parse(dr["URUNID"].ToString());
                ent.Urunad = dr["URUNAD"].ToString();
                ent.Urunadet = int.Parse(dr["URUNADET"].ToString());
                ent.Urunfiyat =decimal.Parse( dr["URUNFIYAT"].ToString());
                
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
    }
}
