using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameThreadGentarap
{
    public partial class Form1: Form
    {
        public bool PlayAgain = false;
        static Random r;
        static Thread player1thd;
        static Thread player2thd;
        static Thread player3thd;
        public static int countPlyr1;
        public static int countPlyr2;
        public static int countPlyr3;
        public Form1()
        {
            InitializeComponent();
            countPlyr1 = 0;
            countPlyr2 = 0;
            countPlyr3 = 0;
            r = new Random();
        }

        public static void Player1()
        {
            while (true)
            {
                Thread.Sleep(50);
                if (countPlyr1 > 650)
                {
                    player1thd.Abort();
                    break;
                }
                countPlyr1 = countPlyr1 + (1 + r.Next(6));
            }
        }
        public static void Player2()
        {
            while (true)
            {
                Thread.Sleep(50);
                if (countPlyr2 > 650)
                {
                    player2thd.Abort();
                    break;
                }
                countPlyr2 = countPlyr2 + (1 + r.Next(6));
            }
        }

        public static void Player3()
        {
            while (true)
            {
                Thread.Sleep(50);
                if (countPlyr3 > 650)
                {
                    player3thd.Abort();
                    break;
                }
                countPlyr3 = countPlyr3 + (1 + r.Next(6));

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            countPlyr1 = 0;
            countPlyr2 = 0;
            countPlyr3 = 0;

            player1thd = new Thread(new ThreadStart(Player1));
            player1thd.IsBackground = true;
            player1thd.Start();

            player2thd = new Thread(new ThreadStart(Player2));
            player2thd.IsBackground = true;
            player2thd.Start();

            player3thd = new Thread(new ThreadStart(Player3));
            player3thd.IsBackground = true;
            player3thd.Start();

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool check = false;
            if (countPlyr1 > 650)
            {
                timer1.Stop();
                countPlyr1 = 0;
                countPlyr2 = 0;
                countPlyr3 = 0;
                check = true;
                int i = Int32.Parse(lbP1.Text);
                i++;
                lbP1.Text = i.ToString();
                MessageBox.Show("Player 1 Win The Race!!");
            }
            else if (countPlyr2 > 650)
            {
                timer1.Stop();
                countPlyr1 = 0;
                countPlyr2 = 0;
                countPlyr3 = 0;
                check = true;
                int i = Int32.Parse(lbP2.Text);
                i++;
                lbP2.Text = i.ToString();
                MessageBox.Show("Player 2 Win The Race!!");
            }
            else if (countPlyr3 > 650)
            {
                timer1.Stop();
                countPlyr1 = 0;
                countPlyr2 = 0;
                countPlyr3 = 0;
                check = true;
                int i = Int32.Parse(lbP3.Text);
                i++;
                lbP3.Text = i.ToString();
                MessageBox.Show("Player1 3 Win The Race!!");
            }
            else if (check == false)
            {
                btP1.Left = countPlyr1;
                btP2.Left = countPlyr2;
                btP3.Left = countPlyr3;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
