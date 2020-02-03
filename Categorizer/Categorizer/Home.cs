﻿using System;
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
        SingleTone sets = SingleTone.Instance();

        public Home()
        {
            InitializeComponent();
            veriAktar();
        }
        private void sonucHesapla()
        {
            List<Set> tempListe = new List<Set>();
            Set tempSet;


            foreach (string s in checkedListBoxSets.CheckedItems)
            {
               tempSet = new Set();
               tempSet= sets.Kumeler.Find(x => x.SetName == s);
               tempListe.Add(tempSet);
            }
            tempSet = null;
            tempSet = new Set();
            bool i = false;
            foreach(Set x in tempListe)
            {
                if (i == false)
                {
                    tempSet = x;
                }
                else
                {
                    tempSet = KesisimAl(x, tempSet);
                }
                i = true;
            }
            sets.TasiyiciNesne = tempSet;
        }
        private Set KesisimAl(Set bir,Set iki)
        {
            Set tempSeti = new Set();
            tempSeti.elements = new List<Element>();
            Element[] bira = new Element[bir.elements.Count];
            Element[] ikia = new Element[iki.elements.Count];
            bira = bir.elements.ToArray();
            ikia = iki.elements.ToArray();

            for(int i = 0; i < bir.elements.Count; i++)
            {
                for (int j = 0; j < bir.elements.Count; j++)
                {
                    if (bira[i].Name == ikia[j].Name)
                    {
                        tempSeti.elements.Add(bira[i]);
                        continue;
                    }
                }
                
            }

            return tempSeti;
        }
        private void Sonuc_Click(object sender, EventArgs e)
        {
            if (checkedSayisi() < 1) { Hata.HataGoster(2); }
            else
            {
                sonucHesapla();
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
        private void veriAktar()
        {
            if (sets.Kumeler == null)
                sets.Kumeler = new List<Set>();
            if (sets.TasiyiciNesne == null)
                sets.TasiyiciNesne = new Set();
            if(sets.TasiyiciNesne.elements==null)
            sets.TasiyiciNesne.elements = new List<Element>();

            Set set = new Set();
            Set set2 = new Set();
            set.elements = new List<Element>();
            set2.elements = new List<Element>();
            
            //veri aktarma basla
            Element element = new Element();
            Element element2 = new Element();
            Element element3 = new Element();
            Element element4 = new Element();
            Element element5 = new Element();
            Element element6 = new Element();
            
            element.Name = "Post nazal akıntı";
            element2.Name = "Astım";
            element3.Name = "GÖR";
            element4.Name = "ACE inhibitörleri";

            element5.Name = "Eosinofilik bronşit";

            element6.Name = "Sigara";

            
            /*    
                ortallar:
                • Post nazal akıntı
                • Astım
                • GÖR
                • ACE inhibitörleri

                Kronik öksürük nedenleri
                
                • Eosinofilik bronşit
                • Bronşektazi
                • Malign/benign akciğer tm leri
                • Tüberküloz                             

                Nonprodüktif öksürük nedenleri
                
                • Sigara                                             
                • Viral ÜSYE
                • Plevra hastalıkları
                • Mediasten hastalıkları
                • İAH
                • Dış kulak yolu hastalıkları           
             */

            set.SetName = "Kronik öksürük nedenleri";
            set2.SetName = "Nonprodüktif öksürük nedenleri";

            set.elements.Add(element);
            set.elements.Add(element2);
            set.elements.Add(element3);
            set.elements.Add(element4);
            set.elements.Add(element5);

            set2.elements.Add(element);
            set2.elements.Add(element2);
            set2.elements.Add(element3);
            set2.elements.Add(element4);
            set2.elements.Add(element6);
            //veri aktarma bitis
            bool tutu = false;
            if (tutu==false)
            {
                sets.Kumeler.Add(set);
                sets.Kumeler.Add(set2);
                tutu = true;
            }
            
           
            checkedListBoxSets.Items.Clear();
            
            foreach (Set s in sets.Kumeler)
            {
               checkedListBoxSets.Items.Add(s.SetName);
            }

        }
    }
}
