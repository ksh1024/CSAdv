using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSAdv
{
    class Wanted<T>
    {
        public T Value;
        public Wanted(T value)
        {
            Value = value;
        }
    }
    class Needed<T, V>
    {
        public T Value1;
        public V Value2;
        public Needed(T value1, V value2)
        {
            Value1 = value1;
            Value2 = value2;
        }
    }

    class SpecialNeeded<T, U>
        where T: IComparable
        where U: IComparable, IDisposable
    {   
        public T Value1;
        public U Value2;
        public SpecialNeeded(T value1, U value2)
        {
            Value1 = value1;
            Value2 = value2;
        }
    }

    class SquareCalculator
    {
        public int this[int i] // indexer
        {
            get { return i * i; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Wanted<int> wantedInt = new Wanted<int>(30302);
            Wanted<string> wantedString = new Wanted<string>("hello world");
            Wanted<double> wantedDouble = new Wanted<double>(33.3);

            Console.WriteLine(wantedInt.Value);
            Console.WriteLine(wantedString.Value);
            Console.WriteLine(wantedDouble.Value);

            SquareCalculator s = new SquareCalculator();
            Console.WriteLine(s[255]);

            Console.Write("숫자 입력: ");
            int output;
            bool result = int.TryParse(Console.ReadLine(), out output);
            if (result)
            {
                Console.WriteLine("입력한 숫자: " + output);
            }
            else
            {
                Console.WriteLine("숫자를 입력해주세요." + output);
            }

        }
    }
}
