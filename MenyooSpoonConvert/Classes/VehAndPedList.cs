using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenyooSpoonConvert.Classes
{
    public class VehAndPedList
    {
        public List<NameHash> Veh_Hash { get; set; }
        public List<NameHash> Ped_Hash { get; set; }

        public VehAndPedList()
        {
            Veh_Hash = new List<NameHash>();
            Ped_Hash = new List<NameHash>();
        }
    }
}
