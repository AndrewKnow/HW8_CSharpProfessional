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


            Console.WriteLine("Обычное сложение:");
            Console.WriteLine($" {implamentations.AddingArrayNumbers(intArray1)}");
            Console.WriteLine($" {implamentations.AddingArrayNumbers(intArray2)}");
            Console.WriteLine($" {implamentations.AddingArrayNumbers(intArray3)}");

        }
    }
}