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
        public long AddingArrayNumbers(int[] arr)
        {

            var sw = new Stopwatch();
            sw.Start();

            var sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];

            sw.Stop();

            return sw.ElapsedMilliseconds;
        }




    }
}
