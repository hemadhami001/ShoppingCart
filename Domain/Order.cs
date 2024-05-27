using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Order
    {
        public int Id { get; set; }

        public int OrderDate { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
