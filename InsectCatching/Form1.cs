using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsectCatching
{
    public partial class Form1 : Form
    {
        private Insect[] insects;
        private Tonbo tonbo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tonbo = new Tonbo(this);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tonbo.Move();
        }
    }
}
