using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Введение_в_Generics_homework_27._02._2023
{
    class Num<T>
    {
        private T a;
        private T b;

        public Num(T a, T b)
        {
            this.a = a;
            this.b = b;
        }
        public void Swap()
        {
            T c = a;
            a = b;
            b = c;
        }
        public void Print()
        {
            Console.WriteLine($"a = {a}\nb = {b}");
        }
    }

    internal class Program
    {
       

        static void Main(string[] args)
        {
            Num<int> num = new Num<int>(1, 5);
            num.Swap();
            num.Print();
            

        }
    }
}