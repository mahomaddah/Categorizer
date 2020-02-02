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
            SingleTone sets = SingleTone.Instance();
            sets.Kumeler = new List<Set>();
            Set set = new Set();
            set.elements = new List<Element>();
            Element element = new Element();
            Element element2 = new Element();
            sets.TasiyiciNesne = new Set();
            sets.TasiyiciNesne.elements = new List<Element>();

            element.Name = "abdulmecit";
            element2.Name = "abdulhemit";
            set.SetName = "pezevenkler";

            set.elements.Add(element);
            set.elements.Add(element2);
            sets.Kumeler.Add(set);
            sets.TasiyiciNesne.elements.Add(element2);
            sets.TasiyiciNesne.elements.Add(element);

        }

        private void Sonuc_Click(object sender, EventArgs e)
        {
            if (checkedSayisi() < 1) { Hata.HataGoster(2); }
            else
            {
                this.Hide();
                new Sonuc().ShowDialog();



            }

        }

        private void addBtn_Click(object sender, EventArgs e)
        {           
                                 
            this.Hide();
            new ElemanListele().ShowDialog();
        }
        private short checkedSayisi()
        {
            short sonuc =0;
            foreach(string s in checkedListBoxSets.CheckedItems)
            {
                sonuc++;
            }
            return sonuc;
        }
        private void ListeleBtn_Click(object sender, EventArgs e)
        {
            if (checkedSayisi() != 1) { Hata.HataGoster(1); }
            else
            {
                this.Hide();
                new ElemanListele().ShowDialog();



            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (checkedSayisi() < 1) { Hata.HataGoster(2); }
            else
            {
             



            }
        }
    }
}
