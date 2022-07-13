using FashionLine.Domain;
using FluentNHibernate.Mapping;

namespace FashionLine.DB.Mappings
{
    public class OrderMap:ClassMap<Order>
    {
        public OrderMap()
        {
            Id(order=>order.Id);
            Map(order=>order.DeliveryAddress);
            Map(order=>order.DeliveryDate);
            References(order => order.Owner);
            HasMany(order => order.Clothes);
            HasOne(order => order.PaymentInfo).PropertyRef(paymentInfo=>paymentInfo.Order);
        }
    }
}
