using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Gra
{
    public partial class Tryb1 : Form
    {
        int wynik;
        int a, b, c, d, ab, cd;
        String rownanie;
        bool start = false;
        int czas = 2000;
        int punkty = 0;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public Tryb1() //okno gry z trybem 1
        {
            InitializeComponent();
            this.Text = "Tabliczka mnożenia: Wyścig z czasem - tryb 1";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            panel2.Parent = this;
            panel1.Parent = this;
            label8.Parent = this;
            panel2.Hide();
            PobierzRekord();
            label7.Text = "Zdobyte punkty: " + punkty;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (start == true && a * b == ab && c * d == cd)
                {
                    punkty += 1;
                    label7.Text = "Zdobyte punkty: " + punkty;
                }
                if (start == false)
                {
                    label8.Hide();
                    LosujRown();
                    WyswRown();
                    LosujRozw();
                    WyswRozw();
                    start = true;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        void WyswRown()
        {
            timer.Interval = czas;
            timer.Tick += new EventHandler(timer_Rown);
            timer.Start();
        }
        void WyswRozw()
        {
            timer.Interval = czas;
            timer.Tick += new EventHandler(timer_Tick1);
            timer.Start();
        }
        private void timer_Rown(object sender, EventArgs e)
        {
            LosujRown();
        }
        private void timer_Tick1(object sender, EventArgs e)
        {
            LosujRozw();
        }

        void LosujRown()
        {
            Random rnd = new Random();
            a = rnd.Next(1, 10);
            b = rnd.Next(1, 10);
            c = rnd.Next(1, 10);
            d = rnd.Next(1, 10);
            while (a == b || a == c || a == d || b == c || b == d || c == d) //ustawienie, aby każda z 4 liczb tworzące równania nie była równa innej
            {                                                                //w celu zróżnicowania równań
                a = rnd.Next(1, 10);
                b = rnd.Next(1, 10);
                c = rnd.Next(1, 10);
                d = rnd.Next(1, 10);
            }
            label1.Text = a + " x " + b;
            label3.Text = c + " x " + d;

        }

        void LosujRozw()
        {
            ab = a * b;
            cd = c * d;
            label2.Text = " " + ab + " ";
            label4.Text = " " + cd + " ";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //kontynuuj
        {
            panel2.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e) //restart
        {
            Tryb1 tryb1 = new Tryb1();
            tryb1.StartPosition = FormStartPosition.Manual;
            tryb1.Location = new Point(this.Location.X, this.Location.Y);
            tryb1.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) //powrót do home
        {
            Menu home = new Menu();
            home.StartPosition = FormStartPosition.Manual;
            home.Location = new Point(this.Location.X, this.Location.Y);
            home.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e) //wyjście
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e) //menu
        {
            if (panel2.Visible == false)
            {
                panel2.Show();
                timer.Stop();
            }
            else if (panel2.Visible == true)
            {
                panel2.Hide();
                timer.Start();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        public void PobierzRekord()
        {
            int rekord;
            string sciezka = "rekord1.txt";
            string zawartoscPliku = File.ReadAllText(sciezka);
            int.TryParse(zawartoscPliku, out rekord);
            label6.Text = "Twój rekord: " + rekord;
        }
    }
}