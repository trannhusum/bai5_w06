using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5_w06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int[] arr = new int[100000];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (int)rd.Next(500);
            }

            StopWatch sw = new StopWatch();
            sw.Start();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                int minCurrent = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (minCurrent > arr[j])
                    {
                        minCurrent = arr[j];
                        minIndex = j;
                    }
                }
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
            sw.Stop();
            Console.WriteLine("Thoi gian chay: " + sw.GetElapsedTime());

            Console.ReadKey();
        }
    }
}
