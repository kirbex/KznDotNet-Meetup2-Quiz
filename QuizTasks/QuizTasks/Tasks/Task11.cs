// Что выведен данный код?

namespace QuizTasks.Tasks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal static class Task11
    {
        private static void Main()
        {
            Console.WriteLine(GetSmallNumbers().First());
            Console.ReadLine();
        }

        private static IEnumerable<int> GetSmallNumbers()
        {
            try
            {
                yield return 1;
                yield return 2;
            }
            finally
            {
                Console.Write("Foo");
            }
        }
    }
}
