using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gra
{
    /// <summary>
    /// Okno z opisem gry
    /// </summary>
    public partial class Opis : Form
    {
        public Opis()
        {
            InitializeComponent();
            przyciski.BackColor = Color.FromArgb(0, 0, 0, 0);
            this.Text = "Opis gry";
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.BackgroundImage = Properties.Resources.opis;
            this.BackgroundImageLayout = ImageLayout.Stretch;
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
            this.Hide();
        }
    }
}