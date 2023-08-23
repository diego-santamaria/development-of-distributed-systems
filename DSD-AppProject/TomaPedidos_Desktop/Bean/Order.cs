using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaPedidos.Bean
{
    public class Order
    {
        public string Cardcode { get; set; }
        public string DocDueDate { get; set; }

        public List<Item> ObjItemList { get; set; }
    }
}
