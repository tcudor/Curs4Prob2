namespace ArrayExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = ConsoleHelper.ReadNumber("The size of the array = ", 3, 0);
            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                int element = ConsoleHelper.ReadNumber($"element[{i}] = ", 3, 0);
                array[i] = element;
            }

            ConsoleHelper.PrintArray("Array=", array);

            int minValue = ArrayHelper.Min(array);
            Console.WriteLine($"Min = {minValue}");

            int maxValue = ArrayHelper.Max(array);
            Console.WriteLine($"Max = {maxValue}");

            int sum = ArrayHelper.Sum(array);
            Console.WriteLine($"Sum = {sum}");

            double average = ArrayHelper.Average(array);
            Console.WriteLine($"Average = {average}");

            int[] reversedArray = ArrayHelper.ReverseArray(array);
            Console.WriteLine($"Reversed Array = [{string.Join(", ", reversedArray)}]");

            int elementToFind = ConsoleHelper.ReadNumber("Element to find = ", 3, 0);
            int frequency = ArrayHelper.Frequency(array, elementToFind);
            Console.WriteLine($"Frequency of {elementToFind} = {frequency}");
        }
    }
}