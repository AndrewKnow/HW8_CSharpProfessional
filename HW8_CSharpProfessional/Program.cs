namespace HW8_CSharpProfessional
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Implamentations implamentations = new Implamentations();

            var intArray1 = new int[1_00_000];
            var intArray2 = new int[1_000_000];
            var intArray3 = new int[10_000_000];

            int[][] listsArray = new int[][] { intArray1, intArray2, intArray3 };

            Console.WriteLine("Обычное сложение:");
            foreach (var arr in listsArray)
            {
                var createArr = implamentations.CreateArray(arr.Length);

                var (sum, time) = implamentations.SimpleSummation(createArr);
                Console.WriteLine($" Результат {sum} Время {time} мс");
            }

            Console.WriteLine();
            Console.WriteLine("Параллельное  сложение:");
            foreach (var arr in listsArray)
            {
                var createArr = implamentations.CreateArray(arr.Length);

                var (sum, time) = implamentations.ThreadSummation(createArr);
                Console.WriteLine($" Результат {sum} Время {time} мс");
            }

            Console.WriteLine();
            Console.WriteLine("Параллельное  сложение с помощью LINQ:");
            foreach (var arr in listsArray)
            {
                var createArr = implamentations.CreateArray(arr.Length);

                var (sum, time) = implamentations.ThreadSummation(createArr);
                Console.WriteLine($" Результат {sum} Время {time} мс");
            }


        }
    }
}