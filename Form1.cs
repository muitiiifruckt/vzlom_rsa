using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vzlom_rsa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BigInteger p, q;
        int potoks,rounds ;
        string date;
 
         private void button_run_factorizachiya_Click(object sender, EventArgs e)
        {
            richTextBox_p.Text = "";
            richTextBox_q.Text = "";
            label_time.Text = "0";

            DateTime date1 = DateTime.Now;
            crash_N();
            DateTime date2 = DateTime.Now;
            date = Convert.ToString(date2.Subtract(date1));
            label_time.Text = Convert.ToString(date2.Subtract(date1));
            rounds++;
            listBox1.Items.Add(rounds + "  " + date + "    potoks :" + potoks);



        }
        private BigInteger f(BigInteger x, BigInteger n)
        {
            BigInteger rex = (x * x + 1) % n;
            return rex;
        }
        private void crash_N()
        {

            try
            {
                potoks = (int)numericUpDown1.Value;
                if (!BigInteger.TryParse(richTextBox_N.Text, out BigInteger N)) throw new Exception("incorrect num");
                if (N < 3) throw new Exception("out of range 2-99999999999999999999999");
                p = PollardRhoFactorization(N, potoks);
                q = N / p;
                richTextBox_p.Text = Convert.ToString(p);
                richTextBox_q.Text = Convert.ToString(q);

            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка: {e.Message}");
            }

        }

 
        private BigInteger gcd(BigInteger a, BigInteger b)
        {
            if (b == 0)
                return a;
            return gcd(b, a % b);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            rounds = 0;

        }

        private BigInteger PollardRhoFactorization(BigInteger n, int numThreads)
        {
            
            BigInteger x = 2, y = 2, d = 1;

            int rangeSize = (int)Math.Ceiling((double)n / numThreads);
            BigInteger[][] ranges = new BigInteger[numThreads][];
            for (int i = 0; i < numThreads; i++)
            {
                BigInteger start = i * rangeSize;
                BigInteger end = BigInteger.Min(start + rangeSize, n);
                ranges[i] = new BigInteger[] { start, end };
            }

            Thread[] threads = new Thread[numThreads];
            for (int i = 0; i < numThreads; i++)
            {
                int threadIndex = i;
                threads[i] = new Thread(() =>
                {
                    BigInteger start = ranges[threadIndex][0];
                    BigInteger end = ranges[threadIndex][1];    

                    BigInteger xi = x, yi = y;
                    while (d == 1)
                    {
                        xi = f(xi, n);
                        yi = f(f(yi, n), n);
                        d = gcd(BigInteger.Abs(xi - yi), n);

                    }

                    if (d != n)
                    {
                        x = xi;
                        y = yi;
                    }
                });
                threads[i].Start();
            }

            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            return d;
        }
    }


}
