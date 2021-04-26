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
    public partial class Form2 : Form
    {
        int buttonkind;
        int buttonNumber;
        public Form2()
        {
            InitializeComponent();
            Load1();
        }

        void Load1()
        {
            if (Properties.Settings.Default.ButtonKind == 1)
            {
                if (Properties.Settings.Default.ButtonNumber == 1)
                {
                    textBox1.Text = Properties.Settings.Default.Title1;
                    textBox2.Text = Properties.Settings.Default.Contents1;
                }
                else if (Properties.Settings.Default.ButtonNumber == 2)
                {
                    textBox1.Text = Properties.Settings.Default.Title2;
                    textBox2.Text = Properties.Settings.Default.Contents2;
                }
                else if (Properties.Settings.Default.ButtonNumber == 3)
                {
                    textBox1.Text = Properties.Settings.Default.Title3;
                    textBox2.Text = Properties.Settings.Default.Contents3;
                }
                else if (Properties.Settings.Default.ButtonNumber == 4)
                {
                    textBox1.Text = Properties.Settings.Default.Title4;
                    textBox2.Text = Properties.Settings.Default.Contents4;
                }
                else if (Properties.Settings.Default.ButtonNumber == 5)
                {
                    textBox1.Text = Properties.Settings.Default.Title5;
                    textBox2.Text = Properties.Settings.Default.Contents5;
                }
                else if (Properties.Settings.Default.ButtonNumber == 6)
                {
                    textBox1.Text = Properties.Settings.Default.Title6;
                    textBox2.Text = Properties.Settings.Default.Contents6;
                }
                else if (Properties.Settings.Default.ButtonNumber == 7)
                {
                    textBox1.Text = Properties.Settings.Default.Title7;
                    textBox2.Text = Properties.Settings.Default.Contents7;
                }
                else if (Properties.Settings.Default.ButtonNumber == 8)
                {
                    textBox1.Text = Properties.Settings.Default.Title8;
                    textBox2.Text = Properties.Settings.Default.Contents8;
                }
                else if (Properties.Settings.Default.ButtonNumber == 9)
                {
                    textBox1.Text = Properties.Settings.Default.Title9;
                    textBox2.Text = Properties.Settings.Default.Contents9;
                }
                else if (Properties.Settings.Default.ButtonNumber == 10)
                {
                    textBox1.Text = Properties.Settings.Default.Title10;
                    textBox2.Text = Properties.Settings.Default.Contents10;
                }
            }
            else if (Properties.Settings.Default.ButtonKind == 2)
            {
                if (Properties.Settings.Default.ButtonNumber == 1)
                {
                    textBox1.Text = Properties.Settings.Default.Title11;
                    textBox2.Text = Properties.Settings.Default.Contents11;
                }
                else if (Properties.Settings.Default.ButtonNumber == 2)
                {
                    textBox1.Text = Properties.Settings.Default.Title12;
                    textBox2.Text = Properties.Settings.Default.Contents12;
                }
                else if (Properties.Settings.Default.ButtonNumber == 3)
                {
                    textBox1.Text = Properties.Settings.Default.Title13;
                    textBox2.Text = Properties.Settings.Default.Contents13;
                }
                else if (Properties.Settings.Default.ButtonNumber == 4)
                {
                    textBox1.Text = Properties.Settings.Default.Title14;
                    textBox2.Text = Properties.Settings.Default.Contents14;
                }
                else if (Properties.Settings.Default.ButtonNumber == 5)
                {
                    textBox1.Text = Properties.Settings.Default.Title15;
                    textBox2.Text = Properties.Settings.Default.Contents15;
                }
                else if (Properties.Settings.Default.ButtonNumber == 6)
                {
                    textBox1.Text = Properties.Settings.Default.Title16;
                    textBox2.Text = Properties.Settings.Default.Contents16;
                }
                else if (Properties.Settings.Default.ButtonNumber == 7)
                {
                    textBox1.Text = Properties.Settings.Default.Title17;
                    textBox2.Text = Properties.Settings.Default.Contents17;
                }
                else if (Properties.Settings.Default.ButtonNumber == 8)
                {
                    textBox1.Text = Properties.Settings.Default.Title18;
                    textBox2.Text = Properties.Settings.Default.Contents18;
                }
                else if (Properties.Settings.Default.ButtonNumber == 9)
                {
                    textBox1.Text = Properties.Settings.Default.Title19;
                    textBox2.Text = Properties.Settings.Default.Contents19;
                }
                else if (Properties.Settings.Default.ButtonNumber == 10)
                {
                    textBox1.Text = Properties.Settings.Default.Title20;
                    textBox2.Text = Properties.Settings.Default.Contents20;
                }
            }
            else if (Properties.Settings.Default.ButtonKind == 3)
            {
                if (Properties.Settings.Default.ButtonNumber == 1)
                {
                    textBox1.Text = Properties.Settings.Default.Title21;
                    textBox2.Text = Properties.Settings.Default.Contents21;
                }
                else if (Properties.Settings.Default.ButtonNumber == 2)
                {
                    textBox1.Text = Properties.Settings.Default.Title22;
                    textBox2.Text = Properties.Settings.Default.Contents22;
                }
                else if (Properties.Settings.Default.ButtonNumber == 3)
                {
                    textBox1.Text = Properties.Settings.Default.Title23;
                    textBox2.Text = Properties.Settings.Default.Contents23;
                }
                else if (Properties.Settings.Default.ButtonNumber == 4)
                {
                    textBox1.Text = Properties.Settings.Default.Title24;
                    textBox2.Text = Properties.Settings.Default.Contents24;
                }
                else if (Properties.Settings.Default.ButtonNumber == 5)
                {
                    textBox1.Text = Properties.Settings.Default.Title25;
                    textBox2.Text = Properties.Settings.Default.Contents25;
                }
                else if (Properties.Settings.Default.ButtonNumber == 6)
                {
                    textBox1.Text = Properties.Settings.Default.Title26;
                    textBox2.Text = Properties.Settings.Default.Contents26;
                }
                else if (Properties.Settings.Default.ButtonNumber == 7)
                {
                    textBox1.Text = Properties.Settings.Default.Title27;
                    textBox2.Text = Properties.Settings.Default.Contents27;
                }
                else if (Properties.Settings.Default.ButtonNumber == 8)
                {
                    textBox1.Text = Properties.Settings.Default.Title28;
                    textBox2.Text = Properties.Settings.Default.Contents28;
                }
                else if (Properties.Settings.Default.ButtonNumber == 9)
                {
                    textBox1.Text = Properties.Settings.Default.Title29;
                    textBox2.Text = Properties.Settings.Default.Contents29;
                }
                else if (Properties.Settings.Default.ButtonNumber == 10)
                {
                    textBox1.Text = Properties.Settings.Default.Title30;
                    textBox2.Text = Properties.Settings.Default.Contents30;
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonkind = Properties.Settings.Default.ButtonKind;
            buttonNumber = Properties.Settings.Default.ButtonNumber;

            if (buttonkind == 1)
            {
                if (buttonNumber == 1)
                {
                    Properties.Settings.Default.Title1 = textBox1.Text;
                    Properties.Settings.Default.Contents1 = textBox2.Text;
                }
                else if (buttonNumber == 2)
                {
                    Properties.Settings.Default.Title2 = textBox1.Text;
                    Properties.Settings.Default.Contents2 = textBox2.Text;

                }
                else if (buttonNumber == 3)
                {
                    Properties.Settings.Default.Title3 = textBox1.Text;
                    Properties.Settings.Default.Contents3 = textBox2.Text;

                }
                else if (buttonNumber == 4)
                {
                    Properties.Settings.Default.Title4 = textBox1.Text;
                    Properties.Settings.Default.Contents4 = textBox2.Text;

                }
                else if (buttonNumber == 5)
                {
                    Properties.Settings.Default.Title5 = textBox1.Text;
                    Properties.Settings.Default.Contents5 = textBox2.Text;

                }
                else if (buttonNumber == 6)
                {
                    Properties.Settings.Default.Title6 = textBox1.Text;
                    Properties.Settings.Default.Contents6 = textBox2.Text;

                }
                else if (buttonNumber == 7)
                {
                    Properties.Settings.Default.Title7 = textBox1.Text;
                    Properties.Settings.Default.Contents7 = textBox2.Text;

                }
                else if (buttonNumber == 8)
                {
                    Properties.Settings.Default.Title8 = textBox1.Text;
                    Properties.Settings.Default.Contents8 = textBox2.Text;

                }
                else if (buttonNumber == 9)
                {
                    Properties.Settings.Default.Title9 = textBox1.Text;
                    Properties.Settings.Default.Contents9 = textBox2.Text;

                }
                else if (buttonNumber == 10)
                {
                    Properties.Settings.Default.Title10 = textBox1.Text;
                    Properties.Settings.Default.Contents10 = textBox2.Text;

                }
            }
            else if (buttonkind == 2)
            {
                if (buttonNumber == 1)
                {
                    Properties.Settings.Default.Title11 = textBox1.Text;
                    Properties.Settings.Default.Contents11 = textBox2.Text;
                }
                else if (buttonNumber == 2)
                {
                    Properties.Settings.Default.Title12 = textBox1.Text;
                    Properties.Settings.Default.Contents12 = textBox2.Text;

                }
                else if (buttonNumber == 3)
                {
                    Properties.Settings.Default.Title13 = textBox1.Text;
                    Properties.Settings.Default.Contents13 = textBox2.Text;

                }
                else if (buttonNumber == 4)
                {
                    Properties.Settings.Default.Title14 = textBox1.Text;
                    Properties.Settings.Default.Contents14 = textBox2.Text;

                }
                else if (buttonNumber == 5)
                {
                    Properties.Settings.Default.Title15 = textBox1.Text;
                    Properties.Settings.Default.Contents15 = textBox2.Text;

                }
                else if (buttonNumber == 6)
                {
                    Properties.Settings.Default.Title16 = textBox1.Text;
                    Properties.Settings.Default.Contents16 = textBox2.Text;

                }
                else if (buttonNumber == 7)
                {
                    Properties.Settings.Default.Title17 = textBox1.Text;
                    Properties.Settings.Default.Contents17 = textBox2.Text;

                }
                else if (buttonNumber == 8)
                {
                    Properties.Settings.Default.Title18 = textBox1.Text;
                    Properties.Settings.Default.Contents18 = textBox2.Text;

                }
                else if (buttonNumber == 9)
                {
                    Properties.Settings.Default.Title19 = textBox1.Text;
                    Properties.Settings.Default.Contents19 = textBox2.Text;

                }
                else if (buttonNumber == 10)
                {
                    Properties.Settings.Default.Title20 = textBox1.Text;
                    Properties.Settings.Default.Contents20 = textBox2.Text;

                }

            }
            else if (buttonkind == 3)
            {
                if (buttonNumber == 1)
                {
                    Properties.Settings.Default.Title21 = textBox1.Text;
                    Properties.Settings.Default.Contents21 = textBox2.Text;
                }
                else if (buttonNumber == 2)
                {
                    Properties.Settings.Default.Title22 = textBox1.Text;
                    Properties.Settings.Default.Contents22 = textBox2.Text;

                }
                else if (buttonNumber == 3)
                {
                    Properties.Settings.Default.Title23 = textBox1.Text;
                    Properties.Settings.Default.Contents23 = textBox2.Text;

                }
                else if (buttonNumber == 4)
                {
                    Properties.Settings.Default.Title24 = textBox1.Text;
                    Properties.Settings.Default.Contents24 = textBox2.Text;

                }
                else if (buttonNumber == 5)
                {
                    Properties.Settings.Default.Title25 = textBox1.Text;
                    Properties.Settings.Default.Contents25 = textBox2.Text;

                }
                else if (buttonNumber == 6)
                {
                    Properties.Settings.Default.Title26 = textBox1.Text;
                    Properties.Settings.Default.Contents26 = textBox2.Text;

                }
                else if (buttonNumber == 7)
                {
                    Properties.Settings.Default.Title27 = textBox1.Text;
                    Properties.Settings.Default.Contents27 = textBox2.Text;

                }
                else if (buttonNumber == 8)
                {
                    Properties.Settings.Default.Title28 = textBox1.Text;
                    Properties.Settings.Default.Contents28 = textBox2.Text;

                }
                else if (buttonNumber == 9)
                {
                    Properties.Settings.Default.Title29 = textBox1.Text;
                    Properties.Settings.Default.Contents29 = textBox2.Text;

                }
                else if (buttonNumber == 10)
                {
                    Properties.Settings.Default.Title30 = textBox1.Text;
                    Properties.Settings.Default.Contents30 = textBox2.Text;

                }

            }
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
