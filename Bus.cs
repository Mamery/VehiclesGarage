using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesGarage
{
    class Bus : Vehicle
    {
		public string FuelType { get; set; }

		public int NumberOfSeats { get; set; }
		

		public Bus(string color, double width, double length, double height, string brand, int numberofwheels, string type, int numberOfSeats, string fuelType) : base(color, width, length, height, brand, numberofwheels,type)
		{
			NumberOfSeats = numberOfSeats;
			FuelType = fuelType;
	
		}
		public override string ToString()
		{
			return base.ToString();
		}

	}
}
