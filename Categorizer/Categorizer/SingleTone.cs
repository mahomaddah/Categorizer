﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Categorizer
{
    class SingleTone
    {
        public bool LoadEdildi { get; set; }
        public List<Set> Kumeler { get; set; }
        public Set TasiyiciNesne { get; set; }
        public bool add { get; set;}
        public string TasiyiciIsim { get; set; }
        private static SingleTone instance;

         public static SingleTone Instance()
        {
            if (instance == null)
            {
                instance = new SingleTone();
               
            }
            return instance;
        }

       
    }
}
