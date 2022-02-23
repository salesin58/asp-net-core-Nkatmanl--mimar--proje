using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
using DataAccessLayer;

namespace BusinesLogicLayer
{
    public class BLLpersonel
    {
        public static List<Entitypersonel> BLLpersonellistesi()
        {
            return DALpersonel.Personellistesi();
        }
    }
}
