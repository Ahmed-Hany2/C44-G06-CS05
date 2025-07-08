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

            #region Array Creation Ways
            int[] numbers01 = new int[3];
            int[] numbers02 = new int[3] { 1, 2, 3};
            int[] numbers03 = new int[] { 1, 2, 3, 4, 5};
            int[] numbers04 = { 1, 2, 3, 4, 5 };

            #endregion




        }
    }
}
