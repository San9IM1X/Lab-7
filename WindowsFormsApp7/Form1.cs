using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] mas = new int[12];
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rand = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rand.Next(-50, 50);
                listBox1.Items.Add("Mas [" + i.ToString() + "] = " + mas[i].ToString());
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int s = 0;
            listBox2.Items.Clear();
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] % 2 == 0)
                    s += mas[i];
            }
            listBox2.Items.Add("Сумма  равна "+ s.ToString());
        }
    }
}