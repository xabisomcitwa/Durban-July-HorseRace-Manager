using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCTXAB001_W1
{
    public partial class Form1 : Form
    {
        private July roster;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            roster = new July();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            int age;
            int height;
            double t1, t2, t3;
            double[] times = new double[3];


            if (double.TryParse(txtTime1.Text, out t1))
            {
                times[0] = t1;

                if (double.TryParse(txtTime2.Text, out t2))
                {
                    times[1] = t2;

                    if (double.TryParse(txtTime3.Text, out t3))
                    {
                        times[2] = t3;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Time 3 Format!");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Time 2 Format!");
                }
            }
            else
            {
                MessageBox.Show("Incorrect Time 1 Format!");
            }

            Horse racer;
            if (int.TryParse(txtAge.Text, out age)){
                if (int.TryParse(txtHeight.Text, out height))
                {
                    racer = new Horse(txtName.Text, age, height, times);
                    roster.addHorse(racer);
                    this.Display();
                }
                else
                {
                    MessageBox.Show("Incorrect Height Format!");
                }
            }
            else
            {
                MessageBox.Show("Incorrect Age Format!");
            }

        }

        private void btPredict_Click(object sender, EventArgs e)
        {
            string fav = (roster.Favourite()).HorseDetails();
            string line1 = fav.Substring(0,fav.IndexOf("Average"));
            string line2 = fav.Substring(fav.IndexOf("Average"));
            MessageBox.Show("The next winner will be:\n" + line1.Replace("\t", "   ") + "\n" + line2, "Favourite", MessageBoxButtons.OK);
        }

        private void Display()
        {
            roster.DisplayRoster(txtRoster);
        }
    }
}
