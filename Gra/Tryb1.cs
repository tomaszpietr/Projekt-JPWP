using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Gra
{
    public partial class Tryb1 : Form
    {
        int szanse_id = 3;
        int pozycja;
        int poz_licznik = 1;
        int wynik;
        int a, b, c, d, ab, cd;
        String rownanie;
        bool start = false;
        int punkty = 0;
        public Tryb1() //okno gry z trybem 1
        {
            InitializeComponent();
            this.Text = "Tabliczka mnożenia: Wyścig z czasem - tryb 1";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            menu_panel.Parent = this;
            game_panel.Parent = this;
            info.Parent = this;
            menu_panel.Hide();
            PobierzRekord();
            punkty_info.Text = "Zdobyte punkty: " + punkty;
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
            rown1.Text = a + " x " + b;
            rown2.Text = c + " x " + d;
        }

        void LosujRozw() //losuje liczby w miejscach rozwiązań
        {
            Random rnd = new Random();
            ab = rnd.Next(1, 100);
            cd = rnd.Next(1, 100);
            rozw1.Text = "" + ab + "";
            rozw2.Text = "" + cd + "";
        }

        void WyswRozw() //wyświetla prawidłowe rozwiązania
        {
            ab = a * b;
            cd = c * d;
            rozw1.Text = "" + ab + "";
            rozw2.Text = "" + cd + "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pozycja == poz_licznik)
            {
                WyswRozw();
                Random rnd = new Random();
                pozycja = rnd.Next(2, 10);
                poz_licznik = 1;
            }
            else
            {
                LosujRozw();
                poz_licznik++;
            }
        }

        private void Tryb1_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Space)
                {
                    if (!start)
                    {
                        info.Hide();
                        LosujRown();
                        LosujRozw();
                        start = true;
                        Random rnd = new Random();
                        pozycja = rnd.Next(2, 10);
                        timer1.Enabled = true;
                    }
                    else if (start && timer1.Enabled)
                    {
                        if (a * b == ab && c * d == cd)
                        {
                            punkty++;
                            punkty_info.Text = "Zdobyte punkty: " + punkty;
                            LosujRown();
                            LosujRozw();
                        }
                        else
                        {

                            if (szanse_id == 3)
                            {
                                szanse_id = 2;
                                szanse.Image = Gra.Properties.Resources.szanse2;
                                LosujRown();
                                LosujRozw();
                            }
                            else if (szanse_id == 2)
                            {
                                szanse_id = 1;
                                szanse.Image = Gra.Properties.Resources.szanse1;
                                LosujRown();
                                LosujRozw();
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

        private void kontynnuj_Click(object sender, EventArgs e)
        {
            menu_panel.Hide();
            timer1.Enabled = true;
        }

        private void restart_Click(object sender, EventArgs e)
        {
            Tryb1 tryb1 = new Tryb1();
            tryb1.StartPosition = FormStartPosition.Manual;
            tryb1.Location = new Point(this.Location.X, this.Location.Y);
            tryb1.Show();
            this.Hide();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            if (menu_panel.Visible == false)
            {
                menu_panel.Show();
                timer1.Stop();
            }
            else if (menu_panel.Visible == true)
            {
                menu_panel.Hide();
                timer1.Start();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void powrot_Click(object sender, EventArgs e)
        {
            Menu home = new Menu();
            home.StartPosition = FormStartPosition.Manual;
            home.Location = new Point(this.Location.X, this.Location.Y);
            home.Show();
            this.Hide();
        }
        void PobierzRekord()
        {
            int rekord;
            string sciezka = "rekord1.txt";
            string zawartoscPliku = File.ReadAllText(sciezka);
            int.TryParse(zawartoscPliku, out rekord);
            rekord_info.Text = "Twój rekord: " + rekord;
        }
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