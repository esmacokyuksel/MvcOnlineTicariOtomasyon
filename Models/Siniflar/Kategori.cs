﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Kategori
    {
        [Key]
        public int KategoriId { get; set; }
        [Column(TypeName = "VarChar")]
        [StringLength(30)]
        public string KategoriAd { get; set; }
        public ICollection<Urun> Uruns { get; set; }
        //Her bir kategoride birden fazla urun yer alabilir demek.

    }
}