namespace TechnikiBiometryczne
{
    partial class EkranGlowny
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
            this.BTPrzegTeksty = new System.Windows.Forms.Button();
            this.LTytul = new System.Windows.Forms.Label();
            this.BTPrzegOsoby = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTPrzegTeksty
            // 
            this.BTPrzegTeksty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTPrzegTeksty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BTPrzegTeksty.Location = new System.Drawing.Point(12, 49);
            this.BTPrzegTeksty.Name = "BTPrzegTeksty";
            this.BTPrzegTeksty.Size = new System.Drawing.Size(403, 135);
            this.BTPrzegTeksty.TabIndex = 0;
            this.BTPrzegTeksty.Text = "Przeglądaj teksty";
            this.BTPrzegTeksty.UseVisualStyleBackColor = false;
            this.BTPrzegTeksty.Click += new System.EventHandler(this.BTPrzegTeksty_Click);
            // 
            // LTytul
            // 
            this.LTytul.AutoSize = true;
            this.LTytul.Dock = System.Windows.Forms.DockStyle.Top;
            this.LTytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LTytul.ForeColor = System.Drawing.Color.Red;
            this.LTytul.Location = new System.Drawing.Point(0, 0);
            this.LTytul.Name = "LTytul";
            this.LTytul.Size = new System.Drawing.Size(785, 46);
            this.LTytul.TabIndex = 6;
            this.LTytul.Text = "Rozpoznawator właściciela tekstu 0.8.2523";
            this.LTytul.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BTPrzegOsoby
            // 
            this.BTPrzegOsoby.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTPrzegOsoby.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BTPrzegOsoby.Location = new System.Drawing.Point(421, 49);
            this.BTPrzegOsoby.Name = "BTPrzegOsoby";
            this.BTPrzegOsoby.Size = new System.Drawing.Size(403, 135);
            this.BTPrzegOsoby.TabIndex = 8;
            this.BTPrzegOsoby.Text = "Przeglądaj osoby";
            this.BTPrzegOsoby.UseVisualStyleBackColor = false;
            this.BTPrzegOsoby.Click += new System.EventHandler(this.BTPrzegOsoby_Click);
            // 
            // EkranGlowny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(833, 604);
            this.Controls.Add(this.BTPrzegOsoby);
            this.Controls.Add(this.LTytul);
            this.Controls.Add(this.BTPrzegTeksty);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Name = "EkranGlowny";
            this.Text = "Rozpoznawanie właściciela tesktu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTPrzegTeksty;
        private System.Windows.Forms.Label LTytul;
        private System.Windows.Forms.Button BTPrzegOsoby;
    }
}

