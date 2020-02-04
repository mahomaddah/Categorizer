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
        SingleTone sets = SingleTone.Instance();
        public Sonuc()
        {
            InitializeComponent();
            checkedListBoxSonuc.Items.Clear();
            foreach(Element x in sets.TasiyiciNesne.elements)
            {
                checkedListBoxSonuc.Items.Add(x.Name);
            }
            labelSonuc.Text = sets.TasiyiciNesne.SetName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().ShowDialog();
        }
    }
}
