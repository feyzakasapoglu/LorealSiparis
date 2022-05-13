using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loreal_Entities
{
    public class AnaFirma : BaseEnitity, IEntity
    {
        public string FirmaKodu { get; set; }
        public string FirmaAdi { get; set; }
        public IList<Firma> Firmalar { get; set; }
    }
}
