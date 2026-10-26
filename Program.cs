using System;
using System.Linq;
using System.Threading.Tasks;

// Small C# sample: LINQ, async/await, records, pattern matching.
var orders = new[] { new Order(1, 120m, true), new Order(2, 45m, false)};
var total = orders.Where(o => o.Paid).Sum(o => o.Amount);
Console.WriteLine($"Paid total: {total:C}");
await Task.Delay(1);
record Order(int Id, decimal Amount, bool Paid);
