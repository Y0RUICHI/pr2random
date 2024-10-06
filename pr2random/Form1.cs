using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr2random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            random_1();
        }
        private void random_1()
        {
            Random r = new Random();
            int a = r.Next(0, 1000);
            label1.Text = a.ToString();
        }

    }
}
