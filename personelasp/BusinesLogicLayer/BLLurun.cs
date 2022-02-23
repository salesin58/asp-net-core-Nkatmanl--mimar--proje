using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
using DataAccessLayer;
namespace BusinesLogicLayer
{
    public class BLLurun
    {
        public static List<EntityUrun> bllurunlistesi()
        {
            return DALurun.urunlistesi();
        }
    }
}
