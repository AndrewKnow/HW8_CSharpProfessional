using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_CSharpProfessional
{
    public class Implamentations
    {
        /// <summary>
        /// Наполнение массива
        /// </summary>
        /// <param name="arrLength"></param>
        /// <returns>Массив</returns>
        public int[] CreateArray(int arrLength )
        {
            var arr = new int[arrLength];
            for (int i = 0; i < arrLength; i++)
            {
                arr[i] = i + 1;
            }

            return arr;
        }

        /// <summary>
        /// Сложение элементов массива и замер времени
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>Сумма чсиел массива и время суммирования</returns>
        public (long, long) SimpleSummation(int[] arr)
        {
            var sw = new Stopwatch();
            sw.Start();

            long sum = 0;

            foreach (var item in arr)
                sum += item;
  
            sw.Stop();

            return (sum, sw.ElapsedMilliseconds);
        }

        /// <summary>
        /// Для параллельного суммирования
        /// </summary>
        /// <param name="arr"></param>
        /// <returns> Сумма чсиел массива </returns>
        public long Summation(int[] arr)
        {
            long sum = 0;

            foreach (var item in arr)
                sum += item;

            return sum;
        }

        /// <summary>
        /// Параллельное (для реализации использовать Thread, например List)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public (long, long) ThreadSummation(int[] arr)
        {
            var sw = new Stopwatch();
            sw.Start();

            long sum = 0;

            var splitArr = new List<int[]>();
            var z = arr.Length / 5;

            for (int i = 0; i < 5; i++)
            {
                splitArr.Add(arr.Skip(z * i).Take(z).ToArray());
            }

            foreach (var tempArray in splitArr)
            {
                var thread = new Thread(() => sum += Summation(tempArray));
                thread.Start();
                thread.Join();
            }


            sw.Stop();

            return (sum, sw.ElapsedMilliseconds);
        }

        /// <summary>
        /// Параллельное с помощью LINQ
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public (long, long) LINQSummation(int[] arr)
        {
            var sw = new Stopwatch();
            sw.Start();

            var newArr = arr.Select(i => (long)i).ToArray();
            long sum = newArr.AsParallel().Sum();

            sw.Stop();

            return (sum, sw.ElapsedMilliseconds);
        }

    }
}
