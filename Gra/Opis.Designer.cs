namespace Gra
{
    partial class Opis
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
            this.przyciski = new System.Windows.Forms.Panel();
            this.powrot = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.przyciski.SuspendLayout();
            this.SuspendLayout();
            // 
            // przyciski
            // 
            this.przyciski.Controls.Add(this.powrot);
            this.przyciski.Controls.Add(this.exit);
            this.przyciski.Location = new System.Drawing.Point(612, 572);
            this.przyciski.Name = "przyciski";
            this.przyciski.Size = new System.Drawing.Size(384, 97);
            this.przyciski.TabIndex = 0;
            // 
            // powrot
            // 
            this.powrot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.powrot.Location = new System.Drawing.Point(6, 0);
            this.powrot.Name = "powrot";
            this.powrot.Size = new System.Drawing.Size(181, 95);
            this.powrot.TabIndex = 1;
            this.powrot.Text = "Powrót";
            this.powrot.UseVisualStyleBackColor = true;
            this.powrot.Click += new System.EventHandler(this.powrot_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit.Location = new System.Drawing.Point(208, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(171, 95);
            this.exit.TabIndex = 0;
            this.exit.Text = "Wyjście";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Opis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.przyciski);
            this.Name = "Opis";
            this.Text = "Opis";
            this.przyciski.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel przyciski;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button powrot;
    }
}