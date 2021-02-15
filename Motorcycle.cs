using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesGarage
{
    class Motorcycle : Vehicle
    {
		public double CylinderVolume { get; set; }

		public int NumberOfEngines { get; set; }
		
		public Motorcycle(string color, double width, double length, double height, string brand, int numberofwheels, string type, int numberOfEngines, double cylinderVolume) : base(color, width, length, height, brand, numberofwheels,type)
		{
			NumberOfEngines = numberOfEngines;
			CylinderVolume = cylinderVolume;
			Type = "Motorcykel";
		}
		public override string ToString()
		{
			return base.ToString();
		}

	}
}
