namespace Loreal_Entities
{
    public class KontaktKisi:BaseEnitity,IEntity
    {
        public int FirmaId { get; set; }
        public Firma Firma { get; set; }
        public string Departman { get; set; }


    }
}