using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Categorizer
{
    public partial class Sonuc : Form
    {
        public Sonuc()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            new kumeler().ShowDialog();
        }
    }
}
