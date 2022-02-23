using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
   public class EntitySatıs
    {
        private int satısid;
        private int urun;
        private int personel;
        private decimal fiyat;
        private int musteri;
        private string musteriad;
        private string musterisoyad;
        private string personelad;
        private string personelsoyad;
        private string urunad;

        
       
        public int Urun { get => urun; set => urun = value; }
        public decimal Fiyat { get => fiyat; set => fiyat = value; }
        public int Personel { get => personel; set => personel = value; }
        public int Musteri { get => musteri; set => musteri = value; }
        public string Personelsoyad { get => personelsoyad; set => personelsoyad = value; }
        public string Musterisoyad { get => musterisoyad; set => musterisoyad = value; }
       
        public string Musteriad { get => musteriad; set => musteriad = value; }
        public string Personelad { get => personelad; set => personelad = value; }
        public string Urunad { get => urunad; set => urunad = value; }
        public int Satısid { get => satısid; set => satısid = value; }
    }
}
