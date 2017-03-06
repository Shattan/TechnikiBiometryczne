using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnikiBiometryczne
{
    public partial class Teksty : Form
    {
        public Teksty()
        {
            InitializeComponent();
        }

        private void TabDane_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TabDane.Rows.Add();
        }
    }
}
