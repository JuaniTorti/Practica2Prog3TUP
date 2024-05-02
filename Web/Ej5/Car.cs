﻿namespace Web.Ej5
{
    public class Car : IVehicle
    {
        public int Fuel { get; set; }

        public Car(int initialfuel)
        {
            Fuel = initialfuel; 
        }

        public string Drive()
        {
            if (Fuel > 0)
            {
                return "El coche esta siendo manejado";
            }

            return "";
        }
        public bool ChargeFuel(int cantFuel)
        {
            Fuel += cantFuel;
            return true;
        }
    }
}