using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
using DataAccessLayer;
namespace BusinesLogicLayer
{
   public class BLLsatıs
    {
        public static List<EntitySatıs> bllsatislistesi()
        {
            return DALsatıs.satıslistesi();
        }
    }
}
