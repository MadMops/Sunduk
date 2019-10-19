using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class NumbersToy
    {
        private List<int> list;
        private MassiveManager manager;

        public NumbersToy(int k) //если создано пару конструкторов то использоваться будет конструктор который подходит под введенный параметр
        {
            Console.WriteLine("We created class NumberToys with int " + k);
        }

        public NumbersToy(string f)
        {
            Console.WriteLine("We created class NumberToys with string " + f);
        }

        public NumbersToy(List<int> listParam, MassiveManager managerParam)
        {
            list = listParam;
            manager = managerParam;
        }

        public NumbersToy()
        {
            Console.WriteLine("We created class NumberToys");
        }

        public List<int> FillMassive(int Max)
        {

            List<int> myList = new List<int>();
            Random rand = new Random();

            for (int i = 0; i < Max; i++)
            {
                myList.Add(rand.Next(100));

            }
            return myList;

        }

        private int MaxNumber(List<int> integers)

        {
            int temp = 0;

            for (int i = 0; i < integers.Count; i++) //count аналог lenght
            {
                if (temp < integers[i])
                    temp = integers[i];

            }

            return temp;
        }

        private int MinNumber(List<int> integers)

        {
            int temp = integers[0];

            for (int i = 0; i < integers.Count; i++) //count аналог lenght
            {
                if (temp > integers[i])
                    temp = integers[i];

            }

            return temp;
        }

        private int Average(List<int> integers)

        {
            int temp = 0;

            for (int i = 0; i < integers.Count; i++) //count аналог lenght
            {
                temp += integers[i];   // equal to temp = temp + integers[i];

            }

            temp /= integers.Count; // equal to temp = temp / integers.Count;

            return temp;
        }

        public void Calculate()
        {
            /*List<int> list = new List<int>(); //параметры передаются через круглые скобочки*/

            //MassiveManager manager = new MassiveManager(); // это другой(внешний) класс и для использ его функций необходимо созд экземпляр класса

            manager.Writer(list);

            int maxnumber = MaxNumber(list);

            int minnumber = MinNumber(list);

            int average = Average(list);

            Console.WriteLine("Max number = " + maxnumber);

            Console.WriteLine("Min number = " + minnumber);

            Console.WriteLine("Average = " + average);

            Console.ReadKey();
        }

    }
}
