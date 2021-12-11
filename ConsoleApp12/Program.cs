using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "  Cumlede soz sayini tapmaq ucun alqoritm  ";
            string result = String.Empty;
            
            string[] arr = str.Split(' ');
            int say = 0;
            

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != result)
                {
                    say++;
                }
            }
            Console.WriteLine(say);
           
            
        }
    }
}
