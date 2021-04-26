using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_コピペ_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.TabName1;
            textBox2.Text = Properties.Settings.Default.TabName2;
            textBox3.Text = Properties.Settings.Default.TabName3;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.TabName1 = textBox1.Text;
            Properties.Settings.Default.TabName2 = textBox2.Text;
            Properties.Settings.Default.TabName3 = textBox3.Text;

            Properties.Settings.Default.Save();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
