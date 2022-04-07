using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_HomeWork_2
{
    internal class Program
    {
        //
        public static string GetStringSummaNumber(string inStrData)
        {
            //разделение входной строки на массив подстрок по разделителю "пробел"
            string[] vWords = inStrData.Split(new char[] { ' ' }, 
                                              StringSplitOptions.RemoveEmptyEntries);

            //вычисление суммы 
            double sum = 0;
            foreach (string s in vWords) sum += Convert.ToDouble(s.Replace('.', ','));

            //
            return $"Сумма элементов строки {inStrData} равна: {sum}";
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Урок 4, домашнее задание № 2");

            //
            Console.Write("Введите набор чисел, разделенных пробелом: ");
            string inStr = Console.ReadLine();
            Console.WriteLine(GetStringSummaNumber(inStr));

            //
            Console.ReadLine();
        }
    }
}
