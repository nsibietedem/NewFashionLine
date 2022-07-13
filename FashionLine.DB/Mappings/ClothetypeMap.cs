using FashionLine.Domain;
using FluentNHibernate.Mapping;
using NHibernate.SqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionLine.DB.Mappings
{
    public class ClothetypeMap:ClassMap<Enum>
    {
        new public bool Equals(object x, object y)
        {
            return object.Equals(x, y);
        }

        public int GetHashCode(object x)
        {
            return x.GetHashCode();
        }

        public object NullSafeGet(IDataReader rs, string[] names, object owner)
        {
            object r = rs[names[0]];
            var value = (string)r;

            if (string.IsNullOrEmpty(value))
                throw new Exception("Invalid Status");

            switch (value)
            {
                case "W":
                    return null;
                case "D":
                    return null;

                default:
                    throw new Exception("Invalid Project Type");

            }


        }

        public void NullSafeSet(IDbCommand cmd, object value, int index)
        {
            object paramVal = 0;
 //           switch ((ClotheType)value)
 //           {

 //               case ClotheType.WebProject:
 //                   paramVal =
 //"W"; break;
 //               case ClotheType.DesktopProject:
 //                   paramVal =
 //    "D"; break;
 //               default:
 //                   throw new Exception("Invalid Project Type");
 //           }
            var parameter = (IDataParameter)cmd.Parameters[index];
            parameter.Value = paramVal;
        }

        public object DeepCopy(object value)
        {
            return value;
        }

        public object Replace(object original, object target, object owner)
        {
            return original;
        }

        public object Assemble(object cached, object owner)
        {
            return cached;
        }

        public object Disassemble(object value)
        {
            return value;
        }

        public SqlType[] SqlTypes
        {
            get { return new SqlType[] { new StringSqlType() }; }
        }

        public Type ReturnedType
        {
            get { return typeof(ClotheType); }
        }

        public bool IsMutable
        {
            get { return false; }
        }
    }
}

