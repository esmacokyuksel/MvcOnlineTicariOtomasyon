﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Personel
    {
        [Key]

        //Keyi croud işlemleri için yazıyoruz
        public int  PersonelId { get; set; }
        public string PersonelAd { get; set; } 
        public string PersonelSoyad { get; set;}
        public string PersonelGorsel { get; set; }

    }
}