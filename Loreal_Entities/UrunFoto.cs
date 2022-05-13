namespace Loreal_Entities
{
    public class UrunFoto:BaseEnitity,IEntity
    {
        public Urun Urun { get; set; }
        public string Path { get; set; }
        public string Url { get; set; }
    }
}