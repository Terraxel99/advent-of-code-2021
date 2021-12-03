namespace Common
{
    public class SolutionWriter
    {
        public static void WriteDayNumber(int dayNumber)
            => Console.WriteLine($"Solutions of day number {dayNumber} : \n");

        public static void WritePartOneAnswer(string answer)
            => WriteAnswer(answer, 1);

        public static void WritePartTwoAnswer(string answer)
        {
            WriteAnswer(answer, 2);
            Console.WriteLine("\n");
        }

        private static void WriteAnswer(string answer, int partNumber)
            => Console.WriteLine($"\tThe solution of part {partNumber} is : {answer}");
    }
}
