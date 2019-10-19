using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Dog
    {

        public void Voice(int count)
        {

            for (int i = 0; i < count; i++)
            {
                Console.Write(" Gav;");

            }
            Console.WriteLine();

        }

        public void GetAge()
        {

            Random random = new Random();
            int age = random.Next(15);
            Console.WriteLine(age);

        }


    }
}
