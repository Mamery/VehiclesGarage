using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesGarage
{
    class UI
    {
        public string GetInput()

        {

            return Console.ReadLine();

        }

        public void Print()

        {

            Console.WriteLine(); //write to the console

        }

        public void Print(string message)

        {

            Console.WriteLine(message); //write to the console

        }

        public void Print(string message, string type, int c)

        {

            Console.WriteLine(message,type,c); //write to the console

        }




        public void Print(Vehicle vehicle)

        {

            Console.WriteLine(vehicle);

        }
    }
}
