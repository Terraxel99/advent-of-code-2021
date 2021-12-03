namespace Common
{
    using System.IO;

    public class FileParser
    {
        public static T ParseInput<T>(string filePath, Func<IEnumerable<string>, T> parser)
        {
            try
            {
                var lines = GetFileLines(filePath);
                return parser(lines);
            }
            catch (IOException)
            {
                Console.WriteLine("ERROR : An error occured while reading input file\n\nStackTrace :\n\n");
                throw;
            }
        }

        private static IEnumerable<string> GetFileLines(string filePath)
            // Inputs stored in root folder of solution. Feel free to modify the path here.
            => File.ReadAllLines($"{AppDomain.CurrentDomain.BaseDirectory}/../../../../Inputs/{filePath}");
    }
}
