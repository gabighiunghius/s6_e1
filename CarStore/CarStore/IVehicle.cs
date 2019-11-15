using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore
{
    interface IVehicle
    {
        IProducer Producer { get; set; }

        string Name { get; set; }

        decimal Price { get; set; }
    }
}
