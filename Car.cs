using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesGarage
{
    class Car : Vehicle
    {

		public string GearBox { get; set; }

		public int NumberOfSeats { get; set; }

		public Car(string color, double width, double length, double height, string brand,  int numberofwheels, string type, int numberOfSeats, string gearBox) : base(color, width, length, height, brand, numberofwheels,type)
		{
			NumberOfSeats = numberOfSeats;
			GearBox = gearBox;
		}

		public override string ToString()
		{
			return base.ToString() ;
		}
	}
}
