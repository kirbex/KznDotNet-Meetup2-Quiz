// Что выведет данный код?

using System;
using System.Collections.Generic;

namespace QuizTasks.Tasks
{
    internal static class Task6
    {
        delegate void Printer();

        private static void Main()
        {
            List<Printer> printers = new List<Printer>();
            for (int i = 0; i < 10; i++)
            {
                printers.Add(delegate { Console.Write(i); });
            }

            foreach (var printer in printers)
            {
                printer();
            }
        }
    }
}
