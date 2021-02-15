using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesGarage
{
    class Airplane : Vehicle
    {
        
        public int NumberOfEngines { get; set; }
        public int CylinderVolume { get; set; }
        public int NumberOfSeats { get; set; }
        public Airplane(string color, double width, double length, double height, string brand, int numberofwheels, string type, int cylinderVolume, int numberOfSeats, int numberOfEngines) : base(color, width, length, height, brand, numberofwheels,type)
        {
            NumberOfEngines = numberOfEngines;
            CylinderVolume = cylinderVolume;
            NumberOfSeats = numberOfSeats;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
