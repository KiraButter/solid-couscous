using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            bool Test = true;
            long n = Convert.ToInt64(textBox1.Text);
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    Test = false;
                    break;
                }

            }
            if (Test)
            {
                label2.Text = "Простое число";
            }
            else
            {
                label2.Text = "Не простое число";
            }
            watch.Stop();
            MessageBox.Show(
            "Время выполнения программы в миллисекундах : " + watch.ElapsedMilliseconds + "мс.\r\n" +
            "Время выполнения программы в секундах : " + watch.Elapsed.Seconds + "сек.\r\n" +
            "Время выполнения программы в Тиках :" + watch.ElapsedTicks + "\r\n"
            );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            int a = Convert.ToInt32(textBox2.Text);
            int b = Convert.ToInt32(textBox3.Text);

            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            label3.Text = "Нод: " + Convert.ToString(a);

            watch.Stop();
            MessageBox.Show(
            "Время выполнения программы в миллисекундах : " + watch.ElapsedMilliseconds + "мс.\r\n" +
            "Время выполнения программы в секундах : " + watch.Elapsed.Seconds + "сек.\r\n" +
            "Время выполнения программы в Тиках :" + watch.ElapsedTicks + "\r\n"
            );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            int[] M = { 228845, 815212, 451948, 684317, 132002, 318541, 524138, 184172, 202092, 251881, 106997, 376752, 236218, 29498, 512749, 632655, 593035, 765626, 942477, 39591 };

            Array.Sort(M);

            for (int i = 0; i < M.Length; i++)
            {
                listBox1.Items.Add(M[i].ToString());
            }
            watch.Stop();
            MessageBox.Show(
            "Время выполнения программы в миллисекундах : " + watch.ElapsedMilliseconds + "мс.\r\n" +
            "Время выполнения программы в секундах : " + watch.Elapsed.Seconds + "сек.\r\n" +
            "Время выполнения программы в Тиках :" + watch.ElapsedTicks + "\r\n"
            );
        }
    }
}
