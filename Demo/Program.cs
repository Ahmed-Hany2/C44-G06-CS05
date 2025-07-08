namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region One Dimensional Array
            int[] numbers;
            numbers = new int[3];
            // [0, 0 ,0] Default Values
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            numbers[0] = 10;    
            numbers[1] = 20;
            numbers[2] = 30;
            // [10, 20, 30]
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            Console.WriteLine($"Size of array => {numbers.Length}, Dimensions of array => {numbers.Rank}");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            #endregion


        }
    }
}
