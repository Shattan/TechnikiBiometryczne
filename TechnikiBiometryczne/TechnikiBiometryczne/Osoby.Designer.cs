namespace TechnikiBiometryczne
{
    partial class Osoby
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
            this.TabDane = new System.Windows.Forms.DataGridView();
            this.ColImie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTeksty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColZmienTeksty = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TabDane)).BeginInit();
            this.SuspendLayout();
            // 
            // TabDane
            // 
            this.TabDane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabDane.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColImie,
            this.ColNazwisko,
            this.ColTeksty,
            this.ColZmienTeksty});
            this.TabDane.Location = new System.Drawing.Point(12, 12);
            this.TabDane.Name = "TabDane";
            this.TabDane.Size = new System.Drawing.Size(920, 524);
            this.TabDane.TabIndex = 0;
            this.TabDane.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabDane_CellContentClick);
            // 
            // ColImie
            // 
            this.ColImie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColImie.HeaderText = "Imię";
            this.ColImie.Name = "ColImie";
            // 
            // ColNazwisko
            // 
            this.ColNazwisko.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNazwisko.HeaderText = "Nazwisko";
            this.ColNazwisko.Name = "ColNazwisko";
            // 
            // ColTeksty
            // 
            this.ColTeksty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTeksty.HeaderText = "Teksty";
            this.ColTeksty.Name = "ColTeksty";
            // 
            // ColZmienTeksty
            // 
            this.ColZmienTeksty.HeaderText = "Zmień teksty";
            this.ColZmienTeksty.Name = "ColZmienTeksty";
            this.ColZmienTeksty.Text = "...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Osoby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 641);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TabDane);
            this.Name = "Osoby";
            this.Text = "Osoby";
            ((System.ComponentModel.ISupportInitialize)(this.TabDane)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TabDane;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColImie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTeksty;
        private System.Windows.Forms.DataGridViewButtonColumn ColZmienTeksty;
        private System.Windows.Forms.Button button1;
    }
}