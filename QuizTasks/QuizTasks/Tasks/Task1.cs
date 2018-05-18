// Что выведет данный код?

using System;

namespace QuizTasks.Tasks
{
    public class Foo<T>
    {
        public static int Bar;
    }

    internal static class Task1
    {
        private static void Main()
        {
            Foo<int>.Bar++;
            Console.WriteLine(Foo<double>.Bar);
        }
    }
}
