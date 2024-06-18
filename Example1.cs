/*using System;

namespace Car
{
    // Base class
    class Car
    {
        // Encapsulated fields
        private string make;
        private string model;
        private int year;

        // Constructor
        public Car(string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }

        // Public properties for encapsulation
        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        // Virtual method for polymorphism
        public virtual void Drive()
        {
            Console.WriteLine("Driving a car.");
        }

        // Method to display car details
        public void DisplayInfo()
        {
            Console.WriteLine($"Car Info: {year} {make} {model}");
        }
    }

    // Derived class
    class ElectricCar : Car
    {
        private int batteryCapacity;

        // Constructor
        public ElectricCar(string make, string model, int year, int batteryCapacity)
            : base(make, model, year)
        {
            this.batteryCapacity = batteryCapacity;
        }

        // Public property for encapsulation
        public int BatteryCapacity
        {
            get { return batteryCapacity; }
            set { batteryCapacity = value; }
        }

        // Overridden method for polymorphism
        public override void Drive()
        {
            Console.WriteLine("Driving an electric car.");
        }

        // Method to display electric car details
        public void DisplayElectricCarInfo()
        {
            DisplayInfo();
            Console.WriteLine($"Battery Capacity: {batteryCapacity} kWh");
        }
    }

    // Derived class
    class GasolineCar : Car
    {
        private int fuelCapacity;

        // Constructor
        public GasolineCar(string make, string model, int year, int fuelCapacity)
            : base(make, model, year)
        {
            this.fuelCapacity = fuelCapacity;
        }

        // Public property for encapsulation
        public int FuelCapacity
        {
            get { return fuelCapacity; }
            set { fuelCapacity = value; }
        }

        // Overridden method for polymorphism
        public override void Drive()
        {
            Console.WriteLine("Driving a gasoline car.");
        }

        // Method to display gasoline car details
        public void DisplayGasolineCarInfo()
        {
            DisplayInfo();
            Console.WriteLine($"Fuel Capacity: {fuelCapacity} liters");
        }
    }

    class Cars
    {
        static void Main(string[] args)
        {
            // Create instances of ElectricCar and GasolineCar
            ElectricCar tesla = new ElectricCar("Tata", "Nexon", 2022, 300);
            GasolineCar ford = new GasolineCar("Ford", "Mustang", 2022, 60);

            // Display details and drive the cars
            tesla.DisplayElectricCarInfo();
            tesla.Drive();

            Console.WriteLine();

            ford.DisplayGasolineCarInfo();
            ford.Drive();
            Console.ReadLine();
        }
    }
}
*/