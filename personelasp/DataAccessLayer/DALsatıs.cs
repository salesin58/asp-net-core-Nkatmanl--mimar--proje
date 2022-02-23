using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessLayer
{
    public class DALsatıs
    {
        public static List<EntitySatıs> satıslistesi()
        {
            List<EntitySatıs> degerler = new List<EntitySatıs>();
            SqlCommand komut = new SqlCommand("SELECT * FROM TBLSATIS1", sqlbaglanti.bgl);
            //komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntitySatıs ent = new EntitySatıs();
                ent.Satısid = int.Parse(dr["SATISID"].ToString());
                //ent.Urunad = dr["URUNAD"].ToString();
                //ent.Personelad = dr["PERSONEL"].ToString();
                //ent.Musteriad = dr["MUSTERIM"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

    }
}
