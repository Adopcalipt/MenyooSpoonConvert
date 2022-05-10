using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace MenyooSpoonConvert
{
    public partial class Form1 : Form
    {
        private int _lastFormSize;
        string sXMLPath = Directory.GetCurrentDirectory();
        string sPedVehList = "" + Directory.GetCurrentDirectory() + "/sPedVehList.Bml";
        string sMayFile = "";
        string sOutputFile = "";
        VehAndPedList MyVehPedList = new VehAndPedList();

        public class NameHash
        {
            public string Item_Name { get; set; }
            public string Item_Hash { get; set; }
        }
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
        public void SaveVehAndPedList(VehAndPedList config, string fileName)
        {
            XmlSerializer xml = new XmlSerializer(typeof(VehAndPedList));
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                xml.Serialize(sw, config);
            }
        }
        public VehAndPedList LoadVehAndPedList(string fileName)
        {
            XmlSerializer xml = new XmlSerializer(typeof(VehAndPedList));
            using (StreamReader sr = new StreamReader(fileName))
            {
                return (VehAndPedList)xml.Deserialize(sr);
            }
        }
        private void ReadVehAndPedList()
        {
            if (File.Exists(sPedVehList))
                MyVehPedList = LoadVehAndPedList(sPedVehList);
            else
            {
                MyVehPedList = BuildPVLists();
                SaveVehAndPedList(MyVehPedList, sPedVehList);
            }
        }
        public VehAndPedList BuildPVLists()
        {
            VehAndPedList NewVP = new VehAndPedList();

            List<string> Veh_Ped_Hash = new List<string>();
            List<string> Veh_Ped_Name = new List<string>();
            Veh_Ped_Name.Add("adder"); Veh_Ped_Hash.Add("0xb779a091");
            Veh_Ped_Name.Add("airbus"); Veh_Ped_Hash.Add("0x4c80eb0e");
            Veh_Ped_Name.Add("airtug"); Veh_Ped_Hash.Add("0x5d0aac8f");
            Veh_Ped_Name.Add("akula"); Veh_Ped_Hash.Add("0x46699f47");
            Veh_Ped_Name.Add("akuma"); Veh_Ped_Hash.Add("0x63abade7");
            Veh_Ped_Name.Add("alkonost"); Veh_Ped_Hash.Add("0xea313705");
            Veh_Ped_Name.Add("alpha"); Veh_Ped_Hash.Add("0x2db8d1aa");
            Veh_Ped_Name.Add("alphaz1"); Veh_Ped_Hash.Add("0xa52f6866");
            Veh_Ped_Name.Add("ambulance"); Veh_Ped_Hash.Add("0x45d56ada");
            Veh_Ped_Name.Add("annihilator"); Veh_Ped_Hash.Add("0x31f0b376");
            Veh_Ped_Name.Add("annihilator2"); Veh_Ped_Hash.Add("0x11962e49");
            Veh_Ped_Name.Add("apc"); Veh_Ped_Hash.Add("0x2189d250");
            Veh_Ped_Name.Add("ardent"); Veh_Ped_Hash.Add("0x97e5533");
            Veh_Ped_Name.Add("armytanker"); Veh_Ped_Hash.Add("0xb8081009");
            Veh_Ped_Name.Add("armytrailer"); Veh_Ped_Hash.Add("0xa7ff33f5");
            Veh_Ped_Name.Add("armytrailer2"); Veh_Ped_Hash.Add("0x9e6b14d6");
            Veh_Ped_Name.Add("asbo"); Veh_Ped_Hash.Add("0x42aca95f");
            Veh_Ped_Name.Add("asea"); Veh_Ped_Hash.Add("0x94204d89");
            Veh_Ped_Name.Add("asea2"); Veh_Ped_Hash.Add("0x9441d8d5");
            Veh_Ped_Name.Add("asterope"); Veh_Ped_Hash.Add("0x8e9254fb");
            Veh_Ped_Name.Add("astron"); Veh_Ped_Hash.Add("0x258c9364");
            Veh_Ped_Name.Add("autarch"); Veh_Ped_Hash.Add("0xed552c74");
            Veh_Ped_Name.Add("avarus"); Veh_Ped_Hash.Add("0x81e38f7f");
            Veh_Ped_Name.Add("avenger"); Veh_Ped_Hash.Add("0x81bd2ed0");
            Veh_Ped_Name.Add("avenger2"); Veh_Ped_Hash.Add("0x18606535");
            Veh_Ped_Name.Add("avisa"); Veh_Ped_Hash.Add("0x9a474b5e");
            Veh_Ped_Name.Add("bagger"); Veh_Ped_Hash.Add("0x806b9cc3");
            Veh_Ped_Name.Add("baletrailer"); Veh_Ped_Hash.Add("0xe82ae656");
            Veh_Ped_Name.Add("baller"); Veh_Ped_Hash.Add("0xcfca3668");
            Veh_Ped_Name.Add("baller2"); Veh_Ped_Hash.Add("0x8852855");
            Veh_Ped_Name.Add("baller3"); Veh_Ped_Hash.Add("0x6ff0f727");
            Veh_Ped_Name.Add("baller4"); Veh_Ped_Hash.Add("0x25cbe2e2");
            Veh_Ped_Name.Add("baller5"); Veh_Ped_Hash.Add("0x1c09cf5e");
            Veh_Ped_Name.Add("baller6"); Veh_Ped_Hash.Add("0x27b4e6b0");
            Veh_Ped_Name.Add("baller7"); Veh_Ped_Hash.Add("0x1573422d");
            Veh_Ped_Name.Add("banshee"); Veh_Ped_Hash.Add("0xc1e908d2");
            Veh_Ped_Name.Add("banshee2"); Veh_Ped_Hash.Add("0x25c5af13");
            Veh_Ped_Name.Add("barracks"); Veh_Ped_Hash.Add("0xceea3f4b");
            Veh_Ped_Name.Add("barracks2"); Veh_Ped_Hash.Add("0x4008eabb");
            Veh_Ped_Name.Add("barracks3"); Veh_Ped_Hash.Add("0x2592b5cf");
            Veh_Ped_Name.Add("barrage"); Veh_Ped_Hash.Add("0xf34dfb25");
            Veh_Ped_Name.Add("bati"); Veh_Ped_Hash.Add("0xf9300cc5");
            Veh_Ped_Name.Add("bati2"); Veh_Ped_Hash.Add("0xcadd5d2d");
            Veh_Ped_Name.Add("benson"); Veh_Ped_Hash.Add("0x7a61b330");
            Veh_Ped_Name.Add("besra"); Veh_Ped_Hash.Add("0x6cbd1d6d");
            Veh_Ped_Name.Add("bestiagts"); Veh_Ped_Hash.Add("0x4bfcf28b");
            Veh_Ped_Name.Add("bf400"); Veh_Ped_Hash.Add("0x5283265");
            Veh_Ped_Name.Add("bfinjection"); Veh_Ped_Hash.Add("0x432aa566");
            Veh_Ped_Name.Add("biff"); Veh_Ped_Hash.Add("0x32b91ae8");
            Veh_Ped_Name.Add("bifta"); Veh_Ped_Hash.Add("0xeb298297");
            Veh_Ped_Name.Add("bison"); Veh_Ped_Hash.Add("0xfefd644f");
            Veh_Ped_Name.Add("bison2"); Veh_Ped_Hash.Add("0x7b8297c5");
            Veh_Ped_Name.Add("bison3"); Veh_Ped_Hash.Add("0x67b3f020");
            Veh_Ped_Name.Add("bjxl"); Veh_Ped_Hash.Add("0x32b29a4b");
            Veh_Ped_Name.Add("blade"); Veh_Ped_Hash.Add("0xb820ed5e");
            Veh_Ped_Name.Add("blazer"); Veh_Ped_Hash.Add("0x8125bcf9");
            Veh_Ped_Name.Add("blazer2"); Veh_Ped_Hash.Add("0xfd231729");
            Veh_Ped_Name.Add("blazer3"); Veh_Ped_Hash.Add("0xb44f0582");
            Veh_Ped_Name.Add("blazer4"); Veh_Ped_Hash.Add("0xe5ba6858");
            Veh_Ped_Name.Add("blazer5"); Veh_Ped_Hash.Add("0xa1355f67");
            Veh_Ped_Name.Add("blimp"); Veh_Ped_Hash.Add("0xf7004c86");
            Veh_Ped_Name.Add("blimp2"); Veh_Ped_Hash.Add("0xdb6b4924");
            Veh_Ped_Name.Add("blimp3"); Veh_Ped_Hash.Add("0xeda4ed97");
            Veh_Ped_Name.Add("blista"); Veh_Ped_Hash.Add("0xeb70965f");
            Veh_Ped_Name.Add("blista2"); Veh_Ped_Hash.Add("0x3dee5eda");
            Veh_Ped_Name.Add("blista3"); Veh_Ped_Hash.Add("0xdcbc1c3b");
            Veh_Ped_Name.Add("bmx"); Veh_Ped_Hash.Add("0x43779c54");
            Veh_Ped_Name.Add("boattrailer"); Veh_Ped_Hash.Add("0x1f3d44b5");
            Veh_Ped_Name.Add("bobcatxl"); Veh_Ped_Hash.Add("0x3fc5d440");
            Veh_Ped_Name.Add("bodhi2"); Veh_Ped_Hash.Add("0xaa699bb6");
            Veh_Ped_Name.Add("bombushka"); Veh_Ped_Hash.Add("0xfe0a508c");
            Veh_Ped_Name.Add("boxville"); Veh_Ped_Hash.Add("0x898eccea");
            Veh_Ped_Name.Add("boxville2"); Veh_Ped_Hash.Add("0xf21b33be");
            Veh_Ped_Name.Add("boxville3"); Veh_Ped_Hash.Add("0x7405e08");
            Veh_Ped_Name.Add("boxville4"); Veh_Ped_Hash.Add("0x1a79847a");
            Veh_Ped_Name.Add("boxville5"); Veh_Ped_Hash.Add("0x28ad20e1");
            Veh_Ped_Name.Add("brawler"); Veh_Ped_Hash.Add("0xa7ce1bc5");
            Veh_Ped_Name.Add("brickade"); Veh_Ped_Hash.Add("0xedc6f847");
            Veh_Ped_Name.Add("brioso"); Veh_Ped_Hash.Add("0x5c55cb39");
            Veh_Ped_Name.Add("brioso2"); Veh_Ped_Hash.Add("0x55365079");
            Veh_Ped_Name.Add("bruiser"); Veh_Ped_Hash.Add("0x27d79225");
            Veh_Ped_Name.Add("bruiser2"); Veh_Ped_Hash.Add("0x9b065c9e");
            Veh_Ped_Name.Add("bruiser3"); Veh_Ped_Hash.Add("0x8644331a");
            Veh_Ped_Name.Add("brutus"); Veh_Ped_Hash.Add("0x7f81a829");
            Veh_Ped_Name.Add("brutus2"); Veh_Ped_Hash.Add("0x8f49ae28");
            Veh_Ped_Name.Add("brutus3"); Veh_Ped_Hash.Add("0x798682a2");
            Veh_Ped_Name.Add("btype"); Veh_Ped_Hash.Add("0x6ff6914");
            Veh_Ped_Name.Add("btype2"); Veh_Ped_Hash.Add("0xce6b35a4");
            Veh_Ped_Name.Add("btype3"); Veh_Ped_Hash.Add("0xdc19d101");
            Veh_Ped_Name.Add("buccaneer"); Veh_Ped_Hash.Add("0xd756460c");
            Veh_Ped_Name.Add("buccaneer2"); Veh_Ped_Hash.Add("0xc397f748");
            Veh_Ped_Name.Add("buffalo"); Veh_Ped_Hash.Add("0xedd516c6");
            Veh_Ped_Name.Add("buffalo2"); Veh_Ped_Hash.Add("0x2bec3cbe");
            Veh_Ped_Name.Add("buffalo3"); Veh_Ped_Hash.Add("0xe2c013e");
            Veh_Ped_Name.Add("buffalo4"); Veh_Ped_Hash.Add("0xdb0c9b04");
            Veh_Ped_Name.Add("bulldozer"); Veh_Ped_Hash.Add("0x7074f39d");
            Veh_Ped_Name.Add("bullet"); Veh_Ped_Hash.Add("0x9ae6dda1");
            Veh_Ped_Name.Add("burrito"); Veh_Ped_Hash.Add("0xafbb2ca4");
            Veh_Ped_Name.Add("burrito2"); Veh_Ped_Hash.Add("0xc9e8ff76");
            Veh_Ped_Name.Add("burrito3"); Veh_Ped_Hash.Add("0x98171bd3");
            Veh_Ped_Name.Add("burrito4"); Veh_Ped_Hash.Add("0x353b561d");
            Veh_Ped_Name.Add("burrito5"); Veh_Ped_Hash.Add("0x437cf2a0");
            Veh_Ped_Name.Add("bus"); Veh_Ped_Hash.Add("0xd577c962");
            Veh_Ped_Name.Add("buzzard"); Veh_Ped_Hash.Add("0x2f03547b");
            Veh_Ped_Name.Add("buzzard2"); Veh_Ped_Hash.Add("0x2c75f0dd");
            Veh_Ped_Name.Add("cablecar"); Veh_Ped_Hash.Add("0xc6c3242d");
            Veh_Ped_Name.Add("caddy"); Veh_Ped_Hash.Add("0x44623884");
            Veh_Ped_Name.Add("caddy2"); Veh_Ped_Hash.Add("0xdff0594c");
            Veh_Ped_Name.Add("caddy3"); Veh_Ped_Hash.Add("0xd227bdbb");
            Veh_Ped_Name.Add("calico"); Veh_Ped_Hash.Add("0xb8d657ad");
            Veh_Ped_Name.Add("camper"); Veh_Ped_Hash.Add("0x6fd95f68");
            Veh_Ped_Name.Add("caracara"); Veh_Ped_Hash.Add("0x4abebf23");
            Veh_Ped_Name.Add("caracara2"); Veh_Ped_Hash.Add("0xaf966f3c");
            Veh_Ped_Name.Add("carbonizzare"); Veh_Ped_Hash.Add("0x7b8ab45f");
            Veh_Ped_Name.Add("carbonrs"); Veh_Ped_Hash.Add("0xabb0c0");
            Veh_Ped_Name.Add("cargobob"); Veh_Ped_Hash.Add("0xfcfcb68b");
            Veh_Ped_Name.Add("cargobob2"); Veh_Ped_Hash.Add("0x60a7ea10");
            Veh_Ped_Name.Add("cargobob3"); Veh_Ped_Hash.Add("0x53174eef");
            Veh_Ped_Name.Add("cargobob4"); Veh_Ped_Hash.Add("0x78bc1a3c");
            Veh_Ped_Name.Add("cargoplane"); Veh_Ped_Hash.Add("0x15f27762");
            Veh_Ped_Name.Add("casco"); Veh_Ped_Hash.Add("0x3822bdfe");
            Veh_Ped_Name.Add("cavalcade"); Veh_Ped_Hash.Add("0x779f23aa");
            Veh_Ped_Name.Add("cavalcade2"); Veh_Ped_Hash.Add("0xd0eb2be5");
            Veh_Ped_Name.Add("cerberus"); Veh_Ped_Hash.Add("0xd039510b");
            Veh_Ped_Name.Add("cerberus2"); Veh_Ped_Hash.Add("0x287fa449");
            Veh_Ped_Name.Add("cerberus3"); Veh_Ped_Hash.Add("0x71d3b6f0");
            Veh_Ped_Name.Add("champion"); Veh_Ped_Hash.Add("0xc972a155");
            Veh_Ped_Name.Add("cheburek"); Veh_Ped_Hash.Add("0xc514aae0");
            Veh_Ped_Name.Add("cheetah"); Veh_Ped_Hash.Add("0xb1d95da0");
            Veh_Ped_Name.Add("cheetah2"); Veh_Ped_Hash.Add("0xd4e5f4d");
            Veh_Ped_Name.Add("chernobog"); Veh_Ped_Hash.Add("0xd6bc7523");
            Veh_Ped_Name.Add("chimera"); Veh_Ped_Hash.Add("0x675ed7");
            Veh_Ped_Name.Add("chino"); Veh_Ped_Hash.Add("0x14d69010");
            Veh_Ped_Name.Add("chino2"); Veh_Ped_Hash.Add("0xaed64a63");
            Veh_Ped_Name.Add("cinquemila"); Veh_Ped_Hash.Add("0xa4f52c13");
            Veh_Ped_Name.Add("cliffhanger"); Veh_Ped_Hash.Add("0x17420102");
            Veh_Ped_Name.Add("clique"); Veh_Ped_Hash.Add("0xa29f78b0");
            Veh_Ped_Name.Add("club"); Veh_Ped_Hash.Add("0x82e47e85");
            Veh_Ped_Name.Add("coach"); Veh_Ped_Hash.Add("0x84718d34");
            Veh_Ped_Name.Add("cog55"); Veh_Ped_Hash.Add("0x360a438e");
            Veh_Ped_Name.Add("cog552"); Veh_Ped_Hash.Add("0x29fcd3e4");
            Veh_Ped_Name.Add("cogcabrio"); Veh_Ped_Hash.Add("0x13b57d8a");
            Veh_Ped_Name.Add("cognoscenti"); Veh_Ped_Hash.Add("0x86fe0b60");
            Veh_Ped_Name.Add("cognoscenti2"); Veh_Ped_Hash.Add("0xdbf2d57a");
            Veh_Ped_Name.Add("comet2"); Veh_Ped_Hash.Add("0xc1ae4d16");
            Veh_Ped_Name.Add("comet3"); Veh_Ped_Hash.Add("0x877358ad");
            Veh_Ped_Name.Add("comet4"); Veh_Ped_Hash.Add("0x5d1903f9");
            Veh_Ped_Name.Add("comet5"); Veh_Ped_Hash.Add("0x276d98a3");
            Veh_Ped_Name.Add("comet6"); Veh_Ped_Hash.Add("0x991efc04");
            Veh_Ped_Name.Add("comet7"); Veh_Ped_Hash.Add("0x440851d8");
            Veh_Ped_Name.Add("contender"); Veh_Ped_Hash.Add("0x28b67aca");
            Veh_Ped_Name.Add("coquette"); Veh_Ped_Hash.Add("0x67bc037");
            Veh_Ped_Name.Add("coquette2"); Veh_Ped_Hash.Add("0x3c4e2113");
            Veh_Ped_Name.Add("coquette3"); Veh_Ped_Hash.Add("0x2ec385fe");
            Veh_Ped_Name.Add("coquette4"); Veh_Ped_Hash.Add("0x98f65a5e");
            Veh_Ped_Name.Add("cruiser"); Veh_Ped_Hash.Add("0x1aba13b5");
            Veh_Ped_Name.Add("crusader"); Veh_Ped_Hash.Add("0x132d5a1a");
            Veh_Ped_Name.Add("cuban800"); Veh_Ped_Hash.Add("0xd9927fe3");
            Veh_Ped_Name.Add("cutter"); Veh_Ped_Hash.Add("0xc3fba120");
            Veh_Ped_Name.Add("cyclone"); Veh_Ped_Hash.Add("0x52ff9437");
            Veh_Ped_Name.Add("cypher"); Veh_Ped_Hash.Add("0x68a5d1ef");
            Veh_Ped_Name.Add("daemon"); Veh_Ped_Hash.Add("0x77934cee");
            Veh_Ped_Name.Add("daemon2"); Veh_Ped_Hash.Add("0xac4e93c9");
            Veh_Ped_Name.Add("deathbike"); Veh_Ped_Hash.Add("0xfe5f0722");
            Veh_Ped_Name.Add("deathbike2"); Veh_Ped_Hash.Add("0x93f09558");
            Veh_Ped_Name.Add("deathbike3"); Veh_Ped_Hash.Add("0xae12c99c");
            Veh_Ped_Name.Add("defiler"); Veh_Ped_Hash.Add("0x30ff0190");
            Veh_Ped_Name.Add("deity"); Veh_Ped_Hash.Add("0x5b531351");
            Veh_Ped_Name.Add("deluxo"); Veh_Ped_Hash.Add("0x586765fb");
            Veh_Ped_Name.Add("deveste"); Veh_Ped_Hash.Add("0x5ee005da");
            Veh_Ped_Name.Add("deviant"); Veh_Ped_Hash.Add("0x4c3fff49");
            Veh_Ped_Name.Add("diablous"); Veh_Ped_Hash.Add("0xf1b44f44");
            Veh_Ped_Name.Add("diablous2"); Veh_Ped_Hash.Add("0x6abdf65e");
            Veh_Ped_Name.Add("dilettante"); Veh_Ped_Hash.Add("0xbc993509");
            Veh_Ped_Name.Add("dilettante2"); Veh_Ped_Hash.Add("0x64430650");
            Veh_Ped_Name.Add("dinghy"); Veh_Ped_Hash.Add("0x3d961290");
            Veh_Ped_Name.Add("dinghy2"); Veh_Ped_Hash.Add("0x107f392c");
            Veh_Ped_Name.Add("dinghy3"); Veh_Ped_Hash.Add("0x1e5e54ea");
            Veh_Ped_Name.Add("dinghy4"); Veh_Ped_Hash.Add("0x33b47f96");
            Veh_Ped_Name.Add("dinghy5"); Veh_Ped_Hash.Add("0xc58da34a");
            Veh_Ped_Name.Add("dloader"); Veh_Ped_Hash.Add("0x698521e3");
            Veh_Ped_Name.Add("docktrailer"); Veh_Ped_Hash.Add("0x806efbee");
            Veh_Ped_Name.Add("docktug"); Veh_Ped_Hash.Add("0xcb44b1ca");
            Veh_Ped_Name.Add("dodo"); Veh_Ped_Hash.Add("0xca495705");
            Veh_Ped_Name.Add("dominator"); Veh_Ped_Hash.Add("0x4ce68ac");
            Veh_Ped_Name.Add("dominator2"); Veh_Ped_Hash.Add("0xc96b73d9");
            Veh_Ped_Name.Add("dominator3"); Veh_Ped_Hash.Add("0xc52c6b93");
            Veh_Ped_Name.Add("dominator4"); Veh_Ped_Hash.Add("0xd6fb0f30");
            Veh_Ped_Name.Add("dominator5"); Veh_Ped_Hash.Add("0xae0a3d4f");
            Veh_Ped_Name.Add("dominator6"); Veh_Ped_Hash.Add("0xb2e046fb");
            Veh_Ped_Name.Add("dominator7"); Veh_Ped_Hash.Add("0x196f9418");
            Veh_Ped_Name.Add("dominator8"); Veh_Ped_Hash.Add("0x2be8b90a");
            Veh_Ped_Name.Add("double"); Veh_Ped_Hash.Add("0x9c669788");
            Veh_Ped_Name.Add("drafter"); Veh_Ped_Hash.Add("0x28eab80f");
            Veh_Ped_Name.Add("dubsta"); Veh_Ped_Hash.Add("0x462fe277");
            Veh_Ped_Name.Add("dubsta2"); Veh_Ped_Hash.Add("0xe882e5f6");
            Veh_Ped_Name.Add("dubsta3"); Veh_Ped_Hash.Add("0xb6410173");
            Veh_Ped_Name.Add("dukes"); Veh_Ped_Hash.Add("0x2b26f456");
            Veh_Ped_Name.Add("dukes2"); Veh_Ped_Hash.Add("0xec8f7094");
            Veh_Ped_Name.Add("dukes3"); Veh_Ped_Hash.Add("0x7f3415e3");
            Veh_Ped_Name.Add("dump"); Veh_Ped_Hash.Add("0x810369e2");
            Veh_Ped_Name.Add("dune"); Veh_Ped_Hash.Add("0x9cf21e0f");
            Veh_Ped_Name.Add("dune2"); Veh_Ped_Hash.Add("0x1fd824af");
            Veh_Ped_Name.Add("dune3"); Veh_Ped_Hash.Add("0x711d4738");
            Veh_Ped_Name.Add("dune4"); Veh_Ped_Hash.Add("0xceb28249");
            Veh_Ped_Name.Add("dune5"); Veh_Ped_Hash.Add("0xed62bfa9");
            Veh_Ped_Name.Add("duster"); Veh_Ped_Hash.Add("0x39d6779e");
            Veh_Ped_Name.Add("dynasty"); Veh_Ped_Hash.Add("0x127e90d5");
            Veh_Ped_Name.Add("elegy"); Veh_Ped_Hash.Add("0xbba2261");
            Veh_Ped_Name.Add("elegy2"); Veh_Ped_Hash.Add("0xde3d9d22");
            Veh_Ped_Name.Add("ellie"); Veh_Ped_Hash.Add("0xb472d2b5");
            Veh_Ped_Name.Add("emerus"); Veh_Ped_Hash.Add("0x4ee74355");
            Veh_Ped_Name.Add("emperor"); Veh_Ped_Hash.Add("0xd7278283");
            Veh_Ped_Name.Add("emperor2"); Veh_Ped_Hash.Add("0x8fc3aadc");
            Veh_Ped_Name.Add("emperor3"); Veh_Ped_Hash.Add("0xb5fcf74e");
            Veh_Ped_Name.Add("enduro"); Veh_Ped_Hash.Add("0x6882fa73");
            Veh_Ped_Name.Add("entity2"); Veh_Ped_Hash.Add("0x8198aedc");
            Veh_Ped_Name.Add("entityxf"); Veh_Ped_Hash.Add("0xb2fe5cf9");
            Veh_Ped_Name.Add("esskey"); Veh_Ped_Hash.Add("0x794cb30c");
            Veh_Ped_Name.Add("euros"); Veh_Ped_Hash.Add("0x7980bdd5");
            Veh_Ped_Name.Add("everon"); Veh_Ped_Hash.Add("0x97553c28");
            Veh_Ped_Name.Add("exemplar"); Veh_Ped_Hash.Add("0xffb15b5e");
            Veh_Ped_Name.Add("f620"); Veh_Ped_Hash.Add("0xdcbcbe48");
            Veh_Ped_Name.Add("faction"); Veh_Ped_Hash.Add("0x81a9cddf");
            Veh_Ped_Name.Add("faction2"); Veh_Ped_Hash.Add("0x95466bdb");
            Veh_Ped_Name.Add("faction3"); Veh_Ped_Hash.Add("0x866bce26");
            Veh_Ped_Name.Add("fagaloa"); Veh_Ped_Hash.Add("0x6068ad86");
            Veh_Ped_Name.Add("faggio"); Veh_Ped_Hash.Add("0x9229e4eb");
            Veh_Ped_Name.Add("faggio2"); Veh_Ped_Hash.Add("0x350d1ab");
            Veh_Ped_Name.Add("faggio3"); Veh_Ped_Hash.Add("0xb328b188");
            Veh_Ped_Name.Add("fbi"); Veh_Ped_Hash.Add("0x432ea949");
            Veh_Ped_Name.Add("fbi2"); Veh_Ped_Hash.Add("0x9dc66994");
            Veh_Ped_Name.Add("fcr"); Veh_Ped_Hash.Add("0x25676eaf");
            Veh_Ped_Name.Add("fcr2"); Veh_Ped_Hash.Add("0xd2d5e00e");
            Veh_Ped_Name.Add("felon"); Veh_Ped_Hash.Add("0xe8a8bda8");
            Veh_Ped_Name.Add("felon2"); Veh_Ped_Hash.Add("0xfaad85ee");
            Veh_Ped_Name.Add("feltzer2"); Veh_Ped_Hash.Add("0x8911b9f5");
            Veh_Ped_Name.Add("feltzer3"); Veh_Ped_Hash.Add("0xa29d6d10");
            Veh_Ped_Name.Add("firetruk"); Veh_Ped_Hash.Add("0x73920f8e");
            Veh_Ped_Name.Add("fixter"); Veh_Ped_Hash.Add("0xce23d3bf");
            Veh_Ped_Name.Add("flashgt"); Veh_Ped_Hash.Add("0xb4f32118");
            Veh_Ped_Name.Add("flatbed"); Veh_Ped_Hash.Add("0x50b0215a");
            Veh_Ped_Name.Add("fmj"); Veh_Ped_Hash.Add("0x5502626c");
            Veh_Ped_Name.Add("forklift"); Veh_Ped_Hash.Add("0x58e49664");
            Veh_Ped_Name.Add("formula"); Veh_Ped_Hash.Add("0x1446590a");
            Veh_Ped_Name.Add("formula2"); Veh_Ped_Hash.Add("0x8b213907");
            Veh_Ped_Name.Add("fq2"); Veh_Ped_Hash.Add("0xbc32a33b");
            Veh_Ped_Name.Add("freecrawler"); Veh_Ped_Hash.Add("0xfcc2f483");
            Veh_Ped_Name.Add("freight"); Veh_Ped_Hash.Add("0x3d6aaa9b");
            Veh_Ped_Name.Add("freightcar"); Veh_Ped_Hash.Add("0xafd22a6");
            Veh_Ped_Name.Add("freightcar2"); Veh_Ped_Hash.Add("0xbdec3d99");
            Veh_Ped_Name.Add("freightcont1"); Veh_Ped_Hash.Add("0x36dcff98");
            Veh_Ped_Name.Add("freightcont2"); Veh_Ped_Hash.Add("0xe512e79");
            Veh_Ped_Name.Add("freightgrain"); Veh_Ped_Hash.Add("0x264d9262");
            Veh_Ped_Name.Add("freighttrailer"); Veh_Ped_Hash.Add("0xd1abb666");
            Veh_Ped_Name.Add("frogger"); Veh_Ped_Hash.Add("0x2c634fbd");
            Veh_Ped_Name.Add("frogger2"); Veh_Ped_Hash.Add("0x742e9ac0");
            Veh_Ped_Name.Add("fugitive"); Veh_Ped_Hash.Add("0x71cb2ffb");
            Veh_Ped_Name.Add("furia"); Veh_Ped_Hash.Add("0x3944d5a0");
            Veh_Ped_Name.Add("furoregt"); Veh_Ped_Hash.Add("0xbf1691e0");
            Veh_Ped_Name.Add("fusilade"); Veh_Ped_Hash.Add("0x1dc0ba53");
            Veh_Ped_Name.Add("futo"); Veh_Ped_Hash.Add("0x7836ce2f");
            Veh_Ped_Name.Add("futo2"); Veh_Ped_Hash.Add("0xa6297cc8");
            Veh_Ped_Name.Add("gargoyle"); Veh_Ped_Hash.Add("0x2c2c2324");
            Veh_Ped_Name.Add("gauntlet"); Veh_Ped_Hash.Add("0x94b395c5");
            Veh_Ped_Name.Add("gauntlet2"); Veh_Ped_Hash.Add("0x14d22159");
            Veh_Ped_Name.Add("gauntlet3"); Veh_Ped_Hash.Add("0x2b0c4dcd");
            Veh_Ped_Name.Add("gauntlet4"); Veh_Ped_Hash.Add("0x734c5e50");
            Veh_Ped_Name.Add("gauntlet5"); Veh_Ped_Hash.Add("0x817afaad");
            Veh_Ped_Name.Add("gb200"); Veh_Ped_Hash.Add("0x71cbea98");
            Veh_Ped_Name.Add("gburrito"); Veh_Ped_Hash.Add("0x97fa4f36");
            Veh_Ped_Name.Add("gburrito2"); Veh_Ped_Hash.Add("0x11aa0e14");
            Veh_Ped_Name.Add("glendale"); Veh_Ped_Hash.Add("0x47a6bc1");
            Veh_Ped_Name.Add("glendale2"); Veh_Ped_Hash.Add("0xc98bbad6");
            Veh_Ped_Name.Add("gp1"); Veh_Ped_Hash.Add("0x4992196c");
            Veh_Ped_Name.Add("graintrailer"); Veh_Ped_Hash.Add("0x3cc7f596");
            Veh_Ped_Name.Add("granger"); Veh_Ped_Hash.Add("0x9628879c");
            Veh_Ped_Name.Add("granger2"); Veh_Ped_Hash.Add("0xf06c29c7");
            Veh_Ped_Name.Add("gresley"); Veh_Ped_Hash.Add("0xa3fc0f4d");
            Veh_Ped_Name.Add("growler"); Veh_Ped_Hash.Add("0x4dc079d7");
            Veh_Ped_Name.Add("gt500"); Veh_Ped_Hash.Add("0x8408f33a");
            Veh_Ped_Name.Add("guardian"); Veh_Ped_Hash.Add("0x825a9f4c");
            Veh_Ped_Name.Add("habanero"); Veh_Ped_Hash.Add("0x34b7390f");
            Veh_Ped_Name.Add("hakuchou"); Veh_Ped_Hash.Add("0x4b6c568a");
            Veh_Ped_Name.Add("hakuchou2"); Veh_Ped_Hash.Add("0xf0c2a91f");
            Veh_Ped_Name.Add("halftrack"); Veh_Ped_Hash.Add("0xfe141da6");
            Veh_Ped_Name.Add("handler"); Veh_Ped_Hash.Add("0x1a7fcefa");
            Veh_Ped_Name.Add("hauler"); Veh_Ped_Hash.Add("0x5a82f9ae");
            Veh_Ped_Name.Add("hauler2"); Veh_Ped_Hash.Add("0x171c92c4");
            Veh_Ped_Name.Add("havok"); Veh_Ped_Hash.Add("0x89ba59f5");
            Veh_Ped_Name.Add("hellion"); Veh_Ped_Hash.Add("0xea6a047f");
            Veh_Ped_Name.Add("hermes"); Veh_Ped_Hash.Add("0xe83c17");
            Veh_Ped_Name.Add("hexer"); Veh_Ped_Hash.Add("0x11f76c14");
            Veh_Ped_Name.Add("hotknife"); Veh_Ped_Hash.Add("0x239e390");
            Veh_Ped_Name.Add("hotring"); Veh_Ped_Hash.Add("0x42836be5");
            Veh_Ped_Name.Add("howard"); Veh_Ped_Hash.Add("0xc3f25753");
            Veh_Ped_Name.Add("hunter"); Veh_Ped_Hash.Add("0xfd707ede");
            Veh_Ped_Name.Add("huntley"); Veh_Ped_Hash.Add("0x1d06d681");
            Veh_Ped_Name.Add("hustler"); Veh_Ped_Hash.Add("0x23ca25f2");
            Veh_Ped_Name.Add("hydra"); Veh_Ped_Hash.Add("0x39d6e83f");
            Veh_Ped_Name.Add("ignus"); Veh_Ped_Hash.Add("0xa9ec907b");
            Veh_Ped_Name.Add("imorgon"); Veh_Ped_Hash.Add("0xbc7c0a00");
            Veh_Ped_Name.Add("impaler"); Veh_Ped_Hash.Add("0x83070b62");
            Veh_Ped_Name.Add("impaler2"); Veh_Ped_Hash.Add("0x3c26bd0c");
            Veh_Ped_Name.Add("impaler3"); Veh_Ped_Hash.Add("0x8d45df49");
            Veh_Ped_Name.Add("impaler4"); Veh_Ped_Hash.Add("0x9804f4c7");
            Veh_Ped_Name.Add("imperator"); Veh_Ped_Hash.Add("0x1a861243");
            Veh_Ped_Name.Add("imperator2"); Veh_Ped_Hash.Add("0x619c1b82");
            Veh_Ped_Name.Add("imperator3"); Veh_Ped_Hash.Add("0xd2f77e37");
            Veh_Ped_Name.Add("infernus"); Veh_Ped_Hash.Add("0x18f25ac7");
            Veh_Ped_Name.Add("infernus2"); Veh_Ped_Hash.Add("0xac33179c");
            Veh_Ped_Name.Add("ingot"); Veh_Ped_Hash.Add("0xb3206692");
            Veh_Ped_Name.Add("innovation"); Veh_Ped_Hash.Add("0xf683eaca");
            Veh_Ped_Name.Add("insurgent"); Veh_Ped_Hash.Add("0x9114eada");
            Veh_Ped_Name.Add("insurgent2"); Veh_Ped_Hash.Add("0x7b7e56f0");
            Veh_Ped_Name.Add("insurgent3"); Veh_Ped_Hash.Add("0x8d4b7a8a");
            Veh_Ped_Name.Add("intruder"); Veh_Ped_Hash.Add("0x34dd8aa1");
            Veh_Ped_Name.Add("issi2"); Veh_Ped_Hash.Add("0xb9cb3b69");
            Veh_Ped_Name.Add("issi3"); Veh_Ped_Hash.Add("0x378236e1");
            Veh_Ped_Name.Add("issi4"); Veh_Ped_Hash.Add("0x256e92ba");
            Veh_Ped_Name.Add("issi5"); Veh_Ped_Hash.Add("0x5ba0ff1e");
            Veh_Ped_Name.Add("issi6"); Veh_Ped_Hash.Add("0x49e25ba1");
            Veh_Ped_Name.Add("issi7"); Veh_Ped_Hash.Add("0x6e8da4f7");
            Veh_Ped_Name.Add("italigtb"); Veh_Ped_Hash.Add("0x85e8e76b");
            Veh_Ped_Name.Add("italigtb2"); Veh_Ped_Hash.Add("0xe33a477b");
            Veh_Ped_Name.Add("italigto"); Veh_Ped_Hash.Add("0xec3e3404");
            Veh_Ped_Name.Add("italirsx"); Veh_Ped_Hash.Add("0xbb78956a");
            Veh_Ped_Name.Add("iwagen"); Veh_Ped_Hash.Add("0x27816b7e");
            Veh_Ped_Name.Add("jackal"); Veh_Ped_Hash.Add("0xdac67112");
            Veh_Ped_Name.Add("jb700"); Veh_Ped_Hash.Add("0x3eab5555");
            Veh_Ped_Name.Add("jb7002"); Veh_Ped_Hash.Add("0x177da45c");
            Veh_Ped_Name.Add("jester"); Veh_Ped_Hash.Add("0xb2a716a3");
            Veh_Ped_Name.Add("jester2"); Veh_Ped_Hash.Add("0xbe0e6126");
            Veh_Ped_Name.Add("jester3"); Veh_Ped_Hash.Add("0xf330cb6a");
            Veh_Ped_Name.Add("jester4"); Veh_Ped_Hash.Add("0xa1b3a871");
            Veh_Ped_Name.Add("jet"); Veh_Ped_Hash.Add("0x3f119114");
            Veh_Ped_Name.Add("jetmax"); Veh_Ped_Hash.Add("0x33581161");
            Veh_Ped_Name.Add("journey"); Veh_Ped_Hash.Add("0xf8d48e7a");
            Veh_Ped_Name.Add("jubilee"); Veh_Ped_Hash.Add("0x1b8165d3");
            Veh_Ped_Name.Add("jugular"); Veh_Ped_Hash.Add("0xf38c4245");
            Veh_Ped_Name.Add("kalahari"); Veh_Ped_Hash.Add("0x5852838");
            Veh_Ped_Name.Add("kamacho"); Veh_Ped_Hash.Add("0xf8c2e0e7");
            Veh_Ped_Name.Add("kanjo"); Veh_Ped_Hash.Add("0x18619b7e");
            Veh_Ped_Name.Add("khamelion"); Veh_Ped_Hash.Add("0x206d1b68");
            Veh_Ped_Name.Add("khanjali"); Veh_Ped_Hash.Add("0xaa6f980a");
            Veh_Ped_Name.Add("komoda"); Veh_Ped_Hash.Add("0xce44c4b9");
            Veh_Ped_Name.Add("kosatka"); Veh_Ped_Hash.Add("0x4faf0d70");
            Veh_Ped_Name.Add("krieger"); Veh_Ped_Hash.Add("0xd86a0247");
            Veh_Ped_Name.Add("kuruma"); Veh_Ped_Hash.Add("0xae2bfe94");
            Veh_Ped_Name.Add("kuruma2"); Veh_Ped_Hash.Add("0x187d938d");
            Veh_Ped_Name.Add("landstalker"); Veh_Ped_Hash.Add("0x4ba4e8dc");
            Veh_Ped_Name.Add("landstalker2"); Veh_Ped_Hash.Add("0xce0b9f22");
            Veh_Ped_Name.Add("lazer"); Veh_Ped_Hash.Add("0xb39b0ae6");
            Veh_Ped_Name.Add("le7b"); Veh_Ped_Hash.Add("0xb6846a55");
            Veh_Ped_Name.Add("lectro"); Veh_Ped_Hash.Add("0x26321e67");
            Veh_Ped_Name.Add("lguard"); Veh_Ped_Hash.Add("0x1bf8d381");
            Veh_Ped_Name.Add("limo2"); Veh_Ped_Hash.Add("0xf92aec4d");
            Veh_Ped_Name.Add("locust"); Veh_Ped_Hash.Add("0xc7e55211");
            Veh_Ped_Name.Add("longfin"); Veh_Ped_Hash.Add("0x6ef89ccc");
            Veh_Ped_Name.Add("lurcher"); Veh_Ped_Hash.Add("0x7b47a6a7");
            Veh_Ped_Name.Add("luxor"); Veh_Ped_Hash.Add("0x250b0c5e");
            Veh_Ped_Name.Add("luxor2"); Veh_Ped_Hash.Add("0xb79f589e");
            Veh_Ped_Name.Add("lynx"); Veh_Ped_Hash.Add("0x1cbdc10b");
            Veh_Ped_Name.Add("mamba"); Veh_Ped_Hash.Add("0x9cfffc56");
            Veh_Ped_Name.Add("mammatus"); Veh_Ped_Hash.Add("0x97e55d11");
            Veh_Ped_Name.Add("manana"); Veh_Ped_Hash.Add("0x81634188");
            Veh_Ped_Name.Add("manana2"); Veh_Ped_Hash.Add("0x665f785d");
            Veh_Ped_Name.Add("manchez"); Veh_Ped_Hash.Add("0xa5325278");
            Veh_Ped_Name.Add("manchez2"); Veh_Ped_Hash.Add("0x40c332a3");
            Veh_Ped_Name.Add("marquis"); Veh_Ped_Hash.Add("0xc1ce1183");
            Veh_Ped_Name.Add("marshall"); Veh_Ped_Hash.Add("0x49863e9c");
            Veh_Ped_Name.Add("massacro"); Veh_Ped_Hash.Add("0xf77ade32");
            Veh_Ped_Name.Add("massacro2"); Veh_Ped_Hash.Add("0xda5819a3");
            Veh_Ped_Name.Add("maverick"); Veh_Ped_Hash.Add("0x9d0450ca");
            Veh_Ped_Name.Add("menacer"); Veh_Ped_Hash.Add("0x79dd18ae");
            Veh_Ped_Name.Add("mesa"); Veh_Ped_Hash.Add("0x36848602");
            Veh_Ped_Name.Add("mesa2"); Veh_Ped_Hash.Add("0xd36a4b44");
            Veh_Ped_Name.Add("mesa3"); Veh_Ped_Hash.Add("0x84f42e51");
            Veh_Ped_Name.Add("metrotrain"); Veh_Ped_Hash.Add("0x33c9e158");
            Veh_Ped_Name.Add("michelli"); Veh_Ped_Hash.Add("0x3e5bd8d9");
            Veh_Ped_Name.Add("microlight"); Veh_Ped_Hash.Add("0x96e24857");
            Veh_Ped_Name.Add("miljet"); Veh_Ped_Hash.Add("0x9d80f93");
            Veh_Ped_Name.Add("minitank"); Veh_Ped_Hash.Add("0xb53c6c52");
            Veh_Ped_Name.Add("minivan"); Veh_Ped_Hash.Add("0xed7eada4");
            Veh_Ped_Name.Add("minivan2"); Veh_Ped_Hash.Add("0xbcde91f0");
            Veh_Ped_Name.Add("mixer"); Veh_Ped_Hash.Add("0xd138a6bb");
            Veh_Ped_Name.Add("mixer2"); Veh_Ped_Hash.Add("0x1c534995");
            Veh_Ped_Name.Add("mogul"); Veh_Ped_Hash.Add("0xd35698ef");
            Veh_Ped_Name.Add("molotok"); Veh_Ped_Hash.Add("0x5d56f01b");
            Veh_Ped_Name.Add("monroe"); Veh_Ped_Hash.Add("0xe62b361b");
            Veh_Ped_Name.Add("monster"); Veh_Ped_Hash.Add("0xcd93a7db");
            Veh_Ped_Name.Add("monster3"); Veh_Ped_Hash.Add("0x669eb40a");
            Veh_Ped_Name.Add("monster4"); Veh_Ped_Hash.Add("0x32174afc");
            Veh_Ped_Name.Add("monster5"); Veh_Ped_Hash.Add("0xd556917c");
            Veh_Ped_Name.Add("moonbeam"); Veh_Ped_Hash.Add("0x1f52a43f");
            Veh_Ped_Name.Add("moonbeam2"); Veh_Ped_Hash.Add("0x710a2b9b");
            Veh_Ped_Name.Add("mower"); Veh_Ped_Hash.Add("0x6a4bd8f6");
            Veh_Ped_Name.Add("mule"); Veh_Ped_Hash.Add("0x35ed670b");
            Veh_Ped_Name.Add("mule2"); Veh_Ped_Hash.Add("0xc1632beb");
            Veh_Ped_Name.Add("mule3"); Veh_Ped_Hash.Add("0x85a5b471");
            Veh_Ped_Name.Add("mule4"); Veh_Ped_Hash.Add("0x73f4110e");
            Veh_Ped_Name.Add("mule5"); Veh_Ped_Hash.Add("0x501ac93c");
            Veh_Ped_Name.Add("nebula"); Veh_Ped_Hash.Add("0xcb642637");
            Veh_Ped_Name.Add("nemesis"); Veh_Ped_Hash.Add("0xda288376");
            Veh_Ped_Name.Add("neo"); Veh_Ped_Hash.Add("0x9f6ed5a2");
            Veh_Ped_Name.Add("neon"); Veh_Ped_Hash.Add("0x91ca96ee");
            Veh_Ped_Name.Add("nero"); Veh_Ped_Hash.Add("0x3da47243");
            Veh_Ped_Name.Add("nero2"); Veh_Ped_Hash.Add("0x4131f378");
            Veh_Ped_Name.Add("nightblade"); Veh_Ped_Hash.Add("0xa0438767");
            Veh_Ped_Name.Add("nightshade"); Veh_Ped_Hash.Add("0x8c2bd0dc");
            Veh_Ped_Name.Add("nightshark"); Veh_Ped_Hash.Add("0x19dd9ed1");
            Veh_Ped_Name.Add("nimbus"); Veh_Ped_Hash.Add("0xb2cf7250");
            Veh_Ped_Name.Add("ninef"); Veh_Ped_Hash.Add("0x3d8fa25c");
            Veh_Ped_Name.Add("ninef2"); Veh_Ped_Hash.Add("0xa8e38b01");
            Veh_Ped_Name.Add("nokota"); Veh_Ped_Hash.Add("0x3dc92356");
            Veh_Ped_Name.Add("novak"); Veh_Ped_Hash.Add("0x92f5024e");
            Veh_Ped_Name.Add("omnis"); Veh_Ped_Hash.Add("0xd1ad4937");
            Veh_Ped_Name.Add("openwheel1"); Veh_Ped_Hash.Add("0x58f77553");
            Veh_Ped_Name.Add("openwheel2"); Veh_Ped_Hash.Add("0x4669d038");
            Veh_Ped_Name.Add("oppressor"); Veh_Ped_Hash.Add("0x34b82784");
            Veh_Ped_Name.Add("oppressor2"); Veh_Ped_Hash.Add("0x7b54a9d3");
            Veh_Ped_Name.Add("oracle"); Veh_Ped_Hash.Add("0x506434f6");
            Veh_Ped_Name.Add("oracle2"); Veh_Ped_Hash.Add("0xe18195b2");
            Veh_Ped_Name.Add("osiris"); Veh_Ped_Hash.Add("0x767164d6");
            Veh_Ped_Name.Add("outlaw"); Veh_Ped_Hash.Add("0x185e2ff3");
            Veh_Ped_Name.Add("packer"); Veh_Ped_Hash.Add("0x21eee87d");
            Veh_Ped_Name.Add("panto"); Veh_Ped_Hash.Add("0xe644e480");
            Veh_Ped_Name.Add("paradise"); Veh_Ped_Hash.Add("0x58b3979c");
            Veh_Ped_Name.Add("paragon"); Veh_Ped_Hash.Add("0xe550775b");
            Veh_Ped_Name.Add("paragon2"); Veh_Ped_Hash.Add("0x546d8eee");
            Veh_Ped_Name.Add("pariah"); Veh_Ped_Hash.Add("0x33b98fe2");
            Veh_Ped_Name.Add("patriot"); Veh_Ped_Hash.Add("0xcfcfeb3b");
            Veh_Ped_Name.Add("patriot2"); Veh_Ped_Hash.Add("0xe6e967f8");
            Veh_Ped_Name.Add("patriot3"); Veh_Ped_Hash.Add("0xd80f4a44");
            Veh_Ped_Name.Add("patrolboat"); Veh_Ped_Hash.Add("0xef813606");
            Veh_Ped_Name.Add("pbus"); Veh_Ped_Hash.Add("0x885f3671");
            Veh_Ped_Name.Add("pbus2"); Veh_Ped_Hash.Add("0x149bd32a");
            Veh_Ped_Name.Add("pcj"); Veh_Ped_Hash.Add("0xc9ceaf06");
            Veh_Ped_Name.Add("penetrator"); Veh_Ped_Hash.Add("0x9734f3ea");
            Veh_Ped_Name.Add("penumbra"); Veh_Ped_Hash.Add("0xe9805550");
            Veh_Ped_Name.Add("penumbra2"); Veh_Ped_Hash.Add("0xda5ec7da");
            Veh_Ped_Name.Add("peyote"); Veh_Ped_Hash.Add("0x6d19ccbc");
            Veh_Ped_Name.Add("peyote2"); Veh_Ped_Hash.Add("0x9472cd24");
            Veh_Ped_Name.Add("peyote3"); Veh_Ped_Hash.Add("0x4201a843");
            Veh_Ped_Name.Add("pfister811"); Veh_Ped_Hash.Add("0x92ef6e04");
            Veh_Ped_Name.Add("phantom"); Veh_Ped_Hash.Add("0x809aa4cb");
            Veh_Ped_Name.Add("phantom2"); Veh_Ped_Hash.Add("0x9dae1398");
            Veh_Ped_Name.Add("phantom3"); Veh_Ped_Hash.Add("0xa90ed5c");
            Veh_Ped_Name.Add("phoenix"); Veh_Ped_Hash.Add("0x831a21d5");
            Veh_Ped_Name.Add("picador"); Veh_Ped_Hash.Add("0x59e0fbf3");
            Veh_Ped_Name.Add("pigalle"); Veh_Ped_Hash.Add("0x404b6381");
            Veh_Ped_Name.Add("police"); Veh_Ped_Hash.Add("0x79fbb0c5");
            Veh_Ped_Name.Add("police2"); Veh_Ped_Hash.Add("0x9f05f101");
            Veh_Ped_Name.Add("police3"); Veh_Ped_Hash.Add("0x71fa16ea");
            Veh_Ped_Name.Add("police4"); Veh_Ped_Hash.Add("0x8a63c7b9");
            Veh_Ped_Name.Add("policeb"); Veh_Ped_Hash.Add("0xfdefaec3");
            Veh_Ped_Name.Add("policeold1"); Veh_Ped_Hash.Add("0xa46462f7");
            Veh_Ped_Name.Add("policeold2"); Veh_Ped_Hash.Add("0x95f4c618");
            Veh_Ped_Name.Add("policet"); Veh_Ped_Hash.Add("0x1b38e955");
            Veh_Ped_Name.Add("polmav"); Veh_Ped_Hash.Add("0x1517d4d9");
            Veh_Ped_Name.Add("pony"); Veh_Ped_Hash.Add("0xf8de29a8");
            Veh_Ped_Name.Add("pony2"); Veh_Ped_Hash.Add("0x38408341");
            Veh_Ped_Name.Add("pounder"); Veh_Ped_Hash.Add("0x7de35e7d");
            Veh_Ped_Name.Add("pounder2"); Veh_Ped_Hash.Add("0x6290f15b");
            Veh_Ped_Name.Add("prairie"); Veh_Ped_Hash.Add("0xa988d3a2");
            Veh_Ped_Name.Add("pranger"); Veh_Ped_Hash.Add("0x2c33b46e");
            Veh_Ped_Name.Add("predator"); Veh_Ped_Hash.Add("0xe2e7d4ab");
            Veh_Ped_Name.Add("premier"); Veh_Ped_Hash.Add("0x8fb66f9b");
            Veh_Ped_Name.Add("previon"); Veh_Ped_Hash.Add("0x546da331");
            Veh_Ped_Name.Add("primo"); Veh_Ped_Hash.Add("0xbb6b404f");
            Veh_Ped_Name.Add("primo2"); Veh_Ped_Hash.Add("0x86618eda");
            Veh_Ped_Name.Add("proptrailer"); Veh_Ped_Hash.Add("0x153e1b0a");
            Veh_Ped_Name.Add("prototipo"); Veh_Ped_Hash.Add("0x7e8f677f");
            Veh_Ped_Name.Add("pyro"); Veh_Ped_Hash.Add("0xad6065c0");
            Veh_Ped_Name.Add("radi"); Veh_Ped_Hash.Add("0x9d96b45b");
            Veh_Ped_Name.Add("raiden"); Veh_Ped_Hash.Add("0xa4d99b7d");
            Veh_Ped_Name.Add("raketrailer"); Veh_Ped_Hash.Add("0x174cb172");
            Veh_Ped_Name.Add("rallytruck"); Veh_Ped_Hash.Add("0x829a3c44");
            Veh_Ped_Name.Add("rancherxl"); Veh_Ped_Hash.Add("0x6210cbb0");
            Veh_Ped_Name.Add("rancherxl2"); Veh_Ped_Hash.Add("0x7341576b");
            Veh_Ped_Name.Add("rapidgt"); Veh_Ped_Hash.Add("0x8cb29a14");
            Veh_Ped_Name.Add("rapidgt2"); Veh_Ped_Hash.Add("0x679450af");
            Veh_Ped_Name.Add("rapidgt3"); Veh_Ped_Hash.Add("0x7a2ef5e4");
            Veh_Ped_Name.Add("raptor"); Veh_Ped_Hash.Add("0xd7c56d39");
            Veh_Ped_Name.Add("ratbike"); Veh_Ped_Hash.Add("0x6facdf31");
            Veh_Ped_Name.Add("ratloader"); Veh_Ped_Hash.Add("0xd83c13ce");
            Veh_Ped_Name.Add("ratloader2"); Veh_Ped_Hash.Add("0xdce1d9f7");
            Veh_Ped_Name.Add("rcbandito"); Veh_Ped_Hash.Add("0xeef345ec");
            Veh_Ped_Name.Add("reaper"); Veh_Ped_Hash.Add("0xdf381e5");
            Veh_Ped_Name.Add("rebel"); Veh_Ped_Hash.Add("0xb802dd46");
            Veh_Ped_Name.Add("rebel2"); Veh_Ped_Hash.Add("0x8612b64b");
            Veh_Ped_Name.Add("rebla"); Veh_Ped_Hash.Add("0x4f48fc4");
            Veh_Ped_Name.Add("reever"); Veh_Ped_Hash.Add("0x76d7c404");
            Veh_Ped_Name.Add("regina"); Veh_Ped_Hash.Add("0xff22d208");
            Veh_Ped_Name.Add("remus"); Veh_Ped_Hash.Add("0x5216ad5e");
            Veh_Ped_Name.Add("rentalbus"); Veh_Ped_Hash.Add("0xbe819c63");
            Veh_Ped_Name.Add("retinue"); Veh_Ped_Hash.Add("0x6dbd6c0a");
            Veh_Ped_Name.Add("retinue2"); Veh_Ped_Hash.Add("0x79178f0a");
            Veh_Ped_Name.Add("revolter"); Veh_Ped_Hash.Add("0xe78cc3d9");
            Veh_Ped_Name.Add("rhapsody"); Veh_Ped_Hash.Add("0x322cf98f");
            Veh_Ped_Name.Add("rhino"); Veh_Ped_Hash.Add("0x2ea68690");
            Veh_Ped_Name.Add("riata"); Veh_Ped_Hash.Add("0xa4a4e453");
            Veh_Ped_Name.Add("riot"); Veh_Ped_Hash.Add("0xb822a1aa");
            Veh_Ped_Name.Add("riot2"); Veh_Ped_Hash.Add("0x9b16a3b4");
            Veh_Ped_Name.Add("ripley"); Veh_Ped_Hash.Add("0xcd935ef9");
            Veh_Ped_Name.Add("rocoto"); Veh_Ped_Hash.Add("0x7f5c91f1");
            Veh_Ped_Name.Add("rogue"); Veh_Ped_Hash.Add("0xc5dd6967");
            Veh_Ped_Name.Add("romero"); Veh_Ped_Hash.Add("0x2560b2fc");
            Veh_Ped_Name.Add("rrocket"); Veh_Ped_Hash.Add("0x36a167e0");
            Veh_Ped_Name.Add("rt3000"); Veh_Ped_Hash.Add("0xe505cf99");
            Veh_Ped_Name.Add("rubble"); Veh_Ped_Hash.Add("0x9a5b1dcc");
            Veh_Ped_Name.Add("ruffian"); Veh_Ped_Hash.Add("0xcabd11e8");
            Veh_Ped_Name.Add("ruiner"); Veh_Ped_Hash.Add("0xf26ceff9");
            Veh_Ped_Name.Add("ruiner2"); Veh_Ped_Hash.Add("0x381e10bd");
            Veh_Ped_Name.Add("ruiner3"); Veh_Ped_Hash.Add("0x2e5afd37");
            Veh_Ped_Name.Add("rumpo"); Veh_Ped_Hash.Add("0x4543b74d");
            Veh_Ped_Name.Add("rumpo2"); Veh_Ped_Hash.Add("0x961afef7");
            Veh_Ped_Name.Add("rumpo3"); Veh_Ped_Hash.Add("0x57f682af");
            Veh_Ped_Name.Add("ruston"); Veh_Ped_Hash.Add("0x2ae524a8");
            Veh_Ped_Name.Add("s80"); Veh_Ped_Hash.Add("0xeca6b6a3");
            Veh_Ped_Name.Add("sabregt"); Veh_Ped_Hash.Add("0x9b909c94");
            Veh_Ped_Name.Add("sabregt2"); Veh_Ped_Hash.Add("0xd4ea603");
            Veh_Ped_Name.Add("sadler"); Veh_Ped_Hash.Add("0xdc434e51");
            Veh_Ped_Name.Add("sadler2"); Veh_Ped_Hash.Add("0x2bc345d1");
            Veh_Ped_Name.Add("sanchez"); Veh_Ped_Hash.Add("0x2ef89e46");
            Veh_Ped_Name.Add("sanchez2"); Veh_Ped_Hash.Add("0xa960b13e");
            Veh_Ped_Name.Add("sanctus"); Veh_Ped_Hash.Add("0x58e316c7");
            Veh_Ped_Name.Add("sandking"); Veh_Ped_Hash.Add("0xb9210fd0");
            Veh_Ped_Name.Add("sandking2"); Veh_Ped_Hash.Add("0x3af8c345");
            Veh_Ped_Name.Add("savage"); Veh_Ped_Hash.Add("0xfb133a17");
            Veh_Ped_Name.Add("savestra"); Veh_Ped_Hash.Add("0x35ded0dd");
            Veh_Ped_Name.Add("sc1"); Veh_Ped_Hash.Add("0x5097f589");
            Veh_Ped_Name.Add("scarab"); Veh_Ped_Hash.Add("0xbba2a2f7");
            Veh_Ped_Name.Add("scarab2"); Veh_Ped_Hash.Add("0x5beb3ce0");
            Veh_Ped_Name.Add("scarab3"); Veh_Ped_Hash.Add("0xdd71bfeb");
            Veh_Ped_Name.Add("schafter2"); Veh_Ped_Hash.Add("0xb52b5113");
            Veh_Ped_Name.Add("schafter3"); Veh_Ped_Hash.Add("0xa774b5a6");
            Veh_Ped_Name.Add("schafter4"); Veh_Ped_Hash.Add("0x58cf185c");
            Veh_Ped_Name.Add("schafter5"); Veh_Ped_Hash.Add("0xcb0e7cd9");
            Veh_Ped_Name.Add("schafter6"); Veh_Ped_Hash.Add("0x72934be4");
            Veh_Ped_Name.Add("schlagen"); Veh_Ped_Hash.Add("0xe1c03ab0");
            Veh_Ped_Name.Add("schwarzer"); Veh_Ped_Hash.Add("0xd37b7976");
            Veh_Ped_Name.Add("scorcher"); Veh_Ped_Hash.Add("0xf4e1aa15");
            Veh_Ped_Name.Add("scramjet"); Veh_Ped_Hash.Add("0xd9f0503d");
            Veh_Ped_Name.Add("scrap"); Veh_Ped_Hash.Add("0x9a9fd3df");
            Veh_Ped_Name.Add("seabreeze"); Veh_Ped_Hash.Add("0xe8983f9f");
            Veh_Ped_Name.Add("seashark"); Veh_Ped_Hash.Add("0xc2974024");
            Veh_Ped_Name.Add("seashark2"); Veh_Ped_Hash.Add("0xdb4388e4");
            Veh_Ped_Name.Add("seashark3"); Veh_Ped_Hash.Add("0xed762d49");
            Veh_Ped_Name.Add("seasparrow"); Veh_Ped_Hash.Add("0xd4ae63d9");
            Veh_Ped_Name.Add("seasparrow2"); Veh_Ped_Hash.Add("0x494752f7");
            Veh_Ped_Name.Add("seasparrow3"); Veh_Ped_Hash.Add("0x5f017e6b");
            Veh_Ped_Name.Add("seminole"); Veh_Ped_Hash.Add("0x48ceced3");
            Veh_Ped_Name.Add("seminole2"); Veh_Ped_Hash.Add("0x94114926");
            Veh_Ped_Name.Add("sentinel"); Veh_Ped_Hash.Add("0x50732c82");
            Veh_Ped_Name.Add("sentinel2"); Veh_Ped_Hash.Add("0x3412ae2d");
            Veh_Ped_Name.Add("sentinel3"); Veh_Ped_Hash.Add("0x41d149aa");
            Veh_Ped_Name.Add("serrano"); Veh_Ped_Hash.Add("0x4fb1a214");
            Veh_Ped_Name.Add("seven70"); Veh_Ped_Hash.Add("0x97398a4b");
            Veh_Ped_Name.Add("shamal"); Veh_Ped_Hash.Add("0xb79c1bf5");
            Veh_Ped_Name.Add("sheava"); Veh_Ped_Hash.Add("0x30d3f6d8");
            Veh_Ped_Name.Add("sheriff"); Veh_Ped_Hash.Add("0x9baa707c");
            Veh_Ped_Name.Add("sheriff2"); Veh_Ped_Hash.Add("0x72935408");
            Veh_Ped_Name.Add("shinobi"); Veh_Ped_Hash.Add("0x50a6fb9c");
            Veh_Ped_Name.Add("shotaro"); Veh_Ped_Hash.Add("0xe7d2a16e");
            Veh_Ped_Name.Add("skylift"); Veh_Ped_Hash.Add("0x3e48bf23");
            Veh_Ped_Name.Add("slamtruck"); Veh_Ped_Hash.Add("0xc1a8a914");
            Veh_Ped_Name.Add("slamvan"); Veh_Ped_Hash.Add("0x2b7f9de3");
            Veh_Ped_Name.Add("slamvan2"); Veh_Ped_Hash.Add("0x31adbbfc");
            Veh_Ped_Name.Add("slamvan3"); Veh_Ped_Hash.Add("0x42bc5e19");
            Veh_Ped_Name.Add("slamvan4"); Veh_Ped_Hash.Add("0x8526e2f5");
            Veh_Ped_Name.Add("slamvan5"); Veh_Ped_Hash.Add("0x163f8520");
            Veh_Ped_Name.Add("slamvan6"); Veh_Ped_Hash.Add("0x67d52852");
            Veh_Ped_Name.Add("sovereign"); Veh_Ped_Hash.Add("0x2c509634");
            Veh_Ped_Name.Add("specter"); Veh_Ped_Hash.Add("0x706e2b40");
            Veh_Ped_Name.Add("specter2"); Veh_Ped_Hash.Add("0x400f5147");
            Veh_Ped_Name.Add("speeder"); Veh_Ped_Hash.Add("0xdc60d2b");
            Veh_Ped_Name.Add("speeder2"); Veh_Ped_Hash.Add("0x1a144f2a");
            Veh_Ped_Name.Add("speedo"); Veh_Ped_Hash.Add("0xcfb3870c");
            Veh_Ped_Name.Add("speedo2"); Veh_Ped_Hash.Add("0x2b6dc64a");
            Veh_Ped_Name.Add("speedo4"); Veh_Ped_Hash.Add("0xd17099d");
            Veh_Ped_Name.Add("squaddie"); Veh_Ped_Hash.Add("0xf9e67c05");
            Veh_Ped_Name.Add("squalo"); Veh_Ped_Hash.Add("0x17df5ec2");
            Veh_Ped_Name.Add("stafford"); Veh_Ped_Hash.Add("0x1324e960");
            Veh_Ped_Name.Add("stalion"); Veh_Ped_Hash.Add("0x72a4c31e");
            Veh_Ped_Name.Add("stalion2"); Veh_Ped_Hash.Add("0xe80f67ee");
            Veh_Ped_Name.Add("stanier"); Veh_Ped_Hash.Add("0xa7ede74d");
            Veh_Ped_Name.Add("starling"); Veh_Ped_Hash.Add("0x9a9eb7de");
            Veh_Ped_Name.Add("stinger"); Veh_Ped_Hash.Add("0x5c23af9b");
            Veh_Ped_Name.Add("stingergt"); Veh_Ped_Hash.Add("0x82e499fa");
            Veh_Ped_Name.Add("stockade"); Veh_Ped_Hash.Add("0x6827cf72");
            Veh_Ped_Name.Add("stockade3"); Veh_Ped_Hash.Add("0xf337ab36");
            Veh_Ped_Name.Add("stratum"); Veh_Ped_Hash.Add("0x66b4fc45");
            Veh_Ped_Name.Add("streiter"); Veh_Ped_Hash.Add("0x67d2b389");
            Veh_Ped_Name.Add("stretch"); Veh_Ped_Hash.Add("0x8b13f083");
            Veh_Ped_Name.Add("strikeforce"); Veh_Ped_Hash.Add("0x64de07a1");
            Veh_Ped_Name.Add("stromberg"); Veh_Ped_Hash.Add("0x34dba661");
            Veh_Ped_Name.Add("stryder"); Veh_Ped_Hash.Add("0x11f58a5a");
            Veh_Ped_Name.Add("stunt"); Veh_Ped_Hash.Add("0x81794c70");
            Veh_Ped_Name.Add("submersible"); Veh_Ped_Hash.Add("0x2dff622f");
            Veh_Ped_Name.Add("submersible2"); Veh_Ped_Hash.Add("0xc07107ee");
            Veh_Ped_Name.Add("sugoi"); Veh_Ped_Hash.Add("0x3adb9758");
            Veh_Ped_Name.Add("sultan"); Veh_Ped_Hash.Add("0x39da2754");
            Veh_Ped_Name.Add("sultan2"); Veh_Ped_Hash.Add("0x3404691c");
            Veh_Ped_Name.Add("sultan3"); Veh_Ped_Hash.Add("0xeea75e63");
            Veh_Ped_Name.Add("sultanrs"); Veh_Ped_Hash.Add("0xee6024bc");
            Veh_Ped_Name.Add("suntrap"); Veh_Ped_Hash.Add("0xef2295c9");
            Veh_Ped_Name.Add("superd"); Veh_Ped_Hash.Add("0x42f2ed16");
            Veh_Ped_Name.Add("supervolito"); Veh_Ped_Hash.Add("0x2a54c47d");
            Veh_Ped_Name.Add("supervolito2"); Veh_Ped_Hash.Add("0x9c5e5644");
            Veh_Ped_Name.Add("surano"); Veh_Ped_Hash.Add("0x16e478c1");
            Veh_Ped_Name.Add("surfer"); Veh_Ped_Hash.Add("0x29b0da97");
            Veh_Ped_Name.Add("surfer2"); Veh_Ped_Hash.Add("0xb1d80e06");
            Veh_Ped_Name.Add("surge"); Veh_Ped_Hash.Add("0x8f0e3594");
            Veh_Ped_Name.Add("swift"); Veh_Ped_Hash.Add("0xebc24df2");
            Veh_Ped_Name.Add("swift2"); Veh_Ped_Hash.Add("0x4019cb4c");
            Veh_Ped_Name.Add("swinger"); Veh_Ped_Hash.Add("0x1dd4c0ff");
            Veh_Ped_Name.Add("t20"); Veh_Ped_Hash.Add("0x6322b39a");
            Veh_Ped_Name.Add("taco"); Veh_Ped_Hash.Add("0x744ca80d");
            Veh_Ped_Name.Add("tailgater"); Veh_Ped_Hash.Add("0xc3ddfdce");
            Veh_Ped_Name.Add("tailgater2"); Veh_Ped_Hash.Add("0xb5d306a4");
            Veh_Ped_Name.Add("taipan"); Veh_Ped_Hash.Add("0xbc5dc07e");
            Veh_Ped_Name.Add("tampa"); Veh_Ped_Hash.Add("0x39f9c898");
            Veh_Ped_Name.Add("tampa2"); Veh_Ped_Hash.Add("0xc0240885");
            Veh_Ped_Name.Add("tampa3"); Veh_Ped_Hash.Add("0xb7d9f7f1");
            Veh_Ped_Name.Add("tanker"); Veh_Ped_Hash.Add("0xd46f4737");
            Veh_Ped_Name.Add("tanker2"); Veh_Ped_Hash.Add("0x74998082");
            Veh_Ped_Name.Add("tankercar"); Veh_Ped_Hash.Add("0x22eddc30");
            Veh_Ped_Name.Add("taxi"); Veh_Ped_Hash.Add("0xc703db5f");
            Veh_Ped_Name.Add("technical"); Veh_Ped_Hash.Add("0x83051506");
            Veh_Ped_Name.Add("technical2"); Veh_Ped_Hash.Add("0x4662bcbb");
            Veh_Ped_Name.Add("technical3"); Veh_Ped_Hash.Add("0x50d4d19f");
            Veh_Ped_Name.Add("tempesta"); Veh_Ped_Hash.Add("0x1044926f");
            Veh_Ped_Name.Add("terbyte"); Veh_Ped_Hash.Add("0x897afc65");
            Veh_Ped_Name.Add("tezeract"); Veh_Ped_Hash.Add("0x3d7c6410");
            Veh_Ped_Name.Add("thrax"); Veh_Ped_Hash.Add("0x3e3d1f59");
            Veh_Ped_Name.Add("thrust"); Veh_Ped_Hash.Add("0x6d6f8f43");
            Veh_Ped_Name.Add("thruster"); Veh_Ped_Hash.Add("0x58cdaf30");
            Veh_Ped_Name.Add("tigon"); Veh_Ped_Hash.Add("0xaf0b8d48");
            Veh_Ped_Name.Add("tiptruck"); Veh_Ped_Hash.Add("0x2e19879");
            Veh_Ped_Name.Add("tiptruck2"); Veh_Ped_Hash.Add("0xc7824e5e");
            Veh_Ped_Name.Add("titan"); Veh_Ped_Hash.Add("0x761e2ad3");
            Veh_Ped_Name.Add("toreador"); Veh_Ped_Hash.Add("0x56c8a5ef");
            Veh_Ped_Name.Add("torero"); Veh_Ped_Hash.Add("0x59a9e570");
            Veh_Ped_Name.Add("tornado"); Veh_Ped_Hash.Add("0x1bb290bc");
            Veh_Ped_Name.Add("tornado2"); Veh_Ped_Hash.Add("0x5b42a5c4");
            Veh_Ped_Name.Add("tornado3"); Veh_Ped_Hash.Add("0x690a4153");
            Veh_Ped_Name.Add("tornado4"); Veh_Ped_Hash.Add("0x86cf7cdd");
            Veh_Ped_Name.Add("tornado5"); Veh_Ped_Hash.Add("0x94da98ef");
            Veh_Ped_Name.Add("tornado6"); Veh_Ped_Hash.Add("0xa31cb573");
            Veh_Ped_Name.Add("toro"); Veh_Ped_Hash.Add("0x3fd5aa2f");
            Veh_Ped_Name.Add("toro2"); Veh_Ped_Hash.Add("0x362cac6d");
            Veh_Ped_Name.Add("toros"); Veh_Ped_Hash.Add("0xba5334ac");
            Veh_Ped_Name.Add("tourbus"); Veh_Ped_Hash.Add("0x73b1c3cb");
            Veh_Ped_Name.Add("towtruck"); Veh_Ped_Hash.Add("0xb12314e0");
            Veh_Ped_Name.Add("towtruck2"); Veh_Ped_Hash.Add("0xe5a2d6c6");
            Veh_Ped_Name.Add("tr2"); Veh_Ped_Hash.Add("0x7be032c6");
            Veh_Ped_Name.Add("tr3"); Veh_Ped_Hash.Add("0x6a59902d");
            Veh_Ped_Name.Add("tr4"); Veh_Ped_Hash.Add("0x7cab34d0");
            Veh_Ped_Name.Add("tractor"); Veh_Ped_Hash.Add("0x61d6ba8c");
            Veh_Ped_Name.Add("tractor2"); Veh_Ped_Hash.Add("0x843b73de");
            Veh_Ped_Name.Add("tractor3"); Veh_Ped_Hash.Add("0x562a97bd");
            Veh_Ped_Name.Add("trailerlarge"); Veh_Ped_Hash.Add("0x5993f939");
            Veh_Ped_Name.Add("trailerlogs"); Veh_Ped_Hash.Add("0x782a236d");
            Veh_Ped_Name.Add("trailers"); Veh_Ped_Hash.Add("0xcbb2be0e");
            Veh_Ped_Name.Add("trailers2"); Veh_Ped_Hash.Add("0xa1da3c91");
            Veh_Ped_Name.Add("trailers3"); Veh_Ped_Hash.Add("0x8548036d");
            Veh_Ped_Name.Add("trailers4"); Veh_Ped_Hash.Add("0xbe66f5aa");
            Veh_Ped_Name.Add("trailersmall"); Veh_Ped_Hash.Add("0x2a72beab");
            Veh_Ped_Name.Add("trailersmall2"); Veh_Ped_Hash.Add("0x8fd54ebb");
            Veh_Ped_Name.Add("trash"); Veh_Ped_Hash.Add("0x72435a19");
            Veh_Ped_Name.Add("trash2"); Veh_Ped_Hash.Add("0xb527915c");
            Veh_Ped_Name.Add("trflat"); Veh_Ped_Hash.Add("0xaf62f6b2");
            Veh_Ped_Name.Add("tribike"); Veh_Ped_Hash.Add("0x4339cd69");
            Veh_Ped_Name.Add("tribike2"); Veh_Ped_Hash.Add("0xb67597ec");
            Veh_Ped_Name.Add("tribike3"); Veh_Ped_Hash.Add("0xe823fb48");
            Veh_Ped_Name.Add("trophytruck"); Veh_Ped_Hash.Add("0x612f4b6");
            Veh_Ped_Name.Add("trophytruck2"); Veh_Ped_Hash.Add("0xd876dbe2");
            Veh_Ped_Name.Add("tropic"); Veh_Ped_Hash.Add("0x1149422f");
            Veh_Ped_Name.Add("tropic2"); Veh_Ped_Hash.Add("0x56590fe9");
            Veh_Ped_Name.Add("tropos"); Veh_Ped_Hash.Add("0x707e63a4");
            Veh_Ped_Name.Add("tug"); Veh_Ped_Hash.Add("0x82cac433");
            Veh_Ped_Name.Add("tula"); Veh_Ped_Hash.Add("0x3e2e4f8a");
            Veh_Ped_Name.Add("tulip"); Veh_Ped_Hash.Add("0x56d42971");
            Veh_Ped_Name.Add("turismo2"); Veh_Ped_Hash.Add("0xc575df11");
            Veh_Ped_Name.Add("turismor"); Veh_Ped_Hash.Add("0x185484e1");
            Veh_Ped_Name.Add("tvtrailer"); Veh_Ped_Hash.Add("0x967620be");
            Veh_Ped_Name.Add("tyrant"); Veh_Ped_Hash.Add("0xe99011c2");
            Veh_Ped_Name.Add("tyrus"); Veh_Ped_Hash.Add("0x7b406efb");
            Veh_Ped_Name.Add("utillitruck"); Veh_Ped_Hash.Add("0x1ed0a534");
            Veh_Ped_Name.Add("utillitruck2"); Veh_Ped_Hash.Add("0x34e6bf6b");
            Veh_Ped_Name.Add("utillitruck3"); Veh_Ped_Hash.Add("0x7f2153df");
            Veh_Ped_Name.Add("vacca"); Veh_Ped_Hash.Add("0x142e0dc3");
            Veh_Ped_Name.Add("vader"); Veh_Ped_Hash.Add("0xf79a00f7");
            Veh_Ped_Name.Add("vagner"); Veh_Ped_Hash.Add("0x7397224c");
            Veh_Ped_Name.Add("vagrant"); Veh_Ped_Hash.Add("0x2c1fea99");
            Veh_Ped_Name.Add("valkyrie"); Veh_Ped_Hash.Add("0xa09e15fd");
            Veh_Ped_Name.Add("valkyrie2"); Veh_Ped_Hash.Add("0x5bfa5c4b");
            Veh_Ped_Name.Add("vamos"); Veh_Ped_Hash.Add("0xfd128dfd");
            Veh_Ped_Name.Add("vectre"); Veh_Ped_Hash.Add("0xa42fc3a5");
            Veh_Ped_Name.Add("velum"); Veh_Ped_Hash.Add("0x9c429b6a");
            Veh_Ped_Name.Add("velum2"); Veh_Ped_Hash.Add("0x403820e8");
            Veh_Ped_Name.Add("verlierer2"); Veh_Ped_Hash.Add("0x41b77fa4");
            Veh_Ped_Name.Add("verus"); Veh_Ped_Hash.Add("0x11cbc051");
            Veh_Ped_Name.Add("vestra"); Veh_Ped_Hash.Add("0x4ff77e37");
            Veh_Ped_Name.Add("vetir"); Veh_Ped_Hash.Add("0x780ffbd2");
            Veh_Ped_Name.Add("veto"); Veh_Ped_Hash.Add("0xcce5c8fa");
            Veh_Ped_Name.Add("veto2"); Veh_Ped_Hash.Add("0xa703e4a9");
            Veh_Ped_Name.Add("vigero"); Veh_Ped_Hash.Add("0xcec6b9b7");
            Veh_Ped_Name.Add("vigilante"); Veh_Ped_Hash.Add("0xb5ef4c33");
            Veh_Ped_Name.Add("vindicator"); Veh_Ped_Hash.Add("0xaf599f01");
            Veh_Ped_Name.Add("virgo"); Veh_Ped_Hash.Add("0xe2504942");
            Veh_Ped_Name.Add("virgo2"); Veh_Ped_Hash.Add("0xca62927a");
            Veh_Ped_Name.Add("virgo3"); Veh_Ped_Hash.Add("0xfdffb0");
            Veh_Ped_Name.Add("viseris"); Veh_Ped_Hash.Add("0xe8a8ba94");
            Veh_Ped_Name.Add("visione"); Veh_Ped_Hash.Add("0xc4810400");
            Veh_Ped_Name.Add("volatol"); Veh_Ped_Hash.Add("0x1aad0ded");
            Veh_Ped_Name.Add("volatus"); Veh_Ped_Hash.Add("0x920016f1");
            Veh_Ped_Name.Add("voltic"); Veh_Ped_Hash.Add("0x9f4b77be");
            Veh_Ped_Name.Add("voltic2"); Veh_Ped_Hash.Add("0x3af76f4a");
            Veh_Ped_Name.Add("voodoo"); Veh_Ped_Hash.Add("0x779b4f2d");
            Veh_Ped_Name.Add("voodoo2"); Veh_Ped_Hash.Add("0x1f3766e3");
            Veh_Ped_Name.Add("vortex"); Veh_Ped_Hash.Add("0xdba9dbfc");
            Veh_Ped_Name.Add("vstr"); Veh_Ped_Hash.Add("0x56cdee7d");
            Veh_Ped_Name.Add("warrener"); Veh_Ped_Hash.Add("0x51d83328");
            Veh_Ped_Name.Add("warrener2"); Veh_Ped_Hash.Add("0x2290c50a");
            Veh_Ped_Name.Add("washington"); Veh_Ped_Hash.Add("0x69f06b57");
            Veh_Ped_Name.Add("wastelander"); Veh_Ped_Hash.Add("0x8e08ec82");
            Veh_Ped_Name.Add("weevil"); Veh_Ped_Hash.Add("0x61fe4d6a");
            Veh_Ped_Name.Add("windsor"); Veh_Ped_Hash.Add("0x5e4327c8");
            Veh_Ped_Name.Add("windsor2"); Veh_Ped_Hash.Add("0x8cf5cae1");
            Veh_Ped_Name.Add("winky"); Veh_Ped_Hash.Add("0xf376f1e6");
            Veh_Ped_Name.Add("wolfsbane"); Veh_Ped_Hash.Add("0xdb20a373");
            Veh_Ped_Name.Add("xa21"); Veh_Ped_Hash.Add("0x36b4a8a9");
            Veh_Ped_Name.Add("xls"); Veh_Ped_Hash.Add("0x47bbcf2e");
            Veh_Ped_Name.Add("xls2"); Veh_Ped_Hash.Add("0xe6401328");
            Veh_Ped_Name.Add("yosemite"); Veh_Ped_Hash.Add("0x6f946279");
            Veh_Ped_Name.Add("yosemite2"); Veh_Ped_Hash.Add("0x64f49967");
            Veh_Ped_Name.Add("yosemite3"); Veh_Ped_Hash.Add("0x409d787");
            Veh_Ped_Name.Add("youga"); Veh_Ped_Hash.Add("0x3e5f6b8");
            Veh_Ped_Name.Add("youga2"); Veh_Ped_Hash.Add("0x3d29cd2b");
            Veh_Ped_Name.Add("youga3"); Veh_Ped_Hash.Add("0x6b73a9be");
            Veh_Ped_Name.Add("youga4"); Veh_Ped_Hash.Add("0x589a840c");
            Veh_Ped_Name.Add("z190"); Veh_Ped_Hash.Add("0x3201dd49");
            Veh_Ped_Name.Add("zeno"); Veh_Ped_Hash.Add("0x2714aa93");
            Veh_Ped_Name.Add("zentorno"); Veh_Ped_Hash.Add("0xac5df515");
            Veh_Ped_Name.Add("zhaba"); Veh_Ped_Hash.Add("0x4c8dba51");
            Veh_Ped_Name.Add("zion"); Veh_Ped_Hash.Add("0xbd1b39c3");
            Veh_Ped_Name.Add("zion2"); Veh_Ped_Hash.Add("0xb8e2ae18");
            Veh_Ped_Name.Add("zion3"); Veh_Ped_Hash.Add("0x6f039a67");
            Veh_Ped_Name.Add("zombiea"); Veh_Ped_Hash.Add("0xc3d7c72b");
            Veh_Ped_Name.Add("zombieb"); Veh_Ped_Hash.Add("0xde05fb87");
            Veh_Ped_Name.Add("zorrusso"); Veh_Ped_Hash.Add("0xd757d97d");
            Veh_Ped_Name.Add("zr350"); Veh_Ped_Hash.Add("0x91373058");
            Veh_Ped_Name.Add("zr380"); Veh_Ped_Hash.Add("0x20314b42");
            Veh_Ped_Name.Add("zr3802"); Veh_Ped_Hash.Add("0xbe11efc6");
            Veh_Ped_Name.Add("zr3803"); Veh_Ped_Hash.Add("0xa7dcc35c");
            Veh_Ped_Name.Add("ztype"); Veh_Ped_Hash.Add("0x2d3bd401");

            for (int i = 0; i < Veh_Ped_Name.Count(); i++)
            {
                NameHash MyHash = new NameHash();
                MyHash.Item_Hash = Veh_Ped_Hash[i];
                MyHash.Item_Name = Veh_Ped_Name[i];
                NewVP.Veh_Hash.Add(MyHash);
            }

            Veh_Ped_Name.Clear();
            Veh_Ped_Hash.Clear();

            Veh_Ped_Name.Add("a_c_boar"); Veh_Ped_Hash.Add("0xce5ff074");
            Veh_Ped_Name.Add("a_c_cat_01"); Veh_Ped_Hash.Add("0x573201b8");
            Veh_Ped_Name.Add("a_c_chickenhawk"); Veh_Ped_Hash.Add("0xaab71f62");
            Veh_Ped_Name.Add("a_c_chimp"); Veh_Ped_Hash.Add("0xa8683715");
            Veh_Ped_Name.Add("a_c_chop"); Veh_Ped_Hash.Add("0x14ec17ea");
            Veh_Ped_Name.Add("a_c_chop_02"); Veh_Ped_Hash.Add("0x3df40fc1");
            Veh_Ped_Name.Add("a_c_cormorant"); Veh_Ped_Hash.Add("0x56e29962");
            Veh_Ped_Name.Add("a_c_cow"); Veh_Ped_Hash.Add("0xfcfa9e1e");
            Veh_Ped_Name.Add("a_c_coyote"); Veh_Ped_Hash.Add("0x644ac75e");
            Veh_Ped_Name.Add("a_c_crow"); Veh_Ped_Hash.Add("0x18012a9f");
            Veh_Ped_Name.Add("a_c_deer"); Veh_Ped_Hash.Add("0xd86b5a95");
            Veh_Ped_Name.Add("a_c_dolphin"); Veh_Ped_Hash.Add("0x8bbab455");
            Veh_Ped_Name.Add("a_c_fish"); Veh_Ped_Hash.Add("0x2fd800b7");
            Veh_Ped_Name.Add("a_c_hen"); Veh_Ped_Hash.Add("0x6af51faf");
            Veh_Ped_Name.Add("a_c_humpback"); Veh_Ped_Hash.Add("0x471be4b2");
            Veh_Ped_Name.Add("a_c_husky"); Veh_Ped_Hash.Add("0x4e8f95a2");
            Veh_Ped_Name.Add("a_c_killerwhale"); Veh_Ped_Hash.Add("0x8d8ac8b9");
            Veh_Ped_Name.Add("a_c_mtlion"); Veh_Ped_Hash.Add("0x1250d7ba");
            Veh_Ped_Name.Add("a_c_panther"); Veh_Ped_Hash.Add("0xe71d5e68");
            Veh_Ped_Name.Add("a_c_pig"); Veh_Ped_Hash.Add("0xb11bab56");
            Veh_Ped_Name.Add("a_c_pigeon"); Veh_Ped_Hash.Add("0x6a20728");
            Veh_Ped_Name.Add("a_c_poodle"); Veh_Ped_Hash.Add("0x431d501c");
            Veh_Ped_Name.Add("a_c_pug"); Veh_Ped_Hash.Add("0x6d362854");
            Veh_Ped_Name.Add("a_c_rabbit_01"); Veh_Ped_Hash.Add("0xdfb55c81");
            Veh_Ped_Name.Add("a_c_rat"); Veh_Ped_Hash.Add("0xc3b52966");
            Veh_Ped_Name.Add("a_c_retriever"); Veh_Ped_Hash.Add("0x349f33e1");
            Veh_Ped_Name.Add("a_c_rhesus"); Veh_Ped_Hash.Add("0xc2d06f53");
            Veh_Ped_Name.Add("a_c_rottweiler"); Veh_Ped_Hash.Add("0x9563221d");
            Veh_Ped_Name.Add("a_c_seagull"); Veh_Ped_Hash.Add("0xd3939dfd");
            Veh_Ped_Name.Add("a_c_sharkhammer"); Veh_Ped_Hash.Add("0x3c831724");
            Veh_Ped_Name.Add("a_c_sharktiger"); Veh_Ped_Hash.Add("0x6c3f072");
            Veh_Ped_Name.Add("a_c_shepherd"); Veh_Ped_Hash.Add("0x431fc24c");
            Veh_Ped_Name.Add("a_c_stingray"); Veh_Ped_Hash.Add("0xa148614d");
            Veh_Ped_Name.Add("a_c_westy"); Veh_Ped_Hash.Add("0xad7844bb");
            Veh_Ped_Name.Add("a_f_m_beach_01"); Veh_Ped_Hash.Add("0x303638a7");
            Veh_Ped_Name.Add("a_f_m_bevhills_01"); Veh_Ped_Hash.Add("0xbe086efd");
            Veh_Ped_Name.Add("a_f_m_bevhills_02"); Veh_Ped_Hash.Add("0xa039335f");
            Veh_Ped_Name.Add("a_f_m_bodybuild_01"); Veh_Ped_Hash.Add("0x3bd99114");
            Veh_Ped_Name.Add("a_f_m_business_02"); Veh_Ped_Hash.Add("0x1fc37dbc");
            Veh_Ped_Name.Add("a_f_m_downtown_01"); Veh_Ped_Hash.Add("0x654ad86e");
            Veh_Ped_Name.Add("a_f_m_eastsa_01"); Veh_Ped_Hash.Add("0x9d3dcb7a");
            Veh_Ped_Name.Add("a_f_m_eastsa_02"); Veh_Ped_Hash.Add("0x63c8d891");
            Veh_Ped_Name.Add("a_f_m_fatbla_01"); Veh_Ped_Hash.Add("0xfab48bcb");
            Veh_Ped_Name.Add("a_f_m_fatcult_01"); Veh_Ped_Hash.Add("0xb5cf80e4");
            Veh_Ped_Name.Add("a_f_m_fatwhite_01"); Veh_Ped_Hash.Add("0x38bad33b");
            Veh_Ped_Name.Add("a_f_m_ktown_01"); Veh_Ped_Hash.Add("0x52c824de");
            Veh_Ped_Name.Add("a_f_m_ktown_02"); Veh_Ped_Hash.Add("0x41018151");
            Veh_Ped_Name.Add("a_f_m_prolhost_01"); Veh_Ped_Hash.Add("0x169bd1e1");
            Veh_Ped_Name.Add("a_f_m_salton_01"); Veh_Ped_Hash.Add("0xde0e0969");
            Veh_Ped_Name.Add("a_f_m_skidrow_01"); Veh_Ped_Hash.Add("0xb097523b");
            Veh_Ped_Name.Add("a_f_m_soucent_01"); Veh_Ped_Hash.Add("0x745855a1");
            Veh_Ped_Name.Add("a_f_m_soucent_02"); Veh_Ped_Hash.Add("0xf322d338");
            Veh_Ped_Name.Add("a_f_m_soucentmc_01"); Veh_Ped_Hash.Add("0xcde955d2");
            Veh_Ped_Name.Add("a_f_m_tourist_01"); Veh_Ped_Hash.Add("0x505603b9");
            Veh_Ped_Name.Add("a_f_m_tramp_01"); Veh_Ped_Hash.Add("0x48f96f5b");
            Veh_Ped_Name.Add("a_f_m_trampbeac_01"); Veh_Ped_Hash.Add("0x8ca0c266");
            Veh_Ped_Name.Add("a_f_o_genstreet_01"); Veh_Ped_Hash.Add("0x61c81c85");
            Veh_Ped_Name.Add("a_f_o_indian_01"); Veh_Ped_Hash.Add("0xbad7bb80");
            Veh_Ped_Name.Add("a_f_o_ktown_01"); Veh_Ped_Hash.Add("0x47cf5e96");
            Veh_Ped_Name.Add("a_f_o_salton_01"); Veh_Ped_Hash.Add("0xccff7d8a");
            Veh_Ped_Name.Add("a_f_o_soucent_01"); Veh_Ped_Hash.Add("0x3dfa1830");
            Veh_Ped_Name.Add("a_f_o_soucent_02"); Veh_Ped_Hash.Add("0xa56de716");
            Veh_Ped_Name.Add("a_f_y_beach_01"); Veh_Ped_Hash.Add("0xc79f6928");
            Veh_Ped_Name.Add("a_f_y_beach_02"); Veh_Ped_Hash.Add("0xb920cc2b");
            Veh_Ped_Name.Add("a_f_y_bevhills_01"); Veh_Ped_Hash.Add("0x445ac854");
            Veh_Ped_Name.Add("a_f_y_bevhills_02"); Veh_Ped_Hash.Add("0x5c2cf7f8");
            Veh_Ped_Name.Add("a_f_y_bevhills_03"); Veh_Ped_Hash.Add("0x20c8012f");
            Veh_Ped_Name.Add("a_f_y_bevhills_04"); Veh_Ped_Hash.Add("0x36df2d5d");
            Veh_Ped_Name.Add("a_f_y_bevhills_05"); Veh_Ped_Hash.Add("0x92e7e56d");
            Veh_Ped_Name.Add("a_f_y_business_01"); Veh_Ped_Hash.Add("0x2799efd8");
            Veh_Ped_Name.Add("a_f_y_business_02"); Veh_Ped_Hash.Add("0x31430342");
            Veh_Ped_Name.Add("a_f_y_business_03"); Veh_Ped_Hash.Add("0xae86fdb4");
            Veh_Ped_Name.Add("a_f_y_business_04"); Veh_Ped_Hash.Add("0xb7c61032");
            Veh_Ped_Name.Add("a_f_y_carclub_01"); Veh_Ped_Hash.Add("0xfd08c54b");
            Veh_Ped_Name.Add("a_f_y_clubcust_01"); Veh_Ped_Hash.Add("0x67f6dbcd");
            Veh_Ped_Name.Add("a_f_y_clubcust_02"); Veh_Ped_Hash.Add("0x154e3679");
            Veh_Ped_Name.Add("a_f_y_clubcust_03"); Veh_Ped_Hash.Add("0xa40d25");
            Veh_Ped_Name.Add("a_f_y_clubcust_04"); Veh_Ped_Hash.Add("0x2ee1e9a0");
            Veh_Ped_Name.Add("a_f_y_eastsa_01"); Veh_Ped_Hash.Add("0xf5b0079d");
            Veh_Ped_Name.Add("a_f_y_eastsa_02"); Veh_Ped_Hash.Add("0x438a4ae");
            Veh_Ped_Name.Add("a_f_y_eastsa_03"); Veh_Ped_Hash.Add("0x51c03fa4");
            Veh_Ped_Name.Add("a_f_y_epsilon_01"); Veh_Ped_Hash.Add("0x689c2a80");
            Veh_Ped_Name.Add("a_f_y_femaleagent"); Veh_Ped_Hash.Add("0x50610c43");
            Veh_Ped_Name.Add("a_f_y_fitness_01"); Veh_Ped_Hash.Add("0x457c64fb");
            Veh_Ped_Name.Add("a_f_y_fitness_02"); Veh_Ped_Hash.Add("0x13c4818c");
            Veh_Ped_Name.Add("a_f_y_gencaspat_01"); Veh_Ped_Hash.Add("0x911b94b2");
            Veh_Ped_Name.Add("a_f_y_genhot_01"); Veh_Ped_Hash.Add("0x2f4aec3e");
            Veh_Ped_Name.Add("a_f_y_golfer_01"); Veh_Ped_Hash.Add("0x7dd8fb58");
            Veh_Ped_Name.Add("a_f_y_hiker_01"); Veh_Ped_Hash.Add("0x30830813");
            Veh_Ped_Name.Add("a_f_y_hippie_01"); Veh_Ped_Hash.Add("0x1475b827");
            Veh_Ped_Name.Add("a_f_y_hipster_01"); Veh_Ped_Hash.Add("0x8247d331");
            Veh_Ped_Name.Add("a_f_y_hipster_02"); Veh_Ped_Hash.Add("0x97f5fe8d");
            Veh_Ped_Name.Add("a_f_y_hipster_03"); Veh_Ped_Hash.Add("0xa5ba9a16");
            Veh_Ped_Name.Add("a_f_y_hipster_04"); Veh_Ped_Hash.Add("0x199881dc");
            Veh_Ped_Name.Add("a_f_y_indian_01"); Veh_Ped_Hash.Add("0x92d9cc1");
            Veh_Ped_Name.Add("a_f_y_juggalo_01"); Veh_Ped_Hash.Add("0xdb134533");
            Veh_Ped_Name.Add("a_f_y_runner_01"); Veh_Ped_Hash.Add("0xc7496729");
            Veh_Ped_Name.Add("a_f_y_rurmeth_01"); Veh_Ped_Hash.Add("0x3f789426");
            Veh_Ped_Name.Add("a_f_y_scdressy_01"); Veh_Ped_Hash.Add("0xdb5ec400");
            Veh_Ped_Name.Add("a_f_y_skater_01"); Veh_Ped_Hash.Add("0x695fe666");
            Veh_Ped_Name.Add("a_f_y_smartcaspat_01"); Veh_Ped_Hash.Add("0x10a4aed2");
            Veh_Ped_Name.Add("a_f_y_soucent_01"); Veh_Ped_Hash.Add("0x2c641d7a");
            Veh_Ped_Name.Add("a_f_y_soucent_02"); Veh_Ped_Hash.Add("0x5a8ef9cf");
            Veh_Ped_Name.Add("a_f_y_soucent_03"); Veh_Ped_Hash.Add("0x87b25415");
            Veh_Ped_Name.Add("a_f_y_studioparty_01"); Veh_Ped_Hash.Add("0x44b4d748");
            Veh_Ped_Name.Add("a_f_y_studioparty_02"); Veh_Ped_Hash.Add("0x76463a5e");
            Veh_Ped_Name.Add("a_f_y_tennis_01"); Veh_Ped_Hash.Add("0x550c79c6");
            Veh_Ped_Name.Add("a_f_y_topless_01"); Veh_Ped_Hash.Add("0x9cf26183");
            Veh_Ped_Name.Add("a_f_y_tourist_01"); Veh_Ped_Hash.Add("0x563b8570");
            Veh_Ped_Name.Add("a_f_y_tourist_02"); Veh_Ped_Hash.Add("0x9123fb40");
            Veh_Ped_Name.Add("a_f_y_vinewood_01"); Veh_Ped_Hash.Add("0x19f41f65");
            Veh_Ped_Name.Add("a_f_y_vinewood_02"); Veh_Ped_Hash.Add("0xdab6a0eb");
            Veh_Ped_Name.Add("a_f_y_vinewood_03"); Veh_Ped_Hash.Add("0x379ddab8");
            Veh_Ped_Name.Add("a_f_y_vinewood_04"); Veh_Ped_Hash.Add("0xfae46146");
            Veh_Ped_Name.Add("a_f_y_yoga_01"); Veh_Ped_Hash.Add("0xc41b062e");
            Veh_Ped_Name.Add("a_m_m_acult_01"); Veh_Ped_Hash.Add("0x5442c66b");
            Veh_Ped_Name.Add("a_m_m_afriamer_01"); Veh_Ped_Hash.Add("0xd172497e");
            Veh_Ped_Name.Add("a_m_m_beach_01"); Veh_Ped_Hash.Add("0x403db4fd");
            Veh_Ped_Name.Add("a_m_m_beach_02"); Veh_Ped_Hash.Add("0x787fa588");
            Veh_Ped_Name.Add("a_m_m_bevhills_01"); Veh_Ped_Hash.Add("0x54dbee1f");
            Veh_Ped_Name.Add("a_m_m_bevhills_02"); Veh_Ped_Hash.Add("0x3fb5c3d3");
            Veh_Ped_Name.Add("a_m_m_business_01"); Veh_Ped_Hash.Add("0x7e6a64b7");
            Veh_Ped_Name.Add("a_m_m_eastsa_01"); Veh_Ped_Hash.Add("0xf9a6f53f");
            Veh_Ped_Name.Add("a_m_m_eastsa_02"); Veh_Ped_Hash.Add("0x7dd91ac");
            Veh_Ped_Name.Add("a_m_m_farmer_01"); Veh_Ped_Hash.Add("0x94562dd7");
            Veh_Ped_Name.Add("a_m_m_fatlatin_01"); Veh_Ped_Hash.Add("0x61d201b3");
            Veh_Ped_Name.Add("a_m_m_genfat_01"); Veh_Ped_Hash.Add("0x6dd569f");
            Veh_Ped_Name.Add("a_m_m_genfat_02"); Veh_Ped_Hash.Add("0x13aef042");
            Veh_Ped_Name.Add("a_m_m_golfer_01"); Veh_Ped_Hash.Add("0xa9eb0e42");
            Veh_Ped_Name.Add("a_m_m_hasjew_01"); Veh_Ped_Hash.Add("0x6bd9b68c");
            Veh_Ped_Name.Add("a_m_m_hillbilly_01"); Veh_Ped_Hash.Add("0x6c9b2849");
            Veh_Ped_Name.Add("a_m_m_hillbilly_02"); Veh_Ped_Hash.Add("0x7b0e452f");
            Veh_Ped_Name.Add("a_m_m_indian_01"); Veh_Ped_Hash.Add("0xddcaaa2c");
            Veh_Ped_Name.Add("a_m_m_ktown_01"); Veh_Ped_Hash.Add("0xd15d7e71");
            Veh_Ped_Name.Add("a_m_m_malibu_01"); Veh_Ped_Hash.Add("0x2fde6eb7");
            Veh_Ped_Name.Add("a_m_m_mexcntry_01"); Veh_Ped_Hash.Add("0xdd817ead");
            Veh_Ped_Name.Add("a_m_m_mexlabor_01"); Veh_Ped_Hash.Add("0xb25d16b2");
            Veh_Ped_Name.Add("a_m_m_mlcrisis_01"); Veh_Ped_Hash.Add("0x5d0c5325");
            Veh_Ped_Name.Add("a_m_m_og_boss_01"); Veh_Ped_Hash.Add("0x681bd012");
            Veh_Ped_Name.Add("a_m_m_paparazzi_01"); Veh_Ped_Hash.Add("0xecca8c15");
            Veh_Ped_Name.Add("a_m_m_polynesian_01"); Veh_Ped_Hash.Add("0xa9d9b69e");
            Veh_Ped_Name.Add("a_m_m_prolhost_01"); Veh_Ped_Hash.Add("0x9712c38f");
            Veh_Ped_Name.Add("a_m_m_rurmeth_01"); Veh_Ped_Hash.Add("0x3bad4184");
            Veh_Ped_Name.Add("a_m_m_salton_01"); Veh_Ped_Hash.Add("0x4f2e038a");
            Veh_Ped_Name.Add("a_m_m_salton_02"); Veh_Ped_Hash.Add("0x60f4a717");
            Veh_Ped_Name.Add("a_m_m_salton_03"); Veh_Ped_Hash.Add("0xb28c4a45");
            Veh_Ped_Name.Add("a_m_m_salton_04"); Veh_Ped_Hash.Add("0x964511b7");
            Veh_Ped_Name.Add("a_m_m_skater_01"); Veh_Ped_Hash.Add("0xd9d7588c");
            Veh_Ped_Name.Add("a_m_m_skidrow_01"); Veh_Ped_Hash.Add("0x1eea6bd");
            Veh_Ped_Name.Add("a_m_m_socenlat_01"); Veh_Ped_Hash.Add("0xb8d69e3");
            Veh_Ped_Name.Add("a_m_m_soucent_01"); Veh_Ped_Hash.Add("0x6857c9b7");
            Veh_Ped_Name.Add("a_m_m_soucent_02"); Veh_Ped_Hash.Add("0x9f6d37e1");
            Veh_Ped_Name.Add("a_m_m_soucent_03"); Veh_Ped_Hash.Add("0x8bd990ba");
            Veh_Ped_Name.Add("a_m_m_soucent_04"); Veh_Ped_Hash.Add("0xc2fbfefe");
            Veh_Ped_Name.Add("a_m_m_stlat_02"); Veh_Ped_Hash.Add("0xc2a87702");
            Veh_Ped_Name.Add("a_m_m_studioparty_01"); Veh_Ped_Hash.Add("0x8b996025");
            Veh_Ped_Name.Add("a_m_m_tennis_01"); Veh_Ped_Hash.Add("0x546a5344");
            Veh_Ped_Name.Add("a_m_m_tourist_01"); Veh_Ped_Hash.Add("0xc89f0184");
            Veh_Ped_Name.Add("a_m_m_tramp_01"); Veh_Ped_Hash.Add("0x1ec93fd0");
            Veh_Ped_Name.Add("a_m_m_trampbeac_01"); Veh_Ped_Hash.Add("0x53b57eb0");
            Veh_Ped_Name.Add("a_m_m_tranvest_01"); Veh_Ped_Hash.Add("0xe0e69974");
            Veh_Ped_Name.Add("a_m_m_tranvest_02"); Veh_Ped_Hash.Add("0xf70ec5c4");
            Veh_Ped_Name.Add("a_m_o_acult_01"); Veh_Ped_Hash.Add("0x55446010");
            Veh_Ped_Name.Add("a_m_o_acult_02"); Veh_Ped_Hash.Add("0x4ba14cca");
            Veh_Ped_Name.Add("a_m_o_beach_01"); Veh_Ped_Hash.Add("0x8427d398");
            Veh_Ped_Name.Add("a_m_o_beach_02"); Veh_Ped_Hash.Add("0xc1534df2");
            Veh_Ped_Name.Add("a_m_o_genstreet_01"); Veh_Ped_Hash.Add("0xad54e7a8");
            Veh_Ped_Name.Add("a_m_o_ktown_01"); Veh_Ped_Hash.Add("0x1536d95a");
            Veh_Ped_Name.Add("a_m_o_salton_01"); Veh_Ped_Hash.Add("0x20208e4d");
            Veh_Ped_Name.Add("a_m_o_soucent_01"); Veh_Ped_Hash.Add("0x2ad8921b");
            Veh_Ped_Name.Add("a_m_o_soucent_02"); Veh_Ped_Hash.Add("0x4086bd77");
            Veh_Ped_Name.Add("a_m_o_soucent_03"); Veh_Ped_Hash.Add("0xe32d8d0");
            Veh_Ped_Name.Add("a_m_o_tramp_01"); Veh_Ped_Hash.Add("0x174d4245");
            Veh_Ped_Name.Add("a_m_y_acult_01"); Veh_Ped_Hash.Add("0xb564882b");
            Veh_Ped_Name.Add("a_m_y_acult_02"); Veh_Ped_Hash.Add("0x80e59f2e");
            Veh_Ped_Name.Add("a_m_y_beach_01"); Veh_Ped_Hash.Add("0xd1feb884");
            Veh_Ped_Name.Add("a_m_y_beach_02"); Veh_Ped_Hash.Add("0x23c7dc11");
            Veh_Ped_Name.Add("a_m_y_beach_03"); Veh_Ped_Hash.Add("0xe7a963d9");
            Veh_Ped_Name.Add("a_m_y_beach_04"); Veh_Ped_Hash.Add("0xb91a86bc");
            Veh_Ped_Name.Add("a_m_y_beachvesp_01"); Veh_Ped_Hash.Add("0x7e0961b8");
            Veh_Ped_Name.Add("a_m_y_beachvesp_02"); Veh_Ped_Hash.Add("0xca56fa52");
            Veh_Ped_Name.Add("a_m_y_bevhills_01"); Veh_Ped_Hash.Add("0x76284640");
            Veh_Ped_Name.Add("a_m_y_bevhills_02"); Veh_Ped_Hash.Add("0x668ba707");
            Veh_Ped_Name.Add("a_m_y_breakdance_01"); Veh_Ped_Hash.Add("0x379f9596");
            Veh_Ped_Name.Add("a_m_y_busicas_01"); Veh_Ped_Hash.Add("0x9ad32fe9");
            Veh_Ped_Name.Add("a_m_y_business_01"); Veh_Ped_Hash.Add("0xc99f21c4");
            Veh_Ped_Name.Add("a_m_y_business_02"); Veh_Ped_Hash.Add("0xb3b3f5e6");
            Veh_Ped_Name.Add("a_m_y_business_03"); Veh_Ped_Hash.Add("0xa1435105");
            Veh_Ped_Name.Add("a_m_y_carclub_01"); Veh_Ped_Hash.Add("0x685ff8d4");
            Veh_Ped_Name.Add("a_m_y_clubcust_01"); Veh_Ped_Hash.Add("0xa7b71042");
            Veh_Ped_Name.Add("a_m_y_clubcust_02"); Veh_Ped_Hash.Add("0xc62f4d32");
            Veh_Ped_Name.Add("a_m_y_clubcust_03"); Veh_Ped_Hash.Add("0xd4f5eabf");
            Veh_Ped_Name.Add("a_m_y_clubcust_04"); Veh_Ped_Hash.Add("0xe2210515");
            Veh_Ped_Name.Add("a_m_y_cyclist_01"); Veh_Ped_Hash.Add("0xfdc653c7");
            Veh_Ped_Name.Add("a_m_y_dhill_01"); Veh_Ped_Hash.Add("0xff3e88ab");
            Veh_Ped_Name.Add("a_m_y_downtown_01"); Veh_Ped_Hash.Add("0x2dadf4aa");
            Veh_Ped_Name.Add("a_m_y_eastsa_01"); Veh_Ped_Hash.Add("0xa4471173");
            Veh_Ped_Name.Add("a_m_y_eastsa_02"); Veh_Ped_Hash.Add("0x168775f6");
            Veh_Ped_Name.Add("a_m_y_epsilon_01"); Veh_Ped_Hash.Add("0x77d41a3e");
            Veh_Ped_Name.Add("a_m_y_epsilon_02"); Veh_Ped_Hash.Add("0xaa82ff9b");
            Veh_Ped_Name.Add("a_m_y_gay_01"); Veh_Ped_Hash.Add("0xd1cce036");
            Veh_Ped_Name.Add("a_m_y_gay_02"); Veh_Ped_Hash.Add("0xa5720781");
            Veh_Ped_Name.Add("a_m_y_gencaspat_01"); Veh_Ped_Hash.Add("0x9b047cdf");
            Veh_Ped_Name.Add("a_m_y_genstreet_01"); Veh_Ped_Hash.Add("0x9877ef71");
            Veh_Ped_Name.Add("a_m_y_genstreet_02"); Veh_Ped_Hash.Add("0x3521a8d2");
            Veh_Ped_Name.Add("a_m_y_golfer_01"); Veh_Ped_Hash.Add("0xd71fe131");
            Veh_Ped_Name.Add("a_m_y_hasjew_01"); Veh_Ped_Hash.Add("0xe16d8f01");
            Veh_Ped_Name.Add("a_m_y_hiker_01"); Veh_Ped_Hash.Add("0x50f73c0c");
            Veh_Ped_Name.Add("a_m_y_hippy_01"); Veh_Ped_Hash.Add("0x7d03e617");
            Veh_Ped_Name.Add("a_m_y_hipster_01"); Veh_Ped_Hash.Add("0x2307a353");
            Veh_Ped_Name.Add("a_m_y_hipster_02"); Veh_Ped_Hash.Add("0x14d506ee");
            Veh_Ped_Name.Add("a_m_y_hipster_03"); Veh_Ped_Hash.Add("0x4e4179c6");
            Veh_Ped_Name.Add("a_m_y_indian_01"); Veh_Ped_Hash.Add("0x2a22fbce");
            Veh_Ped_Name.Add("a_m_y_jetski_01"); Veh_Ped_Hash.Add("0x2db7eef3");
            Veh_Ped_Name.Add("a_m_y_juggalo_01"); Veh_Ped_Hash.Add("0x91ca3e2c");
            Veh_Ped_Name.Add("a_m_y_ktown_01"); Veh_Ped_Hash.Add("0x1af6542c");
            Veh_Ped_Name.Add("a_m_y_ktown_02"); Veh_Ped_Hash.Add("0x297ff13f");
            Veh_Ped_Name.Add("a_m_y_latino_01"); Veh_Ped_Hash.Add("0x132c1a8e");
            Veh_Ped_Name.Add("a_m_y_methhead_01"); Veh_Ped_Hash.Add("0x696be0a9");
            Veh_Ped_Name.Add("a_m_y_mexthug_01"); Veh_Ped_Hash.Add("0x3053e555");
            Veh_Ped_Name.Add("a_m_y_motox_01"); Veh_Ped_Hash.Add("0x64fdea7d");
            Veh_Ped_Name.Add("a_m_y_motox_02"); Veh_Ped_Hash.Add("0x77ac8fda");
            Veh_Ped_Name.Add("a_m_y_musclbeac_01"); Veh_Ped_Hash.Add("0x4b652906");
            Veh_Ped_Name.Add("a_m_y_musclbeac_02"); Veh_Ped_Hash.Add("0xc923247c");
            Veh_Ped_Name.Add("a_m_y_polynesian_01"); Veh_Ped_Hash.Add("0x8384fc9f");
            Veh_Ped_Name.Add("a_m_y_roadcyc_01"); Veh_Ped_Hash.Add("0xf561a4c6");
            Veh_Ped_Name.Add("a_m_y_runner_01"); Veh_Ped_Hash.Add("0x25305eee");
            Veh_Ped_Name.Add("a_m_y_runner_02"); Veh_Ped_Hash.Add("0x843d9d0f");
            Veh_Ped_Name.Add("a_m_y_salton_01"); Veh_Ped_Hash.Add("0xd7606c30");
            Veh_Ped_Name.Add("a_m_y_skater_01"); Veh_Ped_Hash.Add("0xc1c46677");
            Veh_Ped_Name.Add("a_m_y_skater_02"); Veh_Ped_Hash.Add("0xaffac2e4");
            Veh_Ped_Name.Add("a_m_y_smartcaspat_01"); Veh_Ped_Hash.Add("0x2102ba2a");
            Veh_Ped_Name.Add("a_m_y_soucent_01"); Veh_Ped_Hash.Add("0xe716bdcb");
            Veh_Ped_Name.Add("a_m_y_soucent_02"); Veh_Ped_Hash.Add("0xaca3c8ca");
            Veh_Ped_Name.Add("a_m_y_soucent_03"); Veh_Ped_Hash.Add("0xc3f0f764");
            Veh_Ped_Name.Add("a_m_y_soucent_04"); Veh_Ped_Hash.Add("0x8a3703f1");
            Veh_Ped_Name.Add("a_m_y_stbla_01"); Veh_Ped_Hash.Add("0xcf92ade9");
            Veh_Ped_Name.Add("a_m_y_stbla_02"); Veh_Ped_Hash.Add("0x98c7404f");
            Veh_Ped_Name.Add("a_m_y_stlat_01"); Veh_Ped_Hash.Add("0x8674d5fc");
            Veh_Ped_Name.Add("a_m_y_studioparty_01"); Veh_Ped_Hash.Add("0xb231229d");
            Veh_Ped_Name.Add("a_m_y_stwhi_01"); Veh_Ped_Hash.Add("0x2418c430");
            Veh_Ped_Name.Add("a_m_y_stwhi_02"); Veh_Ped_Hash.Add("0x36c6e98c");
            Veh_Ped_Name.Add("a_m_y_sunbathe_01"); Veh_Ped_Hash.Add("0xb7292f0c");
            Veh_Ped_Name.Add("a_m_y_surfer_01"); Veh_Ped_Hash.Add("0xeac2c7ee");
            Veh_Ped_Name.Add("a_m_y_tattoocust_01"); Veh_Ped_Hash.Add("0x9c1f1a19");
            Veh_Ped_Name.Add("a_m_y_vindouche_01"); Veh_Ped_Hash.Add("0xc19377e7");
            Veh_Ped_Name.Add("a_m_y_vinewood_01"); Veh_Ped_Hash.Add("0x4b64199d");
            Veh_Ped_Name.Add("a_m_y_vinewood_02"); Veh_Ped_Hash.Add("0x5d15bd00");
            Veh_Ped_Name.Add("a_m_y_vinewood_03"); Veh_Ped_Hash.Add("0x1fdf4294");
            Veh_Ped_Name.Add("a_m_y_vinewood_04"); Veh_Ped_Hash.Add("0x31c9e669");
            Veh_Ped_Name.Add("a_m_y_yoga_01"); Veh_Ped_Hash.Add("0xab0a7155");
            Veh_Ped_Name.Add("cs_amandatownley"); Veh_Ped_Hash.Add("0x95ef18e3");
            Veh_Ped_Name.Add("cs_andreas"); Veh_Ped_Hash.Add("0xe7565327");
            Veh_Ped_Name.Add("cs_ashley"); Veh_Ped_Hash.Add("0x26c3d079");
            Veh_Ped_Name.Add("cs_bankman"); Veh_Ped_Hash.Add("0x9760192e");
            Veh_Ped_Name.Add("cs_barry"); Veh_Ped_Hash.Add("0x69591cf7");
            Veh_Ped_Name.Add("cs_beverly"); Veh_Ped_Hash.Add("0xb46ec356");
            Veh_Ped_Name.Add("cs_brad"); Veh_Ped_Hash.Add("0xefe5afe6");
            Veh_Ped_Name.Add("cs_bradcadaver"); Veh_Ped_Hash.Add("0x7228af60");
            Veh_Ped_Name.Add("cs_carbuyer"); Veh_Ped_Hash.Add("0x8cce790f");
            Veh_Ped_Name.Add("cs_casey"); Veh_Ped_Hash.Add("0xea969c40");
            Veh_Ped_Name.Add("cs_chengsr"); Veh_Ped_Hash.Add("0x30db9d7b");
            Veh_Ped_Name.Add("cs_chrisformage"); Veh_Ped_Hash.Add("0xc1f380e6");
            Veh_Ped_Name.Add("cs_clay"); Veh_Ped_Hash.Add("0xdbcb9834");
            Veh_Ped_Name.Add("cs_dale"); Veh_Ped_Hash.Add("0xce81655");
            Veh_Ped_Name.Add("cs_davenorton"); Veh_Ped_Hash.Add("0x8587248c");
            Veh_Ped_Name.Add("cs_debra"); Veh_Ped_Hash.Add("0xecd04fe9");
            Veh_Ped_Name.Add("cs_denise"); Veh_Ped_Hash.Add("0x6f802738");
            Veh_Ped_Name.Add("cs_devin"); Veh_Ped_Hash.Add("0x2f016d02");
            Veh_Ped_Name.Add("cs_dom"); Veh_Ped_Hash.Add("0x4772af42");
            Veh_Ped_Name.Add("cs_dreyfuss"); Veh_Ped_Hash.Add("0x3c60a153");
            Veh_Ped_Name.Add("cs_drfriedlander"); Veh_Ped_Hash.Add("0xa3a35c2f");
            Veh_Ped_Name.Add("cs_fabien"); Veh_Ped_Hash.Add("0x47035ec1");
            Veh_Ped_Name.Add("cs_fbisuit_01"); Veh_Ped_Hash.Add("0x585c0b52");
            Veh_Ped_Name.Add("cs_floyd"); Veh_Ped_Hash.Add("0x62547e7");
            Veh_Ped_Name.Add("cs_guadalope"); Veh_Ped_Hash.Add("0xf9513f1");
            Veh_Ped_Name.Add("cs_gurk"); Veh_Ped_Hash.Add("0xc314f727");
            Veh_Ped_Name.Add("cs_hunter"); Veh_Ped_Hash.Add("0x5b44892c");
            Veh_Ped_Name.Add("cs_janet"); Veh_Ped_Hash.Add("0x3034f9e2");
            Veh_Ped_Name.Add("cs_jewelass"); Veh_Ped_Hash.Add("0x4440a804");
            Veh_Ped_Name.Add("cs_jimmyboston"); Veh_Ped_Hash.Add("0x39677bd");
            Veh_Ped_Name.Add("cs_jimmydisanto"); Veh_Ped_Hash.Add("0xb8cc92b4");
            Veh_Ped_Name.Add("cs_jimmydisanto2"); Veh_Ped_Hash.Add("0x6d6f811b");
            Veh_Ped_Name.Add("cs_joeminuteman"); Veh_Ped_Hash.Add("0xf09d5e29");
            Veh_Ped_Name.Add("cs_johnnyklebitz"); Veh_Ped_Hash.Add("0xfa8ab881");
            Veh_Ped_Name.Add("cs_josef"); Veh_Ped_Hash.Add("0x459762ca");
            Veh_Ped_Name.Add("cs_josh"); Veh_Ped_Hash.Add("0x450eef9d");
            Veh_Ped_Name.Add("cs_karen_daniels"); Veh_Ped_Hash.Add("0x4baf381c");
            Veh_Ped_Name.Add("cs_lamardavis"); Veh_Ped_Hash.Add("0x45463a0d");
            Veh_Ped_Name.Add("cs_lamardavis_02"); Veh_Ped_Hash.Add("0x1562e05");
            Veh_Ped_Name.Add("cs_lazlow"); Veh_Ped_Hash.Add("0x38951a1b");
            Veh_Ped_Name.Add("cs_lazlow_2"); Veh_Ped_Hash.Add("0x5f4c593d");
            Veh_Ped_Name.Add("cs_lestercrest"); Veh_Ped_Hash.Add("0xb594f5c3");
            Veh_Ped_Name.Add("cs_lestercrest_2"); Veh_Ped_Hash.Add("0xb63911d");
            Veh_Ped_Name.Add("cs_lestercrest_3"); Veh_Ped_Hash.Add("0x1d953580");
            Veh_Ped_Name.Add("cs_lifeinvad_01"); Veh_Ped_Hash.Add("0x72551375");
            Veh_Ped_Name.Add("cs_magenta"); Veh_Ped_Hash.Add("0x5816c61a");
            Veh_Ped_Name.Add("cs_manuel"); Veh_Ped_Hash.Add("0xfbb374ca");
            Veh_Ped_Name.Add("cs_marnie"); Veh_Ped_Hash.Add("0x574de134");
            Veh_Ped_Name.Add("cs_martinmadrazo"); Veh_Ped_Hash.Add("0x43595670");
            Veh_Ped_Name.Add("cs_maryann"); Veh_Ped_Hash.Add("0x998c7ad");
            Veh_Ped_Name.Add("cs_michelle"); Veh_Ped_Hash.Add("0x70aeb9c8");
            Veh_Ped_Name.Add("cs_milton"); Veh_Ped_Hash.Add("0xb76a330f");
            Veh_Ped_Name.Add("cs_molly"); Veh_Ped_Hash.Add("0x45918e44");
            Veh_Ped_Name.Add("cs_movpremf_01"); Veh_Ped_Hash.Add("0x4bba84d9");
            Veh_Ped_Name.Add("cs_movpremmale"); Veh_Ped_Hash.Add("0x8d67ee7d");
            Veh_Ped_Name.Add("cs_mrk"); Veh_Ped_Hash.Add("0xc3cc9a75");
            Veh_Ped_Name.Add("cs_mrs_thornhill"); Veh_Ped_Hash.Add("0x4f921e6e");
            Veh_Ped_Name.Add("cs_mrsphillips"); Veh_Ped_Hash.Add("0xcbfda3cf");
            Veh_Ped_Name.Add("cs_natalia"); Veh_Ped_Hash.Add("0x4efeb1f0");
            Veh_Ped_Name.Add("cs_nervousron"); Veh_Ped_Hash.Add("0x7896da94");
            Veh_Ped_Name.Add("cs_nigel"); Veh_Ped_Hash.Add("0xe1479c0b");
            Veh_Ped_Name.Add("cs_old_man1a"); Veh_Ped_Hash.Add("0x1eec7bdc");
            Veh_Ped_Name.Add("cs_old_man2"); Veh_Ped_Hash.Add("0x98f9e770");
            Veh_Ped_Name.Add("cs_omega"); Veh_Ped_Hash.Add("0x8b70b405");
            Veh_Ped_Name.Add("cs_orleans"); Veh_Ped_Hash.Add("0xad340f5a");
            Veh_Ped_Name.Add("cs_paper"); Veh_Ped_Hash.Add("0x6b38b8f8");
            Veh_Ped_Name.Add("cs_patricia"); Veh_Ped_Hash.Add("0xdf8b1301");
            Veh_Ped_Name.Add("cs_patricia_02"); Veh_Ped_Hash.Add("0x2efaa8c3");
            Veh_Ped_Name.Add("cs_priest"); Veh_Ped_Hash.Add("0x4d6de57e");
            Veh_Ped_Name.Add("cs_prolsec_02"); Veh_Ped_Hash.Add("0x1e9314a2");
            Veh_Ped_Name.Add("cs_russiandrunk"); Veh_Ped_Hash.Add("0x46521a32");
            Veh_Ped_Name.Add("cs_siemonyetarian"); Veh_Ped_Hash.Add("0xc0937202");
            Veh_Ped_Name.Add("cs_solomon"); Veh_Ped_Hash.Add("0xf6d1e04e");
            Veh_Ped_Name.Add("cs_stevehains"); Veh_Ped_Hash.Add("0xa4e0a1fe");
            Veh_Ped_Name.Add("cs_stretch"); Veh_Ped_Hash.Add("0x893d6805");
            Veh_Ped_Name.Add("cs_tanisha"); Veh_Ped_Hash.Add("0x42fe5370");
            Veh_Ped_Name.Add("cs_taocheng"); Veh_Ped_Hash.Add("0x8864083d");
            Veh_Ped_Name.Add("cs_taocheng2"); Veh_Ped_Hash.Add("0x26bebe36");
            Veh_Ped_Name.Add("cs_taostranslator"); Veh_Ped_Hash.Add("0x53536529");
            Veh_Ped_Name.Add("cs_taostranslator2"); Veh_Ped_Hash.Add("0xb3d82d2f");
            Veh_Ped_Name.Add("cs_tenniscoach"); Veh_Ped_Hash.Add("0x5c26040a");
            Veh_Ped_Name.Add("cs_terry"); Veh_Ped_Hash.Add("0x3a5201c5");
            Veh_Ped_Name.Add("cs_tom"); Veh_Ped_Hash.Add("0x69e8abc3");
            Veh_Ped_Name.Add("cs_tomepsilon"); Veh_Ped_Hash.Add("0x8c0fd4e2");
            Veh_Ped_Name.Add("cs_tracydisanto"); Veh_Ped_Hash.Add("0x609b130");
            Veh_Ped_Name.Add("cs_wade"); Veh_Ped_Hash.Add("0xd266d9d6");
            Veh_Ped_Name.Add("cs_zimbor"); Veh_Ped_Hash.Add("0xeaacaaf0");
            Veh_Ped_Name.Add("csb_abigail"); Veh_Ped_Hash.Add("0x89768941");
            Veh_Ped_Name.Add("csb_agatha"); Veh_Ped_Hash.Add("0x2d145a18");
            Veh_Ped_Name.Add("csb_agent"); Veh_Ped_Hash.Add("0xd770c9b4");
            Veh_Ped_Name.Add("csb_alan"); Veh_Ped_Hash.Add("0x72cab667");
            Veh_Ped_Name.Add("csb_anita"); Veh_Ped_Hash.Add("0x703f106");
            Veh_Ped_Name.Add("csb_anton"); Veh_Ped_Hash.Add("0xa5c787b6");
            Veh_Ped_Name.Add("csb_ary"); Veh_Ped_Hash.Add("0xb65c594e");
            Veh_Ped_Name.Add("csb_ary_02"); Veh_Ped_Hash.Add("0xea177cdd");
            Veh_Ped_Name.Add("csb_avery"); Veh_Ped_Hash.Add("0x551cc92d");
            Veh_Ped_Name.Add("csb_avischwartzman_02"); Veh_Ped_Hash.Add("0x89fefce0");
            Veh_Ped_Name.Add("csb_avon"); Veh_Ped_Hash.Add("0x1833364d");
            Veh_Ped_Name.Add("csb_ballas_leader"); Veh_Ped_Hash.Add("0xb8a90e13");
            Veh_Ped_Name.Add("csb_ballasog"); Veh_Ped_Hash.Add("0xabef0004");
            Veh_Ped_Name.Add("csb_billionaire"); Veh_Ped_Hash.Add("0xca846157");
            Veh_Ped_Name.Add("csb_bogdan"); Veh_Ped_Hash.Add("0x5f06d73d");
            Veh_Ped_Name.Add("csb_bride"); Veh_Ped_Hash.Add("0x82bf7ea1");
            Veh_Ped_Name.Add("csb_brucie2"); Veh_Ped_Hash.Add("0xc860ae15");
            Veh_Ped_Name.Add("csb_bryony"); Veh_Ped_Hash.Add("0x7791addd");
            Veh_Ped_Name.Add("csb_burgerdrug"); Veh_Ped_Hash.Add("0x8cdcc057");
            Veh_Ped_Name.Add("csb_car3guy1"); Veh_Ped_Hash.Add("0x4430687");
            Veh_Ped_Name.Add("csb_car3guy2"); Veh_Ped_Hash.Add("0x1383a508");
            Veh_Ped_Name.Add("csb_celeb_01"); Veh_Ped_Hash.Add("0x234ca435");
            Veh_Ped_Name.Add("csb_chef"); Veh_Ped_Hash.Add("0xa347ca8a");
            Veh_Ped_Name.Add("csb_chef2"); Veh_Ped_Hash.Add("0xae5be23a");
            Veh_Ped_Name.Add("csb_chin_goon"); Veh_Ped_Hash.Add("0xa8c22996");
            Veh_Ped_Name.Add("csb_cletus"); Veh_Ped_Hash.Add("0xcae9e5d5");
            Veh_Ped_Name.Add("csb_cop"); Veh_Ped_Hash.Add("0x9ab35f63");
            Veh_Ped_Name.Add("csb_customer"); Veh_Ped_Hash.Add("0xa44f6f8b");
            Veh_Ped_Name.Add("csb_denise_friend"); Veh_Ped_Hash.Add("0xb58d2529");
            Veh_Ped_Name.Add("csb_dix"); Veh_Ped_Hash.Add("0xebe02d05");
            Veh_Ped_Name.Add("csb_djblamadon"); Veh_Ped_Hash.Add("0x6d65f972");
            Veh_Ped_Name.Add("csb_drugdealer"); Veh_Ped_Hash.Add("0x389258fe");
            Veh_Ped_Name.Add("csb_englishdave"); Veh_Ped_Hash.Add("0xd298823e");
            Veh_Ped_Name.Add("csb_englishdave_02"); Veh_Ped_Hash.Add("0xdd59656f");
            Veh_Ped_Name.Add("csb_fos_rep"); Veh_Ped_Hash.Add("0x1bcc157b");
            Veh_Ped_Name.Add("csb_g"); Veh_Ped_Hash.Add("0xa28e71d7");
            Veh_Ped_Name.Add("csb_georginacheng"); Veh_Ped_Hash.Add("0x1491eabb");
            Veh_Ped_Name.Add("csb_golfer_a"); Veh_Ped_Hash.Add("0x7e5f1188");
            Veh_Ped_Name.Add("csb_golfer_b"); Veh_Ped_Hash.Add("0xdcedcea4");
            Veh_Ped_Name.Add("csb_groom"); Veh_Ped_Hash.Add("0x7aab19d2");
            Veh_Ped_Name.Add("csb_grove_str_dlr"); Veh_Ped_Hash.Add("0xe8594e22");
            Veh_Ped_Name.Add("csb_gustavo"); Veh_Ped_Hash.Add("0x8af43d22");
            Veh_Ped_Name.Add("csb_hao"); Veh_Ped_Hash.Add("0xec9e8f1c");
            Veh_Ped_Name.Add("csb_hao_02"); Veh_Ped_Hash.Add("0xbf71ef93");
            Veh_Ped_Name.Add("csb_helmsmanpavel"); Veh_Ped_Hash.Add("0x9f7e81f8");
            Veh_Ped_Name.Add("csb_huang"); Veh_Ped_Hash.Add("0x3f6e6283");
            Veh_Ped_Name.Add("csb_hugh"); Veh_Ped_Hash.Add("0x6f139b54");
            Veh_Ped_Name.Add("csb_imani"); Veh_Ped_Hash.Add("0x7671a8f6");
            Veh_Ped_Name.Add("csb_imran"); Veh_Ped_Hash.Add("0xe3420bdb");
            Veh_Ped_Name.Add("csb_isldj_00"); Veh_Ped_Hash.Add("0x7a5ee1a5");
            Veh_Ped_Name.Add("csb_isldj_01"); Veh_Ped_Hash.Add("0x34dfd6a4");
            Veh_Ped_Name.Add("csb_isldj_02"); Veh_Ped_Hash.Add("0x66143910");
            Veh_Ped_Name.Add("csb_isldj_03"); Veh_Ped_Hash.Add("0x917b0fdd");
            Veh_Ped_Name.Add("csb_isldj_04"); Veh_Ped_Hash.Add("0xb2bc525f");
            Veh_Ped_Name.Add("csb_jackhowitzer"); Veh_Ped_Hash.Add("0x44bc7bb1");
            Veh_Ped_Name.Add("csb_janitor"); Veh_Ped_Hash.Add("0xc2005a40");
            Veh_Ped_Name.Add("csb_jio"); Veh_Ped_Hash.Add("0xa28b9e2d");
            Veh_Ped_Name.Add("csb_jio_02"); Veh_Ped_Hash.Add("0xdcb110b0");
            Veh_Ped_Name.Add("csb_johnny_guns"); Veh_Ped_Hash.Add("0x7da9c6a1");
            Veh_Ped_Name.Add("csb_juanstrickler"); Veh_Ped_Hash.Add("0xd74b8139");
            Veh_Ped_Name.Add("csb_maude"); Veh_Ped_Hash.Add("0xbcc475cb");
            Veh_Ped_Name.Add("csb_miguelmadrazo"); Veh_Ped_Hash.Add("0xdbb17082");
            Veh_Ped_Name.Add("csb_mimi"); Veh_Ped_Hash.Add("0x86c1ffe8");
            Veh_Ped_Name.Add("csb_mjo"); Veh_Ped_Hash.Add("0xa0fda755");
            Veh_Ped_Name.Add("csb_mjo_02"); Veh_Ped_Hash.Add("0x98f3fa18");
            Veh_Ped_Name.Add("csb_money"); Veh_Ped_Hash.Add("0x989dfd9a");
            Veh_Ped_Name.Add("csb_moodyman_02"); Veh_Ped_Hash.Add("0x8d7ee5a4");
            Veh_Ped_Name.Add("csb_mp_agent14"); Veh_Ped_Hash.Add("0x6dbbfc8b");
            Veh_Ped_Name.Add("csb_mrs_r"); Veh_Ped_Hash.Add("0x9d79c026");
            Veh_Ped_Name.Add("csb_musician_00"); Veh_Ped_Hash.Add("0xc7bc9e2c");
            Veh_Ped_Name.Add("csb_mweather"); Veh_Ped_Hash.Add("0x613e626c");
            Veh_Ped_Name.Add("csb_ortega"); Veh_Ped_Hash.Add("0xc0db04cf");
            Veh_Ped_Name.Add("csb_oscar"); Veh_Ped_Hash.Add("0xf41f399b");
            Veh_Ped_Name.Add("csb_paige"); Veh_Ped_Hash.Add("0x5b1fa0c3");
            Veh_Ped_Name.Add("csb_party_promo"); Veh_Ped_Hash.Add("0x98d8449f");
            Veh_Ped_Name.Add("csb_popov"); Veh_Ped_Hash.Add("0x617d89e2");
            Veh_Ped_Name.Add("csb_porndudes"); Veh_Ped_Hash.Add("0x2f4afe35");
            Veh_Ped_Name.Add("csb_prologuedriver"); Veh_Ped_Hash.Add("0xf00b49db");
            Veh_Ped_Name.Add("csb_prolsec"); Veh_Ped_Hash.Add("0x7fa2f024");
            Veh_Ped_Name.Add("csb_ramp_gang"); Veh_Ped_Hash.Add("0xc2800dbe");
            Veh_Ped_Name.Add("csb_ramp_hic"); Veh_Ped_Hash.Add("0x858c94b8");
            Veh_Ped_Name.Add("csb_ramp_hipster"); Veh_Ped_Hash.Add("0x21f58bb4");
            Veh_Ped_Name.Add("csb_ramp_marine"); Veh_Ped_Hash.Add("0x616c97b9");
            Veh_Ped_Name.Add("csb_ramp_mex"); Veh_Ped_Hash.Add("0xf64ed7d0");
            Veh_Ped_Name.Add("csb_rashcosvki"); Veh_Ped_Hash.Add("0x188099a9");
            Veh_Ped_Name.Add("csb_reporter"); Veh_Ped_Hash.Add("0x2e420a24");
            Veh_Ped_Name.Add("csb_req_officer"); Veh_Ped_Hash.Add("0x88f76b3a");
            Veh_Ped_Name.Add("csb_roccopelosi"); Veh_Ped_Hash.Add("0xaa64168c");
            Veh_Ped_Name.Add("csb_screen_writer"); Veh_Ped_Hash.Add("0x8be12cec");
            Veh_Ped_Name.Add("csb_security_a"); Veh_Ped_Hash.Add("0x2bc9001c");
            Veh_Ped_Name.Add("csb_sessanta"); Veh_Ped_Hash.Add("0xd3bac7e0");
            Veh_Ped_Name.Add("csb_sol"); Veh_Ped_Hash.Add("0x4ef92b55");
            Veh_Ped_Name.Add("csb_soundeng_00"); Veh_Ped_Hash.Add("0x20606d6c");
            Veh_Ped_Name.Add("csb_sss"); Veh_Ped_Hash.Add("0xe0dbdc60");
            Veh_Ped_Name.Add("csb_stripper_01"); Veh_Ped_Hash.Add("0xaeea76b5");
            Veh_Ped_Name.Add("csb_stripper_02"); Veh_Ped_Hash.Add("0x81441b71");
            Veh_Ped_Name.Add("csb_talcc"); Veh_Ped_Hash.Add("0xca300478");
            Veh_Ped_Name.Add("csb_talmm"); Veh_Ped_Hash.Add("0xe1a0bfed");
            Veh_Ped_Name.Add("csb_thornton"); Veh_Ped_Hash.Add("0xf398da51");
            Veh_Ped_Name.Add("csb_tomcasino"); Veh_Ped_Hash.Add("0xcff0d4bb");
            Veh_Ped_Name.Add("csb_tonya"); Veh_Ped_Hash.Add("0x6343dd19");
            Veh_Ped_Name.Add("csb_tonyprince"); Veh_Ped_Hash.Add("0x5d5f971b");
            Veh_Ped_Name.Add("csb_trafficwarden"); Veh_Ped_Hash.Add("0xde2937f3");
            Veh_Ped_Name.Add("csb_undercover"); Veh_Ped_Hash.Add("0xef785a6a");
            Veh_Ped_Name.Add("csb_vagos_leader"); Veh_Ped_Hash.Add("0x8332ebe5");
            Veh_Ped_Name.Add("csb_vagspeak"); Veh_Ped_Hash.Add("0x48ff4ca9");
            Veh_Ped_Name.Add("csb_vernon"); Veh_Ped_Hash.Add("0xbd7713c6");
            Veh_Ped_Name.Add("csb_vincent"); Veh_Ped_Hash.Add("0x1f0846a7");
            Veh_Ped_Name.Add("csb_vincent_2"); Veh_Ped_Hash.Add("0xa5e08e20");
            Veh_Ped_Name.Add("csb_wendy"); Veh_Ped_Hash.Add("0x55a789af");
            Veh_Ped_Name.Add("g_f_importexport_01"); Veh_Ped_Hash.Add("0x84a1b11a");
            Veh_Ped_Name.Add("g_f_y_ballas_01"); Veh_Ped_Hash.Add("0x158c439c");
            Veh_Ped_Name.Add("g_f_y_families_01"); Veh_Ped_Hash.Add("0x4e0ce5d3");
            Veh_Ped_Name.Add("g_f_y_lost_01"); Veh_Ped_Hash.Add("0xfd5537de");
            Veh_Ped_Name.Add("g_f_y_vagos_01"); Veh_Ped_Hash.Add("0x5aa42c21");
            Veh_Ped_Name.Add("g_m_importexport_01"); Veh_Ped_Hash.Add("0xbca2ccea");
            Veh_Ped_Name.Add("g_m_m_armboss_01"); Veh_Ped_Hash.Add("0xf1e823a2");
            Veh_Ped_Name.Add("g_m_m_armgoon_01"); Veh_Ped_Hash.Add("0xfda94268");
            Veh_Ped_Name.Add("g_m_m_armlieut_01"); Veh_Ped_Hash.Add("0xe7714013");
            Veh_Ped_Name.Add("g_m_m_cartelguards_01"); Veh_Ped_Hash.Add("0x7ed5ad78");
            Veh_Ped_Name.Add("g_m_m_cartelguards_02"); Veh_Ped_Hash.Add("0x6c8c08e5");
            Veh_Ped_Name.Add("g_m_m_casrn_01"); Veh_Ped_Hash.Add("0x3cd28cb3");
            Veh_Ped_Name.Add("g_m_m_chemwork_01"); Veh_Ped_Hash.Add("0xf6157d8f");
            Veh_Ped_Name.Add("g_m_m_chiboss_01"); Veh_Ped_Hash.Add("0xb9dd0300");
            Veh_Ped_Name.Add("g_m_m_chicold_01"); Veh_Ped_Hash.Add("0x106d9a99");
            Veh_Ped_Name.Add("g_m_m_chigoon_01"); Veh_Ped_Hash.Add("0x7e4f763f");
            Veh_Ped_Name.Add("g_m_m_chigoon_02"); Veh_Ped_Hash.Add("0xff71f826");
            Veh_Ped_Name.Add("g_m_m_goons_01"); Veh_Ped_Hash.Add("0x61ecd362");
            Veh_Ped_Name.Add("g_m_m_korboss_01"); Veh_Ped_Hash.Add("0x352a026f");
            Veh_Ped_Name.Add("g_m_m_mexboss_01"); Veh_Ped_Hash.Add("0x5761f4ad");
            Veh_Ped_Name.Add("g_m_m_mexboss_02"); Veh_Ped_Hash.Add("0x4914d813");
            Veh_Ped_Name.Add("g_m_m_prisoners_01"); Veh_Ped_Hash.Add("0x21b4080f");
            Veh_Ped_Name.Add("g_m_m_slasher_01"); Veh_Ped_Hash.Add("0x277e179c");
            Veh_Ped_Name.Add("g_m_y_armgoon_02"); Veh_Ped_Hash.Add("0xc54e878a");
            Veh_Ped_Name.Add("g_m_y_azteca_01"); Veh_Ped_Hash.Add("0x68709618");
            Veh_Ped_Name.Add("g_m_y_ballaeast_01"); Veh_Ped_Hash.Add("0xf42ee883");
            Veh_Ped_Name.Add("g_m_y_ballaorig_01"); Veh_Ped_Hash.Add("0x231af63f");
            Veh_Ped_Name.Add("g_m_y_ballasout_01"); Veh_Ped_Hash.Add("0x23b88069");
            Veh_Ped_Name.Add("g_m_y_famca_01"); Veh_Ped_Hash.Add("0xe83b93b7");
            Veh_Ped_Name.Add("g_m_y_famdnf_01"); Veh_Ped_Hash.Add("0xdb729238");
            Veh_Ped_Name.Add("g_m_y_famfor_01"); Veh_Ped_Hash.Add("0x84302b09");
            Veh_Ped_Name.Add("g_m_y_korean_01"); Veh_Ped_Hash.Add("0x247502a9");
            Veh_Ped_Name.Add("g_m_y_korean_02"); Veh_Ped_Hash.Add("0x8fedd989");
            Veh_Ped_Name.Add("g_m_y_korlieut_01"); Veh_Ped_Hash.Add("0x7ccbe17a");
            Veh_Ped_Name.Add("g_m_y_lost_01"); Veh_Ped_Hash.Add("0x4f46d607");
            Veh_Ped_Name.Add("g_m_y_lost_02"); Veh_Ped_Hash.Add("0x3d843282");
            Veh_Ped_Name.Add("g_m_y_lost_03"); Veh_Ped_Hash.Add("0x32b11cdc");
            Veh_Ped_Name.Add("g_m_y_mexgang_01"); Veh_Ped_Hash.Add("0xbddd5546");
            Veh_Ped_Name.Add("g_m_y_mexgoon_01"); Veh_Ped_Hash.Add("0x26ef3426");
            Veh_Ped_Name.Add("g_m_y_mexgoon_02"); Veh_Ped_Hash.Add("0x31a3498e");
            Veh_Ped_Name.Add("g_m_y_mexgoon_03"); Veh_Ped_Hash.Add("0x964d12dc");
            Veh_Ped_Name.Add("g_m_y_pologoon_01"); Veh_Ped_Hash.Add("0x4f3fba06");
            Veh_Ped_Name.Add("g_m_y_pologoon_02"); Veh_Ped_Hash.Add("0xa2e86156");
            Veh_Ped_Name.Add("g_m_y_salvaboss_01"); Veh_Ped_Hash.Add("0x905ce0ca");
            Veh_Ped_Name.Add("g_m_y_salvagoon_01"); Veh_Ped_Hash.Add("0x278c8cb7");
            Veh_Ped_Name.Add("g_m_y_salvagoon_02"); Veh_Ped_Hash.Add("0x3273a285");
            Veh_Ped_Name.Add("g_m_y_salvagoon_03"); Veh_Ped_Hash.Add("0x3b8c510");
            Veh_Ped_Name.Add("g_m_y_strpunk_01"); Veh_Ped_Hash.Add("0xfd1c49bb");
            Veh_Ped_Name.Add("g_m_y_strpunk_02"); Veh_Ped_Hash.Add("0xda1eac6");
            Veh_Ped_Name.Add("hc_driver"); Veh_Ped_Hash.Add("0x3b474adf");
            Veh_Ped_Name.Add("hc_gunman"); Veh_Ped_Hash.Add("0xb881aee");
            Veh_Ped_Name.Add("hc_hacker"); Veh_Ped_Hash.Add("0x99bb00f8");
            Veh_Ped_Name.Add("ig_abigail"); Veh_Ped_Hash.Add("0x400aec41");
            Veh_Ped_Name.Add("ig_agatha"); Veh_Ped_Hash.Add("0x6e99bfc8");
            Veh_Ped_Name.Add("ig_agent"); Veh_Ped_Hash.Add("0x246af208");
            Veh_Ped_Name.Add("ig_amandatownley"); Veh_Ped_Hash.Add("0x6d1e15f7");
            Veh_Ped_Name.Add("ig_andreas"); Veh_Ped_Hash.Add("0x47e4eea0");
            Veh_Ped_Name.Add("ig_ary"); Veh_Ped_Hash.Add("0xcf0c7037");
            Veh_Ped_Name.Add("ig_ary_02"); Veh_Ped_Hash.Add("0x879f366f");
            Veh_Ped_Name.Add("ig_ashley"); Veh_Ped_Hash.Add("0x7ef440db");
            Veh_Ped_Name.Add("ig_avery"); Veh_Ped_Hash.Add("0xb8133f6f");
            Veh_Ped_Name.Add("ig_avischwartzman_02"); Veh_Ped_Hash.Add("0xdea6e105");
            Veh_Ped_Name.Add("ig_avon"); Veh_Ped_Hash.Add("0xfce270c2");
            Veh_Ped_Name.Add("ig_ballas_leader"); Veh_Ped_Hash.Add("0xdb41b4ef");
            Veh_Ped_Name.Add("ig_ballasog"); Veh_Ped_Hash.Add("0xa70b4a92");
            Veh_Ped_Name.Add("ig_bankman"); Veh_Ped_Hash.Add("0x909d9e7f");
            Veh_Ped_Name.Add("ig_barry"); Veh_Ped_Hash.Add("0x2f8845a3");
            Veh_Ped_Name.Add("ig_benny"); Veh_Ped_Hash.Add("0xc4b715d2");
            Veh_Ped_Name.Add("ig_benny_02"); Veh_Ped_Hash.Add("0x73d1907b");
            Veh_Ped_Name.Add("ig_bestmen"); Veh_Ped_Hash.Add("0x5746cd96");
            Veh_Ped_Name.Add("ig_beverly"); Veh_Ped_Hash.Add("0xbda21e5c");
            Veh_Ped_Name.Add("ig_billionaire"); Veh_Ped_Hash.Add("0x1ad5181");
            Veh_Ped_Name.Add("ig_brad"); Veh_Ped_Hash.Add("0xbdbb4922");
            Veh_Ped_Name.Add("ig_bride"); Veh_Ped_Hash.Add("0x6162ec47");
            Veh_Ped_Name.Add("ig_brucie2"); Veh_Ped_Hash.Add("0xe80e9160");
            Veh_Ped_Name.Add("ig_car3guy1"); Veh_Ped_Hash.Add("0x84f9e937");
            Veh_Ped_Name.Add("ig_car3guy2"); Veh_Ped_Hash.Add("0x75c34aca");
            Veh_Ped_Name.Add("ig_casey"); Veh_Ped_Hash.Add("0xe0fa2554");
            Veh_Ped_Name.Add("ig_celeb_01"); Veh_Ped_Hash.Add("0xdb1cf044");
            Veh_Ped_Name.Add("ig_chef"); Veh_Ped_Hash.Add("0x49eadbf6");
            Veh_Ped_Name.Add("ig_chef2"); Veh_Ped_Hash.Add("0x85889ac3");
            Veh_Ped_Name.Add("ig_chengsr"); Veh_Ped_Hash.Add("0xaae4ea7b");
            Veh_Ped_Name.Add("ig_chrisformage"); Veh_Ped_Hash.Add("0x286e54a7");
            Veh_Ped_Name.Add("ig_clay"); Veh_Ped_Hash.Add("0x6ccfe08a");
            Veh_Ped_Name.Add("ig_claypain"); Veh_Ped_Hash.Add("0x9d0087a8");
            Veh_Ped_Name.Add("ig_cletus"); Veh_Ped_Hash.Add("0xe6631195");
            Veh_Ped_Name.Add("ig_dale"); Veh_Ped_Hash.Add("0x467415e9");
            Veh_Ped_Name.Add("ig_davenorton"); Veh_Ped_Hash.Add("0x15cd4c33");
            Veh_Ped_Name.Add("ig_denise"); Veh_Ped_Hash.Add("0x820b33bd");
            Veh_Ped_Name.Add("ig_devin"); Veh_Ped_Hash.Add("0x7461a0b0");
            Veh_Ped_Name.Add("ig_dix"); Veh_Ped_Hash.Add("0xfad0f28d");
            Veh_Ped_Name.Add("ig_djblamadon"); Veh_Ped_Hash.Add("0xfb7c0c65");
            Veh_Ped_Name.Add("ig_djblamrupert"); Veh_Ped_Hash.Add("0x367ba706");
            Veh_Ped_Name.Add("ig_djblamryanh"); Veh_Ped_Hash.Add("0x17df1373");
            Veh_Ped_Name.Add("ig_djblamryans"); Veh_Ped_Hash.Add("0xb642503f");
            Veh_Ped_Name.Add("ig_djdixmanager"); Veh_Ped_Hash.Add("0xfb9cf1be");
            Veh_Ped_Name.Add("ig_djgeneric_01"); Veh_Ped_Hash.Add("0x99d4a44d");
            Veh_Ped_Name.Add("ig_djsolfotios"); Veh_Ped_Hash.Add("0x49fec1f9");
            Veh_Ped_Name.Add("ig_djsoljakob"); Veh_Ped_Hash.Add("0x9431f54b");
            Veh_Ped_Name.Add("ig_djsolmanager"); Veh_Ped_Hash.Add("0x7e924255");
            Veh_Ped_Name.Add("ig_djsolmike"); Veh_Ped_Hash.Add("0x2f6a53fa");
            Veh_Ped_Name.Add("ig_djsolrobt"); Veh_Ped_Hash.Add("0x47386c04");
            Veh_Ped_Name.Add("ig_djtalaurelia"); Veh_Ped_Hash.Add("0xb12c0a74");
            Veh_Ped_Name.Add("ig_djtalignazio"); Veh_Ped_Hash.Add("0xa62549c9");
            Veh_Ped_Name.Add("ig_dom"); Veh_Ped_Hash.Add("0x9c2db088");
            Veh_Ped_Name.Add("ig_dreyfuss"); Veh_Ped_Hash.Add("0xda890932");
            Veh_Ped_Name.Add("ig_drfriedlander"); Veh_Ped_Hash.Add("0xcbfc0df5");
            Veh_Ped_Name.Add("ig_drugdealer"); Veh_Ped_Hash.Add("0x1f0ca79d");
            Veh_Ped_Name.Add("ig_englishdave"); Veh_Ped_Hash.Add("0xc3ceb0c");
            Veh_Ped_Name.Add("ig_englishdave_02"); Veh_Ped_Hash.Add("0x35ffa54a");
            Veh_Ped_Name.Add("ig_entourage_a"); Veh_Ped_Hash.Add("0x19f5ced2");
            Veh_Ped_Name.Add("ig_entourage_b"); Veh_Ped_Hash.Add("0xc866abb5");
            Veh_Ped_Name.Add("ig_fabien"); Veh_Ped_Hash.Add("0xd090c350");
            Veh_Ped_Name.Add("ig_fbisuit_01"); Veh_Ped_Hash.Add("0x3ae4a33b");
            Veh_Ped_Name.Add("ig_floyd"); Veh_Ped_Hash.Add("0xb1b196b2");
            Veh_Ped_Name.Add("ig_g"); Veh_Ped_Hash.Add("0x841ba933");
            Veh_Ped_Name.Add("ig_georginacheng"); Veh_Ped_Hash.Add("0xef4bab2f");
            Veh_Ped_Name.Add("ig_golfer_a"); Veh_Ped_Hash.Add("0x3f9b1a4d");
            Veh_Ped_Name.Add("ig_golfer_b"); Veh_Ped_Hash.Add("0x6ecc78af");
            Veh_Ped_Name.Add("ig_groom"); Veh_Ped_Hash.Add("0xfece8b85");
            Veh_Ped_Name.Add("ig_gustavo"); Veh_Ped_Hash.Add("0xb585b217");
            Veh_Ped_Name.Add("ig_hao"); Veh_Ped_Hash.Add("0x65978363");
            Veh_Ped_Name.Add("ig_hao_02"); Veh_Ped_Hash.Add("0xf0837160");
            Veh_Ped_Name.Add("ig_helmsmanpavel"); Veh_Ped_Hash.Add("0xd7c1e2b1");
            Veh_Ped_Name.Add("ig_huang"); Veh_Ped_Hash.Add("0xbfd2a133");
            Veh_Ped_Name.Add("ig_hunter"); Veh_Ped_Hash.Add("0xce1324de");
            Veh_Ped_Name.Add("ig_imani"); Veh_Ped_Hash.Add("0x2e0a4f4a");
            Veh_Ped_Name.Add("ig_isldj_00"); Veh_Ped_Hash.Add("0xe2a32e68");
            Veh_Ped_Name.Add("ig_isldj_01"); Veh_Ped_Hash.Add("0x6f4747ce");
            Veh_Ped_Name.Add("ig_isldj_02"); Veh_Ped_Hash.Add("0x5d1da37b");
            Veh_Ped_Name.Add("ig_isldj_03"); Veh_Ped_Hash.Add("0x13360fa9");
            Veh_Ped_Name.Add("ig_isldj_04"); Veh_Ped_Hash.Add("0x806e6a1c");
            Veh_Ped_Name.Add("ig_isldj_04_d_01"); Veh_Ped_Hash.Add("0xb193bd6a");
            Veh_Ped_Name.Add("ig_isldj_04_d_02"); Veh_Ped_Hash.Add("0xfdf6562e");
            Veh_Ped_Name.Add("ig_isldj_04_e_01"); Veh_Ped_Hash.Add("0x232d795d");
            Veh_Ped_Name.Add("ig_jackie"); Veh_Ped_Hash.Add("0x799e61f6");
            Veh_Ped_Name.Add("ig_janet"); Veh_Ped_Hash.Add("0xd6d9c49");
            Veh_Ped_Name.Add("ig_jay_norris"); Veh_Ped_Hash.Add("0x7a32ee74");
            Veh_Ped_Name.Add("ig_jewelass"); Veh_Ped_Hash.Add("0xf5d26bb");
            Veh_Ped_Name.Add("ig_jimmyboston"); Veh_Ped_Hash.Add("0xeda0082d");
            Veh_Ped_Name.Add("ig_jimmyboston_02"); Veh_Ped_Hash.Add("0x43b59f1c");
            Veh_Ped_Name.Add("ig_jimmydisanto"); Veh_Ped_Hash.Add("0x570462b9");
            Veh_Ped_Name.Add("ig_jimmydisanto2"); Veh_Ped_Hash.Add("0x842dc2d6");
            Veh_Ped_Name.Add("ig_jio"); Veh_Ped_Hash.Add("0x73775f3f");
            Veh_Ped_Name.Add("ig_jio_02"); Veh_Ped_Hash.Add("0xd047ee3e");
            Veh_Ped_Name.Add("ig_joeminuteman"); Veh_Ped_Hash.Add("0xbe204c9b");
            Veh_Ped_Name.Add("ig_johnny_guns"); Veh_Ped_Hash.Add("0x27474ffa");
            Veh_Ped_Name.Add("ig_johnnyklebitz"); Veh_Ped_Hash.Add("0x87ca80ae");
            Veh_Ped_Name.Add("ig_josef"); Veh_Ped_Hash.Add("0xe11a9fb4");
            Veh_Ped_Name.Add("ig_josh"); Veh_Ped_Hash.Add("0x799e9eee");
            Veh_Ped_Name.Add("ig_juanstrickler"); Veh_Ped_Hash.Add("0x1e3e327d");
            Veh_Ped_Name.Add("ig_karen_daniels"); Veh_Ped_Hash.Add("0xeb51d959");
            Veh_Ped_Name.Add("ig_kaylee"); Veh_Ped_Hash.Add("0xa7810923");
            Veh_Ped_Name.Add("ig_kerrymcintosh"); Veh_Ped_Hash.Add("0x5b3bd90d");
            Veh_Ped_Name.Add("ig_kerrymcintosh_02"); Veh_Ped_Hash.Add("0xd842be92");
            Veh_Ped_Name.Add("ig_lacey_jones_02"); Veh_Ped_Hash.Add("0xcc36beec");
            Veh_Ped_Name.Add("ig_lamardavis"); Veh_Ped_Hash.Add("0x65b93076");
            Veh_Ped_Name.Add("ig_lamardavis_02"); Veh_Ped_Hash.Add("0x1924a05e");
            Veh_Ped_Name.Add("ig_lazlow"); Veh_Ped_Hash.Add("0xdfe443e5");
            Veh_Ped_Name.Add("ig_lazlow_2"); Veh_Ped_Hash.Add("0x850446ec");
            Veh_Ped_Name.Add("ig_lestercrest"); Veh_Ped_Hash.Add("0x4da6e849");
            Veh_Ped_Name.Add("ig_lestercrest_2"); Veh_Ped_Hash.Add("0x6e42fd26");
            Veh_Ped_Name.Add("ig_lestercrest_3"); Veh_Ped_Hash.Add("0x77fe10a4");
            Veh_Ped_Name.Add("ig_lifeinvad_01"); Veh_Ped_Hash.Add("0x5389a93c");
            Veh_Ped_Name.Add("ig_lifeinvad_02"); Veh_Ped_Hash.Add("0x27bd51d4");
            Veh_Ped_Name.Add("ig_lildee"); Veh_Ped_Hash.Add("0xc80df962");
            Veh_Ped_Name.Add("ig_magenta"); Veh_Ped_Hash.Add("0xfcdc910a");
            Veh_Ped_Name.Add("ig_malc"); Veh_Ped_Hash.Add("0xf1bca919");
            Veh_Ped_Name.Add("ig_manuel"); Veh_Ped_Hash.Add("0xfd418e10");
            Veh_Ped_Name.Add("ig_marnie"); Veh_Ped_Hash.Add("0x188232d0");
            Veh_Ped_Name.Add("ig_maryann"); Veh_Ped_Hash.Add("0xa36f9806");
            Veh_Ped_Name.Add("ig_maude"); Veh_Ped_Hash.Add("0x3be8287e");
            Veh_Ped_Name.Add("ig_michelle"); Veh_Ped_Hash.Add("0xbf9672f4");
            Veh_Ped_Name.Add("ig_miguelmadrazo"); Veh_Ped_Hash.Add("0xa5cd7cd8");
            Veh_Ped_Name.Add("ig_milton"); Veh_Ped_Hash.Add("0xcb3059b2");
            Veh_Ped_Name.Add("ig_mimi"); Veh_Ped_Hash.Add("0x784f9c95");
            Veh_Ped_Name.Add("ig_mjo"); Veh_Ped_Hash.Add("0x2d5db362");
            Veh_Ped_Name.Add("ig_mjo_02"); Veh_Ped_Hash.Add("0x38c749c4");
            Veh_Ped_Name.Add("ig_molly"); Veh_Ped_Hash.Add("0xaf03dde1");
            Veh_Ped_Name.Add("ig_money"); Veh_Ped_Hash.Add("0x37facda6");
            Veh_Ped_Name.Add("ig_moodyman_02"); Veh_Ped_Hash.Add("0x97d144b3");
            Veh_Ped_Name.Add("ig_mp_agent14"); Veh_Ped_Hash.Add("0xfbf98469");
            Veh_Ped_Name.Add("ig_mrk"); Veh_Ped_Hash.Add("0xeddcab6d");
            Veh_Ped_Name.Add("ig_mrs_thornhill"); Veh_Ped_Hash.Add("0x1e04a96b");
            Veh_Ped_Name.Add("ig_mrsphillips"); Veh_Ped_Hash.Add("0x3862eea8");
            Veh_Ped_Name.Add("ig_musician_00"); Veh_Ped_Hash.Add("0x23791abf");
            Veh_Ped_Name.Add("ig_natalia"); Veh_Ped_Hash.Add("0xde17dd3b");
            Veh_Ped_Name.Add("ig_nervousron"); Veh_Ped_Hash.Add("0xbd006af1");
            Veh_Ped_Name.Add("ig_nigel"); Veh_Ped_Hash.Add("0xc8b7167d");
            Veh_Ped_Name.Add("ig_old_man1a"); Veh_Ped_Hash.Add("0x719d27f4");
            Veh_Ped_Name.Add("ig_old_man2"); Veh_Ped_Hash.Add("0xef154c47");
            Veh_Ped_Name.Add("ig_oldrichguy"); Veh_Ped_Hash.Add("0x3c04504a");
            Veh_Ped_Name.Add("ig_omega"); Veh_Ped_Hash.Add("0x60e6a7d8");
            Veh_Ped_Name.Add("ig_oneil"); Veh_Ped_Hash.Add("0x2dc6d3e7");
            Veh_Ped_Name.Add("ig_orleans"); Veh_Ped_Hash.Add("0x61d4c771");
            Veh_Ped_Name.Add("ig_ortega"); Veh_Ped_Hash.Add("0x26a562b7");
            Veh_Ped_Name.Add("ig_paige"); Veh_Ped_Hash.Add("0x154fcf3f");
            Veh_Ped_Name.Add("ig_paper"); Veh_Ped_Hash.Add("0x999b00c6");
            Veh_Ped_Name.Add("ig_party_promo"); Veh_Ped_Hash.Add("0x85b8a435");
            Veh_Ped_Name.Add("ig_patricia"); Veh_Ped_Hash.Add("0xc56e118c");
            Veh_Ped_Name.Add("ig_patricia_02"); Veh_Ped_Hash.Add("0xc3114cb1");
            Veh_Ped_Name.Add("ig_pilot"); Veh_Ped_Hash.Add("0x864ed68e");
            Veh_Ped_Name.Add("ig_popov"); Veh_Ped_Hash.Add("0x267630fe");
            Veh_Ped_Name.Add("ig_priest"); Veh_Ped_Hash.Add("0x6437e77d");
            Veh_Ped_Name.Add("ig_prolsec_02"); Veh_Ped_Hash.Add("0x27b3ad75");
            Veh_Ped_Name.Add("ig_ramp_gang"); Veh_Ped_Hash.Add("0xe52e126c");
            Veh_Ped_Name.Add("ig_ramp_hic"); Veh_Ped_Hash.Add("0x45753032");
            Veh_Ped_Name.Add("ig_ramp_hipster"); Veh_Ped_Hash.Add("0xdeef9f6e");
            Veh_Ped_Name.Add("ig_ramp_mex"); Veh_Ped_Hash.Add("0xe6ac74a4");
            Veh_Ped_Name.Add("ig_rashcosvki"); Veh_Ped_Hash.Add("0x380c4de6");
            Veh_Ped_Name.Add("ig_req_officer"); Veh_Ped_Hash.Add("0xeb176014");
            Veh_Ped_Name.Add("ig_roccopelosi"); Veh_Ped_Hash.Add("0xd5ba52ff");
            Veh_Ped_Name.Add("ig_russiandrunk"); Veh_Ped_Hash.Add("0x3d0a5eb1");
            Veh_Ped_Name.Add("ig_sacha"); Veh_Ped_Hash.Add("0x5802d9f5");
            Veh_Ped_Name.Add("ig_screen_writer"); Veh_Ped_Hash.Add("0xffe63677");
            Veh_Ped_Name.Add("ig_security_a"); Veh_Ped_Hash.Add("0x2f4e5c7b");
            Veh_Ped_Name.Add("ig_sessanta"); Veh_Ped_Hash.Add("0x371b9da9");
            Veh_Ped_Name.Add("ig_siemonyetarian"); Veh_Ped_Hash.Add("0x4c7b2f05");
            Veh_Ped_Name.Add("ig_sol"); Veh_Ped_Hash.Add("0xe1ab915c");
            Veh_Ped_Name.Add("ig_solomon"); Veh_Ped_Hash.Add("0x86bdfe26");
            Veh_Ped_Name.Add("ig_soundeng_00"); Veh_Ped_Hash.Add("0xda3bdde8");
            Veh_Ped_Name.Add("ig_sss"); Veh_Ped_Hash.Add("0x3b18e305");
            Veh_Ped_Name.Add("ig_stevehains"); Veh_Ped_Hash.Add("0x382121c8");
            Veh_Ped_Name.Add("ig_stretch"); Veh_Ped_Hash.Add("0x36984358");
            Veh_Ped_Name.Add("ig_talcc"); Veh_Ped_Hash.Add("0xe43422a3");
            Veh_Ped_Name.Add("ig_talina"); Veh_Ped_Hash.Add("0xe793c8e8");
            Veh_Ped_Name.Add("ig_talmm"); Veh_Ped_Hash.Add("0x46764719");
            Veh_Ped_Name.Add("ig_tanisha"); Veh_Ped_Hash.Add("0xd810489");
            Veh_Ped_Name.Add("ig_taocheng"); Veh_Ped_Hash.Add("0xdc5c5ea5");
            Veh_Ped_Name.Add("ig_taocheng2"); Veh_Ped_Hash.Add("0x59c62b90");
            Veh_Ped_Name.Add("ig_taostranslator"); Veh_Ped_Hash.Add("0x7c851464");
            Veh_Ped_Name.Add("ig_taostranslator2"); Veh_Ped_Hash.Add("0xe433179f");
            Veh_Ped_Name.Add("ig_tenniscoach"); Veh_Ped_Hash.Add("0xa23b5f57");
            Veh_Ped_Name.Add("ig_terry"); Veh_Ped_Hash.Add("0x67000b94");
            Veh_Ped_Name.Add("ig_thornton"); Veh_Ped_Hash.Add("0x93fecbd7");
            Veh_Ped_Name.Add("ig_tomcasino"); Veh_Ped_Hash.Add("0x35456a4");
            Veh_Ped_Name.Add("ig_tomepsilon"); Veh_Ped_Hash.Add("0xcd777aaa");
            Veh_Ped_Name.Add("ig_tonya"); Veh_Ped_Hash.Add("0xcac85344");
            Veh_Ped_Name.Add("ig_tonyprince"); Veh_Ped_Hash.Add("0x2d6897b5");
            Veh_Ped_Name.Add("ig_tracydisanto"); Veh_Ped_Hash.Add("0xde352a35");
            Veh_Ped_Name.Add("ig_trafficwarden"); Veh_Ped_Hash.Add("0x5719786d");
            Veh_Ped_Name.Add("ig_tylerdix"); Veh_Ped_Hash.Add("0x5265f707");
            Veh_Ped_Name.Add("ig_tylerdix_02"); Veh_Ped_Hash.Add("0x5a185477");
            Veh_Ped_Name.Add("ig_vagos_leader"); Veh_Ped_Hash.Add("0x837b64de");
            Veh_Ped_Name.Add("ig_vagspeak"); Veh_Ped_Hash.Add("0xf9fd068c");
            Veh_Ped_Name.Add("ig_vernon"); Veh_Ped_Hash.Add("0xcdb291a2");
            Veh_Ped_Name.Add("ig_vincent"); Veh_Ped_Hash.Add("0x2be886b2");
            Veh_Ped_Name.Add("ig_vincent_2"); Veh_Ped_Hash.Add("0xbc4bdd3");
            Veh_Ped_Name.Add("ig_vincent_3"); Veh_Ped_Hash.Add("0x15add1a5");
            Veh_Ped_Name.Add("ig_wade"); Veh_Ped_Hash.Add("0x92991b72");
            Veh_Ped_Name.Add("ig_wendy"); Veh_Ped_Hash.Add("0x6e47a411");
            Veh_Ped_Name.Add("ig_zimbor"); Veh_Ped_Hash.Add("0xb34d6f5");
            Veh_Ped_Name.Add("mp_f_bennymech_01"); Veh_Ped_Hash.Add("0x7f81b0bd");
            Veh_Ped_Name.Add("mp_f_boatstaff_01"); Veh_Ped_Hash.Add("0x3293b9ce");
            Veh_Ped_Name.Add("mp_f_cardesign_01"); Veh_Ped_Hash.Add("0x242c34a7");
            Veh_Ped_Name.Add("mp_f_chbar_01"); Veh_Ped_Hash.Add("0xc3f6e385");
            Veh_Ped_Name.Add("mp_f_cocaine_01"); Veh_Ped_Hash.Add("0x4b657af8");
            Veh_Ped_Name.Add("mp_f_counterfeit_01"); Veh_Ped_Hash.Add("0xb788f1f5");
            Veh_Ped_Name.Add("mp_f_deadhooker"); Veh_Ped_Hash.Add("0x73dea88b");
            Veh_Ped_Name.Add("mp_f_execpa_01"); Veh_Ped_Hash.Add("0x432ca064");
            Veh_Ped_Name.Add("mp_f_execpa_02"); Veh_Ped_Hash.Add("0x5972ccf0");
            Veh_Ped_Name.Add("mp_f_forgery_01"); Veh_Ped_Hash.Add("0x781a3cf8");
            Veh_Ped_Name.Add("mp_f_freemode_01"); Veh_Ped_Hash.Add("0x9c9effd8");
            Veh_Ped_Name.Add("mp_f_helistaff_01"); Veh_Ped_Hash.Add("0x19b6ff06");
            Veh_Ped_Name.Add("mp_f_meth_01"); Veh_Ped_Hash.Add("0xd2b27ec1");
            Veh_Ped_Name.Add("mp_f_misty_01"); Veh_Ped_Hash.Add("0xd128ff9d");
            Veh_Ped_Name.Add("mp_f_stripperlite"); Veh_Ped_Hash.Add("0x2970a494");
            Veh_Ped_Name.Add("mp_f_weed_01"); Veh_Ped_Hash.Add("0xb26573a3");
            Veh_Ped_Name.Add("mp_g_m_pros_01"); Veh_Ped_Hash.Add("0x6c9dd7c9");
            Veh_Ped_Name.Add("mp_headtargets"); Veh_Ped_Hash.Add("0x45f92d79");
            Veh_Ped_Name.Add("mp_m_avongoon"); Veh_Ped_Hash.Add("0x9c13cb95");
            Veh_Ped_Name.Add("mp_m_boatstaff_01"); Veh_Ped_Hash.Add("0xc85f0a88");
            Veh_Ped_Name.Add("mp_m_bogdangoon"); Veh_Ped_Hash.Add("0x4d5696f7");
            Veh_Ped_Name.Add("mp_m_claude_01"); Veh_Ped_Hash.Add("0xc0f371b7");
            Veh_Ped_Name.Add("mp_m_cocaine_01"); Veh_Ped_Hash.Add("0x56d38f95");
            Veh_Ped_Name.Add("mp_m_counterfeit_01"); Veh_Ped_Hash.Add("0x9855c974");
            Veh_Ped_Name.Add("mp_m_exarmy_01"); Veh_Ped_Hash.Add("0x45348dbb");
            Veh_Ped_Name.Add("mp_m_execpa_01"); Veh_Ped_Hash.Add("0x3e8417bc");
            Veh_Ped_Name.Add("mp_m_famdd_01"); Veh_Ped_Hash.Add("0x33a464e5");
            Veh_Ped_Name.Add("mp_m_fibsec_01"); Veh_Ped_Hash.Add("0x5cdef405");
            Veh_Ped_Name.Add("mp_m_forgery_01"); Veh_Ped_Hash.Add("0x613e709b");
            Veh_Ped_Name.Add("mp_m_freemode_01"); Veh_Ped_Hash.Add("0x705e61f2");
            Veh_Ped_Name.Add("mp_m_g_vagfun_01"); Veh_Ped_Hash.Add("0xc4a617bd");
            Veh_Ped_Name.Add("mp_m_marston_01"); Veh_Ped_Hash.Add("0x38430167");
            Veh_Ped_Name.Add("mp_m_meth_01"); Veh_Ped_Hash.Add("0xedb42f3f");
            Veh_Ped_Name.Add("mp_m_niko_01"); Veh_Ped_Hash.Add("0xeedacfc9");
            Veh_Ped_Name.Add("mp_m_securoguard_01"); Veh_Ped_Hash.Add("0xda2c984e");
            Veh_Ped_Name.Add("mp_m_shopkeep_01"); Veh_Ped_Hash.Add("0x18ce57d0");
            Veh_Ped_Name.Add("mp_m_waremech_01"); Veh_Ped_Hash.Add("0xf7a74139");
            Veh_Ped_Name.Add("mp_m_weapexp_01"); Veh_Ped_Hash.Add("0x36ea5b09");
            Veh_Ped_Name.Add("mp_m_weapwork_01"); Veh_Ped_Hash.Add("0x4186506e");
            Veh_Ped_Name.Add("mp_m_weed_01"); Veh_Ped_Hash.Add("0x917ed459");
            Veh_Ped_Name.Add("mp_s_m_armoured_01"); Veh_Ped_Hash.Add("0xcdef5408");
            Veh_Ped_Name.Add("p_franklin_02"); Veh_Ped_Hash.Add("0xaf10bd56");
            Veh_Ped_Name.Add("player_one"); Veh_Ped_Hash.Add("0x9b22dbaf");
            Veh_Ped_Name.Add("player_two"); Veh_Ped_Hash.Add("0x9b810fa2");
            Veh_Ped_Name.Add("player_zero"); Veh_Ped_Hash.Add("0xd7114c9");
            Veh_Ped_Name.Add("s_f_m_autoshop_01"); Veh_Ped_Hash.Add("0xbd1f24");
            Veh_Ped_Name.Add("s_f_m_fembarber"); Veh_Ped_Hash.Add("0x163b875b");
            Veh_Ped_Name.Add("s_f_m_maid_01"); Veh_Ped_Hash.Add("0xe093c5c6");
            Veh_Ped_Name.Add("s_f_m_retailstaff_01"); Veh_Ped_Hash.Add("0xc19c2462");
            Veh_Ped_Name.Add("s_f_m_shop_high"); Veh_Ped_Hash.Add("0xae47e4b0");
            Veh_Ped_Name.Add("s_f_m_studioassist_01"); Veh_Ped_Hash.Add("0xc155acc0");
            Veh_Ped_Name.Add("s_f_m_sweatshop_01"); Veh_Ped_Hash.Add("0x312b5bc0");
            Veh_Ped_Name.Add("s_f_y_airhostess_01"); Veh_Ped_Hash.Add("0x5d71a46f");
            Veh_Ped_Name.Add("s_f_y_bartender_01"); Veh_Ped_Hash.Add("0x780c01bd");
            Veh_Ped_Name.Add("s_f_y_baywatch_01"); Veh_Ped_Hash.Add("0x4a8e5536");
            Veh_Ped_Name.Add("s_f_y_beachbarstaff_01"); Veh_Ped_Hash.Add("0xc2e31a0a");
            Veh_Ped_Name.Add("s_f_y_casino_01"); Veh_Ped_Hash.Add("0xbc92bed5");
            Veh_Ped_Name.Add("s_f_y_clubbar_01"); Veh_Ped_Hash.Add("0xc126394b");
            Veh_Ped_Name.Add("s_f_y_clubbar_02"); Veh_Ped_Hash.Add("0x55c5627b");
            Veh_Ped_Name.Add("s_f_y_cop_01"); Veh_Ped_Hash.Add("0x15f8700d");
            Veh_Ped_Name.Add("s_f_y_factory_01"); Veh_Ped_Hash.Add("0x69f46bf3");
            Veh_Ped_Name.Add("s_f_y_hooker_01"); Veh_Ped_Hash.Add("0x28abf95");
            Veh_Ped_Name.Add("s_f_y_hooker_02"); Veh_Ped_Hash.Add("0x14c3e407");
            Veh_Ped_Name.Add("s_f_y_hooker_03"); Veh_Ped_Hash.Add("0x31640ac");
            Veh_Ped_Name.Add("s_f_y_migrant_01"); Veh_Ped_Hash.Add("0xd55b2bf5");
            Veh_Ped_Name.Add("s_f_y_movprem_01"); Veh_Ped_Hash.Add("0x2300c816");
            Veh_Ped_Name.Add("s_f_y_ranger_01"); Veh_Ped_Hash.Add("0x9fc7f637");
            Veh_Ped_Name.Add("s_f_y_scrubs_01"); Veh_Ped_Hash.Add("0xab594ab6");
            Veh_Ped_Name.Add("s_f_y_sheriff_01"); Veh_Ped_Hash.Add("0x4161d042");
            Veh_Ped_Name.Add("s_f_y_shop_low"); Veh_Ped_Hash.Add("0xa96e2604");
            Veh_Ped_Name.Add("s_f_y_shop_mid"); Veh_Ped_Hash.Add("0x3eecba5d");
            Veh_Ped_Name.Add("s_f_y_stripper_01"); Veh_Ped_Hash.Add("0x52580019");
            Veh_Ped_Name.Add("s_f_y_stripper_02"); Veh_Ped_Hash.Add("0x6e0fb794");
            Veh_Ped_Name.Add("s_f_y_stripperlite"); Veh_Ped_Hash.Add("0x5c14edfa");
            Veh_Ped_Name.Add("s_f_y_sweatshop_01"); Veh_Ped_Hash.Add("0x8502b6b2");
            Veh_Ped_Name.Add("s_m_m_ammucountry"); Veh_Ped_Hash.Add("0xde9a30a");
            Veh_Ped_Name.Add("s_m_m_armoured_01"); Veh_Ped_Hash.Add("0x95c76ecd");
            Veh_Ped_Name.Add("s_m_m_armoured_02"); Veh_Ped_Hash.Add("0x63858a4a");
            Veh_Ped_Name.Add("s_m_m_autoshop_01"); Veh_Ped_Hash.Add("0x40eabe3");
            Veh_Ped_Name.Add("s_m_m_autoshop_02"); Veh_Ped_Hash.Add("0xf06b849d");
            Veh_Ped_Name.Add("s_m_m_autoshop_03"); Veh_Ped_Hash.Add("0x68c3112");
            Veh_Ped_Name.Add("s_m_m_bouncer_01"); Veh_Ped_Hash.Add("0x9fd4292d");
            Veh_Ped_Name.Add("s_m_m_bouncer_02"); Veh_Ped_Hash.Add("0x52060d92");
            Veh_Ped_Name.Add("s_m_m_ccrew_01"); Veh_Ped_Hash.Add("0xc9e5f56b");
            Veh_Ped_Name.Add("s_m_m_chemsec_01"); Veh_Ped_Hash.Add("0x2efeafd5");
            Veh_Ped_Name.Add("s_m_m_ciasec_01"); Veh_Ped_Hash.Add("0x625d6958");
            Veh_Ped_Name.Add("s_m_m_cntrybar_01"); Veh_Ped_Hash.Add("0x1a021b83");
            Veh_Ped_Name.Add("s_m_m_dockwork_01"); Veh_Ped_Hash.Add("0x14d7b4e0");
            Veh_Ped_Name.Add("s_m_m_doctor_01"); Veh_Ped_Hash.Add("0xd47303ac");
            Veh_Ped_Name.Add("s_m_m_drugprocess_01"); Veh_Ped_Hash.Add("0x5c366c83");
            Veh_Ped_Name.Add("s_m_m_fiboffice_01"); Veh_Ped_Hash.Add("0xedbc7546");
            Veh_Ped_Name.Add("s_m_m_fiboffice_02"); Veh_Ped_Hash.Add("0x26f067ad");
            Veh_Ped_Name.Add("s_m_m_fibsec_01"); Veh_Ped_Hash.Add("0x7b8b434b");
            Veh_Ped_Name.Add("s_m_m_fieldworker_01"); Veh_Ped_Hash.Add("0x9074ca50");
            Veh_Ped_Name.Add("s_m_m_gaffer_01"); Veh_Ped_Hash.Add("0xa956bd9e");
            Veh_Ped_Name.Add("s_m_m_gardener_01"); Veh_Ped_Hash.Add("0x49ea5685");
            Veh_Ped_Name.Add("s_m_m_gentransport"); Veh_Ped_Hash.Add("0x1880ed06");
            Veh_Ped_Name.Add("s_m_m_hairdress_01"); Veh_Ped_Hash.Add("0x418dff92");
            Veh_Ped_Name.Add("s_m_m_highsec_01"); Veh_Ped_Hash.Add("0xf161d212");
            Veh_Ped_Name.Add("s_m_m_highsec_02"); Veh_Ped_Hash.Add("0x2930c1ab");
            Veh_Ped_Name.Add("s_m_m_highsec_03"); Veh_Ped_Hash.Add("0x1eeaad1f");
            Veh_Ped_Name.Add("s_m_m_highsec_04"); Veh_Ped_Hash.Add("0x55fe9b46");
            Veh_Ped_Name.Add("s_m_m_highsec_05"); Veh_Ped_Hash.Add("0x3abb64c0");
            Veh_Ped_Name.Add("s_m_m_janitor"); Veh_Ped_Hash.Add("0xa96bd9ec");
            Veh_Ped_Name.Add("s_m_m_lathandy_01"); Veh_Ped_Hash.Add("0x9e80d2ce");
            Veh_Ped_Name.Add("s_m_m_lifeinvad_01"); Veh_Ped_Hash.Add("0xde0077fd");
            Veh_Ped_Name.Add("s_m_m_linecook"); Veh_Ped_Hash.Add("0xdb9c0997");
            Veh_Ped_Name.Add("s_m_m_lsmetro_01"); Veh_Ped_Hash.Add("0x765aaae4");
            Veh_Ped_Name.Add("s_m_m_mariachi_01"); Veh_Ped_Hash.Add("0x7ea4ffa6");
            Veh_Ped_Name.Add("s_m_m_marine_01"); Veh_Ped_Hash.Add("0xf2daa2ed");
            Veh_Ped_Name.Add("s_m_m_marine_02"); Veh_Ped_Hash.Add("0xf0259d83");
            Veh_Ped_Name.Add("s_m_m_migrant_01"); Veh_Ped_Hash.Add("0xed0ce4c6");
            Veh_Ped_Name.Add("s_m_m_movalien_01"); Veh_Ped_Hash.Add("0x64611296");
            Veh_Ped_Name.Add("s_m_m_movprem_01"); Veh_Ped_Hash.Add("0xd85e6d28");
            Veh_Ped_Name.Add("s_m_m_movspace_01"); Veh_Ped_Hash.Add("0xe7b31432");
            Veh_Ped_Name.Add("s_m_m_paramedic_01"); Veh_Ped_Hash.Add("0xb353629e");
            Veh_Ped_Name.Add("s_m_m_pilot_01"); Veh_Ped_Hash.Add("0xe75b4b1c");
            Veh_Ped_Name.Add("s_m_m_pilot_02"); Veh_Ped_Hash.Add("0xf63de8e1");
            Veh_Ped_Name.Add("s_m_m_postal_01"); Veh_Ped_Hash.Add("0x62599034");
            Veh_Ped_Name.Add("s_m_m_postal_02"); Veh_Ped_Hash.Add("0x7367324f");
            Veh_Ped_Name.Add("s_m_m_prisguard_01"); Veh_Ped_Hash.Add("0x56c96fc6");
            Veh_Ped_Name.Add("s_m_m_raceorg_01"); Veh_Ped_Hash.Add("0x9ad98d99");
            Veh_Ped_Name.Add("s_m_m_scientist_01"); Veh_Ped_Hash.Add("0x4117d39b");
            Veh_Ped_Name.Add("s_m_m_security_01"); Veh_Ped_Hash.Add("0xd768b228");
            Veh_Ped_Name.Add("s_m_m_snowcop_01"); Veh_Ped_Hash.Add("0x1ae8bb58");
            Veh_Ped_Name.Add("s_m_m_strperf_01"); Veh_Ped_Hash.Add("0x795ac7a8");
            Veh_Ped_Name.Add("s_m_m_strpreach_01"); Veh_Ped_Hash.Add("0x1c0077fb");
            Veh_Ped_Name.Add("s_m_m_strvend_01"); Veh_Ped_Hash.Add("0xce9113a9");
            Veh_Ped_Name.Add("s_m_m_studioassist_02"); Veh_Ped_Hash.Add("0x9fb16928");
            Veh_Ped_Name.Add("s_m_m_studioprod_01"); Veh_Ped_Hash.Add("0xe3a30bbf");
            Veh_Ped_Name.Add("s_m_m_studiosoueng_02"); Veh_Ped_Hash.Add("0xde08c410");
            Veh_Ped_Name.Add("s_m_m_tattoo_01"); Veh_Ped_Hash.Add("0xc41743eb");
            Veh_Ped_Name.Add("s_m_m_trucker_01"); Veh_Ped_Hash.Add("0x59511a6c");
            Veh_Ped_Name.Add("s_m_m_ups_01"); Veh_Ped_Hash.Add("0x9fc37f22");
            Veh_Ped_Name.Add("s_m_m_ups_02"); Veh_Ped_Hash.Add("0xd0bde116");
            Veh_Ped_Name.Add("s_m_o_busker_01"); Veh_Ped_Hash.Add("0xad9ef1bb");
            Veh_Ped_Name.Add("s_m_y_airworker"); Veh_Ped_Hash.Add("0x62018559");
            Veh_Ped_Name.Add("s_m_y_ammucity_01"); Veh_Ped_Hash.Add("0x9e08633d");
            Veh_Ped_Name.Add("s_m_y_armymech_01"); Veh_Ped_Hash.Add("0x62cc28e2");
            Veh_Ped_Name.Add("s_m_y_autopsy_01"); Veh_Ped_Hash.Add("0xb2273d4e");
            Veh_Ped_Name.Add("s_m_y_barman_01"); Veh_Ped_Hash.Add("0xe5a11106");
            Veh_Ped_Name.Add("s_m_y_baywatch_01"); Veh_Ped_Hash.Add("0xb4a6862");
            Veh_Ped_Name.Add("s_m_y_blackops_01"); Veh_Ped_Hash.Add("0xb3f3ee34");
            Veh_Ped_Name.Add("s_m_y_blackops_02"); Veh_Ped_Hash.Add("0x7a05fa59");
            Veh_Ped_Name.Add("s_m_y_blackops_03"); Veh_Ped_Hash.Add("0x5076a73b");
            Veh_Ped_Name.Add("s_m_y_busboy_01"); Veh_Ped_Hash.Add("0xd8f9cd47");
            Veh_Ped_Name.Add("s_m_y_casino_01"); Veh_Ped_Hash.Add("0x1422d45b");
            Veh_Ped_Name.Add("s_m_y_chef_01"); Veh_Ped_Hash.Add("0xf977ceb");
            Veh_Ped_Name.Add("s_m_y_clown_01"); Veh_Ped_Hash.Add("0x4498dde");
            Veh_Ped_Name.Add("s_m_y_clubbar_01"); Veh_Ped_Hash.Add("0x4d73a43f");
            Veh_Ped_Name.Add("s_m_y_construct_01"); Veh_Ped_Hash.Add("0xd7da9e99");
            Veh_Ped_Name.Add("s_m_y_construct_02"); Veh_Ped_Hash.Add("0xc5fefade");
            Veh_Ped_Name.Add("s_m_y_cop_01"); Veh_Ped_Hash.Add("0x5e3da4a4");
            Veh_Ped_Name.Add("s_m_y_dealer_01"); Veh_Ped_Hash.Add("0xe497bbef");
            Veh_Ped_Name.Add("s_m_y_devinsec_01"); Veh_Ped_Hash.Add("0x9b557274");
            Veh_Ped_Name.Add("s_m_y_dockwork_01"); Veh_Ped_Hash.Add("0x867639d1");
            Veh_Ped_Name.Add("s_m_y_doorman_01"); Veh_Ped_Hash.Add("0x22911304");
            Veh_Ped_Name.Add("s_m_y_dwservice_01"); Veh_Ped_Hash.Add("0x75d30a91");
            Veh_Ped_Name.Add("s_m_y_dwservice_02"); Veh_Ped_Hash.Add("0xf5908a06");
            Veh_Ped_Name.Add("s_m_y_factory_01"); Veh_Ped_Hash.Add("0x4163a158");
            Veh_Ped_Name.Add("s_m_y_fireman_01"); Veh_Ped_Hash.Add("0xb6b1eda8");
            Veh_Ped_Name.Add("s_m_y_garbage"); Veh_Ped_Hash.Add("0xee75a00f");
            Veh_Ped_Name.Add("s_m_y_grip_01"); Veh_Ped_Hash.Add("0x309e7dea");
            Veh_Ped_Name.Add("s_m_y_hwaycop_01"); Veh_Ped_Hash.Add("0x739b1ef5");
            Veh_Ped_Name.Add("s_m_y_marine_01"); Veh_Ped_Hash.Add("0x65793043");
            Veh_Ped_Name.Add("s_m_y_marine_02"); Veh_Ped_Hash.Add("0x58d696fe");
            Veh_Ped_Name.Add("s_m_y_marine_03"); Veh_Ped_Hash.Add("0x72c0cad2");
            Veh_Ped_Name.Add("s_m_y_mime"); Veh_Ped_Hash.Add("0x3cdca742");
            Veh_Ped_Name.Add("s_m_y_pestcont_01"); Veh_Ped_Hash.Add("0x48114518");
            Veh_Ped_Name.Add("s_m_y_pilot_01"); Veh_Ped_Hash.Add("0xab300c07");
            Veh_Ped_Name.Add("s_m_y_prismuscl_01"); Veh_Ped_Hash.Add("0x5f2113a1");
            Veh_Ped_Name.Add("s_m_y_prisoner_01"); Veh_Ped_Hash.Add("0xb1bb9b59");
            Veh_Ped_Name.Add("s_m_y_ranger_01"); Veh_Ped_Hash.Add("0xef7135ae");
            Veh_Ped_Name.Add("s_m_y_robber_01"); Veh_Ped_Hash.Add("0xc05e1399");
            Veh_Ped_Name.Add("s_m_y_sheriff_01"); Veh_Ped_Hash.Add("0xb144f9b9");
            Veh_Ped_Name.Add("s_m_y_shop_mask"); Veh_Ped_Hash.Add("0x6e122c06");
            Veh_Ped_Name.Add("s_m_y_strvend_01"); Veh_Ped_Hash.Add("0x927f2323");
            Veh_Ped_Name.Add("s_m_y_swat_01"); Veh_Ped_Hash.Add("0x8d8f1b10");
            Veh_Ped_Name.Add("s_m_y_uscg_01"); Veh_Ped_Hash.Add("0xca0050e9");
            Veh_Ped_Name.Add("s_m_y_valet_01"); Veh_Ped_Hash.Add("0x3b96f23e");
            Veh_Ped_Name.Add("s_m_y_waiter_01"); Veh_Ped_Hash.Add("0xad4c724c");
            Veh_Ped_Name.Add("s_m_y_waretech_01"); Veh_Ped_Hash.Add("0x48c7a430");
            Veh_Ped_Name.Add("s_m_y_westsec_01"); Veh_Ped_Hash.Add("0xa217f345");
            Veh_Ped_Name.Add("s_m_y_westsec_02"); Veh_Ped_Hash.Add("0xbec82ca5");
            Veh_Ped_Name.Add("s_m_y_winclean_01"); Veh_Ped_Hash.Add("0x550d8d9d");
            Veh_Ped_Name.Add("s_m_y_xmech_01"); Veh_Ped_Hash.Add("0x441405ec");
            Veh_Ped_Name.Add("s_m_y_xmech_02"); Veh_Ped_Hash.Add("0xbe20fa04");
            Veh_Ped_Name.Add("s_m_y_xmech_02_mp"); Veh_Ped_Hash.Add("0x69147a0d");
            Veh_Ped_Name.Add("slod_human"); Veh_Ped_Hash.Add("0x3f039cba");
            Veh_Ped_Name.Add("slod_large_quadped"); Veh_Ped_Hash.Add("0x856cfb02");
            Veh_Ped_Name.Add("slod_small_quadped"); Veh_Ped_Hash.Add("0x2d7030f3");
            Veh_Ped_Name.Add("u_f_m_casinocash_01"); Veh_Ped_Hash.Add("0xbb0d72f5");
            Veh_Ped_Name.Add("u_f_m_casinoshop_01"); Veh_Ped_Hash.Add("0x1427d428");
            Veh_Ped_Name.Add("u_f_m_corpse_01"); Veh_Ped_Hash.Add("0x2e140314");
            Veh_Ped_Name.Add("u_f_m_debbie_01"); Veh_Ped_Hash.Add("0xd575a46");
            Veh_Ped_Name.Add("u_f_m_drowned_01"); Veh_Ped_Hash.Add("0xd7f37609");
            Veh_Ped_Name.Add("u_f_m_miranda"); Veh_Ped_Hash.Add("0x414fa27b");
            Veh_Ped_Name.Add("u_f_m_miranda_02"); Veh_Ped_Hash.Add("0xebbb0cb4");
            Veh_Ped_Name.Add("u_f_m_promourn_01"); Veh_Ped_Hash.Add("0xa20899e7");
            Veh_Ped_Name.Add("u_f_o_carol"); Veh_Ped_Hash.Add("0x54597b3a");
            Veh_Ped_Name.Add("u_f_o_eileen"); Veh_Ped_Hash.Add("0x9ccd13f8");
            Veh_Ped_Name.Add("u_f_o_moviestar"); Veh_Ped_Hash.Add("0x35578634");
            Veh_Ped_Name.Add("u_f_o_prolhost_01"); Veh_Ped_Hash.Add("0xc512dd23");
            Veh_Ped_Name.Add("u_f_y_beth"); Veh_Ped_Hash.Add("0x953f798b");
            Veh_Ped_Name.Add("u_f_y_bikerchic"); Veh_Ped_Hash.Add("0xfa389d4f");
            Veh_Ped_Name.Add("u_f_y_comjane"); Veh_Ped_Hash.Add("0xb6aa85ce");
            Veh_Ped_Name.Add("u_f_y_corpse_01"); Veh_Ped_Hash.Add("0x9c70109d");
            Veh_Ped_Name.Add("u_f_y_corpse_02"); Veh_Ped_Hash.Add("0xd9c72f8");
            Veh_Ped_Name.Add("u_f_y_danceburl_01"); Veh_Ped_Hash.Add("0xd4546aa");
            Veh_Ped_Name.Add("u_f_y_dancelthr_01"); Veh_Ped_Hash.Add("0x7c8a6bb");
            Veh_Ped_Name.Add("u_f_y_dancerave_01"); Veh_Ped_Hash.Add("0xace2a1f1");
            Veh_Ped_Name.Add("u_f_y_hotposh_01"); Veh_Ped_Hash.Add("0x969b6dfe");
            Veh_Ped_Name.Add("u_f_y_jewelass_01"); Veh_Ped_Hash.Add("0xf0d4be2e");
            Veh_Ped_Name.Add("u_f_y_lauren"); Veh_Ped_Hash.Add("0x39ac5284");
            Veh_Ped_Name.Add("u_f_y_mistress"); Veh_Ped_Hash.Add("0x5dca2528");
            Veh_Ped_Name.Add("u_f_y_poppymich"); Veh_Ped_Hash.Add("0x23e9a09e");
            Veh_Ped_Name.Add("u_f_y_poppymich_02"); Veh_Ped_Hash.Add("0x6cb605fb");
            Veh_Ped_Name.Add("u_f_y_princess"); Veh_Ped_Hash.Add("0xd2e3a284");
            Veh_Ped_Name.Add("u_f_y_spyactress"); Veh_Ped_Hash.Add("0x5b81d86c");
            Veh_Ped_Name.Add("u_f_y_taylor"); Veh_Ped_Hash.Add("0x1ad698a0");
            Veh_Ped_Name.Add("u_m_m_aldinapoli"); Veh_Ped_Hash.Add("0xf0ec56e2");
            Veh_Ped_Name.Add("u_m_m_bankman"); Veh_Ped_Hash.Add("0xc306d6f5");
            Veh_Ped_Name.Add("u_m_m_bikehire_01"); Veh_Ped_Hash.Add("0x76474545");
            Veh_Ped_Name.Add("u_m_m_blane"); Veh_Ped_Hash.Add("0x97989c98");
            Veh_Ped_Name.Add("u_m_m_curtis"); Veh_Ped_Hash.Add("0xf8056a75");
            Veh_Ped_Name.Add("u_m_m_doa_01"); Veh_Ped_Hash.Add("0x621e6bfd");
            Veh_Ped_Name.Add("u_m_m_edtoh"); Veh_Ped_Hash.Add("0x2a797197");
            Veh_Ped_Name.Add("u_m_m_fibarchitect"); Veh_Ped_Hash.Add("0x342333d3");
            Veh_Ped_Name.Add("u_m_m_filmdirector"); Veh_Ped_Hash.Add("0x2b6e1bb6");
            Veh_Ped_Name.Add("u_m_m_glenstank_01"); Veh_Ped_Hash.Add("0x45bb1666");
            Veh_Ped_Name.Add("u_m_m_griff_01"); Veh_Ped_Hash.Add("0xc454bcbb");
            Veh_Ped_Name.Add("u_m_m_jesus_01"); Veh_Ped_Hash.Add("0xce2cb751");
            Veh_Ped_Name.Add("u_m_m_jewelsec_01"); Veh_Ped_Hash.Add("0xacccbdb6");
            Veh_Ped_Name.Add("u_m_m_jewelthief"); Veh_Ped_Hash.Add("0xe6cc3cdc");
            Veh_Ped_Name.Add("u_m_m_markfost"); Veh_Ped_Hash.Add("0x1c95cb0b");
            Veh_Ped_Name.Add("u_m_m_partytarget"); Veh_Ped_Hash.Add("0x81f74de7");
            Veh_Ped_Name.Add("u_m_m_prolsec_01"); Veh_Ped_Hash.Add("0x709220c7");
            Veh_Ped_Name.Add("u_m_m_promourn_01"); Veh_Ped_Hash.Add("0xce96030b");
            Veh_Ped_Name.Add("u_m_m_rivalpap"); Veh_Ped_Hash.Add("0x60d5d6da");
            Veh_Ped_Name.Add("u_m_m_spyactor"); Veh_Ped_Hash.Add("0xac0ea5d8");
            Veh_Ped_Name.Add("u_m_m_streetart_01"); Veh_Ped_Hash.Add("0x6c19e962");
            Veh_Ped_Name.Add("u_m_m_vince"); Veh_Ped_Hash.Add("0x969e7c76");
            Veh_Ped_Name.Add("u_m_m_willyfist"); Veh_Ped_Hash.Add("0x90769a8f");
            Veh_Ped_Name.Add("u_m_o_dean"); Veh_Ped_Hash.Add("0xf9ab1c8b");
            Veh_Ped_Name.Add("u_m_o_filmnoir"); Veh_Ped_Hash.Add("0x2bacc2db");
            Veh_Ped_Name.Add("u_m_o_finguru_01"); Veh_Ped_Hash.Add("0x46e39e63");
            Veh_Ped_Name.Add("u_m_o_taphillbilly"); Veh_Ped_Hash.Add("0x9a1e5e52");
            Veh_Ped_Name.Add("u_m_o_tramp_01"); Veh_Ped_Hash.Add("0x6a8f1f9b");
            Veh_Ped_Name.Add("u_m_y_abner"); Veh_Ped_Hash.Add("0xf0ac2626");
            Veh_Ped_Name.Add("u_m_y_antonb"); Veh_Ped_Hash.Add("0xcf623a2c");
            Veh_Ped_Name.Add("u_m_y_babyd"); Veh_Ped_Hash.Add("0xda116e7e");
            Veh_Ped_Name.Add("u_m_y_baygor"); Veh_Ped_Hash.Add("0x5244247d");
            Veh_Ped_Name.Add("u_m_y_burgerdrug_01"); Veh_Ped_Hash.Add("0x8b7d3766");
            Veh_Ped_Name.Add("u_m_y_caleb"); Veh_Ped_Hash.Add("0xf760d12c");
            Veh_Ped_Name.Add("u_m_y_chip"); Veh_Ped_Hash.Add("0x24604b2b");
            Veh_Ped_Name.Add("u_m_y_corpse_01"); Veh_Ped_Hash.Add("0x94c2a03f");
            Veh_Ped_Name.Add("u_m_y_croupthief_01"); Veh_Ped_Hash.Add("0x7fe3dec7");
            Veh_Ped_Name.Add("u_m_y_cyclist_01"); Veh_Ped_Hash.Add("0x2d0efceb");
            Veh_Ped_Name.Add("u_m_y_danceburl_01"); Veh_Ped_Hash.Add("0x56034ef2");
            Veh_Ped_Name.Add("u_m_y_dancelthr_01"); Veh_Ped_Hash.Add("0xfa7b4566");
            Veh_Ped_Name.Add("u_m_y_dancerave_01"); Veh_Ped_Hash.Add("0x7fe3dd1f");
            Veh_Ped_Name.Add("u_m_y_fibmugger_01"); Veh_Ped_Hash.Add("0x85b9c668");
            Veh_Ped_Name.Add("u_m_y_gabriel"); Veh_Ped_Hash.Add("0x4c31c4a1");
            Veh_Ped_Name.Add("u_m_y_guido_01"); Veh_Ped_Hash.Add("0xc6b49a2f");
            Veh_Ped_Name.Add("u_m_y_gunvend_01"); Veh_Ped_Hash.Add("0xb3229752");
            Veh_Ped_Name.Add("u_m_y_hippie_01"); Veh_Ped_Hash.Add("0xf041880b");
            Veh_Ped_Name.Add("u_m_y_imporage"); Veh_Ped_Hash.Add("0x348065f5");
            Veh_Ped_Name.Add("u_m_y_juggernaut_01"); Veh_Ped_Hash.Add("0x90ef5134");
            Veh_Ped_Name.Add("u_m_y_justin"); Veh_Ped_Hash.Add("0x7dc3908f");
            Veh_Ped_Name.Add("u_m_y_mani"); Veh_Ped_Hash.Add("0xc8bb1e52");
            Veh_Ped_Name.Add("u_m_y_militarybum"); Veh_Ped_Hash.Add("0x4705974a");
            Veh_Ped_Name.Add("u_m_y_paparazzi"); Veh_Ped_Hash.Add("0x5048b328");
            Veh_Ped_Name.Add("u_m_y_party_01"); Veh_Ped_Hash.Add("0x36e70600");
            Veh_Ped_Name.Add("u_m_y_pogo_01"); Veh_Ped_Hash.Add("0xdc59940d");
            Veh_Ped_Name.Add("u_m_y_prisoner_01"); Veh_Ped_Hash.Add("0x7b9b4bc0");
            Veh_Ped_Name.Add("u_m_y_proldriver_01"); Veh_Ped_Hash.Add("0x855e36a3");
            Veh_Ped_Name.Add("u_m_y_rsranger_01"); Veh_Ped_Hash.Add("0x3c438cd2");
            Veh_Ped_Name.Add("u_m_y_sbike"); Veh_Ped_Hash.Add("0x6af4185d");
            Veh_Ped_Name.Add("u_m_y_smugmech_01"); Veh_Ped_Hash.Add("0xcd6741a5");
            Veh_Ped_Name.Add("u_m_y_staggrm_01"); Veh_Ped_Hash.Add("0x9194ce03");
            Veh_Ped_Name.Add("u_m_y_tattoo_01"); Veh_Ped_Hash.Add("0x94ae2b8c");
            Veh_Ped_Name.Add("u_m_y_ushi"); Veh_Ped_Hash.Add("0xfb6c0b97");
            Veh_Ped_Name.Add("u_m_y_zombie_01"); Veh_Ped_Hash.Add("0xac4b4506");

            for (int i = 0; i < Veh_Ped_Name.Count(); i++)
            {
                NameHash MyHash = new NameHash();
                MyHash.Item_Hash = Veh_Ped_Hash[i];
                MyHash.Item_Name = Veh_Ped_Name[i];
                NewVP.Ped_Hash.Add(MyHash);
            }

            return NewVP;
        }
        private int GetFormArea(Size size)
        {
            return size.Height * size.Width;
        }
        private void ResizeAlize(object sender, EventArgs e)
        {
            if (GetFormArea(this.Size) > _lastFormSize + 100 || GetFormArea(this.Size) < _lastFormSize - 100)
            {
                Control control = (Control)sender;
                float scaleFactor = (float)GetFormArea(control.Size) / (float)_lastFormSize;
                ResizeFont(this.Controls, scaleFactor);
                _lastFormSize = GetFormArea(control.Size);
            }
        }
        private void ResizeFont(Control.ControlCollection coll, float scaleFactor)
        {
            foreach (Control c in coll)
            {
                if (c.HasChildren)
                {
                    ResizeFont(c.Controls, scaleFactor);
                }
                else
                {
                    if (true)
                    {
                        c.Font = new Font(c.Font.FontFamily.Name, c.Font.Size * scaleFactor);
                    }
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            ReadVehAndPedList();

            this.Resize += new EventHandler(ResizeAlize);
            _lastFormSize = GetFormArea(this.Size);
        }
        private void PrintOutSyatem(string sLog)
        {
            using (StreamWriter tEx = File.AppendText(sOutputFile))
                BeLogs(sLog, tEx);
        }
        private void BeLogs(string sLogs, TextWriter tEx)
        {
            tEx.WriteLine($"{sLogs}");
        }
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
        public class PosRot
        {
            public string PosX { get; set; }
            public string PosY { get; set; }
            public string PosZ { get; set; }
            public string RotX { get; set; }
            public string RotY { get; set; }
            public string RotZ { get; set; }
        }
        public SpoonConvert WhatsMyName(SpoonConvert ThisSpoon)
        {
            for (int i = 0; i < MyVehPedList.Veh_Hash.Count(); i++)
            {
                if (MyVehPedList.Veh_Hash[i].Item_Hash == ThisSpoon.Shash)
                {
                    ThisSpoon.Sname = MyVehPedList.Veh_Hash[i].Item_Name;
                    ThisSpoon.Iobject = 2;
                }
            }

            for (int i = 0; i < MyVehPedList.Ped_Hash.Count(); i++)
            {
                if (MyVehPedList.Ped_Hash[i].Item_Hash == ThisSpoon.Shash)
                {
                    ThisSpoon.Sname = MyVehPedList.Ped_Hash[i].Item_Name;
                    ThisSpoon.Iobject = 3;
                }
            }

            return ThisSpoon;
        }
        private void SpoonConversion(string fileName)
        {
            if (File.Exists(fileName))
            {
                List<string> MyColect = new List<string>();
                List<SpoonConvert> MyConverstion = new List<SpoonConvert>();

                using (var reader = new StreamReader(fileName, Encoding.GetEncoding("ISO-8859-1")))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        MyColect.Add(line);
                    }
                }

                int iMyConvert = -1;
                bool bAttach = false;
                for (int i = 0; i < MyColect.Count(); i++)
                {
                    string line = MyColect[i];
                    if (iMyConvert == -1)
                    {
                        if (line.Contains("<ModelHash>"))
                        {
                            iMyConvert += 1;
                            bAttach = false;
                            int iNum = line.LastIndexOf("<ModelHash>") + 11;
                            line = line.Substring(iNum);
                            line = line.Remove(line.Count() - 12);
                            SpoonConvert ThisSpoon = new SpoonConvert
                            {
                                Iobject = 1,
                                Shash = line,
                                Sattach = "",
                                Rplace = new PosRot(),
                                Sname = "",
                                RattachPlace = new PosRot()
                            };
                            MyConverstion.Add(ThisSpoon);
                        }
                    }
                    else if (line.Contains("<ModelHash>"))
                    {
                        iMyConvert += 1;
                        bAttach = false;
                        int iNum = line.LastIndexOf("<ModelHash>") + 11;
                        line = line.Substring(iNum);
                        line = line.Remove(line.Count() - 12);
                        SpoonConvert ThisSpoon = new SpoonConvert
                        {
                            Iobject = 1,
                            Shash = line,
                            Sattach = "",
                            Rplace = new PosRot(),
                            Sname = "",
                            RattachPlace = new PosRot()
                        };
                        MyConverstion.Add(ThisSpoon);
                    }
                    else if (line.Contains("<InitialHandle>") )
                    {
                        int iNum = line.LastIndexOf("<InitialHandle>") + 15;
                        line = line.Substring(iNum);
                        line = line.Remove(line.Count() - 16);
                        MyConverstion[iMyConvert].SDesNum = line;
                    }
                    else if (line.Contains("<AttachedTo>") )
                    {
                        int iNum = line.LastIndexOf("<AttachedTo>") + 12;
                        line = line.Substring(iNum);
                        line = line.Remove(line.Count() - 13);
                        MyConverstion[iMyConvert].Sattach = line;
                        bAttach = true;
                    }
                    else if (line.Contains("<HashName>") )
                    {
                        int iNum = line.LastIndexOf("<HashName>") + 10;
                        line = line.Substring(iNum);
                        line = line.Remove(line.Count() - 11);
                        MyConverstion[iMyConvert].Sname = line;
                    }
                    else if (line.Contains("<X>") )
                    {
                        int iNum = line.LastIndexOf("<X>") + 3;
                        line = line.Substring(iNum);
                        line = line.Remove(line.Count() - 4);
                        if (line == "0" || line == "-0")
                            line = "0.00";

                        if (bAttach)
                            MyConverstion[iMyConvert].RattachPlace.PosX = line;
                        else
                            MyConverstion[iMyConvert].Rplace.PosX = line;
                    }
                    else if (line.Contains("<Y>") )
                    {
                        int iNum = line.LastIndexOf("<Y>") + 3;
                        line = line.Substring(iNum);
                        line = line.Remove(line.Count() - 4);
                        if (line == "0" || line == "-0")
                            line = "0.00";

                        if (bAttach)
                            MyConverstion[iMyConvert].RattachPlace.PosY = line;
                        else
                            MyConverstion[iMyConvert].Rplace.PosY = line;
                    }
                    else if (line.Contains("<Z>") )
                    {
                        int iNum = line.LastIndexOf("<Z>") + 3;
                        line = line.Substring(iNum);
                        line = line.Remove(line.Count() - 4);
                        if (line == "0" || line == "-0")
                            line = "0.00";

                        if (bAttach)
                            MyConverstion[iMyConvert].RattachPlace.PosZ = line;
                        else
                            MyConverstion[iMyConvert].Rplace.PosZ = line;
                    }
                    else if (line.Contains("<Pitch>") )
                    {
                        int iNum = line.LastIndexOf("<Pitch>") + 7;
                        line = line.Substring(iNum);
                        line = line.Remove(line.Count() - 8);
                        if (line == "0" || line == "-0")
                            line = "0.00";

                        if (bAttach)
                            MyConverstion[iMyConvert].RattachPlace.RotX = line;
                        else
                            MyConverstion[iMyConvert].Rplace.RotX = line;
                    }
                    else if (line.Contains("<Roll>") )
                    {
                        int iNum = line.LastIndexOf("<Roll>") + 6;
                        line = line.Substring(iNum);
                        line = line.Remove(line.Count() - 7);
                        if (line == "0" || line == "-0")
                            line = "0.00";

                        if (bAttach)
                            MyConverstion[iMyConvert].RattachPlace.RotY = line;
                        else
                            MyConverstion[iMyConvert].Rplace.RotY = line;
                    }
                    else if (line.Contains("<Yaw>"))
                    {
                        int iNum = line.LastIndexOf("<Yaw>") + 5;
                        line = line.Substring(iNum);
                        line = line.Remove(line.Count() - 6);
                        if (line == "0" || line == "-0")
                            line = "0.00";

                        if (bAttach)
                            MyConverstion[iMyConvert].RattachPlace.RotZ = line;
                        else
                            MyConverstion[iMyConvert].Rplace.RotZ = line;
                    }
                }

                SpoonPrint(MyConverstion);
            }
        }
        private void SpoonPrint(List<SpoonConvert> MyCon)
        {
            List<SpoonConvert> ObjectList = new List<SpoonConvert>();
            List<SpoonConvert> VehList = new List<SpoonConvert>();
            List<SpoonConvert> PedList = new List<SpoonConvert>();

            for (int i = 0; i < MyCon.Count(); i++)
            {
                SpoonConvert ThisSpoon = WhatsMyName(MyCon[i]);

                if (ThisSpoon.Iobject == 1)
                    ObjectList.Add(ThisSpoon);
                else if (ThisSpoon.Iobject == 2)
                    VehList.Add(ThisSpoon);
                else
                    PedList.Add(ThisSpoon);
            }

            PrintOutSyatem("//-------Objects-------");
            PrintOutSyatem("List<string> ObName = new List<string>();");
            PrintOutSyatem("List<int> ObHash = new List<int>();");
            PrintOutSyatem("List<Vector3> ObPos = new List<Vector3>();");
            PrintOutSyatem("List<Vector3> ObRot = new List<Vector3>();");
            PrintOutSyatem("List<Vector3> ObAttPos = new List<Vector3>();");
            PrintOutSyatem("List<Vector3> ObAttRot = new List<Vector3>();");

            for (int i = 0; i < ObjectList.Count(); i++)
            {
                PrintOutSyatem("//Ref;" + ObjectList[i].SDesNum + "");
                PrintOutSyatem("ObName.Add(\"" + ObjectList[i].Sname + "\");");
                PrintOutSyatem("ObHash.Add(" + ObjectList[i].Shash + ");");
                PrintOutSyatem("ObPos.Add(new Vector3(" + ObjectList[i].Rplace.PosX + "f, "+ ObjectList[i].Rplace.PosY + "f, " + ObjectList[i].Rplace.PosZ + "f);");
                PrintOutSyatem("ObRot.Add(new Vector3(" + ObjectList[i].Rplace.RotX + "f, " + ObjectList[i].Rplace.RotY + "f, " + ObjectList[i].Rplace.RotZ + "f);");
                if (ObjectList[i].Sattach != "")
                {
                    PrintOutSyatem("//------Attachto; " + ObjectList[i].Sattach + "");
                    PrintOutSyatem("AttPos.Add(new Vector3(" + ObjectList[i].RattachPlace.PosX + "f, " + ObjectList[i].RattachPlace.PosY + "f, " + ObjectList[i].RattachPlace.PosZ + "f);");
                    PrintOutSyatem("AttRot.Add(new Vector3(" + ObjectList[i].RattachPlace.RotX + "f, " + ObjectList[i].RattachPlace.RotY + "f, " + ObjectList[i].RattachPlace.RotZ + "f);");
                }
                PrintOutSyatem("//--------------------");
            }

            PrintOutSyatem("//-------Vehicles-------");
            PrintOutSyatem("List<string> VehName = new List<string>();");
            PrintOutSyatem("List<int> VehHash = new List<int>();");
            PrintOutSyatem("List<Vector3> VehPos = new List<Vector3>();");
            PrintOutSyatem("List<Vector3> VehRot = new List<Vector3>();");
            PrintOutSyatem("List<Vector3> VehAttPos = new List<Vector3>();");
            PrintOutSyatem("List<Vector3> VehAttRot = new List<Vector3>();");

            for (int i = 0; i < VehList.Count(); i++)
            {
                PrintOutSyatem("//Ref;" + VehList[i].SDesNum + "");
                PrintOutSyatem("ObName.Add(\"" + VehList[i].Sname + "\");");
                PrintOutSyatem("ObHash.Add(" + VehList[i].Shash + ");");
                PrintOutSyatem("ObPos.Add(new Vector3(" + VehList[i].Rplace.PosX + "f, " + VehList[i].Rplace.PosY + "f, " + VehList[i].Rplace.PosZ + "f);");
                PrintOutSyatem("ObRot.Add(new Vector3(" + VehList[i].Rplace.RotX + "f, " + VehList[i].Rplace.RotY + "f, " + VehList[i].Rplace.RotZ + "f);");
                if (VehList[i].Sattach != "")
                {
                    PrintOutSyatem("//------Attachto; " + VehList[i].Sattach + "");
                    PrintOutSyatem("AttPos.Add(new Vector3(" + VehList[i].RattachPlace.PosX + "f, " + VehList[i].RattachPlace.PosY + "f, " + VehList[i].RattachPlace.PosZ + "f);");
                    PrintOutSyatem("AttRot.Add(new Vector3(" + VehList[i].RattachPlace.RotX + "f, " + VehList[i].RattachPlace.RotY + "f, " + VehList[i].RattachPlace.RotZ + "f);");
                }
                PrintOutSyatem("//--------------------");
            }

            PrintOutSyatem("//-------Peds-------");
            PrintOutSyatem("List<string> PedName = new List<string>();");
            PrintOutSyatem("List<int> PedHash = new List<int>();");
            PrintOutSyatem("List<Vector3> PedPos = new List<Vector3>();");
            PrintOutSyatem("List<Vector3> PedRot = new List<Vector3>();");
            PrintOutSyatem("List<Vector3> PedAttPos = new List<Vector3>();");
            PrintOutSyatem("List<Vector3> PedAttRot = new List<Vector3>();");

            for (int i = 0; i < PedList.Count(); i++)
            {
                PrintOutSyatem("//Ref;" + PedList[i].SDesNum + "");
                PrintOutSyatem("ObName.Add(\"" + PedList[i].Sname + "\");");
                PrintOutSyatem("ObHash.Add(" + PedList[i].Shash + ");");
                PrintOutSyatem("ObPos.Add(new Vector3(" + PedList[i].Rplace.PosX + "f, " + PedList[i].Rplace.PosY + "f, " + PedList[i].Rplace.PosZ + "f);");
                PrintOutSyatem("ObRot.Add(new Vector3(" + PedList[i].Rplace.RotX + "f, " + PedList[i].Rplace.RotY + "f, " + PedList[i].Rplace.RotZ + "f);");
                if (PedList[i].Sattach != "")
                {
                    PrintOutSyatem("//------Attachto; " + PedList[i].Sattach + "");
                    PrintOutSyatem("AttPos.Add(new Vector3(" + PedList[i].RattachPlace.PosX + "f, " + PedList[i].RattachPlace.PosY + "f, " + PedList[i].RattachPlace.PosZ + "f);");
                    PrintOutSyatem("AttRot.Add(new Vector3(" + PedList[i].RattachPlace.RotX + "f, " + PedList[i].RattachPlace.RotY + "f, " + PedList[i].RattachPlace.RotZ + "f);");
                }
                PrintOutSyatem("//--------------------");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog MyDialog = new OpenFileDialog();
            MyDialog.Title = "Select File";
            MyDialog.InitialDirectory = sXMLPath;
            MyDialog.Filter = "All files (*.*)|*.*|Xml file (*.Xml)|*.Xml";
            MyDialog.FilterIndex = 2;
            MyDialog.ShowDialog();
            if (MyDialog.FileName != "")
                textBox1.Text = MyDialog.FileName;
            else
                textBox1.Text = "Nothing Selected";

            sMayFile = textBox1.Text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (sMayFile != "" || sMayFile != "Nothing Selected")
            {
                int iPath = sMayFile.LastIndexOf("/") + 1;
                string FilePath = sMayFile.Substring(0, iPath);

                Form2 testDialog = new Form2();
                testDialog.ShowDialog(this);

                while (!testDialog.bisReady)
                { }

                if (testDialog.sNamed != "")
                {
                    sOutputFile = FilePath + testDialog.sNamed + ".txt";

                    testDialog.Dispose();
                    SpoonConversion(sMayFile);
                }
            }
        }
    }
}
