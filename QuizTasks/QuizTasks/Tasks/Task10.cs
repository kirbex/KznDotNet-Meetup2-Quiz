// Сколько SQL запросов будет выполнено?

namespace QuizTasks.Tasks
{
    using System.Linq;

    // Сколько SQL запросов будет выполнено: 1, 2, 3, 4

    ////internal static class Task10
    ////{
    ////    private static readonly CustomerDbContext Db = new CustomerDbContext();

    ////    private static IQueryable<Customer> GetCustomers() => Db.Customers;

    ////    private static IQueryable<Sale> GetSales() => from s in Db.Sales where s.IsPaid select s;

    ////    private static void Main()
    ////    {
    ////        var totals = (from s in GetSales()
    ////                      join c in GetCustomers() on s.CustomerId equals c.CustomerId
    ////                      group s.Amount by c into g
    ////                      select new { g.Key.CustomerId, g.Key.FirstName, g.Key.LastName, TotalAmount = g.Sum(a => a) })
    ////            .ToList();
    ////    }
    ////}
}
