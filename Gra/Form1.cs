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
    public partial class Form1 : Form
    {
        public Form1() //ekran startowy
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1024, 720);
            panel1.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel1.Location = new System.Drawing.Point((this.ClientSize.Width - panel1.Width) / 2,(this.ClientSize.Height - panel1.Height) / 2);
            panel2.Location = new System.Drawing.Point((this.ClientSize.Width - panel2.Width) / 2,(this.ClientSize.Height - panel2.Height) / 2);
            panel1.Show();
            panel2.Hide();
            panel2.Parent = this; //uniezależnienie od siebie paneli przy ukrywaniu i pokazywaniu
            panel1.Parent = this; //
            this.BackgroundImage = Properties.Resources.tlo;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Text = "Tabliczka mnożenia: Wyścig z czasem";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
            this.Text = "Wybierz tryb";

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) //przycisk tryb1
        {
            Form2 tryb1 = new Form2();
            tryb1.StartPosition = FormStartPosition.Manual;
            tryb1.Location = new Point(this.Location.X, this.Location.Y);
            tryb1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e) //przycisk opis gry
        {
            Form3 opis = new Form3();
            opis.StartPosition = FormStartPosition.Manual;
            opis.Location = new Point(this.Location.X, this.Location.Y);
            opis.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            string sciezka = "rekord1.txt";

            // Usuń zawartość pliku (nadpisz go)
            File.WriteAllText(sciezka, string.Empty);

            // Liczba całkowita do wyeksportowania
            int liczba = 0;

            // Eksportuj liczbę całkowitą do pliku
            using (StreamWriter writer = new StreamWriter(sciezka))
            {
                writer.Write(liczba);
            }
            MessageBox.Show("Pomyślnie zresetowano rekordy", "Reset rekordów", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}