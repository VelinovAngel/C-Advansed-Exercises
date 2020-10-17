﻿using System;
namespace Parking
{
    public class Car
    {
        public Car(string manufacturer, string model, int year)
        {
            Manufacturer = manufacturer;
            Model = model;
            Year = year;
        }

        //•	Manufacturer: string
        //•	Model: string
        //•	Year: int

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public override string ToString()
        {
            return $"{this.Manufacturer} {this.Model} ({this.Year})";
        }

    }
}
