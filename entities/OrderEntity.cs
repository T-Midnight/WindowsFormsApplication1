using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.entities
{
    class OrderEntity
    {
        public int id_order;
        DateTime order_date;
        DateTime order_time;
        string order_status;
        double total_sum;

        public OrderEntity() { 
        
        }

    }
}
