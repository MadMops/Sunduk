using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MassiveManager
    {
        public List<int> AddElements(params int[] elements) // List int - это возвращаемый тип.
        {
            List<int> myList = new List<int>();
            myList.AddRange(elements);
            foreach (int e in elements)
            {

                myList.Add(e);

            }
            return myList;
        }
        public int F(int x) //int - это возвращаемый тип.
        {
            FillMassive(9);
            int y = 5 * x * x + 10 * 2 * x - 15;
            return y;

        }

        // Создать метод который возвращает список int, в метод передается количество элементов и он заполняется случайными числами

        public List<int> FillMassive(int count)
        {

            List<int> myList = new List<int>();
            Random rand = new Random();

            for (int i = 0; i < count; i++)
            {
                myList.Add(rand.Next(100));

            }
            return myList;

        }

        public void Writer(List<int> newList) // void - это возвращаемый тип.
        {

            for (int i = 0; i < newList.Count(); i++)
            {

                Console.WriteLine(newList[i]);

            }

        }

        public static void MassiveManagerClassInfo()
        {

            Console.WriteLine("This class should operate with list");

        }

    }
}
