using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loreal_Entities
{
    public class Kategori:BaseEnitity,IEntity
    {
        public string KategoriAdi { get; set; }
        public string Aciklama { get; set; }
        public IList<Urun>Urunler{ get; set; }
    }
}
