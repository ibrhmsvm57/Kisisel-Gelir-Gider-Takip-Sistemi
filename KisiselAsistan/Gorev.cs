using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselAsistan
{
    public class Gorev
    {
        public int Id { get; set; }
        public string Baslik { get; set; } // Örn: "Faturayı öde"
        public bool TamamlandiMi { get; set; } // Yapıldı mı?
        public DateTime SonTarih { get; set; } // Ne zamana kadar yapılmalı?
    }
}
