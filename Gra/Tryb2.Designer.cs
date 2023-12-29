namespace Gra
{
    partial class Tryb2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menu_button = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.hero = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.liczba1 = new System.Windows.Forms.Label();
            this.liczba2 = new System.Windows.Forms.Label();
            this.liczba3 = new System.Windows.Forms.Label();
            this.liczba4 = new System.Windows.Forms.Label();
            this.liczba5 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.restart_button = new System.Windows.Forms.Button();
            this.kontynnuj_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.return_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menu_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 124);
            this.label6.TabIndex = 8;
            this.label6.Text = "Twój rekord:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(255, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(562, 124);
            this.label7.TabIndex = 9;
            this.label7.Text = "Równanie";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // menu_button
            // 
            this.menu_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menu_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menu_button.Location = new System.Drawing.Point(830, 9);
            this.menu_button.Name = "menu_button";
            this.menu_button.Size = new System.Drawing.Size(166, 124);
            this.menu_button.TabIndex = 10;
            this.menu_button.Text = "MENU";
            this.menu_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.menu_button.Click += new System.EventHandler(this.menu_button_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(120, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 124);
            this.label1.TabIndex = 11;
            this.label1.Text = "Zdobyte punkty:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(-1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(984, 522);
            this.label8.TabIndex = 12;
            this.label8.Text = "Naciśnij SPACJĘ, aby rozpocząć";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hero
            // 
            this.hero.Image = global::Gra.Properties.Resources.math_hero;
            this.hero.Location = new System.Drawing.Point(14, 209);
            this.hero.Name = "hero";
            this.hero.Size = new System.Drawing.Size(50, 81);
            this.hero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.hero.TabIndex = 13;
            this.hero.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.liczba1);
            this.panel2.Controls.Add(this.liczba2);
            this.panel2.Controls.Add(this.liczba3);
            this.panel2.Controls.Add(this.liczba4);
            this.panel2.Controls.Add(this.liczba5);
            this.panel2.Location = new System.Drawing.Point(897, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(83, 515);
            this.panel2.TabIndex = 20;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // liczba1
            // 
            this.liczba1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.liczba1.Location = new System.Drawing.Point(3, 0);
            this.liczba1.Name = "liczba1";
            this.liczba1.Size = new System.Drawing.Size(78, 75);
            this.liczba1.TabIndex = 24;
            this.liczba1.Text = "10";
            this.liczba1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // liczba2
            // 
            this.liczba2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.liczba2.Location = new System.Drawing.Point(3, 114);
            this.liczba2.Name = "liczba2";
            this.liczba2.Size = new System.Drawing.Size(78, 75);
            this.liczba2.TabIndex = 23;
            this.liczba2.Text = "12";
            this.liczba2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // liczba3
            // 
            this.liczba3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.liczba3.Location = new System.Drawing.Point(5, 224);
            this.liczba3.Name = "liczba3";
            this.liczba3.Size = new System.Drawing.Size(78, 75);
            this.liczba3.TabIndex = 22;
            this.liczba3.Text = "14";
            this.liczba3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // liczba4
            // 
            this.liczba4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.liczba4.Location = new System.Drawing.Point(5, 333);
            this.liczba4.Name = "liczba4";
            this.liczba4.Size = new System.Drawing.Size(78, 75);
            this.liczba4.TabIndex = 21;
            this.liczba4.Text = "99";
            this.liczba4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // liczba5
            // 
            this.liczba5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.liczba5.Location = new System.Drawing.Point(3, 440);
            this.liczba5.Name = "liczba5";
            this.liczba5.Size = new System.Drawing.Size(78, 75);
            this.liczba5.TabIndex = 21;
            this.liczba5.Text = "18";
            this.liczba5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Interval = 40;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.hero);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(13, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 522);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // menu_panel
            // 
            this.menu_panel.Controls.Add(this.restart_button);
            this.menu_panel.Controls.Add(this.kontynnuj_button);
            this.menu_panel.Controls.Add(this.exit_button);
            this.menu_panel.Controls.Add(this.return_button);
            this.menu_panel.Location = new System.Drawing.Point(287, 38);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(435, 604);
            this.menu_panel.TabIndex = 15;
            this.menu_panel.Visible = false;
            // 
            // restart_button
            // 
            this.restart_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.restart_button.Location = new System.Drawing.Point(92, 134);
            this.restart_button.Name = "restart_button";
            this.restart_button.Size = new System.Drawing.Size(266, 115);
            this.restart_button.TabIndex = 5;
            this.restart_button.Text = "Restart gry";
            this.restart_button.UseVisualStyleBackColor = true;
            this.restart_button.Click += new System.EventHandler(this.restart_button_Click);
            // 
            // kontynnuj_button
            // 
            this.kontynnuj_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kontynnuj_button.Location = new System.Drawing.Point(92, 20);
            this.kontynnuj_button.Name = "kontynnuj_button";
            this.kontynnuj_button.Size = new System.Drawing.Size(266, 96);
            this.kontynnuj_button.TabIndex = 4;
            this.kontynnuj_button.Text = "Kontynuuj";
            this.kontynnuj_button.UseVisualStyleBackColor = true;
            this.kontynnuj_button.Click += new System.EventHandler(this.kontynnuj_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit_button.Location = new System.Drawing.Point(95, 442);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(263, 146);
            this.exit_button.TabIndex = 3;
            this.exit_button.Text = "Wyjście";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // return_button
            // 
            this.return_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.return_button.Location = new System.Drawing.Point(92, 262);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(266, 162);
            this.return_button.TabIndex = 2;
            this.return_button.Text = "Powrót do ekranu głównego";
            this.return_button.UseVisualStyleBackColor = true;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // Tryb2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu_button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Name = "Tryb2";
            this.Text = "Tryb2";
            this.Load += new System.EventHandler(this.Tryb2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tryb2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Tryb2_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.hero)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menu_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label menu_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox hero;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label liczba4;
        private System.Windows.Forms.Label liczba5;
        private System.Windows.Forms.Label liczba1;
        private System.Windows.Forms.Label liczba2;
        private System.Windows.Forms.Label liczba3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Button restart_button;
        private System.Windows.Forms.Button kontynnuj_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button return_button;
    }
}