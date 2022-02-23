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
    public class DALpersonel
    {
        public static  List<Entitypersonel> Personellistesi()
        {
            List<Entitypersonel> degerler = new List<Entitypersonel>();
            SqlCommand komut = new SqlCommand("select * from TBLPERSONEL",sqlbaglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Entitypersonel ent = new Entitypersonel();
                ent.Personelid = int.Parse(dr["PERSONELID"].ToString());
                ent.Personelad = dr["PERSONELAD"].ToString();
                ent.Personelsoyad = dr["PERSONELSOYAD"].ToString();
                ent.Personelmaas = decimal.Parse(dr["PERSONELMAAS"].ToString());
                ent.Personelfotograf = dr["PERSONELFOTOGRAF"].ToString();
                ent.Personeldepartman = byte.Parse(dr["PERSONELDEPARTMAN"].ToString());
                degerler.Add(ent);



            }
            dr.Close();
            return degerler;


        }
    }
}
