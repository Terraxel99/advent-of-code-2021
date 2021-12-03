using Common;

namespace Day1
{
    public class DayOne : IDay
    {
        public void Solve()
        {
            var numbers = FileParser.ParseInput<IEnumerable<int>>("inputDayOne.txt", (lines) =>
            {
                return lines.Select(line => int.Parse(line));
            }).ToList();

            this.SolvePartOne(numbers);
            this.SolvePartTwo(numbers);
        }

        private void SolvePartOne(List<int> numbers)
        {
            int numberOfMeasurementsHigher = 0;
            int? previousMeasurement = null;

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentMeasurement = numbers[i];

                if (i > 0)
                {
                    if (currentMeasurement > previousMeasurement)
                    {
                        numberOfMeasurementsHigher++;
                    }
                }

                previousMeasurement = currentMeasurement;
            }

            SolutionWriter.WritePartOneAnswer(numberOfMeasurementsHigher.ToString());
        }
    
        private void SolvePartTwo(List<int> numbers)
        {
            int numberOfMeasurementsHigher = 0;
            int? previousMeasurement = null;

            for (int i = 0; i < numbers.Count - 2; i++)
            {
                var currentMeasurement = numbers[i] + numbers[i + 1] + numbers[i + 2];

                if (i > 0)
                {
                    if (currentMeasurement > previousMeasurement)
                    {
                        numberOfMeasurementsHigher++;
                    }
                }

                previousMeasurement = currentMeasurement;
            }

            SolutionWriter.WritePartTwoAnswer(numberOfMeasurementsHigher.ToString());
        }
    }
}
