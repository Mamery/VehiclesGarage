using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesGarage
{
    class Boat : Vehicle
    {
		public double Speed { get; set; }

		public bool IsCommercialBoat { get; set; }
		public Boat(string color, double width, double length, double height, string brand, int numberofwheels, string type, double speed, bool isCommercialBoat) : base(color, width, length, height, brand, numberofwheels,type)
		{
			Speed = speed;
			IsCommercialBoat = isCommercialBoat;
		}

		public override string ToString()
		{
			return base.ToString();
		}
	}
}
