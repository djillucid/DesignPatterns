using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            var values = Enum.GetValues(typeof(VehicleType));

            //Test each f the vehicle types in the enumeration for simple factory creation
            foreach (var item in values)
            {
                Console.WriteLine("The item is: " + item + ":");
                MfrPlant myPlant = new MfrPlant();
                myPlant.NewVehicle(item.ToString());
                Console.WriteLine("Vehicle info: Type {0} - Color {1} - Number of Wheels {2}\n", myPlant.vehicle.Name, myPlant.vehicle.paintColor, myPlant.vehicle.NumberWheels);

             


            }



            Console.ReadLine();

        }
    }
}
