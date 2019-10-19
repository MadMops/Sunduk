using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Dog Chappi = new Dog();

            Chappi.Voice(10);

            Chappi.GetAge();

            var list = new List<int>();
            MassiveManager manager = new MassiveManager();

            list = manager.FillMassive(7);

            NumbersToy toys = new NumbersToy(list, new MassiveManager()); //toys - экземпляр класса, через экземпляр класса мы вызываем все методы класcа через точку


            toys.Calculate(); // включает в себя FillMAssive, Max Min Average number
            
            
            /*
            List<int> list = toys.FillMassive(10); //параметры передаются через круглые скобочки

            MassiveManager manager = new MassiveManager();

            manager.Writer(list);

            int maxnumber = toys.MaxNumber(list);

            

            int minnumber = toys.MinNumber(list);

            int average = toys.Average(list);

            Console.WriteLine("Max number = " + maxnumber);

            Console.WriteLine("Min number = " + minnumber);

            Console.WriteLine("Average = " + average);

            Console.ReadKey();
            */

            /*
            Vector vector = new Vector();

            double x = 10;

            double y = 5;

            double lenght = vector.Lenght(x, y);

            double scale = vector.Scale(2, 4, 6, 8);



           // Console.WriteLine("Vector coordinates: " + "X = " + x + " Y = " + y);
            Console.WriteLine("Vector coordinates:  X = {0} Y = {1} Lenght = {2}", x, y, lenght);

            Console.WriteLine("Vector lenght" + lenght);
            Console.WriteLine("Scale product of numbers" + scale);
            */

            Console.ReadKey();
        }

        static void Pass()
        {

            //вызов статического метода
            MassiveManager.MassiveManagerClassInfo();
            Console.ReadKey();

            // создание экземпляра класса, (без экземпляра класса с классом нельзя ничего делать по тому что он литейная форма)
            MassiveManager manager = new MassiveManager();

            List<int> listResult = manager.FillMassive(10);

            //int y = manager.F(69);

            manager.Writer(listResult);

            Console.ReadKey();

            List<int> manualList = new List<int> { 1, 5, 7, 6, 8 };

            manager.Writer(manualList);

            Console.ReadKey();

        }

    }

}
