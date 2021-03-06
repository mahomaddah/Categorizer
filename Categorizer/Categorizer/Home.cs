﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Categorizer
{
    public partial class Home : Form
    {
        SingleTone sets = SingleTone.Instance();
        

        public Home()
        {
            InitializeComponent();
            veriAktar();
            if (sets.LoadEdildi == false)
            {                             
                sets.LoadEdildi = true;
                LoadEt();
                checkBoxYenile();
            }           
            KayitEt();
        }
        private void sonucHesapla()
        {
            List<Set> tempListe = new List<Set>();
            Set tempSet;

            int i = 1;
            string sorguIsmi = "";
            foreach (string s in checkedListBoxSets.CheckedItems)
            {
                sorguIsmi += "("+s+")";
                if (i < checkedListBoxSets.CheckedItems.Count)
                {
                    sorguIsmi += " n ";
                }
                else
                {
                    sorguIsmi += " :";
                }
                i++;
               tempSet = new Set();
               tempSet= sets.Kumeler.Find(x => x.SetName == s);
               tempListe.Add(tempSet);
            }
            tempSet = null;
            tempSet = new Set();
            bool m = false;
            foreach(Set x in tempListe)
            {
                if (m == false)
                {
                    tempSet = x;
                }
                else
                {
                    tempSet = KesisimAl(x, tempSet);
                }
                m = true;
            }
            sets.TasiyiciIsim = sorguIsmi;
            sets.TasiyiciNesne = tempSet;
            
            
        }
        private Set KesisimAl(Set bir,Set iki)
        {
            Set tempSeti = new Set();
            tempSeti.elements = new List<Element>();
            Element[] bira = new Element[bir.elements.Count];
            Element[] ikia = new Element[iki.elements.Count];
            if(bir.elements.Count==0||iki.elements.Count==0)
            { MessageBox.Show("Lütfen yeterli elemana sahip kümeler seçiniz..."); }
            else { 
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
            sets.add = true;

           sets.TasiyiciNesne = null;
           sets.TasiyiciNesne = new Set();
           sets.TasiyiciNesne.elements = new List<Element>();
            this.Hide();
            new ElementListele().ShowDialog();
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
                sets.add = false;
                foreach(string s in checkedListBoxSets.CheckedItems)                                  
                sets.TasiyiciNesne = sets.Kumeler.Find(x => x.SetName == s);
                this.Hide();
                new ElementListele().ShowDialog();



            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (checkedSayisi() < 1) { Hata.HataGoster(2); }
            else
            {
                foreach (string s in checkedListBoxSets.CheckedItems)
                sets.Kumeler.RemoveAll(x => x.SetName == s);
                checkBoxYenile();
                KayitEt();
            }
        }
        private void veriAktar()
        {
            if (sets.Kumeler == null)
                sets.Kumeler = new List<Set>();
            if (sets.TasiyiciNesne == null)
                sets.TasiyiciNesne = new Set();
            if (sets.TasiyiciNesne.elements == null)
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

            //if (sets.Kumeler.Count == 0)//gunceleme olayi yok sadece veri yoksa kumelerde veri ekler varsa ve eksikse olayini ekle
            //{
            //    sets.Kumeler.Add(set);
            //    sets.Kumeler.Add(set2);
            //}


            checkBoxYenile();
                    
            
        }

        private void checkBoxYenile()
        {
            checkedListBoxSets.Items.Clear();
                       
            foreach (Set s in sets.Kumeler)
            {
                checkedListBoxSets.Items.Add(s.SetName);
            }
            
        }
        List<string> KatitEdici()
        {
            char[] charA;
            List<string> sonuc = new List<string>();
           foreach(Set set in sets.Kumeler)
            {
                sonuc.Add(set.SetName);
                foreach(Element element in set.elements)
                {
                    charA = new char[element.Name.Length];
                    charA = element.Name.ToCharArray();
                    if (charA[0] != '•' )
                        sonuc.Add("• " + element.Name);
                    else
                    {
                        sonuc.Add(element.Name);
                    }
                }
            }
                
            return sonuc;
        }
        void KayitAlici(List<string> liste)
        {      
            Element element;
            char[] charA;
            Set tempSet;
            string EnSonEklenenKumeIsmi="";
       
            foreach (string s in liste)
            {
              
                charA = new char[s.Length];
                charA = s.ToCharArray();
                if (0 < s.Length)
                { 
                     if (charA[0] != '•')
                    {
                        tempSet = new Set();
                        tempSet.elements = new List<Element>();
                        tempSet.SetName = s;
                        sets.Kumeler.Add(tempSet);
                        EnSonEklenenKumeIsmi = s;
                    }
                    else if (charA[0]== '•')
                    {
                        element = new Element();
                        element.Name = s;                                                                            
                        sets.Kumeler.Find(x => x.SetName == EnSonEklenenKumeIsmi).elements.Add(element);
                    }

                }

            }
        }

        string filePath = @"kumeler.txt"; //debug da kumeler.txt te

        void LoadEt()
        {
            List<string> sik = null;
             sik = new List<string>();
            sik = File.ReadAllLines(filePath, Encoding.UTF8).ToList();
            KayitAlici(sik);
        }
        void KayitEt()
        {
            
            File.WriteAllLines(filePath,KatitEdici());
        }

    }
}
