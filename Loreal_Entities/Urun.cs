using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loreal_Entities
{
    public class Urun:BaseEnitity,IEntity
    {
        public string UrunKodu { get; set; }
        public string UrunAdi { get; set; }
        public string Aciklama { get; set; }
        public Birim Birim { get; set; }

        public string Barkod { get; set; }

        public IList<Kategori> Kategoriler { get; set; }

        public IList<UrunFiyat> Fiyatlar { get; set; }

        public decimal MinStokSeviyesi { get; set; }
        public decimal StokMiktari { get; set; }

        public IList<UrunFoto> Fotograflar { get; set; }

        public Marka Marka { get; set; }

        public DateTime UretimTarihi { get; set; }

        public DateTime SonKullanmaTarihi { get; set; }

        public IList<Tedarikci> Tedarikciler { get; set; }


    }
}
