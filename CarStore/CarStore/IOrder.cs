using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore
{
    interface IOrder
    {
        IPerson Person { get; set; }

        IVehicle Vehicle { get; set; }

        DateTime DeliveryDate { get; set; }
    }
}
