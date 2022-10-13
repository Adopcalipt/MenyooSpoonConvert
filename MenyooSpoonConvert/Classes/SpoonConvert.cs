using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MenyooSpoonConvert.Form1;

namespace MenyooSpoonConvert.Classes
{
    public class SpoonConvert
    {
        public int Iobject { get; set; }//1 = Object, 2= Veh, 3= Ped.
        public string Sname { get; set; }
        public string Shash { get; set; }
        public PosRot Rplace { get; set; }
        public string Sattach { get; set; }
        public string SDesNum { get; set; }
        public PosRot RattachPlace { get; set; }
    }
}
