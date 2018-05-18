using System;
using System.Runtime.CompilerServices;

namespace QuizTasks.Tasks
{
    internal static class IntExt
    {
        public static TaskAwaiter GetAwaiter(this int t)
        {
            return new TaskAwaiter();
        }
    }

    internal static class Task7
    {
        // Можно ли заставить скомплироваться код: 
        // Нет
        // Да, это поддерживается из коробки
        // Да, надо реализовать метод GetAwaiter
        // Да, надо унаследоваться от типа Int32 и переопределить метод WaitAsync
        private static async void Main() => await 50;
    }
}
