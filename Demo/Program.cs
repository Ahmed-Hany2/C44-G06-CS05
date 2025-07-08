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

            #region Two Dimensional Array
            int[,] marks = new int[2, 5]
            {
                 { 10, 20, 30, 40, 50 },
                { 80, 90, 50, 60, 50 }
            };
                marks[0, 0] = 10;
            marks[0, 1] = 20;
            marks[0, 2] = 30;
            marks[0, 3] = 40;
            marks[0, 4] = 50;
            marks[1, 0] = 80;
            marks[1, 1] = 90;
            marks[1, 2] = 50;
            marks[1, 3] = 60;
            marks[1, 4] = 50;
            Console.WriteLine($"Size of array => {numbers.Length}, Dimensions of array => {numbers.Rank}");

            for ( int i = 0; i < marks.GetLength(0); i++)
            {
                Console.WriteLine($"The grades of the student number {i + 1}");
                for( int j = 0; j < marks.GetLength(1);)
                {
                    Console.WriteLine($"The grade of the subject number {j + 1}");
                    bool isParsed = int.TryParse(Console.ReadLine(), out marks[i, j]);
                    if (isParsed)
                        ++j;
                }
                Console.WriteLine("======================================================");
            }

            Console.Clear();

            for (int i = 0; i < marks.GetLength(0); i++)
            {
                Console.WriteLine($"The grades of the student number {i + 1}");
                for (int j = 0; j < marks.GetLength(1); j++)
                {
                    Console.WriteLine($"The grade of the subject number {j + 1} => {marks[i, j]}");       
                }
                Console.WriteLine("======================================================");
            }

            #endregion




        }
    }
}
