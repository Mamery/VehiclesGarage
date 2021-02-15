using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace VehiclesGarage
{
    [Serializable()]
    class Vehicle : ISerializable

    {

        private string registrationsNumber;
        private string color;
        private double width;
        private double length;
        private double height;
        private string brand;
        private int numberOfWheels;
        private string type;


        public string RegistrationsNumber 
        {
            get { return registrationsNumber; }
            set { registrationsNumber = value; }

        }
        public string Color 
        {
            get { return color; }
            set { color = value; }
        }
        public double Width 
        {
            get { return width; }
            set { width = value; }
        }
        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public string Brand 
        {
            get { return brand; }
            set {brand = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public int NumberOfWheels
        {
            get { return numberOfWheels; }
            set { numberOfWheels = value; }
        }

        public Vehicle(string color, double width, double length, double height, string brand, int numberofwheels,string type)
        {
             this.RegistrationsNumber = "ABC" + new Random().Next(100, 199);
            this.Color = color;
            this.Width = width;
            this.Length = length;
            this.Height = height;
            this.Brand = brand;
            this.NumberOfWheels = numberofwheels;
            this.Type = type;
        }

        public override string ToString()
        {
            return String.Format("Vehicle Type = {0},RegistrationNumber = {1},Color={2}",type, registrationsNumber,color);
        }

        //Get object data in file
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("RegistrationsNumber", registrationsNumber);
            info.AddValue("Color", color);
            info.AddValue("width", width);
            info.AddValue("length", length);
            info.AddValue("height", height);
            info.AddValue("brand", brand);
            info.AddValue("NumberOfWheels",numberOfWheels);
            info.AddValue("type", type);
          
        }

        //Retreive object from file
        public Vehicle(SerializationInfo info, StreamingContext context)
        {
          
            RegistrationsNumber = (string)info.GetValue("RegistrationsNumber", typeof(string));
            Color = (string)info.GetValue("Color", typeof(string));
            Width = (double)info.GetValue("Width", typeof(double));
            Length = (double)info.GetValue("Length", typeof(double));
            Brand = (string)info.GetValue("Brand", typeof(double));
            Type = (string)info.GetValue("Type", typeof(string));
            NumberOfWheels = (int)info.GetValue("NumberOfWheels", typeof(int));
            Type = (string)info.GetValue("Type", typeof(string));



        }







    }
}

