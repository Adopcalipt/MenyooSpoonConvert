using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenyooSpoonConvert.Classes
{
    public class PropList
    {
        public string PropName { get; set; }
        public float PosX { get; set; }
        public float PosY { get; set; }
        public float PosZ { get; set; }
        public float RotX { get; set; }
        public float RotY { get; set; }
        public float RotZ { get; set; }
        public int ID { get; set; }
        public int AttachId { get; set; }

        public PropList(string propName, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, int iD, int attachId)
        {
            PropName = propName;
            PosX = posX;
            PosY = posY;
            PosZ = posZ;
            RotX = rotX;
            RotY = rotY;
            RotZ = rotZ;
            ID = iD;
            AttachId = attachId;
        }
        public PropList(string propName, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, int iD)
        {
            PropName = propName;
            PosX = posX;
            PosY = posY;
            PosZ = posZ;
            RotX = rotX;
            RotY = rotY;
            RotZ = rotZ;
            ID = iD;
            AttachId = -1;
        }
    }
}
