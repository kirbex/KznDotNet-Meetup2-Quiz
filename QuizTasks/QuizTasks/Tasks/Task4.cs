using System;

namespace QuizTasks.Tasks
{
    internal static class Task4
    {
        private static void Main()
        {
            int i = 0;
            i += Increment(ref i);

            Console.WriteLine(i);
        }

        private static int Increment(ref int i)
        {
            return i++;
        }
    }
}
