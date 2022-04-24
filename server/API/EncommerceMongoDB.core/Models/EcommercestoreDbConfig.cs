using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncommerceMongoDB.core
{
    public class EcommercestoreDbConfig
    {
           public string Database_Name { get; set; }
           public string Trademark_Collection { get; set; }
           public string Connection_String { get; set; }
           public string Product_Collection { get; set; }

           public  string Address_Collection { get; set; }

    }
}
