// Что выведет данный код?

using System;

namespace QuizTasks.Tasks
{
    internal static class Task2
    {
        private static void Main()
        {
            Console.Write($"{new byte() == new byte()} {new byte[0] == new byte[0]}");            
        }
    }
}
