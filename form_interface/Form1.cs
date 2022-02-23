using form_interface.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Mercedes mc = new Mercedes();
                mc.fiyat = 3000;
                mc.hiz = 500;
                mc.Gosterge(300);
                listBox1.Items.Add(mc.BilgiVer());
            }
            else if (radioButton2.Checked)
            {
                Bmw b = new Bmw();
                b.fiyat = 30000;
                b.hiz = 600;
                b.AracPuan(double.Parse(textBox3.Text));
                listBox1.Items.Add(b.BilgiVer());
            }
        }
    }
}
