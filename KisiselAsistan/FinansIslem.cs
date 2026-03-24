using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselAsistan
{
    //Gelir mi gider mi olduğunu belirten seçenekler
    public enum IslemTuru { Gelir,Gider }
    public class FinansIslem
    {
        public int Id { get; set; } // Her işlem için benzersiz numara
        public string Aciklama { get; set; } // Örn: "Market Alışverişi"
        public decimal Tutar { get; set; } // Örn: 150.50
        public IslemTuru Tur { get; set; } // Gelir veya Gider
        public DateTime Tarih { get; set; } // İşlemin yapıldığı zaman
        public string Kategori { get; set; } // Örn: "Mutfak", "Maaş", "Fatura"

        // Listede düzgün görünmesi için ToString metodunu eziyoruz.
        public override string ToString()
        {
            return $"{Tarih.ToShortDateString()} - {Tur}: {Aciklama} ({Tutar} TL)";
        }
    }
}
