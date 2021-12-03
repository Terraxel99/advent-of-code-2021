using Common;

using Day1;
using Day2;

Console.WriteLine("Advent Of Code 2021 By Terraxel");

// ================== Resolutions ==================

static void DisplaySolutions(List<IDay> days)
{
    Console.Write("\n");

    for (int i = 0; i < days.Count; i++)
    {
        SolutionWriter.WriteDayNumber(i + 1);
        days[i].Solve();
    }
}

var days = new List<IDay>()
{
    new DayOne(),
    new DayTwo(),
};

DisplaySolutions(days);

// =================================================


