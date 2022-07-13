using FashionLine.Domain;
using FluentNHibernate.Mapping;

namespace FashionLine.DB.Mappings
{
    public class EmployeeMap:ClassMap<Employee>
    {
        public EmployeeMap()
        {
            Id(employ => employ.Id);
            Map(employ=>employ.FirstName);
            Map(employ=>employ.LastName);  
            Map(employ=>employ.EmployeeRole).CustomType<RoleMap>();
            
        }

    }
}
