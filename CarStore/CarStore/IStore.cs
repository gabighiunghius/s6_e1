using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore
{
    interface IStore
    {
        string Name { get; set; }

        IOrder EnterAndMakeOrder(IPerson person, IVehicle vehicle);

        void CancelOrder(IOrder order);
    }
}
