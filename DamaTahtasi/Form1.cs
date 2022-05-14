using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamaTahtasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] btns = new Button[8, 8];

            int left = 0;
            int top = 0;

            int a = 1;
            while (a <= btns.GetUpperBound(0))
            {
                for (int i = 0; i < btns.GetUpperBound(1); i++)
                {
                    btns[a, i] = new Button();
                    btns[a, i].Width = 50;
                    btns[a, i].Height = 50;
                    btns[a, i].Left = left;
                    btns[a, i].Top = top;
                    left = left + 50;
                    this.Controls.Add(btns[a, i]);

                    if ((a + i) % 2 == 0)
                    {
                        btns[a, i].BackColor = Color.Red;
                    }
                    else
                    {
                        btns[a, i].BackColor = Color.White;
                    }

                }



                left = 0;
                top = top + 50;

                a++;
            }
        }
    }
}
