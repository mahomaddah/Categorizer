using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Categorizer
{
    public static class Hata
    {

        public static void HataGoster(int no)
        {
            string HataMetni="";
            switch (no)
            {
                case 1: HataMetni = "Lütfen sadece 1 kümeyi seçtiğinizden emin olunuz.";break;
                case 2: HataMetni = "Lütfen en az 1 kümeyi seçtiğinizden emin olunuz."; break;
                case 3: HataMetni = "Lütfen yeni küme ismi giriniz..."; break;
                case 4: HataMetni = "Lütfen yeni eleman ismi giriniz..."; break;


            }
            System.Windows.Forms.MessageBox.Show(HataMetni);
        }
    }
}
