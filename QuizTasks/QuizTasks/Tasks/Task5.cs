// Что выведет данный код?

using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizTasks.Tasks
{
    internal static class Task5
    {
        private static void Main()
        {
            int counter = 0;
            var source = new List<byte> { 0, 0, 1, 0, 1 };

            var bytes = source.Where(x =>
            {
                counter++;
                return x > 0;
            });

            if (bytes.First() == bytes.Last()) Console.WriteLine(counter--);
            else Console.WriteLine(counter++);
        }
    }
}
