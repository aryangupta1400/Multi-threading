using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multi_threading
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            // Creating objects to execute the thread
            Thread firstThread = new Thread(MethodForFirstThread);

            Thread secondThread = new Thread(MethodForSecondThread);

            Thread thirdThread = new Thread(MethodForThirdThread);

            // execution of thread
            firstThread.Start();
            secondThread.Start();
            thirdThread.Start();

            Console.ReadKey();
        }

        // Method to execute using First Thread
        public static void MethodForFirstThread()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("First Method: " + i);

                if (i == 2)
                    Thread.Sleep(4000);
            }
        }

        // Method to execute using Second Thread
        public static void MethodForSecondThread()
        {
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("Second Method: " + j);

                if (j == 2)
                    Thread.Sleep(4000);
            }
        }

        // Method to execute using Third Thread
        public static void MethodForThirdThread()
        {
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("Third Method: " + j);
            }
        }
    }    
}
