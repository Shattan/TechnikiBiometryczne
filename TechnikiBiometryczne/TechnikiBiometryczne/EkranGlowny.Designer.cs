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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Aniżeli");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Ponieważ");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Gdyż");
            this.BTWczytaj = new System.Windows.Forms.Button();
            this.ListDane = new System.Windows.Forms.ListView();
            this.ColWyraz = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColCzestosc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColProcent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // BTWczytaj
            // 
            this.BTWczytaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTWczytaj.Location = new System.Drawing.Point(12, 12);
            this.BTWczytaj.Name = "BTWczytaj";
            this.BTWczytaj.Size = new System.Drawing.Size(176, 31);
            this.BTWczytaj.TabIndex = 0;
            this.BTWczytaj.Text = "Wczytaj plik";
            this.BTWczytaj.UseVisualStyleBackColor = false;
            // 
            // ListDane
            // 
            this.ListDane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ListDane.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColWyraz,
            this.ColCzestosc,
            this.ColProcent});
            this.ListDane.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ListDane.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.ListDane.Location = new System.Drawing.Point(280, 12);
            this.ListDane.Name = "ListDane";
            this.ListDane.Size = new System.Drawing.Size(665, 538);
            this.ListDane.TabIndex = 1;
            this.ListDane.UseCompatibleStateImageBehavior = false;
            // 
            // ColWyraz
            // 
            this.ColWyraz.Text = "Wyraz";
            // 
            // ColCzestosc
            // 
            this.ColCzestosc.Text = "Częstość występowania";
            // 
            // ColProcent
            // 
            this.ColProcent.Text = "Procent tekstu";
            // 
            // EkranGlowny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(957, 562);
            this.Controls.Add(this.ListDane);
            this.Controls.Add(this.BTWczytaj);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Name = "EkranGlowny";
            this.Text = "Rozpoznawanie właściciela tesktu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTWczytaj;
        private System.Windows.Forms.ListView ListDane;
        private System.Windows.Forms.ColumnHeader ColWyraz;
        private System.Windows.Forms.ColumnHeader ColCzestosc;
        private System.Windows.Forms.ColumnHeader ColProcent;
    }
}

