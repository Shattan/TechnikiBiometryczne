namespace TechnikiBiometryczne
{
    partial class Teksty
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
            this.ColNazPliku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAutor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColWysStat = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TabDane)).BeginInit();
            this.SuspendLayout();
            // 
            // TabDane
            // 
            this.TabDane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabDane.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNazPliku,
            this.ColAutor,
            this.ColWysStat});
            this.TabDane.Location = new System.Drawing.Point(13, 13);
            this.TabDane.Name = "TabDane";
            this.TabDane.Size = new System.Drawing.Size(848, 612);
            this.TabDane.TabIndex = 0;
            this.TabDane.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabDane_CellContentClick);
            // 
            // ColNazPliku
            // 
            this.ColNazPliku.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNazPliku.HeaderText = "Nazwa pliku";
            this.ColNazPliku.Name = "ColNazPliku";
            // 
            // ColAutor
            // 
            this.ColAutor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColAutor.HeaderText = "Autor";
            this.ColAutor.Name = "ColAutor";
            this.ColAutor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColAutor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColWysStat
            // 
            this.ColWysStat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColWysStat.HeaderText = "Wyświetl statystyki";
            this.ColWysStat.Name = "ColWysStat";
            this.ColWysStat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColWysStat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Teksty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 637);
            this.Controls.Add(this.TabDane);
            this.Name = "Teksty";
            this.Text = "Teksty";
            ((System.ComponentModel.ISupportInitialize)(this.TabDane)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TabDane;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNazPliku;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColAutor;
        private System.Windows.Forms.DataGridViewButtonColumn ColWysStat;
    }
}