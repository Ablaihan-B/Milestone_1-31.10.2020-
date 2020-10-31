using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milestone_1_31._10._2020_.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public Food Food { get; set; }
        public string DeliveryTime { get; set; }

    }
}
