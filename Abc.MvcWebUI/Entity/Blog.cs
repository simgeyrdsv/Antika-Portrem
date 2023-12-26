using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Abc.MvcWebUI.Entity;

namespace Abc.MvcWebUI.Entity
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public DateTime? Tarih { get; set; }
        public string Aciklama { get; set; }
        public string BlogImage { get; set; }
        public string Şoför { get; set; }
        public string Araç { get; set; }

        public ICollection<Yorumlar> Yorumlars { get; set; }
    }
}