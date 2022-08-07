using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_of_positives_Sum_of_negatives
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] newArray = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15};

            int x = 0;

            int sum = 0;

            for (int i = 0; i < newArray.Length; i++)
            {

                if (newArray[i] > 0)
                {
                    x += 1;
                }
                
                else
                {
                    sum += newArray[i];
                }
                
            }
            Console.WriteLine(x);

            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}
