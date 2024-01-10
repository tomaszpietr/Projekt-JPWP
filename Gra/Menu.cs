using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Gra
{
    /// <summary>
    /// Okno z ekranem startowym
    /// </summary>
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Size = new System.Drawing.Size(1024, 720);
            main_panel.BackColor = Color.FromArgb(0, 0, 0, 0); //ustawienie przeźroczystości panelu głównego
            choose_mode_panel.BackColor = Color.FromArgb(0, 0, 0, 0);
            main_panel.Location = new System.Drawing.Point((this.ClientSize.Width - main_panel.Width) / 2, (this.ClientSize.Height - main_panel.Height) / 2);
            choose_mode_panel.Location = new System.Drawing.Point((this.ClientSize.Width - choose_mode_panel.Width) / 2, (this.ClientSize.Height - choose_mode_panel.Height) / 2);
            choose_mode_panel.Parent = this; //uniezależnienie od siebie paneli przy ukrywaniu i pokazywaniu
            main_panel.Parent = this;
            this.BackgroundImage = Properties.Resources.tlo;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Text = "Tabliczka mnożenia: Wyścig z czasem";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false; //zablokowanie możliwości powiększenia okna
        }
        /// <summary>
        /// Wybór trybu gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void start_button_Click(object sender, EventArgs e)
        {
            main_panel.Hide();
            choose_mode_panel.Show();
            this.Text = "Wybierz tryb";
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
        /// Włączenie gry w trybie 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tryb1_button_Click(object sender, EventArgs e)
        {
            Tryb1 tryb1 = new Tryb1();
            tryb1.StartPosition = FormStartPosition.Manual; 
            tryb1.Location = new Point(this.Location.X, this.Location.Y); //wyświetlenie okna w tym samym miejscu
            tryb1.Show();
            this.Hide();
        }
        /// <summary>
        /// Włączenie gry w trybie 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tryb2_button_Click(object sender, EventArgs e)
        {
            Tryb2 tryb2 = new Tryb2();
            tryb2.StartPosition = FormStartPosition.Manual;
            tryb2.Location = new Point(this.Location.X, this.Location.Y); //wyświetlenie okna w tym samym miejscu
            tryb2.Show();
            this.Hide();
        }
        /// <summary>
        /// Wyświetlenie opisu gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void opis_button_Click(object sender, EventArgs e)
        {
            Opis opis = new Opis();
            opis.StartPosition = FormStartPosition.Manual;
            opis.Location = new Point(this.Location.X, this.Location.Y); //wyświetlenie okna w tym samym miejscu
            opis.Show();
        }
        /// <summary>
        /// Reset rekordów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reset_button_Click(object sender, EventArgs e)
        {
            int punkty = 0;
            File.WriteAllText("rekord1.txt", null);
            File.WriteAllText("rekord1.txt", punkty.ToString());
            File.WriteAllText("rekord2.txt", null);
            File.WriteAllText("rekord2.txt", punkty.ToString());
            MessageBox.Show("Pomyślnie zresetowano rekordy", "Reset rekordów", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}