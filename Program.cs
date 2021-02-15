using System;

namespace VehiclesGarage
{
    class Program
    {
        // static ConsoleUI ui = new ConsoleUI();
        static  GarageHandler ghandler = new GarageHandler();
        static Garage<Vehicle> garage = ghandler.CreateGarage(7);
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 5, 6, 7, 8, 0) of your choice"
                    + "\n1. Populate he garage with vehicles"
                    + "\n2. Show the list of vehicles in the garage"
                    + "\n3. Vehicles type and their number"
                    + "\n4. Find vehicle on their color and number of wheels"
                    + "\n5. Find vehicle on their registration number"
                    + "\n6. Find vehicle on their type and number of wheels"
                    + "\n7. Find vehicle on their color"
                    + "\n8. Remove vehicle from garage"
                    + "\n0. Exit the application");

                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    ghandler.PrintMessage("Please enter some input!");
                }
                switch (input)
                {

                    case '1':                       
                        ghandler.PopulateGarage();
                        ghandler.PrintMessage("Your garage is now populated with vehicles");

                        break;
                    case '2':
                        ghandler.PrintMessage("-------List all vehicles in the garage------");
                        ghandler.PrintAllVehicles(garage);
                        ghandler.PrintMessage("-------List is ended------");
                        ghandler.PrintMessage();
                        break;
                    case '3':
                        ghandler.PrintMessage("------- Vehicles specified by type and their number in the garage ------");
                        ghandler.ClassifyVehiclesByType(garage);
                        ghandler.PrintMessage("-------Vehicle is found------");
                        ghandler.PrintMessage();
                        break;
                    case '4':
                        ghandler.PrintMessage("-------Find black vehicles with two wheels------");
                        ghandler.FindVehicleCW(garage,"Black",2);
                        ghandler.PrintMessage("------Vehicles found-------");
                        ghandler.PrintMessage();
                        break;
                    case '5':
                        ghandler.PrintMessage("-------Find Vehicle given registration number on the fly------");
                        ghandler.FindVehicleRg(garage);
                        ghandler.PrintMessage("------Vehicle found-------");
                        ghandler.PrintMessage();
                        break;
                    case '6':
                        ghandler.PrintMessage("-------Find Motorcykel Vehicles with tree wheels------");
                        ghandler.FindVehicleWT(garage,"Motorcykel", 3);
                        ghandler.PrintMessage("------Vehicle found-------");
                        ghandler.PrintMessage();
                        break;
                    case '7':
                        ghandler.PrintMessage("-------Find yellow Vehicles------");
                        ghandler.FindVehicleC(garage, "Yellow");
                        ghandler.PrintMessage("------Vehicle found-------");
                        ghandler.PrintMessage();
                        break;           
                    case '8':
                        ghandler.PrintMessage("-------Remove from the fly the three motorcycles from the list------");
                        ghandler.RemoveVehicle();
                        ghandler.PrintMessage("You have now removed the 3 motocycles from the list");
                        ghandler.PrintMessage();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        ghandler.PrintMessage("Please enter some valid input (0, 1, 2, 3, 4,5,6,7)");
                        break;
                }
            }


        }
    }
}
