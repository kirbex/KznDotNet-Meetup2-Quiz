using System;

namespace QuizTasks.Tasks
{
    internal static class Task8
    {
        // Answeres: true, false, runtime InvalidOperationException, не скомпилится

        private static void Main()
        {
            (int, (((int, double, string, int), string), int)) t1;
            t1 = (10, (((50, 0.0, "What a", 40), "Hello, bro"), 100500));
            Console.WriteLine(t1 == (10, (((50, 0.0, "What a", 40), "Hello, bro"), 100500)));
        }
    }
}
