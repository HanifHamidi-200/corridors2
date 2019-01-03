using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLIP
{
    public partial class Form1 : Form
    {
        private void fShow(int nItem)
        {
            groupBox1.Visible = false;
            fra2.Visible = false;
            fra3.Visible = false;

            switch (nItem)
            {
                case 1:
                    groupBox1.Visible = true;
                    break;
                case 2:
                    fra2.Visible = true;
                    break;
                default:
                    fra3.Visible = true;
                    break;
            }
        }
        public Form1()
        {
            InitializeComponent();
            fra2.Left = groupBox1.Left;
            fra2.Top = groupBox1.Top;
            fra3.Left = groupBox1.Left;
            fra3.Top = groupBox1.Top;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nValue = rnd1.Next(1, 4);

            fShow(nValue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fShow(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fShow(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fShow(3);
        }
    }
}
