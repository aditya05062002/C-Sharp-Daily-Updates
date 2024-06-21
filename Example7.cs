using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEx7
{
    public class Employee
    {
        // Base Class
        public int id;
        public string name;

        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;   
        }
        public Employee() { }
        public void DisplayEmp()
        {
            Console.WriteLine($"Id:{id}\tName:{name}");
        }
    }
    public class Devloper : Employee
    {
        //Derived class
        public Devloper(int id, string name) : base(id, name)
        {
            
        }
        public void IamDev()
        {
            Console.WriteLine("I am Devloper");
        }
    }
    public class Manager : Employee
    {
        //Derived class
        public Manager(int id, string name) : base(id,name)
        {
            
        }
        public void AssignTask()
        {
            Console.WriteLine("Assigen Taks ");
        }
    }
    internal class Example7
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(1 ,"Aditya");
            emp.DisplayEmp();
            Devloper dev = new Devloper(2,"Jill");
            dev.DisplayEmp();
            dev.IamDev();
            Manager manager = new Manager(3,"Max");
            manager.DisplayEmp();
            manager.AssignTask();

            Console.ReadLine();
        }

    }
}
