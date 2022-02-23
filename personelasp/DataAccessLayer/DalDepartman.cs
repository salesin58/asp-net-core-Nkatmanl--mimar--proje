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
    public class DalDepartman
    {
        public static List<Entitydepartman> departmanlistesi()
        {
            List<Entitydepartman> degerler = new List<Entitydepartman>();
            SqlCommand komut =new SqlCommand("SELECT * FROM TBLDEPARTMAN", sqlbaglanti.bgl);
            if (komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Entitydepartman ent = new Entitydepartman();
                ent.Departmanid = byte.Parse(dr["DEPARTMANID"].ToString());
                ent.Departmanad = dr["DEPARTMANAD"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static int departmanekle(Entitydepartman p)
        {
            SqlCommand komut1 = new SqlCommand("insert into TBLDEPARTMAN (DEPARTMANAD) Values(@p1)",sqlbaglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", p.Departmanad);
            return komut1.ExecuteNonQuery();

        }

    }
}
