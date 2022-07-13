namespace FashionLine.Domain
{
    public class Clothe:BaseEntity
    {
        public virtual Measurement Measurement { get; set; }
        public virtual ClotheType ClotheType { get; set; }
        public virtual Order Order { get; set; }
    }
}
