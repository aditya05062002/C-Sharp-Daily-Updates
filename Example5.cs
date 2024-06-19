/*using System;
using System.Threading;

namespace MultithreadingExample
{
    class Multithreading
    {
        static void Main(string[] args)
        {
            // Create and start Thread 1
            Thread thread1 = new Thread(new ThreadStart(Task1));
            thread1.Name = "Thread 1";
            thread1.Start();

            // Create and start Thread 2
            Thread thread2 = new Thread(new ThreadStart(Task2));
            thread2.Name = "Thread 2";
            thread2.Start();

            // Create and start Thread 3
            Thread thread3 = new Thread(new ThreadStart(Task3));
            thread3.Name = "Thread 3";
            thread3.Start();

            // Wait for all threads to complete
            thread1.Join();
            thread2.Join();
            thread3.Join();

            Console.WriteLine("All threads have completed their tasks.");
        }

        static void Task1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} is running iteration {i}");
                Thread.Sleep(1000); // Simulate some work with a 1 second delay
            }
        }

        static void Task2()
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} is running iteration {i}");
                Thread.Sleep(1500); // Simulate some work with a 1.5 second delay
            }
        }

        static void Task3()
        {
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} is running iteration {i}");
                Thread.Sleep(2000); // Simulate some work with a 2 second delay
            }
        }
    }
}
*/