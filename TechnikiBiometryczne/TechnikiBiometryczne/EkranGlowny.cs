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
    public partial class EkranGlowny : Form
    {
        public EkranGlowny()
        {
            InitializeComponent();
        }

        private void BTPrzegTeksty_Click(object sender, EventArgs e)
        {
            Teksty teksty = new Teksty();
            teksty.ShowDialog();
        }

        private void BTPrzegOsoby_Click(object sender, EventArgs e)
        {
            Osoby osoby = new Osoby();
            osoby.ShowDialog();
        }
    }
}
