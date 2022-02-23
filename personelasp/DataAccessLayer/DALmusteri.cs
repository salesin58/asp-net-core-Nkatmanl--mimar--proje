using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ENTITYLAYER;

namespace DataAccessLayer
{
    public class DALmusteri
    {
        public static List<Entitymusteri> musterilislesi()
        {
            List<Entitymusteri> degerler = new List<Entitymusteri>();
            SqlCommand komut = new SqlCommand("SELECT * FROM TBLMUSTERI", sqlbaglanti.bgl);
            if (komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Entitymusteri ent = new Entitymusteri();
                ent.Musteriid = int.Parse(dr["MUSTERIID"].ToString());
                ent.Musteriad = dr["MUSTERIAD"].ToString();
                ent.Musterisoyad = dr["MUSTERISOYAD"].ToString();
                degerler.Add(ent);

            }
            dr.Close();
            return degerler;
        }
        public static int Musteriekle(Entitymusteri p)
        {
        SqlCommand komut2 = new SqlCommand("insert into TBLMUSTERI (MUSTERIAD,MUSTERISOYAD) values (@P1,@P2)", sqlbaglanti.bgl);
        if (komut2.Connection.State != ConnectionState.Open)
        {
            komut2.Connection.Open();
        }
        komut2.Parameters.AddWithValue("@P1", p.Musteriad);
        komut2.Parameters.AddWithValue("@P2", p.Musterisoyad);
        return komut2.ExecuteNonQuery();

        }
    
    public static bool musterisil(int p)
    {
            SqlCommand komut3 = new SqlCommand("delete from TBLMUSTERI WHERE MUSTERIID=@P1", sqlbaglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@P1", p);
            return komut3.ExecuteNonQuery() > 0;
        }
        public static List<Entitymusteri> musterigetir(int id)
        {
            List<Entitymusteri> degerler = new List<Entitymusteri>();
            SqlCommand komut = new SqlCommand("SELECT * FROM TBLMUSTERI where MUSTERIID=@p1 ", sqlbaglanti.bgl);
            komut.Parameters.AddWithValue("@p1", id);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Entitymusteri ent = new Entitymusteri();
               // ent.Musteriid = int.Parse(dr["MUSTERIID"].ToString());
                ent.Musteriad = dr["MUSTERIAD"].ToString();
                ent.Musterisoyad = dr["MUSTERISOYAD"].ToString();
                degerler.Add(ent);

            }
            dr.Close();
            return degerler;
        }
        public static bool musteriguncelle(Entitymusteri p)
        {
            SqlCommand komut = new SqlCommand("update TBLMUSTERI SET MUSTERIAD=@p1,MUSTERISOYAD=@p2 where MUSTERIID=@p3 ", sqlbaglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", p.Musteriad);
            komut.Parameters.AddWithValue("@p2", p.Musterisoyad);
            komut.Parameters.AddWithValue("@p3", p.Musteriid);
            return komut.ExecuteNonQuery() >0;
        }
    }
  
}
