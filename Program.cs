using System;
using System.Linq;

namespace _17.LinqSingle
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[] {1};    // here 3 is non repeating number
            //Console.WriteLine(numbers.Single()); //single works with collection of 1 item ! , if we have { ,,2,3...} throws exception !

            int[] numbers = new int[] {1, 2 , 2, 3, 4 };
            Console.WriteLine(numbers.Single(x => x == 2)); //take from the row only tjhis elements that answeres the lambda condition = 2
            // if we have more than one matching elemetn it will trow an Exception -> mathing more than one elelment
        }
    }
}
