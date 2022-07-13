using FashionLine.Domain;
using FluentNHibernate.Mapping;

namespace FashionLine.DB.Mappings
{
    public class MeasurementMap:ClassMap<Measurement>
    {
        public MeasurementMap()
        {
            Id(measure => measure.Id);
            Map(measure => measure.Hip);
            Map(measure => measure.Waist);
            Map(measure => measure.Neck);
            Map(measure => measure.Shoulder);
        }

    }
}
