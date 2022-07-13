using FashionLine.Domain;
using FluentNHibernate.Mapping;

namespace FashionLine.DB.Mappings
{
    public class PayentInformationMap:ClassMap<PaymentInformation>
    {
        public PayentInformationMap()
        {
            Id(paymentInfo => paymentInfo.Id);
            Map(paymentInfo => paymentInfo.Price);
            Map(paymentInfo=>paymentInfo.Balance);
            HasOne(paymentInfo => paymentInfo.Order);
            Map(paymentInfo=>paymentInfo.AmountPaid);
        }

    }
}
