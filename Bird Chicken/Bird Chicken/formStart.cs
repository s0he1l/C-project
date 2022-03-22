using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bird_Chicken
{
    public partial class formStart : Form
    {
        public formStart()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Helpform hf = new Helpform();
            hf.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formStart fs = new formStart();
            Form1 ff = new Form1();
            fs.Close();
            ff.ShowDialog();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
