using System.Transactions;

namespace Mean_Value_Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double meanValue = 0;
            int numberOfInputs = 0;
            int totalInputsSum = 0;

            while (true)
            {
                Console.WriteLine("Enter integer of your choice:");
                int input = Convert.ToInt32(Console.ReadLine());
                numberOfInputs++;
               
                totalInputsSum += input;

                Console.WriteLine("Sum of all integers: " + totalInputsSum.ToString());
                Console.WriteLine("Number of integers: " +  numberOfInputs.ToString());
                Console.WriteLine();

                meanValue = (totalInputsSum + .0) / numberOfInputs;

                Console.WriteLine("Mean Value: " + meanValue);
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
