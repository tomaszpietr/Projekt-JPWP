namespace Gra
{
    partial class Menu
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
            this.main_panel = new System.Windows.Forms.Panel();
            this.autor = new System.Windows.Forms.Label();
            this.reset_button = new System.Windows.Forms.Button();
            this.tytul = new System.Windows.Forms.Label();
            this.opis_button = new System.Windows.Forms.Button();
            this.start_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.tryb1_button = new System.Windows.Forms.Button();
            this.tryb2_button = new System.Windows.Forms.Button();
            this.choose_mode_panel = new System.Windows.Forms.Panel();
            this.main_panel.SuspendLayout();
            this.choose_mode_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.autor);
            this.main_panel.Controls.Add(this.reset_button);
            this.main_panel.Controls.Add(this.tytul);
            this.main_panel.Controls.Add(this.opis_button);
            this.main_panel.Controls.Add(this.start_button);
            this.main_panel.Controls.Add(this.exit_button);
            this.main_panel.Location = new System.Drawing.Point(67, 20);
            this.main_panel.Name = "main_panel";
            this.main_panel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.main_panel.Size = new System.Drawing.Size(888, 649);
            this.main_panel.TabIndex = 0;
            // 
            // autor
            // 
            this.autor.BackColor = System.Drawing.Color.Blue;
            this.autor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autor.ForeColor = System.Drawing.Color.White;
            this.autor.Location = new System.Drawing.Point(273, 590);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(346, 46);
            this.autor.TabIndex = 6;
            this.autor.Text = "Autor: Tomasz Pietrowski";
            this.autor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reset_button
            // 
            this.reset_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reset_button.Location = new System.Drawing.Point(590, 203);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(263, 146);
            this.reset_button.TabIndex = 5;
            this.reset_button.Text = "Reset rekordów";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // tytul
            // 
            this.tytul.BackColor = System.Drawing.Color.Green;
            this.tytul.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tytul.ForeColor = System.Drawing.Color.White;
            this.tytul.Location = new System.Drawing.Point(74, 52);
            this.tytul.Name = "tytul";
            this.tytul.Size = new System.Drawing.Size(740, 72);
            this.tytul.TabIndex = 5;
            this.tytul.Text = "Tabliczka mnożenia: Wyścig z czasem";
            this.tytul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // opis_button
            // 
            this.opis_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.opis_button.Location = new System.Drawing.Point(306, 203);
            this.opis_button.Name = "opis_button";
            this.opis_button.Size = new System.Drawing.Size(263, 146);
            this.opis_button.TabIndex = 4;
            this.opis_button.Text = "Opis gry";
            this.opis_button.UseVisualStyleBackColor = true;
            this.opis_button.Click += new System.EventHandler(this.opis_button_Click);
            // 
            // start_button
            // 
            this.start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.start_button.Location = new System.Drawing.Point(19, 203);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(267, 146);
            this.start_button.TabIndex = 1;
            this.start_button.Text = "Rozpocznij grę\r\n";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit_button.Location = new System.Drawing.Point(307, 375);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(263, 146);
            this.exit_button.TabIndex = 0;
            this.exit_button.Text = "Wyjście";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // tryb1_button
            // 
            this.tryb1_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tryb1_button.Location = new System.Drawing.Point(3, 3);
            this.tryb1_button.Name = "tryb1_button";
            this.tryb1_button.Size = new System.Drawing.Size(263, 140);
            this.tryb1_button.TabIndex = 2;
            this.tryb1_button.Text = "Tryb 1";
            this.tryb1_button.UseVisualStyleBackColor = true;
            this.tryb1_button.Click += new System.EventHandler(this.tryb1_button_Click);
            // 
            // tryb2_button
            // 
            this.tryb2_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tryb2_button.Location = new System.Drawing.Point(3, 225);
            this.tryb2_button.Name = "tryb2_button";
            this.tryb2_button.Size = new System.Drawing.Size(263, 146);
            this.tryb2_button.TabIndex = 3;
            this.tryb2_button.Text = "Tryb 2";
            this.tryb2_button.UseVisualStyleBackColor = true;
            this.tryb2_button.Click += new System.EventHandler(this.tryb2_button_Click);
            // 
            // choose_mode_panel
            // 
            this.choose_mode_panel.Controls.Add(this.tryb2_button);
            this.choose_mode_panel.Controls.Add(this.tryb1_button);
            this.choose_mode_panel.Location = new System.Drawing.Point(371, 132);
            this.choose_mode_panel.Name = "choose_mode_panel";
            this.choose_mode_panel.Size = new System.Drawing.Size(268, 374);
            this.choose_mode_panel.TabIndex = 4;
            this.choose_mode_panel.Visible = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.choose_mode_panel);
            this.Name = "Menu";
            this.Text = "Form1";
            this.main_panel.ResumeLayout(false);
            this.choose_mode_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Button opis_button;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button tryb1_button;
        private System.Windows.Forms.Button tryb2_button;
        private System.Windows.Forms.Panel choose_mode_panel;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Label tytul;
        private System.Windows.Forms.Label autor;
    }
}

