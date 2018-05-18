using System;
using System.Xml;

namespace QuizTasks.Tasks
{
    internal static class Task3
    {
        private static void Main()
        {
            Bar(XmlWriter => XmlWriter.Flush());
            Bar(XmlReader => XmlReader.Flush());
        }

        private static void Bar(Action<XmlWriter> x)
        {
            Console.Write("W");
        }

        private static void Bar(Action<XmlReader> x)
        {
            Console.Write("R");
        }

    }
}
