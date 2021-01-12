using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vozila.Model;

namespace Vozila.Win32
{
    public partial class frmVozila : Form
    {
        public frmVozila()
        {
            InitializeComponent();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            Brod b1 = new Brod(879);
            b1.Naziv = txtNaziv.Text;
            MessageBox.Show("Pozdrav iz WinForm aplikacije "+b1);
        }
    }
}
