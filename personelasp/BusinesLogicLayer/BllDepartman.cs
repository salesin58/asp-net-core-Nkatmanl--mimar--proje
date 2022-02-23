using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
using DataAccessLayer;
namespace BusinesLogicLayer
{
    public class BllDepartman
    {
        public static List<Entitydepartman> BLLDepartmanListele()
        {
            return DalDepartman.departmanlistesi();
        }
        public static int BLLdepartmanekle(Entitydepartman p)
        {
            if (p.Departmanad!=null && p.Departmanad!="")
            {
                return DalDepartman.departmanekle(p);
            }
            return -1;
        }
    }
}
