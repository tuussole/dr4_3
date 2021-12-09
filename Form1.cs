using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dr4_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateTriangle(Triangle figure)
        {
            var square = figure.Square();
            var perimeter = figure.Perimeter();

            MessageBox.Show(figure.ToString() + ". Perimeter " + perimeter + ", Square " + square);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rectular = new RectularTriangle
            {
                Side1 = 3,
                Side2 = 4,
                Angle = Math.PI / 2
            };
            CalculateTriangle(rectular);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var rectular = new IsoscelesTriangle
            {
                Side1 = 4,
                Side2 = 4,
                Angle = Math.PI / 4
            };
            CalculateTriangle(rectular);
        }
    }
}
