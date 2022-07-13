using FluentNHibernate.Mapping;

namespace FashionLine.DB.Mappings
{
    public class FashionLineMap:ClassMap<Domain.FashionLine>
    {
        public FashionLineMap()
        {
            Id(fashionline => fashionline.Id);
            Map(fashionline => fashionline.Name);
            HasMany(fashionline=>fashionline.Customers);
            HasMany(fashionline=>fashionline.Employees);
            HasMany(fashionline => fashionline.ClotheInventory);
        }

    }
}
