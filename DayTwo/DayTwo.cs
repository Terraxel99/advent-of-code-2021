namespace Day2
{
    using Common;
    using Day2.Models;

    public class DayTwo : IDay
    {
        public void Solve()
        {
            var instructions = FileParser.ParseInput<IEnumerable<MoveInstruction>>("inputDayTwo.txt", (lines) =>
            {
                return lines.Select(line =>
                {
                    var splittedLine = line.Split(' ');
                    return new MoveInstruction(this.CreateDirectionEnum(splittedLine[0]), int.Parse(splittedLine[1]));
                });
            });

            this.SolvePartOne(instructions);
            this.SolvePartTwo(instructions);
        }

        private void SolvePartOne(IEnumerable<MoveInstruction> instructions)
        {
            var submarine = new Submarine();
            submarine.Move(instructions);

            SolutionWriter.WritePartOneAnswer((submarine.HorizontalPosition * submarine.Depth).ToString());
        }

        private void SolvePartTwo(IEnumerable<MoveInstruction> instructions)
        {
            var submarine = new AimSubmarine();
            submarine.Move(instructions);

            SolutionWriter.WritePartTwoAnswer((submarine.HorizontalPosition * submarine.Depth).ToString());
        }

        private Direction CreateDirectionEnum(string text)
        {
            switch (text)
            {
                case "forward":
                    return Direction.Forward;

                case "up":
                    return Direction.Up;

                case "down":
                    return Direction.Down;

                default:
                    throw new NotSupportedException("Invalid direction !");
            }
        }
    }
}
