using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int eded1, eded2;

            if (int.TryParse(txtA.Text, out eded1) && int.TryParse(txtB.Text, out eded2))
            {
                int netice = eded1 + eded2;
                label1.Text = "Nəticə" + netice.ToString();
            }
            else
            {
                label1.Text = "Zəhmət olmasa yalnız rəqəm daxil edin";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int eded1, eded2;

            if (int.TryParse(txtA.Text, out eded1) && int.TryParse(txtB.Text, out eded2))
            {
                int netice = eded1 - eded2;
                label1.Text = "Nəticə" + netice.ToString();
            }
            else
            {
                label1.Text = "Zəhmət olmasa yalnız rəqəm daxil edin";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int eded1, eded2;

            if (int.TryParse(txtA.Text, out eded1) && int.TryParse(txtB.Text, out eded2))
            {
                int netice = eded1 * eded2;
                label1.Text = "Nəticə" + netice.ToString();
            }
            else
            {
                label1.Text = "Zəhmət olmasa yalnız rəqəm daxil edin";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int eded1, eded2;

            if (int.TryParse(txtA.Text, out eded1) && int.TryParse(txtB.Text, out eded2))
            {
                if (eded2 == 0)
                {
                    MessageBox.Show("Sıfıra bölmək olmaz", "Xəta");
                }
                else
                {
                    int netice = eded1 / eded2;
                    label1.Text = "Nəticə" + netice.ToString();
                }
            }
            else
            {
                label1.Text = "Zəhmət olmasa yalnız rəqəm daxil edin";
            }
        }
    }
}
