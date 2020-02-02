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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Sonuc_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Sonuc().ShowDialog();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ElemanListele().ShowDialog();
        }

        private void ListeleBtn_Click(object sender, EventArgs e)
        {
            if (checkedListBoxSets.SelectedItems.Count==0) { MessageBox.Show("hic bir sey secili degil"); }
           

            this.Hide();
            new ElemanListele().ShowDialog();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
