using System;
namespace tablewith_privateconst
{
    public class take
    {
        public static int num;
        private take()
        {
            Console.WriteLine("Private constructor executed");
        }
    }
    class program
    {
        static void Main()
        {
            int i;
            take.num = 9;
            Console.WriteLine($"Table of {take.num}");
            for (i = 1; i < 11; i++)
                Console.WriteLine("{0} * {1} = {2} ",take.num,i,take.num*i);
            Console.ReadKey();
        }
      }
    }
