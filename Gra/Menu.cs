using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra
{
    public partial class Menu : Form
    {
        public Menu() //ekran startowy
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1024, 720);
            main_panel.BackColor = Color.FromArgb(0, 0, 0, 0);
            choose_mode_panel.BackColor = Color.FromArgb(0, 0, 0, 0);
            main_panel.Location = new System.Drawing.Point((this.ClientSize.Width - main_panel.Width) / 2,(this.ClientSize.Height - main_panel.Height) / 2);
            choose_mode_panel.Location = new System.Drawing.Point((this.ClientSize.Width - choose_mode_panel.Width) / 2,(this.ClientSize.Height - choose_mode_panel.Height) / 2);
            main_panel.Show();
            choose_mode_panel.Hide();
            choose_mode_panel.Parent = this; //uniezależnienie od siebie paneli przy ukrywaniu i pokazywaniu
            main_panel.Parent = this;
            this.BackgroundImage = Properties.Resources.tlo;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Text = "Tabliczka mnożenia: Wyścig z czasem";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        private void start_button_Click(object sender, EventArgs e)
        {
            main_panel.Hide();
            choose_mode_panel.Show();
            this.Text = "Wybierz tryb";
        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void tryb1_button_Click(object sender, EventArgs e)
        {
            Tryb1 tryb1 = new Tryb1();
            tryb1.StartPosition = FormStartPosition.Manual;
            tryb1.Location = new Point(this.Location.X, this.Location.Y);
            tryb1.Show();
            this.Hide();
        }
        private void tryb2_button_Click(object sender, EventArgs e)
        {
            Tryb2 tryb2 = new Tryb2();
            tryb2.StartPosition = FormStartPosition.Manual;
            tryb2.Location = new Point(this.Location.X, this.Location.Y);
            tryb2.Show();
            this.Hide();
        }
        private void opis_button_Click(object sender, EventArgs e)
        {
            Opis opis = new Opis();
            opis.StartPosition = FormStartPosition.Manual;
            opis.Location = new Point(this.Location.X, this.Location.Y);
            opis.Show();
        }
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