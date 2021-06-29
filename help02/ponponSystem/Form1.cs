using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ponponSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtRead.Text = @"12345F    00000199887766554433221100
12345F102100000199887766554433221100
12345L102100000199887766554433221100
";
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
           
        }

    }
}
