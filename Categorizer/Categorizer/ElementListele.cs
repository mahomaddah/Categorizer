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
    public partial class ElementListele : Form
    {
        
        SingleTone sets = SingleTone.Instance();
        public ElementListele()
        {
            InitializeComponent();
            checkBoxYenile();          
        }
        private void checkBoxYenile()
        {
            
            if (sets.add == false)
            {
                checkedListBoxElements.Items.Clear();
                foreach (Element element in sets.TasiyiciNesne.elements)
                {
                    checkedListBoxElements.Items.Add(element.Name);
                }
                KumeIsmilbl.Text = "Seçili küme : " + sets.TasiyiciNesne.SetName + " :";
                KumeisimTxtbx.Text = sets.TasiyiciNesne.SetName;
                
            }
            else
            {
                checkedListBoxElements.Items.Clear();
                KumeIsmilbl.Text = "küme ismi giriniz : ";  
                KumeisimTxtbx.Text = "küme ismi giriniz ... ";
                sets.add = false;
            }
        }
        private void GeriDon_Click(object sender, EventArgs e)
        {
            if (sets.TasiyiciNesne.SetName==""&& checkedListBoxElements.Items.Count!=0 )
            {
                Hata.HataGoster(3);
            }
             else
            {
                this.Hide();
                new Home().ShowDialog();
            }
           
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (checkedListBoxElements.CheckedItems.Count == 0)
            {
                MessageBox.Show("lütfen önce silmek istediklerinizi seçiniz....");
            }
            else
            {
                foreach(string name in checkedListBoxElements.CheckedItems)             
                sets.TasiyiciNesne.elements.RemoveAll(x => x.Name == name);
                  
                sets.Kumeler.RemoveAll(x => x.SetName == sets.TasiyiciNesne.SetName);
                sets.Kumeler.Add(sets.TasiyiciNesne);
                checkBoxYenile();
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if(ElemanIsimTexbox.Text== "Eleman ismi giriniz....")
            {
                Hata.HataGoster(4);
            }
            else
            {
                Element element = new Element();
                element.Name = ElemanIsimTexbox.Text ;

                sets.TasiyiciNesne.elements.Add(element);
                sets.Kumeler.RemoveAll(x => x.SetName == sets.TasiyiciNesne.SetName);
                sets.Kumeler.Add(sets.TasiyiciNesne);
                checkBoxYenile();
            }
        }

        private void isimDegisBtn_Click(object sender, EventArgs e)
        {
            if (KumeisimTxtbx.Text == sets.TasiyiciNesne.SetName|| KumeisimTxtbx.Text== "küme ismi giriniz ... ")
            {
                Hata.HataGoster(3);
            }
            else
            {
                sets.TasiyiciNesne.SetName = KumeisimTxtbx.Text;
                sets.Kumeler.RemoveAll(x=>x.SetName==sets.TasiyiciNesne.SetName);
                sets.Kumeler.Add(sets.TasiyiciNesne);
                KumeIsmilbl.Text = "Seçili küme : " + sets.TasiyiciNesne.SetName + " :";
            }
        }
    }
}
