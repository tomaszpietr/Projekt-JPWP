using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Gra
{
    public partial class Tryb2 : Form
    {
        int a, b, c;
        int pozycja;
        bool goup, godown;
        int punkty = 0;
        bool start = false;
        public Tryb2()
        {
            InitializeComponent();
            this.Text = "Tabliczka mnożenia: Wyścig z czasem - tryb 2";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            PobierzRekord();
            label1.Text = "Zdobyte punkty: " + punkty;
        }

        private void Tryb2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && start == false)
            {
                label8.Hide();
                start = true;
                losujLiczby();
                timer1.Enabled = true;
                timer2.Enabled = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
            }
        }

        private void Tryb2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Tryb2_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (goup && hero.Location.Y >= 0)
            {
               hero.Top -= 15;
            }
            if (godown && hero.Location.Y <= 422)
            {
               hero.Top += 15;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel2.Left -= 10;
            Zderzenie();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        void PobierzRekord()
        {
            int rekord;
            string sciezka = "rekord2.txt";
            string zawartoscPliku = File.ReadAllText(sciezka);
            int.TryParse(zawartoscPliku, out rekord);
            label6.Text = "Twój rekord:\n" + rekord;
        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            if (menu_panel.Visible == false)
            {
                menu_panel.Show();
                if (start == true)
                {
                    TimersOFF();
                }
            }
            else if (menu_panel.Visible == true)
            {
                menu_panel.Hide();
                if (start == true)
                {
                    TimersON();
                }
            }
        }

        private void kontynnuj_button_Click(object sender, EventArgs e)
        {
            menu_panel.Hide();
            if (start == true)
            {
                TimersON();
            }
        }

        private void restart_button_Click(object sender, EventArgs e)
        {
            Tryb2 tryb2 = new Tryb2();
            tryb2.StartPosition = FormStartPosition.Manual;
            tryb2.Location = new Point(this.Location.X, this.Location.Y);
            tryb2.Show();
            this.Hide();
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            Menu home = new Menu();
            home.StartPosition = FormStartPosition.Manual;
            home.Location = new Point(this.Location.X, this.Location.Y);
            home.Show();
            this.Hide();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void losujLiczby() //losowanie równania i liczb które będą się przesuwać oraz losowanie pozycji poprawnego rozwiązania
        {
            Random rnd = new Random();
            a = rnd.Next(1, 10);
            b = rnd.Next(1, 10);
            c = a * b;
            label7.Text = a + " x " + b;
            liczba1.Text = "" + rnd.Next(1,100) + "";
            liczba2.Text = "" + rnd.Next(1,100) + "";
            liczba3.Text = "" + rnd.Next(1,100) + "";
            liczba4.Text = "" + rnd.Next(1,100) + "";
            liczba5.Text = "" + rnd.Next(1,100) + "";
            pozycja = rnd.Next(1, 10);
            switch ((pozycja % 5) + 1)
            {
                case 1:
                    liczba1.Text = "" + c + "";
                    break;
                case 2:
                    liczba2.Text = "" + c + "";
                    break;
                case 3:
                    liczba3.Text = "" + c + "";
                    break;
                case 4:
                    liczba4.Text = "" + c + "";
                    break;
                case 5:
                    liczba5.Text = "" + c + "";
                    break;
            }
        }
        void Zderzenie()
        {
            if (panel2.Location.X - hero.Location.X < 40)
            {
                SprawdzPoprawnosc(liczba1, 1);
                SprawdzPoprawnosc(liczba2, 2);
                SprawdzPoprawnosc(liczba3, 3);
                SprawdzPoprawnosc(liczba4, 4);
                SprawdzPoprawnosc(liczba5, 5);
            }    
        }
        void SprawdzPoprawnosc(Label liczba, int poz)
        {
            if (hero.Bounds.IntersectsWith(liczba.Bounds))
            {
                if ((pozycja % 5) + 1 == poz)
                {
                    losujLiczby();
                    panel2.Location = new Point(859, 3);
                    punkty++;
                    label1.Text = "Zdobyte punkty: " + punkty;
                    timer2.Interval = timer2.Interval - 2;
                }
                else
                {
                    label8.Text = "Koniec gry\nZdobyte punkty: " + punkty;
                    label8.Show();
                    TimersOFF();
                    ZapiszRekord();
                }
            }
        }
        void ZapiszRekord()
        {
            int rekord;
            string sciezka = "rekord2.txt";
            string zawartoscPliku = File.ReadAllText(sciezka);
            int.TryParse(zawartoscPliku, out rekord);
            if (punkty > rekord)
            {
                File.WriteAllText("rekord2.txt", null);
                File.WriteAllText("rekord2.txt", punkty.ToString());
            }
        }
        void TimersOFF()
        {
            timer1.Stop();
            timer2.Stop();
        }
        void TimersON()
        {
            timer1.Start();
            timer2.Start();
        }
    }
}