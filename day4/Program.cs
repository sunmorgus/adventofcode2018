using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace day4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> logLineStrings = ReadLogFile(false);

            List<LogLine> logLines = ParseAndSortLines(logLineStrings);

            FindGuardSleepingMinutes(logLines);

            Console.WriteLine("Done!");
        }

        private static void FindGuardSleepingMinutes(List<LogLine> logLines)
        {
            Dictionary < int, (int slept, Dictionary<int, int> minute) > guards = new Dictionary < int, (int slept, Dictionary<int, int> minute) > ();

            int currentGuard = logLines[0].GuardId;
            DateTime currentTimestamp = logLines[0].Timestamp;
            DateTime fallAsleepTime = new DateTime();
            Dictionary<int, int> currentGuardMinutes = new Dictionary<int, int>();
            for (int i = 1; i < logLines.Count; i++)
            {
                if (!guards.ContainsKey(currentGuard))
                {
                    currentGuardMinutes = new Dictionary<int, int>();
                    guards.Add(currentGuard, (slept: 0, minute: currentGuardMinutes));
                }
                else
                {
                    currentGuardMinutes = guards[currentGuard].minute;
                }

                LogLine logLine = logLines[i];

                if (logLine.GuardId == 0)
                {
                    if (logLine.Action == "falls asleep")
                    {
                        fallAsleepTime = logLine.Timestamp;

                    }

                    if (logLine.Action == "wakes up")
                    {
                        TimeSpan elapsed = logLine.Timestamp.Subtract(fallAsleepTime);
                        int minutes = (int) elapsed.TotalMinutes;

                        for (int j = fallAsleepTime.Minute; j < logLine.Timestamp.Minute; j++)
                        {
                            if (currentGuardMinutes.ContainsKey(j))
                            {
                                currentGuardMinutes[j] += 1;
                            }
                            else
                            {
                                currentGuardMinutes.Add(j, 1);
                            }
                        }

                        var guardsTuple = guards[currentGuard];
                        guardsTuple.slept += minutes;
                        guardsTuple.minute = currentGuardMinutes;
                        guards[currentGuard] = guardsTuple;
                    }
                }
                else
                {
                    currentGuard = logLine.GuardId;
                }
            }

            guards = guards.OrderByDescending(g => g.Value.slept).ToDictionary(g => g.Key, g => g.Value);

            int mostGuard = guards.First().Key;
            int mostMinutesSlept = guards.First().Value.slept;
            int mostMinute = guards.First().Value.minute.OrderByDescending(m => m.Value).First().Key;

            int answer = mostGuard * mostMinute;

            Console.WriteLine($"Part 1 Answer: {answer}");

            int part2GuardId = 0;
            int part2Minute = 0;
            int part2MinuteCount = 0;
            foreach (var part2Guard in guards)
            {
                var part2Value = part2Guard.Value.minute;
                if (part2Value.Count > 0)
                {
                    KeyValuePair<int, int> count = part2Value.OrderByDescending(m => m.Value).First();

                    if (count.Value > part2MinuteCount)
                    {
                        part2MinuteCount = count.Value;
                        part2GuardId = part2Guard.Key;
                        part2Minute = count.Key;
                    }
                }
            }

            int part2Answer = part2GuardId * part2Minute;

            Console.WriteLine($"Part 2 Answer: {part2Answer}");
        }

        private static List<LogLine> ParseAndSortLines(List<string> logLines)
        {
            // Example log line: [1518-05-19 23:50] Guard #2447 begins shift
            List<LogLine> parsedLogLines = new List<LogLine>();
            foreach (string line in logLines)
            {
                LogLine logLine = new LogLine();
                string ts = line.Substring(1, line.IndexOf(']') - 1);
                DateTime timestamp = DateTime.Parse(ts);

                string action = line.Split(']') [1];
                int guardId = line.Contains("#") ? int.Parse(line.Split('#') [1].Split(' ') [0]) : 0;

                if (guardId != 0)
                {
                    logLine.GuardId = guardId;
                }
                logLine.Action = action.Trim();
                logLine.Timestamp = timestamp;

                parsedLogLines.Add(logLine);
            }

            parsedLogLines = parsedLogLines.OrderBy(l => l.Timestamp).ToList();

            return parsedLogLines;
        }

        private static List<string> ReadLogFile(bool useExample)
        {
            return File.ReadAllLines(useExample ? "./logexample.txt" : "./log.txt").ToList();
        }
    }
}
