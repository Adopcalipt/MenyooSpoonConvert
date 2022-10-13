using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenyooSpoonConvert.Classes;

namespace MenyooSpoonConvert
{
    public partial class Form3 : Form
    {
        public Form3Output MyOutPut = null;

        public Form3()
        {
            InitializeComponent();
            listBox1.SelectedIndex = 1;
            listBox2.SelectedIndex = 2;
            listBox3.SelectedIndex = 3;

            listBox4.SelectedIndex = 1;
            listBox5.SelectedIndex = 2;
            listBox6.SelectedIndex = 3;

            listBox7.SelectedIndex = 1;
            listBox8.SelectedIndex = 2;
            listBox9.SelectedIndex = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyOutPut = new Form3Output 
            {
                PropLine01 = textBox1.Text,
                PropLine02 = textBox2.Text,
                PropLine03 = textBox3.Text,
                PropText01 = textBox4.Text,
                PropText02 = textBox5.Text,
                PropText03 = textBox6.Text,
                PropText04 = textBox7.Text,

                PropT01 = listBox1.SelectedIndex,
                PropT02 = listBox2.SelectedIndex,
                PropT03 = listBox3.SelectedIndex,

                VehLine01 = textBox8.Text,
                VehLine02 = textBox9.Text,
                VehLine03 = textBox10.Text,
                VehText01 = textBox11.Text,
                VehText02 = textBox12.Text,
                VehText03 = textBox13.Text,
                VehText04 = textBox14.Text,

                VehT01 = listBox4.SelectedIndex,
                VehT02 = listBox5.SelectedIndex,
                VehT03 = listBox6.SelectedIndex,

                PedLine01 = textBox15.Text,
                PedLine02 = textBox16.Text,
                PedLine03 = textBox17.Text,
                PedText01 = textBox18.Text,
                PedText02 = textBox19.Text,
                PedText03 = textBox20.Text,
                PedText04 = textBox21.Text,

                PedT01 = listBox7.SelectedIndex,
                PedT02 = listBox8.SelectedIndex,
                PedT03 = listBox9.SelectedIndex
            };
            Close();
        }
        private XYZAdjust MyAdjusts()
        {
            XYZAdjust anXYZ = new XYZAdjust();
            Form4 testDialog = new Form4();
            testDialog.ShowDialog(this);

            while (testDialog.Adj == null)
            { }

            anXYZ = testDialog.Adj;
            testDialog.Dispose();

            return anXYZ;
        }
        private void CalcAjust(bool bPos, int iSet)
        {
            XYZAdjust ThisChange = MyAdjusts();
            if (iSet == 1)
            {
                if (bPos)
                {
                    Form1.PropAdj.PosX = ThisChange.PosX;
                    Form1.PropAdj.PosY = ThisChange.PosY;
                    Form1.PropAdj.PosZ = ThisChange.PosZ;
                }
                else
                {
                    Form1.PropAdj.RotX = ThisChange.PosX;
                    Form1.PropAdj.RotY = ThisChange.PosY;
                    Form1.PropAdj.RotZ = ThisChange.PosZ;
                }
            }
            else if (iSet == 2)
            {
                if (bPos)
                {
                    Form1.VehAdj.PosX = ThisChange.PosX;
                    Form1.VehAdj.PosY = ThisChange.PosY;
                    Form1.VehAdj.PosZ = ThisChange.PosZ;
                }
                else
                {
                    Form1.VehAdj.RotX = ThisChange.PosX;
                    Form1.VehAdj.RotY = ThisChange.PosZ;
                    Form1.VehAdj.RotZ = ThisChange.PosZ;
                }
            }
            else
            {
                if (bPos)
                {
                    Form1.PedAdj.PosX = ThisChange.PosX;
                    Form1.PedAdj.PosY = ThisChange.PosY;
                    Form1.PedAdj.PosZ = ThisChange.PosZ;
                }
                else
                {
                    Form1.PedAdj.RotX = ThisChange.PosX;
                    Form1.PedAdj.RotY = ThisChange.PosY;
                    Form1.PedAdj.RotZ = ThisChange.PosZ;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 2)
                CalcAjust(true, 1);
            else if (listBox1.SelectedIndex == 3)
                CalcAjust(false, 1);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == 2)
                CalcAjust(true, 1);
            else if (listBox2.SelectedIndex == 3)
                CalcAjust(false, 1);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex == 2)
                CalcAjust(true, 1);
            else if (listBox3.SelectedIndex == 3)
                CalcAjust(false, 1);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox4.SelectedIndex == 2)
                CalcAjust(true, 2);
            else if (listBox4.SelectedIndex == 3)
                CalcAjust(false, 2);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox5.SelectedIndex == 2)
                CalcAjust(true, 2);
            else if (listBox5.SelectedIndex == 3)
                CalcAjust(false, 2);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox6.SelectedIndex == 2)
                CalcAjust(true, 2);
            else if (listBox6.SelectedIndex == 3)
                CalcAjust(false, 2);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (listBox7.SelectedIndex == 2)
                CalcAjust(true, 3);
            else if (listBox7.SelectedIndex == 3)
                CalcAjust(false, 3);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (listBox8.SelectedIndex == 2)
                CalcAjust(true, 3);
            else if (listBox8.SelectedIndex == 3)
                CalcAjust(false, 3);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (listBox9.SelectedIndex == 2)
                CalcAjust(true, 3);
            else if (listBox9.SelectedIndex == 3)
                CalcAjust(false, 3);
        }
    }
}
