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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tryb2));
            this.rekord_info = new System.Windows.Forms.Label();
            this.rown_info = new System.Windows.Forms.Label();
            this.menu_button = new System.Windows.Forms.Label();
            this.punkty_info = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.liczby = new System.Windows.Forms.Panel();
            this.liczba1 = new System.Windows.Forms.Label();
            this.liczba2 = new System.Windows.Forms.Label();
            this.liczba3 = new System.Windows.Forms.Label();
            this.liczba4 = new System.Windows.Forms.Label();
            this.liczba5 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.game_panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hero = new System.Windows.Forms.PictureBox();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.restart_button = new System.Windows.Forms.Button();
            this.kontynnuj_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.return_button = new System.Windows.Forms.Button();
            this.szanse = new System.Windows.Forms.PictureBox();
            this.liczby.SuspendLayout();
            this.game_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).BeginInit();
            this.menu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.szanse)).BeginInit();
            this.SuspendLayout();
            // 
            // rekord_info
            // 
            this.rekord_info.BackColor = System.Drawing.Color.Blue;
            this.rekord_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rekord_info.ForeColor = System.Drawing.Color.White;
            this.rekord_info.Location = new System.Drawing.Point(12, 9);
            this.rekord_info.Name = "rekord_info";
            this.rekord_info.Size = new System.Drawing.Size(237, 40);
            this.rekord_info.TabIndex = 8;
            this.rekord_info.Text = "Twój rekord:";
            this.rekord_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rown_info
            // 
            this.rown_info.BackColor = System.Drawing.Color.Teal;
            this.rown_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rown_info.ForeColor = System.Drawing.Color.White;
            this.rown_info.Location = new System.Drawing.Point(255, 9);
            this.rown_info.Name = "rown_info";
            this.rown_info.Size = new System.Drawing.Size(562, 124);
            this.rown_info.TabIndex = 9;
            this.rown_info.Text = "Równanie";
            this.rown_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menu_button
            // 
            this.menu_button.BackColor = System.Drawing.Color.Gray;
            this.menu_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menu_button.ForeColor = System.Drawing.Color.White;
            this.menu_button.Location = new System.Drawing.Point(830, 9);
            this.menu_button.Name = "menu_button";
            this.menu_button.Size = new System.Drawing.Size(166, 63);
            this.menu_button.TabIndex = 10;
            this.menu_button.Text = "MENU";
            this.menu_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.menu_button.Click += new System.EventHandler(this.menu_button_Click);
            // 
            // punkty_info
            // 
            this.punkty_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.punkty_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.punkty_info.ForeColor = System.Drawing.Color.White;
            this.punkty_info.Location = new System.Drawing.Point(12, 56);
            this.punkty_info.Name = "punkty_info";
            this.punkty_info.Size = new System.Drawing.Size(237, 77);
            this.punkty_info.TabIndex = 11;
            this.punkty_info.Text = "Zdobyte punkty:";
            this.punkty_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.Teal;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.info.ForeColor = System.Drawing.Color.White;
            this.info.Location = new System.Drawing.Point(-1, 0);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(984, 522);
            this.info.TabIndex = 12;
            this.info.Text = "Naciśnij SPACJĘ, aby rozpocząć";
            this.info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // liczby
            // 
            this.liczby.Controls.Add(this.liczba1);
            this.liczby.Controls.Add(this.liczba2);
            this.liczby.Controls.Add(this.liczba3);
            this.liczby.Controls.Add(this.liczba4);
            this.liczby.Controls.Add(this.liczba5);
            this.liczby.Location = new System.Drawing.Point(897, 3);
            this.liczby.Name = "liczby";
            this.liczby.Size = new System.Drawing.Size(83, 515);
            this.liczby.TabIndex = 20;
            // 
            // liczba1
            // 
            this.liczba1.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liczba1.ForeColor = System.Drawing.Color.DarkGreen;
            this.liczba1.Location = new System.Drawing.Point(0, 0);
            this.liczba1.Name = "liczba1";
            this.liczba1.Size = new System.Drawing.Size(83, 103);
            this.liczba1.TabIndex = 24;
            this.liczba1.Text = "10";
            this.liczba1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // liczba2
            // 
            this.liczba2.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liczba2.ForeColor = System.Drawing.Color.DarkBlue;
            this.liczba2.Location = new System.Drawing.Point(0, 103);
            this.liczba2.Name = "liczba2";
            this.liczba2.Size = new System.Drawing.Size(83, 103);
            this.liczba2.TabIndex = 23;
            this.liczba2.Text = "12";
            this.liczba2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // liczba3
            // 
            this.liczba3.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liczba3.ForeColor = System.Drawing.Color.Firebrick;
            this.liczba3.Location = new System.Drawing.Point(0, 206);
            this.liczba3.Name = "liczba3";
            this.liczba3.Size = new System.Drawing.Size(83, 103);
            this.liczba3.TabIndex = 22;
            this.liczba3.Text = "14";
            this.liczba3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // liczba4
            // 
            this.liczba4.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liczba4.ForeColor = System.Drawing.Color.Gainsboro;
            this.liczba4.Location = new System.Drawing.Point(0, 309);
            this.liczba4.Name = "liczba4";
            this.liczba4.Size = new System.Drawing.Size(83, 103);
            this.liczba4.TabIndex = 21;
            this.liczba4.Text = "99";
            this.liczba4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // liczba5
            // 
            this.liczba5.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liczba5.ForeColor = System.Drawing.Color.White;
            this.liczba5.Location = new System.Drawing.Point(0, 412);
            this.liczba5.Name = "liczba5";
            this.liczba5.Size = new System.Drawing.Size(83, 103);
            this.liczba5.TabIndex = 21;
            this.liczba5.Text = "18";
            this.liczba5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Interval = 35;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // game_panel
            // 
            this.game_panel.Controls.Add(this.info);
            this.game_panel.Controls.Add(this.label4);
            this.game_panel.Controls.Add(this.label3);
            this.game_panel.Controls.Add(this.label2);
            this.game_panel.Controls.Add(this.label1);
            this.game_panel.Controls.Add(this.hero);
            this.game_panel.Controls.Add(this.liczby);
            this.game_panel.Location = new System.Drawing.Point(13, 147);
            this.game_panel.Name = "game_panel";
            this.game_panel.Size = new System.Drawing.Size(983, 522);
            this.game_panel.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(82, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(898, 4);
            this.label4.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(85, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(898, 4);
            this.label3.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(79, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(898, 4);
            this.label2.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(79, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(898, 4);
            this.label1.TabIndex = 21;
            // 
            // hero
            // 
            this.hero.Image = global::Gra.Properties.Resources.math_hero;
            this.hero.Location = new System.Drawing.Point(14, 220);
            this.hero.Name = "hero";
            this.hero.Size = new System.Drawing.Size(50, 81);
            this.hero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.hero.TabIndex = 13;
            this.hero.TabStop = false;
            // 
            // menu_panel
            // 
            this.menu_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menu_panel.Controls.Add(this.restart_button);
            this.menu_panel.Controls.Add(this.kontynnuj_button);
            this.menu_panel.Controls.Add(this.exit_button);
            this.menu_panel.Controls.Add(this.return_button);
            this.menu_panel.Location = new System.Drawing.Point(293, 37);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(451, 607);
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
            // szanse
            // 
            this.szanse.Image = ((System.Drawing.Image)(resources.GetObject("szanse.Image")));
            this.szanse.Location = new System.Drawing.Point(858, 86);
            this.szanse.Name = "szanse";
            this.szanse.Size = new System.Drawing.Size(108, 35);
            this.szanse.TabIndex = 16;
            this.szanse.TabStop = false;
            // 
            // Tryb2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.szanse);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.game_panel);
            this.Controls.Add(this.punkty_info);
            this.Controls.Add(this.menu_button);
            this.Controls.Add(this.rown_info);
            this.Controls.Add(this.rekord_info);
            this.Name = "Tryb2";
            this.Text = "Tryb2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tryb2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Tryb2_KeyUp);
            this.liczby.ResumeLayout(false);
            this.game_panel.ResumeLayout(false);
            this.game_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).EndInit();
            this.menu_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.szanse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label rekord_info;
        private System.Windows.Forms.Label rown_info;
        private System.Windows.Forms.Label menu_button;
        private System.Windows.Forms.Label punkty_info;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.PictureBox hero;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel liczby;
        private System.Windows.Forms.Label liczba4;
        private System.Windows.Forms.Label liczba5;
        private System.Windows.Forms.Label liczba1;
        private System.Windows.Forms.Label liczba2;
        private System.Windows.Forms.Label liczba3;
        private System.Windows.Forms.Panel game_panel;
        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Button restart_button;
        private System.Windows.Forms.Button kontynnuj_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.PictureBox szanse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}