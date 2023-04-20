using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjHafta8_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        clsYilan yilan;
        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            yilan = new clsYilan(3,pnlOyun,lblPuan);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar)
            {
                case 'd':
                case 'D':
                    yilan.iYon = 1;
                    break;
                case 'a':
                case 'A':
                    yilan.iYon = 2;
                    break;
                case 's':
                case 'S':
                    yilan.iYon = 3;
                    break;
                case 'w':
                case 'W':
                    yilan.iYon = 4;
                    break;
            }
        }

        private void pnlOyun_Click(object sender, EventArgs e)
        {
            clsYem yem = new clsYem(pnlOyun);
        }

        private void pnlOyun_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
