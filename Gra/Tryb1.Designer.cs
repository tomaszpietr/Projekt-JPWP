namespace Gra
{
    partial class Tryb1
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
            this.rown1 = new System.Windows.Forms.Label();
            this.rozw1 = new System.Windows.Forms.Label();
            this.rown2 = new System.Windows.Forms.Label();
            this.rozw2 = new System.Windows.Forms.Label();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.kontynuuj_button = new System.Windows.Forms.Button();
            this.restart_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.powrot_button = new System.Windows.Forms.Button();
            this.menu_button = new System.Windows.Forms.Label();
            this.rekord_info = new System.Windows.Forms.Label();
            this.punkty_info = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.game_panel = new System.Windows.Forms.Panel();
            this.szanse = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menu_panel.SuspendLayout();
            this.game_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.szanse)).BeginInit();
            this.SuspendLayout();
            // 
            // rown1
            // 
            this.rown1.BackColor = System.Drawing.Color.Green;
            this.rown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rown1.ForeColor = System.Drawing.Color.White;
            this.rown1.Location = new System.Drawing.Point(53, 31);
            this.rown1.Name = "rown1";
            this.rown1.Size = new System.Drawing.Size(406, 147);
            this.rown1.TabIndex = 0;
            this.rown1.Text = "label1";
            this.rown1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rozw1
            // 
            this.rozw1.BackColor = System.Drawing.Color.Green;
            this.rozw1.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rozw1.ForeColor = System.Drawing.Color.White;
            this.rozw1.Location = new System.Drawing.Point(53, 239);
            this.rozw1.Name = "rozw1";
            this.rozw1.Size = new System.Drawing.Size(406, 147);
            this.rozw1.TabIndex = 1;
            this.rozw1.Text = "label2";
            this.rozw1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rown2
            // 
            this.rown2.BackColor = System.Drawing.Color.Blue;
            this.rown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rown2.ForeColor = System.Drawing.Color.White;
            this.rown2.Location = new System.Drawing.Point(494, 31);
            this.rown2.Name = "rown2";
            this.rown2.Size = new System.Drawing.Size(406, 147);
            this.rown2.TabIndex = 2;
            this.rown2.Text = "label3";
            this.rown2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rozw2
            // 
            this.rozw2.BackColor = System.Drawing.Color.Blue;
            this.rozw2.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rozw2.ForeColor = System.Drawing.Color.White;
            this.rozw2.Location = new System.Drawing.Point(494, 239);
            this.rozw2.Name = "rozw2";
            this.rozw2.Size = new System.Drawing.Size(406, 147);
            this.rozw2.TabIndex = 3;
            this.rozw2.Text = "label4";
            this.rozw2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menu_panel
            // 
            this.menu_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menu_panel.Controls.Add(this.kontynuuj_button);
            this.menu_panel.Controls.Add(this.restart_button);
            this.menu_panel.Controls.Add(this.exit_button);
            this.menu_panel.Controls.Add(this.powrot_button);
            this.menu_panel.Location = new System.Drawing.Point(264, 28);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(450, 630);
            this.menu_panel.TabIndex = 5;
            // 
            // kontynuuj_button
            // 
            this.kontynuuj_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kontynuuj_button.Location = new System.Drawing.Point(95, 20);
            this.kontynuuj_button.Name = "kontynuuj_button";
            this.kontynuuj_button.Size = new System.Drawing.Size(263, 96);
            this.kontynuuj_button.TabIndex = 4;
            this.kontynuuj_button.Text = "Kontynuuj";
            this.kontynuuj_button.UseVisualStyleBackColor = true;
            this.kontynuuj_button.Click += new System.EventHandler(this.kontynnuj_Click);
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
            this.restart_button.Click += new System.EventHandler(this.restart_Click);
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
            this.exit_button.Click += new System.EventHandler(this.exit_Click);
            // 
            // powrot_button
            // 
            this.powrot_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.powrot_button.Location = new System.Drawing.Point(92, 262);
            this.powrot_button.Name = "powrot_button";
            this.powrot_button.Size = new System.Drawing.Size(266, 162);
            this.powrot_button.TabIndex = 2;
            this.powrot_button.Text = "Powrót do ekranu głównego";
            this.powrot_button.UseVisualStyleBackColor = true;
            this.powrot_button.Click += new System.EventHandler(this.powrot_Click);
            // 
            // menu_button
            // 
            this.menu_button.BackColor = System.Drawing.Color.Teal;
            this.menu_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menu_button.ForeColor = System.Drawing.Color.White;
            this.menu_button.Location = new System.Drawing.Point(806, 12);
            this.menu_button.Name = "menu_button";
            this.menu_button.Size = new System.Drawing.Size(190, 50);
            this.menu_button.TabIndex = 6;
            this.menu_button.Text = "MENU";
            this.menu_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.menu_button.Click += new System.EventHandler(this.menu_Click);
            // 
            // rekord_info
            // 
            this.rekord_info.BackColor = System.Drawing.Color.DodgerBlue;
            this.rekord_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rekord_info.ForeColor = System.Drawing.Color.White;
            this.rekord_info.Location = new System.Drawing.Point(12, 12);
            this.rekord_info.Name = "rekord_info";
            this.rekord_info.Size = new System.Drawing.Size(216, 50);
            this.rekord_info.TabIndex = 7;
            this.rekord_info.Text = "Twój rekord:";
            this.rekord_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // punkty_info
            // 
            this.punkty_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.punkty_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.punkty_info.ForeColor = System.Drawing.Color.White;
            this.punkty_info.Location = new System.Drawing.Point(245, 12);
            this.punkty_info.Name = "punkty_info";
            this.punkty_info.Size = new System.Drawing.Size(546, 50);
            this.punkty_info.TabIndex = 8;
            this.punkty_info.Text = "Zdobyte punkty:";
            this.punkty_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.Teal;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.info.ForeColor = System.Drawing.Color.White;
            this.info.Location = new System.Drawing.Point(49, 142);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(913, 485);
            this.info.TabIndex = 9;
            this.info.Text = "Naciśnij SPACJĘ, aby rozpocząć";
            this.info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // game_panel
            // 
            this.game_panel.Controls.Add(this.rown1);
            this.game_panel.Controls.Add(this.rown2);
            this.game_panel.Controls.Add(this.rozw1);
            this.game_panel.Controls.Add(this.rozw2);
            this.game_panel.Location = new System.Drawing.Point(35, 142);
            this.game_panel.Name = "game_panel";
            this.game_panel.Size = new System.Drawing.Size(939, 438);
            this.game_panel.TabIndex = 10;
            // 
            // szanse
            // 
            this.szanse.Image = global::Gra.Properties.Resources.szanse3;
            this.szanse.Location = new System.Drawing.Point(60, 75);
            this.szanse.Name = "szanse";
            this.szanse.Size = new System.Drawing.Size(108, 35);
            this.szanse.TabIndex = 11;
            this.szanse.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Tryb1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.info);
            this.Controls.Add(this.szanse);
            this.Controls.Add(this.rekord_info);
            this.Controls.Add(this.menu_button);
            this.Controls.Add(this.punkty_info);
            this.Controls.Add(this.game_panel);
            this.Name = "Tryb1";
            this.Text = "Tryb1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tryb1_KeyDown);
            this.menu_panel.ResumeLayout(false);
            this.game_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.szanse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label rown1;
        private System.Windows.Forms.Label rozw1;
        private System.Windows.Forms.Label rown2;
        private System.Windows.Forms.Label rozw2;
        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button powrot_button;
        private System.Windows.Forms.Button restart_button;
        private System.Windows.Forms.Button kontynuuj_button;
        private System.Windows.Forms.Label menu_button;
        private System.Windows.Forms.Label rekord_info;
        private System.Windows.Forms.Label punkty_info;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Panel game_panel;
        private System.Windows.Forms.PictureBox szanse;
        private System.Windows.Forms.Timer timer1;
    }
}