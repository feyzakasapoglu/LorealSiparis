namespace Loreal_Entities
{
    public class Firma:BaseEnitity,IEntity
    {
        public AnaFirma AnaFirma { get; set; }
        public string FirmaKodu { get; set; }
        public string FirmaAdi { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public string Adres{ get; set; }
        public string OzelKod1 { get; set; }
        public string OzelKod2 { get; set; }
        public string IletisimNo { get; set; }
        public string Email { get; set; }
        public IList<KontaktKisi> Kisiler { get; set; }

        public int PersonelId { get; set; }

        public Personel Personel { get; set; }
        public decimal RiskLimiti { get; set; }

        public string OzelNot { get; set; }

        // Bankalara soruldugunda verilecek bilgiye istinaden tutulacak istihbarat alanları
        public bool IstihbaratOnay { get; set; }

        public string İstihbaratNot { get; set; }



    }
}