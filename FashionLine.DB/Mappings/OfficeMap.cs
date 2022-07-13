using FashionLine.Domain;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionLine.DB.Mappings
{
    public class OfficeMap:ClassMap<Office>
    {
        public OfficeMap()
        {
            Id(off => off.Id);
        }
    }
}
