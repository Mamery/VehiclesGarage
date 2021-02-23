using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehiclesGarage
{
    class GarageHandler
    {

        private UI ui = new UI();
        private Garage<Vehicle> garage;
        private Motorcycle m1,m2,m3; // why?
        public Garage<Vehicle> CreateGarage(int capacity) 
        {
           garage = new Garage<Vehicle>(capacity) ;
           return garage;
        }

        // half the number of rows by garage.Add(new Motorcycle...)
        public void PopulateGarage()
        {
            m1 = new Motorcycle("Black", 2.5, 3.5, 1.75, "Toyota", 4, "Motorcycle", 5, 6);
            m2 = new Motorcycle("Green", 2.5, 3.5, 1.75, "Toyota", 4, "Motorcycle", 5, 6);
            m3 = new Motorcycle("Green", 2.5, 3.5, 1.75, "Toyota", 3, "Motorcycle", 5, 6);
            Airplane air = new Airplane("Yellow", 2.5, 3.5, 1.75, "Air France", 4, "Airplane", 6767, 986, 4);
            Airplane air2 = new Airplane("Yellow", 2.5, 3.5, 1.75, "Air France", 4, "Airplane", 6767, 986, 4);
            Boat boa = new Boat("Blue", 2.5, 3.5, 1.75, "BMW", 4, "Boat", 6767, false);
            Boat boa2 = new Boat("Blue", 2.5, 3.5, 1.75, "BMW", 4, "Boat", 6767, false);
            Bus bus = new Bus("White", 2.5, 3.5, 1.75, "Renault", 4, "Bus", 6767, "Diesel");
            Bus bus2 = new Bus("White", 2.5, 3.5, 1.75, "Renault", 4, "Bus", 6767, "Diesel");
            Car car = new Car("Orange", 2.5, 3.5, 1.75, "Mercedes", 4, "Car", 6767, "Manual");
            Bus bus3 = new Bus("White", 2.5, 3.5, 1.75, "Renault", 4, "Bus", 6767, "Diesel");
            Car car2 = new Car("Black", 2.5, 3.5, 1.75, "Mercedes", 2, "Car", 6767, "Manual");
            Car car3 = new Car("Black", 2.5, 3.5, 1.75, "Mercedes", 2, "Car", 6767, "Manual");
            //Car car4 = new Car("Orange", 2.5, 3.5, 1.75, "Mercedes", 4, "Car", 6767, "Manual");
            garage.Add(air);
            garage.Add(boa);
            garage.Add(bus);
            garage.Add(car);
            garage.Add(m1);
            garage.Add(m2);
            garage.Add(m3);
            garage.Add(air2);
            garage.Add(boa2);
            garage.Add(bus2);
            garage.Add(bus3);
            garage.Add(car2);
            garage.Add(car3);
            garage.Add(new Car("Orange", 2.5, 3.5, 1.75, "Mercedes", 4, "Car", 6767, "Manual"));

        }


        public void RemoveVehicle()
        {
            /*
             * Vehicles are not stored in the file. We get vehicles from the fly
             * and delete the three motorcycles from the list.
             */
            var reg = Console.ReadLine();

            var v = garage.FirstOrDefault(v => v.RegistrationsNumber == reg);

            garage.Remove(v);
            garage.Remove(m2);
            garage.Remove(m3);

        }

        public void PrintMessage(string message)
        {
            ui.Print(message);
        }

        

        public void PrintMessage()
        {
            ui.Print();
        }

        // Why have garage as a parameter?
        public void PrintAllVehicles(/*Garage<Vehicle> garage*/)
        {
            foreach (var vehicle in garage)
            {
                ui.Print(vehicle);
            }
        }

        // Never used
        public void FindVehicleByRegN(/*Garage<Vehicle> garage,*/string registraNumber)
        {   
            
            Vehicle[] arr = garage.InternalArray;
            

            var regis = from v in arr
                      where v.RegistrationsNumber.Contains(registraNumber)
                      select v;
            foreach (var i in regis)
            {
                ui.Print(i);
            }

        }

        
        public void ClassifyVehiclesByType(/*Garage<Vehicle> garage*/)
        {

            Dictionary<string, int> dic = new Dictionary<string, int>();
            Vehicle[] arr = garage.InternalArray;

            for (int i = 0; i < arr.Length; i++)
            {
                var item = arr[i].Type;
                if (!dic.ContainsKey(item))
                {
                    dic.Add(item, 1);
                    ui.Print("Item = {0}: Count = {1}", item, dic[item]);
                }
                else
                {
                   // ui.Print("Item already does exist");
                  //  ui.Print(item);
                    // dic[item] = dic[item] + 1;
                    dic[item] += 1;
                    ui.Print("Item = {0}: Count = {1}", item, dic[item]);
                }
            }

        }


        /*
         * So far our object is not serialized, meaning it is not stored in file
         * We will search on fly the first vehicle based on its registration number
         */
        public void FindVehicleRg(Garage<Vehicle> garage)
        {
            Vehicle[] arr = garage.InternalArray;
            string registNumber = arr[0].RegistrationsNumber;
            var xxx = from v in arr
                      where v.RegistrationsNumber.Contains(registNumber)
                      select v;
            foreach (var i in xxx)
            {
                ui.Print(i);
            }
        }

        /*
         Find vehicles based on color and number of wheels
        */
        public void FindVehicleCW(/*Garage<Vehicle> garage,*/ string color, int numberOfWheeels)
        {
            Vehicle[] arr = garage.InternalArray;
            var xxx = from v in arr
                      where v.NumberOfWheels.Equals(numberOfWheeels) && v.Color.Contains(color)
                      select v;
            foreach (var i in xxx)
            {
                ui.Print(i);
            }
        }

        /*
         * Find vehicle based on number of wheels and type 
         */
        public void FindVehicleWT(Garage<Vehicle> garage, string type, int numberOfWheeels)
        {
            
            Vehicle[] arr = garage.InternalArray;
            var xxx = from v in arr
                      where v.NumberOfWheels.Equals(numberOfWheeels) && v.Type.Contains(type)
                      select v;
            foreach (var i in xxx)
            {
                ui.Print(i);
            }

        }
        public void FindVehicleC(Garage<Vehicle> garage, string color)
        {
            Vehicle[] arr = garage.InternalArray;
            var xxx = from v in arr
                      where v.Color.Equals(color)
                      select v;
            foreach (var i in xxx)
            {
                ui.Print(i);
            }

        }

        public void FindVehicleByProp(string type = "", string color = "", int numberOfWheels = -1)
        {
            var query = garage.Select(v => v);   // get all of the vehicles

            if (type != ""){ query = query.Where(v => v.Type == type);}
            if (color != ""){ query = query.Where(v => v.Color == color);}
            if (numberOfWheels != -1){ query = query.Where(v => v.NumberOfWheels == numberOfWheels);}

            var result = query.ToList();

            foreach (var item in result)
            {
                ui.Print(item);
            }
        }














    }
}
