using MenyooSpoonConvert.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenyooSpoonConvert
{
    public partial class Form4 : Form
    {
        public XYZAdjust Adj = null;

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adj = new XYZAdjust();
            decimal ValX = numericUpDown1.Value;
            decimal ValY = numericUpDown2.Value;
            decimal ValZ = numericUpDown3.Value;

            Adj.PosX = ValX;
            Adj.PosY = ValY;
            Adj.PosZ = ValZ;

            Close();
        }
    }
}
