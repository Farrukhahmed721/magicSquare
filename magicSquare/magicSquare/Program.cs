using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magicSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int rowLength = arr.GetLength(0);
            int colLength = arr.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write("{0} ", arr[i, j]);
                }
                Console.WriteLine("\n");
            }
            int row1 = arr[0, 0] + arr[0, 1] + arr[0, 2];
            int row2 = arr[1, 0] + arr[1, 1] + arr[1, 2];
            int row3 = arr[2, 0] + arr[2, 1] + arr[2, 2];
            int leftdiagonal = arr[0, 0] + arr[1, 1] + arr[2, 2];
            int rightdiagonal = arr[0, 2] + arr[1, 1] + arr[2, 0];
            int col1= arr[0,0] + arr[1,0] + arr[2,0];
            int col2 = arr[0, 1] + arr[1, 1] +arr[2,1];
            int col3 = arr[0, 2] + arr[1, 2] + arr[2, 2];
            Console.WriteLine("sum of row1 is {0}" ,row1);
            Console.WriteLine("sum of row2 is {0}", row2);
            Console.WriteLine("sum of row2 is {0}", row3);
            Console.WriteLine("sum of left diagonal is {0}", leftdiagonal);
            Console.WriteLine("sum of right diagonal is {0}", rightdiagonal);
            Console.WriteLine("sum of col1 is {0}", col1);
            Console.WriteLine("sum of col2 is {0}", col2);
            Console.WriteLine("sum of col3 is {0}", col3);
            if (row1 == row2 && row1 == row3 && row1 == leftdiagonal && row1 == rightdiagonal && row1 == col1 && row1 == col2 && row1 == col3)
            {
                Console.WriteLine("It is a Magic Square");
            }
            else {
                Console.WriteLine("It is not a Magic Square");
            }
            Console.ReadLine();
        }
    }
}
