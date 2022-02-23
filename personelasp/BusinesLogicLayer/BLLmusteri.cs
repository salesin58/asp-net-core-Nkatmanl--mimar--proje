using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using ENTITYLAYER;


namespace BusinesLogicLayer
{
    public class BLLmusteri
    {
        public static List<Entitymusteri> BLLmusterilistesi()
        {
            return DALmusteri.musterilislesi();
        }
        public static int BLLmusterıekle(Entitymusteri p)
        {
            if (p.Musteriad!="" && p.Musterisoyad!="" && p.Musteriad.Length<=7 )
            {
                return DALmusteri.Musteriekle(p);

            }
            return -1;
        }
        public static bool BLLmusterisil(int p)
        {
            if (p!=null)
            {
                return DALmusteri.musterisil(p);
            }
            return false;
        }
        public static List<Entitymusteri> bllmusterigetir(int p)
        {
            return DALmusteri.musterigetir(p);
        }
        public static bool bllmusteriguncelle(Entitymusteri p)
        {
            if (p.Musteriad!="" && p.Musterisoyad!="")
            {
                return DALmusteri.musteriguncelle(p);
            }
            return false;
        }
    }
}
