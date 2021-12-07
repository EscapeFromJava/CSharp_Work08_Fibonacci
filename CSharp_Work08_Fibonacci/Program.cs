using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Work08_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер элемента: ");
            int size = Convert.ToInt32(Console.ReadLine());
            List<int> numbers = new List<int>(size);
            int x;
            if (size == 0 || size == 1)
                Console.WriteLine("Ответ 1");
            else
            {
                numbers.Add(1);
                numbers.Add(1);
                for (int i = 2; i < size; i++)
                {
                    x = numbers[i - 2] + numbers[i - 1];
                    numbers.Add(x);
                }
                Console.WriteLine("Элементу {0} соответствует = {1}", size, numbers[size - 1]);
            }
            Console.ReadKey();
        }
    }
}
