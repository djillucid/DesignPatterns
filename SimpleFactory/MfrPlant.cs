using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
   public class MfrPlant
    {
        public VehicleFactory factory;
        public Vehicle vehicle;

        public MfrPlant()
        {
            this.factory = new VehicleFactory();
            
        }

        public Vehicle NewVehicle(string type) {

           this.vehicle = this.factory.NewVehicle(type);

            return this.vehicle;
        }

        public void PaintVehicle(Vehicle v) { }
        public void WashVehicle(Vehicle v) { }
        public void SetPrice(Vehicle v) { }

    }
}
