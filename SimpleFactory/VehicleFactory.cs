using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
   public class VehicleFactory
    {
        public string type;
        public Vehicle NewVehicle(string type) {


            if (type == "Truck")
            {
                return new Vehicle(){NumberWheels = 4, Name = "truck", paintColor = "White", Type = VehicleType.Truck, SalesPrice = 40000.99f };
            }

            if (type == "Car")
            {
                return new Vehicle() { NumberWheels = 4, Name = "Car", paintColor = "White", Type = VehicleType.Car, SalesPrice = 20000.99f };
            }

            if (type == "Boat")
            {
                return new Vehicle() { NumberWheels = 0, Name = "Boat", paintColor = "Blue", Type = VehicleType.Boat, SalesPrice = 80000.99f };
            }

            if (type == "Motorcycle")
            {
                return new Vehicle() { NumberWheels = 2, Name = "Motorcycle", paintColor = "Black", Type = VehicleType.Motorcycle, SalesPrice = 25000.99f };
            }

            if (type == "ATV")
            {
                return new Vehicle() { NumberWheels = 4, Name = "ATV", paintColor = "Red", Type = VehicleType.Motorcycle, SalesPrice = 10000.99f };
            }

            if (type == "RV")
            {
                return new Vehicle() { NumberWheels = 6, Name = "RV", paintColor = "Tan", Type = VehicleType.Motorcycle, SalesPrice = 125000.99f };
            }

            if (type == "Semi")
            {
                return new Vehicle() { NumberWheels = 18, Name = "Semi", paintColor = "Yellow", Type = VehicleType.Motorcycle, SalesPrice = 225000.99f };
            }


            else
            {
                throw new Exception("Vehicle Type Not Found");
            }
        }


    }
}
