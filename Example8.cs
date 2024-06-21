using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class Product
    {
        private string name;
        private double price;

        public double Price {
            get { return price; } 
            set {
                if (value < 0)
                {
                    throw new Exception("Price Must Be Greater Than \"O\"");
                }
                price = value; } 
        }


        public void SetName(string name)
            { 
            this.name = name; 
        }
        public void SetPrice(double price) {
            if (price < 0)
            {
                throw new Exception("Price Can't be Negative");
                
            }
            else
            {
                this.price = price;
            }
        }
        public string GetName() { return this.name; }
        public double GetPrice() { return this.price; }

    }
    internal class Example8
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.SetName("I Phone15");
            product.Price = -20000;            
            Console.WriteLine($"Product Name:{product.GetName()} \nProduct Price: {product.Price}");
            
            Console.ReadLine();
        }
    }
}
