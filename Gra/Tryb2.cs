using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Gra
{
    /// <summary>
    /// Okno z trybem 2 gry
    /// </summary>
    public partial class Tryb2 : Form
    {
        /// <summary>
        /// Pierwsza liczba równania
        /// </summary>
        int a;
        /// <summary>
        /// Druga liczba równania
        /// </summary>
        int b;
        /// <summary>
        /// Iloczyn liczba a i b
        /// </summary>
        int c;
        /// <summary>
        /// Miejsce poprawnego rozwiązania
        /// </summary>
        int pozycja;
        /// <summary>
        /// Flaga informująca, czy postać ma iść w górę
        /// </summary>
        bool goup;
        /// <summary>
        /// Flaga informująća, czy postać ma iść w dół
        /// </summary>
        bool godown;
        /// <summary>
        /// Zdobyte punkty
        /// </summary>
        int punkty = 0;
        /// <summary>
        /// Informacja czy nastąpił start gry
        /// </summary>
        bool start = false;
        /// <summary>
        /// Ilość pozostałych szans
        /// </summary>
        int szanse_id = 3;
        /// <summary>
        /// Szybkość przesuwania się liczb
        /// </summary>
        int szybkosc = 10;
        public Tryb2()
        {
            InitializeComponent();
            this.Text = "Tabliczka mnożenia: Wyścig z czasem - tryb 2";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackgroundImage = Properties.Resources.tlo2;
            game_panel.BackColor = Color.FromArgb(0, 0, 0, 0);
            liczby.BackColor = Color.FromArgb(0, 0, 0, 0);
            hero.BackColor = Color.FromArgb(0, 0, 0, 0);
            szanse.BackColor = Color.FromArgb(0, 0, 0, 0);
            this.BackgroundImageLayout = ImageLayout.Stretch;
            PobierzRekord();
            punkty_info.Text = "Zdobyte punkty: " + punkty;
        }
        /// <summary>
        /// Funkcja mająca na celu zniwelowanie migotanie podczas ruchu postacią oraz przesuwania się liczb
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
               CreateParams handleparam = base.CreateParams;
               handleparam.ExStyle |= 0x02000000;
               return handleparam;
            }
        }
        /// <summary>
        /// Zdarzenia po naciśnięciu klawisza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tryb2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && start == false && !menu_panel.Visible)
            {
                info.Hide();
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
        /// <summary>
        /// Zdarzenia po puszczeniu klawisza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Timer potrzebny do ruchu postacią
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e) //timer potrzebny do ruchu postacią
        {
            if (goup && hero.Location.Y >= 110)
            {
               hero.Top -= 110;
            }
            if (godown && hero.Location.Y <= 422)
            {
               hero.Top += 110;
            }
        }
        /// <summary>
        /// Timer potrzebny do przesuwania się liczb
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e) //timer potrzebny do przesuwania się liczb
        {
            liczby.Left -= szybkosc;
            Zderzenie();
            if (punkty >= 35)
            {
                szybkosc = 39;
            }
            else if (punkty >= 33)
            {
                szybkosc = 37;
            }
            else if (punkty >= 30)
            {
                szybkosc = 35;
            }
            else if (punkty >= 27)
            {
                szybkosc = 33;
            }
            else if (punkty >= 24)
            {
                szybkosc = 31;
            }
            else if (punkty >= 21)
            {
                szybkosc = 29;
            }
            else if (punkty >= 18)
            {
                szybkosc = 27;
            }
            else if (punkty >= 15)
            {
                szybkosc = 25;
            }
            else if (punkty >= 12)
            {
                szybkosc = 23;
            }
            else if (punkty >= 9)
            {
                szybkosc = 21;
            }
            else if (punkty >= 6)
            {
                szybkosc = 18;
            }
            else if (punkty >= 3)
            {
                szybkosc = 15;
            }
        }
        /// <summary>
        /// Pobieranie rekordu z pliku rekord2.txt
        /// </summary>
        void PobierzRekord()
        {
            int rekord;
            string sciezka = "rekord2.txt";
            string zawartoscPliku = File.ReadAllText(sciezka);
            int.TryParse(zawartoscPliku, out rekord);
            rekord_info.Text = "Twój rekord: " + rekord;
        }
        /// <summary>
        /// Wyświetlenie/Schowanie MENU gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu_button_Click(object sender, EventArgs e)
        {
            if (menu_panel.Visible == false)
            {
                menu_panel.Enabled = true;
                menu_panel.Show();
                if (start == true)
                {
                    TimersOFF();
                }
            }
            else if (menu_panel.Visible == true)
            {
                menu_panel.Enabled = false;
                menu_panel.Hide();
                if (start == true)
                {
                    TimersON();
                }
            }
        }
        /// <summary>
        /// Ukrycie MENU i kontynuacja gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void kontynnuj_button_Click(object sender, EventArgs e)
        {
            menu_panel.Enabled = false;
            menu_panel.Hide();
            if (start == true)
            {
                TimersON();
            }
        }
        /// <summary>
        /// Restart gry (w tym samym trybie)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void restart_button_Click(object sender, EventArgs e)
        {
            Tryb2 tryb2 = new Tryb2();
            tryb2.StartPosition = FormStartPosition.Manual;
            tryb2.Location = new Point(this.Location.X, this.Location.Y);
            tryb2.Show();
            this.Hide();
        }
        /// <summary>
        /// Powrót do ekranu głównego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void return_button_Click(object sender, EventArgs e)
        {
            Menu home = new Menu();
            home.StartPosition = FormStartPosition.Manual;
            home.Location = new Point(this.Location.X, this.Location.Y);
            home.Show();
            this.Hide();
        }
        /// <summary>
        /// Wyjście z gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Losowanie równania i liczb które będą się przesuwać oraz losowanie pozycji poprawnego rozwiązania
        /// </summary>
        void losujLiczby()
        {
            Random rnd = new Random();
            a = rnd.Next(2, 10);
            b = rnd.Next(2, 10);
            c = a * b;
            rown_info.Text = a + " x " + b;
            int l1, l2, l3, l4, l5;
            l1 = rnd.Next(1, 100);
            l2 = rnd.Next(1, 100);
            l3 = rnd.Next(1, 100);
            l4 = rnd.Next(1, 100);
            l5 = rnd.Next(1, 100);
               while (l1 == l2 || l1 == l3 || l1 == l4 || l1 == l5 || l2 == l3 || l2 == l4 || l2 == l5 || l3 == l4 || l3 == l5 || l4 == l5)
            {
                l1 = rnd.Next(1, 100);
                l2 = rnd.Next(1, 100);
                l3 = rnd.Next(1, 100);
                l4 = rnd.Next(1, 100);
                l5 = rnd.Next(1, 100);
            }
            liczba1.Text = "" + l1 + "";
            liczba2.Text = "" + l2 + "";
            liczba3.Text = "" + l3 + "";
            liczba4.Text = "" + l4 + "";
            liczba5.Text = "" + l5 + "";
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
        /// <summary>
        /// Wywołanie funkcji SprawdzPoprawnosc dla kazdej z pięciu liczb, gdy postać zderzy się z liczbą
        /// </summary>
        void Zderzenie()
        {
            if (liczby.Location.X - hero.Location.X < 40)
            {
                SprawdzPoprawnosc(liczba1, 1);
                SprawdzPoprawnosc(liczba2, 2);
                SprawdzPoprawnosc(liczba3, 3);
                SprawdzPoprawnosc(liczba4, 4);
                SprawdzPoprawnosc(liczba5, 5);
            }    
        }
        /// <summary>
        /// Sprawdzenie czy liczba, z którą zderzyła się postać jest rozwiązaniem równania
        /// </summary>
        /// <param name="liczba">Liczba jedna z pięciu</param>
        /// <param name="poz">Pozycja liczby</param>
        void SprawdzPoprawnosc(Label liczba, int poz)
        {
            if (hero.Bounds.IntersectsWith(liczba.Bounds))
            {
                if ((pozycja % 5) + 1 == poz)
                {
                    losujLiczby();
                    liczby.Location = new Point(859, 3);
                    punkty++;
                    punkty_info.Text = "Zdobyte punkty: " + punkty;
                }
                else
                {
                    if (szanse_id == 3)
                    {
                        szanse_id = 2;
                        szanse.Image = Gra.Properties.Resources.szanse2;
                        losujLiczby();
                        liczby.Location = new Point(859, 3);
                    }
                    else if (szanse_id == 2)
                    {
                        szanse_id = 1;
                        szanse.Image = Gra.Properties.Resources.szanse1;
                        losujLiczby();
                        liczby.Location = new Point(859, 3);
                    }
                    else if (szanse_id == 1)
                    {
                        szanse.Image = Gra.Properties.Resources.szanse0;
                        info.Text = "Koniec gry\nZdobyte punkty: " + punkty;
                        info.Show();
                        TimersOFF();
                        ZapiszRekord();
                    }
                }
            }
        }
        /// <summary>
        /// Zapisanie rekordu do pliku rekord2.txt po zakończonej grze
        /// </summary>
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
        /// <summary>
        /// wyłączenie wszystkich Timer'ów
        /// </summary>
        void TimersOFF()
        {
            timer1.Stop();
            timer2.Stop();
        }
        /// <summary>
        /// Włączenie wszystkich Timer'ów
        /// </summary>
        void TimersON()
        {
            timer1.Start();
            timer2.Start();
        }
    }
}