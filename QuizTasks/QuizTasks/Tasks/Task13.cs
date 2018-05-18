using System;

namespace QuizTasks.Tasks
{
    internal static class Task13
    {
        private static void Main()
        {
            new Baz();
            Console.ReadLine();
        }

        class Foo
        {
            protected class Quux
            {
                public Quux()
                {
                    Console.WriteLine("Foo.Quux()");
                }
            }
        }
        class Bar : Foo
        {
            new class Quux
            {
                public Quux()
                {
                    Console.WriteLine("Bar.Quux()");
                }
            }
        }
        class Baz : Bar
        {
            public Baz()
            {
                new Quux();
            }
        }
    }
}
