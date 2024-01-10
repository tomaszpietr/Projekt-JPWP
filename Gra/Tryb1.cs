using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Gra
{
    /// <summary>
    /// Okno z trybem 1 gry
    /// </summary>
    public partial class Tryb1 : Form
    {
        /// <summary>
        /// Ilość pozostałych szans
        /// </summary>
        int szanse_id = 3;
        /// <summary>
        /// Pozycja poprawnego rozwiązania
        /// </summary>
        int pozycja;
        /// <summary>
        /// Licznik ile zostało wyświetlonych rozwiązań
        /// </summary>
        int poz_licznik = 1;
        /// <summary>
        /// Pierwsza liczba pierwszego równania
        /// </summary>
        int a;
        /// <summary>
        /// Druga liczba pierwszego równania
        /// </summary>
        int b;
        /// <summary>
        /// Pierwsza liczba drugiego równania
        /// </summary>
        int c;
        /// <summary>
        /// Druga liczba drugiego równania
        /// </summary>
        int d;
        /// <summary>
        /// Rozwiązanie pierwsze
        /// </summary>
        int ab;
        /// <summary>
        /// Rozwiązanie drugie
        /// </summary>
        int cd;
        /// <summary>
        /// Informacja, czy nastąpił start gry
        /// </summary>
        bool start = false;
        /// <summary>
        /// Liczba zdobytych punktów
        /// </summary>
        int punkty = 0;
        public Tryb1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Text = "Tabliczka mnożenia: Wyścig z czasem - tryb 1";
            this.MaximizeBox = false;
            szanse.BackColor = Color.FromArgb(0, 0, 0, 0);
            game_panel.BackColor = Color.FromArgb(0, 0, 0, 0);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.BackgroundImage = Properties.Resources.tlo1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            menu_panel.Parent = this;
            game_panel.Parent = this;
            info.Parent = this;
            menu_panel.Hide();
            PobierzRekord();
            punkty_info.Text = "Zdobyte punkty: " + punkty;
        }
        /// <summary>
        /// Losuje równania
        /// </summary>
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
            rown1.Text = a + " x " + b;
            rown2.Text = c + " x " + d;
        }
        /// <summary>
        /// Losuje liczby w miejscach rozwiązań
        /// </summary>
        void LosujRozw()
        {
            Random rnd = new Random();
            ab = rnd.Next(1, 100);
            cd = rnd.Next(1, 100);
            rozw1.Text = "" + ab + "";
            rozw2.Text = "" + cd + "";
        }
        /// <summary>
        /// Wyświetla poprawne rozwiązania w miejscach rozwiązań
        /// </summary>
        void WyswRozw()
        {
            ab = a * b;
            cd = c * d;
            rozw1.Text = "" + ab + "";
            rozw2.Text = "" + cd + "";
        }
        /// <summary>
        /// Timer potrzebny do zmieniania równań i rozwiązań
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pozycja == poz_licznik)
            {
                WyswRozw();
                Random rnd = new Random();
                pozycja = rnd.Next(2, 8);
                poz_licznik = 1;
            }
            else
            {
                LosujRozw();
                poz_licznik++;
            }

            if (punkty >= 30)
            {
                timer1.Interval = 150;
            }
            else if (punkty >= 27)
            {
                timer1.Interval = 200;
            }
            else if (punkty >= 24)
            {
                timer1.Interval = 250;
            }
            else if (punkty >= 21)
            {
                timer1.Interval = 300;
            }
            else if (punkty >= 18)
            {
                timer1.Interval = 350;
            }
            else if (punkty >= 15)
            {
                timer1.Interval = 400;
            }
            else if (punkty >= 12)
            {
                timer1.Interval = 525;
            }
            else if (punkty >= 9)
            {
                timer1.Interval = 650;
            }
            else if (punkty >= 6)
            {
                timer1.Interval = 700;
            }
            else if (punkty >= 3)
            {
                timer1.Interval = 1000;
            }
        }
        /// <summary>
        /// Zdarzenia po naciśnięciu klawisza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tryb1_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Space)
                {
                    if (!start && !menu_panel.Visible)
                    {
                        info.Hide();
                        LosujRown();
                        LosujRozw();
                        start = true;
                        Random rnd = new Random();
                        pozycja = rnd.Next(2, 8);
                        timer1.Enabled = true;
                    }
                    else if (start && timer1.Enabled)
                    {
                        if (a * b == ab && c * d == cd)
                        {
                            punkty++;
                            punkty_info.Text = "Zdobyte punkty: " + punkty;
                            LosujRown();
                        }
                        else
                        {

                            if (szanse_id == 3)
                            {
                                szanse_id = 2;
                                szanse.Image = Gra.Properties.Resources.szanse2;
                                LosujRown();
                            }
                            else if (szanse_id == 2)
                            {
                                szanse_id = 1;
                                szanse.Image = Gra.Properties.Resources.szanse1;
                                LosujRown();
                            }
                            else if (szanse_id == 1)
                            {
                                szanse.Image = Gra.Properties.Resources.szanse0;
                                timer1.Stop();
                                info.Text = "Koniec gry\nZdobyte punkty: " + punkty;
                                info.Show();
                                timer1.Enabled = false;
                                ZapiszRekord();
                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Ukrycie MENU i kontynuacja gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void kontynnuj_Click(object sender, EventArgs e)
        {
            menu_panel.Enabled = false;
            menu_panel.Hide();
            timer1.Enabled = true;
        }
        /// <summary>
        /// Restart gry (w tym samym trybie)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void restart_Click(object sender, EventArgs e)
        {
            Tryb1 tryb1 = new Tryb1();
            tryb1.StartPosition = FormStartPosition.Manual;
            tryb1.Location = new Point(this.Location.X, this.Location.Y);
            tryb1.Show();
            this.Hide();
        }
        /// <summary>
        /// Wyświetlenie/Schowanie MENU gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu_Click(object sender, EventArgs e)
        {
            if (menu_panel.Visible == false)
            {
                menu_panel.Enabled = true;
                menu_panel.Show();
                timer1.Stop();
            }
            else if (menu_panel.Visible == true)
            {
                menu_panel.Enabled = false;
                menu_panel.Hide();
                timer1.Start();
            }
        }
        /// <summary>
        /// Wyjście z gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Powrót do ekranu głównego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void powrot_Click(object sender, EventArgs e)
        {
            Menu home = new Menu();
            home.StartPosition = FormStartPosition.Manual;
            home.Location = new Point(this.Location.X, this.Location.Y);
            home.Show();
            this.Hide();
        }

        /// <summary>
        /// Pobranie rekordu z pliku rekord1.txt
        /// </summary>
        void PobierzRekord()
        {
            int rekord;
            string sciezka = "rekord1.txt";
            string zawartoscPliku = File.ReadAllText(sciezka);
            int.TryParse(zawartoscPliku, out rekord);
            rekord_info.Text = "Twój rekord: " + rekord;
        }
        /// <summary>
        /// Zapisanie rekordu do pliku rekord1.txt
        /// </summary>
        void ZapiszRekord()
        {
            int rekord;
            string sciezka = "rekord1.txt";
            string zawartoscPliku = File.ReadAllText(sciezka);
            int.TryParse(zawartoscPliku, out rekord);
            if (punkty > rekord)
            {
                File.WriteAllText("rekord1.txt", null);
                File.WriteAllText("rekord1.txt", punkty.ToString());
            }
        }
    }
}