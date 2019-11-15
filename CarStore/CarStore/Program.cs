using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore
{
    class Program
    {
        static void Main(string[] args)
        {

//            Problem 4.Model in c# the following business model
//Store(IStore)
//Customer(IPerson)
//Order(IOrder)
//Producer(IProducer)
//Car(IVehicle)

//Inside the main method to implement the following behavior:
//            Alex intended to buy a Ford Focus 2015 model.
//He walked to the FordStore in Bucuresti and agreed to buy one for 15000Euro.
//They informed him it will take 4 weeks for delivery.
//He then decided to visit another store SkodaStore and agreed to buy one for 14000Euro and 3 weeks delivery.
//He then canceled his original order from the FordStore.
//After 3 weeks, he received the model.



            IPerson andrei = new Client { Name = "Andrei" }; 
            IPerson catalin = new Client { Name = "Catalin" };

            IStore ford = new Store("Ford");
            IStore skoda = new Store("Skoda");
            IStore audi = new Store("Audi");
           
            IVehicle focus = new Vehicle
            {
                Name = "Focus",
                Price = 6000,
                Producer = new Producer { Name = "Ford" }
            };

            
            IVehicle fabia = new Vehicle
            {
                Name = "Fabia",
                Price = 5000,
                Producer = new Producer { Name = "Skoda" }
            };



            IOrder focusOrder = ford.EnterAndMakeOrder(andrei, focus);

            IOrder skodaOrder = skoda.EnterAndMakeOrder(catalin, fabia);

            if (focusOrder.DeliveryDate < skodaOrder.DeliveryDate)
            {
                skoda.CancelOrder(skodaOrder);
            }
            else
            {
                ford.CancelOrder(focusOrder);
            }
        }
    }
}
