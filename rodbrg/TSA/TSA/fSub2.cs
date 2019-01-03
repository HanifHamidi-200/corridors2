using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSA
{
    public partial class fSub2 : Form
    {
        private List<String> _name = new List<string> { null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<String> _tsa = new List<string> { null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<int> _length = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private int nNumber;

        private void fReset()
        {
            Random rnd1 = new Random();
            char sLetter1, sLetter2;
            String sText;

            for (int i = 1; i <= 14; i++)
            {
                sLetter1 = (char)(rnd1.Next(1, 27) + 64 );
                sLetter2 = (char)(rnd1.Next(1, 27) + 64 );
                sText = Convert.ToString(sLetter1) + Convert.ToString(sLetter2);
                _name[i - 1] = sText;
                sText = null;
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    sText = sText + "T";
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    sText = sText + "S";
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    sText = sText + "A";
                }
                _tsa[i - 1] = sText;
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _length[i - 1] = 0;
                }
                else
                {
                    _length[i - 1] = rnd1.Next(1, 4001);
                }
            }

            fUpdateDisplay();
        }

        private void fUpdateDisplay()
        {
            btn11.Text = _name[0];
            btn12.Text = _name[1];
            btn13.Text = _name[2];
            btn14.Text = _name[3];
            btn15.Text = _name[4];
            btn16.Text = _name[5];
            btn17.Text = _name[6];
            btn18.Text = _name[7];
            btn19.Text = _name[8];
            btn1a.Text = _name[9];
            btn1b.Text = _name[10];
            btn1c.Text = _name[11];
            btn1d.Text = _name[12];
            btn1e.Text = _name[13];

            btn21.Text = _tsa[0];
            btn22.Text = _tsa[1];
            btn23.Text = _tsa[2];
            btn24.Text = _tsa[3];
            btn25.Text = _tsa[4];
            btn26.Text = _tsa[5];
            btn27.Text = _tsa[6];
            btn28.Text = _tsa[7];
            btn29.Text = _tsa[8];
            btn2a.Text = _tsa[9];
            btn2b.Text = _tsa[10];
            btn2c.Text = _tsa[11];
            btn2d.Text = _tsa[12];
            btn2e.Text = _tsa[13];

            btn31.Text = Convert.ToString(_length[0]);
            btn32.Text = Convert.ToString(_length[1]);
            btn33.Text = Convert.ToString(_length[2]);
            btn34.Text = Convert.ToString(_length[3]);
            btn35.Text = Convert.ToString(_length[4]);
            btn36.Text = Convert.ToString(_length[5]);
            btn37.Text = Convert.ToString(_length[6]);
            btn38.Text = Convert.ToString(_length[7]);
            btn39.Text = Convert.ToString(_length[8]);
            btn3a.Text = Convert.ToString(_length[9]);
            btn3b.Text = Convert.ToString(_length[10]);
            btn3c.Text = Convert.ToString(_length[11]);
            btn3d.Text = Convert.ToString(_length[12]);
            btn3e.Text = Convert.ToString(_length[13]);

        }
        public fSub2()
        {
            InitializeComponent();
        }

        private void fSub2_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
